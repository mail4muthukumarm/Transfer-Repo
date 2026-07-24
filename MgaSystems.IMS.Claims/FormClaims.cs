// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.FormClaims
// Assembly: MgaSystems.IMS.Claims, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FCD9D0B7-28CF-40B9-8EB7-297871E1AF5F
// Assembly location: F:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.Layout;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinMaskedEdit;
using Infragistics.Win.UltraWinScrollBar;
using Infragistics.Win.UltraWinTabControl;
using Infragistics.Win.UltraWinTabs;
using Infragistics.Win.UltraWinToolbars;
using Infragistics.Win.UltraWinToolTip;
using MGASystems.AddressResolver;
using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Claims.Properties;
using MGASystems.IMS.Claims.UserLog;
using MGASystems.IMS.DocumentAutomation.TemplateDocuments;
using MGASystems.IMS.NoteDocuments;
using MGASystems.IMS.NoteDocuments.NoteDiarySystem;
using MGASystems.IMS.Policies.PolicyDetail;
using MGASystems.IMS.Security;
using MgaSystems.IMS.WebIntegration.BingMaps;
using MGASystems.Tools;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.Layout;

#nullable disable
namespace MGASystems.IMS.Claims;

[DocumentFolderFilter("Claims-Claim")]
public class FormClaims : 
  FormBase,
  IRecreatableEntity,
  ISupportDocumentSystem,
  ISupportNoteSystem,
  ISupportTemplateDocs
{
  private int _controlNumber;
  private Claim _currentClaim;
  private Claimant _currentClaimant;
  private int _initValueHash;
  private bool _isRecreatingEntity;
  private IContainer components;
  private UltraTabSharedControlsPage ultraTabSharedControlsPage1;
  private UltraTabPageControl tabPageClaimantContainer;
  private UltraToolbarsDockArea _formClaims_Toolbars_Dock_Area_Left;
  private UltraToolbarsDockArea _formClaims_Toolbars_Dock_Area_Right;
  private UltraToolbarsDockArea _formClaims_Toolbars_Dock_Area_Top;
  private UltraToolbarsDockArea _formClaims_Toolbars_Dock_Area_Bottom;
  private UltraToolTipManager ultraToolTipManager1;
  private MGATextBox textClaimants_CorporationName;
  private Label label11;
  private MGATextBox textClaimants_MiddleName;
  private MGATextBox textClaimants_LastName;
  private MGATextBox textClaimants_FirstName;
  private Label label14;
  private Label label13;
  private Label label12;
  private UltraTabControl tabControlClaimants;
  private UltraTabSharedControlsPage ultraTabSharedControlsPage2;
  private UltraTabPageControl tabPageClaimant;
  private UltraTabPageControl tabPageLegal;
  private UltraTabPageControl tabPageClaimSpecifications;
  private Label label16;
  private AddressResolver_MULTI addResolverClaimants_Mailing;
  private Label label15;
  private AddressResolver_MULTI addResolverClaimants_Primary;
  private MGAMaskedEdit maskedEditClaimants_SSNFEIN;
  private Label label19;
  private Label label18;
  private MGATextBox textClaimants_UserDefinedClaimantsID;
  private Label label17;
  private Label label20;
  private MGASimpleComboBox comboClaimants_Gender;
  private MGADateTimePicker dateTimeClaimants_DOB;
  private MGACheckBox checkClaimants_IsInsured;
  private UltraOptionSet optionClaimants_ClaimantType;
  private UltraTabPageControl tabPageClaimantReservesPayments;
  private MGADateTimePicker dateTimeClaimant_DateReported;
  private Label label21;
  private MgaPhoneNumberEntry phoneClaimants_Primary;
  private MgaPhoneNumberEntry phoneClaimants_Mailing;
  private MGASimpleComboBox comboClaimant_AccidentTypes;
  private Label label23;
  private Label label25;
  private MGASimpleComboBox comboClaimants_LossType;
  private Label label24;
  private Label label26;
  private MGASimpleComboBox comboClaimants_ManagedCare;
  private MGADateTimePicker dateTimeClaimant_DateEntered;
  private Label label28;
  private MGACheckBox checkClaimants_Closed;
  private MGATextBox textClaimant_EnteredBy;
  private Label label27;
  private Label label29;
  private MGASimpleComboBox comboClaimants_OutsideAdjuster;
  private MGATextBox textClaimants_LastModifiedBy;
  private Label label38;
  private MGADateTimePicker dateTimeClaimants_LastModified;
  private Label label39;
  private Label label30;
  private MGASimpleComboBox mgaSimpleComboBox3;
  private MGATextBox mgaTextBox2;
  private Label label31;
  private MGADateTimePicker mgaDateTimePicker2;
  private Label label32;
  private Label label33;
  private MGASimpleComboBox mgaSimpleComboBox4;
  private Label label34;
  private MGASimpleComboBox mgaSimpleComboBox5;
  private Label label35;
  private MGASimpleComboBox mgaSimpleComboBox6;
  private Label label36;
  private MGACheckedListBox mgaCheckedListBox1;
  private MGADateTimePicker mgaDateTimePicker4;
  private Label label37;
  private MGATextBox textClaimants_OutsideInvestigator;
  private Label label40;
  private Label label41;
  private MGASimpleComboBox comboClaimants_SettlementType;
  private MGADateTimePicker dateTimeClaimants_OutsideInvestigatorHireDate;
  private Label label42;
  private MGACheckBox checkClaimants_Settled;
  private MGADateTimePicker dateTimeClaimants_SuitAnswered;
  private Label label43;
  private MGADateTimePicker dateTimeClaimants_SuitServed;
  private Label label44;
  private MGACheckBox checkClaimants_SuitServed;
  private AddressResolver_MULTI addResolverClaimants_DefenseAttorney;
  private MgaPhoneNumberEntry phoneClaimants_DefenseAttorney;
  private MGATextBox textClaimants_ClaimantAttorney;
  private MGATextBox textClaimants_ClaimantLawFirm;
  private Label label47;
  private Label label48;
  private MGATextBox textClaimants_DefenseAttorney;
  private MGATextBox textClaimants_DefenseFirm;
  private Label label46;
  private Label label45;
  private MGACheckBox checkClaimants_PublishedDecision;
  private MGATextBox textClaimants_Judge;
  private Label label49;
  protected UltraGrid gridOverview_ReservePaymentBreakout;
  private UltraGrid gridClaimant_Coverages;
  private UltraGrid gridClaimants_ReservePayments;
  private dsClaimActivity dsClaimActivity1;
  private dsClaimOptions dsClaimOptions1;
  private Label label22;
  private MGATextBox textClaimants_EmailAddress;
  private MGADateTimePicker dateTimeClaimant_DateDenied;
  private Label label50;
  private dsReservesPayments dsReservesPayments1;
  private AddressResolver_MULTI addResolverClaimants_ClaimantAttorney;
  private MgaPhoneNumberEntry phoneClaimants_ClaimantAttorney;
  private UltraTabPageControl ultraTabPageControl1;
  private UltraLabel labelCurrentClaimantLabel;
  private UltraLabel labelCurrentClaimant;
  private Label label52;
  private UltraTabPageControl ultraTabPageControl2;
  protected UltraGrid gridUnallocatedExpenses;
  private dsUnallocatedExpenses dsUnallocatedExpenses1;
  private MGAButton buttonClearClaimant;
  private MGAButton buttonAddClaimant;
  private Label label54;
  private Label label53;
  private MGAMaskedEdit textClaimants_ClaimantAttorneyFEIN;
  private MGAMaskedEdit textClaimants_DefenseFEIN;
  protected UltraGrid gridIncurred;
  private dsReservePaymentBreakout dsReservePaymentBreakout1;
  private UltraTabPageControl ultraTabPageControl3;
  protected AddressResolver_MULTI addressResolverAccidentLocation;
  private BingMap mapBing;
  private MGAButton buttonMapLocation;
  protected UltraTabPageControl tabPageClaimOverview;
  protected UltraTabPageControl tabPageClaimLimitsLiabilities;
  protected UltraTabPageControl tabPageClaimReservePayments;
  private Label label58;
  protected Label label59;
  protected Label label60;
  protected MGADateTimePicker dateTimeOverview_LossDate;
  protected GroupBox groupBox3;
  protected UltraGrid gridClaimStatusLog;
  protected MGASimpleComboBox comboAdjusterAssigned;
  public UltraTabControl tabControlClaim;
  protected GroupBox groupBox1;
  protected Label label1;
  protected Label label9;
  protected Label label8;
  protected Label label7;
  protected Label label10;
  protected MGATextBox textOverview_Company;
  protected MGATextBox textOverview_Producer;
  protected MGATextBox textOverview_Insured;
  protected MGATextBox textOverview_PolicyNumber;
  protected MGATextBox textOverview_ControlNumber;
  protected MGATextBox textOverview_Line;
  protected Label label51;
  protected MGATextBox textOverview_EffectiveExpiration;
  protected Label label63;
  private Label label64;
  protected GroupBox groupBox5;
  protected GroupBox groupBox2;
  protected GroupBox groupBox4;
  protected GroupBox groupIncurred;
  protected UltraGrid gridOverview_Claimants;
  private Label label65;
  public UltraToolbarsManager ultraToolbarsManager1;
  protected Label label6;
  protected Label label5;
  protected Label label4;
  protected Label label3;
  protected Label label2;
  protected MGATextBox textOverview_EnteredBy;
  protected MGATextBox textOverview_ClaimNumber;
  protected MGADateTimePicker dateTimeOverview_DateEntered;
  protected MGATextBox textOverview_Comments;
  protected Label label55;
  protected Label label56;
  protected MGASimpleComboBox comboClaim_CatastropheCode;
  private LinkLabel linkViewPolicy;
  protected UltraTabPageControl ultraTabPageControl5;
  private MGAButton buttonEditClaimNumber;
  public UltraCombo comboClaim_CatastropheCode2;
  protected GroupBox groupBox7;
  protected MGATextBox textDriverLastName;
  protected Label label61;
  protected MGATextBox textDriverFirstName;
  protected Label label62;
  protected RadioButton radioNonListedDriver;
  protected RadioButton radioListedDriver;
  protected UltraGrid gridDrivers;
  protected RadioButton radioParkedVehicle;
  protected MGASimpleComboBox comboAccidentType;
  protected MGAMaskedEdit maskAccidentTime;
  private MGATextBox textLatCoord;
  private MGATextBox textLongCoords;
  protected MGATextBox textAccidentDescription;
  protected Label label57;
  protected UltraTabPageControl ultraTabPageControl4;

  public FormClaims()
  {
    this.InitializeForm();
    if (Utility.IsDesignMode())
      return;
    ((EditorButtonControlBase) this.textOverview_ClaimNumber).ReadOnly = false;
  }

  public FormClaims(Claim claim)
  {
    this.InitializeForm();
    if (Utility.IsDesignMode())
      return;
    this._currentClaim = claim;
    this._controlNumber = claim.ControlNumber;
  }

  public FormClaims(int controlNumber)
  {
    this.InitializeForm();
    if (Utility.IsDesignMode())
      return;
    this.SetupForm(controlNumber);
  }

  public FormClaims(Guid claimGuid)
  {
    this.InitializeForm();
    if (Utility.IsDesignMode())
      return;
    this._currentClaim = ObjectFactory.Instance.CreateObjectAs<Claim>((object) claimGuid);
    this._controlNumber = this._currentClaim.ControlNumber;
  }

  protected void SetupForm(int controlNumber)
  {
    if (Utility.IsDesignMode())
      return;
    this._controlNumber = controlNumber;
    this.HookUpClaimEvents();
    this.InitializeForm_ControlNumber();
    ((EditorButtonControlBase) this.textOverview_ClaimNumber).ReadOnly = !this.CurrentClaim.IsManualClaimNumber;
    this.GetPolicyDriverInfo(this._currentClaim.ControlNumber);
    this.HashForm();
  }

  private void InitializeForm()
  {
    this.InitializeComponent();
    if (Utility.IsDesignMode())
      return;
    this.Cursor = MgaCursors.Default;
    ((UltraDateTimeEditor) this.dateTimeClaimant_DateDenied).Value = (object) null;
    this.addressResolverAccidentLocation.WebserviceUrl = AddressResolverSettings.AddressResolverURL;
    this.addressResolverAccidentLocation.UserID = AddressResolverSettings.AddressResolveUserName;
    this.addressResolverAccidentLocation.Password = AddressResolverSettings.AddressResolverPassword;
    this.addressResolverAccidentLocation.OverrideStateEnabled(MGASystems.IMS.NoteDocuments.SystemSettings.GetSetting<bool>("Claims.FormClaims.addressResolverAccidentLocation.OverrideStateEnabled", false));
    if (!MGASystems.Common.SystemSettings.KeyExists("ClaimsShowPolicyLink") || !MGASystems.Common.SystemSettings.GetBoolSetting("ClaimsShowPolicyLink"))
    {
      ((Control) this.textOverview_ControlNumber).Width = ((Control) this.textOverview_PolicyNumber).Width;
      this.linkViewPolicy.Visible = false;
    }
    this.LoadUsers();
    this.LoadCatastroheCodes();
    this.BindCustomControlProperties();
  }

  private void InitializeForm_ControlNumber()
  {
    if (Utility.IsDesignMode())
      return;
    this.CurrentClaim.CreateClaimForControlNumber(this._controlNumber);
  }

  private void HookUpClaimEvents()
  {
    this.CurrentClaim.LoadingPolicyInformation += (EventHandler<CancelEventArgs>) ((sender, e) =>
    {
      if (!this.IsDisposed && !this.Disposing)
        return;
      e.Cancel = true;
    });
    this.CurrentClaim.LoadedPolicyInformation += (EventHandler<LoadedPolicyInformationEventArgs>) ((sender, e) => this.DisplayClaim());
    this.CurrentClaim.Claimants.CollectionChanged += (EventHandler<EventArgs>) ((sender, e) => this.BindClaimantsGrids());
    this.CurrentClaim.UnAllocatedExpensesChanged += (EventHandler<EventArgs>) ((sender, e) =>
    {
      this.BindExpenseGrid();
      this.BindIncurredGrid();
      this.FormatIncurredGrid();
    });
    this.CurrentClaim.UnAllocatedExpensesLoaded += (EventHandler<EventArgs>) ((sender, e) => this.BindExpenseGrid());
    this.CurrentClaim.ReservePaymentBreakoutLoaded += (EventHandler<EventArgs>) ((sender, e) => this.BindReservePaymentBreakout());
  }

  public Claim CurrentClaim
  {
    get
    {
      if (this._currentClaim == null)
        this._currentClaim = ObjectFactory.Instance.CreateObjectAs<Claim>();
      return this._currentClaim;
    }
  }

  public int ControlNumber => this._controlNumber;

  public Claimant CurrentClaimant => this._currentClaimant;

  public DateTime LossDate => ((UltraDateTimeEditor) this.dateTimeOverview_LossDate).DateTime;

  public string ClaimNumber => ((Control) this.textOverview_ClaimNumber).Text;

  private void OverviewTextbox_Enter(object sender, EventArgs e)
  {
    if (!(sender is TextBox textBox))
      return;
    textBox.SelectAll();
  }

  protected virtual void LoadAccidentTypes()
  {
    ((UltraGridBase) this.comboAccidentType).DataSource = (object) DefaultDatabase.ExecuteDataSet("spClaims_GetAccidentTypes").Tables[0];
    ((UltraDropDownBase) this.comboAccidentType).DisplayMember = "AccidentType";
    ((UltraDropDownBase) this.comboAccidentType).ValueMember = "AccidentTypeId";
  }

  protected void HashForm() => this._initValueHash = Utility.GetValueHash((object) this);

  protected virtual void DisplayClaim()
  {
    ((Control) this.textOverview_EnteredBy).Text = this.CurrentClaim.UserName;
    ((UltraDateTimeEditor) this.dateTimeOverview_LossDate).DateTime = this.CurrentClaim.LossDate;
    ((UltraDateTimeEditor) this.dateTimeOverview_DateEntered).DateTime = this.CurrentClaim.DateEntered;
    ((Control) this.textOverview_ClaimNumber).Text = this.CurrentClaim.ClaimNumber;
    ((UltraCombo) this.comboClaim_CatastropheCode).Value = (object) this.CurrentClaim.CatastropheCode;
    ((Control) this.textOverview_Comments).Text = this.CurrentClaim.ClaimComments;
    ((Control) this.textOverview_ControlNumber).Text = this.CurrentClaim.ControlNumber.ToString();
    ((Control) this.textOverview_PolicyNumber).Text = this.CurrentClaim.PolicyInformation.PolicyNumber;
    ((Control) this.textOverview_Insured).Text = this.CurrentClaim.PolicyInformation.InsuredName;
    ((Control) this.textOverview_Producer).Text = this.CurrentClaim.PolicyInformation.ProducerLocationName;
    ((Control) this.textOverview_Company).Text = this.CurrentClaim.PolicyInformation.CompanyName;
    ((Control) this.textOverview_Line).Text = this.CurrentClaim.PolicyInformation.LineName;
    this.GetPolicyEffectiveExpiration();
    ((UltraCombo) this.comboAdjusterAssigned).Value = (object) this.CurrentClaim.InhouseAdjuster;
    this.BindActivityGrid();
    if (this.CurrentClaim.UnAllocatedExpenses != null && this.CurrentClaim.UnAllocatedExpenses.ExpenseList.Count > 0)
      this.BindExpenseGrid();
    this.BindReservePaymentBreakout();
    this.BindIncurredGrid();
    this.FormatIncurredGrid();
    this.LoadAccidentTypes();
    this.DisplayAccidentInformation();
    this.LoadClaimActivityLog();
    if (this.EntityInfoChanged != null)
      this.EntityInfoChanged((object) this, new EventArgs());
    if (this.NoteEntityInfoChanged == null)
      return;
    this.NoteEntityInfoChanged((object) this, new EventArgs());
  }

  private void DisplayAccidentInformation()
  {
    this.addressResolverAccidentLocation.ISOCountryCode = this.CurrentClaim.AccidentInfo.ISOCountryCode;
    this.addressResolverAccidentLocation.Address1 = this.CurrentClaim.AccidentInfo.Address1;
    this.addressResolverAccidentLocation.Address2 = this.CurrentClaim.AccidentInfo.Address2;
    this.addressResolverAccidentLocation.City = this.CurrentClaim.AccidentInfo.City;
    this.addressResolverAccidentLocation.State = this.CurrentClaim.AccidentInfo.State;
    this.addressResolverAccidentLocation.County = this.CurrentClaim.AccidentInfo.County;
    this.addressResolverAccidentLocation.ZipCode = this.CurrentClaim.AccidentInfo.ZipCode;
    if (!string.IsNullOrEmpty(this.CurrentClaim.AccidentInfo.DocumentText))
    {
      this.mapBing.RenderDocument(this.CurrentClaim.AccidentInfo.DocumentText);
      this.mapBing.Visible = true;
    }
    ((Control) this.textAccidentDescription).Text = this.CurrentClaim.AccidentInfo.AccidentDescription;
    ((Control) this.maskAccidentTime).Text = this.CurrentClaim.AccidentInfo.AccidentTime;
    if (this.CurrentClaim.AccidentInfo.AccidentTypeId != 0)
      ((UltraCombo) this.comboAccidentType).Value = (object) this.CurrentClaim.AccidentInfo.AccidentTypeId;
    Decimal num;
    if (this.CurrentClaim.AccidentInfo.Latitude != 0M)
    {
      MGATextBox textLatCoord = this.textLatCoord;
      num = this.CurrentClaim.AccidentInfo.Latitude;
      string str = num.ToString();
      ((Control) textLatCoord).Text = str;
    }
    if (!(this.CurrentClaim.AccidentInfo.Longitude != 0M))
      return;
    MGATextBox textLongCoords = this.textLongCoords;
    num = this.CurrentClaim.AccidentInfo.Longitude;
    string str1 = num.ToString();
    ((Control) textLongCoords).Text = str1;
  }

  private void GetPolicyEffectiveExpiration()
  {
    DataRow dataRow = DefaultDatabase.ExecuteDataRow("spClaims_GetPolicyEffectiveExpiration", new object[2]
    {
      (object) "@ControlNo",
      (object) this._controlNumber
    });
    MGATextBox effectiveExpiration = this.textOverview_EffectiveExpiration;
    DateTime dateTime = (DateTime) dataRow[0];
    string shortDateString1 = dateTime.ToShortDateString();
    dateTime = (DateTime) dataRow[1];
    string shortDateString2 = dateTime.ToShortDateString();
    string str = $"{shortDateString1}-{shortDateString2}";
    ((Control) effectiveExpiration).Text = str;
    this._currentClaim.PolicyInformation.PolicyEffectiveDate = (DateTime) dataRow[0];
    this._currentClaim.PolicyInformation.PolicyExpirationDate = (DateTime) dataRow[1];
  }

  protected virtual void BindIncurredGrid()
  {
    DataSet dataSet = new DataSet();
    DataTable table = new DataTable();
    table.Columns.AddRange(new DataColumn[2]
    {
      new DataColumn((string) null, typeof (string)),
      new DataColumn((string) null, typeof (Decimal))
    });
    Decimal num1 = 0M;
    Decimal num2 = 0M;
    Decimal num3 = 0M;
    Decimal num4 = 0M;
    foreach (Claimant claimant in (Collection<Claimant>) this.CurrentClaim.Claimants)
    {
      num1 += claimant.ReserveTotal();
      num3 += claimant.NonExpensePaymentTotal();
      num4 += claimant.AllocatedExpensePaymentTotal();
      num2 += claimant.ExpenseTotalIncurred();
    }
    Decimal num5 = this.CurrentClaim.UnAllocatedExpenseTotal();
    DataRow row1 = table.NewRow();
    row1[0] = (object) "Reserves";
    row1[1] = (object) num1;
    table.Rows.Add(row1);
    DataRow row2 = table.NewRow();
    row2[0] = (object) "Payments";
    row2[1] = (object) num3;
    table.Rows.Add(row2);
    DataRow row3 = table.NewRow();
    row3[0] = (object) "Expenses (Allocated)";
    row3[1] = (object) num2;
    table.Rows.Add(row3);
    DataRow row4 = table.NewRow();
    row4[0] = (object) "Expenses (Allocated) Payments";
    row4[1] = (object) num4;
    table.Rows.Add(row4);
    DataRow row5 = table.NewRow();
    row5[0] = (object) "Expenses (Un-Allocated)";
    row5[1] = (object) num5;
    table.Rows.Add(row5);
    DataRow row6 = table.NewRow();
    row6[0] = (object) "Total Incurred";
    row6[1] = (object) (num2 + num1 + num3 + num5);
    table.Rows.Add(row6);
    dataSet.Tables.Add(table);
    ((UltraGridBase) this.gridIncurred).DataSource = (object) dataSet.Tables[0];
  }

  private void FormatIncurredGrid()
  {
    UltraGridBand band = ((UltraGridBase) this.gridIncurred).DisplayLayout.Bands[0];
    ((UltraGridBase) this.gridIncurred).DisplayLayout.BorderStyle = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.gridIncurred).DisplayLayout.Override.RowAppearance.BackColor = Color.Transparent;
    ((UltraGridBase) this.gridIncurred).DisplayLayout.Override.RowAppearance.BorderColor = Color.Transparent;
    ((UltraGridBase) this.gridIncurred).DisplayLayout.Override.RowAppearance.BorderColor2 = Color.Transparent;
    ((UltraGridBase) this.gridIncurred).DisplayLayout.Override.RowAlternateAppearance.BackColor = Color.Transparent;
    ((UltraGridBase) this.gridIncurred).DisplayLayout.Override.RowAlternateAppearance.BorderColor = Color.Transparent;
    ((UltraGridBase) this.gridIncurred).DisplayLayout.Override.RowAlternateAppearance.BorderColor2 = Color.Transparent;
    ((UltraGridBase) this.gridIncurred).DisplayLayout.Override.CellAppearance.BorderColor = Color.Transparent;
    ((UltraGridBase) this.gridIncurred).DisplayLayout.Override.CellAppearance.BorderColor2 = Color.Transparent;
    band.ColHeadersVisible = false;
    band.Columns[1].Format = "c";
    band.Columns[1].CellAppearance.TextHAlign = (HAlign) 3;
    this.ClientFormatIncurredGrid(band);
  }

  protected virtual void ClientFormatIncurredGrid(UltraGridBand band)
  {
  }

  protected virtual void BindClaimantsGrids()
  {
    ((UltraGridBase) this.gridOverview_Claimants).DataSource = (object) null;
    ((UltraGridBase) this.gridOverview_Claimants).DataSource = (object) this.CurrentClaim.ClaimantsDataset;
    ((UltraGridBase) this.gridOverview_Claimants).DisplayLayout.Bands[0].Columns["ClaimantGuid"].Hidden = true;
    ((HeaderBase) ((UltraGridBase) this.gridOverview_Claimants).DisplayLayout.Bands[0].Columns["Status"].Header).Caption = "Open?";
    ((UltraGridBase) this.gridOverview_Claimants).DisplayLayout.Bands[0].Columns["Status"].Style = (ColumnStyle) 3;
    ((HeaderBase) ((UltraGridBase) this.gridOverview_Claimants).DisplayLayout.Bands[0].Columns["#"].Header).Caption = string.Empty;
    ((UltraGridBase) this.gridOverview_Claimants).DisplayLayout.Bands[0].Columns["#"].Width = 25;
    ((UltraGridBase) this.gridOverview_Claimants).DisplayLayout.Bands[0].Override.HeaderAppearance.TextHAlign = (HAlign) 1;
    ((Control) this.gridOverview_Claimants).Visible = true;
  }

  private void BindActivityGrid()
  {
    this.dsClaimActivity1.ClaimActivity.Clear();
    foreach (ClaimActivity claimActivity in (Collection<ClaimActivity>) this.CurrentClaim.ClaimActivities)
    {
      string Claimant = string.IsNullOrEmpty(claimActivity.ClaimantName) ? string.Empty : claimActivity.ClaimantName;
      string Status = claimActivity.Status != Utility.ClaimStatus.Open ? "Closed" : "Open";
      this.dsClaimActivity1.ClaimActivity.AddClaimActivityRow(claimActivity.Activity, claimActivity.ActivityDate, claimActivity.UserName, Claimant, Status);
    }
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
          this.BindClaimOptions();
        else
          ExceptionDispatchInfo.Capture(e.Error).Throw();
      });
      backgroundWorker.RunWorkerAsync();
    }
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

  private void BindClaimOptions()
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

  private void SetToolbarEnabled()
  {
    ((ToolsCollectionBase) ((UltraToolbarBase) this.ultraToolbarsManager1.Toolbars[0]).Tools)["EDITCLAIMANT"].SharedProps.Enabled = this._currentClaim.Claimants.Count > 0;
    ((ToolsCollectionBase) ((UltraToolbarBase) this.ultraToolbarsManager1.Toolbars[0]).Tools)["ADDRESERVE"].SharedProps.Enabled = this._currentClaimant != null;
    ((ToolsCollectionBase) ((UltraToolbarBase) this.ultraToolbarsManager1.Toolbars[0]).Tools)["ADDPAYMENT"].SharedProps.Enabled = this._currentClaimant != null;
    ((ToolsCollectionBase) ((UltraToolbarBase) this.ultraToolbarsManager1.Toolbars[0]).Tools)["CLOSECLAIM"].SharedProps.Enabled = this._currentClaimant != null && this._currentClaimant.StatusId == 0;
    ((ToolsCollectionBase) ((UltraToolbarBase) this.ultraToolbarsManager1.Toolbars[0]).Tools)["REOPENCLAIM"].SharedProps.Enabled = this._currentClaimant != null && this._currentClaimant.StatusId == 1;
  }

  protected virtual void BindExpenseGrid()
  {
    ((UltraGridBase) this.gridUnallocatedExpenses).DataSource = (object) this._currentClaim.UnAllocatedExpenses;
    ((UltraGridBase) this.gridUnallocatedExpenses).DisplayLayout.Load(((UltraGridBase) this.gridUnallocatedExpenses).Layouts[0], (PropertyCategories) -1);
  }

  protected virtual void BindReservePaymentBreakout()
  {
    if (this._currentClaim.ReservePaymentBreakout == null)
      return;
    ((UltraGridBase) this.gridOverview_ReservePaymentBreakout).DataSource = (object) this._currentClaim.ReservePaymentBreakout;
    ((UltraGridBase) this.gridOverview_ReservePaymentBreakout).DisplayLayout.Load(((UltraGridBase) this.gridOverview_ReservePaymentBreakout).Layouts[0], (PropertyCategories) -1);
    if (((DisposableObjectCollectionBase) ((UltraGridBase) this.gridOverview_ReservePaymentBreakout).Rows).Count != 0)
      ((UltraGridBase) this.gridOverview_ReservePaymentBreakout).Rows[0].ExpandAll();
    ((UltraGridBase) this.gridOverview_ReservePaymentBreakout).DisplayLayout.RowScrollRegions.Clear();
  }

  private void ShowClaimantReserveTab()
  {
    ((UltraTabControlBase) this.tabControlClaim).SelectedTab = ((UltraTabControlBase) this.tabControlClaim).Tabs[1];
    ((UltraTabControlBase) this.tabControlClaimants).SelectedTab = ((UltraTabControlBase) this.tabControlClaimants).Tabs["ReservesPayments"];
  }

  private void CloseClaim()
  {
    DialogResult dialogResult = MessageBox.Show(Resources.CLAIMANT_CLOSECLAIM, Resources.CLAIMANT_CLOSECLAIMHEADER, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
    if (dialogResult == DialogResult.Cancel)
      return;
    this._currentClaimant.CloseClaim(dialogResult == DialogResult.OK);
  }

  protected virtual void EditClaimant()
  {
    if (((DisposableObjectCollectionBase) ((UltraGridBase) this.gridOverview_Claimants).Rows).Count == 0)
      return;
    if (((SparseCollectionBase) this.gridOverview_Claimants.Selected.Rows).Count == 0 && ((DisposableObjectCollectionBase) ((UltraGridBase) this.gridOverview_Claimants).Rows).Count == 1)
      ((GridItemBase) ((UltraGridBase) this.gridOverview_Claimants).Rows[0]).Selected = true;
    if (((SparseCollectionBase) this.gridOverview_Claimants.Selected.Rows).Count == 0)
      return;
    foreach (Form mdiChild in MDIControls.Instance.MDIParent.MdiChildren)
    {
      if (mdiChild is FormClaimant && (mdiChild as FormClaimant).CurrentClaimant == this.CurrentClaim.Claimants[this.gridOverview_Claimants.Selected.Rows[0].Index])
      {
        mdiChild.Tag = (object) this;
        mdiChild.BringToFront();
        return;
      }
    }
    FormClaimant form = (FormClaimant) ObjectFactory.Instance.CreateForm(typeof (FormClaimant), new object[2]
    {
      (object) this._currentClaim,
      (object) this.CurrentClaim.Claimants[this.gridOverview_Claimants.Selected.Rows[0].Index]
    });
    form.MdiParent = MDIControls.Instance.MDIParent;
    this.OnClaimantFormBeforeShown(form);
    form.Tag = (object) this;
    form.Show();
    this.OnClaimantFormLoaded(form);
  }

  private void DeleteClaimant()
  {
    if (((DisposableObjectCollectionBase) ((UltraGridBase) this.gridOverview_Claimants).Rows).Count == 0 || ((SparseCollectionBase) this.gridOverview_Claimants.Selected.Rows).Count == 0)
      return;
    int num = (int) MessageBox.Show(Resources.QUESTION_DELETECLAIMANT, Resources.MESSAGEBOX_QUESTION_HEADER1, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
  }

  private void SetClaimAccidentInformation()
  {
    this.CurrentClaim.AccidentInfo.Address1 = this.addressResolverAccidentLocation.Address1;
    this.CurrentClaim.AccidentInfo.Address2 = this.addressResolverAccidentLocation.Address2;
    this.CurrentClaim.AccidentInfo.City = this.addressResolverAccidentLocation.City;
    this.CurrentClaim.AccidentInfo.State = this.addressResolverAccidentLocation.State;
    this.CurrentClaim.AccidentInfo.County = this.addressResolverAccidentLocation.County;
    this.CurrentClaim.AccidentInfo.ZipCode = this.addressResolverAccidentLocation.ZipCode;
    this.CurrentClaim.AccidentInfo.ISOCountryCode = this.addressResolverAccidentLocation.ISOCountryCode;
    this.CurrentClaim.AccidentInfo.DocumentText = this.mapBing.GetDocument();
    this.CurrentClaim.AccidentInfo.AccidentDescription = ((Control) this.textAccidentDescription).Text;
    this.CurrentClaim.AccidentInfo.AccidentTime = ((Control) this.maskAccidentTime).Text;
    Decimal result1;
    if (((Control) this.textLatCoord).Text.Length > 0 && Decimal.TryParse(((Control) this.textLatCoord).Text, out result1))
      this.CurrentClaim.AccidentInfo.Latitude = result1;
    Decimal result2;
    if (((Control) this.textLongCoords).Text.Length > 0 && Decimal.TryParse(((Control) this.textLongCoords).Text, out result2))
      this.CurrentClaim.AccidentInfo.Longitude = result2;
    if (((UltraDropDownBase) this.comboAccidentType).SelectedRow == null)
      return;
    this.CurrentClaim.AccidentInfo.AccidentTypeId = (int) ((UltraCombo) this.comboAccidentType).Value;
  }

  protected virtual void ultraToolbarsManager1_ToolClick(object sender, ToolClickEventArgs e)
  {
    string key = ((KeyedSubObjectBase) ((ToolEventArgs) e).Tool).Key;
    if (key == null)
      return;
    switch (key.Length)
    {
      case 4:
        if (!(key == "SAVE") || !this.VerifyLossDate())
          break;
        this.SaveClaim(true);
        int? claimId = this._currentClaim.ClaimId;
        if (claimId.HasValue)
        {
          CurrentUser instance = CurrentUser.Instance;
          claimId = this._currentClaim.ClaimId;
          int identifier = claimId.Value;
          instance.LogAction("User clicked save on the claim screen. (Claim Id)", identifier);
          break;
        }
        CurrentUser.Instance.LogAction("User clicked save on the claim screen. (Control Number)", this._currentClaim.ControlNumber);
        break;
      case 7:
        if (!(key == "USERLOG"))
          break;
        Claim currentClaim = this._currentClaim;
        if ((currentClaim != null ? (!currentClaim.ClaimId.HasValue ? 1 : 0) : 1) != 0)
          break;
        using (FormClaimUserLog formClaimUserLog = new FormClaimUserLog(this._currentClaim.ClaimId.Value))
        {
          int num = (int) formClaimUserLog.ShowDialog();
          break;
        }
      case 11:
        switch (key[0])
        {
          case 'A':
            if (!(key == "ADDCLAIMANT") || !this.SetupClaimObject())
              return;
            FormClaimant form1 = (FormClaimant) ObjectFactory.Instance.CreateForm(typeof (FormClaimant), new object[1]
            {
              (object) this._currentClaim
            });
            form1.Show();
            this.OnClaimantFormLoaded(form1);
            return;
          case 'E':
            if (!(key == "EDITCOMMENT"))
              return;
            if (!SecurityManager.Instance.AssertPermission("{7924820D-3CB6-47AD-BD94-339AE336E10A}"))
            {
              int num = (int) MessageBox.Show("You do not have permission to perform this function.", "Access Denied!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
              return;
            }
            if (((UltraGridBase) this.gridUnallocatedExpenses).ActiveRow == null)
            {
              int num = (int) MessageBox.Show("You must select an expense to edit.", Resources.ERROR_REQUIREDFIELD_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
              return;
            }
            if (MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("RestrictEditUAExpenseComment") && (DateTime.Now - (DateTime) ((UltraGridBase) this.gridUnallocatedExpenses).ActiveRow.Cells["DateEntered"].Value).TotalHours > 24.0)
            {
              int num = (int) MessageBox.Show("Editing comments is restricted to 24 hours after the comment was saved. Editing is no longer allowed.", "Access Denied!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
              return;
            }
            int expenseId = (int) ((UltraGridBase) this.gridUnallocatedExpenses).ActiveRow.Cells["UAExpenseId"].Value;
            if (expenseId == -1)
            {
              UltraGridRow activeRow = ((UltraGridBase) this.gridUnallocatedExpenses).ActiveRow;
              using (FormEditTransactionULAEComment transactionUlaeComment = new FormEditTransactionULAEComment(ref activeRow))
              {
                int num = (int) transactionUlaeComment.ShowDialog();
                return;
              }
            }
            using (FormEditTransactionULAEComment transactionUlaeComment = new FormEditTransactionULAEComment(expenseId))
            {
              int num = (int) transactionUlaeComment.ShowDialog();
              if (transactionUlaeComment.DialogResult != DialogResult.OK)
                return;
              this.RedisplayClaim();
              return;
            }
          default:
            return;
        }
      case 12:
        if (!(key == "EDITCLAIMANT") || !this.SetupClaimObject())
          break;
        this.EditClaimant();
        break;
      case 13:
        if (!(key == "MODIFYRESERVE"))
          break;
        if (((SparseCollectionBase) this.gridOverview_ReservePaymentBreakout.Selected.Rows).Count < 1)
        {
          int num = (int) MessageBox.Show("You must select a reserve type card to continue.", "Invalid Selection!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          break;
        }
        Guid claimantGuid = new Guid(this.gridOverview_ReservePaymentBreakout.Selected.Rows[0].Cells["ClaimantGuid"].Value.ToString());
        this._currentClaimant = this.CurrentClaim.Claimants.FirstOrDefault<Claimant>((System.Func<Claimant, bool>) (x => x.ClaimantGuid == claimantGuid));
        if (this._currentClaimant != null && this._currentClaimant.StatusId == 1)
        {
          int num = (int) MessageBox.Show("A reserve on a closed claimant cannot be modified.", "Closed Claimant Reserve!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          break;
        }
        this.ModifyReserve();
        break;
      case 14:
        int num1 = key == "DELETECLAIMANT" ? 1 : 0;
        break;
      case 17:
        if (!(key == "DELETETRANSACTION") || ((SparseCollectionBase) this.gridUnallocatedExpenses.Selected.Rows).Count == 0)
          break;
        if ((bool) this.gridUnallocatedExpenses.Selected.Rows[0].Cells["ARCreated"].Value)
        {
          int num2 = (int) MessageBox.Show("The expense you are trying to delete has already been sent to accounting and can not be changed at this time.", "Transaction Cannot Be Deleted!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          break;
        }
        if (MessageBox.Show("This will permanently delete the selected transaction and this action can not be undone. Continue?", "Permanently Delete Transaction?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
          break;
        Utility.DeleteClaimExpense((int) this.gridUnallocatedExpenses.Selected.Rows[0].Cells["UAExpenseId"].Value);
        this.CurrentClaim.UnAllocatedExpenses.ExpenseList.RemoveExpenseListRow((dsUnallocatedExpenses.ExpenseListRow) this.CurrentClaim.UnAllocatedExpenses.ExpenseList.Rows[this.gridUnallocatedExpenses.Selected.Rows[0].Index]);
        this.HashForm();
        this.ClearToolTip();
        break;
      case 18:
        if (!(key == "UNALLOCATEDEXPENSE"))
          break;
        using (Form form2 = ObjectFactory.Instance.CreateForm(typeof (FormAddTransaction), new object[1]
        {
          (object) this._currentClaim
        }))
        {
          int num3 = (int) form2.ShowDialog();
          break;
        }
    }
  }

  protected bool VerifyLossDate()
  {
    DataRow dataRow = DefaultDatabase.ExecuteDataRow("spClaims_GetPolicyEffectiveExpiration", new object[2]
    {
      (object) "@ControlNo",
      (object) this._controlNumber
    });
    DateTime dateTime1 = (DateTime) dataRow[0];
    DateTime dateTime2 = (DateTime) dataRow[1];
    if (SecurityManager.Instance.AssertPermission("{A14CB5B5-4879-4BEE-92D9-8E7063728BB2}") || !(this.LossDate.Date < dateTime1.Date) && !(this.LossDate.Date > dateTime2.Date))
      return true;
    int num = (int) MessageBox.Show("The loss date is outside the effective and expiration dates. You do not have rights to complete this posting.", "Invalid Loss Date", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    return false;
  }

  private void ultraToolbarsManager1_BeforeToolDropdown(
    object sender,
    BeforeToolDropdownEventArgs e)
  {
    if (!SecurityManager.Instance.AssertPermission("{EB460F2D-0BDA-4FA1-9931-D08994969163}"))
    {
      ((CancelEventArgs) e).Cancel = true;
    }
    else
    {
      if (!(((KeyedSubObjectBase) ((CancelableToolEventArgs) e).Tool).Key == "ULAEGridContext"))
        return;
      ((ToolsCollectionBase) (((CancelableToolEventArgs) e).Tool as PopupMenuTool).Tools)[0].SharedProps.Enabled = ((SparseCollectionBase) this.gridUnallocatedExpenses.Selected.Rows).Count != 0;
      if (!((KeyedSubObjectsCollectionBase) (((CancelableToolEventArgs) e).Tool as PopupMenuTool).Tools).Exists("EDITCOMMENT"))
        return;
      ((ToolsCollectionBase) (((CancelableToolEventArgs) e).Tool as PopupMenuTool).Tools)["EDITCOMMENT"].SharedProps.Enabled = SecurityManager.Instance.AssertPermission("{7924820D-3CB6-47AD-BD94-339AE336E10A}");
      ((ToolsCollectionBase) (((CancelableToolEventArgs) e).Tool as PopupMenuTool).Tools)["EDITCOMMENT"].SharedProps.Enabled = ((SparseCollectionBase) this.gridUnallocatedExpenses.Selected.Rows).Count != 0;
    }
  }

  protected virtual void ModifyReserve()
  {
    if (!SecurityManager.Instance.AssertPermission("{07F990AF-457C-49F1-9C65-75151047A1D1}"))
    {
      int num1 = (int) MessageBox.Show("You do not have rights to perform the requested action.", "Access Denied!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
    }
    else if (((SparseCollectionBase) this.gridOverview_ReservePaymentBreakout.Selected.Rows).Count < 1 || ((GridItemBase) this.gridOverview_ReservePaymentBreakout.Selected.Rows[0]).Band.Index != 1)
    {
      int num2 = (int) MessageBox.Show("You must select a reserve type card to continue.", "Invalid Selection!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else
    {
      UltraGridRow row = this.gridOverview_ReservePaymentBreakout.Selected.Rows[0];
      string str1 = row.ParentRow.Cells["ClaimantName"].Value.ToString();
      string str2 = row.Cells["ResPayTypeDescription"].Value.ToString();
      if (this._currentClaimant == null)
      {
        Guid claimantGuid = new Guid(row.Cells["ClaimantGuid"].Value.ToString());
        this._currentClaimant = this.CurrentClaim.Claimants.FirstOrDefault<Claimant>((System.Func<Claimant, bool>) (x => x.ClaimantGuid == claimantGuid));
      }
      if (this._currentClaimant == null)
      {
        int num3 = (int) MessageBox.Show("A claimant for this reserve could not be identified.", "Could Not Modify Reserve!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
      else
      {
        string empty1 = string.Empty;
        if (row.Cells["ResPaySubTypeDescription"].Value != DBNull.Value)
          empty1 = row.Cells["ResPaySubTypeDescription"].Value.ToString();
        string empty2 = string.Empty;
        if (row.Cells["CoverageType"].Value != DBNull.Value)
          empty2 = row.Cells["CoverageType"].Value.ToString();
        string empty3 = string.Empty;
        if (row.Cells["CoverageTypeDescription"].Value != DBNull.Value)
          empty3 = row.Cells["CoverageTypeDescription"].Value.ToString();
        int num4 = -1;
        if (row.Cells["ResPayTypeId"].Value is int)
          num4 = (int) row.Cells["ResPayTypeId"].Value;
        int num5 = -1;
        if (row.Cells["ResPaySubTypeId"].Value is int)
          num5 = (int) row.Cells["ResPaySubTypeId"].Value;
        int num6 = -1;
        if (row.Cells["CoverageTypeId"].Value is int)
          num6 = (int) row.Cells["CoverageTypeId"].Value;
        int num7 = -1;
        if (row.Cells["CoverageTypeDescriptionId"].Value is int)
          num7 = (int) row.Cells["CoverageTypeDescriptionId"].Value;
        Decimal num8 = 0M;
        if (row.Cells["TotalReserve"].Value is Decimal)
          num8 = (Decimal) row.Cells["TotalReserve"].Value;
        Decimal num9 = 0M;
        if (row.Cells["TotalPayments"].Value is Decimal)
          num9 = (Decimal) row.Cells["TotalPayments"].Value;
        Decimal num10 = 0M;
        if (row.Cells["RemainingReserves"].Value is Decimal)
          num10 = (Decimal) row.Cells["RemainingReserves"].Value;
        using (FormModifyReserve form = (FormModifyReserve) ObjectFactory.Instance.CreateForm(typeof (FormModifyReserve), new object[15]
        {
          (object) this.CurrentClaimant.ClaimantGuid,
          (object) this.CurrentClaim.ClaimNumber,
          (object) str1,
          (object) str2,
          (object) empty1,
          (object) empty2,
          (object) empty3,
          (object) num4,
          (object) num5,
          (object) num6,
          (object) num7,
          (object) num8,
          (object) num9,
          (object) num10,
          (object) this.CurrentClaimant
        }))
        {
          this.OnModifyReserveFormShown(form);
          if (form.ShowDialog() != DialogResult.OK)
            return;
          this._currentClaim.ReloadClaim();
          this.DisplayClaim();
        }
      }
    }
  }

  protected bool VerifyClaim(bool verifyClaimantCount)
  {
    if (((UltraDateTimeEditor) this.dateTimeOverview_LossDate).Value == null)
    {
      int num = (int) MessageBox.Show("You must specify a loss date to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (MGASystems.Common.SystemSettings.KeyExists("CLAIMS_WARNLOSSDATEERROR") && MGASystems.Common.SystemSettings.GetBoolSetting("CLAIMS_WARNLOSSDATEERROR"))
    {
      DateTime date1 = ((UltraDateTimeEditor) this.dateTimeOverview_LossDate).DateTime.Date;
      DateTime dateTime = this._currentClaim.PolicyInformation.PolicyEffectiveDate;
      DateTime date2 = dateTime.Date;
      if (!(date1 < date2))
      {
        dateTime = ((UltraDateTimeEditor) this.dateTimeOverview_LossDate).DateTime;
        DateTime date3 = dateTime.Date;
        dateTime = this._currentClaim.PolicyInformation.PolicyExpirationDate;
        DateTime date4 = dateTime.Date;
        if (!(date3 > date4))
          goto label_7;
      }
      int num = (int) MessageBox.Show("The loss date specified falls outside the policy effective/expiration dates", "Date Of Loss Warning!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      if (MGASystems.Common.SystemSettings.KeyExists("CLAIMS_DENYLOSSDATEERROR") && MGASystems.Common.SystemSettings.GetBoolSetting("CLAIMS_DENYLOSSDATEERROR"))
        return false;
    }
label_7:
    if (this.CurrentClaim.IsManualClaimNumber && string.IsNullOrEmpty(((Control) this.textOverview_ClaimNumber).Text))
    {
      int num = (int) MessageBox.Show(Resources.CLAIM_ERROR_NOCLAIMNUMBER, Resources.ERROR_REQUIREDFIELD_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (!verifyClaimantCount || this.CurrentClaim.Claimants.Count != 0)
      return true;
    int num1 = (int) MessageBox.Show(Resources.CLAIM_ERROR_NOCLAIMANTS, Resources.ERROR_REQUIREDFIELD_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    return false;
  }

  private void gridOverview_Claimants_DoubleClickRow(object sender, DoubleClickRowEventArgs e)
  {
    this.EditClaimant();
  }

  public Claim RedisplayClaim()
  {
    if (this.CurrentClaim.ClaimId.HasValue)
    {
      this.OnBeforeRedisplayClaim();
      this._currentClaim = ObjectFactory.Instance.CreateObjectAs<Claim>((object) this._currentClaim.ClaimId.Value);
      this.HookUpClaimEvents();
      this._controlNumber = this._currentClaim.ControlNumber;
      this.DisplayClaim();
      this.BindClaimantsGrids();
      this.LoadClaimActivityLog();
      this.OnRedisplayingClaim();
      this._initValueHash = Utility.GetValueHash((object) this);
      this.OnAfterRedisplayClaim();
    }
    return this._currentClaim;
  }

  protected event EventHandler<EventArgs> BeforeRedisplayClaim;

  protected event EventHandler<EventArgs> AfterRedisplayClaim;

  protected event FormClaims.ClaimantFormLoadedEventHandler ClaimantFormLoaded;

  protected event FormClaims.ClaimantFormBeforeShownEventHandler ClaimantFormBeforeShown;

  protected void OnClaimantFormLoaded(FormClaimant f)
  {
    FormClaims.ClaimantFormLoadedEventHandler claimantFormLoaded = this.ClaimantFormLoaded;
    if (claimantFormLoaded == null)
      return;
    claimantFormLoaded((object) this, new ClaimantFormLoadedEventArgs(f));
  }

  private void OnClaimantFormBeforeShown(FormClaimant f)
  {
    FormClaims.ClaimantFormBeforeShownEventHandler claimantFormBeforeShown = this.ClaimantFormBeforeShown;
    if (claimantFormBeforeShown == null)
      return;
    claimantFormBeforeShown((object) this, new ClaimantFormBeforeShownEventArgs(f));
  }

  private void OnBeforeRedisplayClaim()
  {
    EventHandler<EventArgs> beforeRedisplayClaim = this.BeforeRedisplayClaim;
    if (beforeRedisplayClaim == null)
      return;
    beforeRedisplayClaim((object) this, new EventArgs());
  }

  private void OnAfterRedisplayClaim()
  {
    EventHandler<EventArgs> afterRedisplayClaim = this.AfterRedisplayClaim;
    if (afterRedisplayClaim == null)
      return;
    afterRedisplayClaim((object) this, new EventArgs());
  }

  protected virtual void FormClaims_FormClosing(object sender, FormClosingEventArgs e)
  {
    if (!SecurityManager.Instance.AssertPermission("{EB460F2D-0BDA-4FA1-9931-D08994969163}"))
      return;
    int valueHash = Utility.GetValueHash((object) this);
    if (e.CloseReason == CloseReason.UserClosing && ((INotifyChanges) this.CurrentClaim).HasChanges || valueHash != this._initValueHash)
    {
      switch (MessageBox.Show(Resources.MESSAGE_CHANGEDETECTED, Resources.MESSAGEBOX_QUESTION_HEADER1, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1))
      {
        case DialogResult.Cancel:
          e.Cancel = true;
          break;
        case DialogResult.Yes:
          try
          {
            this.SaveClaim(false);
            e.Cancel = false;
            if (!this._currentClaim.ClaimId.HasValue)
              break;
            Utility.DeleteClaimLock(this._currentClaim.ClaimId.Value);
            break;
          }
          catch (Exception ex)
          {
            e.Cancel = true;
            throw;
          }
        case DialogResult.No:
          e.Cancel = false;
          int? claimId1 = this._currentClaim.ClaimId;
          if (!claimId1.HasValue)
            break;
          claimId1 = this._currentClaim.ClaimId;
          Utility.DeleteClaimLock(claimId1.Value);
          break;
      }
    }
    else
    {
      if (this._currentClaim == null)
        return;
      int? claimId2 = this._currentClaim.ClaimId;
      if (!claimId2.HasValue)
        return;
      claimId2 = this._currentClaim.ClaimId;
      Utility.DeleteClaimLock(claimId2.Value);
    }
  }

  private void FormClaims_Shown(object sender, EventArgs e)
  {
    if (!this._isRecreatingEntity)
      return;
    this.SendToBack();
  }

  private void FormClaims_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    if (this._currentClaim != null && this._currentClaim.ClaimGuid != Guid.Empty)
      Note_System.Instance.UIInteractive.ViewPopupNotes(Guid.Empty, this._currentClaim.ClaimGuid, (Form) this);
    if (this._currentClaim != null && !string.IsNullOrEmpty(this._currentClaim.ClaimNumber))
    {
      StringBuilder stringBuilder = new StringBuilder();
      stringBuilder.Append(this.Text);
      stringBuilder.Append(" - Claim #: ");
      stringBuilder.Append(this._currentClaim.ClaimNumber);
      this.Text = stringBuilder.ToString();
    }
    this.DoFormLoad();
    this.SetReadOnlyMode();
  }

  private void DoFormLoad()
  {
    this.HookUpClaimEvents();
    if (this._currentClaim != null)
    {
      this.DisplayClaim();
      this.BindClaimantsGrids();
      this.GetPolicyDriverInfo(this._currentClaim.ControlNumber);
      int? claimId = this._currentClaim.ClaimId;
      if (claimId.HasValue)
      {
        string action = $"{CurrentUser.Instance.DisplayNameLastFirst} open claim {this._currentClaim.ClaimNumber}.";
        claimId = this._currentClaim.ClaimId;
        int identifier = claimId.Value;
        Utility.LogAction(action, identifier);
      }
    }
    this.HashForm();
  }

  protected internal virtual void SaveClaim(bool redisplayClaim)
  {
    if (!this.VerifyClaim(true))
      return;
    if (this._currentClaim != null)
    {
      try
      {
        this.SetupClaimObject();
        if (!this._currentClaim.Save())
          return;
        this.OnClaimSaved();
      }
      catch (ClaimNumberingException ex)
      {
        int num = (int) MessageBox.Show(ex.Message, Resources.ERROR_REQUIREDFIELD_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }
    }
    if (!redisplayClaim)
      return;
    this.RedisplayClaim();
  }

  public virtual bool SetupClaimObject()
  {
    if (this._currentClaim.IsManualClaimNumber && !((EditorButtonControlBase) this.textOverview_ClaimNumber).ReadOnly)
      this.CurrentClaim.ClaimNumber = ((Control) this.textOverview_ClaimNumber).Text;
    this.CurrentClaim.LossDate = ((UltraDateTimeEditor) this.dateTimeOverview_LossDate).DateTime;
    if (((UltraDropDownBase) this.comboClaim_CatastropheCode).SelectedRow != null)
      this.CurrentClaim.CatastropheCode = ((UltraCombo) this.comboClaim_CatastropheCode).Value.ToString();
    this.CurrentClaim.ClaimComments = ((Control) this.textOverview_Comments).Text;
    this.CurrentClaim.InhouseAdjusterGuid = ((UltraDropDownBase) this.comboAdjusterAssigned).SelectedRow == null ? Guid.Empty : new Guid(((UltraCombo) this.comboAdjusterAssigned).Value.ToString());
    this.SetClaimAccidentInformation();
    this.SetClaimDriverInfo();
    return true;
  }

  protected event FormClaims.ClaimSavedHandler ClaimSaved;

  protected event EventHandler<EventArgs> RedisplayingClaim;

  protected void OnClaimSaved()
  {
    FormClaims.ClaimSavedHandler claimSaved = this.ClaimSaved;
    if (claimSaved == null)
      return;
    claimSaved((object) this, new ClaimSavedEventArgs(this.CurrentClaim.ClaimId.Value));
  }

  protected event FormClaims.ModifyReserveFormShowHandler ModifyReserveShown;

  protected void OnModifyReserveFormShown(FormModifyReserve f)
  {
    FormClaims.ModifyReserveFormShowHandler modifyReserveShown = this.ModifyReserveShown;
    if (modifyReserveShown == null)
      return;
    modifyReserveShown((object) this, new ModifyReserveFormShownEventArgs(f, this.CurrentClaim.ClaimId.Value));
  }

  protected void OnRedisplayingClaim()
  {
    if (this.RedisplayingClaim == null)
      return;
    this.RedisplayingClaim((object) this, new EventArgs());
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
    get => this.CurrentClaim == null ? Guid.Empty : this.CurrentClaim.ClaimGuid;
  }

  string IRecreatableEntity.EntityName => this.CurrentClaim?.ClaimNumber ?? string.Empty;

  string IRecreatableEntity.FriendlyEntityName => "Claims";

  bool IRecreatableEntity.HasControlGUID => false;

  bool IRecreatableEntity.RecreateEntityInitialize(Guid entityGuid)
  {
    if ((string) DefaultDatabase.ExecuteScalar("spClaims_GetEntityType", new object[2]
    {
      (object) "@entityGuid",
      (object) entityGuid
    }) == "CLMNT")
    {
      int num = (int) DefaultDatabase.ExecuteScalar(CommandType.Text, "Select dbo.Claims_GetClaimantClaimId(@claimantGuid)", new object[2]
      {
        (object) "@claimantGuid",
        (object) entityGuid
      });
      if (num == -1)
        return false;
      this._currentClaim = ObjectFactory.Instance.CreateObjectAs<Claim>((object) num);
      this.InitializeRecreation();
      this.GetPolicyDriverInfo(this._currentClaim.ControlNumber);
      this._isRecreatingEntity = true;
      foreach (UltraGridRow row in ((UltraGridBase) this.gridOverview_Claimants).Rows)
      {
        if (row.Cells["ClaimantGuid"].Value.ToString() == entityGuid.ToString())
        {
          ((GridItemBase) row).Selected = true;
          row.Activate();
          this.EditClaimant();
        }
      }
      return true;
    }
    this._currentClaim = (Claim) ObjectFactory.Instance.CreateObject(typeof (Claim), new object[1]
    {
      (object) entityGuid
    });
    this.InitializeRecreation();
    this.GetPolicyDriverInfo(this._currentClaim.ControlNumber);
    this._isRecreatingEntity = false;
    return true;
  }

  string IRecreatableEntity.RecreateTypeName => typeof (FormClaims).ToString();

  private void InitializeRecreation()
  {
    this.HookUpClaimEvents();
    this._controlNumber = this._currentClaim.ControlNumber;
    this.DisplayClaim();
    this.BindClaimantsGrids();
    this._initValueHash = Utility.GetValueHash((object) this);
  }

  private void gridUnallocatedExpenses_MouseEnterElement(object sender, UIElementEventArgs e)
  {
    ((UltraGridBase) this.gridUnallocatedExpenses).DisplayLayout.Override.TipStyleCell = (TipStyle) 2;
    if (!(e.Element is CellUIElement) || !(((KeyedSubObjectBase) (e.Element.GetContext(typeof (UltraGridCell)) as UltraGridCell).Column).Key == "Comments") || string.IsNullOrEmpty((e.Element.GetContext(typeof (UltraGridCell)) as UltraGridCell).Value.ToString()))
      return;
    this.ultraToolTipManager1.SetUltraToolTip((Control) this.gridUnallocatedExpenses, new UltraToolTipInfo((e.Element.GetContext(typeof (UltraGridCell)) as UltraGridCell).Value.ToString(), (ToolTipImage) 3, "Comments", (DefaultableBoolean) 1));
    this.ultraToolTipManager1.ShowToolTip((Control) this.gridUnallocatedExpenses);
  }

  private void gridUnallocatedExpenses_MouseLeaveElement(object sender, UIElementEventArgs e)
  {
    this.ClearToolTip();
  }

  protected void ClearToolTip()
  {
    this.ultraToolTipManager1.SetUltraToolTip((Control) null, new UltraToolTipInfo(string.Empty, (ToolTipImage) 2, string.Empty, (DefaultableBoolean) 2));
    this.ultraToolTipManager1.HideToolTip();
  }

  protected virtual void LoadUsers()
  {
    ((UltraGridBase) this.comboAdjusterAssigned).DataSource = (object) DefaultDatabase.ExecuteDataSet("spClaims_GetInhouseAdjusters").Tables[0];
    ((UltraDropDownBase) this.comboAdjusterAssigned).DisplayMember = "UserName";
    ((UltraDropDownBase) this.comboAdjusterAssigned).ValueMember = "UserGuid";
  }

  protected virtual void LoadCatastroheCodes()
  {
    ((UltraGridBase) this.comboClaim_CatastropheCode).DataSource = (object) DefaultDatabase.ExecuteDataSet("spClaims_GetCatastropheCodes").Tables[0];
    ((UltraDropDownBase) this.comboClaim_CatastropheCode).DisplayMember = "CatastropheCode";
    ((UltraDropDownBase) this.comboClaim_CatastropheCode).ValueMember = "CatastropheCodeId";
    this.comboClaim_CatastropheCode.DisplayLayout.Bands[0].Columns["CatastropheCodeId"].Hidden = true;
    ((HeaderBase) this.comboClaim_CatastropheCode.DisplayLayout.Bands[0].Columns["CatastropheCodeDescription"].Header).Caption = "Description";
    this.comboClaim_CatastropheCode.DisplayLayout.Bands[0].HeaderVisible = false;
    this.comboClaim_CatastropheCode.DisplayLayout.Bands[0].Override.SelectedRowAppearance.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    this.comboClaim_CatastropheCode.DisplayLayout.Bands[0].Override.SelectedRowAppearance.BorderColor = Color.FromArgb((int) byte.MaxValue, 214, 88);
    this.comboClaim_CatastropheCode.DisplayLayout.Bands[0].Override.SelectedRowAppearance.ForeColor = Color.Black;
    ((UltraDropDownBase) this.comboClaim_CatastropheCode).DropDownWidth = 350;
  }

  private void buttonMapLocation_Click(object sender, EventArgs e)
  {
    this.mapBing.Visible = true;
    if (string.IsNullOrEmpty(((Control) this.textLatCoord).Text) || string.IsNullOrEmpty(((Control) this.textLongCoords).Text))
      this.mapBing.RenderAddress(this.addressResolverAccidentLocation.Address1, this.addressResolverAccidentLocation.City, this.addressResolverAccidentLocation.State, this.addressResolverAccidentLocation.ZipCode);
    else
      this.mapBing.RenderAddress(float.Parse(((Control) this.textLatCoord).Text, NumberStyles.Any), float.Parse(((Control) this.textLongCoords).Text, NumberStyles.Any));
  }

  public event ISupportDocumentSystem.EntityInfoChangedEventHandler EntityInfoChanged;

  bool ISupportDocumentSystem.AllowAddNewDocument => true;

  bool ISupportNoteSystem.CanCreateNewNote => true;

  public event ISupportNoteSystem.EntityInfoChangedEventHandler NoteEntityInfoChanged;

  event ISupportNoteSystem.EntityInfoChangedEventHandler ISupportNoteSystem.EntityInfoChanged
  {
    add => this.NoteEntityInfoChanged += value;
    remove => this.NoteEntityInfoChanged += value;
  }

  protected virtual void LoadClaimActivityLog()
  {
    DataSet ds = new DataSet();
    using (BackgroundWorker backgroundWorker = new BackgroundWorker())
    {
      backgroundWorker.DoWork += (DoWorkEventHandler) ((sender, e) => ds = DefaultDatabase.ExecuteDataSet("spClaims_GetClaimActivityLog", new object[2]
      {
        (object) "@Claimid",
        (object) this._currentClaim.ClaimId
      }));
      backgroundWorker.RunWorkerCompleted += (RunWorkerCompletedEventHandler) ((sender, e) =>
      {
        if (this.IsDisposed)
          return;
        ((UltraGridBase) this.gridClaimStatusLog).DataSource = (object) ds.Tables[0];
        this.FormatClaimActivityGrid();
      });
      backgroundWorker.RunWorkerAsync();
    }
  }

  private void FormatClaimActivityGrid()
  {
    UltraGridBand band = ((UltraGridBase) this.gridClaimStatusLog).DisplayLayout.Bands[0];
    if (((KeyedSubObjectsCollectionBase) band.Columns).Exists("claimActivityId"))
      band.Columns["claimActivityId"].Hidden = true;
    if (((KeyedSubObjectsCollectionBase) band.Columns).Exists("userGuid"))
      band.Columns["userGuid"].Hidden = true;
    band.Override.HeaderAppearance.TextHAlign = (HAlign) 1;
  }

  private void gridOverview_Claimants_InitializeRow(object sender, InitializeRowEventArgs e)
  {
  }

  public List<int> SupportedTemplateGroupIDs
  {
    get => new List<int>() { 10 };
  }

  public object[] TagParserConstructorArgs(int automationDocGroupID)
  {
    if (this._currentClaim == null || !(this._currentClaim.ClaimGuid != Guid.Empty))
      return new object[0];
    return new object[1]
    {
      (object) this._currentClaim.ClaimGuid
    };
  }

  private void textOverview_Producer_MouseEnter(object sender, EventArgs e)
  {
    try
    {
      this.Cursor = MgaCursors.WaitCursor;
      if (((Control) this.textOverview_Producer).Tag != null)
        return;
      UltraToolTipInfo ultraToolTipInfo = new UltraToolTipInfo(Utility.GetEntityAddressToolTip(this._currentClaim.ControlNumber, this._currentClaim.PolicyInformation.ProducerLocationGuid), (ToolTipImage) 2, ((Control) this.textOverview_Producer).Text, (DefaultableBoolean) 1);
      ((Control) this.textOverview_Producer).Tag = (object) ultraToolTipInfo;
      this.ultraToolTipManager1.SetUltraToolTip((Control) this.textOverview_Producer, ultraToolTipInfo);
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
    }
  }

  private void textOverview_Insured_MouseEnter(object sender, EventArgs e)
  {
    try
    {
      this.Cursor = MgaCursors.WaitCursor;
      if (((Control) this.textOverview_Insured).Tag != null)
        return;
      UltraToolTipInfo ultraToolTipInfo = new UltraToolTipInfo(Utility.GetEntityAddressToolTip(this._currentClaim.ControlNumber, this._currentClaim.PolicyInformation.InsuredGuid), (ToolTipImage) 2, ((Control) this.textOverview_Insured).Text, (DefaultableBoolean) 1);
      ((Control) this.textOverview_Insured).Tag = (object) ultraToolTipInfo;
      this.ultraToolTipManager1.SetUltraToolTip((Control) this.textOverview_Insured, ultraToolTipInfo);
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
    }
  }

  private void textOverview_Company_MouseEnter(object sender, EventArgs e)
  {
    try
    {
      this.Cursor = MgaCursors.WaitCursor;
      if (((Control) this.textOverview_Company).Tag != null)
        return;
      UltraToolTipInfo ultraToolTipInfo = new UltraToolTipInfo(Utility.GetEntityAddressToolTip(this._currentClaim.ControlNumber, this._currentClaim.PolicyInformation.CompanyGuid), (ToolTipImage) 2, ((Control) this.textOverview_Company).Text, (DefaultableBoolean) 1);
      ((Control) this.textOverview_Company).Tag = (object) ultraToolTipInfo;
      this.ultraToolTipManager1.SetUltraToolTip((Control) this.textOverview_Company, ultraToolTipInfo);
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
    }
  }

  private void BindCustomControlProperties()
  {
    ((Control) this.gridDrivers).DataBindings.Add("Enabled", (object) this.radioListedDriver, "Checked");
    ((Control) this.textDriverFirstName).DataBindings.Add("Enabled", (object) this.radioNonListedDriver, "Checked");
    ((Control) this.textDriverLastName).DataBindings.Add("Enabled", (object) this.radioNonListedDriver, "Checked");
  }

  protected virtual void GetPolicyDriverInfo(int controlNo)
  {
    UltraGrid gridDrivers = this.gridDrivers;
    object[] objArray = new object[4]
    {
      (object) "@ControlNo",
      (object) controlNo,
      (object) "@ClaimId",
      null
    };
    SqlInt32 sqlInt32;
    if (this._currentClaim != null)
    {
      int? claimId = this._currentClaim.ClaimId;
      if (claimId.HasValue)
      {
        claimId = this._currentClaim.ClaimId;
        sqlInt32 = (SqlInt32) claimId.Value;
        goto label_4;
      }
    }
    sqlInt32 = SqlInt32.Null;
label_4:
    objArray[3] = (object) sqlInt32;
    DataSet dataSet = DefaultDatabase.ExecuteDataSet("spClaims_ClaimGetPolicyDrivers", objArray);
    ((UltraGridBase) gridDrivers).DataSource = (object) dataSet;
    UltraGridBand band = ((UltraGridBase) this.gridDrivers).DisplayLayout.Bands[0];
    band.Override.HeaderAppearance.TextHAlign = (HAlign) 1;
    band.Override.AllowAddNew = (AllowAddNew) 2;
    band.Override.AllowUpdate = (DefaultableBoolean) 1;
    band.Columns["DriverId"].Hidden = true;
    band.Columns["Select"].Style = (ColumnStyle) 3;
    ((HeaderBase) band.Columns["Select"].Header).VisiblePosition = 0;
    band.Columns["Select"].Width = 16 /*0x10*/;
    band.Columns["Select"].CellActivation = (Activation) 0;
    ((HeaderBase) band.Columns["Select"].Header).Caption = string.Empty;
    foreach (UltraGridColumn column in band.Columns)
    {
      if (((KeyedSubObjectBase) column).Key != "Select")
        column.CellActivation = (Activation) 3;
    }
    if (this._currentClaim == null)
      return;
    int? claimId1 = this._currentClaim.ClaimId;
    if (!claimId1.HasValue)
      return;
    claimId1 = this._currentClaim.ClaimId;
    this.DisplayDriverInformation(claimId1.Value);
  }

  protected void DisplayDriverInformation(int claimId)
  {
    DataRow dataRow = DefaultDatabase.ExecuteDataRow("spClaims_GetDriverInformation", new object[2]
    {
      (object) "@claimId",
      (object) claimId
    });
    if (dataRow == null || dataRow.ItemArray.Length == 0)
      return;
    if (ExtensionsMethods.FieldIsNull<bool>(dataRow, "parkedVehicle", false))
    {
      this.radioParkedVehicle.Checked = true;
    }
    else
    {
      int num = ExtensionsMethods.FieldIsNull<int>(dataRow, "driverid", -1);
      if (num != -1)
      {
        foreach (UltraGridRow row in ((UltraGridBase) this.gridDrivers).Rows)
        {
          if (int.Parse(row.Cells["driverid"].Value.ToString()) == num)
          {
            row.Cells["Select"].Value = (object) true;
            break;
          }
        }
        this.radioListedDriver.Checked = true;
      }
      else
        this.GetUnlistedDriverInformation(this._currentClaim.ClaimId.Value);
    }
  }

  private void SetClaimDriverInfo()
  {
    if (this._currentClaim == null)
      return;
    ClaimDriverInformation driverInformation1 = new ClaimDriverInformation();
    int? claimId = this._currentClaim.ClaimId;
    if (claimId.HasValue)
    {
      ClaimDriverInformation driverInformation2 = driverInformation1;
      claimId = this._currentClaim.ClaimId;
      int num = claimId.Value;
      driverInformation2.ClaimId = num;
    }
    if (this.radioListedDriver.Checked)
    {
      foreach (UltraGridRow row in ((UltraGridBase) this.gridDrivers).Rows)
      {
        if ((bool) row.Cells["Select"].Value)
        {
          driverInformation1.DriverId = int.Parse(row.Cells["DriverId"].Value.ToString());
          this._currentClaim.DriverInfo = driverInformation1;
          return;
        }
      }
      driverInformation1.ParkedVehicle = false;
    }
    else if (this.radioNonListedDriver.Checked)
    {
      driverInformation1.DriverFirstName = ((Control) this.textDriverFirstName).Text;
      driverInformation1.DriverLastName = ((Control) this.textDriverLastName).Text;
      driverInformation1.ParkedVehicle = false;
      this._currentClaim.DriverInfo = driverInformation1;
    }
    else
    {
      if (!this.radioParkedVehicle.Checked)
        return;
      driverInformation1.ParkedVehicle = true;
      this._currentClaim.DriverInfo = driverInformation1;
    }
  }

  private void GetUnlistedDriverInformation(int claimId)
  {
    DataRow dataRow = DefaultDatabase.ExecuteDataRow("spClaim_GetUnlistedDriverInfo", new object[2]
    {
      (object) "@ClaimId",
      (object) claimId
    });
    if (dataRow == null || dataRow[0] == null || string.IsNullOrEmpty(dataRow["firstname"].ToString()) && string.IsNullOrEmpty(dataRow["lastname"].ToString()))
      return;
    this.radioNonListedDriver.Checked = true;
    ((Control) this.textDriverFirstName).Text = dataRow["firstname"].ToString();
    ((Control) this.textDriverLastName).Text = dataRow["lastname"].ToString();
  }

  private void gridDrivers_CellChange(object sender, CellEventArgs e)
  {
  }

  private void gridDrivers_Click(object sender, EventArgs e)
  {
  }

  private void gridDrivers_BeforeCellUpdate(object sender, BeforeCellUpdateEventArgs e)
  {
    if (!(bool) e.NewValue)
    {
      StringBuilder stringBuilder = new StringBuilder();
      stringBuilder.Append(CurrentUser.Instance.DisplayNameLastFirst);
      stringBuilder.Append(" deselected driver ");
      if (((KeyedSubObjectsCollectionBase) ((GridItemBase) e.Cell.Row).Band.Columns).Exists("Driver Name"))
      {
        stringBuilder.Append(e.Cell.Row.Cells["Driver Name"].Value);
      }
      else
      {
        stringBuilder.Append("<Driver Name Not Found!> driver id ");
        stringBuilder.Append(e.Cell.Row.Cells["driverid"].Value);
      }
      if (this._currentClaim != null && this._currentClaim.ClaimId.HasValue)
      {
        Utility.LogAction(stringBuilder.ToString(), this._currentClaim.ClaimId.Value);
      }
      else
      {
        if (this._currentClaim == null)
          return;
        this._currentClaim.LoggingList.Add(stringBuilder.ToString());
      }
    }
    else
    {
      StringBuilder stringBuilder = new StringBuilder();
      stringBuilder.Append(CurrentUser.Instance.DisplayNameLastFirst);
      stringBuilder.Append(" selected driver ");
      if (((KeyedSubObjectsCollectionBase) ((GridItemBase) e.Cell.Row).Band.Columns).Exists("Driver Name"))
      {
        stringBuilder.Append(e.Cell.Row.Cells["Driver Name"].Value);
      }
      else
      {
        stringBuilder.Append("<Driver Name Not Found!> driver id ");
        stringBuilder.Append(e.Cell.Row.Cells["driverid"].Value);
      }
      if (this._currentClaim != null && this._currentClaim.ClaimId.HasValue)
      {
        Utility.LogAction(stringBuilder.ToString(), this._currentClaim.ClaimId.Value);
      }
      else
      {
        if (this._currentClaim == null)
          return;
        this._currentClaim.LoggingList.Add(stringBuilder.ToString());
      }
    }
  }

  private void gridDrivers_ClickCell(object sender, ClickCellEventArgs e)
  {
    if (((SparseCollectionBase) this.gridDrivers.Selected.Rows).Count == 0)
      return;
    foreach (UltraGridRow row in ((UltraGridBase) this.gridDrivers).Rows)
    {
      if ((bool) row.Cells["Select"].Value)
        row.Cells["Select"].Value = (object) false;
    }
    this.gridDrivers.Selected.Rows[0].Cells["Select"].Value = (object) !(bool) this.gridDrivers.Selected.Rows[0].Cells["Select"].Value;
    ((UltraGridBase) this.gridDrivers).UpdateData();
  }

  private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    if (!SecurityManager.Instance.AssertPermission("{68F0B71D-DB74-4048-9D6C-86379996CFB2}"))
    {
      int num = (int) MessageBox.Show("You do not have permission to perform this action.", "Insufficient Rights!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else
    {
      int result = 0;
      if (string.IsNullOrEmpty(((Control) this.textOverview_ControlNumber).Text) || !int.TryParse(((Control) this.textOverview_ControlNumber).Text, out result) || !Quote.ControlNumberExists(result))
        return;
      MGASystems.Common.FormSettings.ShowForm(typeof (frmPolicyDetail), (object) result);
    }
  }

  private void SetReadOnlyMode()
  {
    if (SecurityManager.Instance.AssertPermission("{EB460F2D-0BDA-4FA1-9931-D08994969163}"))
      return;
    foreach (Control control in (ArrangedElementCollection) this.Controls)
    {
      if (control.GetType() != typeof (UltraTabControl))
        control.Enabled = false;
    }
    foreach (UltraTab tab in ((UltraTabControlBase) this.tabControlClaim).Tabs)
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

  private void buttonEditClaimNumber_Click(object sender, EventArgs e)
  {
    if (!SecurityManager.Instance.AssertPermission("{D01270EE-776B-4FE7-B85D-D6536230ECDA}"))
    {
      int num1 = (int) MessageBox.Show("You do not have rights to perform this action!", "Access Denied!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
    }
    else
    {
      this._currentClaim.IsManualClaimNumber = Utility.HasManualClaimNumberRule(this._currentClaim.PolicyInformation.CompanyGuid, this._currentClaim.PolicyInformation.CompanyLocationGuid, this._currentClaim.PolicyInformation.LineGuid, this._currentClaim.PolicyInformation.PolicyEffectiveDate);
      if (!this._currentClaim.IsManualClaimNumber)
      {
        int num2 = (int) MessageBox.Show("This claim is already linked to an automated claim number rule.", "Cannot Change Number", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
      else
      {
        int? claimId = this._currentClaim.ClaimId;
        if (!claimId.HasValue)
          return;
        claimId = this._currentClaim.ClaimId;
        using (FormEditClaimNumber formEditClaimNumber = new FormEditClaimNumber(claimId.Value, this._currentClaim.ClaimNumber))
        {
          if (formEditClaimNumber.ShowDialog() != DialogResult.OK)
            return;
          this.RedisplayClaim();
        }
      }
    }
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
    ValueListItem valueListItem1 = new ValueListItem();
    ValueListItem valueListItem2 = new ValueListItem();
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    Appearance appearance17 = new Appearance();
    Appearance appearance18 = new Appearance();
    Appearance appearance19 = new Appearance();
    Appearance appearance20 = new Appearance();
    ScrollBarLook scrollBarLook1 = new ScrollBarLook();
    Appearance appearance21 = new Appearance();
    Appearance appearance22 = new Appearance();
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
    Appearance appearance51 = new Appearance();
    Appearance appearance52 = new Appearance();
    Appearance appearance53 = new Appearance();
    Appearance appearance54 = new Appearance();
    Appearance appearance55 = new Appearance();
    ScrollBarLook scrollBarLook2 = new ScrollBarLook();
    Appearance appearance56 = new Appearance();
    Appearance appearance57 = new Appearance();
    Appearance appearance58 = new Appearance();
    Appearance appearance59 = new Appearance();
    Appearance appearance60 = new Appearance();
    Appearance appearance61 = new Appearance();
    Appearance appearance62 = new Appearance();
    Appearance appearance63 = new Appearance();
    Appearance appearance64 = new Appearance();
    ScrollBarLook scrollBarLook3 = new ScrollBarLook();
    Appearance appearance65 = new Appearance();
    Appearance appearance66 = new Appearance();
    Appearance appearance67 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("Claimants", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("ClaimantGuid");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("ClaimantName");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("Claimants_ReservePaymentBreakout");
    UltraGridBand ultraGridBand2 = new UltraGridBand("Claimants_ReservePaymentBreakout", 0);
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("ClaimantGuid");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("ClaimantName");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("ResPayTypeId");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("ResPayTypeDescription");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("ResPaySubTypeId");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("ResPaySubTypeDescription");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("CoverageTypeId");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("CoverageType");
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("CoverageTypeDescriptionId");
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("CoverageTypeDescription");
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("TotalReserve");
    Appearance appearance68 = new Appearance();
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("TotalPayments");
    Appearance appearance69 = new Appearance();
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("RemainingReserves");
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
    ScrollBarLook scrollBarLook4 = new ScrollBarLook();
    Appearance appearance80 = new Appearance();
    Appearance appearance81 = new Appearance();
    UltraGridLayout ultraGridLayout1 = new UltraGridLayout("ReservePaymentBreakout");
    Appearance appearance82 = new Appearance();
    UltraGridBand ultraGridBand3 = new UltraGridBand("Claimants", -1);
    UltraGridColumn ultraGridColumn17 = new UltraGridColumn("ClaimantGuid");
    UltraGridColumn ultraGridColumn18 = new UltraGridColumn("ClaimantName");
    UltraGridColumn ultraGridColumn19 = new UltraGridColumn("Claimants_ReservePaymentBreakout");
    UltraGridBand ultraGridBand4 = new UltraGridBand("Claimants_ReservePaymentBreakout", 0);
    UltraGridColumn ultraGridColumn20 = new UltraGridColumn("ClaimantGuid");
    UltraGridColumn ultraGridColumn21 = new UltraGridColumn("ClaimantName");
    UltraGridColumn ultraGridColumn22 = new UltraGridColumn("ResPayTypeId");
    UltraGridColumn ultraGridColumn23 = new UltraGridColumn("ResPayTypeDescription");
    UltraGridColumn ultraGridColumn24 = new UltraGridColumn("ResPaySubTypeId");
    UltraGridColumn ultraGridColumn25 = new UltraGridColumn("ResPaySubTypeDescription");
    UltraGridColumn ultraGridColumn26 = new UltraGridColumn("CoverageTypeId");
    UltraGridColumn ultraGridColumn27 = new UltraGridColumn("CoverageType");
    UltraGridColumn ultraGridColumn28 = new UltraGridColumn("CoverageTypeDescriptionId");
    UltraGridColumn ultraGridColumn29 = new UltraGridColumn("CoverageTypeDescription");
    UltraGridColumn ultraGridColumn30 = new UltraGridColumn("TotalReserve");
    Appearance appearance83 = new Appearance();
    UltraGridColumn ultraGridColumn31 = new UltraGridColumn("TotalPayments");
    Appearance appearance84 = new Appearance();
    UltraGridColumn ultraGridColumn32 = new UltraGridColumn("RemainingReserves");
    Appearance appearance85 = new Appearance();
    Appearance appearance86 = new Appearance();
    Appearance appearance87 = new Appearance();
    Appearance appearance88 = new Appearance();
    Appearance appearance89 = new Appearance();
    Appearance appearance90 = new Appearance();
    Appearance appearance91 = new Appearance();
    Appearance appearance92 = new Appearance();
    Appearance appearance93 = new Appearance();
    Appearance appearance94 = new Appearance();
    ScrollBarLook scrollBarLook5 = new ScrollBarLook();
    Appearance appearance95 = new Appearance();
    Appearance appearance96 = new Appearance();
    Appearance appearance97 = new Appearance();
    Appearance appearance98 = new Appearance();
    Appearance appearance99 = new Appearance();
    UltraGridBand ultraGridBand5 = new UltraGridBand("", -1);
    Appearance appearance100 = new Appearance();
    Appearance appearance101 = new Appearance();
    Appearance appearance102 = new Appearance();
    Appearance appearance103 = new Appearance();
    Appearance appearance104 = new Appearance();
    Appearance appearance105 = new Appearance();
    Appearance appearance106 = new Appearance();
    Appearance appearance107 = new Appearance();
    Appearance appearance108 = new Appearance();
    Appearance appearance109 = new Appearance();
    Appearance appearance110 = new Appearance();
    Appearance appearance111 = new Appearance();
    Appearance appearance112 = new Appearance();
    Appearance appearance113 = new Appearance();
    UltraToolTipInfo ultraToolTipInfo1 = new UltraToolTipInfo("Click to edit the claim number.", (ToolTipImage) 0, "Edit Claim Number", (DefaultableBoolean) 0);
    Appearance appearance114 = new Appearance();
    Appearance appearance115 = new Appearance();
    Appearance appearance116 = new Appearance();
    Appearance appearance117 = new Appearance();
    Appearance appearance118 = new Appearance();
    Appearance appearance119 = new Appearance();
    Appearance appearance120 = new Appearance();
    Appearance appearance121 = new Appearance();
    Appearance appearance122 = new Appearance();
    Appearance appearance123 = new Appearance();
    Appearance appearance124 = new Appearance();
    Appearance appearance125 = new Appearance();
    Appearance appearance126 = new Appearance();
    ScrollBarLook scrollBarLook6 = new ScrollBarLook();
    Appearance appearance127 = new Appearance();
    Appearance appearance128 = new Appearance();
    Appearance appearance129 = new Appearance();
    Appearance appearance130 = new Appearance();
    Appearance appearance131 = new Appearance();
    Appearance appearance132 = new Appearance();
    Appearance appearance133 = new Appearance();
    Appearance appearance134 = new Appearance();
    Appearance appearance135 = new Appearance();
    Appearance appearance136 = new Appearance();
    UltraGridBand ultraGridBand6 = new UltraGridBand("ExpenseList", -1);
    UltraGridColumn ultraGridColumn33 = new UltraGridColumn("UAExpenseId");
    UltraGridColumn ultraGridColumn34 = new UltraGridColumn("ClaimId");
    UltraGridColumn ultraGridColumn35 = new UltraGridColumn("ClaimantGuid");
    UltraGridColumn ultraGridColumn36 = new UltraGridColumn("DateEntered", -1, (object) null, 11401422, 0, 0);
    UltraGridColumn ultraGridColumn37 = new UltraGridColumn("ExpenseDescription", -1, (object) null, 11401422, 1, 0);
    UltraGridColumn ultraGridColumn38 = new UltraGridColumn("AutomationCode");
    UltraGridColumn ultraGridColumn39 = new UltraGridColumn("Automated", -1, (object) null, 11401422, 2, 0);
    Appearance appearance137 = new Appearance();
    UltraGridColumn ultraGridColumn40 = new UltraGridColumn("ExpenseId");
    UltraGridColumn ultraGridColumn41 = new UltraGridColumn("UserGuid");
    UltraGridColumn ultraGridColumn42 = new UltraGridColumn("EnteredBy", -1, (object) null, 11401422, 12, 1);
    UltraGridColumn ultraGridColumn43 = new UltraGridColumn("ARCreated", -1, (object) null, 11401422, 14, 1);
    Appearance appearance138 = new Appearance();
    UltraGridColumn ultraGridColumn44 = new UltraGridColumn("DateARCreated", -1, (object) null, 11401422, 15, 1);
    UltraGridColumn ultraGridColumn45 = new UltraGridColumn("ARCreatedBy", -1, (object) null, 11401422, 16 /*0x10*/, 1);
    UltraGridColumn ultraGridColumn46 = new UltraGridColumn("Waived", -1, (object) null, 11401422, 17, 1);
    Appearance appearance139 = new Appearance();
    UltraGridColumn ultraGridColumn47 = new UltraGridColumn("WaivedBy", -1, (object) null, 11401422, 19, 1);
    UltraGridColumn ultraGridColumn48 = new UltraGridColumn("DateWaived", -1, (object) null, 11401422, 18, 1);
    UltraGridColumn ultraGridColumn49 = new UltraGridColumn("Comments", -1, (object) null, 11401422, 13, 1);
    UltraGridColumn ultraGridColumn50 = new UltraGridColumn("Hours", -1, (object) null, 11401422, 3, 0);
    Appearance appearance140 = new Appearance();
    Appearance appearance141 = new Appearance();
    UltraGridColumn ultraGridColumn51 = new UltraGridColumn("HourlyRate", -1, (object) null, 11401422, 4, 0);
    Appearance appearance142 = new Appearance();
    UltraGridColumn ultraGridColumn52 = new UltraGridColumn("HourlyAmount", -1, (object) null, 11401422, 5, 0);
    Appearance appearance143 = new Appearance();
    Appearance appearance144 = new Appearance();
    UltraGridColumn ultraGridColumn53 = new UltraGridColumn("EquipmentRate", -1, (object) null, 11401422, 6, 0);
    Appearance appearance145 = new Appearance();
    Appearance appearance146 = new Appearance();
    UltraGridColumn ultraGridColumn54 = new UltraGridColumn("EquipmentAmount", -1, (object) null, 11401422, 7, 0);
    Appearance appearance147 = new Appearance();
    Appearance appearance148 = new Appearance();
    UltraGridColumn ultraGridColumn55 = new UltraGridColumn("OtherCost", -1, (object) null, 11401422, 8, 0);
    Appearance appearance149 = new Appearance();
    Appearance appearance150 = new Appearance();
    UltraGridColumn ultraGridColumn56 = new UltraGridColumn("OtherCount", -1, (object) null, 11401422, 9, 0);
    Appearance appearance151 = new Appearance();
    Appearance appearance152 = new Appearance();
    UltraGridColumn ultraGridColumn57 = new UltraGridColumn("OtherAmount", -1, (object) null, 11401422, 10, 0);
    Appearance appearance153 = new Appearance();
    Appearance appearance154 = new Appearance();
    UltraGridColumn ultraGridColumn58 = new UltraGridColumn("TotalAmount", -1, (object) null, 11401422, 11, 0);
    Appearance appearance155 = new Appearance();
    Appearance appearance156 = new Appearance();
    UltraGridGroup ultraGridGroup1 = new UltraGridGroup("NewGroup0", 11401422);
    Appearance appearance157 = new Appearance();
    Appearance appearance158 = new Appearance();
    SummarySettings summarySettings1 = new SummarySettings("GrandTotalSum", (SummaryType) 1, (string) null, "TotalAmount", 25, true, "ExpenseList", 0, (SummaryPosition) 3, "TotalAmount", 25, true);
    Appearance appearance159 = new Appearance();
    SummarySettings summarySettings2 = new SummarySettings("OtherTotalSum", (SummaryType) 1, (string) null, "OtherAmount", 24, true, "ExpenseList", 0, (SummaryPosition) 3, "OtherAmount", 24, true);
    Appearance appearance160 = new Appearance();
    SummarySettings summarySettings3 = new SummarySettings("", (SummaryType) 1, (string) null, "EquipmentAmount", 21, true, "ExpenseList", 0, (SummaryPosition) 3, "EquipmentAmount", 21, true);
    Appearance appearance161 = new Appearance();
    SummarySettings summarySettings4 = new SummarySettings("", (SummaryType) 1, (string) null, "HourlyAmount", 19, true, "ExpenseList", 0, (SummaryPosition) 3, "HourlyAmount", 19, true);
    Appearance appearance162 = new Appearance();
    SummarySettings summarySettings5 = new SummarySettings("", (SummaryType) 1, (string) null, "Hours", 17, true, "ExpenseList", 0, (SummaryPosition) 3, "Hours", 17, true);
    Appearance appearance163 = new Appearance();
    Appearance appearance164 = new Appearance();
    Appearance appearance165 = new Appearance();
    Appearance appearance166 = new Appearance();
    Appearance appearance167 = new Appearance();
    Appearance appearance168 = new Appearance();
    Appearance appearance169 = new Appearance();
    ScrollBarLook scrollBarLook7 = new ScrollBarLook();
    Appearance appearance170 = new Appearance();
    Appearance appearance171 = new Appearance();
    UltraGridLayout ultraGridLayout2 = new UltraGridLayout("Layout1");
    Appearance appearance172 = new Appearance();
    UltraGridBand ultraGridBand7 = new UltraGridBand("ExpenseList", -1);
    UltraGridColumn ultraGridColumn59 = new UltraGridColumn("UAExpenseId");
    UltraGridColumn ultraGridColumn60 = new UltraGridColumn("ClaimId");
    UltraGridColumn ultraGridColumn61 = new UltraGridColumn("ClaimantGuid");
    UltraGridColumn ultraGridColumn62 = new UltraGridColumn("DateEntered", -1, (object) null, 455230985, 0, 0);
    UltraGridColumn ultraGridColumn63 = new UltraGridColumn("ExpenseDescription", -1, (object) null, 455230985, 1, 0);
    UltraGridColumn ultraGridColumn64 = new UltraGridColumn("AutomationCode");
    UltraGridColumn ultraGridColumn65 = new UltraGridColumn("Automated", -1, (object) null, 455230985, 2, 0);
    Appearance appearance173 = new Appearance();
    UltraGridColumn ultraGridColumn66 = new UltraGridColumn("ExpenseId");
    UltraGridColumn ultraGridColumn67 = new UltraGridColumn("UserGuid");
    UltraGridColumn ultraGridColumn68 = new UltraGridColumn("EnteredBy", -1, (object) null, 455230985, 12, 1);
    UltraGridColumn ultraGridColumn69 = new UltraGridColumn("ARCreated", -1, (object) null, 455230985, 14, 1);
    Appearance appearance174 = new Appearance();
    UltraGridColumn ultraGridColumn70 = new UltraGridColumn("DateARCreated", -1, (object) null, 455230985, 15, 1);
    UltraGridColumn ultraGridColumn71 = new UltraGridColumn("ARCreatedBy", -1, (object) null, 455230985, 16 /*0x10*/, 1);
    UltraGridColumn ultraGridColumn72 = new UltraGridColumn("Waived", -1, (object) null, 455230985, 17, 1);
    Appearance appearance175 = new Appearance();
    UltraGridColumn ultraGridColumn73 = new UltraGridColumn("WaivedBy", -1, (object) null, 455230985, 19, 1);
    UltraGridColumn ultraGridColumn74 = new UltraGridColumn("DateWaived", -1, (object) null, 455230985, 18, 1);
    UltraGridColumn ultraGridColumn75 = new UltraGridColumn("Comments", -1, (object) null, 455230985, 13, 1);
    UltraGridColumn ultraGridColumn76 = new UltraGridColumn("Hours", -1, (object) null, 455230985, 3, 0);
    Appearance appearance176 = new Appearance();
    Appearance appearance177 = new Appearance();
    UltraGridColumn ultraGridColumn77 = new UltraGridColumn("HourlyRate", -1, (object) null, 455230985, 4, 0);
    Appearance appearance178 = new Appearance();
    UltraGridColumn ultraGridColumn78 = new UltraGridColumn("HourlyAmount", -1, (object) null, 455230985, 5, 0);
    Appearance appearance179 = new Appearance();
    Appearance appearance180 = new Appearance();
    UltraGridColumn ultraGridColumn79 = new UltraGridColumn("EquipmentRate", -1, (object) null, 455230985, 6, 0);
    Appearance appearance181 = new Appearance();
    Appearance appearance182 = new Appearance();
    UltraGridColumn ultraGridColumn80 = new UltraGridColumn("EquipmentAmount", -1, (object) null, 455230985, 7, 0);
    Appearance appearance183 = new Appearance();
    Appearance appearance184 = new Appearance();
    UltraGridColumn ultraGridColumn81 = new UltraGridColumn("OtherCost", -1, (object) null, 455230985, 8, 0);
    Appearance appearance185 = new Appearance();
    Appearance appearance186 = new Appearance();
    UltraGridColumn ultraGridColumn82 = new UltraGridColumn("OtherCount", -1, (object) null, 455230985, 9, 0);
    Appearance appearance187 = new Appearance();
    Appearance appearance188 = new Appearance();
    UltraGridColumn ultraGridColumn83 = new UltraGridColumn("OtherAmount", -1, (object) null, 455230985, 10, 0);
    Appearance appearance189 = new Appearance();
    Appearance appearance190 = new Appearance();
    UltraGridColumn ultraGridColumn84 = new UltraGridColumn("TotalAmount", -1, (object) null, 455230985, 11, 0);
    Appearance appearance191 = new Appearance();
    Appearance appearance192 = new Appearance();
    UltraGridGroup ultraGridGroup2 = new UltraGridGroup("NewGroup0", 455230985);
    Appearance appearance193 = new Appearance();
    Appearance appearance194 = new Appearance();
    Appearance appearance195 = new Appearance();
    Appearance appearance196 = new Appearance();
    Appearance appearance197 = new Appearance();
    Appearance appearance198 = new Appearance();
    ScrollBarLook scrollBarLook8 = new ScrollBarLook();
    Appearance appearance199 = new Appearance();
    Appearance appearance200 = new Appearance();
    UltraToolTipInfo ultraToolTipInfo2 = new UltraToolTipInfo("", (ToolTipImage) 0, (string) null, (DefaultableBoolean) 2);
    Appearance appearance201 = new Appearance();
    Appearance appearance202 = new Appearance();
    Appearance appearance203 = new Appearance();
    Appearance appearance204 = new Appearance();
    Appearance appearance205 = new Appearance();
    Appearance appearance206 = new Appearance();
    Appearance appearance207 = new Appearance();
    Appearance appearance208 = new Appearance();
    Appearance appearance209 = new Appearance();
    Appearance appearance210 = new Appearance();
    Appearance appearance211 = new Appearance();
    Appearance appearance212 = new Appearance();
    ScrollBarLook scrollBarLook9 = new ScrollBarLook();
    Appearance appearance213 = new Appearance();
    Appearance appearance214 = new Appearance();
    Appearance appearance215 = new Appearance();
    Appearance appearance216 = new Appearance();
    Appearance appearance217 = new Appearance();
    Appearance appearance218 = new Appearance();
    Appearance appearance219 = new Appearance();
    Appearance appearance220 = new Appearance();
    Appearance appearance221 = new Appearance();
    Appearance appearance222 = new Appearance();
    Appearance appearance223 = new Appearance();
    ScrollBarLook scrollBarLook10 = new ScrollBarLook();
    Appearance appearance224 = new Appearance();
    Appearance appearance225 = new Appearance();
    Appearance appearance226 = new Appearance();
    Appearance appearance227 = new Appearance();
    Appearance appearance228 = new Appearance();
    Appearance appearance229 = new Appearance();
    UltraTab ultraTab1 = new UltraTab();
    UltraTab ultraTab2 = new UltraTab();
    UltraTab ultraTab3 = new UltraTab();
    UltraTab ultraTab4 = new UltraTab();
    Appearance appearance230 = new Appearance();
    Appearance appearance231 = new Appearance();
    Appearance appearance232 = new Appearance();
    UltraTab ultraTab5 = new UltraTab();
    Appearance appearance233 = new Appearance();
    UltraTab ultraTab6 = new UltraTab();
    UltraTab ultraTab7 = new UltraTab();
    Appearance appearance234 = new Appearance();
    UltraTab ultraTab8 = new UltraTab();
    Appearance appearance235 = new Appearance();
    UltraTab ultraTab9 = new UltraTab();
    Appearance appearance236 = new Appearance();
    UltraTab ultraTab10 = new UltraTab();
    Appearance appearance237 = new Appearance();
    UltraTab ultraTab11 = new UltraTab();
    Appearance appearance238 = new Appearance();
    Appearance appearance239 = new Appearance();
    Appearance appearance240 = new Appearance();
    Appearance appearance241 = new Appearance();
    Appearance appearance242 = new Appearance();
    Appearance appearance243 = new Appearance();
    Appearance appearance244 = new Appearance();
    UltraToolbar ultraToolbar = new UltraToolbar("MainToolbar");
    ButtonTool buttonTool1 = new ButtonTool("SAVE");
    ButtonTool buttonTool2 = new ButtonTool("ADDCLAIMANT");
    ButtonTool buttonTool3 = new ButtonTool("CLEARCLAIMANTENTRY");
    ButtonTool buttonTool4 = new ButtonTool("EDITCLAIMANT");
    ButtonTool buttonTool5 = new ButtonTool("DELETECLAIMANT");
    ButtonTool buttonTool6 = new ButtonTool("UNALLOCATEDEXPENSE");
    ButtonTool buttonTool7 = new ButtonTool("USERLOG");
    Appearance appearance245 = new Appearance();
    ButtonTool buttonTool8 = new ButtonTool("ADDCLAIMANT");
    Appearance appearance246 = new Appearance();
    ButtonTool buttonTool9 = new ButtonTool("DELETECLAIMANT");
    Appearance appearance247 = new Appearance();
    ButtonTool buttonTool10 = new ButtonTool("ADDRESERVE");
    Appearance appearance248 = new Appearance();
    ButtonTool buttonTool11 = new ButtonTool("ADDPAYMENT");
    Appearance appearance249 = new Appearance();
    ButtonTool buttonTool12 = new ButtonTool("RESPAYVIEW");
    Appearance appearance250 = new Appearance();
    ButtonTool buttonTool13 = new ButtonTool("UNALLOCATEDEXPENSE");
    Appearance appearance251 = new Appearance();
    ButtonTool buttonTool14 = new ButtonTool("SAVE");
    Appearance appearance252 = new Appearance();
    ButtonTool buttonTool15 = new ButtonTool("CLOSECLAIM");
    Appearance appearance253 = new Appearance();
    ButtonTool buttonTool16 = new ButtonTool("REOPENCLAIM");
    Appearance appearance254 = new Appearance();
    ButtonTool buttonTool17 = new ButtonTool("CLEARCLAIMANTENTRY");
    Appearance appearance255 = new Appearance();
    ButtonTool buttonTool18 = new ButtonTool("EDITCLAIMANT");
    Appearance appearance256 = new Appearance();
    PopupMenuTool popupMenuTool1 = new PopupMenuTool("ULAEGridContext");
    ButtonTool buttonTool19 = new ButtonTool("DELETETRANSACTION");
    ButtonTool buttonTool20 = new ButtonTool("EDITCOMMENT");
    ButtonTool buttonTool21 = new ButtonTool("DELETETRANSACTION");
    Appearance appearance257 = new Appearance();
    ButtonTool buttonTool22 = new ButtonTool("USERLOG");
    Appearance appearance258 = new Appearance();
    PopupMenuTool popupMenuTool2 = new PopupMenuTool("ReservePaymentBreakoutContext");
    ButtonTool buttonTool23 = new ButtonTool("MODIFYRESERVE");
    ButtonTool buttonTool24 = new ButtonTool("MODIFYRESERVE");
    ButtonTool buttonTool25 = new ButtonTool("EDITCOMMENT");
    Appearance appearance259 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormClaims));
    this.tabPageClaimant = new UltraTabPageControl();
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
    this.addResolverClaimants_ClaimantAttorney = new AddressResolver_MULTI();
    this.tabPageClaimantReservesPayments = new UltraTabPageControl();
    this.gridClaimants_ReservePayments = new UltraGrid();
    this.dsReservesPayments1 = new dsReservesPayments();
    this.tabPageClaimOverview = new UltraTabPageControl();
    this.groupIncurred = new GroupBox();
    this.gridIncurred = new UltraGrid();
    this.groupBox4 = new GroupBox();
    this.gridOverview_ReservePaymentBreakout = new UltraGrid();
    this.dsReservePaymentBreakout1 = new dsReservePaymentBreakout();
    this.groupBox3 = new GroupBox();
    this.comboClaim_CatastropheCode2 = new UltraCombo();
    this.textOverview_ClaimNumber = new MGATextBox();
    this.buttonEditClaimNumber = new MGAButton();
    this.comboClaim_CatastropheCode = new MGASimpleComboBox();
    this.comboAdjusterAssigned = new MGASimpleComboBox();
    this.label56 = new Label();
    this.label55 = new Label();
    this.textOverview_Comments = new MGATextBox();
    this.dateTimeOverview_DateEntered = new MGADateTimePicker();
    this.dateTimeOverview_LossDate = new MGADateTimePicker();
    this.textOverview_EnteredBy = new MGATextBox();
    this.label6 = new Label();
    this.label5 = new Label();
    this.label4 = new Label();
    this.label3 = new Label();
    this.label2 = new Label();
    this.groupBox2 = new GroupBox();
    this.gridOverview_Claimants = new UltraGrid();
    this.groupBox1 = new GroupBox();
    this.linkViewPolicy = new LinkLabel();
    this.textOverview_EffectiveExpiration = new MGATextBox();
    this.label63 = new Label();
    this.textOverview_Line = new MGATextBox();
    this.label51 = new Label();
    this.textOverview_Company = new MGATextBox();
    this.textOverview_Producer = new MGATextBox();
    this.textOverview_Insured = new MGATextBox();
    this.textOverview_PolicyNumber = new MGATextBox();
    this.textOverview_ControlNumber = new MGATextBox();
    this.label10 = new Label();
    this.label9 = new Label();
    this.label8 = new Label();
    this.label7 = new Label();
    this.label1 = new Label();
    this.tabPageClaimReservePayments = new UltraTabPageControl();
    this.tabPageClaimLimitsLiabilities = new UltraTabPageControl();
    this.ultraTabPageControl2 = new UltraTabPageControl();
    this.gridUnallocatedExpenses = new UltraGrid();
    this.dsUnallocatedExpenses1 = new dsUnallocatedExpenses();
    this.ultraTabPageControl3 = new UltraTabPageControl();
    this.textAccidentDescription = new MGATextBox();
    this.label57 = new Label();
    this.groupBox5 = new GroupBox();
    this.label65 = new Label();
    this.textLongCoords = new MGATextBox();
    this.label64 = new Label();
    this.textLatCoord = new MGATextBox();
    this.maskAccidentTime = new MGAMaskedEdit();
    this.comboAccidentType = new MGASimpleComboBox();
    this.label60 = new Label();
    this.label59 = new Label();
    this.label58 = new Label();
    this.buttonMapLocation = new MGAButton();
    this.mapBing = new BingMap();
    this.addressResolverAccidentLocation = new AddressResolver_MULTI();
    this.ultraTabPageControl4 = new UltraTabPageControl();
    this.gridClaimStatusLog = new UltraGrid();
    this.ultraTabPageControl5 = new UltraTabPageControl();
    this.groupBox7 = new GroupBox();
    this.radioParkedVehicle = new RadioButton();
    this.textDriverLastName = new MGATextBox();
    this.label61 = new Label();
    this.textDriverFirstName = new MGATextBox();
    this.label62 = new Label();
    this.radioNonListedDriver = new RadioButton();
    this.radioListedDriver = new RadioButton();
    this.gridDrivers = new UltraGrid();
    this.buttonClearClaimant = new MGAButton();
    this.buttonAddClaimant = new MGAButton();
    this.labelCurrentClaimant = new UltraLabel();
    this.labelCurrentClaimantLabel = new UltraLabel();
    this.dsClaimActivity1 = new dsClaimActivity();
    this.tabPageClaimantContainer = new UltraTabPageControl();
    this.tabControlClaimants = new UltraTabControl();
    this.ultraTabSharedControlsPage2 = new UltraTabSharedControlsPage();
    this.ultraTabPageControl1 = new UltraTabPageControl();
    this.tabControlClaim = new UltraTabControl();
    this.ultraTabSharedControlsPage1 = new UltraTabSharedControlsPage();
    this.ultraToolTipManager1 = new UltraToolTipManager(this.components);
    this.label30 = new Label();
    this.mgaSimpleComboBox3 = new MGASimpleComboBox();
    this.mgaTextBox2 = new MGATextBox();
    this.label31 = new Label();
    this.mgaDateTimePicker2 = new MGADateTimePicker();
    this.label32 = new Label();
    this.label33 = new Label();
    this.mgaSimpleComboBox4 = new MGASimpleComboBox();
    this.label34 = new Label();
    this.mgaSimpleComboBox5 = new MGASimpleComboBox();
    this.label35 = new Label();
    this.mgaSimpleComboBox6 = new MGASimpleComboBox();
    this.label36 = new Label();
    this.mgaCheckedListBox1 = new MGACheckedListBox();
    this.mgaDateTimePicker4 = new MGADateTimePicker();
    this.label37 = new Label();
    this.dsClaimOptions1 = new dsClaimOptions();
    this._formClaims_Toolbars_Dock_Area_Left = new UltraToolbarsDockArea();
    this._formClaims_Toolbars_Dock_Area_Right = new UltraToolbarsDockArea();
    this._formClaims_Toolbars_Dock_Area_Top = new UltraToolbarsDockArea();
    this._formClaims_Toolbars_Dock_Area_Bottom = new UltraToolbarsDockArea();
    this.ultraToolbarsManager1 = new UltraToolbarsManager(this.components);
    this.phoneClaimants_Primary = new MgaPhoneNumberEntry();
    this.phoneClaimants_Mailing = new MgaPhoneNumberEntry();
    this.phoneClaimants_DefenseAttorney = new MgaPhoneNumberEntry();
    this.phoneClaimants_ClaimantAttorney = new MgaPhoneNumberEntry();
    ((Control) this.tabPageClaimant).SuspendLayout();
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
    ((Control) this.tabPageClaimOverview).SuspendLayout();
    this.groupIncurred.SuspendLayout();
    ((ISupportInitialize) this.gridIncurred).BeginInit();
    this.groupBox4.SuspendLayout();
    ((ISupportInitialize) this.gridOverview_ReservePaymentBreakout).BeginInit();
    this.dsReservePaymentBreakout1.BeginInit();
    this.groupBox3.SuspendLayout();
    ((ISupportInitialize) this.comboClaim_CatastropheCode2).BeginInit();
    ((ISupportInitialize) this.textOverview_ClaimNumber).BeginInit();
    ((ISupportInitialize) this.buttonEditClaimNumber).BeginInit();
    ((ISupportInitialize) this.comboClaim_CatastropheCode).BeginInit();
    ((ISupportInitialize) this.comboAdjusterAssigned).BeginInit();
    ((ISupportInitialize) this.textOverview_Comments).BeginInit();
    ((ISupportInitialize) this.dateTimeOverview_DateEntered).BeginInit();
    ((ISupportInitialize) this.dateTimeOverview_LossDate).BeginInit();
    ((ISupportInitialize) this.textOverview_EnteredBy).BeginInit();
    this.groupBox2.SuspendLayout();
    ((ISupportInitialize) this.gridOverview_Claimants).BeginInit();
    this.groupBox1.SuspendLayout();
    ((ISupportInitialize) this.textOverview_EffectiveExpiration).BeginInit();
    ((ISupportInitialize) this.textOverview_Line).BeginInit();
    ((ISupportInitialize) this.textOverview_Company).BeginInit();
    ((ISupportInitialize) this.textOverview_Producer).BeginInit();
    ((ISupportInitialize) this.textOverview_Insured).BeginInit();
    ((ISupportInitialize) this.textOverview_PolicyNumber).BeginInit();
    ((ISupportInitialize) this.textOverview_ControlNumber).BeginInit();
    ((Control) this.ultraTabPageControl2).SuspendLayout();
    ((ISupportInitialize) this.gridUnallocatedExpenses).BeginInit();
    this.dsUnallocatedExpenses1.BeginInit();
    ((Control) this.ultraTabPageControl3).SuspendLayout();
    ((ISupportInitialize) this.textAccidentDescription).BeginInit();
    this.groupBox5.SuspendLayout();
    ((ISupportInitialize) this.textLongCoords).BeginInit();
    ((ISupportInitialize) this.textLatCoord).BeginInit();
    ((ISupportInitialize) this.maskAccidentTime).BeginInit();
    ((ISupportInitialize) this.comboAccidentType).BeginInit();
    ((ISupportInitialize) this.buttonMapLocation).BeginInit();
    ((Control) this.ultraTabPageControl4).SuspendLayout();
    ((ISupportInitialize) this.gridClaimStatusLog).BeginInit();
    ((Control) this.ultraTabPageControl5).SuspendLayout();
    this.groupBox7.SuspendLayout();
    ((ISupportInitialize) this.textDriverLastName).BeginInit();
    ((ISupportInitialize) this.textDriverFirstName).BeginInit();
    ((ISupportInitialize) this.gridDrivers).BeginInit();
    ((ISupportInitialize) this.buttonClearClaimant).BeginInit();
    ((ISupportInitialize) this.buttonAddClaimant).BeginInit();
    this.dsClaimActivity1.BeginInit();
    ((Control) this.tabPageClaimantContainer).SuspendLayout();
    ((ISupportInitialize) this.tabControlClaimants).BeginInit();
    ((Control) this.tabControlClaimants).SuspendLayout();
    ((Control) this.ultraTabSharedControlsPage2).SuspendLayout();
    ((ISupportInitialize) this.tabControlClaim).BeginInit();
    ((Control) this.tabControlClaim).SuspendLayout();
    ((ISupportInitialize) this.mgaSimpleComboBox3).BeginInit();
    ((ISupportInitialize) this.mgaTextBox2).BeginInit();
    ((ISupportInitialize) this.mgaDateTimePicker2).BeginInit();
    ((ISupportInitialize) this.mgaSimpleComboBox4).BeginInit();
    ((ISupportInitialize) this.mgaSimpleComboBox5).BeginInit();
    ((ISupportInitialize) this.mgaSimpleComboBox6).BeginInit();
    ((ISupportInitialize) this.mgaCheckedListBox1).BeginInit();
    ((ISupportInitialize) this.mgaDateTimePicker4).BeginInit();
    this.dsClaimOptions1.BeginInit();
    ((ISupportInitialize) this.ultraToolbarsManager1).BeginInit();
    this.SuspendLayout();
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
    ((Control) this.tabPageClaimant).Controls.Add((Control) this.buttonClearClaimant);
    ((Control) this.tabPageClaimant).Controls.Add((Control) this.buttonAddClaimant);
    ((Control) this.tabPageClaimant).Controls.Add((Control) this.labelCurrentClaimant);
    ((Control) this.tabPageClaimant).Controls.Add((Control) this.labelCurrentClaimantLabel);
    ((Control) this.tabPageClaimant).Location = new Point(1, 1);
    ((Control) this.tabPageClaimant).Name = "tabPageClaimant";
    ((Control) this.tabPageClaimant).Size = new Size(951, 558);
    this.label22.AutoSize = true;
    this.label22.ForeColor = Color.Black;
    this.label22.Location = new Point(9, 132);
    this.label22.Name = "label22";
    this.label22.Size = new Size(76, 13);
    this.label22.TabIndex = 10;
    this.label22.Text = "Email Address:";
    ((AppearanceBase) appearance1).BackColor = Color.White;
    ((AppearanceBase) appearance1).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance1).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textClaimants_EmailAddress).Appearance = (AppearanceBase) appearance1;
    ((Control) this.textClaimants_EmailAddress).BackColor = Color.White;
    ((Control) this.textClaimants_EmailAddress).Location = new Point(119, 133);
    this.textClaimants_EmailAddress.MGAStyle = (MGAStyles) 2;
    ((Control) this.textClaimants_EmailAddress).Name = "textClaimants_EmailAddress";
    ((Control) this.textClaimants_EmailAddress).Size = new Size(182, 19);
    ((Control) this.textClaimants_EmailAddress).TabIndex = 11;
    ((UltraControlBase) this.textClaimants_EmailAddress).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textClaimants_EmailAddress).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance2).BorderColor = Color.Gray;
    ((AppearanceBase) appearance2).ForeColor = Color.Black;
    ((AppearanceBase) appearance2).TextHAlignAsString = "Left";
    ((AppearanceBase) appearance2).TextVAlignAsString = "Top";
    ((UltraToggleEditorBase) this.checkClaimants_Closed).Appearance = (AppearanceBase) appearance2;
    ((UltraToggleEditorBase) this.checkClaimants_Closed).CheckAlign = ContentAlignment.TopRight;
    ((UltraToggleEditorBase) this.checkClaimants_Closed).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007RadioButtonGlyphInfo;
    ((Control) this.checkClaimants_Closed).Location = new Point(890, 26);
    ((Control) this.checkClaimants_Closed).Name = "checkClaimants_Closed";
    ((Control) this.checkClaimants_Closed).Size = new Size(54, 20);
    ((Control) this.checkClaimants_Closed).TabIndex = 27;
    ((Control) this.checkClaimants_Closed).Text = "Closed";
    this.label20.AutoSize = true;
    this.label20.ForeColor = Color.Black;
    this.label20.Location = new Point(516, 86);
    this.label20.Name = "label20";
    this.label20.Size = new Size(45, 13);
    this.label20.TabIndex = 19;
    this.label20.Text = "Gender:";
    ((UltraCombo) this.comboClaimants_Gender).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraCombo) this.comboClaimants_Gender).DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboClaimants_Gender).Location = new Point(618, 87);
    this.comboClaimants_Gender.MGAStyle = (MGAStyles) 2;
    ((Control) this.comboClaimants_Gender).Name = "comboClaimants_Gender";
    ((Control) this.comboClaimants_Gender).Size = new Size(92, 20);
    ((Control) this.comboClaimants_Gender).TabIndex = 20;
    ((UltraControlBase) this.comboClaimants_Gender).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboClaimants_Gender).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance3).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraDateTimeEditor) this.dateTimeClaimants_DOB).Appearance = (AppearanceBase) appearance3;
    ((AppearanceBase) appearance4).AlphaLevel = (short) 14;
    ((AppearanceBase) appearance4).BackColor = Color.FromArgb(0, 0, 246, 253);
    ((AppearanceBase) appearance4).BackColor2 = Color.FromArgb(133, 162, 221);
    ((AppearanceBase) appearance4).BackColorAlpha = (Alpha) 2;
    ((AppearanceBase) appearance4).BackGradientAlignment = (GradientAlignment) 4;
    ((AppearanceBase) appearance4).BackGradientStyle = (GradientStyle) 5;
    ((AppearanceBase) appearance4).BorderAlpha = (Alpha) 1;
    ((AppearanceBase) appearance4).BorderColor = Color.FromArgb(78, 122, 171);
    ((AppearanceBase) appearance4).ForeColor = Color.FromArgb(49, 85, 153);
    ((AppearanceBase) appearance4).ForegroundAlpha = (Alpha) 2;
    ((UltraDateTimeEditor) this.dateTimeClaimants_DOB).ButtonAppearance = (AppearanceBase) appearance4;
    ((UltraDateTimeEditor) this.dateTimeClaimants_DOB).DateTime = new DateTime(2007, 10, 3, 0, 0, 0, 0);
    ((Control) this.dateTimeClaimants_DOB).Location = new Point(618, 65);
    this.dateTimeClaimants_DOB.MGAStyle = (MGAStyles) 2;
    ((Control) this.dateTimeClaimants_DOB).Name = "dateTimeClaimants_DOB";
    ((Control) this.dateTimeClaimants_DOB).Size = new Size(92, 19);
    ((Control) this.dateTimeClaimants_DOB).TabIndex = 18;
    ((UltraControlBase) this.dateTimeClaimants_DOB).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dateTimeClaimants_DOB).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDateTimeEditor) this.dateTimeClaimants_DOB).Value = (object) new DateTime(2007, 10, 3, 0, 0, 0, 0);
    ((AppearanceBase) appearance5).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraMaskedEdit) this.maskedEditClaimants_SSNFEIN).Appearance = (AppearanceBase) appearance5;
    ((UltraMaskedEdit) this.maskedEditClaimants_SSNFEIN).ClipMode = (MaskMode) 0;
    ((UltraMaskedEdit) this.maskedEditClaimants_SSNFEIN).DataMode = (MaskMode) 0;
    ((UltraMaskedEdit) this.maskedEditClaimants_SSNFEIN).EditAs = (EditAsType) 1;
    ((UltraMaskedEdit) this.maskedEditClaimants_SSNFEIN).InputMask = "999-99-9999";
    ((Control) this.maskedEditClaimants_SSNFEIN).Location = new Point(618, 41);
    this.maskedEditClaimants_SSNFEIN.MGAStyle = (MGAStyles) 2;
    ((Control) this.maskedEditClaimants_SSNFEIN).Name = "maskedEditClaimants_SSNFEIN";
    ((UltraMaskedEdit) this.maskedEditClaimants_SSNFEIN).NonAutoSizeHeight = 20;
    ((Control) this.maskedEditClaimants_SSNFEIN).Size = new Size(76, 20);
    ((Control) this.maskedEditClaimants_SSNFEIN).TabIndex = 16 /*0x10*/;
    ((UltraControlBase) this.maskedEditClaimants_SSNFEIN).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.maskedEditClaimants_SSNFEIN).UseOsThemes = (DefaultableBoolean) 2;
    this.label19.AutoSize = true;
    this.label19.ForeColor = Color.Black;
    this.label19.Location = new Point(516, 108);
    this.label19.Name = "label19";
    this.label19.Size = new Size(87, 13);
    this.label19.TabIndex = 21;
    this.label19.Text = "Claimant Id (UD):";
    this.label18.AutoSize = true;
    this.label18.ForeColor = Color.Black;
    this.label18.Location = new Point(516, 63 /*0x3F*/);
    this.label18.Name = "label18";
    this.label18.Size = new Size(33, 13);
    this.label18.TabIndex = 17;
    this.label18.Text = "DOB:";
    ((AppearanceBase) appearance6).BackColor = Color.White;
    ((AppearanceBase) appearance6).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance6).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textClaimants_UserDefinedClaimantsID).Appearance = (AppearanceBase) appearance6;
    ((Control) this.textClaimants_UserDefinedClaimantsID).BackColor = Color.White;
    ((Control) this.textClaimants_UserDefinedClaimantsID).Location = new Point(618, 110);
    this.textClaimants_UserDefinedClaimantsID.MGAStyle = (MGAStyles) 2;
    ((Control) this.textClaimants_UserDefinedClaimantsID).Name = "textClaimants_UserDefinedClaimantsID";
    ((Control) this.textClaimants_UserDefinedClaimantsID).Size = new Size(169, 19);
    ((Control) this.textClaimants_UserDefinedClaimantsID).TabIndex = 22;
    ((UltraControlBase) this.textClaimants_UserDefinedClaimantsID).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textClaimants_UserDefinedClaimantsID).UseOsThemes = (DefaultableBoolean) 2;
    this.label17.AutoSize = true;
    this.label17.ForeColor = Color.Black;
    this.label17.Location = new Point(516, 42);
    this.label17.Name = "label17";
    this.label17.Size = new Size(61, 13);
    this.label17.TabIndex = 15;
    this.label17.Text = "SSN/FEIN:";
    this.label16.AutoSize = true;
    this.label16.Font = new Font("Tahoma", 8.25f, FontStyle.Bold | FontStyle.Underline);
    this.label16.ForeColor = Color.Black;
    this.label16.Location = new Point(516, 170);
    this.label16.Name = "label16";
    this.label16.Size = new Size(96 /*0x60*/, 13);
    this.label16.TabIndex = 21;
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
    ((Control) this.addResolverClaimants_Mailing).Location = new Point(507, 180);
    this.addResolverClaimants_Mailing.MGAStyle = (MGAStyles) 2;
    ((Control) this.addResolverClaimants_Mailing).Name = "addResolverClaimants_Mailing";
    this.addResolverClaimants_Mailing.Password = (string) null;
    ((Control) this.addResolverClaimants_Mailing).Size = new Size(288, 152);
    this.addResolverClaimants_Mailing.State = "";
    ((Control) this.addResolverClaimants_Mailing).TabIndex = 23;
    this.addResolverClaimants_Mailing.TextAlign = ContentAlignment.TopLeft;
    this.addResolverClaimants_Mailing.UserID = (string) null;
    this.addResolverClaimants_Mailing.WebserviceUrl = (string) null;
    this.addResolverClaimants_Mailing.ZipCode = "";
    this.addResolverClaimants_Mailing.ZipCodeExtension = "";
    this.label15.AutoSize = true;
    this.label15.Font = new Font("Tahoma", 8.25f, FontStyle.Bold | FontStyle.Underline);
    this.label15.ForeColor = Color.Black;
    this.label15.Location = new Point(9, 170);
    this.label15.Name = "label15";
    this.label15.Size = new Size(101, 13);
    this.label15.TabIndex = 13;
    this.label15.Text = "Primary Address";
    this.label14.AutoSize = true;
    this.label14.ForeColor = Color.Black;
    this.label14.Location = new Point(9, 109);
    this.label14.Name = "label14";
    this.label14.Size = new Size(61, 13);
    this.label14.TabIndex = 8;
    this.label14.Text = "Last Name:";
    this.label11.AutoSize = true;
    this.label11.ForeColor = Color.Black;
    this.label11.Location = new Point(9, 42);
    this.label11.Name = "label11";
    this.label11.Size = new Size(95, 13);
    this.label11.TabIndex = 2;
    this.label11.Text = "Corporation Name:";
    this.label13.AutoSize = true;
    this.label13.ForeColor = Color.Black;
    this.label13.Location = new Point(9, 87);
    this.label13.Name = "label13";
    this.label13.Size = new Size(72, 13);
    this.label13.TabIndex = 6;
    this.label13.Text = "Middle Name:";
    ((AppearanceBase) appearance7).BackColor = Color.White;
    ((AppearanceBase) appearance7).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance7).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textClaimants_CorporationName).Appearance = (AppearanceBase) appearance7;
    ((Control) this.textClaimants_CorporationName).BackColor = Color.White;
    ((Control) this.textClaimants_CorporationName).Enabled = false;
    ((Control) this.textClaimants_CorporationName).Location = new Point(119, 41);
    this.textClaimants_CorporationName.MGAStyle = (MGAStyles) 2;
    ((Control) this.textClaimants_CorporationName).Name = "textClaimants_CorporationName";
    ((Control) this.textClaimants_CorporationName).Size = new Size(242, 19);
    ((Control) this.textClaimants_CorporationName).TabIndex = 3;
    ((UltraControlBase) this.textClaimants_CorporationName).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textClaimants_CorporationName).UseOsThemes = (DefaultableBoolean) 2;
    this.label12.AutoSize = true;
    this.label12.ForeColor = Color.Black;
    this.label12.Location = new Point(9, 64 /*0x40*/);
    this.label12.Name = "label12";
    this.label12.Size = new Size(60, 13);
    this.label12.TabIndex = 4;
    this.label12.Text = "First Name:";
    ((AppearanceBase) appearance8).BackColor = Color.White;
    ((AppearanceBase) appearance8).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance8).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textClaimants_FirstName).Appearance = (AppearanceBase) appearance8;
    ((Control) this.textClaimants_FirstName).BackColor = Color.White;
    ((Control) this.textClaimants_FirstName).Location = new Point(119, 64 /*0x40*/);
    this.textClaimants_FirstName.MGAStyle = (MGAStyles) 2;
    ((Control) this.textClaimants_FirstName).Name = "textClaimants_FirstName";
    ((Control) this.textClaimants_FirstName).Size = new Size(182, 19);
    ((Control) this.textClaimants_FirstName).TabIndex = 5;
    ((UltraControlBase) this.textClaimants_FirstName).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textClaimants_FirstName).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance9).BackColor = Color.White;
    ((AppearanceBase) appearance9).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance9).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textClaimants_MiddleName).Appearance = (AppearanceBase) appearance9;
    ((Control) this.textClaimants_MiddleName).BackColor = Color.White;
    ((Control) this.textClaimants_MiddleName).Location = new Point(119, 87);
    this.textClaimants_MiddleName.MGAStyle = (MGAStyles) 2;
    ((Control) this.textClaimants_MiddleName).Name = "textClaimants_MiddleName";
    ((Control) this.textClaimants_MiddleName).Size = new Size(182, 19);
    ((Control) this.textClaimants_MiddleName).TabIndex = 7;
    ((UltraControlBase) this.textClaimants_MiddleName).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textClaimants_MiddleName).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance10).BackColor = Color.White;
    ((AppearanceBase) appearance10).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance10).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textClaimants_LastName).Appearance = (AppearanceBase) appearance10;
    ((Control) this.textClaimants_LastName).BackColor = Color.White;
    ((Control) this.textClaimants_LastName).Location = new Point(119, 110);
    this.textClaimants_LastName.MGAStyle = (MGAStyles) 2;
    ((Control) this.textClaimants_LastName).Name = "textClaimants_LastName";
    ((Control) this.textClaimants_LastName).Size = new Size(182, 19);
    ((Control) this.textClaimants_LastName).TabIndex = 9;
    ((UltraControlBase) this.textClaimants_LastName).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textClaimants_LastName).UseOsThemes = (DefaultableBoolean) 2;
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
    ((Control) this.addResolverClaimants_Primary).Location = new Point(2, 180);
    this.addResolverClaimants_Primary.MGAStyle = (MGAStyles) 2;
    ((Control) this.addResolverClaimants_Primary).Name = "addResolverClaimants_Primary";
    this.addResolverClaimants_Primary.Password = (string) null;
    ((Control) this.addResolverClaimants_Primary).Size = new Size(293, 152);
    this.addResolverClaimants_Primary.State = "";
    ((Control) this.addResolverClaimants_Primary).TabIndex = 12;
    this.addResolverClaimants_Primary.TextAlign = ContentAlignment.TopLeft;
    this.addResolverClaimants_Primary.UserID = (string) null;
    this.addResolverClaimants_Primary.WebserviceUrl = (string) null;
    this.addResolverClaimants_Primary.ZipCode = "";
    this.addResolverClaimants_Primary.ZipCodeExtension = "";
    ((AppearanceBase) appearance11).BorderColor = Color.Gray;
    ((AppearanceBase) appearance11).ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.checkClaimants_IsInsured).Appearance = (AppearanceBase) appearance11;
    ((UltraToggleEditorBase) this.checkClaimants_IsInsured).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007RadioButtonGlyphInfo;
    ((Control) this.checkClaimants_IsInsured).Location = new Point(120, 22);
    ((Control) this.checkClaimants_IsInsured).Name = "checkClaimants_IsInsured";
    ((Control) this.checkClaimants_IsInsured).Size = new Size(74, 20);
    ((Control) this.checkClaimants_IsInsured).TabIndex = 0;
    ((Control) this.checkClaimants_IsInsured).Text = "Insured";
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
    ((Control) this.optionClaimants_ClaimantType).Location = new Point(200, 24);
    ((Control) this.optionClaimants_ClaimantType).Name = "optionClaimants_ClaimantType";
    ((Control) this.optionClaimants_ClaimantType).Size = new Size(158, 17);
    ((Control) this.optionClaimants_ClaimantType).TabIndex = 1;
    ((Control) this.optionClaimants_ClaimantType).Text = "Individual";
    ((UltraControlBase) this.optionClaimants_ClaimantType).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.optionClaimants_ClaimantType).UseOsThemes = (DefaultableBoolean) 2;
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
    ((Control) this.tabPageClaimSpecifications).Size = new Size(951, 558);
    ((AppearanceBase) appearance12).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraDateTimeEditor) this.dateTimeClaimant_DateDenied).Appearance = (AppearanceBase) appearance12;
    ((AppearanceBase) appearance13).AlphaLevel = (short) 14;
    ((AppearanceBase) appearance13).BackColor = Color.FromArgb(0, 0, 246, 253);
    ((AppearanceBase) appearance13).BackColor2 = Color.FromArgb(133, 162, 221);
    ((AppearanceBase) appearance13).BackColorAlpha = (Alpha) 2;
    ((AppearanceBase) appearance13).BackGradientAlignment = (GradientAlignment) 4;
    ((AppearanceBase) appearance13).BackGradientStyle = (GradientStyle) 5;
    ((AppearanceBase) appearance13).BorderAlpha = (Alpha) 1;
    ((AppearanceBase) appearance13).BorderColor = Color.FromArgb(78, 122, 171);
    ((AppearanceBase) appearance13).ForeColor = Color.FromArgb(49, 85, 153);
    ((AppearanceBase) appearance13).ForegroundAlpha = (Alpha) 2;
    ((UltraDateTimeEditor) this.dateTimeClaimant_DateDenied).ButtonAppearance = (AppearanceBase) appearance13;
    ((UltraDateTimeEditor) this.dateTimeClaimant_DateDenied).DateTime = new DateTime(2007, 10, 3, 0, 0, 0, 0);
    ((Control) this.dateTimeClaimant_DateDenied).Location = new Point(566, 119);
    this.dateTimeClaimant_DateDenied.MGAStyle = (MGAStyles) 2;
    ((Control) this.dateTimeClaimant_DateDenied).Name = "dateTimeClaimant_DateDenied";
    ((Control) this.dateTimeClaimant_DateDenied).Size = new Size(92, 19);
    ((Control) this.dateTimeClaimant_DateDenied).TabIndex = 24;
    ((UltraControlBase) this.dateTimeClaimant_DateDenied).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dateTimeClaimant_DateDenied).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDateTimeEditor) this.dateTimeClaimant_DateDenied).Value = (object) new DateTime(2007, 10, 3, 0, 0, 0, 0);
    this.label50.AutoSize = true;
    this.label50.BackColor = Color.Transparent;
    this.label50.ForeColor = Color.Black;
    this.label50.Location = new Point(470, 119);
    this.label50.Name = "label50";
    this.label50.Size = new Size(70, 13);
    this.label50.TabIndex = 23;
    this.label50.Text = "Date Denied:";
    ((AppearanceBase) appearance14).BackColor = Color.White;
    ((AppearanceBase) appearance14).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridClaimant_Coverages).DisplayLayout.Appearance = (AppearanceBase) appearance14;
    ((UltraGridBase) this.gridClaimant_Coverages).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((UltraGridBase) this.gridClaimant_Coverages).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance15).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance15).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance15).ForeColor = Color.Black;
    ((UltraGridBase) this.gridClaimant_Coverages).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance15;
    ((UltraGridBase) this.gridClaimant_Coverages).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridClaimant_Coverages).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridClaimant_Coverages).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance16).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridClaimant_Coverages).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance16;
    ((UltraGridBase) this.gridClaimant_Coverages).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance17).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.gridClaimant_Coverages).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance17;
    ((UltraGridBase) this.gridClaimant_Coverages).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance18).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridClaimant_Coverages).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance18;
    ((AppearanceBase) appearance19).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridClaimant_Coverages).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance19;
    ((UltraGridBase) this.gridClaimant_Coverages).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance20).BackColor = Color.Transparent;
    ((AppearanceBase) appearance20).ForeColor = Color.Black;
    ((UltraGridBase) this.gridClaimant_Coverages).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance20;
    ((AppearanceBase) appearance21).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance21).BorderColor = Color.Silver;
    scrollBarLook1.ButtonAppearance = (AppearanceBase) appearance21;
    ((AppearanceBase) appearance22).BackColor = Color.White;
    scrollBarLook1.TrackAppearance = (AppearanceBase) appearance22;
    ((UltraGridBase) this.gridClaimant_Coverages).DisplayLayout.ScrollBarLook = scrollBarLook1;
    ((Control) this.gridClaimant_Coverages).Location = new Point(139, 41);
    ((Control) this.gridClaimant_Coverages).Name = "gridClaimant_Coverages";
    ((Control) this.gridClaimant_Coverages).Size = new Size(297, 117);
    ((Control) this.gridClaimant_Coverages).TabIndex = 1;
    ((UltraControlBase) this.gridClaimant_Coverages).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridClaimant_Coverages).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance23).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraDateTimeEditor) this.dateTimeClaimants_OutsideInvestigatorHireDate).Appearance = (AppearanceBase) appearance23;
    ((AppearanceBase) appearance24).AlphaLevel = (short) 14;
    ((AppearanceBase) appearance24).BackColor = Color.FromArgb(0, 0, 246, 253);
    ((AppearanceBase) appearance24).BackColor2 = Color.FromArgb(133, 162, 221);
    ((AppearanceBase) appearance24).BackColorAlpha = (Alpha) 2;
    ((AppearanceBase) appearance24).BackGradientAlignment = (GradientAlignment) 4;
    ((AppearanceBase) appearance24).BackGradientStyle = (GradientStyle) 5;
    ((AppearanceBase) appearance24).BorderAlpha = (Alpha) 1;
    ((AppearanceBase) appearance24).BorderColor = Color.FromArgb(78, 122, 171);
    ((AppearanceBase) appearance24).ForeColor = Color.FromArgb(49, 85, 153);
    ((AppearanceBase) appearance24).ForegroundAlpha = (Alpha) 2;
    ((UltraDateTimeEditor) this.dateTimeClaimants_OutsideInvestigatorHireDate).ButtonAppearance = (AppearanceBase) appearance24;
    ((UltraDateTimeEditor) this.dateTimeClaimants_OutsideInvestigatorHireDate).DateTime = new DateTime(2007, 10, 3, 0, 0, 0, 0);
    ((Control) this.dateTimeClaimants_OutsideInvestigatorHireDate).Location = new Point(139, 295);
    this.dateTimeClaimants_OutsideInvestigatorHireDate.MGAStyle = (MGAStyles) 2;
    ((Control) this.dateTimeClaimants_OutsideInvestigatorHireDate).Name = "dateTimeClaimants_OutsideInvestigatorHireDate";
    ((Control) this.dateTimeClaimants_OutsideInvestigatorHireDate).Size = new Size(92, 19);
    ((Control) this.dateTimeClaimants_OutsideInvestigatorHireDate).TabIndex = 13;
    ((UltraControlBase) this.dateTimeClaimants_OutsideInvestigatorHireDate).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dateTimeClaimants_OutsideInvestigatorHireDate).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDateTimeEditor) this.dateTimeClaimants_OutsideInvestigatorHireDate).Value = (object) new DateTime(2007, 10, 3, 0, 0, 0, 0);
    this.label42.AutoSize = true;
    this.label42.BackColor = Color.Transparent;
    this.label42.ForeColor = Color.Black;
    this.label42.Location = new Point(20, 295);
    this.label42.Name = "label42";
    this.label42.Size = new Size(110, 13);
    this.label42.TabIndex = 12;
    this.label42.Text = "Investigator Hired On:";
    ((AppearanceBase) appearance25).BorderColor = Color.Gray;
    ((AppearanceBase) appearance25).ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.checkClaimants_Settled).Appearance = (AppearanceBase) appearance25;
    ((Control) this.checkClaimants_Settled).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.checkClaimants_Settled).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.checkClaimants_Settled).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007RadioButtonGlyphInfo;
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
    this.label41.Size = new Size(87, 13);
    this.label41.TabIndex = 15;
    this.label41.Text = "Settlement Type:";
    ((UltraCombo) this.comboClaimants_SettlementType).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraCombo) this.comboClaimants_SettlementType).DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboClaimants_SettlementType).Location = new Point(139, 343);
    this.comboClaimants_SettlementType.MGAStyle = (MGAStyles) 2;
    ((Control) this.comboClaimants_SettlementType).Name = "comboClaimants_SettlementType";
    ((Control) this.comboClaimants_SettlementType).Size = new Size(181, 20);
    ((Control) this.comboClaimants_SettlementType).TabIndex = 16 /*0x10*/;
    ((UltraControlBase) this.comboClaimants_SettlementType).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboClaimants_SettlementType).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance26).BackColor = Color.White;
    ((AppearanceBase) appearance26).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance26).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textClaimants_OutsideInvestigator).Appearance = (AppearanceBase) appearance26;
    ((Control) this.textClaimants_OutsideInvestigator).BackColor = Color.White;
    ((Control) this.textClaimants_OutsideInvestigator).Enabled = false;
    ((Control) this.textClaimants_OutsideInvestigator).Location = new Point(139, 271);
    this.textClaimants_OutsideInvestigator.MGAStyle = (MGAStyles) 2;
    ((Control) this.textClaimants_OutsideInvestigator).Name = "textClaimants_OutsideInvestigator";
    ((Control) this.textClaimants_OutsideInvestigator).Size = new Size(297, 19);
    ((Control) this.textClaimants_OutsideInvestigator).TabIndex = 11;
    ((UltraControlBase) this.textClaimants_OutsideInvestigator).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textClaimants_OutsideInvestigator).UseOsThemes = (DefaultableBoolean) 2;
    this.label40.AutoSize = true;
    this.label40.BackColor = Color.Transparent;
    this.label40.ForeColor = Color.Black;
    this.label40.Location = new Point(20, 271);
    this.label40.Name = "label40";
    this.label40.Size = new Size(104, 13);
    this.label40.TabIndex = 10;
    this.label40.Text = "Outside Investigator:";
    ((AppearanceBase) appearance27).BackColor = Color.White;
    ((AppearanceBase) appearance27).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance27).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textClaimants_LastModifiedBy).Appearance = (AppearanceBase) appearance27;
    ((Control) this.textClaimants_LastModifiedBy).BackColor = Color.White;
    ((Control) this.textClaimants_LastModifiedBy).Enabled = false;
    ((Control) this.textClaimants_LastModifiedBy).Location = new Point(566, 172);
    this.textClaimants_LastModifiedBy.MGAStyle = (MGAStyles) 2;
    ((Control) this.textClaimants_LastModifiedBy).Name = "textClaimants_LastModifiedBy";
    ((Control) this.textClaimants_LastModifiedBy).Size = new Size(185, 19);
    ((Control) this.textClaimants_LastModifiedBy).TabIndex = 28;
    ((UltraControlBase) this.textClaimants_LastModifiedBy).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textClaimants_LastModifiedBy).UseOsThemes = (DefaultableBoolean) 2;
    this.label38.AutoSize = true;
    this.label38.BackColor = Color.Transparent;
    this.label38.ForeColor = Color.Black;
    this.label38.Location = new Point(470, 172);
    this.label38.Name = "label38";
    this.label38.Size = new Size(65, 13);
    this.label38.TabIndex = 27;
    this.label38.Text = "Modified By:";
    ((AppearanceBase) appearance28).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraDateTimeEditor) this.dateTimeClaimants_LastModified).Appearance = (AppearanceBase) appearance28;
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
    ((UltraDateTimeEditor) this.dateTimeClaimants_LastModified).ButtonAppearance = (AppearanceBase) appearance29;
    ((UltraDateTimeEditor) this.dateTimeClaimants_LastModified).DateTime = new DateTime(2007, 10, 3, 0, 0, 0, 0);
    ((Control) this.dateTimeClaimants_LastModified).Enabled = false;
    ((Control) this.dateTimeClaimants_LastModified).Location = new Point(566, 146);
    this.dateTimeClaimants_LastModified.MGAStyle = (MGAStyles) 2;
    ((Control) this.dateTimeClaimants_LastModified).Name = "dateTimeClaimants_LastModified";
    ((Control) this.dateTimeClaimants_LastModified).Size = new Size(92, 19);
    ((Control) this.dateTimeClaimants_LastModified).TabIndex = 26;
    ((UltraControlBase) this.dateTimeClaimants_LastModified).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dateTimeClaimants_LastModified).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDateTimeEditor) this.dateTimeClaimants_LastModified).Value = (object) new DateTime(2007, 10, 3, 0, 0, 0, 0);
    this.label39.AutoSize = true;
    this.label39.BackColor = Color.Transparent;
    this.label39.ForeColor = Color.Black;
    this.label39.Location = new Point(470, 145);
    this.label39.Name = "label39";
    this.label39.Size = new Size(73, 13);
    this.label39.TabIndex = 25;
    this.label39.Text = "Last Modified:";
    this.label29.AutoSize = true;
    this.label29.BackColor = Color.Transparent;
    this.label29.ForeColor = Color.Black;
    this.label29.Location = new Point(20, 244);
    this.label29.Name = "label29";
    this.label29.Size = new Size(87, 13);
    this.label29.TabIndex = 8;
    this.label29.Text = "Outside Adjuster:";
    ((UltraCombo) this.comboClaimants_OutsideAdjuster).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraCombo) this.comboClaimants_OutsideAdjuster).DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboClaimants_OutsideAdjuster).Location = new Point(139, 244);
    this.comboClaimants_OutsideAdjuster.MGAStyle = (MGAStyles) 2;
    ((Control) this.comboClaimants_OutsideAdjuster).Name = "comboClaimants_OutsideAdjuster";
    ((Control) this.comboClaimants_OutsideAdjuster).Size = new Size(181, 20);
    ((Control) this.comboClaimants_OutsideAdjuster).TabIndex = 9;
    ((UltraControlBase) this.comboClaimants_OutsideAdjuster).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboClaimants_OutsideAdjuster).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance30).BackColor = Color.White;
    ((AppearanceBase) appearance30).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance30).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textClaimant_EnteredBy).Appearance = (AppearanceBase) appearance30;
    ((Control) this.textClaimant_EnteredBy).BackColor = Color.White;
    ((Control) this.textClaimant_EnteredBy).Enabled = false;
    ((Control) this.textClaimant_EnteredBy).Location = new Point(566, 41);
    this.textClaimant_EnteredBy.MGAStyle = (MGAStyles) 2;
    ((Control) this.textClaimant_EnteredBy).Name = "textClaimant_EnteredBy";
    ((Control) this.textClaimant_EnteredBy).Size = new Size(185, 19);
    ((Control) this.textClaimant_EnteredBy).TabIndex = 18;
    ((UltraControlBase) this.textClaimant_EnteredBy).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textClaimant_EnteredBy).UseOsThemes = (DefaultableBoolean) 2;
    this.label27.AutoSize = true;
    this.label27.BackColor = Color.Transparent;
    this.label27.ForeColor = Color.Black;
    this.label27.Location = new Point(470, 41);
    this.label27.Name = "label27";
    this.label27.Size = new Size(62, 13);
    this.label27.TabIndex = 17;
    this.label27.Text = "Entered By:";
    ((AppearanceBase) appearance31).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraDateTimeEditor) this.dateTimeClaimant_DateEntered).Appearance = (AppearanceBase) appearance31;
    ((AppearanceBase) appearance32).AlphaLevel = (short) 14;
    ((AppearanceBase) appearance32).BackColor = Color.FromArgb(0, 0, 246, 253);
    ((AppearanceBase) appearance32).BackColor2 = Color.FromArgb(133, 162, 221);
    ((AppearanceBase) appearance32).BackColorAlpha = (Alpha) 2;
    ((AppearanceBase) appearance32).BackGradientAlignment = (GradientAlignment) 4;
    ((AppearanceBase) appearance32).BackGradientStyle = (GradientStyle) 5;
    ((AppearanceBase) appearance32).BorderAlpha = (Alpha) 1;
    ((AppearanceBase) appearance32).BorderColor = Color.FromArgb(78, 122, 171);
    ((AppearanceBase) appearance32).ForeColor = Color.FromArgb(49, 85, 153);
    ((AppearanceBase) appearance32).ForegroundAlpha = (Alpha) 2;
    ((UltraDateTimeEditor) this.dateTimeClaimant_DateEntered).ButtonAppearance = (AppearanceBase) appearance32;
    ((UltraDateTimeEditor) this.dateTimeClaimant_DateEntered).DateTime = new DateTime(2007, 10, 3, 0, 0, 0, 0);
    ((Control) this.dateTimeClaimant_DateEntered).Enabled = false;
    ((Control) this.dateTimeClaimant_DateEntered).Location = new Point(566, 67);
    this.dateTimeClaimant_DateEntered.MGAStyle = (MGAStyles) 2;
    ((Control) this.dateTimeClaimant_DateEntered).Name = "dateTimeClaimant_DateEntered";
    ((Control) this.dateTimeClaimant_DateEntered).Size = new Size(92, 19);
    ((Control) this.dateTimeClaimant_DateEntered).TabIndex = 20;
    ((UltraControlBase) this.dateTimeClaimant_DateEntered).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dateTimeClaimant_DateEntered).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDateTimeEditor) this.dateTimeClaimant_DateEntered).Value = (object) new DateTime(2007, 10, 3, 0, 0, 0, 0);
    this.label28.AutoSize = true;
    this.label28.BackColor = Color.Transparent;
    this.label28.ForeColor = Color.Black;
    this.label28.Location = new Point(470, 67);
    this.label28.Name = "label28";
    this.label28.Size = new Size(73, 13);
    this.label28.TabIndex = 19;
    this.label28.Text = "Date Entered:";
    this.label26.AutoSize = true;
    this.label26.BackColor = Color.Transparent;
    this.label26.ForeColor = Color.Black;
    this.label26.Location = new Point(20, 217);
    this.label26.Name = "label26";
    this.label26.Size = new Size(115, 13);
    this.label26.TabIndex = 6;
    this.label26.Text = "Managed Care Facility:";
    ((UltraCombo) this.comboClaimants_ManagedCare).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraCombo) this.comboClaimants_ManagedCare).DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboClaimants_ManagedCare).Location = new Point(139, 217);
    this.comboClaimants_ManagedCare.MGAStyle = (MGAStyles) 2;
    ((Control) this.comboClaimants_ManagedCare).Name = "comboClaimants_ManagedCare";
    ((Control) this.comboClaimants_ManagedCare).Size = new Size(181, 20);
    ((Control) this.comboClaimants_ManagedCare).TabIndex = 7;
    ((UltraControlBase) this.comboClaimants_ManagedCare).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboClaimants_ManagedCare).UseOsThemes = (DefaultableBoolean) 2;
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
    ((Control) this.comboClaimants_LossType).Size = new Size(181, 20);
    ((Control) this.comboClaimants_LossType).TabIndex = 5;
    ((UltraControlBase) this.comboClaimants_LossType).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboClaimants_LossType).UseOsThemes = (DefaultableBoolean) 2;
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
    ((Control) this.comboClaimant_AccidentTypes).Size = new Size(181, 20);
    ((Control) this.comboClaimant_AccidentTypes).TabIndex = 3;
    ((UltraControlBase) this.comboClaimant_AccidentTypes).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboClaimant_AccidentTypes).UseOsThemes = (DefaultableBoolean) 2;
    this.label23.AutoSize = true;
    this.label23.BackColor = Color.Transparent;
    this.label23.ForeColor = Color.Black;
    this.label23.Location = new Point(20, 41);
    this.label23.Name = "label23";
    this.label23.Size = new Size(104, 13);
    this.label23.TabIndex = 0;
    this.label23.Text = "Affected Coverages:";
    ((AppearanceBase) appearance33).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraDateTimeEditor) this.dateTimeClaimant_DateReported).Appearance = (AppearanceBase) appearance33;
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
    ((UltraDateTimeEditor) this.dateTimeClaimant_DateReported).ButtonAppearance = (AppearanceBase) appearance34;
    ((UltraDateTimeEditor) this.dateTimeClaimant_DateReported).DateTime = new DateTime(2007, 10, 3, 0, 0, 0, 0);
    ((Control) this.dateTimeClaimant_DateReported).Location = new Point(566, 93);
    this.dateTimeClaimant_DateReported.MGAStyle = (MGAStyles) 2;
    ((Control) this.dateTimeClaimant_DateReported).Name = "dateTimeClaimant_DateReported";
    ((Control) this.dateTimeClaimant_DateReported).Size = new Size(92, 19);
    ((Control) this.dateTimeClaimant_DateReported).TabIndex = 22;
    ((UltraControlBase) this.dateTimeClaimant_DateReported).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dateTimeClaimant_DateReported).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDateTimeEditor) this.dateTimeClaimant_DateReported).Value = (object) new DateTime(2007, 10, 3, 0, 0, 0, 0);
    this.label21.AutoSize = true;
    this.label21.BackColor = Color.Transparent;
    this.label21.ForeColor = Color.Black;
    this.label21.Location = new Point(470, 93);
    this.label21.Name = "label21";
    this.label21.Size = new Size(80 /*0x50*/, 13);
    this.label21.TabIndex = 21;
    this.label21.Text = "Date Reported:";
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
    ((Control) this.tabPageLegal).Size = new Size(951, 558);
    ((AppearanceBase) appearance35).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraMaskedEdit) this.textClaimants_ClaimantAttorneyFEIN).Appearance = (AppearanceBase) appearance35;
    ((UltraMaskedEdit) this.textClaimants_ClaimantAttorneyFEIN).ClipMode = (MaskMode) 0;
    ((UltraMaskedEdit) this.textClaimants_ClaimantAttorneyFEIN).DataMode = (MaskMode) 0;
    ((UltraMaskedEdit) this.textClaimants_ClaimantAttorneyFEIN).EditAs = (EditAsType) 1;
    ((UltraMaskedEdit) this.textClaimants_ClaimantAttorneyFEIN).InputMask = "99-9999999";
    ((Control) this.textClaimants_ClaimantAttorneyFEIN).Location = new Point(507, 165);
    this.textClaimants_ClaimantAttorneyFEIN.MGAStyle = (MGAStyles) 2;
    ((Control) this.textClaimants_ClaimantAttorneyFEIN).Name = "textClaimants_ClaimantAttorneyFEIN";
    ((UltraMaskedEdit) this.textClaimants_ClaimantAttorneyFEIN).NonAutoSizeHeight = 20;
    ((Control) this.textClaimants_ClaimantAttorneyFEIN).Size = new Size(76, 20);
    ((Control) this.textClaimants_ClaimantAttorneyFEIN).TabIndex = 22;
    ((UltraControlBase) this.textClaimants_ClaimantAttorneyFEIN).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textClaimants_ClaimantAttorneyFEIN).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance36).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraMaskedEdit) this.textClaimants_DefenseFEIN).Appearance = (AppearanceBase) appearance36;
    ((UltraMaskedEdit) this.textClaimants_DefenseFEIN).ClipMode = (MaskMode) 0;
    ((UltraMaskedEdit) this.textClaimants_DefenseFEIN).DataMode = (MaskMode) 0;
    ((UltraMaskedEdit) this.textClaimants_DefenseFEIN).EditAs = (EditAsType) 1;
    ((UltraMaskedEdit) this.textClaimants_DefenseFEIN).InputMask = "99-9999999";
    ((Control) this.textClaimants_DefenseFEIN).Location = new Point(125, 163);
    this.textClaimants_DefenseFEIN.MGAStyle = (MGAStyles) 2;
    ((Control) this.textClaimants_DefenseFEIN).Name = "textClaimants_DefenseFEIN";
    ((UltraMaskedEdit) this.textClaimants_DefenseFEIN).NonAutoSizeHeight = 20;
    ((Control) this.textClaimants_DefenseFEIN).Size = new Size(76, 20);
    ((Control) this.textClaimants_DefenseFEIN).TabIndex = 11;
    ((UltraControlBase) this.textClaimants_DefenseFEIN).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textClaimants_DefenseFEIN).UseOsThemes = (DefaultableBoolean) 2;
    this.label54.AutoSize = true;
    this.label54.BackColor = Color.Transparent;
    this.label54.ForeColor = Color.Black;
    this.label54.Location = new Point(404, 167);
    this.label54.Name = "label54";
    this.label54.Size = new Size(61, 13);
    this.label54.TabIndex = 21;
    this.label54.Text = "FEIN/SSN:";
    this.label53.AutoSize = true;
    this.label53.BackColor = Color.Transparent;
    this.label53.ForeColor = Color.Black;
    this.label53.Location = new Point(30, 163);
    this.label53.Name = "label53";
    this.label53.Size = new Size(61, 13);
    this.label53.TabIndex = 10;
    this.label53.Text = "FEIN/SSN:";
    ((AppearanceBase) appearance37).BackColor = Color.White;
    ((AppearanceBase) appearance37).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance37).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textClaimants_DefenseAttorney).Appearance = (AppearanceBase) appearance37;
    ((Control) this.textClaimants_DefenseAttorney).BackColor = Color.White;
    ((Control) this.textClaimants_DefenseAttorney).Location = new Point(125, 137);
    this.textClaimants_DefenseAttorney.MGAStyle = (MGAStyles) 2;
    ((Control) this.textClaimants_DefenseAttorney).Name = "textClaimants_DefenseAttorney";
    ((Control) this.textClaimants_DefenseAttorney).Size = new Size(257, 19);
    ((Control) this.textClaimants_DefenseAttorney).TabIndex = 9;
    ((UltraControlBase) this.textClaimants_DefenseAttorney).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textClaimants_DefenseAttorney).UseOsThemes = (DefaultableBoolean) 2;
    this.label52.AutoSize = true;
    this.label52.BackColor = Color.Transparent;
    this.label52.ForeColor = Color.Black;
    this.label52.Location = new Point(30, 138);
    this.label52.Name = "label52";
    this.label52.Size = new Size(92, 13);
    this.label52.TabIndex = 8;
    this.label52.Text = "Defense Attorney:";
    ((AppearanceBase) appearance38).BorderColor = Color.Gray;
    ((AppearanceBase) appearance38).ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.checkClaimants_PublishedDecision).Appearance = (AppearanceBase) appearance38;
    ((Control) this.checkClaimants_PublishedDecision).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.checkClaimants_PublishedDecision).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.checkClaimants_PublishedDecision).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007RadioButtonGlyphInfo;
    ((Control) this.checkClaimants_PublishedDecision).Location = new Point(507, 39);
    ((Control) this.checkClaimants_PublishedDecision).Name = "checkClaimants_PublishedDecision";
    ((Control) this.checkClaimants_PublishedDecision).Size = new Size(120, 20);
    ((Control) this.checkClaimants_PublishedDecision).TabIndex = 14;
    ((Control) this.checkClaimants_PublishedDecision).Text = "Published Decision";
    ((AppearanceBase) appearance39).BackColor = Color.White;
    ((AppearanceBase) appearance39).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance39).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textClaimants_Judge).Appearance = (AppearanceBase) appearance39;
    ((Control) this.textClaimants_Judge).BackColor = Color.White;
    ((Control) this.textClaimants_Judge).Location = new Point(507, 66);
    this.textClaimants_Judge.MGAStyle = (MGAStyles) 2;
    ((Control) this.textClaimants_Judge).Name = "textClaimants_Judge";
    ((Control) this.textClaimants_Judge).Size = new Size(248, 19);
    ((Control) this.textClaimants_Judge).TabIndex = 16 /*0x10*/;
    ((UltraControlBase) this.textClaimants_Judge).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textClaimants_Judge).UseOsThemes = (DefaultableBoolean) 2;
    this.label49.AutoSize = true;
    this.label49.BackColor = Color.Transparent;
    this.label49.ForeColor = Color.Black;
    this.label49.Location = new Point(404, 66);
    this.label49.Name = "label49";
    this.label49.Size = new Size(39, 13);
    this.label49.TabIndex = 15;
    this.label49.Text = "Judge:";
    ((AppearanceBase) appearance40).BackColor = Color.White;
    ((AppearanceBase) appearance40).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance40).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textClaimants_ClaimantAttorney).Appearance = (AppearanceBase) appearance40;
    ((Control) this.textClaimants_ClaimantAttorney).BackColor = Color.White;
    ((Control) this.textClaimants_ClaimantAttorney).Location = new Point(507, 139);
    this.textClaimants_ClaimantAttorney.MGAStyle = (MGAStyles) 2;
    ((Control) this.textClaimants_ClaimantAttorney).Name = "textClaimants_ClaimantAttorney";
    ((Control) this.textClaimants_ClaimantAttorney).Size = new Size(248, 19);
    ((Control) this.textClaimants_ClaimantAttorney).TabIndex = 20;
    ((UltraControlBase) this.textClaimants_ClaimantAttorney).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textClaimants_ClaimantAttorney).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance41).BackColor = Color.White;
    ((AppearanceBase) appearance41).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance41).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textClaimants_ClaimantLawFirm).Appearance = (AppearanceBase) appearance41;
    ((Control) this.textClaimants_ClaimantLawFirm).BackColor = Color.White;
    ((Control) this.textClaimants_ClaimantLawFirm).Location = new Point(507, 113);
    this.textClaimants_ClaimantLawFirm.MGAStyle = (MGAStyles) 2;
    ((Control) this.textClaimants_ClaimantLawFirm).Name = "textClaimants_ClaimantLawFirm";
    ((Control) this.textClaimants_ClaimantLawFirm).Size = new Size(248, 19);
    ((Control) this.textClaimants_ClaimantLawFirm).TabIndex = 18;
    ((UltraControlBase) this.textClaimants_ClaimantLawFirm).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textClaimants_ClaimantLawFirm).UseOsThemes = (DefaultableBoolean) 2;
    this.label47.AutoSize = true;
    this.label47.BackColor = Color.Transparent;
    this.label47.ForeColor = Color.Black;
    this.label47.Location = new Point(404, 112 /*0x70*/);
    this.label47.Name = "label47";
    this.label47.Size = new Size(95, 13);
    this.label47.TabIndex = 17;
    this.label47.Text = "Claimant Law Firm:";
    this.label48.AutoSize = true;
    this.label48.BackColor = Color.Transparent;
    this.label48.ForeColor = Color.Black;
    this.label48.Location = new Point(404, 138);
    this.label48.Name = "label48";
    this.label48.Size = new Size(92, 13);
    this.label48.TabIndex = 19;
    this.label48.Text = "Claimant Attorney:";
    ((AppearanceBase) appearance42).BackColor = Color.White;
    ((AppearanceBase) appearance42).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance42).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textClaimants_DefenseFirm).Appearance = (AppearanceBase) appearance42;
    ((Control) this.textClaimants_DefenseFirm).BackColor = Color.White;
    ((Control) this.textClaimants_DefenseFirm).Location = new Point(125, 111);
    this.textClaimants_DefenseFirm.MGAStyle = (MGAStyles) 2;
    ((Control) this.textClaimants_DefenseFirm).Name = "textClaimants_DefenseFirm";
    ((Control) this.textClaimants_DefenseFirm).Size = new Size(257, 19);
    ((Control) this.textClaimants_DefenseFirm).TabIndex = 7;
    ((UltraControlBase) this.textClaimants_DefenseFirm).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textClaimants_DefenseFirm).UseOsThemes = (DefaultableBoolean) 2;
    this.label46.AutoSize = true;
    this.label46.BackColor = Color.Transparent;
    this.label46.ForeColor = Color.Black;
    this.label46.Location = new Point(30, 112 /*0x70*/);
    this.label46.Name = "label46";
    this.label46.Size = new Size(72, 13);
    this.label46.TabIndex = 6;
    this.label46.Text = "Defense Firm:";
    this.label45.AutoSize = true;
    this.label45.BackColor = Color.Transparent;
    this.label45.ForeColor = Color.Black;
    this.label45.Location = new Point(28, 110);
    this.label45.Name = "label45";
    this.label45.Size = new Size(49, 13);
    this.label45.TabIndex = 41;
    this.label45.Text = "Attorney:";
    ((AppearanceBase) appearance43).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraDateTimeEditor) this.dateTimeClaimants_SuitAnswered).Appearance = (AppearanceBase) appearance43;
    ((AppearanceBase) appearance44).AlphaLevel = (short) 14;
    ((AppearanceBase) appearance44).BackColor = Color.FromArgb(0, 0, 246, 253);
    ((AppearanceBase) appearance44).BackColor2 = Color.FromArgb(133, 162, 221);
    ((AppearanceBase) appearance44).BackColorAlpha = (Alpha) 2;
    ((AppearanceBase) appearance44).BackGradientAlignment = (GradientAlignment) 4;
    ((AppearanceBase) appearance44).BackGradientStyle = (GradientStyle) 5;
    ((AppearanceBase) appearance44).BorderAlpha = (Alpha) 1;
    ((AppearanceBase) appearance44).BorderColor = Color.FromArgb(78, 122, 171);
    ((AppearanceBase) appearance44).ForeColor = Color.FromArgb(49, 85, 153);
    ((AppearanceBase) appearance44).ForegroundAlpha = (Alpha) 2;
    ((UltraDateTimeEditor) this.dateTimeClaimants_SuitAnswered).ButtonAppearance = (AppearanceBase) appearance44;
    ((UltraDateTimeEditor) this.dateTimeClaimants_SuitAnswered).DateTime = new DateTime(2007, 10, 3, 0, 0, 0, 0);
    ((Control) this.dateTimeClaimants_SuitAnswered).Location = new Point(125, 85);
    this.dateTimeClaimants_SuitAnswered.MGAStyle = (MGAStyles) 2;
    ((Control) this.dateTimeClaimants_SuitAnswered).Name = "dateTimeClaimants_SuitAnswered";
    ((Control) this.dateTimeClaimants_SuitAnswered).Size = new Size(92, 19);
    ((Control) this.dateTimeClaimants_SuitAnswered).TabIndex = 4;
    ((UltraControlBase) this.dateTimeClaimants_SuitAnswered).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dateTimeClaimants_SuitAnswered).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDateTimeEditor) this.dateTimeClaimants_SuitAnswered).Value = (object) new DateTime(2007, 10, 3, 0, 0, 0, 0);
    this.label43.AutoSize = true;
    this.label43.BackColor = Color.Transparent;
    this.label43.ForeColor = Color.Black;
    this.label43.Location = new Point(30, 85);
    this.label43.Name = "label43";
    this.label43.Size = new Size(83, 13);
    this.label43.TabIndex = 3;
    this.label43.Text = "Date Answered:";
    ((AppearanceBase) appearance45).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraDateTimeEditor) this.dateTimeClaimants_SuitServed).Appearance = (AppearanceBase) appearance45;
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
    ((UltraDateTimeEditor) this.dateTimeClaimants_SuitServed).ButtonAppearance = (AppearanceBase) appearance46;
    ((UltraDateTimeEditor) this.dateTimeClaimants_SuitServed).DateTime = new DateTime(2007, 10, 3, 0, 0, 0, 0);
    ((Control) this.dateTimeClaimants_SuitServed).Location = new Point(125, 59);
    this.dateTimeClaimants_SuitServed.MGAStyle = (MGAStyles) 2;
    ((Control) this.dateTimeClaimants_SuitServed).Name = "dateTimeClaimants_SuitServed";
    ((Control) this.dateTimeClaimants_SuitServed).Size = new Size(92, 19);
    ((Control) this.dateTimeClaimants_SuitServed).TabIndex = 2;
    ((UltraControlBase) this.dateTimeClaimants_SuitServed).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dateTimeClaimants_SuitServed).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDateTimeEditor) this.dateTimeClaimants_SuitServed).Value = (object) new DateTime(2007, 10, 3, 0, 0, 0, 0);
    this.label44.AutoSize = true;
    this.label44.BackColor = Color.Transparent;
    this.label44.ForeColor = Color.Black;
    this.label44.Location = new Point(30, 59);
    this.label44.Name = "label44";
    this.label44.Size = new Size(70, 13);
    this.label44.TabIndex = 1;
    this.label44.Text = "Date Served:";
    ((AppearanceBase) appearance47).BorderColor = Color.Gray;
    ((AppearanceBase) appearance47).ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.checkClaimants_SuitServed).Appearance = (AppearanceBase) appearance47;
    ((Control) this.checkClaimants_SuitServed).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.checkClaimants_SuitServed).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.checkClaimants_SuitServed).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007RadioButtonGlyphInfo;
    ((Control) this.checkClaimants_SuitServed).Location = new Point(125, 39);
    ((Control) this.checkClaimants_SuitServed).Name = "checkClaimants_SuitServed";
    ((Control) this.checkClaimants_SuitServed).Size = new Size(120, 20);
    ((Control) this.checkClaimants_SuitServed).TabIndex = 0;
    ((Control) this.checkClaimants_SuitServed).Text = "Suit Served";
    this.addResolverClaimants_DefenseAttorney.Address1 = "";
    this.addResolverClaimants_DefenseAttorney.Address2 = "";
    ((Control) this.addResolverClaimants_DefenseAttorney).BackColor = Color.Transparent;
    this.addResolverClaimants_DefenseAttorney.City = "";
    this.addResolverClaimants_DefenseAttorney.County = "";
    ((Control) this.addResolverClaimants_DefenseAttorney).Font = new Font("Tahoma", 8f);
    this.addResolverClaimants_DefenseAttorney.ISOCountryCode = "";
    this.addResolverClaimants_DefenseAttorney.ISOCountryCodeMember = "";
    this.addResolverClaimants_DefenseAttorney.ISOCountryList = (object) null;
    this.addResolverClaimants_DefenseAttorney.ISOCountryNameMember = "";
    ((Control) this.addResolverClaimants_DefenseAttorney).Location = new Point(22, 183);
    this.addResolverClaimants_DefenseAttorney.MGAStyle = (MGAStyles) 2;
    ((Control) this.addResolverClaimants_DefenseAttorney).Name = "addResolverClaimants_DefenseAttorney";
    this.addResolverClaimants_DefenseAttorney.Password = (string) null;
    ((Control) this.addResolverClaimants_DefenseAttorney).Size = new Size(279, 152);
    this.addResolverClaimants_DefenseAttorney.State = "";
    ((Control) this.addResolverClaimants_DefenseAttorney).TabIndex = 12;
    this.addResolverClaimants_DefenseAttorney.TextAlign = ContentAlignment.TopLeft;
    this.addResolverClaimants_DefenseAttorney.UserID = (string) null;
    this.addResolverClaimants_DefenseAttorney.WebserviceUrl = (string) null;
    this.addResolverClaimants_DefenseAttorney.ZipCode = "";
    this.addResolverClaimants_DefenseAttorney.ZipCodeExtension = "";
    this.addResolverClaimants_ClaimantAttorney.Address1 = "";
    this.addResolverClaimants_ClaimantAttorney.Address2 = "";
    ((Control) this.addResolverClaimants_ClaimantAttorney).BackColor = Color.Transparent;
    this.addResolverClaimants_ClaimantAttorney.City = "";
    this.addResolverClaimants_ClaimantAttorney.County = "";
    ((Control) this.addResolverClaimants_ClaimantAttorney).Font = new Font("Tahoma", 8f);
    this.addResolverClaimants_ClaimantAttorney.ISOCountryCode = "";
    this.addResolverClaimants_ClaimantAttorney.ISOCountryCodeMember = "";
    this.addResolverClaimants_ClaimantAttorney.ISOCountryList = (object) null;
    this.addResolverClaimants_ClaimantAttorney.ISOCountryNameMember = "";
    ((Control) this.addResolverClaimants_ClaimantAttorney).Location = new Point(397, 183);
    this.addResolverClaimants_ClaimantAttorney.MGAStyle = (MGAStyles) 2;
    ((Control) this.addResolverClaimants_ClaimantAttorney).Name = "addResolverClaimants_ClaimantAttorney";
    this.addResolverClaimants_ClaimantAttorney.Password = (string) null;
    ((Control) this.addResolverClaimants_ClaimantAttorney).Size = new Size(286, 152);
    this.addResolverClaimants_ClaimantAttorney.State = "";
    ((Control) this.addResolverClaimants_ClaimantAttorney).TabIndex = 23;
    this.addResolverClaimants_ClaimantAttorney.TextAlign = ContentAlignment.TopLeft;
    this.addResolverClaimants_ClaimantAttorney.UserID = (string) null;
    this.addResolverClaimants_ClaimantAttorney.WebserviceUrl = (string) null;
    this.addResolverClaimants_ClaimantAttorney.ZipCode = "";
    this.addResolverClaimants_ClaimantAttorney.ZipCodeExtension = "";
    ((Control) this.tabPageClaimantReservesPayments).Controls.Add((Control) this.gridClaimants_ReservePayments);
    ((Control) this.tabPageClaimantReservesPayments).Location = new Point(-10000, -10000);
    ((Control) this.tabPageClaimantReservesPayments).Name = "tabPageClaimantReservesPayments";
    ((Control) this.tabPageClaimantReservesPayments).Size = new Size(951, 558);
    ((Control) this.gridClaimants_ReservePayments).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.gridClaimants_ReservePayments).DataSource = (object) this.dsReservesPayments1;
    ((AppearanceBase) appearance48).BackColor = Color.White;
    ((AppearanceBase) appearance48).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.Appearance = (AppearanceBase) appearance48;
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance49).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance49).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance49).ForeColor = Color.Black;
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance49;
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.Override.AllowAddNew = (AllowAddNew) 6;
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
    ((AppearanceBase) appearance50).BorderColor = Color.LightGray;
    ((AppearanceBase) appearance50).TextHAlignAsString = "Left";
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance50;
    ((AppearanceBase) appearance51).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((AppearanceBase) appearance51).TextHAlignAsString = "Left";
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance51;
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance52).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance52;
    ((AppearanceBase) appearance53).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance53;
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.Override.RowSpacingAfter = 1;
    ((AppearanceBase) appearance54).BackColor = Color.Transparent;
    ((AppearanceBase) appearance54).ForeColor = Color.Black;
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance54;
    ((AppearanceBase) appearance55).BackColor = Color.LightSteelBlue;
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance55;
    ((AppearanceBase) appearance56).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance56).BorderColor = Color.Silver;
    scrollBarLook2.ButtonAppearance = (AppearanceBase) appearance56;
    ((AppearanceBase) appearance57).BackColor = Color.White;
    scrollBarLook2.TrackAppearance = (AppearanceBase) appearance57;
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.ScrollBarLook = scrollBarLook2;
    ((Control) this.gridClaimants_ReservePayments).Location = new Point(4, 26);
    ((Control) this.gridClaimants_ReservePayments).Name = "gridClaimants_ReservePayments";
    ((Control) this.gridClaimants_ReservePayments).Size = new Size(940, 571);
    ((Control) this.gridClaimants_ReservePayments).TabIndex = 0;
    ((UltraControlBase) this.gridClaimants_ReservePayments).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridClaimants_ReservePayments).UseOsThemes = (DefaultableBoolean) 2;
    this.dsReservesPayments1.DataSetName = "dsReservesPayments";
    this.dsReservesPayments1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((Control) this.tabPageClaimOverview).Controls.Add((Control) this.groupIncurred);
    ((Control) this.tabPageClaimOverview).Controls.Add((Control) this.groupBox4);
    ((Control) this.tabPageClaimOverview).Controls.Add((Control) this.groupBox3);
    ((Control) this.tabPageClaimOverview).Controls.Add((Control) this.groupBox2);
    ((Control) this.tabPageClaimOverview).Controls.Add((Control) this.groupBox1);
    ((Control) this.tabPageClaimOverview).Location = new Point(1, 22);
    ((Control) this.tabPageClaimOverview).Name = "tabPageClaimOverview";
    ((Control) this.tabPageClaimOverview).Size = new Size(974, 626);
    this.groupIncurred.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.groupIncurred.Controls.Add((Control) this.gridIncurred);
    this.groupIncurred.ForeColor = Color.Black;
    this.groupIncurred.Location = new Point(379, 352);
    this.groupIncurred.Name = "groupIncurred";
    this.groupIncurred.Size = new Size(592, 321);
    this.groupIncurred.TabIndex = 4;
    this.groupIncurred.TabStop = false;
    this.groupIncurred.Text = "Totals / Incurred";
    ((Control) this.gridIncurred).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((AppearanceBase) appearance58).BackColor = Color.Transparent;
    ((AppearanceBase) appearance58).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridIncurred).DisplayLayout.Appearance = (AppearanceBase) appearance58;
    ((UltraGridBase) this.gridIncurred).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((UltraGridBase) this.gridIncurred).DisplayLayout.BorderStyle = (UIElementBorderStyle) 1;
    ((AppearanceBase) appearance59).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance59).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance59).ForeColor = Color.Black;
    ((UltraGridBase) this.gridIncurred).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance59;
    ((UltraGridBase) this.gridIncurred).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridIncurred).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridIncurred).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance60).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridIncurred).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance60;
    ((UltraGridBase) this.gridIncurred).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance61).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.gridIncurred).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance61;
    ((UltraGridBase) this.gridIncurred).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance62).BackColor = Color.Transparent;
    ((UltraGridBase) this.gridIncurred).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance62;
    ((AppearanceBase) appearance63).BackColor = Color.Transparent;
    ((AppearanceBase) appearance63).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridIncurred).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance63;
    ((UltraGridBase) this.gridIncurred).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance64).BackColor = Color.Transparent;
    ((AppearanceBase) appearance64).ForeColor = Color.Black;
    ((UltraGridBase) this.gridIncurred).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance64;
    ((AppearanceBase) appearance65).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance65).BorderColor = Color.Silver;
    scrollBarLook3.ButtonAppearance = (AppearanceBase) appearance65;
    ((AppearanceBase) appearance66).BackColor = Color.White;
    scrollBarLook3.TrackAppearance = (AppearanceBase) appearance66;
    ((UltraGridBase) this.gridIncurred).DisplayLayout.ScrollBarLook = scrollBarLook3;
    ((Control) this.gridIncurred).Location = new Point(7, 21);
    ((Control) this.gridIncurred).Name = "gridIncurred";
    ((Control) this.gridIncurred).Size = new Size(579, 292);
    ((Control) this.gridIncurred).TabIndex = 0;
    ((UltraControlBase) this.gridIncurred).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridIncurred).UseOsThemes = (DefaultableBoolean) 2;
    this.groupBox4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.groupBox4.Controls.Add((Control) this.gridOverview_ReservePaymentBreakout);
    this.groupBox4.ForeColor = Color.Black;
    this.groupBox4.Location = new Point(379, 15);
    this.groupBox4.Name = "groupBox4";
    this.groupBox4.Size = new Size(592, 332);
    this.groupBox4.TabIndex = 3;
    this.groupBox4.TabStop = false;
    this.groupBox4.Text = "Reserve/Payment Breakout";
    ((Control) this.gridOverview_ReservePaymentBreakout).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.ultraToolbarsManager1.SetContextMenuUltra((Component) this.gridOverview_ReservePaymentBreakout, "ReservePaymentBreakoutContext");
    ((UltraGridBase) this.gridOverview_ReservePaymentBreakout).DataMember = "Claimants";
    ((UltraGridBase) this.gridOverview_ReservePaymentBreakout).DataSource = (object) this.dsReservePaymentBreakout1;
    ((AppearanceBase) appearance67).BackColor = Color.Transparent;
    ((AppearanceBase) appearance67).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridOverview_ReservePaymentBreakout).DisplayLayout.Appearance = (AppearanceBase) appearance67;
    ((UltraGridBase) this.gridOverview_ReservePaymentBreakout).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand1.ColHeadersVisible = false;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn1.Header).VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 77;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn2.Header).VisiblePosition = 1;
    ultraGridColumn2.Width = 561;
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn3.Header).VisiblePosition = 2;
    ultraGridBand1.Columns.AddRange(new object[3]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3
    });
    ultraGridBand1.GroupHeadersVisible = false;
    ultraGridBand2.CardSettings.AllowLabelSizing = false;
    ultraGridBand2.CardSettings.AllowSizing = false;
    ultraGridBand2.CardSettings.Width = 100;
    ultraGridBand2.CardView = true;
    ultraGridColumn4.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn4.Header).VisiblePosition = 0;
    ultraGridColumn4.Hidden = true;
    ultraGridColumn4.Width = 71;
    ultraGridColumn5.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn5.Header).VisiblePosition = 1;
    ultraGridColumn5.Hidden = true;
    ultraGridColumn5.Width = 33;
    ultraGridColumn6.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn6.Header).VisiblePosition = 2;
    ultraGridColumn6.Hidden = true;
    ultraGridColumn6.Width = 29;
    ultraGridColumn7.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn7.Header).Caption = "Reserve/Payment Type";
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn7.Header).VisiblePosition = 3;
    ultraGridColumn7.Width = 87;
    ultraGridColumn8.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn8.Header).VisiblePosition = 4;
    ultraGridColumn8.Hidden = true;
    ultraGridColumn8.Width = 35;
    ultraGridColumn9.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn9.Header).Caption = "Reserve/Payment Sub Type";
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn9.Header).VisiblePosition = 5;
    ultraGridColumn9.Width = 97;
    ultraGridColumn10.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn10.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn10.Header).VisiblePosition = 6;
    ultraGridColumn10.Hidden = true;
    ultraGridColumn10.Width = 33;
    ultraGridColumn11.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn11.Header).Caption = "Coverage Type";
    ((HeaderBase) ultraGridColumn11.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn11.Header).VisiblePosition = 7;
    ultraGridColumn11.Width = 64 /*0x40*/;
    ultraGridColumn12.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn12.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn12.Header).VisiblePosition = 8;
    ultraGridColumn12.Hidden = true;
    ultraGridColumn12.Width = 51;
    ultraGridColumn13.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn13.Header).Caption = "Coverage Type Description";
    ((HeaderBase) ultraGridColumn13.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn13.Header).VisiblePosition = 9;
    ultraGridColumn13.Width = 91;
    ultraGridColumn14.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance68).TextHAlignAsString = "Left";
    ultraGridColumn14.CellAppearance = (AppearanceBase) appearance68;
    ultraGridColumn14.Format = "c";
    ((HeaderBase) ultraGridColumn14.Header).Caption = "Total Reserve";
    ((HeaderBase) ultraGridColumn14.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn14.Header).VisiblePosition = 10;
    ultraGridColumn14.Width = 52;
    ultraGridColumn15.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance69).TextHAlignAsString = "Left";
    ultraGridColumn15.CellAppearance = (AppearanceBase) appearance69;
    ultraGridColumn15.Format = "c";
    ((HeaderBase) ultraGridColumn15.Header).Caption = "Total Payments";
    ((HeaderBase) ultraGridColumn15.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn15.Header).VisiblePosition = 11;
    ultraGridColumn15.Width = 58;
    ultraGridColumn16.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance70).TextHAlignAsString = "Left";
    ultraGridColumn16.CellAppearance = (AppearanceBase) appearance70;
    ultraGridColumn16.Format = "c";
    ((HeaderBase) ultraGridColumn16.Header).Caption = "Remaining Reserves";
    ((HeaderBase) ultraGridColumn16.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn16.Header).VisiblePosition = 12;
    ultraGridColumn16.Width = 71;
    ultraGridBand2.Columns.AddRange(new object[13]
    {
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
    ((AppearanceBase) appearance71).BackColor = Color.LightSteelBlue;
    ultraGridBand2.Override.CardCaptionAppearance = (AppearanceBase) appearance71;
    ((AppearanceBase) appearance72).BackColor = Color.Transparent;
    ultraGridBand2.Override.HeaderAppearance = (AppearanceBase) appearance72;
    ((UltraGridBase) this.gridOverview_ReservePaymentBreakout).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.gridOverview_ReservePaymentBreakout).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.gridOverview_ReservePaymentBreakout).DisplayLayout.BorderStyle = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.gridOverview_ReservePaymentBreakout).DisplayLayout.MaxRowScrollRegions = 1;
    ((AppearanceBase) appearance73).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance73).BorderColor = Color.Transparent;
    ((AppearanceBase) appearance73).ForeColor = Color.Black;
    ((UltraGridBase) this.gridOverview_ReservePaymentBreakout).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance73;
    ((UltraGridBase) this.gridOverview_ReservePaymentBreakout).DisplayLayout.Override.AllowAddNew = (AllowAddNew) 2;
    ((UltraGridBase) this.gridOverview_ReservePaymentBreakout).DisplayLayout.Override.AllowColMoving = (AllowColMoving) 1;
    ((UltraGridBase) this.gridOverview_ReservePaymentBreakout).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridOverview_ReservePaymentBreakout).DisplayLayout.Override.AllowColSwapping = (AllowColSwapping) 1;
    ((UltraGridBase) this.gridOverview_ReservePaymentBreakout).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridOverview_ReservePaymentBreakout).DisplayLayout.Override.AllowGroupBy = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridOverview_ReservePaymentBreakout).DisplayLayout.Override.AllowGroupMoving = (AllowGroupMoving) 1;
    ((UltraGridBase) this.gridOverview_ReservePaymentBreakout).DisplayLayout.Override.AllowGroupSwapping = (AllowGroupSwapping) 1;
    ((UltraGridBase) this.gridOverview_ReservePaymentBreakout).DisplayLayout.Override.AllowMultiCellOperations = (AllowMultiCellOperation) 0;
    ((UltraGridBase) this.gridOverview_ReservePaymentBreakout).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridOverview_ReservePaymentBreakout).DisplayLayout.Override.AllowRowLayoutCellSizing = (RowLayoutSizing) 1;
    ((UltraGridBase) this.gridOverview_ReservePaymentBreakout).DisplayLayout.Override.AllowRowLayoutCellSpanSizing = (GridBagLayoutAllowSpanSizing) 1;
    ((UltraGridBase) this.gridOverview_ReservePaymentBreakout).DisplayLayout.Override.AllowRowLayoutColMoving = (GridBagLayoutAllowMoving) 1;
    ((UltraGridBase) this.gridOverview_ReservePaymentBreakout).DisplayLayout.Override.AllowRowLayoutLabelSizing = (RowLayoutSizing) 1;
    ((UltraGridBase) this.gridOverview_ReservePaymentBreakout).DisplayLayout.Override.AllowRowLayoutLabelSpanSizing = (GridBagLayoutAllowSpanSizing) 1;
    ((UltraGridBase) this.gridOverview_ReservePaymentBreakout).DisplayLayout.Override.AllowRowSummaries = (AllowRowSummaries) 2;
    ((UltraGridBase) this.gridOverview_ReservePaymentBreakout).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance74).BackColor = Color.Transparent;
    ((UltraGridBase) this.gridOverview_ReservePaymentBreakout).DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance74;
    ((AppearanceBase) appearance75).BorderColor = Color.Transparent;
    ((UltraGridBase) this.gridOverview_ReservePaymentBreakout).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance75;
    ((UltraGridBase) this.gridOverview_ReservePaymentBreakout).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance76).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.gridOverview_ReservePaymentBreakout).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance76;
    ((UltraGridBase) this.gridOverview_ReservePaymentBreakout).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance77).BackColor = Color.Transparent;
    ((UltraGridBase) this.gridOverview_ReservePaymentBreakout).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance77;
    ((AppearanceBase) appearance78).BackColor = Color.Transparent;
    ((AppearanceBase) appearance78).BorderColor = Color.Transparent;
    ((UltraGridBase) this.gridOverview_ReservePaymentBreakout).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance78;
    ((UltraGridBase) this.gridOverview_ReservePaymentBreakout).DisplayLayout.Override.RowSelectorHeaderStyle = (RowSelectorHeaderStyle) 1;
    ((UltraGridBase) this.gridOverview_ReservePaymentBreakout).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance79).BackColor = Color.Transparent;
    ((AppearanceBase) appearance79).ForeColor = Color.Black;
    ((UltraGridBase) this.gridOverview_ReservePaymentBreakout).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance79;
    ((AppearanceBase) appearance80).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance80).BorderColor = Color.Silver;
    scrollBarLook4.ButtonAppearance = (AppearanceBase) appearance80;
    ((AppearanceBase) appearance81).BackColor = Color.White;
    scrollBarLook4.TrackAppearance = (AppearanceBase) appearance81;
    scrollBarLook4.ViewStyle = (ScrollBarViewStyle) 2;
    ((UltraGridBase) this.gridOverview_ReservePaymentBreakout).DisplayLayout.ScrollBarLook = scrollBarLook4;
    ((AppearanceBase) appearance82).BackColor = Color.Transparent;
    ((AppearanceBase) appearance82).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ultraGridLayout1.Appearance = (AppearanceBase) appearance82;
    ultraGridLayout1.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand3.ColHeadersVisible = false;
    ultraGridColumn17.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn17.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn17.Header).VisiblePosition = 0;
    ultraGridColumn17.Hidden = true;
    ultraGridColumn17.Width = 77;
    ultraGridColumn18.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn18.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn18.Header).VisiblePosition = 1;
    ultraGridColumn18.Width = 561;
    ultraGridColumn19.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn19.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn19.Header).VisiblePosition = 2;
    ultraGridBand3.Columns.AddRange(new object[3]
    {
      (object) ultraGridColumn17,
      (object) ultraGridColumn18,
      (object) ultraGridColumn19
    });
    ultraGridBand3.GroupHeadersVisible = false;
    ultraGridBand4.CardSettings.AllowLabelSizing = false;
    ultraGridBand4.CardSettings.AllowSizing = false;
    ultraGridBand4.CardSettings.Width = 100;
    ultraGridBand4.CardView = true;
    ultraGridColumn20.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn20.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn20.Header).VisiblePosition = 0;
    ultraGridColumn20.Hidden = true;
    ultraGridColumn20.Width = 71;
    ultraGridColumn21.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn21.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn21.Header).VisiblePosition = 1;
    ultraGridColumn21.Hidden = true;
    ultraGridColumn21.Width = 33;
    ultraGridColumn22.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn22.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn22.Header).VisiblePosition = 2;
    ultraGridColumn22.Hidden = true;
    ultraGridColumn22.Width = 29;
    ultraGridColumn23.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn23.Header).Caption = "Reserve/Payment Type";
    ((HeaderBase) ultraGridColumn23.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn23.Header).VisiblePosition = 3;
    ultraGridColumn23.Width = 87;
    ultraGridColumn24.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn24.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn24.Header).VisiblePosition = 4;
    ultraGridColumn24.Hidden = true;
    ultraGridColumn24.Width = 35;
    ultraGridColumn25.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn25.Header).Caption = "Reserve/Payment Sub Type";
    ((HeaderBase) ultraGridColumn25.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn25.Header).VisiblePosition = 5;
    ultraGridColumn25.Width = 97;
    ultraGridColumn26.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn26.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn26.Header).VisiblePosition = 6;
    ultraGridColumn26.Hidden = true;
    ultraGridColumn26.Width = 33;
    ultraGridColumn27.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn27.Header).Caption = "Coverage Type";
    ((HeaderBase) ultraGridColumn27.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn27.Header).VisiblePosition = 7;
    ultraGridColumn27.Width = 64 /*0x40*/;
    ultraGridColumn28.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn28.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn28.Header).VisiblePosition = 8;
    ultraGridColumn28.Hidden = true;
    ultraGridColumn28.Width = 51;
    ultraGridColumn29.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn29.Header).Caption = "Coverage Type Description";
    ((HeaderBase) ultraGridColumn29.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn29.Header).VisiblePosition = 9;
    ultraGridColumn29.Width = 91;
    ultraGridColumn30.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance83).TextHAlignAsString = "Left";
    ultraGridColumn30.CellAppearance = (AppearanceBase) appearance83;
    ultraGridColumn30.Format = "c";
    ((HeaderBase) ultraGridColumn30.Header).Caption = "Total Reserve";
    ((HeaderBase) ultraGridColumn30.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn30.Header).VisiblePosition = 10;
    ultraGridColumn30.Width = 52;
    ultraGridColumn31.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance84).TextHAlignAsString = "Left";
    ultraGridColumn31.CellAppearance = (AppearanceBase) appearance84;
    ultraGridColumn31.Format = "c";
    ((HeaderBase) ultraGridColumn31.Header).Caption = "Total Payments";
    ((HeaderBase) ultraGridColumn31.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn31.Header).VisiblePosition = 11;
    ultraGridColumn31.Width = 58;
    ultraGridColumn32.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance85).TextHAlignAsString = "Left";
    ultraGridColumn32.CellAppearance = (AppearanceBase) appearance85;
    ultraGridColumn32.Format = "c";
    ((HeaderBase) ultraGridColumn32.Header).Caption = "Remaining Reserves";
    ((HeaderBase) ultraGridColumn32.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn32.Header).VisiblePosition = 12;
    ultraGridColumn32.Width = 71;
    ultraGridBand4.Columns.AddRange(new object[13]
    {
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
      (object) ultraGridColumn31,
      (object) ultraGridColumn32
    });
    ((AppearanceBase) appearance86).BackColor = Color.LightSteelBlue;
    ultraGridBand4.Override.CardCaptionAppearance = (AppearanceBase) appearance86;
    ((AppearanceBase) appearance87).BackColor = Color.Transparent;
    ultraGridBand4.Override.HeaderAppearance = (AppearanceBase) appearance87;
    ultraGridLayout1.BandsSerializer.Add((object) ultraGridBand3);
    ultraGridLayout1.BandsSerializer.Add((object) ultraGridBand4);
    ultraGridLayout1.BorderStyle = (UIElementBorderStyle) 1;
    ((KeyedSubObjectBase) ultraGridLayout1).Key = "ReservePaymentBreakout";
    ultraGridLayout1.MaxRowScrollRegions = 1;
    ((AppearanceBase) appearance88).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance88).BorderColor = Color.Transparent;
    ((AppearanceBase) appearance88).ForeColor = Color.Black;
    ultraGridLayout1.Override.ActiveRowAppearance = (AppearanceBase) appearance88;
    ultraGridLayout1.Override.AllowAddNew = (AllowAddNew) 2;
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
    ultraGridLayout1.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance89).BackColor = Color.Transparent;
    ultraGridLayout1.Override.CardAreaAppearance = (AppearanceBase) appearance89;
    ((AppearanceBase) appearance90).BorderColor = Color.Transparent;
    ultraGridLayout1.Override.CellAppearance = (AppearanceBase) appearance90;
    ultraGridLayout1.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance91).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ultraGridLayout1.Override.HeaderAppearance = (AppearanceBase) appearance91;
    ultraGridLayout1.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance92).BackColor = Color.Transparent;
    ultraGridLayout1.Override.RowAlternateAppearance = (AppearanceBase) appearance92;
    ((AppearanceBase) appearance93).BackColor = Color.Transparent;
    ((AppearanceBase) appearance93).BorderColor = Color.Transparent;
    ultraGridLayout1.Override.RowAppearance = (AppearanceBase) appearance93;
    ultraGridLayout1.Override.RowSelectorHeaderStyle = (RowSelectorHeaderStyle) 1;
    ultraGridLayout1.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance94).BackColor = Color.Transparent;
    ((AppearanceBase) appearance94).ForeColor = Color.Black;
    ultraGridLayout1.Override.SelectedRowAppearance = (AppearanceBase) appearance94;
    ((AppearanceBase) appearance95).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance95).BorderColor = Color.Silver;
    scrollBarLook5.ButtonAppearance = (AppearanceBase) appearance95;
    ((AppearanceBase) appearance96).BackColor = Color.White;
    scrollBarLook5.TrackAppearance = (AppearanceBase) appearance96;
    scrollBarLook5.ViewStyle = (ScrollBarViewStyle) 2;
    ultraGridLayout1.ScrollBarLook = scrollBarLook5;
    ((UltraGridBase) this.gridOverview_ReservePaymentBreakout).Layouts.Add(ultraGridLayout1);
    ((Control) this.gridOverview_ReservePaymentBreakout).Location = new Point(6, 20);
    ((Control) this.gridOverview_ReservePaymentBreakout).Name = "gridOverview_ReservePaymentBreakout";
    ((Control) this.gridOverview_ReservePaymentBreakout).Size = new Size(580, 306);
    ((Control) this.gridOverview_ReservePaymentBreakout).TabIndex = 0;
    ((UltraControlBase) this.gridOverview_ReservePaymentBreakout).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridOverview_ReservePaymentBreakout).UseOsThemes = (DefaultableBoolean) 2;
    this.dsReservePaymentBreakout1.DataSetName = "dsReservePaymentBreakout";
    this.dsReservePaymentBreakout1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.groupBox3.Controls.Add((Control) this.comboClaim_CatastropheCode2);
    this.groupBox3.Controls.Add((Control) this.textOverview_ClaimNumber);
    this.groupBox3.Controls.Add((Control) this.buttonEditClaimNumber);
    this.groupBox3.Controls.Add((Control) this.comboClaim_CatastropheCode);
    this.groupBox3.Controls.Add((Control) this.comboAdjusterAssigned);
    this.groupBox3.Controls.Add((Control) this.label56);
    this.groupBox3.Controls.Add((Control) this.label55);
    this.groupBox3.Controls.Add((Control) this.textOverview_Comments);
    this.groupBox3.Controls.Add((Control) this.dateTimeOverview_DateEntered);
    this.groupBox3.Controls.Add((Control) this.dateTimeOverview_LossDate);
    this.groupBox3.Controls.Add((Control) this.textOverview_EnteredBy);
    this.groupBox3.Controls.Add((Control) this.label6);
    this.groupBox3.Controls.Add((Control) this.label5);
    this.groupBox3.Controls.Add((Control) this.label4);
    this.groupBox3.Controls.Add((Control) this.label3);
    this.groupBox3.Controls.Add((Control) this.label2);
    this.groupBox3.ForeColor = Color.Black;
    this.groupBox3.Location = new Point(11, 15);
    this.groupBox3.Name = "groupBox3";
    this.groupBox3.Size = new Size(362, 241);
    this.groupBox3.TabIndex = 0;
    this.groupBox3.TabStop = false;
    this.groupBox3.Text = "Claim Information";
    ((AppearanceBase) appearance97).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.comboClaim_CatastropheCode2.Appearance = (AppearanceBase) appearance97;
    this.comboClaim_CatastropheCode2.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance98).BackColor = Color.FromArgb(0, 0, 246, 253);
    ((AppearanceBase) appearance98).BackColor2 = Color.FromArgb(133, 162, 221);
    ((AppearanceBase) appearance98).BackColorAlpha = (Alpha) 2;
    ((AppearanceBase) appearance98).BackGradientAlignment = (GradientAlignment) 4;
    ((AppearanceBase) appearance98).BackGradientStyle = (GradientStyle) 5;
    ((AppearanceBase) appearance98).BorderAlpha = (Alpha) 1;
    ((AppearanceBase) appearance98).BorderColor = Color.FromArgb(133, 162, 221);
    ((AppearanceBase) appearance98).ForeColor = Color.FromArgb(49, 85, 153);
    ((AppearanceBase) appearance98).ForegroundAlpha = (Alpha) 2;
    this.comboClaim_CatastropheCode2.ButtonAppearance = (AppearanceBase) appearance98;
    ((AppearanceBase) appearance99).BackColor = SystemColors.Window;
    ((AppearanceBase) appearance99).BorderColor = SystemColors.InactiveCaption;
    ((UltraGridBase) this.comboClaim_CatastropheCode2).DisplayLayout.Appearance = (AppearanceBase) appearance99;
    ((UltraGridBase) this.comboClaim_CatastropheCode2).DisplayLayout.AutoFitStyle = (AutoFitStyle) 2;
    ultraGridBand5.ColHeadersVisible = false;
    ((UltraGridBase) this.comboClaim_CatastropheCode2).DisplayLayout.BandsSerializer.Add((object) ultraGridBand5);
    ((UltraGridBase) this.comboClaim_CatastropheCode2).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.comboClaim_CatastropheCode2).DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance100).BackColor = SystemColors.ActiveBorder;
    ((AppearanceBase) appearance100).BackColor2 = SystemColors.ControlDark;
    ((AppearanceBase) appearance100).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance100).BorderColor = SystemColors.Window;
    ((SpecialBoxBase) ((UltraGridBase) this.comboClaim_CatastropheCode2).DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance100;
    ((AppearanceBase) appearance101).ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.comboClaim_CatastropheCode2).DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance101;
    ((SpecialBoxBase) ((UltraGridBase) this.comboClaim_CatastropheCode2).DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance102).BackColor = SystemColors.ControlLightLight;
    ((AppearanceBase) appearance102).BackColor2 = SystemColors.Control;
    ((AppearanceBase) appearance102).BackGradientStyle = (GradientStyle) 3;
    ((AppearanceBase) appearance102).ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.comboClaim_CatastropheCode2).DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance102;
    ((UltraGridBase) this.comboClaim_CatastropheCode2).DisplayLayout.MaxColScrollRegions = 1;
    ((UltraGridBase) this.comboClaim_CatastropheCode2).DisplayLayout.MaxRowScrollRegions = 1;
    ((AppearanceBase) appearance103).BackColor = SystemColors.Window;
    ((AppearanceBase) appearance103).ForeColor = SystemColors.ControlText;
    ((UltraGridBase) this.comboClaim_CatastropheCode2).DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance103;
    ((AppearanceBase) appearance104).BackColor = SystemColors.Highlight;
    ((AppearanceBase) appearance104).ForeColor = SystemColors.HighlightText;
    ((UltraGridBase) this.comboClaim_CatastropheCode2).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance104;
    ((UltraGridBase) this.comboClaim_CatastropheCode2).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 2;
    ((UltraGridBase) this.comboClaim_CatastropheCode2).DisplayLayout.Override.AllowRowLayoutCellSizing = (RowLayoutSizing) 1;
    ((UltraGridBase) this.comboClaim_CatastropheCode2).DisplayLayout.Override.AllowRowLayoutCellSpanSizing = (GridBagLayoutAllowSpanSizing) 1;
    ((UltraGridBase) this.comboClaim_CatastropheCode2).DisplayLayout.Override.AllowRowLayoutColMoving = (GridBagLayoutAllowMoving) 1;
    ((UltraGridBase) this.comboClaim_CatastropheCode2).DisplayLayout.Override.AllowRowLayoutLabelSizing = (RowLayoutSizing) 1;
    ((UltraGridBase) this.comboClaim_CatastropheCode2).DisplayLayout.Override.AllowRowLayoutLabelSpanSizing = (GridBagLayoutAllowSpanSizing) 1;
    ((UltraGridBase) this.comboClaim_CatastropheCode2).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 2;
    ((UltraGridBase) this.comboClaim_CatastropheCode2).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 2;
    ((AppearanceBase) appearance105).BackColor = SystemColors.Window;
    ((UltraGridBase) this.comboClaim_CatastropheCode2).DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance105;
    ((AppearanceBase) appearance106).BorderColor = Color.Silver;
    ((AppearanceBase) appearance106).TextTrimming = (TextTrimming) 3;
    ((UltraGridBase) this.comboClaim_CatastropheCode2).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance106;
    ((UltraGridBase) this.comboClaim_CatastropheCode2).DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    ((UltraGridBase) this.comboClaim_CatastropheCode2).DisplayLayout.Override.CellPadding = 0;
    ((AppearanceBase) appearance107).BackColor = SystemColors.Control;
    ((AppearanceBase) appearance107).BackColor2 = SystemColors.ControlDark;
    ((AppearanceBase) appearance107).BackGradientAlignment = (GradientAlignment) 1;
    ((AppearanceBase) appearance107).BackGradientStyle = (GradientStyle) 3;
    ((AppearanceBase) appearance107).BorderColor = SystemColors.Window;
    ((UltraGridBase) this.comboClaim_CatastropheCode2).DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance107;
    ((AppearanceBase) appearance108).TextHAlignAsString = "Left";
    ((UltraGridBase) this.comboClaim_CatastropheCode2).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance108;
    ((UltraGridBase) this.comboClaim_CatastropheCode2).DisplayLayout.Override.HeaderStyle = (HeaderStyle) 3;
    ((AppearanceBase) appearance109).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.comboClaim_CatastropheCode2).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance109;
    ((AppearanceBase) appearance110).BackColor = SystemColors.Window;
    ((AppearanceBase) appearance110).BorderColor = Color.Silver;
    ((UltraGridBase) this.comboClaim_CatastropheCode2).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance110;
    ((UltraGridBase) this.comboClaim_CatastropheCode2).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance111).BackColor = SystemColors.ControlLight;
    ((UltraGridBase) this.comboClaim_CatastropheCode2).DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance111;
    ((UltraGridBase) this.comboClaim_CatastropheCode2).DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    ((UltraGridBase) this.comboClaim_CatastropheCode2).DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    ((UltraGridBase) this.comboClaim_CatastropheCode2).DisplayLayout.ViewStyleBand = (ViewStyleBand) 2;
    ((Control) this.comboClaim_CatastropheCode2).Location = new Point(119, 39);
    ((Control) this.comboClaim_CatastropheCode2).Name = "comboClaim_CatastropheCode2";
    ((Control) this.comboClaim_CatastropheCode2).Size = new Size(236, 21);
    ((Control) this.comboClaim_CatastropheCode2).TabIndex = 14;
    ((UltraControlBase) this.comboClaim_CatastropheCode2).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboClaim_CatastropheCode2).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.comboClaim_CatastropheCode2).Visible = false;
    ((AppearanceBase) appearance112).BackColor = Color.White;
    ((AppearanceBase) appearance112).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance112).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textOverview_ClaimNumber).Appearance = (AppearanceBase) appearance112;
    ((Control) this.textOverview_ClaimNumber).BackColor = Color.White;
    ((Control) this.textOverview_ClaimNumber).Location = new Point(120, 17);
    this.textOverview_ClaimNumber.MGAStyle = (MGAStyles) 2;
    ((Control) this.textOverview_ClaimNumber).Name = "textOverview_ClaimNumber";
    ((EditorButtonControlBase) this.textOverview_ClaimNumber).ReadOnly = true;
    ((Control) this.textOverview_ClaimNumber).Size = new Size(217, 20);
    ((Control) this.textOverview_ClaimNumber).TabIndex = 1;
    ((Control) this.textOverview_ClaimNumber).TabStop = false;
    ((UltraControlBase) this.textOverview_ClaimNumber).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textOverview_ClaimNumber).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.textOverview_ClaimNumber).Enter += new EventHandler(this.OverviewTextbox_Enter);
    ((AppearanceBase) appearance113).BackColor = Color.Transparent;
    ((AppearanceBase) appearance113).BackColor2 = Color.Transparent;
    ((AppearanceBase) appearance113).BackGradientStyle = (GradientStyle) 1;
    ((AppearanceBase) appearance113).BorderColor = Color.Transparent;
    ((AppearanceBase) appearance113).Image = (object) Resources.Edit;
    ((AppearanceBase) appearance113).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance113).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonEditClaimNumber).Appearance = (AppearanceBase) appearance113;
    ((Control) this.buttonEditClaimNumber).Location = new Point(335, 17);
    ((Control) this.buttonEditClaimNumber).Name = "buttonEditClaimNumber";
    ((Control) this.buttonEditClaimNumber).Size = new Size(24, 22);
    ((Control) this.buttonEditClaimNumber).TabIndex = 15;
    ultraToolTipInfo1.ToolTipText = "Click to edit the claim number.";
    ultraToolTipInfo1.ToolTipTitle = "Edit Claim Number";
    this.ultraToolTipManager1.SetUltraToolTip((Control) this.buttonEditClaimNumber, ultraToolTipInfo1);
    ((UltraControlBase) this.buttonEditClaimNumber).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.buttonEditClaimNumber).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonEditClaimNumber).Click += new EventHandler(this.buttonEditClaimNumber_Click);
    ((UltraCombo) this.comboClaim_CatastropheCode).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraCombo) this.comboClaim_CatastropheCode).DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboClaim_CatastropheCode).Location = new Point(120, 39);
    this.comboClaim_CatastropheCode.MGAStyle = (MGAStyles) 2;
    ((Control) this.comboClaim_CatastropheCode).Name = "comboClaim_CatastropheCode";
    ((Control) this.comboClaim_CatastropheCode).Size = new Size(235, 21);
    ((Control) this.comboClaim_CatastropheCode).TabIndex = 14;
    ((UltraControlBase) this.comboClaim_CatastropheCode).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboClaim_CatastropheCode).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraCombo) this.comboAdjusterAssigned).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraCombo) this.comboAdjusterAssigned).DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboAdjusterAssigned).Location = new Point(120, 133);
    this.comboAdjusterAssigned.MGAStyle = (MGAStyles) 2;
    ((Control) this.comboAdjusterAssigned).Name = "comboAdjusterAssigned";
    ((Control) this.comboAdjusterAssigned).Size = new Size(235, 21);
    ((Control) this.comboAdjusterAssigned).TabIndex = 13;
    ((UltraControlBase) this.comboAdjusterAssigned).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboAdjusterAssigned).UseOsThemes = (DefaultableBoolean) 2;
    this.label56.AutoSize = true;
    this.label56.Location = new Point(7, 131);
    this.label56.Name = "label56";
    this.label56.Size = new Size(98, 13);
    this.label56.TabIndex = 12;
    this.label56.Text = "Adjuster Assigned:";
    this.label55.AutoSize = true;
    this.label55.Location = new Point(7, 153);
    this.label55.Name = "label55";
    this.label55.Size = new Size(61, 13);
    this.label55.TabIndex = 11;
    this.label55.Text = "Comments:";
    ((AppearanceBase) appearance114).BackColor = Color.White;
    ((AppearanceBase) appearance114).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance114).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textOverview_Comments).Appearance = (AppearanceBase) appearance114;
    ((Control) this.textOverview_Comments).BackColor = Color.White;
    ((Control) this.textOverview_Comments).Location = new Point(120, 157);
    ((TextEditorControlBase) this.textOverview_Comments).MaxLength = 550;
    this.textOverview_Comments.MGAStyle = (MGAStyles) 2;
    ((UltraTextEditor) this.textOverview_Comments).Multiline = true;
    ((Control) this.textOverview_Comments).Name = "textOverview_Comments";
    ((Control) this.textOverview_Comments).Size = new Size(236, 76);
    ((Control) this.textOverview_Comments).TabIndex = 10;
    ((Control) this.textOverview_Comments).TabStop = false;
    ((UltraControlBase) this.textOverview_Comments).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textOverview_Comments).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance115).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraDateTimeEditor) this.dateTimeOverview_DateEntered).Appearance = (AppearanceBase) appearance115;
    ((AppearanceBase) appearance116).AlphaLevel = (short) 14;
    ((AppearanceBase) appearance116).BackColor = Color.FromArgb(0, 0, 246, 253);
    ((AppearanceBase) appearance116).BackColor2 = Color.FromArgb(133, 162, 221);
    ((AppearanceBase) appearance116).BackColorAlpha = (Alpha) 2;
    ((AppearanceBase) appearance116).BackGradientAlignment = (GradientAlignment) 4;
    ((AppearanceBase) appearance116).BackGradientStyle = (GradientStyle) 5;
    ((AppearanceBase) appearance116).BorderAlpha = (Alpha) 1;
    ((AppearanceBase) appearance116).BorderColor = Color.FromArgb(78, 122, 171);
    ((AppearanceBase) appearance116).ForeColor = Color.FromArgb(49, 85, 153);
    ((AppearanceBase) appearance116).ForegroundAlpha = (Alpha) 2;
    ((UltraDateTimeEditor) this.dateTimeOverview_DateEntered).ButtonAppearance = (AppearanceBase) appearance116;
    ((UltraDateTimeEditor) this.dateTimeOverview_DateEntered).DateTime = new DateTime(2011, 2, 24, 0, 0, 0, 0);
    ((Control) this.dateTimeOverview_DateEntered).Enabled = false;
    ((Control) this.dateTimeOverview_DateEntered).Location = new Point(120, 86);
    this.dateTimeOverview_DateEntered.MGAStyle = (MGAStyles) 2;
    ((Control) this.dateTimeOverview_DateEntered).Name = "dateTimeOverview_DateEntered";
    ((Control) this.dateTimeOverview_DateEntered).Size = new Size(88, 20);
    ((Control) this.dateTimeOverview_DateEntered).TabIndex = 7;
    ((UltraControlBase) this.dateTimeOverview_DateEntered).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dateTimeOverview_DateEntered).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDateTimeEditor) this.dateTimeOverview_DateEntered).Value = (object) new DateTime(2011, 2, 24, 0, 0, 0, 0);
    ((AppearanceBase) appearance117).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraDateTimeEditor) this.dateTimeOverview_LossDate).Appearance = (AppearanceBase) appearance117;
    ((AppearanceBase) appearance118).AlphaLevel = (short) 14;
    ((AppearanceBase) appearance118).BackColor = Color.FromArgb(0, 0, 246, 253);
    ((AppearanceBase) appearance118).BackColor2 = Color.FromArgb(133, 162, 221);
    ((AppearanceBase) appearance118).BackColorAlpha = (Alpha) 2;
    ((AppearanceBase) appearance118).BackGradientAlignment = (GradientAlignment) 4;
    ((AppearanceBase) appearance118).BackGradientStyle = (GradientStyle) 5;
    ((AppearanceBase) appearance118).BorderAlpha = (Alpha) 1;
    ((AppearanceBase) appearance118).BorderColor = Color.FromArgb(78, 122, 171);
    ((AppearanceBase) appearance118).ForeColor = Color.FromArgb(49, 85, 153);
    ((AppearanceBase) appearance118).ForegroundAlpha = (Alpha) 2;
    ((UltraDateTimeEditor) this.dateTimeOverview_LossDate).ButtonAppearance = (AppearanceBase) appearance118;
    ((UltraDateTimeEditor) this.dateTimeOverview_LossDate).DateTime = new DateTime(2017, 12, 14, 0, 0, 0, 0);
    ((Control) this.dateTimeOverview_LossDate).Location = new Point(120, 62);
    this.dateTimeOverview_LossDate.MGAStyle = (MGAStyles) 2;
    ((Control) this.dateTimeOverview_LossDate).Name = "dateTimeOverview_LossDate";
    ((Control) this.dateTimeOverview_LossDate).Size = new Size(88, 20);
    ((Control) this.dateTimeOverview_LossDate).TabIndex = 5;
    ((UltraControlBase) this.dateTimeOverview_LossDate).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dateTimeOverview_LossDate).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDateTimeEditor) this.dateTimeOverview_LossDate).Value = (object) new DateTime(2017, 12, 14, 0, 0, 0, 0);
    ((AppearanceBase) appearance119).BackColor = Color.White;
    ((AppearanceBase) appearance119).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance119).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textOverview_EnteredBy).Appearance = (AppearanceBase) appearance119;
    ((Control) this.textOverview_EnteredBy).BackColor = Color.White;
    ((Control) this.textOverview_EnteredBy).Enabled = false;
    ((Control) this.textOverview_EnteredBy).Location = new Point(120, 109);
    this.textOverview_EnteredBy.MGAStyle = (MGAStyles) 2;
    ((Control) this.textOverview_EnteredBy).Name = "textOverview_EnteredBy";
    ((EditorButtonControlBase) this.textOverview_EnteredBy).ReadOnly = true;
    ((Control) this.textOverview_EnteredBy).Size = new Size(236, 20);
    ((Control) this.textOverview_EnteredBy).TabIndex = 9;
    ((Control) this.textOverview_EnteredBy).TabStop = false;
    ((UltraControlBase) this.textOverview_EnteredBy).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textOverview_EnteredBy).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.textOverview_EnteredBy).Enter += new EventHandler(this.OverviewTextbox_Enter);
    this.label6.AutoSize = true;
    this.label6.Location = new Point(7, 39);
    this.label6.Name = "label6";
    this.label6.Size = new Size(99, 13);
    this.label6.TabIndex = 2;
    this.label6.Text = "Catastrophe Code:";
    this.label5.AutoSize = true;
    this.label5.Location = new Point(7, 85);
    this.label5.Name = "label5";
    this.label5.Size = new Size(75, 13);
    this.label5.TabIndex = 6;
    this.label5.Text = "Date Entered:";
    this.label4.AutoSize = true;
    this.label4.Location = new Point(7, 108);
    this.label4.Name = "label4";
    this.label4.Size = new Size(64 /*0x40*/, 13);
    this.label4.TabIndex = 8;
    this.label4.Text = "Entered By:";
    this.label3.AutoSize = true;
    this.label3.Location = new Point(7, 61);
    this.label3.Name = "label3";
    this.label3.Size = new Size(58, 13);
    this.label3.TabIndex = 4;
    this.label3.Text = "Loss Date:";
    this.label2.AutoSize = true;
    this.label2.Location = new Point(7, 18);
    this.label2.Name = "label2";
    this.label2.Size = new Size(47, 13);
    this.label2.TabIndex = 0;
    this.label2.Text = "Claim #:";
    this.groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
    this.groupBox2.Controls.Add((Control) this.gridOverview_Claimants);
    this.groupBox2.ForeColor = Color.Black;
    this.groupBox2.Location = new Point(10, 442);
    this.groupBox2.Name = "groupBox2";
    this.groupBox2.Size = new Size(362, 226);
    this.groupBox2.TabIndex = 2;
    this.groupBox2.TabStop = false;
    this.groupBox2.Text = "Claimants";
    ((Control) this.gridOverview_Claimants).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((AppearanceBase) appearance120).BackColor = Color.Transparent;
    ((AppearanceBase) appearance120).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridOverview_Claimants).DisplayLayout.Appearance = (AppearanceBase) appearance120;
    ((UltraGridBase) this.gridOverview_Claimants).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((UltraGridBase) this.gridOverview_Claimants).DisplayLayout.BorderStyle = (UIElementBorderStyle) 1;
    ((AppearanceBase) appearance121).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance121).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance121).ForeColor = Color.Black;
    ((UltraGridBase) this.gridOverview_Claimants).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance121;
    ((UltraGridBase) this.gridOverview_Claimants).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridOverview_Claimants).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridOverview_Claimants).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance122).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridOverview_Claimants).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance122;
    ((UltraGridBase) this.gridOverview_Claimants).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance123).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.gridOverview_Claimants).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance123;
    ((UltraGridBase) this.gridOverview_Claimants).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance124).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridOverview_Claimants).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance124;
    ((AppearanceBase) appearance125).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridOverview_Claimants).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance125;
    ((UltraGridBase) this.gridOverview_Claimants).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance126).BackColor = Color.Transparent;
    ((AppearanceBase) appearance126).ForeColor = Color.Black;
    ((UltraGridBase) this.gridOverview_Claimants).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance126;
    ((AppearanceBase) appearance127).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance127).BorderColor = Color.Silver;
    scrollBarLook6.ButtonAppearance = (AppearanceBase) appearance127;
    ((AppearanceBase) appearance128).BackColor = Color.White;
    scrollBarLook6.TrackAppearance = (AppearanceBase) appearance128;
    ((UltraGridBase) this.gridOverview_Claimants).DisplayLayout.ScrollBarLook = scrollBarLook6;
    ((Control) this.gridOverview_Claimants).Location = new Point(7, 21);
    ((Control) this.gridOverview_Claimants).Name = "gridOverview_Claimants";
    ((Control) this.gridOverview_Claimants).Size = new Size(344, 180);
    ((Control) this.gridOverview_Claimants).TabIndex = 0;
    ((UltraControlBase) this.gridOverview_Claimants).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridOverview_Claimants).UseOsThemes = (DefaultableBoolean) 2;
    this.gridOverview_Claimants.InitializeRow += new InitializeRowEventHandler(this.gridOverview_Claimants_InitializeRow);
    this.gridOverview_Claimants.DoubleClickRow += new DoubleClickRowEventHandler(this.gridOverview_Claimants_DoubleClickRow);
    this.groupBox1.Controls.Add((Control) this.linkViewPolicy);
    this.groupBox1.Controls.Add((Control) this.textOverview_EffectiveExpiration);
    this.groupBox1.Controls.Add((Control) this.label63);
    this.groupBox1.Controls.Add((Control) this.textOverview_Line);
    this.groupBox1.Controls.Add((Control) this.label51);
    this.groupBox1.Controls.Add((Control) this.textOverview_Company);
    this.groupBox1.Controls.Add((Control) this.textOverview_Producer);
    this.groupBox1.Controls.Add((Control) this.textOverview_Insured);
    this.groupBox1.Controls.Add((Control) this.textOverview_PolicyNumber);
    this.groupBox1.Controls.Add((Control) this.textOverview_ControlNumber);
    this.groupBox1.Controls.Add((Control) this.label10);
    this.groupBox1.Controls.Add((Control) this.label9);
    this.groupBox1.Controls.Add((Control) this.label8);
    this.groupBox1.Controls.Add((Control) this.label7);
    this.groupBox1.Controls.Add((Control) this.label1);
    this.groupBox1.ForeColor = Color.Black;
    this.groupBox1.Location = new Point(10, (int) byte.MaxValue);
    this.groupBox1.Name = "groupBox1";
    this.groupBox1.Size = new Size(362, 184);
    this.groupBox1.TabIndex = 1;
    this.groupBox1.TabStop = false;
    this.groupBox1.Text = "Policy Information";
    this.linkViewPolicy.AutoSize = true;
    this.linkViewPolicy.Location = new Point(289, 25);
    this.linkViewPolicy.Name = "linkViewPolicy";
    this.linkViewPolicy.Size = new Size(67, 13);
    this.linkViewPolicy.TabIndex = 16 /*0x10*/;
    this.linkViewPolicy.TabStop = true;
    this.linkViewPolicy.Text = "(View Policy)";
    this.linkViewPolicy.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
    ((AppearanceBase) appearance129).BackColor = Color.White;
    ((AppearanceBase) appearance129).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance129).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textOverview_EffectiveExpiration).Appearance = (AppearanceBase) appearance129;
    ((Control) this.textOverview_EffectiveExpiration).BackColor = Color.White;
    ((Control) this.textOverview_EffectiveExpiration).Location = new Point(120, 159);
    this.textOverview_EffectiveExpiration.MGAStyle = (MGAStyles) 2;
    ((Control) this.textOverview_EffectiveExpiration).Name = "textOverview_EffectiveExpiration";
    ((EditorButtonControlBase) this.textOverview_EffectiveExpiration).ReadOnly = true;
    ((Control) this.textOverview_EffectiveExpiration).Size = new Size(236, 20);
    ((Control) this.textOverview_EffectiveExpiration).TabIndex = 13;
    ((Control) this.textOverview_EffectiveExpiration).TabStop = false;
    ((UltraControlBase) this.textOverview_EffectiveExpiration).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textOverview_EffectiveExpiration).UseOsThemes = (DefaultableBoolean) 2;
    this.label63.AutoSize = true;
    this.label63.Location = new Point(9, 159);
    this.label63.Name = "label63";
    this.label63.Size = new Size(106, 13);
    this.label63.TabIndex = 12;
    this.label63.Text = "Effective/Expiration:";
    ((AppearanceBase) appearance130).BackColor = Color.White;
    ((AppearanceBase) appearance130).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance130).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textOverview_Line).Appearance = (AppearanceBase) appearance130;
    ((Control) this.textOverview_Line).BackColor = Color.White;
    ((Control) this.textOverview_Line).Location = new Point(120, 138);
    this.textOverview_Line.MGAStyle = (MGAStyles) 2;
    ((Control) this.textOverview_Line).Name = "textOverview_Line";
    ((EditorButtonControlBase) this.textOverview_Line).ReadOnly = true;
    ((Control) this.textOverview_Line).Size = new Size(236, 20);
    ((Control) this.textOverview_Line).TabIndex = 11;
    ((Control) this.textOverview_Line).TabStop = false;
    ((UltraControlBase) this.textOverview_Line).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textOverview_Line).UseOsThemes = (DefaultableBoolean) 2;
    this.label51.AutoSize = true;
    this.label51.Location = new Point(9, 138);
    this.label51.Name = "label51";
    this.label51.Size = new Size(30, 13);
    this.label51.TabIndex = 10;
    this.label51.Text = "Line:";
    ((AppearanceBase) appearance131).BackColor = Color.White;
    ((AppearanceBase) appearance131).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance131).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textOverview_Company).Appearance = (AppearanceBase) appearance131;
    ((Control) this.textOverview_Company).BackColor = Color.White;
    ((Control) this.textOverview_Company).Location = new Point(120, 115);
    this.textOverview_Company.MGAStyle = (MGAStyles) 2;
    ((Control) this.textOverview_Company).Name = "textOverview_Company";
    ((EditorButtonControlBase) this.textOverview_Company).ReadOnly = true;
    ((Control) this.textOverview_Company).Size = new Size(236, 20);
    ((Control) this.textOverview_Company).TabIndex = 9;
    ((Control) this.textOverview_Company).TabStop = false;
    ((UltraControlBase) this.textOverview_Company).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textOverview_Company).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.textOverview_Company).Enter += new EventHandler(this.OverviewTextbox_Enter);
    ((Control) this.textOverview_Company).MouseEnter += new EventHandler(this.textOverview_Company_MouseEnter);
    ((AppearanceBase) appearance132).BackColor = Color.White;
    ((AppearanceBase) appearance132).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance132).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textOverview_Producer).Appearance = (AppearanceBase) appearance132;
    ((Control) this.textOverview_Producer).BackColor = Color.White;
    ((Control) this.textOverview_Producer).Location = new Point(120, 92);
    this.textOverview_Producer.MGAStyle = (MGAStyles) 2;
    ((Control) this.textOverview_Producer).Name = "textOverview_Producer";
    ((EditorButtonControlBase) this.textOverview_Producer).ReadOnly = true;
    ((Control) this.textOverview_Producer).Size = new Size(236, 20);
    ((Control) this.textOverview_Producer).TabIndex = 7;
    ((Control) this.textOverview_Producer).TabStop = false;
    ((UltraControlBase) this.textOverview_Producer).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textOverview_Producer).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.textOverview_Producer).Enter += new EventHandler(this.OverviewTextbox_Enter);
    ((Control) this.textOverview_Producer).MouseEnter += new EventHandler(this.textOverview_Producer_MouseEnter);
    ((AppearanceBase) appearance133).BackColor = Color.White;
    ((AppearanceBase) appearance133).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance133).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textOverview_Insured).Appearance = (AppearanceBase) appearance133;
    ((Control) this.textOverview_Insured).BackColor = Color.White;
    ((Control) this.textOverview_Insured).Location = new Point(120, 69);
    this.textOverview_Insured.MGAStyle = (MGAStyles) 2;
    ((Control) this.textOverview_Insured).Name = "textOverview_Insured";
    ((EditorButtonControlBase) this.textOverview_Insured).ReadOnly = true;
    ((Control) this.textOverview_Insured).Size = new Size(236, 20);
    ((Control) this.textOverview_Insured).TabIndex = 5;
    ((Control) this.textOverview_Insured).TabStop = false;
    ((UltraControlBase) this.textOverview_Insured).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textOverview_Insured).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.textOverview_Insured).Enter += new EventHandler(this.OverviewTextbox_Enter);
    ((Control) this.textOverview_Insured).MouseEnter += new EventHandler(this.textOverview_Insured_MouseEnter);
    ((AppearanceBase) appearance134).BackColor = Color.White;
    ((AppearanceBase) appearance134).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance134).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textOverview_PolicyNumber).Appearance = (AppearanceBase) appearance134;
    ((Control) this.textOverview_PolicyNumber).BackColor = Color.White;
    ((Control) this.textOverview_PolicyNumber).Location = new Point(120, 46);
    this.textOverview_PolicyNumber.MGAStyle = (MGAStyles) 2;
    ((Control) this.textOverview_PolicyNumber).Name = "textOverview_PolicyNumber";
    ((EditorButtonControlBase) this.textOverview_PolicyNumber).ReadOnly = true;
    ((Control) this.textOverview_PolicyNumber).Size = new Size(236, 20);
    ((Control) this.textOverview_PolicyNumber).TabIndex = 3;
    ((Control) this.textOverview_PolicyNumber).TabStop = false;
    ((UltraControlBase) this.textOverview_PolicyNumber).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textOverview_PolicyNumber).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.textOverview_PolicyNumber).Enter += new EventHandler(this.OverviewTextbox_Enter);
    ((AppearanceBase) appearance135).BackColor = Color.White;
    ((AppearanceBase) appearance135).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance135).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textOverview_ControlNumber).Appearance = (AppearanceBase) appearance135;
    ((Control) this.textOverview_ControlNumber).BackColor = Color.White;
    ((Control) this.textOverview_ControlNumber).Location = new Point(120, 23);
    this.textOverview_ControlNumber.MGAStyle = (MGAStyles) 2;
    ((Control) this.textOverview_ControlNumber).Name = "textOverview_ControlNumber";
    ((EditorButtonControlBase) this.textOverview_ControlNumber).ReadOnly = true;
    ((Control) this.textOverview_ControlNumber).Size = new Size(163, 20);
    ((Control) this.textOverview_ControlNumber).TabIndex = 1;
    ((Control) this.textOverview_ControlNumber).TabStop = false;
    ((UltraControlBase) this.textOverview_ControlNumber).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textOverview_ControlNumber).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.textOverview_ControlNumber).Enter += new EventHandler(this.OverviewTextbox_Enter);
    this.label10.AutoSize = true;
    this.label10.Location = new Point(9, 115);
    this.label10.Name = "label10";
    this.label10.Size = new Size(56, 13);
    this.label10.TabIndex = 8;
    this.label10.Text = "Company:";
    this.label9.AutoSize = true;
    this.label9.Location = new Point(7, 23);
    this.label9.Name = "label9";
    this.label9.Size = new Size(57, 13);
    this.label9.TabIndex = 0;
    this.label9.Text = "Control #:";
    this.label8.AutoSize = true;
    this.label8.Location = new Point(9, 69);
    this.label8.Name = "label8";
    this.label8.Size = new Size(48 /*0x30*/, 13);
    this.label8.TabIndex = 4;
    this.label8.Text = "Insured:";
    this.label7.AutoSize = true;
    this.label7.Location = new Point(9, 92);
    this.label7.Name = "label7";
    this.label7.Size = new Size(54, 13);
    this.label7.TabIndex = 6;
    this.label7.Text = "Producer:";
    this.label1.AutoSize = true;
    this.label1.Location = new Point(8, 46);
    this.label1.Name = "label1";
    this.label1.Size = new Size(49, 13);
    this.label1.TabIndex = 2;
    this.label1.Text = "Policy #:";
    ((Control) this.tabPageClaimReservePayments).Location = new Point(-10000, -10000);
    ((Control) this.tabPageClaimReservePayments).Name = "tabPageClaimReservePayments";
    ((Control) this.tabPageClaimReservePayments).Size = new Size(974, 626);
    ((Control) this.tabPageClaimLimitsLiabilities).Location = new Point(-10000, -10000);
    ((Control) this.tabPageClaimLimitsLiabilities).Name = "tabPageClaimLimitsLiabilities";
    ((Control) this.tabPageClaimLimitsLiabilities).Size = new Size(974, 626);
    ((Control) this.ultraTabPageControl2).Controls.Add((Control) this.gridUnallocatedExpenses);
    ((Control) this.ultraTabPageControl2).Location = new Point(-10000, -10000);
    ((Control) this.ultraTabPageControl2).Name = "ultraTabPageControl2";
    ((Control) this.ultraTabPageControl2).Size = new Size(974, 626);
    ((Control) this.gridUnallocatedExpenses).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.ultraToolbarsManager1.SetContextMenuUltra((Component) this.gridUnallocatedExpenses, "ULAEGridContext");
    ((UltraGridBase) this.gridUnallocatedExpenses).DataSource = (object) this.dsUnallocatedExpenses1;
    ((AppearanceBase) appearance136).BackColor = Color.White;
    ((AppearanceBase) appearance136).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridUnallocatedExpenses).DisplayLayout.Appearance = (AppearanceBase) appearance136;
    ((UltraGridBase) this.gridUnallocatedExpenses).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn33.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn33.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn33.Header).VisiblePosition = 0;
    ultraGridColumn33.Hidden = true;
    ultraGridColumn33.Width = 47;
    ultraGridColumn34.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn34.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn34.Header).VisiblePosition = 22;
    ultraGridColumn34.Hidden = true;
    ultraGridColumn34.Width = 35;
    ultraGridColumn35.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn35.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn35.Header).VisiblePosition = 21;
    ultraGridColumn36.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn36.Header).Caption = "Date";
    ((HeaderBase) ultraGridColumn36.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn36.Width = 78;
    ultraGridColumn37.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn37.Header).Caption = "Description";
    ((HeaderBase) ultraGridColumn37.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn37.Width = 231;
    ultraGridColumn38.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn38.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn38.Header).VisiblePosition = 23;
    ultraGridColumn38.Hidden = true;
    ultraGridColumn38.Width = 83;
    ultraGridColumn39.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance137).TextHAlignAsString = "Center";
    ((HeaderBase) ultraGridColumn39.Header).Appearance = (AppearanceBase) appearance137;
    ((HeaderBase) ultraGridColumn39.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn39.Width = 78;
    ultraGridColumn40.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn40.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn40.Header).VisiblePosition = 24;
    ultraGridColumn40.Hidden = true;
    ultraGridColumn40.Width = 41;
    ultraGridColumn41.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn41.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn41.Header).VisiblePosition = 25;
    ultraGridColumn41.Hidden = true;
    ultraGridColumn41.Width = 143;
    ultraGridColumn42.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn42.Header).Caption = "Entered By";
    ((HeaderBase) ultraGridColumn42.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn42.Width = 137;
    ultraGridColumn43.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance138).TextHAlignAsString = "Center";
    ((HeaderBase) ultraGridColumn43.Header).Appearance = (AppearanceBase) appearance138;
    ((HeaderBase) ultraGridColumn43.Header).Caption = "Rec. Created";
    ((HeaderBase) ultraGridColumn43.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn43.Width = 90;
    ultraGridColumn44.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn44.Header).Caption = "Rec. Date";
    ((HeaderBase) ultraGridColumn44.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn44.Width = 90;
    ultraGridColumn45.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn45.Header).Caption = "AR Created By";
    ((HeaderBase) ultraGridColumn45.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn45.Width = 186;
    ultraGridColumn46.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance139).TextHAlignAsString = "Center";
    ((HeaderBase) ultraGridColumn46.Header).Appearance = (AppearanceBase) appearance139;
    ((HeaderBase) ultraGridColumn46.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn46.Width = 90;
    ultraGridColumn47.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn47.Header).Caption = "Waived By";
    ((HeaderBase) ultraGridColumn47.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn47.Width = 114;
    ultraGridColumn48.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn48.Header).Caption = "Date Waived";
    ((HeaderBase) ultraGridColumn48.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn48.Width = 90;
    ultraGridColumn49.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn49.Width = 415;
    ultraGridColumn50.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance140).TextHAlignAsString = "Right";
    ultraGridColumn50.CellAppearance = (AppearanceBase) appearance140;
    ((AppearanceBase) appearance141).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn50.Header).Appearance = (AppearanceBase) appearance141;
    ((HeaderBase) ultraGridColumn50.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn50.Width = 60;
    ultraGridColumn51.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance142).TextHAlignAsString = "Right";
    ultraGridColumn51.CellAppearance = (AppearanceBase) appearance142;
    ultraGridColumn51.Format = "c";
    ((HeaderBase) ultraGridColumn51.Header).Caption = "Hourly Rate";
    ((HeaderBase) ultraGridColumn51.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn51.Width = 88;
    ultraGridColumn52.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance143).TextHAlignAsString = "Right";
    ultraGridColumn52.CellAppearance = (AppearanceBase) appearance143;
    ultraGridColumn52.Format = "c";
    ((AppearanceBase) appearance144).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn52.Header).Appearance = (AppearanceBase) appearance144;
    ((HeaderBase) ultraGridColumn52.Header).Caption = "Hourly Total";
    ((HeaderBase) ultraGridColumn52.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn52.Width = 88;
    ultraGridColumn53.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance145).TextHAlignAsString = "Right";
    ultraGridColumn53.CellAppearance = (AppearanceBase) appearance145;
    ((AppearanceBase) appearance146).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn53.Header).Appearance = (AppearanceBase) appearance146;
    ((HeaderBase) ultraGridColumn53.Header).Caption = "Equip. Rate";
    ((HeaderBase) ultraGridColumn53.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn53.Width = 88;
    ultraGridColumn54.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance147).TextHAlignAsString = "Right";
    ultraGridColumn54.CellAppearance = (AppearanceBase) appearance147;
    ultraGridColumn54.Format = "c";
    ((AppearanceBase) appearance148).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn54.Header).Appearance = (AppearanceBase) appearance148;
    ((HeaderBase) ultraGridColumn54.Header).Caption = "Equip. Total";
    ((HeaderBase) ultraGridColumn54.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn54.Width = 92;
    ultraGridColumn55.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance149).TextHAlignAsString = "Right";
    ultraGridColumn55.CellAppearance = (AppearanceBase) appearance149;
    ((AppearanceBase) appearance150).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn55.Header).Appearance = (AppearanceBase) appearance150;
    ((HeaderBase) ultraGridColumn55.Header).Caption = "Other Rate";
    ((HeaderBase) ultraGridColumn55.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn55.Width = 88;
    ultraGridColumn56.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance151).TextHAlignAsString = "Right";
    ultraGridColumn56.CellAppearance = (AppearanceBase) appearance151;
    ((AppearanceBase) appearance152).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn56.Header).Appearance = (AppearanceBase) appearance152;
    ((HeaderBase) ultraGridColumn56.Header).Caption = "Other Amt.";
    ((HeaderBase) ultraGridColumn56.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn56.Width = 88;
    ultraGridColumn57.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance153).TextHAlignAsString = "Right";
    ultraGridColumn57.CellAppearance = (AppearanceBase) appearance153;
    ultraGridColumn57.Format = "c";
    ((AppearanceBase) appearance154).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn57.Header).Appearance = (AppearanceBase) appearance154;
    ((HeaderBase) ultraGridColumn57.Header).Caption = "Other Total";
    ((HeaderBase) ultraGridColumn57.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn57.Width = 88;
    ultraGridColumn58.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance155).TextHAlignAsString = "Right";
    ultraGridColumn58.CellAppearance = (AppearanceBase) appearance155;
    ultraGridColumn58.Format = "c";
    ((AppearanceBase) appearance156).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn58.Header).Appearance = (AppearanceBase) appearance156;
    ((HeaderBase) ultraGridColumn58.Header).Caption = "Total";
    ((HeaderBase) ultraGridColumn58.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn58.Width = 145;
    ultraGridBand6.Columns.AddRange(new object[26]
    {
      (object) ultraGridColumn33,
      (object) ultraGridColumn34,
      (object) ultraGridColumn35,
      (object) ultraGridColumn36,
      (object) ultraGridColumn37,
      (object) ultraGridColumn38,
      (object) ultraGridColumn39,
      (object) ultraGridColumn40,
      (object) ultraGridColumn41,
      (object) ultraGridColumn42,
      (object) ultraGridColumn43,
      (object) ultraGridColumn44,
      (object) ultraGridColumn45,
      (object) ultraGridColumn46,
      (object) ultraGridColumn47,
      (object) ultraGridColumn48,
      (object) ultraGridColumn49,
      (object) ultraGridColumn50,
      (object) ultraGridColumn51,
      (object) ultraGridColumn52,
      (object) ultraGridColumn53,
      (object) ultraGridColumn54,
      (object) ultraGridColumn55,
      (object) ultraGridColumn56,
      (object) ultraGridColumn57,
      (object) ultraGridColumn58
    });
    ultraGridBand6.GroupHeadersVisible = false;
    ((KeyedSubObjectBase) ultraGridGroup1).Key = "NewGroup0";
    ultraGridBand6.Groups.AddRange(new UltraGridGroup[1]
    {
      ultraGridGroup1
    });
    ultraGridBand6.LevelCount = 2;
    ultraGridBand6.Override.RowSpacingAfter = 1;
    ((AppearanceBase) appearance157).BackColor = Color.LightSteelBlue;
    ultraGridBand6.Override.SummaryFooterAppearance = (AppearanceBase) appearance157;
    ultraGridBand6.Override.SummaryFooterCaptionVisible = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance158).BackColor = Color.LightSteelBlue;
    ultraGridBand6.Override.SummaryValueAppearance = (AppearanceBase) appearance158;
    ultraGridBand6.Override.TipStyleCell = (TipStyle) 2;
    ((AppearanceBase) appearance159).TextHAlignAsString = "Right";
    summarySettings1.Appearance = (AppearanceBase) appearance159;
    summarySettings1.DisplayFormat = "{0:c}";
    ((AppearanceBase) appearance160).TextHAlignAsString = "Right";
    summarySettings2.Appearance = (AppearanceBase) appearance160;
    summarySettings2.DisplayFormat = "{0:c}";
    ((AppearanceBase) appearance161).TextHAlignAsString = "Right";
    summarySettings3.Appearance = (AppearanceBase) appearance161;
    summarySettings3.DisplayFormat = "{0:c}";
    ((AppearanceBase) appearance162).TextHAlignAsString = "Right";
    summarySettings4.Appearance = (AppearanceBase) appearance162;
    summarySettings4.DisplayFormat = "{0:c}";
    ((AppearanceBase) appearance163).TextHAlignAsString = "Right";
    summarySettings5.Appearance = (AppearanceBase) appearance163;
    summarySettings5.DisplayFormat = "{0:}";
    ultraGridBand6.Summaries.AddRange(new SummarySettings[5]
    {
      summarySettings1,
      summarySettings2,
      summarySettings3,
      summarySettings4,
      summarySettings5
    });
    ultraGridBand6.SummaryFooterCaption = "";
    ((UltraGridBase) this.gridUnallocatedExpenses).DisplayLayout.BandsSerializer.Add((object) ultraGridBand6);
    ((UltraGridBase) this.gridUnallocatedExpenses).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance164).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance164).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance164).ForeColor = Color.Black;
    ((UltraGridBase) this.gridUnallocatedExpenses).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance164;
    ((UltraGridBase) this.gridUnallocatedExpenses).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridUnallocatedExpenses).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridUnallocatedExpenses).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance165).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridUnallocatedExpenses).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance165;
    ((UltraGridBase) this.gridUnallocatedExpenses).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance166).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((AppearanceBase) appearance166).TextHAlignAsString = "Left";
    ((UltraGridBase) this.gridUnallocatedExpenses).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance166;
    ((UltraGridBase) this.gridUnallocatedExpenses).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.gridUnallocatedExpenses).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance167).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridUnallocatedExpenses).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance167;
    ((AppearanceBase) appearance168).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridUnallocatedExpenses).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance168;
    ((UltraGridBase) this.gridUnallocatedExpenses).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance169).BackColor = Color.Transparent;
    ((AppearanceBase) appearance169).ForeColor = Color.Black;
    ((UltraGridBase) this.gridUnallocatedExpenses).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance169;
    ((UltraGridBase) this.gridUnallocatedExpenses).DisplayLayout.Override.TipStyleCell = (TipStyle) 2;
    ((AppearanceBase) appearance170).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance170).BorderColor = Color.Silver;
    scrollBarLook7.ButtonAppearance = (AppearanceBase) appearance170;
    ((AppearanceBase) appearance171).BackColor = Color.White;
    scrollBarLook7.TrackAppearance = (AppearanceBase) appearance171;
    ((UltraGridBase) this.gridUnallocatedExpenses).DisplayLayout.ScrollBarLook = scrollBarLook7;
    ((AppearanceBase) appearance172).BackColor = Color.White;
    ((AppearanceBase) appearance172).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ultraGridLayout2.Appearance = (AppearanceBase) appearance172;
    ultraGridLayout2.AutoFitStyle = (AutoFitStyle) 1;
    ((HeaderBase) ultraGridColumn59.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn59.Header).VisiblePosition = 0;
    ultraGridColumn59.Hidden = true;
    ultraGridColumn59.Width = 47;
    ((HeaderBase) ultraGridColumn60.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn60.Header).VisiblePosition = 2;
    ultraGridColumn60.Hidden = true;
    ultraGridColumn60.Width = 35;
    ((HeaderBase) ultraGridColumn61.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn61.Header).VisiblePosition = 1;
    ((HeaderBase) ultraGridColumn62.Header).Caption = "Date";
    ((HeaderBase) ultraGridColumn62.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn62.Width = 78;
    ((HeaderBase) ultraGridColumn63.Header).Caption = "Description";
    ((HeaderBase) ultraGridColumn63.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn63.Width = 231;
    ((HeaderBase) ultraGridColumn64.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn64.Header).VisiblePosition = 5;
    ultraGridColumn64.Hidden = true;
    ultraGridColumn64.Width = 83;
    ((AppearanceBase) appearance173).TextHAlignAsString = "Center";
    ((HeaderBase) ultraGridColumn65.Header).Appearance = (AppearanceBase) appearance173;
    ((HeaderBase) ultraGridColumn65.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn65.Width = 78;
    ((HeaderBase) ultraGridColumn66.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn66.Header).VisiblePosition = 7;
    ultraGridColumn66.Hidden = true;
    ultraGridColumn66.Width = 41;
    ((HeaderBase) ultraGridColumn67.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn67.Header).VisiblePosition = 8;
    ultraGridColumn67.Hidden = true;
    ultraGridColumn67.Width = 143;
    ((HeaderBase) ultraGridColumn68.Header).Caption = "Entered By";
    ((HeaderBase) ultraGridColumn68.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn68.Width = 137;
    ((AppearanceBase) appearance174).TextHAlignAsString = "Center";
    ((HeaderBase) ultraGridColumn69.Header).Appearance = (AppearanceBase) appearance174;
    ((HeaderBase) ultraGridColumn69.Header).Caption = "Rec. Created";
    ((HeaderBase) ultraGridColumn69.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn69.Width = 91;
    ((HeaderBase) ultraGridColumn70.Header).Caption = "Rec. Date";
    ((HeaderBase) ultraGridColumn70.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn70.Width = 91;
    ((HeaderBase) ultraGridColumn71.Header).Caption = "AR Created By";
    ((HeaderBase) ultraGridColumn71.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn71.Width = 186;
    ((AppearanceBase) appearance175).TextHAlignAsString = "Center";
    ((HeaderBase) ultraGridColumn72.Header).Appearance = (AppearanceBase) appearance175;
    ((HeaderBase) ultraGridColumn72.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn72.Width = 91;
    ((HeaderBase) ultraGridColumn73.Header).Caption = "Waived By";
    ((HeaderBase) ultraGridColumn73.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn73.Width = 109;
    ((HeaderBase) ultraGridColumn74.Header).Caption = "Date Waived";
    ((HeaderBase) ultraGridColumn74.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn74.Width = 91;
    ultraGridColumn75.Width = 416;
    ((AppearanceBase) appearance176).TextHAlignAsString = "Right";
    ultraGridColumn76.CellAppearance = (AppearanceBase) appearance176;
    ((AppearanceBase) appearance177).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn76.Header).Appearance = (AppearanceBase) appearance177;
    ((HeaderBase) ultraGridColumn76.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn76.Width = 60;
    ((AppearanceBase) appearance178).TextHAlignAsString = "Right";
    ultraGridColumn77.CellAppearance = (AppearanceBase) appearance178;
    ultraGridColumn77.Format = "c";
    ((HeaderBase) ultraGridColumn77.Header).Caption = "Hourly Rate";
    ((HeaderBase) ultraGridColumn77.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn77.Width = 88;
    ((AppearanceBase) appearance179).TextHAlignAsString = "Right";
    ultraGridColumn78.CellAppearance = (AppearanceBase) appearance179;
    ultraGridColumn78.Format = "c";
    ((AppearanceBase) appearance180).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn78.Header).Appearance = (AppearanceBase) appearance180;
    ((HeaderBase) ultraGridColumn78.Header).Caption = "Hourly Total";
    ((HeaderBase) ultraGridColumn78.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn78.Width = 88;
    ((AppearanceBase) appearance181).TextHAlignAsString = "Right";
    ultraGridColumn79.CellAppearance = (AppearanceBase) appearance181;
    ((AppearanceBase) appearance182).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn79.Header).Appearance = (AppearanceBase) appearance182;
    ((HeaderBase) ultraGridColumn79.Header).Caption = "Equip. Rate";
    ((HeaderBase) ultraGridColumn79.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn79.Width = 88;
    ((AppearanceBase) appearance183).TextHAlignAsString = "Right";
    ultraGridColumn80.CellAppearance = (AppearanceBase) appearance183;
    ultraGridColumn80.Format = "c";
    ((AppearanceBase) appearance184).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn80.Header).Appearance = (AppearanceBase) appearance184;
    ((HeaderBase) ultraGridColumn80.Header).Caption = "Equip. Total";
    ((HeaderBase) ultraGridColumn80.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn80.Width = 92;
    ((AppearanceBase) appearance185).TextHAlignAsString = "Right";
    ultraGridColumn81.CellAppearance = (AppearanceBase) appearance185;
    ((AppearanceBase) appearance186).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn81.Header).Appearance = (AppearanceBase) appearance186;
    ((HeaderBase) ultraGridColumn81.Header).Caption = "Other Rate";
    ((HeaderBase) ultraGridColumn81.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn81.Width = 88;
    ((AppearanceBase) appearance187).TextHAlignAsString = "Right";
    ultraGridColumn82.CellAppearance = (AppearanceBase) appearance187;
    ((AppearanceBase) appearance188).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn82.Header).Appearance = (AppearanceBase) appearance188;
    ((HeaderBase) ultraGridColumn82.Header).Caption = "Other Amt.";
    ((HeaderBase) ultraGridColumn82.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn82.Width = 88;
    ((AppearanceBase) appearance189).TextHAlignAsString = "Right";
    ultraGridColumn83.CellAppearance = (AppearanceBase) appearance189;
    ultraGridColumn83.Format = "c";
    ((AppearanceBase) appearance190).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn83.Header).Appearance = (AppearanceBase) appearance190;
    ((HeaderBase) ultraGridColumn83.Header).Caption = "Other Total";
    ((HeaderBase) ultraGridColumn83.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn83.Width = 88;
    ((AppearanceBase) appearance191).TextHAlignAsString = "Right";
    ultraGridColumn84.CellAppearance = (AppearanceBase) appearance191;
    ultraGridColumn84.Format = "c";
    ((AppearanceBase) appearance192).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn84.Header).Appearance = (AppearanceBase) appearance192;
    ((HeaderBase) ultraGridColumn84.Header).Caption = "Total";
    ((HeaderBase) ultraGridColumn84.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn84.Width = 145;
    ultraGridBand7.Columns.AddRange(new object[26]
    {
      (object) ultraGridColumn59,
      (object) ultraGridColumn60,
      (object) ultraGridColumn61,
      (object) ultraGridColumn62,
      (object) ultraGridColumn63,
      (object) ultraGridColumn64,
      (object) ultraGridColumn65,
      (object) ultraGridColumn66,
      (object) ultraGridColumn67,
      (object) ultraGridColumn68,
      (object) ultraGridColumn69,
      (object) ultraGridColumn70,
      (object) ultraGridColumn71,
      (object) ultraGridColumn72,
      (object) ultraGridColumn73,
      (object) ultraGridColumn74,
      (object) ultraGridColumn75,
      (object) ultraGridColumn76,
      (object) ultraGridColumn77,
      (object) ultraGridColumn78,
      (object) ultraGridColumn79,
      (object) ultraGridColumn80,
      (object) ultraGridColumn81,
      (object) ultraGridColumn82,
      (object) ultraGridColumn83,
      (object) ultraGridColumn84
    });
    ultraGridBand7.GroupHeadersVisible = false;
    ((KeyedSubObjectBase) ultraGridGroup2).Key = "NewGroup0";
    ultraGridBand7.Groups.AddRange(new UltraGridGroup[1]
    {
      ultraGridGroup2
    });
    ultraGridBand7.LevelCount = 2;
    ultraGridBand7.Override.RowSpacingAfter = 1;
    ultraGridLayout2.BandsSerializer.Add((object) ultraGridBand7);
    ultraGridLayout2.BorderStyle = (UIElementBorderStyle) 4;
    ((KeyedSubObjectBase) ultraGridLayout2).Key = "Layout1";
    ((AppearanceBase) appearance193).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance193).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance193).ForeColor = Color.Black;
    ultraGridLayout2.Override.ActiveRowAppearance = (AppearanceBase) appearance193;
    ultraGridLayout2.Override.AllowColSizing = (AllowColSizing) 3;
    ultraGridLayout2.Override.AllowDelete = (DefaultableBoolean) 2;
    ultraGridLayout2.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance194).BorderColor = Color.LightGray;
    ultraGridLayout2.Override.CellAppearance = (AppearanceBase) appearance194;
    ultraGridLayout2.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance195).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((AppearanceBase) appearance195).TextHAlignAsString = "Left";
    ultraGridLayout2.Override.HeaderAppearance = (AppearanceBase) appearance195;
    ultraGridLayout2.Override.HeaderClickAction = (HeaderClickAction) 2;
    ultraGridLayout2.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance196).BackColor = Color.FromArgb(246, 250, 253);
    ultraGridLayout2.Override.RowAlternateAppearance = (AppearanceBase) appearance196;
    ((AppearanceBase) appearance197).BorderColor = Color.LightGray;
    ultraGridLayout2.Override.RowAppearance = (AppearanceBase) appearance197;
    ultraGridLayout2.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance198).BackColor = Color.Transparent;
    ((AppearanceBase) appearance198).ForeColor = Color.Black;
    ultraGridLayout2.Override.SelectedRowAppearance = (AppearanceBase) appearance198;
    ((AppearanceBase) appearance199).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance199).BorderColor = Color.Silver;
    scrollBarLook8.ButtonAppearance = (AppearanceBase) appearance199;
    ((AppearanceBase) appearance200).BackColor = Color.White;
    scrollBarLook8.TrackAppearance = (AppearanceBase) appearance200;
    ultraGridLayout2.ScrollBarLook = scrollBarLook8;
    ((UltraGridBase) this.gridUnallocatedExpenses).Layouts.Add(ultraGridLayout2);
    ((Control) this.gridUnallocatedExpenses).Location = new Point(3, 3);
    ((Control) this.gridUnallocatedExpenses).Name = "gridUnallocatedExpenses";
    ((Control) this.gridUnallocatedExpenses).Size = new Size(1214, 727);
    ((Control) this.gridUnallocatedExpenses).TabIndex = 0;
    ultraToolTipInfo2.Enabled = (DefaultableBoolean) 2;
    this.ultraToolTipManager1.SetUltraToolTip((Control) this.gridUnallocatedExpenses, ultraToolTipInfo2);
    ((UltraControlBase) this.gridUnallocatedExpenses).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridUnallocatedExpenses).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraControlBase) this.gridUnallocatedExpenses).MouseEnterElement += new UIElementEventHandler(this.gridUnallocatedExpenses_MouseEnterElement);
    ((UltraControlBase) this.gridUnallocatedExpenses).MouseLeaveElement += new UIElementEventHandler(this.gridUnallocatedExpenses_MouseLeaveElement);
    this.dsUnallocatedExpenses1.DataSetName = "dsUnallocatedExpenses";
    this.dsUnallocatedExpenses1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((Control) this.ultraTabPageControl3).Controls.Add((Control) this.textAccidentDescription);
    ((Control) this.ultraTabPageControl3).Controls.Add((Control) this.label57);
    ((Control) this.ultraTabPageControl3).Controls.Add((Control) this.groupBox5);
    ((Control) this.ultraTabPageControl3).Location = new Point(-10000, -10000);
    ((Control) this.ultraTabPageControl3).Name = "ultraTabPageControl3";
    ((Control) this.ultraTabPageControl3).Size = new Size(974, 626);
    ((AppearanceBase) appearance201).BackColor = Color.White;
    ((AppearanceBase) appearance201).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance201).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textAccidentDescription).Appearance = (AppearanceBase) appearance201;
    ((Control) this.textAccidentDescription).AutoSize = false;
    ((Control) this.textAccidentDescription).BackColor = Color.White;
    ((Control) this.textAccidentDescription).Location = new Point(12, 447);
    this.textAccidentDescription.MGAStyle = (MGAStyles) 2;
    ((UltraTextEditor) this.textAccidentDescription).Multiline = true;
    ((Control) this.textAccidentDescription).Name = "textAccidentDescription";
    ((Control) this.textAccidentDescription).Size = new Size(951, 176 /*0xB0*/);
    ((Control) this.textAccidentDescription).TabIndex = 1;
    ((UltraControlBase) this.textAccidentDescription).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textAccidentDescription).UseOsThemes = (DefaultableBoolean) 2;
    this.label57.AutoSize = true;
    this.label57.Location = new Point(11, 431);
    this.label57.Name = "label57";
    this.label57.Size = new Size(108, 13);
    this.label57.TabIndex = 2;
    this.label57.Text = "Accident Description:";
    this.groupBox5.Controls.Add((Control) this.label65);
    this.groupBox5.Controls.Add((Control) this.textLongCoords);
    this.groupBox5.Controls.Add((Control) this.label64);
    this.groupBox5.Controls.Add((Control) this.textLatCoord);
    this.groupBox5.Controls.Add((Control) this.maskAccidentTime);
    this.groupBox5.Controls.Add((Control) this.comboAccidentType);
    this.groupBox5.Controls.Add((Control) this.label60);
    this.groupBox5.Controls.Add((Control) this.label59);
    this.groupBox5.Controls.Add((Control) this.label58);
    this.groupBox5.Controls.Add((Control) this.buttonMapLocation);
    this.groupBox5.Controls.Add((Control) this.mapBing);
    this.groupBox5.Controls.Add((Control) this.addressResolverAccidentLocation);
    this.groupBox5.ForeColor = Color.Black;
    this.groupBox5.Location = new Point(11, 15);
    this.groupBox5.Name = "groupBox5";
    this.groupBox5.Size = new Size(952, 407);
    this.groupBox5.TabIndex = 0;
    this.groupBox5.TabStop = false;
    this.groupBox5.Text = "Accident Location";
    this.label65.AutoSize = true;
    this.label65.Location = new Point(13, 195);
    this.label65.Name = "label65";
    this.label65.Size = new Size(95, 13);
    this.label65.TabIndex = 36;
    this.label65.Text = "Long Coordinates:";
    ((AppearanceBase) appearance202).BackColor = Color.White;
    ((AppearanceBase) appearance202).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance202).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textLongCoords).Appearance = (AppearanceBase) appearance202;
    ((Control) this.textLongCoords).BackColor = Color.White;
    ((Control) this.textLongCoords).Location = new Point(122, 195);
    this.textLongCoords.MGAStyle = (MGAStyles) 2;
    ((Control) this.textLongCoords).Name = "textLongCoords";
    ((Control) this.textLongCoords).Size = new Size(168, 20);
    ((Control) this.textLongCoords).TabIndex = 35;
    ((UltraControlBase) this.textLongCoords).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textLongCoords).UseOsThemes = (DefaultableBoolean) 2;
    this.label64.AutoSize = true;
    this.label64.Location = new Point(13, 172);
    this.label64.Name = "label64";
    this.label64.Size = new Size(87, 13);
    this.label64.TabIndex = 34;
    this.label64.Text = "Lat Coordinates:";
    ((AppearanceBase) appearance203).BackColor = Color.White;
    ((AppearanceBase) appearance203).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance203).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textLatCoord).Appearance = (AppearanceBase) appearance203;
    ((Control) this.textLatCoord).BackColor = Color.White;
    ((Control) this.textLatCoord).Location = new Point(122, 172);
    this.textLatCoord.MGAStyle = (MGAStyles) 2;
    ((Control) this.textLatCoord).Name = "textLatCoord";
    ((Control) this.textLatCoord).Size = new Size(168, 20);
    ((Control) this.textLatCoord).TabIndex = 33;
    ((UltraControlBase) this.textLatCoord).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textLatCoord).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance204).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraMaskedEdit) this.maskAccidentTime).Appearance = (AppearanceBase) appearance204;
    ((UltraMaskedEdit) this.maskAccidentTime).DataMode = (MaskMode) 0;
    ((UltraMaskedEdit) this.maskAccidentTime).EditAs = (EditAsType) 8;
    ((Control) this.maskAccidentTime).Location = new Point(19, 275);
    this.maskAccidentTime.MGAStyle = (MGAStyles) 2;
    ((Control) this.maskAccidentTime).Name = "maskAccidentTime";
    ((UltraMaskedEdit) this.maskAccidentTime).NonAutoSizeHeight = 20;
    ((Control) this.maskAccidentTime).Size = new Size(55, 21);
    ((Control) this.maskAccidentTime).TabIndex = 32 /*0x20*/;
    ((UltraControlBase) this.maskAccidentTime).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.maskAccidentTime).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraCombo) this.comboAccidentType).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraCombo) this.comboAccidentType).DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.comboAccidentType).DropDownWidth = 300;
    ((Control) this.comboAccidentType).Location = new Point(16 /*0x10*/, 317);
    this.comboAccidentType.MGAStyle = (MGAStyles) 2;
    ((Control) this.comboAccidentType).Name = "comboAccidentType";
    ((Control) this.comboAccidentType).Size = new Size(280, 21);
    ((Control) this.comboAccidentType).TabIndex = 31 /*0x1F*/;
    ((UltraControlBase) this.comboAccidentType).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboAccidentType).UseOsThemes = (DefaultableBoolean) 2;
    this.label60.AutoSize = true;
    this.label60.Location = new Point(16 /*0x10*/, 301);
    this.label60.Name = "label60";
    this.label60.Size = new Size(79, 13);
    this.label60.TabIndex = 30;
    this.label60.Text = "Accident Type:";
    this.label59.AutoSize = true;
    this.label59.Location = new Point(16 /*0x10*/, 259);
    this.label59.Name = "label59";
    this.label59.Size = new Size(77, 13);
    this.label59.TabIndex = 28;
    this.label59.Text = "Accident Time:";
    this.label58.BackColor = Color.SteelBlue;
    this.label58.Location = new Point(16 /*0x10*/, 249);
    this.label58.Name = "label58";
    this.label58.Size = new Size(274, 1);
    this.label58.TabIndex = 27;
    ((AppearanceBase) appearance205).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance205).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance205).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance205).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance205).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance205).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonMapLocation).Appearance = (AppearanceBase) appearance205;
    ((Control) this.buttonMapLocation).Location = new Point(180, 220);
    ((Control) this.buttonMapLocation).Name = "buttonMapLocation";
    ((Control) this.buttonMapLocation).Size = new Size(110, 26);
    ((Control) this.buttonMapLocation).TabIndex = 26;
    ((Control) this.buttonMapLocation).Text = "Map Location";
    ((UltraControlBase) this.buttonMapLocation).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonMapLocation).Click += new EventHandler(this.buttonMapLocation_Click);
    this.mapBing.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.mapBing.Location = new Point(565, 25);
    this.mapBing.Margin = new Padding(4);
    this.mapBing.MaximumSize = new Size(375, 375);
    this.mapBing.MinimumSize = new Size(375, 375);
    this.mapBing.Name = "mapBing";
    this.mapBing.Size = new Size(375, 375);
    this.mapBing.TabIndex = 25;
    this.mapBing.Visible = false;
    this.addressResolverAccidentLocation.Address1 = "";
    this.addressResolverAccidentLocation.Address2 = "";
    ((Control) this.addressResolverAccidentLocation).BackColor = Color.Transparent;
    this.addressResolverAccidentLocation.City = "";
    this.addressResolverAccidentLocation.County = "";
    ((Control) this.addressResolverAccidentLocation).Font = new Font("Tahoma", 8f);
    ((Control) this.addressResolverAccidentLocation).ForeColor = Color.Black;
    this.addressResolverAccidentLocation.ISOCountryCode = "";
    this.addressResolverAccidentLocation.ISOCountryCodeMember = "";
    this.addressResolverAccidentLocation.ISOCountryList = (object) null;
    this.addressResolverAccidentLocation.ISOCountryNameMember = "";
    ((Control) this.addressResolverAccidentLocation).Location = new Point(6, 20);
    this.addressResolverAccidentLocation.MGAStyle = (MGAStyles) 2;
    ((Control) this.addressResolverAccidentLocation).Name = "addressResolverAccidentLocation";
    this.addressResolverAccidentLocation.Password = (string) null;
    ((Control) this.addressResolverAccidentLocation).Size = new Size(293, 152);
    this.addressResolverAccidentLocation.State = "";
    ((Control) this.addressResolverAccidentLocation).TabIndex = 24;
    this.addressResolverAccidentLocation.TextAlign = ContentAlignment.TopLeft;
    this.addressResolverAccidentLocation.UserID = (string) null;
    this.addressResolverAccidentLocation.WebserviceUrl = (string) null;
    this.addressResolverAccidentLocation.ZipCode = "";
    this.addressResolverAccidentLocation.ZipCodeExtension = "";
    ((Control) this.ultraTabPageControl4).Controls.Add((Control) this.gridClaimStatusLog);
    ((Control) this.ultraTabPageControl4).Location = new Point(-10000, -10000);
    ((Control) this.ultraTabPageControl4).Name = "ultraTabPageControl4";
    ((Control) this.ultraTabPageControl4).Size = new Size(974, 626);
    ((Control) this.gridClaimStatusLog).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((AppearanceBase) appearance206).BackColor = Color.White;
    ((AppearanceBase) appearance206).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridClaimStatusLog).DisplayLayout.Appearance = (AppearanceBase) appearance206;
    ((UltraGridBase) this.gridClaimStatusLog).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((UltraGridBase) this.gridClaimStatusLog).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance207).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance207).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance207).ForeColor = Color.Black;
    ((UltraGridBase) this.gridClaimStatusLog).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance207;
    ((UltraGridBase) this.gridClaimStatusLog).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridClaimStatusLog).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridClaimStatusLog).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance208).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridClaimStatusLog).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance208;
    ((UltraGridBase) this.gridClaimStatusLog).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance209).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.gridClaimStatusLog).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance209;
    ((UltraGridBase) this.gridClaimStatusLog).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance210).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridClaimStatusLog).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance210;
    ((AppearanceBase) appearance211).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridClaimStatusLog).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance211;
    ((UltraGridBase) this.gridClaimStatusLog).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance212).BackColor = Color.Transparent;
    ((AppearanceBase) appearance212).ForeColor = Color.Black;
    ((UltraGridBase) this.gridClaimStatusLog).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance212;
    ((AppearanceBase) appearance213).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance213).BorderColor = Color.Silver;
    scrollBarLook9.ButtonAppearance = (AppearanceBase) appearance213;
    ((AppearanceBase) appearance214).BackColor = Color.White;
    scrollBarLook9.TrackAppearance = (AppearanceBase) appearance214;
    ((UltraGridBase) this.gridClaimStatusLog).DisplayLayout.ScrollBarLook = scrollBarLook9;
    ((Control) this.gridClaimStatusLog).Location = new Point(11, 13);
    ((Control) this.gridClaimStatusLog).Name = "gridClaimStatusLog";
    ((Control) this.gridClaimStatusLog).Size = new Size(952, 606);
    ((Control) this.gridClaimStatusLog).TabIndex = 0;
    ((UltraControlBase) this.gridClaimStatusLog).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridClaimStatusLog).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.ultraTabPageControl5).Controls.Add((Control) this.groupBox7);
    ((Control) this.ultraTabPageControl5).Location = new Point(-10000, -10000);
    ((Control) this.ultraTabPageControl5).Name = "ultraTabPageControl5";
    ((Control) this.ultraTabPageControl5).Size = new Size(974, 626);
    this.groupBox7.Controls.Add((Control) this.radioParkedVehicle);
    this.groupBox7.Controls.Add((Control) this.textDriverLastName);
    this.groupBox7.Controls.Add((Control) this.label61);
    this.groupBox7.Controls.Add((Control) this.textDriverFirstName);
    this.groupBox7.Controls.Add((Control) this.label62);
    this.groupBox7.Controls.Add((Control) this.radioNonListedDriver);
    this.groupBox7.Controls.Add((Control) this.radioListedDriver);
    this.groupBox7.Controls.Add((Control) this.gridDrivers);
    this.groupBox7.Location = new Point(11, 9);
    this.groupBox7.Name = "groupBox7";
    this.groupBox7.Size = new Size(457, 476);
    this.groupBox7.TabIndex = 2;
    this.groupBox7.TabStop = false;
    this.groupBox7.Text = "Driver Information";
    this.radioParkedVehicle.AutoSize = true;
    this.radioParkedVehicle.Location = new Point(13, 355);
    this.radioParkedVehicle.Name = "radioParkedVehicle";
    this.radioParkedVehicle.Size = new Size(94, 17);
    this.radioParkedVehicle.TabIndex = 7;
    this.radioParkedVehicle.Text = "Parked Vehicle";
    this.radioParkedVehicle.UseVisualStyleBackColor = true;
    ((AppearanceBase) appearance215).BackColor = Color.White;
    ((AppearanceBase) appearance215).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance215).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textDriverLastName).Appearance = (AppearanceBase) appearance215;
    ((Control) this.textDriverLastName).BackColor = Color.White;
    ((Control) this.textDriverLastName).Enabled = false;
    ((Control) this.textDriverLastName).Location = new Point(13, 321);
    ((TextEditorControlBase) this.textDriverLastName).MaxLength = 150;
    this.textDriverLastName.MGAStyle = (MGAStyles) 2;
    ((Control) this.textDriverLastName).Name = "textDriverLastName";
    ((Control) this.textDriverLastName).Size = new Size(312, 20);
    ((Control) this.textDriverLastName).TabIndex = 6;
    ((UltraControlBase) this.textDriverLastName).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textDriverLastName).UseOsThemes = (DefaultableBoolean) 2;
    this.label61.AutoSize = true;
    this.label61.Location = new Point(10, 305);
    this.label61.Name = "label61";
    this.label61.Size = new Size(61, 13);
    this.label61.TabIndex = 5;
    this.label61.Text = "Last Name:";
    ((AppearanceBase) appearance216).BackColor = Color.White;
    ((AppearanceBase) appearance216).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance216).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textDriverFirstName).Appearance = (AppearanceBase) appearance216;
    ((Control) this.textDriverFirstName).BackColor = Color.White;
    ((Control) this.textDriverFirstName).Enabled = false;
    ((Control) this.textDriverFirstName).Location = new Point(13, 283);
    ((TextEditorControlBase) this.textDriverFirstName).MaxLength = 150;
    this.textDriverFirstName.MGAStyle = (MGAStyles) 2;
    ((Control) this.textDriverFirstName).Name = "textDriverFirstName";
    ((Control) this.textDriverFirstName).Size = new Size(312, 20);
    ((Control) this.textDriverFirstName).TabIndex = 4;
    ((UltraControlBase) this.textDriverFirstName).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textDriverFirstName).UseOsThemes = (DefaultableBoolean) 2;
    this.label62.AutoSize = true;
    this.label62.Location = new Point(10, 267);
    this.label62.Name = "label62";
    this.label62.Size = new Size(62, 13);
    this.label62.TabIndex = 3;
    this.label62.Text = "First Name:";
    this.radioNonListedDriver.AutoSize = true;
    this.radioNonListedDriver.Location = new Point(10, 243);
    this.radioNonListedDriver.Name = "radioNonListedDriver";
    this.radioNonListedDriver.Size = new Size(120, 17);
    this.radioNonListedDriver.TabIndex = 2;
    this.radioNonListedDriver.Text = "Not Listed On Policy";
    this.radioNonListedDriver.UseVisualStyleBackColor = true;
    this.radioListedDriver.AutoSize = true;
    this.radioListedDriver.Checked = true;
    this.radioListedDriver.Location = new Point(10, 25);
    this.radioListedDriver.Name = "radioListedDriver";
    this.radioListedDriver.Size = new Size(100, 17);
    this.radioListedDriver.TabIndex = 1;
    this.radioListedDriver.TabStop = true;
    this.radioListedDriver.Text = "Listed On Policy";
    this.radioListedDriver.UseVisualStyleBackColor = true;
    ((AppearanceBase) appearance217).BackColor = Color.White;
    ((AppearanceBase) appearance217).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridDrivers).DisplayLayout.Appearance = (AppearanceBase) appearance217;
    ((UltraGridBase) this.gridDrivers).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((UltraGridBase) this.gridDrivers).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance218).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance218).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance218).ForeColor = Color.Black;
    ((UltraGridBase) this.gridDrivers).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance218;
    ((UltraGridBase) this.gridDrivers).DisplayLayout.Override.AllowAddNew = (AllowAddNew) 2;
    ((UltraGridBase) this.gridDrivers).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridDrivers).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridDrivers).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 1;
    ((AppearanceBase) appearance219).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridDrivers).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance219;
    ((UltraGridBase) this.gridDrivers).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance220).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.gridDrivers).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance220;
    ((UltraGridBase) this.gridDrivers).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance221).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridDrivers).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance221;
    ((AppearanceBase) appearance222).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridDrivers).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance222;
    ((UltraGridBase) this.gridDrivers).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance223).BackColor = Color.Transparent;
    ((AppearanceBase) appearance223).ForeColor = Color.Black;
    ((UltraGridBase) this.gridDrivers).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance223;
    ((AppearanceBase) appearance224).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance224).BorderColor = Color.Silver;
    scrollBarLook10.ButtonAppearance = (AppearanceBase) appearance224;
    ((AppearanceBase) appearance225).BackColor = Color.White;
    scrollBarLook10.TrackAppearance = (AppearanceBase) appearance225;
    ((UltraGridBase) this.gridDrivers).DisplayLayout.ScrollBarLook = scrollBarLook10;
    ((Control) this.gridDrivers).Location = new Point(10, 48 /*0x30*/);
    ((Control) this.gridDrivers).Name = "gridDrivers";
    ((Control) this.gridDrivers).Size = new Size(441, 189);
    ((Control) this.gridDrivers).TabIndex = 0;
    this.gridDrivers.UpdateMode = (UpdateMode) 2;
    ((UltraControlBase) this.gridDrivers).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridDrivers).UseOsThemes = (DefaultableBoolean) 2;
    this.gridDrivers.CellChange += new CellEventHandler(this.gridDrivers_CellChange);
    this.gridDrivers.BeforeCellUpdate += new BeforeCellUpdateEventHandler(this.gridDrivers_BeforeCellUpdate);
    this.gridDrivers.ClickCell += new ClickCellEventHandler(this.gridDrivers_ClickCell);
    ((Control) this.gridDrivers).Click += new EventHandler(this.gridDrivers_Click);
    ((Control) this.buttonClearClaimant).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    ((AppearanceBase) appearance226).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance226).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance226).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance226).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance226).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance226).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonClearClaimant).Appearance = (AppearanceBase) appearance226;
    ((Control) this.buttonClearClaimant).Location = new Point(795, 521);
    ((Control) this.buttonClearClaimant).Name = "buttonClearClaimant";
    ((Control) this.buttonClearClaimant).Size = new Size(90, 24);
    ((Control) this.buttonClearClaimant).TabIndex = 26;
    ((Control) this.buttonClearClaimant).Text = "Clear Claimant";
    ((UltraControlBase) this.buttonClearClaimant).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonClearClaimant).Visible = false;
    ((Control) this.buttonAddClaimant).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    ((AppearanceBase) appearance227).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance227).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance227).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance227).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance227).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance227).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonAddClaimant).Appearance = (AppearanceBase) appearance227;
    ((Control) this.buttonAddClaimant).Location = new Point(700, 521);
    ((Control) this.buttonAddClaimant).Name = "buttonAddClaimant";
    ((Control) this.buttonAddClaimant).Size = new Size(89, 24);
    ((Control) this.buttonAddClaimant).TabIndex = 25;
    ((Control) this.buttonAddClaimant).Text = "Save Claimant";
    ((UltraControlBase) this.buttonAddClaimant).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonAddClaimant).Visible = false;
    ((AppearanceBase) appearance228).FontData.BoldAsString = "False";
    ((AppearanceBase) appearance228).FontData.SizeInPoints = 10f;
    ((ControlBase) this.labelCurrentClaimant).Appearance = (AppearanceBase) appearance228;
    ((Control) this.labelCurrentClaimant).Location = new Point(139, 3);
    ((Control) this.labelCurrentClaimant).Name = "labelCurrentClaimant";
    ((Control) this.labelCurrentClaimant).Size = new Size(467, 18);
    ((Control) this.labelCurrentClaimant).TabIndex = 1;
    ((Control) this.labelCurrentClaimant).Text = "None";
    ((AppearanceBase) appearance229).FontData.BoldAsString = "True";
    ((AppearanceBase) appearance229).FontData.SizeInPoints = 10f;
    ((ControlBase) this.labelCurrentClaimantLabel).Appearance = (AppearanceBase) appearance229;
    ((Control) this.labelCurrentClaimantLabel).AutoSize = true;
    ((Control) this.labelCurrentClaimantLabel).Location = new Point(10, 3);
    ((Control) this.labelCurrentClaimantLabel).Name = "labelCurrentClaimantLabel";
    ((Control) this.labelCurrentClaimantLabel).Size = new Size(155, 21);
    ((Control) this.labelCurrentClaimantLabel).TabIndex = 0;
    ((Control) this.labelCurrentClaimantLabel).Text = "Showing Claimant:";
    this.dsClaimActivity1.DataSetName = "dsClaimActivity";
    this.dsClaimActivity1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((Control) this.tabPageClaimantContainer).Controls.Add((Control) this.tabControlClaimants);
    ((Control) this.tabPageClaimantContainer).Location = new Point(-10000, -10000);
    ((Control) this.tabPageClaimantContainer).Name = "tabPageClaimantContainer";
    ((Control) this.tabPageClaimantContainer).Size = new Size(963, 623);
    ((Control) this.tabControlClaimants).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((Control) this.tabControlClaimants).Controls.Add((Control) this.ultraTabSharedControlsPage2);
    ((Control) this.tabControlClaimants).Controls.Add((Control) this.tabPageClaimant);
    ((Control) this.tabControlClaimants).Controls.Add((Control) this.tabPageLegal);
    ((Control) this.tabControlClaimants).Controls.Add((Control) this.tabPageClaimSpecifications);
    ((Control) this.tabControlClaimants).Controls.Add((Control) this.tabPageClaimantReservesPayments);
    ((Control) this.tabControlClaimants).Location = new Point(7, 11);
    ((Control) this.tabControlClaimants).Name = "tabControlClaimants";
    ((UltraTabControlBase) this.tabControlClaimants).SharedControls.AddRange(new Control[4]
    {
      (Control) this.buttonClearClaimant,
      (Control) this.buttonAddClaimant,
      (Control) this.labelCurrentClaimant,
      (Control) this.labelCurrentClaimantLabel
    });
    ((UltraTabControlBase) this.tabControlClaimants).SharedControlsPage = this.ultraTabSharedControlsPage2;
    ((Control) this.tabControlClaimants).Size = new Size(953, 581);
    ((Control) this.tabControlClaimants).TabIndex = 0;
    ((UltraTabControlBase) this.tabControlClaimants).TabOrientation = (TabOrientation) 3;
    ultraTab1.TabPage = this.tabPageClaimant;
    ultraTab1.Text = "Claimant Information";
    ultraTab2.TabPage = this.tabPageClaimSpecifications;
    ultraTab2.Text = "Claim Specifications";
    ultraTab3.TabPage = this.tabPageLegal;
    ultraTab3.Text = "Legal / Attorney";
    ((KeyedSubObjectBase) ultraTab4).Key = "ReservesPayments";
    ultraTab4.TabPage = this.tabPageClaimantReservesPayments;
    ultraTab4.Text = "Reserves/Payments";
    ((UltraTabControlBase) this.tabControlClaimants).Tabs.AddRange(new UltraTab[4]
    {
      ultraTab1,
      ultraTab2,
      ultraTab3,
      ultraTab4
    });
    ((UltraTabControlBase) this.tabControlClaimants).ViewStyle = (ViewStyle) 4;
    ((Control) this.ultraTabSharedControlsPage2).Controls.Add((Control) this.buttonClearClaimant);
    ((Control) this.ultraTabSharedControlsPage2).Controls.Add((Control) this.buttonAddClaimant);
    ((Control) this.ultraTabSharedControlsPage2).Controls.Add((Control) this.labelCurrentClaimant);
    ((Control) this.ultraTabSharedControlsPage2).Controls.Add((Control) this.labelCurrentClaimantLabel);
    ((Control) this.ultraTabSharedControlsPage2).Location = new Point(-10000, -10000);
    ((Control) this.ultraTabSharedControlsPage2).Name = "ultraTabSharedControlsPage2";
    ((Control) this.ultraTabSharedControlsPage2).Size = new Size(951, 558);
    ((Control) this.ultraTabPageControl1).Location = new Point(-10000, -10000);
    ((Control) this.ultraTabPageControl1).Name = "ultraTabPageControl1";
    ((Control) this.ultraTabPageControl1).Size = new Size(951, 561);
    ((AppearanceBase) appearance230).BackColor = Color.Transparent;
    ((UltraTabControlBase) this.tabControlClaim).Appearance = (AppearanceBase) appearance230;
    ((AppearanceBase) appearance231).BackColor = Color.Transparent;
    ((AppearanceBase) appearance231).BackColor2 = Color.Transparent;
    ((UltraTabControlBase) this.tabControlClaim).ClientAreaAppearance = (AppearanceBase) appearance231;
    ((Control) this.tabControlClaim).Controls.Add((Control) this.ultraTabSharedControlsPage1);
    ((Control) this.tabControlClaim).Controls.Add((Control) this.tabPageClaimOverview);
    ((Control) this.tabControlClaim).Controls.Add((Control) this.tabPageClaimLimitsLiabilities);
    ((Control) this.tabControlClaim).Controls.Add((Control) this.tabPageClaimReservePayments);
    ((Control) this.tabControlClaim).Controls.Add((Control) this.ultraTabPageControl2);
    ((Control) this.tabControlClaim).Controls.Add((Control) this.ultraTabPageControl3);
    ((Control) this.tabControlClaim).Controls.Add((Control) this.ultraTabPageControl4);
    ((Control) this.tabControlClaim).Controls.Add((Control) this.ultraTabPageControl5);
    ((Control) this.tabControlClaim).Dock = DockStyle.Fill;
    ((Control) this.tabControlClaim).Location = new Point(0, 46);
    ((Control) this.tabControlClaim).Name = "tabControlClaim";
    ((AppearanceBase) appearance232).FontData.BoldAsString = "True";
    ((UltraTabControlBase) this.tabControlClaim).SelectedTabAppearance = (AppearanceBase) appearance232;
    ((UltraTabControlBase) this.tabControlClaim).SharedControlsPage = this.ultraTabSharedControlsPage1;
    ((Control) this.tabControlClaim).Size = new Size(976, 649);
    ((UltraTabControlBase) this.tabControlClaim).SpaceBeforeTabs = new DefaultableInteger(0);
    ((UltraTabControlBase) this.tabControlClaim).Style = (UltraTabControlStyle) 13;
    ((UltraTabControlBase) this.tabControlClaim).TabButtonStyle = (UIElementButtonStyle) 18;
    ((Control) this.tabControlClaim).TabIndex = 0;
    ((AppearanceBase) appearance233).BackColor = Color.Transparent;
    ((AppearanceBase) appearance233).Image = (object) Resources.ClaimOverview;
    ultraTab5.Appearance = (AppearanceBase) appearance233;
    ((KeyedSubObjectBase) ultraTab5).Key = "ClaimOverview";
    ultraTab5.TabPage = this.tabPageClaimOverview;
    ultraTab5.Text = "Claim Overview";
    ((KeyedSubObjectBase) ultraTab6).Key = "ReservePayments";
    ultraTab6.TabPage = this.tabPageClaimReservePayments;
    ultraTab6.Text = "Reserves / Payments";
    ultraTab6.Visible = false;
    ((AppearanceBase) appearance234).Image = (object) Resources.LimitsLiabilities;
    ultraTab7.Appearance = (AppearanceBase) appearance234;
    ((KeyedSubObjectBase) ultraTab7).Key = "LimitsLiabilities";
    ultraTab7.TabPage = this.tabPageClaimLimitsLiabilities;
    ultraTab7.Text = "Liability and Limits";
    ultraTab7.Visible = false;
    ((AppearanceBase) appearance235).Image = (object) Resources.Coins;
    ultraTab8.Appearance = (AppearanceBase) appearance235;
    ((KeyedSubObjectBase) ultraTab8).Key = "TransULAE";
    ultraTab8.TabPage = this.ultraTabPageControl2;
    ultraTab8.Text = "Transactions / ULAE";
    ((AppearanceBase) appearance236).Image = (object) Resources.AccidentTypeSmall;
    ultraTab9.Appearance = (AppearanceBase) appearance236;
    ((KeyedSubObjectBase) ultraTab9).Key = "AccidentInfo";
    ultraTab9.TabPage = this.ultraTabPageControl3;
    ultraTab9.Text = "Additional Claim/Accident Information";
    ((AppearanceBase) appearance237).Image = (object) Resources.ClaimStatus;
    ultraTab10.Appearance = (AppearanceBase) appearance237;
    ((KeyedSubObjectBase) ultraTab10).Key = "StatusLog";
    ultraTab10.TabPage = this.ultraTabPageControl4;
    ultraTab10.Text = "Claim Status Log";
    ((AppearanceBase) appearance238).Image = (object) Resources.car;
    ultraTab11.Appearance = (AppearanceBase) appearance238;
    ((KeyedSubObjectBase) ultraTab11).Key = "tabDriverInfo";
    ultraTab11.TabPage = this.ultraTabPageControl5;
    ultraTab11.Text = "Driver Information";
    ((UltraTabControlBase) this.tabControlClaim).Tabs.AddRange(new UltraTab[7]
    {
      ultraTab5,
      ultraTab6,
      ultraTab7,
      ultraTab8,
      ultraTab9,
      ultraTab10,
      ultraTab11
    });
    ((UltraTabControlBase) this.tabControlClaim).ViewStyle = (ViewStyle) 4;
    ((Control) this.ultraTabSharedControlsPage1).Location = new Point(-10000, -10000);
    ((Control) this.ultraTabSharedControlsPage1).Name = "ultraTabSharedControlsPage1";
    ((Control) this.ultraTabSharedControlsPage1).Size = new Size(974, 626);
    this.ultraToolTipManager1.AutoPopDelay = 50000;
    this.ultraToolTipManager1.ContainingControl = (Control) this;
    this.label30.AutoSize = true;
    this.label30.ForeColor = Color.Black;
    this.label30.Location = new Point(18, 213);
    this.label30.Name = "label30";
    this.label30.Size = new Size(87, 13);
    this.label30.TabIndex = 42;
    this.label30.Text = "Outside Adjuster:";
    ((UltraCombo) this.mgaSimpleComboBox3).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraCombo) this.mgaSimpleComboBox3).DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.mgaSimpleComboBox3).Location = new Point(137, 213);
    this.mgaSimpleComboBox3.MGAStyle = (MGAStyles) 2;
    ((Control) this.mgaSimpleComboBox3).Name = "mgaSimpleComboBox3";
    ((Control) this.mgaSimpleComboBox3).Size = new Size(181, 20);
    ((Control) this.mgaSimpleComboBox3).TabIndex = 41;
    ((UltraControlBase) this.mgaSimpleComboBox3).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.mgaSimpleComboBox3).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance239).BackColor = Color.White;
    ((AppearanceBase) appearance239).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance239).ForeColor = Color.Black;
    ((TextEditorControlBase) this.mgaTextBox2).Appearance = (AppearanceBase) appearance239;
    ((Control) this.mgaTextBox2).BackColor = Color.White;
    ((Control) this.mgaTextBox2).Enabled = false;
    ((Control) this.mgaTextBox2).Location = new Point(564, 21);
    this.mgaTextBox2.MGAStyle = (MGAStyles) 2;
    ((Control) this.mgaTextBox2).Name = "mgaTextBox2";
    ((Control) this.mgaTextBox2).Size = new Size(185, 19);
    ((Control) this.mgaTextBox2).TabIndex = 40;
    ((UltraControlBase) this.mgaTextBox2).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.mgaTextBox2).UseOsThemes = (DefaultableBoolean) 2;
    this.label31.AutoSize = true;
    this.label31.ForeColor = Color.Black;
    this.label31.Location = new Point(468, 21);
    this.label31.Name = "label31";
    this.label31.Size = new Size(62, 13);
    this.label31.TabIndex = 39;
    this.label31.Text = "Entered By:";
    ((AppearanceBase) appearance240).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraDateTimeEditor) this.mgaDateTimePicker2).Appearance = (AppearanceBase) appearance240;
    ((AppearanceBase) appearance241).AlphaLevel = (short) 14;
    ((AppearanceBase) appearance241).BackColor = Color.FromArgb(0, 0, 246, 253);
    ((AppearanceBase) appearance241).BackColor2 = Color.FromArgb(133, 162, 221);
    ((AppearanceBase) appearance241).BackColorAlpha = (Alpha) 2;
    ((AppearanceBase) appearance241).BackGradientAlignment = (GradientAlignment) 4;
    ((AppearanceBase) appearance241).BackGradientStyle = (GradientStyle) 5;
    ((AppearanceBase) appearance241).BorderAlpha = (Alpha) 1;
    ((AppearanceBase) appearance241).BorderColor = Color.FromArgb(78, 122, 171);
    ((AppearanceBase) appearance241).ForeColor = Color.FromArgb(49, 85, 153);
    ((AppearanceBase) appearance241).ForegroundAlpha = (Alpha) 2;
    ((UltraDateTimeEditor) this.mgaDateTimePicker2).ButtonAppearance = (AppearanceBase) appearance241;
    ((UltraDateTimeEditor) this.mgaDateTimePicker2).DateTime = new DateTime(2007, 10, 3, 0, 0, 0, 0);
    ((Control) this.mgaDateTimePicker2).Enabled = false;
    ((Control) this.mgaDateTimePicker2).Location = new Point(564, 44);
    this.mgaDateTimePicker2.MGAStyle = (MGAStyles) 2;
    ((Control) this.mgaDateTimePicker2).Name = "mgaDateTimePicker2";
    ((Control) this.mgaDateTimePicker2).Size = new Size(92, 19);
    ((Control) this.mgaDateTimePicker2).TabIndex = 38;
    ((UltraControlBase) this.mgaDateTimePicker2).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.mgaDateTimePicker2).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDateTimeEditor) this.mgaDateTimePicker2).Value = (object) new DateTime(2007, 10, 3, 0, 0, 0, 0);
    this.label32.AutoSize = true;
    this.label32.ForeColor = Color.Black;
    this.label32.Location = new Point(468, 44);
    this.label32.Name = "label32";
    this.label32.Size = new Size(73, 13);
    this.label32.TabIndex = 37;
    this.label32.Text = "Date Entered:";
    this.label33.AutoSize = true;
    this.label33.ForeColor = Color.Black;
    this.label33.Location = new Point(18, 186);
    this.label33.Name = "label33";
    this.label33.Size = new Size(115, 13);
    this.label33.TabIndex = 33;
    this.label33.Text = "Managed Care Facility:";
    ((UltraCombo) this.mgaSimpleComboBox4).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraCombo) this.mgaSimpleComboBox4).DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.mgaSimpleComboBox4).Location = new Point(137, 186);
    this.mgaSimpleComboBox4.MGAStyle = (MGAStyles) 2;
    ((Control) this.mgaSimpleComboBox4).Name = "mgaSimpleComboBox4";
    ((Control) this.mgaSimpleComboBox4).Size = new Size(181, 20);
    ((Control) this.mgaSimpleComboBox4).TabIndex = 32 /*0x20*/;
    ((UltraControlBase) this.mgaSimpleComboBox4).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.mgaSimpleComboBox4).UseOsThemes = (DefaultableBoolean) 2;
    this.label34.AutoSize = true;
    this.label34.ForeColor = Color.Black;
    this.label34.Location = new Point(18, 163);
    this.label34.Name = "label34";
    this.label34.Size = new Size(59, 13);
    this.label34.TabIndex = 31 /*0x1F*/;
    this.label34.Text = "Loss Type:";
    ((UltraCombo) this.mgaSimpleComboBox5).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraCombo) this.mgaSimpleComboBox5).DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.mgaSimpleComboBox5).Location = new Point(137, 163);
    this.mgaSimpleComboBox5.MGAStyle = (MGAStyles) 2;
    ((Control) this.mgaSimpleComboBox5).Name = "mgaSimpleComboBox5";
    ((Control) this.mgaSimpleComboBox5).Size = new Size(181, 20);
    ((Control) this.mgaSimpleComboBox5).TabIndex = 30;
    ((UltraControlBase) this.mgaSimpleComboBox5).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.mgaSimpleComboBox5).UseOsThemes = (DefaultableBoolean) 2;
    this.label35.AutoSize = true;
    this.label35.ForeColor = Color.Black;
    this.label35.Location = new Point(18, 140);
    this.label35.Name = "label35";
    this.label35.Size = new Size(79, 13);
    this.label35.TabIndex = 29;
    this.label35.Text = "Accident Type:";
    ((UltraCombo) this.mgaSimpleComboBox6).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraCombo) this.mgaSimpleComboBox6).DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.mgaSimpleComboBox6).Location = new Point(137, 140);
    this.mgaSimpleComboBox6.MGAStyle = (MGAStyles) 2;
    ((Control) this.mgaSimpleComboBox6).Name = "mgaSimpleComboBox6";
    ((Control) this.mgaSimpleComboBox6).Size = new Size(181, 20);
    ((Control) this.mgaSimpleComboBox6).TabIndex = 28;
    ((UltraControlBase) this.mgaSimpleComboBox6).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.mgaSimpleComboBox6).UseOsThemes = (DefaultableBoolean) 2;
    this.label36.AutoSize = true;
    this.label36.ForeColor = Color.Black;
    this.label36.Location = new Point(18, 21);
    this.label36.Name = "label36";
    this.label36.Size = new Size(104, 13);
    this.label36.TabIndex = 27;
    this.label36.Text = "Affected Coverages:";
    ((Control) this.mgaCheckedListBox1).BackColor = Color.White;
    ((ListControl) this.mgaCheckedListBox1).FormattingEnabled = true;
    ((Control) this.mgaCheckedListBox1).Location = new Point(137, 21);
    this.mgaCheckedListBox1.MGAStyle = (MGAStyles) 2;
    ((Control) this.mgaCheckedListBox1).Name = "mgaCheckedListBox1";
    ((Control) this.mgaCheckedListBox1).Size = new Size(260, 109);
    ((Control) this.mgaCheckedListBox1).TabIndex = 26;
    ((AppearanceBase) appearance242).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraDateTimeEditor) this.mgaDateTimePicker4).Appearance = (AppearanceBase) appearance242;
    ((AppearanceBase) appearance243).AlphaLevel = (short) 14;
    ((AppearanceBase) appearance243).BackColor = Color.FromArgb(0, 0, 246, 253);
    ((AppearanceBase) appearance243).BackColor2 = Color.FromArgb(133, 162, 221);
    ((AppearanceBase) appearance243).BackColorAlpha = (Alpha) 2;
    ((AppearanceBase) appearance243).BackGradientAlignment = (GradientAlignment) 4;
    ((AppearanceBase) appearance243).BackGradientStyle = (GradientStyle) 5;
    ((AppearanceBase) appearance243).BorderAlpha = (Alpha) 1;
    ((AppearanceBase) appearance243).BorderColor = Color.FromArgb(78, 122, 171);
    ((AppearanceBase) appearance243).ForeColor = Color.FromArgb(49, 85, 153);
    ((AppearanceBase) appearance243).ForegroundAlpha = (Alpha) 2;
    ((UltraDateTimeEditor) this.mgaDateTimePicker4).ButtonAppearance = (AppearanceBase) appearance243;
    ((UltraDateTimeEditor) this.mgaDateTimePicker4).DateTime = new DateTime(2007, 10, 3, 0, 0, 0, 0);
    ((Control) this.mgaDateTimePicker4).Location = new Point(564, 66);
    this.mgaDateTimePicker4.MGAStyle = (MGAStyles) 2;
    ((Control) this.mgaDateTimePicker4).Name = "mgaDateTimePicker4";
    ((Control) this.mgaDateTimePicker4).Size = new Size(92, 19);
    ((Control) this.mgaDateTimePicker4).TabIndex = 25;
    ((UltraControlBase) this.mgaDateTimePicker4).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.mgaDateTimePicker4).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDateTimeEditor) this.mgaDateTimePicker4).Value = (object) new DateTime(2007, 10, 3, 0, 0, 0, 0);
    this.label37.AutoSize = true;
    this.label37.ForeColor = Color.Black;
    this.label37.Location = new Point(468, 66);
    this.label37.Name = "label37";
    this.label37.Size = new Size(80 /*0x50*/, 13);
    this.label37.TabIndex = 24;
    this.label37.Text = "Date Reported:";
    this.dsClaimOptions1.DataSetName = "dsClaimOptions";
    this.dsClaimOptions1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((Control) this._formClaims_Toolbars_Dock_Area_Left).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._formClaims_Toolbars_Dock_Area_Left).BackColor = SystemColors.Control;
    this._formClaims_Toolbars_Dock_Area_Left.DockedPosition = (DockedPosition) 2;
    ((Control) this._formClaims_Toolbars_Dock_Area_Left).ForeColor = SystemColors.ControlText;
    ((Control) this._formClaims_Toolbars_Dock_Area_Left).Location = new Point(0, 46);
    ((Control) this._formClaims_Toolbars_Dock_Area_Left).Name = "_formClaims_Toolbars_Dock_Area_Left";
    ((Control) this._formClaims_Toolbars_Dock_Area_Left).Size = new Size(0, 649);
    this._formClaims_Toolbars_Dock_Area_Left.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._formClaims_Toolbars_Dock_Area_Right).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._formClaims_Toolbars_Dock_Area_Right).BackColor = SystemColors.Control;
    this._formClaims_Toolbars_Dock_Area_Right.DockedPosition = (DockedPosition) 3;
    ((Control) this._formClaims_Toolbars_Dock_Area_Right).ForeColor = SystemColors.ControlText;
    ((Control) this._formClaims_Toolbars_Dock_Area_Right).Location = new Point(976, 46);
    ((Control) this._formClaims_Toolbars_Dock_Area_Right).Name = "_formClaims_Toolbars_Dock_Area_Right";
    ((Control) this._formClaims_Toolbars_Dock_Area_Right).Size = new Size(0, 649);
    this._formClaims_Toolbars_Dock_Area_Right.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._formClaims_Toolbars_Dock_Area_Top).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._formClaims_Toolbars_Dock_Area_Top).BackColor = SystemColors.Control;
    this._formClaims_Toolbars_Dock_Area_Top.DockedPosition = (DockedPosition) 0;
    ((Control) this._formClaims_Toolbars_Dock_Area_Top).ForeColor = SystemColors.ControlText;
    ((Control) this._formClaims_Toolbars_Dock_Area_Top).Location = new Point(0, 0);
    ((Control) this._formClaims_Toolbars_Dock_Area_Top).Name = "_formClaims_Toolbars_Dock_Area_Top";
    ((Control) this._formClaims_Toolbars_Dock_Area_Top).Size = new Size(976, 46);
    this._formClaims_Toolbars_Dock_Area_Top.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._formClaims_Toolbars_Dock_Area_Bottom).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._formClaims_Toolbars_Dock_Area_Bottom).BackColor = SystemColors.Control;
    this._formClaims_Toolbars_Dock_Area_Bottom.DockedPosition = (DockedPosition) 1;
    ((Control) this._formClaims_Toolbars_Dock_Area_Bottom).ForeColor = SystemColors.ControlText;
    ((Control) this._formClaims_Toolbars_Dock_Area_Bottom).Location = new Point(0, 695);
    ((Control) this._formClaims_Toolbars_Dock_Area_Bottom).Name = "_formClaims_Toolbars_Dock_Area_Bottom";
    ((Control) this._formClaims_Toolbars_Dock_Area_Bottom).Size = new Size(976, 0);
    this._formClaims_Toolbars_Dock_Area_Bottom.ToolbarsManager = this.ultraToolbarsManager1;
    this.ultraToolbarsManager1.DesignerFlags = 1;
    this.ultraToolbarsManager1.DockWithinContainer = (Control) this;
    this.ultraToolbarsManager1.DockWithinContainerBaseType = typeof (Form);
    this.ultraToolbarsManager1.MdiMergeable = false;
    ((AppearanceBase) appearance244).Image = (object) Resources.Edit;
    ((SettingsBase) this.ultraToolbarsManager1.Ribbon.QuickAccessToolbar.Settings).Appearance = (AppearanceBase) appearance244;
    this.ultraToolbarsManager1.ShowFullMenusDelay = 500;
    ultraToolbar.DockedColumn = 0;
    ultraToolbar.DockedRow = 0;
    ultraToolbar.FloatingLocation = new Point(362, 144 /*0x90*/);
    ultraToolbar.FloatingSize = new Size(615, 45);
    ((ToolBase) buttonTool2).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) buttonTool5).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) buttonTool6).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) buttonTool7).InstanceProps.IsFirstInGroup = true;
    ((UltraToolbarBase) ultraToolbar).NonInheritedTools.AddRange(new ToolBase[7]
    {
      (ToolBase) buttonTool1,
      (ToolBase) buttonTool2,
      (ToolBase) buttonTool3,
      (ToolBase) buttonTool4,
      (ToolBase) buttonTool5,
      (ToolBase) buttonTool6,
      (ToolBase) buttonTool7
    });
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
    ((AppearanceBase) appearance245).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    ((AppearanceBase) appearance245).BackColor2 = Color.White;
    ((AppearanceBase) appearance245).BackGradientAlignment = (GradientAlignment) 1;
    ((AppearanceBase) appearance245).BackGradientStyle = (GradientStyle) 14;
    ((SettingsBase) this.ultraToolbarsManager1.ToolbarSettings).Appearance = (AppearanceBase) appearance245;
    this.ultraToolbarsManager1.ToolbarSettings.FillEntireRow = (DefaultableBoolean) 1;
    this.ultraToolbarsManager1.ToolbarSettings.GrabHandleStyle = (GrabHandleStyle) 1;
    ((SettingsBase) this.ultraToolbarsManager1.ToolbarSettings).ToolDisplayStyle = (ToolDisplayStyle) 4;
    ((AppearanceBase) appearance246).Image = (object) Resources.AddClaimantSmall;
    ((ToolPropsBase) ((ToolBase) buttonTool8).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance246;
    ((ToolPropsBase) ((ToolBase) buttonTool8).SharedPropsInternal).Caption = "Add Claimant";
    ((ToolBase) buttonTool8).SharedPropsInternal.Category = "Claimants";
    ((ToolPropsBase) ((ToolBase) buttonTool8).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((ToolBase) buttonTool8).SharedPropsInternal.Shortcut = Shortcut.ShiftF2;
    ((ToolBase) buttonTool8).SharedPropsInternal.ToolTipText = "Click here to add a new claimant.";
    ((ToolBase) buttonTool8).SharedPropsInternal.ToolTipTitle = "Add Claimant (Shift+F2)";
    ((AppearanceBase) appearance247).Image = (object) Resources.DeleteClaimSmall;
    ((ToolPropsBase) ((ToolBase) buttonTool9).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance247;
    ((ToolPropsBase) ((ToolBase) buttonTool9).SharedPropsInternal).Caption = "Delete Claimant";
    ((ToolBase) buttonTool9).SharedPropsInternal.Category = "Claimants";
    ((ToolPropsBase) ((ToolBase) buttonTool9).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((ToolBase) buttonTool9).SharedPropsInternal.Enabled = false;
    ((ToolBase) buttonTool9).SharedPropsInternal.Shortcut = Shortcut.ShiftF3;
    ((ToolBase) buttonTool9).SharedPropsInternal.ToolTipText = "Click here to delete a claimant.";
    ((ToolBase) buttonTool9).SharedPropsInternal.ToolTipTitle = "Delete Claimant (Shift+F3)";
    ((ToolBase) buttonTool9).SharedPropsInternal.Visible = false;
    ((AppearanceBase) appearance248).Image = (object) Resources.AddReserve;
    ((ToolPropsBase) ((ToolBase) buttonTool10).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance248;
    ((ToolPropsBase) ((ToolBase) buttonTool10).SharedPropsInternal).Caption = "Add Reserve";
    ((ToolBase) buttonTool10).SharedPropsInternal.Category = "Reservers/Payments";
    ((ToolPropsBase) ((ToolBase) buttonTool10).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((ToolBase) buttonTool10).SharedPropsInternal.Shortcut = Shortcut.ShiftF5;
    ((ToolBase) buttonTool10).SharedPropsInternal.ToolTipText = "Click here to add a new reserve.";
    ((ToolBase) buttonTool10).SharedPropsInternal.ToolTipTitle = "Add Reserve (Shift+F5)";
    ((AppearanceBase) appearance249).Image = (object) Resources.PaymentsReserveSmall;
    ((ToolPropsBase) ((ToolBase) buttonTool11).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance249;
    ((ToolPropsBase) ((ToolBase) buttonTool11).SharedPropsInternal).Caption = "Add Payment";
    ((ToolBase) buttonTool11).SharedPropsInternal.Category = "Reservers/Payments";
    ((ToolPropsBase) ((ToolBase) buttonTool11).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((ToolBase) buttonTool11).SharedPropsInternal.Enabled = false;
    ((ToolBase) buttonTool11).SharedPropsInternal.Shortcut = Shortcut.ShiftF6;
    ((ToolBase) buttonTool11).SharedPropsInternal.ToolTipText = "Click here to add a new payment.";
    ((ToolBase) buttonTool11).SharedPropsInternal.ToolTipTitle = "Add Payment (Shift+F6)";
    ((AppearanceBase) appearance250).Image = (object) Resources.ViewReservesPayments;
    ((ToolPropsBase) ((ToolBase) buttonTool12).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance250;
    ((ToolPropsBase) ((ToolBase) buttonTool12).SharedPropsInternal).Caption = "View Reserves/Payments";
    ((ToolBase) buttonTool12).SharedPropsInternal.Category = "Reservers/Payments";
    ((ToolPropsBase) ((ToolBase) buttonTool12).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((ToolBase) buttonTool12).SharedPropsInternal.Shortcut = Shortcut.ShiftF4;
    ((ToolBase) buttonTool12).SharedPropsInternal.ToolTipText = "Click here to view the reserves and payments on the current claim.";
    ((ToolBase) buttonTool12).SharedPropsInternal.ToolTipTitle = "View Reserves/Payments (Shift+F4)";
    ((AppearanceBase) appearance251).Image = (object) Resources.Coins;
    ((ToolPropsBase) ((ToolBase) buttonTool13).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance251;
    ((ToolPropsBase) ((ToolBase) buttonTool13).SharedPropsInternal).Caption = "Transactions";
    ((ToolBase) buttonTool13).SharedPropsInternal.Category = "TPA Expenses";
    ((ToolPropsBase) ((ToolBase) buttonTool13).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((ToolBase) buttonTool13).SharedPropsInternal.Shortcut = Shortcut.ShiftF7;
    ((ToolBase) buttonTool13).SharedPropsInternal.ToolTipText = "Click here to add a new TPA expense.";
    ((ToolBase) buttonTool13).SharedPropsInternal.ToolTipTitle = "Add TPA Expense (Shift+F7)";
    ((AppearanceBase) appearance252).Image = (object) Resources.Save;
    ((ToolPropsBase) ((ToolBase) buttonTool14).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance252;
    ((ToolPropsBase) ((ToolBase) buttonTool14).SharedPropsInternal).Caption = "Save";
    ((ToolBase) buttonTool14).SharedPropsInternal.Category = "GeneralOptions";
    ((ToolPropsBase) ((ToolBase) buttonTool14).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((ToolBase) buttonTool14).SharedPropsInternal.Shortcut = Shortcut.ShiftF1;
    ((ToolBase) buttonTool14).SharedPropsInternal.ToolTipText = "Click here to save the changes you have made to the current claim.";
    ((ToolBase) buttonTool14).SharedPropsInternal.ToolTipTitle = "Save Claim Changes (Shift+F1)";
    ((AppearanceBase) appearance253).Image = (object) Resources.CloseClaim;
    ((ToolPropsBase) ((ToolBase) buttonTool15).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance253;
    ((ToolPropsBase) ((ToolBase) buttonTool15).SharedPropsInternal).Caption = "Close Claim";
    ((ToolBase) buttonTool15).SharedPropsInternal.Category = "GeneralOptions";
    ((ToolPropsBase) ((ToolBase) buttonTool15).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((ToolBase) buttonTool15).SharedPropsInternal.Enabled = false;
    ((ToolBase) buttonTool15).SharedPropsInternal.Shortcut = Shortcut.ShiftF8;
    ((ToolBase) buttonTool15).SharedPropsInternal.ToolTipText = "Click here to close the claim.";
    ((ToolBase) buttonTool15).SharedPropsInternal.ToolTipTitle = "Close claim (Shift+F8)";
    ((AppearanceBase) appearance254).Image = (object) Resources.ReopenClaim;
    ((ToolPropsBase) ((ToolBase) buttonTool16).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance254;
    ((ToolPropsBase) ((ToolBase) buttonTool16).SharedPropsInternal).Caption = "Reopen Claim";
    ((ToolBase) buttonTool16).SharedPropsInternal.Category = "GeneralOptions";
    ((ToolBase) buttonTool16).SharedPropsInternal.Enabled = false;
    ((ToolBase) buttonTool16).SharedPropsInternal.ToolTipText = "Click here to re-open the claim.";
    ((ToolBase) buttonTool16).SharedPropsInternal.ToolTipTitle = "Re-Open Claim (Shift+F9)";
    ((AppearanceBase) appearance255).Image = (object) Resources.CatastropheCodeSmall;
    ((ToolPropsBase) ((ToolBase) buttonTool17).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance255;
    ((ToolPropsBase) ((ToolBase) buttonTool17).SharedPropsInternal).Caption = "Clear Claimant Entry";
    ((ToolBase) buttonTool17).SharedPropsInternal.Category = "Claimants";
    ((ToolBase) buttonTool17).SharedPropsInternal.Visible = false;
    ((AppearanceBase) appearance256).Image = (object) Resources.EditClaimant;
    ((ToolPropsBase) ((ToolBase) buttonTool18).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance256;
    ((ToolPropsBase) ((ToolBase) buttonTool18).SharedPropsInternal).Caption = "Edit Claimant";
    ((ToolBase) buttonTool18).SharedPropsInternal.Category = "Claimants";
    ((ToolPropsBase) ((ToolBase) popupMenuTool1).SharedPropsInternal).Caption = "ULAEGridContext";
    ((ToolBase) popupMenuTool1).SharedPropsInternal.Category = "ULAEOptions";
    ((ToolBase) buttonTool20).InstanceProps.IsFirstInGroup = true;
    ((ToolsCollectionBase) popupMenuTool1.Tools).AddRange(new ToolBase[2]
    {
      (ToolBase) buttonTool19,
      (ToolBase) buttonTool20
    });
    ((AppearanceBase) appearance257).Image = (object) Resources.DeleteClaimSmall;
    ((ToolPropsBase) ((ToolBase) buttonTool21).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance257;
    ((ToolPropsBase) ((ToolBase) buttonTool21).SharedPropsInternal).Caption = "Delete Transaction";
    ((ToolBase) buttonTool21).SharedPropsInternal.Category = "ULAEOptions";
    ((ToolBase) buttonTool21).SharedPropsInternal.Enabled = false;
    ((AppearanceBase) appearance258).Image = (object) Resources.ClaimStatus;
    ((ToolPropsBase) ((ToolBase) buttonTool22).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance258;
    ((ToolPropsBase) ((ToolBase) buttonTool22).SharedPropsInternal).Caption = "View User Log";
    ((ToolPropsBase) ((ToolBase) popupMenuTool2).SharedPropsInternal).Caption = "PopupMenuTool1";
    ((ToolsCollectionBase) popupMenuTool2.Tools).AddRange(new ToolBase[1]
    {
      (ToolBase) buttonTool23
    });
    ((ToolPropsBase) ((ToolBase) buttonTool24).SharedPropsInternal).Caption = "Modify Reserve";
    ((ToolPropsBase) ((ToolBase) buttonTool24).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((AppearanceBase) appearance259).Image = (object) Resources.Edit;
    ((ToolPropsBase) ((ToolBase) buttonTool25).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance259;
    ((ToolPropsBase) ((ToolBase) buttonTool25).SharedPropsInternal).Caption = "Edit Comment";
    ((ToolPropsBase) ((ToolBase) buttonTool25).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((ToolsCollectionBase) this.ultraToolbarsManager1.Tools).AddRange(new ToolBase[17]
    {
      (ToolBase) buttonTool8,
      (ToolBase) buttonTool9,
      (ToolBase) buttonTool10,
      (ToolBase) buttonTool11,
      (ToolBase) buttonTool12,
      (ToolBase) buttonTool13,
      (ToolBase) buttonTool14,
      (ToolBase) buttonTool15,
      (ToolBase) buttonTool16,
      (ToolBase) buttonTool17,
      (ToolBase) buttonTool18,
      (ToolBase) popupMenuTool1,
      (ToolBase) buttonTool21,
      (ToolBase) buttonTool22,
      (ToolBase) popupMenuTool2,
      (ToolBase) buttonTool24,
      (ToolBase) buttonTool25
    });
    this.ultraToolbarsManager1.BeforeToolDropdown += new BeforeToolDropdownEventHandler(this.ultraToolbarsManager1_BeforeToolDropdown);
    this.ultraToolbarsManager1.ToolClick += new ToolClickEventHandler(this.ultraToolbarsManager1_ToolClick);
    this.phoneClaimants_Primary.BackColor = Color.Transparent;
    this.phoneClaimants_Primary.Enabled = false;
    this.phoneClaimants_Primary.Font = new Font("Tahoma", 8.25f);
    this.phoneClaimants_Primary.Location = new Point(7, 325);
    this.phoneClaimants_Primary.Name = "phoneClaimants_Primary";
    this.phoneClaimants_Primary.PhoneLabelType = MgaPhoneNumberEntry.PhoneLabelTypes.Stacked;
    this.phoneClaimants_Primary.Size = new Size(378, 154);
    this.phoneClaimants_Primary.TabIndex = 14;
    this.phoneClaimants_Mailing.BackColor = Color.Transparent;
    this.phoneClaimants_Mailing.Enabled = false;
    this.phoneClaimants_Mailing.Font = new Font("Tahoma", 8.25f);
    this.phoneClaimants_Mailing.Location = new Point(512 /*0x0200*/, 325);
    this.phoneClaimants_Mailing.Name = "phoneClaimants_Mailing";
    this.phoneClaimants_Mailing.Size = new Size(373, 154);
    this.phoneClaimants_Mailing.TabIndex = 24;
    this.phoneClaimants_DefenseAttorney.BackColor = Color.Transparent;
    this.phoneClaimants_DefenseAttorney.Enabled = false;
    this.phoneClaimants_DefenseAttorney.Font = new Font("Tahoma", 8.25f);
    this.phoneClaimants_DefenseAttorney.Location = new Point(27, 330);
    this.phoneClaimants_DefenseAttorney.Name = "phoneClaimants_DefenseAttorney";
    this.phoneClaimants_DefenseAttorney.Size = new Size(364, 154);
    this.phoneClaimants_DefenseAttorney.TabIndex = 13;
    this.phoneClaimants_ClaimantAttorney.BackColor = Color.Transparent;
    this.phoneClaimants_ClaimantAttorney.Font = new Font("Tahoma", 8.25f);
    this.phoneClaimants_ClaimantAttorney.Location = new Point(403, 330);
    this.phoneClaimants_ClaimantAttorney.Name = "phoneClaimants_ClaimantAttorney";
    this.phoneClaimants_ClaimantAttorney.Size = new Size(370, 154);
    this.phoneClaimants_ClaimantAttorney.TabIndex = 24;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(976, 695);
    this.Controls.Add((Control) this.tabControlClaim);
    this.Controls.Add((Control) this._formClaims_Toolbars_Dock_Area_Left);
    this.Controls.Add((Control) this._formClaims_Toolbars_Dock_Area_Right);
    this.Controls.Add((Control) this._formClaims_Toolbars_Dock_Area_Bottom);
    this.Controls.Add((Control) this._formClaims_Toolbars_Dock_Area_Top);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.MinimumSize = new Size(900, 719);
    this.Name = nameof (FormClaims);
    this.ShowInTaskbar = false;
    this.Text = "Claims Entry";
    this.FormClosing += new FormClosingEventHandler(this.FormClaims_FormClosing);
    this.Load += new EventHandler(this.FormClaims_Load);
    this.Shown += new EventHandler(this.FormClaims_Shown);
    ((Control) this.tabPageClaimant).ResumeLayout(false);
    ((Control) this.tabPageClaimant).PerformLayout();
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
    ((Control) this.tabPageClaimOverview).ResumeLayout(false);
    this.groupIncurred.ResumeLayout(false);
    ((ISupportInitialize) this.gridIncurred).EndInit();
    this.groupBox4.ResumeLayout(false);
    ((ISupportInitialize) this.gridOverview_ReservePaymentBreakout).EndInit();
    this.dsReservePaymentBreakout1.EndInit();
    this.groupBox3.ResumeLayout(false);
    this.groupBox3.PerformLayout();
    ((ISupportInitialize) this.comboClaim_CatastropheCode2).EndInit();
    ((ISupportInitialize) this.textOverview_ClaimNumber).EndInit();
    ((ISupportInitialize) this.buttonEditClaimNumber).EndInit();
    ((ISupportInitialize) this.comboClaim_CatastropheCode).EndInit();
    ((ISupportInitialize) this.comboAdjusterAssigned).EndInit();
    ((ISupportInitialize) this.textOverview_Comments).EndInit();
    ((ISupportInitialize) this.dateTimeOverview_DateEntered).EndInit();
    ((ISupportInitialize) this.dateTimeOverview_LossDate).EndInit();
    ((ISupportInitialize) this.textOverview_EnteredBy).EndInit();
    this.groupBox2.ResumeLayout(false);
    ((ISupportInitialize) this.gridOverview_Claimants).EndInit();
    this.groupBox1.ResumeLayout(false);
    this.groupBox1.PerformLayout();
    ((ISupportInitialize) this.textOverview_EffectiveExpiration).EndInit();
    ((ISupportInitialize) this.textOverview_Line).EndInit();
    ((ISupportInitialize) this.textOverview_Company).EndInit();
    ((ISupportInitialize) this.textOverview_Producer).EndInit();
    ((ISupportInitialize) this.textOverview_Insured).EndInit();
    ((ISupportInitialize) this.textOverview_PolicyNumber).EndInit();
    ((ISupportInitialize) this.textOverview_ControlNumber).EndInit();
    ((Control) this.ultraTabPageControl2).ResumeLayout(false);
    ((ISupportInitialize) this.gridUnallocatedExpenses).EndInit();
    this.dsUnallocatedExpenses1.EndInit();
    ((Control) this.ultraTabPageControl3).ResumeLayout(false);
    ((Control) this.ultraTabPageControl3).PerformLayout();
    ((ISupportInitialize) this.textAccidentDescription).EndInit();
    this.groupBox5.ResumeLayout(false);
    this.groupBox5.PerformLayout();
    ((ISupportInitialize) this.textLongCoords).EndInit();
    ((ISupportInitialize) this.textLatCoord).EndInit();
    ((ISupportInitialize) this.maskAccidentTime).EndInit();
    ((ISupportInitialize) this.comboAccidentType).EndInit();
    ((ISupportInitialize) this.buttonMapLocation).EndInit();
    ((Control) this.ultraTabPageControl4).ResumeLayout(false);
    ((ISupportInitialize) this.gridClaimStatusLog).EndInit();
    ((Control) this.ultraTabPageControl5).ResumeLayout(false);
    this.groupBox7.ResumeLayout(false);
    this.groupBox7.PerformLayout();
    ((ISupportInitialize) this.textDriverLastName).EndInit();
    ((ISupportInitialize) this.textDriverFirstName).EndInit();
    ((ISupportInitialize) this.gridDrivers).EndInit();
    ((ISupportInitialize) this.buttonClearClaimant).EndInit();
    ((ISupportInitialize) this.buttonAddClaimant).EndInit();
    this.dsClaimActivity1.EndInit();
    ((Control) this.tabPageClaimantContainer).ResumeLayout(false);
    ((ISupportInitialize) this.tabControlClaimants).EndInit();
    ((Control) this.tabControlClaimants).ResumeLayout(false);
    ((Control) this.ultraTabSharedControlsPage2).ResumeLayout(false);
    ((Control) this.ultraTabSharedControlsPage2).PerformLayout();
    ((ISupportInitialize) this.tabControlClaim).EndInit();
    ((Control) this.tabControlClaim).ResumeLayout(false);
    ((ISupportInitialize) this.mgaSimpleComboBox3).EndInit();
    ((ISupportInitialize) this.mgaTextBox2).EndInit();
    ((ISupportInitialize) this.mgaDateTimePicker2).EndInit();
    ((ISupportInitialize) this.mgaSimpleComboBox4).EndInit();
    ((ISupportInitialize) this.mgaSimpleComboBox5).EndInit();
    ((ISupportInitialize) this.mgaSimpleComboBox6).EndInit();
    ((ISupportInitialize) this.mgaCheckedListBox1).EndInit();
    ((ISupportInitialize) this.mgaDateTimePicker4).EndInit();
    this.dsClaimOptions1.EndInit();
    ((ISupportInitialize) this.ultraToolbarsManager1).EndInit();
    this.ResumeLayout(false);
  }

  protected delegate void ClaimantFormLoadedEventHandler(
    object sender,
    ClaimantFormLoadedEventArgs e);

  protected delegate void ClaimantFormBeforeShownEventHandler(
    object sender,
    ClaimantFormBeforeShownEventArgs e);

  protected delegate void ClaimSavedHandler(object sender, ClaimSavedEventArgs e);

  protected delegate void ModifyReserveFormShowHandler(
    object sender,
    ModifyReserveFormShownEventArgs e);
}
