// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.NumberingAutomation.ClaimNumberAutomationLinkingUI
// Assembly: MgaSystems.IMS.Claims, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FCD9D0B7-28CF-40B9-8EB7-297871E1AF5F
// Assembly location: F:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.Layout;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using Infragistics.Win.UltraWinToolbars;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Claims.Properties;
using MGASystems.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Claims.NumberingAutomation;

public class ClaimNumberAutomationLinkingUI : UserControl
{
  private bool _ignoreRowErrors;
  private IContainer components;
  private MGAGroupBox groupDefinedRules;
  private UltraGrid gridCurrentRules;
  private Label label2;
  private Label label1;
  private UltraDropDown dropDownLines;
  private UltraDropDown dropDownCompanyLocations;
  private UltraDropDown dropDownCompanies;
  private UltraDropDown dropDownRules;
  private BindingSource companiesBindingSource;
  private BindingSource companyLocationsBindingSource;
  private BindingSource linesBindingSource;
  private BindingSource numberingAutomationRulesBindingSource;
  private MGAButton buttonSave;
  private MGAButton buttonCancel;
  private SqlCommand sqlSelectCommand1;
  private SqlCommand sqlInsertCommand1;
  private SqlCommand sqlUpdateCommand1;
  private SqlDataAdapter daAutomationLinking;
  private SqlConnection dataConnection;
  private dsNumberingLinking dsNumberingLinking1;
  private dsNumberingLinking dsNumberingLinking;
  private UltraToolbarsManager ultraToolbarsManager1;
  private UltraToolbarsDockArea _ClaimNumberAutomationLinkingUI_Toolbars_Dock_Area_Left;
  private UltraToolbarsDockArea _ClaimNumberAutomationLinkingUI_Toolbars_Dock_Area_Right;
  private UltraToolbarsDockArea _ClaimNumberAutomationLinkingUI_Toolbars_Dock_Area_Top;
  private UltraToolbarsDockArea _ClaimNumberAutomationLinkingUI_Toolbars_Dock_Area_Bottom;
  private Label lblSaved;

  public ClaimNumberAutomationLinkingUI()
  {
    this.InitializeComponent();
    this.InitializeControl();
    this.Dock = DockStyle.Fill;
    ((Control) this.gridCurrentRules).Focus();
  }

  private string _updatedRuleName { get; set; } = string.Empty;

  private string _updatedCompanyName { get; set; } = string.Empty;

  private string _updatedCompanyLocationName { get; set; } = string.Empty;

  private string _updatedLineName { get; set; } = string.Empty;

  private string _updatedColumnName { get; set; } = string.Empty;

  private void InitializeControl()
  {
    this._ignoreRowErrors = false;
    this.UnBindControl();
    this.daAutomationLinking.UpdateCommand.Connection.ConnectionString = DefaultDatabase.ConnectionString;
    this.daAutomationLinking.InsertCommand.Connection.ConnectionString = DefaultDatabase.ConnectionString;
    using (BackgroundWorker backgroundWorker = new BackgroundWorker())
    {
      backgroundWorker.DoWork += (DoWorkEventHandler) ((sender, e) =>
      {
        this.LoadCompanies();
        this.LoadCompanyLocations();
        this.LoadLines();
        this.LoadRules();
        this.LoadLinkedRules();
        this.FormatGrid();
      });
      backgroundWorker.RunWorkerCompleted += (RunWorkerCompletedEventHandler) ((sender, e) =>
      {
        this.BindControl();
        if (this._updatedRuleName.Length > 0)
        {
          IEnumerable<UltraGridRow> source = ((IEnumerable<UltraGridRow>) ((UltraGridBase) this.gridCurrentRules).Rows).AsEnumerable<UltraGridRow>().Where<UltraGridRow>((System.Func<UltraGridRow, bool>) (rows => rows.Cells["RuleName"].Value.ToString() == this._updatedRuleName && rows.Cells["CompanyName"].Value.ToString() == this._updatedCompanyName && rows.Cells["CompanyLocationName"].Value.ToString() == this._updatedCompanyLocationName && rows.Cells["LineName"].Value.ToString() == this._updatedLineName));
          if (source.Any<UltraGridRow>())
          {
            source.First<UltraGridRow>().Cells[this._updatedColumnName].ActiveAppearance.BackColor = Color.Yellow;
            source.First<UltraGridRow>().Activate();
          }
        }
        this.lblSaved.Visible = true;
      });
      backgroundWorker.RunWorkerAsync();
    }
  }

  private void UnBindControl()
  {
    ((UltraGridBase) this.gridCurrentRules).DataSource = (object) null;
    ((UltraDropDownBase) this.dropDownRules).DisplayMember = string.Empty;
    ((UltraDropDownBase) this.dropDownRules).ValueMember = string.Empty;
    ((UltraGridBase) this.dropDownRules).DataSource = (object) null;
    ((UltraDropDownBase) this.dropDownCompanies).DisplayMember = string.Empty;
    ((UltraDropDownBase) this.dropDownCompanies).ValueMember = string.Empty;
    ((UltraGridBase) this.dropDownCompanies).DataSource = (object) null;
    ((UltraDropDownBase) this.dropDownCompanyLocations).DisplayMember = string.Empty;
    ((UltraDropDownBase) this.dropDownCompanyLocations).ValueMember = string.Empty;
    ((UltraGridBase) this.dropDownCompanyLocations).DataSource = (object) null;
    ((UltraDropDownBase) this.dropDownLines).DisplayMember = string.Empty;
    ((UltraDropDownBase) this.dropDownLines).ValueMember = string.Empty;
    ((UltraGridBase) this.dropDownLines).DataSource = (object) null;
  }

  private void BindControl()
  {
    ((UltraGridBase) this.gridCurrentRules).DataSource = (object) this.dsNumberingLinking1.LinkedRules;
    ((UltraGridBase) this.gridCurrentRules).DisplayLayout.Load(((UltraGridBase) this.gridCurrentRules).Layouts[0], (PropertyCategories) -1);
    if (((DisposableObjectCollectionBase) ((UltraGridBase) this.gridCurrentRules).Rows).Count != 0)
      ((UltraGridBase) this.gridCurrentRules).ActiveRowScrollRegion.FirstRow = ((UltraGridBase) this.gridCurrentRules).Rows[0];
    ((UltraGridBase) this.dropDownRules).DataSource = (object) this.dsNumberingLinking1.NumberingAutomationRules;
    ((UltraDropDownBase) this.dropDownRules).DisplayMember = this.dsNumberingLinking1.NumberingAutomationRules.RuleNameColumn.ColumnName;
    ((UltraDropDownBase) this.dropDownRules).ValueMember = this.dsNumberingLinking1.NumberingAutomationRules.RuleIdColumn.ColumnName;
    ((UltraGridBase) this.dropDownRules).DisplayLayout.Load(((UltraGridBase) this.dropDownRules).Layouts[0], (PropertyCategories) -1);
    ((UltraGridBase) this.dropDownCompanies).DataSource = (object) this.dsNumberingLinking1.Companies;
    ((UltraDropDownBase) this.dropDownCompanies).DisplayMember = this.dsNumberingLinking1.Companies.CompanyNameColumn.ColumnName;
    ((UltraDropDownBase) this.dropDownCompanies).ValueMember = this.dsNumberingLinking1.Companies.CompanyGuidColumn.ColumnName;
    ((UltraGridBase) this.dropDownCompanies).DisplayLayout.Load(((UltraGridBase) this.dropDownCompanies).Layouts[0], (PropertyCategories) -1);
    ((UltraGridBase) this.dropDownCompanyLocations).DataSource = (object) this.dsNumberingLinking1.CompanyLocations;
    ((UltraDropDownBase) this.dropDownCompanyLocations).DisplayMember = this.dsNumberingLinking1.CompanyLocations.CompanyLocationNameColumn.ColumnName;
    ((UltraDropDownBase) this.dropDownCompanyLocations).ValueMember = this.dsNumberingLinking1.CompanyLocations.CompanyLocationGuidColumn.ColumnName;
    ((UltraGridBase) this.dropDownCompanyLocations).DisplayLayout.Load(((UltraGridBase) this.dropDownCompanyLocations).Layouts[0], (PropertyCategories) -1);
    ((UltraGridBase) this.dropDownLines).DataSource = (object) this.dsNumberingLinking1.Lines;
    ((UltraDropDownBase) this.dropDownLines).DisplayMember = this.dsNumberingLinking1.Lines.LineNameColumn.ColumnName;
    ((UltraDropDownBase) this.dropDownLines).ValueMember = this.dsNumberingLinking1.Lines.LineGuidColumn.ColumnName;
    ((UltraGridBase) this.dropDownLines).DisplayLayout.Load(((UltraGridBase) this.dropDownLines).Layouts[0], (PropertyCategories) -1);
  }

  private void LoadCompanies()
  {
    this.dsNumberingLinking1.Companies.Clear();
    DefaultDatabase.LoadDataTable((DataTable) this.dsNumberingLinking1.Companies, "spClaims_GetCompanies");
  }

  private void LoadCompanyLocations()
  {
    this.dsNumberingLinking1.CompanyLocations.Clear();
    DefaultDatabase.LoadDataTable((DataTable) this.dsNumberingLinking1.CompanyLocations, "spClaims_GetCompanyLocations");
  }

  private void LoadLines()
  {
    this.dsNumberingLinking1.Lines.Clear();
    DefaultDatabase.LoadDataTable((DataTable) this.dsNumberingLinking1.Lines, "spClaims_GetLines");
  }

  private void LoadRules()
  {
    this.dsNumberingLinking1.NumberingAutomationRules.Clear();
    DefaultDatabase.LoadDataTable((DataTable) this.dsNumberingLinking1.NumberingAutomationRules, "spClaims_GetNumberingRulesList");
  }

  private void LoadLinkedRules()
  {
    this.dsNumberingLinking1.LinkedRules.Clear();
    DefaultDatabase.LoadDataTable((DataTable) this.dsNumberingLinking1.LinkedRules, "spClaims_GetLinkedAutomationRules");
  }

  private void ResetControl()
  {
    this.Cursor = Cursors.WaitCursor;
    try
    {
      this.InitializeControl();
    }
    finally
    {
      this.Cursor = Cursors.Default;
    }
  }

  private void ForceRowUpdate()
  {
    for (int index = ((DisposableObjectCollectionBase) ((UltraGridBase) this.gridCurrentRules).Rows).Count - 1; index >= 0; --index)
      ((UltraGridBase) this.gridCurrentRules).Rows[index].Update();
  }

  private void gridCurrentRules_InitializeTemplateAddRow(
    object sender,
    InitializeTemplateAddRowEventArgs e)
  {
    e.TemplateAddRow.Cells["EnteredByGuid"].Value = (object) CurrentUser.Instance.UserGUID;
    e.TemplateAddRow.Cells["EnteredBy"].Value = (object) CurrentUser.Instance.DisplayName;
    e.TemplateAddRow.Cells["DateEntered"].Value = (object) DateTime.Now;
    e.TemplateAddRow.Cells["Active"].Value = (object) true;
  }

  private void gridCurrentRules_AfterCellListCloseUp(object sender, CellEventArgs e)
  {
    this._updatedRuleName = e.Cell.Row.Cells["RuleName"].Text;
    this._updatedCompanyName = e.Cell.Row.Cells["CompanyName"].Text;
    this._updatedCompanyLocationName = e.Cell.Row.Cells["CompanyLocationName"].Text;
    this._updatedLineName = e.Cell.Row.Cells["LineName"].Text;
    this._updatedColumnName = e.Cell.Column.ToString();
    if (e.Cell.Column.ValueList == null || e.Cell.Column.ValueList.SelectedItemIndex == -1)
      return;
    switch (((KeyedSubObjectBase) e.Cell.Column).Key)
    {
      case "RuleName":
        e.Cell.Row.Cells[this.dsNumberingLinking1.LinkedRules.RuleIdColumn.ColumnName].Value = e.Cell.Column.ValueList.GetValue(e.Cell.Column.ValueList.SelectedItemIndex);
        this._updatedRuleName = e.Cell.Row.Cells["RuleName"].SelText;
        break;
      case "CompanyName":
        if (e.Cell.Column.ValueList.GetValue(e.Cell.Column.ValueList.SelectedItemIndex) == null)
          break;
        e.Cell.Row.Cells[this.dsNumberingLinking1.LinkedRules.CompanyGuidColumn.ColumnName].Value = e.Cell.Column.ValueList.GetValue(e.Cell.Column.ValueList.SelectedItemIndex);
        this._updatedCompanyName = e.Cell.Row.Cells["CompanyName"].SelText;
        break;
      case "CompanyLocationName":
        if (e.Cell.Column.ValueList.GetValue(e.Cell.Column.ValueList.SelectedItemIndex) == null)
          break;
        e.Cell.Row.Cells[this.dsNumberingLinking1.LinkedRules.CompanyLocationGuidColumn.ColumnName].Value = e.Cell.Column.ValueList.GetValue(e.Cell.Column.ValueList.SelectedItemIndex);
        this._updatedCompanyLocationName = e.Cell.Row.Cells["CompanyLocationName"].SelText;
        break;
      case "LineName":
        if (e.Cell.Column.ValueList.GetValue(e.Cell.Column.ValueList.SelectedItemIndex) == null)
          break;
        e.Cell.Row.Cells[this.dsNumberingLinking1.LinkedRules.LineGuidColumn.ColumnName].Value = e.Cell.Column.ValueList.GetValue(e.Cell.Column.ValueList.SelectedItemIndex);
        this._updatedLineName = e.Cell.Row.Cells["LineName"].SelText;
        break;
    }
  }

  private void gridCurrentRules_Error(object sender, ErrorEventArgs e)
  {
    if (this._ignoreRowErrors)
    {
      e.DataErrorInfo.Row.Delete();
      ((CancelEventArgs) e).Cancel = true;
    }
    else
    {
      if (!e.DataErrorInfo.ErrorText.Contains("RuleId"))
        return;
      int num = (int) MessageBox.Show(Resources.NUMAUTOMATIONLINKING_ERROR_RULE, Resources.ERROR_REQUIREDFIELD_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      ((CancelEventArgs) e).Cancel = true;
    }
  }

  private void gridCurrentRules_BeforeRowsDeleted(object sender, BeforeRowsDeletedEventArgs e)
  {
    e.DisplayPromptMsg = false;
  }

  private void buttonSave_Click(object sender, EventArgs e)
  {
    this._ignoreRowErrors = true;
    this.ForceRowUpdate();
    DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.daAutomationLinking, (DataSet) this.dsNumberingLinking1, "LinkedRules");
    this.ResetControl();
    this._ignoreRowErrors = false;
  }

  private void buttonCancel_Click(object sender, EventArgs e) => this.ResetControl();

  private void gridCurrentRules_CellDataError(object sender, CellDataErrorEventArgs e)
  {
    switch (((KeyedSubObjectBase) this.gridCurrentRules.ActiveCell.Column).Key)
    {
      case "RuleName":
        this.gridCurrentRules.ActiveCell.Value = (object) null;
        this.gridCurrentRules.ActiveCell.Row.Cells["RuleId"].SetValue((object) DBNull.Value, false);
        break;
      case "CompanyName":
        this.gridCurrentRules.ActiveCell.Value = (object) null;
        this.gridCurrentRules.ActiveCell.Row.Cells["CompanyGuid"].SetValue((object) DBNull.Value, false);
        break;
      case "CompanyLocationName":
        this.gridCurrentRules.ActiveCell.Value = (object) null;
        this.gridCurrentRules.ActiveCell.Row.Cells["CompanyLocationGuid"].SetValue((object) DBNull.Value, false);
        break;
      case "LineName":
        this.gridCurrentRules.ActiveCell.Value = (object) null;
        this.gridCurrentRules.ActiveCell.Row.Cells["LineGuid"].SetValue((object) DBNull.Value, false);
        break;
      case "EffectiveDate":
        this.gridCurrentRules.ActiveCell.Value = (object) DateTime.Now;
        break;
    }
    e.RestoreOriginalValue = false;
    e.StayInEditMode = false;
    e.RaiseErrorEvent = false;
  }

  private void ultraToolbarsManager1_ToolClick(object sender, ToolClickEventArgs e)
  {
    this.ClearHiglightedCell();
    if (!(((KeyedSubObjectBase) ((ToolEventArgs) e).Tool).Key == "DELETE"))
      return;
    this.DeleteLinking();
  }

  private void DeleteLinking()
  {
    if (((SparseCollectionBase) this.gridCurrentRules.Selected.Rows).Count == 0 || MessageBox.Show(Resources.NUMAUTOMATIONLINKING_DELETEWARNING, Resources.MESSAGEBOX_QUESTION_HEADER1, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
      return;
    this.gridCurrentRules.Selected.Rows[0].Delete();
  }

  private void ultraToolbarsManager1_BeforeToolDropdown(
    object sender,
    BeforeToolDropdownEventArgs e)
  {
    this.ClearHiglightedCell();
    object context = ((ControlUIElementBase) ((UltraGridBase) this.gridCurrentRules).DisplayLayout.UIElement).LastElementEntered.GetContext(typeof (UltraGridRow));
    if (context == null)
      return;
    ((GridItemBase) (context as UltraGridRow)).Selected = true;
    (context as UltraGridRow).Activate();
  }

  private void FormatGrid()
  {
    ((UltraGridBase) this.gridCurrentRules).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    ((UltraGridBase) this.gridCurrentRules).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 1;
  }

  private void ClearHiglightedCell()
  {
    if (this._updatedRuleName.Length <= 0)
      return;
    IEnumerable<UltraGridRow> source = ((IEnumerable<UltraGridRow>) ((UltraGridBase) this.gridCurrentRules).Rows).AsEnumerable<UltraGridRow>().Where<UltraGridRow>((System.Func<UltraGridRow, bool>) (rows => rows.Cells["RuleName"].Value.ToString() == this._updatedRuleName && rows.Cells["CompanyName"].Value.ToString() == this._updatedCompanyName && rows.Cells["CompanyLocationName"].Value.ToString() == this._updatedCompanyLocationName && rows.Cells["LineName"].Value.ToString() == this._updatedLineName));
    if (source.Any<UltraGridRow>())
      source.First<UltraGridRow>().Cells[this._updatedColumnName].ActiveAppearance.ResetBackColor();
    this.lblSaved.Visible = false;
  }

  private void gridCurrentRules_ClickCell(object sender, ClickCellEventArgs e)
  {
    this.ClearHiglightedCell();
  }

  private void gridCurrentRules_InitializeRow(object sender, InitializeRowEventArgs e)
  {
    if (this._updatedColumnName.Length <= 0)
      return;
    e.Row.Cells[this._updatedColumnName].ActiveAppearance.ResetBackColor();
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
    UltraGridBand ultraGridBand1 = new UltraGridBand("LinkedRules", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("LinkId");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("CompanyGuid");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("CompanyName", -1, (object) "dropDownCompanies");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("CompanyLocationGuid");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("CompanyLocationName", -1, (object) "dropDownCompanyLocations");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("LineGuid");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("LineName", -1, (object) "dropDownLines");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("EffectiveDate");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("DateEntered");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("EnteredByGuid");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("EnteredBy");
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("RuleId");
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("RuleName", -1, (object) "dropDownRules");
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("Active");
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    ScrollBarLook scrollBarLook1 = new ScrollBarLook();
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    UltraGridLayout ultraGridLayout1 = new UltraGridLayout("Layout1");
    Appearance appearance15 = new Appearance();
    UltraGridBand ultraGridBand2 = new UltraGridBand("LinkedRules", -1);
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("LinkId");
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("CompanyGuid");
    UltraGridColumn ultraGridColumn17 = new UltraGridColumn("CompanyName", -1, (object) "dropDownCompanies");
    UltraGridColumn ultraGridColumn18 = new UltraGridColumn("CompanyLocationGuid");
    UltraGridColumn ultraGridColumn19 = new UltraGridColumn("CompanyLocationName", -1, (object) "dropDownCompanyLocations");
    UltraGridColumn ultraGridColumn20 = new UltraGridColumn("LineGuid");
    UltraGridColumn ultraGridColumn21 = new UltraGridColumn("LineName", -1, (object) "dropDownLines");
    UltraGridColumn ultraGridColumn22 = new UltraGridColumn("EffectiveDate");
    UltraGridColumn ultraGridColumn23 = new UltraGridColumn("DateEntered");
    UltraGridColumn ultraGridColumn24 = new UltraGridColumn("EnteredByGuid");
    UltraGridColumn ultraGridColumn25 = new UltraGridColumn("EnteredBy");
    UltraGridColumn ultraGridColumn26 = new UltraGridColumn("RuleId");
    UltraGridColumn ultraGridColumn27 = new UltraGridColumn("RuleName", -1, (object) "dropDownRules");
    UltraGridColumn ultraGridColumn28 = new UltraGridColumn("Active");
    Appearance appearance16 = new Appearance();
    Appearance appearance17 = new Appearance();
    Appearance appearance18 = new Appearance();
    Appearance appearance19 = new Appearance();
    Appearance appearance20 = new Appearance();
    Appearance appearance21 = new Appearance();
    Appearance appearance22 = new Appearance();
    Appearance appearance23 = new Appearance();
    Appearance appearance24 = new Appearance();
    ScrollBarLook scrollBarLook2 = new ScrollBarLook();
    Appearance appearance25 = new Appearance();
    Appearance appearance26 = new Appearance();
    Appearance appearance27 = new Appearance();
    UltraGridBand ultraGridBand3 = new UltraGridBand("NumberingAutomationRules", -1);
    UltraGridColumn ultraGridColumn29 = new UltraGridColumn("RuleId");
    UltraGridColumn ultraGridColumn30 = new UltraGridColumn("RuleName", -1, (object) null, 0, (SortIndicator) 1, false);
    Appearance appearance28 = new Appearance();
    Appearance appearance29 = new Appearance();
    Appearance appearance30 = new Appearance();
    Appearance appearance31 = new Appearance();
    Appearance appearance32 = new Appearance();
    Appearance appearance33 = new Appearance();
    Appearance appearance34 = new Appearance();
    Appearance appearance35 = new Appearance();
    Appearance appearance36 = new Appearance();
    Appearance appearance37 = new Appearance();
    Appearance appearance38 = new Appearance();
    Appearance appearance39 = new Appearance();
    UltraGridLayout ultraGridLayout2 = new UltraGridLayout("RulesLayout");
    Appearance appearance40 = new Appearance();
    UltraGridBand ultraGridBand4 = new UltraGridBand("NumberingAutomationRules", -1);
    UltraGridColumn ultraGridColumn31 = new UltraGridColumn("RuleId");
    UltraGridColumn ultraGridColumn32 = new UltraGridColumn("RuleName", -1, (object) null, 0, (SortIndicator) 1, false);
    Appearance appearance41 = new Appearance();
    Appearance appearance42 = new Appearance();
    Appearance appearance43 = new Appearance();
    Appearance appearance44 = new Appearance();
    Appearance appearance45 = new Appearance();
    Appearance appearance46 = new Appearance();
    Appearance appearance47 = new Appearance();
    Appearance appearance48 = new Appearance();
    Appearance appearance49 = new Appearance();
    Appearance appearance50 = new Appearance();
    Appearance appearance51 = new Appearance();
    Appearance appearance52 = new Appearance();
    Appearance appearance53 = new Appearance();
    UltraGridBand ultraGridBand5 = new UltraGridBand("Companies", -1);
    UltraGridColumn ultraGridColumn33 = new UltraGridColumn("CompanyGuid");
    UltraGridColumn ultraGridColumn34 = new UltraGridColumn("CompanyName");
    Appearance appearance54 = new Appearance();
    Appearance appearance55 = new Appearance();
    Appearance appearance56 = new Appearance();
    Appearance appearance57 = new Appearance();
    Appearance appearance58 = new Appearance();
    Appearance appearance59 = new Appearance();
    Appearance appearance60 = new Appearance();
    Appearance appearance61 = new Appearance();
    Appearance appearance62 = new Appearance();
    Appearance appearance63 = new Appearance();
    Appearance appearance64 = new Appearance();
    Appearance appearance65 = new Appearance();
    UltraGridLayout ultraGridLayout3 = new UltraGridLayout("CompanyLayout");
    Appearance appearance66 = new Appearance();
    UltraGridBand ultraGridBand6 = new UltraGridBand("Companies", -1);
    UltraGridColumn ultraGridColumn35 = new UltraGridColumn("CompanyGuid");
    UltraGridColumn ultraGridColumn36 = new UltraGridColumn("CompanyName");
    Appearance appearance67 = new Appearance();
    Appearance appearance68 = new Appearance();
    Appearance appearance69 = new Appearance();
    Appearance appearance70 = new Appearance();
    Appearance appearance71 = new Appearance();
    Appearance appearance72 = new Appearance();
    Appearance appearance73 = new Appearance();
    Appearance appearance74 = new Appearance();
    Appearance appearance75 = new Appearance();
    Appearance appearance76 = new Appearance();
    Appearance appearance77 = new Appearance();
    Appearance appearance78 = new Appearance();
    Appearance appearance79 = new Appearance();
    UltraGridBand ultraGridBand7 = new UltraGridBand("CompanyLocations", -1);
    UltraGridColumn ultraGridColumn37 = new UltraGridColumn("CompanyGuid");
    UltraGridColumn ultraGridColumn38 = new UltraGridColumn("CompanyLocationGuid");
    UltraGridColumn ultraGridColumn39 = new UltraGridColumn("CompanyLocationName");
    Appearance appearance80 = new Appearance();
    Appearance appearance81 = new Appearance();
    Appearance appearance82 = new Appearance();
    Appearance appearance83 = new Appearance();
    Appearance appearance84 = new Appearance();
    Appearance appearance85 = new Appearance();
    Appearance appearance86 = new Appearance();
    Appearance appearance87 = new Appearance();
    Appearance appearance88 = new Appearance();
    Appearance appearance89 = new Appearance();
    Appearance appearance90 = new Appearance();
    Appearance appearance91 = new Appearance();
    UltraGridLayout ultraGridLayout4 = new UltraGridLayout("CompanyLocationsLayout");
    Appearance appearance92 = new Appearance();
    UltraGridBand ultraGridBand8 = new UltraGridBand("CompanyLocations", -1);
    UltraGridColumn ultraGridColumn40 = new UltraGridColumn("CompanyGuid");
    UltraGridColumn ultraGridColumn41 = new UltraGridColumn("CompanyLocationGuid");
    UltraGridColumn ultraGridColumn42 = new UltraGridColumn("CompanyLocationName");
    Appearance appearance93 = new Appearance();
    Appearance appearance94 = new Appearance();
    Appearance appearance95 = new Appearance();
    Appearance appearance96 = new Appearance();
    Appearance appearance97 = new Appearance();
    Appearance appearance98 = new Appearance();
    Appearance appearance99 = new Appearance();
    Appearance appearance100 = new Appearance();
    Appearance appearance101 = new Appearance();
    Appearance appearance102 = new Appearance();
    Appearance appearance103 = new Appearance();
    Appearance appearance104 = new Appearance();
    Appearance appearance105 = new Appearance();
    UltraGridBand ultraGridBand9 = new UltraGridBand("Lines", -1);
    UltraGridColumn ultraGridColumn43 = new UltraGridColumn("LineGuid");
    UltraGridColumn ultraGridColumn44 = new UltraGridColumn("LineName");
    Appearance appearance106 = new Appearance();
    Appearance appearance107 = new Appearance();
    Appearance appearance108 = new Appearance();
    Appearance appearance109 = new Appearance();
    Appearance appearance110 = new Appearance();
    Appearance appearance111 = new Appearance();
    Appearance appearance112 = new Appearance();
    Appearance appearance113 = new Appearance();
    Appearance appearance114 = new Appearance();
    Appearance appearance115 = new Appearance();
    Appearance appearance116 = new Appearance();
    Appearance appearance117 = new Appearance();
    UltraGridLayout ultraGridLayout5 = new UltraGridLayout("LinesLayout");
    Appearance appearance118 = new Appearance();
    UltraGridBand ultraGridBand10 = new UltraGridBand("Lines", -1);
    UltraGridColumn ultraGridColumn45 = new UltraGridColumn("LineGuid");
    UltraGridColumn ultraGridColumn46 = new UltraGridColumn("LineName");
    Appearance appearance119 = new Appearance();
    Appearance appearance120 = new Appearance();
    Appearance appearance121 = new Appearance();
    Appearance appearance122 = new Appearance();
    Appearance appearance123 = new Appearance();
    Appearance appearance124 = new Appearance();
    Appearance appearance125 = new Appearance();
    Appearance appearance126 = new Appearance();
    Appearance appearance127 = new Appearance();
    Appearance appearance128 = new Appearance();
    Appearance appearance129 = new Appearance();
    Appearance appearance130 = new Appearance();
    Appearance appearance131 = new Appearance();
    Appearance appearance132 = new Appearance();
    UltraToolbar ultraToolbar = new UltraToolbar("UltraToolbar1");
    PopupMenuTool popupMenuTool1 = new PopupMenuTool("GridContextMenu");
    PopupMenuTool popupMenuTool2 = new PopupMenuTool("GridContextMenu");
    ButtonTool buttonTool1 = new ButtonTool("DELETE");
    ButtonTool buttonTool2 = new ButtonTool("DELETE");
    Appearance appearance133 = new Appearance();
    this.groupDefinedRules = new MGAGroupBox();
    this.gridCurrentRules = new UltraGrid();
    this.dsNumberingLinking1 = new dsNumberingLinking();
    this.label2 = new Label();
    this.label1 = new Label();
    this.dropDownRules = new UltraDropDown();
    this.numberingAutomationRulesBindingSource = new BindingSource(this.components);
    this.dsNumberingLinking = new dsNumberingLinking();
    this.dropDownCompanies = new UltraDropDown();
    this.companiesBindingSource = new BindingSource(this.components);
    this.dropDownCompanyLocations = new UltraDropDown();
    this.companyLocationsBindingSource = new BindingSource(this.components);
    this.dropDownLines = new UltraDropDown();
    this.linesBindingSource = new BindingSource(this.components);
    this.buttonSave = new MGAButton();
    this.buttonCancel = new MGAButton();
    this.sqlSelectCommand1 = new SqlCommand();
    this.dataConnection = new SqlConnection();
    this.sqlInsertCommand1 = new SqlCommand();
    this.sqlUpdateCommand1 = new SqlCommand();
    this.daAutomationLinking = new SqlDataAdapter();
    this._ClaimNumberAutomationLinkingUI_Toolbars_Dock_Area_Left = new UltraToolbarsDockArea();
    this.ultraToolbarsManager1 = new UltraToolbarsManager(this.components);
    this._ClaimNumberAutomationLinkingUI_Toolbars_Dock_Area_Right = new UltraToolbarsDockArea();
    this._ClaimNumberAutomationLinkingUI_Toolbars_Dock_Area_Top = new UltraToolbarsDockArea();
    this._ClaimNumberAutomationLinkingUI_Toolbars_Dock_Area_Bottom = new UltraToolbarsDockArea();
    this.lblSaved = new Label();
    ((ISupportInitialize) this.groupDefinedRules).BeginInit();
    ((Control) this.groupDefinedRules).SuspendLayout();
    ((ISupportInitialize) this.gridCurrentRules).BeginInit();
    this.dsNumberingLinking1.BeginInit();
    ((ISupportInitialize) this.dropDownRules).BeginInit();
    ((ISupportInitialize) this.numberingAutomationRulesBindingSource).BeginInit();
    this.dsNumberingLinking.BeginInit();
    ((ISupportInitialize) this.dropDownCompanies).BeginInit();
    ((ISupportInitialize) this.companiesBindingSource).BeginInit();
    ((ISupportInitialize) this.dropDownCompanyLocations).BeginInit();
    ((ISupportInitialize) this.companyLocationsBindingSource).BeginInit();
    ((ISupportInitialize) this.dropDownLines).BeginInit();
    ((ISupportInitialize) this.linesBindingSource).BeginInit();
    ((ISupportInitialize) this.buttonSave).BeginInit();
    ((ISupportInitialize) this.buttonCancel).BeginInit();
    ((ISupportInitialize) this.ultraToolbarsManager1).BeginInit();
    this.SuspendLayout();
    ((Control) this.groupDefinedRules).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((AppearanceBase) appearance1).BackColor = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance1).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGroupBox) this.groupDefinedRules).ContentAreaAppearance = (AppearanceBase) appearance1;
    ((Control) this.groupDefinedRules).Controls.Add((Control) this.gridCurrentRules);
    ((Control) this.groupDefinedRules).ForeColor = Color.Black;
    ((AppearanceBase) appearance2).ForeColor = Color.Black;
    ((UltraGroupBox) this.groupDefinedRules).HeaderAppearance = (AppearanceBase) appearance2;
    ((Control) this.groupDefinedRules).Location = new Point(9, 59);
    ((Control) this.groupDefinedRules).Name = "groupDefinedRules";
    ((Control) this.groupDefinedRules).Size = new Size(895, 485);
    ((Control) this.groupDefinedRules).TabIndex = 7;
    ((Control) this.groupDefinedRules).Text = "Current Numbering Rules";
    ((UltraGroupBox) this.groupDefinedRules).ViewStyle = (GroupBoxViewStyle) 2;
    ((Control) this.gridCurrentRules).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.gridCurrentRules).DataMember = "LinkedRules";
    ((UltraGridBase) this.gridCurrentRules).DataSource = (object) this.dsNumberingLinking1;
    ((AppearanceBase) appearance3).BackColor = Color.White;
    ((AppearanceBase) appearance3).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridCurrentRules).DisplayLayout.Appearance = (AppearanceBase) appearance3;
    ((UltraGridBase) this.gridCurrentRules).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn1.Header).VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 29;
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn2.Header).VisiblePosition = 2;
    ultraGridColumn2.Hidden = true;
    ultraGridColumn2.Width = 65;
    ((HeaderBase) ultraGridColumn3.Header).Caption = "Company";
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn3.Header).VisiblePosition = 4;
    ultraGridColumn3.Style = (ColumnStyle) 7;
    ultraGridColumn3.Width = 153;
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn4.Header).VisiblePosition = 5;
    ultraGridColumn4.Hidden = true;
    ultraGridColumn4.Width = 71;
    ((HeaderBase) ultraGridColumn5.Header).Caption = "Company Location";
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn5.Header).VisiblePosition = 6;
    ultraGridColumn5.Style = (ColumnStyle) 7;
    ultraGridColumn5.Width = 150;
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn6.Header).VisiblePosition = 7;
    ultraGridColumn6.Hidden = true;
    ultraGridColumn6.Width = 71;
    ((HeaderBase) ultraGridColumn7.Header).Caption = "Line";
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn7.Header).VisiblePosition = 8;
    ultraGridColumn7.Style = (ColumnStyle) 7;
    ultraGridColumn7.Width = 141;
    ((HeaderBase) ultraGridColumn8.Header).Caption = "Effective";
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn8.Header).VisiblePosition = 9;
    ultraGridColumn8.Width = 81;
    ultraGridColumn9.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn9.Header).Caption = "Date Entered";
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn9.Header).VisiblePosition = 10;
    ultraGridColumn9.Width = 85;
    ((HeaderBase) ultraGridColumn10.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn10.Header).VisiblePosition = 11;
    ultraGridColumn10.Hidden = true;
    ultraGridColumn10.Width = 71;
    ultraGridColumn11.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn11.Header).Caption = "User";
    ((HeaderBase) ultraGridColumn11.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn11.Header).VisiblePosition = 12;
    ultraGridColumn11.Width = 105;
    ((HeaderBase) ultraGridColumn12.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn12.Header).VisiblePosition = 1;
    ultraGridColumn12.Hidden = true;
    ultraGridColumn12.Width = 122;
    ((HeaderBase) ultraGridColumn13.Header).Caption = "Rule";
    ((HeaderBase) ultraGridColumn13.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn13.Header).VisiblePosition = 3;
    ultraGridColumn13.Style = (ColumnStyle) 7;
    ultraGridColumn13.Width = 120;
    ((HeaderBase) ultraGridColumn14.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn14.Header).VisiblePosition = 13;
    ultraGridColumn14.Width = 47;
    ultraGridBand1.Columns.AddRange(new object[14]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4,
      (object) ultraGridColumn5,
      (object) ultraGridColumn6,
      (object) ultraGridColumn7,
      (object) ultraGridColumn8,
      (object) ultraGridColumn9,
      (object) ultraGridColumn10,
      (object) ultraGridColumn11,
      (object) ultraGridColumn12,
      (object) ultraGridColumn13,
      (object) ultraGridColumn14
    });
    ((AppearanceBase) appearance4).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridBand1.Header).Appearance = (AppearanceBase) appearance4;
    ((HeaderBase) ultraGridBand1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridBand1.Override.AllowAddNew = (AllowAddNew) 6;
    ultraGridBand1.Override.AllowColMoving = (AllowColMoving) 1;
    ultraGridBand1.Override.AllowColSizing = (AllowColSizing) 1;
    ultraGridBand1.Override.AllowColSwapping = (AllowColSwapping) 1;
    ultraGridBand1.Override.AllowDelete = (DefaultableBoolean) 2;
    ultraGridBand1.Override.AllowGroupBy = (DefaultableBoolean) 2;
    ultraGridBand1.Override.AllowGroupMoving = (AllowGroupMoving) 1;
    ultraGridBand1.Override.AllowGroupSwapping = (AllowGroupSwapping) 1;
    ultraGridBand1.Override.AllowMultiCellOperations = (AllowMultiCellOperation) 0;
    ultraGridBand1.Override.AllowRowFiltering = (DefaultableBoolean) 2;
    ultraGridBand1.Override.AllowRowLayoutCellSizing = (RowLayoutSizing) 1;
    ultraGridBand1.Override.AllowRowLayoutCellSpanSizing = (GridBagLayoutAllowSpanSizing) 1;
    ultraGridBand1.Override.AllowRowLayoutColMoving = (GridBagLayoutAllowMoving) 1;
    ultraGridBand1.Override.AllowRowLayoutLabelSizing = (RowLayoutSizing) 1;
    ultraGridBand1.Override.AllowRowLayoutLabelSpanSizing = (GridBagLayoutAllowSpanSizing) 1;
    ultraGridBand1.Override.AllowRowSummaries = (AllowRowSummaries) 2;
    ultraGridBand1.Override.AllowUpdate = (DefaultableBoolean) 1;
    ((AppearanceBase) appearance5).TextHAlignAsString = "Left";
    ultraGridBand1.Override.HeaderAppearance = (AppearanceBase) appearance5;
    ((UltraGridBase) this.gridCurrentRules).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.gridCurrentRules).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance6).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance6).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance6).ForeColor = Color.Black;
    ((UltraGridBase) this.gridCurrentRules).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance6;
    ((AppearanceBase) appearance7).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridCurrentRules).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance7;
    ((AppearanceBase) appearance8).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.gridCurrentRules).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance8;
    ((UltraGridBase) this.gridCurrentRules).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance9).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridCurrentRules).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance9;
    ((AppearanceBase) appearance10).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridCurrentRules).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance10;
    ((UltraGridBase) this.gridCurrentRules).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance11).BackColor = Color.Transparent;
    ((AppearanceBase) appearance11).ForeColor = Color.Black;
    ((UltraGridBase) this.gridCurrentRules).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance11;
    ((AppearanceBase) appearance12).BackColor = Color.LightSteelBlue;
    ((UltraGridBase) this.gridCurrentRules).DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance12;
    ((AppearanceBase) appearance13).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance13).BorderColor = Color.Silver;
    scrollBarLook1.ButtonAppearance = (AppearanceBase) appearance13;
    ((AppearanceBase) appearance14).BackColor = Color.White;
    scrollBarLook1.TrackAppearance = (AppearanceBase) appearance14;
    ((UltraGridBase) this.gridCurrentRules).DisplayLayout.ScrollBarLook = scrollBarLook1;
    ((AppearanceBase) appearance15).BackColor = Color.White;
    ((AppearanceBase) appearance15).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ultraGridLayout1.Appearance = (AppearanceBase) appearance15;
    ultraGridLayout1.AutoFitStyle = (AutoFitStyle) 1;
    ((HeaderBase) ultraGridColumn15.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn15.Header).VisiblePosition = 0;
    ultraGridColumn15.Hidden = true;
    ultraGridColumn15.Width = 29;
    ((HeaderBase) ultraGridColumn16.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn16.Header).VisiblePosition = 2;
    ultraGridColumn16.Hidden = true;
    ultraGridColumn16.Width = 65;
    ((HeaderBase) ultraGridColumn17.Header).Caption = "Company";
    ((HeaderBase) ultraGridColumn17.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn17.Header).VisiblePosition = 4;
    ultraGridColumn17.Style = (ColumnStyle) 7;
    ultraGridColumn17.Width = 153;
    ((HeaderBase) ultraGridColumn18.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn18.Header).VisiblePosition = 5;
    ultraGridColumn18.Hidden = true;
    ultraGridColumn18.Width = 71;
    ((HeaderBase) ultraGridColumn19.Header).Caption = "Company Location";
    ((HeaderBase) ultraGridColumn19.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn19.Header).VisiblePosition = 6;
    ultraGridColumn19.Style = (ColumnStyle) 7;
    ultraGridColumn19.Width = 146;
    ((HeaderBase) ultraGridColumn20.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn20.Header).VisiblePosition = 7;
    ultraGridColumn20.Hidden = true;
    ultraGridColumn20.Width = 71;
    ((HeaderBase) ultraGridColumn21.Header).Caption = "Line";
    ((HeaderBase) ultraGridColumn21.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn21.Header).VisiblePosition = 8;
    ultraGridColumn21.Style = (ColumnStyle) 7;
    ultraGridColumn21.Width = 137;
    ((HeaderBase) ultraGridColumn22.Header).Caption = "Effective";
    ((HeaderBase) ultraGridColumn22.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn22.Header).VisiblePosition = 9;
    ultraGridColumn22.Width = 83;
    ultraGridColumn23.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn23.Header).Caption = "Date Entered";
    ((HeaderBase) ultraGridColumn23.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn23.Header).VisiblePosition = 10;
    ultraGridColumn23.Width = 86;
    ((HeaderBase) ultraGridColumn24.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn24.Header).VisiblePosition = 11;
    ultraGridColumn24.Hidden = true;
    ultraGridColumn24.Width = 71;
    ultraGridColumn25.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn25.Header).Caption = "User";
    ((HeaderBase) ultraGridColumn25.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn25.Header).VisiblePosition = 12;
    ultraGridColumn25.Width = 107;
    ((HeaderBase) ultraGridColumn26.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn26.Header).VisiblePosition = 1;
    ultraGridColumn26.Hidden = true;
    ultraGridColumn26.Width = 122;
    ((HeaderBase) ultraGridColumn27.Header).Caption = "Rule";
    ((HeaderBase) ultraGridColumn27.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn27.Header).VisiblePosition = 3;
    ultraGridColumn27.Style = (ColumnStyle) 7;
    ultraGridColumn27.Width = 124;
    ((HeaderBase) ultraGridColumn28.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn28.Header).VisiblePosition = 13;
    ultraGridColumn28.Width = 46;
    ultraGridBand2.Columns.AddRange(new object[14]
    {
      (object) ultraGridColumn15,
      (object) ultraGridColumn16,
      (object) ultraGridColumn17,
      (object) ultraGridColumn18,
      (object) ultraGridColumn19,
      (object) ultraGridColumn20,
      (object) ultraGridColumn21,
      (object) ultraGridColumn22,
      (object) ultraGridColumn23,
      (object) ultraGridColumn24,
      (object) ultraGridColumn25,
      (object) ultraGridColumn26,
      (object) ultraGridColumn27,
      (object) ultraGridColumn28
    });
    ((AppearanceBase) appearance16).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridBand2.Header).Appearance = (AppearanceBase) appearance16;
    ((HeaderBase) ultraGridBand2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridBand2.Override.AllowAddNew = (AllowAddNew) 6;
    ((AppearanceBase) appearance17).TextHAlignAsString = "Left";
    ultraGridBand2.Override.HeaderAppearance = (AppearanceBase) appearance17;
    ultraGridLayout1.BandsSerializer.Add((object) ultraGridBand2);
    ultraGridLayout1.BorderStyle = (UIElementBorderStyle) 4;
    ((KeyedSubObjectBase) ultraGridLayout1).Key = "Layout1";
    ((AppearanceBase) appearance18).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance18).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance18).ForeColor = Color.Black;
    ultraGridLayout1.Override.ActiveRowAppearance = (AppearanceBase) appearance18;
    ultraGridLayout1.Override.AllowAddNew = (AllowAddNew) 5;
    ultraGridLayout1.Override.AllowColMoving = (AllowColMoving) 1;
    ultraGridLayout1.Override.AllowColSizing = (AllowColSizing) 3;
    ultraGridLayout1.Override.AllowColSwapping = (AllowColSwapping) 1;
    ultraGridLayout1.Override.AllowDelete = (DefaultableBoolean) 2;
    ultraGridLayout1.Override.AllowGroupBy = (DefaultableBoolean) 2;
    ultraGridLayout1.Override.AllowGroupMoving = (AllowGroupMoving) 1;
    ultraGridLayout1.Override.AllowGroupSwapping = (AllowGroupSwapping) 1;
    ultraGridLayout1.Override.AllowMultiCellOperations = (AllowMultiCellOperation) 0;
    ultraGridLayout1.Override.AllowRowFiltering = (DefaultableBoolean) 2;
    ultraGridLayout1.Override.AllowRowLayoutCellSizing = (RowLayoutSizing) 1;
    ultraGridLayout1.Override.AllowRowLayoutCellSpanSizing = (GridBagLayoutAllowSpanSizing) 1;
    ultraGridLayout1.Override.AllowRowLayoutColMoving = (GridBagLayoutAllowMoving) 1;
    ultraGridLayout1.Override.AllowRowLayoutLabelSizing = (RowLayoutSizing) 1;
    ultraGridLayout1.Override.AllowRowLayoutLabelSpanSizing = (GridBagLayoutAllowSpanSizing) 1;
    ultraGridLayout1.Override.AllowRowSummaries = (AllowRowSummaries) 2;
    ultraGridLayout1.Override.AllowUpdate = (DefaultableBoolean) 1;
    ((AppearanceBase) appearance19).BorderColor = Color.LightGray;
    ultraGridLayout1.Override.CellAppearance = (AppearanceBase) appearance19;
    ((AppearanceBase) appearance20).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ultraGridLayout1.Override.HeaderAppearance = (AppearanceBase) appearance20;
    ultraGridLayout1.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance21).BackColor = Color.FromArgb(246, 250, 253);
    ultraGridLayout1.Override.RowAlternateAppearance = (AppearanceBase) appearance21;
    ((AppearanceBase) appearance22).BorderColor = Color.LightGray;
    ultraGridLayout1.Override.RowAppearance = (AppearanceBase) appearance22;
    ultraGridLayout1.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance23).BackColor = Color.Transparent;
    ((AppearanceBase) appearance23).ForeColor = Color.Black;
    ultraGridLayout1.Override.SelectedRowAppearance = (AppearanceBase) appearance23;
    ((AppearanceBase) appearance24).BackColor = Color.LightSteelBlue;
    ultraGridLayout1.Override.TemplateAddRowAppearance = (AppearanceBase) appearance24;
    ((AppearanceBase) appearance25).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance25).BorderColor = Color.Silver;
    scrollBarLook2.ButtonAppearance = (AppearanceBase) appearance25;
    ((AppearanceBase) appearance26).BackColor = Color.White;
    scrollBarLook2.TrackAppearance = (AppearanceBase) appearance26;
    ultraGridLayout1.ScrollBarLook = scrollBarLook2;
    ((UltraGridBase) this.gridCurrentRules).Layouts.Add(ultraGridLayout1);
    ((Control) this.gridCurrentRules).Location = new Point(6, 24);
    ((Control) this.gridCurrentRules).Name = "gridCurrentRules";
    ((Control) this.gridCurrentRules).Size = new Size(884, 456);
    ((Control) this.gridCurrentRules).TabIndex = 0;
    this.gridCurrentRules.UpdateMode = (UpdateMode) 1;
    ((UltraControlBase) this.gridCurrentRules).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridCurrentRules).UseOsThemes = (DefaultableBoolean) 2;
    this.gridCurrentRules.InitializeRow += new InitializeRowEventHandler(this.gridCurrentRules_InitializeRow);
    this.gridCurrentRules.InitializeTemplateAddRow += new InitializeTemplateAddRowEventHandler(this.gridCurrentRules_InitializeTemplateAddRow);
    this.gridCurrentRules.AfterCellListCloseUp += new CellEventHandler(this.gridCurrentRules_AfterCellListCloseUp);
    this.gridCurrentRules.BeforeRowsDeleted += new BeforeRowsDeletedEventHandler(this.gridCurrentRules_BeforeRowsDeleted);
    this.gridCurrentRules.Error += new ErrorEventHandler(this.gridCurrentRules_Error);
    this.gridCurrentRules.CellDataError += new CellDataErrorEventHandler(this.gridCurrentRules_CellDataError);
    this.gridCurrentRules.ClickCell += new ClickCellEventHandler(this.gridCurrentRules_ClickCell);
    this.dsNumberingLinking1.DataSetName = "dsNumberingLinking";
    this.dsNumberingLinking1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.label2.BackColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.label2.ForeColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.label2.Location = new Point(15, 41);
    this.label2.Name = "label2";
    this.label2.Size = new Size(882, 1);
    this.label2.TabIndex = 5;
    this.label2.Text = "label2";
    this.label1.AutoSize = true;
    this.label1.BackColor = Color.Transparent;
    this.label1.Font = new Font("Tahoma", 20.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.label1.ForeColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.label1.Location = new Point(3, 9);
    this.label1.Name = "label1";
    this.label1.Size = new Size(419, 33);
    this.label1.TabIndex = 4;
    this.label1.Text = "Claim Number Automation Linking";
    ((UltraGridBase) this.dropDownRules).DataSource = (object) this.numberingAutomationRulesBindingSource;
    ((AppearanceBase) appearance27).BackColor = SystemColors.Window;
    ((AppearanceBase) appearance27).BorderColor = SystemColors.InactiveCaption;
    ((UltraGridBase) this.dropDownRules).DisplayLayout.Appearance = (AppearanceBase) appearance27;
    ((UltraGridBase) this.dropDownRules).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand3.ColHeadersVisible = false;
    ((HeaderBase) ultraGridColumn29.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn29.Header).VisiblePosition = 0;
    ultraGridColumn29.Hidden = true;
    ((HeaderBase) ultraGridColumn30.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn30.Header).Enabled = false;
    ((HeaderBase) ultraGridColumn30.Header).VisiblePosition = 1;
    ultraGridColumn30.ProportionalResize = true;
    ultraGridColumn30.Width = 231;
    ultraGridBand3.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn29,
      (object) ultraGridColumn30
    });
    ((UltraGridBase) this.dropDownRules).DisplayLayout.BandsSerializer.Add((object) ultraGridBand3);
    ((UltraGridBase) this.dropDownRules).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.dropDownRules).DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance28).BackColor = SystemColors.ActiveBorder;
    ((AppearanceBase) appearance28).BackColor2 = SystemColors.ControlDark;
    ((AppearanceBase) appearance28).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance28).BorderColor = SystemColors.Window;
    ((SpecialBoxBase) ((UltraGridBase) this.dropDownRules).DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance28;
    ((AppearanceBase) appearance29).ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.dropDownRules).DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance29;
    ((SpecialBoxBase) ((UltraGridBase) this.dropDownRules).DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance30).BackColor = SystemColors.ControlLightLight;
    ((AppearanceBase) appearance30).BackColor2 = SystemColors.Control;
    ((AppearanceBase) appearance30).BackGradientStyle = (GradientStyle) 3;
    ((AppearanceBase) appearance30).ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.dropDownRules).DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance30;
    ((UltraGridBase) this.dropDownRules).DisplayLayout.MaxColScrollRegions = 1;
    ((UltraGridBase) this.dropDownRules).DisplayLayout.MaxRowScrollRegions = 1;
    ((AppearanceBase) appearance31).BackColor = SystemColors.Window;
    ((AppearanceBase) appearance31).ForeColor = SystemColors.ControlText;
    ((UltraGridBase) this.dropDownRules).DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance31;
    ((AppearanceBase) appearance32).BackColor = SystemColors.Highlight;
    ((AppearanceBase) appearance32).ForeColor = SystemColors.HighlightText;
    ((UltraGridBase) this.dropDownRules).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance32;
    ((UltraGridBase) this.dropDownRules).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 2;
    ((UltraGridBase) this.dropDownRules).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 2;
    ((AppearanceBase) appearance33).BackColor = SystemColors.Window;
    ((UltraGridBase) this.dropDownRules).DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance33;
    ((AppearanceBase) appearance34).BorderColor = Color.Silver;
    ((AppearanceBase) appearance34).TextTrimming = (TextTrimming) 3;
    ((UltraGridBase) this.dropDownRules).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance34;
    ((UltraGridBase) this.dropDownRules).DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    ((UltraGridBase) this.dropDownRules).DisplayLayout.Override.CellPadding = 0;
    ((AppearanceBase) appearance35).BackColor = SystemColors.Control;
    ((AppearanceBase) appearance35).BackColor2 = SystemColors.ControlDark;
    ((AppearanceBase) appearance35).BackGradientAlignment = (GradientAlignment) 1;
    ((AppearanceBase) appearance35).BackGradientStyle = (GradientStyle) 3;
    ((AppearanceBase) appearance35).BorderColor = SystemColors.Window;
    ((UltraGridBase) this.dropDownRules).DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance35;
    ((AppearanceBase) appearance36).TextHAlignAsString = "Left";
    ((UltraGridBase) this.dropDownRules).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance36;
    ((UltraGridBase) this.dropDownRules).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    ((AppearanceBase) appearance37).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.dropDownRules).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance37;
    ((AppearanceBase) appearance38).BackColor = SystemColors.Window;
    ((AppearanceBase) appearance38).BorderColor = Color.Silver;
    ((UltraGridBase) this.dropDownRules).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance38;
    ((UltraGridBase) this.dropDownRules).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance39).BackColor = SystemColors.ControlLight;
    ((UltraGridBase) this.dropDownRules).DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance39;
    ((UltraGridBase) this.dropDownRules).DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    ((UltraGridBase) this.dropDownRules).DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    ((UltraGridBase) this.dropDownRules).DisplayLayout.ViewStyleBand = (ViewStyleBand) 2;
    ((AppearanceBase) appearance40).BackColor = SystemColors.Window;
    ((AppearanceBase) appearance40).BorderColor = SystemColors.InactiveCaption;
    ultraGridLayout2.Appearance = (AppearanceBase) appearance40;
    ultraGridLayout2.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand4.ColHeadersVisible = false;
    ((HeaderBase) ultraGridColumn31.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn31.Header).VisiblePosition = 0;
    ultraGridColumn31.Hidden = true;
    ((HeaderBase) ultraGridColumn32.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn32.Header).Enabled = false;
    ((HeaderBase) ultraGridColumn32.Header).VisiblePosition = 1;
    ultraGridColumn32.ProportionalResize = true;
    ultraGridColumn32.Width = 231;
    ultraGridBand4.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn31,
      (object) ultraGridColumn32
    });
    ultraGridLayout2.BandsSerializer.Add((object) ultraGridBand4);
    ultraGridLayout2.BorderStyle = (UIElementBorderStyle) 4;
    ultraGridLayout2.CaptionVisible = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance41).BackColor = SystemColors.ActiveBorder;
    ((AppearanceBase) appearance41).BackColor2 = SystemColors.ControlDark;
    ((AppearanceBase) appearance41).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance41).BorderColor = SystemColors.Window;
    ((SpecialBoxBase) ultraGridLayout2.GroupByBox).Appearance = (AppearanceBase) appearance41;
    ((AppearanceBase) appearance42).ForeColor = SystemColors.GrayText;
    ultraGridLayout2.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance42;
    ((SpecialBoxBase) ultraGridLayout2.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance43).BackColor = SystemColors.ControlLightLight;
    ((AppearanceBase) appearance43).BackColor2 = SystemColors.Control;
    ((AppearanceBase) appearance43).BackGradientStyle = (GradientStyle) 3;
    ((AppearanceBase) appearance43).ForeColor = SystemColors.GrayText;
    ultraGridLayout2.GroupByBox.PromptAppearance = (AppearanceBase) appearance43;
    ((KeyedSubObjectBase) ultraGridLayout2).Key = "RulesLayout";
    ultraGridLayout2.MaxColScrollRegions = 1;
    ultraGridLayout2.MaxRowScrollRegions = 1;
    ((AppearanceBase) appearance44).BackColor = SystemColors.Window;
    ((AppearanceBase) appearance44).ForeColor = SystemColors.ControlText;
    ultraGridLayout2.Override.ActiveCellAppearance = (AppearanceBase) appearance44;
    ((AppearanceBase) appearance45).BackColor = SystemColors.Highlight;
    ((AppearanceBase) appearance45).ForeColor = SystemColors.HighlightText;
    ultraGridLayout2.Override.ActiveRowAppearance = (AppearanceBase) appearance45;
    ultraGridLayout2.Override.BorderStyleCell = (UIElementBorderStyle) 2;
    ultraGridLayout2.Override.BorderStyleRow = (UIElementBorderStyle) 2;
    ((AppearanceBase) appearance46).BackColor = SystemColors.Window;
    ultraGridLayout2.Override.CardAreaAppearance = (AppearanceBase) appearance46;
    ((AppearanceBase) appearance47).BorderColor = Color.Silver;
    ((AppearanceBase) appearance47).TextTrimming = (TextTrimming) 3;
    ultraGridLayout2.Override.CellAppearance = (AppearanceBase) appearance47;
    ultraGridLayout2.Override.CellClickAction = (CellClickAction) 4;
    ultraGridLayout2.Override.CellPadding = 0;
    ((AppearanceBase) appearance48).BackColor = SystemColors.Control;
    ((AppearanceBase) appearance48).BackColor2 = SystemColors.ControlDark;
    ((AppearanceBase) appearance48).BackGradientAlignment = (GradientAlignment) 1;
    ((AppearanceBase) appearance48).BackGradientStyle = (GradientStyle) 3;
    ((AppearanceBase) appearance48).BorderColor = SystemColors.Window;
    ultraGridLayout2.Override.GroupByRowAppearance = (AppearanceBase) appearance48;
    ((AppearanceBase) appearance49).TextHAlignAsString = "Left";
    ultraGridLayout2.Override.HeaderAppearance = (AppearanceBase) appearance49;
    ultraGridLayout2.Override.HeaderClickAction = (HeaderClickAction) 3;
    ((AppearanceBase) appearance50).BackColor = Color.FromArgb(246, 250, 253);
    ultraGridLayout2.Override.RowAlternateAppearance = (AppearanceBase) appearance50;
    ((AppearanceBase) appearance51).BackColor = SystemColors.Window;
    ((AppearanceBase) appearance51).BorderColor = Color.Silver;
    ultraGridLayout2.Override.RowAppearance = (AppearanceBase) appearance51;
    ultraGridLayout2.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance52).BackColor = SystemColors.ControlLight;
    ultraGridLayout2.Override.TemplateAddRowAppearance = (AppearanceBase) appearance52;
    ultraGridLayout2.ScrollBounds = (ScrollBounds) 0;
    ultraGridLayout2.ScrollStyle = (ScrollStyle) 1;
    ultraGridLayout2.ViewStyleBand = (ViewStyleBand) 2;
    ((UltraGridBase) this.dropDownRules).Layouts.Add(ultraGridLayout2);
    ((Control) this.dropDownRules).Location = new Point(59, 588);
    ((Control) this.dropDownRules).Name = "dropDownRules";
    ((Control) this.dropDownRules).Size = new Size(233, 80 /*0x50*/);
    ((Control) this.dropDownRules).TabIndex = 1;
    ((Control) this.dropDownRules).Text = "ultraDropDown1";
    ((Control) this.dropDownRules).Visible = false;
    this.numberingAutomationRulesBindingSource.DataMember = "NumberingAutomationRules";
    this.numberingAutomationRulesBindingSource.DataSource = (object) this.dsNumberingLinking;
    this.dsNumberingLinking.DataSetName = "dsNumberingLinking";
    this.dsNumberingLinking.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((UltraGridBase) this.dropDownCompanies).DataSource = (object) this.companiesBindingSource;
    ((AppearanceBase) appearance53).BackColor = SystemColors.Window;
    ((AppearanceBase) appearance53).BorderColor = SystemColors.InactiveCaption;
    ((UltraGridBase) this.dropDownCompanies).DisplayLayout.Appearance = (AppearanceBase) appearance53;
    ((UltraGridBase) this.dropDownCompanies).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand5.ColHeadersVisible = false;
    ((HeaderBase) ultraGridColumn33.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn33.Header).VisiblePosition = 0;
    ultraGridColumn33.Hidden = true;
    ((HeaderBase) ultraGridColumn34.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn34.Header).VisiblePosition = 1;
    ultraGridColumn34.Width = 268;
    ultraGridBand5.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn33,
      (object) ultraGridColumn34
    });
    ((UltraGridBase) this.dropDownCompanies).DisplayLayout.BandsSerializer.Add((object) ultraGridBand5);
    ((UltraGridBase) this.dropDownCompanies).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.dropDownCompanies).DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance54).BackColor = SystemColors.ActiveBorder;
    ((AppearanceBase) appearance54).BackColor2 = SystemColors.ControlDark;
    ((AppearanceBase) appearance54).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance54).BorderColor = SystemColors.Window;
    ((SpecialBoxBase) ((UltraGridBase) this.dropDownCompanies).DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance54;
    ((AppearanceBase) appearance55).ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.dropDownCompanies).DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance55;
    ((SpecialBoxBase) ((UltraGridBase) this.dropDownCompanies).DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance56).BackColor = SystemColors.ControlLightLight;
    ((AppearanceBase) appearance56).BackColor2 = SystemColors.Control;
    ((AppearanceBase) appearance56).BackGradientStyle = (GradientStyle) 3;
    ((AppearanceBase) appearance56).ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.dropDownCompanies).DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance56;
    ((UltraGridBase) this.dropDownCompanies).DisplayLayout.MaxColScrollRegions = 1;
    ((UltraGridBase) this.dropDownCompanies).DisplayLayout.MaxRowScrollRegions = 1;
    ((AppearanceBase) appearance57).BackColor = SystemColors.Window;
    ((AppearanceBase) appearance57).ForeColor = SystemColors.ControlText;
    ((UltraGridBase) this.dropDownCompanies).DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance57;
    ((AppearanceBase) appearance58).BackColor = SystemColors.Highlight;
    ((AppearanceBase) appearance58).ForeColor = SystemColors.HighlightText;
    ((UltraGridBase) this.dropDownCompanies).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance58;
    ((UltraGridBase) this.dropDownCompanies).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 2;
    ((UltraGridBase) this.dropDownCompanies).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 2;
    ((AppearanceBase) appearance59).BackColor = SystemColors.Window;
    ((UltraGridBase) this.dropDownCompanies).DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance59;
    ((AppearanceBase) appearance60).BorderColor = Color.Silver;
    ((AppearanceBase) appearance60).TextTrimming = (TextTrimming) 3;
    ((UltraGridBase) this.dropDownCompanies).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance60;
    ((UltraGridBase) this.dropDownCompanies).DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    ((UltraGridBase) this.dropDownCompanies).DisplayLayout.Override.CellPadding = 0;
    ((AppearanceBase) appearance61).BackColor = SystemColors.Control;
    ((AppearanceBase) appearance61).BackColor2 = SystemColors.ControlDark;
    ((AppearanceBase) appearance61).BackGradientAlignment = (GradientAlignment) 1;
    ((AppearanceBase) appearance61).BackGradientStyle = (GradientStyle) 3;
    ((AppearanceBase) appearance61).BorderColor = SystemColors.Window;
    ((UltraGridBase) this.dropDownCompanies).DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance61;
    ((AppearanceBase) appearance62).TextHAlignAsString = "Left";
    ((UltraGridBase) this.dropDownCompanies).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance62;
    ((UltraGridBase) this.dropDownCompanies).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    ((UltraGridBase) this.dropDownCompanies).DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    ((AppearanceBase) appearance63).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.dropDownCompanies).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance63;
    ((AppearanceBase) appearance64).BackColor = Color.White;
    ((AppearanceBase) appearance64).BorderColor = Color.Silver;
    ((UltraGridBase) this.dropDownCompanies).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance64;
    ((UltraGridBase) this.dropDownCompanies).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance65).BackColor = SystemColors.ControlLight;
    ((UltraGridBase) this.dropDownCompanies).DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance65;
    ((UltraGridBase) this.dropDownCompanies).DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    ((UltraGridBase) this.dropDownCompanies).DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    ((UltraGridBase) this.dropDownCompanies).DisplayLayout.ViewStyleBand = (ViewStyleBand) 2;
    ((AppearanceBase) appearance66).BackColor = SystemColors.Window;
    ((AppearanceBase) appearance66).BorderColor = SystemColors.InactiveCaption;
    ultraGridLayout3.Appearance = (AppearanceBase) appearance66;
    ultraGridLayout3.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand6.ColHeadersVisible = false;
    ((HeaderBase) ultraGridColumn35.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn35.Header).VisiblePosition = 0;
    ultraGridColumn35.Hidden = true;
    ((HeaderBase) ultraGridColumn36.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn36.Header).VisiblePosition = 1;
    ultraGridColumn36.Width = 268;
    ultraGridBand6.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn35,
      (object) ultraGridColumn36
    });
    ultraGridLayout3.BandsSerializer.Add((object) ultraGridBand6);
    ultraGridLayout3.BorderStyle = (UIElementBorderStyle) 4;
    ultraGridLayout3.CaptionVisible = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance67).BackColor = SystemColors.ActiveBorder;
    ((AppearanceBase) appearance67).BackColor2 = SystemColors.ControlDark;
    ((AppearanceBase) appearance67).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance67).BorderColor = SystemColors.Window;
    ((SpecialBoxBase) ultraGridLayout3.GroupByBox).Appearance = (AppearanceBase) appearance67;
    ((AppearanceBase) appearance68).ForeColor = SystemColors.GrayText;
    ultraGridLayout3.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance68;
    ((SpecialBoxBase) ultraGridLayout3.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance69).BackColor = SystemColors.ControlLightLight;
    ((AppearanceBase) appearance69).BackColor2 = SystemColors.Control;
    ((AppearanceBase) appearance69).BackGradientStyle = (GradientStyle) 3;
    ((AppearanceBase) appearance69).ForeColor = SystemColors.GrayText;
    ultraGridLayout3.GroupByBox.PromptAppearance = (AppearanceBase) appearance69;
    ((KeyedSubObjectBase) ultraGridLayout3).Key = "CompanyLayout";
    ultraGridLayout3.MaxColScrollRegions = 1;
    ultraGridLayout3.MaxRowScrollRegions = 1;
    ((AppearanceBase) appearance70).BackColor = SystemColors.Window;
    ((AppearanceBase) appearance70).ForeColor = SystemColors.ControlText;
    ultraGridLayout3.Override.ActiveCellAppearance = (AppearanceBase) appearance70;
    ((AppearanceBase) appearance71).BackColor = SystemColors.Highlight;
    ((AppearanceBase) appearance71).ForeColor = SystemColors.HighlightText;
    ultraGridLayout3.Override.ActiveRowAppearance = (AppearanceBase) appearance71;
    ultraGridLayout3.Override.BorderStyleCell = (UIElementBorderStyle) 2;
    ultraGridLayout3.Override.BorderStyleRow = (UIElementBorderStyle) 2;
    ((AppearanceBase) appearance72).BackColor = SystemColors.Window;
    ultraGridLayout3.Override.CardAreaAppearance = (AppearanceBase) appearance72;
    ((AppearanceBase) appearance73).BorderColor = Color.Silver;
    ((AppearanceBase) appearance73).TextTrimming = (TextTrimming) 3;
    ultraGridLayout3.Override.CellAppearance = (AppearanceBase) appearance73;
    ultraGridLayout3.Override.CellClickAction = (CellClickAction) 4;
    ultraGridLayout3.Override.CellPadding = 0;
    ((AppearanceBase) appearance74).BackColor = SystemColors.Control;
    ((AppearanceBase) appearance74).BackColor2 = SystemColors.ControlDark;
    ((AppearanceBase) appearance74).BackGradientAlignment = (GradientAlignment) 1;
    ((AppearanceBase) appearance74).BackGradientStyle = (GradientStyle) 3;
    ((AppearanceBase) appearance74).BorderColor = SystemColors.Window;
    ultraGridLayout3.Override.GroupByRowAppearance = (AppearanceBase) appearance74;
    ((AppearanceBase) appearance75).TextHAlignAsString = "Left";
    ultraGridLayout3.Override.HeaderAppearance = (AppearanceBase) appearance75;
    ultraGridLayout3.Override.HeaderClickAction = (HeaderClickAction) 3;
    ultraGridLayout3.Override.HeaderStyle = (HeaderStyle) 2;
    ((AppearanceBase) appearance76).BackColor = Color.FromArgb(246, 250, 253);
    ultraGridLayout3.Override.RowAlternateAppearance = (AppearanceBase) appearance76;
    ((AppearanceBase) appearance77).BackColor = Color.White;
    ((AppearanceBase) appearance77).BorderColor = Color.Silver;
    ultraGridLayout3.Override.RowAppearance = (AppearanceBase) appearance77;
    ultraGridLayout3.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance78).BackColor = SystemColors.ControlLight;
    ultraGridLayout3.Override.TemplateAddRowAppearance = (AppearanceBase) appearance78;
    ultraGridLayout3.ScrollBounds = (ScrollBounds) 0;
    ultraGridLayout3.ScrollStyle = (ScrollStyle) 1;
    ultraGridLayout3.ViewStyleBand = (ViewStyleBand) 2;
    ((UltraGridBase) this.dropDownCompanies).Layouts.Add(ultraGridLayout3);
    ((Control) this.dropDownCompanies).Location = new Point(248, 588);
    ((Control) this.dropDownCompanies).Name = "dropDownCompanies";
    ((Control) this.dropDownCompanies).Size = new Size(270, 80 /*0x50*/);
    ((Control) this.dropDownCompanies).TabIndex = 2;
    ((Control) this.dropDownCompanies).Text = "ultraDropDown2";
    ((Control) this.dropDownCompanies).Visible = false;
    this.companiesBindingSource.DataMember = "Companies";
    this.companiesBindingSource.DataSource = (object) this.dsNumberingLinking;
    ((UltraGridBase) this.dropDownCompanyLocations).DataSource = (object) this.companyLocationsBindingSource;
    ((AppearanceBase) appearance79).BackColor = SystemColors.Window;
    ((AppearanceBase) appearance79).BorderColor = SystemColors.InactiveCaption;
    ((UltraGridBase) this.dropDownCompanyLocations).DisplayLayout.Appearance = (AppearanceBase) appearance79;
    ((UltraGridBase) this.dropDownCompanyLocations).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand7.ColHeadersVisible = false;
    ((HeaderBase) ultraGridColumn37.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn37.Header).VisiblePosition = 0;
    ultraGridColumn37.Hidden = true;
    ((HeaderBase) ultraGridColumn38.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn38.Header).VisiblePosition = 1;
    ultraGridColumn38.Hidden = true;
    ((HeaderBase) ultraGridColumn39.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn39.Header).VisiblePosition = 2;
    ultraGridColumn39.Width = 240 /*0xF0*/;
    ultraGridBand7.Columns.AddRange(new object[3]
    {
      (object) ultraGridColumn37,
      (object) ultraGridColumn38,
      (object) ultraGridColumn39
    });
    ((UltraGridBase) this.dropDownCompanyLocations).DisplayLayout.BandsSerializer.Add((object) ultraGridBand7);
    ((UltraGridBase) this.dropDownCompanyLocations).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.dropDownCompanyLocations).DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance80).BackColor = SystemColors.ActiveBorder;
    ((AppearanceBase) appearance80).BackColor2 = SystemColors.ControlDark;
    ((AppearanceBase) appearance80).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance80).BorderColor = SystemColors.Window;
    ((SpecialBoxBase) ((UltraGridBase) this.dropDownCompanyLocations).DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance80;
    ((AppearanceBase) appearance81).ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.dropDownCompanyLocations).DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance81;
    ((SpecialBoxBase) ((UltraGridBase) this.dropDownCompanyLocations).DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance82).BackColor = SystemColors.ControlLightLight;
    ((AppearanceBase) appearance82).BackColor2 = SystemColors.Control;
    ((AppearanceBase) appearance82).BackGradientStyle = (GradientStyle) 3;
    ((AppearanceBase) appearance82).ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.dropDownCompanyLocations).DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance82;
    ((UltraGridBase) this.dropDownCompanyLocations).DisplayLayout.MaxColScrollRegions = 1;
    ((UltraGridBase) this.dropDownCompanyLocations).DisplayLayout.MaxRowScrollRegions = 1;
    ((AppearanceBase) appearance83).BackColor = SystemColors.Window;
    ((AppearanceBase) appearance83).ForeColor = SystemColors.ControlText;
    ((UltraGridBase) this.dropDownCompanyLocations).DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance83;
    ((AppearanceBase) appearance84).BackColor = SystemColors.Highlight;
    ((AppearanceBase) appearance84).ForeColor = SystemColors.HighlightText;
    ((UltraGridBase) this.dropDownCompanyLocations).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance84;
    ((UltraGridBase) this.dropDownCompanyLocations).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 2;
    ((UltraGridBase) this.dropDownCompanyLocations).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 2;
    ((AppearanceBase) appearance85).BackColor = SystemColors.Window;
    ((UltraGridBase) this.dropDownCompanyLocations).DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance85;
    ((AppearanceBase) appearance86).BorderColor = Color.Silver;
    ((AppearanceBase) appearance86).TextTrimming = (TextTrimming) 3;
    ((UltraGridBase) this.dropDownCompanyLocations).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance86;
    ((UltraGridBase) this.dropDownCompanyLocations).DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    ((UltraGridBase) this.dropDownCompanyLocations).DisplayLayout.Override.CellPadding = 0;
    ((AppearanceBase) appearance87).BackColor = SystemColors.Control;
    ((AppearanceBase) appearance87).BackColor2 = SystemColors.ControlDark;
    ((AppearanceBase) appearance87).BackGradientAlignment = (GradientAlignment) 1;
    ((AppearanceBase) appearance87).BackGradientStyle = (GradientStyle) 3;
    ((AppearanceBase) appearance87).BorderColor = SystemColors.Window;
    ((UltraGridBase) this.dropDownCompanyLocations).DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance87;
    ((AppearanceBase) appearance88).TextHAlignAsString = "Left";
    ((UltraGridBase) this.dropDownCompanyLocations).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance88;
    ((UltraGridBase) this.dropDownCompanyLocations).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    ((UltraGridBase) this.dropDownCompanyLocations).DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    ((AppearanceBase) appearance89).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.dropDownCompanyLocations).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance89;
    ((AppearanceBase) appearance90).BackColor = Color.White;
    ((AppearanceBase) appearance90).BorderColor = Color.Silver;
    ((UltraGridBase) this.dropDownCompanyLocations).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance90;
    ((UltraGridBase) this.dropDownCompanyLocations).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance91).BackColor = SystemColors.ControlLight;
    ((UltraGridBase) this.dropDownCompanyLocations).DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance91;
    ((UltraGridBase) this.dropDownCompanyLocations).DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    ((UltraGridBase) this.dropDownCompanyLocations).DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    ((UltraGridBase) this.dropDownCompanyLocations).DisplayLayout.ViewStyleBand = (ViewStyleBand) 2;
    ((AppearanceBase) appearance92).BackColor = SystemColors.Window;
    ((AppearanceBase) appearance92).BorderColor = SystemColors.InactiveCaption;
    ultraGridLayout4.Appearance = (AppearanceBase) appearance92;
    ultraGridLayout4.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand8.ColHeadersVisible = false;
    ((HeaderBase) ultraGridColumn40.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn40.Header).VisiblePosition = 0;
    ultraGridColumn40.Hidden = true;
    ((HeaderBase) ultraGridColumn41.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn41.Header).VisiblePosition = 1;
    ultraGridColumn41.Hidden = true;
    ((HeaderBase) ultraGridColumn42.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn42.Header).VisiblePosition = 2;
    ultraGridColumn42.Width = 240 /*0xF0*/;
    ultraGridBand8.Columns.AddRange(new object[3]
    {
      (object) ultraGridColumn40,
      (object) ultraGridColumn41,
      (object) ultraGridColumn42
    });
    ultraGridLayout4.BandsSerializer.Add((object) ultraGridBand8);
    ultraGridLayout4.BorderStyle = (UIElementBorderStyle) 4;
    ultraGridLayout4.CaptionVisible = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance93).BackColor = SystemColors.ActiveBorder;
    ((AppearanceBase) appearance93).BackColor2 = SystemColors.ControlDark;
    ((AppearanceBase) appearance93).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance93).BorderColor = SystemColors.Window;
    ((SpecialBoxBase) ultraGridLayout4.GroupByBox).Appearance = (AppearanceBase) appearance93;
    ((AppearanceBase) appearance94).ForeColor = SystemColors.GrayText;
    ultraGridLayout4.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance94;
    ((SpecialBoxBase) ultraGridLayout4.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance95).BackColor = SystemColors.ControlLightLight;
    ((AppearanceBase) appearance95).BackColor2 = SystemColors.Control;
    ((AppearanceBase) appearance95).BackGradientStyle = (GradientStyle) 3;
    ((AppearanceBase) appearance95).ForeColor = SystemColors.GrayText;
    ultraGridLayout4.GroupByBox.PromptAppearance = (AppearanceBase) appearance95;
    ((KeyedSubObjectBase) ultraGridLayout4).Key = "CompanyLocationsLayout";
    ultraGridLayout4.MaxColScrollRegions = 1;
    ultraGridLayout4.MaxRowScrollRegions = 1;
    ((AppearanceBase) appearance96).BackColor = SystemColors.Window;
    ((AppearanceBase) appearance96).ForeColor = SystemColors.ControlText;
    ultraGridLayout4.Override.ActiveCellAppearance = (AppearanceBase) appearance96;
    ((AppearanceBase) appearance97).BackColor = SystemColors.Highlight;
    ((AppearanceBase) appearance97).ForeColor = SystemColors.HighlightText;
    ultraGridLayout4.Override.ActiveRowAppearance = (AppearanceBase) appearance97;
    ultraGridLayout4.Override.BorderStyleCell = (UIElementBorderStyle) 2;
    ultraGridLayout4.Override.BorderStyleRow = (UIElementBorderStyle) 2;
    ((AppearanceBase) appearance98).BackColor = SystemColors.Window;
    ultraGridLayout4.Override.CardAreaAppearance = (AppearanceBase) appearance98;
    ((AppearanceBase) appearance99).BorderColor = Color.Silver;
    ((AppearanceBase) appearance99).TextTrimming = (TextTrimming) 3;
    ultraGridLayout4.Override.CellAppearance = (AppearanceBase) appearance99;
    ultraGridLayout4.Override.CellClickAction = (CellClickAction) 4;
    ultraGridLayout4.Override.CellPadding = 0;
    ((AppearanceBase) appearance100).BackColor = SystemColors.Control;
    ((AppearanceBase) appearance100).BackColor2 = SystemColors.ControlDark;
    ((AppearanceBase) appearance100).BackGradientAlignment = (GradientAlignment) 1;
    ((AppearanceBase) appearance100).BackGradientStyle = (GradientStyle) 3;
    ((AppearanceBase) appearance100).BorderColor = SystemColors.Window;
    ultraGridLayout4.Override.GroupByRowAppearance = (AppearanceBase) appearance100;
    ((AppearanceBase) appearance101).TextHAlignAsString = "Left";
    ultraGridLayout4.Override.HeaderAppearance = (AppearanceBase) appearance101;
    ultraGridLayout4.Override.HeaderClickAction = (HeaderClickAction) 3;
    ultraGridLayout4.Override.HeaderStyle = (HeaderStyle) 2;
    ((AppearanceBase) appearance102).BackColor = Color.FromArgb(246, 250, 253);
    ultraGridLayout4.Override.RowAlternateAppearance = (AppearanceBase) appearance102;
    ((AppearanceBase) appearance103).BackColor = Color.White;
    ((AppearanceBase) appearance103).BorderColor = Color.Silver;
    ultraGridLayout4.Override.RowAppearance = (AppearanceBase) appearance103;
    ultraGridLayout4.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance104).BackColor = SystemColors.ControlLight;
    ultraGridLayout4.Override.TemplateAddRowAppearance = (AppearanceBase) appearance104;
    ultraGridLayout4.ScrollBounds = (ScrollBounds) 0;
    ultraGridLayout4.ScrollStyle = (ScrollStyle) 1;
    ultraGridLayout4.ViewStyleBand = (ViewStyleBand) 2;
    ((UltraGridBase) this.dropDownCompanyLocations).Layouts.Add(ultraGridLayout4);
    ((Control) this.dropDownCompanyLocations).Location = new Point(442, 588);
    ((Control) this.dropDownCompanyLocations).Name = "dropDownCompanyLocations";
    ((Control) this.dropDownCompanyLocations).Size = new Size(242, 80 /*0x50*/);
    ((Control) this.dropDownCompanyLocations).TabIndex = 3;
    ((Control) this.dropDownCompanyLocations).Text = "ultraDropDown3";
    ((Control) this.dropDownCompanyLocations).Visible = false;
    this.companyLocationsBindingSource.DataMember = "CompanyLocations";
    this.companyLocationsBindingSource.DataSource = (object) this.dsNumberingLinking;
    ((UltraGridBase) this.dropDownLines).DataSource = (object) this.linesBindingSource;
    ((AppearanceBase) appearance105).BackColor = SystemColors.Window;
    ((AppearanceBase) appearance105).BorderColor = SystemColors.InactiveCaption;
    ((UltraGridBase) this.dropDownLines).DisplayLayout.Appearance = (AppearanceBase) appearance105;
    ((UltraGridBase) this.dropDownLines).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand9.ColHeadersVisible = false;
    ((HeaderBase) ultraGridColumn43.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn43.Header).VisiblePosition = 0;
    ultraGridColumn43.Hidden = true;
    ((HeaderBase) ultraGridColumn44.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn44.Header).VisiblePosition = 1;
    ultraGridColumn44.Width = 228;
    ultraGridBand9.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn43,
      (object) ultraGridColumn44
    });
    ((UltraGridBase) this.dropDownLines).DisplayLayout.BandsSerializer.Add((object) ultraGridBand9);
    ((UltraGridBase) this.dropDownLines).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.dropDownLines).DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance106).BackColor = SystemColors.ActiveBorder;
    ((AppearanceBase) appearance106).BackColor2 = SystemColors.ControlDark;
    ((AppearanceBase) appearance106).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance106).BorderColor = SystemColors.Window;
    ((SpecialBoxBase) ((UltraGridBase) this.dropDownLines).DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance106;
    ((AppearanceBase) appearance107).ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.dropDownLines).DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance107;
    ((SpecialBoxBase) ((UltraGridBase) this.dropDownLines).DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance108).BackColor = SystemColors.ControlLightLight;
    ((AppearanceBase) appearance108).BackColor2 = SystemColors.Control;
    ((AppearanceBase) appearance108).BackGradientStyle = (GradientStyle) 3;
    ((AppearanceBase) appearance108).ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.dropDownLines).DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance108;
    ((UltraGridBase) this.dropDownLines).DisplayLayout.MaxColScrollRegions = 1;
    ((UltraGridBase) this.dropDownLines).DisplayLayout.MaxRowScrollRegions = 1;
    ((AppearanceBase) appearance109).BackColor = SystemColors.Window;
    ((AppearanceBase) appearance109).ForeColor = SystemColors.ControlText;
    ((UltraGridBase) this.dropDownLines).DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance109;
    ((AppearanceBase) appearance110).BackColor = SystemColors.Highlight;
    ((AppearanceBase) appearance110).ForeColor = SystemColors.HighlightText;
    ((UltraGridBase) this.dropDownLines).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance110;
    ((UltraGridBase) this.dropDownLines).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 2;
    ((UltraGridBase) this.dropDownLines).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 2;
    ((AppearanceBase) appearance111).BackColor = SystemColors.Window;
    ((UltraGridBase) this.dropDownLines).DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance111;
    ((AppearanceBase) appearance112).BorderColor = Color.Silver;
    ((AppearanceBase) appearance112).TextTrimming = (TextTrimming) 3;
    ((UltraGridBase) this.dropDownLines).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance112;
    ((UltraGridBase) this.dropDownLines).DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    ((UltraGridBase) this.dropDownLines).DisplayLayout.Override.CellPadding = 0;
    ((AppearanceBase) appearance113).BackColor = SystemColors.Control;
    ((AppearanceBase) appearance113).BackColor2 = SystemColors.ControlDark;
    ((AppearanceBase) appearance113).BackGradientAlignment = (GradientAlignment) 1;
    ((AppearanceBase) appearance113).BackGradientStyle = (GradientStyle) 3;
    ((AppearanceBase) appearance113).BorderColor = SystemColors.Window;
    ((UltraGridBase) this.dropDownLines).DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance113;
    ((AppearanceBase) appearance114).TextHAlignAsString = "Left";
    ((UltraGridBase) this.dropDownLines).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance114;
    ((UltraGridBase) this.dropDownLines).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    ((UltraGridBase) this.dropDownLines).DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    ((AppearanceBase) appearance115).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.dropDownLines).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance115;
    ((AppearanceBase) appearance116).BackColor = Color.White;
    ((AppearanceBase) appearance116).BorderColor = Color.Silver;
    ((UltraGridBase) this.dropDownLines).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance116;
    ((UltraGridBase) this.dropDownLines).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance117).BackColor = SystemColors.ControlLight;
    ((UltraGridBase) this.dropDownLines).DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance117;
    ((UltraGridBase) this.dropDownLines).DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    ((UltraGridBase) this.dropDownLines).DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    ((UltraGridBase) this.dropDownLines).DisplayLayout.ViewStyleBand = (ViewStyleBand) 2;
    ((AppearanceBase) appearance118).BackColor = SystemColors.Window;
    ((AppearanceBase) appearance118).BorderColor = SystemColors.InactiveCaption;
    ultraGridLayout5.Appearance = (AppearanceBase) appearance118;
    ultraGridLayout5.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand10.ColHeadersVisible = false;
    ((HeaderBase) ultraGridColumn45.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn45.Header).VisiblePosition = 0;
    ultraGridColumn45.Hidden = true;
    ((HeaderBase) ultraGridColumn46.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn46.Header).VisiblePosition = 1;
    ultraGridColumn46.Width = 228;
    ultraGridBand10.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn45,
      (object) ultraGridColumn46
    });
    ultraGridLayout5.BandsSerializer.Add((object) ultraGridBand10);
    ultraGridLayout5.BorderStyle = (UIElementBorderStyle) 4;
    ultraGridLayout5.CaptionVisible = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance119).BackColor = SystemColors.ActiveBorder;
    ((AppearanceBase) appearance119).BackColor2 = SystemColors.ControlDark;
    ((AppearanceBase) appearance119).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance119).BorderColor = SystemColors.Window;
    ((SpecialBoxBase) ultraGridLayout5.GroupByBox).Appearance = (AppearanceBase) appearance119;
    ((AppearanceBase) appearance120).ForeColor = SystemColors.GrayText;
    ultraGridLayout5.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance120;
    ((SpecialBoxBase) ultraGridLayout5.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance121).BackColor = SystemColors.ControlLightLight;
    ((AppearanceBase) appearance121).BackColor2 = SystemColors.Control;
    ((AppearanceBase) appearance121).BackGradientStyle = (GradientStyle) 3;
    ((AppearanceBase) appearance121).ForeColor = SystemColors.GrayText;
    ultraGridLayout5.GroupByBox.PromptAppearance = (AppearanceBase) appearance121;
    ((KeyedSubObjectBase) ultraGridLayout5).Key = "LinesLayout";
    ultraGridLayout5.MaxColScrollRegions = 1;
    ultraGridLayout5.MaxRowScrollRegions = 1;
    ((AppearanceBase) appearance122).BackColor = SystemColors.Window;
    ((AppearanceBase) appearance122).ForeColor = SystemColors.ControlText;
    ultraGridLayout5.Override.ActiveCellAppearance = (AppearanceBase) appearance122;
    ((AppearanceBase) appearance123).BackColor = SystemColors.Highlight;
    ((AppearanceBase) appearance123).ForeColor = SystemColors.HighlightText;
    ultraGridLayout5.Override.ActiveRowAppearance = (AppearanceBase) appearance123;
    ultraGridLayout5.Override.BorderStyleCell = (UIElementBorderStyle) 2;
    ultraGridLayout5.Override.BorderStyleRow = (UIElementBorderStyle) 2;
    ((AppearanceBase) appearance124).BackColor = SystemColors.Window;
    ultraGridLayout5.Override.CardAreaAppearance = (AppearanceBase) appearance124;
    ((AppearanceBase) appearance125).BorderColor = Color.Silver;
    ((AppearanceBase) appearance125).TextTrimming = (TextTrimming) 3;
    ultraGridLayout5.Override.CellAppearance = (AppearanceBase) appearance125;
    ultraGridLayout5.Override.CellClickAction = (CellClickAction) 4;
    ultraGridLayout5.Override.CellPadding = 0;
    ((AppearanceBase) appearance126).BackColor = SystemColors.Control;
    ((AppearanceBase) appearance126).BackColor2 = SystemColors.ControlDark;
    ((AppearanceBase) appearance126).BackGradientAlignment = (GradientAlignment) 1;
    ((AppearanceBase) appearance126).BackGradientStyle = (GradientStyle) 3;
    ((AppearanceBase) appearance126).BorderColor = SystemColors.Window;
    ultraGridLayout5.Override.GroupByRowAppearance = (AppearanceBase) appearance126;
    ((AppearanceBase) appearance127).TextHAlignAsString = "Left";
    ultraGridLayout5.Override.HeaderAppearance = (AppearanceBase) appearance127;
    ultraGridLayout5.Override.HeaderClickAction = (HeaderClickAction) 3;
    ultraGridLayout5.Override.HeaderStyle = (HeaderStyle) 2;
    ((AppearanceBase) appearance128).BackColor = Color.FromArgb(246, 250, 253);
    ultraGridLayout5.Override.RowAlternateAppearance = (AppearanceBase) appearance128;
    ((AppearanceBase) appearance129).BackColor = Color.White;
    ((AppearanceBase) appearance129).BorderColor = Color.Silver;
    ultraGridLayout5.Override.RowAppearance = (AppearanceBase) appearance129;
    ultraGridLayout5.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance130).BackColor = SystemColors.ControlLight;
    ultraGridLayout5.Override.TemplateAddRowAppearance = (AppearanceBase) appearance130;
    ultraGridLayout5.ScrollBounds = (ScrollBounds) 0;
    ultraGridLayout5.ScrollStyle = (ScrollStyle) 1;
    ultraGridLayout5.ViewStyleBand = (ViewStyleBand) 2;
    ((UltraGridBase) this.dropDownLines).Layouts.Add(ultraGridLayout5);
    ((Control) this.dropDownLines).Location = new Point(530, 588);
    ((Control) this.dropDownLines).Name = "dropDownLines";
    ((Control) this.dropDownLines).Size = new Size(230, 80 /*0x50*/);
    ((Control) this.dropDownLines).TabIndex = 4;
    ((Control) this.dropDownLines).Text = "ultraDropDown4";
    ((Control) this.dropDownLines).Visible = false;
    this.linesBindingSource.DataMember = "Lines";
    this.linesBindingSource.DataSource = (object) this.dsNumberingLinking;
    ((Control) this.buttonSave).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    ((AppearanceBase) appearance131).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance131).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance131).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance131).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance131).Image = (object) Resources.Save;
    ((AppearanceBase) appearance131).ImageHAlign = (HAlign) 1;
    ((AppearanceBase) appearance131).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonSave).Appearance = (AppearanceBase) appearance131;
    ((Control) this.buttonSave).Location = new Point(674, 550);
    ((Control) this.buttonSave).Name = "buttonSave";
    ((Control) this.buttonSave).Size = new Size(110, 30);
    ((Control) this.buttonSave).TabIndex = 8;
    ((Control) this.buttonSave).Text = "Save Changes";
    ((UltraControlBase) this.buttonSave).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonSave).Click += new EventHandler(this.buttonSave_Click);
    ((Control) this.buttonCancel).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    ((AppearanceBase) appearance132).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance132).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance132).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance132).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance132).Image = (object) Resources.CatastropheCodeSmall;
    ((AppearanceBase) appearance132).ImageHAlign = (HAlign) 1;
    ((AppearanceBase) appearance132).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonCancel).Appearance = (AppearanceBase) appearance132;
    ((Control) this.buttonCancel).Location = new Point(794, 550);
    ((Control) this.buttonCancel).Name = "buttonCancel";
    ((Control) this.buttonCancel).Size = new Size(110, 30);
    ((Control) this.buttonCancel).TabIndex = 9;
    ((Control) this.buttonCancel).Text = "Cancel Changes";
    ((UltraControlBase) this.buttonCancel).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonCancel).Click += new EventHandler(this.buttonCancel_Click);
    this.sqlSelectCommand1.CommandText = "dbo.spClaims_GetLinkedAutomationRules";
    this.sqlSelectCommand1.CommandType = CommandType.StoredProcedure;
    this.sqlSelectCommand1.Connection = this.dataConnection;
    this.sqlSelectCommand1.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null)
    });
    this.dataConnection.ConnectionString = "Data Source=MGASYSTEMS;Initial Catalog=IMS;User ID=mgasystems";
    this.dataConnection.FireInfoMessageEventOnUserErrors = false;
    this.sqlInsertCommand1.CommandText = "dbo.spClaims_InsertNumberingAutomationLink";
    this.sqlInsertCommand1.CommandType = CommandType.StoredProcedure;
    this.sqlInsertCommand1.Connection = this.dataConnection;
    this.sqlInsertCommand1.Parameters.AddRange(new SqlParameter[7]
    {
      new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null),
      new SqlParameter("@CompanyGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "CompanyGuid"),
      new SqlParameter("@CompanyLocationGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "CompanyLocationGuid"),
      new SqlParameter("@LineGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "LineGuid"),
      new SqlParameter("@EffectiveDate", SqlDbType.DateTime, 8, "EffectiveDate"),
      new SqlParameter("@EnteredByGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "EnteredByGuid"),
      new SqlParameter("@RuleId", SqlDbType.Int, 4, "RuleId")
    });
    this.sqlUpdateCommand1.CommandText = "dbo.spClaims_UpdateNumberingAutomationLink";
    this.sqlUpdateCommand1.CommandType = CommandType.StoredProcedure;
    this.sqlUpdateCommand1.Connection = this.dataConnection;
    this.sqlUpdateCommand1.Parameters.AddRange(new SqlParameter[9]
    {
      new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null),
      new SqlParameter("@LinkId", SqlDbType.Int, 4, "LinkId"),
      new SqlParameter("@CompanyGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "CompanyGuid"),
      new SqlParameter("@CompanyLocationGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "CompanyLocationGuid"),
      new SqlParameter("@LineGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "LineGuid"),
      new SqlParameter("@EffectiveDate", SqlDbType.DateTime, 8, "EffectiveDate"),
      new SqlParameter("@ModifiedByGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "EnteredByGuid"),
      new SqlParameter("@RuleId", SqlDbType.Int, 4, "RuleId"),
      new SqlParameter("@Active", SqlDbType.Bit, 1, "Active")
    });
    this.daAutomationLinking.InsertCommand = this.sqlInsertCommand1;
    this.daAutomationLinking.SelectCommand = this.sqlSelectCommand1;
    this.daAutomationLinking.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "spClaims_GetLinkedAutomationRules", new DataColumnMapping[14]
      {
        new DataColumnMapping("LinkId", "LinkId"),
        new DataColumnMapping("CompanyGuid", "CompanyGuid"),
        new DataColumnMapping("CompanyName", "CompanyName"),
        new DataColumnMapping("CompanyLocationGuid", "CompanyLocationGuid"),
        new DataColumnMapping("CompanyLocationName", "CompanyLocationName"),
        new DataColumnMapping("LineGuid", "LineGuid"),
        new DataColumnMapping("LineName", "LineName"),
        new DataColumnMapping("EffectiveDate", "EffectiveDate"),
        new DataColumnMapping("DateEntered", "DateEntered"),
        new DataColumnMapping("EnteredByGuid", "EnteredByGuid"),
        new DataColumnMapping("EnteredBy", "EnteredBy"),
        new DataColumnMapping("RuleId", "RuleId"),
        new DataColumnMapping("RuleName", "RuleName"),
        new DataColumnMapping("Active", "Active")
      })
    });
    this.daAutomationLinking.UpdateCommand = this.sqlUpdateCommand1;
    ((Control) this._ClaimNumberAutomationLinkingUI_Toolbars_Dock_Area_Left).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._ClaimNumberAutomationLinkingUI_Toolbars_Dock_Area_Left).BackColor = SystemColors.Control;
    this._ClaimNumberAutomationLinkingUI_Toolbars_Dock_Area_Left.DockedPosition = (DockedPosition) 2;
    ((Control) this._ClaimNumberAutomationLinkingUI_Toolbars_Dock_Area_Left).ForeColor = SystemColors.ControlText;
    ((Control) this._ClaimNumberAutomationLinkingUI_Toolbars_Dock_Area_Left).Location = new Point(0, 0);
    ((Control) this._ClaimNumberAutomationLinkingUI_Toolbars_Dock_Area_Left).Name = "_ClaimNumberAutomationLinkingUI_Toolbars_Dock_Area_Left";
    ((Control) this._ClaimNumberAutomationLinkingUI_Toolbars_Dock_Area_Left).Size = new Size(0, 583);
    this._ClaimNumberAutomationLinkingUI_Toolbars_Dock_Area_Left.ToolbarsManager = this.ultraToolbarsManager1;
    this.ultraToolbarsManager1.DesignerFlags = 1;
    this.ultraToolbarsManager1.DockWithinContainer = (Control) this;
    this.ultraToolbarsManager1.ShowFullMenusDelay = 500;
    ultraToolbar.DockedColumn = 0;
    ultraToolbar.DockedRow = 0;
    ((UltraToolbarBase) ultraToolbar).NonInheritedTools.AddRange(new ToolBase[1]
    {
      (ToolBase) popupMenuTool1
    });
    ultraToolbar.Text = "UltraToolbar1";
    ultraToolbar.Visible = false;
    this.ultraToolbarsManager1.Toolbars.AddRange(new UltraToolbar[1]
    {
      ultraToolbar
    });
    ((ToolPropsBase) ((ToolBase) popupMenuTool2).SharedPropsInternal).Caption = "GridContextMenu";
    ((ToolsCollectionBase) popupMenuTool2.Tools).AddRange(new ToolBase[1]
    {
      (ToolBase) buttonTool1
    });
    ((AppearanceBase) appearance133).Image = (object) Resources.DeleteClaimSmall;
    ((ToolPropsBase) ((ToolBase) buttonTool2).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance133;
    ((ToolPropsBase) ((ToolBase) buttonTool2).SharedPropsInternal).Caption = "Delete Linking";
    ((ToolsCollectionBase) this.ultraToolbarsManager1.Tools).AddRange(new ToolBase[2]
    {
      (ToolBase) popupMenuTool2,
      (ToolBase) buttonTool2
    });
    this.ultraToolbarsManager1.BeforeToolDropdown += new BeforeToolDropdownEventHandler(this.ultraToolbarsManager1_BeforeToolDropdown);
    this.ultraToolbarsManager1.ToolClick += new ToolClickEventHandler(this.ultraToolbarsManager1_ToolClick);
    ((Control) this._ClaimNumberAutomationLinkingUI_Toolbars_Dock_Area_Right).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._ClaimNumberAutomationLinkingUI_Toolbars_Dock_Area_Right).BackColor = SystemColors.Control;
    this._ClaimNumberAutomationLinkingUI_Toolbars_Dock_Area_Right.DockedPosition = (DockedPosition) 3;
    ((Control) this._ClaimNumberAutomationLinkingUI_Toolbars_Dock_Area_Right).ForeColor = SystemColors.ControlText;
    ((Control) this._ClaimNumberAutomationLinkingUI_Toolbars_Dock_Area_Right).Location = new Point(911, 0);
    ((Control) this._ClaimNumberAutomationLinkingUI_Toolbars_Dock_Area_Right).Name = "_ClaimNumberAutomationLinkingUI_Toolbars_Dock_Area_Right";
    ((Control) this._ClaimNumberAutomationLinkingUI_Toolbars_Dock_Area_Right).Size = new Size(0, 583);
    this._ClaimNumberAutomationLinkingUI_Toolbars_Dock_Area_Right.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._ClaimNumberAutomationLinkingUI_Toolbars_Dock_Area_Top).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._ClaimNumberAutomationLinkingUI_Toolbars_Dock_Area_Top).BackColor = SystemColors.Control;
    this._ClaimNumberAutomationLinkingUI_Toolbars_Dock_Area_Top.DockedPosition = (DockedPosition) 0;
    ((Control) this._ClaimNumberAutomationLinkingUI_Toolbars_Dock_Area_Top).ForeColor = SystemColors.ControlText;
    ((Control) this._ClaimNumberAutomationLinkingUI_Toolbars_Dock_Area_Top).Location = new Point(0, 0);
    ((Control) this._ClaimNumberAutomationLinkingUI_Toolbars_Dock_Area_Top).Name = "_ClaimNumberAutomationLinkingUI_Toolbars_Dock_Area_Top";
    ((Control) this._ClaimNumberAutomationLinkingUI_Toolbars_Dock_Area_Top).Size = new Size(911, 0);
    this._ClaimNumberAutomationLinkingUI_Toolbars_Dock_Area_Top.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._ClaimNumberAutomationLinkingUI_Toolbars_Dock_Area_Bottom).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._ClaimNumberAutomationLinkingUI_Toolbars_Dock_Area_Bottom).BackColor = SystemColors.Control;
    this._ClaimNumberAutomationLinkingUI_Toolbars_Dock_Area_Bottom.DockedPosition = (DockedPosition) 1;
    ((Control) this._ClaimNumberAutomationLinkingUI_Toolbars_Dock_Area_Bottom).ForeColor = SystemColors.ControlText;
    ((Control) this._ClaimNumberAutomationLinkingUI_Toolbars_Dock_Area_Bottom).Location = new Point(0, 583);
    ((Control) this._ClaimNumberAutomationLinkingUI_Toolbars_Dock_Area_Bottom).Name = "_ClaimNumberAutomationLinkingUI_Toolbars_Dock_Area_Bottom";
    ((Control) this._ClaimNumberAutomationLinkingUI_Toolbars_Dock_Area_Bottom).Size = new Size(911, 0);
    this._ClaimNumberAutomationLinkingUI_Toolbars_Dock_Area_Bottom.ToolbarsManager = this.ultraToolbarsManager1;
    this.lblSaved.Anchor = AnchorStyles.Bottom;
    this.lblSaved.AutoSize = true;
    this.lblSaved.BackColor = Color.Transparent;
    this.lblSaved.ForeColor = Color.Black;
    this.lblSaved.Location = new Point(78, 564);
    this.lblSaved.Name = "lblSaved";
    this.lblSaved.Size = new Size(262, 13);
    this.lblSaved.TabIndex = 14;
    this.lblSaved.Text = "Linking has been saved successfully to the database.";
    this.lblSaved.TextAlign = ContentAlignment.MiddleCenter;
    this.lblSaved.Visible = false;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.Controls.Add((Control) this.lblSaved);
    this.Controls.Add((Control) this.buttonCancel);
    this.Controls.Add((Control) this.buttonSave);
    this.Controls.Add((Control) this.dropDownLines);
    this.Controls.Add((Control) this.groupDefinedRules);
    this.Controls.Add((Control) this.dropDownCompanyLocations);
    this.Controls.Add((Control) this.label2);
    this.Controls.Add((Control) this.dropDownCompanies);
    this.Controls.Add((Control) this.label1);
    this.Controls.Add((Control) this.dropDownRules);
    this.Controls.Add((Control) this._ClaimNumberAutomationLinkingUI_Toolbars_Dock_Area_Left);
    this.Controls.Add((Control) this._ClaimNumberAutomationLinkingUI_Toolbars_Dock_Area_Right);
    this.Controls.Add((Control) this._ClaimNumberAutomationLinkingUI_Toolbars_Dock_Area_Bottom);
    this.Controls.Add((Control) this._ClaimNumberAutomationLinkingUI_Toolbars_Dock_Area_Top);
    this.Font = new Font("Tahoma", 8.25f);
    this.Name = nameof (ClaimNumberAutomationLinkingUI);
    this.Size = new Size(911, 583);
    ((ISupportInitialize) this.groupDefinedRules).EndInit();
    ((Control) this.groupDefinedRules).ResumeLayout(false);
    ((ISupportInitialize) this.gridCurrentRules).EndInit();
    this.dsNumberingLinking1.EndInit();
    ((ISupportInitialize) this.dropDownRules).EndInit();
    ((ISupportInitialize) this.numberingAutomationRulesBindingSource).EndInit();
    this.dsNumberingLinking.EndInit();
    ((ISupportInitialize) this.dropDownCompanies).EndInit();
    ((ISupportInitialize) this.companiesBindingSource).EndInit();
    ((ISupportInitialize) this.dropDownCompanyLocations).EndInit();
    ((ISupportInitialize) this.companyLocationsBindingSource).EndInit();
    ((ISupportInitialize) this.dropDownLines).EndInit();
    ((ISupportInitialize) this.linesBindingSource).EndInit();
    ((ISupportInitialize) this.buttonSave).EndInit();
    ((ISupportInitialize) this.buttonCancel).EndInit();
    ((ISupportInitialize) this.ultraToolbarsManager1).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }
}
