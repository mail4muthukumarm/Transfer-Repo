// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Banking.formBankRecInputs
// Assembly: MgaSystems.IMS.Accounting.Banking, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: ED5B99DC-3DD2-44AB-BA36-49A11A94937D
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Banking.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Banking;

public class formBankRecInputs : Form
{
  private IContainer components;
  private int _bankGLAccountID;
  private Decimal _endingBalance;
  private DateTime _periodDate;

  public formBankRecInputs() => this.InitializeComponent();

  public formBankRecInputs(int bankGLAccountId)
  {
    this.InitializeComponent();
    this._bankGLAccountID = bankGLAccountId;
  }

  public formBankRecInputs(int bankGLAccountId, DateTime periodDate)
  {
    this.InitializeComponent();
    this._bankGLAccountID = bankGLAccountId;
    this.dateTimePeriodDate.Value = (object) periodDate;
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [field: AccessedThroughProperty("EllipsePanel1")]
  internal virtual EllipsePanel EllipsePanel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label2")]
  internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label3")]
  internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label4")]
  internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("textEndingBalance")]
  internal virtual MGATextBox textEndingBalance { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Panel1")]
  internal virtual Panel Panel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGAButton buttonReconcile
  {
    get => this._buttonReconcile;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.buttonReconcile_Click);
      MGAButton buttonReconcile1 = this._buttonReconcile;
      if (buttonReconcile1 != null)
        ((Control) buttonReconcile1).Click -= eventHandler;
      this._buttonReconcile = value;
      MGAButton buttonReconcile2 = this._buttonReconcile;
      if (buttonReconcile2 == null)
        return;
      ((Control) buttonReconcile2).Click += eventHandler;
    }
  }

  internal virtual MGAButton buttonCancel
  {
    get => this._buttonCancel;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.buttonCancel_Click);
      MGAButton buttonCancel1 = this._buttonCancel;
      if (buttonCancel1 != null)
        ((Control) buttonCancel1).Click -= eventHandler;
      this._buttonCancel = value;
      MGAButton buttonCancel2 = this._buttonCancel;
      if (buttonCancel2 == null)
        return;
      ((Control) buttonCancel2).Click += eventHandler;
    }
  }

  internal virtual MGADateTimePicker dateTimePeriodDate
  {
    get => this._dateTimePeriodDate;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.dateTimePeriodDate_ValueChanged);
      CancelEventHandler cancelEventHandler = new CancelEventHandler(this.dateTimePeriodDate_Validating);
      MGADateTimePicker dateTimePeriodDate1 = this._dateTimePeriodDate;
      if (dateTimePeriodDate1 != null)
      {
        dateTimePeriodDate1.ValueChanged -= eventHandler;
        ((Control) dateTimePeriodDate1).Validating -= cancelEventHandler;
      }
      this._dateTimePeriodDate = value;
      MGADateTimePicker dateTimePeriodDate2 = this._dateTimePeriodDate;
      if (dateTimePeriodDate2 == null)
        return;
      dateTimePeriodDate2.ValueChanged += eventHandler;
      ((Control) dateTimePeriodDate2).Validating += cancelEventHandler;
    }
  }

  [field: AccessedThroughProperty("textStartingBalance")]
  internal virtual MGATextBox textStartingBalance { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label5")]
  internal virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    this.EllipsePanel1 = new EllipsePanel();
    this.Label2 = new Label();
    this.Label1 = new Label();
    this.Label3 = new Label();
    this.dateTimePeriodDate = new MGADateTimePicker();
    this.Label4 = new Label();
    this.textEndingBalance = new MGATextBox();
    this.Panel1 = new Panel();
    this.buttonReconcile = new MGAButton();
    this.buttonCancel = new MGAButton();
    this.textStartingBalance = new MGATextBox();
    this.Label5 = new Label();
    this.EllipsePanel1.SuspendLayout();
    ((ISupportInitialize) this.dateTimePeriodDate).BeginInit();
    ((ISupportInitialize) this.textEndingBalance).BeginInit();
    this.Panel1.SuspendLayout();
    ((ISupportInitialize) this.buttonReconcile).BeginInit();
    ((ISupportInitialize) this.buttonCancel).BeginInit();
    ((ISupportInitialize) this.textStartingBalance).BeginInit();
    this.SuspendLayout();
    this.EllipsePanel1.BackColor = Color.WhiteSmoke;
    this.EllipsePanel1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.EllipsePanel1.Controls.Add((Control) this.Label2);
    this.EllipsePanel1.Controls.Add((Control) this.Label1);
    this.EllipsePanel1.CornerOffset = 1;
    this.EllipsePanel1.Dock = DockStyle.Top;
    this.EllipsePanel1.Location = new Point(0, 0);
    this.EllipsePanel1.Name = "EllipsePanel1";
    this.EllipsePanel1.Size = new Size(464, 48 /*0x30*/);
    this.EllipsePanel1.TabIndex = 0;
    this.Label2.Location = new Point(16 /*0x10*/, 24);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(440, 16 /*0x10*/);
    this.Label2.TabIndex = 1;
    this.Label2.Text = "Please enter the information on your paper statement for the bank you wish to reconcile.";
    this.Label1.AutoSize = true;
    this.Label1.Font = new Font("Tahoma", 8f, FontStyle.Bold);
    this.Label1.ForeColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.Label1.Location = new Point(16 /*0x10*/, 8);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(110, 13);
    this.Label1.TabIndex = 0;
    this.Label1.Text = "Reconcile Account";
    this.Label3.AutoSize = true;
    this.Label3.Location = new Point(112 /*0x70*/, 80 /*0x50*/);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(87, 13);
    this.Label3.TabIndex = 1;
    this.Label3.Text = "Statement Date:";
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dateTimePeriodDate.Appearance = (AppearanceBase) appearance1;
    appearance2.AlphaLevel = (short) 14;
    appearance2.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance2.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance2.BackColorAlpha = (Alpha) 2;
    appearance2.BackGradientAlignment = (GradientAlignment) 4;
    appearance2.BackGradientStyle = (GradientStyle) 5;
    appearance2.BorderAlpha = (Alpha) 1;
    appearance2.BorderColor = Color.FromArgb(78, 122, 171);
    appearance2.ForeColor = Color.FromArgb(49, 85, 153);
    appearance2.ForegroundAlpha = (Alpha) 2;
    this.dateTimePeriodDate.ButtonAppearance = (AppearanceBase) appearance2;
    ((Control) this.dateTimePeriodDate).Location = new Point(208 /*0xD0*/, 80 /*0x50*/);
    this.dateTimePeriodDate.MGAStyle = MGAStyles.Blue;
    ((Control) this.dateTimePeriodDate).Name = "dateTimePeriodDate";
    ((Control) this.dateTimePeriodDate).Size = new Size(136, 20);
    ((Control) this.dateTimePeriodDate).TabIndex = 2;
    ((UltraControlBase) this.dateTimePeriodDate).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dateTimePeriodDate).UseOsThemes = (DefaultableBoolean) 2;
    this.Label4.AutoSize = true;
    this.Label4.Location = new Point(112 /*0x70*/, 128 /*0x80*/);
    this.Label4.Name = "Label4";
    this.Label4.Size = new Size(83, 13);
    this.Label4.TabIndex = 3;
    this.Label4.Text = "Ending Balance:";
    appearance3.BackColor = Color.White;
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance3.ForeColor = Color.Black;
    ((AppearanceBase) appearance3).TextHAlignAsString = "Right";
    ((TextEditorControlBase) this.textEndingBalance).Appearance = (AppearanceBase) appearance3;
    ((TextEditorControlBase) this.textEndingBalance).BackColor = Color.White;
    ((Control) this.textEndingBalance).Location = new Point(208 /*0xD0*/, 128 /*0x80*/);
    this.textEndingBalance.MGAStyle = MGAStyles.Blue;
    ((Control) this.textEndingBalance).Name = "textEndingBalance";
    ((Control) this.textEndingBalance).Size = new Size(136, 20);
    ((Control) this.textEndingBalance).TabIndex = 4;
    ((UltraControlBase) this.textEndingBalance).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textEndingBalance).UseOsThemes = (DefaultableBoolean) 2;
    this.Panel1.BackColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.Panel1.Controls.Add((Control) this.buttonReconcile);
    this.Panel1.Controls.Add((Control) this.buttonCancel);
    this.Panel1.Dock = DockStyle.Bottom;
    this.Panel1.Location = new Point(0, 182);
    this.Panel1.Name = "Panel1";
    this.Panel1.Size = new Size(464, 40);
    this.Panel1.TabIndex = 5;
    ((Control) this.buttonReconcile).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
    appearance4.BackColor = Color.FromArgb(248, 248, 248);
    appearance4.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance4.BackGradientStyle = (GradientStyle) 2;
    appearance4.BorderColor = Color.DarkGray;
    appearance4.ImageHAlign = (HAlign) 2;
    appearance4.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonReconcile).Appearance = (AppearanceBase) appearance4;
    ((Control) this.buttonReconcile).Location = new Point(240 /*0xF0*/, 8);
    ((Control) this.buttonReconcile).Name = "buttonReconcile";
    ((Control) this.buttonReconcile).Size = new Size(112 /*0x70*/, 24);
    ((Control) this.buttonReconcile).TabIndex = 0;
    ((ControlBase) this.buttonReconcile).Text = "Reconcile";
    this.buttonReconcile.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonCancel).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
    appearance5.BackColor = Color.FromArgb(248, 248, 248);
    appearance5.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance5.BackGradientStyle = (GradientStyle) 2;
    appearance5.BorderColor = Color.DarkGray;
    appearance5.ImageHAlign = (HAlign) 2;
    appearance5.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonCancel).Appearance = (AppearanceBase) appearance5;
    ((Control) this.buttonCancel).Location = new Point(360, 8);
    ((Control) this.buttonCancel).Name = "buttonCancel";
    ((Control) this.buttonCancel).Size = new Size(96 /*0x60*/, 24);
    ((Control) this.buttonCancel).TabIndex = 1;
    ((ControlBase) this.buttonCancel).Text = "Cancel";
    this.buttonCancel.UseOSThemes = (DefaultableBoolean) 2;
    appearance6.BackColor = Color.White;
    appearance6.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance6.ForeColor = Color.Black;
    ((AppearanceBase) appearance6).TextHAlignAsString = "Right";
    ((TextEditorControlBase) this.textStartingBalance).Appearance = (AppearanceBase) appearance6;
    ((TextEditorControlBase) this.textStartingBalance).BackColor = Color.White;
    ((Control) this.textStartingBalance).Enabled = false;
    ((Control) this.textStartingBalance).Location = new Point(208 /*0xD0*/, 104);
    this.textStartingBalance.MGAStyle = MGAStyles.Blue;
    ((Control) this.textStartingBalance).Name = "textStartingBalance";
    ((Control) this.textStartingBalance).Size = new Size(136, 20);
    ((Control) this.textStartingBalance).TabIndex = 7;
    ((UltraControlBase) this.textStartingBalance).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textStartingBalance).UseOsThemes = (DefaultableBoolean) 2;
    this.Label5.AutoSize = true;
    this.Label5.Location = new Point(112 /*0x70*/, 104);
    this.Label5.Name = "Label5";
    this.Label5.Size = new Size(89, 13);
    this.Label5.TabIndex = 6;
    this.Label5.Text = "Starting Balance:";
    this.AutoScaleBaseSize = new Size(5, 13);
    this.BackColor = Color.White;
    this.ClientSize = new Size(464, 222);
    this.ControlBox = false;
    this.Controls.Add((Control) this.textStartingBalance);
    this.Controls.Add((Control) this.Label5);
    this.Controls.Add((Control) this.Panel1);
    this.Controls.Add((Control) this.textEndingBalance);
    this.Controls.Add((Control) this.Label4);
    this.Controls.Add((Control) this.dateTimePeriodDate);
    this.Controls.Add((Control) this.Label3);
    this.Controls.Add((Control) this.EllipsePanel1);
    this.Font = new Font("Tahoma", 8f);
    this.ForeColor = Color.Black;
    this.Name = nameof (formBankRecInputs);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Bank Account Reconciliation";
    this.EllipsePanel1.ResumeLayout(false);
    this.EllipsePanel1.PerformLayout();
    ((ISupportInitialize) this.dateTimePeriodDate).EndInit();
    ((ISupportInitialize) this.textEndingBalance).EndInit();
    this.Panel1.ResumeLayout(false);
    ((ISupportInitialize) this.buttonReconcile).EndInit();
    ((ISupportInitialize) this.buttonCancel).EndInit();
    ((ISupportInitialize) this.textStartingBalance).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  public Decimal EndingBalance => this._endingBalance;

  public DateTime PeriodDate => this._periodDate;

  public Decimal StartingBalance
  {
    get
    {
      return Operators.CompareString(((TextEditorControlBase) this.textStartingBalance).Text, string.Empty, false) == 0 ? 0M : Conversions.ToDecimal(((TextEditorControlBase) this.textStartingBalance).Text);
    }
  }

  private void buttonCancel_Click(object sender, EventArgs e)
  {
    this.DialogResult = DialogResult.Cancel;
    this.Close();
  }

  private void buttonReconcile_Click(object sender, EventArgs e)
  {
    if (this.dateTimePeriodDate.DateTime.Equals((object) DBNull.Value))
    {
      int num1 = (int) MessageBox.Show("You must enter a statement date to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else if (((TextEditorControlBase) this.textEndingBalance).Text.Length == 0)
    {
      int num2 = (int) MessageBox.Show("You must enter an ending balance to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else if (!Versioned.IsNumeric((object) ((TextEditorControlBase) this.textEndingBalance).Text))
    {
      int num3 = (int) MessageBox.Show("Ending balance must be numeric.", "Invalid Entry!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else
    {
      this._endingBalance = Conversions.ToDecimal(((TextEditorControlBase) this.textEndingBalance).Text);
      this._periodDate = this.dateTimePeriodDate.DateTime;
      this.DialogResult = DialogResult.OK;
      this.Close();
    }
  }

  private void GetStartingBalance(DateTime StatementDate)
  {
    ((TextEditorControlBase) this.textStartingBalance).Text = Utility.GetAccountStartingBalance(this._bankGLAccountID, StatementDate).ToString("c");
  }

  private void dateTimePeriodDate_ValueChanged(object sender, EventArgs e)
  {
  }

  private void dateTimePeriodDate_Validating(object sender, CancelEventArgs e)
  {
    if (this.dateTimePeriodDate.DateTime.Equals((object) DBNull.Value))
      return;
    this.GetStartingBalance(this.dateTimePeriodDate.DateTime);
  }
}
