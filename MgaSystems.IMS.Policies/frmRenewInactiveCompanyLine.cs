// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.frmRenewInactiveCompanyLine
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies;

public class frmRenewInactiveCompanyLine : Form
{
  private IContainer components;
  private Panel panelAutomationTypes;
  private Label Label2;
  private bool _saved;
  private bool _renewWithNewCarrier;

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

  [field: AccessedThroughProperty("rbRenewSelectNewCarrier")]
  private virtual RadioButton rbRenewSelectNewCarrier { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("rbRenewWithExpCarrier")]
  private virtual RadioButton rbRenewWithExpCarrier { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    Appearance appearance = new Appearance();
    this.panelAutomationTypes = new Panel();
    this.rbRenewSelectNewCarrier = new RadioButton();
    this.rbRenewWithExpCarrier = new RadioButton();
    this.Label2 = new Label();
    this.btnSave = new MGAButton();
    this.panelAutomationTypes.SuspendLayout();
    ((ISupportInitialize) this.btnSave).BeginInit();
    this.SuspendLayout();
    this.panelAutomationTypes.BackColor = Color.Transparent;
    this.panelAutomationTypes.Controls.Add((Control) this.rbRenewSelectNewCarrier);
    this.panelAutomationTypes.Controls.Add((Control) this.rbRenewWithExpCarrier);
    this.panelAutomationTypes.Location = new Point(2, 34);
    this.panelAutomationTypes.Name = "panelAutomationTypes";
    this.panelAutomationTypes.Size = new Size(376, 42);
    this.panelAutomationTypes.TabIndex = 34;
    this.panelAutomationTypes.Tag = (object) "KeepEnabled";
    this.rbRenewSelectNewCarrier.Location = new Point(194, 8);
    this.rbRenewSelectNewCarrier.Name = "rbRenewSelectNewCarrier";
    this.rbRenewSelectNewCarrier.Size = new Size(180, 24);
    this.rbRenewSelectNewCarrier.TabIndex = 17;
    this.rbRenewSelectNewCarrier.Text = "Renew and Select New Carrier";
    this.rbRenewWithExpCarrier.Checked = true;
    this.rbRenewWithExpCarrier.ForeColor = Color.Black;
    this.rbRenewWithExpCarrier.Location = new Point(11, 8);
    this.rbRenewWithExpCarrier.Name = "rbRenewWithExpCarrier";
    this.rbRenewWithExpCarrier.Size = new Size(162, 24);
    this.rbRenewWithExpCarrier.TabIndex = 15;
    this.rbRenewWithExpCarrier.TabStop = true;
    this.rbRenewWithExpCarrier.Text = "Renew with Expiring Carrier";
    this.Label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.Label2.Enabled = false;
    this.Label2.Location = new Point(4, 13);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(438, 16 /*0x10*/);
    this.Label2.TabIndex = 37;
    this.Label2.Text = "This company/line setup is inactive.  Please select a renewal option:";
    ((Control) this.btnSave).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance.BackColor = Color.FromArgb(248, 248, 248);
    appearance.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance.BackGradientStyle = (GradientStyle) 2;
    appearance.BorderColor = Color.DarkGray;
    appearance.ImageHAlign = (HAlign) 2;
    appearance.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnSave).Appearance = (AppearanceBase) appearance;
    ((ControlBase) this.btnSave).ImageSize = new Size(24, 24);
    ((Control) this.btnSave).Location = new Point(401, 80 /*0x50*/);
    ((Control) this.btnSave).Name = "btnSave";
    ((Control) this.btnSave).TabIndex = 38;
    ((Control) this.btnSave).Tag = (object) "KeepEnabled";
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.ClientSize = new Size(456, 129);
    this.Controls.Add((Control) this.btnSave);
    this.Controls.Add((Control) this.panelAutomationTypes);
    this.Controls.Add((Control) this.Label2);
    this.Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ForeColor = Color.Black;
    this.Name = nameof (frmRenewInactiveCompanyLine);
    this.Text = "Renew Inactive Company/Line";
    this.panelAutomationTypes.ResumeLayout(false);
    ((ISupportInitialize) this.btnSave).EndInit();
    this.ResumeLayout(false);
  }

  public frmRenewInactiveCompanyLine()
  {
    this.Load += new EventHandler(this.frmRenewInactiveCompanyLine_Load);
    this.InitializeComponent();
  }

  public bool Saved => this._saved;

  public bool RenewAndSelectNewCarrier => this._renewWithNewCarrier;

  private void frmRenewInactiveCompanyLine_Load(object sender, EventArgs e)
  {
    ((ControlBase) this.btnSave).Appearance.Image = (object) ImageCache.Instance.Save;
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
    this._saved = true;
    this._renewWithNewCarrier = this.rbRenewSelectNewCarrier.Checked;
    this.Close();
  }
}
