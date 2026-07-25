// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.ReportControls.FontSelection
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
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

public class FontSelection : BaseReportControl
{
  private IContainer components;
  private Font fnt;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [field: AccessedThroughProperty("txtFontName")]
  internal virtual MGATextBox txtFontName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGAButton btnLookup
  {
    get => this._btnLookup;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnLookup_Click);
      MGAButton btnLookup1 = this._btnLookup;
      if (btnLookup1 != null)
        ((Control) btnLookup1).Click -= eventHandler;
      this._btnLookup = value;
      MGAButton btnLookup2 = this._btnLookup;
      if (btnLookup2 == null)
        return;
      ((Control) btnLookup2).Click += eventHandler;
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    this.txtFontName = new MGATextBox();
    this.btnLookup = new MGAButton();
    ((ISupportInitialize) this.txtFontName).BeginInit();
    ((ISupportInitialize) this.btnLookup).BeginInit();
    this.SuspendLayout();
    ((Control) this.txtFontName).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.Gray;
    appearance1.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtFontName).Appearance = (AppearanceBase) appearance1;
    ((TextEditorControlBase) this.txtFontName).BackColor = Color.White;
    ((Control) this.txtFontName).Enabled = false;
    ((Control) this.txtFontName).Location = new Point(88, 7);
    ((Control) this.txtFontName).Name = "txtFontName";
    ((Control) this.txtFontName).Size = new Size(268, 19);
    ((Control) this.txtFontName).TabIndex = 1;
    ((UltraControlBase) this.txtFontName).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtFontName).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.btnLookup).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    appearance2.BackColor = Color.FromArgb(248, 248, 248);
    appearance2.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance2.BackGradientStyle = (GradientStyle) 2;
    appearance2.BorderColor = Color.DarkGray;
    appearance2.ImageHAlign = (HAlign) 2;
    appearance2.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnLookup).Appearance = (AppearanceBase) appearance2;
    ((Control) this.btnLookup).Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, (byte) 0);
    ((Control) this.btnLookup).Location = new Point(362, 5);
    ((Control) this.btnLookup).Name = "btnLookup";
    ((Control) this.btnLookup).Size = new Size(26, 24);
    ((Control) this.btnLookup).TabIndex = 2;
    ((ControlBase) this.btnLookup).Text = "Aa";
    this.btnLookup.UseOSThemes = (DefaultableBoolean) 2;
    this.Controls.Add((Control) this.btnLookup);
    this.Controls.Add((Control) this.txtFontName);
    this.Name = nameof (FontSelection);
    this.Size = new Size(392, 32 /*0x20*/);
    this.Controls.SetChildIndex((Control) this.txtFontName, 0);
    this.Controls.SetChildIndex((Control) this.btnLookup, 0);
    this.Controls.SetChildIndex((Control) this.lblDescription, 0);
    ((ISupportInitialize) this.txtFontName).EndInit();
    ((ISupportInitialize) this.btnLookup).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  public FontSelection()
  {
    this.InitializeComponent();
    this.fnt = new Font("Arial", 8f, FontStyle.Regular);
    ((TextEditorControlBase) this.txtFontName).Text = this.FontToString(this.fnt);
    this.InitialSize = this.Size;
  }

  public FontSelection(string LabelText)
  {
    this.InitializeComponent();
    this.Description = LabelText;
    this.fnt = new Font("Arial", 8f, FontStyle.Regular);
    ((TextEditorControlBase) this.txtFontName).Text = this.FontToString(this.fnt);
    this.InitialSize = this.Size;
  }

  public FontSelection(
    string LabelText,
    string DefalultFontName,
    int DefaultFontSize,
    FontStyle DefaultFontStyle)
  {
    this.InitializeComponent();
    this.Description = LabelText;
    this.fnt = new Font(DefalultFontName, (float) DefaultFontSize, DefaultFontStyle);
    ((TextEditorControlBase) this.txtFontName).Text = this.FontToString(this.fnt);
    this.InitialSize = this.Size;
  }

  public override object Value
  {
    get => (object) this.FontConvert(this.fnt);
    set
    {
      this.fnt = this.FontConvert((string) value);
      if (Information.IsDBNull((object) this.fnt))
        return;
      ((TextEditorControlBase) this.txtFontName).Text = this.FontToString(this.fnt);
    }
  }

  public override void Compress()
  {
    ((Control) this.txtFontName).Top = 0;
    ((Control) this.btnLookup).Top = 0;
    this.lblDescription.Top = 0;
    this.lblDescription.Height = ((Control) this.txtFontName).Height;
    ((Control) this.btnLookup).Height = ((Control) this.txtFontName).Height;
    this.Height = ((Control) this.txtFontName).Height;
  }

  private void btnLookup_Click(object sender, EventArgs e)
  {
    FontDialog fontDialog = new FontDialog();
    fontDialog.Font = this.fnt;
    try
    {
      if (fontDialog.ShowDialog() != DialogResult.OK)
        return;
      this.fnt = fontDialog.Font;
      ((TextEditorControlBase) this.txtFontName).Text = this.FontToString(this.fnt);
    }
    finally
    {
      fontDialog.Dispose();
    }
  }

  public override string InputErrorMessage => string.Empty;

  private string FontToString(Font f)
  {
    return !Information.IsDBNull((object) f) ? $"{f.FontFamily.Name + ", "}{f.SizeInPoints.ToString()}pt., " + f.Style.ToString() : "";
  }

  private string FontConvert(Font f)
  {
    return !Information.IsDBNull((object) f) ? new FontConverter().ConvertToString((object) f) : "";
  }

  private Font FontConvert(string s)
  {
    return Information.IsDBNull((object) s) || Operators.CompareString(s, "", false) == 0 ? new Font("Arial", 8f, FontStyle.Regular) : (Font) new FontConverter().ConvertFromString(s);
  }
}
