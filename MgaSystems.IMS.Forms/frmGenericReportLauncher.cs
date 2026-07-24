// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Forms.frmGenericReportLauncher
// Assembly: MgaSystems.IMS.Forms, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FB3F392E-40B6-486F-8F0B-A4A494A546D4
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Forms.dll

using GrapeCity.ActiveReports;
using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.Common;
using MGASystems.Common.ErrorHandling;
using MGASystems.Data;
using MGASystems.IMS.Reporting;
using MGASystems.IMS.Reporting.ReportControls;
using MGASystems.IMS.Security;
using MGASystems.Tools;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

#nullable disable
namespace MGASystems.IMS.Forms;

[SecureResource("{6B7EE9D9-E7E6-43F0-B5B3-C30582F30860}", "Allows Users to change the 'Use Reporting Server", "Controls whether or not users can change the 'Use Reporting Server' option.", "Reports")]
public sealed class frmGenericReportLauncher : Form
{
  private IContainer components;
  private ErrorProvider err;
  public const string CanChangeUseReportingServer = "{6B7EE9D9-E7E6-43F0-B5B3-C30582F30860}";
  private const int SpaceFromLeft = 10;
  private const int SpaceBetweenRows = 2;
  private const int ErrorProviderSpace = 30;
  private readonly Type _reportType;
  private readonly BaseReportControl[] _reportControls;
  private readonly string _displayName;
  private Guid _AdHocReportGUID;
  private bool HasColumns;
  private bool _useReportingServerChecked;
  private bool _useReportingServer;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [field: AccessedThroughProperty("pnlControls")]
  private virtual Panel pnlControls { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

  [field: AccessedThroughProperty("MgaComboBox1")]
  internal virtual MGAComboBox MgaComboBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGAButton btnLoad
  {
    get => this._btnLoad;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.Preset_Click);
      MGAButton btnLoad1 = this._btnLoad;
      if (btnLoad1 != null)
        ((Control) btnLoad1).Click -= eventHandler;
      this._btnLoad = value;
      MGAButton btnLoad2 = this._btnLoad;
      if (btnLoad2 == null)
        return;
      ((Control) btnLoad2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("ContextMenuStrip1")]
  internal virtual ContextMenuStrip ContextMenuStrip1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("mnuTraceParameters")]
  internal virtual ToolStripMenuItem mnuTraceParameters { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual ToolStripMenuItem ShowReportLogToolStripMenuItem
  {
    get => this._ShowReportLogToolStripMenuItem;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ShowReportLogToolStripMenuItem_Click);
      ToolStripMenuItem toolStripMenuItem1 = this._ShowReportLogToolStripMenuItem;
      if (toolStripMenuItem1 != null)
        toolStripMenuItem1.Click -= eventHandler;
      this._ShowReportLogToolStripMenuItem = value;
      ToolStripMenuItem toolStripMenuItem2 = this._ShowReportLogToolStripMenuItem;
      if (toolStripMenuItem2 == null)
        return;
      toolStripMenuItem2.Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("chkUseReportingServer")]
  internal virtual MGACheckBox chkUseReportingServer { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("pnlButtons")]
  internal virtual Panel pnlButtons { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    UltraGridBand ultraGridBand = new UltraGridBand("", -1);
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
    Appearance appearance18 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmGenericReportLauncher));
    this.err = new ErrorProvider(this.components);
    this.pnlControls = new Panel();
    this.pnlButtons = new Panel();
    this.ContextMenuStrip1 = new ContextMenuStrip(this.components);
    this.mnuTraceParameters = new ToolStripMenuItem();
    this.ShowReportLogToolStripMenuItem = new ToolStripMenuItem();
    this.chkUseReportingServer = new MGACheckBox();
    this.btnLoad = new MGAButton();
    this.btnOk = new MGAButton();
    this.btnCancel = new MGAButton();
    this.MgaComboBox1 = new MGAComboBox();
    ((ISupportInitialize) this.err).BeginInit();
    this.pnlButtons.SuspendLayout();
    this.ContextMenuStrip1.SuspendLayout();
    ((ISupportInitialize) this.chkUseReportingServer).BeginInit();
    ((ISupportInitialize) this.btnLoad).BeginInit();
    ((ISupportInitialize) this.btnOk).BeginInit();
    ((ISupportInitialize) this.btnCancel).BeginInit();
    ((ISupportInitialize) this.MgaComboBox1).BeginInit();
    this.SuspendLayout();
    this.err.ContainerControl = (ContainerControl) this;
    this.pnlControls.Location = new Point(8, 8);
    this.pnlControls.Name = "pnlControls";
    this.pnlControls.Size = new Size(232, 8);
    this.pnlControls.TabIndex = 102;
    this.pnlButtons.Controls.Add((Control) this.chkUseReportingServer);
    this.pnlButtons.Controls.Add((Control) this.btnLoad);
    this.pnlButtons.Controls.Add((Control) this.btnOk);
    this.pnlButtons.Controls.Add((Control) this.btnCancel);
    this.pnlButtons.Dock = DockStyle.Bottom;
    this.pnlButtons.Location = new Point(0, 21);
    this.pnlButtons.Name = "pnlButtons";
    this.pnlButtons.Size = new Size(411, 40);
    this.pnlButtons.TabIndex = 103;
    this.ContextMenuStrip1.Items.AddRange(new ToolStripItem[2]
    {
      (ToolStripItem) this.mnuTraceParameters,
      (ToolStripItem) this.ShowReportLogToolStripMenuItem
    });
    this.ContextMenuStrip1.Name = "ContextMenuStrip1";
    this.ContextMenuStrip1.Size = new Size(165, 48 /*0x30*/);
    this.mnuTraceParameters.CheckOnClick = true;
    this.mnuTraceParameters.Name = "mnuTraceParameters";
    this.mnuTraceParameters.Size = new Size(164, 22);
    this.mnuTraceParameters.Text = "Trace Parameters";
    this.mnuTraceParameters.Visible = false;
    this.ShowReportLogToolStripMenuItem.Name = "ShowReportLogToolStripMenuItem";
    this.ShowReportLogToolStripMenuItem.Size = new Size(164, 22);
    this.ShowReportLogToolStripMenuItem.Text = "Show Report Log";
    appearance1.BorderColor = Color.Gray;
    appearance1.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkUseReportingServer).Appearance = (AppearanceBase) appearance1;
    ((UltraToggleEditorBase) this.chkUseReportingServer).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkUseReportingServer).Location = new Point(116, 8);
    ((Control) this.chkUseReportingServer).Name = "chkUseReportingServer";
    ((Control) this.chkUseReportingServer).Size = new Size(129, 20);
    ((Control) this.chkUseReportingServer).TabIndex = 106;
    ((UltraToggleEditorBase) this.chkUseReportingServer).Text = "Use Reporting Server";
    ((Control) this.btnLoad).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    appearance2.BackColor = Color.FromArgb(248, 248, 248);
    appearance2.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance2.BackGradientStyle = (GradientStyle) 2;
    appearance2.BorderColor = Color.DarkGray;
    appearance2.ImageHAlign = (HAlign) 2;
    appearance2.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnLoad).Appearance = (AppearanceBase) appearance2;
    ((Control) this.btnLoad).Location = new Point(5, 8);
    ((Control) this.btnLoad).Name = "btnLoad";
    ((Control) this.btnLoad).Size = new Size(104, 24);
    ((Control) this.btnLoad).TabIndex = 105;
    ((ControlBase) this.btnLoad).Text = "Load/Save Criteria";
    this.btnLoad.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.btnOk).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance3.BackColor = Color.FromArgb(248, 248, 248);
    appearance3.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance3.BackGradientStyle = (GradientStyle) 2;
    appearance3.BorderColor = Color.DarkGray;
    appearance3.ImageHAlign = (HAlign) 2;
    appearance3.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnOk).Appearance = (AppearanceBase) appearance3;
    ((Control) this.btnOk).Location = new Point(251, 8);
    ((Control) this.btnOk).Name = "btnOk";
    ((Control) this.btnOk).Size = new Size(74, 24);
    ((Control) this.btnOk).TabIndex = 102;
    ((ControlBase) this.btnOk).Text = "Ok";
    this.btnOk.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.btnCancel).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance4.BackColor = Color.FromArgb(248, 248, 248);
    appearance4.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance4.BackGradientStyle = (GradientStyle) 2;
    appearance4.BorderColor = Color.DarkGray;
    appearance4.ImageHAlign = (HAlign) 2;
    appearance4.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnCancel).Appearance = (AppearanceBase) appearance4;
    ((UltraButtonBase) this.btnCancel).DialogResult = DialogResult.Cancel;
    ((Control) this.btnCancel).Location = new Point(331, 8);
    ((Control) this.btnCancel).Name = "btnCancel";
    ((Control) this.btnCancel).Size = new Size(74, 24);
    ((Control) this.btnCancel).TabIndex = 103;
    ((ControlBase) this.btnCancel).Text = "Cancel";
    this.btnCancel.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.MgaComboBox1).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.MgaComboBox1.BorderStyle = (UIElementBorderStyle) 4;
    appearance5.BackColor = Color.White;
    appearance5.BorderColor = Color.FromArgb(78, 122, 171);
    this.MgaComboBox1.DisplayLayout.Appearance = (AppearanceBase) appearance5;
    this.MgaComboBox1.DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand.ColHeadersVisible = false;
    this.MgaComboBox1.DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    this.MgaComboBox1.DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    this.MgaComboBox1.DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    appearance6.BackColor = SystemColors.ActiveBorder;
    appearance6.BackColor2 = SystemColors.ControlDark;
    appearance6.BackGradientStyle = (GradientStyle) 2;
    appearance6.BorderColor = SystemColors.Window;
    ((SpecialBoxBase) this.MgaComboBox1.DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance6;
    appearance7.ForeColor = SystemColors.GrayText;
    this.MgaComboBox1.DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance7;
    ((SpecialBoxBase) this.MgaComboBox1.DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    appearance8.BackColor = SystemColors.ControlLightLight;
    appearance8.BackColor2 = SystemColors.Control;
    appearance8.BackGradientStyle = (GradientStyle) 3;
    appearance8.ForeColor = SystemColors.GrayText;
    this.MgaComboBox1.DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance8;
    this.MgaComboBox1.DisplayLayout.MaxColScrollRegions = 1;
    this.MgaComboBox1.DisplayLayout.MaxRowScrollRegions = 1;
    appearance9.BackColor = SystemColors.Window;
    appearance9.ForeColor = SystemColors.ControlText;
    this.MgaComboBox1.DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance9;
    appearance10.BackColor = SystemColors.Highlight;
    appearance10.ForeColor = SystemColors.HighlightText;
    this.MgaComboBox1.DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance10;
    this.MgaComboBox1.DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    this.MgaComboBox1.DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 2;
    appearance11.BackColor = SystemColors.Window;
    this.MgaComboBox1.DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance11;
    appearance12.BorderColor = Color.Silver;
    appearance12.TextTrimming = (TextTrimming) 3;
    this.MgaComboBox1.DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance12;
    this.MgaComboBox1.DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    this.MgaComboBox1.DisplayLayout.Override.CellPadding = 0;
    appearance13.BackColor = SystemColors.Control;
    appearance13.BackColor2 = SystemColors.ControlDark;
    appearance13.BackGradientAlignment = (GradientAlignment) 1;
    appearance13.BackGradientStyle = (GradientStyle) 3;
    appearance13.BorderColor = SystemColors.Window;
    this.MgaComboBox1.DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance13;
    ((AppearanceBase) appearance14).TextHAlignAsString = "Left";
    this.MgaComboBox1.DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance14;
    this.MgaComboBox1.DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    this.MgaComboBox1.DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    appearance15.BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    appearance15.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this.MgaComboBox1.DisplayLayout.Override.HotTrackRowAppearance = (AppearanceBase) appearance15;
    appearance16.BackColor = SystemColors.Window;
    appearance16.BorderColor = Color.White;
    this.MgaComboBox1.DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance16;
    this.MgaComboBox1.DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    this.MgaComboBox1.DisplayLayout.Override.RowSpacingAfter = 1;
    appearance17.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance17.BorderColor = Color.FromArgb((int) byte.MaxValue, 214, 88);
    appearance17.ForeColor = Color.Black;
    this.MgaComboBox1.DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance17;
    appearance18.BackColor = SystemColors.ControlLight;
    this.MgaComboBox1.DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance18;
    scrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
    this.MgaComboBox1.DisplayLayout.ScrollBarLook = scrollBarLook;
    this.MgaComboBox1.DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    this.MgaComboBox1.DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    this.MgaComboBox1.DisplayLayout.ViewStyleBand = (ViewStyleBand) 2;
    this.MgaComboBox1.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.MgaComboBox1).DropDownWidth = 190;
    ((Control) this.MgaComboBox1).Font = new Font("Tahoma", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.MgaComboBox1).Location = new Point(71, 8);
    ((UltraDropDownBase) this.MgaComboBox1).MaxDropDownItems = 2;
    this.MgaComboBox1.MGAStyle = MGAStyles.Blue;
    ((Control) this.MgaComboBox1).Name = "MgaComboBox1";
    ((Control) this.MgaComboBox1).Size = new Size(91, 24);
    ((Control) this.MgaComboBox1).TabIndex = 104;
    ((UltraControlBase) this.MgaComboBox1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaComboBox1).UseOsThemes = (DefaultableBoolean) 2;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.BackgroundImageLayout = ImageLayout.Stretch;
    this.ClientSize = new Size(411, 61);
    this.Controls.Add((Control) this.pnlButtons);
    this.Controls.Add((Control) this.pnlControls);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ForeColor = Color.Black;
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.Name = nameof (frmGenericReportLauncher);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "[Launch Form]";
    ((ISupportInitialize) this.err).EndInit();
    this.pnlButtons.ResumeLayout(false);
    this.ContextMenuStrip1.ResumeLayout(false);
    ((ISupportInitialize) this.chkUseReportingServer).EndInit();
    ((ISupportInitialize) this.btnLoad).EndInit();
    ((ISupportInitialize) this.btnOk).EndInit();
    ((ISupportInitialize) this.btnCancel).EndInit();
    ((ISupportInitialize) this.MgaComboBox1).EndInit();
    this.ResumeLayout(false);
  }

  public frmGenericReportLauncher(
    Type reportType,
    string displayName,
    BaseReportControl[] reportControls)
  {
    this.Load += new EventHandler(this.frmLaunchForm_Load);
    this.Shown += new EventHandler(this.frmGenericReportLauncher_Shown);
    this._AdHocReportGUID = Guid.Empty;
    this.HasColumns = false;
    this._useReportingServerChecked = false;
    this._useReportingServer = false;
    this.InitializeComponent();
    this._reportControls = reportControls;
    this._displayName = displayName;
    this._reportType = reportType;
    this.Text = this._displayName;
  }

  public frmGenericReportLauncher(
    Type reportType,
    string displayName,
    BaseReportControl[] reportControls,
    Guid AdHocReportGUID)
  {
    this.Load += new EventHandler(this.frmLaunchForm_Load);
    this.Shown += new EventHandler(this.frmGenericReportLauncher_Shown);
    this._AdHocReportGUID = Guid.Empty;
    this.HasColumns = false;
    this._useReportingServerChecked = false;
    this._useReportingServer = false;
    this.InitializeComponent();
    this._reportControls = reportControls;
    this._displayName = displayName;
    this._reportType = reportType;
    this.Text = this._displayName;
    if (Information.IsNothing((object) AdHocReportGUID) || AdHocReportGUID.Equals(Guid.Empty))
      return;
    this._AdHocReportGUID = AdHocReportGUID;
  }

  private void frmLaunchForm_Load(object sender, EventArgs e)
  {
    if (this._reportControls.Length < 1)
    {
      this.LaunchReport();
      this.BeginInvoke((Delegate) new MethodInvoker(this.CloseMe));
    }
    else
    {
      BaseReportControl[] reportControls = this._reportControls;
      int index = 0;
      while (index < reportControls.Length)
      {
        if (Information.IsNothing((object) reportControls[index]))
          this.HasColumns = true;
        checked { ++index; }
      }
      if (this.HasColumns)
        this.LoadControlLayoutColumns();
      else
        this.LoadControlLayout();
      this._useReportingServer = MGASystems.IMS.NoteDocuments.SystemSettings.GetSetting<bool>("UseReportingServer", false);
      if (this._useReportingServer && !this._AdHocReportGUID.Equals(Guid.Empty) || (MGAReport) ObjectFactory.Instance.CreateObject(this._reportType) is ISupportReportDatabase)
      {
        this._useReportingServerChecked = MGASystems.IMS.NoteDocuments.SystemSettings.GetSetting<bool>("UseReportingServerChecked", false);
        if (this._useReportingServerChecked)
          ((UltraToggleEditorBase) this.chkUseReportingServer).CheckState = CheckState.Checked;
        else
          ((UltraToggleEditorBase) this.chkUseReportingServer).CheckState = CheckState.Unchecked;
      }
      else
        ((Control) this.chkUseReportingServer).Visible = false;
      ((Control) this.chkUseReportingServer).Enabled = SecurityManager.Instance.AssertPermission("{6B7EE9D9-E7E6-43F0-B5B3-C30582F30860}");
      this.ContextMenuStrip = this.ContextMenuStrip1;
      if (SecurityManager.Instance.AssertPermission("{92DE09B8-0E0E-471A-95F3-8CCB5A88410A}"))
        this.ShowReportLogToolStripMenuItem.Visible = true;
      else
        this.ShowReportLogToolStripMenuItem.Visible = false;
      if (CurrentUser.IsMGADeveloper)
        this.mnuTraceParameters.Visible = true;
      else
        this.mnuTraceParameters.Visible = false;
      if (!this.mnuTraceParameters.Visible && !this.ShowReportLogToolStripMenuItem.Visible)
        this.ContextMenuStrip.Visible = false;
      int num = 0;
      if (this.Height <= MDIControls.Instance.MDIParent.ClientSize.Height)
        return;
      try
      {
        foreach (BaseReportControl control in this.pnlControls.Controls)
        {
          control.Compress();
          control.Top = num;
          num += control.Height;
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      this.pnlControls.Height = num;
      this.MinimumSize = new Size(this.Size.Width, this.pnlControls.Height + this.pnlButtons.Height + 20);
      this.ClientSize = new Size(this.ClientSize.Width, this.pnlControls.Height + this.pnlButtons.Height + 20);
    }
  }

  private void frmGenericReportLauncher_Resize(object sender, EventArgs e)
  {
    this.pnlControls.Width = this.ClientSize.Width - this.pnlControls.Left * 2;
    if (this.WindowState == FormWindowState.Maximized)
      this.AutoScroll = true;
    else
      this.AutoScroll = false;
  }

  private void pnlControls_Resize(object sender, EventArgs e)
  {
    int num = this.pnlControls.Width / 2;
    if (this.HasColumns)
    {
      int NewWidth = this.pnlControls.Width / 2 - 30;
      try
      {
        foreach (BaseReportControl control in this.pnlControls.Controls)
        {
          if (control.Left > 10)
            control.Left = num;
          control.AdjustWidth(NewWidth);
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
    else
    {
      int NewWidth = this.pnlControls.Width - 30;
      try
      {
        foreach (BaseReportControl control in this.pnlControls.Controls)
          control.AdjustWidth(NewWidth);
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
  }

  private void frmGenericReportLauncher_Shown(object sender, EventArgs e)
  {
    this.Resize += new EventHandler(this.frmGenericReportLauncher_Resize);
    this.pnlControls.Resize += new EventHandler(this.pnlControls_Resize);
  }

  private void btnCancel_Click(object sender, EventArgs e) => this.Close();

  private void btnOk_Click(object sender, EventArgs e)
  {
    Cursor.Current = Cursors.WaitCursor;
    this.LaunchReport();
    Cursor.Current = Cursors.Default;
  }

  private void CloseMe() => this.Close();

  private void LoadControlLayoutColumns()
  {
    int num1 = 0;
    int num2 = 0;
    int num3 = 0;
    int num4 = 0;
    int num5 = 10;
    BaseReportControl[] reportControls = this._reportControls;
    int index = 0;
    while (index < reportControls.Length)
    {
      BaseReportControl Expression = reportControls[index];
      if (Information.IsNothing((object) Expression))
      {
        num5 = num1;
        num1 *= 2;
        num3 = 0;
      }
      else
      {
        Expression.Left = num5;
        Expression.Top = num3;
        Expression.TabIndex = num4;
        this.pnlControls.Controls.Add((Control) Expression);
        num3 += Expression.Height + 2;
        ++num4;
        if (num1 < Expression.Width + 30)
          num1 = Expression.Width + 30;
        if (num2 < Expression.Top + Expression.Height + 2)
          num2 = Expression.Top + Expression.Height + 2;
      }
      checked { ++index; }
    }
    this.pnlControls.Width = num1;
    this.pnlControls.Height = num2;
    this.Width = num1 + this.pnlControls.Left * 2;
    this.Height += num2;
    this.MinimumSize = new Size(this.pnlControls.Width + 30, this.pnlControls.Height + this.pnlButtons.Height * 2);
    if (this.pnlControls.Controls.Count > 0)
      this.pnlControls.Controls[0].Focus();
    Application.DoEvents();
    this.Left = 50;
    this.Top = 50;
  }

  private void LoadControlLayout()
  {
    int num1 = 0;
    int num2 = 0;
    int num3 = 0;
    int num4 = 0;
    int num5 = 0;
    BaseReportControl[] reportControls = this._reportControls;
    int index = 0;
    while (index < reportControls.Length)
    {
      BaseReportControl baseReportControl = reportControls[index];
      baseReportControl.Left = 10;
      baseReportControl.Top = num3;
      baseReportControl.TabIndex = num4;
      this.pnlControls.Controls.Add((Control) baseReportControl);
      num3 += baseReportControl.Height + 2;
      ++num4;
      if (num1 < baseReportControl.Width + 30)
        num1 = baseReportControl.Width + 30;
      num2 += baseReportControl.Height + 2;
      if (baseReportControl.Width > num5)
        num5 = baseReportControl.Width;
      checked { ++index; }
    }
    this.pnlControls.Width = num1;
    this.pnlControls.Height = num2;
    if (this.Width < num1 + this.pnlControls.Left * 2)
      this.Width = num1 + this.pnlControls.Left * 2;
    this.Height += num2;
    this.MinimumSize = new Size(this.pnlControls.Width + 30, this.pnlControls.Height + this.pnlButtons.Height * 2);
    if (this.pnlControls.Controls.Count <= 0)
      return;
    this.pnlControls.Controls[0].Focus();
  }

  private bool validateData()
  {
    bool flag = true;
    try
    {
      foreach (BaseReportControl control in this.pnlControls.Controls)
      {
        if (!control.IsInputValid)
        {
          this.err.SetError((Control) control, control.InputErrorMessage);
          flag = false;
        }
        else
          this.err.SetError((Control) control, string.Empty);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    return flag;
  }

  private ArrayList getTypedParamList()
  {
    ArrayList typedParamList = new ArrayList();
    try
    {
      foreach (BaseReportControl control in this.pnlControls.Controls)
      {
        if (control.Value is Array)
        {
          Array array = (Array) control.Value;
          int num = array.Length - 1;
          for (int index = 0; index <= num; ++index)
            typedParamList.Add(RuntimeHelpers.GetObjectValue(array.GetValue(index)));
        }
        else
          typedParamList.Add(RuntimeHelpers.GetObjectValue(control.Value));
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    return typedParamList;
  }

  public void setFromTypedParamList(ArrayList reportValues)
  {
    int index1 = 0;
    try
    {
      foreach (BaseReportControl control in this.pnlControls.Controls)
      {
        if (control.Value is Array)
        {
          Array array = (Array) control.Value;
          ArrayList arrayList = new ArrayList();
          int num = array.Length - 1;
          for (int index2 = 0; index2 <= num; ++index2)
          {
            arrayList.Add(RuntimeHelpers.GetObjectValue(reportValues[index1]));
            ++index1;
          }
          control.Value = (object) arrayList.ToArray();
        }
        else
        {
          control.Value = RuntimeHelpers.GetObjectValue(reportValues[index1]);
          ++index1;
        }
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void LaunchReport()
  {
    if (!this.validateData())
      return;
    ArrayList typedParamList = this.getTypedParamList();
    if (this.mnuTraceParameters.Checked)
    {
      frmShowParams frmShowParams = new frmShowParams(typedParamList);
      frmShowParams.MdiParent = MDIControls.Instance.MDIParent;
      frmShowParams.Show();
    }
    if (this._AdHocReportGUID.Equals(Guid.Empty))
      this.LaunchCannedReport(typedParamList);
    else
      this.LaunchAdHocReport(typedParamList);
  }

  private string GetDecryptedReportPassword()
  {
    string decryptedReportPassword = string.Empty;
    string setting = MGASystems.IMS.NoteDocuments.SystemSettings.GetSetting<string>("ReportingConfiguration", "");
    if (!string.IsNullOrWhiteSpace(setting))
      decryptedReportPassword = new Encryption().DecryptTripleDes(setting);
    return decryptedReportPassword;
  }

  private void SetReportDatabase(ref MGAReport report)
  {
    if (!(report is ISupportReportDatabase))
      return;
    ISupportReportDatabase supportReportDatabase = report as ISupportReportDatabase;
    supportReportDatabase.ReportDatabase = (Database) null;
    if (((UltraToggleEditorBase) this.chkUseReportingServer).Checked)
    {
      try
      {
        string decryptedReportPassword = this.GetDecryptedReportPassword();
        if (!string.IsNullOrWhiteSpace(decryptedReportPassword))
          supportReportDatabase.ReportDatabase = new Database(decryptedReportPassword, "System.Data.SqlClient");
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ErrorHandler.SilentLogError(ex);
        ProjectData.ClearProjectError();
      }
    }
    else if (this._useReportingServerChecked)
      CurrentUser.Instance.LogAction("User unchecked 'Use Reporting Server'", this.GetReportGuid(), this._displayName);
    if (supportReportDatabase.ReportDatabase != null)
      return;
    supportReportDatabase.ReportDatabase = new Database(DefaultDatabase.ConnectionString, "System.Data.SqlClient");
  }

  private void LaunchCannedReport(ArrayList TypedParamList)
  {
    if (((MGAReport) ObjectFactory.Instance.CreateObject(this._reportType)).IsThreaded)
    {
      frmThreadedReportGeneration reportGeneration = new frmThreadedReportGeneration(this._reportType, TypedParamList, this._displayName);
      reportGeneration.MdiParent = MDIControls.Instance.MDIParent;
      MGAReport report = reportGeneration.Report;
      report.ReportLogID = this.LogReportAction(report, TypedParamList, this._AdHocReportGUID);
      this.SetReportDatabase(ref report);
      reportGeneration.Show();
    }
    else
    {
      this.Cursor = Cursors.WaitCursor;
      try
      {
        MGAReport report = (MGAReport) ObjectFactory.Instance.CreateObject(this._reportType, TypedParamList.ToArray());
        report.CurrentUserGuid = CurrentUser.Instance.UserGUID;
        report.ReportLogID = this.LogReportAction(report, TypedParamList, this._AdHocReportGUID);
        this.SetReportDatabase(ref report);
        report.Document.Printer.PrinterName = string.Empty;
        try
        {
          ReportingTraceListener.RunCannedReportAndLogSqlDetails((SectionReport) report);
        }
        catch (NullReferenceException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          int num = (int) MessageBox.Show("An error has occured when trying to run this report.\n\nPlease contact technical support", "Unable to Run Report", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          ProjectData.ClearProjectError();
          return;
        }
        if (!report.HasRecords)
        {
          int num1 = (int) MessageBox.Show("No results were found based on your criteria", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        else
        {
          report.Document.Name = this._displayName;
          ReportFactory.Instance.ShowReport((SectionReport) report);
        }
      }
      finally
      {
        this.Cursor = Cursors.Default;
      }
    }
  }

  private void LaunchAdHocReport(ArrayList TypedParamList)
  {
    if (this._useReportingServer && this._useReportingServerChecked && !((UltraToggleEditorBase) this.chkUseReportingServer).Checked)
      CurrentUser.Instance.LogAction("User unchecked 'Use Reporting Server'", this.GetReportGuid(), this._displayName);
    TypedParamList.Add((object) ("UseReportingServer" + ((UltraToggleEditorBase) this.chkUseReportingServer).Checked.ToString()));
    TypedParamList.Insert(0, (object) this._AdHocReportGUID);
    if (new AdHocReport(this._AdHocReportGUID).isThreaded)
    {
      frmThreadedReportGeneration reportGeneration = new frmThreadedReportGeneration(this._reportType, TypedParamList, this._displayName, this._AdHocReportGUID);
      reportGeneration.MdiParent = MDIControls.Instance.MDIParent;
      MGAReport report = reportGeneration.Report;
      report.ReportLogID = this.LogReportAction(report, TypedParamList, this._AdHocReportGUID);
      reportGeneration.Show();
    }
    else
    {
      this.Cursor = Cursors.WaitCursor;
      try
      {
        MGAReport mgaReport = (MGAReport) ObjectFactory.Instance.CreateObject(this._reportType, TypedParamList.ToArray());
        mgaReport.CurrentUserGuid = CurrentUser.Instance.UserGUID;
        mgaReport.ReportLogID = this.LogReportAction(mgaReport, TypedParamList, this._AdHocReportGUID);
        mgaReport.Document.Printer.PrinterName = string.Empty;
        try
        {
          ReportingTraceListener.RunAdHocReportAndLogSqlDetails((SectionReport) mgaReport, this._displayName, this._AdHocReportGUID);
        }
        catch (NullReferenceException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          int num = (int) MessageBox.Show("An error has occured when trying to run this report.\n\nPlease contact technical support", "Unable to Run Report", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          ProjectData.ClearProjectError();
          return;
        }
        if (!mgaReport.HasRecords)
        {
          int num1 = (int) MessageBox.Show("No results were found based on your criteria", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        else
        {
          mgaReport.Document.Name = this._displayName;
          ReportFactory.Instance.ShowReport((SectionReport) mgaReport);
        }
      }
      finally
      {
        this.Cursor = Cursors.Default;
      }
    }
  }

  private int LogReportAction(MGAReport Report, ArrayList Criteria, Guid AdHocReportGUID)
  {
    int result = 0;
    string str1;
    Guid guid;
    if (AdHocReportGUID.Equals(Guid.Empty))
    {
      SecureReportResourceAttribute secureReportResource = this.GetSecureReportResource(this._reportType);
      str1 = $"{secureReportResource.ReportCategory}/{secureReportResource.Name}";
      guid = secureReportResource.UniqueIdentifier;
    }
    else
    {
      AdHocReport adHocReport = new AdHocReport(AdHocReportGUID);
      str1 = $"{adHocReport.GroupName}/{adHocReport.ReportName}";
      guid = adHocReport.GUID;
    }
    string str2 = $"Ran {str1} Report";
    string str3 = this.SerializeArrayList(Criteria);
    int.TryParse(RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(nameof (LogReportAction), new object[10]
    {
      (object) "@userID",
      (object) CurrentUser.Instance.UserID,
      (object) "@action",
      (object) str2,
      (object) "@reportGuid",
      (object) guid,
      (object) "@CriteriaXML",
      (object) str3,
      (object) "@Context",
      (object) str1
    })).ToString(), out result);
    return result;
  }

  private SecureReportResourceAttribute GetSecureReportResource(Type ReportType)
  {
    SecureReportResourceAttribute searchAttribute = new SecureReportResourceAttribute();
    return (SecureReportResourceAttribute) ObjectFactory.GetAttributeFromType(ReportType, (Attribute) searchAttribute);
  }

  private string SerializeArrayList(ArrayList obj)
  {
    XmlDocument xmlDocument = new XmlDocument();
    using (MemoryStream inStream = new MemoryStream())
    {
      new XmlSerializer(typeof (ArrayList), new Type[1]
      {
        typeof (DBNull)
      }).Serialize((Stream) inStream, (object) obj);
      inStream.Position = 0L;
      xmlDocument.Load((Stream) inStream);
      return xmlDocument.InnerXml;
    }
  }

  private void Preset_Click(object sender, EventArgs e)
  {
    frmGenericReportPresets genericReportPresets = new frmGenericReportPresets(this._displayName, this.GetReportGuid(), this.getTypedParamList(), "LOAD");
    int num1 = (int) genericReportPresets.ShowDialog();
    if (!(Operators.CompareString(genericReportPresets.FormExitMode, "LOAD", false) == 0 & !genericReportPresets.FormCancel))
      return;
    ArrayList reportPresets = genericReportPresets.ReportPresets;
    try
    {
      this.setFromTypedParamList(reportPresets);
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      switch (ex)
      {
        case InvalidCastException _:
        case NullReferenceException _:
          int num2 = (int) MessageBox.Show("This report was modified after preset was created.", "Preset is invalid", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          break;
      }
      ProjectData.ClearProjectError();
    }
  }

  private Guid GetReportGuid()
  {
    return !this._AdHocReportGUID.Equals(Guid.Empty) ? this._AdHocReportGUID : this.GetSecureReportResource(this._reportType).UniqueIdentifier;
  }

  private void ShowReportLogToolStripMenuItem_Click(object sender, EventArgs e)
  {
    frmReportLog frmReportLog = new frmReportLog(!this._AdHocReportGUID.Equals(Guid.Empty) ? this._AdHocReportGUID : this.GetSecureReportResource(this._reportType).UniqueIdentifier, this);
    frmReportLog.MdiParent = MDIControls.Instance.MDIParent;
    frmReportLog.Show();
  }

  public Guid ReportGUID
  {
    get
    {
      Guid reportGuid;
      if (!this._AdHocReportGUID.Equals(Guid.Empty))
      {
        reportGuid = this._AdHocReportGUID;
      }
      else
      {
        Guid guid = Guid.Empty;
        try
        {
          foreach (CustomAttributeData customAttribute in this._reportType.CustomAttributes)
          {
            if ((object) customAttribute.AttributeType == (object) typeof (SecureReportResourceAttribute))
              guid = new Guid(customAttribute.ConstructorArguments[0].Value.ToString());
          }
        }
        finally
        {
          IEnumerator<CustomAttributeData> enumerator;
          enumerator?.Dispose();
        }
        reportGuid = guid;
      }
      return reportGuid;
    }
  }
}
