// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Security.FormSecurityPrompt
// Assembly: MgaSystems.IMS.Security, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: A5FACEA8-628E-4FEB-97EB-CBBA0F666906
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Security.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Security;

public class FormSecurityPrompt : Form
{
  private IContainer components;

  public FormSecurityPrompt() => this.InitializeComponent();

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  internal virtual MGAButton btnOK
  {
    get => this._btnOK;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnOK_Click);
      MGAButton btnOk1 = this._btnOK;
      if (btnOk1 != null)
        ((Control) btnOk1).Click -= eventHandler;
      this._btnOK = value;
      MGAButton btnOk2 = this._btnOK;
      if (btnOk2 == null)
        return;
      ((Control) btnOk2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("btnCancel")]
  internal virtual MGAButton btnCancel { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtPassword")]
  internal virtual MGATextBox txtPassword { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtUserName")]
  internal virtual MGATextBox txtUserName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label2")]
  internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label3")]
  internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PictureBox1")]
  internal virtual PictureBox PictureBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    ResourceManager resourceManager = new ResourceManager(typeof (FormSecurityPrompt));
    this.btnOK = new MGAButton();
    this.btnCancel = new MGAButton();
    this.txtPassword = new MGATextBox();
    this.txtUserName = new MGATextBox();
    this.Label1 = new Label();
    this.Label2 = new Label();
    this.Label3 = new Label();
    this.PictureBox1 = new PictureBox();
    ((ISupportInitialize) this.btnOK).BeginInit();
    ((ISupportInitialize) this.btnCancel).BeginInit();
    ((ISupportInitialize) this.txtPassword).BeginInit();
    ((ISupportInitialize) this.txtUserName).BeginInit();
    this.SuspendLayout();
    appearance1.BackColor = Color.FromArgb(248, 248, 248);
    appearance1.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance1.BackGradientStyle = (GradientStyle) 2;
    appearance1.BorderColor = Color.DarkGray;
    ((ControlBase) this.btnOK).Appearance = (AppearanceBase) appearance1;
    ((Control) this.btnOK).Location = new Point(160 /*0xA0*/, 136);
    ((Control) this.btnOK).Name = "btnOK";
    ((Control) this.btnOK).Size = new Size(72, 24);
    ((Control) this.btnOK).TabIndex = 5;
    ((ControlBase) this.btnOK).Text = "OK";
    appearance2.BackColor = Color.FromArgb(248, 248, 248);
    appearance2.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance2.BackGradientStyle = (GradientStyle) 2;
    appearance2.BorderColor = Color.DarkGray;
    ((ControlBase) this.btnCancel).Appearance = (AppearanceBase) appearance2;
    ((UltraButtonBase) this.btnCancel).DialogResult = DialogResult.Cancel;
    ((Control) this.btnCancel).Location = new Point(240 /*0xF0*/, 136);
    ((Control) this.btnCancel).Name = "btnCancel";
    ((Control) this.btnCancel).Size = new Size(72, 24);
    ((Control) this.btnCancel).TabIndex = 6;
    ((ControlBase) this.btnCancel).Text = "Cancel";
    appearance3.BorderColor = Color.Gray;
    ((TextEditorControlBase) this.txtPassword).Appearance = (AppearanceBase) appearance3;
    ((Control) this.txtPassword).Location = new Point(80 /*0x50*/, 104);
    ((Control) this.txtPassword).Name = "txtPassword";
    this.txtPassword.PasswordChar = '*';
    ((Control) this.txtPassword).Size = new Size(232, 20);
    ((Control) this.txtPassword).TabIndex = 4;
    appearance4.BorderColor = Color.Gray;
    ((TextEditorControlBase) this.txtUserName).Appearance = (AppearanceBase) appearance4;
    ((Control) this.txtUserName).Location = new Point(80 /*0x50*/, 80 /*0x50*/);
    ((Control) this.txtUserName).Name = "txtUserName";
    ((Control) this.txtUserName).Size = new Size(232, 20);
    ((Control) this.txtUserName).TabIndex = 2;
    this.Label1.AutoSize = true;
    this.Label1.Location = new Point(8, 80 /*0x50*/);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(54, 17);
    this.Label1.TabIndex = 1;
    this.Label1.Text = "Username";
    this.Label2.AutoSize = true;
    this.Label2.Location = new Point(8, 104);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(51, 17);
    this.Label2.TabIndex = 3;
    this.Label2.Text = "Password";
    this.Label3.Location = new Point(104, 16 /*0x10*/);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(208 /*0xD0*/, 48 /*0x30*/);
    this.Label3.TabIndex = 0;
    this.Label3.Text = "To access this functionality, a user with administrative access must log in. ";
    this.PictureBox1.Image = (Image) resourceManager.GetObject("PictureBox1.Image");
    this.PictureBox1.Location = new Point(16 /*0x10*/, 8);
    this.PictureBox1.Name = "PictureBox1";
    this.PictureBox1.Size = new Size(64 /*0x40*/, 64 /*0x40*/);
    this.PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
    this.PictureBox1.TabIndex = 8;
    this.PictureBox1.TabStop = false;
    this.AcceptButton = (IButtonControl) this.btnOK;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.CancelButton = (IButtonControl) this.btnCancel;
    this.ClientSize = new Size(322, 168);
    this.ControlBox = false;
    this.Controls.Add((Control) this.PictureBox1);
    this.Controls.Add((Control) this.Label3);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.txtUserName);
    this.Controls.Add((Control) this.txtPassword);
    this.Controls.Add((Control) this.btnCancel);
    this.Controls.Add((Control) this.btnOK);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.Name = nameof (FormSecurityPrompt);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Administrative Login Required";
    ((ISupportInitialize) this.btnOK).EndInit();
    ((ISupportInitialize) this.btnCancel).EndInit();
    ((ISupportInitialize) this.txtPassword).EndInit();
    ((ISupportInitialize) this.txtUserName).EndInit();
    this.ResumeLayout(false);
  }

  public string Username => ((TextEditorControlBase) this.txtUserName).Text;

  public string Password => ((TextEditorControlBase) this.txtPassword).Text;

  private void btnOK_Click(object sender, EventArgs e)
  {
    this.DialogResult = DialogResult.OK;
    this.Close();
  }
}
