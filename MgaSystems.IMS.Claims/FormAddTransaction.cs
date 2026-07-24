// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.FormAddTransaction
// Assembly: MgaSystems.IMS.Claims, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FCD9D0B7-28CF-40B9-8EB7-297871E1AF5F
// Assembly location: F:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinMaskedEdit;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Claims.Properties;
using MGASystems.IMS.Security;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Claims;

[SecureResource("{7DA51B1A-9A0D-4178-9BD7-2DA2A2A53C02}", "Claim Expense Allow Negative Rights", "Users with this permission are granted the ability to enter negative expenses on claims.", "Claims")]
public class FormAddTransaction : FormBase
{
  private Claim _currentClaim;
  private IContainer components;
  private UltraLabel ultraLabel1;
  private UltraLabel ultraLabel3;
  private UltraLabel ultraLabel2;
  private UltraLabel ultraLabel4;
  private UltraLabel ultraLabel6;
  private UltraLabel ultraLabel5;
  private BindingSource expenseListBindingSource;
  private BindingSource dsClaimExpensesBindingSource;
  protected MGASimpleComboBox comboExpenses;
  protected UltraLabel ultraLabel7;
  protected MGADateTimePicker dateTimeTransactiondate;
  protected MGAMaskedEdit textHourly_AutomatedHours;
  protected MGAMaskedEdit textHourlyRate;
  protected MGAMaskedEdit textEquipmentRate;
  protected MGAMaskedEdit textUnit_AutomatedAmount;
  protected MGAMaskedEdit textUnit_UnitCost;
  protected dsClaimExpenses dsClaimExpenses1;
  protected MGATextBox textComments;
  protected UltraGroupBox groupHourlyCharges;
  protected UltraGroupBox groupUnitCharges;
  protected MGAButton buttonCancel;
  protected MGAButton buttonSave;
  protected UltraGroupBox ultraGroupBox1;
  protected UltraGroupBox groupEquipmentCharges;

  internal bool AllowNegative { get; set; }

  public FormAddTransaction()
  {
    this.InitializeComponent();
    this.InitializeForm();
  }

  public FormAddTransaction(Claim currentClaim)
  {
    this.InitializeComponent();
    this._currentClaim = currentClaim;
    this.InitializeForm();
  }

  protected Claim CurrentClaim
  {
    get => this._currentClaim;
    set => this._currentClaim = value;
  }

  private void FormAddTransaction_Load(object sender, EventArgs e)
  {
    ((UltraDateTimeEditor) this.dateTimeTransactiondate).Value = (object) DateTime.Now;
    if (!SecurityManager.Instance.AssertPermission("{7DA51B1A-9A0D-4178-9BD7-2DA2A2A53C02}"))
      return;
    this.AllowNegative = true;
    ((UltraMaskedEdit) this.textHourlyRate).MinValue = (object) -9999999;
    ((UltraMaskedEdit) this.textEquipmentRate).MinValue = (object) -9999999;
    ((UltraMaskedEdit) this.textUnit_UnitCost).MinValue = (object) -9999999;
  }

  private void buttonCancel_Click(object sender, EventArgs e)
  {
    this.DialogResult = DialogResult.Cancel;
    this.Close();
  }

  protected virtual void comboExpenses_RowSelected(object sender, RowSelectedEventArgs e)
  {
    if (((UltraDropDownBase) this.comboExpenses).SelectedRow == null)
      return;
    ((Control) this.groupHourlyCharges).Enabled = (bool) ((UltraDropDownBase) this.comboExpenses).SelectedRow.Cells[this.dsClaimExpenses1.ExpenseList.HourlyChargedColumn.ColumnName].Value;
    if (((Control) this.groupHourlyCharges).Enabled)
    {
      ((UltraMaskedEdit) this.textHourlyRate).Value = (object) (Decimal) ((UltraDropDownBase) this.comboExpenses).SelectedRow.Cells[this.dsClaimExpenses1.ExpenseList.HourlyRateColumn.ColumnName].Value;
      ((Control) this.textHourlyRate).Enabled = (bool) ((UltraDropDownBase) this.comboExpenses).SelectedRow.Cells[this.dsClaimExpenses1.ExpenseList.AllowHourlyRateEditColumn.ColumnName].Value;
      ((UltraMaskedEdit) this.textHourly_AutomatedHours).Value = (object) (Decimal) ((UltraDropDownBase) this.comboExpenses).SelectedRow.Cells[this.dsClaimExpenses1.ExpenseList.AutomatedHoursColumn.ColumnName].Value;
    }
    else
    {
      ((Control) this.textHourlyRate).Text = string.Empty;
      ((Control) this.textHourly_AutomatedHours).Text = string.Empty;
    }
    ((Control) this.groupEquipmentCharges).Enabled = (bool) ((UltraDropDownBase) this.comboExpenses).SelectedRow.Cells[this.dsClaimExpenses1.ExpenseList.EquipmentChargedColumn.ColumnName].Value;
    if (((Control) this.groupEquipmentCharges).Enabled)
    {
      ((UltraMaskedEdit) this.textEquipmentRate).Value = (object) (Decimal) ((UltraDropDownBase) this.comboExpenses).SelectedRow.Cells[this.dsClaimExpenses1.ExpenseList.EquipmentRateColumn.ColumnName].Value;
      ((Control) this.textEquipmentRate).Enabled = (bool) ((UltraDropDownBase) this.comboExpenses).SelectedRow.Cells[this.dsClaimExpenses1.ExpenseList.AllowEquipmentRateEditColumn.ColumnName].Value;
    }
    else
      ((Control) this.textEquipmentRate).Text = string.Empty;
    ((Control) this.groupUnitCharges).Enabled = (bool) ((UltraDropDownBase) this.comboExpenses).SelectedRow.Cells[this.dsClaimExpenses1.ExpenseList.UnitAmountChargedColumn.ColumnName].Value;
    if (((Control) this.groupUnitCharges).Enabled)
    {
      ((Control) this.groupUnitCharges).Text = ((UltraDropDownBase) this.comboExpenses).SelectedRow.Cells[this.dsClaimExpenses1.ExpenseList.UnitCostPromptColumn.ColumnName].Value.ToString();
      ((UltraMaskedEdit) this.textUnit_UnitCost).Value = (object) (Decimal) ((UltraDropDownBase) this.comboExpenses).SelectedRow.Cells[this.dsClaimExpenses1.ExpenseList.UnitCostColumn.ColumnName].Value;
      ((Control) this.textUnit_UnitCost).Enabled = (bool) ((UltraDropDownBase) this.comboExpenses).SelectedRow.Cells[this.dsClaimExpenses1.ExpenseList.AllowUnitCostEditColumn.ColumnName].Value;
      ((UltraMaskedEdit) this.textUnit_AutomatedAmount).Value = (object) (Decimal) ((UltraDropDownBase) this.comboExpenses).SelectedRow.Cells[this.dsClaimExpenses1.ExpenseList.AutomatedUnitCostColumn.ColumnName].Value;
    }
    else
    {
      ((Control) this.groupUnitCharges).Text = "Unit Charges";
      ((Control) this.textUnit_UnitCost).Text = string.Empty;
      ((Control) this.textUnit_AutomatedAmount).Text = string.Empty;
    }
  }

  private void buttonSave_Click(object sender, EventArgs e)
  {
    if (!this.ValidateForm())
      return;
    this.Save();
    this.ClearScreen();
    ((UltraCombo) this.comboExpenses).Focus();
  }

  protected virtual void InitializeForm()
  {
    this.Cursor = MgaCursors.WaitCursor;
    using (BackgroundWorker backgroundWorker = new BackgroundWorker())
    {
      backgroundWorker.RunWorkerCompleted += (RunWorkerCompletedEventHandler) ((sender, e) => this.Cursor = MgaCursors.Default);
      backgroundWorker.DoWork += (DoWorkEventHandler) ((sender, e) => this.LoadExpenses());
      backgroundWorker.RunWorkerAsync();
    }
  }

  protected virtual void LoadExpenses()
  {
    this.dsClaimExpenses1.ExpenseList.Clear();
    DefaultDatabase.LoadDataTable((DataTable) this.dsClaimExpenses1.ExpenseList, "spClaims_GetExpenseList");
  }

  protected virtual void Save()
  {
    if (((UltraDropDownBase) this.comboExpenses).SelectedRow == null)
      return;
    Decimal? hourlyRate = new Decimal?(0M);
    Decimal? hours = new Decimal?(0M);
    Decimal? equiptmentRate = new Decimal?(0M);
    Decimal? otherCost = new Decimal?(0M);
    Decimal? otherAmount = new Decimal?(0M);
    hours = string.IsNullOrEmpty(((Control) this.textHourly_AutomatedHours).Text) || ((UltraMaskedEdit) this.textHourly_AutomatedHours).Value == null ? new Decimal?(0M) : new Decimal?(Convert.ToDecimal(((UltraMaskedEdit) this.textHourly_AutomatedHours).Value));
    if ((bool) ((UltraDropDownBase) this.comboExpenses).SelectedRow.Cells[this.dsClaimExpenses1.ExpenseList.HourlyChargedColumn.ColumnName].Value)
      hourlyRate = (Decimal?) ((UltraMaskedEdit) this.textHourlyRate).Value;
    if ((bool) ((UltraDropDownBase) this.comboExpenses).SelectedRow.Cells[this.dsClaimExpenses1.ExpenseList.EquipmentChargedColumn.ColumnName].Value)
    {
      equiptmentRate = (Decimal?) ((UltraMaskedEdit) this.textEquipmentRate).Value;
      Decimal? nullable = hours;
      Decimal num = 0M;
      if (nullable.GetValueOrDefault() == num & nullable.HasValue)
        hours = new Decimal?(1M);
    }
    if ((bool) ((UltraDropDownBase) this.comboExpenses).SelectedRow.Cells[this.dsClaimExpenses1.ExpenseList.UnitAmountChargedColumn.ColumnName].Value)
    {
      otherCost = (Decimal?) ((UltraMaskedEdit) this.textUnit_UnitCost).Value;
      otherAmount = new Decimal?(Convert.ToDecimal(((UltraMaskedEdit) this.textUnit_AutomatedAmount).Value));
    }
    this._currentClaim.AddExpense(Guid.Empty, ((Control) this.comboExpenses).Text, string.Empty, false, new int?((int) ((UltraCombo) this.comboExpenses).Value), CurrentUser.Instance.UserGUID, CurrentUser.Instance.DisplayName, ((Control) this.textComments).Text, hours, hourlyRate, equiptmentRate, otherCost, otherAmount, ((UltraDateTimeEditor) this.dateTimeTransactiondate).DateTime);
  }

  protected virtual bool ValidateForm()
  {
    if (((UltraDropDownBase) this.comboExpenses).SelectedRow == null || (int) ((UltraDropDownBase) this.comboExpenses).SelectedRow.Cells["ExpenseId"].Value == -1)
    {
      int num = (int) MessageBox.Show(Resources.CLAIMTRANSACTION_ERROR_NOEXPENSESELECTED, Resources.ERROR_REQUIREDFIELD_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    return this.ValidateRemainingAmount() && this.ValidateUserEntry();
  }

  protected virtual bool ValidateUserEntry() => true;

  private void ClearScreen()
  {
    ((UltraCombo) this.comboExpenses).Value = (object) null;
    ((UltraDropDownBase) this.comboExpenses).SelectedRow = (UltraGridRow) null;
    ((Control) this.textHourlyRate).Text = string.Empty;
    ((Control) this.textHourly_AutomatedHours).Text = string.Empty;
    ((Control) this.textEquipmentRate).Text = string.Empty;
    ((Control) this.textUnit_UnitCost).Text = string.Empty;
    ((Control) this.textUnit_AutomatedAmount).Text = string.Empty;
    ((Control) this.textComments).Text = string.Empty;
  }

  private bool ValidateRemainingAmount()
  {
    dsUnallocatedExpenses.ExpenseListRow expenseListRow = this.CurrentClaim.UnAllocatedExpenses.ExpenseList.NewExpenseListRow();
    Decimal? nullable1 = new Decimal?(0M);
    Decimal? nullable2 = new Decimal?(0M);
    Decimal? nullable3 = new Decimal?(0M);
    Decimal? nullable4 = new Decimal?(0M);
    Decimal? nullable5 = new Decimal?(0M);
    if (this.AllowNegative)
    {
      nullable2 = string.IsNullOrEmpty(((Control) this.textHourly_AutomatedHours).Text) || ((UltraMaskedEdit) this.textHourly_AutomatedHours).Value == null ? new Decimal?(0M) : new Decimal?(Convert.ToDecimal(((UltraMaskedEdit) this.textHourly_AutomatedHours).Value));
      if ((bool) ((UltraDropDownBase) this.comboExpenses).SelectedRow.Cells[this.dsClaimExpenses1.ExpenseList.HourlyChargedColumn.ColumnName].Value)
        nullable1 = (Decimal?) ((UltraMaskedEdit) this.textHourlyRate).Value;
      if ((bool) ((UltraDropDownBase) this.comboExpenses).SelectedRow.Cells[this.dsClaimExpenses1.ExpenseList.EquipmentChargedColumn.ColumnName].Value)
      {
        nullable3 = (Decimal?) ((UltraMaskedEdit) this.textEquipmentRate).Value;
        Decimal? nullable6 = nullable2;
        Decimal num = 0M;
        if (nullable6.GetValueOrDefault() == num & nullable6.HasValue)
          nullable2 = new Decimal?(1M);
      }
      if ((bool) ((UltraDropDownBase) this.comboExpenses).SelectedRow.Cells[this.dsClaimExpenses1.ExpenseList.UnitAmountChargedColumn.ColumnName].Value)
      {
        Decimal? nullable7 = (Decimal?) ((UltraMaskedEdit) this.textUnit_UnitCost).Value;
        nullable4 = new Decimal?(Convert.ToDecimal(((UltraMaskedEdit) this.textUnit_AutomatedAmount).Value));
      }
      if (nullable2.HasValue && nullable1.HasValue)
      {
        expenseListRow.HourlyRate = nullable1.Value;
        expenseListRow.Hours = nullable2.Value;
        expenseListRow.HourlyAmount = nullable1.Value * nullable2.Value;
        expenseListRow.TotalAmount = nullable1.Value * nullable2.Value;
      }
      else
      {
        expenseListRow.Hours = 0M;
        expenseListRow.HourlyRate = 0M;
        expenseListRow.HourlyAmount = 0M;
      }
      if (nullable2.HasValue)
      {
        expenseListRow.EquipmentRate = nullable3.Value;
        expenseListRow.EquipmentAmount = nullable3.Value * nullable2.Value;
        expenseListRow.TotalAmount += nullable3.Value * nullable2.Value;
      }
      else
      {
        expenseListRow.EquipmentRate = 0M;
        expenseListRow.EquipmentAmount = 0M;
      }
      if (nullable5.HasValue && nullable4.HasValue)
      {
        expenseListRow.OtherCost = nullable5.Value;
        expenseListRow.OtherCount = nullable4.Value;
        expenseListRow.OtherAmount = nullable5.Value * nullable4.Value;
        expenseListRow.TotalAmount += nullable5.Value * nullable4.Value;
      }
      else
      {
        expenseListRow.OtherCost = 0M;
        expenseListRow.OtherCount = 0M;
        expenseListRow.OtherAmount = 0M;
      }
      Decimal? nullable8 = new Decimal?(this.CurrentClaim.UnAllocatedExpenseTotal());
      Decimal totalAmount = expenseListRow.TotalAmount;
      nullable8 = nullable8.HasValue ? new Decimal?(nullable8.GetValueOrDefault() + totalAmount) : new Decimal?();
      Decimal num1 = 0M;
      if (nullable8.GetValueOrDefault() < num1 & nullable8.HasValue)
      {
        int num2 = (int) MessageBox.Show(Resources.CLAIMTRANSACTION_ERROR_BELOWZERO, Resources.CLAIMTRANSACTION_ERROR_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return false;
      }
    }
    return true;
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormAddTransaction));
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    this.comboExpenses = new MGASimpleComboBox();
    this.expenseListBindingSource = new BindingSource(this.components);
    this.dsClaimExpensesBindingSource = new BindingSource(this.components);
    this.dsClaimExpenses1 = new dsClaimExpenses();
    this.ultraLabel1 = new UltraLabel();
    this.groupHourlyCharges = new UltraGroupBox();
    this.textHourly_AutomatedHours = new MGAMaskedEdit();
    this.textHourlyRate = new MGAMaskedEdit();
    this.ultraLabel3 = new UltraLabel();
    this.ultraLabel2 = new UltraLabel();
    this.groupEquipmentCharges = new UltraGroupBox();
    this.textEquipmentRate = new MGAMaskedEdit();
    this.ultraLabel4 = new UltraLabel();
    this.groupUnitCharges = new UltraGroupBox();
    this.textUnit_AutomatedAmount = new MGAMaskedEdit();
    this.textUnit_UnitCost = new MGAMaskedEdit();
    this.ultraLabel6 = new UltraLabel();
    this.ultraLabel5 = new UltraLabel();
    this.buttonCancel = new MGAButton();
    this.buttonSave = new MGAButton();
    this.textComments = new MGATextBox();
    this.ultraGroupBox1 = new UltraGroupBox();
    this.dateTimeTransactiondate = new MGADateTimePicker();
    this.ultraLabel7 = new UltraLabel();
    ((ISupportInitialize) this.comboExpenses).BeginInit();
    ((ISupportInitialize) this.expenseListBindingSource).BeginInit();
    ((ISupportInitialize) this.dsClaimExpensesBindingSource).BeginInit();
    this.dsClaimExpenses1.BeginInit();
    ((ISupportInitialize) this.groupHourlyCharges).BeginInit();
    ((Control) this.groupHourlyCharges).SuspendLayout();
    ((ISupportInitialize) this.textHourly_AutomatedHours).BeginInit();
    ((ISupportInitialize) this.textHourlyRate).BeginInit();
    ((ISupportInitialize) this.groupEquipmentCharges).BeginInit();
    ((Control) this.groupEquipmentCharges).SuspendLayout();
    ((ISupportInitialize) this.textEquipmentRate).BeginInit();
    ((ISupportInitialize) this.groupUnitCharges).BeginInit();
    ((Control) this.groupUnitCharges).SuspendLayout();
    ((ISupportInitialize) this.textUnit_AutomatedAmount).BeginInit();
    ((ISupportInitialize) this.textUnit_UnitCost).BeginInit();
    ((ISupportInitialize) this.buttonCancel).BeginInit();
    ((ISupportInitialize) this.buttonSave).BeginInit();
    ((ISupportInitialize) this.textComments).BeginInit();
    ((ISupportInitialize) this.ultraGroupBox1).BeginInit();
    ((Control) this.ultraGroupBox1).SuspendLayout();
    ((ISupportInitialize) this.dateTimeTransactiondate).BeginInit();
    this.SuspendLayout();
    ((UltraCombo) this.comboExpenses).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.comboExpenses).DataSource = (object) this.expenseListBindingSource;
    ((UltraDropDownBase) this.comboExpenses).DisplayMember = "Expense";
    ((UltraCombo) this.comboExpenses).DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboExpenses).Location = new Point(91, 9);
    this.comboExpenses.MGAStyle = (MGAStyles) 2;
    ((Control) this.comboExpenses).Name = "comboExpenses";
    ((Control) this.comboExpenses).Size = new Size(477, 21);
    ((Control) this.comboExpenses).TabIndex = 1;
    ((UltraControlBase) this.comboExpenses).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboExpenses).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.comboExpenses).ValueMember = "ExpenseId";
    ((UltraCombo) this.comboExpenses).RowSelected += new RowSelectedEventHandler(this.comboExpenses_RowSelected);
    this.expenseListBindingSource.DataMember = "ExpenseList";
    this.expenseListBindingSource.DataSource = (object) this.dsClaimExpensesBindingSource;
    this.dsClaimExpensesBindingSource.DataSource = (object) this.dsClaimExpenses1;
    this.dsClaimExpensesBindingSource.Position = 0;
    this.dsClaimExpenses1.DataSetName = "dsClaimExpenses";
    this.dsClaimExpenses1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((AppearanceBase) appearance1).BackColor = Color.Transparent;
    ((ControlBase) this.ultraLabel1).Appearance = (AppearanceBase) appearance1;
    ((Control) this.ultraLabel1).AutoSize = true;
    ((Control) this.ultraLabel1).Location = new Point(16 /*0x10*/, 9);
    ((Control) this.ultraLabel1).Name = "ultraLabel1";
    ((Control) this.ultraLabel1).Size = new Size(50, 15);
    ((Control) this.ultraLabel1).TabIndex = 0;
    ((Control) this.ultraLabel1).Text = "Expense:";
    ((AppearanceBase) appearance2).BackColor = Color.Transparent;
    this.groupHourlyCharges.Appearance = (AppearanceBase) appearance2;
    ((Control) this.groupHourlyCharges).Controls.Add((Control) this.textHourly_AutomatedHours);
    ((Control) this.groupHourlyCharges).Controls.Add((Control) this.textHourlyRate);
    ((Control) this.groupHourlyCharges).Controls.Add((Control) this.ultraLabel3);
    ((Control) this.groupHourlyCharges).Controls.Add((Control) this.ultraLabel2);
    ((Control) this.groupHourlyCharges).Location = new Point(13, 60);
    ((Control) this.groupHourlyCharges).Name = "groupHourlyCharges";
    ((Control) this.groupHourlyCharges).Size = new Size(219, 79);
    ((Control) this.groupHourlyCharges).TabIndex = 4;
    ((Control) this.groupHourlyCharges).Text = "Hourly Charges";
    ((AppearanceBase) appearance3).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance3).TextHAlignAsString = "Right";
    ((UltraMaskedEdit) this.textHourly_AutomatedHours).Appearance = (AppearanceBase) appearance3;
    ((UltraMaskedEdit) this.textHourly_AutomatedHours).EditAs = (EditAsType) 7;
    ((Control) this.textHourly_AutomatedHours).Location = new Point(78, 47);
    this.textHourly_AutomatedHours.MGAStyle = (MGAStyles) 2;
    ((UltraMaskedEdit) this.textHourly_AutomatedHours).MinValue = (object) new Decimal(new int[4]);
    ((Control) this.textHourly_AutomatedHours).Name = "textHourly_AutomatedHours";
    ((UltraMaskedEdit) this.textHourly_AutomatedHours).NonAutoSizeHeight = 20;
    ((Control) this.textHourly_AutomatedHours).Size = new Size(135, 21);
    ((Control) this.textHourly_AutomatedHours).TabIndex = 3;
    ((Control) this.textHourly_AutomatedHours).Text = "$.";
    ((UltraControlBase) this.textHourly_AutomatedHours).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textHourly_AutomatedHours).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance4).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance4).TextHAlignAsString = "Right";
    ((UltraMaskedEdit) this.textHourlyRate).Appearance = (AppearanceBase) appearance4;
    ((UltraMaskedEdit) this.textHourlyRate).DataMode = (MaskMode) 0;
    ((UltraMaskedEdit) this.textHourlyRate).EditAs = (EditAsType) 2;
    ((Control) this.textHourlyRate).Location = new Point(78, 20);
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
    ((Control) this.textHourlyRate).Size = new Size(135, 21);
    ((Control) this.textHourlyRate).TabIndex = 1;
    ((Control) this.textHourlyRate).Text = ".";
    ((UltraControlBase) this.textHourlyRate).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textHourlyRate).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.ultraLabel3).AutoSize = true;
    ((Control) this.ultraLabel3).Location = new Point(18, 41);
    ((Control) this.ultraLabel3).Name = "ultraLabel3";
    ((Control) this.ultraLabel3).Size = new Size(37, 15);
    ((Control) this.ultraLabel3).TabIndex = 2;
    ((Control) this.ultraLabel3).Text = "Hours:";
    ((Control) this.ultraLabel2).AutoSize = true;
    ((Control) this.ultraLabel2).Location = new Point(18, 20);
    ((Control) this.ultraLabel2).Name = "ultraLabel2";
    ((Control) this.ultraLabel2).Size = new Size(31 /*0x1F*/, 15);
    ((Control) this.ultraLabel2).TabIndex = 0;
    ((Control) this.ultraLabel2).Text = "Rate:";
    ((AppearanceBase) appearance5).BackColor = Color.Transparent;
    this.groupEquipmentCharges.Appearance = (AppearanceBase) appearance5;
    ((Control) this.groupEquipmentCharges).Controls.Add((Control) this.textEquipmentRate);
    ((Control) this.groupEquipmentCharges).Controls.Add((Control) this.ultraLabel4);
    ((Control) this.groupEquipmentCharges).Location = new Point(13, 145);
    ((Control) this.groupEquipmentCharges).Name = "groupEquipmentCharges";
    ((Control) this.groupEquipmentCharges).Size = new Size(219, 59);
    ((Control) this.groupEquipmentCharges).TabIndex = 5;
    ((Control) this.groupEquipmentCharges).Text = "Equipment Charges";
    ((AppearanceBase) appearance6).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance6).TextHAlignAsString = "Right";
    ((UltraMaskedEdit) this.textEquipmentRate).Appearance = (AppearanceBase) appearance6;
    ((UltraMaskedEdit) this.textEquipmentRate).EditAs = (EditAsType) 2;
    ((Control) this.textEquipmentRate).Location = new Point(78, 25);
    this.textEquipmentRate.MGAStyle = (MGAStyles) 2;
    ((UltraMaskedEdit) this.textEquipmentRate).MinValue = (object) new Decimal(new int[4]);
    ((Control) this.textEquipmentRate).Name = "textEquipmentRate";
    ((UltraMaskedEdit) this.textEquipmentRate).NonAutoSizeHeight = 20;
    ((Control) this.textEquipmentRate).Size = new Size(135, 21);
    ((Control) this.textEquipmentRate).TabIndex = 1;
    ((Control) this.textEquipmentRate).Text = "$.";
    ((UltraControlBase) this.textEquipmentRate).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textEquipmentRate).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.ultraLabel4).AutoSize = true;
    ((Control) this.ultraLabel4).Location = new Point(18, 25);
    ((Control) this.ultraLabel4).Name = "ultraLabel4";
    ((Control) this.ultraLabel4).Size = new Size(31 /*0x1F*/, 15);
    ((Control) this.ultraLabel4).TabIndex = 0;
    ((Control) this.ultraLabel4).Text = "Rate:";
    ((AppearanceBase) appearance7).BackColor = Color.Transparent;
    this.groupUnitCharges.Appearance = (AppearanceBase) appearance7;
    ((Control) this.groupUnitCharges).Controls.Add((Control) this.textUnit_AutomatedAmount);
    ((Control) this.groupUnitCharges).Controls.Add((Control) this.textUnit_UnitCost);
    ((Control) this.groupUnitCharges).Controls.Add((Control) this.ultraLabel6);
    ((Control) this.groupUnitCharges).Controls.Add((Control) this.ultraLabel5);
    ((Control) this.groupUnitCharges).Location = new Point(13, 210);
    ((Control) this.groupUnitCharges).Name = "groupUnitCharges";
    ((Control) this.groupUnitCharges).Size = new Size(219, 78);
    ((Control) this.groupUnitCharges).TabIndex = 6;
    ((Control) this.groupUnitCharges).Text = "Unit Charges";
    ((AppearanceBase) appearance8).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance8).TextHAlignAsString = "Right";
    ((UltraMaskedEdit) this.textUnit_AutomatedAmount).Appearance = (AppearanceBase) appearance8;
    ((UltraMaskedEdit) this.textUnit_AutomatedAmount).EditAs = (EditAsType) 7;
    ((Control) this.textUnit_AutomatedAmount).Location = new Point(78, 47);
    this.textUnit_AutomatedAmount.MGAStyle = (MGAStyles) 2;
    ((UltraMaskedEdit) this.textUnit_AutomatedAmount).MinValue = (object) new Decimal(new int[4]);
    ((Control) this.textUnit_AutomatedAmount).Name = "textUnit_AutomatedAmount";
    ((UltraMaskedEdit) this.textUnit_AutomatedAmount).NonAutoSizeHeight = 20;
    ((Control) this.textUnit_AutomatedAmount).Size = new Size(135, 21);
    ((Control) this.textUnit_AutomatedAmount).TabIndex = 3;
    ((Control) this.textUnit_AutomatedAmount).Text = "$.";
    ((UltraControlBase) this.textUnit_AutomatedAmount).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textUnit_AutomatedAmount).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance9).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance9).TextHAlignAsString = "Right";
    ((UltraMaskedEdit) this.textUnit_UnitCost).Appearance = (AppearanceBase) appearance9;
    ((UltraMaskedEdit) this.textUnit_UnitCost).EditAs = (EditAsType) 2;
    ((Control) this.textUnit_UnitCost).Location = new Point(78, 20);
    this.textUnit_UnitCost.MGAStyle = (MGAStyles) 2;
    ((UltraMaskedEdit) this.textUnit_UnitCost).MinValue = (object) new Decimal(new int[4]);
    ((Control) this.textUnit_UnitCost).Name = "textUnit_UnitCost";
    ((UltraMaskedEdit) this.textUnit_UnitCost).NonAutoSizeHeight = 20;
    ((Control) this.textUnit_UnitCost).Size = new Size(135, 21);
    ((Control) this.textUnit_UnitCost).TabIndex = 1;
    ((Control) this.textUnit_UnitCost).Text = "$.";
    ((UltraControlBase) this.textUnit_UnitCost).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textUnit_UnitCost).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.ultraLabel6).AutoSize = true;
    ((Control) this.ultraLabel6).Location = new Point(18, 20);
    ((Control) this.ultraLabel6).Name = "ultraLabel6";
    ((Control) this.ultraLabel6).Size = new Size(54, 15);
    ((Control) this.ultraLabel6).TabIndex = 0;
    ((Control) this.ultraLabel6).Text = "Unit Cost:";
    ((Control) this.ultraLabel5).AutoSize = true;
    ((Control) this.ultraLabel5).Location = new Point(18, 41);
    ((Control) this.ultraLabel5).Name = "ultraLabel5";
    ((Control) this.ultraLabel5).Size = new Size(47, 15);
    ((Control) this.ultraLabel5).TabIndex = 2;
    ((Control) this.ultraLabel5).Text = "Amount:";
    ((AppearanceBase) appearance10).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance10).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance10).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance10).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance10).Image = componentResourceManager.GetObject("appearance10.Image");
    ((AppearanceBase) appearance10).ImageHAlign = (HAlign) 1;
    ((AppearanceBase) appearance10).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonCancel).Appearance = (AppearanceBase) appearance10;
    ((UltraButtonBase) this.buttonCancel).DialogResult = DialogResult.Cancel;
    ((Control) this.buttonCancel).Location = new Point(486, 295);
    ((Control) this.buttonCancel).Name = "buttonCancel";
    ((Control) this.buttonCancel).Size = new Size(82, 34);
    ((Control) this.buttonCancel).TabIndex = 9;
    ((Control) this.buttonCancel).Text = "Cancel";
    ((UltraControlBase) this.buttonCancel).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonCancel).Click += new EventHandler(this.buttonCancel_Click);
    ((AppearanceBase) appearance11).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance11).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance11).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance11).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance11).Image = componentResourceManager.GetObject("appearance11.Image");
    ((AppearanceBase) appearance11).ImageHAlign = (HAlign) 1;
    ((AppearanceBase) appearance11).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonSave).Appearance = (AppearanceBase) appearance11;
    ((Control) this.buttonSave).Location = new Point(393, 295);
    ((Control) this.buttonSave).Name = "buttonSave";
    ((Control) this.buttonSave).Size = new Size(87, 34);
    ((Control) this.buttonSave).TabIndex = 8;
    ((Control) this.buttonSave).Text = "Save";
    ((UltraControlBase) this.buttonSave).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonSave).Click += new EventHandler(this.buttonSave_Click);
    ((AppearanceBase) appearance12).BackColor = Color.White;
    ((AppearanceBase) appearance12).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance12).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textComments).Appearance = (AppearanceBase) appearance12;
    ((Control) this.textComments).BackColor = Color.White;
    ((Control) this.textComments).Location = new Point(6, 20);
    ((TextEditorControlBase) this.textComments).MaxLength = 5000;
    this.textComments.MGAStyle = (MGAStyles) 2;
    ((UltraTextEditor) this.textComments).Multiline = true;
    ((Control) this.textComments).Name = "textComments";
    ((Control) this.textComments).Size = new Size(318, 202);
    ((Control) this.textComments).TabIndex = 0;
    ((UltraControlBase) this.textComments).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textComments).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance13).BackColor = Color.Transparent;
    this.ultraGroupBox1.Appearance = (AppearanceBase) appearance13;
    ((Control) this.ultraGroupBox1).Controls.Add((Control) this.textComments);
    ((Control) this.ultraGroupBox1).Location = new Point(238, 60);
    ((Control) this.ultraGroupBox1).Name = "ultraGroupBox1";
    ((Control) this.ultraGroupBox1).Size = new Size(330, 228);
    ((Control) this.ultraGroupBox1).TabIndex = 7;
    ((Control) this.ultraGroupBox1).Text = "Comments";
    ((AppearanceBase) appearance14).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraDateTimeEditor) this.dateTimeTransactiondate).Appearance = (AppearanceBase) appearance14;
    ((AppearanceBase) appearance15).AlphaLevel = (short) 14;
    ((AppearanceBase) appearance15).BackColor = Color.FromArgb(0, 0, 246, 253);
    ((AppearanceBase) appearance15).BackColor2 = Color.FromArgb(133, 162, 221);
    ((AppearanceBase) appearance15).BackColorAlpha = (Alpha) 2;
    ((AppearanceBase) appearance15).BackGradientAlignment = (GradientAlignment) 4;
    ((AppearanceBase) appearance15).BackGradientStyle = (GradientStyle) 5;
    ((AppearanceBase) appearance15).BorderAlpha = (Alpha) 1;
    ((AppearanceBase) appearance15).BorderColor = Color.FromArgb(78, 122, 171);
    ((AppearanceBase) appearance15).ForeColor = Color.FromArgb(49, 85, 153);
    ((AppearanceBase) appearance15).ForegroundAlpha = (Alpha) 2;
    ((UltraDateTimeEditor) this.dateTimeTransactiondate).ButtonAppearance = (AppearanceBase) appearance15;
    ((Control) this.dateTimeTransactiondate).Location = new Point(91, 35);
    this.dateTimeTransactiondate.MGAStyle = (MGAStyles) 2;
    ((Control) this.dateTimeTransactiondate).Name = "dateTimeTransactiondate";
    ((Control) this.dateTimeTransactiondate).Size = new Size(83, 20);
    ((Control) this.dateTimeTransactiondate).TabIndex = 3;
    ((UltraControlBase) this.dateTimeTransactiondate).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dateTimeTransactiondate).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance16).BackColor = Color.Transparent;
    ((ControlBase) this.ultraLabel7).Appearance = (AppearanceBase) appearance16;
    ((Control) this.ultraLabel7).AutoSize = true;
    ((Control) this.ultraLabel7).Location = new Point(16 /*0x10*/, 35);
    ((Control) this.ultraLabel7).Name = "ultraLabel7";
    ((Control) this.ultraLabel7).Size = new Size(32 /*0x20*/, 15);
    ((Control) this.ultraLabel7).TabIndex = 2;
    ((Control) this.ultraLabel7).Text = "Date:";
    this.AcceptButton = (IButtonControl) this.buttonSave;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.CancelButton = (IButtonControl) this.buttonCancel;
    this.ClientSize = new Size(580, 341);
    this.Controls.Add((Control) this.ultraLabel7);
    this.Controls.Add((Control) this.dateTimeTransactiondate);
    this.Controls.Add((Control) this.ultraGroupBox1);
    this.Controls.Add((Control) this.buttonCancel);
    this.Controls.Add((Control) this.buttonSave);
    this.Controls.Add((Control) this.groupUnitCharges);
    this.Controls.Add((Control) this.groupEquipmentCharges);
    this.Controls.Add((Control) this.groupHourlyCharges);
    this.Controls.Add((Control) this.comboExpenses);
    this.Controls.Add((Control) this.ultraLabel1);
    this.Font = new Font("Tahoma", 8.25f);
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (FormAddTransaction);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Claims Expense Transaction";
    this.Load += new EventHandler(this.FormAddTransaction_Load);
    ((ISupportInitialize) this.comboExpenses).EndInit();
    ((ISupportInitialize) this.expenseListBindingSource).EndInit();
    ((ISupportInitialize) this.dsClaimExpensesBindingSource).EndInit();
    this.dsClaimExpenses1.EndInit();
    ((ISupportInitialize) this.groupHourlyCharges).EndInit();
    ((Control) this.groupHourlyCharges).ResumeLayout(false);
    ((Control) this.groupHourlyCharges).PerformLayout();
    ((ISupportInitialize) this.textHourly_AutomatedHours).EndInit();
    ((ISupportInitialize) this.textHourlyRate).EndInit();
    ((ISupportInitialize) this.groupEquipmentCharges).EndInit();
    ((Control) this.groupEquipmentCharges).ResumeLayout(false);
    ((Control) this.groupEquipmentCharges).PerformLayout();
    ((ISupportInitialize) this.textEquipmentRate).EndInit();
    ((ISupportInitialize) this.groupUnitCharges).EndInit();
    ((Control) this.groupUnitCharges).ResumeLayout(false);
    ((Control) this.groupUnitCharges).PerformLayout();
    ((ISupportInitialize) this.textUnit_AutomatedAmount).EndInit();
    ((ISupportInitialize) this.textUnit_UnitCost).EndInit();
    ((ISupportInitialize) this.buttonCancel).EndInit();
    ((ISupportInitialize) this.buttonSave).EndInit();
    ((ISupportInitialize) this.textComments).EndInit();
    ((ISupportInitialize) this.ultraGroupBox1).EndInit();
    ((Control) this.ultraGroupBox1).ResumeLayout(false);
    ((Control) this.ultraGroupBox1).PerformLayout();
    ((ISupportInitialize) this.dateTimeTransactiondate).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }
}
