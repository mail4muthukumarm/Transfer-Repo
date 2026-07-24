// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.Forms.Controls.HiddenValueMgaTextBox
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinMaskedEdit;
using MGASystems.Data;
using MGASystems.IMS.Accounting.Services.Forms.Utility;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.Forms.Controls;

public class HiddenValueMgaTextBox : UserControl
{
  private string _originalInputMask;
  private string _hiddenInputMask;
  private TextHider _textHider;
  private bool _isEditing;
  private BlockingRunner _maskSwapRunner = new BlockingRunner();
  private IContainer components;
  protected MGAMaskedEdit wrappedEdit;

  private TextHider TextHider
  {
    get
    {
      if (this._textHider == null)
        this._textHider = new TextHider()
        {
          VisibleSuffixCharacters = this.VisibleSuffixCharacters,
          HideCharacter = this.HideCharacter,
          IgnoreCharacters = this.IgnoreCharagers
        };
      return this._textHider;
    }
  }

  public string PlainText { get; private set; } = string.Empty;

  public char HideCharacter { get; set; } = '*';

  public char[] IgnoreCharagers { get; set; }

  public int VisibleSuffixCharacters { get; set; }

  public event EventHandler ValueChanged;

  public string InputMask
  {
    get => this.wrappedEdit.InputMask;
    set
    {
      this.wrappedEdit.InputMask = value;
      this._originalInputMask = value;
      this._hiddenInputMask = this._originalInputMask.Replace('#', '&').Replace('?', '&');
    }
  }

  public HiddenValueMgaTextBox() => this.InitializeComponent();

  public void SetPlainText(string text)
  {
    if (this._isEditing)
      return;
    this.wrappedEdit.InputMask = this._hiddenInputMask;
    ((Control) this.wrappedEdit).Text = this.TextHider.HideText(text);
    this.PlainText = text;
  }

  public void Clear()
  {
    ((Control) this.wrappedEdit).Text = string.Empty;
    this.PlainText = string.Empty;
  }

  private void wrappedEdit_Enter(object sender, EventArgs e)
  {
    this._maskSwapRunner.Run(new Action(this.UnHideText));
  }

  private void wrappedEdit_Leave(object sender, EventArgs e)
  {
    if (!this._isEditing)
      return;
    this._maskSwapRunner.Run(new Action(this.HideText));
  }

  private void HideText()
  {
    this.PlainText = ((Control) this.wrappedEdit).Text;
    this.wrappedEdit.InputMask = this._hiddenInputMask;
    ((Control) this.wrappedEdit).Text = this.TextHider.HideText(this.PlainText);
    this._isEditing = false;
  }

  private void UnHideText()
  {
    ((Control) this.wrappedEdit).Text = this.PlainText;
    this.wrappedEdit.InputMask = this._originalInputMask;
    this._isEditing = true;
  }

  private void wrappedEdit_TextChanged(object sender, EventArgs e)
  {
    if (this._maskSwapRunner.IsRunning)
      return;
    this.PlainText = ((Control) this.wrappedEdit).Text;
    EventHandler valueChanged = this.ValueChanged;
    if (valueChanged == null)
      return;
    valueChanged((object) this, e);
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    Appearance appearance = new Appearance();
    this.wrappedEdit = new MGAMaskedEdit();
    ((ISupportInitialize) this.wrappedEdit).BeginInit();
    this.SuspendLayout();
    ((AppearanceBase) appearance).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.wrappedEdit.Appearance = (AppearanceBase) appearance;
    this.wrappedEdit.DataMode = (MaskMode) 0;
    ((Control) this.wrappedEdit).Dock = DockStyle.Fill;
    this.wrappedEdit.EditAs = (EditAsType) 1;
    this.wrappedEdit.InputMask = "##-#######";
    ((Control) this.wrappedEdit).Location = new Point(0, 0);
    this.wrappedEdit.MGAStyle = MGAStyles.Blue;
    ((Control) this.wrappedEdit).Name = "wrappedEdit";
    this.wrappedEdit.NonAutoSizeHeight = 20;
    ((Control) this.wrappedEdit).Size = new Size(80 /*0x50*/, 20);
    ((Control) this.wrappedEdit).TabIndex = 26;
    ((UltraControlBase) this.wrappedEdit).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.wrappedEdit).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.wrappedEdit).TextChanged += new EventHandler(this.wrappedEdit_TextChanged);
    ((Control) this.wrappedEdit).Enter += new EventHandler(this.wrappedEdit_Enter);
    ((Control) this.wrappedEdit).Leave += new EventHandler(this.wrappedEdit_Leave);
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.Controls.Add((Control) this.wrappedEdit);
    this.Name = nameof (HiddenValueMgaTextBox);
    this.Size = new Size(80 /*0x50*/, 19);
    ((ISupportInitialize) this.wrappedEdit).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }
}
