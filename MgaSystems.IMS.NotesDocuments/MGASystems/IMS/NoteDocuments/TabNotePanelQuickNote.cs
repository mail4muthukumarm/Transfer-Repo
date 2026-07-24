// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.NoteDocuments.TabNotePanelQuickNote
// Assembly: MgaSystems.IMS.NotesDocuments, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 3F898CF7-066D-4B05-A9F1-D37DBC4FAA16
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.NotesDocuments.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using MGASystems.Common;
using MGASystems.Common.DataAccess;
using MGASystems.IMS.NoteDocuments.NoteDiarySystem;
using MGASystems.Tools;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.NoteDocuments;

public class TabNotePanelQuickNote : Form
{
  private IContainer components;
  private MGASimpleComboBox cboType;
  private MGATextBox txtEntry;
  private Label lblCreatedDate;
  private Label Label1;
  private MGATextBox txtSubject;
  private ErrorProvider ErrorProvider1;
  private bool _noteSaved;

  public TabNotePanelQuickNote()
  {
    this.Load += new EventHandler(this.TabNotePanelQuickNote_Load);
    this.Closing += new CancelEventHandler(this.TabNotePanelQuickNote_Closing);
    this.InitializeComponent();
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private virtual MGAButton btnSaveEntry
  {
    get => this._btnSaveEntry;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnSaveEntry_Click);
      MGAButton btnSaveEntry1 = this._btnSaveEntry;
      if (btnSaveEntry1 != null)
        ((Control) btnSaveEntry1).Click -= eventHandler;
      this._btnSaveEntry = value;
      MGAButton btnSaveEntry2 = this._btnSaveEntry;
      if (btnSaveEntry2 == null)
        return;
      ((Control) btnSaveEntry2).Click += eventHandler;
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    this.cboType = new MGASimpleComboBox();
    this.btnSaveEntry = new MGAButton();
    this.txtEntry = new MGATextBox();
    this.lblCreatedDate = new Label();
    this.Label1 = new Label();
    this.txtSubject = new MGATextBox();
    this.ErrorProvider1 = new ErrorProvider();
    ((ISupportInitialize) this.cboType).BeginInit();
    ((ISupportInitialize) this.btnSaveEntry).BeginInit();
    ((ISupportInitialize) this.txtEntry).BeginInit();
    ((ISupportInitialize) this.txtSubject).BeginInit();
    this.SuspendLayout();
    ((Control) this.cboType).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.cboType.BorderStyle = (UIElementBorderStyle) 4;
    this.cboType.CharacterCasing = CharacterCasing.Normal;
    ((UltraDropDownBase) this.cboType).DisplayMember = "";
    this.cboType.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboType).Location = new Point(440, 32 /*0x20*/);
    this.cboType.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboType).Name = "cboType";
    ((Control) this.cboType).Size = new Size(120, 20);
    ((Control) this.cboType).TabIndex = 1;
    ((UltraDropDownBase) this.cboType).ValueMember = "";
    ((Control) this.btnSaveEntry).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    ((ControlBase) this.btnSaveEntry).ImageSize = new Size(24, 24);
    ((Control) this.btnSaveEntry).Location = new Point(520, 200);
    ((Control) this.btnSaveEntry).Name = "btnSaveEntry";
    ((Control) this.btnSaveEntry).TabIndex = 3;
    ((Control) this.txtEntry).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance1.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtEntry).Appearance = (AppearanceBase) appearance1;
    ((Control) this.txtEntry).Location = new Point(8, 56);
    this.txtEntry.MGAStyle = MGAStyles.Blue;
    this.txtEntry.Multiline = true;
    ((Control) this.txtEntry).Name = "txtEntry";
    ((Control) this.txtEntry).Size = new Size(552, 136);
    ((Control) this.txtEntry).TabIndex = 2;
    ((TextEditorControlBase) this.txtEntry).Text = "Enter note text here.";
    this.lblCreatedDate.Location = new Point(8, 32 /*0x20*/);
    this.lblCreatedDate.Name = "lblCreatedDate";
    this.lblCreatedDate.Size = new Size(120, 16 /*0x10*/);
    this.lblCreatedDate.TabIndex = 20;
    this.lblCreatedDate.Text = "Created: 12/12/02";
    this.Label1.AutoSize = true;
    this.Label1.Location = new Point(8, 8);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(41, 17);
    this.Label1.TabIndex = 19;
    this.Label1.Text = "Subject";
    ((Control) this.txtSubject).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    appearance2.BackColor = Color.White;
    appearance2.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance2.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtSubject).Appearance = (AppearanceBase) appearance2;
    ((Control) this.txtSubject).Location = new Point(56, 8);
    this.txtSubject.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtSubject).Name = "txtSubject";
    ((Control) this.txtSubject).Size = new Size(504, 20);
    ((Control) this.txtSubject).TabIndex = 0;
    ((TextEditorControlBase) this.txtSubject).Text = "Please enter a subject.";
    this.ErrorProvider1.ContainerControl = (ContainerControl) this;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.FromArgb(250, 250, 250);
    this.ClientSize = new Size(584, 246);
    this.Controls.Add((Control) this.cboType);
    this.Controls.Add((Control) this.btnSaveEntry);
    this.Controls.Add((Control) this.txtEntry);
    this.Controls.Add((Control) this.lblCreatedDate);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.txtSubject);
    this.Font = new Font("Tahoma", 8.25f);
    this.ForeColor = Color.Black;
    this.Name = nameof (TabNotePanelQuickNote);
    this.Text = "New Note (unbound)";
    ((ISupportInitialize) this.cboType).EndInit();
    ((ISupportInitialize) this.btnSaveEntry).EndInit();
    ((ISupportInitialize) this.txtEntry).EndInit();
    ((ISupportInitialize) this.txtSubject).EndInit();
    this.ResumeLayout(false);
  }

  private void TabNotePanelQuickNote_Load(object sender, EventArgs e)
  {
    ((ControlBase) this.btnSaveEntry).Appearance.Image = (object) ImageCache.Instance.Save;
    this.lblCreatedDate.Text = $"Created {DateAndTime.Now.ToShortDateString()}";
    Database.Instance.QueryMultithreadedText.PerformTableQuery(new TableQueryMultithreadEventHandler(this.lstNoteTypes_TableFilled), (Control) this, (object) "lstNoteTypes", "SELECT NoteTypeID, Description FROM lstNoteTypes");
  }

  private void lstNoteTypes_TableFilled(object sender, TableQueryMultithreadEventArgs e)
  {
    ((UltraGridBase) this.cboType).DataSource = (object) e.Table;
    ((UltraDropDownBase) this.cboType).ValueMember = "NoteTypeID";
    ((UltraDropDownBase) this.cboType).DisplayMember = "Description";
    this.cboType.Value = (object) -1;
    this.cboType.Value = (object) -1;
  }

  private bool ValidateControls()
  {
    bool flag = true;
    if (string.IsNullOrEmpty(((TextEditorControlBase) this.txtSubject).Text))
    {
      this.ErrorProvider1.SetError((Control) this.txtSubject, "You must enter a subject.");
      flag = false;
    }
    else
      this.ErrorProvider1.SetError((Control) this.txtSubject, string.Empty);
    if (string.IsNullOrEmpty(((TextEditorControlBase) this.txtEntry).Text))
    {
      this.ErrorProvider1.SetError((Control) this.txtEntry, "You must enter content.");
      flag = false;
    }
    else
      this.ErrorProvider1.SetError((Control) this.txtEntry, string.Empty);
    if (string.IsNullOrEmpty(this.cboType.Text))
    {
      this.ErrorProvider1.SetError((Control) this.cboType, "You must choose a type.");
      flag = false;
    }
    else
      this.ErrorProvider1.SetError((Control) this.cboType, string.Empty);
    return flag;
  }

  private void btnSaveEntry_Click(object sender, EventArgs e)
  {
    if (!this.DoSave())
      return;
    this.Close();
  }

  public bool HasChanges
  {
    get
    {
      return !this._noteSaved && (Operators.CompareString(((TextEditorControlBase) this.txtSubject).Text, "Please enter a subject.", false) != 0 || Operators.CompareString(((TextEditorControlBase) this.txtEntry).Text, "Enter note text here.", false) != 0);
    }
  }

  private void TabNotePanelQuickNote_Closing(object sender, CancelEventArgs e)
  {
    if (!this.HasChanges)
      return;
    switch (MessageBox.Show("Would you like to save your changes?", "Changes Detected", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
    {
      case DialogResult.Cancel:
        e.Cancel = true;
        break;
      case DialogResult.Yes:
        if (this.DoSave())
          break;
        e.Cancel = true;
        break;
    }
  }

  private bool DoSave()
  {
    bool flag;
    if (this.ValidateControls())
    {
      Note_System.Instance.NonInteractive.CreateNote(Database.IsNull(RuntimeHelpers.GetObjectValue(this.cboType.Value), -1), ((TextEditorControlBase) this.txtSubject).Text, CurrentUser.Instance.UserGUID, ((TextEditorControlBase) this.txtEntry).Text, false, new Guid[1]
      {
        CurrentUser.Instance.UserGUID
      });
      this._noteSaved = true;
      flag = true;
    }
    else
      flag = false;
    return flag;
  }
}
