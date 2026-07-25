// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Invoices.frmChangeInvoiceDueDate
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using MGASystems.BusinessObjects;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies.Invoices;

public sealed class frmChangeInvoiceDueDate : Form
{
  private IContainer components;
  private UltraLabel Label1;
  private UltraLabel Label2;
  private UltraLabel lblDue;
  private UltraLabel Label3;
  private UltraLabel lblInvoiceNum;
  private MGADateTimePicker dtNewDate;
  private Invoice _i;
  private bool _saved;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private virtual MGAButton btnSave
  {
    get => this._btnSave;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnSave_Click);
      MGAButton btnSave1 = this._btnSave;
      if (btnSave1 != null)
        ((Control) btnSave1).Click -= eventHandler;
      this._btnSave = value;
      MGAButton btnSave2 = this._btnSave;
      if (btnSave2 == null)
        return;
      ((Control) btnSave2).Click += eventHandler;
    }
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

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    this.btnSave = new MGAButton();
    this.btnCancel = new MGAButton();
    this.Label1 = new UltraLabel();
    this.Label2 = new UltraLabel();
    this.lblDue = new UltraLabel();
    this.Label3 = new UltraLabel();
    this.lblInvoiceNum = new UltraLabel();
    this.dtNewDate = new MGADateTimePicker();
    ((ISupportInitialize) this.btnSave).BeginInit();
    ((ISupportInitialize) this.btnCancel).BeginInit();
    ((ISupportInitialize) this.dtNewDate).BeginInit();
    this.SuspendLayout();
    appearance1.BackColor = Color.Gainsboro;
    appearance1.BackColor2 = Color.White;
    appearance1.BackGradientStyle = (GradientStyle) 2;
    appearance1.BorderColor = Color.Gray;
    appearance1.ImageHAlign = (HAlign) 2;
    ((ControlBase) this.btnSave).Appearance = (AppearanceBase) appearance1;
    ((ControlBase) this.btnSave).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnSave).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnSave).Location = new Point(224 /*0xE0*/, 104);
    ((Control) this.btnSave).Name = "btnSave";
    ((Control) this.btnSave).TabIndex = 0;
    appearance2.BackColor = Color.Gainsboro;
    appearance2.BackColor2 = Color.White;
    appearance2.BackGradientStyle = (GradientStyle) 2;
    appearance2.BorderColor = Color.Gray;
    appearance2.ImageHAlign = (HAlign) 2;
    ((ControlBase) this.btnCancel).Appearance = (AppearanceBase) appearance2;
    ((UltraButtonBase) this.btnCancel).DialogResult = DialogResult.Cancel;
    ((ControlBase) this.btnCancel).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnCancel).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnCancel).Location = new Point(272, 104);
    ((Control) this.btnCancel).Name = "btnCancel";
    ((Control) this.btnCancel).TabIndex = 1;
    ((AutoSizeControlBase) this.Label1).AutoSize = true;
    ((Control) this.Label1).Location = new Point(44, 12);
    ((Control) this.Label1).Name = "Label1";
    ((Control) this.Label1).Size = new Size(56, 15);
    ((Control) this.Label1).TabIndex = 2;
    ((ControlBase) this.Label1).Text = "Invoice #:";
    ((AutoSizeControlBase) this.Label2).AutoSize = true;
    ((Control) this.Label2).Location = new Point(69, 44);
    ((Control) this.Label2).Name = "Label2";
    ((Control) this.Label2).Size = new Size(28, 15);
    ((Control) this.Label2).TabIndex = 3;
    ((ControlBase) this.Label2).Text = "Due:";
    appearance3.BorderColor = Color.Gray;
    appearance3.TextHAlign = (HAlign) 1;
    appearance3.TextVAlign = (VAlign) 2;
    ((ControlBase) this.lblDue).Appearance = (AppearanceBase) appearance3;
    this.lblDue.BorderStyleOuter = (UIElementBorderStyle) 4;
    ((Control) this.lblDue).Location = new Point(112 /*0x70*/, 40);
    ((Control) this.lblDue).Name = "lblDue";
    ((Control) this.lblDue).Size = new Size(72, 24);
    ((Control) this.lblDue).TabIndex = 4;
    ((AutoSizeControlBase) this.Label3).AutoSize = true;
    ((Control) this.Label3).Location = new Point(16 /*0x10*/, 74);
    ((Control) this.Label3).Name = "Label3";
    ((Control) this.Label3).Size = new Size(81, 15);
    ((Control) this.Label3).TabIndex = 5;
    ((ControlBase) this.Label3).Text = "New Due Date:";
    appearance4.BorderColor = Color.Gray;
    appearance4.TextHAlign = (HAlign) 1;
    appearance4.TextVAlign = (VAlign) 2;
    ((ControlBase) this.lblInvoiceNum).Appearance = (AppearanceBase) appearance4;
    this.lblInvoiceNum.BorderStyleOuter = (UIElementBorderStyle) 4;
    ((Control) this.lblInvoiceNum).Location = new Point(112 /*0x70*/, 8);
    ((Control) this.lblInvoiceNum).Name = "lblInvoiceNum";
    ((Control) this.lblInvoiceNum).Size = new Size(72, 24);
    ((Control) this.lblInvoiceNum).TabIndex = 6;
    appearance5.BorderColor = Color.Gray;
    ((UltraDateTimeEditor) this.dtNewDate).Appearance = (AppearanceBase) appearance5;
    appearance6.BackColor = Color.LightGray;
    appearance6.BackColor2 = Color.White;
    appearance6.BackGradientStyle = (GradientStyle) 2;
    appearance6.BorderColor = Color.LightGray;
    appearance6.ForeColor = Color.FromArgb(60, 60, 60);
    ((UltraDateTimeEditor) this.dtNewDate).ButtonAppearance = (AppearanceBase) appearance6;
    ((UltraDateTimeEditor) this.dtNewDate).FormatString = "D";
    ((Control) this.dtNewDate).Location = new Point(112 /*0x70*/, 72);
    ((Control) this.dtNewDate).Name = "dtNewDate";
    ((Control) this.dtNewDate).Size = new Size(200, 20);
    ((Control) this.dtNewDate).TabIndex = 7;
    this.AcceptButton = (IButtonControl) this.btnSave;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.CancelButton = (IButtonControl) this.btnCancel;
    this.ClientSize = new Size(320, 150);
    this.ControlBox = false;
    this.Controls.Add((Control) this.dtNewDate);
    this.Controls.Add((Control) this.lblInvoiceNum);
    this.Controls.Add((Control) this.Label3);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.lblDue);
    this.Controls.Add((Control) this.btnCancel);
    this.Controls.Add((Control) this.btnSave);
    this.Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.Name = nameof (frmChangeInvoiceDueDate);
    this.ShowInTaskbar = false;
    this.Text = "Change Invoice Due Date";
    ((ISupportInitialize) this.btnSave).EndInit();
    ((ISupportInitialize) this.btnCancel).EndInit();
    ((ISupportInitialize) this.dtNewDate).EndInit();
    this.ResumeLayout(false);
  }

  public bool Saved => this._saved;

  public frmChangeInvoiceDueDate(Invoice i)
  {
    this.Load += new EventHandler(this.frmChangeInvoiceDueDate_Load);
    this.InitializeComponent();
    this._i = i;
  }

  private void btnCancel_Click(object sender, EventArgs e) => this.Close();

  private void btnSave_Click(object sender, EventArgs e)
  {
    if (((UltraDateTimeEditor) this.dtNewDate).Value == null)
      return;
    this._i.DueDate = ((UltraDateTimeEditor) this.dtNewDate).DateTime;
    this._saved = true;
    this.Close();
  }

  private void frmChangeInvoiceDueDate_Load(object sender, EventArgs e)
  {
    ((ControlBase) this.btnSave).Appearance.Image = (object) ImageCache.Instance.Save;
    ((ControlBase) this.btnCancel).Appearance.Image = (object) ImageCache.Instance.Undo;
    ((ControlBase) this.lblInvoiceNum).Text = this._i.OfficeInvoiceNum.ToString();
    ((ControlBase) this.lblDue).Text = this._i.DueDate.ToShortDateString();
  }
}
