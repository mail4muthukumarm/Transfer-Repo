// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.ExcelImport.FormExcelFileMappings
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.Layout;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using Infragistics.Win.UltraWinToolbars;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Accounting.Services.Properties;
using MGASystems.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.ExcelImport;

public class FormExcelFileMappings : Form
{
  private DataTable _excelColumnNames;
  private IContainer components;
  private UltraDropDown dropDownWorksheetFields;
  private UltraGrid gridMappings;
  private UltraToolbarsManager ultraToolbarsManager1;
  private UltraToolbarsDockArea _FormExcelFileMappings_Toolbars_Dock_Area_Left;
  private UltraToolbarsDockArea _FormExcelFileMappings_Toolbars_Dock_Area_Right;
  private UltraToolbarsDockArea _FormExcelFileMappings_Toolbars_Dock_Area_Bottom;
  private UltraToolbarsDockArea _FormExcelFileMappings_Toolbars_Dock_Area_Top;
  protected MGAButton buttonSaveMappings;
  protected MGAButton buttonCancel;
  protected CheckBox checkRememberMappings;

  public List<ExcelImportMapping> Mappings { get; }

  protected string MappingType { get; set; }

  private FormExcelFileMappings() => this.InitializeComponent();

  public FormExcelFileMappings(
    List<ExcelImportMapping> imsMappings,
    DataTable excelColumnNames,
    string mappingType)
  {
    this.InitializeComponent();
    this._excelColumnNames = excelColumnNames;
    this.Mappings = imsMappings;
    this.MappingType = mappingType;
  }

  protected void SetCurrentMappings()
  {
    for (int index = 0; index < this.Mappings.Count; ++index)
    {
      if (!string.IsNullOrEmpty(this.Mappings[index].ExcelFieldName))
        ((UltraGridBase) this.gridMappings).Rows[index].Cells["ExcelFields"].Value = (object) this.Mappings[index].ExcelFieldName;
    }
  }

  private void CreateMappingDataset()
  {
    DataTable dataTable = new DataTable();
    dataTable.Columns.AddRange(new DataColumn[2]
    {
      new DataColumn("IMSFields", typeof (string)),
      new DataColumn("ExcelFields", typeof (string))
    });
    for (int index = 0; index < this.Mappings.Count; ++index)
      dataTable.Rows.Add((object) this.Mappings[index].MappingName);
    ((UltraGridBase) this.gridMappings).DataSource = (object) dataTable;
    this.CreateExcelFieldList();
    this.FormatGrid();
  }

  private void FormExcelMappings_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    this.CreateMappingDataset();
    this.DeserializeMappings();
  }

  private void buttonCancel_Click(object sender, EventArgs e)
  {
    this.DialogResult = DialogResult.Cancel;
    this.Close();
  }

  private void FormatGrid()
  {
    ((UltraGridBase) this.gridMappings).DisplayLayout.Override.HeaderAppearance.TextHAlign = (HAlign) 1;
    ((UltraGridBase) this.gridMappings).DisplayLayout.Bands[0].Columns["IMSFields"].CellActivation = (Activation) 3;
  }

  private void CreateExcelFieldList()
  {
    this._excelColumnNames.DefaultView.Sort = "FieldName ASC";
    ((UltraGridBase) this.dropDownWorksheetFields).DataSource = (object) this._excelColumnNames.DefaultView;
    ((UltraGridBase) this.gridMappings).DisplayLayout.Bands[0].Columns[1].Style = (ColumnStyle) 6;
    ((UltraGridBase) this.gridMappings).DisplayLayout.Bands[0].Columns[1].ValueList = (IValueList) this.dropDownWorksheetFields;
    ((UltraGridBase) this.dropDownWorksheetFields).DisplayLayout.Bands[0].ColHeadersVisible = false;
  }

  protected void SetMappingExcelValues()
  {
    for (int index = 0; index < ((DisposableObjectCollectionBase) ((UltraGridBase) this.gridMappings).Rows).Count; ++index)
      this.Mappings[index].ExcelFieldName = ((UltraGridBase) this.gridMappings).Rows[index].Cells[1].Text;
  }

  protected bool ValidateFieldMappings()
  {
    bool flag = true;
    try
    {
      ((UltraControlBase) this.gridMappings).BeginUpdate();
      ((UltraGridBase) this.gridMappings).DisplayLayout.Bands[0].ColumnFilters["ExcelFields"].FilterConditions.Add((FilterComparisionOperator) 1, (object) DBNull.Value);
      if (((UltraGridBase) this.gridMappings).Rows.GetFilteredInNonGroupByRows().Length == 0)
      {
        int num = (int) MessageBox.Show("You have not specified any Excel mappings. This operation cannot continue.", "Mapping Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return false;
      }
      int num1 = 0;
      foreach (UltraGridRow filteredInNonGroupByRow in ((UltraGridBase) this.gridMappings).Rows.GetFilteredInNonGroupByRows())
      {
        if (this._excelColumnNames.Select($"FieldName = '{filteredInNonGroupByRow.Cells["ExcelFields"].Value}'").Length == 0)
        {
          ++num1;
          ((AppearanceBase) filteredInNonGroupByRow.Cells["ExcelFields"].Appearance).ForeColor = Color.Red;
          ((AppearanceBase) filteredInNonGroupByRow.Cells["ExcelFields"].Appearance).Image = (object) Resources.exclamation;
          ((AppearanceBase) filteredInNonGroupByRow.Cells["ExcelFields"].Appearance).ImageHAlign = (HAlign) 1;
        }
        else
        {
          ((AppearanceBase) filteredInNonGroupByRow.Cells["ExcelFields"].Appearance).ForeColor = Color.Black;
          ((AppearanceBase) filteredInNonGroupByRow.Cells["ExcelFields"].Appearance).Image = (object) null;
        }
      }
      if (num1 > 0)
      {
        int num2 = (int) MessageBox.Show($"The system has found {num1} column mapping(s) that do not exist in the Excel file. Please check the mappings to continue.", "Invalid Excel Field Mappings!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        ((UltraGridBase) this.gridMappings).DisplayLayout.Bands[0].ColumnFilters["ExcelFields"].FilterConditions.Clear();
        return false;
      }
      ((UltraGridBase) this.gridMappings).DisplayLayout.Bands[0].ColumnFilters["ExcelFields"].FilterConditions.Clear();
      for (int index = 0; index < ((DisposableObjectCollectionBase) ((UltraGridBase) this.gridMappings).Rows).Count; ++index)
      {
        if (string.IsNullOrEmpty(((UltraGridBase) this.gridMappings).Rows[index].Cells[1].Text) && this.Mappings[index].IsRequired)
        {
          flag = false;
          break;
        }
      }
      if (flag)
        return flag;
      int num3 = (int) MessageBox.Show("You must define a field mapping for all required fields.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return flag;
    }
    finally
    {
      ((UltraGridBase) this.gridMappings).DisplayLayout.Bands[0].ColumnFilters["ExcelFields"].FilterConditions.Clear();
      ((UltraControlBase) this.gridMappings).EndUpdate();
    }
  }

  private void buttonSaveMappings_Click(object sender, EventArgs e) => this.Save();

  protected virtual void Save()
  {
    if (!this.ValidateFieldMappings())
      return;
    this.SetMappingExcelValues();
    if (this.checkRememberMappings.Checked)
    {
      using (MemoryStream serializationStream = new MemoryStream())
      {
        new BinaryFormatter().Serialize((Stream) serializationStream, (object) this.Mappings);
        this.SerializeMappings("dbo.spFin_ClearUserExcelFileMappings", new object[4]
        {
          (object) "@userGuid",
          (object) CurrentUser.Instance.UserGUID,
          (object) "@mappingType",
          this.MappingType == string.Empty ? (object) "Default Mapping" : (object) this.MappingType
        }, "dbo.spFin_InsertExcelFileMappings", new object[6]
        {
          (object) "@mapping",
          (object) serializationStream.ToArray(),
          (object) "@mappingType",
          this.MappingType == string.Empty ? (object) "Default Mapping" : (object) this.MappingType,
          (object) "@userGuid",
          (object) CurrentUser.Instance.UserGUID
        });
      }
    }
    this.DialogResult = DialogResult.OK;
    this.Close();
  }

  protected void SerializeMappings(
    string clearSproc,
    object[] clearParams,
    string saveSproc,
    object[] saveParams)
  {
    try
    {
      DefaultDatabase.ExecuteNonQuery(clearSproc, clearParams);
      this.AfterMappingsSaved(DefaultDatabase.ExecuteNonQuery(saveSproc, saveParams));
    }
    catch
    {
      throw;
    }
  }

  protected virtual void AfterMappingsSaved(int rowId)
  {
  }

  protected virtual void DeserializeMappings()
  {
    DataRow dataRow = DefaultDatabase.ExecuteDataRow("dbo.spFin_GetExcelFileMappings", new object[4]
    {
      (object) "@mappingType",
      this.MappingType == string.Empty ? (object) "Default Mapping" : (object) this.MappingType,
      (object) "@userGuid",
      (object) CurrentUser.Instance.UserGUID
    });
    if (dataRow == null || dataRow.Table == null || dataRow.Table.Columns.Count == 0 || dataRow.Table.Rows.Count == 0 || MessageBox.Show($"The system has found mappings saved for the mapping type '{this.MappingType}', do you want to use the saved mappings?", "Restore Saved Mappings?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
      return;
    MemoryStream serializationStream = new MemoryStream(dataRow[0] as byte[]);
    try
    {
      BinaryFormatter binaryFormatter = new BinaryFormatter();
      serializationStream.Position = 0L;
      this.Mappings.Clear();
      foreach (ExcelImportMapping excelImportMapping in binaryFormatter.Deserialize((Stream) serializationStream) as List<ExcelImportMapping>)
        this.Mappings.Add(excelImportMapping);
      this.SetCurrentMappings();
    }
    finally
    {
      serializationStream.Dispose();
    }
  }

  private void gridMappings_InitializeRow(object sender, InitializeRowEventArgs e)
  {
    if (e.Row.Index >= this.Mappings.Count)
      return;
    if (this.Mappings[e.Row.Index].IsRequired)
      ((AppearanceBase) e.Row.Cells[0].Appearance).FontData.Bold = (DefaultableBoolean) 1;
    else
      ((AppearanceBase) e.Row.Cells[0].Appearance).FontData.Bold = (DefaultableBoolean) 2;
  }

  private void gridMappings_AfterCellListCloseUp(object sender, CellEventArgs e)
  {
    if (this._excelColumnNames.Select($"FieldName = '{e.Cell.ValueListResolved.GetValue(e.Cell.ValueListResolved.SelectedItemIndex)}'").Length == 0)
      return;
    ((AppearanceBase) e.Cell.Appearance).ForeColor = Color.Black;
    ((AppearanceBase) e.Cell.Appearance).Image = (object) null;
  }

  private void ultraToolbarsManager1_ToolClick(object sender, ToolClickEventArgs e)
  {
    if (!(((KeyedSubObjectBase) ((ToolEventArgs) e).Tool).Key == "CLEAR"))
      return;
    this.ClearValueListSelection();
  }

  private void ClearValueListSelection()
  {
    if (MessageBox.Show("This will clear the current mapping, are you sure you wish to continue?", "Clear Current Mapping?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
      return;
    UltraGridRow activeRow = ((UltraGridBase) this.gridMappings).ActiveRow;
    if (activeRow == null)
      return;
    activeRow.Cells["ExcelFields"].Value = (object) DBNull.Value;
    activeRow.Update();
  }

  private void gridMappings_MouseDown(object sender, MouseEventArgs e)
  {
    if (e.Button != MouseButtons.Right)
      return;
    UIElement uiElement = ((UIElement) ((UltraGridBase) this.gridMappings).DisplayLayout.UIElement).ElementFromPoint(new Point(e.X, e.Y));
    if (uiElement == null)
      return;
    if (!(uiElement is RowUIElement))
      uiElement = uiElement.GetAncestor(typeof (RowUIElement));
    if (uiElement == null || !(uiElement.GetContext(typeof (UltraGridRow)) is UltraGridRow context))
      return;
    context.Activate();
    ((GridItemBase) context).Selected = true;
  }

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
    UltraToolbar ultraToolbar = new UltraToolbar("UltraToolbar1");
    ButtonTool buttonTool1 = new ButtonTool("CLEAR");
    Appearance appearance21 = new Appearance();
    PopupMenuTool popupMenuTool = new PopupMenuTool("gridOptions");
    ButtonTool buttonTool2 = new ButtonTool("CLEAR");
    this.dropDownWorksheetFields = new UltraDropDown();
    this.buttonSaveMappings = new MGAButton();
    this.buttonCancel = new MGAButton();
    this.gridMappings = new UltraGrid();
    this.checkRememberMappings = new CheckBox();
    this.ultraToolbarsManager1 = new UltraToolbarsManager(this.components);
    this._FormExcelFileMappings_Toolbars_Dock_Area_Left = new UltraToolbarsDockArea();
    this._FormExcelFileMappings_Toolbars_Dock_Area_Right = new UltraToolbarsDockArea();
    this._FormExcelFileMappings_Toolbars_Dock_Area_Top = new UltraToolbarsDockArea();
    this._FormExcelFileMappings_Toolbars_Dock_Area_Bottom = new UltraToolbarsDockArea();
    ((ISupportInitialize) this.dropDownWorksheetFields).BeginInit();
    ((ISupportInitialize) this.buttonSaveMappings).BeginInit();
    ((ISupportInitialize) this.buttonCancel).BeginInit();
    ((ISupportInitialize) this.gridMappings).BeginInit();
    ((ISupportInitialize) this.ultraToolbarsManager1).BeginInit();
    this.SuspendLayout();
    ((AppearanceBase) appearance1).BackColor = Color.White;
    ((AppearanceBase) appearance1).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.dropDownWorksheetFields).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.dropDownWorksheetFields).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((UltraGridBase) this.dropDownWorksheetFields).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance2).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance2).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance2).ForeColor = Color.Black;
    ((UltraGridBase) this.dropDownWorksheetFields).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance2;
    ((UltraGridBase) this.dropDownWorksheetFields).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.dropDownWorksheetFields).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.dropDownWorksheetFields).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance3).BorderColor = Color.LightGray;
    ((UltraGridBase) this.dropDownWorksheetFields).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance3;
    ((UltraGridBase) this.dropDownWorksheetFields).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance4).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.dropDownWorksheetFields).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance4;
    ((UltraGridBase) this.dropDownWorksheetFields).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance5).BackColor = Color.White;
    ((AppearanceBase) appearance5).BorderColor = Color.White;
    ((UltraGridBase) this.dropDownWorksheetFields).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance5;
    ((AppearanceBase) appearance6).BorderColor = Color.White;
    ((UltraGridBase) this.dropDownWorksheetFields).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance6;
    ((UltraGridBase) this.dropDownWorksheetFields).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance7).BackColor = Color.Transparent;
    ((AppearanceBase) appearance7).ForeColor = Color.Black;
    ((UltraGridBase) this.dropDownWorksheetFields).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance7;
    ((AppearanceBase) appearance8).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance8).BorderColor = Color.Silver;
    scrollBarLook1.ButtonAppearance = (AppearanceBase) appearance8;
    ((AppearanceBase) appearance9).BackColor = Color.White;
    scrollBarLook1.TrackAppearance = (AppearanceBase) appearance9;
    ((UltraGridBase) this.dropDownWorksheetFields).DisplayLayout.ScrollBarLook = scrollBarLook1;
    ((UltraDropDownBase) this.dropDownWorksheetFields).DisplayMember = "FieldName";
    ((Control) this.dropDownWorksheetFields).Location = new Point(38, 92);
    ((Control) this.dropDownWorksheetFields).Name = "dropDownWorksheetFields";
    ((Control) this.dropDownWorksheetFields).Size = new Size(208 /*0xD0*/, 80 /*0x50*/);
    ((Control) this.dropDownWorksheetFields).TabIndex = 14;
    ((Control) this.dropDownWorksheetFields).Text = "ultraDropDown1";
    ((UltraControlBase) this.dropDownWorksheetFields).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dropDownWorksheetFields).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.dropDownWorksheetFields).ValueMember = "FieldName";
    ((Control) this.dropDownWorksheetFields).Visible = false;
    ((AppearanceBase) appearance10).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance10).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance10).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance10).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance10).Image = (object) Resources.disk;
    ((AppearanceBase) appearance10).ImageHAlign = (HAlign) 1;
    ((AppearanceBase) appearance10).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonSaveMappings).Appearance = (AppearanceBase) appearance10;
    ((Control) this.buttonSaveMappings).Location = new Point(148, 368);
    ((Control) this.buttonSaveMappings).Name = "buttonSaveMappings";
    ((Control) this.buttonSaveMappings).Size = new Size(116, 30);
    ((Control) this.buttonSaveMappings).TabIndex = 13;
    ((Control) this.buttonSaveMappings).Text = "&Save Mappings";
    ((UltraControlBase) this.buttonSaveMappings).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonSaveMappings).Click += new EventHandler(this.buttonSaveMappings_Click);
    ((AppearanceBase) appearance11).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance11).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance11).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance11).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance11).Image = (object) Resources.delete;
    ((AppearanceBase) appearance11).ImageHAlign = (HAlign) 1;
    ((AppearanceBase) appearance11).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonCancel).Appearance = (AppearanceBase) appearance11;
    ((Control) this.buttonCancel).Location = new Point(270, 368);
    ((Control) this.buttonCancel).Name = "buttonCancel";
    ((Control) this.buttonCancel).Size = new Size(85, 30);
    ((Control) this.buttonCancel).TabIndex = 12;
    ((Control) this.buttonCancel).Text = "&Cancel";
    ((UltraControlBase) this.buttonCancel).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonCancel).Click += new EventHandler(this.buttonCancel_Click);
    this.ultraToolbarsManager1.SetContextMenuUltra((Component) this.gridMappings, "gridOptions");
    ((AppearanceBase) appearance12).BackColor = Color.White;
    ((AppearanceBase) appearance12).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridMappings).DisplayLayout.Appearance = (AppearanceBase) appearance12;
    ((UltraGridBase) this.gridMappings).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((UltraGridBase) this.gridMappings).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance13).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance13).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance13).ForeColor = Color.Black;
    ((UltraGridBase) this.gridMappings).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance13;
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
    ((AppearanceBase) appearance14).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridMappings).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance14;
    ((AppearanceBase) appearance15).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.gridMappings).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance15;
    ((UltraGridBase) this.gridMappings).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance16).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridMappings).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance16;
    ((AppearanceBase) appearance17).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridMappings).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance17;
    ((UltraGridBase) this.gridMappings).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance18).BackColor = Color.Transparent;
    ((AppearanceBase) appearance18).ForeColor = Color.Black;
    ((UltraGridBase) this.gridMappings).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance18;
    ((AppearanceBase) appearance19).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance19).BorderColor = Color.Silver;
    scrollBarLook2.ButtonAppearance = (AppearanceBase) appearance19;
    ((AppearanceBase) appearance20).BackColor = Color.White;
    scrollBarLook2.TrackAppearance = (AppearanceBase) appearance20;
    ((UltraGridBase) this.gridMappings).DisplayLayout.ScrollBarLook = scrollBarLook2;
    ((Control) this.gridMappings).Dock = DockStyle.Top;
    ((Control) this.gridMappings).Location = new Point(0, 0);
    ((Control) this.gridMappings).Name = "gridMappings";
    ((Control) this.gridMappings).Size = new Size(367, 362);
    ((Control) this.gridMappings).TabIndex = 11;
    ((UltraControlBase) this.gridMappings).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridMappings).UseOsThemes = (DefaultableBoolean) 2;
    this.gridMappings.InitializeRow += new InitializeRowEventHandler(this.gridMappings_InitializeRow);
    this.gridMappings.AfterCellListCloseUp += new CellEventHandler(this.gridMappings_AfterCellListCloseUp);
    ((Control) this.gridMappings).MouseDown += new MouseEventHandler(this.gridMappings_MouseDown);
    this.checkRememberMappings.AutoSize = true;
    this.checkRememberMappings.Checked = true;
    this.checkRememberMappings.CheckState = CheckState.Checked;
    this.checkRememberMappings.Location = new Point(3, 381);
    this.checkRememberMappings.Name = "checkRememberMappings";
    this.checkRememberMappings.Size = new Size(142, 17);
    this.checkRememberMappings.TabIndex = 15;
    this.checkRememberMappings.Text = "Remember My Mappings";
    this.checkRememberMappings.UseVisualStyleBackColor = true;
    this.ultraToolbarsManager1.DesignerFlags = 1;
    this.ultraToolbarsManager1.DockWithinContainer = (Control) this;
    this.ultraToolbarsManager1.DockWithinContainerBaseType = typeof (Form);
    this.ultraToolbarsManager1.ShowFullMenusDelay = 500;
    ultraToolbar.DockedColumn = 0;
    ultraToolbar.DockedRow = 0;
    ultraToolbar.Text = "UltraToolbar1";
    ultraToolbar.Visible = false;
    this.ultraToolbarsManager1.Toolbars.AddRange(new UltraToolbar[1]
    {
      ultraToolbar
    });
    ((AppearanceBase) appearance21).Image = (object) Resources.arrow_rotate_anticlockwise;
    ((ToolPropsBase) ((ToolBase) buttonTool1).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance21;
    ((ToolPropsBase) ((ToolBase) buttonTool1).SharedPropsInternal).Caption = "Clear Selection";
    ((ToolPropsBase) ((ToolBase) popupMenuTool).SharedPropsInternal).Caption = "gridOptions";
    ((ToolsCollectionBase) popupMenuTool.Tools).AddRange(new ToolBase[1]
    {
      (ToolBase) buttonTool2
    });
    ((ToolsCollectionBase) this.ultraToolbarsManager1.Tools).AddRange(new ToolBase[2]
    {
      (ToolBase) buttonTool1,
      (ToolBase) popupMenuTool
    });
    this.ultraToolbarsManager1.ToolClick += new ToolClickEventHandler(this.ultraToolbarsManager1_ToolClick);
    ((Control) this._FormExcelFileMappings_Toolbars_Dock_Area_Left).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormExcelFileMappings_Toolbars_Dock_Area_Left).BackColor = SystemColors.Control;
    this._FormExcelFileMappings_Toolbars_Dock_Area_Left.DockedPosition = (DockedPosition) 2;
    ((Control) this._FormExcelFileMappings_Toolbars_Dock_Area_Left).ForeColor = SystemColors.ControlText;
    ((Control) this._FormExcelFileMappings_Toolbars_Dock_Area_Left).Location = new Point(0, 0);
    ((Control) this._FormExcelFileMappings_Toolbars_Dock_Area_Left).Name = "_FormExcelFileMappings_Toolbars_Dock_Area_Left";
    ((Control) this._FormExcelFileMappings_Toolbars_Dock_Area_Left).Size = new Size(0, 413);
    this._FormExcelFileMappings_Toolbars_Dock_Area_Left.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._FormExcelFileMappings_Toolbars_Dock_Area_Right).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormExcelFileMappings_Toolbars_Dock_Area_Right).BackColor = SystemColors.Control;
    this._FormExcelFileMappings_Toolbars_Dock_Area_Right.DockedPosition = (DockedPosition) 3;
    ((Control) this._FormExcelFileMappings_Toolbars_Dock_Area_Right).ForeColor = SystemColors.ControlText;
    ((Control) this._FormExcelFileMappings_Toolbars_Dock_Area_Right).Location = new Point(367, 0);
    ((Control) this._FormExcelFileMappings_Toolbars_Dock_Area_Right).Name = "_FormExcelFileMappings_Toolbars_Dock_Area_Right";
    ((Control) this._FormExcelFileMappings_Toolbars_Dock_Area_Right).Size = new Size(0, 413);
    this._FormExcelFileMappings_Toolbars_Dock_Area_Right.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._FormExcelFileMappings_Toolbars_Dock_Area_Top).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormExcelFileMappings_Toolbars_Dock_Area_Top).BackColor = SystemColors.Control;
    this._FormExcelFileMappings_Toolbars_Dock_Area_Top.DockedPosition = (DockedPosition) 0;
    ((Control) this._FormExcelFileMappings_Toolbars_Dock_Area_Top).ForeColor = SystemColors.ControlText;
    ((Control) this._FormExcelFileMappings_Toolbars_Dock_Area_Top).Location = new Point(0, 0);
    ((Control) this._FormExcelFileMappings_Toolbars_Dock_Area_Top).Name = "_FormExcelFileMappings_Toolbars_Dock_Area_Top";
    ((Control) this._FormExcelFileMappings_Toolbars_Dock_Area_Top).Size = new Size(367, 0);
    this._FormExcelFileMappings_Toolbars_Dock_Area_Top.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._FormExcelFileMappings_Toolbars_Dock_Area_Bottom).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormExcelFileMappings_Toolbars_Dock_Area_Bottom).BackColor = SystemColors.Control;
    this._FormExcelFileMappings_Toolbars_Dock_Area_Bottom.DockedPosition = (DockedPosition) 1;
    ((Control) this._FormExcelFileMappings_Toolbars_Dock_Area_Bottom).ForeColor = SystemColors.ControlText;
    ((Control) this._FormExcelFileMappings_Toolbars_Dock_Area_Bottom).Location = new Point(0, 413);
    ((Control) this._FormExcelFileMappings_Toolbars_Dock_Area_Bottom).Name = "_FormExcelFileMappings_Toolbars_Dock_Area_Bottom";
    ((Control) this._FormExcelFileMappings_Toolbars_Dock_Area_Bottom).Size = new Size(367, 0);
    this._FormExcelFileMappings_Toolbars_Dock_Area_Bottom.ToolbarsManager = this.ultraToolbarsManager1;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(367, 413);
    this.Controls.Add((Control) this.buttonSaveMappings);
    this.Controls.Add((Control) this.checkRememberMappings);
    this.Controls.Add((Control) this.dropDownWorksheetFields);
    this.Controls.Add((Control) this.buttonCancel);
    this.Controls.Add((Control) this.gridMappings);
    this.Controls.Add((Control) this._FormExcelFileMappings_Toolbars_Dock_Area_Left);
    this.Controls.Add((Control) this._FormExcelFileMappings_Toolbars_Dock_Area_Right);
    this.Controls.Add((Control) this._FormExcelFileMappings_Toolbars_Dock_Area_Bottom);
    this.Controls.Add((Control) this._FormExcelFileMappings_Toolbars_Dock_Area_Top);
    this.Font = new Font("Tahoma", 8.25f);
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (FormExcelFileMappings);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Excel File Mappings";
    this.Load += new EventHandler(this.FormExcelMappings_Load);
    ((ISupportInitialize) this.dropDownWorksheetFields).EndInit();
    ((ISupportInitialize) this.buttonSaveMappings).EndInit();
    ((ISupportInitialize) this.buttonCancel).EndInit();
    ((ISupportInitialize) this.gridMappings).EndInit();
    ((ISupportInitialize) this.ultraToolbarsManager1).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }
}
