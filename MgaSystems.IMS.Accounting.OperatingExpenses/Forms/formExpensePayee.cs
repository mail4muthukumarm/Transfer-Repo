// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.OperatingExpenses.Forms.formExpensePayee
// Assembly: MgaSystems.IMS.Accounting.OperatingExpenses, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 77B4DED4-9019-44D3-8D52-4669B0CA70E1
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.OperatingExpenses.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using MGASystems.AddressResolver;
using MGASystems.Common;
using MGASystems.Common.DataAccess;
using MGASystems.IMS.Accounting.Services;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.OperatingExpenses.Forms;

public class formExpensePayee : AccountingNoteDocumentSupport
{
  private MGATextBox textAccountNumber;
  private AddressResolver_MULTI zipCodeResolver;
  private Label label5;
  private MGATextBox textTaxIDNumber;
  private Label label4;
  private Label label3;
  private MGATextBox textPhone2;
  private MGATextBox textFax;
  private MGATextBox textPhone1;
  internal MGAButton buttonCancel;
  private Label label6;
  private MGAButton buttonDelete;
  private Label label2;
  private MGATextBox textPayeeName;
  private Label label1;
  internal UltraLabel ultraLabel4;
  internal UltraLabel ultraLabel8;
  internal UltraLabel UltraLabel1;
  internal Panel Panel2;
  internal Label label7;
  internal PictureBox PictureBox1;
  internal Label label8;
  internal Panel Panel1;
  private MGAButton buttonSaveExpensePayee;
  private MGATextBox textEmailAddress;
  private Label label9;
  private Label label10;
  private MGACheckBox check1099;
  private Label label11;
  private MGADateTimePicker dateTime1099Effective;
  private System.ComponentModel.Container components;
  private Guid _payeeGuid;

  public formExpensePayee()
  {
    this.InitializeComponent();
    ((Control) this.buttonDelete).Enabled = false;
    this.SetAddressResolverProperties();
  }

  public formExpensePayee(Guid payeeGuid)
  {
    this.InitializeComponent();
    this._payeeGuid = payeeGuid;
    this.DisplayExpensePayee();
    ((Control) this.buttonDelete).Enabled = true;
    this.SetAddressResolverProperties();
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
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (formExpensePayee));
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    this.textAccountNumber = new MGATextBox();
    this.zipCodeResolver = new AddressResolver_MULTI();
    this.label5 = new Label();
    this.textTaxIDNumber = new MGATextBox();
    this.label4 = new Label();
    this.label3 = new Label();
    this.textPhone2 = new MGATextBox();
    this.textFax = new MGATextBox();
    this.textPhone1 = new MGATextBox();
    this.buttonCancel = new MGAButton();
    this.label6 = new Label();
    this.buttonDelete = new MGAButton();
    this.buttonSaveExpensePayee = new MGAButton();
    this.label2 = new Label();
    this.textPayeeName = new MGATextBox();
    this.label1 = new Label();
    this.ultraLabel4 = new UltraLabel();
    this.ultraLabel8 = new UltraLabel();
    this.UltraLabel1 = new UltraLabel();
    this.Panel2 = new Panel();
    this.label7 = new Label();
    this.PictureBox1 = new PictureBox();
    this.label8 = new Label();
    this.Panel1 = new Panel();
    this.textEmailAddress = new MGATextBox();
    this.label9 = new Label();
    this.label10 = new Label();
    this.check1099 = new MGACheckBox();
    this.label11 = new Label();
    this.dateTime1099Effective = new MGADateTimePicker();
    ((ISupportInitialize) this.textAccountNumber).BeginInit();
    ((ISupportInitialize) this.textTaxIDNumber).BeginInit();
    ((ISupportInitialize) this.textPhone2).BeginInit();
    ((ISupportInitialize) this.textFax).BeginInit();
    ((ISupportInitialize) this.textPhone1).BeginInit();
    ((ISupportInitialize) this.buttonCancel).BeginInit();
    ((ISupportInitialize) this.buttonDelete).BeginInit();
    ((ISupportInitialize) this.buttonSaveExpensePayee).BeginInit();
    ((ISupportInitialize) this.textPayeeName).BeginInit();
    this.Panel2.SuspendLayout();
    ((ISupportInitialize) this.PictureBox1).BeginInit();
    this.Panel1.SuspendLayout();
    ((ISupportInitialize) this.textEmailAddress).BeginInit();
    ((ISupportInitialize) this.check1099).BeginInit();
    ((ISupportInitialize) this.dateTime1099Effective).BeginInit();
    this.SuspendLayout();
    ((AppearanceBase) appearance1).BackColor = Color.White;
    ((AppearanceBase) appearance1).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance1).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textAccountNumber).Appearance = (AppearanceBase) appearance1;
    ((Control) this.textAccountNumber).BackColor = Color.White;
    ((Control) this.textAccountNumber).Location = new Point(288, 112 /*0x70*/);
    ((TextEditorControlBase) this.textAccountNumber).MaxLength = 40;
    this.textAccountNumber.MGAStyle = MGAStyles.Blue;
    ((Control) this.textAccountNumber).Name = "textAccountNumber";
    ((Control) this.textAccountNumber).Size = new Size(288, 20);
    ((Control) this.textAccountNumber).TabIndex = 7;
    ((UltraControlBase) this.textAccountNumber).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textAccountNumber).UseOsThemes = (DefaultableBoolean) 2;
    this.zipCodeResolver.Address1 = string.Empty;
    this.zipCodeResolver.Address2 = string.Empty;
    ((Control) this.zipCodeResolver).BackColor = Color.White;
    this.zipCodeResolver.City = string.Empty;
    this.zipCodeResolver.County = string.Empty;
    ((Control) this.zipCodeResolver).Font = new Font("Tahoma", 8f);
    ((Control) this.zipCodeResolver).Location = new Point(192 /*0xC0*/, 128 /*0x80*/);
    this.zipCodeResolver.MGAStyle = MGAStyles.Blue;
    ((Control) this.zipCodeResolver).Name = "zipCodeResolver";
    this.zipCodeResolver.Password = (string) null;
    ((Control) this.zipCodeResolver).Size = new Size(272, 152);
    this.zipCodeResolver.State = string.Empty;
    ((Control) this.zipCodeResolver).TabIndex = 8;
    this.zipCodeResolver.TextAlign = ContentAlignment.TopLeft;
    this.zipCodeResolver.UserID = (string) null;
    this.zipCodeResolver.WebserviceUrl = (string) null;
    this.zipCodeResolver.ZipCode = string.Empty;
    this.zipCodeResolver.ZipCodeExtension = string.Empty;
    this.label5.BackColor = Color.Transparent;
    this.label5.Location = new Point(200, 328);
    this.label5.Name = "label5";
    this.label5.Size = new Size(80 /*0x50*/, 17);
    this.label5.TabIndex = 13;
    this.label5.Text = "Fax:";
    this.label5.TextAlign = ContentAlignment.MiddleLeft;
    ((AppearanceBase) appearance2).BackColor = Color.White;
    ((AppearanceBase) appearance2).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance2).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textTaxIDNumber).Appearance = (AppearanceBase) appearance2;
    ((Control) this.textTaxIDNumber).BackColor = Color.White;
    ((Control) this.textTaxIDNumber).Location = new Point(288, 376);
    ((TextEditorControlBase) this.textTaxIDNumber).MaxLength = 25;
    this.textTaxIDNumber.MGAStyle = MGAStyles.Blue;
    ((Control) this.textTaxIDNumber).Name = "textTaxIDNumber";
    ((Control) this.textTaxIDNumber).Size = new Size(256 /*0x0100*/, 20);
    ((Control) this.textTaxIDNumber).TabIndex = 18;
    ((UltraControlBase) this.textTaxIDNumber).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textTaxIDNumber).UseOsThemes = (DefaultableBoolean) 2;
    this.label4.BackColor = Color.Transparent;
    this.label4.Location = new Point(200, 304);
    this.label4.Name = "label4";
    this.label4.Size = new Size(80 /*0x50*/, 17);
    this.label4.TabIndex = 11;
    this.label4.Text = "Phone 2:";
    this.label4.TextAlign = ContentAlignment.MiddleLeft;
    this.label3.BackColor = Color.Transparent;
    this.label3.Location = new Point(200, 280);
    this.label3.Name = "label3";
    this.label3.Size = new Size(80 /*0x50*/, 17);
    this.label3.TabIndex = 9;
    this.label3.Text = "Phone 1:";
    this.label3.TextAlign = ContentAlignment.MiddleLeft;
    ((AppearanceBase) appearance3).BackColor = Color.White;
    ((AppearanceBase) appearance3).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance3).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textPhone2).Appearance = (AppearanceBase) appearance3;
    ((Control) this.textPhone2).BackColor = Color.White;
    ((Control) this.textPhone2).Location = new Point(288, 304);
    ((TextEditorControlBase) this.textPhone2).MaxLength = 20;
    this.textPhone2.MGAStyle = MGAStyles.Blue;
    ((Control) this.textPhone2).Name = "textPhone2";
    ((Control) this.textPhone2).Size = new Size(160 /*0xA0*/, 20);
    ((Control) this.textPhone2).TabIndex = 12;
    ((UltraControlBase) this.textPhone2).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textPhone2).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance4).BackColor = Color.White;
    ((AppearanceBase) appearance4).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance4).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textFax).Appearance = (AppearanceBase) appearance4;
    ((Control) this.textFax).BackColor = Color.White;
    ((Control) this.textFax).Location = new Point(288, 328);
    ((TextEditorControlBase) this.textFax).MaxLength = 20;
    this.textFax.MGAStyle = MGAStyles.Blue;
    ((Control) this.textFax).Name = "textFax";
    ((Control) this.textFax).Size = new Size(160 /*0xA0*/, 20);
    ((Control) this.textFax).TabIndex = 14;
    ((UltraControlBase) this.textFax).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textFax).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance5).BackColor = Color.White;
    ((AppearanceBase) appearance5).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance5).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textPhone1).Appearance = (AppearanceBase) appearance5;
    ((Control) this.textPhone1).BackColor = Color.White;
    ((Control) this.textPhone1).Location = new Point(288, 280);
    ((TextEditorControlBase) this.textPhone1).MaxLength = 20;
    this.textPhone1.MGAStyle = MGAStyles.Blue;
    ((Control) this.textPhone1).Name = "textPhone1";
    ((Control) this.textPhone1).Size = new Size(160 /*0xA0*/, 20);
    ((Control) this.textPhone1).TabIndex = 10;
    ((UltraControlBase) this.textPhone1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textPhone1).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance6).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance6).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance6).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance6).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance6).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance6).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonCancel).Appearance = (AppearanceBase) appearance6;
    ((Control) this.buttonCancel).Location = new Point(488, 8);
    ((Control) this.buttonCancel).Name = "buttonCancel";
    ((Control) this.buttonCancel).Size = new Size(96 /*0x60*/, 24);
    ((Control) this.buttonCancel).TabIndex = 2;
    ((Control) this.buttonCancel).Text = "Cancel";
    ((UltraControlBase) this.buttonCancel).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonCancel).Click += new EventHandler(this.buttonCancel_Click);
    this.label6.BackColor = Color.Transparent;
    this.label6.Location = new Point(200, 376);
    this.label6.Name = "label6";
    this.label6.Size = new Size(85, 17);
    this.label6.TabIndex = 17;
    this.label6.Text = "Tax ID Number:";
    this.label6.TextAlign = ContentAlignment.MiddleLeft;
    ((AppearanceBase) appearance7).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance7).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance7).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance7).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance7).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance7).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonDelete).Appearance = (AppearanceBase) appearance7;
    ((Control) this.buttonDelete).Location = new Point(384, 8);
    ((Control) this.buttonDelete).Name = "buttonDelete";
    ((Control) this.buttonDelete).Size = new Size(96 /*0x60*/, 24);
    ((Control) this.buttonDelete).TabIndex = 1;
    ((Control) this.buttonDelete).Text = "Delete Payee";
    ((UltraControlBase) this.buttonDelete).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonDelete).Click += new EventHandler(this.buttonDelete_Click);
    ((AppearanceBase) appearance8).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance8).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance8).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance8).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance8).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance8).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonSaveExpensePayee).Appearance = (AppearanceBase) appearance8;
    ((Control) this.buttonSaveExpensePayee).Location = new Point(280, 8);
    ((Control) this.buttonSaveExpensePayee).Name = "buttonSaveExpensePayee";
    ((Control) this.buttonSaveExpensePayee).Size = new Size(96 /*0x60*/, 24);
    ((Control) this.buttonSaveExpensePayee).TabIndex = 0;
    ((Control) this.buttonSaveExpensePayee).Text = "Save Payee";
    ((UltraControlBase) this.buttonSaveExpensePayee).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonSaveExpensePayee).Click += new EventHandler(this.buttonSaveExpensePayee_Click);
    this.label2.BackColor = Color.Transparent;
    this.label2.Location = new Point(200, 112 /*0x70*/);
    this.label2.Name = "label2";
    this.label2.Size = new Size(64 /*0x40*/, 17);
    this.label2.TabIndex = 6;
    this.label2.Text = "Account #:";
    this.label2.TextAlign = ContentAlignment.MiddleLeft;
    ((AppearanceBase) appearance9).BackColor = Color.White;
    ((AppearanceBase) appearance9).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance9).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textPayeeName).Appearance = (AppearanceBase) appearance9;
    ((Control) this.textPayeeName).BackColor = Color.White;
    ((Control) this.textPayeeName).Location = new Point(288, 88);
    ((TextEditorControlBase) this.textPayeeName).MaxLength = 100;
    this.textPayeeName.MGAStyle = MGAStyles.Blue;
    ((Control) this.textPayeeName).Name = "textPayeeName";
    ((Control) this.textPayeeName).Size = new Size(288, 20);
    ((Control) this.textPayeeName).TabIndex = 5;
    ((UltraControlBase) this.textPayeeName).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textPayeeName).UseOsThemes = (DefaultableBoolean) 2;
    this.label1.AutoSize = true;
    this.label1.BackColor = Color.Transparent;
    this.label1.Location = new Point(200, 88);
    this.label1.Name = "label1";
    this.label1.Size = new Size(71, 13);
    this.label1.TabIndex = 4;
    this.label1.Text = "Payee Name:";
    this.label1.TextAlign = ContentAlignment.MiddleLeft;
    ((AppearanceBase) appearance10).BackColor = Color.White;
    ((AppearanceBase) appearance10).BackColor2 = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance10).BackGradientAlignment = (GradientAlignment) 3;
    ((AppearanceBase) appearance10).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance10).ForeColor = Color.Gray;
    ((ControlBase) this.ultraLabel4).Appearance = (AppearanceBase) appearance10;
    ((Control) this.ultraLabel4).AutoSize = true;
    ((Control) this.ultraLabel4).Location = new Point(24, 104);
    ((Control) this.ultraLabel4).Name = "ultraLabel4";
    ((Control) this.ultraLabel4).Size = new Size(121, 15);
    ((Control) this.ultraLabel4).TabIndex = 3;
    ((Control) this.ultraLabel4).Text = "Add/Edit Expense Payee";
    ((AppearanceBase) appearance11).BackColor = Color.White;
    ((AppearanceBase) appearance11).BackColor2 = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance11).BackGradientAlignment = (GradientAlignment) 2;
    ((AppearanceBase) appearance11).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance11).ForeColor = Color.Gray;
    ((ControlBase) this.ultraLabel8).Appearance = (AppearanceBase) appearance11;
    ((Control) this.ultraLabel8).AutoSize = true;
    ((Control) this.ultraLabel8).Font = new Font("Tahoma", 8f, FontStyle.Bold);
    ((Control) this.ultraLabel8).Location = new Point(8, 88);
    ((Control) this.ultraLabel8).Name = "ultraLabel8";
    ((Control) this.ultraLabel8).Size = new Size(177, 15);
    ((Control) this.ultraLabel8).TabIndex = 2;
    ((Control) this.ultraLabel8).Text = "EXPENSE PAYEE MANAGEMENT";
    ((AppearanceBase) appearance12).BackColor = Color.White;
    ((AppearanceBase) appearance12).BackColor2 = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance12).BackGradientStyle = (GradientStyle) 2;
    ((ControlBase) this.UltraLabel1).Appearance = (AppearanceBase) appearance12;
    ((Control) this.UltraLabel1).Dock = DockStyle.Left;
    ((Control) this.UltraLabel1).Location = new Point(0, 80 /*0x50*/);
    ((Control) this.UltraLabel1).Name = "UltraLabel1";
    ((Control) this.UltraLabel1).Size = new Size(192 /*0xC0*/, 371);
    ((Control) this.UltraLabel1).TabIndex = 1;
    this.Panel2.Controls.Add((Control) this.label7);
    this.Panel2.Controls.Add((Control) this.PictureBox1);
    this.Panel2.Controls.Add((Control) this.label8);
    this.Panel2.Dock = DockStyle.Top;
    this.Panel2.Location = new Point(0, 0);
    this.Panel2.Name = "Panel2";
    this.Panel2.Size = new Size(596, 80 /*0x50*/);
    this.Panel2.TabIndex = 0;
    this.label7.BackColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.label7.Dock = DockStyle.Bottom;
    this.label7.ForeColor = Color.FromArgb(239, 247, 253);
    this.label7.Location = new Point(0, 79);
    this.label7.Name = "label7";
    this.label7.Size = new Size(596, 1);
    this.label7.TabIndex = 1;
    this.PictureBox1.Image = (Image) componentResourceManager.GetObject("PictureBox1.Image");
    this.PictureBox1.Location = new Point(8, 8);
    this.PictureBox1.Name = "PictureBox1";
    this.PictureBox1.Size = new Size(70, 70);
    this.PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
    this.PictureBox1.TabIndex = 1;
    this.PictureBox1.TabStop = false;
    this.label8.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.label8.AutoSize = true;
    this.label8.Font = new Font("Arial", 12f, FontStyle.Bold);
    this.label8.ForeColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.label8.Location = new Point(364, 56);
    this.label8.Name = "label8";
    this.label8.Size = new Size(229, 19);
    this.label8.TabIndex = 0;
    this.label8.Text = "Expense Payee Management";
    this.Panel1.BackColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.Panel1.Controls.Add((Control) this.buttonCancel);
    this.Panel1.Controls.Add((Control) this.buttonDelete);
    this.Panel1.Controls.Add((Control) this.buttonSaveExpensePayee);
    this.Panel1.Dock = DockStyle.Bottom;
    this.Panel1.Location = new Point(0, 451);
    this.Panel1.Name = "Panel1";
    this.Panel1.Size = new Size(596, 40);
    this.Panel1.TabIndex = 23;
    ((AppearanceBase) appearance13).BackColor = Color.White;
    ((AppearanceBase) appearance13).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance13).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textEmailAddress).Appearance = (AppearanceBase) appearance13;
    ((Control) this.textEmailAddress).BackColor = Color.White;
    ((Control) this.textEmailAddress).Location = new Point(288, 352);
    ((TextEditorControlBase) this.textEmailAddress).MaxLength = 150;
    this.textEmailAddress.MGAStyle = MGAStyles.Blue;
    ((Control) this.textEmailAddress).Name = "textEmailAddress";
    ((Control) this.textEmailAddress).Size = new Size(256 /*0x0100*/, 20);
    ((Control) this.textEmailAddress).TabIndex = 16 /*0x10*/;
    ((UltraControlBase) this.textEmailAddress).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textEmailAddress).UseOsThemes = (DefaultableBoolean) 2;
    this.label9.BackColor = Color.Transparent;
    this.label9.Location = new Point(200, 352);
    this.label9.Name = "label9";
    this.label9.Size = new Size(85, 17);
    this.label9.TabIndex = 15;
    this.label9.Text = "Email Address:";
    this.label9.TextAlign = ContentAlignment.MiddleLeft;
    this.label10.BackColor = Color.Transparent;
    this.label10.Location = new Point(200, 398);
    this.label10.Name = "label10";
    this.label10.Size = new Size(85, 17);
    this.label10.TabIndex = 19;
    this.label10.Text = "Requires 1099?:";
    this.label10.TextAlign = ContentAlignment.MiddleLeft;
    ((AppearanceBase) appearance14).BorderColor = Color.Gray;
    ((AppearanceBase) appearance14).ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.check1099).Appearance = (AppearanceBase) appearance14;
    ((UltraToggleEditorBase) this.check1099).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.check1099).Location = new Point(289, 398);
    ((Control) this.check1099).Name = "check1099";
    ((Control) this.check1099).Size = new Size(120, 20);
    ((Control) this.check1099).TabIndex = 20;
    this.label11.BackColor = Color.Transparent;
    this.label11.Location = new Point(198, 419);
    this.label11.Name = "label11";
    this.label11.Size = new Size(85, 17);
    this.label11.TabIndex = 21;
    this.label11.Text = "1099 Effective:";
    this.label11.TextAlign = ContentAlignment.MiddleLeft;
    ((AppearanceBase) appearance15).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dateTime1099Effective.Appearance = (AppearanceBase) appearance15;
    ((AppearanceBase) appearance16).AlphaLevel = (short) 14;
    ((AppearanceBase) appearance16).BackColor = Color.FromArgb(0, 0, 246, 253);
    ((AppearanceBase) appearance16).BackColor2 = Color.FromArgb(133, 162, 221);
    ((AppearanceBase) appearance16).BackColorAlpha = (Alpha) 2;
    ((AppearanceBase) appearance16).BackGradientAlignment = (GradientAlignment) 4;
    ((AppearanceBase) appearance16).BackGradientStyle = (GradientStyle) 5;
    ((AppearanceBase) appearance16).BorderAlpha = (Alpha) 1;
    ((AppearanceBase) appearance16).BorderColor = Color.FromArgb(78, 122, 171);
    ((AppearanceBase) appearance16).ForeColor = Color.FromArgb(49, 85, 153);
    ((AppearanceBase) appearance16).ForegroundAlpha = (Alpha) 2;
    this.dateTime1099Effective.ButtonAppearance = (AppearanceBase) appearance16;
    ((Control) this.dateTime1099Effective).Location = new Point(289, 419);
    this.dateTime1099Effective.MGAStyle = MGAStyles.Blue;
    ((Control) this.dateTime1099Effective).Name = "dateTime1099Effective";
    ((Control) this.dateTime1099Effective).Size = new Size(96 /*0x60*/, 20);
    ((Control) this.dateTime1099Effective).TabIndex = 22;
    ((UltraControlBase) this.dateTime1099Effective).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dateTime1099Effective).UseOsThemes = (DefaultableBoolean) 2;
    this.AutoScaleBaseSize = new Size(5, 13);
    this.BackColor = Color.White;
    this.ClientSize = new Size(596, 491);
    this.ControlBox = false;
    this.Controls.Add((Control) this.dateTime1099Effective);
    this.Controls.Add((Control) this.label11);
    this.Controls.Add((Control) this.check1099);
    this.Controls.Add((Control) this.label10);
    this.Controls.Add((Control) this.textEmailAddress);
    this.Controls.Add((Control) this.label9);
    this.Controls.Add((Control) this.ultraLabel4);
    this.Controls.Add((Control) this.ultraLabel8);
    this.Controls.Add((Control) this.UltraLabel1);
    this.Controls.Add((Control) this.Panel2);
    this.Controls.Add((Control) this.Panel1);
    this.Controls.Add((Control) this.textAccountNumber);
    this.Controls.Add((Control) this.zipCodeResolver);
    this.Controls.Add((Control) this.label5);
    this.Controls.Add((Control) this.textTaxIDNumber);
    this.Controls.Add((Control) this.label4);
    this.Controls.Add((Control) this.label3);
    this.Controls.Add((Control) this.textPhone2);
    this.Controls.Add((Control) this.textFax);
    this.Controls.Add((Control) this.textPhone1);
    this.Controls.Add((Control) this.label6);
    this.Controls.Add((Control) this.label2);
    this.Controls.Add((Control) this.textPayeeName);
    this.Controls.Add((Control) this.label1);
    this.Font = new Font("Tahoma", 8f);
    this.ForeColor = Color.Black;
    this.Name = nameof (formExpensePayee);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Add/Edit Expense Payee";
    ((ISupportInitialize) this.textAccountNumber).EndInit();
    ((ISupportInitialize) this.textTaxIDNumber).EndInit();
    ((ISupportInitialize) this.textPhone2).EndInit();
    ((ISupportInitialize) this.textFax).EndInit();
    ((ISupportInitialize) this.textPhone1).EndInit();
    ((ISupportInitialize) this.buttonCancel).EndInit();
    ((ISupportInitialize) this.buttonDelete).EndInit();
    ((ISupportInitialize) this.buttonSaveExpensePayee).EndInit();
    ((ISupportInitialize) this.textPayeeName).EndInit();
    this.Panel2.ResumeLayout(false);
    this.Panel2.PerformLayout();
    ((ISupportInitialize) this.PictureBox1).EndInit();
    this.Panel1.ResumeLayout(false);
    ((ISupportInitialize) this.textEmailAddress).EndInit();
    ((ISupportInitialize) this.check1099).EndInit();
    ((ISupportInitialize) this.dateTime1099Effective).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  private void SaveExpensePayee()
  {
    if (this._payeeGuid.Equals(Guid.Empty))
    {
      Database.Instance.QuerySP.PerformNonQuery("spFin_AddExpensePayee", (object) "@PAYEENAME", (object) ((Control) this.textPayeeName).Text, (object) "@PAYEEACCTNUM", ((Control) this.textAccountNumber).Text == string.Empty ? (object) string.Empty : (object) ((Control) this.textAccountNumber).Text, (object) "@ADDRESS1", (object) this.zipCodeResolver.Address1, (object) "@ADDRESS2", (object) this.zipCodeResolver.Address2, (object) "@CITY", (object) this.zipCodeResolver.City, (object) "@STATE", (object) this.zipCodeResolver.State, (object) "@ZIP", (object) this.zipCodeResolver.ZipCode, (object) "@ZIPPLUS", (object) this.zipCodeResolver.ZipCodeExtension, (object) "@PHONE1", ((Control) this.textPhone1).Text == string.Empty ? (object) string.Empty : (object) ((Control) this.textPhone1).Text, (object) "@PHONE2", ((Control) this.textPhone1).Text == string.Empty ? (object) string.Empty : (object) ((Control) this.textPhone1).Text, (object) "@FAX", ((Control) this.textFax).Text == string.Empty ? (object) string.Empty : (object) ((Control) this.textFax).Text, (object) "@TAXIDNUMBER", ((Control) this.textTaxIDNumber).Text == string.Empty ? (object) string.Empty : (object) ((Control) this.textTaxIDNumber).Text, (object) "@EMAILADDRESS", ((Control) this.textEmailAddress).Text == string.Empty ? (object) string.Empty : (object) ((Control) this.textEmailAddress).Text, (object) "@IS1099", (object) ((UltraToggleEditorBase) this.check1099).Checked);
    }
    else
    {
      if (MessageBox.Show("This will update the current expense payee record, are you sure you wish to continue?", "Update Expense Payee?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
        return;
      Database.Instance.QuerySP.PerformNonQuery("spFin_UpdateExpensePayee", (object) "@PAYEEGUID", (object) this._payeeGuid, (object) "@PAYEENAME", (object) ((Control) this.textPayeeName).Text, (object) "@PAYEEACCTNUM", ((Control) this.textAccountNumber).Text == string.Empty ? (object) string.Empty : (object) ((Control) this.textAccountNumber).Text, (object) "@ADDRESS1", (object) this.zipCodeResolver.Address1, (object) "@ADDRESS2", (object) this.zipCodeResolver.Address2, (object) "@CITY", (object) this.zipCodeResolver.City, (object) "@STATE", (object) this.zipCodeResolver.State, (object) "@ZIP", (object) this.zipCodeResolver.ZipCode, (object) "@ZIPPLUS", (object) this.zipCodeResolver.ZipCodeExtension, (object) "@PHONE1", ((Control) this.textPhone1).Text == string.Empty ? (object) string.Empty : (object) ((Control) this.textPhone1).Text, (object) "@PHONE2", ((Control) this.textPhone2).Text == string.Empty ? (object) string.Empty : (object) ((Control) this.textPhone2).Text, (object) "@FAX", ((Control) this.textFax).Text == string.Empty ? (object) string.Empty : (object) ((Control) this.textFax).Text, (object) "@TAXIDNUMBER", ((Control) this.textTaxIDNumber).Text == string.Empty ? (object) string.Empty : (object) ((Control) this.textTaxIDNumber).Text, (object) "@EMAILADDRESS", ((Control) this.textEmailAddress).Text == string.Empty ? (object) string.Empty : (object) ((Control) this.textEmailAddress).Text, (object) "@IS1099", (object) ((UltraToggleEditorBase) this.check1099).Checked);
    }
    this.DialogResult = DialogResult.OK;
    this.Close();
  }

  private void buttonSaveExpensePayee_Click(object sender, EventArgs e)
  {
    if (!this.ValidateForm())
      return;
    this.SaveExpensePayee();
  }

  private void buttonCancel_Click(object sender, EventArgs e)
  {
    this.DialogResult = DialogResult.Cancel;
    this.Close();
  }

  private void DisplayExpensePayee()
  {
    using (SqlConnection connection = new SqlConnection(CurrentUser.Instance.ConnectionString))
    {
      using (SqlCommand sqlCommand = new SqlCommand("spFin_GetExpensePayee", connection))
      {
        sqlCommand.Parameters.AddWithValue("@PAYEEGUID", (object) this._payeeGuid);
        sqlCommand.CommandType = CommandType.StoredProcedure;
        sqlCommand.Connection.Open();
        SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
        if (!sqlDataReader.Read())
          return;
        ((Control) this.textPayeeName).Text = sqlDataReader["payeeName"].ToString();
        ((Control) this.textAccountNumber).Text = sqlDataReader["PayeeAcctNum"].ToString();
        this.zipCodeResolver.Address1 = sqlDataReader["address1"].ToString();
        this.zipCodeResolver.Address2 = sqlDataReader["address2"].ToString();
        this.zipCodeResolver.City = sqlDataReader["city"].ToString();
        this.zipCodeResolver.State = sqlDataReader["state"].ToString();
        this.zipCodeResolver.ZipCode = sqlDataReader["zip"].ToString();
        this.zipCodeResolver.ZipCodeExtension = sqlDataReader["zipplus"].ToString();
        ((Control) this.textPhone1).Text = sqlDataReader["phone1"].ToString();
        ((Control) this.textPhone2).Text = sqlDataReader["phone2"].ToString();
        ((Control) this.textFax).Text = sqlDataReader["Fax"].ToString();
        ((Control) this.textTaxIDNumber).Text = sqlDataReader["TaxIdNumber"].ToString();
        ((Control) this.textEmailAddress).Text = sqlDataReader["Email"].ToString();
        ((UltraToggleEditorBase) this.check1099).Checked = (bool) sqlDataReader["is1099"];
      }
    }
  }

  private bool ValidateForm()
  {
    if (((Control) this.textPayeeName).Text.Length == 0 || ((object) this.textPayeeName).Equals((object) string.Empty))
    {
      int num = (int) MessageBox.Show("You must enter an expense payee name to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (((ContainerControl) this.zipCodeResolver).Validate())
      return true;
    int num1 = (int) MessageBox.Show("You must enter valid address information to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    return false;
  }

  private void ClearScreen()
  {
    ((Control) this.textPayeeName).Text = string.Empty;
    ((Control) this.textAccountNumber).Text = string.Empty;
    ((Control) this.textPhone1).Text = string.Empty;
    ((Control) this.textPhone2).Text = string.Empty;
    ((Control) this.textFax).Text = string.Empty;
    this.zipCodeResolver.Address1 = string.Empty;
    this.zipCodeResolver.Address1 = string.Empty;
    this.zipCodeResolver.City = string.Empty;
    this.zipCodeResolver.State = string.Empty;
    this.zipCodeResolver.ZipCode = string.Empty;
    this.zipCodeResolver.ZipCodeExtension = string.Empty;
    this.zipCodeResolver.County = string.Empty;
  }

  private void buttonDelete_Click(object sender, EventArgs e)
  {
    if (MessageBox.Show("This will permanently delete this expense payee record, continue?", "Delete Expense Payee?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
      return;
    this.DeleteExpensePayee();
  }

  private void DeleteExpensePayee()
  {
    using (SqlConnection connection = new SqlConnection(CurrentUser.Instance.ConnectionString))
    {
      using (SqlCommand sqlCommand = new SqlCommand($"Select dbo.CanDeleteExpensePayee('{this._payeeGuid.ToString()}')", connection))
      {
        sqlCommand.CommandType = CommandType.Text;
        sqlCommand.Connection.Open();
        if (bool.Parse(sqlCommand.ExecuteScalar().ToString()))
        {
          sqlCommand.CommandText = "spFin_DeleteExpensePayee";
          sqlCommand.Parameters.AddWithValue("@payeeGuid", (object) this._payeeGuid);
          sqlCommand.CommandType = CommandType.StoredProcedure;
          sqlCommand.ExecuteNonQuery();
          this.DialogResult = DialogResult.OK;
          this.Close();
        }
        else
        {
          int num = (int) MessageBox.Show("The system has determined that the expense payee you are trying to delete has checks that have been issue against their account. This expense payee can not be deleted at this time.", "Can Not Delete Expense Payee!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
      }
    }
  }

  private void SetAddressResolverProperties()
  {
    this.zipCodeResolver.UserID = AddressResolverSettings.AddressResolveUserName;
    this.zipCodeResolver.Password = AddressResolverSettings.AddressResolverPassword;
    this.zipCodeResolver.WebserviceUrl = AddressResolverSettings.AddressResolverURL;
  }
}
