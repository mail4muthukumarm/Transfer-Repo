// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.NoteDocuments.CompleteDiaryMultiForm
// Assembly: MgaSystems.IMS.NotesDocuments, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 3F898CF7-066D-4B05-A9F1-D37DBC4FAA16
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.NotesDocuments.dll

using MGASystems.Common;
using MGASystems.Data;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.NoteDocuments;

[DesignerGenerated]
public class CompleteDiaryMultiForm : Form
{
  private IContainer components;
  private bool _sendCompletionNotice;

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
    this.TableLayoutPanel1 = new TableLayoutPanel();
    this.OK_Button = new Button();
    this.Cancel_Button = new Button();
    this.lbDiariedUsers = new CheckedListBox();
    this.DsMultiRecipientDiary = new dsMultiRecipientDiary();
    this.chkSendCompletionNotice = new CheckBox();
    this.TableLayoutPanel1.SuspendLayout();
    this.DsMultiRecipientDiary.BeginInit();
    this.SuspendLayout();
    this.TableLayoutPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.TableLayoutPanel1.ColumnCount = 2;
    this.TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
    this.TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
    this.TableLayoutPanel1.Controls.Add((Control) this.OK_Button, 0, 0);
    this.TableLayoutPanel1.Controls.Add((Control) this.Cancel_Button, 1, 0);
    this.TableLayoutPanel1.Location = new Point(260, 165);
    this.TableLayoutPanel1.Name = "TableLayoutPanel1";
    this.TableLayoutPanel1.RowCount = 1;
    this.TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50f));
    this.TableLayoutPanel1.Size = new Size(146, 29);
    this.TableLayoutPanel1.TabIndex = 0;
    this.OK_Button.Anchor = AnchorStyles.None;
    this.OK_Button.Location = new Point(3, 3);
    this.OK_Button.Name = "OK_Button";
    this.OK_Button.Size = new Size(67, 23);
    this.OK_Button.TabIndex = 0;
    this.OK_Button.Text = "OK";
    this.Cancel_Button.Anchor = AnchorStyles.None;
    this.Cancel_Button.DialogResult = DialogResult.Cancel;
    this.Cancel_Button.Location = new Point(76, 3);
    this.Cancel_Button.Name = "Cancel_Button";
    this.Cancel_Button.Size = new Size(67, 23);
    this.Cancel_Button.TabIndex = 1;
    this.Cancel_Button.Text = "Cancel";
    this.lbDiariedUsers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.lbDiariedUsers.CheckOnClick = true;
    this.lbDiariedUsers.FormattingEnabled = true;
    this.lbDiariedUsers.IntegralHeight = false;
    this.lbDiariedUsers.Location = new Point(12, 5);
    this.lbDiariedUsers.Name = "lbDiariedUsers";
    this.lbDiariedUsers.Size = new Size(394, 154);
    this.lbDiariedUsers.TabIndex = 1;
    this.DsMultiRecipientDiary.DataSetName = "dsMultiRecipientDiary";
    this.DsMultiRecipientDiary.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.chkSendCompletionNotice.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.chkSendCompletionNotice.AutoSize = true;
    this.chkSendCompletionNotice.Checked = true;
    this.chkSendCompletionNotice.CheckState = CheckState.Checked;
    this.chkSendCompletionNotice.Location = new Point(12, 177);
    this.chkSendCompletionNotice.Name = "chkSendCompletionNotice";
    this.chkSendCompletionNotice.Size = new Size(227, 17);
    this.chkSendCompletionNotice.TabIndex = 2;
    this.chkSendCompletionNotice.Text = "Send completion notice to affected users?";
    this.chkSendCompletionNotice.UseVisualStyleBackColor = true;
    this.AcceptButton = (IButtonControl) this.OK_Button;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.CancelButton = (IButtonControl) this.Cancel_Button;
    this.ClientSize = new Size(418, 206);
    this.Controls.Add((Control) this.chkSendCompletionNotice);
    this.Controls.Add((Control) this.lbDiariedUsers);
    this.Controls.Add((Control) this.TableLayoutPanel1);
    this.Font = new Font("Tahoma", 8.25f);
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (CompleteDiaryMultiForm);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterParent;
    this.Text = "Check to complete the diary for the following recipients.";
    this.TableLayoutPanel1.ResumeLayout(false);
    this.DsMultiRecipientDiary.EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  [field: AccessedThroughProperty("TableLayoutPanel1")]
  internal virtual TableLayoutPanel TableLayoutPanel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual Button OK_Button
  {
    get => this._OK_Button;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.OK_Button_Click);
      Button okButton1 = this._OK_Button;
      if (okButton1 != null)
        okButton1.Click -= eventHandler;
      this._OK_Button = value;
      Button okButton2 = this._OK_Button;
      if (okButton2 == null)
        return;
      okButton2.Click += eventHandler;
    }
  }

  internal virtual Button Cancel_Button
  {
    get => this._Cancel_Button;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.Cancel_Button_Click);
      Button cancelButton1 = this._Cancel_Button;
      if (cancelButton1 != null)
        cancelButton1.Click -= eventHandler;
      this._Cancel_Button = value;
      Button cancelButton2 = this._Cancel_Button;
      if (cancelButton2 == null)
        return;
      cancelButton2.Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("lbDiariedUsers")]
  internal virtual CheckedListBox lbDiariedUsers { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("DsMultiRecipientDiary")]
  private virtual dsMultiRecipientDiary DsMultiRecipientDiary { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkSendCompletionNotice")]
  internal virtual CheckBox chkSendCompletionNotice { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public bool SendCompletionNotice => this._sendCompletionNotice;

  private void OK_Button_Click(object sender, EventArgs e)
  {
    if (this.chkSendCompletionNotice.Checked)
      this._sendCompletionNotice = true;
    this.UpdateCompletedStatus();
    this.DialogResult = DialogResult.OK;
    this.Close();
  }

  private void Cancel_Button_Click(object sender, EventArgs e)
  {
    this.DialogResult = DialogResult.Cancel;
    this.Close();
  }

  public CompleteDiaryMultiForm(Guid entryGuid, bool complete)
  {
    this.InitializeComponent();
    DefaultDatabase.LoadDataSet((DataSet) this.DsMultiRecipientDiary, new string[1]
    {
      "NoteSystem_GetDiaryRecipientsStatusOnEntry"
    }, "NoteSystem_GetDiaryRecipientsStatusOnEntry", new object[2]
    {
      (object) "@EntryGuid",
      (object) entryGuid
    });
    try
    {
      foreach (object obj in (TypedTableBase<dsMultiRecipientDiary.NoteSystem_GetDiaryRecipientsStatusOnEntryRow>) this.DsMultiRecipientDiary.NoteSystem_GetDiaryRecipientsStatusOnEntry)
        this.lbDiariedUsers.Items.Add(obj, complete);
    }
    finally
    {
      IEnumerator<dsMultiRecipientDiary.NoteSystem_GetDiaryRecipientsStatusOnEntryRow> enumerator;
      enumerator?.Dispose();
    }
  }

  private void UpdateCompletedStatus()
  {
    DateTime dateTime = DateAndTime.Now;
    if (SystemSettings.GetSetting<bool>("NoteView.UseServerDateTime", false))
      dateTime = CurrentUser.ServerTime;
    try
    {
      foreach (dsMultiRecipientDiary.NoteSystem_GetDiaryRecipientsStatusOnEntryRow statusOnEntryRow in (TypedTableBase<dsMultiRecipientDiary.NoteSystem_GetDiaryRecipientsStatusOnEntryRow>) this.DsMultiRecipientDiary.NoteSystem_GetDiaryRecipientsStatusOnEntry)
      {
        statusOnEntryRow.CompletedDate = dateTime;
        statusOnEntryRow.Completed = this.lbDiariedUsers.CheckedItems.Contains((object) statusOnEntryRow);
      }
    }
    finally
    {
      IEnumerator<dsMultiRecipientDiary.NoteSystem_GetDiaryRecipientsStatusOnEntryRow> enumerator;
      enumerator?.Dispose();
    }
  }

  public dsMultiRecipientDiary.NoteSystem_GetDiaryRecipientsStatusOnEntryDataTable DiaryCompletedStatus
  {
    get => this.DsMultiRecipientDiary.NoteSystem_GetDiaryRecipientsStatusOnEntry;
  }
}
