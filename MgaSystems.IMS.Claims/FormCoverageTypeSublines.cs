// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.FormCoverageTypeSublines
// Assembly: MgaSystems.IMS.Claims, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FCD9D0B7-28CF-40B9-8EB7-297871E1AF5F
// Assembly location: F:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.Tools;
using MGASystems.Tools.DBSaveUI;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Claims;

public class FormCoverageTypeSublines : FormBase
{
  private int _coverageTypeDescriptionId;
  private string _coverageTypeDescription;
  private int? _rowId;
  private IContainer components;
  private Label label1;
  private Label labelCoverageTypeDescription;
  private UltraGrid gridSublines;
  private UltraGroupBox ultraGroupBox1;
  private MGASystems.Tools.DBSaveUI.DBSaveUI dbSaveUI1;
  private MGATextBox textSublineCode;
  private Label label2;
  private dsSublineCodes dsSublineCodes1;

  public FormCoverageTypeSublines() => this.InitializeComponent();

  public FormCoverageTypeSublines(int coverageTypeDescriptionId, string coverageTypeDescription)
  {
    this.InitializeComponent();
    this._coverageTypeDescriptionId = coverageTypeDescriptionId;
    this._coverageTypeDescription = coverageTypeDescription;
    this.labelCoverageTypeDescription.Text = this._coverageTypeDescription;
    this.LoadSublineCodes();
    this.SetDBSaveUIState();
  }

  private void LoadSublineCodes()
  {
    this.dsSublineCodes1.Clear();
    DefaultDatabase.LoadDataSet((DataSet) this.dsSublineCodes1, new string[1]
    {
      "SublineCodes"
    }, "[spClaims_GetCoverageTypeSublineCodes]", new object[2]
    {
      (object) "@CoverageTypeDescriptionId",
      (object) this._coverageTypeDescriptionId
    });
  }

  private void SetDBSaveUIState()
  {
    if (((DisposableObjectCollectionBase) ((UltraGridBase) this.gridSublines).Rows).Count > 0)
      this.dbSaveUI1.UIState = (UIState) 1;
    else
      this.dbSaveUI1.UIState = (UIState) 0;
  }

  private void gridSublines_AfterSelectChange(object sender, AfterSelectChangeEventArgs e)
  {
    if (((SparseCollectionBase) this.gridSublines.Selected.Rows).Count == 0)
      return;
    ((Control) this.textSublineCode).Text = this.gridSublines.Selected.Rows[0].Cells["SublineCode"].Value.ToString();
    this._rowId = new int?((int) this.gridSublines.Selected.Rows[0].Cells["RowId"].Value);
  }

  private void dbSaveUI1_ClickedNew(object sender, EventArgs e) => this._rowId = new int?();

  private void dbSaveUI1_UIStateChanged(object sender, EventArgs e)
  {
    ((Control) this.textSublineCode).Enabled = this.dbSaveUI1.UIState == 2;
  }

  private void dbSaveUI1_ClickingSave(object sender, CancelEventArgs e)
  {
    if (!string.IsNullOrEmpty(((Control) this.textSublineCode).Text))
      return;
    int num = (int) MessageBox.Show("You must enter a subline code to continue!", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    e.Cancel = true;
  }

  private void dbSaveUI1_ClickedSave(object sender, EventArgs e)
  {
    if (this._rowId.HasValue)
      DefaultDatabase.ExecuteNonQuery("spClaims_UpdateCoverageTypeSublineCodes", new object[4]
      {
        (object) "@RowId",
        (object) this._rowId.Value,
        (object) "@SublineCode",
        (object) ((Control) this.textSublineCode).Text
      });
    else
      DefaultDatabase.ExecuteNonQuery("spClaims_InsertCoverageTypeSublineCodes", new object[4]
      {
        (object) "@CoverageTypeDescriptionId",
        (object) this._coverageTypeDescriptionId,
        (object) "@SublineCode",
        (object) ((Control) this.textSublineCode).Text
      });
    this.Clear();
    this.LoadSublineCodes();
    this.SetDBSaveUIState();
  }

  private void dbSaveUI1_ClickedDelete(object sender, EventArgs e)
  {
    if (!this._rowId.HasValue)
    {
      this.Clear();
    }
    else
    {
      if (MessageBox.Show("This will permanently delete this subline code association, do you wish to continue?", "Delete Subline Code Association?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
        return;
      DefaultDatabase.ExecuteNonQuery("spClaims_DeleteCoverageTypeSublineCodes", new object[2]
      {
        (object) "@RowId",
        (object) this._rowId.Value
      });
      this.Clear();
      this.LoadSublineCodes();
      this.SetDBSaveUIState();
    }
  }

  private void Clear()
  {
    ((Control) this.textSublineCode).Text = string.Empty;
    this._rowId = new int?();
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("SublineCodes", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("RowId");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("SublineCode");
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    ScrollBarLook scrollBarLook1 = new ScrollBarLook();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    UltraGridLayout ultraGridLayout = new UltraGridLayout("Layout1");
    Appearance appearance12 = new Appearance();
    UltraGridBand ultraGridBand2 = new UltraGridBand("SublineCodes", -1);
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("RowId");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("SublineCode");
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    Appearance appearance17 = new Appearance();
    Appearance appearance18 = new Appearance();
    Appearance appearance19 = new Appearance();
    Appearance appearance20 = new Appearance();
    ScrollBarLook scrollBarLook2 = new ScrollBarLook();
    Appearance appearance21 = new Appearance();
    Appearance appearance22 = new Appearance();
    Appearance appearance23 = new Appearance();
    Appearance appearance24 = new Appearance();
    Appearance appearance25 = new Appearance();
    this.label1 = new Label();
    this.labelCoverageTypeDescription = new Label();
    this.gridSublines = new UltraGrid();
    this.dsSublineCodes1 = new dsSublineCodes();
    this.ultraGroupBox1 = new UltraGroupBox();
    this.dbSaveUI1 = new MGASystems.Tools.DBSaveUI.DBSaveUI();
    this.textSublineCode = new MGATextBox();
    this.label2 = new Label();
    ((ISupportInitialize) this.gridSublines).BeginInit();
    this.dsSublineCodes1.BeginInit();
    ((ISupportInitialize) this.ultraGroupBox1).BeginInit();
    ((Control) this.ultraGroupBox1).SuspendLayout();
    ((ISupportInitialize) this.textSublineCode).BeginInit();
    this.SuspendLayout();
    this.label1.AutoSize = true;
    this.label1.BackColor = Color.Transparent;
    this.label1.Location = new Point(13, 13);
    this.label1.Name = "label1";
    this.label1.Size = new Size(141, 13);
    this.label1.TabIndex = 0;
    this.label1.Text = "Coverage Type Description:";
    this.labelCoverageTypeDescription.BackColor = Color.Transparent;
    this.labelCoverageTypeDescription.Location = new Point(13, 35);
    this.labelCoverageTypeDescription.Name = "labelCoverageTypeDescription";
    this.labelCoverageTypeDescription.Size = new Size(256 /*0x0100*/, 53);
    this.labelCoverageTypeDescription.TabIndex = 1;
    ((UltraGridBase) this.gridSublines).DataSource = (object) this.dsSublineCodes1;
    ((AppearanceBase) appearance1).BackColor = Color.White;
    ((AppearanceBase) appearance1).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridSublines).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.gridSublines).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn1.Header).VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 107;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance2).TextHAlignAsString = "Left";
    ultraGridColumn2.CellAppearance = (AppearanceBase) appearance2;
    ((AppearanceBase) appearance3).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn2.Header).Appearance = (AppearanceBase) appearance3;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Subline Code";
    ((HeaderBase) ultraGridColumn2.Header).VisiblePosition = 1;
    ultraGridColumn2.Width = 249;
    ultraGridBand1.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2
    });
    ((UltraGridBase) this.gridSublines).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.gridSublines).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance4).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance4).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance4).ForeColor = Color.Black;
    ((UltraGridBase) this.gridSublines).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance4;
    ((UltraGridBase) this.gridSublines).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridSublines).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridSublines).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance5).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridSublines).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance5;
    ((UltraGridBase) this.gridSublines).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance6).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.gridSublines).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance6;
    ((UltraGridBase) this.gridSublines).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance7).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridSublines).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance7;
    ((AppearanceBase) appearance8).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridSublines).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance8;
    ((UltraGridBase) this.gridSublines).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance9).BackColor = Color.Transparent;
    ((AppearanceBase) appearance9).ForeColor = Color.Black;
    ((UltraGridBase) this.gridSublines).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance9;
    ((AppearanceBase) appearance10).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance10).BorderColor = Color.Silver;
    scrollBarLook1.ButtonAppearance = (AppearanceBase) appearance10;
    ((AppearanceBase) appearance11).BackColor = Color.White;
    scrollBarLook1.TrackAppearance = (AppearanceBase) appearance11;
    ((UltraGridBase) this.gridSublines).DisplayLayout.ScrollBarLook = scrollBarLook1;
    ((AppearanceBase) appearance12).BackColor = Color.White;
    ((AppearanceBase) appearance12).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ultraGridLayout.Appearance = (AppearanceBase) appearance12;
    ultraGridLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn3.Header).VisiblePosition = 0;
    ultraGridColumn3.Hidden = true;
    ultraGridColumn3.Width = 107;
    ultraGridColumn4.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance13).TextHAlignAsString = "Left";
    ultraGridColumn4.CellAppearance = (AppearanceBase) appearance13;
    ((AppearanceBase) appearance14).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn4.Header).Appearance = (AppearanceBase) appearance14;
    ((HeaderBase) ultraGridColumn4.Header).Caption = "Subline Code";
    ((HeaderBase) ultraGridColumn4.Header).VisiblePosition = 1;
    ultraGridColumn4.Width = 249;
    ultraGridBand2.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn3,
      (object) ultraGridColumn4
    });
    ultraGridLayout.BandsSerializer.Add((object) ultraGridBand2);
    ultraGridLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((KeyedSubObjectBase) ultraGridLayout).Key = "Layout1";
    ((AppearanceBase) appearance15).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance15).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance15).ForeColor = Color.Black;
    ultraGridLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance15;
    ultraGridLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ultraGridLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ultraGridLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance16).BorderColor = Color.LightGray;
    ultraGridLayout.Override.CellAppearance = (AppearanceBase) appearance16;
    ultraGridLayout.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance17).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ultraGridLayout.Override.HeaderAppearance = (AppearanceBase) appearance17;
    ultraGridLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance18).BackColor = Color.FromArgb(246, 250, 253);
    ultraGridLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance18;
    ((AppearanceBase) appearance19).BorderColor = Color.LightGray;
    ultraGridLayout.Override.RowAppearance = (AppearanceBase) appearance19;
    ultraGridLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance20).BackColor = Color.Transparent;
    ((AppearanceBase) appearance20).ForeColor = Color.Black;
    ultraGridLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance20;
    ((AppearanceBase) appearance21).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance21).BorderColor = Color.Silver;
    scrollBarLook2.ButtonAppearance = (AppearanceBase) appearance21;
    ((AppearanceBase) appearance22).BackColor = Color.White;
    scrollBarLook2.TrackAppearance = (AppearanceBase) appearance22;
    ultraGridLayout.ScrollBarLook = scrollBarLook2;
    ((UltraGridBase) this.gridSublines).Layouts.Add(ultraGridLayout);
    ((Control) this.gridSublines).Location = new Point(285, 13);
    ((Control) this.gridSublines).Name = "gridSublines";
    ((Control) this.gridSublines).Size = new Size(251, 192 /*0xC0*/);
    ((Control) this.gridSublines).TabIndex = 2;
    ((UltraControlBase) this.gridSublines).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridSublines).UseOsThemes = (DefaultableBoolean) 2;
    this.gridSublines.AfterSelectChange += new AfterSelectChangeEventHandler(this.gridSublines_AfterSelectChange);
    this.dsSublineCodes1.DataSetName = "dsSublineCodes";
    this.dsSublineCodes1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((AppearanceBase) appearance23).BackColor = Color.Transparent;
    this.ultraGroupBox1.Appearance = (AppearanceBase) appearance23;
    ((AppearanceBase) appearance24).BackColor = Color.Transparent;
    this.ultraGroupBox1.ContentAreaAppearance = (AppearanceBase) appearance24;
    ((Control) this.ultraGroupBox1).Controls.Add((Control) this.dbSaveUI1);
    ((Control) this.ultraGroupBox1).Controls.Add((Control) this.textSublineCode);
    ((Control) this.ultraGroupBox1).Controls.Add((Control) this.label2);
    ((Control) this.ultraGroupBox1).Location = new Point(16 /*0x10*/, 91);
    ((Control) this.ultraGroupBox1).Name = "ultraGroupBox1";
    ((Control) this.ultraGroupBox1).Size = new Size(253, 114);
    ((Control) this.ultraGroupBox1).TabIndex = 3;
    ((Control) this.ultraGroupBox1).Text = "Add/Edit Subline Code";
    this.dbSaveUI1.FreezeEvents = false;
    ((Control) this.dbSaveUI1).Location = new Point(134, 65);
    ((Control) this.dbSaveUI1).Name = "dbSaveUI1";
    ((Control) this.dbSaveUI1).Size = new Size(112 /*0x70*/, 40);
    ((Control) this.dbSaveUI1).TabIndex = 3;
    this.dbSaveUI1.UIState = (UIState) 1;
    this.dbSaveUI1.ClickedDelete += new EventHandler(this.dbSaveUI1_ClickedDelete);
    this.dbSaveUI1.ClickedNew += new EventHandler(this.dbSaveUI1_ClickedNew);
    this.dbSaveUI1.ClickedSave += new EventHandler(this.dbSaveUI1_ClickedSave);
    this.dbSaveUI1.ClickingSave += new CancelEventHandler(this.dbSaveUI1_ClickingSave);
    this.dbSaveUI1.UIStateChanged += new EventHandler(this.dbSaveUI1_UIStateChanged);
    ((AppearanceBase) appearance25).BackColor = Color.White;
    ((AppearanceBase) appearance25).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance25).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textSublineCode).Appearance = (AppearanceBase) appearance25;
    ((Control) this.textSublineCode).BackColor = Color.White;
    ((Control) this.textSublineCode).Enabled = false;
    ((Control) this.textSublineCode).Location = new Point(85, 32 /*0x20*/);
    this.textSublineCode.MGAStyle = (MGAStyles) 2;
    ((Control) this.textSublineCode).Name = "textSublineCode";
    ((Control) this.textSublineCode).Size = new Size(162, 20);
    ((Control) this.textSublineCode).TabIndex = 2;
    ((UltraControlBase) this.textSublineCode).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textSublineCode).UseOsThemes = (DefaultableBoolean) 2;
    this.label2.AutoSize = true;
    this.label2.BackColor = Color.Transparent;
    this.label2.Location = new Point(6, 32 /*0x20*/);
    this.label2.Name = "label2";
    this.label2.Size = new Size(73, 13);
    this.label2.TabIndex = 1;
    this.label2.Text = "Subline Code:";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(548, 213);
    this.Controls.Add((Control) this.ultraGroupBox1);
    this.Controls.Add((Control) this.gridSublines);
    this.Controls.Add((Control) this.labelCoverageTypeDescription);
    this.Controls.Add((Control) this.label1);
    this.Name = nameof (FormCoverageTypeSublines);
    this.Text = "Coverage Type Sublines Administration";
    ((ISupportInitialize) this.gridSublines).EndInit();
    this.dsSublineCodes1.EndInit();
    ((ISupportInitialize) this.ultraGroupBox1).EndInit();
    ((Control) this.ultraGroupBox1).ResumeLayout(false);
    ((Control) this.ultraGroupBox1).PerformLayout();
    ((ISupportInitialize) this.textSublineCode).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }
}
