// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Forms.FormActiveUserReplace
// Assembly: MgaSystems.IMS.Forms, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FB3F392E-40B6-486F-8F0B-A4A494A546D4
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Forms.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.Common;
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
public class FormActiveUserReplace : Form
{
  private IContainer components;
  private Guid _inactiveUserGuid;

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
    UltraGridBand ultraGridBand1 = new UltraGridBand("dtCSR", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("UserGUID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("Name_LastFirst");
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    ScrollBarLook scrollBarLook1 = new ScrollBarLook();
    Appearance appearance7 = new Appearance();
    UltraGridBand ultraGridBand2 = new UltraGridBand("dtAssistantUnderwriters", -1);
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("UserGUID");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("Name_LastFirst");
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    ScrollBarLook scrollBarLook2 = new ScrollBarLook();
    Appearance appearance11 = new Appearance();
    UltraGridBand ultraGridBand3 = new UltraGridBand("dtUnderwriters", -1);
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("UserGUID");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("Name_LastFirst");
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    ScrollBarLook scrollBarLook3 = new ScrollBarLook();
    Appearance appearance15 = new Appearance();
    this.Label1 = new Label();
    this.Label2 = new Label();
    this.Label3 = new Label();
    this.btnSave = new MGAButton();
    this.btnCancel = new MGAButton();
    this.cboCSR = new MGAComboBox();
    this.ds = new dsActiveUserReplace();
    this.cboAssistantUnderwriters = new MGAComboBox();
    this.cboUnderwriters = new MGAComboBox();
    this.lblInactiveUserName = new Label();
    this.chkOnBound = new MGACheckBox();
    ((ISupportInitialize) this.btnSave).BeginInit();
    ((ISupportInitialize) this.btnCancel).BeginInit();
    ((ISupportInitialize) this.cboCSR).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.cboAssistantUnderwriters).BeginInit();
    ((ISupportInitialize) this.cboUnderwriters).BeginInit();
    ((ISupportInitialize) this.chkOnBound).BeginInit();
    this.SuspendLayout();
    this.Label1.AutoSize = true;
    this.Label1.Location = new Point(12, 50);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(64 /*0x40*/, 13);
    this.Label1.TabIndex = 37;
    this.Label1.Text = "Underwriter:";
    this.Label2.AutoSize = true;
    this.Label2.Location = new Point(12, 90);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(109, 13);
    this.Label2.TabIndex = 38;
    this.Label2.Text = "Assistant Underwriter:";
    this.Label3.AutoSize = true;
    this.Label3.Location = new Point(12, 130);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(51, 13);
    this.Label3.TabIndex = 39;
    this.Label3.Text = "TA/CSR:";
    ((Control) this.btnSave).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance1.BackColor = Color.Gainsboro;
    appearance1.BackColor2 = Color.White;
    appearance1.BackGradientStyle = (GradientStyle) 2;
    appearance1.BorderColor = Color.Gray;
    appearance1.ImageHAlign = (HAlign) 2;
    appearance1.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnSave).Appearance = (AppearanceBase) appearance1;
    ((ControlBase) this.btnSave).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnSave).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnSave).Location = new Point(273, 205);
    ((Control) this.btnSave).Name = "btnSave";
    ((Control) this.btnSave).Size = new Size(40, 40);
    ((Control) this.btnSave).TabIndex = 40;
    this.btnSave.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.btnCancel).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance2.BackColor = Color.Gainsboro;
    appearance2.BackColor2 = Color.White;
    appearance2.BackGradientStyle = (GradientStyle) 2;
    appearance2.BorderColor = Color.Gray;
    appearance2.ImageHAlign = (HAlign) 2;
    appearance2.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnCancel).Appearance = (AppearanceBase) appearance2;
    ((ControlBase) this.btnCancel).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnCancel).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnCancel).Location = new Point(333, 205);
    ((Control) this.btnCancel).Name = "btnCancel";
    ((Control) this.btnCancel).Size = new Size(40, 40);
    ((Control) this.btnCancel).TabIndex = 41;
    this.btnCancel.UseOSThemes = (DefaultableBoolean) 2;
    this.cboCSR.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.cboCSR).DataMember = "dtCSR";
    ((UltraGridBase) this.cboCSR).DataSource = (object) this.ds;
    appearance3.BackColor = Color.White;
    appearance3.BorderColor = Color.FromArgb(78, 122, 171);
    this.cboCSR.DisplayLayout.Appearance = (AppearanceBase) appearance3;
    this.cboCSR.DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand1.ColHeadersVisible = false;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Width = 481;
    ultraGridBand1.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2
    });
    this.cboCSR.DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    this.cboCSR.DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    this.cboCSR.DisplayLayout.BorderStyleCaption = (UIElementBorderStyle) 1;
    this.cboCSR.DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    this.cboCSR.DisplayLayout.Override.BorderStyleHeader = (UIElementBorderStyle) 1;
    this.cboCSR.DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    this.cboCSR.DisplayLayout.Override.BorderStyleRowSelector = (UIElementBorderStyle) 1;
    this.cboCSR.DisplayLayout.Override.BorderStyleSummaryFooter = (UIElementBorderStyle) 1;
    this.cboCSR.DisplayLayout.Override.BorderStyleSummaryFooterCaption = (UIElementBorderStyle) 1;
    this.cboCSR.DisplayLayout.Override.BorderStyleSummaryValue = (UIElementBorderStyle) 1;
    this.cboCSR.DisplayLayout.Override.BorderStyleTemplateAddRow = (UIElementBorderStyle) 1;
    appearance4.BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    appearance4.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this.cboCSR.DisplayLayout.Override.HotTrackRowAppearance = (AppearanceBase) appearance4;
    appearance5.BorderColor = Color.White;
    this.cboCSR.DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance5;
    this.cboCSR.DisplayLayout.Override.RowSpacingAfter = 1;
    appearance6.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance6.BorderColor = Color.FromArgb((int) byte.MaxValue, 214, 88);
    appearance6.ForeColor = Color.Black;
    this.cboCSR.DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance6;
    scrollBarLook1.ViewStyle = (ScrollBarViewStyle) 3;
    this.cboCSR.DisplayLayout.ScrollBarLook = scrollBarLook1;
    ((UltraDropDownBase) this.cboCSR).DisplayMember = "Name_LastFirst";
    this.cboCSR.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboCSR).DropDownWidth = 500;
    ((Control) this.cboCSR).Location = new Point(146, 126);
    this.cboCSR.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboCSR).Name = "cboCSR";
    ((Control) this.cboCSR).Size = new Size(227, 20);
    ((Control) this.cboCSR).TabIndex = 36;
    ((UltraControlBase) this.cboCSR).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboCSR).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboCSR).ValueMember = "UserGUID";
    this.ds.DataSetName = "dsActiveUserReplace";
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.cboAssistantUnderwriters.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.cboAssistantUnderwriters).DataMember = "dtAssistantUnderwriters";
    ((UltraGridBase) this.cboAssistantUnderwriters).DataSource = (object) this.ds;
    appearance7.BackColor = Color.White;
    appearance7.BorderColor = Color.FromArgb(78, 122, 171);
    this.cboAssistantUnderwriters.DisplayLayout.Appearance = (AppearanceBase) appearance7;
    this.cboAssistantUnderwriters.DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand2.ColHeadersVisible = false;
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Header.VisiblePosition = 0;
    ultraGridColumn3.Hidden = true;
    ultraGridColumn4.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn4.Header.VisiblePosition = 1;
    ultraGridColumn4.Width = 481;
    ultraGridBand2.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn3,
      (object) ultraGridColumn4
    });
    this.cboAssistantUnderwriters.DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    this.cboAssistantUnderwriters.DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    this.cboAssistantUnderwriters.DisplayLayout.BorderStyleCaption = (UIElementBorderStyle) 1;
    this.cboAssistantUnderwriters.DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    this.cboAssistantUnderwriters.DisplayLayout.Override.BorderStyleHeader = (UIElementBorderStyle) 1;
    this.cboAssistantUnderwriters.DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    this.cboAssistantUnderwriters.DisplayLayout.Override.BorderStyleRowSelector = (UIElementBorderStyle) 1;
    this.cboAssistantUnderwriters.DisplayLayout.Override.BorderStyleSummaryFooter = (UIElementBorderStyle) 1;
    this.cboAssistantUnderwriters.DisplayLayout.Override.BorderStyleSummaryFooterCaption = (UIElementBorderStyle) 1;
    this.cboAssistantUnderwriters.DisplayLayout.Override.BorderStyleSummaryValue = (UIElementBorderStyle) 1;
    this.cboAssistantUnderwriters.DisplayLayout.Override.BorderStyleTemplateAddRow = (UIElementBorderStyle) 1;
    appearance8.BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    appearance8.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this.cboAssistantUnderwriters.DisplayLayout.Override.HotTrackRowAppearance = (AppearanceBase) appearance8;
    appearance9.BorderColor = Color.White;
    this.cboAssistantUnderwriters.DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance9;
    this.cboAssistantUnderwriters.DisplayLayout.Override.RowSpacingAfter = 1;
    appearance10.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance10.BorderColor = Color.FromArgb((int) byte.MaxValue, 214, 88);
    appearance10.ForeColor = Color.Black;
    this.cboAssistantUnderwriters.DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance10;
    scrollBarLook2.ViewStyle = (ScrollBarViewStyle) 3;
    this.cboAssistantUnderwriters.DisplayLayout.ScrollBarLook = scrollBarLook2;
    ((UltraDropDownBase) this.cboAssistantUnderwriters).DisplayMember = "Name_LastFirst";
    this.cboAssistantUnderwriters.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboAssistantUnderwriters).DropDownWidth = 500;
    ((Control) this.cboAssistantUnderwriters).Location = new Point(146, 86);
    this.cboAssistantUnderwriters.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboAssistantUnderwriters).Name = "cboAssistantUnderwriters";
    ((Control) this.cboAssistantUnderwriters).Size = new Size(227, 20);
    ((Control) this.cboAssistantUnderwriters).TabIndex = 35;
    ((UltraControlBase) this.cboAssistantUnderwriters).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboAssistantUnderwriters).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboAssistantUnderwriters).ValueMember = "UserGUID";
    this.cboUnderwriters.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.cboUnderwriters).DataMember = "dtUnderwriters";
    ((UltraGridBase) this.cboUnderwriters).DataSource = (object) this.ds;
    appearance11.BackColor = Color.White;
    appearance11.BorderColor = Color.FromArgb(78, 122, 171);
    this.cboUnderwriters.DisplayLayout.Appearance = (AppearanceBase) appearance11;
    this.cboUnderwriters.DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand3.ColHeadersVisible = false;
    ultraGridColumn5.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn5.Header.VisiblePosition = 0;
    ultraGridColumn5.Hidden = true;
    ultraGridColumn6.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn6.Header.VisiblePosition = 1;
    ultraGridColumn6.Width = 481;
    ultraGridBand3.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn5,
      (object) ultraGridColumn6
    });
    this.cboUnderwriters.DisplayLayout.BandsSerializer.Add((object) ultraGridBand3);
    this.cboUnderwriters.DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    this.cboUnderwriters.DisplayLayout.BorderStyleCaption = (UIElementBorderStyle) 1;
    this.cboUnderwriters.DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    this.cboUnderwriters.DisplayLayout.Override.BorderStyleHeader = (UIElementBorderStyle) 1;
    this.cboUnderwriters.DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    this.cboUnderwriters.DisplayLayout.Override.BorderStyleRowSelector = (UIElementBorderStyle) 1;
    this.cboUnderwriters.DisplayLayout.Override.BorderStyleSummaryFooter = (UIElementBorderStyle) 1;
    this.cboUnderwriters.DisplayLayout.Override.BorderStyleSummaryFooterCaption = (UIElementBorderStyle) 1;
    this.cboUnderwriters.DisplayLayout.Override.BorderStyleSummaryValue = (UIElementBorderStyle) 1;
    this.cboUnderwriters.DisplayLayout.Override.BorderStyleTemplateAddRow = (UIElementBorderStyle) 1;
    appearance12.BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    appearance12.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this.cboUnderwriters.DisplayLayout.Override.HotTrackRowAppearance = (AppearanceBase) appearance12;
    appearance13.BorderColor = Color.White;
    this.cboUnderwriters.DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance13;
    this.cboUnderwriters.DisplayLayout.Override.RowSpacingAfter = 1;
    appearance14.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance14.BorderColor = Color.FromArgb((int) byte.MaxValue, 214, 88);
    appearance14.ForeColor = Color.Black;
    this.cboUnderwriters.DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance14;
    scrollBarLook3.ViewStyle = (ScrollBarViewStyle) 3;
    this.cboUnderwriters.DisplayLayout.ScrollBarLook = scrollBarLook3;
    ((UltraDropDownBase) this.cboUnderwriters).DisplayMember = "Name_LastFirst";
    this.cboUnderwriters.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboUnderwriters).DropDownWidth = 500;
    ((Control) this.cboUnderwriters).Location = new Point(146, 46);
    this.cboUnderwriters.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboUnderwriters).Name = "cboUnderwriters";
    ((Control) this.cboUnderwriters).Size = new Size(227, 20);
    ((Control) this.cboUnderwriters).TabIndex = 33;
    ((UltraControlBase) this.cboUnderwriters).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboUnderwriters).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboUnderwriters).ValueMember = "UserGUID";
    this.lblInactiveUserName.AutoSize = true;
    this.lblInactiveUserName.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblInactiveUserName.Location = new Point(88, 9);
    this.lblInactiveUserName.Name = "lblInactiveUserName";
    this.lblInactiveUserName.Size = new Size(223, 13);
    this.lblInactiveUserName.TabIndex = 42;
    this.lblInactiveUserName.Text = "[Enter the Inactive User's Name Here]";
    appearance15.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance15.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkOnBound).Appearance = (AppearanceBase) appearance15;
    ((UltraToggleEditorBase) this.chkOnBound).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkOnBound).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkOnBound).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkOnBound).Location = new Point(146, 159);
    this.chkOnBound.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkOnBound).Name = "chkOnBound";
    ((Control) this.chkOnBound).Size = new Size(188, 27);
    ((Control) this.chkOnBound).TabIndex = 43;
    ((UltraToggleEditorBase) this.chkOnBound).Text = "Change on Bound Policies Only";
    ((UltraControlBase) this.chkOnBound).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkOnBound).UseOsThemes = (DefaultableBoolean) 2;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(388, 257);
    this.Controls.Add((Control) this.chkOnBound);
    this.Controls.Add((Control) this.lblInactiveUserName);
    this.Controls.Add((Control) this.btnCancel);
    this.Controls.Add((Control) this.btnSave);
    this.Controls.Add((Control) this.Label3);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.cboCSR);
    this.Controls.Add((Control) this.cboAssistantUnderwriters);
    this.Controls.Add((Control) this.cboUnderwriters);
    this.Name = nameof (FormActiveUserReplace);
    this.Text = "Available Active Users ";
    ((ISupportInitialize) this.btnSave).EndInit();
    ((ISupportInitialize) this.btnCancel).EndInit();
    ((ISupportInitialize) this.cboCSR).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.cboAssistantUnderwriters).EndInit();
    ((ISupportInitialize) this.cboUnderwriters).EndInit();
    ((ISupportInitialize) this.chkOnBound).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  [field: AccessedThroughProperty("cboUnderwriters")]
  protected virtual MGAComboBox cboUnderwriters { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboAssistantUnderwriters")]
  protected virtual MGAComboBox cboAssistantUnderwriters { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboCSR")]
  protected virtual MGAComboBox cboCSR { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label2")]
  internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label3")]
  internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGAButton btnSave
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

  internal virtual MGAButton btnCancel
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

  [field: AccessedThroughProperty("ds")]
  internal virtual dsActiveUserReplace ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblInactiveUserName")]
  internal virtual Label lblInactiveUserName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkOnBound")]
  private virtual MGACheckBox chkOnBound { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public FormActiveUserReplace(Guid inActiveUserGuid)
  {
    this.Load += new EventHandler(this.FormActiveUserReplace_Load);
    this.InitializeComponent();
    this._inactiveUserGuid = inActiveUserGuid;
    ((ControlBase) this.btnSave).Appearance.Image = (object) ImageCache.Instance.Save;
    ((ControlBase) this.btnCancel).Appearance.Image = (object) ImageCache.Instance.Undo;
  }

  private void FormActiveUserReplace_Load(object sender, EventArgs e)
  {
    MGASystems.BusinessObjects.User user = new MGASystems.BusinessObjects.User(this._inactiveUserGuid);
    this.lblInactiveUserName.Text = $"Current Inactive User:{user.LastName}, {user.FirstName}";
    if (user.StatusID == (byte) 3)
      this.lblInactiveUserName.Text = $"Current Closed User:{user.LastName}, {user.FirstName}";
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[3]
    {
      "dtUnderwriters",
      "dtAssistantUnderwriters",
      "dtCSR"
    }, "spGetAvailableActiveUsers", new object[2]
    {
      (object) "@inactiveUserGuid",
      (object) this._inactiveUserGuid
    });
    ((UltraToggleEditorBase) this.chkOnBound).Checked = true;
  }

  private void btnCancel_Click(object sender, EventArgs e) => this.Close();

  private void btnSave_Click(object sender, EventArgs e)
  {
    if (DialogResult.Yes != MessageBox.Show("You are about to replace this closed/inactive user.\n\nContinue?", "Replace User", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
      return;
    try
    {
      ((Control) this.btnSave).Enabled = false;
      int userId = CurrentUser.Instance.UserID;
      if (!string.IsNullOrEmpty(this.cboUnderwriters.Text))
        DefaultDatabase.ExecuteNonQuery("spReplaceInactiveUser", new object[10]
        {
          (object) "@inactiveUserGuid",
          (object) this._inactiveUserGuid,
          (object) "@newUserGUID",
          (object) (Guid) this.cboUnderwriters.Value,
          (object) "@userType",
          (object) "UND",
          (object) "@CurrentUserID",
          (object) userId,
          (object) "@BoundOnly",
          (object) ((UltraToggleEditorBase) this.chkOnBound).Checked
        });
      if (!string.IsNullOrEmpty(this.cboAssistantUnderwriters.Text))
        DefaultDatabase.ExecuteNonQuery("spReplaceInactiveUser", new object[10]
        {
          (object) "@inactiveUserGuid",
          (object) this._inactiveUserGuid,
          (object) "@newUserGUID",
          (object) (Guid) this.cboAssistantUnderwriters.Value,
          (object) "@userType",
          (object) "AUND",
          (object) "@CurrentUserID",
          (object) userId,
          (object) "@BoundOnly",
          (object) ((UltraToggleEditorBase) this.chkOnBound).Checked
        });
      if (!string.IsNullOrEmpty(this.cboCSR.Text))
        DefaultDatabase.ExecuteNonQuery("spReplaceInactiveUser", new object[10]
        {
          (object) "@inactiveUserGuid",
          (object) this._inactiveUserGuid,
          (object) "@newUserGUID",
          (object) (Guid) this.cboCSR.Value,
          (object) "@userType",
          (object) "TACR",
          (object) "@CurrentUserID",
          (object) userId,
          (object) "@BoundOnly",
          (object) ((UltraToggleEditorBase) this.chkOnBound).Checked
        });
    }
    finally
    {
      ((Control) this.btnSave).Enabled = true;
    }
    this.Close();
  }
}
