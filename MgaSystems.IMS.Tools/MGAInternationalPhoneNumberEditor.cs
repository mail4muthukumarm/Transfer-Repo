// Decompiled with JetBrains decompiler
// Type: MGASystems.Tools.MGAInternationalPhoneNumberEditor
// Assembly: MgaSystems.IMS.Tools, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1287D1AD-C908-42E9-BE8F-4574B2D0AB9E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Tools.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinMaskedEdit;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.Data;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.Tools;

[DesignerGenerated]
public class MGAInternationalPhoneNumberEditor : UserControl
{
  private IContainer components;
  private MGAStyles _mgaStyle;
  private static DataTable dtPhoneGlobalization;

  public MGAInternationalPhoneNumberEditor()
  {
    this.Load += new EventHandler(this.MGAInternationalPhoneNumberEditor_Load);
    this._mgaStyle = MGAStyles.Gray;
    this.InitializeComponent();
  }

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
    this.comboCountryGlobalization = new UltraCombo();
    this.maskPhoneNumber = new MGAMaskedEdit();
    ((ISupportInitialize) this.comboCountryGlobalization).BeginInit();
    ((ISupportInitialize) this.maskPhoneNumber).BeginInit();
    this.SuspendLayout();
    appearance1.BackColor = SystemColors.Window;
    appearance1.BorderColor = SystemColors.InactiveCaption;
    ((UltraGridBase) this.comboCountryGlobalization).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.comboCountryGlobalization).DisplayLayout.AutoFitStyle = (AutoFitStyle) 2;
    ((UltraGridBase) this.comboCountryGlobalization).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.comboCountryGlobalization).DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    appearance2.BackColor = SystemColors.ActiveBorder;
    appearance2.BackColor2 = SystemColors.ControlDark;
    appearance2.BackGradientStyle = (GradientStyle) 2;
    appearance2.BorderColor = SystemColors.Window;
    ((SpecialBoxBase) ((UltraGridBase) this.comboCountryGlobalization).DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance2;
    appearance3.ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.comboCountryGlobalization).DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance3;
    ((SpecialBoxBase) ((UltraGridBase) this.comboCountryGlobalization).DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    appearance4.BackColor = SystemColors.ControlLightLight;
    appearance4.BackColor2 = SystemColors.Control;
    appearance4.BackGradientStyle = (GradientStyle) 3;
    appearance4.ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.comboCountryGlobalization).DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance4;
    ((UltraGridBase) this.comboCountryGlobalization).DisplayLayout.MaxColScrollRegions = 1;
    ((UltraGridBase) this.comboCountryGlobalization).DisplayLayout.MaxRowScrollRegions = 1;
    appearance5.BackColor = SystemColors.Window;
    appearance5.ForeColor = SystemColors.ControlText;
    ((UltraGridBase) this.comboCountryGlobalization).DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance5;
    appearance6.BackColor = SystemColors.Highlight;
    appearance6.ForeColor = SystemColors.HighlightText;
    ((UltraGridBase) this.comboCountryGlobalization).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance6;
    ((UltraGridBase) this.comboCountryGlobalization).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 2;
    ((UltraGridBase) this.comboCountryGlobalization).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 2;
    appearance7.BackColor = SystemColors.Window;
    ((UltraGridBase) this.comboCountryGlobalization).DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance7;
    appearance8.BorderColor = Color.Silver;
    appearance8.TextTrimming = (TextTrimming) 3;
    ((UltraGridBase) this.comboCountryGlobalization).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance8;
    ((UltraGridBase) this.comboCountryGlobalization).DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    ((UltraGridBase) this.comboCountryGlobalization).DisplayLayout.Override.CellPadding = 0;
    appearance9.BackColor = SystemColors.Control;
    appearance9.BackColor2 = SystemColors.ControlDark;
    appearance9.BackGradientAlignment = (GradientAlignment) 1;
    appearance9.BackGradientStyle = (GradientStyle) 3;
    appearance9.BorderColor = SystemColors.Window;
    ((UltraGridBase) this.comboCountryGlobalization).DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance9;
    ((AppearanceBase) appearance10).TextHAlignAsString = "Left";
    ((UltraGridBase) this.comboCountryGlobalization).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance10;
    ((UltraGridBase) this.comboCountryGlobalization).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    ((UltraGridBase) this.comboCountryGlobalization).DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    appearance11.BackColor = SystemColors.Window;
    appearance11.BorderColor = Color.Silver;
    ((UltraGridBase) this.comboCountryGlobalization).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance11;
    ((UltraGridBase) this.comboCountryGlobalization).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance12.BackColor = SystemColors.ControlLight;
    ((UltraGridBase) this.comboCountryGlobalization).DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance12;
    ((UltraGridBase) this.comboCountryGlobalization).DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    ((UltraGridBase) this.comboCountryGlobalization).DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    ((UltraGridBase) this.comboCountryGlobalization).DisplayLayout.ViewStyleBand = (ViewStyleBand) 2;
    this.comboCountryGlobalization.DisplayStyle = (EmbeddableElementDisplayStyle) 5;
    ((Control) this.comboCountryGlobalization).Dock = DockStyle.Left;
    ((UltraDropDownBase) this.comboCountryGlobalization).DropDownWidth = 250;
    ((Control) this.comboCountryGlobalization).Location = new Point(0, 0);
    ((Control) this.comboCountryGlobalization).Name = "comboCountryGlobalization";
    ((Control) this.comboCountryGlobalization).Size = new Size(38, 21);
    ((Control) this.comboCountryGlobalization).TabIndex = 1;
    ((UltraControlBase) this.comboCountryGlobalization).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboCountryGlobalization).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.maskPhoneNumber).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    appearance13.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.maskPhoneNumber.Appearance = (AppearanceBase) appearance13;
    ((Control) this.maskPhoneNumber).CausesValidation = false;
    this.maskPhoneNumber.DataMode = (MaskMode) 0;
    ((Control) this.maskPhoneNumber).Location = new Point(39, 0);
    this.maskPhoneNumber.MGAStyle = MGAStyles.Blue;
    ((Control) this.maskPhoneNumber).Name = "maskPhoneNumber";
    this.maskPhoneNumber.NonAutoSizeHeight = 20;
    ((Control) this.maskPhoneNumber).Size = new Size(144 /*0x90*/, 20);
    ((Control) this.maskPhoneNumber).TabIndex = 0;
    ((UltraControlBase) this.maskPhoneNumber).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.maskPhoneNumber).UseOsThemes = (DefaultableBoolean) 2;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.Controls.Add((Control) this.maskPhoneNumber);
    this.Controls.Add((Control) this.comboCountryGlobalization);
    this.Name = nameof (MGAInternationalPhoneNumberEditor);
    this.Size = new Size(184, 21);
    ((ISupportInitialize) this.comboCountryGlobalization).EndInit();
    ((ISupportInitialize) this.maskPhoneNumber).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  internal virtual UltraCombo comboCountryGlobalization
  {
    get => this._comboCountryGlobalization;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      InitializeLayoutEventHandler layoutEventHandler = new InitializeLayoutEventHandler(this.comboCountryGlobalization_InitializeLayout);
      InitializeRowEventHandler initializeRowEventHandler = new InitializeRowEventHandler(this.comboCountryGlobalization_InitializeRow);
      RowSelectedEventHandler selectedEventHandler = new RowSelectedEventHandler(this.comboCountryGlobalization_RowSelected);
      UltraCombo countryGlobalization1 = this._comboCountryGlobalization;
      if (countryGlobalization1 != null)
      {
        countryGlobalization1.InitializeLayout -= layoutEventHandler;
        countryGlobalization1.InitializeRow -= initializeRowEventHandler;
        countryGlobalization1.RowSelected -= selectedEventHandler;
      }
      this._comboCountryGlobalization = value;
      UltraCombo countryGlobalization2 = this._comboCountryGlobalization;
      if (countryGlobalization2 == null)
        return;
      countryGlobalization2.InitializeLayout += layoutEventHandler;
      countryGlobalization2.InitializeRow += initializeRowEventHandler;
      countryGlobalization2.RowSelected += selectedEventHandler;
    }
  }

  internal virtual MGAMaskedEdit maskPhoneNumber
  {
    get => this._maskPhoneNumber;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      UltraMaskedEdit.MaskValidationErrorEventHandler errorEventHandler = new UltraMaskedEdit.MaskValidationErrorEventHandler(this.maskPhoneNumber_MaskValidationError);
      MGAMaskedEdit maskPhoneNumber1 = this._maskPhoneNumber;
      if (maskPhoneNumber1 != null)
        maskPhoneNumber1.MaskValidationError -= errorEventHandler;
      this._maskPhoneNumber = value;
      MGAMaskedEdit maskPhoneNumber2 = this._maskPhoneNumber;
      if (maskPhoneNumber2 == null)
        return;
      maskPhoneNumber2.MaskValidationError += errorEventHandler;
    }
  }

  [DefaultValue(typeof (MGAStyles), "Blue")]
  public MGAStyles MGAStyle
  {
    get => this._mgaStyle;
    set
    {
      if (value == this._mgaStyle)
        return;
      this._mgaStyle = value;
      this.SetupAppearances();
    }
  }

  public object Value
  {
    get => this.maskPhoneNumber.Value;
    set
    {
      if (value == null)
        return;
      this.maskPhoneNumber.Value = RuntimeHelpers.GetObjectValue(value);
    }
  }

  public string ValueString
  {
    get
    {
      return this.maskPhoneNumber.Value != null ? this.maskPhoneNumber.Value.ToString() : string.Empty;
    }
  }

  public override string Text
  {
    get
    {
      return this.maskPhoneNumber.Value != null ? this.maskPhoneNumber.Value.ToString() : string.Empty;
    }
    set => this.maskPhoneNumber.Value = (object) value;
  }

  public string InputMask
  {
    get => this.maskPhoneNumber.InputMask;
    private set => this.maskPhoneNumber.InputMask = value;
  }

  public string CountryCode
  {
    get
    {
      return ((UltraDropDownBase) this.comboCountryGlobalization).SelectedRow != null ? ((UltraDropDownBase) this.comboCountryGlobalization).SelectedRow.Cells[nameof (CountryCode)].Value.ToString() : string.Empty;
    }
    set
    {
      if (string.IsNullOrEmpty(value))
        return;
      this.comboCountryGlobalization.Value = (object) value;
      this.InputMask = MGAInternationalPhoneNumberEditor.GetCountryInputMask(value);
    }
  }

  private void MGAInternationalPhoneNumberEditor_Load(object sender, EventArgs e)
  {
    if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
      return;
    this.LoadCountryGlobalization();
    this.maskPhoneNumber.PromptCharacterAppearance.ForeColor = Color.Gray;
  }

  public static string GetCountryInputMask(string countryCode)
  {
    if (MGAInternationalPhoneNumberEditor.dtPhoneGlobalization == null)
      MGAInternationalPhoneNumberEditor.dtPhoneGlobalization = DefaultDatabase.ExecuteDataTable("GetPhoneGlobalization");
    DataRow[] dataRowArray = MGAInternationalPhoneNumberEditor.dtPhoneGlobalization.Select($"CountryCode = '{countryCode}'");
    return dataRowArray.Length <= 0 ? "(###) ###-####" : dataRowArray[0]["PhoneInputMask"].ToString();
  }

  private void LoadCountryGlobalization()
  {
    if (string.IsNullOrEmpty(DefaultDatabase.ConnectionString))
      return;
    ((UltraGridBase) this.comboCountryGlobalization).DataSource = (object) DefaultDatabase.ExecuteDataTable("GetPhoneGlobalization");
    ((UltraDropDownBase) this.comboCountryGlobalization).DisplayMember = "FlagImage16";
    ((UltraDropDownBase) this.comboCountryGlobalization).ValueMember = "CountryCode";
    DataTable dataTable = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT * FROM tblSystemSettings WHERE [Setting] = @s", new object[2]
    {
      (object) "@s",
      (object) "GLOBALIZATION_DEFAULTCOUNTRY"
    });
    if (dataTable.Rows.Count == 1)
      this.comboCountryGlobalization.Value = (object) dataTable.Rows[0]["SettingValueString"].ToString();
    ((UltraDropDownBase) this.comboCountryGlobalization).DropDownWidth = 300;
  }

  private void comboCountryGlobalization_InitializeLayout(
    object sender,
    InitializeLayoutEventArgs e)
  {
    UltraGridBand band = ((UltraGridBase) this.comboCountryGlobalization).DisplayLayout.Bands[0];
    band.Columns["FlagImage16"].Style = (ColumnStyle) 27;
    band.Columns["FlagImage32"].Style = (ColumnStyle) 27;
    band.Columns["FlagImage32"].Width = 34;
    band.Columns["FlagImage16"].CellAppearance.ForeColor = Color.White;
    band.Columns["CountryName"].Width = 150;
    band.Columns["AdditionalDescription"].Width = 50;
    band.Columns["FlagImage16"].Hidden = true;
    band.Columns["RowId"].Hidden = true;
    band.Columns["CountryCode"].Hidden = true;
    band.Columns["PhoneInputMask"].Hidden = true;
    band.Columns["AdditionalDescription"].CellAppearance.ForeColor = Color.Gray;
    ((UltraDropDownBase) this.comboCountryGlobalization).DropDownWidth = 250;
    band.ColHeadersVisible = false;
    band.Override.DefaultRowHeight = 32 /*0x20*/;
  }

  private void comboCountryGlobalization_InitializeRow(object sender, InitializeRowEventArgs e)
  {
    e.Row.Cells["FlagImage16"].Appearance.Image = (object) this.GetImage((byte[]) e.Row.Cells["FlagImage16"].Value);
    e.Row.Cells["FlagImage16"].Appearance.ImageHAlign = (HAlign) 1;
    e.Row.Cells["FlagImage16"].Appearance.ImageVAlign = (VAlign) 1;
  }

  private Image GetImage(byte[] b) => Image.FromStream((Stream) new MemoryStream(b));

  private void SetupAppearances()
  {
    if (this.MGAStyle == MGAStyles.Blue)
      this.SetBlueAppearance();
    else
      this.SetGrayAppearance();
  }

  private void SetCommonAppearances()
  {
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    scrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
    Appearance appearance = new Appearance();
    ((UltraControlBase) this.comboCountryGlobalization).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboCountryGlobalization).UseOsThemes = (DefaultableBoolean) 2;
    this.comboCountryGlobalization.Appearance.ForeColor = Color.Black;
    UltraGridLayout displayLayout = ((UltraGridBase) this.comboCountryGlobalization).DisplayLayout;
    displayLayout.ScrollBarLook = scrollBarLook;
    displayLayout.Override.HotTrackRowAppearance = (AppearanceBase) appearance;
    displayLayout.Override.RowAppearance.BorderColor = Color.White;
    displayLayout.Appearance.BorderColor = Color.LightGray;
    displayLayout.Override.RowSpacingAfter = 1;
    displayLayout.BorderStyle = (UIElementBorderStyle) 4;
    displayLayout.AutoFitStyle = (AutoFitStyle) 1;
    displayLayout.Bands[0].ColHeadersVisible = false;
    displayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    displayLayout.Appearance.BackColor = Color.White;
    displayLayout.Override.SelectedRowAppearance.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    displayLayout.Override.SelectedRowAppearance.BorderColor = Color.FromArgb((int) byte.MaxValue, 214, 88);
    displayLayout.Override.SelectedRowAppearance.ForeColor = Color.Black;
  }

  private void SetGrayAppearance()
  {
    this.SetCommonAppearances();
    this.comboCountryGlobalization.Appearance.BorderColor = Color.Gray;
    AppearanceBase buttonAppearance = this.comboCountryGlobalization.ButtonAppearance;
    buttonAppearance.BackColor = Color.LightGray;
    buttonAppearance.BackColor2 = Color.White;
    buttonAppearance.BackGradientStyle = (GradientStyle) 2;
    buttonAppearance.BorderColor = Color.LightGray;
    buttonAppearance.ForeColor = Color.FromArgb(60, 60, 60);
  }

  private void SetBlueAppearance()
  {
    this.SetCommonAppearances();
    this.comboCountryGlobalization.Appearance.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    UltraCombo countryGlobalization = this.comboCountryGlobalization;
    countryGlobalization.BorderStyle = (UIElementBorderStyle) 4;
    countryGlobalization.CharacterCasing = CharacterCasing.Normal;
    AppearanceBase buttonAppearance = this.comboCountryGlobalization.ButtonAppearance;
    buttonAppearance.AlphaLevel = (short) 14;
    buttonAppearance.BackColor = Color.FromArgb(0, 0, 246, 253);
    buttonAppearance.BackColor2 = Color.FromArgb(133, 162, 221);
    buttonAppearance.BackColorAlpha = (Alpha) 2;
    buttonAppearance.BackGradientAlignment = (GradientAlignment) 4;
    buttonAppearance.BackGradientStyle = (GradientStyle) 5;
    buttonAppearance.BorderAlpha = (Alpha) 1;
    buttonAppearance.BorderColor = Color.FromArgb(78, 122, 171);
    buttonAppearance.ForeColor = Color.FromArgb(49, 85, 153);
    buttonAppearance.ForegroundAlpha = (Alpha) 2;
    ((UltraGridBase) this.comboCountryGlobalization).DisplayLayout.Appearance.BorderColor = Color.FromArgb(78, 122, 171);
  }

  private void comboCountryGlobalization_RowSelected(object sender, RowSelectedEventArgs e)
  {
    if (e.Row == null)
      return;
    if (e.Row.Cells["PhoneInputMask"].Value != null)
      this.maskPhoneNumber.InputMask = e.Row.Cells["PhoneInputMask"].Value.ToString();
    ((Control) this.maskPhoneNumber).Select();
    this.maskPhoneNumber.SelectionStart = 0;
    SendKeys.Send("{HOME}");
  }

  private void maskPhoneNumber_MaskValidationError(object sender, MaskValidationErrorEventArgs e)
  {
    e.RetainFocus = false;
  }

  public void ClearControl()
  {
    ((Control) this.comboCountryGlobalization).ResetText();
    this.maskPhoneNumber.Value = (object) null;
    this.maskPhoneNumber.Text = string.Empty;
  }
}
