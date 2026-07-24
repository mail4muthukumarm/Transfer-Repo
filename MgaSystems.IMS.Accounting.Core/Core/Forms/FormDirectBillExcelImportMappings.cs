// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.Forms.FormDirectBillExcelImportMappings
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using Infragistics.Win;
using Infragistics.Win.Layout;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.Common;
using MGASystems.IMS.Accounting.Core.Properties;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.Forms;

public class FormDirectBillExcelImportMappings : FormBase
{
  private DataTable _excelColumnNames;
  private IContainer components;
  private UltraGrid gridMappings;
  private MGAButton buttonCancel;
  private MGAButton buttonSaveMappings;
  private UltraDropDown dropDownWorksheetFields;

  public string InvoiceMapping
  {
    get => ((UltraGridBase) this.gridMappings).Rows[0].Cells[1].Value.ToString();
  }

  public string CheckNumberMapping
  {
    get => ((UltraGridBase) this.gridMappings).Rows[1].Cells[1].Value.ToString();
  }

  public string AmountMapping
  {
    get => ((UltraGridBase) this.gridMappings).Rows[2].Cells[1].Value.ToString();
  }

  public string DateMapping
  {
    get => ((UltraGridBase) this.gridMappings).Rows[3].Cells[1].Value.ToString();
  }

  public FormDirectBillExcelImportMappings(DataTable excelColumnNames)
  {
    this.InitializeComponent();
    this._excelColumnNames = excelColumnNames;
  }

  private void CreateMappingDataset()
  {
    DataTable dataTable = new DataTable();
    dataTable.Columns.AddRange(new DataColumn[2]
    {
      new DataColumn("IMSFields", typeof (string)),
      new DataColumn("ExcelFields", typeof (string))
    });
    dataTable.Rows.Add((object) "Invoice Number", (object) string.Empty);
    dataTable.Rows.Add((object) "Check Number", (object) string.Empty);
    dataTable.Rows.Add((object) "Check Amount", (object) string.Empty);
    dataTable.Rows.Add((object) "Deposit Date", (object) string.Empty);
    ((UltraGridBase) this.gridMappings).DataSource = (object) dataTable;
    this.CreateExcelFieldList();
    this.FormatGrid();
  }

  private void FormDirectBillExcelImportMappings_Load(object sender, EventArgs e)
  {
    this.CreateMappingDataset();
  }

  private void buttonCancel_Click(object sender, EventArgs e)
  {
    this.DialogResult = DialogResult.Cancel;
    this.Close();
  }

  private void FormatGrid()
  {
    ((UltraGridBase) this.gridMappings).DisplayLayout.Override.HeaderAppearance.TextHAlign = (HAlign) 1;
  }

  private void CreateExcelFieldList()
  {
    ((UltraGridBase) this.dropDownWorksheetFields).DataSource = (object) this._excelColumnNames;
    ((UltraGridBase) this.gridMappings).DisplayLayout.Bands[0].Columns[1].Style = (ColumnStyle) 6;
    ((UltraGridBase) this.gridMappings).DisplayLayout.Bands[0].Columns[1].ValueList = (IValueList) this.dropDownWorksheetFields;
    ((UltraGridBase) this.dropDownWorksheetFields).DisplayLayout.Bands[0].ColHeadersVisible = false;
  }

  private bool ValidateFieldMappings()
  {
    bool flag = true;
    foreach (UltraGridRow row in ((UltraGridBase) this.gridMappings).Rows)
    {
      if (string.IsNullOrEmpty(row.Cells[1].Text))
      {
        flag = false;
        break;
      }
    }
    if (flag)
      return flag;
    int num = (int) MessageBox.Show("You must define a field mapping for all of the IMS fields.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    return flag;
  }

  private void buttonSaveMappings_Click(object sender, EventArgs e)
  {
    if (!this.ValidateFieldMappings())
      return;
    this.DialogResult = DialogResult.OK;
    this.Close();
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
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    Appearance appearance17 = new Appearance();
    Appearance appearance18 = new Appearance();
    ScrollBarLook scrollBarLook2 = new ScrollBarLook();
    Appearance appearance19 = new Appearance();
    Appearance appearance20 = new Appearance();
    this.gridMappings = new UltraGrid();
    this.buttonCancel = new MGAButton();
    this.buttonSaveMappings = new MGAButton();
    this.dropDownWorksheetFields = new UltraDropDown();
    ((ISupportInitialize) this.gridMappings).BeginInit();
    ((ISupportInitialize) this.buttonCancel).BeginInit();
    ((ISupportInitialize) this.buttonSaveMappings).BeginInit();
    ((ISupportInitialize) this.dropDownWorksheetFields).BeginInit();
    this.SuspendLayout();
    ((AppearanceBase) appearance1).BackColor = Color.White;
    ((AppearanceBase) appearance1).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridMappings).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.gridMappings).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((UltraGridBase) this.gridMappings).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance2).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance2).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance2).ForeColor = Color.Black;
    ((UltraGridBase) this.gridMappings).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance2;
    ((UltraGridBase) this.gridMappings).DisplayLayout.Override.AllowAddNew = (AllowAddNew) 2;
    ((UltraGridBase) this.gridMappings).DisplayLayout.Override.AllowColMoving = (AllowColMoving) 1;
    ((UltraGridBase) this.gridMappings).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 1;
    ((UltraGridBase) this.gridMappings).DisplayLayout.Override.AllowColSwapping = (AllowColSwapping) 1;
    ((UltraGridBase) this.gridMappings).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridMappings).DisplayLayout.Override.AllowGroupBy = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridMappings).DisplayLayout.Override.AllowGroupMoving = (AllowGroupMoving) 1;
    ((UltraGridBase) this.gridMappings).DisplayLayout.Override.AllowGroupSwapping = (AllowGroupSwapping) 1;
    ((UltraGridBase) this.gridMappings).DisplayLayout.Override.AllowMultiCellOperations = (AllowMultiCellOperation) 0;
    ((UltraGridBase) this.gridMappings).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridMappings).DisplayLayout.Override.AllowRowLayoutCellSizing = (RowLayoutSizing) 1;
    ((UltraGridBase) this.gridMappings).DisplayLayout.Override.AllowRowLayoutCellSpanSizing = (GridBagLayoutAllowSpanSizing) 1;
    ((UltraGridBase) this.gridMappings).DisplayLayout.Override.AllowRowLayoutColMoving = (GridBagLayoutAllowMoving) 1;
    ((UltraGridBase) this.gridMappings).DisplayLayout.Override.AllowRowLayoutLabelSizing = (RowLayoutSizing) 1;
    ((UltraGridBase) this.gridMappings).DisplayLayout.Override.AllowRowLayoutLabelSpanSizing = (GridBagLayoutAllowSpanSizing) 1;
    ((UltraGridBase) this.gridMappings).DisplayLayout.Override.AllowRowSummaries = (AllowRowSummaries) 2;
    ((UltraGridBase) this.gridMappings).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 1;
    ((AppearanceBase) appearance3).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridMappings).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance3;
    ((AppearanceBase) appearance4).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.gridMappings).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance4;
    ((UltraGridBase) this.gridMappings).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance5).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridMappings).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance5;
    ((AppearanceBase) appearance6).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridMappings).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance6;
    ((UltraGridBase) this.gridMappings).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance7).BackColor = Color.Transparent;
    ((AppearanceBase) appearance7).ForeColor = Color.Black;
    ((UltraGridBase) this.gridMappings).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance7;
    ((AppearanceBase) appearance8).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance8).BorderColor = Color.Silver;
    scrollBarLook1.ButtonAppearance = (AppearanceBase) appearance8;
    ((AppearanceBase) appearance9).BackColor = Color.White;
    scrollBarLook1.TrackAppearance = (AppearanceBase) appearance9;
    ((UltraGridBase) this.gridMappings).DisplayLayout.ScrollBarLook = scrollBarLook1;
    ((Control) this.gridMappings).Dock = DockStyle.Top;
    ((Control) this.gridMappings).Location = new Point(0, 0);
    ((Control) this.gridMappings).Name = "gridMappings";
    ((Control) this.gridMappings).Size = new Size(289, 220);
    ((Control) this.gridMappings).TabIndex = 0;
    ((UltraControlBase) this.gridMappings).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridMappings).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance10).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance10).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance10).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance10).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance10).Image = (object) Resources.delete;
    ((AppearanceBase) appearance10).ImageHAlign = (HAlign) 1;
    ((AppearanceBase) appearance10).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonCancel).Appearance = (AppearanceBase) appearance10;
    ((Control) this.buttonCancel).Location = new Point(199, 226);
    ((Control) this.buttonCancel).Name = "buttonCancel";
    ((Control) this.buttonCancel).Size = new Size(85, 30);
    ((Control) this.buttonCancel).TabIndex = 1;
    ((Control) this.buttonCancel).Text = "&Cancel";
    ((UltraControlBase) this.buttonCancel).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonCancel).Click += new EventHandler(this.buttonCancel_Click);
    ((AppearanceBase) appearance11).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance11).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance11).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance11).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance11).Image = (object) Resources.disk;
    ((AppearanceBase) appearance11).ImageHAlign = (HAlign) 1;
    ((AppearanceBase) appearance11).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonSaveMappings).Appearance = (AppearanceBase) appearance11;
    ((Control) this.buttonSaveMappings).Location = new Point(77, 226);
    ((Control) this.buttonSaveMappings).Name = "buttonSaveMappings";
    ((Control) this.buttonSaveMappings).Size = new Size(116, 30);
    ((Control) this.buttonSaveMappings).TabIndex = 2;
    ((Control) this.buttonSaveMappings).Text = "&Save Mappings";
    ((UltraControlBase) this.buttonSaveMappings).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonSaveMappings).Click += new EventHandler(this.buttonSaveMappings_Click);
    ((AppearanceBase) appearance12).BackColor = Color.White;
    ((AppearanceBase) appearance12).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.dropDownWorksheetFields).DisplayLayout.Appearance = (AppearanceBase) appearance12;
    ((UltraGridBase) this.dropDownWorksheetFields).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((UltraGridBase) this.dropDownWorksheetFields).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance13).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance13).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance13).ForeColor = Color.Black;
    ((UltraGridBase) this.dropDownWorksheetFields).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance13;
    ((UltraGridBase) this.dropDownWorksheetFields).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.dropDownWorksheetFields).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.dropDownWorksheetFields).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance14).BorderColor = Color.LightGray;
    ((UltraGridBase) this.dropDownWorksheetFields).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance14;
    ((UltraGridBase) this.dropDownWorksheetFields).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance15).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.dropDownWorksheetFields).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance15;
    ((UltraGridBase) this.dropDownWorksheetFields).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance16).BackColor = Color.White;
    ((AppearanceBase) appearance16).BorderColor = Color.White;
    ((UltraGridBase) this.dropDownWorksheetFields).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance16;
    ((AppearanceBase) appearance17).BorderColor = Color.White;
    ((UltraGridBase) this.dropDownWorksheetFields).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance17;
    ((UltraGridBase) this.dropDownWorksheetFields).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance18).BackColor = Color.Transparent;
    ((AppearanceBase) appearance18).ForeColor = Color.Black;
    ((UltraGridBase) this.dropDownWorksheetFields).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance18;
    ((AppearanceBase) appearance19).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance19).BorderColor = Color.Silver;
    scrollBarLook2.ButtonAppearance = (AppearanceBase) appearance19;
    ((AppearanceBase) appearance20).BackColor = Color.White;
    scrollBarLook2.TrackAppearance = (AppearanceBase) appearance20;
    ((UltraGridBase) this.dropDownWorksheetFields).DisplayLayout.ScrollBarLook = scrollBarLook2;
    ((UltraDropDownBase) this.dropDownWorksheetFields).DisplayMember = "FieldName";
    ((Control) this.dropDownWorksheetFields).Location = new Point(38, 90);
    ((Control) this.dropDownWorksheetFields).Name = "dropDownWorksheetFields";
    ((Control) this.dropDownWorksheetFields).Size = new Size(208 /*0xD0*/, 80 /*0x50*/);
    ((Control) this.dropDownWorksheetFields).TabIndex = 10;
    ((Control) this.dropDownWorksheetFields).Text = "ultraDropDown1";
    ((UltraControlBase) this.dropDownWorksheetFields).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dropDownWorksheetFields).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.dropDownWorksheetFields).ValueMember = "FieldName";
    ((Control) this.dropDownWorksheetFields).Visible = false;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(289, 261);
    this.ControlBox = false;
    this.Controls.Add((Control) this.dropDownWorksheetFields);
    this.Controls.Add((Control) this.buttonSaveMappings);
    this.Controls.Add((Control) this.buttonCancel);
    this.Controls.Add((Control) this.gridMappings);
    this.Font = new Font("Tahoma", 8.25f);
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.Name = nameof (FormDirectBillExcelImportMappings);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "File Mappings";
    this.Load += new EventHandler(this.FormDirectBillExcelImportMappings_Load);
    ((ISupportInitialize) this.gridMappings).EndInit();
    ((ISupportInitialize) this.buttonCancel).EndInit();
    ((ISupportInitialize) this.buttonSaveMappings).EndInit();
    ((ISupportInitialize) this.dropDownWorksheetFields).EndInit();
    this.ResumeLayout(false);
  }
}
