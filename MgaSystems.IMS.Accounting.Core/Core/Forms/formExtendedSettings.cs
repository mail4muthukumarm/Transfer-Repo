// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.Forms.formExtendedSettings
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Accounting.Core.ClassObjects;
using MGASystems.IMS.Accounting.GeneralLedger.ClassObjects;
using MGASystems.IMS.Accounting.Services;
using MGASystems.IMS.Accounting.Shared;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.Forms;

[SecureResource("{3519F03A-EFAD-440d-8105-037D44565571}", "Extended Settings Management Rights", "Determines whether a user has rights to change the GL Office extended settings.", "Accounting")]
public class formExtendedSettings : AccountingNoteDocumentSupport
{
  internal SqlDataAdapter daGetOfficeLocations;
  internal SqlCommand SqlSelectCommand1;
  internal SqlConnection FormDataConnection;
  internal MGASimpleComboBox cmbOfficeLocations;
  internal Label Label3;
  internal RadioButton optReceivables;
  internal RadioButton optPayables;
  internal RadioButton optPropotional;
  internal RadioButton optFull;
  internal MGATextBox txtLiabilityWriteOff;
  internal Label Label1;
  internal Label Label2;
  internal MGATextBox txtAssetWriteOff;
  internal MGAButton btnSave;
  internal RadioButton radioUseBillingDate;
  internal RadioButton radioUseEffectiveDate;
  internal MGAButton buttonClose;
  private Panel panel1;
  private UltraLabel ultraLabel1;
  private Panel panel2;
  private PictureBox pictureBox1;
  private Label label4;
  private Label label5;
  internal Label label6;
  internal Label label7;
  internal Label label8;
  internal Label label9;
  private UltraLabel ultraLabel4;
  private UltraLabel ultraLabel3;
  private UltraLabel ultraLabel8;
  private UltraLabel ultraLabel2;
  private UltraLabel ultraLabel5;
  private UltraLabel ultraLabel6;
  private Panel panel3;
  private Panel panel4;
  private System.ComponentModel.Container components;
  private int _glCompanyId;

  public formExtendedSettings()
  {
    this.InitializeComponent();
    this.LoadOfficeLocations();
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
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    ResourceManager resourceManager = new ResourceManager(typeof (formExtendedSettings));
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    this.cmbOfficeLocations = new MGASimpleComboBox();
    this.Label3 = new Label();
    this.optReceivables = new RadioButton();
    this.optPayables = new RadioButton();
    this.optFull = new RadioButton();
    this.optPropotional = new RadioButton();
    this.txtLiabilityWriteOff = new MGATextBox();
    this.Label1 = new Label();
    this.Label2 = new Label();
    this.txtAssetWriteOff = new MGATextBox();
    this.radioUseBillingDate = new RadioButton();
    this.radioUseEffectiveDate = new RadioButton();
    this.btnSave = new MGAButton();
    this.daGetOfficeLocations = new SqlDataAdapter();
    this.SqlSelectCommand1 = new SqlCommand();
    this.FormDataConnection = new SqlConnection();
    this.buttonClose = new MGAButton();
    this.panel1 = new Panel();
    this.ultraLabel1 = new UltraLabel();
    this.panel2 = new Panel();
    this.pictureBox1 = new PictureBox();
    this.label4 = new Label();
    this.label5 = new Label();
    this.label6 = new Label();
    this.label7 = new Label();
    this.label8 = new Label();
    this.label9 = new Label();
    this.ultraLabel4 = new UltraLabel();
    this.ultraLabel3 = new UltraLabel();
    this.ultraLabel8 = new UltraLabel();
    this.ultraLabel2 = new UltraLabel();
    this.ultraLabel5 = new UltraLabel();
    this.ultraLabel6 = new UltraLabel();
    this.panel3 = new Panel();
    this.panel4 = new Panel();
    ((ISupportInitialize) this.cmbOfficeLocations).BeginInit();
    ((ISupportInitialize) this.txtLiabilityWriteOff).BeginInit();
    ((ISupportInitialize) this.txtAssetWriteOff).BeginInit();
    ((ISupportInitialize) this.btnSave).BeginInit();
    ((ISupportInitialize) this.buttonClose).BeginInit();
    this.panel1.SuspendLayout();
    this.panel2.SuspendLayout();
    this.panel3.SuspendLayout();
    this.panel4.SuspendLayout();
    this.SuspendLayout();
    this.cmbOfficeLocations.BorderStyle = (UIElementBorderStyle) 4;
    this.cmbOfficeLocations.CharacterCasing = CharacterCasing.Normal;
    ((UltraGridBase) this.cmbOfficeLocations).DataMember = "spFin_GetOfficeLocations";
    ((UltraDropDownBase) this.cmbOfficeLocations).DisplayMember = "Office Location";
    this.cmbOfficeLocations.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cmbOfficeLocations).Location = new Point(232, 112 /*0x70*/);
    this.cmbOfficeLocations.MGAStyle = MGAStyles.Blue;
    ((Control) this.cmbOfficeLocations).Name = "cmbOfficeLocations";
    ((Control) this.cmbOfficeLocations).Size = new Size(280, 20);
    ((Control) this.cmbOfficeLocations).TabIndex = 9;
    ((UltraDropDownBase) this.cmbOfficeLocations).ValueMember = "ID";
    this.cmbOfficeLocations.RowSelected += new RowSelectedEventHandler(this.cmbOfficeLocations_RowSelected);
    this.Label3.AutoSize = true;
    this.Label3.BackColor = Color.Transparent;
    this.Label3.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label3.Location = new Point(224 /*0xE0*/, 96 /*0x60*/);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(90, 17);
    this.Label3.TabIndex = 8;
    this.Label3.Text = "Office Location";
    this.optReceivables.BackColor = Color.Transparent;
    this.optReceivables.Checked = true;
    this.optReceivables.FlatStyle = FlatStyle.Flat;
    this.optReceivables.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.optReceivables.Location = new Point(8, 8);
    this.optReceivables.Name = "optReceivables";
    this.optReceivables.Size = new Size(88, 16 /*0x10*/);
    this.optReceivables.TabIndex = 0;
    this.optReceivables.TabStop = true;
    this.optReceivables.Tag = (object) "CommReconciliation";
    this.optReceivables.Text = "Receivables";
    this.optPayables.BackColor = Color.Transparent;
    this.optPayables.FlatStyle = FlatStyle.Flat;
    this.optPayables.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.optPayables.Location = new Point(104, 8);
    this.optPayables.Name = "optPayables";
    this.optPayables.Size = new Size(72, 16 /*0x10*/);
    this.optPayables.TabIndex = 1;
    this.optPayables.Tag = (object) "CommReconciliation";
    this.optPayables.Text = "Payables";
    this.optFull.BackColor = Color.Transparent;
    this.optFull.FlatStyle = FlatStyle.Flat;
    this.optFull.Location = new Point(200, 8);
    this.optFull.Name = "optFull";
    this.optFull.Size = new Size(176 /*0xB0*/, 16 /*0x10*/);
    this.optFull.TabIndex = 1;
    this.optFull.Text = "Recognize Full Commission";
    this.optPropotional.BackColor = Color.Transparent;
    this.optPropotional.Checked = true;
    this.optPropotional.FlatStyle = FlatStyle.Flat;
    this.optPropotional.Location = new Point(8, 8);
    this.optPropotional.Name = "optPropotional";
    this.optPropotional.Size = new Size(192 /*0xC0*/, 16 /*0x10*/);
    this.optPropotional.TabIndex = 0;
    this.optPropotional.TabStop = true;
    this.optPropotional.Text = "Recognize Income Proportionally";
    ((AppearanceBase) appearance1).BackColor = Color.White;
    ((AppearanceBase) appearance1).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance1).ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtLiabilityWriteOff).Appearance = (AppearanceBase) appearance1;
    ((Control) this.txtLiabilityWriteOff).Location = new Point(304, 328);
    this.txtLiabilityWriteOff.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtLiabilityWriteOff).Name = "txtLiabilityWriteOff";
    ((Control) this.txtLiabilityWriteOff).Size = new Size(96 /*0x60*/, 20);
    ((Control) this.txtLiabilityWriteOff).TabIndex = 18;
    ((Control) this.txtLiabilityWriteOff).Tag = (object) "LiabliltyWriteOff";
    ((Control) this.txtLiabilityWriteOff).Text = "$0.00";
    ((Control) this.txtLiabilityWriteOff).Leave += new EventHandler(this.FormatCurrencyFields);
    this.Label1.AutoSize = true;
    this.Label1.BackColor = Color.Transparent;
    this.Label1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label1.Location = new Point(240 /*0xF0*/, 304);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(41, 16 /*0x10*/);
    this.Label1.TabIndex = 15;
    this.Label1.Text = "Assets:";
    this.Label2.AutoSize = true;
    this.Label2.BackColor = Color.Transparent;
    this.Label2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label2.Location = new Point(240 /*0xF0*/, 328);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(54, 16 /*0x10*/);
    this.Label2.TabIndex = 17;
    this.Label2.Text = "Liabilities:";
    ((AppearanceBase) appearance2).BackColor = Color.White;
    ((AppearanceBase) appearance2).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance2).ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtAssetWriteOff).Appearance = (AppearanceBase) appearance2;
    ((Control) this.txtAssetWriteOff).Location = new Point(304, 304);
    this.txtAssetWriteOff.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtAssetWriteOff).Name = "txtAssetWriteOff";
    ((Control) this.txtAssetWriteOff).Size = new Size(96 /*0x60*/, 20);
    ((Control) this.txtAssetWriteOff).TabIndex = 16 /*0x10*/;
    ((Control) this.txtAssetWriteOff).Tag = (object) "AssetWriteOff";
    ((Control) this.txtAssetWriteOff).Text = "$0.00";
    ((Control) this.txtAssetWriteOff).Leave += new EventHandler(this.FormatCurrencyFields);
    this.radioUseBillingDate.BackColor = Color.Transparent;
    this.radioUseBillingDate.Checked = true;
    this.radioUseBillingDate.FlatStyle = FlatStyle.Flat;
    this.radioUseBillingDate.Location = new Point(232, 384);
    this.radioUseBillingDate.Name = "radioUseBillingDate";
    this.radioUseBillingDate.Size = new Size(144 /*0x90*/, 16 /*0x10*/);
    this.radioUseBillingDate.TabIndex = 20;
    this.radioUseBillingDate.TabStop = true;
    this.radioUseBillingDate.Text = "Use Invoice Billing Date";
    this.radioUseEffectiveDate.BackColor = Color.Transparent;
    this.radioUseEffectiveDate.FlatStyle = FlatStyle.Flat;
    this.radioUseEffectiveDate.Location = new Point(384, 384);
    this.radioUseEffectiveDate.Name = "radioUseEffectiveDate";
    this.radioUseEffectiveDate.Size = new Size(176 /*0xB0*/, 16 /*0x10*/);
    this.radioUseEffectiveDate.TabIndex = 21;
    this.radioUseEffectiveDate.Text = "Use Effective Date of Coverage";
    ((Control) this.btnSave).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
    ((AppearanceBase) appearance3).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance3).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance3).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance3).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance3).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance3).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnSave).Appearance = (AppearanceBase) appearance3;
    ((Control) this.btnSave).Location = new Point(272, 16 /*0x10*/);
    ((Control) this.btnSave).Name = "btnSave";
    ((Control) this.btnSave).Size = new Size(168, 24);
    ((Control) this.btnSave).TabIndex = 0;
    ((Control) this.btnSave).Text = "Save Configuration";
    ((Control) this.btnSave).Click += new EventHandler(this.btnSave_Click);
    this.daGetOfficeLocations.SelectCommand = this.SqlSelectCommand1;
    this.daGetOfficeLocations.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "spFin_GetOfficeLocations", new DataColumnMapping[2]
      {
        new DataColumnMapping("ID", "ID"),
        new DataColumnMapping("Office Location", "Office Location")
      })
    });
    this.SqlSelectCommand1.CommandText = "[spFin_GetOfficeLocations]";
    this.SqlSelectCommand1.CommandType = CommandType.StoredProcedure;
    this.SqlSelectCommand1.Connection = this.FormDataConnection;
    this.SqlSelectCommand1.Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null));
    this.FormDataConnection.ConnectionString = "workstation id=WREYES;packet size=4096;user id=mgasystems;data source=MGASYSTEMS;persist security info=False;initial catalog=IMS";
    ((Control) this.buttonClose).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
    ((AppearanceBase) appearance4).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance4).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance4).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance4).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance4).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance4).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonClose).Appearance = (AppearanceBase) appearance4;
    ((Control) this.buttonClose).Location = new Point(448, 16 /*0x10*/);
    ((Control) this.buttonClose).Name = "buttonClose";
    ((Control) this.buttonClose).Size = new Size(168, 24);
    ((Control) this.buttonClose).TabIndex = 1;
    ((Control) this.buttonClose).Text = "Cancel";
    ((Control) this.buttonClose).Click += new EventHandler(this.buttonClose_Click);
    this.panel1.BackColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.panel1.Controls.Add((Control) this.btnSave);
    this.panel1.Controls.Add((Control) this.buttonClose);
    this.panel1.Dock = DockStyle.Bottom;
    this.panel1.Location = new Point(0, 422);
    this.panel1.Name = "panel1";
    this.panel1.Size = new Size(632, 56);
    this.panel1.TabIndex = 22;
    ((AppearanceBase) appearance5).BackColor = Color.White;
    ((AppearanceBase) appearance5).BackColor2 = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance5).BackGradientStyle = (GradientStyle) 2;
    ((ControlBase) this.ultraLabel1).Appearance = (AppearanceBase) appearance5;
    ((Control) this.ultraLabel1).Dock = DockStyle.Left;
    ((Control) this.ultraLabel1).Location = new Point(0, 80 /*0x50*/);
    ((Control) this.ultraLabel1).Name = "ultraLabel1";
    ((Control) this.ultraLabel1).Size = new Size(208 /*0xD0*/, 342);
    ((Control) this.ultraLabel1).TabIndex = 1;
    this.panel2.Controls.Add((Control) this.label5);
    this.panel2.Controls.Add((Control) this.label4);
    this.panel2.Controls.Add((Control) this.pictureBox1);
    this.panel2.Dock = DockStyle.Top;
    this.panel2.Location = new Point(0, 0);
    this.panel2.Name = "panel2";
    this.panel2.Size = new Size(632, 80 /*0x50*/);
    this.panel2.TabIndex = 0;
    this.pictureBox1.Image = (Image) resourceManager.GetObject("pictureBox1.Image");
    this.pictureBox1.Location = new Point(16 /*0x10*/, 8);
    this.pictureBox1.Name = "pictureBox1";
    this.pictureBox1.Size = new Size(84, 65);
    this.pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
    this.pictureBox1.TabIndex = 0;
    this.pictureBox1.TabStop = false;
    this.label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.label4.AutoSize = true;
    this.label4.Font = new Font("Arial", 12f, FontStyle.Bold);
    this.label4.ForeColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.label4.Location = new Point(376, 56);
    this.label4.Name = "label4";
    this.label4.Size = new Size((int) byte.MaxValue, 22);
    this.label4.TabIndex = 0;
    this.label4.Text = "Extended Settings Management";
    this.label5.BackColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.label5.Dock = DockStyle.Bottom;
    this.label5.Location = new Point(0, 79);
    this.label5.Name = "label5";
    this.label5.Size = new Size(632, 1);
    this.label5.TabIndex = 1;
    this.label6.AutoSize = true;
    this.label6.BackColor = Color.Transparent;
    this.label6.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.label6.Location = new Point(224 /*0xE0*/, 224 /*0xE0*/);
    this.label6.Name = "label6";
    this.label6.Size = new Size(145, 17);
    this.label6.TabIndex = 12;
    this.label6.Text = "Commission Recognition";
    this.label7.AutoSize = true;
    this.label7.BackColor = Color.Transparent;
    this.label7.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.label7.Location = new Point(224 /*0xE0*/, 160 /*0xA0*/);
    this.label7.Name = "label7";
    this.label7.Size = new Size(157, 17);
    this.label7.TabIndex = 10;
    this.label7.Text = "Commission Reconciliation";
    this.label8.AutoSize = true;
    this.label8.BackColor = Color.Transparent;
    this.label8.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.label8.Location = new Point(224 /*0xE0*/, 280);
    this.label8.Name = "label8";
    this.label8.Size = new Size(123, 17);
    this.label8.TabIndex = 14;
    this.label8.Text = "Write-Off Thresholds";
    this.label9.AutoSize = true;
    this.label9.BackColor = Color.Transparent;
    this.label9.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.label9.Location = new Point(224 /*0xE0*/, 360);
    this.label9.Name = "label9";
    this.label9.Size = new Size(141, 17);
    this.label9.TabIndex = 19;
    this.label9.Text = "Post Date Configuration";
    ((AppearanceBase) appearance6).BackColor = Color.White;
    ((AppearanceBase) appearance6).BackColor2 = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance6).BackGradientAlignment = (GradientAlignment) 3;
    ((AppearanceBase) appearance6).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance6).ForeColor = Color.Gray;
    ((ControlBase) this.ultraLabel4).Appearance = (AppearanceBase) appearance6;
    ((Control) this.ultraLabel4).AutoSize = true;
    ((Control) this.ultraLabel4).Location = new Point(32 /*0x20*/, 112 /*0x70*/);
    ((Control) this.ultraLabel4).Name = "ultraLabel4";
    ((Control) this.ultraLabel4).Size = new Size(128 /*0x80*/, 15);
    ((Control) this.ultraLabel4).TabIndex = 3;
    ((Control) this.ultraLabel4).Text = "Select an Office Location";
    ((AppearanceBase) appearance7).BackColor = Color.White;
    ((AppearanceBase) appearance7).BackColor2 = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance7).BackGradientAlignment = (GradientAlignment) 3;
    ((AppearanceBase) appearance7).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance7).ForeColor = Color.Gray;
    ((ControlBase) this.ultraLabel3).Appearance = (AppearanceBase) appearance7;
    ((Control) this.ultraLabel3).AutoSize = true;
    ((Control) this.ultraLabel3).Location = new Point(32 /*0x20*/, 144 /*0x90*/);
    ((Control) this.ultraLabel3).Name = "ultraLabel3";
    ((Control) this.ultraLabel3).Size = new Size(180, 15);
    ((Control) this.ultraLabel3).TabIndex = 4;
    ((Control) this.ultraLabel3).Text = "Commission Reconciliation Settings";
    ((AppearanceBase) appearance8).BackColor = Color.White;
    ((AppearanceBase) appearance8).BackColor2 = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance8).BackGradientAlignment = (GradientAlignment) 2;
    ((AppearanceBase) appearance8).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance8).ForeColor = Color.Gray;
    ((ControlBase) this.ultraLabel8).Appearance = (AppearanceBase) appearance8;
    ((Control) this.ultraLabel8).AutoSize = true;
    ((Control) this.ultraLabel8).Font = new Font("Tahoma", 8f, FontStyle.Bold);
    ((Control) this.ultraLabel8).Location = new Point(16 /*0x10*/, 88);
    ((Control) this.ultraLabel8).Name = "ultraLabel8";
    ((Control) this.ultraLabel8).Size = new Size(123, 15);
    ((Control) this.ultraLabel8).TabIndex = 2;
    ((Control) this.ultraLabel8).Text = "EXTENDED SETTINGS";
    ((AppearanceBase) appearance9).BackColor = Color.White;
    ((AppearanceBase) appearance9).BackColor2 = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance9).BackGradientAlignment = (GradientAlignment) 3;
    ((AppearanceBase) appearance9).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance9).ForeColor = Color.Gray;
    ((ControlBase) this.ultraLabel2).Appearance = (AppearanceBase) appearance9;
    ((Control) this.ultraLabel2).AutoSize = true;
    ((Control) this.ultraLabel2).Location = new Point(32 /*0x20*/, 176 /*0xB0*/);
    ((Control) this.ultraLabel2).Name = "ultraLabel2";
    ((Control) this.ultraLabel2).Size = new Size(169, 15);
    ((Control) this.ultraLabel2).TabIndex = 5;
    ((Control) this.ultraLabel2).Text = "Commission Recognition Settings";
    ((AppearanceBase) appearance10).BackColor = Color.White;
    ((AppearanceBase) appearance10).BackColor2 = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance10).BackGradientAlignment = (GradientAlignment) 3;
    ((AppearanceBase) appearance10).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance10).ForeColor = Color.Gray;
    ((ControlBase) this.ultraLabel5).Appearance = (AppearanceBase) appearance10;
    ((Control) this.ultraLabel5).AutoSize = true;
    ((Control) this.ultraLabel5).Location = new Point(32 /*0x20*/, 208 /*0xD0*/);
    ((Control) this.ultraLabel5).Name = "ultraLabel5";
    ((Control) this.ultraLabel5).Size = new Size(108, 15);
    ((Control) this.ultraLabel5).TabIndex = 6;
    ((Control) this.ultraLabel5).Text = "Write-Off Thresholds";
    ((AppearanceBase) appearance11).BackColor = Color.White;
    ((AppearanceBase) appearance11).BackColor2 = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance11).BackGradientAlignment = (GradientAlignment) 3;
    ((AppearanceBase) appearance11).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance11).ForeColor = Color.Gray;
    ((ControlBase) this.ultraLabel6).Appearance = (AppearanceBase) appearance11;
    ((Control) this.ultraLabel6).AutoSize = true;
    ((Control) this.ultraLabel6).Location = new Point(32 /*0x20*/, 240 /*0xF0*/);
    ((Control) this.ultraLabel6).Name = "ultraLabel6";
    ((Control) this.ultraLabel6).Size = new Size(123, 15);
    ((Control) this.ultraLabel6).TabIndex = 7;
    ((Control) this.ultraLabel6).Text = "Post Date Configuration";
    this.panel3.Controls.Add((Control) this.optReceivables);
    this.panel3.Controls.Add((Control) this.optPayables);
    this.panel3.Location = new Point(224 /*0xE0*/, 176 /*0xB0*/);
    this.panel3.Name = "panel3";
    this.panel3.Size = new Size(200, 32 /*0x20*/);
    this.panel3.TabIndex = 11;
    this.panel4.Controls.Add((Control) this.optFull);
    this.panel4.Controls.Add((Control) this.optPropotional);
    this.panel4.Location = new Point(224 /*0xE0*/, 240 /*0xF0*/);
    this.panel4.Name = "panel4";
    this.panel4.Size = new Size(384, 32 /*0x20*/);
    this.panel4.TabIndex = 13;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.ClientSize = new Size(632, 478);
    this.ControlBox = false;
    this.Controls.Add((Control) this.panel4);
    this.Controls.Add((Control) this.panel3);
    this.Controls.Add((Control) this.radioUseEffectiveDate);
    this.Controls.Add((Control) this.ultraLabel6);
    this.Controls.Add((Control) this.ultraLabel5);
    this.Controls.Add((Control) this.ultraLabel2);
    this.Controls.Add((Control) this.ultraLabel4);
    this.Controls.Add((Control) this.ultraLabel3);
    this.Controls.Add((Control) this.ultraLabel8);
    this.Controls.Add((Control) this.label9);
    this.Controls.Add((Control) this.label8);
    this.Controls.Add((Control) this.label7);
    this.Controls.Add((Control) this.label6);
    this.Controls.Add((Control) this.ultraLabel1);
    this.Controls.Add((Control) this.panel1);
    this.Controls.Add((Control) this.panel2);
    this.Controls.Add((Control) this.cmbOfficeLocations);
    this.Controls.Add((Control) this.Label3);
    this.Controls.Add((Control) this.txtAssetWriteOff);
    this.Controls.Add((Control) this.txtLiabilityWriteOff);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.radioUseBillingDate);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ForeColor = Color.Black;
    this.Name = nameof (formExtendedSettings);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Extended Settings";
    ((ISupportInitialize) this.cmbOfficeLocations).EndInit();
    ((ISupportInitialize) this.txtLiabilityWriteOff).EndInit();
    ((ISupportInitialize) this.txtAssetWriteOff).EndInit();
    ((ISupportInitialize) this.btnSave).EndInit();
    ((ISupportInitialize) this.buttonClose).EndInit();
    this.panel1.ResumeLayout(false);
    this.panel2.ResumeLayout(false);
    this.panel3.ResumeLayout(false);
    this.panel4.ResumeLayout(false);
    this.ResumeLayout(false);
  }

  private void LoadOfficeLocations()
  {
    ((UltraGridBase) this.cmbOfficeLocations).DataSource = (object) Methods.GetOfficeLocationDataset();
    ((UltraDropDownBase) this.cmbOfficeLocations).DisplayMember = "Office Location";
    ((UltraDropDownBase) this.cmbOfficeLocations).ValueMember = "ID";
  }

  private void FormatCurrencyFields(object sender, EventArgs e)
  {
    if (!(sender is MGATextBox) || !Utility.IsDecimalValue((object) ((Control) (sender as MGATextBox)).Text))
      return;
    ((Control) (sender as MGATextBox)).Text = Decimal.Parse(((Control) (sender as MGATextBox)).Text, NumberStyles.Currency).ToString("c");
  }

  private void cmbOfficeLocations_RowSelected(object sender, RowSelectedEventArgs e)
  {
    if (((UltraDropDownBase) this.cmbOfficeLocations).SelectedRow == null)
      return;
    this._glCompanyId = int.Parse(((UltraDropDownBase) this.cmbOfficeLocations).SelectedRow.Cells["id"].Value.ToString());
    this.LoadSettings(this._glCompanyId);
  }

  private void LoadSettings(int glCompanyId)
  {
    DataTable dataTable = DefaultDatabase.ExecuteDataTable("spFin_GetExtendedSetting", new object[2]
    {
      (object) "@glcompanyid",
      (object) glCompanyId
    });
    if (dataTable == null || dataTable.Rows.Count == 0)
      return;
    foreach (DataRow row in (InternalDataCollectionBase) dataTable.Rows)
    {
      switch (row["setting"].ToString())
      {
        case "CommReconciliation":
          if (!row["settingnumvalue"].Equals((object) DBNull.Value))
          {
            this.optPayables.Checked = Decimal.Parse(row["settingnumvalue"].ToString()) == 2M;
            this.optReceivables.Checked = !this.optPayables.Checked;
            continue;
          }
          continue;
        case "AssetWriteOff":
          if (row["settingnumvalue"].Equals((object) DBNull.Value))
          {
            ((Control) this.txtAssetWriteOff).Text = Decimal.Parse("0").ToString("c");
            continue;
          }
          ((Control) this.txtAssetWriteOff).Text = Decimal.Parse(row["settingnumvalue"].ToString()).ToString("c");
          continue;
        case "LiabilityWriteOff":
          if (row["settingnumvalue"].Equals((object) DBNull.Value))
          {
            ((Control) this.txtLiabilityWriteOff).Text = Decimal.Parse("0").ToString("c");
            continue;
          }
          ((Control) this.txtLiabilityWriteOff).Text = Decimal.Parse(row["settingnumvalue"].ToString()).ToString("c");
          continue;
        case "CommRecognition":
          if (row["settingstringvalue"].Equals((object) DBNull.Value))
          {
            this.optPropotional.Checked = false;
            this.optFull.Checked = !this.optPropotional.Checked;
            continue;
          }
          this.optPropotional.Checked = row["settingstringvalue"].ToString().Equals("P");
          this.optFull.Checked = !this.optPropotional.Checked;
          continue;
        case "PostDateConfiguration":
          if (row["settingstringvalue"].Equals((object) DBNull.Value))
          {
            this.radioUseEffectiveDate.Checked = false;
            this.radioUseBillingDate.Checked = !this.radioUseEffectiveDate.Checked;
            continue;
          }
          this.radioUseEffectiveDate.Checked = row["settingstringvalue"].ToString().Equals("E");
          this.radioUseBillingDate.Checked = !this.radioUseEffectiveDate.Checked;
          continue;
        default:
          continue;
      }
    }
  }

  private void SaveCommissionReconciliationSettings(SqlCommand cmd, int glCompanyId)
  {
    cmd.CommandType = CommandType.StoredProcedure;
    cmd.CommandText = "spFin_InsertExtendedSettings";
    cmd.Parameters.Clear();
    cmd.Parameters.AddWithValue("@glcompanyid", (object) glCompanyId);
    cmd.Parameters.AddWithValue("@setting", (object) "CommReconciliation");
    cmd.Parameters.AddWithValue("@settingnumvalue", (object) (this.optReceivables.Checked ? 1.00M : 2.00M));
    cmd.ExecuteNonQuery();
    CurrentUser.Instance.LogAction($"User set commission reconciliation to {(this.optReceivables.Checked ? 1.00M : 2.00M)}", "Accounting");
  }

  private void SaveCommissionRecognitionSettings(SqlCommand cmd, int glCompanyId)
  {
    cmd.CommandType = CommandType.StoredProcedure;
    cmd.CommandText = "spFin_InsertExtendedSettings";
    cmd.Parameters.Clear();
    cmd.Parameters.AddWithValue("@glcompanyid", (object) glCompanyId);
    cmd.Parameters.AddWithValue("@setting", (object) "CommRecognition");
    cmd.Parameters.AddWithValue("@settingstringvalue", this.optFull.Checked ? (object) "F" : (object) "P");
    cmd.ExecuteNonQuery();
    CurrentUser.Instance.LogAction("User set commission recognition to " + (this.optFull.Checked ? "Full" : "Proportional"), "Accounting");
  }

  private void SaveReceivablesWriteOffSettings(SqlCommand cmd, int glCompanyId)
  {
    cmd.CommandType = CommandType.StoredProcedure;
    cmd.CommandText = "spFin_InsertExtendedSettings";
    cmd.Parameters.Clear();
    cmd.Parameters.AddWithValue("@glcompanyid", (object) glCompanyId);
    cmd.Parameters.AddWithValue("@setting", (object) "AssetWriteOff");
    cmd.Parameters.AddWithValue("@settingnumvalue", (object) Decimal.Parse(((Control) this.txtAssetWriteOff).Text, NumberStyles.Currency));
    cmd.ExecuteNonQuery();
    CurrentUser.Instance.LogAction("User set asset write-off amount to " + Decimal.Parse(((Control) this.txtAssetWriteOff).Text, NumberStyles.Currency).ToString("c"), "Accounting");
  }

  private void SavePayablesWriteOffSettings(SqlCommand cmd, int glCompanyId)
  {
    cmd.CommandType = CommandType.StoredProcedure;
    cmd.CommandText = "spFin_InsertExtendedSettings";
    cmd.Parameters.Clear();
    cmd.Parameters.AddWithValue("@glcompanyid", (object) glCompanyId);
    cmd.Parameters.AddWithValue("@setting", (object) "LiabilityWriteOff");
    cmd.Parameters.AddWithValue("@settingnumvalue", (object) Decimal.Parse(((Control) this.txtLiabilityWriteOff).Text, NumberStyles.Currency));
    cmd.ExecuteNonQuery();
    CurrentUser.Instance.LogAction("User set liability write-off amount to " + Decimal.Parse(((Control) this.txtLiabilityWriteOff).Text, NumberStyles.Currency).ToString("c"), "Accounting");
  }

  private void SavePostDateConfigurationSettings(SqlCommand cmd, int glCompanyId)
  {
    cmd.CommandType = CommandType.StoredProcedure;
    cmd.CommandText = "spFin_InsertExtendedSettings";
    cmd.Parameters.Clear();
    cmd.Parameters.AddWithValue("@glcompanyid", (object) glCompanyId);
    cmd.Parameters.AddWithValue("@setting", (object) "PostDateConfiguration");
    cmd.Parameters.AddWithValue("@settingstringvalue", this.radioUseBillingDate.Checked ? (object) "B" : (object) "E");
    cmd.ExecuteNonQuery();
    CurrentUser.Instance.LogAction("User set post date configuration to " + (this.radioUseBillingDate.Checked ? "Billing Date" : "Effective Date"), "Accounting");
  }

  private void buttonClose_Click(object sender, EventArgs e)
  {
    this.DialogResult = DialogResult.Cancel;
    this.Close();
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
    if (!this.ValidateForm())
      return;
    using (SqlConnection connection = new SqlConnection(CurrentUser.Instance.ConnectionString))
    {
      using (SqlCommand cmd = new SqlCommand("", connection))
      {
        try
        {
          cmd.Connection.Open();
          cmd.Transaction = cmd.Connection.BeginTransaction();
          this.SaveCommissionReconciliationSettings(cmd, this._glCompanyId);
          this.SaveCommissionRecognitionSettings(cmd, this._glCompanyId);
          this.SaveReceivablesWriteOffSettings(cmd, this._glCompanyId);
          this.SavePayablesWriteOffSettings(cmd, this._glCompanyId);
          this.SavePostDateConfigurationSettings(cmd, this._glCompanyId);
          cmd.Transaction.Commit();
          this.DialogResult = DialogResult.OK;
          this.Close();
        }
        catch (SqlException ex)
        {
          if (cmd.Transaction != null)
            cmd.Transaction.Rollback();
          throw ex;
        }
      }
    }
  }

  private bool ValidateForm()
  {
    if (((UltraDropDownBase) this.cmbOfficeLocations).SelectedRow == null || this._glCompanyId <= 0)
    {
      int num = (int) MessageBox.Show("You must specify a GL Company to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (((Control) this.txtAssetWriteOff).Text.Equals(string.Empty))
    {
      int num = (int) MessageBox.Show("You must specify an asset write off amount to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (!Utilities.IsDecimalValue((object) ((Control) this.txtAssetWriteOff).Text))
    {
      int num = (int) MessageBox.Show("Asset write-off amount must me numeric.", "Invalid Entry!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (((Control) this.txtLiabilityWriteOff).Text.Equals(string.Empty))
    {
      int num = (int) MessageBox.Show("You must specify an liability write off amount to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (Utilities.IsDecimalValue((object) ((Control) this.txtLiabilityWriteOff).Text))
      return true;
    int num1 = (int) MessageBox.Show("Liability write-off amount must me numeric.", "Invalid Entry!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    return false;
  }
}
