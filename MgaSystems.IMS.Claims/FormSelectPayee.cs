// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.FormSelectPayee
// Assembly: MgaSystems.IMS.Claims, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FCD9D0B7-28CF-40B9-8EB7-297871E1AF5F
// Assembly location: F:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using MGASystems.Common;
using MGASystems.IMS.Claims.Properties;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Claims;

public class FormSelectPayee : FormBase
{
  private FormClaimant _claimantForm;
  protected FormSelectPayee.PayeeType _selectedPayeeType;
  protected Guid _payeeGuid;
  protected string _payeeName;
  protected bool _hasClaimantAttorney;
  protected bool _hasDefenseAttorney;
  private IContainer components;
  protected UltraOptionSet optionSetPayee;
  protected MGAButton buttonOk;
  protected MGAButton buttonCancel;
  protected MGAButton buttonSelect;
  protected MGATextBox textPayee;

  public FormSelectPayee()
  {
    this.InitializeComponent();
    this._selectedPayeeType = FormSelectPayee.PayeeType.None;
  }

  public FormSelectPayee(bool hasClaimantAttorney, bool hasDefenseAttorney)
  {
    this.InitializeComponent();
    this._selectedPayeeType = FormSelectPayee.PayeeType.None;
    this._hasClaimantAttorney = hasClaimantAttorney;
    this._hasDefenseAttorney = hasDefenseAttorney;
  }

  public FormClaimant ClaimantForm => this._claimantForm;

  public FormSelectPayee.PayeeType SelectedPayeeType => this._selectedPayeeType;

  public Guid PayeeGuid => this._payeeGuid;

  public string PayeeName => this._payeeName;

  private void buttonCancel_Click(object sender, EventArgs e)
  {
    this.DialogResult = DialogResult.Cancel;
    this.Close();
  }

  private void buttonSelect_Click(object sender, EventArgs e) => this.SelectPayee();

  protected virtual void SelectPayee()
  {
    using (FormSearchEntity formSearchEntity = new FormSearchEntity(Utility.SearchEntityTypes.All))
    {
      if (formSearchEntity.ShowDialog() == DialogResult.OK)
      {
        this._payeeGuid = formSearchEntity.EntityGuid;
        this._payeeName = formSearchEntity.EntityName;
        ((Control) this.textPayee).Text = formSearchEntity.EntityName;
      }
      else
      {
        this._payeeGuid = Guid.Empty;
        this._payeeName = string.Empty;
        ((Control) this.textPayee).Text = string.Empty;
      }
    }
  }

  protected virtual void optionSetPayee_ValueChanged(object sender, EventArgs e)
  {
    if (this.optionSetPayee.Value.ToString() == "CLAIMANTATTORNEY" && !this._hasClaimantAttorney)
    {
      int num = (int) MessageBox.Show(Resources.CLAIMANTPAYEE_NOCLAIMANTATTORNEY, Resources.ERROR_REQUIREDFIELD_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      this.optionSetPayee.Value = (object) "CLAIMANT";
    }
    if (this.optionSetPayee.Value.ToString() == "DEFENSEATTORNEY" && !this._hasDefenseAttorney)
    {
      int num = (int) MessageBox.Show(Resources.CLAIMANTPAYEE_NODEFENSEATTORNEY, Resources.ERROR_REQUIREDFIELD_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      this.optionSetPayee.Value = (object) "CLAIMANT";
    }
    ((Control) this.textPayee).Enabled = this.optionSetPayee.Value.ToString() == "OTHER";
    ((Control) this.buttonSelect).Enabled = this.optionSetPayee.Value.ToString() == "OTHER";
  }

  protected virtual void buttonOk_Click(object sender, EventArgs e)
  {
    switch (this.optionSetPayee.Value.ToString())
    {
      case "CLAIMANT":
        this._selectedPayeeType = FormSelectPayee.PayeeType.Claimant;
        break;
      case "CLAIMANTATTORNEY":
        this._selectedPayeeType = FormSelectPayee.PayeeType.ClaimantAttorney;
        break;
      case "DEFENSEATTORNEY":
        this._selectedPayeeType = FormSelectPayee.PayeeType.DefenseAttorney;
        break;
      case "INSURED":
        this._selectedPayeeType = FormSelectPayee.PayeeType.Insured;
        break;
      case "OTHER":
        this._selectedPayeeType = FormSelectPayee.PayeeType.Other;
        break;
      default:
        this._selectedPayeeType = FormSelectPayee.PayeeType.None;
        break;
    }
    this.DialogResult = DialogResult.OK;
    this.Close();
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
    ValueListItem valueListItem1 = new ValueListItem();
    ValueListItem valueListItem2 = new ValueListItem();
    ValueListItem valueListItem3 = new ValueListItem();
    ValueListItem valueListItem4 = new ValueListItem();
    ValueListItem valueListItem5 = new ValueListItem();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    this.optionSetPayee = new UltraOptionSet();
    this.buttonOk = new MGAButton();
    this.buttonCancel = new MGAButton();
    this.buttonSelect = new MGAButton();
    this.textPayee = new MGATextBox();
    ((ISupportInitialize) this.optionSetPayee).BeginInit();
    ((ISupportInitialize) this.buttonOk).BeginInit();
    ((ISupportInitialize) this.buttonCancel).BeginInit();
    ((ISupportInitialize) this.buttonSelect).BeginInit();
    ((ISupportInitialize) this.textPayee).BeginInit();
    this.SuspendLayout();
    ((AppearanceBase) appearance1).BorderColor = Color.Transparent;
    this.optionSetPayee.Appearance = (AppearanceBase) appearance1;
    ((Control) this.optionSetPayee).BackColor = Color.Transparent;
    this.optionSetPayee.BackColorInternal = Color.Transparent;
    this.optionSetPayee.CheckedIndex = 0;
    this.optionSetPayee.GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007RadioButtonGlyphInfo;
    valueListItem1.DataValue = (object) "CLAIMANT";
    valueListItem1.DisplayText = "Claimant";
    valueListItem2.DataValue = (object) "CLAIMANTATTORNEY";
    valueListItem2.DisplayText = "Claimant Attorney";
    valueListItem3.DataValue = (object) "DEFENSEATTORNEY";
    valueListItem3.DisplayText = "Defense Attorney";
    valueListItem4.DataValue = (object) "INSURED";
    valueListItem4.DisplayText = "Insured";
    valueListItem5.DataValue = (object) "OTHER";
    valueListItem5.DisplayText = "Other (Select)";
    this.optionSetPayee.Items.AddRange(new ValueListItem[5]
    {
      valueListItem1,
      valueListItem2,
      valueListItem3,
      valueListItem4,
      valueListItem5
    });
    this.optionSetPayee.ItemSpacingVertical = 3;
    ((Control) this.optionSetPayee).Location = new Point(11, 12);
    ((Control) this.optionSetPayee).Name = "optionSetPayee";
    ((Control) this.optionSetPayee).Size = new Size(128 /*0x80*/, 93);
    ((Control) this.optionSetPayee).TabIndex = 0;
    ((Control) this.optionSetPayee).Text = "Claimant";
    ((UltraControlBase) this.optionSetPayee).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.optionSetPayee).UseOsThemes = (DefaultableBoolean) 2;
    this.optionSetPayee.ValueChanged += new EventHandler(this.optionSetPayee_ValueChanged);
    ((AppearanceBase) appearance2).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance2).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance2).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance2).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance2).Image = (object) Resources.Add;
    ((AppearanceBase) appearance2).ImageBackgroundStyle = (ImageBackgroundStyle) 1;
    ((AppearanceBase) appearance2).ImageHAlign = (HAlign) 1;
    ((AppearanceBase) appearance2).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonOk).Appearance = (AppearanceBase) appearance2;
    ((Control) this.buttonOk).Location = new Point(211, 117);
    ((Control) this.buttonOk).Name = "buttonOk";
    ((Control) this.buttonOk).Size = new Size(83, 28);
    ((Control) this.buttonOk).TabIndex = 3;
    ((Control) this.buttonOk).Text = "Save";
    ((UltraControlBase) this.buttonOk).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonOk).Click += new EventHandler(this.buttonOk_Click);
    ((AppearanceBase) appearance3).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance3).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance3).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance3).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance3).Image = (object) Resources.CatastropheCodeSmall;
    ((AppearanceBase) appearance3).ImageHAlign = (HAlign) 1;
    ((AppearanceBase) appearance3).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonCancel).Appearance = (AppearanceBase) appearance3;
    ((UltraButtonBase) this.buttonCancel).DialogResult = DialogResult.Cancel;
    ((Control) this.buttonCancel).Location = new Point(300, 117);
    ((Control) this.buttonCancel).Name = "buttonCancel";
    ((Control) this.buttonCancel).Size = new Size(83, 28);
    ((Control) this.buttonCancel).TabIndex = 4;
    ((Control) this.buttonCancel).Text = "Cancel";
    ((UltraControlBase) this.buttonCancel).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonCancel).Click += new EventHandler(this.buttonCancel_Click);
    ((AppearanceBase) appearance4).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance4).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance4).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance4).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance4).Image = (object) Resources.SearchClaimSmall;
    ((AppearanceBase) appearance4).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonSelect).Appearance = (AppearanceBase) appearance4;
    ((Control) this.buttonSelect).Enabled = false;
    ((Control) this.buttonSelect).Location = new Point(313, 86);
    ((Control) this.buttonSelect).Name = "buttonSelect";
    ((Control) this.buttonSelect).Size = new Size(70, 21);
    ((Control) this.buttonSelect).TabIndex = 2;
    ((Control) this.buttonSelect).Text = "Select...";
    ((UltraControlBase) this.buttonSelect).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonSelect).Click += new EventHandler(this.buttonSelect_Click);
    ((AppearanceBase) appearance5).BackColor = Color.White;
    ((AppearanceBase) appearance5).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance5).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textPayee).Appearance = (AppearanceBase) appearance5;
    ((Control) this.textPayee).BackColor = Color.White;
    ((Control) this.textPayee).Enabled = false;
    ((Control) this.textPayee).Location = new Point(114, 86);
    this.textPayee.MGAStyle = (MGAStyles) 2;
    ((Control) this.textPayee).Name = "textPayee";
    ((EditorButtonControlBase) this.textPayee).ReadOnly = true;
    ((Control) this.textPayee).Size = new Size(193, 20);
    ((Control) this.textPayee).TabIndex = 1;
    ((UltraControlBase) this.textPayee).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textPayee).UseOsThemes = (DefaultableBoolean) 2;
    this.AcceptButton = (IButtonControl) this.buttonOk;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.CancelButton = (IButtonControl) this.buttonCancel;
    this.ClientSize = new Size(395, 154);
    this.ControlBox = false;
    this.Controls.Add((Control) this.textPayee);
    this.Controls.Add((Control) this.buttonSelect);
    this.Controls.Add((Control) this.buttonCancel);
    this.Controls.Add((Control) this.buttonOk);
    this.Controls.Add((Control) this.optionSetPayee);
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.Name = nameof (FormSelectPayee);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Payee Selection";
    ((ISupportInitialize) this.optionSetPayee).EndInit();
    ((ISupportInitialize) this.buttonOk).EndInit();
    ((ISupportInitialize) this.buttonCancel).EndInit();
    ((ISupportInitialize) this.buttonSelect).EndInit();
    ((ISupportInitialize) this.textPayee).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  public enum PayeeType
  {
    None,
    Claimant,
    ClaimantAttorney,
    DefenseAttorney,
    Insured,
    Other,
  }
}
