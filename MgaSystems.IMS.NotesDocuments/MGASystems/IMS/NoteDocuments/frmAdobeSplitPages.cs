// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.NoteDocuments.frmAdobeSplitPages
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
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.NoteDocuments;

[SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly")]
public class frmAdobeSplitPages : Form
{
  private string _adobeSplitString;
  private IContainer components;
  private UltraGroupBox MgaGroupBox1;
  private Label Label1;
  private MGATextBox txtPages;

  public frmAdobeSplitPages() => this.InitializeComponent();

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

  private virtual CustomValidator CustomValidator1
  {
    get => this._CustomValidator1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      CustomValidator.ValidateEventHandler validateEventHandler = new CustomValidator.ValidateEventHandler(this.CustomValidator1_CustomValidate);
      CustomValidator customValidator1_1 = this._CustomValidator1;
      if (customValidator1_1 != null)
        customValidator1_1.CustomValidate -= validateEventHandler;
      this._CustomValidator1 = value;
      CustomValidator customValidator1_2 = this._CustomValidator1;
      if (customValidator1_2 == null)
        return;
      customValidator1_2.CustomValidate += validateEventHandler;
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    this.btnCancel = new MGAButton();
    this.btnOK = new MGAButton();
    this.MgaGroupBox1 = new UltraGroupBox();
    this.txtPages = new MGATextBox();
    this.Label1 = new Label();
    this.CustomValidator1 = new CustomValidator(this.components);
    ((ISupportInitialize) this.btnCancel).BeginInit();
    ((ISupportInitialize) this.btnOK).BeginInit();
    ((ISupportInitialize) this.MgaGroupBox1).BeginInit();
    ((Control) this.MgaGroupBox1).SuspendLayout();
    ((ISupportInitialize) this.txtPages).BeginInit();
    ((ISupportInitialize) this.CustomValidator1).BeginInit();
    this.SuspendLayout();
    ((Control) this.btnCancel).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance1.BackColor = Color.FromArgb(248, 248, 248);
    appearance1.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance1.BackGradientStyle = (GradientStyle) 2;
    appearance1.BorderColor = Color.DarkGray;
    ((ControlBase) this.btnCancel).Appearance = (AppearanceBase) appearance1;
    ((UltraButtonBase) this.btnCancel).DialogResult = DialogResult.Cancel;
    ((Control) this.btnCancel).Location = new Point(159, 120);
    ((Control) this.btnCancel).Name = "btnCancel";
    ((Control) this.btnCancel).Size = new Size(76, 24);
    ((Control) this.btnCancel).TabIndex = 0;
    ((ControlBase) this.btnCancel).Text = "Cancel";
    this.btnCancel.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.btnOK).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance2.BackColor = Color.FromArgb(248, 248, 248);
    appearance2.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance2.BackGradientStyle = (GradientStyle) 2;
    appearance2.BorderColor = Color.DarkGray;
    ((ControlBase) this.btnOK).Appearance = (AppearanceBase) appearance2;
    ((Control) this.btnOK).Location = new Point(72, 120);
    ((Control) this.btnOK).Name = "btnOK";
    ((Control) this.btnOK).Size = new Size(76, 24);
    ((Control) this.btnOK).TabIndex = 2;
    ((ControlBase) this.btnOK).Text = "Ok";
    this.btnOK.UseOSThemes = (DefaultableBoolean) 2;
    appearance3.BackColor = Color.White;
    this.MgaGroupBox1.Appearance = (AppearanceBase) appearance3;
    this.MgaGroupBox1.BackColorInternal = Color.FromArgb(239, 247, 253);
    appearance4.BackColor = Color.FromArgb(239, 247, 253);
    appearance4.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.MgaGroupBox1.ContentAreaAppearance = (AppearanceBase) appearance4;
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.txtPages);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.Label1);
    appearance5.ForeColor = Color.Navy;
    this.MgaGroupBox1.HeaderAppearance = (AppearanceBase) appearance5;
    ((Control) this.MgaGroupBox1).Location = new Point(11, 8);
    ((Control) this.MgaGroupBox1).Name = "MgaGroupBox1";
    ((Control) this.MgaGroupBox1).Size = new Size(224 /*0xE0*/, 104);
    ((Control) this.MgaGroupBox1).TabIndex = 4;
    this.MgaGroupBox1.Text = "Pages";
    ((Control) this.txtPages).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    appearance6.BackColor = Color.White;
    appearance6.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance6.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtPages).Appearance = (AppearanceBase) appearance6;
    ((TextEditorControlBase) this.txtPages).BackColor = Color.White;
    ((Control) this.txtPages).Location = new Point(9, 72);
    this.txtPages.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtPages).Name = "txtPages";
    ((Control) this.txtPages).Size = new Size(206, 20);
    ((Control) this.txtPages).TabIndex = 1;
    ((UltraControlBase) this.txtPages).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtPages).UseOsThemes = (DefaultableBoolean) 2;
    this.Label1.BackColor = Color.Transparent;
    this.Label1.Location = new Point(8, 24);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(208 /*0xD0*/, 40);
    this.Label1.TabIndex = 0;
    this.Label1.Text = "Enter page numbers and/or page ranges separated by commas. For example, 1,3,5-12. Or 1+3, 1+4, 1+3-5.";
    this.CustomValidator1.ControlToValidate = (Control) this.txtPages;
    this.CustomValidator1.Enabled = true;
    this.CustomValidator1.FieldToValidate = "Text";
    this.AcceptButton = (IButtonControl) this.btnOK;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.CancelButton = (IButtonControl) this.btnCancel;
    this.ClientSize = new Size(242, 152);
    this.Controls.Add((Control) this.MgaGroupBox1);
    this.Controls.Add((Control) this.btnOK);
    this.Controls.Add((Control) this.btnCancel);
    this.Font = new Font("Tahoma", 8.25f);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
    this.Name = nameof (frmAdobeSplitPages);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Adobe Page Splitter";
    ((ISupportInitialize) this.btnCancel).EndInit();
    ((ISupportInitialize) this.btnOK).EndInit();
    ((ISupportInitialize) this.MgaGroupBox1).EndInit();
    ((Control) this.MgaGroupBox1).ResumeLayout(false);
    ((Control) this.MgaGroupBox1).PerformLayout();
    ((ISupportInitialize) this.txtPages).EndInit();
    ((ISupportInitialize) this.CustomValidator1).EndInit();
    this.ResumeLayout(false);
  }

  private void btnCancel_Click(object sender, EventArgs e)
  {
    this.DialogResult = DialogResult.Cancel;
    this.Close();
  }

  private void btnOK_Click(object sender, EventArgs e)
  {
    this.CustomValidator1.Validate();
    if (!this.CustomValidator1.IsValid)
      return;
    this._adobeSplitString = ((TextEditorControlBase) this.txtPages).Text;
    this.DialogResult = DialogResult.OK;
    this.Close();
  }

  public string AdobeSplitString => this._adobeSplitString;

  private void CustomValidator1_CustomValidate(object sender, ValidateEventArgs e)
  {
    e.IsValid = Operators.CompareString(Conversions.ToString(e.Value), string.Empty, false) != 0;
  }
}
