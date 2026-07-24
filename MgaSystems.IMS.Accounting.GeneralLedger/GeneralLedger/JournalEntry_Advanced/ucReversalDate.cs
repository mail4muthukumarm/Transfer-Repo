// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.GeneralLedger.JournalEntry_Advanced.ucReversalDate
// Assembly: MgaSystems.IMS.Accounting.GeneralLedger, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: DC511D5D-5AA9-4B52-8578-E2A0BCB046C3
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Accounting.GeneralLedger.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinEditors;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.GeneralLedger.JournalEntry_Advanced;

public class ucReversalDate : UserControl
{
  private IContainer components;
  private MGADateTimePicker dateTimeReversalDate;
  private MGACheckBox checkReversalEnabled;

  public DateTime? ReversalDate
  {
    get
    {
      return ((UltraToggleEditorBase) this.checkReversalEnabled).Checked && this.dateTimeReversalDate.Value != null ? new DateTime?(this.dateTimeReversalDate.DateTime) : new DateTime?();
    }
  }

  public bool ReversalEnabled => ((UltraToggleEditorBase) this.checkReversalEnabled).Checked;

  public ucReversalDate() => this.InitializeComponent();

  private void SetCheckBinding()
  {
    ((Control) this.dateTimeReversalDate).DataBindings.Clear();
    ((Control) this.dateTimeReversalDate).DataBindings.Add("Enabled", (object) this.checkReversalEnabled, "Checked");
  }

  private void ucReversalDate_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    this.dateTimeReversalDate.Value = (object) null;
    this.SetCheckBinding();
  }

  private void checkReversalEnabled_CheckedChanged(object sender, EventArgs e)
  {
    if (((UltraToggleEditorBase) this.checkReversalEnabled).Checked)
      return;
    this.dateTimeReversalDate.Value = (object) null;
  }

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
    this.dateTimeReversalDate = new MGADateTimePicker();
    this.checkReversalEnabled = new MGACheckBox();
    ((ISupportInitialize) this.dateTimeReversalDate).BeginInit();
    ((ISupportInitialize) this.checkReversalEnabled).BeginInit();
    this.SuspendLayout();
    ((AppearanceBase) appearance1).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dateTimeReversalDate.Appearance = (AppearanceBase) appearance1;
    ((AppearanceBase) appearance2).AlphaLevel = (short) 14;
    ((AppearanceBase) appearance2).BackColor = Color.FromArgb(0, 0, 246, 253);
    ((AppearanceBase) appearance2).BackColor2 = Color.FromArgb(133, 162, 221);
    ((AppearanceBase) appearance2).BackColorAlpha = (Alpha) 2;
    ((AppearanceBase) appearance2).BackGradientAlignment = (GradientAlignment) 4;
    ((AppearanceBase) appearance2).BackGradientStyle = (GradientStyle) 5;
    ((AppearanceBase) appearance2).BorderAlpha = (Alpha) 1;
    ((AppearanceBase) appearance2).BorderColor = Color.FromArgb(78, 122, 171);
    ((AppearanceBase) appearance2).ForeColor = Color.FromArgb(49, 85, 153);
    ((AppearanceBase) appearance2).ForegroundAlpha = (Alpha) 2;
    this.dateTimeReversalDate.ButtonAppearance = (AppearanceBase) appearance2;
    ((Control) this.dateTimeReversalDate).Enabled = false;
    ((Control) this.dateTimeReversalDate).Location = new Point(24, 1);
    this.dateTimeReversalDate.MGAStyle = MGAStyles.Blue;
    ((Control) this.dateTimeReversalDate).Name = "dateTimeReversalDate";
    ((Control) this.dateTimeReversalDate).Size = new Size(91, 20);
    ((Control) this.dateTimeReversalDate).TabIndex = 0;
    ((UltraControlBase) this.dateTimeReversalDate).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dateTimeReversalDate).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance3).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance3).ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.checkReversalEnabled).Appearance = (AppearanceBase) appearance3;
    ((UltraToggleEditorBase) this.checkReversalEnabled).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.checkReversalEnabled).Location = new Point(4, 0);
    this.checkReversalEnabled.MGAStyle = MGAStyles.Blue;
    ((Control) this.checkReversalEnabled).Name = "checkReversalEnabled";
    ((Control) this.checkReversalEnabled).Size = new Size(26, 20);
    ((Control) this.checkReversalEnabled).TabIndex = 1;
    ((UltraToggleEditorBase) this.checkReversalEnabled).CheckedChanged += new EventHandler(this.checkReversalEnabled_CheckedChanged);
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.Transparent;
    this.Controls.Add((Control) this.dateTimeReversalDate);
    this.Controls.Add((Control) this.checkReversalEnabled);
    this.Font = new Font("Tahoma", 8.25f);
    this.Name = nameof (ucReversalDate);
    this.Size = new Size(119, 21);
    this.Load += new EventHandler(this.ucReversalDate_Load);
    ((ISupportInitialize) this.dateTimeReversalDate).EndInit();
    ((ISupportInitialize) this.checkReversalEnabled).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }
}
