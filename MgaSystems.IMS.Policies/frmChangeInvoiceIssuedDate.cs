// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.frmChangeInvoiceIssuedDate
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using MGASystems.Data;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies;

public class frmChangeInvoiceIssuedDate : Form
{
  private IContainer components;
  private Label Label3;
  private MGADateTimePicker dtpDateIssued;
  private MGACheckBox cbViaAutomation;
  private readonly int _invoiceNumber;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
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

  private virtual MGAButton btnOK
  {
    get => this._btnOK;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnOK_Click);
      MGAButton btnOk1 = this._btnOK;
      if (btnOk1 != null)
        ((Control) btnOk1).Click -= eventHandler;
      this._btnOK = value;
      MGAButton btnOk2 = this._btnOK;
      if (btnOk2 == null)
        return;
      ((Control) btnOk2).Click += eventHandler;
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
    this.Label3 = new Label();
    this.btnCancel = new MGAButton();
    this.btnOK = new MGAButton();
    this.dtpDateIssued = new MGADateTimePicker();
    this.cbViaAutomation = new MGACheckBox();
    ((ISupportInitialize) this.btnCancel).BeginInit();
    ((ISupportInitialize) this.btnOK).BeginInit();
    ((ISupportInitialize) this.dtpDateIssued).BeginInit();
    ((ISupportInitialize) this.cbViaAutomation).BeginInit();
    this.SuspendLayout();
    this.Label3.Location = new Point(8, 8);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(80 /*0x50*/, 16 /*0x10*/);
    this.Label3.TabIndex = 2;
    this.Label3.Text = "Date Issued:";
    appearance1.BackColor = Color.FromArgb(248, 248, 248);
    appearance1.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance1.BackGradientStyle = (GradientStyle) 2;
    appearance1.BorderColor = Color.DarkGray;
    appearance1.ImageHAlign = (HAlign) 2;
    appearance1.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnCancel).Appearance = (AppearanceBase) appearance1;
    ((UltraButtonBase) this.btnCancel).DialogResult = DialogResult.Cancel;
    ((Control) this.btnCancel).Location = new Point(144 /*0x90*/, 64 /*0x40*/);
    ((Control) this.btnCancel).Name = "btnCancel";
    ((Control) this.btnCancel).Size = new Size(80 /*0x50*/, 24);
    ((Control) this.btnCancel).TabIndex = 4;
    ((ControlBase) this.btnCancel).Text = "Cancel";
    appearance2.BackColor = Color.FromArgb(248, 248, 248);
    appearance2.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance2.BackGradientStyle = (GradientStyle) 2;
    appearance2.BorderColor = Color.DarkGray;
    appearance2.ImageHAlign = (HAlign) 2;
    appearance2.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnOK).Appearance = (AppearanceBase) appearance2;
    ((Control) this.btnOK).Location = new Point(56, 64 /*0x40*/);
    ((Control) this.btnOK).Name = "btnOK";
    ((Control) this.btnOK).Size = new Size(80 /*0x50*/, 24);
    ((Control) this.btnOK).TabIndex = 5;
    ((ControlBase) this.btnOK).Text = "Ok";
    appearance3.BorderColor = Color.Gray;
    ((UltraDateTimeEditor) this.dtpDateIssued).Appearance = (AppearanceBase) appearance3;
    appearance4.BackColor = Color.LightGray;
    appearance4.BackColor2 = Color.White;
    appearance4.BackGradientStyle = (GradientStyle) 2;
    appearance4.BorderColor = Color.LightGray;
    appearance4.ForeColor = Color.FromArgb(60, 60, 60);
    ((UltraDateTimeEditor) this.dtpDateIssued).ButtonAppearance = (AppearanceBase) appearance4;
    ((Control) this.dtpDateIssued).Location = new Point(88, 8);
    ((Control) this.dtpDateIssued).Name = "dtpDateIssued";
    ((Control) this.dtpDateIssued).Size = new Size(136, 20);
    ((Control) this.dtpDateIssued).TabIndex = 6;
    appearance5.BorderColor = Color.Gray;
    appearance5.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.cbViaAutomation).Appearance = (AppearanceBase) appearance5;
    ((Control) this.cbViaAutomation).Location = new Point(88, 32 /*0x20*/);
    ((Control) this.cbViaAutomation).Name = "cbViaAutomation";
    ((Control) this.cbViaAutomation).Size = new Size(136, 20);
    ((Control) this.cbViaAutomation).TabIndex = 7;
    ((UltraToggleEditorBase) this.cbViaAutomation).Text = "Issued Via Automation";
    this.AcceptButton = (IButtonControl) this.btnOK;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.CancelButton = (IButtonControl) this.btnCancel;
    this.ClientSize = new Size(234, 95);
    this.Controls.Add((Control) this.cbViaAutomation);
    this.Controls.Add((Control) this.dtpDateIssued);
    this.Controls.Add((Control) this.btnOK);
    this.Controls.Add((Control) this.btnCancel);
    this.Controls.Add((Control) this.Label3);
    this.Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmChangeInvoiceIssuedDate);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Invoice #{0}";
    ((ISupportInitialize) this.btnCancel).EndInit();
    ((ISupportInitialize) this.btnOK).EndInit();
    ((ISupportInitialize) this.dtpDateIssued).EndInit();
    ((ISupportInitialize) this.cbViaAutomation).EndInit();
    this.ResumeLayout(false);
  }

  public frmChangeInvoiceIssuedDate(int InvoiceNumber)
  {
    this.Load += new EventHandler(this.frmChangeInvoiceIssuedDate_Load);
    this.InitializeComponent();
    this._invoiceNumber = InvoiceNumber;
  }

  private void btnOK_Click(object sender, EventArgs e)
  {
    DefaultDatabase.ExecuteNonQuery(CommandType.Text, "UPDATE tblFin_Invoices SET DateIssued = @DateIssued, IssuedViaAutomation = @IssuedViaAutomation WHERE InvoiceNum = @InvoiceNum", new object[6]
    {
      (object) "@DateIssued",
      ((UltraDateTimeEditor) this.dtpDateIssued).Value,
      (object) "@IssuedViaAutomation",
      (object) ((UltraToggleEditorBase) this.cbViaAutomation).Checked,
      (object) "@InvoiceNum",
      (object) this._invoiceNumber
    });
    this.Close();
  }

  private void frmChangeInvoiceIssuedDate_Load(object sender, EventArgs e)
  {
    DataRow dataRow = DefaultDatabase.ExecuteDataRow(CommandType.Text, "SELECT OfficeInvoiceNum, DateIssued, IssuedViaAutomation FROM tblFin_Invoices WHERE InvoiceNum=@InvoiceNum", new object[2]
    {
      (object) "@InvoiceNum",
      (object) this._invoiceNumber
    });
    if (dataRow == null)
      return;
    this.Text = string.Format(this.Text, RuntimeHelpers.GetObjectValue(dataRow["OfficeInvoiceNum"]));
    ((UltraDateTimeEditor) this.dtpDateIssued).Value = RuntimeHelpers.GetObjectValue(dataRow["DateIssued"]);
    ((UltraToggleEditorBase) this.cbViaAutomation).Checked = Conversions.ToBoolean(dataRow["IssuedViaAutomation"]);
  }

  private void btnCancel_Click(object sender, EventArgs e) => this.Close();
}
