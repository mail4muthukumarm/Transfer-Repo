// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.PolicyServices.formCancellationDateOverride
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Common.BroadcastMessaging;
using MGASystems.IMS.Accounting.AccountingDatasets;
using MGASystems.IMS.Accounting.Services;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.PolicyServices;

public class formCancellationDateOverride : AccountingNoteDocumentSupport
{
  private const string _systemSettingUseNOCDescription = "UseNOCDescription";
  private bool _useNOCDescription;
  private IContainer components;
  internal SqlConnection FormDataConnection;
  internal SqlCommand SqlSelectCommand1;
  internal SqlDataAdapter daGetQuoteStatusReasons;
  private dsQuoteStatusReasons dsQuoteStatusReasons1;
  protected MGATextBox textNOCDescription;
  protected EllipsePanel ellipsePanel1;
  protected Label Label5;
  protected Label Label4;
  protected Label Label3;
  protected Label Label2;
  protected MGAButton btnCancel;
  protected UltraCombo cmbReasons;
  protected MGAButton btnIssueNotice;
  protected Label lblPolicyNumber;
  protected PictureBox PictureBox1;
  protected Label Label1;
  protected MGADateTimePicker uccEffectiveDate;
  protected MGADateTimePicker uccMailingDate;
  protected UltraLabel labelNOCDescription;

  protected int QuoteId { get; private set; }

  protected int GlCompanyId { get; private set; }

  protected string PolicyNumber { get; private set; }

  protected int ControlNumber { get; private set; }

  public formCancellationDateOverride()
  {
    this.InitializeComponent();
    this._useNOCDescription = MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("UseNOCDescription");
    this.FormatCancellationDateOverride();
  }

  public formCancellationDateOverride(
    string policyNumber,
    int controlNumber,
    int quoteId,
    int glCompanyId)
  {
    this.InitializeComponent();
    this._useNOCDescription = MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("UseNOCDescription");
    this.PolicyNumber = policyNumber;
    this.ControlNumber = controlNumber;
    this.QuoteId = quoteId;
    this.GlCompanyId = glCompanyId;
    this.FormDataConnection.ConnectionString = CurrentUser.Instance.ConnectionString;
    this.daGetQuoteStatusReasons.Fill((DataTable) this.dsQuoteStatusReasons1.Reasons);
    this.lblPolicyNumber.Text = policyNumber;
    this.uccEffectiveDate.DateTime = DateTime.Now;
    this.uccMailingDate.DateTime = DateTime.Now;
    this.FormatCancellationDateOverride();
  }

  private void FormatCancellationDateOverride()
  {
    if (this._useNOCDescription)
      return;
    ((Control) this.textNOCDescription).Visible = false;
    ((Control) this.labelNOCDescription).Visible = false;
    this.Size = new Size(458, 275);
    this.ellipsePanel1.Size = new Size(432, 226);
    this.Label4.Location = new Point(32 /*0x20*/, 138);
    this.Label5.Location = new Point(32 /*0x20*/, 162);
    ((Control) this.uccEffectiveDate).Location = new Point(160 /*0xA0*/, 138);
    ((Control) this.uccMailingDate).Location = new Point(160 /*0xA0*/, 162);
    ((Control) this.btnIssueNotice).Location = new Point(208 /*0xD0*/, 194);
    ((Control) this.btnCancel).Location = new Point(328, 194);
  }

  private void btnCancel_Click(object sender, EventArgs e)
  {
    this.DialogResult = DialogResult.Cancel;
    this.Close();
  }

  protected virtual void btnIssueNotice_Click(object sender, EventArgs e)
  {
    if (!this.ValidateCancellationOverride())
      return;
    this.IssueNotice();
  }

  protected virtual void IssueNotice()
  {
    NoticeOfCancellation.PrintCancellationNotices(CurrentUser.Instance.ConnectionString, this.QuoteId, this.GlCompanyId, this.uccEffectiveDate.DateTime, int.Parse(((UltraDropDownBase) this.cmbReasons).SelectedRow.Cells["id"].Value.ToString()), this.uccMailingDate.DateTime, "", "", ((Control) this.textNOCDescription).Text);
    Quote quote = new Quote(this.QuoteId);
    if (quote.UnderNotice)
    {
      CurrentUser.Instance.LogAction("Issued Manual NOC", quote.QuoteGuid);
      Messaging.SendBroadcastMessage(BroadcastMessages.NOCIssued, (object) quote.QuoteGuid);
    }
    this.DialogResult = DialogResult.OK;
    this.Close();
  }

  private void cmbReasons_RowSelected(object sender, RowSelectedEventArgs e)
  {
    if (((UltraDropDownBase) this.cmbReasons).SelectedRow == null)
      return;
    this.uccEffectiveDate.DateTime = DateTime.Now.AddDays((double) MGASystems.IMS.Accounting.Services.PolicyServices.GetManualCancellationEffectiveDays(this.ControlNumber));
  }

  private bool ValidateCancellationOverride()
  {
    if (((UltraDropDownBase) this.cmbReasons).SelectedRow != null)
      return true;
    int num = (int) MessageBox.Show("Please select a reason for cancellation notice.", "Required Feild Missing", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    return false;
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (formCancellationDateOverride));
    UltraGridBand ultraGridBand = new UltraGridBand("Reasons", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("ID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("Reason");
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    this.FormDataConnection = new SqlConnection();
    this.SqlSelectCommand1 = new SqlCommand();
    this.Label5 = new Label();
    this.Label4 = new Label();
    this.Label3 = new Label();
    this.Label2 = new Label();
    this.btnCancel = new MGAButton();
    this.daGetQuoteStatusReasons = new SqlDataAdapter();
    this.cmbReasons = new UltraCombo();
    this.dsQuoteStatusReasons1 = new dsQuoteStatusReasons();
    this.btnIssueNotice = new MGAButton();
    this.lblPolicyNumber = new Label();
    this.PictureBox1 = new PictureBox();
    this.Label1 = new Label();
    this.uccEffectiveDate = new MGADateTimePicker();
    this.uccMailingDate = new MGADateTimePicker();
    this.ellipsePanel1 = new EllipsePanel();
    this.textNOCDescription = new MGATextBox();
    this.labelNOCDescription = new UltraLabel();
    ((ISupportInitialize) this.btnCancel).BeginInit();
    ((ISupportInitialize) this.cmbReasons).BeginInit();
    this.dsQuoteStatusReasons1.BeginInit();
    ((ISupportInitialize) this.btnIssueNotice).BeginInit();
    ((ISupportInitialize) this.PictureBox1).BeginInit();
    ((ISupportInitialize) this.uccEffectiveDate).BeginInit();
    ((ISupportInitialize) this.uccMailingDate).BeginInit();
    this.ellipsePanel1.SuspendLayout();
    ((ISupportInitialize) this.textNOCDescription).BeginInit();
    this.SuspendLayout();
    this.FormDataConnection.ConnectionString = "workstation id=WREYES;packet size=4096;user id=mgasystems;data source=MGASYSTEMS;persist security info=False;initial catalog=IMS";
    this.FormDataConnection.FireInfoMessageEventOnUserErrors = false;
    this.SqlSelectCommand1.CommandText = "[spFin_GetQuoteStatusReasons]";
    this.SqlSelectCommand1.CommandType = CommandType.StoredProcedure;
    this.SqlSelectCommand1.Connection = this.FormDataConnection;
    this.SqlSelectCommand1.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null)
    });
    this.Label5.AutoSize = true;
    this.Label5.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label5.Location = new Point(32 /*0x20*/, 229);
    this.Label5.Name = "Label5";
    this.Label5.Size = new Size(92, 13);
    this.Label5.TabIndex = 20;
    this.Label5.Text = "Date Of Mailing";
    this.Label5.TextAlign = ContentAlignment.TopCenter;
    this.Label4.AutoSize = true;
    this.Label4.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label4.Location = new Point(32 /*0x20*/, 205);
    this.Label4.Name = "Label4";
    this.Label4.Size = new Size(89, 13);
    this.Label4.TabIndex = 19;
    this.Label4.Text = "Effective Date:";
    this.Label4.TextAlign = ContentAlignment.TopCenter;
    this.Label3.AutoSize = true;
    this.Label3.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label3.Location = new Point(32 /*0x20*/, 112 /*0x70*/);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(111, 13);
    this.Label3.TabIndex = 17;
    this.Label3.Text = "Reason For Notice:";
    this.Label3.TextAlign = ContentAlignment.TopCenter;
    this.Label2.AutoSize = true;
    this.Label2.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label2.Location = new Point(32 /*0x20*/, 88);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(55, 13);
    this.Label2.TabIndex = 13;
    this.Label2.Text = "Policy #:";
    this.Label2.TextAlign = ContentAlignment.TopCenter;
    ((AppearanceBase) appearance1).Image = componentResourceManager.GetObject("appearance1.Image");
    ((ControlBase) this.btnCancel).Appearance = (AppearanceBase) appearance1;
    ((Control) this.btnCancel).Location = new Point(328, 261);
    ((Control) this.btnCancel).Name = "btnCancel";
    ((Control) this.btnCancel).Size = new Size(96 /*0x60*/, 23);
    ((Control) this.btnCancel).TabIndex = 16 /*0x10*/;
    ((Control) this.btnCancel).Text = "&Cancel";
    ((UltraControlBase) this.btnCancel).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.btnCancel).Click += new EventHandler(this.btnCancel_Click);
    this.daGetQuoteStatusReasons.SelectCommand = this.SqlSelectCommand1;
    this.daGetQuoteStatusReasons.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "spFin_GetQuoteStatusReasons", new DataColumnMapping[2]
      {
        new DataColumnMapping("ID", "ID"),
        new DataColumnMapping("Reason", "Reason")
      })
    });
    ((UltraGridBase) this.cmbReasons).DataMember = "Reasons";
    ((UltraGridBase) this.cmbReasons).DataSource = (object) this.dsQuoteStatusReasons1;
    ((UltraGridBase) this.cmbReasons).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand.ColHeadersVisible = false;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn1.Header).VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn2.Header).VisiblePosition = 1;
    ultraGridColumn2.Width = 245;
    ultraGridBand.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2
    });
    ultraGridBand.GroupHeadersVisible = false;
    ((UltraGridBase) this.cmbReasons).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.cmbReasons).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.cmbReasons).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 2;
    ((UltraGridBase) this.cmbReasons).DisplayLayout.Override.AllowRowLayoutCellSizing = (RowLayoutSizing) 1;
    ((UltraGridBase) this.cmbReasons).DisplayLayout.Override.AllowRowLayoutLabelSizing = (RowLayoutSizing) 1;
    ((UltraGridBase) this.cmbReasons).DisplayLayout.Override.AllowRowSummaries = (AllowRowSummaries) 2;
    ((UltraGridBase) this.cmbReasons).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.cmbReasons).DisplayLayout.Override.BorderStyleHeader = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.cmbReasons).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.cmbReasons).DisplayLayout.Override.BorderStyleRowSelector = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.cmbReasons).DisplayLayout.Override.BorderStyleSummaryFooter = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.cmbReasons).DisplayLayout.Override.BorderStyleSummaryFooterCaption = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.cmbReasons).DisplayLayout.Override.BorderStyleSummaryValue = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.cmbReasons).DisplayLayout.Override.BorderStyleTemplateAddRow = (UIElementBorderStyle) 1;
    ((UltraDropDownBase) this.cmbReasons).DisplayMember = "Reason";
    this.cmbReasons.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cmbReasons).Location = new Point(160 /*0xA0*/, 112 /*0x70*/);
    ((Control) this.cmbReasons).Name = "cmbReasons";
    ((Control) this.cmbReasons).Size = new Size(264, 23);
    ((Control) this.cmbReasons).TabIndex = 18;
    ((UltraDropDownBase) this.cmbReasons).ValueMember = "ID";
    this.cmbReasons.RowSelected += new RowSelectedEventHandler(this.cmbReasons_RowSelected);
    this.dsQuoteStatusReasons1.DataSetName = "dsQuoteStatusReasons";
    this.dsQuoteStatusReasons1.Locale = new CultureInfo("en-US");
    ((AppearanceBase) appearance2).Image = componentResourceManager.GetObject("appearance2.Image");
    ((ControlBase) this.btnIssueNotice).Appearance = (AppearanceBase) appearance2;
    ((Control) this.btnIssueNotice).Location = new Point(208 /*0xD0*/, 261);
    ((Control) this.btnIssueNotice).Name = "btnIssueNotice";
    ((Control) this.btnIssueNotice).Size = new Size(104, 23);
    ((Control) this.btnIssueNotice).TabIndex = 15;
    ((Control) this.btnIssueNotice).Text = "&Issue Notice";
    ((UltraControlBase) this.btnIssueNotice).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.btnIssueNotice).Click += new EventHandler(this.btnIssueNotice_Click);
    this.lblPolicyNumber.Location = new Point(160 /*0xA0*/, 88);
    this.lblPolicyNumber.Name = "lblPolicyNumber";
    this.lblPolicyNumber.Size = new Size(232, 24);
    this.lblPolicyNumber.TabIndex = 14;
    this.lblPolicyNumber.Text = "[Policy Number]";
    this.PictureBox1.Image = (Image) componentResourceManager.GetObject("PictureBox1.Image");
    this.PictureBox1.Location = new Point(360, 8);
    this.PictureBox1.Name = "PictureBox1";
    this.PictureBox1.Size = new Size(64 /*0x40*/, 64 /*0x40*/);
    this.PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
    this.PictureBox1.TabIndex = 11;
    this.PictureBox1.TabStop = false;
    this.Label1.BackColor = Color.Transparent;
    this.Label1.Location = new Point(16 /*0x10*/, 8);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(344, 72);
    this.Label1.TabIndex = 12;
    this.Label1.Text = componentResourceManager.GetString("Label1.Text");
    ((AppearanceBase) appearance3).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.uccEffectiveDate.Appearance = (AppearanceBase) appearance3;
    ((AppearanceBase) appearance4).AlphaLevel = (short) 14;
    ((AppearanceBase) appearance4).BackColor = Color.FromArgb(0, 0, 246, 253);
    ((AppearanceBase) appearance4).BackColor2 = Color.FromArgb(133, 162, 221);
    ((AppearanceBase) appearance4).BackColorAlpha = (Alpha) 2;
    ((AppearanceBase) appearance4).BackGradientAlignment = (GradientAlignment) 4;
    ((AppearanceBase) appearance4).BackGradientStyle = (GradientStyle) 5;
    ((AppearanceBase) appearance4).BorderAlpha = (Alpha) 1;
    ((AppearanceBase) appearance4).BorderColor = Color.FromArgb(78, 122, 171);
    ((AppearanceBase) appearance4).ForeColor = Color.FromArgb(49, 85, 153);
    ((AppearanceBase) appearance4).ForegroundAlpha = (Alpha) 2;
    this.uccEffectiveDate.ButtonAppearance = (AppearanceBase) appearance4;
    ((Control) this.uccEffectiveDate).Location = new Point(160 /*0xA0*/, 205);
    this.uccEffectiveDate.MGAStyle = MGAStyles.Blue;
    ((Control) this.uccEffectiveDate).Name = "uccEffectiveDate";
    ((Control) this.uccEffectiveDate).Size = new Size(144 /*0x90*/, 20);
    ((Control) this.uccEffectiveDate).TabIndex = 21;
    ((UltraControlBase) this.uccEffectiveDate).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.uccEffectiveDate).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance5).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.uccMailingDate.Appearance = (AppearanceBase) appearance5;
    ((AppearanceBase) appearance6).AlphaLevel = (short) 14;
    ((AppearanceBase) appearance6).BackColor = Color.FromArgb(0, 0, 246, 253);
    ((AppearanceBase) appearance6).BackColor2 = Color.FromArgb(133, 162, 221);
    ((AppearanceBase) appearance6).BackColorAlpha = (Alpha) 2;
    ((AppearanceBase) appearance6).BackGradientAlignment = (GradientAlignment) 4;
    ((AppearanceBase) appearance6).BackGradientStyle = (GradientStyle) 5;
    ((AppearanceBase) appearance6).BorderAlpha = (Alpha) 1;
    ((AppearanceBase) appearance6).BorderColor = Color.FromArgb(78, 122, 171);
    ((AppearanceBase) appearance6).ForeColor = Color.FromArgb(49, 85, 153);
    ((AppearanceBase) appearance6).ForegroundAlpha = (Alpha) 2;
    this.uccMailingDate.ButtonAppearance = (AppearanceBase) appearance6;
    ((Control) this.uccMailingDate).Location = new Point(160 /*0xA0*/, 229);
    this.uccMailingDate.MGAStyle = MGAStyles.Blue;
    ((Control) this.uccMailingDate).Name = "uccMailingDate";
    ((Control) this.uccMailingDate).Size = new Size(144 /*0x90*/, 20);
    ((Control) this.uccMailingDate).TabIndex = 22;
    ((UltraControlBase) this.uccMailingDate).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.uccMailingDate).UseOsThemes = (DefaultableBoolean) 2;
    this.ellipsePanel1.BackColor = Color.FromArgb(239, 247, 253);
    this.ellipsePanel1.Controls.Add((Control) this.textNOCDescription);
    this.ellipsePanel1.Controls.Add((Control) this.labelNOCDescription);
    this.ellipsePanel1.Controls.Add((Control) this.btnCancel);
    this.ellipsePanel1.Controls.Add((Control) this.Label2);
    this.ellipsePanel1.Controls.Add((Control) this.Label3);
    this.ellipsePanel1.Controls.Add((Control) this.uccMailingDate);
    this.ellipsePanel1.Controls.Add((Control) this.Label4);
    this.ellipsePanel1.Controls.Add((Control) this.Label5);
    this.ellipsePanel1.Controls.Add((Control) this.lblPolicyNumber);
    this.ellipsePanel1.Controls.Add((Control) this.uccEffectiveDate);
    this.ellipsePanel1.Controls.Add((Control) this.Label1);
    this.ellipsePanel1.Controls.Add((Control) this.cmbReasons);
    this.ellipsePanel1.Controls.Add((Control) this.btnIssueNotice);
    this.ellipsePanel1.Controls.Add((Control) this.PictureBox1);
    this.ellipsePanel1.Location = new Point(4, 4);
    this.ellipsePanel1.Name = "ellipsePanel1";
    this.ellipsePanel1.Size = new Size(432, 290);
    this.ellipsePanel1.TabIndex = 23;
    ((AppearanceBase) appearance7).BackColor = Color.White;
    ((AppearanceBase) appearance7).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance7).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textNOCDescription).Appearance = (AppearanceBase) appearance7;
    ((Control) this.textNOCDescription).BackColor = Color.White;
    ((Control) this.textNOCDescription).Location = new Point(160 /*0xA0*/, 138);
    ((TextEditorControlBase) this.textNOCDescription).MaxLength = 550;
    this.textNOCDescription.MGAStyle = MGAStyles.Blue;
    this.textNOCDescription.Multiline = true;
    ((Control) this.textNOCDescription).Name = "textNOCDescription";
    ((Control) this.textNOCDescription).Size = new Size(264, 64 /*0x40*/);
    ((Control) this.textNOCDescription).TabIndex = 26;
    ((Control) this.textNOCDescription).Tag = (object) "NOC Description";
    ((UltraControlBase) this.textNOCDescription).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textNOCDescription).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance8).BackColor = Color.Transparent;
    ((ControlBase) this.labelNOCDescription).Appearance = (AppearanceBase) appearance8;
    ((Control) this.labelNOCDescription).AutoSize = true;
    ((Control) this.labelNOCDescription).Font = new Font("Tahoma", 8.25f, FontStyle.Bold);
    ((Control) this.labelNOCDescription).Location = new Point(32 /*0x20*/, 139);
    ((Control) this.labelNOCDescription).Name = "labelNOCDescription";
    ((Control) this.labelNOCDescription).Size = new Size(73, 15);
    ((Control) this.labelNOCDescription).TabIndex = 25;
    ((Control) this.labelNOCDescription).Text = "Description:";
    this.AutoScaleBaseSize = new Size(5, 13);
    this.BackColor = Color.White;
    this.ClientSize = new Size(442, 297);
    this.ControlBox = false;
    this.Controls.Add((Control) this.ellipsePanel1);
    this.Font = new Font("Tahoma", 8f);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.Name = nameof (formCancellationDateOverride);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Cancellation Override";
    ((ISupportInitialize) this.btnCancel).EndInit();
    ((ISupportInitialize) this.cmbReasons).EndInit();
    this.dsQuoteStatusReasons1.EndInit();
    ((ISupportInitialize) this.btnIssueNotice).EndInit();
    ((ISupportInitialize) this.PictureBox1).EndInit();
    ((ISupportInitialize) this.uccEffectiveDate).EndInit();
    ((ISupportInitialize) this.uccMailingDate).EndInit();
    this.ellipsePanel1.ResumeLayout(false);
    this.ellipsePanel1.PerformLayout();
    ((ISupportInitialize) this.textNOCDescription).EndInit();
    this.ResumeLayout(false);
  }
}
