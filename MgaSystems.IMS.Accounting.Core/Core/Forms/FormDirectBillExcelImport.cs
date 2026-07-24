// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.Forms.FormDirectBillExcelImport
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using Infragistics.Win.UltraWinToolbars;
using MGASystems.AsposeFacade.Cells;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Accounting.Core.Controls;
using MGASystems.IMS.Accounting.Core.Properties;
using MGASystems.IMS.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.Forms;

[TestForm]
public class FormDirectBillExcelImport : FormBase
{
  protected DataSet excelData;
  private string _excelFileName;
  private DataTable _dtExcelFields;
  private string _invoiceMapping;
  private string _checkNumberMapping;
  private string _amountMapping;
  private string _dateMapping;
  private bool _mappingComplete;
  private IContainer components;
  private UltraToolbarsManager ultraToolbarsManager1;
  private UltraPanel FormDirectBillExcelImport_Fill_Panel;
  private UltraToolbarsDockArea _FormDirectBillExcelImport_Toolbars_Dock_Area_Left;
  private UltraToolbarsDockArea _FormDirectBillExcelImport_Toolbars_Dock_Area_Right;
  private UltraToolbarsDockArea _FormDirectBillExcelImport_Toolbars_Dock_Area_Bottom;
  private UltraToolbarsDockArea _FormDirectBillExcelImport_Toolbars_Dock_Area_Top;
  private UltraGrid gridExcelData;
  private OpenFileDialog openFileDialog1;
  private UC_OfficeLocation uC_OfficeLocation1;
  private UC_WorksheetList uC_WorksheetList1;
  private UC_BankAccounts uC_BankAccounts1;

  public FormDirectBillExcelImport() => this.InitializeComponent();

  private void OpenExcelFile()
  {
    if (this.openFileDialog1.ShowDialog() != DialogResult.OK)
      return;
    this._excelFileName = this.openFileDialog1.FileName;
    this.GetWorksheets();
  }

  private bool VerifyProcessFile()
  {
    if (this.uC_BankAccounts1.SelectedBankGLAccountId == -1)
    {
      int num = (int) MessageBox.Show("You must specify a bank account to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (!this._mappingComplete)
    {
      int num = (int) MessageBox.Show("You must specify the data field mappings to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    StringBuilder stringBuilder = new StringBuilder();
    stringBuilder.AppendLine("Mapping Verification");
    stringBuilder.AppendLine("");
    stringBuilder.Append("Invoice Number -> ");
    stringBuilder.AppendLine(this._invoiceMapping);
    stringBuilder.Append("Check Number -> ");
    stringBuilder.AppendLine(this._checkNumberMapping);
    stringBuilder.Append("Amount Number -> ");
    stringBuilder.AppendLine(this._amountMapping);
    stringBuilder.Append("Deposit Date -> ");
    stringBuilder.AppendLine(this._dateMapping);
    stringBuilder.AppendLine("");
    stringBuilder.AppendLine("Continue with these mappings?");
    return MessageBox.Show(stringBuilder.ToString(), "Mappings Are Correct?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No;
  }

  private void ProcessFile()
  {
    if (!this.VerifyProcessFile())
      return;
    DefaultDatabase.ExecuteTransaction((EventHandler<ExecuteTransactionEventArgs>) ((sender, e) =>
    {
      this.Cursor = MgaCursors.WaitCursor;
      try
      {
        DefaultDatabase.ExecuteNonQuery(CommandType.Text, "TRUNCATE TABLE dbo.tblFin_DirectBillExcelImport");
        DataTable dataTable = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT * FROM dbo.tblFin_DirectBillExcelImport");
        DataTable dt = dataTable.Clone();
        foreach (DataColumn column in (InternalDataCollectionBase) dt.Columns)
          column.DataType = typeof (string);
        dt.Columns.Remove("userGuid");
        dt.Columns.Remove("glCompanyid");
        dt.Columns.Remove("bankglacctid");
        int selectedOfficeId = this.uC_OfficeLocation1.SelectedOfficeId;
        int selectedBankGlAccountId = this.uC_BankAccounts1.SelectedBankGLAccountId;
        Guid userGuid = CurrentUser.Instance.UserGUID;
        for (int index = 0; index < this.excelData.Tables[0].Rows.Count; ++index)
        {
          object obj1 = this.excelData.Tables[0].Rows[index][this._invoiceMapping];
          object obj2 = this.excelData.Tables[0].Rows[index][this._dateMapping];
          object obj3 = this.excelData.Tables[0].Rows[index][this._amountMapping];
          object obj4 = this.excelData.Tables[0].Rows[index][this._checkNumberMapping];
          if (!int.TryParse(obj1.ToString(), out int _))
            dt.Rows.Add(obj1, obj4, obj2, obj3, (object) "Import failed - Invoice number not an integer value.");
          else if (!Decimal.TryParse(obj3.ToString(), out Decimal _))
            dt.Rows.Add(obj1, obj4, obj2, obj3, (object) "Import failed - Check amount is not a decimal value.");
          else if (!DateTime.TryParse(obj2.ToString(), out DateTime _))
            dt.Rows.Add(obj1, obj4, obj2, obj3, (object) "Import failed - Deposit date is not a date.");
          else
            dataTable.Rows.Add((object) selectedOfficeId, (object) selectedBankGlAccountId, obj1, obj4, obj2, obj3, (object) "Processing...", (object) userGuid);
        }
        DefaultDatabase.ExecuteBulkInsert(dataTable, (SqlRowsCopiedEventHandler) null, SqlBulkCopyOptions.Default, "dbo.tblFin_DirectBillExcelImport");
        DefaultDatabase.ExecuteNonQuery("dbo.spFin_ProcessDirectBillExcel");
        this.DisplayDataErrors(dt);
        this.DisplayImportStatus();
        e.Transaction.Commit();
      }
      catch (Exception ex)
      {
        e.Transaction.Rollback();
        throw ex;
      }
      finally
      {
        this.Cursor = MgaCursors.Default;
      }
    }));
  }

  private void DisplayDataErrors(DataTable dt)
  {
    ((UltraControlBase) this.gridExcelData).BeginUpdate();
    foreach (DataRow row in (InternalDataCollectionBase) dt.Rows)
    {
      foreach (UltraGridBand band in ((UltraGridBase) this.gridExcelData).DisplayLayout.Bands)
      {
        band.ColumnFilters.ClearAllFilters();
        band.ColumnFilters[this._invoiceMapping].FilterConditions.Add((FilterComparisionOperator) 0, row["invoicenumber"]);
      }
      foreach (UltraGridRow filteredInNonGroupByRow in ((UltraGridBase) this.gridExcelData).Rows.GetFilteredInNonGroupByRows())
      {
        filteredInNonGroupByRow.Cells["importstatus"].Value = row["importstatus"];
        filteredInNonGroupByRow.Activation = (Activation) 3;
        ((AppearanceBase) filteredInNonGroupByRow.Cells["importstatus"].Appearance).ForeColor = Color.Red;
        filteredInNonGroupByRow.Cells["importstatus"].SelectedAppearance.ForeColor = Color.Red;
      }
      foreach (UltraGridBand band in ((UltraGridBase) this.gridExcelData).DisplayLayout.Bands)
        band.ColumnFilters.ClearAllFilters();
    }
    ((UltraControlBase) this.gridExcelData).EndUpdate();
  }

  private void DisplayImportStatus()
  {
    DataTable dataTable = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT * FROM dbo.tblFin_DirectBillExcelImport");
    ((UltraControlBase) this.gridExcelData).BeginUpdate();
    foreach (DataRow row in (InternalDataCollectionBase) dataTable.Rows)
    {
      foreach (UltraGridBand band in ((UltraGridBase) this.gridExcelData).DisplayLayout.Bands)
      {
        band.ColumnFilters.ClearAllFilters();
        band.ColumnFilters[this._invoiceMapping].FilterConditions.Add((FilterComparisionOperator) 0, row["invoicenumber"]);
      }
      foreach (UltraGridRow filteredInNonGroupByRow in ((UltraGridBase) this.gridExcelData).Rows.GetFilteredInNonGroupByRows())
      {
        filteredInNonGroupByRow.Cells["importstatus"].Value = row["importstatus"];
        if (row["importstatus"].ToString().Contains("Success"))
        {
          filteredInNonGroupByRow.Activation = (Activation) 3;
          ((AppearanceBase) filteredInNonGroupByRow.Cells["importstatus"].Appearance).ForeColor = Color.Green;
          filteredInNonGroupByRow.Cells["importstatus"].SelectedAppearance.ForeColor = Color.Green;
        }
        else
        {
          filteredInNonGroupByRow.Activation = (Activation) 3;
          ((AppearanceBase) filteredInNonGroupByRow.Cells["importstatus"].Appearance).ForeColor = Color.Red;
          filteredInNonGroupByRow.Cells["importstatus"].SelectedAppearance.ForeColor = Color.Red;
        }
      }
      foreach (UltraGridBand band in ((UltraGridBase) this.gridExcelData).DisplayLayout.Bands)
        band.ColumnFilters.ClearAllFilters();
    }
    ((UltraControlBase) this.gridExcelData).EndUpdate();
  }

  private void ultraToolbarsManager1_ToolClick(object sender, ToolClickEventArgs e)
  {
    switch (((KeyedSubObjectBase) ((ToolEventArgs) e).Tool).Key)
    {
      case "OPENFILE":
        this.OpenExcelFile();
        break;
      case "PROCESS":
        this.ProcessFile();
        break;
      case "MAPPINGS":
        using (FormDirectBillExcelImportMappings excelImportMappings = new FormDirectBillExcelImportMappings(this._dtExcelFields))
        {
          if (excelImportMappings.ShowDialog() != DialogResult.OK)
            break;
          this._mappingComplete = true;
          this._invoiceMapping = excelImportMappings.InvoiceMapping;
          this._checkNumberMapping = excelImportMappings.CheckNumberMapping;
          this._amountMapping = excelImportMappings.AmountMapping;
          this._dateMapping = excelImportMappings.DateMapping;
          break;
        }
    }
  }

  private void GetWorksheets()
  {
    Workbook workbook = new Workbook(this._excelFileName);
    DataTable dataTable = new DataTable();
    dataTable.Columns.AddRange(new DataColumn[1]
    {
      new DataColumn("WorksheetName", typeof (string))
    });
    foreach (Worksheet worksheet in (IEnumerable<Worksheet>) workbook.Worksheets)
      dataTable.Rows.Add((object) worksheet.Name);
    this.uC_WorksheetList1.WorksheetListDataSource = dataTable;
    this.uC_WorksheetList1.DisplayMember = "WorksheetName";
    this.uC_WorksheetList1.ValueMember = "WorksheetName";
  }

  private void GetExcelData()
  {
    MGASystems.AsposeFacade.Cells.Cells cells = new Workbook(this._excelFileName).Worksheets[this.uC_WorksheetList1.SelectedWorksheet].Cells;
    if (cells.MaxDataColumn == 0 || cells.MaxDataRow == 0)
    {
      int num = (int) MessageBox.Show("The worksheet selected has no columns or rows.", "Invalid Worksheet Selected!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else
    {
      this.excelData = new DataSet();
      this.excelData.Tables.Add(this.BuildExcelDataTable(cells));
      ((UltraGridBase) this.gridExcelData).DataSource = (object) this.excelData;
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
    this.GetExcelData();
  }

  private void FormDirectBillExcelImport_Load(object sender, EventArgs e)
  {
    this.uC_WorksheetList1.ComboBoxWidth = 175;
    this.uC_OfficeLocation1.ComboBoxWidth = 200;
    this.uC_BankAccounts1.ComboBoxWidth = 200;
    this._dtExcelFields = new DataTable();
    this._dtExcelFields.Columns.AddRange(new DataColumn[1]
    {
      new DataColumn("FieldName", typeof (string))
    });
  }

  private void uC_OfficeLocation1_RowSelected(object sender, RowSelectedEventArgs e)
  {
    if (this.uC_OfficeLocation1.SelectedOfficeId == -1)
      return;
    this.uC_BankAccounts1.LoadBankAccounts(this.uC_OfficeLocation1.SelectedOfficeId);
  }

  private DataTable BuildExcelDataTable(MGASystems.AsposeFacade.Cells.Cells cls)
  {
    DataTable dataTable = new DataTable();
    int num = 1;
    for (int index = 0; index < cls.Columns.Count; ++index)
    {
      if (cls.Worksheet.Cells[0, index].Value != null)
      {
        dataTable.Columns.Add(cls.Worksheet.Cells[0, index].Value.ToString(), typeof (string));
      }
      else
      {
        dataTable.Columns.Add($"F{num.ToString()}", typeof (string));
        ++num;
      }
    }
    for (int index1 = 1; index1 < cls.Rows.Count; ++index1)
    {
      List<object> objectList = new List<object>();
      for (int index2 = 0; index2 < cls.Columns.Count; ++index2)
      {
        if (cls[index1, index2].Value != null)
          objectList.Add((object) cls[index1, index2].Value.ToString());
        else
          objectList.Add((object) string.Empty);
      }
      dataTable.Rows.Add(objectList.ToArray());
    }
    return dataTable;
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
    Appearance appearance8 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    UltraToolbar ultraToolbar = new UltraToolbar("MainMenu");
    ButtonTool buttonTool1 = new ButtonTool("OPENFILE");
    ControlContainerTool controlContainerTool1 = new ControlContainerTool("ControlContainerTool2");
    ControlContainerTool controlContainerTool2 = new ControlContainerTool("ControlContainerTool3");
    ControlContainerTool controlContainerTool3 = new ControlContainerTool("ControlContainerTool4");
    ButtonTool buttonTool2 = new ButtonTool("MAPPINGS");
    ButtonTool buttonTool3 = new ButtonTool("PROCESS");
    ButtonTool buttonTool4 = new ButtonTool("OPENFILE");
    Appearance appearance11 = new Appearance();
    ButtonTool buttonTool5 = new ButtonTool("PROCESS");
    Appearance appearance12 = new Appearance();
    ControlContainerTool controlContainerTool4 = new ControlContainerTool("ControlContainerTool1");
    LabelTool labelTool = new LabelTool("Worksheet:");
    ControlContainerTool controlContainerTool5 = new ControlContainerTool("ControlContainerTool2");
    ControlContainerTool controlContainerTool6 = new ControlContainerTool("ControlContainerTool3");
    ButtonTool buttonTool6 = new ButtonTool("MAPPINGS");
    Appearance appearance13 = new Appearance();
    ControlContainerTool controlContainerTool7 = new ControlContainerTool("ControlContainerTool4");
    this.FormDirectBillExcelImport_Fill_Panel = new UltraPanel();
    this.uC_BankAccounts1 = new UC_BankAccounts();
    this.uC_WorksheetList1 = new UC_WorksheetList();
    this.uC_OfficeLocation1 = new UC_OfficeLocation();
    this.gridExcelData = new UltraGrid();
    this._FormDirectBillExcelImport_Toolbars_Dock_Area_Left = new UltraToolbarsDockArea();
    this.ultraToolbarsManager1 = new UltraToolbarsManager(this.components);
    this._FormDirectBillExcelImport_Toolbars_Dock_Area_Right = new UltraToolbarsDockArea();
    this._FormDirectBillExcelImport_Toolbars_Dock_Area_Top = new UltraToolbarsDockArea();
    this._FormDirectBillExcelImport_Toolbars_Dock_Area_Bottom = new UltraToolbarsDockArea();
    this.openFileDialog1 = new OpenFileDialog();
    ((Control) this.FormDirectBillExcelImport_Fill_Panel.ClientArea).SuspendLayout();
    ((Control) this.FormDirectBillExcelImport_Fill_Panel).SuspendLayout();
    ((ISupportInitialize) this.gridExcelData).BeginInit();
    ((ISupportInitialize) this.ultraToolbarsManager1).BeginInit();
    this.SuspendLayout();
    ((AppearanceBase) appearance1).BackColor = Color.Transparent;
    this.FormDirectBillExcelImport_Fill_Panel.Appearance = (AppearanceBase) appearance1;
    ((Control) this.FormDirectBillExcelImport_Fill_Panel.ClientArea).Controls.Add((Control) this.uC_BankAccounts1);
    ((Control) this.FormDirectBillExcelImport_Fill_Panel.ClientArea).Controls.Add((Control) this.uC_WorksheetList1);
    ((Control) this.FormDirectBillExcelImport_Fill_Panel.ClientArea).Controls.Add((Control) this.uC_OfficeLocation1);
    ((Control) this.FormDirectBillExcelImport_Fill_Panel.ClientArea).Controls.Add((Control) this.gridExcelData);
    ((Control) this.FormDirectBillExcelImport_Fill_Panel).Cursor = Cursors.Default;
    ((Control) this.FormDirectBillExcelImport_Fill_Panel).Dock = DockStyle.Fill;
    ((Control) this.FormDirectBillExcelImport_Fill_Panel).Location = new Point(0, 49);
    ((Control) this.FormDirectBillExcelImport_Fill_Panel).Name = "FormDirectBillExcelImport_Fill_Panel";
    ((Control) this.FormDirectBillExcelImport_Fill_Panel).Size = new Size(944, 582);
    ((Control) this.FormDirectBillExcelImport_Fill_Panel).TabIndex = 0;
    this.uC_BankAccounts1.BackColor = Color.Transparent;
    this.uC_BankAccounts1.ComboBoxWidth = 32 /*0x20*/;
    this.uC_BankAccounts1.Location = new Point(8, 114);
    this.uC_BankAccounts1.Name = "uC_BankAccounts1";
    this.uC_BankAccounts1.Size = new Size(209, 47);
    this.uC_BankAccounts1.TabIndex = 9;
    this.uC_WorksheetList1.BackColor = Color.Transparent;
    this.uC_WorksheetList1.ComboBoxWidth = 32 /*0x20*/;
    this.uC_WorksheetList1.Location = new Point(8, 61);
    this.uC_WorksheetList1.Name = "uC_WorksheetList1";
    this.uC_WorksheetList1.Size = new Size(209, 47);
    this.uC_WorksheetList1.TabIndex = 5;
    this.uC_WorksheetList1.RowSelected += new UC_WorksheetList.RowSelectedHandler(this.comboWorksheet_RowSelected);
    this.uC_OfficeLocation1.BackColor = Color.Transparent;
    this.uC_OfficeLocation1.ComboBoxWidth = 32 /*0x20*/;
    this.uC_OfficeLocation1.Font = new Font("Tahoma", 8.25f);
    this.uC_OfficeLocation1.Location = new Point(8, 8);
    this.uC_OfficeLocation1.Name = "uC_OfficeLocation1";
    this.uC_OfficeLocation1.Size = new Size(209, 47);
    this.uC_OfficeLocation1.TabIndex = 8;
    this.uC_OfficeLocation1.RowSelected += new UC_OfficeLocation.RowSelectedHandler(this.uC_OfficeLocation1_RowSelected);
    ((AppearanceBase) appearance2).BackColor = Color.White;
    ((AppearanceBase) appearance2).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridExcelData).DisplayLayout.Appearance = (AppearanceBase) appearance2;
    ((UltraGridBase) this.gridExcelData).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((UltraGridBase) this.gridExcelData).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance3).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance3).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance3).ForeColor = Color.Black;
    ((UltraGridBase) this.gridExcelData).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance3;
    ((UltraGridBase) this.gridExcelData).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridExcelData).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridExcelData).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance4).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridExcelData).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance4;
    ((UltraGridBase) this.gridExcelData).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance5).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.gridExcelData).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance5;
    ((UltraGridBase) this.gridExcelData).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance6).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridExcelData).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance6;
    ((AppearanceBase) appearance7).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridExcelData).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance7;
    ((UltraGridBase) this.gridExcelData).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance8).BackColor = Color.Transparent;
    ((AppearanceBase) appearance8).ForeColor = Color.Black;
    ((UltraGridBase) this.gridExcelData).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance8;
    ((AppearanceBase) appearance9).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance9).BorderColor = Color.Silver;
    scrollBarLook.ButtonAppearance = (AppearanceBase) appearance9;
    ((AppearanceBase) appearance10).BackColor = Color.White;
    scrollBarLook.TrackAppearance = (AppearanceBase) appearance10;
    ((UltraGridBase) this.gridExcelData).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.gridExcelData).Dock = DockStyle.Fill;
    ((Control) this.gridExcelData).Location = new Point(0, 0);
    ((Control) this.gridExcelData).Name = "gridExcelData";
    ((Control) this.gridExcelData).Size = new Size(944, 582);
    ((Control) this.gridExcelData).TabIndex = 0;
    ((UltraControlBase) this.gridExcelData).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridExcelData).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this._FormDirectBillExcelImport_Toolbars_Dock_Area_Left).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormDirectBillExcelImport_Toolbars_Dock_Area_Left).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._FormDirectBillExcelImport_Toolbars_Dock_Area_Left.DockedPosition = (DockedPosition) 2;
    ((Control) this._FormDirectBillExcelImport_Toolbars_Dock_Area_Left).ForeColor = SystemColors.ControlText;
    ((Control) this._FormDirectBillExcelImport_Toolbars_Dock_Area_Left).Location = new Point(0, 49);
    ((Control) this._FormDirectBillExcelImport_Toolbars_Dock_Area_Left).Name = "_FormDirectBillExcelImport_Toolbars_Dock_Area_Left";
    ((Control) this._FormDirectBillExcelImport_Toolbars_Dock_Area_Left).Size = new Size(0, 582);
    this._FormDirectBillExcelImport_Toolbars_Dock_Area_Left.ToolbarsManager = this.ultraToolbarsManager1;
    this.ultraToolbarsManager1.DesignerFlags = 1;
    this.ultraToolbarsManager1.DockWithinContainer = (Control) this;
    this.ultraToolbarsManager1.DockWithinContainerBaseType = typeof (Form);
    this.ultraToolbarsManager1.MdiMergeable = false;
    this.ultraToolbarsManager1.ShowFullMenusDelay = 500;
    this.ultraToolbarsManager1.Style = (ToolbarStyle) 8;
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
    this.ultraToolbarsManager1.Toolbars.AddRange(new UltraToolbar[1]
    {
      ultraToolbar
    });
    ((AppearanceBase) appearance11).Image = (object) Resources.Excel;
    ((ToolPropsBase) ((ToolBase) buttonTool4).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance11;
    ((ToolPropsBase) ((ToolBase) buttonTool4).SharedPropsInternal).Caption = "Open Excel File";
    ((ToolPropsBase) ((ToolBase) buttonTool4).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((AppearanceBase) appearance12).Image = (object) Resources.cog_edit;
    ((ToolPropsBase) ((ToolBase) buttonTool5).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance12;
    ((ToolPropsBase) ((ToolBase) buttonTool5).SharedPropsInternal).Caption = "Process File";
    ((ToolPropsBase) ((ToolBase) buttonTool5).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((ToolPropsBase) ((ToolBase) controlContainerTool4).SharedPropsInternal).Caption = "ControlContainerTool1";
    ((ToolPropsBase) ((ToolBase) labelTool).SharedPropsInternal).Caption = "Worksheet:";
    ((ToolPropsBase) ((ToolBase) labelTool).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    controlContainerTool5.ControlName = "uC_WorksheetList1";
    ((ToolPropsBase) ((ToolBase) controlContainerTool5).SharedPropsInternal).Caption = "ControlContainerTool2";
    ((ToolPropsBase) ((ToolBase) controlContainerTool5).SharedPropsInternal).Width = 209;
    controlContainerTool6.ControlName = "uC_OfficeLocation1";
    ((ToolPropsBase) ((ToolBase) controlContainerTool6).SharedPropsInternal).Caption = "ControlContainerTool3";
    ((ToolPropsBase) ((ToolBase) controlContainerTool6).SharedPropsInternal).Width = 209;
    ((AppearanceBase) appearance13).Image = (object) Resources.bricks;
    ((ToolPropsBase) ((ToolBase) buttonTool6).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance13;
    ((ToolPropsBase) ((ToolBase) buttonTool6).SharedPropsInternal).Caption = "File Mappings";
    ((ToolPropsBase) ((ToolBase) buttonTool6).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    controlContainerTool7.ControlName = "uC_BankAccounts1";
    ((ToolPropsBase) ((ToolBase) controlContainerTool7).SharedPropsInternal).Caption = "ControlContainerTool4";
    ((ToolsCollectionBase) this.ultraToolbarsManager1.Tools).AddRange(new ToolBase[8]
    {
      (ToolBase) buttonTool4,
      (ToolBase) buttonTool5,
      (ToolBase) controlContainerTool4,
      (ToolBase) labelTool,
      (ToolBase) controlContainerTool5,
      (ToolBase) controlContainerTool6,
      (ToolBase) buttonTool6,
      (ToolBase) controlContainerTool7
    });
    ((UltraComponentControlManagerBase) this.ultraToolbarsManager1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraComponentControlManagerBase) this.ultraToolbarsManager1).UseOsThemes = (DefaultableBoolean) 2;
    this.ultraToolbarsManager1.ToolClick += new ToolClickEventHandler(this.ultraToolbarsManager1_ToolClick);
    ((Control) this._FormDirectBillExcelImport_Toolbars_Dock_Area_Right).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormDirectBillExcelImport_Toolbars_Dock_Area_Right).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._FormDirectBillExcelImport_Toolbars_Dock_Area_Right.DockedPosition = (DockedPosition) 3;
    ((Control) this._FormDirectBillExcelImport_Toolbars_Dock_Area_Right).ForeColor = SystemColors.ControlText;
    ((Control) this._FormDirectBillExcelImport_Toolbars_Dock_Area_Right).Location = new Point(944, 49);
    ((Control) this._FormDirectBillExcelImport_Toolbars_Dock_Area_Right).Name = "_FormDirectBillExcelImport_Toolbars_Dock_Area_Right";
    ((Control) this._FormDirectBillExcelImport_Toolbars_Dock_Area_Right).Size = new Size(0, 582);
    this._FormDirectBillExcelImport_Toolbars_Dock_Area_Right.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._FormDirectBillExcelImport_Toolbars_Dock_Area_Top).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormDirectBillExcelImport_Toolbars_Dock_Area_Top).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._FormDirectBillExcelImport_Toolbars_Dock_Area_Top.DockedPosition = (DockedPosition) 0;
    ((Control) this._FormDirectBillExcelImport_Toolbars_Dock_Area_Top).ForeColor = SystemColors.ControlText;
    ((Control) this._FormDirectBillExcelImport_Toolbars_Dock_Area_Top).Location = new Point(0, 0);
    ((Control) this._FormDirectBillExcelImport_Toolbars_Dock_Area_Top).Name = "_FormDirectBillExcelImport_Toolbars_Dock_Area_Top";
    ((Control) this._FormDirectBillExcelImport_Toolbars_Dock_Area_Top).Size = new Size(944, 49);
    this._FormDirectBillExcelImport_Toolbars_Dock_Area_Top.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._FormDirectBillExcelImport_Toolbars_Dock_Area_Bottom).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormDirectBillExcelImport_Toolbars_Dock_Area_Bottom).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._FormDirectBillExcelImport_Toolbars_Dock_Area_Bottom.DockedPosition = (DockedPosition) 1;
    ((Control) this._FormDirectBillExcelImport_Toolbars_Dock_Area_Bottom).ForeColor = SystemColors.ControlText;
    ((Control) this._FormDirectBillExcelImport_Toolbars_Dock_Area_Bottom).Location = new Point(0, 631);
    ((Control) this._FormDirectBillExcelImport_Toolbars_Dock_Area_Bottom).Name = "_FormDirectBillExcelImport_Toolbars_Dock_Area_Bottom";
    ((Control) this._FormDirectBillExcelImport_Toolbars_Dock_Area_Bottom).Size = new Size(944, 0);
    this._FormDirectBillExcelImport_Toolbars_Dock_Area_Bottom.ToolbarsManager = this.ultraToolbarsManager1;
    this.openFileDialog1.FileName = "openFileDialog1";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(944, 631);
    this.Controls.Add((Control) this.FormDirectBillExcelImport_Fill_Panel);
    this.Controls.Add((Control) this._FormDirectBillExcelImport_Toolbars_Dock_Area_Left);
    this.Controls.Add((Control) this._FormDirectBillExcelImport_Toolbars_Dock_Area_Right);
    this.Controls.Add((Control) this._FormDirectBillExcelImport_Toolbars_Dock_Area_Bottom);
    this.Controls.Add((Control) this._FormDirectBillExcelImport_Toolbars_Dock_Area_Top);
    this.Font = new Font("Tahoma", 8.25f);
    this.MinimumSize = new Size(960, 670);
    this.Name = nameof (FormDirectBillExcelImport);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Direct Bill Excel Import";
    this.Load += new EventHandler(this.FormDirectBillExcelImport_Load);
    ((Control) this.FormDirectBillExcelImport_Fill_Panel.ClientArea).ResumeLayout(false);
    ((Control) this.FormDirectBillExcelImport_Fill_Panel).ResumeLayout(false);
    ((ISupportInitialize) this.gridExcelData).EndInit();
    ((ISupportInitialize) this.ultraToolbarsManager1).EndInit();
    this.ResumeLayout(false);
  }
}
