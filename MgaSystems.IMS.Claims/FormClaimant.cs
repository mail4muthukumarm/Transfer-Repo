// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.FormClaimant
// Assembly: MgaSystems.IMS.Claims, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FCD9D0B7-28CF-40B9-8EB7-297871E1AF5F
// Assembly location: F:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.Layout;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinMaskedEdit;
using Infragistics.Win.UltraWinScrollBar;
using Infragistics.Win.UltraWinStatusBar;
using Infragistics.Win.UltraWinTabControl;
using Infragistics.Win.UltraWinTabs;
using Infragistics.Win.UltraWinToolbars;
using Infragistics.Win.UltraWinToolTip;
using Mga.Wpf.Ims.DialogService;
using MGASystems.AddressResolver;
using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Claims.Claims;
using MGASystems.IMS.Claims.Properties;
using MGASystems.IMS.DocumentAutomation.TemplateDocuments;
using MGASystems.IMS.NoteDocuments;
using MGASystems.IMS.NoteDocuments.NoteDiarySystem;
using MGASystems.IMS.Security;
using MGASystems.Tools;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.Layout;

#nullable disable
namespace MGASystems.IMS.Claims;

[DocumentFolderFilter("Claims-Claimant")]
public class FormClaimant : 
  FormBase,
  ISupportNoteSystem,
  IRecreatableEntity,
  ISupportDocumentSystem,
  ISupportTemplateDocs
{
  protected Claim _currentClaim;
  protected Claimant _currentClaimant;
  protected int _initValueHash;
  private bool _showColors;
  private IWinMsgBoxService msgBoxSvc;
  private List<FormClaimant.Cached_AddressResolverProperties> _addressResolverCache = new List<FormClaimant.Cached_AddressResolverProperties>();
  private List<FormClaimant.Cached_TextProperties> _textBoxCache = new List<FormClaimant.Cached_TextProperties>();
  private List<FormClaimant.Cached_ComboProperties> _comboBoxCache = new List<FormClaimant.Cached_ComboProperties>();
  private IContainer components;
  private Panel FormClaimant_Fill_Panel;
  private UltraToolbarsDockArea _FormClaimant_Toolbars_Dock_Area_Left;
  private UltraToolbarsDockArea _FormClaimant_Toolbars_Dock_Area_Right;
  private UltraToolbarsDockArea _FormClaimant_Toolbars_Dock_Area_Top;
  private UltraToolbarsDockArea _FormClaimant_Toolbars_Dock_Area_Bottom;
  private UltraTabSharedControlsPage ultraTabSharedControlsPage2;
  protected Label label22;
  protected MGACheckBox checkClaimants_Closed;
  protected MGAMaskedEdit maskedEditClaimants_SSNFEIN;
  protected Label label19;
  protected Label label17;
  protected Label label14;
  private Label label11;
  protected Label label13;
  protected MGATextBox textClaimants_CorporationName;
  private Label label12;
  protected MGATextBox textClaimants_FirstName;
  protected MGATextBox textClaimants_MiddleName;
  protected MGATextBox textClaimants_LastName;
  protected MGACheckBox checkClaimants_IsInsured;
  protected UltraOptionSet optionClaimants_ClaimantType;
  private UltraTabPageControl tabPageClaimantReservesPayments;
  private dsClaimOptions dsClaimOptions1;
  protected MGATextBox textClaimants_Comments;
  protected Label label1;
  protected UltraToolTipManager ultraToolTipManager1;
  protected UltraTabControl tabControlClaimants;
  protected UltraTabPageControl tabPageClaimant;
  protected UltraTabPageControl tabPageLegal;
  protected UltraTabPageControl tabPageClaimSpecifications;
  protected UltraTabPageControl ultraTabPageControl1;
  protected MGAMaskedEdit textClaimants_ClaimantAttorneyFEIN;
  protected Label label54;
  protected MGACheckBox checkClaimants_PublishedDecision;
  protected MGATextBox textClaimants_Judge;
  protected Label label49;
  protected MGATextBox textClaimants_ClaimantAttorney;
  protected MGATextBox textClaimants_ClaimantLawFirm;
  protected Label label47;
  protected Label label48;
  protected AddressResolver_MULTI addResolverClaimants_ClaimantAttorney;
  public MgaPhoneNumberEntry phoneClaimants_ClaimantAttorney;
  protected UltraOptionSet optionClaimantAttorneyEntityType;
  protected MGADateTimePicker dateTimeClaimant_DateDenied;
  protected MGATextBox textClaimants_LastModifiedBy;
  protected MGADateTimePicker dateTimeClaimants_LastModified;
  protected MGATextBox textClaimant_EnteredBy;
  protected MGADateTimePicker dateTimeClaimant_DateEntered;
  protected MGADateTimePicker dateTimeClaimant_DateReported;
  protected UltraGrid gridClaimant_Coverages;
  protected MGADateTimePicker dateTimeClaimants_OutsideInvestigatorHireDate;
  protected Label label42;
  protected MGACheckBox checkClaimants_Settled;
  protected Label label41;
  protected MGASimpleComboBox comboClaimants_SettlementType;
  protected MGATextBox textClaimants_OutsideInvestigator;
  protected Label label40;
  protected Label label29;
  protected MGASimpleComboBox comboClaimants_OutsideAdjuster;
  protected Label label26;
  protected MGASimpleComboBox comboClaimants_ManagedCare;
  protected Label label25;
  protected MGASimpleComboBox comboClaimants_LossType;
  protected Label label24;
  protected MGASimpleComboBox comboClaimant_AccidentTypes;
  protected Label label23;
  public UltraToolbarsManager ultraToolbarsManager1;
  protected MGAMaskedEdit textClaimants_DefenseFEIN;
  protected MGATextBox textClaimants_DefenseAttorney;
  protected MGATextBox textClaimants_DefenseFirm;
  protected AddressResolver_MULTI addResolverClaimants_DefenseAttorney;
  protected MGATextBox textClaimants_UserDefinedClaimantsID;
  protected Label label16;
  protected AddressResolver_MULTI addResolverClaimants_Mailing;
  protected Label label15;
  protected AddressResolver_MULTI addResolverClaimants_Primary;
  protected MgaPhoneNumberEntry phoneClaimants_Primary;
  protected MgaPhoneNumberEntry phoneClaimants_Mailing;
  protected Label label20;
  protected MGASimpleComboBox comboClaimants_Gender;
  protected MGADateTimePicker dateTimeClaimants_DOB;
  protected Label label18;
  protected MGATextBox textClaimants_EmailAddress;
  protected MGACheckBox checkClaimants_MedicareEligible;
  protected Label label50;
  protected Label label38;
  protected Label label39;
  protected Label label27;
  protected Label label28;
  protected Label label21;
  protected Label label53;
  protected Label label52;
  protected Label label46;
  protected MGADateTimePicker dateTimeClaimants_SuitAnswered;
  protected Label label43;
  protected MGADateTimePicker dateTimeClaimants_SuitServed;
  protected Label label44;
  protected MGACheckBox checkClaimants_SuitServed;
  public MgaPhoneNumberEntry phoneClaimants_DefenseAttorney;
  protected UltraOptionSet optionDefenseEntityType;
  protected Label label45;
  protected UltraGrid gridClaimants_ReservePayments;
  private ToolTip toolTip1;
  protected dsReservesPayments dsReservesPayments1;
  protected MGASimpleComboBox cboDefenseAttorney;
  protected MGASimpleComboBox cboClaimantAttorney;
  protected UltraStatusBar statusBar1;
  private UltraTabPageControl ultraTabPageControlVerisk;
  protected MGATextBox Verisk_txtHICNMBI;
  protected MGATextBox Verisk_txtICDCode;
  protected LinkLabel lnkICD;
  protected Label Verisk_label5;
  protected Label Verisk_label13;
  protected MGASimpleComboBox Verisk_cboRepType;
  protected Label Verisk_label12;
  protected MGADateTimePicker Verisk_dtORMTermination;
  protected Label Verisk_label11;
  protected MGASimpleComboBox Verisk_cboORMIndicator;
  protected Label Verisk_label10;
  protected Label Verisk_label9;
  protected MGATextBox Verisk_txtApprovalComments;
  protected Label Verisk_label8;
  protected MGASimpleComboBox Verisk_cboMedicareApproval;
  protected Label Verisk_label1;
  protected MGASimpleComboBox Verisk_cboInsuranceType;
  protected Label Verisk_label7;
  protected Label Verisk_label6;
  protected MGADateTimePicker Verisk_dtInjuredDeathDate;
  protected Label Verisk_label4;
  protected Label Verisk_label3;
  protected MGADateTimePicker Verisk_dtFundingDelayed;
  protected Label Verisk_label2;
  protected MGADateTimePicker Verisk_dtExhaustDate;
  protected MGAMaskedEdit Verisk_mgaNoFaultPolicyLimit;

  protected bool BaseIsClosing { get; private set; }

  protected Claim CurrentClaim
  {
    get
    {
      if (this._currentClaim == null)
        this._currentClaim = ObjectFactory.Instance.CreateObjectAs<Claim>(typeof (Claim));
      return this._currentClaim;
    }
  }

  public Claimant CurrentClaimant
  {
    get => this._currentClaimant;
    set
    {
      this._currentClaimant = value;
      if (value == null)
        return;
      this.HookUpClaimantHandlers(this._currentClaimant);
    }
  }

  public Guid SelectedOutsideAdjuster
  {
    get
    {
      return ((UltraDropDownBase) this.comboClaimants_OutsideAdjuster).SelectedRow == null ? Guid.Empty : new Guid(((UltraCombo) this.comboClaimants_OutsideAdjuster).Value.ToString());
    }
  }

  protected bool SetFromClaimant { get; set; }

  public FormClaimant() => this.InitializeComponent();

  public FormClaimant(Claim claim)
  {
    this.InitializeComponent();
    this.SetFromClaimant = false;
    if (string.IsNullOrEmpty(DefaultDatabase.ConnectionString))
      return;
    this._currentClaim = claim;
    this._currentClaimant = ObjectFactory.Instance.CreateObjectAs<Claimant>((object) claim);
    this._currentClaimant.EditState = Claimant.ClaimantState.New;
  }

  public FormClaimant(Claim claim, Claimant claimant)
  {
    this.InitializeComponent();
    this.SetFromClaimant = true;
    if (!string.IsNullOrEmpty(DefaultDatabase.ConnectionString))
    {
      this._currentClaim = claim;
      this._currentClaimant = claimant;
    }
    this._currentClaimant.EditState = Claimant.ClaimantState.Updated;
    int? claimId = this._currentClaim.ClaimId;
    if (!claimId.HasValue)
      return;
    string action = $"{CurrentUser.Instance.DisplayNameLastFirst} open claimant {claimant.DisplayName}.";
    claimId = this._currentClaim.ClaimId;
    int identifier = claimId.Value;
    Utility.LogAction(action, identifier);
  }

  public FormClaimant(Guid claimantGuid)
  {
  }

  public event EventHandler<EventArgs> AfterClearScreen;

  protected void OnAfterClearScreen()
  {
    EventHandler<EventArgs> afterClearScreen = this.AfterClearScreen;
    if (afterClearScreen == null)
      return;
    afterClearScreen((object) this, new EventArgs());
  }

  public event EventHandler<EventArgs> ClaimOptionsLoaded;

  protected void OnClaimOptionsLoaded()
  {
    EventHandler<EventArgs> claimOptionsLoaded = this.ClaimOptionsLoaded;
    if (claimOptionsLoaded == null)
      return;
    claimOptionsLoaded((object) this, new EventArgs());
  }

  protected virtual void InitializeForm()
  {
    this.Cursor = MgaCursors.Default;
    if (this.SetFromClaimant)
    {
      this.optionClaimantAttorneyEntityType.Value = this.CurrentClaimant.LegalInformation.ClaimantAttorneyEntityType == ClaimantLegalInformation.EntityType.Individual ? (object) "I" : (object) "C";
      this.optionDefenseEntityType.Value = this.CurrentClaimant.LegalInformation.DefenseFirmEntityType == ClaimantLegalInformation.EntityType.Individual ? (object) "I" : (object) "C";
    }
    else
    {
      this.optionClaimantAttorneyEntityType.Value = (object) "I";
      this.optionDefenseEntityType.Value = (object) "I";
    }
    this.optionClaimants_ClaimantType.Value = (object) "I";
    ((UltraDateTimeEditor) this.dateTimeClaimant_DateReported).Value = (object) DateTime.Now;
    ((Control) this.dateTimeClaimants_SuitServed).DataBindings.Add("Enabled", (object) this.checkClaimants_SuitServed, "Checked");
    ((Control) this.dateTimeClaimants_SuitAnswered).DataBindings.Add("Enabled", (object) this.checkClaimants_SuitServed, "Checked");
    ((Control) this.comboClaimants_SettlementType).DataBindings.Add("Enabled", (object) this.checkClaimants_Settled, "Checked");
    this.SetAddressResolverProperties();
    this.BindGenderDropDown();
    this.LoadClaimOptions();
    ((UltraDateTimeEditor) this.dateTimeClaimant_DateDenied).Value = (object) null;
    this.BindCoveragesGrid();
    this.SetToolbarEnabled();
    this.LoadLocationVehicles();
  }

  protected virtual void DisplayCurrentClaimant()
  {
    Guid claimantGuid = this.CurrentClaimant.ClaimantGuid;
    if (this.CurrentClaimant.ClaimantGuid != Guid.Empty)
      this.CurrentClaimant = this.CurrentClaim.GetClaimant(this.CurrentClaimant.ClaimantGuid);
    this.DisplayClaimantHeaderInformation(this.CurrentClaimant);
    this.DisplayClaimantAddressInformation(this.CurrentClaimant);
    this.DisplayClaimantClaimInformation(this.CurrentClaimant);
    this.DisplayClaimantLegalInformation(this.CurrentClaimant);
    this.HookUpClaimantHandlers(this.CurrentClaimant);
    this.CreateReservePaymentDataset();
  }

  protected virtual void BindCoveragesGrid()
  {
    ((UltraGridBase) this.gridClaimant_Coverages).DataSource = (object) this.CurrentClaim.Lines;
    ((UltraGridBase) this.gridClaimant_Coverages).DisplayLayout.Bands[0].Columns["EntityGuid"].Hidden = true;
    ((HeaderBase) ((UltraGridBase) this.gridClaimant_Coverages).DisplayLayout.Bands[0].Columns["EntityName"].Header).Caption = "Coverage";
    ((HeaderBase) ((UltraGridBase) this.gridClaimant_Coverages).DisplayLayout.Bands[0].Columns["EntityName"].Header).Appearance.TextHAlign = (HAlign) 1;
    ((UltraGridBase) this.gridClaimant_Coverages).DisplayLayout.Bands[0].Columns.Add("Select", string.Empty);
    UltraGridColumn column = ((UltraGridBase) this.gridClaimant_Coverages).DisplayLayout.Bands[0].Columns["Select"];
    column.Style = (ColumnStyle) 3;
    column.DataType = typeof (bool);
    ((HeaderBase) column.Header).VisiblePosition = 0;
    column.Width = 15;
    if (((DisposableObjectCollectionBase) ((UltraGridBase) this.gridClaimant_Coverages).Rows).Count != 1)
      return;
    ((UltraGridBase) this.gridClaimant_Coverages).Rows[0].Cells["Select"].Value = (object) true;
    ((Control) this.gridClaimant_Coverages).Enabled = false;
  }

  private void UnBindClaimOptions()
  {
    ((UltraDropDownBase) this.comboClaimant_AccidentTypes).DisplayMember = string.Empty;
    ((UltraDropDownBase) this.comboClaimant_AccidentTypes).ValueMember = string.Empty;
    ((UltraGridBase) this.comboClaimant_AccidentTypes).DataSource = (object) null;
    ((UltraDropDownBase) this.comboClaimants_LossType).DisplayMember = string.Empty;
    ((UltraDropDownBase) this.comboClaimants_LossType).ValueMember = string.Empty;
    ((UltraGridBase) this.comboClaimants_LossType).DataSource = (object) null;
    ((UltraDropDownBase) this.comboClaimants_ManagedCare).DisplayMember = string.Empty;
    ((UltraDropDownBase) this.comboClaimants_ManagedCare).ValueMember = string.Empty;
    ((UltraGridBase) this.comboClaimants_ManagedCare).DataSource = (object) null;
    ((UltraDropDownBase) this.comboClaimants_OutsideAdjuster).DisplayMember = string.Empty;
    ((UltraDropDownBase) this.comboClaimants_OutsideAdjuster).ValueMember = string.Empty;
    ((UltraGridBase) this.comboClaimants_OutsideAdjuster).DataSource = (object) null;
    ((UltraDropDownBase) this.comboClaimants_SettlementType).DisplayMember = string.Empty;
    ((UltraDropDownBase) this.comboClaimants_SettlementType).ValueMember = string.Empty;
    ((UltraGridBase) this.comboClaimants_SettlementType).DataSource = (object) null;
  }

  private void SetAddressResolverProperties()
  {
  }

  protected virtual void BindClaimOptions()
  {
    ((UltraDropDownBase) this.comboClaimant_AccidentTypes).DisplayMember = "AccidentType";
    ((UltraDropDownBase) this.comboClaimant_AccidentTypes).ValueMember = "AccidentTypeId";
    ((UltraGridBase) this.comboClaimant_AccidentTypes).DataSource = (object) this.dsClaimOptions1.AccidentTypes;
    ((UltraDropDownBase) this.comboClaimants_LossType).ValueMember = "LossTypeId";
    ((UltraDropDownBase) this.comboClaimants_LossType).DisplayMember = "LossType";
    ((UltraGridBase) this.comboClaimants_LossType).DataSource = (object) this.dsClaimOptions1.LossTypes;
    ((UltraDropDownBase) this.comboClaimants_ManagedCare).ValueMember = "ManagedCareId";
    ((UltraDropDownBase) this.comboClaimants_ManagedCare).DisplayMember = "FacilityName";
    ((UltraGridBase) this.comboClaimants_ManagedCare).DataSource = (object) this.dsClaimOptions1.ManagedCareFacilities;
    ((UltraDropDownBase) this.comboClaimants_OutsideAdjuster).ValueMember = "AdjusterGuid";
    ((UltraDropDownBase) this.comboClaimants_OutsideAdjuster).DisplayMember = "Adjuster";
    ((UltraGridBase) this.comboClaimants_OutsideAdjuster).DataSource = (object) this.dsClaimOptions1.OutsideAdjusters;
    ((UltraDropDownBase) this.comboClaimants_SettlementType).ValueMember = "SettlementTypeId";
    ((UltraDropDownBase) this.comboClaimants_SettlementType).DisplayMember = "SettlementType";
    ((UltraGridBase) this.comboClaimants_SettlementType).DataSource = (object) this.dsClaimOptions1.SettlementTypes;
  }

  private void BindGenderDropDown()
  {
    ((UltraGridBase) this.comboClaimants_Gender).DataSource = (object) DefaultDatabase.ExecuteDataSet("spClaims_GetGenderList");
    ((UltraDropDownBase) this.comboClaimants_Gender).ValueMember = "GenderId";
    ((UltraDropDownBase) this.comboClaimants_Gender).DisplayMember = "Gender";
  }

  private void LoadClaimOptions()
  {
    this.UnBindClaimOptions();
    using (BackgroundWorker backgroundWorker = new BackgroundWorker())
    {
      backgroundWorker.DoWork += (DoWorkEventHandler) ((sender, e) => DefaultDatabase.LoadDataSet((DataSet) this.dsClaimOptions1, new string[5]
      {
        this.dsClaimOptions1.AccidentTypes.TableName,
        this.dsClaimOptions1.LossTypes.TableName,
        this.dsClaimOptions1.ManagedCareFacilities.TableName,
        this.dsClaimOptions1.OutsideAdjusters.TableName,
        this.dsClaimOptions1.SettlementTypes.TableName
      }, "spClaims_GetClaimOptions"));
      backgroundWorker.RunWorkerCompleted += (RunWorkerCompletedEventHandler) ((sender, e) =>
      {
        if (e.Error == null)
        {
          this.BindClaimOptions();
          this.OnClaimOptionsLoaded();
        }
        else
          ExceptionDispatchInfo.Capture(e.Error).Throw();
      });
      backgroundWorker.RunWorkerAsync();
    }
  }

  protected virtual void optionClaimants_ClaimantType_ValueChanged(object sender, EventArgs e)
  {
    bool flag = this.optionClaimants_ClaimantType.CheckedIndex == 0;
    if (!flag)
      ((UltraCombo) this.comboClaimants_Gender).Value = (object) "0";
    else
      ((Control) this.comboClaimants_Gender).ResetText();
    ((Control) this.comboClaimants_Gender).Enabled = flag;
    ((Control) this.textClaimants_CorporationName).Enabled = !flag;
    ((Control) this.textClaimants_FirstName).Enabled = flag;
    ((Control) this.textClaimants_MiddleName).Enabled = flag;
    ((Control) this.textClaimants_LastName).Enabled = flag;
    ((UltraMaskedEdit) this.maskedEditClaimants_SSNFEIN).InputMask = this.optionClaimants_ClaimantType.CheckedIndex != 0 ? "99-9999999" : "999-99-9999";
  }

  private void optionDefenseEntityType_ValueChanged(object sender, EventArgs e)
  {
    ((UltraMaskedEdit) this.textClaimants_DefenseFEIN).InputMask = this.optionDefenseEntityType.CheckedIndex != 0 ? "99-9999999" : "999-99-9999";
  }

  private void optionClaimantAttorneyEntityType_ValueChanged(object sender, EventArgs e)
  {
    ((UltraMaskedEdit) this.textClaimants_ClaimantAttorneyFEIN).InputMask = this.optionClaimantAttorneyEntityType.CheckedIndex != 0 ? "99-9999999" : "999-99-9999";
  }

  public void CreateClaimant()
  {
    if (this.CurrentClaimant == null)
      this.CurrentClaimant = ObjectFactory.Instance.CreateObjectAs<Claimant>(typeof (Claimant), (object) this.CurrentClaim);
    this.CreateClaimantHeader(this.CurrentClaimant);
    this.CreateClaimantAddresses(this.CurrentClaimant);
    this.CreateClaimantClaimInformation(this.CurrentClaimant);
    this.CreateClaimantLegalInformation(this.CurrentClaimant);
  }

  protected virtual void CreateClaimantHeader(Claimant c)
  {
    c.ClaimantInformation.Gender = ((UltraDropDownBase) this.comboClaimants_Gender).SelectedRow == null ? 0 : int.Parse(((UltraCombo) this.comboClaimants_Gender).Value.ToString());
    c.UserDefinedClaimantId = ((Control) this.textClaimants_UserDefinedClaimantsID).Text;
    c.EmailAddress = ((Control) this.textClaimants_EmailAddress).Text;
    c.IsInsured = ((UltraToggleEditorBase) this.checkClaimants_IsInsured).Checked;
    c.StatusId = ((UltraToggleEditorBase) this.checkClaimants_Closed).Checked ? 1 : 0;
    c.ClaimantComments = ((Control) this.textClaimants_Comments).Text;
    c.DateReported = new DateTime?(((UltraDateTimeEditor) this.dateTimeClaimant_DateReported).DateTime);
    c.MedicareEligible = ((UltraToggleEditorBase) this.checkClaimants_MedicareEligible).Checked;
    if (this.optionClaimants_ClaimantType.CheckedIndex == 0)
    {
      c.ClaimantInformation.FirstName = ((Control) this.textClaimants_FirstName).Text;
      c.ClaimantInformation.MiddleName = ((Control) this.textClaimants_MiddleName).Text;
      c.ClaimantInformation.LastName = ((Control) this.textClaimants_LastName).Text;
      c.ClaimantInformation.SocialSecurityNumber = ((Control) this.maskedEditClaimants_SSNFEIN).Text;
      c.ClaimantInformation.DateOfBirth = new DateTime?(((UltraDateTimeEditor) this.dateTimeClaimants_DOB).DateTime);
      c.ClaimantInformation.CorporationName = string.Empty;
      c.ClaimantInformation.Fein = string.Empty;
    }
    else
    {
      c.ClaimantInformation.CorporationName = ((Control) this.textClaimants_CorporationName).Text;
      c.ClaimantInformation.DateOfBirth = new DateTime?();
      c.ClaimantInformation.Fein = ((Control) this.maskedEditClaimants_SSNFEIN).Text;
      c.ClaimantInformation.FirstName = string.Empty;
      c.ClaimantInformation.MiddleName = string.Empty;
      c.ClaimantInformation.LastName = string.Empty;
      c.ClaimantInformation.SocialSecurityNumber = string.Empty;
    }
  }

  private void CreateClaimantClaimInformation(Claimant c)
  {
    c.AccidentTypeId = ((UltraDropDownBase) this.comboClaimant_AccidentTypes).SelectedRow == null || (int) ((UltraCombo) this.comboClaimant_AccidentTypes).Value == -1 ? new int?() : new int?((int) ((UltraCombo) this.comboClaimant_AccidentTypes).Value);
    c.LossTypeId = ((UltraDropDownBase) this.comboClaimants_LossType).SelectedRow == null || (int) ((UltraCombo) this.comboClaimants_LossType).Value == -1 ? new int?() : new int?((int) ((UltraCombo) this.comboClaimants_LossType).Value);
    c.ManagedCareId = ((UltraDropDownBase) this.comboClaimants_ManagedCare).SelectedRow == null || (int) ((UltraCombo) this.comboClaimants_ManagedCare).Value == -1 ? new int?() : (int?) ((UltraCombo) this.comboClaimants_ManagedCare).Value;
    c.OutsideAdjusterGuid = ((UltraDropDownBase) this.comboClaimants_OutsideAdjuster).SelectedRow == null || ((UltraCombo) this.comboClaimants_OutsideAdjuster).Value.Equals((object) Guid.Empty) ? Guid.Empty : new Guid(((UltraCombo) this.comboClaimants_OutsideAdjuster).Value.ToString());
    c.OutsideInvestigator = ((Control) this.textClaimants_OutsideInvestigator).Text;
    c.OutsideInvestigatorHireDate = (DateTime?) ((UltraDateTimeEditor) this.dateTimeClaimants_OutsideInvestigatorHireDate).Value;
    c.IsSettled = ((UltraToggleEditorBase) this.checkClaimants_Settled).Checked;
    c.SettlementTypeId = ((UltraDropDownBase) this.comboClaimants_SettlementType).SelectedRow == null || (int) ((UltraCombo) this.comboClaimants_SettlementType).Value == -1 ? new int?() : (int?) ((UltraCombo) this.comboClaimants_SettlementType).Value;
    c.DateReported = (DateTime?) ((UltraDateTimeEditor) this.dateTimeClaimant_DateReported).Value;
    c.DateDenied = (DateTime?) ((UltraDateTimeEditor) this.dateTimeClaimant_DateDenied).Value;
  }

  private void CreateClaimantAddresses(Claimant c)
  {
    if (!c.PrimaryAddress.AddressId.HasValue)
      c.PrimaryAddress = Utility.CreateAddress(this.addResolverClaimants_Primary, this.phoneClaimants_Primary);
    else
      Utility.CreateAddress(c.PrimaryAddress, this.addResolverClaimants_Primary, this.phoneClaimants_Primary);
    if (c.MailingAddress == null)
    {
      c.MailingAddress = Utility.CreateAddress(this.addResolverClaimants_Mailing, this.phoneClaimants_Mailing);
      this.phoneClaimants_Mailing.NumberManager.Copy(c.MailingAddress.NumberManager);
    }
    else
      Utility.CreateAddress(c.MailingAddress, this.addResolverClaimants_Mailing, this.phoneClaimants_Mailing);
  }

  protected void CreateClaimantLegalInformation(Claimant c)
  {
    if (c.LegalInformation == null)
      c.LegalInformation = new ClaimantLegalInformation();
    c.LegalInformation.SuitServed = ((UltraToggleEditorBase) this.checkClaimants_SuitServed).Checked;
    c.LegalInformation.DateServed = (DateTime?) ((UltraDateTimeEditor) this.dateTimeClaimants_SuitServed).Value;
    c.LegalInformation.DateAnswered = (DateTime?) ((UltraDateTimeEditor) this.dateTimeClaimants_SuitAnswered).Value;
    c.LegalInformation.DefenseFirm = ((Control) this.textClaimants_DefenseFirm).Text;
    c.LegalInformation.DefenseAttorney = ((Control) this.textClaimants_DefenseAttorney).Text.Length > 0 ? ((Control) this.textClaimants_DefenseAttorney).Text : ((Control) this.cboDefenseAttorney).Text;
    c.LegalInformation.ClaimantAttorneyEntityType = this.optionClaimantAttorneyEntityType.Value.ToString() == "I" ? ClaimantLegalInformation.EntityType.Individual : ClaimantLegalInformation.EntityType.Corporation;
    c.LegalInformation.DefenseFirmEntityType = this.optionDefenseEntityType.Value.ToString() == "I" ? ClaimantLegalInformation.EntityType.Individual : ClaimantLegalInformation.EntityType.Corporation;
    c.LegalInformation.DefenseAttorneyFeinSsn = string.IsNullOrEmpty(((Control) this.textClaimants_DefenseFEIN).Text) ? string.Empty : ((UltraMaskedEdit) this.textClaimants_DefenseFEIN).Value.ToString();
    c.LegalInformation.DefenseAttorneyAddress = Utility.CreateAddress(this.addResolverClaimants_DefenseAttorney, this.phoneClaimants_DefenseAttorney);
    c.LegalInformation.DefenseAttorneyAddress.IsInternational = this.addResolverClaimants_DefenseAttorney.ISOCountryCode != "USA";
    c.LegalInformation.PublishedDecision = ((UltraToggleEditorBase) this.checkClaimants_PublishedDecision).Checked;
    c.LegalInformation.Judge = ((Control) this.textClaimants_Judge).Text;
    c.LegalInformation.ClaimantLawFirm = ((Control) this.textClaimants_ClaimantLawFirm).Text;
    c.LegalInformation.ClaimantAttorney = ((Control) this.textClaimants_ClaimantAttorney).Text.Length > 0 ? ((Control) this.textClaimants_ClaimantAttorney).Text : ((Control) this.cboClaimantAttorney).Text;
    c.LegalInformation.ClaimantAttorneyFeinSsn = string.IsNullOrEmpty(((Control) this.textClaimants_ClaimantAttorneyFEIN).Text) ? string.Empty : ((UltraMaskedEdit) this.textClaimants_ClaimantAttorneyFEIN).Value.ToString();
    c.LegalInformation.ClaimantAttorneyAddress = Utility.CreateAddress(this.addResolverClaimants_ClaimantAttorney, this.phoneClaimants_ClaimantAttorney);
    c.LegalInformation.ClaimantAttorneyAddress.IsInternational = this.addResolverClaimants_ClaimantAttorney.ISOCountryCode != "USA";
  }

  protected void ClearClaimantEntry()
  {
    this.CurrentClaimant = (Claimant) null;
    ((UltraToggleEditorBase) this.checkClaimants_Closed).Checked = false;
    ((UltraToggleEditorBase) this.checkClaimants_IsInsured).Checked = false;
    ((UltraToggleEditorBase) this.checkClaimants_Settled).Checked = false;
    ((UltraToggleEditorBase) this.checkClaimants_SuitServed).Checked = false;
    ((Control) this.textClaimants_CorporationName).Text = string.Empty;
    ((Control) this.textClaimants_FirstName).Text = string.Empty;
    ((Control) this.textClaimants_MiddleName).Text = string.Empty;
    ((Control) this.textClaimants_LastName).Text = string.Empty;
    ((Control) this.textClaimants_UserDefinedClaimantsID).Text = string.Empty;
    ((UltraDateTimeEditor) this.dateTimeClaimants_DOB).Value = (object) null;
    ((Control) this.textClaimants_EmailAddress).Text = string.Empty;
    ((Control) this.textClaimants_UserDefinedClaimantsID).Text = string.Empty;
    ((Control) this.maskedEditClaimants_SSNFEIN).Text = string.Empty;
    ((Control) this.comboClaimants_Gender).ResetText();
    ((Control) this.comboClaimant_AccidentTypes).ResetText();
    ((Control) this.comboClaimants_LossType).ResetText();
    ((Control) this.comboClaimants_ManagedCare).ResetText();
    ((Control) this.comboClaimants_OutsideAdjuster).ResetText();
    ((Control) this.comboClaimants_SettlementType).ResetText();
    this.addResolverClaimants_Primary.Clear();
    this.addResolverClaimants_Mailing.Clear();
    this.addResolverClaimants_DefenseAttorney.Clear();
    this.addResolverClaimants_ClaimantAttorney.Clear();
    this.phoneClaimants_Primary.Clear();
    this.phoneClaimants_Mailing.Clear();
    this.phoneClaimants_DefenseAttorney.Clear();
    this.phoneClaimants_ClaimantAttorney.Clear();
    this.phoneClaimants_Primary.Enabled = !((UltraToggleEditorBase) this.checkClaimants_IsInsured).Checked;
    this.phoneClaimants_Mailing.Enabled = !((UltraToggleEditorBase) this.checkClaimants_IsInsured).Checked;
    this.dsReservesPayments1.Clear();
    ((UltraDateTimeEditor) this.dateTimeClaimants_SuitServed).Value = (object) null;
    ((UltraDateTimeEditor) this.dateTimeClaimants_SuitAnswered).Value = (object) null;
    ((UltraDateTimeEditor) this.dateTimeClaimant_DateReported).Value = (object) DateTime.Now;
    ((UltraToggleEditorBase) this.checkClaimants_SuitServed).Checked = false;
    ((Control) this.textClaimants_DefenseFirm).Text = string.Empty;
    ((Control) this.textClaimants_DefenseAttorney).Text = string.Empty;
    ((UltraMaskedEdit) this.textClaimants_DefenseFEIN).Value = (object) null;
    ((Control) this.textClaimants_DefenseFEIN).Text = string.Empty;
    ((UltraToggleEditorBase) this.checkClaimants_PublishedDecision).Checked = false;
    ((Control) this.textClaimants_Judge).Text = string.Empty;
    ((Control) this.textClaimants_ClaimantLawFirm).Text = string.Empty;
    ((Control) this.textClaimants_ClaimantAttorney).Text = string.Empty;
    this.OnAfterClearScreen();
    this._currentClaimant = ObjectFactory.Instance.CreateObjectAs<Claimant>(typeof (Claimant), (object) this.CurrentClaim);
    this.DisplayCurrentClaimant();
    this._initValueHash = Utility.GetValueHash((object) this);
    this.RaiseNotesAndDocumentEvents();
  }

  protected virtual bool VerifyClaimant()
  {
    if (this.optionClaimants_ClaimantType.Value.ToString() == "I")
    {
      if (string.IsNullOrEmpty(((Control) this.textClaimants_FirstName).Text) || string.IsNullOrEmpty(((Control) this.textClaimants_LastName).Text))
      {
        int num = (int) MessageBox.Show(Resources.CLAIMANTERROR_FIRSTLASTNAME, Resources.ERROR_REQUIREDFIELD_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return false;
      }
      if (((UltraDropDownBase) this.comboClaimants_Gender).SelectedRow == null)
      {
        int num = (int) MessageBox.Show(Resources.CLAIMANTERROR_GENDERREQUIRED, Resources.ERROR_REQUIREDFIELD_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return false;
      }
    }
    else if (string.IsNullOrEmpty(((Control) this.textClaimants_CorporationName).Text))
    {
      int num = (int) MessageBox.Show(Resources.CLAIMANTERROR_CORPORATIONNAMEREQUIRED, Resources.ERROR_REQUIREDFIELD_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (this.addResolverClaimants_Primary.ISOCountryCode == "USA" && (string.IsNullOrEmpty(this.addResolverClaimants_Primary.Address1) || string.IsNullOrEmpty(this.addResolverClaimants_Primary.City) || string.IsNullOrEmpty(this.addResolverClaimants_Primary.State) || string.IsNullOrEmpty(this.addResolverClaimants_Primary.ZipCode)) || this.addResolverClaimants_Primary.ISOCountryCode != "USA" && string.IsNullOrEmpty(this.addResolverClaimants_Primary.Address1))
    {
      int num = (int) MessageBox.Show(Resources.CLAIMANTERROR_PRIMARYADDRESS, Resources.ERROR_REQUIREDFIELD_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if ((((Control) this.textClaimants_DefenseFirm).Text.Length > 0 || ((Control) this.textClaimants_DefenseAttorney).Text.Length > 0) && (this.addResolverClaimants_DefenseAttorney.ISOCountryCode == "USA" && (string.IsNullOrEmpty(this.addResolverClaimants_DefenseAttorney.Address1) || string.IsNullOrEmpty(this.addResolverClaimants_DefenseAttorney.City) || string.IsNullOrEmpty(this.addResolverClaimants_DefenseAttorney.State) || string.IsNullOrEmpty(this.addResolverClaimants_DefenseAttorney.ZipCode)) || this.addResolverClaimants_DefenseAttorney.ISOCountryCode != "USA" && (string.IsNullOrEmpty(this.addResolverClaimants_DefenseAttorney.Address1) || string.IsNullOrEmpty(this.addResolverClaimants_DefenseAttorney.ZipCode))))
    {
      int num = (int) MessageBox.Show(Resources.CLAIMANTERROR_DEFENSEATTORNEY_ADDRESS, Resources.ERROR_REQUIREDFIELD_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (((Control) this.textClaimants_ClaimantLawFirm).Text.Length <= 0 && ((Control) this.textClaimants_ClaimantAttorney).Text.Length <= 0 || (!(this.addResolverClaimants_ClaimantAttorney.ISOCountryCode == "USA") || !string.IsNullOrEmpty(this.addResolverClaimants_ClaimantAttorney.Address1) && !string.IsNullOrEmpty(this.addResolverClaimants_ClaimantAttorney.City) && !string.IsNullOrEmpty(this.addResolverClaimants_ClaimantAttorney.State) && !string.IsNullOrEmpty(this.addResolverClaimants_ClaimantAttorney.ZipCode)) && (!(this.addResolverClaimants_ClaimantAttorney.ISOCountryCode != "USA") || !string.IsNullOrEmpty(this.addResolverClaimants_ClaimantAttorney.Address1) && !string.IsNullOrEmpty(this.addResolverClaimants_ClaimantAttorney.ZipCode)))
      return true;
    int num1 = (int) MessageBox.Show(Resources.CLAIMANTERROR_CLAIMANTATTORNEY_ADDRESS, Resources.ERROR_REQUIREDFIELD_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    return false;
  }

  protected virtual void checkClaimantsIsInsured_CheckChanged(object sender, EventArgs e)
  {
    this.InsuredChecked();
    this.SetFromClaimant = false;
  }

  protected virtual void InsuredChecked()
  {
    ((Control) this.textClaimants_CorporationName).Text = string.Empty;
    ((Control) this.textClaimants_FirstName).Text = string.Empty;
    ((Control) this.textClaimants_MiddleName).Text = string.Empty;
    ((Control) this.textClaimants_LastName).Text = string.Empty;
    ((Control) this.maskedEditClaimants_SSNFEIN).Text = string.Empty;
    this.optionClaimants_ClaimantType.Value = (object) "I";
    this.addResolverClaimants_Primary.Clear();
    this.addResolverClaimants_Mailing.Clear();
    this.phoneClaimants_Primary.Clear();
    this.phoneClaimants_Mailing.Clear();
    if (((UltraToggleEditorBase) this.checkClaimants_IsInsured).Checked)
    {
      if (this.SetFromClaimant)
      {
        if (!string.IsNullOrEmpty(this.CurrentClaimant.ClaimantInformation.CorporationName) || !string.IsNullOrEmpty(this.CurrentClaimant.ClaimantInformation.Fein))
        {
          this.optionClaimants_ClaimantType.Value = (object) "C";
          ((Control) this.maskedEditClaimants_SSNFEIN).Text = this.CurrentClaimant.ClaimantInformation.Fein;
          ((Control) this.textClaimants_CorporationName).Text = this.CurrentClaimant.ClaimantInformation.CorporationName;
        }
        else
        {
          this.optionClaimants_ClaimantType.Value = (object) "I";
          ((Control) this.maskedEditClaimants_SSNFEIN).Text = this.CurrentClaimant.ClaimantInformation.SocialSecurityNumber;
          ((Control) this.textClaimants_FirstName).Text = this.CurrentClaimant.ClaimantInformation.FirstName;
          ((Control) this.textClaimants_MiddleName).Text = this.CurrentClaimant.ClaimantInformation.MiddleName;
          ((Control) this.textClaimants_LastName).Text = this.CurrentClaimant.ClaimantInformation.LastName;
        }
        this.addResolverClaimants_Primary.Address1 = this.CurrentClaimant.PrimaryAddress.Address1;
        this.addResolverClaimants_Primary.Address2 = this.CurrentClaimant.PrimaryAddress.Address2;
        this.addResolverClaimants_Primary.City = this.CurrentClaimant.PrimaryAddress.City;
        this.addResolverClaimants_Primary.State = this.CurrentClaimant.PrimaryAddress.State;
        this.addResolverClaimants_Primary.County = this.CurrentClaimant.PrimaryAddress.County;
        this.addResolverClaimants_Primary.ISOCountryCode = this.CurrentClaimant.PrimaryAddress.IsoCountryCode;
        this.addResolverClaimants_Primary.ZipCode = this.CurrentClaimant.PrimaryAddress.ZipCode;
        if (this.CurrentClaimant.PrimaryAddress.PhoneNumberDataset.PhoneNumbers.Count > 0)
          this.phoneClaimants_Primary.AddNew(this.CurrentClaimant.PrimaryAddress.PhoneNumberDataset.PhoneNumbers[0].PhoneNumber);
      }
      else
      {
        DataRow insuredInformation = Utility.GetClaimantInsuredInformation(this.CurrentClaim.ControlNumber);
        if (insuredInformation != null)
        {
          if (insuredInformation["CorporationName"] != DBNull.Value && !string.IsNullOrEmpty(insuredInformation["CorporationName"].ToString().Trim()) || insuredInformation["FEIN"] != DBNull.Value && !string.IsNullOrEmpty(insuredInformation["FEIN"].ToString().Trim()))
          {
            this.optionClaimants_ClaimantType.Value = (object) "C";
            ((Control) this.maskedEditClaimants_SSNFEIN).Text = insuredInformation["FEIN"].ToString();
            ((Control) this.textClaimants_CorporationName).Text = insuredInformation["CorporationName"].ToString();
          }
          else
          {
            this.optionClaimants_ClaimantType.Value = (object) "I";
            ((Control) this.maskedEditClaimants_SSNFEIN).Text = insuredInformation["SSN"].ToString();
            ((Control) this.textClaimants_FirstName).Text = insuredInformation["FirstName"].ToString();
            ((Control) this.textClaimants_MiddleName).Text = insuredInformation["MiddleName"].ToString();
            ((Control) this.textClaimants_LastName).Text = insuredInformation["LastName"].ToString();
          }
          this.addResolverClaimants_Primary.Address1 = insuredInformation["Address1"].ToString();
          this.addResolverClaimants_Primary.Address2 = insuredInformation["Address2"].ToString();
          this.addResolverClaimants_Primary.City = insuredInformation["City"].ToString();
          this.addResolverClaimants_Primary.State = insuredInformation["State"].ToString();
          this.addResolverClaimants_Primary.County = insuredInformation["County"].ToString();
          this.addResolverClaimants_Primary.ISOCountryCode = insuredInformation["ISOCountryCode"].ToString();
          this.addResolverClaimants_Primary.ZipCode = insuredInformation["Zip"].ToString();
          if (insuredInformation["Phone"] != DBNull.Value && !string.IsNullOrEmpty(insuredInformation["Phone"].ToString().Trim()))
            this.phoneClaimants_Primary.AddNew(insuredInformation["Phone"].ToString());
        }
      }
      ((UltraCombo) this.comboClaimants_Gender).Value = ((UltraGridBase) this.comboClaimants_Gender).Rows[0].Cells[0].Value;
      StringBuilder stringBuilder = new StringBuilder();
      stringBuilder.Append(CurrentUser.Instance.DisplayNameLastFirst);
      stringBuilder.Append(" checked the insured checkbox.Claimant: ");
      stringBuilder.Append(" checked the insured checkbox.Claimant: ");
      if (string.IsNullOrEmpty(((Control) this.textClaimants_CorporationName).Text))
      {
        stringBuilder.Append(((Control) this.textClaimants_FirstName).Text);
        stringBuilder.Append(" ");
        stringBuilder.Append(string.IsNullOrEmpty(((Control) this.textClaimants_MiddleName).Text) ? ((Control) this.textClaimants_LastName).Text : ((Control) this.textClaimants_MiddleName).Text);
        if (!string.IsNullOrEmpty(((Control) this.textClaimants_MiddleName).Text))
        {
          stringBuilder.Append(" ");
          stringBuilder.Append(((Control) this.textClaimants_LastName).Text);
        }
      }
      if (this._currentClaim != null)
      {
        int? claimId = this._currentClaim.ClaimId;
        if (claimId.HasValue)
        {
          string action = stringBuilder.ToString();
          claimId = this._currentClaim.ClaimId;
          int identifier = claimId.Value;
          Utility.LogAction(action, identifier);
          goto label_21;
        }
      }
      if (this._currentClaim != null)
        this._currentClaim.LoggingList.Add(stringBuilder.ToString());
    }
label_21:
    this.SetInsuredEnabled();
  }

  private void gridClaimants_ReservePayments_InitializeTemplateAddRow(
    object sender,
    InitializeTemplateAddRowEventArgs e)
  {
    e.TemplateAddRow.Cells["CreatedByGuid"].Value = (object) CurrentUser.Instance.UserGUID;
    e.TemplateAddRow.Cells["CreatedBy"].Value = (object) CurrentUser.Instance.DisplayName;
    e.TemplateAddRow.Cells["DateCreated"].Value = (object) DateTime.Now;
  }

  private void HookUpClaimantHandlers(Claimant claimant)
  {
    claimant.ReservesAndPayments.CollectionChanged += (EventHandler<EventArgs>) ((sender, e) => this.CreateReservePaymentDataset());
    claimant.ClaimantStatusChanged += (EventHandler<EventArgs>) ((sender, e) =>
    {
      ((UltraToggleEditorBase) this.checkClaimants_Closed).Checked = this.CurrentClaimant.StatusId == 1;
      this.SetToolbarEnabled();
    });
  }

  protected virtual void SetToolbarEnabled()
  {
    UltraToolbar toolbar = this.ultraToolbarsManager1.Toolbars[0];
    if (((KeyedSubObjectsCollectionBase) ((UltraToolbarBase) toolbar).Tools).Exists("ADDPAYMENT"))
      ((ToolsCollectionBase) ((UltraToolbarBase) toolbar).Tools)["ADDPAYMENT"].SharedProps.Enabled = this.CurrentClaimant.CountReserves() > 0 && this.CurrentClaimant.StatusId == 0;
    if (((KeyedSubObjectsCollectionBase) ((UltraToolbarBase) toolbar).Tools).Exists("PAYMENTRETURN"))
      ((ToolsCollectionBase) ((UltraToolbarBase) toolbar).Tools)["PAYMENTRETURN"].SharedProps.Enabled = this.CurrentClaimant.CountPayments() > 0 && this.CurrentClaimant.StatusId == 0;
    if (((KeyedSubObjectsCollectionBase) ((UltraToolbarBase) toolbar).Tools).Exists("DELETEPAYMENT"))
      ((ToolsCollectionBase) ((UltraToolbarBase) toolbar).Tools)["DELETEPAYMENT"].SharedProps.Enabled = this.CurrentClaimant.CountPayments() > 0 && this.CurrentClaimant.StatusId == 0;
    if (((KeyedSubObjectsCollectionBase) ((UltraToolbarBase) toolbar).Tools).Exists("REOPENCLAIM"))
      ((ToolsCollectionBase) ((UltraToolbarBase) toolbar).Tools)["REOPENCLAIM"].SharedProps.Enabled = this.CurrentClaimant.StatusId == 1;
    if (((KeyedSubObjectsCollectionBase) ((UltraToolbarBase) toolbar).Tools).Exists("CLOSECLAIM"))
      ((ToolsCollectionBase) ((UltraToolbarBase) toolbar).Tools)["CLOSECLAIM"].SharedProps.Enabled = this.CurrentClaimant.StatusId == 0;
    if (!((KeyedSubObjectsCollectionBase) ((UltraToolbarBase) toolbar).Tools).Exists("ADDRESERVE"))
      return;
    ((ToolsCollectionBase) ((UltraToolbarBase) toolbar).Tools)["ADDRESERVE"].SharedProps.Enabled = this.CurrentClaimant.StatusId == 0;
  }

  private void DisplayClaimantHeaderInformation(Claimant c)
  {
    if (c.IsInsured)
      ((UltraToggleEditorBase) this.checkClaimants_IsInsured).Checked = true;
    ((UltraToggleEditorBase) this.checkClaimants_MedicareEligible).Checked = c.MedicareEligible;
    if (string.IsNullOrEmpty(c.ClaimantInformation.CorporationName))
    {
      this.optionClaimants_ClaimantType.Value = (object) "I";
      ((Control) this.textClaimants_FirstName).Text = c.ClaimantInformation.FirstName;
      ((Control) this.textClaimants_MiddleName).Text = c.ClaimantInformation.MiddleName;
      ((Control) this.textClaimants_LastName).Text = c.ClaimantInformation.LastName;
      ((Control) this.maskedEditClaimants_SSNFEIN).Text = c.ClaimantInformation.SocialSecurityNumber;
      ((UltraDateTimeEditor) this.dateTimeClaimants_DOB).Value = (object) (c.ClaimantInformation.DateOfBirth ?? new DateTime?());
    }
    else
    {
      this.optionClaimants_ClaimantType.Value = (object) "C";
      ((Control) this.textClaimants_CorporationName).Text = c.ClaimantInformation.CorporationName;
      ((Control) this.maskedEditClaimants_SSNFEIN).Text = c.ClaimantInformation.Fein;
    }
    ((UltraCombo) this.comboClaimants_Gender).Value = (object) c.ClaimantInformation.Gender;
    ((Control) this.textClaimants_UserDefinedClaimantsID).Text = c.UserDefinedClaimantId;
    ((UltraToggleEditorBase) this.checkClaimants_Closed).Checked = c.StatusId == 1;
    ((Control) this.textClaimants_Comments).Text = c.ClaimantComments;
    ((Control) this.textClaimants_EmailAddress).Text = c.EmailAddress;
  }

  protected virtual void DisplayClaimantAddressInformation(Claimant c)
  {
    Utility.DisplayAddress(this.addResolverClaimants_Primary, this.phoneClaimants_Primary, c.PrimaryAddress);
    this.phoneClaimants_Primary.Enabled = !((UltraToggleEditorBase) this.checkClaimants_IsInsured).Checked;
    if (c.MailingAddress == null)
      return;
    Utility.DisplayAddress(this.addResolverClaimants_Mailing, this.phoneClaimants_Mailing, c.MailingAddress);
    this.phoneClaimants_Mailing.Enabled = !((UltraToggleEditorBase) this.checkClaimants_IsInsured).Checked;
  }

  private void DisplayClaimantClaimInformation(Claimant c)
  {
    ((Control) this.textClaimant_EnteredBy).Text = c.EnteredByUserName;
    ((UltraDateTimeEditor) this.dateTimeClaimant_DateEntered).Value = (object) c.EnteredOn;
    ((UltraDateTimeEditor) this.dateTimeClaimants_LastModified).Value = (object) c.LastModified;
    ((Control) this.textClaimants_LastModifiedBy).Text = c.ModifiedByUserName;
    ((UltraDateTimeEditor) this.dateTimeClaimant_DateDenied).Value = (object) c.DateDenied;
    ((UltraCombo) this.comboClaimant_AccidentTypes).Value = (object) (c.AccidentTypeId ?? new int?());
    MGASimpleComboBox claimantsLossType = this.comboClaimants_LossType;
    int? nullable = c.LossTypeId;
    // ISSUE: variable of a boxed type
    __Boxed<int?> local1 = (System.ValueType) (nullable ?? new int?());
    ((UltraCombo) claimantsLossType).Value = (object) local1;
    MGASimpleComboBox claimantsManagedCare = this.comboClaimants_ManagedCare;
    nullable = c.ManagedCareId;
    // ISSUE: variable of a boxed type
    __Boxed<int?> local2 = (System.ValueType) (nullable ?? new int?());
    ((UltraCombo) claimantsManagedCare).Value = (object) local2;
    ((UltraCombo) this.comboClaimants_OutsideAdjuster).Value = (object) c.OutsideAdjusterGuid;
    ((Control) this.textClaimants_OutsideInvestigator).Text = c.OutsideInvestigator;
    ((UltraDateTimeEditor) this.dateTimeClaimants_OutsideInvestigatorHireDate).Value = (object) (c.OutsideInvestigatorHireDate ?? new DateTime?());
    ((UltraToggleEditorBase) this.checkClaimants_Settled).Checked = c.IsSettled;
    MGASimpleComboBox claimantsSettlementType = this.comboClaimants_SettlementType;
    nullable = c.SettlementTypeId;
    // ISSUE: variable of a boxed type
    __Boxed<int?> local3 = (System.ValueType) (nullable ?? new int?());
    ((UltraCombo) claimantsSettlementType).Value = (object) local3;
    ((UltraDateTimeEditor) this.dateTimeClaimant_DateReported).Value = (object) c.DateReported;
    MGASimpleComboBox claimantsOutsideAdjuster = this.comboClaimants_OutsideAdjuster;
    Guid outsideAdjusterGuid = c.OutsideAdjusterGuid;
    // ISSUE: variable of a boxed type
    __Boxed<Guid> local4 = (System.ValueType) (c.OutsideAdjusterGuid.Equals(Guid.Empty) ? Guid.Empty : c.OutsideAdjusterGuid);
    ((UltraCombo) claimantsOutsideAdjuster).Value = (object) local4;
  }

  private void DisplayClaimantLegalInformation(Claimant c)
  {
    if (c.LegalInformation == null)
      c.LegalInformation = new ClaimantLegalInformation();
    ClaimantLegalInformation legalInformation = c.LegalInformation;
    ((UltraToggleEditorBase) this.checkClaimants_SuitServed).Checked = legalInformation.SuitServed;
    ((UltraDateTimeEditor) this.dateTimeClaimants_SuitServed).Value = (object) legalInformation.DateServed;
    ((UltraDateTimeEditor) this.dateTimeClaimants_SuitAnswered).Value = (object) legalInformation.DateAnswered;
    ((Control) this.textClaimants_DefenseFirm).Text = legalInformation.DefenseFirm;
    ((Control) this.textClaimants_DefenseAttorney).Text = legalInformation.DefenseAttorney;
    ((Control) this.textClaimants_DefenseFEIN).Text = legalInformation.DefenseAttorneyFeinSsn;
    if (legalInformation.DefenseAttorneyAddress == null)
    {
      legalInformation.DefenseAttorneyAddress = new ClaimAddress();
      Utility.LinkPhoneNumberManager(legalInformation.DefenseAttorneyAddress, this.phoneClaimants_DefenseAttorney);
    }
    else
      Utility.DisplayAddress(this.addResolverClaimants_DefenseAttorney, this.phoneClaimants_DefenseAttorney, legalInformation.DefenseAttorneyAddress);
    ((UltraToggleEditorBase) this.checkClaimants_PublishedDecision).Checked = legalInformation.PublishedDecision;
    ((Control) this.textClaimants_Judge).Text = legalInformation.Judge;
    ((Control) this.textClaimants_ClaimantLawFirm).Text = legalInformation.ClaimantLawFirm;
    ((Control) this.textClaimants_ClaimantAttorney).Text = legalInformation.ClaimantAttorney;
    ((Control) this.textClaimants_ClaimantAttorneyFEIN).Text = legalInformation.ClaimantAttorneyFeinSsn;
    if (legalInformation.ClaimantAttorneyAddress == null)
    {
      legalInformation.ClaimantAttorneyAddress = new ClaimAddress();
      Utility.LinkPhoneNumberManager(legalInformation.ClaimantAttorneyAddress, this.phoneClaimants_ClaimantAttorney);
    }
    else
      Utility.DisplayAddress(this.addResolverClaimants_ClaimantAttorney, this.phoneClaimants_ClaimantAttorney, legalInformation.ClaimantAttorneyAddress);
  }

  protected virtual void CreateReservePaymentDataset()
  {
    this.dsReservesPayments1.Clear();
    if (this.CurrentClaimant.ReservesAndPayments == null || this.CurrentClaimant.ReservesAndPayments.Count == 0)
      return;
    foreach (PaymentReserve reservesAndPayment in (Collection<PaymentReserve>) this.CurrentClaimant.ReservesAndPayments)
    {
      if (reservesAndPayment != null)
      {
        dsReservesPayments.ReservesPaymentsDataTable reservesPayments = this.dsReservesPayments1.ReservesPayments;
        string EntryTypeId = reservesAndPayment.EntryType == PaymentReserveType.Reserve ? "R" : "P";
        string EntryType = reservesAndPayment.EntryType == PaymentReserveType.Reserve ? "Reserve" : "Payment";
        int? nullable = reservesAndPayment.CoverageTypeId;
        int valueOrDefault1 = nullable.GetValueOrDefault();
        string coverageType = reservesAndPayment.CoverageType;
        nullable = reservesAndPayment.CoverageTypeDescriptionId;
        int valueOrDefault2 = nullable.GetValueOrDefault();
        string coverageTypeDescription = reservesAndPayment.CoverageTypeDescription;
        int reservePaymentTypeId = reservesAndPayment.ReservePaymentTypeId;
        string reservePaymentType = reservesAndPayment.ReservePaymentType;
        nullable = reservesAndPayment.ReservePaymentSubTypeId;
        int valueOrDefault3 = nullable.GetValueOrDefault();
        string reservePaymentSubType = reservesAndPayment.ReservePaymentSubType;
        Decimal reservePaymentAmount = reservesAndPayment.ReservePaymentAmount;
        DateTime dateCreated = reservesAndPayment.DateCreated;
        Guid createdByGuid = reservesAndPayment.CreatedByGuid;
        string createdBy = reservesAndPayment.CreatedBy;
        string comments = reservesAndPayment.Comments;
        Guid payeeGuid = reservesAndPayment.PayeeGuid;
        string payeeName = reservesAndPayment.PayeeName;
        int num1 = reservesAndPayment.IsVoid ? 1 : 0;
        int num2 = reservesAndPayment.IsPaymentReduction ? 1 : 0;
        dsReservesPayments.ReservesPaymentsRow reservesPaymentsRow1 = reservesPayments.AddReservesPaymentsRow(EntryTypeId, EntryType, valueOrDefault1, coverageType, valueOrDefault2, coverageTypeDescription, reservePaymentTypeId, reservePaymentType, valueOrDefault3, reservePaymentSubType, reservePaymentAmount, dateCreated, createdByGuid, createdBy, comments, payeeGuid, payeeName, num1 != 0, num2 != 0);
        nullable = reservesAndPayment.CoverageTypeId;
        if (!nullable.HasValue)
          reservesPaymentsRow1.SetCoverageTypeIdNull();
        nullable = reservesAndPayment.CoverageTypeDescriptionId;
        if (!nullable.HasValue)
          reservesPaymentsRow1.SetCoverageTypeDescriptionIdNull();
        nullable = reservesAndPayment.ReservePaymentSubTypeId;
        if (!nullable.HasValue)
          reservesPaymentsRow1.SetResPaySubTypeIdNull();
        nullable = reservesAndPayment.ReservePaymentId;
        if (nullable.HasValue)
        {
          dsReservesPayments.ReservesPaymentsRow reservesPaymentsRow2 = reservesPaymentsRow1;
          nullable = reservesAndPayment.ReservePaymentId;
          int num3 = nullable.Value;
          reservesPaymentsRow2.ResPayId = num3;
        }
      }
    }
    if (((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout == null || ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.Bands[0] == null)
      return;
    if (((KeyedSubObjectsCollectionBase) ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.Bands[0].Columns).Exists("IsVoid"))
      ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.Bands[0].Columns["IsVoid"].Hidden = true;
    if (!((KeyedSubObjectsCollectionBase) ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.Bands[0].Columns).Exists("IsPaymentReduction"))
      return;
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.Bands[0].Columns["IsPaymentReduction"].Hidden = true;
  }

  protected virtual bool CheckResPayId(UltraGridRow activeRow)
  {
    return this.CurrentClaimant.ReservesAndPayments[activeRow.Index].ReservePaymentId.HasValue;
  }

  protected virtual void EditCoverageType()
  {
    if (!SecurityManager.Instance.AssertPermission("{DF33CB2D-AE2B-4ee3-AA8C-24D08E14E090}"))
      return;
    foreach (UltraGridRow row in ((UltraGridBase) this.gridClaimants_ReservePayments).Rows)
    {
      if (!this.CheckResPayId(row))
      {
        int num = (int) MessageBox.Show(Resources.RESERVEPAYMENT_EDIT_ALLRESPAY, Resources.RESERVEPAYMENT_EDIT_NEWRESPAY_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }
    }
    UltraGridRow activeRow = ((UltraGridBase) this.gridClaimants_ReservePayments).ActiveRow;
    if (activeRow == null)
    {
      int num1 = (int) MessageBox.Show(Resources.CHANGERESERVEPAYMENTSUBTYPE_NOTHINGSELECTED, Resources.ERROR_REQUIREDFIELD_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else
    {
      int num2 = (int) ObjectFactory.Instance.CreateObjectAs<EditReservesPayments>(typeof (EditReservesPayments), (object) this.CurrentClaimant.ReservesAndPayments[activeRow.Index], (object) this._currentClaimant, (object) this._currentClaim).ShowDialog();
      this.CurrentClaimant.LoadReservesPayments();
      this.DisplayCurrentClaimant();
    }
  }

  protected virtual bool SaveClaimant(bool clearEntry)
  {
    if (!this.VerifyClaimant())
      return false;
    this.CreateClaimant();
    if (!this.CurrentClaimant.VerifyClaimant())
      return false;
    if (this.CurrentClaimant.EditState == Claimant.ClaimantState.New || this.CurrentClaimant.EditState == Claimant.ClaimantState.UpdatedNew)
    {
      this.CurrentClaim.Claimants.Add(this.CurrentClaimant);
      this.CurrentClaim.AddClaimantCreatedExpense();
    }
    if (clearEntry)
      this.ClearClaimantEntry();
    StringBuilder stringBuilder = new StringBuilder();
    stringBuilder.Append(CurrentUser.Instance.DisplayNameLastFirst);
    stringBuilder.Append(" saved the claimant.");
    if (this._currentClaim != null)
    {
      int? claimId = this._currentClaim.ClaimId;
      if (claimId.HasValue)
      {
        string action = stringBuilder.ToString();
        claimId = this._currentClaim.ClaimId;
        int identifier = claimId.Value;
        Utility.LogAction(action, identifier);
        goto label_13;
      }
    }
    if (this._currentClaim != null)
      this._currentClaim.LoggingList.Add(stringBuilder.ToString());
label_13:
    ((INotifyChanges) this.CurrentClaimant).HasChanges = false;
    this._initValueHash = Utility.GetValueHash((object) this);
    return true;
  }

  protected void ShowClaimantReserveTab()
  {
    ((UltraTabControlBase) this.tabControlClaimants).SelectedTab = ((UltraTabControlBase) this.tabControlClaimants).Tabs["ReservesPayments"];
  }

  private void ViewPaymentInformation()
  {
    if (!this.VerifyPayments())
      return;
    UltraGridRow activeRow = ((UltraGridBase) this.gridClaimants_ReservePayments).ActiveRow;
    if (activeRow == null)
      return;
    if (activeRow.Cells["EntryType"].Value.ToString() != "Payment" && activeRow.Cells["EntryType"].Value.ToString() != "Payment-(VOID)")
    {
      int num1 = (int) MessageBox.Show(Resources.CLAIMANT_RESERVEPAYMENT_CHECKDETAILMESSAGE, Resources.ERROR_INVALIDENTRY_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else if ((Decimal) activeRow.Cells["ResPayAmount"].Value > 0M)
    {
      using (FormPaymentCheckInformation objectAs = ObjectFactory.Instance.CreateObjectAs<FormPaymentCheckInformation>(typeof (FormPaymentCheckInformation), (object) this._currentClaimant, (object) this._currentClaimant.GetReservePayment((int) activeRow.Cells["ResPayId"].Value)))
      {
        int num2 = (int) objectAs.ShowDialog();
      }
    }
    else
    {
      using (FormDepositPaymentInformation objectAs = ObjectFactory.Instance.CreateObjectAs<FormDepositPaymentInformation>(typeof (FormDepositPaymentInformation), (object) this._currentClaimant, (object) this._currentClaimant.GetReservePayment((int) activeRow.Cells["ResPayId"].Value)))
      {
        int num3 = (int) objectAs.ShowDialog();
      }
    }
  }

  protected void RaiseNotesAndDocumentEvents()
  {
    ISupportDocumentSystem.EntityInfoChangedEventHandler entityInfoChanged1 = this.DocumentEntityInfoChanged;
    if (entityInfoChanged1 != null)
      entityInfoChanged1((object) this, new EventArgs());
    ISupportNoteSystem.EntityInfoChangedEventHandler entityInfoChanged2 = this.NoteEntityInfoChanged;
    if (entityInfoChanged2 == null)
      return;
    entityInfoChanged2((object) this, new EventArgs());
  }

  protected virtual void SetInsuredEnabled()
  {
    ((Control) this.textClaimants_CorporationName).Enabled = !((UltraToggleEditorBase) this.checkClaimants_IsInsured).Checked;
    ((Control) this.textClaimants_FirstName).Enabled = !((UltraToggleEditorBase) this.checkClaimants_IsInsured).Checked;
    ((Control) this.textClaimants_MiddleName).Enabled = !((UltraToggleEditorBase) this.checkClaimants_IsInsured).Checked;
    ((Control) this.textClaimants_LastName).Enabled = !((UltraToggleEditorBase) this.checkClaimants_IsInsured).Checked;
    ((Control) this.maskedEditClaimants_SSNFEIN).Enabled = !((UltraToggleEditorBase) this.checkClaimants_IsInsured).Checked;
    this.phoneClaimants_Primary.Enabled = !((UltraToggleEditorBase) this.checkClaimants_IsInsured).Checked;
    this.phoneClaimants_Mailing.Enabled = !((UltraToggleEditorBase) this.checkClaimants_IsInsured).Checked;
    ((Control) this.optionClaimants_ClaimantType).Enabled = !((UltraToggleEditorBase) this.checkClaimants_IsInsured).Checked;
    ((Control) this.addResolverClaimants_Primary).Enabled = !((UltraToggleEditorBase) this.checkClaimants_IsInsured).Checked;
    ((Control) this.addResolverClaimants_Mailing).Enabled = !((UltraToggleEditorBase) this.checkClaimants_IsInsured).Checked;
    ((Control) this.dateTimeClaimants_DOB).Enabled = !((UltraToggleEditorBase) this.checkClaimants_IsInsured).Checked;
    ((Control) this.textClaimants_EmailAddress).Enabled = !((UltraToggleEditorBase) this.checkClaimants_IsInsured).Checked;
  }

  protected virtual void AddPayment(bool isPaymentReturn)
  {
    if (isPaymentReturn)
    {
      if (this.CurrentClaimant.CountPayments() == 0)
        return;
    }
    else if (this.CurrentClaimant.CountReserves() == 0)
      return;
    this.CreateClaimantLegalInformation(this.CurrentClaimant);
    this.ShowClaimantReserveTab();
    if (!isPaymentReturn)
    {
      if (this.CurrentClaimant.CountReserves() == 1)
      {
        foreach (UltraGridRow row in ((UltraGridBase) this.gridClaimants_ReservePayments).Rows)
        {
          if (row.Cells["EntryType"].Value.ToString() == "Reserve")
          {
            ((UltraGridBase) this.gridClaimants_ReservePayments).ActiveRow = row;
            ((GridItemBase) row).Selected = true;
            row.Activate();
          }
        }
      }
    }
    else if (this.CurrentClaimant.CountPayments() == 1)
    {
      foreach (UltraGridRow row in ((UltraGridBase) this.gridClaimants_ReservePayments).Rows)
      {
        if (row.Cells["EntryType"].Value.ToString() == "Payment")
        {
          ((UltraGridBase) this.gridClaimants_ReservePayments).ActiveRow = row;
          ((GridItemBase) row).Selected = true;
          row.Activate();
        }
      }
    }
    UltraGridRow activeRow = ((UltraGridBase) this.gridClaimants_ReservePayments).ActiveRow;
    if (activeRow == null || !isPaymentReturn && activeRow.Cells["EntryType"].Value.ToString() != "Reserve" || isPaymentReturn && activeRow.Cells["EntryType"].Value.ToString() != "Payment")
    {
      int num1 = (int) MessageBox.Show(Resources.RESERVEPAYMENT_RESERVEREQUIRED, Resources.ERROR_REQUIREDFIELD_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else if ((int) (activeRow.Cells["ResPayId"].Value ?? (object) 0) < 1)
    {
      int num2 = (int) MessageBox.Show(Resources.RESERVEPAYMENT_SAVERESERVES, Resources.RESERVEPAYMENT_SAVERESERVES_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else
    {
      using (FormAddPayment form = (FormAddPayment) ObjectFactory.Instance.CreateForm(typeof (FormAddPayment), new object[4]
      {
        (object) this._currentClaimant,
        (object) this._currentClaimant.GetReservePayment((int) activeRow.Cells["ResPayId"].Value),
        (object) isPaymentReturn,
        (object) this
      }))
      {
        form.OwnerForm = this;
        int num3 = (int) form.ShowDialog((IWin32Window) this);
      }
    }
  }

  protected virtual void ultraToolbarsManager1_ToolClick(object sender, ToolClickEventArgs e)
  {
    this.SetMedicareEligibilityData();
    StringBuilder stringBuilder1 = new StringBuilder();
    UltraGridRow activeRow = ((UltraGridBase) this.gridClaimants_ReservePayments).ActiveRow;
    string key = ((KeyedSubObjectBase) ((ToolEventArgs) e).Tool).Key;
    if (key != null)
    {
      switch (key.Length)
      {
        case 4:
          switch (key[0])
          {
            case 'E':
              if (key == "EDIT")
              {
                if (!SecurityManager.Instance.AssertPermission("{48E13963-BF89-4831-9E3A-44A3585B88B4}"))
                {
                  int num = (int) MessageBox.Show("You do not have permission to perform this function.", "Access Denied!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                  return;
                }
                if (activeRow == null)
                {
                  int num = (int) MessageBox.Show(Resources.CHANGERESERVEPAYMENTTYPE_NOTHINGSELECTED, Resources.ERROR_REQUIREDFIELD_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                  return;
                }
                if (!this.CheckResPayId(activeRow))
                {
                  int num = (int) MessageBox.Show(Resources.RESERVEPAYMENT_EDIT_NEWRESPAY, Resources.RESERVEPAYMENT_EDIT_NEWRESPAY_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                  return;
                }
                if (SystemSettings.GetBoolSetting("RestrictEditReservePayment") && (DateTime.Now - (DateTime) ((UltraGridBase) this.gridClaimants_ReservePayments).ActiveRow.Cells["DateCreated"].Value).TotalHours > 24.0)
                {
                  int num = (int) MessageBox.Show("Editing comments is restricted to 24 hours after the comment was saved. Editing is no longer allowed.", "Access Denied!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                  return;
                }
                using (FormEditReservePaymentComment reservePaymentComment = new FormEditReservePaymentComment((int) ((UltraGridBase) this.gridClaimants_ReservePayments).ActiveRow.Cells["ResPayId"].Value))
                {
                  int num = (int) reservePaymentComment.ShowDialog();
                  if (reservePaymentComment.DialogResult != DialogResult.OK)
                    return;
                  this.RedisplayClaim();
                  this.DisplayCurrentClaimant();
                  return;
                }
              }
              goto label_128;
            case 'S':
              if (key == "SAVE")
              {
                this.SaveClaimant(true);
                StringBuilder stringBuilder2 = new StringBuilder();
                stringBuilder2.Append(CurrentUser.Instance.DisplayNameLastFirst);
                stringBuilder2.Append(" clicked Save Claimant.");
                if (this._currentClaim != null)
                {
                  int? claimId = this._currentClaim.ClaimId;
                  if (claimId.HasValue)
                  {
                    string action = stringBuilder2.ToString();
                    claimId = this._currentClaim.ClaimId;
                    int identifier = claimId.Value;
                    Utility.LogAction(action, identifier);
                    return;
                  }
                }
                if (this._currentClaim == null)
                  return;
                this._currentClaim.LoggingList.Add(stringBuilder2.ToString());
                return;
              }
              goto label_128;
            default:
              goto label_128;
          }
        case 10:
          switch (key[3])
          {
            case 'N':
              if (key == "CHANGEDATE")
              {
                if (activeRow == null)
                {
                  int num = (int) MessageBox.Show(Resources.CHANGERESERVEPAYMENTTYPE_NOTHINGSELECTED, Resources.ERROR_REQUIREDFIELD_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                  return;
                }
                if (!this.CheckResPayId(activeRow))
                {
                  int num = (int) MessageBox.Show(Resources.RESERVEPAYMENT_EDIT_NEWRESPAY, Resources.RESERVEPAYMENT_EDIT_NEWRESPAY_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                  return;
                }
                using (FormChangeReservePaymentDate form = (FormChangeReservePaymentDate) ObjectFactory.Instance.CreateForm(typeof (FormChangeReservePaymentDate)))
                {
                  form.ResPayId = (int) ((UltraGridBase) this.gridClaimants_ReservePayments).ActiveRow.Cells["ResPayId"].Value;
                  form.OldDate = (DateTime) ((UltraGridBase) this.gridClaimants_ReservePayments).ActiveRow.Cells["DateCreated"].Value;
                  if (form.ShowDialog() != DialogResult.OK)
                    return;
                  StringBuilder stringBuilder3 = new StringBuilder();
                  stringBuilder3.Append(CurrentUser.Instance.DisplayNameLastFirst);
                  stringBuilder3.Append(" changed the date from ");
                  stringBuilder3.Append(form.OldDate.ToShortDateString());
                  stringBuilder3.Append(" to ");
                  stringBuilder3.Append(form.NewDate.ToShortDateString());
                  stringBuilder3.Append(" on ResPayId ");
                  stringBuilder3.Append(form.ResPayId.ToString());
                  stringBuilder3.Append(".");
                  if (this._currentClaim != null)
                  {
                    int? claimId = this._currentClaim.ClaimId;
                    if (claimId.HasValue)
                    {
                      string action = stringBuilder3.ToString();
                      claimId = this._currentClaim.ClaimId;
                      int identifier = claimId.Value;
                      Utility.LogAction(action, identifier);
                      goto label_107;
                    }
                  }
                  if (this._currentClaim != null)
                    this._currentClaim.LoggingList.Add(stringBuilder3.ToString());
label_107:
                  this.CurrentClaim.Save();
                  this.RedisplayClaim();
                  this.DisplayCurrentClaimant();
                  return;
                }
              }
              goto label_128;
            case 'P':
              if (key == "ADDPAYMENT")
              {
                if (!this.VerifyLossPolicyDates() || activeRow == null)
                  return;
                this.AddPayment(false);
                StringBuilder stringBuilder4 = new StringBuilder();
                stringBuilder4.Append(CurrentUser.Instance.DisplayNameLastFirst);
                stringBuilder4.Append(" clicked Add Payment.");
                if (this._currentClaim != null)
                {
                  int? claimId = this._currentClaim.ClaimId;
                  if (claimId.HasValue)
                  {
                    string action = stringBuilder4.ToString();
                    claimId = this._currentClaim.ClaimId;
                    int identifier = claimId.Value;
                    Utility.LogAction(action, identifier);
                    return;
                  }
                }
                if (this._currentClaim == null)
                  return;
                this._currentClaim.LoggingList.Add(stringBuilder4.ToString());
                return;
              }
              goto label_128;
            case 'R':
              if (key == "ADDRESERVE")
              {
                if (!this.VerifyLossPolicyDates())
                  return;
                this.AddReserve();
                StringBuilder stringBuilder5 = new StringBuilder();
                stringBuilder5.Append(CurrentUser.Instance.DisplayNameLastFirst);
                stringBuilder5.Append(" clicked Add Reserve.");
                if (this._currentClaim != null)
                {
                  int? claimId = this._currentClaim.ClaimId;
                  if (claimId.HasValue)
                  {
                    string action = stringBuilder5.ToString();
                    claimId = this._currentClaim.ClaimId;
                    int identifier = claimId.Value;
                    Utility.LogAction(action, identifier);
                    return;
                  }
                }
                if (this._currentClaim == null)
                  return;
                this._currentClaim.LoggingList.Add(stringBuilder5.ToString());
                return;
              }
              goto label_128;
            case 'S':
              if (key == "CLOSECLAIM")
              {
                foreach (UltraGridRow row in ((UltraGridBase) this.gridClaimants_ReservePayments).Rows)
                {
                  if (Utility.IsNull(row.Cells["respayid"].Value) || (int) row.Cells["resPayId"].Value < 0)
                  {
                    int num = (int) MessageBox.Show("There are unsaved changes on this claimant. Please save the changes prior to closing the claimant.", "Unsaved Changes Found!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                  }
                }
                this.CloseClaim();
                StringBuilder stringBuilder6 = new StringBuilder();
                stringBuilder6.Append(CurrentUser.Instance.DisplayNameLastFirst);
                stringBuilder6.Append(" clicked Close Claim.");
                if (this._currentClaim != null)
                {
                  int? claimId = this._currentClaim.ClaimId;
                  if (claimId.HasValue)
                  {
                    string action = stringBuilder6.ToString();
                    claimId = this._currentClaim.ClaimId;
                    int identifier = claimId.Value;
                    Utility.LogAction(action, identifier);
                    return;
                  }
                }
                if (this._currentClaim == null)
                  return;
                this._currentClaim.LoggingList.Add(stringBuilder6.ToString());
                return;
              }
              goto label_128;
            default:
              goto label_128;
          }
        case 11:
          switch (key[0])
          {
            case 'A':
              if (key == "ADDCLAIMANT")
                break;
              goto label_128;
            case 'E':
              if (key == "EDITCOVTYPE")
              {
                this.EditCoverageType();
                return;
              }
              goto label_128;
            case 'R':
              if (key == "REOPENCLAIM")
              {
                if (!SecurityManager.Instance.AssertPermission("{B69F645B-A06D-44FE-AFDD-4B2EFA97A5AE}"))
                {
                  int num = (int) MessageBox.Show("You do not have permission to perform this function.", "Access Denied!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                  return;
                }
                this.ReopenClaim();
                StringBuilder stringBuilder7 = new StringBuilder();
                stringBuilder7.Append(CurrentUser.Instance.DisplayNameLastFirst);
                stringBuilder7.Append(" clicked Reopen Claim.");
                if (this._currentClaim != null)
                {
                  int? claimId = this._currentClaim.ClaimId;
                  if (claimId.HasValue)
                  {
                    string action = stringBuilder7.ToString();
                    claimId = this._currentClaim.ClaimId;
                    int identifier = claimId.Value;
                    Utility.LogAction(action, identifier);
                    return;
                  }
                }
                if (this._currentClaim == null)
                  return;
                this._currentClaim.LoggingList.Add(stringBuilder7.ToString());
                return;
              }
              goto label_128;
            default:
              goto label_128;
          }
          break;
        case 12:
          if (key == "DELETERESPAY")
          {
            this.DeleteReservePayment();
            StringBuilder stringBuilder8 = new StringBuilder();
            stringBuilder8.Append(CurrentUser.Instance.DisplayNameLastFirst);
            stringBuilder8.Append(" clicked Delete Reserve Payment.");
            if (this._currentClaim != null)
            {
              int? claimId = this._currentClaim.ClaimId;
              if (claimId.HasValue)
              {
                string action = stringBuilder8.ToString();
                claimId = this._currentClaim.ClaimId;
                int identifier = claimId.Value;
                Utility.LogAction(action, identifier);
                return;
              }
            }
            if (this._currentClaim == null)
              return;
            this._currentClaim.LoggingList.Add(stringBuilder8.ToString());
            return;
          }
          goto label_128;
        case 13:
          switch (key[0])
          {
            case 'D':
              if (key == "DELETEPAYMENT")
              {
                this.DeletePayment();
                StringBuilder stringBuilder9 = new StringBuilder();
                stringBuilder9.Append(CurrentUser.Instance.DisplayNameLastFirst);
                stringBuilder9.Append(" clicked Delete Payment.");
                if (this._currentClaim != null)
                {
                  int? claimId = this._currentClaim.ClaimId;
                  if (claimId.HasValue)
                  {
                    string action = stringBuilder9.ToString();
                    claimId = this._currentClaim.ClaimId;
                    int identifier = claimId.Value;
                    Utility.LogAction(action, identifier);
                    return;
                  }
                }
                if (this._currentClaim == null)
                  return;
                this._currentClaim.LoggingList.Add(stringBuilder9.ToString());
                return;
              }
              goto label_128;
            case 'P':
              if (key == "PAYMENTRETURN")
              {
                this.AddPayment(true);
                StringBuilder stringBuilder10 = new StringBuilder();
                stringBuilder10.Append(CurrentUser.Instance.DisplayNameLastFirst);
                stringBuilder10.Append(" clicked Payment Return.");
                if (this._currentClaim != null)
                {
                  int? claimId = this._currentClaim.ClaimId;
                  if (claimId.HasValue)
                  {
                    string action = stringBuilder10.ToString();
                    claimId = this._currentClaim.ClaimId;
                    int identifier = claimId.Value;
                    Utility.LogAction(action, identifier);
                    return;
                  }
                }
                if (this._currentClaim == null)
                  return;
                this._currentClaim.LoggingList.Add(stringBuilder10.ToString());
                return;
              }
              goto label_128;
            case 'V':
              if (key == "VIEWCHECKINFO")
                goto label_81;
              goto label_128;
            default:
              goto label_128;
          }
        case 15:
          if (key == "VIEWPAYMENTINFO")
            goto label_81;
          goto label_128;
        case 18:
          if (key == "CLEARCLAIMANTENTRY")
            break;
          goto label_128;
        default:
          goto label_128;
      }
      this.ClearClaimantEntry();
      StringBuilder stringBuilder11 = new StringBuilder();
      stringBuilder11.Append(CurrentUser.Instance.DisplayNameLastFirst);
      stringBuilder11.Append(" clicked Add/Clear Claimant Entry.");
      if (this._currentClaim != null)
      {
        int? claimId = this._currentClaim.ClaimId;
        if (claimId.HasValue)
        {
          string action = stringBuilder11.ToString();
          claimId = this._currentClaim.ClaimId;
          int identifier = claimId.Value;
          Utility.LogAction(action, identifier);
          return;
        }
      }
      if (this._currentClaim == null)
        return;
      this._currentClaim.LoggingList.Add(stringBuilder11.ToString());
      return;
label_81:
      this.ViewCheckPaymentInfo();
      StringBuilder stringBuilder12 = new StringBuilder();
      stringBuilder12.Append(CurrentUser.Instance.DisplayNameLastFirst);
      stringBuilder12.Append(" clicked View Payment Information.");
      if (this._currentClaim != null)
      {
        int? claimId = this._currentClaim.ClaimId;
        if (claimId.HasValue)
        {
          string action = stringBuilder12.ToString();
          claimId = this._currentClaim.ClaimId;
          int identifier = claimId.Value;
          Utility.LogAction(action, identifier);
          return;
        }
      }
      if (this._currentClaim == null)
        return;
      this._currentClaim.LoggingList.Add(stringBuilder12.ToString());
      return;
    }
label_128:
    int result;
    if (!int.TryParse(((KeyedSubObjectBase) ((ToolEventArgs) e).Tool).Key, out result))
      return;
    if (activeRow == null)
    {
      int num1 = (int) MessageBox.Show(Resources.CHANGERESERVEPAYMENTTYPE_NOTHINGSELECTED, Resources.ERROR_REQUIREDFIELD_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else if (!this.CheckResPayId(activeRow))
    {
      int num2 = (int) MessageBox.Show(Resources.RESERVEPAYMENT_EDIT_NEWRESPAY, Resources.RESERVEPAYMENT_EDIT_NEWRESPAY_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else
    {
      Utility.ChangeReservePaymentType(this._currentClaim.ClaimNumber, (int) ((UltraGridBase) this.gridClaimants_ReservePayments).ActiveRow.Cells["ResPayId"].Value, result);
      this._currentClaimant.LoadReservesPayments();
      this.DisplayCurrentClaimant();
    }
  }

  protected void AddReserve()
  {
    this.ShowClaimantReserveTab();
    FormAddReserve form = (FormAddReserve) ObjectFactory.Instance.CreateForm(typeof (FormAddReserve), new object[1]
    {
      (object) this._currentClaimant
    });
    int num = (int) form.ShowDialog();
    form.Dispose();
  }

  protected virtual void CloseClaim()
  {
    if (SystemSettings.KeyExists("CLOSECLAIM_SHOWMESSAGEOPTION") && !SystemSettings.GetBoolSetting("CLOSECLAIM_SHOWMESSAGEOPTION"))
    {
      if (MessageBox.Show(Resources.CLAIMANT_CLOSECLAIM_NOOPTION, Resources.CLAIMANT_CLOSECLAIMHEADER_NOOPTION, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
        return;
      this.CurrentClaimant.CloseClaim(true);
    }
    else
    {
      switch (MessageBox.Show(Resources.CLAIMANT_CLOSECLAIM, Resources.CLAIMANT_CLOSECLAIMHEADER, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
      {
        case DialogResult.Yes:
          this.CurrentClaimant.CloseClaim(true);
          break;
        case DialogResult.No:
          this.CurrentClaimant.CloseClaim(false);
          break;
        default:
          return;
      }
    }
    this.SaveClaimant(false);
    this.CurrentClaim.Save();
    this.RedisplayClaim();
    this.DisplayCurrentClaimant();
  }

  protected virtual bool CloseClaim(bool saveClaimant)
  {
    switch (MessageBox.Show(Resources.CLAIMANT_CLOSECLAIM, Resources.CLAIMANT_CLOSECLAIMHEADER, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
    {
      case DialogResult.Yes:
        this.CurrentClaimant.CloseClaim(true);
        break;
      case DialogResult.No:
        this.CurrentClaimant.CloseClaim(false);
        break;
      default:
        return false;
    }
    this.SaveClaimant(false);
    this.CurrentClaim.Save();
    this.RedisplayClaim();
    this.DisplayCurrentClaimant();
    return true;
  }

  protected virtual void CloseClaim(DateTime closeDate)
  {
    switch (MessageBox.Show(Resources.CLAIMANT_CLOSECLAIM, Resources.CLAIMANT_CLOSECLAIMHEADER, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
    {
      case DialogResult.Yes:
        this.CurrentClaimant.CloseClaim(true, closeDate);
        break;
      case DialogResult.No:
        this.CurrentClaimant.CloseClaim(false, closeDate);
        break;
      default:
        return;
    }
    this.SaveClaimant(false);
    this.CurrentClaim.Save();
    this.RedisplayClaim();
    this.DisplayCurrentClaimant();
  }

  protected bool CloseClaimSilent()
  {
    this.CurrentClaimant.CloseClaim(true);
    this.SaveClaimant(false);
    this.CurrentClaim.Save();
    this.RedisplayClaim();
    this.DisplayCurrentClaimant();
    return true;
  }

  protected virtual void ReopenClaim()
  {
    this.CurrentClaimant.OpenClaim();
    this.SaveClaimant(false);
    this.CurrentClaim.Save();
    this.RedisplayClaim();
    this.DisplayCurrentClaimant();
  }

  protected void ViewCheckPaymentInfo()
  {
    this.ViewPaymentInformation();
    this.DisplayCurrentClaimant();
  }

  protected virtual void FormClaimant_FormClosing(object sender, FormClosingEventArgs e)
  {
    int valueHash = Utility.GetValueHash((object) this);
    if (valueHash == this._initValueHash || this.CurrentClaimant == null || !SecurityManager.Instance.AssertPermission("{EB460F2D-0BDA-4FA1-9931-D08994969163}") || (e.CloseReason != CloseReason.UserClosing || !((INotifyChanges) this.CurrentClaimant).HasChanges) && valueHash == this._initValueHash)
      return;
    switch (MessageBox.Show(Resources.MESSAGE_CHANGEDETECTED, Resources.MESSAGEBOX_QUESTION_HEADER1, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1))
    {
      case DialogResult.Cancel:
        e.Cancel = true;
        break;
      case DialogResult.Yes:
        try
        {
          this.BaseIsClosing = true;
          this.SaveClaimant(true);
          e.Cancel = false;
          break;
        }
        catch (Exception ex)
        {
          e.Cancel = true;
          throw;
        }
      case DialogResult.No:
        if (this._currentClaimant != null)
          this._currentClaimant.EditState = Claimant.ClaimantState.None;
        e.Cancel = false;
        break;
    }
  }

  protected void RedisplayClaim()
  {
    foreach (Form mdiChild in MDIControls.Instance.MDIParent.MdiChildren)
    {
      if (mdiChild is FormClaims && this._currentClaim == (mdiChild as FormClaims).CurrentClaim)
      {
        this._currentClaim = (mdiChild as FormClaims).RedisplayClaim();
        break;
      }
    }
  }

  protected bool VerifyPayments()
  {
    if (((DisposableObjectCollectionBase) ((UltraGridBase) this.gridClaimants_ReservePayments).Rows).Count == 0 || this.CurrentClaimant.CountPayments() == 0)
    {
      int num = (int) MessageBox.Show(Resources.CLAIMANT_RESERVEPAYMENT_CHECKDETAILMESSAGE3, Resources.ERROR_INVALIDENTRY_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (((UltraGridBase) this.gridClaimants_ReservePayments).ActiveRow != null)
      return true;
    int num1 = (int) MessageBox.Show(Resources.CLAIMANT_RESERVEPAYMENT_CHECKDETAILMESSAGE2, Resources.ERROR_INVALIDENTRY_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    return false;
  }

  bool ISupportNoteSystem.CanCreateNewNote => true;

  public event ISupportNoteSystem.EntityInfoChangedEventHandler NoteEntityInfoChanged;

  event ISupportNoteSystem.EntityInfoChangedEventHandler ISupportNoteSystem.EntityInfoChanged
  {
    add => this.NoteEntityInfoChanged += value;
    remove => this.NoteEntityInfoChanged -= value;
  }

  bool IRecreatableEntity.CanReCreateEntity => true;

  Guid IRecreatableEntity.ControlGUID
  {
    get
    {
      return this.CurrentClaim == null ? Guid.Empty : Quote.FromControlNo(this.CurrentClaim.ControlNumber).ControlGuid;
    }
  }

  Guid IRecreatableEntity.EntityGuid
  {
    get => this._currentClaimant != null ? this._currentClaimant.ClaimantGuid : Guid.Empty;
  }

  string IRecreatableEntity.EntityName
  {
    get => this._currentClaimant != null ? this._currentClaimant.DisplayName : string.Empty;
  }

  string IRecreatableEntity.FriendlyEntityName
  {
    get => this._currentClaimant != null ? this._currentClaimant.DisplayName : string.Empty;
  }

  bool IRecreatableEntity.HasControlGUID => false;

  bool IRecreatableEntity.RecreateEntityInitialize(Guid entityGuid) => false;

  string IRecreatableEntity.RecreateTypeName => typeof (FormClaims).ToString();

  bool ISupportDocumentSystem.AllowAddNewDocument
  {
    get => this.CurrentClaimant != null && !this.CurrentClaimant.ClaimantGuid.Equals(Guid.Empty);
  }

  public event ISupportDocumentSystem.EntityInfoChangedEventHandler DocumentEntityInfoChanged;

  event ISupportDocumentSystem.EntityInfoChangedEventHandler ISupportDocumentSystem.EntityInfoChanged
  {
    add => this.DocumentEntityInfoChanged += value;
    remove => this.DocumentEntityInfoChanged -= value;
  }

  private void gridClaimants_ReservePayments_MouseEnterElement(object sender, UIElementEventArgs e)
  {
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.Override.TipStyleCell = (TipStyle) 2;
    if (!(e.Element is CellUIElement) || !(((KeyedSubObjectBase) (e.Element.GetContext(typeof (UltraGridCell)) as UltraGridCell).Column).Key == "Comments") || string.IsNullOrEmpty((e.Element.GetContext(typeof (UltraGridCell)) as UltraGridCell).Value.ToString()))
      return;
    this.ultraToolTipManager1.SetUltraToolTip((Control) this.gridClaimants_ReservePayments, new UltraToolTipInfo((e.Element.GetContext(typeof (UltraGridCell)) as UltraGridCell).Value.ToString(), (ToolTipImage) 3, "Comments", (DefaultableBoolean) 1));
    this.ultraToolTipManager1.ShowToolTip((Control) this.gridClaimants_ReservePayments);
  }

  private void gridClaimants_ReservePayments_MouseLeaveElement(object sender, UIElementEventArgs e)
  {
    this.ClearToolTip();
  }

  protected virtual void DeleteReservePayment()
  {
    if (((UltraGridBase) this.gridClaimants_ReservePayments).ActiveRow == null)
    {
      int num = (int) MessageBox.Show(Resources.DELETERESPAY_NOROWSELECTED, Resources.ERROR_REQUIREDFIELD_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else if (((UltraGridBase) this.gridClaimants_ReservePayments).ActiveRow.Cells["EntryType"].Value.ToString() == "Payment")
    {
      this.DeletePayment();
    }
    else
    {
      if (this._currentClaimant.ReservesAndPayments[((UltraGridBase) this.gridClaimants_ReservePayments).ActiveRow.Index].ReservePaymentId.HasValue)
      {
        DefaultDatabase.ExecuteNonQuery("spClaims_DeleteReservePayment", new object[2]
        {
          (object) "@ResPayId",
          (object) (int) ((UltraGridBase) this.gridClaimants_ReservePayments).ActiveRow.Cells["ResPayId"].Value
        });
        CurrentUser.Instance.LogAction($"Deleted ${((UltraGridBase) this.gridClaimants_ReservePayments).ActiveRow.Cells["ResPayAmount"].Value.ToString()} reserve on claim {this.CurrentClaimant.Owner.ClaimNumber}.");
      }
      this.RedisplayClaim();
      Claimant.ClaimantState editState = this._currentClaimant.EditState;
      this._currentClaimant = this._currentClaim.GetClaimant(this._currentClaimant.ClaimantGuid);
      this._currentClaimant.EditState = editState;
      this.DisplayCurrentClaimant();
      this._initValueHash = Utility.GetValueHash((object) this);
    }
  }

  protected void DeletePayment(string sprocName, object[] args)
  {
    if (!this.VerifyPayments())
      return;
    if (((UltraGridBase) this.gridClaimants_ReservePayments).ActiveRow.Cells["EntryType"].Value.ToString() != "Payment" && ((UltraGridBase) this.gridClaimants_ReservePayments).ActiveRow.Cells["EntryType"].Value.ToString() != "Payment-(VOID)")
    {
      int num = (int) MessageBox.Show(Resources.RESERVEPAYMENT_DELETEPAYMENTMESSAGE1, Resources.ERROR_INVALIDENTRY_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else
    {
      if (MessageBox.Show(Resources.RESERVEPAYMENT_DELETEPAYMENTMESSAGE, Resources.RESERVEPAYMENT_DELETEPAYMENTHEADER, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
        return;
      if (this._currentClaimant.ReservesAndPayments[((UltraGridBase) this.gridClaimants_ReservePayments).ActiveRow.Index].ReservePaymentId.HasValue)
      {
        DefaultDatabase.ExecuteNonQuery(sprocName, args);
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.Append(CurrentUser.Instance.DisplayNameLastFirst);
        stringBuilder.Append(" deleted $");
        stringBuilder.Append(((UltraGridBase) this.gridClaimants_ReservePayments).ActiveRow.Cells["ResPayAmount"].Value.ToString());
        stringBuilder.Append(" payment on claim ");
        stringBuilder.Append(this.CurrentClaimant.Owner.ClaimNumber);
        stringBuilder.Append(".");
        if (this._currentClaim != null)
          this._currentClaim.LoggingList.Add(stringBuilder.ToString());
        this.CurrentClaim.Save();
        this.RedisplayClaim();
        this.DisplayCurrentClaimant();
      }
      this.RedisplayClaim();
      Claimant.ClaimantState editState = this._currentClaimant.EditState;
      this._currentClaimant = this._currentClaim.GetClaimant(this._currentClaimant.ClaimantGuid);
      this._currentClaimant.EditState = editState;
      this.DisplayCurrentClaimant();
      this._initValueHash = Utility.GetValueHash((object) this);
    }
  }

  protected virtual void DeletePayment()
  {
    this.DeletePayment("spClaims_DeleteReservePayment", new object[2]
    {
      (object) "@ResPayId",
      (object) (int) ((UltraGridBase) this.gridClaimants_ReservePayments).ActiveRow.Cells["ResPayId"].Value
    });
  }

  private void ClearToolTip()
  {
    this.ultraToolTipManager1.SetUltraToolTip((Control) null, new UltraToolTipInfo(string.Empty, (ToolTipImage) 2, string.Empty, (DefaultableBoolean) 2));
    this.ultraToolTipManager1.HideToolTip();
  }

  protected virtual void LoadReservePaymentTypeMenu()
  {
    if (!SecurityManager.Instance.AssertPermission("{DF33CB2D-AE2B-4ee3-AA8C-24D08E14E090}") || !(((ToolsCollectionBase) this.ultraToolbarsManager1.Tools)["GridContextMenu"] is PopupMenuTool tool) || ((KeyedSubObjectsCollectionBase) tool.Tools).Exists("EDITCOVTYPE"))
      return;
    tool.Tools.AddTool("EDITCOVTYPE");
  }

  protected virtual void ultraToolbarsManager1_BeforeToolDropdown(
    object sender,
    BeforeToolDropdownEventArgs e)
  {
    if (!SecurityManager.Instance.AssertPermission("{EB460F2D-0BDA-4FA1-9931-D08994969163}"))
    {
      ((CancelEventArgs) e).Cancel = true;
    }
    else
    {
      if (!(((KeyedSubObjectBase) ((CancelableToolEventArgs) e).Tool).Key == "GridContextMenu"))
        return;
      this.LoadReservePaymentTypeMenu();
      if (!((KeyedSubObjectsCollectionBase) (((CancelableToolEventArgs) e).Tool as PopupMenuTool).Tools).Exists("EDIT"))
        return;
      ((ToolsCollectionBase) (((CancelableToolEventArgs) e).Tool as PopupMenuTool).Tools)["EDIT"].InstanceProps.Visible = SecurityManager.Instance.AssertPermission("{48E13963-BF89-4831-9E3A-44A3585B88B4}") ? (DefaultableBoolean) 1 : (DefaultableBoolean) 2;
    }
  }

  private void LoadLocationVehicles()
  {
  }

  List<int> ISupportTemplateDocs.SupportedTemplateGroupIDs
  {
    get => new List<int>() { 11, 10 };
  }

  object[] ISupportTemplateDocs.TagParserConstructorArgs(int automationDocGroupID)
  {
    object[] objArray = (object[]) null;
    switch ((Utility.AutomationDocumentGroups) automationDocGroupID)
    {
      case Utility.AutomationDocumentGroups.Claim:
        if (this._currentClaimant != null && this._currentClaimant.ClaimantGuid != Guid.Empty)
        {
          objArray = new object[1]
          {
            (object) Utility.GetClaimGuid(this._currentClaimant.ClaimantGuid)
          };
          break;
        }
        break;
      case Utility.AutomationDocumentGroups.Claimant:
        if (this._currentClaimant != null && this._currentClaimant.ClaimantGuid != Guid.Empty)
        {
          objArray = new object[1]
          {
            (object) this._currentClaimant.ClaimantGuid
          };
          break;
        }
        break;
      default:
        objArray = new object[0];
        break;
    }
    return objArray;
  }

  private void FormClaimant_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    this.InitializeForm();
    if (SystemSettings.KeyExists("CLAIMS_SHOWRESPAYCOLORS"))
      this._showColors = SystemSettings.GetBoolSetting("CLAIMS_SHOWRESPAYCOLORS");
    if (this.CurrentClaimant.ClaimantGuid.Equals(Guid.Empty))
    {
      this.CurrentClaimant.EditState = Claimant.ClaimantState.UpdatedNew;
    }
    else
    {
      this.CurrentClaimant.EditState = Claimant.ClaimantState.Updated;
      this.CheckClaimantOFACStatus();
    }
    if (SystemSettings.KeyExists("Claims.ShowVeriskTab"))
      ((UltraTabControlBase) this.tabControlClaimants).Tabs["VERISK"].Visible = SystemSettings.GetBoolSetting("Claims.ShowVeriskTab");
    this.DisplayCurrentClaimant();
    this._initValueHash = Utility.GetValueHash((object) this);
    if (this._currentClaimant != null && this._currentClaimant.ClaimantGuid != Guid.Empty)
      Note_System.Instance.UIInteractive.ViewPopupNotes(Guid.Empty, this._currentClaimant.ClaimantGuid, (Form) this);
    if (this._currentClaimant != null)
    {
      StringBuilder stringBuilder = new StringBuilder();
      stringBuilder.Append(this.Text);
      stringBuilder.Append(" - Claimant: ");
      stringBuilder.Append(this._currentClaimant.DisplayName);
      if (this._currentClaim != null && !string.IsNullOrEmpty(this._currentClaim.ClaimNumber))
      {
        stringBuilder.Append("(Claim #: ");
        stringBuilder.Append(this._currentClaim.ClaimNumber);
        stringBuilder.Append(")");
      }
      this.Text = stringBuilder.ToString();
    }
    this.SetReadOnlyMode();
    this.LoadAttorneys();
    this.LoadMedicareEligibilityData();
  }

  private void CheckClaimantOFACStatus()
  {
    if (!Utility.PerformOFACCheck(new ClaimOFACEntity(this._currentClaimant.ClaimantGuid, "MGASystems.IMS.Claims.FormClaims")
    {
      CorporationName = this._currentClaimant.ClaimantInformation.CorporationName,
      DBAName = string.Empty,
      FirstName = this._currentClaimant.ClaimantInformation.FirstName,
      MiddleName = this._currentClaimant.ClaimantInformation.MiddleName,
      LastName = this._currentClaimant.ClaimantInformation.LastName,
      FEINSSN = string.IsNullOrEmpty(this._currentClaimant.ClaimantInformation.Fein) ? this._currentClaimant.ClaimantInformation.SocialSecurityNumber : this._currentClaimant.ClaimantInformation.Fein,
      ISOCountryCode = this._currentClaimant.PrimaryAddress.IsoCountryCode,
      Address1 = this._currentClaimant.PrimaryAddress.Address1,
      Address2 = this._currentClaimant.PrimaryAddress.Address2,
      City = this._currentClaimant.PrimaryAddress.City,
      State = this._currentClaimant.PrimaryAddress.State,
      ZipCode = this._currentClaimant.PrimaryAddress.ZipCode,
      ParentEntityGuid = new Guid?()
    }))
      return;
    ((Control) this.statusBar1).Visible = true;
    ((ToolsCollectionBase) ((UltraToolbarBase) this.ultraToolbarsManager1.Toolbars[0]).Tools)["ADDRESERVE"].SharedProps.Enabled = false;
    ((ToolsCollectionBase) ((UltraToolbarBase) this.ultraToolbarsManager1.Toolbars[0]).Tools)["ADDPAYMENT"].SharedProps.Enabled = false;
  }

  protected void HashForm() => this._initValueHash = Utility.GetValueHash((object) this);

  protected virtual bool VerifyLossPolicyDates()
  {
    DateTime date1 = this._currentClaim.LossDate.Date;
    DateTime date2 = this._currentClaim.PolicyInformation.PolicyEffectiveDate.Date;
    DateTime date3 = this._currentClaim.PolicyInformation.PolicyExpirationDate.Date;
    if (SecurityManager.Instance.AssertPermission("{83FF52BD-9064-474C-8252-97406FF6C070}") || !(date1 < date2) && !(date1 > date3))
      return true;
    int num = (int) MessageBox.Show("The loss date is outside the effective and expiration dates. You do not have rights to complete this transaction.", "Invalid Loss/Policy Dates", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    return false;
  }

  private void dateTimePicker_ValueChanged(object sender, EventArgs e)
  {
    StringBuilder stringBuilder = new StringBuilder();
    stringBuilder.Append(CurrentUser.Instance.DisplayNameLastFirst);
    stringBuilder.Append(" changed the ");
    if (((Control) (sender as MGADateTimePicker)).Tag == null)
      stringBuilder.Append(((Control) (sender as MGADateTimePicker)).Name);
    else
      stringBuilder.Append(((Control) (sender as MGADateTimePicker)).Tag.ToString());
    stringBuilder.Append(" to ");
    stringBuilder.Append(((Control) (sender as MGADateTimePicker)).Text.ToString());
    stringBuilder.Append(".");
    if (this._currentClaim == null)
      return;
    this._currentClaim.LoggingList.Add(stringBuilder.ToString());
  }

  private void maskedEditClaimants_SSNFEIN_ValueChanged(object sender, EventArgs e)
  {
    StringBuilder stringBuilder = new StringBuilder();
    stringBuilder.Append(CurrentUser.Instance.DisplayNameLastFirst);
    stringBuilder.Append(" changed the ");
    if (((Control) (sender as MGAMaskedEdit)).Tag == null)
      stringBuilder.Append(((Control) (sender as MGAMaskedEdit)).Name);
    else
      stringBuilder.Append(((Control) (sender as MGAMaskedEdit)).Tag.ToString());
    stringBuilder.Append(" to ");
    stringBuilder.Append(((UltraMaskedEdit) (sender as MGAMaskedEdit)).Value.ToString());
    stringBuilder.Append(".");
    if (this._currentClaim == null)
      return;
    this._currentClaim.LoggingList.Add(stringBuilder.ToString());
  }

  private void addResolver_Enter(object sender, EventArgs e)
  {
    AddressResolver_MULTI addressResolverMulti = sender as AddressResolver_MULTI;
    FormClaimant.Cached_AddressResolverProperties resolverProperties;
    resolverProperties.ControlName = ((Control) addressResolverMulti).Name;
    resolverProperties.ControlTag = ((Control) addressResolverMulti).Tag.ToString();
    resolverProperties.Address1 = addressResolverMulti.Address1;
    resolverProperties.Address2 = addressResolverMulti.Address2;
    resolverProperties.City = addressResolverMulti.City;
    resolverProperties.State = addressResolverMulti.State;
    resolverProperties.ZipCode = addressResolverMulti.ZipCode;
    this._addressResolverCache.Add(resolverProperties);
  }

  private void addResolver_Leave(object sender, EventArgs e)
  {
    AddressResolver_MULTI control = sender as AddressResolver_MULTI;
    if (!this._addressResolverCache.Exists((Predicate<FormClaimant.Cached_AddressResolverProperties>) (cachedResolver => cachedResolver.ControlTag == ((Control) control).Tag.ToString())))
      return;
    FormClaimant.Cached_AddressResolverProperties resolverProperties = this._addressResolverCache.Find((Predicate<FormClaimant.Cached_AddressResolverProperties>) (cachedResolver => cachedResolver.ControlTag == ((Control) control).Tag.ToString()));
    if (resolverProperties.Address1 != control.Address1)
    {
      StringBuilder stringBuilder = new StringBuilder();
      stringBuilder.Append(CurrentUser.Instance.DisplayNameLastFirst);
      stringBuilder.Append(" changed the Address1 on the ");
      if (((Control) control).Tag == null)
        stringBuilder.Append(((Control) control).Name);
      else
        stringBuilder.Append(((Control) control).Tag.ToString());
      stringBuilder.Append(" from ");
      stringBuilder.Append(string.IsNullOrEmpty(resolverProperties.Address1) ? "<blank>" : resolverProperties.Address1);
      stringBuilder.Append(" to ");
      stringBuilder.Append(string.IsNullOrEmpty(control.Address1) ? "<blank>" : control.Address1);
      stringBuilder.Append(".");
      if (this._currentClaim != null)
        this._currentClaim.LoggingList.Add(stringBuilder.ToString());
    }
    if (resolverProperties.Address2 != control.Address2)
    {
      StringBuilder stringBuilder = new StringBuilder();
      stringBuilder.Append(CurrentUser.Instance.DisplayNameLastFirst);
      stringBuilder.Append(" changed the Address2 on the ");
      if (((Control) control).Tag == null)
        stringBuilder.Append(((Control) control).Name);
      else
        stringBuilder.Append(((Control) control).Tag.ToString());
      stringBuilder.Append(" from ");
      stringBuilder.Append(string.IsNullOrEmpty(resolverProperties.Address2) ? "<blank>" : resolverProperties.Address2);
      stringBuilder.Append(" to ");
      stringBuilder.Append(string.IsNullOrEmpty(control.Address2) ? "<blank>" : control.Address2);
      stringBuilder.Append(".");
      if (this._currentClaim != null)
        this._currentClaim.LoggingList.Add(stringBuilder.ToString());
    }
    if (resolverProperties.City != control.City)
    {
      StringBuilder stringBuilder = new StringBuilder();
      stringBuilder.Append(CurrentUser.Instance.DisplayNameLastFirst);
      stringBuilder.Append(" changed the City on the ");
      if (((Control) control).Tag == null)
        stringBuilder.Append(((Control) control).Name);
      else
        stringBuilder.Append(((Control) control).Tag.ToString());
      stringBuilder.Append(" from ");
      stringBuilder.Append(string.IsNullOrEmpty(resolverProperties.City) ? "<blank>" : resolverProperties.City);
      stringBuilder.Append(" to ");
      stringBuilder.Append(string.IsNullOrEmpty(control.City) ? "<blank>" : control.City);
      stringBuilder.Append(".");
      if (this._currentClaim != null)
        this._currentClaim.LoggingList.Add(stringBuilder.ToString());
    }
    if (resolverProperties.State != control.State)
    {
      StringBuilder stringBuilder = new StringBuilder();
      stringBuilder.Append(CurrentUser.Instance.DisplayNameLastFirst);
      stringBuilder.Append(" changed the State on the ");
      if (((Control) control).Tag == null)
        stringBuilder.Append(((Control) control).Name);
      else
        stringBuilder.Append(((Control) control).Tag.ToString());
      stringBuilder.Append(" from ");
      stringBuilder.Append(string.IsNullOrEmpty(resolverProperties.State) ? "<blank>" : resolverProperties.State);
      stringBuilder.Append(" to ");
      stringBuilder.Append(string.IsNullOrEmpty(control.State) ? "<blank>" : control.State);
      stringBuilder.Append(".");
      if (this._currentClaim != null)
        this._currentClaim.LoggingList.Add(stringBuilder.ToString());
    }
    if (!(resolverProperties.ZipCode != control.ZipCode))
      return;
    StringBuilder stringBuilder1 = new StringBuilder();
    stringBuilder1.Append(CurrentUser.Instance.DisplayNameLastFirst);
    stringBuilder1.Append(" changed the ZipCode on the ");
    if (((Control) control).Tag == null)
      stringBuilder1.Append(((Control) control).Name);
    else
      stringBuilder1.Append(((Control) control).Tag.ToString());
    stringBuilder1.Append(" from ");
    stringBuilder1.Append(string.IsNullOrEmpty(resolverProperties.ZipCode) ? "<blank>" : resolverProperties.ZipCode);
    stringBuilder1.Append(" to ");
    stringBuilder1.Append(string.IsNullOrEmpty(control.ZipCode) ? "<blank>" : control.ZipCode);
    stringBuilder1.Append(".");
    if (this._currentClaim == null)
      return;
    this._currentClaim.LoggingList.Add(stringBuilder1.ToString());
  }

  private void text_Enter(object sender, EventArgs e)
  {
    MGATextBox mgaTextBox = sender as MGATextBox;
    FormClaimant.Cached_TextProperties cachedTextProperties;
    cachedTextProperties.ControlName = ((Control) mgaTextBox).Name;
    cachedTextProperties.ControlTag = ((Control) mgaTextBox).Tag == null ? string.Empty : ((Control) mgaTextBox).Tag.ToString();
    cachedTextProperties.Text = ((Control) mgaTextBox).Text;
    this._textBoxCache.Add(cachedTextProperties);
  }

  private void text_Leave(object sender, EventArgs e)
  {
    MGATextBox control = sender as MGATextBox;
    if (((Control) control).Tag == null)
      ((Control) control).Tag = (object) string.Empty;
    if (!this._textBoxCache.Exists((Predicate<FormClaimant.Cached_TextProperties>) (cachedText => cachedText.ControlTag == ((Control) control).Tag.ToString())))
      return;
    FormClaimant.Cached_TextProperties cachedTextProperties = this._textBoxCache.Find((Predicate<FormClaimant.Cached_TextProperties>) (cachedText => cachedText.ControlTag == ((Control) control).Tag.ToString()));
    if (!(cachedTextProperties.Text != ((Control) control).Text))
      return;
    StringBuilder stringBuilder = new StringBuilder();
    stringBuilder.Append(CurrentUser.Instance.DisplayNameLastFirst);
    stringBuilder.Append(" changed the text on the ");
    if (((Control) control).Tag == null)
      stringBuilder.Append(((Control) control).Name);
    else
      stringBuilder.Append(((Control) control).Tag.ToString());
    stringBuilder.Append(" from ");
    stringBuilder.Append(string.IsNullOrEmpty(cachedTextProperties.Text) ? "<blank>" : cachedTextProperties.Text);
    stringBuilder.Append(" to ");
    stringBuilder.Append(string.IsNullOrEmpty(((Control) control).Text) ? "<blank>" : ((Control) control).Text);
    stringBuilder.Append(".");
    if (this._currentClaim == null)
      return;
    this._currentClaim.LoggingList.Add(stringBuilder.ToString());
  }

  private void combo_Enter(object sender, EventArgs e)
  {
    MGASimpleComboBox mgaSimpleComboBox = sender as MGASimpleComboBox;
    FormClaimant.Cached_ComboProperties cachedComboProperties;
    cachedComboProperties.ControlName = ((Control) mgaSimpleComboBox).Name;
    cachedComboProperties.ControlTag = ((Control) mgaSimpleComboBox).Tag.ToString();
    cachedComboProperties.Text = ((Control) mgaSimpleComboBox).Text;
    cachedComboProperties.Value = ((UltraCombo) mgaSimpleComboBox).Value;
    this._comboBoxCache.Add(cachedComboProperties);
  }

  private void combo_Leave(object sender, EventArgs e)
  {
    MGASimpleComboBox control = sender as MGASimpleComboBox;
    if (!this._comboBoxCache.Exists((Predicate<FormClaimant.Cached_ComboProperties>) (cachedText => cachedText.ControlTag == ((Control) control).Tag.ToString())))
      return;
    FormClaimant.Cached_ComboProperties cachedComboProperties = this._comboBoxCache.Find((Predicate<FormClaimant.Cached_ComboProperties>) (cachedText => cachedText.ControlTag == ((Control) control).Tag.ToString()));
    if (cachedComboProperties.Value == ((UltraCombo) control).Value)
      return;
    StringBuilder stringBuilder = new StringBuilder();
    stringBuilder.Append(CurrentUser.Instance.DisplayNameLastFirst);
    stringBuilder.Append(" changed the value on the ");
    if (((Control) control).Tag == null)
      stringBuilder.Append(((Control) control).Name);
    else
      stringBuilder.Append(((Control) control).Tag.ToString());
    stringBuilder.Append(" from ");
    stringBuilder.Append(string.IsNullOrEmpty(cachedComboProperties.Text) ? "<blank>" : cachedComboProperties.Text);
    stringBuilder.Append(" to ");
    stringBuilder.Append(string.IsNullOrEmpty(((Control) control).Text) ? "<blank>" : ((Control) control).Text);
    stringBuilder.Append(".");
    if (this._currentClaim == null)
      return;
    this._currentClaim.LoggingList.Add(stringBuilder.ToString());
  }

  private void SetReadOnlyMode()
  {
    if (SecurityManager.Instance.AssertPermission("{EB460F2D-0BDA-4FA1-9931-D08994969163}"))
      return;
    foreach (Control control in (ArrangedElementCollection) this.Controls)
    {
      if (control.GetType() != typeof (UltraTabControl) && control.GetType() != typeof (Panel))
        control.Enabled = false;
    }
    foreach (UltraTab tab in ((UltraTabControlBase) this.tabControlClaimants).Tabs)
    {
      foreach (Control control1 in (ArrangedElementCollection) ((Control) tab.TabPage).Controls)
      {
        if (control1.GetType() != typeof (UltraGrid) && control1.GetType() != typeof (TabPage) && control1.GetType() != typeof (UltraTab) && control1.GetType() != typeof (GroupBox) && control1.GetType() != typeof (Panel))
          control1.Enabled = false;
        else if (control1.GetType() == typeof (GroupBox) || control1.GetType() == typeof (Panel))
        {
          foreach (Control control2 in (ArrangedElementCollection) control1.Controls)
          {
            if (control2.GetType() != typeof (UltraGrid) && control2.GetType() != typeof (TabPage) && control2.GetType() != typeof (UltraTab))
              control2.Enabled = false;
          }
        }
      }
    }
  }

  protected virtual void gridClaimants_ReservePayments_InitializeRow(
    object sender,
    InitializeRowEventArgs e)
  {
    if (!this._showColors)
      return;
    if ((bool) e.Row.Cells["IsVoid"].Value)
    {
      ((AppearanceBase) e.Row.CellAppearance).ForeColor = Color.Red;
      ((AppearanceBase) e.Row.CellAppearance).FontData.Bold = (DefaultableBoolean) 1;
      if (!e.Row.Cells["EntryType"].Value.ToString().Contains("-(VOID)"))
        e.Row.Cells["EntryType"].Value = (object) (e.Row.Cells["EntryType"].Value.ToString() + "-(VOID)");
    }
    else
      ((AppearanceBase) e.Row.CellAppearance).ForeColor = Color.Black;
    if ((bool) e.Row.Cells["IsPaymentReduction"].Value)
    {
      if ((bool) e.Row.Cells["IsVoid"].Value)
        return;
      ((AppearanceBase) e.Row.CellAppearance).ForeColor = Color.Blue;
      if (e.Row.Cells["EntryType"].Value.ToString().Contains("-(PAYMENT OFFSET)"))
        return;
      e.Row.Cells["EntryType"].Value = (object) (e.Row.Cells["EntryType"].Value.ToString() + "-(PAYMENT OFFSET)");
    }
    else
    {
      if ((bool) e.Row.Cells["IsVoid"].Value)
        return;
      ((AppearanceBase) e.Row.CellAppearance).ForeColor = Color.Black;
    }
  }

  private void cboDefenseAttorney_RowSelected(object sender, RowSelectedEventArgs e)
  {
    this.ClearAddress(this.addResolverClaimants_DefenseAttorney);
    this.phoneClaimants_DefenseAttorney.DeleteAll();
    DataTable dataSource = (DataTable) ((UltraGridBase) this.cboDefenseAttorney).DataSource;
    if (Guid.Parse(((UltraCombo) this.cboDefenseAttorney).Value.ToString()) == Guid.Empty)
    {
      this.CurrentClaimant.LegalInformation.DefenseAttorneyGuid = Guid.Empty;
      this.CurrentClaimant.LegalInformation.DefenseAttorney = string.Empty;
      this.optionDefenseEntityType.Value = (object) "I";
      ((TextEditorControlBase) this.textClaimants_DefenseFirm).Value = (object) string.Empty;
      ((UltraMaskedEdit) this.textClaimants_DefenseFEIN).Value = (object) string.Empty;
    }
    else
    {
      foreach (DataRow row in (InternalDataCollectionBase) dataSource.Rows)
      {
        if (row.Field<Guid>("AttorneyGuid") == Guid.Parse(((UltraCombo) this.cboDefenseAttorney).Value.ToString()))
        {
          this.CurrentClaimant.LegalInformation.DefenseAttorneyGuid = !Utility.IsNull(row["AttorneyGuid"]) ? row.Field<Guid>("AttorneyGuid") : Guid.Empty;
          this.CurrentClaimant.LegalInformation.DefenseAttorney = ((Control) this.cboDefenseAttorney).Text;
          if (!Utility.IsNull(row["AttorneyEntityType"]))
            this.optionDefenseEntityType.Value = (object) row.Field<string>("AttorneyEntityType");
          if (!Utility.IsNull(row["LawFirm"]))
            ((TextEditorControlBase) this.textClaimants_DefenseFirm).Value = (object) row.Field<string>("LawFirm");
          if (!Utility.IsNull(row["FEINSSN"]))
            ((UltraMaskedEdit) this.textClaimants_DefenseFEIN).Value = (object) row.Field<string>("FEINSSN");
          if (!Utility.IsNull(row["ISOCountryCode"]))
            this.addResolverClaimants_DefenseAttorney.ISOCountryCode = row.Field<string>("ISOCountryCode");
          if (!Utility.IsNull(row["Address1"]))
            this.addResolverClaimants_DefenseAttorney.Address1 = row.Field<string>("Address1");
          if (!Utility.IsNull(row["Address2"]))
            this.addResolverClaimants_DefenseAttorney.Address2 = row.Field<string>("Address2");
          if (!Utility.IsNull(row["ZipCode"]))
            this.addResolverClaimants_DefenseAttorney.ZipCode = row.Field<string>("ZipCode");
          if (!Utility.IsNull(row["ZipPlus"]))
            this.addResolverClaimants_DefenseAttorney.ZipCodeExtension = row.Field<string>("ZipPlus");
          if (!Utility.IsNull(row["City"]))
            this.addResolverClaimants_DefenseAttorney.City = row.Field<string>("City");
          if (!Utility.IsNull(row["State"]))
            this.addResolverClaimants_DefenseAttorney.State = row.Field<string>("State");
          if (!Utility.IsNull(row["County"]))
            this.addResolverClaimants_DefenseAttorney.County = row.Field<string>("County");
          if (!Utility.IsNull(row["PhoneNumber"]))
            this.phoneClaimants_DefenseAttorney.AddNew(row.Field<string>("PhoneNumber"));
          if (!Utility.IsNull(row["FaxNumber"]))
          {
            if (this.optionDefenseEntityType.Value != null && this.optionDefenseEntityType.Value.ToString() == "I")
              this.phoneClaimants_DefenseAttorney.AddNew(row.Field<string>("FaxNumber"), "Home Fax");
            else
              this.phoneClaimants_DefenseAttorney.AddNew(row.Field<string>("FaxNumber"), "Business Fax");
          }
        }
      }
    }
  }

  private void cboClaimantAttorney_RowSelected(object sender, RowSelectedEventArgs e)
  {
    this.ClearAddress(this.addResolverClaimants_ClaimantAttorney);
    this.phoneClaimants_ClaimantAttorney.DeleteAll();
    DataTable dataSource = (DataTable) ((UltraGridBase) this.cboClaimantAttorney).DataSource;
    if (Guid.Parse(((UltraCombo) this.cboClaimantAttorney).Value.ToString()) == Guid.Empty)
    {
      this.CurrentClaimant.LegalInformation.ClaimantAttorneyGuid = Guid.Empty;
      this.CurrentClaimant.LegalInformation.ClaimantAttorney = string.Empty;
      this.optionClaimantAttorneyEntityType.Value = (object) "I";
      ((TextEditorControlBase) this.textClaimants_ClaimantLawFirm).Value = (object) string.Empty;
      ((UltraMaskedEdit) this.textClaimants_ClaimantAttorneyFEIN).Value = (object) string.Empty;
    }
    else
    {
      foreach (DataRow row in (InternalDataCollectionBase) dataSource.Rows)
      {
        if (row.Field<Guid>("AttorneyGuid") == Guid.Parse(((UltraCombo) this.cboClaimantAttorney).Value.ToString()))
        {
          this.CurrentClaimant.LegalInformation.ClaimantAttorneyGuid = !Utility.IsNull(row["AttorneyGuid"]) ? row.Field<Guid>("AttorneyGuid") : Guid.Empty;
          this.CurrentClaimant.LegalInformation.ClaimantAttorney = ((Control) this.cboClaimantAttorney).Text;
          if (!Utility.IsNull(row["AttorneyEntityType"]))
            this.optionClaimantAttorneyEntityType.Value = (object) row.Field<string>("AttorneyEntityType");
          if (!Utility.IsNull(row["LawFirm"]))
            ((TextEditorControlBase) this.textClaimants_ClaimantLawFirm).Value = (object) row.Field<string>("LawFirm");
          if (!Utility.IsNull(row["FEINSSN"]))
            ((UltraMaskedEdit) this.textClaimants_ClaimantAttorneyFEIN).Value = (object) row.Field<string>("FEINSSN");
          if (!Utility.IsNull(row["ISOCountryCode"]))
            this.addResolverClaimants_ClaimantAttorney.ISOCountryCode = row.Field<string>("ISOCountryCode");
          if (!Utility.IsNull(row["Address1"]))
            this.addResolverClaimants_ClaimantAttorney.Address1 = row.Field<string>("Address1");
          if (!Utility.IsNull(row["Address2"]))
            this.addResolverClaimants_ClaimantAttorney.Address2 = row.Field<string>("Address2");
          if (!Utility.IsNull(row["ZipCode"]))
            this.addResolverClaimants_ClaimantAttorney.ZipCode = row.Field<string>("ZipCode");
          if (!Utility.IsNull(row["ZipPlus"]))
            this.addResolverClaimants_ClaimantAttorney.ZipCodeExtension = row.Field<string>("ZipPlus");
          if (!Utility.IsNull(row["City"]))
            this.addResolverClaimants_ClaimantAttorney.City = row.Field<string>("City");
          if (!Utility.IsNull(row["State"]))
            this.addResolverClaimants_ClaimantAttorney.State = row.Field<string>("State");
          if (!Utility.IsNull(row["County"]))
            this.addResolverClaimants_ClaimantAttorney.County = row.Field<string>("County");
          if (!Utility.IsNull(row["PhoneNumber"]))
            this.phoneClaimants_ClaimantAttorney.AddNew(row.Field<string>("PhoneNumber"));
          if (!Utility.IsNull(row["FaxNumber"]))
          {
            if (this.optionDefenseEntityType.Value != null && this.optionDefenseEntityType.Value.ToString() == "I")
              this.phoneClaimants_ClaimantAttorney.AddNew(row.Field<string>("FaxNumber"), "Home Fax");
            else
              this.phoneClaimants_ClaimantAttorney.AddNew(row.Field<string>("FaxNumber"), "Business Fax");
          }
        }
      }
    }
  }

  protected void ClearAddress(AddressResolver_MULTI addr)
  {
    addr.ISOCountryCode = "";
    addr.Address1 = "";
    addr.Address2 = "";
    addr.ZipCode = "";
    addr.ZipCodeExtension = "";
    addr.City = "";
    addr.State = "";
    addr.County = "";
  }

  protected void SetHashValue() => this._initValueHash = Utility.GetValueHash((object) this);

  private void addResolverClaimants_Primary_ZipCodeChanged(object sender, EventArgs e)
  {
    if (!string.IsNullOrEmpty(this.addResolverClaimants_Primary.ZipCode))
      return;
    this.addResolverClaimants_Primary.ZipCodeExtension = string.Empty;
    this.addResolverClaimants_Primary.City = string.Empty;
    this.addResolverClaimants_Primary.State = string.Empty;
    this.addResolverClaimants_Primary.County = string.Empty;
  }

  private void addResolverClaimants_Mailing_ZipCodeChanged(object sender, EventArgs e)
  {
    if (!string.IsNullOrEmpty(this.addResolverClaimants_Mailing.ZipCode))
      return;
    this.addResolverClaimants_Mailing.ZipCodeExtension = string.Empty;
    this.addResolverClaimants_Mailing.City = string.Empty;
    this.addResolverClaimants_Mailing.State = string.Empty;
    this.addResolverClaimants_Mailing.County = string.Empty;
  }

  private void lnkICD_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    Process.Start("https://clients.mspnavigator.com/Public/ICDLookup.aspx");
  }

  protected virtual void LoadAttorneys()
  {
    if (SystemSettings.KeyExists("CLAIMS_LEGACYATTORNEYS") && SystemSettings.GetBoolSetting("CLAIMS_LEGACYATTORNEYS"))
    {
      ((UltraCombo) this.cboDefenseAttorney).RowSelected -= new RowSelectedEventHandler(this.cboDefenseAttorney_RowSelected);
      ((Control) this.cboDefenseAttorney).Visible = false;
      ((Control) this.textClaimants_DefenseAttorney).Visible = true;
      ((Control) this.optionDefenseEntityType).Enabled = true;
      ((Control) this.textClaimants_DefenseFirm).Enabled = true;
      ((EditorButtonControlBase) this.textClaimants_DefenseAttorney).ReadOnly = false;
      ((Control) this.textClaimants_DefenseFEIN).Enabled = true;
      ((Control) this.addResolverClaimants_DefenseAttorney).Enabled = true;
      this.phoneClaimants_DefenseAttorney.Enabled = true;
      ((UltraCombo) this.cboClaimantAttorney).RowSelected -= new RowSelectedEventHandler(this.cboClaimantAttorney_RowSelected);
      ((Control) this.cboClaimantAttorney).Visible = false;
      ((Control) this.textClaimants_ClaimantAttorney).Visible = true;
      ((Control) this.optionClaimantAttorneyEntityType).Enabled = true;
      ((Control) this.textClaimants_ClaimantLawFirm).Enabled = true;
      ((EditorButtonControlBase) this.textClaimants_ClaimantAttorney).ReadOnly = false;
      ((Control) this.textClaimants_ClaimantAttorneyFEIN).Enabled = true;
      ((Control) this.addResolverClaimants_ClaimantAttorney).Enabled = true;
      this.phoneClaimants_ClaimantAttorney.Enabled = true;
    }
    else
    {
      if (this.CurrentClaimant.LegalInformation.DefenseAttorney.Length > 0)
      {
        Guid defenseAttorneyGuid = this.CurrentClaimant.LegalInformation.DefenseAttorneyGuid;
      }
      if (this.CurrentClaimant.LegalInformation.ClaimantAttorney.Length > 0)
      {
        Guid claimantAttorneyGuid = this.CurrentClaimant.LegalInformation.ClaimantAttorneyGuid;
      }
      ((UltraGridBase) this.cboDefenseAttorney).DataSource = (object) DefaultDatabase.ExecuteDataTable("spClaims_GetAttorneyList", new object[4]
      {
        (object) "@AttorneyType",
        (object) "D",
        (object) "@HideBlank",
        (object) false
      });
      ((UltraDropDownBase) this.cboDefenseAttorney).ValueMember = "AttorneyGuid";
      ((UltraDropDownBase) this.cboDefenseAttorney).DisplayMember = "AttorneyName";
      ((UltraCombo) this.cboDefenseAttorney).Value = (object) this.CurrentClaimant.LegalInformation.DefenseAttorneyGuid;
      ((UltraGridBase) this.cboClaimantAttorney).DataSource = (object) DefaultDatabase.ExecuteDataTable("spClaims_GetAttorneyList", new object[4]
      {
        (object) "@AttorneyType",
        (object) "C",
        (object) "@HideBlank",
        (object) false
      });
      ((UltraDropDownBase) this.cboClaimantAttorney).ValueMember = "AttorneyGuid";
      ((UltraDropDownBase) this.cboClaimantAttorney).DisplayMember = "AttorneyName";
      ((UltraCombo) this.cboClaimantAttorney).Value = (object) this.CurrentClaimant.LegalInformation.ClaimantAttorneyGuid;
    }
  }

  protected void LoadMedicareEligibilityData()
  {
    if (!((UltraTabControlBase) this.tabControlClaimants).Tabs["VERISK"].Visible)
      return;
    ((UltraDateTimeEditor) this.Verisk_dtExhaustDate).Value = (object) null;
    ((UltraDateTimeEditor) this.Verisk_dtFundingDelayed).Value = (object) null;
    ((UltraDateTimeEditor) this.Verisk_dtInjuredDeathDate).Value = (object) null;
    ((UltraDateTimeEditor) this.Verisk_dtORMTermination).Value = (object) null;
    this.LoadInsuranceTypes();
    this.LoadMedicareApprovals();
    this.LoadORMIndicators();
    this.LoadRepresentativeTypes();
    if (this.CurrentClaimant == null)
      return;
    Guid claimantGuid = this.CurrentClaimant.ClaimantGuid;
    if (this.CurrentClaimant.ClaimantGuid.Equals(Guid.Empty))
      return;
    DataRow dataRow = DefaultDatabase.ExecuteDataRow("Verisk_GetMedicareEligibilityData", new object[2]
    {
      (object) "@claimantGuid",
      (object) this.CurrentClaimant.ClaimantGuid
    });
    if (dataRow == null)
      return;
    if (!Utility.IsNull(dataRow["ExhaustDate"]))
      ((UltraDateTimeEditor) this.Verisk_dtExhaustDate).Value = dataRow["ExhaustDate"];
    if (!Utility.IsNull(dataRow["FundingDelayedDate"]))
      ((UltraDateTimeEditor) this.Verisk_dtFundingDelayed).Value = dataRow["FundingDelayedDate"];
    if (!Utility.IsNull(dataRow["ICDCode"]))
      ((Control) this.Verisk_txtICDCode).Text = dataRow["ICDCode"].ToString();
    if (!Utility.IsNull(dataRow["InjuredPartyDeathDate"]))
      ((UltraDateTimeEditor) this.Verisk_dtInjuredDeathDate).Value = dataRow["InjuredPartyDeathDate"];
    if (!Utility.IsNull(dataRow["InjuredPartyHICNMBI"]))
      ((Control) this.Verisk_txtHICNMBI).Text = dataRow["InjuredPartyHICNMBI"].ToString();
    if (!Utility.IsNull(dataRow["InsuranceTypeId"]))
      ((UltraCombo) this.Verisk_cboInsuranceType).Value = dataRow["InsuranceTypeId"];
    if (!Utility.IsNull(dataRow["MedicareApprovalId"]))
      ((UltraCombo) this.Verisk_cboMedicareApproval).Value = dataRow["MedicareApprovalId"];
    if (!Utility.IsNull(dataRow["MedicareApprovalComments"]))
      ((Control) this.Verisk_txtApprovalComments).Text = dataRow["MedicareApprovalComments"].ToString();
    if (!Utility.IsNull(dataRow["NoFaultPolicyLimit"]))
      ((UltraMaskedEdit) this.Verisk_mgaNoFaultPolicyLimit).Value = dataRow["NoFaultPolicyLimit"];
    if (!Utility.IsNull(dataRow["ORMIndicatorId"]))
      ((UltraCombo) this.Verisk_cboORMIndicator).Value = dataRow["ORMIndicatorId"];
    if (!Utility.IsNull(dataRow["ORMTerminationDate"]))
      ((UltraDateTimeEditor) this.Verisk_dtORMTermination).Value = dataRow["ORMTerminationDate"];
    if (Utility.IsNull(dataRow["RepresentativeTypeId"]))
      return;
    ((UltraCombo) this.Verisk_cboRepType).Value = dataRow["RepresentativeTypeId"];
  }

  private void LoadInsuranceTypes()
  {
    ((UltraGridBase) this.Verisk_cboInsuranceType).DataSource = (object) DefaultDatabase.ExecuteDataSet(CommandType.Text, "SELECT InsuranceTypeId, InsuranceType + @h + Description as [InsuranceType]  FROM dbo.Verisk_lstInsuranceType ORDER BY InsuranceTypeId", new object[2]
    {
      (object) "@h",
      (object) " − "
    });
    ((UltraDropDownBase) this.Verisk_cboInsuranceType).ValueMember = "InsuranceTypeId";
    ((UltraDropDownBase) this.Verisk_cboInsuranceType).DisplayMember = "InsuranceType";
  }

  private void LoadMedicareApprovals()
  {
    ((UltraGridBase) this.Verisk_cboMedicareApproval).DataSource = (object) DefaultDatabase.ExecuteDataSet(CommandType.Text, "SELECT * FROM dbo.Verisk_lstMedicareApproval ORDER BY MedicareApprovalId");
    ((UltraDropDownBase) this.Verisk_cboMedicareApproval).ValueMember = "MedicareApprovalId";
    ((UltraDropDownBase) this.Verisk_cboMedicareApproval).DisplayMember = "MedicareApproval";
  }

  private void LoadORMIndicators()
  {
    ((UltraGridBase) this.Verisk_cboORMIndicator).DataSource = (object) DefaultDatabase.ExecuteDataSet(CommandType.Text, "SELECT ORMIndicatorId, ORMIndicator + @h + Description as [ORMIndicator]  FROM dbo.Verisk_lstORMIndicator ORDER BY ORMIndicatorId", new object[2]
    {
      (object) "@h",
      (object) " − "
    });
    ((UltraDropDownBase) this.Verisk_cboORMIndicator).ValueMember = "ORMIndicatorId";
    ((UltraDropDownBase) this.Verisk_cboORMIndicator).DisplayMember = "ORMIndicator";
  }

  private void LoadRepresentativeTypes()
  {
    ((UltraGridBase) this.Verisk_cboRepType).DataSource = (object) DefaultDatabase.ExecuteDataSet(CommandType.Text, "SELECT RepresentativeTypeId, RepresentativeType + @h + Description as [RepresentativeType]  FROM dbo.Verisk_lstRepresentativeType ORDER BY RepresentativeTypeId", new object[2]
    {
      (object) "@h",
      (object) " − "
    });
    ((UltraDropDownBase) this.Verisk_cboRepType).ValueMember = "RepresentativeTypeId";
    ((UltraDropDownBase) this.Verisk_cboRepType).DisplayMember = "RepresentativeType";
  }

  public void SetMedicareEligibilityData()
  {
    if (!SystemSettings.KeyExists("Claims.ShowVeriskTab"))
      return;
    MedicareEligibilityData eligibilityData = this.CurrentClaimant.EligibilityData;
    if (eligibilityData == null)
      return;
    if (((Control) this.Verisk_cboInsuranceType).Text.Length > 0)
      eligibilityData.InsuranceTypeId = new int?((int) ((UltraCombo) this.Verisk_cboInsuranceType).Value);
    if (((TextEditorControlBase) this.Verisk_txtICDCode).Value != null)
      eligibilityData.ICDCode = ((Control) this.Verisk_txtICDCode).Text;
    if (((UltraDateTimeEditor) this.Verisk_dtExhaustDate).Value != null)
      eligibilityData.ExhaustDate = new DateTime?(((UltraDateTimeEditor) this.Verisk_dtExhaustDate).DateTime);
    if (((UltraDateTimeEditor) this.Verisk_dtFundingDelayed).Value != null)
      eligibilityData.FundingDelayedDate = new DateTime?(((UltraDateTimeEditor) this.Verisk_dtFundingDelayed).DateTime);
    if (((UltraDateTimeEditor) this.Verisk_dtInjuredDeathDate).Value != null)
      eligibilityData.InjuredPartyDeathDate = new DateTime?(((UltraDateTimeEditor) this.Verisk_dtInjuredDeathDate).DateTime);
    if (((TextEditorControlBase) this.Verisk_txtHICNMBI).Value != null)
      eligibilityData.InjuredPartyHICNMBI = ((Control) this.Verisk_txtHICNMBI).Text;
    if (((Control) this.Verisk_cboMedicareApproval).Text.Length > 0)
      eligibilityData.MedicareApprovalId = new int?((int) ((UltraCombo) this.Verisk_cboMedicareApproval).Value);
    if (((TextEditorControlBase) this.Verisk_txtApprovalComments).Value != null)
      eligibilityData.MedicareApprovalComments = ((Control) this.Verisk_txtApprovalComments).Text;
    Decimal result;
    if (((UltraMaskedEdit) this.Verisk_mgaNoFaultPolicyLimit).Value != null && Decimal.TryParse(((Control) this.Verisk_mgaNoFaultPolicyLimit).Text, out result))
      eligibilityData.NoFaultPolicyLimit = result;
    if (((Control) this.Verisk_cboORMIndicator).Text.Length > 0)
      eligibilityData.ORMIndicatorId = new int?((int) ((UltraCombo) this.Verisk_cboORMIndicator).Value);
    if (((UltraDateTimeEditor) this.Verisk_dtORMTermination).Value != null)
      eligibilityData.ORMTerminationDate = new DateTime?(((UltraDateTimeEditor) this.Verisk_dtORMTermination).DateTime);
    if (((Control) this.Verisk_cboRepType).Text.Length <= 0)
      return;
    eligibilityData.RepresentativeTypeId = new int?((int) ((UltraCombo) this.Verisk_cboRepType).Value);
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
    ValueListItem valueListItem1 = new ValueListItem();
    ValueListItem valueListItem2 = new ValueListItem();
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    Appearance appearance17 = new Appearance();
    Appearance appearance18 = new Appearance();
    Appearance appearance19 = new Appearance();
    Appearance appearance20 = new Appearance();
    Appearance appearance21 = new Appearance();
    Appearance appearance22 = new Appearance();
    ScrollBarLook scrollBarLook1 = new ScrollBarLook();
    Appearance appearance23 = new Appearance();
    Appearance appearance24 = new Appearance();
    Appearance appearance25 = new Appearance();
    Appearance appearance26 = new Appearance();
    Appearance appearance27 = new Appearance();
    Appearance appearance28 = new Appearance();
    Appearance appearance29 = new Appearance();
    Appearance appearance30 = new Appearance();
    Appearance appearance31 = new Appearance();
    Appearance appearance32 = new Appearance();
    Appearance appearance33 = new Appearance();
    Appearance appearance34 = new Appearance();
    Appearance appearance35 = new Appearance();
    Appearance appearance36 = new Appearance();
    ValueListItem valueListItem3 = new ValueListItem();
    ValueListItem valueListItem4 = new ValueListItem();
    ValueListItem valueListItem5 = new ValueListItem();
    ValueListItem valueListItem6 = new ValueListItem();
    Appearance appearance37 = new Appearance();
    Appearance appearance38 = new Appearance();
    Appearance appearance39 = new Appearance();
    Appearance appearance40 = new Appearance();
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
    UltraGridBand ultraGridBand = new UltraGridBand("ReservesPayments", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("ResPayId");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("EntryTypeId");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("EntryType", -1, (object) null, 12532344, 0, 0);
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("CoverageTypeId");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("CoverageType", -1, (object) null, 12532344, 4, 0);
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("CoverageTypeDescriptionId");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("CoverageTypeDescription", -1, (object) null, 12532344, 5, 0);
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("ResPayTypeId");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("ResPayType", -1, (object) null, 12532344, 2, 0);
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("ResPaySubTypeId");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("ResPaySubType", -1, (object) null, 12532344, 3, 0);
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("ResPayAmount", -1, (object) null, 12532344, 9, 1);
    Appearance appearance51 = new Appearance();
    Appearance appearance52 = new Appearance();
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("DateCreated", -1, (object) null, 12532344, 7, 1);
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("CreatedByGuid");
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("CreatedBy", -1, (object) null, 12532344, 6, 1);
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("Comments", -1, (object) null, 12532344, 8, 1);
    UltraGridColumn ultraGridColumn17 = new UltraGridColumn("PayeeGuid");
    UltraGridColumn ultraGridColumn18 = new UltraGridColumn("Payee", -1, (object) null, 12532344, 1, 0);
    UltraGridColumn ultraGridColumn19 = new UltraGridColumn("IsVoid");
    UltraGridColumn ultraGridColumn20 = new UltraGridColumn("IsPaymentReduction");
    UltraGridGroup ultraGridGroup = new UltraGridGroup("TopRow", 12532344);
    SummarySettings summarySettings = new SummarySettings("", (SummaryType) 1, (string) null, "ResPayAmount", 11, true, "ReservesPayments", 0, (SummaryPosition) 3, "ResPayAmount", 11, true);
    Appearance appearance53 = new Appearance();
    Appearance appearance54 = new Appearance();
    Appearance appearance55 = new Appearance();
    Appearance appearance56 = new Appearance();
    Appearance appearance57 = new Appearance();
    Appearance appearance58 = new Appearance();
    Appearance appearance59 = new Appearance();
    Appearance appearance60 = new Appearance();
    Appearance appearance61 = new Appearance();
    ScrollBarLook scrollBarLook2 = new ScrollBarLook();
    Appearance appearance62 = new Appearance();
    Appearance appearance63 = new Appearance();
    Appearance appearance64 = new Appearance();
    Appearance appearance65 = new Appearance();
    Appearance appearance66 = new Appearance();
    Appearance appearance67 = new Appearance();
    Appearance appearance68 = new Appearance();
    Appearance appearance69 = new Appearance();
    Appearance appearance70 = new Appearance();
    Appearance appearance71 = new Appearance();
    Appearance appearance72 = new Appearance();
    Appearance appearance73 = new Appearance();
    Appearance appearance74 = new Appearance();
    Appearance appearance75 = new Appearance();
    UltraTab ultraTab1 = new UltraTab();
    Appearance appearance76 = new Appearance();
    UltraTab ultraTab2 = new UltraTab();
    Appearance appearance77 = new Appearance();
    UltraTab ultraTab3 = new UltraTab();
    Appearance appearance78 = new Appearance();
    UltraTab ultraTab4 = new UltraTab();
    Appearance appearance79 = new Appearance();
    UltraTab ultraTab5 = new UltraTab();
    Appearance appearance80 = new Appearance();
    UltraTab ultraTab6 = new UltraTab();
    Appearance appearance81 = new Appearance();
    UltraToolbar ultraToolbar = new UltraToolbar("MainToolbar");
    ButtonTool buttonTool1 = new ButtonTool("SAVE");
    ButtonTool buttonTool2 = new ButtonTool("ADDCLAIMANT");
    ButtonTool buttonTool3 = new ButtonTool("CLEARCLAIMANTENTRY");
    ButtonTool buttonTool4 = new ButtonTool("ADDRESERVE");
    ButtonTool buttonTool5 = new ButtonTool("ADDPAYMENT");
    ButtonTool buttonTool6 = new ButtonTool("PAYMENTRETURN");
    ButtonTool buttonTool7 = new ButtonTool("DELETEPAYMENT");
    ButtonTool buttonTool8 = new ButtonTool("VIEWPAYMENTINFO");
    ButtonTool buttonTool9 = new ButtonTool("CLOSECLAIM");
    ButtonTool buttonTool10 = new ButtonTool("REOPENCLAIM");
    Appearance appearance82 = new Appearance();
    ButtonTool buttonTool11 = new ButtonTool("ADDCLAIMANT");
    Appearance appearance83 = new Appearance();
    ButtonTool buttonTool12 = new ButtonTool("ADDRESERVE");
    Appearance appearance84 = new Appearance();
    ButtonTool buttonTool13 = new ButtonTool("ADDPAYMENT");
    Appearance appearance85 = new Appearance();
    ButtonTool buttonTool14 = new ButtonTool("SAVE");
    Appearance appearance86 = new Appearance();
    ButtonTool buttonTool15 = new ButtonTool("CLOSECLAIM");
    Appearance appearance87 = new Appearance();
    ButtonTool buttonTool16 = new ButtonTool("REOPENCLAIM");
    Appearance appearance88 = new Appearance();
    ButtonTool buttonTool17 = new ButtonTool("CLEARCLAIMANTENTRY");
    Appearance appearance89 = new Appearance();
    PopupMenuTool popupMenuTool1 = new PopupMenuTool("GridContextMenu");
    ButtonTool buttonTool18 = new ButtonTool("VIEWCHECKINFO");
    ButtonTool buttonTool19 = new ButtonTool("DELETERESPAY");
    ButtonTool buttonTool20 = new ButtonTool("CHANGEDATE");
    ButtonTool buttonTool21 = new ButtonTool("EDIT");
    ButtonTool buttonTool22 = new ButtonTool("VIEWCHECKINFO");
    Appearance appearance90 = new Appearance();
    ButtonTool buttonTool23 = new ButtonTool("VIEWPAYMENTINFO");
    Appearance appearance91 = new Appearance();
    ButtonTool buttonTool24 = new ButtonTool("DELETEPAYMENT");
    Appearance appearance92 = new Appearance();
    ButtonTool buttonTool25 = new ButtonTool("PAYMENTRETURN");
    Appearance appearance93 = new Appearance();
    PopupMenuTool popupMenuTool2 = new PopupMenuTool("CHANGETYPE");
    ButtonTool buttonTool26 = new ButtonTool("DELETERESPAY");
    Appearance appearance94 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormClaimant));
    ButtonTool buttonTool27 = new ButtonTool("CHANGEDATE");
    Appearance appearance95 = new Appearance();
    ButtonTool buttonTool28 = new ButtonTool("EDIT");
    Appearance appearance96 = new Appearance();
    ButtonTool buttonTool29 = new ButtonTool("EDITCOVTYPE");
    Appearance appearance97 = new Appearance();
    UltraStatusPanel ultraStatusPanel = new UltraStatusPanel();
    Appearance appearance98 = new Appearance();
    this.tabPageClaimant = new UltraTabPageControl();
    this.checkClaimants_MedicareEligible = new MGACheckBox();
    this.textClaimants_Comments = new MGATextBox();
    this.label1 = new Label();
    this.label22 = new Label();
    this.textClaimants_EmailAddress = new MGATextBox();
    this.checkClaimants_Closed = new MGACheckBox();
    this.label20 = new Label();
    this.comboClaimants_Gender = new MGASimpleComboBox();
    this.dateTimeClaimants_DOB = new MGADateTimePicker();
    this.maskedEditClaimants_SSNFEIN = new MGAMaskedEdit();
    this.label19 = new Label();
    this.label18 = new Label();
    this.textClaimants_UserDefinedClaimantsID = new MGATextBox();
    this.label17 = new Label();
    this.label16 = new Label();
    this.addResolverClaimants_Mailing = new AddressResolver_MULTI();
    this.label15 = new Label();
    this.label14 = new Label();
    this.label11 = new Label();
    this.label13 = new Label();
    this.textClaimants_CorporationName = new MGATextBox();
    this.label12 = new Label();
    this.textClaimants_FirstName = new MGATextBox();
    this.textClaimants_MiddleName = new MGATextBox();
    this.textClaimants_LastName = new MGATextBox();
    this.addResolverClaimants_Primary = new AddressResolver_MULTI();
    this.checkClaimants_IsInsured = new MGACheckBox();
    this.optionClaimants_ClaimantType = new UltraOptionSet();
    this.phoneClaimants_Primary = new MgaPhoneNumberEntry();
    this.phoneClaimants_Mailing = new MgaPhoneNumberEntry();
    this.tabPageClaimSpecifications = new UltraTabPageControl();
    this.dateTimeClaimant_DateDenied = new MGADateTimePicker();
    this.label50 = new Label();
    this.gridClaimant_Coverages = new UltraGrid();
    this.dateTimeClaimants_OutsideInvestigatorHireDate = new MGADateTimePicker();
    this.label42 = new Label();
    this.checkClaimants_Settled = new MGACheckBox();
    this.label41 = new Label();
    this.comboClaimants_SettlementType = new MGASimpleComboBox();
    this.textClaimants_OutsideInvestigator = new MGATextBox();
    this.label40 = new Label();
    this.textClaimants_LastModifiedBy = new MGATextBox();
    this.label38 = new Label();
    this.dateTimeClaimants_LastModified = new MGADateTimePicker();
    this.label39 = new Label();
    this.label29 = new Label();
    this.comboClaimants_OutsideAdjuster = new MGASimpleComboBox();
    this.textClaimant_EnteredBy = new MGATextBox();
    this.label27 = new Label();
    this.dateTimeClaimant_DateEntered = new MGADateTimePicker();
    this.label28 = new Label();
    this.label26 = new Label();
    this.comboClaimants_ManagedCare = new MGASimpleComboBox();
    this.label25 = new Label();
    this.comboClaimants_LossType = new MGASimpleComboBox();
    this.label24 = new Label();
    this.comboClaimant_AccidentTypes = new MGASimpleComboBox();
    this.label23 = new Label();
    this.dateTimeClaimant_DateReported = new MGADateTimePicker();
    this.label21 = new Label();
    this.tabPageLegal = new UltraTabPageControl();
    this.cboClaimantAttorney = new MGASimpleComboBox();
    this.cboDefenseAttorney = new MGASimpleComboBox();
    this.optionClaimantAttorneyEntityType = new UltraOptionSet();
    this.optionDefenseEntityType = new UltraOptionSet();
    this.textClaimants_ClaimantAttorneyFEIN = new MGAMaskedEdit();
    this.textClaimants_DefenseFEIN = new MGAMaskedEdit();
    this.label54 = new Label();
    this.label53 = new Label();
    this.textClaimants_DefenseAttorney = new MGATextBox();
    this.label52 = new Label();
    this.checkClaimants_PublishedDecision = new MGACheckBox();
    this.textClaimants_Judge = new MGATextBox();
    this.label49 = new Label();
    this.textClaimants_ClaimantAttorney = new MGATextBox();
    this.textClaimants_ClaimantLawFirm = new MGATextBox();
    this.label47 = new Label();
    this.label48 = new Label();
    this.textClaimants_DefenseFirm = new MGATextBox();
    this.label46 = new Label();
    this.label45 = new Label();
    this.dateTimeClaimants_SuitAnswered = new MGADateTimePicker();
    this.label43 = new Label();
    this.dateTimeClaimants_SuitServed = new MGADateTimePicker();
    this.label44 = new Label();
    this.checkClaimants_SuitServed = new MGACheckBox();
    this.addResolverClaimants_DefenseAttorney = new AddressResolver_MULTI();
    this.phoneClaimants_DefenseAttorney = new MgaPhoneNumberEntry();
    this.addResolverClaimants_ClaimantAttorney = new AddressResolver_MULTI();
    this.phoneClaimants_ClaimantAttorney = new MgaPhoneNumberEntry();
    this.tabPageClaimantReservesPayments = new UltraTabPageControl();
    this.gridClaimants_ReservePayments = new UltraGrid();
    this.dsReservesPayments1 = new dsReservesPayments();
    this.ultraTabPageControl1 = new UltraTabPageControl();
    this.ultraTabPageControlVerisk = new UltraTabPageControl();
    this.Verisk_label5 = new Label();
    this.lnkICD = new LinkLabel();
    this.Verisk_mgaNoFaultPolicyLimit = new MGAMaskedEdit();
    this.Verisk_label13 = new Label();
    this.Verisk_cboRepType = new MGASimpleComboBox();
    this.Verisk_label12 = new Label();
    this.Verisk_dtORMTermination = new MGADateTimePicker();
    this.Verisk_label11 = new Label();
    this.Verisk_cboORMIndicator = new MGASimpleComboBox();
    this.Verisk_label10 = new Label();
    this.Verisk_label9 = new Label();
    this.Verisk_txtApprovalComments = new MGATextBox();
    this.Verisk_label8 = new Label();
    this.Verisk_cboMedicareApproval = new MGASimpleComboBox();
    this.Verisk_label1 = new Label();
    this.Verisk_cboInsuranceType = new MGASimpleComboBox();
    this.Verisk_txtHICNMBI = new MGATextBox();
    this.Verisk_label7 = new Label();
    this.Verisk_label6 = new Label();
    this.Verisk_dtInjuredDeathDate = new MGADateTimePicker();
    this.Verisk_txtICDCode = new MGATextBox();
    this.Verisk_label4 = new Label();
    this.Verisk_label3 = new Label();
    this.Verisk_dtFundingDelayed = new MGADateTimePicker();
    this.Verisk_label2 = new Label();
    this.Verisk_dtExhaustDate = new MGADateTimePicker();
    this.tabControlClaimants = new UltraTabControl();
    this.ultraTabSharedControlsPage2 = new UltraTabSharedControlsPage();
    this.FormClaimant_Fill_Panel = new Panel();
    this._FormClaimant_Toolbars_Dock_Area_Left = new UltraToolbarsDockArea();
    this.ultraToolbarsManager1 = new UltraToolbarsManager(this.components);
    this._FormClaimant_Toolbars_Dock_Area_Right = new UltraToolbarsDockArea();
    this._FormClaimant_Toolbars_Dock_Area_Top = new UltraToolbarsDockArea();
    this._FormClaimant_Toolbars_Dock_Area_Bottom = new UltraToolbarsDockArea();
    this.dsClaimOptions1 = new dsClaimOptions();
    this.ultraToolTipManager1 = new UltraToolTipManager(this.components);
    this.toolTip1 = new ToolTip(this.components);
    this.statusBar1 = new UltraStatusBar();
    ((Control) this.tabPageClaimant).SuspendLayout();
    ((ISupportInitialize) this.checkClaimants_MedicareEligible).BeginInit();
    ((ISupportInitialize) this.textClaimants_Comments).BeginInit();
    ((ISupportInitialize) this.textClaimants_EmailAddress).BeginInit();
    ((ISupportInitialize) this.checkClaimants_Closed).BeginInit();
    ((ISupportInitialize) this.comboClaimants_Gender).BeginInit();
    ((ISupportInitialize) this.dateTimeClaimants_DOB).BeginInit();
    ((ISupportInitialize) this.maskedEditClaimants_SSNFEIN).BeginInit();
    ((ISupportInitialize) this.textClaimants_UserDefinedClaimantsID).BeginInit();
    ((ISupportInitialize) this.textClaimants_CorporationName).BeginInit();
    ((ISupportInitialize) this.textClaimants_FirstName).BeginInit();
    ((ISupportInitialize) this.textClaimants_MiddleName).BeginInit();
    ((ISupportInitialize) this.textClaimants_LastName).BeginInit();
    ((ISupportInitialize) this.checkClaimants_IsInsured).BeginInit();
    ((ISupportInitialize) this.optionClaimants_ClaimantType).BeginInit();
    ((Control) this.tabPageClaimSpecifications).SuspendLayout();
    ((ISupportInitialize) this.dateTimeClaimant_DateDenied).BeginInit();
    ((ISupportInitialize) this.gridClaimant_Coverages).BeginInit();
    ((ISupportInitialize) this.dateTimeClaimants_OutsideInvestigatorHireDate).BeginInit();
    ((ISupportInitialize) this.checkClaimants_Settled).BeginInit();
    ((ISupportInitialize) this.comboClaimants_SettlementType).BeginInit();
    ((ISupportInitialize) this.textClaimants_OutsideInvestigator).BeginInit();
    ((ISupportInitialize) this.textClaimants_LastModifiedBy).BeginInit();
    ((ISupportInitialize) this.dateTimeClaimants_LastModified).BeginInit();
    ((ISupportInitialize) this.comboClaimants_OutsideAdjuster).BeginInit();
    ((ISupportInitialize) this.textClaimant_EnteredBy).BeginInit();
    ((ISupportInitialize) this.dateTimeClaimant_DateEntered).BeginInit();
    ((ISupportInitialize) this.comboClaimants_ManagedCare).BeginInit();
    ((ISupportInitialize) this.comboClaimants_LossType).BeginInit();
    ((ISupportInitialize) this.comboClaimant_AccidentTypes).BeginInit();
    ((ISupportInitialize) this.dateTimeClaimant_DateReported).BeginInit();
    ((Control) this.tabPageLegal).SuspendLayout();
    ((ISupportInitialize) this.cboClaimantAttorney).BeginInit();
    ((ISupportInitialize) this.cboDefenseAttorney).BeginInit();
    ((ISupportInitialize) this.optionClaimantAttorneyEntityType).BeginInit();
    ((ISupportInitialize) this.optionDefenseEntityType).BeginInit();
    ((ISupportInitialize) this.textClaimants_ClaimantAttorneyFEIN).BeginInit();
    ((ISupportInitialize) this.textClaimants_DefenseFEIN).BeginInit();
    ((ISupportInitialize) this.textClaimants_DefenseAttorney).BeginInit();
    ((ISupportInitialize) this.checkClaimants_PublishedDecision).BeginInit();
    ((ISupportInitialize) this.textClaimants_Judge).BeginInit();
    ((ISupportInitialize) this.textClaimants_ClaimantAttorney).BeginInit();
    ((ISupportInitialize) this.textClaimants_ClaimantLawFirm).BeginInit();
    ((ISupportInitialize) this.textClaimants_DefenseFirm).BeginInit();
    ((ISupportInitialize) this.dateTimeClaimants_SuitAnswered).BeginInit();
    ((ISupportInitialize) this.dateTimeClaimants_SuitServed).BeginInit();
    ((ISupportInitialize) this.checkClaimants_SuitServed).BeginInit();
    ((Control) this.tabPageClaimantReservesPayments).SuspendLayout();
    ((ISupportInitialize) this.gridClaimants_ReservePayments).BeginInit();
    this.dsReservesPayments1.BeginInit();
    ((Control) this.ultraTabPageControlVerisk).SuspendLayout();
    ((ISupportInitialize) this.Verisk_mgaNoFaultPolicyLimit).BeginInit();
    ((ISupportInitialize) this.Verisk_cboRepType).BeginInit();
    ((ISupportInitialize) this.Verisk_dtORMTermination).BeginInit();
    ((ISupportInitialize) this.Verisk_cboORMIndicator).BeginInit();
    ((ISupportInitialize) this.Verisk_txtApprovalComments).BeginInit();
    ((ISupportInitialize) this.Verisk_cboMedicareApproval).BeginInit();
    ((ISupportInitialize) this.Verisk_cboInsuranceType).BeginInit();
    ((ISupportInitialize) this.Verisk_txtHICNMBI).BeginInit();
    ((ISupportInitialize) this.Verisk_dtInjuredDeathDate).BeginInit();
    ((ISupportInitialize) this.Verisk_txtICDCode).BeginInit();
    ((ISupportInitialize) this.Verisk_dtFundingDelayed).BeginInit();
    ((ISupportInitialize) this.Verisk_dtExhaustDate).BeginInit();
    ((ISupportInitialize) this.tabControlClaimants).BeginInit();
    ((Control) this.tabControlClaimants).SuspendLayout();
    this.FormClaimant_Fill_Panel.SuspendLayout();
    ((ISupportInitialize) this.ultraToolbarsManager1).BeginInit();
    this.dsClaimOptions1.BeginInit();
    ((ISupportInitialize) this.statusBar1).BeginInit();
    this.SuspendLayout();
    ((Control) this.tabPageClaimant).Controls.Add((Control) this.checkClaimants_MedicareEligible);
    ((Control) this.tabPageClaimant).Controls.Add((Control) this.textClaimants_Comments);
    ((Control) this.tabPageClaimant).Controls.Add((Control) this.label1);
    ((Control) this.tabPageClaimant).Controls.Add((Control) this.label22);
    ((Control) this.tabPageClaimant).Controls.Add((Control) this.textClaimants_EmailAddress);
    ((Control) this.tabPageClaimant).Controls.Add((Control) this.checkClaimants_Closed);
    ((Control) this.tabPageClaimant).Controls.Add((Control) this.label20);
    ((Control) this.tabPageClaimant).Controls.Add((Control) this.comboClaimants_Gender);
    ((Control) this.tabPageClaimant).Controls.Add((Control) this.dateTimeClaimants_DOB);
    ((Control) this.tabPageClaimant).Controls.Add((Control) this.maskedEditClaimants_SSNFEIN);
    ((Control) this.tabPageClaimant).Controls.Add((Control) this.label19);
    ((Control) this.tabPageClaimant).Controls.Add((Control) this.label18);
    ((Control) this.tabPageClaimant).Controls.Add((Control) this.textClaimants_UserDefinedClaimantsID);
    ((Control) this.tabPageClaimant).Controls.Add((Control) this.label17);
    ((Control) this.tabPageClaimant).Controls.Add((Control) this.label16);
    ((Control) this.tabPageClaimant).Controls.Add((Control) this.addResolverClaimants_Mailing);
    ((Control) this.tabPageClaimant).Controls.Add((Control) this.label15);
    ((Control) this.tabPageClaimant).Controls.Add((Control) this.label14);
    ((Control) this.tabPageClaimant).Controls.Add((Control) this.label11);
    ((Control) this.tabPageClaimant).Controls.Add((Control) this.label13);
    ((Control) this.tabPageClaimant).Controls.Add((Control) this.textClaimants_CorporationName);
    ((Control) this.tabPageClaimant).Controls.Add((Control) this.label12);
    ((Control) this.tabPageClaimant).Controls.Add((Control) this.textClaimants_FirstName);
    ((Control) this.tabPageClaimant).Controls.Add((Control) this.textClaimants_MiddleName);
    ((Control) this.tabPageClaimant).Controls.Add((Control) this.textClaimants_LastName);
    ((Control) this.tabPageClaimant).Controls.Add((Control) this.addResolverClaimants_Primary);
    ((Control) this.tabPageClaimant).Controls.Add((Control) this.checkClaimants_IsInsured);
    ((Control) this.tabPageClaimant).Controls.Add((Control) this.optionClaimants_ClaimantType);
    ((Control) this.tabPageClaimant).Controls.Add((Control) this.phoneClaimants_Primary);
    ((Control) this.tabPageClaimant).Controls.Add((Control) this.phoneClaimants_Mailing);
    ((Control) this.tabPageClaimant).Location = new Point(1, 22);
    ((Control) this.tabPageClaimant).Name = "tabPageClaimant";
    ((Control) this.tabPageClaimant).Size = new Size(922, 551);
    ((AppearanceBase) appearance1).BorderColor = Color.Gray;
    ((AppearanceBase) appearance1).ForeColor = Color.Black;
    ((AppearanceBase) appearance1).TextHAlignAsString = "Left";
    ((AppearanceBase) appearance1).TextVAlignAsString = "Top";
    ((UltraToggleEditorBase) this.checkClaimants_MedicareEligible).Appearance = (AppearanceBase) appearance1;
    ((UltraToggleEditorBase) this.checkClaimants_MedicareEligible).CheckAlign = ContentAlignment.TopRight;
    ((UltraToggleEditorBase) this.checkClaimants_MedicareEligible).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.checkClaimants_MedicareEligible).Location = new Point(746, 42);
    ((Control) this.checkClaimants_MedicareEligible).Name = "checkClaimants_MedicareEligible";
    ((Control) this.checkClaimants_MedicareEligible).Size = new Size(142, 24);
    ((Control) this.checkClaimants_MedicareEligible).TabIndex = 28;
    ((Control) this.checkClaimants_MedicareEligible).Text = "Medicare Report Sent";
    ((AppearanceBase) appearance2).BackColor = Color.White;
    ((AppearanceBase) appearance2).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance2).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textClaimants_Comments).Appearance = (AppearanceBase) appearance2;
    ((Control) this.textClaimants_Comments).BackColor = Color.White;
    ((Control) this.textClaimants_Comments).Location = new Point(618, 123);
    ((TextEditorControlBase) this.textClaimants_Comments).MaxLength = 550;
    this.textClaimants_Comments.MGAStyle = (MGAStyles) 2;
    ((UltraTextEditor) this.textClaimants_Comments).Multiline = true;
    ((Control) this.textClaimants_Comments).Name = "textClaimants_Comments";
    ((Control) this.textClaimants_Comments).Size = new Size(267, 78);
    ((Control) this.textClaimants_Comments).TabIndex = 21;
    ((Control) this.textClaimants_Comments).Tag = (object) "Claimant Comments";
    ((UltraControlBase) this.textClaimants_Comments).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textClaimants_Comments).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.textClaimants_Comments).Enter += new EventHandler(this.text_Enter);
    ((Control) this.textClaimants_Comments).Leave += new EventHandler(this.text_Leave);
    this.label1.AutoSize = true;
    this.label1.ForeColor = Color.Black;
    this.label1.Location = new Point(516, 122);
    this.label1.Name = "label1";
    this.label1.Size = new Size(61, 13);
    this.label1.TabIndex = 20;
    this.label1.Text = "Comments:";
    this.label22.AutoSize = true;
    this.label22.ForeColor = Color.Black;
    this.label22.Location = new Point(9, 122);
    this.label22.Name = "label22";
    this.label22.Size = new Size(77, 13);
    this.label22.TabIndex = 10;
    this.label22.Text = "Email Address:";
    ((AppearanceBase) appearance3).BackColor = Color.White;
    ((AppearanceBase) appearance3).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance3).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textClaimants_EmailAddress).Appearance = (AppearanceBase) appearance3;
    ((Control) this.textClaimants_EmailAddress).BackColor = Color.White;
    ((Control) this.textClaimants_EmailAddress).Location = new Point(119, 123);
    this.textClaimants_EmailAddress.MGAStyle = (MGAStyles) 2;
    ((Control) this.textClaimants_EmailAddress).Name = "textClaimants_EmailAddress";
    ((Control) this.textClaimants_EmailAddress).Size = new Size(182, 20);
    ((Control) this.textClaimants_EmailAddress).TabIndex = 11;
    ((Control) this.textClaimants_EmailAddress).Tag = (object) "Email Address";
    ((UltraControlBase) this.textClaimants_EmailAddress).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textClaimants_EmailAddress).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.textClaimants_EmailAddress).Enter += new EventHandler(this.text_Enter);
    ((Control) this.textClaimants_EmailAddress).Leave += new EventHandler(this.text_Leave);
    ((AppearanceBase) appearance4).BorderColor = Color.Gray;
    ((AppearanceBase) appearance4).ForeColor = Color.Black;
    ((AppearanceBase) appearance4).TextHAlignAsString = "Left";
    ((AppearanceBase) appearance4).TextVAlignAsString = "Top";
    ((UltraToggleEditorBase) this.checkClaimants_Closed).Appearance = (AppearanceBase) appearance4;
    ((UltraToggleEditorBase) this.checkClaimants_Closed).CheckAlign = ContentAlignment.TopRight;
    ((Control) this.checkClaimants_Closed).Enabled = false;
    ((UltraToggleEditorBase) this.checkClaimants_Closed).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.checkClaimants_Closed).Location = new Point(819, 21);
    ((Control) this.checkClaimants_Closed).Name = "checkClaimants_Closed";
    ((Control) this.checkClaimants_Closed).Size = new Size(69, 24);
    ((Control) this.checkClaimants_Closed).TabIndex = 26;
    ((Control) this.checkClaimants_Closed).Text = "Closed";
    this.label20.AutoSize = true;
    this.label20.ForeColor = Color.Black;
    this.label20.Location = new Point(516, 76);
    this.label20.Name = "label20";
    this.label20.Size = new Size(46, 13);
    this.label20.TabIndex = 16 /*0x10*/;
    this.label20.Text = "Gender:";
    ((UltraCombo) this.comboClaimants_Gender).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraCombo) this.comboClaimants_Gender).DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboClaimants_Gender).Location = new Point(618, 77);
    this.comboClaimants_Gender.MGAStyle = (MGAStyles) 2;
    ((Control) this.comboClaimants_Gender).Name = "comboClaimants_Gender";
    ((Control) this.comboClaimants_Gender).Size = new Size(92, 21);
    ((Control) this.comboClaimants_Gender).TabIndex = 17;
    ((Control) this.comboClaimants_Gender).Tag = (object) "Gender";
    ((UltraControlBase) this.comboClaimants_Gender).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboClaimants_Gender).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.comboClaimants_Gender).Enter += new EventHandler(this.combo_Enter);
    ((Control) this.comboClaimants_Gender).Leave += new EventHandler(this.combo_Leave);
    ((AppearanceBase) appearance5).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraDateTimeEditor) this.dateTimeClaimants_DOB).Appearance = (AppearanceBase) appearance5;
    ((AppearanceBase) appearance6).AlphaLevel = (short) 14;
    ((AppearanceBase) appearance6).BackColor = Color.FromArgb(0, 0, 246, 253);
    ((AppearanceBase) appearance6).BackColor2 = Color.FromArgb(133, 162, 221);
    ((AppearanceBase) appearance6).BackColorAlpha = (Alpha) 2;
    ((AppearanceBase) appearance6).BackGradientAlignment = (GradientAlignment) 4;
    ((AppearanceBase) appearance6).BackGradientStyle = (GradientStyle) 5;
    ((AppearanceBase) appearance6).BorderAlpha = (Alpha) 1;
    ((AppearanceBase) appearance6).BorderColor = Color.FromArgb(78, 122, 171);
    ((AppearanceBase) appearance6).ForeColor = Color.FromArgb(49, 85, 153);
    ((AppearanceBase) appearance6).ForegroundAlpha = (Alpha) 2;
    ((UltraDateTimeEditor) this.dateTimeClaimants_DOB).ButtonAppearance = (AppearanceBase) appearance6;
    ((UltraDateTimeEditor) this.dateTimeClaimants_DOB).DateTime = new DateTime(2018, 7, 11, 0, 0, 0, 0);
    ((Control) this.dateTimeClaimants_DOB).Location = new Point(618, 55);
    this.dateTimeClaimants_DOB.MGAStyle = (MGAStyles) 2;
    ((Control) this.dateTimeClaimants_DOB).Name = "dateTimeClaimants_DOB";
    ((Control) this.dateTimeClaimants_DOB).Size = new Size(92, 20);
    ((Control) this.dateTimeClaimants_DOB).TabIndex = 15;
    ((Control) this.dateTimeClaimants_DOB).Tag = (object) "Date Of Birth";
    ((UltraControlBase) this.dateTimeClaimants_DOB).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dateTimeClaimants_DOB).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDateTimeEditor) this.dateTimeClaimants_DOB).Value = (object) new DateTime(2018, 7, 11, 0, 0, 0, 0);
    ((UltraDateTimeEditor) this.dateTimeClaimants_DOB).ValueChanged += new EventHandler(this.dateTimePicker_ValueChanged);
    ((AppearanceBase) appearance7).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraMaskedEdit) this.maskedEditClaimants_SSNFEIN).Appearance = (AppearanceBase) appearance7;
    ((UltraMaskedEdit) this.maskedEditClaimants_SSNFEIN).ClipMode = (MaskMode) 0;
    ((UltraMaskedEdit) this.maskedEditClaimants_SSNFEIN).DataMode = (MaskMode) 0;
    ((UltraMaskedEdit) this.maskedEditClaimants_SSNFEIN).EditAs = (EditAsType) 1;
    ((UltraMaskedEdit) this.maskedEditClaimants_SSNFEIN).InputMask = "999-99-9999";
    ((Control) this.maskedEditClaimants_SSNFEIN).Location = new Point(618, 31 /*0x1F*/);
    this.maskedEditClaimants_SSNFEIN.MGAStyle = (MGAStyles) 2;
    ((Control) this.maskedEditClaimants_SSNFEIN).Name = "maskedEditClaimants_SSNFEIN";
    ((UltraMaskedEdit) this.maskedEditClaimants_SSNFEIN).NonAutoSizeHeight = 20;
    ((Control) this.maskedEditClaimants_SSNFEIN).Size = new Size(76, 21);
    ((Control) this.maskedEditClaimants_SSNFEIN).TabIndex = 13;
    ((Control) this.maskedEditClaimants_SSNFEIN).Tag = (object) "SSN/FEIN";
    ((UltraControlBase) this.maskedEditClaimants_SSNFEIN).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.maskedEditClaimants_SSNFEIN).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraMaskedEdit) this.maskedEditClaimants_SSNFEIN).ValueChanged += new EventHandler(this.maskedEditClaimants_SSNFEIN_ValueChanged);
    this.label19.AutoSize = true;
    this.label19.ForeColor = Color.Black;
    this.label19.Location = new Point(516, 98);
    this.label19.Name = "label19";
    this.label19.Size = new Size(90, 13);
    this.label19.TabIndex = 18;
    this.label19.Text = "Claimant Id (UD):";
    this.label18.AutoSize = true;
    this.label18.ForeColor = Color.Black;
    this.label18.Location = new Point(516, 53);
    this.label18.Name = "label18";
    this.label18.Size = new Size(32 /*0x20*/, 13);
    this.label18.TabIndex = 14;
    this.label18.Text = "DOB:";
    ((AppearanceBase) appearance8).BackColor = Color.White;
    ((AppearanceBase) appearance8).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance8).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textClaimants_UserDefinedClaimantsID).Appearance = (AppearanceBase) appearance8;
    ((Control) this.textClaimants_UserDefinedClaimantsID).BackColor = Color.White;
    ((Control) this.textClaimants_UserDefinedClaimantsID).Location = new Point(618, 100);
    this.textClaimants_UserDefinedClaimantsID.MGAStyle = (MGAStyles) 2;
    ((Control) this.textClaimants_UserDefinedClaimantsID).Name = "textClaimants_UserDefinedClaimantsID";
    ((Control) this.textClaimants_UserDefinedClaimantsID).Size = new Size(267, 20);
    ((Control) this.textClaimants_UserDefinedClaimantsID).TabIndex = 19;
    ((Control) this.textClaimants_UserDefinedClaimantsID).Tag = (object) "User-Defined Claimant Id";
    ((UltraControlBase) this.textClaimants_UserDefinedClaimantsID).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textClaimants_UserDefinedClaimantsID).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.textClaimants_UserDefinedClaimantsID).Enter += new EventHandler(this.text_Enter);
    ((Control) this.textClaimants_UserDefinedClaimantsID).Leave += new EventHandler(this.text_Leave);
    this.label17.AutoSize = true;
    this.label17.ForeColor = Color.Black;
    this.label17.Location = new Point(516, 32 /*0x20*/);
    this.label17.Name = "label17";
    this.label17.Size = new Size(57, 13);
    this.label17.TabIndex = 12;
    this.label17.Text = "SSN/FEIN:";
    this.label16.AutoSize = true;
    this.label16.Font = new Font("Tahoma", 8.25f, FontStyle.Bold | FontStyle.Underline);
    this.label16.ForeColor = Color.Black;
    this.label16.Location = new Point(517, 209);
    this.label16.Name = "label16";
    this.label16.Size = new Size(96 /*0x60*/, 13);
    this.label16.TabIndex = 25;
    this.label16.Text = "Mailing Address";
    this.addResolverClaimants_Mailing.Address1 = "";
    this.addResolverClaimants_Mailing.Address2 = "";
    ((Control) this.addResolverClaimants_Mailing).BackColor = Color.Transparent;
    this.addResolverClaimants_Mailing.City = "";
    this.addResolverClaimants_Mailing.County = "";
    ((Control) this.addResolverClaimants_Mailing).Font = new Font("Tahoma", 8f);
    ((Control) this.addResolverClaimants_Mailing).ForeColor = Color.Black;
    this.addResolverClaimants_Mailing.ISOCountryCode = "";
    this.addResolverClaimants_Mailing.ISOCountryCodeMember = "";
    this.addResolverClaimants_Mailing.ISOCountryList = (object) null;
    this.addResolverClaimants_Mailing.ISOCountryNameMember = "";
    ((Control) this.addResolverClaimants_Mailing).Location = new Point(508, 219);
    this.addResolverClaimants_Mailing.MGAStyle = (MGAStyles) 2;
    ((Control) this.addResolverClaimants_Mailing).Name = "addResolverClaimants_Mailing";
    this.addResolverClaimants_Mailing.Password = (string) null;
    ((Control) this.addResolverClaimants_Mailing).Size = new Size(288, 152);
    this.addResolverClaimants_Mailing.State = "";
    ((Control) this.addResolverClaimants_Mailing).TabIndex = 26;
    ((Control) this.addResolverClaimants_Mailing).Tag = (object) "Claimant Mailing Address";
    this.addResolverClaimants_Mailing.TextAlign = ContentAlignment.TopLeft;
    this.addResolverClaimants_Mailing.UserID = (string) null;
    this.addResolverClaimants_Mailing.WebserviceUrl = (string) null;
    this.addResolverClaimants_Mailing.ZipCode = "";
    this.addResolverClaimants_Mailing.ZipCodeExtension = "";
    this.addResolverClaimants_Mailing.ZipCodeChanged += new EventHandler(this.addResolverClaimants_Mailing_ZipCodeChanged);
    ((Control) this.addResolverClaimants_Mailing).Enter += new EventHandler(this.addResolver_Enter);
    ((Control) this.addResolverClaimants_Mailing).Leave += new EventHandler(this.addResolver_Leave);
    this.label15.AutoSize = true;
    this.label15.Font = new Font("Tahoma", 8.25f, FontStyle.Bold | FontStyle.Underline);
    this.label15.ForeColor = Color.Black;
    this.label15.Location = new Point(10, 209);
    this.label15.Name = "label15";
    this.label15.Size = new Size(101, 13);
    this.label15.TabIndex = 22;
    this.label15.Text = "Primary Address";
    this.label14.AutoSize = true;
    this.label14.ForeColor = Color.Black;
    this.label14.Location = new Point(9, 99);
    this.label14.Name = "label14";
    this.label14.Size = new Size(61, 13);
    this.label14.TabIndex = 8;
    this.label14.Text = "Last Name:";
    this.label11.AutoSize = true;
    this.label11.ForeColor = Color.Black;
    this.label11.Location = new Point(9, 32 /*0x20*/);
    this.label11.Name = "label11";
    this.label11.Size = new Size(98, 13);
    this.label11.TabIndex = 2;
    this.label11.Text = "Corporation Name:";
    this.label13.AutoSize = true;
    this.label13.ForeColor = Color.Black;
    this.label13.Location = new Point(9, 77);
    this.label13.Name = "label13";
    this.label13.Size = new Size(71, 13);
    this.label13.TabIndex = 6;
    this.label13.Text = "Middle Name:";
    ((AppearanceBase) appearance9).BackColor = Color.White;
    ((AppearanceBase) appearance9).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance9).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textClaimants_CorporationName).Appearance = (AppearanceBase) appearance9;
    ((Control) this.textClaimants_CorporationName).BackColor = Color.White;
    ((Control) this.textClaimants_CorporationName).Enabled = false;
    ((Control) this.textClaimants_CorporationName).Location = new Point(119, 31 /*0x1F*/);
    this.textClaimants_CorporationName.MGAStyle = (MGAStyles) 2;
    ((Control) this.textClaimants_CorporationName).Name = "textClaimants_CorporationName";
    ((Control) this.textClaimants_CorporationName).Size = new Size(242, 20);
    ((Control) this.textClaimants_CorporationName).TabIndex = 3;
    ((Control) this.textClaimants_CorporationName).Tag = (object) "Corporation Name";
    ((UltraControlBase) this.textClaimants_CorporationName).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textClaimants_CorporationName).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.textClaimants_CorporationName).Enter += new EventHandler(this.text_Enter);
    ((Control) this.textClaimants_CorporationName).Leave += new EventHandler(this.text_Leave);
    this.label12.AutoSize = true;
    this.label12.ForeColor = Color.Black;
    this.label12.Location = new Point(9, 54);
    this.label12.Name = "label12";
    this.label12.Size = new Size(62, 13);
    this.label12.TabIndex = 4;
    this.label12.Text = "First Name:";
    ((AppearanceBase) appearance10).BackColor = Color.White;
    ((AppearanceBase) appearance10).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance10).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textClaimants_FirstName).Appearance = (AppearanceBase) appearance10;
    ((Control) this.textClaimants_FirstName).BackColor = Color.White;
    ((Control) this.textClaimants_FirstName).Location = new Point(119, 54);
    this.textClaimants_FirstName.MGAStyle = (MGAStyles) 2;
    ((Control) this.textClaimants_FirstName).Name = "textClaimants_FirstName";
    ((Control) this.textClaimants_FirstName).Size = new Size(182, 20);
    ((Control) this.textClaimants_FirstName).TabIndex = 5;
    ((Control) this.textClaimants_FirstName).Tag = (object) "First Name";
    ((UltraControlBase) this.textClaimants_FirstName).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textClaimants_FirstName).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.textClaimants_FirstName).Enter += new EventHandler(this.text_Enter);
    ((Control) this.textClaimants_FirstName).Leave += new EventHandler(this.text_Leave);
    ((AppearanceBase) appearance11).BackColor = Color.White;
    ((AppearanceBase) appearance11).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance11).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textClaimants_MiddleName).Appearance = (AppearanceBase) appearance11;
    ((Control) this.textClaimants_MiddleName).BackColor = Color.White;
    ((Control) this.textClaimants_MiddleName).Location = new Point(119, 77);
    this.textClaimants_MiddleName.MGAStyle = (MGAStyles) 2;
    ((Control) this.textClaimants_MiddleName).Name = "textClaimants_MiddleName";
    ((Control) this.textClaimants_MiddleName).Size = new Size(182, 20);
    ((Control) this.textClaimants_MiddleName).TabIndex = 7;
    ((Control) this.textClaimants_MiddleName).Tag = (object) "Middle Name";
    ((UltraControlBase) this.textClaimants_MiddleName).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textClaimants_MiddleName).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.textClaimants_MiddleName).Enter += new EventHandler(this.text_Enter);
    ((Control) this.textClaimants_MiddleName).Leave += new EventHandler(this.text_Leave);
    ((AppearanceBase) appearance12).BackColor = Color.White;
    ((AppearanceBase) appearance12).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance12).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textClaimants_LastName).Appearance = (AppearanceBase) appearance12;
    ((Control) this.textClaimants_LastName).BackColor = Color.White;
    ((Control) this.textClaimants_LastName).Location = new Point(119, 100);
    this.textClaimants_LastName.MGAStyle = (MGAStyles) 2;
    ((Control) this.textClaimants_LastName).Name = "textClaimants_LastName";
    ((Control) this.textClaimants_LastName).Size = new Size(182, 20);
    ((Control) this.textClaimants_LastName).TabIndex = 9;
    ((Control) this.textClaimants_LastName).Tag = (object) "Last Name";
    ((UltraControlBase) this.textClaimants_LastName).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textClaimants_LastName).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.textClaimants_LastName).Enter += new EventHandler(this.text_Enter);
    ((Control) this.textClaimants_LastName).Leave += new EventHandler(this.text_Leave);
    this.addResolverClaimants_Primary.Address1 = "";
    this.addResolverClaimants_Primary.Address2 = "";
    ((Control) this.addResolverClaimants_Primary).BackColor = Color.Transparent;
    this.addResolverClaimants_Primary.City = "";
    this.addResolverClaimants_Primary.County = "";
    ((Control) this.addResolverClaimants_Primary).Font = new Font("Tahoma", 8f);
    ((Control) this.addResolverClaimants_Primary).ForeColor = Color.Black;
    this.addResolverClaimants_Primary.ISOCountryCode = "";
    this.addResolverClaimants_Primary.ISOCountryCodeMember = "";
    this.addResolverClaimants_Primary.ISOCountryList = (object) null;
    this.addResolverClaimants_Primary.ISOCountryNameMember = "";
    ((Control) this.addResolverClaimants_Primary).Location = new Point(3, 219);
    this.addResolverClaimants_Primary.MGAStyle = (MGAStyles) 2;
    ((Control) this.addResolverClaimants_Primary).Name = "addResolverClaimants_Primary";
    this.addResolverClaimants_Primary.Password = (string) null;
    ((Control) this.addResolverClaimants_Primary).Size = new Size(293, 152);
    this.addResolverClaimants_Primary.State = "";
    ((Control) this.addResolverClaimants_Primary).TabIndex = 23;
    ((Control) this.addResolverClaimants_Primary).Tag = (object) "Claimant Primary Address";
    this.addResolverClaimants_Primary.TextAlign = ContentAlignment.TopLeft;
    this.addResolverClaimants_Primary.UserID = (string) null;
    this.addResolverClaimants_Primary.WebserviceUrl = (string) null;
    this.addResolverClaimants_Primary.ZipCode = "";
    this.addResolverClaimants_Primary.ZipCodeExtension = "";
    this.addResolverClaimants_Primary.ZipCodeChanged += new EventHandler(this.addResolverClaimants_Primary_ZipCodeChanged);
    ((Control) this.addResolverClaimants_Primary).Enter += new EventHandler(this.addResolver_Enter);
    ((Control) this.addResolverClaimants_Primary).Leave += new EventHandler(this.addResolver_Leave);
    ((AppearanceBase) appearance13).BorderColor = Color.Gray;
    ((AppearanceBase) appearance13).ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.checkClaimants_IsInsured).Appearance = (AppearanceBase) appearance13;
    ((UltraToggleEditorBase) this.checkClaimants_IsInsured).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.checkClaimants_IsInsured).Location = new Point(120, 12);
    ((Control) this.checkClaimants_IsInsured).Name = "checkClaimants_IsInsured";
    ((Control) this.checkClaimants_IsInsured).Size = new Size(74, 20);
    ((Control) this.checkClaimants_IsInsured).TabIndex = 0;
    ((Control) this.checkClaimants_IsInsured).Text = "Insured";
    ((UltraToggleEditorBase) this.checkClaimants_IsInsured).CheckedChanged += new EventHandler(this.checkClaimantsIsInsured_CheckChanged);
    this.optionClaimants_ClaimantType.BorderStyle = (UIElementBorderStyle) 1;
    this.optionClaimants_ClaimantType.CheckedIndex = 0;
    this.optionClaimants_ClaimantType.GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007RadioButtonGlyphInfo;
    valueListItem1.DataValue = (object) "I";
    valueListItem1.DisplayText = "Individual";
    valueListItem2.DataValue = (object) "C";
    valueListItem2.DisplayText = "Corporation";
    this.optionClaimants_ClaimantType.Items.AddRange(new ValueListItem[2]
    {
      valueListItem1,
      valueListItem2
    });
    ((Control) this.optionClaimants_ClaimantType).Location = new Point(200, 14);
    ((Control) this.optionClaimants_ClaimantType).Name = "optionClaimants_ClaimantType";
    ((Control) this.optionClaimants_ClaimantType).Size = new Size(158, 17);
    ((Control) this.optionClaimants_ClaimantType).TabIndex = 1;
    ((Control) this.optionClaimants_ClaimantType).Text = "Individual";
    ((UltraControlBase) this.optionClaimants_ClaimantType).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.optionClaimants_ClaimantType).UseOsThemes = (DefaultableBoolean) 2;
    this.optionClaimants_ClaimantType.ValueChanged += new EventHandler(this.optionClaimants_ClaimantType_ValueChanged);
    this.phoneClaimants_Primary.BackColor = Color.Transparent;
    this.phoneClaimants_Primary.Font = new Font("Tahoma", 8.25f);
    this.phoneClaimants_Primary.Location = new Point(8, 364);
    this.phoneClaimants_Primary.Name = "phoneClaimants_Primary";
    this.phoneClaimants_Primary.Size = new Size(378, 154);
    this.phoneClaimants_Primary.TabIndex = 24;
    this.phoneClaimants_Mailing.BackColor = Color.Transparent;
    this.phoneClaimants_Mailing.Font = new Font("Tahoma", 8.25f);
    this.phoneClaimants_Mailing.Location = new Point(513, 364);
    this.phoneClaimants_Mailing.Name = "phoneClaimants_Mailing";
    this.phoneClaimants_Mailing.Size = new Size(373, 154);
    this.phoneClaimants_Mailing.TabIndex = 27;
    ((Control) this.tabPageClaimSpecifications).Controls.Add((Control) this.dateTimeClaimant_DateDenied);
    ((Control) this.tabPageClaimSpecifications).Controls.Add((Control) this.label50);
    ((Control) this.tabPageClaimSpecifications).Controls.Add((Control) this.gridClaimant_Coverages);
    ((Control) this.tabPageClaimSpecifications).Controls.Add((Control) this.dateTimeClaimants_OutsideInvestigatorHireDate);
    ((Control) this.tabPageClaimSpecifications).Controls.Add((Control) this.label42);
    ((Control) this.tabPageClaimSpecifications).Controls.Add((Control) this.checkClaimants_Settled);
    ((Control) this.tabPageClaimSpecifications).Controls.Add((Control) this.label41);
    ((Control) this.tabPageClaimSpecifications).Controls.Add((Control) this.comboClaimants_SettlementType);
    ((Control) this.tabPageClaimSpecifications).Controls.Add((Control) this.textClaimants_OutsideInvestigator);
    ((Control) this.tabPageClaimSpecifications).Controls.Add((Control) this.label40);
    ((Control) this.tabPageClaimSpecifications).Controls.Add((Control) this.textClaimants_LastModifiedBy);
    ((Control) this.tabPageClaimSpecifications).Controls.Add((Control) this.label38);
    ((Control) this.tabPageClaimSpecifications).Controls.Add((Control) this.dateTimeClaimants_LastModified);
    ((Control) this.tabPageClaimSpecifications).Controls.Add((Control) this.label39);
    ((Control) this.tabPageClaimSpecifications).Controls.Add((Control) this.label29);
    ((Control) this.tabPageClaimSpecifications).Controls.Add((Control) this.comboClaimants_OutsideAdjuster);
    ((Control) this.tabPageClaimSpecifications).Controls.Add((Control) this.textClaimant_EnteredBy);
    ((Control) this.tabPageClaimSpecifications).Controls.Add((Control) this.label27);
    ((Control) this.tabPageClaimSpecifications).Controls.Add((Control) this.dateTimeClaimant_DateEntered);
    ((Control) this.tabPageClaimSpecifications).Controls.Add((Control) this.label28);
    ((Control) this.tabPageClaimSpecifications).Controls.Add((Control) this.label26);
    ((Control) this.tabPageClaimSpecifications).Controls.Add((Control) this.comboClaimants_ManagedCare);
    ((Control) this.tabPageClaimSpecifications).Controls.Add((Control) this.label25);
    ((Control) this.tabPageClaimSpecifications).Controls.Add((Control) this.comboClaimants_LossType);
    ((Control) this.tabPageClaimSpecifications).Controls.Add((Control) this.label24);
    ((Control) this.tabPageClaimSpecifications).Controls.Add((Control) this.comboClaimant_AccidentTypes);
    ((Control) this.tabPageClaimSpecifications).Controls.Add((Control) this.label23);
    ((Control) this.tabPageClaimSpecifications).Controls.Add((Control) this.dateTimeClaimant_DateReported);
    ((Control) this.tabPageClaimSpecifications).Controls.Add((Control) this.label21);
    ((Control) this.tabPageClaimSpecifications).Location = new Point(-10000, -10000);
    ((Control) this.tabPageClaimSpecifications).Name = "tabPageClaimSpecifications";
    ((Control) this.tabPageClaimSpecifications).Size = new Size(922, 551);
    ((AppearanceBase) appearance14).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraDateTimeEditor) this.dateTimeClaimant_DateDenied).Appearance = (AppearanceBase) appearance14;
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
    ((UltraDateTimeEditor) this.dateTimeClaimant_DateDenied).ButtonAppearance = (AppearanceBase) appearance15;
    ((UltraDateTimeEditor) this.dateTimeClaimant_DateDenied).DateTime = new DateTime(2010, 6, 10, 0, 0, 0, 0);
    ((Control) this.dateTimeClaimant_DateDenied).Location = new Point(566, 119);
    this.dateTimeClaimant_DateDenied.MGAStyle = (MGAStyles) 2;
    ((Control) this.dateTimeClaimant_DateDenied).Name = "dateTimeClaimant_DateDenied";
    ((Control) this.dateTimeClaimant_DateDenied).Size = new Size(92, 20);
    ((Control) this.dateTimeClaimant_DateDenied).TabIndex = 24;
    ((Control) this.dateTimeClaimant_DateDenied).Tag = (object) "Date Denied";
    ((UltraControlBase) this.dateTimeClaimant_DateDenied).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dateTimeClaimant_DateDenied).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDateTimeEditor) this.dateTimeClaimant_DateDenied).Value = (object) new DateTime(2010, 6, 10, 0, 0, 0, 0);
    this.label50.AutoSize = true;
    this.label50.BackColor = Color.Transparent;
    this.label50.ForeColor = Color.Black;
    this.label50.Location = new Point(470, 119);
    this.label50.Name = "label50";
    this.label50.Size = new Size(70, 13);
    this.label50.TabIndex = 23;
    this.label50.Text = "Date Denied:";
    ((AppearanceBase) appearance16).BackColor = Color.White;
    ((AppearanceBase) appearance16).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridClaimant_Coverages).DisplayLayout.Appearance = (AppearanceBase) appearance16;
    ((UltraGridBase) this.gridClaimant_Coverages).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((UltraGridBase) this.gridClaimant_Coverages).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance17).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance17).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance17).ForeColor = Color.Black;
    ((UltraGridBase) this.gridClaimant_Coverages).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance17;
    ((UltraGridBase) this.gridClaimant_Coverages).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridClaimant_Coverages).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridClaimant_Coverages).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance18).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridClaimant_Coverages).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance18;
    ((UltraGridBase) this.gridClaimant_Coverages).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance19).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.gridClaimant_Coverages).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance19;
    ((UltraGridBase) this.gridClaimant_Coverages).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance20).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridClaimant_Coverages).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance20;
    ((AppearanceBase) appearance21).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridClaimant_Coverages).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance21;
    ((UltraGridBase) this.gridClaimant_Coverages).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance22).BackColor = Color.Transparent;
    ((AppearanceBase) appearance22).ForeColor = Color.Black;
    ((UltraGridBase) this.gridClaimant_Coverages).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance22;
    ((AppearanceBase) appearance23).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance23).BorderColor = Color.Silver;
    scrollBarLook1.ButtonAppearance = (AppearanceBase) appearance23;
    ((AppearanceBase) appearance24).BackColor = Color.White;
    scrollBarLook1.TrackAppearance = (AppearanceBase) appearance24;
    ((UltraGridBase) this.gridClaimant_Coverages).DisplayLayout.ScrollBarLook = scrollBarLook1;
    ((Control) this.gridClaimant_Coverages).Location = new Point(139, 41);
    ((Control) this.gridClaimant_Coverages).Name = "gridClaimant_Coverages";
    ((Control) this.gridClaimant_Coverages).Size = new Size(297, 117);
    ((Control) this.gridClaimant_Coverages).TabIndex = 1;
    ((UltraControlBase) this.gridClaimant_Coverages).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridClaimant_Coverages).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance25).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraDateTimeEditor) this.dateTimeClaimants_OutsideInvestigatorHireDate).Appearance = (AppearanceBase) appearance25;
    ((AppearanceBase) appearance26).AlphaLevel = (short) 14;
    ((AppearanceBase) appearance26).BackColor = Color.FromArgb(0, 0, 246, 253);
    ((AppearanceBase) appearance26).BackColor2 = Color.FromArgb(133, 162, 221);
    ((AppearanceBase) appearance26).BackColorAlpha = (Alpha) 2;
    ((AppearanceBase) appearance26).BackGradientAlignment = (GradientAlignment) 4;
    ((AppearanceBase) appearance26).BackGradientStyle = (GradientStyle) 5;
    ((AppearanceBase) appearance26).BorderAlpha = (Alpha) 1;
    ((AppearanceBase) appearance26).BorderColor = Color.FromArgb(78, 122, 171);
    ((AppearanceBase) appearance26).ForeColor = Color.FromArgb(49, 85, 153);
    ((AppearanceBase) appearance26).ForegroundAlpha = (Alpha) 2;
    ((UltraDateTimeEditor) this.dateTimeClaimants_OutsideInvestigatorHireDate).ButtonAppearance = (AppearanceBase) appearance26;
    ((UltraDateTimeEditor) this.dateTimeClaimants_OutsideInvestigatorHireDate).DateTime = new DateTime(2010, 6, 10, 0, 0, 0, 0);
    ((Control) this.dateTimeClaimants_OutsideInvestigatorHireDate).Location = new Point(139, 295);
    this.dateTimeClaimants_OutsideInvestigatorHireDate.MGAStyle = (MGAStyles) 2;
    ((Control) this.dateTimeClaimants_OutsideInvestigatorHireDate).Name = "dateTimeClaimants_OutsideInvestigatorHireDate";
    ((Control) this.dateTimeClaimants_OutsideInvestigatorHireDate).Size = new Size(92, 20);
    ((Control) this.dateTimeClaimants_OutsideInvestigatorHireDate).TabIndex = 13;
    ((Control) this.dateTimeClaimants_OutsideInvestigatorHireDate).Tag = (object) "Investigator Hire Date";
    ((UltraControlBase) this.dateTimeClaimants_OutsideInvestigatorHireDate).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dateTimeClaimants_OutsideInvestigatorHireDate).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDateTimeEditor) this.dateTimeClaimants_OutsideInvestigatorHireDate).Value = (object) new DateTime(2010, 6, 10, 0, 0, 0, 0);
    ((UltraDateTimeEditor) this.dateTimeClaimants_OutsideInvestigatorHireDate).ValueChanged += new EventHandler(this.dateTimePicker_ValueChanged);
    this.label42.AutoSize = true;
    this.label42.BackColor = Color.Transparent;
    this.label42.ForeColor = Color.Black;
    this.label42.Location = new Point(20, 295);
    this.label42.Name = "label42";
    this.label42.Size = new Size(115, 13);
    this.label42.TabIndex = 12;
    this.label42.Text = "Investigator Hired On:";
    ((AppearanceBase) appearance27).BorderColor = Color.Gray;
    ((AppearanceBase) appearance27).ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.checkClaimants_Settled).Appearance = (AppearanceBase) appearance27;
    ((Control) this.checkClaimants_Settled).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.checkClaimants_Settled).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.checkClaimants_Settled).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.checkClaimants_Settled).Location = new Point(139, 321);
    ((Control) this.checkClaimants_Settled).Name = "checkClaimants_Settled";
    ((Control) this.checkClaimants_Settled).Size = new Size(120, 20);
    ((Control) this.checkClaimants_Settled).TabIndex = 14;
    ((Control) this.checkClaimants_Settled).Text = "Settled";
    this.label41.AutoSize = true;
    this.label41.BackColor = Color.Transparent;
    this.label41.ForeColor = Color.Black;
    this.label41.Location = new Point(20, 343);
    this.label41.Name = "label41";
    this.label41.Size = new Size(90, 13);
    this.label41.TabIndex = 15;
    this.label41.Text = "Settlement Type:";
    ((UltraCombo) this.comboClaimants_SettlementType).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraCombo) this.comboClaimants_SettlementType).DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboClaimants_SettlementType).Location = new Point(139, 343);
    this.comboClaimants_SettlementType.MGAStyle = (MGAStyles) 2;
    ((Control) this.comboClaimants_SettlementType).Name = "comboClaimants_SettlementType";
    ((Control) this.comboClaimants_SettlementType).Size = new Size(181, 21);
    ((Control) this.comboClaimants_SettlementType).TabIndex = 16 /*0x10*/;
    ((Control) this.comboClaimants_SettlementType).Tag = (object) "Settlement Type";
    ((UltraControlBase) this.comboClaimants_SettlementType).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboClaimants_SettlementType).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.comboClaimants_SettlementType).Enter += new EventHandler(this.combo_Enter);
    ((Control) this.comboClaimants_SettlementType).Leave += new EventHandler(this.combo_Leave);
    ((AppearanceBase) appearance28).BackColor = Color.White;
    ((AppearanceBase) appearance28).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance28).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textClaimants_OutsideInvestigator).Appearance = (AppearanceBase) appearance28;
    ((Control) this.textClaimants_OutsideInvestigator).BackColor = Color.White;
    ((Control) this.textClaimants_OutsideInvestigator).Location = new Point(139, 271);
    this.textClaimants_OutsideInvestigator.MGAStyle = (MGAStyles) 2;
    ((Control) this.textClaimants_OutsideInvestigator).Name = "textClaimants_OutsideInvestigator";
    ((Control) this.textClaimants_OutsideInvestigator).Size = new Size(297, 20);
    ((Control) this.textClaimants_OutsideInvestigator).TabIndex = 11;
    ((UltraControlBase) this.textClaimants_OutsideInvestigator).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textClaimants_OutsideInvestigator).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.textClaimants_OutsideInvestigator).Enter += new EventHandler(this.text_Enter);
    ((Control) this.textClaimants_OutsideInvestigator).Leave += new EventHandler(this.text_Leave);
    this.label40.AutoSize = true;
    this.label40.BackColor = Color.Transparent;
    this.label40.ForeColor = Color.Black;
    this.label40.Location = new Point(20, 271);
    this.label40.Name = "label40";
    this.label40.Size = new Size(110, 13);
    this.label40.TabIndex = 10;
    this.label40.Text = "Outside Investigator:";
    ((AppearanceBase) appearance29).BackColor = Color.White;
    ((AppearanceBase) appearance29).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance29).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textClaimants_LastModifiedBy).Appearance = (AppearanceBase) appearance29;
    ((Control) this.textClaimants_LastModifiedBy).BackColor = Color.White;
    ((Control) this.textClaimants_LastModifiedBy).Enabled = false;
    ((Control) this.textClaimants_LastModifiedBy).Location = new Point(566, 172);
    this.textClaimants_LastModifiedBy.MGAStyle = (MGAStyles) 2;
    ((Control) this.textClaimants_LastModifiedBy).Name = "textClaimants_LastModifiedBy";
    ((Control) this.textClaimants_LastModifiedBy).Size = new Size(185, 20);
    ((Control) this.textClaimants_LastModifiedBy).TabIndex = 28;
    ((UltraControlBase) this.textClaimants_LastModifiedBy).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textClaimants_LastModifiedBy).UseOsThemes = (DefaultableBoolean) 2;
    this.label38.AutoSize = true;
    this.label38.BackColor = Color.Transparent;
    this.label38.ForeColor = Color.Black;
    this.label38.Location = new Point(470, 172);
    this.label38.Name = "label38";
    this.label38.Size = new Size(66, 13);
    this.label38.TabIndex = 27;
    this.label38.Text = "Modified By:";
    ((AppearanceBase) appearance30).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraDateTimeEditor) this.dateTimeClaimants_LastModified).Appearance = (AppearanceBase) appearance30;
    ((AppearanceBase) appearance31).AlphaLevel = (short) 14;
    ((AppearanceBase) appearance31).BackColor = Color.FromArgb(0, 0, 246, 253);
    ((AppearanceBase) appearance31).BackColor2 = Color.FromArgb(133, 162, 221);
    ((AppearanceBase) appearance31).BackColorAlpha = (Alpha) 2;
    ((AppearanceBase) appearance31).BackGradientAlignment = (GradientAlignment) 4;
    ((AppearanceBase) appearance31).BackGradientStyle = (GradientStyle) 5;
    ((AppearanceBase) appearance31).BorderAlpha = (Alpha) 1;
    ((AppearanceBase) appearance31).BorderColor = Color.FromArgb(78, 122, 171);
    ((AppearanceBase) appearance31).ForeColor = Color.FromArgb(49, 85, 153);
    ((AppearanceBase) appearance31).ForegroundAlpha = (Alpha) 2;
    ((UltraDateTimeEditor) this.dateTimeClaimants_LastModified).ButtonAppearance = (AppearanceBase) appearance31;
    ((UltraDateTimeEditor) this.dateTimeClaimants_LastModified).DateTime = new DateTime(2010, 6, 10, 0, 0, 0, 0);
    ((Control) this.dateTimeClaimants_LastModified).Enabled = false;
    ((Control) this.dateTimeClaimants_LastModified).Location = new Point(566, 146);
    this.dateTimeClaimants_LastModified.MGAStyle = (MGAStyles) 2;
    ((Control) this.dateTimeClaimants_LastModified).Name = "dateTimeClaimants_LastModified";
    ((Control) this.dateTimeClaimants_LastModified).Size = new Size(92, 20);
    ((Control) this.dateTimeClaimants_LastModified).TabIndex = 26;
    ((UltraControlBase) this.dateTimeClaimants_LastModified).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dateTimeClaimants_LastModified).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDateTimeEditor) this.dateTimeClaimants_LastModified).Value = (object) new DateTime(2010, 6, 10, 0, 0, 0, 0);
    this.label39.AutoSize = true;
    this.label39.BackColor = Color.Transparent;
    this.label39.ForeColor = Color.Black;
    this.label39.Location = new Point(470, 145);
    this.label39.Name = "label39";
    this.label39.Size = new Size(74, 13);
    this.label39.TabIndex = 25;
    this.label39.Text = "Last Modified:";
    this.label29.AutoSize = true;
    this.label29.BackColor = Color.Transparent;
    this.label29.ForeColor = Color.Black;
    this.label29.Location = new Point(20, 244);
    this.label29.Name = "label29";
    this.label29.Size = new Size(92, 13);
    this.label29.TabIndex = 8;
    this.label29.Text = "Outside Adjuster:";
    ((UltraCombo) this.comboClaimants_OutsideAdjuster).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraCombo) this.comboClaimants_OutsideAdjuster).DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.comboClaimants_OutsideAdjuster).DropDownWidth = 400;
    ((Control) this.comboClaimants_OutsideAdjuster).Location = new Point(139, 244);
    this.comboClaimants_OutsideAdjuster.MGAStyle = (MGAStyles) 2;
    ((Control) this.comboClaimants_OutsideAdjuster).Name = "comboClaimants_OutsideAdjuster";
    ((Control) this.comboClaimants_OutsideAdjuster).Size = new Size(181, 21);
    ((Control) this.comboClaimants_OutsideAdjuster).TabIndex = 9;
    ((Control) this.comboClaimants_OutsideAdjuster).Tag = (object) "Oustside Adjuster";
    ((UltraControlBase) this.comboClaimants_OutsideAdjuster).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboClaimants_OutsideAdjuster).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.comboClaimants_OutsideAdjuster).Enter += new EventHandler(this.combo_Enter);
    ((Control) this.comboClaimants_OutsideAdjuster).Leave += new EventHandler(this.combo_Leave);
    ((AppearanceBase) appearance32).BackColor = Color.White;
    ((AppearanceBase) appearance32).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance32).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textClaimant_EnteredBy).Appearance = (AppearanceBase) appearance32;
    ((Control) this.textClaimant_EnteredBy).BackColor = Color.White;
    ((Control) this.textClaimant_EnteredBy).Enabled = false;
    ((Control) this.textClaimant_EnteredBy).Location = new Point(566, 41);
    this.textClaimant_EnteredBy.MGAStyle = (MGAStyles) 2;
    ((Control) this.textClaimant_EnteredBy).Name = "textClaimant_EnteredBy";
    ((Control) this.textClaimant_EnteredBy).Size = new Size(185, 20);
    ((Control) this.textClaimant_EnteredBy).TabIndex = 18;
    ((UltraControlBase) this.textClaimant_EnteredBy).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textClaimant_EnteredBy).UseOsThemes = (DefaultableBoolean) 2;
    this.label27.AutoSize = true;
    this.label27.BackColor = Color.Transparent;
    this.label27.ForeColor = Color.Black;
    this.label27.Location = new Point(470, 41);
    this.label27.Name = "label27";
    this.label27.Size = new Size(64 /*0x40*/, 13);
    this.label27.TabIndex = 17;
    this.label27.Text = "Entered By:";
    ((AppearanceBase) appearance33).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraDateTimeEditor) this.dateTimeClaimant_DateEntered).Appearance = (AppearanceBase) appearance33;
    ((AppearanceBase) appearance34).AlphaLevel = (short) 14;
    ((AppearanceBase) appearance34).BackColor = Color.FromArgb(0, 0, 246, 253);
    ((AppearanceBase) appearance34).BackColor2 = Color.FromArgb(133, 162, 221);
    ((AppearanceBase) appearance34).BackColorAlpha = (Alpha) 2;
    ((AppearanceBase) appearance34).BackGradientAlignment = (GradientAlignment) 4;
    ((AppearanceBase) appearance34).BackGradientStyle = (GradientStyle) 5;
    ((AppearanceBase) appearance34).BorderAlpha = (Alpha) 1;
    ((AppearanceBase) appearance34).BorderColor = Color.FromArgb(78, 122, 171);
    ((AppearanceBase) appearance34).ForeColor = Color.FromArgb(49, 85, 153);
    ((AppearanceBase) appearance34).ForegroundAlpha = (Alpha) 2;
    ((UltraDateTimeEditor) this.dateTimeClaimant_DateEntered).ButtonAppearance = (AppearanceBase) appearance34;
    ((UltraDateTimeEditor) this.dateTimeClaimant_DateEntered).DateTime = new DateTime(2010, 6, 10, 0, 0, 0, 0);
    ((Control) this.dateTimeClaimant_DateEntered).Enabled = false;
    ((Control) this.dateTimeClaimant_DateEntered).Location = new Point(566, 67);
    this.dateTimeClaimant_DateEntered.MGAStyle = (MGAStyles) 2;
    ((Control) this.dateTimeClaimant_DateEntered).Name = "dateTimeClaimant_DateEntered";
    ((Control) this.dateTimeClaimant_DateEntered).Size = new Size(92, 20);
    ((Control) this.dateTimeClaimant_DateEntered).TabIndex = 20;
    ((UltraControlBase) this.dateTimeClaimant_DateEntered).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dateTimeClaimant_DateEntered).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDateTimeEditor) this.dateTimeClaimant_DateEntered).Value = (object) new DateTime(2010, 6, 10, 0, 0, 0, 0);
    this.label28.AutoSize = true;
    this.label28.BackColor = Color.Transparent;
    this.label28.ForeColor = Color.Black;
    this.label28.Location = new Point(470, 67);
    this.label28.Name = "label28";
    this.label28.Size = new Size(75, 13);
    this.label28.TabIndex = 19;
    this.label28.Text = "Date Entered:";
    this.label26.AutoSize = true;
    this.label26.BackColor = Color.Transparent;
    this.label26.ForeColor = Color.Black;
    this.label26.Location = new Point(20, 217);
    this.label26.Name = "label26";
    this.label26.Size = new Size(117, 13);
    this.label26.TabIndex = 6;
    this.label26.Text = "Managed Care Facility:";
    ((UltraCombo) this.comboClaimants_ManagedCare).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraCombo) this.comboClaimants_ManagedCare).DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboClaimants_ManagedCare).Location = new Point(139, 217);
    this.comboClaimants_ManagedCare.MGAStyle = (MGAStyles) 2;
    ((Control) this.comboClaimants_ManagedCare).Name = "comboClaimants_ManagedCare";
    ((Control) this.comboClaimants_ManagedCare).Size = new Size(181, 21);
    ((Control) this.comboClaimants_ManagedCare).TabIndex = 7;
    ((Control) this.comboClaimants_ManagedCare).Tag = (object) "Managed Care Facility";
    ((UltraControlBase) this.comboClaimants_ManagedCare).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboClaimants_ManagedCare).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.comboClaimants_ManagedCare).Enter += new EventHandler(this.combo_Enter);
    ((Control) this.comboClaimants_ManagedCare).Leave += new EventHandler(this.combo_Leave);
    this.label25.AutoSize = true;
    this.label25.BackColor = Color.Transparent;
    this.label25.ForeColor = Color.Black;
    this.label25.Location = new Point(20, 190);
    this.label25.Name = "label25";
    this.label25.Size = new Size(59, 13);
    this.label25.TabIndex = 4;
    this.label25.Text = "Loss Type:";
    ((UltraCombo) this.comboClaimants_LossType).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraCombo) this.comboClaimants_LossType).DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboClaimants_LossType).Location = new Point(139, 190);
    this.comboClaimants_LossType.MGAStyle = (MGAStyles) 2;
    ((Control) this.comboClaimants_LossType).Name = "comboClaimants_LossType";
    ((Control) this.comboClaimants_LossType).Size = new Size(181, 21);
    ((Control) this.comboClaimants_LossType).TabIndex = 5;
    ((Control) this.comboClaimants_LossType).Tag = (object) "Loss Type";
    ((UltraControlBase) this.comboClaimants_LossType).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboClaimants_LossType).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.comboClaimants_LossType).Enter += new EventHandler(this.combo_Enter);
    ((Control) this.comboClaimants_LossType).Leave += new EventHandler(this.combo_Leave);
    this.label24.AutoSize = true;
    this.label24.BackColor = Color.Transparent;
    this.label24.ForeColor = Color.Black;
    this.label24.Location = new Point(20, 163);
    this.label24.Name = "label24";
    this.label24.Size = new Size(79, 13);
    this.label24.TabIndex = 2;
    this.label24.Text = "Accident Type:";
    ((UltraCombo) this.comboClaimant_AccidentTypes).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraCombo) this.comboClaimant_AccidentTypes).DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboClaimant_AccidentTypes).Location = new Point(139, 163);
    this.comboClaimant_AccidentTypes.MGAStyle = (MGAStyles) 2;
    ((Control) this.comboClaimant_AccidentTypes).Name = "comboClaimant_AccidentTypes";
    ((Control) this.comboClaimant_AccidentTypes).Size = new Size(181, 21);
    ((Control) this.comboClaimant_AccidentTypes).TabIndex = 3;
    ((Control) this.comboClaimant_AccidentTypes).Tag = (object) "Accident Type";
    ((UltraControlBase) this.comboClaimant_AccidentTypes).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboClaimant_AccidentTypes).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.comboClaimant_AccidentTypes).Enter += new EventHandler(this.combo_Enter);
    ((Control) this.comboClaimant_AccidentTypes).Leave += new EventHandler(this.combo_Leave);
    this.label23.AutoSize = true;
    this.label23.BackColor = Color.Transparent;
    this.label23.ForeColor = Color.Black;
    this.label23.Location = new Point(20, 41);
    this.label23.Name = "label23";
    this.label23.Size = new Size(108, 13);
    this.label23.TabIndex = 0;
    this.label23.Text = "Affected Coverages:";
    ((AppearanceBase) appearance35).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraDateTimeEditor) this.dateTimeClaimant_DateReported).Appearance = (AppearanceBase) appearance35;
    ((AppearanceBase) appearance36).AlphaLevel = (short) 14;
    ((AppearanceBase) appearance36).BackColor = Color.FromArgb(0, 0, 246, 253);
    ((AppearanceBase) appearance36).BackColor2 = Color.FromArgb(133, 162, 221);
    ((AppearanceBase) appearance36).BackColorAlpha = (Alpha) 2;
    ((AppearanceBase) appearance36).BackGradientAlignment = (GradientAlignment) 4;
    ((AppearanceBase) appearance36).BackGradientStyle = (GradientStyle) 5;
    ((AppearanceBase) appearance36).BorderAlpha = (Alpha) 1;
    ((AppearanceBase) appearance36).BorderColor = Color.FromArgb(78, 122, 171);
    ((AppearanceBase) appearance36).ForeColor = Color.FromArgb(49, 85, 153);
    ((AppearanceBase) appearance36).ForegroundAlpha = (Alpha) 2;
    ((UltraDateTimeEditor) this.dateTimeClaimant_DateReported).ButtonAppearance = (AppearanceBase) appearance36;
    ((UltraDateTimeEditor) this.dateTimeClaimant_DateReported).DateTime = new DateTime(2010, 6, 10, 0, 0, 0, 0);
    ((Control) this.dateTimeClaimant_DateReported).Location = new Point(566, 93);
    this.dateTimeClaimant_DateReported.MGAStyle = (MGAStyles) 2;
    ((Control) this.dateTimeClaimant_DateReported).Name = "dateTimeClaimant_DateReported";
    ((Control) this.dateTimeClaimant_DateReported).Size = new Size(92, 20);
    ((Control) this.dateTimeClaimant_DateReported).TabIndex = 22;
    ((Control) this.dateTimeClaimant_DateReported).Tag = (object) "Date Reported";
    ((UltraControlBase) this.dateTimeClaimant_DateReported).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dateTimeClaimant_DateReported).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDateTimeEditor) this.dateTimeClaimant_DateReported).Value = (object) new DateTime(2010, 6, 10, 0, 0, 0, 0);
    this.label21.AutoSize = true;
    this.label21.BackColor = Color.Transparent;
    this.label21.ForeColor = Color.Black;
    this.label21.Location = new Point(470, 93);
    this.label21.Name = "label21";
    this.label21.Size = new Size(82, 13);
    this.label21.TabIndex = 21;
    this.label21.Text = "Date Reported:";
    ((Control) this.tabPageLegal).Controls.Add((Control) this.cboClaimantAttorney);
    ((Control) this.tabPageLegal).Controls.Add((Control) this.cboDefenseAttorney);
    ((Control) this.tabPageLegal).Controls.Add((Control) this.optionClaimantAttorneyEntityType);
    ((Control) this.tabPageLegal).Controls.Add((Control) this.optionDefenseEntityType);
    ((Control) this.tabPageLegal).Controls.Add((Control) this.textClaimants_ClaimantAttorneyFEIN);
    ((Control) this.tabPageLegal).Controls.Add((Control) this.textClaimants_DefenseFEIN);
    ((Control) this.tabPageLegal).Controls.Add((Control) this.label54);
    ((Control) this.tabPageLegal).Controls.Add((Control) this.label53);
    ((Control) this.tabPageLegal).Controls.Add((Control) this.textClaimants_DefenseAttorney);
    ((Control) this.tabPageLegal).Controls.Add((Control) this.label52);
    ((Control) this.tabPageLegal).Controls.Add((Control) this.checkClaimants_PublishedDecision);
    ((Control) this.tabPageLegal).Controls.Add((Control) this.textClaimants_Judge);
    ((Control) this.tabPageLegal).Controls.Add((Control) this.label49);
    ((Control) this.tabPageLegal).Controls.Add((Control) this.textClaimants_ClaimantAttorney);
    ((Control) this.tabPageLegal).Controls.Add((Control) this.textClaimants_ClaimantLawFirm);
    ((Control) this.tabPageLegal).Controls.Add((Control) this.label47);
    ((Control) this.tabPageLegal).Controls.Add((Control) this.label48);
    ((Control) this.tabPageLegal).Controls.Add((Control) this.textClaimants_DefenseFirm);
    ((Control) this.tabPageLegal).Controls.Add((Control) this.label46);
    ((Control) this.tabPageLegal).Controls.Add((Control) this.label45);
    ((Control) this.tabPageLegal).Controls.Add((Control) this.dateTimeClaimants_SuitAnswered);
    ((Control) this.tabPageLegal).Controls.Add((Control) this.label43);
    ((Control) this.tabPageLegal).Controls.Add((Control) this.dateTimeClaimants_SuitServed);
    ((Control) this.tabPageLegal).Controls.Add((Control) this.label44);
    ((Control) this.tabPageLegal).Controls.Add((Control) this.checkClaimants_SuitServed);
    ((Control) this.tabPageLegal).Controls.Add((Control) this.addResolverClaimants_DefenseAttorney);
    ((Control) this.tabPageLegal).Controls.Add((Control) this.phoneClaimants_DefenseAttorney);
    ((Control) this.tabPageLegal).Controls.Add((Control) this.addResolverClaimants_ClaimantAttorney);
    ((Control) this.tabPageLegal).Controls.Add((Control) this.phoneClaimants_ClaimantAttorney);
    ((Control) this.tabPageLegal).Location = new Point(-10000, -10000);
    ((Control) this.tabPageLegal).Name = "tabPageLegal";
    ((Control) this.tabPageLegal).Size = new Size(922, 551);
    ((UltraCombo) this.cboClaimantAttorney).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraCombo) this.cboClaimantAttorney).DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboClaimantAttorney).Location = new Point(592, 155);
    this.cboClaimantAttorney.MGAStyle = (MGAStyles) 2;
    ((Control) this.cboClaimantAttorney).Name = "cboClaimantAttorney";
    ((Control) this.cboClaimantAttorney).Size = new Size(248, 21);
    ((Control) this.cboClaimantAttorney).TabIndex = 46;
    ((Control) this.cboClaimantAttorney).Tag = (object) "Settlement Type";
    ((UltraControlBase) this.cboClaimantAttorney).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboClaimantAttorney).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraCombo) this.cboClaimantAttorney).RowSelected += new RowSelectedEventHandler(this.cboClaimantAttorney_RowSelected);
    ((UltraCombo) this.cboDefenseAttorney).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraCombo) this.cboDefenseAttorney).DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboDefenseAttorney).Location = new Point(129, 156);
    this.cboDefenseAttorney.MGAStyle = (MGAStyles) 2;
    ((Control) this.cboDefenseAttorney).Name = "cboDefenseAttorney";
    ((Control) this.cboDefenseAttorney).Size = new Size((int) byte.MaxValue, 21);
    ((Control) this.cboDefenseAttorney).TabIndex = 47;
    ((Control) this.cboDefenseAttorney).Tag = (object) "Settlement Type";
    ((UltraControlBase) this.cboDefenseAttorney).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboDefenseAttorney).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraCombo) this.cboDefenseAttorney).RowSelected += new RowSelectedEventHandler(this.cboDefenseAttorney_RowSelected);
    this.optionClaimantAttorneyEntityType.BorderStyle = (UIElementBorderStyle) 1;
    ((Control) this.optionClaimantAttorneyEntityType).Enabled = false;
    this.optionClaimantAttorneyEntityType.GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007RadioButtonGlyphInfo;
    valueListItem3.DataValue = (object) "I";
    valueListItem3.DisplayText = "Individual";
    valueListItem4.DataValue = (object) "C";
    valueListItem4.DisplayText = "Corporation";
    this.optionClaimantAttorneyEntityType.Items.AddRange(new ValueListItem[2]
    {
      valueListItem3,
      valueListItem4
    });
    ((Control) this.optionClaimantAttorneyEntityType).Location = new Point(592, 111);
    ((Control) this.optionClaimantAttorneyEntityType).Name = "optionClaimantAttorneyEntityType";
    ((Control) this.optionClaimantAttorneyEntityType).Size = new Size(160 /*0xA0*/, 19);
    ((Control) this.optionClaimantAttorneyEntityType).TabIndex = 43;
    ((UltraControlBase) this.optionClaimantAttorneyEntityType).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.optionClaimantAttorneyEntityType).UseOsThemes = (DefaultableBoolean) 2;
    this.optionClaimantAttorneyEntityType.ValueChanged += new EventHandler(this.optionClaimantAttorneyEntityType_ValueChanged);
    this.optionDefenseEntityType.BorderStyle = (UIElementBorderStyle) 1;
    ((Control) this.optionDefenseEntityType).Enabled = false;
    this.optionDefenseEntityType.GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007RadioButtonGlyphInfo;
    valueListItem5.DataValue = (object) "I";
    valueListItem5.DisplayText = "Individual";
    valueListItem6.DataValue = (object) "C";
    valueListItem6.DisplayText = "Corporation";
    this.optionDefenseEntityType.Items.AddRange(new ValueListItem[2]
    {
      valueListItem5,
      valueListItem6
    });
    ((Control) this.optionDefenseEntityType).Location = new Point(129, 111);
    ((Control) this.optionDefenseEntityType).Name = "optionDefenseEntityType";
    ((Control) this.optionDefenseEntityType).Size = new Size(149, 19);
    ((Control) this.optionDefenseEntityType).TabIndex = 42;
    ((UltraControlBase) this.optionDefenseEntityType).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.optionDefenseEntityType).UseOsThemes = (DefaultableBoolean) 2;
    this.optionDefenseEntityType.ValueChanged += new EventHandler(this.optionDefenseEntityType_ValueChanged);
    ((AppearanceBase) appearance37).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraMaskedEdit) this.textClaimants_ClaimantAttorneyFEIN).Appearance = (AppearanceBase) appearance37;
    ((UltraMaskedEdit) this.textClaimants_ClaimantAttorneyFEIN).ClipMode = (MaskMode) 0;
    ((UltraMaskedEdit) this.textClaimants_ClaimantAttorneyFEIN).DataMode = (MaskMode) 0;
    ((UltraMaskedEdit) this.textClaimants_ClaimantAttorneyFEIN).EditAs = (EditAsType) 1;
    ((Control) this.textClaimants_ClaimantAttorneyFEIN).Enabled = false;
    ((UltraMaskedEdit) this.textClaimants_ClaimantAttorneyFEIN).InputMask = "99-9999999";
    ((Control) this.textClaimants_ClaimantAttorneyFEIN).Location = new Point(592, 183);
    this.textClaimants_ClaimantAttorneyFEIN.MGAStyle = (MGAStyles) 2;
    ((Control) this.textClaimants_ClaimantAttorneyFEIN).Name = "textClaimants_ClaimantAttorneyFEIN";
    ((UltraMaskedEdit) this.textClaimants_ClaimantAttorneyFEIN).NonAutoSizeHeight = 20;
    ((Control) this.textClaimants_ClaimantAttorneyFEIN).Size = new Size(72, 21);
    ((Control) this.textClaimants_ClaimantAttorneyFEIN).TabIndex = 21;
    ((UltraControlBase) this.textClaimants_ClaimantAttorneyFEIN).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textClaimants_ClaimantAttorneyFEIN).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance38).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraMaskedEdit) this.textClaimants_DefenseFEIN).Appearance = (AppearanceBase) appearance38;
    ((UltraMaskedEdit) this.textClaimants_DefenseFEIN).ClipMode = (MaskMode) 0;
    ((UltraMaskedEdit) this.textClaimants_DefenseFEIN).DataMode = (MaskMode) 0;
    ((UltraMaskedEdit) this.textClaimants_DefenseFEIN).EditAs = (EditAsType) 1;
    ((Control) this.textClaimants_DefenseFEIN).Enabled = false;
    ((UltraMaskedEdit) this.textClaimants_DefenseFEIN).InputMask = "99-9999999";
    ((Control) this.textClaimants_DefenseFEIN).Location = new Point(129, 183);
    this.textClaimants_DefenseFEIN.MGAStyle = (MGAStyles) 2;
    ((Control) this.textClaimants_DefenseFEIN).Name = "textClaimants_DefenseFEIN";
    ((UltraMaskedEdit) this.textClaimants_DefenseFEIN).NonAutoSizeHeight = 20;
    ((Control) this.textClaimants_DefenseFEIN).Size = new Size(76, 21);
    ((Control) this.textClaimants_DefenseFEIN).TabIndex = 10;
    ((UltraControlBase) this.textClaimants_DefenseFEIN).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textClaimants_DefenseFEIN).UseOsThemes = (DefaultableBoolean) 2;
    this.label54.AutoSize = true;
    this.label54.BackColor = Color.Transparent;
    this.label54.ForeColor = Color.Black;
    this.label54.Location = new Point(485, 185);
    this.label54.Name = "label54";
    this.label54.Size = new Size(57, 13);
    this.label54.TabIndex = 20;
    this.label54.Text = "FEIN/SSN:";
    this.label53.AutoSize = true;
    this.label53.BackColor = Color.Transparent;
    this.label53.ForeColor = Color.Black;
    this.label53.Location = new Point(30, 183);
    this.label53.Name = "label53";
    this.label53.Size = new Size(57, 13);
    this.label53.TabIndex = 9;
    this.label53.Text = "FEIN/SSN:";
    ((AppearanceBase) appearance39).BackColor = Color.White;
    ((AppearanceBase) appearance39).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance39).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textClaimants_DefenseAttorney).Appearance = (AppearanceBase) appearance39;
    ((Control) this.textClaimants_DefenseAttorney).BackColor = Color.White;
    ((Control) this.textClaimants_DefenseAttorney).Location = new Point(129, 157);
    this.textClaimants_DefenseAttorney.MGAStyle = (MGAStyles) 2;
    ((Control) this.textClaimants_DefenseAttorney).Name = "textClaimants_DefenseAttorney";
    ((Control) this.textClaimants_DefenseAttorney).Size = new Size((int) byte.MaxValue, 20);
    ((Control) this.textClaimants_DefenseAttorney).TabIndex = 8;
    ((Control) this.textClaimants_DefenseAttorney).Tag = (object) "Defense Attorney";
    ((UltraControlBase) this.textClaimants_DefenseAttorney).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textClaimants_DefenseAttorney).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.textClaimants_DefenseAttorney).Visible = false;
    ((Control) this.textClaimants_DefenseAttorney).Enter += new EventHandler(this.text_Enter);
    ((Control) this.textClaimants_DefenseAttorney).Leave += new EventHandler(this.text_Leave);
    this.label52.AutoSize = true;
    this.label52.BackColor = Color.Transparent;
    this.label52.ForeColor = Color.Black;
    this.label52.Location = new Point(30, 158);
    this.label52.Name = "label52";
    this.label52.Size = new Size(97, 13);
    this.label52.TabIndex = 7;
    this.label52.Text = "Defense Attorney:";
    ((AppearanceBase) appearance40).BorderColor = Color.Gray;
    ((AppearanceBase) appearance40).ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.checkClaimants_PublishedDecision).Appearance = (AppearanceBase) appearance40;
    ((Control) this.checkClaimants_PublishedDecision).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.checkClaimants_PublishedDecision).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.checkClaimants_PublishedDecision).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.checkClaimants_PublishedDecision).Location = new Point(592, 39);
    ((Control) this.checkClaimants_PublishedDecision).Name = "checkClaimants_PublishedDecision";
    ((Control) this.checkClaimants_PublishedDecision).Size = new Size(116, 20);
    ((Control) this.checkClaimants_PublishedDecision).TabIndex = 13;
    ((Control) this.checkClaimants_PublishedDecision).Text = "Published Decision";
    ((AppearanceBase) appearance41).BackColor = Color.White;
    ((AppearanceBase) appearance41).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance41).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textClaimants_Judge).Appearance = (AppearanceBase) appearance41;
    ((Control) this.textClaimants_Judge).BackColor = Color.White;
    ((Control) this.textClaimants_Judge).Location = new Point(592, 66);
    this.textClaimants_Judge.MGAStyle = (MGAStyles) 2;
    ((Control) this.textClaimants_Judge).Name = "textClaimants_Judge";
    ((Control) this.textClaimants_Judge).Size = new Size(244, 20);
    ((Control) this.textClaimants_Judge).TabIndex = 15;
    ((Control) this.textClaimants_Judge).Tag = (object) "Judge";
    ((UltraControlBase) this.textClaimants_Judge).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textClaimants_Judge).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.textClaimants_Judge).Enter += new EventHandler(this.text_Enter);
    ((Control) this.textClaimants_Judge).Leave += new EventHandler(this.text_Leave);
    this.label49.AutoSize = true;
    this.label49.BackColor = Color.Transparent;
    this.label49.ForeColor = Color.Black;
    this.label49.Location = new Point(485, 66);
    this.label49.Name = "label49";
    this.label49.Size = new Size(40, 13);
    this.label49.TabIndex = 14;
    this.label49.Text = "Judge:";
    ((AppearanceBase) appearance42).BackColor = Color.White;
    ((AppearanceBase) appearance42).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance42).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textClaimants_ClaimantAttorney).Appearance = (AppearanceBase) appearance42;
    ((Control) this.textClaimants_ClaimantAttorney).BackColor = Color.White;
    ((Control) this.textClaimants_ClaimantAttorney).Location = new Point(592, 155);
    this.textClaimants_ClaimantAttorney.MGAStyle = (MGAStyles) 2;
    ((Control) this.textClaimants_ClaimantAttorney).Name = "textClaimants_ClaimantAttorney";
    ((Control) this.textClaimants_ClaimantAttorney).Size = new Size(248, 20);
    ((Control) this.textClaimants_ClaimantAttorney).TabIndex = 19;
    ((Control) this.textClaimants_ClaimantAttorney).Tag = (object) "Claimant Attorney";
    ((UltraControlBase) this.textClaimants_ClaimantAttorney).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textClaimants_ClaimantAttorney).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.textClaimants_ClaimantAttorney).Visible = false;
    ((Control) this.textClaimants_ClaimantAttorney).Enter += new EventHandler(this.text_Enter);
    ((Control) this.textClaimants_ClaimantAttorney).Leave += new EventHandler(this.text_Leave);
    ((AppearanceBase) appearance43).BackColor = Color.White;
    ((AppearanceBase) appearance43).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance43).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textClaimants_ClaimantLawFirm).Appearance = (AppearanceBase) appearance43;
    ((Control) this.textClaimants_ClaimantLawFirm).BackColor = Color.White;
    ((Control) this.textClaimants_ClaimantLawFirm).Enabled = false;
    ((Control) this.textClaimants_ClaimantLawFirm).Location = new Point(592, 131);
    this.textClaimants_ClaimantLawFirm.MGAStyle = (MGAStyles) 2;
    ((Control) this.textClaimants_ClaimantLawFirm).Name = "textClaimants_ClaimantLawFirm";
    ((Control) this.textClaimants_ClaimantLawFirm).Size = new Size(248, 20);
    ((Control) this.textClaimants_ClaimantLawFirm).TabIndex = 17;
    ((Control) this.textClaimants_ClaimantLawFirm).Tag = (object) "Claimant Law Firm";
    ((UltraControlBase) this.textClaimants_ClaimantLawFirm).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textClaimants_ClaimantLawFirm).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.textClaimants_ClaimantLawFirm).Enter += new EventHandler(this.text_Enter);
    ((Control) this.textClaimants_ClaimantLawFirm).Leave += new EventHandler(this.text_Leave);
    this.label47.AutoSize = true;
    this.label47.BackColor = Color.Transparent;
    this.label47.ForeColor = Color.Black;
    this.label47.Location = new Point(485, 130);
    this.label47.Name = "label47";
    this.label47.Size = new Size(97, 13);
    this.label47.TabIndex = 16 /*0x10*/;
    this.label47.Text = "Claimant Law Firm:";
    this.label48.AutoSize = true;
    this.label48.BackColor = Color.Transparent;
    this.label48.ForeColor = Color.Black;
    this.label48.Location = new Point(485, 156);
    this.label48.Name = "label48";
    this.label48.Size = new Size(98, 13);
    this.label48.TabIndex = 18;
    this.label48.Text = "Claimant Attorney:";
    ((AppearanceBase) appearance44).BackColor = Color.White;
    ((AppearanceBase) appearance44).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance44).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textClaimants_DefenseFirm).Appearance = (AppearanceBase) appearance44;
    ((Control) this.textClaimants_DefenseFirm).BackColor = Color.White;
    ((Control) this.textClaimants_DefenseFirm).Enabled = false;
    ((Control) this.textClaimants_DefenseFirm).Location = new Point(129, 131);
    this.textClaimants_DefenseFirm.MGAStyle = (MGAStyles) 2;
    ((Control) this.textClaimants_DefenseFirm).Name = "textClaimants_DefenseFirm";
    ((Control) this.textClaimants_DefenseFirm).Size = new Size((int) byte.MaxValue, 20);
    ((Control) this.textClaimants_DefenseFirm).TabIndex = 6;
    ((Control) this.textClaimants_DefenseFirm).Tag = (object) "Defense Firm";
    ((UltraControlBase) this.textClaimants_DefenseFirm).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textClaimants_DefenseFirm).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.textClaimants_DefenseFirm).Enter += new EventHandler(this.text_Enter);
    ((Control) this.textClaimants_DefenseFirm).Leave += new EventHandler(this.text_Leave);
    this.label46.AutoSize = true;
    this.label46.BackColor = Color.Transparent;
    this.label46.ForeColor = Color.Black;
    this.label46.Location = new Point(30, 133);
    this.label46.Name = "label46";
    this.label46.Size = new Size(74, 13);
    this.label46.TabIndex = 5;
    this.label46.Text = "Defense Firm:";
    this.label45.AutoSize = true;
    this.label45.BackColor = Color.Transparent;
    this.label45.ForeColor = Color.Black;
    this.label45.Location = new Point(28, 130);
    this.label45.Name = "label45";
    this.label45.Size = new Size(54, 13);
    this.label45.TabIndex = 41;
    this.label45.Text = "Attorney:";
    ((AppearanceBase) appearance45).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraDateTimeEditor) this.dateTimeClaimants_SuitAnswered).Appearance = (AppearanceBase) appearance45;
    ((AppearanceBase) appearance46).AlphaLevel = (short) 14;
    ((AppearanceBase) appearance46).BackColor = Color.FromArgb(0, 0, 246, 253);
    ((AppearanceBase) appearance46).BackColor2 = Color.FromArgb(133, 162, 221);
    ((AppearanceBase) appearance46).BackColorAlpha = (Alpha) 2;
    ((AppearanceBase) appearance46).BackGradientAlignment = (GradientAlignment) 4;
    ((AppearanceBase) appearance46).BackGradientStyle = (GradientStyle) 5;
    ((AppearanceBase) appearance46).BorderAlpha = (Alpha) 1;
    ((AppearanceBase) appearance46).BorderColor = Color.FromArgb(78, 122, 171);
    ((AppearanceBase) appearance46).ForeColor = Color.FromArgb(49, 85, 153);
    ((AppearanceBase) appearance46).ForegroundAlpha = (Alpha) 2;
    ((UltraDateTimeEditor) this.dateTimeClaimants_SuitAnswered).ButtonAppearance = (AppearanceBase) appearance46;
    ((UltraDateTimeEditor) this.dateTimeClaimants_SuitAnswered).DateTime = new DateTime(2007, 10, 3, 0, 0, 0, 0);
    ((Control) this.dateTimeClaimants_SuitAnswered).Location = new Point(129, 85);
    this.dateTimeClaimants_SuitAnswered.MGAStyle = (MGAStyles) 2;
    ((Control) this.dateTimeClaimants_SuitAnswered).Name = "dateTimeClaimants_SuitAnswered";
    ((Control) this.dateTimeClaimants_SuitAnswered).Size = new Size(92, 20);
    ((Control) this.dateTimeClaimants_SuitAnswered).TabIndex = 4;
    ((UltraControlBase) this.dateTimeClaimants_SuitAnswered).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dateTimeClaimants_SuitAnswered).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDateTimeEditor) this.dateTimeClaimants_SuitAnswered).Value = (object) new DateTime(2007, 10, 3, 0, 0, 0, 0);
    this.label43.AutoSize = true;
    this.label43.BackColor = Color.Transparent;
    this.label43.ForeColor = Color.Black;
    this.label43.Location = new Point(30, 85);
    this.label43.Name = "label43";
    this.label43.Size = new Size(85, 13);
    this.label43.TabIndex = 3;
    this.label43.Text = "Date Answered:";
    ((AppearanceBase) appearance47).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraDateTimeEditor) this.dateTimeClaimants_SuitServed).Appearance = (AppearanceBase) appearance47;
    ((AppearanceBase) appearance48).AlphaLevel = (short) 14;
    ((AppearanceBase) appearance48).BackColor = Color.FromArgb(0, 0, 246, 253);
    ((AppearanceBase) appearance48).BackColor2 = Color.FromArgb(133, 162, 221);
    ((AppearanceBase) appearance48).BackColorAlpha = (Alpha) 2;
    ((AppearanceBase) appearance48).BackGradientAlignment = (GradientAlignment) 4;
    ((AppearanceBase) appearance48).BackGradientStyle = (GradientStyle) 5;
    ((AppearanceBase) appearance48).BorderAlpha = (Alpha) 1;
    ((AppearanceBase) appearance48).BorderColor = Color.FromArgb(78, 122, 171);
    ((AppearanceBase) appearance48).ForeColor = Color.FromArgb(49, 85, 153);
    ((AppearanceBase) appearance48).ForegroundAlpha = (Alpha) 2;
    ((UltraDateTimeEditor) this.dateTimeClaimants_SuitServed).ButtonAppearance = (AppearanceBase) appearance48;
    ((UltraDateTimeEditor) this.dateTimeClaimants_SuitServed).DateTime = new DateTime(2007, 10, 3, 0, 0, 0, 0);
    ((Control) this.dateTimeClaimants_SuitServed).Location = new Point(129, 59);
    this.dateTimeClaimants_SuitServed.MGAStyle = (MGAStyles) 2;
    ((Control) this.dateTimeClaimants_SuitServed).Name = "dateTimeClaimants_SuitServed";
    ((Control) this.dateTimeClaimants_SuitServed).Size = new Size(92, 20);
    ((Control) this.dateTimeClaimants_SuitServed).TabIndex = 2;
    ((UltraControlBase) this.dateTimeClaimants_SuitServed).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dateTimeClaimants_SuitServed).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDateTimeEditor) this.dateTimeClaimants_SuitServed).Value = (object) new DateTime(2007, 10, 3, 0, 0, 0, 0);
    this.label44.AutoSize = true;
    this.label44.BackColor = Color.Transparent;
    this.label44.ForeColor = Color.Black;
    this.label44.Location = new Point(30, 59);
    this.label44.Name = "label44";
    this.label44.Size = new Size(71, 13);
    this.label44.TabIndex = 1;
    this.label44.Text = "Date Served:";
    ((AppearanceBase) appearance49).BorderColor = Color.Gray;
    ((AppearanceBase) appearance49).ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.checkClaimants_SuitServed).Appearance = (AppearanceBase) appearance49;
    ((Control) this.checkClaimants_SuitServed).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.checkClaimants_SuitServed).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.checkClaimants_SuitServed).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.checkClaimants_SuitServed).Location = new Point(129, 39);
    ((Control) this.checkClaimants_SuitServed).Name = "checkClaimants_SuitServed";
    ((Control) this.checkClaimants_SuitServed).Size = new Size(120, 20);
    ((Control) this.checkClaimants_SuitServed).TabIndex = 0;
    ((Control) this.checkClaimants_SuitServed).Text = "Suit Served";
    this.addResolverClaimants_DefenseAttorney.Address1 = "";
    this.addResolverClaimants_DefenseAttorney.Address2 = "";
    ((Control) this.addResolverClaimants_DefenseAttorney).BackColor = Color.Transparent;
    this.addResolverClaimants_DefenseAttorney.City = "";
    this.addResolverClaimants_DefenseAttorney.County = "";
    ((Control) this.addResolverClaimants_DefenseAttorney).Enabled = false;
    ((Control) this.addResolverClaimants_DefenseAttorney).Font = new Font("Tahoma", 8f);
    this.addResolverClaimants_DefenseAttorney.ISOCountryCode = "";
    this.addResolverClaimants_DefenseAttorney.ISOCountryCodeMember = "";
    this.addResolverClaimants_DefenseAttorney.ISOCountryList = (object) null;
    this.addResolverClaimants_DefenseAttorney.ISOCountryNameMember = "";
    ((Control) this.addResolverClaimants_DefenseAttorney).Location = new Point(22, 203);
    this.addResolverClaimants_DefenseAttorney.MGAStyle = (MGAStyles) 2;
    ((Control) this.addResolverClaimants_DefenseAttorney).Name = "addResolverClaimants_DefenseAttorney";
    this.addResolverClaimants_DefenseAttorney.Password = (string) null;
    ((Control) this.addResolverClaimants_DefenseAttorney).Size = new Size(283, 152);
    this.addResolverClaimants_DefenseAttorney.State = "";
    ((Control) this.addResolverClaimants_DefenseAttorney).TabIndex = 11;
    ((Control) this.addResolverClaimants_DefenseAttorney).Tag = (object) "Defense Firm Address";
    this.addResolverClaimants_DefenseAttorney.TextAlign = ContentAlignment.TopLeft;
    this.addResolverClaimants_DefenseAttorney.UserID = (string) null;
    this.addResolverClaimants_DefenseAttorney.WebserviceUrl = (string) null;
    this.addResolverClaimants_DefenseAttorney.ZipCode = "";
    this.addResolverClaimants_DefenseAttorney.ZipCodeExtension = "";
    ((Control) this.addResolverClaimants_DefenseAttorney).Enter += new EventHandler(this.addResolver_Enter);
    ((Control) this.addResolverClaimants_DefenseAttorney).Leave += new EventHandler(this.addResolver_Leave);
    this.phoneClaimants_DefenseAttorney.BackColor = Color.Transparent;
    this.phoneClaimants_DefenseAttorney.Enabled = false;
    this.phoneClaimants_DefenseAttorney.Font = new Font("Tahoma", 8.25f);
    this.phoneClaimants_DefenseAttorney.Location = new Point(27, 350);
    this.phoneClaimants_DefenseAttorney.Name = "phoneClaimants_DefenseAttorney";
    this.phoneClaimants_DefenseAttorney.Size = new Size(368, 154);
    this.phoneClaimants_DefenseAttorney.TabIndex = 12;
    this.addResolverClaimants_ClaimantAttorney.Address1 = "";
    this.addResolverClaimants_ClaimantAttorney.Address2 = "";
    ((Control) this.addResolverClaimants_ClaimantAttorney).BackColor = Color.Transparent;
    this.addResolverClaimants_ClaimantAttorney.City = "";
    this.addResolverClaimants_ClaimantAttorney.County = "";
    ((Control) this.addResolverClaimants_ClaimantAttorney).Enabled = false;
    ((Control) this.addResolverClaimants_ClaimantAttorney).Font = new Font("Tahoma", 8f);
    this.addResolverClaimants_ClaimantAttorney.ISOCountryCode = "";
    this.addResolverClaimants_ClaimantAttorney.ISOCountryCodeMember = "";
    this.addResolverClaimants_ClaimantAttorney.ISOCountryList = (object) null;
    this.addResolverClaimants_ClaimantAttorney.ISOCountryNameMember = "";
    ((Control) this.addResolverClaimants_ClaimantAttorney).Location = new Point(478, 201);
    this.addResolverClaimants_ClaimantAttorney.MGAStyle = (MGAStyles) 2;
    ((Control) this.addResolverClaimants_ClaimantAttorney).Name = "addResolverClaimants_ClaimantAttorney";
    this.addResolverClaimants_ClaimantAttorney.Password = (string) null;
    ((Control) this.addResolverClaimants_ClaimantAttorney).Size = new Size(290, 152);
    this.addResolverClaimants_ClaimantAttorney.State = "";
    ((Control) this.addResolverClaimants_ClaimantAttorney).TabIndex = 22;
    ((Control) this.addResolverClaimants_ClaimantAttorney).Tag = (object) "Claimant Attorney Address";
    this.addResolverClaimants_ClaimantAttorney.TextAlign = ContentAlignment.TopLeft;
    this.addResolverClaimants_ClaimantAttorney.UserID = (string) null;
    this.addResolverClaimants_ClaimantAttorney.WebserviceUrl = (string) null;
    this.addResolverClaimants_ClaimantAttorney.ZipCode = "";
    this.addResolverClaimants_ClaimantAttorney.ZipCodeExtension = "";
    ((Control) this.addResolverClaimants_ClaimantAttorney).Enter += new EventHandler(this.addResolver_Enter);
    ((Control) this.addResolverClaimants_ClaimantAttorney).Leave += new EventHandler(this.addResolver_Leave);
    this.phoneClaimants_ClaimantAttorney.BackColor = Color.Transparent;
    this.phoneClaimants_ClaimantAttorney.Enabled = false;
    this.phoneClaimants_ClaimantAttorney.Font = new Font("Tahoma", 8.25f);
    this.phoneClaimants_ClaimantAttorney.Location = new Point(484, 348);
    this.phoneClaimants_ClaimantAttorney.Name = "phoneClaimants_ClaimantAttorney";
    this.phoneClaimants_ClaimantAttorney.Size = new Size(372, 154);
    this.phoneClaimants_ClaimantAttorney.TabIndex = 23;
    ((Control) this.tabPageClaimantReservesPayments).Controls.Add((Control) this.gridClaimants_ReservePayments);
    ((Control) this.tabPageClaimantReservesPayments).Location = new Point(-10000, -10000);
    ((Control) this.tabPageClaimantReservesPayments).Name = "tabPageClaimantReservesPayments";
    ((Control) this.tabPageClaimantReservesPayments).Size = new Size(922, 551);
    this.ultraToolbarsManager1.SetContextMenuUltra((Component) this.gridClaimants_ReservePayments, "GridContextMenu");
    ((UltraGridBase) this.gridClaimants_ReservePayments).DataSource = (object) this.dsReservesPayments1;
    ((AppearanceBase) appearance50).BackColor = Color.White;
    ((AppearanceBase) appearance50).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.Appearance = (AppearanceBase) appearance50;
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn1.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn1.Header).VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 30;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn2.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn2.Header).VisiblePosition = 11;
    ultraGridColumn2.Hidden = true;
    ultraGridColumn2.Width = 73;
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn3.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn3.Header).Caption = "Entry Type";
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Width = 161;
    ultraGridColumn4.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn4.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn4.Header).VisiblePosition = 12;
    ultraGridColumn4.Hidden = true;
    ultraGridColumn4.Width = 59;
    ultraGridColumn5.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn5.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn5.Header).Caption = "Coverage Type";
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn5.Width = 149;
    ultraGridColumn6.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn6.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn6.Header).VisiblePosition = 13;
    ultraGridColumn6.Width = 111;
    ultraGridColumn7.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn7.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn7.Header).Caption = "Coverage Sub-Type";
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn7.Width = 149;
    ultraGridColumn8.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn8.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn8.Header).VisiblePosition = 14;
    ultraGridColumn8.Hidden = true;
    ultraGridColumn8.Width = 52;
    ultraGridColumn9.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn9.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn9.Header).Caption = "Type";
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn9.Width = 149;
    ultraGridColumn10.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn10.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn10.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn10.Header).VisiblePosition = 15;
    ultraGridColumn10.Hidden = true;
    ultraGridColumn10.Width = 64 /*0x40*/;
    ultraGridColumn11.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn11.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn11.Header).Caption = "Type Description";
    ((HeaderBase) ultraGridColumn11.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn11.Width = 149;
    ultraGridColumn12.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn12.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance51).TextHAlignAsString = "Right";
    ultraGridColumn12.CellAppearance = (AppearanceBase) appearance51;
    ultraGridColumn12.Format = "c";
    ((AppearanceBase) appearance52).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn12.Header).Appearance = (AppearanceBase) appearance52;
    ((HeaderBase) ultraGridColumn12.Header).Caption = "Amount";
    ((HeaderBase) ultraGridColumn12.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn12.Width = 133;
    ultraGridColumn13.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn13.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn13.Header).Caption = "Date Created";
    ((HeaderBase) ultraGridColumn13.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn13.Width = 181;
    ultraGridColumn14.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn14.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn14.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn14.Header).VisiblePosition = 16 /*0x10*/;
    ultraGridColumn14.Hidden = true;
    ultraGridColumn14.Width = 142;
    ultraGridColumn15.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn15.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn15.Header).Caption = "Created By";
    ((HeaderBase) ultraGridColumn15.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn15.Width = 134;
    ultraGridColumn16.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn16.CellActivation = (Activation) 3;
    ultraGridColumn16.MaxLength = 5000;
    ultraGridColumn16.Width = 425;
    ultraGridColumn17.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn17.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn17.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn17.Header).VisiblePosition = 17;
    ultraGridColumn18.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn18.CellActivation = (Activation) 3;
    ultraGridColumn18.Width = 163;
    ((HeaderBase) ultraGridColumn19.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn19.Header).VisiblePosition = 18;
    ((HeaderBase) ultraGridColumn20.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn20.Header).VisiblePosition = 19;
    ultraGridBand.Columns.AddRange(new object[20]
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
      (object) ultraGridColumn16,
      (object) ultraGridColumn17,
      (object) ultraGridColumn18,
      (object) ultraGridColumn19,
      (object) ultraGridColumn20
    });
    ultraGridBand.GroupHeadersVisible = false;
    ((KeyedSubObjectBase) ultraGridGroup).Key = "TopRow";
    ultraGridBand.Groups.AddRange(new UltraGridGroup[1]
    {
      ultraGridGroup
    });
    ultraGridBand.LevelCount = 2;
    ((AppearanceBase) appearance53).TextHAlignAsString = "Right";
    summarySettings.Appearance = (AppearanceBase) appearance53;
    summarySettings.DisplayFormat = "{0:c}";
    ultraGridBand.Summaries.AddRange(new SummarySettings[1]
    {
      summarySettings
    });
    ultraGridBand.SummaryFooterCaption = "";
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance54).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance54).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance54).ForeColor = Color.Black;
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance54;
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.Override.AllowAddNew = (AllowAddNew) 2;
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.Override.AllowColMoving = (AllowColMoving) 1;
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.Override.AllowColSwapping = (AllowColSwapping) 1;
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 1;
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.Override.AllowGroupBy = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.Override.AllowGroupMoving = (AllowGroupMoving) 1;
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.Override.AllowGroupSwapping = (AllowGroupSwapping) 1;
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.Override.AllowMultiCellOperations = (AllowMultiCellOperation) 0;
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.Override.AllowRowLayoutCellSizing = (RowLayoutSizing) 1;
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.Override.AllowRowLayoutCellSpanSizing = (GridBagLayoutAllowSpanSizing) 1;
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.Override.AllowRowLayoutColMoving = (GridBagLayoutAllowMoving) 1;
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.Override.AllowRowLayoutLabelSizing = (RowLayoutSizing) 1;
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.Override.AllowRowLayoutLabelSpanSizing = (GridBagLayoutAllowSpanSizing) 1;
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.Override.AllowRowSummaries = (AllowRowSummaries) 2;
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 1;
    ((AppearanceBase) appearance55).BorderColor = Color.LightGray;
    ((AppearanceBase) appearance55).TextHAlignAsString = "Left";
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance55;
    ((AppearanceBase) appearance56).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((AppearanceBase) appearance56).TextHAlignAsString = "Left";
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance56;
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance57).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance57;
    ((AppearanceBase) appearance58).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance58;
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.Override.RowSpacingAfter = 1;
    ((AppearanceBase) appearance59).BackColor = Color.Transparent;
    ((AppearanceBase) appearance59).ForeColor = Color.Black;
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance59;
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.Override.SummaryFooterCaptionVisible = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance60).BackColor = Color.LightSteelBlue;
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.Override.SummaryValueAppearance = (AppearanceBase) appearance60;
    ((AppearanceBase) appearance61).BackColor = Color.LightSteelBlue;
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance61;
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.Override.TipStyleCell = (TipStyle) 2;
    ((AppearanceBase) appearance62).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance62).BorderColor = Color.Silver;
    scrollBarLook2.ButtonAppearance = (AppearanceBase) appearance62;
    ((AppearanceBase) appearance63).BackColor = Color.White;
    scrollBarLook2.TrackAppearance = (AppearanceBase) appearance63;
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.ScrollBarLook = scrollBarLook2;
    ((Control) this.gridClaimants_ReservePayments).Dock = DockStyle.Fill;
    ((Control) this.gridClaimants_ReservePayments).Location = new Point(0, 0);
    ((Control) this.gridClaimants_ReservePayments).Name = "gridClaimants_ReservePayments";
    ((Control) this.gridClaimants_ReservePayments).Size = new Size(922, 551);
    ((Control) this.gridClaimants_ReservePayments).TabIndex = 0;
    ((UltraControlBase) this.gridClaimants_ReservePayments).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridClaimants_ReservePayments).UseOsThemes = (DefaultableBoolean) 2;
    this.gridClaimants_ReservePayments.InitializeRow += new InitializeRowEventHandler(this.gridClaimants_ReservePayments_InitializeRow);
    this.gridClaimants_ReservePayments.InitializeTemplateAddRow += new InitializeTemplateAddRowEventHandler(this.gridClaimants_ReservePayments_InitializeTemplateAddRow);
    ((UltraControlBase) this.gridClaimants_ReservePayments).MouseEnterElement += new UIElementEventHandler(this.gridClaimants_ReservePayments_MouseEnterElement);
    ((UltraControlBase) this.gridClaimants_ReservePayments).MouseLeaveElement += new UIElementEventHandler(this.gridClaimants_ReservePayments_MouseLeaveElement);
    this.dsReservesPayments1.DataSetName = "dsReservesPayments";
    this.dsReservesPayments1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((Control) this.ultraTabPageControl1).Location = new Point(-10000, -10000);
    ((Control) this.ultraTabPageControl1).Name = "ultraTabPageControl1";
    ((Control) this.ultraTabPageControl1).Size = new Size(922, 551);
    ((Control) this.ultraTabPageControlVerisk).Controls.Add((Control) this.Verisk_label5);
    ((Control) this.ultraTabPageControlVerisk).Controls.Add((Control) this.lnkICD);
    ((Control) this.ultraTabPageControlVerisk).Controls.Add((Control) this.Verisk_mgaNoFaultPolicyLimit);
    ((Control) this.ultraTabPageControlVerisk).Controls.Add((Control) this.Verisk_label13);
    ((Control) this.ultraTabPageControlVerisk).Controls.Add((Control) this.Verisk_cboRepType);
    ((Control) this.ultraTabPageControlVerisk).Controls.Add((Control) this.Verisk_label12);
    ((Control) this.ultraTabPageControlVerisk).Controls.Add((Control) this.Verisk_dtORMTermination);
    ((Control) this.ultraTabPageControlVerisk).Controls.Add((Control) this.Verisk_label11);
    ((Control) this.ultraTabPageControlVerisk).Controls.Add((Control) this.Verisk_cboORMIndicator);
    ((Control) this.ultraTabPageControlVerisk).Controls.Add((Control) this.Verisk_label10);
    ((Control) this.ultraTabPageControlVerisk).Controls.Add((Control) this.Verisk_label9);
    ((Control) this.ultraTabPageControlVerisk).Controls.Add((Control) this.Verisk_txtApprovalComments);
    ((Control) this.ultraTabPageControlVerisk).Controls.Add((Control) this.Verisk_label8);
    ((Control) this.ultraTabPageControlVerisk).Controls.Add((Control) this.Verisk_cboMedicareApproval);
    ((Control) this.ultraTabPageControlVerisk).Controls.Add((Control) this.Verisk_label1);
    ((Control) this.ultraTabPageControlVerisk).Controls.Add((Control) this.Verisk_cboInsuranceType);
    ((Control) this.ultraTabPageControlVerisk).Controls.Add((Control) this.Verisk_txtHICNMBI);
    ((Control) this.ultraTabPageControlVerisk).Controls.Add((Control) this.Verisk_label7);
    ((Control) this.ultraTabPageControlVerisk).Controls.Add((Control) this.Verisk_label6);
    ((Control) this.ultraTabPageControlVerisk).Controls.Add((Control) this.Verisk_dtInjuredDeathDate);
    ((Control) this.ultraTabPageControlVerisk).Controls.Add((Control) this.Verisk_txtICDCode);
    ((Control) this.ultraTabPageControlVerisk).Controls.Add((Control) this.Verisk_label4);
    ((Control) this.ultraTabPageControlVerisk).Controls.Add((Control) this.Verisk_label3);
    ((Control) this.ultraTabPageControlVerisk).Controls.Add((Control) this.Verisk_dtFundingDelayed);
    ((Control) this.ultraTabPageControlVerisk).Controls.Add((Control) this.Verisk_label2);
    ((Control) this.ultraTabPageControlVerisk).Controls.Add((Control) this.Verisk_dtExhaustDate);
    ((Control) this.ultraTabPageControlVerisk).Location = new Point(-10000, -10000);
    ((Control) this.ultraTabPageControlVerisk).Name = "ultraTabPageControlVerisk";
    ((Control) this.ultraTabPageControlVerisk).Size = new Size(922, 551);
    this.Verisk_label5.AutoSize = true;
    this.Verisk_label5.BackColor = Color.Transparent;
    this.Verisk_label5.Location = new Point(10, 120);
    this.Verisk_label5.Name = "Verisk_label5";
    this.Verisk_label5.Size = new Size(50, 13);
    this.Verisk_label5.TabIndex = 118;
    this.Verisk_label5.Text = "ICD Link:";
    this.Verisk_label5.Visible = false;
    this.lnkICD.AutoSize = true;
    this.lnkICD.BackColor = Color.Transparent;
    this.lnkICD.Location = new Point(146, 120);
    this.lnkICD.Name = "lnkICD";
    this.lnkICD.Size = new Size(280, 13);
    this.lnkICD.TabIndex = 108;
    this.lnkICD.TabStop = true;
    this.lnkICD.Text = "https://clients.mspnavigator.com/Public/ICDLookup.aspx";
    this.lnkICD.Visible = false;
    this.lnkICD.LinkClicked += new LinkLabelLinkClickedEventHandler(this.lnkICD_LinkClicked);
    ((AppearanceBase) appearance64).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance64).TextHAlignAsString = "Right";
    ((UltraMaskedEdit) this.Verisk_mgaNoFaultPolicyLimit).Appearance = (AppearanceBase) appearance64;
    ((UltraMaskedEdit) this.Verisk_mgaNoFaultPolicyLimit).DataMode = (MaskMode) 0;
    ((UltraMaskedEdit) this.Verisk_mgaNoFaultPolicyLimit).EditAs = (EditAsType) 2;
    ((Control) this.Verisk_mgaNoFaultPolicyLimit).Location = new Point(148, 321);
    this.Verisk_mgaNoFaultPolicyLimit.MGAStyle = (MGAStyles) 2;
    ((Control) this.Verisk_mgaNoFaultPolicyLimit).Name = "Verisk_mgaNoFaultPolicyLimit";
    ((UltraMaskedEdit) this.Verisk_mgaNoFaultPolicyLimit).NonAutoSizeHeight = 21;
    ((Control) this.Verisk_mgaNoFaultPolicyLimit).Size = new Size(101, 21);
    ((Control) this.Verisk_mgaNoFaultPolicyLimit).TabIndex = 117;
    ((UltraControlBase) this.Verisk_mgaNoFaultPolicyLimit).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.Verisk_mgaNoFaultPolicyLimit).UseOsThemes = (DefaultableBoolean) 2;
    this.Verisk_label13.AutoSize = true;
    this.Verisk_label13.BackColor = Color.Transparent;
    this.Verisk_label13.ForeColor = SystemColors.ControlText;
    this.Verisk_label13.Location = new Point(10, 400);
    this.Verisk_label13.Name = "Verisk_label13";
    this.Verisk_label13.Size = new Size(112 /*0x70*/, 13);
    this.Verisk_label13.TabIndex = 121;
    this.Verisk_label13.Text = "Representative Type:";
    ((UltraCombo) this.Verisk_cboRepType).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraCombo) this.Verisk_cboRepType).DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.Verisk_cboRepType).Location = new Point(148, 394);
    this.Verisk_cboRepType.MGAStyle = (MGAStyles) 2;
    ((Control) this.Verisk_cboRepType).Name = "Verisk_cboRepType";
    ((Control) this.Verisk_cboRepType).Size = new Size(161, 21);
    ((Control) this.Verisk_cboRepType).TabIndex = 122;
    ((UltraControlBase) this.Verisk_cboRepType).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.Verisk_cboRepType).UseOsThemes = (DefaultableBoolean) 2;
    this.Verisk_label12.AutoSize = true;
    this.Verisk_label12.BackColor = Color.Transparent;
    this.Verisk_label12.Location = new Point(10, 374);
    this.Verisk_label12.Name = "Verisk_label12";
    this.Verisk_label12.Size = new Size(119, 13);
    this.Verisk_label12.TabIndex = 113;
    this.Verisk_label12.Text = "ORM Termination Date:";
    ((AppearanceBase) appearance65).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraDateTimeEditor) this.Verisk_dtORMTermination).Appearance = (AppearanceBase) appearance65;
    ((AppearanceBase) appearance66).AlphaLevel = (short) 14;
    ((AppearanceBase) appearance66).BackColor = Color.FromArgb(0, 0, 246, 253);
    ((AppearanceBase) appearance66).BackColor2 = Color.FromArgb(133, 162, 221);
    ((AppearanceBase) appearance66).BackColorAlpha = (Alpha) 2;
    ((AppearanceBase) appearance66).BackGradientAlignment = (GradientAlignment) 4;
    ((AppearanceBase) appearance66).BackGradientStyle = (GradientStyle) 5;
    ((AppearanceBase) appearance66).BorderAlpha = (Alpha) 1;
    ((AppearanceBase) appearance66).BorderColor = Color.FromArgb(78, 122, 171);
    ((AppearanceBase) appearance66).ForeColor = Color.FromArgb(49, 85, 153);
    ((AppearanceBase) appearance66).ForegroundAlpha = (Alpha) 2;
    ((UltraDateTimeEditor) this.Verisk_dtORMTermination).ButtonAppearance = (AppearanceBase) appearance66;
    ((UltraDateTimeEditor) this.Verisk_dtORMTermination).DateTime = new DateTime(2022, 4, 25, 0, 0, 0, 0);
    ((Control) this.Verisk_dtORMTermination).Location = new Point(148, 370);
    this.Verisk_dtORMTermination.MGAStyle = (MGAStyles) 2;
    ((Control) this.Verisk_dtORMTermination).Name = "Verisk_dtORMTermination";
    ((Control) this.Verisk_dtORMTermination).Size = new Size(100, 20);
    ((Control) this.Verisk_dtORMTermination).TabIndex = 120;
    ((UltraControlBase) this.Verisk_dtORMTermination).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.Verisk_dtORMTermination).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDateTimeEditor) this.Verisk_dtORMTermination).Value = (object) new DateTime(2022, 4, 25, 0, 0, 0, 0);
    this.Verisk_label11.AutoSize = true;
    this.Verisk_label11.BackColor = Color.Transparent;
    this.Verisk_label11.ForeColor = SystemColors.ControlText;
    this.Verisk_label11.Location = new Point(10, 350);
    this.Verisk_label11.Name = "Verisk_label11";
    this.Verisk_label11.Size = new Size(80 /*0x50*/, 13);
    this.Verisk_label11.TabIndex = 118;
    this.Verisk_label11.Text = "ORM Indicator:";
    ((UltraCombo) this.Verisk_cboORMIndicator).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraCombo) this.Verisk_cboORMIndicator).DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.Verisk_cboORMIndicator).Location = new Point(148, 345);
    this.Verisk_cboORMIndicator.MGAStyle = (MGAStyles) 2;
    ((Control) this.Verisk_cboORMIndicator).Name = "Verisk_cboORMIndicator";
    ((Control) this.Verisk_cboORMIndicator).Size = new Size(161, 21);
    ((Control) this.Verisk_cboORMIndicator).TabIndex = 119;
    ((UltraControlBase) this.Verisk_cboORMIndicator).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.Verisk_cboORMIndicator).UseOsThemes = (DefaultableBoolean) 2;
    this.Verisk_label10.AutoSize = true;
    this.Verisk_label10.BackColor = Color.Transparent;
    this.Verisk_label10.Location = new Point(8, 325);
    this.Verisk_label10.Name = "Verisk_label10";
    this.Verisk_label10.Size = new Size(105, 13);
    this.Verisk_label10.TabIndex = 108;
    this.Verisk_label10.Text = "No Fault Policy Limit:";
    this.Verisk_label9.AutoSize = true;
    this.Verisk_label9.BackColor = Color.Transparent;
    this.Verisk_label9.ForeColor = SystemColors.ControlText;
    this.Verisk_label9.Location = new Point(10, 229);
    this.Verisk_label9.Name = "Verisk_label9";
    this.Verisk_label9.Size = new Size(107, 13);
    this.Verisk_label9.TabIndex = 115;
    this.Verisk_label9.Text = "Approval Comments:";
    ((AppearanceBase) appearance67).BackColor = Color.White;
    ((AppearanceBase) appearance67).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance67).ForeColor = Color.Black;
    ((TextEditorControlBase) this.Verisk_txtApprovalComments).Appearance = (AppearanceBase) appearance67;
    ((Control) this.Verisk_txtApprovalComments).BackColor = Color.White;
    ((Control) this.Verisk_txtApprovalComments).Location = new Point(148, 226);
    this.Verisk_txtApprovalComments.MGAStyle = (MGAStyles) 2;
    ((UltraTextEditor) this.Verisk_txtApprovalComments).Multiline = true;
    ((Control) this.Verisk_txtApprovalComments).Name = "Verisk_txtApprovalComments";
    ((Control) this.Verisk_txtApprovalComments).Size = new Size(322, 91);
    ((Control) this.Verisk_txtApprovalComments).TabIndex = 116;
    ((UltraControlBase) this.Verisk_txtApprovalComments).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.Verisk_txtApprovalComments).UseOsThemes = (DefaultableBoolean) 2;
    this.Verisk_label8.AutoSize = true;
    this.Verisk_label8.BackColor = Color.Transparent;
    this.Verisk_label8.ForeColor = SystemColors.ControlText;
    this.Verisk_label8.Location = new Point(10, 206);
    this.Verisk_label8.Name = "Verisk_label8";
    this.Verisk_label8.Size = new Size(100, 13);
    this.Verisk_label8.TabIndex = 113;
    this.Verisk_label8.Text = "Medicare Approval:";
    ((UltraCombo) this.Verisk_cboMedicareApproval).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraCombo) this.Verisk_cboMedicareApproval).DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.Verisk_cboMedicareApproval).Location = new Point(148, 201);
    this.Verisk_cboMedicareApproval.MGAStyle = (MGAStyles) 2;
    ((Control) this.Verisk_cboMedicareApproval).Name = "Verisk_cboMedicareApproval";
    ((Control) this.Verisk_cboMedicareApproval).Size = new Size(161, 21);
    ((Control) this.Verisk_cboMedicareApproval).TabIndex = 114;
    ((UltraControlBase) this.Verisk_cboMedicareApproval).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.Verisk_cboMedicareApproval).UseOsThemes = (DefaultableBoolean) 2;
    this.Verisk_label1.AutoSize = true;
    this.Verisk_label1.BackColor = Color.Transparent;
    this.Verisk_label1.ForeColor = SystemColors.ControlText;
    this.Verisk_label1.Location = new Point(10, 26);
    this.Verisk_label1.Name = "Verisk_label1";
    this.Verisk_label1.Size = new Size(86, 13);
    this.Verisk_label1.TabIndex = 99;
    this.Verisk_label1.Text = "Insurance Type:";
    ((UltraCombo) this.Verisk_cboInsuranceType).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraCombo) this.Verisk_cboInsuranceType).DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.Verisk_cboInsuranceType).Location = new Point(148, 24);
    this.Verisk_cboInsuranceType.MGAStyle = (MGAStyles) 2;
    ((Control) this.Verisk_cboInsuranceType).Name = "Verisk_cboInsuranceType";
    ((Control) this.Verisk_cboInsuranceType).Size = new Size(161, 21);
    ((Control) this.Verisk_cboInsuranceType).TabIndex = 100;
    ((UltraControlBase) this.Verisk_cboInsuranceType).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.Verisk_cboInsuranceType).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance68).BackColor = Color.White;
    ((AppearanceBase) appearance68).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance68).ForeColor = Color.Black;
    ((TextEditorControlBase) this.Verisk_txtHICNMBI).Appearance = (AppearanceBase) appearance68;
    ((Control) this.Verisk_txtHICNMBI).BackColor = Color.White;
    ((Control) this.Verisk_txtHICNMBI).Location = new Point(148, 177);
    ((TextEditorControlBase) this.Verisk_txtHICNMBI).MaxLength = 12;
    this.Verisk_txtHICNMBI.MGAStyle = (MGAStyles) 2;
    ((Control) this.Verisk_txtHICNMBI).Name = "Verisk_txtHICNMBI";
    ((Control) this.Verisk_txtHICNMBI).Size = new Size(161, 20);
    ((Control) this.Verisk_txtHICNMBI).TabIndex = 112 /*0x70*/;
    ((UltraControlBase) this.Verisk_txtHICNMBI).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.Verisk_txtHICNMBI).UseOsThemes = (DefaultableBoolean) 2;
    this.Verisk_label7.AutoSize = true;
    this.Verisk_label7.BackColor = Color.Transparent;
    this.Verisk_label7.Location = new Point(10, 180);
    this.Verisk_label7.Name = "Verisk_label7";
    this.Verisk_label7.Size = new Size(115, 13);
    this.Verisk_label7.TabIndex = 111;
    this.Verisk_label7.Text = "HICN Party HICN/MBI:";
    this.Verisk_label6.AutoSize = true;
    this.Verisk_label6.BackColor = Color.Transparent;
    this.Verisk_label6.Location = new Point(10, 155);
    this.Verisk_label6.Name = "Verisk_label6";
    this.Verisk_label6.Size = new Size(134, 13);
    this.Verisk_label6.TabIndex = 109;
    this.Verisk_label6.Text = "Injured Party/Death Date:";
    ((AppearanceBase) appearance69).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraDateTimeEditor) this.Verisk_dtInjuredDeathDate).Appearance = (AppearanceBase) appearance69;
    ((AppearanceBase) appearance70).AlphaLevel = (short) 14;
    ((AppearanceBase) appearance70).BackColor = Color.FromArgb(0, 0, 246, 253);
    ((AppearanceBase) appearance70).BackColor2 = Color.FromArgb(133, 162, 221);
    ((AppearanceBase) appearance70).BackColorAlpha = (Alpha) 2;
    ((AppearanceBase) appearance70).BackGradientAlignment = (GradientAlignment) 4;
    ((AppearanceBase) appearance70).BackGradientStyle = (GradientStyle) 5;
    ((AppearanceBase) appearance70).BorderAlpha = (Alpha) 1;
    ((AppearanceBase) appearance70).BorderColor = Color.FromArgb(78, 122, 171);
    ((AppearanceBase) appearance70).ForeColor = Color.FromArgb(49, 85, 153);
    ((AppearanceBase) appearance70).ForegroundAlpha = (Alpha) 2;
    ((UltraDateTimeEditor) this.Verisk_dtInjuredDeathDate).ButtonAppearance = (AppearanceBase) appearance70;
    ((UltraDateTimeEditor) this.Verisk_dtInjuredDeathDate).DateTime = new DateTime(2022, 4, 25, 0, 0, 0, 0);
    ((Control) this.Verisk_dtInjuredDeathDate).Location = new Point(148, 153);
    this.Verisk_dtInjuredDeathDate.MGAStyle = (MGAStyles) 2;
    ((Control) this.Verisk_dtInjuredDeathDate).Name = "Verisk_dtInjuredDeathDate";
    ((Control) this.Verisk_dtInjuredDeathDate).Size = new Size(100, 20);
    ((Control) this.Verisk_dtInjuredDeathDate).TabIndex = 110;
    ((UltraControlBase) this.Verisk_dtInjuredDeathDate).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.Verisk_dtInjuredDeathDate).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDateTimeEditor) this.Verisk_dtInjuredDeathDate).Value = (object) new DateTime(2022, 4, 25, 0, 0, 0, 0);
    ((AppearanceBase) appearance71).BackColor = Color.White;
    ((AppearanceBase) appearance71).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance71).ForeColor = Color.Black;
    ((TextEditorControlBase) this.Verisk_txtICDCode).Appearance = (AppearanceBase) appearance71;
    ((Control) this.Verisk_txtICDCode).BackColor = Color.White;
    ((Control) this.Verisk_txtICDCode).Location = new Point(148, 97);
    ((TextEditorControlBase) this.Verisk_txtICDCode).MaxLength = 7;
    this.Verisk_txtICDCode.MGAStyle = (MGAStyles) 2;
    ((Control) this.Verisk_txtICDCode).Name = "Verisk_txtICDCode";
    ((Control) this.Verisk_txtICDCode).Size = new Size(161, 20);
    ((Control) this.Verisk_txtICDCode).TabIndex = 107;
    ((UltraControlBase) this.Verisk_txtICDCode).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.Verisk_txtICDCode).UseOsThemes = (DefaultableBoolean) 2;
    this.Verisk_label4.AutoSize = true;
    this.Verisk_label4.BackColor = Color.Transparent;
    this.Verisk_label4.Location = new Point(10, 97);
    this.Verisk_label4.Name = "Verisk_label4";
    this.Verisk_label4.Size = new Size(57, 13);
    this.Verisk_label4.TabIndex = 106;
    this.Verisk_label4.Text = "ICD Code:";
    this.Verisk_label3.AutoSize = true;
    this.Verisk_label3.BackColor = Color.Transparent;
    this.Verisk_label3.Location = new Point(10, 73);
    this.Verisk_label3.Name = "Verisk_label3";
    this.Verisk_label3.Size = new Size(117, 13);
    this.Verisk_label3.TabIndex = 104;
    this.Verisk_label3.Text = "Funding Delayed Date:";
    ((AppearanceBase) appearance72).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraDateTimeEditor) this.Verisk_dtFundingDelayed).Appearance = (AppearanceBase) appearance72;
    ((AppearanceBase) appearance73).AlphaLevel = (short) 14;
    ((AppearanceBase) appearance73).BackColor = Color.FromArgb(0, 0, 246, 253);
    ((AppearanceBase) appearance73).BackColor2 = Color.FromArgb(133, 162, 221);
    ((AppearanceBase) appearance73).BackColorAlpha = (Alpha) 2;
    ((AppearanceBase) appearance73).BackGradientAlignment = (GradientAlignment) 4;
    ((AppearanceBase) appearance73).BackGradientStyle = (GradientStyle) 5;
    ((AppearanceBase) appearance73).BorderAlpha = (Alpha) 1;
    ((AppearanceBase) appearance73).BorderColor = Color.FromArgb(78, 122, 171);
    ((AppearanceBase) appearance73).ForeColor = Color.FromArgb(49, 85, 153);
    ((AppearanceBase) appearance73).ForegroundAlpha = (Alpha) 2;
    ((UltraDateTimeEditor) this.Verisk_dtFundingDelayed).ButtonAppearance = (AppearanceBase) appearance73;
    ((UltraDateTimeEditor) this.Verisk_dtFundingDelayed).DateTime = new DateTime(2022, 4, 25, 0, 0, 0, 0);
    ((Control) this.Verisk_dtFundingDelayed).Location = new Point(148, 73);
    this.Verisk_dtFundingDelayed.MGAStyle = (MGAStyles) 2;
    ((Control) this.Verisk_dtFundingDelayed).Name = "Verisk_dtFundingDelayed";
    ((Control) this.Verisk_dtFundingDelayed).Size = new Size(100, 20);
    ((Control) this.Verisk_dtFundingDelayed).TabIndex = 105;
    ((UltraControlBase) this.Verisk_dtFundingDelayed).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.Verisk_dtFundingDelayed).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDateTimeEditor) this.Verisk_dtFundingDelayed).Value = (object) new DateTime(2022, 4, 25, 0, 0, 0, 0);
    this.Verisk_label2.AutoSize = true;
    this.Verisk_label2.BackColor = Color.Transparent;
    this.Verisk_label2.Location = new Point(10, 50);
    this.Verisk_label2.Name = "Verisk_label2";
    this.Verisk_label2.Size = new Size(76, 13);
    this.Verisk_label2.TabIndex = 102;
    this.Verisk_label2.Text = "Exhaust Date:";
    ((AppearanceBase) appearance74).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraDateTimeEditor) this.Verisk_dtExhaustDate).Appearance = (AppearanceBase) appearance74;
    ((AppearanceBase) appearance75).AlphaLevel = (short) 14;
    ((AppearanceBase) appearance75).BackColor = Color.FromArgb(0, 0, 246, 253);
    ((AppearanceBase) appearance75).BackColor2 = Color.FromArgb(133, 162, 221);
    ((AppearanceBase) appearance75).BackColorAlpha = (Alpha) 2;
    ((AppearanceBase) appearance75).BackGradientAlignment = (GradientAlignment) 4;
    ((AppearanceBase) appearance75).BackGradientStyle = (GradientStyle) 5;
    ((AppearanceBase) appearance75).BorderAlpha = (Alpha) 1;
    ((AppearanceBase) appearance75).BorderColor = Color.FromArgb(78, 122, 171);
    ((AppearanceBase) appearance75).ForeColor = Color.FromArgb(49, 85, 153);
    ((AppearanceBase) appearance75).ForegroundAlpha = (Alpha) 2;
    ((UltraDateTimeEditor) this.Verisk_dtExhaustDate).ButtonAppearance = (AppearanceBase) appearance75;
    ((UltraDateTimeEditor) this.Verisk_dtExhaustDate).DateTime = new DateTime(2022, 4, 25, 0, 0, 0, 0);
    ((Control) this.Verisk_dtExhaustDate).Location = new Point(148, 49);
    this.Verisk_dtExhaustDate.MGAStyle = (MGAStyles) 2;
    ((Control) this.Verisk_dtExhaustDate).Name = "Verisk_dtExhaustDate";
    ((Control) this.Verisk_dtExhaustDate).Size = new Size(100, 20);
    ((Control) this.Verisk_dtExhaustDate).TabIndex = 103;
    ((UltraControlBase) this.Verisk_dtExhaustDate).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.Verisk_dtExhaustDate).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDateTimeEditor) this.Verisk_dtExhaustDate).Value = (object) new DateTime(2022, 4, 25, 0, 0, 0, 0);
    ((Control) this.tabControlClaimants).Controls.Add((Control) this.ultraTabSharedControlsPage2);
    ((Control) this.tabControlClaimants).Controls.Add((Control) this.tabPageClaimant);
    ((Control) this.tabControlClaimants).Controls.Add((Control) this.tabPageLegal);
    ((Control) this.tabControlClaimants).Controls.Add((Control) this.tabPageClaimSpecifications);
    ((Control) this.tabControlClaimants).Controls.Add((Control) this.tabPageClaimantReservesPayments);
    ((Control) this.tabControlClaimants).Controls.Add((Control) this.ultraTabPageControl1);
    ((Control) this.tabControlClaimants).Controls.Add((Control) this.ultraTabPageControlVerisk);
    ((Control) this.tabControlClaimants).Dock = DockStyle.Fill;
    ((Control) this.tabControlClaimants).Location = new Point(0, 0);
    ((Control) this.tabControlClaimants).Name = "tabControlClaimants";
    ((UltraTabControlBase) this.tabControlClaimants).SharedControlsPage = this.ultraTabSharedControlsPage2;
    ((Control) this.tabControlClaimants).Size = new Size(924, 574);
    ((UltraTabControlBase) this.tabControlClaimants).Style = (UltraTabControlStyle) 13;
    ((Control) this.tabControlClaimants).TabIndex = 0;
    ((UltraTabControlBase) this.tabControlClaimants).TabLayoutStyle = (TabLayoutStyle) 2;
    ((UltraTabControlBase) this.tabControlClaimants).TabOrientation = (TabOrientation) 1;
    ((AppearanceBase) appearance76).Image = (object) Resources.AddClaimantSmall;
    ultraTab1.Appearance = (AppearanceBase) appearance76;
    ultraTab1.TabPage = this.tabPageClaimant;
    ultraTab1.Text = "Claimant Information";
    ((AppearanceBase) appearance77).Image = (object) Resources.ClaimSpecifications;
    ultraTab2.Appearance = (AppearanceBase) appearance77;
    ultraTab2.TabPage = this.tabPageClaimSpecifications;
    ultraTab2.Text = "Claim Specifications";
    ((AppearanceBase) appearance78).Image = (object) Resources.SettlementTypesSmall;
    ultraTab3.Appearance = (AppearanceBase) appearance78;
    ultraTab3.TabPage = this.tabPageLegal;
    ultraTab3.Text = "Legal / Attorney";
    ((KeyedSubObjectBase) ultraTab3).Key = "LegalAttorney";
    ((AppearanceBase) appearance79).Image = (object) Resources.Coins;
    ultraTab4.Appearance = (AppearanceBase) appearance79;
    ((KeyedSubObjectBase) ultraTab4).Key = "ReservesPayments";
    ultraTab4.TabPage = this.tabPageClaimantReservesPayments;
    ultraTab4.Text = "Reserves/Payments";
    ((AppearanceBase) appearance80).Image = (object) Resources.interCompanyTransfer1;
    ultraTab5.Appearance = (AppearanceBase) appearance80;
    ((KeyedSubObjectBase) ultraTab5).Key = "Exposure";
    ultraTab5.TabPage = this.ultraTabPageControl1;
    ultraTab5.Text = "Vehicles / Locations";
    ultraTab5.Visible = false;
    ((AppearanceBase) appearance81).Image = (object) Resources.pill;
    ultraTab6.Appearance = (AppearanceBase) appearance81;
    ((KeyedSubObjectBase) ultraTab6).Key = "VERISK";
    ultraTab6.TabPage = this.ultraTabPageControlVerisk;
    ((SubObjectBase) ultraTab6).Tag = (object) "VERISK";
    ultraTab6.Text = "Medicare Eligibility";
    ultraTab6.Visible = false;
    ((UltraTabControlBase) this.tabControlClaimants).Tabs.AddRange(new UltraTab[6]
    {
      ultraTab1,
      ultraTab2,
      ultraTab3,
      ultraTab4,
      ultraTab5,
      ultraTab6
    });
    ((UltraTabControlBase) this.tabControlClaimants).ViewStyle = (ViewStyle) 4;
    ((Control) this.ultraTabSharedControlsPage2).Location = new Point(-10000, -10000);
    ((Control) this.ultraTabSharedControlsPage2).Name = "ultraTabSharedControlsPage2";
    ((Control) this.ultraTabSharedControlsPage2).Size = new Size(922, 551);
    this.FormClaimant_Fill_Panel.Controls.Add((Control) this.tabControlClaimants);
    this.FormClaimant_Fill_Panel.Cursor = Cursors.Default;
    this.FormClaimant_Fill_Panel.Dock = DockStyle.Fill;
    this.FormClaimant_Fill_Panel.Location = new Point(0, 46);
    this.FormClaimant_Fill_Panel.Name = "FormClaimant_Fill_Panel";
    this.FormClaimant_Fill_Panel.Size = new Size(924, 574);
    this.FormClaimant_Fill_Panel.TabIndex = 0;
    ((Control) this._FormClaimant_Toolbars_Dock_Area_Left).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormClaimant_Toolbars_Dock_Area_Left).BackColor = SystemColors.Control;
    this._FormClaimant_Toolbars_Dock_Area_Left.DockedPosition = (DockedPosition) 2;
    ((Control) this._FormClaimant_Toolbars_Dock_Area_Left).ForeColor = SystemColors.ControlText;
    ((Control) this._FormClaimant_Toolbars_Dock_Area_Left).Location = new Point(0, 46);
    ((Control) this._FormClaimant_Toolbars_Dock_Area_Left).Name = "_FormClaimant_Toolbars_Dock_Area_Left";
    ((Control) this._FormClaimant_Toolbars_Dock_Area_Left).Size = new Size(0, 574);
    this._FormClaimant_Toolbars_Dock_Area_Left.ToolbarsManager = this.ultraToolbarsManager1;
    this.ultraToolbarsManager1.DesignerFlags = 1;
    this.ultraToolbarsManager1.DockWithinContainer = (Control) this;
    this.ultraToolbarsManager1.DockWithinContainerBaseType = typeof (Form);
    this.ultraToolbarsManager1.MdiMergeable = false;
    this.ultraToolbarsManager1.ShowFullMenusDelay = 500;
    ultraToolbar.DockedColumn = 0;
    ultraToolbar.DockedRow = 0;
    ultraToolbar.FloatingLocation = new Point(223, 181);
    ultraToolbar.FloatingSize = new Size(389, 76);
    ((ToolBase) buttonTool2).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) buttonTool4).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) buttonTool5).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) buttonTool7).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) buttonTool8).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) buttonTool9).InstanceProps.IsFirstInGroup = true;
    ((UltraToolbarBase) ultraToolbar).NonInheritedTools.AddRange(new ToolBase[10]
    {
      (ToolBase) buttonTool1,
      (ToolBase) buttonTool2,
      (ToolBase) buttonTool3,
      (ToolBase) buttonTool4,
      (ToolBase) buttonTool5,
      (ToolBase) buttonTool6,
      (ToolBase) buttonTool7,
      (ToolBase) buttonTool8,
      (ToolBase) buttonTool9,
      (ToolBase) buttonTool10
    });
    ultraToolbar.Settings.AllowCustomize = (DefaultableBoolean) 2;
    ultraToolbar.Settings.AllowDockBottom = (DefaultableBoolean) 2;
    ultraToolbar.Settings.AllowDockLeft = (DefaultableBoolean) 2;
    ultraToolbar.Settings.AllowDockRight = (DefaultableBoolean) 2;
    ultraToolbar.Settings.AllowDockTop = (DefaultableBoolean) 2;
    ultraToolbar.Settings.AllowFloating = (DefaultableBoolean) 2;
    ultraToolbar.Settings.AllowHiding = (DefaultableBoolean) 2;
    ultraToolbar.Settings.CaptionPlacement = (TextPlacement) 2;
    ultraToolbar.Text = "MainToolbar";
    this.ultraToolbarsManager1.Toolbars.AddRange(new UltraToolbar[1]
    {
      ultraToolbar
    });
    this.ultraToolbarsManager1.ToolbarSettings.AllowCustomize = (DefaultableBoolean) 2;
    this.ultraToolbarsManager1.ToolbarSettings.AllowDockBottom = (DefaultableBoolean) 2;
    this.ultraToolbarsManager1.ToolbarSettings.AllowDockLeft = (DefaultableBoolean) 2;
    this.ultraToolbarsManager1.ToolbarSettings.AllowDockRight = (DefaultableBoolean) 2;
    this.ultraToolbarsManager1.ToolbarSettings.AllowDockTop = (DefaultableBoolean) 2;
    this.ultraToolbarsManager1.ToolbarSettings.AllowFloating = (DefaultableBoolean) 2;
    this.ultraToolbarsManager1.ToolbarSettings.AllowHiding = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance82).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    ((AppearanceBase) appearance82).BackColor2 = Color.White;
    ((AppearanceBase) appearance82).BackGradientAlignment = (GradientAlignment) 1;
    ((AppearanceBase) appearance82).BackGradientStyle = (GradientStyle) 14;
    ((SettingsBase) this.ultraToolbarsManager1.ToolbarSettings).Appearance = (AppearanceBase) appearance82;
    this.ultraToolbarsManager1.ToolbarSettings.FillEntireRow = (DefaultableBoolean) 1;
    this.ultraToolbarsManager1.ToolbarSettings.GrabHandleStyle = (GrabHandleStyle) 1;
    ((SettingsBase) this.ultraToolbarsManager1.ToolbarSettings).ToolDisplayStyle = (ToolDisplayStyle) 4;
    ((AppearanceBase) appearance83).Image = (object) Resources.AddClaimantSmall;
    ((ToolPropsBase) ((ToolBase) buttonTool11).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance83;
    ((ToolPropsBase) ((ToolBase) buttonTool11).SharedPropsInternal).Caption = "Add Claimant";
    ((ToolBase) buttonTool11).SharedPropsInternal.Category = "Claimants";
    ((ToolPropsBase) ((ToolBase) buttonTool11).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((ToolBase) buttonTool11).SharedPropsInternal.Shortcut = Shortcut.ShiftF2;
    ((ToolBase) buttonTool11).SharedPropsInternal.ToolTipText = "Click here to add a new claimant.";
    ((ToolBase) buttonTool11).SharedPropsInternal.ToolTipTitle = "Add Claimant (Shift+F2)";
    ((AppearanceBase) appearance84).Image = (object) Resources.AddReserve;
    ((ToolPropsBase) ((ToolBase) buttonTool12).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance84;
    ((ToolPropsBase) ((ToolBase) buttonTool12).SharedPropsInternal).Caption = "Add Reserve";
    ((ToolBase) buttonTool12).SharedPropsInternal.Category = "Reservers/Payments";
    ((ToolPropsBase) ((ToolBase) buttonTool12).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((ToolBase) buttonTool12).SharedPropsInternal.Shortcut = Shortcut.ShiftF5;
    ((ToolBase) buttonTool12).SharedPropsInternal.ToolTipText = "Click here to add a new reserve.";
    ((ToolBase) buttonTool12).SharedPropsInternal.ToolTipTitle = "Add Reserve (Shift+F5)";
    ((AppearanceBase) appearance85).Image = (object) Resources.AddReserve;
    ((ToolPropsBase) ((ToolBase) buttonTool13).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance85;
    ((ToolPropsBase) ((ToolBase) buttonTool13).SharedPropsInternal).Caption = "Add Payment";
    ((ToolBase) buttonTool13).SharedPropsInternal.Category = "Reservers/Payments";
    ((ToolPropsBase) ((ToolBase) buttonTool13).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((ToolBase) buttonTool13).SharedPropsInternal.Enabled = false;
    ((ToolBase) buttonTool13).SharedPropsInternal.Shortcut = Shortcut.ShiftF6;
    ((ToolBase) buttonTool13).SharedPropsInternal.ToolTipText = "Click here to add a new payment.";
    ((ToolBase) buttonTool13).SharedPropsInternal.ToolTipTitle = "Add Payment (Shift+F6)";
    ((AppearanceBase) appearance86).Image = (object) Resources.Save;
    ((ToolPropsBase) ((ToolBase) buttonTool14).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance86;
    ((ToolPropsBase) ((ToolBase) buttonTool14).SharedPropsInternal).Caption = "Save";
    ((ToolBase) buttonTool14).SharedPropsInternal.Category = "GeneralOptions";
    ((ToolPropsBase) ((ToolBase) buttonTool14).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((ToolBase) buttonTool14).SharedPropsInternal.Shortcut = Shortcut.ShiftF1;
    ((ToolBase) buttonTool14).SharedPropsInternal.ToolTipText = "Click here to save the changes you have made to the current claim.";
    ((ToolBase) buttonTool14).SharedPropsInternal.ToolTipTitle = "Save Claim Changes (Shift+F1)";
    ((AppearanceBase) appearance87).Image = (object) Resources.CloseClaim;
    ((ToolPropsBase) ((ToolBase) buttonTool15).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance87;
    ((ToolPropsBase) ((ToolBase) buttonTool15).SharedPropsInternal).Caption = "Close Claim";
    ((ToolBase) buttonTool15).SharedPropsInternal.Category = "GeneralOptions";
    ((ToolPropsBase) ((ToolBase) buttonTool15).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((ToolBase) buttonTool15).SharedPropsInternal.Enabled = false;
    ((ToolBase) buttonTool15).SharedPropsInternal.Shortcut = Shortcut.ShiftF8;
    ((ToolBase) buttonTool15).SharedPropsInternal.ToolTipText = "Click here to close the claim.";
    ((ToolBase) buttonTool15).SharedPropsInternal.ToolTipTitle = "Close claim (Shift+F8)";
    ((AppearanceBase) appearance88).Image = (object) Resources.ReopenClaim;
    ((ToolPropsBase) ((ToolBase) buttonTool16).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance88;
    ((ToolPropsBase) ((ToolBase) buttonTool16).SharedPropsInternal).Caption = "Reopen Claim";
    ((ToolBase) buttonTool16).SharedPropsInternal.Category = "GeneralOptions";
    ((ToolBase) buttonTool16).SharedPropsInternal.Enabled = false;
    ((ToolBase) buttonTool16).SharedPropsInternal.ToolTipText = "Click here to re-open the claim.";
    ((ToolBase) buttonTool16).SharedPropsInternal.ToolTipTitle = "Re-Open Claim (Shift+F9)";
    ((AppearanceBase) appearance89).Image = (object) Resources.EditClaimant;
    ((ToolPropsBase) ((ToolBase) buttonTool17).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance89;
    ((ToolPropsBase) ((ToolBase) buttonTool17).SharedPropsInternal).Caption = "Clear Claimant Entry";
    ((ToolBase) buttonTool17).SharedPropsInternal.Category = "Claimants";
    ((ToolPropsBase) ((ToolBase) popupMenuTool1).SharedPropsInternal).Caption = "GridContextMenu";
    ((ToolBase) popupMenuTool1).SharedPropsInternal.Category = "GridContextMenu";
    ((ToolBase) buttonTool19).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) buttonTool21).InstanceProps.IsFirstInGroup = true;
    ((ToolsCollectionBase) popupMenuTool1.Tools).AddRange(new ToolBase[4]
    {
      (ToolBase) buttonTool18,
      (ToolBase) buttonTool19,
      (ToolBase) buttonTool20,
      (ToolBase) buttonTool21
    });
    ((AppearanceBase) appearance90).Image = (object) Resources.View;
    ((ToolPropsBase) ((ToolBase) buttonTool22).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance90;
    ((ToolPropsBase) ((ToolBase) buttonTool22).SharedPropsInternal).Caption = "View Check Information";
    ((ToolBase) buttonTool22).SharedPropsInternal.Category = "GridContextMenu";
    ((AppearanceBase) appearance91).Image = (object) Resources.View;
    ((ToolPropsBase) ((ToolBase) buttonTool23).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance91;
    ((ToolPropsBase) ((ToolBase) buttonTool23).SharedPropsInternal).Caption = "View Check Information";
    ((ToolBase) buttonTool23).SharedPropsInternal.Category = "GeneralOptions";
    ((AppearanceBase) appearance92).Image = (object) Resources.DeleteClaimSmall;
    ((ToolPropsBase) ((ToolBase) buttonTool24).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance92;
    ((ToolPropsBase) ((ToolBase) buttonTool24).SharedPropsInternal).Caption = "Delete Payment";
    ((AppearanceBase) appearance93).Image = (object) Resources.PaymentReturn;
    ((ToolPropsBase) ((ToolBase) buttonTool25).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance93;
    ((ToolPropsBase) ((ToolBase) buttonTool25).SharedPropsInternal).Caption = "Payment Return";
    ((ToolBase) buttonTool25).SharedPropsInternal.Category = "Reservers/Payments";
    ((ToolPropsBase) ((ToolBase) popupMenuTool2).SharedPropsInternal).Caption = "Edit Reserve/Payment Type";
    ((ToolBase) popupMenuTool2).SharedPropsInternal.Category = "GridContextMenu";
    ((AppearanceBase) appearance94).Image = componentResourceManager.GetObject("appearance81.Image");
    ((ToolPropsBase) ((ToolBase) buttonTool26).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance94;
    ((ToolPropsBase) ((ToolBase) buttonTool26).SharedPropsInternal).Caption = "Delete Reserve/Payment";
    ((AppearanceBase) appearance95).Image = (object) Resources.Edit;
    ((ToolPropsBase) ((ToolBase) buttonTool27).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance95;
    ((ToolPropsBase) ((ToolBase) buttonTool27).SharedPropsInternal).Caption = "Change Date";
    ((AppearanceBase) appearance96).Image = (object) Resources.Edit;
    ((ToolPropsBase) ((ToolBase) buttonTool28).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance96;
    ((ToolPropsBase) ((ToolBase) buttonTool28).SharedPropsInternal).Caption = "Edit Comment";
    ((ToolPropsBase) ((ToolBase) buttonTool28).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((AppearanceBase) appearance97).Image = (object) Resources.Edit;
    ((ToolPropsBase) ((ToolBase) buttonTool29).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance97;
    ((ToolPropsBase) ((ToolBase) buttonTool29).SharedPropsInternal).Caption = "Edit Type or Coverage Type";
    ((ToolBase) buttonTool29).SharedPropsInternal.Category = "GridContextMenu";
    ((ToolsCollectionBase) this.ultraToolbarsManager1.Tools).AddRange(new ToolBase[17]
    {
      (ToolBase) buttonTool11,
      (ToolBase) buttonTool12,
      (ToolBase) buttonTool13,
      (ToolBase) buttonTool14,
      (ToolBase) buttonTool15,
      (ToolBase) buttonTool16,
      (ToolBase) buttonTool17,
      (ToolBase) popupMenuTool1,
      (ToolBase) buttonTool22,
      (ToolBase) buttonTool23,
      (ToolBase) buttonTool24,
      (ToolBase) buttonTool25,
      (ToolBase) popupMenuTool2,
      (ToolBase) buttonTool26,
      (ToolBase) buttonTool27,
      (ToolBase) buttonTool28,
      (ToolBase) buttonTool29
    });
    this.ultraToolbarsManager1.BeforeToolDropdown += new BeforeToolDropdownEventHandler(this.ultraToolbarsManager1_BeforeToolDropdown);
    this.ultraToolbarsManager1.ToolClick += new ToolClickEventHandler(this.ultraToolbarsManager1_ToolClick);
    ((Control) this._FormClaimant_Toolbars_Dock_Area_Right).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormClaimant_Toolbars_Dock_Area_Right).BackColor = SystemColors.Control;
    this._FormClaimant_Toolbars_Dock_Area_Right.DockedPosition = (DockedPosition) 3;
    ((Control) this._FormClaimant_Toolbars_Dock_Area_Right).ForeColor = SystemColors.ControlText;
    ((Control) this._FormClaimant_Toolbars_Dock_Area_Right).Location = new Point(924, 46);
    ((Control) this._FormClaimant_Toolbars_Dock_Area_Right).Name = "_FormClaimant_Toolbars_Dock_Area_Right";
    ((Control) this._FormClaimant_Toolbars_Dock_Area_Right).Size = new Size(0, 574);
    this._FormClaimant_Toolbars_Dock_Area_Right.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._FormClaimant_Toolbars_Dock_Area_Top).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormClaimant_Toolbars_Dock_Area_Top).BackColor = SystemColors.Control;
    this._FormClaimant_Toolbars_Dock_Area_Top.DockedPosition = (DockedPosition) 0;
    ((Control) this._FormClaimant_Toolbars_Dock_Area_Top).ForeColor = SystemColors.ControlText;
    ((Control) this._FormClaimant_Toolbars_Dock_Area_Top).Location = new Point(0, 0);
    ((Control) this._FormClaimant_Toolbars_Dock_Area_Top).Name = "_FormClaimant_Toolbars_Dock_Area_Top";
    ((Control) this._FormClaimant_Toolbars_Dock_Area_Top).Size = new Size(924, 46);
    this._FormClaimant_Toolbars_Dock_Area_Top.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._FormClaimant_Toolbars_Dock_Area_Bottom).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormClaimant_Toolbars_Dock_Area_Bottom).BackColor = SystemColors.Control;
    this._FormClaimant_Toolbars_Dock_Area_Bottom.DockedPosition = (DockedPosition) 1;
    ((Control) this._FormClaimant_Toolbars_Dock_Area_Bottom).ForeColor = SystemColors.ControlText;
    ((Control) this._FormClaimant_Toolbars_Dock_Area_Bottom).Location = new Point(0, 620);
    ((Control) this._FormClaimant_Toolbars_Dock_Area_Bottom).Name = "_FormClaimant_Toolbars_Dock_Area_Bottom";
    ((Control) this._FormClaimant_Toolbars_Dock_Area_Bottom).Size = new Size(924, 0);
    this._FormClaimant_Toolbars_Dock_Area_Bottom.ToolbarsManager = this.ultraToolbarsManager1;
    this.dsClaimOptions1.DataSetName = "dsClaimOptions";
    this.dsClaimOptions1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.ultraToolTipManager1.AutoPopDelay = 50000;
    this.ultraToolTipManager1.ContainingControl = (Control) this;
    this.statusBar1.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.statusBar1).Location = new Point(0, 620);
    ((Control) this.statusBar1).Name = "statusBar1";
    ((AppearanceBase) appearance98).ForeColor = Color.Red;
    ((AppearanceBase) appearance98).ImageHAlign = (HAlign) 1;
    ((AppearanceBase) appearance98).TextHAlignAsString = "Center";
    ultraStatusPanel.Appearance = (AppearanceBase) appearance98;
    ultraStatusPanel.SizingMode = (PanelSizingMode) 3;
    ultraStatusPanel.Text = "OFAC Hit Detected - Compliance Approval Required";
    this.statusBar1.Panels.AddRange(new UltraStatusPanel[1]
    {
      ultraStatusPanel
    });
    ((Control) this.statusBar1).Size = new Size(924, 23);
    this.statusBar1.SizeGripVisible = (DefaultableBoolean) 2;
    ((Control) this.statusBar1).TabIndex = 5;
    ((UltraControlBase) this.statusBar1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.statusBar1).UseOsThemes = (DefaultableBoolean) 2;
    this.statusBar1.ViewStyle = (ViewStyle) 4;
    ((Control) this.statusBar1).Visible = false;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(924, 643);
    this.Controls.Add((Control) this.FormClaimant_Fill_Panel);
    this.Controls.Add((Control) this._FormClaimant_Toolbars_Dock_Area_Left);
    this.Controls.Add((Control) this._FormClaimant_Toolbars_Dock_Area_Right);
    this.Controls.Add((Control) this._FormClaimant_Toolbars_Dock_Area_Bottom);
    this.Controls.Add((Control) this.statusBar1);
    this.Controls.Add((Control) this._FormClaimant_Toolbars_Dock_Area_Top);
    this.Font = new Font("Tahoma", 8.25f);
    this.Name = nameof (FormClaimant);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Add/Edit Claimant";
    this.FormClosing += new FormClosingEventHandler(this.FormClaimant_FormClosing);
    this.Load += new EventHandler(this.FormClaimant_Load);
    ((Control) this.tabPageClaimant).ResumeLayout(false);
    ((Control) this.tabPageClaimant).PerformLayout();
    ((ISupportInitialize) this.checkClaimants_MedicareEligible).EndInit();
    ((ISupportInitialize) this.textClaimants_Comments).EndInit();
    ((ISupportInitialize) this.textClaimants_EmailAddress).EndInit();
    ((ISupportInitialize) this.checkClaimants_Closed).EndInit();
    ((ISupportInitialize) this.comboClaimants_Gender).EndInit();
    ((ISupportInitialize) this.dateTimeClaimants_DOB).EndInit();
    ((ISupportInitialize) this.maskedEditClaimants_SSNFEIN).EndInit();
    ((ISupportInitialize) this.textClaimants_UserDefinedClaimantsID).EndInit();
    ((ISupportInitialize) this.textClaimants_CorporationName).EndInit();
    ((ISupportInitialize) this.textClaimants_FirstName).EndInit();
    ((ISupportInitialize) this.textClaimants_MiddleName).EndInit();
    ((ISupportInitialize) this.textClaimants_LastName).EndInit();
    ((ISupportInitialize) this.checkClaimants_IsInsured).EndInit();
    ((ISupportInitialize) this.optionClaimants_ClaimantType).EndInit();
    ((Control) this.tabPageClaimSpecifications).ResumeLayout(false);
    ((Control) this.tabPageClaimSpecifications).PerformLayout();
    ((ISupportInitialize) this.dateTimeClaimant_DateDenied).EndInit();
    ((ISupportInitialize) this.gridClaimant_Coverages).EndInit();
    ((ISupportInitialize) this.dateTimeClaimants_OutsideInvestigatorHireDate).EndInit();
    ((ISupportInitialize) this.checkClaimants_Settled).EndInit();
    ((ISupportInitialize) this.comboClaimants_SettlementType).EndInit();
    ((ISupportInitialize) this.textClaimants_OutsideInvestigator).EndInit();
    ((ISupportInitialize) this.textClaimants_LastModifiedBy).EndInit();
    ((ISupportInitialize) this.dateTimeClaimants_LastModified).EndInit();
    ((ISupportInitialize) this.comboClaimants_OutsideAdjuster).EndInit();
    ((ISupportInitialize) this.textClaimant_EnteredBy).EndInit();
    ((ISupportInitialize) this.dateTimeClaimant_DateEntered).EndInit();
    ((ISupportInitialize) this.comboClaimants_ManagedCare).EndInit();
    ((ISupportInitialize) this.comboClaimants_LossType).EndInit();
    ((ISupportInitialize) this.comboClaimant_AccidentTypes).EndInit();
    ((ISupportInitialize) this.dateTimeClaimant_DateReported).EndInit();
    ((Control) this.tabPageLegal).ResumeLayout(false);
    ((Control) this.tabPageLegal).PerformLayout();
    ((ISupportInitialize) this.cboClaimantAttorney).EndInit();
    ((ISupportInitialize) this.cboDefenseAttorney).EndInit();
    ((ISupportInitialize) this.optionClaimantAttorneyEntityType).EndInit();
    ((ISupportInitialize) this.optionDefenseEntityType).EndInit();
    ((ISupportInitialize) this.textClaimants_ClaimantAttorneyFEIN).EndInit();
    ((ISupportInitialize) this.textClaimants_DefenseFEIN).EndInit();
    ((ISupportInitialize) this.textClaimants_DefenseAttorney).EndInit();
    ((ISupportInitialize) this.checkClaimants_PublishedDecision).EndInit();
    ((ISupportInitialize) this.textClaimants_Judge).EndInit();
    ((ISupportInitialize) this.textClaimants_ClaimantAttorney).EndInit();
    ((ISupportInitialize) this.textClaimants_ClaimantLawFirm).EndInit();
    ((ISupportInitialize) this.textClaimants_DefenseFirm).EndInit();
    ((ISupportInitialize) this.dateTimeClaimants_SuitAnswered).EndInit();
    ((ISupportInitialize) this.dateTimeClaimants_SuitServed).EndInit();
    ((ISupportInitialize) this.checkClaimants_SuitServed).EndInit();
    ((Control) this.tabPageClaimantReservesPayments).ResumeLayout(false);
    ((ISupportInitialize) this.gridClaimants_ReservePayments).EndInit();
    this.dsReservesPayments1.EndInit();
    ((Control) this.ultraTabPageControlVerisk).ResumeLayout(false);
    ((Control) this.ultraTabPageControlVerisk).PerformLayout();
    ((ISupportInitialize) this.Verisk_mgaNoFaultPolicyLimit).EndInit();
    ((ISupportInitialize) this.Verisk_cboRepType).EndInit();
    ((ISupportInitialize) this.Verisk_dtORMTermination).EndInit();
    ((ISupportInitialize) this.Verisk_cboORMIndicator).EndInit();
    ((ISupportInitialize) this.Verisk_txtApprovalComments).EndInit();
    ((ISupportInitialize) this.Verisk_cboMedicareApproval).EndInit();
    ((ISupportInitialize) this.Verisk_cboInsuranceType).EndInit();
    ((ISupportInitialize) this.Verisk_txtHICNMBI).EndInit();
    ((ISupportInitialize) this.Verisk_dtInjuredDeathDate).EndInit();
    ((ISupportInitialize) this.Verisk_txtICDCode).EndInit();
    ((ISupportInitialize) this.Verisk_dtFundingDelayed).EndInit();
    ((ISupportInitialize) this.Verisk_dtExhaustDate).EndInit();
    ((ISupportInitialize) this.tabControlClaimants).EndInit();
    ((Control) this.tabControlClaimants).ResumeLayout(false);
    this.FormClaimant_Fill_Panel.ResumeLayout(false);
    ((ISupportInitialize) this.ultraToolbarsManager1).EndInit();
    this.dsClaimOptions1.EndInit();
    ((ISupportInitialize) this.statusBar1).EndInit();
    this.ResumeLayout(false);
  }

  private struct Cached_AddressResolverProperties
  {
    public string ControlName;
    public string ControlTag;
    public string Address1;
    public string Address2;
    public string City;
    public string State;
    public string ZipCode;
  }

  private struct Cached_TextProperties
  {
    public string ControlName;
    public string ControlTag;
    public string Text;
  }

  private struct Cached_ComboProperties
  {
    public string ControlName;
    public string ControlTag;
    public string Text;
    public object Value;
  }
}
