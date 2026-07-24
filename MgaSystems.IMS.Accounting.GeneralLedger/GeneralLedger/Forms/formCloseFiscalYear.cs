// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.GeneralLedger.Forms.formCloseFiscalYear
// Assembly: MgaSystems.IMS.Accounting.GeneralLedger, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: DC511D5D-5AA9-4B52-8578-E2A0BCB046C3
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Accounting.GeneralLedger.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Accounting.Controls;
using MGASystems.IMS.Accounting.GeneralLedger.ClassObjects;
using MGASystems.IMS.Accounting.Shared;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.GeneralLedger.Forms;

[SecureResource("{1D6326A2-7300-4f39-A531-4A119F657C5F}", "Close Fiscal Utility Rights", "Determines whether or not a user is allowed the close fiscal periods.", "Accounting")]
public class formCloseFiscalYear : Form
{
  private Panel panelLeft;
  private Panel panelContent;
  internal PictureBox PictureBox5;
  internal Panel Panel8;
  internal Label Label24;
  internal Label Label23;
  private Label label1;
  protected MGASimpleComboBox comboOfficeLocations;
  private Label label2;
  protected MGADateTimePicker dateTimeFrom;
  protected MGADateTimePicker dateTimeTo;
  private Label label3;
  private Label label4;
  protected ExtendedTreeViewDropDown dropTreeEquityAccount;
  private Label label5;
  private Label labelPatience;
  private BouncingProgress progress1;
  private System.ComponentModel.Container components;
  internal MGAButton buttonCloseFiscalYear;
  private Label label6;
  private MGADateTimePicker dateTimePostDate;
  private Label label7;
  protected MGATextBox textComments;
  internal MGAButton buttonCancel;
  private Label label8;
  protected MGASimpleComboBox comboCostCenter;
  private DataSet _ds;

  public formCloseFiscalYear() => this.InitializeComponent();

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (formCloseFiscalYear));
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    this.panelLeft = new Panel();
    this.PictureBox5 = new PictureBox();
    this.panelContent = new Panel();
    this.textComments = new MGATextBox();
    this.comboCostCenter = new MGASimpleComboBox();
    this.comboOfficeLocations = new MGASimpleComboBox();
    this.dropTreeEquityAccount = new ExtendedTreeViewDropDown();
    this.dateTimeTo = new MGADateTimePicker();
    this.dateTimeFrom = new MGADateTimePicker();
    this.label8 = new Label();
    this.label7 = new Label();
    this.dateTimePostDate = new MGADateTimePicker();
    this.label6 = new Label();
    this.progress1 = new BouncingProgress();
    this.labelPatience = new Label();
    this.label5 = new Label();
    this.label4 = new Label();
    this.label3 = new Label();
    this.label2 = new Label();
    this.label1 = new Label();
    this.Label23 = new Label();
    this.Label24 = new Label();
    this.Panel8 = new Panel();
    this.buttonCloseFiscalYear = new MGAButton();
    this.buttonCancel = new MGAButton();
    this.panelLeft.SuspendLayout();
    ((ISupportInitialize) this.PictureBox5).BeginInit();
    this.panelContent.SuspendLayout();
    ((ISupportInitialize) this.textComments).BeginInit();
    ((ISupportInitialize) this.comboCostCenter).BeginInit();
    ((ISupportInitialize) this.comboOfficeLocations).BeginInit();
    ((ISupportInitialize) this.dateTimeTo).BeginInit();
    ((ISupportInitialize) this.dateTimeFrom).BeginInit();
    ((ISupportInitialize) this.dateTimePostDate).BeginInit();
    this.Panel8.SuspendLayout();
    ((ISupportInitialize) this.buttonCloseFiscalYear).BeginInit();
    ((ISupportInitialize) this.buttonCancel).BeginInit();
    this.SuspendLayout();
    this.panelLeft.Controls.Add((Control) this.PictureBox5);
    this.panelLeft.Dock = DockStyle.Left;
    this.panelLeft.Location = new Point(0, 0);
    this.panelLeft.Name = "panelLeft";
    this.panelLeft.Size = new Size(128 /*0x80*/, 480);
    this.panelLeft.TabIndex = 0;
    this.PictureBox5.Dock = DockStyle.Fill;
    this.PictureBox5.Image = (Image) componentResourceManager.GetObject("PictureBox5.Image");
    this.PictureBox5.Location = new Point(0, 0);
    this.PictureBox5.Name = "PictureBox5";
    this.PictureBox5.Size = new Size(128 /*0x80*/, 480);
    this.PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
    this.PictureBox5.TabIndex = 1;
    this.PictureBox5.TabStop = false;
    this.panelContent.Controls.Add((Control) this.textComments);
    this.panelContent.Controls.Add((Control) this.comboCostCenter);
    this.panelContent.Controls.Add((Control) this.comboOfficeLocations);
    this.panelContent.Controls.Add((Control) this.dropTreeEquityAccount);
    this.panelContent.Controls.Add((Control) this.dateTimeTo);
    this.panelContent.Controls.Add((Control) this.dateTimeFrom);
    this.panelContent.Controls.Add((Control) this.label8);
    this.panelContent.Controls.Add((Control) this.label7);
    this.panelContent.Controls.Add((Control) this.dateTimePostDate);
    this.panelContent.Controls.Add((Control) this.label6);
    this.panelContent.Controls.Add((Control) this.progress1);
    this.panelContent.Controls.Add((Control) this.labelPatience);
    this.panelContent.Controls.Add((Control) this.label5);
    this.panelContent.Controls.Add((Control) this.label4);
    this.panelContent.Controls.Add((Control) this.label3);
    this.panelContent.Controls.Add((Control) this.label2);
    this.panelContent.Controls.Add((Control) this.label1);
    this.panelContent.Controls.Add((Control) this.Label23);
    this.panelContent.Controls.Add((Control) this.Label24);
    this.panelContent.Dock = DockStyle.Fill;
    this.panelContent.Location = new Point(128 /*0x80*/, 0);
    this.panelContent.Name = "panelContent";
    this.panelContent.Size = new Size(424, 480);
    this.panelContent.TabIndex = 1;
    ((AppearanceBase) appearance1).BackColor = Color.White;
    ((AppearanceBase) appearance1).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance1).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textComments).Appearance = (AppearanceBase) appearance1;
    ((Control) this.textComments).BackColor = Color.White;
    ((Control) this.textComments).Location = new Point(16 /*0x10*/, 304);
    ((TextEditorControlBase) this.textComments).MaxLength = 2000;
    this.textComments.MGAStyle = MGAStyles.Blue;
    this.textComments.Multiline = true;
    ((Control) this.textComments).Name = "textComments";
    ((Control) this.textComments).Size = new Size(392, 128 /*0x80*/);
    ((Control) this.textComments).TabIndex = 15;
    ((UltraControlBase) this.textComments).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textComments).UseOsThemes = (DefaultableBoolean) 2;
    this.comboCostCenter.BorderStyle = (UIElementBorderStyle) 4;
    this.comboCostCenter.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboCostCenter).Location = new Point(16 /*0x10*/, 256 /*0x0100*/);
    this.comboCostCenter.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboCostCenter).Name = "comboCostCenter";
    ((Control) this.comboCostCenter).Size = new Size(384, 21);
    ((Control) this.comboCostCenter).TabIndex = 12;
    ((UltraControlBase) this.comboCostCenter).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboCostCenter).UseOsThemes = (DefaultableBoolean) 2;
    this.comboOfficeLocations.BorderStyle = (UIElementBorderStyle) 4;
    this.comboOfficeLocations.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboOfficeLocations).Location = new Point(16 /*0x10*/, 88);
    this.comboOfficeLocations.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboOfficeLocations).Name = "comboOfficeLocations";
    ((Control) this.comboOfficeLocations).Size = new Size(328, 21);
    ((Control) this.comboOfficeLocations).TabIndex = 3;
    ((UltraControlBase) this.comboOfficeLocations).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboOfficeLocations).UseOsThemes = (DefaultableBoolean) 2;
    this.comboOfficeLocations.RowSelected += new RowSelectedEventHandler(this.comboOfficeLocations_RowSelected);
    this.dropTreeEquityAccount.DropDownHeight = 300;
    this.dropTreeEquityAccount.DropDownWidth = 300;
    this.dropTreeEquityAccount.Font = new Font("Tahoma", 8f);
    this.dropTreeEquityAccount.Location = new Point(16 /*0x10*/, 200);
    this.dropTreeEquityAccount.Name = "dropTreeEquityAccount";
    this.dropTreeEquityAccount.ShowEquityAccounts = true;
    this.dropTreeEquityAccount.ShowSystemDefinedAccounts = true;
    this.dropTreeEquityAccount.Size = new Size(208 /*0xD0*/, 20);
    this.dropTreeEquityAccount.TabIndex = 10;
    this.dropTreeEquityAccount.UseCheckedStateSelectionOverride = false;
    ((AppearanceBase) appearance2).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dateTimeTo.Appearance = (AppearanceBase) appearance2;
    ((AppearanceBase) appearance3).AlphaLevel = (short) 14;
    ((AppearanceBase) appearance3).BackColor = Color.FromArgb(0, 0, 246, 253);
    ((AppearanceBase) appearance3).BackColor2 = Color.FromArgb(133, 162, 221);
    ((AppearanceBase) appearance3).BackColorAlpha = (Alpha) 2;
    ((AppearanceBase) appearance3).BackGradientAlignment = (GradientAlignment) 4;
    ((AppearanceBase) appearance3).BackGradientStyle = (GradientStyle) 5;
    ((AppearanceBase) appearance3).BorderAlpha = (Alpha) 1;
    ((AppearanceBase) appearance3).BorderColor = Color.FromArgb(78, 122, 171);
    ((AppearanceBase) appearance3).ForeColor = Color.FromArgb(49, 85, 153);
    ((AppearanceBase) appearance3).ForegroundAlpha = (Alpha) 2;
    this.dateTimeTo.ButtonAppearance = (AppearanceBase) appearance3;
    this.dateTimeTo.DateTime = new DateTime(2022, 8, 17, 0, 0, 0, 0);
    ((Control) this.dateTimeTo).Location = new Point(128 /*0x80*/, 152);
    this.dateTimeTo.MGAStyle = MGAStyles.Blue;
    ((Control) this.dateTimeTo).Name = "dateTimeTo";
    ((Control) this.dateTimeTo).Size = new Size(96 /*0x60*/, 20);
    ((Control) this.dateTimeTo).TabIndex = 8;
    ((UltraControlBase) this.dateTimeTo).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dateTimeTo).UseOsThemes = (DefaultableBoolean) 2;
    this.dateTimeTo.Value = (object) new DateTime(2022, 8, 17, 0, 0, 0, 0);
    ((AppearanceBase) appearance4).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dateTimeFrom.Appearance = (AppearanceBase) appearance4;
    ((AppearanceBase) appearance5).AlphaLevel = (short) 14;
    ((AppearanceBase) appearance5).BackColor = Color.FromArgb(0, 0, 246, 253);
    ((AppearanceBase) appearance5).BackColor2 = Color.FromArgb(133, 162, 221);
    ((AppearanceBase) appearance5).BackColorAlpha = (Alpha) 2;
    ((AppearanceBase) appearance5).BackGradientAlignment = (GradientAlignment) 4;
    ((AppearanceBase) appearance5).BackGradientStyle = (GradientStyle) 5;
    ((AppearanceBase) appearance5).BorderAlpha = (Alpha) 1;
    ((AppearanceBase) appearance5).BorderColor = Color.FromArgb(78, 122, 171);
    ((AppearanceBase) appearance5).ForeColor = Color.FromArgb(49, 85, 153);
    ((AppearanceBase) appearance5).ForegroundAlpha = (Alpha) 2;
    this.dateTimeFrom.ButtonAppearance = (AppearanceBase) appearance5;
    this.dateTimeFrom.DateTime = new DateTime(2022, 8, 17, 0, 0, 0, 0);
    ((Control) this.dateTimeFrom).Location = new Point(16 /*0x10*/, 152);
    this.dateTimeFrom.MGAStyle = MGAStyles.Blue;
    ((Control) this.dateTimeFrom).Name = "dateTimeFrom";
    ((Control) this.dateTimeFrom).Size = new Size(96 /*0x60*/, 20);
    ((Control) this.dateTimeFrom).TabIndex = 6;
    ((UltraControlBase) this.dateTimeFrom).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dateTimeFrom).UseOsThemes = (DefaultableBoolean) 2;
    this.dateTimeFrom.Value = (object) new DateTime(2022, 8, 17, 0, 0, 0, 0);
    this.label8.AutoSize = true;
    this.label8.Location = new Point(16 /*0x10*/, 240 /*0xF0*/);
    this.label8.Name = "label8";
    this.label8.Size = new Size(65, 13);
    this.label8.TabIndex = 11;
    this.label8.Text = "Cost Center";
    this.label7.AutoSize = true;
    this.label7.Location = new Point(16 /*0x10*/, 288);
    this.label7.Name = "label7";
    this.label7.Size = new Size(57, 13);
    this.label7.TabIndex = 13;
    this.label7.Text = "Comments";
    ((AppearanceBase) appearance6).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dateTimePostDate.Appearance = (AppearanceBase) appearance6;
    ((AppearanceBase) appearance7).AlphaLevel = (short) 14;
    ((AppearanceBase) appearance7).BackColor = Color.FromArgb(0, 0, 246, 253);
    ((AppearanceBase) appearance7).BackColor2 = Color.FromArgb(133, 162, 221);
    ((AppearanceBase) appearance7).BackColorAlpha = (Alpha) 2;
    ((AppearanceBase) appearance7).BackGradientAlignment = (GradientAlignment) 4;
    ((AppearanceBase) appearance7).BackGradientStyle = (GradientStyle) 5;
    ((AppearanceBase) appearance7).BorderAlpha = (Alpha) 1;
    ((AppearanceBase) appearance7).BorderColor = Color.FromArgb(78, 122, 171);
    ((AppearanceBase) appearance7).ForeColor = Color.FromArgb(49, 85, 153);
    ((AppearanceBase) appearance7).ForegroundAlpha = (Alpha) 2;
    this.dateTimePostDate.ButtonAppearance = (AppearanceBase) appearance7;
    this.dateTimePostDate.DateTime = new DateTime(2022, 8, 17, 0, 0, 0, 0);
    ((Control) this.dateTimePostDate).Location = new Point(16 /*0x10*/, 304);
    this.dateTimePostDate.MGAStyle = MGAStyles.Blue;
    ((Control) this.dateTimePostDate).Name = "dateTimePostDate";
    ((Control) this.dateTimePostDate).Size = new Size(96 /*0x60*/, 20);
    ((Control) this.dateTimePostDate).TabIndex = 12;
    ((UltraControlBase) this.dateTimePostDate).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dateTimePostDate).UseOsThemes = (DefaultableBoolean) 2;
    this.dateTimePostDate.Value = (object) new DateTime(2022, 8, 17, 0, 0, 0, 0);
    ((Control) this.dateTimePostDate).Visible = false;
    this.label6.AutoSize = true;
    this.label6.Location = new Point(16 /*0x10*/, 288);
    this.label6.Name = "label6";
    this.label6.Size = new Size(113, 13);
    this.label6.TabIndex = 14;
    this.label6.Text = "Transaction Post Date";
    this.label6.Visible = false;
    this.progress1.Border = BorderStyle.Fixed3D;
    this.progress1.BorderColor = Color.DarkGray;
    this.progress1.Bounce = false;
    this.progress1.BounceColor = SystemColors.Highlight;
    this.progress1.Location = new Point(16 /*0x10*/, 456);
    this.progress1.Name = "progress1";
    this.progress1.Size = new Size(392, 8);
    this.progress1.TabIndex = 16 /*0x10*/;
    this.progress1.Visible = false;
    this.labelPatience.AutoSize = true;
    this.labelPatience.Location = new Point(16 /*0x10*/, 440);
    this.labelPatience.Name = "labelPatience";
    this.labelPatience.Size = new Size(341, 13);
    this.labelPatience.TabIndex = 16 /*0x10*/;
    this.labelPatience.Text = "Calculating total. This may take several minutes, please be patient....";
    this.labelPatience.Visible = false;
    this.label5.AutoSize = true;
    this.label5.Location = new Point(16 /*0x10*/, 184);
    this.label5.Name = "label5";
    this.label5.Size = new Size(61, 13);
    this.label5.TabIndex = 9;
    this.label5.Text = "GL Account";
    this.label4.AutoSize = true;
    this.label4.Location = new Point(128 /*0x80*/, 136);
    this.label4.Name = "label4";
    this.label4.Size = new Size(19, 13);
    this.label4.TabIndex = 7;
    this.label4.Text = "To";
    this.label3.AutoSize = true;
    this.label3.Location = new Point(16 /*0x10*/, 136);
    this.label3.Name = "label3";
    this.label3.Size = new Size(31 /*0x1F*/, 13);
    this.label3.TabIndex = 5;
    this.label3.Text = "From";
    this.label2.AutoSize = true;
    this.label2.Location = new Point(16 /*0x10*/, 120);
    this.label2.Name = "label2";
    this.label2.Size = new Size(210, 13);
    this.label2.TabIndex = 4;
    this.label2.Text = "Fiscal Year (or User Specified Date Range)";
    this.label1.AutoSize = true;
    this.label1.Location = new Point(16 /*0x10*/, 72);
    this.label1.Name = "label1";
    this.label1.Size = new Size(83, 13);
    this.label1.TabIndex = 2;
    this.label1.Text = "Office Location:";
    this.Label23.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label23.Location = new Point(16 /*0x10*/, 32 /*0x20*/);
    this.Label23.Name = "Label23";
    this.Label23.Size = new Size(400, 32 /*0x20*/);
    this.Label23.TabIndex = 1;
    this.Label23.Text = "This wizard enables you to move account balances from the profit and loss statement to retained earnings.";
    this.Label24.AutoSize = true;
    this.Label24.Font = new Font("Tahoma", 14f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label24.Location = new Point(16 /*0x10*/, 8);
    this.Label24.Name = "Label24";
    this.Label24.Size = new Size(236, 23);
    this.Label24.TabIndex = 0;
    this.Label24.Text = "Close Fiscal Year Utility";
    this.Panel8.BackgroundImage = (Image) componentResourceManager.GetObject("Panel8.BackgroundImage");
    this.Panel8.Controls.Add((Control) this.buttonCloseFiscalYear);
    this.Panel8.Controls.Add((Control) this.buttonCancel);
    this.Panel8.Dock = DockStyle.Bottom;
    this.Panel8.Location = new Point(0, 480);
    this.Panel8.Name = "Panel8";
    this.Panel8.Size = new Size(552, 40);
    this.Panel8.TabIndex = 2;
    ((Control) this.buttonCloseFiscalYear).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    ((AppearanceBase) appearance8).BackColor = Color.Gainsboro;
    ((AppearanceBase) appearance8).BackColor2 = Color.White;
    ((AppearanceBase) appearance8).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance8).BorderColor = Color.Gray;
    ((ControlBase) this.buttonCloseFiscalYear).Appearance = (AppearanceBase) appearance8;
    ((Control) this.buttonCloseFiscalYear).Location = new Point(296, 8);
    ((Control) this.buttonCloseFiscalYear).Name = "buttonCloseFiscalYear";
    ((Control) this.buttonCloseFiscalYear).Size = new Size(120, 24);
    ((Control) this.buttonCloseFiscalYear).TabIndex = 0;
    ((Control) this.buttonCloseFiscalYear).Text = "Close Fiscal Year";
    ((UltraControlBase) this.buttonCloseFiscalYear).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonCloseFiscalYear).Click += new EventHandler(this.buttonCloseFiscalYear_Click);
    ((Control) this.buttonCancel).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    ((AppearanceBase) appearance9).BackColor = Color.Gainsboro;
    ((AppearanceBase) appearance9).BackColor2 = Color.White;
    ((AppearanceBase) appearance9).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance9).BorderColor = Color.Gray;
    ((ControlBase) this.buttonCancel).Appearance = (AppearanceBase) appearance9;
    ((ControlBase) this.buttonCancel).BackColorInternal = Color.White;
    ((Control) this.buttonCancel).Font = new Font("Tahoma", 8f);
    ((Control) this.buttonCancel).ForeColor = Color.Black;
    ((Control) this.buttonCancel).Location = new Point(424, 8);
    ((Control) this.buttonCancel).Name = "buttonCancel";
    ((Control) this.buttonCancel).Size = new Size(120, 24);
    ((Control) this.buttonCancel).TabIndex = 1;
    ((Control) this.buttonCancel).Text = "&Cancel";
    ((UltraControlBase) this.buttonCancel).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonCancel).Click += new EventHandler(this.buttonCancel_Click);
    this.AutoScaleBaseSize = new Size(5, 13);
    this.BackColor = Color.White;
    this.ClientSize = new Size(552, 520);
    this.ControlBox = false;
    this.Controls.Add((Control) this.panelContent);
    this.Controls.Add((Control) this.panelLeft);
    this.Controls.Add((Control) this.Panel8);
    this.Font = new Font("Tahoma", 8f);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.Name = nameof (formCloseFiscalYear);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Close Fiscal Year Utility";
    this.Load += new EventHandler(this.formCloseFiscalYear_Load);
    this.panelLeft.ResumeLayout(false);
    ((ISupportInitialize) this.PictureBox5).EndInit();
    this.panelContent.ResumeLayout(false);
    this.panelContent.PerformLayout();
    ((ISupportInitialize) this.textComments).EndInit();
    ((ISupportInitialize) this.comboCostCenter).EndInit();
    ((ISupportInitialize) this.comboOfficeLocations).EndInit();
    ((ISupportInitialize) this.dateTimeTo).EndInit();
    ((ISupportInitialize) this.dateTimeFrom).EndInit();
    ((ISupportInitialize) this.dateTimePostDate).EndInit();
    this.Panel8.ResumeLayout(false);
    ((ISupportInitialize) this.buttonCloseFiscalYear).EndInit();
    ((ISupportInitialize) this.buttonCancel).EndInit();
    this.ResumeLayout(false);
  }

  private void LoadOfficeLocations()
  {
    ((UltraGridBase) this.comboOfficeLocations).DataSource = (object) Methods.GetOfficeLocationDataset();
    ((UltraDropDownBase) this.comboOfficeLocations).DisplayMember = "Office Location";
    ((UltraDropDownBase) this.comboOfficeLocations).ValueMember = "ID";
  }

  private void comboOfficeLocations_RowSelected(object sender, RowSelectedEventArgs e)
  {
    if (((UltraDropDownBase) this.comboOfficeLocations).SelectedRow == null)
      return;
    this.dropTreeEquityAccount.LoadGLAccounts((int) this.comboOfficeLocations.Value);
    this.LoadCostCenters();
  }

  protected virtual void buttonCloseFiscalYear_Click(object sender, EventArgs e)
  {
    if (!this.ValidateForm())
      return;
    this.LoadProfitAndLoss();
  }

  private void buttonCancel_Click(object sender, EventArgs e)
  {
    if (MessageBox.Show("Are you sure you want to exit the Close Fiscal Year Utility?", "Exit Utility?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
      return;
    this.Close();
  }

  private void LoadProfitAndLoss()
  {
    this.labelPatience.Visible = true;
    this.progress1.Visible = true;
    this.progress1.Bounce = true;
    new Thread(new ThreadStart(this.DoLoadProfitAndLoss))
    {
      IsBackground = true,
      Name = nameof (LoadProfitAndLoss)
    }.Start();
  }

  private void DoLoadProfitAndLoss()
  {
    this._ds = DefaultDatabase.ExecuteDataSet("spFin_GetFiscalYearIncomeExpenseClose", new object[6]
    {
      (object) "@DateFrom",
      (object) this.dateTimeFrom.DateTime,
      (object) "@DateTo",
      (object) this.dateTimeTo.DateTime,
      (object) "@glcompanyId",
      this.comboOfficeLocations.Value
    });
    if (this.IsDisposed || this.Disposing)
      return;
    this.Invoke((Delegate) new formCloseFiscalYear.LoadProfitAndLossCompletedHandler(this.LoadProfitAndLossCompleted));
  }

  private void LoadProfitAndLossCompleted() => this.CreateLedgerEntry();

  private void CreateLedgerEntry()
  {
    JournalEntry journalEntry = new JournalEntry();
    journalEntry.IsYearEnd = true;
    journalEntry.JournalEntryType = SharedMembers.JournalEntryType.AccountAdjustment;
    journalEntry.GlCompanyId = int.Parse(((UltraDropDownBase) this.comboOfficeLocations).SelectedRow.Cells["ID"].Value.ToString());
    journalEntry.PostDate = this.dateTimeTo.DateTime;
    journalEntry.Comments = ((Control) this.textComments).Text;
    journalEntry.CostCenterId = int.Parse(this.comboCostCenter.Value.ToString());
    foreach (DataRow row in (InternalDataCollectionBase) this._ds.Tables[0].Rows)
    {
      CostCenterAllocationCollection costCenters = new CostCenterAllocationCollection();
      costCenters.Add(new CostCenterAllocation(journalEntry.CostCenterId, Math.Abs(Decimal.Parse(row["amount"].ToString()))), Math.Abs(Decimal.Parse(row["amount"].ToString())));
      if (Decimal.Parse(row["Amount"].ToString()) < 0M)
      {
        journalEntry.DebitsCol.Add(new LedgerEntry(int.Parse(row["glacctid"].ToString()), Math.Abs(Decimal.Parse(row["amount"].ToString())), costCenters));
        journalEntry.CreditsCol.Add(new LedgerEntry(this.dropTreeEquityAccount.GLAccountID, Math.Abs(Decimal.Parse(row["amount"].ToString())), costCenters));
      }
      else
      {
        journalEntry.CreditsCol.Add(new LedgerEntry(int.Parse(row["glacctid"].ToString()), Math.Abs(Decimal.Parse(row["amount"].ToString())), costCenters));
        journalEntry.DebitsCol.Add(new LedgerEntry(this.dropTreeEquityAccount.GLAccountID, Math.Abs(Decimal.Parse(row["amount"].ToString())), costCenters));
      }
    }
    if (!journalEntry.ViolatesClosedDate())
    {
      journalEntry.Save();
      CurrentUser.Instance.LogAction("Closed fiscal year.", "Accounting Logs");
    }
    this.labelPatience.Visible = false;
    this.progress1.Visible = false;
    this.progress1.Bounce = false;
    int num = (int) MessageBox.Show("The system has successfully created the close journal entry.", "Successfully Created Entry!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    this.Close();
  }

  protected bool ValidateForm()
  {
    if (((UltraDropDownBase) this.comboOfficeLocations).SelectedRow == null)
    {
      int num = (int) MessageBox.Show("You must select an office location to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (this.dateTimeFrom.Value.Equals((object) DBNull.Value) || this.dateTimeTo.Value.Equals((object) DBNull.Value))
    {
      int num = (int) MessageBox.Show("You must specify a starting and an ending date to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (this.dateTimeFrom.DateTime > this.dateTimeTo.DateTime)
    {
      int num = (int) MessageBox.Show("The starting date can not be greater than the ending date.", "Invalid Entry!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (this.dropTreeEquityAccount.GLAccountID == -1 || this.dropTreeEquityAccount.SelectedNodeCount == 0)
    {
      int num = (int) MessageBox.Show("You must specify an equity account to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (this.dateTimePostDate.Value.Equals((object) DBNull.Value))
    {
      int num = (int) MessageBox.Show("You must specify a posting date to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (((UltraDropDownBase) this.comboCostCenter).SelectedRow == null)
    {
      int num = (int) MessageBox.Show("You must specify a cost center to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (new GlCompany((int) ((UltraDropDownBase) this.comboOfficeLocations).SelectedRow.Cells["ID"].Value).ViolatesClosedDate(this.dateTimeTo.DateTime))
      return true;
    StringBuilder stringBuilder1 = new StringBuilder();
    stringBuilder1.Append("You must open the accounting period to allow this posting. The close date must be set to at least ");
    StringBuilder stringBuilder2 = stringBuilder1;
    DateTime dateTime = this.dateTimeTo.DateTime;
    dateTime = dateTime.AddDays(-1.0);
    string shortDateString = dateTime.ToShortDateString();
    stringBuilder2.Append(shortDateString);
    stringBuilder1.Append(".");
    int num1 = (int) MessageBox.Show(stringBuilder1.ToString(), "Post Date Violates Closed Date!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    return false;
  }

  private void LoadCostCenters()
  {
    ((UltraGridBase) this.comboCostCenter).DataSource = (object) DefaultDatabase.ExecuteDataTable("spFin_GetCostCentersList", new object[2]
    {
      (object) "@glCompanyId",
      this.comboOfficeLocations.Value
    });
    ((UltraDropDownBase) this.comboCostCenter).DisplayMember = "Name";
    ((UltraDropDownBase) this.comboCostCenter).ValueMember = "CostCenterID";
  }

  private void formCloseFiscalYear_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    this.LoadOfficeLocations();
  }

  private delegate void LoadProfitAndLossCompletedHandler();
}
