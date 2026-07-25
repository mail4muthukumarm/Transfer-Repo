// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Rating.FormCopyRenewalDrivers
// Assembly: MgaSystems.IMS.Rating, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 370B8F0A-FA1A-41D0-87BD-563CC23E9EA7
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Rating.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.Common;
using MGASystems.Data;
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

[DesignerGenerated]
public class FormCopyRenewalDrivers : Form
{
  private IContainer components;
  private readonly Guid _QuoteGuid;
  private readonly int _ControlNo;

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
    UltraGridBand ultraGridBand1 = new UltraGridBand("lstDriverStatusInfo", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("ID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("Status");
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
    UltraGridBand ultraGridBand2 = new UltraGridBand("lstStates", -1);
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("StateID");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("State");
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    Appearance appearance17 = new Appearance();
    Appearance appearance18 = new Appearance();
    Appearance appearance19 = new Appearance();
    Appearance appearance20 = new Appearance();
    Appearance appearance21 = new Appearance();
    Appearance appearance22 = new Appearance();
    Appearance appearance23 = new Appearance();
    Appearance appearance24 = new Appearance();
    Appearance appearance25 = new Appearance();
    UltraGridBand ultraGridBand3 = new UltraGridBand("tblDriverInfo", -1);
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("FirstName");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("LastName");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("DOB");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("LicenseNumber");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("StateID");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("NumberOfPoints");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("FullPartTime", -1, (object) "ddFullPartTime");
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("CopyOver");
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("DriverID");
    Appearance appearance26 = new Appearance();
    Appearance appearance27 = new Appearance();
    Appearance appearance28 = new Appearance();
    Appearance appearance29 = new Appearance();
    Appearance appearance30 = new Appearance();
    Appearance appearance31 = new Appearance();
    Appearance appearance32 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance33 = new Appearance();
    Appearance appearance34 = new Appearance();
    this.btnSave = new Button();
    this.ddFullPartTime = new UltraDropDown();
    this.ds = new dsDriverRenewal();
    this.uddState = new UltraDropDown();
    this.ugDrivers = new UltraGrid();
    ((ISupportInitialize) this.ddFullPartTime).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.uddState).BeginInit();
    ((ISupportInitialize) this.ugDrivers).BeginInit();
    this.SuspendLayout();
    this.btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.btnSave.FlatStyle = FlatStyle.System;
    this.btnSave.Location = new Point(672, 246);
    this.btnSave.Name = "btnSave";
    this.btnSave.Size = new Size(44, 44);
    this.btnSave.TabIndex = 8;
    this.btnSave.Text = "Import";
    this.btnSave.UseVisualStyleBackColor = true;
    ((UltraGridBase) this.ddFullPartTime).DataMember = "lstDriverStatusInfo";
    ((UltraGridBase) this.ddFullPartTime).DataSource = (object) this.ds;
    appearance1.BackColor = SystemColors.Window;
    appearance1.BorderColor = SystemColors.InactiveCaption;
    ((UltraGridBase) this.ddFullPartTime).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridBand1.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2
    });
    ((UltraGridBase) this.ddFullPartTime).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.ddFullPartTime).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.ddFullPartTime).DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    appearance2.BackColor = SystemColors.ActiveBorder;
    appearance2.BackColor2 = SystemColors.ControlDark;
    appearance2.BackGradientStyle = (GradientStyle) 2;
    appearance2.BorderColor = SystemColors.Window;
    ((SpecialBoxBase) ((UltraGridBase) this.ddFullPartTime).DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance2;
    appearance3.BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    appearance3.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    appearance3.ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.ddFullPartTime).DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance3;
    ((SpecialBoxBase) ((UltraGridBase) this.ddFullPartTime).DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    appearance4.BackColor = SystemColors.ControlLightLight;
    appearance4.BackColor2 = SystemColors.Control;
    appearance4.BackGradientStyle = (GradientStyle) 3;
    appearance4.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    appearance4.ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.ddFullPartTime).DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance4;
    ((UltraGridBase) this.ddFullPartTime).DisplayLayout.MaxColScrollRegions = 1;
    ((UltraGridBase) this.ddFullPartTime).DisplayLayout.MaxRowScrollRegions = 1;
    appearance5.BackColor = SystemColors.Window;
    appearance5.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    appearance5.ForeColor = SystemColors.ControlText;
    ((UltraGridBase) this.ddFullPartTime).DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance5;
    appearance6.BackColor = SystemColors.Highlight;
    appearance6.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    appearance6.ForeColor = SystemColors.HighlightText;
    ((UltraGridBase) this.ddFullPartTime).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance6;
    ((UltraGridBase) this.ddFullPartTime).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 2;
    ((UltraGridBase) this.ddFullPartTime).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 2;
    appearance7.BackColor = SystemColors.Window;
    appearance7.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    ((UltraGridBase) this.ddFullPartTime).DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance7;
    appearance8.BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    appearance8.BorderColor = Color.Silver;
    appearance8.TextTrimming = (TextTrimming) 3;
    ((UltraGridBase) this.ddFullPartTime).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance8;
    ((UltraGridBase) this.ddFullPartTime).DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    ((UltraGridBase) this.ddFullPartTime).DisplayLayout.Override.CellPadding = 0;
    appearance9.BackColor = SystemColors.Control;
    appearance9.BackColor2 = SystemColors.ControlDark;
    appearance9.BackGradientAlignment = (GradientAlignment) 1;
    appearance9.BackGradientStyle = (GradientStyle) 3;
    appearance9.BorderColor = SystemColors.Window;
    ((UltraGridBase) this.ddFullPartTime).DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance9;
    appearance10.BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    appearance10.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    ((AppearanceBase) appearance10).TextHAlignAsString = "Left";
    ((UltraGridBase) this.ddFullPartTime).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance10;
    ((UltraGridBase) this.ddFullPartTime).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    ((UltraGridBase) this.ddFullPartTime).DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    appearance11.BackColor = SystemColors.Window;
    appearance11.BorderColor = Color.Silver;
    ((UltraGridBase) this.ddFullPartTime).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance11;
    ((UltraGridBase) this.ddFullPartTime).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance12.BackColor = SystemColors.ControlLight;
    appearance12.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    ((UltraGridBase) this.ddFullPartTime).DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance12;
    ((UltraGridBase) this.ddFullPartTime).DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    ((UltraGridBase) this.ddFullPartTime).DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    ((UltraGridBase) this.ddFullPartTime).DisplayLayout.ViewStyleBand = (ViewStyleBand) 2;
    ((UltraDropDownBase) this.ddFullPartTime).DisplayMember = "Status";
    ((Control) this.ddFullPartTime).Location = new Point(69, 99);
    ((Control) this.ddFullPartTime).Name = "ddFullPartTime";
    ((Control) this.ddFullPartTime).Size = new Size(96 /*0x60*/, 58);
    ((Control) this.ddFullPartTime).TabIndex = 7;
    ((UltraDropDownBase) this.ddFullPartTime).ValueMember = "ID";
    ((Control) this.ddFullPartTime).Visible = false;
    this.ds.DataSetName = "dsDriverRenewal";
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((UltraGridBase) this.uddState).DataMember = "lstStates";
    ((UltraGridBase) this.uddState).DataSource = (object) this.ds;
    appearance13.BackColor = SystemColors.Window;
    appearance13.BorderColor = SystemColors.InactiveCaption;
    ((UltraGridBase) this.uddState).DisplayLayout.Appearance = (AppearanceBase) appearance13;
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn3.Header.VisiblePosition = 0;
    ultraGridColumn4.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn4.Header.VisiblePosition = 1;
    ultraGridBand2.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn3,
      (object) ultraGridColumn4
    });
    ((UltraGridBase) this.uddState).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.uddState).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.uddState).DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    appearance14.BackColor = SystemColors.ActiveBorder;
    appearance14.BackColor2 = SystemColors.ControlDark;
    appearance14.BackGradientStyle = (GradientStyle) 2;
    appearance14.BorderColor = SystemColors.Window;
    ((SpecialBoxBase) ((UltraGridBase) this.uddState).DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance14;
    appearance15.BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    appearance15.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    appearance15.ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.uddState).DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance15;
    ((SpecialBoxBase) ((UltraGridBase) this.uddState).DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    appearance16.BackColor = SystemColors.ControlLightLight;
    appearance16.BackColor2 = SystemColors.Control;
    appearance16.BackGradientStyle = (GradientStyle) 3;
    appearance16.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    appearance16.ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.uddState).DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance16;
    ((UltraGridBase) this.uddState).DisplayLayout.MaxColScrollRegions = 1;
    ((UltraGridBase) this.uddState).DisplayLayout.MaxRowScrollRegions = 1;
    appearance17.BackColor = SystemColors.Window;
    appearance17.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    appearance17.ForeColor = SystemColors.ControlText;
    ((UltraGridBase) this.uddState).DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance17;
    appearance18.BackColor = SystemColors.Highlight;
    appearance18.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    appearance18.ForeColor = SystemColors.HighlightText;
    ((UltraGridBase) this.uddState).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance18;
    ((UltraGridBase) this.uddState).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 2;
    ((UltraGridBase) this.uddState).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 2;
    appearance19.BackColor = SystemColors.Window;
    appearance19.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    ((UltraGridBase) this.uddState).DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance19;
    appearance20.BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    appearance20.BorderColor = Color.Silver;
    appearance20.TextTrimming = (TextTrimming) 3;
    ((UltraGridBase) this.uddState).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance20;
    ((UltraGridBase) this.uddState).DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    ((UltraGridBase) this.uddState).DisplayLayout.Override.CellPadding = 0;
    appearance21.BackColor = SystemColors.Control;
    appearance21.BackColor2 = SystemColors.ControlDark;
    appearance21.BackGradientAlignment = (GradientAlignment) 1;
    appearance21.BackGradientStyle = (GradientStyle) 3;
    appearance21.BorderColor = SystemColors.Window;
    ((UltraGridBase) this.uddState).DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance21;
    appearance22.BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    appearance22.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    ((AppearanceBase) appearance22).TextHAlignAsString = "Left";
    ((UltraGridBase) this.uddState).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance22;
    ((UltraGridBase) this.uddState).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    ((UltraGridBase) this.uddState).DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    appearance23.BackColor = SystemColors.Window;
    appearance23.BorderColor = Color.Silver;
    ((UltraGridBase) this.uddState).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance23;
    ((UltraGridBase) this.uddState).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance24.BackColor = SystemColors.ControlLight;
    appearance24.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    ((UltraGridBase) this.uddState).DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance24;
    ((UltraGridBase) this.uddState).DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    ((UltraGridBase) this.uddState).DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    ((UltraGridBase) this.uddState).DisplayLayout.ViewStyleBand = (ViewStyleBand) 2;
    ((UltraDropDownBase) this.uddState).DisplayMember = "State";
    ((Control) this.uddState).Location = new Point(286, 99);
    ((Control) this.uddState).Name = "uddState";
    ((Control) this.uddState).Size = new Size(96 /*0x60*/, 58);
    ((Control) this.uddState).TabIndex = 6;
    ((UltraDropDownBase) this.uddState).ValueMember = "StateID";
    ((Control) this.uddState).Visible = false;
    ((Control) this.ugDrivers).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.ugDrivers).DataMember = "tblDriverInfo";
    ((UltraGridBase) this.ugDrivers).DataSource = (object) this.ds;
    appearance25.BackColor = Color.White;
    appearance25.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ugDrivers).DisplayLayout.Appearance = (AppearanceBase) appearance25;
    ((UltraGridBase) this.ugDrivers).DisplayLayout.AutoFitStyle = (AutoFitStyle) 2;
    ultraGridColumn5.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn5.CellActivation = (Activation) 3;
    ultraGridColumn5.Header.VisiblePosition = 0;
    ultraGridColumn6.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn6.CellActivation = (Activation) 3;
    ultraGridColumn6.Header.VisiblePosition = 1;
    ultraGridColumn7.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn7.CellActivation = (Activation) 3;
    ultraGridColumn7.Header.VisiblePosition = 2;
    ultraGridColumn7.Width = 65;
    ultraGridColumn8.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn8.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn8.Header).Caption = "License #";
    ultraGridColumn8.Header.VisiblePosition = 3;
    ultraGridColumn8.Width = 69;
    ultraGridColumn9.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn9.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn9.Header).Caption = "State";
    ultraGridColumn9.Header.VisiblePosition = 4;
    ultraGridColumn10.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn10.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn10.Header).Caption = "# Points";
    ultraGridColumn10.Header.VisiblePosition = 5;
    ultraGridColumn10.Width = 70;
    ultraGridColumn11.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn11.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn11.Header).Caption = "Full or Part Time";
    ultraGridColumn11.Header.VisiblePosition = 6;
    ultraGridColumn11.Style = (ColumnStyle) 6;
    ultraGridColumn12.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn12.Header).Caption = "Copy Over";
    ultraGridColumn12.Header.VisiblePosition = 7;
    ultraGridColumn13.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn13.Header.VisiblePosition = 8;
    ultraGridColumn13.Hidden = true;
    ultraGridBand3.Columns.AddRange(new object[9]
    {
      (object) ultraGridColumn5,
      (object) ultraGridColumn6,
      (object) ultraGridColumn7,
      (object) ultraGridColumn8,
      (object) ultraGridColumn9,
      (object) ultraGridColumn10,
      (object) ultraGridColumn11,
      (object) ultraGridColumn12,
      (object) ultraGridColumn13
    });
    ((UltraGridBase) this.ugDrivers).DisplayLayout.BandsSerializer.Add((object) ultraGridBand3);
    ((UltraGridBase) this.ugDrivers).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance26.BackColor = Color.LightSteelBlue;
    appearance26.FontData.SizeInPoints = 10f;
    appearance26.ForeColor = Color.Black;
    ((UltraGridBase) this.ugDrivers).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance26;
    appearance27.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance27.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance27.ForeColor = Color.Black;
    ((UltraGridBase) this.ugDrivers).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance27;
    ((UltraGridBase) this.ugDrivers).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.ugDrivers).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.ugDrivers).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    appearance28.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugDrivers).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance28;
    appearance29.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ugDrivers).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance29;
    ((UltraGridBase) this.ugDrivers).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.ugDrivers).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance30.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ugDrivers).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance30;
    appearance31.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugDrivers).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance31;
    ((UltraGridBase) this.ugDrivers).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance32.BackColor = Color.Transparent;
    appearance32.ForeColor = Color.Black;
    ((UltraGridBase) this.ugDrivers).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance32;
    appearance33.BackColor = Color.WhiteSmoke;
    appearance33.BorderColor = Color.Silver;
    scrollBarLook.ButtonAppearance = (AppearanceBase) appearance33;
    appearance34.BackColor = Color.White;
    scrollBarLook.TrackAppearance = (AppearanceBase) appearance34;
    ((UltraGridBase) this.ugDrivers).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((UltraGridBase) this.ugDrivers).DisplayLayout.ViewStyle = (ViewStyle) 0;
    ((Control) this.ugDrivers).Location = new Point(12, 12);
    ((Control) this.ugDrivers).Name = "ugDrivers";
    ((Control) this.ugDrivers).Size = new Size(704, 228);
    ((Control) this.ugDrivers).TabIndex = 2;
    ((Control) this.ugDrivers).Text = "Available Drivers on Expiring Policy";
    ((UltraControlBase) this.ugDrivers).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ugDrivers).UseOsThemes = (DefaultableBoolean) 2;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(728, 298);
    this.Controls.Add((Control) this.btnSave);
    this.Controls.Add((Control) this.ddFullPartTime);
    this.Controls.Add((Control) this.uddState);
    this.Controls.Add((Control) this.ugDrivers);
    this.Name = nameof (FormCopyRenewalDrivers);
    this.Text = "Drivers for Renewal";
    ((ISupportInitialize) this.ddFullPartTime).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.uddState).EndInit();
    ((ISupportInitialize) this.ugDrivers).EndInit();
    this.ResumeLayout(false);
  }

  [field: AccessedThroughProperty("ugDrivers")]
  private virtual UltraGrid ugDrivers { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ds")]
  internal virtual dsDriverRenewal ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("uddState")]
  private virtual UltraDropDown uddState { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ddFullPartTime")]
  private virtual UltraDropDown ddFullPartTime { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual Button btnSave
  {
    get => this._btnSave;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnSave_Click);
      Button btnSave1 = this._btnSave;
      if (btnSave1 != null)
        btnSave1.Click -= eventHandler;
      this._btnSave = value;
      Button btnSave2 = this._btnSave;
      if (btnSave2 == null)
        return;
      btnSave2.Click += eventHandler;
    }
  }

  public FormCopyRenewalDrivers(int controlNo, Guid quoteGuid)
  {
    this.Load += new EventHandler(this.FormCopyRenewalDrivers_Load);
    this.InitializeComponent();
    this._ControlNo = controlNo;
    this._QuoteGuid = quoteGuid;
  }

  private void FormCopyRenewalDrivers_Load(object sender, EventArgs e)
  {
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[3]
    {
      "tblDriverInfo",
      "lstStates",
      "lstDriverStatusInfo"
    }, "GetExpiringDrivers", new object[4]
    {
      (object) "@controlNo",
      (object) this._ControlNo,
      (object) "@quoteGuid",
      (object) this._QuoteGuid
    });
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
    string str = string.Empty;
    int num1 = 0;
    foreach (UltraGridRow row in ((UltraGridBase) this.ugDrivers).Rows)
    {
      if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(row.Cells["CopyOver"].Value)) && (bool) row.Cells["CopyOver"].Value)
      {
        str = $"{str}{row.Cells["DriverID"].Value.ToString()},";
        ++num1;
      }
    }
    if (!str.Equals(string.Empty))
    {
      try
      {
        this.Cursor = MgaCursors.WaitCursor;
        DefaultDatabase.ExecuteNonQuery("UpdateRenewalDrivers", new object[6]
        {
          (object) "@controlNo",
          (object) this._ControlNo,
          (object) "@quoteGuid",
          (object) this._QuoteGuid,
          (object) "@driverIDs",
          (object) str.Substring(0, str.Length - 1)
        });
      }
      finally
      {
        this.Cursor = MgaCursors.Default;
      }
    }
    if (num1 > 0)
    {
      int num2 = (int) MessageBox.Show("Driver records imported successfully.", "Successful Import", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    this.Close();
  }
}
