// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.FormCoverageCodeLinking
// Assembly: MgaSystems.IMS.Claims, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FCD9D0B7-28CF-40B9-8EB7-297871E1AF5F
// Assembly location: F:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.Layout;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Claims.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Claims;

public class FormCoverageCodeLinking : FormBase
{
  private IContainer components;
  private UltraGrid gridLines;
  private BindingSource dsLines1BindingSource;
  private dsLines dsLines1;
  private Panel panelTop;
  private UltraLabel labelHeader;
  private UltraGrid gridCoverageCodes;
  private Splitter splitter1;
  private PictureBox pictureBox1;
  private BindingSource dsCoverageTypesBindingSource;
  private dsCoverageTypes dsCoverageTypes1;

  public FormCoverageCodeLinking()
  {
    this.InitializeComponent();
    this.InitializeForm();
  }

  private void InitializeForm()
  {
    ((Control) this.labelHeader).Text = Resources.COVERAGECODE_ASSOCIATIONHEADER;
    using (BackgroundWorker backgroundWorker = new BackgroundWorker())
    {
      backgroundWorker.DoWork += (DoWorkEventHandler) ((sender, e) =>
      {
        this.LoadLines();
        this.LoadCoverageCodes();
      });
      backgroundWorker.RunWorkerCompleted += (RunWorkerCompletedEventHandler) ((sender, e) =>
      {
        if (((DisposableObjectCollectionBase) ((UltraGridBase) this.gridLines).Rows).Count == 0)
          return;
        this.LoadCurrentSettings(new Guid(((UltraGridBase) this.gridLines).Rows[0].Cells["LineGuid"].Value.ToString()));
      });
      backgroundWorker.RunWorkerAsync();
    }
  }

  private void LoadLines()
  {
    DefaultDatabase.LoadDataSet((DataSet) this.dsLines1, new string[1]
    {
      "Lines"
    }, "spClaims_GetLines", new object[4]
    {
      (object) "@showall",
      (object) false,
      (object) "@hideBlank",
      (object) true
    });
  }

  private void LoadCoverageCodes()
  {
    DefaultDatabase.LoadDataSet((DataSet) this.dsCoverageTypes1, new string[1]
    {
      "CoverageTypes"
    }, "spClaims_GetCoverageTypes", new object[2]
    {
      (object) "@showall",
      (object) false
    });
  }

  private void LoadCurrentSettings(Guid lineGuid)
  {
    this.Cursor = MgaCursors.Working;
    try
    {
      DataTable dataTable = DefaultDatabase.ExecuteDataTable("spClaims_GetCoverageTypeAssociations", new object[2]
      {
        (object) "@lineGuid",
        (object) lineGuid.ToString()
      });
      if (dataTable.Rows.Count == 0)
      {
        foreach (UltraGridRow row in ((UltraGridBase) this.gridCoverageCodes).Rows)
          row.Cells["Select"].Value = (object) false;
      }
      else
      {
        List<int> intList = new List<int>();
        foreach (DataRow row1 in (InternalDataCollectionBase) dataTable.Rows)
        {
          foreach (UltraGridRow row2 in ((UltraGridBase) this.gridCoverageCodes).Rows)
          {
            if ((int) row2.Cells["CoverageTypeId"].Value == (int) row1[0])
            {
              row2.Cells["Select"].Value = (object) true;
              intList.Add(row2.Index);
            }
            else if (!intList.Contains(row2.Index))
              row2.Cells["Select"].Value = (object) false;
          }
        }
      }
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
    }
  }

  private void AddAssociation(Guid lineGuid, int coverageTypeId)
  {
    DefaultDatabase.ExecuteNonQuery("spClaims_InsertCoverageTypeAssociation", new object[4]
    {
      (object) "@lineGuid",
      (object) lineGuid.ToString(),
      (object) "@coverageTypeId",
      (object) coverageTypeId
    });
  }

  private void DeleteAssociation(Guid lineGuid, int coverageTypeId)
  {
    DefaultDatabase.ExecuteNonQuery("spClaims_DeleteCoverageTypeAssociation", new object[4]
    {
      (object) "@lineGuid",
      (object) lineGuid.ToString(),
      (object) "@coverageTypeId",
      (object) coverageTypeId
    });
  }

  private void gridLines_AfterSelectChange(object sender, AfterSelectChangeEventArgs e)
  {
    try
    {
      this.gridCoverageCodes.EventManager.SetEnabled((EventGroups) 0, false);
      this.LoadCurrentSettings(new Guid(((UltraGridBase) this.gridLines).ActiveRow.Cells["LineGuid"].Value.ToString()));
    }
    finally
    {
      this.gridCoverageCodes.EventManager.SetEnabled((EventGroups) 0, true);
    }
  }

  private void gridCoverageCodes_AfterCellUpdate(object sender, CellEventArgs e)
  {
    if (((UltraGridBase) this.gridLines).ActiveRow == null || ((UltraGridBase) this.gridCoverageCodes).ActiveRow == null || !(((KeyedSubObjectBase) e.Cell.Column).Key == "SELECT"))
      return;
    Guid lineGuid = new Guid(((UltraGridBase) this.gridLines).ActiveRow.Cells["LineGuid"].Value.ToString());
    int coverageTypeId = (int) ((UltraGridBase) this.gridCoverageCodes).ActiveRow.Cells["CoverageTypeId"].Value;
    if ((bool) e.Cell.Value)
      this.AddAssociation(lineGuid, coverageTypeId);
    else
      this.DeleteAssociation(lineGuid, coverageTypeId);
  }

  private void gridCoverageCodes_CellChange(object sender, CellEventArgs e) => e.Cell.Row.Update();

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    Appearance appearance1 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("Lines", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("LineGuid");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("LineName");
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    ScrollBarLook scrollBarLook1 = new ScrollBarLook();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    UltraGridBand ultraGridBand2 = new UltraGridBand("CoverageTypes", -1);
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("CoverageTypeId");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("CoverageType");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("CoverageTypeDescription");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("SELECT", 0);
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    Appearance appearance17 = new Appearance();
    Appearance appearance18 = new Appearance();
    Appearance appearance19 = new Appearance();
    ScrollBarLook scrollBarLook2 = new ScrollBarLook();
    Appearance appearance20 = new Appearance();
    Appearance appearance21 = new Appearance();
    this.gridLines = new UltraGrid();
    this.dsLines1BindingSource = new BindingSource(this.components);
    this.dsLines1 = new dsLines();
    this.panelTop = new Panel();
    this.pictureBox1 = new PictureBox();
    this.labelHeader = new UltraLabel();
    this.gridCoverageCodes = new UltraGrid();
    this.dsCoverageTypesBindingSource = new BindingSource(this.components);
    this.dsCoverageTypes1 = new dsCoverageTypes();
    this.splitter1 = new Splitter();
    ((ISupportInitialize) this.gridLines).BeginInit();
    ((ISupportInitialize) this.dsLines1BindingSource).BeginInit();
    this.dsLines1.BeginInit();
    this.panelTop.SuspendLayout();
    ((ISupportInitialize) this.pictureBox1).BeginInit();
    ((ISupportInitialize) this.gridCoverageCodes).BeginInit();
    ((ISupportInitialize) this.dsCoverageTypesBindingSource).BeginInit();
    this.dsCoverageTypes1.BeginInit();
    this.SuspendLayout();
    ((UltraGridBase) this.gridLines).DataMember = "Lines";
    ((UltraGridBase) this.gridLines).DataSource = (object) this.dsLines1BindingSource;
    ((AppearanceBase) appearance1).BackColor = Color.White;
    ((AppearanceBase) appearance1).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridLines).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.gridLines).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand1.ColHeadersVisible = false;
    ((HeaderBase) ultraGridColumn1.Header).VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 388;
    ((AppearanceBase) appearance2).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn2.Header).Appearance = (AppearanceBase) appearance2;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Line";
    ((HeaderBase) ultraGridColumn2.Header).VisiblePosition = 1;
    ultraGridColumn2.Width = 333;
    ultraGridBand1.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2
    });
    ((UltraGridBase) this.gridLines).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.gridLines).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance3).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance3).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance3).ForeColor = Color.Black;
    ((UltraGridBase) this.gridLines).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance3;
    ((UltraGridBase) this.gridLines).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridLines).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridLines).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance4).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridLines).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance4;
    ((UltraGridBase) this.gridLines).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance5).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.gridLines).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance5;
    ((UltraGridBase) this.gridLines).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance6).BorderColor = Color.White;
    ((UltraGridBase) this.gridLines).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance6;
    ((UltraGridBase) this.gridLines).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance7).BackColor = Color.Transparent;
    ((AppearanceBase) appearance7).ForeColor = Color.Black;
    ((UltraGridBase) this.gridLines).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance7;
    ((AppearanceBase) appearance8).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance8).BorderColor = Color.Silver;
    scrollBarLook1.ButtonAppearance = (AppearanceBase) appearance8;
    ((AppearanceBase) appearance9).BackColor = Color.White;
    scrollBarLook1.TrackAppearance = (AppearanceBase) appearance9;
    ((UltraGridBase) this.gridLines).DisplayLayout.ScrollBarLook = scrollBarLook1;
    ((Control) this.gridLines).Dock = DockStyle.Left;
    ((Control) this.gridLines).Location = new Point(0, 84);
    ((Control) this.gridLines).Name = "gridLines";
    ((Control) this.gridLines).Size = new Size(335, 516);
    ((Control) this.gridLines).TabIndex = 0;
    this.gridLines.AfterSelectChange += new AfterSelectChangeEventHandler(this.gridLines_AfterSelectChange);
    this.dsLines1BindingSource.DataSource = (object) this.dsLines1;
    this.dsLines1BindingSource.Position = 0;
    this.dsLines1.DataSetName = "dsLines";
    this.dsLines1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.panelTop.BackColor = Color.Transparent;
    this.panelTop.Controls.Add((Control) this.pictureBox1);
    this.panelTop.Controls.Add((Control) this.labelHeader);
    this.panelTop.Dock = DockStyle.Top;
    this.panelTop.Location = new Point(0, 0);
    this.panelTop.Name = "panelTop";
    this.panelTop.Size = new Size(854, 84);
    this.panelTop.TabIndex = 1;
    this.pictureBox1.BackColor = Color.Transparent;
    this.pictureBox1.Image = (Image) Resources.CoverageCodeLinking;
    this.pictureBox1.Location = new Point(4, 3);
    this.pictureBox1.Name = "pictureBox1";
    this.pictureBox1.Size = new Size(48 /*0x30*/, 48 /*0x30*/);
    this.pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
    this.pictureBox1.TabIndex = 1;
    this.pictureBox1.TabStop = false;
    ((AppearanceBase) appearance10).BackColor = Color.Transparent;
    ((ControlBase) this.labelHeader).Appearance = (AppearanceBase) appearance10;
    ((Control) this.labelHeader).Location = new Point(58, 12);
    ((Control) this.labelHeader).Name = "labelHeader";
    ((Control) this.labelHeader).Size = new Size(791, 65);
    ((Control) this.labelHeader).TabIndex = 0;
    ((UltraGridBase) this.gridCoverageCodes).DataMember = "CoverageTypes";
    ((UltraGridBase) this.gridCoverageCodes).DataSource = (object) this.dsCoverageTypesBindingSource;
    ((AppearanceBase) appearance11).BackColor = Color.White;
    ((AppearanceBase) appearance11).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridCoverageCodes).DisplayLayout.Appearance = (AppearanceBase) appearance11;
    ((UltraGridBase) this.gridCoverageCodes).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand2.ColHeadersVisible = false;
    ultraGridColumn3.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn3.Header).VisiblePosition = 1;
    ultraGridColumn3.Hidden = true;
    ultraGridColumn3.Width = 150;
    ultraGridColumn4.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn4.Header).VisiblePosition = 2;
    ultraGridColumn4.Width = 430;
    ultraGridColumn5.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn5.Header).VisiblePosition = 3;
    ultraGridColumn5.Hidden = true;
    ultraGridColumn5.Width = 305;
    ultraGridColumn6.DataType = typeof (bool);
    ((HeaderBase) ultraGridColumn6.Header).Caption = "";
    ((HeaderBase) ultraGridColumn6.Header).VisiblePosition = 0;
    ultraGridColumn6.Style = (ColumnStyle) 3;
    ultraGridColumn6.Width = 87;
    ultraGridBand2.Columns.AddRange(new object[4]
    {
      (object) ultraGridColumn3,
      (object) ultraGridColumn4,
      (object) ultraGridColumn5,
      (object) ultraGridColumn6
    });
    ultraGridBand2.Override.AllowAddNew = (AllowAddNew) 2;
    ultraGridBand2.Override.AllowColMoving = (AllowColMoving) 1;
    ultraGridBand2.Override.AllowColSizing = (AllowColSizing) 1;
    ultraGridBand2.Override.AllowColSwapping = (AllowColSwapping) 1;
    ultraGridBand2.Override.AllowDelete = (DefaultableBoolean) 2;
    ultraGridBand2.Override.AllowGroupBy = (DefaultableBoolean) 2;
    ultraGridBand2.Override.AllowGroupMoving = (AllowGroupMoving) 1;
    ultraGridBand2.Override.AllowGroupSwapping = (AllowGroupSwapping) 1;
    ultraGridBand2.Override.AllowMultiCellOperations = (AllowMultiCellOperation) 0;
    ultraGridBand2.Override.AllowRowFiltering = (DefaultableBoolean) 2;
    ultraGridBand2.Override.AllowRowLayoutCellSizing = (RowLayoutSizing) 1;
    ultraGridBand2.Override.AllowRowLayoutCellSpanSizing = (GridBagLayoutAllowSpanSizing) 1;
    ultraGridBand2.Override.AllowRowLayoutColMoving = (GridBagLayoutAllowMoving) 1;
    ultraGridBand2.Override.AllowRowLayoutLabelSizing = (RowLayoutSizing) 1;
    ultraGridBand2.Override.AllowRowLayoutLabelSpanSizing = (GridBagLayoutAllowSpanSizing) 1;
    ultraGridBand2.Override.AllowRowSummaries = (AllowRowSummaries) 2;
    ultraGridBand2.Override.AllowUpdate = (DefaultableBoolean) 1;
    ((AppearanceBase) appearance12).BorderColor = Color.White;
    ultraGridBand2.Override.CellAppearance = (AppearanceBase) appearance12;
    ((AppearanceBase) appearance13).BorderColor = Color.White;
    ultraGridBand2.Override.RowAlternateAppearance = (AppearanceBase) appearance13;
    ((AppearanceBase) appearance14).BorderColor = Color.White;
    ultraGridBand2.Override.RowAppearance = (AppearanceBase) appearance14;
    ((UltraGridBase) this.gridCoverageCodes).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.gridCoverageCodes).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance15).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance15).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance15).ForeColor = Color.Black;
    ((UltraGridBase) this.gridCoverageCodes).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance15;
    ((AppearanceBase) appearance16).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridCoverageCodes).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance16;
    ((AppearanceBase) appearance17).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.gridCoverageCodes).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance17;
    ((UltraGridBase) this.gridCoverageCodes).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance18).BorderColor = Color.White;
    ((UltraGridBase) this.gridCoverageCodes).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance18;
    ((UltraGridBase) this.gridCoverageCodes).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance19).BackColor = Color.Transparent;
    ((AppearanceBase) appearance19).ForeColor = Color.Black;
    ((UltraGridBase) this.gridCoverageCodes).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance19;
    ((AppearanceBase) appearance20).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance20).BorderColor = Color.Silver;
    scrollBarLook2.ButtonAppearance = (AppearanceBase) appearance20;
    ((AppearanceBase) appearance21).BackColor = Color.White;
    scrollBarLook2.TrackAppearance = (AppearanceBase) appearance21;
    ((UltraGridBase) this.gridCoverageCodes).DisplayLayout.ScrollBarLook = scrollBarLook2;
    ((Control) this.gridCoverageCodes).Dock = DockStyle.Fill;
    ((Control) this.gridCoverageCodes).Location = new Point(335, 84);
    ((Control) this.gridCoverageCodes).Name = "gridCoverageCodes";
    ((Control) this.gridCoverageCodes).Size = new Size(519, 516);
    ((Control) this.gridCoverageCodes).TabIndex = 2;
    this.gridCoverageCodes.UpdateMode = (UpdateMode) 4;
    ((UltraControlBase) this.gridCoverageCodes).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridCoverageCodes).UseOsThemes = (DefaultableBoolean) 2;
    this.gridCoverageCodes.AfterCellUpdate += new CellEventHandler(this.gridCoverageCodes_AfterCellUpdate);
    this.gridCoverageCodes.CellChange += new CellEventHandler(this.gridCoverageCodes_CellChange);
    this.dsCoverageTypesBindingSource.DataSource = (object) this.dsCoverageTypes1;
    this.dsCoverageTypesBindingSource.Position = 0;
    this.dsCoverageTypes1.DataSetName = "dsCoverageTypes";
    this.dsCoverageTypes1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.splitter1.BackColor = Color.SteelBlue;
    this.splitter1.Location = new Point(335, 84);
    this.splitter1.Name = "splitter1";
    this.splitter1.Size = new Size(3, 516);
    this.splitter1.TabIndex = 3;
    this.splitter1.TabStop = false;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(854, 600);
    this.Controls.Add((Control) this.splitter1);
    this.Controls.Add((Control) this.gridCoverageCodes);
    this.Controls.Add((Control) this.gridLines);
    this.Controls.Add((Control) this.panelTop);
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.MaximizeBox = false;
    this.MaximumSize = new Size(860, 632);
    this.MinimizeBox = false;
    this.MinimumSize = new Size(860, 632);
    this.Name = nameof (FormCoverageCodeLinking);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Coverage Code Association Management";
    ((ISupportInitialize) this.gridLines).EndInit();
    ((ISupportInitialize) this.dsLines1BindingSource).EndInit();
    this.dsLines1.EndInit();
    this.panelTop.ResumeLayout(false);
    this.panelTop.PerformLayout();
    ((ISupportInitialize) this.pictureBox1).EndInit();
    ((ISupportInitialize) this.gridCoverageCodes).EndInit();
    ((ISupportInitialize) this.dsCoverageTypesBindingSource).EndInit();
    this.dsCoverageTypes1.EndInit();
    this.ResumeLayout(false);
  }
}
