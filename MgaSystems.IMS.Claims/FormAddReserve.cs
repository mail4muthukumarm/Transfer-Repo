// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.FormAddReserve
// Assembly: MgaSystems.IMS.Claims, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FCD9D0B7-28CF-40B9-8EB7-297871E1AF5F
// Assembly location: F:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Claims.Properties;
using MGASystems.Tools;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Claims;

public class FormAddReserve : FormBase
{
  protected Claimant _currentClaimant;
  protected PaymentReserve _reserve;
  protected PaymentReserve _payment;
  protected FormClaimant _claimantForm;
  private IContainer components;
  protected MGASimpleComboBox comboCoverageType;
  protected UltraLabel ultraLabel1;
  protected UltraLabel ultraLabel2;
  protected UltraLabel ultraLabel3;
  protected UltraLabel ultraLabel4;
  protected UltraLabel ultraLabel5;
  protected UltraLabel ultraLabel6;
  protected MGASimpleComboBox comboReserveType;
  protected MGASimpleComboBox comboReserveSubType;
  protected MGASimpleComboBox comboCoverageSubType;
  protected MGATextBox textComments;
  protected MGATextBox textAmount;
  protected MGAButton buttonSave;
  protected MGAButton buttonCancel;
  protected BindingSource coverageTypeDescriptionsBindingSource;
  protected BindingSource reserveTypesBindingSource;
  protected BindingSource dsReservePaymentTypes1BindingSource;
  protected BindingSource reserveSubTypesBindingSource;
  protected BindingSource coverageTypesBindingSource;
  protected BindingSource reserveTypesBindingSource1;
  protected dsReservePaymentTypes dsReservePaymentTypes1;
  protected dsCoverageTypes dsCoverageTypes1;
  public UltraLabel lblDate;
  public MGADateTimePicker dateTimeReserveDate;

  protected FormClaimant FormClaimant_Owner { get; private set; }

  public FormAddReserve() => this.InitializeComponent();

  public FormAddReserve(Claimant claimant, FormClaimant owner)
  {
    this.InitializeComponent();
    this._currentClaimant = claimant;
    this.FormClaimant_Owner = owner;
  }

  public FormAddReserve(Claimant claimant)
  {
    this.InitializeComponent();
    this._currentClaimant = claimant;
  }

  internal int? ReservePaymentTypeId
  {
    get
    {
      return ((UltraDropDownBase) this.comboReserveType).SelectedRow == null ? new int?() : new int?((int) ((UltraCombo) this.comboReserveType).Value);
    }
  }

  internal string ReservePaymentType
  {
    get
    {
      return ((UltraDropDownBase) this.comboReserveType).SelectedRow == null ? (string) null : ((Control) this.comboReserveType).Text;
    }
  }

  internal int? ReservePaymentSubTypeId
  {
    get
    {
      return ((UltraDropDownBase) this.comboReserveSubType).SelectedRow == null ? new int?() : new int?((int) ((UltraCombo) this.comboReserveSubType).Value);
    }
  }

  internal string ReservePaymentSubType
  {
    get
    {
      return ((UltraDropDownBase) this.comboReserveSubType).SelectedRow == null ? string.Empty : ((Control) this.comboReserveSubType).Text;
    }
  }

  internal int? CoverageTypeId
  {
    get
    {
      return ((UltraDropDownBase) this.comboCoverageType).SelectedRow == null ? new int?() : new int?((int) ((UltraCombo) this.comboCoverageType).Value);
    }
  }

  internal string CoverageType
  {
    get
    {
      return ((UltraDropDownBase) this.comboCoverageType).SelectedRow == null ? string.Empty : ((Control) this.comboCoverageType).Text;
    }
  }

  internal int? CoverageSubTypeId
  {
    get
    {
      return ((UltraDropDownBase) this.comboCoverageSubType).SelectedRow == null ? new int?() : new int?((int) ((UltraCombo) this.comboCoverageSubType).Value);
    }
  }

  internal string CoverageSubType
  {
    get
    {
      return ((UltraDropDownBase) this.comboCoverageSubType).SelectedRow == null ? string.Empty : ((Control) this.comboCoverageSubType).Text;
    }
  }

  internal string Comments => ((Control) this.textComments).Text;

  internal Decimal Amount
  {
    get
    {
      return string.IsNullOrEmpty(((Control) this.textAmount).Text) ? 0M : Decimal.Parse(((Control) this.textAmount).Text);
    }
  }

  internal PaymentReserve Reserve => this._reserve;

  internal PaymentReserve Payment => this._payment;

  protected virtual void InitializeForm()
  {
    ((UltraGridBase) this.comboReserveType).DataSource = (object) null;
    ((UltraGridBase) this.comboReserveSubType).DataSource = (object) null;
    ((UltraGridBase) this.comboCoverageType).DataSource = (object) null;
    ((UltraGridBase) this.comboCoverageSubType).DataSource = (object) null;
    this.LoadReservePaymentTypes();
    this.LoadReservePaymentSubTypes();
    this.LoadCoverageTypes();
    this.LoadCoverageTypeDescriptions();
    Utility.BindSimpleCombo(this.comboReserveType, (DataTable) this.dsReservePaymentTypes1.ReserveTypes);
    Utility.BindSimpleCombo(this.comboReserveSubType, (DataTable) this.dsReservePaymentTypes1.ReserveSubTypes);
    Utility.BindSimpleCombo(this.comboCoverageType, (DataTable) this.dsCoverageTypes1.CoverageTypes);
    Utility.BindSimpleCombo(this.comboCoverageSubType, (DataTable) this.dsCoverageTypes1.CoverageTypeDescriptions);
    this.OnInitializeFormComplete();
  }

  protected virtual void buttonCancel_Click(object sender, EventArgs e)
  {
    this.DialogResult = DialogResult.Cancel;
    this.Close();
  }

  protected virtual void LoadReservePaymentTypes()
  {
    DefaultDatabase.LoadDataTable((DataTable) this.dsReservePaymentTypes1.ReserveTypes, "spClaims_GetReservePaymentTypes");
  }

  internal void LoadReservePaymentSubTypes()
  {
    DefaultDatabase.LoadDataTable((DataTable) this.dsReservePaymentTypes1.ReserveSubTypes, "spClaims_GetReservePaymentSubTypes");
  }

  protected virtual void LoadCoverageTypes()
  {
    DefaultDatabase.LoadDataTable((DataTable) this.dsCoverageTypes1.CoverageTypes, "spClaims_GetCoverageTypes", new object[2]
    {
      (object) "@ShowAll",
      (object) false
    });
  }

  protected virtual void LoadCoverageTypeDescriptions()
  {
    DefaultDatabase.LoadDataTable((DataTable) this.dsCoverageTypes1.CoverageTypeDescriptions, "spClaims_GetCoverageTypeDescriptions");
  }

  private void BeforeDropDownHandler(object sender, CancelEventArgs e)
  {
    if (sender == this.comboReserveSubType)
    {
      ((UltraGridBase) this.comboReserveSubType).Rows.ColumnFilters["ResPayTypeId"].FilterConditions.Clear();
      if (((UltraDropDownBase) this.comboReserveType).SelectedRow != null)
        ((UltraGridBase) this.comboReserveSubType).Rows.ColumnFilters["ResPayTypeId"].FilterConditions.Add((FilterComparisionOperator) 0, ((UltraCombo) this.comboReserveType).Value);
      else
        ((UltraGridBase) this.comboReserveSubType).Rows.ColumnFilters["ResPayTypeId"].FilterConditions.Add((FilterComparisionOperator) 0, (SpecialFilterOperand) null);
    }
    else
    {
      if (sender != this.comboCoverageSubType)
        return;
      ((UltraGridBase) this.comboCoverageSubType).Rows.ColumnFilters["CoverageTypeId"].FilterConditions.Clear();
      if (((UltraDropDownBase) this.comboCoverageType).SelectedRow != null)
        ((UltraGridBase) this.comboCoverageSubType).Rows.ColumnFilters["CoverageTypeId"].FilterConditions.Add((FilterComparisionOperator) 0, ((UltraCombo) this.comboCoverageType).Value);
      else
        ((UltraGridBase) this.comboCoverageSubType).Rows.ColumnFilters["CoverageTypeId"].FilterConditions.Add((FilterComparisionOperator) 0, (SpecialFilterOperand) null);
    }
  }

  protected virtual void buttonSave_Click(object sender, EventArgs e) => this.Save();

  protected virtual void Save()
  {
    if (!this.ValidateForm())
      return;
    this.CreateReservePayment();
    this._currentClaimant.ReservesAndPayments.Add(this._reserve);
    this._currentClaimant.Owner.AddReserveCreatedExpense();
    this._currentClaimant.Owner.AddActivity(new ClaimActivity(Utility.ClaimActivityType.ReserveCreated, DateTime.Now, CurrentUser.Instance.UserGUID, CurrentUser.Instance.DisplayName, (Utility.ClaimStatus) this._currentClaimant.StatusId));
    this.OnAfterSaveComplete();
    this.DialogResult = DialogResult.OK;
    this.Close();
  }

  protected internal virtual void CreateReservePayment()
  {
    this._reserve = new PaymentReserve(PaymentReserveType.Reserve, (int) ((UltraCombo) this.comboReserveType).Value, ((Control) this.comboReserveType).Text, ((UltraDropDownBase) this.comboReserveSubType).SelectedRow == null ? new int?() : (int?) ((UltraCombo) this.comboReserveSubType).Value, ((UltraDropDownBase) this.comboReserveSubType).SelectedRow == null ? string.Empty : ((Control) this.comboReserveSubType).Text, ((UltraDropDownBase) this.comboCoverageType).SelectedRow == null ? new int?() : (int?) ((UltraCombo) this.comboCoverageType).Value, ((UltraDropDownBase) this.comboCoverageType).SelectedRow == null ? string.Empty : ((Control) this.comboCoverageType).Text, ((UltraDropDownBase) this.comboCoverageSubType).SelectedRow == null ? new int?() : (int?) ((UltraCombo) this.comboCoverageSubType).Value, ((UltraDropDownBase) this.comboCoverageSubType).SelectedRow == null ? string.Empty : ((Control) this.comboCoverageSubType).Text, ((Control) this.textComments).Text, Decimal.Parse(((Control) this.textAmount).Text, NumberStyles.Any), Guid.Empty, string.Empty, (bool) ((UltraDropDownBase) this.comboReserveType).SelectedRow.Cells["IsRecoveryType"].Value);
    this._reserve.IsPaymentReduction = false;
    this._reserve.DateCreated = ((UltraDateTimeEditor) this.dateTimeReserveDate).DateTime;
  }

  protected virtual bool ValidateForm()
  {
    if (((UltraDropDownBase) this.comboReserveType).SelectedRow == null)
    {
      int num = (int) MessageBox.Show(Resources.RESERVEPAYMENT_TYPEREQUIRED_ERROR, Resources.ERROR_REQUIREDFIELD_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (string.IsNullOrEmpty(((Control) this.textAmount).Text))
    {
      int num = (int) MessageBox.Show(Resources.RESERVEPAYMENT_AMOUNTREQUIRED_ERROR, Resources.ERROR_REQUIREDFIELD_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    Decimal result;
    if (!Decimal.TryParse(((Control) this.textAmount).Text, NumberStyles.Any, (IFormatProvider) null, out result))
    {
      int num = (int) MessageBox.Show(Resources.RESERVEPAYMENT_INVALIDAMOUNT_ERROR, Resources.ERROR_INVALIDENTRY_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    return this.CheckReserveLevel(result) && this.CheckClaimReserveLevel(result) && this.CheckRemainingReserve(result);
  }

  protected virtual bool CheckReserveLevel(Decimal amt)
  {
    if (Utility.GetReserveLevelGuid(amt))
      return true;
    int num = (int) MessageBox.Show("You do not have rights to create a reserve for this amount, please contact your system administrator for more information.", "Invalid Reserve Amount!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    return false;
  }

  protected virtual bool CheckClaimReserveLevel(Decimal amt)
  {
    if (Utility.GetClaimReserveLevelGuid(amt + this._currentClaimant.Owner.GetTotalReserves()))
      return true;
    int num = (int) MessageBox.Show("This reserve will exceed your claim level reserve limit. You do not have rights to create a reserve for this amount, please contact your system administrator for more information.", "Invalid Reserve Amount!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    return false;
  }

  protected bool CheckRemainingReserve(Decimal amt)
  {
    if (!SystemSettings.GetBoolSetting("CLAIMS_CHECKREMAININGRESERVE"))
      return true;
    if (((UltraDropDownBase) this.comboReserveType).SelectedRow == null || string.IsNullOrEmpty(((Control) this.textAmount).Text))
    {
      int num = (int) MessageBox.Show("This remaining reserve amount could not be determined. The reserve cannot be saved.", "Cannot Validate Amount!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if ((bool) ((UltraDropDownBase) this.comboReserveType).SelectedRow.Cells["IsRecoveryType"].Value)
      return true;
    int num1 = (int) ((UltraCombo) this.comboReserveType).Value;
    Decimal num2 = 0M;
    foreach (PaymentReserve reservesAndPayment in (Collection<PaymentReserve>) this._currentClaimant.ReservesAndPayments)
    {
      if (reservesAndPayment.EntryType == PaymentReserveType.Reserve && reservesAndPayment.ReservePaymentTypeId == num1)
        num2 += reservesAndPayment.ReservePaymentAmount;
    }
    if (!(num2 + amt < 0M))
      return true;
    int num3 = (int) MessageBox.Show("This will result in a negative reserve amount. The reserve cannot be saved.", "Invalid Amount!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    return false;
  }

  protected internal virtual bool ValidateForm_Payment()
  {
    if (((UltraDropDownBase) this.comboReserveType).SelectedRow == null)
    {
      int num = (int) MessageBox.Show(Resources.RESERVEPAYMENT_TYPEREQUIRED_ERROR, Resources.ERROR_REQUIREDFIELD_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (string.IsNullOrEmpty(((Control) this.textAmount).Text))
    {
      int num = (int) MessageBox.Show(Resources.RESERVEPAYMENT_AMOUNTREQUIRED_ERROR, Resources.ERROR_REQUIREDFIELD_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (Decimal.TryParse(((Control) this.textAmount).Text, NumberStyles.Any, (IFormatProvider) null, out Decimal _))
      return true;
    int num1 = (int) MessageBox.Show(Resources.RESERVEPAYMENT_INVALIDAMOUNT_ERROR, Resources.ERROR_INVALIDENTRY_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    return false;
  }

  protected event FormAddReserve.InitializeFormCompletedHandler InitializeFormComplete;

  private void OnInitializeFormComplete()
  {
    if (this.InitializeFormComplete == null)
      return;
    this.InitializeFormComplete((object) this, new EventArgs());
  }

  protected event EventHandler AfterSaveComplete;

  private void OnAfterSaveComplete()
  {
    if (this.AfterSaveComplete == null)
      return;
    this.AfterSaveComplete((object) this, new EventArgs());
  }

  private void comboReserveType_RowSelected(object sender, RowSelectedEventArgs e)
  {
    ((UltraDropDownBase) this.comboReserveSubType).SelectedRow = (UltraGridRow) null;
  }

  private void FormAddReserve_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    this.InitializeForm();
  }

  private void reserveSubTypesBindingSource_CurrentChanged(object sender, EventArgs e)
  {
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
    UltraGridLayout ultraGridLayout1 = new UltraGridLayout("Layout1");
    Appearance appearance7 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("ReserveTypes", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("ResPayTypeId");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("ResPayTypeDescription");
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    UltraGridLayout ultraGridLayout2 = new UltraGridLayout("Layout1");
    Appearance appearance11 = new Appearance();
    UltraGridBand ultraGridBand2 = new UltraGridBand("ReserveSubTypes", -1);
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("ResPaySubTypeId");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("ResPayTypeId");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("ResPaySubTypeDescription");
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    UltraGridLayout ultraGridLayout3 = new UltraGridLayout("Layout1");
    Appearance appearance15 = new Appearance();
    UltraGridBand ultraGridBand3 = new UltraGridBand("CoverageTypes", -1);
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("CoverageTypeId");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("CoverageType");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("CoverageTypeDescription");
    Appearance appearance16 = new Appearance();
    Appearance appearance17 = new Appearance();
    Appearance appearance18 = new Appearance();
    UltraGridLayout ultraGridLayout4 = new UltraGridLayout("Layout1");
    Appearance appearance19 = new Appearance();
    UltraGridBand ultraGridBand4 = new UltraGridBand("CoverageTypeDescriptions", -1);
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("CoverageTypeDescriptionId");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("CoverageTypeId");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("CoverageTypeDescription");
    Appearance appearance20 = new Appearance();
    Appearance appearance21 = new Appearance();
    Appearance appearance22 = new Appearance();
    Appearance appearance23 = new Appearance();
    Appearance appearance24 = new Appearance();
    Appearance appearance25 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormAddReserve));
    Appearance appearance26 = new Appearance();
    Appearance appearance27 = new Appearance();
    Appearance appearance28 = new Appearance();
    Appearance appearance29 = new Appearance();
    this.ultraLabel1 = new UltraLabel();
    this.ultraLabel2 = new UltraLabel();
    this.ultraLabel3 = new UltraLabel();
    this.ultraLabel4 = new UltraLabel();
    this.ultraLabel5 = new UltraLabel();
    this.ultraLabel6 = new UltraLabel();
    this.comboReserveType = new MGASimpleComboBox();
    this.reserveTypesBindingSource = new BindingSource(this.components);
    this.dsReservePaymentTypes1BindingSource = new BindingSource(this.components);
    this.dsReservePaymentTypes1 = new dsReservePaymentTypes();
    this.comboReserveSubType = new MGASimpleComboBox();
    this.reserveSubTypesBindingSource = new BindingSource(this.components);
    this.comboCoverageType = new MGASimpleComboBox();
    this.coverageTypesBindingSource = new BindingSource(this.components);
    this.dsCoverageTypes1 = new dsCoverageTypes();
    this.comboCoverageSubType = new MGASimpleComboBox();
    this.coverageTypeDescriptionsBindingSource = new BindingSource(this.components);
    this.textComments = new MGATextBox();
    this.textAmount = new MGATextBox();
    this.buttonSave = new MGAButton();
    this.buttonCancel = new MGAButton();
    this.reserveTypesBindingSource1 = new BindingSource(this.components);
    this.lblDate = new UltraLabel();
    this.dateTimeReserveDate = new MGADateTimePicker();
    ((ISupportInitialize) this.comboReserveType).BeginInit();
    ((ISupportInitialize) this.reserveTypesBindingSource).BeginInit();
    ((ISupportInitialize) this.dsReservePaymentTypes1BindingSource).BeginInit();
    this.dsReservePaymentTypes1.BeginInit();
    ((ISupportInitialize) this.comboReserveSubType).BeginInit();
    ((ISupportInitialize) this.reserveSubTypesBindingSource).BeginInit();
    ((ISupportInitialize) this.comboCoverageType).BeginInit();
    ((ISupportInitialize) this.coverageTypesBindingSource).BeginInit();
    this.dsCoverageTypes1.BeginInit();
    ((ISupportInitialize) this.comboCoverageSubType).BeginInit();
    ((ISupportInitialize) this.coverageTypeDescriptionsBindingSource).BeginInit();
    ((ISupportInitialize) this.textComments).BeginInit();
    ((ISupportInitialize) this.textAmount).BeginInit();
    ((ISupportInitialize) this.buttonSave).BeginInit();
    ((ISupportInitialize) this.buttonCancel).BeginInit();
    ((ISupportInitialize) this.reserveTypesBindingSource1).BeginInit();
    ((ISupportInitialize) this.dateTimeReserveDate).BeginInit();
    this.SuspendLayout();
    ((AppearanceBase) appearance1).BackColor = Color.Transparent;
    ((ControlBase) this.ultraLabel1).Appearance = (AppearanceBase) appearance1;
    ((Control) this.ultraLabel1).AutoSize = true;
    ((Control) this.ultraLabel1).Location = new Point(5, 12);
    ((Control) this.ultraLabel1).Name = "ultraLabel1";
    ((Control) this.ultraLabel1).Size = new Size(76, 15);
    ((Control) this.ultraLabel1).TabIndex = 0;
    ((Control) this.ultraLabel1).Text = "Reserve Type:";
    ((AppearanceBase) appearance2).BackColor = Color.Transparent;
    ((ControlBase) this.ultraLabel2).Appearance = (AppearanceBase) appearance2;
    ((Control) this.ultraLabel2).AutoSize = true;
    ((Control) this.ultraLabel2).Location = new Point(5, 36);
    ((Control) this.ultraLabel2).Name = "ultraLabel2";
    ((Control) this.ultraLabel2).Size = new Size(99, 15);
    ((Control) this.ultraLabel2).TabIndex = 2;
    ((Control) this.ultraLabel2).Text = "Reserve Sub-Type:";
    ((AppearanceBase) appearance3).BackColor = Color.Transparent;
    ((ControlBase) this.ultraLabel3).Appearance = (AppearanceBase) appearance3;
    ((Control) this.ultraLabel3).AutoSize = true;
    ((Control) this.ultraLabel3).Location = new Point(5, 60);
    ((Control) this.ultraLabel3).Name = "ultraLabel3";
    ((Control) this.ultraLabel3).Size = new Size(83, 15);
    ((Control) this.ultraLabel3).TabIndex = 4;
    ((Control) this.ultraLabel3).Text = "Coverage Type:";
    ((AppearanceBase) appearance4).BackColor = Color.Transparent;
    ((ControlBase) this.ultraLabel4).Appearance = (AppearanceBase) appearance4;
    ((Control) this.ultraLabel4).AutoSize = true;
    ((Control) this.ultraLabel4).Location = new Point(5, 84);
    ((Control) this.ultraLabel4).Name = "ultraLabel4";
    ((Control) this.ultraLabel4).Size = new Size(106, 15);
    ((Control) this.ultraLabel4).TabIndex = 6;
    ((Control) this.ultraLabel4).Text = "Coverage Sub-Type:";
    ((AppearanceBase) appearance5).BackColor = Color.Transparent;
    ((ControlBase) this.ultraLabel5).Appearance = (AppearanceBase) appearance5;
    ((Control) this.ultraLabel5).AutoSize = true;
    ((Control) this.ultraLabel5).Location = new Point(5, 108);
    ((Control) this.ultraLabel5).Name = "ultraLabel5";
    ((Control) this.ultraLabel5).Size = new Size(61, 15);
    ((Control) this.ultraLabel5).TabIndex = 8;
    ((Control) this.ultraLabel5).Text = "Comments:";
    ((AppearanceBase) appearance6).BackColor = Color.Transparent;
    ((ControlBase) this.ultraLabel6).Appearance = (AppearanceBase) appearance6;
    ((Control) this.ultraLabel6).AutoSize = true;
    ((Control) this.ultraLabel6).Location = new Point(5, 228);
    ((Control) this.ultraLabel6).Name = "ultraLabel6";
    ((Control) this.ultraLabel6).Size = new Size(47, 15);
    ((Control) this.ultraLabel6).TabIndex = 12;
    ((Control) this.ultraLabel6).Text = "Amount:";
    ((UltraCombo) this.comboReserveType).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.comboReserveType).DataSource = (object) this.reserveTypesBindingSource;
    ((UltraDropDownBase) this.comboReserveType).DisplayMember = "ResPayTypeDescription";
    ((UltraCombo) this.comboReserveType).DropDownStyle = (UltraComboStyle) 1;
    ((AppearanceBase) appearance7).BackColor = Color.White;
    ((AppearanceBase) appearance7).BorderColor = Color.FromArgb(78, 122, 171);
    ultraGridLayout1.Appearance = (AppearanceBase) appearance7;
    ultraGridLayout1.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand1.ColHeadersVisible = false;
    ((HeaderBase) ultraGridColumn1.Header).VisiblePosition = 0;
    ultraGridColumn1.Width = 110;
    ((HeaderBase) ultraGridColumn2.Header).VisiblePosition = 1;
    ultraGridColumn2.Width = 164;
    ultraGridBand1.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2
    });
    ultraGridLayout1.BandsSerializer.Add((object) ultraGridBand1);
    ultraGridLayout1.BorderStyle = (UIElementBorderStyle) 4;
    ((KeyedSubObjectBase) ultraGridLayout1).Key = "Layout1";
    ultraGridLayout1.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    ((AppearanceBase) appearance8).BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    ((AppearanceBase) appearance8).BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    ultraGridLayout1.Override.HotTrackRowAppearance = (AppearanceBase) appearance8;
    ((AppearanceBase) appearance9).BorderColor = Color.White;
    ultraGridLayout1.Override.RowAppearance = (AppearanceBase) appearance9;
    ultraGridLayout1.Override.RowSpacingAfter = 1;
    ((AppearanceBase) appearance10).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance10).BorderColor = Color.FromArgb((int) byte.MaxValue, 214, 88);
    ((AppearanceBase) appearance10).ForeColor = Color.Black;
    ultraGridLayout1.Override.SelectedRowAppearance = (AppearanceBase) appearance10;
    ((UltraGridBase) this.comboReserveType).Layouts.Add(ultraGridLayout1);
    ((Control) this.comboReserveType).Location = new Point(139, 12);
    this.comboReserveType.MGAStyle = (MGAStyles) 2;
    ((Control) this.comboReserveType).Name = "comboReserveType";
    ((Control) this.comboReserveType).Size = new Size(276, 21);
    ((Control) this.comboReserveType).TabIndex = 1;
    ((UltraControlBase) this.comboReserveType).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboReserveType).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.comboReserveType).ValueMember = "ResPayTypeId";
    ((UltraCombo) this.comboReserveType).RowSelected += new RowSelectedEventHandler(this.comboReserveType_RowSelected);
    this.reserveTypesBindingSource.DataMember = "ReserveTypes";
    this.reserveTypesBindingSource.DataSource = (object) this.dsReservePaymentTypes1BindingSource;
    this.dsReservePaymentTypes1BindingSource.DataSource = (object) this.dsReservePaymentTypes1;
    this.dsReservePaymentTypes1BindingSource.Position = 0;
    this.dsReservePaymentTypes1.DataSetName = "dsReservePaymentTypes";
    this.dsReservePaymentTypes1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((UltraCombo) this.comboReserveSubType).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.comboReserveSubType).DataSource = (object) this.reserveSubTypesBindingSource;
    ((UltraDropDownBase) this.comboReserveSubType).DisplayMember = "ResPaySubTypeDescription";
    ((UltraCombo) this.comboReserveSubType).DropDownStyle = (UltraComboStyle) 1;
    ((AppearanceBase) appearance11).BackColor = Color.White;
    ((AppearanceBase) appearance11).BorderColor = Color.FromArgb(78, 122, 171);
    ultraGridLayout2.Appearance = (AppearanceBase) appearance11;
    ultraGridLayout2.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand2.ColHeadersVisible = false;
    ((HeaderBase) ultraGridColumn3.Header).VisiblePosition = 0;
    ultraGridColumn3.Width = 85;
    ((HeaderBase) ultraGridColumn4.Header).VisiblePosition = 1;
    ultraGridColumn4.Width = 68;
    ((HeaderBase) ultraGridColumn5.Header).VisiblePosition = 2;
    ultraGridColumn5.Width = 121;
    ultraGridBand2.Columns.AddRange(new object[3]
    {
      (object) ultraGridColumn3,
      (object) ultraGridColumn4,
      (object) ultraGridColumn5
    });
    ultraGridLayout2.BandsSerializer.Add((object) ultraGridBand2);
    ultraGridLayout2.BorderStyle = (UIElementBorderStyle) 4;
    ((KeyedSubObjectBase) ultraGridLayout2).Key = "Layout1";
    ultraGridLayout2.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    ((AppearanceBase) appearance12).BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    ((AppearanceBase) appearance12).BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    ultraGridLayout2.Override.HotTrackRowAppearance = (AppearanceBase) appearance12;
    ((AppearanceBase) appearance13).BorderColor = Color.White;
    ultraGridLayout2.Override.RowAppearance = (AppearanceBase) appearance13;
    ultraGridLayout2.Override.RowSpacingAfter = 1;
    ((AppearanceBase) appearance14).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance14).BorderColor = Color.FromArgb((int) byte.MaxValue, 214, 88);
    ((AppearanceBase) appearance14).ForeColor = Color.Black;
    ultraGridLayout2.Override.SelectedRowAppearance = (AppearanceBase) appearance14;
    ((UltraGridBase) this.comboReserveSubType).Layouts.Add(ultraGridLayout2);
    ((Control) this.comboReserveSubType).Location = new Point(139, 36);
    this.comboReserveSubType.MGAStyle = (MGAStyles) 2;
    ((Control) this.comboReserveSubType).Name = "comboReserveSubType";
    ((Control) this.comboReserveSubType).Size = new Size(276, 21);
    ((Control) this.comboReserveSubType).TabIndex = 3;
    ((UltraControlBase) this.comboReserveSubType).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboReserveSubType).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.comboReserveSubType).ValueMember = "ResPaySubTypeId";
    ((UltraCombo) this.comboReserveSubType).BeforeDropDown += new CancelEventHandler(this.BeforeDropDownHandler);
    this.reserveSubTypesBindingSource.DataMember = "ReserveSubTypes";
    this.reserveSubTypesBindingSource.DataSource = (object) this.dsReservePaymentTypes1BindingSource;
    this.reserveSubTypesBindingSource.CurrentChanged += new EventHandler(this.reserveSubTypesBindingSource_CurrentChanged);
    ((UltraCombo) this.comboCoverageType).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.comboCoverageType).DataSource = (object) this.coverageTypesBindingSource;
    ((UltraDropDownBase) this.comboCoverageType).DisplayMember = "CoverageType";
    ((UltraCombo) this.comboCoverageType).DropDownStyle = (UltraComboStyle) 1;
    ((AppearanceBase) appearance15).BackColor = Color.White;
    ((AppearanceBase) appearance15).BorderColor = Color.FromArgb(78, 122, 171);
    ultraGridLayout3.Appearance = (AppearanceBase) appearance15;
    ultraGridLayout3.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand3.ColHeadersVisible = false;
    ((HeaderBase) ultraGridColumn6.Header).VisiblePosition = 0;
    ultraGridColumn6.Width = 81;
    ((HeaderBase) ultraGridColumn7.Header).VisiblePosition = 1;
    ultraGridColumn7.Width = 76;
    ((HeaderBase) ultraGridColumn8.Header).VisiblePosition = 2;
    ultraGridColumn8.Width = 117;
    ultraGridBand3.Columns.AddRange(new object[3]
    {
      (object) ultraGridColumn6,
      (object) ultraGridColumn7,
      (object) ultraGridColumn8
    });
    ultraGridLayout3.BandsSerializer.Add((object) ultraGridBand3);
    ultraGridLayout3.BorderStyle = (UIElementBorderStyle) 4;
    ((KeyedSubObjectBase) ultraGridLayout3).Key = "Layout1";
    ultraGridLayout3.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    ((AppearanceBase) appearance16).BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    ((AppearanceBase) appearance16).BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    ultraGridLayout3.Override.HotTrackRowAppearance = (AppearanceBase) appearance16;
    ((AppearanceBase) appearance17).BorderColor = Color.White;
    ultraGridLayout3.Override.RowAppearance = (AppearanceBase) appearance17;
    ultraGridLayout3.Override.RowSpacingAfter = 1;
    ((AppearanceBase) appearance18).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance18).BorderColor = Color.FromArgb((int) byte.MaxValue, 214, 88);
    ((AppearanceBase) appearance18).ForeColor = Color.Black;
    ultraGridLayout3.Override.SelectedRowAppearance = (AppearanceBase) appearance18;
    ((UltraGridBase) this.comboCoverageType).Layouts.Add(ultraGridLayout3);
    ((Control) this.comboCoverageType).Location = new Point(139, 60);
    this.comboCoverageType.MGAStyle = (MGAStyles) 2;
    ((Control) this.comboCoverageType).Name = "comboCoverageType";
    ((Control) this.comboCoverageType).Size = new Size(276, 21);
    ((Control) this.comboCoverageType).TabIndex = 5;
    ((UltraControlBase) this.comboCoverageType).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboCoverageType).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.comboCoverageType).ValueMember = "CoverageTypeId";
    this.coverageTypesBindingSource.DataMember = "CoverageTypes";
    this.coverageTypesBindingSource.DataSource = (object) this.dsCoverageTypes1;
    this.dsCoverageTypes1.DataSetName = "dsCoverageTypes";
    this.dsCoverageTypes1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((UltraCombo) this.comboCoverageSubType).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.comboCoverageSubType).DataSource = (object) this.coverageTypeDescriptionsBindingSource;
    ((UltraDropDownBase) this.comboCoverageSubType).DisplayMember = "CoverageTypeDescription";
    ((UltraCombo) this.comboCoverageSubType).DropDownStyle = (UltraComboStyle) 1;
    ((AppearanceBase) appearance19).BackColor = Color.White;
    ((AppearanceBase) appearance19).BorderColor = Color.FromArgb(78, 122, 171);
    ultraGridLayout4.Appearance = (AppearanceBase) appearance19;
    ultraGridLayout4.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand4.ColHeadersVisible = false;
    ((HeaderBase) ultraGridColumn9.Header).VisiblePosition = 0;
    ultraGridColumn9.Width = 107;
    ((HeaderBase) ultraGridColumn10.Header).VisiblePosition = 1;
    ultraGridColumn10.Width = 67;
    ((HeaderBase) ultraGridColumn11.Header).VisiblePosition = 2;
    ultraGridColumn11.Width = 100;
    ultraGridBand4.Columns.AddRange(new object[3]
    {
      (object) ultraGridColumn9,
      (object) ultraGridColumn10,
      (object) ultraGridColumn11
    });
    ultraGridLayout4.BandsSerializer.Add((object) ultraGridBand4);
    ultraGridLayout4.BorderStyle = (UIElementBorderStyle) 4;
    ((KeyedSubObjectBase) ultraGridLayout4).Key = "Layout1";
    ultraGridLayout4.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    ((AppearanceBase) appearance20).BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    ((AppearanceBase) appearance20).BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    ultraGridLayout4.Override.HotTrackRowAppearance = (AppearanceBase) appearance20;
    ((AppearanceBase) appearance21).BorderColor = Color.White;
    ultraGridLayout4.Override.RowAppearance = (AppearanceBase) appearance21;
    ultraGridLayout4.Override.RowSpacingAfter = 1;
    ((AppearanceBase) appearance22).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance22).BorderColor = Color.FromArgb((int) byte.MaxValue, 214, 88);
    ((AppearanceBase) appearance22).ForeColor = Color.Black;
    ultraGridLayout4.Override.SelectedRowAppearance = (AppearanceBase) appearance22;
    ((UltraGridBase) this.comboCoverageSubType).Layouts.Add(ultraGridLayout4);
    ((Control) this.comboCoverageSubType).Location = new Point(139, 84);
    this.comboCoverageSubType.MGAStyle = (MGAStyles) 2;
    ((Control) this.comboCoverageSubType).Name = "comboCoverageSubType";
    ((Control) this.comboCoverageSubType).Size = new Size(276, 21);
    ((Control) this.comboCoverageSubType).TabIndex = 7;
    ((UltraControlBase) this.comboCoverageSubType).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboCoverageSubType).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.comboCoverageSubType).ValueMember = "CoverageTypeDescriptionId";
    ((UltraCombo) this.comboCoverageSubType).BeforeDropDown += new CancelEventHandler(this.BeforeDropDownHandler);
    this.coverageTypeDescriptionsBindingSource.DataMember = "CoverageTypeDescriptions";
    this.coverageTypeDescriptionsBindingSource.DataSource = (object) this.dsCoverageTypes1;
    ((AppearanceBase) appearance23).BackColor = Color.White;
    ((AppearanceBase) appearance23).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance23).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textComments).Appearance = (AppearanceBase) appearance23;
    ((Control) this.textComments).BackColor = Color.White;
    ((Control) this.textComments).Location = new Point(139, 108);
    this.textComments.MGAStyle = (MGAStyles) 2;
    ((UltraTextEditor) this.textComments).Multiline = true;
    ((Control) this.textComments).Name = "textComments";
    ((Control) this.textComments).Size = new Size(276, 94);
    ((Control) this.textComments).TabIndex = 9;
    ((UltraControlBase) this.textComments).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textComments).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance24).BackColor = Color.White;
    ((AppearanceBase) appearance24).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance24).ForeColor = Color.Black;
    ((AppearanceBase) appearance24).TextHAlignAsString = "Right";
    ((TextEditorControlBase) this.textAmount).Appearance = (AppearanceBase) appearance24;
    ((Control) this.textAmount).BackColor = Color.White;
    ((Control) this.textAmount).Location = new Point(139, 228);
    this.textAmount.MGAStyle = (MGAStyles) 2;
    ((Control) this.textAmount).Name = "textAmount";
    ((Control) this.textAmount).Size = new Size(138, 20);
    ((Control) this.textAmount).TabIndex = 13;
    ((UltraControlBase) this.textAmount).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textAmount).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance25).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance25).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance25).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance25).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance25).Image = componentResourceManager.GetObject("appearance25.Image");
    ((AppearanceBase) appearance25).ImageHAlign = (HAlign) 1;
    ((AppearanceBase) appearance25).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonSave).Appearance = (AppearanceBase) appearance25;
    ((Control) this.buttonSave).Location = new Point(240 /*0xF0*/, 259);
    ((Control) this.buttonSave).Name = "buttonSave";
    ((Control) this.buttonSave).Size = new Size(87, 34);
    ((Control) this.buttonSave).TabIndex = 14;
    ((Control) this.buttonSave).Text = "Save";
    ((UltraControlBase) this.buttonSave).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonSave).Click += new EventHandler(this.buttonSave_Click);
    ((AppearanceBase) appearance26).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance26).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance26).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance26).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance26).Image = componentResourceManager.GetObject("appearance26.Image");
    ((AppearanceBase) appearance26).ImageHAlign = (HAlign) 1;
    ((AppearanceBase) appearance26).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonCancel).Appearance = (AppearanceBase) appearance26;
    ((UltraButtonBase) this.buttonCancel).DialogResult = DialogResult.Cancel;
    ((Control) this.buttonCancel).Location = new Point(333, 259);
    ((Control) this.buttonCancel).Name = "buttonCancel";
    ((Control) this.buttonCancel).Size = new Size(82, 34);
    ((Control) this.buttonCancel).TabIndex = 15;
    ((Control) this.buttonCancel).Text = "Cancel";
    ((UltraControlBase) this.buttonCancel).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonCancel).Click += new EventHandler(this.buttonCancel_Click);
    this.reserveTypesBindingSource1.DataMember = "ReserveTypes";
    this.reserveTypesBindingSource1.DataSource = (object) this.dsReservePaymentTypes1BindingSource;
    ((AppearanceBase) appearance27).BackColor = Color.Transparent;
    ((ControlBase) this.lblDate).Appearance = (AppearanceBase) appearance27;
    ((Control) this.lblDate).AutoSize = true;
    ((Control) this.lblDate).Location = new Point(5, 200);
    ((Control) this.lblDate).Name = "lblDate";
    ((Control) this.lblDate).Size = new Size(32 /*0x20*/, 15);
    ((Control) this.lblDate).TabIndex = 10;
    ((Control) this.lblDate).Text = "Date:";
    ((AppearanceBase) appearance28).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraDateTimeEditor) this.dateTimeReserveDate).Appearance = (AppearanceBase) appearance28;
    ((AppearanceBase) appearance29).AlphaLevel = (short) 14;
    ((AppearanceBase) appearance29).BackColor = Color.FromArgb(0, 0, 246, 253);
    ((AppearanceBase) appearance29).BackColor2 = Color.FromArgb(133, 162, 221);
    ((AppearanceBase) appearance29).BackColorAlpha = (Alpha) 2;
    ((AppearanceBase) appearance29).BackGradientAlignment = (GradientAlignment) 4;
    ((AppearanceBase) appearance29).BackGradientStyle = (GradientStyle) 5;
    ((AppearanceBase) appearance29).BorderAlpha = (Alpha) 1;
    ((AppearanceBase) appearance29).BorderColor = Color.FromArgb(78, 122, 171);
    ((AppearanceBase) appearance29).ForeColor = Color.FromArgb(49, 85, 153);
    ((AppearanceBase) appearance29).ForegroundAlpha = (Alpha) 2;
    ((UltraDateTimeEditor) this.dateTimeReserveDate).ButtonAppearance = (AppearanceBase) appearance29;
    ((Control) this.dateTimeReserveDate).Location = new Point(139, 205);
    this.dateTimeReserveDate.MGAStyle = (MGAStyles) 2;
    ((Control) this.dateTimeReserveDate).Name = "dateTimeReserveDate";
    ((Control) this.dateTimeReserveDate).Size = new Size(92, 20);
    ((Control) this.dateTimeReserveDate).TabIndex = 11;
    ((UltraControlBase) this.dateTimeReserveDate).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dateTimeReserveDate).UseOsThemes = (DefaultableBoolean) 2;
    this.AcceptButton = (IButtonControl) this.buttonSave;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.CancelButton = (IButtonControl) this.buttonCancel;
    this.ClientSize = new Size(425, 296);
    this.ControlBox = false;
    this.Controls.Add((Control) this.dateTimeReserveDate);
    this.Controls.Add((Control) this.lblDate);
    this.Controls.Add((Control) this.buttonCancel);
    this.Controls.Add((Control) this.buttonSave);
    this.Controls.Add((Control) this.textAmount);
    this.Controls.Add((Control) this.textComments);
    this.Controls.Add((Control) this.comboCoverageSubType);
    this.Controls.Add((Control) this.comboCoverageType);
    this.Controls.Add((Control) this.comboReserveSubType);
    this.Controls.Add((Control) this.comboReserveType);
    this.Controls.Add((Control) this.ultraLabel6);
    this.Controls.Add((Control) this.ultraLabel5);
    this.Controls.Add((Control) this.ultraLabel4);
    this.Controls.Add((Control) this.ultraLabel3);
    this.Controls.Add((Control) this.ultraLabel2);
    this.Controls.Add((Control) this.ultraLabel1);
    this.Font = new Font("Tahoma", 8.25f);
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.Name = nameof (FormAddReserve);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Add Reserve";
    this.Load += new EventHandler(this.FormAddReserve_Load);
    ((ISupportInitialize) this.comboReserveType).EndInit();
    ((ISupportInitialize) this.reserveTypesBindingSource).EndInit();
    ((ISupportInitialize) this.dsReservePaymentTypes1BindingSource).EndInit();
    this.dsReservePaymentTypes1.EndInit();
    ((ISupportInitialize) this.comboReserveSubType).EndInit();
    ((ISupportInitialize) this.reserveSubTypesBindingSource).EndInit();
    ((ISupportInitialize) this.comboCoverageType).EndInit();
    ((ISupportInitialize) this.coverageTypesBindingSource).EndInit();
    this.dsCoverageTypes1.EndInit();
    ((ISupportInitialize) this.comboCoverageSubType).EndInit();
    ((ISupportInitialize) this.coverageTypeDescriptionsBindingSource).EndInit();
    ((ISupportInitialize) this.textComments).EndInit();
    ((ISupportInitialize) this.textAmount).EndInit();
    ((ISupportInitialize) this.buttonSave).EndInit();
    ((ISupportInitialize) this.buttonCancel).EndInit();
    ((ISupportInitialize) this.reserveTypesBindingSource1).EndInit();
    ((ISupportInitialize) this.dateTimeReserveDate).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  protected delegate void InitializeFormCompletedHandler(object sender, EventArgs e);
}
