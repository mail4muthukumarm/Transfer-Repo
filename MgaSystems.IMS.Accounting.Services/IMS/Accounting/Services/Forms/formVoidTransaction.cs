// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.Forms.formVoidTransaction
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.Forms;

[SecureResource("{1A4F865E-ABC2-47c1-A976-77B4348F33F3}", "Void Accounting Transaction", "Determines whether a user has rights to void an accounting transaction.", "Accounting")]
public class formVoidTransaction : Form
{
  public const string VOIDTRANSACTIONRIGHTS = "{1A4F865E-ABC2-47c1-A976-77B4348F33F3}";
  private Panel panel1;
  private MGAButton buttonSave;
  private MGAButton buttonCancel;
  private Label label1;
  private Label label2;
  private MGADateTimePicker dateTimePostDate;
  private System.ComponentModel.Container components;
  protected const int CommandTimeout = 300;

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
    this.panel1 = new Panel();
    this.label2 = new Label();
    this.label1 = new Label();
    this.dateTimePostDate = new MGADateTimePicker();
    this.buttonCancel = new MGAButton();
    this.buttonSave = new MGAButton();
    this.panel1.SuspendLayout();
    ((ISupportInitialize) this.dateTimePostDate).BeginInit();
    ((ISupportInitialize) this.buttonCancel).BeginInit();
    ((ISupportInitialize) this.buttonSave).BeginInit();
    this.SuspendLayout();
    this.panel1.BackColor = Color.FromArgb(239, 247, 253);
    this.panel1.Controls.Add((Control) this.label2);
    this.panel1.Controls.Add((Control) this.label1);
    this.panel1.Controls.Add((Control) this.dateTimePostDate);
    this.panel1.Controls.Add((Control) this.buttonCancel);
    this.panel1.Controls.Add((Control) this.buttonSave);
    this.panel1.Location = new Point(8, 8);
    this.panel1.Name = "panel1";
    this.panel1.Size = new Size(352, 104);
    this.panel1.TabIndex = 0;
    this.label2.AutoSize = true;
    this.label2.Location = new Point(8, 32 /*0x20*/);
    this.label2.Name = "label2";
    this.label2.Size = new Size(115, 16 /*0x10*/);
    this.label2.TabIndex = 4;
    this.label2.Text = "Void Transaction Date:";
    this.label1.Location = new Point(8, 8);
    this.label1.Name = "label1";
    this.label1.Size = new Size(296, 23);
    this.label1.TabIndex = 3;
    this.label1.Text = "Do you wish to permanently void the specified transaction?";
    ((AppearanceBase) appearance1).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dateTimePostDate.Appearance = (AppearanceBase) appearance1;
    ((AppearanceBase) appearance2).AlphaLevel = (short) 14;
    ((AppearanceBase) appearance2).BackColor = Color.FromArgb(0, 0, 246, 253);
    ((AppearanceBase) appearance2).BackColor2 = Color.FromArgb(133, 162, 221);
    ((AppearanceBase) appearance2).BackColorAlpha = (Alpha) 2;
    ((AppearanceBase) appearance2).BackGradientAlignment = (GradientAlignment) 4;
    ((AppearanceBase) appearance2).BackGradientStyle = (GradientStyle) 5;
    ((AppearanceBase) appearance2).BorderAlpha = (Alpha) 1;
    ((AppearanceBase) appearance2).BorderColor = Color.FromArgb(78, 122, 171);
    ((AppearanceBase) appearance2).ForeColor = Color.FromArgb(49, 85, 153);
    ((AppearanceBase) appearance2).ForegroundAlpha = (Alpha) 2;
    this.dateTimePostDate.ButtonAppearance = (AppearanceBase) appearance2;
    this.dateTimePostDate.FormatString = "D";
    ((Control) this.dateTimePostDate).Location = new Point(136, 32 /*0x20*/);
    this.dateTimePostDate.MGAStyle = MGAStyles.Blue;
    ((Control) this.dateTimePostDate).Name = "dateTimePostDate";
    ((Control) this.dateTimePostDate).Size = new Size(208 /*0xD0*/, 20);
    ((Control) this.dateTimePostDate).TabIndex = 2;
    ((AppearanceBase) appearance3).BackColor = Color.Gainsboro;
    ((AppearanceBase) appearance3).BackColor2 = Color.White;
    ((AppearanceBase) appearance3).BackGradientStyle = (GradientStyle) 2;
    ((ControlBase) this.buttonCancel).Appearance = (AppearanceBase) appearance3;
    ((Control) this.buttonCancel).Location = new Point(240 /*0xF0*/, 72);
    ((Control) this.buttonCancel).Name = "buttonCancel";
    ((Control) this.buttonCancel).Size = new Size(104, 24);
    ((Control) this.buttonCancel).TabIndex = 1;
    ((Control) this.buttonCancel).Text = "Cancel";
    ((Control) this.buttonCancel).Click += new EventHandler(this.buttonCancel_Click);
    ((AppearanceBase) appearance4).BackColor = Color.Gainsboro;
    ((AppearanceBase) appearance4).BackColor2 = Color.White;
    ((AppearanceBase) appearance4).BackGradientStyle = (GradientStyle) 2;
    ((ControlBase) this.buttonSave).Appearance = (AppearanceBase) appearance4;
    ((Control) this.buttonSave).Location = new Point(120, 72);
    ((Control) this.buttonSave).Name = "buttonSave";
    ((Control) this.buttonSave).Size = new Size(104, 24);
    ((Control) this.buttonSave).TabIndex = 0;
    ((Control) this.buttonSave).Text = "Void Transaction";
    ((Control) this.buttonSave).Click += new EventHandler(this.buttonSave_Click);
    this.AutoScaleBaseSize = new Size(5, 13);
    this.BackColor = Color.White;
    this.ClientSize = new Size(370, 118);
    this.ControlBox = false;
    this.Controls.Add((Control) this.panel1);
    this.Font = new Font("Tahoma", 8f);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.Name = nameof (formVoidTransaction);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Permanently Void Transaction?";
    this.panel1.ResumeLayout(false);
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

  protected virtual void VoidJournalTransaction(int transactionNumber, DateTime postDate)
  {
    DefaultDatabase.ExecuteTransaction((EventHandler<ExecuteTransactionEventArgs>) ((s, evt) =>
    {
      List<object> objectList = new List<object>()
      {
        (object) "@TRANSACTNUM_VOIDEE",
        (object) transactionNumber,
        (object) "@USERGUID",
        (object) CurrentUser.Instance.UserGUID,
        (object) "@POSTDATE",
        (object) postDate
      };
      int voidingTransactNum = DefaultDatabase.ExecuteScalar<int>(CommandType.StoredProcedure, "dbo.spFin_VoidJournalTransaction", 300, (CommandArgumentType) 0, objectList.ToArray());
      DefaultDatabase.ExecuteNonQuery(CommandType.StoredProcedure, "dbo.spFin_VoidLinkedManualEntries", 300, (CommandArgumentType) 0, objectList.ToArray());
      DefaultDatabase.ExecuteNonQuery(CommandType.StoredProcedure, "dbo.spFin_VoidAppliedUnAccountedLinkedTransactions", 300, (CommandArgumentType) 0, objectList.ToArray());
      DefaultDatabase.ExecuteNonQuery(CommandType.StoredProcedure, "dbo.spFin_VoidLinkedCommissionTransactions", 300, (CommandArgumentType) 0, objectList.ToArray());
      DefaultDatabase.ExecuteNonQuery(CommandType.StoredProcedure, "dbo.spFin_VoidLinkedTransactionReference", 300, (CommandArgumentType) 0, objectList.ToArray());
      this.OnSaveVoidingTransaction(voidingTransactNum);
      CurrentUser.Instance.LogAction($"Voided transaction #{transactionNumber}", "Accounting Logs");
      evt.Transaction.Commit();
    }));
  }

  protected virtual void OnSaveVoidingTransaction(int voidingTransactNum)
  {
  }

  private void buttonSave_Click(object sender, EventArgs e)
  {
    if (this.dateTimePostDate.Value == null)
    {
      int num = (int) MessageBox.Show("You must select a post date to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else
    {
      this.VoidJournalTransaction(this.TransactionNumber, this.dateTimePostDate.DateTime);
      this.DialogResult = DialogResult.OK;
      this.Close();
    }
  }
}
