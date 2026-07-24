// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.ClaimsAdministrationPortal
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
using Infragistics.Win.UltraWinToolbars;
using MGASystems.AddressResolver;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Claims.Properties;
using MGASystems.Tools;
using MGASystems.Tools.DBSaveUI;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Claims;

public class ClaimsAdministrationPortal : UserControlBase
{
  private ClaimsAdministrationPortal.ViewType _layoutViewType;
  private ClaimsAdministrationPortal.AdministrationPortalType _portalType;
  private string _controlTitle;
  protected ClaimsAdministrationPortal.DBSaveUIState _DBSaveUIState;
  private IContainer components;
  protected UltraGrid gridView;
  protected MGAGroupBox groupTwoText;
  private UltraLabel labelHeader;
  protected MGASystems.Tools.DBSaveUI.DBSaveUI dbSaveMulti;
  protected MGATextBox textTwoText2;
  protected MGATextBox textTwoText1;
  private Label labelTwoField2;
  private Label labelTwoField1;
  protected MGAGroupBox groupOneText;
  protected MGATextBox textOneText1;
  private Label labelOneViewField1;
  protected MGASystems.Tools.DBSaveUI.DBSaveUI dbSaveUISingle;
  private Panel panelBottom;
  private Panel panelCenter;
  private Panel panelTop;
  private Panel panelRight;
  private Label label5;
  private Label label4;
  private Label label3;
  private Label label2;
  private MGATextBox textCorporationName;
  private MGATextBox textLastName;
  private MGATextBox textMiddleName;
  private MGATextBox textFirstName;
  private UltraOptionSet optionEntityType;
  private AddressResolver_MULTI addResolver;
  private Label label6;
  private MGATextBox textEmailAddress;
  private Label label7;
  private MGAMaskedEdit maskedEditSSNFEIN;
  private MGADateTimePicker dateTimeIncorporated;
  private Label label8;
  private MGASystems.Tools.DBSaveUI.DBSaveUI dbSaveUIAddress;
  private dsClaims_PhoneNumbers dsClaims_PhoneNumbers1;
  protected dsClaimsAdministration dsClaimsAdministration1;
  private MGAGroupBox groupExtendedMulti;
  private MGASystems.Tools.DBSaveUI.DBSaveUI dbSaveUIExtendedMulti;
  private MGATextBox textExtendedMulti1;
  private MGASimpleComboBox comboExtendedMulti;
  private Label label12;
  private Label labelExtendedCombo;
  private MGATextBox textWebAddress;
  private Label label1;
  private MgaPhoneNumberEntry mgaPhoneNumberEntry1;
  private UltraToolbarsManager ultraToolbarsManager1;
  private UltraToolbarsDockArea _ClaimsAdministrationPortal_Toolbars_Dock_Area_Left;
  private UltraToolbarsDockArea _ClaimsAdministrationPortal_Toolbars_Dock_Area_Right;
  private UltraToolbarsDockArea _ClaimsAdministrationPortal_Toolbars_Dock_Area_Top;
  private UltraToolbarsDockArea _ClaimsAdministrationPortal_Toolbars_Dock_Area_Bottom;

  public ClaimsAdministrationPortal()
  {
    this.InitializeComponent();
    this.InitializeLayout();
  }

  private void InitializeLayout()
  {
    this.ToggleLayoutView(this._layoutViewType);
    this.panelTop.Dock = DockStyle.Top;
    this.panelBottom.Dock = DockStyle.Bottom;
    this.panelCenter.Dock = DockStyle.Fill;
  }

  [EditorBrowsable(EditorBrowsableState.Always)]
  [DefaultValue(1)]
  public ClaimsAdministrationPortal.ViewType LayoutViewType
  {
    get => this._layoutViewType;
    set
    {
      this.ToggleLayoutView(value);
      this._layoutViewType = value;
    }
  }

  [EditorBrowsable(EditorBrowsableState.Always)]
  public string ControlTitle
  {
    get => this._controlTitle;
    set => this._controlTitle = value;
  }

  [EditorBrowsable(EditorBrowsableState.Always)]
  public ClaimsAdministrationPortal.AdministrationPortalType PortalType
  {
    get => this._portalType;
    set
    {
      this.SetPredefinedPortalType(value);
      this._portalType = value;
      this.BindUI();
      this.LoadInternationalZipCode();
    }
  }

  private void ToggleLayoutView(ClaimsAdministrationPortal.ViewType layoutViewType)
  {
    if (this.LayoutViewType == layoutViewType)
      return;
    ClaimsAdministrationPortal.ViewType layoutViewType1 = this.LayoutViewType;
    ((Control) this.groupTwoText).Visible = layoutViewType == ClaimsAdministrationPortal.ViewType.MultiTextBoxView;
    ((Control) this.groupOneText).Visible = layoutViewType == ClaimsAdministrationPortal.ViewType.SingleTextBoxView;
    ((Control) this.groupExtendedMulti).Visible = layoutViewType == ClaimsAdministrationPortal.ViewType.ExtendedMultiView;
    this.panelBottom.Visible = layoutViewType != ClaimsAdministrationPortal.ViewType.AddressView;
    this.panelRight.Visible = layoutViewType == ClaimsAdministrationPortal.ViewType.AddressView;
    if (this._layoutViewType == ClaimsAdministrationPortal.ViewType.Default)
      this._layoutViewType = ClaimsAdministrationPortal.ViewType.SingleTextBoxView;
    switch (layoutViewType)
    {
      case ClaimsAdministrationPortal.ViewType.SingleTextBoxView:
        this.Width = Convert.ToInt32(Resources.CLAIMSADMIN_PORTALWIDTH_NONADDRESS);
        this.panelBottom.Height = Convert.ToInt32(Resources.CLAIMSADMIN_PORTALHEIGHT_ONEBOX);
        this.panelRight.Dock = DockStyle.None;
        break;
      case ClaimsAdministrationPortal.ViewType.MultiTextBoxView:
        this.Width = Convert.ToInt32(Resources.CLAIMSADMIN_PORTALWIDTH_NONADDRESS);
        this.panelBottom.Height = Convert.ToInt32(Resources.CLAIMSADMIN_PORTALHEIGHT_TWOBOX);
        this.panelRight.Dock = DockStyle.None;
        break;
      case ClaimsAdministrationPortal.ViewType.ExtendedMultiView:
        this.Width = Convert.ToInt32(Resources.CLAIMSADMIN_PORTALWIDTH_NONADDRESS);
        this.panelBottom.Height = Convert.ToInt32(Resources.CLAIMSADMIN_PORTALHEIGHT_TWOBOX);
        this.panelRight.Dock = DockStyle.None;
        break;
      case ClaimsAdministrationPortal.ViewType.AddressView:
        this.Width = Convert.ToInt32(Resources.CLAIMSADMIN_PORTALWIDTH_ADDRESS);
        this.panelRight.Dock = DockStyle.Right;
        this.panelRight.SendToBack();
        break;
      default:
        this.ToggleLayoutView(ClaimsAdministrationPortal.ViewType.SingleTextBoxView);
        break;
    }
    this.Refresh();
    this.OnLayoutTypeChanged(layoutViewType1, layoutViewType);
  }

  private void SetPredefinedPortalType(
    ClaimsAdministrationPortal.AdministrationPortalType portalType)
  {
    if (this.PortalType == portalType)
      return;
    ClaimsAdministrationPortal.AdministrationPortalType portalType1 = this.PortalType;
    this._portalType = portalType;
    switch (portalType)
    {
      case ClaimsAdministrationPortal.AdministrationPortalType.CatastropheCodes:
      case ClaimsAdministrationPortal.AdministrationPortalType.CoverageTypes:
        this.LayoutViewType = ClaimsAdministrationPortal.ViewType.MultiTextBoxView;
        break;
      case ClaimsAdministrationPortal.AdministrationPortalType.CoverageTypeDescriptions:
      case ClaimsAdministrationPortal.AdministrationPortalType.ReservePaymentSubTypes:
        this.LayoutViewType = ClaimsAdministrationPortal.ViewType.ExtendedMultiView;
        break;
      case ClaimsAdministrationPortal.AdministrationPortalType.ManagedCareFacilities:
      case ClaimsAdministrationPortal.AdministrationPortalType.OutsideAdjusters:
        this.LayoutViewType = ClaimsAdministrationPortal.ViewType.AddressView;
        break;
      default:
        this.LayoutViewType = ClaimsAdministrationPortal.ViewType.SingleTextBoxView;
        break;
    }
    if (portalType == ClaimsAdministrationPortal.AdministrationPortalType.Custom)
    {
      ((UltraGridBase) this.gridView).DataMember = string.Empty;
      ((UltraGridBase) this.gridView).DataSource = (object) null;
    }
    else
    {
      ((UltraGridBase) this.gridView).DataSource = (object) this.dsClaimsAdministration1;
      switch (portalType - 1)
      {
        case ClaimsAdministrationPortal.AdministrationPortalType.Custom:
          this._controlTitle = Resources.CLAIMSADMIN_ACCIDENTTYPE_TITLE;
          this.labelOneViewField1.Text = Resources.CLAIMSADMIN_ACCIDENTTYPE_FIELDLABEL1;
          ((UltraGridBase) this.gridView).DataMember = this.dsClaimsAdministration1.AccidentTypes.TableName;
          break;
        case ClaimsAdministrationPortal.AdministrationPortalType.AccidentTypes:
          this._controlTitle = Resources.CLAIMSADMIN_CATASTROPHECODE_TITLE;
          this.labelTwoField1.Text = Resources.CLAIMSADMIN_CATASTROPHECODE_FIELDLABEL1;
          ((UltraGridBase) this.gridView).DataMember = this.dsClaimsAdministration1.CatastropheCodes.TableName;
          break;
        case ClaimsAdministrationPortal.AdministrationPortalType.ClaimPrefixes:
          this._controlTitle = Resources.CLAIMSADMIN_COVERAGETYPE_TITLE;
          this.labelTwoField1.Text = Resources.CLAIMSADMIN_COVERAGETYPE_FIELDLABEL1;
          ((UltraGridBase) this.gridView).DataMember = this.dsClaimsAdministration1.CoverageTypes.TableName;
          break;
        case ClaimsAdministrationPortal.AdministrationPortalType.CoverageTypes:
          this._controlTitle = Resources.CLAIMSADMIN_COVERAGETYPEDESCRIPTION_TITLE;
          this.labelOneViewField1.Text = Resources.CLAIMSADMIN_COVERAGETYPEDESCRIPTION_FIELDLABEL1;
          ((UltraGridBase) this.gridView).DataMember = this.dsClaimsAdministration1.CoverageTypeDescriptions.TableName;
          this.SetLinkDropDownDatasource((DataTable) this.dsClaimsAdministration1.CoverageTypes, this.dsClaimsAdministration1.CoverageTypes.CoverageTypeIdColumn.ColumnName, this.dsClaimsAdministration1.CoverageTypes.CoverageTypeColumn.ColumnName);
          break;
        case ClaimsAdministrationPortal.AdministrationPortalType.CoverageTypeDescriptions:
          this._controlTitle = Resources.CLAIMSADMIN_LOSSTYPE_TITLE;
          this.labelOneViewField1.Text = Resources.CLAIMSADMIN_LOSSTYPE_FIELDLABEL1;
          ((UltraGridBase) this.gridView).DataMember = this.dsClaimsAdministration1.LossTypes.TableName;
          break;
        case ClaimsAdministrationPortal.AdministrationPortalType.LossTypes:
          this._controlTitle = Resources.CLAIMSADMIN_MANAGEDCARE_TITLE;
          ((UltraGridBase) this.gridView).DataMember = this.dsClaimsAdministration1.ManagedCareFacilities.TableName;
          this.InitializeAddressPhoneNumberControl();
          break;
        case ClaimsAdministrationPortal.AdministrationPortalType.ManagedCareFacilities:
          this._controlTitle = Resources.CLAIMSADMIN_OUTSIDEADJUSTER_TITLE;
          ((UltraGridBase) this.gridView).DataMember = this.dsClaimsAdministration1.OutsideAdjusters.TableName;
          this.InitializeAddressPhoneNumberControl();
          break;
        case ClaimsAdministrationPortal.AdministrationPortalType.PhoneTypes:
          this._controlTitle = Resources.CLAIMSADMIN_RESERVEPAYMENT_TITLE;
          this.labelTwoField1.Text = Resources.CLAIMSADMIN_RESERVEPAYMENT_FIELDLABEL1;
          ((UltraGridBase) this.gridView).DataMember = this.dsClaimsAdministration1.ReservePaymentTypes.TableName;
          break;
        case ClaimsAdministrationPortal.AdministrationPortalType.ReservePaymentTypes:
          this._controlTitle = Resources.CLAIMSADMIN_RESERVEPAYMENTSUBTYPE_TITLE;
          this.labelTwoField1.Text = Resources.CLAIMSADMIN_RESERVEPAYMENTSUBTYPE_FIELDLABEL1;
          ((UltraGridBase) this.gridView).DataMember = this.dsClaimsAdministration1.ReservePaymentSubTypes.TableName;
          this.SetLinkDropDownDatasource((DataTable) this.dsClaimsAdministration1.ReservePaymentTypes, this.dsClaimsAdministration1.ReservePaymentTypes.ResPayTypeIdColumn.ColumnName, this.dsClaimsAdministration1.ReservePaymentTypes.ResPayTypeDescriptionColumn.ColumnName);
          break;
        case ClaimsAdministrationPortal.AdministrationPortalType.ReservePaymentSubTypes:
          this._controlTitle = Resources.CLAIMSADMIN_SETTLEMENTTYPE_TITLE;
          this.labelOneViewField1.Text = Resources.CLAIMSADMIN_SETTLEMENTTYPE_FIELDLABEL1;
          ((UltraGridBase) this.gridView).DataMember = this.dsClaimsAdministration1.SettlementTypes.TableName;
          break;
      }
      if (((KeyedSubObjectsCollectionBase) ((UltraGridBase) this.gridView).Layouts).Exists(((UltraGridBase) this.gridView).DataMember))
        ((UltraGridBase) this.gridView).DisplayLayout.Load(((UltraGridBase) this.gridView).Layouts[((UltraGridBase) this.gridView).DataMember], (PropertyCategories) -1);
      ((UltraGridBase) this.gridView).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
      ((UltraGridBase) this.gridView).DisplayLayout.Bands[0].Override.AllowColSizing = (AllowColSizing) 3;
      if (((DisposableObjectCollectionBase) ((UltraGridBase) this.gridView).Rows).Count > 0)
      {
        this.gridView.AfterSelectChange -= new AfterSelectChangeEventHandler(this.gridView_AfterSelectChange);
        ((GridItemBase) ((UltraGridBase) this.gridView).Rows[0]).Selected = true;
        this.gridView.AfterSelectChange += new AfterSelectChangeEventHandler(this.gridView_AfterSelectChange);
      }
      this.SetControlTitle();
      this.ClearSingleView();
      this.ClearMultiView();
      this.ClearExtendedMultiView();
      this.ClearAddressView();
      this.BindUI();
      this.OnAdministrationPortalTypeChanged(portalType1, portalType);
    }
  }

  private void SetLinkDropDownDatasource(
    DataTable dataTable,
    string valueMember,
    string displayMember)
  {
    ((UltraDropDownBase) this.comboExtendedMulti).ValueMember = string.Empty;
    ((UltraDropDownBase) this.comboExtendedMulti).DisplayMember = string.Empty;
    ((UltraGridBase) this.comboExtendedMulti).DataSource = (object) dataTable;
    ((UltraDropDownBase) this.comboExtendedMulti).ValueMember = valueMember;
    ((UltraDropDownBase) this.comboExtendedMulti).DisplayMember = displayMember;
  }

  private void SetControlTitle()
  {
    if (!string.IsNullOrEmpty(this.ControlTitle))
    {
      StringBuilder stringBuilder = new StringBuilder();
      stringBuilder.Append(this.ControlTitle);
      stringBuilder.Append(" ");
      stringBuilder.Append(Resources.CLAIMSADMIN_DEFAULTTILE);
      ((Control) this.labelHeader).Text = stringBuilder.ToString();
    }
    else
      ((Control) this.labelHeader).Text = Resources.CLAIMSADMIN_DEFAULTTILE;
  }

  protected void ClearSingleView() => ((Control) this.textOneText1).Text = string.Empty;

  protected void ClearMultiView()
  {
    ((Control) this.textTwoText1).Text = string.Empty;
    ((Control) this.textTwoText2).Text = string.Empty;
  }

  private void ClearExtendedMultiView()
  {
    ((Control) this.comboExtendedMulti).ResetText();
    ((Control) this.textExtendedMulti1).Text = string.Empty;
  }

  private void ClearAddressView()
  {
    this.optionEntityType.Value = this.PortalType != ClaimsAdministrationPortal.AdministrationPortalType.ManagedCareFacilities ? (object) "I" : (object) "C";
    ((Control) this.textCorporationName).Text = string.Empty;
    ((Control) this.textFirstName).Text = string.Empty;
    ((Control) this.textMiddleName).Text = string.Empty;
    ((Control) this.textLastName).Text = string.Empty;
    this.addResolver.Clear();
    ((Control) this.textCorporationName).Text = string.Empty;
    ((Control) this.textEmailAddress).Text = string.Empty;
    ((Control) this.textWebAddress).Text = string.Empty;
    ((UltraDateTimeEditor) this.dateTimeIncorporated).Value = (object) DBNull.Value;
    ((Control) this.maskedEditSSNFEIN).Text = string.Empty;
  }

  public virtual void LoadClaimsAdmistration()
  {
    this.dsClaimsAdministration1.Clear();
    DefaultDatabase.LoadDataSet((DataSet) this.dsClaimsAdministration1, new string[14]
    {
      this.dsClaimsAdministration1.AccidentTypes.TableName,
      this.dsClaimsAdministration1.CoverageTypes.TableName,
      this.dsClaimsAdministration1.CoverageTypeDescriptions.TableName,
      this.dsClaimsAdministration1.CatastropheCodes.TableName,
      this.dsClaimsAdministration1.LossTypes.TableName,
      this.dsClaimsAdministration1.ManagedCareFacilities.TableName,
      this.dsClaimsAdministration1.ManagedCareAddresses.TableName,
      this.dsClaimsAdministration1.ManagedCareAddressPhoneNumbers.TableName,
      this.dsClaimsAdministration1.ReservePaymentTypes.TableName,
      this.dsClaimsAdministration1.ReservePaymentSubTypes.TableName,
      this.dsClaimsAdministration1.OutsideAdjusterAddresses.TableName,
      this.dsClaimsAdministration1.OutsideAdjusters.TableName,
      this.dsClaimsAdministration1.OutsideAdjusterAddressPhoneNumbers.TableName,
      this.dsClaimsAdministration1.SettlementTypes.TableName
    }, "spClaims_LoadClaimsAdministration");
  }

  protected virtual void BindUI()
  {
    this.ClearSingleUIBindings();
    this.ClearMultiUIBindings();
    this.ClearExtendedMultiUIBindings();
    this.ClearAddressViewUIBindings();
    switch (this.PortalType)
    {
      case ClaimsAdministrationPortal.AdministrationPortalType.AccidentTypes:
        this.SetUIBindings((Control) this.groupOneText, (object[]) new string[3]
        {
          "textOneText1",
          "Text",
          "AccidentTypes.AccidentType"
        });
        break;
      case ClaimsAdministrationPortal.AdministrationPortalType.CatastropheCodes:
        this.SetUIBindings((Control) this.groupTwoText, (object[]) new string[6]
        {
          "textTwoText1",
          "Text",
          "CatastropheCodes.CatastropheCode",
          "textTwoText2",
          "Text",
          "CatastropheCodes.CatastropheCodeDescription"
        });
        break;
      case ClaimsAdministrationPortal.AdministrationPortalType.CoverageTypes:
        this.SetUIBindings((Control) this.groupTwoText, (object[]) new string[6]
        {
          "textTwoText1",
          "Text",
          "CoverageTypes.CoverageType",
          "textTwoText2",
          "Text",
          "CoverageTypes.CoverageTypeDescription"
        });
        break;
      case ClaimsAdministrationPortal.AdministrationPortalType.CoverageTypeDescriptions:
        this.SetUIBindings((Control) this.groupExtendedMulti, (object[]) new string[6]
        {
          "textExtendedMulti1",
          "Text",
          "CoverageTypeDescriptions.CoverageTypeDescription",
          "comboExtendedMulti",
          "Value",
          "CoverageTypeDescriptions.CoverageTypeId"
        });
        break;
      case ClaimsAdministrationPortal.AdministrationPortalType.LossTypes:
        this.SetUIBindings((Control) this.groupOneText, (object[]) new string[3]
        {
          "textOneText1",
          "Text",
          "LossTypes.LossType"
        });
        break;
      case ClaimsAdministrationPortal.AdministrationPortalType.ManagedCareFacilities:
        this.SetUIBindings((Control) this.panelRight, (object) "textCorporationName", (object) "Text", (object) "ManagedCareFacilities.FacilityName", (object) "addResolver", (object) "ISOCountryCode", (object) "ManagedCareAddresses.ISOCountryCode", (object) "addResolver", (object) "Address1", (object) "ManagedCareAddresses.Address1", (object) "addResolver", (object) "Address2", (object) "ManagedCareAddresses.Address2", (object) "addResolver", (object) "City", (object) "ManagedCareAddresses.City", (object) "addResolver", (object) "State", (object) "ManagedCareAddresses.State", (object) "addResolver", (object) "ZipCode", (object) "ManagedCareAddresses.ZipCode", (object) "optionEntityType", (object) "Value", (object) "ManagedCareFacilities.EntityType", (object) "dateTimeIncorporated", (object) "Value", (object) "ManagedCareFacilities.DateIncorporated", (object) "maskedEditSSNFEIN", (object) "Text", (object) "ManagedCareFacilities.FEIN", (object) "textEmailAddress", (object) "Text", (object) "ManagedCareFacilities.EmailAddress");
        break;
      case ClaimsAdministrationPortal.AdministrationPortalType.OutsideAdjusters:
        this.SetUIBindings((Control) this.panelRight, (object) "textCorporationName", (object) "Text", (object) "OutsideAdjusters.Company", (object) "textFirstName", (object) "Text", (object) "OutsideAdjusters.FirstName", (object) "textMiddleName", (object) "Text", (object) "OutsideAdjusters.MiddleName", (object) "textLastName", (object) "Text", (object) "OutsideAdjusters.LastName", (object) "addResolver", (object) "ISOCountryCode", (object) "OutsideAdjusterAddresses.ISOCountryCode", (object) "addResolver", (object) "Address1", (object) "OutsideAdjusterAddresses.Address1", (object) "addResolver", (object) "Address2", (object) "OutsideAdjusterAddresses.Address2", (object) "addResolver", (object) "City", (object) "OutsideAdjusterAddresses.City", (object) "addResolver", (object) "State", (object) "OutsideAdjusterAddresses.State", (object) "addResolver", (object) "ZipCode", (object) "OutsideAdjusterAddresses.ZipCode", (object) "optionEntityType", (object) "Value", (object) "OutsideAdjusters.EntityType", (object) "maskedEditSSNFEIN", (object) "Text", (object) "OutsideAdjusters.SSNFEIN", (object) "textEmailAddress", (object) "Text", (object) "OutsideAdjusters.EmailAddress");
        break;
      case ClaimsAdministrationPortal.AdministrationPortalType.ReservePaymentTypes:
        this.SetUIBindings((Control) this.groupOneText, (object[]) new string[3]
        {
          "textOneText1",
          "Text",
          "ReservePaymentTypes.ResPayTypeDescription"
        });
        break;
      case ClaimsAdministrationPortal.AdministrationPortalType.ReservePaymentSubTypes:
        this.SetUIBindings((Control) this.groupExtendedMulti, (object[]) new string[6]
        {
          "textExtendedMulti1",
          "Text",
          "ReservePaymentSubTypes.ResPaySubTypeDescription",
          "comboExtendedMulti",
          "Value",
          "ReservePaymentSubTypes.ResPayTypeId"
        });
        break;
      case ClaimsAdministrationPortal.AdministrationPortalType.SettlementTypes:
        this.SetUIBindings((Control) this.groupOneText, (object[]) new string[3]
        {
          "textOneText1",
          "Text",
          "SettlementTypes.SettlementType"
        });
        break;
    }
  }

  protected void SetUIBindings(Control containerControl, params object[] typeValuePair)
  {
    int num1;
    for (int index = 0; index < typeValuePair.Length; index = num1 + 1)
    {
      int num2;
      containerControl.Controls[typeValuePair[index].ToString()].DataBindings.Add(new Binding(typeValuePair[num2 = index + 1].ToString(), (object) this.dsClaimsAdministration1, typeValuePair[num1 = num2 + 1].ToString()));
    }
    this.InitUIEnabled();
  }

  protected virtual void ClearSingleUIBindings()
  {
    ((Control) this.textOneText1).DataBindings.Clear();
  }

  protected virtual void ClearMultiUIBindings()
  {
    ((Control) this.textTwoText1).DataBindings.Clear();
    ((Control) this.textTwoText2).DataBindings.Clear();
  }

  private void ClearExtendedMultiUIBindings()
  {
    ((Control) this.comboExtendedMulti).DataBindings.Clear();
    ((Control) this.textExtendedMulti1).DataBindings.Clear();
  }

  private void ClearAddressViewUIBindings()
  {
    ((Control) this.textCorporationName).DataBindings.Clear();
    ((Control) this.textFirstName).DataBindings.Clear();
    ((Control) this.textMiddleName).DataBindings.Clear();
    ((Control) this.textLastName).DataBindings.Clear();
    ((Control) this.textEmailAddress).DataBindings.Clear();
    ((Control) this.dateTimeIncorporated).DataBindings.Clear();
    ((Control) this.addResolver).DataBindings.Clear();
    ((Control) this.optionEntityType).DataBindings.Clear();
    ((Control) this.textWebAddress).DataBindings.Clear();
    ((Control) this.maskedEditSSNFEIN).DataBindings.Clear();
  }

  protected virtual void InitUIEnabled()
  {
    int count = ((DisposableObjectCollectionBase) ((UltraGridBase) this.gridView).Rows).Count;
    switch (this.LayoutViewType)
    {
      case ClaimsAdministrationPortal.ViewType.SingleTextBoxView:
        ((Control) this.textOneText1).Enabled = false;
        this.dbSaveUISingle.EditStyle = count == 0 ? (EditStyle) 0 : (EditStyle) 1;
        this.dbSaveUISingle.UIState = count == 0 ? (UIState) 0 : (UIState) 1;
        break;
      case ClaimsAdministrationPortal.ViewType.MultiTextBoxView:
        ((Control) this.textTwoText1).Enabled = false;
        ((Control) this.textTwoText2).Enabled = false;
        this.dbSaveMulti.EditStyle = count == 0 ? (EditStyle) 0 : (EditStyle) 1;
        this.dbSaveMulti.UIState = count == 0 ? (UIState) 0 : (UIState) 1;
        break;
      case ClaimsAdministrationPortal.ViewType.ExtendedMultiView:
        ((Control) this.comboExtendedMulti).Enabled = false;
        ((Control) this.textExtendedMulti1).Enabled = false;
        this.dbSaveUIExtendedMulti.EditStyle = count == 0 ? (EditStyle) 0 : (EditStyle) 1;
        this.dbSaveUIExtendedMulti.UIState = count == 0 ? (UIState) 0 : (UIState) 1;
        break;
      case ClaimsAdministrationPortal.ViewType.AddressView:
        this.ToggleAddressViewEnabled(false);
        this.dbSaveUIAddress.EditStyle = count == 0 ? (EditStyle) 0 : (EditStyle) 1;
        this.dbSaveUIAddress.UIState = count == 0 ? (UIState) 0 : (UIState) 1;
        break;
    }
  }

  private void ToggleAddressViewEnabled(bool enableControls)
  {
    if (this.PortalType == ClaimsAdministrationPortal.AdministrationPortalType.ManagedCareFacilities)
    {
      this.optionEntityType.Value = (object) "C";
      ((Control) this.optionEntityType).Enabled = false;
    }
    else
      ((Control) this.optionEntityType).Enabled = enableControls;
    ((Control) this.textCorporationName).Enabled = enableControls && (string) this.optionEntityType.Value == "C";
    ((Control) this.textFirstName).Enabled = enableControls && (string) this.optionEntityType.Value == "I";
    ((Control) this.textMiddleName).Enabled = enableControls && (string) this.optionEntityType.Value == "I";
    ((Control) this.textLastName).Enabled = enableControls && (string) this.optionEntityType.Value == "I";
    ((Control) this.addResolver).Enabled = enableControls;
    ((Control) this.textEmailAddress).Enabled = enableControls;
    ((Control) this.textWebAddress).Enabled = enableControls;
    this.mgaPhoneNumberEntry1.Enabled = enableControls;
    ((Control) this.dateTimeIncorporated).Enabled = enableControls;
    ((Control) this.maskedEditSSNFEIN).Enabled = enableControls;
  }

  private void InitializeAddressPhoneNumberControl()
  {
    if (this.PortalType == ClaimsAdministrationPortal.AdministrationPortalType.ManagedCareFacilities)
    {
      this.mgaPhoneNumberEntry1.DataSource = (object) this.dsClaimsAdministration1.ManagedCareAddressPhoneNumbers;
      this.mgaPhoneNumberEntry1.InitializePhoneGrid("AddressId", "PhoneTypeId", "PhoneNumberId", "CountryCode", "InputMask");
      if (this.dsClaimsAdministration1.ManagedCareFacilities.Count <= 0)
        return;
      this.mgaPhoneNumberEntry1.SetAddressId(Convert.ToInt32(this.dsClaimsAdministration1.ManagedCareFacilities[0]["AddressId"]));
    }
    else
    {
      if (this.PortalType != ClaimsAdministrationPortal.AdministrationPortalType.OutsideAdjusters)
        return;
      this.mgaPhoneNumberEntry1.DataSource = (object) this.dsClaimsAdministration1.OutsideAdjusterAddressPhoneNumbers;
      this.mgaPhoneNumberEntry1.InitializePhoneGrid("AddressId", "PhoneTypeId", "PhoneNumberId", "CountryCode", "InputMask");
      if (this.dsClaimsAdministration1.OutsideAdjusters.Count <= 0)
        return;
      this.mgaPhoneNumberEntry1.SetAddressId(Convert.ToInt32(this.dsClaimsAdministration1.OutsideAdjusters[0]["AddressId"]));
    }
  }

  private bool VerifyAddress()
  {
    if (!string.IsNullOrEmpty(((Control) this.textCorporationName).Text) || !string.IsNullOrEmpty(((Control) this.textFirstName).Text) || !string.IsNullOrEmpty(((Control) this.textMiddleName).Text) || !string.IsNullOrEmpty(((Control) this.textLastName).Text))
      return true;
    int num = (int) MessageBox.Show(Resources.ADDRESSERROR_NAMEMISSING, Resources.ERROR_REQUIREDFIELD_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    return false;
  }

  protected void OnLayoutTypeChanged(
    ClaimsAdministrationPortal.ViewType oldType,
    ClaimsAdministrationPortal.ViewType newType)
  {
    if (this.LayoutViewTypeChanged == null)
      return;
    this.LayoutViewTypeChanged((object) this, new ViewLayoutEventArgs(oldType, newType));
  }

  protected void OnAdministrationPortalTypeChanged(
    ClaimsAdministrationPortal.AdministrationPortalType oldType,
    ClaimsAdministrationPortal.AdministrationPortalType newType)
  {
    if (this.AdministrationPortalTypeChanged == null)
      return;
    this.AdministrationPortalTypeChanged((object) this, new AdministrationPortalTypeEventArgs(oldType, newType));
  }

  public event EventHandler<ViewLayoutEventArgs> LayoutViewTypeChanged;

  public event EventHandler<AdministrationPortalTypeEventArgs> AdministrationPortalTypeChanged;

  protected void FinalizeDatabaseOperation(params DataTable[] tables)
  {
    for (int index = 0; index < tables.Length; ++index)
      tables[index].Clear();
    this.LoadClaimsAdmistration();
    if (((DisposableObjectCollectionBase) ((UltraGridBase) this.gridView).Rows).Count == 0)
      return;
    this.gridView.AfterSelectChange -= new AfterSelectChangeEventHandler(this.gridView_AfterSelectChange);
    ((GridItemBase) ((UltraGridBase) this.gridView).Rows[0]).Selected = true;
    this.gridView.AfterSelectChange += new AfterSelectChangeEventHandler(this.gridView_AfterSelectChange);
  }

  protected void SetDBSaveUIState(ClaimsAdministrationPortal.DBSaveUIState state)
  {
    this._DBSaveUIState = state;
  }

  protected virtual void dbSaveUISingle_ClickedCancel(object sender, EventArgs e)
  {
    this.SetDBSaveUIState(ClaimsAdministrationPortal.DBSaveUIState.None);
    this.ClearSingleUIBindings();
    this.ClearSingleView();
    this.BindUI();
    this.InitUIEnabled();
  }

  protected virtual void dbSaveUISingle_ClickedEdit(object sender, EventArgs e)
  {
    this.SetDBSaveUIState(ClaimsAdministrationPortal.DBSaveUIState.Editing);
    this.ClearSingleUIBindings();
    ((Control) this.textOneText1).Enabled = true;
    ((TextEditorControlBase) this.textOneText1).Focus();
    ((TextEditorControlBase) this.textOneText1).SelectAll();
  }

  private void dbSaveUISingle_ClickedNew(object sender, EventArgs e)
  {
    this.SetDBSaveUIState(ClaimsAdministrationPortal.DBSaveUIState.Adding);
    this.ClearSingleUIBindings();
    this.ClearSingleView();
    ((Control) this.textOneText1).Enabled = true;
    ((TextEditorControlBase) this.textOneText1).Focus();
    ((TextEditorControlBase) this.textOneText1).SelectAll();
  }

  private void dbSaveUISingle_ClickedSave(object sender, EventArgs e)
  {
    switch (this.PortalType)
    {
      case ClaimsAdministrationPortal.AdministrationPortalType.AccidentTypes:
        this.AddEditAccidentType();
        break;
      case ClaimsAdministrationPortal.AdministrationPortalType.LossTypes:
        this.AddEditLossType();
        break;
      case ClaimsAdministrationPortal.AdministrationPortalType.ReservePaymentTypes:
        this.AddReservePaymentType();
        break;
      case ClaimsAdministrationPortal.AdministrationPortalType.SettlementTypes:
        this.AddEditSettlementType();
        break;
    }
  }

  private void dbSaveUISingle_ClickedDelete(object sender, EventArgs e) => this.Delete();

  private void dbSaveUISingle_ClickingSave(object sender, CancelEventArgs e)
  {
    if (!string.IsNullOrEmpty(((Control) this.textOneText1).Text))
      return;
    int num = (int) MessageBox.Show(Resources.CLAIMSADMIN_ERROR_SINGLETEXTEMPTY, Resources.ERROR_REQUIREDFIELD_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    e.Cancel = true;
  }

  private void dbSaveMulti_ClickingSave(object sender, CancelEventArgs e)
  {
    if (!string.IsNullOrEmpty(((Control) this.textTwoText1).Text))
      return;
    int num = (int) MessageBox.Show(Resources.CLAIMSADMIN_ERROR_SINGLETEXTEMPTY, Resources.ERROR_REQUIREDFIELD_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    e.Cancel = true;
  }

  private void dbSaveMulti_ClickedCancel(object sender, EventArgs e)
  {
    this.SetDBSaveUIState(ClaimsAdministrationPortal.DBSaveUIState.None);
    this.ClearMultiUIBindings();
    this.ClearMultiView();
    this.BindUI();
    this.InitUIEnabled();
  }

  private void dbSaveMulti_ClickedDelete(object sender, EventArgs e) => this.Delete();

  private void dbSaveMulti_ClickedEdit(object sender, EventArgs e)
  {
    this.SetDBSaveUIState(ClaimsAdministrationPortal.DBSaveUIState.Editing);
    this.ClearMultiUIBindings();
    ((Control) this.textTwoText1).Enabled = true;
    ((Control) this.textTwoText2).Enabled = true;
    ((TextEditorControlBase) this.textTwoText1).Focus();
    ((TextEditorControlBase) this.textTwoText1).SelectAll();
  }

  private void dbSaveMulti_ClickedNew(object sender, EventArgs e)
  {
    this.SetDBSaveUIState(ClaimsAdministrationPortal.DBSaveUIState.Adding);
    this.ClearMultiUIBindings();
    this.ClearMultiView();
    ((Control) this.textTwoText1).Enabled = true;
    ((Control) this.textTwoText2).Enabled = true;
    ((TextEditorControlBase) this.textTwoText1).Focus();
    ((TextEditorControlBase) this.textTwoText1).SelectAll();
  }

  private void dbSaveMulti_ClickedSave(object sender, EventArgs e)
  {
    switch (this.PortalType)
    {
      case ClaimsAdministrationPortal.AdministrationPortalType.CatastropheCodes:
        this.AddEditCatastropheCode();
        break;
      case ClaimsAdministrationPortal.AdministrationPortalType.CoverageTypes:
        this.AddEditCoverageType();
        break;
    }
  }

  private void dbSaveUIExtendedMulti_ClickedCancel(object sender, EventArgs e)
  {
    this.SetDBSaveUIState(ClaimsAdministrationPortal.DBSaveUIState.None);
    this.ClearExtendedMultiUIBindings();
    this.ClearExtendedMultiView();
    this.BindUI();
    this.InitUIEnabled();
  }

  private void dbSaveUIExtendedMulti_ClickedDelete(object sender, EventArgs e) => this.Delete();

  private void dbSaveUIExtendedMulti_ClickedEdit(object sender, EventArgs e)
  {
    this.SetDBSaveUIState(ClaimsAdministrationPortal.DBSaveUIState.Editing);
    this.ClearExtendedMultiUIBindings();
    ((Control) this.comboExtendedMulti).Enabled = true;
    ((Control) this.textExtendedMulti1).Enabled = true;
    ((UltraCombo) this.comboExtendedMulti).Focus();
  }

  private void dbSaveUIExtendedMulti_ClickedNew(object sender, EventArgs e)
  {
    this.SetDBSaveUIState(ClaimsAdministrationPortal.DBSaveUIState.Adding);
    this.ClearExtendedMultiUIBindings();
    this.ClearExtendedMultiView();
    ((Control) this.comboExtendedMulti).Enabled = true;
    ((Control) this.textExtendedMulti1).Enabled = true;
    ((UltraCombo) this.comboExtendedMulti).Focus();
  }

  private void dbSaveUIExtendedMulti_ClickedSave(object sender, EventArgs e)
  {
    if (((UltraDropDownBase) this.comboExtendedMulti).SelectedRow == null)
    {
      int num = (int) MessageBox.Show(Resources.CLAIMSADMIN_MULTIEXTENDED_LINKNOTSELECTED, Resources.ERROR_REQUIREDFIELD_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else if (this.PortalType == ClaimsAdministrationPortal.AdministrationPortalType.CoverageTypeDescriptions)
    {
      this.AddEditCoverageTypeDescription();
    }
    else
    {
      if (this.PortalType != ClaimsAdministrationPortal.AdministrationPortalType.ReservePaymentSubTypes)
        return;
      this.AddReservePaymentSubType();
    }
  }

  private void dbSaveUIAddress_ClickingSave(object sender, CancelEventArgs e)
  {
    if (this.VerifyAddress())
      return;
    e.Cancel = true;
  }

  private void dbSaveUIAddress_ClickedEdit(object sender, EventArgs e)
  {
    this.SetDBSaveUIState(ClaimsAdministrationPortal.DBSaveUIState.Editing);
    this.ClearAddressViewUIBindings();
    this.ToggleAddressViewEnabled(true);
    ((Control) this.optionEntityType).Focus();
  }

  private void dbSaveUIAddress_ClickedDelete(object sender, EventArgs e) => this.Delete();

  private void dbSaveUIAddress_ClickedSave(object sender, EventArgs e)
  {
    if (this.PortalType == ClaimsAdministrationPortal.AdministrationPortalType.ManagedCareFacilities)
      this.AddEditManagedCareFacility();
    else
      this.AddEditOutsideAdjuster();
  }

  private void dbSaveUIAddress_ClickedNew(object sender, EventArgs e)
  {
    this.SetDBSaveUIState(ClaimsAdministrationPortal.DBSaveUIState.Adding);
    this.ClearAddressViewUIBindings();
    this.ToggleAddressViewEnabled(true);
    this.mgaPhoneNumberEntry1.SetAddressId(-1);
    this.ClearAddressView();
    ((Control) this.optionEntityType).Focus();
  }

  private void dbSaveUIAddress_ClickedCancel(object sender, EventArgs e)
  {
    this.SetDBSaveUIState(ClaimsAdministrationPortal.DBSaveUIState.None);
    this.ClearAddressViewUIBindings();
    this.ClearAddressView();
    this.BindUI();
    this.InitUIEnabled();
    if (((SparseCollectionBase) this.gridView.Selected.Rows).Count > 0)
      this.mgaPhoneNumberEntry1.SetAddressId((int) this.gridView.Selected.Rows[0].Cells["AddressId"].Value);
    ((Control) this.gridView).Focus();
  }

  protected virtual void Delete()
  {
    switch (this.PortalType)
    {
      case ClaimsAdministrationPortal.AdministrationPortalType.AccidentTypes:
        this.DeleteAccidentType((int) this.gridView.Selected.Rows[0].Cells["AccidentTypeId"].Value, ((Control) this.textOneText1).Text);
        break;
      case ClaimsAdministrationPortal.AdministrationPortalType.CatastropheCodes:
        this.DeleteCatastropheCode((int) this.gridView.Selected.Rows[0].Cells["CatastropheCodeId"].Value, ((Control) this.textTwoText1).Text);
        break;
      case ClaimsAdministrationPortal.AdministrationPortalType.CoverageTypes:
        this.DeleteCoverageType((int) this.gridView.Selected.Rows[0].Cells["CoverageTypeId"].Value, ((Control) this.textTwoText1).Text);
        break;
      case ClaimsAdministrationPortal.AdministrationPortalType.CoverageTypeDescriptions:
        this.DeleteCoverageTypeDescription((int) this.gridView.Selected.Rows[0].Cells["CoverageTypeDescriptionId"].Value, ((Control) this.textExtendedMulti1).Text);
        break;
      case ClaimsAdministrationPortal.AdministrationPortalType.LossTypes:
        this.DeleteLossType((int) this.gridView.Selected.Rows[0].Cells["LossTypeId"].Value, ((Control) this.textOneText1).Text);
        break;
      case ClaimsAdministrationPortal.AdministrationPortalType.ManagedCareFacilities:
        this.DeleteManagedCareFacility((int) this.gridView.Selected.Rows[0].Cells["ManagedCareId"].Value, this.gridView.Selected.Rows[0].Cells["FacilityName"].Value.ToString());
        break;
      case ClaimsAdministrationPortal.AdministrationPortalType.OutsideAdjusters:
        this.DeleteOutsideAdjuster(new Guid(this.gridView.Selected.Rows[0].Cells["AdjusterGuid"].Value.ToString()), string.IsNullOrEmpty(this.gridView.Selected.Rows[0].Cells["Company"].Value.ToString()) ? $"{this.gridView.Selected.Rows[0].Cells["FirstName"].Value.ToString()} {this.gridView.Selected.Rows[0].Cells["LastName"].Value.ToString()}" : this.gridView.Selected.Rows[0].Cells["Company"].Value.ToString());
        break;
      case ClaimsAdministrationPortal.AdministrationPortalType.ReservePaymentTypes:
        this.DeleteReservePaymentType((int) this.gridView.Selected.Rows[0].Cells["ResPayTypeId"].Value, ((Control) this.textOneText1).Text);
        break;
      case ClaimsAdministrationPortal.AdministrationPortalType.ReservePaymentSubTypes:
        this.DeleteReservePaymentSubType((int) this.gridView.Selected.Rows[0].Cells["ResPaySubTypeId"].Value, ((Control) this.textExtendedMulti1).Text);
        break;
      case ClaimsAdministrationPortal.AdministrationPortalType.SettlementTypes:
        this.DeleteSettlementType((int) this.gridView.Selected.Rows[0].Cells["SettlementTypeId"].Value, ((Control) this.textOneText1).Text);
        break;
    }
  }

  protected virtual void AddEditAccidentType()
  {
    try
    {
      if (this._DBSaveUIState == ClaimsAdministrationPortal.DBSaveUIState.Adding)
        DefaultDatabase.ExecuteNonQuery("spClaims_InsertAccidentType", new object[2]
        {
          (object) "@accidentType",
          (object) ((Control) this.textOneText1).Text
        });
      else if (this._DBSaveUIState == ClaimsAdministrationPortal.DBSaveUIState.Editing)
        DefaultDatabase.ExecuteNonQuery("spClaims_UpdateAccidentType", new object[4]
        {
          (object) "@AccidentTypeId",
          (object) (int) this.gridView.Selected.Rows[0].Cells["AccidentTypeId"].Value,
          (object) "@accidentType",
          (object) ((Control) this.textOneText1).Text
        });
      this.FinalizeDatabaseOperation((DataTable) this.dsClaimsAdministration1.AccidentTypes);
    }
    finally
    {
      this.SetDBSaveUIState(ClaimsAdministrationPortal.DBSaveUIState.None);
      this.ClearSingleUIBindings();
      this.ClearSingleView();
      this.InitUIEnabled();
      this.BindUI();
    }
  }

  protected virtual void DeleteAccidentType(int accidentTypeId, string accidentType)
  {
    if (MessageBox.Show($"This will permanently delete the {accidentType} accident type. Do you wish to continue?", "Delete Accident Type?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
      return;
    try
    {
      DefaultDatabase.ExecuteNonQuery("spClaims_DeleteAccidentType", new object[2]
      {
        (object) "@AccidentTypeId",
        (object) accidentTypeId
      });
      this.FinalizeDatabaseOperation((DataTable) this.dsClaimsAdministration1.AccidentTypes);
    }
    finally
    {
      this.SetDBSaveUIState(ClaimsAdministrationPortal.DBSaveUIState.None);
      this.ClearSingleUIBindings();
      this.ClearSingleView();
      this.BindUI();
      this.InitUIEnabled();
    }
  }

  private void AddEditSettlementType()
  {
    try
    {
      if (this._DBSaveUIState == ClaimsAdministrationPortal.DBSaveUIState.Adding)
        DefaultDatabase.ExecuteNonQuery("spClaims_InsertSettlementType", new object[2]
        {
          (object) "@SettlementType",
          (object) ((Control) this.textOneText1).Text
        });
      else if (this._DBSaveUIState == ClaimsAdministrationPortal.DBSaveUIState.Editing)
        DefaultDatabase.ExecuteNonQuery("spClaims_UpdateSettlementType", new object[4]
        {
          (object) "@SettlementTypeId",
          (object) (int) this.gridView.Selected.Rows[0].Cells["SettlementTypeId"].Value,
          (object) "@SettlementType",
          (object) ((Control) this.textOneText1).Text
        });
      this.FinalizeDatabaseOperation((DataTable) this.dsClaimsAdministration1.SettlementTypes);
    }
    finally
    {
      this.SetDBSaveUIState(ClaimsAdministrationPortal.DBSaveUIState.None);
      this.ClearSingleUIBindings();
      this.ClearSingleView();
      this.InitUIEnabled();
      this.BindUI();
    }
  }

  private void DeleteSettlementType(int settlementTypeId, string settlementType)
  {
    if (MessageBox.Show($"This will permanently delete the {settlementType} settlement type. Do you wish to continue?", "Delete Settlement Type?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
      return;
    try
    {
      DefaultDatabase.ExecuteNonQuery("spClaims_DeleteSettlementType", new object[2]
      {
        (object) "@SettlementTypeId",
        (object) settlementTypeId
      });
      this.FinalizeDatabaseOperation((DataTable) this.dsClaimsAdministration1.SettlementTypes);
    }
    finally
    {
      this.SetDBSaveUIState(ClaimsAdministrationPortal.DBSaveUIState.None);
      this.ClearSingleUIBindings();
      this.ClearSingleView();
      this.BindUI();
      this.InitUIEnabled();
    }
  }

  protected virtual void AddEditCoverageType()
  {
    try
    {
      if (this._DBSaveUIState == ClaimsAdministrationPortal.DBSaveUIState.Adding)
        DefaultDatabase.ExecuteNonQuery("spClaims_InsertCoverageType", new object[4]
        {
          (object) "@CoverageType",
          (object) ((Control) this.textTwoText1).Text,
          (object) "@CoverageTypeDescription",
          (object) ((Control) this.textTwoText2).Text
        });
      else
        DefaultDatabase.ExecuteNonQuery("spClaims_UpdateCoverageType", new object[6]
        {
          (object) "@CoverageTypeId",
          (object) (int) this.gridView.Selected.Rows[0].Cells["CoverageTypeId"].Value,
          (object) "@CoverageType",
          (object) ((Control) this.textTwoText1).Text,
          (object) "@CoverageTypeDescription",
          (object) ((Control) this.textTwoText2).Text
        });
      this.FinalizeDatabaseOperation((DataTable) this.dsClaimsAdministration1.CoverageTypes);
    }
    finally
    {
      this.SetDBSaveUIState(ClaimsAdministrationPortal.DBSaveUIState.None);
      this.ClearMultiUIBindings();
      this.ClearMultiView();
      this.BindUI();
      this.InitUIEnabled();
    }
  }

  protected virtual void DeleteCoverageType(int coverageTypeId, string coverageType)
  {
    if (MessageBox.Show($"This will permanently delete the {coverageType} coverage type. Do you wish to continue?", "Delete Coverage Type?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
      return;
    try
    {
      DefaultDatabase.ExecuteNonQuery("spClaims_DeleteCoverageType", new object[2]
      {
        (object) "@CoverageTypeId",
        (object) coverageTypeId
      });
      this.FinalizeDatabaseOperation((DataTable) this.dsClaimsAdministration1.CoverageTypes);
    }
    finally
    {
      this.SetDBSaveUIState(ClaimsAdministrationPortal.DBSaveUIState.None);
      this.ClearMultiUIBindings();
      this.ClearMultiView();
      this.BindUI();
      this.InitUIEnabled();
    }
  }

  private void AddEditCoverageTypeDescription()
  {
    try
    {
      if (this._DBSaveUIState == ClaimsAdministrationPortal.DBSaveUIState.Adding)
        DefaultDatabase.ExecuteNonQuery("spClaims_InsertCoverageTypeDescription", new object[4]
        {
          (object) "@CoverageTypeId",
          (object) (int) ((UltraCombo) this.comboExtendedMulti).Value,
          (object) "@CoverageTypeDescription",
          (object) ((Control) this.textExtendedMulti1).Text
        });
      else
        DefaultDatabase.ExecuteNonQuery("spClaims_UpdateCoverageTypeDescription", new object[6]
        {
          (object) "@CoverageTypeDescriptionId",
          (object) (int) this.gridView.Selected.Rows[0].Cells["CoverageTypeDescriptionId"].Value,
          (object) "@CoverageTypeId",
          (object) (int) ((UltraCombo) this.comboExtendedMulti).Value,
          (object) "@CoverageTypeDescription",
          (object) ((Control) this.textExtendedMulti1).Text
        });
      this.FinalizeDatabaseOperation((DataTable) this.dsClaimsAdministration1.CoverageTypeDescriptions);
    }
    catch (Exception ex)
    {
      int num = (int) MessageBox.Show(ex.Message);
    }
    finally
    {
      this.SetDBSaveUIState(ClaimsAdministrationPortal.DBSaveUIState.None);
      this.ClearMultiUIBindings();
      this.ClearMultiView();
      this.BindUI();
      this.InitUIEnabled();
    }
  }

  private void DeleteCoverageTypeDescription(
    int coverageTypeDescriptionId,
    string coverageTypeDescription)
  {
    if (MessageBox.Show($"This will permanently delete the {coverageTypeDescription} coverage type description. Do you wish to continue?", "Delete Coverage Type?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
      return;
    try
    {
      DefaultDatabase.ExecuteNonQuery("spClaims_DeleteCoverageTypeDescription", new object[2]
      {
        (object) "@CoverageTypeDescriptionId",
        (object) coverageTypeDescriptionId
      });
      this.FinalizeDatabaseOperation((DataTable) this.dsClaimsAdministration1.CoverageTypeDescriptions);
    }
    finally
    {
      this.SetDBSaveUIState(ClaimsAdministrationPortal.DBSaveUIState.None);
      this.ClearExtendedMultiUIBindings();
      this.ClearExtendedMultiView();
      this.BindUI();
      this.InitUIEnabled();
    }
  }

  private void AddEditCatastropheCode()
  {
    try
    {
      if (this._DBSaveUIState == ClaimsAdministrationPortal.DBSaveUIState.Adding)
        DefaultDatabase.ExecuteNonQuery("spClaims_InsertCatastropheCode", new object[4]
        {
          (object) "@CatastropheCode",
          (object) ((Control) this.textTwoText1).Text,
          (object) "@CatastropheCodeDescription",
          (object) ((Control) this.textTwoText2).Text
        });
      else
        DefaultDatabase.ExecuteNonQuery("spClaims_UpdateCatastropheCode", new object[6]
        {
          (object) "@CatastropheCodeId",
          (object) (int) this.gridView.Selected.Rows[0].Cells["CatastropheCodeId"].Value,
          (object) "@CatastropheCode",
          (object) ((Control) this.textTwoText1).Text,
          (object) "@CatastropheCodeDescription",
          (object) ((Control) this.textTwoText2).Text
        });
      this.FinalizeDatabaseOperation((DataTable) this.dsClaimsAdministration1.CatastropheCodes);
    }
    finally
    {
      this.SetDBSaveUIState(ClaimsAdministrationPortal.DBSaveUIState.None);
      this.ClearMultiUIBindings();
      this.ClearMultiView();
      this.BindUI();
      this.InitUIEnabled();
    }
  }

  private void DeleteCatastropheCode(int catastropheCodeId, string catastropheCode)
  {
    if (MessageBox.Show($"This will permanently delete the {catastropheCode} catastrophe code. Do you wish to continue?", "Delete Catastrophe Code?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
      return;
    try
    {
      DefaultDatabase.ExecuteNonQuery("spClaims_DeleteCatastropheCode", new object[2]
      {
        (object) "@CatastropheCodeId",
        (object) catastropheCodeId
      });
      this.FinalizeDatabaseOperation((DataTable) this.dsClaimsAdministration1.CatastropheCodes);
    }
    finally
    {
      this.SetDBSaveUIState(ClaimsAdministrationPortal.DBSaveUIState.None);
      this.ClearMultiUIBindings();
      this.ClearMultiView();
      this.BindUI();
      this.InitUIEnabled();
    }
  }

  private void AddEditLossType()
  {
    try
    {
      if (this._DBSaveUIState == ClaimsAdministrationPortal.DBSaveUIState.Adding)
        DefaultDatabase.ExecuteNonQuery("spClaims_InsertLossType", new object[2]
        {
          (object) "@LossType",
          (object) ((Control) this.textOneText1).Text
        });
      else if (this._DBSaveUIState == ClaimsAdministrationPortal.DBSaveUIState.Editing)
        DefaultDatabase.ExecuteNonQuery("spClaims_UpdateLossType", new object[4]
        {
          (object) "@LossTypeId",
          (object) (int) this.gridView.Selected.Rows[0].Cells["LossTypeId"].Value,
          (object) "@LossType",
          (object) ((Control) this.textOneText1).Text
        });
      this.FinalizeDatabaseOperation((DataTable) this.dsClaimsAdministration1.LossTypes);
    }
    finally
    {
      this.SetDBSaveUIState(ClaimsAdministrationPortal.DBSaveUIState.None);
      this.ClearSingleUIBindings();
      this.ClearSingleView();
      this.InitUIEnabled();
      this.BindUI();
    }
  }

  private void DeleteLossType(int lossTypeId, string lossType)
  {
    if (MessageBox.Show($"This will permanently delete the {lossType} loss type. Do you wish to continue?", "Delete Loss Type?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
      return;
    try
    {
      DefaultDatabase.ExecuteNonQuery("spClaims_DeleteLossType", new object[2]
      {
        (object) "@LossTypeId",
        (object) lossTypeId
      });
      this.FinalizeDatabaseOperation((DataTable) this.dsClaimsAdministration1.LossTypes);
    }
    finally
    {
      this.SetDBSaveUIState(ClaimsAdministrationPortal.DBSaveUIState.None);
      this.ClearSingleUIBindings();
      this.ClearSingleView();
      this.BindUI();
      this.InitUIEnabled();
    }
  }

  private void AddEditManagedCareFacility()
  {
    try
    {
      if (this._DBSaveUIState == ClaimsAdministrationPortal.DBSaveUIState.Adding)
        DefaultDatabase.ExecuteTransaction((EventHandler<ExecuteTransactionEventArgs>) ((sender, e) =>
        {
          this.mgaPhoneNumberEntry1.NumberManager.SaveChanges((int) DefaultDatabase.ExecuteScalar("spClaims_InsertManagedCareFacility", new object[32 /*0x20*/]
          {
            (object) "@FacilityName",
            (object) ((Control) this.textCorporationName).Text,
            (object) "@WebAddress",
            (object) string.Empty,
            (object) "@Address1",
            (object) this.addResolver.Address1,
            (object) "@Address2",
            (object) this.addResolver.Address2,
            (object) "@City",
            (object) this.addResolver.City,
            (object) "@State",
            (object) this.addResolver.State,
            (object) "@ZipCode",
            this.addResolver.ISOCountryCode == "USA" ? (object) this.addResolver.ZipCode : (object) string.Empty,
            (object) "@ZipCodeExtension",
            this.addResolver.ISOCountryCode == "USA" ? (object) this.addResolver.ZipCodeExtension : (object) string.Empty,
            (object) "@IsInternational",
            (object) (this.addResolver.ISOCountryCode != "USA"),
            (object) "@InternationalZipCode",
            this.addResolver.ISOCountryCode != "USA" ? (object) this.addResolver.ZipCode : (object) string.Empty,
            (object) "@ISOCountryCode",
            (object) this.addResolver.ISOCountryCode,
            (object) "@EntityType",
            (object) this.optionEntityType.Value.ToString(),
            (object) "@FEIN",
            (object) ((Control) this.maskedEditSSNFEIN).Text,
            (object) "@DateIncorporated",
            ((UltraDateTimeEditor) this.dateTimeIncorporated).Value,
            (object) "@UserGuid",
            (object) CurrentUser.Instance.UserGUID,
            (object) "@EmailAddress",
            (object) ((Control) this.textEmailAddress).Text
          }));
          e.Transaction.Commit();
        }));
      else if (this._DBSaveUIState == ClaimsAdministrationPortal.DBSaveUIState.Editing)
        DefaultDatabase.ExecuteTransaction((EventHandler<ExecuteTransactionEventArgs>) ((sender, e) =>
        {
          DefaultDatabase.ExecuteNonQuery("spClaims_UpdateManagedCareFacility", new object[36]
          {
            (object) "@ManagedCareId",
            (object) (int) this.gridView.Selected.Rows[0].Cells["ManagedCareId"].Value,
            (object) "@AddressId",
            (object) (int) this.gridView.Selected.Rows[0].Cells["AddressId"].Value,
            (object) "@FacilityName",
            (object) ((Control) this.textCorporationName).Text,
            (object) "@WebAddress",
            (object) string.Empty,
            (object) "@Address1",
            (object) this.addResolver.Address1,
            (object) "@Address2",
            (object) this.addResolver.Address2,
            (object) "@City",
            (object) this.addResolver.City,
            (object) "@State",
            (object) this.addResolver.State,
            (object) "@ZipCode",
            this.addResolver.ISOCountryCode == "USA" ? (object) this.addResolver.ZipCode : (object) string.Empty,
            (object) "@ZipCodeExtension",
            this.addResolver.ISOCountryCode == "USA" ? (object) this.addResolver.ZipCodeExtension : (object) string.Empty,
            (object) "@IsInternational",
            (object) (this.addResolver.ISOCountryCode != "USA"),
            (object) "@InternationalZipCode",
            this.addResolver.ISOCountryCode != "USA" ? (object) this.addResolver.ZipCode : (object) string.Empty,
            (object) "@ISOCountryCode",
            (object) this.addResolver.ISOCountryCode,
            (object) "@EntityType",
            (object) this.optionEntityType.Value.ToString(),
            (object) "@FEIN",
            (object) ((Control) this.maskedEditSSNFEIN).Text,
            (object) "@DateIncorporated",
            (object) ((UltraDateTimeEditor) this.dateTimeIncorporated).DateTime,
            (object) "@UserGuid",
            (object) CurrentUser.Instance.UserGUID,
            (object) "@EmailAddress",
            (object) ((Control) this.textEmailAddress).Text
          });
          this.mgaPhoneNumberEntry1.NumberManager.SaveChanges();
          e.Transaction.Commit();
        }));
      this.FinalizeDatabaseOperation((DataTable) this.dsClaimsAdministration1.ManagedCareFacilities, (DataTable) this.dsClaimsAdministration1.ManagedCareAddresses, (DataTable) this.dsClaimsAdministration1.ManagedCareAddressPhoneNumbers);
    }
    finally
    {
      this.SetDBSaveUIState(ClaimsAdministrationPortal.DBSaveUIState.None);
      this.ClearAddressViewUIBindings();
      this.ClearAddressView();
      this.InitUIEnabled();
      this.BindUI();
      this.LoadInternationalZipCode();
    }
  }

  private void DeleteManagedCareFacility(int manageCareId, string facilityName)
  {
    if (MessageBox.Show($"This will permanently delete the {facilityName} managed care facility. Do you wish to continue?", "Delete Managed Care Facility?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
      return;
    try
    {
      DefaultDatabase.ExecuteTransaction((EventHandler<ExecuteTransactionEventArgs>) ((sender, e) =>
      {
        DefaultDatabase.ExecuteNonQuery("spClaims_DeleteManagedCareFacility", new object[2]
        {
          (object) "@ManagedCareId",
          (object) manageCareId
        });
        e.Transaction.Commit();
      }));
      this.FinalizeDatabaseOperation((DataTable) this.dsClaimsAdministration1.ManagedCareFacilities, (DataTable) this.dsClaimsAdministration1.ManagedCareAddresses, (DataTable) this.dsClaimsAdministration1.ManagedCareAddressPhoneNumbers);
    }
    finally
    {
      this.SetDBSaveUIState(ClaimsAdministrationPortal.DBSaveUIState.None);
      this.ClearAddressViewUIBindings();
      this.ClearAddressView();
      this.BindUI();
      this.InitUIEnabled();
    }
  }

  private void AddEditOutsideAdjuster()
  {
    try
    {
      if (this._DBSaveUIState == ClaimsAdministrationPortal.DBSaveUIState.Adding)
        DefaultDatabase.ExecuteTransaction((EventHandler<ExecuteTransactionEventArgs>) ((sender, e) =>
        {
          this.mgaPhoneNumberEntry1.NumberManager.SaveChanges((int) DefaultDatabase.ExecuteScalar("spClaims_InsertOutsideAdjuster", new object[34]
          {
            (object) "@CompanyName",
            (object) (this.optionEntityType.Value.ToString() == "C" ? (SqlString) ((Control) this.textCorporationName).Text : SqlString.Null),
            (object) "@FirstName",
            (object) (this.optionEntityType.Value.ToString() == "I" ? (SqlString) ((Control) this.textFirstName).Text : SqlString.Null),
            (object) "@MiddleName",
            (object) (this.optionEntityType.Value.ToString() == "I" ? (SqlString) ((Control) this.textMiddleName).Text : SqlString.Null),
            (object) "@LastName",
            (object) (this.optionEntityType.Value.ToString() == "I" ? (SqlString) ((Control) this.textLastName).Text : SqlString.Null),
            (object) "@Address1",
            (object) this.addResolver.Address1,
            (object) "@Address2",
            (object) this.addResolver.Address2,
            (object) "@City",
            (object) this.addResolver.City,
            (object) "@State",
            (object) this.addResolver.State,
            (object) "@ZipCode",
            this.addResolver.ISOCountryCode == "USA" ? (object) this.addResolver.ZipCode : (object) string.Empty,
            (object) "@ZipCodeExtension",
            this.addResolver.ISOCountryCode == "USA" ? (object) this.addResolver.ZipCodeExtension : (object) string.Empty,
            (object) "@IsInternational",
            (object) (this.addResolver.ISOCountryCode != "USA"),
            (object) "@InternationalZipCode",
            this.addResolver.ISOCountryCode != "USA" ? (object) this.addResolver.ZipCode : (object) string.Empty,
            (object) "@ISOCountryCode",
            (object) this.addResolver.ISOCountryCode,
            (object) "@EntityType",
            (object) this.optionEntityType.Value.ToString(),
            (object) "@FEINSSN",
            (object) ((Control) this.maskedEditSSNFEIN).Text,
            (object) "@UserGuid",
            (object) CurrentUser.Instance.UserGUID,
            (object) "@EmailAddress",
            (object) ((Control) this.textEmailAddress).Text
          }));
          e.Transaction.Commit();
        }));
      else if (this._DBSaveUIState == ClaimsAdministrationPortal.DBSaveUIState.Editing)
        DefaultDatabase.ExecuteTransaction((EventHandler<ExecuteTransactionEventArgs>) ((sender, e) =>
        {
          DefaultDatabase.ExecuteNonQuery("spClaims_UpdateOutsideAdjuster", new object[38]
          {
            (object) "@AdjusterGuid",
            (object) new Guid(this.gridView.Selected.Rows[0].Cells["AdjusterGuid"].Value.ToString()),
            (object) "@AddressId",
            (object) (int) this.gridView.Selected.Rows[0].Cells["AddressId"].Value,
            (object) "@CompanyName",
            (object) (this.optionEntityType.Value.ToString() == "C" ? (SqlString) ((Control) this.textCorporationName).Text : SqlString.Null),
            (object) "@FirstName",
            (object) (this.optionEntityType.Value.ToString() == "I" ? (SqlString) ((Control) this.textFirstName).Text : SqlString.Null),
            (object) "@MiddleName",
            (object) (this.optionEntityType.Value.ToString() == "I" ? (SqlString) ((Control) this.textMiddleName).Text : SqlString.Null),
            (object) "@Lastname",
            (object) (this.optionEntityType.Value.ToString() == "I" ? (SqlString) ((Control) this.textLastName).Text : SqlString.Null),
            (object) "@Address1",
            (object) this.addResolver.Address1,
            (object) "@Address2",
            (object) this.addResolver.Address2,
            (object) "@City",
            (object) this.addResolver.City,
            (object) "@State",
            (object) this.addResolver.State,
            (object) "@ZipCode",
            this.addResolver.ISOCountryCode == "USA" ? (object) this.addResolver.ZipCode : (object) string.Empty,
            (object) "@ZipCodeExtension",
            this.addResolver.ISOCountryCode == "USA" ? (object) this.addResolver.ZipCodeExtension : (object) string.Empty,
            (object) "@IsInternational",
            (object) (this.addResolver.ISOCountryCode != "USA"),
            (object) "@InternationalZipCode",
            this.addResolver.ISOCountryCode != "USA" ? (object) this.addResolver.ZipCode : (object) string.Empty,
            (object) "@ISOCountryCode",
            (object) this.addResolver.ISOCountryCode,
            (object) "@EntityType",
            (object) this.optionEntityType.Value.ToString(),
            (object) "@FEINSSN",
            (object) ((Control) this.maskedEditSSNFEIN).Text,
            (object) "@UserGuid",
            (object) CurrentUser.Instance.UserGUID,
            (object) "@EmailAddress",
            (object) ((Control) this.textEmailAddress).Text
          });
          this.mgaPhoneNumberEntry1.NumberManager.SaveChanges();
          e.Transaction.Commit();
        }));
      this.FinalizeDatabaseOperation((DataTable) this.dsClaimsAdministration1.OutsideAdjusters, (DataTable) this.dsClaimsAdministration1.OutsideAdjusterAddresses, (DataTable) this.dsClaimsAdministration1.OutsideAdjusterAddressPhoneNumbers);
    }
    finally
    {
      this.SetDBSaveUIState(ClaimsAdministrationPortal.DBSaveUIState.None);
      this.ClearAddressViewUIBindings();
      this.ClearAddressView();
      this.InitUIEnabled();
      this.BindUI();
      this.LoadInternationalZipCode();
    }
  }

  private void DeleteOutsideAdjuster(Guid adjusterGuid, string adjusterName)
  {
    if (MessageBox.Show($"This will permanently delete the {adjusterName} outside adjuster. Do you wish to continue?", "Delete Outside Adjuster?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
      return;
    try
    {
      DefaultDatabase.ExecuteTransaction((EventHandler<ExecuteTransactionEventArgs>) ((sender, e) =>
      {
        DefaultDatabase.ExecuteNonQuery("spClaims_DeleteOutsideAdjuster", new object[2]
        {
          (object) "@AdjusterGuid",
          (object) adjusterGuid
        });
        e.Transaction.Commit();
      }));
      this.FinalizeDatabaseOperation((DataTable) this.dsClaimsAdministration1.OutsideAdjusters, (DataTable) this.dsClaimsAdministration1.OutsideAdjusterAddresses, (DataTable) this.dsClaimsAdministration1.OutsideAdjusterAddressPhoneNumbers);
    }
    finally
    {
      this.SetDBSaveUIState(ClaimsAdministrationPortal.DBSaveUIState.None);
      this.ClearAddressViewUIBindings();
      this.ClearAddressView();
      this.BindUI();
      this.InitUIEnabled();
    }
  }

  protected virtual void AddReservePaymentType()
  {
    try
    {
      if (this._DBSaveUIState == ClaimsAdministrationPortal.DBSaveUIState.Adding)
        DefaultDatabase.ExecuteNonQuery("spClaims_InsertReservePaymentType", new object[2]
        {
          (object) "@ResPayTypeDescription",
          (object) ((Control) this.textOneText1).Text
        });
      else if (this._DBSaveUIState == ClaimsAdministrationPortal.DBSaveUIState.Editing)
        DefaultDatabase.ExecuteNonQuery("spClaims_UpdateReservePaymentType", new object[4]
        {
          (object) "@ResPayTypeId",
          (object) (int) this.gridView.Selected.Rows[0].Cells["ResPayTypeId"].Value,
          (object) "@ResPayTypeDescription",
          (object) ((Control) this.textOneText1).Text
        });
      this.FinalizeDatabaseOperation((DataTable) this.dsClaimsAdministration1.ReservePaymentTypes);
    }
    finally
    {
      this.SetDBSaveUIState(ClaimsAdministrationPortal.DBSaveUIState.None);
      this.ClearSingleUIBindings();
      this.ClearSingleView();
      this.InitUIEnabled();
      this.BindUI();
    }
  }

  protected virtual void DeleteReservePaymentType(
    int reservePayementTypeId,
    string reservePaymentType)
  {
    if (MessageBox.Show($"This will permanently delete the {reservePaymentType} reserve/payment type. Do you wish to continue?", "Delete Reserve/Payment Type?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
      return;
    try
    {
      DefaultDatabase.ExecuteNonQuery("spClaims_DeleteReservePaymentType", new object[2]
      {
        (object) "@ResPayTypeId",
        (object) reservePayementTypeId
      });
      this.FinalizeDatabaseOperation((DataTable) this.dsClaimsAdministration1.ReservePaymentTypes);
    }
    finally
    {
      this.SetDBSaveUIState(ClaimsAdministrationPortal.DBSaveUIState.None);
      this.ClearSingleUIBindings();
      this.ClearSingleView();
      this.BindUI();
      this.InitUIEnabled();
    }
  }

  private void AddReservePaymentSubType()
  {
    try
    {
      if (this._DBSaveUIState == ClaimsAdministrationPortal.DBSaveUIState.Adding)
        DefaultDatabase.ExecuteNonQuery("spClaims_InsertReservePaymentSubType", new object[4]
        {
          (object) "@ResPayTypeId",
          (object) (int) ((UltraCombo) this.comboExtendedMulti).Value,
          (object) "@ResPaySubTypeDescription",
          (object) ((Control) this.textExtendedMulti1).Text
        });
      else
        DefaultDatabase.ExecuteNonQuery("spClaims_UpdateReservePaymentSubType", new object[6]
        {
          (object) "@ResPaySubTypeId",
          (object) (int) this.gridView.Selected.Rows[0].Cells["ResPaySubTypeId"].Value,
          (object) "@ResPayTypeId",
          (object) (int) ((UltraCombo) this.comboExtendedMulti).Value,
          (object) "@ResPaySubTypeDescription",
          (object) ((Control) this.textExtendedMulti1).Text
        });
      this.FinalizeDatabaseOperation((DataTable) this.dsClaimsAdministration1.ReservePaymentSubTypes);
    }
    catch (Exception ex)
    {
      int num = (int) MessageBox.Show(ex.Message);
    }
    finally
    {
      this.SetDBSaveUIState(ClaimsAdministrationPortal.DBSaveUIState.None);
      this.ClearMultiUIBindings();
      this.ClearMultiView();
      this.BindUI();
      this.InitUIEnabled();
    }
  }

  private void DeleteReservePaymentSubType(
    int reservePaymentSubTypeId,
    string reservePaymentSubType)
  {
    if (MessageBox.Show($"This will permanently delete the {reservePaymentSubType} reserve/payment sub type description. Do you wish to continue?", "Delete Reserve/Payment Sub Type?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
      return;
    try
    {
      DefaultDatabase.ExecuteNonQuery("spClaims_DeleteReservePaymentSubType", new object[2]
      {
        (object) "@ResPaySubTypeId",
        (object) reservePaymentSubTypeId
      });
      this.FinalizeDatabaseOperation((DataTable) this.dsClaimsAdministration1.ReservePaymentSubTypes);
    }
    finally
    {
      this.SetDBSaveUIState(ClaimsAdministrationPortal.DBSaveUIState.None);
      this.ClearExtendedMultiUIBindings();
      this.ClearExtendedMultiView();
      this.BindUI();
      this.InitUIEnabled();
    }
  }

  protected virtual void gridView_BeforeSelectChange(object sender, BeforeSelectChangeEventArgs e)
  {
    if (this._DBSaveUIState == ClaimsAdministrationPortal.DBSaveUIState.None)
      return;
    this.BindUI();
    this.InitUIEnabled();
    this._DBSaveUIState = ClaimsAdministrationPortal.DBSaveUIState.None;
  }

  private void gridView_AfterSelectChange(object sender, AfterSelectChangeEventArgs e)
  {
    this.LoadInternationalZipCode();
  }

  private void optionEntityType_ValueChanged(object sender, EventArgs e)
  {
    if (this.optionEntityType.Value == null)
      this.optionEntityType.Value = (object) "I";
    ((Control) this.textCorporationName).Enabled = this.optionEntityType.Value.ToString() == "C";
    ((Control) this.textFirstName).Enabled = this.optionEntityType.Value.ToString() == "I";
    ((Control) this.textMiddleName).Enabled = this.optionEntityType.Value.ToString() == "I";
    ((Control) this.textLastName).Enabled = this.optionEntityType.Value.ToString() == "I";
    ((UltraMaskedEdit) this.maskedEditSSNFEIN).InputMask = this.optionEntityType.Value.ToString() == "C" ? "99-9999999" : "999-99-9999";
  }

  private void ultraToolbarsManager1_BeforeToolDropdown(
    object sender,
    BeforeToolDropdownEventArgs e)
  {
    ((CancelEventArgs) e).Cancel = this._portalType != ClaimsAdministrationPortal.AdministrationPortalType.CoverageTypeDescriptions;
    ((CancelEventArgs) e).Cancel = true;
  }

  private void ultraToolbarsManager1_ToolClick(object sender, ToolClickEventArgs e)
  {
    if (!(((KeyedSubObjectBase) ((ToolEventArgs) e).Tool).Key == "SUBLINECODES"))
      return;
    using (FormCoverageTypeSublines coverageTypeSublines = new FormCoverageTypeSublines((int) this.gridView.Selected.Rows[0].Cells["CoverageTypeDescriptionId"].Value, this.gridView.Selected.Rows[0].Cells["CoverageTypeDescription"].Value.ToString()))
    {
      int num = (int) coverageTypeSublines.ShowDialog();
    }
  }

  private void LoadInternationalZipCode()
  {
    if (((SparseCollectionBase) this.gridView.Selected.Rows).Count == 0 || this.PortalType != ClaimsAdministrationPortal.AdministrationPortalType.ManagedCareFacilities && this.PortalType != ClaimsAdministrationPortal.AdministrationPortalType.OutsideAdjusters)
      return;
    int int32 = Convert.ToInt32(this.gridView.Selected.Rows[0].Cells["AddressId"].Value);
    DataTable dataTable = this.PortalType != ClaimsAdministrationPortal.AdministrationPortalType.ManagedCareFacilities ? (DataTable) this.dsClaimsAdministration1.OutsideAdjusterAddresses : (DataTable) this.dsClaimsAdministration1.ManagedCareAddresses;
    for (int index = 0; index < dataTable.Rows.Count; ++index)
    {
      if ((int) dataTable.Rows[index]["AddressId"] == int32)
      {
        if (((Control) this.addResolver).DataBindings["ZipCode"] != null)
          ((Control) this.addResolver).DataBindings.Remove(((Control) this.addResolver).DataBindings["ZipCode"]);
        if (!(bool) dataTable.Rows[index]["IsInternational"])
          ((Control) this.addResolver).DataBindings.Add(new Binding("ZipCode", (object) this.dsClaimsAdministration1, this.PortalType == ClaimsAdministrationPortal.AdministrationPortalType.ManagedCareFacilities ? "ManagedCareAddresses.ZipCode" : "OutsideAdjusterAddresses.ZipCode"));
        else
          ((Control) this.addResolver).DataBindings.Add(new Binding("ZipCode", (object) this.dsClaimsAdministration1, this.PortalType == ClaimsAdministrationPortal.AdministrationPortalType.ManagedCareFacilities ? "ManagedCareAddresses.InternationalZipCode" : "OutsideAdjusterAddresses.InternationalZipCode"));
        ((Control) this.addResolver).DataBindings[0].BindingManagerBase.Position = index;
        this.mgaPhoneNumberEntry1.SetAddressId(int32);
        break;
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
    Appearance appearance12 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("ReservePaymentSubTypes", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("ResPaySubTypeId");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("ResPayTypeId");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("ResPaySubTypeDescription");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("Allocated");
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    Appearance appearance17 = new Appearance();
    Appearance appearance18 = new Appearance();
    Appearance appearance19 = new Appearance();
    Appearance appearance20 = new Appearance();
    Appearance appearance21 = new Appearance();
    ScrollBarLook scrollBarLook1 = new ScrollBarLook();
    Appearance appearance22 = new Appearance();
    Appearance appearance23 = new Appearance();
    UltraGridLayout ultraGridLayout1 = new UltraGridLayout("AccidentTypes");
    Appearance appearance24 = new Appearance();
    UltraGridBand ultraGridBand2 = new UltraGridBand("AccidentTypes", -1);
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("AccidentTypeId");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("AccidentType");
    Appearance appearance25 = new Appearance();
    Appearance appearance26 = new Appearance();
    Appearance appearance27 = new Appearance();
    Appearance appearance28 = new Appearance();
    Appearance appearance29 = new Appearance();
    Appearance appearance30 = new Appearance();
    Appearance appearance31 = new Appearance();
    ScrollBarLook scrollBarLook2 = new ScrollBarLook();
    Appearance appearance32 = new Appearance();
    Appearance appearance33 = new Appearance();
    UltraGridLayout ultraGridLayout2 = new UltraGridLayout("CoverageTypes");
    Appearance appearance34 = new Appearance();
    UltraGridBand ultraGridBand3 = new UltraGridBand("CoverageTypes", -1);
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("CoverageTypeId");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("CoverageType");
    Appearance appearance35 = new Appearance();
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("CoverageTypeDescription");
    Appearance appearance36 = new Appearance();
    Appearance appearance37 = new Appearance();
    Appearance appearance38 = new Appearance();
    Appearance appearance39 = new Appearance();
    Appearance appearance40 = new Appearance();
    Appearance appearance41 = new Appearance();
    Appearance appearance42 = new Appearance();
    ScrollBarLook scrollBarLook3 = new ScrollBarLook();
    Appearance appearance43 = new Appearance();
    Appearance appearance44 = new Appearance();
    UltraGridLayout ultraGridLayout3 = new UltraGridLayout("CatastropheCodes");
    Appearance appearance45 = new Appearance();
    UltraGridBand ultraGridBand4 = new UltraGridBand("CatastropheCodes", -1);
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("CatastropheCodeId");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("CatastropheCode");
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("CatastropheCodeDescription");
    Appearance appearance46 = new Appearance();
    Appearance appearance47 = new Appearance();
    Appearance appearance48 = new Appearance();
    Appearance appearance49 = new Appearance();
    Appearance appearance50 = new Appearance();
    Appearance appearance51 = new Appearance();
    Appearance appearance52 = new Appearance();
    Appearance appearance53 = new Appearance();
    ScrollBarLook scrollBarLook4 = new ScrollBarLook();
    Appearance appearance54 = new Appearance();
    Appearance appearance55 = new Appearance();
    UltraGridLayout ultraGridLayout4 = new UltraGridLayout("LossTypes");
    Appearance appearance56 = new Appearance();
    UltraGridBand ultraGridBand5 = new UltraGridBand("LossTypes", -1);
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("LossTypeId");
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("LossType");
    Appearance appearance57 = new Appearance();
    Appearance appearance58 = new Appearance();
    Appearance appearance59 = new Appearance();
    Appearance appearance60 = new Appearance();
    Appearance appearance61 = new Appearance();
    Appearance appearance62 = new Appearance();
    Appearance appearance63 = new Appearance();
    Appearance appearance64 = new Appearance();
    ScrollBarLook scrollBarLook5 = new ScrollBarLook();
    Appearance appearance65 = new Appearance();
    Appearance appearance66 = new Appearance();
    UltraGridLayout ultraGridLayout5 = new UltraGridLayout("ManagedCareFacilities");
    Appearance appearance67 = new Appearance();
    UltraGridBand ultraGridBand6 = new UltraGridBand("ManagedCareFacilities", -1);
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("ManagedCareId");
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("FacilityName");
    UltraGridColumn ultraGridColumn17 = new UltraGridColumn("AddressId");
    UltraGridColumn ultraGridColumn18 = new UltraGridColumn("WebAddress");
    UltraGridColumn ultraGridColumn19 = new UltraGridColumn("EntityType");
    UltraGridColumn ultraGridColumn20 = new UltraGridColumn("FEIN");
    UltraGridColumn ultraGridColumn21 = new UltraGridColumn("DateIncorporated");
    UltraGridColumn ultraGridColumn22 = new UltraGridColumn("EmailAddress");
    UltraGridColumn ultraGridColumn23 = new UltraGridColumn("DateEntered");
    UltraGridColumn ultraGridColumn24 = new UltraGridColumn("EnteredByUserGuid");
    UltraGridColumn ultraGridColumn25 = new UltraGridColumn("DateModified");
    UltraGridColumn ultraGridColumn26 = new UltraGridColumn("ModifiedByUserGuid");
    Appearance appearance68 = new Appearance();
    Appearance appearance69 = new Appearance();
    Appearance appearance70 = new Appearance();
    Appearance appearance71 = new Appearance();
    Appearance appearance72 = new Appearance();
    Appearance appearance73 = new Appearance();
    Appearance appearance74 = new Appearance();
    Appearance appearance75 = new Appearance();
    ScrollBarLook scrollBarLook6 = new ScrollBarLook();
    Appearance appearance76 = new Appearance();
    Appearance appearance77 = new Appearance();
    UltraGridLayout ultraGridLayout6 = new UltraGridLayout("ReservePaymentSubTypes");
    Appearance appearance78 = new Appearance();
    UltraGridBand ultraGridBand7 = new UltraGridBand("ReservePaymentSubTypes", -1);
    UltraGridColumn ultraGridColumn27 = new UltraGridColumn("ResPaySubTypeId");
    UltraGridColumn ultraGridColumn28 = new UltraGridColumn("ResPayTypeId");
    UltraGridColumn ultraGridColumn29 = new UltraGridColumn("ResPaySubTypeDescription");
    UltraGridColumn ultraGridColumn30 = new UltraGridColumn("Allocated");
    Appearance appearance79 = new Appearance();
    Appearance appearance80 = new Appearance();
    Appearance appearance81 = new Appearance();
    Appearance appearance82 = new Appearance();
    Appearance appearance83 = new Appearance();
    Appearance appearance84 = new Appearance();
    Appearance appearance85 = new Appearance();
    Appearance appearance86 = new Appearance();
    Appearance appearance87 = new Appearance();
    ScrollBarLook scrollBarLook7 = new ScrollBarLook();
    Appearance appearance88 = new Appearance();
    Appearance appearance89 = new Appearance();
    UltraGridLayout ultraGridLayout7 = new UltraGridLayout("ReservePaymentTypes");
    Appearance appearance90 = new Appearance();
    UltraGridBand ultraGridBand8 = new UltraGridBand("ReservePaymentTypes", -1);
    UltraGridColumn ultraGridColumn31 = new UltraGridColumn("ResPayTypeId");
    UltraGridColumn ultraGridColumn32 = new UltraGridColumn("ResPayTypeDescription");
    Appearance appearance91 = new Appearance();
    Appearance appearance92 = new Appearance();
    Appearance appearance93 = new Appearance();
    Appearance appearance94 = new Appearance();
    Appearance appearance95 = new Appearance();
    Appearance appearance96 = new Appearance();
    Appearance appearance97 = new Appearance();
    Appearance appearance98 = new Appearance();
    ScrollBarLook scrollBarLook8 = new ScrollBarLook();
    Appearance appearance99 = new Appearance();
    Appearance appearance100 = new Appearance();
    UltraGridLayout ultraGridLayout8 = new UltraGridLayout("SettlementTypes");
    Appearance appearance101 = new Appearance();
    UltraGridBand ultraGridBand9 = new UltraGridBand("SettlementTypes", -1);
    UltraGridColumn ultraGridColumn33 = new UltraGridColumn("SettlementTypeId");
    UltraGridColumn ultraGridColumn34 = new UltraGridColumn("SettlementType");
    Appearance appearance102 = new Appearance();
    Appearance appearance103 = new Appearance();
    Appearance appearance104 = new Appearance();
    Appearance appearance105 = new Appearance();
    Appearance appearance106 = new Appearance();
    Appearance appearance107 = new Appearance();
    Appearance appearance108 = new Appearance();
    Appearance appearance109 = new Appearance();
    ScrollBarLook scrollBarLook9 = new ScrollBarLook();
    Appearance appearance110 = new Appearance();
    Appearance appearance111 = new Appearance();
    UltraGridLayout ultraGridLayout9 = new UltraGridLayout("CoverageTypeDescriptions");
    Appearance appearance112 = new Appearance();
    UltraGridBand ultraGridBand10 = new UltraGridBand("CoverageTypeDescriptions", -1);
    UltraGridColumn ultraGridColumn35 = new UltraGridColumn("CoverageTypeDescriptionId");
    UltraGridColumn ultraGridColumn36 = new UltraGridColumn("CoverageTypeId");
    UltraGridColumn ultraGridColumn37 = new UltraGridColumn("CoverageTypeDescription");
    Appearance appearance113 = new Appearance();
    Appearance appearance114 = new Appearance();
    Appearance appearance115 = new Appearance();
    Appearance appearance116 = new Appearance();
    Appearance appearance117 = new Appearance();
    Appearance appearance118 = new Appearance();
    Appearance appearance119 = new Appearance();
    Appearance appearance120 = new Appearance();
    ScrollBarLook scrollBarLook10 = new ScrollBarLook();
    Appearance appearance121 = new Appearance();
    Appearance appearance122 = new Appearance();
    UltraGridLayout ultraGridLayout10 = new UltraGridLayout("OutsideAdjusters");
    Appearance appearance123 = new Appearance();
    UltraGridBand ultraGridBand11 = new UltraGridBand("OutsideAdjusters", -1);
    UltraGridColumn ultraGridColumn38 = new UltraGridColumn("AdjusterGuid");
    UltraGridColumn ultraGridColumn39 = new UltraGridColumn("OutsideAdjuster");
    UltraGridColumn ultraGridColumn40 = new UltraGridColumn("Company");
    UltraGridColumn ultraGridColumn41 = new UltraGridColumn("FirstName");
    UltraGridColumn ultraGridColumn42 = new UltraGridColumn("MiddleName");
    UltraGridColumn ultraGridColumn43 = new UltraGridColumn("LastName");
    UltraGridColumn ultraGridColumn44 = new UltraGridColumn("AddressId");
    UltraGridColumn ultraGridColumn45 = new UltraGridColumn("EmailAddress");
    UltraGridColumn ultraGridColumn46 = new UltraGridColumn("SSNFEIN");
    UltraGridColumn ultraGridColumn47 = new UltraGridColumn("EntityType");
    UltraGridColumn ultraGridColumn48 = new UltraGridColumn("EnteredByUserGuid");
    UltraGridColumn ultraGridColumn49 = new UltraGridColumn("EnteredOn");
    UltraGridColumn ultraGridColumn50 = new UltraGridColumn("ModifiedByUserGuid");
    UltraGridColumn ultraGridColumn51 = new UltraGridColumn("ModifiedOn");
    Appearance appearance124 = new Appearance();
    Appearance appearance125 = new Appearance();
    Appearance appearance126 = new Appearance();
    Appearance appearance127 = new Appearance();
    Appearance appearance128 = new Appearance();
    Appearance appearance129 = new Appearance();
    Appearance appearance130 = new Appearance();
    Appearance appearance131 = new Appearance();
    ScrollBarLook scrollBarLook11 = new ScrollBarLook();
    Appearance appearance132 = new Appearance();
    Appearance appearance133 = new Appearance();
    Appearance appearance134 = new Appearance();
    Appearance appearance135 = new Appearance();
    Appearance appearance136 = new Appearance();
    Appearance appearance137 = new Appearance();
    Appearance appearance138 = new Appearance();
    Appearance appearance139 = new Appearance();
    Appearance appearance140 = new Appearance();
    Appearance appearance141 = new Appearance();
    Appearance appearance142 = new Appearance();
    ValueListItem valueListItem1 = new ValueListItem();
    ValueListItem valueListItem2 = new ValueListItem();
    UltraToolbar ultraToolbar = new UltraToolbar("UltraToolbar1");
    PopupMenuTool popupMenuTool = new PopupMenuTool("PopupMenuTool1");
    ButtonTool buttonTool1 = new ButtonTool("SUBLINECODES");
    ButtonTool buttonTool2 = new ButtonTool("SUBLINECODES");
    this.groupTwoText = new MGAGroupBox();
    this.textTwoText2 = new MGATextBox();
    this.textTwoText1 = new MGATextBox();
    this.labelTwoField2 = new Label();
    this.labelTwoField1 = new Label();
    this.dbSaveMulti = new MGASystems.Tools.DBSaveUI.DBSaveUI();
    this.labelHeader = new UltraLabel();
    this.groupOneText = new MGAGroupBox();
    this.textOneText1 = new MGATextBox();
    this.labelOneViewField1 = new Label();
    this.dbSaveUISingle = new MGASystems.Tools.DBSaveUI.DBSaveUI();
    this.panelBottom = new Panel();
    this.groupExtendedMulti = new MGAGroupBox();
    this.label12 = new Label();
    this.labelExtendedCombo = new Label();
    this.textExtendedMulti1 = new MGATextBox();
    this.comboExtendedMulti = new MGASimpleComboBox();
    this.dbSaveUIExtendedMulti = new MGASystems.Tools.DBSaveUI.DBSaveUI();
    this.panelCenter = new Panel();
    this.gridView = new UltraGrid();
    this.dsClaimsAdministration1 = new dsClaimsAdministration();
    this.panelTop = new Panel();
    this.panelRight = new Panel();
    this.textWebAddress = new MGATextBox();
    this.label1 = new Label();
    this.dbSaveUIAddress = new MGASystems.Tools.DBSaveUI.DBSaveUI();
    this.dateTimeIncorporated = new MGADateTimePicker();
    this.label8 = new Label();
    this.maskedEditSSNFEIN = new MGAMaskedEdit();
    this.label7 = new Label();
    this.label6 = new Label();
    this.textEmailAddress = new MGATextBox();
    this.label5 = new Label();
    this.label4 = new Label();
    this.label3 = new Label();
    this.label2 = new Label();
    this.textCorporationName = new MGATextBox();
    this.textLastName = new MGATextBox();
    this.textMiddleName = new MGATextBox();
    this.textFirstName = new MGATextBox();
    this.optionEntityType = new UltraOptionSet();
    this.addResolver = new AddressResolver_MULTI();
    this.dsClaims_PhoneNumbers1 = new dsClaims_PhoneNumbers();
    this._ClaimsAdministrationPortal_Toolbars_Dock_Area_Left = new UltraToolbarsDockArea();
    this._ClaimsAdministrationPortal_Toolbars_Dock_Area_Right = new UltraToolbarsDockArea();
    this._ClaimsAdministrationPortal_Toolbars_Dock_Area_Top = new UltraToolbarsDockArea();
    this._ClaimsAdministrationPortal_Toolbars_Dock_Area_Bottom = new UltraToolbarsDockArea();
    this.mgaPhoneNumberEntry1 = new MgaPhoneNumberEntry();
    this.ultraToolbarsManager1 = new UltraToolbarsManager(this.components);
    ((ISupportInitialize) this.groupTwoText).BeginInit();
    ((Control) this.groupTwoText).SuspendLayout();
    ((ISupportInitialize) this.textTwoText2).BeginInit();
    ((ISupportInitialize) this.textTwoText1).BeginInit();
    ((ISupportInitialize) this.groupOneText).BeginInit();
    ((Control) this.groupOneText).SuspendLayout();
    ((ISupportInitialize) this.textOneText1).BeginInit();
    this.panelBottom.SuspendLayout();
    ((ISupportInitialize) this.groupExtendedMulti).BeginInit();
    ((Control) this.groupExtendedMulti).SuspendLayout();
    ((ISupportInitialize) this.textExtendedMulti1).BeginInit();
    ((ISupportInitialize) this.comboExtendedMulti).BeginInit();
    this.panelCenter.SuspendLayout();
    ((ISupportInitialize) this.gridView).BeginInit();
    this.dsClaimsAdministration1.BeginInit();
    this.panelTop.SuspendLayout();
    this.panelRight.SuspendLayout();
    ((ISupportInitialize) this.textWebAddress).BeginInit();
    ((ISupportInitialize) this.dateTimeIncorporated).BeginInit();
    ((ISupportInitialize) this.maskedEditSSNFEIN).BeginInit();
    ((ISupportInitialize) this.textEmailAddress).BeginInit();
    ((ISupportInitialize) this.textCorporationName).BeginInit();
    ((ISupportInitialize) this.textLastName).BeginInit();
    ((ISupportInitialize) this.textMiddleName).BeginInit();
    ((ISupportInitialize) this.textFirstName).BeginInit();
    ((ISupportInitialize) this.optionEntityType).BeginInit();
    this.dsClaims_PhoneNumbers1.BeginInit();
    ((ISupportInitialize) this.ultraToolbarsManager1).BeginInit();
    this.SuspendLayout();
    ((Control) this.groupTwoText).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    ((AppearanceBase) appearance1).BackColor = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance1).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGroupBox) this.groupTwoText).ContentAreaAppearance = (AppearanceBase) appearance1;
    ((Control) this.groupTwoText).Controls.Add((Control) this.textTwoText2);
    ((Control) this.groupTwoText).Controls.Add((Control) this.textTwoText1);
    ((Control) this.groupTwoText).Controls.Add((Control) this.labelTwoField2);
    ((Control) this.groupTwoText).Controls.Add((Control) this.labelTwoField1);
    ((Control) this.groupTwoText).Controls.Add((Control) this.dbSaveMulti);
    ((AppearanceBase) appearance2).ForeColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGroupBox) this.groupTwoText).HeaderAppearance = (AppearanceBase) appearance2;
    ((Control) this.groupTwoText).Location = new Point(2, 6);
    ((Control) this.groupTwoText).Name = "groupTwoText";
    ((Control) this.groupTwoText).Size = new Size(503, 111);
    ((Control) this.groupTwoText).TabIndex = 0;
    ((Control) this.groupTwoText).Text = "Options";
    ((UltraGroupBox) this.groupTwoText).ViewStyle = (GroupBoxViewStyle) 2;
    ((Control) this.groupTwoText).Visible = false;
    ((Control) this.textTwoText2).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    ((AppearanceBase) appearance3).BackColor = Color.White;
    ((AppearanceBase) appearance3).BorderColor = Color.Gray;
    ((AppearanceBase) appearance3).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textTwoText2).Appearance = (AppearanceBase) appearance3;
    ((Control) this.textTwoText2).BackColor = Color.White;
    ((Control) this.textTwoText2).Location = new Point(114, 56);
    ((UltraTextEditor) this.textTwoText2).Multiline = true;
    ((Control) this.textTwoText2).Name = "textTwoText2";
    ((Control) this.textTwoText2).Size = new Size(264, 43);
    ((Control) this.textTwoText2).TabIndex = 1;
    ((UltraControlBase) this.textTwoText2).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textTwoText2).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.textTwoText1).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    ((AppearanceBase) appearance4).BackColor = Color.White;
    ((AppearanceBase) appearance4).BorderColor = Color.Gray;
    ((AppearanceBase) appearance4).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textTwoText1).Appearance = (AppearanceBase) appearance4;
    ((Control) this.textTwoText1).BackColor = Color.White;
    ((Control) this.textTwoText1).Location = new Point(115, 31 /*0x1F*/);
    ((Control) this.textTwoText1).Name = "textTwoText1";
    ((Control) this.textTwoText1).Size = new Size(379, 20);
    ((Control) this.textTwoText1).TabIndex = 0;
    ((UltraControlBase) this.textTwoText1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textTwoText1).UseOsThemes = (DefaultableBoolean) 2;
    this.labelTwoField2.AutoSize = true;
    this.labelTwoField2.BackColor = Color.Transparent;
    this.labelTwoField2.Location = new Point(11, 59);
    this.labelTwoField2.Name = "labelTwoField2";
    this.labelTwoField2.Size = new Size(64 /*0x40*/, 13);
    this.labelTwoField2.TabIndex = 2;
    this.labelTwoField2.Text = "Description:";
    this.labelTwoField1.AutoSize = true;
    this.labelTwoField1.BackColor = Color.Transparent;
    this.labelTwoField1.Location = new Point(11, 31 /*0x1F*/);
    this.labelTwoField1.Name = "labelTwoField1";
    this.labelTwoField1.Size = new Size(36, 13);
    this.labelTwoField1.TabIndex = 0;
    this.labelTwoField1.Text = "Code:";
    ((Control) this.dbSaveMulti).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.dbSaveMulti.EditStyle = (EditStyle) 1;
    this.dbSaveMulti.FreezeEvents = false;
    ((Control) this.dbSaveMulti).Location = new Point(383, 59);
    ((Control) this.dbSaveMulti).Name = "dbSaveMulti";
    ((Control) this.dbSaveMulti).Size = new Size(112 /*0x70*/, 40);
    ((Control) this.dbSaveMulti).TabIndex = 1;
    this.dbSaveMulti.UIState = (UIState) 1;
    this.dbSaveMulti.ClickedNew += new EventHandler(this.dbSaveMulti_ClickedNew);
    this.dbSaveMulti.ClickingSave += new CancelEventHandler(this.dbSaveMulti_ClickingSave);
    this.dbSaveMulti.ClickedSave += new EventHandler(this.dbSaveMulti_ClickedSave);
    this.dbSaveMulti.ClickedDelete += new EventHandler(this.dbSaveMulti_ClickedDelete);
    this.dbSaveMulti.ClickedCancel += new EventHandler(this.dbSaveMulti_ClickedCancel);
    this.dbSaveMulti.ClickedEdit += new EventHandler(this.dbSaveMulti_ClickedEdit);
    ((AppearanceBase) appearance5).FontData.BoldAsString = "True";
    ((AppearanceBase) appearance5).FontData.Name = "Tahoma";
    ((AppearanceBase) appearance5).FontData.SizeInPoints = 10f;
    ((AppearanceBase) appearance5).ForeColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance5).TextHAlignAsString = "Left";
    ((AppearanceBase) appearance5).TextVAlignAsString = "Middle";
    ((ControlBase) this.labelHeader).Appearance = (AppearanceBase) appearance5;
    ((Control) this.labelHeader).Font = new Font("Tahoma", 10f, FontStyle.Bold);
    ((Control) this.labelHeader).Location = new Point(0, 0);
    ((Control) this.labelHeader).Name = "labelHeader";
    ((Control) this.labelHeader).Size = new Size(497, 24);
    ((Control) this.labelHeader).TabIndex = 0;
    ((Control) this.labelHeader).Text = "Administration Options";
    ((Control) this.groupOneText).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((AppearanceBase) appearance6).BackColor = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance6).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGroupBox) this.groupOneText).ContentAreaAppearance = (AppearanceBase) appearance6;
    ((Control) this.groupOneText).Controls.Add((Control) this.textOneText1);
    ((Control) this.groupOneText).Controls.Add((Control) this.labelOneViewField1);
    ((Control) this.groupOneText).Controls.Add((Control) this.dbSaveUISingle);
    ((AppearanceBase) appearance7).ForeColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGroupBox) this.groupOneText).HeaderAppearance = (AppearanceBase) appearance7;
    ((Control) this.groupOneText).Location = new Point(2, 6);
    ((Control) this.groupOneText).Name = "groupOneText";
    ((Control) this.groupOneText).Size = new Size(499, 68);
    ((Control) this.groupOneText).TabIndex = 1;
    ((Control) this.groupOneText).Text = "Options";
    ((UltraGroupBox) this.groupOneText).ViewStyle = (GroupBoxViewStyle) 2;
    ((Control) this.textOneText1).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    ((AppearanceBase) appearance8).BackColor = Color.White;
    ((AppearanceBase) appearance8).BorderColor = Color.Gray;
    ((AppearanceBase) appearance8).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textOneText1).Appearance = (AppearanceBase) appearance8;
    ((Control) this.textOneText1).BackColor = Color.White;
    ((Control) this.textOneText1).Location = new Point(115, 32 /*0x20*/);
    ((Control) this.textOneText1).Name = "textOneText1";
    ((Control) this.textOneText1).Size = new Size(258, 20);
    ((Control) this.textOneText1).TabIndex = 1;
    ((UltraControlBase) this.textOneText1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textOneText1).UseOsThemes = (DefaultableBoolean) 2;
    this.labelOneViewField1.AutoSize = true;
    this.labelOneViewField1.BackColor = Color.Transparent;
    this.labelOneViewField1.Location = new Point(11, 32 /*0x20*/);
    this.labelOneViewField1.Name = "labelOneViewField1";
    this.labelOneViewField1.Size = new Size(36, 13);
    this.labelOneViewField1.TabIndex = 0;
    this.labelOneViewField1.Text = "Code:";
    ((Control) this.dbSaveUISingle).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.dbSaveUISingle.EditStyle = (EditStyle) 1;
    this.dbSaveUISingle.FreezeEvents = false;
    ((Control) this.dbSaveUISingle).Location = new Point(379, 23);
    ((Control) this.dbSaveUISingle).Name = "dbSaveUISingle";
    ((Control) this.dbSaveUISingle).Size = new Size(112 /*0x70*/, 40);
    ((Control) this.dbSaveUISingle).TabIndex = 0;
    this.dbSaveUISingle.UIState = (UIState) 1;
    this.dbSaveUISingle.ClickedNew += new EventHandler(this.dbSaveUISingle_ClickedNew);
    this.dbSaveUISingle.ClickingSave += new CancelEventHandler(this.dbSaveUISingle_ClickingSave);
    this.dbSaveUISingle.ClickedSave += new EventHandler(this.dbSaveUISingle_ClickedSave);
    this.dbSaveUISingle.ClickedDelete += new EventHandler(this.dbSaveUISingle_ClickedDelete);
    this.dbSaveUISingle.ClickedCancel += new EventHandler(this.dbSaveUISingle_ClickedCancel);
    this.dbSaveUISingle.ClickedEdit += new EventHandler(this.dbSaveUISingle_ClickedEdit);
    this.panelBottom.Controls.Add((Control) this.groupExtendedMulti);
    this.panelBottom.Controls.Add((Control) this.groupOneText);
    this.panelBottom.Controls.Add((Control) this.groupTwoText);
    this.panelBottom.Location = new Point(0, 495);
    this.panelBottom.Name = "panelBottom";
    this.panelBottom.Size = new Size(508, 78);
    this.panelBottom.TabIndex = 0;
    ((Control) this.groupExtendedMulti).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    ((AppearanceBase) appearance9).BackColor = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance9).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGroupBox) this.groupExtendedMulti).ContentAreaAppearance = (AppearanceBase) appearance9;
    ((Control) this.groupExtendedMulti).Controls.Add((Control) this.label12);
    ((Control) this.groupExtendedMulti).Controls.Add((Control) this.labelExtendedCombo);
    ((Control) this.groupExtendedMulti).Controls.Add((Control) this.textExtendedMulti1);
    ((Control) this.groupExtendedMulti).Controls.Add((Control) this.comboExtendedMulti);
    ((Control) this.groupExtendedMulti).Controls.Add((Control) this.dbSaveUIExtendedMulti);
    ((AppearanceBase) appearance10).ForeColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGroupBox) this.groupExtendedMulti).HeaderAppearance = (AppearanceBase) appearance10;
    ((Control) this.groupExtendedMulti).Location = new Point(2, 6);
    ((Control) this.groupExtendedMulti).Name = "groupExtendedMulti";
    ((Control) this.groupExtendedMulti).Size = new Size(503, 111);
    ((Control) this.groupExtendedMulti).TabIndex = 0;
    ((Control) this.groupExtendedMulti).Text = "Options";
    ((UltraGroupBox) this.groupExtendedMulti).ViewStyle = (GroupBoxViewStyle) 2;
    ((Control) this.groupExtendedMulti).Visible = false;
    this.label12.AutoSize = true;
    this.label12.BackColor = Color.Transparent;
    this.label12.Location = new Point(13, 58);
    this.label12.Name = "label12";
    this.label12.Size = new Size(64 /*0x40*/, 13);
    this.label12.TabIndex = 3;
    this.label12.Text = "Description:";
    this.labelExtendedCombo.AutoSize = true;
    this.labelExtendedCombo.BackColor = Color.Transparent;
    this.labelExtendedCombo.Location = new Point(13, 30);
    this.labelExtendedCombo.Name = "labelExtendedCombo";
    this.labelExtendedCombo.Size = new Size(29, 13);
    this.labelExtendedCombo.TabIndex = 0;
    this.labelExtendedCombo.Text = "Link:";
    ((Control) this.textExtendedMulti1).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    ((AppearanceBase) appearance11).BackColor = Color.White;
    ((AppearanceBase) appearance11).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance11).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textExtendedMulti1).Appearance = (AppearanceBase) appearance11;
    ((Control) this.textExtendedMulti1).BackColor = Color.White;
    ((Control) this.textExtendedMulti1).Location = new Point(94, 58);
    this.textExtendedMulti1.MGAStyle = (MGAStyles) 2;
    ((Control) this.textExtendedMulti1).Name = "textExtendedMulti1";
    ((Control) this.textExtendedMulti1).Size = new Size(284, 20);
    ((Control) this.textExtendedMulti1).TabIndex = 4;
    ((UltraControlBase) this.textExtendedMulti1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textExtendedMulti1).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.comboExtendedMulti).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraCombo) this.comboExtendedMulti).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraCombo) this.comboExtendedMulti).DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboExtendedMulti).Location = new Point(94, 31 /*0x1F*/);
    this.comboExtendedMulti.MGAStyle = (MGAStyles) 2;
    ((Control) this.comboExtendedMulti).Name = "comboExtendedMulti";
    ((Control) this.comboExtendedMulti).Size = new Size(284, 21);
    ((Control) this.comboExtendedMulti).TabIndex = 2;
    ((UltraControlBase) this.comboExtendedMulti).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboExtendedMulti).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.dbSaveUIExtendedMulti).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.dbSaveUIExtendedMulti.EditStyle = (EditStyle) 1;
    this.dbSaveUIExtendedMulti.FreezeEvents = false;
    ((Control) this.dbSaveUIExtendedMulti).Location = new Point(383, 38);
    ((Control) this.dbSaveUIExtendedMulti).Name = "dbSaveUIExtendedMulti";
    ((Control) this.dbSaveUIExtendedMulti).Size = new Size(112 /*0x70*/, 40);
    ((Control) this.dbSaveUIExtendedMulti).TabIndex = 0;
    this.dbSaveUIExtendedMulti.UIState = (UIState) 1;
    this.dbSaveUIExtendedMulti.ClickedNew += new EventHandler(this.dbSaveUIExtendedMulti_ClickedNew);
    this.dbSaveUIExtendedMulti.ClickedSave += new EventHandler(this.dbSaveUIExtendedMulti_ClickedSave);
    this.dbSaveUIExtendedMulti.ClickedDelete += new EventHandler(this.dbSaveUIExtendedMulti_ClickedDelete);
    this.dbSaveUIExtendedMulti.ClickedCancel += new EventHandler(this.dbSaveUIExtendedMulti_ClickedCancel);
    this.dbSaveUIExtendedMulti.ClickedEdit += new EventHandler(this.dbSaveUIExtendedMulti_ClickedEdit);
    this.panelCenter.Controls.Add((Control) this.gridView);
    this.panelCenter.Location = new Point(0, 22);
    this.panelCenter.Name = "panelCenter";
    this.panelCenter.Size = new Size(508, 473);
    this.panelCenter.TabIndex = 0;
    this.ultraToolbarsManager1.SetContextMenuUltra((Component) this.gridView, "PopupMenuTool1");
    ((UltraGridBase) this.gridView).DataMember = "ReservePaymentSubTypes";
    ((UltraGridBase) this.gridView).DataSource = (object) this.dsClaimsAdministration1;
    ((AppearanceBase) appearance12).BackColor = Color.White;
    ((AppearanceBase) appearance12).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridView).DisplayLayout.Appearance = (AppearanceBase) appearance12;
    ((UltraGridBase) this.gridView).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn1.Header).VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 166;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn2.Header).VisiblePosition = 1;
    ultraGridColumn2.Hidden = true;
    ultraGridColumn2.Width = 73;
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn3.Header).Caption = "Sub-Type Description";
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn3.Header).VisiblePosition = 2;
    ultraGridColumn3.Width = 380;
    ultraGridColumn4.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance13).TextHAlignAsString = "Center";
    ((HeaderBase) ultraGridColumn4.Header).Appearance = (AppearanceBase) appearance13;
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn4.Header).VisiblePosition = 3;
    ultraGridColumn4.Width = 126;
    ultraGridBand1.Columns.AddRange(new object[4]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4
    });
    ((AppearanceBase) appearance14).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridBand1.Header).Appearance = (AppearanceBase) appearance14;
    ((HeaderBase) ultraGridBand1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridBand1.Override.AllowAddNew = (AllowAddNew) 2;
    ultraGridBand1.Override.AllowColMoving = (AllowColMoving) 1;
    ultraGridBand1.Override.AllowColSizing = (AllowColSizing) 1;
    ultraGridBand1.Override.AllowColSwapping = (AllowColSwapping) 1;
    ultraGridBand1.Override.AllowDelete = (DefaultableBoolean) 1;
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
    ultraGridBand1.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance15).TextHAlignAsString = "Left";
    ultraGridBand1.Override.HeaderAppearance = (AppearanceBase) appearance15;
    ultraGridBand1.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.gridView).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.gridView).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance16).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance16).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance16).ForeColor = Color.Black;
    ((UltraGridBase) this.gridView).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance16;
    ((UltraGridBase) this.gridView).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridView).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridView).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance17).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridView).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance17;
    ((UltraGridBase) this.gridView).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance18).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.gridView).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance18;
    ((UltraGridBase) this.gridView).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance19).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridView).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance19;
    ((AppearanceBase) appearance20).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridView).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance20;
    ((UltraGridBase) this.gridView).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance21).BackColor = Color.Transparent;
    ((AppearanceBase) appearance21).ForeColor = Color.Black;
    ((UltraGridBase) this.gridView).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance21;
    ((AppearanceBase) appearance22).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance22).BorderColor = Color.Silver;
    scrollBarLook1.ButtonAppearance = (AppearanceBase) appearance22;
    ((AppearanceBase) appearance23).BackColor = Color.White;
    scrollBarLook1.TrackAppearance = (AppearanceBase) appearance23;
    ((UltraGridBase) this.gridView).DisplayLayout.ScrollBarLook = scrollBarLook1;
    ((Control) this.gridView).Dock = DockStyle.Fill;
    ((AppearanceBase) appearance24).BackColor = Color.White;
    ((AppearanceBase) appearance24).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ultraGridLayout1.Appearance = (AppearanceBase) appearance24;
    ultraGridLayout1.AutoFitStyle = (AutoFitStyle) 1;
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn5.Header).VisiblePosition = 0;
    ultraGridColumn5.Hidden = true;
    ultraGridColumn5.Width = 243;
    ((AppearanceBase) appearance25).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn6.Header).Appearance = (AppearanceBase) appearance25;
    ((HeaderBase) ultraGridColumn6.Header).Caption = "Accident Types";
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn6.Header).VisiblePosition = 1;
    ultraGridColumn6.Width = 506;
    ultraGridBand2.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn5,
      (object) ultraGridColumn6
    });
    ultraGridBand2.Override.AllowAddNew = (AllowAddNew) 2;
    ultraGridBand2.Override.AllowColMoving = (AllowColMoving) 1;
    ultraGridBand2.Override.AllowColSizing = (AllowColSizing) 1;
    ultraGridBand2.Override.AllowColSwapping = (AllowColSwapping) 1;
    ultraGridBand2.Override.AllowDelete = (DefaultableBoolean) 1;
    ultraGridBand2.Override.AllowGroupBy = (DefaultableBoolean) 2;
    ultraGridBand2.Override.AllowGroupMoving = (AllowGroupMoving) 1;
    ultraGridBand2.Override.AllowGroupSwapping = (AllowGroupSwapping) 1;
    ultraGridBand2.Override.AllowMultiCellOperations = (AllowMultiCellOperation) 0;
    ultraGridBand2.Override.AllowRowFiltering = (DefaultableBoolean) 2;
    ultraGridBand2.Override.AllowRowLayoutCellSizing = (RowLayoutSizing) 1;
    ultraGridBand2.Override.AllowRowLayoutCellSpanSizing = (GridBagLayoutAllowSpanSizing) 1;
    ultraGridBand2.Override.AllowRowLayoutColMoving = (GridBagLayoutAllowMoving) 1;
    ultraGridBand2.Override.AllowRowLayoutLabelSizing = (RowLayoutSizing) 1;
    ultraGridBand2.Override.AllowRowLayoutLabelSpanSizing = (GridBagLayoutAllowSpanSizing) 1;
    ultraGridBand2.Override.AllowRowSummaries = (AllowRowSummaries) 2;
    ultraGridBand2.Override.AllowUpdate = (DefaultableBoolean) 2;
    ultraGridBand2.Override.HeaderClickAction = (HeaderClickAction) 2;
    ultraGridLayout1.BandsSerializer.Add((object) ultraGridBand2);
    ultraGridLayout1.BorderStyle = (UIElementBorderStyle) 4;
    ((KeyedSubObjectBase) ultraGridLayout1).Key = "AccidentTypes";
    ((AppearanceBase) appearance26).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance26).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance26).ForeColor = Color.Black;
    ultraGridLayout1.Override.ActiveRowAppearance = (AppearanceBase) appearance26;
    ultraGridLayout1.Override.AllowColSizing = (AllowColSizing) 3;
    ultraGridLayout1.Override.AllowDelete = (DefaultableBoolean) 2;
    ultraGridLayout1.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance27).BorderColor = Color.LightGray;
    ultraGridLayout1.Override.CellAppearance = (AppearanceBase) appearance27;
    ultraGridLayout1.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance28).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ultraGridLayout1.Override.HeaderAppearance = (AppearanceBase) appearance28;
    ultraGridLayout1.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance29).BackColor = Color.FromArgb(246, 250, 253);
    ultraGridLayout1.Override.RowAlternateAppearance = (AppearanceBase) appearance29;
    ((AppearanceBase) appearance30).BorderColor = Color.LightGray;
    ultraGridLayout1.Override.RowAppearance = (AppearanceBase) appearance30;
    ultraGridLayout1.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance31).BackColor = Color.Transparent;
    ((AppearanceBase) appearance31).ForeColor = Color.Black;
    ultraGridLayout1.Override.SelectedRowAppearance = (AppearanceBase) appearance31;
    ((AppearanceBase) appearance32).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance32).BorderColor = Color.Silver;
    scrollBarLook2.ButtonAppearance = (AppearanceBase) appearance32;
    ((AppearanceBase) appearance33).BackColor = Color.White;
    scrollBarLook2.TrackAppearance = (AppearanceBase) appearance33;
    ultraGridLayout1.ScrollBarLook = scrollBarLook2;
    ((AppearanceBase) appearance34).BackColor = Color.White;
    ((AppearanceBase) appearance34).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ultraGridLayout2.Appearance = (AppearanceBase) appearance34;
    ultraGridLayout2.AutoFitStyle = (AutoFitStyle) 2;
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn7.Header).VisiblePosition = 0;
    ultraGridColumn7.Hidden = true;
    ultraGridColumn7.Width = 249;
    ((AppearanceBase) appearance35).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn8.Header).Appearance = (AppearanceBase) appearance35;
    ((HeaderBase) ultraGridColumn8.Header).Caption = "Coverage Types";
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn8.Header).VisiblePosition = 1;
    ultraGridColumn8.Width = (int) sbyte.MaxValue;
    ((HeaderBase) ultraGridColumn9.Header).Caption = "Coverage Type Description";
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn9.Header).VisiblePosition = 2;
    ultraGridColumn9.Width = 373;
    ultraGridBand3.Columns.AddRange(new object[3]
    {
      (object) ultraGridColumn7,
      (object) ultraGridColumn8,
      (object) ultraGridColumn9
    });
    ultraGridBand3.Override.AllowAddNew = (AllowAddNew) 2;
    ultraGridBand3.Override.AllowColMoving = (AllowColMoving) 1;
    ultraGridBand3.Override.AllowColSizing = (AllowColSizing) 1;
    ultraGridBand3.Override.AllowColSwapping = (AllowColSwapping) 1;
    ultraGridBand3.Override.AllowDelete = (DefaultableBoolean) 1;
    ultraGridBand3.Override.AllowGroupBy = (DefaultableBoolean) 2;
    ultraGridBand3.Override.AllowGroupMoving = (AllowGroupMoving) 1;
    ultraGridBand3.Override.AllowGroupSwapping = (AllowGroupSwapping) 1;
    ultraGridBand3.Override.AllowMultiCellOperations = (AllowMultiCellOperation) 0;
    ultraGridBand3.Override.AllowRowFiltering = (DefaultableBoolean) 2;
    ultraGridBand3.Override.AllowRowLayoutCellSizing = (RowLayoutSizing) 1;
    ultraGridBand3.Override.AllowRowLayoutCellSpanSizing = (GridBagLayoutAllowSpanSizing) 1;
    ultraGridBand3.Override.AllowRowLayoutColMoving = (GridBagLayoutAllowMoving) 1;
    ultraGridBand3.Override.AllowRowLayoutLabelSizing = (RowLayoutSizing) 1;
    ultraGridBand3.Override.AllowRowLayoutLabelSpanSizing = (GridBagLayoutAllowSpanSizing) 1;
    ultraGridBand3.Override.AllowRowSummaries = (AllowRowSummaries) 2;
    ultraGridBand3.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance36).TextHAlignAsString = "Left";
    ultraGridBand3.Override.HeaderAppearance = (AppearanceBase) appearance36;
    ultraGridBand3.Override.HeaderClickAction = (HeaderClickAction) 2;
    ultraGridLayout2.BandsSerializer.Add((object) ultraGridBand3);
    ultraGridLayout2.BorderStyle = (UIElementBorderStyle) 4;
    ((KeyedSubObjectBase) ultraGridLayout2).Key = "CoverageTypes";
    ((AppearanceBase) appearance37).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance37).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance37).ForeColor = Color.Black;
    ultraGridLayout2.Override.ActiveRowAppearance = (AppearanceBase) appearance37;
    ultraGridLayout2.Override.AllowColSizing = (AllowColSizing) 3;
    ultraGridLayout2.Override.AllowDelete = (DefaultableBoolean) 2;
    ultraGridLayout2.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance38).BorderColor = Color.LightGray;
    ultraGridLayout2.Override.CellAppearance = (AppearanceBase) appearance38;
    ultraGridLayout2.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance39).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ultraGridLayout2.Override.HeaderAppearance = (AppearanceBase) appearance39;
    ultraGridLayout2.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance40).BackColor = Color.FromArgb(246, 250, 253);
    ultraGridLayout2.Override.RowAlternateAppearance = (AppearanceBase) appearance40;
    ((AppearanceBase) appearance41).BorderColor = Color.LightGray;
    ultraGridLayout2.Override.RowAppearance = (AppearanceBase) appearance41;
    ultraGridLayout2.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance42).BackColor = Color.Transparent;
    ((AppearanceBase) appearance42).ForeColor = Color.Black;
    ultraGridLayout2.Override.SelectedRowAppearance = (AppearanceBase) appearance42;
    ((AppearanceBase) appearance43).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance43).BorderColor = Color.Silver;
    scrollBarLook3.ButtonAppearance = (AppearanceBase) appearance43;
    ((AppearanceBase) appearance44).BackColor = Color.White;
    scrollBarLook3.TrackAppearance = (AppearanceBase) appearance44;
    ultraGridLayout2.ScrollBarLook = scrollBarLook3;
    ((AppearanceBase) appearance45).BackColor = Color.White;
    ((AppearanceBase) appearance45).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ultraGridLayout3.Appearance = (AppearanceBase) appearance45;
    ultraGridLayout3.AutoFitStyle = (AutoFitStyle) 1;
    ((HeaderBase) ultraGridColumn10.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn10.Header).VisiblePosition = 0;
    ultraGridColumn10.Hidden = true;
    ultraGridColumn10.Width = 152;
    ((HeaderBase) ultraGridColumn11.Header).Caption = "Catastrophe Code";
    ((HeaderBase) ultraGridColumn11.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn11.Header).VisiblePosition = 1;
    ultraGridColumn11.Width = 222;
    ((HeaderBase) ultraGridColumn12.Header).Caption = "Description";
    ((HeaderBase) ultraGridColumn12.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn12.Header).VisiblePosition = 2;
    ultraGridColumn12.Width = 284;
    ultraGridBand4.Columns.AddRange(new object[3]
    {
      (object) ultraGridColumn10,
      (object) ultraGridColumn11,
      (object) ultraGridColumn12
    });
    ((AppearanceBase) appearance46).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridBand4.Header).Appearance = (AppearanceBase) appearance46;
    ((HeaderBase) ultraGridBand4.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridBand4.Override.AllowAddNew = (AllowAddNew) 2;
    ultraGridBand4.Override.AllowColMoving = (AllowColMoving) 1;
    ultraGridBand4.Override.AllowColSizing = (AllowColSizing) 1;
    ultraGridBand4.Override.AllowColSwapping = (AllowColSwapping) 1;
    ultraGridBand4.Override.AllowDelete = (DefaultableBoolean) 1;
    ultraGridBand4.Override.AllowGroupBy = (DefaultableBoolean) 2;
    ultraGridBand4.Override.AllowGroupMoving = (AllowGroupMoving) 1;
    ultraGridBand4.Override.AllowGroupSwapping = (AllowGroupSwapping) 1;
    ultraGridBand4.Override.AllowMultiCellOperations = (AllowMultiCellOperation) 0;
    ultraGridBand4.Override.AllowRowFiltering = (DefaultableBoolean) 2;
    ultraGridBand4.Override.AllowRowLayoutCellSizing = (RowLayoutSizing) 1;
    ultraGridBand4.Override.AllowRowLayoutCellSpanSizing = (GridBagLayoutAllowSpanSizing) 1;
    ultraGridBand4.Override.AllowRowLayoutColMoving = (GridBagLayoutAllowMoving) 1;
    ultraGridBand4.Override.AllowRowLayoutLabelSizing = (RowLayoutSizing) 1;
    ultraGridBand4.Override.AllowRowLayoutLabelSpanSizing = (GridBagLayoutAllowSpanSizing) 1;
    ultraGridBand4.Override.AllowRowSummaries = (AllowRowSummaries) 2;
    ultraGridBand4.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance47).TextHAlignAsString = "Left";
    ultraGridBand4.Override.HeaderAppearance = (AppearanceBase) appearance47;
    ultraGridBand4.Override.HeaderClickAction = (HeaderClickAction) 2;
    ultraGridLayout3.BandsSerializer.Add((object) ultraGridBand4);
    ultraGridLayout3.BorderStyle = (UIElementBorderStyle) 4;
    ((KeyedSubObjectBase) ultraGridLayout3).Key = "CatastropheCodes";
    ((AppearanceBase) appearance48).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance48).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance48).ForeColor = Color.Black;
    ultraGridLayout3.Override.ActiveRowAppearance = (AppearanceBase) appearance48;
    ultraGridLayout3.Override.AllowColSizing = (AllowColSizing) 3;
    ultraGridLayout3.Override.AllowDelete = (DefaultableBoolean) 2;
    ultraGridLayout3.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance49).BorderColor = Color.LightGray;
    ultraGridLayout3.Override.CellAppearance = (AppearanceBase) appearance49;
    ultraGridLayout3.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance50).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ultraGridLayout3.Override.HeaderAppearance = (AppearanceBase) appearance50;
    ultraGridLayout3.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance51).BackColor = Color.FromArgb(246, 250, 253);
    ultraGridLayout3.Override.RowAlternateAppearance = (AppearanceBase) appearance51;
    ((AppearanceBase) appearance52).BorderColor = Color.LightGray;
    ultraGridLayout3.Override.RowAppearance = (AppearanceBase) appearance52;
    ultraGridLayout3.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance53).BackColor = Color.Transparent;
    ((AppearanceBase) appearance53).ForeColor = Color.Black;
    ultraGridLayout3.Override.SelectedRowAppearance = (AppearanceBase) appearance53;
    ((AppearanceBase) appearance54).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance54).BorderColor = Color.Silver;
    scrollBarLook4.ButtonAppearance = (AppearanceBase) appearance54;
    ((AppearanceBase) appearance55).BackColor = Color.White;
    scrollBarLook4.TrackAppearance = (AppearanceBase) appearance55;
    ultraGridLayout3.ScrollBarLook = scrollBarLook4;
    ((AppearanceBase) appearance56).BackColor = Color.White;
    ((AppearanceBase) appearance56).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ultraGridLayout4.Appearance = (AppearanceBase) appearance56;
    ultraGridLayout4.AutoFitStyle = (AutoFitStyle) 1;
    ((HeaderBase) ultraGridColumn13.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn13.Header).VisiblePosition = 0;
    ultraGridColumn13.Hidden = true;
    ultraGridColumn13.Width = 213;
    ((HeaderBase) ultraGridColumn14.Header).Caption = "Loss Types";
    ((HeaderBase) ultraGridColumn14.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn14.Header).VisiblePosition = 1;
    ultraGridColumn14.Width = 506;
    ultraGridBand5.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn13,
      (object) ultraGridColumn14
    });
    ((AppearanceBase) appearance57).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridBand5.Header).Appearance = (AppearanceBase) appearance57;
    ((HeaderBase) ultraGridBand5.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridBand5.Override.AllowAddNew = (AllowAddNew) 2;
    ultraGridBand5.Override.AllowColMoving = (AllowColMoving) 1;
    ultraGridBand5.Override.AllowColSizing = (AllowColSizing) 1;
    ultraGridBand5.Override.AllowColSwapping = (AllowColSwapping) 1;
    ultraGridBand5.Override.AllowDelete = (DefaultableBoolean) 1;
    ultraGridBand5.Override.AllowGroupBy = (DefaultableBoolean) 2;
    ultraGridBand5.Override.AllowGroupMoving = (AllowGroupMoving) 1;
    ultraGridBand5.Override.AllowGroupSwapping = (AllowGroupSwapping) 1;
    ultraGridBand5.Override.AllowMultiCellOperations = (AllowMultiCellOperation) 0;
    ultraGridBand5.Override.AllowRowFiltering = (DefaultableBoolean) 2;
    ultraGridBand5.Override.AllowRowLayoutCellSizing = (RowLayoutSizing) 1;
    ultraGridBand5.Override.AllowRowLayoutCellSpanSizing = (GridBagLayoutAllowSpanSizing) 1;
    ultraGridBand5.Override.AllowRowLayoutColMoving = (GridBagLayoutAllowMoving) 1;
    ultraGridBand5.Override.AllowRowLayoutLabelSizing = (RowLayoutSizing) 1;
    ultraGridBand5.Override.AllowRowLayoutLabelSpanSizing = (GridBagLayoutAllowSpanSizing) 1;
    ultraGridBand5.Override.AllowRowSummaries = (AllowRowSummaries) 2;
    ultraGridBand5.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance58).TextHAlignAsString = "Left";
    ultraGridBand5.Override.HeaderAppearance = (AppearanceBase) appearance58;
    ultraGridBand5.Override.HeaderClickAction = (HeaderClickAction) 2;
    ultraGridLayout4.BandsSerializer.Add((object) ultraGridBand5);
    ultraGridLayout4.BorderStyle = (UIElementBorderStyle) 4;
    ((KeyedSubObjectBase) ultraGridLayout4).Key = "LossTypes";
    ((AppearanceBase) appearance59).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance59).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance59).ForeColor = Color.Black;
    ultraGridLayout4.Override.ActiveRowAppearance = (AppearanceBase) appearance59;
    ultraGridLayout4.Override.AllowColSizing = (AllowColSizing) 3;
    ultraGridLayout4.Override.AllowDelete = (DefaultableBoolean) 2;
    ultraGridLayout4.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance60).BorderColor = Color.LightGray;
    ultraGridLayout4.Override.CellAppearance = (AppearanceBase) appearance60;
    ultraGridLayout4.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance61).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ultraGridLayout4.Override.HeaderAppearance = (AppearanceBase) appearance61;
    ultraGridLayout4.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance62).BackColor = Color.FromArgb(246, 250, 253);
    ultraGridLayout4.Override.RowAlternateAppearance = (AppearanceBase) appearance62;
    ((AppearanceBase) appearance63).BorderColor = Color.LightGray;
    ultraGridLayout4.Override.RowAppearance = (AppearanceBase) appearance63;
    ultraGridLayout4.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance64).BackColor = Color.Transparent;
    ((AppearanceBase) appearance64).ForeColor = Color.Black;
    ultraGridLayout4.Override.SelectedRowAppearance = (AppearanceBase) appearance64;
    ((AppearanceBase) appearance65).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance65).BorderColor = Color.Silver;
    scrollBarLook5.ButtonAppearance = (AppearanceBase) appearance65;
    ((AppearanceBase) appearance66).BackColor = Color.White;
    scrollBarLook5.TrackAppearance = (AppearanceBase) appearance66;
    ultraGridLayout4.ScrollBarLook = scrollBarLook5;
    ((AppearanceBase) appearance67).BackColor = Color.White;
    ((AppearanceBase) appearance67).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ultraGridLayout5.Appearance = (AppearanceBase) appearance67;
    ultraGridLayout5.AutoFitStyle = (AutoFitStyle) 1;
    ((HeaderBase) ultraGridColumn15.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn15.Header).VisiblePosition = 0;
    ultraGridColumn15.Hidden = true;
    ultraGridColumn15.Width = 122;
    ((HeaderBase) ultraGridColumn16.Header).Caption = "Facility Name";
    ((HeaderBase) ultraGridColumn16.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn16.Header).VisiblePosition = 1;
    ultraGridColumn16.Width = 407;
    ((HeaderBase) ultraGridColumn17.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn17.Header).VisiblePosition = 2;
    ultraGridColumn17.Hidden = true;
    ultraGridColumn17.Width = 167;
    ((HeaderBase) ultraGridColumn18.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn18.Header).VisiblePosition = 3;
    ultraGridColumn18.Hidden = true;
    ultraGridColumn18.Width = 250;
    ((HeaderBase) ultraGridColumn19.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn19.Header).VisiblePosition = 4;
    ultraGridColumn19.Hidden = true;
    ultraGridColumn19.Width = 83;
    ((HeaderBase) ultraGridColumn20.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn20.Header).VisiblePosition = 5;
    ultraGridColumn20.Hidden = true;
    ultraGridColumn20.Width = 31 /*0x1F*/;
    ((HeaderBase) ultraGridColumn21.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn21.Header).VisiblePosition = 6;
    ultraGridColumn21.Hidden = true;
    ultraGridColumn21.Width = 33;
    ((HeaderBase) ultraGridColumn22.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn22.Header).VisiblePosition = 7;
    ultraGridColumn22.Hidden = true;
    ultraGridColumn22.Width = 98;
    ((HeaderBase) ultraGridColumn23.Header).Caption = "Date Entered";
    ((HeaderBase) ultraGridColumn23.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn23.Header).VisiblePosition = 8;
    ultraGridColumn23.Width = 99;
    ((HeaderBase) ultraGridColumn24.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn24.Header).VisiblePosition = 9;
    ultraGridColumn24.Hidden = true;
    ultraGridColumn24.Width = 85;
    ((HeaderBase) ultraGridColumn25.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn25.Header).VisiblePosition = 10;
    ultraGridColumn25.Hidden = true;
    ultraGridColumn25.Width = 33;
    ((HeaderBase) ultraGridColumn26.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn26.Header).VisiblePosition = 11;
    ultraGridColumn26.Hidden = true;
    ultraGridColumn26.Width = 85;
    ultraGridBand6.Columns.AddRange(new object[12]
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
      (object) ultraGridColumn26
    });
    ((AppearanceBase) appearance68).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridBand6.Header).Appearance = (AppearanceBase) appearance68;
    ((HeaderBase) ultraGridBand6.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridBand6.Override.AllowAddNew = (AllowAddNew) 2;
    ultraGridBand6.Override.AllowColMoving = (AllowColMoving) 1;
    ultraGridBand6.Override.AllowColSizing = (AllowColSizing) 1;
    ultraGridBand6.Override.AllowColSwapping = (AllowColSwapping) 1;
    ultraGridBand6.Override.AllowDelete = (DefaultableBoolean) 1;
    ultraGridBand6.Override.AllowGroupBy = (DefaultableBoolean) 2;
    ultraGridBand6.Override.AllowGroupMoving = (AllowGroupMoving) 1;
    ultraGridBand6.Override.AllowGroupSwapping = (AllowGroupSwapping) 1;
    ultraGridBand6.Override.AllowMultiCellOperations = (AllowMultiCellOperation) 0;
    ultraGridBand6.Override.AllowRowFiltering = (DefaultableBoolean) 2;
    ultraGridBand6.Override.AllowRowLayoutCellSizing = (RowLayoutSizing) 1;
    ultraGridBand6.Override.AllowRowLayoutCellSpanSizing = (GridBagLayoutAllowSpanSizing) 1;
    ultraGridBand6.Override.AllowRowLayoutColMoving = (GridBagLayoutAllowMoving) 1;
    ultraGridBand6.Override.AllowRowLayoutLabelSizing = (RowLayoutSizing) 1;
    ultraGridBand6.Override.AllowRowLayoutLabelSpanSizing = (GridBagLayoutAllowSpanSizing) 1;
    ultraGridBand6.Override.AllowRowSummaries = (AllowRowSummaries) 2;
    ultraGridBand6.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance69).TextHAlignAsString = "Left";
    ultraGridBand6.Override.HeaderAppearance = (AppearanceBase) appearance69;
    ultraGridBand6.Override.HeaderClickAction = (HeaderClickAction) 2;
    ultraGridLayout5.BandsSerializer.Add((object) ultraGridBand6);
    ultraGridLayout5.BorderStyle = (UIElementBorderStyle) 4;
    ((KeyedSubObjectBase) ultraGridLayout5).Key = "ManagedCareFacilities";
    ((AppearanceBase) appearance70).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance70).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance70).ForeColor = Color.Black;
    ultraGridLayout5.Override.ActiveRowAppearance = (AppearanceBase) appearance70;
    ultraGridLayout5.Override.AllowColSizing = (AllowColSizing) 3;
    ultraGridLayout5.Override.AllowDelete = (DefaultableBoolean) 2;
    ultraGridLayout5.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance71).BorderColor = Color.LightGray;
    ultraGridLayout5.Override.CellAppearance = (AppearanceBase) appearance71;
    ultraGridLayout5.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance72).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ultraGridLayout5.Override.HeaderAppearance = (AppearanceBase) appearance72;
    ultraGridLayout5.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance73).BackColor = Color.FromArgb(246, 250, 253);
    ultraGridLayout5.Override.RowAlternateAppearance = (AppearanceBase) appearance73;
    ((AppearanceBase) appearance74).BorderColor = Color.LightGray;
    ultraGridLayout5.Override.RowAppearance = (AppearanceBase) appearance74;
    ultraGridLayout5.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance75).BackColor = Color.Transparent;
    ((AppearanceBase) appearance75).ForeColor = Color.Black;
    ultraGridLayout5.Override.SelectedRowAppearance = (AppearanceBase) appearance75;
    ((AppearanceBase) appearance76).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance76).BorderColor = Color.Silver;
    scrollBarLook6.ButtonAppearance = (AppearanceBase) appearance76;
    ((AppearanceBase) appearance77).BackColor = Color.White;
    scrollBarLook6.TrackAppearance = (AppearanceBase) appearance77;
    ultraGridLayout5.ScrollBarLook = scrollBarLook6;
    ((AppearanceBase) appearance78).BackColor = Color.White;
    ((AppearanceBase) appearance78).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ultraGridLayout6.Appearance = (AppearanceBase) appearance78;
    ultraGridLayout6.AutoFitStyle = (AutoFitStyle) 1;
    ((HeaderBase) ultraGridColumn27.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn27.Header).VisiblePosition = 0;
    ultraGridColumn27.Hidden = true;
    ultraGridColumn27.Width = 166;
    ((HeaderBase) ultraGridColumn28.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn28.Header).VisiblePosition = 1;
    ultraGridColumn28.Hidden = true;
    ultraGridColumn28.Width = 73;
    ((HeaderBase) ultraGridColumn29.Header).Caption = "Sub-Type Description";
    ((HeaderBase) ultraGridColumn29.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn29.Header).VisiblePosition = 2;
    ultraGridColumn29.Width = 380;
    ((AppearanceBase) appearance79).TextHAlignAsString = "Center";
    ((HeaderBase) ultraGridColumn30.Header).Appearance = (AppearanceBase) appearance79;
    ((HeaderBase) ultraGridColumn30.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn30.Header).VisiblePosition = 3;
    ultraGridColumn30.Width = 126;
    ultraGridBand7.Columns.AddRange(new object[4]
    {
      (object) ultraGridColumn27,
      (object) ultraGridColumn28,
      (object) ultraGridColumn29,
      (object) ultraGridColumn30
    });
    ((AppearanceBase) appearance80).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridBand7.Header).Appearance = (AppearanceBase) appearance80;
    ((HeaderBase) ultraGridBand7.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridBand7.Override.AllowAddNew = (AllowAddNew) 2;
    ultraGridBand7.Override.AllowColMoving = (AllowColMoving) 1;
    ultraGridBand7.Override.AllowColSizing = (AllowColSizing) 1;
    ultraGridBand7.Override.AllowColSwapping = (AllowColSwapping) 1;
    ultraGridBand7.Override.AllowDelete = (DefaultableBoolean) 1;
    ultraGridBand7.Override.AllowGroupBy = (DefaultableBoolean) 2;
    ultraGridBand7.Override.AllowGroupMoving = (AllowGroupMoving) 1;
    ultraGridBand7.Override.AllowGroupSwapping = (AllowGroupSwapping) 1;
    ultraGridBand7.Override.AllowMultiCellOperations = (AllowMultiCellOperation) 0;
    ultraGridBand7.Override.AllowRowFiltering = (DefaultableBoolean) 2;
    ultraGridBand7.Override.AllowRowLayoutCellSizing = (RowLayoutSizing) 1;
    ultraGridBand7.Override.AllowRowLayoutCellSpanSizing = (GridBagLayoutAllowSpanSizing) 1;
    ultraGridBand7.Override.AllowRowLayoutColMoving = (GridBagLayoutAllowMoving) 1;
    ultraGridBand7.Override.AllowRowLayoutLabelSizing = (RowLayoutSizing) 1;
    ultraGridBand7.Override.AllowRowLayoutLabelSpanSizing = (GridBagLayoutAllowSpanSizing) 1;
    ultraGridBand7.Override.AllowRowSummaries = (AllowRowSummaries) 2;
    ultraGridBand7.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance81).TextHAlignAsString = "Left";
    ultraGridBand7.Override.HeaderAppearance = (AppearanceBase) appearance81;
    ultraGridBand7.Override.HeaderClickAction = (HeaderClickAction) 2;
    ultraGridLayout6.BandsSerializer.Add((object) ultraGridBand7);
    ultraGridLayout6.BorderStyle = (UIElementBorderStyle) 4;
    ((KeyedSubObjectBase) ultraGridLayout6).Key = "ReservePaymentSubTypes";
    ((AppearanceBase) appearance82).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance82).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance82).ForeColor = Color.Black;
    ultraGridLayout6.Override.ActiveRowAppearance = (AppearanceBase) appearance82;
    ultraGridLayout6.Override.AllowColSizing = (AllowColSizing) 3;
    ultraGridLayout6.Override.AllowDelete = (DefaultableBoolean) 2;
    ultraGridLayout6.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance83).BorderColor = Color.LightGray;
    ultraGridLayout6.Override.CellAppearance = (AppearanceBase) appearance83;
    ultraGridLayout6.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance84).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ultraGridLayout6.Override.HeaderAppearance = (AppearanceBase) appearance84;
    ultraGridLayout6.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance85).BackColor = Color.FromArgb(246, 250, 253);
    ultraGridLayout6.Override.RowAlternateAppearance = (AppearanceBase) appearance85;
    ((AppearanceBase) appearance86).BorderColor = Color.LightGray;
    ultraGridLayout6.Override.RowAppearance = (AppearanceBase) appearance86;
    ultraGridLayout6.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance87).BackColor = Color.Transparent;
    ((AppearanceBase) appearance87).ForeColor = Color.Black;
    ultraGridLayout6.Override.SelectedRowAppearance = (AppearanceBase) appearance87;
    ((AppearanceBase) appearance88).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance88).BorderColor = Color.Silver;
    scrollBarLook7.ButtonAppearance = (AppearanceBase) appearance88;
    ((AppearanceBase) appearance89).BackColor = Color.White;
    scrollBarLook7.TrackAppearance = (AppearanceBase) appearance89;
    ultraGridLayout6.ScrollBarLook = scrollBarLook7;
    ((AppearanceBase) appearance90).BackColor = Color.White;
    ((AppearanceBase) appearance90).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ultraGridLayout7.Appearance = (AppearanceBase) appearance90;
    ultraGridLayout7.AutoFitStyle = (AutoFitStyle) 1;
    ((HeaderBase) ultraGridColumn31.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn31.Header).VisiblePosition = 0;
    ultraGridColumn31.Hidden = true;
    ultraGridColumn31.Width = 199;
    ((HeaderBase) ultraGridColumn32.Header).Caption = "Reserve/Payment Type";
    ((HeaderBase) ultraGridColumn32.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn32.Header).VisiblePosition = 1;
    ultraGridColumn32.Width = 506;
    ultraGridBand8.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn31,
      (object) ultraGridColumn32
    });
    ((AppearanceBase) appearance91).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridBand8.Header).Appearance = (AppearanceBase) appearance91;
    ((HeaderBase) ultraGridBand8.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridBand8.Override.AllowAddNew = (AllowAddNew) 2;
    ultraGridBand8.Override.AllowColMoving = (AllowColMoving) 1;
    ultraGridBand8.Override.AllowColSizing = (AllowColSizing) 1;
    ultraGridBand8.Override.AllowColSwapping = (AllowColSwapping) 1;
    ultraGridBand8.Override.AllowDelete = (DefaultableBoolean) 1;
    ultraGridBand8.Override.AllowGroupBy = (DefaultableBoolean) 2;
    ultraGridBand8.Override.AllowGroupMoving = (AllowGroupMoving) 1;
    ultraGridBand8.Override.AllowGroupSwapping = (AllowGroupSwapping) 1;
    ultraGridBand8.Override.AllowMultiCellOperations = (AllowMultiCellOperation) 0;
    ultraGridBand8.Override.AllowRowFiltering = (DefaultableBoolean) 2;
    ultraGridBand8.Override.AllowRowLayoutCellSizing = (RowLayoutSizing) 1;
    ultraGridBand8.Override.AllowRowLayoutCellSpanSizing = (GridBagLayoutAllowSpanSizing) 1;
    ultraGridBand8.Override.AllowRowLayoutColMoving = (GridBagLayoutAllowMoving) 1;
    ultraGridBand8.Override.AllowRowLayoutLabelSizing = (RowLayoutSizing) 1;
    ultraGridBand8.Override.AllowRowLayoutLabelSpanSizing = (GridBagLayoutAllowSpanSizing) 1;
    ultraGridBand8.Override.AllowRowSummaries = (AllowRowSummaries) 2;
    ultraGridBand8.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance92).TextHAlignAsString = "Left";
    ultraGridBand8.Override.HeaderAppearance = (AppearanceBase) appearance92;
    ultraGridBand8.Override.HeaderClickAction = (HeaderClickAction) 2;
    ultraGridLayout7.BandsSerializer.Add((object) ultraGridBand8);
    ultraGridLayout7.BorderStyle = (UIElementBorderStyle) 4;
    ((KeyedSubObjectBase) ultraGridLayout7).Key = "ReservePaymentTypes";
    ((AppearanceBase) appearance93).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance93).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance93).ForeColor = Color.Black;
    ultraGridLayout7.Override.ActiveRowAppearance = (AppearanceBase) appearance93;
    ultraGridLayout7.Override.AllowColSizing = (AllowColSizing) 3;
    ultraGridLayout7.Override.AllowDelete = (DefaultableBoolean) 2;
    ultraGridLayout7.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance94).BorderColor = Color.LightGray;
    ultraGridLayout7.Override.CellAppearance = (AppearanceBase) appearance94;
    ultraGridLayout7.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance95).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ultraGridLayout7.Override.HeaderAppearance = (AppearanceBase) appearance95;
    ultraGridLayout7.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance96).BackColor = Color.FromArgb(246, 250, 253);
    ultraGridLayout7.Override.RowAlternateAppearance = (AppearanceBase) appearance96;
    ((AppearanceBase) appearance97).BorderColor = Color.LightGray;
    ultraGridLayout7.Override.RowAppearance = (AppearanceBase) appearance97;
    ultraGridLayout7.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance98).BackColor = Color.Transparent;
    ((AppearanceBase) appearance98).ForeColor = Color.Black;
    ultraGridLayout7.Override.SelectedRowAppearance = (AppearanceBase) appearance98;
    ((AppearanceBase) appearance99).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance99).BorderColor = Color.Silver;
    scrollBarLook8.ButtonAppearance = (AppearanceBase) appearance99;
    ((AppearanceBase) appearance100).BackColor = Color.White;
    scrollBarLook8.TrackAppearance = (AppearanceBase) appearance100;
    ultraGridLayout7.ScrollBarLook = scrollBarLook8;
    ((AppearanceBase) appearance101).BackColor = Color.White;
    ((AppearanceBase) appearance101).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ultraGridLayout8.Appearance = (AppearanceBase) appearance101;
    ultraGridLayout8.AutoFitStyle = (AutoFitStyle) 1;
    ((HeaderBase) ultraGridColumn33.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn33.Header).VisiblePosition = 0;
    ultraGridColumn33.Hidden = true;
    ultraGridColumn33.Width = 258;
    ((HeaderBase) ultraGridColumn34.Header).Caption = "Settlement Type";
    ((HeaderBase) ultraGridColumn34.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn34.Header).VisiblePosition = 1;
    ultraGridColumn34.Width = 506;
    ultraGridBand9.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn33,
      (object) ultraGridColumn34
    });
    ((AppearanceBase) appearance102).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridBand9.Header).Appearance = (AppearanceBase) appearance102;
    ((HeaderBase) ultraGridBand9.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridBand9.Override.AllowAddNew = (AllowAddNew) 2;
    ultraGridBand9.Override.AllowColMoving = (AllowColMoving) 1;
    ultraGridBand9.Override.AllowColSizing = (AllowColSizing) 1;
    ultraGridBand9.Override.AllowColSwapping = (AllowColSwapping) 1;
    ultraGridBand9.Override.AllowDelete = (DefaultableBoolean) 1;
    ultraGridBand9.Override.AllowGroupBy = (DefaultableBoolean) 2;
    ultraGridBand9.Override.AllowGroupMoving = (AllowGroupMoving) 1;
    ultraGridBand9.Override.AllowGroupSwapping = (AllowGroupSwapping) 1;
    ultraGridBand9.Override.AllowMultiCellOperations = (AllowMultiCellOperation) 0;
    ultraGridBand9.Override.AllowRowFiltering = (DefaultableBoolean) 2;
    ultraGridBand9.Override.AllowRowLayoutCellSizing = (RowLayoutSizing) 1;
    ultraGridBand9.Override.AllowRowLayoutCellSpanSizing = (GridBagLayoutAllowSpanSizing) 1;
    ultraGridBand9.Override.AllowRowLayoutColMoving = (GridBagLayoutAllowMoving) 1;
    ultraGridBand9.Override.AllowRowLayoutLabelSizing = (RowLayoutSizing) 1;
    ultraGridBand9.Override.AllowRowLayoutLabelSpanSizing = (GridBagLayoutAllowSpanSizing) 1;
    ultraGridBand9.Override.AllowRowSummaries = (AllowRowSummaries) 2;
    ultraGridBand9.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance103).TextHAlignAsString = "Left";
    ultraGridBand9.Override.HeaderAppearance = (AppearanceBase) appearance103;
    ultraGridBand9.Override.HeaderClickAction = (HeaderClickAction) 2;
    ultraGridLayout8.BandsSerializer.Add((object) ultraGridBand9);
    ultraGridLayout8.BorderStyle = (UIElementBorderStyle) 4;
    ((KeyedSubObjectBase) ultraGridLayout8).Key = "SettlementTypes";
    ((AppearanceBase) appearance104).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance104).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance104).ForeColor = Color.Black;
    ultraGridLayout8.Override.ActiveRowAppearance = (AppearanceBase) appearance104;
    ultraGridLayout8.Override.AllowColSizing = (AllowColSizing) 3;
    ultraGridLayout8.Override.AllowDelete = (DefaultableBoolean) 2;
    ultraGridLayout8.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance105).BorderColor = Color.LightGray;
    ultraGridLayout8.Override.CellAppearance = (AppearanceBase) appearance105;
    ultraGridLayout8.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance106).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ultraGridLayout8.Override.HeaderAppearance = (AppearanceBase) appearance106;
    ultraGridLayout8.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance107).BackColor = Color.FromArgb(246, 250, 253);
    ultraGridLayout8.Override.RowAlternateAppearance = (AppearanceBase) appearance107;
    ((AppearanceBase) appearance108).BorderColor = Color.LightGray;
    ultraGridLayout8.Override.RowAppearance = (AppearanceBase) appearance108;
    ultraGridLayout8.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance109).BackColor = Color.Transparent;
    ((AppearanceBase) appearance109).ForeColor = Color.Black;
    ultraGridLayout8.Override.SelectedRowAppearance = (AppearanceBase) appearance109;
    ((AppearanceBase) appearance110).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance110).BorderColor = Color.Silver;
    scrollBarLook9.ButtonAppearance = (AppearanceBase) appearance110;
    ((AppearanceBase) appearance111).BackColor = Color.White;
    scrollBarLook9.TrackAppearance = (AppearanceBase) appearance111;
    ultraGridLayout8.ScrollBarLook = scrollBarLook9;
    ((AppearanceBase) appearance112).BackColor = Color.White;
    ((AppearanceBase) appearance112).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ultraGridLayout9.Appearance = (AppearanceBase) appearance112;
    ultraGridLayout9.AutoFitStyle = (AutoFitStyle) 1;
    ((HeaderBase) ultraGridColumn35.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn35.Header).VisiblePosition = 0;
    ultraGridColumn35.Hidden = true;
    ultraGridColumn35.Width = 131;
    ((HeaderBase) ultraGridColumn36.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn36.Header).VisiblePosition = 1;
    ultraGridColumn36.Hidden = true;
    ultraGridColumn36.Width = 82;
    ((HeaderBase) ultraGridColumn37.Header).Caption = "Coverage Type Description";
    ((HeaderBase) ultraGridColumn37.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn37.Header).VisiblePosition = 2;
    ultraGridColumn37.Width = 506;
    ultraGridBand10.Columns.AddRange(new object[3]
    {
      (object) ultraGridColumn35,
      (object) ultraGridColumn36,
      (object) ultraGridColumn37
    });
    ((AppearanceBase) appearance113).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridBand10.Header).Appearance = (AppearanceBase) appearance113;
    ((HeaderBase) ultraGridBand10.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridBand10.Override.AllowAddNew = (AllowAddNew) 2;
    ultraGridBand10.Override.AllowColMoving = (AllowColMoving) 1;
    ultraGridBand10.Override.AllowColSizing = (AllowColSizing) 1;
    ultraGridBand10.Override.AllowColSwapping = (AllowColSwapping) 1;
    ultraGridBand10.Override.AllowDelete = (DefaultableBoolean) 1;
    ultraGridBand10.Override.AllowGroupBy = (DefaultableBoolean) 2;
    ultraGridBand10.Override.AllowGroupMoving = (AllowGroupMoving) 1;
    ultraGridBand10.Override.AllowGroupSwapping = (AllowGroupSwapping) 1;
    ultraGridBand10.Override.AllowMultiCellOperations = (AllowMultiCellOperation) 0;
    ultraGridBand10.Override.AllowRowFiltering = (DefaultableBoolean) 2;
    ultraGridBand10.Override.AllowRowLayoutCellSizing = (RowLayoutSizing) 1;
    ultraGridBand10.Override.AllowRowLayoutCellSpanSizing = (GridBagLayoutAllowSpanSizing) 1;
    ultraGridBand10.Override.AllowRowLayoutColMoving = (GridBagLayoutAllowMoving) 1;
    ultraGridBand10.Override.AllowRowLayoutLabelSizing = (RowLayoutSizing) 1;
    ultraGridBand10.Override.AllowRowLayoutLabelSpanSizing = (GridBagLayoutAllowSpanSizing) 1;
    ultraGridBand10.Override.AllowRowSummaries = (AllowRowSummaries) 2;
    ultraGridBand10.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance114).TextHAlignAsString = "Left";
    ultraGridBand10.Override.HeaderAppearance = (AppearanceBase) appearance114;
    ultraGridBand10.Override.HeaderClickAction = (HeaderClickAction) 2;
    ultraGridLayout9.BandsSerializer.Add((object) ultraGridBand10);
    ultraGridLayout9.BorderStyle = (UIElementBorderStyle) 4;
    ((KeyedSubObjectBase) ultraGridLayout9).Key = "CoverageTypeDescriptions";
    ((AppearanceBase) appearance115).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance115).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance115).ForeColor = Color.Black;
    ultraGridLayout9.Override.ActiveRowAppearance = (AppearanceBase) appearance115;
    ultraGridLayout9.Override.AllowColSizing = (AllowColSizing) 3;
    ultraGridLayout9.Override.AllowDelete = (DefaultableBoolean) 2;
    ultraGridLayout9.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance116).BorderColor = Color.LightGray;
    ultraGridLayout9.Override.CellAppearance = (AppearanceBase) appearance116;
    ultraGridLayout9.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance117).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ultraGridLayout9.Override.HeaderAppearance = (AppearanceBase) appearance117;
    ultraGridLayout9.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance118).BackColor = Color.FromArgb(246, 250, 253);
    ultraGridLayout9.Override.RowAlternateAppearance = (AppearanceBase) appearance118;
    ((AppearanceBase) appearance119).BorderColor = Color.LightGray;
    ultraGridLayout9.Override.RowAppearance = (AppearanceBase) appearance119;
    ultraGridLayout9.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance120).BackColor = Color.Transparent;
    ((AppearanceBase) appearance120).ForeColor = Color.Black;
    ultraGridLayout9.Override.SelectedRowAppearance = (AppearanceBase) appearance120;
    ((AppearanceBase) appearance121).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance121).BorderColor = Color.Silver;
    scrollBarLook10.ButtonAppearance = (AppearanceBase) appearance121;
    ((AppearanceBase) appearance122).BackColor = Color.White;
    scrollBarLook10.TrackAppearance = (AppearanceBase) appearance122;
    ultraGridLayout9.ScrollBarLook = scrollBarLook10;
    ((AppearanceBase) appearance123).BackColor = Color.White;
    ((AppearanceBase) appearance123).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ultraGridLayout10.Appearance = (AppearanceBase) appearance123;
    ultraGridLayout10.AutoFitStyle = (AutoFitStyle) 1;
    ((HeaderBase) ultraGridColumn38.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn38.Header).VisiblePosition = 0;
    ultraGridColumn38.Hidden = true;
    ultraGridColumn38.Width = 122;
    ((HeaderBase) ultraGridColumn39.Header).Caption = "Outside Adjuster";
    ((HeaderBase) ultraGridColumn39.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn39.Header).VisiblePosition = 1;
    ultraGridColumn39.Width = 506;
    ((HeaderBase) ultraGridColumn40.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn40.Header).VisiblePosition = 2;
    ultraGridColumn40.Hidden = true;
    ultraGridColumn40.Width = 133;
    ((HeaderBase) ultraGridColumn41.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn41.Header).VisiblePosition = 3;
    ultraGridColumn41.Hidden = true;
    ultraGridColumn41.Width = 146;
    ((HeaderBase) ultraGridColumn42.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn42.Header).VisiblePosition = 4;
    ultraGridColumn42.Hidden = true;
    ultraGridColumn42.Width = 51;
    ((HeaderBase) ultraGridColumn43.Header).Caption = "Last Name";
    ((HeaderBase) ultraGridColumn43.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn43.Header).VisiblePosition = 6;
    ultraGridColumn43.Hidden = true;
    ultraGridColumn43.Width = 324;
    ((HeaderBase) ultraGridColumn44.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn44.Header).VisiblePosition = 7;
    ultraGridColumn44.Hidden = true;
    ultraGridColumn44.Width = 55;
    ((HeaderBase) ultraGridColumn45.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn45.Header).VisiblePosition = 8;
    ultraGridColumn45.Hidden = true;
    ultraGridColumn45.Width = 117;
    ((HeaderBase) ultraGridColumn46.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn46.Header).VisiblePosition = 9;
    ultraGridColumn46.Hidden = true;
    ultraGridColumn46.Width = 51;
    ((HeaderBase) ultraGridColumn47.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn47.Header).VisiblePosition = 5;
    ultraGridColumn47.Hidden = true;
    ultraGridColumn47.Width = 39;
    ((HeaderBase) ultraGridColumn48.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn48.Header).VisiblePosition = 10;
    ultraGridColumn48.Hidden = true;
    ultraGridColumn48.Width = 96 /*0x60*/;
    ((HeaderBase) ultraGridColumn49.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn49.Header).VisiblePosition = 11;
    ultraGridColumn49.Hidden = true;
    ultraGridColumn49.Width = 47;
    ((HeaderBase) ultraGridColumn50.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn50.Header).VisiblePosition = 12;
    ultraGridColumn50.Hidden = true;
    ultraGridColumn50.Width = 96 /*0x60*/;
    ((HeaderBase) ultraGridColumn51.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn51.Header).VisiblePosition = 13;
    ultraGridColumn51.Hidden = true;
    ultraGridColumn51.Width = 47;
    ultraGridBand11.Columns.AddRange(new object[14]
    {
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
      (object) ultraGridColumn51
    });
    ((AppearanceBase) appearance124).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridBand11.Header).Appearance = (AppearanceBase) appearance124;
    ((HeaderBase) ultraGridBand11.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridBand11.Override.AllowAddNew = (AllowAddNew) 2;
    ultraGridBand11.Override.AllowColMoving = (AllowColMoving) 1;
    ultraGridBand11.Override.AllowColSizing = (AllowColSizing) 1;
    ultraGridBand11.Override.AllowColSwapping = (AllowColSwapping) 1;
    ultraGridBand11.Override.AllowDelete = (DefaultableBoolean) 1;
    ultraGridBand11.Override.AllowGroupBy = (DefaultableBoolean) 2;
    ultraGridBand11.Override.AllowGroupMoving = (AllowGroupMoving) 1;
    ultraGridBand11.Override.AllowGroupSwapping = (AllowGroupSwapping) 1;
    ultraGridBand11.Override.AllowMultiCellOperations = (AllowMultiCellOperation) 0;
    ultraGridBand11.Override.AllowRowFiltering = (DefaultableBoolean) 2;
    ultraGridBand11.Override.AllowRowLayoutCellSizing = (RowLayoutSizing) 1;
    ultraGridBand11.Override.AllowRowLayoutCellSpanSizing = (GridBagLayoutAllowSpanSizing) 1;
    ultraGridBand11.Override.AllowRowLayoutColMoving = (GridBagLayoutAllowMoving) 1;
    ultraGridBand11.Override.AllowRowLayoutLabelSizing = (RowLayoutSizing) 1;
    ultraGridBand11.Override.AllowRowLayoutLabelSpanSizing = (GridBagLayoutAllowSpanSizing) 1;
    ultraGridBand11.Override.AllowRowSummaries = (AllowRowSummaries) 2;
    ultraGridBand11.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance125).TextHAlignAsString = "Left";
    ultraGridBand11.Override.HeaderAppearance = (AppearanceBase) appearance125;
    ultraGridBand11.Override.HeaderClickAction = (HeaderClickAction) 2;
    ultraGridLayout10.BandsSerializer.Add((object) ultraGridBand11);
    ultraGridLayout10.BorderStyle = (UIElementBorderStyle) 4;
    ((KeyedSubObjectBase) ultraGridLayout10).Key = "OutsideAdjusters";
    ((AppearanceBase) appearance126).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance126).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance126).ForeColor = Color.Black;
    ultraGridLayout10.Override.ActiveRowAppearance = (AppearanceBase) appearance126;
    ultraGridLayout10.Override.AllowColSizing = (AllowColSizing) 3;
    ultraGridLayout10.Override.AllowDelete = (DefaultableBoolean) 2;
    ultraGridLayout10.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance127).BorderColor = Color.LightGray;
    ultraGridLayout10.Override.CellAppearance = (AppearanceBase) appearance127;
    ultraGridLayout10.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance128).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ultraGridLayout10.Override.HeaderAppearance = (AppearanceBase) appearance128;
    ultraGridLayout10.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance129).BackColor = Color.FromArgb(246, 250, 253);
    ultraGridLayout10.Override.RowAlternateAppearance = (AppearanceBase) appearance129;
    ((AppearanceBase) appearance130).BorderColor = Color.LightGray;
    ultraGridLayout10.Override.RowAppearance = (AppearanceBase) appearance130;
    ultraGridLayout10.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance131).BackColor = Color.Transparent;
    ((AppearanceBase) appearance131).ForeColor = Color.Black;
    ultraGridLayout10.Override.SelectedRowAppearance = (AppearanceBase) appearance131;
    ((AppearanceBase) appearance132).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance132).BorderColor = Color.Silver;
    scrollBarLook11.ButtonAppearance = (AppearanceBase) appearance132;
    ((AppearanceBase) appearance133).BackColor = Color.White;
    scrollBarLook11.TrackAppearance = (AppearanceBase) appearance133;
    ultraGridLayout10.ScrollBarLook = scrollBarLook11;
    ((UltraGridBase) this.gridView).Layouts.Add(ultraGridLayout1);
    ((UltraGridBase) this.gridView).Layouts.Add(ultraGridLayout2);
    ((UltraGridBase) this.gridView).Layouts.Add(ultraGridLayout3);
    ((UltraGridBase) this.gridView).Layouts.Add(ultraGridLayout4);
    ((UltraGridBase) this.gridView).Layouts.Add(ultraGridLayout5);
    ((UltraGridBase) this.gridView).Layouts.Add(ultraGridLayout6);
    ((UltraGridBase) this.gridView).Layouts.Add(ultraGridLayout7);
    ((UltraGridBase) this.gridView).Layouts.Add(ultraGridLayout8);
    ((UltraGridBase) this.gridView).Layouts.Add(ultraGridLayout9);
    ((UltraGridBase) this.gridView).Layouts.Add(ultraGridLayout10);
    ((Control) this.gridView).Location = new Point(0, 0);
    ((Control) this.gridView).Name = "gridView";
    ((Control) this.gridView).Size = new Size(508, 473);
    ((Control) this.gridView).TabIndex = 0;
    ((UltraControlBase) this.gridView).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridView).UseOsThemes = (DefaultableBoolean) 2;
    this.gridView.AfterSelectChange += new AfterSelectChangeEventHandler(this.gridView_AfterSelectChange);
    this.gridView.BeforeSelectChange += new BeforeSelectChangeEventHandler(this.gridView_BeforeSelectChange);
    this.dsClaimsAdministration1.DataSetName = "dsClaimsAdministration";
    this.dsClaimsAdministration1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.panelTop.BackColor = Color.Transparent;
    this.panelTop.Controls.Add((Control) this.labelHeader);
    this.panelTop.Location = new Point(0, 0);
    this.panelTop.Name = "panelTop";
    this.panelTop.Size = new Size(508, 22);
    this.panelTop.TabIndex = 0;
    this.panelRight.BackColor = Color.Transparent;
    this.panelRight.Controls.Add((Control) this.textWebAddress);
    this.panelRight.Controls.Add((Control) this.label1);
    this.panelRight.Controls.Add((Control) this.dbSaveUIAddress);
    this.panelRight.Controls.Add((Control) this.dateTimeIncorporated);
    this.panelRight.Controls.Add((Control) this.label8);
    this.panelRight.Controls.Add((Control) this.maskedEditSSNFEIN);
    this.panelRight.Controls.Add((Control) this.label7);
    this.panelRight.Controls.Add((Control) this.label6);
    this.panelRight.Controls.Add((Control) this.textEmailAddress);
    this.panelRight.Controls.Add((Control) this.label5);
    this.panelRight.Controls.Add((Control) this.label4);
    this.panelRight.Controls.Add((Control) this.label3);
    this.panelRight.Controls.Add((Control) this.label2);
    this.panelRight.Controls.Add((Control) this.textCorporationName);
    this.panelRight.Controls.Add((Control) this.textLastName);
    this.panelRight.Controls.Add((Control) this.textMiddleName);
    this.panelRight.Controls.Add((Control) this.textFirstName);
    this.panelRight.Controls.Add((Control) this.optionEntityType);
    this.panelRight.Controls.Add((Control) this.addResolver);
    this.panelRight.Controls.Add((Control) this.mgaPhoneNumberEntry1);
    this.panelRight.Location = new Point(541, 3);
    this.panelRight.Name = "panelRight";
    this.panelRight.Size = new Size(393, 561);
    this.panelRight.TabIndex = 1;
    this.panelRight.Visible = false;
    ((AppearanceBase) appearance134).BackColor = Color.White;
    ((AppearanceBase) appearance134).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance134).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textWebAddress).Appearance = (AppearanceBase) appearance134;
    ((Control) this.textWebAddress).BackColor = Color.White;
    ((Control) this.textWebAddress).Location = new Point(118, 293);
    this.textWebAddress.MGAStyle = (MGAStyles) 2;
    ((Control) this.textWebAddress).Name = "textWebAddress";
    ((Control) this.textWebAddress).Size = new Size(257, 20);
    ((Control) this.textWebAddress).TabIndex = 12;
    ((UltraControlBase) this.textWebAddress).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textWebAddress).UseOsThemes = (DefaultableBoolean) 2;
    this.label1.AutoSize = true;
    this.label1.Location = new Point(10, 293);
    this.label1.Name = "label1";
    this.label1.Size = new Size(78, 13);
    this.label1.TabIndex = 24;
    this.label1.Text = "Web  Address:";
    this.dbSaveUIAddress.FreezeEvents = false;
    ((Control) this.dbSaveUIAddress).Location = new Point(260, 516);
    ((Control) this.dbSaveUIAddress).Name = "dbSaveUIAddress";
    ((Control) this.dbSaveUIAddress).Size = new Size(112 /*0x70*/, 40);
    ((Control) this.dbSaveUIAddress).TabIndex = 23;
    this.dbSaveUIAddress.UIState = (UIState) 1;
    this.dbSaveUIAddress.ClickedNew += new EventHandler(this.dbSaveUIAddress_ClickedNew);
    this.dbSaveUIAddress.ClickingSave += new CancelEventHandler(this.dbSaveUIAddress_ClickingSave);
    this.dbSaveUIAddress.ClickedSave += new EventHandler(this.dbSaveUIAddress_ClickedSave);
    this.dbSaveUIAddress.ClickedDelete += new EventHandler(this.dbSaveUIAddress_ClickedDelete);
    this.dbSaveUIAddress.ClickedCancel += new EventHandler(this.dbSaveUIAddress_ClickedCancel);
    this.dbSaveUIAddress.ClickedEdit += new EventHandler(this.dbSaveUIAddress_ClickedEdit);
    ((AppearanceBase) appearance135).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraDateTimeEditor) this.dateTimeIncorporated).Appearance = (AppearanceBase) appearance135;
    ((AppearanceBase) appearance136).AlphaLevel = (short) 14;
    ((AppearanceBase) appearance136).BackColor = Color.FromArgb(0, 0, 246, 253);
    ((AppearanceBase) appearance136).BackColor2 = Color.FromArgb(133, 162, 221);
    ((AppearanceBase) appearance136).BackColorAlpha = (Alpha) 2;
    ((AppearanceBase) appearance136).BackGradientAlignment = (GradientAlignment) 4;
    ((AppearanceBase) appearance136).BackGradientStyle = (GradientStyle) 5;
    ((AppearanceBase) appearance136).BorderAlpha = (Alpha) 1;
    ((AppearanceBase) appearance136).BorderColor = Color.FromArgb(78, 122, 171);
    ((AppearanceBase) appearance136).ForeColor = Color.FromArgb(49, 85, 153);
    ((AppearanceBase) appearance136).ForegroundAlpha = (Alpha) 2;
    ((UltraDateTimeEditor) this.dateTimeIncorporated).ButtonAppearance = (AppearanceBase) appearance136;
    ((UltraDateTimeEditor) this.dateTimeIncorporated).DateTime = new DateTime(2009, 1, 15, 0, 0, 0, 0);
    ((Control) this.dateTimeIncorporated).Location = new Point(118, 341);
    this.dateTimeIncorporated.MGAStyle = (MGAStyles) 2;
    ((Control) this.dateTimeIncorporated).Name = "dateTimeIncorporated";
    ((Control) this.dateTimeIncorporated).Size = new Size(89, 20);
    ((Control) this.dateTimeIncorporated).TabIndex = 15;
    ((UltraControlBase) this.dateTimeIncorporated).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dateTimeIncorporated).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDateTimeEditor) this.dateTimeIncorporated).Value = (object) new DateTime(2009, 1, 15, 0, 0, 0, 0);
    this.label8.AutoSize = true;
    this.label8.Location = new Point(10, 341);
    this.label8.Name = "label8";
    this.label8.Size = new Size(100, 13);
    this.label8.TabIndex = 14;
    this.label8.Text = "Date Incorporated:";
    ((AppearanceBase) appearance137).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraMaskedEdit) this.maskedEditSSNFEIN).Appearance = (AppearanceBase) appearance137;
    ((UltraMaskedEdit) this.maskedEditSSNFEIN).DataMode = (MaskMode) 0;
    ((UltraMaskedEdit) this.maskedEditSSNFEIN).EditAs = (EditAsType) 1;
    ((UltraMaskedEdit) this.maskedEditSSNFEIN).InputMask = "999-99-9999";
    ((Control) this.maskedEditSSNFEIN).Location = new Point(118, 317);
    this.maskedEditSSNFEIN.MGAStyle = (MGAStyles) 2;
    ((Control) this.maskedEditSSNFEIN).Name = "maskedEditSSNFEIN";
    ((UltraMaskedEdit) this.maskedEditSSNFEIN).NonAutoSizeHeight = 22;
    ((Control) this.maskedEditSSNFEIN).Size = new Size(79, 21);
    ((Control) this.maskedEditSSNFEIN).TabIndex = 13;
    ((UltraControlBase) this.maskedEditSSNFEIN).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.maskedEditSSNFEIN).UseOsThemes = (DefaultableBoolean) 2;
    this.label7.AutoSize = true;
    this.label7.Location = new Point(10, 317);
    this.label7.Name = "label7";
    this.label7.Size = new Size(57, 13);
    this.label7.TabIndex = 12;
    this.label7.Text = "SSN/FEIN:";
    this.label6.AutoSize = true;
    this.label6.Location = new Point(11, 269);
    this.label6.Name = "label6";
    this.label6.Size = new Size(77, 13);
    this.label6.TabIndex = 10;
    this.label6.Text = "Email Address:";
    ((AppearanceBase) appearance138).BackColor = Color.White;
    ((AppearanceBase) appearance138).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance138).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textEmailAddress).Appearance = (AppearanceBase) appearance138;
    ((Control) this.textEmailAddress).BackColor = Color.White;
    ((Control) this.textEmailAddress).Location = new Point(118, 269);
    this.textEmailAddress.MGAStyle = (MGAStyles) 2;
    ((Control) this.textEmailAddress).Name = "textEmailAddress";
    ((Control) this.textEmailAddress).Size = new Size(257, 20);
    ((Control) this.textEmailAddress).TabIndex = 11;
    ((UltraControlBase) this.textEmailAddress).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textEmailAddress).UseOsThemes = (DefaultableBoolean) 2;
    this.label5.AutoSize = true;
    this.label5.Location = new Point(12, 79);
    this.label5.Name = "label5";
    this.label5.Size = new Size(71, 13);
    this.label5.TabIndex = 5;
    this.label5.Text = "Middle Name:";
    this.label4.AutoSize = true;
    this.label4.Location = new Point(12, 102);
    this.label4.Name = "label4";
    this.label4.Size = new Size(61, 13);
    this.label4.TabIndex = 7;
    this.label4.Text = "Last Name:";
    this.label3.AutoSize = true;
    this.label3.Location = new Point(12, 30);
    this.label3.Name = "label3";
    this.label3.Size = new Size(98, 13);
    this.label3.TabIndex = 1;
    this.label3.Text = "Corporation Name:";
    this.label2.AutoSize = true;
    this.label2.Location = new Point(12, 55);
    this.label2.Name = "label2";
    this.label2.Size = new Size(62, 13);
    this.label2.TabIndex = 3;
    this.label2.Text = "First Name:";
    ((AppearanceBase) appearance139).BackColor = Color.White;
    ((AppearanceBase) appearance139).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance139).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textCorporationName).Appearance = (AppearanceBase) appearance139;
    ((Control) this.textCorporationName).BackColor = Color.White;
    ((Control) this.textCorporationName).Location = new Point(118, 30);
    ((TextEditorControlBase) this.textCorporationName).MaxLength = 150;
    this.textCorporationName.MGAStyle = (MGAStyles) 2;
    ((Control) this.textCorporationName).Name = "textCorporationName";
    ((Control) this.textCorporationName).Size = new Size(257, 20);
    ((Control) this.textCorporationName).TabIndex = 2;
    ((UltraControlBase) this.textCorporationName).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textCorporationName).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance140).BackColor = Color.White;
    ((AppearanceBase) appearance140).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance140).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textLastName).Appearance = (AppearanceBase) appearance140;
    ((Control) this.textLastName).BackColor = Color.White;
    ((Control) this.textLastName).Location = new Point(118, 103);
    ((TextEditorControlBase) this.textLastName).MaxLength = 35;
    this.textLastName.MGAStyle = (MGAStyles) 2;
    ((Control) this.textLastName).Name = "textLastName";
    ((Control) this.textLastName).Size = new Size(227, 20);
    ((Control) this.textLastName).TabIndex = 8;
    ((UltraControlBase) this.textLastName).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textLastName).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance141).BackColor = Color.White;
    ((AppearanceBase) appearance141).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance141).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textMiddleName).Appearance = (AppearanceBase) appearance141;
    ((Control) this.textMiddleName).BackColor = Color.White;
    ((Control) this.textMiddleName).Location = new Point(118, 79);
    ((TextEditorControlBase) this.textMiddleName).MaxLength = 35;
    this.textMiddleName.MGAStyle = (MGAStyles) 2;
    ((Control) this.textMiddleName).Name = "textMiddleName";
    ((Control) this.textMiddleName).Size = new Size(227, 20);
    ((Control) this.textMiddleName).TabIndex = 6;
    ((UltraControlBase) this.textMiddleName).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textMiddleName).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance142).BackColor = Color.White;
    ((AppearanceBase) appearance142).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance142).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textFirstName).Appearance = (AppearanceBase) appearance142;
    ((Control) this.textFirstName).BackColor = Color.White;
    ((Control) this.textFirstName).Location = new Point(118, 55);
    ((TextEditorControlBase) this.textFirstName).MaxLength = 35;
    this.textFirstName.MGAStyle = (MGAStyles) 2;
    ((Control) this.textFirstName).Name = "textFirstName";
    ((Control) this.textFirstName).Size = new Size(227, 20);
    ((Control) this.textFirstName).TabIndex = 4;
    ((UltraControlBase) this.textFirstName).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textFirstName).UseOsThemes = (DefaultableBoolean) 2;
    this.optionEntityType.BorderStyle = (UIElementBorderStyle) 1;
    ((Control) this.optionEntityType).Enabled = false;
    this.optionEntityType.GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007RadioButtonGlyphInfo;
    valueListItem1.DataValue = (object) "I";
    valueListItem1.DisplayText = "Individual";
    valueListItem2.DataValue = (object) "C";
    valueListItem2.DisplayText = "Corporation";
    this.optionEntityType.Items.AddRange(new ValueListItem[2]
    {
      valueListItem1,
      valueListItem2
    });
    ((Control) this.optionEntityType).Location = new Point(14, 3);
    ((Control) this.optionEntityType).Name = "optionEntityType";
    ((Control) this.optionEntityType).Size = new Size(149, 19);
    ((Control) this.optionEntityType).TabIndex = 0;
    ((UltraControlBase) this.optionEntityType).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.optionEntityType).UseOsThemes = (DefaultableBoolean) 2;
    this.optionEntityType.ValueChanged += new EventHandler(this.optionEntityType_ValueChanged);
    this.addResolver.Address1 = "";
    this.addResolver.Address2 = "";
    this.addResolver.City = "";
    this.addResolver.County = "";
    ((Control) this.addResolver).Font = new Font("Tahoma", 8f);
    this.addResolver.ISOCountryCode = "";
    this.addResolver.ISOCountryCodeMember = "";
    this.addResolver.ISOCountryList = (object) null;
    this.addResolver.ISOCountryNameMember = "";
    ((Control) this.addResolver).Location = new Point(3, 118);
    this.addResolver.MGAStyle = (MGAStyles) 2;
    ((Control) this.addResolver).Name = "addResolver";
    this.addResolver.Password = (string) null;
    ((Control) this.addResolver).Size = new Size(291, 152);
    this.addResolver.State = "";
    ((Control) this.addResolver).TabIndex = 9;
    this.addResolver.TextAlign = ContentAlignment.TopLeft;
    this.addResolver.UserID = (string) null;
    this.addResolver.WebserviceUrl = (string) null;
    this.addResolver.ZipCode = "";
    this.addResolver.ZipCodeExtension = "";
    this.dsClaims_PhoneNumbers1.DataSetName = "dsClaims_PhoneNumbers";
    this.dsClaims_PhoneNumbers1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((Control) this._ClaimsAdministrationPortal_Toolbars_Dock_Area_Left).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._ClaimsAdministrationPortal_Toolbars_Dock_Area_Left).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._ClaimsAdministrationPortal_Toolbars_Dock_Area_Left.DockedPosition = (DockedPosition) 2;
    ((Control) this._ClaimsAdministrationPortal_Toolbars_Dock_Area_Left).ForeColor = SystemColors.ControlText;
    ((Control) this._ClaimsAdministrationPortal_Toolbars_Dock_Area_Left).Location = new Point(0, 0);
    ((Control) this._ClaimsAdministrationPortal_Toolbars_Dock_Area_Left).Name = "_ClaimsAdministrationPortal_Toolbars_Dock_Area_Left";
    ((Control) this._ClaimsAdministrationPortal_Toolbars_Dock_Area_Left).Size = new Size(0, 573);
    this._ClaimsAdministrationPortal_Toolbars_Dock_Area_Left.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._ClaimsAdministrationPortal_Toolbars_Dock_Area_Right).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._ClaimsAdministrationPortal_Toolbars_Dock_Area_Right).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._ClaimsAdministrationPortal_Toolbars_Dock_Area_Right.DockedPosition = (DockedPosition) 3;
    ((Control) this._ClaimsAdministrationPortal_Toolbars_Dock_Area_Right).ForeColor = SystemColors.ControlText;
    ((Control) this._ClaimsAdministrationPortal_Toolbars_Dock_Area_Right).Location = new Point(964, 0);
    ((Control) this._ClaimsAdministrationPortal_Toolbars_Dock_Area_Right).Name = "_ClaimsAdministrationPortal_Toolbars_Dock_Area_Right";
    ((Control) this._ClaimsAdministrationPortal_Toolbars_Dock_Area_Right).Size = new Size(0, 573);
    this._ClaimsAdministrationPortal_Toolbars_Dock_Area_Right.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._ClaimsAdministrationPortal_Toolbars_Dock_Area_Top).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._ClaimsAdministrationPortal_Toolbars_Dock_Area_Top).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._ClaimsAdministrationPortal_Toolbars_Dock_Area_Top.DockedPosition = (DockedPosition) 0;
    ((Control) this._ClaimsAdministrationPortal_Toolbars_Dock_Area_Top).ForeColor = SystemColors.ControlText;
    ((Control) this._ClaimsAdministrationPortal_Toolbars_Dock_Area_Top).Location = new Point(0, 0);
    ((Control) this._ClaimsAdministrationPortal_Toolbars_Dock_Area_Top).Name = "_ClaimsAdministrationPortal_Toolbars_Dock_Area_Top";
    ((Control) this._ClaimsAdministrationPortal_Toolbars_Dock_Area_Top).Size = new Size(964, 0);
    this._ClaimsAdministrationPortal_Toolbars_Dock_Area_Top.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._ClaimsAdministrationPortal_Toolbars_Dock_Area_Bottom).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._ClaimsAdministrationPortal_Toolbars_Dock_Area_Bottom).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._ClaimsAdministrationPortal_Toolbars_Dock_Area_Bottom.DockedPosition = (DockedPosition) 1;
    ((Control) this._ClaimsAdministrationPortal_Toolbars_Dock_Area_Bottom).ForeColor = SystemColors.ControlText;
    ((Control) this._ClaimsAdministrationPortal_Toolbars_Dock_Area_Bottom).Location = new Point(0, 573);
    ((Control) this._ClaimsAdministrationPortal_Toolbars_Dock_Area_Bottom).Name = "_ClaimsAdministrationPortal_Toolbars_Dock_Area_Bottom";
    ((Control) this._ClaimsAdministrationPortal_Toolbars_Dock_Area_Bottom).Size = new Size(964, 0);
    this._ClaimsAdministrationPortal_Toolbars_Dock_Area_Bottom.ToolbarsManager = this.ultraToolbarsManager1;
    this.mgaPhoneNumberEntry1.Enabled = false;
    this.mgaPhoneNumberEntry1.Font = new Font("Tahoma", 8.25f);
    this.mgaPhoneNumberEntry1.Location = new Point(8, 359);
    this.mgaPhoneNumberEntry1.Name = "mgaPhoneNumberEntry1";
    this.mgaPhoneNumberEntry1.Size = new Size(374, 154);
    this.mgaPhoneNumberEntry1.TabIndex = 16 /*0x10*/;
    this.ultraToolbarsManager1.DesignerFlags = 1;
    this.ultraToolbarsManager1.DockWithinContainer = (Control) this;
    this.ultraToolbarsManager1.ShowFullMenusDelay = 500;
    this.ultraToolbarsManager1.Style = (ToolbarStyle) 5;
    ultraToolbar.DockedColumn = 0;
    ultraToolbar.DockedRow = 0;
    ultraToolbar.Text = "UltraToolbar1";
    ultraToolbar.Visible = false;
    this.ultraToolbarsManager1.Toolbars.AddRange(new UltraToolbar[1]
    {
      ultraToolbar
    });
    ((ToolPropsBase) ((ToolBase) popupMenuTool).SharedPropsInternal).Caption = "PopupMenuTool1";
    ((ToolBase) popupMenuTool).SharedPropsInternal.Visible = false;
    ((ToolsCollectionBase) popupMenuTool.Tools).AddRange(new ToolBase[1]
    {
      (ToolBase) buttonTool1
    });
    ((ToolPropsBase) ((ToolBase) buttonTool2).SharedPropsInternal).Caption = "Add/Edit Subline Codes";
    ((ToolBase) buttonTool2).SharedPropsInternal.Visible = false;
    ((ToolsCollectionBase) this.ultraToolbarsManager1.Tools).AddRange(new ToolBase[2]
    {
      (ToolBase) popupMenuTool,
      (ToolBase) buttonTool2
    });
    this.ultraToolbarsManager1.BeforeToolDropdown += new BeforeToolDropdownEventHandler(this.ultraToolbarsManager1_BeforeToolDropdown);
    this.ultraToolbarsManager1.ToolClick += new ToolClickEventHandler(this.ultraToolbarsManager1_ToolClick);
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.Transparent;
    this.Controls.Add((Control) this.panelCenter);
    this.Controls.Add((Control) this.panelBottom);
    this.Controls.Add((Control) this.panelTop);
    this.Controls.Add((Control) this.panelRight);
    this.Controls.Add((Control) this._ClaimsAdministrationPortal_Toolbars_Dock_Area_Left);
    this.Controls.Add((Control) this._ClaimsAdministrationPortal_Toolbars_Dock_Area_Right);
    this.Controls.Add((Control) this._ClaimsAdministrationPortal_Toolbars_Dock_Area_Bottom);
    this.Controls.Add((Control) this._ClaimsAdministrationPortal_Toolbars_Dock_Area_Top);
    this.Font = new Font("Tahoma", 8.25f);
    this.Name = nameof (ClaimsAdministrationPortal);
    this.Size = new Size(964, 573);
    ((ISupportInitialize) this.groupTwoText).EndInit();
    ((Control) this.groupTwoText).ResumeLayout(false);
    ((Control) this.groupTwoText).PerformLayout();
    ((ISupportInitialize) this.textTwoText2).EndInit();
    ((ISupportInitialize) this.textTwoText1).EndInit();
    ((ISupportInitialize) this.groupOneText).EndInit();
    ((Control) this.groupOneText).ResumeLayout(false);
    ((Control) this.groupOneText).PerformLayout();
    ((ISupportInitialize) this.textOneText1).EndInit();
    this.panelBottom.ResumeLayout(false);
    ((ISupportInitialize) this.groupExtendedMulti).EndInit();
    ((Control) this.groupExtendedMulti).ResumeLayout(false);
    ((Control) this.groupExtendedMulti).PerformLayout();
    ((ISupportInitialize) this.textExtendedMulti1).EndInit();
    ((ISupportInitialize) this.comboExtendedMulti).EndInit();
    this.panelCenter.ResumeLayout(false);
    ((ISupportInitialize) this.gridView).EndInit();
    this.dsClaimsAdministration1.EndInit();
    this.panelTop.ResumeLayout(false);
    this.panelRight.ResumeLayout(false);
    this.panelRight.PerformLayout();
    ((ISupportInitialize) this.textWebAddress).EndInit();
    ((ISupportInitialize) this.dateTimeIncorporated).EndInit();
    ((ISupportInitialize) this.maskedEditSSNFEIN).EndInit();
    ((ISupportInitialize) this.textEmailAddress).EndInit();
    ((ISupportInitialize) this.textCorporationName).EndInit();
    ((ISupportInitialize) this.textLastName).EndInit();
    ((ISupportInitialize) this.textMiddleName).EndInit();
    ((ISupportInitialize) this.textFirstName).EndInit();
    ((ISupportInitialize) this.optionEntityType).EndInit();
    this.dsClaims_PhoneNumbers1.EndInit();
    ((ISupportInitialize) this.ultraToolbarsManager1).EndInit();
    this.ResumeLayout(false);
  }

  public enum ViewType
  {
    Default,
    SingleTextBoxView,
    MultiTextBoxView,
    ExtendedMultiView,
    AddressView,
  }

  public enum AdministrationPortalType
  {
    Custom,
    AccidentTypes,
    CatastropheCodes,
    ClaimPrefixes,
    CoverageTypes,
    CoverageTypeDescriptions,
    LossTypes,
    ManagedCareFacilities,
    OutsideAdjusters,
    PhoneTypes,
    ReservePaymentTypes,
    ReservePaymentSubTypes,
    SettlementTypes,
  }

  protected enum DBSaveUIState
  {
    None,
    Adding,
    Editing,
  }
}
