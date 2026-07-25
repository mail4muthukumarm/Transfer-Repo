// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Rating.frmImportAllocationData
// Assembly: MgaSystems.IMS.Rating, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 370B8F0A-FA1A-41D0-87BD-563CC23E9EA7
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Rating.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.Data;
using MGASystems.Tools;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies.Rating;

public class frmImportAllocationData : Form
{
  private IContainer components;
  private UltraGrid UltraGrid1;
  private dsImportAllocationData ds;
  private Label Label1;
  private readonly Guid _quoteGuid;
  private readonly Guid _submissionGroupGuid;

  public frmImportAllocationData()
  {
    this.Load += new EventHandler(this.frmImportAllocationData_Load);
    this.InitializeComponent();
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private virtual MGAButton btnImportData
  {
    get => this._btnImportData;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnImportData_Click);
      MGAButton btnImportData1 = this._btnImportData;
      if (btnImportData1 != null)
        ((Control) btnImportData1).Click -= eventHandler;
      this._btnImportData = value;
      MGAButton btnImportData2 = this._btnImportData;
      if (btnImportData2 == null)
        return;
      ((Control) btnImportData2).Click += eventHandler;
    }
  }

  private virtual LinkLabel lnkCheckAll
  {
    get => this._lnkCheckAll;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkCheckAll_LinkClicked);
      LinkLabel lnkCheckAll1 = this._lnkCheckAll;
      if (lnkCheckAll1 != null)
        lnkCheckAll1.LinkClicked -= clickedEventHandler;
      this._lnkCheckAll = value;
      LinkLabel lnkCheckAll2 = this._lnkCheckAll;
      if (lnkCheckAll2 == null)
        return;
      lnkCheckAll2.LinkClicked += clickedEventHandler;
    }
  }

  private virtual LinkLabel lnkUncheckAll
  {
    get => this._lnkUncheckAll;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkUncheckAll_LinkClicked);
      LinkLabel lnkUncheckAll1 = this._lnkUncheckAll;
      if (lnkUncheckAll1 != null)
        lnkUncheckAll1.LinkClicked -= clickedEventHandler;
      this._lnkUncheckAll = value;
      LinkLabel lnkUncheckAll2 = this._lnkUncheckAll;
      if (lnkUncheckAll2 == null)
        return;
      lnkUncheckAll2.LinkClicked += clickedEventHandler;
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    UltraGridBand ultraGridBand = new UltraGridBand("AllocationData", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("TotalPremium");
    Appearance appearance3 = new Appearance();
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("ControlNo");
    Appearance appearance4 = new Appearance();
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("TotalTIV");
    Appearance appearance5 = new Appearance();
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("ImportData");
    Appearance appearance6 = new Appearance();
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("Name");
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    this.btnImportData = new MGAButton();
    this.lnkCheckAll = new LinkLabel();
    this.lnkUncheckAll = new LinkLabel();
    this.Label1 = new Label();
    this.UltraGrid1 = new UltraGrid();
    this.ds = new dsImportAllocationData();
    ((ISupportInitialize) this.btnImportData).BeginInit();
    ((ISupportInitialize) this.UltraGrid1).BeginInit();
    this.ds.BeginInit();
    this.SuspendLayout();
    ((Control) this.btnImportData).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance1.BackColor = Color.FromArgb(248, 248, 248);
    appearance1.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance1.BackGradientStyle = (GradientStyle) 2;
    appearance1.BorderColor = Color.DarkGray;
    appearance1.ImageHAlign = (HAlign) 2;
    appearance1.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnImportData).Appearance = (AppearanceBase) appearance1;
    ((ControlBase) this.btnImportData).ImageSize = new Size(24, 24);
    ((Control) this.btnImportData).Location = new Point(684, 259);
    ((Control) this.btnImportData).Name = "btnImportData";
    ((Control) this.btnImportData).Size = new Size(88, 24);
    ((Control) this.btnImportData).TabIndex = 4;
    ((ControlBase) this.btnImportData).Text = "Import Data";
    this.btnImportData.UseOSThemes = (DefaultableBoolean) 2;
    this.lnkCheckAll.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkCheckAll.AutoSize = true;
    this.lnkCheckAll.Location = new Point(8, 267);
    this.lnkCheckAll.Name = "lnkCheckAll";
    this.lnkCheckAll.Size = new Size(50, 13);
    this.lnkCheckAll.TabIndex = 5;
    this.lnkCheckAll.TabStop = true;
    this.lnkCheckAll.Text = "Select All";
    this.lnkUncheckAll.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkUncheckAll.AutoSize = true;
    this.lnkUncheckAll.Location = new Point(80 /*0x50*/, 267);
    this.lnkUncheckAll.Name = "lnkUncheckAll";
    this.lnkUncheckAll.Size = new Size(67, 13);
    this.lnkUncheckAll.TabIndex = 6;
    this.lnkUncheckAll.TabStop = true;
    this.lnkUncheckAll.Text = "Un-Select All";
    this.Label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.Label1.AutoSize = true;
    this.Label1.Location = new Point(64 /*0x40*/, 267);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(11, 13);
    this.Label1.TabIndex = 7;
    this.Label1.Text = "/";
    ((Control) this.UltraGrid1).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.UltraGrid1).DataSource = (object) this.ds.AllocationData;
    appearance2.BackColor = Color.White;
    appearance2.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Appearance = (AppearanceBase) appearance2;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn1.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance3).TextHAlignAsString = "Right";
    ultraGridColumn1.CellAppearance = (AppearanceBase) appearance3;
    ultraGridColumn1.Format = "c";
    ((HeaderBase) ultraGridColumn1.Header).Caption = "Total Premium";
    ultraGridColumn1.Header.VisiblePosition = 1;
    ultraGridColumn1.Width = 182;
    ultraGridColumn2.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance4).TextHAlignAsString = "Center";
    ultraGridColumn2.CellAppearance = (AppearanceBase) appearance4;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Control No";
    ultraGridColumn2.Header.VisiblePosition = 0;
    ultraGridColumn2.Width = 130;
    ultraGridColumn3.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance5).TextHAlignAsString = "Right";
    ultraGridColumn3.CellAppearance = (AppearanceBase) appearance5;
    ultraGridColumn3.Format = "c";
    ((HeaderBase) ultraGridColumn3.Header).Caption = "Total TIV";
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridColumn3.Width = 161;
    appearance6.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 210);
    ultraGridColumn4.CellAppearance = (AppearanceBase) appearance6;
    ((HeaderBase) ultraGridColumn4.Header).Caption = "Import";
    ultraGridColumn4.Header.VisiblePosition = 4;
    ultraGridColumn4.Width = 85;
    ((HeaderBase) ultraGridColumn5.Header).Caption = "Company Name";
    ultraGridColumn5.Header.VisiblePosition = 3;
    ultraGridColumn5.MinLength = 120;
    ultraGridColumn5.Width = 204;
    ultraGridBand.Columns.AddRange(new object[5]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4,
      (object) ultraGridColumn5
    });
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance7.BackColor = Color.LightSteelBlue;
    appearance7.FontData.SizeInPoints = 10f;
    appearance7.ForeColor = Color.Navy;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance7;
    ((SpecialBoxBase) ((UltraGridBase) this.UltraGrid1).DisplayLayout.GroupByBox).Hidden = true;
    appearance8.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance8.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance8.ForeColor = Color.Black;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance8;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.AllowAddNew = (AllowAddNew) 2;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.AllowGroupBy = (DefaultableBoolean) 2;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 1;
    appearance9.BorderColor = Color.LightGray;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance9;
    appearance10.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance10;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance11.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance11;
    appearance12.BorderColor = Color.LightGray;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance12;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance13.BackColor = Color.Transparent;
    appearance13.ForeColor = Color.Black;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance13;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.SelectTypeCell = (SelectType) 2;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.SelectTypeRow = (SelectType) 2;
    scrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.UltraGrid1).Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.UltraGrid1).Location = new Point(8, 8);
    ((Control) this.UltraGrid1).Name = "UltraGrid1";
    ((Control) this.UltraGrid1).Size = new Size(764, 235);
    ((Control) this.UltraGrid1).TabIndex = 0;
    ((Control) this.UltraGrid1).Text = "Select Rows To Copy Allocation Data From";
    ((UltraControlBase) this.UltraGrid1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.UltraGrid1).UseOsThemes = (DefaultableBoolean) 2;
    this.ds.DataSetName = "dsImportAllocationData";
    this.ds.Locale = new CultureInfo("en-US");
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.ClientSize = new Size(780, 297);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.lnkUncheckAll);
    this.Controls.Add((Control) this.lnkCheckAll);
    this.Controls.Add((Control) this.btnImportData);
    this.Controls.Add((Control) this.UltraGrid1);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmImportAllocationData);
    this.Text = "Import Allocation Data";
    ((ISupportInitialize) this.btnImportData).EndInit();
    ((ISupportInitialize) this.UltraGrid1).EndInit();
    this.ds.EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  public frmImportAllocationData(Guid quoteGuid, Guid submissionGroupGuid)
  {
    this.Load += new EventHandler(this.frmImportAllocationData_Load);
    this.InitializeComponent();
    this._quoteGuid = quoteGuid;
    this._submissionGroupGuid = submissionGroupGuid;
  }

  private void frmImportAllocationData_Load(object sender, EventArgs e)
  {
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "AllocationData"
    }, "dbo.spGetImportAllocationData", new object[4]
    {
      (object) "@quoteGuid",
      (object) this._quoteGuid,
      (object) "@submissionGroupGuid",
      (object) this._submissionGroupGuid
    });
  }

  private void btnImportData_Click(object sender, EventArgs e)
  {
    if (this.ds.AllocationData.Rows.Count > 0)
    {
      try
      {
        foreach (dsImportAllocationData.AllocationDataRow row in this.ds.AllocationData.Rows)
        {
          if (row.ImportData)
            DefaultDatabase.ExecuteNonQuery("dbo.spUpdateImportAllocationData", new object[4]
            {
              (object) "@controlNo",
              (object) row.ControlNo,
              (object) "@quoteGuid",
              (object) this._quoteGuid
            });
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
    this.Close();
  }

  private void lnkCheckAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    try
    {
      foreach (dsImportAllocationData.AllocationDataRow row in this.ds.AllocationData.Rows)
        row.ImportData = true;
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void lnkUncheckAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    try
    {
      foreach (dsImportAllocationData.AllocationDataRow row in this.ds.AllocationData.Rows)
        row.ImportData = false;
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }
}
