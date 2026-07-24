// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.AdHocReportManager.frmAdHocReportLauncher
// Assembly: MGASystems.IMS.AdHocReportManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 82F2F291-BD8F-4EDC-8925-41D0C4FA14AC
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.AdHocReportManager.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.Common;
using MGASystems.IMS.Forms;
using MGASystems.IMS.Reporting;
using MGASystems.IMS.Reporting.ReportControls;
using MGASystems.IMS.Security;
using MGASystems.Tools;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using System.Xml;

#nullable disable
namespace MGASystems.IMS.AdHocReportManager;

public class frmAdHocReportLauncher : Form
{
  private IContainer components;
  private ErrorProvider err;
  private Panel pnlControls;
  private MGAButton withEventsField_btnOk;
  private MGAButton withEventsField_btnCancel;
  internal MGAComboBox MgaComboBox1;
  private MGAButton withEventsField_btnLoad;
  internal ContextMenuStrip ContextMenuStrip1;
  internal ToolStripMenuItem mnuTraceParameters;
  internal Panel pnlButtons;
  private Type _reportType;
  private BaseReportControl[] _reportControls;
  private string _displayName;
  private Guid _AdHocReportGUID = Guid.Empty;
  private SqlCommand cmd;
  private string _layout;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  internal MGAButton btnOk
  {
    get => this.withEventsField_btnOk;
    set
    {
      if (this.withEventsField_btnOk != null)
        ((Control) this.withEventsField_btnOk).Click -= new EventHandler(this.btnOk_Click);
      this.withEventsField_btnOk = value;
      if (this.withEventsField_btnOk == null)
        return;
      ((Control) this.withEventsField_btnOk).Click += new EventHandler(this.btnOk_Click);
    }
  }

  internal MGAButton btnCancel
  {
    get => this.withEventsField_btnCancel;
    set
    {
      if (this.withEventsField_btnCancel != null)
        ((Control) this.withEventsField_btnCancel).Click -= new EventHandler(this.btnCancel_Click);
      this.withEventsField_btnCancel = value;
      if (this.withEventsField_btnCancel == null)
        return;
      ((Control) this.withEventsField_btnCancel).Click += new EventHandler(this.btnCancel_Click);
    }
  }

  internal MGAButton btnLoad
  {
    get => this.withEventsField_btnLoad;
    set
    {
      if (this.withEventsField_btnLoad != null)
        ((Control) this.withEventsField_btnLoad).Click -= new EventHandler(this.MgaButton1_Click);
      this.withEventsField_btnLoad = value;
      if (this.withEventsField_btnLoad == null)
        return;
      ((Control) this.withEventsField_btnLoad).Click += new EventHandler(this.MgaButton1_Click);
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    UltraGridBand ultraGridBand = new UltraGridBand("", -1);
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmAdHocReportLauncher));
    this.err = new ErrorProvider(this.components);
    this.pnlControls = new Panel();
    this.pnlButtons = new Panel();
    this.btnLoad = new MGAButton();
    this.btnOk = new MGAButton();
    this.btnCancel = new MGAButton();
    this.MgaComboBox1 = new MGAComboBox();
    this.ContextMenuStrip1 = new ContextMenuStrip(this.components);
    this.mnuTraceParameters = new ToolStripMenuItem();
    ((ISupportInitialize) this.err).BeginInit();
    this.pnlButtons.SuspendLayout();
    ((ISupportInitialize) this.btnLoad).BeginInit();
    ((ISupportInitialize) this.btnOk).BeginInit();
    ((ISupportInitialize) this.btnCancel).BeginInit();
    ((ISupportInitialize) this.MgaComboBox1).BeginInit();
    this.ContextMenuStrip1.SuspendLayout();
    this.SuspendLayout();
    this.err.ContainerControl = (ContainerControl) this;
    this.pnlControls.Location = new Point(8, 8);
    this.pnlControls.Name = "pnlControls";
    this.pnlControls.Size = new Size(232, 8);
    this.pnlControls.TabIndex = 102;
    this.pnlButtons.Controls.Add((Control) this.btnLoad);
    this.pnlButtons.Controls.Add((Control) this.btnOk);
    this.pnlButtons.Controls.Add((Control) this.btnCancel);
    this.pnlButtons.Dock = DockStyle.Bottom;
    this.pnlButtons.Location = new Point(0, 21);
    this.pnlButtons.Name = "pnlButtons";
    this.pnlButtons.Size = new Size(277, 40);
    this.pnlButtons.TabIndex = 103;
    ((Control) this.btnLoad).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    ((AppearanceBase) appearance1).BackColor = Color.FromArgb(Convert.ToInt32(Convert.ToByte(248)), Convert.ToInt32(Convert.ToByte(248)), Convert.ToInt32(Convert.ToByte(248)));
    ((AppearanceBase) appearance1).BackColor2 = Color.FromArgb(Convert.ToInt32(Convert.ToByte(250)), Convert.ToInt32(Convert.ToByte(250)), Convert.ToInt32(Convert.ToByte(250)));
    ((AppearanceBase) appearance1).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance1).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance1).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance1).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnLoad).Appearance = (AppearanceBase) appearance1;
    ((Control) this.btnLoad).Location = new Point(5, 8);
    ((Control) this.btnLoad).Name = "btnLoad";
    ((Control) this.btnLoad).Size = new Size(104, 24);
    ((Control) this.btnLoad).TabIndex = 105;
    ((Control) this.btnLoad).Text = "Load/Save Criteria";
    this.btnLoad.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.btnOk).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    ((AppearanceBase) appearance2).BackColor = Color.FromArgb(Convert.ToInt32(Convert.ToByte(248)), Convert.ToInt32(Convert.ToByte(248)), Convert.ToInt32(Convert.ToByte(248)));
    ((AppearanceBase) appearance2).BackColor2 = Color.FromArgb(Convert.ToInt32(Convert.ToByte(250)), Convert.ToInt32(Convert.ToByte(250)), Convert.ToInt32(Convert.ToByte(250)));
    ((AppearanceBase) appearance2).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance2).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance2).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance2).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnOk).Appearance = (AppearanceBase) appearance2;
    ((Control) this.btnOk).Location = new Point(117, 8);
    ((Control) this.btnOk).Name = "btnOk";
    ((Control) this.btnOk).Size = new Size(74, 24);
    ((Control) this.btnOk).TabIndex = 102;
    ((Control) this.btnOk).Text = "Ok";
    this.btnOk.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.btnCancel).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    ((AppearanceBase) appearance3).BackColor = Color.FromArgb(Convert.ToInt32(Convert.ToByte(248)), Convert.ToInt32(Convert.ToByte(248)), Convert.ToInt32(Convert.ToByte(248)));
    ((AppearanceBase) appearance3).BackColor2 = Color.FromArgb(Convert.ToInt32(Convert.ToByte(250)), Convert.ToInt32(Convert.ToByte(250)), Convert.ToInt32(Convert.ToByte(250)));
    ((AppearanceBase) appearance3).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance3).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance3).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance3).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnCancel).Appearance = (AppearanceBase) appearance3;
    ((UltraButtonBase) this.btnCancel).DialogResult = DialogResult.Cancel;
    ((Control) this.btnCancel).Location = new Point(197, 8);
    ((Control) this.btnCancel).Name = "btnCancel";
    ((Control) this.btnCancel).Size = new Size(74, 24);
    ((Control) this.btnCancel).TabIndex = 103;
    ((Control) this.btnCancel).Text = "Cancel";
    this.btnCancel.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.MgaComboBox1).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.MgaComboBox1.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance4).BackColor = Color.White;
    ((AppearanceBase) appearance4).BorderColor = Color.FromArgb(Convert.ToInt32(Convert.ToByte(78)), Convert.ToInt32(Convert.ToByte(122)), Convert.ToInt32(Convert.ToByte(171)));
    this.MgaComboBox1.DisplayLayout.Appearance = (AppearanceBase) appearance4;
    this.MgaComboBox1.DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand.ColHeadersVisible = false;
    this.MgaComboBox1.DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    this.MgaComboBox1.DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    this.MgaComboBox1.DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance5).BackColor = SystemColors.ActiveBorder;
    ((AppearanceBase) appearance5).BackColor2 = SystemColors.ControlDark;
    ((AppearanceBase) appearance5).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance5).BorderColor = SystemColors.Window;
    ((SpecialBoxBase) this.MgaComboBox1.DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance5;
    ((AppearanceBase) appearance6).ForeColor = SystemColors.GrayText;
    this.MgaComboBox1.DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance6;
    ((SpecialBoxBase) this.MgaComboBox1.DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance7).BackColor = SystemColors.ControlLightLight;
    ((AppearanceBase) appearance7).BackColor2 = SystemColors.Control;
    ((AppearanceBase) appearance7).BackGradientStyle = (GradientStyle) 3;
    ((AppearanceBase) appearance7).ForeColor = SystemColors.GrayText;
    this.MgaComboBox1.DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance7;
    this.MgaComboBox1.DisplayLayout.MaxColScrollRegions = 1;
    this.MgaComboBox1.DisplayLayout.MaxRowScrollRegions = 1;
    ((AppearanceBase) appearance8).BackColor = SystemColors.Window;
    ((AppearanceBase) appearance8).ForeColor = SystemColors.ControlText;
    this.MgaComboBox1.DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance8;
    ((AppearanceBase) appearance9).BackColor = SystemColors.Highlight;
    ((AppearanceBase) appearance9).ForeColor = SystemColors.HighlightText;
    this.MgaComboBox1.DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance9;
    this.MgaComboBox1.DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    this.MgaComboBox1.DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 2;
    ((AppearanceBase) appearance10).BackColor = SystemColors.Window;
    this.MgaComboBox1.DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance10;
    ((AppearanceBase) appearance11).BorderColor = Color.Silver;
    ((AppearanceBase) appearance11).TextTrimming = (TextTrimming) 3;
    this.MgaComboBox1.DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance11;
    this.MgaComboBox1.DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    this.MgaComboBox1.DisplayLayout.Override.CellPadding = 0;
    ((AppearanceBase) appearance12).BackColor = SystemColors.Control;
    ((AppearanceBase) appearance12).BackColor2 = SystemColors.ControlDark;
    ((AppearanceBase) appearance12).BackGradientAlignment = (GradientAlignment) 1;
    ((AppearanceBase) appearance12).BackGradientStyle = (GradientStyle) 3;
    ((AppearanceBase) appearance12).BorderColor = SystemColors.Window;
    this.MgaComboBox1.DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance12;
    ((AppearanceBase) appearance13).TextHAlignAsString = "Left";
    this.MgaComboBox1.DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance13;
    this.MgaComboBox1.DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    this.MgaComboBox1.DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    ((AppearanceBase) appearance14).BackColor = Color.FromArgb(Convert.ToInt32(Convert.ToByte(240 /*0xF0*/)), Convert.ToInt32(Convert.ToByte(246)), Convert.ToInt32(Convert.ToByte(254)));
    ((AppearanceBase) appearance14).BorderColor = Color.FromArgb(Convert.ToInt32(Convert.ToByte(191)), Convert.ToInt32(Convert.ToByte(219)), Convert.ToInt32(Convert.ToByte((int) byte.MaxValue)));
    this.MgaComboBox1.DisplayLayout.Override.HotTrackRowAppearance = (AppearanceBase) appearance14;
    ((AppearanceBase) appearance15).BackColor = SystemColors.Window;
    ((AppearanceBase) appearance15).BorderColor = Color.White;
    this.MgaComboBox1.DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance15;
    this.MgaComboBox1.DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    this.MgaComboBox1.DisplayLayout.Override.RowSpacingAfter = 1;
    ((AppearanceBase) appearance16).BackColor = Color.FromArgb(Convert.ToInt32(Convert.ToByte((int) byte.MaxValue)), Convert.ToInt32(Convert.ToByte(240 /*0xF0*/)), Convert.ToInt32(Convert.ToByte(194)));
    ((AppearanceBase) appearance16).BorderColor = Color.FromArgb(Convert.ToInt32(Convert.ToByte((int) byte.MaxValue)), Convert.ToInt32(Convert.ToByte(214)), Convert.ToInt32(Convert.ToByte(88)));
    ((AppearanceBase) appearance16).ForeColor = Color.Black;
    this.MgaComboBox1.DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance16;
    ((AppearanceBase) appearance17).BackColor = SystemColors.ControlLight;
    this.MgaComboBox1.DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance17;
    scrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
    this.MgaComboBox1.DisplayLayout.ScrollBarLook = scrollBarLook;
    this.MgaComboBox1.DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    this.MgaComboBox1.DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    this.MgaComboBox1.DisplayLayout.ViewStyleBand = (ViewStyleBand) 2;
    this.MgaComboBox1.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.MgaComboBox1).DropDownWidth = 190;
    ((Control) this.MgaComboBox1).Font = new Font("Tahoma", 10f, FontStyle.Regular, GraphicsUnit.Point, Convert.ToByte(0));
    ((Control) this.MgaComboBox1).Location = new Point(71, 8);
    ((UltraDropDownBase) this.MgaComboBox1).MaxDropDownItems = 2;
    this.MgaComboBox1.MGAStyle = MGAStyles.Blue;
    ((Control) this.MgaComboBox1).Name = "MgaComboBox1";
    ((Control) this.MgaComboBox1).Size = new Size(91, 24);
    ((Control) this.MgaComboBox1).TabIndex = 104;
    ((UltraControlBase) this.MgaComboBox1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaComboBox1).UseOsThemes = (DefaultableBoolean) 2;
    this.ContextMenuStrip1.Items.AddRange(new ToolStripItem[1]
    {
      (ToolStripItem) this.mnuTraceParameters
    });
    this.ContextMenuStrip1.Name = "ContextMenuStrip1";
    this.ContextMenuStrip1.Size = new Size(166, 26);
    this.mnuTraceParameters.CheckOnClick = true;
    this.mnuTraceParameters.Name = "mnuTraceParameters";
    this.mnuTraceParameters.Size = new Size(165, 22);
    this.mnuTraceParameters.Text = "Trace Parameters";
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.ClientSize = new Size(277, 61);
    this.Controls.Add((Control) this.pnlButtons);
    this.Controls.Add((Control) this.pnlControls);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Convert.ToByte(0));
    this.ForeColor = Color.Black;
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.Name = nameof (frmAdHocReportLauncher);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "[Launch Form]";
    ((ISupportInitialize) this.err).EndInit();
    this.pnlButtons.ResumeLayout(false);
    ((ISupportInitialize) this.btnLoad).EndInit();
    ((ISupportInitialize) this.btnOk).EndInit();
    ((ISupportInitialize) this.btnCancel).EndInit();
    ((ISupportInitialize) this.MgaComboBox1).EndInit();
    this.ContextMenuStrip1.ResumeLayout(false);
    this.ResumeLayout(false);
  }

  public frmAdHocReportLauncher(
    Type reportType,
    string displayName,
    BaseReportControl[] reportControls)
  {
    this.InitializeComponent();
    this.Load += new EventHandler(this.frmLaunchForm_Load);
    this._reportControls = reportControls;
    this._displayName = displayName;
    this._reportType = reportType;
    this.Text = this._displayName;
  }

  public frmAdHocReportLauncher(
    Type reportType,
    string displayName,
    BaseReportControl[] reportControls,
    Guid AdHocReportGUID)
  {
    this.InitializeComponent();
    this.Load += new EventHandler(this.frmLaunchForm_Load);
    this._reportControls = reportControls;
    this._displayName = displayName;
    this._reportType = reportType;
    this.Text = this._displayName;
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
      bool flag = false;
      foreach (BaseReportControl reportControl in this._reportControls)
      {
        if (reportControl == null)
          flag = true;
      }
      if (flag)
        this.LoadControlLayoutColumns();
      else
        this.LoadControlLayout();
      if (!(CurrentUser.Instance.UserName.ToLower() == "admin1"))
        return;
      this.ContextMenuStrip = this.ContextMenuStrip1;
    }
  }

  private void MgaButton1_Click(object sender, EventArgs e)
  {
    Guid guid = new Guid();
    SecureReportResourceAttribute searchAttribute = new SecureReportResourceAttribute();
    frmGenericReportPresets genericReportPresets = new frmGenericReportPresets(this._displayName, !this._AdHocReportGUID.Equals(Guid.Empty) ? this._AdHocReportGUID : ((SecureResourceAttribute) ObjectFactory.GetAttributeFromType(this._reportType, (Attribute) searchAttribute)).UniqueIdentifier, this.getTypedParamList(), "LOAD");
    int num1 = (int) genericReportPresets.ShowDialog();
    if (!(genericReportPresets.FormExitMode == "LOAD" & !genericReportPresets.FormCancel))
      return;
    ArrayList reportPresets = genericReportPresets.ReportPresets;
    try
    {
      this.setFromTypedParamList(reportPresets);
    }
    catch (Exception ex)
    {
      switch (ex)
      {
        case InvalidCastException _:
        case NullReferenceException _:
          int num2 = (int) MessageBox.Show("This report was modified after preset was created.", "Preset is invalid", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          break;
      }
    }
  }

  public SqlCommand SQLCommand => this.cmd;

  public string Layout => this._layout;

  private void btnCancel_Click(object sender, EventArgs e)
  {
    this.DialogResult = DialogResult.Cancel;
    this.Close();
  }

  private void btnOk_Click(object sender, EventArgs e)
  {
    Cursor.Current = Cursors.WaitCursor;
    this.cmd = this.LaunchReport();
    if (this.cmd != null)
    {
      Cursor.Current = Cursors.Default;
      this.DialogResult = DialogResult.OK;
      this.Close();
    }
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
    foreach (BaseReportControl reportControl in this._reportControls)
    {
      if (reportControl == null)
      {
        num5 = num1;
        num1 *= 2;
        num3 = 0;
      }
      else
      {
        reportControl.Left = num5;
        reportControl.Top = num3;
        reportControl.TabIndex = num4;
        this.pnlControls.Controls.Add((Control) reportControl);
        num3 += reportControl.Height + 2;
        ++num4;
        if (num1 < reportControl.Width + 30)
          num1 = reportControl.Width + 30;
        if (num2 < reportControl.Top + reportControl.Height + 2)
          num2 = reportControl.Top + reportControl.Height + 2;
      }
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
    foreach (BaseReportControl reportControl in this._reportControls)
    {
      reportControl.Left = 10;
      reportControl.Top = num3;
      reportControl.TabIndex = num4;
      this.pnlControls.Controls.Add((Control) reportControl);
      num3 += reportControl.Height + 2;
      ++num4;
      if (num1 < reportControl.Width + 30)
        num1 = reportControl.Width + 30;
      num2 += reportControl.Height + 2;
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
    foreach (BaseReportControl control in (ArrangedElementCollection) this.pnlControls.Controls)
    {
      if (!control.IsInputValid)
      {
        this.err.SetError((Control) control, control.InputErrorMessage);
        flag = false;
      }
      else
        this.err.SetError((Control) control, string.Empty);
    }
    return flag;
  }

  private ArrayList getTypedParamList()
  {
    ArrayList typedParamList = new ArrayList();
    foreach (BaseReportControl control in (ArrangedElementCollection) this.pnlControls.Controls)
    {
      if (control.Value is Array)
      {
        Array array = (Array) control.Value;
        for (int index = 0; index <= array.Length - 1; ++index)
          typedParamList.Add(array.GetValue(index));
      }
      else
        typedParamList.Add(control.Value);
    }
    return typedParamList;
  }

  private void setFromTypedParamList(ArrayList reportParamValues)
  {
    int index1 = 0;
    foreach (BaseReportControl control in (ArrangedElementCollection) this.pnlControls.Controls)
    {
      if (control.Value is Array)
      {
        Array array = (Array) control.Value;
        ArrayList arrayList = new ArrayList();
        for (int index2 = 0; index2 <= array.Length - 1; ++index2)
        {
          arrayList.Add(reportParamValues[index1]);
          ++index1;
        }
        control.Value = (object) arrayList.ToArray();
      }
      else
      {
        control.Value = reportParamValues[index1];
        ++index1;
      }
    }
  }

  private SqlCommand LaunchReport()
  {
    if (this.validateData())
    {
      ArrayList typedParamList = this.getTypedParamList();
      this.Cursor = Cursors.WaitCursor;
      try
      {
        if (!this._AdHocReportGUID.Equals(Guid.Empty))
          typedParamList.Insert(0, (object) this._AdHocReportGUID);
        AdHocReportDisplay hocReportDisplay = new AdHocReportDisplay(typedParamList.ToArray());
        try
        {
          hocReportDisplay.Run();
        }
        catch (NullReferenceException ex)
        {
          int num = (int) MessageBox.Show("An error has occured when trying to run this report.\n Please contact technical support", "Unable to Run Report", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          return (SqlCommand) null;
        }
        if (!hocReportDisplay.HasRecords)
        {
          int num = (int) MessageBox.Show("No results were found based on your criteria", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          Cursor.Current = Cursors.Default;
        }
        else
        {
          using (StringWriter output = new StringWriter())
          {
            using (XmlWriter xmlWriter = XmlWriter.Create((TextWriter) output))
              hocReportDisplay.SaveLayout(xmlWriter);
            this._layout = output.ToString();
          }
          return hocReportDisplay.SQLCommand;
        }
      }
      finally
      {
        this.Cursor = Cursors.Default;
      }
    }
    return (SqlCommand) null;
  }
}
