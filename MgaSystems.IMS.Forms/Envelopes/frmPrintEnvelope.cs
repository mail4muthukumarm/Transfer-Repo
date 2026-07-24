// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Forms.Envelopes.frmPrintEnvelope
// Assembly: MgaSystems.IMS.Forms, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FB3F392E-40B6-486F-8F0B-A4A494A546D4
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Forms.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using MGASystems.Tools;
using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Forms.Envelopes;

public sealed class frmPrintEnvelope : Form
{
  private EnvelopeLayout EnvelopePreview;
  private RichTextBox rtbReturn;
  private RichTextBox rtbDelivery;
  private Label Label1;
  private Envelope currentEnvelope;

  private virtual MGAButton btnOptions
  {
    get => this._btnOptions;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnOptions_Click);
      MGAButton btnOptions1 = this._btnOptions;
      if (btnOptions1 != null)
        ((Control) btnOptions1).Click -= eventHandler;
      this._btnOptions = value;
      MGAButton btnOptions2 = this._btnOptions;
      if (btnOptions2 == null)
        return;
      ((Control) btnOptions2).Click += eventHandler;
    }
  }

  private virtual MGACheckBox chkReturnAddress
  {
    get => this._chkReturnAddress;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.chkReturnAddress_CheckedChanged);
      MGACheckBox chkReturnAddress1 = this._chkReturnAddress;
      if (chkReturnAddress1 != null)
        ((UltraToggleEditorBase) chkReturnAddress1).CheckedChanged -= eventHandler;
      this._chkReturnAddress = value;
      MGACheckBox chkReturnAddress2 = this._chkReturnAddress;
      if (chkReturnAddress2 == null)
        return;
      ((UltraToggleEditorBase) chkReturnAddress2).CheckedChanged += eventHandler;
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

  private virtual MGAButton btnPrint
  {
    get => this._btnPrint;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnPrint_Click);
      MGAButton btnPrint1 = this._btnPrint;
      if (btnPrint1 != null)
        ((Control) btnPrint1).Click -= eventHandler;
      this._btnPrint = value;
      MGAButton btnPrint2 = this._btnPrint;
      if (btnPrint2 == null)
        return;
      ((Control) btnPrint2).Click += eventHandler;
    }
  }

  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    this.EnvelopePreview = new EnvelopeLayout();
    this.btnOptions = new MGAButton();
    this.rtbReturn = new RichTextBox();
    this.rtbDelivery = new RichTextBox();
    this.btnCancel = new MGAButton();
    this.chkReturnAddress = new MGACheckBox();
    this.btnPrint = new MGAButton();
    this.Label1 = new Label();
    this.SuspendLayout();
    this.EnvelopePreview.Envelope = (Envelope) null;
    this.EnvelopePreview.Location = new Point(232, 136);
    this.EnvelopePreview.Name = "EnvelopePreview";
    this.EnvelopePreview.Size = new Size(168, 88);
    this.EnvelopePreview.TabIndex = 23;
    this.EnvelopePreview.TabStop = false;
    appearance1.BackColor = Color.Gainsboro;
    appearance1.BackColor2 = Color.White;
    appearance1.BackGradientStyle = (GradientStyle) 2;
    appearance1.BorderColor = Color.Gray;
    ((ControlBase) this.btnOptions).Appearance = (AppearanceBase) appearance1;
    ((Control) this.btnOptions).Location = new Point(256 /*0x0100*/, 56);
    ((Control) this.btnOptions).Name = "btnOptions";
    ((Control) this.btnOptions).Size = new Size(136, 24);
    ((Control) this.btnOptions).TabIndex = 4;
    ((ControlBase) this.btnOptions).Text = "Options";
    this.rtbReturn.Location = new Point(8, 136);
    this.rtbReturn.Name = "rtbReturn";
    this.rtbReturn.ScrollBars = RichTextBoxScrollBars.ForcedVertical;
    this.rtbReturn.Size = new Size(216, 88);
    this.rtbReturn.TabIndex = 2;
    this.rtbReturn.Text = "";
    this.rtbDelivery.Location = new Point(8, 24);
    this.rtbDelivery.Name = "rtbDelivery";
    this.rtbDelivery.ScrollBars = RichTextBoxScrollBars.ForcedVertical;
    this.rtbDelivery.Size = new Size(240 /*0xF0*/, 88);
    this.rtbDelivery.TabIndex = 0;
    this.rtbDelivery.Text = "";
    appearance2.BackColor = Color.Gainsboro;
    appearance2.BackColor2 = Color.White;
    appearance2.BackGradientStyle = (GradientStyle) 2;
    appearance2.BorderColor = Color.Gray;
    ((ControlBase) this.btnCancel).Appearance = (AppearanceBase) appearance2;
    ((Control) this.btnCancel).Location = new Point(256 /*0x0100*/, 88);
    ((Control) this.btnCancel).Name = "btnCancel";
    ((Control) this.btnCancel).Size = new Size(136, 24);
    ((Control) this.btnCancel).TabIndex = 5;
    ((ControlBase) this.btnCancel).Text = "Cancel";
    ((UltraToggleEditorBase) this.chkReturnAddress).Checked = true;
    ((UltraToggleEditorBase) this.chkReturnAddress).CheckState = CheckState.Checked;
    ((Control) this.chkReturnAddress).Location = new Point(8, 120);
    ((Control) this.chkReturnAddress).Name = "chkReturnAddress";
    ((Control) this.chkReturnAddress).Size = new Size(104, 16 /*0x10*/);
    ((Control) this.chkReturnAddress).TabIndex = 1;
    ((UltraToggleEditorBase) this.chkReturnAddress).Text = "Return address:";
    appearance3.BackColor = Color.Gainsboro;
    appearance3.BackColor2 = Color.White;
    appearance3.BackGradientStyle = (GradientStyle) 2;
    appearance3.BorderColor = Color.Gray;
    ((ControlBase) this.btnPrint).Appearance = (AppearanceBase) appearance3;
    ((Control) this.btnPrint).Location = new Point(256 /*0x0100*/, 24);
    ((Control) this.btnPrint).Name = "btnPrint";
    ((Control) this.btnPrint).Size = new Size(136, 24);
    ((Control) this.btnPrint).TabIndex = 3;
    ((ControlBase) this.btnPrint).Text = "&Print";
    this.Label1.Location = new Point(8, 8);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(100, 16 /*0x10*/);
    this.Label1.TabIndex = 16 /*0x10*/;
    this.Label1.Text = "Delivery address:";
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.WhiteSmoke;
    this.ClientSize = new Size(402, 231);
    this.Controls.Add((Control) this.EnvelopePreview);
    this.Controls.Add((Control) this.btnOptions);
    this.Controls.Add((Control) this.rtbReturn);
    this.Controls.Add((Control) this.rtbDelivery);
    this.Controls.Add((Control) this.btnCancel);
    this.Controls.Add((Control) this.chkReturnAddress);
    this.Controls.Add((Control) this.btnPrint);
    this.Controls.Add((Control) this.Label1);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmPrintEnvelope);
    this.Text = "Print Envelopes";
    this.ResumeLayout(false);
  }

  public frmPrintEnvelope()
  {
    this.Load += new EventHandler(this.frmPrintEnvelope_Load);
    this.InitializeComponent();
    this.currentEnvelope = new Envelope();
  }

  public frmPrintEnvelope(string ToAddress, string FromAddress)
  {
    this.Load += new EventHandler(this.frmPrintEnvelope_Load);
    this.InitializeComponent();
    this.currentEnvelope = new Envelope();
    this.currentEnvelope.DeliveryAddress.Address = ToAddress;
    this.currentEnvelope.ReturnAddress.Address = FromAddress;
  }

  public frmPrintEnvelope(Envelope env)
  {
    this.Load += new EventHandler(this.frmPrintEnvelope_Load);
    this.InitializeComponent();
    this.currentEnvelope = env;
  }

  private void UpdateDeliveryAndReturnAddressFont()
  {
    this.rtbDelivery.Font = this.currentEnvelope.DeliveryAddress.Font;
    this.rtbReturn.Font = this.currentEnvelope.ReturnAddress.Font;
  }

  private void frmPrintEnvelope_Load(object sender, EventArgs e)
  {
    this.EnvelopePreview.Envelope = this.currentEnvelope;
    this.rtbReturn.Text = this.currentEnvelope.ReturnAddress.Address;
    this.rtbDelivery.Text = this.currentEnvelope.DeliveryAddress.Address;
    this.UpdateDeliveryAndReturnAddressFont();
    this.UpdateEnvelopePreview();
  }

  private void btnOptions_Click(object sender, EventArgs e)
  {
    frmPrintEnvelope_EnvelopesOptions envelopesOptions = new frmPrintEnvelope_EnvelopesOptions(this.currentEnvelope);
    if (envelopesOptions.ShowDialog() == DialogResult.OK)
    {
      this.currentEnvelope = envelopesOptions.NewEnvelope.Clone();
      this.UpdateDeliveryAndReturnAddressFont();
      this.UpdateEnvelopePreview();
    }
    envelopesOptions.Dispose();
  }

  private void chkReturnAddress_CheckedChanged(object sender, EventArgs e)
  {
    this.rtbReturn.Enabled = ((UltraToggleEditorBase) this.chkReturnAddress).Checked;
  }

  private void UpdateEnvelopePreview()
  {
    this.EnvelopePreview.Envelope = this.currentEnvelope;
    this.EnvelopePreview.Refresh();
  }

  private void btnCancel_Click(object sender, EventArgs e)
  {
    this.Close();
    this.Dispose();
  }

  private void btnPrint_Click(object sender, EventArgs e)
  {
    PrintDialog printDialog = new PrintDialog();
    printDialog.Document = this.currentEnvelope.Document;
    if (printDialog.ShowDialog() != DialogResult.OK)
      return;
    this.currentEnvelope.DeliveryAddress.Address = this.rtbDelivery.Text;
    this.currentEnvelope.ReturnAddress.Address = this.rtbReturn.Text;
    this.currentEnvelope.Document.PrinterSettings = printDialog.PrinterSettings;
    this.currentEnvelope.Print();
  }
}
