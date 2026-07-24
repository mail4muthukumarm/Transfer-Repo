// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Forms.FormFeeViewingRights
// Assembly: MgaSystems.IMS.Forms, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FB3F392E-40B6-486F-8F0B-A4A494A546D4
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Forms.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.Common;
using MGASystems.Common.ErrorHandling;
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
namespace MGASystems.IMS.Forms;

[DesignerGenerated]
public class FormFeeViewingRights : Form
{
  private IContainer components;
  private Guid _userGuid;
  private string _userLastFirstName;
  private Guid _currentUserGuid;

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
    UltraGridBand ultraGridBand1 = new UltraGridBand("lstStates", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("StateID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("State");
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    ScrollBarLook scrollBarLook1 = new ScrollBarLook();
    Appearance appearance7 = new Appearance();
    UltraGridBand ultraGridBand2 = new UltraGridBand("tblFees", -1);
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("ChargeCode");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("StateID");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("ChargeName");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("Description");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("Restr");
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    ScrollBarLook scrollBarLook2 = new ScrollBarLook();
    Appearance appearance15 = new Appearance();
    UltraGridBand ultraGridBand3 = new UltraGridBand("tblUserRestrictedFees", -1);
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("ChargeCode");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("ChargeName");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("StateID");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("Remove");
    Appearance appearance16 = new Appearance();
    Appearance appearance17 = new Appearance();
    Appearance appearance18 = new Appearance();
    Appearance appearance19 = new Appearance();
    Appearance appearance20 = new Appearance();
    Appearance appearance21 = new Appearance();
    Appearance appearance22 = new Appearance();
    ScrollBarLook scrollBarLook3 = new ScrollBarLook();
    this.Label1 = new Label();
    this.txtSearch = new TextBox();
    this.btnGo = new MGAButton();
    this.lnkDeselectAll = new LinkLabel();
    this.lnkSelectAll = new LinkLabel();
    this.Label2 = new Label();
    this.btnSearch = new MGAButton();
    this.cboState = new MGAComboBox();
    this.ds = new dsRestrictedFees();
    this.ugSearch = new UltraGrid();
    this.ugHide = new UltraGrid();
    ((ISupportInitialize) this.btnGo).BeginInit();
    ((ISupportInitialize) this.btnSearch).BeginInit();
    ((ISupportInitialize) this.cboState).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.ugSearch).BeginInit();
    ((ISupportInitialize) this.ugHide).BeginInit();
    this.SuspendLayout();
    this.Label1.AutoSize = true;
    this.Label1.Location = new Point(8, 17);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(59, 13);
    this.Label1.TabIndex = 26;
    this.Label1.Text = "Fee Name:";
    this.txtSearch.Location = new Point(73, 13);
    this.txtSearch.Name = "txtSearch";
    this.txtSearch.Size = new Size(204, 20);
    this.txtSearch.TabIndex = 24;
    ((Control) this.btnGo).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    appearance1.BackColor = Color.FromArgb(248, 248, 248);
    appearance1.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance1.BackGradientStyle = (GradientStyle) 2;
    appearance1.BorderColor = Color.DarkGray;
    appearance1.ImageHAlign = (HAlign) 2;
    appearance1.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnGo).Appearance = (AppearanceBase) appearance1;
    ((UltraButtonBase) this.btnGo).DialogResult = DialogResult.Cancel;
    ((ControlBase) this.btnGo).ImageSize = new Size(24, 24);
    ((Control) this.btnGo).Location = new Point(416, 573);
    ((Control) this.btnGo).Name = "btnGo";
    ((Control) this.btnGo).Size = new Size(40, 40);
    ((Control) this.btnGo).TabIndex = 23;
    this.btnGo.UseOSThemes = (DefaultableBoolean) 2;
    this.lnkDeselectAll.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkDeselectAll.AutoSize = true;
    this.lnkDeselectAll.Location = new Point(103, 600);
    this.lnkDeselectAll.Name = "lnkDeselectAll";
    this.lnkDeselectAll.Size = new Size(68, 13);
    this.lnkDeselectAll.TabIndex = 22;
    this.lnkDeselectAll.TabStop = true;
    this.lnkDeselectAll.Text = "De-Select All";
    this.lnkSelectAll.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkSelectAll.AutoSize = true;
    this.lnkSelectAll.Location = new Point(26, 600);
    this.lnkSelectAll.Name = "lnkSelectAll";
    this.lnkSelectAll.Size = new Size(51, 13);
    this.lnkSelectAll.TabIndex = 21;
    this.lnkSelectAll.TabStop = true;
    this.lnkSelectAll.Text = "Select All";
    this.Label2.AutoSize = true;
    this.Label2.Location = new Point(8, 52);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(35, 13);
    this.Label2.TabIndex = 28;
    this.Label2.Text = "State:";
    appearance2.BackColor = Color.Gainsboro;
    appearance2.BackColor2 = Color.White;
    appearance2.BackGradientStyle = (GradientStyle) 2;
    appearance2.BorderColor = Color.Gray;
    appearance2.ImageHAlign = (HAlign) 2;
    appearance2.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnSearch).Appearance = (AppearanceBase) appearance2;
    ((ControlBase) this.btnSearch).ImageSize = new Size(24, 24);
    ((Control) this.btnSearch).Location = new Point(416, 25);
    ((Control) this.btnSearch).Name = "btnSearch";
    ((Control) this.btnSearch).Size = new Size(40, 40);
    ((Control) this.btnSearch).TabIndex = 25;
    this.btnSearch.UseOSThemes = (DefaultableBoolean) 2;
    this.cboState.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.cboState).DataMember = "lstStates";
    ((UltraGridBase) this.cboState).DataSource = (object) this.ds;
    appearance3.BackColor = Color.White;
    appearance3.BorderColor = Color.FromArgb(78, 122, 171);
    this.cboState.DisplayLayout.Appearance = (AppearanceBase) appearance3;
    this.cboState.DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand1.ColHeadersVisible = false;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Width = 105;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Width = 226;
    ultraGridBand1.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2
    });
    this.cboState.DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    this.cboState.DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    this.cboState.DisplayLayout.BorderStyleCaption = (UIElementBorderStyle) 1;
    this.cboState.DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    this.cboState.DisplayLayout.Override.BorderStyleHeader = (UIElementBorderStyle) 1;
    this.cboState.DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    this.cboState.DisplayLayout.Override.BorderStyleRowSelector = (UIElementBorderStyle) 1;
    this.cboState.DisplayLayout.Override.BorderStyleSummaryFooter = (UIElementBorderStyle) 1;
    this.cboState.DisplayLayout.Override.BorderStyleSummaryFooterCaption = (UIElementBorderStyle) 1;
    this.cboState.DisplayLayout.Override.BorderStyleSummaryValue = (UIElementBorderStyle) 1;
    this.cboState.DisplayLayout.Override.BorderStyleTemplateAddRow = (UIElementBorderStyle) 1;
    appearance4.BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    appearance4.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this.cboState.DisplayLayout.Override.HotTrackRowAppearance = (AppearanceBase) appearance4;
    appearance5.BorderColor = Color.White;
    this.cboState.DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance5;
    this.cboState.DisplayLayout.Override.RowSpacingAfter = 1;
    appearance6.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance6.BorderColor = Color.FromArgb((int) byte.MaxValue, 214, 88);
    appearance6.ForeColor = Color.Black;
    this.cboState.DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance6;
    scrollBarLook1.ViewStyle = (ScrollBarViewStyle) 3;
    this.cboState.DisplayLayout.ScrollBarLook = scrollBarLook1;
    ((UltraDropDownBase) this.cboState).DisplayMember = "State";
    this.cboState.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboState).DropDownWidth = 350;
    ((Control) this.cboState).Location = new Point(73, 48 /*0x30*/);
    this.cboState.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboState).Name = "cboState";
    ((Control) this.cboState).Size = new Size(204, 20);
    ((Control) this.cboState).TabIndex = 27;
    ((UltraControlBase) this.cboState).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboState).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboState).ValueMember = "StateID";
    this.ds.DataSetName = "dsRestrictedFees";
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((Control) this.ugSearch).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
    ((UltraControlBase) this.ugSearch).Cursor = Cursors.Hand;
    ((UltraGridBase) this.ugSearch).DataMember = "tblFees";
    ((UltraGridBase) this.ugSearch).DataSource = (object) this.ds;
    appearance7.BackColor = Color.White;
    appearance7.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ugSearch).DisplayLayout.Appearance = (AppearanceBase) appearance7;
    ((UltraGridBase) this.ugSearch).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn3.Header.VisiblePosition = 0;
    ultraGridColumn3.Hidden = true;
    ultraGridColumn3.Width = 90;
    ((HeaderBase) ultraGridColumn4.Header).Caption = "State";
    ultraGridColumn4.Header.VisiblePosition = 1;
    ultraGridColumn4.Width = 120;
    ultraGridColumn5.Header.VisiblePosition = 2;
    ultraGridColumn5.Width = 188;
    ultraGridColumn6.Header.VisiblePosition = 3;
    ultraGridColumn6.Width = 171;
    ((HeaderBase) ultraGridColumn7.Header).Caption = "Restrict";
    ultraGridColumn7.Header.VisiblePosition = 4;
    ultraGridColumn7.Width = 47;
    ultraGridBand2.Columns.AddRange(new object[5]
    {
      (object) ultraGridColumn3,
      (object) ultraGridColumn4,
      (object) ultraGridColumn5,
      (object) ultraGridColumn6,
      (object) ultraGridColumn7
    });
    ((UltraGridBase) this.ugSearch).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.ugSearch).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance8.BackColor = Color.LightSteelBlue;
    appearance8.FontData.SizeInPoints = 10f;
    appearance8.ForeColor = Color.Black;
    ((UltraGridBase) this.ugSearch).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance8;
    appearance9.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance9.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance9.ForeColor = Color.Black;
    ((UltraGridBase) this.ugSearch).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance9;
    ((UltraGridBase) this.ugSearch).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.ugSearch).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    appearance10.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugSearch).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance10;
    appearance11.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ugSearch).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance11;
    ((UltraGridBase) this.ugSearch).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.ugSearch).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance12.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ugSearch).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance12;
    appearance13.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugSearch).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance13;
    ((UltraGridBase) this.ugSearch).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance14.BackColor = Color.Transparent;
    appearance14.ForeColor = Color.Black;
    ((UltraGridBase) this.ugSearch).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance14;
    scrollBarLook2.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.ugSearch).DisplayLayout.ScrollBarLook = scrollBarLook2;
    ((Control) this.ugSearch).Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.ugSearch).Location = new Point(11, 85);
    ((Control) this.ugSearch).Name = "ugSearch";
    ((Control) this.ugSearch).Size = new Size(528, 474);
    ((Control) this.ugSearch).TabIndex = 20;
    ((Control) this.ugSearch).Text = "Fee Search Results";
    ((UltraControlBase) this.ugSearch).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ugSearch).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.ugHide).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraControlBase) this.ugHide).Cursor = Cursors.Hand;
    ((UltraGridBase) this.ugHide).DataMember = "tblUserRestrictedFees";
    ((UltraGridBase) this.ugHide).DataSource = (object) this.ds;
    appearance15.BackColor = Color.White;
    appearance15.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ugHide).DisplayLayout.Appearance = (AppearanceBase) appearance15;
    ((UltraGridBase) this.ugHide).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn8.Header.VisiblePosition = 0;
    ultraGridColumn8.Hidden = true;
    ultraGridColumn8.Width = 108;
    ((HeaderBase) ultraGridColumn9.Header).Caption = "Fee";
    ultraGridColumn9.Header.VisiblePosition = 1;
    ultraGridColumn9.Width = 240 /*0xF0*/;
    ((HeaderBase) ultraGridColumn10.Header).Caption = "State";
    ultraGridColumn10.Header.VisiblePosition = 2;
    ultraGridColumn10.Width = 120;
    ultraGridColumn11.Header.VisiblePosition = 3;
    ultraGridColumn11.Width = 101;
    ultraGridBand3.Columns.AddRange(new object[4]
    {
      (object) ultraGridColumn8,
      (object) ultraGridColumn9,
      (object) ultraGridColumn10,
      (object) ultraGridColumn11
    });
    ((UltraGridBase) this.ugHide).DisplayLayout.BandsSerializer.Add((object) ultraGridBand3);
    ((UltraGridBase) this.ugHide).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance16.BackColor = Color.LightSteelBlue;
    appearance16.FontData.SizeInPoints = 10f;
    appearance16.ForeColor = Color.Black;
    ((UltraGridBase) this.ugHide).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance16;
    appearance17.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance17.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance17.ForeColor = Color.Black;
    ((UltraGridBase) this.ugHide).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance17;
    ((UltraGridBase) this.ugHide).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.ugHide).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    appearance18.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugHide).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance18;
    appearance19.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ugHide).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance19;
    ((UltraGridBase) this.ugHide).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.ugHide).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance20.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ugHide).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance20;
    appearance21.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugHide).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance21;
    ((UltraGridBase) this.ugHide).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance22.BackColor = Color.Transparent;
    appearance22.ForeColor = Color.Black;
    ((UltraGridBase) this.ugHide).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance22;
    scrollBarLook3.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.ugHide).DisplayLayout.ScrollBarLook = scrollBarLook3;
    ((Control) this.ugHide).Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.ugHide).Location = new Point(545, 1);
    ((Control) this.ugHide).Name = "ugHide";
    ((Control) this.ugHide).Size = new Size(463, 622);
    ((Control) this.ugHide).TabIndex = 19;
    ((Control) this.ugHide).Text = " Restricted Fees";
    ((UltraControlBase) this.ugHide).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ugHide).UseOsThemes = (DefaultableBoolean) 2;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(1015, 624);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.cboState);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.btnSearch);
    this.Controls.Add((Control) this.txtSearch);
    this.Controls.Add((Control) this.btnGo);
    this.Controls.Add((Control) this.lnkDeselectAll);
    this.Controls.Add((Control) this.lnkSelectAll);
    this.Controls.Add((Control) this.ugSearch);
    this.Controls.Add((Control) this.ugHide);
    this.Name = nameof (FormFeeViewingRights);
    this.Text = "Fee Viewing Rights";
    ((ISupportInitialize) this.btnGo).EndInit();
    ((ISupportInitialize) this.btnSearch).EndInit();
    ((ISupportInitialize) this.cboState).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.ugSearch).EndInit();
    ((ISupportInitialize) this.ugHide).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtSearch")]
  internal virtual TextBox txtSearch { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MGAButton btnGo
  {
    get => this._btnGo;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnGo_Click);
      MGAButton btnGo1 = this._btnGo;
      if (btnGo1 != null)
        ((Control) btnGo1).Click -= eventHandler;
      this._btnGo = value;
      MGAButton btnGo2 = this._btnGo;
      if (btnGo2 == null)
        return;
      ((Control) btnGo2).Click += eventHandler;
    }
  }

  internal virtual LinkLabel lnkDeselectAll
  {
    get => this._lnkDeselectAll;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkDeselectAll_LinkClicked);
      LinkLabel lnkDeselectAll1 = this._lnkDeselectAll;
      if (lnkDeselectAll1 != null)
        lnkDeselectAll1.LinkClicked -= clickedEventHandler;
      this._lnkDeselectAll = value;
      LinkLabel lnkDeselectAll2 = this._lnkDeselectAll;
      if (lnkDeselectAll2 == null)
        return;
      lnkDeselectAll2.LinkClicked += clickedEventHandler;
    }
  }

  internal virtual LinkLabel lnkSelectAll
  {
    get => this._lnkSelectAll;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkSelectAll_LinkClicked);
      LinkLabel lnkSelectAll1 = this._lnkSelectAll;
      if (lnkSelectAll1 != null)
        lnkSelectAll1.LinkClicked -= clickedEventHandler;
      this._lnkSelectAll = value;
      LinkLabel lnkSelectAll2 = this._lnkSelectAll;
      if (lnkSelectAll2 == null)
        return;
      lnkSelectAll2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("ugSearch")]
  private virtual UltraGrid ugSearch { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual UltraGrid ugHide
  {
    get => this._ugHide;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      CellEventHandler cellEventHandler = new CellEventHandler(this.ugHide_CellChange);
      UltraGrid ugHide1 = this._ugHide;
      if (ugHide1 != null)
        ugHide1.CellChange -= cellEventHandler;
      this._ugHide = value;
      UltraGrid ugHide2 = this._ugHide;
      if (ugHide2 == null)
        return;
      ugHide2.CellChange += cellEventHandler;
    }
  }

  [field: AccessedThroughProperty("ds")]
  internal virtual dsRestrictedFees ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboState")]
  protected virtual MGAComboBox cboState { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label2")]
  internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MGAButton btnSearch
  {
    get => this._btnSearch;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnSearch_Click);
      MGAButton btnSearch1 = this._btnSearch;
      if (btnSearch1 != null)
        ((Control) btnSearch1).Click -= eventHandler;
      this._btnSearch = value;
      MGAButton btnSearch2 = this._btnSearch;
      if (btnSearch2 == null)
        return;
      ((Control) btnSearch2).Click += eventHandler;
    }
  }

  public FormFeeViewingRights(Guid userGuid)
  {
    this.Load += new EventHandler(this.FormFeeViewingRights_Load);
    this._userLastFirstName = string.Empty;
    this.InitializeComponent();
    this._userGuid = userGuid;
    this._currentUserGuid = CurrentUser.Instance.UserGUID;
    MGASystems.BusinessObjects.User user = new MGASystems.BusinessObjects.User(userGuid);
    this._userLastFirstName = $"{user.LastName}, {user.FirstName}";
  }

  private void FormFeeViewingRights_Load(object sender, EventArgs e)
  {
    ((ControlBase) this.btnGo).Appearance.Image = (object) ImageCache.Instance.Save;
    ((ControlBase) this.btnSearch).Appearance.Image = (object) ImageCache.Instance.Search;
    MGASystems.BusinessObjects.User user = new MGASystems.BusinessObjects.User(this._userGuid);
    ((Control) this.ugHide).Text = $"[{user.LastName}, {user.FirstName}]  -  {((Control) this.ugHide).Text}";
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "lstStates"
    }, CommandType.Text, "SELECT StateID, State FROM lstStates ORDER BY State");
    this.RefreshData();
  }

  private void ugHide_CellChange(object sender, CellEventArgs e)
  {
    if (e.Cell == null || e.Cell.Row == null || e.Cell.Value == null || !e.Cell.Column.Key.Equals("Remove"))
      return;
    if (!(bool) e.Cell.Value)
      return;
    try
    {
      Cursor.Current = Cursors.WaitCursor;
      int ChargeCode = (int) e.Cell.Row.Cells["ChargeCode"].Value;
      object obj = (object) null;
      if (e.Cell.Row.Cells["StateID"].Value != null && e.Cell.Row.Cells["StateID"].Value != DBNull.Value)
        obj = (object) (string) e.Cell.Row.Cells["StateID"].Value;
      string action = $"Users Menu - Removed user, {this._userLastFirstName} , restriction for fee {(string) e.Cell.Row.Cells["ChargeName"].Value}";
      if (obj != null)
        action = $"{action} and state {obj.ToString()}";
      DefaultDatabase.ExecuteNonQuery(CommandType.Text, "DELETE FROM tblUserRestrictedFees WHERE ChargeCode=@CC And UserGuid= @uGuid", new object[4]
      {
        (object) "@CC",
        (object) ChargeCode,
        (object) "@uGuid",
        (object) this._userGuid
      });
      CurrentUser.Instance.LogAction(action, this._currentUserGuid);
      this.ds.tblUserRestrictedFees.RemovetblUserRestrictedFeesRow(this.ds.tblUserRestrictedFees.FindByChargeCode(ChargeCode));
      ((UltraGridBase) this.ugHide).UpdateData();
    }
    finally
    {
      Cursor.Current = Cursors.Default;
    }
  }

  private void RefreshData()
  {
    try
    {
      this.ugHide.CellChange -= new CellEventHandler(this.ugHide_CellChange);
      this.ds.tblUserRestrictedFees.Clear();
      DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
      {
        "tblUserRestrictedFees"
      }, CommandType.Text, "SELECT DISTINCT RF.ChargeCode, F.ChargeName, RF.StateID,  1 AS Remove FROM tblUserRestrictedFees AS RF WITH (NOLOCK) INNER JOIN tblFin_PolicyCharges AS F WITH (NOLOCK) ON F.ChargeCode  = RF.ChargeCode  WHERE RF.UserGuid = @UG ORDER BY F.ChargeName, RF.StateID, RF.ChargeCode, [Remove]", new object[2]
      {
        (object) "@UG",
        (object) this._userGuid
      });
    }
    finally
    {
      this.ugHide.CellChange += new CellEventHandler(this.ugHide_CellChange);
    }
  }

  private void btnSearch_Click(object sender, EventArgs e)
  {
    this.ds.tblFees.Clear();
    if (this.txtSearch.Text.Replace(" ", string.Empty).Length == 0 && string.IsNullOrEmpty(this.cboState.Text))
    {
      int num = (int) MessageBox.Show("Please enter at least one search criterion.\n\nBoth text and state cannot be empty.", "Empty Search", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else
    {
      try
      {
        DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
        {
          "tblFees"
        }, "GetUserFeesViewingRightsData", new object[6]
        {
          (object) "@UserGuid",
          (object) this._userGuid,
          (object) "@searchText",
          (object) this.txtSearch.Text,
          (object) "@StateID",
          this.cboState.Value
        });
      }
      catch (ConstraintException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        ErrorHandler.ShowDataSetErrors((DataSet) this.ds, ex);
        ProjectData.ClearProjectError();
      }
    }
  }

  private void btnGo_Click(object sender, EventArgs e)
  {
    try
    {
      this.Cursor = MgaCursors.WaitCursor;
      bool flag = false;
      object obj1 = (object) DBNull.Value;
      string empty1 = string.Empty;
      string empty2 = string.Empty;
      RowEnumerator enumerator = ((UltraGridBase) this.ugSearch).Rows.GetEnumerator();
      while (enumerator.MoveNext())
      {
        UltraGridRow current = enumerator.Current;
        if ((bool) current.Cells["Restr"].Value)
        {
          int num = (int) current.Cells["ChargeCode"].Value;
          object obj2 = (object) DBNull.Value;
          if (current.Cells["StateID"].Value != null && current.Cells["StateID"].Value != DBNull.Value)
            obj2 = (object) (string) current.Cells["StateID"].Value;
          string str = (string) current.Cells["ChargeName"].Value;
          DefaultDatabase.ExecuteNonQuery("SaveFeeViewingRightsData", new object[6]
          {
            (object) "@ChargeCode",
            (object) num,
            (object) "@StateID",
            obj2,
            (object) "@UserGuid",
            (object) this._userGuid
          });
          string action = "Users Menu - Added restriction for fee " + str;
          if (obj2 != DBNull.Value)
            action = $"{action} for StateID={obj2.ToString()}";
          CurrentUser.Instance.LogAction(action, this._currentUserGuid);
          flag = true;
        }
      }
      if (!flag)
        return;
      this.RefreshData();
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
    }
  }

  private void lnkSelectAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.SetRestriction(true);
  }

  private void lnkDeselectAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.SetRestriction(false);
  }

  private void SetRestriction(bool SetValue)
  {
    foreach (UltraGridRow row in ((UltraGridBase) this.ugSearch).Rows)
      row.Cells["Restr"].Value = (object) SetValue;
  }
}
