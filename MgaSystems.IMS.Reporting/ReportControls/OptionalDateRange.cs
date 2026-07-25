// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.ReportControls.OptionalDateRange
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinEditors;
using MGASystems.Tools;
using Microsoft.VisualBasic;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Reporting.ReportControls;

public class OptionalDateRange : BaseReportControl
{
  private IContainer components;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [field: AccessedThroughProperty("dtpFrom")]
  internal virtual MGADateTimePicker dtpFrom { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dtpTo")]
  internal virtual MGADateTimePicker dtpTo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGACheckBox chkUseRange
  {
    get => this._chkUseRange;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.chkUseRange_CheckedChanged);
      MGACheckBox chkUseRange1 = this._chkUseRange;
      if (chkUseRange1 != null)
        ((UltraToggleEditorBase) chkUseRange1).CheckedChanged -= eventHandler;
      this._chkUseRange = value;
      MGACheckBox chkUseRange2 = this._chkUseRange;
      if (chkUseRange2 == null)
        return;
      ((UltraToggleEditorBase) chkUseRange2).CheckedChanged += eventHandler;
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    this.dtpFrom = new MGADateTimePicker();
    this.dtpTo = new MGADateTimePicker();
    this.Label1 = new Label();
    this.chkUseRange = new MGACheckBox();
    ((ISupportInitialize) this.dtpFrom).BeginInit();
    ((ISupportInitialize) this.dtpTo).BeginInit();
    ((ISupportInitialize) this.chkUseRange).BeginInit();
    this.SuspendLayout();
    appearance1.BackColor = Color.LightGray;
    appearance1.BackColor2 = Color.White;
    appearance1.BackGradientStyle = (GradientStyle) 2;
    appearance1.BorderColor = Color.LightGray;
    appearance1.ForeColor = Color.FromArgb(60, 60, 60);
    this.dtpFrom.ButtonAppearance = (AppearanceBase) appearance1;
    ((Control) this.dtpFrom).Enabled = false;
    ((Control) this.dtpFrom).Location = new Point(108, 7);
    ((Control) this.dtpFrom).Name = "dtpFrom";
    ((Control) this.dtpFrom).Size = new Size(100, 19);
    ((Control) this.dtpFrom).TabIndex = 0;
    ((UltraControlBase) this.dtpFrom).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtpFrom).UseOsThemes = (DefaultableBoolean) 2;
    appearance2.BackColor = Color.LightGray;
    appearance2.BackColor2 = Color.White;
    appearance2.BackGradientStyle = (GradientStyle) 2;
    appearance2.BorderColor = Color.LightGray;
    appearance2.ForeColor = Color.FromArgb(60, 60, 60);
    this.dtpTo.ButtonAppearance = (AppearanceBase) appearance2;
    ((Control) this.dtpTo).Enabled = false;
    ((Control) this.dtpTo).Location = new Point(232, 7);
    ((Control) this.dtpTo).Name = "dtpTo";
    ((Control) this.dtpTo).Size = new Size(100, 19);
    ((Control) this.dtpTo).TabIndex = 1;
    ((UltraControlBase) this.dtpTo).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtpTo).UseOsThemes = (DefaultableBoolean) 2;
    this.Label1.Location = new Point(213, 0);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(16 /*0x10*/, 30);
    this.Label1.TabIndex = 2;
    this.Label1.Text = "to";
    this.Label1.TextAlign = ContentAlignment.MiddleLeft;
    appearance3.BorderColor = Color.Gray;
    appearance3.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkUseRange).Appearance = (AppearanceBase) appearance3;
    ((UltraToggleEditorBase) this.chkUseRange).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkUseRange).Location = new Point(88, 8);
    ((Control) this.chkUseRange).Name = "chkUseRange";
    ((Control) this.chkUseRange).Size = new Size(16 /*0x10*/, 19);
    ((Control) this.chkUseRange).TabIndex = 3;
    this.Controls.Add((Control) this.chkUseRange);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.dtpTo);
    this.Controls.Add((Control) this.dtpFrom);
    this.Name = nameof (OptionalDateRange);
    this.Size = new Size(336, 32 /*0x20*/);
    this.Controls.SetChildIndex((Control) this.lblDescription, 0);
    this.Controls.SetChildIndex((Control) this.dtpFrom, 0);
    this.Controls.SetChildIndex((Control) this.dtpTo, 0);
    this.Controls.SetChildIndex((Control) this.Label1, 0);
    this.Controls.SetChildIndex((Control) this.chkUseRange, 0);
    ((ISupportInitialize) this.dtpFrom).EndInit();
    ((ISupportInitialize) this.dtpTo).EndInit();
    ((ISupportInitialize) this.chkUseRange).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  public OptionalDateRange(string labelText, DateTime dateFrom, DateTime dateTo)
  {
    this.InitializeComponent();
    this.Description = labelText;
    this.dtpFrom.Value = (object) dateFrom;
    this.dtpTo.Value = (object) dateTo;
    this.InitialSize = this.Size;
  }

  public override string InputErrorMessage
  {
    get
    {
      return !((UltraToggleEditorBase) this.chkUseRange).Checked || DateTime.Compare(this.dtpFrom.DateTime.Date, this.dtpTo.DateTime.Date) <= 0 ? string.Empty : "From Date Must Be Before To Date";
    }
  }

  public override object Value
  {
    get
    {
      object obj;
      if (((UltraToggleEditorBase) this.chkUseRange).Checked)
      {
        object[] objArray = new object[2];
        int num1 = !((UltraToggleEditorBase) this.chkUseRange).Checked ? 0 : (this.dtpFrom.Value != null ? 1 : 0);
        DateTime dateTime = this.dtpFrom.DateTime;
        __Boxed<DateTime> date1 = (ValueType) dateTime.Date;
        objArray[0] = Interaction.IIf(num1 != 0, (object) date1, (object) null);
        int num2 = !((UltraToggleEditorBase) this.chkUseRange).Checked ? 0 : (this.dtpTo.Value != null ? 1 : 0);
        dateTime = this.dtpTo.DateTime;
        __Boxed<DateTime> date2 = (ValueType) dateTime.Date;
        objArray[1] = Interaction.IIf(num2 != 0, (object) date2, (object) null);
        obj = (object) objArray;
      }
      else
        obj = (object) new object[2];
      return obj;
    }
    set
    {
      object[] objArray = (object[]) value;
      if (objArray[0] == null)
        this.dtpFrom.Value = (object) null;
      else
        this.dtpFrom.Value = (object) (DateTime) objArray[0];
      if (objArray[1] == null)
        this.dtpTo.Value = (object) null;
      else
        this.dtpTo.Value = (object) (DateTime) objArray[1];
    }
  }

  public override void Compress()
  {
    ((Control) this.dtpFrom).Top = 0;
    ((Control) this.dtpTo).Top = 0;
    this.lblDescription.Top = 0;
    this.Label1.Top = 0;
    ((Control) this.chkUseRange).Top = 0;
    this.lblDescription.Height = ((Control) this.dtpTo).Height;
    this.Label1.Height = ((Control) this.dtpTo).Height;
    this.Height = ((Control) this.dtpTo).Height;
  }

  private void chkUseRange_CheckedChanged(object sender, EventArgs e)
  {
    ((Control) this.dtpTo).Enabled = ((UltraToggleEditorBase) this.chkUseRange).Checked;
    ((Control) this.dtpFrom).Enabled = ((UltraToggleEditorBase) this.chkUseRange).Checked;
  }
}
