// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.NoteDocuments.frmAdminDocumentType
// Assembly: MgaSystems.IMS.NotesDocuments, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 3F898CF7-066D-4B05-A9F1-D37DBC4FAA16
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.NotesDocuments.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using MGASystems.Tools;
using MGASystems.Tools.DBSaveUI;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.NoteDocuments;

[DesignerGenerated]
public class frmAdminDocumentType : Form
{
  private IContainer components;
  private DocumentType selectedDocType;

  public frmAdminDocumentType()
  {
    this.Load += new EventHandler(this.frmAdminDocumentType_Load);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  protected override void Dispose(bool disposing)
  {
    try
    {
      if (!disposing || this.components == null)
        return;
      this.components.Dispose();
    }
    finally
    {
      base.Dispose(disposing);
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    this.grpNoteDefaults = new MGAGroupBox();
    this.txtDocumentType = new MGATextBox();
    this.DbSaveUI1 = new MGASystems.Tools.DBSaveUI.DBSaveUI();
    this.lstDocumentTypes = new MGAListBox();
    Label label = new Label();
    ((ISupportInitialize) this.grpNoteDefaults).BeginInit();
    ((Control) this.grpNoteDefaults).SuspendLayout();
    ((ISupportInitialize) this.txtDocumentType).BeginInit();
    ((ISupportInitialize) this.lstDocumentTypes).BeginInit();
    this.SuspendLayout();
    label.AutoSize = true;
    label.BackColor = Color.Transparent;
    label.Location = new Point(22, 8);
    label.Name = "Label3";
    label.Size = new Size(86, 13);
    label.TabIndex = 0;
    label.Text = "Document Type:";
    ((Control) this.grpNoteDefaults).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    appearance1.BackColor = Color.FromArgb(239, 247, 253);
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.grpNoteDefaults.ContentAreaAppearance = (AppearanceBase) appearance1;
    ((Control) this.grpNoteDefaults).Controls.Add((Control) label);
    ((Control) this.grpNoteDefaults).Controls.Add((Control) this.txtDocumentType);
    ((Control) this.grpNoteDefaults).Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    appearance2.ForeColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.grpNoteDefaults.HeaderAppearance = (AppearanceBase) appearance2;
    ((Control) this.grpNoteDefaults).Location = new Point(174, 5);
    ((Control) this.grpNoteDefaults).Name = "grpNoteDefaults";
    ((Control) this.grpNoteDefaults).Size = new Size(503, 215);
    ((Control) this.grpNoteDefaults).TabIndex = 7;
    this.grpNoteDefaults.ViewStyle = (GroupBoxViewStyle) 2;
    ((Control) this.txtDocumentType).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    appearance3.BackColor = Color.White;
    appearance3.BorderColor = Color.Gray;
    appearance3.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtDocumentType).Appearance = (AppearanceBase) appearance3;
    ((TextEditorControlBase) this.txtDocumentType).BackColor = Color.White;
    ((Control) this.txtDocumentType).Location = new Point(114, 5);
    ((Control) this.txtDocumentType).Name = "txtDocumentType";
    ((Control) this.txtDocumentType).Size = new Size(367, 20);
    ((Control) this.txtDocumentType).TabIndex = 1;
    ((UltraControlBase) this.txtDocumentType).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtDocumentType).UseOsThemes = (DefaultableBoolean) 2;
    this.DbSaveUI1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.DbSaveUI1.AutoQueryRowCountOnLoad = false;
    this.DbSaveUI1.EditStyle = EditStyle.ShowEditButton;
    this.DbSaveUI1.FreezeEvents = false;
    this.DbSaveUI1.Location = new Point(557, 226);
    this.DbSaveUI1.Name = "DbSaveUI1";
    this.DbSaveUI1.Size = new Size(120, 40);
    this.DbSaveUI1.TabIndex = 8;
    this.DbSaveUI1.UIState = UIState.HasRecordsNotEditing;
    this.lstDocumentTypes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
    this.lstDocumentTypes.BackColor = SystemColors.Window;
    this.lstDocumentTypes.FormattingEnabled = true;
    this.lstDocumentTypes.IntegralHeight = false;
    this.lstDocumentTypes.Location = new Point(3, 5);
    this.lstDocumentTypes.Name = "lstDocumentTypes";
    this.lstDocumentTypes.Size = new Size(165, 261);
    this.lstDocumentTypes.TabIndex = 5;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(712, 284);
    this.Controls.Add((Control) this.grpNoteDefaults);
    this.Controls.Add((Control) this.DbSaveUI1);
    this.Controls.Add((Control) this.lstDocumentTypes);
    this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
    this.Name = nameof (frmAdminDocumentType);
    this.Text = "Document Types Administration";
    ((ISupportInitialize) this.grpNoteDefaults).EndInit();
    ((Control) this.grpNoteDefaults).ResumeLayout(false);
    ((Control) this.grpNoteDefaults).PerformLayout();
    ((ISupportInitialize) this.txtDocumentType).EndInit();
    ((ISupportInitialize) this.lstDocumentTypes).EndInit();
    this.ResumeLayout(false);
  }

  [field: AccessedThroughProperty("grpNoteDefaults")]
  internal virtual MGAGroupBox grpNoteDefaults { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtDocumentType")]
  internal virtual MGATextBox txtDocumentType { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MGASystems.Tools.DBSaveUI.DBSaveUI DbSaveUI1
  {
    get => this._DbSaveUI1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      CancelEventHandler cancelEventHandler1 = new CancelEventHandler(this.DbSaveUI1_ClickingEdit);
      EventHandler eventHandler1 = new EventHandler(this.DbSaveUI1_ClickedNew);
      EventHandler eventHandler2 = new EventHandler(this.DbSaveUI1_ClickedCancel);
      CancelEventHandler cancelEventHandler2 = new CancelEventHandler(this.DbSaveUI1_ClickingDelete);
      EventHandler eventHandler3 = new EventHandler(this.DbSaveUI1_ClickedDelete);
      EventHandler eventHandler4 = new EventHandler(this.DbSaveUI1_ClickedSave);
      CancelEventHandler cancelEventHandler3 = new CancelEventHandler(this.DbSaveUI1_ClickingSave);
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSaveUi1_1 = this._DbSaveUI1;
      if (dbSaveUi1_1 != null)
      {
        dbSaveUi1_1.ClickingEdit -= cancelEventHandler1;
        dbSaveUi1_1.ClickedNew -= eventHandler1;
        dbSaveUi1_1.ClickedCancel -= eventHandler2;
        dbSaveUi1_1.ClickingDelete -= cancelEventHandler2;
        dbSaveUi1_1.ClickedDelete -= eventHandler3;
        dbSaveUi1_1.ClickedSave -= eventHandler4;
        dbSaveUi1_1.ClickingSave -= cancelEventHandler3;
      }
      this._DbSaveUI1 = value;
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSaveUi1_2 = this._DbSaveUI1;
      if (dbSaveUi1_2 == null)
        return;
      dbSaveUi1_2.ClickingEdit += cancelEventHandler1;
      dbSaveUi1_2.ClickedNew += eventHandler1;
      dbSaveUi1_2.ClickedCancel += eventHandler2;
      dbSaveUi1_2.ClickingDelete += cancelEventHandler2;
      dbSaveUi1_2.ClickedDelete += eventHandler3;
      dbSaveUi1_2.ClickedSave += eventHandler4;
      dbSaveUi1_2.ClickingSave += cancelEventHandler3;
    }
  }

  internal virtual MGAListBox lstDocumentTypes
  {
    get => this._lstDocumentTypes;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.lstDocumentTypes_SelectedIndexChanged);
      MGAListBox lstDocumentTypes1 = this._lstDocumentTypes;
      if (lstDocumentTypes1 != null)
        lstDocumentTypes1.SelectedIndexChanged -= eventHandler;
      this._lstDocumentTypes = value;
      MGAListBox lstDocumentTypes2 = this._lstDocumentTypes;
      if (lstDocumentTypes2 == null)
        return;
      lstDocumentTypes2.SelectedIndexChanged += eventHandler;
    }
  }

  private void frmAdminDocumentType_Load(object sender, EventArgs e)
  {
    this.SetTypeList();
    ((EditorButtonControlBase) this.txtDocumentType).ReadOnly = true;
  }

  private void SetTypeList()
  {
    this.lstDocumentTypes.DataSource = (object) DocumentType.GetDocumentTypeList();
    this.lstDocumentTypes.DisplayMember = "TypeName";
    this.lstDocumentTypes.ValueMember = "TypeGuid";
  }

  private void DbSaveUI1_ClickingEdit(object sender, CancelEventArgs e)
  {
    if (this.selectedDocType == null)
      return;
    if (this.selectedDocType.SystemDefined)
    {
      int num = (int) MessageBox.Show("Cannot edit a system defined document type", "No Edit", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      e.Cancel = true;
    }
    else
    {
      ((EditorButtonControlBase) this.txtDocumentType).ReadOnly = false;
      ((TextEditorControlBase) this.txtDocumentType).Focus();
      this.lstDocumentTypes.Enabled = false;
    }
  }

  private void DbSaveUI1_ClickedNew(object sender, EventArgs e)
  {
    this.selectedDocType = DocumentType.Allocate(Guid.Empty, "", false);
    ((TextEditorControlBase) this.txtDocumentType).Text = this.selectedDocType.TypeName;
    this.lstDocumentTypes.Enabled = false;
    ((EditorButtonControlBase) this.txtDocumentType).ReadOnly = false;
    ((TextEditorControlBase) this.txtDocumentType).Focus();
  }

  private void DbSaveUI1_ClickedCancel(object sender, EventArgs e)
  {
    this.lstDocumentTypes.SetSelected(0, true);
    ((EditorButtonControlBase) this.txtDocumentType).ReadOnly = true;
    this.lstDocumentTypes.Enabled = true;
  }

  private void DbSaveUI1_ClickingDelete(object sender, CancelEventArgs e)
  {
    if (this.selectedDocType == null)
      e.Cancel = true;
    if (!this.selectedDocType.SystemDefined)
      return;
    int num = (int) MessageBox.Show("Cannot delete a system defined document type", "No Delete", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    e.Cancel = true;
  }

  private void DbSaveUI1_ClickedDelete(object sender, EventArgs e)
  {
    if (this.selectedDocType == null)
      return;
    DocumentType.DeleteDocumentType(this.selectedDocType.TypeGuid);
    this.SetTypeList();
  }

  private void lstDocumentTypes_SelectedIndexChanged(object sender, EventArgs e)
  {
    this.selectedDocType = (DocumentType) this.lstDocumentTypes.SelectedItem;
    ((TextEditorControlBase) this.txtDocumentType).Text = this.selectedDocType.TypeName;
  }

  private void DbSaveUI1_ClickedSave(object sender, EventArgs e)
  {
    if (this.selectedDocType != null)
    {
      DocumentType.SaveDocumentType(this.selectedDocType.TypeGuid, ((TextEditorControlBase) this.txtDocumentType).Text);
      this.SetTypeList();
    }
    ((EditorButtonControlBase) this.txtDocumentType).ReadOnly = true;
    this.lstDocumentTypes.Enabled = true;
  }

  private void DbSaveUI1_ClickingSave(object sender, CancelEventArgs e)
  {
    if (this.selectedDocType == null)
    {
      e.Cancel = true;
    }
    else
    {
      if (!string.IsNullOrEmpty(((TextEditorControlBase) this.txtDocumentType).Text))
        return;
      e.Cancel = true;
    }
  }
}
