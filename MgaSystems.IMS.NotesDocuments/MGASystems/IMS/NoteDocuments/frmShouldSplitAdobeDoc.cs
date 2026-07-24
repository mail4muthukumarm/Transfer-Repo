// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.NoteDocuments.frmShouldSplitAdobeDoc
// Assembly: MgaSystems.IMS.NotesDocuments, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 3F898CF7-066D-4B05-A9F1-D37DBC4FAA16
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.NotesDocuments.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using MGASystems.Common;
using MGASystems.IMS.NoteDocuments.Serialization;
using MGASystems.Tools;
using MGASystems.Tools.BaseClasses;
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
[Preference("DockingTabs.Documents.AdobeDocumentSplitDialog.Show", true)]
public class frmShouldSplitAdobeDoc : MGABaseForm
{
  internal const string PREFERENCE_SHOWSPLITDLG = "DockingTabs.Documents.AdobeDocumentSplitDialog.Show";
  private IContainer components;

  public frmShouldSplitAdobeDoc() => this.InitializeComponent();

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGACheckBox chkDoNotAsk
  {
    get => this._chkDoNotAsk;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.chkDoNotAsk_CheckedChanged);
      MGACheckBox chkDoNotAsk1 = this._chkDoNotAsk;
      if (chkDoNotAsk1 != null)
        ((UltraToggleEditorBase) chkDoNotAsk1).CheckedChanged -= eventHandler;
      this._chkDoNotAsk = value;
      MGACheckBox chkDoNotAsk2 = this._chkDoNotAsk;
      if (chkDoNotAsk2 == null)
        return;
      ((UltraToggleEditorBase) chkDoNotAsk2).CheckedChanged += eventHandler;
    }
  }

  internal virtual MGAButton btnNoChange
  {
    get => this._btnNoChange;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnNoChange_Click);
      MGAButton btnNoChange1 = this._btnNoChange;
      if (btnNoChange1 != null)
        ((Control) btnNoChange1).Click -= eventHandler;
      this._btnNoChange = value;
      MGAButton btnNoChange2 = this._btnNoChange;
      if (btnNoChange2 == null)
        return;
      ((Control) btnNoChange2).Click += eventHandler;
    }
  }

  internal virtual MGAButton btnSplit
  {
    get => this._btnSplit;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnSplit_Click);
      MGAButton btnSplit1 = this._btnSplit;
      if (btnSplit1 != null)
        ((Control) btnSplit1).Click -= eventHandler;
      this._btnSplit = value;
      MGAButton btnSplit2 = this._btnSplit;
      if (btnSplit2 == null)
        return;
      ((Control) btnSplit2).Click += eventHandler;
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmShouldSplitAdobeDoc));
    Appearance appearance3 = new Appearance();
    this.chkDoNotAsk = new MGACheckBox();
    this.Label1 = new Label();
    this.btnNoChange = new MGAButton();
    this.btnSplit = new MGAButton();
    ((ISupportInitialize) this.chkDoNotAsk).BeginInit();
    ((ISupportInitialize) this.btnNoChange).BeginInit();
    ((ISupportInitialize) this.btnSplit).BeginInit();
    this.SuspendLayout();
    appearance1.BorderColor = Color.Gray;
    appearance1.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkDoNotAsk).Appearance = (AppearanceBase) appearance1;
    ((UltraToggleEditorBase) this.chkDoNotAsk).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkDoNotAsk).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkDoNotAsk).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkDoNotAsk).Location = new Point(8, 88);
    ((Control) this.chkDoNotAsk).Name = "chkDoNotAsk";
    ((Control) this.chkDoNotAsk).Size = new Size(200, 20);
    ((Control) this.chkDoNotAsk).TabIndex = 0;
    ((UltraToggleEditorBase) this.chkDoNotAsk).Text = "Do not ask me again in the future";
    this.Label1.BackColor = Color.Transparent;
    this.Label1.Location = new Point(8, 8);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(280, 36);
    this.Label1.TabIndex = 1;
    this.Label1.Text = "Would you like to split this document into multiple documents, or import without changes?";
    appearance2.BackColor = Color.FromArgb(248, 248, 248);
    appearance2.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance2.BackGradientStyle = (GradientStyle) 2;
    appearance2.BorderColor = Color.DarkGray;
    appearance2.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance2.Image"));
    ((ControlBase) this.btnNoChange).Appearance = (AppearanceBase) appearance2;
    ((Control) this.btnNoChange).Location = new Point(36, 47);
    ((Control) this.btnNoChange).Name = "btnNoChange";
    ((Control) this.btnNoChange).Size = new Size(97, 33);
    ((Control) this.btnNoChange).TabIndex = 2;
    ((ControlBase) this.btnNoChange).Text = "No Changes";
    this.btnNoChange.UseOSThemes = (DefaultableBoolean) 2;
    appearance3.BackColor = Color.FromArgb(248, 248, 248);
    appearance3.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance3.BackGradientStyle = (GradientStyle) 2;
    appearance3.BorderColor = Color.DarkGray;
    appearance3.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance3.Image"));
    ((ControlBase) this.btnSplit).Appearance = (AppearanceBase) appearance3;
    ((UltraButtonBase) this.btnSplit).DialogResult = DialogResult.Cancel;
    ((Control) this.btnSplit).Location = new Point(149, 47);
    ((Control) this.btnSplit).Name = "btnSplit";
    ((Control) this.btnSplit).Size = new Size(97, 33);
    ((Control) this.btnSplit).TabIndex = 3;
    ((ControlBase) this.btnSplit).Text = "Split";
    this.btnSplit.UseOSThemes = (DefaultableBoolean) 2;
    this.AcceptButton = (IButtonControl) this.btnNoChange;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.CancelButton = (IButtonControl) this.btnSplit;
    this.ClientSize = new Size(298, 120);
    this.Controls.Add((Control) this.btnSplit);
    this.Controls.Add((Control) this.btnNoChange);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.chkDoNotAsk);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
    this.Name = nameof (frmShouldSplitAdobeDoc);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Adobe document splitting";
    ((ISupportInitialize) this.chkDoNotAsk).EndInit();
    ((ISupportInitialize) this.btnNoChange).EndInit();
    ((ISupportInitialize) this.btnSplit).EndInit();
    this.ResumeLayout(false);
  }

  private void btnNoChange_Click(object sender, EventArgs e)
  {
    this.DialogResult = DialogResult.OK;
    this.Close();
  }

  private void btnSplit_Click(object sender, EventArgs e)
  {
    this.DialogResult = DialogResult.Cancel;
    this.Close();
  }

  private void chkDoNotAsk_CheckedChanged(object sender, EventArgs e)
  {
    Preferences.SetPreference("DockingTabs.Documents.AdobeDocumentSplitDialog.Show", ((UltraToggleEditorBase) this.chkDoNotAsk).Checked);
  }
}
