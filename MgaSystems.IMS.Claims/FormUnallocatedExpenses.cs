// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.FormUnallocatedExpenses
// Assembly: MgaSystems.IMS.Claims, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FCD9D0B7-28CF-40B9-8EB7-297871E1AF5F
// Assembly location: F:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinMaskedEdit;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Claims.Properties;
using MGASystems.Tools;
using MGASystems.Tools.DBSaveUI;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Claims;

public class FormUnallocatedExpenses : FormBase
{
  private IContainer components;
  protected UltraGrid gridExpenseListing;
  protected BindingSource expenseListBindingSource;
  protected dsClaimExpenses dsClaimExpenses1;
  protected UltraLabel ultraLabel1;
  protected MGATextBox textExpenseName;
  protected UltraLabel ultraLabel4;
  protected UltraLabel ultraLabel3;
  protected UltraLabel ultraLabel2;
  protected MGACheckBox checkChargedHourly;
  protected UltraLabel ultraLabel7;
  protected MGACheckBox checkEquipmentCharges;
  protected MGACheckBox checkUnit_Allowedit;
  protected UltraLabel ultraLabel5;
  protected UltraLabel ultraLabel6;
  protected UltraLabel ultraLabel8;
  protected MGACheckBox checkChargedPerUnit;
  protected MGACheckBox checkEquip_AllowEdit;
  protected MGACheckBox checkHourly_AllowEdit;
  protected MGATextBox textUnit_DisplayPrompt;
  protected UltraLabel ultraLabel9;
  protected SqlCommand sqlSelectCommand1;
  protected SqlCommand sqlInsertCommand1;
  protected SqlCommand sqlUpdateCommand1;
  protected SqlDataAdapter sqlDataAdapter1;
  protected SqlCommand sqlDeleteCommand;
  protected MGAMaskedEdit textHourlyRate;
  protected MGAMaskedEdit textHourly_MaxHours;
  protected MGAMaskedEdit textUnit_AutomatedAmount;
  protected MGAMaskedEdit textUnit_MaxAmount;
  protected MGAMaskedEdit textUnit_UnitCost;
  protected MGAMaskedEdit textEquipmentRate;
  protected MGAMaskedEdit textHourly_AutomatedHours;
  protected MGAGroupBox mgaGroupBox1;
  protected MGASystems.Tools.DBSaveUI.DBSaveUI dbSaveUI1;
  protected Panel panelEdits;
  protected MGATextBox textExpenseId;
  protected MGACheckBox checkIsTax;

  public FormUnallocatedExpenses() => this.InitializeComponent();

  protected int ExpenseId { get; set; }

  protected virtual void LoadExpenses()
  {
    this.DoClearScreenEvent();
    this.dsClaimExpenses1.ExpenseList.Clear();
    DefaultDatabase.LoadDataTable((DataTable) this.dsClaimExpenses1.ExpenseList, "spClaims_GetExpenseAdministration");
  }

  protected virtual void AddNew()
  {
    this.expenseListBindingSource.AddNew();
    this.expenseListBindingSource.Position = this.expenseListBindingSource.Count - 1;
    this.panelEdits.Enabled = true;
    this.SetControlsForNewEntry();
    ((GridItemBase) ((UltraGridBase) this.gridExpenseListing).Rows[((DisposableObjectCollectionBase) ((UltraGridBase) this.gridExpenseListing).Rows).Count - 1]).Selected = true;
    string s = this.gridExpenseListing.Selected.Rows[0].Cells["ExpenseId"].Value.ToString();
    this.ExpenseId = s.Length > 0 ? int.Parse(s) : 0;
  }

  protected virtual void Save()
  {
    this.expenseListBindingSource.EndEdit();
    try
    {
      DefaultDatabase.ExecuteTransaction((EventHandler<ExecuteTransactionEventArgs>) ((sender, e) =>
      {
        this.sqlDataAdapter1.SelectCommand.Connection = (SqlConnection) e.Transaction.Connection;
        this.sqlDataAdapter1.UpdateCommand.Connection = (SqlConnection) e.Transaction.Connection;
        this.sqlDataAdapter1.InsertCommand.Connection = (SqlConnection) e.Transaction.Connection;
        this.sqlDataAdapter1.DeleteCommand.Connection = (SqlConnection) e.Transaction.Connection;
        DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.sqlDataAdapter1, (DataTable) this.dsClaimExpenses1.ExpenseList);
        if (this.ExpenseId == 0)
        {
          string s = DefaultDatabase.ExecuteScalar(CommandType.Text, "select top 1 ExpenseId from lstClaims_ClaimExpenses order by ExpenseId desc").ToString();
          this.ExpenseId = s.Length > 0 ? int.Parse(s) : 0;
        }
        this.DoSaveExpenseEvent();
        e.Transaction.Commit();
      }));
    }
    finally
    {
      this.LoadExpenses();
      this.SetDBSaveUIState();
      this.panelEdits.Enabled = false;
    }
  }

  private bool ValidateForm()
  {
    if (!((UltraToggleEditorBase) this.checkChargedHourly).Checked && !((UltraToggleEditorBase) this.checkEquipmentCharges).Checked && !((UltraToggleEditorBase) this.checkChargedPerUnit).Checked)
    {
      int num = (int) MessageBox.Show(Resources.EXPENSE_INVALIDARGUMENT_NOCHARGES, Resources.ERROR_REQUIREDFIELD_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (string.IsNullOrEmpty(((Control) this.textExpenseName).Text))
    {
      int num = (int) MessageBox.Show(Resources.UNALLOCATEDEXPENSE_ERROR1, Resources.ERROR_REQUIREDFIELD_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      ((TextEditorControlBase) this.textExpenseName).Focus();
      return false;
    }
    Decimal result;
    if (((UltraToggleEditorBase) this.checkChargedHourly).Checked)
    {
      if (string.IsNullOrEmpty(((Control) this.textHourlyRate).Text) || !Decimal.TryParse(((Control) this.textHourlyRate).Text, NumberStyles.Any, (IFormatProvider) null, out result))
      {
        int num = (int) MessageBox.Show(Resources.UNALLOCATEDEXPENSE_HOURLY_ERROR1, Resources.ERROR_INVALIDENTRY_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        ((Control) this.textHourlyRate).Focus();
        return false;
      }
      if (string.IsNullOrEmpty(((Control) this.textHourly_MaxHours).Text) || !Decimal.TryParse(((Control) this.textHourly_MaxHours).Text, NumberStyles.Any, (IFormatProvider) null, out result))
      {
        int num = (int) MessageBox.Show(Resources.UNALLOCATEDEXPENSE_HOURLY_ERROR2, Resources.ERROR_INVALIDENTRY_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        ((Control) this.textHourly_MaxHours).Focus();
        return false;
      }
      if (string.IsNullOrEmpty(((Control) this.textHourly_AutomatedHours).Text) || !Decimal.TryParse(((Control) this.textHourly_AutomatedHours).Text, NumberStyles.Any, (IFormatProvider) null, out result))
      {
        int num = (int) MessageBox.Show(Resources.UNALLOCATEDEXPENSE_HOURLY_ERROR3, Resources.ERROR_INVALIDENTRY_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        ((Control) this.textHourly_AutomatedHours).Focus();
        return false;
      }
    }
    if (((UltraToggleEditorBase) this.checkEquipmentCharges).Checked && (string.IsNullOrEmpty(((Control) this.textEquipmentRate).Text) || !Decimal.TryParse(((Control) this.textEquipmentRate).Text, NumberStyles.Any, (IFormatProvider) null, out result)))
    {
      int num = (int) MessageBox.Show(Resources.UNALLOCATEDEXPENSE_EQUIPMENT_ERROR, Resources.ERROR_INVALIDENTRY_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      ((Control) this.textEquipmentRate).Focus();
      return false;
    }
    if (((UltraToggleEditorBase) this.checkChargedPerUnit).Checked)
    {
      if (string.IsNullOrEmpty(((Control) this.textUnit_DisplayPrompt).Text))
      {
        int num = (int) MessageBox.Show(Resources.UNALLOCATEDEXPENSE_UNIT_ERROR1, Resources.ERROR_REQUIREDFIELD_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        ((TextEditorControlBase) this.textUnit_DisplayPrompt).Focus();
        return false;
      }
      if (string.IsNullOrEmpty(((Control) this.textUnit_AutomatedAmount).Text) || !Decimal.TryParse(((Control) this.textUnit_AutomatedAmount).Text, NumberStyles.Any, (IFormatProvider) null, out result))
      {
        int num = (int) MessageBox.Show(Resources.UNALLOCATEDEXPENSE_UNIT_ERROR4, Resources.ERROR_INVALIDENTRY_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        ((Control) this.textUnit_AutomatedAmount).Focus();
        return false;
      }
      if (string.IsNullOrEmpty(((Control) this.textUnit_MaxAmount).Text) || !Decimal.TryParse(((Control) this.textUnit_MaxAmount).Text, NumberStyles.Any, (IFormatProvider) null, out result))
      {
        int num = (int) MessageBox.Show(Resources.UNALLOCATEDEXPENSE_UNIT_ERROR3, Resources.ERROR_INVALIDENTRY_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        ((Control) this.textUnit_MaxAmount).Focus();
        return false;
      }
      if (string.IsNullOrEmpty(((Control) this.textUnit_UnitCost).Text) || !Decimal.TryParse(((Control) this.textUnit_UnitCost).Text, NumberStyles.Any, (IFormatProvider) null, out result))
      {
        int num = (int) MessageBox.Show(Resources.UNALLOCATEDEXPENSE_UNIT_ERROR2, Resources.ERROR_INVALIDENTRY_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        ((Control) this.textUnit_UnitCost).Focus();
        return false;
      }
    }
    return true;
  }

  protected void SetDBSaveUIState()
  {
    this.dbSaveUI1.EditStyle = (EditStyle) 1;
    this.dbSaveUI1.UIState = ((DisposableObjectCollectionBase) ((UltraGridBase) this.gridExpenseListing).Rows).Count <= 0 ? (UIState) 0 : (UIState) 1;
    ((Control) this.gridExpenseListing).Enabled = true;
  }

  protected virtual void CheckedChangedHandler(object sender, EventArgs e)
  {
    if (sender == this.checkChargedPerUnit)
    {
      if (((UltraToggleEditorBase) this.checkChargedPerUnit).Checked)
        return;
      ((Control) this.textUnit_DisplayPrompt).Text = string.Empty;
      ((UltraMaskedEdit) this.textUnit_AutomatedAmount).Value = (object) 0M;
      ((UltraMaskedEdit) this.textUnit_MaxAmount).Value = (object) 0M;
      ((UltraMaskedEdit) this.textUnit_UnitCost).Value = (object) 0M;
      ((UltraToggleEditorBase) this.checkUnit_Allowedit).Checked = false;
    }
    else if (sender == this.checkChargedHourly)
    {
      if (((UltraToggleEditorBase) this.checkChargedHourly).Checked)
        return;
      ((UltraMaskedEdit) this.textHourlyRate).Value = (object) 0M;
      ((UltraMaskedEdit) this.textHourly_MaxHours).Value = (object) 0M;
      ((UltraMaskedEdit) this.textHourly_AutomatedHours).Value = (object) 0M;
      ((UltraToggleEditorBase) this.checkHourly_AllowEdit).Checked = false;
    }
    else
    {
      if (sender != this.checkEquipmentCharges || ((UltraToggleEditorBase) this.checkEquipmentCharges).Checked)
        return;
      ((UltraMaskedEdit) this.textEquipmentRate).Value = (object) 0M;
      ((UltraToggleEditorBase) this.checkEquip_AllowEdit).Checked = false;
    }
  }

  protected virtual void SetControlsForNewEntry()
  {
    ((UltraToggleEditorBase) this.checkChargedHourly).Checked = false;
    ((UltraToggleEditorBase) this.checkChargedPerUnit).Checked = false;
    ((UltraToggleEditorBase) this.checkEquipmentCharges).Checked = false;
    ((UltraToggleEditorBase) this.checkIsTax).Checked = false;
    this.CheckedChangedHandler((object) this.checkChargedHourly, new EventArgs());
    this.CheckedChangedHandler((object) this.checkChargedPerUnit, new EventArgs());
    this.CheckedChangedHandler((object) this.checkEquipmentCharges, new EventArgs());
    this.DoClearScreenEvent();
  }

  private void gridExpenseListing_BeforeRowsDeleted(object sender, BeforeRowsDeletedEventArgs e)
  {
    e.DisplayPromptMsg = false;
  }

  private void dbSaveUI1_ClickedNew(object sender, EventArgs e)
  {
    ((Control) this.gridExpenseListing).Enabled = false;
    this.AddNew();
  }

  private void dbSaveUI1_ClickedEdit(object sender, EventArgs e)
  {
    ((Control) this.gridExpenseListing).Enabled = false;
    this.panelEdits.Enabled = true;
    this.ExpenseId = ((SparseCollectionBase) this.gridExpenseListing.Selected.Rows).Count != 0 ? (int) this.gridExpenseListing.Selected.Rows[0].Cells["ExpenseId"].Value : (int) ((UltraGridBase) this.gridExpenseListing).Rows[0].Cells["ExpenseId"].Value;
    this.DoEditExpenseEvent();
  }

  private void dbSaveUI1_ClickedDelete(object sender, EventArgs e)
  {
    if (((UltraGridBase) this.gridExpenseListing).ActiveRow != null)
      ((UltraGridBase) this.gridExpenseListing).ActiveRow.Delete();
    this.Save();
  }

  protected virtual void dbSaveUI1_ClickedCancel(object sender, EventArgs e)
  {
    this.panelEdits.Enabled = false;
    ((Control) this.gridExpenseListing).Enabled = true;
    this.LoadExpenses();
  }

  private void dbSaveUI1_ClickingSave(object sender, CancelEventArgs e)
  {
    if (this.ValidateForm())
      return;
    e.Cancel = true;
  }

  private void dbSaveUI1_ClickedSave(object sender, EventArgs e) => this.Save();

  protected virtual void FormUnallocatedExpenses_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    this.Cursor = MgaCursors.WaitCursor;
    using (BackgroundWorker backgroundWorker = new BackgroundWorker())
    {
      backgroundWorker.RunWorkerCompleted += (RunWorkerCompletedEventHandler) ((s, arg) =>
      {
        ((UltraGridBase) this.gridExpenseListing).DisplayLayout.Load(((UltraGridBase) this.gridExpenseListing).Layouts[0], (PropertyCategories) -1);
        this.SetDBSaveUIState();
        this.expenseListBindingSource.ResetCurrentItem();
        this.Cursor = MgaCursors.Default;
      });
      backgroundWorker.DoWork += (DoWorkEventHandler) ((snd, args) => this.LoadExpenses());
      backgroundWorker.RunWorkerAsync();
    }
  }

  protected event FormUnallocatedExpenses.SaveExpenseHandler SaveExpenseEvent;

  protected void DoSaveExpenseEvent()
  {
    FormUnallocatedExpenses.SaveExpenseHandler saveExpenseEvent = this.SaveExpenseEvent;
    if (saveExpenseEvent == null)
      return;
    saveExpenseEvent((object) this, new EventArgs());
  }

  protected event FormUnallocatedExpenses.ClearScreenHandler ClearScreenEvent;

  protected void DoClearScreenEvent()
  {
    FormUnallocatedExpenses.ClearScreenHandler clearScreenEvent = this.ClearScreenEvent;
    if (clearScreenEvent == null)
      return;
    clearScreenEvent((object) this, new EventArgs());
  }

  protected event FormUnallocatedExpenses.EditExpenseHandler EditExpenseEvent;

  protected void DoEditExpenseEvent()
  {
    FormUnallocatedExpenses.EditExpenseHandler editExpenseEvent = this.EditExpenseEvent;
    if (editExpenseEvent == null)
      return;
    editExpenseEvent((object) this, new EventArgs());
  }

  protected event FormUnallocatedExpenses.GridSelectedChangedHandler GridSelectedChangedEvent;

  protected virtual void OnGridSelectedChangedEvent()
  {
    if (((SparseCollectionBase) this.gridExpenseListing.Selected.Rows).Count > 0)
    {
      string s = this.gridExpenseListing.Selected.Rows[0].Cells["ExpenseId"].Value.ToString();
      this.ExpenseId = s.Length > 0 ? int.Parse(s) : 0;
    }
    FormUnallocatedExpenses.GridSelectedChangedHandler selectedChangedEvent = this.GridSelectedChangedEvent;
    if (selectedChangedEvent == null)
      return;
    selectedChangedEvent((object) this, new EventArgs());
  }

  private void gridExpenseListing_AfterSelectChange(object sender, AfterSelectChangeEventArgs e)
  {
    this.OnGridSelectedChangedEvent();
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
    Appearance appearance19 = new Appearance();
    Appearance appearance20 = new Appearance();
    Appearance appearance21 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("ExpenseList", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("ExpenseId");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("Expense");
    Appearance appearance22 = new Appearance();
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("HourlyCharged");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("HourlyRate");
    Appearance appearance23 = new Appearance();
    Appearance appearance24 = new Appearance();
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("AllowHourlyRateEdit");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("AutomatedHours");
    Appearance appearance25 = new Appearance();
    Appearance appearance26 = new Appearance();
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("MaximumHours");
    Appearance appearance27 = new Appearance();
    Appearance appearance28 = new Appearance();
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("EquipmentCharged");
    Appearance appearance29 = new Appearance();
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("EquipmentRate");
    Appearance appearance30 = new Appearance();
    Appearance appearance31 = new Appearance();
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("AllowEquipmentRateEdit");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("UnitAmountCharged");
    Appearance appearance32 = new Appearance();
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("UnitCost");
    Appearance appearance33 = new Appearance();
    Appearance appearance34 = new Appearance();
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("AllowUnitCostEdit");
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("AutomatedUnitCost");
    Appearance appearance35 = new Appearance();
    Appearance appearance36 = new Appearance();
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("UnitCostPrompt");
    Appearance appearance37 = new Appearance();
    Appearance appearance38 = new Appearance();
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("IsTax");
    Appearance appearance39 = new Appearance();
    Appearance appearance40 = new Appearance();
    Appearance appearance41 = new Appearance();
    Appearance appearance42 = new Appearance();
    Appearance appearance43 = new Appearance();
    Appearance appearance44 = new Appearance();
    ScrollBarLook scrollBarLook1 = new ScrollBarLook();
    Appearance appearance45 = new Appearance();
    Appearance appearance46 = new Appearance();
    UltraGridLayout ultraGridLayout = new UltraGridLayout("Layout1");
    Appearance appearance47 = new Appearance();
    UltraGridBand ultraGridBand2 = new UltraGridBand("ExpenseList", -1);
    UltraGridColumn ultraGridColumn17 = new UltraGridColumn("ExpenseId");
    UltraGridColumn ultraGridColumn18 = new UltraGridColumn("Expense");
    Appearance appearance48 = new Appearance();
    UltraGridColumn ultraGridColumn19 = new UltraGridColumn("HourlyCharged");
    UltraGridColumn ultraGridColumn20 = new UltraGridColumn("HourlyRate");
    Appearance appearance49 = new Appearance();
    Appearance appearance50 = new Appearance();
    UltraGridColumn ultraGridColumn21 = new UltraGridColumn("AllowHourlyRateEdit");
    UltraGridColumn ultraGridColumn22 = new UltraGridColumn("AutomatedHours");
    Appearance appearance51 = new Appearance();
    Appearance appearance52 = new Appearance();
    UltraGridColumn ultraGridColumn23 = new UltraGridColumn("MaximumHours");
    Appearance appearance53 = new Appearance();
    Appearance appearance54 = new Appearance();
    UltraGridColumn ultraGridColumn24 = new UltraGridColumn("EquipmentCharged");
    Appearance appearance55 = new Appearance();
    UltraGridColumn ultraGridColumn25 = new UltraGridColumn("EquipmentRate");
    Appearance appearance56 = new Appearance();
    Appearance appearance57 = new Appearance();
    UltraGridColumn ultraGridColumn26 = new UltraGridColumn("AllowEquipmentRateEdit");
    UltraGridColumn ultraGridColumn27 = new UltraGridColumn("UnitAmountCharged");
    Appearance appearance58 = new Appearance();
    UltraGridColumn ultraGridColumn28 = new UltraGridColumn("UnitCost");
    Appearance appearance59 = new Appearance();
    Appearance appearance60 = new Appearance();
    UltraGridColumn ultraGridColumn29 = new UltraGridColumn("AllowUnitCostEdit");
    UltraGridColumn ultraGridColumn30 = new UltraGridColumn("AutomatedUnitCost");
    Appearance appearance61 = new Appearance();
    Appearance appearance62 = new Appearance();
    UltraGridColumn ultraGridColumn31 = new UltraGridColumn("UnitCostPrompt");
    Appearance appearance63 = new Appearance();
    Appearance appearance64 = new Appearance();
    Appearance appearance65 = new Appearance();
    Appearance appearance66 = new Appearance();
    Appearance appearance67 = new Appearance();
    Appearance appearance68 = new Appearance();
    Appearance appearance69 = new Appearance();
    Appearance appearance70 = new Appearance();
    ScrollBarLook scrollBarLook2 = new ScrollBarLook();
    Appearance appearance71 = new Appearance();
    Appearance appearance72 = new Appearance();
    this.mgaGroupBox1 = new MGAGroupBox();
    this.dbSaveUI1 = new MGASystems.Tools.DBSaveUI.DBSaveUI();
    this.panelEdits = new Panel();
    this.checkIsTax = new MGACheckBox();
    this.expenseListBindingSource = new BindingSource(this.components);
    this.dsClaimExpenses1 = new dsClaimExpenses();
    this.textExpenseId = new MGATextBox();
    this.textUnit_AutomatedAmount = new MGAMaskedEdit();
    this.textUnit_MaxAmount = new MGAMaskedEdit();
    this.textUnit_UnitCost = new MGAMaskedEdit();
    this.textEquipmentRate = new MGAMaskedEdit();
    this.textHourly_AutomatedHours = new MGAMaskedEdit();
    this.textHourly_MaxHours = new MGAMaskedEdit();
    this.textHourlyRate = new MGAMaskedEdit();
    this.checkEquip_AllowEdit = new MGACheckBox();
    this.textUnit_DisplayPrompt = new MGATextBox();
    this.ultraLabel1 = new UltraLabel();
    this.ultraLabel9 = new UltraLabel();
    this.textExpenseName = new MGATextBox();
    this.checkUnit_Allowedit = new MGACheckBox();
    this.checkChargedHourly = new MGACheckBox();
    this.ultraLabel2 = new UltraLabel();
    this.ultraLabel3 = new UltraLabel();
    this.ultraLabel4 = new UltraLabel();
    this.ultraLabel5 = new UltraLabel();
    this.ultraLabel6 = new UltraLabel();
    this.ultraLabel8 = new UltraLabel();
    this.checkChargedPerUnit = new MGACheckBox();
    this.checkEquipmentCharges = new MGACheckBox();
    this.ultraLabel7 = new UltraLabel();
    this.checkHourly_AllowEdit = new MGACheckBox();
    this.sqlSelectCommand1 = new SqlCommand();
    this.sqlInsertCommand1 = new SqlCommand();
    this.sqlUpdateCommand1 = new SqlCommand();
    this.sqlDataAdapter1 = new SqlDataAdapter();
    this.sqlDeleteCommand = new SqlCommand();
    this.gridExpenseListing = new UltraGrid();
    ((ISupportInitialize) this.mgaGroupBox1).BeginInit();
    ((Control) this.mgaGroupBox1).SuspendLayout();
    this.panelEdits.SuspendLayout();
    ((ISupportInitialize) this.checkIsTax).BeginInit();
    ((ISupportInitialize) this.expenseListBindingSource).BeginInit();
    this.dsClaimExpenses1.BeginInit();
    ((ISupportInitialize) this.textExpenseId).BeginInit();
    ((ISupportInitialize) this.textUnit_AutomatedAmount).BeginInit();
    ((ISupportInitialize) this.textUnit_MaxAmount).BeginInit();
    ((ISupportInitialize) this.textUnit_UnitCost).BeginInit();
    ((ISupportInitialize) this.textEquipmentRate).BeginInit();
    ((ISupportInitialize) this.textHourly_AutomatedHours).BeginInit();
    ((ISupportInitialize) this.textHourly_MaxHours).BeginInit();
    ((ISupportInitialize) this.textHourlyRate).BeginInit();
    ((ISupportInitialize) this.checkEquip_AllowEdit).BeginInit();
    ((ISupportInitialize) this.textUnit_DisplayPrompt).BeginInit();
    ((ISupportInitialize) this.textExpenseName).BeginInit();
    ((ISupportInitialize) this.checkUnit_Allowedit).BeginInit();
    ((ISupportInitialize) this.checkChargedHourly).BeginInit();
    ((ISupportInitialize) this.checkChargedPerUnit).BeginInit();
    ((ISupportInitialize) this.checkEquipmentCharges).BeginInit();
    ((ISupportInitialize) this.checkHourly_AllowEdit).BeginInit();
    ((ISupportInitialize) this.gridExpenseListing).BeginInit();
    this.SuspendLayout();
    ((AppearanceBase) appearance1).BackColor = Color.Transparent;
    ((AppearanceBase) appearance1).ForeColor = Color.Black;
    ((UltraGroupBox) this.mgaGroupBox1).Appearance = (AppearanceBase) appearance1;
    ((AppearanceBase) appearance2).BackColor = Color.Transparent;
    ((AppearanceBase) appearance2).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGroupBox) this.mgaGroupBox1).ContentAreaAppearance = (AppearanceBase) appearance2;
    ((Control) this.mgaGroupBox1).Controls.Add((Control) this.dbSaveUI1);
    ((Control) this.mgaGroupBox1).Controls.Add((Control) this.panelEdits);
    ((Control) this.mgaGroupBox1).Dock = DockStyle.Bottom;
    ((AppearanceBase) appearance3).ForeColor = Color.Black;
    ((UltraGroupBox) this.mgaGroupBox1).HeaderAppearance = (AppearanceBase) appearance3;
    ((Control) this.mgaGroupBox1).Location = new Point(0, 315);
    ((Control) this.mgaGroupBox1).Name = "mgaGroupBox1";
    ((Control) this.mgaGroupBox1).Size = new Size(667, 242);
    ((Control) this.mgaGroupBox1).TabIndex = 1;
    ((Control) this.mgaGroupBox1).Text = "Expense Options";
    ((UltraGroupBox) this.mgaGroupBox1).ViewStyle = (GroupBoxViewStyle) 2;
    ((Control) this.dbSaveUI1).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.dbSaveUI1.EditStyle = (EditStyle) 1;
    this.dbSaveUI1.FreezeEvents = false;
    ((Control) this.dbSaveUI1).Location = new Point(543, 191);
    ((Control) this.dbSaveUI1).Name = "dbSaveUI1";
    ((Control) this.dbSaveUI1).Size = new Size(112 /*0x70*/, 40);
    ((Control) this.dbSaveUI1).TabIndex = 1;
    this.dbSaveUI1.UIState = (UIState) 1;
    this.dbSaveUI1.ClickedNew += new EventHandler(this.dbSaveUI1_ClickedNew);
    this.dbSaveUI1.ClickingSave += new CancelEventHandler(this.dbSaveUI1_ClickingSave);
    this.dbSaveUI1.ClickedSave += new EventHandler(this.dbSaveUI1_ClickedSave);
    this.dbSaveUI1.ClickedDelete += new EventHandler(this.dbSaveUI1_ClickedDelete);
    this.dbSaveUI1.ClickedCancel += new EventHandler(this.dbSaveUI1_ClickedCancel);
    this.dbSaveUI1.ClickedEdit += new EventHandler(this.dbSaveUI1_ClickedEdit);
    this.panelEdits.Controls.Add((Control) this.checkIsTax);
    this.panelEdits.Controls.Add((Control) this.textExpenseId);
    this.panelEdits.Controls.Add((Control) this.textUnit_AutomatedAmount);
    this.panelEdits.Controls.Add((Control) this.textUnit_MaxAmount);
    this.panelEdits.Controls.Add((Control) this.textUnit_UnitCost);
    this.panelEdits.Controls.Add((Control) this.textEquipmentRate);
    this.panelEdits.Controls.Add((Control) this.textHourly_AutomatedHours);
    this.panelEdits.Controls.Add((Control) this.textHourly_MaxHours);
    this.panelEdits.Controls.Add((Control) this.textHourlyRate);
    this.panelEdits.Controls.Add((Control) this.checkEquip_AllowEdit);
    this.panelEdits.Controls.Add((Control) this.textUnit_DisplayPrompt);
    this.panelEdits.Controls.Add((Control) this.ultraLabel1);
    this.panelEdits.Controls.Add((Control) this.ultraLabel9);
    this.panelEdits.Controls.Add((Control) this.textExpenseName);
    this.panelEdits.Controls.Add((Control) this.checkUnit_Allowedit);
    this.panelEdits.Controls.Add((Control) this.checkChargedHourly);
    this.panelEdits.Controls.Add((Control) this.ultraLabel2);
    this.panelEdits.Controls.Add((Control) this.ultraLabel3);
    this.panelEdits.Controls.Add((Control) this.ultraLabel4);
    this.panelEdits.Controls.Add((Control) this.ultraLabel5);
    this.panelEdits.Controls.Add((Control) this.ultraLabel6);
    this.panelEdits.Controls.Add((Control) this.ultraLabel8);
    this.panelEdits.Controls.Add((Control) this.checkChargedPerUnit);
    this.panelEdits.Controls.Add((Control) this.checkEquipmentCharges);
    this.panelEdits.Controls.Add((Control) this.ultraLabel7);
    this.panelEdits.Controls.Add((Control) this.checkHourly_AllowEdit);
    this.panelEdits.Enabled = false;
    this.panelEdits.Location = new Point(5, 22);
    this.panelEdits.Name = "panelEdits";
    this.panelEdits.Size = new Size(657, 215);
    this.panelEdits.TabIndex = 0;
    ((AppearanceBase) appearance4).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance4).ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.checkIsTax).Appearance = (AppearanceBase) appearance4;
    ((UltraToggleEditorBase) this.checkIsTax).CheckAlign = ContentAlignment.MiddleRight;
    ((Control) this.checkIsTax).DataBindings.Add(new Binding("Checked", (object) this.expenseListBindingSource, "IsTax", true));
    ((UltraToggleEditorBase) this.checkIsTax).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.StandardCheckBoxGlyphInfo;
    ((Control) this.checkIsTax).Location = new Point(592, 6);
    this.checkIsTax.MGAStyle = (MGAStyles) 2;
    ((Control) this.checkIsTax).Name = "checkIsTax";
    ((Control) this.checkIsTax).Size = new Size(58, 20);
    ((Control) this.checkIsTax).TabIndex = 25;
    ((Control) this.checkIsTax).Text = "Is Tax?";
    ((UltraControlBase) this.checkIsTax).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.checkIsTax).UseOsThemes = (DefaultableBoolean) 2;
    this.expenseListBindingSource.DataMember = "ExpenseList";
    this.expenseListBindingSource.DataSource = (object) this.dsClaimExpenses1;
    this.dsClaimExpenses1.DataSetName = "dsClaimExpenses";
    this.dsClaimExpenses1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((AppearanceBase) appearance5).BackColor = Color.White;
    ((AppearanceBase) appearance5).BorderColor = Color.Gray;
    ((AppearanceBase) appearance5).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textExpenseId).Appearance = (AppearanceBase) appearance5;
    ((Control) this.textExpenseId).BackColor = Color.White;
    ((Control) this.textExpenseId).DataBindings.Add(new Binding("Value", (object) this.expenseListBindingSource, "ExpenseId", true));
    ((Control) this.textExpenseId).Location = new Point(680, 32 /*0x20*/);
    ((Control) this.textExpenseId).Name = "textExpenseId";
    ((Control) this.textExpenseId).Size = new Size(19, 20);
    ((Control) this.textExpenseId).TabIndex = 24;
    ((UltraControlBase) this.textExpenseId).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textExpenseId).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance6).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance6).TextHAlignAsString = "Right";
    ((UltraMaskedEdit) this.textUnit_AutomatedAmount).Appearance = (AppearanceBase) appearance6;
    ((Control) this.textUnit_AutomatedAmount).DataBindings.Add(new Binding("Value", (object) this.expenseListBindingSource, "AutomatedUnitCost", true));
    ((UltraMaskedEdit) this.textUnit_AutomatedAmount).EditAs = (EditAsType) 7;
    ((Control) this.textUnit_AutomatedAmount).Location = new Point(406, 135);
    this.textUnit_AutomatedAmount.MGAStyle = (MGAStyles) 2;
    ((UltraMaskedEdit) this.textUnit_AutomatedAmount).MinValue = (object) new Decimal(new int[4]);
    ((Control) this.textUnit_AutomatedAmount).Name = "textUnit_AutomatedAmount";
    ((UltraMaskedEdit) this.textUnit_AutomatedAmount).NonAutoSizeHeight = 20;
    ((Control) this.textUnit_AutomatedAmount).Size = new Size(88, 21);
    ((Control) this.textUnit_AutomatedAmount).TabIndex = 23;
    ((UltraControlBase) this.textUnit_AutomatedAmount).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textUnit_AutomatedAmount).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance7).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance7).TextHAlignAsString = "Right";
    ((UltraMaskedEdit) this.textUnit_MaxAmount).Appearance = (AppearanceBase) appearance7;
    ((UltraMaskedEdit) this.textUnit_MaxAmount).EditAs = (EditAsType) 7;
    ((Control) this.textUnit_MaxAmount).Location = new Point(406, 113);
    this.textUnit_MaxAmount.MGAStyle = (MGAStyles) 2;
    ((UltraMaskedEdit) this.textUnit_MaxAmount).MinValue = (object) new Decimal(new int[4]);
    ((Control) this.textUnit_MaxAmount).Name = "textUnit_MaxAmount";
    ((UltraMaskedEdit) this.textUnit_MaxAmount).NonAutoSizeHeight = 20;
    ((Control) this.textUnit_MaxAmount).Size = new Size(88, 21);
    ((Control) this.textUnit_MaxAmount).TabIndex = 21;
    ((UltraControlBase) this.textUnit_MaxAmount).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textUnit_MaxAmount).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance8).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance8).TextHAlignAsString = "Right";
    ((UltraMaskedEdit) this.textUnit_UnitCost).Appearance = (AppearanceBase) appearance8;
    ((Control) this.textUnit_UnitCost).DataBindings.Add(new Binding("Value", (object) this.expenseListBindingSource, "UnitCost", true));
    ((UltraMaskedEdit) this.textUnit_UnitCost).EditAs = (EditAsType) 2;
    ((Control) this.textUnit_UnitCost).Location = new Point(406, 91);
    this.textUnit_UnitCost.MGAStyle = (MGAStyles) 2;
    ((UltraMaskedEdit) this.textUnit_UnitCost).MinValue = (object) new Decimal(new int[4]);
    ((Control) this.textUnit_UnitCost).Name = "textUnit_UnitCost";
    ((UltraMaskedEdit) this.textUnit_UnitCost).NonAutoSizeHeight = 20;
    ((Control) this.textUnit_UnitCost).Size = new Size(88, 21);
    ((Control) this.textUnit_UnitCost).TabIndex = 18;
    ((Control) this.textUnit_UnitCost).Text = "$";
    ((UltraControlBase) this.textUnit_UnitCost).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textUnit_UnitCost).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance9).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance9).TextHAlignAsString = "Right";
    ((UltraMaskedEdit) this.textEquipmentRate).Appearance = (AppearanceBase) appearance9;
    ((Control) this.textEquipmentRate).DataBindings.Add(new Binding("Value", (object) this.expenseListBindingSource, "EquipmentRate", true));
    ((UltraMaskedEdit) this.textEquipmentRate).EditAs = (EditAsType) 2;
    ((Control) this.textEquipmentRate).Location = new Point(113, 176 /*0xB0*/);
    this.textEquipmentRate.MGAStyle = (MGAStyles) 2;
    ((UltraMaskedEdit) this.textEquipmentRate).MinValue = (object) new Decimal(new int[4]);
    ((Control) this.textEquipmentRate).Name = "textEquipmentRate";
    ((UltraMaskedEdit) this.textEquipmentRate).NonAutoSizeHeight = 20;
    ((Control) this.textEquipmentRate).Size = new Size(97, 21);
    ((Control) this.textEquipmentRate).TabIndex = 12;
    ((Control) this.textEquipmentRate).Text = "$";
    ((UltraControlBase) this.textEquipmentRate).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textEquipmentRate).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance10).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance10).TextHAlignAsString = "Right";
    ((UltraMaskedEdit) this.textHourly_AutomatedHours).Appearance = (AppearanceBase) appearance10;
    ((Control) this.textHourly_AutomatedHours).DataBindings.Add(new Binding("Value", (object) this.expenseListBindingSource, "AutomatedHours", true));
    ((UltraMaskedEdit) this.textHourly_AutomatedHours).EditAs = (EditAsType) 7;
    ((Control) this.textHourly_AutomatedHours).Location = new Point(113, 115);
    this.textHourly_AutomatedHours.MGAStyle = (MGAStyles) 2;
    ((UltraMaskedEdit) this.textHourly_AutomatedHours).MinValue = (object) new Decimal(new int[4]);
    ((Control) this.textHourly_AutomatedHours).Name = "textHourly_AutomatedHours";
    ((UltraMaskedEdit) this.textHourly_AutomatedHours).NonAutoSizeHeight = 20;
    ((Control) this.textHourly_AutomatedHours).Size = new Size(97, 21);
    ((Control) this.textHourly_AutomatedHours).TabIndex = 9;
    ((UltraControlBase) this.textHourly_AutomatedHours).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textHourly_AutomatedHours).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance11).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance11).TextHAlignAsString = "Right";
    ((UltraMaskedEdit) this.textHourly_MaxHours).Appearance = (AppearanceBase) appearance11;
    ((Control) this.textHourly_MaxHours).DataBindings.Add(new Binding("Value", (object) this.expenseListBindingSource, "MaximumHours", true));
    ((UltraMaskedEdit) this.textHourly_MaxHours).EditAs = (EditAsType) 7;
    ((Control) this.textHourly_MaxHours).Location = new Point(113, 93);
    this.textHourly_MaxHours.MGAStyle = (MGAStyles) 2;
    ((UltraMaskedEdit) this.textHourly_MaxHours).MinValue = (object) new Decimal(new int[4]);
    ((Control) this.textHourly_MaxHours).Name = "textHourly_MaxHours";
    ((UltraMaskedEdit) this.textHourly_MaxHours).NonAutoSizeHeight = 20;
    ((Control) this.textHourly_MaxHours).Size = new Size(97, 21);
    ((Control) this.textHourly_MaxHours).TabIndex = 7;
    ((UltraControlBase) this.textHourly_MaxHours).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textHourly_MaxHours).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance12).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance12).TextHAlignAsString = "Right";
    ((UltraMaskedEdit) this.textHourlyRate).Appearance = (AppearanceBase) appearance12;
    ((Control) this.textHourlyRate).DataBindings.Add(new Binding("Value", (object) this.expenseListBindingSource, "HourlyRate", true));
    ((UltraMaskedEdit) this.textHourlyRate).DataMode = (MaskMode) 0;
    ((UltraMaskedEdit) this.textHourlyRate).EditAs = (EditAsType) 2;
    ((Control) this.textHourlyRate).Location = new Point(113, 71);
    this.textHourlyRate.MGAStyle = (MGAStyles) 2;
    ((UltraMaskedEdit) this.textHourlyRate).MinValue = (object) new Decimal(new int[4]
    {
      0,
      0,
      0,
      131072 /*0x020000*/
    });
    ((Control) this.textHourlyRate).Name = "textHourlyRate";
    ((UltraMaskedEdit) this.textHourlyRate).NonAutoSizeHeight = 20;
    ((Control) this.textHourlyRate).Size = new Size(97, 21);
    ((Control) this.textHourlyRate).TabIndex = 4;
    ((UltraControlBase) this.textHourlyRate).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textHourlyRate).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance13).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance13).ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.checkEquip_AllowEdit).Appearance = (AppearanceBase) appearance13;
    ((Control) this.checkEquip_AllowEdit).DataBindings.Add(new Binding("Checked", (object) this.expenseListBindingSource, "AllowEquipmentRateEdit", true));
    ((UltraToggleEditorBase) this.checkEquip_AllowEdit).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.checkEquip_AllowEdit).Location = new Point(216, 176 /*0xB0*/);
    this.checkEquip_AllowEdit.MGAStyle = (MGAStyles) 2;
    ((Control) this.checkEquip_AllowEdit).Name = "checkEquip_AllowEdit";
    ((Control) this.checkEquip_AllowEdit).Size = new Size(97, 20);
    ((Control) this.checkEquip_AllowEdit).TabIndex = 13;
    ((Control) this.checkEquip_AllowEdit).Text = "Allow Edit?";
    ((UltraControlBase) this.checkEquip_AllowEdit).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.checkEquip_AllowEdit).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance14).BackColor = Color.White;
    ((AppearanceBase) appearance14).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance14).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textUnit_DisplayPrompt).Appearance = (AppearanceBase) appearance14;
    ((Control) this.textUnit_DisplayPrompt).BackColor = Color.White;
    ((Control) this.textUnit_DisplayPrompt).DataBindings.Add(new Binding("Value", (object) this.expenseListBindingSource, "UnitCostPrompt", true));
    ((Control) this.textUnit_DisplayPrompt).Location = new Point(406, 69);
    this.textUnit_DisplayPrompt.MGAStyle = (MGAStyles) 2;
    ((Control) this.textUnit_DisplayPrompt).Name = "textUnit_DisplayPrompt";
    ((Control) this.textUnit_DisplayPrompt).Size = new Size(246, 20);
    ((Control) this.textUnit_DisplayPrompt).TabIndex = 16 /*0x10*/;
    ((UltraControlBase) this.textUnit_DisplayPrompt).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textUnit_DisplayPrompt).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.ultraLabel1).AutoSize = true;
    ((Control) this.ultraLabel1).Location = new Point(15, 9);
    ((Control) this.ultraLabel1).Name = "ultraLabel1";
    ((Control) this.ultraLabel1).Size = new Size(50, 15);
    ((Control) this.ultraLabel1).TabIndex = 0;
    ((Control) this.ultraLabel1).Text = "Expense:";
    ((Control) this.ultraLabel9).AutoSize = true;
    ((Control) this.ultraLabel9).Location = new Point(305, 69);
    ((Control) this.ultraLabel9).Name = "ultraLabel9";
    ((Control) this.ultraLabel9).Size = new Size(75, 15);
    ((Control) this.ultraLabel9).TabIndex = 15;
    ((Control) this.ultraLabel9).Text = "Display Value:";
    ((AppearanceBase) appearance15).BackColor = Color.White;
    ((AppearanceBase) appearance15).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance15).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textExpenseName).Appearance = (AppearanceBase) appearance15;
    ((Control) this.textExpenseName).BackColor = Color.White;
    ((Control) this.textExpenseName).DataBindings.Add(new Binding("Value", (object) this.expenseListBindingSource, "Expense", true));
    ((Control) this.textExpenseName).Location = new Point(113, 9);
    this.textExpenseName.MGAStyle = (MGAStyles) 2;
    ((Control) this.textExpenseName).Name = "textExpenseName";
    ((Control) this.textExpenseName).Size = new Size(315, 20);
    ((Control) this.textExpenseName).TabIndex = 1;
    ((UltraControlBase) this.textExpenseName).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textExpenseName).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance16).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance16).ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.checkUnit_Allowedit).Appearance = (AppearanceBase) appearance16;
    ((Control) this.checkUnit_Allowedit).DataBindings.Add(new Binding("Checked", (object) this.expenseListBindingSource, "AllowUnitCostEdit", true));
    ((UltraToggleEditorBase) this.checkUnit_Allowedit).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.StandardCheckBoxGlyphInfo;
    ((Control) this.checkUnit_Allowedit).Location = new Point(500, 89);
    this.checkUnit_Allowedit.MGAStyle = (MGAStyles) 2;
    ((Control) this.checkUnit_Allowedit).Name = "checkUnit_Allowedit";
    ((Control) this.checkUnit_Allowedit).Size = new Size(120, 20);
    ((Control) this.checkUnit_Allowedit).TabIndex = 19;
    ((Control) this.checkUnit_Allowedit).Text = "Allow User Edit?";
    ((UltraControlBase) this.checkUnit_Allowedit).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.checkUnit_Allowedit).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance17).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance17).ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.checkChargedHourly).Appearance = (AppearanceBase) appearance17;
    ((Control) this.checkChargedHourly).DataBindings.Add(new Binding("Checked", (object) this.expenseListBindingSource, "HourlyCharged", true));
    ((UltraToggleEditorBase) this.checkChargedHourly).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.StandardCheckBoxGlyphInfo;
    ((Control) this.checkChargedHourly).Location = new Point(15, 46);
    this.checkChargedHourly.MGAStyle = (MGAStyles) 2;
    ((Control) this.checkChargedHourly).Name = "checkChargedHourly";
    ((Control) this.checkChargedHourly).Size = new Size(120, 20);
    ((Control) this.checkChargedHourly).TabIndex = 2;
    ((Control) this.checkChargedHourly).Text = "Charged Hourly?";
    ((UltraControlBase) this.checkChargedHourly).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.checkChargedHourly).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraToggleEditorBase) this.checkChargedHourly).CheckedChanged += new EventHandler(this.CheckedChangedHandler);
    ((Control) this.ultraLabel2).AutoSize = true;
    ((Control) this.ultraLabel2).Location = new Point(12, 72);
    ((Control) this.ultraLabel2).Name = "ultraLabel2";
    ((Control) this.ultraLabel2).Size = new Size(67, 15);
    ((Control) this.ultraLabel2).TabIndex = 3;
    ((Control) this.ultraLabel2).Text = "Hourly Rate:";
    ((Control) this.ultraLabel3).AutoSize = true;
    ((Control) this.ultraLabel3).Location = new Point(12, 94);
    ((Control) this.ultraLabel3).Name = "ultraLabel3";
    ((Control) this.ultraLabel3).Size = new Size(65, 15);
    ((Control) this.ultraLabel3).TabIndex = 6;
    ((Control) this.ultraLabel3).Text = "Max. Hours:";
    ((Control) this.ultraLabel4).AutoSize = true;
    ((Control) this.ultraLabel4).Location = new Point(12, 115);
    ((Control) this.ultraLabel4).Name = "ultraLabel4";
    ((Control) this.ultraLabel4).Size = new Size(95, 15);
    ((Control) this.ultraLabel4).TabIndex = 8;
    ((Control) this.ultraLabel4).Text = "Automated Hours:";
    ((Control) this.ultraLabel5).AutoSize = true;
    ((Control) this.ultraLabel5).Location = new Point(305, 133);
    ((Control) this.ultraLabel5).Name = "ultraLabel5";
    ((Control) this.ultraLabel5).Size = new Size(90, 15);
    ((Control) this.ultraLabel5).TabIndex = 22;
    ((Control) this.ultraLabel5).Text = "Automated Amt.:";
    ((Control) this.ultraLabel6).AutoSize = true;
    ((Control) this.ultraLabel6).Location = new Point(305, 112 /*0x70*/);
    ((Control) this.ultraLabel6).Name = "ultraLabel6";
    ((Control) this.ultraLabel6).Size = new Size(74, 15);
    ((Control) this.ultraLabel6).TabIndex = 20;
    ((Control) this.ultraLabel6).Text = "Max. Amount:";
    ((Control) this.ultraLabel8).AutoSize = true;
    ((Control) this.ultraLabel8).Location = new Point(305, 91);
    ((Control) this.ultraLabel8).Name = "ultraLabel8";
    ((Control) this.ultraLabel8).Size = new Size(54, 15);
    ((Control) this.ultraLabel8).TabIndex = 17;
    ((Control) this.ultraLabel8).Text = "Unit Cost:";
    ((AppearanceBase) appearance18).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance18).ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.checkChargedPerUnit).Appearance = (AppearanceBase) appearance18;
    ((Control) this.checkChargedPerUnit).DataBindings.Add(new Binding("Checked", (object) this.expenseListBindingSource, "UnitAmountCharged", true));
    ((UltraToggleEditorBase) this.checkChargedPerUnit).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.StandardCheckBoxGlyphInfo;
    ((Control) this.checkChargedPerUnit).Location = new Point(308, 46);
    this.checkChargedPerUnit.MGAStyle = (MGAStyles) 2;
    ((Control) this.checkChargedPerUnit).Name = "checkChargedPerUnit";
    ((Control) this.checkChargedPerUnit).Size = new Size(120, 20);
    ((Control) this.checkChargedPerUnit).TabIndex = 14;
    ((Control) this.checkChargedPerUnit).Text = "Charged Per Unit?";
    ((UltraControlBase) this.checkChargedPerUnit).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.checkChargedPerUnit).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraToggleEditorBase) this.checkChargedPerUnit).CheckedChanged += new EventHandler(this.CheckedChangedHandler);
    ((AppearanceBase) appearance19).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance19).ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.checkEquipmentCharges).Appearance = (AppearanceBase) appearance19;
    ((Control) this.checkEquipmentCharges).DataBindings.Add(new Binding("Checked", (object) this.expenseListBindingSource, "EquipmentCharged", true));
    ((UltraToggleEditorBase) this.checkEquipmentCharges).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.StandardCheckBoxGlyphInfo;
    ((Control) this.checkEquipmentCharges).Location = new Point(15, 150);
    this.checkEquipmentCharges.MGAStyle = (MGAStyles) 2;
    ((Control) this.checkEquipmentCharges).Name = "checkEquipmentCharges";
    ((Control) this.checkEquipmentCharges).Size = new Size(178, 20);
    ((Control) this.checkEquipmentCharges).TabIndex = 10;
    ((Control) this.checkEquipmentCharges).Text = "Equipment Charges?";
    ((UltraControlBase) this.checkEquipmentCharges).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.checkEquipmentCharges).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraToggleEditorBase) this.checkEquipmentCharges).CheckedChanged += new EventHandler(this.CheckedChangedHandler);
    ((Control) this.ultraLabel7).AutoSize = true;
    ((Control) this.ultraLabel7).Location = new Point(12, 176 /*0xB0*/);
    ((Control) this.ultraLabel7).Name = "ultraLabel7";
    ((Control) this.ultraLabel7).Size = new Size(88, 15);
    ((Control) this.ultraLabel7).TabIndex = 11;
    ((Control) this.ultraLabel7).Text = "Equipment Rate:";
    ((AppearanceBase) appearance20).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance20).ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.checkHourly_AllowEdit).Appearance = (AppearanceBase) appearance20;
    ((Control) this.checkHourly_AllowEdit).DataBindings.Add(new Binding("Checked", (object) this.expenseListBindingSource, "AllowHourlyRateEdit", true));
    ((UltraToggleEditorBase) this.checkHourly_AllowEdit).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.StandardCheckBoxGlyphInfo;
    ((Control) this.checkHourly_AllowEdit).Location = new Point(216, 73);
    this.checkHourly_AllowEdit.MGAStyle = (MGAStyles) 2;
    ((Control) this.checkHourly_AllowEdit).Name = "checkHourly_AllowEdit";
    ((Control) this.checkHourly_AllowEdit).Size = new Size(97, 20);
    ((Control) this.checkHourly_AllowEdit).TabIndex = 5;
    ((Control) this.checkHourly_AllowEdit).Text = "Allow Edit?";
    ((UltraControlBase) this.checkHourly_AllowEdit).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.checkHourly_AllowEdit).UseOsThemes = (DefaultableBoolean) 2;
    this.sqlSelectCommand1.CommandText = "dbo.spClaims_GetExpenseList";
    this.sqlSelectCommand1.CommandType = CommandType.StoredProcedure;
    this.sqlSelectCommand1.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null)
    });
    this.sqlInsertCommand1.CommandText = "dbo.spClaims_InsertExpense";
    this.sqlInsertCommand1.CommandType = CommandType.StoredProcedure;
    this.sqlInsertCommand1.Parameters.AddRange(new SqlParameter[16 /*0x10*/]
    {
      new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null),
      new SqlParameter("@Expense", SqlDbType.VarChar, 150, "Expense"),
      new SqlParameter("@HourlyCharged", SqlDbType.Bit, 1, "HourlyCharged"),
      new SqlParameter("@HourlyRate", SqlDbType.Money, 8, "HourlyRate"),
      new SqlParameter("@AllowHourlyrateEdit", SqlDbType.Bit, 1, "AllowHourlyRateEdit"),
      new SqlParameter("@AutomatedHours", SqlDbType.Decimal, 9, ParameterDirection.Input, false, (byte) 10, (byte) 2, "AutomatedHours", DataRowVersion.Current, (object) null),
      new SqlParameter("@MaximumHours", SqlDbType.Decimal, 9, ParameterDirection.Input, false, (byte) 10, (byte) 2, "MaximumHours", DataRowVersion.Current, (object) null),
      new SqlParameter("@EquipmentCharged", SqlDbType.Bit, 1, "EquipmentCharged"),
      new SqlParameter("@EquipmentRate", SqlDbType.Money, 8, "EquipmentRate"),
      new SqlParameter("@AllowEquipmentRateEdit", SqlDbType.Bit, 1, "AllowEquipmentRateEdit"),
      new SqlParameter("@UnitAmountCharged", SqlDbType.Bit, 1, "UnitAmountCharged"),
      new SqlParameter("@UnitCost", SqlDbType.Money, 8, "UnitCost"),
      new SqlParameter("@AllowUnitCostEdit", SqlDbType.Bit, 1, "AllowUnitCostEdit"),
      new SqlParameter("@AutomatedUnitCost", SqlDbType.Decimal, 5, ParameterDirection.Input, false, (byte) 8, (byte) 2, "AutomatedUnitCost", DataRowVersion.Current, (object) null),
      new SqlParameter("@UnitCostPrompt", SqlDbType.VarChar, 75, "UnitCostPrompt"),
      new SqlParameter("@IsTax", SqlDbType.NVarChar, 0, "IsTax")
    });
    this.sqlUpdateCommand1.CommandText = "dbo.spClaims_UpdateExpense";
    this.sqlUpdateCommand1.CommandType = CommandType.StoredProcedure;
    this.sqlUpdateCommand1.Parameters.AddRange(new SqlParameter[17]
    {
      new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null),
      new SqlParameter("@ExpenseId", SqlDbType.Int, 4, "ExpenseId"),
      new SqlParameter("@Expense", SqlDbType.VarChar, 150, "Expense"),
      new SqlParameter("@HourlyCharged", SqlDbType.Bit, 1, "HourlyCharged"),
      new SqlParameter("@HourlyRate", SqlDbType.Money, 8, "HourlyRate"),
      new SqlParameter("@AllowHourlyRateEdit", SqlDbType.Bit, 1, "AllowHourlyRateEdit"),
      new SqlParameter("@AutomatedHours", SqlDbType.Decimal, 9, ParameterDirection.Input, false, (byte) 10, (byte) 2, "AutomatedHours", DataRowVersion.Current, (object) null),
      new SqlParameter("@MaximumHours", SqlDbType.Decimal, 9, ParameterDirection.Input, false, (byte) 10, (byte) 2, "MaximumHours", DataRowVersion.Current, (object) null),
      new SqlParameter("@EquipmentCharged", SqlDbType.Bit, 1, "EquipmentCharged"),
      new SqlParameter("@EquipmentRate", SqlDbType.Money, 8, "EquipmentRate"),
      new SqlParameter("@AllowEquipmentRateEdit", SqlDbType.Bit, 1, "AllowEquipmentRateEdit"),
      new SqlParameter("@UnitAmountCharged", SqlDbType.Bit, 1, "UnitAmountCharged"),
      new SqlParameter("@UnitCost", SqlDbType.Money, 8, "UnitCost"),
      new SqlParameter("@AllowUnitCostEdit", SqlDbType.Bit, 1, "AllowUnitCostEdit"),
      new SqlParameter("@AutomatedUnitCost", SqlDbType.Decimal, 5, ParameterDirection.Input, false, (byte) 8, (byte) 2, "AutomatedUnitCost", DataRowVersion.Current, (object) null),
      new SqlParameter("@UnitCostPrompt", SqlDbType.VarChar, 75, "UnitCostPrompt"),
      new SqlParameter("@IsTax", SqlDbType.NVarChar, 0, "IsTax")
    });
    this.sqlDataAdapter1.DeleteCommand = this.sqlDeleteCommand;
    this.sqlDataAdapter1.InsertCommand = this.sqlInsertCommand1;
    this.sqlDataAdapter1.SelectCommand = this.sqlSelectCommand1;
    this.sqlDataAdapter1.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "spClaims_GetExpenseList", new DataColumnMapping[15]
      {
        new DataColumnMapping("ExpenseId", "ExpenseId"),
        new DataColumnMapping("Expense", "Expense"),
        new DataColumnMapping("HourlyCharged", "HourlyCharged"),
        new DataColumnMapping("HourlyRate", "HourlyRate"),
        new DataColumnMapping("AllowHourlyRateEdit", "AllowHourlyRateEdit"),
        new DataColumnMapping("AutomatedHours", "AutomatedHours"),
        new DataColumnMapping("MaximumHours", "MaximumHours"),
        new DataColumnMapping("EquipmentCharged", "EquipmentCharged"),
        new DataColumnMapping("EquipmentRate", "EquipmentRate"),
        new DataColumnMapping("AllowEquipmentRateEdit", "AllowEquipmentRateEdit"),
        new DataColumnMapping("UnitAmountCharged", "UnitAmountCharged"),
        new DataColumnMapping("UnitCost", "UnitCost"),
        new DataColumnMapping("AllowUnitCostEdit", "AllowUnitCostEdit"),
        new DataColumnMapping("AutomatedUnitCost", "AutomatedUnitCost"),
        new DataColumnMapping("UnitCostPrompt", "UnitCostPrompt")
      })
    });
    this.sqlDataAdapter1.UpdateCommand = this.sqlUpdateCommand1;
    this.sqlDeleteCommand.CommandText = "dbo.spClaims_DeleteExpense";
    this.sqlDeleteCommand.CommandType = CommandType.StoredProcedure;
    this.sqlDeleteCommand.Parameters.AddRange(new SqlParameter[2]
    {
      new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null),
      new SqlParameter("@ExpenseId", SqlDbType.Int, 4, "ExpenseId")
    });
    ((UltraGridBase) this.gridExpenseListing).DataSource = (object) this.expenseListBindingSource;
    ((AppearanceBase) appearance21).BackColor = Color.White;
    ((AppearanceBase) appearance21).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridExpenseListing).DisplayLayout.Appearance = (AppearanceBase) appearance21;
    ((UltraGridBase) this.gridExpenseListing).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn1.Header).VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 32 /*0x20*/;
    ((AppearanceBase) appearance22).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn2.Header).Appearance = (AppearanceBase) appearance22;
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn2.Header).VisiblePosition = 1;
    ultraGridColumn2.Width = 263;
    ((HeaderBase) ultraGridColumn3.Header).Caption = "Charged Hourly?";
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn3.Header).VisiblePosition = 2;
    ultraGridColumn3.Width = 108;
    ((AppearanceBase) appearance23).TextHAlignAsString = "Right";
    ultraGridColumn4.CellAppearance = (AppearanceBase) appearance23;
    ((AppearanceBase) appearance24).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn4.Header).Appearance = (AppearanceBase) appearance24;
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn4.Header).VisiblePosition = 3;
    ultraGridColumn4.Hidden = true;
    ultraGridColumn4.Width = 52;
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn5.Header).VisiblePosition = 4;
    ultraGridColumn5.Hidden = true;
    ultraGridColumn5.Width = 82;
    ((AppearanceBase) appearance25).TextHAlignAsString = "Right";
    ultraGridColumn6.CellAppearance = (AppearanceBase) appearance25;
    ((AppearanceBase) appearance26).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn6.Header).Appearance = (AppearanceBase) appearance26;
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn6.Header).VisiblePosition = 5;
    ultraGridColumn6.Hidden = true;
    ultraGridColumn6.Width = 87;
    ((AppearanceBase) appearance27).TextHAlignAsString = "Right";
    ultraGridColumn7.CellAppearance = (AppearanceBase) appearance27;
    ((AppearanceBase) appearance28).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn7.Header).Appearance = (AppearanceBase) appearance28;
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn7.Header).VisiblePosition = 6;
    ultraGridColumn7.Hidden = true;
    ultraGridColumn7.Width = 99;
    ((AppearanceBase) appearance29).TextHAlignAsString = "Center";
    ((HeaderBase) ultraGridColumn8.Header).Appearance = (AppearanceBase) appearance29;
    ((HeaderBase) ultraGridColumn8.Header).Caption = "Cost For Equipment?";
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn8.Header).VisiblePosition = 7;
    ultraGridColumn8.Width = 103;
    ((AppearanceBase) appearance30).TextHAlignAsString = "Right";
    ultraGridColumn9.CellAppearance = (AppearanceBase) appearance30;
    ((AppearanceBase) appearance31).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn9.Header).Appearance = (AppearanceBase) appearance31;
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn9.Header).VisiblePosition = 8;
    ultraGridColumn9.Hidden = true;
    ultraGridColumn9.Width = 66;
    ((HeaderBase) ultraGridColumn10.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn10.Header).VisiblePosition = 9;
    ultraGridColumn10.Hidden = true;
    ultraGridColumn10.Width = 114;
    ((AppearanceBase) appearance32).TextHAlignAsString = "Center";
    ((HeaderBase) ultraGridColumn11.Header).Appearance = (AppearanceBase) appearance32;
    ((HeaderBase) ultraGridColumn11.Header).Caption = "Cost Per Unit?";
    ((HeaderBase) ultraGridColumn11.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn11.Header).VisiblePosition = 10;
    ultraGridColumn11.Width = 104;
    ((AppearanceBase) appearance33).TextHAlignAsString = "Right";
    ultraGridColumn12.CellAppearance = (AppearanceBase) appearance33;
    ((AppearanceBase) appearance34).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn12.Header).Appearance = (AppearanceBase) appearance34;
    ((HeaderBase) ultraGridColumn12.Header).Caption = "Unit Cost";
    ((HeaderBase) ultraGridColumn12.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn12.Header).VisiblePosition = 11;
    ultraGridColumn12.Hidden = true;
    ultraGridColumn12.Width = 71;
    ((HeaderBase) ultraGridColumn13.Header).Caption = "Unit Cost Edit";
    ((HeaderBase) ultraGridColumn13.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn13.Header).VisiblePosition = 12;
    ultraGridColumn13.Hidden = true;
    ultraGridColumn13.Width = 104;
    ((AppearanceBase) appearance35).TextHAlignAsString = "Right";
    ultraGridColumn14.CellAppearance = (AppearanceBase) appearance35;
    ((AppearanceBase) appearance36).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn14.Header).Appearance = (AppearanceBase) appearance36;
    ((HeaderBase) ultraGridColumn14.Header).Caption = "Automated Unit Cost";
    ((HeaderBase) ultraGridColumn14.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn14.Header).VisiblePosition = 13;
    ultraGridColumn14.Hidden = true;
    ultraGridColumn14.Width = 126;
    ((AppearanceBase) appearance37).TextHAlignAsString = "Left";
    ultraGridColumn15.CellAppearance = (AppearanceBase) appearance37;
    ((AppearanceBase) appearance38).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn15.Header).Appearance = (AppearanceBase) appearance38;
    ((HeaderBase) ultraGridColumn15.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn15.Header).VisiblePosition = 14;
    ultraGridColumn15.Hidden = true;
    ultraGridColumn15.Width = 135;
    ((HeaderBase) ultraGridColumn16.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn16.Header).VisiblePosition = 15;
    ultraGridColumn16.Width = 87;
    ultraGridBand1.Columns.AddRange(new object[16 /*0x10*/]
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
      (object) ultraGridColumn14,
      (object) ultraGridColumn15,
      (object) ultraGridColumn16
    });
    ultraGridBand1.GroupHeadersVisible = false;
    ((UltraGridBase) this.gridExpenseListing).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.gridExpenseListing).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance39).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance39).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance39).ForeColor = Color.Black;
    ((UltraGridBase) this.gridExpenseListing).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance39;
    ((UltraGridBase) this.gridExpenseListing).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridExpenseListing).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridExpenseListing).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance40).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridExpenseListing).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance40;
    ((UltraGridBase) this.gridExpenseListing).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance41).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.gridExpenseListing).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance41;
    ((UltraGridBase) this.gridExpenseListing).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance42).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridExpenseListing).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance42;
    ((AppearanceBase) appearance43).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridExpenseListing).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance43;
    ((UltraGridBase) this.gridExpenseListing).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance44).BackColor = Color.Transparent;
    ((AppearanceBase) appearance44).ForeColor = Color.Black;
    ((UltraGridBase) this.gridExpenseListing).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance44;
    ((AppearanceBase) appearance45).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance45).BorderColor = Color.Silver;
    scrollBarLook1.ButtonAppearance = (AppearanceBase) appearance45;
    ((AppearanceBase) appearance46).BackColor = Color.White;
    scrollBarLook1.TrackAppearance = (AppearanceBase) appearance46;
    ((UltraGridBase) this.gridExpenseListing).DisplayLayout.ScrollBarLook = scrollBarLook1;
    ((Control) this.gridExpenseListing).Dock = DockStyle.Fill;
    ((AppearanceBase) appearance47).BackColor = Color.White;
    ((AppearanceBase) appearance47).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ultraGridLayout.Appearance = (AppearanceBase) appearance47;
    ultraGridLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((HeaderBase) ultraGridColumn17.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn17.Header).VisiblePosition = 0;
    ultraGridColumn17.Hidden = true;
    ultraGridColumn17.Width = 32 /*0x20*/;
    ((AppearanceBase) appearance48).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn18.Header).Appearance = (AppearanceBase) appearance48;
    ((HeaderBase) ultraGridColumn18.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn18.Header).VisiblePosition = 1;
    ultraGridColumn18.Width = 308;
    ((HeaderBase) ultraGridColumn19.Header).Caption = "Charged Hourly?";
    ((HeaderBase) ultraGridColumn19.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn19.Header).VisiblePosition = 2;
    ultraGridColumn19.Width = 119;
    ((AppearanceBase) appearance49).TextHAlignAsString = "Right";
    ultraGridColumn20.CellAppearance = (AppearanceBase) appearance49;
    ((AppearanceBase) appearance50).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn20.Header).Appearance = (AppearanceBase) appearance50;
    ((HeaderBase) ultraGridColumn20.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn20.Header).VisiblePosition = 3;
    ultraGridColumn20.Hidden = true;
    ultraGridColumn20.Width = 52;
    ((HeaderBase) ultraGridColumn21.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn21.Header).VisiblePosition = 4;
    ultraGridColumn21.Hidden = true;
    ultraGridColumn21.Width = 82;
    ((AppearanceBase) appearance51).TextHAlignAsString = "Right";
    ultraGridColumn22.CellAppearance = (AppearanceBase) appearance51;
    ((AppearanceBase) appearance52).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn22.Header).Appearance = (AppearanceBase) appearance52;
    ((HeaderBase) ultraGridColumn22.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn22.Header).VisiblePosition = 5;
    ultraGridColumn22.Hidden = true;
    ultraGridColumn22.Width = 87;
    ((AppearanceBase) appearance53).TextHAlignAsString = "Right";
    ultraGridColumn23.CellAppearance = (AppearanceBase) appearance53;
    ((AppearanceBase) appearance54).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn23.Header).Appearance = (AppearanceBase) appearance54;
    ((HeaderBase) ultraGridColumn23.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn23.Header).VisiblePosition = 6;
    ultraGridColumn23.Hidden = true;
    ultraGridColumn23.Width = 99;
    ((AppearanceBase) appearance55).TextHAlignAsString = "Center";
    ((HeaderBase) ultraGridColumn24.Header).Appearance = (AppearanceBase) appearance55;
    ((HeaderBase) ultraGridColumn24.Header).Caption = "Cost For Equipment?";
    ((HeaderBase) ultraGridColumn24.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn24.Header).VisiblePosition = 7;
    ultraGridColumn24.Width = 119;
    ((AppearanceBase) appearance56).TextHAlignAsString = "Right";
    ultraGridColumn25.CellAppearance = (AppearanceBase) appearance56;
    ((AppearanceBase) appearance57).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn25.Header).Appearance = (AppearanceBase) appearance57;
    ((HeaderBase) ultraGridColumn25.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn25.Header).VisiblePosition = 8;
    ultraGridColumn25.Hidden = true;
    ultraGridColumn25.Width = 66;
    ((HeaderBase) ultraGridColumn26.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn26.Header).VisiblePosition = 9;
    ultraGridColumn26.Hidden = true;
    ultraGridColumn26.Width = 114;
    ((AppearanceBase) appearance58).TextHAlignAsString = "Center";
    ((HeaderBase) ultraGridColumn27.Header).Appearance = (AppearanceBase) appearance58;
    ((HeaderBase) ultraGridColumn27.Header).Caption = "Cost Per Unit?";
    ((HeaderBase) ultraGridColumn27.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn27.Header).VisiblePosition = 10;
    ultraGridColumn27.Width = 119;
    ((AppearanceBase) appearance59).TextHAlignAsString = "Right";
    ultraGridColumn28.CellAppearance = (AppearanceBase) appearance59;
    ((AppearanceBase) appearance60).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn28.Header).Appearance = (AppearanceBase) appearance60;
    ((HeaderBase) ultraGridColumn28.Header).Caption = "Unit Cost";
    ((HeaderBase) ultraGridColumn28.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn28.Header).VisiblePosition = 11;
    ultraGridColumn28.Hidden = true;
    ultraGridColumn28.Width = 71;
    ((HeaderBase) ultraGridColumn29.Header).Caption = "Unit Cost Edit";
    ((HeaderBase) ultraGridColumn29.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn29.Header).VisiblePosition = 12;
    ultraGridColumn29.Hidden = true;
    ultraGridColumn29.Width = 104;
    ((AppearanceBase) appearance61).TextHAlignAsString = "Right";
    ultraGridColumn30.CellAppearance = (AppearanceBase) appearance61;
    ((AppearanceBase) appearance62).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn30.Header).Appearance = (AppearanceBase) appearance62;
    ((HeaderBase) ultraGridColumn30.Header).Caption = "Automated Unit Cost";
    ((HeaderBase) ultraGridColumn30.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn30.Header).VisiblePosition = 13;
    ultraGridColumn30.Hidden = true;
    ultraGridColumn30.Width = 126;
    ((AppearanceBase) appearance63).TextHAlignAsString = "Left";
    ultraGridColumn31.CellAppearance = (AppearanceBase) appearance63;
    ((AppearanceBase) appearance64).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn31.Header).Appearance = (AppearanceBase) appearance64;
    ((HeaderBase) ultraGridColumn31.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn31.Header).VisiblePosition = 14;
    ultraGridColumn31.Hidden = true;
    ultraGridColumn31.Width = 135;
    ultraGridBand2.Columns.AddRange(new object[15]
    {
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
      (object) ultraGridColumn28,
      (object) ultraGridColumn29,
      (object) ultraGridColumn30,
      (object) ultraGridColumn31
    });
    ultraGridBand2.GroupHeadersVisible = false;
    ultraGridLayout.BandsSerializer.Add((object) ultraGridBand2);
    ultraGridLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((KeyedSubObjectBase) ultraGridLayout).Key = "Layout1";
    ((AppearanceBase) appearance65).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance65).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance65).ForeColor = Color.Black;
    ultraGridLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance65;
    ultraGridLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ultraGridLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ultraGridLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance66).BorderColor = Color.LightGray;
    ultraGridLayout.Override.CellAppearance = (AppearanceBase) appearance66;
    ultraGridLayout.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance67).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ultraGridLayout.Override.HeaderAppearance = (AppearanceBase) appearance67;
    ultraGridLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance68).BackColor = Color.FromArgb(246, 250, 253);
    ultraGridLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance68;
    ((AppearanceBase) appearance69).BorderColor = Color.LightGray;
    ultraGridLayout.Override.RowAppearance = (AppearanceBase) appearance69;
    ultraGridLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance70).BackColor = Color.Transparent;
    ((AppearanceBase) appearance70).ForeColor = Color.Black;
    ultraGridLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance70;
    ((AppearanceBase) appearance71).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance71).BorderColor = Color.Silver;
    scrollBarLook2.ButtonAppearance = (AppearanceBase) appearance71;
    ((AppearanceBase) appearance72).BackColor = Color.White;
    scrollBarLook2.TrackAppearance = (AppearanceBase) appearance72;
    ultraGridLayout.ScrollBarLook = scrollBarLook2;
    ((UltraGridBase) this.gridExpenseListing).Layouts.Add(ultraGridLayout);
    ((Control) this.gridExpenseListing).Location = new Point(0, 0);
    ((Control) this.gridExpenseListing).Name = "gridExpenseListing";
    ((Control) this.gridExpenseListing).Size = new Size(667, 315);
    ((Control) this.gridExpenseListing).TabIndex = 0;
    ((UltraControlBase) this.gridExpenseListing).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridExpenseListing).UseOsThemes = (DefaultableBoolean) 2;
    this.gridExpenseListing.AfterSelectChange += new AfterSelectChangeEventHandler(this.gridExpenseListing_AfterSelectChange);
    this.gridExpenseListing.BeforeRowsDeleted += new BeforeRowsDeletedEventHandler(this.gridExpenseListing_BeforeRowsDeleted);
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(667, 557);
    this.Controls.Add((Control) this.gridExpenseListing);
    this.Controls.Add((Control) this.mgaGroupBox1);
    this.Font = new Font("Tahoma", 8.25f);
    this.ForeColor = Color.Black;
    this.Name = nameof (FormUnallocatedExpenses);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Claims Expense Management";
    this.Load += new EventHandler(this.FormUnallocatedExpenses_Load);
    ((ISupportInitialize) this.mgaGroupBox1).EndInit();
    ((Control) this.mgaGroupBox1).ResumeLayout(false);
    this.panelEdits.ResumeLayout(false);
    this.panelEdits.PerformLayout();
    ((ISupportInitialize) this.checkIsTax).EndInit();
    ((ISupportInitialize) this.expenseListBindingSource).EndInit();
    this.dsClaimExpenses1.EndInit();
    ((ISupportInitialize) this.textExpenseId).EndInit();
    ((ISupportInitialize) this.textUnit_AutomatedAmount).EndInit();
    ((ISupportInitialize) this.textUnit_MaxAmount).EndInit();
    ((ISupportInitialize) this.textUnit_UnitCost).EndInit();
    ((ISupportInitialize) this.textEquipmentRate).EndInit();
    ((ISupportInitialize) this.textHourly_AutomatedHours).EndInit();
    ((ISupportInitialize) this.textHourly_MaxHours).EndInit();
    ((ISupportInitialize) this.textHourlyRate).EndInit();
    ((ISupportInitialize) this.checkEquip_AllowEdit).EndInit();
    ((ISupportInitialize) this.textUnit_DisplayPrompt).EndInit();
    ((ISupportInitialize) this.textExpenseName).EndInit();
    ((ISupportInitialize) this.checkUnit_Allowedit).EndInit();
    ((ISupportInitialize) this.checkChargedHourly).EndInit();
    ((ISupportInitialize) this.checkChargedPerUnit).EndInit();
    ((ISupportInitialize) this.checkEquipmentCharges).EndInit();
    ((ISupportInitialize) this.checkHourly_AllowEdit).EndInit();
    ((ISupportInitialize) this.gridExpenseListing).EndInit();
    this.ResumeLayout(false);
  }

  protected delegate void SaveExpenseHandler(object sender, EventArgs e);

  protected delegate void ClearScreenHandler(object sender, EventArgs e);

  protected delegate void EditExpenseHandler(object sender, EventArgs e);

  protected delegate void GridSelectedChangedHandler(object sender, EventArgs e);
}
