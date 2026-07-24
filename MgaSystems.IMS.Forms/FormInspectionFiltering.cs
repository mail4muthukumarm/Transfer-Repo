// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Forms.FormInspectionFiltering
// Assembly: MgaSystems.IMS.Forms, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FB3F392E-40B6-486F-8F0B-A4A494A546D4
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Forms.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
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
public class FormInspectionFiltering : Form
{
  private IContainer components;
  private bool _applyFilter;

  public FormInspectionFiltering()
  {
    this.Load += new EventHandler(this.FormInspectionFiltering_Load);
    this._applyFilter = false;
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
    this.components = (IContainer) new System.ComponentModel.Container();
    Appearance appearance1 = new Appearance();
    UltraGridBand ultraGridBand = new UltraGridBand("dtFilterDate", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("DateID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("DateName");
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    this.cboDateEntity = new MGAComboBox();
    this.Label1 = new Label();
    this.dtpToDate = new MGADateTimePicker();
    this.dtpFromDate = new MGADateTimePicker();
    this.Label2 = new Label();
    this.Label4 = new Label();
    this.btnGo = new MGAButton();
    this.err = new ErrorProvider(this.components);
    this.ds = new dsAdminInspReq();
    ((ISupportInitialize) this.cboDateEntity).BeginInit();
    ((ISupportInitialize) this.dtpToDate).BeginInit();
    ((ISupportInitialize) this.dtpFromDate).BeginInit();
    ((ISupportInitialize) this.btnGo).BeginInit();
    ((ISupportInitialize) this.err).BeginInit();
    this.ds.BeginInit();
    this.SuspendLayout();
    this.cboDateEntity.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.cboDateEntity).DataMember = "dtFilterDate";
    ((UltraGridBase) this.cboDateEntity).DataSource = (object) this.ds;
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.FromArgb(78, 122, 171);
    this.cboDateEntity.DisplayLayout.Appearance = (AppearanceBase) appearance1;
    this.cboDateEntity.DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand.ColHeadersVisible = false;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 122;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Width = 209;
    ultraGridBand.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2
    });
    this.cboDateEntity.DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    this.cboDateEntity.DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    this.cboDateEntity.DisplayLayout.BorderStyleCaption = (UIElementBorderStyle) 1;
    this.cboDateEntity.DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    this.cboDateEntity.DisplayLayout.Override.BorderStyleHeader = (UIElementBorderStyle) 1;
    this.cboDateEntity.DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    this.cboDateEntity.DisplayLayout.Override.BorderStyleRowSelector = (UIElementBorderStyle) 1;
    this.cboDateEntity.DisplayLayout.Override.BorderStyleSummaryFooter = (UIElementBorderStyle) 1;
    this.cboDateEntity.DisplayLayout.Override.BorderStyleSummaryFooterCaption = (UIElementBorderStyle) 1;
    this.cboDateEntity.DisplayLayout.Override.BorderStyleSummaryValue = (UIElementBorderStyle) 1;
    this.cboDateEntity.DisplayLayout.Override.BorderStyleTemplateAddRow = (UIElementBorderStyle) 1;
    appearance2.BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    appearance2.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this.cboDateEntity.DisplayLayout.Override.HotTrackRowAppearance = (AppearanceBase) appearance2;
    appearance3.BorderColor = Color.White;
    this.cboDateEntity.DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance3;
    this.cboDateEntity.DisplayLayout.Override.RowSpacingAfter = 1;
    appearance4.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance4.BorderColor = Color.FromArgb((int) byte.MaxValue, 214, 88);
    appearance4.ForeColor = Color.Black;
    this.cboDateEntity.DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance4;
    scrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
    this.cboDateEntity.DisplayLayout.ScrollBarLook = scrollBarLook;
    ((UltraDropDownBase) this.cboDateEntity).DisplayMember = "DateName";
    this.cboDateEntity.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboDateEntity).DropDownWidth = 350;
    ((Control) this.cboDateEntity).Location = new Point(82, 12);
    this.cboDateEntity.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboDateEntity).Name = "cboDateEntity";
    ((Control) this.cboDateEntity).Size = new Size(200, 20);
    ((Control) this.cboDateEntity).TabIndex = 96 /*0x60*/;
    ((UltraControlBase) this.cboDateEntity).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboDateEntity).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboDateEntity).ValueMember = "DateID";
    this.Label1.AutoSize = true;
    this.Label1.Location = new Point(5, 12);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(62, 13);
    this.Label1.TabIndex = 97;
    this.Label1.Text = "Date Entity:";
    appearance5.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dtpToDate.Appearance = (AppearanceBase) appearance5;
    appearance6.AlphaLevel = (short) 14;
    appearance6.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance6.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance6.BackColorAlpha = (Alpha) 2;
    appearance6.BackGradientAlignment = (GradientAlignment) 4;
    appearance6.BackGradientStyle = (GradientStyle) 5;
    appearance6.BorderAlpha = (Alpha) 1;
    appearance6.BorderColor = Color.FromArgb(78, 122, 171);
    appearance6.ForeColor = Color.FromArgb(49, 85, 153);
    appearance6.ForegroundAlpha = (Alpha) 2;
    this.dtpToDate.ButtonAppearance = (AppearanceBase) appearance6;
    this.dtpToDate.DateTime = new DateTime(1753, 1, 1, 0, 0, 0, 0);
    ((Control) this.dtpToDate).Location = new Point(198, 51);
    this.dtpToDate.MGAStyle = MGAStyles.Blue;
    ((Control) this.dtpToDate).Name = "dtpToDate";
    ((Control) this.dtpToDate).Size = new Size(84, 19);
    ((Control) this.dtpToDate).TabIndex = 98;
    ((UltraControlBase) this.dtpToDate).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtpToDate).UseOsThemes = (DefaultableBoolean) 2;
    this.dtpToDate.Value = (object) null;
    appearance7.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dtpFromDate.Appearance = (AppearanceBase) appearance7;
    appearance8.AlphaLevel = (short) 14;
    appearance8.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance8.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance8.BackColorAlpha = (Alpha) 2;
    appearance8.BackGradientAlignment = (GradientAlignment) 4;
    appearance8.BackGradientStyle = (GradientStyle) 5;
    appearance8.BorderAlpha = (Alpha) 1;
    appearance8.BorderColor = Color.FromArgb(78, 122, 171);
    appearance8.ForeColor = Color.FromArgb(49, 85, 153);
    appearance8.ForegroundAlpha = (Alpha) 2;
    this.dtpFromDate.ButtonAppearance = (AppearanceBase) appearance8;
    this.dtpFromDate.DateTime = new DateTime(1753, 1, 1, 0, 0, 0, 0);
    ((Control) this.dtpFromDate).Location = new Point(82, 51);
    this.dtpFromDate.MGAStyle = MGAStyles.Blue;
    ((Control) this.dtpFromDate).Name = "dtpFromDate";
    ((Control) this.dtpFromDate).Size = new Size(84, 19);
    ((Control) this.dtpFromDate).TabIndex = 99;
    ((UltraControlBase) this.dtpFromDate).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtpFromDate).UseOsThemes = (DefaultableBoolean) 2;
    this.dtpFromDate.Value = (object) null;
    this.Label2.AutoSize = true;
    this.Label2.Location = new Point(5, 54);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(68, 13);
    this.Label2.TabIndex = 100;
    this.Label2.Text = "Date Range:";
    this.Label4.AutoSize = true;
    this.Label4.Location = new Point(172, 54);
    this.Label4.Name = "Label4";
    this.Label4.Size = new Size(20, 13);
    this.Label4.TabIndex = 102;
    this.Label4.Text = "To";
    ((Control) this.btnGo).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    appearance9.BackColor = Color.Gainsboro;
    appearance9.BackColor2 = Color.White;
    appearance9.BackGradientStyle = (GradientStyle) 2;
    appearance9.BorderColor = Color.Gray;
    appearance9.ImageHAlign = (HAlign) 2;
    appearance9.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnGo).Appearance = (AppearanceBase) appearance9;
    ((ControlBase) this.btnGo).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnGo).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnGo).Location = new Point(133, 91);
    ((Control) this.btnGo).Name = "btnGo";
    ((Control) this.btnGo).Size = new Size(40, 40);
    ((Control) this.btnGo).TabIndex = 103;
    this.btnGo.UseOSThemes = (DefaultableBoolean) 2;
    this.err.ContainerControl = (ContainerControl) this;
    this.ds.DataSetName = "dsAdminInspReq";
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(299, 138);
    this.Controls.Add((Control) this.btnGo);
    this.Controls.Add((Control) this.Label4);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.dtpFromDate);
    this.Controls.Add((Control) this.dtpToDate);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.cboDateEntity);
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (FormInspectionFiltering);
    this.Text = "Filtering Rows";
    ((ISupportInitialize) this.cboDateEntity).EndInit();
    ((ISupportInitialize) this.dtpToDate).EndInit();
    ((ISupportInitialize) this.dtpFromDate).EndInit();
    ((ISupportInitialize) this.btnGo).EndInit();
    ((ISupportInitialize) this.err).EndInit();
    this.ds.EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  [field: AccessedThroughProperty("cboDateEntity")]
  protected virtual MGAComboBox cboDateEntity { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dtpToDate")]
  private virtual MGADateTimePicker dtpToDate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dtpFromDate")]
  private virtual MGADateTimePicker dtpFromDate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label2")]
  internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label4")]
  internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

  [field: AccessedThroughProperty("err")]
  internal virtual ErrorProvider err { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ds")]
  internal virtual dsAdminInspReq ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public int SelectedDateEntity
  {
    get
    {
      return this.cboDateEntity.Value == null || this.cboDateEntity.Value == DBNull.Value ? int.MinValue : (int) this.cboDateEntity.Value;
    }
  }

  public bool ApplyDateFilter => this._applyFilter;

  private void btnGo_Click(object sender, EventArgs e)
  {
    bool flag = true;
    this._applyFilter = false;
    this.err.SetError((Control) this.cboDateEntity, string.Empty);
    this.err.SetError((Control) this.dtpFromDate, string.Empty);
    this.err.SetError((Control) this.dtpToDate, string.Empty);
    if (this.cboDateEntity.Value == null || this.cboDateEntity.Value == DBNull.Value)
    {
      flag = false;
      this.err.SetError((Control) this.cboDateEntity, "Select an entity");
    }
    if (this.dtpFromDate.Value == null || this.dtpFromDate.Value == DBNull.Value)
    {
      flag = false;
      this.err.SetError((Control) this.dtpFromDate, "Select From Date");
    }
    if (this.dtpToDate.Value == null || this.dtpToDate.Value == DBNull.Value)
    {
      flag = false;
      this.err.SetError((Control) this.dtpToDate, "Select To Date");
    }
    if (!flag)
      return;
    this._applyFilter = true;
    this.Close();
  }

  public DateTime FromDate
  {
    get
    {
      return this.dtpFromDate.Value == null || this.dtpFromDate.Value == DBNull.Value ? DateTime.MinValue : (DateTime) this.dtpFromDate.Value;
    }
  }

  public DateTime ToDate
  {
    get
    {
      return this.dtpToDate.Value == null || this.dtpToDate.Value == DBNull.Value ? DateTime.MinValue : (DateTime) this.dtpToDate.Value;
    }
  }

  private void FormInspectionFiltering_Load(object sender, EventArgs e)
  {
    ((ControlBase) this.btnGo).Appearance.Image = (object) ImageCache.Instance.Search;
    this._applyFilter = false;
    this.ds.dtFilterDate.AdddtFilterDateRow(1, "Follow up Date");
    this.ds.dtFilterDate.AdddtFilterDateRow(2, "Drop Dead Date");
    this.ds.dtFilterDate.AdddtFilterDateRow(3, "Order Date");
    this.ds.dtFilterDate.AdddtFilterDateRow(4, "Effective Date");
    this.ds.dtFilterDate.AdddtFilterDateRow(5, "Received Date");
  }
}
