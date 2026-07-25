// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.Producers.frmProducers
// Assembly: MgaSystems.IMS.IPC, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: F22CEF02-8C0F-420D-8344-A8A010CA7834
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.IPC.dll

using Infragistics.Shared;
using Infragistics.UltraChart.Resources.Appearance;
using Infragistics.UltraChart.Shared.Styles;
using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinMaskedEdit;
using Infragistics.Win.UltraWinScrollBar;
using Infragistics.Win.UltraWinTabControl;
using Infragistics.Win.UltraWinTabs;
using Infragistics.Win.UltraWinToolbars;
using MGASystems.AddressResolver;
using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Common.BroadcastMessaging;
using MGASystems.Common.Enums;
using MGASystems.Common.ErrorHandling;
using MGASystems.Common.Functions;
using MGASystems.Data;
using MGASystems.IMS.InsuredsProducersCompanies.Producers.Lines;
using MGASystems.IMS.InsuredsProducersCompanies.Producers.Lines.Blocking;
using MGASystems.IMS.InsuredsProducersCompanies.Sircon;
using MGASystems.IMS.Logging.Administration;
using MGASystems.IMS.NoteDocuments;
using MGASystems.IMS.NoteDocuments.NoteDiarySystem;
using MGASystems.IMS.Security;
using MGASystems.Tools;
using MGASystems.Tools.DBSaveUI;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.InsuredsProducersCompanies.Producers;

[SecureResource("{4C8083A6-CA95-4e6a-9581-0D1529E6590E}", "Add Retailer", "Controls the ability to add a new retailer to the system.", "Producers")]
[SecureResource("{D33EC04C-C716-4dfb-A47A-40F995680EF5}", "Add Wholesaler", "Controls the ability to add a new wholesaler to the system.", "Producers")]
[SecureResource("{9609FF8A-0776-4fac-9AA1-7728705B1940}", "Add MGA", "Controls the ability to add a new MGA to the system.", "Producers")]
[SecureResource("{91B371AA-3B53-47ff-8797-A9676C7DEDF5}", "Add Location", "Controls the ability to add a new producer location to the system.", "Producers")]
[SecureResource("{AF625193-53D6-4d88-A122-4F7055B0EBA5}", "Edit Producer", "Controls the ability to edit an existing producer.", "Producers")]
[SecureResource("{8B9773EE-C6CC-43d8-8ECB-9393B7C13824}", "Edit Location", "Controls the ability to edit an existing location.", "Producers")]
[SecureResource("{80C38DB7-51A1-4373-9BF9-6F33C03983DF}", "Delete Producer", "Controls the ability to delete an existing producer.", "Producers")]
[SecureResource("{4CACD183-630E-422b-A053-9650D23F4D2F}", "View Producer Underwriter Assignment", "Controls the ability to view producer / underwriter assignment", "Producers")]
[SecureResource("{37539B37-EEAB-4c9b-B612-D225B048E9D5}", "Allow Move/Combine Producer", "Controls the ability to move an existing producer location to another.", "Producers")]
[SecureResource("{D677240B-C6A0-4014-990F-DBB810CFAE97}", "Edit CRM", "Controls the editing of CRM on the producer location.", "Producers")]
[SecureResource("{2437CF48-D6EF-4571-9A89-AB1194EA6707}", "Edit Call Reports", "Controls the editing of call reports.", "Producers")]
[SecureResource("{5B098E3D-BAE4-42a2-BD20-EB5166A9D43A}", "Add Producer", "Controls the addition of producers.", "Producers")]
[SecureResource("{0BC6FCA1-9107-4C32-AB5F-87837F85895C}", "View Marketing Menu", "Controls the ability to view Marketing menu", "Producers")]
[SecureResource("{6A0C9E1C-246B-4586-837D-418B2D8D433E}", "View Production Goal", "Controls the ability to view Production Goal menu", "Producers")]
[SecureResource("{920C280E-6419-4D02-ACE2-C9CFCFD839EA}", "View User Relationship", "Controls the ability to view User Relationship menu", "Producers")]
[SecureResource("{FF566DFA-A086-482C-9BD8-5E6F90F09AAA}", "View Producer Location Log", "Controls the ability to view Producer / Location Log", "Producers")]
[SecureResource("{8EB178EF-9D56-4355-B279-D5EF4E2CF652}", "View Assign Client Offices", "Controls the ability to view Assign Client Offices menu", "Producers")]
[SecureResource("{2D117606-DE51-4902-B36F-C415C27F52E0}", "View All Producer Locations", "Controls the ability to view all producers irrespective of Assigned Client Offices menu", "Producers")]
[SecureResource("{4db29af7-55f3-476d-8edf-be17cd700d51}", "View Producer Screen Statistics Tab", "Controls the ability to view the Statistics tab on the Edit Producer Screen", "Producers")]
[SecureResource("{0d45875e-b0f2-4ec6-b0a5-88b5432579ef}", "View Producer Screen Policies Tab", "Controls the ability to view the Policies tab on the Edit Producer Screen", "Producers")]
[SecureResource("e02ec0c3-180c-49b6-a3bd-81628b3c9b4b", "View Producer Screen Contacts Tab", "Controls the ability to view the Contacts tab on the Edit Producer Screen", "Producers")]
[SecureResource("{b643ab27-9f68-4087-bd7f-4e2c645e5f12}", "View Producer Screen Invoices Tab", "Controls the ability to view the Invoices tab on the Edit Producer Screen", "Producers")]
[SecureResource("{80a1d2d1-2015-405b-a65b-f4067cff7f15}", "View Producer Screen CRM Tab", "Controls the ability to view the CRM tab on the Edit Producer Screen", "Producers")]
[SecureResource("{c8280168-06d0-446e-bed3-b27e8235615e}", "View Producer Screen Call Reports Tab", "Controls the ability to view the Call Reports tab on the Edit Producer Screen", "Producers")]
[SecureResource("{0F3032ad-9246-4197-a37e-762d23b9a8b0}", "View Producer Screen Call Logo Tab", "Controls the ability to view the Logo tab on the Edit Producer Screen", "Producers")]
[SecureResource("{3DF59352-B65E-43EF-96CE-AE36DCAA9AC4}", "Edit Retailer", "Controls the ability to edit a Retailer.", "Producers")]
[SecureResource("{C21670F1-45C7-4129-BA80-AACCD25E0B81}", "Edit Wholesaler", "Controls the ability to edit a wholesaler.", "Producers")]
[SecureResource("{98535796-6A3D-4011-872E-B65BAFE32A52}", "Edit MGA", "Controls the ability to edit an MGA.", "Producers")]
[LogCategory("IMS.Insured.Producers.frmProducer", "IMS.Insured.Producers.frmProducer")]
[DocumentFolderFilter("Producer Administration")]
public class frmProducers : Form, ISupportNoteSystem, ISupportDocumentSystem
{
  private IContainer components;
  private bool _showAllContacts;
  private int _originalProducerBusType;
  private SqlDataAdapter daLocations;
  private SqlConnection cnSQL;
  private UltraToolbarsDockArea _frmProducers_Toolbars_Dock_Area_Left;
  private UltraToolbarsDockArea _frmProducers_Toolbars_Dock_Area_Right;
  private UltraToolbarsDockArea _frmProducers_Toolbars_Dock_Area_Top;
  private UltraToolbarsDockArea _frmProducers_Toolbars_Dock_Area_Bottom;
  private Label lblPhone;
  private Label Label3;
  private MGATextBox txtWebSite;
  private Label Label13;
  private Label Label9;
  private UltraLabel lblAdded;
  private Label Label2;
  private MGAMaskedEdit txtPhone;
  private MGAMaskedEdit txtFax;
  private MGAMaskedEdit txtFEIN1;
  internal SqlCommand SqlSelectCommand5;
  protected Label Label5;
  protected ToolTip ToolTip;
  private SqlDataAdapter daContacts;
  private ContextMenu mnuContacts;
  private SqlDataAdapter daProducers;
  private MGATextBox txtEmail;
  private Label Label16;
  private UltraLabel lblTotalPremium;
  private Label Label17;
  private UltraLabel lblRenewalRetention;
  private Label Label18;
  private UltraLabel lblDeclineRatio;
  private Label Label19;
  private UltraLabel lblBindRatio;
  private Label Label20;
  private UltraLabel lblQuoteRatio;
  private Label Label21;
  private Label Label1;
  private Label Label4;
  private Label Label6;
  private Label Label8;
  private Label Label10;
  private Infragistics.Win.UltraWinChart.UltraChart chartStats;
  private UltraCheckEditor chkAutoNOC;
  private UltraTabSharedControlsPage UltraTabSharedControlsPage1;
  private Label Label22;
  private MGASimpleComboBox cboCompanyLines;
  private UltraCheckEditor chkEmailReminders;
  private Label Label14;
  private MGASimpleComboBox cboBillTo;
  private SqlCommand SqlSelectCommand1;
  private SqlCommand SqlInsertCommand2;
  private SqlCommand SqlUpdateCommand2;
  private SqlCommand SqlDeleteCommand2;
  protected SqlDataAdapter daLoadData;
  private SqlCommand SqlSelectCommand3;
  public const string AddRetailer = "{4C8083A6-CA95-4e6a-9581-0D1529E6590E}";
  public const string AddWholesaler = "{D33EC04C-C716-4dfb-A47A-40F995680EF5}";
  public const string AddMGA = "{9609FF8A-0776-4fac-9AA1-7728705B1940}";
  public const string AddProducerLocation = "{91B371AA-3B53-47ff-8797-A9676C7DEDF5}";
  internal const string EditProducer = "{AF625193-53D6-4d88-A122-4F7055B0EBA5}";
  internal const string EditProducerLocation = "{8B9773EE-C6CC-43d8-8ECB-9393B7C13824}";
  internal const string DeleteProducer = "{80C38DB7-51A1-4373-9BF9-6F33C03983DF}";
  internal const string AllowMoveProducer = "{37539B37-EEAB-4c9b-B612-D225B048E9D5}";
  internal const string CanViewProducerUnderwriterAssignment = "{4CACD183-630E-422b-A053-9650D23F4D2F}";
  internal const string EditCrm = "{D677240B-C6A0-4014-990F-DBB810CFAE97}";
  internal const string EditCallReport = "{2437CF48-D6EF-4571-9A89-AB1194EA6707}";
  public const string AddProducer = "{5B098E3D-BAE4-42a2-BD20-EB5166A9D43A}";
  public const string CanViewMarketingMenu = "{0BC6FCA1-9107-4C32-AB5F-87837F85895C}";
  public const string CanViewProductionGoalMenu = "{6A0C9E1C-246B-4586-837D-418B2D8D433E}";
  public const string CanViewUserRelationshipMenu = "{920C280E-6419-4D02-ACE2-C9CFCFD839EA}";
  public const string CanViewProducerLocationLog = "{FF566DFA-A086-482C-9BD8-5E6F90F09AAA}";
  public const string CanViewAssignClientOffices = "{8EB178EF-9D56-4355-B279-D5EF4E2CF652}";
  public const string CanViewAllProducersIrrespectiveOfClientOffices = "{2D117606-DE51-4902-B36F-C415C27F52E0}";
  public const string CanViewTabLocationInfoProducer = "{3973041a-66e6-419a-9b98-a73d170176c5}";
  public const string CanViewTabStatisticsProducer = "{4db29af7-55f3-476d-8edf-be17cd700d51}";
  public const string CanViewTabPoliciesProducer = "{0d45875e-b0f2-4ec6-b0a5-88b5432579ef}";
  public const string CanViewTabContactsProducer = "e02ec0c3-180c-49b6-a3bd-81628b3c9b4b";
  public const string CanViewTabInvoicesProducer = "{b643ab27-9f68-4087-bd7f-4e2c645e5f12}";
  public const string CanViewTabCRMProducer = "{80a1d2d1-2015-405b-a65b-f4067cff7f15}";
  public const string CanViewTabCallReportsProducer = "{c8280168-06d0-446e-bed3-b27e8235615e}";
  public const string CanViewTabLogoProducer = "{0F3032ad-9246-4197-a37e-762d23b9a8b0}";
  public const string EditRetailer = "{3DF59352-B65E-43EF-96CE-AE36DCAA9AC4}";
  public const string EditWholesaler = "{C21670F1-45C7-4129-BA80-AACCD25E0B81}";
  public const string EditMGA = "{98535796-6A3D-4011-872E-B65BAFE32A52}";
  internal const string LogKey = "IMS.Insured.Producers.frmProducer";
  protected Guid _producerGuid;
  private bool _tabStatisticsPainted;
  private Size _phoneTextBoxSize;
  private Guid _moveToProducerLocationGuid;
  private Guid _producerLocationGuid;
  private bool _refreshContacts;
  private Thread _statisticsThread;
  private static dsProducers.CompanyLinesDataTable _compLineCache = (dsProducers.CompanyLinesDataTable) null;
  private int _Client_Existing_Relationship;
  private bool _CanEditProducerLocation;
  private bool _CanEditCRM;
  private bool _CanEditCallReports;
  protected bool _canEditProducer;
  private bool _canDeleteProducer;
  private bool _canAddProducer;
  private bool _EstablishSourceAndOwnerCRM_ProducerRelationShip;
  private bool _canAddProducerContact;
  private bool _canEditProducerContact;
  private bool _canAddProducerLocation;
  private bool _isFormLoading;
  private string _originalProducerName;
  private int _originalProducerStatus;
  private bool _hasProducerOrLocationChanges;
  private bool _isLocationModified;
  private bool _newProdLocBtnClicked;
  private bool _showLocationCode;
  private bool _locClosedOnSave;
  private bool _allowOfacSearch;
  private bool _showOfac;
  private bool _canClearOfac;
  private Dictionary<Guid, OfacSystem.OfacStatus> _ofacData;
  private readonly int _validLengthFEIN;

  protected override void Dispose(bool disposing)
  {
    if (disposing)
    {
      if (this.components != null)
        this.components.Dispose();
      if (!this.DesignMode)
        MDIControls.Instance.ToolBarManager.BeforeToolDropdown -= new BeforeToolDropdownEventHandler(this.menuProducer_BeforeToolDropdown);
    }
    base.Dispose(disposing);
  }

  [field: AccessedThroughProperty("Label24")]
  private virtual Label Label24 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaTextBox1")]
  private virtual MGATextBox MgaTextBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label25")]
  private virtual Label Label25 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtGrossWrittenPremium")]
  private virtual MGANumericEditor txtGrossWrittenPremium { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtNumEmployees")]
  private virtual MGANumericEditor txtNumEmployees { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label26")]
  private virtual Label Label26 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkOptOut")]
  protected virtual MGACheckBox chkOptOut { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblLoading")]
  internal virtual Label lblLoading { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("tabCRM")]
  protected virtual UltraTabPageControl tabCRM { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblProdPro")]
  private virtual Label lblProdPro { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblSource")]
  private virtual Label lblSource { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblProductionStatus")]
  private virtual Label lblProductionStatus { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblProdStatus")]
  private virtual Label lblProdStatus { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboOwner")]
  protected virtual MGAComboBox cboOwner { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboProductionPotential")]
  protected virtual MGAComboBox cboProductionPotential { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual MGAComboBox cboSource
  {
    get => this._cboSource;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.cboSource_ValueChanged);
      MGAComboBox cboSource1 = this._cboSource;
      if (cboSource1 != null)
        cboSource1.ValueChanged -= eventHandler;
      this._cboSource = value;
      MGAComboBox cboSource2 = this._cboSource;
      if (cboSource2 == null)
        return;
      cboSource2.ValueChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("lblOwner")]
  private virtual Label lblOwner { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblGWP")]
  private virtual Label lblGWP { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblEmployees")]
  private virtual Label lblEmployees { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("numGWP")]
  private virtual MGANumericEditor numGWP { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("numEmployees")]
  private virtual MGANumericEditor numEmployees { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label27")]
  private virtual Label Label27 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("numWholesaleRel")]
  private virtual MGANumericEditor numWholesaleRel { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraGroupBox1")]
  protected virtual UltraGroupBox UltraGroupBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtExpertise")]
  protected virtual RichTextBox txtExpertise { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraGroupBox4")]
  protected virtual UltraGroupBox UltraGroupBox4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtSpecFocusDept")]
  protected virtual RichTextBox txtSpecFocusDept { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraGroupBox2")]
  protected virtual UltraGroupBox UltraGroupBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtWholesaleRelationships")]
  protected virtual RichTextBox txtWholesaleRelationships { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkSetProcedureToEngage")]
  private virtual MGACheckBox chkSetProcedureToEngage { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkApproveWholesalersList")]
  private virtual MGACheckBox chkApproveWholesalersList { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("tabCallReport")]
  protected virtual UltraTabPageControl tabCallReport { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual UltraGrid ugDetails
  {
    get => this._ugDetails;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ugDetails_DoubleClick);
      UltraGrid ugDetails1 = this._ugDetails;
      if (ugDetails1 != null)
        ((Control) ugDetails1).DoubleClick -= eventHandler;
      this._ugDetails = value;
      UltraGrid ugDetails2 = this._ugDetails;
      if (ugDetails2 == null)
        return;
      ((Control) ugDetails2).DoubleClick += eventHandler;
    }
  }

  [field: AccessedThroughProperty("dvCallReports")]
  private virtual DataView dvCallReports { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual MGAButton btnReport
  {
    get => this._btnReport;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnReport_Click);
      MGAButton btnReport1 = this._btnReport;
      if (btnReport1 != null)
        ((Control) btnReport1).Click -= eventHandler;
      this._btnReport = value;
      MGAButton btnReport2 = this._btnReport;
      if (btnReport2 == null)
        return;
      ((Control) btnReport2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("Label28")]
  private virtual Label Label28 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dtProdAgrrmntEff")]
  internal virtual MGADateTimePicker dtProdAgrrmntEff { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label29")]
  private virtual Label Label29 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaComboBox1")]
  protected virtual MGAComboBox MgaComboBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboPaymentMethod")]
  protected internal virtual MGASimpleComboBox cboPaymentMethod { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label31")]
  protected virtual Label Label31 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblNumDeclined")]
  private virtual UltraLabel lblNumDeclined { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label33")]
  private virtual Label Label33 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblNumBind")]
  private virtual UltraLabel lblNumBind { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label32")]
  private virtual Label Label32 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblNumQuoted")]
  private virtual UltraLabel lblNumQuoted { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label30")]
  private virtual Label Label30 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblNumSubmitted")]
  private virtual UltraLabel lblNumSubmitted { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label34")]
  private virtual Label Label34 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkOnStatement")]
  protected virtual MGACheckBox chkOnStatement { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraTabPageControl5")]
  internal virtual UltraTabPageControl UltraTabPageControl5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual UltraGrid ugPoliciesGrid
  {
    get => this._ugPoliciesGrid;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      DoubleClickRowEventHandler clickRowEventHandler = new DoubleClickRowEventHandler(this.ugPoliciesTab_DoubleClickRow);
      InitializeLayoutEventHandler layoutEventHandler = new InitializeLayoutEventHandler(this.ugPoliciesGrid_InitializeLayout);
      UltraGrid ugPoliciesGrid1 = this._ugPoliciesGrid;
      if (ugPoliciesGrid1 != null)
      {
        ugPoliciesGrid1.DoubleClickRow -= clickRowEventHandler;
        ugPoliciesGrid1.InitializeLayout -= layoutEventHandler;
      }
      this._ugPoliciesGrid = value;
      UltraGrid ugPoliciesGrid2 = this._ugPoliciesGrid;
      if (ugPoliciesGrid2 == null)
        return;
      ugPoliciesGrid2.DoubleClickRow += clickRowEventHandler;
      ugPoliciesGrid2.InitializeLayout += layoutEventHandler;
    }
  }

  [field: AccessedThroughProperty("txtNPN")]
  private virtual MGATextBox txtNPN { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("tabLogo")]
  protected virtual UltraTabPageControl tabLogo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("pbLogo")]
  internal virtual PictureBox pbLogo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MGAButton btnNewImage
  {
    get => this._btnNewImage;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnNewImage_Click);
      MGAButton btnNewImage1 = this._btnNewImage;
      if (btnNewImage1 != null)
        ((Control) btnNewImage1).Click -= eventHandler;
      this._btnNewImage = value;
      MGAButton btnNewImage2 = this._btnNewImage;
      if (btnNewImage2 == null)
        return;
      ((Control) btnNewImage2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("Label37")]
  private virtual Label Label37 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label36")]
  private virtual Label Label36 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dtEndDate")]
  internal virtual MGADateTimePicker dtEndDate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dtStartDate")]
  internal virtual MGADateTimePicker dtStartDate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual Button btnQueryDates
  {
    get => this._btnQueryDates;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnQueryDates_Click);
      Button btnQueryDates1 = this._btnQueryDates;
      if (btnQueryDates1 != null)
        btnQueryDates1.Click -= eventHandler;
      this._btnQueryDates = value;
      Button btnQueryDates2 = this._btnQueryDates;
      if (btnQueryDates2 == null)
        return;
      btnQueryDates2.Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("lblReferredBy")]
  protected virtual Label lblReferredBy { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboProducerlocations")]
  protected virtual MGAComboBox cboProducerlocations { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblRecords")]
  protected virtual UltraLabel lblRecords { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual MGAButton btnDelete
  {
    get => this._btnDelete;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnDelete_Click);
      MGAButton btnDelete1 = this._btnDelete;
      if (btnDelete1 != null)
        ((Control) btnDelete1).Click -= eventHandler;
      this._btnDelete = value;
      MGAButton btnDelete2 = this._btnDelete;
      if (btnDelete2 == null)
        return;
      ((Control) btnDelete2).Click += eventHandler;
    }
  }

  protected virtual MGAButton btnPrev
  {
    get => this._btnPrev;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.Navigation);
      MGAButton btnPrev1 = this._btnPrev;
      if (btnPrev1 != null)
        ((Control) btnPrev1).Click -= eventHandler;
      this._btnPrev = value;
      MGAButton btnPrev2 = this._btnPrev;
      if (btnPrev2 == null)
        return;
      ((Control) btnPrev2).Click += eventHandler;
    }
  }

  protected virtual MGAButton btnNext
  {
    get => this._btnNext;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.Navigation);
      MGAButton btnNext1 = this._btnNext;
      if (btnNext1 != null)
        ((Control) btnNext1).Click -= eventHandler;
      this._btnNext = value;
      MGAButton btnNext2 = this._btnNext;
      if (btnNext2 == null)
        return;
      ((Control) btnNext2).Click += eventHandler;
    }
  }

  protected virtual MGAButton btnLast
  {
    get => this._btnLast;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.Navigation);
      MGAButton btnLast1 = this._btnLast;
      if (btnLast1 != null)
        ((Control) btnLast1).Click -= eventHandler;
      this._btnLast = value;
      MGAButton btnLast2 = this._btnLast;
      if (btnLast2 == null)
        return;
      ((Control) btnLast2).Click += eventHandler;
    }
  }

  protected virtual MGAButton btnFirst
  {
    get => this._btnFirst;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.Navigation);
      MGAButton btnFirst1 = this._btnFirst;
      if (btnFirst1 != null)
        ((Control) btnFirst1).Click -= eventHandler;
      this._btnFirst = value;
      MGAButton btnFirst2 = this._btnFirst;
      if (btnFirst2 == null)
        return;
      ((Control) btnFirst2).Click += eventHandler;
    }
  }

  protected virtual MGAButton btnNewProducerLocation
  {
    get => this._btnNewProducerLocation;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnNewProducerLocation_Click);
      MGAButton producerLocation1 = this._btnNewProducerLocation;
      if (producerLocation1 != null)
        ((Control) producerLocation1).Click -= eventHandler;
      this._btnNewProducerLocation = value;
      MGAButton producerLocation2 = this._btnNewProducerLocation;
      if (producerLocation2 == null)
        return;
      ((Control) producerLocation2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("lblStatusChnageComm")]
  protected virtual Label lblStatusChnageComm { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblStatusChnageComment")]
  protected virtual Label lblStatusChnageComment { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtStatusChangeComments")]
  protected virtual MGATextBox txtStatusChangeComments { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblStatusReasonID")]
  protected virtual Label lblStatusReasonID { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboReason")]
  protected virtual MGASimpleComboBox cboReason { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblStatusChangeReason")]
  protected virtual Label lblStatusChangeReason { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblNameonCheck")]
  private virtual Label lblNameonCheck { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("mgatxtNameonCheck")]
  private virtual MGATextBox mgatxtNameonCheck { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaInternationalPhone")]
  internal virtual MGAInternationalPhoneNumberEditor MgaInternationalPhone { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaInternationalFax")]
  internal virtual MGAInternationalPhoneNumberEditor MgaInternationalFax { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblInhouseProducer")]
  protected virtual Label lblInhouseProducer { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblCurrentContact")]
  internal virtual Label lblCurrentContact { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("grpContactOfac")]
  protected virtual UltraGroupBox grpContactOfac { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblOfacClearedDate")]
  private virtual Label lblOfacClearedDate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dtOFACClearedDate")]
  private virtual MGADateTimePicker dtOFACClearedDate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual MGACheckBox chkOFACCleared
  {
    get => this._chkOFACCleared;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.chkOFACCleared_CheckedChanged);
      MGACheckBox chkOfacCleared1 = this._chkOFACCleared;
      if (chkOfacCleared1 != null)
        ((UltraToggleEditorBase) chkOfacCleared1).CheckedChanged -= eventHandler;
      this._chkOFACCleared = value;
      MGACheckBox chkOfacCleared2 = this._chkOFACCleared;
      if (chkOfacCleared2 == null)
        return;
      ((UltraToggleEditorBase) chkOfacCleared2).CheckedChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("lblOFACReturnCode")]
  protected virtual Label lblOFACReturnCode { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblOFACDate")]
  protected virtual Label lblOFACDate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ugOFAC")]
  protected virtual UltraGrid ugOFAC { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual MGATextBox txtProducerName
  {
    get => this._txtProducerName;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      CancelEventHandler cancelEventHandler = new CancelEventHandler(this.txtProducerName_Validating);
      MGATextBox txtProducerName1 = this._txtProducerName;
      if (txtProducerName1 != null)
        ((Control) txtProducerName1).Validating -= cancelEventHandler;
      this._txtProducerName = value;
      MGATextBox txtProducerName2 = this._txtProducerName;
      if (txtProducerName2 == null)
        return;
      ((Control) txtProducerName2).Validating += cancelEventHandler;
    }
  }

  [field: AccessedThroughProperty("txtCode")]
  protected virtual MGATextBox txtCode { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtLocation")]
  protected virtual MGATextBox txtLocation { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MGASimpleComboBox cboProducerType
  {
    get => this._cboProducerType;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.cboProducerType_ValueChanged);
      MGASimpleComboBox cboProducerType1 = this._cboProducerType;
      if (cboProducerType1 != null)
        cboProducerType1.ValueChanged -= eventHandler;
      this._cboProducerType = value;
      MGASimpleComboBox cboProducerType2 = this._cboProducerType;
      if (cboProducerType2 == null)
        return;
      cboProducerType2.ValueChanged += eventHandler;
    }
  }

  private virtual MGAListBox lstContacts
  {
    get => this._lstContacts;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.SelectContact);
      EventHandler eventHandler2 = new EventHandler(this.lstContacts_SelectedIndexChanged);
      MGAListBox lstContacts1 = this._lstContacts;
      if (lstContacts1 != null)
      {
        lstContacts1.DoubleClick -= eventHandler1;
        lstContacts1.SelectedIndexChanged -= eventHandler2;
      }
      this._lstContacts = value;
      MGAListBox lstContacts2 = this._lstContacts;
      if (lstContacts2 == null)
        return;
      lstContacts2.DoubleClick += eventHandler1;
      lstContacts2.SelectedIndexChanged += eventHandler2;
    }
  }

  [field: AccessedThroughProperty("Label7")]
  protected virtual Label Label7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MGAButton btnSelectContact
  {
    get => this._btnSelectContact;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.SelectContact);
      MGAButton btnSelectContact1 = this._btnSelectContact;
      if (btnSelectContact1 != null)
        ((Control) btnSelectContact1).Click -= eventHandler;
      this._btnSelectContact = value;
      MGAButton btnSelectContact2 = this._btnSelectContact;
      if (btnSelectContact2 == null)
        return;
      ((Control) btnSelectContact2).Click += eventHandler;
    }
  }

  private virtual MGAButton btnNewContact
  {
    get => this._btnNewContact;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnNewContact_Click);
      MGAButton btnNewContact1 = this._btnNewContact;
      if (btnNewContact1 != null)
        ((Control) btnNewContact1).Click -= eventHandler;
      this._btnNewContact = value;
      MGAButton btnNewContact2 = this._btnNewContact;
      if (btnNewContact2 == null)
        return;
      ((Control) btnNewContact2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("cboDeliveryMethod")]
  protected virtual MGASimpleComboBox cboDeliveryMethod { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label11")]
  protected virtual Label Label11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label12")]
  protected virtual Label Label12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual MGASimpleComboBox cbStatus
  {
    get => this._cbStatus;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.cbStatus_ValueChanged);
      MGASimpleComboBox cbStatus1 = this._cbStatus;
      if (cbStatus1 != null)
        cbStatus1.ValueChanged -= eventHandler;
      this._cbStatus = value;
      MGASimpleComboBox cbStatus2 = this._cbStatus;
      if (cbStatus2 == null)
        return;
      cbStatus2.ValueChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("cbOfficeType")]
  protected virtual MGASimpleComboBox cbOfficeType { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MenuItem mnuActive
  {
    get => this._mnuActive;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ContactsMenuClick);
      MenuItem mnuActive1 = this._mnuActive;
      if (mnuActive1 != null)
        mnuActive1.Click -= eventHandler;
      this._mnuActive = value;
      MenuItem mnuActive2 = this._mnuActive;
      if (mnuActive2 == null)
        return;
      mnuActive2.Click += eventHandler;
    }
  }

  private virtual MenuItem mnuInactive
  {
    get => this._mnuInactive;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ContactsMenuClick);
      MenuItem mnuInactive1 = this._mnuInactive;
      if (mnuInactive1 != null)
        mnuInactive1.Click -= eventHandler;
      this._mnuInactive = value;
      MenuItem mnuInactive2 = this._mnuInactive;
      if (mnuInactive2 == null)
        return;
      mnuInactive2.Click += eventHandler;
    }
  }

  private virtual MenuItem mnuBothContacts
  {
    get => this._mnuBothContacts;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ContactsMenuClick);
      MenuItem mnuBothContacts1 = this._mnuBothContacts;
      if (mnuBothContacts1 != null)
        mnuBothContacts1.Click -= eventHandler;
      this._mnuBothContacts = value;
      MenuItem mnuBothContacts2 = this._mnuBothContacts;
      if (mnuBothContacts2 == null)
        return;
      mnuBothContacts2.Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("dsProducer")]
  protected virtual dsProducers dsProducer { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboBusinessTypes")]
  protected virtual MGASimpleComboBox cboBusinessTypes { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblProducerCode")]
  protected virtual UltraLabel lblProducerCode { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual UltraToolbarsManager menuProducer
  {
    get => this._menuProducer;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      ToolClickEventHandler clickEventHandler = new ToolClickEventHandler(this.menuProducer_ToolClick);
      UltraToolbarsManager menuProducer1 = this._menuProducer;
      if (menuProducer1 != null)
        menuProducer1.ToolClick -= clickEventHandler;
      this._menuProducer = value;
      UltraToolbarsManager menuProducer2 = this._menuProducer;
      if (menuProducer2 == null)
        return;
      menuProducer2.ToolClick += clickEventHandler;
    }
  }

  [field: AccessedThroughProperty("gbProducer")]
  protected virtual UltraGroupBox gbProducer { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraTabPageControl1")]
  protected virtual UltraTabPageControl UltraTabPageControl1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraTabPageControl2")]
  protected virtual UltraTabPageControl UltraTabPageControl2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraTabPageControl3")]
  protected virtual UltraTabPageControl UltraTabPageControl3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraTabPageControl4")]
  protected virtual UltraTabPageControl UltraTabPageControl4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual MGASystems.Tools.DBSaveUI.DBSaveUI dbSave
  {
    get => this._dbSave;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      CancelEventHandler cancelEventHandler1 = new CancelEventHandler(this.dbSave_ClickingNew);
      CancelEventHandler cancelEventHandler2 = new CancelEventHandler(this.dbSave_ClickingSave);
      CancelEventHandler cancelEventHandler3 = new CancelEventHandler(this.dbSave_ClickingDelete);
      EventHandler eventHandler1 = new EventHandler(this.dbSave_ClickedEdit);
      EventHandler eventHandler2 = new EventHandler(this.dbSave_ClickedCancel);
      CancelEventHandler cancelEventHandler4 = new CancelEventHandler(this.dbSave_ClickingCancel);
      CancelEventHandler cancelEventHandler5 = new CancelEventHandler(this.dbSave_ClickingEdit);
      EventHandler eventHandler3 = new EventHandler(this.dbSave_UIStateChanged);
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave1 = this._dbSave;
      if (dbSave1 != null)
      {
        dbSave1.ClickingNew -= cancelEventHandler1;
        dbSave1.ClickingSave -= cancelEventHandler2;
        dbSave1.ClickingDelete -= cancelEventHandler3;
        dbSave1.ClickedEdit -= eventHandler1;
        dbSave1.ClickedCancel -= eventHandler2;
        dbSave1.ClickingCancel -= cancelEventHandler4;
        dbSave1.ClickingEdit -= cancelEventHandler5;
        dbSave1.UIStateChanged -= eventHandler3;
      }
      this._dbSave = value;
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave2 = this._dbSave;
      if (dbSave2 == null)
        return;
      dbSave2.ClickingNew += cancelEventHandler1;
      dbSave2.ClickingSave += cancelEventHandler2;
      dbSave2.ClickingDelete += cancelEventHandler3;
      dbSave2.ClickedEdit += eventHandler1;
      dbSave2.ClickedCancel += eventHandler2;
      dbSave2.ClickingCancel += cancelEventHandler4;
      dbSave2.ClickingEdit += cancelEventHandler5;
      dbSave2.UIStateChanged += eventHandler3;
    }
  }

  protected virtual UltraTabControl tabLocationInfo
  {
    get => this._tabLocationInfo;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      SelectedTabChangedEventHandler changedEventHandler = new SelectedTabChangedEventHandler(this.tabLocationInfo_SelectedTabChanged);
      UltraTabControl tabLocationInfo1 = this._tabLocationInfo;
      if (tabLocationInfo1 != null)
        ((UltraTabControlBase) tabLocationInfo1).SelectedTabChanged -= changedEventHandler;
      this._tabLocationInfo = value;
      UltraTabControl tabLocationInfo2 = this._tabLocationInfo;
      if (tabLocationInfo2 == null)
        return;
      ((UltraTabControlBase) tabLocationInfo2).SelectedTabChanged += changedEventHandler;
    }
  }

  [field: AccessedThroughProperty("err")]
  protected virtual ErrorProvider err { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboMailTo")]
  internal virtual MGASimpleComboBox cboMailTo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label15")]
  internal virtual Label Label15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlSelectCommand2")]
  internal virtual SqlCommand SqlSelectCommand2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlInsertCommand1")]
  internal virtual SqlCommand SqlInsertCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlUpdateCommand1")]
  internal virtual SqlCommand SqlUpdateCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlDeleteCommand1")]
  internal virtual SqlCommand SqlDeleteCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label23")]
  protected virtual Label Label23 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("daProducerRegion")]
  internal virtual SqlDataAdapter daProducerRegion { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlCommand1")]
  internal virtual SqlCommand SqlCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual AddressResolver_MULTI ctlZipCode
  {
    get => this._ctlZipCode;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.ctlZipCode_CountryChanged);
      EventHandler eventHandler2 = new EventHandler(this.ctlZipCode_StateChanged);
      AddressResolver_MULTI ctlZipCode1 = this._ctlZipCode;
      if (ctlZipCode1 != null)
      {
        ctlZipCode1.CountryChanged -= eventHandler1;
        ctlZipCode1.StateChanged -= eventHandler2;
      }
      this._ctlZipCode = value;
      AddressResolver_MULTI ctlZipCode2 = this._ctlZipCode;
      if (ctlZipCode2 == null)
        return;
      ctlZipCode2.CountryChanged += eventHandler1;
      ctlZipCode2.StateChanged += eventHandler2;
    }
  }

  [field: AccessedThroughProperty("cboProducerRegion")]
  protected virtual MGASimpleComboBox cboProducerRegion { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmProducers));
    Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance9 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance10 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance11 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance12 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance13 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance14 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance15 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance16 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance17 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance18 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance19 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance20 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance21 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance22 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance23 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance24 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance25 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance26 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance27 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance28 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance29 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance30 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance31 = new Infragistics.Win.Appearance();
    PaintElement paintElement = new PaintElement();
    Infragistics.Win.Appearance appearance32 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance33 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance34 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance35 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance36 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance37 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance38 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance39 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance40 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance41 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance42 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance43 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance44 = new Infragistics.Win.Appearance();
    ScrollBarLook scrollBarLook1 = new ScrollBarLook();
    Infragistics.Win.Appearance appearance45 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance46 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance47 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance48 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance49 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance50 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance51 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance52 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance53 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance54 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance55 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance56 = new Infragistics.Win.Appearance();
    ScrollBarLook scrollBarLook2 = new ScrollBarLook();
    Infragistics.Win.Appearance appearance57 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance58 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance59 = new Infragistics.Win.Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("lstProducers", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("ProducerGUID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("ProducerName");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("lstProducers_tblProducerLocations");
    UltraGridBand ultraGridBand2 = new UltraGridBand("lstProducers_tblProducerLocations", 0);
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("ProducerLocationGUID");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("ProducerGUID");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("ProducerTypeID");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("Name");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("Address1");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("Address2");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("City");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("County");
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("ZipPlus");
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("Phone");
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("Fax");
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("FEIN");
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("Closed");
    UltraGridColumn ultraGridColumn17 = new UltraGridColumn("WebSite");
    UltraGridColumn ultraGridColumn18 = new UltraGridColumn("PrimaryLocation");
    UltraGridColumn ultraGridColumn19 = new UltraGridColumn("DeliveryMethodID");
    UltraGridColumn ultraGridColumn20 = new UltraGridColumn("DateAdded");
    UltraGridColumn ultraGridColumn21 = new UltraGridColumn("LocationTypeID");
    UltraGridColumn ultraGridColumn22 = new UltraGridColumn("StatusID");
    UltraGridColumn ultraGridColumn23 = new UltraGridColumn("Hidden");
    UltraGridColumn ultraGridColumn24 = new UltraGridColumn("State");
    UltraGridColumn ultraGridColumn25 = new UltraGridColumn("ZipCode");
    UltraGridColumn ultraGridColumn26 = new UltraGridColumn("LocationCode");
    UltraGridColumn ultraGridColumn27 = new UltraGridColumn("Email");
    UltraGridColumn ultraGridColumn28 = new UltraGridColumn("AllowAutomaticNOC");
    UltraGridColumn ultraGridColumn29 = new UltraGridColumn("ISOCountryCode");
    UltraGridColumn ultraGridColumn30 = new UltraGridColumn("Region");
    UltraGridColumn ultraGridColumn31 = new UltraGridColumn("EmailReminders");
    UltraGridColumn ultraGridColumn32 = new UltraGridColumn("BillToProducerLocationGuid");
    UltraGridColumn ultraGridColumn33 = new UltraGridColumn("MailToProducerLocationGuid");
    UltraGridColumn ultraGridColumn34 = new UltraGridColumn("ProducerLocationRegion");
    UltraGridColumn ultraGridColumn35 = new UltraGridColumn("ProducerLocationID");
    UltraGridColumn ultraGridColumn36 = new UltraGridColumn("NumEmployees");
    UltraGridColumn ultraGridColumn37 = new UltraGridColumn("GrossWrittenPremium");
    UltraGridColumn ultraGridColumn38 = new UltraGridColumn("OptOut");
    UltraGridColumn ultraGridColumn39 = new UltraGridColumn("ProductionPotential");
    UltraGridColumn ultraGridColumn40 = new UltraGridColumn("LocationSource");
    UltraGridColumn ultraGridColumn41 = new UltraGridColumn("Owner");
    UltraGridColumn ultraGridColumn42 = new UltraGridColumn("NumWholesaleRelationship");
    UltraGridColumn ultraGridColumn43 = new UltraGridColumn("WholesaleRelationships");
    UltraGridColumn ultraGridColumn44 = new UltraGridColumn("Expertise");
    UltraGridColumn ultraGridColumn45 = new UltraGridColumn("SetProcedureToEnage");
    UltraGridColumn ultraGridColumn46 = new UltraGridColumn("ApproveWholesalersList");
    UltraGridColumn ultraGridColumn47 = new UltraGridColumn("SpecFocusDept");
    UltraGridColumn ultraGridColumn48 = new UltraGridColumn("AgreementEffectiveDate");
    UltraGridColumn ultraGridColumn49 = new UltraGridColumn("ProducerRankingID");
    UltraGridColumn ultraGridColumn50 = new UltraGridColumn("PaymentMethodID");
    UltraGridColumn ultraGridColumn51 = new UltraGridColumn("OnStatement");
    UltraGridColumn ultraGridColumn52 = new UltraGridColumn("NPN");
    UltraGridColumn ultraGridColumn53 = new UltraGridColumn("ReferredBYProdLocation");
    UltraGridColumn ultraGridColumn54 = new UltraGridColumn("StatusChangeReasonID");
    UltraGridColumn ultraGridColumn55 = new UltraGridColumn("StatusChangeReasonComment");
    UltraGridColumn ultraGridColumn56 = new UltraGridColumn("AddedBy");
    UltraGridColumn ultraGridColumn57 = new UltraGridColumn("DateModified");
    UltraGridColumn ultraGridColumn58 = new UltraGridColumn("ModifiedBy");
    UltraGridColumn ultraGridColumn59 = new UltraGridColumn("NameonCheck");
    UltraGridColumn ultraGridColumn60 = new UltraGridColumn("CountryCodeforPhone");
    UltraGridColumn ultraGridColumn61 = new UltraGridColumn("CountryCodeforFax");
    UltraGridColumn ultraGridColumn62 = new UltraGridColumn("InHouseProducer");
    UltraGridColumn ultraGridColumn63 = new UltraGridColumn("tblProducerLocationstblProducerContacts");
    UltraGridBand ultraGridBand3 = new UltraGridBand("tblProducerLocationstblProducerContacts", 1);
    UltraGridColumn ultraGridColumn64 = new UltraGridColumn("ProducerContactGUID");
    UltraGridColumn ultraGridColumn65 = new UltraGridColumn("ProducerLocationGUID");
    UltraGridColumn ultraGridColumn66 = new UltraGridColumn("Name");
    UltraGridColumn ultraGridColumn67 = new UltraGridColumn("StatusID");
    Infragistics.Win.Appearance appearance60 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance61 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance62 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance63 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance64 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance65 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance66 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance67 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance68 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance69 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance70 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance71 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance72 = new Infragistics.Win.Appearance();
    ScrollBarLook scrollBarLook3 = new ScrollBarLook();
    Infragistics.Win.Appearance appearance73 = new Infragistics.Win.Appearance();
    UltraGridBand ultraGridBand4 = new UltraGridBand("lstProducerRankings", -1);
    UltraGridColumn ultraGridColumn68 = new UltraGridColumn("ID");
    UltraGridColumn ultraGridColumn69 = new UltraGridColumn("ProducerRanking");
    Infragistics.Win.Appearance appearance74 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance75 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance76 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance77 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance78 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance79 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance80 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance81 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance82 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance83 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance84 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance85 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance86 = new Infragistics.Win.Appearance();
    ScrollBarLook scrollBarLook4 = new ScrollBarLook();
    Infragistics.Win.Appearance appearance87 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance88 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance89 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance90 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance91 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance92 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance93 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance94 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance95 = new Infragistics.Win.Appearance();
    UltraGridBand ultraGridBand5 = new UltraGridBand("tblUsers", -1);
    UltraGridColumn ultraGridColumn70 = new UltraGridColumn("UserGUID");
    UltraGridColumn ultraGridColumn71 = new UltraGridColumn("Name_LastFirst");
    Infragistics.Win.Appearance appearance96 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance97 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance98 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance99 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance100 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance101 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance102 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance103 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance104 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance105 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance106 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance107 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance108 = new Infragistics.Win.Appearance();
    ScrollBarLook scrollBarLook5 = new ScrollBarLook();
    Infragistics.Win.Appearance appearance109 = new Infragistics.Win.Appearance();
    UltraGridBand ultraGridBand6 = new UltraGridBand("lstProductionPotential", -1);
    UltraGridColumn ultraGridColumn72 = new UltraGridColumn("ID");
    UltraGridColumn ultraGridColumn73 = new UltraGridColumn("Description");
    Infragistics.Win.Appearance appearance110 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance111 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance112 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance113 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance114 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance115 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance116 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance117 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance118 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance119 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance120 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance121 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance122 = new Infragistics.Win.Appearance();
    ScrollBarLook scrollBarLook6 = new ScrollBarLook();
    Infragistics.Win.Appearance appearance123 = new Infragistics.Win.Appearance();
    UltraGridBand ultraGridBand7 = new UltraGridBand("lstProducerLocationSource", -1);
    UltraGridColumn ultraGridColumn74 = new UltraGridColumn("ID");
    UltraGridColumn ultraGridColumn75 = new UltraGridColumn("Source");
    Infragistics.Win.Appearance appearance124 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance125 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance126 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance127 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance128 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance129 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance130 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance131 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance132 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance133 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance134 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance135 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance136 = new Infragistics.Win.Appearance();
    ScrollBarLook scrollBarLook7 = new ScrollBarLook();
    Infragistics.Win.Appearance appearance137 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance138 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance139 = new Infragistics.Win.Appearance();
    UltraGridBand ultraGridBand8 = new UltraGridBand("tblProducerCallReport", -1);
    UltraGridColumn ultraGridColumn76 = new UltraGridColumn("CallReportID");
    UltraGridColumn ultraGridColumn77 = new UltraGridColumn("DateOfVisit");
    UltraGridColumn ultraGridColumn78 = new UltraGridColumn("CallType");
    UltraGridColumn ultraGridColumn79 = new UltraGridColumn("LeadContact");
    UltraGridColumn ultraGridColumn80 = new UltraGridColumn("ProducerLocationID");
    UltraGridColumn ultraGridColumn81 = new UltraGridColumn("ProducerLocationGuid");
    Infragistics.Win.Appearance appearance140 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance141 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance142 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance143 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance144 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance145 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance146 = new Infragistics.Win.Appearance();
    ScrollBarLook scrollBarLook8 = new ScrollBarLook();
    Infragistics.Win.Appearance appearance147 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance148 = new Infragistics.Win.Appearance();
    UltraGridBand ultraGridBand9 = new UltraGridBand("tblSirconLicenses", -1);
    UltraGridColumn ultraGridColumn82 = new UltraGridColumn("Type");
    UltraGridColumn ultraGridColumn83 = new UltraGridColumn("State", -1, (object) null, 0, (SortIndicator) 1, false);
    UltraGridColumn ultraGridColumn84 = new UltraGridColumn("Status");
    UltraGridColumn ultraGridColumn85 = new UltraGridColumn("ExpirationDate");
    UltraGridColumn ultraGridColumn86 = new UltraGridColumn("Number");
    Infragistics.Win.Appearance appearance149 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance150 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance151 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance152 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance153 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance154 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance155 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance156 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance157 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance158 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance159 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance160 = new Infragistics.Win.Appearance();
    UltraGridBand ultraGridBand10 = new UltraGridBand("tblSirconLOAs", -1);
    UltraGridColumn ultraGridColumn87 = new UltraGridColumn("Type", -1, (object) null, 0, (SortIndicator) 1, false);
    UltraGridColumn ultraGridColumn88 = new UltraGridColumn("State");
    UltraGridColumn ultraGridColumn89 = new UltraGridColumn("Status");
    UltraGridColumn ultraGridColumn90 = new UltraGridColumn("StatusDate");
    UltraGridColumn ultraGridColumn91 = new UltraGridColumn("ExpirationDate");
    Infragistics.Win.Appearance appearance161 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance162 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance163 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance164 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance165 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance166 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance167 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance168 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance169 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance170 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance171 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance172 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance173 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance174 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance175 = new Infragistics.Win.Appearance();
    UltraToolbar ultraToolbar = new UltraToolbar("MainMenu");
    PopupMenuTool popupMenuTool1 = new PopupMenuTool("Producers");
    PopupMenuTool popupMenuTool2 = new PopupMenuTool("Producers");
    PopupMenuTool popupMenuTool3 = new PopupMenuTool("PopupMenuTool1611");
    ButtonTool buttonTool1 = new ButtonTool("Licenses");
    ButtonTool buttonTool2 = new ButtonTool("Requirements");
    ButtonTool buttonTool3 = new ButtonTool("Marketing");
    ButtonTool buttonTool4 = new ButtonTool("Producer/Underwriter Assignment");
    ButtonTool buttonTool5 = new ButtonTool("Move Location To Another Producer");
    ButtonTool buttonTool6 = new ButtonTool("Producer / Location Log");
    ButtonTool buttonTool7 = new ButtonTool("Production Goal...");
    ButtonTool buttonTool8 = new ButtonTool("User Relationship");
    ButtonTool buttonTool9 = new ButtonTool("Assign Client Offices");
    ButtonTool buttonTool10 = new ButtonTool("Producer/Line Blocking");
    ButtonTool buttonTool11 = new ButtonTool("Assign BillingTypes");
    ButtonTool buttonTool12 = new ButtonTool("Licenses");
    ButtonTool buttonTool13 = new ButtonTool("Requirements");
    ButtonTool buttonTool14 = new ButtonTool("Producer Lines");
    ButtonTool buttonTool15 = new ButtonTool("Marketing");
    PopupMenuTool popupMenuTool4 = new PopupMenuTool("PopupMenuTool1611");
    ButtonTool buttonTool16 = new ButtonTool("Producer Lines");
    ButtonTool buttonTool17 = new ButtonTool("Producer Lines (For Entire Producer) ...");
    ButtonTool buttonTool18 = new ButtonTool("Producer/Underwriter Assignment");
    ButtonTool buttonTool19 = new ButtonTool("Producer Lines (For Entire Producer) ...");
    ButtonTool buttonTool20 = new ButtonTool("Move Location To Another Producer");
    ButtonTool buttonTool21 = new ButtonTool("Producer / Location Log");
    ButtonTool buttonTool22 = new ButtonTool("Production Goal...");
    ButtonTool buttonTool23 = new ButtonTool("User Relationship");
    ButtonTool buttonTool24 = new ButtonTool("Assign Client Offices");
    ButtonTool buttonTool25 = new ButtonTool("Producer/Line Blocking");
    ButtonTool buttonTool26 = new ButtonTool("Assign BillingTypes");
    UltraTab ultraTab1 = new UltraTab();
    Infragistics.Win.Appearance appearance176 = new Infragistics.Win.Appearance();
    UltraTab ultraTab2 = new UltraTab();
    Infragistics.Win.Appearance appearance177 = new Infragistics.Win.Appearance();
    UltraTab ultraTab3 = new UltraTab();
    Infragistics.Win.Appearance appearance178 = new Infragistics.Win.Appearance();
    UltraTab ultraTab4 = new UltraTab();
    Infragistics.Win.Appearance appearance179 = new Infragistics.Win.Appearance();
    UltraTab ultraTab5 = new UltraTab();
    Infragistics.Win.Appearance appearance180 = new Infragistics.Win.Appearance();
    UltraTab ultraTab6 = new UltraTab();
    Infragistics.Win.Appearance appearance181 = new Infragistics.Win.Appearance();
    UltraTab ultraTab7 = new UltraTab();
    Infragistics.Win.Appearance appearance182 = new Infragistics.Win.Appearance();
    UltraTab ultraTab8 = new UltraTab();
    UltraTab ultraTab9 = new UltraTab();
    this.UltraTabPageControl1 = new UltraTabPageControl();
    this.lblInhouseProducer = new Label();
    this.MgaInternationalFax = new MGAInternationalPhoneNumberEditor();
    this.MgaInternationalPhone = new MGAInternationalPhoneNumberEditor();
    this.lblNameonCheck = new Label();
    this.txtFax = new MGAMaskedEdit();
    this.dsProducer = new dsProducers();
    this.txtPhone = new MGAMaskedEdit();
    this.mgatxtNameonCheck = new MGATextBox();
    this.lblStatusChnageComm = new Label();
    this.lblStatusChnageComment = new Label();
    this.txtStatusChangeComments = new MGATextBox();
    this.lblStatusReasonID = new Label();
    this.cboReason = new MGASimpleComboBox();
    this.lblStatusChangeReason = new Label();
    this.Label35 = new Label();
    this.txtNPN = new MGATextBox();
    this.chkOnStatement = new MGACheckBox();
    this.Label31 = new Label();
    this.cboPaymentMethod = new MGASimpleComboBox();
    this.chkOptOut = new MGACheckBox();
    this.Label26 = new Label();
    this.Label25 = new Label();
    this.txtGrossWrittenPremium = new MGANumericEditor();
    this.txtNumEmployees = new MGANumericEditor();
    this.Label24 = new Label();
    this.MgaTextBox1 = new MGATextBox();
    this.cboProducerRegion = new MGASimpleComboBox();
    this.Label23 = new Label();
    this.cboMailTo = new MGASimpleComboBox();
    this.Label15 = new Label();
    this.cboBillTo = new MGASimpleComboBox();
    this.Label14 = new Label();
    this.cboDeliveryMethod = new MGASimpleComboBox();
    this.cbOfficeType = new MGASimpleComboBox();
    this.cbStatus = new MGASimpleComboBox();
    this.txtEmail = new MGATextBox();
    this.Label11 = new Label();
    this.Label12 = new Label();
    this.ctlZipCode = new AddressResolver_MULTI();
    this.txtFEIN1 = new MGAMaskedEdit();
    this.Label16 = new Label();
    this.txtWebSite = new MGATextBox();
    this.Label13 = new Label();
    this.Label8 = new Label();
    this.Label4 = new Label();
    this.cboProducerType = new MGASimpleComboBox();
    this.Label3 = new Label();
    this.Label6 = new Label();
    this.lblPhone = new Label();
    this.Label7 = new Label();
    this.txtLocation = new MGATextBox();
    this.Label9 = new Label();
    this.lblAdded = new UltraLabel();
    this.Label2 = new Label();
    this.txtCode = new MGATextBox();
    this.lblRecords = new UltraLabel();
    this.btnDelete = new MGAButton();
    this.btnPrev = new MGAButton();
    this.btnNext = new MGAButton();
    this.btnLast = new MGAButton();
    this.btnFirst = new MGAButton();
    this.btnNewProducerLocation = new MGAButton();
    this.UltraTabPageControl2 = new UltraTabPageControl();
    this.btnQueryDates = new Button();
    this.Label37 = new Label();
    this.Label36 = new Label();
    this.dtEndDate = new MGADateTimePicker();
    this.dtStartDate = new MGADateTimePicker();
    this.lblNumSubmitted = new UltraLabel();
    this.Label34 = new Label();
    this.lblNumDeclined = new UltraLabel();
    this.Label33 = new Label();
    this.lblNumBind = new UltraLabel();
    this.Label32 = new Label();
    this.lblNumQuoted = new UltraLabel();
    this.Label30 = new Label();
    this.lblLoading = new Label();
    this.cboCompanyLines = new MGASimpleComboBox();
    this.Label22 = new Label();
    this.chartStats = new Infragistics.Win.UltraWinChart.UltraChart();
    this.lblTotalPremium = new UltraLabel();
    this.Label17 = new Label();
    this.lblRenewalRetention = new UltraLabel();
    this.Label18 = new Label();
    this.lblDeclineRatio = new UltraLabel();
    this.Label19 = new Label();
    this.lblBindRatio = new UltraLabel();
    this.Label20 = new Label();
    this.lblQuoteRatio = new UltraLabel();
    this.Label21 = new Label();
    this.UltraTabPageControl5 = new UltraTabPageControl();
    this.ugPoliciesGrid = new UltraGrid();
    this.UltraTabPageControl3 = new UltraTabPageControl();
    this.grpContactOfac = new UltraGroupBox();
    this.lblOfacClearedUser = new Label();
    this.lblOfacClearedDate = new Label();
    this.dtOFACClearedDate = new MGADateTimePicker();
    this.chkOFACCleared = new MGACheckBox();
    this.lblOFACReturnCode = new Label();
    this.lblOFACDate = new Label();
    this.ugOFAC = new UltraGrid();
    this.lblCurrentContact = new Label();
    this.btnNewContact = new MGAButton();
    this.btnSelectContact = new MGAButton();
    this.lstContacts = new MGAListBox();
    this.mnuContacts = new ContextMenu();
    this.mnuActive = new MenuItem();
    this.mnuInactive = new MenuItem();
    this.mnuBothContacts = new MenuItem();
    this.UltraTabPageControl4 = new UltraTabPageControl();
    this.chkEmailReminders = new UltraCheckEditor();
    this.chkAutoNOC = new UltraCheckEditor();
    this.tabCRM = new UltraTabPageControl();
    this.lblReferredBy = new Label();
    this.cboProducerlocations = new MGAComboBox();
    this.Label29 = new Label();
    this.MgaComboBox1 = new MGAComboBox();
    this.dtProdAgrrmntEff = new MGADateTimePicker();
    this.Label28 = new Label();
    this.chkApproveWholesalersList = new MGACheckBox();
    this.chkSetProcedureToEngage = new MGACheckBox();
    this.UltraGroupBox2 = new UltraGroupBox();
    this.txtWholesaleRelationships = new RichTextBox();
    this.UltraGroupBox1 = new UltraGroupBox();
    this.txtExpertise = new RichTextBox();
    this.UltraGroupBox4 = new UltraGroupBox();
    this.txtSpecFocusDept = new RichTextBox();
    this.Label27 = new Label();
    this.numWholesaleRel = new MGANumericEditor();
    this.lblProdPro = new Label();
    this.lblSource = new Label();
    this.lblProductionStatus = new Label();
    this.lblProdStatus = new Label();
    this.cboOwner = new MGAComboBox();
    this.cboProductionPotential = new MGAComboBox();
    this.cboSource = new MGAComboBox();
    this.lblOwner = new Label();
    this.lblGWP = new Label();
    this.lblEmployees = new Label();
    this.numGWP = new MGANumericEditor();
    this.numEmployees = new MGANumericEditor();
    this.tabCallReport = new UltraTabPageControl();
    this.btnReport = new MGAButton();
    this.ugDetails = new UltraGrid();
    this.dvCallReports = new DataView();
    this.tabLogo = new UltraTabPageControl();
    this.pbLogo = new PictureBox();
    this.btnNewImage = new MGAButton();
    this.tabSirconInfo = new UltraTabPageControl();
    this.lblSirconStatus = new Label();
    this.tbSirconStatus = new TextBox();
    this.tbSirconMsg = new TextBox();
    this.lblOrgNPN = new Label();
    this.tbOrgNPN = new TextBox();
    this.lblLicenses = new Label();
    this.lblLOAs = new Label();
    this.SirconLicenseGrid = new UltraGrid();
    this.DsSirconDataSetBindingSource1 = new BindingSource(this.components);
    this.DsSirconDataSet = new dsSirconDataSet();
    this.SirconLOAGrid = new UltraGrid();
    this.DsSirconDataSetBindingSource = new BindingSource(this.components);
    this.ToolTip = new ToolTip(this.components);
    this.dbSave = new MGASystems.Tools.DBSaveUI.DBSaveUI();
    this.cnSQL = new SqlConnection();
    this.daContacts = new SqlDataAdapter();
    this.SqlSelectCommand5 = new SqlCommand();
    this.gbProducer = new UltraGroupBox();
    this.lblProducerCode = new UltraLabel();
    this.Label10 = new Label();
    this.Label1 = new Label();
    this.txtProducerName = new MGATextBox();
    this.cboBusinessTypes = new MGASimpleComboBox();
    this.Label5 = new Label();
    this.daLocations = new SqlDataAdapter();
    this.SqlDeleteCommand1 = new SqlCommand();
    this.SqlInsertCommand1 = new SqlCommand();
    this.SqlSelectCommand2 = new SqlCommand();
    this.SqlUpdateCommand1 = new SqlCommand();
    this.err = new ErrorProvider(this.components);
    this.menuProducer = new UltraToolbarsManager(this.components);
    this._frmProducers_Toolbars_Dock_Area_Left = new UltraToolbarsDockArea();
    this._frmProducers_Toolbars_Dock_Area_Right = new UltraToolbarsDockArea();
    this._frmProducers_Toolbars_Dock_Area_Top = new UltraToolbarsDockArea();
    this._frmProducers_Toolbars_Dock_Area_Bottom = new UltraToolbarsDockArea();
    this.daProducers = new SqlDataAdapter();
    this.SqlDeleteCommand2 = new SqlCommand();
    this.SqlInsertCommand2 = new SqlCommand();
    this.SqlSelectCommand1 = new SqlCommand();
    this.SqlUpdateCommand2 = new SqlCommand();
    this.tabLocationInfo = new UltraTabControl();
    this.UltraTabSharedControlsPage1 = new UltraTabSharedControlsPage();
    this.daLoadData = new SqlDataAdapter();
    this.SqlSelectCommand3 = new SqlCommand();
    this.daProducerRegion = new SqlDataAdapter();
    this.SqlCommand1 = new SqlCommand();
    ((Control) this.UltraTabPageControl1).SuspendLayout();
    ((ISupportInitialize) this.txtFax).BeginInit();
    this.dsProducer.BeginInit();
    ((ISupportInitialize) this.txtPhone).BeginInit();
    ((ISupportInitialize) this.mgatxtNameonCheck).BeginInit();
    ((ISupportInitialize) this.txtStatusChangeComments).BeginInit();
    ((ISupportInitialize) this.cboReason).BeginInit();
    ((ISupportInitialize) this.txtNPN).BeginInit();
    ((ISupportInitialize) this.chkOnStatement).BeginInit();
    ((ISupportInitialize) this.cboPaymentMethod).BeginInit();
    ((ISupportInitialize) this.chkOptOut).BeginInit();
    ((ISupportInitialize) this.txtGrossWrittenPremium).BeginInit();
    ((ISupportInitialize) this.txtNumEmployees).BeginInit();
    ((ISupportInitialize) this.MgaTextBox1).BeginInit();
    ((ISupportInitialize) this.cboProducerRegion).BeginInit();
    ((ISupportInitialize) this.cboMailTo).BeginInit();
    ((ISupportInitialize) this.cboBillTo).BeginInit();
    ((ISupportInitialize) this.cboDeliveryMethod).BeginInit();
    ((ISupportInitialize) this.cbOfficeType).BeginInit();
    ((ISupportInitialize) this.cbStatus).BeginInit();
    ((ISupportInitialize) this.txtEmail).BeginInit();
    ((ISupportInitialize) this.txtFEIN1).BeginInit();
    ((ISupportInitialize) this.txtWebSite).BeginInit();
    ((ISupportInitialize) this.cboProducerType).BeginInit();
    ((ISupportInitialize) this.txtLocation).BeginInit();
    ((ISupportInitialize) this.txtCode).BeginInit();
    ((ISupportInitialize) this.btnDelete).BeginInit();
    ((ISupportInitialize) this.btnPrev).BeginInit();
    ((ISupportInitialize) this.btnNext).BeginInit();
    ((ISupportInitialize) this.btnLast).BeginInit();
    ((ISupportInitialize) this.btnFirst).BeginInit();
    ((ISupportInitialize) this.btnNewProducerLocation).BeginInit();
    ((Control) this.UltraTabPageControl2).SuspendLayout();
    ((ISupportInitialize) this.dtEndDate).BeginInit();
    ((ISupportInitialize) this.dtStartDate).BeginInit();
    ((ISupportInitialize) this.cboCompanyLines).BeginInit();
    ((ISupportInitialize) this.chartStats).BeginInit();
    ((Control) this.UltraTabPageControl5).SuspendLayout();
    ((ISupportInitialize) this.ugPoliciesGrid).BeginInit();
    ((Control) this.UltraTabPageControl3).SuspendLayout();
    ((ISupportInitialize) this.grpContactOfac).BeginInit();
    ((Control) this.grpContactOfac).SuspendLayout();
    ((ISupportInitialize) this.dtOFACClearedDate).BeginInit();
    ((ISupportInitialize) this.chkOFACCleared).BeginInit();
    ((ISupportInitialize) this.ugOFAC).BeginInit();
    ((ISupportInitialize) this.btnNewContact).BeginInit();
    ((ISupportInitialize) this.btnSelectContact).BeginInit();
    ((ISupportInitialize) this.lstContacts).BeginInit();
    ((Control) this.UltraTabPageControl4).SuspendLayout();
    ((ISupportInitialize) this.chkEmailReminders).BeginInit();
    ((ISupportInitialize) this.chkAutoNOC).BeginInit();
    ((Control) this.tabCRM).SuspendLayout();
    ((ISupportInitialize) this.cboProducerlocations).BeginInit();
    ((ISupportInitialize) this.MgaComboBox1).BeginInit();
    ((ISupportInitialize) this.dtProdAgrrmntEff).BeginInit();
    ((ISupportInitialize) this.chkApproveWholesalersList).BeginInit();
    ((ISupportInitialize) this.chkSetProcedureToEngage).BeginInit();
    ((ISupportInitialize) this.UltraGroupBox2).BeginInit();
    ((Control) this.UltraGroupBox2).SuspendLayout();
    ((ISupportInitialize) this.UltraGroupBox1).BeginInit();
    ((Control) this.UltraGroupBox1).SuspendLayout();
    ((ISupportInitialize) this.UltraGroupBox4).BeginInit();
    ((Control) this.UltraGroupBox4).SuspendLayout();
    ((ISupportInitialize) this.numWholesaleRel).BeginInit();
    ((ISupportInitialize) this.cboOwner).BeginInit();
    ((ISupportInitialize) this.cboProductionPotential).BeginInit();
    ((ISupportInitialize) this.cboSource).BeginInit();
    ((ISupportInitialize) this.numGWP).BeginInit();
    ((ISupportInitialize) this.numEmployees).BeginInit();
    ((Control) this.tabCallReport).SuspendLayout();
    ((ISupportInitialize) this.btnReport).BeginInit();
    ((ISupportInitialize) this.ugDetails).BeginInit();
    this.dvCallReports.BeginInit();
    ((Control) this.tabLogo).SuspendLayout();
    ((ISupportInitialize) this.pbLogo).BeginInit();
    ((ISupportInitialize) this.btnNewImage).BeginInit();
    ((Control) this.tabSirconInfo).SuspendLayout();
    ((ISupportInitialize) this.SirconLicenseGrid).BeginInit();
    ((ISupportInitialize) this.DsSirconDataSetBindingSource1).BeginInit();
    this.DsSirconDataSet.BeginInit();
    ((ISupportInitialize) this.SirconLOAGrid).BeginInit();
    ((ISupportInitialize) this.DsSirconDataSetBindingSource).BeginInit();
    ((ISupportInitialize) this.gbProducer).BeginInit();
    ((Control) this.gbProducer).SuspendLayout();
    ((ISupportInitialize) this.txtProducerName).BeginInit();
    ((ISupportInitialize) this.cboBusinessTypes).BeginInit();
    ((ISupportInitialize) this.err).BeginInit();
    ((ISupportInitialize) this.menuProducer).BeginInit();
    ((ISupportInitialize) this.tabLocationInfo).BeginInit();
    ((Control) this.tabLocationInfo).SuspendLayout();
    ((Control) this.UltraTabSharedControlsPage1).SuspendLayout();
    this.SuspendLayout();
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.lblInhouseProducer);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.MgaInternationalFax);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.MgaInternationalPhone);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.lblNameonCheck);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.txtFax);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.txtPhone);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.mgatxtNameonCheck);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.lblStatusChnageComm);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.lblStatusChnageComment);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.txtStatusChangeComments);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.lblStatusReasonID);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.cboReason);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.lblStatusChangeReason);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label35);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.txtNPN);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.chkOnStatement);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label31);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.cboPaymentMethod);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.chkOptOut);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label26);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label25);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.txtGrossWrittenPremium);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.txtNumEmployees);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label24);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.MgaTextBox1);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.cboProducerRegion);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label23);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.cboMailTo);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label15);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.cboBillTo);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label14);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.cboDeliveryMethod);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.cbOfficeType);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.cbStatus);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.txtEmail);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label11);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label12);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.ctlZipCode);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.txtFEIN1);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label16);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.txtWebSite);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label13);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label8);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label4);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.cboProducerType);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label3);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label6);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.lblPhone);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label7);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.txtLocation);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label9);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.lblAdded);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label2);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.txtCode);
    ((Control) this.UltraTabPageControl1).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabPageControl1).Name = "UltraTabPageControl1";
    ((Control) this.UltraTabPageControl1).Size = new Size(876, 341);
    this.lblInhouseProducer.AutoSize = true;
    this.lblInhouseProducer.BackColor = Color.Transparent;
    this.lblInhouseProducer.Location = new Point(358, 281);
    this.lblInhouseProducer.Name = "lblInhouseProducer";
    this.lblInhouseProducer.Size = new Size(100, 13);
    this.lblInhouseProducer.TabIndex = 67;
    this.lblInhouseProducer.Text = "In-house producer:";
    this.lblInhouseProducer.TextAlign = ContentAlignment.MiddleRight;
    this.lblInhouseProducer.Visible = false;
    this.MgaInternationalFax.CountryCode = "";
    this.MgaInternationalFax.Location = new Point(361, 33);
    this.MgaInternationalFax.MGAStyle = MGAStyles.Gray;
    this.MgaInternationalFax.Name = "MgaInternationalFax";
    this.MgaInternationalFax.Size = new Size(184, 21);
    this.MgaInternationalFax.TabIndex = 66;
    this.MgaInternationalFax.Value = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("MgaInternationalFax.Value"));
    this.MgaInternationalPhone.CountryCode = "";
    this.MgaInternationalPhone.Location = new Point(361, 8);
    this.MgaInternationalPhone.MGAStyle = MGAStyles.Gray;
    this.MgaInternationalPhone.Name = "MgaInternationalPhone";
    this.MgaInternationalPhone.Size = new Size(184, 21);
    this.MgaInternationalPhone.TabIndex = 65;
    this.MgaInternationalPhone.Value = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("MgaInternationalPhone.Value"));
    this.lblNameonCheck.AutoSize = true;
    this.lblNameonCheck.BackColor = Color.Transparent;
    this.lblNameonCheck.Location = new Point(2, 310);
    this.lblNameonCheck.Name = "lblNameonCheck";
    this.lblNameonCheck.Size = new Size(85, 13);
    this.lblNameonCheck.TabIndex = 64 /*0x40*/;
    this.lblNameonCheck.Text = "Name on Check:";
    this.lblNameonCheck.TextAlign = ContentAlignment.MiddleRight;
    appearance1.BackColorDisabled = Color.Gainsboro;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.txtFax.Appearance = (AppearanceBase) appearance1;
    ((Control) this.txtFax).DataBindings.Add(new Binding("Text", (object) this.dsProducer, "tblProducerLocations.Fax", true));
    this.txtFax.EditAs = (EditAsType) 1;
    ((Control) this.txtFax).Enabled = false;
    this.txtFax.InputMask = "###-###-####";
    ((Control) this.txtFax).Location = new Point(549, 35);
    this.txtFax.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtFax).Name = "txtFax";
    this.txtFax.NonAutoSizeHeight = 20;
    ((Control) this.txtFax).Size = new Size(96 /*0x60*/, 21);
    ((Control) this.txtFax).TabIndex = 7;
    this.txtFax.Text = "--";
    ((UltraControlBase) this.txtFax).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtFax).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.txtFax).Visible = false;
    this.dsProducer.DataSetName = "dsProducers";
    this.dsProducer.Locale = new CultureInfo("en-US");
    this.dsProducer.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    appearance2.BackColorDisabled = Color.Gainsboro;
    appearance2.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.txtPhone.Appearance = (AppearanceBase) appearance2;
    ((Control) this.txtPhone).DataBindings.Add(new Binding("Text", (object) this.dsProducer, "tblProducerLocations.Phone", true));
    this.txtPhone.EditAs = (EditAsType) 1;
    ((Control) this.txtPhone).Enabled = false;
    this.txtPhone.InputMask = "###-###-####";
    ((Control) this.txtPhone).Location = new Point(549, 8);
    this.txtPhone.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtPhone).Name = "txtPhone";
    this.txtPhone.NonAutoSizeHeight = 20;
    ((Control) this.txtPhone).Size = new Size(96 /*0x60*/, 21);
    ((Control) this.txtPhone).TabIndex = 6;
    this.txtPhone.Text = "--";
    ((UltraControlBase) this.txtPhone).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtPhone).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.txtPhone).Visible = false;
    appearance3.BackColor = Color.White;
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance3.ForeColor = Color.Black;
    ((TextEditorControlBase) this.mgatxtNameonCheck).Appearance = (AppearanceBase) appearance3;
    ((TextEditorControlBase) this.mgatxtNameonCheck).BackColor = Color.White;
    ((Control) this.mgatxtNameonCheck).DataBindings.Add(new Binding("Text", (object) this.dsProducer, "tblProducerLocations.NameonCheck", true));
    ((Control) this.mgatxtNameonCheck).Location = new Point(95, 306);
    ((TextEditorControlBase) this.mgatxtNameonCheck).MaxLength = 150;
    this.mgatxtNameonCheck.MGAStyle = MGAStyles.Blue;
    ((Control) this.mgatxtNameonCheck).Name = "mgatxtNameonCheck";
    ((Control) this.mgatxtNameonCheck).Size = new Size(216, 20);
    ((Control) this.mgatxtNameonCheck).TabIndex = 63 /*0x3F*/;
    ((UltraControlBase) this.mgatxtNameonCheck).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.mgatxtNameonCheck).UseOsThemes = (DefaultableBoolean) 2;
    this.lblStatusChnageComm.AutoSize = true;
    this.lblStatusChnageComm.BackColor = Color.Transparent;
    this.lblStatusChnageComm.Location = new Point(611, 205);
    this.lblStatusChnageComm.Name = "lblStatusChnageComm";
    this.lblStatusChnageComm.Size = new Size(82, 13);
    this.lblStatusChnageComm.TabIndex = 62;
    this.lblStatusChnageComm.Text = "Status Change:";
    this.lblStatusChnageComm.TextAlign = ContentAlignment.MiddleRight;
    this.lblStatusChnageComment.AutoSize = true;
    this.lblStatusChnageComment.BackColor = Color.Transparent;
    this.lblStatusChnageComment.Location = new Point(613, 218);
    this.lblStatusChnageComment.Name = "lblStatusChnageComment";
    this.lblStatusChnageComment.Size = new Size(56, 13);
    this.lblStatusChnageComment.TabIndex = 61;
    this.lblStatusChnageComment.Text = "Comment:";
    this.lblStatusChnageComment.TextAlign = ContentAlignment.MiddleRight;
    appearance4.BackColor = Color.White;
    appearance4.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance4.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtStatusChangeComments).Appearance = (AppearanceBase) appearance4;
    ((TextEditorControlBase) this.txtStatusChangeComments).BackColor = Color.White;
    ((Control) this.txtStatusChangeComments).DataBindings.Add(new Binding("Value", (object) this.dsProducer, "tblProducerLocations.StatusChangeReasonComment", true));
    ((Control) this.txtStatusChangeComments).Enabled = false;
    ((Control) this.txtStatusChangeComments).Location = new Point(697, 199);
    ((TextEditorControlBase) this.txtStatusChangeComments).MaxLength = 300;
    this.txtStatusChangeComments.MGAStyle = MGAStyles.Blue;
    this.txtStatusChangeComments.Multiline = true;
    ((Control) this.txtStatusChangeComments).Name = "txtStatusChangeComments";
    ((Control) this.txtStatusChangeComments).Size = new Size(165, 52);
    ((Control) this.txtStatusChangeComments).TabIndex = 60;
    ((UltraControlBase) this.txtStatusChangeComments).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtStatusChangeComments).UseOsThemes = (DefaultableBoolean) 2;
    this.lblStatusReasonID.AutoSize = true;
    this.lblStatusReasonID.BackColor = Color.Transparent;
    this.lblStatusReasonID.Location = new Point(613, 181);
    this.lblStatusReasonID.Name = "lblStatusReasonID";
    this.lblStatusReasonID.Size = new Size(47, 13);
    this.lblStatusReasonID.TabIndex = 59;
    this.lblStatusReasonID.Text = "Reason:";
    this.lblStatusReasonID.TextAlign = ContentAlignment.MiddleRight;
    this.cboReason.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboReason).DataBindings.Add(new Binding("Value", (object) this.dsProducer, "tblProducerLocations.StatusChangeReasonID", true));
    ((UltraGridBase) this.cboReason).DataMember = "lstProducerStatusReasons";
    ((UltraGridBase) this.cboReason).DataSource = (object) this.dsProducer;
    ((UltraDropDownBase) this.cboReason).DisplayMember = "Reason";
    this.cboReason.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboReason).DropDownWidth = 500;
    ((Control) this.cboReason).Enabled = false;
    ((Control) this.cboReason).Location = new Point(697, 165);
    this.cboReason.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboReason).Name = "cboReason";
    ((Control) this.cboReason).Size = new Size(124, 21);
    ((Control) this.cboReason).TabIndex = 57;
    ((UltraControlBase) this.cboReason).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboReason).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboReason).ValueMember = "ID";
    this.lblStatusChangeReason.AutoSize = true;
    this.lblStatusChangeReason.BackColor = Color.Transparent;
    this.lblStatusChangeReason.Location = new Point(613, 168);
    this.lblStatusChangeReason.Name = "lblStatusChangeReason";
    this.lblStatusChangeReason.Size = new Size(82, 13);
    this.lblStatusChangeReason.TabIndex = 58;
    this.lblStatusChangeReason.Text = "Status Change:";
    this.lblStatusChangeReason.TextAlign = ContentAlignment.MiddleRight;
    this.Label35.AutoSize = true;
    this.Label35.BackColor = Color.Transparent;
    this.Label35.Location = new Point(311, 158);
    this.Label35.Name = "Label35";
    this.Label35.Size = new Size(42, 13);
    this.Label35.TabIndex = 50;
    this.Label35.Text = "NPN# :";
    this.Label35.TextAlign = ContentAlignment.MiddleRight;
    appearance5.BackColor = Color.White;
    appearance5.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance5.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtNPN).Appearance = (AppearanceBase) appearance5;
    ((TextEditorControlBase) this.txtNPN).BackColor = Color.White;
    ((Control) this.txtNPN).DataBindings.Add(new Binding("Text", (object) this.dsProducer, "tblProducerLocations.NPN", true));
    ((Control) this.txtNPN).Location = new Point(361, 154);
    ((TextEditorControlBase) this.txtNPN).MaxLength = 20;
    this.txtNPN.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtNPN).Name = "txtNPN";
    ((Control) this.txtNPN).Size = new Size(192 /*0xC0*/, 20);
    ((Control) this.txtNPN).TabIndex = 12;
    ((UltraControlBase) this.txtNPN).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtNPN).UseOsThemes = (DefaultableBoolean) 2;
    appearance6.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance6.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkOnStatement).Appearance = (AppearanceBase) appearance6;
    ((UltraToggleEditorBase) this.chkOnStatement).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkOnStatement).BackColorInternal = Color.Transparent;
    ((Control) this.chkOnStatement).DataBindings.Add(new Binding("CheckedValue", (object) this.dsProducer, "tblProducerLocations.OnStatement", true));
    ((UltraToggleEditorBase) this.chkOnStatement).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkOnStatement).Location = new Point(361, 258);
    this.chkOnStatement.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkOnStatement).Name = "chkOnStatement";
    ((Control) this.chkOnStatement).Size = new Size(105, 20);
    ((Control) this.chkOnStatement).TabIndex = 23;
    ((UltraToggleEditorBase) this.chkOnStatement).Text = "On Statement";
    ((UltraControlBase) this.chkOnStatement).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkOnStatement).UseOsThemes = (DefaultableBoolean) 2;
    this.Label31.AutoSize = true;
    this.Label31.BackColor = Color.Transparent;
    this.Label31.Location = new Point(9, 286);
    this.Label31.Name = "Label31";
    this.Label31.Size = new Size(80 /*0x50*/, 13);
    this.Label31.TabIndex = 47;
    this.Label31.Text = "Paymt Method:";
    this.Label31.TextAlign = ContentAlignment.MiddleRight;
    this.cboPaymentMethod.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboPaymentMethod).DataBindings.Add(new Binding("Value", (object) this.dsProducer, "tblProducerLocations.PaymentMethodID", true));
    ((UltraGridBase) this.cboPaymentMethod).DataMember = "lstPaymentMethods";
    ((UltraGridBase) this.cboPaymentMethod).DataSource = (object) this.dsProducer;
    ((UltraDropDownBase) this.cboPaymentMethod).DisplayMember = "PaymentMethod";
    this.cboPaymentMethod.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboPaymentMethod).DropDownWidth = 350;
    ((Control) this.cboPaymentMethod).Location = new Point(95, 279);
    this.cboPaymentMethod.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboPaymentMethod).Name = "cboPaymentMethod";
    ((Control) this.cboPaymentMethod).Size = new Size(216, 21);
    ((Control) this.cboPaymentMethod).TabIndex = 5;
    ((UltraControlBase) this.cboPaymentMethod).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboPaymentMethod).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboPaymentMethod).ValueMember = "ID";
    appearance7.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance7.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkOptOut).Appearance = (AppearanceBase) appearance7;
    ((UltraToggleEditorBase) this.chkOptOut).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkOptOut).BackColorInternal = Color.Transparent;
    ((Control) this.chkOptOut).DataBindings.Add(new Binding("CheckedValue", (object) this.dsProducer, "tblProducerLocations.OptOut", true));
    ((UltraToggleEditorBase) this.chkOptOut).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkOptOut).Location = new Point(361, 232);
    this.chkOptOut.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkOptOut).Name = "chkOptOut";
    ((Control) this.chkOptOut).Size = new Size(72, 20);
    ((Control) this.chkOptOut).TabIndex = 22;
    ((UltraToggleEditorBase) this.chkOptOut).Text = "Opt Out ";
    ((UltraControlBase) this.chkOptOut).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkOptOut).UseOsThemes = (DefaultableBoolean) 2;
    this.Label26.AutoSize = true;
    this.Label26.BackColor = Color.Transparent;
    this.Label26.Location = new Point(573, 113);
    this.Label26.Name = "Label26";
    this.Label26.Size = new Size(120, 13);
    this.Label26.TabIndex = 43;
    this.Label26.Text = "Gross Written Premium:";
    this.Label26.TextAlign = ContentAlignment.MiddleRight;
    this.Label25.AutoSize = true;
    this.Label25.BackColor = Color.Transparent;
    this.Label25.Location = new Point(624, 87);
    this.Label25.Name = "Label25";
    this.Label25.Size = new Size(73, 13);
    this.Label25.TabIndex = 42;
    this.Label25.Text = "# Employees:";
    this.Label25.TextAlign = ContentAlignment.MiddleRight;
    appearance8.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.txtGrossWrittenPremium).Appearance = (AppearanceBase) appearance8;
    ((Control) this.txtGrossWrittenPremium).DataBindings.Add(new Binding("Value", (object) this.dsProducer, "tblProducerLocations.GrossWrittenPremium", true));
    ((UltraNumericEditorBase) this.txtGrossWrittenPremium).FormatString = "c";
    ((Control) this.txtGrossWrittenPremium).Location = new Point(699, 109);
    this.txtGrossWrittenPremium.MaxValue = (object) new Decimal(new int[4]
    {
      1410065407,
      2,
      0,
      0
    });
    this.txtGrossWrittenPremium.MGAStyle = MGAStyles.Blue;
    this.txtGrossWrittenPremium.MinValue = (object) 0;
    ((Control) this.txtGrossWrittenPremium).Name = "txtGrossWrittenPremium";
    this.txtGrossWrittenPremium.Nullable = true;
    this.txtGrossWrittenPremium.NumericType = (NumericType) 2;
    ((Control) this.txtGrossWrittenPremium).Size = new Size(124, 20);
    ((Control) this.txtGrossWrittenPremium).TabIndex = 21;
    ((UltraControlBase) this.txtGrossWrittenPremium).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtGrossWrittenPremium).UseOsThemes = (DefaultableBoolean) 2;
    appearance9.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.txtNumEmployees).Appearance = (AppearanceBase) appearance9;
    ((Control) this.txtNumEmployees).DataBindings.Add(new Binding("Value", (object) this.dsProducer, "tblProducerLocations.NumEmployees", true));
    ((UltraNumericEditorBase) this.txtNumEmployees).FormatString = "";
    ((Control) this.txtNumEmployees).Location = new Point(699, 83);
    this.txtNumEmployees.MaxValue = (object) 99999;
    this.txtNumEmployees.MGAStyle = MGAStyles.Blue;
    this.txtNumEmployees.MinValue = (object) 0;
    ((Control) this.txtNumEmployees).Name = "txtNumEmployees";
    this.txtNumEmployees.Nullable = true;
    ((Control) this.txtNumEmployees).Size = new Size(72, 20);
    ((Control) this.txtNumEmployees).TabIndex = 20;
    ((UltraControlBase) this.txtNumEmployees).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtNumEmployees).UseOsThemes = (DefaultableBoolean) 2;
    this.Label24.AutoSize = true;
    this.Label24.BackColor = Color.Transparent;
    this.Label24.Location = new Point(632, 61);
    this.Label24.Name = "Label24";
    this.Label24.Size = new Size(65, 13);
    this.Label24.TabIndex = 39;
    this.Label24.Text = "Location ID:";
    this.Label24.TextAlign = ContentAlignment.MiddleRight;
    appearance10.BackColor = Color.White;
    appearance10.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance10.ForeColor = Color.Black;
    ((TextEditorControlBase) this.MgaTextBox1).Appearance = (AppearanceBase) appearance10;
    ((TextEditorControlBase) this.MgaTextBox1).BackColor = Color.White;
    ((Control) this.MgaTextBox1).DataBindings.Add(new Binding("Text", (object) this.dsProducer, "tblProducerLocations.ProducerLocationID", true));
    ((Control) this.MgaTextBox1).Location = new Point(699, 57);
    this.MgaTextBox1.MGAStyle = MGAStyles.Blue;
    ((Control) this.MgaTextBox1).Name = "MgaTextBox1";
    ((Control) this.MgaTextBox1).Size = new Size(124, 20);
    ((Control) this.MgaTextBox1).TabIndex = 19;
    ((UltraControlBase) this.MgaTextBox1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaTextBox1).UseOsThemes = (DefaultableBoolean) 2;
    this.cboProducerRegion.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboProducerRegion).DataBindings.Add(new Binding("Value", (object) this.dsProducer, "tblProducerLocations.ProducerLocationRegion", true));
    ((UltraGridBase) this.cboProducerRegion).DataSource = (object) this.dsProducer.lstProducerLocationRegions;
    ((UltraDropDownBase) this.cboProducerRegion).DisplayMember = "ProducerRegion";
    this.cboProducerRegion.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboProducerRegion).DropDownWidth = 500;
    ((Control) this.cboProducerRegion).Location = new Point(699, 33);
    this.cboProducerRegion.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboProducerRegion).Name = "cboProducerRegion";
    ((Control) this.cboProducerRegion).Size = new Size(124, 21);
    ((Control) this.cboProducerRegion).TabIndex = 18;
    ((UltraControlBase) this.cboProducerRegion).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboProducerRegion).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboProducerRegion).ValueMember = "ID";
    this.Label23.AutoSize = true;
    this.Label23.BackColor = Color.Transparent;
    this.Label23.Location = new Point(651, 37);
    this.Label23.Name = "Label23";
    this.Label23.Size = new Size(44, 13);
    this.Label23.TabIndex = 36;
    this.Label23.Text = "Region:";
    this.Label23.TextAlign = ContentAlignment.MiddleRight;
    this.cboMailTo.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboMailTo).DataBindings.Add(new Binding("Value", (object) this.dsProducer, "tblProducerLocations.MailToProducerLocationGuid", true));
    ((UltraGridBase) this.cboMailTo).DataSource = (object) this.dsProducer.tblProducerLocations;
    ((UltraDropDownBase) this.cboMailTo).DisplayMember = "Name";
    this.cboMailTo.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboMailTo).DropDownWidth = 500;
    ((Control) this.cboMailTo).Location = new Point(95, 254);
    this.cboMailTo.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboMailTo).Name = "cboMailTo";
    ((Control) this.cboMailTo).Size = new Size(216, 21);
    ((Control) this.cboMailTo).TabIndex = 4;
    ((UltraControlBase) this.cboMailTo).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboMailTo).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboMailTo).ValueMember = "ProducerLocationGUID";
    this.Label15.BackColor = Color.Transparent;
    this.Label15.Location = new Point(39, 259);
    this.Label15.Name = "Label15";
    this.Label15.Size = new Size(48 /*0x30*/, 17);
    this.Label15.TabIndex = 34;
    this.Label15.Text = "Mail To:";
    this.Label15.TextAlign = ContentAlignment.MiddleRight;
    this.cboBillTo.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboBillTo).DataBindings.Add(new Binding("Value", (object) this.dsProducer, "tblProducerLocations.BillToProducerLocationGuid", true));
    ((UltraGridBase) this.cboBillTo).DataSource = (object) this.dsProducer.tblProducerLocations;
    ((UltraDropDownBase) this.cboBillTo).DisplayMember = "Name";
    this.cboBillTo.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboBillTo).DropDownWidth = 500;
    ((Control) this.cboBillTo).Location = new Point(95, 230);
    this.cboBillTo.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboBillTo).Name = "cboBillTo";
    ((Control) this.cboBillTo).Size = new Size(216, 21);
    ((Control) this.cboBillTo).TabIndex = 3;
    ((UltraControlBase) this.cboBillTo).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboBillTo).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboBillTo).ValueMember = "ProducerLocationGUID";
    this.Label14.BackColor = Color.Transparent;
    this.Label14.Location = new Point(39, 232);
    this.Label14.Name = "Label14";
    this.Label14.Size = new Size(48 /*0x30*/, 17);
    this.Label14.TabIndex = 32 /*0x20*/;
    this.Label14.Text = "Bill To:";
    this.Label14.TextAlign = ContentAlignment.MiddleRight;
    this.cboDeliveryMethod.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboDeliveryMethod).DataBindings.Add(new Binding("Value", (object) this.dsProducer, "tblProducerLocations.DeliveryMethodID", true));
    ((UltraGridBase) this.cboDeliveryMethod).DataSource = (object) this.dsProducer.lstDeliveryMethod;
    ((UltraDropDownBase) this.cboDeliveryMethod).DisplayMember = "Description";
    this.cboDeliveryMethod.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboDeliveryMethod).Location = new Point(361, 180);
    this.cboDeliveryMethod.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboDeliveryMethod).Name = "cboDeliveryMethod";
    ((Control) this.cboDeliveryMethod).Size = new Size(192 /*0xC0*/, 21);
    ((Control) this.cboDeliveryMethod).TabIndex = 14;
    ((UltraControlBase) this.cboDeliveryMethod).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboDeliveryMethod).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboDeliveryMethod).ValueMember = "DeliveryMethodID";
    this.cbOfficeType.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cbOfficeType).DataBindings.Add(new Binding("Value", (object) this.dsProducer, "tblProducerLocations.LocationTypeID", true));
    ((UltraGridBase) this.cbOfficeType).DataSource = (object) this.dsProducer.lstLocationType;
    ((UltraDropDownBase) this.cbOfficeType).DisplayMember = "LocationType";
    this.cbOfficeType.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cbOfficeType).Location = new Point(361, 205);
    this.cbOfficeType.MGAStyle = MGAStyles.Blue;
    ((Control) this.cbOfficeType).Name = "cbOfficeType";
    ((Control) this.cbOfficeType).Size = new Size(192 /*0xC0*/, 21);
    ((Control) this.cbOfficeType).TabIndex = 15;
    ((UltraControlBase) this.cbOfficeType).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cbOfficeType).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cbOfficeType).ValueMember = "LocationTypeID";
    this.cbStatus.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cbStatus).DataBindings.Add(new Binding("Value", (object) this.dsProducer, "tblProducerLocations.StatusID", true));
    ((UltraGridBase) this.cbStatus).DataSource = (object) this.dsProducer.lstStatus;
    ((UltraDropDownBase) this.cbStatus).DisplayMember = "Status";
    this.cbStatus.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cbStatus).Location = new Point(699, 135);
    this.cbStatus.MGAStyle = MGAStyles.Blue;
    ((Control) this.cbStatus).Name = "cbStatus";
    ((Control) this.cbStatus).Size = new Size(137, 21);
    ((Control) this.cbStatus).TabIndex = 13;
    ((UltraControlBase) this.cbStatus).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cbStatus).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cbStatus).ValueMember = "StatusID";
    appearance11.BackColor = Color.White;
    appearance11.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance11.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtEmail).Appearance = (AppearanceBase) appearance11;
    ((TextEditorControlBase) this.txtEmail).BackColor = Color.White;
    ((Control) this.txtEmail).DataBindings.Add(new Binding("Text", (object) this.dsProducer, "tblProducerLocations.Email", true));
    ((Control) this.txtEmail).Location = new Point(361, 81);
    this.txtEmail.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtEmail).Name = "txtEmail";
    ((Control) this.txtEmail).Size = new Size(184, 20);
    ((Control) this.txtEmail).TabIndex = 9;
    ((UltraControlBase) this.txtEmail).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtEmail).UseOsThemes = (DefaultableBoolean) 2;
    this.Label11.AutoSize = true;
    this.Label11.BackColor = Color.Transparent;
    this.Label11.Location = new Point(653, 137);
    this.Label11.Name = "Label11";
    this.Label11.Size = new Size(42, 13);
    this.Label11.TabIndex = 17;
    this.Label11.Text = "Status:";
    this.Label11.TextAlign = ContentAlignment.MiddleRight;
    this.Label12.AutoSize = true;
    this.Label12.BackColor = Color.Transparent;
    this.Label12.Location = new Point(288, 209);
    this.Label12.Name = "Label12";
    this.Label12.Size = new Size(67, 13);
    this.Label12.TabIndex = 21;
    this.Label12.Text = "Office Type:";
    this.Label12.TextAlign = ContentAlignment.MiddleRight;
    this.ctlZipCode.Address1 = "";
    this.ctlZipCode.Address2 = "";
    ((Control) this.ctlZipCode).BackColor = Color.Transparent;
    this.ctlZipCode.City = "";
    this.ctlZipCode.County = "";
    ((Control) this.ctlZipCode).DataBindings.Add(new Binding("Address1", (object) this.dsProducer, "tblProducerLocations.Address1", true, DataSourceUpdateMode.OnPropertyChanged));
    ((Control) this.ctlZipCode).DataBindings.Add(new Binding("Address2", (object) this.dsProducer, "tblProducerLocations.Address2", true, DataSourceUpdateMode.OnPropertyChanged));
    ((Control) this.ctlZipCode).DataBindings.Add(new Binding("ZipCodeExtension", (object) this.dsProducer, "tblProducerLocations.ZipPlus", true, DataSourceUpdateMode.OnPropertyChanged));
    ((Control) this.ctlZipCode).Font = new Font("Tahoma", 8f);
    this.ctlZipCode.ISOCountryCode = "";
    this.ctlZipCode.ISOCountryCodeMember = "";
    this.ctlZipCode.ISOCountryList = (object) null;
    this.ctlZipCode.ISOCountryNameMember = "";
    ((Control) this.ctlZipCode).Location = new Point(19, 55);
    this.ctlZipCode.MGAStyle = MGAStyles.Blue;
    ((Control) this.ctlZipCode).Name = "ctlZipCode";
    this.ctlZipCode.Password = "";
    ((Control) this.ctlZipCode).Size = new Size(254, 171);
    this.ctlZipCode.State = "";
    ((Control) this.ctlZipCode).TabIndex = 2;
    this.ctlZipCode.TextAlign = ContentAlignment.MiddleRight;
    this.ctlZipCode.UserID = "";
    this.ctlZipCode.WebserviceUrl = (string) null;
    this.ctlZipCode.ZipCode = "";
    this.ctlZipCode.ZipCodeExtension = "";
    appearance12.BackColorDisabled = Color.Gainsboro;
    appearance12.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.txtFEIN1.Appearance = (AppearanceBase) appearance12;
    ((Control) this.txtFEIN1).DataBindings.Add(new Binding("Text", (object) this.dsProducer, "tblProducerLocations.FEIN", true));
    this.txtFEIN1.EditAs = (EditAsType) 1;
    this.txtFEIN1.InputMask = "##-#######";
    ((Control) this.txtFEIN1).Location = new Point(361, 105);
    this.txtFEIN1.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtFEIN1).Name = "txtFEIN1";
    this.txtFEIN1.NonAutoSizeHeight = 20;
    ((Control) this.txtFEIN1).Size = new Size(72, 21);
    ((Control) this.txtFEIN1).TabIndex = 10;
    this.txtFEIN1.Text = "-";
    ((UltraControlBase) this.txtFEIN1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtFEIN1).UseOsThemes = (DefaultableBoolean) 2;
    this.Label16.AutoSize = true;
    this.Label16.BackColor = Color.Transparent;
    this.Label16.Location = new Point(316, 85);
    this.Label16.Name = "Label16";
    this.Label16.Size = new Size(35, 13);
    this.Label16.TabIndex = 11;
    this.Label16.Text = "Email:";
    this.Label16.TextAlign = ContentAlignment.MiddleRight;
    appearance13.BackColor = Color.White;
    appearance13.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance13.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtWebSite).Appearance = (AppearanceBase) appearance13;
    ((TextEditorControlBase) this.txtWebSite).BackColor = Color.White;
    ((Control) this.txtWebSite).DataBindings.Add(new Binding("Text", (object) this.dsProducer, "tblProducerLocations.WebSite", true));
    ((Control) this.txtWebSite).Location = new Point(361, 57);
    this.txtWebSite.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtWebSite).Name = "txtWebSite";
    ((Control) this.txtWebSite).Size = new Size(184, 20);
    ((Control) this.txtWebSite).TabIndex = 8;
    ((UltraControlBase) this.txtWebSite).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtWebSite).UseOsThemes = (DefaultableBoolean) 2;
    this.Label13.AutoSize = true;
    this.Label13.BackColor = Color.Transparent;
    this.Label13.Location = new Point(319, 109);
    this.Label13.Name = "Label13";
    this.Label13.Size = new Size(34, 13);
    this.Label13.TabIndex = 13;
    this.Label13.Text = "FEIN:";
    this.Label13.TextAlign = ContentAlignment.MiddleRight;
    this.Label8.AutoSize = true;
    this.Label8.BackColor = Color.Transparent;
    this.Label8.Location = new Point(299, 61);
    this.Label8.Name = "Label8";
    this.Label8.Size = new Size(54, 13);
    this.Label8.TabIndex = 9;
    this.Label8.Text = "Web Site:";
    this.Label8.TextAlign = ContentAlignment.MiddleRight;
    this.Label4.AutoSize = true;
    this.Label4.BackColor = Color.Transparent;
    this.Label4.Location = new Point(41, 13);
    this.Label4.Name = "Label4";
    this.Label4.Size = new Size(51, 13);
    this.Label4.TabIndex = 0;
    this.Label4.Text = "Location:";
    this.Label4.TextAlign = ContentAlignment.MiddleRight;
    this.cboProducerType.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboProducerType).DataBindings.Add(new Binding("Value", (object) this.dsProducer, "tblProducerLocations.ProducerTypeID", true));
    ((UltraGridBase) this.cboProducerType).DataSource = (object) this.dsProducer.lstProducerTypes;
    ((UltraDropDownBase) this.cboProducerType).DisplayMember = "Description";
    this.cboProducerType.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboProducerType).Location = new Point(97, 33);
    this.cboProducerType.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboProducerType).Name = "cboProducerType";
    ((Control) this.cboProducerType).Size = new Size(196, 21);
    ((Control) this.cboProducerType).TabIndex = 1;
    ((UltraControlBase) this.cboProducerType).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboProducerType).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboProducerType).ValueMember = "ProducerTypeID";
    this.Label3.AutoSize = true;
    this.Label3.BackColor = Color.Transparent;
    this.Label3.Location = new Point(326, 37);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(29, 13);
    this.Label3.TabIndex = 7;
    this.Label3.Text = "Fax:";
    this.Label3.TextAlign = ContentAlignment.MiddleRight;
    this.Label6.AutoSize = true;
    this.Label6.BackColor = Color.Transparent;
    this.Label6.Location = new Point(57, 37);
    this.Label6.Name = "Label6";
    this.Label6.Size = new Size(35, 13);
    this.Label6.TabIndex = 2;
    this.Label6.Text = "Type:";
    this.Label6.TextAlign = ContentAlignment.MiddleRight;
    this.lblPhone.AutoSize = true;
    this.lblPhone.BackColor = Color.Transparent;
    this.lblPhone.Location = new Point(314, 13);
    this.lblPhone.Name = "lblPhone";
    this.lblPhone.Size = new Size(41, 13);
    this.lblPhone.TabIndex = 5;
    this.lblPhone.Text = "Phone:";
    this.lblPhone.TextAlign = ContentAlignment.MiddleRight;
    this.Label7.AutoSize = true;
    this.Label7.BackColor = Color.Transparent;
    this.Label7.Location = new Point(305, 184);
    this.Label7.Name = "Label7";
    this.Label7.Size = new Size(50, 13);
    this.Label7.TabIndex = 19;
    this.Label7.Text = "Delivery:";
    this.Label7.TextAlign = ContentAlignment.MiddleRight;
    appearance14.BackColor = Color.White;
    appearance14.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance14.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtLocation).Appearance = (AppearanceBase) appearance14;
    ((TextEditorControlBase) this.txtLocation).BackColor = Color.White;
    ((Control) this.txtLocation).DataBindings.Add(new Binding("Text", (object) this.dsProducer, "tblProducerLocations.Name", true));
    ((Control) this.txtLocation).Location = new Point(97, 9);
    this.txtLocation.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtLocation).Name = "txtLocation";
    ((Control) this.txtLocation).Size = new Size(196, 20);
    ((Control) this.txtLocation).TabIndex = 0;
    ((UltraControlBase) this.txtLocation).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtLocation).UseOsThemes = (DefaultableBoolean) 2;
    this.Label9.AutoSize = true;
    this.Label9.BackColor = Color.Transparent;
    this.Label9.Location = new Point(651, 13);
    this.Label9.Name = "Label9";
    this.Label9.Size = new Size(42, 13);
    this.Label9.TabIndex = 23;
    this.Label9.Text = "Added:";
    this.Label9.TextAlign = ContentAlignment.MiddleRight;
    appearance15.BackColor = Color.Transparent;
    appearance15.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance15).TextHAlignAsString = "Left";
    ((AppearanceBase) appearance15).TextVAlignAsString = "Middle";
    ((ControlBase) this.lblAdded).Appearance = (AppearanceBase) appearance15;
    ((ControlBase) this.lblAdded).BackColorInternal = Color.WhiteSmoke;
    this.lblAdded.BorderStyleOuter = (UIElementBorderStyle) 4;
    ((Control) this.lblAdded).DataBindings.Add(new Binding("Text", (object) this.dsProducer, "tblProducerLocations.DateAdded", true));
    ((Control) this.lblAdded).Location = new Point(699, 9);
    ((Control) this.lblAdded).Name = "lblAdded";
    ((Control) this.lblAdded).Size = new Size(124, 21);
    ((Control) this.lblAdded).TabIndex = 17;
    this.Label2.AutoSize = true;
    this.Label2.BackColor = Color.Transparent;
    this.Label2.Location = new Point(272, 134);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(79, 13);
    this.Label2.TabIndex = 15;
    this.Label2.Text = "Location Code:";
    this.Label2.TextAlign = ContentAlignment.MiddleRight;
    appearance16.BackColor = Color.White;
    appearance16.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance16.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtCode).Appearance = (AppearanceBase) appearance16;
    ((TextEditorControlBase) this.txtCode).BackColor = Color.White;
    ((Control) this.txtCode).DataBindings.Add(new Binding("Text", (object) this.dsProducer, "tblProducerLocations.LocationCode", true));
    ((Control) this.txtCode).Location = new Point(361, 130);
    this.txtCode.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtCode).Name = "txtCode";
    ((Control) this.txtCode).Size = new Size(106, 20);
    ((Control) this.txtCode).TabIndex = 11;
    ((UltraControlBase) this.txtCode).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtCode).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.lblRecords).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance17.BackColor = Color.Transparent;
    appearance17.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance17).TextHAlignAsString = "Center";
    ((AppearanceBase) appearance17).TextVAlignAsString = "Middle";
    ((ControlBase) this.lblRecords).Appearance = (AppearanceBase) appearance17;
    ((ControlBase) this.lblRecords).BackColorInternal = Color.WhiteSmoke;
    this.lblRecords.BorderStyleOuter = (UIElementBorderStyle) 4;
    ((Control) this.lblRecords).Location = new Point(579, 313);
    ((Control) this.lblRecords).Name = "lblRecords";
    ((Control) this.lblRecords).Size = new Size(80 /*0x50*/, 16 /*0x10*/);
    ((Control) this.lblRecords).TabIndex = 32 /*0x20*/;
    ((Control) this.lblRecords).Tag = (object) "KeepEnabled";
    ((UltraControlBase) this.lblRecords).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.lblRecords).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.btnDelete).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance18.BackColor = Color.Gainsboro;
    appearance18.BackColor2 = Color.White;
    appearance18.BackGradientStyle = (GradientStyle) 2;
    appearance18.BorderColor = Color.Gray;
    appearance18.ImageHAlign = (HAlign) 1;
    ((ControlBase) this.btnDelete).Appearance = (AppearanceBase) appearance18;
    ((Control) this.btnDelete).Location = new Point(751, 304);
    ((Control) this.btnDelete).Name = "btnDelete";
    ((Control) this.btnDelete).Size = new Size(122, 31 /*0x1F*/);
    ((Control) this.btnDelete).TabIndex = 34;
    ((ControlBase) this.btnDelete).Text = "Delete Location";
    this.ToolTip.SetToolTip((Control) this.btnDelete, "Delete This Location");
    this.btnDelete.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.btnPrev).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance19.BackColor = Color.FromArgb(248, 248, 248);
    appearance19.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance19.BackGradientStyle = (GradientStyle) 2;
    appearance19.BorderColor = Color.DarkGray;
    appearance19.ImageHAlign = (HAlign) 2;
    appearance19.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnPrev).Appearance = (AppearanceBase) appearance19;
    ((ControlBase) this.btnPrev).BackColorInternal = Color.WhiteSmoke;
    ((Control) this.btnPrev).Location = new Point(547, 307);
    ((Control) this.btnPrev).Name = "btnPrev";
    ((Control) this.btnPrev).Size = new Size(28, 28);
    ((Control) this.btnPrev).TabIndex = 36;
    ((Control) this.btnPrev).Tag = (object) "KeepEnabled";
    this.ToolTip.SetToolTip((Control) this.btnPrev, "Previous Location");
    this.btnPrev.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.btnNext).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance20.BackColor = Color.FromArgb(248, 248, 248);
    appearance20.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance20.BackGradientStyle = (GradientStyle) 2;
    appearance20.BorderColor = Color.DarkGray;
    appearance20.ImageHAlign = (HAlign) 2;
    appearance20.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnNext).Appearance = (AppearanceBase) appearance20;
    ((ControlBase) this.btnNext).BackColorInternal = Color.WhiteSmoke;
    ((Control) this.btnNext).Location = new Point(667, 307);
    ((Control) this.btnNext).Name = "btnNext";
    ((Control) this.btnNext).Size = new Size(28, 28);
    ((Control) this.btnNext).TabIndex = 37;
    ((Control) this.btnNext).Tag = (object) "KeepEnabled";
    this.ToolTip.SetToolTip((Control) this.btnNext, "Next Location");
    this.btnNext.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.btnLast).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance21.BackColor = Color.FromArgb(248, 248, 248);
    appearance21.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance21.BackGradientStyle = (GradientStyle) 2;
    appearance21.BorderColor = Color.DarkGray;
    appearance21.ImageHAlign = (HAlign) 2;
    appearance21.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnLast).Appearance = (AppearanceBase) appearance21;
    ((Control) this.btnLast).Location = new Point(699, 307);
    ((Control) this.btnLast).Name = "btnLast";
    ((Control) this.btnLast).Size = new Size(28, 28);
    ((Control) this.btnLast).TabIndex = 38;
    ((Control) this.btnLast).Tag = (object) "KeepEnabled";
    this.ToolTip.SetToolTip((Control) this.btnLast, "Last Location");
    this.btnLast.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.btnFirst).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance22.BackColor = Color.FromArgb(248, 248, 248);
    appearance22.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance22.BackGradientStyle = (GradientStyle) 2;
    appearance22.BorderColor = Color.DarkGray;
    appearance22.ImageHAlign = (HAlign) 2;
    appearance22.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnFirst).Appearance = (AppearanceBase) appearance22;
    ((Control) this.btnFirst).Location = new Point(515, 307);
    ((Control) this.btnFirst).Name = "btnFirst";
    ((Control) this.btnFirst).Size = new Size(28, 28);
    ((Control) this.btnFirst).TabIndex = 35;
    ((Control) this.btnFirst).Tag = (object) "KeepEnabled";
    this.ToolTip.SetToolTip((Control) this.btnFirst, "First Location");
    this.btnFirst.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.btnNewProducerLocation).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance23.ImageHAlign = (HAlign) 1;
    ((ControlBase) this.btnNewProducerLocation).Appearance = (AppearanceBase) appearance23;
    ((Control) this.btnNewProducerLocation).Location = new Point(751, 267);
    ((Control) this.btnNewProducerLocation).Name = "btnNewProducerLocation";
    ((Control) this.btnNewProducerLocation).Size = new Size(122, 31 /*0x1F*/);
    ((Control) this.btnNewProducerLocation).TabIndex = 33;
    ((ControlBase) this.btnNewProducerLocation).Text = "New Location";
    this.ToolTip.SetToolTip((Control) this.btnNewProducerLocation, "New Producer Location");
    this.btnNewProducerLocation.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.btnQueryDates);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.Label37);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.Label36);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.dtEndDate);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.dtStartDate);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.lblNumSubmitted);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.Label34);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.lblNumDeclined);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.Label33);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.lblNumBind);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.Label32);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.lblNumQuoted);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.Label30);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.lblLoading);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.cboCompanyLines);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.Label22);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.chartStats);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.lblTotalPremium);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.Label17);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.lblRenewalRetention);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.Label18);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.lblDeclineRatio);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.Label19);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.lblBindRatio);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.Label20);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.lblQuoteRatio);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.Label21);
    ((Control) this.UltraTabPageControl2).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabPageControl2).Name = "UltraTabPageControl2";
    ((Control) this.UltraTabPageControl2).Size = new Size(876, 341);
    this.btnQueryDates.Image = (Image) componentResourceManager.GetObject("btnQueryDates.Image");
    this.btnQueryDates.Location = new Point(219, 228);
    this.btnQueryDates.Name = "btnQueryDates";
    this.btnQueryDates.Size = new Size(24, 23);
    this.btnQueryDates.TabIndex = 488;
    this.btnQueryDates.UseVisualStyleBackColor = true;
    this.Label37.AutoSize = true;
    this.Label37.BackColor = Color.Transparent;
    this.Label37.Location = new Point(14, 257);
    this.Label37.Name = "Label37";
    this.Label37.Size = new Size(55, 13);
    this.Label37.TabIndex = 487;
    this.Label37.Text = "End Date:";
    this.Label37.TextAlign = ContentAlignment.MiddleLeft;
    this.Label36.AutoSize = true;
    this.Label36.BackColor = Color.Transparent;
    this.Label36.Location = new Point(14, 232);
    this.Label36.Name = "Label36";
    this.Label36.Size = new Size(61, 13);
    this.Label36.TabIndex = 486;
    this.Label36.Text = "Start Date:";
    this.Label36.TextAlign = ContentAlignment.MiddleLeft;
    appearance24.BackColor = Color.White;
    appearance24.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dtEndDate.Appearance = (AppearanceBase) appearance24;
    this.dtEndDate.BackColor = Color.White;
    appearance25.AlphaLevel = (short) 14;
    appearance25.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance25.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance25.BackColorAlpha = (Alpha) 2;
    appearance25.BackGradientAlignment = (GradientAlignment) 4;
    appearance25.BackGradientStyle = (GradientStyle) 5;
    appearance25.BorderAlpha = (Alpha) 1;
    appearance25.BorderColor = Color.FromArgb(78, 122, 171);
    appearance25.ForeColor = Color.FromArgb(49, 85, 153);
    appearance25.ForegroundAlpha = (Alpha) 2;
    this.dtEndDate.ButtonAppearance = (AppearanceBase) appearance25;
    this.dtEndDate.DateTime = new DateTime(1753, 1, 1, 0, 0, 0, 0);
    ((Control) this.dtEndDate).Location = new Point(123, 253);
    this.dtEndDate.MGAStyle = MGAStyles.Blue;
    ((Control) this.dtEndDate).Name = "dtEndDate";
    ((Control) this.dtEndDate).Size = new Size(90, 20);
    ((Control) this.dtEndDate).TabIndex = 485;
    ((UltraControlBase) this.dtEndDate).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtEndDate).UseOsThemes = (DefaultableBoolean) 2;
    this.dtEndDate.Value = (object) null;
    appearance26.BackColor = Color.White;
    appearance26.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dtStartDate.Appearance = (AppearanceBase) appearance26;
    this.dtStartDate.BackColor = Color.White;
    appearance27.AlphaLevel = (short) 14;
    appearance27.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance27.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance27.BackColorAlpha = (Alpha) 2;
    appearance27.BackGradientAlignment = (GradientAlignment) 4;
    appearance27.BackGradientStyle = (GradientStyle) 5;
    appearance27.BorderAlpha = (Alpha) 1;
    appearance27.BorderColor = Color.FromArgb(78, 122, 171);
    appearance27.ForeColor = Color.FromArgb(49, 85, 153);
    appearance27.ForegroundAlpha = (Alpha) 2;
    this.dtStartDate.ButtonAppearance = (AppearanceBase) appearance27;
    this.dtStartDate.DateTime = new DateTime(1753, 1, 1, 0, 0, 0, 0);
    ((Control) this.dtStartDate).Location = new Point(122, 228);
    this.dtStartDate.MGAStyle = MGAStyles.Blue;
    ((Control) this.dtStartDate).Name = "dtStartDate";
    ((Control) this.dtStartDate).Size = new Size(91, 20);
    ((Control) this.dtStartDate).TabIndex = 484;
    ((UltraControlBase) this.dtStartDate).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtStartDate).UseOsThemes = (DefaultableBoolean) 2;
    this.dtStartDate.Value = (object) null;
    appearance28.BackColor = Color.Transparent;
    appearance28.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((ControlBase) this.lblNumSubmitted).Appearance = (AppearanceBase) appearance28;
    ((ControlBase) this.lblNumSubmitted).BackColorInternal = Color.WhiteSmoke;
    this.lblNumSubmitted.BorderStyleOuter = (UIElementBorderStyle) 4;
    ((Control) this.lblNumSubmitted).Location = new Point(123, 3);
    ((Control) this.lblNumSubmitted).Name = "lblNumSubmitted";
    ((Control) this.lblNumSubmitted).Size = new Size(72, 20);
    ((Control) this.lblNumSubmitted).TabIndex = 42;
    this.Label34.AutoSize = true;
    this.Label34.BackColor = Color.Transparent;
    this.Label34.Location = new Point(14, 7);
    this.Label34.Name = "Label34";
    this.Label34.Size = new Size(70, 13);
    this.Label34.TabIndex = 41;
    this.Label34.Text = "# Submitted:";
    this.Label34.TextAlign = ContentAlignment.MiddleLeft;
    appearance29.BackColor = Color.Transparent;
    appearance29.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((ControlBase) this.lblNumDeclined).Appearance = (AppearanceBase) appearance29;
    ((ControlBase) this.lblNumDeclined).BackColorInternal = Color.WhiteSmoke;
    this.lblNumDeclined.BorderStyleOuter = (UIElementBorderStyle) 4;
    ((Control) this.lblNumDeclined).Location = new Point(123, 78);
    ((Control) this.lblNumDeclined).Name = "lblNumDeclined";
    ((Control) this.lblNumDeclined).Size = new Size(72, 20);
    ((Control) this.lblNumDeclined).TabIndex = 39;
    this.Label33.AutoSize = true;
    this.Label33.BackColor = Color.Transparent;
    this.Label33.Location = new Point(14, 82);
    this.Label33.Name = "Label33";
    this.Label33.Size = new Size(62, 13);
    this.Label33.TabIndex = 40;
    this.Label33.Text = "# Declined:";
    this.Label33.TextAlign = ContentAlignment.MiddleLeft;
    appearance30.BackColor = Color.Transparent;
    appearance30.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((ControlBase) this.lblNumBind).Appearance = (AppearanceBase) appearance30;
    ((ControlBase) this.lblNumBind).BackColorInternal = Color.WhiteSmoke;
    this.lblNumBind.BorderStyleOuter = (UIElementBorderStyle) 4;
    ((Control) this.lblNumBind).Location = new Point(123, 53);
    ((Control) this.lblNumBind).Name = "lblNumBind";
    ((Control) this.lblNumBind).Size = new Size(72, 20);
    ((Control) this.lblNumBind).TabIndex = 38;
    this.Label32.AutoSize = true;
    this.Label32.BackColor = Color.Transparent;
    this.Label32.Location = new Point(14, 57);
    this.Label32.Name = "Label32";
    this.Label32.Size = new Size(52, 13);
    this.Label32.TabIndex = 37;
    this.Label32.Text = "# Bound:";
    this.Label32.TextAlign = ContentAlignment.MiddleLeft;
    appearance31.BackColor = Color.Transparent;
    appearance31.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((ControlBase) this.lblNumQuoted).Appearance = (AppearanceBase) appearance31;
    ((ControlBase) this.lblNumQuoted).BackColorInternal = Color.WhiteSmoke;
    this.lblNumQuoted.BorderStyleOuter = (UIElementBorderStyle) 4;
    ((Control) this.lblNumQuoted).Location = new Point(123, 28);
    ((Control) this.lblNumQuoted).Name = "lblNumQuoted";
    ((Control) this.lblNumQuoted).Size = new Size(72, 20);
    ((Control) this.lblNumQuoted).TabIndex = 36;
    this.Label30.AutoSize = true;
    this.Label30.BackColor = Color.Transparent;
    this.Label30.Location = new Point(14, 32 /*0x20*/);
    this.Label30.Name = "Label30";
    this.Label30.Size = new Size(58, 13);
    this.Label30.TabIndex = 35;
    this.Label30.Text = "# Quoted:";
    this.Label30.TextAlign = ContentAlignment.MiddleLeft;
    this.lblLoading.AutoSize = true;
    this.lblLoading.BackColor = Color.Transparent;
    this.lblLoading.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblLoading.Location = new Point(262, 15);
    this.lblLoading.Name = "lblLoading";
    this.lblLoading.Size = new Size(170, 14);
    this.lblLoading.TabIndex = 28;
    this.lblLoading.Text = "Loading Producer Statistics ...";
    this.cboCompanyLines.BorderStyle = (UIElementBorderStyle) 4;
    this.cboCompanyLines.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboCompanyLines).DropDownWidth = 600;
    ((Control) this.cboCompanyLines).Location = new Point(123, 278);
    this.cboCompanyLines.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboCompanyLines).Name = "cboCompanyLines";
    ((Control) this.cboCompanyLines).Size = new Size(333, 21);
    ((Control) this.cboCompanyLines).TabIndex = 11;
    ((UltraControlBase) this.cboCompanyLines).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboCompanyLines).UseOsThemes = (DefaultableBoolean) 2;
    this.Label22.AutoSize = true;
    this.Label22.BackColor = Color.Transparent;
    this.Label22.Location = new Point(14, 282);
    this.Label22.Name = "Label22";
    this.Label22.Size = new Size(79, 13);
    this.Label22.TabIndex = 10;
    this.Label22.Text = "Company/Line:";
    this.Label22.TextAlign = ContentAlignment.MiddleLeft;
    this.chartStats.Axis.BackColor = Color.FromArgb((int) byte.MaxValue, 248, 220);
    paintElement.ElementType = (PaintElementType) 0;
    paintElement.Fill = Color.FromArgb((int) byte.MaxValue, 248, 220);
    this.chartStats.Axis.PE = paintElement;
    ((AxisLabelAppearanceBase) this.chartStats.Axis.X.Labels).HorizontalAlign = StringAlignment.Near;
    this.chartStats.Axis.X.Labels.ItemFormatString = "<ITEM_LABEL>";
    ((AxisLabelAppearanceBase) this.chartStats.Axis.X.Labels).Orientation = (TextOrientation) 0;
    ((AxisLabelAppearanceBase) this.chartStats.Axis.X.Labels.SeriesLabels).HorizontalAlign = StringAlignment.Near;
    ((AxisLabelAppearanceBase) this.chartStats.Axis.X.Labels.SeriesLabels).Orientation = (TextOrientation) 2;
    ((AxisLabelAppearanceBase) this.chartStats.Axis.X.Labels.SeriesLabels).VerticalAlign = StringAlignment.Center;
    ((AxisLabelAppearanceBase) this.chartStats.Axis.X.Labels.SeriesLabels).Visible = false;
    ((AxisLabelAppearanceBase) this.chartStats.Axis.X.Labels).VerticalAlign = StringAlignment.Center;
    ((AxisLabelAppearanceBase) this.chartStats.Axis.X.Labels).Visible = true;
    this.chartStats.Axis.X.MajorGridLines.AlphaLevel = byte.MaxValue;
    this.chartStats.Axis.X.MajorGridLines.Color = Color.Gainsboro;
    this.chartStats.Axis.X.MajorGridLines.DrawStyle = (LineDrawStyle) 4;
    this.chartStats.Axis.X.MajorGridLines.Visible = true;
    this.chartStats.Axis.X.MinorGridLines.AlphaLevel = byte.MaxValue;
    this.chartStats.Axis.X.MinorGridLines.Color = Color.LightGray;
    this.chartStats.Axis.X.MinorGridLines.DrawStyle = (LineDrawStyle) 4;
    this.chartStats.Axis.X.MinorGridLines.Visible = false;
    this.chartStats.Axis.X.Visible = true;
    ((AxisLabelAppearanceBase) this.chartStats.Axis.X2.Labels).HorizontalAlign = StringAlignment.Far;
    this.chartStats.Axis.X2.Labels.ItemFormatString = "<ITEM_LABEL>";
    ((AxisLabelAppearanceBase) this.chartStats.Axis.X2.Labels).Orientation = (TextOrientation) 0;
    ((AxisLabelAppearanceBase) this.chartStats.Axis.X2.Labels.SeriesLabels).HorizontalAlign = StringAlignment.Near;
    ((AxisLabelAppearanceBase) this.chartStats.Axis.X2.Labels.SeriesLabels).Orientation = (TextOrientation) 2;
    ((AxisLabelAppearanceBase) this.chartStats.Axis.X2.Labels.SeriesLabels).VerticalAlign = StringAlignment.Center;
    ((AxisLabelAppearanceBase) this.chartStats.Axis.X2.Labels.SeriesLabels).Visible = true;
    ((AxisLabelAppearanceBase) this.chartStats.Axis.X2.Labels).VerticalAlign = StringAlignment.Center;
    ((AxisLabelAppearanceBase) this.chartStats.Axis.X2.Labels).Visible = false;
    this.chartStats.Axis.X2.MajorGridLines.AlphaLevel = byte.MaxValue;
    this.chartStats.Axis.X2.MajorGridLines.Color = Color.Gainsboro;
    this.chartStats.Axis.X2.MajorGridLines.DrawStyle = (LineDrawStyle) 4;
    this.chartStats.Axis.X2.MajorGridLines.Visible = true;
    this.chartStats.Axis.X2.MinorGridLines.AlphaLevel = byte.MaxValue;
    this.chartStats.Axis.X2.MinorGridLines.Color = Color.LightGray;
    this.chartStats.Axis.X2.MinorGridLines.DrawStyle = (LineDrawStyle) 4;
    this.chartStats.Axis.X2.MinorGridLines.Visible = false;
    this.chartStats.Axis.X2.Visible = false;
    ((AxisLabelAppearanceBase) this.chartStats.Axis.Y.Labels).HorizontalAlign = StringAlignment.Far;
    this.chartStats.Axis.Y.Labels.ItemFormatString = "<DATA_VALUE:00>";
    ((AxisLabelAppearanceBase) this.chartStats.Axis.Y.Labels).Orientation = (TextOrientation) 2;
    ((AxisLabelAppearanceBase) this.chartStats.Axis.Y.Labels.SeriesLabels).HorizontalAlign = StringAlignment.Center;
    ((AxisLabelAppearanceBase) this.chartStats.Axis.Y.Labels.SeriesLabels).Orientation = (TextOrientation) 0;
    ((AxisLabelAppearanceBase) this.chartStats.Axis.Y.Labels.SeriesLabels).VerticalAlign = StringAlignment.Center;
    ((AxisLabelAppearanceBase) this.chartStats.Axis.Y.Labels.SeriesLabels).Visible = true;
    ((AxisLabelAppearanceBase) this.chartStats.Axis.Y.Labels).VerticalAlign = StringAlignment.Center;
    ((AxisLabelAppearanceBase) this.chartStats.Axis.Y.Labels).Visible = true;
    this.chartStats.Axis.Y.MajorGridLines.AlphaLevel = byte.MaxValue;
    this.chartStats.Axis.Y.MajorGridLines.Color = Color.Gainsboro;
    this.chartStats.Axis.Y.MajorGridLines.DrawStyle = (LineDrawStyle) 4;
    this.chartStats.Axis.Y.MajorGridLines.Visible = true;
    this.chartStats.Axis.Y.MinorGridLines.AlphaLevel = byte.MaxValue;
    this.chartStats.Axis.Y.MinorGridLines.Color = Color.LightGray;
    this.chartStats.Axis.Y.MinorGridLines.DrawStyle = (LineDrawStyle) 4;
    this.chartStats.Axis.Y.MinorGridLines.Visible = false;
    this.chartStats.Axis.Y.Visible = true;
    ((AxisLabelAppearanceBase) this.chartStats.Axis.Y2.Labels).HorizontalAlign = StringAlignment.Near;
    this.chartStats.Axis.Y2.Labels.ItemFormatString = "<DATA_VALUE:00.00>";
    ((AxisLabelAppearanceBase) this.chartStats.Axis.Y2.Labels).Orientation = (TextOrientation) 2;
    ((AxisLabelAppearanceBase) this.chartStats.Axis.Y2.Labels.SeriesLabels).HorizontalAlign = StringAlignment.Near;
    ((AxisLabelAppearanceBase) this.chartStats.Axis.Y2.Labels.SeriesLabels).Orientation = (TextOrientation) 0;
    ((AxisLabelAppearanceBase) this.chartStats.Axis.Y2.Labels.SeriesLabels).VerticalAlign = StringAlignment.Center;
    ((AxisLabelAppearanceBase) this.chartStats.Axis.Y2.Labels.SeriesLabels).Visible = true;
    ((AxisLabelAppearanceBase) this.chartStats.Axis.Y2.Labels).VerticalAlign = StringAlignment.Center;
    ((AxisLabelAppearanceBase) this.chartStats.Axis.Y2.Labels).Visible = false;
    this.chartStats.Axis.Y2.MajorGridLines.AlphaLevel = byte.MaxValue;
    this.chartStats.Axis.Y2.MajorGridLines.Color = Color.Gainsboro;
    this.chartStats.Axis.Y2.MajorGridLines.DrawStyle = (LineDrawStyle) 4;
    this.chartStats.Axis.Y2.MajorGridLines.Visible = true;
    this.chartStats.Axis.Y2.MinorGridLines.AlphaLevel = byte.MaxValue;
    this.chartStats.Axis.Y2.MinorGridLines.Color = Color.LightGray;
    this.chartStats.Axis.Y2.MinorGridLines.DrawStyle = (LineDrawStyle) 4;
    this.chartStats.Axis.Y2.MinorGridLines.Visible = false;
    this.chartStats.Axis.Y2.Visible = false;
    ((AxisLabelAppearanceBase) this.chartStats.Axis.Z.Labels).HorizontalAlign = StringAlignment.Near;
    this.chartStats.Axis.Z.Labels.ItemFormatString = "";
    ((AxisLabelAppearanceBase) this.chartStats.Axis.Z.Labels).Orientation = (TextOrientation) 2;
    ((AxisLabelAppearanceBase) this.chartStats.Axis.Z.Labels.SeriesLabels).HorizontalAlign = StringAlignment.Near;
    ((AxisLabelAppearanceBase) this.chartStats.Axis.Z.Labels.SeriesLabels).Orientation = (TextOrientation) 2;
    ((AxisLabelAppearanceBase) this.chartStats.Axis.Z.Labels.SeriesLabels).VerticalAlign = StringAlignment.Center;
    ((AxisLabelAppearanceBase) this.chartStats.Axis.Z.Labels.SeriesLabels).Visible = true;
    ((AxisLabelAppearanceBase) this.chartStats.Axis.Z.Labels).VerticalAlign = StringAlignment.Center;
    ((AxisLabelAppearanceBase) this.chartStats.Axis.Z.Labels).Visible = true;
    this.chartStats.Axis.Z.MajorGridLines.AlphaLevel = byte.MaxValue;
    this.chartStats.Axis.Z.MajorGridLines.Color = Color.Gainsboro;
    this.chartStats.Axis.Z.MajorGridLines.DrawStyle = (LineDrawStyle) 4;
    this.chartStats.Axis.Z.MajorGridLines.Visible = true;
    this.chartStats.Axis.Z.MinorGridLines.AlphaLevel = byte.MaxValue;
    this.chartStats.Axis.Z.MinorGridLines.Color = Color.LightGray;
    this.chartStats.Axis.Z.MinorGridLines.DrawStyle = (LineDrawStyle) 4;
    this.chartStats.Axis.Z.MinorGridLines.Visible = false;
    this.chartStats.Axis.Z.Visible = false;
    ((AxisLabelAppearanceBase) this.chartStats.Axis.Z2.Labels).HorizontalAlign = StringAlignment.Near;
    this.chartStats.Axis.Z2.Labels.ItemFormatString = "";
    ((AxisLabelAppearanceBase) this.chartStats.Axis.Z2.Labels).Orientation = (TextOrientation) 2;
    ((AxisLabelAppearanceBase) this.chartStats.Axis.Z2.Labels.SeriesLabels).HorizontalAlign = StringAlignment.Near;
    ((AxisLabelAppearanceBase) this.chartStats.Axis.Z2.Labels.SeriesLabels).Orientation = (TextOrientation) 2;
    ((AxisLabelAppearanceBase) this.chartStats.Axis.Z2.Labels.SeriesLabels).VerticalAlign = StringAlignment.Center;
    ((AxisLabelAppearanceBase) this.chartStats.Axis.Z2.Labels.SeriesLabels).Visible = true;
    ((AxisLabelAppearanceBase) this.chartStats.Axis.Z2.Labels).VerticalAlign = StringAlignment.Center;
    ((AxisLabelAppearanceBase) this.chartStats.Axis.Z2.Labels).Visible = false;
    this.chartStats.Axis.Z2.MajorGridLines.AlphaLevel = byte.MaxValue;
    this.chartStats.Axis.Z2.MajorGridLines.Color = Color.Gainsboro;
    this.chartStats.Axis.Z2.MajorGridLines.DrawStyle = (LineDrawStyle) 4;
    this.chartStats.Axis.Z2.MajorGridLines.Visible = true;
    this.chartStats.Axis.Z2.MinorGridLines.AlphaLevel = byte.MaxValue;
    this.chartStats.Axis.Z2.MinorGridLines.Color = Color.LightGray;
    this.chartStats.Axis.Z2.MinorGridLines.DrawStyle = (LineDrawStyle) 4;
    this.chartStats.Axis.Z2.MinorGridLines.Visible = false;
    this.chartStats.Axis.Z2.Visible = false;
    this.chartStats.BackgroundImageLayout = ImageLayout.Center;
    this.chartStats.Border.Color = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.chartStats.ColorModel.AlphaLevel = (byte) 150;
    this.chartStats.Data.EmptyStyle.LineStyle.DrawStyle = (LineDrawStyle) 1;
    this.chartStats.Legend.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.chartStats.Legend.SpanPercentage = 20;
    this.chartStats.Legend.Visible = true;
    ((Control) this.chartStats).Location = new Point(248, 8);
    ((Control) this.chartStats).Name = "chartStats";
    ((Control) this.chartStats).Size = new Size(475, 204);
    this.chartStats.TabIndex = 20;
    this.chartStats.TitleBottom.Visible = false;
    this.chartStats.TitleTop.Text = "Producer Statistics <TODAY_DATE:MM/dd/yy>";
    appearance32.BackColor = Color.Transparent;
    appearance32.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((ControlBase) this.lblTotalPremium).Appearance = (AppearanceBase) appearance32;
    ((ControlBase) this.lblTotalPremium).BackColorInternal = Color.WhiteSmoke;
    this.lblTotalPremium.BorderStyleOuter = (UIElementBorderStyle) 4;
    ((Control) this.lblTotalPremium).Location = new Point(123, 203);
    ((Control) this.lblTotalPremium).Name = "lblTotalPremium";
    ((Control) this.lblTotalPremium).Size = new Size(120, 20);
    ((Control) this.lblTotalPremium).TabIndex = 4;
    this.Label17.AutoSize = true;
    this.Label17.BackColor = Color.Transparent;
    this.Label17.Location = new Point(14, 207);
    this.Label17.Name = "Label17";
    this.Label17.Size = new Size(78, 13);
    this.Label17.TabIndex = 8;
    this.Label17.Text = "Total Premium:";
    this.Label17.TextAlign = ContentAlignment.MiddleLeft;
    appearance33.BackColor = Color.Transparent;
    appearance33.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((ControlBase) this.lblRenewalRetention).Appearance = (AppearanceBase) appearance33;
    ((ControlBase) this.lblRenewalRetention).BackColorInternal = Color.WhiteSmoke;
    this.lblRenewalRetention.BorderStyleOuter = (UIElementBorderStyle) 4;
    ((Control) this.lblRenewalRetention).Location = new Point(123, 178);
    ((Control) this.lblRenewalRetention).Name = "lblRenewalRetention";
    ((Control) this.lblRenewalRetention).Size = new Size(72, 20);
    ((Control) this.lblRenewalRetention).TabIndex = 3;
    this.Label18.AutoSize = true;
    this.Label18.BackColor = Color.Transparent;
    this.Label18.Location = new Point(14, 182);
    this.Label18.Name = "Label18";
    this.Label18.Size = new Size(102, 13);
    this.Label18.TabIndex = 6;
    this.Label18.Text = "Renewal Retention:";
    this.Label18.TextAlign = ContentAlignment.MiddleLeft;
    appearance34.BackColor = Color.Transparent;
    appearance34.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((ControlBase) this.lblDeclineRatio).Appearance = (AppearanceBase) appearance34;
    ((ControlBase) this.lblDeclineRatio).BackColorInternal = Color.WhiteSmoke;
    this.lblDeclineRatio.BorderStyleOuter = (UIElementBorderStyle) 4;
    ((Control) this.lblDeclineRatio).Location = new Point(123, 153);
    ((Control) this.lblDeclineRatio).Name = "lblDeclineRatio";
    ((Control) this.lblDeclineRatio).Size = new Size(72, 20);
    ((Control) this.lblDeclineRatio).TabIndex = 2;
    this.Label19.AutoSize = true;
    this.Label19.BackColor = Color.Transparent;
    this.Label19.Location = new Point(14, 157);
    this.Label19.Name = "Label19";
    this.Label19.Size = new Size(73, 13);
    this.Label19.TabIndex = 4;
    this.Label19.Text = "Decline Ratio:";
    this.Label19.TextAlign = ContentAlignment.MiddleLeft;
    appearance35.BackColor = Color.Transparent;
    appearance35.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((ControlBase) this.lblBindRatio).Appearance = (AppearanceBase) appearance35;
    ((ControlBase) this.lblBindRatio).BackColorInternal = Color.WhiteSmoke;
    this.lblBindRatio.BorderStyleOuter = (UIElementBorderStyle) 4;
    ((Control) this.lblBindRatio).Location = new Point(123, 128 /*0x80*/);
    ((Control) this.lblBindRatio).Name = "lblBindRatio";
    ((Control) this.lblBindRatio).Size = new Size(72, 20);
    ((Control) this.lblBindRatio).TabIndex = 1;
    this.Label20.AutoSize = true;
    this.Label20.BackColor = Color.Transparent;
    this.Label20.Location = new Point(14, 132);
    this.Label20.Name = "Label20";
    this.Label20.Size = new Size(59, 13);
    this.Label20.TabIndex = 2;
    this.Label20.Text = "Bind Ratio:";
    this.Label20.TextAlign = ContentAlignment.MiddleLeft;
    appearance36.BackColor = Color.Transparent;
    appearance36.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((ControlBase) this.lblQuoteRatio).Appearance = (AppearanceBase) appearance36;
    ((ControlBase) this.lblQuoteRatio).BackColorInternal = Color.WhiteSmoke;
    this.lblQuoteRatio.BorderStyleOuter = (UIElementBorderStyle) 4;
    ((Control) this.lblQuoteRatio).Location = new Point(123, 103);
    ((Control) this.lblQuoteRatio).Name = "lblQuoteRatio";
    ((Control) this.lblQuoteRatio).Size = new Size(72, 20);
    ((Control) this.lblQuoteRatio).TabIndex = 0;
    this.Label21.AutoSize = true;
    this.Label21.BackColor = Color.Transparent;
    this.Label21.Location = new Point(14, 107);
    this.Label21.Name = "Label21";
    this.Label21.Size = new Size(69, 13);
    this.Label21.TabIndex = 0;
    this.Label21.Text = "Quote Ratio:";
    this.Label21.TextAlign = ContentAlignment.MiddleLeft;
    ((Control) this.UltraTabPageControl5).Controls.Add((Control) this.ugPoliciesGrid);
    ((Control) this.UltraTabPageControl5).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabPageControl5).Name = "UltraTabPageControl5";
    ((Control) this.UltraTabPageControl5).Size = new Size(876, 341);
    ((Control) this.ugPoliciesGrid).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraControlBase) this.ugPoliciesGrid).Cursor = Cursors.Hand;
    appearance37.BackColor = Color.White;
    appearance37.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ugPoliciesGrid).DisplayLayout.Appearance = (AppearanceBase) appearance37;
    ((UltraGridBase) this.ugPoliciesGrid).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((UltraGridBase) this.ugPoliciesGrid).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance38.BackColor = Color.LightSteelBlue;
    appearance38.FontData.SizeInPoints = 10f;
    appearance38.ForeColor = Color.Black;
    ((UltraGridBase) this.ugPoliciesGrid).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance38;
    appearance39.BackColor = Color.White;
    appearance39.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance39.ForeColor = Color.Black;
    ((UltraGridBase) this.ugPoliciesGrid).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance39;
    ((UltraGridBase) this.ugPoliciesGrid).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.ugPoliciesGrid).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.ugPoliciesGrid).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    appearance40.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugPoliciesGrid).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance40;
    ((UltraGridBase) this.ugPoliciesGrid).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    appearance41.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ugPoliciesGrid).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance41;
    ((UltraGridBase) this.ugPoliciesGrid).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance42.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ugPoliciesGrid).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance42;
    appearance43.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugPoliciesGrid).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance43;
    ((UltraGridBase) this.ugPoliciesGrid).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance44.BackColor = Color.Transparent;
    appearance44.ForeColor = Color.Black;
    ((UltraGridBase) this.ugPoliciesGrid).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance44;
    ((UltraGridBase) this.ugPoliciesGrid).DisplayLayout.Override.SelectTypeCell = (SelectType) 2;
    scrollBarLook1.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.ugPoliciesGrid).DisplayLayout.ScrollBarLook = scrollBarLook1;
    ((Control) this.ugPoliciesGrid).Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.ugPoliciesGrid).Location = new Point(22, 13);
    ((Control) this.ugPoliciesGrid).Name = "ugPoliciesGrid";
    ((Control) this.ugPoliciesGrid).Size = new Size(832, 241);
    ((Control) this.ugPoliciesGrid).TabIndex = 35;
    ((Control) this.ugPoliciesGrid).Text = "Policies for this Producer Location";
    ((UltraControlBase) this.ugPoliciesGrid).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ugPoliciesGrid).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.grpContactOfac);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.lblCurrentContact);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.btnNewContact);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.btnSelectContact);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.lstContacts);
    ((Control) this.UltraTabPageControl3).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabPageControl3).Name = "UltraTabPageControl3";
    ((Control) this.UltraTabPageControl3).Size = new Size(876, 341);
    this.grpContactOfac.BackColorInternal = Color.FromArgb(240 /*0xF0*/, 247, 253);
    appearance45.BackColor = Color.White;
    appearance45.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.grpContactOfac.ContentAreaAppearance = (AppearanceBase) appearance45;
    ((Control) this.grpContactOfac).Controls.Add((Control) this.lblOfacClearedUser);
    ((Control) this.grpContactOfac).Controls.Add((Control) this.lblOfacClearedDate);
    ((Control) this.grpContactOfac).Controls.Add((Control) this.dtOFACClearedDate);
    ((Control) this.grpContactOfac).Controls.Add((Control) this.chkOFACCleared);
    ((Control) this.grpContactOfac).Controls.Add((Control) this.lblOFACReturnCode);
    ((Control) this.grpContactOfac).Controls.Add((Control) this.lblOFACDate);
    ((Control) this.grpContactOfac).Controls.Add((Control) this.ugOFAC);
    ((Control) this.grpContactOfac).Location = new Point(254, 8);
    ((Control) this.grpContactOfac).Name = "grpContactOfac";
    ((Control) this.grpContactOfac).Size = new Size(619, 210);
    ((Control) this.grpContactOfac).TabIndex = 40;
    this.grpContactOfac.Text = "OFAC";
    this.lblOfacClearedUser.BackColor = Color.Transparent;
    this.lblOfacClearedUser.Location = new Point(288, 185);
    this.lblOfacClearedUser.Name = "lblOfacClearedUser";
    this.lblOfacClearedUser.Size = new Size(181, 13);
    this.lblOfacClearedUser.TabIndex = 149;
    this.lblOfacClearedUser.TextAlign = ContentAlignment.MiddleCenter;
    this.lblOfacClearedDate.AutoSize = true;
    this.lblOfacClearedDate.BackColor = Color.Transparent;
    this.lblOfacClearedDate.Location = new Point(288, 160 /*0xA0*/);
    this.lblOfacClearedDate.Name = "lblOfacClearedDate";
    this.lblOfacClearedDate.Size = new Size(79, 13);
    this.lblOfacClearedDate.TabIndex = 148;
    this.lblOfacClearedDate.Text = "OFAC Cleared:";
    appearance46.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dtOFACClearedDate.Appearance = (AppearanceBase) appearance46;
    appearance47.AlphaLevel = (short) 14;
    appearance47.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance47.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance47.BackColorAlpha = (Alpha) 2;
    appearance47.BackGradientAlignment = (GradientAlignment) 4;
    appearance47.BackGradientStyle = (GradientStyle) 5;
    appearance47.BorderAlpha = (Alpha) 1;
    appearance47.BorderColor = Color.FromArgb(78, 122, 171);
    appearance47.ForeColor = Color.FromArgb(49, 85, 153);
    appearance47.ForegroundAlpha = (Alpha) 2;
    this.dtOFACClearedDate.ButtonAppearance = (AppearanceBase) appearance47;
    this.dtOFACClearedDate.DateTime = new DateTime(1753, 1, 1, 0, 0, 0, 0);
    ((Control) this.dtOFACClearedDate).Location = new Point(373, 156);
    this.dtOFACClearedDate.MGAStyle = MGAStyles.Blue;
    ((Control) this.dtOFACClearedDate).Name = "dtOFACClearedDate";
    ((EditorButtonControlBase) this.dtOFACClearedDate).ReadOnly = true;
    ((Control) this.dtOFACClearedDate).Size = new Size(96 /*0x60*/, 20);
    ((Control) this.dtOFACClearedDate).TabIndex = 147;
    ((UltraControlBase) this.dtOFACClearedDate).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtOFACClearedDate).UseOsThemes = (DefaultableBoolean) 2;
    this.dtOFACClearedDate.Value = (object) null;
    appearance48.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance48.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkOFACCleared).Appearance = (AppearanceBase) appearance48;
    ((UltraToggleEditorBase) this.chkOFACCleared).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkOFACCleared).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkOFACCleared).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkOFACCleared).Location = new Point(203, 158);
    this.chkOFACCleared.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkOFACCleared).Name = "chkOFACCleared";
    ((Control) this.chkOFACCleared).Size = new Size(66, 17);
    ((Control) this.chkOFACCleared).TabIndex = 145;
    ((UltraToggleEditorBase) this.chkOFACCleared).Text = "Cleared";
    ((UltraControlBase) this.chkOFACCleared).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkOFACCleared).UseOsThemes = (DefaultableBoolean) 2;
    this.lblOFACReturnCode.AutoSize = true;
    this.lblOFACReturnCode.BackColor = Color.Transparent;
    this.lblOFACReturnCode.Location = new Point(3, 185);
    this.lblOFACReturnCode.Name = "lblOFACReturnCode";
    this.lblOFACReturnCode.Size = new Size(103, 13);
    this.lblOFACReturnCode.TabIndex = 144 /*0x90*/;
    this.lblOFACReturnCode.Text = "OFAC Return Code:";
    this.lblOFACDate.AutoSize = true;
    this.lblOFACDate.BackColor = Color.Transparent;
    this.lblOFACDate.Location = new Point(3, 156);
    this.lblOFACDate.Name = "lblOFACDate";
    this.lblOFACDate.Size = new Size(65, 13);
    this.lblOFACDate.TabIndex = 143;
    this.lblOFACDate.Text = "OFAC Date:";
    appearance49.BackColor = Color.White;
    appearance49.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ugOFAC).DisplayLayout.Appearance = (AppearanceBase) appearance49;
    ((UltraGridBase) this.ugOFAC).DisplayLayout.AutoFitStyle = (AutoFitStyle) 2;
    ((UltraGridBase) this.ugOFAC).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance50.BackColor = Color.LightSteelBlue;
    appearance50.FontData.SizeInPoints = 10f;
    appearance50.ForeColor = Color.Black;
    ((UltraGridBase) this.ugOFAC).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance50;
    appearance51.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance51.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance51.ForeColor = Color.Black;
    ((UltraGridBase) this.ugOFAC).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance51;
    ((UltraGridBase) this.ugOFAC).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.ugOFAC).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    appearance52.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugOFAC).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance52;
    appearance53.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ugOFAC).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance53;
    ((UltraGridBase) this.ugOFAC).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance54.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ugOFAC).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance54;
    appearance55.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugOFAC).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance55;
    appearance56.BackColor = Color.Transparent;
    appearance56.ForeColor = Color.Black;
    ((UltraGridBase) this.ugOFAC).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance56;
    scrollBarLook2.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.ugOFAC).DisplayLayout.ScrollBarLook = scrollBarLook2;
    ((UltraGridBase) this.ugOFAC).DisplayLayout.Scrollbars = (Scrollbars) 3;
    ((UltraGridBase) this.ugOFAC).DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    ((Control) this.ugOFAC).Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.ugOFAC).Location = new Point(6, 20);
    ((Control) this.ugOFAC).Name = "ugOFAC";
    ((Control) this.ugOFAC).Size = new Size(607, 130);
    ((Control) this.ugOFAC).TabIndex = 142;
    ((Control) this.ugOFAC).Tag = (object) "KeepEnabled";
    ((UltraControlBase) this.ugOFAC).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ugOFAC).UseOsThemes = (DefaultableBoolean) 2;
    this.lblCurrentContact.AutoSize = true;
    this.lblCurrentContact.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblCurrentContact.Location = new Point(19, 221);
    this.lblCurrentContact.Name = "lblCurrentContact";
    this.lblCurrentContact.Size = new Size(107, 13);
    this.lblCurrentContact.TabIndex = 39;
    this.lblCurrentContact.Text = "lblCurrentContact";
    appearance57.ImageHAlign = (HAlign) 2;
    appearance57.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnNewContact).Appearance = (AppearanceBase) appearance57;
    ((Control) this.btnNewContact).Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((ControlBase) this.btnNewContact).ImageSize = new Size(24, 24);
    ((Control) this.btnNewContact).Location = new Point(8, 237);
    ((Control) this.btnNewContact).Name = "btnNewContact";
    ((Control) this.btnNewContact).Size = new Size(40, 40);
    ((Control) this.btnNewContact).TabIndex = 1;
    ((Control) this.btnNewContact).Tag = (object) "KeepEnabled";
    this.ToolTip.SetToolTip((Control) this.btnNewContact, "New Producer Contact");
    this.btnNewContact.UseOSThemes = (DefaultableBoolean) 2;
    appearance58.ImageHAlign = (HAlign) 2;
    appearance58.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnSelectContact).Appearance = (AppearanceBase) appearance58;
    ((ControlBase) this.btnSelectContact).ImageSize = new Size(24, 24);
    ((Control) this.btnSelectContact).Location = new Point(58, 237);
    ((Control) this.btnSelectContact).Name = "btnSelectContact";
    ((Control) this.btnSelectContact).Size = new Size(40, 40);
    ((Control) this.btnSelectContact).TabIndex = 2;
    ((Control) this.btnSelectContact).Tag = (object) "KeepEnabled";
    this.ToolTip.SetToolTip((Control) this.btnSelectContact, "View Contact Information");
    this.btnSelectContact.UseOSThemes = (DefaultableBoolean) 2;
    this.lstContacts.ContextMenu = this.mnuContacts;
    this.lstContacts.DataSource = (object) this.dsProducer.tblProducerContacts;
    this.lstContacts.DisplayMember = "Name";
    this.lstContacts.Location = new Point(8, 8);
    this.lstContacts.Name = "lstContacts";
    this.lstContacts.Size = new Size(240 /*0xF0*/, 210);
    this.lstContacts.TabIndex = 0;
    this.lstContacts.Tag = (object) "KeepEnabled";
    this.lstContacts.ValueMember = "ProducerContactGUID";
    this.mnuContacts.MenuItems.AddRange(new MenuItem[3]
    {
      this.mnuActive,
      this.mnuInactive,
      this.mnuBothContacts
    });
    this.mnuActive.Checked = true;
    this.mnuActive.Index = 0;
    this.mnuActive.RadioCheck = true;
    this.mnuActive.Text = "Active Contacts";
    this.mnuInactive.Index = 1;
    this.mnuInactive.RadioCheck = true;
    this.mnuInactive.Text = "Inactive Contacts";
    this.mnuBothContacts.Index = 2;
    this.mnuBothContacts.RadioCheck = true;
    this.mnuBothContacts.Text = "Both";
    ((Control) this.UltraTabPageControl4).Controls.Add((Control) this.chkEmailReminders);
    ((Control) this.UltraTabPageControl4).Controls.Add((Control) this.chkAutoNOC);
    ((Control) this.UltraTabPageControl4).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabPageControl4).Name = "UltraTabPageControl4";
    ((Control) this.UltraTabPageControl4).Size = new Size(876, 341);
    ((UltraToggleEditorBase) this.chkEmailReminders).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkEmailReminders).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkEmailReminders).Checked = true;
    ((UltraToggleEditorBase) this.chkEmailReminders).CheckState = CheckState.Checked;
    ((Control) this.chkEmailReminders).DataBindings.Add(new Binding("Checked", (object) this.dsProducer, "tblProducerLocations.EmailReminders", true));
    ((Control) this.chkEmailReminders).Location = new Point(8, 48 /*0x30*/);
    ((Control) this.chkEmailReminders).Name = "chkEmailReminders";
    ((Control) this.chkEmailReminders).Size = new Size(224 /*0xE0*/, 24);
    ((Control) this.chkEmailReminders).TabIndex = 1;
    ((UltraToggleEditorBase) this.chkEmailReminders).Text = "Send e-mail reminders for premium due";
    ((UltraControlBase) this.chkEmailReminders).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkEmailReminders).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraToggleEditorBase) this.chkAutoNOC).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkAutoNOC).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkAutoNOC).Checked = true;
    ((UltraToggleEditorBase) this.chkAutoNOC).CheckState = CheckState.Checked;
    ((Control) this.chkAutoNOC).DataBindings.Add(new Binding("Checked", (object) this.dsProducer, "tblProducerLocations.AllowAutomaticNOC", true));
    ((Control) this.chkAutoNOC).Location = new Point(8, 16 /*0x10*/);
    ((Control) this.chkAutoNOC).Name = "chkAutoNOC";
    ((Control) this.chkAutoNOC).Size = new Size(376, 24);
    ((Control) this.chkAutoNOC).TabIndex = 0;
    ((UltraToggleEditorBase) this.chkAutoNOC).Text = "Allow automatic Notice of Cancellation for non-payment of premium";
    ((UltraControlBase) this.chkAutoNOC).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkAutoNOC).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.tabCRM).Controls.Add((Control) this.lblReferredBy);
    ((Control) this.tabCRM).Controls.Add((Control) this.cboProducerlocations);
    ((Control) this.tabCRM).Controls.Add((Control) this.Label29);
    ((Control) this.tabCRM).Controls.Add((Control) this.MgaComboBox1);
    ((Control) this.tabCRM).Controls.Add((Control) this.dtProdAgrrmntEff);
    ((Control) this.tabCRM).Controls.Add((Control) this.Label28);
    ((Control) this.tabCRM).Controls.Add((Control) this.chkApproveWholesalersList);
    ((Control) this.tabCRM).Controls.Add((Control) this.chkSetProcedureToEngage);
    ((Control) this.tabCRM).Controls.Add((Control) this.UltraGroupBox2);
    ((Control) this.tabCRM).Controls.Add((Control) this.UltraGroupBox1);
    ((Control) this.tabCRM).Controls.Add((Control) this.UltraGroupBox4);
    ((Control) this.tabCRM).Controls.Add((Control) this.Label27);
    ((Control) this.tabCRM).Controls.Add((Control) this.numWholesaleRel);
    ((Control) this.tabCRM).Controls.Add((Control) this.lblProdPro);
    ((Control) this.tabCRM).Controls.Add((Control) this.lblSource);
    ((Control) this.tabCRM).Controls.Add((Control) this.lblProductionStatus);
    ((Control) this.tabCRM).Controls.Add((Control) this.lblProdStatus);
    ((Control) this.tabCRM).Controls.Add((Control) this.cboOwner);
    ((Control) this.tabCRM).Controls.Add((Control) this.cboProductionPotential);
    ((Control) this.tabCRM).Controls.Add((Control) this.cboSource);
    ((Control) this.tabCRM).Controls.Add((Control) this.lblOwner);
    ((Control) this.tabCRM).Controls.Add((Control) this.lblGWP);
    ((Control) this.tabCRM).Controls.Add((Control) this.lblEmployees);
    ((Control) this.tabCRM).Controls.Add((Control) this.numGWP);
    ((Control) this.tabCRM).Controls.Add((Control) this.numEmployees);
    ((Control) this.tabCRM).Location = new Point(-10000, -10000);
    ((Control) this.tabCRM).Name = "tabCRM";
    ((Control) this.tabCRM).Size = new Size(876, 341);
    this.lblReferredBy.AutoSize = true;
    this.lblReferredBy.BackColor = Color.Transparent;
    this.lblReferredBy.Location = new Point(310, 215);
    this.lblReferredBy.Name = "lblReferredBy";
    this.lblReferredBy.Size = new Size(69, 13);
    this.lblReferredBy.TabIndex = 487;
    this.lblReferredBy.Text = "Referred By:";
    this.lblReferredBy.TextAlign = ContentAlignment.MiddleLeft;
    ((Control) this.cboProducerlocations).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.cboProducerlocations.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboProducerlocations).DataBindings.Add(new Binding("Value", (object) this.dsProducer, "tblProducerLocations.ReferredBYProdLocation", true));
    ((UltraGridBase) this.cboProducerlocations).DataMember = "lstProducers";
    ((UltraGridBase) this.cboProducerlocations).DataSource = (object) this.dsProducer;
    appearance59.BackColor = Color.White;
    appearance59.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance59.BackGradientStyle = (GradientStyle) 2;
    appearance59.BorderColor = Color.FromArgb(78, 122, 171);
    appearance59.ImageHAlign = (HAlign) 2;
    appearance59.ImageVAlign = (VAlign) 2;
    this.cboProducerlocations.DisplayLayout.Appearance = (AppearanceBase) appearance59;
    this.cboProducerlocations.DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand1.ColHeadersVisible = false;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 235;
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Width = 331;
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridBand1.Columns.AddRange(new object[3]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3
    });
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn4.Header.VisiblePosition = 0;
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn5.Header.VisiblePosition = 1;
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn6.Header.VisiblePosition = 2;
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn7.Header.VisiblePosition = 3;
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn8.Header.VisiblePosition = 4;
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn9.Header.VisiblePosition = 5;
    ((HeaderBase) ultraGridColumn10.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn10.Header.VisiblePosition = 6;
    ((HeaderBase) ultraGridColumn11.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn11.Header.VisiblePosition = 7;
    ((HeaderBase) ultraGridColumn12.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn12.Header.VisiblePosition = 8;
    ((HeaderBase) ultraGridColumn13.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn13.Header.VisiblePosition = 9;
    ((HeaderBase) ultraGridColumn14.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn14.Header.VisiblePosition = 10;
    ((HeaderBase) ultraGridColumn15.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn15.Header.VisiblePosition = 11;
    ((HeaderBase) ultraGridColumn16.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn16.Header.VisiblePosition = 12;
    ((HeaderBase) ultraGridColumn17.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn17.Header.VisiblePosition = 13;
    ((HeaderBase) ultraGridColumn18.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn18.Header.VisiblePosition = 14;
    ((HeaderBase) ultraGridColumn19.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn19.Header.VisiblePosition = 15;
    ((HeaderBase) ultraGridColumn20.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn20.Header.VisiblePosition = 16 /*0x10*/;
    ((HeaderBase) ultraGridColumn21.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn21.Header.VisiblePosition = 17;
    ((HeaderBase) ultraGridColumn22.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn22.Header.VisiblePosition = 18;
    ((HeaderBase) ultraGridColumn23.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn23.Header.VisiblePosition = 19;
    ((HeaderBase) ultraGridColumn24.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn24.Header.VisiblePosition = 20;
    ((HeaderBase) ultraGridColumn25.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn25.Header.VisiblePosition = 21;
    ((HeaderBase) ultraGridColumn26.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn26.Header.VisiblePosition = 22;
    ((HeaderBase) ultraGridColumn27.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn27.Header.VisiblePosition = 23;
    ((HeaderBase) ultraGridColumn28.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn28.Header.VisiblePosition = 24;
    ((HeaderBase) ultraGridColumn29.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn29.Header.VisiblePosition = 25;
    ((HeaderBase) ultraGridColumn30.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn30.Header.VisiblePosition = 26;
    ((HeaderBase) ultraGridColumn31.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn31.Header.VisiblePosition = 27;
    ((HeaderBase) ultraGridColumn32.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn32.Header.VisiblePosition = 28;
    ((HeaderBase) ultraGridColumn33.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn33.Header.VisiblePosition = 29;
    ((HeaderBase) ultraGridColumn34.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn34.Header.VisiblePosition = 30;
    ((HeaderBase) ultraGridColumn35.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn35.Header.VisiblePosition = 31 /*0x1F*/;
    ((HeaderBase) ultraGridColumn36.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn36.Header.VisiblePosition = 32 /*0x20*/;
    ((HeaderBase) ultraGridColumn37.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn37.Header.VisiblePosition = 33;
    ((HeaderBase) ultraGridColumn38.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn38.Header.VisiblePosition = 34;
    ((HeaderBase) ultraGridColumn39.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn39.Header.VisiblePosition = 35;
    ((HeaderBase) ultraGridColumn40.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn40.Header.VisiblePosition = 36;
    ((HeaderBase) ultraGridColumn41.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn41.Header.VisiblePosition = 37;
    ((HeaderBase) ultraGridColumn42.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn42.Header.VisiblePosition = 38;
    ((HeaderBase) ultraGridColumn43.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn43.Header.VisiblePosition = 39;
    ((HeaderBase) ultraGridColumn44.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn44.Header.VisiblePosition = 40;
    ((HeaderBase) ultraGridColumn45.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn45.Header.VisiblePosition = 41;
    ((HeaderBase) ultraGridColumn46.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn46.Header.VisiblePosition = 42;
    ((HeaderBase) ultraGridColumn47.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn47.Header.VisiblePosition = 43;
    ((HeaderBase) ultraGridColumn48.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn48.Header.VisiblePosition = 44;
    ((HeaderBase) ultraGridColumn49.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn49.Header.VisiblePosition = 45;
    ((HeaderBase) ultraGridColumn50.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn50.Header.VisiblePosition = 46;
    ((HeaderBase) ultraGridColumn51.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn51.Header.VisiblePosition = 47;
    ((HeaderBase) ultraGridColumn52.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn52.Header.VisiblePosition = 48 /*0x30*/;
    ((HeaderBase) ultraGridColumn53.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn53.Header.VisiblePosition = 49;
    ((HeaderBase) ultraGridColumn54.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn54.Header.VisiblePosition = 50;
    ((HeaderBase) ultraGridColumn55.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn55.Header.VisiblePosition = 51;
    ((HeaderBase) ultraGridColumn56.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn56.Header.VisiblePosition = 52;
    ((HeaderBase) ultraGridColumn57.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn57.Header.VisiblePosition = 53;
    ((HeaderBase) ultraGridColumn58.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn58.Header.VisiblePosition = 54;
    ((HeaderBase) ultraGridColumn59.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn59.Header.VisiblePosition = 55;
    ((HeaderBase) ultraGridColumn60.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn60.Header.VisiblePosition = 56;
    ((HeaderBase) ultraGridColumn61.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn61.Header.VisiblePosition = 57;
    ((HeaderBase) ultraGridColumn62.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn62.Header.VisiblePosition = 58;
    ((HeaderBase) ultraGridColumn63.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn63.Header.VisiblePosition = 59;
    ultraGridBand2.Columns.AddRange(new object[60]
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
      (object) ultraGridColumn28,
      (object) ultraGridColumn29,
      (object) ultraGridColumn30,
      (object) ultraGridColumn31,
      (object) ultraGridColumn32,
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
      (object) ultraGridColumn58,
      (object) ultraGridColumn59,
      (object) ultraGridColumn60,
      (object) ultraGridColumn61,
      (object) ultraGridColumn62,
      (object) ultraGridColumn63
    });
    ((HeaderBase) ultraGridColumn64.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn64.Header.VisiblePosition = 0;
    ((HeaderBase) ultraGridColumn65.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn65.Header.VisiblePosition = 1;
    ((HeaderBase) ultraGridColumn66.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn66.Header.VisiblePosition = 2;
    ((HeaderBase) ultraGridColumn67.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn67.Header.VisiblePosition = 3;
    ultraGridBand3.Columns.AddRange(new object[4]
    {
      (object) ultraGridColumn64,
      (object) ultraGridColumn65,
      (object) ultraGridColumn66,
      (object) ultraGridColumn67
    });
    this.cboProducerlocations.DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    this.cboProducerlocations.DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    this.cboProducerlocations.DisplayLayout.BandsSerializer.Add((object) ultraGridBand3);
    this.cboProducerlocations.DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    this.cboProducerlocations.DisplayLayout.BorderStyleCaption = (UIElementBorderStyle) 1;
    this.cboProducerlocations.DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    appearance60.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance60.Image"));
    appearance60.ImageHAlign = (HAlign) 1;
    ((SpecialBoxBase) this.cboProducerlocations.DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance60;
    appearance61.BackColor = Color.Transparent;
    appearance61.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.cboProducerlocations.DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance61;
    ((SpecialBoxBase) this.cboProducerlocations.DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    appearance62.BackColor = Color.Transparent;
    appearance62.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.cboProducerlocations.DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance62;
    this.cboProducerlocations.DisplayLayout.MaxColScrollRegions = 1;
    this.cboProducerlocations.DisplayLayout.MaxRowScrollRegions = 1;
    appearance63.BackColor = Color.Transparent;
    appearance63.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.cboProducerlocations.DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance63;
    appearance64.BackColor = Color.Transparent;
    appearance64.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.cboProducerlocations.DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance64;
    this.cboProducerlocations.DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    this.cboProducerlocations.DisplayLayout.Override.BorderStyleHeader = (UIElementBorderStyle) 1;
    this.cboProducerlocations.DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    this.cboProducerlocations.DisplayLayout.Override.BorderStyleRowSelector = (UIElementBorderStyle) 1;
    this.cboProducerlocations.DisplayLayout.Override.BorderStyleSummaryFooter = (UIElementBorderStyle) 1;
    this.cboProducerlocations.DisplayLayout.Override.BorderStyleSummaryFooterCaption = (UIElementBorderStyle) 1;
    this.cboProducerlocations.DisplayLayout.Override.BorderStyleSummaryValue = (UIElementBorderStyle) 1;
    this.cboProducerlocations.DisplayLayout.Override.BorderStyleTemplateAddRow = (UIElementBorderStyle) 1;
    appearance65.BackColor = Color.Transparent;
    appearance65.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.cboProducerlocations.DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance65;
    appearance66.ImageHAlign = (HAlign) 2;
    appearance66.ImageVAlign = (VAlign) 2;
    this.cboProducerlocations.DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance66;
    this.cboProducerlocations.DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    this.cboProducerlocations.DisplayLayout.Override.CellPadding = 0;
    appearance67.ImageHAlign = (HAlign) 2;
    appearance67.ImageVAlign = (VAlign) 2;
    this.cboProducerlocations.DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance67;
    appearance68.BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    appearance68.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.cboProducerlocations.DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance68;
    this.cboProducerlocations.DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    this.cboProducerlocations.DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    appearance69.BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    appearance69.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this.cboProducerlocations.DisplayLayout.Override.HotTrackRowAppearance = (AppearanceBase) appearance69;
    appearance70.BackColor = SystemColors.Window;
    appearance70.BorderColor = Color.White;
    this.cboProducerlocations.DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance70;
    this.cboProducerlocations.DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    this.cboProducerlocations.DisplayLayout.Override.RowSpacingAfter = 1;
    appearance71.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance71.BorderColor = Color.FromArgb((int) byte.MaxValue, 214, 88);
    appearance71.ForeColor = Color.Black;
    this.cboProducerlocations.DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance71;
    appearance72.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance72.Image"));
    this.cboProducerlocations.DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance72;
    scrollBarLook3.ViewStyle = (ScrollBarViewStyle) 3;
    this.cboProducerlocations.DisplayLayout.ScrollBarLook = scrollBarLook3;
    this.cboProducerlocations.DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    this.cboProducerlocations.DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    this.cboProducerlocations.DisplayLayout.ViewStyleBand = (ViewStyleBand) 2;
    ((UltraDropDownBase) this.cboProducerlocations).DisplayMember = "ProducerName";
    this.cboProducerlocations.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboProducerlocations).DropDownWidth = 350;
    ((Control) this.cboProducerlocations).Location = new Point(385, 207);
    this.cboProducerlocations.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboProducerlocations).Name = "cboProducerlocations";
    ((Control) this.cboProducerlocations).Size = new Size(211, 21);
    ((Control) this.cboProducerlocations).TabIndex = 486;
    ((UltraControlBase) this.cboProducerlocations).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboProducerlocations).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboProducerlocations).ValueMember = "ProducerGUID";
    this.Label29.AutoSize = true;
    this.Label29.BackColor = Color.Transparent;
    this.Label29.Location = new Point(5, 149);
    this.Label29.Name = "Label29";
    this.Label29.Size = new Size(49, 13);
    this.Label29.TabIndex = 485;
    this.Label29.Text = "Ranking:";
    this.Label29.TextAlign = ContentAlignment.MiddleLeft;
    ((Control) this.MgaComboBox1).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.MgaComboBox1.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.MgaComboBox1).DataBindings.Add(new Binding("Value", (object) this.dsProducer, "tblProducerLocations.ProducerRankingID", true));
    ((UltraGridBase) this.MgaComboBox1).DataMember = "lstProducerRankings";
    ((UltraGridBase) this.MgaComboBox1).DataSource = (object) this.dsProducer;
    appearance73.BackColor = Color.White;
    appearance73.BorderColor = Color.FromArgb(78, 122, 171);
    appearance73.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance73.Image"));
    this.MgaComboBox1.DisplayLayout.Appearance = (AppearanceBase) appearance73;
    this.MgaComboBox1.DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand4.ColHeadersVisible = false;
    ultraGridColumn68.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn68.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn68.Header.VisiblePosition = 0;
    ultraGridColumn68.Hidden = true;
    ultraGridColumn68.Width = 100;
    ultraGridColumn69.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn69.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn69.Header.VisiblePosition = 1;
    ultraGridColumn69.Width = 331;
    ultraGridBand4.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn68,
      (object) ultraGridColumn69
    });
    this.MgaComboBox1.DisplayLayout.BandsSerializer.Add((object) ultraGridBand4);
    this.MgaComboBox1.DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    this.MgaComboBox1.DisplayLayout.BorderStyleCaption = (UIElementBorderStyle) 1;
    this.MgaComboBox1.DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    appearance74.BackColorDisabled = Color.Gainsboro;
    appearance74.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((SpecialBoxBase) this.MgaComboBox1.DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance74;
    appearance75.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance75.Image"));
    this.MgaComboBox1.DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance75;
    ((SpecialBoxBase) this.MgaComboBox1.DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    appearance76.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance76.Image"));
    this.MgaComboBox1.DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance76;
    this.MgaComboBox1.DisplayLayout.MaxColScrollRegions = 1;
    this.MgaComboBox1.DisplayLayout.MaxRowScrollRegions = 1;
    appearance77.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance77.Image"));
    this.MgaComboBox1.DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance77;
    appearance78.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance78.Image"));
    this.MgaComboBox1.DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance78;
    this.MgaComboBox1.DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    this.MgaComboBox1.DisplayLayout.Override.BorderStyleHeader = (UIElementBorderStyle) 1;
    this.MgaComboBox1.DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    this.MgaComboBox1.DisplayLayout.Override.BorderStyleRowSelector = (UIElementBorderStyle) 1;
    this.MgaComboBox1.DisplayLayout.Override.BorderStyleSummaryFooter = (UIElementBorderStyle) 1;
    this.MgaComboBox1.DisplayLayout.Override.BorderStyleSummaryFooterCaption = (UIElementBorderStyle) 1;
    this.MgaComboBox1.DisplayLayout.Override.BorderStyleSummaryValue = (UIElementBorderStyle) 1;
    this.MgaComboBox1.DisplayLayout.Override.BorderStyleTemplateAddRow = (UIElementBorderStyle) 1;
    appearance79.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance79.Image"));
    this.MgaComboBox1.DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance79;
    appearance80.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance80.Image"));
    this.MgaComboBox1.DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance80;
    this.MgaComboBox1.DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    this.MgaComboBox1.DisplayLayout.Override.CellPadding = 0;
    appearance81.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance81.Image"));
    this.MgaComboBox1.DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance81;
    appearance82.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance82.Image"));
    this.MgaComboBox1.DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance82;
    this.MgaComboBox1.DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    this.MgaComboBox1.DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    appearance83.BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    appearance83.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this.MgaComboBox1.DisplayLayout.Override.HotTrackRowAppearance = (AppearanceBase) appearance83;
    appearance84.BorderColor = Color.White;
    appearance84.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance84.Image"));
    this.MgaComboBox1.DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance84;
    this.MgaComboBox1.DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    this.MgaComboBox1.DisplayLayout.Override.RowSpacingAfter = 1;
    appearance85.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance85.BorderColor = Color.FromArgb((int) byte.MaxValue, 214, 88);
    appearance85.ForeColor = Color.Black;
    appearance85.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance85.Image"));
    this.MgaComboBox1.DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance85;
    appearance86.BackColor = SystemColors.ControlLight;
    appearance86.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.MgaComboBox1.DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance86;
    scrollBarLook4.ViewStyle = (ScrollBarViewStyle) 3;
    this.MgaComboBox1.DisplayLayout.ScrollBarLook = scrollBarLook4;
    this.MgaComboBox1.DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    this.MgaComboBox1.DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    this.MgaComboBox1.DisplayLayout.ViewStyleBand = (ViewStyleBand) 2;
    ((UltraDropDownBase) this.MgaComboBox1).DisplayMember = "ProducerRanking";
    this.MgaComboBox1.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.MgaComboBox1).DropDownWidth = 350;
    ((Control) this.MgaComboBox1).Location = new Point(131, 145);
    this.MgaComboBox1.MGAStyle = MGAStyles.Blue;
    ((Control) this.MgaComboBox1).Name = "MgaComboBox1";
    ((Control) this.MgaComboBox1).Size = new Size(232, 21);
    ((Control) this.MgaComboBox1).TabIndex = 484;
    ((UltraControlBase) this.MgaComboBox1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaComboBox1).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.MgaComboBox1).ValueMember = "ID";
    appearance87.BackColor = Color.White;
    appearance87.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dtProdAgrrmntEff.Appearance = (AppearanceBase) appearance87;
    this.dtProdAgrrmntEff.BackColor = Color.White;
    appearance88.AlphaLevel = (short) 14;
    appearance88.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance88.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance88.BackColorAlpha = (Alpha) 2;
    appearance88.BackGradientAlignment = (GradientAlignment) 4;
    appearance88.BackGradientStyle = (GradientStyle) 5;
    appearance88.BorderAlpha = (Alpha) 1;
    appearance88.BorderColor = Color.FromArgb(78, 122, 171);
    appearance88.ForeColor = Color.FromArgb(49, 85, 153);
    appearance88.ForegroundAlpha = (Alpha) 2;
    this.dtProdAgrrmntEff.ButtonAppearance = (AppearanceBase) appearance88;
    ((Control) this.dtProdAgrrmntEff).DataBindings.Add(new Binding("Value", (object) this.dsProducer, "tblProducerLocations.AgreementEffectiveDate", true));
    this.dtProdAgrrmntEff.DateTime = new DateTime(2018, 11, 20, 0, 0, 0, 0);
    ((Control) this.dtProdAgrrmntEff).Location = new Point(131, 220);
    this.dtProdAgrrmntEff.MGAStyle = MGAStyles.Blue;
    ((Control) this.dtProdAgrrmntEff).Name = "dtProdAgrrmntEff";
    ((Control) this.dtProdAgrrmntEff).Size = new Size(90, 20);
    ((Control) this.dtProdAgrrmntEff).TabIndex = 483;
    ((UltraControlBase) this.dtProdAgrrmntEff).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtProdAgrrmntEff).UseOsThemes = (DefaultableBoolean) 2;
    this.dtProdAgrrmntEff.Value = (object) new DateTime(2018, 11, 20, 0, 0, 0, 0);
    this.Label28.AutoSize = true;
    this.Label28.BackColor = Color.Transparent;
    this.Label28.Location = new Point(5, 224 /*0xE0*/);
    this.Label28.Name = "Label28";
    this.Label28.Size = new Size(88, 13);
    this.Label28.TabIndex = 481;
    this.Label28.Text = "Prod Agrmnt Eff:";
    this.Label28.TextAlign = ContentAlignment.MiddleLeft;
    appearance89.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance89.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkApproveWholesalersList).Appearance = (AppearanceBase) appearance89;
    ((UltraToggleEditorBase) this.chkApproveWholesalersList).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkApproveWholesalersList).BackColorInternal = Color.Transparent;
    ((Control) this.chkApproveWholesalersList).DataBindings.Add(new Binding("CheckedValue", (object) this.dsProducer, "tblProducerLocations.ApproveWholesalersList", true));
    ((UltraToggleEditorBase) this.chkApproveWholesalersList).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkApproveWholesalersList).Location = new Point(84, 277);
    this.chkApproveWholesalersList.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkApproveWholesalersList).Name = "chkApproveWholesalersList";
    ((Control) this.chkApproveWholesalersList).Size = new Size(230, 23);
    ((Control) this.chkApproveWholesalersList).TabIndex = 8;
    ((UltraToggleEditorBase) this.chkApproveWholesalersList).Text = "Is there an Approve List of Wholesalers?";
    ((UltraControlBase) this.chkApproveWholesalersList).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkApproveWholesalersList).UseOsThemes = (DefaultableBoolean) 2;
    appearance90.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance90.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkSetProcedureToEngage).Appearance = (AppearanceBase) appearance90;
    ((UltraToggleEditorBase) this.chkSetProcedureToEngage).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkSetProcedureToEngage).BackColorInternal = Color.Transparent;
    ((Control) this.chkSetProcedureToEngage).DataBindings.Add(new Binding("CheckedValue", (object) this.dsProducer, "tblProducerLocations.SetProcedureToEnage", true));
    ((UltraToggleEditorBase) this.chkSetProcedureToEngage).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkSetProcedureToEngage).Location = new Point(84, 247);
    this.chkSetProcedureToEngage.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkSetProcedureToEngage).Name = "chkSetProcedureToEngage";
    ((Control) this.chkSetProcedureToEngage).Size = new Size(259, 24);
    ((Control) this.chkSetProcedureToEngage).TabIndex = 7;
    ((UltraToggleEditorBase) this.chkSetProcedureToEngage).Text = "Set Procedure on how to engage a wholesaler?";
    ((UltraControlBase) this.chkSetProcedureToEngage).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkSetProcedureToEngage).UseOsThemes = (DefaultableBoolean) 2;
    this.UltraGroupBox2.BackColorInternal = Color.FromArgb(240 /*0xF0*/, 247, 253);
    appearance91.BackColor = Color.White;
    appearance91.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.UltraGroupBox2.ContentAreaAppearance = (AppearanceBase) appearance91;
    ((Control) this.UltraGroupBox2).Controls.Add((Control) this.txtWholesaleRelationships);
    ((Control) this.UltraGroupBox2).Location = new Point(385, 139);
    ((Control) this.UltraGroupBox2).Name = "UltraGroupBox2";
    ((Control) this.UltraGroupBox2).Size = new Size(296, 62);
    ((Control) this.UltraGroupBox2).TabIndex = 11;
    this.UltraGroupBox2.Text = "Wholesale Relationships";
    this.txtWholesaleRelationships.BackColor = Color.White;
    this.txtWholesaleRelationships.BorderStyle = BorderStyle.None;
    this.txtWholesaleRelationships.Dock = DockStyle.Fill;
    this.txtWholesaleRelationships.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtWholesaleRelationships.ForeColor = Color.Black;
    this.txtWholesaleRelationships.Location = new Point(3, 17);
    this.txtWholesaleRelationships.Name = "txtWholesaleRelationships";
    this.txtWholesaleRelationships.Size = new Size(290, 42);
    this.txtWholesaleRelationships.TabIndex = 0;
    this.txtWholesaleRelationships.Text = "";
    this.UltraGroupBox1.BackColorInternal = Color.FromArgb(240 /*0xF0*/, 247, 253);
    appearance92.BackColor = Color.White;
    appearance92.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.UltraGroupBox1.ContentAreaAppearance = (AppearanceBase) appearance92;
    ((Control) this.UltraGroupBox1).Controls.Add((Control) this.txtExpertise);
    ((Control) this.UltraGroupBox1).Location = new Point(385, 71);
    ((Control) this.UltraGroupBox1).Name = "UltraGroupBox1";
    ((Control) this.UltraGroupBox1).Size = new Size(296, 62);
    ((Control) this.UltraGroupBox1).TabIndex = 10;
    this.UltraGroupBox1.Text = "Expertise, Specialization or Niches";
    this.txtExpertise.BackColor = Color.White;
    this.txtExpertise.BorderStyle = BorderStyle.None;
    this.txtExpertise.Dock = DockStyle.Fill;
    this.txtExpertise.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtExpertise.ForeColor = Color.Black;
    this.txtExpertise.Location = new Point(3, 17);
    this.txtExpertise.Name = "txtExpertise";
    this.txtExpertise.Size = new Size(290, 42);
    this.txtExpertise.TabIndex = 0;
    this.txtExpertise.Text = "";
    this.UltraGroupBox4.BackColorInternal = Color.FromArgb(240 /*0xF0*/, 247, 253);
    appearance93.BackColor = Color.White;
    appearance93.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.UltraGroupBox4.ContentAreaAppearance = (AppearanceBase) appearance93;
    ((Control) this.UltraGroupBox4).Controls.Add((Control) this.txtSpecFocusDept);
    ((Control) this.UltraGroupBox4).Location = new Point(382, 9);
    ((Control) this.UltraGroupBox4).Name = "UltraGroupBox4";
    ((Control) this.UltraGroupBox4).Size = new Size(296, 56);
    ((Control) this.UltraGroupBox4).TabIndex = 9;
    this.UltraGroupBox4.Text = "Specialized Focused Departments";
    this.txtSpecFocusDept.BackColor = Color.White;
    this.txtSpecFocusDept.BorderStyle = BorderStyle.None;
    this.txtSpecFocusDept.Dock = DockStyle.Fill;
    this.txtSpecFocusDept.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtSpecFocusDept.ForeColor = Color.Black;
    this.txtSpecFocusDept.Location = new Point(3, 17);
    this.txtSpecFocusDept.Name = "txtSpecFocusDept";
    this.txtSpecFocusDept.Size = new Size(290, 36);
    this.txtSpecFocusDept.TabIndex = 0;
    this.txtSpecFocusDept.Text = "";
    this.Label27.AutoSize = true;
    this.Label27.BackColor = Color.Transparent;
    this.Label27.Location = new Point(5, 197);
    this.Label27.Name = "Label27";
    this.Label27.Size = new Size(99, 13);
    this.Label27.TabIndex = 479;
    this.Label27.Text = "# Wholesale Rela.:";
    this.Label27.TextAlign = ContentAlignment.MiddleLeft;
    appearance94.BackColor = SystemColors.ControlLight;
    appearance94.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.numWholesaleRel).Appearance = (AppearanceBase) appearance94;
    ((UltraNumericEditorBase) this.numWholesaleRel).BackColor = SystemColors.ControlLight;
    ((Control) this.numWholesaleRel).DataBindings.Add(new Binding("Value", (object) this.dsProducer, "tblProducerLocations.NumWholesaleRelationship", true));
    ((UltraNumericEditorBase) this.numWholesaleRel).FormatString = "";
    ((Control) this.numWholesaleRel).Location = new Point(131, 193);
    this.numWholesaleRel.MaxValue = (object) 99999;
    this.numWholesaleRel.MGAStyle = MGAStyles.Blue;
    this.numWholesaleRel.MinValue = (object) 0;
    ((Control) this.numWholesaleRel).Name = "numWholesaleRel";
    this.numWholesaleRel.Nullable = true;
    ((Control) this.numWholesaleRel).Size = new Size(90, 20);
    ((Control) this.numWholesaleRel).TabIndex = 6;
    ((UltraControlBase) this.numWholesaleRel).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numWholesaleRel).UseOsThemes = (DefaultableBoolean) 2;
    this.numWholesaleRel.Value = (object) null;
    this.lblProdPro.AutoSize = true;
    this.lblProdPro.BackColor = Color.Transparent;
    this.lblProdPro.Location = new Point(5, 121);
    this.lblProdPro.Name = "lblProdPro";
    this.lblProdPro.Size = new Size(107, 13);
    this.lblProdPro.TabIndex = 477;
    this.lblProdPro.Text = "Production Potential:";
    this.lblProdPro.TextAlign = ContentAlignment.MiddleLeft;
    this.lblSource.AutoSize = true;
    this.lblSource.BackColor = Color.Transparent;
    this.lblSource.Location = new Point(5, 65);
    this.lblSource.Name = "lblSource";
    this.lblSource.Size = new Size(44, 13);
    this.lblSource.TabIndex = 476;
    this.lblSource.Text = "Source:";
    this.lblSource.TextAlign = ContentAlignment.MiddleLeft;
    this.lblProductionStatus.AutoSize = true;
    this.lblProductionStatus.BackColor = Color.Transparent;
    this.lblProductionStatus.Location = new Point(128 /*0x80*/, 173);
    this.lblProductionStatus.Name = "lblProductionStatus";
    this.lblProductionStatus.Size = new Size(32 /*0x20*/, 13);
    this.lblProductionStatus.TabIndex = 5;
    this.lblProductionStatus.Text = "None";
    this.lblProductionStatus.TextAlign = ContentAlignment.MiddleLeft;
    this.lblProdStatus.AutoSize = true;
    this.lblProdStatus.BackColor = Color.Transparent;
    this.lblProdStatus.Location = new Point(5, 173);
    this.lblProdStatus.Name = "lblProdStatus";
    this.lblProdStatus.Size = new Size(96 /*0x60*/, 13);
    this.lblProdStatus.TabIndex = 472;
    this.lblProdStatus.Text = "Production Status:";
    this.lblProdStatus.TextAlign = ContentAlignment.MiddleLeft;
    ((Control) this.cboOwner).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.cboOwner.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboOwner).DataBindings.Add(new Binding("Value", (object) this.dsProducer, "tblProducerLocations.Owner", true));
    ((UltraGridBase) this.cboOwner).DataMember = "tblUsers";
    ((UltraGridBase) this.cboOwner).DataSource = (object) this.dsProducer;
    appearance95.BackColor = Color.White;
    appearance95.BorderColor = Color.FromArgb(78, 122, 171);
    appearance95.ForeColor = Color.Black;
    this.cboOwner.DisplayLayout.Appearance = (AppearanceBase) appearance95;
    this.cboOwner.DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand5.ColHeadersVisible = false;
    ultraGridColumn70.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn70.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn70.Header.VisiblePosition = 0;
    ultraGridColumn70.Hidden = true;
    ultraGridColumn70.Width = 231;
    ultraGridColumn71.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn71.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn71.Header.VisiblePosition = 1;
    ultraGridColumn71.Width = 331;
    ultraGridBand5.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn70,
      (object) ultraGridColumn71
    });
    this.cboOwner.DisplayLayout.BandsSerializer.Add((object) ultraGridBand5);
    this.cboOwner.DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    this.cboOwner.DisplayLayout.BorderStyleCaption = (UIElementBorderStyle) 1;
    this.cboOwner.DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    appearance96.BackColor = Color.White;
    appearance96.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance96.ForeColor = Color.Black;
    ((SpecialBoxBase) this.cboOwner.DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance96;
    appearance97.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance97.ForeColor = Color.Black;
    this.cboOwner.DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance97;
    ((SpecialBoxBase) this.cboOwner.DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    appearance98.BackColorDisabled = Color.Gainsboro;
    appearance98.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.cboOwner.DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance98;
    this.cboOwner.DisplayLayout.MaxColScrollRegions = 1;
    this.cboOwner.DisplayLayout.MaxRowScrollRegions = 1;
    appearance99.BackColorDisabled = Color.Gainsboro;
    appearance99.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.cboOwner.DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance99;
    appearance100.BackColor = Color.White;
    appearance100.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance100.ForeColor = Color.Black;
    this.cboOwner.DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance100;
    this.cboOwner.DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    this.cboOwner.DisplayLayout.Override.BorderStyleHeader = (UIElementBorderStyle) 1;
    this.cboOwner.DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    this.cboOwner.DisplayLayout.Override.BorderStyleRowSelector = (UIElementBorderStyle) 1;
    this.cboOwner.DisplayLayout.Override.BorderStyleSummaryFooter = (UIElementBorderStyle) 1;
    this.cboOwner.DisplayLayout.Override.BorderStyleSummaryFooterCaption = (UIElementBorderStyle) 1;
    this.cboOwner.DisplayLayout.Override.BorderStyleSummaryValue = (UIElementBorderStyle) 1;
    this.cboOwner.DisplayLayout.Override.BorderStyleTemplateAddRow = (UIElementBorderStyle) 1;
    appearance101.BackColor = Color.White;
    appearance101.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance101.ForeColor = Color.Black;
    this.cboOwner.DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance101;
    appearance102.BackColor = Color.Transparent;
    appearance102.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance102).TextHAlignAsString = "Left";
    ((AppearanceBase) appearance102).TextVAlignAsString = "Middle";
    this.cboOwner.DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance102;
    this.cboOwner.DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    this.cboOwner.DisplayLayout.Override.CellPadding = 0;
    appearance103.BackColor = Color.White;
    appearance103.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance103.ForeColor = Color.Black;
    this.cboOwner.DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance103;
    appearance104.BackColor = Color.Transparent;
    appearance104.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance104).TextHAlignAsString = "Center";
    ((AppearanceBase) appearance104).TextVAlignAsString = "Middle";
    this.cboOwner.DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance104;
    this.cboOwner.DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    this.cboOwner.DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    appearance105.BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    appearance105.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this.cboOwner.DisplayLayout.Override.HotTrackRowAppearance = (AppearanceBase) appearance105;
    appearance106.BackColor = Color.FromArgb(248, 248, 248);
    appearance106.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance106.BackGradientStyle = (GradientStyle) 2;
    appearance106.BorderColor = Color.White;
    appearance106.ImageHAlign = (HAlign) 2;
    appearance106.ImageVAlign = (VAlign) 2;
    this.cboOwner.DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance106;
    this.cboOwner.DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    this.cboOwner.DisplayLayout.Override.RowSpacingAfter = 1;
    appearance107.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance107.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance107.BackGradientStyle = (GradientStyle) 2;
    appearance107.BorderColor = Color.FromArgb((int) byte.MaxValue, 214, 88);
    appearance107.ForeColor = Color.Black;
    appearance107.ImageHAlign = (HAlign) 2;
    appearance107.ImageVAlign = (VAlign) 2;
    this.cboOwner.DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance107;
    appearance108.BackColor = Color.FromArgb(248, 248, 248);
    appearance108.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance108.BackGradientStyle = (GradientStyle) 2;
    appearance108.BorderColor = Color.DarkGray;
    appearance108.ImageHAlign = (HAlign) 2;
    appearance108.ImageVAlign = (VAlign) 2;
    this.cboOwner.DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance108;
    scrollBarLook5.ViewStyle = (ScrollBarViewStyle) 3;
    this.cboOwner.DisplayLayout.ScrollBarLook = scrollBarLook5;
    this.cboOwner.DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    this.cboOwner.DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    this.cboOwner.DisplayLayout.ViewStyleBand = (ViewStyleBand) 2;
    ((UltraDropDownBase) this.cboOwner).DisplayMember = "Name_LastFirst";
    this.cboOwner.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboOwner).DropDownWidth = 350;
    ((Control) this.cboOwner).Location = new Point(131, 89);
    this.cboOwner.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboOwner).Name = "cboOwner";
    ((Control) this.cboOwner).Size = new Size(232, 21);
    ((Control) this.cboOwner).TabIndex = 3;
    ((UltraControlBase) this.cboOwner).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboOwner).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboOwner).ValueMember = "UserGUID";
    ((Control) this.cboProductionPotential).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.cboProductionPotential.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboProductionPotential).DataBindings.Add(new Binding("Value", (object) this.dsProducer, "tblProducerLocations.ProductionPotential", true));
    ((UltraGridBase) this.cboProductionPotential).DataMember = "lstProductionPotential";
    ((UltraGridBase) this.cboProductionPotential).DataSource = (object) this.dsProducer;
    appearance109.BackColor = Color.White;
    appearance109.BorderColor = Color.FromArgb(78, 122, 171);
    appearance109.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance109.Image"));
    this.cboProductionPotential.DisplayLayout.Appearance = (AppearanceBase) appearance109;
    this.cboProductionPotential.DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand6.ColHeadersVisible = false;
    ultraGridColumn72.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn72.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn72.Header.VisiblePosition = 0;
    ultraGridColumn72.Hidden = true;
    ultraGridColumn72.Width = 100;
    ultraGridColumn73.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn73.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn73.Header.VisiblePosition = 1;
    ultraGridColumn73.Width = 331;
    ultraGridBand6.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn72,
      (object) ultraGridColumn73
    });
    this.cboProductionPotential.DisplayLayout.BandsSerializer.Add((object) ultraGridBand6);
    this.cboProductionPotential.DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    this.cboProductionPotential.DisplayLayout.BorderStyleCaption = (UIElementBorderStyle) 1;
    this.cboProductionPotential.DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    appearance110.BackColorDisabled = Color.Gainsboro;
    appearance110.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((SpecialBoxBase) this.cboProductionPotential.DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance110;
    appearance111.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance111.Image"));
    this.cboProductionPotential.DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance111;
    ((SpecialBoxBase) this.cboProductionPotential.DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    appearance112.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance112.Image"));
    this.cboProductionPotential.DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance112;
    this.cboProductionPotential.DisplayLayout.MaxColScrollRegions = 1;
    this.cboProductionPotential.DisplayLayout.MaxRowScrollRegions = 1;
    appearance113.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance113.Image"));
    this.cboProductionPotential.DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance113;
    appearance114.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance114.Image"));
    this.cboProductionPotential.DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance114;
    this.cboProductionPotential.DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    this.cboProductionPotential.DisplayLayout.Override.BorderStyleHeader = (UIElementBorderStyle) 1;
    this.cboProductionPotential.DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    this.cboProductionPotential.DisplayLayout.Override.BorderStyleRowSelector = (UIElementBorderStyle) 1;
    this.cboProductionPotential.DisplayLayout.Override.BorderStyleSummaryFooter = (UIElementBorderStyle) 1;
    this.cboProductionPotential.DisplayLayout.Override.BorderStyleSummaryFooterCaption = (UIElementBorderStyle) 1;
    this.cboProductionPotential.DisplayLayout.Override.BorderStyleSummaryValue = (UIElementBorderStyle) 1;
    this.cboProductionPotential.DisplayLayout.Override.BorderStyleTemplateAddRow = (UIElementBorderStyle) 1;
    appearance115.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance115.Image"));
    this.cboProductionPotential.DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance115;
    appearance116.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance116.Image"));
    this.cboProductionPotential.DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance116;
    this.cboProductionPotential.DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    this.cboProductionPotential.DisplayLayout.Override.CellPadding = 0;
    appearance117.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance117.Image"));
    this.cboProductionPotential.DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance117;
    appearance118.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance118.Image"));
    this.cboProductionPotential.DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance118;
    this.cboProductionPotential.DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    this.cboProductionPotential.DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    appearance119.BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    appearance119.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this.cboProductionPotential.DisplayLayout.Override.HotTrackRowAppearance = (AppearanceBase) appearance119;
    appearance120.BorderColor = Color.White;
    appearance120.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance120.Image"));
    this.cboProductionPotential.DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance120;
    this.cboProductionPotential.DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    this.cboProductionPotential.DisplayLayout.Override.RowSpacingAfter = 1;
    appearance121.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance121.BorderColor = Color.FromArgb((int) byte.MaxValue, 214, 88);
    appearance121.ForeColor = Color.Black;
    appearance121.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance121.Image"));
    this.cboProductionPotential.DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance121;
    appearance122.BackColor = SystemColors.ControlLight;
    appearance122.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.cboProductionPotential.DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance122;
    scrollBarLook6.ViewStyle = (ScrollBarViewStyle) 3;
    this.cboProductionPotential.DisplayLayout.ScrollBarLook = scrollBarLook6;
    this.cboProductionPotential.DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    this.cboProductionPotential.DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    this.cboProductionPotential.DisplayLayout.ViewStyleBand = (ViewStyleBand) 2;
    ((UltraDropDownBase) this.cboProductionPotential).DisplayMember = "Description";
    this.cboProductionPotential.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboProductionPotential).DropDownWidth = 350;
    ((Control) this.cboProductionPotential).Location = new Point(131, 117);
    this.cboProductionPotential.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboProductionPotential).Name = "cboProductionPotential";
    ((Control) this.cboProductionPotential).Size = new Size(232, 21);
    ((Control) this.cboProductionPotential).TabIndex = 4;
    ((UltraControlBase) this.cboProductionPotential).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboProductionPotential).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboProductionPotential).ValueMember = "ID";
    ((Control) this.cboSource).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.cboSource.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboSource).DataBindings.Add(new Binding("Value", (object) this.dsProducer, "tblProducerLocations.LocationSource", true));
    ((UltraGridBase) this.cboSource).DataMember = "lstProducerLocationSource";
    ((UltraGridBase) this.cboSource).DataSource = (object) this.dsProducer;
    appearance123.BackColor = Color.White;
    appearance123.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance123.BackGradientStyle = (GradientStyle) 2;
    appearance123.BorderColor = Color.FromArgb(78, 122, 171);
    appearance123.ImageHAlign = (HAlign) 2;
    appearance123.ImageVAlign = (VAlign) 2;
    this.cboSource.DisplayLayout.Appearance = (AppearanceBase) appearance123;
    this.cboSource.DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand7.ColHeadersVisible = false;
    ultraGridColumn74.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn74.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn74.Header.VisiblePosition = 0;
    ultraGridColumn74.Hidden = true;
    ultraGridColumn74.Width = 124;
    ultraGridColumn75.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn75.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn75.Header.VisiblePosition = 1;
    ultraGridColumn75.Width = 331;
    ultraGridBand7.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn74,
      (object) ultraGridColumn75
    });
    this.cboSource.DisplayLayout.BandsSerializer.Add((object) ultraGridBand7);
    this.cboSource.DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    this.cboSource.DisplayLayout.BorderStyleCaption = (UIElementBorderStyle) 1;
    this.cboSource.DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    appearance124.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance124.Image"));
    appearance124.ImageHAlign = (HAlign) 1;
    ((SpecialBoxBase) this.cboSource.DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance124;
    appearance125.BackColor = Color.Transparent;
    appearance125.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.cboSource.DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance125;
    ((SpecialBoxBase) this.cboSource.DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    appearance126.BackColor = Color.Transparent;
    appearance126.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.cboSource.DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance126;
    this.cboSource.DisplayLayout.MaxColScrollRegions = 1;
    this.cboSource.DisplayLayout.MaxRowScrollRegions = 1;
    appearance127.BackColor = Color.Transparent;
    appearance127.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.cboSource.DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance127;
    appearance128.BackColor = Color.Transparent;
    appearance128.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.cboSource.DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance128;
    this.cboSource.DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    this.cboSource.DisplayLayout.Override.BorderStyleHeader = (UIElementBorderStyle) 1;
    this.cboSource.DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    this.cboSource.DisplayLayout.Override.BorderStyleRowSelector = (UIElementBorderStyle) 1;
    this.cboSource.DisplayLayout.Override.BorderStyleSummaryFooter = (UIElementBorderStyle) 1;
    this.cboSource.DisplayLayout.Override.BorderStyleSummaryFooterCaption = (UIElementBorderStyle) 1;
    this.cboSource.DisplayLayout.Override.BorderStyleSummaryValue = (UIElementBorderStyle) 1;
    this.cboSource.DisplayLayout.Override.BorderStyleTemplateAddRow = (UIElementBorderStyle) 1;
    appearance129.BackColor = Color.Transparent;
    appearance129.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.cboSource.DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance129;
    appearance130.ImageHAlign = (HAlign) 2;
    appearance130.ImageVAlign = (VAlign) 2;
    this.cboSource.DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance130;
    this.cboSource.DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    this.cboSource.DisplayLayout.Override.CellPadding = 0;
    appearance131.ImageHAlign = (HAlign) 2;
    appearance131.ImageVAlign = (VAlign) 2;
    this.cboSource.DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance131;
    appearance132.BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    appearance132.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.cboSource.DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance132;
    this.cboSource.DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    this.cboSource.DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    appearance133.BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    appearance133.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this.cboSource.DisplayLayout.Override.HotTrackRowAppearance = (AppearanceBase) appearance133;
    appearance134.BackColor = SystemColors.Window;
    appearance134.BorderColor = Color.White;
    this.cboSource.DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance134;
    this.cboSource.DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    this.cboSource.DisplayLayout.Override.RowSpacingAfter = 1;
    appearance135.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance135.BorderColor = Color.FromArgb((int) byte.MaxValue, 214, 88);
    appearance135.ForeColor = Color.Black;
    this.cboSource.DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance135;
    appearance136.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance136.Image"));
    this.cboSource.DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance136;
    scrollBarLook7.ViewStyle = (ScrollBarViewStyle) 3;
    this.cboSource.DisplayLayout.ScrollBarLook = scrollBarLook7;
    this.cboSource.DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    this.cboSource.DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    this.cboSource.DisplayLayout.ViewStyleBand = (ViewStyleBand) 2;
    ((UltraDropDownBase) this.cboSource).DisplayMember = "Source";
    this.cboSource.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboSource).DropDownWidth = 350;
    ((Control) this.cboSource).Location = new Point(131, 61);
    this.cboSource.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboSource).Name = "cboSource";
    ((Control) this.cboSource).Size = new Size(232, 21);
    ((Control) this.cboSource).TabIndex = 2;
    ((UltraControlBase) this.cboSource).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboSource).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboSource).ValueMember = "ID";
    this.lblOwner.AutoSize = true;
    this.lblOwner.BackColor = Color.Transparent;
    this.lblOwner.Location = new Point(5, 93);
    this.lblOwner.Name = "lblOwner";
    this.lblOwner.Size = new Size(43, 13);
    this.lblOwner.TabIndex = 474;
    this.lblOwner.Text = "Owner:";
    this.lblOwner.TextAlign = ContentAlignment.MiddleLeft;
    this.lblGWP.AutoSize = true;
    this.lblGWP.BackColor = Color.Transparent;
    this.lblGWP.Location = new Point(5, 38);
    this.lblGWP.Name = "lblGWP";
    this.lblGWP.Size = new Size(120, 13);
    this.lblGWP.TabIndex = 469;
    this.lblGWP.Text = "Gross Written Premium:";
    this.lblGWP.TextAlign = ContentAlignment.MiddleLeft;
    this.lblEmployees.AutoSize = true;
    this.lblEmployees.BackColor = Color.Transparent;
    this.lblEmployees.Location = new Point(5, 11);
    this.lblEmployees.Name = "lblEmployees";
    this.lblEmployees.Size = new Size(73, 13);
    this.lblEmployees.TabIndex = 468;
    this.lblEmployees.Text = "# Employees:";
    this.lblEmployees.TextAlign = ContentAlignment.MiddleLeft;
    appearance137.BackColor = SystemColors.Window;
    appearance137.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.numGWP).Appearance = (AppearanceBase) appearance137;
    ((UltraNumericEditorBase) this.numGWP).BackColor = SystemColors.Window;
    ((Control) this.numGWP).DataBindings.Add(new Binding("Value", (object) this.dsProducer, "tblProducerLocations.GrossWrittenPremium", true));
    ((UltraNumericEditorBase) this.numGWP).FormatString = "c";
    ((Control) this.numGWP).Location = new Point(131, 34);
    this.numGWP.MaxValue = (object) new Decimal(new int[4]
    {
      276447231,
      23283,
      0,
      0
    });
    this.numGWP.MGAStyle = MGAStyles.Blue;
    this.numGWP.MinValue = (object) 0;
    ((Control) this.numGWP).Name = "numGWP";
    this.numGWP.Nullable = true;
    this.numGWP.NumericType = (NumericType) 2;
    ((Control) this.numGWP).Size = new Size(148, 20);
    ((Control) this.numGWP).TabIndex = 1;
    ((UltraControlBase) this.numGWP).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numGWP).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraNumericEditorBase) this.numEmployees).Appearance = (AppearanceBase) appearance122;
    ((UltraNumericEditorBase) this.numEmployees).BackColor = SystemColors.ControlLight;
    ((Control) this.numEmployees).DataBindings.Add(new Binding("Value", (object) this.dsProducer, "tblProducerLocations.NumEmployees", true));
    ((UltraNumericEditorBase) this.numEmployees).FormatString = "";
    ((Control) this.numEmployees).Location = new Point(131, 7);
    this.numEmployees.MaxValue = (object) 99999;
    this.numEmployees.MGAStyle = MGAStyles.Blue;
    this.numEmployees.MinValue = (object) 0;
    ((Control) this.numEmployees).Name = "numEmployees";
    this.numEmployees.Nullable = true;
    ((Control) this.numEmployees).Size = new Size(77, 20);
    ((Control) this.numEmployees).TabIndex = 0;
    ((UltraControlBase) this.numEmployees).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numEmployees).UseOsThemes = (DefaultableBoolean) 2;
    this.numEmployees.Value = (object) null;
    ((Control) this.tabCallReport).Controls.Add((Control) this.btnReport);
    ((Control) this.tabCallReport).Controls.Add((Control) this.ugDetails);
    ((Control) this.tabCallReport).Location = new Point(-10000, -10000);
    ((Control) this.tabCallReport).Name = "tabCallReport";
    ((Control) this.tabCallReport).Size = new Size(876, 341);
    ((Control) this.btnReport).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    appearance138.BackColor = Color.FromArgb(248, 248, 248);
    appearance138.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance138.BackGradientStyle = (GradientStyle) 2;
    appearance138.BorderColor = Color.DarkGray;
    appearance138.ImageHAlign = (HAlign) 2;
    appearance138.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnReport).Appearance = (AppearanceBase) appearance138;
    ((Control) this.btnReport).Location = new Point(688, 12);
    ((Control) this.btnReport).Margin = new Padding(4);
    ((Control) this.btnReport).Name = "btnReport";
    ((Control) this.btnReport).Size = new Size(126, 33);
    ((Control) this.btnReport).TabIndex = 245;
    ((ControlBase) this.btnReport).Text = "Add Call Report";
    this.btnReport.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.ugDetails).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraControlBase) this.ugDetails).Cursor = Cursors.Hand;
    ((UltraGridBase) this.ugDetails).DataSource = (object) this.dvCallReports;
    appearance139.BackColor = Color.White;
    appearance139.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ugDetails).DisplayLayout.Appearance = (AppearanceBase) appearance139;
    ((UltraGridBase) this.ugDetails).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand8.AddButtonCaption = "Details";
    ultraGridColumn76.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn76.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn76.Header.VisiblePosition = 0;
    ultraGridColumn76.Hidden = true;
    ultraGridColumn76.Width = 49;
    ultraGridColumn77.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn77.Header).Caption = "Date Of Visit";
    ((HeaderBase) ultraGridColumn77.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn77.Header.VisiblePosition = 1;
    ultraGridColumn77.Width = 101;
    ultraGridColumn78.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn78.Header).Caption = "Call Type";
    ((HeaderBase) ultraGridColumn78.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn78.Header.VisiblePosition = 2;
    ultraGridColumn78.Width = 328;
    ultraGridColumn79.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn79.Header).Caption = "Lead Contact";
    ((HeaderBase) ultraGridColumn79.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn79.Header.VisiblePosition = 3;
    ultraGridColumn79.Width = 221;
    ultraGridColumn80.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn80.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn80.Header.VisiblePosition = 4;
    ultraGridColumn80.Hidden = true;
    ultraGridColumn80.Width = 85;
    ultraGridColumn81.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn81.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn81.Header.VisiblePosition = 5;
    ultraGridColumn81.Hidden = true;
    ultraGridColumn81.Width = 216;
    ultraGridBand8.Columns.AddRange(new object[6]
    {
      (object) ultraGridColumn76,
      (object) ultraGridColumn77,
      (object) ultraGridColumn78,
      (object) ultraGridColumn79,
      (object) ultraGridColumn80,
      (object) ultraGridColumn81
    });
    ((UltraGridBase) this.ugDetails).DisplayLayout.BandsSerializer.Add((object) ultraGridBand8);
    ((UltraGridBase) this.ugDetails).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance140.BackColor = Color.LightSteelBlue;
    appearance140.FontData.SizeInPoints = 10f;
    appearance140.ForeColor = Color.Black;
    ((UltraGridBase) this.ugDetails).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance140;
    appearance141.BackColor = Color.White;
    appearance141.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance141.ForeColor = Color.Black;
    ((UltraGridBase) this.ugDetails).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance141;
    ((UltraGridBase) this.ugDetails).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.ugDetails).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.ugDetails).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    appearance142.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugDetails).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance142;
    ((UltraGridBase) this.ugDetails).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    appearance143.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ugDetails).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance143;
    ((UltraGridBase) this.ugDetails).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance144.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ugDetails).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance144;
    appearance145.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugDetails).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance145;
    ((UltraGridBase) this.ugDetails).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance146.BackColor = Color.Transparent;
    appearance146.ForeColor = Color.Black;
    ((UltraGridBase) this.ugDetails).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance146;
    ((UltraGridBase) this.ugDetails).DisplayLayout.Override.SelectTypeCell = (SelectType) 2;
    scrollBarLook8.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.ugDetails).DisplayLayout.ScrollBarLook = scrollBarLook8;
    ((Control) this.ugDetails).Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.ugDetails).Location = new Point(17, 12);
    ((Control) this.ugDetails).Name = "ugDetails";
    ((Control) this.ugDetails).Size = new Size(652, 267);
    ((Control) this.ugDetails).TabIndex = 6;
    ((Control) this.ugDetails).Text = "Available Call Reports";
    ((UltraControlBase) this.ugDetails).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ugDetails).UseOsThemes = (DefaultableBoolean) 2;
    this.dvCallReports.Table = (DataTable) this.dsProducer.tblProducerCallReport;
    ((Control) this.tabLogo).Controls.Add((Control) this.pbLogo);
    ((Control) this.tabLogo).Controls.Add((Control) this.btnNewImage);
    ((Control) this.tabLogo).Location = new Point(-10000, -10000);
    ((Control) this.tabLogo).Name = "tabLogo";
    ((Control) this.tabLogo).Size = new Size(876, 341);
    this.pbLogo.DataBindings.Add(new Binding("Image", (object) this.dsProducer, "tblProducers.Logo", true));
    this.pbLogo.Location = new Point(486, 14);
    this.pbLogo.Name = "pbLogo";
    this.pbLogo.Size = new Size(120, 90);
    this.pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
    this.pbLogo.TabIndex = 33;
    this.pbLogo.TabStop = false;
    ((Control) this.btnNewImage).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    appearance147.BackColor = Color.FromArgb(248, 248, 248);
    appearance147.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance147.BackGradientStyle = (GradientStyle) 2;
    appearance147.BorderColor = Color.DarkGray;
    ((ControlBase) this.btnNewImage).Appearance = (AppearanceBase) appearance147;
    ((ControlBase) this.btnNewImage).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnNewImage).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnNewImage).Location = new Point(625, 14);
    ((Control) this.btnNewImage).Name = "btnNewImage";
    ((Control) this.btnNewImage).Size = new Size(40, 40);
    ((Control) this.btnNewImage).TabIndex = 32 /*0x20*/;
    this.btnNewImage.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.tabSirconInfo).Controls.Add((Control) this.lblSirconStatus);
    ((Control) this.tabSirconInfo).Controls.Add((Control) this.tbSirconStatus);
    ((Control) this.tabSirconInfo).Controls.Add((Control) this.tbSirconMsg);
    ((Control) this.tabSirconInfo).Controls.Add((Control) this.lblOrgNPN);
    ((Control) this.tabSirconInfo).Controls.Add((Control) this.tbOrgNPN);
    ((Control) this.tabSirconInfo).Controls.Add((Control) this.lblLicenses);
    ((Control) this.tabSirconInfo).Controls.Add((Control) this.lblLOAs);
    ((Control) this.tabSirconInfo).Controls.Add((Control) this.SirconLicenseGrid);
    ((Control) this.tabSirconInfo).Controls.Add((Control) this.SirconLOAGrid);
    ((Control) this.tabSirconInfo).Controls.Add((Control) this.lblRecords);
    ((Control) this.tabSirconInfo).Controls.Add((Control) this.btnDelete);
    ((Control) this.tabSirconInfo).Controls.Add((Control) this.btnPrev);
    ((Control) this.tabSirconInfo).Controls.Add((Control) this.btnNext);
    ((Control) this.tabSirconInfo).Controls.Add((Control) this.btnLast);
    ((Control) this.tabSirconInfo).Controls.Add((Control) this.btnFirst);
    ((Control) this.tabSirconInfo).Controls.Add((Control) this.btnNewProducerLocation);
    ((Control) this.tabSirconInfo).Location = new Point(1, 26);
    ((Control) this.tabSirconInfo).Name = "tabSirconInfo";
    ((Control) this.tabSirconInfo).Size = new Size(876, 341);
    this.lblSirconStatus.AutoSize = true;
    this.lblSirconStatus.Location = new Point(22, (int) byte.MaxValue);
    this.lblSirconStatus.Name = "lblSirconStatus";
    this.lblSirconStatus.Size = new Size(70, 13);
    this.lblSirconStatus.TabIndex = 62;
    this.lblSirconStatus.Text = "Sircon Status";
    this.tbSirconStatus.Location = new Point(22, 272);
    this.tbSirconStatus.Name = "tbSirconStatus";
    this.tbSirconStatus.ReadOnly = true;
    this.tbSirconStatus.Size = new Size(152, 21);
    this.tbSirconStatus.TabIndex = 51;
    this.tbSirconMsg.Location = new Point(22, 300);
    this.tbSirconMsg.Multiline = true;
    this.tbSirconMsg.Name = "tbSirconMsg";
    this.tbSirconMsg.ReadOnly = true;
    this.tbSirconMsg.ScrollBars = ScrollBars.Vertical;
    this.tbSirconMsg.Size = new Size(487, 38);
    this.tbSirconMsg.TabIndex = 50;
    this.lblOrgNPN.AutoSize = true;
    this.lblOrgNPN.Location = new Point(340, (int) byte.MaxValue);
    this.lblOrgNPN.Name = "lblOrgNPN";
    this.lblOrgNPN.Size = new Size(73, 13);
    this.lblOrgNPN.TabIndex = 48 /*0x30*/;
    this.lblOrgNPN.Text = "Agency's NPN";
    this.tbOrgNPN.Location = new Point(340, 272);
    this.tbOrgNPN.Name = "tbOrgNPN";
    this.tbOrgNPN.ReadOnly = true;
    this.tbOrgNPN.Size = new Size(169, 21);
    this.tbOrgNPN.TabIndex = 45;
    this.lblLicenses.AutoSize = true;
    this.lblLicenses.Location = new Point(22, (int) sbyte.MaxValue);
    this.lblLicenses.Name = "lblLicenses";
    this.lblLicenses.Size = new Size(47, 13);
    this.lblLicenses.TabIndex = 42;
    this.lblLicenses.Text = "Licenses";
    this.lblLOAs.AutoSize = true;
    this.lblLOAs.Location = new Point(22, 4);
    this.lblLOAs.Name = "lblLOAs";
    this.lblLOAs.Size = new Size(32 /*0x20*/, 13);
    this.lblLOAs.TabIndex = 41;
    this.lblLOAs.Text = "LOAs";
    ((UltraGridBase) this.SirconLicenseGrid).DataMember = "tblSirconLicenses";
    ((UltraGridBase) this.SirconLicenseGrid).DataSource = (object) this.DsSirconDataSetBindingSource1;
    appearance148.BackColor = SystemColors.Window;
    appearance148.BorderColor = SystemColors.InactiveCaption;
    ((UltraGridBase) this.SirconLicenseGrid).DisplayLayout.Appearance = (AppearanceBase) appearance148;
    ((HeaderBase) ultraGridColumn82.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn82.Header.VisiblePosition = 0;
    ((HeaderBase) ultraGridColumn83.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn83.Header.VisiblePosition = 1;
    ((HeaderBase) ultraGridColumn84.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn84.Header.VisiblePosition = 2;
    ((HeaderBase) ultraGridColumn85.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn85.Header.VisiblePosition = 3;
    ((HeaderBase) ultraGridColumn86.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn86.Header.VisiblePosition = 4;
    ultraGridBand9.Columns.AddRange(new object[5]
    {
      (object) ultraGridColumn82,
      (object) ultraGridColumn83,
      (object) ultraGridColumn84,
      (object) ultraGridColumn85,
      (object) ultraGridColumn86
    });
    ((UltraGridBase) this.SirconLicenseGrid).DisplayLayout.BandsSerializer.Add((object) ultraGridBand9);
    ((UltraGridBase) this.SirconLicenseGrid).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.SirconLicenseGrid).DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    appearance149.BackColor = SystemColors.ActiveBorder;
    appearance149.BackColor2 = SystemColors.ControlDark;
    appearance149.BackGradientStyle = (GradientStyle) 2;
    appearance149.BorderColor = SystemColors.Window;
    ((SpecialBoxBase) ((UltraGridBase) this.SirconLicenseGrid).DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance149;
    appearance150.ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.SirconLicenseGrid).DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance150;
    ((SpecialBoxBase) ((UltraGridBase) this.SirconLicenseGrid).DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    appearance151.BackColor = SystemColors.ControlLightLight;
    appearance151.BackColor2 = SystemColors.Control;
    appearance151.BackGradientStyle = (GradientStyle) 3;
    appearance151.ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.SirconLicenseGrid).DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance151;
    ((UltraGridBase) this.SirconLicenseGrid).DisplayLayout.MaxColScrollRegions = 1;
    ((UltraGridBase) this.SirconLicenseGrid).DisplayLayout.MaxRowScrollRegions = 1;
    appearance152.BackColor = SystemColors.Window;
    appearance152.ForeColor = SystemColors.ControlText;
    ((UltraGridBase) this.SirconLicenseGrid).DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance152;
    appearance153.BackColor = SystemColors.Highlight;
    appearance153.ForeColor = SystemColors.HighlightText;
    ((UltraGridBase) this.SirconLicenseGrid).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance153;
    ((UltraGridBase) this.SirconLicenseGrid).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((UltraGridBase) this.SirconLicenseGrid).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 2;
    ((UltraGridBase) this.SirconLicenseGrid).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 2;
    appearance154.BackColor = SystemColors.Window;
    ((UltraGridBase) this.SirconLicenseGrid).DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance154;
    appearance155.BorderColor = Color.Silver;
    appearance155.TextTrimming = (TextTrimming) 3;
    ((UltraGridBase) this.SirconLicenseGrid).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance155;
    ((UltraGridBase) this.SirconLicenseGrid).DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    ((UltraGridBase) this.SirconLicenseGrid).DisplayLayout.Override.CellPadding = 0;
    appearance156.BackColor = SystemColors.Control;
    appearance156.BackColor2 = SystemColors.ControlDark;
    appearance156.BackGradientAlignment = (GradientAlignment) 1;
    appearance156.BackGradientStyle = (GradientStyle) 3;
    appearance156.BorderColor = SystemColors.Window;
    ((UltraGridBase) this.SirconLicenseGrid).DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance156;
    ((AppearanceBase) appearance157).TextHAlignAsString = "Left";
    ((UltraGridBase) this.SirconLicenseGrid).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance157;
    ((UltraGridBase) this.SirconLicenseGrid).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    ((UltraGridBase) this.SirconLicenseGrid).DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    appearance158.BackColor = SystemColors.Window;
    appearance158.BorderColor = Color.Silver;
    ((UltraGridBase) this.SirconLicenseGrid).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance158;
    ((UltraGridBase) this.SirconLicenseGrid).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance159.BackColor = SystemColors.ControlLight;
    ((UltraGridBase) this.SirconLicenseGrid).DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance159;
    ((UltraGridBase) this.SirconLicenseGrid).DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    ((UltraGridBase) this.SirconLicenseGrid).DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    ((Control) this.SirconLicenseGrid).Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.SirconLicenseGrid).Location = new Point(22, 143);
    ((Control) this.SirconLicenseGrid).Name = "SirconLicenseGrid";
    ((Control) this.SirconLicenseGrid).Size = new Size(491, 101);
    ((Control) this.SirconLicenseGrid).TabIndex = 40;
    ((Control) this.SirconLicenseGrid).Text = "SirconLicenseGrid";
    ((UltraControlBase) this.SirconLicenseGrid).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.SirconLicenseGrid).UseOsThemes = (DefaultableBoolean) 2;
    this.DsSirconDataSetBindingSource1.DataSource = (object) this.DsSirconDataSet;
    this.DsSirconDataSetBindingSource1.Position = 0;
    this.DsSirconDataSet.DataSetName = "dsSirconDataSet";
    this.DsSirconDataSet.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((UltraGridBase) this.SirconLOAGrid).DataMember = "tblSirconLOAs";
    ((UltraGridBase) this.SirconLOAGrid).DataSource = (object) this.DsSirconDataSetBindingSource;
    appearance160.BackColor = SystemColors.Window;
    appearance160.BorderColor = SystemColors.InactiveCaption;
    ((UltraGridBase) this.SirconLOAGrid).DisplayLayout.Appearance = (AppearanceBase) appearance160;
    ((HeaderBase) ultraGridColumn87.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn87.Header.VisiblePosition = 0;
    ((HeaderBase) ultraGridColumn88.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn88.Header.VisiblePosition = 1;
    ((HeaderBase) ultraGridColumn89.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn89.Header.VisiblePosition = 2;
    ((HeaderBase) ultraGridColumn90.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn90.Header.VisiblePosition = 3;
    ((HeaderBase) ultraGridColumn91.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn91.Header.VisiblePosition = 4;
    ultraGridBand10.Columns.AddRange(new object[5]
    {
      (object) ultraGridColumn87,
      (object) ultraGridColumn88,
      (object) ultraGridColumn89,
      (object) ultraGridColumn90,
      (object) ultraGridColumn91
    });
    ((UltraGridBase) this.SirconLOAGrid).DisplayLayout.BandsSerializer.Add((object) ultraGridBand10);
    ((UltraGridBase) this.SirconLOAGrid).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.SirconLOAGrid).DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    appearance161.BackColor = SystemColors.ActiveBorder;
    appearance161.BackColor2 = SystemColors.ControlDark;
    appearance161.BackGradientStyle = (GradientStyle) 2;
    appearance161.BorderColor = SystemColors.Window;
    ((SpecialBoxBase) ((UltraGridBase) this.SirconLOAGrid).DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance161;
    appearance162.ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.SirconLOAGrid).DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance162;
    ((SpecialBoxBase) ((UltraGridBase) this.SirconLOAGrid).DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    appearance163.BackColor = SystemColors.ControlLightLight;
    appearance163.BackColor2 = SystemColors.Control;
    appearance163.BackGradientStyle = (GradientStyle) 3;
    appearance163.ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.SirconLOAGrid).DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance163;
    ((UltraGridBase) this.SirconLOAGrid).DisplayLayout.MaxColScrollRegions = 1;
    ((UltraGridBase) this.SirconLOAGrid).DisplayLayout.MaxRowScrollRegions = 1;
    appearance164.BackColor = SystemColors.Window;
    appearance164.ForeColor = SystemColors.ControlText;
    ((UltraGridBase) this.SirconLOAGrid).DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance164;
    appearance165.BackColor = SystemColors.Highlight;
    appearance165.ForeColor = SystemColors.HighlightText;
    ((UltraGridBase) this.SirconLOAGrid).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance165;
    ((UltraGridBase) this.SirconLOAGrid).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((UltraGridBase) this.SirconLOAGrid).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 2;
    ((UltraGridBase) this.SirconLOAGrid).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 2;
    appearance166.BackColor = SystemColors.Window;
    ((UltraGridBase) this.SirconLOAGrid).DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance166;
    appearance167.BorderColor = Color.Silver;
    appearance167.TextTrimming = (TextTrimming) 3;
    ((UltraGridBase) this.SirconLOAGrid).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance167;
    ((UltraGridBase) this.SirconLOAGrid).DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    ((UltraGridBase) this.SirconLOAGrid).DisplayLayout.Override.CellPadding = 0;
    appearance168.BackColor = SystemColors.Control;
    appearance168.BackColor2 = SystemColors.ControlDark;
    appearance168.BackGradientAlignment = (GradientAlignment) 1;
    appearance168.BackGradientStyle = (GradientStyle) 3;
    appearance168.BorderColor = SystemColors.Window;
    ((UltraGridBase) this.SirconLOAGrid).DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance168;
    ((AppearanceBase) appearance169).TextHAlignAsString = "Left";
    ((UltraGridBase) this.SirconLOAGrid).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance169;
    ((UltraGridBase) this.SirconLOAGrid).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    ((UltraGridBase) this.SirconLOAGrid).DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    appearance170.BackColor = SystemColors.Window;
    appearance170.BorderColor = Color.Silver;
    ((UltraGridBase) this.SirconLOAGrid).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance170;
    ((UltraGridBase) this.SirconLOAGrid).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance171.BackColor = SystemColors.ControlLight;
    ((UltraGridBase) this.SirconLOAGrid).DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance171;
    ((UltraGridBase) this.SirconLOAGrid).DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    ((UltraGridBase) this.SirconLOAGrid).DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    ((Control) this.SirconLOAGrid).Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.SirconLOAGrid).Location = new Point(22, 20);
    ((Control) this.SirconLOAGrid).Name = "SirconLOAGrid";
    ((Control) this.SirconLOAGrid).Size = new Size(491, 99);
    ((Control) this.SirconLOAGrid).TabIndex = 39;
    ((Control) this.SirconLOAGrid).Text = "SirconLOAGrid";
    ((UltraControlBase) this.SirconLOAGrid).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.SirconLOAGrid).UseOsThemes = (DefaultableBoolean) 2;
    this.DsSirconDataSetBindingSource.DataSource = (object) this.DsSirconDataSet;
    this.DsSirconDataSetBindingSource.Position = 0;
    this.dbSave.AutoQueryRowCountOnLoad = false;
    this.dbSave.EditStyle = EditStyle.ShowEditButton;
    this.dbSave.FreezeEvents = false;
    this.dbSave.Location = new Point(532, 48 /*0x30*/);
    this.dbSave.Name = "dbSave";
    this.dbSave.Size = new Size(112 /*0x70*/, 40);
    this.dbSave.TabIndex = 2;
    this.cnSQL.ConnectionString = "Data Source=d-dc02db11.rsgcorp.local,1433;Initial Catalog=IMS;User ID=ims_rsg";
    this.cnSQL.FireInfoMessageEventOnUserErrors = false;
    this.daContacts.SelectCommand = this.SqlSelectCommand5;
    this.daContacts.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblProducerContacts", new DataColumnMapping[3]
      {
        new DataColumnMapping("ProducerContactGUID", "ProducerContactGUID"),
        new DataColumnMapping("Name", "Name"),
        new DataColumnMapping("StatusID", "StatusID")
      })
    });
    this.SqlSelectCommand5.CommandText = "SELECT ProducerContactGUID, LName + ', ' + FName AS Name, StatusID FROM tblProducerContacts  WHERE (ProducerLocationGUID = @ProducerLocationGuid) ORDER BY LName";
    this.SqlSelectCommand5.Connection = this.cnSQL;
    this.SqlSelectCommand5.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@ProducerLocationGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "ProducerLocationGUID")
    });
    appearance172.BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    appearance172.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.gbProducer.ContentAreaAppearance = (AppearanceBase) appearance172;
    ((Control) this.gbProducer).Controls.Add((Control) this.lblProducerCode);
    ((Control) this.gbProducer).Controls.Add((Control) this.Label10);
    ((Control) this.gbProducer).Controls.Add((Control) this.Label1);
    ((Control) this.gbProducer).Controls.Add((Control) this.txtProducerName);
    ((Control) this.gbProducer).Controls.Add((Control) this.cboBusinessTypes);
    ((Control) this.gbProducer).Controls.Add((Control) this.Label5);
    appearance173.ForeColor = Color.Black;
    this.gbProducer.HeaderAppearance = (AppearanceBase) appearance173;
    ((Control) this.gbProducer).Location = new Point(17, 16 /*0x10*/);
    ((Control) this.gbProducer).Name = "gbProducer";
    ((Control) this.gbProducer).Size = new Size(509, 72);
    ((Control) this.gbProducer).TabIndex = 0;
    this.gbProducer.Text = "Producer";
    appearance174.BackColor = Color.Transparent;
    appearance174.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((ControlBase) this.lblProducerCode).Appearance = (AppearanceBase) appearance174;
    ((ControlBase) this.lblProducerCode).BackColorInternal = Color.WhiteSmoke;
    this.lblProducerCode.BorderStyleOuter = (UIElementBorderStyle) 4;
    ((Control) this.lblProducerCode).DataBindings.Add(new Binding("Text", (object) this.dsProducer, "tblProducers.ProducerCode", true));
    ((Control) this.lblProducerCode).Location = new Point(419, 18);
    ((Control) this.lblProducerCode).Name = "lblProducerCode";
    ((Control) this.lblProducerCode).Size = new Size(72, 20);
    ((Control) this.lblProducerCode).TabIndex = 3;
    this.Label10.AutoSize = true;
    this.Label10.BackColor = Color.Transparent;
    this.Label10.Location = new Point(331, 22);
    this.Label10.Name = "Label10";
    this.Label10.Size = new Size(82, 13);
    this.Label10.TabIndex = 4;
    this.Label10.Text = "Producer Code:";
    this.Label10.TextAlign = ContentAlignment.MiddleRight;
    this.Label1.AutoSize = true;
    this.Label1.BackColor = Color.Transparent;
    this.Label1.Location = new Point(15, 21);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(38, 13);
    this.Label1.TabIndex = 0;
    this.Label1.Text = "Name:";
    this.Label1.TextAlign = ContentAlignment.MiddleRight;
    appearance175.BackColor = Color.White;
    appearance175.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance175.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtProducerName).Appearance = (AppearanceBase) appearance175;
    ((TextEditorControlBase) this.txtProducerName).BackColor = Color.White;
    ((Control) this.txtProducerName).DataBindings.Add(new Binding("Text", (object) this.dsProducer, "tblProducers.ProducerName", true));
    ((Control) this.txtProducerName).Location = new Point(96 /*0x60*/, 18);
    this.txtProducerName.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtProducerName).Name = "txtProducerName";
    ((Control) this.txtProducerName).Size = new Size(184, 20);
    ((Control) this.txtProducerName).TabIndex = 1;
    ((UltraControlBase) this.txtProducerName).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtProducerName).UseOsThemes = (DefaultableBoolean) 2;
    this.cboBusinessTypes.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboBusinessTypes).DataBindings.Add(new Binding("Value", (object) this.dsProducer, "tblProducers.ProducerBusinessTypeID", true));
    ((UltraGridBase) this.cboBusinessTypes).DataSource = (object) this.dsProducer.lstProducerBusinessTypes;
    ((UltraDropDownBase) this.cboBusinessTypes).DisplayMember = "BusinessType";
    this.cboBusinessTypes.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboBusinessTypes).Location = new Point(96 /*0x60*/, 45);
    this.cboBusinessTypes.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboBusinessTypes).Name = "cboBusinessTypes";
    ((Control) this.cboBusinessTypes).Size = new Size(184, 21);
    ((Control) this.cboBusinessTypes).TabIndex = 2;
    ((UltraControlBase) this.cboBusinessTypes).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboBusinessTypes).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboBusinessTypes).ValueMember = "BusinessTypeID";
    this.Label5.AutoSize = true;
    this.Label5.BackColor = Color.Transparent;
    this.Label5.Location = new Point(15, 49);
    this.Label5.Name = "Label5";
    this.Label5.Size = new Size(79, 13);
    this.Label5.TabIndex = 2;
    this.Label5.Text = "Business Type:";
    this.Label5.TextAlign = ContentAlignment.MiddleRight;
    this.daLocations.DeleteCommand = this.SqlDeleteCommand1;
    this.daLocations.InsertCommand = this.SqlInsertCommand1;
    this.daLocations.SelectCommand = this.SqlSelectCommand2;
    this.daLocations.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblProducerLocations", new DataColumnMapping[55]
      {
        new DataColumnMapping("ProducerLocationGUID", "ProducerLocationGUID"),
        new DataColumnMapping("ProducerGUID", "ProducerGUID"),
        new DataColumnMapping("ProducerTypeID", "ProducerTypeID"),
        new DataColumnMapping("LocationCode", "LocationCode"),
        new DataColumnMapping("Name", "Name"),
        new DataColumnMapping("Address1", "Address1"),
        new DataColumnMapping("Address2", "Address2"),
        new DataColumnMapping("ZipPlus", "ZipPlus"),
        new DataColumnMapping("Phone", "Phone"),
        new DataColumnMapping("Fax", "Fax"),
        new DataColumnMapping("FEIN", "FEIN"),
        new DataColumnMapping("DateAdded", "DateAdded"),
        new DataColumnMapping("DeliveryMethodID", "DeliveryMethodID"),
        new DataColumnMapping("LocationTypeID", "LocationTypeID"),
        new DataColumnMapping("StatusID", "StatusID"),
        new DataColumnMapping("WebSite", "WebSite"),
        new DataColumnMapping("City", "City"),
        new DataColumnMapping("County", "County"),
        new DataColumnMapping("State", "State"),
        new DataColumnMapping("ZipCode", "ZipCode"),
        new DataColumnMapping("Email", "Email"),
        new DataColumnMapping("AllowAutomaticNOC", "AllowAutomaticNOC"),
        new DataColumnMapping("Region", "Region"),
        new DataColumnMapping("ISOCountryCode", "ISOCountryCode"),
        new DataColumnMapping("EmailReminders", "EmailReminders"),
        new DataColumnMapping("BillToProducerLocationGuid", "BillToProducerLocationGuid"),
        new DataColumnMapping("MailToProducerLocationGuid", "MailToProducerLocationGuid"),
        new DataColumnMapping("ProducerLocationRegion", "ProducerLocationRegion"),
        new DataColumnMapping("ProducerLocationID", "ProducerLocationID"),
        new DataColumnMapping("NumEmployees", "NumEmployees"),
        new DataColumnMapping("GrossWrittenPremium", "GrossWrittenPremium"),
        new DataColumnMapping("OptOut", "OptOut"),
        new DataColumnMapping("ProductionPotential", "ProductionPotential"),
        new DataColumnMapping("LocationSource", "LocationSource"),
        new DataColumnMapping("Owner", "Owner"),
        new DataColumnMapping("NumWholesaleRelationship", "NumWholesaleRelationship"),
        new DataColumnMapping("WholesaleRelationships", "WholesaleRelationships"),
        new DataColumnMapping("Expertise", "Expertise"),
        new DataColumnMapping("SetProcedureToEnage", "SetProcedureToEnage"),
        new DataColumnMapping("ApproveWholesalersList", "ApproveWholesalersList"),
        new DataColumnMapping("SpecFocusDept", "SpecFocusDept"),
        new DataColumnMapping("AgreementEffectiveDate", "AgreementEffectiveDate"),
        new DataColumnMapping("ProducerRankingID", "ProducerRankingID"),
        new DataColumnMapping("PaymentMethodID", "PaymentMethodID"),
        new DataColumnMapping("OnStatement", "OnStatement"),
        new DataColumnMapping("NPN", "NPN"),
        new DataColumnMapping("ReferredBYProdLocation", "ReferredBYProdLocation"),
        new DataColumnMapping("StatusChangeReasonComment", "StatusChangeReasonComment"),
        new DataColumnMapping("StatusChangeReasonID", "StatusChangeReasonID"),
        new DataColumnMapping("Addedby", "Addedby"),
        new DataColumnMapping("DateModified", "DateModified"),
        new DataColumnMapping("Modifiedby", "Modifiedby"),
        new DataColumnMapping("NameonCheck", "NameonCheck"),
        new DataColumnMapping("CountryCodeforPhone", "CountryCodeforPhone"),
        new DataColumnMapping("CountryCodeforFax", "CountryCodeforFax")
      })
    });
    this.daLocations.UpdateCommand = this.SqlUpdateCommand1;
    this.SqlDeleteCommand1.CommandText = componentResourceManager.GetString("SqlDeleteCommand1.CommandText");
    this.SqlDeleteCommand1.Connection = this.cnSQL;
    this.SqlDeleteCommand1.Parameters.AddRange(new SqlParameter[82]
    {
      new SqlParameter("@Original_ProducerLocationGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ProducerLocationGUID", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_ProducerGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ProducerGUID", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_ProducerTypeID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ProducerTypeID", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_ProducerTypeID", SqlDbType.TinyInt, 1, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ProducerTypeID", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_LocationCode", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "LocationCode", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_LocationCode", SqlDbType.VarChar, 20, ParameterDirection.Input, false, (byte) 0, (byte) 0, "LocationCode", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_Name", SqlDbType.VarChar, 250, ParameterDirection.Input, false, (byte) 0, (byte) 0, "Name", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_Address1", SqlDbType.VarChar, 250, ParameterDirection.Input, false, (byte) 0, (byte) 0, "Address1", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_Address2", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Address2", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_Address2", SqlDbType.VarChar, 250, ParameterDirection.Input, false, (byte) 0, (byte) 0, "Address2", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_ZipPlus", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ZipPlus", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_ZipPlus", SqlDbType.VarChar, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ZipPlus", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_Phone", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Phone", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_Phone", SqlDbType.VarChar, 20, ParameterDirection.Input, false, (byte) 0, (byte) 0, "Phone", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_Fax", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Fax", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_Fax", SqlDbType.VarChar, 20, ParameterDirection.Input, false, (byte) 0, (byte) 0, "Fax", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_FEIN", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FEIN", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_FEIN", SqlDbType.VarChar, 20, ParameterDirection.Input, false, (byte) 0, (byte) 0, "FEIN", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_DateAdded", SqlDbType.DateTime, 8, ParameterDirection.Input, false, (byte) 0, (byte) 0, "DateAdded", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_DeliveryMethodID", SqlDbType.TinyInt, 1, ParameterDirection.Input, false, (byte) 0, (byte) 0, "DeliveryMethodID", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_LocationTypeID", SqlDbType.SmallInt, 2, ParameterDirection.Input, false, (byte) 0, (byte) 0, "LocationTypeID", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_StatusID", SqlDbType.TinyInt, 1, ParameterDirection.Input, false, (byte) 0, (byte) 0, "StatusID", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_WebSite", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "WebSite", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_WebSite", SqlDbType.VarChar, 50, ParameterDirection.Input, false, (byte) 0, (byte) 0, "WebSite", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_City", SqlDbType.VarChar, 50, ParameterDirection.Input, false, (byte) 0, (byte) 0, "City", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_County", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "County", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_County", SqlDbType.VarChar, 50, ParameterDirection.Input, false, (byte) 0, (byte) 0, "County", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_State", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "State", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_State", SqlDbType.Char, 2, ParameterDirection.Input, false, (byte) 0, (byte) 0, "State", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_ZipCode", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ZipCode", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_ZipCode", SqlDbType.VarChar, 5, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ZipCode", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_Email", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Email", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_Email", SqlDbType.VarChar, 50, ParameterDirection.Input, false, (byte) 0, (byte) 0, "Email", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_AllowAutomaticNOC", SqlDbType.Bit, 1, ParameterDirection.Input, false, (byte) 0, (byte) 0, "AllowAutomaticNOC", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_Region", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Region", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_Region", SqlDbType.VarChar, 100, ParameterDirection.Input, false, (byte) 0, (byte) 0, "Region", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_ISOCountryCode", SqlDbType.Char, 3, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ISOCountryCode", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_EmailReminders", SqlDbType.Bit, 1, ParameterDirection.Input, false, (byte) 0, (byte) 0, "EmailReminders", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_BillToProducerLocationGuid", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BillToProducerLocationGuid", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_BillToProducerLocationGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, ParameterDirection.Input, false, (byte) 0, (byte) 0, "BillToProducerLocationGuid", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_MailToProducerLocationGuid", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MailToProducerLocationGuid", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_MailToProducerLocationGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, ParameterDirection.Input, false, (byte) 0, (byte) 0, "MailToProducerLocationGuid", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_ProducerLocationRegion", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ProducerLocationRegion", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_ProducerLocationRegion", SqlDbType.Decimal, 9, ParameterDirection.Input, false, (byte) 10, (byte) 0, "ProducerLocationRegion", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_ProducerLocationID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ProducerLocationID", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_NumEmployees", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "NumEmployees", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_NumEmployees", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "NumEmployees", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_GrossWrittenPremium", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GrossWrittenPremium", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_GrossWrittenPremium", SqlDbType.Money, 8, ParameterDirection.Input, false, (byte) 0, (byte) 0, "GrossWrittenPremium", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_OptOut", SqlDbType.Bit, 1, ParameterDirection.Input, false, (byte) 0, (byte) 0, "OptOut", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_ProductionPotential", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ProductionPotential", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_ProductionPotential", SqlDbType.Char, 1, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ProductionPotential", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_LocationSource", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "LocationSource", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_LocationSource", SqlDbType.TinyInt, 1, ParameterDirection.Input, false, (byte) 0, (byte) 0, "LocationSource", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_Owner", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Owner", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_Owner", SqlDbType.UniqueIdentifier, 16 /*0x10*/, ParameterDirection.Input, false, (byte) 0, (byte) 0, "Owner", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_NumWholesaleRelationship", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "NumWholesaleRelationship", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_NumWholesaleRelationship", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "NumWholesaleRelationship", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_AgreementEffectiveDate", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "AgreementEffectiveDate", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_AgreementEffectiveDate", SqlDbType.DateTime, 8, ParameterDirection.Input, false, (byte) 0, (byte) 0, "AgreementEffectiveDate", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_ProducerRankingID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ProducerRankingID", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_ProducerRankingID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ProducerRankingID", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_PaymentMethodID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PaymentMethodID", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_PaymentMethodID", SqlDbType.TinyInt, 1, ParameterDirection.Input, false, (byte) 0, (byte) 0, "PaymentMethodID", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_OnStatement", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "OnStatement", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_OnStatement", SqlDbType.Bit, 1, ParameterDirection.Input, false, (byte) 0, (byte) 0, "OnStatement", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_NPN", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "NPN", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_NPN", SqlDbType.VarChar, 20, ParameterDirection.Input, false, (byte) 0, (byte) 0, "NPN", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_ReferredBYProdLocation", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ReferredBYProdLocation", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_ReferredBYProdLocation", SqlDbType.UniqueIdentifier, 16 /*0x10*/, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ReferredBYProdLocation", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_StatusChangeReasonComment", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "StatusChangeReasonComment", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_StatusChangeReasonComment", SqlDbType.VarChar, 250, ParameterDirection.Input, false, (byte) 0, (byte) 0, "StatusChangeReasonComment", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_StatusChangeReasonID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "StatusChangeReasonID", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_StatusChangeReasonID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "StatusChangeReasonID", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_Addedby", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Addedby", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_Addedby", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "Addedby", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_DateModified", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "DateModified", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_DateModified", SqlDbType.DateTime, 8, ParameterDirection.Input, false, (byte) 0, (byte) 0, "DateModified", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_Modifiedby", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Modifiedby", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_Modifiedby", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "Modifiedby", DataRowVersion.Original, (object) null),
      new SqlParameter("@isNull_NameonCheck", SqlDbType.VarChar, 1024 /*0x0400*/, ParameterDirection.Input, false, (byte) 0, (byte) 0, "", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_NameOnCheck", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "Modifiedby", DataRowVersion.Original, (object) null)
    });
    this.SqlInsertCommand1.CommandText = componentResourceManager.GetString("SqlInsertCommand1.CommandText");
    this.SqlInsertCommand1.Connection = this.cnSQL;
    this.SqlInsertCommand1.Parameters.AddRange(new SqlParameter[52]
    {
      new SqlParameter("@ProducerLocationGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "ProducerLocationGUID"),
      new SqlParameter("@ProducerGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "ProducerGUID"),
      new SqlParameter("@ProducerTypeID", SqlDbType.TinyInt, 1, "ProducerTypeID"),
      new SqlParameter("@LocationCode", SqlDbType.VarChar, 20, "LocationCode"),
      new SqlParameter("@Name", SqlDbType.VarChar, 250, "Name"),
      new SqlParameter("@Address1", SqlDbType.VarChar, 250, "Address1"),
      new SqlParameter("@Address2", SqlDbType.VarChar, 250, "Address2"),
      new SqlParameter("@ZipPlus", SqlDbType.VarChar, 4, "ZipPlus"),
      new SqlParameter("@Phone", SqlDbType.VarChar, 20, "Phone"),
      new SqlParameter("@Fax", SqlDbType.VarChar, 20, "Fax"),
      new SqlParameter("@FEIN", SqlDbType.VarChar, 20, "FEIN"),
      new SqlParameter("@DateAdded", SqlDbType.DateTime, 8, "DateAdded"),
      new SqlParameter("@DeliveryMethodID", SqlDbType.TinyInt, 1, "DeliveryMethodID"),
      new SqlParameter("@LocationTypeID", SqlDbType.SmallInt, 2, "LocationTypeID"),
      new SqlParameter("@StatusID", SqlDbType.TinyInt, 1, "StatusID"),
      new SqlParameter("@WebSite", SqlDbType.VarChar, 50, "WebSite"),
      new SqlParameter("@City", SqlDbType.VarChar, 50, "City"),
      new SqlParameter("@County", SqlDbType.VarChar, 50, "County"),
      new SqlParameter("@State", SqlDbType.Char, 2, "State"),
      new SqlParameter("@ZipCode", SqlDbType.VarChar, 15, "ZipCode"),
      new SqlParameter("@Email", SqlDbType.VarChar, 50, "Email"),
      new SqlParameter("@AllowAutomaticNOC", SqlDbType.Bit, 1, "AllowAutomaticNOC"),
      new SqlParameter("@Region", SqlDbType.VarChar, 100, "Region"),
      new SqlParameter("@ISOCountryCode", SqlDbType.Char, 3, "ISOCountryCode"),
      new SqlParameter("@EmailReminders", SqlDbType.Bit, 1, "EmailReminders"),
      new SqlParameter("@BillToProducerLocationGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "BillToProducerLocationGuid"),
      new SqlParameter("@MailToProducerLocationGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "MailToProducerLocationGuid"),
      new SqlParameter("@ProducerLocationRegion", SqlDbType.Decimal, 9, ParameterDirection.Input, false, (byte) 10, (byte) 0, "ProducerLocationRegion", DataRowVersion.Current, (object) null),
      new SqlParameter("@NumEmployees", SqlDbType.Int, 4, "NumEmployees"),
      new SqlParameter("@GrossWrittenPremium", SqlDbType.Money, 8, "GrossWrittenPremium"),
      new SqlParameter("@OptOut", SqlDbType.Bit, 1, "OptOut"),
      new SqlParameter("@ProductionPotential", SqlDbType.Char, 1, "ProductionPotential"),
      new SqlParameter("@LocationSource", SqlDbType.TinyInt, 1, "LocationSource"),
      new SqlParameter("@Owner", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "Owner"),
      new SqlParameter("@NumWholesaleRelationship", SqlDbType.Int, 4, "NumWholesaleRelationship"),
      new SqlParameter("@WholesaleRelationships", SqlDbType.Text, int.MaxValue, "WholesaleRelationships"),
      new SqlParameter("@Expertise", SqlDbType.Text, int.MaxValue, "Expertise"),
      new SqlParameter("@SpecFocusDept", SqlDbType.Text, int.MaxValue, "SpecFocusDept"),
      new SqlParameter("@AgreementEffectiveDate", SqlDbType.DateTime, 8, "AgreementEffectiveDate"),
      new SqlParameter("@ProducerRankingID", SqlDbType.Int, 4, "ProducerRankingID"),
      new SqlParameter("@PaymentMethodID", SqlDbType.TinyInt, 1, "PaymentMethodID"),
      new SqlParameter("@OnStatement", SqlDbType.Bit, 1, "OnStatement"),
      new SqlParameter("@NPN", SqlDbType.VarChar, 20, "NPN"),
      new SqlParameter("@ReferredBYProdLocation", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "ReferredBYProdLocation"),
      new SqlParameter("@StatusChangeReasonComment", SqlDbType.VarChar, 250, "StatusChangeReasonComment"),
      new SqlParameter("@StatusChangeReasonID", SqlDbType.Int, 4, "StatusChangeReasonID"),
      new SqlParameter("@Addedby", SqlDbType.Int, 4, "Addedby"),
      new SqlParameter("@DateModified", SqlDbType.DateTime, 8, "DateModified"),
      new SqlParameter("@Modifiedby", SqlDbType.Int, 4, "Modifiedby"),
      new SqlParameter("@NameonCheck", SqlDbType.VarChar, 250, "NameonCheck"),
      new SqlParameter("@CountryCodeforPhone", SqlDbType.VarChar, 5, "CountryCodeforPhone"),
      new SqlParameter("@CountryCodeforFax", SqlDbType.VarChar, 5, "CountryCodeforFax")
    });
    this.SqlSelectCommand2.CommandText = componentResourceManager.GetString("SqlSelectCommand2.CommandText");
    this.SqlSelectCommand2.Connection = this.cnSQL;
    this.SqlSelectCommand2.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@ProducerGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "ProducerGUID")
    });
    this.SqlUpdateCommand1.CommandText = componentResourceManager.GetString("SqlUpdateCommand1.CommandText");
    this.SqlUpdateCommand1.Connection = this.cnSQL;
    this.SqlUpdateCommand1.Parameters.AddRange(new SqlParameter[54]
    {
      new SqlParameter("@ProducerLocationGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "ProducerLocationGUID"),
      new SqlParameter("@ProducerGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "ProducerGUID"),
      new SqlParameter("@ProducerTypeID", SqlDbType.TinyInt, 1, "ProducerTypeID"),
      new SqlParameter("@LocationCode", SqlDbType.VarChar, 20, "LocationCode"),
      new SqlParameter("@Name", SqlDbType.VarChar, 250, "Name"),
      new SqlParameter("@Address1", SqlDbType.VarChar, 250, "Address1"),
      new SqlParameter("@Address2", SqlDbType.VarChar, 250, "Address2"),
      new SqlParameter("@ZipPlus", SqlDbType.VarChar, 4, "ZipPlus"),
      new SqlParameter("@Phone", SqlDbType.VarChar, 20, "Phone"),
      new SqlParameter("@Fax", SqlDbType.VarChar, 20, "Fax"),
      new SqlParameter("@FEIN", SqlDbType.VarChar, 20, "FEIN"),
      new SqlParameter("@DateAdded", SqlDbType.DateTime, 8, "DateAdded"),
      new SqlParameter("@DeliveryMethodID", SqlDbType.TinyInt, 1, "DeliveryMethodID"),
      new SqlParameter("@LocationTypeID", SqlDbType.SmallInt, 2, "LocationTypeID"),
      new SqlParameter("@StatusID", SqlDbType.TinyInt, 1, "StatusID"),
      new SqlParameter("@WebSite", SqlDbType.VarChar, 50, "WebSite"),
      new SqlParameter("@City", SqlDbType.VarChar, 50, "City"),
      new SqlParameter("@County", SqlDbType.VarChar, 50, "County"),
      new SqlParameter("@State", SqlDbType.Char, 2, "State"),
      new SqlParameter("@ZipCode", SqlDbType.VarChar, 15, "ZipCode"),
      new SqlParameter("@Email", SqlDbType.VarChar, 50, "Email"),
      new SqlParameter("@AllowAutomaticNOC", SqlDbType.Bit, 1, "AllowAutomaticNOC"),
      new SqlParameter("@Region", SqlDbType.VarChar, 100, "Region"),
      new SqlParameter("@ISOCountryCode", SqlDbType.Char, 3, "ISOCountryCode"),
      new SqlParameter("@EmailReminders", SqlDbType.Bit, 1, "EmailReminders"),
      new SqlParameter("@BillToProducerLocationGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "BillToProducerLocationGuid"),
      new SqlParameter("@MailToProducerLocationGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "MailToProducerLocationGuid"),
      new SqlParameter("@ProducerLocationRegion", SqlDbType.Decimal, 9, ParameterDirection.Input, false, (byte) 10, (byte) 0, "ProducerLocationRegion", DataRowVersion.Current, (object) null),
      new SqlParameter("@NumEmployees", SqlDbType.Int, 4, "NumEmployees"),
      new SqlParameter("@GrossWrittenPremium", SqlDbType.Money, 8, "GrossWrittenPremium"),
      new SqlParameter("@OptOut", SqlDbType.Bit, 1, "OptOut"),
      new SqlParameter("@ProductionPotential", SqlDbType.Char, 1, "ProductionPotential"),
      new SqlParameter("@LocationSource", SqlDbType.TinyInt, 1, "LocationSource"),
      new SqlParameter("@Owner", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "Owner"),
      new SqlParameter("@NumWholesaleRelationship", SqlDbType.Int, 4, "NumWholesaleRelationship"),
      new SqlParameter("@WholesaleRelationships", SqlDbType.Text, int.MaxValue, "WholesaleRelationships"),
      new SqlParameter("@Expertise", SqlDbType.Text, int.MaxValue, "Expertise"),
      new SqlParameter("@SpecFocusDept", SqlDbType.Text, int.MaxValue, "SpecFocusDept"),
      new SqlParameter("@AgreementEffectiveDate", SqlDbType.DateTime, 8, "AgreementEffectiveDate"),
      new SqlParameter("@ProducerRankingID", SqlDbType.Int, 4, "ProducerRankingID"),
      new SqlParameter("@PaymentMethodID", SqlDbType.TinyInt, 1, "PaymentMethodID"),
      new SqlParameter("@OnStatement", SqlDbType.Bit, 1, "OnStatement"),
      new SqlParameter("@NPN", SqlDbType.VarChar, 20, "NPN"),
      new SqlParameter("@ReferredBYProdLocation", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "ReferredBYProdLocation"),
      new SqlParameter("@StatusChangeReasonComment", SqlDbType.VarChar, 250, "StatusChangeReasonComment"),
      new SqlParameter("@StatusChangeReasonID", SqlDbType.Int, 4, "StatusChangeReasonID"),
      new SqlParameter("@Addedby", SqlDbType.Int, 4, "Addedby"),
      new SqlParameter("@DateModified", SqlDbType.DateTime, 8, "DateModified"),
      new SqlParameter("@Modifiedby", SqlDbType.Int, 4, "Modifiedby"),
      new SqlParameter("@NameonCheck", SqlDbType.VarChar, 250, "NameonCheck"),
      new SqlParameter("@Original_ProducerLocationGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ProducerLocationGUID", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_ProducerGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ProducerGUID", DataRowVersion.Original, (object) null),
      new SqlParameter("@CountryCodeforPhone", SqlDbType.VarChar, 5, "CountryCodeforPhone"),
      new SqlParameter("@CountryCodeforFax", SqlDbType.VarChar, 5, "CountryCodeforFax")
    });
    this.err.ContainerControl = (ContainerControl) this;
    this.menuProducer.DesignerFlags = 1;
    this.menuProducer.DockWithinContainer = (Control) this;
    this.menuProducer.DockWithinContainerBaseType = typeof (Form);
    this.menuProducer.ShowFullMenusDelay = 500;
    ultraToolbar.DockedColumn = 0;
    ultraToolbar.DockedRow = 0;
    ultraToolbar.IsMainMenuBar = true;
    ((UltraToolbarBase) ultraToolbar).NonInheritedTools.AddRange(new ToolBase[1]
    {
      (ToolBase) popupMenuTool1
    });
    ultraToolbar.Text = "MainMenu";
    this.menuProducer.Toolbars.AddRange(new UltraToolbar[1]
    {
      ultraToolbar
    });
    ((ToolPropsBase) ((ToolBase) popupMenuTool2).SharedPropsInternal).Caption = "Producers";
    ((ToolBase) popupMenuTool2).SharedPropsInternal.MergeType = (MenuMergeType) 1;
    ((ToolsCollectionBase) popupMenuTool2.Tools).AddRange(new ToolBase[12]
    {
      (ToolBase) popupMenuTool3,
      (ToolBase) buttonTool1,
      (ToolBase) buttonTool2,
      (ToolBase) buttonTool3,
      (ToolBase) buttonTool4,
      (ToolBase) buttonTool5,
      (ToolBase) buttonTool6,
      (ToolBase) buttonTool7,
      (ToolBase) buttonTool8,
      (ToolBase) buttonTool9,
      (ToolBase) buttonTool10,
      (ToolBase) buttonTool11
    });
    ((ToolPropsBase) ((ToolBase) buttonTool12).SharedPropsInternal).Caption = "Licenses...";
    ((ToolPropsBase) ((ToolBase) buttonTool13).SharedPropsInternal).Caption = "Requirements..";
    ((ToolPropsBase) ((ToolBase) buttonTool14).SharedPropsInternal).Caption = "Producer Lines (For This Location) ...";
    ((ToolPropsBase) ((ToolBase) buttonTool15).SharedPropsInternal).Caption = "Marketing ...";
    ((ToolPropsBase) ((ToolBase) popupMenuTool4).SharedPropsInternal).Caption = "Lines";
    ((ToolsCollectionBase) popupMenuTool4.Tools).AddRange(new ToolBase[2]
    {
      (ToolBase) buttonTool16,
      (ToolBase) buttonTool17
    });
    ((ToolPropsBase) ((ToolBase) buttonTool18).SharedPropsInternal).Caption = "Producer/Underwriter Assignment ...";
    ((ToolPropsBase) ((ToolBase) buttonTool19).SharedPropsInternal).Caption = "Authorize Lines (For Entire Producer) ...";
    ((ToolPropsBase) ((ToolBase) buttonTool20).SharedPropsInternal).Caption = "Move Location To Another Producer ...";
    ((ToolPropsBase) ((ToolBase) buttonTool21).SharedPropsInternal).Caption = "Producer / Location Log ...";
    ((ToolPropsBase) ((ToolBase) buttonTool22).SharedPropsInternal).Caption = "Production Goal...";
    ((ToolPropsBase) ((ToolBase) buttonTool23).SharedPropsInternal).Caption = "User Relationship";
    ((ToolPropsBase) ((ToolBase) buttonTool24).SharedPropsInternal).Caption = "Assign Client Offices";
    ((ToolPropsBase) ((ToolBase) buttonTool25).SharedPropsInternal).Caption = "Producer/Line Blocking";
    ((ToolPropsBase) ((ToolBase) buttonTool26).SharedPropsInternal).Caption = "Assign BillingTypes";
    this.menuProducer.Tools.AddRange(new ToolBase[15]
    {
      (ToolBase) popupMenuTool2,
      (ToolBase) buttonTool12,
      (ToolBase) buttonTool13,
      (ToolBase) buttonTool14,
      (ToolBase) buttonTool15,
      (ToolBase) popupMenuTool4,
      (ToolBase) buttonTool18,
      (ToolBase) buttonTool19,
      (ToolBase) buttonTool20,
      (ToolBase) buttonTool21,
      (ToolBase) buttonTool22,
      (ToolBase) buttonTool23,
      (ToolBase) buttonTool24,
      (ToolBase) buttonTool25,
      (ToolBase) buttonTool26
    });
    ((Control) this._frmProducers_Toolbars_Dock_Area_Left).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._frmProducers_Toolbars_Dock_Area_Left).BackColor = Color.White;
    this._frmProducers_Toolbars_Dock_Area_Left.DockedPosition = (DockedPosition) 2;
    ((Control) this._frmProducers_Toolbars_Dock_Area_Left).ForeColor = Color.Black;
    ((Control) this._frmProducers_Toolbars_Dock_Area_Left).Location = new Point(0, 21);
    ((Control) this._frmProducers_Toolbars_Dock_Area_Left).Name = "_frmProducers_Toolbars_Dock_Area_Left";
    ((Control) this._frmProducers_Toolbars_Dock_Area_Left).Size = new Size(0, 467);
    this._frmProducers_Toolbars_Dock_Area_Left.ToolbarsManager = this.menuProducer;
    ((Control) this._frmProducers_Toolbars_Dock_Area_Right).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._frmProducers_Toolbars_Dock_Area_Right).BackColor = Color.White;
    this._frmProducers_Toolbars_Dock_Area_Right.DockedPosition = (DockedPosition) 3;
    ((Control) this._frmProducers_Toolbars_Dock_Area_Right).ForeColor = Color.Black;
    ((Control) this._frmProducers_Toolbars_Dock_Area_Right).Location = new Point(902, 21);
    ((Control) this._frmProducers_Toolbars_Dock_Area_Right).Name = "_frmProducers_Toolbars_Dock_Area_Right";
    ((Control) this._frmProducers_Toolbars_Dock_Area_Right).Size = new Size(0, 467);
    this._frmProducers_Toolbars_Dock_Area_Right.ToolbarsManager = this.menuProducer;
    ((Control) this._frmProducers_Toolbars_Dock_Area_Top).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._frmProducers_Toolbars_Dock_Area_Top).BackColor = Color.White;
    this._frmProducers_Toolbars_Dock_Area_Top.DockedPosition = (DockedPosition) 0;
    ((Control) this._frmProducers_Toolbars_Dock_Area_Top).ForeColor = Color.Black;
    ((Control) this._frmProducers_Toolbars_Dock_Area_Top).Location = new Point(0, 0);
    ((Control) this._frmProducers_Toolbars_Dock_Area_Top).Name = "_frmProducers_Toolbars_Dock_Area_Top";
    ((Control) this._frmProducers_Toolbars_Dock_Area_Top).Size = new Size(902, 21);
    this._frmProducers_Toolbars_Dock_Area_Top.ToolbarsManager = this.menuProducer;
    ((Control) this._frmProducers_Toolbars_Dock_Area_Bottom).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._frmProducers_Toolbars_Dock_Area_Bottom).BackColor = Color.White;
    this._frmProducers_Toolbars_Dock_Area_Bottom.DockedPosition = (DockedPosition) 1;
    ((Control) this._frmProducers_Toolbars_Dock_Area_Bottom).ForeColor = Color.Black;
    ((Control) this._frmProducers_Toolbars_Dock_Area_Bottom).Location = new Point(0, 488);
    ((Control) this._frmProducers_Toolbars_Dock_Area_Bottom).Name = "_frmProducers_Toolbars_Dock_Area_Bottom";
    ((Control) this._frmProducers_Toolbars_Dock_Area_Bottom).Size = new Size(902, 0);
    this._frmProducers_Toolbars_Dock_Area_Bottom.ToolbarsManager = this.menuProducer;
    this.daProducers.DeleteCommand = this.SqlDeleteCommand2;
    this.daProducers.InsertCommand = this.SqlInsertCommand2;
    this.daProducers.SelectCommand = this.SqlSelectCommand1;
    this.daProducers.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblProducers", new DataColumnMapping[6]
      {
        new DataColumnMapping("ProducerGUID", "ProducerGUID"),
        new DataColumnMapping("ProducerName", "ProducerName"),
        new DataColumnMapping("Closed", "Closed"),
        new DataColumnMapping("ProducerBusinessTypeID", "ProducerBusinessTypeID"),
        new DataColumnMapping("ProducerCode", "ProducerCode"),
        new DataColumnMapping("Logo", "Logo")
      })
    });
    this.daProducers.UpdateCommand = this.SqlUpdateCommand2;
    this.SqlDeleteCommand2.CommandText = "DELETE FROM tblProducers WHERE (ProducerGUID = @Original_ProducerGUID)";
    this.SqlDeleteCommand2.Connection = this.cnSQL;
    this.SqlDeleteCommand2.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@Original_ProducerGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ProducerGUID", DataRowVersion.Original, (object) null)
    });
    this.SqlInsertCommand2.CommandText = "INSERT INTO tblProducers\r\n                         (ProducerGUID, ProducerName, Closed, ProducerBusinessTypeID, Logo)\r\nVALUES        (@ProducerGUID,@ProducerName,@Closed,@ProducerBusinessTypeID,@Logo)";
    this.SqlInsertCommand2.Connection = this.cnSQL;
    this.SqlInsertCommand2.Parameters.AddRange(new SqlParameter[5]
    {
      new SqlParameter("@ProducerGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "ProducerGUID"),
      new SqlParameter("@ProducerName", SqlDbType.VarChar, 100, "ProducerName"),
      new SqlParameter("@Closed", SqlDbType.Bit, 1, "Closed"),
      new SqlParameter("@ProducerBusinessTypeID", SqlDbType.SmallInt, 2, "ProducerBusinessTypeID"),
      new SqlParameter("@Logo", SqlDbType.Image, 0, "Logo")
    });
    this.SqlSelectCommand1.CommandText = "SELECT        ProducerGUID, ProducerName, Closed, ProducerBusinessTypeID, ProducerCode, Logo\r\nFROM            tblProducers\r\nWHERE        (ProducerGUID = @ProducerGuid)";
    this.SqlSelectCommand1.Connection = this.cnSQL;
    this.SqlSelectCommand1.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@ProducerGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "ProducerGUID")
    });
    this.SqlUpdateCommand2.CommandText = componentResourceManager.GetString("SqlUpdateCommand2.CommandText");
    this.SqlUpdateCommand2.Connection = this.cnSQL;
    this.SqlUpdateCommand2.Parameters.AddRange(new SqlParameter[6]
    {
      new SqlParameter("@ProducerGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "ProducerGUID"),
      new SqlParameter("@ProducerName", SqlDbType.VarChar, 100, "ProducerName"),
      new SqlParameter("@Closed", SqlDbType.Bit, 1, "Closed"),
      new SqlParameter("@ProducerBusinessTypeID", SqlDbType.SmallInt, 2, "ProducerBusinessTypeID"),
      new SqlParameter("@Logo", SqlDbType.Image, 0, "Logo"),
      new SqlParameter("@Original_ProducerGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ProducerGUID", DataRowVersion.Original, (object) null)
    });
    ((Control) this.tabLocationInfo).Controls.Add((Control) this.UltraTabSharedControlsPage1);
    ((Control) this.tabLocationInfo).Controls.Add((Control) this.UltraTabPageControl1);
    ((Control) this.tabLocationInfo).Controls.Add((Control) this.UltraTabPageControl2);
    ((Control) this.tabLocationInfo).Controls.Add((Control) this.UltraTabPageControl3);
    ((Control) this.tabLocationInfo).Controls.Add((Control) this.UltraTabPageControl4);
    ((Control) this.tabLocationInfo).Controls.Add((Control) this.tabCRM);
    ((Control) this.tabLocationInfo).Controls.Add((Control) this.tabCallReport);
    ((Control) this.tabLocationInfo).Controls.Add((Control) this.UltraTabPageControl5);
    ((Control) this.tabLocationInfo).Controls.Add((Control) this.tabLogo);
    ((Control) this.tabLocationInfo).Controls.Add((Control) this.tabSirconInfo);
    ((Control) this.tabLocationInfo).Location = new Point(12, 106);
    ((Control) this.tabLocationInfo).Name = "tabLocationInfo";
    ((UltraTabControlBase) this.tabLocationInfo).SharedControls.AddRange(new Control[7]
    {
      (Control) this.lblRecords,
      (Control) this.btnDelete,
      (Control) this.btnPrev,
      (Control) this.btnNext,
      (Control) this.btnLast,
      (Control) this.btnFirst,
      (Control) this.btnNewProducerLocation
    });
    ((UltraTabControlBase) this.tabLocationInfo).SharedControlsPage = this.UltraTabSharedControlsPage1;
    ((Control) this.tabLocationInfo).Size = new Size(878, 368);
    ((Control) this.tabLocationInfo).TabIndex = 0;
    ((UltraTabControlBase) this.tabLocationInfo).TabLayoutStyle = (TabLayoutStyle) 1;
    ((UltraTabControlBase) this.tabLocationInfo).TabPadding = new Size(5, 3);
    appearance176.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance176.Image"));
    ultraTab1.Appearance = (AppearanceBase) appearance176;
    ultraTab1.Key = "tabLocationInfo";
    ultraTab1.TabPage = this.UltraTabPageControl1;
    ultraTab1.Text = "Location Info";
    appearance177.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance177.Image"));
    ultraTab2.Appearance = (AppearanceBase) appearance177;
    ultraTab2.Key = "tabStatistics";
    ultraTab2.TabPage = this.UltraTabPageControl2;
    ultraTab2.Text = "Statistics";
    appearance178.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance178.Image"));
    ultraTab3.Appearance = (AppearanceBase) appearance178;
    ultraTab3.Key = "tabPolicies";
    ultraTab3.TabPage = this.UltraTabPageControl5;
    ultraTab3.Text = "Policies";
    appearance179.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance179.Image"));
    ultraTab4.Appearance = (AppearanceBase) appearance179;
    ultraTab4.Key = "tabContactInfo";
    ultraTab4.TabPage = this.UltraTabPageControl3;
    ultraTab4.Text = "Contact Info";
    appearance180.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance180.Image"));
    ultraTab5.Appearance = (AppearanceBase) appearance180;
    ultraTab5.Key = "tabInvoices";
    ultraTab5.TabPage = this.UltraTabPageControl4;
    ultraTab5.Text = "Invoices";
    appearance181.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance181.Image"));
    ultraTab6.Appearance = (AppearanceBase) appearance181;
    ultraTab6.Key = "tabCRM";
    ultraTab6.TabPage = this.tabCRM;
    ultraTab6.Text = "CRM";
    appearance182.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance182.Image"));
    ultraTab7.Appearance = (AppearanceBase) appearance182;
    ultraTab7.Key = "tabCallReports";
    ultraTab7.TabPage = this.tabCallReport;
    ultraTab7.Text = "Call Reports";
    ultraTab8.Key = "tabLogo";
    ultraTab8.TabPage = this.tabLogo;
    ultraTab8.Text = "Logo";
    ultraTab9.Key = "tabSircon";
    ultraTab9.TabPage = this.tabSirconInfo;
    ultraTab9.Text = "Sircon";
    ((UltraTabControlBase) this.tabLocationInfo).Tabs.AddRange(new UltraTab[9]
    {
      ultraTab1,
      ultraTab2,
      ultraTab3,
      ultraTab4,
      ultraTab5,
      ultraTab6,
      ultraTab7,
      ultraTab8,
      ultraTab9
    });
    ((UltraTabControlBase) this.tabLocationInfo).TabSize = new Size(110, 0);
    ((UltraTabControlBase) this.tabLocationInfo).ViewStyle = (ViewStyle) 4;
    ((Control) this.UltraTabSharedControlsPage1).Controls.Add((Control) this.lblRecords);
    ((Control) this.UltraTabSharedControlsPage1).Controls.Add((Control) this.btnDelete);
    ((Control) this.UltraTabSharedControlsPage1).Controls.Add((Control) this.btnPrev);
    ((Control) this.UltraTabSharedControlsPage1).Controls.Add((Control) this.btnNext);
    ((Control) this.UltraTabSharedControlsPage1).Controls.Add((Control) this.btnLast);
    ((Control) this.UltraTabSharedControlsPage1).Controls.Add((Control) this.btnFirst);
    ((Control) this.UltraTabSharedControlsPage1).Controls.Add((Control) this.btnNewProducerLocation);
    ((Control) this.UltraTabSharedControlsPage1).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabSharedControlsPage1).Name = "UltraTabSharedControlsPage1";
    ((Control) this.UltraTabSharedControlsPage1).Size = new Size(876, 341);
    this.daLoadData.SelectCommand = this.SqlSelectCommand3;
    this.daLoadData.TableMappings.AddRange(new DataTableMapping[5]
    {
      new DataTableMapping("Table", "spGetProducerFormData", new DataColumnMapping[2]
      {
        new DataColumnMapping("ProducerTypeID", "ProducerTypeID"),
        new DataColumnMapping("Description", "Description")
      }),
      new DataTableMapping("Table1", "Table1", new DataColumnMapping[2]
      {
        new DataColumnMapping("DeliveryMethodID", "DeliveryMethodID"),
        new DataColumnMapping("Description", "Description")
      }),
      new DataTableMapping("Table2", "Table2", new DataColumnMapping[3]
      {
        new DataColumnMapping("LocationType", "LocationType"),
        new DataColumnMapping("LocationTypeID", "LocationTypeID"),
        new DataColumnMapping("SortOrder", "SortOrder")
      }),
      new DataTableMapping("Table3", "Table3", new DataColumnMapping[3]
      {
        new DataColumnMapping("StatusID", "StatusID"),
        new DataColumnMapping("Status", "Status"),
        new DataColumnMapping("Disable", "Disable")
      }),
      new DataTableMapping("Table4", "Table4", new DataColumnMapping[2]
      {
        new DataColumnMapping("BusinessTypeID", "BusinessTypeID"),
        new DataColumnMapping("BusinessType", "BusinessType")
      })
    });
    this.SqlSelectCommand3.CommandText = "[spGetProducerFormData]";
    this.SqlSelectCommand3.CommandType = CommandType.StoredProcedure;
    this.SqlSelectCommand3.Connection = this.cnSQL;
    this.SqlSelectCommand3.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null)
    });
    this.daProducerRegion.SelectCommand = this.SqlCommand1;
    this.daProducerRegion.TableMappings.AddRange(new DataTableMapping[5]
    {
      new DataTableMapping("Table", "spGetProducerFormData", new DataColumnMapping[2]
      {
        new DataColumnMapping("ProducerTypeID", "ProducerTypeID"),
        new DataColumnMapping("Description", "Description")
      }),
      new DataTableMapping("Table1", "Table1", new DataColumnMapping[2]
      {
        new DataColumnMapping("DeliveryMethodID", "DeliveryMethodID"),
        new DataColumnMapping("Description", "Description")
      }),
      new DataTableMapping("Table2", "Table2", new DataColumnMapping[3]
      {
        new DataColumnMapping("LocationType", "LocationType"),
        new DataColumnMapping("LocationTypeID", "LocationTypeID"),
        new DataColumnMapping("SortOrder", "SortOrder")
      }),
      new DataTableMapping("Table3", "Table3", new DataColumnMapping[3]
      {
        new DataColumnMapping("StatusID", "StatusID"),
        new DataColumnMapping("Status", "Status"),
        new DataColumnMapping("Disable", "Disable")
      }),
      new DataTableMapping("Table4", "Table4", new DataColumnMapping[2]
      {
        new DataColumnMapping("BusinessTypeID", "BusinessTypeID"),
        new DataColumnMapping("BusinessType", "BusinessType")
      })
    });
    this.SqlCommand1.CommandText = "SELECT ID, ProducerRegion FROM dbo.lstProducerLocationRegions";
    this.SqlCommand1.Connection = this.cnSQL;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.ClientSize = new Size(902, 488);
    this.Controls.Add((Control) this.gbProducer);
    this.Controls.Add((Control) this.dbSave);
    this.Controls.Add((Control) this.tabLocationInfo);
    this.Controls.Add((Control) this._frmProducers_Toolbars_Dock_Area_Left);
    this.Controls.Add((Control) this._frmProducers_Toolbars_Dock_Area_Right);
    this.Controls.Add((Control) this._frmProducers_Toolbars_Dock_Area_Bottom);
    this.Controls.Add((Control) this._frmProducers_Toolbars_Dock_Area_Top);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedSingle;
    this.MaximizeBox = false;
    this.Name = nameof (frmProducers);
    this.StartPosition = FormStartPosition.CenterScreen;
    ((Control) this.UltraTabPageControl1).ResumeLayout(false);
    ((Control) this.UltraTabPageControl1).PerformLayout();
    ((ISupportInitialize) this.txtFax).EndInit();
    this.dsProducer.EndInit();
    ((ISupportInitialize) this.txtPhone).EndInit();
    ((ISupportInitialize) this.mgatxtNameonCheck).EndInit();
    ((ISupportInitialize) this.txtStatusChangeComments).EndInit();
    ((ISupportInitialize) this.cboReason).EndInit();
    ((ISupportInitialize) this.txtNPN).EndInit();
    ((ISupportInitialize) this.chkOnStatement).EndInit();
    ((ISupportInitialize) this.cboPaymentMethod).EndInit();
    ((ISupportInitialize) this.chkOptOut).EndInit();
    ((ISupportInitialize) this.txtGrossWrittenPremium).EndInit();
    ((ISupportInitialize) this.txtNumEmployees).EndInit();
    ((ISupportInitialize) this.MgaTextBox1).EndInit();
    ((ISupportInitialize) this.cboProducerRegion).EndInit();
    ((ISupportInitialize) this.cboMailTo).EndInit();
    ((ISupportInitialize) this.cboBillTo).EndInit();
    ((ISupportInitialize) this.cboDeliveryMethod).EndInit();
    ((ISupportInitialize) this.cbOfficeType).EndInit();
    ((ISupportInitialize) this.cbStatus).EndInit();
    ((ISupportInitialize) this.txtEmail).EndInit();
    ((ISupportInitialize) this.txtFEIN1).EndInit();
    ((ISupportInitialize) this.txtWebSite).EndInit();
    ((ISupportInitialize) this.cboProducerType).EndInit();
    ((ISupportInitialize) this.txtLocation).EndInit();
    ((ISupportInitialize) this.txtCode).EndInit();
    ((ISupportInitialize) this.btnDelete).EndInit();
    ((ISupportInitialize) this.btnPrev).EndInit();
    ((ISupportInitialize) this.btnNext).EndInit();
    ((ISupportInitialize) this.btnLast).EndInit();
    ((ISupportInitialize) this.btnFirst).EndInit();
    ((ISupportInitialize) this.btnNewProducerLocation).EndInit();
    ((Control) this.UltraTabPageControl2).ResumeLayout(false);
    ((Control) this.UltraTabPageControl2).PerformLayout();
    ((ISupportInitialize) this.dtEndDate).EndInit();
    ((ISupportInitialize) this.dtStartDate).EndInit();
    ((ISupportInitialize) this.cboCompanyLines).EndInit();
    ((ISupportInitialize) this.chartStats).EndInit();
    ((Control) this.UltraTabPageControl5).ResumeLayout(false);
    ((ISupportInitialize) this.ugPoliciesGrid).EndInit();
    ((Control) this.UltraTabPageControl3).ResumeLayout(false);
    ((Control) this.UltraTabPageControl3).PerformLayout();
    ((ISupportInitialize) this.grpContactOfac).EndInit();
    ((Control) this.grpContactOfac).ResumeLayout(false);
    ((Control) this.grpContactOfac).PerformLayout();
    ((ISupportInitialize) this.dtOFACClearedDate).EndInit();
    ((ISupportInitialize) this.chkOFACCleared).EndInit();
    ((ISupportInitialize) this.ugOFAC).EndInit();
    ((ISupportInitialize) this.btnNewContact).EndInit();
    ((ISupportInitialize) this.btnSelectContact).EndInit();
    ((ISupportInitialize) this.lstContacts).EndInit();
    ((Control) this.UltraTabPageControl4).ResumeLayout(false);
    ((ISupportInitialize) this.chkEmailReminders).EndInit();
    ((ISupportInitialize) this.chkAutoNOC).EndInit();
    ((Control) this.tabCRM).ResumeLayout(false);
    ((Control) this.tabCRM).PerformLayout();
    ((ISupportInitialize) this.cboProducerlocations).EndInit();
    ((ISupportInitialize) this.MgaComboBox1).EndInit();
    ((ISupportInitialize) this.dtProdAgrrmntEff).EndInit();
    ((ISupportInitialize) this.chkApproveWholesalersList).EndInit();
    ((ISupportInitialize) this.chkSetProcedureToEngage).EndInit();
    ((ISupportInitialize) this.UltraGroupBox2).EndInit();
    ((Control) this.UltraGroupBox2).ResumeLayout(false);
    ((ISupportInitialize) this.UltraGroupBox1).EndInit();
    ((Control) this.UltraGroupBox1).ResumeLayout(false);
    ((ISupportInitialize) this.UltraGroupBox4).EndInit();
    ((Control) this.UltraGroupBox4).ResumeLayout(false);
    ((ISupportInitialize) this.numWholesaleRel).EndInit();
    ((ISupportInitialize) this.cboOwner).EndInit();
    ((ISupportInitialize) this.cboProductionPotential).EndInit();
    ((ISupportInitialize) this.cboSource).EndInit();
    ((ISupportInitialize) this.numGWP).EndInit();
    ((ISupportInitialize) this.numEmployees).EndInit();
    ((Control) this.tabCallReport).ResumeLayout(false);
    ((ISupportInitialize) this.btnReport).EndInit();
    ((ISupportInitialize) this.ugDetails).EndInit();
    this.dvCallReports.EndInit();
    ((Control) this.tabLogo).ResumeLayout(false);
    ((ISupportInitialize) this.pbLogo).EndInit();
    ((ISupportInitialize) this.btnNewImage).EndInit();
    ((Control) this.tabSirconInfo).ResumeLayout(false);
    ((Control) this.tabSirconInfo).PerformLayout();
    ((ISupportInitialize) this.SirconLicenseGrid).EndInit();
    ((ISupportInitialize) this.DsSirconDataSetBindingSource1).EndInit();
    this.DsSirconDataSet.EndInit();
    ((ISupportInitialize) this.SirconLOAGrid).EndInit();
    ((ISupportInitialize) this.DsSirconDataSetBindingSource).EndInit();
    ((ISupportInitialize) this.gbProducer).EndInit();
    ((Control) this.gbProducer).ResumeLayout(false);
    ((Control) this.gbProducer).PerformLayout();
    ((ISupportInitialize) this.txtProducerName).EndInit();
    ((ISupportInitialize) this.cboBusinessTypes).EndInit();
    ((ISupportInitialize) this.err).EndInit();
    ((ISupportInitialize) this.menuProducer).EndInit();
    ((ISupportInitialize) this.tabLocationInfo).EndInit();
    ((Control) this.tabLocationInfo).ResumeLayout(false);
    ((Control) this.UltraTabSharedControlsPage1).ResumeLayout(false);
    this.ResumeLayout(false);
  }

  [field: AccessedThroughProperty("lblOfacClearedUser")]
  protected virtual Label lblOfacClearedUser { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label35")]
  protected virtual Label Label35 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("tabSirconInfo")]
  internal virtual UltraTabPageControl tabSirconInfo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("DsSirconDataSetBindingSource")]
  internal virtual BindingSource DsSirconDataSetBindingSource { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("DsSirconDataSet")]
  internal virtual dsSirconDataSet DsSirconDataSet { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SirconLOAGrid")]
  internal virtual UltraGrid SirconLOAGrid { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SirconLicenseGrid")]
  internal virtual UltraGrid SirconLicenseGrid { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("DsSirconDataSetBindingSource1")]
  internal virtual BindingSource DsSirconDataSetBindingSource1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblLicenses")]
  internal virtual Label lblLicenses { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblLOAs")]
  internal virtual Label lblLOAs { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblOrgNPN")]
  internal virtual Label lblOrgNPN { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("tbOrgNPN")]
  internal virtual TextBox tbOrgNPN { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("tbSirconStatus")]
  internal virtual TextBox tbSirconStatus { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("tbSirconMsg")]
  internal virtual TextBox tbSirconMsg { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblSirconStatus")]
  internal virtual Label lblSirconStatus { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public frmProducers(Guid producerGuid)
    : this()
  {
    this._producerGuid = producerGuid;
  }

  public frmProducers(Guid producerGuid, Guid producerLocationGuid)
    : this(producerGuid)
  {
    this._moveToProducerLocationGuid = producerLocationGuid;
    this._producerLocationGuid = producerLocationGuid;
  }

  public frmProducers()
  {
    this.FormClosing += new FormClosingEventHandler(this.frmProducers_FormClosing);
    this.Load += new EventHandler(this.frmProducers_Load);
    this._showAllContacts = false;
    this._refreshContacts = false;
    this._Client_Existing_Relationship = -10;
    this._EstablishSourceAndOwnerCRM_ProducerRelationShip = false;
    this._isFormLoading = true;
    this._originalProducerName = string.Empty;
    this._showLocationCode = false;
    this._locClosedOnSave = false;
    this._ofacData = new Dictionary<Guid, OfacSystem.OfacStatus>();
    this._validLengthFEIN = 10;
    this.InitializeComponent();
    this.AddCustomMenuItems(this.menuProducer);
    this._phoneTextBoxSize = ((Control) this.txtPhone).Size;
    this.daProducerRegion.SelectCommand.CommandText = this.ProducerRegionsProcedure;
  }

  public Guid ProducerGuid => this._producerGuid;

  private BindingManagerBase bmb
  {
    get
    {
      return this.BindingContext[(object) this.dsProducer, this.dsProducer.tblProducerLocations.TableName];
    }
  }

  protected dsProducers.tblProducerLocationsRow CurrentLocationRow
  {
    get
    {
      return this.bmb.Position != -1 ? this.dsProducer.tblProducerLocations[this.bmb.Position] : (dsProducers.tblProducerLocationsRow) null;
    }
  }

  public int ProducerType
  {
    get
    {
      return string.IsNullOrEmpty(this.cboProducerType.Text) ? int.MinValue : Conversions.ToInteger(this.cboProducerType.Value);
    }
  }

  public bool IsFormLoading => this._isFormLoading;

  public bool RefreshContacts
  {
    get => this._refreshContacts;
    set => this._refreshContacts = value;
  }

  public virtual string ProducerRegionsProcedure => "spGetProducerRegions";

  Guid IRecreatableEntity.ControlGUID => Guid.Empty;

  bool IRecreatableEntity.HasControlGUID => false;

  string IRecreatableEntity.FriendlyEntityName => "Producer";

  string IRecreatableEntity.RecreateTypeName => typeof (frmProducers).ToString();

  public bool CanCreateNewNote
  {
    get
    {
      bool canCreateNewNote;
      try
      {
        canCreateNewNote = this.CurrentLocationRow != null && this.CurrentLocationRow.RowState != DataRowState.Added;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        canCreateNewNote = false;
        ProjectData.ClearProjectError();
      }
      return canCreateNewNote;
    }
  }

  Guid IRecreatableEntity.EntityGUID
  {
    get
    {
      Guid entityGuid;
      try
      {
        entityGuid = this.CurrentLocationRow == null || this.CurrentLocationRow.RowState == DataRowState.Added ? new Guid() : this.CurrentLocationRow.ProducerLocationGUID;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        entityGuid = new Guid();
        ProjectData.ClearProjectError();
      }
      return entityGuid;
    }
  }

  string IRecreatableEntity.EntityName
  {
    get
    {
      return this.CurrentLocationRow == null || this.CurrentLocationRow.RowState == DataRowState.Added ? "New Producer" : this.CurrentLocationRow.Name;
    }
  }

  bool IRecreatableEntity.CanReCreateEntity => true;

  bool IRecreatableEntity.RecreateEntityInitialize(Guid entityGUID)
  {
    ProducerLocation producerLocation = new ProducerLocation(entityGUID);
    bool flag;
    if (!producerLocation.RecordExists())
    {
      flag = false;
    }
    else
    {
      this._producerGuid = producerLocation.ProducerGuid;
      this._producerLocationGuid = entityGUID;
      flag = !this.ProducerGuid.Equals(Guid.Empty);
    }
    return flag;
  }

  private void frmProducers_FormClosing(object sender, FormClosingEventArgs e)
  {
    frmProducers._compLineCache = (dsProducers.CompanyLinesDataTable) null;
  }

  private void frmProducers_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    Cursor.Current = MgaCursors.WaitCursor;
    this.SetupSecurity();
    this._allowOfacSearch = MGASystems.IMS.NoteDocuments.SystemSettings.GetSetting<bool>("OFAC.ProducerContact.AllowSearch", false);
    this._showOfac = MGASystems.IMS.NoteDocuments.SystemSettings.GetSetting<bool>("OFAC.ProducerLocation.ShowInfo", this._allowOfacSearch);
    this._EstablishSourceAndOwnerCRM_ProducerRelationShip = MGASystems.IMS.NoteDocuments.SystemSettings.GetSetting<bool>("EstablishSourceAndOwnerCRM_ProducerRelationShip", false);
    this._showAllContacts = MGASystems.IMS.NoteDocuments.SystemSettings.GetSetting<bool>("ShowAllProducerContactsOnFormLoad", false);
    this._Client_Existing_Relationship = MGASystems.IMS.NoteDocuments.SystemSettings.GetSetting<int>("CLIENT_EXISTING_RELATIONSHIP", -10);
    this._showLocationCode = MGASystems.IMS.NoteDocuments.SystemSettings.GetSetting<bool>("ShowProducerLocationCode", false);
    this.cnSQL.ConnectionString = CurrentUser.Instance.ConnectionString;
    ImageCache instance1 = ImageCache.Instance;
    ((ControlBase) this.btnNewImage).Appearance.Image = (object) instance1.Open;
    ((ControlBase) this.btnNewContact).Appearance.Image = (object) instance1.NewImage;
    ((ControlBase) this.btnSelectContact).Appearance.Image = (object) instance1.Forward;
    ((ControlBase) this.btnNext).Appearance.Image = (object) instance1.MoveNext;
    ((ControlBase) this.btnLast).Appearance.Image = (object) instance1.MoveLast;
    ((ControlBase) this.btnFirst).Appearance.Image = (object) instance1.MoveFirst;
    ((ControlBase) this.btnPrev).Appearance.Image = (object) instance1.MovePrev;
    this.BringToFront();
    this.Refresh();
    this.Loadallproducers();
    this.PopulateDataSet(true);
    MDIControls.Instance.ToolBarManager.BeforeToolDropdown += new BeforeToolDropdownEventHandler(this.menuProducer_BeforeToolDropdown);
    if (!this._showAllContacts)
      this.dsProducer.tblProducerContacts.DefaultView.RowFilter = "StatusID=1";
    ((Control) this.grpContactOfac).Visible = this._showOfac;
    if (this.dsProducer.tblProducerLocations.Rows.Count <= 0 || ((TextEditorControlBase) this.txtLocation).Text.Length == 0)
    {
      ((Control) this.grpContactOfac).Visible = false;
      ((Control) this.btnNewContact).Enabled = false;
      ((Control) this.btnSelectContact).Enabled = false;
      ((Control) this.txtFax).Enabled = false;
      ((Control) this.txtPhone).Enabled = false;
    }
    if (this._producerGuid.Equals(Guid.Empty))
      this.NewProducer();
    this.bmb.PositionChanged += new EventHandler(this.bmb_PositionChanged);
    this.UpdateLocationsNavDisplay();
    DateTime now1 = DateAndTime.Now;
    if (!this._moveToProducerLocationGuid.Equals(Guid.Empty))
    {
      Database.MoveTo((object) this._moveToProducerLocationGuid, "ProducerLocationGuid", (DataTable) this.dsProducer.tblProducerLocations, this.bmb);
      this.dsProducer.AcceptChanges();
    }
    DateTime now2 = DateAndTime.Now;
    this.LoadContacts();
    this.dbSave.UIState = this.dsProducer.tblProducers[0].RowState != DataRowState.Added ? UIState.HasRecordsNotEditing : UIState.Editing;
    this.SetFormControlsEnabledState();
    MDIControls instance2 = MDIControls.Instance;
    instance2.StatusBarText = string.Empty;
    instance2.ProgressPanel.Visible = false;
    Cursor.Current = MgaCursors.Default;
    Note_System.Instance.UIInteractive.ViewPopupNotes(Guid.Empty, this.EntityGUID, (Form) this);
    ((UltraNumericEditorBase) this.numEmployees).Appearance.BackColor = Color.White;
    ((UltraNumericEditorBase) this.numWholesaleRel).Appearance.BackColor = Color.White;
    // ISSUE: reference to a compiler-generated field
    ISupportDocumentSystem.EntityInfoChangedEventHandler infoChangedEvent = this.EntityInfoChangedEvent;
    if (infoChangedEvent != null)
      infoChangedEvent((object) this, EventArgs.Empty);
    // ISSUE: reference to a compiler-generated field
    ISupportNoteSystem.EntityInfoChangedEventHandler infoChanged1Event = this.EntityInfoChanged1Event;
    if (infoChanged1Event != null)
      infoChanged1Event((object) this, EventArgs.Empty);
    if (!this.Text.Equals("New Producer"))
    {
      this._originalProducerBusType = this.dsProducer.tblProducers[0].ProducerBusinessTypeID;
      this._originalProducerName = this.dsProducer.tblProducers[0].ProducerName;
      this._originalProducerStatus = this.dsProducer.tblProducerLocations[0].StatusID;
    }
    this.lstContacts_SelectedIndexChanged((object) null, EventArgs.Empty);
    this.getSirconData();
    this._newProdLocBtnClicked = false;
    this._isFormLoading = false;
    this.ClientAfterLoad();
  }

  protected virtual void ClientAfterLoad()
  {
  }

  protected virtual void StateChanged(string State)
  {
  }

  protected virtual void CountryChanged(string isoCountryCode)
  {
  }

  protected virtual void AddCustomMenuItems(UltraToolbarsManager ProducerMenu)
  {
  }

  protected virtual void AddCRM()
  {
  }

  protected virtual void AddCRM(bool successfullySaved, bool newRecord)
  {
    if (!successfullySaved || !newRecord)
      return;
    this.AddCRM();
  }

  protected virtual void OnProducerTypeValueChange(object sender)
  {
  }

  private void SetupMoveToProducerLocationMenu()
  {
    ((ToolsCollectionBase) this.menuProducer.Tools)["Move Location To Another Producer"].SharedProps.Visible = this.CurrentLocationRow != null;
  }

  private void ctlZipCode_CountryChanged(object sender, EventArgs e)
  {
    this.CountryChanged(this.ctlZipCode.ISOCountryCode);
  }

  private void ctlZipCode_StateChanged(object sender, EventArgs e)
  {
    this.StateChanged(this.ctlZipCode.State);
  }

  private void SetupSecurity()
  {
    ((ToolsCollectionBase) this.menuProducer.Tools)["Producer Lines"].SharedProps.Visible = SecurityManager.Instance.AssertPermission("{4092C509-B8E1-4f32-8C75-FEFC70E6BD11}");
    ((ToolsCollectionBase) this.menuProducer.Tools)["Licenses"].SharedProps.Visible = SecurityManager.Instance.AssertPermission("{4092C509-B8E1-4f32-8C75-FEFC70E6BD11}");
    ((ToolsCollectionBase) this.menuProducer.Tools)["Requirements"].SharedProps.Visible = SecurityManager.Instance.AssertPermission("{31986E19-AE7B-448f-A898-EE86A9CB71AA}");
    ((ToolsCollectionBase) this.menuProducer.Tools)["Move Location To Another Producer"].SharedProps.Visible = SecurityManager.Instance.AssertPermission("{37539B37-EEAB-4c9b-B612-D225B048E9D5}");
    ((ToolsCollectionBase) this.menuProducer.Tools)["Producer/Underwriter Assignment"].SharedProps.Visible = SecurityManager.Instance.AssertPermission("{4CACD183-630E-422b-A053-9650D23F4D2F}");
    ((ToolsCollectionBase) this.menuProducer.Tools)["Producer Lines (For Entire Producer) ..."].SharedProps.Visible = SecurityManager.Instance.AssertPermission("{4092C509-B8E1-4f32-8C75-FEFC70E6BD11}");
    ((ToolsCollectionBase) this.menuProducer.Tools)["Marketing"].SharedProps.Visible = SecurityManager.Instance.AssertPermission("{0BC6FCA1-9107-4C32-AB5F-87837F85895C}");
    ((ToolsCollectionBase) this.menuProducer.Tools)["Production Goal..."].SharedProps.Visible = SecurityManager.Instance.AssertPermission("{6A0C9E1C-246B-4586-837D-418B2D8D433E}");
    ((ToolsCollectionBase) this.menuProducer.Tools)["User Relationship"].SharedProps.Visible = SecurityManager.Instance.AssertPermission("{920C280E-6419-4D02-ACE2-C9CFCFD839EA}");
    ((ToolsCollectionBase) this.menuProducer.Tools)["Assign Client Offices"].SharedProps.Visible = SecurityManager.Instance.AssertPermission("{8EB178EF-9D56-4355-B279-D5EF4E2CF652}");
    ((ToolsCollectionBase) this.menuProducer.Tools)["Producer / Location Log"].SharedProps.Visible = SecurityManager.Instance.AssertPermission("{FF566DFA-A086-482C-9BD8-5E6F90F09AAA}");
    this._CanEditProducerLocation = SecurityManager.Instance.AssertPermission("{8B9773EE-C6CC-43d8-8ECB-9393B7C13824}");
    this._CanEditCallReports = SecurityManager.Instance.AssertPermission("{2437CF48-D6EF-4571-9A89-AB1194EA6707}");
    this._CanEditCRM = SecurityManager.Instance.AssertPermission("{D677240B-C6A0-4014-990F-DBB810CFAE97}");
    this._canEditProducer = SecurityManager.Instance.AssertPermission("{AF625193-53D6-4d88-A122-4F7055B0EBA5}");
    this._canDeleteProducer = SecurityManager.Instance.AssertPermission("{80C38DB7-51A1-4373-9BF9-6F33C03983DF}");
    this._canAddProducer = SecurityManager.Instance.AssertPermission("{5B098E3D-BAE4-42a2-BD20-EB5166A9D43A}");
    this._canAddProducerContact = SecurityManager.Instance.AssertPermission("{72A14282-79A9-4911-AFE1-8CB943352762}");
    this._canEditProducerContact = SecurityManager.Instance.AssertPermission("{BA4D1F6A-179A-42C6-8592-160F05478BFC}");
    this._canAddProducerLocation = SecurityManager.Instance.AssertPermission("{91B371AA-3B53-47ff-8797-A9676C7DEDF5}");
    this._canClearOfac = SecurityManager.Instance.AssertPermission("{88E157A8-27B4-4E2C-AB3E-C0DC06E2CD11}");
    ((Control) this.btnNewProducerLocation).Enabled = this._canAddProducerLocation;
    ((Control) this.txtFax).Enabled = false;
    ((Control) this.txtPhone).Enabled = false;
    this.EnableTabsSecurity();
  }

  private void EnableTabsSecurity()
  {
    ((UltraTabControlBase) this.tabLocationInfo).Tabs["tabStatistics"].Visible = SecurityManager.Instance.AssertPermission("{4db29af7-55f3-476d-8edf-be17cd700d51}");
    ((UltraTabControlBase) this.tabLocationInfo).Tabs["tabPolicies"].Visible = SecurityManager.Instance.AssertPermission("{0d45875e-b0f2-4ec6-b0a5-88b5432579ef}");
    ((UltraTabControlBase) this.tabLocationInfo).Tabs["tabContactInfo"].Visible = SecurityManager.Instance.AssertPermission("e02ec0c3-180c-49b6-a3bd-81628b3c9b4b");
    ((UltraTabControlBase) this.tabLocationInfo).Tabs["tabInvoices"].Visible = SecurityManager.Instance.AssertPermission("{b643ab27-9f68-4087-bd7f-4e2c645e5f12}");
    ((UltraTabControlBase) this.tabLocationInfo).Tabs["tabCRM"].Visible = SecurityManager.Instance.AssertPermission("{80a1d2d1-2015-405b-a65b-f4067cff7f15}");
    ((UltraTabControlBase) this.tabLocationInfo).Tabs["tabCallReports"].Visible = SecurityManager.Instance.AssertPermission("{c8280168-06d0-446e-bed3-b27e8235615e}");
    ((UltraTabControlBase) this.tabLocationInfo).Tabs["tabLogo"].Visible = SecurityManager.Instance.AssertPermission("{0F3032ad-9246-4197-a37e-762d23b9a8b0}");
  }

  private void menuProducer_BeforeToolDropdown(object sender, BeforeToolDropdownEventArgs e)
  {
    foreach (ToolBase tool in (ToolsCollectionBase) this.menuProducer.Tools)
    {
      if (!(tool is PopupMenuTool))
        tool.SharedProps.Enabled = !this.CurrentLocationRow.IsNameNull() && this.CurrentLocationRow.RowState != DataRowState.Added;
    }
    if (this.CurrentLocationRow.IsNameNull())
      ((ToolPropsBase) ((ToolsCollectionBase) this.menuProducer.Tools)["Producer Lines"].SharedProps).Caption = "Authorize Lines";
    else
      ((ToolPropsBase) ((ToolsCollectionBase) this.menuProducer.Tools)["Producer Lines"].SharedProps).Caption = $"Authorize Lines For {this.CurrentLocationRow.Name} (Location Only) ...";
  }

  private void dbSave_ClickingNew(object sender, CancelEventArgs e)
  {
    if (!this._canAddProducer)
    {
      int num = (int) MessageBox.Show("You are not authorized to add producer.", "Unauthorized Action", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      e.Cancel = true;
    }
    else
      this.NewProducer();
  }

  protected virtual void dbSave_ClickingSave(object sender, CancelEventArgs e)
  {
    bool successfullySaved = true;
    bool newRecord = this.dsProducer.tblProducerLocations[this.bmb.Position].RowState == DataRowState.Added;
    if (newRecord && !this._canAddProducerLocation)
    {
      int num = (int) MessageBox.Show("You are not authorized to add location.", "Unauthorized Action", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      e.Cancel = true;
    }
    else if (!newRecord && !this._CanEditProducerLocation)
    {
      int num = (int) MessageBox.Show("You are not authorized to save an edited location.", "Unauthorized Action", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      e.Cancel = true;
    }
    else if (!this.SaveChanges())
      e.Cancel = true;
    else
      this.AddCRM(successfullySaved, newRecord);
  }

  private void dbSave_ClickingDelete(object sender, CancelEventArgs e)
  {
    if (!this._canDeleteProducer)
    {
      int num1 = (int) MessageBox.Show("You are not authorized to delete producers.", "Unauthorized Action", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else
    {
      if (MessageBox.Show("Are you sure you want to delete this producer?", "Delete Producer?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
        return;
      string text = ((TextEditorControlBase) this.txtProducerName).Text;
      List<Guid> guidList = new List<Guid>();
      try
      {
        foreach (dsProducers.tblProducerLocationsRow producerLocation in (TypedTableBase<dsProducers.tblProducerLocationsRow>) this.dsProducer.tblProducerLocations)
          guidList.Add(producerLocation.ProducerLocationGUID);
      }
      finally
      {
        IEnumerator<dsProducers.tblProducerLocationsRow> enumerator;
        enumerator?.Dispose();
      }
      try
      {
        DefaultDatabase.ExecuteTransaction((EventHandler<ExecuteTransactionEventArgs>) ([SpecialName] (obj, args) =>
        {
          this.DeleteProducerTransaction(RuntimeHelpers.GetObjectValue(obj), args);
          args.Transaction.Commit();
        }));
        Form[] mdiChildren = MDIControls.Instance.MDIParent.MdiChildren;
        int index = 0;
        while (index < mdiChildren.Length)
        {
          Form form = mdiChildren[index];
          if (form is frmSelection)
          {
            if (((frmSelection) form).SelectionType == frmSelection.SelectionTypes.Producer)
            {
              try
              {
                foreach (Guid valueGuid in guidList)
                  ((frmSelection) form).RemoveItem(valueGuid);
              }
              finally
              {
                List<Guid>.Enumerator enumerator;
                enumerator.Dispose();
              }
            }
          }
          checked { ++index; }
        }
        CurrentUser.Instance.LogAction("Deleted producer:" + text);
        this.Close();
      }
      catch (SqlException ex1)
      {
        ProjectData.SetProjectError((Exception) ex1);
        SqlException ex2 = ex1;
        if (ex2.Message.IndexOf("FK_tblQuotes_tblProducerContacts") != -1)
        {
          int num2 = (int) MessageBox.Show("This producer can not be deleted, because one of the contacts is currently assigned to a policy.", "Contact In Use", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        else if (ex2.Message.IndexOf("FK_tblUsersProducerContacts_tblProducerContacts") != -1)
        {
          int num3 = (int) MessageBox.Show("This producer can not be deleted, because underwriters\nare currently associated with it.", "Unable To Delete Producer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        else if (ex2.Message.IndexOf("FK_tblSubmissionGroup_tblProducerContacts") != -1)
        {
          int num4 = (int) MessageBox.Show("This producer contact can not be deleted because it is assigned to one more more submissions", "Unable To Delete Producer Contact", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        else if (ex2.Message.Contains("FK_tblProducerLines_tblProducers"))
        {
          int num5 = (int) MessageBox.Show("This producer can not be deleted, because it is currently assigned to one or more producer lines.", "Producer Assigned To Producer Lines", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        else
          ErrorHandler.HandleError((Exception) ex2);
        ProjectData.ClearProjectError();
      }
    }
  }

  private void dbSave_ClickedEdit(object sender, EventArgs e)
  {
    if (this.dsProducer.tblProducerLocations.Count != 0)
      return;
    this.NewLocation();
  }

  private void dbSave_ClickedCancel(object sender, EventArgs e)
  {
    this.ClearErrors();
    this.ClearClientScreen();
  }

  private void dbSave_ClickingCancel(object sender, CancelEventArgs e)
  {
    this.bmb.CancelCurrentEdit();
  }

  private void dbSave_ClickingEdit(object sender, CancelEventArgs e)
  {
    if (!this._canEditProducer && this.dsProducer.tblProducers.Count > 0 && !this._CanEditCallReports && !this._CanEditCRM)
    {
      int num = (int) MessageBox.Show("You do not have permission to edit producer information.", "Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      e.Cancel = true;
    }
    else
    {
      if (this._CanEditProducerLocation || this._CanEditCallReports || this._CanEditCRM)
        return;
      int num = (int) MessageBox.Show("You do not have permission to edit any producer location information.", "Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      e.Cancel = true;
    }
  }

  private void dbSave_UIStateChanged(object sender, EventArgs e)
  {
    this.SetFormControlsEnabledState();
  }

  private object DeleteProducerTransaction(object sender, ExecuteTransactionEventArgs e)
  {
    DefaultDatabase.ExecuteNonQuery("spDeleteProducer", new object[2]
    {
      (object) "@producerGuid",
      (object) this._producerGuid
    });
    return (object) null;
  }

  private object DeleteLocationTransaction(object sender, ExecuteTransactionEventArgs e)
  {
    DefaultDatabase.ExecuteNonQuery("spDeleteProducer", new object[4]
    {
      (object) "@producerGuid",
      (object) this._producerGuid,
      (object) "@LocationGuid",
      (object) this.CurrentLocationRow.ProducerLocationGUID
    });
    return (object) null;
  }

  protected virtual void SetFormControlsEnabledState()
  {
    this._newProdLocBtnClicked = false;
    this.SetupLocationEdits();
    ((Control) this.btnDelete).Enabled = ((Control) this.txtEmail).Enabled && this.dsProducer.tblProducerLocations.Count > 1;
    ((Control) this.btnNewProducerLocation).Enabled = this.dbSave.UIState == UIState.Editing && this._CanEditProducerLocation;
    ((Control) this.btnNewContact).Enabled = this._CanEditProducerLocation;
    ((Control) this.btnSelectContact).Enabled = this._canEditProducerContact;
    ((Control) this.txtProducerName).Enabled = this._canEditProducer && this.dbSave.UIState == UIState.Editing;
    ((Control) this.cboBusinessTypes).Enabled = this._canEditProducer && this.dbSave.UIState == UIState.Editing;
    ((Control) this.btnNewContact).Enabled = this._canAddProducerContact;
    ((Control) this.btnReport).Enabled = this._CanEditCallReports;
    ((Control) this.chkOFACCleared).Enabled = this._canClearOfac && this.dbSave.UIState == UIState.Editing;
    ((Control) this.txtFax).Enabled = false;
    ((Control) this.txtPhone).Enabled = false;
    ((Control) this.SirconLOAGrid).Enabled = true;
    ((Control) this.SirconLicenseGrid).Enabled = true;
    this.tbOrgNPN.Enabled = true;
    this.tbSirconMsg.Enabled = true;
    this.tbSirconStatus.Enabled = true;
    this.lblLOAs.Enabled = true;
    this.lblOrgNPN.Enabled = true;
    this.lblLicenses.Enabled = true;
    this.lblSirconStatus.Enabled = true;
    ((UltraTabControlBase) this.tabLocationInfo).Tabs["tabSircon"].Visible = Utilities.SirconEnabled;
  }

  private void FillCompanyLines()
  {
    ((Control) this.cboCompanyLines).Enabled = false;
    if (frmProducers._compLineCache == null)
    {
      this.dsProducer.CompanyLines.AddCompanyLinesRow(Guid.Empty, string.Empty);
      DefaultDatabase.LoadDataSet((DataSet) this.dsProducer, new string[1]
      {
        "CompanyLines"
      }, "dbo.GetCompanyLineList");
    }
    if (frmProducers._compLineCache != null)
    {
      this.dsProducer.CompanyLines.BeginLoadData();
      this.dsProducer.CompanyLines.Load((IDataReader) frmProducers._compLineCache.CreateDataReader());
      this.dsProducer.CompanyLines.EndLoadData();
    }
    else
    {
      this.dsProducer.CompanyLines.Clear();
      this.dsProducer.CompanyLines.AddCompanyLinesRow(Guid.Empty, string.Empty);
      DefaultDatabase.LoadDataSet((DataSet) this.dsProducer, new string[1]
      {
        "CompanyLines"
      }, "dbo.GetCompanyLineList", new object[2]
      {
        (object) "@producerLocationGuid",
        (object) this.CurrentLocationRow.ProducerLocationGUID
      });
      frmProducers._compLineCache = new dsProducers.CompanyLinesDataTable();
      frmProducers._compLineCache.BeginLoadData();
      frmProducers._compLineCache.Load((IDataReader) this.dsProducer.CompanyLines.CreateDataReader());
      frmProducers._compLineCache.EndLoadData();
    }
    ((Control) this.cboCompanyLines).Enabled = true;
    this.FillCompanyLinesComplete();
  }

  private void FillCompanyLinesComplete()
  {
    MGASimpleComboBox cboCompanyLines = this.cboCompanyLines;
    ((UltraGridBase) cboCompanyLines).DataSource = (object) this.dsProducer.CompanyLines;
    ((UltraDropDownBase) cboCompanyLines).DisplayMember = "CompanyLine";
    ((UltraDropDownBase) cboCompanyLines).ValueMember = "CompanyLineGuid";
    ((Control) cboCompanyLines).Enabled = this._CanEditProducerLocation;
    this.cboCompanyLines.ValueChanged += new EventHandler(this.cboCompanyLines_ValueChanged);
  }

  private void cboCompanyLines_ValueChanged(object sender, EventArgs e)
  {
    this.FillProducerStatistics();
  }

  private void FillProducerStatisticsThread()
  {
    if (this.CurrentLocationRow == null)
      return;
    List<string> stringList = new List<string>();
    DataRow dataRow = (DataRow) null;
    object obj1 = (object) null;
    object obj2 = (object) null;
    object objectValue = this.cboCompanyLines.Text == null || this.cboCompanyLines.Text.Length == 0 ? (object) null : RuntimeHelpers.GetObjectValue(this.cboCompanyLines.Value);
    if (this.dtStartDate.Value != null && this.dtStartDate.Value != DBNull.Value)
      obj1 = (object) Conversions.ToDate(this.dtStartDate.Value).ToShortDateString();
    if (this.dtEndDate.Value != null && this.dtEndDate.Value != DBNull.Value)
      obj2 = (object) Conversions.ToDate(this.dtEndDate.Value).ToShortDateString();
    try
    {
      dataRow = DefaultDatabase.ExecuteDataRow("spGetProducerStatistics", new object[8]
      {
        (object) "@producerLocationGuid",
        (object) this.CurrentLocationRow.ProducerLocationGUID,
        (object) "@companyLineGuid",
        objectValue,
        (object) "@StartDate",
        obj1,
        (object) "@EndDate",
        obj2
      });
      stringList.Add(Conversions.ToDecimal(dataRow[2]).ToString("p"));
      stringList.Add(Conversions.ToDecimal(dataRow[3]).ToString("p"));
      stringList.Add(Conversions.ToDecimal(dataRow[1]).ToString("p"));
      stringList.Add(Conversions.ToDecimal(dataRow[4]).ToString("c"));
    }
    catch (SqlException ex1)
    {
      ProjectData.SetProjectError((Exception) ex1);
      SqlException ex2 = ex1;
      if (ex2.Message.IndexOf("Timeout expired") == -1)
        ErrorHandler.HandleError((Exception) ex2);
      ProjectData.ClearProjectError();
    }
    if (!this.IsHandleCreated || this.IsDisposed || this.Disposing)
      return;
    this.Invoke((Delegate) new frmProducers.FillProducerStatisticsThreadCompleteHandler(this.FillProducerStatisticsThreadComplete), (object) stringList, (object) dataRow);
  }

  private void FillProducerStatistics()
  {
    ((Control) this.chartStats).Visible = false;
    this.lblLoading.Visible = true;
    if (this._statisticsThread != null)
      this._statisticsThread.Abort();
    this._statisticsThread = new Thread(new ThreadStart(this.FillProducerStatisticsThread));
    this._statisticsThread.Name = "Fill Producer Statistics";
    this._statisticsThread.Start();
  }

  private void FillProducerStatisticsThreadComplete(List<string> output, DataRow dr)
  {
    this.lblLoading.Visible = false;
    ((Control) this.chartStats).Visible = true;
    ((ControlBase) this.lblBindRatio).Text = output[0].ToString();
    ((ControlBase) this.lblDeclineRatio).Text = output[1].ToString();
    ((ControlBase) this.lblQuoteRatio).Text = output[2].ToString();
    ((ControlBase) this.lblTotalPremium).Text = output[3].ToString();
    ((ControlBase) this.lblNumBind).Text = dr[7].ToString();
    ((ControlBase) this.lblNumDeclined).Text = dr[9].ToString();
    ((ControlBase) this.lblNumQuoted).Text = dr[8].ToString();
    ((ControlBase) this.lblNumSubmitted).Text = dr[6].ToString();
    DataTable dataTable = new DataTable();
    dataTable.Columns.Add("Submitted", typeof (int));
    dataTable.Columns.Add("Bound", typeof (int));
    dataTable.Columns.Add("Quoted", typeof (int));
    dataTable.Columns.Add("Declined", typeof (int));
    DataRow row = dataTable.NewRow();
    row[0] = (object) Conversions.ToInteger(dr[6]);
    row[1] = (object) Conversions.ToInteger(dr[7]);
    row[2] = (object) Conversions.ToInteger(dr[8]);
    row[3] = (object) Conversions.ToInteger(dr[9]);
    dataTable.Rows.Add(row);
    this.chartStats.DataSource = (object) dataTable;
    this.chartStats.Data.DataBind();
    MDIControls.Instance.StatusBarText = string.Empty;
  }

  private void tabLocationInfo_SelectedTabChanged(object sender, SelectedTabChangedEventArgs e)
  {
    if (!this._tabStatisticsPainted && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((UltraTabControlBase) this.tabLocationInfo).SelectedTab.Key, "tabStatistics", false) == 0)
    {
      this._tabStatisticsPainted = true;
      ((Control) this.cboCompanyLines).Enabled = false;
      ((Control) this.dtStartDate).Enabled = true;
      ((Control) this.dtEndDate).Enabled = true;
      this.btnQueryDates.Enabled = true;
      this.FillCompanyLines();
      this.FillProducerStatistics();
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((UltraTabControlBase) this.tabLocationInfo).SelectedTab.Key, "tabCRM", false) == 0)
      this.ShowProductionStatus();
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((UltraTabControlBase) this.tabLocationInfo).SelectedTab.Key, "tabPolicies", false) != 0)
      return;
    this.LoadPoliciesTab();
  }

  private void btnDelete_Click(object sender, EventArgs e)
  {
    if (!SecurityManager.Instance.AssertPermission("{80C38DB7-51A1-4373-9BF9-6F33C03983DF}"))
    {
      int num1 = (int) MessageBox.Show("You are not authorized to delete locations.", "Unauthorized Action", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else
    {
      if (this.dsProducer.tblProducerLocations.Count == 1)
        throw new Exception("Unable to delete only location");
      if (MessageBox.Show("Are you sure you want to delete this location?", "Delete Location?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
        return;
      if (this.dsProducer.tblProducerLocations[this.bmb.Position].RowState == DataRowState.Added)
      {
        this.dsProducer.tblProducerLocations.RemovetblProducerLocationsRow(this.dsProducer.tblProducerLocations[this.bmb.Position]);
        this.ClearErrorProviders();
      }
      else
      {
        try
        {
          DefaultDatabase.ExecuteTransaction((EventHandler<ExecuteTransactionEventArgs>) ([SpecialName] (obj, args) =>
          {
            this.DeleteLocationTransaction(RuntimeHelpers.GetObjectValue(obj), args);
            args.Transaction.Commit();
          }));
          Guid producerLocationGuid = this.dsProducer.tblProducerLocations[this.bmb.Position].ProducerLocationGUID;
          dsProducers.tblProducerContactsRow[] producerContactsRowArray = this.dsProducer.tblProducerLocations.FindByProducerLocationGUID(producerLocationGuid).GettblProducerContactsRows();
          int index = 0;
          while (index < producerContactsRowArray.Length)
          {
            this.dsProducer.tblProducerContacts.RemovetblProducerContactsRow(producerContactsRowArray[index]);
            checked { ++index; }
          }
          this.dsProducer.tblProducerLocations.RemovetblProducerLocationsRow(this.dsProducer.tblProducerLocations.FindByProducerLocationGUID(producerLocationGuid));
          this.bmb.Position = this.dsProducer.tblProducerLocations.Count - 1;
          this.UpdateLocationsNavDisplay();
        }
        catch (SqlException ex1)
        {
          ProjectData.SetProjectError((Exception) ex1);
          SqlException ex2 = ex1;
          if (ex2.Message.Contains("FK_tblQuotes_tblProducerContacts"))
          {
            int num2 = (int) MessageBox.Show("This location can not be deleted, because one of the contacts is currently assigned to a policy.", "Contact In Use", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          }
          else if (ex2.Message.Contains("FK_tblAdminCommissions_tblProducerLocations"))
          {
            int num3 = (int) MessageBox.Show("This location can not be deleted, because automated commissions are in effect.", "Location In Use", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          }
          else if (ex2.Message.Contains("FK_tblSubmissionGroup_tblProducerContacts"))
          {
            int num4 = (int) MessageBox.Show("This location can not be deleted, because submissions have been created under it.", "Location In Use", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          }
          else
            ErrorHandler.HandleError((Exception) ex2);
          ProjectData.ClearProjectError();
        }
      }
      this.SetFormControlsEnabledState();
    }
  }

  private void txtProducerName_Validating(object sender, CancelEventArgs e)
  {
    if (((TextEditorControlBase) this.txtLocation).Text.Length != 0)
      return;
    ((TextEditorControlBase) this.txtLocation).Text = ((TextEditorControlBase) this.txtProducerName).Text;
  }

  protected virtual void PopulateDataSet() => this.PopulateDataSet(false);

  protected virtual void PopulateDataSet(bool suppressEntityChanged)
  {
    DataTableMappingCollection tableMappings = this.daLoadData.TableMappings;
    tableMappings.Clear();
    tableMappings.Add("Table", this.dsProducer.lstProducerTypes.TableName);
    tableMappings.Add("Table1", this.dsProducer.lstDeliveryMethod.TableName);
    tableMappings.Add("Table2", this.dsProducer.lstLocationType.TableName);
    tableMappings.Add("Table3", this.dsProducer.lstStatus.TableName);
    tableMappings.Add("Table4", this.dsProducer.lstProducerBusinessTypes.TableName);
    tableMappings.Add("Table5", this.dsProducer.lstProducerLocationSource.TableName);
    tableMappings.Add("Table6", this.dsProducer.lstProductionPotential.TableName);
    tableMappings.Add("Table7", this.dsProducer.tblUsers.TableName);
    tableMappings.Add("Table8", this.dsProducer.lstProducerRankings.TableName);
    tableMappings.Add("Table9", this.dsProducer.lstPaymentMethods.TableName);
    tableMappings.Add("Table10", this.dsProducer.lstProducerStatusReasons.TableName);
    DefaultDatabase.DataAdapterFill((DbDataAdapter) this.daLoadData, (DataSet) this.dsProducer);
    this.daLoadData.Dispose();
    this.daLoadData = (SqlDataAdapter) null;
    DefaultDatabase.DataAdapterFill((DbDataAdapter) this.daProducerRegion, (DataTable) this.dsProducer.lstProducerLocationRegions);
    this.daProducerRegion.Dispose();
    this.daProducerRegion = (SqlDataAdapter) null;
    if (!this._producerGuid.Equals(Guid.Empty))
    {
      MDIControls.Instance.StatusBarText = "Getting producer and location information...";
      DefaultDatabase.LoadDataSet((DataSet) this.dsProducer, new string[2]
      {
        "tblProducers",
        "tblProducerLocations"
      }, "spGetProducerAndLocationData", new object[6]
      {
        (object) "@ProducerGuid",
        (object) this._producerGuid,
        (object) "@CurrentUserGuid",
        (object) CurrentUser.Instance.UserGUID,
        (object) "@ViewAllProducers",
        (object) SecurityManager.Instance.AssertPermission("{2D117606-DE51-4902-B36F-C415C27F52E0}")
      });
      this.Text = "Producer Information - " + this.dsProducer.tblProducers[0].ProducerName;
      if (!this.dsProducer.tblProducerLocations[0].IsInHouseProducerNull())
      {
        this.lblInhouseProducer.Visible = true;
        this.lblInhouseProducer.Text = "In House Producer: " + this.dsProducer.tblProducerLocations[0].InHouseProducer;
      }
      dsProducers.tblProducerLocationsDataTable dt = (dsProducers.tblProducerLocationsDataTable) this.dsProducer.tblProducerLocations.Copy();
      dsProducers.tblProducerLocationsRow row1 = dt.NewtblProducerLocationsRow();
      row1.ProducerGUID = this._producerGuid;
      row1.ProducerLocationGUID = Guid.Empty;
      row1.Name = string.Empty;
      row1.DateAdded = DateAndTime.Now;
      int userId = CurrentUser.Instance.UserID;
      if (this.dsProducer.tblProducerLocations[0].IsAddedByNull())
        row1.AddedBy = userId;
      row1.DateModified = DateAndTime.Now;
      row1.ModifiedBy = userId;
      dt.Rows.InsertAt((DataRow) row1, 0);
      Guid? nullable1;
      if (this.cboBillTo.Value != null && this.cboBillTo.Value != DBNull.Value)
        nullable1 = new Guid?((Guid) this.cboBillTo.Value);
      Guid? nullable2;
      if (this.cboMailTo.Value != null && this.cboMailTo.Value != DBNull.Value)
        nullable2 = new Guid?((Guid) this.cboMailTo.Value);
      Guid? nullable3;
      if (this.cboProducerlocations.Value != null && this.cboProducerlocations.Value != DBNull.Value)
        nullable3 = new Guid?((Guid) this.cboProducerlocations.Value);
      if (this._showLocationCode)
      {
        string empty = string.Empty;
        try
        {
          foreach (dsProducers.tblProducerLocationsRow row2 in dt.Rows)
          {
            string str1 = string.Empty;
            if (!row2.IsLocationCodeNull())
              str1 = $"{str1}Code: {row2.LocationCode} | ";
            string str2 = str1 + row2.Name;
            if (!row2.IsCityNull())
              str2 = $"{str2}, {row2.City}";
            row2.Name = str2;
          }
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
      }
      ((UltraGridBase) this.cboBillTo).DataSource = (object) dt;
      ((UltraGridBase) this.cboMailTo).DataSource = (object) dt;
      this.FillClientMailchecktoCombo((DataTable) dt);
      if (!nullable1.Equals((object) Guid.Empty))
        this.cboBillTo.Value = (object) nullable1;
      if (!nullable2.Equals((object) Guid.Empty))
        this.cboMailTo.Value = (object) nullable2;
      if (!nullable3.Equals((object) Guid.Empty))
        this.cboProducerlocations.Value = (object) nullable3;
      if (!suppressEntityChanged)
      {
        // ISSUE: reference to a compiler-generated field
        ISupportDocumentSystem.EntityInfoChangedEventHandler infoChangedEvent = this.EntityInfoChangedEvent;
        if (infoChangedEvent != null)
          infoChangedEvent((object) this, EventArgs.Empty);
        // ISSUE: reference to a compiler-generated field
        ISupportNoteSystem.EntityInfoChangedEventHandler infoChanged1Event = this.EntityInfoChanged1Event;
        if (infoChanged1Event != null)
          infoChanged1Event((object) this, EventArgs.Empty);
      }
      this.FillAllCallReports(this._producerGuid);
    }
    else
      this.Text = "New Producer";
  }

  public void LoadPoliciesTab()
  {
    if (this._producerLocationGuid.Equals(Guid.Empty) || ((UltraGridBase) this.ugPoliciesGrid).DataSource != null)
      return;
    ((UltraGridBase) this.ugPoliciesGrid).DataSource = (object) DefaultDatabase.ExecuteDataTable("spGetProducerPolicyAssociations", new object[2]
    {
      (object) "@ProducerLocationGUID",
      (object) this._producerLocationGuid
    });
    ((UltraGridBase) this.ugPoliciesGrid).DisplayLayout.Bands[0].Columns["quoteguid"].Hidden = true;
  }

  private void ugPoliciesTab_DoubleClickRow(object sender, DoubleClickRowEventArgs e)
  {
    UltraGridColumn column = ((UltraGridBase) this.ugPoliciesGrid).DisplayLayout.Bands[0].Columns["quoteguid"];
    Guid guid = Guid.Parse(e.Row.GetCellText(column));
    FormSettings.ShowForm(ObjectFactory.Instance.CreateTypeFromString("MGASystems.IMS.Policies.PolicyDetail.frmPolicyDetail"), (object) guid);
  }

  internal void LoadContacts()
  {
    if (this.dsProducer.tblProducerLocations.Count <= 0)
      return;
    this.daContacts.SelectCommand.Parameters["@ProducerLocationGuid"].Value = (object) this.CurrentLocationRow.ProducerLocationGUID;
    this.dsProducer.tblProducerContacts.Clear();
    DefaultDatabase.DataAdapterFill((DbDataAdapter) this.daContacts, (DataTable) this.dsProducer.tblProducerContacts);
    this.lstContacts.Enabled = this.dsProducer.tblProducerContacts.Count > 0;
    this.ShowOfacData((dsProducers.tblProducerContactsRow) null);
  }

  private void Navigation(object sender, EventArgs e)
  {
    this.bmb.EndCurrentEdit();
    this.dsProducer.AcceptChanges();
    if (this.dsProducer.HasChanges())
    {
      switch (MessageBox.Show("You have unsaved changes on this record.  Would you like to save?", "Save Changes", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation))
      {
        case DialogResult.Cancel:
          return;
        case DialogResult.Yes:
          if (!this.SaveChanges())
            return;
          break;
        default:
          this.dsProducer.tblProducerLocations.RejectChanges();
          this.ClearErrorProviders();
          break;
      }
    }
    else
      this.SaveClient((SqlTransaction) null);
    if (sender == this.btnNext)
    {
      BindingManagerBase bmb;
      int num = (bmb = this.bmb).Position + 1;
      bmb.Position = num;
    }
    else if (sender == this.btnFirst)
      this.bmb.Position = 0;
    else if (sender == this.btnLast)
      this.bmb.Position = this.bmb.Count - 1;
    else if (sender == this.btnPrev)
    {
      BindingManagerBase bmb;
      int num = (bmb = this.bmb).Position - 1;
      bmb.Position = num;
    }
    this.LoadContacts();
    this._producerLocationGuid = this.CurrentLocationRow.ProducerLocationGUID;
    ((UltraGridBase) this.ugPoliciesGrid).DataSource = (object) null;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((UltraTabControlBase) this.tabLocationInfo).SelectedTab.Key, "tabPolicies", false) == 0)
      this.LoadPoliciesTab();
    if (((TextEditorControlBase) this.txtLocation).Text.Length != 0)
    {
      ((Control) this.btnNewContact).Enabled = this._CanEditProducerLocation;
      ((Control) this.btnSelectContact).Enabled = this._canEditProducerContact;
      ((Control) this.cboReason).Enabled = false;
      ((Control) this.txtStatusChangeComments).Enabled = false;
      ((Control) this.txtFax).Enabled = false;
      ((Control) this.txtPhone).Enabled = false;
    }
    this.bmb.EndCurrentEdit();
    this.dsProducer.tblProducerLocations.AcceptChanges();
    // ISSUE: reference to a compiler-generated field
    ISupportDocumentSystem.EntityInfoChangedEventHandler infoChangedEvent = this.EntityInfoChangedEvent;
    if (infoChangedEvent != null)
      infoChangedEvent((object) this, EventArgs.Empty);
    // ISSUE: reference to a compiler-generated field
    ISupportNoteSystem.EntityInfoChangedEventHandler infoChanged1Event = this.EntityInfoChanged1Event;
    if (infoChanged1Event != null)
      infoChanged1Event((object) this, EventArgs.Empty);
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((UltraTabControlBase) this.tabLocationInfo).SelectedTab.Key, "tabStatistics", false) != 0)
      return;
    this.FillProducerStatistics();
  }

  private void btnNewProducerLocation_Click(object sender, EventArgs e)
  {
    if (this.bmb.Position != -1 && this.dsProducer.tblProducerLocations[this.bmb.Position].RowState == DataRowState.Added)
    {
      int num1 = (int) MessageBox.Show("Please save your new location before adding another.", "Save Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else if (!this._canAddProducerLocation)
    {
      int num2 = (int) MessageBox.Show("You do not have the required security to add a new location.", "Security Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else
      this.NewLocation();
  }

  private void ClearErrors()
  {
    try
    {
      foreach (Control control in ((Control) this.UltraTabPageControl1).Controls)
        this.err.SetError(control, string.Empty);
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  protected virtual bool IsValidForm()
  {
    bool flag1 = true;
    this.err.SetError((Control) this.txtEmail, string.Empty);
    this.err.SetError((Control) this.txtProducerName, string.Empty);
    this.err.SetError((Control) this.cboBusinessTypes, string.Empty);
    this.err.SetError((Control) this.txtLocation, string.Empty);
    this.err.SetError((Control) this.cbStatus, string.Empty);
    this.err.SetError((Control) this.cbOfficeType, string.Empty);
    this.err.SetError((Control) this.MgaInternationalFax, string.Empty);
    this.err.SetError((Control) this.cboProducerType, string.Empty);
    this.err.SetError((Control) this.txtCode, string.Empty);
    this.err.SetError((Control) this.cboReason, string.Empty);
    this.err.SetError((Control) this.txtStatusChangeComments, string.Empty);
    this.err.SetError((Control) this.txtFEIN1, string.Empty);
    if (((TextEditorControlBase) this.txtProducerName).Text.Length == 0)
    {
      this.err.SetError((Control) this.txtProducerName, "Please enter a name for this producer.");
      flag1 = false;
    }
    else if (DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "SELECT COUNT(*) FROM tblProducers WHERE ProducerName=@ProducerName AND ProducerGuid <> @ProducerGuid", new object[4]
    {
      (object) "@ProducerName",
      (object) ((TextEditorControlBase) this.txtProducerName).Text,
      (object) "@ProducerGuid",
      (object) this._producerGuid
    }) > 0)
    {
      this.err.SetError((Control) this.txtProducerName, "This producer name already exists.");
      flag1 = false;
    }
    if (this.cboBusinessTypes.Value == null && ((Control) this.cboBusinessTypes).Visible)
    {
      this.err.SetError((Control) this.cboBusinessTypes, "Please select a valid business type.");
      flag1 = false;
    }
    if (((TextEditorControlBase) this.txtLocation).Text.Length == 0)
    {
      this.err.SetError((Control) this.txtLocation, "Please enter a Location for this producer.");
      flag1 = false;
    }
    if (!this.ctlZipCode.ValidateFields())
      flag1 = false;
    if (this.cbStatus.Text.Length == 0)
    {
      this.err.SetError((Control) this.cbStatus, "Please enter a Status for this producer.");
      flag1 = false;
    }
    if (this.cbOfficeType.Text.Length == 0)
    {
      this.err.SetError((Control) this.cbOfficeType, "Please enter a office type for this producer.");
      flag1 = false;
    }
    if (MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("ProducerFEIN_Required") && this.txtFEIN1.Text.Length < this._validLengthFEIN)
    {
      this.err.SetError((Control) this.txtFEIN1, "Please enter a valid FEIN.");
      flag1 = false;
    }
    Regex regex = new Regex("((\\(\\d{3}\\) ?)|(\\d{3}[- \\.]))?\\d{3}[- \\.]\\d{4}(\\s(x\\d+)?){0,1}$");
    if (this.dsProducer.tblProducerLocations[this.bmb.Position].RowState != DataRowState.Added)
    {
      this._producerLocationGuid = this.CurrentLocationRow.ProducerLocationGUID;
      this.GetSelectedLocationOriginalStatus(this._producerLocationGuid);
      if (this._originalProducerStatus != (int) this.cbStatus.Value && this.cboReason.Text.Length == 0)
      {
        this.err.SetError((Control) this.cboReason, "Please select a status change reason since you are changing the status.  You can also include an optional comment below.");
        flag1 = false;
      }
    }
    if (this.cboDeliveryMethod.Text.Length == 0)
    {
      this.err.SetError((Control) this.cboDeliveryMethod, "Please enter a delivery method.");
      flag1 = false;
    }
    else if (Conversions.ToInteger(this.cboDeliveryMethod.Value) == 3 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((TextEditorControlBase) this.txtEmail).Text, string.Empty, false) == 0)
    {
      this.err.SetError((Control) this.txtEmail, "Email must be provided when selecting email delivery type.");
      flag1 = false;
    }
    else if (Conversions.ToInteger(this.cboDeliveryMethod.Value) == 2 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.MgaInternationalFax.Text, string.Empty, false) == 0)
    {
      this.err.SetError((Control) this.MgaInternationalFax, "Fax must be provided when selecting fax delivery type.");
      flag1 = false;
    }
    else
    {
      ErrorProvider err = this.err;
      err.SetError((Control) this.txtEmail, string.Empty);
      err.SetError((Control) this.MgaInternationalFax, string.Empty);
      err.SetError((Control) this.cboDeliveryMethod, string.Empty);
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.err.GetError((Control) this.txtEmail), string.Empty, false) == 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((TextEditorControlBase) this.txtEmail).Text, string.Empty, false) != 0 && !Parsing.IsValidEmailAddress(((TextEditorControlBase) this.txtEmail).Text))
    {
      this.err.SetError((Control) this.txtEmail, "Please enter a valid email address.");
      flag1 = false;
    }
    else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.err.GetError((Control) this.txtEmail), string.Empty, false) == 0 && ((UltraToggleEditorBase) this.chkEmailReminders).Checked && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((TextEditorControlBase) this.txtEmail).Text, string.Empty, false) == 0)
    {
      this.err.SetError((Control) this.txtEmail, "Email must be provided when automated NOC reminders are active.");
      flag1 = false;
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cboProducerType.Text, string.Empty, false) == 0)
    {
      this.err.SetError((Control) this.cboProducerType, "Please select a producer type.");
      flag1 = false;
    }
    if (flag1)
    {
      ProducerTypes producerTypes = (ProducerTypes) Enum.Parse(typeof (ProducerTypes), this.cboProducerType.Value.ToString());
      bool flag2 = this.dsProducer.tblProducerLocations[this.bmb.Position].RowState == DataRowState.Added;
      switch (producerTypes)
      {
        case ProducerTypes.Retailer:
          if (flag2)
          {
            if (!frmProducers.CanAddRetailer())
            {
              int num = (int) MessageBox.Show("You are not authorized to to add new retailers.", "Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
              flag1 = false;
              break;
            }
            break;
          }
          if (!frmProducers.CanEditRetailer())
          {
            int num = (int) MessageBox.Show("You are not authorized to to edit retailers.", "Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            flag1 = false;
            break;
          }
          break;
        case ProducerTypes.Wholesaler:
          if (flag2)
          {
            if (!frmProducers.CanAddWholeSaler())
            {
              int num = (int) MessageBox.Show("You are not authorized to to add new wholesalers.", "Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
              flag1 = false;
              break;
            }
            break;
          }
          if (!frmProducers.CanEditWholesaler())
          {
            int num = (int) MessageBox.Show("You are not authorized to to edit wholesalers.", "Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            flag1 = false;
            break;
          }
          break;
        case ProducerTypes.MGA:
          if (flag2)
          {
            if (!frmProducers.CanAddMGA())
            {
              int num = (int) MessageBox.Show("You are not authorized to to add new MGAs.", "Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
              flag1 = false;
              break;
            }
            break;
          }
          if (!frmProducers.CanEditMGA())
          {
            int num = (int) MessageBox.Show("You are not authorized to to edit MGAs.", "Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            flag1 = false;
            break;
          }
          break;
      }
    }
    if (flag1 & !string.IsNullOrEmpty(((TextEditorControlBase) this.txtCode).Text))
    {
      if (DefaultDatabase.ExecuteScalar<bool>("EnforceUniqueLocationCodes", new object[4]
      {
        (object) "@ProducerLocationGUID",
        (object) this.dsProducer.tblProducerLocations[this.bmb.Position].ProducerLocationGUID,
        (object) "@LocationCode",
        (object) ((TextEditorControlBase) this.txtCode).Text
      }))
      {
        this.err.SetError((Control) this.txtCode, "Location codes must be unique.");
        flag1 = false;
      }
    }
    if (!flag1)
      ((UltraTabControlBase) this.tabLocationInfo).Tabs[0].Selected = true;
    if (flag1 && !this.ValidLocationData())
      flag1 = false;
    return flag1;
  }

  protected virtual void ClientNewProducer()
  {
  }

  protected virtual void ClientNewProducerLocation()
  {
  }

  protected virtual void SaveClient(SqlTransaction trans)
  {
  }

  protected virtual bool ClientLogModifiedData() => true;

  protected virtual bool ClientProducerHasChanges() => false;

  protected virtual bool ClientProducerLocationHasChanges() => false;

  protected virtual void ClearClientScreen()
  {
  }

  private bool DataTableModified(DataRow currRow)
  {
    bool flag;
    switch (currRow.RowState)
    {
      case DataRowState.Added:
      case DataRowState.Deleted:
        flag = false;
        break;
      default:
        try
        {
          foreach (DataColumn column in (InternalDataCollectionBase) currRow.Table.Columns)
          {
            string empty1 = string.Empty;
            string empty2 = string.Empty;
            if (currRow[column, DataRowVersion.Original] != DBNull.Value)
              empty1 = currRow[column, DataRowVersion.Original].ToString();
            if (currRow[column] != DBNull.Value)
              empty2 = currRow[column].ToString();
            if (!empty1.Equals(empty2))
            {
              flag = true;
              goto label_14;
            }
          }
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
        flag = false;
        break;
    }
label_14:
    return flag;
  }

  private bool SaveChanges()
  {
    // ISSUE: variable of a compiler-generated type
    frmProducers._Closure\u0024__782\u002D1 closure7821_1;
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    frmProducers._Closure\u0024__782\u002D1 closure7821_2 = new frmProducers._Closure\u0024__782\u002D1(closure7821_1);
    // ISSUE: reference to a compiler-generated field
    closure7821_2.\u0024VB\u0024Me = this;
    bool flag;
    if (!this.IsValidForm())
    {
      flag = false;
    }
    else
    {
      // ISSUE: reference to a compiler-generated field
      closure7821_2.\u0024VB\u0024Local_isLocationClosed = false;
      try
      {
        // ISSUE: variable of a compiler-generated type
        frmProducers._Closure\u0024__782\u002D0 closure7820_1;
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        frmProducers._Closure\u0024__782\u002D0 closure7820_2 = new frmProducers._Closure\u0024__782\u002D0(closure7820_1);
        // ISSUE: reference to a compiler-generated field
        closure7820_2.\u0024VB\u0024NonLocal_\u0024VB\u0024Closure_2 = closure7821_2;
        this.CurrentLocationRow.CountryCodeforPhone = this.MgaInternationalPhone.CountryCode;
        this.CurrentLocationRow.Phone = this.MgaInternationalPhone.ValueString;
        this.CurrentLocationRow.CountryCodeforFax = this.MgaInternationalFax.CountryCode;
        this.CurrentLocationRow.Fax = this.MgaInternationalFax.ValueString;
        this.CurrentLocationRow.ZipCode = this.ctlZipCode.ZipCode;
        this.CurrentLocationRow.City = this.ctlZipCode.City;
        this.CurrentLocationRow.County = this.ctlZipCode.County;
        this.CurrentLocationRow.State = this.ctlZipCode.State;
        this.CurrentLocationRow.ISOCountryCode = this.ctlZipCode.ISOCountryCode;
        this.BindingContext[(object) this.dsProducer, this.dsProducer.tblProducers.TableName].EndCurrentEdit();
        this.bmb.EndCurrentEdit();
        if (this.dsProducer.tblProducers[0].IsProducerBusinessTypeIDNull())
        {
          this.err.SetError((Control) this.cboBusinessTypes, "Please select a valid business type.");
          flag = false;
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          closure7820_2.\u0024VB\u0024Local_isProducerModified = this.DataTableModified((DataRow) this.dsProducer.tblProducers[0]);
          this._isLocationModified = this.DataTableModified((DataRow) this.CurrentLocationRow);
          // ISSUE: reference to a compiler-generated field
          this._hasProducerOrLocationChanges = this.dsProducer.tblProducerLocations[this.bmb.Position].RowState == DataRowState.Added | closure7820_2.\u0024VB\u0024Local_isProducerModified | this.dsProducer.tblProducers[0].RowState == DataRowState.Added | this._isLocationModified | this.ClientProducerHasChanges() | this.ClientProducerLocationHasChanges();
          if (!this.dsProducer.tblProducerLocations[this.bmb.Position].IsBillToProducerLocationGuidNull() && this.dsProducer.tblProducerLocations[this.bmb.Position].BillToProducerLocationGuid.Equals(Guid.Empty))
            this.dsProducer.tblProducerLocations[this.bmb.Position].SetBillToProducerLocationGuidNull();
          if (!this.dsProducer.tblProducerLocations[this.bmb.Position].IsMailToProducerLocationGuidNull() && this.dsProducer.tblProducerLocations[this.bmb.Position].MailToProducerLocationGuid.Equals(Guid.Empty))
            this.dsProducer.tblProducerLocations[this.bmb.Position].SetMailToProducerLocationGuidNull();
          this.SaveRichTextBoxesInfo(this.dsProducer.tblProducerLocations[this.bmb.Position]);
          // ISSUE: reference to a compiler-generated field
          closure7820_2.\u0024VB\u0024Local_drLocation = this.dsProducer.tblProducerLocations[this.bmb.Position];
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          closure7820_2.\u0024VB\u0024Local_producerLocationGuid = closure7820_2.\u0024VB\u0024Local_drLocation.ProducerLocationGUID;
          int userId = CurrentUser.Instance.UserID;
          // ISSUE: reference to a compiler-generated field
          if (closure7820_2.\u0024VB\u0024Local_drLocation.IsAddedByNull())
          {
            // ISSUE: reference to a compiler-generated field
            closure7820_2.\u0024VB\u0024Local_drLocation.AddedBy = userId;
          }
          // ISSUE: reference to a compiler-generated field
          closure7820_2.\u0024VB\u0024Local_drLocation.DateModified = DateAndTime.Now;
          // ISSUE: reference to a compiler-generated field
          closure7820_2.\u0024VB\u0024Local_drLocation.ModifiedBy = userId;
          if (string.IsNullOrEmpty(this.ctlZipCode.State))
          {
            // ISSUE: reference to a compiler-generated field
            closure7820_2.\u0024VB\u0024Local_drLocation.SetStateNull();
          }
          this.Cursor = MgaCursors.WaitCursor;
          // ISSUE: reference to a compiler-generated field
          closure7820_2.\u0024VB\u0024Local_producerGuid = this.dsProducer.tblProducers[0].ProducerGUID;
          // ISSUE: reference to a compiler-generated field
          closure7820_2.\u0024VB\u0024Local_UpdateProducersSubmissions = false;
          // ISSUE: reference to a compiler-generated field
          closure7820_2.\u0024VB\u0024Local_NumProducersSubmissionUpdated = 0;
          // ISSUE: reference to a compiler-generated field
          if (closure7820_2.\u0024VB\u0024Local_isProducerModified | this._hasProducerOrLocationChanges)
          {
            // ISSUE: reference to a compiler-generated field
            closure7820_2.\u0024VB\u0024Local_UpdateProducersSubmissions = this.LocationModifiedUserResponseUpdateSubmissions();
          }
          // ISSUE: reference to a compiler-generated method
          DefaultDatabase.ExecuteTransaction(new EventHandler<ExecuteTransactionEventArgs>(closure7820_2._Lambda\u0024__0));
          // ISSUE: reference to a compiler-generated field
          if (closure7820_2.\u0024VB\u0024Local_UpdateProducersSubmissions)
          {
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            int num = (int) MessageBox.Show(Interaction.IIf(closure7820_2.\u0024VB\u0024Local_NumProducersSubmissionUpdated == 0, (object) "No", (object) closure7820_2.\u0024VB\u0024Local_NumProducersSubmissionUpdated.ToString()).ToString() + " policies were affected.", "Update Complete", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          }
          this.err.SetError((Control) this.txtCode, string.Empty);
          this.dsProducer.tblProducerLocations.AcceptChanges();
          this.dsProducer.tblProducers.AcceptChanges();
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          if (closure7820_2.\u0024VB\u0024NonLocal_\u0024VB\u0024Closure_2.\u0024VB\u0024Local_isLocationClosed)
            this.MoveProducerRenewalBor();
          flag = true;
        }
      }
      catch (SqlException ex1)
      {
        ProjectData.SetProjectError((Exception) ex1);
        SqlException ex2 = ex1;
        if (ex2.State == (byte) 55)
          this.err.SetError((Control) this.txtCode, "Location codes must be unique.");
        else if (ex2.Message.IndexOf("FK_tblProducerLocations_lstStates") != -1)
        {
          int num = (int) MessageBox.Show("Please enter a value for the state field.", "Missing State - Required for International and US Domestic", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        else
          ErrorHandler.HandleError((Exception) ex2);
        flag = false;
        ProjectData.ClearProjectError();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ErrorHandler.HandleError(ex);
        flag = false;
        ProjectData.ClearProjectError();
      }
      finally
      {
        this.Cursor = MgaCursors.Default;
      }
    }
    return flag;
  }

  public virtual void SaveProducer(Guid producerGuid, Guid producerLocationGuid)
  {
  }

  private void SavingNewProducer()
  {
    ProducerContext context = new ProducerContext(this.ProducerGuid, this.ProductName, false);
    Messaging.SendBroadcastMessage(BroadcastMessages.ProducerAdded, (object) context);
  }

  private void UpdatingProducer()
  {
    ProducerContext context = new ProducerContext(this.ProducerGuid, this.ProductName, false);
    Messaging.SendBroadcastMessage(BroadcastMessages.ProducerUpdated, (object) context);
  }

  private void SaveRichTextBoxesInfo(dsProducers.tblProducerLocationsRow dr)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtSpecFocusDept.Text, string.Empty, false) == 0)
      dr.SetSpecFocusDeptNull();
    else
      dr.SpecFocusDept = this.txtSpecFocusDept.Rtf;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtExpertise.Text, string.Empty, false) == 0)
      dr.SetExpertiseNull();
    else
      dr.Expertise = this.txtExpertise.Rtf;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtWholesaleRelationships.Text, string.Empty, false) == 0)
      dr.SetWholesaleRelationshipsNull();
    else
      dr.WholesaleRelationships = this.txtWholesaleRelationships.Rtf;
    dr.CountryCodeforPhone = this.MgaInternationalPhone.CountryCode;
    dr.Phone = this.MgaInternationalPhone.ValueString;
    dr.CountryCodeforFax = this.MgaInternationalFax.CountryCode;
    dr.Fax = this.MgaInternationalFax.ValueString;
    dr.ZipCode = this.ctlZipCode.ZipCode;
    dr.County = this.ctlZipCode.County;
    dr.City = this.ctlZipCode.City;
    dr.State = this.ctlZipCode.State;
    dr.ISOCountryCode = this.ctlZipCode.ISOCountryCode;
  }

  private bool LocationModifiedUserResponseUpdateSubmissions()
  {
    bool flag;
    if (MessageBox.Show("Information about this producer has changed.\n\nWould you Like To update this producers submissions And In-force policies\nWith this New information?", "Update Policies?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
    {
      flag = true;
    }
    else
    {
      CurrentUser.Instance.LogAction("Decline To update the producers submissions And In-force policies On producer change.", this.dsProducer.tblProducers[0].ProducerGUID);
      flag = false;
    }
    return flag;
  }

  private int LocationModified(Guid producerLocationGuid)
  {
    return DefaultDatabase.ExecuteScalar<int>("dbo.spUpdateProducerPolicyInfo", new object[2]
    {
      (object) "@producerLocationGuid",
      (object) producerLocationGuid
    });
  }

  private string GetEntityTableValue(
    string columnName,
    dsProducers.tblProducerLocationsRow row,
    object rowValue)
  {
    string entityTableValue = string.Empty;
    string str = columnName;
    // ISSUE: reference to a compiler-generated method
    switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(str))
    {
      case 647047847:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "MailToProducerLocationGuid", false) == 0 && !row.IsMailToProducerLocationGuidNull())
        {
          dsProducers.tblProducerLocationsRow producerLocationGuid = this.dsProducer.tblProducerLocations.FindByProducerLocationGUID(new Guid(rowValue.ToString()));
          if (producerLocationGuid != null)
          {
            entityTableValue = producerLocationGuid.Name;
            break;
          }
          break;
        }
        break;
      case 1618682461:
        int result1;
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "DeliveryMethodID", false) == 0 && !row.IsDeliveryMethodIDNull() && int.TryParse(rowValue.ToString(), out result1))
        {
          dsProducers.lstDeliveryMethodRow deliveryMethodId = this.dsProducer.lstDeliveryMethod.FindByDeliveryMethodID(result1);
          if (deliveryMethodId != null)
          {
            entityTableValue = deliveryMethodId.Description;
            break;
          }
          break;
        }
        break;
      case 2537521044:
        Decimal result2;
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "ProducerLocationRegion", false) == 0 && !row.IsProducerLocationRegionNull() && Decimal.TryParse(rowValue.ToString(), out result2))
        {
          dsProducers.lstProducerLocationRegionsRow byId = this.dsProducer.lstProducerLocationRegions.FindByID(result2);
          if (byId != null)
          {
            entityTableValue = byId.ProducerRegion;
            break;
          }
          break;
        }
        break;
      case 2851509931:
        int result3;
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "LocationTypeID", false) == 0 && !row.IsLocationTypeIDNull() && int.TryParse(rowValue.ToString(), out result3))
        {
          dsProducers.lstLocationTypeRow byLocationTypeId = this.dsProducer.lstLocationType.FindByLocationTypeID(result3);
          if (byLocationTypeId != null)
          {
            entityTableValue = byLocationTypeId.LocationType;
            break;
          }
          break;
        }
        break;
      case 3429594882:
        int result4;
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "StatusChangeReasonID", false) == 0 && !row.IsStatusIDNull() && int.TryParse(rowValue.ToString(), out result4))
        {
          dsProducers.lstProducerStatusReasonsRow byId = this.dsProducer.lstProducerStatusReasons.FindByID(result4);
          if (byId != null)
          {
            entityTableValue = byId.Reason;
            break;
          }
          break;
        }
        break;
      case 3742141357:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "BillToProducerLocationGuid", false) == 0 && !row.IsBillToProducerLocationGuidNull())
        {
          dsProducers.tblProducerLocationsRow producerLocationGuid = this.dsProducer.tblProducerLocations.FindByProducerLocationGUID(new Guid(rowValue.ToString()));
          if (producerLocationGuid != null)
          {
            entityTableValue = producerLocationGuid.Name;
            break;
          }
          break;
        }
        break;
      case 4076021186:
        int result5;
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "StatusID", false) == 0 && !row.IsStatusIDNull() && int.TryParse(rowValue.ToString(), out result5))
        {
          dsProducers.lstStatusRow byStatusId = this.dsProducer.lstStatus.FindByStatusID(result5);
          if (byStatusId != null)
          {
            entityTableValue = byStatusId.Status;
            break;
          }
          break;
        }
        break;
      case 4082508274:
        int result6;
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "ProducerTypeID", false) == 0 && !row.IsProducerTypeIDNull() && int.TryParse(rowValue.ToString(), out result6))
        {
          dsProducers.lstProducerTypesRow byProducerTypeId = this.dsProducer.lstProducerTypes.FindByProducerTypeID(result6);
          if (byProducerTypeId != null)
          {
            entityTableValue = byProducerTypeId.Description;
            break;
          }
          break;
        }
        break;
    }
    return entityTableValue;
  }

  private string LogModifiedLocationData(
    dsProducers.tblProducerLocationsRow row,
    string strOrigAndChanged)
  {
    Dictionary<string, string> dictionary1 = new Dictionary<string, string>();
    Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
    Dictionary<string, string> dictionary3 = dictionary1;
    dictionary3.Add("LocationCode", "Location Code");
    dictionary3.Add("LocationTypeID", "Location Type");
    dictionary3.Add("ProducerTypeID", "Producer Type");
    dictionary3.Add("DeliveryMethodID", "Delivery Method");
    dictionary3.Add("StatusID", "Status");
    dictionary3.Add("BillToProducerLocationGuid", "Bill To ProducerLocation");
    dictionary3.Add("EmailReminders", "Email Reminders");
    dictionary3.Add("AllowAutomaticNOC", "Allow Automatic NOC");
    dictionary3.Add("MailToProducerLocationGuid", "Mail To Producer Location");
    dictionary3.Add("ProducerLocationRegion", "Producer Location Region");
    dictionary3.Add("StatusChangeReasonID", "Status Reason Change");
    Dictionary<string, string> dictionary4 = dictionary2;
    dictionary4.Add("LocationTypeID", "Location Type");
    dictionary4.Add("ProducerTypeID", "Producer Type");
    dictionary4.Add("DeliveryMethodID", "Delivery Method");
    dictionary4.Add("StatusID", "Status");
    dictionary4.Add("BillToProducerLocationGuid", "Bill To ProducerLocation");
    dictionary4.Add("MailToProducerLocationGuid", "Mail To Producer Location");
    dictionary4.Add("ProducerLocationRegion", "Producer Location Region");
    dictionary4.Add("StatusChangeReasonID", "Status Reason Change");
    string empty1 = string.Empty;
    string empty2 = string.Empty;
    string str = "<empty>";
    try
    {
      foreach (DataColumn column in (InternalDataCollectionBase) this.dsProducer.tblProducerLocations.Columns)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(row[column.ColumnName, DataRowVersion.Original].ToString(), row[column.ColumnName, DataRowVersion.Current].ToString(), false) != 0)
        {
          string rowValue1 = row[column] == DBNull.Value ? str : row[column, DataRowVersion.Current].ToString();
          string rowValue2 = row[column, DataRowVersion.Original] == DBNull.Value ? str : row[column, DataRowVersion.Original].ToString();
          string columnName = column.ColumnName;
          if (dictionary1.ContainsKey(column.ColumnName))
            columnName = dictionary1[column.ColumnName];
          if (!rowValue1.Equals(str) && dictionary2.ContainsKey(column.ColumnName))
            rowValue1 = this.GetEntityTableValue(column.ColumnName, row, (object) rowValue1);
          if (!rowValue2.Equals(str) && dictionary2.ContainsKey(column.ColumnName))
            rowValue2 = this.GetEntityTableValue(column.ColumnName, row, (object) rowValue2);
          strOrigAndChanged = $"{strOrigAndChanged}\r\n {columnName}: was changed FROM {rowValue2} TO {rowValue1}";
        }
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    return strOrigAndChanged;
  }

  private void SelectContact(object sender, EventArgs e)
  {
    if (this.lstContacts.SelectedIndex < 0)
      return;
    FormSettings.ShowForm(typeof (frmProducerContacts), (object) this.CurrentLocationRow.ProducerLocationGUID, (object) (Guid) this.lstContacts.SelectedValue);
    if (this._producerGuid.Equals(Guid.Empty))
      return;
    this.FillAllCallReports(this._producerGuid);
  }

  private void NewProducer()
  {
    this.dsProducer.tblProducerContacts.Clear();
    this.dsProducer.tblProducerLocations.Clear();
    this.dsProducer.tblProducers.Clear();
    dsProducers.tblProducersRow row = this.dsProducer.tblProducers.NewtblProducersRow();
    this._producerGuid = Guid.NewGuid();
    row.ProducerGUID = this._producerGuid;
    row.ProducerCode = 0;
    this.dsProducer.tblProducers.AddtblProducersRow(row);
    this.NewLocation();
    this.UpdateLocationsNavDisplay();
    this.ClientNewProducer();
  }

  protected virtual void DefaultLocationOverride(dsProducers.tblProducerLocationsRow dr)
  {
  }

  private void NewLocation()
  {
    dsProducers.tblProducerLocationsDataTable producerLocations = this.dsProducer.tblProducerLocations;
    dsProducers.tblProducerLocationsRow producerLocationsRow = producerLocations.NewtblProducerLocationsRow();
    producerLocationsRow.ProducerLocationGUID = Guid.NewGuid();
    producerLocationsRow.ProducerGUID = this._producerGuid;
    producerLocationsRow.DateAdded = DateAndTime.Now;
    int userId = CurrentUser.Instance.UserID;
    producerLocationsRow.AddedBy = userId;
    producerLocationsRow.DateModified = DateAndTime.Now;
    producerLocationsRow.ModifiedBy = userId;
    this.MgaInternationalPhone.CountryCode = "USA";
    this.MgaInternationalFax.CountryCode = "USA";
    this.MgaInternationalPhone.Value = (object) "";
    this.MgaInternationalFax.Value = (object) "";
    producerLocationsRow.CountryCodeforPhone = "USA";
    producerLocationsRow.CountryCodeforFax = "USA";
    producerLocationsRow.Phone = "";
    producerLocationsRow.Fax = "";
    producerLocationsRow.ZipCode = "";
    producerLocationsRow.ISOCountryCode = "USA";
    producerLocationsRow.City = "";
    producerLocationsRow.County = "";
    producerLocationsRow.State = "";
    if (CurrentUser.Instance.IsAccountingPackageActive)
    {
      producerLocationsRow.AllowAutomaticNOC = true;
      producerLocationsRow.EmailReminders = false;
    }
    this.DefaultLocationOverride(producerLocationsRow);
    producerLocations.AddtblProducerLocationsRow(producerLocationsRow);
    this.bmb.Position = this.bmb.Count - 1;
    this.dsProducer.tblProducerContacts.Clear();
    try
    {
      foreach (Control control in ((Control) this.UltraTabPageControl1).Controls)
      {
        if (control is ComboBox)
        {
          ((ComboBox) control).SelectedIndex = -1;
          ((ComboBox) control).SelectedIndex = -1;
        }
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    ((Control) this.btnNewContact).Enabled = false;
    ((Control) this.btnSelectContact).Enabled = false;
    ((Control) this.txtFax).Enabled = false;
    ((Control) this.txtPhone).Enabled = false;
    this.UpdateLocationsNavDisplay();
    this.ClientNewProducerLocation();
    this.cboReason.Value = (object) -1;
    ((TextEditorControlBase) this.txtStatusChangeComments).Clear();
    this._newProdLocBtnClicked = true;
  }

  private void bmb_PositionChanged(object sender, EventArgs e) => this.UpdateLocationsNavDisplay();

  private void UpdateLocationsNavDisplay()
  {
    ((Control) this.btnFirst).Enabled = this.bmb.Position > 0;
    ((Control) this.btnPrev).Enabled = this.bmb.Position > 0;
    ((Control) this.btnLast).Enabled = this.bmb.Position < this.bmb.Count - 1;
    ((Control) this.btnNext).Enabled = this.bmb.Position < this.bmb.Count - 1;
    ((Control) this.txtFax).Enabled = false;
    ((Control) this.txtPhone).Enabled = false;
    UltraLabel lblRecords = this.lblRecords;
    int num = this.bmb.Position + 1;
    string str1 = num.ToString();
    num = this.bmb.Count;
    string str2 = num.ToString();
    string str3 = $"{str1} of {str2}";
    ((ControlBase) lblRecords).Text = str3;
    this.ShowRichTextBoxesData();
    this.ClientShowLocationData();
    this.UpdateCallReportLocations();
    if (this.bmb.Position == -1 || this.CurrentLocationRow == null)
      return;
    if (this.CurrentLocationRow.IsZipCodeNull())
      return;
    try
    {
      this.ctlZipCode.ZipCode = this.CurrentLocationRow.ZipCode;
    }
    catch (ArgumentException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      this.ctlZipCode.ZipCode = this.CurrentLocationRow.ZipCode;
      ProjectData.ClearProjectError();
    }
  }

  private void UpdateCallReportLocations()
  {
    this.dvCallReports.RowFilter = string.Empty;
    if (this.bmb.Position == -1 || this.CurrentLocationRow == null)
      return;
    this.dvCallReports.RowFilter = $"ProducerLocationGuid='{this.CurrentLocationRow.ProducerLocationGUID.ToString()}'";
  }

  private void btnNewContact_Click(object sender, EventArgs e)
  {
    if (this.CurrentLocationRow == null)
    {
      int num1 = (int) MessageBox.Show("Please add a location to this producer before adding contacts.", "Location Required", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else if (!SecurityManager.Instance.AssertPermission("{72A14282-79A9-4911-AFE1-8CB943352762}"))
    {
      int num2 = (int) MessageBox.Show("You do not have permission to add new producer contacts.", "Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else if (this.bmb.Position != -1 && this.dsProducer.tblProducerLocations[this.bmb.Position].RowState == DataRowState.Added)
    {
      int num3 = (int) MessageBox.Show("Please save your new location before adding contacts.", "Save Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else
    {
      Cursor.Current = MgaCursors.WaitCursor;
      this.SaveChanges();
      FormSettings.ShowForm(typeof (frmProducerContacts), (object) this.CurrentLocationRow.ProducerLocationGUID);
      Cursor.Current = MgaCursors.Default;
    }
    this.lstContacts_SelectedIndexChanged((object) null, EventArgs.Empty);
  }

  private void ClearErrorProviders()
  {
    try
    {
      foreach (Control control in ((Control) this.tabLocationInfo).Controls)
        this.err.SetError(control, string.Empty);
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  protected virtual void ClientShowLocationData()
  {
  }

  protected virtual void UpdateClientOnMoveProducerLocation(
    Guid producerLocMoveFrom,
    Guid producerLocMoveTo)
  {
  }

  protected virtual void menuProducer_ToolClick(object sender, ToolClickEventArgs e)
  {
    Guid producerLocationGuid = this.dsProducer.tblProducerLocations[this.bmb.Position].ProducerLocationGUID;
    string key = ((ToolEventArgs) e).Tool.Key;
    // ISSUE: reference to a compiler-generated method
    switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(key))
    {
      case 362002613:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Producer/Line Blocking", false) == 0)
        {
          FormSettings.ShowForm(typeof (FormProducerLineBlocking), (object) this.ProducerGuid, (object) producerLocationGuid);
          break;
        }
        break;
      case 643604357:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Production Goal...", false) == 0)
        {
          FormSettings.ShowForm(typeof (FormBrokerProductionGoals), (object) producerLocationGuid);
          break;
        }
        break;
      case 716961717:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Licenses", false) == 0)
        {
          FormSettings.ShowForm(typeof (frmProducerLicenses), (object) producerLocationGuid, (object) ((TextEditorControlBase) this.txtLocation).Text, (object) this._refreshContacts);
          break;
        }
        break;
      case 767640444:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Producer Lines", false) == 0)
        {
          using (FormSettings.ShowFormDialog(typeof (frmProducerLines), (object) producerLocationGuid))
            break;
        }
        break;
      case 1311177825:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Requirements", false) == 0)
        {
          FormSettings.ShowForm(typeof (frmProducerRequirements), (object) producerLocationGuid, (object) ((TextEditorControlBase) this.txtLocation).Text);
          break;
        }
        break;
      case 1422629647:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Marketing", false) == 0)
        {
          FormSettings.ShowForm(typeof (frmProducerMarketing), (object) this._producerGuid);
          break;
        }
        break;
      case 1682430703:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Producer Lines (For Entire Producer) ...", false) == 0)
        {
          using (FormSettings.ShowFormDialog(typeof (frmProducerLines), (object) this.ProducerGuid, (object) producerLocationGuid))
            break;
        }
        break;
      case 2192848028:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Assign BillingTypes", false) == 0)
        {
          FormSettings.ShowForm(typeof (FormAssignBrokerBillingType), (object) producerLocationGuid);
          break;
        }
        break;
      case 2789256996:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "User Relationship", false) == 0)
        {
          FormSettings.ShowForm(typeof (FormProducerUserRelationship), (object) producerLocationGuid, (object) this.ProducerGuid);
          break;
        }
        break;
      case 3241718347:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Move Location To Another Producer", false) == 0)
        {
          this.RemoveFormInstance();
          Guid guid = Guid.Empty;
          using (frmSelection frmSelection = new frmSelection(frmSelection.SelectionTypes.Producer, true))
          {
            frmSelection.Launch = false;
            int num = (int) frmSelection.ShowDialog();
            guid = frmSelection.SelectedGuid;
          }
          if (!guid.Equals(Guid.Empty))
          {
            string selectedLocationName = this.GetSelectedLocationName(guid);
            if (!string.IsNullOrEmpty(selectedLocationName))
            {
              if (MessageBox.Show($"Do you wish to move the current producer location{"\n"}{"\n"}[{this.CurrentLocationRow.Name}]{"\n"}to{"\n"}[{selectedLocationName}]?", "Move Producer Location", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
              {
                if (!this.CurrentLocationRow.IsBillToProducerLocationGuidNull())
                {
                  if (MessageBox.Show("The bill-to address on this location will be reset when this producer is moved.", "Bill-To Address Reset", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.Cancel)
                    return;
                  this.CurrentLocationRow.SetBillToProducerLocationGuidNull();
                  this.cboBillTo.Value = (object) null;
                }
                int num1 = DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "SELECT dbo.GetNumberLocations(@ProducerGUID)", new object[2]
                {
                  (object) "@ProducerGUID",
                  (object) this.CurrentLocationRow.ProducerGUID
                });
                if (num1 == 1 && MessageBox.Show("Moving the only Location under a Producer will delete the Producer entity and all associated configurations.", "Producer Entity Deletion", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) != DialogResult.OK)
                  return;
                DefaultDatabase.ExecuteNonQuery("dbo.spMoveProducerLocation", new object[4]
                {
                  (object) "@producerLocFrom",
                  (object) this.CurrentLocationRow.ProducerLocationGUID,
                  (object) "@producerLocTo",
                  (object) guid
                });
                this.LogMoveAction(guid);
                this.UpdateClientOnMoveProducerLocation(this.CurrentLocationRow.ProducerLocationGUID, guid);
                if (num1 <= 1)
                  this.Close();
                int num2 = (int) MessageBox.Show(this.CurrentLocationRow.Name + " has been successfully moved", "Producer Location Moved", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                break;
              }
              break;
            }
            int num = (int) MessageBox.Show("The current operation was NOT successful.\n\nAn attempt was made to move the current producer location to its parent producer", "Operation Not Successful", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            break;
          }
          break;
        }
        break;
      case 3749943570:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Assign Client Offices", false) == 0)
        {
          FormSettings.ShowForm(typeof (FormAssignClientOffices), (object) producerLocationGuid);
          break;
        }
        break;
      case 4030098747:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Producer / Location Log", false) == 0)
        {
          FormSettings.ShowForm(typeof (FormProducerLog), (object) this._producerGuid, (object) producerLocationGuid);
          break;
        }
        break;
      case 4183262906:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Producer/Underwriter Assignment", false) == 0)
        {
          FormSettings.ShowForm(typeof (frmProducersUnderwriters), (object) producerLocationGuid);
          break;
        }
        break;
    }
    this._refreshContacts = false;
  }

  private void LogMoveAction(Guid selectedProducerLocationGuid)
  {
    string producerName = this.CurrentLocationRow.tblProducersRow.ProducerName;
    int producerCode = this.CurrentLocationRow.tblProducersRow.ProducerCode;
    string producerLocationId = this.CurrentLocationRow.ProducerLocationID;
    DataTable dataTable = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT  dbo.tblProducerLocations.ProducerLocationID, dbo.tblProducers.ProducerName,dbo.tblProducers.ProducerCode FROM            dbo.tblProducerLocations INNER JOIN  dbo.tblProducers ON dbo.tblProducerLocations.ProducerGUID = dbo.tblProducers.ProducerGUID WHERE (dbo.tblProducerLocations.ProducerLocationGUID = @ProducerLocationGUID)", new object[2]
    {
      (object) "@ProducerLocationGUID",
      (object) selectedProducerLocationGuid
    });
    if (dataTable.Rows.Count <= 0)
      return;
    string str = dataTable.Rows[0]["ProducerName"].ToString();
    int integer1 = Conversions.ToInteger(dataTable.Rows[0]["ProducerCode"]);
    int integer2 = Conversions.ToInteger(dataTable.Rows[0]["ProducerLocationID"]);
    CurrentUser.Instance.LogAction($"Producer : {producerName} Code: {producerCode.ToString()} Location ID: {producerLocationId.ToString()} was moved to Producer : {str} Code: {integer1.ToString()} Location ID: {integer2.ToString()}", this.CurrentLocationRow.ProducerLocationGUID, "ProducerLocationID");
  }

  private string GetSelectedLocationName(Guid locGuid)
  {
    string empty = string.Empty;
    string selectedLocationName;
    if (locGuid.Equals(this.CurrentLocationRow.ProducerLocationGUID))
    {
      selectedLocationName = empty;
    }
    else
    {
      try
      {
        foreach (DataRow row in DefaultDatabase.ExecuteDataTable("dbo.GetLocationsPerProducer", new object[4]
        {
          (object) "@producerGUID",
          (object) this.CurrentLocationRow.ProducerGUID,
          (object) "@ProducerLocationGuid",
          (object) this.CurrentLocationRow.ProducerLocationGUID
        }).Rows)
        {
          if (locGuid.Equals((Guid) row[0]))
          {
            selectedLocationName = empty;
            goto label_10;
          }
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      selectedLocationName = new ProducerLocation(locGuid).LocationName;
    }
label_10:
    return selectedLocationName;
  }

  private void RemoveFormInstance()
  {
    Form[] mdiChildren = MDIControls.Instance.MDIParent.MdiChildren;
    int index = 0;
    while (index < mdiChildren.Length)
    {
      if (mdiChildren[index] is frmSelection frmSelection)
      {
        frmSelection.Dispose();
        break;
      }
      checked { ++index; }
    }
  }

  private void ContactsMenuClick(object sender, EventArgs e)
  {
    try
    {
      foreach (MenuItem menuItem in this.mnuContacts.MenuItems)
        menuItem.Checked = false;
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    ((MenuItem) sender).Checked = true;
    if (this.mnuInactive.Checked)
      this.dsProducer.tblProducerContacts.DefaultView.RowFilter = "StatusID=2";
    else if (this.mnuActive.Checked)
      this.dsProducer.tblProducerContacts.DefaultView.RowFilter = "StatusID=1";
    else
      this.dsProducer.tblProducerContacts.DefaultView.RowFilter = string.Empty;
  }

  public event ISupportDocumentSystem.EntityInfoChangedEventHandler EntityInfoChanged;

  public event ISupportNoteSystem.EntityInfoChangedEventHandler EntityInfoChanged1;

  public static bool CanAddMGA()
  {
    return SecurityManager.Instance.AssertPermission("{9609FF8A-0776-4fac-9AA1-7728705B1940}");
  }

  public static bool CanAddRetailer()
  {
    return SecurityManager.Instance.AssertPermission("{4C8083A6-CA95-4e6a-9581-0D1529E6590E}");
  }

  public static bool CanAddWholeSaler()
  {
    return SecurityManager.Instance.AssertPermission("{D33EC04C-C716-4dfb-A47A-40F995680EF5}");
  }

  public static bool CanAddProducer()
  {
    return SecurityManager.Instance.AssertPermission("{5B098E3D-BAE4-42a2-BD20-EB5166A9D43A}");
  }

  public static bool CanEditRetailer()
  {
    return SecurityManager.Instance.AssertPermission("{3DF59352-B65E-43EF-96CE-AE36DCAA9AC4}");
  }

  public static bool CanEditWholesaler()
  {
    return SecurityManager.Instance.AssertPermission("{C21670F1-45C7-4129-BA80-AACCD25E0B81}");
  }

  public static bool CanEditMGA()
  {
    return SecurityManager.Instance.AssertPermission("{98535796-6A3D-4011-872E-B65BAFE32A52}");
  }

  private void cboProducerType_ValueChanged(object sender, EventArgs e)
  {
    this.OnProducerTypeValueChange(RuntimeHelpers.GetObjectValue(sender));
  }

  private void EnableDisableOwner()
  {
    if (!this._EstablishSourceAndOwnerCRM_ProducerRelationShip)
      return;
    ((Control) this.cboOwner).Enabled = false;
    if (string.IsNullOrEmpty(this.cboSource.Text))
      return;
    if ((int) (byte) this.cboSource.Value == this._Client_Existing_Relationship)
      ((Control) this.cboOwner).Enabled = true;
    else
      this.cboOwner.Value = (object) null;
  }

  private void cboSource_ValueChanged(object sender, EventArgs e) => this.EnableDisableOwner();

  private bool ValidLocationData()
  {
    bool flag = true;
    if (this._EstablishSourceAndOwnerCRM_ProducerRelationShip && !string.IsNullOrEmpty(this.cboSource.Text))
    {
      if ((int) (byte) this.cboSource.Value == this._Client_Existing_Relationship)
      {
        if (string.IsNullOrEmpty(this.cboOwner.Text))
        {
          flag = false;
          int num = (int) MessageBox.Show($"Data for the current location could not be saved.\n\nA source of '{this.cboSource.Text}' needs a owner", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
      }
      else if (!string.IsNullOrEmpty(this.cboOwner.Text))
        this.cboOwner.Value = (object) DBNull.Value;
    }
    return flag;
  }

  private void ShowProductionStatus()
  {
    this.lblProductionStatus.Text = "None";
    if (this.CurrentLocationRow == null)
      return;
    object objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar("spGetProductionStatus", new object[4]
    {
      (object) "@ProducerLocationGUID",
      (object) this.CurrentLocationRow.ProducerLocationGUID,
      (object) "@CutOffDate",
      (object) CurrentUser.ServerTime
    }));
    if (objectValue == null || objectValue == DBNull.Value)
      return;
    this.lblProductionStatus.Text = objectValue.ToString();
  }

  private void ShowRichTextBoxesData()
  {
    this.txtSpecFocusDept.Text = string.Empty;
    this.txtExpertise.Text = string.Empty;
    this.txtWholesaleRelationships.Text = string.Empty;
    if (this.CurrentLocationRow == null || this.CurrentLocationRow == DBNull.Value)
      return;
    if (!this.CurrentLocationRow.IsSpecFocusDeptNull())
    {
      try
      {
        this.txtSpecFocusDept.Rtf = this.CurrentLocationRow.SpecFocusDept;
      }
      catch (ArgumentException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        this.txtSpecFocusDept.Text = this.CurrentLocationRow.SpecFocusDept;
        ProjectData.ClearProjectError();
      }
    }
    if (!this.CurrentLocationRow.IsExpertiseNull())
    {
      try
      {
        this.txtExpertise.Rtf = this.CurrentLocationRow.Expertise;
      }
      catch (ArgumentException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        this.txtExpertise.Text = this.CurrentLocationRow.Expertise;
        ProjectData.ClearProjectError();
      }
    }
    if (!this.CurrentLocationRow.IsWholesaleRelationshipsNull())
    {
      try
      {
        this.txtWholesaleRelationships.Rtf = this.CurrentLocationRow.WholesaleRelationships;
      }
      catch (ArgumentException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        this.txtWholesaleRelationships.Text = this.CurrentLocationRow.WholesaleRelationships;
        ProjectData.ClearProjectError();
      }
    }
    if (!this.CurrentLocationRow.IsCountryCodeforPhoneNull())
    {
      try
      {
        this.MgaInternationalPhone.CountryCode = this.CurrentLocationRow.CountryCodeforPhone;
      }
      catch (ArgumentException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        this.MgaInternationalPhone.CountryCode = this.CurrentLocationRow.CountryCodeforPhone;
        ProjectData.ClearProjectError();
      }
    }
    if (!this.CurrentLocationRow.IsPhoneNull())
    {
      try
      {
        this.MgaInternationalPhone.Value = (object) this.CurrentLocationRow.Phone;
      }
      catch (ArgumentException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        this.MgaInternationalPhone.Text = this.CurrentLocationRow.Phone;
        ProjectData.ClearProjectError();
      }
    }
    if (!this.CurrentLocationRow.IsCountryCodeforFaxNull())
    {
      try
      {
        this.MgaInternationalFax.CountryCode = this.CurrentLocationRow.CountryCodeforFax;
      }
      catch (ArgumentException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        this.MgaInternationalFax.CountryCode = this.CurrentLocationRow.CountryCodeforFax;
        ProjectData.ClearProjectError();
      }
    }
    if (!this.CurrentLocationRow.IsFaxNull())
    {
      try
      {
        this.MgaInternationalFax.Value = (object) this.CurrentLocationRow.Fax;
      }
      catch (ArgumentException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        this.MgaInternationalFax.Text = this.CurrentLocationRow.Fax;
        ProjectData.ClearProjectError();
      }
    }
    if (!this.CurrentLocationRow.IsZipCodeNull())
    {
      try
      {
        this.ctlZipCode.ZipCode = this.CurrentLocationRow.ZipCode;
      }
      catch (ArgumentException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        this.ctlZipCode.ZipCode = this.CurrentLocationRow.ZipCode;
        ProjectData.ClearProjectError();
      }
    }
    if (!this.CurrentLocationRow.IsCityNull())
    {
      try
      {
        this.ctlZipCode.City = this.CurrentLocationRow.City;
      }
      catch (ArgumentException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        this.ctlZipCode.City = this.CurrentLocationRow.City;
        ProjectData.ClearProjectError();
      }
    }
    if (!this.CurrentLocationRow.IsCountyNull())
    {
      try
      {
        this.ctlZipCode.County = this.CurrentLocationRow.County;
      }
      catch (ArgumentException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        this.ctlZipCode.County = this.CurrentLocationRow.County;
        ProjectData.ClearProjectError();
      }
    }
    if (!this.CurrentLocationRow.IsStateNull())
    {
      try
      {
        this.ctlZipCode.State = this.CurrentLocationRow.State;
      }
      catch (ArgumentException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        this.ctlZipCode.State = this.CurrentLocationRow.State;
        ProjectData.ClearProjectError();
      }
    }
    this.ctlZipCode.ISOCountryCode = this.CurrentLocationRow.ISOCountryCode;
  }

  private void FillAllCallReports(Guid producerGuid)
  {
    this.dsProducer.tblProducerCallReport.Clear();
    DefaultDatabase.LoadDataTable((DataTable) this.dsProducer.tblProducerCallReport, "spGetAllCallReports", new object[2]
    {
      (object) "@producerGuid",
      (object) producerGuid
    });
    ((UltraGridBase) this.ugDetails).UpdateData();
  }

  protected virtual void FillClientMailchecktoCombo(DataTable dt)
  {
  }

  private void ugDetails_DoubleClick(object sender, EventArgs e)
  {
    if (((UltraGridBase) this.ugDetails).ActiveRow == null)
      return;
    UIElement lastElementEntered = ((ControlUIElementBase) ((UltraGridBase) this.ugDetails).DisplayLayout.UIElement).LastElementEntered;
    RowUIElement rowUiElement = !(lastElementEntered is RowUIElement) ? (RowUIElement) lastElementEntered.GetAncestor(typeof (RowUIElement)) : (RowUIElement) lastElementEntered;
    if (rowUiElement == null)
      return;
    UltraGridRow context = (UltraGridRow) ((UIElement) rowUiElement).GetContext(typeof (UltraGridRow));
    if (context == null)
      return;
    FormSettings.ShowFormDialog(typeof (FormProducerCallReports), (object) this.CurrentLocationRow.ProducerLocationGUID, (object) false, (object) Conversions.ToInteger(context.Cells["CallReportID"].Value));
    this.FillAllCallReports(this._producerGuid);
  }

  private void btnReport_Click(object sender, EventArgs e)
  {
    if (this.CurrentLocationRow == null)
    {
      int num1 = (int) MessageBox.Show("Please select a location to add call reports to.", "No Location Selected", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else if (this.CurrentLocationRow.RowState == DataRowState.Added)
    {
      int num2 = (int) MessageBox.Show("Please save the current location prior to adding call reports.", "Current Location Not Added", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else
    {
      FormSettings.ShowFormDialog(typeof (FormProducerCallReports), (object) this.CurrentLocationRow.ProducerLocationGUID, (object) true);
      this.FillAllCallReports(this._producerGuid);
    }
  }

  private void SetupLocationEdits()
  {
    foreach (UltraTab tab in ((UltraTabControlBase) this.tabLocationInfo).Tabs)
    {
      if (!tab.Key.Equals(string.Empty))
      {
        string key = tab.Key;
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "tabCRM", false) != 0)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "tabCallReports", false) != 0)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "tabPolicies", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "tabContactInfo", false) != 0)
            {
              this.SetTabState(tab, this._CanEditProducerLocation);
              ((Control) this.cboReason).Enabled = false;
              ((Control) this.txtStatusChangeComments).Enabled = false;
              ((Control) this.txtFax).Enabled = false;
              ((Control) this.txtPhone).Enabled = false;
            }
          }
          else
            this.SetTabState(tab, this._CanEditCallReports);
        }
        else
          this.SetTabState(tab, this._CanEditCRM);
      }
    }
  }

  private void SetTabState(UltraTab tab, bool enableTabState)
  {
    try
    {
      foreach (Control control in ((Control) tab.TabPage).Controls)
      {
        if (control.Tag == null || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(control.Tag.ToString(), "KeepEnabled", false) != 0)
          control.Enabled = enableTabState && this.dbSave.UIState == UIState.Editing;
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    ((Control) this.txtFax).Enabled = false;
    ((Control) this.txtPhone).Enabled = false;
  }

  protected virtual void StatusChange(object sender, EventArgs e)
  {
  }

  private void cbStatus_ValueChanged(object sender, EventArgs e)
  {
    if (this._newProdLocBtnClicked)
    {
      ((Control) this.cboReason).Enabled = false;
      ((Control) this.txtStatusChangeComments).Enabled = false;
    }
    else
    {
      ((Control) this.cboReason).Enabled = true;
      ((Control) this.txtStatusChangeComments).Enabled = true;
      this.cboReason.Value = (object) -1;
      ((TextEditorControlBase) this.txtStatusChangeComments).Clear();
    }
    this.StatusChange(RuntimeHelpers.GetObjectValue(sender), e);
  }

  private void btnNewImage_Click(object sender, EventArgs e)
  {
    using (OpenFileDialog openFileDialog = new OpenFileDialog())
    {
      openFileDialog.Title = "Please select a logo";
      openFileDialog.Filter = "Image Files|*.jpg;*.gif;*.bmp;*.png;*.jpeg|All Files|*.*";
      openFileDialog.FilterIndex = 1;
      openFileDialog.RestoreDirectory = true;
      if (openFileDialog.ShowDialog() != DialogResult.OK || !File.Exists(openFileDialog.FileName) || this.dsProducer.tblProducers.Rows.Count <= 0)
        return;
      ((dsProducers.tblProducersRow) this.dsProducer.tblProducers.Rows[0]).Logo = File.ReadAllBytes(openFileDialog.FileName);
    }
  }

  private void btnQueryDates_Click(object sender, EventArgs e)
  {
    if (this.dtStartDate.Value != null && this.dtStartDate.Value != DBNull.Value)
    {
      string s1 = this.dtStartDate.Value.ToString();
      if (this.dtEndDate.Value != null && this.dtEndDate.Value != DBNull.Value)
      {
        string s2 = this.dtEndDate.Value.ToString();
        DateTime result;
        if (!DateTime.TryParse(s1, out result) || !DateTime.TryParse(s2, out result))
          return;
        this.FillProducerStatistics();
      }
      else
      {
        int num = (int) MessageBox.Show("Missing End Date", "End Date Missing", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
    }
    else
    {
      int num1 = (int) MessageBox.Show("Missing Start Date", "Start Date Missing", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
  }

  private void Loadallproducers()
  {
    DefaultDatabase.LoadDataSet((DataSet) this.dsProducer, Strings.Split("lstProducers"), "spGetProducerList");
    ((UltraGridBase) this.cboProducerlocations).DataSource = (object) this.dsProducer;
    ((UltraGridBase) this.cboProducerlocations).DataMember = "lstProducers";
    ((UltraDropDownBase) this.cboProducerlocations).ValueMember = "ProducerGUID";
    ((UltraDropDownBase) this.cboProducerlocations).DisplayMember = "ProducerName";
  }

  private int GetSelectedLocationOriginalStatus(Guid locGuid)
  {
    this._originalProducerStatus = new ProducerLocation(locGuid).StatusID;
    return this._originalProducerStatus;
  }

  private void ugPoliciesGrid_InitializeLayout(object sender, InitializeLayoutEventArgs e)
  {
    e.Layout.Override.FilterUIType = (FilterUIType) 1;
  }

  private void MoveProducerRenewalBor()
  {
    object objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT TOP 1 Q.QuoteID  FROM  tblQuotes Q WITH (NOLOCK)  INNER JOIN tblProducerContacts PC WITH (NOLOCK) ON Q.ProducerContactGuid = PC.ProducerContactGUID  INNER JOIN tblProducerLocations PL WITH (NOLOCK) ON PC.ProducerLocationGUID = PL.ProducerLocationGUID   INNER JOIN tblMaxQuoteIDs WITH (NOLOCK) ON Q.QuoteID = tblMaxQuoteIDs.MaxBoundQuoteID   INNER JOIN tblQuotes2 WITH (NOLOCK) ON Q.QuoteID = tblQuotes2.QuoteID  WHERE (Q.ExpirationDate >= @currentDate)  AND (tblQuotes2.NewProducerContactOnBOR Is NULL)  AND (PL.ProducerLocationGUID = @PLG) ", new object[4]
    {
      (object) "@currentDate",
      (object) DateTime.Now,
      (object) "@PLG",
      (object) this.CurrentLocationRow.ProducerLocationGUID
    }));
    if (objectValue == null || objectValue == DBNull.Value || MessageBox.Show("The current location Is no longer active.\n\nSet renewal BOR on all bound In-force policies with an active producer?", "Assign Renewal BOR on all Bound In-Force Policies?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
      return;
    using (FormAssignNewProducer assignNewProducer = new FormAssignNewProducer(this.CurrentLocationRow.ProducerLocationGUID))
    {
      int num = (int) assignNewProducer.ShowDialog();
    }
  }

  private void lstContacts_SelectedIndexChanged(object sender, EventArgs e)
  {
    this.lblCurrentContact.Text = string.Empty;
    if (this.lstContacts.SelectedIndex < 0)
      return;
    dsProducers.tblProducerContactsRow producerContactGuid = this.dsProducer.tblProducerContacts.FindByProducerContactGUID((Guid) this.lstContacts.SelectedValue);
    if (producerContactGuid != null && !producerContactGuid.IsNameNull())
      this.lblCurrentContact.Text = producerContactGuid.Name;
    this.ShowOfacData(producerContactGuid);
  }

  private void ShowOfacData(dsProducers.tblProducerContactsRow contact)
  {
    if (!this._showOfac)
      return;
    this.dtOFACClearedDate.Value = (object) null;
    ((Control) this.chkOFACCleared).Tag = (object) null;
    ((UltraToggleEditorBase) this.chkOFACCleared).Checked = false;
    ((Control) this.chkOFACCleared).Enabled = false;
    this.lblOFACDate.Text = "OFAC Date:";
    this.lblOFACReturnCode.Text = "Return Code:";
    this.lblOfacClearedUser.Text = string.Empty;
    ((UltraGridBase) this.ugOFAC).DataSource = (object) null;
    if (contact == null)
      return;
    OfacSystem.OfacStatus ofacStatus = (OfacSystem.OfacStatus) null;
    if (!this._ofacData.TryGetValue(contact.ProducerContactGUID, out ofacStatus))
    {
      ofacStatus = OfacSystem.Instance.GetEntityStatus(contact.ProducerContactGUID, this.CurrentLocationRow?.ProducerLocationGUID);
      this._ofacData.Add(contact.ProducerContactGUID, ofacStatus);
    }
    if (ofacStatus == null)
      return;
    if (ofacStatus.IsHit)
    {
      ((Control) this.chkOFACCleared).Enabled = true;
      this.lblOFACDate.Text = $"OFAC Date: {ofacStatus.HitDate:d}";
    }
    else
      this.lblOFACDate.Text = $"Search Date: {ofacStatus.LogDate:d}";
    ((UltraToggleEditorBase) this.chkOFACCleared).Checked = ofacStatus.OFACCleared;
    this.dtOFACClearedDate.Value = (object) ofacStatus.ClearDate;
    Guid? clearByUserGuid = ofacStatus.ClearByUserGuid;
    if (clearByUserGuid.HasValue)
    {
      clearByUserGuid = ofacStatus.ClearByUserGuid;
      MGASystems.BusinessObjects.User user = new MGASystems.BusinessObjects.User(clearByUserGuid.Value);
      this.lblOfacClearedUser.Text = $"By: {(user.RecordExists() ? (object) user.Name_FirstLast : (object) "<UNKNOWN USER>")}";
    }
    this.lblOFACReturnCode.Text = $"Return Code: {ofacStatus.ReturnCode}";
    ((Control) this.chkOFACCleared).Tag = (object) ofacStatus;
    if (string.IsNullOrEmpty(ofacStatus.OfacXml))
      return;
    DataSet dataSet = ofacStatus.GetOfacDataset ?? new DataSet();
    ((UltraGridBase) this.ugOFAC).DataSource = (object) dataSet;
    ((UltraGridBase) this.ugOFAC).DataBind();
    if (dataSet.Tables.Count <= 0)
      return;
    if (((DisposableObjectCollectionBase) ((UltraGridBase) this.ugOFAC).DisplayLayout.Bands[0].Columns).Count > 13)
      ((UltraGridBase) this.ugOFAC).DisplayLayout.Bands[0].Columns[12].PerformAutoResize();
    ((UltraGridBase) this.ugOFAC).DisplayLayout.MaxColScrollRegions = 1;
    ((UltraGridBase) this.ugOFAC).UpdateData();
  }

  private void chkOFACCleared_CheckedChanged(object sender, EventArgs e)
  {
    if (!(((Control) this.chkOFACCleared).Tag is OfacSystem.OfacStatus tag))
      return;
    if (((UltraToggleEditorBase) this.chkOFACCleared).Checked)
    {
      OfacSystem.Instance.ClearOfacHit(tag.EntityGuid, tag.ParentEntityGuid, new Guid?(CurrentUser.Instance.UserGUID), new DateTime?(CurrentUser.ServerTime), "Cleared via Producer Location UI");
      this.lblOfacClearedUser.Text = $"By: {CurrentUser.Instance.DisplayName}";
      this.dtOFACClearedDate.Value = (object) DateTime.Today;
    }
    else
    {
      OfacSystem.Instance.ReinstateOfacHit(tag.EntityGuid, tag.ParentEntityGuid);
      this.lblOfacClearedUser.Text = string.Empty;
      this.dtOFACClearedDate.Value = (object) null;
    }
    this._ofacData[tag.EntityGuid] = OfacSystem.Instance.GetEntityStatus(tag.EntityGuid, tag.ParentEntityGuid);
  }

  private void getSirconData()
  {
    if (!Utilities.SirconEnabled)
      return;
    try
    {
      string text1 = ((TextEditorControlBase) this.txtProducerName).Text;
      string text2 = ((TextEditorControlBase) this.txtNPN).Text;
      ProducerDataRetriever.ProducerIdentifiers producerDataType = ProducerDataRetriever.ProducerIdentifiers.NPN;
      ProducerDataRetriever.ProducerType producerType = ProducerDataRetriever.ProducerType.Agency;
      if (string.IsNullOrEmpty(text1) | string.IsNullOrEmpty(text2))
      {
        this.tbOrgNPN.Text = text2;
        this.tbSirconMsg.Text = "Name or NPN Missing";
        this.tbSirconStatus.Text = "No Data";
      }
      else
        this.DisplaySirconResults(this.MakeSirconRequest(text1, text2, producerDataType, producerType));
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      this.tbSirconMsg.Text = ex.Message;
      this.tbSirconStatus.Text = "Exception Thrown";
      ProjectData.ClearProjectError();
    }
  }

  private ProducerData MakeSirconRequest(
    string producerName,
    string producerDataValue,
    ProducerDataRetriever.ProducerIdentifiers producerDataType,
    ProducerDataRetriever.ProducerType producerType)
  {
    ProducerDataRetriever producerDataRetriever = new ProducerDataRetriever();
    producerDataRetriever.SetSearchCriteria(producerName, producerDataType, producerDataValue, producerType);
    producerDataRetriever.AddSectionTypes(ProducerDataRetriever.SectionType.Licenses);
    producerDataRetriever.AddSectionTypes(ProducerDataRetriever.SectionType.Loas);
    return producerDataRetriever.RetrieveData();
  }

  private void DisplaySirconResults(ProducerData Result)
  {
    this.DsSirconDataSet.Clear();
    this.tbOrgNPN.Text = string.Empty;
    if (Result.isValid)
    {
      try
      {
        foreach (LicenseData licenseData in Result.lstLicenseData)
        {
          dsSirconDataSet.tblSirconLicensesRow row = this.DsSirconDataSet.tblSirconLicenses.NewtblSirconLicensesRow();
          row.Type = licenseData.Type;
          row.State = licenseData.State;
          row.Status = licenseData.Status;
          row.ExpirationDate = licenseData.ExpirationDate;
          row.Number = licenseData.Number;
          this.DsSirconDataSet.tblSirconLicenses.Rows.Add((DataRow) row);
        }
      }
      finally
      {
        List<LicenseData>.Enumerator enumerator;
        enumerator.Dispose();
      }
      try
      {
        foreach (LOAData loaData in Result.lstLOAData)
        {
          dsSirconDataSet.tblSirconLOAsRow row = this.DsSirconDataSet.tblSirconLOAs.NewtblSirconLOAsRow();
          row.Type = loaData.Type;
          row.State = loaData.State;
          row.Status = loaData.Status;
          row.StatusDate = loaData.StatusDate;
          row.ExpirationDate = loaData.ExpirationDate;
          this.DsSirconDataSet.tblSirconLOAs.Rows.Add((DataRow) row);
        }
      }
      finally
      {
        List<LOAData>.Enumerator enumerator;
        enumerator.Dispose();
      }
      this.tbOrgNPN.Text = Result.orgNPN;
    }
    this.tbSirconMsg.Text = Result.statusMessage;
    this.tbSirconStatus.Text = Result.SirconStatus;
  }

  private enum MenuState
  {
    Enabled,
    Disabled,
  }

  private delegate void FillProducerStatisticsThreadCompleteHandler(
    List<string> statList,
    DataRow dr);
}
