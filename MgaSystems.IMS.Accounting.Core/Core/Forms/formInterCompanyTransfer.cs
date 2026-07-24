// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.Forms.formInterCompanyTransfer
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using MGASystems.IMS.Accounting.Controls;
using MGASystems.IMS.Accounting.Core.ClassObjects;
using MGASystems.IMS.Accounting.Services;
using MGASystems.Tools;
using Microsoft.VisualBasic;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.Forms;

public class formInterCompanyTransfer : AccountingNoteDocumentSupport
{
  private EllipsePanel ellipsePanel1;
  private ExtendedTreeViewDropDown dropTreeGLAccounts;
  private Label labelGLAccount;
  private MGATextBox textComments;
  private MGATextBox textAmount;
  private Label label1;
  private Label label2;
  private EllipsePanel ellipsePanel2;
  private MGAButton buttonCancel;
  private MGAButton buttonSave;
  private System.ComponentModel.Container components;
  private int _glCompanyId;
  private int replacementIndex;
  private int glAccountId;
  private string glAccountShortName;
  private string postingComments;
  private Decimal amount;

  public formInterCompanyTransfer(int glCompanyId)
  {
    this.InitializeComponent();
    this._glCompanyId = glCompanyId;
    this.dropTreeGLAccounts.LoadGLAccounts(this._glCompanyId);
  }

  public formInterCompanyTransfer(
    int glCompanyId,
    InterCompanyTransfer transferObject,
    int replacementIndex)
  {
    this.InitializeComponent();
    this._glCompanyId = glCompanyId;
    this.replacementIndex = replacementIndex;
    this.dropTreeGLAccounts.LoadGLAccounts(this._glCompanyId);
    this.glAccountId = transferObject.GlAccountId;
    this.glAccountShortName = transferObject.GlAccountShortName;
    this.amount = transferObject.Amount;
    this.postingComments = transferObject.Comments;
    this.DisplayTransfer();
  }

  public int GlAccountId => this.glAccountId;

  public string GlAccountShortName => this.glAccountShortName;

  public string PostingComments => this.postingComments;

  public Decimal Amount => this.amount;

  public int ReplacementIndex => this.replacementIndex;

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
    this.ellipsePanel1 = new EllipsePanel();
    this.label2 = new Label();
    this.label1 = new Label();
    this.textAmount = new MGATextBox();
    this.textComments = new MGATextBox();
    this.labelGLAccount = new Label();
    this.dropTreeGLAccounts = new ExtendedTreeViewDropDown();
    this.ellipsePanel2 = new EllipsePanel();
    this.buttonCancel = new MGAButton();
    this.buttonSave = new MGAButton();
    this.ellipsePanel1.SuspendLayout();
    ((ISupportInitialize) this.textAmount).BeginInit();
    ((ISupportInitialize) this.textComments).BeginInit();
    this.ellipsePanel2.SuspendLayout();
    ((ISupportInitialize) this.buttonCancel).BeginInit();
    ((ISupportInitialize) this.buttonSave).BeginInit();
    this.SuspendLayout();
    this.ellipsePanel1.BackColor = Color.FromArgb(239, 247, 253);
    this.ellipsePanel1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.ellipsePanel1.Controls.Add((Control) this.label2);
    this.ellipsePanel1.Controls.Add((Control) this.label1);
    this.ellipsePanel1.Controls.Add((Control) this.textAmount);
    this.ellipsePanel1.Controls.Add((Control) this.textComments);
    this.ellipsePanel1.Controls.Add((Control) this.labelGLAccount);
    this.ellipsePanel1.Controls.Add((Control) this.dropTreeGLAccounts);
    this.ellipsePanel1.CornerOffset = 1;
    this.ellipsePanel1.Location = new Point(8, 8);
    this.ellipsePanel1.Name = "ellipsePanel1";
    this.ellipsePanel1.Size = new Size(288, 152);
    this.ellipsePanel1.TabIndex = 0;
    this.label2.AutoSize = true;
    this.label2.Location = new Point(8, 120);
    this.label2.Name = "label2";
    this.label2.Size = new Size(46, 16 /*0x10*/);
    this.label2.TabIndex = 4;
    this.label2.Text = "Amount:";
    this.label1.AutoSize = true;
    this.label1.Location = new Point(8, 32 /*0x20*/);
    this.label1.Name = "label1";
    this.label1.Size = new Size(59, 16 /*0x10*/);
    this.label1.TabIndex = 2;
    this.label1.Text = "Comments:";
    ((AppearanceBase) appearance1).BackColor = Color.White;
    ((AppearanceBase) appearance1).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance1).ForeColor = Color.Black;
    ((AppearanceBase) appearance1).TextHAlign = (HAlign) 3;
    ((TextEditorControlBase) this.textAmount).Appearance = (AppearanceBase) appearance1;
    ((Control) this.textAmount).Location = new Point(72, 120);
    ((TextEditorControlBase) this.textAmount).MaxLength = 50;
    this.textAmount.MGAStyle = MGAStyles.Blue;
    ((Control) this.textAmount).Name = "textAmount";
    ((Control) this.textAmount).Size = new Size(208 /*0xD0*/, 20);
    ((Control) this.textAmount).TabIndex = 5;
    ((Control) this.textAmount).Validating += new CancelEventHandler(this.textAmount_Validating);
    ((AppearanceBase) appearance2).BackColor = Color.White;
    ((AppearanceBase) appearance2).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance2).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textComments).Appearance = (AppearanceBase) appearance2;
    ((Control) this.textComments).Location = new Point(72, 32 /*0x20*/);
    ((TextEditorControlBase) this.textComments).MaxLength = 2000;
    this.textComments.MGAStyle = MGAStyles.Blue;
    this.textComments.Multiline = true;
    ((Control) this.textComments).Name = "textComments";
    ((Control) this.textComments).Size = new Size(208 /*0xD0*/, 84);
    ((Control) this.textComments).TabIndex = 3;
    this.labelGLAccount.AutoSize = true;
    this.labelGLAccount.Location = new Point(8, 8);
    this.labelGLAccount.Name = "labelGLAccount";
    this.labelGLAccount.Size = new Size(63 /*0x3F*/, 16 /*0x10*/);
    this.labelGLAccount.TabIndex = 0;
    this.labelGLAccount.Text = "GL Account:";
    this.dropTreeGLAccounts.DropDownHeight = 300;
    this.dropTreeGLAccounts.DropDownWidth = 300;
    this.dropTreeGLAccounts.Location = new Point(72, 8);
    this.dropTreeGLAccounts.Name = "dropTreeGLAccounts";
    this.dropTreeGLAccounts.ShowAssetAccounts = ExtendedTreeViewDropDown.Assets.All;
    this.dropTreeGLAccounts.ShowEquityAccounts = true;
    this.dropTreeGLAccounts.ShowExpenseAccounts = true;
    this.dropTreeGLAccounts.ShowIncomeAccounts = true;
    this.dropTreeGLAccounts.ShowLiabilityAccounts = ExtendedTreeViewDropDown.Liabilities.All;
    this.dropTreeGLAccounts.ShowSystemDefinedAccounts = true;
    this.dropTreeGLAccounts.Size = new Size(208 /*0xD0*/, 20);
    this.dropTreeGLAccounts.TabIndex = 1;
    this.dropTreeGLAccounts.UseCheckedStateSelectionOverride = false;
    this.ellipsePanel2.BackColor = Color.FromArgb(239, 247, 253);
    this.ellipsePanel2.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.ellipsePanel2.Controls.Add((Control) this.buttonCancel);
    this.ellipsePanel2.Controls.Add((Control) this.buttonSave);
    this.ellipsePanel2.CornerOffset = 1;
    this.ellipsePanel2.Location = new Point(8, 168);
    this.ellipsePanel2.Name = "ellipsePanel2";
    this.ellipsePanel2.Size = new Size(288, 40);
    this.ellipsePanel2.TabIndex = 1;
    ((AppearanceBase) appearance3).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance3).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance3).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance3).BorderColor = Color.DarkGray;
    ((ControlBase) this.buttonCancel).Appearance = (AppearanceBase) appearance3;
    ((UltraButtonBase) this.buttonCancel).DialogResult = DialogResult.Cancel;
    ((Control) this.buttonCancel).Location = new Point(184, 8);
    ((Control) this.buttonCancel).Name = "buttonCancel";
    ((Control) this.buttonCancel).Size = new Size(96 /*0x60*/, 24);
    ((Control) this.buttonCancel).TabIndex = 1;
    ((Control) this.buttonCancel).Text = "&Cancel";
    ((Control) this.buttonCancel).Click += new EventHandler(this.buttonCancel_Click);
    ((AppearanceBase) appearance4).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance4).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance4).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance4).BorderColor = Color.DarkGray;
    ((ControlBase) this.buttonSave).Appearance = (AppearanceBase) appearance4;
    ((Control) this.buttonSave).Location = new Point(80 /*0x50*/, 8);
    ((Control) this.buttonSave).Name = "buttonSave";
    ((Control) this.buttonSave).Size = new Size(96 /*0x60*/, 24);
    ((Control) this.buttonSave).TabIndex = 0;
    ((Control) this.buttonSave).Text = "&Save";
    ((Control) this.buttonSave).Click += new EventHandler(this.buttonSave_Click);
    this.AcceptButton = (IButtonControl) this.buttonSave;
    this.AutoScaleBaseSize = new Size(5, 13);
    this.BackColor = Color.White;
    this.CancelButton = (IButtonControl) this.buttonCancel;
    this.ClientSize = new Size(304, 214);
    this.ControlBox = false;
    this.Controls.Add((Control) this.ellipsePanel2);
    this.Controls.Add((Control) this.ellipsePanel1);
    this.Font = new Font("Tahoma", 8f);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.Name = nameof (formInterCompanyTransfer);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Inter-Company Transfer / Additional Offset";
    this.ellipsePanel1.ResumeLayout(false);
    ((ISupportInitialize) this.textAmount).EndInit();
    ((ISupportInitialize) this.textComments).EndInit();
    this.ellipsePanel2.ResumeLayout(false);
    ((ISupportInitialize) this.buttonCancel).EndInit();
    ((ISupportInitialize) this.buttonSave).EndInit();
    this.ResumeLayout(false);
  }

  private bool ValidateForm()
  {
    if (this.dropTreeGLAccounts.GLAccountID == -1 || this.dropTreeGLAccounts.GLAccountID == 0)
    {
      int num = (int) MessageBox.Show("You must select a GL Account to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (((Control) this.textAmount).Text == string.Empty || ((Control) this.textAmount).Text.Length == 0)
    {
      int num = (int) MessageBox.Show("You must enter an amount to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (Information.IsNumeric((object) ((Control) this.textAmount).Text))
      return true;
    int num1 = (int) MessageBox.Show("Amount must be numeric.", "Invalid Entry!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    return false;
  }

  private void SetProperties()
  {
    this.glAccountId = this.dropTreeGLAccounts.GLAccountID;
    this.glAccountShortName = this.dropTreeGLAccounts.GLAccountShortName;
    this.postingComments = ((Control) this.textComments).Text;
    this.amount = Decimal.Parse(((Control) this.textAmount).Text, NumberStyles.Currency);
  }

  private void buttonCancel_Click(object sender, EventArgs e)
  {
    this.DialogResult = DialogResult.Cancel;
    this.Close();
  }

  private void buttonSave_Click(object sender, EventArgs e)
  {
    if (!this.ValidateForm())
      return;
    this.SetProperties();
    this.DialogResult = DialogResult.OK;
    this.Close();
  }

  private void DisplayTransfer()
  {
    this.dropTreeGLAccounts.SetSelectedNodeByKey(this.glAccountId.ToString());
    ((Control) this.textComments).Text = this.postingComments;
    ((Control) this.textAmount).Text = this.amount.ToString("c");
  }

  private void textAmount_Validating(object sender, CancelEventArgs e)
  {
    if (!Information.IsNumeric((object) ((Control) this.textAmount).Text))
      return;
    try
    {
      ((Control) this.textAmount).Text = Decimal.Parse(((Control) this.textAmount).Text).ToString("c");
    }
    catch (FormatException ex)
    {
      e.Cancel = true;
    }
  }
}
