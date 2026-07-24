// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.Forms.formChangeTransactionDate
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.Forms;

public class formChangeTransactionDate : Form
{
  private Label label1;
  private MGAButton buttonOk;
  private MGAButton buttonCancel;
  private Panel panelLoading;
  private Panel panel2;
  private System.ComponentModel.Container components;
  private MGADateTimePicker dateTimeNewDate;
  private int _transactionNumber;
  private DateTime newDate;

  public formChangeTransactionDate(int transactionNumber)
  {
    this.InitializeComponent();
    this._transactionNumber = transactionNumber;
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
    this.label1 = new Label();
    this.buttonOk = new MGAButton();
    this.buttonCancel = new MGAButton();
    this.dateTimeNewDate = new MGADateTimePicker();
    this.panelLoading = new Panel();
    this.panel2 = new Panel();
    ((ISupportInitialize) this.buttonOk).BeginInit();
    ((ISupportInitialize) this.buttonCancel).BeginInit();
    ((ISupportInitialize) this.dateTimeNewDate).BeginInit();
    this.panelLoading.SuspendLayout();
    this.panel2.SuspendLayout();
    this.SuspendLayout();
    this.label1.AutoSize = true;
    this.label1.Location = new Point(8, 12);
    this.label1.Name = "label1";
    this.label1.Size = new Size(88, 16 /*0x10*/);
    this.label1.TabIndex = 0;
    this.label1.Text = "Select New Date:";
    ((AppearanceBase) appearance1).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance1).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance1).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance1).BorderColor = Color.DarkGray;
    ((ControlBase) this.buttonOk).Appearance = (AppearanceBase) appearance1;
    ((Control) this.buttonOk).Location = new Point(32 /*0x20*/, 40);
    ((Control) this.buttonOk).Name = "buttonOk";
    ((Control) this.buttonOk).Size = new Size(80 /*0x50*/, 24);
    ((Control) this.buttonOk).TabIndex = 2;
    ((Control) this.buttonOk).Text = "Ok";
    ((Control) this.buttonOk).Click += new EventHandler(this.buttonOk_Click);
    ((AppearanceBase) appearance2).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance2).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance2).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance2).BorderColor = Color.DarkGray;
    ((ControlBase) this.buttonCancel).Appearance = (AppearanceBase) appearance2;
    ((UltraButtonBase) this.buttonCancel).DialogResult = DialogResult.Cancel;
    ((Control) this.buttonCancel).Location = new Point(120, 40);
    ((Control) this.buttonCancel).Name = "buttonCancel";
    ((Control) this.buttonCancel).Size = new Size(80 /*0x50*/, 24);
    ((Control) this.buttonCancel).TabIndex = 3;
    ((Control) this.buttonCancel).Text = "Cancel";
    ((Control) this.buttonCancel).Click += new EventHandler(this.buttonCancel_Click);
    ((AppearanceBase) appearance3).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dateTimeNewDate.Appearance = (AppearanceBase) appearance3;
    ((AppearanceBase) appearance4).AlphaLevel = (short) 14;
    ((AppearanceBase) appearance4).BackColor = Color.FromArgb(0, 0, 246, 253);
    ((AppearanceBase) appearance4).BackColor2 = Color.FromArgb(133, 162, 221);
    ((AppearanceBase) appearance4).BackColorAlpha = (Alpha) 2;
    ((AppearanceBase) appearance4).BackGradientAlignment = (GradientAlignment) 4;
    ((AppearanceBase) appearance4).BackGradientStyle = (GradientStyle) 5;
    ((AppearanceBase) appearance4).BorderAlpha = (Alpha) 1;
    ((AppearanceBase) appearance4).BorderColor = Color.FromArgb(78, 122, 171);
    ((AppearanceBase) appearance4).ForeColor = Color.FromArgb(49, 85, 153);
    ((AppearanceBase) appearance4).ForegroundAlpha = (Alpha) 2;
    this.dateTimeNewDate.ButtonAppearance = (AppearanceBase) appearance4;
    ((Control) this.dateTimeNewDate).Location = new Point(104, 8);
    this.dateTimeNewDate.MGAStyle = MGAStyles.Blue;
    ((Control) this.dateTimeNewDate).Name = "dateTimeNewDate";
    ((Control) this.dateTimeNewDate).Size = new Size(96 /*0x60*/, 20);
    ((Control) this.dateTimeNewDate).TabIndex = 1;
    this.panelLoading.Controls.Add((Control) this.panel2);
    this.panelLoading.Dock = DockStyle.Fill;
    this.panelLoading.Location = new Point(0, 0);
    this.panelLoading.Name = "panelLoading";
    this.panelLoading.Size = new Size(226, 88);
    this.panelLoading.TabIndex = 0;
    this.panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.panel2.BackColor = Color.FromArgb(239, 247, 253);
    this.panel2.Controls.Add((Control) this.buttonCancel);
    this.panel2.Controls.Add((Control) this.dateTimeNewDate);
    this.panel2.Controls.Add((Control) this.buttonOk);
    this.panel2.Controls.Add((Control) this.label1);
    this.panel2.Location = new Point(8, 8);
    this.panel2.Name = "panel2";
    this.panel2.Size = new Size(210, 72);
    this.panel2.TabIndex = 0;
    this.AcceptButton = (IButtonControl) this.buttonOk;
    this.AutoScaleBaseSize = new Size(5, 13);
    this.BackColor = Color.White;
    this.CancelButton = (IButtonControl) this.buttonCancel;
    this.ClientSize = new Size(226, 88);
    this.ControlBox = false;
    this.Controls.Add((Control) this.panelLoading);
    this.Font = new Font("Tahoma", 8f);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.Name = nameof (formChangeTransactionDate);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Change Transaction Date";
    ((ISupportInitialize) this.buttonOk).EndInit();
    ((ISupportInitialize) this.buttonCancel).EndInit();
    ((ISupportInitialize) this.dateTimeNewDate).EndInit();
    this.panelLoading.ResumeLayout(false);
    this.panel2.ResumeLayout(false);
    this.ResumeLayout(false);
  }

  public DateTime NewDate => this.newDate;

  private void buttonOk_Click(object sender, EventArgs e)
  {
    if (this.dateTimeNewDate.Value == null || MessageBox.Show("This will permanently change the transaction date, continue?", "Permanently Change Transaction?", MessageBoxButtons.OK, MessageBoxIcon.Question) != DialogResult.OK)
      return;
    this.ChangeDate();
  }

  private void buttonCancel_Click(object sender, EventArgs e)
  {
    this.DialogResult = DialogResult.Cancel;
    this.Close();
  }

  private void ChangeDate()
  {
    DefaultDatabase.ExecuteNonQuery("spFin_ChangePostDate", new object[4]
    {
      (object) "@transactNum",
      (object) this._transactionNumber,
      (object) "@newDate",
      (object) this.dateTimeNewDate.DateTime
    });
    StringBuilder stringBuilder = new StringBuilder();
    stringBuilder.Append("Changed the post date on transaction ");
    stringBuilder.Append(this._transactionNumber.ToString());
    stringBuilder.Append(" from ");
    stringBuilder.Append(this.GetCurrentTransactionDate().ToShortDateString());
    stringBuilder.Append(" to ");
    stringBuilder.Append(this.dateTimeNewDate.DateTime.ToShortDateString());
    stringBuilder.Append(".");
    CurrentUser.Instance.LogAction(stringBuilder.ToString(), "Accounting Logs");
    this.newDate = this.dateTimeNewDate.DateTime;
    this.DialogResult = DialogResult.OK;
    this.Close();
  }

  private DateTime GetCurrentTransactionDate()
  {
    return (DateTime) DefaultDatabase.ExecuteScalar("spFin_GetTransactionPostDate", new object[2]
    {
      (object) "@TransactionNumber",
      (object) this._transactionNumber
    });
  }
}
