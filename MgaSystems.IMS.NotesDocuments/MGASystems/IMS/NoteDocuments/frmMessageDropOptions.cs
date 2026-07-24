// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.NoteDocuments.frmMessageDropOptions
// Assembly: MgaSystems.IMS.NotesDocuments, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 3F898CF7-066D-4B05-A9F1-D37DBC4FAA16
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.NotesDocuments.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using MGASystems.Common;
using MGASystems.IMS.NoteDocuments.Serialization;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.NoteDocuments;

[SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly")]
[Preference("Screens.OutlookMessageDropOptions.CheckedRadioButtonIndex", 0)]
public class frmMessageDropOptions : Form
{
  private IContainer components;
  private Label Label1;
  private PictureBox PictureBox1;
  private RadioButton rdoFullMessage;
  private RadioButton rdoMessageOnly;
  private RadioButton rdoAttachmentsOnly;
  internal const string PREFERENCEID_CHECKED_RADIO_INDEX = "Screens.OutlookMessageDropOptions.CheckedRadioButtonIndex";
  private frmMessageDropOptions.MessageImportOptions _importOptions;
  private bool _applyToAllItems;

  public frmMessageDropOptions()
    : this(false)
  {
  }

  public frmMessageDropOptions(bool displayDoThisForAllItemsCheckBox)
  {
    this.Load += new EventHandler(this.frmMessageDropOptions_Load);
    this.InitializeComponent();
    this.chkUseThisOptionForAllDocs.Visible = displayDoThisForAllItemsCheckBox;
  }

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

  [field: AccessedThroughProperty("chkUseThisOptionForAllDocs")]
  internal virtual CheckBox chkUseThisOptionForAllDocs { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("rdoFullMessageABO")]
  private virtual RadioButton rdoFullMessageABO { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmMessageDropOptions));
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    this.Label1 = new Label();
    this.PictureBox1 = new PictureBox();
    this.rdoFullMessage = new RadioButton();
    this.rdoMessageOnly = new RadioButton();
    this.rdoAttachmentsOnly = new RadioButton();
    this.btnOK = new MGAButton();
    this.btnCancel = new MGAButton();
    this.chkUseThisOptionForAllDocs = new CheckBox();
    this.rdoFullMessageABO = new RadioButton();
    ((ISupportInitialize) this.PictureBox1).BeginInit();
    ((ISupportInitialize) this.btnOK).BeginInit();
    ((ISupportInitialize) this.btnCancel).BeginInit();
    this.SuspendLayout();
    this.Label1.AutoSize = true;
    this.Label1.Font = new Font("Tahoma", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label1.Location = new Point(16 /*0x10*/, 16 /*0x10*/);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(202, 17);
    this.Label1.TabIndex = 1;
    this.Label1.Text = "What would you like to import?";
    this.PictureBox1.Image = (Image) componentResourceManager.GetObject("PictureBox1.Image");
    this.PictureBox1.Location = new Point(24, 56);
    this.PictureBox1.Name = "PictureBox1";
    this.PictureBox1.Size = new Size(48 /*0x30*/, 48 /*0x30*/);
    this.PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
    this.PictureBox1.TabIndex = 2;
    this.PictureBox1.TabStop = false;
    this.rdoFullMessage.Checked = true;
    this.rdoFullMessage.Location = new Point(96 /*0x60*/, 56);
    this.rdoFullMessage.Name = "rdoFullMessage";
    this.rdoFullMessage.Size = new Size(224 /*0xE0*/, 24);
    this.rdoFullMessage.TabIndex = 3;
    this.rdoFullMessage.TabStop = true;
    this.rdoFullMessage.Text = "Full Message (Including Attachments)";
    this.rdoMessageOnly.Location = new Point(96 /*0x60*/, 104);
    this.rdoMessageOnly.Name = "rdoMessageOnly";
    this.rdoMessageOnly.Size = new Size(104, 24);
    this.rdoMessageOnly.TabIndex = 4;
    this.rdoMessageOnly.Text = "Message Only";
    this.rdoAttachmentsOnly.Location = new Point(96 /*0x60*/, 128 /*0x80*/);
    this.rdoAttachmentsOnly.Name = "rdoAttachmentsOnly";
    this.rdoAttachmentsOnly.Size = new Size(152, 24);
    this.rdoAttachmentsOnly.TabIndex = 5;
    this.rdoAttachmentsOnly.Text = "Attachments Only";
    appearance1.BackColor = Color.FromArgb(248, 248, 248);
    appearance1.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance1.BackGradientStyle = (GradientStyle) 2;
    appearance1.BorderColor = Color.DarkGray;
    appearance1.ImageHAlign = (HAlign) 2;
    appearance1.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnOK).Appearance = (AppearanceBase) appearance1;
    ((Control) this.btnOK).Location = new Point(188, 185);
    ((Control) this.btnOK).Name = "btnOK";
    ((Control) this.btnOK).Size = new Size(72, 24);
    ((Control) this.btnOK).TabIndex = 6;
    ((ControlBase) this.btnOK).Text = "&OK";
    this.btnOK.UseOSThemes = (DefaultableBoolean) 2;
    appearance2.BackColor = Color.FromArgb(248, 248, 248);
    appearance2.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance2.BackGradientStyle = (GradientStyle) 2;
    appearance2.BorderColor = Color.DarkGray;
    appearance2.ImageHAlign = (HAlign) 2;
    appearance2.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnCancel).Appearance = (AppearanceBase) appearance2;
    ((UltraButtonBase) this.btnCancel).DialogResult = DialogResult.Cancel;
    ((Control) this.btnCancel).Location = new Point(268, 185);
    ((Control) this.btnCancel).Name = "btnCancel";
    ((Control) this.btnCancel).Size = new Size(72, 24);
    ((Control) this.btnCancel).TabIndex = 7;
    ((ControlBase) this.btnCancel).Text = "&Cancel";
    this.btnCancel.UseOSThemes = (DefaultableBoolean) 2;
    this.chkUseThisOptionForAllDocs.AutoSize = true;
    this.chkUseThisOptionForAllDocs.Location = new Point(96 /*0x60*/, 162);
    this.chkUseThisOptionForAllDocs.Name = "chkUseThisOptionForAllDocs";
    this.chkUseThisOptionForAllDocs.Size = new Size(177, 17);
    this.chkUseThisOptionForAllDocs.TabIndex = 8;
    this.chkUseThisOptionForAllDocs.Text = "Use this option for all messages";
    this.chkUseThisOptionForAllDocs.UseVisualStyleBackColor = true;
    this.rdoFullMessageABO.Location = new Point(96 /*0x60*/, 80 /*0x50*/);
    this.rdoFullMessageABO.Name = "rdoFullMessageABO";
    this.rdoFullMessageABO.Size = new Size(234, 24);
    this.rdoFullMessageABO.TabIndex = 9;
    this.rdoFullMessageABO.Text = "Full Message (Attachments Broken Out)";
    this.AcceptButton = (IButtonControl) this.btnOK;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.CancelButton = (IButtonControl) this.btnCancel;
    this.ClientSize = new Size(352, 228);
    this.ControlBox = false;
    this.Controls.Add((Control) this.rdoFullMessageABO);
    this.Controls.Add((Control) this.chkUseThisOptionForAllDocs);
    this.Controls.Add((Control) this.btnCancel);
    this.Controls.Add((Control) this.btnOK);
    this.Controls.Add((Control) this.rdoAttachmentsOnly);
    this.Controls.Add((Control) this.rdoMessageOnly);
    this.Controls.Add((Control) this.rdoFullMessage);
    this.Controls.Add((Control) this.PictureBox1);
    this.Controls.Add((Control) this.Label1);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmMessageDropOptions);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Message Drop Options";
    ((ISupportInitialize) this.PictureBox1).EndInit();
    ((ISupportInitialize) this.btnOK).EndInit();
    ((ISupportInitialize) this.btnCancel).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  private void btnCancel_Click(object sender, EventArgs e)
  {
    this.DialogResult = DialogResult.Cancel;
    this.Close();
  }

  private void btnOK_Click(object sender, EventArgs e)
  {
    if (this.rdoFullMessage.Checked)
    {
      this._importOptions = frmMessageDropOptions.MessageImportOptions.FullMessage;
      Preferences.SetPreference("Screens.OutlookMessageDropOptions.CheckedRadioButtonIndex", 0);
    }
    else if (this.rdoAttachmentsOnly.Checked)
    {
      this._importOptions = frmMessageDropOptions.MessageImportOptions.AttachmentOnly;
      Preferences.SetPreference("Screens.OutlookMessageDropOptions.CheckedRadioButtonIndex", 2);
    }
    else if (this.rdoMessageOnly.Checked)
    {
      this._importOptions = frmMessageDropOptions.MessageImportOptions.MessageOnly;
      Preferences.SetPreference("Screens.OutlookMessageDropOptions.CheckedRadioButtonIndex", 1);
    }
    else if (this.rdoFullMessageABO.Checked)
    {
      this._importOptions = frmMessageDropOptions.MessageImportOptions.FullMessageAttachmentsBrokenOut;
      Preferences.SetPreference("Screens.OutlookMessageDropOptions.CheckedRadioButtonIndex", 3);
    }
    else
      this._importOptions = frmMessageDropOptions.MessageImportOptions.None;
    this._applyToAllItems = this.chkUseThisOptionForAllDocs.Checked;
    this.DialogResult = DialogResult.OK;
    this.Close();
  }

  public frmMessageDropOptions.MessageImportOptions ImportOptions => this._importOptions;

  public bool ApplyToAllItems => this._applyToAllItems;

  private void frmMessageDropOptions_Load(object sender, EventArgs e)
  {
    this.rdoFullMessage.Checked = true;
    this.rdoAttachmentsOnly.Visible = SystemInfo.IsOfficeAppAvailable(SystemInfo.OfficeApps.Outlook, SystemInfo.WordVersion.Office2000);
  }

  public enum MessageImportOptions
  {
    None,
    FullMessage,
    MessageOnly,
    AttachmentOnly,
    FullMessageAttachmentsBrokenOut,
  }
}
