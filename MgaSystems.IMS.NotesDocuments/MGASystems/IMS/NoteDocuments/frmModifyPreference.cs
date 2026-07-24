// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.NoteDocuments.frmModifyPreference
// Assembly: MgaSystems.IMS.NotesDocuments, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 3F898CF7-066D-4B05-A9F1-D37DBC4FAA16
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.NotesDocuments.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.NoteDocuments;

[SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly")]
public class frmModifyPreference : Form
{
  private IContainer components;
  private MGATextBox txtValue;
  private Label lblPrefname;
  private PictureBox PictureBox1;
  private string _originalValue;
  private string _prefType;
  private string _prefName;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private virtual MGAButton btnOK
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
  private virtual MGAButton btnCancel { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    ResourceManager resourceManager = new ResourceManager(typeof (frmModifyPreference));
    this.btnOK = new MGAButton();
    this.btnCancel = new MGAButton();
    this.txtValue = new MGATextBox();
    this.lblPrefname = new Label();
    this.PictureBox1 = new PictureBox();
    ((ISupportInitialize) this.btnOK).BeginInit();
    ((ISupportInitialize) this.btnCancel).BeginInit();
    ((ISupportInitialize) this.txtValue).BeginInit();
    this.SuspendLayout();
    appearance1.BackColor = Color.FromArgb(248, 248, 248);
    appearance1.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance1.BackGradientStyle = (GradientStyle) 2;
    appearance1.BorderColor = Color.DarkGray;
    ((ControlBase) this.btnOK).Appearance = (AppearanceBase) appearance1;
    ((Control) this.btnOK).Location = new Point(128 /*0x80*/, 80 /*0x50*/);
    ((Control) this.btnOK).Name = "btnOK";
    ((Control) this.btnOK).Size = new Size(72, 24);
    ((Control) this.btnOK).TabIndex = 1;
    ((ControlBase) this.btnOK).Text = "OK";
    appearance2.BackColor = Color.FromArgb(248, 248, 248);
    appearance2.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance2.BackGradientStyle = (GradientStyle) 2;
    appearance2.BorderColor = Color.DarkGray;
    ((ControlBase) this.btnCancel).Appearance = (AppearanceBase) appearance2;
    ((UltraButtonBase) this.btnCancel).DialogResult = DialogResult.Cancel;
    ((Control) this.btnCancel).Location = new Point(208 /*0xD0*/, 80 /*0x50*/);
    ((Control) this.btnCancel).Name = "btnCancel";
    ((Control) this.btnCancel).Size = new Size(72, 24);
    ((Control) this.btnCancel).TabIndex = 2;
    ((ControlBase) this.btnCancel).Text = "Cancel";
    appearance3.BorderColor = Color.Gray;
    ((TextEditorControlBase) this.txtValue).Appearance = (AppearanceBase) appearance3;
    ((Control) this.txtValue).Location = new Point(56, 48 /*0x30*/);
    ((Control) this.txtValue).Name = "txtValue";
    ((Control) this.txtValue).Size = new Size(224 /*0xE0*/, 20);
    ((Control) this.txtValue).TabIndex = 0;
    this.lblPrefname.AutoSize = true;
    this.lblPrefname.Location = new Point(56, 24);
    this.lblPrefname.Name = "lblPrefname";
    this.lblPrefname.Size = new Size(37, 17);
    this.lblPrefname.TabIndex = 3;
    this.lblPrefname.Text = "Label1";
    this.PictureBox1.Image = (Image) resourceManager.GetObject("PictureBox1.Image");
    this.PictureBox1.Location = new Point(16 /*0x10*/, 16 /*0x10*/);
    this.PictureBox1.Name = "PictureBox1";
    this.PictureBox1.Size = new Size(32 /*0x20*/, 32 /*0x20*/);
    this.PictureBox1.TabIndex = 4;
    this.PictureBox1.TabStop = false;
    this.AcceptButton = (IButtonControl) this.btnOK;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.WhiteSmoke;
    this.CancelButton = (IButtonControl) this.btnCancel;
    this.ClientSize = new Size(296, 126);
    this.Controls.Add((Control) this.PictureBox1);
    this.Controls.Add((Control) this.lblPrefname);
    this.Controls.Add((Control) this.txtValue);
    this.Controls.Add((Control) this.btnCancel);
    this.Controls.Add((Control) this.btnOK);
    this.Font = new Font("Tahoma", 8.25f);
    this.FormBorderStyle = FormBorderStyle.FixedSingle;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmModifyPreference);
    this.StartPosition = FormStartPosition.CenterParent;
    this.Text = nameof (frmModifyPreference);
    ((ISupportInitialize) this.btnOK).EndInit();
    ((ISupportInitialize) this.btnCancel).EndInit();
    ((ISupportInitialize) this.txtValue).EndInit();
    this.ResumeLayout(false);
  }

  public frmModifyPreference(string prefName, string prefType, string value)
  {
    this.Load += new EventHandler(this.frmModifyPreference_Load);
    this.InitializeComponent();
    this._originalValue = value;
    this._prefType = prefType;
    this._prefName = prefName;
  }

  private void frmModifyPreference_Load(object sender, EventArgs e)
  {
    ((TextEditorControlBase) this.txtValue).Text = this._originalValue;
    this.Text = $"Enter {this._prefType} value".Replace("System.", "");
    this.lblPrefname.Text = this._prefName;
    ((TextEditorControlBase) this.txtValue).Text = this._originalValue;
  }

  public bool IsModified
  {
    get
    {
      return Operators.CompareString(this._originalValue, ((TextEditorControlBase) this.txtValue).Text, false) != 0;
    }
  }

  public string NewValue => ((TextEditorControlBase) this.txtValue).Text;

  private void btnOK_Click(object sender, EventArgs e)
  {
    if (this.IsModified)
      this.DialogResult = DialogResult.OK;
    else
      this.DialogResult = DialogResult.Cancel;
  }
}
