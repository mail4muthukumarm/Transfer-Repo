// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.ReportControls.TextInput
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinEditors;
using MGASystems.Tools;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Reporting.ReportControls;

public class TextInput : BaseReportControl, IOfflineReportControl
{
  private IContainer components;
  private bool _IsRequired;
  private TextInput.ReturnType _ReturnType;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [field: AccessedThroughProperty("txt")]
  internal virtual MGATextBox txt { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    Appearance appearance = new Appearance();
    this.txt = new MGATextBox();
    ((ISupportInitialize) this.txt).BeginInit();
    this.SuspendLayout();
    this.lblDescription.Size = new Size(88, 32 /*0x20*/);
    ((Control) this.txt).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    appearance.BackColor = Color.White;
    appearance.BorderColor = Color.Gray;
    appearance.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txt).Appearance = (AppearanceBase) appearance;
    ((TextEditorControlBase) this.txt).BackColor = Color.White;
    ((Control) this.txt).Location = new Point(88, 6);
    ((Control) this.txt).Name = "txt";
    ((Control) this.txt).Size = new Size(300, 19);
    ((Control) this.txt).TabIndex = 1;
    ((UltraControlBase) this.txt).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txt).UseOsThemes = (DefaultableBoolean) 2;
    this.Controls.Add((Control) this.txt);
    this.Name = nameof (TextInput);
    this.Size = new Size(392, 30);
    this.Controls.SetChildIndex((Control) this.txt, 0);
    this.Controls.SetChildIndex((Control) this.lblDescription, 0);
    ((ISupportInitialize) this.txt).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  public TextInput(string labelText, bool Required, bool NumericOnly)
  {
    this.InitializeComponent();
    this.Description = labelText;
    this._ReturnType = !NumericOnly ? TextInput.ReturnType.Str : TextInput.ReturnType.Int;
    this._IsRequired = Required;
    this.InitialSize = this.Size;
  }

  public TextInput(string LabelText, TextInput.ReturnType ReturnType, bool Required)
  {
    this.InitializeComponent();
    this.Description = LabelText;
    this._ReturnType = ReturnType;
    this._IsRequired = Required;
    this.InitialSize = this.Size;
  }

  public override string InputErrorMessage
  {
    get
    {
      return !this._IsRequired || ((TextEditorControlBase) this.txt).Text.Length != 0 ? (this._ReturnType != TextInput.ReturnType.Dbl && this._ReturnType != TextInput.ReturnType.Dec && this._ReturnType != TextInput.ReturnType.Int || ((TextEditorControlBase) this.txt).Text.Length <= 0 || Versioned.IsNumeric((object) ((TextEditorControlBase) this.txt).Text) ? string.Empty : "Value must be numeric.") : "A Value is required.";
    }
  }

  public override object Value
  {
    get
    {
      object obj;
      switch (this._ReturnType)
      {
        case TextInput.ReturnType.Int:
          obj = ((TextEditorControlBase) this.txt).Text.Length != 0 ? (object) Conversions.ToInteger(((TextEditorControlBase) this.txt).Text) : (object) null;
          break;
        case TextInput.ReturnType.Dbl:
          obj = ((TextEditorControlBase) this.txt).Text.Length != 0 ? (object) Conversions.ToDouble(((TextEditorControlBase) this.txt).Text) : (object) null;
          break;
        case TextInput.ReturnType.Dec:
          obj = ((TextEditorControlBase) this.txt).Text.Length != 0 ? (object) Conversions.ToDecimal(((TextEditorControlBase) this.txt).Text) : (object) null;
          break;
        case TextInput.ReturnType.Str:
          obj = ((TextEditorControlBase) this.txt).Text.Length != 0 ? (object) ((TextEditorControlBase) this.txt).Text : (object) null;
          break;
        default:
          obj = (object) null;
          break;
      }
      return obj;
    }
    set
    {
      if (Information.IsNothing(RuntimeHelpers.GetObjectValue(value)) || Information.IsDBNull(RuntimeHelpers.GetObjectValue(value)))
        return;
      switch (this._ReturnType)
      {
        case TextInput.ReturnType.Int:
          ((TextEditorControlBase) this.txt).Text = ((int) value).ToString();
          break;
        case TextInput.ReturnType.Dbl:
          ((TextEditorControlBase) this.txt).Text = ((double) value).ToString();
          break;
        case TextInput.ReturnType.Dec:
          ((TextEditorControlBase) this.txt).Text = ((Decimal) value).ToString();
          break;
        case TextInput.ReturnType.Str:
          ((TextEditorControlBase) this.txt).Text = ((string) value).ToString();
          break;
      }
    }
  }

  public override void Compress()
  {
    ((Control) this.txt).Top = 0;
    this.lblDescription.Height = ((Control) this.txt).Height;
    this.lblDescription.Top = 0;
    this.Height = ((Control) this.txt).Height;
  }

  public void SetReportControlValue(object value)
  {
    if (value == null)
      return;
    ((TextEditorControlBase) this.txt).Text = Conversions.ToString(value);
  }

  public enum ReturnType
  {
    Int,
    Dbl,
    Dec,
    Str,
  }
}
