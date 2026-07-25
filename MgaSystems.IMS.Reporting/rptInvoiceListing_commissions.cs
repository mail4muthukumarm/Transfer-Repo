// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.rptInvoiceListing_commissions
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

using DDCssLib;
using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.SectionReportModel;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Reporting;

public class rptInvoiceListing_commissions : MGAReport
{
  private Label Label1;
  private Label Label2;
  private Label Label3;
  private Label Label;
  private TextBox txtPayee;
  private TextBox txtCommissionPercent;
  private TextBox txtCommissionAmount;
  private TextBox TextBox;
  private Label Label4;
  private TextBox PayeeAmt1;

  public rptInvoiceListing_commissions(DataView dvCommissions)
  {
    this.InitializeComponent();
    this.DataSource = (object) dvCommissions;
  }

  private void InitializeComponent()
  {
    ResourceManager resourceManager = new ResourceManager(typeof (rptInvoiceListing_commissions));
    this.Detail = new Detail();
    this.txtPayee = new TextBox();
    this.txtCommissionPercent = new TextBox();
    this.txtCommissionAmount = new TextBox();
    this.TextBox = new TextBox();
    this.ghCommissions = new GroupHeader();
    this.Label1 = new Label();
    this.Label2 = new Label();
    this.Label3 = new Label();
    this.Label = new Label();
    this.gfCommissions = new GroupFooter();
    this.Label4 = new Label();
    this.PayeeAmt1 = new TextBox();
    ((ISupportInitialize) this.txtPayee).BeginInit();
    ((ISupportInitialize) this.txtCommissionPercent).BeginInit();
    ((ISupportInitialize) this.txtCommissionAmount).BeginInit();
    ((ISupportInitialize) this.TextBox).BeginInit();
    ((ISupportInitialize) this.Label1).BeginInit();
    ((ISupportInitialize) this.Label2).BeginInit();
    ((ISupportInitialize) this.Label3).BeginInit();
    ((ISupportInitialize) this.Label).BeginInit();
    ((ISupportInitialize) this.Label4).BeginInit();
    ((ISupportInitialize) this.PayeeAmt1).BeginInit();
    ((ISupportInitialize) this).BeginInit();
    ((Section) this.Detail).Controls.AddRange(new ARControl[4]
    {
      (ARControl) this.txtPayee,
      (ARControl) this.txtCommissionPercent,
      (ARControl) this.txtCommissionAmount,
      (ARControl) this.TextBox
    });
    ((Section) this.Detail).Height = 0.125f;
    ((Section) this.Detail).Name = "Detail";
    ((ARControl) this.txtPayee).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtPayee).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtPayee).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtPayee).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtPayee).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtPayee).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtPayee).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtPayee).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtPayee).DataField = "Payee";
    ((ARControl) this.txtPayee).Height = 0.125f;
    ((ARControl) this.txtPayee).Left = 0.0f;
    ((ARControl) this.txtPayee).Name = "txtPayee";
    this.txtPayee.Style = "font-size: 7pt";
    this.txtPayee.Text = (string) null;
    ((ARControl) this.txtPayee).Top = 0.0f;
    ((ARControl) this.txtPayee).Width = 29f / 16f;
    ((ARControl) this.txtCommissionPercent).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtCommissionPercent).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtCommissionPercent).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtCommissionPercent).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtCommissionPercent).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtCommissionPercent).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtCommissionPercent).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtCommissionPercent).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtCommissionPercent).DataField = "PayeePercentRate";
    ((ARControl) this.txtCommissionPercent).Height = 0.125f;
    ((ARControl) this.txtCommissionPercent).Left = 3.875f;
    ((ARControl) this.txtCommissionPercent).Name = "txtCommissionPercent";
    this.txtCommissionPercent.OutputFormat = resourceManager.GetString("txtCommissionPercent.OutputFormat");
    this.txtCommissionPercent.Style = "font-size: 7pt";
    this.txtCommissionPercent.Text = (string) null;
    ((ARControl) this.txtCommissionPercent).Top = 0.0f;
    ((ARControl) this.txtCommissionPercent).Width = 11f / 16f;
    ((ARControl) this.txtCommissionAmount).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtCommissionAmount).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtCommissionAmount).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtCommissionAmount).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtCommissionAmount).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtCommissionAmount).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtCommissionAmount).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtCommissionAmount).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtCommissionAmount).DataField = "PayeeAmt";
    ((ARControl) this.txtCommissionAmount).Height = 0.125f;
    ((ARControl) this.txtCommissionAmount).Left = 73f / 16f;
    ((ARControl) this.txtCommissionAmount).Name = "txtCommissionAmount";
    this.txtCommissionAmount.OutputFormat = resourceManager.GetString("txtCommissionAmount.OutputFormat");
    this.txtCommissionAmount.Style = "font-size: 7pt; text-align: right";
    this.txtCommissionAmount.Text = (string) null;
    ((ARControl) this.txtCommissionAmount).Top = 0.0f;
    ((ARControl) this.txtCommissionAmount).Width = 17f / 16f;
    ((ARControl) this.TextBox).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox).DataField = "PaymentDesc";
    ((ARControl) this.TextBox).Height = 0.125f;
    ((ARControl) this.TextBox).Left = 29f / 16f;
    ((ARControl) this.TextBox).Name = "TextBox";
    this.TextBox.Style = "font-size: 7pt";
    this.TextBox.Text = (string) null;
    ((ARControl) this.TextBox).Top = 0.0f;
    ((ARControl) this.TextBox).Width = 33f / 16f;
    ((Section) this.ghCommissions).Controls.AddRange(new ARControl[4]
    {
      (ARControl) this.Label1,
      (ARControl) this.Label2,
      (ARControl) this.Label3,
      (ARControl) this.Label
    });
    this.ghCommissions.Height = 3f / 16f;
    ((Section) this.ghCommissions).Name = "ghCommissions";
    ((ARControl) this.Label1).Height = 3f / 16f;
    this.Label1.HyperLink = (string) null;
    ((ARControl) this.Label1).Left = 0.0f;
    ((ARControl) this.Label1).Name = "Label1";
    this.Label1.Style = "font-size: 7pt; font-weight: bold; vertical-align: bottom";
    this.Label1.Text = "Payee";
    ((ARControl) this.Label1).Top = 0.0f;
    ((ARControl) this.Label1).Width = 29f / 16f;
    ((ARControl) this.Label2).Height = 3f / 16f;
    this.Label2.HyperLink = (string) null;
    ((ARControl) this.Label2).Left = 3.875f;
    ((ARControl) this.Label2).Name = "Label2";
    this.Label2.Style = "font-size: 7pt; font-weight: bold; vertical-align: bottom";
    this.Label2.Text = "Payee %";
    ((ARControl) this.Label2).Top = 0.0f;
    ((ARControl) this.Label2).Width = 11f / 16f;
    ((ARControl) this.Label3).Height = 3f / 16f;
    this.Label3.HyperLink = (string) null;
    ((ARControl) this.Label3).Left = 73f / 16f;
    ((ARControl) this.Label3).Name = "Label3";
    this.Label3.Style = "font-size: 7pt; font-weight: bold; text-align: right; vertical-align: bottom";
    this.Label3.Text = "Payee Amount";
    ((ARControl) this.Label3).Top = 0.0f;
    ((ARControl) this.Label3).Width = 17f / 16f;
    ((ARControl) this.Label).Height = 3f / 16f;
    this.Label.HyperLink = (string) null;
    ((ARControl) this.Label).Left = 29f / 16f;
    ((ARControl) this.Label).Name = "Label";
    this.Label.Style = "font-size: 7pt; font-weight: bold; vertical-align: bottom";
    this.Label.Text = "Payment Description";
    ((ARControl) this.Label).Top = 0.0f;
    ((ARControl) this.Label).Width = 33f / 16f;
    ((Section) this.gfCommissions).Controls.AddRange(new ARControl[2]
    {
      (ARControl) this.Label4,
      (ARControl) this.PayeeAmt1
    });
    this.gfCommissions.Height = 0.2388889f;
    ((Section) this.gfCommissions).Name = "gfCommissions";
    ((ARControl) this.Label4).Height = 0.125f;
    this.Label4.HyperLink = (string) null;
    ((ARControl) this.Label4).Left = 3.5f;
    ((ARControl) this.Label4).Name = "Label4";
    this.Label4.Style = "font-size: 7pt; font-weight: bold; text-align: right";
    this.Label4.Text = "Total:";
    ((ARControl) this.Label4).Top = 0.0f;
    ((ARControl) this.Label4).Width = 17f / 16f;
    ((ARControl) this.PayeeAmt1).DataField = "PayeeAmt";
    ((ARControl) this.PayeeAmt1).Height = 0.125f;
    ((ARControl) this.PayeeAmt1).Left = 73f / 16f;
    ((ARControl) this.PayeeAmt1).Name = "PayeeAmt1";
    this.PayeeAmt1.OutputFormat = resourceManager.GetString("PayeeAmt1.OutputFormat");
    this.PayeeAmt1.Style = "font-size: 7pt; text-align: right";
    this.PayeeAmt1.SummaryGroup = "ghCommissions";
    this.PayeeAmt1.SummaryRunning = (SummaryRunning) 2;
    this.PayeeAmt1.SummaryType = (SummaryType) 1;
    this.PayeeAmt1.Text = (string) null;
    ((ARControl) this.PayeeAmt1).Top = 0.0f;
    ((ARControl) this.PayeeAmt1).Width = 17f / 16f;
    this.MasterReport = false;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 7.927083f;
    this.Sections.Add((Section) this.ghCommissions);
    this.Sections.Add((Section) this.Detail);
    this.Sections.Add((Section) this.gfCommissions);
    this.StyleSheet.Add(new StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; color: Black; text-align: left; vertical-align: top; ddo-char-set: 1", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-family: Arial; font-size: 16pt; font-style: normal; font-weight: bold", "Heading1", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-style: italic; font-weight: bold", "Heading2", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-family: Arial; font-size: 13pt; font-style: normal; font-weight: bold", "Heading3", "Normal"));
    ((ISupportInitialize) this.txtPayee).EndInit();
    ((ISupportInitialize) this.txtCommissionPercent).EndInit();
    ((ISupportInitialize) this.txtCommissionAmount).EndInit();
    ((ISupportInitialize) this.TextBox).EndInit();
    ((ISupportInitialize) this.Label1).EndInit();
    ((ISupportInitialize) this.Label2).EndInit();
    ((ISupportInitialize) this.Label3).EndInit();
    ((ISupportInitialize) this.Label).EndInit();
    ((ISupportInitialize) this.Label4).EndInit();
    ((ISupportInitialize) this.PayeeAmt1).EndInit();
    ((ISupportInitialize) this).EndInit();
  }

  private void Detail_BeforePrint(object sender, EventArgs e) => this.SetDetailControlsHeight();

  [field: AccessedThroughProperty("ghCommissions")]
  private virtual GroupHeader ghCommissions { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual Detail Detail
  {
    get => this._Detail;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.Detail_BeforePrint);
      Detail detail1 = this._Detail;
      if (detail1 != null)
        ((Section) detail1).BeforePrint -= eventHandler;
      this._Detail = value;
      Detail detail2 = this._Detail;
      if (detail2 == null)
        return;
      ((Section) detail2).BeforePrint += eventHandler;
    }
  }

  [field: AccessedThroughProperty("gfCommissions")]
  private virtual GroupFooter gfCommissions { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }
}
