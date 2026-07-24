// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.ExcelImport.FormExcelImportBase
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using Infragistics.Win.UltraWinToolbars;
using MGASystems.AsposeFacade.Cells;
using MGASystems.Common;
using MGASystems.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.ExcelImport;

public class FormExcelImportBase : FormBase
{
  private string _excelFileName;
  private string _excelWorksheetName;
  private DataTable _dtExcelFields;
  private List<ExcelImportMapping> _mappings;
  private bool _excelDataIssuesFound;
  private StringBuilder _dataIssueColumns;
  private bool _fileProcessed;
  protected DataSet excelData;
  private IContainer components;
  private UltraToolbarsDockArea _FormDirectBillExcelImport_Toolbars_Dock_Area_Left;
  private UltraToolbarsDockArea _FormDirectBillExcelImport_Toolbars_Dock_Area_Right;
  private UltraToolbarsDockArea _FormDirectBillExcelImport_Toolbars_Dock_Area_Bottom;
  private UltraToolbarsDockArea _FormDirectBillExcelImport_Toolbars_Dock_Area_Top;
  private UC_WorksheetList uC_WorksheetList1;
  private UC_OfficeLocation uC_OfficeLocation1;
  private UC_BankAccounts uC_BankAccounts1;
  private OpenFileDialog openFileDialog1;
  protected UltraToolbarsManager toolManager;
  protected UltraPanel FormExcelImportBase_Fill_Panel;
  protected UltraGrid gridExcelData;

  [Browsable(false)]
  public bool ShowBankAccounts { get; private set; }

  [Browsable(false)]
  public bool ShowOfficeLocations { get; private set; }

  [Browsable(false)]
  public int SelectOfficeId => this.uC_OfficeLocation1.SelectedOfficeId;

  [Browsable(false)]
  public int SelectBankGLAccounttId => this.uC_BankAccounts1.SelectedBankGLAccountId;

  [Browsable(false)]
  public bool OfficeLocationSelected => this.uC_OfficeLocation1.OfficeIdSelected;

  [Browsable(false)]
  public bool BankAccountSelected => this.uC_BankAccounts1.BankGLAccountSelected;

  [Browsable(true)]
  public List<ExcelImport_IMSField> IMSFields { get; set; }

  [Browsable(true)]
  public List<ExcelImportMapping> Mappings
  {
    get
    {
      if (this._mappings == null)
        this._mappings = new List<ExcelImportMapping>();
      return this._mappings;
    }
    private set => this.Mappings = value;
  }

  [Browsable(false)]
  public bool DataIssuesFound { get; private set; }

  protected string ExcelFileName => this._excelFileName;

  protected string ExcelWorksheetName => this._excelWorksheetName;

  protected Workbook CurrentWorkbook { get; private set; }

  protected DataTable ExcelFields => this._dtExcelFields;

  [Browsable(true)]
  public event EventHandler<ExcelDataLoadedEventArgs> ExcelDataLoaded;

  protected void OnExcelDataLoaded(ExcelDataLoadedEventArgs e)
  {
    EventHandler<ExcelDataLoadedEventArgs> excelDataLoaded = this.ExcelDataLoaded;
    if (excelDataLoaded == null)
      return;
    excelDataLoaded((object) this, e);
  }

  [Browsable(true)]
  public event EventHandler<EventArgs> ExcelMappingsComplete;

  protected void OnExcelMappingsComplete()
  {
    EventHandler<EventArgs> mappingsComplete = this.ExcelMappingsComplete;
    if (mappingsComplete == null)
      return;
    mappingsComplete((object) this, new EventArgs());
  }

  [Browsable(true)]
  public event EventHandler<EventArgs> ExcelMappingsReset;

  protected void OnExcelMappingsReset()
  {
    EventHandler<EventArgs> excelMappingsReset = this.ExcelMappingsReset;
    if (excelMappingsReset == null)
      return;
    excelMappingsReset((object) this, new EventArgs());
  }

  public FormExcelImportBase()
  {
    this.InitializeComponent();
    this.ShowBankAccounts = false;
    this.ShowOfficeLocations = false;
  }

  public FormExcelImportBase(bool showOfficeLocations, bool showBankAccounts)
  {
    this.InitializeComponent();
    this.ShowBankAccounts = showBankAccounts;
    this.ShowOfficeLocations = showOfficeLocations;
  }

  public FormExcelImportBase(
    bool showOfficeLocations,
    bool showBankAccounts,
    List<ExcelImportMapping> imsMappings)
  {
    this.InitializeComponent();
    this.ShowBankAccounts = showBankAccounts;
    this.ShowOfficeLocations = showOfficeLocations;
  }

  private void toolManager_ToolClick(object sender, ToolClickEventArgs e)
  {
    switch (((KeyedSubObjectBase) ((ToolEventArgs) e).Tool).Key)
    {
      case "OPENFILE":
        if (this._dtExcelFields != null)
        {
          if (MessageBox.Show("This will clear all mappings and reset the selected options, continue?", "Clear Selected Options?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            break;
          this.Reset();
        }
        this.OpenExcelFile();
        break;
      case "PROCESS":
        if (this._fileProcessed)
        {
          int num = (int) MessageBox.Show("The file has already been processed. please start again by clicking 'Open File' or downloading your file again.", "File Already Processed", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          break;
        }
        try
        {
          this.ProcessFile();
          this._fileProcessed = true;
          break;
        }
        catch (IOException ex)
        {
          int num = (int) MessageBox.Show("The import file is being used by another process. Please close the file and try again.", "File In Use!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          this._fileProcessed = false;
          break;
        }
        catch
        {
          throw;
        }
      case "MAPPINGS":
        this.ShowMappings();
        break;
    }
  }

  protected virtual void ShowMappings(string mappingType = "Default Mapping")
  {
    if (this._dtExcelFields == null)
    {
      int num = (int) MessageBox.Show("You must specify the Excel fields to be mapped to continue.", "Required Fields Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else
    {
      using (FormExcelFileMappings excelFileMappings = new FormExcelFileMappings(this.Mappings, this._dtExcelFields, mappingType))
      {
        if (excelFileMappings.ShowDialog() != DialogResult.OK)
          return;
        this.OnExcelMappingsComplete();
      }
    }
  }

  private void OpenExcelFile()
  {
    if (this.openFileDialog1.ShowDialog() != DialogResult.OK)
      return;
    this._excelFileName = this.openFileDialog1.FileName;
    this.GetWorksheets();
  }

  private void Reset()
  {
    this._fileProcessed = false;
    this._dtExcelFields = (DataTable) null;
    this.excelData = (DataSet) null;
    ((UltraGridBase) this.gridExcelData).DataSource = (object) null;
    this.Mappings.Clear();
    this.OnExcelMappingsReset();
  }

  private void GetWorksheets()
  {
    this.CurrentWorkbook = new Workbook(this._excelFileName);
    this.LoadWorksheets();
  }

  protected void GetWorksheets(MemoryStream excelFile)
  {
    this.CurrentWorkbook = new Workbook((Stream) excelFile);
    this.LoadWorksheets();
  }

  protected void GetWorksheets(string path)
  {
    this.CurrentWorkbook = new Workbook(path);
    this.LoadWorksheets();
  }

  private void LoadWorksheets()
  {
    if (this.CurrentWorkbook == null)
      return;
    DataTable dataTable = new DataTable();
    dataTable.Columns.AddRange(new DataColumn[1]
    {
      new DataColumn("WorksheetName", typeof (string))
    });
    foreach (Worksheet worksheet in (IEnumerable<Worksheet>) this.CurrentWorkbook.Worksheets)
      dataTable.Rows.Add((object) worksheet.Name);
    this.uC_WorksheetList1.WorksheetListDataSource = (DataTable) null;
    this.uC_WorksheetList1.WorksheetListDataSource = dataTable;
    this.uC_WorksheetList1.DisplayMember = "WorksheetName";
    this.uC_WorksheetList1.ValueMember = "WorksheetName";
    if (this.CurrentWorkbook.Worksheets.Count != 1)
      return;
    this.uC_WorksheetList1.SetSelectedRow(0);
  }

  private void GetExcelData()
  {
    MGASystems.AsposeFacade.Cells.Cells cells = this.CurrentWorkbook.Worksheets[this.uC_WorksheetList1.SelectedWorksheet].Cells;
    cells.DeleteBlankRows();
    if (cells.MaxDataColumn == 0 || cells.MaxDataRow == 0)
    {
      int num = (int) MessageBox.Show("The worksheet selected has no columns or rows.", "Invalid Worksheet Selected!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else
    {
      this.excelData = new DataSet();
      this.excelData.Tables.Add(ExcelImportUtility.BuildExcelDataTable(cells));
      ((UltraGridBase) this.gridExcelData).DataSource = (object) this.excelData;
      this._dtExcelFields = new DataTable();
      this._dtExcelFields.Columns.AddRange(new DataColumn[1]
      {
        new DataColumn("FieldName", typeof (string))
      });
      for (int index = 0; index < this.excelData.Tables[0].Columns.Count; ++index)
        this._dtExcelFields.Rows.Add((object) this.excelData.Tables[0].Columns[index].ColumnName);
      if (!((KeyedSubObjectsCollectionBase) ((UltraGridBase) this.gridExcelData).DisplayLayout.Bands[0].Columns).Exists("importstatus"))
        ((UltraGridBase) this.gridExcelData).DisplayLayout.Bands[0].Columns.Add("importstatus", "Import Status").DataType = typeof (string);
      else
        ((HeaderBase) ((UltraGridBase) this.gridExcelData).DisplayLayout.Bands[0].Columns["importstatus"].Header).VisiblePosition = ((DisposableObjectCollectionBase) ((UltraGridBase) this.gridExcelData).DisplayLayout.Bands[0].Columns).Count;
    }
  }

  private void comboWorksheet_RowSelected(object sender, RowSelectedEventArgs e)
  {
    this._excelWorksheetName = this.uC_WorksheetList1.SelectedWorksheet;
    this.GetExcelData();
    this.FormatGrid();
    this.OnExcelDataLoaded(new ExcelDataLoadedEventArgs(this.excelData, this._excelFileName));
  }

  private void FormatGrid()
  {
    UltraGridBand band = ((UltraGridBase) this.gridExcelData).DisplayLayout.Bands[0];
    if (((DisposableObjectCollectionBase) band.Columns).Count == 0)
      return;
    foreach (UltraGridColumn column in band.Columns)
    {
      if (column.DataType == typeof (string) || column.DataType == typeof (DateTime))
      {
        ((HeaderBase) column.Header).Appearance.TextHAlign = (HAlign) 1;
        column.CellAppearance.TextHAlign = (HAlign) 1;
      }
      else if (column.DataType == typeof (Decimal))
      {
        ((HeaderBase) column.Header).Appearance.TextHAlign = (HAlign) 3;
        column.CellAppearance.TextHAlign = (HAlign) 3;
      }
    }
  }

  private void FormExcelImportBase_Load(object sender, EventArgs e)
  {
    this.uC_WorksheetList1.ComboBoxWidth = 175;
    this.uC_OfficeLocation1.ComboBoxWidth = 200;
    this.uC_BankAccounts1.ComboBoxWidth = 200;
    if (!this.ShowBankAccounts && ((KeyedSubObjectsCollectionBase) this.toolManager.Tools).Exists("BankAccountTool"))
      ((ToolsCollectionBase) ((UltraToolbarBase) this.toolManager.Toolbars[0]).Tools)["BankAccountTool"].InstanceProps.Visible = (DefaultableBoolean) 2;
    if (this.ShowOfficeLocations || !((KeyedSubObjectsCollectionBase) this.toolManager.Tools).Exists("OfficeLocationTool"))
      return;
    ((ToolsCollectionBase) ((UltraToolbarBase) this.toolManager.Toolbars[0]).Tools)["OfficeLocationTool"].InstanceProps.Visible = (DefaultableBoolean) 2;
  }

  protected virtual bool VerifyProcessFile() => true;

  protected virtual void ProcessFile()
  {
  }

  private void CleanData(Worksheet ws)
  {
  }

  protected virtual void PerformDataCheck()
  {
    bool flag1 = false;
    if (this.Mappings.Count == 0)
    {
      int num1 = (int) MessageBox.Show("You must specify field mapping before you can perform this operation (PerformDataCheck).", "Required Field(s) Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else
    {
      bool flag2 = false;
      for (int index = 0; index < this.Mappings.Count; ++index)
      {
        if (!string.IsNullOrEmpty(this.Mappings[index].ExcelFieldName))
        {
          flag2 = true;
          break;
        }
      }
      if (!flag2)
      {
        int num2 = (int) MessageBox.Show("You must specify at least one Excel field to perform this action (PerformDataCheck).", "Required Field(s) Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
      else
      {
        this.DataIssuesFound = false;
        this._dataIssueColumns = (StringBuilder) null;
        for (int index = 0; index < this.Mappings.Count; ++index)
        {
          if (this.Mappings[index].MappingType != typeof (string) && !string.IsNullOrEmpty(this.Mappings[index].ExcelFieldName))
            this.PerformValueCheck(this.Mappings[index].ExcelFieldName, this.Mappings[index].MappingType);
        }
        if (!this.DataIssuesFound || flag1)
          return;
        int num3 = (int) MessageBox.Show($"The system has found data within the spreadsheet that will not import properly based on the data type specified. Please check the data in the excel file. Columns containing data issues: {this._dataIssueColumns.ToString()}", "Invalid Data Detected!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
    }
  }

  private void PerformValueCheck(string columnName, Type comparisonType)
  {
    if (comparisonType == typeof (DateTime))
      return;
    try
    {
      ((UltraControlBase) this.gridExcelData).BeginUpdate();
      Regex regex1 = new Regex("^$");
      if (comparisonType == typeof (Decimal))
      {
        Regex regex2 = new Regex(MGASystems.Common.Settings.SystemSettings.GetSetting<string>("Accounting.Services.ExcelImportBase.DecimalFormatRegex", "^(-?)(\\d*.)?\\d+$"));
        ((UltraGridBase) this.gridExcelData).DisplayLayout.Bands[0].ColumnFilters[columnName].FilterConditions.Add((FilterComparisionOperator) 9, (object) regex2);
      }
      else if (comparisonType == typeof (int))
      {
        Regex regex3 = new Regex("^\\d+$");
        ((UltraGridBase) this.gridExcelData).DisplayLayout.Bands[0].ColumnFilters[columnName].FilterConditions.Add((FilterComparisionOperator) 9, (object) regex3);
      }
      bool flag = false;
      if (((UltraGridBase) this.gridExcelData).Rows.GetFilteredInNonGroupByRows().Length != 0)
      {
        flag = true;
        if (this._dataIssueColumns == null)
        {
          this._dataIssueColumns = new StringBuilder();
          this._dataIssueColumns.AppendLine(string.Empty);
          this._dataIssueColumns.AppendLine(string.Empty);
        }
        this._dataIssueColumns.AppendLine(columnName);
      }
      foreach (UltraGridRow filteredInNonGroupByRow in ((UltraGridBase) this.gridExcelData).Rows.GetFilteredInNonGroupByRows())
      {
        ((AppearanceBase) filteredInNonGroupByRow.Cells[columnName].Appearance).ForeColor = Color.Red;
        ((AppearanceBase) filteredInNonGroupByRow.Cells[columnName].Appearance).FontData.Bold = (DefaultableBoolean) 1;
      }
      if (!flag)
        return;
      this.DataIssuesFound = true;
    }
    catch
    {
      throw;
    }
    finally
    {
      ((UltraGridBase) this.gridExcelData).DisplayLayout.Bands[0].ColumnFilters[columnName].FilterConditions.Clear();
      ((UltraControlBase) this.gridExcelData).EndUpdate();
    }
  }

  protected void PerformBulkInsert(string tableName)
  {
    try
    {
      this.CreateBulkInsertTable(tableName);
      DefaultDatabase.ExecuteBulkInsert(this.CreateBulkInsertDataTable(), (SqlRowsCopiedEventHandler) null, SqlBulkCopyOptions.Default, tableName);
    }
    catch (Exception ex)
    {
      throw ex;
    }
  }

  private void CreateBulkInsertTable(string tableName)
  {
    try
    {
      StringBuilder stringBuilder1 = new StringBuilder();
      StringBuilder stringBuilder2 = new StringBuilder();
      StringBuilder stringBuilder3 = new StringBuilder();
      for (int index = 0; index < this.Mappings.Count; ++index)
      {
        if (!string.IsNullOrEmpty(this.Mappings[index].ExcelFieldName) || this.Mappings[index].GenerateField)
        {
          stringBuilder1.Append(index == 0 ? this.Mappings[index].MappingName : "|" + this.Mappings[index].MappingName);
          if (this.Mappings[index].MappingType == typeof (Decimal))
            stringBuilder2.Append(index == 0 ? "DECIMAL(18,4)" : "|DECIMAL(18,4)");
          else if (this.Mappings[index].MappingType == typeof (string))
            stringBuilder2.Append(index == 0 ? "VARCHAR(500)" : "|VARCHAR(500)");
          else if (this.Mappings[index].MappingType == typeof (int))
            stringBuilder2.Append(index == 0 ? "INT" : "|INT");
          else if (this.Mappings[index].MappingType == typeof (DateTime))
            stringBuilder2.Append(index == 0 ? "DATETIME" : "|DATETIME");
          else if (this.Mappings[index].MappingType == typeof (bool))
            stringBuilder2.Append(index == 0 ? "BIT" : "|BIT");
          if (this.Mappings[index].IsRequired)
            stringBuilder3.Append(index == 0 ? "NOT NULL" : "|NOT NULL");
          else
            stringBuilder3.Append(index == 0 ? "NULL" : "|NULL");
        }
      }
      stringBuilder1.Append("|ImportStatus");
      stringBuilder2.Append("|VARCHAR(MAX)");
      stringBuilder3.Append("|NULL");
      stringBuilder1.Append("|ID");
      stringBuilder2.Append("|INT");
      stringBuilder3.Append("|NULL");
      DefaultDatabase.ExecuteNonQuery("spFin_ExcelImportUtility_BulkInsertCreateTable", new object[8]
      {
        (object) "@TableName",
        (object) tableName,
        (object) "@ColumnNames",
        (object) stringBuilder1.ToString(),
        (object) "@ColumnDataTypes",
        (object) stringBuilder2.ToString(),
        (object) "@ColumnNullable",
        (object) stringBuilder3.ToString()
      });
    }
    catch (Exception ex)
    {
      throw ex;
    }
  }

  private void CleanNullableData()
  {
    string str1 = string.Empty;
    string str2 = string.Empty;
    for (int index1 = 0; index1 < this.excelData.Tables[0].Columns.Count; ++index1)
    {
      for (int index2 = 0; index2 < this.Mappings.Count; ++index2)
      {
        if (this.excelData.Tables[0].Columns[index1].ColumnName == this.Mappings[index2].ExcelFieldName && this.Mappings[index2].MappingType == typeof (DateTime))
          str1 = $"{str1}[{this.excelData.Tables[0].Columns[index1].ColumnName}] = '' or ";
        if (this.excelData.Tables[0].Columns[index1].ColumnName == this.Mappings[index2].ExcelFieldName && this.Mappings[index2].MappingType == typeof (Decimal))
          str2 = $"{str2}[{this.excelData.Tables[0].Columns[index1].ColumnName}] = '' or ";
      }
    }
    DataView defaultView = this.excelData.Tables[0].DefaultView;
    if (!string.IsNullOrEmpty(str2))
    {
      DataView dataView = defaultView;
      dataView.RowFilter = dataView.RowFilter + str1 + str2.Substring(0, str2.Length - 4);
    }
    foreach (DataRowView dataRowView in defaultView)
    {
      for (int index = 0; index < this.excelData.Tables[0].Columns.Count; ++index)
      {
        if (dataRowView != null && dataRowView[index].ToString() == string.Empty && str1.Contains(this.excelData.Tables[0].Columns[index].ColumnName))
          dataRowView[index] = (object) DBNull.Value;
        else if (dataRowView[index].ToString() == string.Empty && str2.Contains(this.excelData.Tables[0].Columns[index].ColumnName))
          dataRowView[index] = (object) 0;
      }
    }
    defaultView.RowFilter = string.Empty;
  }

  private DataTable CreateBulkInsertDataTable()
  {
    List<string> stringList = new List<string>();
    List<DataColumn> dataColumnList = new List<DataColumn>();
    DataTable bulkInsertDataTable = new DataTable();
    try
    {
      ((UltraControlBase) this.gridExcelData).BeginUpdate();
      this.CleanNullableData();
      for (int index = 0; index < this.Mappings.Count; ++index)
      {
        if (!string.IsNullOrEmpty(this.Mappings[index].ExcelFieldName) || this.Mappings[index].GenerateField)
        {
          string columnName = "F" + (100 + index).ToString();
          if (string.IsNullOrEmpty(this.Mappings[index].ExcelFieldName))
          {
            DataColumn column = new DataColumn(columnName, this.Mappings[index].MappingType)
            {
              DefaultValue = this.Mappings[index].DefaultValue
            };
            this.excelData.Tables[0].Columns.Add(column);
            dataColumnList.Add(column);
          }
          stringList.Add(string.IsNullOrEmpty(this.Mappings[index].ExcelFieldName) ? columnName : this.Mappings[index].ExcelFieldName);
          bulkInsertDataTable.Columns.Add(new DataColumn(this.Mappings[index].MappingName, this.Mappings[index].MappingType));
        }
      }
      foreach (DataRow row in (InternalDataCollectionBase) this.excelData.Tables[0].DefaultView.ToTable("table", false, stringList.ToArray()).Rows)
        bulkInsertDataTable.Rows.Add(row.ItemArray);
      bulkInsertDataTable.Columns.Add(new DataColumn("ImportStatus", typeof (string)));
      bulkInsertDataTable.Columns.Add(new DataColumn("ID", typeof (int)));
      for (int index = 0; index < dataColumnList.Count; ++index)
        this.excelData.Tables[0].Columns.Remove(dataColumnList[index]);
    }
    finally
    {
      ((UltraControlBase) this.gridExcelData).EndUpdate();
    }
    return bulkInsertDataTable;
  }

  protected virtual void PerformArchiveFile()
  {
  }

  protected virtual void PerformShowResultFormatting()
  {
    try
    {
      ((UltraControlBase) this.gridExcelData).BeginUpdate();
      UltraGridBand band = ((UltraGridBase) this.gridExcelData).DisplayLayout.Bands[0];
      foreach (UltraGridColumn column in band.Columns)
        column.Hidden = true;
      for (int index = 0; index < this.Mappings.Count; ++index)
      {
        if (!string.IsNullOrEmpty(this.Mappings[index].ExcelFieldName))
          band.Columns[this.Mappings[index].MappingName].Hidden = false;
      }
      band.Columns["ImportStatus"].Hidden = false;
    }
    finally
    {
      ((UltraControlBase) this.gridExcelData).EndUpdate();
    }
  }

  private void UC_OfficeLocation1_RowSelected(object sender, RowSelectedEventArgs e)
  {
    if (!this.uC_BankAccounts1.Visible)
      return;
    this.uC_BankAccounts1.LoadBankAccounts(this.SelectOfficeId);
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
    UltraToolbar ultraToolbar = new UltraToolbar("MainMenu");
    ButtonTool buttonTool1 = new ButtonTool("OPENFILE");
    ControlContainerTool controlContainerTool1 = new ControlContainerTool("ExcelWorkbookTool");
    ControlContainerTool controlContainerTool2 = new ControlContainerTool("OfficeLocationTool");
    ControlContainerTool controlContainerTool3 = new ControlContainerTool("BankAccountTool");
    ButtonTool buttonTool2 = new ButtonTool("MAPPINGS");
    ButtonTool buttonTool3 = new ButtonTool("PROCESS");
    ButtonTool buttonTool4 = new ButtonTool("OPENFILE");
    Appearance appearance1 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormExcelImportBase));
    ButtonTool buttonTool5 = new ButtonTool("PROCESS");
    Appearance appearance2 = new Appearance();
    LabelTool labelTool = new LabelTool("Worksheet:");
    ControlContainerTool controlContainerTool4 = new ControlContainerTool("ExcelWorkbookTool");
    ControlContainerTool controlContainerTool5 = new ControlContainerTool("OfficeLocationTool");
    ButtonTool buttonTool6 = new ButtonTool("MAPPINGS");
    Appearance appearance3 = new Appearance();
    ControlContainerTool controlContainerTool6 = new ControlContainerTool("BankAccountTool");
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    this._FormDirectBillExcelImport_Toolbars_Dock_Area_Top = new UltraToolbarsDockArea();
    this.toolManager = new UltraToolbarsManager(this.components);
    this._FormDirectBillExcelImport_Toolbars_Dock_Area_Bottom = new UltraToolbarsDockArea();
    this._FormDirectBillExcelImport_Toolbars_Dock_Area_Left = new UltraToolbarsDockArea();
    this._FormDirectBillExcelImport_Toolbars_Dock_Area_Right = new UltraToolbarsDockArea();
    this.FormExcelImportBase_Fill_Panel = new UltraPanel();
    this.gridExcelData = new UltraGrid();
    this.uC_WorksheetList1 = new UC_WorksheetList();
    this.uC_OfficeLocation1 = new UC_OfficeLocation();
    this.uC_BankAccounts1 = new UC_BankAccounts();
    this.openFileDialog1 = new OpenFileDialog();
    ((ISupportInitialize) this.toolManager).BeginInit();
    ((Control) this.FormExcelImportBase_Fill_Panel.ClientArea).SuspendLayout();
    ((Control) this.FormExcelImportBase_Fill_Panel).SuspendLayout();
    ((ISupportInitialize) this.gridExcelData).BeginInit();
    this.SuspendLayout();
    ((Control) this._FormDirectBillExcelImport_Toolbars_Dock_Area_Top).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormDirectBillExcelImport_Toolbars_Dock_Area_Top).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._FormDirectBillExcelImport_Toolbars_Dock_Area_Top.DockedPosition = (DockedPosition) 0;
    ((Control) this._FormDirectBillExcelImport_Toolbars_Dock_Area_Top).ForeColor = SystemColors.ControlText;
    ((Control) this._FormDirectBillExcelImport_Toolbars_Dock_Area_Top).Location = new Point(0, 0);
    ((Control) this._FormDirectBillExcelImport_Toolbars_Dock_Area_Top).Name = "_FormDirectBillExcelImport_Toolbars_Dock_Area_Top";
    ((Control) this._FormDirectBillExcelImport_Toolbars_Dock_Area_Top).Size = new Size(1045, 50);
    this._FormDirectBillExcelImport_Toolbars_Dock_Area_Top.ToolbarsManager = this.toolManager;
    this.toolManager.DesignerFlags = 1;
    this.toolManager.DockWithinContainer = (Control) this;
    this.toolManager.DockWithinContainerBaseType = typeof (Form);
    this.toolManager.MdiMergeable = false;
    this.toolManager.ShowFullMenusDelay = 500;
    this.toolManager.Style = (ToolbarStyle) 8;
    ultraToolbar.DockedColumn = 0;
    ultraToolbar.DockedRow = 0;
    ultraToolbar.FloatingLocation = new Point(634, 348);
    ultraToolbar.FloatingSize = new Size(618, 88);
    controlContainerTool1.ControlName = "uC_WorksheetList1";
    ((ToolBase) controlContainerTool1).InstanceProps.IsFirstInGroup = true;
    ((ToolPropsBase) ((ToolBase) controlContainerTool1).InstanceProps).Width = 209;
    controlContainerTool2.ControlName = "uC_OfficeLocation1";
    ((ToolBase) controlContainerTool2).InstanceProps.IsFirstInGroup = true;
    ((ToolPropsBase) ((ToolBase) controlContainerTool2).InstanceProps).Width = 209;
    controlContainerTool3.ControlName = "uC_BankAccounts1";
    ((ToolBase) controlContainerTool3).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) buttonTool2).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) buttonTool3).InstanceProps.IsFirstInGroup = true;
    ((UltraToolbarBase) ultraToolbar).NonInheritedTools.AddRange(new ToolBase[6]
    {
      (ToolBase) buttonTool1,
      (ToolBase) controlContainerTool1,
      (ToolBase) controlContainerTool2,
      (ToolBase) controlContainerTool3,
      (ToolBase) buttonTool2,
      (ToolBase) buttonTool3
    });
    ultraToolbar.Settings.AllowCustomize = (DefaultableBoolean) 2;
    ultraToolbar.Settings.AllowDockBottom = (DefaultableBoolean) 2;
    ultraToolbar.Settings.AllowDockLeft = (DefaultableBoolean) 2;
    ultraToolbar.Settings.AllowDockRight = (DefaultableBoolean) 2;
    ultraToolbar.Settings.AllowDockTop = (DefaultableBoolean) 2;
    ultraToolbar.Settings.AllowFloating = (DefaultableBoolean) 2;
    ultraToolbar.Settings.AllowHiding = (DefaultableBoolean) 2;
    ultraToolbar.Settings.CaptionPlacement = (TextPlacement) 2;
    ultraToolbar.Settings.FillEntireRow = (DefaultableBoolean) 1;
    ultraToolbar.Settings.GrabHandleStyle = (GrabHandleStyle) 1;
    ultraToolbar.Text = "MainMenu";
    this.toolManager.Toolbars.AddRange(new UltraToolbar[1]
    {
      ultraToolbar
    });
    ((AppearanceBase) appearance1).Image = componentResourceManager.GetObject("appearance11.Image");
    ((ToolPropsBase) ((ToolBase) buttonTool4).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance1;
    ((ToolPropsBase) ((ToolBase) buttonTool4).SharedPropsInternal).Caption = "Open Excel File";
    ((ToolPropsBase) ((ToolBase) buttonTool4).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((AppearanceBase) appearance2).Image = componentResourceManager.GetObject("appearance12.Image");
    ((ToolPropsBase) ((ToolBase) buttonTool5).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance2;
    ((ToolPropsBase) ((ToolBase) buttonTool5).SharedPropsInternal).Caption = "Process File";
    ((ToolPropsBase) ((ToolBase) buttonTool5).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((ToolPropsBase) ((ToolBase) labelTool).SharedPropsInternal).Caption = "Worksheet:";
    ((ToolPropsBase) ((ToolBase) labelTool).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    controlContainerTool4.ControlName = "uC_WorksheetList1";
    ((ToolPropsBase) ((ToolBase) controlContainerTool4).SharedPropsInternal).Caption = "ExcelWorkbookTool";
    ((ToolPropsBase) ((ToolBase) controlContainerTool4).SharedPropsInternal).Width = 209;
    controlContainerTool5.ControlName = "uC_OfficeLocation1";
    ((ToolPropsBase) ((ToolBase) controlContainerTool5).SharedPropsInternal).Caption = "OfficeLocationTool";
    ((ToolPropsBase) ((ToolBase) controlContainerTool5).SharedPropsInternal).Width = 209;
    ((AppearanceBase) appearance3).Image = componentResourceManager.GetObject("appearance13.Image");
    ((ToolPropsBase) ((ToolBase) buttonTool6).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance3;
    ((ToolPropsBase) ((ToolBase) buttonTool6).SharedPropsInternal).Caption = "File Mappings";
    ((ToolPropsBase) ((ToolBase) buttonTool6).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    controlContainerTool6.ControlName = "uC_BankAccounts1";
    ((ToolPropsBase) ((ToolBase) controlContainerTool6).SharedPropsInternal).Caption = "BankAccountTool";
    ((ToolsCollectionBase) this.toolManager.Tools).AddRange(new ToolBase[7]
    {
      (ToolBase) buttonTool4,
      (ToolBase) buttonTool5,
      (ToolBase) labelTool,
      (ToolBase) controlContainerTool4,
      (ToolBase) controlContainerTool5,
      (ToolBase) buttonTool6,
      (ToolBase) controlContainerTool6
    });
    ((UltraComponentControlManagerBase) this.toolManager).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraComponentControlManagerBase) this.toolManager).UseOsThemes = (DefaultableBoolean) 2;
    this.toolManager.ToolClick += new ToolClickEventHandler(this.toolManager_ToolClick);
    ((Control) this._FormDirectBillExcelImport_Toolbars_Dock_Area_Bottom).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormDirectBillExcelImport_Toolbars_Dock_Area_Bottom).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._FormDirectBillExcelImport_Toolbars_Dock_Area_Bottom.DockedPosition = (DockedPosition) 1;
    ((Control) this._FormDirectBillExcelImport_Toolbars_Dock_Area_Bottom).ForeColor = SystemColors.ControlText;
    ((Control) this._FormDirectBillExcelImport_Toolbars_Dock_Area_Bottom).Location = new Point(0, 662);
    ((Control) this._FormDirectBillExcelImport_Toolbars_Dock_Area_Bottom).Name = "_FormDirectBillExcelImport_Toolbars_Dock_Area_Bottom";
    ((Control) this._FormDirectBillExcelImport_Toolbars_Dock_Area_Bottom).Size = new Size(1045, 0);
    this._FormDirectBillExcelImport_Toolbars_Dock_Area_Bottom.ToolbarsManager = this.toolManager;
    ((Control) this._FormDirectBillExcelImport_Toolbars_Dock_Area_Left).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormDirectBillExcelImport_Toolbars_Dock_Area_Left).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._FormDirectBillExcelImport_Toolbars_Dock_Area_Left.DockedPosition = (DockedPosition) 2;
    ((Control) this._FormDirectBillExcelImport_Toolbars_Dock_Area_Left).ForeColor = SystemColors.ControlText;
    ((Control) this._FormDirectBillExcelImport_Toolbars_Dock_Area_Left).Location = new Point(0, 50);
    ((Control) this._FormDirectBillExcelImport_Toolbars_Dock_Area_Left).Name = "_FormDirectBillExcelImport_Toolbars_Dock_Area_Left";
    ((Control) this._FormDirectBillExcelImport_Toolbars_Dock_Area_Left).Size = new Size(0, 612);
    this._FormDirectBillExcelImport_Toolbars_Dock_Area_Left.ToolbarsManager = this.toolManager;
    ((Control) this._FormDirectBillExcelImport_Toolbars_Dock_Area_Right).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormDirectBillExcelImport_Toolbars_Dock_Area_Right).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._FormDirectBillExcelImport_Toolbars_Dock_Area_Right.DockedPosition = (DockedPosition) 3;
    ((Control) this._FormDirectBillExcelImport_Toolbars_Dock_Area_Right).ForeColor = SystemColors.ControlText;
    ((Control) this._FormDirectBillExcelImport_Toolbars_Dock_Area_Right).Location = new Point(1045, 50);
    ((Control) this._FormDirectBillExcelImport_Toolbars_Dock_Area_Right).Name = "_FormDirectBillExcelImport_Toolbars_Dock_Area_Right";
    ((Control) this._FormDirectBillExcelImport_Toolbars_Dock_Area_Right).Size = new Size(0, 612);
    this._FormDirectBillExcelImport_Toolbars_Dock_Area_Right.ToolbarsManager = this.toolManager;
    ((AppearanceBase) appearance4).BackColor = Color.Transparent;
    this.FormExcelImportBase_Fill_Panel.Appearance = (AppearanceBase) appearance4;
    ((Control) this.FormExcelImportBase_Fill_Panel.ClientArea).Controls.Add((Control) this.gridExcelData);
    ((Control) this.FormExcelImportBase_Fill_Panel.ClientArea).Controls.Add((Control) this.uC_WorksheetList1);
    ((Control) this.FormExcelImportBase_Fill_Panel.ClientArea).Controls.Add((Control) this.uC_OfficeLocation1);
    ((Control) this.FormExcelImportBase_Fill_Panel.ClientArea).Controls.Add((Control) this.uC_BankAccounts1);
    ((Control) this.FormExcelImportBase_Fill_Panel).Cursor = Cursors.Default;
    ((Control) this.FormExcelImportBase_Fill_Panel).Dock = DockStyle.Fill;
    ((Control) this.FormExcelImportBase_Fill_Panel).Location = new Point(0, 50);
    ((Control) this.FormExcelImportBase_Fill_Panel).Name = "FormExcelImportBase_Fill_Panel";
    ((Control) this.FormExcelImportBase_Fill_Panel).Size = new Size(1045, 612);
    ((Control) this.FormExcelImportBase_Fill_Panel).TabIndex = 8;
    ((AppearanceBase) appearance5).BackColor = Color.White;
    ((AppearanceBase) appearance5).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridExcelData).DisplayLayout.Appearance = (AppearanceBase) appearance5;
    ((UltraGridBase) this.gridExcelData).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((UltraGridBase) this.gridExcelData).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance6).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance6).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance6).ForeColor = Color.Black;
    ((UltraGridBase) this.gridExcelData).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance6;
    ((UltraGridBase) this.gridExcelData).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridExcelData).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridExcelData).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance7).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridExcelData).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance7;
    ((UltraGridBase) this.gridExcelData).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance8).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.gridExcelData).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance8;
    ((UltraGridBase) this.gridExcelData).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance9).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridExcelData).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance9;
    ((AppearanceBase) appearance10).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridExcelData).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance10;
    ((UltraGridBase) this.gridExcelData).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance11).BackColor = Color.Transparent;
    ((AppearanceBase) appearance11).ForeColor = Color.Black;
    ((UltraGridBase) this.gridExcelData).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance11;
    ((AppearanceBase) appearance12).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance12).BorderColor = Color.Silver;
    scrollBarLook.ButtonAppearance = (AppearanceBase) appearance12;
    ((AppearanceBase) appearance13).BackColor = Color.White;
    scrollBarLook.TrackAppearance = (AppearanceBase) appearance13;
    ((UltraGridBase) this.gridExcelData).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.gridExcelData).Dock = DockStyle.Fill;
    ((Control) this.gridExcelData).Location = new Point(0, 0);
    ((Control) this.gridExcelData).Name = "gridExcelData";
    ((Control) this.gridExcelData).Size = new Size(1045, 612);
    ((Control) this.gridExcelData).TabIndex = 3;
    ((UltraControlBase) this.gridExcelData).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridExcelData).UseOsThemes = (DefaultableBoolean) 2;
    this.uC_WorksheetList1.BackColor = Color.Transparent;
    this.uC_WorksheetList1.ComboBoxWidth = 0;
    this.uC_WorksheetList1.Location = new Point(8, 125);
    this.uC_WorksheetList1.Name = "uC_WorksheetList1";
    this.uC_WorksheetList1.Size = new Size(209, 48 /*0x30*/);
    this.uC_WorksheetList1.TabIndex = 2;
    this.uC_WorksheetList1.RowSelected += new UC_WorksheetList.RowSelectedHandler(this.comboWorksheet_RowSelected);
    this.uC_OfficeLocation1.BackColor = Color.Transparent;
    this.uC_OfficeLocation1.ComboBoxWidth = 0;
    this.uC_OfficeLocation1.Font = new Font("Tahoma", 8.25f);
    this.uC_OfficeLocation1.Location = new Point(8, 0);
    this.uC_OfficeLocation1.Name = "uC_OfficeLocation1";
    this.uC_OfficeLocation1.Size = new Size(209, 48 /*0x30*/);
    this.uC_OfficeLocation1.TabIndex = 1;
    this.uC_OfficeLocation1.RowSelected += new UC_OfficeLocation.RowSelectedHandler(this.UC_OfficeLocation1_RowSelected);
    this.uC_BankAccounts1.BackColor = Color.Transparent;
    this.uC_BankAccounts1.ComboBoxWidth = 284;
    this.uC_BankAccounts1.Location = new Point(8, 54);
    this.uC_BankAccounts1.Name = "uC_BankAccounts1";
    this.uC_BankAccounts1.Size = new Size(293, 48 /*0x30*/);
    this.uC_BankAccounts1.TabIndex = 0;
    this.openFileDialog1.FileName = "openFileDialog1";
    this.openFileDialog1.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm|CSV Files|*.csv";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(1045, 662);
    this.Controls.Add((Control) this.FormExcelImportBase_Fill_Panel);
    this.Controls.Add((Control) this._FormDirectBillExcelImport_Toolbars_Dock_Area_Left);
    this.Controls.Add((Control) this._FormDirectBillExcelImport_Toolbars_Dock_Area_Right);
    this.Controls.Add((Control) this._FormDirectBillExcelImport_Toolbars_Dock_Area_Bottom);
    this.Controls.Add((Control) this._FormDirectBillExcelImport_Toolbars_Dock_Area_Top);
    this.Font = new Font("Tahoma", 8.25f);
    this.Name = nameof (FormExcelImportBase);
    this.Text = nameof (FormExcelImportBase);
    this.Load += new EventHandler(this.FormExcelImportBase_Load);
    ((ISupportInitialize) this.toolManager).EndInit();
    ((Control) this.FormExcelImportBase_Fill_Panel.ClientArea).ResumeLayout(false);
    ((Control) this.FormExcelImportBase_Fill_Panel).ResumeLayout(false);
    ((ISupportInitialize) this.gridExcelData).EndInit();
    this.ResumeLayout(false);
  }
}
