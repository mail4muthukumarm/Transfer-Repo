// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Forms.frmUpdateCDKey
// Assembly: MgaSystems.IMS.Forms, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FB3F392E-40B6-486F-8F0B-A4A494A546D4
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Forms.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using MGASystems.Common;
using MGASystems.IMS.Security;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Forms;

[SecureResource("{1BEAB417-AD16-41c0-984F-0A6660131697}", "Update CD Key", "Controls the ability for users to update CD Key.", "Users")]
public sealed class frmUpdateCDKey : Form
{
  private IContainer components;
  private MGATextBox txtCDKey;
  public const string CanUpdateCDKey = "{1BEAB417-AD16-41c0-984F-0A6660131697}";

  public frmUpdateCDKey()
  {
    this.Load += new EventHandler(this.frmUpdateCDKey_Load);
    this.InitializeComponent();
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private virtual MGAButton btnSave
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

  private virtual MGAButton btnCancel
  {
    get => this._btnCancel;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.Button2_Click);
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

  [field: AccessedThroughProperty("PictureBox1")]
  internal virtual PictureBox PictureBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label2")]
  internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    ResourceManager resourceManager = new ResourceManager(typeof (frmUpdateCDKey));
    this.txtCDKey = new MGATextBox();
    this.btnSave = new MGAButton();
    this.btnCancel = new MGAButton();
    this.PictureBox1 = new PictureBox();
    this.Label2 = new Label();
    ((ISupportInitialize) this.txtCDKey).BeginInit();
    ((ISupportInitialize) this.btnSave).BeginInit();
    ((ISupportInitialize) this.btnCancel).BeginInit();
    this.SuspendLayout();
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.Gray;
    appearance1.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtCDKey).Appearance = (AppearanceBase) appearance1;
    ((Control) this.txtCDKey).Location = new Point(72, 40);
    ((TextEditorControlBase) this.txtCDKey).MaxLength = 38;
    ((Control) this.txtCDKey).Name = "txtCDKey";
    ((Control) this.txtCDKey).Size = new Size(272, 20);
    ((Control) this.txtCDKey).TabIndex = 0;
    appearance2.BackColor = Color.FromArgb(248, 248, 248);
    appearance2.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance2.BackGradientStyle = (GradientStyle) 2;
    appearance2.BorderColor = Color.DarkGray;
    appearance2.ImageHAlign = (HAlign) 2;
    appearance2.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnSave).Appearance = (AppearanceBase) appearance2;
    ((ControlBase) this.btnSave).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnSave).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnSave).Location = new Point(360, 20);
    ((Control) this.btnSave).Name = "btnSave";
    ((Control) this.btnSave).TabIndex = 1;
    appearance3.BackColor = Color.FromArgb(248, 248, 248);
    appearance3.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance3.BackGradientStyle = (GradientStyle) 2;
    appearance3.BorderColor = Color.DarkGray;
    appearance3.ImageHAlign = (HAlign) 2;
    appearance3.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnCancel).Appearance = (AppearanceBase) appearance3;
    ((UltraButtonBase) this.btnCancel).DialogResult = DialogResult.Cancel;
    ((ControlBase) this.btnCancel).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnCancel).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnCancel).Location = new Point(408, 20);
    ((Control) this.btnCancel).Name = "btnCancel";
    ((Control) this.btnCancel).TabIndex = 2;
    this.PictureBox1.Image = (Image) resourceManager.GetObject("PictureBox1.Image");
    this.PictureBox1.Location = new Point(8, 16 /*0x10*/);
    this.PictureBox1.Name = "PictureBox1";
    this.PictureBox1.Size = new Size(56, 48 /*0x30*/);
    this.PictureBox1.TabIndex = 4;
    this.PictureBox1.TabStop = false;
    this.Label2.AutoSize = true;
    this.Label2.Location = new Point(72, 16 /*0x10*/);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(265, 16 /*0x10*/);
    this.Label2.TabIndex = 5;
    this.Label2.Text = "Please enter the IMS CD-Key you were provided with:";
    this.AcceptButton = (IButtonControl) this.btnSave;
    this.AutoScaleBaseSize = new Size(5, 13);
    this.BackColor = Color.White;
    this.CancelButton = (IButtonControl) this.btnCancel;
    this.ClientSize = new Size(458, 80 /*0x50*/);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.PictureBox1);
    this.Controls.Add((Control) this.txtCDKey);
    this.Controls.Add((Control) this.btnCancel);
    this.Controls.Add((Control) this.btnSave);
    this.Font = new Font("Tahoma", 8f);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmUpdateCDKey);
    this.ShowInTaskbar = false;
    this.Text = "CD Key Information";
    ((ISupportInitialize) this.txtCDKey).EndInit();
    ((ISupportInitialize) this.btnSave).EndInit();
    ((ISupportInitialize) this.btnCancel).EndInit();
    this.ResumeLayout(false);
  }

  private void frmUpdateCDKey_Load(object sender, EventArgs e)
  {
    ((ControlBase) this.btnSave).Appearance.Image = (object) ImageCache.Instance.Save;
    ((ControlBase) this.btnCancel).Appearance.Image = (object) ImageCache.Instance.Undo;
    string path = $"{Application.StartupPath}\\IMS_Update.exe.config";
    if (!File.Exists(path))
      return;
    StreamReader streamReader = File.OpenText(path);
    for (string str = streamReader.ReadLine(); str != null; str = streamReader.ReadLine())
    {
      if (str.IndexOf("UpdatePackageKey") != -1)
        ((TextEditorControlBase) this.txtCDKey).Text = str.Substring(str.LastIndexOf("value") + 7, 36).Replace("-", "");
    }
    streamReader.Close();
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
    if (!SecurityManager.Instance.AssertPermission("{1BEAB417-AD16-41c0-984F-0A6660131697}"))
    {
      int num1 = (int) MessageBox.Show("You do not have the required security to update the CD Key.", "Insufficient Security", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else
    {
      string path = $"{Application.StartupPath}\\IMS_Update.exe.config";
      ArrayList arrayList = new ArrayList();
      try
      {
        Guid guid = new Guid(((TextEditorControlBase) this.txtCDKey).Text.Replace("-", string.Empty));
        if (!File.Exists(path))
          return;
        StreamReader streamReader = File.OpenText(path);
        for (string str = streamReader.ReadLine(); str != null; str = streamReader.ReadLine())
        {
          if (str.IndexOf("UpdatePackageKey") != -1)
            arrayList.Add((object) $"<add key=\"UpdatePackageKey\" value=\"{guid.ToString()}\" />");
          else
            arrayList.Add((object) str);
        }
        streamReader.Close();
        File.Delete(path);
        StreamWriter text = File.CreateText(path);
        try
        {
          foreach (object obj in arrayList)
          {
            string str = Conversions.ToString(obj);
            text.WriteLine(str);
          }
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
        text.Close();
        this.DialogResult = DialogResult.OK;
        this.Close();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num2 = (int) MessageBox.Show($"{((TextEditorControlBase) this.txtCDKey).Text} is not a valid CD-key.", "Invalid CD Key", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        this.DialogResult = DialogResult.Cancel;
        ProjectData.ClearProjectError();
      }
    }
  }

  private void Button2_Click(object sender, EventArgs e)
  {
    this.DialogResult = DialogResult.Cancel;
    this.Close();
  }
}
