// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.SharedForms.formVoidTransaction
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using MGASystems.Common;
using MGASystems.IMS.Accounting.Core.DataAccess.VoidTransaction;
using MGASystems.IMS.Accounting.Core.Forms;
using MGASystems.IMS.Security;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.SharedForms;

public class formVoidTransaction : FormBase
{
  protected Panel panel1;
  protected MGAButton buttonSave;
  protected MGAButton buttonCancel;
  private Label label1;
  private Label label2;
  private MGADateTimePicker dateTimePostDate;
  protected MGATextBox textComments;
  protected Label label3;
  private System.ComponentModel.Container components;

  private formVoidTransaction() => this.InitializeComponent();

  public formVoidTransaction(int transactionNumber)
  {
    this.InitializeComponent();
    this.TransactionNumber = transactionNumber;
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    this.panel1 = new Panel();
    this.textComments = new MGATextBox();
    this.label3 = new Label();
    this.label2 = new Label();
    this.label1 = new Label();
    this.dateTimePostDate = new MGADateTimePicker();
    this.buttonCancel = new MGAButton();
    this.buttonSave = new MGAButton();
    this.panel1.SuspendLayout();
    ((ISupportInitialize) this.textComments).BeginInit();
    ((ISupportInitialize) this.dateTimePostDate).BeginInit();
    ((ISupportInitialize) this.buttonCancel).BeginInit();
    ((ISupportInitialize) this.buttonSave).BeginInit();
    this.SuspendLayout();
    this.panel1.BackColor = Color.FromArgb(239, 247, 253);
    this.panel1.Controls.Add((Control) this.textComments);
    this.panel1.Controls.Add((Control) this.label3);
    this.panel1.Controls.Add((Control) this.label2);
    this.panel1.Controls.Add((Control) this.label1);
    this.panel1.Controls.Add((Control) this.dateTimePostDate);
    this.panel1.Controls.Add((Control) this.buttonCancel);
    this.panel1.Controls.Add((Control) this.buttonSave);
    this.panel1.Location = new Point(8, 8);
    this.panel1.Name = "panel1";
    this.panel1.Size = new Size(352, 239);
    this.panel1.TabIndex = 0;
    ((AppearanceBase) appearance1).BackColor = Color.White;
    ((AppearanceBase) appearance1).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance1).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textComments).Appearance = (AppearanceBase) appearance1;
    ((Control) this.textComments).BackColor = Color.White;
    ((Control) this.textComments).Location = new Point(11, 72);
    this.textComments.MGAStyle = MGAStyles.Blue;
    this.textComments.Multiline = true;
    ((Control) this.textComments).Name = "textComments";
    ((Control) this.textComments).Size = new Size(333, 128 /*0x80*/);
    ((Control) this.textComments).TabIndex = 6;
    ((UltraControlBase) this.textComments).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textComments).UseOsThemes = (DefaultableBoolean) 2;
    this.label3.AutoSize = true;
    this.label3.Location = new Point(8, 55);
    this.label3.Name = "label3";
    this.label3.Size = new Size(94, 13);
    this.label3.TabIndex = 5;
    this.label3.Text = "Posting Comment:";
    this.label2.AutoSize = true;
    this.label2.Location = new Point(8, 32 /*0x20*/);
    this.label2.Name = "label2";
    this.label2.Size = new Size(116, 13);
    this.label2.TabIndex = 4;
    this.label2.Text = "Void Transaction Date:";
    this.label1.Location = new Point(8, 8);
    this.label1.Name = "label1";
    this.label1.Size = new Size(296, 23);
    this.label1.TabIndex = 3;
    this.label1.Text = "Do you wish to permanently void the specified transaction?";
    ((AppearanceBase) appearance2).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dateTimePostDate.Appearance = (AppearanceBase) appearance2;
    ((AppearanceBase) appearance3).AlphaLevel = (short) 14;
    ((AppearanceBase) appearance3).BackColor = Color.FromArgb(0, 0, 246, 253);
    ((AppearanceBase) appearance3).BackColor2 = Color.FromArgb(133, 162, 221);
    ((AppearanceBase) appearance3).BackColorAlpha = (Alpha) 2;
    ((AppearanceBase) appearance3).BackGradientAlignment = (GradientAlignment) 4;
    ((AppearanceBase) appearance3).BackGradientStyle = (GradientStyle) 5;
    ((AppearanceBase) appearance3).BorderAlpha = (Alpha) 1;
    ((AppearanceBase) appearance3).BorderColor = Color.FromArgb(78, 122, 171);
    ((AppearanceBase) appearance3).ForeColor = Color.FromArgb(49, 85, 153);
    ((AppearanceBase) appearance3).ForegroundAlpha = (Alpha) 2;
    this.dateTimePostDate.ButtonAppearance = (AppearanceBase) appearance3;
    this.dateTimePostDate.FormatString = "D";
    ((Control) this.dateTimePostDate).Location = new Point(136, 32 /*0x20*/);
    this.dateTimePostDate.MGAStyle = MGAStyles.Blue;
    ((Control) this.dateTimePostDate).Name = "dateTimePostDate";
    ((Control) this.dateTimePostDate).Size = new Size(208 /*0xD0*/, 20);
    ((Control) this.dateTimePostDate).TabIndex = 2;
    ((UltraControlBase) this.dateTimePostDate).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dateTimePostDate).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance4).BackColor = Color.Gainsboro;
    ((AppearanceBase) appearance4).BackColor2 = Color.White;
    ((AppearanceBase) appearance4).BackGradientStyle = (GradientStyle) 2;
    ((ControlBase) this.buttonCancel).Appearance = (AppearanceBase) appearance4;
    ((Control) this.buttonCancel).Location = new Point(240 /*0xF0*/, 206);
    ((Control) this.buttonCancel).Name = "buttonCancel";
    ((Control) this.buttonCancel).Size = new Size(104, 24);
    ((Control) this.buttonCancel).TabIndex = 1;
    ((Control) this.buttonCancel).Text = "Cancel";
    ((UltraControlBase) this.buttonCancel).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonCancel).Click += new EventHandler(this.buttonCancel_Click);
    ((AppearanceBase) appearance5).BackColor = Color.Gainsboro;
    ((AppearanceBase) appearance5).BackColor2 = Color.White;
    ((AppearanceBase) appearance5).BackGradientStyle = (GradientStyle) 2;
    ((ControlBase) this.buttonSave).Appearance = (AppearanceBase) appearance5;
    ((Control) this.buttonSave).Location = new Point(120, 206);
    ((Control) this.buttonSave).Name = "buttonSave";
    ((Control) this.buttonSave).Size = new Size(104, 24);
    ((Control) this.buttonSave).TabIndex = 0;
    ((Control) this.buttonSave).Text = "Void Transaction";
    ((UltraControlBase) this.buttonSave).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonSave).Click += new EventHandler(this.buttonSave_Click);
    this.AutoScaleBaseSize = new Size(5, 13);
    this.BackColor = Color.White;
    this.ClientSize = new Size(370, 253);
    this.ControlBox = false;
    this.Controls.Add((Control) this.panel1);
    this.Font = new Font("Tahoma", 8f);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.Name = nameof (formVoidTransaction);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Permanently Void Transaction?";
    this.Load += new EventHandler(this.formVoidTransaction_Load);
    this.panel1.ResumeLayout(false);
    this.panel1.PerformLayout();
    ((ISupportInitialize) this.textComments).EndInit();
    ((ISupportInitialize) this.dateTimePostDate).EndInit();
    ((ISupportInitialize) this.buttonCancel).EndInit();
    ((ISupportInitialize) this.buttonSave).EndInit();
    this.ResumeLayout(false);
  }

  protected int TransactionNumber { get; private set; }

  private void buttonCancel_Click(object sender, EventArgs e)
  {
    this.DialogResult = DialogResult.Cancel;
    this.Close();
  }

  public void VoidJournalTransaction(
    int transactionNumber,
    DateTime postDate,
    string journalComments)
  {
    this.Cursor = MgaCursors.WaitCursor;
    try
    {
      this.ChildVoidJournalTransaction(transactionNumber, postDate, journalComments);
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
    }
  }

  protected virtual void ChildVoidJournalTransaction(
    int transactionNumber,
    DateTime postDate,
    string journalComments)
  {
    new VoidTransactionRepository().VoidTransaction(transactionNumber, postDate, journalComments, new Action<int, int>(this.PublicBeforeVoidCommitted));
  }

  private void buttonSave_Click(object sender, EventArgs e)
  {
    if (this.dateTimePostDate.Value == null)
    {
      int num = (int) MessageBox.Show("You must select a post date to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else
    {
      this.VoidJournalTransaction(this.TransactionNumber, this.dateTimePostDate.DateTime, ((Control) this.textComments).Text);
      this.DialogResult = DialogResult.OK;
      this.Close();
    }
  }

  private void formVoidTransaction_Load(object sender, EventArgs e)
  {
    if (this.DesignMode || SecurityManager.Instance.AssertPermission("{1A4F865E-ABC2-47c1-A976-77B4348F33F3}"))
      return;
    new formAccessDenied().Show();
    this.Close();
  }

  public void PublicBeforeVoidCommitted(int transactionNumber, int voidingTransactionNumber)
  {
    this.BeforeVoidCommitted(transactionNumber, voidingTransactionNumber);
  }

  protected virtual void BeforeVoidCommitted(int transactionNumber, SqlCommand cmd)
  {
  }

  protected virtual void BeforeVoidCommitted(int transactionNumber, int voidingTransactionNumber)
  {
  }
}
