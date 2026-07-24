// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.frmEmailInfo
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using MGASystems.Common.DockingManagement;
using MGASystems.Common.Email;
using MGASystems.Data;
using MGASystems.Tools;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using System.Xml;

#nullable disable
namespace MGASystems.Common;

[SecureResource("{8E970393-182B-4B79-813D-842EED7F306F}", "Allow Updating Email Azure Secret", "Allows user ability to update (not view) the Azure secret key for use in blackbox environments.", "Email")]
[SecureResource("{9464E4F2-EA4B-4B37-8FE9-9247F1C0B86B}", "Allow Configure Service User Email", "Allows user the ability to manage a Service User for email settings.", "Email")]
public class frmEmailInfo : FormBase
{
  public const string AllowUpdateAzureSecret = "{8E970393-182B-4B79-813D-842EED7F306F}";
  public const string AllowUpdateServiceUserEmail = "{9464E4F2-EA4B-4B37-8FE9-9247F1C0B86B}";
  private static readonly Guid SecurityAzureSecretGuid = new Guid("{8E970393-182B-4B79-813D-842EED7F306F}");
  private static readonly Guid SecurityServiceUserEmail = new Guid("{9464E4F2-EA4B-4B37-8FE9-9247F1C0B86B}");
  private IContainer components;
  private Guid _userGuid;
  private int _userID;
  private DataTable _usersTable;
  private bool _ctrlPressed;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [field: AccessedThroughProperty("PictureBox1")]
  internal virtual PictureBox PictureBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtEmail")]
  internal virtual MGATextBox txtEmail { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label2")]
  internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label3")]
  internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label4")]
  internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtMailServerAddress")]
  internal virtual MGATextBox txtMailServerAddress { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtMailUserName")]
  internal virtual MGATextBox txtMailUserName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtMailPassword")]
  internal virtual MGATextBox txtMailPassword { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("err")]
  internal virtual ErrorProvider err { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGAButton btnSave
  {
    get => this._btnSave;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnSave_Click);
      MGAButton btnSave1 = this._btnSave;
      if (btnSave1 != null)
        ((Control) btnSave1).Click -= eventHandler;
      this._btnSave = value;
      MGAButton btnSave2 = this._btnSave;
      if (btnSave2 == null)
        return;
      ((Control) btnSave2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("Label6")]
  internal virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label5")]
  internal virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtExchangeServerDomain")]
  internal virtual MGATextBox txtExchangeServerDomain { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual LinkLabel linkTestEmail
  {
    get => this._linkTestEmail;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.linkTestEmail_LinkClicked);
      LinkLabel linkTestEmail1 = this._linkTestEmail;
      if (linkTestEmail1 != null)
        linkTestEmail1.LinkClicked -= clickedEventHandler;
      this._linkTestEmail = value;
      LinkLabel linkTestEmail2 = this._linkTestEmail;
      if (linkTestEmail2 == null)
        return;
      linkTestEmail2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("checkUseOWS")]
  internal virtual MGACheckBox checkUseOWS { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblAzureTenant")]
  internal virtual Label lblAzureTenant { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtAzureTenant")]
  internal virtual MGATextBox txtAzureTenant { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblAzureClient")]
  internal virtual Label lblAzureClient { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtAzureClient")]
  internal virtual MGATextBox txtAzureClient { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblAzureSecret")]
  internal virtual Label lblAzureSecret { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtAzureSecret")]
  internal virtual MGATextBox txtAzureSecret { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGAButton btnCancel
  {
    get => this._btnCancel;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnCancel_Click);
      MGAButton btnCancel1 = this._btnCancel;
      if (btnCancel1 != null)
        ((Control) btnCancel1).Click -= eventHandler;
      this._btnCancel = value;
      MGAButton btnCancel2 = this._btnCancel;
      if (btnCancel2 == null)
        return;
      ((Control) btnCancel2).Click += eventHandler;
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmEmailInfo));
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
    this.PictureBox1 = new PictureBox();
    this.Label1 = new Label();
    this.txtEmail = new MGATextBox();
    this.Label2 = new Label();
    this.txtMailServerAddress = new MGATextBox();
    this.txtMailUserName = new MGATextBox();
    this.txtMailPassword = new MGATextBox();
    this.Label3 = new Label();
    this.Label4 = new Label();
    this.err = new ErrorProvider(this.components);
    this.btnSave = new MGAButton();
    this.btnCancel = new MGAButton();
    this.txtExchangeServerDomain = new MGATextBox();
    this.Label5 = new Label();
    this.Label6 = new Label();
    this.linkTestEmail = new LinkLabel();
    this.checkUseOWS = new MGACheckBox();
    this.txtAzureClient = new MGATextBox();
    this.lblAzureClient = new Label();
    this.txtAzureTenant = new MGATextBox();
    this.lblAzureTenant = new Label();
    this.txtAzureSecret = new MGATextBox();
    this.lblAzureSecret = new Label();
    ((ISupportInitialize) this.PictureBox1).BeginInit();
    ((ISupportInitialize) this.txtEmail).BeginInit();
    ((ISupportInitialize) this.txtMailServerAddress).BeginInit();
    ((ISupportInitialize) this.txtMailUserName).BeginInit();
    ((ISupportInitialize) this.txtMailPassword).BeginInit();
    ((ISupportInitialize) this.err).BeginInit();
    ((ISupportInitialize) this.btnSave).BeginInit();
    ((ISupportInitialize) this.btnCancel).BeginInit();
    ((ISupportInitialize) this.txtExchangeServerDomain).BeginInit();
    ((ISupportInitialize) this.checkUseOWS).BeginInit();
    ((ISupportInitialize) this.txtAzureClient).BeginInit();
    ((ISupportInitialize) this.txtAzureTenant).BeginInit();
    ((ISupportInitialize) this.txtAzureSecret).BeginInit();
    this.SuspendLayout();
    this.PictureBox1.Image = (Image) componentResourceManager.GetObject("PictureBox1.Image");
    this.PictureBox1.Location = new Point(16 /*0x10*/, 16 /*0x10*/);
    this.PictureBox1.Name = "PictureBox1";
    this.PictureBox1.Size = new Size(48 /*0x30*/, 48 /*0x30*/);
    this.PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
    this.PictureBox1.TabIndex = 0;
    this.PictureBox1.TabStop = false;
    this.Label1.AutoSize = true;
    this.Label1.BackColor = Color.Transparent;
    this.Label1.Location = new Point(94, 25);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(77, 13);
    this.Label1.TabIndex = 1;
    this.Label1.Text = "Email Address:";
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance1.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtEmail).Appearance = (AppearanceBase) appearance1;
    ((TextEditorControlBase) this.txtEmail).BackColor = Color.White;
    ((Control) this.txtEmail).Location = new Point(184, 22);
    this.txtEmail.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtEmail).Name = "txtEmail";
    ((Control) this.txtEmail).Size = new Size(232, 20);
    ((Control) this.txtEmail).TabIndex = 0;
    ((UltraControlBase) this.txtEmail).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtEmail).UseOsThemes = (DefaultableBoolean) 2;
    this.Label2.AutoSize = true;
    this.Label2.BackColor = Color.Transparent;
    this.Label2.Location = new Point(104, 50);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(67, 13);
    this.Label2.TabIndex = 3;
    this.Label2.Text = " Mail Server:";
    appearance2.BackColor = Color.White;
    appearance2.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance2.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtMailServerAddress).Appearance = (AppearanceBase) appearance2;
    ((TextEditorControlBase) this.txtMailServerAddress).BackColor = Color.White;
    ((Control) this.txtMailServerAddress).Location = new Point(184, 48 /*0x30*/);
    ((TextEditorControlBase) this.txtMailServerAddress).MaxLength = 100;
    this.txtMailServerAddress.MGAStyle = MGAStyles.Blue;
    this.txtMailServerAddress.Multiline = true;
    ((Control) this.txtMailServerAddress).Name = "txtMailServerAddress";
    ((Control) this.txtMailServerAddress).Size = new Size(232, 45);
    ((Control) this.txtMailServerAddress).TabIndex = 1;
    ((UltraControlBase) this.txtMailServerAddress).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtMailServerAddress).UseOsThemes = (DefaultableBoolean) 2;
    appearance3.BackColor = Color.White;
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance3.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtMailUserName).Appearance = (AppearanceBase) appearance3;
    ((TextEditorControlBase) this.txtMailUserName).BackColor = Color.White;
    ((Control) this.txtMailUserName).Location = new Point(184, 99);
    this.txtMailUserName.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtMailUserName).Name = "txtMailUserName";
    ((Control) this.txtMailUserName).Size = new Size(232, 20);
    ((Control) this.txtMailUserName).TabIndex = 2;
    ((UltraControlBase) this.txtMailUserName).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtMailUserName).UseOsThemes = (DefaultableBoolean) 2;
    appearance4.BackColor = Color.White;
    appearance4.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance4.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtMailPassword).Appearance = (AppearanceBase) appearance4;
    ((TextEditorControlBase) this.txtMailPassword).BackColor = Color.White;
    ((Control) this.txtMailPassword).Location = new Point(184, 123);
    this.txtMailPassword.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtMailPassword).Name = "txtMailPassword";
    this.txtMailPassword.PasswordChar = '*';
    ((Control) this.txtMailPassword).Size = new Size(232, 20);
    ((Control) this.txtMailPassword).TabIndex = 3;
    ((UltraControlBase) this.txtMailPassword).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtMailPassword).UseOsThemes = (DefaultableBoolean) 2;
    this.Label3.AutoSize = true;
    this.Label3.BackColor = Color.Transparent;
    this.Label3.Location = new Point(55, 102);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(116, 13);
    this.Label3.TabIndex = 7;
    this.Label3.Text = "Mail Server UserName:";
    this.Label4.AutoSize = true;
    this.Label4.BackColor = Color.Transparent;
    this.Label4.Location = new Point(55, 126);
    this.Label4.Name = "Label4";
    this.Label4.Size = new Size(116, 13);
    this.Label4.TabIndex = 8;
    this.Label4.Text = " Mail Server Password:";
    this.err.ContainerControl = (ContainerControl) this;
    ((Control) this.btnSave).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance5.BackColor = Color.FromArgb(248, 248, 248);
    appearance5.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance5.BackGradientStyle = (GradientStyle) 2;
    appearance5.BorderColor = Color.DarkGray;
    appearance5.ImageHAlign = (HAlign) 2;
    appearance5.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnSave).Appearance = (AppearanceBase) appearance5;
    ((ControlBase) this.btnSave).ImageSize = new Size(24, 24);
    ((Control) this.btnSave).Location = new Point(320, 288);
    ((Control) this.btnSave).Name = "btnSave";
    ((Control) this.btnSave).Size = new Size(40, 40);
    ((Control) this.btnSave).TabIndex = 5;
    this.btnSave.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.btnCancel).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance6.BackColor = Color.FromArgb(248, 248, 248);
    appearance6.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance6.BackGradientStyle = (GradientStyle) 2;
    appearance6.BorderColor = Color.DarkGray;
    appearance6.ImageHAlign = (HAlign) 2;
    appearance6.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnCancel).Appearance = (AppearanceBase) appearance6;
    ((ControlBase) this.btnCancel).ImageSize = new Size(24, 24);
    ((Control) this.btnCancel).Location = new Point(376, 288);
    ((Control) this.btnCancel).Name = "btnCancel";
    ((Control) this.btnCancel).Size = new Size(40, 40);
    ((Control) this.btnCancel).TabIndex = 6;
    this.btnCancel.UseOSThemes = (DefaultableBoolean) 2;
    appearance7.BackColor = Color.White;
    appearance7.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance7.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtExchangeServerDomain).Appearance = (AppearanceBase) appearance7;
    ((TextEditorControlBase) this.txtExchangeServerDomain).BackColor = Color.White;
    ((Control) this.txtExchangeServerDomain).Location = new Point(184, 149);
    ((TextEditorControlBase) this.txtExchangeServerDomain).MaxLength = 100;
    this.txtExchangeServerDomain.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtExchangeServerDomain).Name = "txtExchangeServerDomain";
    ((Control) this.txtExchangeServerDomain).Size = new Size(232, 20);
    ((Control) this.txtExchangeServerDomain).TabIndex = 4;
    ((UltraControlBase) this.txtExchangeServerDomain).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtExchangeServerDomain).UseOsThemes = (DefaultableBoolean) 2;
    this.Label5.AutoSize = true;
    this.Label5.BackColor = Color.Transparent;
    this.Label5.Location = new Point(66, 152);
    this.Label5.Name = "Label5";
    this.Label5.Size = new Size(105, 13);
    this.Label5.TabIndex = 10;
    this.Label5.Text = " Mail Server Domain:";
    this.Label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.Label6.AutoSize = true;
    this.Label6.BackColor = Color.Transparent;
    this.Label6.Font = new Font("Tahoma", 8.25f, FontStyle.Bold);
    this.Label6.Location = new Point(12, 315);
    this.Label6.Name = "Label6";
    this.Label6.Size = new Size(264, 13);
    this.Label6.TabIndex = 11;
    this.Label6.Text = "If using Exchange provide mail server domain";
    this.linkTestEmail.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.linkTestEmail.AutoSize = true;
    this.linkTestEmail.BackColor = Color.Transparent;
    this.linkTestEmail.Location = new Point(12, 282);
    this.linkTestEmail.Name = "linkTestEmail";
    this.linkTestEmail.Size = new Size(150, 13);
    this.linkTestEmail.TabIndex = 12;
    this.linkTestEmail.TabStop = true;
    this.linkTestEmail.Text = "Click here to send a test email";
    appearance8.BorderColor = Color.Gray;
    appearance8.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.checkUseOWS).Appearance = (AppearanceBase) appearance8;
    ((UltraToggleEditorBase) this.checkUseOWS).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.checkUseOWS).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.checkUseOWS).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.checkUseOWS).Location = new Point(184, 175);
    ((Control) this.checkUseOWS).Name = "checkUseOWS";
    ((Control) this.checkUseOWS).Size = new Size(161, 20);
    ((Control) this.checkUseOWS).TabIndex = 13;
    ((UltraToggleEditorBase) this.checkUseOWS).Text = "Use Outlook Web Services";
    appearance9.BackColor = Color.White;
    appearance9.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance9.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtAzureClient).Appearance = (AppearanceBase) appearance9;
    ((TextEditorControlBase) this.txtAzureClient).BackColor = Color.White;
    ((Control) this.txtAzureClient).Location = new Point(184, 201);
    this.txtAzureClient.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtAzureClient).Name = "txtAzureClient";
    ((Control) this.txtAzureClient).Size = new Size(232, 20);
    ((Control) this.txtAzureClient).TabIndex = 3;
    ((UltraControlBase) this.txtAzureClient).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtAzureClient).UseOsThemes = (DefaultableBoolean) 2;
    this.lblAzureClient.AutoSize = true;
    this.lblAzureClient.BackColor = Color.Transparent;
    this.lblAzureClient.Location = new Point(102, 204);
    this.lblAzureClient.Name = "lblAzureClient";
    this.lblAzureClient.Size = new Size(69, 13);
    this.lblAzureClient.TabIndex = 8;
    this.lblAzureClient.Text = "Azure Client:";
    appearance10.BackColor = Color.White;
    appearance10.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance10.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtAzureTenant).Appearance = (AppearanceBase) appearance10;
    ((TextEditorControlBase) this.txtAzureTenant).BackColor = Color.White;
    ((Control) this.txtAzureTenant).Location = new Point(184, 227);
    ((TextEditorControlBase) this.txtAzureTenant).MaxLength = 100;
    this.txtAzureTenant.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtAzureTenant).Name = "txtAzureTenant";
    ((Control) this.txtAzureTenant).Size = new Size(232, 20);
    ((Control) this.txtAzureTenant).TabIndex = 4;
    ((UltraControlBase) this.txtAzureTenant).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtAzureTenant).UseOsThemes = (DefaultableBoolean) 2;
    this.lblAzureTenant.AutoSize = true;
    this.lblAzureTenant.BackColor = Color.Transparent;
    this.lblAzureTenant.Location = new Point(95, 230);
    this.lblAzureTenant.Name = "lblAzureTenant";
    this.lblAzureTenant.Size = new Size(76, 13);
    this.lblAzureTenant.TabIndex = 10;
    this.lblAzureTenant.Text = "Azure Tenant:";
    appearance11.BackColor = Color.White;
    appearance11.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance11.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtAzureSecret).Appearance = (AppearanceBase) appearance11;
    ((TextEditorControlBase) this.txtAzureSecret).BackColor = Color.White;
    ((Control) this.txtAzureSecret).Location = new Point(184, 253);
    ((TextEditorControlBase) this.txtAzureSecret).MaxLength = 100;
    this.txtAzureSecret.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtAzureSecret).Name = "txtAzureSecret";
    this.txtAzureSecret.PasswordChar = '*';
    ((Control) this.txtAzureSecret).Size = new Size(232, 20);
    ((Control) this.txtAzureSecret).TabIndex = 4;
    ((UltraControlBase) this.txtAzureSecret).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtAzureSecret).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.txtAzureSecret).Visible = false;
    this.lblAzureSecret.AutoSize = true;
    this.lblAzureSecret.BackColor = Color.Transparent;
    this.lblAzureSecret.Location = new Point(98, 256 /*0x0100*/);
    this.lblAzureSecret.Name = "lblAzureSecret";
    this.lblAzureSecret.Size = new Size(73, 13);
    this.lblAzureSecret.TabIndex = 10;
    this.lblAzureSecret.Text = "Azure Secret:";
    this.lblAzureSecret.Visible = false;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.ClientSize = new Size(432, 340);
    this.Controls.Add((Control) this.checkUseOWS);
    this.Controls.Add((Control) this.linkTestEmail);
    this.Controls.Add((Control) this.Label6);
    this.Controls.Add((Control) this.lblAzureSecret);
    this.Controls.Add((Control) this.lblAzureTenant);
    this.Controls.Add((Control) this.Label5);
    this.Controls.Add((Control) this.txtAzureSecret);
    this.Controls.Add((Control) this.txtAzureTenant);
    this.Controls.Add((Control) this.txtExchangeServerDomain);
    this.Controls.Add((Control) this.btnCancel);
    this.Controls.Add((Control) this.lblAzureClient);
    this.Controls.Add((Control) this.btnSave);
    this.Controls.Add((Control) this.Label4);
    this.Controls.Add((Control) this.txtAzureClient);
    this.Controls.Add((Control) this.Label3);
    this.Controls.Add((Control) this.txtMailPassword);
    this.Controls.Add((Control) this.txtMailUserName);
    this.Controls.Add((Control) this.txtMailServerAddress);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.txtEmail);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.PictureBox1);
    this.Font = new Font("Tahoma", 8.25f);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
    this.Name = nameof (frmEmailInfo);
    this.Text = "Email Information";
    ((ISupportInitialize) this.PictureBox1).EndInit();
    ((ISupportInitialize) this.txtEmail).EndInit();
    ((ISupportInitialize) this.txtMailServerAddress).EndInit();
    ((ISupportInitialize) this.txtMailUserName).EndInit();
    ((ISupportInitialize) this.txtMailPassword).EndInit();
    ((ISupportInitialize) this.err).EndInit();
    ((ISupportInitialize) this.btnSave).EndInit();
    ((ISupportInitialize) this.btnCancel).EndInit();
    ((ISupportInitialize) this.txtExchangeServerDomain).EndInit();
    ((ISupportInitialize) this.checkUseOWS).EndInit();
    ((ISupportInitialize) this.txtAzureClient).EndInit();
    ((ISupportInitialize) this.txtAzureTenant).EndInit();
    ((ISupportInitialize) this.txtAzureSecret).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  public frmEmailInfo()
  {
    this.Load += new EventHandler(this.frmEmailInfo_Load);
    this.KeyDown += new KeyEventHandler(this.frmEmailInfo_KeyDown);
    this.KeyUp += new KeyEventHandler(this.frmEmailInfo_KeyUp);
    this._userGuid = Guid.Empty;
    this._userID = -1;
    this._ctrlPressed = false;
    this.InitializeComponent();
    try
    {
      foreach (Control control in this.Controls)
      {
        control.KeyDown += new KeyEventHandler(this.frmEmailInfo_KeyDown);
        control.KeyUp += new KeyEventHandler(this.frmEmailInfo_KeyUp);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  public frmEmailInfo(Guid userGuid)
    : this()
  {
    this._userGuid = userGuid;
    ((ControlBase) this.btnCancel).Appearance.Image = (object) ImageCache.Instance.Undo;
    ((ControlBase) this.btnSave).Appearance.Image = (object) ImageCache.Instance.Save;
  }

  public frmEmailInfo(int userID)
    : this()
  {
    this._userID = userID;
    ((ControlBase) this.btnCancel).Appearance.Image = (object) ImageCache.Instance.Undo;
    ((ControlBase) this.btnSave).Appearance.Image = (object) ImageCache.Instance.Save;
  }

  private void frmEmailInfo_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    this._usersTable = DefaultDatabase.ExecuteDataTable("dbo.spEmail_GetUser", new object[4]
    {
      (object) "@userGuid",
      (object) this._userGuid,
      (object) "@userID",
      (object) this._userID
    });
    if (this._usersTable.Rows.Count == 0 && this._userGuid.Equals(Guid.Empty) && SystemSettings.KeyExists("UserEmail.UseSystemEmail") && SystemSettings.GetBoolSetting("UserEmail.UseSystemEmail"))
    {
      string stringSetting = SystemSettings.KeyExists("UserEmail.SystemConfiguration") ? SystemSettings.GetStringSetting("UserEmail.SystemConfiguration") : (string) null;
      if (!string.IsNullOrEmpty(stringSetting))
      {
        using (StringReader input = new StringReader(new Encryption().DecryptTripleDes(stringSetting)))
        {
          using (XmlReader reader = XmlReader.Create((TextReader) input))
          {
            int num = (int) this._usersTable.ReadXml(reader);
          }
        }
      }
      else
      {
        DataRow row = this._usersTable.NewRow();
        row["UserGUID"] = (object) this._userGuid;
        row["UserID"] = (object) 0;
        row["DisplayName"] = (object) "System Email";
        this._usersTable.Rows.Add(row);
      }
    }
    DataRow row1 = this._usersTable.AsEnumerable().FirstOrDefault<DataRow>() ?? this._usersTable.NewRow();
    if (!string.IsNullOrEmpty(row1.Field<string>("MailPassword")))
      ((TextEditorControlBase) this.txtMailPassword).Text = new Encryption().DecryptTripleDes(row1.Field<string>("MailPassword"));
    ((TextEditorControlBase) this.txtEmail).Text = row1.Field<string>("EmailAddress");
    ((TextEditorControlBase) this.txtMailServerAddress).Text = row1.Field<string>("MailServerAddress");
    ((TextEditorControlBase) this.txtMailUserName).Text = row1.Field<string>("MailUserName");
    ((TextEditorControlBase) this.txtExchangeServerDomain).Text = row1.Field<string>("ExchangeServerDomain");
    ((UltraToggleEditorBase) this.checkUseOWS).Checked = row1.Field<bool?>("UseOutlookWebServices").GetValueOrDefault();
    ((TextEditorControlBase) this.txtAzureClient).Text = row1.Field<string>("AzureClientID");
    ((TextEditorControlBase) this.txtAzureTenant).Text = row1.Field<string>("AzureTenantID");
    if (CurrentUser.UsingModernAuthentication || !string.IsNullOrEmpty(CurrentUser.Instance.AzureClient) || !string.IsNullOrEmpty(CurrentUser.Instance.AzureTenant))
    {
      this.HookupAzureTextbox((Control) this.txtAzureClient, (Control) this.lblAzureClient, CurrentUser.Instance.AzureClient);
      this.HookupAzureTextbox((Control) this.txtAzureTenant, (Control) this.lblAzureTenant, CurrentUser.Instance.AzureTenant);
    }
    ((Control) this.txtAzureSecret).Visible = DockingManager.Security.AssertPermission(frmEmailInfo.SecurityAzureSecretGuid, 15);
    if (((Control) this.txtAzureSecret).Visible)
    {
      this.lblAzureSecret.Visible = true;
      string str = row1.Field<string>("AzureSecret");
      if (string.IsNullOrEmpty(str))
        return;
      ((Control) this.txtAzureSecret).Tag = (object) str;
      ((TextEditorControlBase) this.txtAzureSecret).Text = "******";
      ((Control) this.txtAzureSecret).KeyDown += new KeyEventHandler(this.txtAzureSecret_KeyDown);
    }
    else
      this.Height -= ((Control) this.txtAzureSecret).Height;
  }

  private void HookupAzureTextbox(Control txtBox, Control label, string value)
  {
    txtBox.Tag = (object) value;
    label.Tag = (object) txtBox;
    label.Cursor = Cursors.Hand;
    label.MouseClick += new MouseEventHandler(this.Azure_CopyGraphValues);
  }

  private bool ValidateForm()
  {
    bool flag = true;
    this.err.SetError((Control) this.txtEmail, string.Empty);
    this.err.SetError((Control) this.txtMailServerAddress, string.Empty);
    this.err.SetError((Control) this.txtMailPassword, string.Empty);
    this.err.SetError((Control) this.txtMailUserName, string.Empty);
    if (string.IsNullOrWhiteSpace(((TextEditorControlBase) this.txtEmail).Text))
    {
      this.err.SetError((Control) this.txtEmail, "Please enter an email address.");
      flag = false;
    }
    if (string.IsNullOrWhiteSpace(((TextEditorControlBase) this.txtMailServerAddress).Text) && string.IsNullOrEmpty(((TextEditorControlBase) this.txtAzureTenant).Text) && string.IsNullOrEmpty(((TextEditorControlBase) this.txtAzureClient).Text))
    {
      this.err.SetError((Control) this.txtMailServerAddress, "Please enter a Server Name.");
      flag = false;
    }
    if (!string.IsNullOrWhiteSpace(((TextEditorControlBase) this.txtExchangeServerDomain).Text))
    {
      if (string.IsNullOrWhiteSpace(((TextEditorControlBase) this.txtMailPassword).Text))
      {
        this.err.SetError((Control) this.txtMailPassword, "Please enter a valid password.");
        flag = false;
      }
      if (string.IsNullOrWhiteSpace(((TextEditorControlBase) this.txtMailUserName).Text))
      {
        this.err.SetError((Control) this.txtMailUserName, "Please enter a UserName.");
        flag = false;
      }
    }
    return flag;
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
    Dictionary<string, DbParameter> dictionary = DefaultDatabase.DiscoverParameters("dbo.spEmail_UpdateUser");
    DbParameter dbParameter = dictionary["@mailPassword"];
    Encryption encryption = new Encryption();
    string str = (string) null;
    if (!string.IsNullOrWhiteSpace(((TextEditorControlBase) this.txtMailPassword).Text))
    {
      str = encryption.EncryptTripleDes(((TextEditorControlBase) this.txtMailPassword).Text);
      if (str != null && str.Length > dbParameter.Size)
      {
        int num = (int) MessageBox.Show($"Encrypted password length is larger than the allowed length of {dbParameter.Size} characters and will not be saved", "Error - Invalid Password Length");
        return;
      }
    }
    if (this._userGuid.Equals(Guid.Empty) && this._usersTable.Rows.Count > 0)
    {
      DataRow row = this._usersTable.Rows[0];
      row["EmailAddress"] = (object) ((TextEditorControlBase) this.txtEmail).Text.Trim();
      row["MailServerAddress"] = (object) ((TextEditorControlBase) this.txtMailServerAddress).Text.Trim();
      row["ExchangeServerDomain"] = (object) ((TextEditorControlBase) this.txtExchangeServerDomain).Text.Trim();
      row["MailUserName"] = (object) ((TextEditorControlBase) this.txtMailUserName).Text.Trim();
      row["MailPassword"] = (object) str;
      row["UseOutlookWebServices"] = (object) ((UltraToggleEditorBase) this.checkUseOWS).Checked;
      row["AzureTenantID"] = (object) ((TextEditorControlBase) this.txtAzureTenant).Text.Trim();
      row["AzureClientID"] = (object) ((TextEditorControlBase) this.txtAzureClient).Text.Trim();
      row["AzureSecret"] = RuntimeHelpers.GetObjectValue(((Control) this.txtAzureSecret).Tag ?? (object) ((TextEditorControlBase) this.txtAzureSecret).Text.Trim());
      StringBuilder sb = new StringBuilder();
      using (StringWriter output = new StringWriter(sb))
      {
        using (XmlWriter writer = XmlWriter.Create((TextWriter) output))
          this._usersTable.WriteXml(writer);
      }
      SystemSettings.SetStringSetting("UserEmail.SystemConfiguration", encryption.EncryptTripleDes(sb.ToString()));
    }
    else
    {
      dictionary["@userGuid"].Value = (object) this._userGuid;
      dictionary["@emailAddress"].Value = (object) ((TextEditorControlBase) this.txtEmail).Text.Trim();
      dictionary["@mailServer"].Value = (object) ((TextEditorControlBase) this.txtMailServerAddress).Text.Trim();
      dictionary["@exchangeDomain"].Value = (object) ((TextEditorControlBase) this.txtExchangeServerDomain).Text.Trim();
      dictionary["@mailUserName"].Value = (object) ((TextEditorControlBase) this.txtMailUserName).Text.Trim();
      dictionary["@mailPassword"].Value = (object) str;
      dictionary["@useOWS"].Value = (object) ((UltraToggleEditorBase) this.checkUseOWS).Checked;
      if (dictionary.ContainsKey("@clientID"))
        dictionary["@clientID"].Value = (object) ((TextEditorControlBase) this.txtAzureClient).Text.Trim();
      if (dictionary.ContainsKey("@tenantID"))
        dictionary["@tenantID"].Value = (object) ((TextEditorControlBase) this.txtAzureTenant).Text.Trim();
      if (dictionary.ContainsKey("@secretKey") && ((Control) this.txtAzureSecret).Visible && !string.IsNullOrEmpty(((TextEditorControlBase) this.txtAzureSecret).Text) && ((Control) this.txtAzureSecret).Tag == null)
        dictionary["@secretKey"].Value = (object) encryption.EncryptTripleDes(((TextEditorControlBase) this.txtAzureSecret).Text.Trim());
      DefaultDatabase.ExecuteNonQuery(CommandType.StoredProcedure, "dbo.spEmail_UpdateUser", (CommandArgumentType) 2, new object[1]
      {
        (object) dictionary
      });
    }
    this.Close();
  }

  private void btnCancel_Click(object sender, EventArgs e) => this.Close();

  private void linkTestEmail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    try
    {
      if (this.ValidateForm())
      {
        Encryption encryption = new Encryption();
        string text1 = ((TextEditorControlBase) this.txtMailServerAddress).Text;
        string text2 = ((TextEditorControlBase) this.txtMailUserName).Text;
        string emailPassword = encryption.EncryptTripleDes(((TextEditorControlBase) this.txtMailPassword).Text);
        string text3 = ((TextEditorControlBase) this.txtEmail).Text;
        string text4 = ((TextEditorControlBase) this.txtExchangeServerDomain).Text;
        int num1 = ((UltraToggleEditorBase) this.checkUseOWS).Checked ? 1 : 0;
        string text5 = ((TextEditorControlBase) this.txtAzureTenant).Text;
        string text6 = ((TextEditorControlBase) this.txtAzureClient).Text;
        if (!(((Control) this.txtAzureSecret).Tag is string azureSecret))
          azureSecret = ((TextEditorControlBase) this.txtAzureSecret).Text;
        UserEmail userEmail = new UserEmail(text1, text2, emailPassword, text3, text4, num1 != 0, text5, text6, azureSecret);
        string str = (string) null;
        if (this._ctrlPressed)
        {
          str = Interaction.InputBox("Please enter an email address to send to...", "Send Test To", ((TextEditorControlBase) this.txtEmail).Text);
          MailAddress mailAddress = new MailAddress(str);
          if (string.IsNullOrWhiteSpace(str) || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(mailAddress.Address, str, false) != 0)
            str = ((TextEditorControlBase) this.txtEmail).Text;
        }
        Settings.SuppressDialogs = true;
        int num2 = userEmail.SendMail(userEmail.Address, str, "Test Email", "This is a test email from the IMS.") ? 1 : 0;
        Settings.SuppressDialogs = false;
        if (num2 != 0)
        {
          int num3 = (int) MessageBox.Show("A test email has been sent.", "Test Email Sent", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        else
        {
          int num4 = (int) MessageBox.Show("The test email failed. Please check settings and try again.", "Email Failed", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
      }
      else
      {
        int num = (int) MessageBox.Show("A test email could not be sent because required fields were ommitted.", "Email Failed", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      Exception exception = ex;
      int num = (int) MessageBox.Show($"The test email failed: {exception.Message}{(exception.InnerException != null ? (object) $"{Environment.NewLine}Inner Exception: {exception.InnerException.Message}" : (object) string.Empty)}", "Email Failed", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      ProjectData.ClearProjectError();
    }
  }

  private void frmEmailInfo_KeyDown(object sender, KeyEventArgs e) => this._ctrlPressed = e.Control;

  private void frmEmailInfo_KeyUp(object sender, KeyEventArgs e) => this._ctrlPressed = false;

  private void txtAzureSecret_KeyDown(object sender, KeyEventArgs e)
  {
    if (!((TextEditorControlBase) this.txtAzureSecret).Text.Equals("******"))
      return;
    ((Control) this.txtAzureSecret).Tag = (object) null;
    ((TextEditorControlBase) this.txtAzureSecret).Text = ((TextEditorControlBase) this.txtAzureSecret).Text.Replace("*", "");
    this.txtAzureSecret.PasswordChar = char.MinValue;
    ((Control) this.txtAzureSecret).KeyDown -= new KeyEventHandler(this.txtAzureSecret_KeyDown);
  }

  private void Azure_CopyGraphValues(object sender, MouseEventArgs e)
  {
    Control control = sender as Control;
    if (control.Tag == null || !(control.Tag is Control tag))
      return;
    tag.Text = tag.Tag as string;
  }
}
