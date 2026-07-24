// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Reports.frmBoundAccounts
// Assembly: MgaSystems.IMS.Accounting.Reports, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 04B285D2-9F1D-4009-8AE0-5683AB5AFB4E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Reports.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using MGASystems.Common.DataAccess;
using MGASystems.Tools;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Reports;

public sealed class frmBoundAccounts : Form
{
  private IContainer components;
  private Guid _EntityGuid;
  private Guid _CarrierGuid;

  public frmBoundAccounts()
  {
    this.Load += new EventHandler(this.frmOpenReceivables_Load);
    this._EntityGuid = Guid.Empty;
    this._CarrierGuid = Guid.Empty;
    this.InitializeComponent();
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [field: AccessedThroughProperty("lblOffice")]
  internal virtual Label lblOffice { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblPriorTo")]
  internal virtual Label lblPriorTo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboOffice")]
  internal virtual MGASimpleComboBox cboOffice { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtEntity")]
  internal virtual MGATextBox txtEntity { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGAButton btnEntityLookup
  {
    get => this._btnEntityLookup;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnEntityLookup_Click);
      MGAButton btnEntityLookup1 = this._btnEntityLookup;
      if (btnEntityLookup1 != null)
        ((Control) btnEntityLookup1).Click -= eventHandler;
      this._btnEntityLookup = value;
      MGAButton btnEntityLookup2 = this._btnEntityLookup;
      if (btnEntityLookup2 == null)
        return;
      ((Control) btnEntityLookup2).Click += eventHandler;
    }
  }

  internal virtual MGAButton btnOk
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

  [field: AccessedThroughProperty("lblRemitter")]
  internal virtual Label lblRemitter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGAButton btnCarrierLookup
  {
    get => this._btnCarrierLookup;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnCarrierLookup_Click);
      MGAButton btnCarrierLookup1 = this._btnCarrierLookup;
      if (btnCarrierLookup1 != null)
        ((Control) btnCarrierLookup1).Click -= eventHandler;
      this._btnCarrierLookup = value;
      MGAButton btnCarrierLookup2 = this._btnCarrierLookup;
      if (btnCarrierLookup2 == null)
        return;
      ((Control) btnCarrierLookup2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("txtCarrier")]
  internal virtual MGATextBox txtCarrier { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblCarrier")]
  internal virtual Label lblCarrier { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGAButton btnClearRemitter
  {
    get => this._btnClearRemitter;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnClearRemitter_Click);
      MGAButton btnClearRemitter1 = this._btnClearRemitter;
      if (btnClearRemitter1 != null)
        ((Control) btnClearRemitter1).Click -= eventHandler;
      this._btnClearRemitter = value;
      MGAButton btnClearRemitter2 = this._btnClearRemitter;
      if (btnClearRemitter2 == null)
        return;
      ((Control) btnClearRemitter2).Click += eventHandler;
    }
  }

  internal virtual MGAButton btnClearCarrier
  {
    get => this._btnClearCarrier;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnClearCarrier_Click);
      MGAButton btnClearCarrier1 = this._btnClearCarrier;
      if (btnClearCarrier1 != null)
        ((Control) btnClearCarrier1).Click -= eventHandler;
      this._btnClearCarrier = value;
      MGAButton btnClearCarrier2 = this._btnClearCarrier;
      if (btnClearCarrier2 == null)
        return;
      ((Control) btnClearCarrier2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("dtpFrom")]
  internal virtual MGADateTimePicker dtpFrom { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dtpTo")]
  internal virtual MGADateTimePicker dtpTo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkSortByPolicyNumber")]
  internal virtual MGACheckBox chkSortByPolicyNumber { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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
    this.lblOffice = new Label();
    this.lblRemitter = new Label();
    this.lblPriorTo = new Label();
    this.cboOffice = new MGASimpleComboBox();
    this.dtpFrom = new MGADateTimePicker();
    this.txtEntity = new MGATextBox();
    this.btnEntityLookup = new MGAButton();
    this.btnOk = new MGAButton();
    this.btnCancel = new MGAButton();
    this.btnCarrierLookup = new MGAButton();
    this.txtCarrier = new MGATextBox();
    this.lblCarrier = new Label();
    this.btnClearRemitter = new MGAButton();
    this.btnClearCarrier = new MGAButton();
    this.dtpTo = new MGADateTimePicker();
    this.Label1 = new Label();
    this.chkSortByPolicyNumber = new MGACheckBox();
    ((ISupportInitialize) this.cboOffice).BeginInit();
    ((ISupportInitialize) this.dtpFrom).BeginInit();
    ((ISupportInitialize) this.txtEntity).BeginInit();
    ((ISupportInitialize) this.btnEntityLookup).BeginInit();
    ((ISupportInitialize) this.btnOk).BeginInit();
    ((ISupportInitialize) this.btnCancel).BeginInit();
    ((ISupportInitialize) this.btnCarrierLookup).BeginInit();
    ((ISupportInitialize) this.txtCarrier).BeginInit();
    ((ISupportInitialize) this.btnClearRemitter).BeginInit();
    ((ISupportInitialize) this.btnClearCarrier).BeginInit();
    ((ISupportInitialize) this.dtpTo).BeginInit();
    ((ISupportInitialize) this.chkSortByPolicyNumber).BeginInit();
    this.SuspendLayout();
    this.lblOffice.Location = new Point(2, 10);
    this.lblOffice.Name = "lblOffice";
    this.lblOffice.Size = new Size(64 /*0x40*/, 16 /*0x10*/);
    this.lblOffice.TabIndex = 0;
    this.lblOffice.Text = "Office";
    this.lblOffice.TextAlign = ContentAlignment.MiddleRight;
    this.lblRemitter.Location = new Point(2, 49);
    this.lblRemitter.Name = "lblRemitter";
    this.lblRemitter.Size = new Size(64 /*0x40*/, 16 /*0x10*/);
    this.lblRemitter.TabIndex = 1;
    this.lblRemitter.Text = "Remitter";
    this.lblRemitter.TextAlign = ContentAlignment.MiddleRight;
    this.lblPriorTo.Location = new Point(2, 152);
    this.lblPriorTo.Name = "lblPriorTo";
    this.lblPriorTo.Size = new Size(64 /*0x40*/, 16 /*0x10*/);
    this.lblPriorTo.TabIndex = 2;
    this.lblPriorTo.Text = "From";
    this.lblPriorTo.TextAlign = ContentAlignment.MiddleRight;
    this.cboOffice.BorderStyle = (UIElementBorderStyle) 4;
    this.cboOffice.CharacterCasing = CharacterCasing.Normal;
    this.cboOffice.DisplayStyle = (EmbeddableElementDisplayStyle) 0;
    this.cboOffice.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboOffice).Location = new Point(72, 8);
    this.cboOffice.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboOffice).Name = "cboOffice";
    ((Control) this.cboOffice).Size = new Size(400, 21);
    ((Control) this.cboOffice).TabIndex = 3;
    ((UltraControlBase) this.cboOffice).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboOffice).UseOsThemes = (DefaultableBoolean) 2;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dtpFrom.Appearance = (AppearanceBase) appearance1;
    appearance2.AlphaLevel = (short) 14;
    appearance2.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance2.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance2.BackColorAlpha = (Alpha) 2;
    appearance2.BackGradientAlignment = (GradientAlignment) 4;
    appearance2.BackGradientStyle = (GradientStyle) 5;
    appearance2.BorderAlpha = (Alpha) 1;
    appearance2.BorderColor = Color.FromArgb(78, 122, 171);
    appearance2.ForeColor = Color.FromArgb(49, 85, 153);
    appearance2.ForegroundAlpha = (Alpha) 2;
    this.dtpFrom.ButtonAppearance = (AppearanceBase) appearance2;
    ((Control) this.dtpFrom).Location = new Point(72, 150);
    this.dtpFrom.MGAStyle = MGAStyles.Blue;
    ((Control) this.dtpFrom).Name = "dtpFrom";
    ((Control) this.dtpFrom).Size = new Size(104, 20);
    ((Control) this.dtpFrom).TabIndex = 4;
    ((UltraControlBase) this.dtpFrom).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtpFrom).UseOsThemes = (DefaultableBoolean) 2;
    appearance3.BackColor = Color.White;
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance3.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtEntity).Appearance = (AppearanceBase) appearance3;
    ((TextEditorControlBase) this.txtEntity).BackColor = Color.White;
    ((Control) this.txtEntity).Location = new Point(72, 47);
    this.txtEntity.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtEntity).Name = "txtEntity";
    ((EditorButtonControlBase) this.txtEntity).ReadOnly = true;
    ((Control) this.txtEntity).Size = new Size(304, 20);
    ((Control) this.txtEntity).TabIndex = 5;
    ((UltraControlBase) this.txtEntity).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtEntity).UseOsThemes = (DefaultableBoolean) 2;
    appearance4.BackColor = Color.FromArgb(248, 248, 248);
    appearance4.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance4.BackGradientStyle = (GradientStyle) 2;
    appearance4.BorderColor = Color.DarkGray;
    appearance4.ImageHAlign = (HAlign) 2;
    appearance4.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnEntityLookup).Appearance = (AppearanceBase) appearance4;
    ((Control) this.btnEntityLookup).Location = new Point(384, 37);
    ((Control) this.btnEntityLookup).Name = "btnEntityLookup";
    ((Control) this.btnEntityLookup).Size = new Size(40, 40);
    ((Control) this.btnEntityLookup).TabIndex = 6;
    this.btnEntityLookup.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.btnOk).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance5.BackColor = Color.FromArgb(248, 248, 248);
    appearance5.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance5.BackGradientStyle = (GradientStyle) 2;
    appearance5.BorderColor = Color.DarkGray;
    appearance5.ImageHAlign = (HAlign) 2;
    appearance5.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnOk).Appearance = (AppearanceBase) appearance5;
    ((Control) this.btnOk).Location = new Point(304, 224 /*0xE0*/);
    ((Control) this.btnOk).Name = "btnOk";
    ((Control) this.btnOk).Size = new Size(80 /*0x50*/, 24);
    ((Control) this.btnOk).TabIndex = 7;
    ((ControlBase) this.btnOk).Text = "Ok";
    this.btnOk.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.btnCancel).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance6.BackColor = Color.FromArgb(248, 248, 248);
    appearance6.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance6.BackGradientStyle = (GradientStyle) 2;
    appearance6.BorderColor = Color.DarkGray;
    appearance6.ImageHAlign = (HAlign) 2;
    appearance6.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnCancel).Appearance = (AppearanceBase) appearance6;
    ((UltraButtonBase) this.btnCancel).DialogResult = DialogResult.Cancel;
    ((Control) this.btnCancel).Location = new Point(392, 224 /*0xE0*/);
    ((Control) this.btnCancel).Name = "btnCancel";
    ((Control) this.btnCancel).Size = new Size(80 /*0x50*/, 24);
    ((Control) this.btnCancel).TabIndex = 8;
    ((ControlBase) this.btnCancel).Text = "Cancel";
    this.btnCancel.UseOSThemes = (DefaultableBoolean) 2;
    appearance7.BackColor = Color.FromArgb(248, 248, 248);
    appearance7.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance7.BackGradientStyle = (GradientStyle) 2;
    appearance7.BorderColor = Color.DarkGray;
    appearance7.ImageHAlign = (HAlign) 2;
    appearance7.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnCarrierLookup).Appearance = (AppearanceBase) appearance7;
    ((Control) this.btnCarrierLookup).Location = new Point(384, 92);
    ((Control) this.btnCarrierLookup).Name = "btnCarrierLookup";
    ((Control) this.btnCarrierLookup).Size = new Size(40, 40);
    ((Control) this.btnCarrierLookup).TabIndex = 11;
    this.btnCarrierLookup.UseOSThemes = (DefaultableBoolean) 2;
    appearance8.BackColor = Color.White;
    appearance8.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance8.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtCarrier).Appearance = (AppearanceBase) appearance8;
    ((TextEditorControlBase) this.txtCarrier).BackColor = Color.White;
    ((Control) this.txtCarrier).Location = new Point(73, 102);
    this.txtCarrier.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtCarrier).Name = "txtCarrier";
    ((EditorButtonControlBase) this.txtCarrier).ReadOnly = true;
    ((Control) this.txtCarrier).Size = new Size(304, 20);
    ((Control) this.txtCarrier).TabIndex = 10;
    ((UltraControlBase) this.txtCarrier).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtCarrier).UseOsThemes = (DefaultableBoolean) 2;
    this.lblCarrier.Location = new Point(2, 104);
    this.lblCarrier.Name = "lblCarrier";
    this.lblCarrier.Size = new Size(64 /*0x40*/, 16 /*0x10*/);
    this.lblCarrier.TabIndex = 9;
    this.lblCarrier.Text = "Carrier";
    this.lblCarrier.TextAlign = ContentAlignment.MiddleRight;
    appearance9.BackColor = Color.FromArgb(248, 248, 248);
    appearance9.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance9.BackGradientStyle = (GradientStyle) 2;
    appearance9.BorderColor = Color.DarkGray;
    appearance9.ImageHAlign = (HAlign) 2;
    appearance9.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnClearRemitter).Appearance = (AppearanceBase) appearance9;
    ((Control) this.btnClearRemitter).Location = new Point(432, 37);
    ((Control) this.btnClearRemitter).Name = "btnClearRemitter";
    ((Control) this.btnClearRemitter).Size = new Size(40, 40);
    ((Control) this.btnClearRemitter).TabIndex = 12;
    this.btnClearRemitter.UseOSThemes = (DefaultableBoolean) 2;
    appearance10.BackColor = Color.FromArgb(248, 248, 248);
    appearance10.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance10.BackGradientStyle = (GradientStyle) 2;
    appearance10.BorderColor = Color.DarkGray;
    appearance10.ImageHAlign = (HAlign) 2;
    appearance10.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnClearCarrier).Appearance = (AppearanceBase) appearance10;
    ((Control) this.btnClearCarrier).Location = new Point(431, 92);
    ((Control) this.btnClearCarrier).Name = "btnClearCarrier";
    ((Control) this.btnClearCarrier).Size = new Size(40, 40);
    ((Control) this.btnClearCarrier).TabIndex = 13;
    this.btnClearCarrier.UseOSThemes = (DefaultableBoolean) 2;
    appearance11.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dtpTo.Appearance = (AppearanceBase) appearance11;
    appearance12.AlphaLevel = (short) 14;
    appearance12.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance12.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance12.BackColorAlpha = (Alpha) 2;
    appearance12.BackGradientAlignment = (GradientAlignment) 4;
    appearance12.BackGradientStyle = (GradientStyle) 5;
    appearance12.BorderAlpha = (Alpha) 1;
    appearance12.BorderColor = Color.FromArgb(78, 122, 171);
    appearance12.ForeColor = Color.FromArgb(49, 85, 153);
    appearance12.ForegroundAlpha = (Alpha) 2;
    this.dtpTo.ButtonAppearance = (AppearanceBase) appearance12;
    ((Control) this.dtpTo).Location = new Point(72, 182);
    this.dtpTo.MGAStyle = MGAStyles.Blue;
    ((Control) this.dtpTo).Name = "dtpTo";
    ((Control) this.dtpTo).Size = new Size(104, 20);
    ((Control) this.dtpTo).TabIndex = 15;
    ((UltraControlBase) this.dtpTo).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtpTo).UseOsThemes = (DefaultableBoolean) 2;
    this.Label1.Location = new Point(2, 184);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(64 /*0x40*/, 16 /*0x10*/);
    this.Label1.TabIndex = 14;
    this.Label1.Text = "To";
    this.Label1.TextAlign = ContentAlignment.MiddleRight;
    appearance13.BorderColor = Color.Gray;
    appearance13.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkSortByPolicyNumber).Appearance = (AppearanceBase) appearance13;
    ((Control) this.chkSortByPolicyNumber).Location = new Point(8, 232);
    ((Control) this.chkSortByPolicyNumber).Name = "chkSortByPolicyNumber";
    ((Control) this.chkSortByPolicyNumber).Size = new Size(160 /*0xA0*/, 16 /*0x10*/);
    ((Control) this.chkSortByPolicyNumber).TabIndex = 16 /*0x10*/;
    ((UltraToggleEditorBase) this.chkSortByPolicyNumber).Text = "Sort By Policy Number";
    ((UltraControlBase) this.chkSortByPolicyNumber).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkSortByPolicyNumber).UseOsThemes = (DefaultableBoolean) 2;
    this.AcceptButton = (IButtonControl) this.btnOk;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.CancelButton = (IButtonControl) this.btnCancel;
    this.ClientSize = new Size(482, 256 /*0x0100*/);
    this.Controls.Add((Control) this.chkSortByPolicyNumber);
    this.Controls.Add((Control) this.dtpTo);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.btnClearCarrier);
    this.Controls.Add((Control) this.btnClearRemitter);
    this.Controls.Add((Control) this.btnCarrierLookup);
    this.Controls.Add((Control) this.txtCarrier);
    this.Controls.Add((Control) this.lblCarrier);
    this.Controls.Add((Control) this.btnCancel);
    this.Controls.Add((Control) this.btnOk);
    this.Controls.Add((Control) this.btnEntityLookup);
    this.Controls.Add((Control) this.txtEntity);
    this.Controls.Add((Control) this.dtpFrom);
    this.Controls.Add((Control) this.cboOffice);
    this.Controls.Add((Control) this.lblPriorTo);
    this.Controls.Add((Control) this.lblRemitter);
    this.Controls.Add((Control) this.lblOffice);
    this.Font = new Font("Tahoma", 8.25f);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmBoundAccounts);
    this.Text = "Open Receivables";
    ((ISupportInitialize) this.cboOffice).EndInit();
    ((ISupportInitialize) this.dtpFrom).EndInit();
    ((ISupportInitialize) this.txtEntity).EndInit();
    ((ISupportInitialize) this.btnEntityLookup).EndInit();
    ((ISupportInitialize) this.btnOk).EndInit();
    ((ISupportInitialize) this.btnCancel).EndInit();
    ((ISupportInitialize) this.btnCarrierLookup).EndInit();
    ((ISupportInitialize) this.txtCarrier).EndInit();
    ((ISupportInitialize) this.btnClearRemitter).EndInit();
    ((ISupportInitialize) this.btnClearCarrier).EndInit();
    ((ISupportInitialize) this.dtpTo).EndInit();
    ((ISupportInitialize) this.chkSortByPolicyNumber).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  private void frmOpenReceivables_Load(object sender, EventArgs e)
  {
    DataTable dataTable = Database.Instance.QueryText.PerformTableQuery("SELECT Location, OfficeGuid FROM tblClientOffices");
    MGASimpleComboBox cboOffice = this.cboOffice;
    ((UltraGridBase) cboOffice).DataSource = (object) dataTable;
    ((UltraDropDownBase) cboOffice).ValueMember = "OfficeGuid";
    ((UltraDropDownBase) cboOffice).DisplayMember = "Location";
    ((ControlBase) this.btnEntityLookup).Appearance.Image = (object) ImageCache.Instance.Search;
    ((ControlBase) this.btnCarrierLookup).Appearance.Image = (object) ImageCache.Instance.Search;
    ((ControlBase) this.btnClearCarrier).Appearance.Image = (object) ImageCache.Instance.NewImage;
    ((ControlBase) this.btnClearRemitter).Appearance.Image = (object) ImageCache.Instance.NewImage;
  }

  private void btnCancel_Click(object sender, EventArgs e) => this.Close();

  private void btnOk_Click(object sender, EventArgs e)
  {
    Cursor.Current = Cursors.WaitCursor;
    MGASystems.IMS.Forms.Reports.LaunchThreadedReport(typeof (rptOpenReceivables), new ArrayList()
    {
      (object) (Guid) this.cboOffice.Value,
      (object) this._EntityGuid,
      RuntimeHelpers.GetObjectValue(this.dtpFrom.Value),
      RuntimeHelpers.GetObjectValue(this.dtpTo.Value),
      (object) this._CarrierGuid,
      (object) ((UltraToggleEditorBase) this.chkSortByPolicyNumber).Checked
    }, "Bound Accounts");
    Cursor.Current = Cursors.Default;
  }

  private void btnEntityLookup_Click(object sender, EventArgs e)
  {
  }

  private void btnCarrierLookup_Click(object sender, EventArgs e)
  {
  }

  private void btnClearRemitter_Click(object sender, EventArgs e)
  {
    this._EntityGuid = Guid.Empty;
    ((TextEditorControlBase) this.txtEntity).Text = string.Empty;
  }

  private void btnClearCarrier_Click(object sender, EventArgs e)
  {
    this._CarrierGuid = Guid.Empty;
    ((TextEditorControlBase) this.txtCarrier).Text = string.Empty;
  }
}
