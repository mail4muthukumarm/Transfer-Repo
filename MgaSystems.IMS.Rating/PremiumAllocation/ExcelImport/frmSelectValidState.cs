// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Rating.PremiumAllocation.ExcelImport.frmSelectValidState
// Assembly: MgaSystems.IMS.Rating, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 370B8F0A-FA1A-41D0-87BD-563CC23E9EA7
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Rating.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies.Rating.PremiumAllocation.ExcelImport;

public sealed class frmSelectValidState : Form
{
  private IContainer components;
  private Label Label2;
  private MGAComboBox cboStates;
  private Label lblOriginalState;
  private ErrorProvider err;
  private DataTable _dtStates;
  private bool _saved;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
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

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    Appearance appearance1 = new Appearance();
    UltraGridBand ultraGridBand = new UltraGridBand("", -1);
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance15 = new Appearance();
    this.lblOriginalState = new Label();
    this.Label2 = new Label();
    this.cboStates = new MGAComboBox();
    this.btnSave = new MGAButton();
    this.err = new ErrorProvider(this.components);
    ((ISupportInitialize) this.cboStates).BeginInit();
    ((ISupportInitialize) this.btnSave).BeginInit();
    ((ISupportInitialize) this.err).BeginInit();
    this.SuspendLayout();
    this.lblOriginalState.AutoSize = true;
    this.lblOriginalState.Font = new Font("Tahoma", 12f);
    this.lblOriginalState.Location = new Point(8, 16 /*0x10*/);
    this.lblOriginalState.Name = "lblOriginalState";
    this.lblOriginalState.Size = new Size(205, 19);
    this.lblOriginalState.TabIndex = 0;
    this.lblOriginalState.Text = "[state here] Not Recognized";
    this.Label2.Location = new Point(8, 56);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(464, 16 /*0x10*/);
    this.Label2.TabIndex = 1;
    this.Label2.Text = "This state was not recognized as a valid selection.   Please select the correct entry below:";
    this.cboStates.BorderStyle = (UIElementBorderStyle) 4;
    this.cboStates.CharacterCasing = CharacterCasing.Normal;
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.FromArgb(78, 122, 171);
    this.cboStates.DisplayLayout.Appearance = (AppearanceBase) appearance1;
    this.cboStates.DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand.ColHeadersVisible = false;
    this.cboStates.DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    this.cboStates.DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    this.cboStates.DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    appearance2.BackColor = SystemColors.ActiveBorder;
    appearance2.BackColor2 = SystemColors.ControlDark;
    appearance2.BackGradientStyle = (GradientStyle) 2;
    appearance2.BorderColor = SystemColors.Window;
    ((SpecialBoxBase) this.cboStates.DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance2;
    appearance3.ForeColor = SystemColors.GrayText;
    this.cboStates.DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance3;
    ((SpecialBoxBase) this.cboStates.DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    appearance4.BackColor = SystemColors.ControlLightLight;
    appearance4.BackColor2 = SystemColors.Control;
    appearance4.BackGradientStyle = (GradientStyle) 3;
    appearance4.ForeColor = SystemColors.GrayText;
    this.cboStates.DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance4;
    this.cboStates.DisplayLayout.MaxColScrollRegions = 1;
    this.cboStates.DisplayLayout.MaxRowScrollRegions = 1;
    appearance5.BackColor = SystemColors.Window;
    appearance5.ForeColor = SystemColors.ControlText;
    this.cboStates.DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance5;
    appearance6.BackColor = SystemColors.Highlight;
    appearance6.ForeColor = SystemColors.HighlightText;
    this.cboStates.DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance6;
    this.cboStates.DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    this.cboStates.DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 2;
    appearance7.BackColor = SystemColors.Window;
    this.cboStates.DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance7;
    appearance8.BorderColor = Color.Silver;
    appearance8.TextTrimming = (TextTrimming) 3;
    this.cboStates.DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance8;
    this.cboStates.DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    this.cboStates.DisplayLayout.Override.CellPadding = 0;
    appearance9.BackColor = SystemColors.Control;
    appearance9.BackColor2 = SystemColors.ControlDark;
    appearance9.BackGradientAlignment = (GradientAlignment) 1;
    appearance9.BackGradientStyle = (GradientStyle) 3;
    appearance9.BorderColor = SystemColors.Window;
    this.cboStates.DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance9;
    ((AppearanceBase) appearance10).TextHAlignAsString = "Left";
    this.cboStates.DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance10;
    this.cboStates.DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    this.cboStates.DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    appearance11.BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    appearance11.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this.cboStates.DisplayLayout.Override.HotTrackRowAppearance = (AppearanceBase) appearance11;
    appearance12.BackColor = SystemColors.Window;
    appearance12.BorderColor = Color.White;
    this.cboStates.DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance12;
    this.cboStates.DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    this.cboStates.DisplayLayout.Override.RowSpacingAfter = 1;
    appearance13.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance13.BorderColor = Color.FromArgb((int) byte.MaxValue, 214, 88);
    appearance13.ForeColor = Color.Black;
    this.cboStates.DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance13;
    appearance14.BackColor = SystemColors.ControlLight;
    this.cboStates.DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance14;
    scrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
    this.cboStates.DisplayLayout.ScrollBarLook = scrollBarLook;
    this.cboStates.DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    this.cboStates.DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    this.cboStates.DisplayLayout.ViewStyleBand = (ViewStyleBand) 2;
    this.cboStates.DisplayStyle = (EmbeddableElementDisplayStyle) 0;
    this.cboStates.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboStates).Location = new Point(8, 88);
    this.cboStates.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboStates).Name = "cboStates";
    ((Control) this.cboStates).Size = new Size(456, 21);
    ((Control) this.cboStates).TabIndex = 2;
    ((UltraControlBase) this.cboStates).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboStates).UseOsThemes = (DefaultableBoolean) 2;
    appearance15.BackColor = Color.FromArgb(248, 248, 248);
    appearance15.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance15.BackGradientStyle = (GradientStyle) 2;
    appearance15.BorderColor = Color.DarkGray;
    appearance15.ImageHAlign = (HAlign) 2;
    appearance15.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnSave).Appearance = (AppearanceBase) appearance15;
    ((Control) this.btnSave).Location = new Point(424, 120);
    ((Control) this.btnSave).Name = "btnSave";
    ((Control) this.btnSave).Size = new Size(40, 40);
    ((Control) this.btnSave).TabIndex = 3;
    this.btnSave.UseOSThemes = (DefaultableBoolean) 2;
    this.err.ContainerControl = (ContainerControl) this;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.ClientSize = new Size(498, 168);
    this.Controls.Add((Control) this.btnSave);
    this.Controls.Add((Control) this.cboStates);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.lblOriginalState);
    this.Font = new Font("Tahoma", 8.25f);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmSelectValidState);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Select Valid State";
    ((ISupportInitialize) this.cboStates).EndInit();
    ((ISupportInitialize) this.btnSave).EndInit();
    ((ISupportInitialize) this.err).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  internal bool Saved => this._saved;

  internal string SelectedStateID
  {
    get => this.cboStates.Value != null ? this.cboStates.Value.ToString() : string.Empty;
  }

  public frmSelectValidState(string invalidState, DataTable dtStates)
  {
    this.Load += new EventHandler(this.frmSelectValidState_Load);
    this.InitializeComponent();
    this._dtStates = dtStates;
    this.lblOriginalState.Text = $"\"{invalidState}\" Not Recognized";
    ((ControlBase) this.btnSave).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnSave).Appearance.Image = (object) ImageCache.Instance.Save;
  }

  private void frmSelectValidState_Load(object sender, EventArgs e)
  {
    MGAComboBox cboStates = this.cboStates;
    ((UltraGridBase) cboStates).DataSource = (object) this._dtStates;
    ((UltraDropDownBase) cboStates).DisplayMember = "State";
    ((UltraDropDownBase) cboStates).ValueMember = "StateID";
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
    if (this.cboStates.Value == null)
    {
      this.err.SetError((Control) this.cboStates, "Please select a state.");
    }
    else
    {
      this._saved = true;
      this.Close();
    }
  }
}
