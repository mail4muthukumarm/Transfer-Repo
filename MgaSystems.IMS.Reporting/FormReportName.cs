// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.FormReportName
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

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
namespace MGASystems.IMS.Reporting;

[DesignerGenerated]
public class FormReportName : Form
{
  private IContainer components;
  private bool _saved;

  [DebuggerNonUserCode]
  protected override void Dispose(bool disposing)
  {
    try
    {
      if (!disposing || this.components == null)
        return;
      this.components.Dispose();
    }
    finally
    {
      base.Dispose(disposing);
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    this.btnCancel = new MGAButton();
    this.btnSave = new MGAButton();
    this.txtFileName = new MGATextBox();
    this.Label1 = new Label();
    this.Label2 = new Label();
    ((ISupportInitialize) this.btnCancel).BeginInit();
    ((ISupportInitialize) this.btnSave).BeginInit();
    ((ISupportInitialize) this.txtFileName).BeginInit();
    this.SuspendLayout();
    ((Control) this.btnCancel).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance1.BackColor = Color.FromArgb(248, 248, 248);
    appearance1.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance1.BackGradientStyle = (GradientStyle) 2;
    appearance1.BorderColor = Color.DarkGray;
    appearance1.ImageHAlign = (HAlign) 2;
    appearance1.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnCancel).Appearance = (AppearanceBase) appearance1;
    ((ControlBase) this.btnCancel).ImageSize = new Size(24, 24);
    ((Control) this.btnCancel).Location = new Point(451, 37);
    ((Control) this.btnCancel).Name = "btnCancel";
    ((Control) this.btnCancel).Size = new Size(40, 40);
    ((Control) this.btnCancel).TabIndex = 20;
    this.btnCancel.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.btnSave).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance2.BackColor = Color.FromArgb(248, 248, 248);
    appearance2.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance2.BackGradientStyle = (GradientStyle) 2;
    appearance2.BorderColor = Color.DarkGray;
    appearance2.ImageHAlign = (HAlign) 2;
    appearance2.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnSave).Appearance = (AppearanceBase) appearance2;
    ((ControlBase) this.btnSave).ImageSize = new Size(24, 24);
    ((Control) this.btnSave).Location = new Point(403, 37);
    ((Control) this.btnSave).Name = "btnSave";
    ((Control) this.btnSave).Size = new Size(40, 40);
    ((Control) this.btnSave).TabIndex = 19;
    this.btnSave.UseOSThemes = (DefaultableBoolean) 2;
    this.txtFileName.AcceptsReturn = true;
    appearance3.BackColor = Color.White;
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance3.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtFileName).Appearance = (AppearanceBase) appearance3;
    ((TextEditorControlBase) this.txtFileName).BackColor = Color.White;
    ((Control) this.txtFileName).Location = new Point(71, 39);
    ((TextEditorControlBase) this.txtFileName).MaxLength = 1000;
    this.txtFileName.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtFileName).Name = "txtFileName";
    ((Control) this.txtFileName).Size = new Size(272, 19);
    ((Control) this.txtFileName).TabIndex = 21;
    ((UltraControlBase) this.txtFileName).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtFileName).UseOsThemes = (DefaultableBoolean) 2;
    this.Label1.AutoSize = true;
    this.Label1.Location = new Point(8, 42);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(57, 13);
    this.Label1.TabIndex = 22;
    this.Label1.Text = "File Name:";
    this.Label2.AutoSize = true;
    this.Label2.Location = new Point(8, 9);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(462, 13);
    this.Label2.TabIndex = 23;
    this.Label2.Text = "Enter the name of the file as you would like to see if appears in the doc handler (Omit Extensions)";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(503, 89);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.txtFileName);
    this.Controls.Add((Control) this.btnCancel);
    this.Controls.Add((Control) this.btnSave);
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (FormReportName);
    this.Text = "Enter File Name";
    ((ISupportInitialize) this.btnCancel).EndInit();
    ((ISupportInitialize) this.btnSave).EndInit();
    ((ISupportInitialize) this.txtFileName).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
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

  [field: AccessedThroughProperty("txtFileName")]
  private virtual MGATextBox txtFileName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label2")]
  internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public FormReportName(string filename)
  {
    this.Load += new EventHandler(this.FormReportName_Load);
    this._saved = false;
    this.InitializeComponent();
    ((TextEditorControlBase) this.txtFileName).Text = filename;
  }

  public FormReportName()
  {
    this.Load += new EventHandler(this.FormReportName_Load);
    this._saved = false;
    this.InitializeComponent();
  }

  private void FormReportName_Load(object sender, EventArgs e)
  {
    ((ControlBase) this.btnSave).Appearance.Image = (object) ImageCache.Instance.Save;
    ((ControlBase) this.btnCancel).Appearance.Image = (object) ImageCache.Instance.Undo;
  }

  public bool Saved => this._saved;

  public string FileName => ((TextEditorControlBase) this.txtFileName).Text;

  private void btnSave_Click(object sender, EventArgs e)
  {
    this._saved = true;
    this.Close();
  }

  private void btnCancel_Click(object sender, EventArgs e)
  {
    this._saved = false;
    this.Close();
  }
}
