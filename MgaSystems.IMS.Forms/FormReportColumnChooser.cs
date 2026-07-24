// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Forms.FormReportColumnChooser
// Assembly: MgaSystems.IMS.Forms, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FB3F392E-40B6-486F-8F0B-A4A494A546D4
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Forms.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.Common;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Forms;

[DesignerGenerated]
public class FormReportColumnChooser : Form
{
  private IContainer components;
  private string _hiddenColumns;
  private bool _isButtonClicked;

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
    UltraGridBand ultraGridBand = new UltraGridBand("dtColumns", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("ColumnName");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("SelectColumn");
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance9 = new Appearance();
    this.ugColumns = new UltraGrid();
    this.ds = new dsAdminInspReq();
    this.btnChoose = new MGAButton();
    this.Label1 = new Label();
    this.lnkDeSelectAll = new LinkLabel();
    this.lnkSelectAll = new LinkLabel();
    ((ISupportInitialize) this.ugColumns).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.btnChoose).BeginInit();
    this.SuspendLayout();
    ((Control) this.ugColumns).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraControlBase) this.ugColumns).Cursor = Cursors.Hand;
    ((UltraGridBase) this.ugColumns).DataMember = "dtColumns";
    ((UltraGridBase) this.ugColumns).DataSource = (object) this.ds;
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ugColumns).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.ugColumns).DisplayLayout.AutoFitStyle = (AutoFitStyle) 2;
    ((HeaderBase) ultraGridColumn1.Header).Caption = "Column Name";
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Width = 320;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Select";
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridBand.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2
    });
    ((UltraGridBase) this.ugColumns).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.ugColumns).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance2.BackColor = Color.LightSteelBlue;
    appearance2.FontData.SizeInPoints = 10f;
    appearance2.ForeColor = Color.Black;
    ((UltraGridBase) this.ugColumns).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance2;
    ((UltraGridBase) this.ugColumns).DisplayLayout.MaxRowScrollRegions = 40;
    appearance3.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance3.ForeColor = Color.Black;
    ((UltraGridBase) this.ugColumns).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance3;
    ((UltraGridBase) this.ugColumns).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.ugColumns).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.ugColumns).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    appearance4.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugColumns).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance4;
    appearance5.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ugColumns).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance5;
    ((UltraGridBase) this.ugColumns).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.ugColumns).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance6.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ugColumns).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance6;
    appearance7.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugColumns).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance7;
    ((UltraGridBase) this.ugColumns).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance8.BackColor = Color.Transparent;
    appearance8.ForeColor = Color.Black;
    ((UltraGridBase) this.ugColumns).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance8;
    scrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.ugColumns).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((UltraGridBase) this.ugColumns).DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    ((Control) this.ugColumns).Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.ugColumns).Location = new Point(12, 25);
    ((Control) this.ugColumns).Name = "ugColumns";
    ((Control) this.ugColumns).Size = new Size(423, 590);
    ((Control) this.ugColumns).TabIndex = 14;
    ((Control) this.ugColumns).Text = "Available Columns";
    ((UltraControlBase) this.ugColumns).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ugColumns).UseOsThemes = (DefaultableBoolean) 2;
    this.ds.DataSetName = "dsAdminInspReq";
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((Control) this.btnChoose).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance9.BackColor = Color.Gainsboro;
    appearance9.BackColor2 = Color.White;
    appearance9.BackGradientStyle = (GradientStyle) 2;
    appearance9.BorderColor = Color.Gray;
    appearance9.ImageHAlign = (HAlign) 2;
    appearance9.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnChoose).Appearance = (AppearanceBase) appearance9;
    ((ControlBase) this.btnChoose).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnChoose).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnChoose).Location = new Point(395, 629);
    ((Control) this.btnChoose).Name = "btnChoose";
    ((Control) this.btnChoose).Size = new Size(40, 40);
    ((Control) this.btnChoose).TabIndex = 35;
    this.btnChoose.UseOSThemes = (DefaultableBoolean) 2;
    this.Label1.AutoSize = true;
    this.Label1.Location = new Point(12, 9);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(181, 13);
    this.Label1.TabIndex = 36;
    this.Label1.Text = "Choose columns to appear on report.";
    this.lnkDeSelectAll.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkDeSelectAll.AutoSize = true;
    this.lnkDeSelectAll.Location = new Point(12, 663);
    this.lnkDeSelectAll.Name = "lnkDeSelectAll";
    this.lnkDeSelectAll.Size = new Size(68, 13);
    this.lnkDeSelectAll.TabIndex = 37;
    this.lnkDeSelectAll.TabStop = true;
    this.lnkDeSelectAll.Text = "De-Select All";
    this.lnkSelectAll.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkSelectAll.AutoSize = true;
    this.lnkSelectAll.Location = new Point(12, 633);
    this.lnkSelectAll.Name = "lnkSelectAll";
    this.lnkSelectAll.Size = new Size(51, 13);
    this.lnkSelectAll.TabIndex = 38;
    this.lnkSelectAll.TabStop = true;
    this.lnkSelectAll.Text = "Select All";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(447, 681);
    this.Controls.Add((Control) this.lnkSelectAll);
    this.Controls.Add((Control) this.lnkDeSelectAll);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.btnChoose);
    this.Controls.Add((Control) this.ugColumns);
    this.Name = nameof (FormReportColumnChooser);
    this.Text = "Report Column Chooser";
    ((ISupportInitialize) this.ugColumns).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.btnChoose).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  [field: AccessedThroughProperty("ugColumns")]
  private virtual UltraGrid ugColumns { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ds")]
  internal virtual dsAdminInspReq ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MGAButton btnChoose
  {
    get => this._btnChoose;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnSave_Click);
      MGAButton btnChoose1 = this._btnChoose;
      if (btnChoose1 != null)
        ((Control) btnChoose1).Click -= eventHandler;
      this._btnChoose = value;
      MGAButton btnChoose2 = this._btnChoose;
      if (btnChoose2 == null)
        return;
      ((Control) btnChoose2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual LinkLabel lnkDeSelectAll
  {
    get => this._lnkDeSelectAll;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkDeSelectAll_LinkClicked);
      LinkLabel lnkDeSelectAll1 = this._lnkDeSelectAll;
      if (lnkDeSelectAll1 != null)
        lnkDeSelectAll1.LinkClicked -= clickedEventHandler;
      this._lnkDeSelectAll = value;
      LinkLabel lnkDeSelectAll2 = this._lnkDeSelectAll;
      if (lnkDeSelectAll2 == null)
        return;
      lnkDeSelectAll2.LinkClicked += clickedEventHandler;
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

  public FormReportColumnChooser()
  {
    this.Load += new EventHandler(this.FormReportColumnChooser_Load);
    this._hiddenColumns = string.Empty;
    this._isButtonClicked = false;
    this.InitializeComponent();
  }

  public bool ButtonClick => this._isButtonClicked;

  public string HiddenColumns => this._hiddenColumns;

  private void FormReportColumnChooser_Load(object sender, EventArgs e)
  {
    ((ControlBase) this.btnChoose).Appearance.Image = (object) ImageCache.Instance.Forward;
    List<string> stringList = new List<string>();
    stringList.Add("CriticalOutstanding");
    stringList.Add("CriticalWaived");
    stringList.Add("CriticalComplete");
    stringList.Add("CriticalTotal");
    stringList.Add("NonCriticalOutstanding");
    stringList.Add("NonCriticalWaived");
    stringList.Add("NonCriticalComplete");
    stringList.Add("NonCriticalTotal");
    stringList.Add("RecSent");
    stringList.Add("RecStatus");
    stringList.Add("RecsFollowUp");
    stringList.Add("RecsCompleted");
    stringList.Add("CPR");
    stringList.Add("Map");
    stringList.Add("SprinklerTest");
    stringList.Add("Thermo");
    stringList.Add("FirePump");
    stringList.Add("FocusAccount");
    stringList.Add("CriticalAccount");
    bool flag = SystemSettings.KeyExists("ShowInspAdminRecommendationsTab");
    try
    {
      foreach (DataColumn column in (InternalDataCollectionBase) this.ds.dtReportGeneric.Columns)
      {
        if (flag || !stringList.Contains(column.ColumnName))
          this.ds.dtColumns.AdddtColumnsRow(column.ColumnName, true);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
    foreach (UltraGridRow row in ((UltraGridBase) this.ugColumns).Rows)
    {
      if (row.Cells["SelectColumn"].Value != null && row.Cells["SelectColumn"].Value != DBNull.Value && !Conversions.ToBoolean(row.Cells["SelectColumn"].Value))
        this._hiddenColumns = $"{this._hiddenColumns}{row.Cells["ColumnName"].Value.ToString()}/";
    }
    this._isButtonClicked = true;
    this.Close();
  }

  private void lnkSelectAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.SetGridSelection(true);
  }

  private void lnkDeSelectAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.SetGridSelection(false);
  }

  private void SetGridSelection(bool selValue)
  {
    foreach (UltraGridRow row in ((UltraGridBase) this.ugColumns).Rows)
      row.Cells["SelectColumn"].Value = (object) selValue;
  }
}
