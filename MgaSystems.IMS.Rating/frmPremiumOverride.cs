// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Rating.frmPremiumOverride
// Assembly: MgaSystems.IMS.Rating, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 370B8F0A-FA1A-41D0-87BD-563CC23E9EA7
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Rating.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.BusinessObjects;
using MGASystems.Data;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies.Rating;

public class frmPremiumOverride : Form
{
  private IContainer components;
  private Label lblPremium;
  private CurrencyTextBox txtPremiumOverride;
  private ErrorProvider err;
  private Label Label1;
  private Guid _QuoteOptionGuid;
  private double _overridePremium;
  private Quote _quote;
  private dsPremiumOverride.spGetQuoteOptionsForPremiumOverrideDataTable _dt;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private virtual MGAButton btnCancel
  {
    get => this._btnCancel;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnCancel_Click);
      MGAButton btnCancel1 = this._btnCancel;
      if (btnCancel1 != null)
        ((Control) btnCancel1).Click -= eventHandler;
      this._btnCancel = value;
      MGAButton btnCancel2 = this._btnCancel;
      if (btnCancel2 == null)
        return;
      ((Control) btnCancel2).Click += eventHandler;
    }
  }

  private virtual MGAButton btnOk
  {
    get => this._btnOk;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnOk_Click);
      MGAButton btnOk1 = this._btnOk;
      if (btnOk1 != null)
        ((Control) btnOk1).Click -= eventHandler;
      this._btnOk = value;
      MGAButton btnOk2 = this._btnOk;
      if (btnOk2 == null)
        return;
      ((Control) btnOk2).Click += eventHandler;
    }
  }

  private virtual MGAComboBox cboQuoteOptions
  {
    get => this._cboQuoteOptions;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.cboQuoteOptions_ValueChanged);
      MGAComboBox cboQuoteOptions1 = this._cboQuoteOptions;
      if (cboQuoteOptions1 != null)
        cboQuoteOptions1.ValueChanged -= eventHandler;
      this._cboQuoteOptions = value;
      MGAComboBox cboQuoteOptions2 = this._cboQuoteOptions;
      if (cboQuoteOptions2 == null)
        return;
      cboQuoteOptions2.ValueChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("Label2")]
  private virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboChargeCodes")]
  private virtual MGASimpleComboBox cboChargeCodes { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ds")]
  internal virtual dsPremiumOverride ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    UltraGridBand ultraGridBand = new UltraGridBand("spGetQuoteOptionsForPremiumOverride", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("Display");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("QuoteOptionGuid");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("OveriddenPremium");
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
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    Appearance appearance17 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    this.lblPremium = new Label();
    this.txtPremiumOverride = new CurrencyTextBox();
    this.btnCancel = new MGAButton();
    this.btnOk = new MGAButton();
    this.err = new ErrorProvider(this.components);
    this.cboQuoteOptions = new MGAComboBox();
    this.Label1 = new Label();
    this.cboChargeCodes = new MGASimpleComboBox();
    this.ds = new dsPremiumOverride();
    this.Label2 = new Label();
    ((ISupportInitialize) this.txtPremiumOverride).BeginInit();
    ((ISupportInitialize) this.btnCancel).BeginInit();
    ((ISupportInitialize) this.btnOk).BeginInit();
    ((ISupportInitialize) this.err).BeginInit();
    ((ISupportInitialize) this.cboQuoteOptions).BeginInit();
    ((ISupportInitialize) this.cboChargeCodes).BeginInit();
    this.ds.BeginInit();
    this.SuspendLayout();
    this.lblPremium.Location = new Point(8, 75);
    this.lblPremium.Name = "lblPremium";
    this.lblPremium.Size = new Size(104, 16 /*0x10*/);
    this.lblPremium.TabIndex = 0;
    this.lblPremium.Text = "Premium Override:";
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance1.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtPremiumOverride).Appearance = (AppearanceBase) appearance1;
    ((TextEditorControlBase) this.txtPremiumOverride).BackColor = Color.White;
    ((Control) this.txtPremiumOverride).Location = new Point(136, 73);
    this.txtPremiumOverride.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtPremiumOverride).Name = "txtPremiumOverride";
    ((Control) this.txtPremiumOverride).Size = new Size(100, 20);
    ((Control) this.txtPremiumOverride).TabIndex = 2;
    ((UltraControlBase) this.txtPremiumOverride).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtPremiumOverride).UseOsThemes = (DefaultableBoolean) 2;
    appearance2.BackColor = Color.FromArgb(248, 248, 248);
    appearance2.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance2.BackGradientStyle = (GradientStyle) 2;
    appearance2.BorderColor = Color.DarkGray;
    appearance2.ImageHAlign = (HAlign) 2;
    appearance2.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnCancel).Appearance = (AppearanceBase) appearance2;
    ((UltraButtonBase) this.btnCancel).DialogResult = DialogResult.Cancel;
    ((Control) this.btnCancel).Location = new Point(251, 114);
    ((Control) this.btnCancel).Name = "btnCancel";
    ((Control) this.btnCancel).Size = new Size(88, 24);
    ((Control) this.btnCancel).TabIndex = 4;
    ((ControlBase) this.btnCancel).Text = "Cancel";
    this.btnCancel.UseOSThemes = (DefaultableBoolean) 2;
    appearance3.BackColor = Color.FromArgb(248, 248, 248);
    appearance3.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance3.BackGradientStyle = (GradientStyle) 2;
    appearance3.BorderColor = Color.DarkGray;
    appearance3.ImageHAlign = (HAlign) 2;
    appearance3.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnOk).Appearance = (AppearanceBase) appearance3;
    ((Control) this.btnOk).Location = new Point(136, 114);
    ((Control) this.btnOk).Name = "btnOk";
    ((Control) this.btnOk).Size = new Size(88, 24);
    ((Control) this.btnOk).TabIndex = 3;
    ((ControlBase) this.btnOk).Text = "Ok";
    this.btnOk.UseOSThemes = (DefaultableBoolean) 2;
    this.err.ContainerControl = (ContainerControl) this;
    this.cboQuoteOptions.BorderStyle = (UIElementBorderStyle) 4;
    appearance4.BackColor = Color.White;
    appearance4.BorderColor = Color.FromArgb(78, 122, 171);
    this.cboQuoteOptions.DisplayLayout.Appearance = (AppearanceBase) appearance4;
    this.cboQuoteOptions.DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand.ColHeadersVisible = false;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Width = 101;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Width = 102;
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridColumn3.Width = 120;
    ultraGridBand.Columns.AddRange(new object[3]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3
    });
    this.cboQuoteOptions.DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    this.cboQuoteOptions.DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    this.cboQuoteOptions.DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    appearance5.BackColor = SystemColors.ActiveBorder;
    appearance5.BackColor2 = SystemColors.ControlDark;
    appearance5.BackGradientStyle = (GradientStyle) 2;
    appearance5.BorderColor = SystemColors.Window;
    ((SpecialBoxBase) this.cboQuoteOptions.DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance5;
    appearance6.ForeColor = SystemColors.GrayText;
    this.cboQuoteOptions.DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance6;
    ((SpecialBoxBase) this.cboQuoteOptions.DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    appearance7.BackColor = SystemColors.ControlLightLight;
    appearance7.BackColor2 = SystemColors.Control;
    appearance7.BackGradientStyle = (GradientStyle) 3;
    appearance7.ForeColor = SystemColors.GrayText;
    this.cboQuoteOptions.DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance7;
    this.cboQuoteOptions.DisplayLayout.MaxColScrollRegions = 1;
    this.cboQuoteOptions.DisplayLayout.MaxRowScrollRegions = 1;
    appearance8.BackColor = SystemColors.Window;
    appearance8.ForeColor = SystemColors.ControlText;
    this.cboQuoteOptions.DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance8;
    appearance9.BackColor = SystemColors.Highlight;
    appearance9.ForeColor = SystemColors.HighlightText;
    this.cboQuoteOptions.DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance9;
    this.cboQuoteOptions.DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    this.cboQuoteOptions.DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    appearance10.BackColor = SystemColors.Window;
    this.cboQuoteOptions.DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance10;
    appearance11.BorderColor = Color.Silver;
    appearance11.TextTrimming = (TextTrimming) 3;
    this.cboQuoteOptions.DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance11;
    this.cboQuoteOptions.DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    this.cboQuoteOptions.DisplayLayout.Override.CellPadding = 0;
    appearance12.BackColor = SystemColors.Control;
    appearance12.BackColor2 = SystemColors.ControlDark;
    appearance12.BackGradientAlignment = (GradientAlignment) 1;
    appearance12.BackGradientStyle = (GradientStyle) 3;
    appearance12.BorderColor = SystemColors.Window;
    this.cboQuoteOptions.DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance12;
    ((AppearanceBase) appearance13).TextHAlignAsString = "Left";
    this.cboQuoteOptions.DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance13;
    this.cboQuoteOptions.DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    this.cboQuoteOptions.DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    appearance14.BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    appearance14.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this.cboQuoteOptions.DisplayLayout.Override.HotTrackRowAppearance = (AppearanceBase) appearance14;
    appearance15.BackColor = SystemColors.Window;
    appearance15.BorderColor = Color.White;
    this.cboQuoteOptions.DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance15;
    this.cboQuoteOptions.DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    this.cboQuoteOptions.DisplayLayout.Override.RowSpacingAfter = 1;
    appearance16.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance16.BorderColor = Color.FromArgb((int) byte.MaxValue, 214, 88);
    appearance16.ForeColor = Color.Black;
    this.cboQuoteOptions.DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance16;
    appearance17.BackColor = SystemColors.ControlLight;
    this.cboQuoteOptions.DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance17;
    scrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
    this.cboQuoteOptions.DisplayLayout.ScrollBarLook = scrollBarLook;
    this.cboQuoteOptions.DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    this.cboQuoteOptions.DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    this.cboQuoteOptions.DisplayLayout.ViewStyleBand = (ViewStyleBand) 2;
    this.cboQuoteOptions.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboQuoteOptions).Location = new Point(136, 5);
    this.cboQuoteOptions.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboQuoteOptions).Name = "cboQuoteOptions";
    ((Control) this.cboQuoteOptions).Size = new Size(342, 21);
    ((Control) this.cboQuoteOptions).TabIndex = 1;
    ((UltraControlBase) this.cboQuoteOptions).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboQuoteOptions).UseOsThemes = (DefaultableBoolean) 2;
    this.Label1.Location = new Point(8, 7);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(96 /*0x60*/, 16 /*0x10*/);
    this.Label1.TabIndex = 5;
    this.Label1.Text = "Option:";
    this.cboChargeCodes.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.cboChargeCodes).DataMember = "tblFin_PolicyCharges";
    ((UltraGridBase) this.cboChargeCodes).DataSource = (object) this.ds;
    ((UltraDropDownBase) this.cboChargeCodes).DisplayMember = "ChargeName";
    this.cboChargeCodes.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboChargeCodes).DropDownWidth = 250;
    ((Control) this.cboChargeCodes).Location = new Point(136, 39);
    this.cboChargeCodes.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboChargeCodes).Name = "cboChargeCodes";
    ((Control) this.cboChargeCodes).Size = new Size(342, 21);
    ((Control) this.cboChargeCodes).TabIndex = 6;
    ((UltraControlBase) this.cboChargeCodes).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboChargeCodes).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboChargeCodes).ValueMember = "ChargeCode";
    this.ds.DataSetName = "dsPremiumOverride";
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.Label2.Location = new Point(8, 41);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(96 /*0x60*/, 16 /*0x10*/);
    this.Label2.TabIndex = 7;
    this.Label2.Text = "Premium Type:";
    this.AcceptButton = (IButtonControl) this.btnOk;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.CancelButton = (IButtonControl) this.btnCancel;
    this.ClientSize = new Size(497, 150);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.cboChargeCodes);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.cboQuoteOptions);
    this.Controls.Add((Control) this.btnOk);
    this.Controls.Add((Control) this.btnCancel);
    this.Controls.Add((Control) this.txtPremiumOverride);
    this.Controls.Add((Control) this.lblPremium);
    this.Font = new Font("Tahoma", 8.25f);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmPremiumOverride);
    this.ShowInTaskbar = false;
    this.Text = "Premium Override";
    ((ISupportInitialize) this.txtPremiumOverride).EndInit();
    ((ISupportInitialize) this.btnCancel).EndInit();
    ((ISupportInitialize) this.btnOk).EndInit();
    ((ISupportInitialize) this.err).EndInit();
    ((ISupportInitialize) this.cboQuoteOptions).EndInit();
    ((ISupportInitialize) this.cboChargeCodes).EndInit();
    this.ds.EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  public double OverridePremium
  {
    get => this._overridePremium;
    set => this._overridePremium = value;
  }

  public Quote Quote
  {
    get => this._quote;
    set => this._quote = value;
  }

  public Guid QuoteOptionGuid
  {
    get => this._QuoteOptionGuid;
    set => this._QuoteOptionGuid = value;
  }

  public int ChargeCode => Conversions.ToInteger(this.cboChargeCodes.Value);

  public frmPremiumOverride(Guid quoteGuid)
  {
    this._QuoteOptionGuid = new Guid();
    this._dt = new dsPremiumOverride.spGetQuoteOptionsForPremiumOverrideDataTable();
    this.InitializeComponent();
    this._quote = new Quote(quoteGuid);
    this.PopulateOptionDropDown();
    ((TextEditorControlBase) this.txtPremiumOverride).Value = (object) this._overridePremium;
  }

  private void PopulateOptionDropDown()
  {
    if (!this.Quote.IsBound)
      DefaultDatabase.LoadDataTable((DataTable) this._dt, "spGetQuoteOptionsForPremiumOverride", new object[2]
      {
        (object) "@QuoteGuid",
        (object) this._quote.QuoteGuid
      });
    if (this._dt == null || this._dt.Rows.Count == 0)
    {
      ((Control) this.cboQuoteOptions).Enabled = false;
      ((Control) this.txtPremiumOverride).Enabled = false;
      ((Control) this.btnOk).Enabled = false;
    }
    else
    {
      ((UltraGridBase) this.cboQuoteOptions).DataSource = (object) this._dt;
      ((UltraDropDownBase) this.cboQuoteOptions).DisplayMember = this._dt.DisplayColumn.ColumnName;
      ((UltraDropDownBase) this.cboQuoteOptions).ValueMember = this._dt.QuoteOptionGuidColumn.ColumnName;
      this.cboQuoteOptions.DisplayLayout.Bands[0].Columns[this._dt.QuoteOptionGuidColumn.ColumnName].Hidden = true;
      this.cboQuoteOptions.DisplayLayout.Bands[0].Columns[this._dt.OveriddenPremiumColumn.ColumnName].Hidden = true;
      this.cboQuoteOptions.ValueChanged += new EventHandler(this.cboQuoteOptions_ValueChanged);
      this.cboQuoteOptions.SelectedIndex = 0;
    }
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "tblFin_PolicyCharges"
    }, CommandType.Text, "SELECT ChargeCode, StateID + @D + ChargeName AS ChargeName, StateID FROM tblFin_PolicyCharges WITH (NOLOCK) WHERE ChargeType = @CT AND StateID = @StateID ORDER BY StateID + @D + ChargeName", new object[6]
    {
      (object) "@CT",
      (object) "P",
      (object) "@StateID",
      (object) this._quote.StateID,
      (object) "@D",
      (object) " - "
    });
  }

  private void cboQuoteOptions_ValueChanged(object sender, EventArgs e)
  {
    this._QuoteOptionGuid = (Guid) this.cboQuoteOptions.Value;
    this._overridePremium = Convert.ToDouble(this._dt.FindByQuoteOptionGuid(this._QuoteOptionGuid).OveriddenPremium);
    ((TextEditorControlBase) this.txtPremiumOverride).Value = (object) this._overridePremium;
  }

  private void btnOk_Click(object sender, EventArgs e)
  {
    this.err.SetError((Control) this.txtPremiumOverride, string.Empty);
    this.err.SetError((Control) this.cboChargeCodes, string.Empty);
    if (((TextEditorControlBase) this.txtPremiumOverride).Value == null || ((TextEditorControlBase) this.txtPremiumOverride).Value == DBNull.Value)
      this.err.SetError((Control) this.txtPremiumOverride, "Please enter a value.");
    else if (this.cboChargeCodes.Value == null || this.cboChargeCodes.Value == DBNull.Value)
    {
      this.err.SetError((Control) this.cboChargeCodes, "Please select a value.");
    }
    else
    {
      this.OverridePremium = Conversions.ToDouble(((TextEditorControlBase) this.txtPremiumOverride).Value);
      this.DialogResult = DialogResult.OK;
      this.Close();
    }
  }

  private void btnCancel_Click(object sender, EventArgs e)
  {
    this.OverridePremium = Conversions.ToDouble(((TextEditorControlBase) this.txtPremiumOverride).Value);
    this.DialogResult = DialogResult.Cancel;
    this.Close();
  }
}
