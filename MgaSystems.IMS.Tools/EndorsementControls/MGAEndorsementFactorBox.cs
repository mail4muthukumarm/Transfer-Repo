// Decompiled with JetBrains decompiler
// Type: MGASystems.Tools.EndorsementControls.MGAEndorsementFactorBox
// Assembly: MgaSystems.IMS.Tools, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1287D1AD-C908-42E9-BE8F-4574B2D0AB9E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Tools.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinEditors;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.Tools.EndorsementControls;

public sealed class MGAEndorsementFactorBox : UserControl
{
  private IContainer components;

  public MGAEndorsementFactorBox() => this.InitializeComponent();

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [field: AccessedThroughProperty("lblFactor")]
  internal virtual Label lblFactor { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGATextBox txtFactor
  {
    get => this._txtFactor;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.txtFactor_TextChanged);
      MGATextBox txtFactor1 = this._txtFactor;
      if (txtFactor1 != null)
        ((Control) txtFactor1).TextChanged -= eventHandler;
      this._txtFactor = value;
      MGATextBox txtFactor2 = this._txtFactor;
      if (txtFactor2 == null)
        return;
      ((Control) txtFactor2).TextChanged += eventHandler;
    }
  }

  internal virtual LinkLabel lnkModifyFactor
  {
    get => this._lnkModifyFactor;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkModifyFactor_Click);
      LinkLabel lnkModifyFactor1 = this._lnkModifyFactor;
      if (lnkModifyFactor1 != null)
        lnkModifyFactor1.LinkClicked -= clickedEventHandler;
      this._lnkModifyFactor = value;
      LinkLabel lnkModifyFactor2 = this._lnkModifyFactor;
      if (lnkModifyFactor2 == null)
        return;
      lnkModifyFactor2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual LinkLabel lnkEffectiveDate
  {
    get => this._lnkEffectiveDate;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.lnkEffectiveDate_TextChanged);
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkEffectiveDate_Click);
      LinkLabel lnkEffectiveDate1 = this._lnkEffectiveDate;
      if (lnkEffectiveDate1 != null)
      {
        lnkEffectiveDate1.TextChanged -= eventHandler;
        lnkEffectiveDate1.LinkClicked -= clickedEventHandler;
      }
      this._lnkEffectiveDate = value;
      LinkLabel lnkEffectiveDate2 = this._lnkEffectiveDate;
      if (lnkEffectiveDate2 == null)
        return;
      lnkEffectiveDate2.TextChanged += eventHandler;
      lnkEffectiveDate2.LinkClicked += clickedEventHandler;
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    Appearance appearance = new Appearance();
    this.lblFactor = new Label();
    this.txtFactor = new MGATextBox();
    this.lnkModifyFactor = new LinkLabel();
    this.Label1 = new Label();
    this.lnkEffectiveDate = new LinkLabel();
    ((ISupportInitialize) this.txtFactor).BeginInit();
    this.SuspendLayout();
    this.lblFactor.AutoSize = true;
    this.lblFactor.Location = new Point(0, 3);
    this.lblFactor.Name = "lblFactor";
    this.lblFactor.Size = new Size(35, 17);
    this.lblFactor.TabIndex = 0;
    this.lblFactor.Text = "Factor";
    ((Control) this.txtFactor).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    appearance.BorderColor = Color.Gray;
    ((TextEditorControlBase) this.txtFactor).Appearance = (AppearanceBase) appearance;
    ((Control) this.txtFactor).Location = new Point(56, 0);
    ((Control) this.txtFactor).Name = "txtFactor";
    ((EditorButtonControlBase) this.txtFactor).ReadOnly = true;
    ((Control) this.txtFactor).Size = new Size(88, 20);
    ((Control) this.txtFactor).TabIndex = 1;
    this.lnkModifyFactor.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.lnkModifyFactor.AutoSize = true;
    this.lnkModifyFactor.Location = new Point(152, 3);
    this.lnkModifyFactor.Name = "lnkModifyFactor";
    this.lnkModifyFactor.Size = new Size(79, 17);
    this.lnkModifyFactor.TabIndex = 2;
    this.lnkModifyFactor.TabStop = true;
    this.lnkModifyFactor.Text = "(modify factor)";
    this.Label1.AutoSize = true;
    this.Label1.Location = new Point(0, 32 /*0x20*/);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(47, 17);
    this.Label1.TabIndex = 3;
    this.Label1.Text = "Effective";
    this.lnkEffectiveDate.AutoSize = true;
    this.lnkEffectiveDate.Location = new Point(56, 32 /*0x20*/);
    this.lnkEffectiveDate.Name = "lnkEffectiveDate";
    this.lnkEffectiveDate.Size = new Size(0, 17);
    this.lnkEffectiveDate.TabIndex = 4;
    this.Controls.Add((Control) this.lnkEffectiveDate);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.lnkModifyFactor);
    this.Controls.Add((Control) this.txtFactor);
    this.Controls.Add((Control) this.lblFactor);
    this.Font = new Font("Tahoma", 8.25f);
    this.Name = nameof (MGAEndorsementFactorBox);
    this.Size = new Size(232, 48 /*0x30*/);
    ((ISupportInitialize) this.txtFactor).EndInit();
    this.ResumeLayout(false);
  }

  public event EventHandler EndorsementFactorTextChanged;

  public event EventHandler EffectiveDateTextChanged;

  public event EventHandler EndorsementFactorLinkClicked;

  public event EventHandler EffectiveDateLinkClicked;

  [Bindable(true)]
  public string EndorsementFactorText
  {
    get => ((TextEditorControlBase) this.txtFactor).Text;
    set => ((TextEditorControlBase) this.txtFactor).Text = value;
  }

  private void txtFactor_TextChanged(object sender, EventArgs e)
  {
    // ISSUE: reference to a compiler-generated field
    EventHandler textChangedEvent = this.EndorsementFactorTextChangedEvent;
    if (textChangedEvent == null)
      return;
    textChangedEvent(RuntimeHelpers.GetObjectValue(sender), e);
  }

  [Bindable(true)]
  public string EffectiveDateText
  {
    get => this.lnkEffectiveDate.Text;
    set => this.lnkEffectiveDate.Text = value;
  }

  private void lnkEffectiveDate_TextChanged(object sender, EventArgs e)
  {
    // ISSUE: reference to a compiler-generated field
    EventHandler textChangedEvent = this.EffectiveDateTextChangedEvent;
    if (textChangedEvent == null)
      return;
    textChangedEvent(RuntimeHelpers.GetObjectValue(sender), e);
  }

  private void lnkEffectiveDate_Click(object sender, LinkLabelLinkClickedEventArgs e)
  {
    // ISSUE: reference to a compiler-generated field
    EventHandler linkClickedEvent = this.EffectiveDateLinkClickedEvent;
    if (linkClickedEvent == null)
      return;
    linkClickedEvent(RuntimeHelpers.GetObjectValue(sender), (EventArgs) e);
  }

  private void lnkModifyFactor_Click(object sender, LinkLabelLinkClickedEventArgs e)
  {
    // ISSUE: reference to a compiler-generated field
    EventHandler linkClickedEvent = this.EndorsementFactorLinkClickedEvent;
    if (linkClickedEvent == null)
      return;
    linkClickedEvent(RuntimeHelpers.GetObjectValue(sender), (EventArgs) e);
  }
}
