// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.BindPolicy.frmBindingRequirements
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using MGASystems.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies.BindPolicy;

public sealed class frmBindingRequirements : Form
{
  private IContainer components;
  private PictureBox PictureBox1;
  private MGAListBox lstReasons;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
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

  [field: AccessedThroughProperty("lblTitle")]
  private virtual Label lblTitle { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblReason")]
  private virtual Label lblReason { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmBindingRequirements));
    Appearance appearance = new Appearance();
    this.PictureBox1 = new PictureBox();
    this.lblTitle = new Label();
    this.lblReason = new Label();
    this.lstReasons = new MGAListBox();
    this.btnOK = new MGAButton();
    ((ISupportInitialize) this.PictureBox1).BeginInit();
    ((ISupportInitialize) this.lstReasons).BeginInit();
    ((ISupportInitialize) this.btnOK).BeginInit();
    this.SuspendLayout();
    this.PictureBox1.Image = (Image) componentResourceManager.GetObject("PictureBox1.Image");
    this.PictureBox1.Location = new Point(39, 8);
    this.PictureBox1.Name = "PictureBox1";
    this.PictureBox1.Size = new Size(48 /*0x30*/, 48 /*0x30*/);
    this.PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
    this.PictureBox1.TabIndex = 0;
    this.PictureBox1.TabStop = false;
    this.lblTitle.AutoSize = true;
    this.lblTitle.Font = new Font("Tahoma", 12f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblTitle.Location = new Point(95, 21);
    this.lblTitle.Name = "lblTitle";
    this.lblTitle.Size = new Size(0, 19);
    this.lblTitle.TabIndex = 1;
    this.lblReason.AutoSize = true;
    this.lblReason.Location = new Point(8, 72);
    this.lblReason.Name = "lblReason";
    this.lblReason.Size = new Size(0, 13);
    this.lblReason.TabIndex = 2;
    ((Control) this.lstReasons).Location = new Point(8, 96 /*0x60*/);
    ((Control) this.lstReasons).Name = "lstReasons";
    ((Control) this.lstReasons).Size = new Size(664, 145);
    ((Control) this.lstReasons).TabIndex = 3;
    appearance.BackColor = Color.Gainsboro;
    appearance.BackColor2 = Color.White;
    appearance.BackGradientStyle = (GradientStyle) 2;
    appearance.BorderColor = Color.Gray;
    ((ControlBase) this.btnOK).Appearance = (AppearanceBase) appearance;
    ((Control) this.btnOK).Location = new Point(281, 282);
    ((Control) this.btnOK).Name = "btnOK";
    ((Control) this.btnOK).Size = new Size(88, 24);
    ((Control) this.btnOK).TabIndex = 4;
    ((ControlBase) this.btnOK).Text = "OK";
    this.btnOK.UseOSThemes = (DefaultableBoolean) 2;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.ClientSize = new Size(684, 318);
    this.Controls.Add((Control) this.btnOK);
    this.Controls.Add((Control) this.lstReasons);
    this.Controls.Add((Control) this.lblReason);
    this.Controls.Add((Control) this.lblTitle);
    this.Controls.Add((Control) this.PictureBox1);
    this.Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
    this.Name = nameof (frmBindingRequirements);
    ((ISupportInitialize) this.PictureBox1).EndInit();
    ((ISupportInitialize) this.lstReasons).EndInit();
    ((ISupportInitialize) this.btnOK).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  public frmBindingRequirements(List<string> reasons, frmBindingRequirements.RequirementsType type)
  {
    this.InitializeComponent();
    try
    {
      foreach (object reason in reasons)
        ((ListBox) this.lstReasons).Items.Add(reason);
    }
    finally
    {
      List<string>.Enumerator enumerator;
      enumerator.Dispose();
    }
    switch (type)
    {
      case frmBindingRequirements.RequirementsType.Bind:
        this.Text = "Binding Requirements Not Met";
        this.lblReason.Text = "This policy can not be bound because the following data is missing:";
        this.lblTitle.Text = "Binding Requirements Not Met";
        break;
      case frmBindingRequirements.RequirementsType.Issue:
        this.Text = "Issuance Requirements Not Met";
        this.lblReason.Text = "This policy can not be issued because the following data is missing:";
        this.lblTitle.Text = "Issuance Requirements Not Met";
        break;
    }
  }

  private void btnOK_Click(object sender, EventArgs e) => this.Close();

  public enum RequirementsType
  {
    Bind,
    Issue,
  }
}
