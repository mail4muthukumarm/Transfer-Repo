// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Forms.frmSafeFileAccessGetLoginInfo
// Assembly: MgaSystems.IMS.Forms, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FB3F392E-40B6-486F-8F0B-A4A494A546D4
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Forms.dll

using Infragistics.Win.Misc;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Security.Principal;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Forms;

public sealed class frmSafeFileAccessGetLoginInfo : Form
{
  private IContainer components;
  private Label Label3;
  private Label Label1;
  private Label lblText;
  private Label label33;
  private TextBox txtPassword;
  private TextBox txtLogOnMachine;
  private TextBox txtUsername;
  private string _logonMachine;
  private string _userName;
  private string _passWord;

  public frmSafeFileAccessGetLoginInfo(string resourceName)
  {
    this.Load += new EventHandler(this.frmSafeFileAccessGetLoginInfo_Load);
    this.Closing += new CancelEventHandler(this.frmSafeFileAccessGetLoginInfo_Closing);
    this.InitializeComponent();
    this.lblText.Text = $"The IMS requires access to the resource {resourceName}. The current account does not have privelage to access this resource. Please enter a username/password that has access to this resource.";
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private virtual MGAButton btnCancel
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

  private virtual MGAButton btnOk
  {
    get => this._btnOk;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnOk_Click);
      MGAButton btnOk1 = this._btnOk;
      if (btnOk1 != null)
        ((Control) btnOk1).Click -= eventHandler;
      this._btnOk = value;
      MGAButton btnOk2 = this._btnOk;
      if (btnOk2 == null)
        return;
      ((Control) btnOk2).Click += eventHandler;
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.btnCancel = new MGAButton();
    this.btnOk = new MGAButton();
    this.txtLogOnMachine = new TextBox();
    this.Label3 = new Label();
    this.Label1 = new Label();
    this.txtUsername = new TextBox();
    this.label33 = new Label();
    this.txtPassword = new TextBox();
    this.lblText = new Label();
    this.SuspendLayout();
    ((UltraButtonBase) this.btnCancel).DialogResult = DialogResult.Cancel;
    ((Control) this.btnCancel).Location = new Point(392, 152);
    ((Control) this.btnCancel).Name = "btnCancel";
    ((Control) this.btnCancel).Size = new Size(88, 24);
    ((Control) this.btnCancel).TabIndex = 5;
    ((ControlBase) this.btnCancel).Text = "Cancel";
    ((Control) this.btnOk).Location = new Point(296, 152);
    ((Control) this.btnOk).Name = "btnOk";
    ((Control) this.btnOk).Size = new Size(88, 24);
    ((Control) this.btnOk).TabIndex = 4;
    ((ControlBase) this.btnOk).Text = "OK";
    this.txtLogOnMachine.Location = new Point(128 /*0x80*/, 120);
    this.txtLogOnMachine.Name = "txtLogOnMachine";
    this.txtLogOnMachine.Size = new Size(352, 21);
    this.txtLogOnMachine.TabIndex = 2;
    this.txtLogOnMachine.Text = "";
    this.Label3.Location = new Point(40, 120);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(88, 16 /*0x10*/);
    this.Label3.TabIndex = 7;
    this.Label3.Text = "Log On To:";
    this.Label1.Location = new Point(40, 56);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(88, 16 /*0x10*/);
    this.Label1.TabIndex = 9;
    this.Label1.Text = "User Name:";
    this.txtUsername.Location = new Point(128 /*0x80*/, 56);
    this.txtUsername.Name = "txtUsername";
    this.txtUsername.Size = new Size(352, 21);
    this.txtUsername.TabIndex = 0;
    this.txtUsername.Text = "";
    this.label33.Location = new Point(40, 88);
    this.label33.Name = "label33";
    this.label33.Size = new Size(88, 16 /*0x10*/);
    this.label33.TabIndex = 11;
    this.label33.Text = "Password:";
    this.txtPassword.Location = new Point(128 /*0x80*/, 88);
    this.txtPassword.Name = "txtPassword";
    this.txtPassword.PasswordChar = '*';
    this.txtPassword.Size = new Size(352, 21);
    this.txtPassword.TabIndex = 1;
    this.txtPassword.Text = "";
    this.lblText.Location = new Point(40, 8);
    this.lblText.Name = "lblText";
    this.lblText.Size = new Size(440, 40);
    this.lblText.TabIndex = 12;
    this.lblText.Text = "Label4";
    this.AcceptButton = (IButtonControl) this.btnOk;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.CancelButton = (IButtonControl) this.btnCancel;
    this.ClientSize = new Size(488, 182);
    this.Controls.Add((Control) this.lblText);
    this.Controls.Add((Control) this.label33);
    this.Controls.Add((Control) this.txtPassword);
    this.Controls.Add((Control) this.txtUsername);
    this.Controls.Add((Control) this.txtLogOnMachine);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.Label3);
    this.Controls.Add((Control) this.btnOk);
    this.Controls.Add((Control) this.btnCancel);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Name = nameof (frmSafeFileAccessGetLoginInfo);
    this.Text = "Access Resource As...";
    this.ResumeLayout(false);
  }

  public string UserName => this._userName;

  public string PassWord => this._passWord;

  public string LogonMachine => this._logonMachine;

  private void frmSafeFileAccessGetLoginInfo_Load(object sender, EventArgs e)
  {
    this.CancelButton = (IButtonControl) this.btnCancel;
    this.AcceptButton = (IButtonControl) this.btnOk;
    try
    {
      string name = WindowsIdentity.GetCurrent().Name;
      this.txtLogOnMachine.Text = name.Substring(0, name.IndexOf("\\"));
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ProjectData.ClearProjectError();
    }
  }

  private void btnOk_Click(object sender, EventArgs e)
  {
    this._passWord = this.txtPassword.Text;
    this._logonMachine = this.txtLogOnMachine.Text;
    this._userName = this.txtUsername.Text;
    this.DialogResult = DialogResult.OK;
    this.Close();
  }

  private void btnCancel_Click(object sender, EventArgs e)
  {
    this.DialogResult = DialogResult.Cancel;
    this.Close();
  }

  private void frmSafeFileAccessGetLoginInfo_Closing(object sender, CancelEventArgs e)
  {
    if (this.DialogResult != DialogResult.Cancel || MessageBox.Show("The IMS must be able to perform this file access, inability to do so will require the IMS to shut down to prevent any errors.\r\nAre you sure you want to shut down?", "IMS Shutdown required", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
      return;
    e.Cancel = true;
  }
}
