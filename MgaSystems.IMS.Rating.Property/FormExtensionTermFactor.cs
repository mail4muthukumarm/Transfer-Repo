// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.Rating.Property.FormExtensionTermFactor
// Assembly: MgaSystems.IMS.Rating.Property, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B6A893CA-828D-4C72-A3E1-997D4DDF80FA
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Rating.Property.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinMaskedEdit;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MgaSystems.IMS.Rating.Property;

[DesignerGenerated]
public class FormExtensionTermFactor : Form
{
  private IContainer components;
  private Decimal _factor;
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormExtensionTermFactor));
    this.lblText = new Label();
    this.Label1 = new Label();
    this.Label2 = new Label();
    this.numFactor = new MGANumericEditor();
    this.numOverrideFactor = new MGANumericEditor();
    this.btnSave = new MGAButton();
    ((ISupportInitialize) this.numFactor).BeginInit();
    ((ISupportInitialize) this.numOverrideFactor).BeginInit();
    ((ISupportInitialize) this.btnSave).BeginInit();
    this.SuspendLayout();
    this.lblText.AutoSize = true;
    this.lblText.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblText.Location = new Point(23, 22);
    this.lblText.Name = "lblText";
    this.lblText.Size = new Size(241, 26);
    this.lblText.TabIndex = 0;
    this.lblText.Text = "If needed, override the calculated factor.\r\n ";
    this.Label1.AutoSize = true;
    this.Label1.Location = new Point(23, 66);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(133, 13);
    this.Label1.TabIndex = 1;
    this.Label1.Text = "Calculated Pro-rata Factor:";
    this.Label2.AutoSize = true;
    this.Label2.Location = new Point(23, 105);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(123, 13);
    this.Label2.TabIndex = 2;
    this.Label2.Text = "Override Pro-rata Factor:";
    appearance1.BackColorDisabled = Color.Gainsboro;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.numFactor).Appearance = (AppearanceBase) appearance1;
    ((UltraNumericEditorBase) this.numFactor).FormatString = "";
    ((Control) this.numFactor).Location = new Point(177, 63 /*0x3F*/);
    this.numFactor.MaskInput = "n.nnnn";
    this.numFactor.MaxValue = (object) new Decimal(new int[4]
    {
      99999,
      0,
      0,
      262144 /*0x040000*/
    });
    this.numFactor.MGAStyle = MGAStyles.Blue;
    this.numFactor.MinValue = (object) new Decimal(new int[4]
    {
      99999,
      0,
      0,
      -2147221504 /*0x80040000*/
    });
    ((Control) this.numFactor).Name = "numFactor";
    this.numFactor.Nullable = true;
    this.numFactor.NumericType = (NumericType) 2;
    ((EditorButtonControlBase) this.numFactor).ReadOnly = true;
    ((Control) this.numFactor).Size = new Size(71, 19);
    ((Control) this.numFactor).TabIndex = 423;
    ((UltraWinEditorMaskedControlBase) this.numFactor).TabNavigation = (MaskedEditTabNavigation) 0;
    ((UltraControlBase) this.numFactor).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numFactor).UseOsThemes = (DefaultableBoolean) 2;
    appearance2.BackColorDisabled = Color.Gainsboro;
    appearance2.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.numOverrideFactor).Appearance = (AppearanceBase) appearance2;
    ((UltraNumericEditorBase) this.numOverrideFactor).FormatString = "";
    ((Control) this.numOverrideFactor).Location = new Point(177, 102);
    this.numOverrideFactor.MaskInput = "n.nnnn";
    this.numOverrideFactor.MaxValue = (object) new Decimal(new int[4]
    {
      99999,
      0,
      0,
      262144 /*0x040000*/
    });
    this.numOverrideFactor.MGAStyle = MGAStyles.Blue;
    this.numOverrideFactor.MinValue = (object) new Decimal(new int[4]
    {
      99999,
      0,
      0,
      -2147221504 /*0x80040000*/
    });
    ((Control) this.numOverrideFactor).Name = "numOverrideFactor";
    this.numOverrideFactor.Nullable = true;
    this.numOverrideFactor.NumericType = (NumericType) 2;
    ((Control) this.numOverrideFactor).Size = new Size(71, 19);
    ((Control) this.numOverrideFactor).TabIndex = 424;
    ((UltraWinEditorMaskedControlBase) this.numOverrideFactor).TabNavigation = (MaskedEditTabNavigation) 0;
    ((UltraControlBase) this.numOverrideFactor).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numOverrideFactor).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.btnSave).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance3.BackColor = Color.FromArgb(248, 248, 248);
    appearance3.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance3.BackGradientStyle = (GradientStyle) 2;
    appearance3.BorderColor = Color.DarkGray;
    appearance3.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance3.Image"));
    appearance3.ImageHAlign = (HAlign) 1;
    appearance3.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnSave).Appearance = (AppearanceBase) appearance3;
    ((Control) this.btnSave).Font = new Font("Tahoma", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.btnSave).Location = new Point(189, 142);
    ((Control) this.btnSave).Name = "btnSave";
    ((ControlBase) this.btnSave).Padding = new Size(5, 0);
    ((Control) this.btnSave).Size = new Size(70, 34);
    ((Control) this.btnSave).TabIndex = 425;
    ((ControlBase) this.btnSave).Text = "Save";
    this.btnSave.UseOSThemes = (DefaultableBoolean) 2;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(271, 188);
    this.Controls.Add((Control) this.btnSave);
    this.Controls.Add((Control) this.numOverrideFactor);
    this.Controls.Add((Control) this.numFactor);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.lblText);
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (FormExtensionTermFactor);
    this.Text = "Set Extension Term Factor";
    ((ISupportInitialize) this.numFactor).EndInit();
    ((ISupportInitialize) this.numOverrideFactor).EndInit();
    ((ISupportInitialize) this.btnSave).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  [field: AccessedThroughProperty("lblText")]
  internal virtual Label lblText { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label2")]
  internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("numFactor")]
  private virtual MGANumericEditor numFactor { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("numOverrideFactor")]
  private virtual MGANumericEditor numOverrideFactor { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

  public bool Saved => this._saved;

  public Decimal SelectedFactor
  {
    get
    {
      Decimal d1 = this.numOverrideFactor.Value == null || this.numOverrideFactor.Value == DBNull.Value || Decimal.Compare(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(this.numOverrideFactor.Value)), 0M) == 0 ? Convert.ToDecimal(RuntimeHelpers.GetObjectValue(this.numFactor.Value)) : Convert.ToDecimal(RuntimeHelpers.GetObjectValue(this.numOverrideFactor.Value));
      return Decimal.Compare(d1, 0M) != 0 ? d1 : throw new InvalidOperationException("Extension Term Factor Cannot Equal 0");
    }
  }

  public FormExtensionTermFactor(Decimal factor)
  {
    this.Load += new EventHandler(this.FormExtensionTermFactor_Load);
    this._saved = false;
    this.InitializeComponent();
    this._factor = factor;
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
    this._saved = false;
    if (MessageBox.Show($"Are you sure you want to set the pro-rata factor to {this.SelectedFactor.ToString()} for all selected exposures?", "Set Extended Term Factor?", MessageBoxButtons.YesNo) == DialogResult.Yes)
      this._saved = true;
    this.Close();
  }

  private void FormExtensionTermFactor_Load(object sender, EventArgs e)
  {
    this.numFactor.Value = (object) this._factor;
    this.numOverrideFactor.Value = (object) DBNull.Value;
    ((Control) this.numOverrideFactor).Select();
  }
}
