// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.Forms.formChangeSecondCostCenter
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.Forms;

public class formChangeSecondCostCenter : Form
{
  private Label label20;
  private MGASimpleComboBox comboCostCenter;
  private Label label1;
  private Label lblCurrentCostCenter;
  private MGAButton btnOk;
  private MGAButton btnCancel;
  private System.ComponentModel.Container components;
  private int SecondCostCenterId;

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
    this.label20 = new Label();
    this.comboCostCenter = new MGASimpleComboBox();
    this.label1 = new Label();
    this.lblCurrentCostCenter = new Label();
    this.btnOk = new MGAButton();
    this.btnCancel = new MGAButton();
    ((ISupportInitialize) this.comboCostCenter).BeginInit();
    ((ISupportInitialize) this.btnOk).BeginInit();
    ((ISupportInitialize) this.btnCancel).BeginInit();
    this.SuspendLayout();
    this.label20.AutoSize = true;
    this.label20.Font = new Font("Tahoma", 8.25f);
    this.label20.Location = new Point(16 /*0x10*/, 40);
    this.label20.Name = "label20";
    this.label20.Size = new Size(99, 17);
    this.label20.TabIndex = 57;
    this.label20.Text = "New Cost Center : ";
    this.comboCostCenter.BorderStyle = (UIElementBorderStyle) 4;
    this.comboCostCenter.CharacterCasing = CharacterCasing.Normal;
    ((UltraDropDownBase) this.comboCostCenter).DisplayMember = "";
    this.comboCostCenter.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboCostCenter).Font = new Font("Tahoma", 8.25f);
    ((Control) this.comboCostCenter).Location = new Point(144 /*0x90*/, 40);
    this.comboCostCenter.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboCostCenter).Name = "comboCostCenter";
    ((Control) this.comboCostCenter).Size = new Size(200, 20);
    ((Control) this.comboCostCenter).TabIndex = 58;
    ((UltraDropDownBase) this.comboCostCenter).ValueMember = "";
    this.label1.AutoSize = true;
    this.label1.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.label1.Location = new Point(16 /*0x10*/, 16 /*0x10*/);
    this.label1.Name = "label1";
    this.label1.Size = new Size(116, 17);
    this.label1.TabIndex = 59;
    this.label1.Text = "Existing Cost Center : ";
    this.lblCurrentCostCenter.Font = new Font("Tahoma", 8.25f);
    this.lblCurrentCostCenter.Location = new Point(144 /*0x90*/, 16 /*0x10*/);
    this.lblCurrentCostCenter.Name = "lblCurrentCostCenter";
    this.lblCurrentCostCenter.Size = new Size(192 /*0xC0*/, 16 /*0x10*/);
    this.lblCurrentCostCenter.TabIndex = 60;
    this.lblCurrentCostCenter.Text = "{}";
    ((Control) this.btnOk).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    ((AppearanceBase) appearance1).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance1).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance1).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance1).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance1).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance1).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnOk).Appearance = (AppearanceBase) appearance1;
    ((Control) this.btnOk).Location = new Point(180, 72);
    ((Control) this.btnOk).Name = "btnOk";
    ((Control) this.btnOk).Size = new Size(80 /*0x50*/, 24);
    ((Control) this.btnOk).TabIndex = 79;
    ((Control) this.btnOk).Text = "Ok";
    ((Control) this.btnOk).Click += new EventHandler(this.btnOk_Click);
    ((Control) this.btnCancel).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    ((AppearanceBase) appearance2).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance2).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance2).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance2).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance2).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance2).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnCancel).Appearance = (AppearanceBase) appearance2;
    ((Control) this.btnCancel).Location = new Point(264, 72);
    ((Control) this.btnCancel).Name = "btnCancel";
    ((Control) this.btnCancel).Size = new Size(80 /*0x50*/, 24);
    ((Control) this.btnCancel).TabIndex = 80 /*0x50*/;
    ((Control) this.btnCancel).Text = "Cancel";
    ((Control) this.btnCancel).Click += new EventHandler(this.btnCancel_Click);
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.ClientSize = new Size(354, 104);
    this.Controls.Add((Control) this.btnCancel);
    this.Controls.Add((Control) this.btnOk);
    this.Controls.Add((Control) this.lblCurrentCostCenter);
    this.Controls.Add((Control) this.label1);
    this.Controls.Add((Control) this.label20);
    this.Controls.Add((Control) this.comboCostCenter);
    this.Font = new Font("Tahoma", 8.25f);
    this.FormBorderStyle = FormBorderStyle.FixedSingle;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (formChangeSecondCostCenter);
    this.ShowInTaskbar = false;
    this.Text = "Change Cost Center";
    ((ISupportInitialize) this.comboCostCenter).EndInit();
    ((ISupportInitialize) this.btnOk).EndInit();
    ((ISupportInitialize) this.btnCancel).EndInit();
    this.ResumeLayout(false);
  }

  private formChangeSecondCostCenter() => this.InitializeComponent();

  internal formChangeSecondCostCenter(DataTable dt)
  {
    this.InitializeComponent();
    ((UltraGridBase) this.comboCostCenter).DataSource = (object) dt;
    ((UltraDropDownBase) this.comboCostCenter).DisplayMember = "Name";
    ((UltraDropDownBase) this.comboCostCenter).ValueMember = "CostCenterId";
  }

  private void btnOk_Click(object sender, EventArgs e)
  {
    this.DialogResult = DialogResult.OK;
    this.Close();
  }

  private void btnCancel_Click(object sender, EventArgs e)
  {
    this.DialogResult = DialogResult.Cancel;
    this.Close();
  }

  internal string SecondCostCenterName
  {
    get => this.lblCurrentCostCenter.Text;
    set => this.lblCurrentCostCenter.Text = value;
  }

  internal int SecondCostCenterID
  {
    get
    {
      return this.comboCostCenter.Value == null ? this.SecondCostCenterId : int.Parse(this.comboCostCenter.Value.ToString());
    }
    set => this.SecondCostCenterId = value;
  }

  internal int NewSecondCostCenterID
  {
    get
    {
      return this.comboCostCenter.Value == null ? this.SecondCostCenterId : int.Parse(this.comboCostCenter.Value.ToString());
    }
  }

  internal string NewSecondCostCenterName
  {
    get
    {
      return ((Control) this.comboCostCenter).Text == null ? this.lblCurrentCostCenter.Text : ((Control) this.comboCostCenter).Text;
    }
  }
}
