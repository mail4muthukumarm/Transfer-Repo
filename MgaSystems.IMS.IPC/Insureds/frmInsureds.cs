// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.Insureds.frmInsureds
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
using Mga.Wpf.Ims.ExtensionMethods;
using Mga.Wpf.Ims.Interop;
using MGASystems.AddressResolver;
using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Common.BroadcastMessaging;
using MGASystems.Common.CustomExceptions;
using MGASystems.Common.ErrorHandling;
using MGASystems.Common.Functions;
using MGASystems.Common.HotKeyManagement;
using MGASystems.Data;
using MGASystems.IMS.DocumentAutomation.TemplateDocuments;
using MGASystems.IMS.NoteDocuments;
using MGASystems.IMS.Reporting;
using MGASystems.IMS.Security;
using MGASystems.InfragisticsExtensions.Editors;
using MGASystems.Tools;
using MGASystems.Tools.DBSaveUI;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

#nullable disable
namespace MGASystems.IMS.InsuredsProducersCompanies.Insureds;

[SecureHotkeyResource("{C012DF59-9A5E-4ce7-BFFE-9B156038C97E}", "Create New Insured Hotkey", "Determines whether or not the user will be allowed to use the New Insured Hot Key", "Insureds")]
[SecureResource("{BB72FEAA-727A-4d7a-BE51-35DDA92459B6}", "Combine Insureds", "Controls whether or not a user is allowed to combine insureds.", "Insureds")]
[SecureResource("{09F4B2C7-F992-48a8-80C7-7481FA6ACB79}", "Edit Insured", "Controls the ability to edit the information of an Insured.", "Insureds")]
[SecureResource("{ADAE0A61-DE61-4aaf-8BCA-39F8158C9248}", "Add New Insureds / Location", "Controls whether or not a user is allowed to add insureds / locations.", "Insureds")]
[SecureResource("{BED4EDC7-CEE8-444B-9BE3-45A3A06DA7CD}", "Edit DOB", "Controls the ability to edit DOB.", "Insureds")]
[SecureResource("{4951C7B9-9EBC-4711-B3EB-86E9649310E3}", "Add Submissions", "Controls whether or not a user is allowed to add submissions from the Insureds screen.", "Insureds")]
[SecureResource("{65b7a17f-e9e2-4714-8275-f4611a0ea2a6}", "View Insured Screen Invoices Tab", "Controls the ability to view the Invoices tab on the Edit Insureds Screen", "Insureds")]
[SecureResource("{AB502BED-6A60-473D-8B06-B7F180F87B2B}", "Edit OFAC Cleared", "Controls whether or not a user is allowed to edit OFAC Cleared.", "Insureds")]
[SecureResource("{A3B94A69-F5FE-4C86-A927-93D45BC9E2D8}", "Clear OFAC And Generate Historical Data", "Controls whether or not a user is clear OFAC and generate historical data.", "Insureds")]
[SecureResource("{4c3f185b-29ad-45c2-9c06-7d6a696f4bfb}", "View Insured Screen Statistics Tab", "Controls the ability to view the Statistics tab on the Edit Insureds Screen", "Insureds")]
[SecureResource("{b0bef290-e672-4668-a754-01e0854cb3ab}", "View Insured Screen Contacts Tab", "Controls the ability to view the contacts tab on the edit Insureds Screen", "Insureds")]
[SecureResource("{BCF20F77-76DB-445D-9FDC-7F653B692779}", "Rerun Insured OFAC", "Controls the ability to rerun Insured OFAC ", "Insureds")]
[DocumentFolderFilter("Insured Form")]
[HotKeyInfo("New_Insured", "New Insured", "This will create a new insured", Keys.F3, "MGASystems.Tools.user_add.png")]
public class frmInsureds : 
  Form,
  ISupportNoteSystem,
  ISupportDocumentSystem,
  ISupportInsuredLocationTemplateDocs
{
  private IContainer components;
  private Label lblCity;
  protected ToolTip ToolTip;
  private MGATextBox txtWebSite;
  private Label Label8;
  private SqlDataAdapter daInsureds;
  private SqlDataAdapter daContacts;
  private SqlDataAdapter daLocations;
  private Label Label4;
  private MGATextBox txtLocation;
  private Label Label7;
  private MGASimpleComboBox cboDeliveryMethod;
  private Label Label9;
  private Label Label10;
  protected UltraLabel lblRecords;
  private Label Label14;
  private MGASimpleComboBox cbOfficeType;
  private SqlConnection cnSQL;
  protected UltraGroupBox gbInsuredInfo;
  protected ErrorProvider ErrProvider;
  private ContextMenu mnuContacts;
  private SqlCommand SqlSelectCommand4;
  private Label Label2;
  private Label lblFEIN;
  protected MGAMaskedEdit txtSSN;
  private Label Label6;
  private Label Label11;
  private Label Label12;
  private Label Label13;
  private MGATextBox txtDateAdded;
  private UltraToolbarsDockArea _frmInsureds_Toolbars_Dock_Area_Left;
  private UltraToolbarsDockArea _frmInsureds_Toolbars_Dock_Area_Right;
  private UltraToolbarsDockArea _frmInsureds_Toolbars_Dock_Area_Top;
  private UltraToolbarsDockArea _frmInsureds_Toolbars_Dock_Area_Bottom;
  protected UltraGroupBox gbInsuredInfo2;
  private Label Label15;
  private MGATextBox txtEmail;
  private SqlCommand SqlSelectCommand3;
  private SqlCommand SqlInsertCommand1;
  private SqlCommand SqlUpdateCommand1;
  private SqlCommand SqlDeleteCommand2;
  private Label Label17;
  protected MGATextBox txtPolicyName;
  private UltraTabSharedControlsPage UltraTabSharedControlsPage1;
  private SqlCommand SqlSelectCommand2;
  private SqlDataAdapter daLookups;
  private SqlCommand SqlSelectCommand1;
  private SqlCommand SqlInsertCommand2;
  private SqlCommand SqlUpdateCommand2;
  private SqlCommand SqlDeleteCommand1;
  internal const string NewInsured = "{C012DF59-9A5E-4ce7-BFFE-9B156038C97E}";
  internal const string CombineInsureds = "{BB72FEAA-727A-4d7a-BE51-35DDA92459B6}";
  public const string CanAddNewInsureds = "{ADAE0A61-DE61-4aaf-8BCA-39F8158C9248}";
  public const string CanAddSubmissions = "{4951C7B9-9EBC-4711-B3EB-86E9649310E3}";
  internal const string EditInsured = "{09F4B2C7-F992-48a8-80C7-7481FA6ACB79}";
  internal const string CanEditDateOfBirth = "{BED4EDC7-CEE8-444B-9BE3-45A3A06DA7CD}";
  internal const string CanEditOFACCleard = "{AB502BED-6A60-473D-8B06-B7F180F87B2B}";
  internal const string CanViewTabInvoicesInsureds = "{65b7a17f-e9e2-4714-8275-f4611a0ea2a6}";
  internal const string CanClearOFACAndUpdateHistoricalData = "{A3B94A69-F5FE-4C86-A927-93D45BC9E2D8}";
  internal const string CanViewTabStatisticsInsured = "{4c3f185b-29ad-45c2-9c06-7d6a696f4bfb}";
  internal const string CanViewTabContactsInsured = "{b0bef290-e672-4668-a754-01e0854cb3ab}";
  internal const string CanRerunInsuredOFAC = "{BCF20F77-76DB-445D-9FDC-7F653B692779}";
  private Guid _insuredGuid;
  private Guid _moveToInsuredLocationGuid;
  private bool _canAddSubmissions;
  private bool _CanEditDateOfBirth;
  private bool _CanEditInsured;
  private bool _canAddInsured;
  private bool _canEditOFACCleared;
  private bool _canViewInvoicesTab;
  private Lazy<bool> _skipOfacOnNewInsured;
  private Lazy<bool> _skipOfacOnModifiedInsured;
  protected bool _showOfacTab;
  private bool _canClearOFACAndUpdateHistoricalData;
  private bool _tabStatisticsPainted;
  private Thread _statisticsThread;
  private object _lock;
  private bool _showInsuredCallReportsTab;
  private bool _UnlockIndividualType;
  private bool _producerStatusChanged;
  private int _origInsuredStatuID;
  private string _origInsuredStatusComment;
  private bool _assignClientOffices;
  private OfacSystem.OfacStatus _ofacStatus;
  private bool _implementInsuredScores;
  private static dsInsured.CompanyLinesDataTable _compLineCache = (dsInsured.CompanyLinesDataTable) null;
  private Lazy<MGASystems.BusinessObjects.Insured> _insuredEntity;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [field: AccessedThroughProperty("lblPhone")]
  protected virtual Label lblPhone { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label3")]
  protected virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MGAListBox lstContacts
  {
    get => this._lstContacts;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnContacts_Click);
      MGAListBox lstContacts1 = this._lstContacts;
      if (lstContacts1 != null)
        lstContacts1.DoubleClick -= eventHandler;
      this._lstContacts = value;
      MGAListBox lstContacts2 = this._lstContacts;
      if (lstContacts2 == null)
        return;
      lstContacts2.DoubleClick += eventHandler;
    }
  }

  private virtual MGAButton btnContacts
  {
    get => this._btnContacts;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnContacts_Click);
      MGAButton btnContacts1 = this._btnContacts;
      if (btnContacts1 != null)
        ((Control) btnContacts1).Click -= eventHandler;
      this._btnContacts = value;
      MGAButton btnContacts2 = this._btnContacts;
      if (btnContacts2 == null)
        return;
      ((Control) btnContacts2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("txtInsuredCode")]
  protected virtual MGATextBox txtInsuredCode { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  protected virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

  protected virtual MGAButton btnNewInsuredLocation
  {
    get => this._btnNewInsuredLocation;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnNewInsuredLocation_Click);
      MGAButton newInsuredLocation1 = this._btnNewInsuredLocation;
      if (newInsuredLocation1 != null)
        ((Control) newInsuredLocation1).Click -= eventHandler;
      this._btnNewInsuredLocation = value;
      MGAButton newInsuredLocation2 = this._btnNewInsuredLocation;
      if (newInsuredLocation2 == null)
        return;
      ((Control) newInsuredLocation2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("dsInsured")]
  protected virtual dsInsured dsInsured { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

  [field: AccessedThroughProperty("txtFEIN")]
  protected virtual MGAMaskedEdit txtFEIN { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ZipCodeResolver1")]
  protected virtual AddressResolver_MULTI ZipCodeResolver1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

  [field: AccessedThroughProperty("Label16")]
  protected virtual Label Label16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboInsuredType")]
  protected virtual MGASimpleComboBox cboInsuredType { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label5")]
  protected virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtBusiness")]
  protected virtual MGATextBox txtBusiness { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtMiddle")]
  protected virtual MGATextBox txtMiddle { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtLast")]
  protected virtual MGATextBox txtLast { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboSalutations")]
  protected virtual MGASimpleComboBox cboSalutations { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtFirst")]
  protected virtual MGATextBox txtFirst { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual UltraToolbarsManager UltraToolbarsManager1
  {
    get => this._UltraToolbarsManager1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      ToolClickEventHandler clickEventHandler = new ToolClickEventHandler(this.UltraToolbarsManager1_ToolClick);
      UltraToolbarsManager toolbarsManager1_1 = this._UltraToolbarsManager1;
      if (toolbarsManager1_1 != null)
        toolbarsManager1_1.ToolClick -= clickEventHandler;
      this._UltraToolbarsManager1 = value;
      UltraToolbarsManager toolbarsManager1_2 = this._UltraToolbarsManager1;
      if (toolbarsManager1_2 == null)
        return;
      toolbarsManager1_2.ToolClick += clickEventHandler;
    }
  }

  protected virtual LinkLabel lnkAddSubmissionGroup
  {
    get => this._lnkAddSubmissionGroup;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkAddSubmissionGroup_LinkClicked);
      LinkLabel addSubmissionGroup1 = this._lnkAddSubmissionGroup;
      if (addSubmissionGroup1 != null)
        addSubmissionGroup1.LinkClicked -= clickedEventHandler;
      this._lnkAddSubmissionGroup = value;
      LinkLabel addSubmissionGroup2 = this._lnkAddSubmissionGroup;
      if (addSubmissionGroup2 == null)
        return;
      addSubmissionGroup2.LinkClicked += clickedEventHandler;
    }
  }

  private virtual UltraGrid dgInvoices
  {
    get => this._dgInvoices;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      RowEventHandler rowEventHandler = new RowEventHandler(this.dgInvoices_AfterRowInsert);
      PaintEventHandler paintEventHandler = new PaintEventHandler(this.dgInvoices_Paint);
      UltraGrid dgInvoices1 = this._dgInvoices;
      if (dgInvoices1 != null)
      {
        dgInvoices1.AfterRowInsert -= rowEventHandler;
        ((Control) dgInvoices1).Paint -= paintEventHandler;
      }
      this._dgInvoices = value;
      UltraGrid dgInvoices2 = this._dgInvoices;
      if (dgInvoices2 == null)
        return;
      dgInvoices2.AfterRowInsert += rowEventHandler;
      ((Control) dgInvoices2).Paint += paintEventHandler;
    }
  }

  [field: AccessedThroughProperty("cboInsStatus")]
  protected virtual MGASimpleComboBox cboInsStatus { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtDBA")]
  protected virtual MGATextBox txtDBA { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

  private virtual LinkLabel lnkUseInsured
  {
    get => this._lnkUseInsured;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkUseInsured_LinkClicked);
      LinkLabel lnkUseInsured1 = this._lnkUseInsured;
      if (lnkUseInsured1 != null)
        lnkUseInsured1.LinkClicked -= clickedEventHandler;
      this._lnkUseInsured = value;
      LinkLabel lnkUseInsured2 = this._lnkUseInsured;
      if (lnkUseInsured2 == null)
        return;
      lnkUseInsured2.LinkClicked += clickedEventHandler;
    }
  }

  protected virtual MGASystems.Tools.DBSaveUI.DBSaveUI dbSave
  {
    get => this._dbSave;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      CancelEventHandler cancelEventHandler1 = new CancelEventHandler(this.dbSave_ClickingEdit);
      CancelEventHandler cancelEventHandler2 = new CancelEventHandler(this.dbSave_ClickingDelete);
      CancelEventHandler cancelEventHandler3 = new CancelEventHandler(this.dbSave_ClickingNew);
      CancelEventHandler cancelEventHandler4 = new CancelEventHandler(this.dbSave_ClickingCancel);
      EventHandler eventHandler = new EventHandler(this.dbSave_UIStateChanged);
      CancelEventHandler cancelEventHandler5 = new CancelEventHandler(this.dbSave_ClickingSave);
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave1 = this._dbSave;
      if (dbSave1 != null)
      {
        dbSave1.ClickingEdit -= cancelEventHandler1;
        dbSave1.ClickingDelete -= cancelEventHandler2;
        dbSave1.ClickingNew -= cancelEventHandler3;
        dbSave1.ClickingCancel -= cancelEventHandler4;
        dbSave1.UIStateChanged -= eventHandler;
        dbSave1.ClickingSave -= cancelEventHandler5;
      }
      this._dbSave = value;
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave2 = this._dbSave;
      if (dbSave2 == null)
        return;
      dbSave2.ClickingEdit += cancelEventHandler1;
      dbSave2.ClickingDelete += cancelEventHandler2;
      dbSave2.ClickingNew += cancelEventHandler3;
      dbSave2.ClickingCancel += cancelEventHandler4;
      dbSave2.UIStateChanged += eventHandler;
      dbSave2.ClickingSave += cancelEventHandler5;
    }
  }

  protected virtual UltraTabControl tabControl
  {
    get => this._tabControl;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      SelectedTabChangedEventHandler changedEventHandler = new SelectedTabChangedEventHandler(this.tabControl_SelectedTabChanged);
      UltraTabControl tabControl1 = this._tabControl;
      if (tabControl1 != null)
        ((UltraTabControlBase) tabControl1).SelectedTabChanged -= changedEventHandler;
      this._tabControl = value;
      UltraTabControl tabControl2 = this._tabControl;
      if (tabControl2 == null)
        return;
      ((UltraTabControlBase) tabControl2).SelectedTabChanged += changedEventHandler;
    }
  }

  [field: AccessedThroughProperty("UltraTabPageControl1")]
  protected virtual UltraTabPageControl UltraTabPageControl1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraTabPageControl2")]
  protected virtual UltraTabPageControl UltraTabPageControl2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraTabPageControl3")]
  protected virtual UltraTabPageControl UltraTabPageControl3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtAddedBy")]
  private virtual MGATextBox txtAddedBy { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label18")]
  private virtual Label Label18 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label19")]
  protected virtual Label Label19 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dtDOB")]
  protected virtual MGADateTimePicker dtDOB { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblRiskId")]
  private virtual Label lblRiskId { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtRiskID")]
  protected virtual MGATextBox txtRiskID { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtCarrierId")]
  protected virtual MGATextBox txtCarrierId { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblCarrierId")]
  protected virtual Label lblCarrierId { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual LinkLabel lnkShowMap
  {
    get => this._lnkShowMap;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkShowMap_LinkClicked);
      LinkLabel lnkShowMap1 = this._lnkShowMap;
      if (lnkShowMap1 != null)
        lnkShowMap1.LinkClicked -= clickedEventHandler;
      this._lnkShowMap = value;
      LinkLabel lnkShowMap2 = this._lnkShowMap;
      if (lnkShowMap2 == null)
        return;
      lnkShowMap2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("lblMobile")]
  protected virtual Label lblMobile { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblTaxID")]
  private virtual Label lblTaxID { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaTextBox1")]
  private virtual MGATextBox MgaTextBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblDNBNumber")]
  protected internal virtual Label lblDNBNumber { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtlblDNBNumber")]
  protected virtual MGATextBox txtlblDNBNumber { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("tabOFAC")]
  protected virtual UltraTabPageControl tabOFAC { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ugOFAC")]
  protected virtual UltraGrid ugOFAC { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblOFACDate")]
  protected virtual Label lblOFACDate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblOFACReturnCode")]
  protected virtual Label lblOFACReturnCode { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkOFACCleared")]
  protected virtual MGACheckBox chkOFACCleared { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cmbGender")]
  protected virtual MGASimpleComboBox cmbGender { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblGender")]
  private virtual Label lblGender { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual MGAButton btnClearOFAC
  {
    get => this._btnClearOFAC;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnClearOFAC_Click);
      MGAButton btnClearOfac1 = this._btnClearOFAC;
      if (btnClearOfac1 != null)
        ((Control) btnClearOfac1).Click -= eventHandler;
      this._btnClearOFAC = value;
      MGAButton btnClearOfac2 = this._btnClearOFAC;
      if (btnClearOfac2 == null)
        return;
      ((Control) btnClearOfac2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("UltraTabPageControl4")]
  protected virtual UltraTabPageControl UltraTabPageControl4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

  [field: AccessedThroughProperty("Label37")]
  private virtual Label Label37 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label36")]
  private virtual Label Label36 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dtEndDate")]
  internal virtual MGADateTimePicker dtEndDate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dtStartDate")]
  internal virtual MGADateTimePicker dtStartDate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblNumSubmitted")]
  private virtual UltraLabel lblNumSubmitted { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label34")]
  private virtual Label Label34 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

  private virtual MGASimpleComboBox cboCompanyLines
  {
    get => this._cboCompanyLines;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.cboCompanyLines_ValueChanged);
      MGASimpleComboBox cboCompanyLines1 = this._cboCompanyLines;
      if (cboCompanyLines1 != null)
        cboCompanyLines1.ValueChanged -= eventHandler;
      this._cboCompanyLines = value;
      MGASimpleComboBox cboCompanyLines2 = this._cboCompanyLines;
      if (cboCompanyLines2 == null)
        return;
      cboCompanyLines2.ValueChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("Label22")]
  protected virtual Label Label22 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chartStats")]
  protected virtual Infragistics.Win.UltraWinChart.UltraChart chartStats { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblTotalPremium")]
  private virtual UltraLabel lblTotalPremium { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label21")]
  protected virtual Label Label21 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblRenewalRetention")]
  private virtual UltraLabel lblRenewalRetention { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label23")]
  private virtual Label Label23 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblDeclineRatio")]
  private virtual UltraLabel lblDeclineRatio { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label24")]
  private virtual Label Label24 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblBindRatio")]
  private virtual UltraLabel lblBindRatio { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label25")]
  private virtual Label Label25 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblQuoteRatio")]
  private virtual UltraLabel lblQuoteRatio { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label26")]
  private virtual Label Label26 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

  [field: AccessedThroughProperty("dvCallReports")]
  private virtual DataView dvCallReports { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("tabCRM")]
  protected virtual UltraTabPageControl tabCRM { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblReferredBy")]
  protected virtual Label lblReferredBy { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboProducerlocations")]
  protected virtual MGAComboBox cboProducerlocations { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label29")]
  private virtual Label Label29 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaComboBox1")]
  protected virtual MGAComboBox MgaComboBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dtProdAgrrmntEff")]
  internal virtual MGADateTimePicker dtProdAgrrmntEff { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label28")]
  private virtual Label Label28 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkApproveWholesalersList")]
  private virtual MGACheckBox chkApproveWholesalersList { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkSetProcedureToEngage")]
  private virtual MGACheckBox chkSetProcedureToEngage { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraGroupBox2")]
  protected virtual UltraGroupBox UltraGroupBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtWholesaleRelationships")]
  protected virtual RichTextBox txtWholesaleRelationships { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraGroupBox1")]
  protected virtual UltraGroupBox UltraGroupBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtExpertise")]
  protected virtual RichTextBox txtExpertise { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraGroupBox4")]
  protected virtual UltraGroupBox UltraGroupBox4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtSpecFocusDept")]
  protected virtual RichTextBox txtSpecFocusDept { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label27")]
  private virtual Label Label27 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("numWholesaleRel")]
  private virtual MGANumericEditor numWholesaleRel { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

  [field: AccessedThroughProperty("cboSource")]
  protected virtual MGAComboBox cboSource { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

  [field: AccessedThroughProperty("lblStatusChangeReason")]
  protected virtual Label lblStatusChangeReason { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtStatusChangeComments")]
  protected virtual MGATextBox txtStatusChangeComments { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblOfacClearedDate")]
  private virtual Label lblOfacClearedDate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dtOFACClearedDate")]
  private virtual MGADateTimePicker dtOFACClearedDate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkOptOut")]
  protected virtual MGACheckBox chkOptOut { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaInternationalMobile")]
  protected virtual MGAInternationalPhoneNumberEditor MgaInternationalMobile { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaInternationaFax")]
  protected virtual MGAInternationalPhoneNumberEditor MgaInternationaFax { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaInternationalPhone")]
  protected virtual MGAInternationalPhoneNumberEditor MgaInternationalPhone { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label20")]
  protected virtual Label Label20 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual LinkLabel lnkOrderInsuranceScoreReport
  {
    get => this._lnkOrderInsuranceScoreReport;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkOrderInsuranceScoreReport_LinkClicked);
      LinkLabel insuranceScoreReport1 = this._lnkOrderInsuranceScoreReport;
      if (insuranceScoreReport1 != null)
        insuranceScoreReport1.LinkClicked -= clickedEventHandler;
      this._lnkOrderInsuranceScoreReport = value;
      LinkLabel insuranceScoreReport2 = this._lnkOrderInsuranceScoreReport;
      if (insuranceScoreReport2 == null)
        return;
      insuranceScoreReport2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("lnkInsuranceScoreNotice")]
  protected virtual LinkLabel lnkInsuranceScoreNotice { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblInsuredScore")]
  protected virtual Label lblInsuredScore { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtInsuredScoreStatus")]
  protected virtual MGATextBox txtInsuredScoreStatus { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmInsureds));
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
    UltraGridBand ultraGridBand1 = new UltraGridBand("Invoices", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("AmtBilled");
    Infragistics.Win.Appearance appearance18 = new Infragistics.Win.Appearance();
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("DueDate");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("OfficeInvoiceNum");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("InsuredGuid");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("View");
    Infragistics.Win.Appearance appearance19 = new Infragistics.Win.Appearance();
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("InvoiceDate");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("PolicyNumber");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("InvoiceNum");
    Infragistics.Win.Appearance appearance20 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance21 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance22 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance23 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance24 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance25 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance26 = new Infragistics.Win.Appearance();
    ScrollBarLook scrollBarLook1 = new ScrollBarLook();
    Infragistics.Win.Appearance appearance27 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance28 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance29 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance30 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance31 = new Infragistics.Win.Appearance();
    UltraGridBand ultraGridBand2 = new UltraGridBand("Invoices", -1);
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("AmtBilled");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("DueDate");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("OfficeInvoiceNum");
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("InsuredGuid");
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("View");
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("InvoiceDate");
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("PolicyNumber");
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("InvoiceNum");
    Infragistics.Win.Appearance appearance32 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance33 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance34 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance35 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance36 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance37 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance38 = new Infragistics.Win.Appearance();
    ScrollBarLook scrollBarLook2 = new ScrollBarLook();
    Infragistics.Win.Appearance appearance39 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance40 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance41 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance42 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance43 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance44 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance45 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance46 = new Infragistics.Win.Appearance();
    PaintElement paintElement = new PaintElement();
    Infragistics.Win.Appearance appearance47 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance48 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance49 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance50 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance51 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance52 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance53 = new Infragistics.Win.Appearance();
    UltraGridBand ultraGridBand3 = new UltraGridBand("tblInsuredCallReport", -1);
    UltraGridColumn ultraGridColumn17 = new UltraGridColumn("CallReportID");
    UltraGridColumn ultraGridColumn18 = new UltraGridColumn("DateOfVisit");
    UltraGridColumn ultraGridColumn19 = new UltraGridColumn("CallType");
    UltraGridColumn ultraGridColumn20 = new UltraGridColumn("LeadContact");
    UltraGridColumn ultraGridColumn21 = new UltraGridColumn("InsuredLocationGuid");
    Infragistics.Win.Appearance appearance54 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance55 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance56 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance57 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance58 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance59 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance60 = new Infragistics.Win.Appearance();
    ScrollBarLook scrollBarLook3 = new ScrollBarLook();
    Infragistics.Win.Appearance appearance61 = new Infragistics.Win.Appearance();
    UltraGridBand ultraGridBand4 = new UltraGridBand("tblProducers", -1);
    UltraGridColumn ultraGridColumn22 = new UltraGridColumn("ProducerGUID");
    UltraGridColumn ultraGridColumn23 = new UltraGridColumn("ProducerName");
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
    Infragistics.Win.Appearance appearance73 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance74 = new Infragistics.Win.Appearance();
    ScrollBarLook scrollBarLook4 = new ScrollBarLook();
    Infragistics.Win.Appearance appearance75 = new Infragistics.Win.Appearance();
    UltraGridBand ultraGridBand5 = new UltraGridBand("lstInsuredRankings", -1);
    UltraGridColumn ultraGridColumn24 = new UltraGridColumn("ID");
    UltraGridColumn ultraGridColumn25 = new UltraGridColumn("InsuredRanking");
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
    Infragistics.Win.Appearance appearance87 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance88 = new Infragistics.Win.Appearance();
    ScrollBarLook scrollBarLook5 = new ScrollBarLook();
    Infragistics.Win.Appearance appearance89 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance90 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance91 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance92 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance93 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance94 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance95 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance96 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance97 = new Infragistics.Win.Appearance();
    UltraGridBand ultraGridBand6 = new UltraGridBand("tblUsers", -1);
    UltraGridColumn ultraGridColumn26 = new UltraGridColumn("UserGUID");
    UltraGridColumn ultraGridColumn27 = new UltraGridColumn("Name_LastFirst");
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
    Infragistics.Win.Appearance appearance109 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance110 = new Infragistics.Win.Appearance();
    ScrollBarLook scrollBarLook6 = new ScrollBarLook();
    Infragistics.Win.Appearance appearance111 = new Infragistics.Win.Appearance();
    UltraGridBand ultraGridBand7 = new UltraGridBand("lstProductionPotential", -1);
    UltraGridColumn ultraGridColumn28 = new UltraGridColumn("ID");
    UltraGridColumn ultraGridColumn29 = new UltraGridColumn("Description");
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
    Infragistics.Win.Appearance appearance123 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance124 = new Infragistics.Win.Appearance();
    ScrollBarLook scrollBarLook7 = new ScrollBarLook();
    Infragistics.Win.Appearance appearance125 = new Infragistics.Win.Appearance();
    UltraGridBand ultraGridBand8 = new UltraGridBand("lstInsuredLocationSource", -1);
    UltraGridColumn ultraGridColumn30 = new UltraGridColumn("ID");
    UltraGridColumn ultraGridColumn31 = new UltraGridColumn("Source");
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
    Infragistics.Win.Appearance appearance137 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance138 = new Infragistics.Win.Appearance();
    ScrollBarLook scrollBarLook8 = new ScrollBarLook();
    Infragistics.Win.Appearance appearance139 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance140 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance141 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance142 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance143 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance144 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance145 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance146 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance147 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance148 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance149 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance150 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance151 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance152 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance153 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance154 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance155 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance156 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance157 = new Infragistics.Win.Appearance();
    UltraToolbar ultraToolbar = new UltraToolbar("MainMenu");
    PopupMenuTool popupMenuTool1 = new PopupMenuTool("Insured");
    PopupMenuTool popupMenuTool2 = new PopupMenuTool("Insured");
    ButtonTool buttonTool1 = new ButtonTool("Combine Insureds");
    ButtonTool buttonTool2 = new ButtonTool("Current Loss Information");
    ButtonTool buttonTool3 = new ButtonTool("Assign Client Offices");
    ButtonTool buttonTool4 = new ButtonTool("Combine Insureds");
    ButtonTool buttonTool5 = new ButtonTool("Current Loss Information");
    ButtonTool buttonTool6 = new ButtonTool("Assign Client Offices");
    UltraTab ultraTab1 = new UltraTab();
    Infragistics.Win.Appearance appearance158 = new Infragistics.Win.Appearance();
    UltraTab ultraTab2 = new UltraTab();
    Infragistics.Win.Appearance appearance159 = new Infragistics.Win.Appearance();
    UltraTab ultraTab3 = new UltraTab();
    Infragistics.Win.Appearance appearance160 = new Infragistics.Win.Appearance();
    UltraTab ultraTab4 = new UltraTab();
    Infragistics.Win.Appearance appearance161 = new Infragistics.Win.Appearance();
    UltraTab ultraTab5 = new UltraTab();
    Infragistics.Win.Appearance appearance162 = new Infragistics.Win.Appearance();
    UltraTab ultraTab6 = new UltraTab();
    UltraTab ultraTab7 = new UltraTab();
    this.UltraTabPageControl1 = new UltraTabPageControl();
    this.txtInsuredScoreStatus = new MGATextBox();
    this.lblInsuredScore = new Label();
    this.lnkInsuranceScoreNotice = new LinkLabel();
    this.lnkOrderInsuranceScoreReport = new LinkLabel();
    this.MgaInternationalMobile = new MGAInternationalPhoneNumberEditor();
    this.MgaInternationaFax = new MGAInternationalPhoneNumberEditor();
    this.MgaInternationalPhone = new MGAInternationalPhoneNumberEditor();
    this.chkOptOut = new MGACheckBox();
    this.dsInsured = new dsInsured();
    this.lblMobile = new Label();
    this.txtAddedBy = new MGATextBox();
    this.Label18 = new Label();
    this.lnkShowMap = new LinkLabel();
    this.ZipCodeResolver1 = new AddressResolver_MULTI();
    this.Label15 = new Label();
    this.Label7 = new Label();
    this.txtEmail = new MGATextBox();
    this.cboDeliveryMethod = new MGASimpleComboBox();
    this.Label9 = new Label();
    this.Label14 = new Label();
    this.txtDateAdded = new MGATextBox();
    this.Label4 = new Label();
    this.cbOfficeType = new MGASimpleComboBox();
    this.txtWebSite = new MGATextBox();
    this.Label3 = new Label();
    this.lblPhone = new Label();
    this.txtLocation = new MGATextBox();
    this.Label8 = new Label();
    this.btnDelete = new MGAButton();
    this.btnPrev = new MGAButton();
    this.btnNext = new MGAButton();
    this.btnLast = new MGAButton();
    this.btnFirst = new MGAButton();
    this.lblRecords = new UltraLabel();
    this.btnNewInsuredLocation = new MGAButton();
    this.UltraTabPageControl2 = new UltraTabPageControl();
    this.btnNewContact = new MGAButton();
    this.btnContacts = new MGAButton();
    this.lstContacts = new MGAListBox();
    this.mnuContacts = new ContextMenu();
    this.mnuActive = new MenuItem();
    this.mnuInactive = new MenuItem();
    this.mnuBothContacts = new MenuItem();
    this.UltraTabPageControl3 = new UltraTabPageControl();
    this.dgInvoices = new UltraGrid();
    this.tabOFAC = new UltraTabPageControl();
    this.lblOfacClearedDate = new Label();
    this.dtOFACClearedDate = new MGADateTimePicker();
    this.btnClearOFAC = new MGAButton();
    this.chkOFACCleared = new MGACheckBox();
    this.lblOFACReturnCode = new Label();
    this.lblOFACDate = new Label();
    this.ugOFAC = new UltraGrid();
    this.UltraTabPageControl4 = new UltraTabPageControl();
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
    this.cboCompanyLines = new MGASimpleComboBox();
    this.Label22 = new Label();
    this.chartStats = new Infragistics.Win.UltraWinChart.UltraChart();
    this.lblTotalPremium = new UltraLabel();
    this.Label21 = new Label();
    this.lblRenewalRetention = new UltraLabel();
    this.Label23 = new Label();
    this.lblDeclineRatio = new UltraLabel();
    this.Label24 = new Label();
    this.lblBindRatio = new UltraLabel();
    this.Label25 = new Label();
    this.lblQuoteRatio = new UltraLabel();
    this.Label26 = new Label();
    this.tabCallReport = new UltraTabPageControl();
    this.btnReport = new MGAButton();
    this.ugDetails = new UltraGrid();
    this.dvCallReports = new DataView();
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
    this.lblFEIN = new Label();
    this.lblCity = new Label();
    this.ToolTip = new ToolTip(this.components);
    this.daInsureds = new SqlDataAdapter();
    this.SqlDeleteCommand1 = new SqlCommand();
    this.cnSQL = new SqlConnection();
    this.SqlInsertCommand2 = new SqlCommand();
    this.SqlSelectCommand1 = new SqlCommand();
    this.SqlUpdateCommand2 = new SqlCommand();
    this.daContacts = new SqlDataAdapter();
    this.SqlSelectCommand4 = new SqlCommand();
    this.daLocations = new SqlDataAdapter();
    this.SqlDeleteCommand2 = new SqlCommand();
    this.SqlInsertCommand1 = new SqlCommand();
    this.SqlSelectCommand3 = new SqlCommand();
    this.SqlUpdateCommand1 = new SqlCommand();
    this.gbInsuredInfo = new UltraGroupBox();
    this.lblGender = new Label();
    this.cmbGender = new MGASimpleComboBox();
    this.lblDNBNumber = new Label();
    this.txtlblDNBNumber = new MGATextBox();
    this.lblTaxID = new Label();
    this.MgaTextBox1 = new MGATextBox();
    this.txtRiskID = new MGATextBox();
    this.lblRiskId = new Label();
    this.lnkUseInsured = new LinkLabel();
    this.Label17 = new Label();
    this.txtPolicyName = new MGATextBox();
    this.cboSalutations = new MGASimpleComboBox();
    this.Label13 = new Label();
    this.Label12 = new Label();
    this.txtLast = new MGATextBox();
    this.txtMiddle = new MGATextBox();
    this.txtFirst = new MGATextBox();
    this.Label11 = new Label();
    this.Label10 = new Label();
    this.txtBusiness = new MGATextBox();
    this.cboInsuredType = new MGASimpleComboBox();
    this.Label2 = new Label();
    this.txtFEIN = new MGAMaskedEdit();
    this.txtSSN = new MGAMaskedEdit();
    this.Label6 = new Label();
    this.Label16 = new Label();
    this.Label1 = new Label();
    this.txtInsuredCode = new MGATextBox();
    this.Label5 = new Label();
    this.txtDBA = new MGATextBox();
    this.ErrProvider = new ErrorProvider(this.components);
    this.gbInsuredInfo2 = new UltraGroupBox();
    this.lblStatusChangeReason = new Label();
    this.txtStatusChangeComments = new MGATextBox();
    this.txtCarrierId = new MGATextBox();
    this.lblCarrierId = new Label();
    this.dtDOB = new MGADateTimePicker();
    this.Label19 = new Label();
    this.cboInsStatus = new MGASimpleComboBox();
    this.UltraToolbarsManager1 = new UltraToolbarsManager(this.components);
    this._frmInsureds_Toolbars_Dock_Area_Left = new UltraToolbarsDockArea();
    this._frmInsureds_Toolbars_Dock_Area_Right = new UltraToolbarsDockArea();
    this._frmInsureds_Toolbars_Dock_Area_Top = new UltraToolbarsDockArea();
    this._frmInsureds_Toolbars_Dock_Area_Bottom = new UltraToolbarsDockArea();
    this.lnkAddSubmissionGroup = new LinkLabel();
    this.dbSave = new MGASystems.Tools.DBSaveUI.DBSaveUI();
    this.tabControl = new UltraTabControl();
    this.UltraTabSharedControlsPage1 = new UltraTabSharedControlsPage();
    this.daLookups = new SqlDataAdapter();
    this.SqlSelectCommand2 = new SqlCommand();
    this.Label20 = new Label();
    ((Control) this.UltraTabPageControl1).SuspendLayout();
    ((ISupportInitialize) this.txtInsuredScoreStatus).BeginInit();
    ((ISupportInitialize) this.chkOptOut).BeginInit();
    this.dsInsured.BeginInit();
    ((ISupportInitialize) this.txtAddedBy).BeginInit();
    ((ISupportInitialize) this.txtEmail).BeginInit();
    ((ISupportInitialize) this.cboDeliveryMethod).BeginInit();
    ((ISupportInitialize) this.txtDateAdded).BeginInit();
    ((ISupportInitialize) this.cbOfficeType).BeginInit();
    ((ISupportInitialize) this.txtWebSite).BeginInit();
    ((ISupportInitialize) this.txtLocation).BeginInit();
    ((ISupportInitialize) this.btnDelete).BeginInit();
    ((ISupportInitialize) this.btnPrev).BeginInit();
    ((ISupportInitialize) this.btnNext).BeginInit();
    ((ISupportInitialize) this.btnLast).BeginInit();
    ((ISupportInitialize) this.btnFirst).BeginInit();
    ((ISupportInitialize) this.btnNewInsuredLocation).BeginInit();
    ((Control) this.UltraTabPageControl2).SuspendLayout();
    ((ISupportInitialize) this.btnNewContact).BeginInit();
    ((ISupportInitialize) this.btnContacts).BeginInit();
    ((ISupportInitialize) this.lstContacts).BeginInit();
    ((Control) this.UltraTabPageControl3).SuspendLayout();
    ((ISupportInitialize) this.dgInvoices).BeginInit();
    ((Control) this.tabOFAC).SuspendLayout();
    ((ISupportInitialize) this.dtOFACClearedDate).BeginInit();
    ((ISupportInitialize) this.btnClearOFAC).BeginInit();
    ((ISupportInitialize) this.chkOFACCleared).BeginInit();
    ((ISupportInitialize) this.ugOFAC).BeginInit();
    ((Control) this.UltraTabPageControl4).SuspendLayout();
    ((ISupportInitialize) this.dtEndDate).BeginInit();
    ((ISupportInitialize) this.dtStartDate).BeginInit();
    ((ISupportInitialize) this.cboCompanyLines).BeginInit();
    ((ISupportInitialize) this.chartStats).BeginInit();
    ((Control) this.tabCallReport).SuspendLayout();
    ((ISupportInitialize) this.btnReport).BeginInit();
    ((ISupportInitialize) this.ugDetails).BeginInit();
    this.dvCallReports.BeginInit();
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
    ((ISupportInitialize) this.gbInsuredInfo).BeginInit();
    ((Control) this.gbInsuredInfo).SuspendLayout();
    ((ISupportInitialize) this.cmbGender).BeginInit();
    ((ISupportInitialize) this.txtlblDNBNumber).BeginInit();
    ((ISupportInitialize) this.MgaTextBox1).BeginInit();
    ((ISupportInitialize) this.txtRiskID).BeginInit();
    ((ISupportInitialize) this.txtPolicyName).BeginInit();
    ((ISupportInitialize) this.cboSalutations).BeginInit();
    ((ISupportInitialize) this.txtLast).BeginInit();
    ((ISupportInitialize) this.txtMiddle).BeginInit();
    ((ISupportInitialize) this.txtFirst).BeginInit();
    ((ISupportInitialize) this.txtBusiness).BeginInit();
    ((ISupportInitialize) this.cboInsuredType).BeginInit();
    ((ISupportInitialize) this.txtFEIN).BeginInit();
    ((ISupportInitialize) this.txtSSN).BeginInit();
    ((ISupportInitialize) this.txtInsuredCode).BeginInit();
    ((ISupportInitialize) this.txtDBA).BeginInit();
    ((ISupportInitialize) this.ErrProvider).BeginInit();
    ((ISupportInitialize) this.gbInsuredInfo2).BeginInit();
    ((Control) this.gbInsuredInfo2).SuspendLayout();
    ((ISupportInitialize) this.txtStatusChangeComments).BeginInit();
    ((ISupportInitialize) this.txtCarrierId).BeginInit();
    ((ISupportInitialize) this.dtDOB).BeginInit();
    ((ISupportInitialize) this.cboInsStatus).BeginInit();
    ((ISupportInitialize) this.UltraToolbarsManager1).BeginInit();
    ((ISupportInitialize) this.tabControl).BeginInit();
    ((Control) this.tabControl).SuspendLayout();
    ((Control) this.UltraTabSharedControlsPage1).SuspendLayout();
    this.SuspendLayout();
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.txtInsuredScoreStatus);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.lblInsuredScore);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.lnkInsuranceScoreNotice);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.lnkOrderInsuranceScoreReport);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.MgaInternationalMobile);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.MgaInternationaFax);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.MgaInternationalPhone);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.chkOptOut);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.lblMobile);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.txtAddedBy);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label18);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.lnkShowMap);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.ZipCodeResolver1);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label15);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label7);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.txtEmail);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.cboDeliveryMethod);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label9);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label14);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.txtDateAdded);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label4);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.cbOfficeType);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.txtWebSite);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label3);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.lblPhone);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.txtLocation);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label8);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.btnDelete);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.btnPrev);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.btnNext);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.btnLast);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.btnFirst);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.lblRecords);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.btnNewInsuredLocation);
    ((Control) this.UltraTabPageControl1).Location = new Point(1, 26);
    ((Control) this.UltraTabPageControl1).Name = "UltraTabPageControl1";
    ((Control) this.UltraTabPageControl1).Size = new Size(810, 357);
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance1.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtInsuredScoreStatus).Appearance = (AppearanceBase) appearance1;
    ((TextEditorControlBase) this.txtInsuredScoreStatus).BackColor = Color.White;
    ((Control) this.txtInsuredScoreStatus).Location = new Point(621, 92);
    this.txtInsuredScoreStatus.MGAStyle = MGAStyles.Blue;
    this.txtInsuredScoreStatus.Multiline = true;
    ((Control) this.txtInsuredScoreStatus).Name = "txtInsuredScoreStatus";
    ((Control) this.txtInsuredScoreStatus).Size = new Size(143, 58);
    ((Control) this.txtInsuredScoreStatus).TabIndex = 185;
    ((UltraControlBase) this.txtInsuredScoreStatus).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtInsuredScoreStatus).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.txtInsuredScoreStatus).Visible = false;
    this.lblInsuredScore.AutoSize = true;
    this.lblInsuredScore.BackColor = Color.Transparent;
    this.lblInsuredScore.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblInsuredScore.ForeColor = Color.Black;
    this.lblInsuredScore.Location = new Point(618, 71);
    this.lblInsuredScore.Name = "lblInsuredScore";
    this.lblInsuredScore.Size = new Size(89, 13);
    this.lblInsuredScore.TabIndex = 184;
    this.lblInsuredScore.Text = "Insured Score:";
    this.lblInsuredScore.TextAlign = ContentAlignment.MiddleRight;
    this.lblInsuredScore.Visible = false;
    this.lnkInsuranceScoreNotice.AutoSize = true;
    this.lnkInsuranceScoreNotice.BackColor = Color.Transparent;
    this.lnkInsuranceScoreNotice.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lnkInsuranceScoreNotice.Location = new Point(618, 43);
    this.lnkInsuranceScoreNotice.Name = "lnkInsuranceScoreNotice";
    this.lnkInsuranceScoreNotice.Size = new Size(146, 13);
    this.lnkInsuranceScoreNotice.TabIndex = 183;
    this.lnkInsuranceScoreNotice.TabStop = true;
    this.lnkInsuranceScoreNotice.Tag = (object) "keepEnabled";
    this.lnkInsuranceScoreNotice.Text = "Adverse Notice Required";
    this.lnkInsuranceScoreNotice.Visible = false;
    this.lnkOrderInsuranceScoreReport.AutoSize = true;
    this.lnkOrderInsuranceScoreReport.BackColor = Color.Transparent;
    this.lnkOrderInsuranceScoreReport.Location = new Point(618, 19);
    this.lnkOrderInsuranceScoreReport.Name = "lnkOrderInsuranceScoreReport";
    this.lnkOrderInsuranceScoreReport.Size = new Size(152, 13);
    this.lnkOrderInsuranceScoreReport.TabIndex = 182;
    this.lnkOrderInsuranceScoreReport.TabStop = true;
    this.lnkOrderInsuranceScoreReport.Tag = (object) " ";
    this.lnkOrderInsuranceScoreReport.Text = "Order Insurance Score Report";
    this.lnkOrderInsuranceScoreReport.Visible = false;
    this.MgaInternationalMobile.CountryCode = "";
    this.MgaInternationalMobile.Location = new Point(381, 37);
    this.MgaInternationalMobile.MGAStyle = MGAStyles.Gray;
    this.MgaInternationalMobile.Name = "MgaInternationalMobile";
    this.MgaInternationalMobile.Size = new Size(184, 21);
    this.MgaInternationalMobile.TabIndex = 171;
    this.MgaInternationalMobile.Value = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("MgaInternationalMobile.Value"));
    this.MgaInternationaFax.CountryCode = "";
    this.MgaInternationaFax.Location = new Point(381, 11);
    this.MgaInternationaFax.MGAStyle = MGAStyles.Gray;
    this.MgaInternationaFax.Name = "MgaInternationaFax";
    this.MgaInternationaFax.Size = new Size(184, 21);
    this.MgaInternationaFax.TabIndex = 170;
    this.MgaInternationaFax.Value = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("MgaInternationaFax.Value"));
    this.MgaInternationalPhone.CountryCode = "";
    this.MgaInternationalPhone.Location = new Point(111, 205);
    this.MgaInternationalPhone.MGAStyle = MGAStyles.Gray;
    this.MgaInternationalPhone.Name = "MgaInternationalPhone";
    this.MgaInternationalPhone.Size = new Size(184, 21);
    this.MgaInternationalPhone.TabIndex = 169;
    this.MgaInternationalPhone.Value = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("MgaInternationalPhone.Value"));
    appearance2.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance2.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkOptOut).Appearance = (AppearanceBase) appearance2;
    ((UltraToggleEditorBase) this.chkOptOut).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkOptOut).BackColorInternal = Color.Transparent;
    ((Control) this.chkOptOut).DataBindings.Add(new Binding("Checked", (object) this.dsInsured, "tblInsuredLocations.OptOut", true));
    ((UltraToggleEditorBase) this.chkOptOut).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkOptOut).Location = new Point(381, 213);
    this.chkOptOut.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkOptOut).Name = "chkOptOut";
    ((Control) this.chkOptOut).Size = new Size(66, 17);
    ((Control) this.chkOptOut).TabIndex = 168;
    ((UltraToggleEditorBase) this.chkOptOut).Text = "Opt Out";
    ((UltraControlBase) this.chkOptOut).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkOptOut).UseOsThemes = (DefaultableBoolean) 2;
    this.dsInsured.DataSetName = "dsInsured";
    this.dsInsured.Locale = new CultureInfo("en-US");
    this.dsInsured.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.lblMobile.AutoSize = true;
    this.lblMobile.BackColor = Color.Transparent;
    this.lblMobile.Location = new Point(317, 43);
    this.lblMobile.Name = "lblMobile";
    this.lblMobile.Size = new Size(52, 13);
    this.lblMobile.TabIndex = 167;
    this.lblMobile.Text = "Mobile #:";
    this.lblMobile.TextAlign = ContentAlignment.MiddleRight;
    appearance3.BackColor = Color.White;
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance3.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtAddedBy).Appearance = (AppearanceBase) appearance3;
    ((TextEditorControlBase) this.txtAddedBy).BackColor = Color.White;
    ((Control) this.txtAddedBy).DataBindings.Add(new Binding("Text", (object) this.dsInsured, "tblInsuredLocations.Name_LastFirst", true));
    ((Control) this.txtAddedBy).Location = new Point(381, 186);
    this.txtAddedBy.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtAddedBy).Name = "txtAddedBy";
    ((EditorButtonControlBase) this.txtAddedBy).ReadOnly = true;
    ((Control) this.txtAddedBy).Size = new Size(174, 20);
    ((Control) this.txtAddedBy).TabIndex = 10;
    ((Control) this.txtAddedBy).TabStop = false;
    ((UltraControlBase) this.txtAddedBy).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtAddedBy).UseOsThemes = (DefaultableBoolean) 2;
    this.Label18.AutoSize = true;
    this.Label18.BackColor = Color.Transparent;
    this.Label18.Location = new Point(312, 190);
    this.Label18.Name = "Label18";
    this.Label18.Size = new Size(57, 13);
    this.Label18.TabIndex = 164;
    this.Label18.Text = "Added By:";
    this.Label18.TextAlign = ContentAlignment.MiddleRight;
    this.lnkShowMap.AutoSize = true;
    this.lnkShowMap.BackColor = Color.Transparent;
    this.lnkShowMap.Location = new Point(110, 242);
    this.lnkShowMap.Name = "lnkShowMap";
    this.lnkShowMap.Size = new Size(70, 13);
    this.lnkShowMap.TabIndex = 14;
    this.lnkShowMap.TabStop = true;
    this.lnkShowMap.Tag = (object) "keepEnabled";
    this.lnkShowMap.Text = "Map Location";
    this.lnkShowMap.TextAlign = ContentAlignment.MiddleRight;
    this.ZipCodeResolver1.Address1 = "";
    this.ZipCodeResolver1.Address2 = "";
    ((Control) this.ZipCodeResolver1).BackColor = Color.Transparent;
    this.ZipCodeResolver1.City = "";
    this.ZipCodeResolver1.County = "";
    ((Control) this.ZipCodeResolver1).DataBindings.Add(new Binding("Address1", (object) this.dsInsured, "tblInsuredLocations.Address1", true, DataSourceUpdateMode.OnPropertyChanged));
    ((Control) this.ZipCodeResolver1).DataBindings.Add(new Binding("Address2", (object) this.dsInsured, "tblInsuredLocations.Address2", true, DataSourceUpdateMode.OnPropertyChanged));
    ((Control) this.ZipCodeResolver1).Font = new Font("Tahoma", 8f);
    this.ZipCodeResolver1.ISOCountryCode = "";
    this.ZipCodeResolver1.ISOCountryCodeMember = "";
    this.ZipCodeResolver1.ISOCountryList = (object) null;
    this.ZipCodeResolver1.ISOCountryNameMember = "";
    ((Control) this.ZipCodeResolver1).Location = new Point(21, 35);
    this.ZipCodeResolver1.MGAStyle = MGAStyles.Blue;
    ((Control) this.ZipCodeResolver1).Name = "ZipCodeResolver1";
    this.ZipCodeResolver1.Password = (string) null;
    ((Control) this.ZipCodeResolver1).Size = new Size(266, 171);
    this.ZipCodeResolver1.State = "";
    ((Control) this.ZipCodeResolver1).TabIndex = 1;
    this.ZipCodeResolver1.UserID = (string) null;
    this.ZipCodeResolver1.WebserviceUrl = (string) null;
    this.ZipCodeResolver1.ZipCode = "";
    this.ZipCodeResolver1.ZipCodeExtension = "";
    this.Label15.AutoSize = true;
    this.Label15.BackColor = Color.Transparent;
    this.Label15.Location = new Point(332, 92);
    this.Label15.Name = "Label15";
    this.Label15.Size = new Size(35, 13);
    this.Label15.TabIndex = 163;
    this.Label15.Text = "Email:";
    this.Label15.TextAlign = ContentAlignment.MiddleRight;
    this.Label7.AutoSize = true;
    this.Label7.BackColor = Color.Transparent;
    this.Label7.Location = new Point(319, 116);
    this.Label7.Name = "Label7";
    this.Label7.Size = new Size(50, 13);
    this.Label7.TabIndex = 136;
    this.Label7.Text = "Delivery:";
    this.Label7.TextAlign = ContentAlignment.MiddleRight;
    appearance4.BackColor = Color.White;
    appearance4.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance4.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtEmail).Appearance = (AppearanceBase) appearance4;
    ((TextEditorControlBase) this.txtEmail).BackColor = Color.White;
    ((Control) this.txtEmail).DataBindings.Add(new Binding("Text", (object) this.dsInsured, "tblInsuredLocations.Email", true));
    ((Control) this.txtEmail).Location = new Point(381, 88);
    this.txtEmail.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtEmail).Name = "txtEmail";
    ((Control) this.txtEmail).Size = new Size(126, 20);
    ((Control) this.txtEmail).TabIndex = 6;
    ((UltraControlBase) this.txtEmail).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtEmail).UseOsThemes = (DefaultableBoolean) 2;
    this.cboDeliveryMethod.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboDeliveryMethod).DataBindings.Add(new Binding("Value", (object) this.dsInsured, "tblInsuredLocations.DeliveryMethodID", true));
    ((UltraGridBase) this.cboDeliveryMethod).DataSource = (object) this.dsInsured.lstDeliveryMethod;
    ((UltraDropDownBase) this.cboDeliveryMethod).DisplayMember = "Description";
    this.cboDeliveryMethod.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboDeliveryMethod).Location = new Point(381, 112 /*0x70*/);
    this.cboDeliveryMethod.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboDeliveryMethod).Name = "cboDeliveryMethod";
    ((Control) this.cboDeliveryMethod).Size = new Size(128 /*0x80*/, 21);
    ((Control) this.cboDeliveryMethod).TabIndex = 7;
    ((UltraControlBase) this.cboDeliveryMethod).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboDeliveryMethod).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboDeliveryMethod).ValueMember = "DeliveryMethodID";
    this.Label9.AutoSize = true;
    this.Label9.BackColor = Color.Transparent;
    this.Label9.Location = new Point(327, 166);
    this.Label9.Name = "Label9";
    this.Label9.Size = new Size(42, 13);
    this.Label9.TabIndex = 141;
    this.Label9.Text = "Added:";
    this.Label9.TextAlign = ContentAlignment.MiddleRight;
    this.Label14.AutoSize = true;
    this.Label14.BackColor = Color.Transparent;
    this.Label14.Location = new Point(302, 137);
    this.Label14.Name = "Label14";
    this.Label14.Size = new Size(67, 13);
    this.Label14.TabIndex = 158;
    this.Label14.Text = "Office Type:";
    this.Label14.TextAlign = ContentAlignment.MiddleRight;
    appearance5.BackColor = Color.White;
    appearance5.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance5.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtDateAdded).Appearance = (AppearanceBase) appearance5;
    ((TextEditorControlBase) this.txtDateAdded).BackColor = Color.White;
    ((Control) this.txtDateAdded).DataBindings.Add(new Binding("Text", (object) this.dsInsured, "tblInsuredLocations.DateAdded", true));
    ((Control) this.txtDateAdded).Location = new Point(381, 162);
    this.txtDateAdded.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtDateAdded).Name = "txtDateAdded";
    ((EditorButtonControlBase) this.txtDateAdded).ReadOnly = true;
    ((Control) this.txtDateAdded).Size = new Size(174, 20);
    ((Control) this.txtDateAdded).TabIndex = 9;
    ((Control) this.txtDateAdded).TabStop = false;
    ((UltraControlBase) this.txtDateAdded).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtDateAdded).UseOsThemes = (DefaultableBoolean) 2;
    this.Label4.AutoSize = true;
    this.Label4.BackColor = Color.Transparent;
    this.Label4.Location = new Point(21, 18);
    this.Label4.Name = "Label4";
    this.Label4.Size = new Size(64 /*0x40*/, 13);
    this.Label4.TabIndex = 14;
    this.Label4.Text = "Description:";
    this.Label4.TextAlign = ContentAlignment.MiddleRight;
    this.cbOfficeType.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cbOfficeType).DataBindings.Add(new Binding("Value", (object) this.dsInsured, "tblInsuredLocations.LocationTypeID", true));
    ((UltraGridBase) this.cbOfficeType).DataSource = (object) this.dsInsured.lstLocationType;
    ((UltraDropDownBase) this.cbOfficeType).DisplayMember = "LocationType";
    this.cbOfficeType.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cbOfficeType).Location = new Point(381, 137);
    this.cbOfficeType.MGAStyle = MGAStyles.Blue;
    ((Control) this.cbOfficeType).Name = "cbOfficeType";
    ((Control) this.cbOfficeType).Size = new Size(128 /*0x80*/, 21);
    ((Control) this.cbOfficeType).TabIndex = 8;
    ((UltraControlBase) this.cbOfficeType).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cbOfficeType).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cbOfficeType).ValueMember = "LocationTypeID";
    appearance6.BackColor = Color.White;
    appearance6.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance6.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtWebSite).Appearance = (AppearanceBase) appearance6;
    ((TextEditorControlBase) this.txtWebSite).BackColor = Color.White;
    ((Control) this.txtWebSite).DataBindings.Add(new Binding("Text", (object) this.dsInsured, "tblInsuredLocations.WebSite", true));
    ((Control) this.txtWebSite).Location = new Point(381, 64 /*0x40*/);
    this.txtWebSite.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtWebSite).Name = "txtWebSite";
    ((Control) this.txtWebSite).Size = new Size(126, 20);
    ((Control) this.txtWebSite).TabIndex = 5;
    ((UltraControlBase) this.txtWebSite).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtWebSite).UseOsThemes = (DefaultableBoolean) 2;
    this.Label3.AutoSize = true;
    this.Label3.BackColor = Color.Transparent;
    this.Label3.Location = new Point(341, 18);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(29, 13);
    this.Label3.TabIndex = 98;
    this.Label3.Text = "Fax:";
    this.Label3.TextAlign = ContentAlignment.MiddleRight;
    this.lblPhone.AutoSize = true;
    this.lblPhone.BackColor = Color.Transparent;
    this.lblPhone.Location = new Point(42, 213);
    this.lblPhone.Name = "lblPhone";
    this.lblPhone.Size = new Size(41, 13);
    this.lblPhone.TabIndex = 92;
    this.lblPhone.Text = "Phone:";
    this.lblPhone.TextAlign = ContentAlignment.MiddleRight;
    appearance7.BackColor = Color.White;
    appearance7.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance7.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtLocation).Appearance = (AppearanceBase) appearance7;
    ((TextEditorControlBase) this.txtLocation).BackColor = Color.White;
    ((Control) this.txtLocation).DataBindings.Add(new Binding("Text", (object) this.dsInsured, "tblInsuredLocations.Name", true));
    ((Control) this.txtLocation).Location = new Point(111, 11);
    this.txtLocation.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtLocation).Name = "txtLocation";
    ((Control) this.txtLocation).Size = new Size(173, 20);
    ((Control) this.txtLocation).TabIndex = 0;
    ((UltraControlBase) this.txtLocation).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtLocation).UseOsThemes = (DefaultableBoolean) 2;
    this.Label8.AutoSize = true;
    this.Label8.BackColor = Color.Transparent;
    this.Label8.Location = new Point(314, 68);
    this.Label8.Name = "Label8";
    this.Label8.Size = new Size(54, 13);
    this.Label8.TabIndex = 111;
    this.Label8.Text = "Web Site:";
    this.Label8.TextAlign = ContentAlignment.MiddleRight;
    ((Control) this.btnDelete).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    appearance8.BackColor = Color.Gainsboro;
    appearance8.BackColor2 = Color.White;
    appearance8.BackGradientStyle = (GradientStyle) 2;
    appearance8.BorderColor = Color.Gray;
    appearance8.ImageHAlign = (HAlign) 2;
    ((ControlBase) this.btnDelete).Appearance = (AppearanceBase) appearance8;
    ((ControlBase) this.btnDelete).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnDelete).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnDelete).Location = new Point(560, 310);
    ((Control) this.btnDelete).Name = "btnDelete";
    ((Control) this.btnDelete).Size = new Size(42, 42);
    ((Control) this.btnDelete).TabIndex = 12;
    this.ToolTip.SetToolTip((Control) this.btnDelete, "Delete Information");
    this.btnDelete.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.btnPrev).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    appearance9.BackColor = Color.Gainsboro;
    appearance9.BackColor2 = Color.White;
    appearance9.BackGradientStyle = (GradientStyle) 2;
    appearance9.BorderColor = Color.Gray;
    appearance9.ImageHAlign = (HAlign) 2;
    ((ControlBase) this.btnPrev).Appearance = (AppearanceBase) appearance9;
    ((ControlBase) this.btnPrev).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnPrev).Location = new Point(294, 317);
    ((Control) this.btnPrev).Name = "btnPrev";
    ((Control) this.btnPrev).Size = new Size(28, 28);
    ((Control) this.btnPrev).TabIndex = 9;
    ((Control) this.btnPrev).Tag = (object) "keepEnabled";
    this.ToolTip.SetToolTip((Control) this.btnPrev, "Previous Location");
    this.btnPrev.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.btnNext).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    appearance10.BackColor = Color.Gainsboro;
    appearance10.BackColor2 = Color.White;
    appearance10.BackGradientStyle = (GradientStyle) 2;
    appearance10.BorderColor = Color.Gray;
    appearance10.ImageHAlign = (HAlign) 2;
    ((ControlBase) this.btnNext).Appearance = (AppearanceBase) appearance10;
    ((ControlBase) this.btnNext).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnNext).Location = new Point(427, 317);
    ((Control) this.btnNext).Name = "btnNext";
    ((Control) this.btnNext).Size = new Size(28, 28);
    ((Control) this.btnNext).TabIndex = 10;
    ((Control) this.btnNext).Tag = (object) "keepEnabled";
    this.ToolTip.SetToolTip((Control) this.btnNext, "Next Location");
    this.btnNext.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.btnLast).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    appearance11.BackColor = Color.Gainsboro;
    appearance11.BackColor2 = Color.White;
    appearance11.BackGradientStyle = (GradientStyle) 2;
    appearance11.BorderColor = Color.Gray;
    appearance11.ImageHAlign = (HAlign) 2;
    ((ControlBase) this.btnLast).Appearance = (AppearanceBase) appearance11;
    ((ControlBase) this.btnLast).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnLast).Location = new Point(462, 317);
    ((Control) this.btnLast).Name = "btnLast";
    ((Control) this.btnLast).Size = new Size(28, 28);
    ((Control) this.btnLast).TabIndex = 11;
    ((Control) this.btnLast).Tag = (object) "keepEnabled";
    this.ToolTip.SetToolTip((Control) this.btnLast, "Last Location");
    this.btnLast.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.btnFirst).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    appearance12.BackColor = Color.Gainsboro;
    appearance12.BackColor2 = Color.White;
    appearance12.BackGradientStyle = (GradientStyle) 2;
    appearance12.BorderColor = Color.Gray;
    appearance12.ImageHAlign = (HAlign) 2;
    ((ControlBase) this.btnFirst).Appearance = (AppearanceBase) appearance12;
    ((ControlBase) this.btnFirst).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnFirst).Location = new Point(259, 317);
    ((Control) this.btnFirst).Name = "btnFirst";
    ((Control) this.btnFirst).Size = new Size(28, 28);
    ((Control) this.btnFirst).TabIndex = 8;
    ((Control) this.btnFirst).Tag = (object) "keepEnabled";
    this.ToolTip.SetToolTip((Control) this.btnFirst, "First Location");
    this.btnFirst.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.lblRecords).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    appearance13.BackColor = Color.Transparent;
    appearance13.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance13).TextHAlignAsString = "Center";
    ((AppearanceBase) appearance13).TextVAlignAsString = "Middle";
    ((ControlBase) this.lblRecords).Appearance = (AppearanceBase) appearance13;
    ((ControlBase) this.lblRecords).BackColorInternal = SystemColors.Control;
    this.lblRecords.BorderStyleOuter = (UIElementBorderStyle) 4;
    ((Control) this.lblRecords).Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.lblRecords).Location = new Point(329, 324);
    ((Control) this.lblRecords).Name = "lblRecords";
    ((Control) this.lblRecords).Size = new Size(88, 14);
    ((Control) this.lblRecords).TabIndex = 132;
    ((Control) this.lblRecords).Tag = (object) "keepEnabled";
    ((UltraControlBase) this.lblRecords).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.btnNewInsuredLocation).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    appearance14.BackColor = Color.Gainsboro;
    appearance14.BackColor2 = Color.White;
    appearance14.BackGradientStyle = (GradientStyle) 2;
    appearance14.BorderColor = Color.Gray;
    appearance14.ImageHAlign = (HAlign) 2;
    ((ControlBase) this.btnNewInsuredLocation).Appearance = (AppearanceBase) appearance14;
    ((ControlBase) this.btnNewInsuredLocation).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnNewInsuredLocation).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnNewInsuredLocation).Location = new Point(511 /*0x01FF*/, 310);
    ((Control) this.btnNewInsuredLocation).Name = "btnNewInsuredLocation";
    ((Control) this.btnNewInsuredLocation).Size = new Size(42, 42);
    ((Control) this.btnNewInsuredLocation).TabIndex = 11;
    this.ToolTip.SetToolTip((Control) this.btnNewInsuredLocation, "New Insured Location");
    this.btnNewInsuredLocation.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.btnNewContact);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.btnContacts);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.lstContacts);
    ((Control) this.UltraTabPageControl2).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabPageControl2).Name = "UltraTabPageControl2";
    ((Control) this.UltraTabPageControl2).Size = new Size(810, 357);
    ((Control) this.btnNewContact).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    appearance15.ImageHAlign = (HAlign) 2;
    appearance15.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnNewContact).Appearance = (AppearanceBase) appearance15;
    ((ControlBase) this.btnNewContact).BackColorInternal = Color.Transparent;
    ((Control) this.btnNewContact).Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((ControlBase) this.btnNewContact).ImageSize = new Size(24, 24);
    ((Control) this.btnNewContact).Location = new Point(345, 14);
    ((Control) this.btnNewContact).Name = "btnNewContact";
    ((Control) this.btnNewContact).Size = new Size(40, 40);
    ((Control) this.btnNewContact).TabIndex = 9;
    ((Control) this.btnNewContact).Tag = (object) "keepEnabled";
    this.ToolTip.SetToolTip((Control) this.btnNewContact, "Enter a new contact for this insured location");
    this.btnNewContact.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.btnContacts).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    appearance16.ImageHAlign = (HAlign) 2;
    appearance16.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnContacts).Appearance = (AppearanceBase) appearance16;
    ((ControlBase) this.btnContacts).BackColorInternal = Color.Transparent;
    ((ControlBase) this.btnContacts).ImageSize = new Size(24, 24);
    ((Control) this.btnContacts).Location = new Point(296, 14);
    ((Control) this.btnContacts).Name = "btnContacts";
    ((Control) this.btnContacts).Size = new Size(40, 40);
    ((Control) this.btnContacts).TabIndex = 8;
    ((Control) this.btnContacts).Tag = (object) "keepEnabled";
    this.ToolTip.SetToolTip((Control) this.btnContacts, "View this location contact");
    this.btnContacts.UseOSThemes = (DefaultableBoolean) 2;
    this.lstContacts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.lstContacts.ContextMenu = this.mnuContacts;
    this.lstContacts.DataSource = (object) this.dsInsured.tblInsuredContacts;
    this.lstContacts.DisplayMember = "Name";
    this.lstContacts.Location = new Point(7, 14);
    this.lstContacts.MGAStyle = MGAStyles.Blue;
    this.lstContacts.Name = "lstContacts";
    this.lstContacts.Size = new Size(282, 210);
    this.lstContacts.TabIndex = 7;
    this.lstContacts.ValueMember = "InsuredContactGuid";
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
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.dgInvoices);
    ((Control) this.UltraTabPageControl3).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabPageControl3).Name = "UltraTabPageControl3";
    ((Control) this.UltraTabPageControl3).Size = new Size(810, 357);
    ((UltraGridBase) this.dgInvoices).DataSource = (object) this.dsInsured.Invoices;
    appearance17.BackColor = Color.White;
    appearance17.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.dgInvoices).DisplayLayout.Appearance = (AppearanceBase) appearance17;
    ((UltraGridBase) this.dgInvoices).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn1.CellActivation = (Activation) 1;
    ((AppearanceBase) appearance18).TextHAlignAsString = "Right";
    ultraGridColumn1.CellAppearance = (AppearanceBase) appearance18;
    ultraGridColumn1.Format = "c";
    ((HeaderBase) ultraGridColumn1.Header).Caption = "Amount";
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 3;
    ultraGridColumn1.Width = 90;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn2.CellActivation = (Activation) 1;
    ultraGridColumn2.Format = "d";
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Due";
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 2;
    ultraGridColumn2.Width = 102;
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn3.CellActivation = (Activation) 1;
    ((HeaderBase) ultraGridColumn3.Header).Caption = "Invoice #";
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Header.VisiblePosition = 0;
    ultraGridColumn3.Width = 71;
    ultraGridColumn4.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn4.Header.VisiblePosition = 4;
    ultraGridColumn4.Hidden = true;
    ultraGridColumn5.AutoCompleteMode = (AutoCompleteMode) 2;
    appearance19.FontData.UnderlineAsString = "True";
    appearance19.ForeColor = Color.Blue;
    ((AppearanceBase) appearance19).TextHAlignAsString = "Center";
    ultraGridColumn5.CellAppearance = (AppearanceBase) appearance19;
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn5.Header.VisiblePosition = 6;
    ultraGridColumn5.Width = 112 /*0x70*/;
    ultraGridColumn6.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn6.CellActivation = (Activation) 1;
    ultraGridColumn6.Format = "d";
    ((HeaderBase) ultraGridColumn6.Header).Caption = "Invoice Date";
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn6.Header.VisiblePosition = 5;
    ultraGridColumn6.Width = 102;
    ultraGridColumn7.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn7.CellActivation = (Activation) 1;
    ((HeaderBase) ultraGridColumn7.Header).Caption = "Policy #";
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn7.Header.VisiblePosition = 1;
    ultraGridColumn7.Width = 115;
    ultraGridColumn8.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn8.Header.VisiblePosition = 7;
    ultraGridColumn8.Hidden = true;
    ultraGridBand1.Columns.AddRange(new object[8]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4,
      (object) ultraGridColumn5,
      (object) ultraGridColumn6,
      (object) ultraGridColumn7,
      (object) ultraGridColumn8
    });
    ((UltraGridBase) this.dgInvoices).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.dgInvoices).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance20.BackColor = Color.LightSteelBlue;
    appearance20.FontData.SizeInPoints = 10f;
    appearance20.ForeColor = Color.Black;
    ((UltraGridBase) this.dgInvoices).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance20;
    appearance21.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance21.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance21.ForeColor = Color.Black;
    ((UltraGridBase) this.dgInvoices).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance21;
    ((UltraGridBase) this.dgInvoices).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.dgInvoices).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    appearance22.BorderColor = Color.LightGray;
    ((UltraGridBase) this.dgInvoices).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance22;
    appearance23.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.dgInvoices).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance23;
    ((UltraGridBase) this.dgInvoices).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance24.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.dgInvoices).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance24;
    appearance25.BorderColor = Color.LightGray;
    ((UltraGridBase) this.dgInvoices).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance25;
    ((UltraGridBase) this.dgInvoices).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance26.BackColor = Color.Transparent;
    appearance26.ForeColor = Color.Black;
    ((UltraGridBase) this.dgInvoices).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance26;
    scrollBarLook1.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.dgInvoices).DisplayLayout.ScrollBarLook = scrollBarLook1;
    ((Control) this.dgInvoices).Location = new Point(7, 7);
    ((Control) this.dgInvoices).Name = "dgInvoices";
    ((Control) this.dgInvoices).Size = new Size(594, 265);
    ((Control) this.dgInvoices).TabIndex = 0;
    ((Control) this.dgInvoices).Tag = (object) "keepEnabled";
    ((UltraControlBase) this.dgInvoices).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dgInvoices).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.tabOFAC).Controls.Add((Control) this.lblOfacClearedDate);
    ((Control) this.tabOFAC).Controls.Add((Control) this.dtOFACClearedDate);
    ((Control) this.tabOFAC).Controls.Add((Control) this.btnClearOFAC);
    ((Control) this.tabOFAC).Controls.Add((Control) this.chkOFACCleared);
    ((Control) this.tabOFAC).Controls.Add((Control) this.lblOFACReturnCode);
    ((Control) this.tabOFAC).Controls.Add((Control) this.lblOFACDate);
    ((Control) this.tabOFAC).Controls.Add((Control) this.ugOFAC);
    ((Control) this.tabOFAC).Location = new Point(-10000, -10000);
    ((Control) this.tabOFAC).Name = "tabOFAC";
    ((Control) this.tabOFAC).Size = new Size(810, 357);
    this.lblOfacClearedDate.AutoSize = true;
    this.lblOfacClearedDate.BackColor = Color.Transparent;
    this.lblOfacClearedDate.Location = new Point(253, 215);
    this.lblOfacClearedDate.Name = "lblOfacClearedDate";
    this.lblOfacClearedDate.Size = new Size(79, 13);
    this.lblOfacClearedDate.TabIndex = 141;
    this.lblOfacClearedDate.Text = "OFAC Cleared:";
    appearance27.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dtOFACClearedDate.Appearance = (AppearanceBase) appearance27;
    appearance28.AlphaLevel = (short) 14;
    appearance28.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance28.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance28.BackColorAlpha = (Alpha) 2;
    appearance28.BackGradientAlignment = (GradientAlignment) 4;
    appearance28.BackGradientStyle = (GradientStyle) 5;
    appearance28.BorderAlpha = (Alpha) 1;
    appearance28.BorderColor = Color.FromArgb(78, 122, 171);
    appearance28.ForeColor = Color.FromArgb(49, 85, 153);
    appearance28.ForegroundAlpha = (Alpha) 2;
    this.dtOFACClearedDate.ButtonAppearance = (AppearanceBase) appearance28;
    ((Control) this.dtOFACClearedDate).DataBindings.Add(new Binding("Value", (object) this.dsInsured, "tblInsureds.OfacClearedDate", true));
    this.dtOFACClearedDate.DateTime = new DateTime(1753, 1, 1, 0, 0, 0, 0);
    ((Control) this.dtOFACClearedDate).Location = new Point(338, 211);
    this.dtOFACClearedDate.MGAStyle = MGAStyles.Blue;
    ((Control) this.dtOFACClearedDate).Name = "dtOFACClearedDate";
    ((Control) this.dtOFACClearedDate).Size = new Size(96 /*0x60*/, 20);
    ((Control) this.dtOFACClearedDate).TabIndex = 140;
    ((UltraControlBase) this.dtOFACClearedDate).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtOFACClearedDate).UseOsThemes = (DefaultableBoolean) 2;
    this.dtOFACClearedDate.Value = (object) null;
    ((Control) this.btnClearOFAC).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    appearance29.BackColor = Color.Gainsboro;
    appearance29.BackColor2 = Color.White;
    appearance29.BackGradientStyle = (GradientStyle) 2;
    appearance29.BorderColor = Color.Gray;
    appearance29.ImageHAlign = (HAlign) 2;
    ((ControlBase) this.btnClearOFAC).Appearance = (AppearanceBase) appearance29;
    ((ControlBase) this.btnClearOFAC).ImageTransparentColor = Color.Empty;
    ((Control) this.btnClearOFAC).Location = new Point(168, 236);
    ((Control) this.btnClearOFAC).Name = "btnClearOFAC";
    ((Control) this.btnClearOFAC).Size = new Size(28, 20);
    ((Control) this.btnClearOFAC).TabIndex = 137;
    ((Control) this.btnClearOFAC).Tag = (object) "keepEnabled";
    this.ToolTip.SetToolTip((Control) this.btnClearOFAC, "Clear OFAC");
    this.btnClearOFAC.UseOSThemes = (DefaultableBoolean) 2;
    appearance30.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance30.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkOFACCleared).Appearance = (AppearanceBase) appearance30;
    ((UltraToggleEditorBase) this.chkOFACCleared).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkOFACCleared).BackColorInternal = Color.Transparent;
    ((Control) this.chkOFACCleared).DataBindings.Add(new Binding("Checked", (object) this.dsInsured, "tblInsureds.OFACCleared", true));
    ((UltraToggleEditorBase) this.chkOFACCleared).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkOFACCleared).Location = new Point(168, 213);
    this.chkOFACCleared.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkOFACCleared).Name = "chkOFACCleared";
    ((Control) this.chkOFACCleared).Size = new Size(66, 17);
    ((Control) this.chkOFACCleared).TabIndex = 136;
    ((UltraToggleEditorBase) this.chkOFACCleared).Text = "Cleared";
    ((UltraControlBase) this.chkOFACCleared).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkOFACCleared).UseOsThemes = (DefaultableBoolean) 2;
    this.lblOFACReturnCode.AutoSize = true;
    this.lblOFACReturnCode.BackColor = Color.Transparent;
    this.lblOFACReturnCode.Location = new Point(7, 242);
    this.lblOFACReturnCode.Name = "lblOFACReturnCode";
    this.lblOFACReturnCode.Size = new Size(103, 13);
    this.lblOFACReturnCode.TabIndex = 135;
    this.lblOFACReturnCode.Text = "OFAC Return Code:";
    this.lblOFACDate.AutoSize = true;
    this.lblOFACDate.BackColor = Color.Transparent;
    this.lblOFACDate.Location = new Point(7, 213);
    this.lblOFACDate.Name = "lblOFACDate";
    this.lblOFACDate.Size = new Size(65, 13);
    this.lblOFACDate.TabIndex = 134;
    this.lblOFACDate.Text = "OFAC Date:";
    ((UltraGridBase) this.ugOFAC).DataSource = (object) this.dsInsured.Invoices;
    appearance31.BackColor = Color.White;
    appearance31.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ugOFAC).DisplayLayout.Appearance = (AppearanceBase) appearance31;
    ((UltraGridBase) this.ugOFAC).DisplayLayout.AutoFitStyle = (AutoFitStyle) 2;
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn9.Header.VisiblePosition = 0;
    ((HeaderBase) ultraGridColumn10.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn10.Header.VisiblePosition = 1;
    ((HeaderBase) ultraGridColumn11.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn11.Header.VisiblePosition = 2;
    ((HeaderBase) ultraGridColumn12.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn12.Header.VisiblePosition = 3;
    ((HeaderBase) ultraGridColumn13.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn13.Header.VisiblePosition = 4;
    ((HeaderBase) ultraGridColumn14.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn14.Header.VisiblePosition = 5;
    ((HeaderBase) ultraGridColumn15.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn15.Header.VisiblePosition = 6;
    ((HeaderBase) ultraGridColumn16.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn16.Header.VisiblePosition = 7;
    ultraGridBand2.Columns.AddRange(new object[8]
    {
      (object) ultraGridColumn9,
      (object) ultraGridColumn10,
      (object) ultraGridColumn11,
      (object) ultraGridColumn12,
      (object) ultraGridColumn13,
      (object) ultraGridColumn14,
      (object) ultraGridColumn15,
      (object) ultraGridColumn16
    });
    ((UltraGridBase) this.ugOFAC).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.ugOFAC).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance32.BackColor = Color.LightSteelBlue;
    appearance32.FontData.SizeInPoints = 10f;
    appearance32.ForeColor = Color.Black;
    ((UltraGridBase) this.ugOFAC).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance32;
    appearance33.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance33.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance33.ForeColor = Color.Black;
    ((UltraGridBase) this.ugOFAC).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance33;
    ((UltraGridBase) this.ugOFAC).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.ugOFAC).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    appearance34.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugOFAC).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance34;
    appearance35.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ugOFAC).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance35;
    ((UltraGridBase) this.ugOFAC).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance36.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ugOFAC).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance36;
    appearance37.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugOFAC).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance37;
    appearance38.BackColor = Color.Transparent;
    appearance38.ForeColor = Color.Black;
    ((UltraGridBase) this.ugOFAC).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance38;
    scrollBarLook2.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.ugOFAC).DisplayLayout.ScrollBarLook = scrollBarLook2;
    ((UltraGridBase) this.ugOFAC).DisplayLayout.Scrollbars = (Scrollbars) 3;
    ((UltraGridBase) this.ugOFAC).DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    ((Control) this.ugOFAC).Location = new Point(10, 11);
    ((Control) this.ugOFAC).Name = "ugOFAC";
    ((Control) this.ugOFAC).Size = new Size(594, 196);
    ((Control) this.ugOFAC).TabIndex = 133;
    ((Control) this.ugOFAC).Tag = (object) "keepEnabled";
    ((UltraControlBase) this.ugOFAC).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ugOFAC).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.UltraTabPageControl4).Controls.Add((Control) this.btnQueryDates);
    ((Control) this.UltraTabPageControl4).Controls.Add((Control) this.Label37);
    ((Control) this.UltraTabPageControl4).Controls.Add((Control) this.Label36);
    ((Control) this.UltraTabPageControl4).Controls.Add((Control) this.dtEndDate);
    ((Control) this.UltraTabPageControl4).Controls.Add((Control) this.dtStartDate);
    ((Control) this.UltraTabPageControl4).Controls.Add((Control) this.lblNumSubmitted);
    ((Control) this.UltraTabPageControl4).Controls.Add((Control) this.Label34);
    ((Control) this.UltraTabPageControl4).Controls.Add((Control) this.lblNumDeclined);
    ((Control) this.UltraTabPageControl4).Controls.Add((Control) this.Label33);
    ((Control) this.UltraTabPageControl4).Controls.Add((Control) this.lblNumBind);
    ((Control) this.UltraTabPageControl4).Controls.Add((Control) this.Label32);
    ((Control) this.UltraTabPageControl4).Controls.Add((Control) this.lblNumQuoted);
    ((Control) this.UltraTabPageControl4).Controls.Add((Control) this.Label30);
    ((Control) this.UltraTabPageControl4).Controls.Add((Control) this.cboCompanyLines);
    ((Control) this.UltraTabPageControl4).Controls.Add((Control) this.Label22);
    ((Control) this.UltraTabPageControl4).Controls.Add((Control) this.chartStats);
    ((Control) this.UltraTabPageControl4).Controls.Add((Control) this.lblTotalPremium);
    ((Control) this.UltraTabPageControl4).Controls.Add((Control) this.Label21);
    ((Control) this.UltraTabPageControl4).Controls.Add((Control) this.lblRenewalRetention);
    ((Control) this.UltraTabPageControl4).Controls.Add((Control) this.Label23);
    ((Control) this.UltraTabPageControl4).Controls.Add((Control) this.lblDeclineRatio);
    ((Control) this.UltraTabPageControl4).Controls.Add((Control) this.Label24);
    ((Control) this.UltraTabPageControl4).Controls.Add((Control) this.lblBindRatio);
    ((Control) this.UltraTabPageControl4).Controls.Add((Control) this.Label25);
    ((Control) this.UltraTabPageControl4).Controls.Add((Control) this.lblQuoteRatio);
    ((Control) this.UltraTabPageControl4).Controls.Add((Control) this.Label26);
    ((Control) this.UltraTabPageControl4).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabPageControl4).Name = "UltraTabPageControl4";
    ((Control) this.UltraTabPageControl4).Size = new Size(810, 357);
    this.btnQueryDates.Image = (Image) componentResourceManager.GetObject("btnQueryDates.Image");
    this.btnQueryDates.Location = new Point(241, 233);
    this.btnQueryDates.Name = "btnQueryDates";
    this.btnQueryDates.Size = new Size(24, 23);
    this.btnQueryDates.TabIndex = 515;
    this.btnQueryDates.UseVisualStyleBackColor = true;
    this.Label37.AutoSize = true;
    this.Label37.BackColor = Color.Transparent;
    this.Label37.Location = new Point(36, 262);
    this.Label37.Name = "Label37";
    this.Label37.Size = new Size(55, 13);
    this.Label37.TabIndex = 514;
    this.Label37.Text = "End Date:";
    this.Label37.TextAlign = ContentAlignment.MiddleLeft;
    this.Label36.AutoSize = true;
    this.Label36.BackColor = Color.Transparent;
    this.Label36.Location = new Point(36, 237);
    this.Label36.Name = "Label36";
    this.Label36.Size = new Size(61, 13);
    this.Label36.TabIndex = 513;
    this.Label36.Text = "Start Date:";
    this.Label36.TextAlign = ContentAlignment.MiddleLeft;
    appearance39.BackColor = Color.White;
    appearance39.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dtEndDate.Appearance = (AppearanceBase) appearance39;
    this.dtEndDate.BackColor = Color.White;
    appearance40.AlphaLevel = (short) 14;
    appearance40.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance40.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance40.BackColorAlpha = (Alpha) 2;
    appearance40.BackGradientAlignment = (GradientAlignment) 4;
    appearance40.BackGradientStyle = (GradientStyle) 5;
    appearance40.BorderAlpha = (Alpha) 1;
    appearance40.BorderColor = Color.FromArgb(78, 122, 171);
    appearance40.ForeColor = Color.FromArgb(49, 85, 153);
    appearance40.ForegroundAlpha = (Alpha) 2;
    this.dtEndDate.ButtonAppearance = (AppearanceBase) appearance40;
    this.dtEndDate.DateTime = new DateTime(1753, 1, 1, 0, 0, 0, 0);
    ((Control) this.dtEndDate).Location = new Point(145, 258);
    this.dtEndDate.MGAStyle = MGAStyles.Blue;
    ((Control) this.dtEndDate).Name = "dtEndDate";
    ((Control) this.dtEndDate).Size = new Size(90, 20);
    ((Control) this.dtEndDate).TabIndex = 512 /*0x0200*/;
    ((UltraControlBase) this.dtEndDate).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtEndDate).UseOsThemes = (DefaultableBoolean) 2;
    this.dtEndDate.Value = (object) null;
    appearance41.BackColor = Color.White;
    appearance41.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dtStartDate.Appearance = (AppearanceBase) appearance41;
    this.dtStartDate.BackColor = Color.White;
    appearance42.AlphaLevel = (short) 14;
    appearance42.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance42.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance42.BackColorAlpha = (Alpha) 2;
    appearance42.BackGradientAlignment = (GradientAlignment) 4;
    appearance42.BackGradientStyle = (GradientStyle) 5;
    appearance42.BorderAlpha = (Alpha) 1;
    appearance42.BorderColor = Color.FromArgb(78, 122, 171);
    appearance42.ForeColor = Color.FromArgb(49, 85, 153);
    appearance42.ForegroundAlpha = (Alpha) 2;
    this.dtStartDate.ButtonAppearance = (AppearanceBase) appearance42;
    this.dtStartDate.DateTime = new DateTime(1753, 1, 1, 0, 0, 0, 0);
    ((Control) this.dtStartDate).Location = new Point(144 /*0x90*/, 233);
    this.dtStartDate.MGAStyle = MGAStyles.Blue;
    ((Control) this.dtStartDate).Name = "dtStartDate";
    ((Control) this.dtStartDate).Size = new Size(91, 20);
    ((Control) this.dtStartDate).TabIndex = 511 /*0x01FF*/;
    ((UltraControlBase) this.dtStartDate).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtStartDate).UseOsThemes = (DefaultableBoolean) 2;
    this.dtStartDate.Value = (object) null;
    appearance43.BackColor = Color.Transparent;
    appearance43.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((ControlBase) this.lblNumSubmitted).Appearance = (AppearanceBase) appearance43;
    ((ControlBase) this.lblNumSubmitted).BackColorInternal = Color.WhiteSmoke;
    this.lblNumSubmitted.BorderStyleOuter = (UIElementBorderStyle) 4;
    ((Control) this.lblNumSubmitted).Location = new Point(145, 8);
    ((Control) this.lblNumSubmitted).Name = "lblNumSubmitted";
    ((Control) this.lblNumSubmitted).Size = new Size(72, 20);
    ((Control) this.lblNumSubmitted).TabIndex = 510;
    this.Label34.AutoSize = true;
    this.Label34.BackColor = Color.Transparent;
    this.Label34.Location = new Point(36, 12);
    this.Label34.Name = "Label34";
    this.Label34.Size = new Size(70, 13);
    this.Label34.TabIndex = 509;
    this.Label34.Text = "# Submitted:";
    this.Label34.TextAlign = ContentAlignment.MiddleLeft;
    appearance44.BackColor = Color.Transparent;
    appearance44.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((ControlBase) this.lblNumDeclined).Appearance = (AppearanceBase) appearance44;
    ((ControlBase) this.lblNumDeclined).BackColorInternal = Color.WhiteSmoke;
    this.lblNumDeclined.BorderStyleOuter = (UIElementBorderStyle) 4;
    ((Control) this.lblNumDeclined).Location = new Point(145, 83);
    ((Control) this.lblNumDeclined).Name = "lblNumDeclined";
    ((Control) this.lblNumDeclined).Size = new Size(72, 20);
    ((Control) this.lblNumDeclined).TabIndex = 507;
    this.Label33.AutoSize = true;
    this.Label33.BackColor = Color.Transparent;
    this.Label33.Location = new Point(36, 87);
    this.Label33.Name = "Label33";
    this.Label33.Size = new Size(62, 13);
    this.Label33.TabIndex = 508;
    this.Label33.Text = "# Declined:";
    this.Label33.TextAlign = ContentAlignment.MiddleLeft;
    appearance45.BackColor = Color.Transparent;
    appearance45.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((ControlBase) this.lblNumBind).Appearance = (AppearanceBase) appearance45;
    ((ControlBase) this.lblNumBind).BackColorInternal = Color.WhiteSmoke;
    this.lblNumBind.BorderStyleOuter = (UIElementBorderStyle) 4;
    ((Control) this.lblNumBind).Location = new Point(145, 58);
    ((Control) this.lblNumBind).Name = "lblNumBind";
    ((Control) this.lblNumBind).Size = new Size(72, 20);
    ((Control) this.lblNumBind).TabIndex = 506;
    this.Label32.AutoSize = true;
    this.Label32.BackColor = Color.Transparent;
    this.Label32.Location = new Point(36, 62);
    this.Label32.Name = "Label32";
    this.Label32.Size = new Size(52, 13);
    this.Label32.TabIndex = 505;
    this.Label32.Text = "# Bound:";
    this.Label32.TextAlign = ContentAlignment.MiddleLeft;
    appearance46.BackColor = Color.Transparent;
    appearance46.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((ControlBase) this.lblNumQuoted).Appearance = (AppearanceBase) appearance46;
    ((ControlBase) this.lblNumQuoted).BackColorInternal = Color.WhiteSmoke;
    this.lblNumQuoted.BorderStyleOuter = (UIElementBorderStyle) 4;
    ((Control) this.lblNumQuoted).Location = new Point(145, 33);
    ((Control) this.lblNumQuoted).Name = "lblNumQuoted";
    ((Control) this.lblNumQuoted).Size = new Size(72, 20);
    ((Control) this.lblNumQuoted).TabIndex = 504;
    this.Label30.AutoSize = true;
    this.Label30.BackColor = Color.Transparent;
    this.Label30.Location = new Point(36, 37);
    this.Label30.Name = "Label30";
    this.Label30.Size = new Size(58, 13);
    this.Label30.TabIndex = 503;
    this.Label30.Text = "# Quoted:";
    this.Label30.TextAlign = ContentAlignment.MiddleLeft;
    this.cboCompanyLines.BorderStyle = (UIElementBorderStyle) 4;
    this.cboCompanyLines.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboCompanyLines).DropDownWidth = 400;
    ((Control) this.cboCompanyLines).Location = new Point(145, 283);
    this.cboCompanyLines.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboCompanyLines).Name = "cboCompanyLines";
    ((Control) this.cboCompanyLines).Size = new Size(193, 21);
    ((Control) this.cboCompanyLines).TabIndex = 500;
    ((UltraControlBase) this.cboCompanyLines).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboCompanyLines).UseOsThemes = (DefaultableBoolean) 2;
    this.Label22.AutoSize = true;
    this.Label22.BackColor = Color.Transparent;
    this.Label22.Location = new Point(36, 287);
    this.Label22.Name = "Label22";
    this.Label22.Size = new Size(79, 13);
    this.Label22.TabIndex = 499;
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
    ((Control) this.chartStats).Location = new Point(270, 13);
    ((Control) this.chartStats).Name = "chartStats";
    ((Control) this.chartStats).Size = new Size(475, 262);
    this.chartStats.TabIndex = 501;
    this.chartStats.TitleBottom.Visible = false;
    this.chartStats.TitleTop.Text = "Insured Statistics <TODAY_DATE:MM/dd/yy>";
    appearance47.BackColor = Color.Transparent;
    appearance47.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((ControlBase) this.lblTotalPremium).Appearance = (AppearanceBase) appearance47;
    ((ControlBase) this.lblTotalPremium).BackColorInternal = Color.WhiteSmoke;
    this.lblTotalPremium.BorderStyleOuter = (UIElementBorderStyle) 4;
    ((Control) this.lblTotalPremium).Location = new Point(145, 208 /*0xD0*/);
    ((Control) this.lblTotalPremium).Name = "lblTotalPremium";
    ((Control) this.lblTotalPremium).Size = new Size(120, 20);
    ((Control) this.lblTotalPremium).TabIndex = 496;
    this.Label21.AutoSize = true;
    this.Label21.BackColor = Color.Transparent;
    this.Label21.Location = new Point(36, 212);
    this.Label21.Name = "Label21";
    this.Label21.Size = new Size(78, 13);
    this.Label21.TabIndex = 498;
    this.Label21.Text = "Total Premium:";
    this.Label21.TextAlign = ContentAlignment.MiddleLeft;
    appearance48.BackColor = Color.Transparent;
    appearance48.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((ControlBase) this.lblRenewalRetention).Appearance = (AppearanceBase) appearance48;
    ((ControlBase) this.lblRenewalRetention).BackColorInternal = Color.WhiteSmoke;
    this.lblRenewalRetention.BorderStyleOuter = (UIElementBorderStyle) 4;
    ((Control) this.lblRenewalRetention).Location = new Point(145, 183);
    ((Control) this.lblRenewalRetention).Name = "lblRenewalRetention";
    ((Control) this.lblRenewalRetention).Size = new Size(72, 20);
    ((Control) this.lblRenewalRetention).TabIndex = 494;
    this.Label23.AutoSize = true;
    this.Label23.BackColor = Color.Transparent;
    this.Label23.Location = new Point(36, 187);
    this.Label23.Name = "Label23";
    this.Label23.Size = new Size(102, 13);
    this.Label23.TabIndex = 497;
    this.Label23.Text = "Renewal Retention:";
    this.Label23.TextAlign = ContentAlignment.MiddleLeft;
    appearance49.BackColor = Color.Transparent;
    appearance49.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((ControlBase) this.lblDeclineRatio).Appearance = (AppearanceBase) appearance49;
    ((ControlBase) this.lblDeclineRatio).BackColorInternal = Color.WhiteSmoke;
    this.lblDeclineRatio.BorderStyleOuter = (UIElementBorderStyle) 4;
    ((Control) this.lblDeclineRatio).Location = new Point(145, 158);
    ((Control) this.lblDeclineRatio).Name = "lblDeclineRatio";
    ((Control) this.lblDeclineRatio).Size = new Size(72, 20);
    ((Control) this.lblDeclineRatio).TabIndex = 493;
    this.Label24.AutoSize = true;
    this.Label24.BackColor = Color.Transparent;
    this.Label24.Location = new Point(36, 162);
    this.Label24.Name = "Label24";
    this.Label24.Size = new Size(73, 13);
    this.Label24.TabIndex = 495;
    this.Label24.Text = "Decline Ratio:";
    this.Label24.TextAlign = ContentAlignment.MiddleLeft;
    appearance50.BackColor = Color.Transparent;
    appearance50.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((ControlBase) this.lblBindRatio).Appearance = (AppearanceBase) appearance50;
    ((ControlBase) this.lblBindRatio).BackColorInternal = Color.WhiteSmoke;
    this.lblBindRatio.BorderStyleOuter = (UIElementBorderStyle) 4;
    ((Control) this.lblBindRatio).Location = new Point(145, 133);
    ((Control) this.lblBindRatio).Name = "lblBindRatio";
    ((Control) this.lblBindRatio).Size = new Size(72, 20);
    ((Control) this.lblBindRatio).TabIndex = 491;
    this.Label25.AutoSize = true;
    this.Label25.BackColor = Color.Transparent;
    this.Label25.Location = new Point(36, 137);
    this.Label25.Name = "Label25";
    this.Label25.Size = new Size(59, 13);
    this.Label25.TabIndex = 492;
    this.Label25.Text = "Bind Ratio:";
    this.Label25.TextAlign = ContentAlignment.MiddleLeft;
    appearance51.BackColor = Color.Transparent;
    appearance51.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((ControlBase) this.lblQuoteRatio).Appearance = (AppearanceBase) appearance51;
    ((ControlBase) this.lblQuoteRatio).BackColorInternal = Color.WhiteSmoke;
    this.lblQuoteRatio.BorderStyleOuter = (UIElementBorderStyle) 4;
    ((Control) this.lblQuoteRatio).Location = new Point(145, 108);
    ((Control) this.lblQuoteRatio).Name = "lblQuoteRatio";
    ((Control) this.lblQuoteRatio).Size = new Size(72, 20);
    ((Control) this.lblQuoteRatio).TabIndex = 490;
    this.Label26.AutoSize = true;
    this.Label26.BackColor = Color.Transparent;
    this.Label26.Location = new Point(36, 112 /*0x70*/);
    this.Label26.Name = "Label26";
    this.Label26.Size = new Size(69, 13);
    this.Label26.TabIndex = 489;
    this.Label26.Text = "Quote Ratio:";
    this.Label26.TextAlign = ContentAlignment.MiddleLeft;
    ((Control) this.tabCallReport).Controls.Add((Control) this.btnReport);
    ((Control) this.tabCallReport).Controls.Add((Control) this.ugDetails);
    ((Control) this.tabCallReport).Location = new Point(-10000, -10000);
    ((Control) this.tabCallReport).Name = "tabCallReport";
    ((Control) this.tabCallReport).Size = new Size(810, 357);
    ((Control) this.btnReport).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance52.BackColor = Color.FromArgb(248, 248, 248);
    appearance52.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance52.BackGradientStyle = (GradientStyle) 2;
    appearance52.BorderColor = Color.DarkGray;
    appearance52.ImageHAlign = (HAlign) 2;
    appearance52.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnReport).Appearance = (AppearanceBase) appearance52;
    ((Control) this.btnReport).Location = new Point(693, 14);
    ((Control) this.btnReport).Margin = new Padding(4);
    ((Control) this.btnReport).Name = "btnReport";
    ((Control) this.btnReport).Size = new Size(111, 33);
    ((Control) this.btnReport).TabIndex = 246;
    ((ControlBase) this.btnReport).Text = "Add Call Report";
    this.btnReport.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.ugDetails).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraControlBase) this.ugDetails).Cursor = Cursors.Hand;
    ((UltraGridBase) this.ugDetails).DataSource = (object) this.dvCallReports;
    appearance53.BackColor = Color.White;
    appearance53.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ugDetails).DisplayLayout.Appearance = (AppearanceBase) appearance53;
    ((UltraGridBase) this.ugDetails).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand3.AddButtonCaption = "Details";
    ultraGridColumn17.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn17.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn17.Header.VisiblePosition = 0;
    ultraGridColumn17.Hidden = true;
    ultraGridColumn17.Width = 49;
    ultraGridColumn18.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn18.Header).Caption = "Date Of Visit";
    ((HeaderBase) ultraGridColumn18.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn18.Header.VisiblePosition = 1;
    ultraGridColumn18.Width = 109;
    ultraGridColumn19.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn19.Header).Caption = "Call Type";
    ((HeaderBase) ultraGridColumn19.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn19.Header.VisiblePosition = 2;
    ultraGridColumn19.Width = 303;
    ultraGridColumn20.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn20.Header).Caption = "Lead Contact";
    ((HeaderBase) ultraGridColumn20.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn20.Header.VisiblePosition = 3;
    ultraGridColumn20.Width = 250;
    ((HeaderBase) ultraGridColumn21.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn21.Header.VisiblePosition = 4;
    ultraGridColumn21.Hidden = true;
    ultraGridColumn21.Width = 173;
    ultraGridBand3.Columns.AddRange(new object[5]
    {
      (object) ultraGridColumn17,
      (object) ultraGridColumn18,
      (object) ultraGridColumn19,
      (object) ultraGridColumn20,
      (object) ultraGridColumn21
    });
    ((UltraGridBase) this.ugDetails).DisplayLayout.BandsSerializer.Add((object) ultraGridBand3);
    ((UltraGridBase) this.ugDetails).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance54.BackColor = Color.LightSteelBlue;
    appearance54.FontData.SizeInPoints = 10f;
    appearance54.ForeColor = Color.Black;
    ((UltraGridBase) this.ugDetails).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance54;
    appearance55.BackColor = Color.White;
    appearance55.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance55.ForeColor = Color.Black;
    ((UltraGridBase) this.ugDetails).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance55;
    ((UltraGridBase) this.ugDetails).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.ugDetails).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.ugDetails).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    appearance56.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugDetails).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance56;
    ((UltraGridBase) this.ugDetails).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    appearance57.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ugDetails).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance57;
    ((UltraGridBase) this.ugDetails).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance58.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ugDetails).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance58;
    appearance59.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugDetails).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance59;
    ((UltraGridBase) this.ugDetails).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance60.BackColor = Color.Transparent;
    appearance60.ForeColor = Color.Black;
    ((UltraGridBase) this.ugDetails).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance60;
    ((UltraGridBase) this.ugDetails).DisplayLayout.Override.SelectTypeCell = (SelectType) 2;
    scrollBarLook3.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.ugDetails).DisplayLayout.ScrollBarLook = scrollBarLook3;
    ((Control) this.ugDetails).Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.ugDetails).Location = new Point(10, 14);
    ((Control) this.ugDetails).Name = "ugDetails";
    ((Control) this.ugDetails).Size = new Size(664, 267);
    ((Control) this.ugDetails).TabIndex = 133;
    ((Control) this.ugDetails).Text = "Available Call Reports";
    ((UltraControlBase) this.ugDetails).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ugDetails).UseOsThemes = (DefaultableBoolean) 2;
    this.dvCallReports.Table = (DataTable) this.dsInsured.tblInsuredCallReport;
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
    ((Control) this.tabCRM).Size = new Size(810, 357);
    this.lblReferredBy.AutoSize = true;
    this.lblReferredBy.BackColor = Color.Transparent;
    this.lblReferredBy.Location = new Point(394, 211);
    this.lblReferredBy.Name = "lblReferredBy";
    this.lblReferredBy.Size = new Size(69, 13);
    this.lblReferredBy.TabIndex = 512 /*0x0200*/;
    this.lblReferredBy.Text = "Referred By:";
    this.lblReferredBy.TextAlign = ContentAlignment.MiddleLeft;
    ((Control) this.cboProducerlocations).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.cboProducerlocations.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboProducerlocations).DataBindings.Add(new Binding("Value", (object) this.dsInsured, "tblInsuredLocations.ReferredBYProdLocation", true));
    ((UltraGridBase) this.cboProducerlocations).DataMember = "tblProducers";
    ((UltraGridBase) this.cboProducerlocations).DataSource = (object) this.dsInsured;
    appearance61.BackColor = Color.White;
    appearance61.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance61.BackGradientStyle = (GradientStyle) 2;
    appearance61.BorderColor = Color.FromArgb(78, 122, 171);
    appearance61.ImageHAlign = (HAlign) 2;
    appearance61.ImageVAlign = (VAlign) 2;
    this.cboProducerlocations.DisplayLayout.Appearance = (AppearanceBase) appearance61;
    this.cboProducerlocations.DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand4.ColHeadersVisible = false;
    ((HeaderBase) ultraGridColumn22.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn22.Header.VisiblePosition = 0;
    ultraGridColumn22.Hidden = true;
    ultraGridColumn22.Width = 235;
    ((HeaderBase) ultraGridColumn23.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn23.Header.VisiblePosition = 1;
    ultraGridColumn23.Width = 331;
    ultraGridBand4.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn22,
      (object) ultraGridColumn23
    });
    this.cboProducerlocations.DisplayLayout.BandsSerializer.Add((object) ultraGridBand4);
    this.cboProducerlocations.DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    this.cboProducerlocations.DisplayLayout.BorderStyleCaption = (UIElementBorderStyle) 1;
    this.cboProducerlocations.DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    appearance62.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance62.Image"));
    appearance62.ImageHAlign = (HAlign) 1;
    ((SpecialBoxBase) this.cboProducerlocations.DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance62;
    appearance63.BackColor = Color.Transparent;
    appearance63.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.cboProducerlocations.DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance63;
    ((SpecialBoxBase) this.cboProducerlocations.DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    appearance64.BackColor = Color.Transparent;
    appearance64.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.cboProducerlocations.DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance64;
    this.cboProducerlocations.DisplayLayout.MaxColScrollRegions = 1;
    this.cboProducerlocations.DisplayLayout.MaxRowScrollRegions = 1;
    appearance65.BackColor = Color.Transparent;
    appearance65.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.cboProducerlocations.DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance65;
    appearance66.BackColor = Color.Transparent;
    appearance66.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.cboProducerlocations.DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance66;
    this.cboProducerlocations.DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    this.cboProducerlocations.DisplayLayout.Override.BorderStyleHeader = (UIElementBorderStyle) 1;
    this.cboProducerlocations.DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    this.cboProducerlocations.DisplayLayout.Override.BorderStyleRowSelector = (UIElementBorderStyle) 1;
    this.cboProducerlocations.DisplayLayout.Override.BorderStyleSummaryFooter = (UIElementBorderStyle) 1;
    this.cboProducerlocations.DisplayLayout.Override.BorderStyleSummaryFooterCaption = (UIElementBorderStyle) 1;
    this.cboProducerlocations.DisplayLayout.Override.BorderStyleSummaryValue = (UIElementBorderStyle) 1;
    this.cboProducerlocations.DisplayLayout.Override.BorderStyleTemplateAddRow = (UIElementBorderStyle) 1;
    appearance67.BackColor = Color.Transparent;
    appearance67.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.cboProducerlocations.DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance67;
    appearance68.ImageHAlign = (HAlign) 2;
    appearance68.ImageVAlign = (VAlign) 2;
    this.cboProducerlocations.DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance68;
    this.cboProducerlocations.DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    this.cboProducerlocations.DisplayLayout.Override.CellPadding = 0;
    appearance69.ImageHAlign = (HAlign) 2;
    appearance69.ImageVAlign = (VAlign) 2;
    this.cboProducerlocations.DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance69;
    appearance70.BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    appearance70.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.cboProducerlocations.DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance70;
    this.cboProducerlocations.DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    this.cboProducerlocations.DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    appearance71.BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    appearance71.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this.cboProducerlocations.DisplayLayout.Override.HotTrackRowAppearance = (AppearanceBase) appearance71;
    appearance72.BackColor = SystemColors.Window;
    appearance72.BorderColor = Color.White;
    this.cboProducerlocations.DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance72;
    this.cboProducerlocations.DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    this.cboProducerlocations.DisplayLayout.Override.RowSpacingAfter = 1;
    appearance73.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance73.BorderColor = Color.FromArgb((int) byte.MaxValue, 214, 88);
    appearance73.ForeColor = Color.Black;
    this.cboProducerlocations.DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance73;
    appearance74.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance74.Image"));
    this.cboProducerlocations.DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance74;
    scrollBarLook4.ViewStyle = (ScrollBarViewStyle) 3;
    this.cboProducerlocations.DisplayLayout.ScrollBarLook = scrollBarLook4;
    this.cboProducerlocations.DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    this.cboProducerlocations.DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    this.cboProducerlocations.DisplayLayout.ViewStyleBand = (ViewStyleBand) 2;
    ((UltraDropDownBase) this.cboProducerlocations).DisplayMember = "ProducerName";
    this.cboProducerlocations.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboProducerlocations).DropDownWidth = 350;
    ((Control) this.cboProducerlocations).Location = new Point(477, 207);
    this.cboProducerlocations.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboProducerlocations).Name = "cboProducerlocations";
    ((Control) this.cboProducerlocations).Size = new Size(210, 21);
    ((Control) this.cboProducerlocations).TabIndex = 14;
    ((UltraControlBase) this.cboProducerlocations).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboProducerlocations).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboProducerlocations).ValueMember = "ProducerGUID";
    this.Label29.AutoSize = true;
    this.Label29.BackColor = Color.Transparent;
    this.Label29.Location = new Point(17, 145);
    this.Label29.Name = "Label29";
    this.Label29.Size = new Size(49, 13);
    this.Label29.TabIndex = 510;
    this.Label29.Text = "Ranking:";
    this.Label29.TextAlign = ContentAlignment.MiddleLeft;
    ((Control) this.MgaComboBox1).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.MgaComboBox1.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.MgaComboBox1).DataBindings.Add(new Binding("Value", (object) this.dsInsured, "tblInsuredLocations.ProducerRankingID", true));
    ((UltraGridBase) this.MgaComboBox1).DataMember = "lstInsuredRankings";
    ((UltraGridBase) this.MgaComboBox1).DataSource = (object) this.dsInsured;
    appearance75.BackColor = Color.White;
    appearance75.BorderColor = Color.FromArgb(78, 122, 171);
    appearance75.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance75.Image"));
    this.MgaComboBox1.DisplayLayout.Appearance = (AppearanceBase) appearance75;
    this.MgaComboBox1.DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand5.ColHeadersVisible = false;
    ((HeaderBase) ultraGridColumn24.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn24.Header.VisiblePosition = 0;
    ultraGridColumn24.Hidden = true;
    ultraGridColumn24.Width = 113;
    ((HeaderBase) ultraGridColumn25.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn25.Header.VisiblePosition = 1;
    ultraGridColumn25.Width = 331;
    ultraGridBand5.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn24,
      (object) ultraGridColumn25
    });
    this.MgaComboBox1.DisplayLayout.BandsSerializer.Add((object) ultraGridBand5);
    this.MgaComboBox1.DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    this.MgaComboBox1.DisplayLayout.BorderStyleCaption = (UIElementBorderStyle) 1;
    this.MgaComboBox1.DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    appearance76.BackColorDisabled = Color.Gainsboro;
    appearance76.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((SpecialBoxBase) this.MgaComboBox1.DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance76;
    appearance77.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance77.Image"));
    this.MgaComboBox1.DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance77;
    ((SpecialBoxBase) this.MgaComboBox1.DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    appearance78.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance78.Image"));
    this.MgaComboBox1.DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance78;
    this.MgaComboBox1.DisplayLayout.MaxColScrollRegions = 1;
    this.MgaComboBox1.DisplayLayout.MaxRowScrollRegions = 1;
    appearance79.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance79.Image"));
    this.MgaComboBox1.DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance79;
    appearance80.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance80.Image"));
    this.MgaComboBox1.DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance80;
    this.MgaComboBox1.DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    this.MgaComboBox1.DisplayLayout.Override.BorderStyleHeader = (UIElementBorderStyle) 1;
    this.MgaComboBox1.DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    this.MgaComboBox1.DisplayLayout.Override.BorderStyleRowSelector = (UIElementBorderStyle) 1;
    this.MgaComboBox1.DisplayLayout.Override.BorderStyleSummaryFooter = (UIElementBorderStyle) 1;
    this.MgaComboBox1.DisplayLayout.Override.BorderStyleSummaryFooterCaption = (UIElementBorderStyle) 1;
    this.MgaComboBox1.DisplayLayout.Override.BorderStyleSummaryValue = (UIElementBorderStyle) 1;
    this.MgaComboBox1.DisplayLayout.Override.BorderStyleTemplateAddRow = (UIElementBorderStyle) 1;
    appearance81.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance81.Image"));
    this.MgaComboBox1.DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance81;
    appearance82.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance82.Image"));
    this.MgaComboBox1.DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance82;
    this.MgaComboBox1.DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    this.MgaComboBox1.DisplayLayout.Override.CellPadding = 0;
    appearance83.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance83.Image"));
    this.MgaComboBox1.DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance83;
    appearance84.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance84.Image"));
    this.MgaComboBox1.DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance84;
    this.MgaComboBox1.DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    this.MgaComboBox1.DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    appearance85.BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    appearance85.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this.MgaComboBox1.DisplayLayout.Override.HotTrackRowAppearance = (AppearanceBase) appearance85;
    appearance86.BorderColor = Color.White;
    appearance86.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance86.Image"));
    this.MgaComboBox1.DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance86;
    this.MgaComboBox1.DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    this.MgaComboBox1.DisplayLayout.Override.RowSpacingAfter = 1;
    appearance87.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance87.BorderColor = Color.FromArgb((int) byte.MaxValue, 214, 88);
    appearance87.ForeColor = Color.Black;
    appearance87.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance87.Image"));
    this.MgaComboBox1.DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance87;
    appearance88.BackColor = SystemColors.ControlLight;
    appearance88.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.MgaComboBox1.DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance88;
    scrollBarLook5.ViewStyle = (ScrollBarViewStyle) 3;
    this.MgaComboBox1.DisplayLayout.ScrollBarLook = scrollBarLook5;
    this.MgaComboBox1.DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    this.MgaComboBox1.DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    this.MgaComboBox1.DisplayLayout.ViewStyleBand = (ViewStyleBand) 2;
    ((UltraDropDownBase) this.MgaComboBox1).DisplayMember = "ProducerRanking";
    this.MgaComboBox1.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.MgaComboBox1).DropDownWidth = 350;
    ((Control) this.MgaComboBox1).Location = new Point(143, 141);
    this.MgaComboBox1.MGAStyle = MGAStyles.Blue;
    ((Control) this.MgaComboBox1).Name = "MgaComboBox1";
    ((Control) this.MgaComboBox1).Size = new Size(232, 21);
    ((Control) this.MgaComboBox1).TabIndex = 5;
    ((UltraControlBase) this.MgaComboBox1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaComboBox1).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.MgaComboBox1).ValueMember = "ID";
    appearance89.BackColor = Color.White;
    appearance89.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dtProdAgrrmntEff.Appearance = (AppearanceBase) appearance89;
    this.dtProdAgrrmntEff.BackColor = Color.White;
    appearance90.AlphaLevel = (short) 14;
    appearance90.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance90.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance90.BackColorAlpha = (Alpha) 2;
    appearance90.BackGradientAlignment = (GradientAlignment) 4;
    appearance90.BackGradientStyle = (GradientStyle) 5;
    appearance90.BorderAlpha = (Alpha) 1;
    appearance90.BorderColor = Color.FromArgb(78, 122, 171);
    appearance90.ForeColor = Color.FromArgb(49, 85, 153);
    appearance90.ForegroundAlpha = (Alpha) 2;
    this.dtProdAgrrmntEff.ButtonAppearance = (AppearanceBase) appearance90;
    ((Control) this.dtProdAgrrmntEff).DataBindings.Add(new Binding("Value", (object) this.dsInsured, "tblInsuredLocations.AgreementEffectiveDate", true));
    this.dtProdAgrrmntEff.DateTime = new DateTime(2018, 8, 30, 0, 0, 0, 0);
    ((Control) this.dtProdAgrrmntEff).Location = new Point(143, 216);
    this.dtProdAgrrmntEff.MGAStyle = MGAStyles.Blue;
    ((Control) this.dtProdAgrrmntEff).Name = "dtProdAgrrmntEff";
    ((Control) this.dtProdAgrrmntEff).Size = new Size(90, 20);
    ((Control) this.dtProdAgrrmntEff).TabIndex = 8;
    ((UltraControlBase) this.dtProdAgrrmntEff).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtProdAgrrmntEff).UseOsThemes = (DefaultableBoolean) 2;
    this.dtProdAgrrmntEff.Value = (object) new DateTime(2018, 8, 30, 0, 0, 0, 0);
    this.Label28.AutoSize = true;
    this.Label28.BackColor = Color.Transparent;
    this.Label28.Location = new Point(17, 220);
    this.Label28.Name = "Label28";
    this.Label28.Size = new Size(88, 13);
    this.Label28.TabIndex = 507;
    this.Label28.Text = "Prod Agrmnt Eff:";
    this.Label28.TextAlign = ContentAlignment.MiddleLeft;
    appearance91.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance91.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkApproveWholesalersList).Appearance = (AppearanceBase) appearance91;
    ((UltraToggleEditorBase) this.chkApproveWholesalersList).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkApproveWholesalersList).BackColorInternal = Color.Transparent;
    ((Control) this.chkApproveWholesalersList).DataBindings.Add(new Binding("Checked", (object) this.dsInsured, "tblInsuredLocations.ApproveWholesalersList", true));
    ((UltraToggleEditorBase) this.chkApproveWholesalersList).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkApproveWholesalersList).Location = new Point(96 /*0x60*/, 273);
    this.chkApproveWholesalersList.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkApproveWholesalersList).Name = "chkApproveWholesalersList";
    ((Control) this.chkApproveWholesalersList).Size = new Size(230, 23);
    ((Control) this.chkApproveWholesalersList).TabIndex = 10;
    ((UltraToggleEditorBase) this.chkApproveWholesalersList).Text = "Is there an Approve List of Wholesalers?";
    ((UltraControlBase) this.chkApproveWholesalersList).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkApproveWholesalersList).UseOsThemes = (DefaultableBoolean) 2;
    appearance92.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance92.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkSetProcedureToEngage).Appearance = (AppearanceBase) appearance92;
    ((UltraToggleEditorBase) this.chkSetProcedureToEngage).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkSetProcedureToEngage).BackColorInternal = Color.Transparent;
    ((Control) this.chkSetProcedureToEngage).DataBindings.Add(new Binding("Checked", (object) this.dsInsured, "tblInsuredLocations.SetProcedureToEnage", true));
    ((UltraToggleEditorBase) this.chkSetProcedureToEngage).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkSetProcedureToEngage).Location = new Point(96 /*0x60*/, 243);
    this.chkSetProcedureToEngage.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkSetProcedureToEngage).Name = "chkSetProcedureToEngage";
    ((Control) this.chkSetProcedureToEngage).Size = new Size(259, 24);
    ((Control) this.chkSetProcedureToEngage).TabIndex = 9;
    ((UltraToggleEditorBase) this.chkSetProcedureToEngage).Text = "Set Procedure on how to engage a wholesaler?";
    ((UltraControlBase) this.chkSetProcedureToEngage).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkSetProcedureToEngage).UseOsThemes = (DefaultableBoolean) 2;
    this.UltraGroupBox2.BackColorInternal = Color.FromArgb(240 /*0xF0*/, 247, 253);
    appearance93.BackColor = Color.White;
    appearance93.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.UltraGroupBox2.ContentAreaAppearance = (AppearanceBase) appearance93;
    ((Control) this.UltraGroupBox2).Controls.Add((Control) this.txtWholesaleRelationships);
    ((Control) this.UltraGroupBox2).Location = new Point(397, 135);
    ((Control) this.UltraGroupBox2).Name = "UltraGroupBox2";
    ((Control) this.UltraGroupBox2).Size = new Size(296, 62);
    ((Control) this.UltraGroupBox2).TabIndex = 13;
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
    appearance94.BackColor = Color.White;
    appearance94.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.UltraGroupBox1.ContentAreaAppearance = (AppearanceBase) appearance94;
    ((Control) this.UltraGroupBox1).Controls.Add((Control) this.txtExpertise);
    ((Control) this.UltraGroupBox1).Location = new Point(397, 67);
    ((Control) this.UltraGroupBox1).Name = "UltraGroupBox1";
    ((Control) this.UltraGroupBox1).Size = new Size(296, 62);
    ((Control) this.UltraGroupBox1).TabIndex = 12;
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
    appearance95.BackColor = Color.White;
    appearance95.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.UltraGroupBox4.ContentAreaAppearance = (AppearanceBase) appearance95;
    ((Control) this.UltraGroupBox4).Controls.Add((Control) this.txtSpecFocusDept);
    ((Control) this.UltraGroupBox4).Location = new Point(394, 5);
    ((Control) this.UltraGroupBox4).Name = "UltraGroupBox4";
    ((Control) this.UltraGroupBox4).Size = new Size(296, 56);
    ((Control) this.UltraGroupBox4).TabIndex = 11;
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
    this.Label27.Location = new Point(17, 193);
    this.Label27.Name = "Label27";
    this.Label27.Size = new Size(99, 13);
    this.Label27.TabIndex = 506;
    this.Label27.Text = "# Wholesale Rela.:";
    this.Label27.TextAlign = ContentAlignment.MiddleLeft;
    appearance96.BackColor = SystemColors.ControlLight;
    appearance96.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.numWholesaleRel).Appearance = (AppearanceBase) appearance96;
    ((UltraNumericEditorBase) this.numWholesaleRel).BackColor = SystemColors.ControlLight;
    ((Control) this.numWholesaleRel).DataBindings.Add(new Binding("Value", (object) this.dsInsured, "tblInsuredLocations.NumWholesaleRelationship", true));
    ((UltraNumericEditorBase) this.numWholesaleRel).FormatString = "";
    ((Control) this.numWholesaleRel).Location = new Point(143, 189);
    this.numWholesaleRel.MaxValue = (object) 99999;
    this.numWholesaleRel.MGAStyle = MGAStyles.Blue;
    this.numWholesaleRel.MinValue = (object) 0;
    ((Control) this.numWholesaleRel).Name = "numWholesaleRel";
    this.numWholesaleRel.Nullable = true;
    ((Control) this.numWholesaleRel).Size = new Size(90, 20);
    ((Control) this.numWholesaleRel).TabIndex = 7;
    ((UltraControlBase) this.numWholesaleRel).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numWholesaleRel).UseOsThemes = (DefaultableBoolean) 2;
    this.numWholesaleRel.Value = (object) null;
    this.lblProdPro.AutoSize = true;
    this.lblProdPro.BackColor = Color.Transparent;
    this.lblProdPro.Location = new Point(17, 117);
    this.lblProdPro.Name = "lblProdPro";
    this.lblProdPro.Size = new Size(107, 13);
    this.lblProdPro.TabIndex = 505;
    this.lblProdPro.Text = "Production Potential:";
    this.lblProdPro.TextAlign = ContentAlignment.MiddleLeft;
    this.lblSource.AutoSize = true;
    this.lblSource.BackColor = Color.Transparent;
    this.lblSource.Location = new Point(17, 61);
    this.lblSource.Name = "lblSource";
    this.lblSource.Size = new Size(44, 13);
    this.lblSource.TabIndex = 504;
    this.lblSource.Text = "Source:";
    this.lblSource.TextAlign = ContentAlignment.MiddleLeft;
    this.lblProductionStatus.AutoSize = true;
    this.lblProductionStatus.BackColor = Color.Transparent;
    this.lblProductionStatus.Location = new Point(140, 169);
    this.lblProductionStatus.Name = "lblProductionStatus";
    this.lblProductionStatus.Size = new Size(32 /*0x20*/, 13);
    this.lblProductionStatus.TabIndex = 6;
    this.lblProductionStatus.Text = "None";
    this.lblProductionStatus.TextAlign = ContentAlignment.MiddleLeft;
    this.lblProdStatus.AutoSize = true;
    this.lblProdStatus.BackColor = Color.Transparent;
    this.lblProdStatus.Location = new Point(17, 169);
    this.lblProdStatus.Name = "lblProdStatus";
    this.lblProdStatus.Size = new Size(96 /*0x60*/, 13);
    this.lblProdStatus.TabIndex = 502;
    this.lblProdStatus.Text = "Production Status:";
    this.lblProdStatus.TextAlign = ContentAlignment.MiddleLeft;
    ((Control) this.cboOwner).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.cboOwner.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboOwner).DataBindings.Add(new Binding("Value", (object) this.dsInsured, "tblInsuredLocations.Owner", true));
    ((UltraGridBase) this.cboOwner).DataMember = "tblUsers";
    ((UltraGridBase) this.cboOwner).DataSource = (object) this.dsInsured;
    appearance97.BackColor = Color.White;
    appearance97.BorderColor = Color.FromArgb(78, 122, 171);
    appearance97.ForeColor = Color.Black;
    this.cboOwner.DisplayLayout.Appearance = (AppearanceBase) appearance97;
    this.cboOwner.DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand6.ColHeadersVisible = false;
    ultraGridColumn26.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn26.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn26.Header.VisiblePosition = 0;
    ultraGridColumn26.Hidden = true;
    ultraGridColumn26.Width = 231;
    ultraGridColumn27.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn27.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn27.Header.VisiblePosition = 1;
    ultraGridColumn27.Width = 331;
    ultraGridBand6.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn26,
      (object) ultraGridColumn27
    });
    this.cboOwner.DisplayLayout.BandsSerializer.Add((object) ultraGridBand6);
    this.cboOwner.DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    this.cboOwner.DisplayLayout.BorderStyleCaption = (UIElementBorderStyle) 1;
    this.cboOwner.DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    appearance98.BackColor = Color.White;
    appearance98.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance98.ForeColor = Color.Black;
    ((SpecialBoxBase) this.cboOwner.DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance98;
    appearance99.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance99.ForeColor = Color.Black;
    this.cboOwner.DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance99;
    ((SpecialBoxBase) this.cboOwner.DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    appearance100.BackColorDisabled = Color.Gainsboro;
    appearance100.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.cboOwner.DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance100;
    this.cboOwner.DisplayLayout.MaxColScrollRegions = 1;
    this.cboOwner.DisplayLayout.MaxRowScrollRegions = 1;
    appearance101.BackColorDisabled = Color.Gainsboro;
    appearance101.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.cboOwner.DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance101;
    appearance102.BackColor = Color.White;
    appearance102.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance102.ForeColor = Color.Black;
    this.cboOwner.DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance102;
    this.cboOwner.DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    this.cboOwner.DisplayLayout.Override.BorderStyleHeader = (UIElementBorderStyle) 1;
    this.cboOwner.DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    this.cboOwner.DisplayLayout.Override.BorderStyleRowSelector = (UIElementBorderStyle) 1;
    this.cboOwner.DisplayLayout.Override.BorderStyleSummaryFooter = (UIElementBorderStyle) 1;
    this.cboOwner.DisplayLayout.Override.BorderStyleSummaryFooterCaption = (UIElementBorderStyle) 1;
    this.cboOwner.DisplayLayout.Override.BorderStyleSummaryValue = (UIElementBorderStyle) 1;
    this.cboOwner.DisplayLayout.Override.BorderStyleTemplateAddRow = (UIElementBorderStyle) 1;
    appearance103.BackColor = Color.White;
    appearance103.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance103.ForeColor = Color.Black;
    this.cboOwner.DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance103;
    appearance104.BackColor = Color.Transparent;
    appearance104.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance104).TextHAlignAsString = "Left";
    ((AppearanceBase) appearance104).TextVAlignAsString = "Middle";
    this.cboOwner.DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance104;
    this.cboOwner.DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    this.cboOwner.DisplayLayout.Override.CellPadding = 0;
    appearance105.BackColor = Color.White;
    appearance105.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance105.ForeColor = Color.Black;
    this.cboOwner.DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance105;
    appearance106.BackColor = Color.Transparent;
    appearance106.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance106).TextHAlignAsString = "Center";
    ((AppearanceBase) appearance106).TextVAlignAsString = "Middle";
    this.cboOwner.DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance106;
    this.cboOwner.DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    this.cboOwner.DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    appearance107.BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    appearance107.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this.cboOwner.DisplayLayout.Override.HotTrackRowAppearance = (AppearanceBase) appearance107;
    appearance108.BackColor = Color.FromArgb(248, 248, 248);
    appearance108.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance108.BackGradientStyle = (GradientStyle) 2;
    appearance108.BorderColor = Color.White;
    appearance108.ImageHAlign = (HAlign) 2;
    appearance108.ImageVAlign = (VAlign) 2;
    this.cboOwner.DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance108;
    this.cboOwner.DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    this.cboOwner.DisplayLayout.Override.RowSpacingAfter = 1;
    appearance109.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance109.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance109.BackGradientStyle = (GradientStyle) 2;
    appearance109.BorderColor = Color.FromArgb((int) byte.MaxValue, 214, 88);
    appearance109.ForeColor = Color.Black;
    appearance109.ImageHAlign = (HAlign) 2;
    appearance109.ImageVAlign = (VAlign) 2;
    this.cboOwner.DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance109;
    appearance110.BackColor = Color.FromArgb(248, 248, 248);
    appearance110.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance110.BackGradientStyle = (GradientStyle) 2;
    appearance110.BorderColor = Color.DarkGray;
    appearance110.ImageHAlign = (HAlign) 2;
    appearance110.ImageVAlign = (VAlign) 2;
    this.cboOwner.DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance110;
    scrollBarLook6.ViewStyle = (ScrollBarViewStyle) 3;
    this.cboOwner.DisplayLayout.ScrollBarLook = scrollBarLook6;
    this.cboOwner.DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    this.cboOwner.DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    this.cboOwner.DisplayLayout.ViewStyleBand = (ViewStyleBand) 2;
    ((UltraDropDownBase) this.cboOwner).DisplayMember = "Name_LastFirst";
    this.cboOwner.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboOwner).DropDownWidth = 350;
    ((Control) this.cboOwner).Location = new Point(143, 85);
    this.cboOwner.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboOwner).Name = "cboOwner";
    ((Control) this.cboOwner).Size = new Size(232, 21);
    ((Control) this.cboOwner).TabIndex = 3;
    ((UltraControlBase) this.cboOwner).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboOwner).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboOwner).ValueMember = "UserGUID";
    ((Control) this.cboProductionPotential).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.cboProductionPotential.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboProductionPotential).DataBindings.Add(new Binding("Value", (object) this.dsInsured, "tblInsuredLocations.ProductionPotential", true));
    ((UltraGridBase) this.cboProductionPotential).DataMember = "lstProductionPotential";
    ((UltraGridBase) this.cboProductionPotential).DataSource = (object) this.dsInsured;
    appearance111.BackColor = Color.White;
    appearance111.BorderColor = Color.FromArgb(78, 122, 171);
    appearance111.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance111.Image"));
    this.cboProductionPotential.DisplayLayout.Appearance = (AppearanceBase) appearance111;
    this.cboProductionPotential.DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand7.ColHeadersVisible = false;
    ultraGridColumn28.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn28.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn28.Header.VisiblePosition = 0;
    ultraGridColumn28.Hidden = true;
    ultraGridColumn28.Width = 100;
    ultraGridColumn29.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn29.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn29.Header.VisiblePosition = 1;
    ultraGridColumn29.Width = 331;
    ultraGridBand7.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn28,
      (object) ultraGridColumn29
    });
    this.cboProductionPotential.DisplayLayout.BandsSerializer.Add((object) ultraGridBand7);
    this.cboProductionPotential.DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    this.cboProductionPotential.DisplayLayout.BorderStyleCaption = (UIElementBorderStyle) 1;
    this.cboProductionPotential.DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    appearance112.BackColorDisabled = Color.Gainsboro;
    appearance112.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((SpecialBoxBase) this.cboProductionPotential.DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance112;
    appearance113.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance113.Image"));
    this.cboProductionPotential.DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance113;
    ((SpecialBoxBase) this.cboProductionPotential.DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    appearance114.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance114.Image"));
    this.cboProductionPotential.DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance114;
    this.cboProductionPotential.DisplayLayout.MaxColScrollRegions = 1;
    this.cboProductionPotential.DisplayLayout.MaxRowScrollRegions = 1;
    appearance115.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance115.Image"));
    this.cboProductionPotential.DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance115;
    appearance116.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance116.Image"));
    this.cboProductionPotential.DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance116;
    this.cboProductionPotential.DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    this.cboProductionPotential.DisplayLayout.Override.BorderStyleHeader = (UIElementBorderStyle) 1;
    this.cboProductionPotential.DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    this.cboProductionPotential.DisplayLayout.Override.BorderStyleRowSelector = (UIElementBorderStyle) 1;
    this.cboProductionPotential.DisplayLayout.Override.BorderStyleSummaryFooter = (UIElementBorderStyle) 1;
    this.cboProductionPotential.DisplayLayout.Override.BorderStyleSummaryFooterCaption = (UIElementBorderStyle) 1;
    this.cboProductionPotential.DisplayLayout.Override.BorderStyleSummaryValue = (UIElementBorderStyle) 1;
    this.cboProductionPotential.DisplayLayout.Override.BorderStyleTemplateAddRow = (UIElementBorderStyle) 1;
    appearance117.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance117.Image"));
    this.cboProductionPotential.DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance117;
    appearance118.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance118.Image"));
    this.cboProductionPotential.DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance118;
    this.cboProductionPotential.DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    this.cboProductionPotential.DisplayLayout.Override.CellPadding = 0;
    appearance119.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance119.Image"));
    this.cboProductionPotential.DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance119;
    appearance120.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance120.Image"));
    this.cboProductionPotential.DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance120;
    this.cboProductionPotential.DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    this.cboProductionPotential.DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    appearance121.BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    appearance121.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this.cboProductionPotential.DisplayLayout.Override.HotTrackRowAppearance = (AppearanceBase) appearance121;
    appearance122.BorderColor = Color.White;
    appearance122.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance122.Image"));
    this.cboProductionPotential.DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance122;
    this.cboProductionPotential.DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    this.cboProductionPotential.DisplayLayout.Override.RowSpacingAfter = 1;
    appearance123.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance123.BorderColor = Color.FromArgb((int) byte.MaxValue, 214, 88);
    appearance123.ForeColor = Color.Black;
    appearance123.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance123.Image"));
    this.cboProductionPotential.DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance123;
    appearance124.BackColor = SystemColors.ControlLight;
    appearance124.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.cboProductionPotential.DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance124;
    scrollBarLook7.ViewStyle = (ScrollBarViewStyle) 3;
    this.cboProductionPotential.DisplayLayout.ScrollBarLook = scrollBarLook7;
    this.cboProductionPotential.DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    this.cboProductionPotential.DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    this.cboProductionPotential.DisplayLayout.ViewStyleBand = (ViewStyleBand) 2;
    ((UltraDropDownBase) this.cboProductionPotential).DisplayMember = "Description";
    this.cboProductionPotential.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboProductionPotential).DropDownWidth = 350;
    ((Control) this.cboProductionPotential).Location = new Point(143, 113);
    this.cboProductionPotential.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboProductionPotential).Name = "cboProductionPotential";
    ((Control) this.cboProductionPotential).Size = new Size(232, 21);
    ((Control) this.cboProductionPotential).TabIndex = 4;
    ((UltraControlBase) this.cboProductionPotential).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboProductionPotential).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboProductionPotential).ValueMember = "ID";
    ((Control) this.cboSource).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.cboSource.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboSource).DataBindings.Add(new Binding("Value", (object) this.dsInsured, "tblInsuredLocations.LocationSource", true));
    ((UltraGridBase) this.cboSource).DataMember = "lstInsuredLocationSource";
    ((UltraGridBase) this.cboSource).DataSource = (object) this.dsInsured;
    appearance125.BackColor = Color.White;
    appearance125.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance125.BackGradientStyle = (GradientStyle) 2;
    appearance125.BorderColor = Color.FromArgb(78, 122, 171);
    appearance125.ImageHAlign = (HAlign) 2;
    appearance125.ImageVAlign = (VAlign) 2;
    this.cboSource.DisplayLayout.Appearance = (AppearanceBase) appearance125;
    this.cboSource.DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand8.ColHeadersVisible = false;
    ((HeaderBase) ultraGridColumn30.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn30.Header.VisiblePosition = 0;
    ultraGridColumn30.Hidden = true;
    ultraGridColumn30.Width = 92;
    ((HeaderBase) ultraGridColumn31.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn31.Header.VisiblePosition = 1;
    ultraGridColumn31.Width = 331;
    ultraGridBand8.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn30,
      (object) ultraGridColumn31
    });
    this.cboSource.DisplayLayout.BandsSerializer.Add((object) ultraGridBand8);
    this.cboSource.DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    this.cboSource.DisplayLayout.BorderStyleCaption = (UIElementBorderStyle) 1;
    this.cboSource.DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    appearance126.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance126.Image"));
    appearance126.ImageHAlign = (HAlign) 1;
    ((SpecialBoxBase) this.cboSource.DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance126;
    appearance127.BackColor = Color.Transparent;
    appearance127.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.cboSource.DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance127;
    ((SpecialBoxBase) this.cboSource.DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    appearance128.BackColor = Color.Transparent;
    appearance128.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.cboSource.DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance128;
    this.cboSource.DisplayLayout.MaxColScrollRegions = 1;
    this.cboSource.DisplayLayout.MaxRowScrollRegions = 1;
    appearance129.BackColor = Color.Transparent;
    appearance129.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.cboSource.DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance129;
    appearance130.BackColor = Color.Transparent;
    appearance130.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.cboSource.DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance130;
    this.cboSource.DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    this.cboSource.DisplayLayout.Override.BorderStyleHeader = (UIElementBorderStyle) 1;
    this.cboSource.DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    this.cboSource.DisplayLayout.Override.BorderStyleRowSelector = (UIElementBorderStyle) 1;
    this.cboSource.DisplayLayout.Override.BorderStyleSummaryFooter = (UIElementBorderStyle) 1;
    this.cboSource.DisplayLayout.Override.BorderStyleSummaryFooterCaption = (UIElementBorderStyle) 1;
    this.cboSource.DisplayLayout.Override.BorderStyleSummaryValue = (UIElementBorderStyle) 1;
    this.cboSource.DisplayLayout.Override.BorderStyleTemplateAddRow = (UIElementBorderStyle) 1;
    appearance131.BackColor = Color.Transparent;
    appearance131.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.cboSource.DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance131;
    appearance132.ImageHAlign = (HAlign) 2;
    appearance132.ImageVAlign = (VAlign) 2;
    this.cboSource.DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance132;
    this.cboSource.DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    this.cboSource.DisplayLayout.Override.CellPadding = 0;
    appearance133.ImageHAlign = (HAlign) 2;
    appearance133.ImageVAlign = (VAlign) 2;
    this.cboSource.DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance133;
    appearance134.BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    appearance134.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.cboSource.DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance134;
    this.cboSource.DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    this.cboSource.DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    appearance135.BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    appearance135.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this.cboSource.DisplayLayout.Override.HotTrackRowAppearance = (AppearanceBase) appearance135;
    appearance136.BackColor = SystemColors.Window;
    appearance136.BorderColor = Color.White;
    this.cboSource.DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance136;
    this.cboSource.DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    this.cboSource.DisplayLayout.Override.RowSpacingAfter = 1;
    appearance137.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance137.BorderColor = Color.FromArgb((int) byte.MaxValue, 214, 88);
    appearance137.ForeColor = Color.Black;
    this.cboSource.DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance137;
    appearance138.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance138.Image"));
    this.cboSource.DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance138;
    scrollBarLook8.ViewStyle = (ScrollBarViewStyle) 3;
    this.cboSource.DisplayLayout.ScrollBarLook = scrollBarLook8;
    this.cboSource.DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    this.cboSource.DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    this.cboSource.DisplayLayout.ViewStyleBand = (ViewStyleBand) 2;
    ((UltraDropDownBase) this.cboSource).DisplayMember = "Source";
    this.cboSource.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboSource).DropDownWidth = 350;
    ((Control) this.cboSource).Location = new Point(143, 57);
    this.cboSource.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboSource).Name = "cboSource";
    ((Control) this.cboSource).Size = new Size(232, 21);
    ((Control) this.cboSource).TabIndex = 2;
    ((UltraControlBase) this.cboSource).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboSource).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboSource).ValueMember = "ID";
    this.lblOwner.AutoSize = true;
    this.lblOwner.BackColor = Color.Transparent;
    this.lblOwner.Location = new Point(17, 89);
    this.lblOwner.Name = "lblOwner";
    this.lblOwner.Size = new Size(43, 13);
    this.lblOwner.TabIndex = 503;
    this.lblOwner.Text = "Owner:";
    this.lblOwner.TextAlign = ContentAlignment.MiddleLeft;
    this.lblGWP.AutoSize = true;
    this.lblGWP.BackColor = Color.Transparent;
    this.lblGWP.Location = new Point(17, 34);
    this.lblGWP.Name = "lblGWP";
    this.lblGWP.Size = new Size(120, 13);
    this.lblGWP.TabIndex = 501;
    this.lblGWP.Text = "Gross Written Premium:";
    this.lblGWP.TextAlign = ContentAlignment.MiddleLeft;
    this.lblEmployees.AutoSize = true;
    this.lblEmployees.BackColor = Color.Transparent;
    this.lblEmployees.Location = new Point(17, 7);
    this.lblEmployees.Name = "lblEmployees";
    this.lblEmployees.Size = new Size(73, 13);
    this.lblEmployees.TabIndex = 500;
    this.lblEmployees.Text = "# Employees:";
    this.lblEmployees.TextAlign = ContentAlignment.MiddleLeft;
    appearance139.BackColor = SystemColors.Window;
    appearance139.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.numGWP).Appearance = (AppearanceBase) appearance139;
    ((UltraNumericEditorBase) this.numGWP).BackColor = SystemColors.Window;
    ((Control) this.numGWP).DataBindings.Add(new Binding("Value", (object) this.dsInsured, "tblInsuredLocations.GrossWrittenPremium", true));
    ((UltraNumericEditorBase) this.numGWP).FormatString = "c";
    ((Control) this.numGWP).Location = new Point(143, 30);
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
    ((UltraNumericEditorBase) this.numEmployees).Appearance = (AppearanceBase) appearance124;
    ((UltraNumericEditorBase) this.numEmployees).BackColor = SystemColors.ControlLight;
    ((Control) this.numEmployees).DataBindings.Add(new Binding("Value", (object) this.dsInsured, "tblInsuredLocations.NumEmployees", true));
    ((UltraNumericEditorBase) this.numEmployees).FormatString = "";
    ((Control) this.numEmployees).Location = new Point(143, 3);
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
    this.lblFEIN.BackColor = Color.Transparent;
    this.lblFEIN.Location = new Point(273, 52);
    this.lblFEIN.Name = "lblFEIN";
    this.lblFEIN.Size = new Size(42, 23);
    this.lblFEIN.TabIndex = 6;
    this.lblFEIN.Text = "FEIN:";
    this.lblFEIN.TextAlign = ContentAlignment.MiddleRight;
    this.lblCity.Location = new Point(-133, 308);
    this.lblCity.Name = "lblCity";
    this.lblCity.Size = new Size(133, 23);
    this.lblCity.TabIndex = 91;
    this.lblCity.Text = "Zip:";
    this.lblCity.TextAlign = ContentAlignment.MiddleRight;
    this.daInsureds.DeleteCommand = this.SqlDeleteCommand1;
    this.daInsureds.InsertCommand = this.SqlInsertCommand2;
    this.daInsureds.SelectCommand = this.SqlSelectCommand1;
    this.daInsureds.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblInsureds", new DataColumnMapping[23]
      {
        new DataColumnMapping("InsuredGUID", "InsuredGUID"),
        new DataColumnMapping("BusinessTypeID", "BusinessTypeID"),
        new DataColumnMapping("FEIN", "FEIN"),
        new DataColumnMapping("StatusID", "StatusID"),
        new DataColumnMapping("DBA", "DBA"),
        new DataColumnMapping("SSN", "SSN"),
        new DataColumnMapping("CorporationName", "CorporationName"),
        new DataColumnMapping("Salutation", "Salutation"),
        new DataColumnMapping("FirstName", "FirstName"),
        new DataColumnMapping("MiddleName", "MiddleName"),
        new DataColumnMapping("LastName", "LastName"),
        new DataColumnMapping("InsuredID", "InsuredID"),
        new DataColumnMapping("Soundex", "Soundex"),
        new DataColumnMapping("PolicyName", "PolicyName"),
        new DataColumnMapping("DOB", "DOB"),
        new DataColumnMapping("RiskID", "RiskID"),
        new DataColumnMapping("CarrierId", "CarrierId"),
        new DataColumnMapping("TaxID", "TaxID"),
        new DataColumnMapping("DNBNumber", "DNBNumber"),
        new DataColumnMapping("OFACCleared", "OFACCleared"),
        new DataColumnMapping("GenderID", "GenderID"),
        new DataColumnMapping("StatusChangeReasonComment", "StatusChangeReasonComment"),
        new DataColumnMapping("OfacClearedDate", "OfacClearedDate")
      })
    });
    this.daInsureds.UpdateCommand = this.SqlUpdateCommand2;
    this.SqlDeleteCommand1.CommandText = "DELETE FROM [tblInsureds] WHERE (([InsuredID] = @Original_InsuredID))";
    this.SqlDeleteCommand1.Connection = this.cnSQL;
    this.SqlDeleteCommand1.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@Original_InsuredID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "InsuredID", DataRowVersion.Original, (object) null)
    });
    this.cnSQL.ConnectionString = "Data Source=mgads0003.mgasystems.com,1433;Initial Catalog=ParagonInsuranceHoldingsTest;Integrated Security=True";
    this.cnSQL.FireInfoMessageEventOnUserErrors = false;
    this.SqlInsertCommand2.CommandText = componentResourceManager.GetString("SqlInsertCommand2.CommandText");
    this.SqlInsertCommand2.Connection = this.cnSQL;
    this.SqlInsertCommand2.Parameters.AddRange(new SqlParameter[23]
    {
      new SqlParameter("@InsuredGUID", SqlDbType.UniqueIdentifier, 0, "InsuredGUID"),
      new SqlParameter("@BusinessTypeID", SqlDbType.TinyInt, 0, "BusinessTypeID"),
      new SqlParameter("@FEIN", SqlDbType.Char, 0, "FEIN"),
      new SqlParameter("@StatusID", SqlDbType.TinyInt, 0, "StatusID"),
      new SqlParameter("@DBA", SqlDbType.VarChar, 0, "DBA"),
      new SqlParameter("@SSN", SqlDbType.Char, 0, "SSN"),
      new SqlParameter("@CorporationName", SqlDbType.VarChar, 0, "CorporationName"),
      new SqlParameter("@Salutation", SqlDbType.VarChar, 0, "Salutation"),
      new SqlParameter("@FirstName", SqlDbType.VarChar, 0, "FirstName"),
      new SqlParameter("@MiddleName", SqlDbType.VarChar, 0, "MiddleName"),
      new SqlParameter("@LastName", SqlDbType.VarChar, 0, "LastName"),
      new SqlParameter("@Soundex", SqlDbType.VarChar, 0, "Soundex"),
      new SqlParameter("@PolicyName", SqlDbType.VarChar, 0, "PolicyName"),
      new SqlParameter("@DOB", SqlDbType.SmallDateTime, 0, "DOB"),
      new SqlParameter("@RiskID", SqlDbType.VarChar, 0, "RiskID"),
      new SqlParameter("@CarrierId", SqlDbType.VarChar, 0, "CarrierId"),
      new SqlParameter("@TaxID", SqlDbType.VarChar, 0, "TaxID"),
      new SqlParameter("@DNBNumber", SqlDbType.VarChar, 0, "DNBNumber"),
      new SqlParameter("@OFACCleared", SqlDbType.Bit, 0, "OFACCleared"),
      new SqlParameter("@GenderID", SqlDbType.Int, 0, "GenderID"),
      new SqlParameter("@StatusChangeReasonComment", SqlDbType.VarChar, 0, "StatusChangeReasonComment"),
      new SqlParameter("@OfacClearedDate", SqlDbType.DateTime, 0, "OfacClearedDate"),
      new SqlParameter("@OptOut", SqlDbType.Bit, 0, "OptOut")
    });
    this.SqlSelectCommand1.CommandText = componentResourceManager.GetString("SqlSelectCommand1.CommandText");
    this.SqlSelectCommand1.Connection = this.cnSQL;
    this.SqlSelectCommand1.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@InsuredGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "InsuredGUID")
    });
    this.SqlUpdateCommand2.CommandText = componentResourceManager.GetString("SqlUpdateCommand2.CommandText");
    this.SqlUpdateCommand2.Connection = this.cnSQL;
    this.SqlUpdateCommand2.Parameters.AddRange(new SqlParameter[24]
    {
      new SqlParameter("@InsuredGUID", SqlDbType.UniqueIdentifier, 0, "InsuredGUID"),
      new SqlParameter("@BusinessTypeID", SqlDbType.TinyInt, 0, "BusinessTypeID"),
      new SqlParameter("@FEIN", SqlDbType.Char, 0, "FEIN"),
      new SqlParameter("@StatusID", SqlDbType.TinyInt, 0, "StatusID"),
      new SqlParameter("@DBA", SqlDbType.VarChar, 0, "DBA"),
      new SqlParameter("@SSN", SqlDbType.Char, 0, "SSN"),
      new SqlParameter("@CorporationName", SqlDbType.VarChar, 0, "CorporationName"),
      new SqlParameter("@Salutation", SqlDbType.VarChar, 0, "Salutation"),
      new SqlParameter("@FirstName", SqlDbType.VarChar, 0, "FirstName"),
      new SqlParameter("@MiddleName", SqlDbType.VarChar, 0, "MiddleName"),
      new SqlParameter("@LastName", SqlDbType.VarChar, 0, "LastName"),
      new SqlParameter("@Soundex", SqlDbType.VarChar, 0, "Soundex"),
      new SqlParameter("@PolicyName", SqlDbType.VarChar, 0, "PolicyName"),
      new SqlParameter("@DOB", SqlDbType.SmallDateTime, 0, "DOB"),
      new SqlParameter("@RiskID", SqlDbType.VarChar, 0, "RiskID"),
      new SqlParameter("@CarrierId", SqlDbType.VarChar, 0, "CarrierId"),
      new SqlParameter("@TaxID", SqlDbType.VarChar, 0, "TaxID"),
      new SqlParameter("@DNBNumber", SqlDbType.VarChar, 0, "DNBNumber"),
      new SqlParameter("@OFACCleared", SqlDbType.Bit, 0, "OFACCleared"),
      new SqlParameter("@GenderID", SqlDbType.Int, 0, "GenderID"),
      new SqlParameter("@StatusChangeReasonComment", SqlDbType.VarChar, 0, "StatusChangeReasonComment"),
      new SqlParameter("@OfacClearedDate", SqlDbType.DateTime, 0, "OfacClearedDate"),
      new SqlParameter("@Original_InsuredID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "InsuredID", DataRowVersion.Original, (object) null),
      new SqlParameter("@OptOut", SqlDbType.Bit, 0, "OptOut")
    });
    this.daContacts.SelectCommand = this.SqlSelectCommand4;
    this.daContacts.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblInsuredContacts", new DataColumnMapping[4]
      {
        new DataColumnMapping("Name", "Name"),
        new DataColumnMapping("InsuredContactGuid", "InsuredContactGuid"),
        new DataColumnMapping("InsuredLocationGuid", "InsuredLocationGuid"),
        new DataColumnMapping("StatusID", "StatusID")
      })
    });
    this.SqlSelectCommand4.CommandText = "SELECT LName + ', ' + FName AS Name, InsuredContactGuid, InsuredLocationGuid, StatusID FROM tblInsuredContacts WHERE (InsuredLocationGuid = @InsuredLocationGuid)";
    this.SqlSelectCommand4.Connection = this.cnSQL;
    this.SqlSelectCommand4.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@InsuredLocationGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "InsuredLocationGuid")
    });
    this.daLocations.DeleteCommand = this.SqlDeleteCommand2;
    this.daLocations.InsertCommand = this.SqlInsertCommand1;
    this.daLocations.SelectCommand = this.SqlSelectCommand3;
    this.daLocations.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblInsuredLocations", new DataColumnMapping[40]
      {
        new DataColumnMapping("InsuredLocationGUID", "InsuredLocationGUID"),
        new DataColumnMapping("InsuredGUID", "InsuredGUID"),
        new DataColumnMapping("DeliveryMethodID", "DeliveryMethodID"),
        new DataColumnMapping("Name", "Name"),
        new DataColumnMapping("Address1", "Address1"),
        new DataColumnMapping("Address2", "Address2"),
        new DataColumnMapping("ZipPlus", "ZipPlus"),
        new DataColumnMapping("Phone", "Phone"),
        new DataColumnMapping("Fax", "Fax"),
        new DataColumnMapping("WebSite", "WebSite"),
        new DataColumnMapping("DateAdded", "DateAdded"),
        new DataColumnMapping("LocationTypeID", "LocationTypeID"),
        new DataColumnMapping("Code", "Code"),
        new DataColumnMapping("Hidden", "Hidden"),
        new DataColumnMapping("City", "City"),
        new DataColumnMapping("County", "County"),
        new DataColumnMapping("State", "State"),
        new DataColumnMapping("ZipCode", "ZipCode"),
        new DataColumnMapping("Email", "Email"),
        new DataColumnMapping("Region", "Region"),
        new DataColumnMapping("ISOCountryCode", "ISOCountryCode"),
        new DataColumnMapping("AddedBy", "AddedBy"),
        new DataColumnMapping("MobileNumber", "MobileNumber"),
        new DataColumnMapping("NumEmployees", "NumEmployees"),
        new DataColumnMapping("GrossWrittenPremium", "GrossWrittenPremium"),
        new DataColumnMapping("LocationSource", "LocationSource"),
        new DataColumnMapping("Owner", "Owner"),
        new DataColumnMapping("ProductionPotential", "ProductionPotential"),
        new DataColumnMapping("ProducerRankingID", "ProducerRankingID"),
        new DataColumnMapping("NumWholesaleRelationship", "NumWholesaleRelationship"),
        new DataColumnMapping("AgreementEffectiveDate", "AgreementEffectiveDate"),
        new DataColumnMapping("SetProcedureToEnage", "SetProcedureToEnage"),
        new DataColumnMapping("ApproveWholesalersList", "ApproveWholesalersList"),
        new DataColumnMapping("ReferredBYProdLocation", "ReferredBYProdLocation"),
        new DataColumnMapping("SpecFocusDept", "SpecFocusDept"),
        new DataColumnMapping("Expertise", "Expertise"),
        new DataColumnMapping("WholesaleRelationships", "WholesaleRelationships"),
        new DataColumnMapping("CountryCodeforPhone", "CountryCodeforPhone"),
        new DataColumnMapping("CountryCodeforFax", "CountryCodeforFax"),
        new DataColumnMapping("CountryCodeforMobile", "CountryCodeforMobile")
      })
    });
    this.daLocations.UpdateCommand = this.SqlUpdateCommand1;
    this.SqlDeleteCommand2.CommandText = "DELETE FROM [dbo].[tblInsuredLocations] WHERE (([InsuredLocationGUID] = @Original_InsuredLocationGUID))";
    this.SqlDeleteCommand2.Connection = this.cnSQL;
    this.SqlDeleteCommand2.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@Original_InsuredLocationGUID", SqlDbType.UniqueIdentifier, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "InsuredLocationGUID", DataRowVersion.Original, (object) null)
    });
    this.SqlInsertCommand1.CommandText = componentResourceManager.GetString("SqlInsertCommand1.CommandText");
    this.SqlInsertCommand1.Connection = this.cnSQL;
    this.SqlInsertCommand1.Parameters.AddRange(new SqlParameter[41]
    {
      new SqlParameter("@InsuredLocationGUID", SqlDbType.UniqueIdentifier, 0, "InsuredLocationGUID"),
      new SqlParameter("@InsuredGUID", SqlDbType.UniqueIdentifier, 0, "InsuredGUID"),
      new SqlParameter("@DeliveryMethodID", SqlDbType.TinyInt, 0, "DeliveryMethodID"),
      new SqlParameter("@Name", SqlDbType.VarChar, 0, "Name"),
      new SqlParameter("@Address1", SqlDbType.VarChar, 0, "Address1"),
      new SqlParameter("@Address2", SqlDbType.VarChar, 0, "Address2"),
      new SqlParameter("@ZipPlus", SqlDbType.VarChar, 0, "ZipPlus"),
      new SqlParameter("@Phone", SqlDbType.VarChar, 0, "Phone"),
      new SqlParameter("@Fax", SqlDbType.VarChar, 0, "Fax"),
      new SqlParameter("@WebSite", SqlDbType.VarChar, 0, "WebSite"),
      new SqlParameter("@DateAdded", SqlDbType.DateTime, 0, "DateAdded"),
      new SqlParameter("@LocationTypeID", SqlDbType.SmallInt, 0, "LocationTypeID"),
      new SqlParameter("@Code", SqlDbType.VarChar, 0, "Code"),
      new SqlParameter("@Hidden", SqlDbType.Bit, 0, "Hidden"),
      new SqlParameter("@City", SqlDbType.VarChar, 0, "City"),
      new SqlParameter("@County", SqlDbType.VarChar, 0, "County"),
      new SqlParameter("@State", SqlDbType.VarChar, 2, "State"),
      new SqlParameter("@ZipCode", SqlDbType.VarChar, 0, "ZipCode"),
      new SqlParameter("@Email", SqlDbType.VarChar, 0, "Email"),
      new SqlParameter("@Region", SqlDbType.VarChar, 0, "Region"),
      new SqlParameter("@ISOCountryCode", SqlDbType.Char, 0, "ISOCountryCode"),
      new SqlParameter("@AddedBy", SqlDbType.UniqueIdentifier, 0, "AddedBy"),
      new SqlParameter("@MobileNumber", SqlDbType.VarChar, 0, "MobileNumber"),
      new SqlParameter("@NumEmployees", SqlDbType.Int, 0, "NumEmployees"),
      new SqlParameter("@GrossWrittenPremium", SqlDbType.Money, 0, "GrossWrittenPremium"),
      new SqlParameter("@LocationSource", SqlDbType.TinyInt, 0, "LocationSource"),
      new SqlParameter("@Owner", SqlDbType.UniqueIdentifier, 0, "Owner"),
      new SqlParameter("@ProductionPotential", SqlDbType.Char, 0, "ProductionPotential"),
      new SqlParameter("@ProducerRankingID", SqlDbType.Int, 0, "ProducerRankingID"),
      new SqlParameter("@NumWholesaleRelationship", SqlDbType.Int, 0, "NumWholesaleRelationship"),
      new SqlParameter("@AgreementEffectiveDate", SqlDbType.DateTime, 0, "AgreementEffectiveDate"),
      new SqlParameter("@SetProcedureToEnage", SqlDbType.Bit, 0, "SetProcedureToEnage"),
      new SqlParameter("@ApproveWholesalersList", SqlDbType.Bit, 0, "ApproveWholesalersList"),
      new SqlParameter("@ReferredBYProdLocation", SqlDbType.UniqueIdentifier, 0, "ReferredBYProdLocation"),
      new SqlParameter("@SpecFocusDept", SqlDbType.Text, 0, "SpecFocusDept"),
      new SqlParameter("@Expertise", SqlDbType.Text, 0, "Expertise"),
      new SqlParameter("@WholesaleRelationships", SqlDbType.Text, 0, "WholesaleRelationships"),
      new SqlParameter("@OptOut", SqlDbType.Bit, 0, "OptOut"),
      new SqlParameter("CountryCodeforPhone", SqlDbType.VarChar, 5, "CountryCodeforPhone"),
      new SqlParameter("CountryCodeforFax", SqlDbType.VarChar, 5, "CountryCodeforFax"),
      new SqlParameter("CountryCodeforMobile", SqlDbType.VarChar, 5, "CountryCodeforMobile")
    });
    this.SqlSelectCommand3.CommandText = componentResourceManager.GetString("SqlSelectCommand3.CommandText");
    this.SqlSelectCommand3.Connection = this.cnSQL;
    this.SqlSelectCommand3.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@InsuredGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "InsuredGUID")
    });
    this.SqlUpdateCommand1.CommandText = componentResourceManager.GetString("SqlUpdateCommand1.CommandText");
    this.SqlUpdateCommand1.Connection = this.cnSQL;
    this.SqlUpdateCommand1.Parameters.AddRange(new SqlParameter[42]
    {
      new SqlParameter("@InsuredLocationGUID", SqlDbType.UniqueIdentifier, 0, "InsuredLocationGUID"),
      new SqlParameter("@InsuredGUID", SqlDbType.UniqueIdentifier, 0, "InsuredGUID"),
      new SqlParameter("@DeliveryMethodID", SqlDbType.TinyInt, 0, "DeliveryMethodID"),
      new SqlParameter("@Name", SqlDbType.VarChar, 0, "Name"),
      new SqlParameter("@Address1", SqlDbType.VarChar, 0, "Address1"),
      new SqlParameter("@Address2", SqlDbType.VarChar, 0, "Address2"),
      new SqlParameter("@ZipPlus", SqlDbType.VarChar, 0, "ZipPlus"),
      new SqlParameter("@Phone", SqlDbType.VarChar, 0, "Phone"),
      new SqlParameter("@Fax", SqlDbType.VarChar, 0, "Fax"),
      new SqlParameter("@WebSite", SqlDbType.VarChar, 0, "WebSite"),
      new SqlParameter("@DateAdded", SqlDbType.DateTime, 0, "DateAdded"),
      new SqlParameter("@LocationTypeID", SqlDbType.SmallInt, 0, "LocationTypeID"),
      new SqlParameter("@Code", SqlDbType.VarChar, 0, "Code"),
      new SqlParameter("@Hidden", SqlDbType.Bit, 0, "Hidden"),
      new SqlParameter("@City", SqlDbType.VarChar, 0, "City"),
      new SqlParameter("@County", SqlDbType.VarChar, 0, "County"),
      new SqlParameter("@State", SqlDbType.VarChar, 2, "State"),
      new SqlParameter("@ZipCode", SqlDbType.VarChar, 0, "ZipCode"),
      new SqlParameter("@Email", SqlDbType.VarChar, 0, "Email"),
      new SqlParameter("@Region", SqlDbType.VarChar, 0, "Region"),
      new SqlParameter("@ISOCountryCode", SqlDbType.Char, 0, "ISOCountryCode"),
      new SqlParameter("@AddedBy", SqlDbType.UniqueIdentifier, 0, "AddedBy"),
      new SqlParameter("@MobileNumber", SqlDbType.VarChar, 0, "MobileNumber"),
      new SqlParameter("@NumEmployees", SqlDbType.Int, 0, "NumEmployees"),
      new SqlParameter("@GrossWrittenPremium", SqlDbType.Money, 0, "GrossWrittenPremium"),
      new SqlParameter("@LocationSource", SqlDbType.TinyInt, 0, "LocationSource"),
      new SqlParameter("@Owner", SqlDbType.UniqueIdentifier, 0, "Owner"),
      new SqlParameter("@ProductionPotential", SqlDbType.Char, 0, "ProductionPotential"),
      new SqlParameter("@ProducerRankingID", SqlDbType.Int, 0, "ProducerRankingID"),
      new SqlParameter("@NumWholesaleRelationship", SqlDbType.Int, 0, "NumWholesaleRelationship"),
      new SqlParameter("@AgreementEffectiveDate", SqlDbType.DateTime, 0, "AgreementEffectiveDate"),
      new SqlParameter("@SetProcedureToEnage", SqlDbType.Bit, 0, "SetProcedureToEnage"),
      new SqlParameter("@ApproveWholesalersList", SqlDbType.Bit, 0, "ApproveWholesalersList"),
      new SqlParameter("@ReferredBYProdLocation", SqlDbType.UniqueIdentifier, 0, "ReferredBYProdLocation"),
      new SqlParameter("@SpecFocusDept", SqlDbType.Text, 0, "SpecFocusDept"),
      new SqlParameter("@Expertise", SqlDbType.Text, 0, "Expertise"),
      new SqlParameter("@WholesaleRelationships", SqlDbType.Text, 0, "WholesaleRelationships"),
      new SqlParameter("@Original_InsuredLocationGUID", SqlDbType.UniqueIdentifier, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "InsuredLocationGUID", DataRowVersion.Original, (object) null),
      new SqlParameter("@OptOut", SqlDbType.Bit, 0, "OptOut"),
      new SqlParameter("@CountryCodeforPhone", SqlDbType.VarChar, 5, "CountryCodeforPhone"),
      new SqlParameter("@CountryCodeforFax", SqlDbType.VarChar, 5, ParameterDirection.Input, false, (byte) 0, (byte) 0, "CountryCodeforFax", DataRowVersion.Current, (object) ""),
      new SqlParameter("@CountryCodeforMobile", SqlDbType.VarChar, 5, "CountryCodeforMobile")
    });
    appearance140.BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    appearance140.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.gbInsuredInfo.ContentAreaAppearance = (AppearanceBase) appearance140;
    ((Control) this.gbInsuredInfo).Controls.Add((Control) this.lblGender);
    ((Control) this.gbInsuredInfo).Controls.Add((Control) this.cmbGender);
    ((Control) this.gbInsuredInfo).Controls.Add((Control) this.lblDNBNumber);
    ((Control) this.gbInsuredInfo).Controls.Add((Control) this.txtlblDNBNumber);
    ((Control) this.gbInsuredInfo).Controls.Add((Control) this.lblTaxID);
    ((Control) this.gbInsuredInfo).Controls.Add((Control) this.MgaTextBox1);
    ((Control) this.gbInsuredInfo).Controls.Add((Control) this.txtRiskID);
    ((Control) this.gbInsuredInfo).Controls.Add((Control) this.lblRiskId);
    ((Control) this.gbInsuredInfo).Controls.Add((Control) this.lnkUseInsured);
    ((Control) this.gbInsuredInfo).Controls.Add((Control) this.Label17);
    ((Control) this.gbInsuredInfo).Controls.Add((Control) this.txtPolicyName);
    ((Control) this.gbInsuredInfo).Controls.Add((Control) this.cboSalutations);
    ((Control) this.gbInsuredInfo).Controls.Add((Control) this.Label13);
    ((Control) this.gbInsuredInfo).Controls.Add((Control) this.Label12);
    ((Control) this.gbInsuredInfo).Controls.Add((Control) this.txtLast);
    ((Control) this.gbInsuredInfo).Controls.Add((Control) this.txtMiddle);
    ((Control) this.gbInsuredInfo).Controls.Add((Control) this.txtFirst);
    ((Control) this.gbInsuredInfo).Controls.Add((Control) this.Label11);
    ((Control) this.gbInsuredInfo).Controls.Add((Control) this.Label10);
    ((Control) this.gbInsuredInfo).Controls.Add((Control) this.txtBusiness);
    ((Control) this.gbInsuredInfo).Controls.Add((Control) this.cboInsuredType);
    ((Control) this.gbInsuredInfo).Controls.Add((Control) this.Label2);
    ((Control) this.gbInsuredInfo).Controls.Add((Control) this.txtFEIN);
    ((Control) this.gbInsuredInfo).Controls.Add((Control) this.lblFEIN);
    ((Control) this.gbInsuredInfo).Controls.Add((Control) this.txtSSN);
    ((Control) this.gbInsuredInfo).Controls.Add((Control) this.Label6);
    ((Control) this.gbInsuredInfo).Location = new Point(8, 0);
    ((Control) this.gbInsuredInfo).Name = "gbInsuredInfo";
    ((Control) this.gbInsuredInfo).Size = new Size(363, 241);
    ((Control) this.gbInsuredInfo).TabIndex = 0;
    this.gbInsuredInfo.Text = "Insured Information";
    this.lblGender.BackColor = Color.Transparent;
    this.lblGender.Location = new Point(277, 143);
    this.lblGender.Name = "lblGender";
    this.lblGender.Size = new Size(48 /*0x30*/, 13);
    this.lblGender.TabIndex = 25;
    this.lblGender.Text = "Gender:";
    this.lblGender.TextAlign = ContentAlignment.MiddleRight;
    this.cmbGender.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cmbGender).DataBindings.Add(new Binding("Value", (object) this.dsInsured, "tblInsureds.GenderId", true));
    ((UltraGridBase) this.cmbGender).DataSource = (object) this.dsInsured.lstClaims_Gender;
    ((UltraDropDownBase) this.cmbGender).DisplayMember = "Gender";
    this.cmbGender.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cmbGender).Location = new Point(280, 158);
    this.cmbGender.MGAStyle = MGAStyles.Blue;
    ((Control) this.cmbGender).Name = "cmbGender";
    ((Control) this.cmbGender).Size = new Size(70, 21);
    ((Control) this.cmbGender).TabIndex = 24;
    ((UltraControlBase) this.cmbGender).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cmbGender).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cmbGender).ValueMember = "GenderId";
    this.lblDNBNumber.AutoSize = true;
    this.lblDNBNumber.BackColor = Color.Transparent;
    this.lblDNBNumber.Location = new Point(192 /*0xC0*/, 216);
    this.lblDNBNumber.Name = "lblDNBNumber";
    this.lblDNBNumber.Size = new Size(42, 13);
    this.lblDNBNumber.TabIndex = 23;
    this.lblDNBNumber.Text = "DNB #:";
    appearance141.BackColor = Color.White;
    appearance141.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance141.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtlblDNBNumber).Appearance = (AppearanceBase) appearance141;
    ((TextEditorControlBase) this.txtlblDNBNumber).BackColor = Color.White;
    ((Control) this.txtlblDNBNumber).DataBindings.Add(new Binding("Text", (object) this.dsInsured, "tblInsureds.DNBNumber", true));
    ((Control) this.txtlblDNBNumber).Location = new Point(239, 212);
    ((TextEditorControlBase) this.txtlblDNBNumber).MaxLength = 15;
    this.txtlblDNBNumber.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtlblDNBNumber).Name = "txtlblDNBNumber";
    ((Control) this.txtlblDNBNumber).Size = new Size(111, 20);
    ((Control) this.txtlblDNBNumber).TabIndex = 0;
    ((UltraControlBase) this.txtlblDNBNumber).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtlblDNBNumber).UseOsThemes = (DefaultableBoolean) 2;
    this.lblTaxID.BackColor = Color.Transparent;
    this.lblTaxID.Location = new Point(7, 214);
    this.lblTaxID.Name = "lblTaxID";
    this.lblTaxID.Size = new Size(47, 16 /*0x10*/);
    this.lblTaxID.TabIndex = 21;
    this.lblTaxID.Text = "Tax ID:";
    this.lblTaxID.TextAlign = ContentAlignment.MiddleLeft;
    appearance142.BackColor = Color.White;
    appearance142.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance142.ForeColor = Color.Black;
    ((TextEditorControlBase) this.MgaTextBox1).Appearance = (AppearanceBase) appearance142;
    ((TextEditorControlBase) this.MgaTextBox1).BackColor = Color.White;
    ((Control) this.MgaTextBox1).DataBindings.Add(new Binding("Text", (object) this.dsInsured, "tblInsureds.TaxID", true));
    ((Control) this.MgaTextBox1).Location = new Point(60, 212);
    ((TextEditorControlBase) this.MgaTextBox1).MaxLength = 15;
    this.MgaTextBox1.MGAStyle = MGAStyles.Blue;
    ((Control) this.MgaTextBox1).Name = "MgaTextBox1";
    ((Control) this.MgaTextBox1).Size = new Size(111, 20);
    ((Control) this.MgaTextBox1).TabIndex = 22;
    ((UltraControlBase) this.MgaTextBox1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaTextBox1).UseOsThemes = (DefaultableBoolean) 2;
    appearance143.BackColor = Color.White;
    appearance143.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance143.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtRiskID).Appearance = (AppearanceBase) appearance143;
    ((TextEditorControlBase) this.txtRiskID).BackColor = Color.White;
    ((Control) this.txtRiskID).DataBindings.Add(new Binding("Value", (object) this.dsInsured, "tblInsureds.RiskID", true));
    ((Control) this.txtRiskID).Location = new Point(280, 32 /*0x20*/);
    ((TextEditorControlBase) this.txtRiskID).MaxLength = 50;
    this.txtRiskID.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtRiskID).Name = "txtRiskID";
    ((Control) this.txtRiskID).Size = new Size(70, 20);
    ((Control) this.txtRiskID).TabIndex = 3;
    ((UltraControlBase) this.txtRiskID).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtRiskID).UseOsThemes = (DefaultableBoolean) 2;
    this.lblRiskId.BackColor = Color.Transparent;
    this.lblRiskId.Location = new Point(272, 9);
    this.lblRiskId.Name = "lblRiskId";
    this.lblRiskId.Size = new Size(52, 23);
    this.lblRiskId.TabIndex = 2;
    this.lblRiskId.Text = "Risk ID:";
    this.lblRiskId.TextAlign = ContentAlignment.MiddleRight;
    this.lnkUseInsured.AutoSize = true;
    this.lnkUseInsured.BackColor = Color.Transparent;
    this.lnkUseInsured.Location = new Point(99, 165);
    this.lnkUseInsured.Name = "lnkUseInsured";
    this.lnkUseInsured.Size = new Size(99, 13);
    this.lnkUseInsured.TabIndex = 19;
    this.lnkUseInsured.TabStop = true;
    this.lnkUseInsured.Text = "(use insured name)";
    this.lnkUseInsured.TextAlign = ContentAlignment.MiddleLeft;
    this.Label17.BackColor = Color.Transparent;
    this.Label17.Location = new Point(7, 165);
    this.Label17.Name = "Label17";
    this.Label17.Size = new Size(91, 16 /*0x10*/);
    this.Label17.TabIndex = 18;
    this.Label17.Text = "Name on Policy:";
    this.Label17.TextAlign = ContentAlignment.MiddleRight;
    appearance144.BackColor = Color.White;
    appearance144.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance144.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtPolicyName).Appearance = (AppearanceBase) appearance144;
    ((TextEditorControlBase) this.txtPolicyName).BackColor = Color.White;
    ((Control) this.txtPolicyName).DataBindings.Add(new Binding("Text", (object) this.dsInsured, "tblInsureds.PolicyName", true));
    ((Control) this.txtPolicyName).Location = new Point(7, 185);
    ((TextEditorControlBase) this.txtPolicyName).MaxLength = 250;
    this.txtPolicyName.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtPolicyName).Name = "txtPolicyName";
    ((Control) this.txtPolicyName).Size = new Size(343, 20);
    ((Control) this.txtPolicyName).TabIndex = 20;
    ((UltraControlBase) this.txtPolicyName).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtPolicyName).UseOsThemes = (DefaultableBoolean) 2;
    this.cboSalutations.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboSalutations).DataBindings.Add(new Binding("Value", (object) this.dsInsured, "tblInsureds.Salutation", true));
    ((UltraGridBase) this.cboSalutations).DataSource = (object) this.dsInsured.lstSalutations;
    ((UltraDropDownBase) this.cboSalutations).DisplayMember = "Salutation";
    this.cboSalutations.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboSalutations).Enabled = false;
    ((Control) this.cboSalutations).Location = new Point(6, 133);
    this.cboSalutations.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboSalutations).Name = "cboSalutations";
    ((Control) this.cboSalutations).Size = new Size(42, 21);
    ((Control) this.cboSalutations).TabIndex = 11;
    ((UltraControlBase) this.cboSalutations).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboSalutations).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboSalutations).ValueMember = "Salutation";
    this.Label13.BackColor = Color.Transparent;
    this.Label13.Location = new Point(167, 111);
    this.Label13.Name = "Label13";
    this.Label13.Size = new Size(42, 16 /*0x10*/);
    this.Label13.TabIndex = 10;
    this.Label13.Text = "Last";
    this.Label13.TextAlign = ContentAlignment.MiddleCenter;
    this.Label12.BackColor = Color.Transparent;
    this.Label12.Location = new Point(119, 111);
    this.Label12.Name = "Label12";
    this.Label12.Size = new Size(42, 16 /*0x10*/);
    this.Label12.TabIndex = 9;
    this.Label12.Text = "Middle";
    this.Label12.TextAlign = ContentAlignment.MiddleCenter;
    appearance145.BackColor = Color.White;
    appearance145.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance145.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtLast).Appearance = (AppearanceBase) appearance145;
    ((TextEditorControlBase) this.txtLast).BackColor = Color.White;
    ((Control) this.txtLast).DataBindings.Add(new Binding("Text", (object) this.dsInsured, "tblInsureds.LastName", true));
    ((Control) this.txtLast).Enabled = false;
    ((Control) this.txtLast).Location = new Point(170, 134);
    ((TextEditorControlBase) this.txtLast).MaxLength = 50;
    this.txtLast.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtLast).Name = "txtLast";
    ((Control) this.txtLast).Size = new Size(98, 20);
    ((Control) this.txtLast).TabIndex = 15;
    ((UltraControlBase) this.txtLast).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtLast).UseOsThemes = (DefaultableBoolean) 2;
    appearance146.BackColor = Color.White;
    appearance146.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance146.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtMiddle).Appearance = (AppearanceBase) appearance146;
    ((TextEditorControlBase) this.txtMiddle).BackColor = Color.White;
    ((Control) this.txtMiddle).DataBindings.Add(new Binding("Text", (object) this.dsInsured, "tblInsureds.MiddleName", true));
    ((Control) this.txtMiddle).Enabled = false;
    ((Control) this.txtMiddle).Location = new Point(122, 134);
    ((TextEditorControlBase) this.txtMiddle).MaxLength = 50;
    this.txtMiddle.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtMiddle).Name = "txtMiddle";
    ((Control) this.txtMiddle).Size = new Size(49, 20);
    ((Control) this.txtMiddle).TabIndex = 14;
    ((UltraControlBase) this.txtMiddle).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtMiddle).UseOsThemes = (DefaultableBoolean) 2;
    appearance147.BackColor = Color.White;
    appearance147.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance147.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtFirst).Appearance = (AppearanceBase) appearance147;
    ((TextEditorControlBase) this.txtFirst).BackColor = Color.White;
    ((Control) this.txtFirst).DataBindings.Add(new Binding("Text", (object) this.dsInsured, "tblInsureds.FirstName", true));
    ((Control) this.txtFirst).Enabled = false;
    ((Control) this.txtFirst).Location = new Point(48 /*0x30*/, 134);
    ((TextEditorControlBase) this.txtFirst).MaxLength = 50;
    this.txtFirst.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtFirst).Name = "txtFirst";
    ((Control) this.txtFirst).Size = new Size(76, 20);
    ((Control) this.txtFirst).TabIndex = 12;
    ((UltraControlBase) this.txtFirst).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtFirst).UseOsThemes = (DefaultableBoolean) 2;
    this.Label11.BackColor = Color.Transparent;
    this.Label11.Location = new Point(7, 63 /*0x3F*/);
    this.Label11.Name = "Label11";
    this.Label11.Size = new Size(91, 16 /*0x10*/);
    this.Label11.TabIndex = 4;
    this.Label11.Text = "Business Name:";
    this.Label11.TextAlign = ContentAlignment.MiddleRight;
    this.Label10.BackColor = Color.Transparent;
    this.Label10.Location = new Point(46, 111);
    this.Label10.Name = "Label10";
    this.Label10.Size = new Size(42, 16 /*0x10*/);
    this.Label10.TabIndex = 8;
    this.Label10.Text = "First";
    this.Label10.TextAlign = ContentAlignment.MiddleCenter;
    appearance148.BackColor = Color.White;
    appearance148.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance148.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtBusiness).Appearance = (AppearanceBase) appearance148;
    ((TextEditorControlBase) this.txtBusiness).BackColor = Color.White;
    ((Control) this.txtBusiness).DataBindings.Add(new Binding("Text", (object) this.dsInsured, "tblInsureds.CorporationName", true));
    ((Control) this.txtBusiness).Enabled = false;
    ((Control) this.txtBusiness).Location = new Point(7, 86);
    ((TextEditorControlBase) this.txtBusiness).MaxLength = 250;
    this.txtBusiness.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtBusiness).Name = "txtBusiness";
    ((Control) this.txtBusiness).Size = new Size(259, 20);
    ((Control) this.txtBusiness).TabIndex = 5;
    ((UltraControlBase) this.txtBusiness).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtBusiness).UseOsThemes = (DefaultableBoolean) 2;
    this.cboInsuredType.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboInsuredType).DataBindings.Add(new Binding("Value", (object) this.dsInsured, "tblInsureds.BusinessTypeID", true));
    ((UltraGridBase) this.cboInsuredType).DataSource = (object) this.dsInsured.lstBusinessTypes;
    ((UltraDropDownBase) this.cboInsuredType).DisplayMember = "BusinessType";
    this.cboInsuredType.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboInsuredType).Location = new Point(48 /*0x30*/, 32 /*0x20*/);
    this.cboInsuredType.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboInsuredType).Name = "cboInsuredType";
    ((Control) this.cboInsuredType).Size = new Size(217, 21);
    ((Control) this.cboInsuredType).TabIndex = 1;
    ((UltraControlBase) this.cboInsuredType).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboInsuredType).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboInsuredType).ValueMember = "BusinessTypeID";
    this.Label2.BackColor = Color.Transparent;
    this.Label2.Location = new Point(7, 34);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(35, 16 /*0x10*/);
    this.Label2.TabIndex = 0;
    this.Label2.Text = "Type:";
    this.Label2.TextAlign = ContentAlignment.MiddleRight;
    appearance149.BackColorDisabled = Color.Gainsboro;
    appearance149.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.txtFEIN.Appearance = (AppearanceBase) appearance149;
    ((Control) this.txtFEIN).DataBindings.Add(new Binding("Value", (object) this.dsInsured, "tblInsureds.FEIN", true));
    this.txtFEIN.EditAs = (EditAsType) 1;
    this.txtFEIN.InputMask = "##-#######";
    ((Control) this.txtFEIN).Location = new Point(280, 72);
    this.txtFEIN.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtFEIN).Name = "txtFEIN";
    this.txtFEIN.NonAutoSizeHeight = 20;
    ((Control) this.txtFEIN).Size = new Size(70, 21);
    ((Control) this.txtFEIN).TabIndex = 7;
    this.txtFEIN.TabNavigation = (MaskedEditTabNavigation) 0;
    this.txtFEIN.Text = "-";
    ((UltraControlBase) this.txtFEIN).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtFEIN).UseOsThemes = (DefaultableBoolean) 2;
    appearance150.BackColorDisabled = Color.Gainsboro;
    appearance150.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.txtSSN.Appearance = (AppearanceBase) appearance150;
    ((Control) this.txtSSN).DataBindings.Add(new Binding("Value", (object) this.dsInsured, "tblInsureds.SSN", true));
    this.txtSSN.EditAs = (EditAsType) 1;
    this.txtSSN.InputMask = "###-##-####";
    ((Control) this.txtSSN).Location = new Point(280, 117);
    this.txtSSN.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtSSN).Name = "txtSSN";
    this.txtSSN.NonAutoSizeHeight = 20;
    ((Control) this.txtSSN).Size = new Size(70, 21);
    ((Control) this.txtSSN).TabIndex = 17;
    this.txtSSN.TabNavigation = (MaskedEditTabNavigation) 0;
    this.txtSSN.Text = "--";
    ((UltraControlBase) this.txtSSN).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtSSN).UseOsThemes = (DefaultableBoolean) 2;
    this.Label6.BackColor = Color.Transparent;
    this.Label6.Location = new Point(273, 96 /*0x60*/);
    this.Label6.Name = "Label6";
    this.Label6.Size = new Size(42, 23);
    this.Label6.TabIndex = 16 /*0x10*/;
    this.Label6.Text = "SSN:";
    this.Label6.TextAlign = ContentAlignment.MiddleRight;
    this.Label16.BackColor = Color.Transparent;
    this.Label16.Location = new Point(33, 116);
    this.Label16.Name = "Label16";
    this.Label16.Size = new Size(42, 16 /*0x10*/);
    this.Label16.TabIndex = 125;
    this.Label16.Text = "Status:";
    this.Label16.TextAlign = ContentAlignment.MiddleRight;
    this.Label1.BackColor = Color.Transparent;
    this.Label1.Location = new Point(7, 54);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(68, 16 /*0x10*/);
    this.Label1.TabIndex = 3;
    this.Label1.Text = "Insured #:";
    this.Label1.TextAlign = ContentAlignment.MiddleRight;
    appearance151.BackColor = Color.White;
    appearance151.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance151.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtInsuredCode).Appearance = (AppearanceBase) appearance151;
    ((TextEditorControlBase) this.txtInsuredCode).BackColor = Color.White;
    ((Control) this.txtInsuredCode).Location = new Point(81, 52);
    ((TextEditorControlBase) this.txtInsuredCode).MaxLength = 5;
    this.txtInsuredCode.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtInsuredCode).Name = "txtInsuredCode";
    ((EditorButtonControlBase) this.txtInsuredCode).ReadOnly = true;
    ((Control) this.txtInsuredCode).Size = new Size(73, 20);
    ((Control) this.txtInsuredCode).TabIndex = 1;
    ((UltraControlBase) this.txtInsuredCode).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtInsuredCode).UseOsThemes = (DefaultableBoolean) 2;
    this.Label5.BackColor = Color.Transparent;
    this.Label5.Location = new Point(40, 23);
    this.Label5.Name = "Label5";
    this.Label5.Size = new Size(35, 16 /*0x10*/);
    this.Label5.TabIndex = 161;
    this.Label5.Text = "DBA:";
    this.Label5.TextAlign = ContentAlignment.MiddleRight;
    appearance152.BackColor = Color.White;
    appearance152.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance152.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtDBA).Appearance = (AppearanceBase) appearance152;
    ((TextEditorControlBase) this.txtDBA).BackColor = Color.White;
    ((Control) this.txtDBA).DataBindings.Add(new Binding("Text", (object) this.dsInsured, "tblInsureds.DBA", true));
    ((Control) this.txtDBA).Location = new Point(81, 21);
    ((TextEditorControlBase) this.txtDBA).MaxLength = 500;
    this.txtDBA.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtDBA).Name = "txtDBA";
    ((Control) this.txtDBA).Size = new Size(152, 20);
    ((Control) this.txtDBA).TabIndex = 0;
    ((UltraControlBase) this.txtDBA).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtDBA).UseOsThemes = (DefaultableBoolean) 2;
    this.ErrProvider.ContainerControl = (ContainerControl) this;
    ((Control) this.gbInsuredInfo2).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    appearance153.BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    appearance153.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.gbInsuredInfo2.ContentAreaAppearance = (AppearanceBase) appearance153;
    ((Control) this.gbInsuredInfo2).Controls.Add((Control) this.lblStatusChangeReason);
    ((Control) this.gbInsuredInfo2).Controls.Add((Control) this.txtStatusChangeComments);
    ((Control) this.gbInsuredInfo2).Controls.Add((Control) this.txtCarrierId);
    ((Control) this.gbInsuredInfo2).Controls.Add((Control) this.lblCarrierId);
    ((Control) this.gbInsuredInfo2).Controls.Add((Control) this.dtDOB);
    ((Control) this.gbInsuredInfo2).Controls.Add((Control) this.Label19);
    ((Control) this.gbInsuredInfo2).Controls.Add((Control) this.txtDBA);
    ((Control) this.gbInsuredInfo2).Controls.Add((Control) this.Label1);
    ((Control) this.gbInsuredInfo2).Controls.Add((Control) this.txtInsuredCode);
    ((Control) this.gbInsuredInfo2).Controls.Add((Control) this.Label5);
    ((Control) this.gbInsuredInfo2).Controls.Add((Control) this.cboInsStatus);
    ((Control) this.gbInsuredInfo2).Controls.Add((Control) this.Label16);
    ((Control) this.gbInsuredInfo2).Location = new Point(378, 0);
    ((Control) this.gbInsuredInfo2).Name = "gbInsuredInfo2";
    ((Control) this.gbInsuredInfo2).Size = new Size(441, 174);
    ((Control) this.gbInsuredInfo2).TabIndex = 3;
    this.gbInsuredInfo2.Text = "Additional Info";
    this.lblStatusChangeReason.BackColor = Color.Transparent;
    this.lblStatusChangeReason.Location = new Point(220, 90);
    this.lblStatusChangeReason.Name = "lblStatusChangeReason";
    this.lblStatusChangeReason.Size = new Size(156, 16 /*0x10*/);
    this.lblStatusChangeReason.TabIndex = 166;
    this.lblStatusChangeReason.Text = "Status Change Comment:";
    this.lblStatusChangeReason.TextAlign = ContentAlignment.MiddleRight;
    ((Control) this.txtStatusChangeComments).Anchor = AnchorStyles.Left;
    appearance154.BackColor = Color.White;
    appearance154.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance154.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtStatusChangeComments).Appearance = (AppearanceBase) appearance154;
    ((TextEditorControlBase) this.txtStatusChangeComments).BackColor = Color.White;
    ((Control) this.txtStatusChangeComments).DataBindings.Add(new Binding("Text", (object) this.dsInsured, "tblInsureds.StatusChangeReasonComment", true));
    ((Control) this.txtStatusChangeComments).Enabled = false;
    ((Control) this.txtStatusChangeComments).Location = new Point(251, 115);
    ((TextEditorControlBase) this.txtStatusChangeComments).MaxLength = 300;
    this.txtStatusChangeComments.MGAStyle = MGAStyles.Blue;
    this.txtStatusChangeComments.Multiline = true;
    ((Control) this.txtStatusChangeComments).Name = "txtStatusChangeComments";
    ((Control) this.txtStatusChangeComments).Size = new Size(165, 52);
    ((Control) this.txtStatusChangeComments).TabIndex = 165;
    ((UltraControlBase) this.txtStatusChangeComments).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtStatusChangeComments).UseOsThemes = (DefaultableBoolean) 2;
    appearance155.BackColor = Color.White;
    appearance155.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance155.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtCarrierId).Appearance = (AppearanceBase) appearance155;
    ((TextEditorControlBase) this.txtCarrierId).BackColor = Color.White;
    ((Control) this.txtCarrierId).DataBindings.Add(new Binding("Value", (object) this.dsInsured, "tblInsureds.CarrierId", true));
    ((Control) this.txtCarrierId).Location = new Point(81, 83);
    ((TextEditorControlBase) this.txtCarrierId).MaxLength = 20;
    this.txtCarrierId.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtCarrierId).Name = "txtCarrierId";
    ((Control) this.txtCarrierId).Size = new Size(116, 20);
    ((Control) this.txtCarrierId).TabIndex = 2;
    ((UltraControlBase) this.txtCarrierId).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtCarrierId).UseOsThemes = (DefaultableBoolean) 2;
    this.lblCarrierId.BackColor = Color.Transparent;
    this.lblCarrierId.Location = new Point(7, 85);
    this.lblCarrierId.Name = "lblCarrierId";
    this.lblCarrierId.Size = new Size(68, 16 /*0x10*/);
    this.lblCarrierId.TabIndex = 164;
    this.lblCarrierId.Text = "Carrier Id:";
    this.lblCarrierId.TextAlign = ContentAlignment.MiddleRight;
    appearance156.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dtDOB.Appearance = (AppearanceBase) appearance156;
    appearance157.AlphaLevel = (short) 14;
    appearance157.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance157.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance157.BackColorAlpha = (Alpha) 2;
    appearance157.BackGradientAlignment = (GradientAlignment) 4;
    appearance157.BackGradientStyle = (GradientStyle) 5;
    appearance157.BorderAlpha = (Alpha) 1;
    appearance157.BorderColor = Color.FromArgb(78, 122, 171);
    appearance157.ForeColor = Color.FromArgb(49, 85, 153);
    appearance157.ForegroundAlpha = (Alpha) 2;
    this.dtDOB.ButtonAppearance = (AppearanceBase) appearance157;
    ((Control) this.dtDOB).DataBindings.Add(new Binding("Value", (object) this.dsInsured, "tblInsureds.DOB", true));
    this.dtDOB.DateTime = new DateTime(1753, 1, 1, 0, 0, 0, 0);
    ((Control) this.dtDOB).Location = new Point(81, 146);
    this.dtDOB.MGAStyle = MGAStyles.Blue;
    ((Control) this.dtDOB).Name = "dtDOB";
    ((Control) this.dtDOB).Size = new Size(152, 20);
    ((Control) this.dtDOB).TabIndex = 4;
    ((UltraControlBase) this.dtDOB).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtDOB).UseOsThemes = (DefaultableBoolean) 2;
    this.dtDOB.Value = (object) null;
    this.Label19.BackColor = Color.Transparent;
    this.Label19.Location = new Point(33, 148);
    this.Label19.Name = "Label19";
    this.Label19.Size = new Size(42, 16 /*0x10*/);
    this.Label19.TabIndex = 162;
    this.Label19.Text = "DOB:";
    this.Label19.TextAlign = ContentAlignment.MiddleRight;
    this.cboInsStatus.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboInsStatus).DataBindings.Add(new Binding("Value", (object) this.dsInsured, "tblInsureds.StatusID", true));
    ((UltraGridBase) this.cboInsStatus).DataSource = (object) this.dsInsured.lstStatus;
    ((UltraDropDownBase) this.cboInsStatus).DisplayMember = "Status";
    this.cboInsStatus.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboInsStatus).Location = new Point(81, 114);
    this.cboInsStatus.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboInsStatus).Name = "cboInsStatus";
    ((Control) this.cboInsStatus).Size = new Size(152, 21);
    ((Control) this.cboInsStatus).TabIndex = 3;
    ((UltraControlBase) this.cboInsStatus).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboInsStatus).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboInsStatus).ValueMember = "StatusID";
    this.UltraToolbarsManager1.DesignerFlags = 1;
    this.UltraToolbarsManager1.DockWithinContainer = (Control) this;
    this.UltraToolbarsManager1.DockWithinContainerBaseType = typeof (Form);
    this.UltraToolbarsManager1.ShowFullMenusDelay = 500;
    ultraToolbar.DockedColumn = 0;
    ultraToolbar.DockedRow = 0;
    ultraToolbar.IsMainMenuBar = true;
    ((UltraToolbarBase) ultraToolbar).NonInheritedTools.AddRange(new ToolBase[1]
    {
      (ToolBase) popupMenuTool1
    });
    ultraToolbar.Text = "MainMenu";
    this.UltraToolbarsManager1.Toolbars.AddRange(new UltraToolbar[1]
    {
      ultraToolbar
    });
    ((ToolPropsBase) ((ToolBase) popupMenuTool2).SharedPropsInternal).Caption = "Insured";
    ((ToolsCollectionBase) popupMenuTool2.Tools).AddRange(new ToolBase[3]
    {
      (ToolBase) buttonTool1,
      (ToolBase) buttonTool2,
      (ToolBase) buttonTool3
    });
    ((ToolPropsBase) ((ToolBase) buttonTool4).SharedPropsInternal).Caption = "Combine Insureds";
    ((ToolPropsBase) ((ToolBase) buttonTool5).SharedPropsInternal).Caption = "Current Loss Information";
    ((ToolPropsBase) ((ToolBase) buttonTool6).SharedPropsInternal).Caption = "Assign Client Offices...";
    this.UltraToolbarsManager1.Tools.AddRange(new ToolBase[4]
    {
      (ToolBase) popupMenuTool2,
      (ToolBase) buttonTool4,
      (ToolBase) buttonTool5,
      (ToolBase) buttonTool6
    });
    ((Control) this._frmInsureds_Toolbars_Dock_Area_Left).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._frmInsureds_Toolbars_Dock_Area_Left).BackColor = Color.White;
    this._frmInsureds_Toolbars_Dock_Area_Left.DockedPosition = (DockedPosition) 2;
    ((Control) this._frmInsureds_Toolbars_Dock_Area_Left).ForeColor = Color.Black;
    ((Control) this._frmInsureds_Toolbars_Dock_Area_Left).Location = new Point(0, 21);
    ((Control) this._frmInsureds_Toolbars_Dock_Area_Left).Name = "_frmInsureds_Toolbars_Dock_Area_Left";
    ((Control) this._frmInsureds_Toolbars_Dock_Area_Left).Size = new Size(0, 622);
    this._frmInsureds_Toolbars_Dock_Area_Left.ToolbarsManager = this.UltraToolbarsManager1;
    ((Control) this._frmInsureds_Toolbars_Dock_Area_Right).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._frmInsureds_Toolbars_Dock_Area_Right).BackColor = Color.White;
    this._frmInsureds_Toolbars_Dock_Area_Right.DockedPosition = (DockedPosition) 3;
    ((Control) this._frmInsureds_Toolbars_Dock_Area_Right).ForeColor = Color.Black;
    ((Control) this._frmInsureds_Toolbars_Dock_Area_Right).Location = new Point(825, 21);
    ((Control) this._frmInsureds_Toolbars_Dock_Area_Right).Name = "_frmInsureds_Toolbars_Dock_Area_Right";
    ((Control) this._frmInsureds_Toolbars_Dock_Area_Right).Size = new Size(0, 622);
    this._frmInsureds_Toolbars_Dock_Area_Right.ToolbarsManager = this.UltraToolbarsManager1;
    ((Control) this._frmInsureds_Toolbars_Dock_Area_Top).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._frmInsureds_Toolbars_Dock_Area_Top).BackColor = Color.White;
    this._frmInsureds_Toolbars_Dock_Area_Top.DockedPosition = (DockedPosition) 0;
    ((Control) this._frmInsureds_Toolbars_Dock_Area_Top).ForeColor = Color.Black;
    ((Control) this._frmInsureds_Toolbars_Dock_Area_Top).Location = new Point(0, 0);
    ((Control) this._frmInsureds_Toolbars_Dock_Area_Top).Name = "_frmInsureds_Toolbars_Dock_Area_Top";
    ((Control) this._frmInsureds_Toolbars_Dock_Area_Top).Size = new Size(825, 21);
    this._frmInsureds_Toolbars_Dock_Area_Top.ToolbarsManager = this.UltraToolbarsManager1;
    ((Control) this._frmInsureds_Toolbars_Dock_Area_Bottom).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._frmInsureds_Toolbars_Dock_Area_Bottom).BackColor = Color.White;
    this._frmInsureds_Toolbars_Dock_Area_Bottom.DockedPosition = (DockedPosition) 1;
    ((Control) this._frmInsureds_Toolbars_Dock_Area_Bottom).ForeColor = Color.Black;
    ((Control) this._frmInsureds_Toolbars_Dock_Area_Bottom).Location = new Point(0, 643);
    ((Control) this._frmInsureds_Toolbars_Dock_Area_Bottom).Name = "_frmInsureds_Toolbars_Dock_Area_Bottom";
    ((Control) this._frmInsureds_Toolbars_Dock_Area_Bottom).Size = new Size(825, 0);
    this._frmInsureds_Toolbars_Dock_Area_Bottom.ToolbarsManager = this.UltraToolbarsManager1;
    this.lnkAddSubmissionGroup.AutoSize = true;
    this.lnkAddSubmissionGroup.Location = new Point(377, 228);
    this.lnkAddSubmissionGroup.Name = "lnkAddSubmissionGroup";
    this.lnkAddSubmissionGroup.Size = new Size(209, 13);
    this.lnkAddSubmissionGroup.TabIndex = 14;
    this.lnkAddSubmissionGroup.TabStop = true;
    this.lnkAddSubmissionGroup.Tag = (object) "keepEnabled";
    this.lnkAddSubmissionGroup.Text = "Create a New Submission For This Insured";
    this.lnkAddSubmissionGroup.TextAlign = ContentAlignment.MiddleRight;
    this.dbSave.AutoQueryRowCountOnLoad = false;
    this.dbSave.EditStyle = EditStyle.ShowEditButton;
    this.dbSave.FreezeEvents = false;
    this.dbSave.Location = new Point(378, 181);
    this.dbSave.Name = "dbSave";
    this.dbSave.Size = new Size(112 /*0x70*/, 40);
    this.dbSave.TabIndex = 137;
    this.dbSave.Tag = (object) "keepEnabled";
    this.dbSave.ToolTipDelete = "Delete Insured";
    this.dbSave.ToolTipEdit = "Edit Insured";
    this.dbSave.ToolTipNew = "New Insured";
    this.dbSave.ToolTipSave = "Save Insured";
    ((UltraTabControlBase) this.tabControl).BackColorInternal = Color.White;
    ((Control) this.tabControl).Controls.Add((Control) this.UltraTabSharedControlsPage1);
    ((Control) this.tabControl).Controls.Add((Control) this.UltraTabPageControl1);
    ((Control) this.tabControl).Controls.Add((Control) this.UltraTabPageControl2);
    ((Control) this.tabControl).Controls.Add((Control) this.UltraTabPageControl3);
    ((Control) this.tabControl).Controls.Add((Control) this.tabOFAC);
    ((Control) this.tabControl).Controls.Add((Control) this.UltraTabPageControl4);
    ((Control) this.tabControl).Controls.Add((Control) this.tabCallReport);
    ((Control) this.tabControl).Controls.Add((Control) this.tabCRM);
    ((Control) this.tabControl).Location = new Point(7, 247);
    ((Control) this.tabControl).Name = "tabControl";
    ((UltraTabControlBase) this.tabControl).SharedControls.AddRange(new Control[7]
    {
      (Control) this.btnDelete,
      (Control) this.btnPrev,
      (Control) this.btnNext,
      (Control) this.btnLast,
      (Control) this.btnFirst,
      (Control) this.lblRecords,
      (Control) this.btnNewInsuredLocation
    });
    ((UltraTabControlBase) this.tabControl).SharedControlsPage = this.UltraTabSharedControlsPage1;
    ((Control) this.tabControl).Size = new Size(812, 384);
    ((Control) this.tabControl).TabIndex = 142;
    ((UltraTabControlBase) this.tabControl).TabLayoutStyle = (TabLayoutStyle) 1;
    ((UltraTabControlBase) this.tabControl).TabPadding = new Size(5, 3);
    appearance158.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance153.Image"));
    ultraTab1.Appearance = (AppearanceBase) appearance158;
    ultraTab1.Key = "tabLocationInfo";
    ultraTab1.TabPage = this.UltraTabPageControl1;
    ultraTab1.Text = "Location Info";
    appearance159.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance154.Image"));
    ultraTab2.Appearance = (AppearanceBase) appearance159;
    ultraTab2.Key = "tabContacts";
    ultraTab2.TabPage = this.UltraTabPageControl2;
    ultraTab2.Text = "Contacts";
    appearance160.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance155.Image"));
    ultraTab3.Appearance = (AppearanceBase) appearance160;
    ultraTab3.Key = "tabInvoices";
    ultraTab3.TabPage = this.UltraTabPageControl3;
    ultraTab3.Text = "Invoices";
    appearance161.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance156.Image"));
    ultraTab4.Appearance = (AppearanceBase) appearance161;
    ultraTab4.TabPage = this.tabOFAC;
    ultraTab4.Text = "OFAC";
    appearance162.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance157.Image"));
    ultraTab5.Appearance = (AppearanceBase) appearance162;
    ultraTab5.Key = "tabStatistics";
    ultraTab5.TabPage = this.UltraTabPageControl4;
    ultraTab5.Text = "Statistics";
    ultraTab6.TabPage = this.tabCallReport;
    ultraTab6.Text = "Call Reports";
    ultraTab7.TabPage = this.tabCRM;
    ultraTab7.Text = "CRM";
    ((UltraTabControlBase) this.tabControl).Tabs.AddRange(new UltraTab[7]
    {
      ultraTab1,
      ultraTab2,
      ultraTab3,
      ultraTab4,
      ultraTab5,
      ultraTab6,
      ultraTab7
    });
    ((UltraTabControlBase) this.tabControl).TabSize = new Size(125, 0);
    ((Control) this.tabControl).Tag = (object) "keepEnabled";
    ((UltraTabControlBase) this.tabControl).ViewStyle = (ViewStyle) 4;
    ((Control) this.UltraTabSharedControlsPage1).Controls.Add((Control) this.btnDelete);
    ((Control) this.UltraTabSharedControlsPage1).Controls.Add((Control) this.btnPrev);
    ((Control) this.UltraTabSharedControlsPage1).Controls.Add((Control) this.btnNext);
    ((Control) this.UltraTabSharedControlsPage1).Controls.Add((Control) this.btnLast);
    ((Control) this.UltraTabSharedControlsPage1).Controls.Add((Control) this.btnFirst);
    ((Control) this.UltraTabSharedControlsPage1).Controls.Add((Control) this.lblRecords);
    ((Control) this.UltraTabSharedControlsPage1).Controls.Add((Control) this.btnNewInsuredLocation);
    ((Control) this.UltraTabSharedControlsPage1).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabSharedControlsPage1).Name = "UltraTabSharedControlsPage1";
    ((Control) this.UltraTabSharedControlsPage1).Size = new Size(810, 357);
    this.daLookups.SelectCommand = this.SqlSelectCommand2;
    this.daLookups.TableMappings.AddRange(new DataTableMapping[5]
    {
      new DataTableMapping("Table", "spGetInsuredFormData", new DataColumnMapping[2]
      {
        new DataColumnMapping("DeliveryMethodID", "DeliveryMethodID"),
        new DataColumnMapping("Description", "Description")
      }),
      new DataTableMapping("Table1", "Table1", new DataColumnMapping[3]
      {
        new DataColumnMapping("BusinessTypeID", "BusinessTypeID"),
        new DataColumnMapping("BusinessType", "BusinessType"),
        new DataColumnMapping("Individual", "Individual")
      }),
      new DataTableMapping("Table2", "Table2", new DataColumnMapping[2]
      {
        new DataColumnMapping("LocationTypeID", "LocationTypeID"),
        new DataColumnMapping("LocationType", "LocationType")
      }),
      new DataTableMapping("Table3", "Table3", new DataColumnMapping[2]
      {
        new DataColumnMapping("StatusID", "StatusID"),
        new DataColumnMapping("Status", "Status")
      }),
      new DataTableMapping("Table4", "Table4", new DataColumnMapping[1]
      {
        new DataColumnMapping("Salutation", "Salutation")
      })
    });
    this.SqlSelectCommand2.CommandText = "[spGetInsuredFormData]";
    this.SqlSelectCommand2.CommandType = CommandType.StoredProcedure;
    this.SqlSelectCommand2.Connection = this.cnSQL;
    this.SqlSelectCommand2.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null)
    });
    this.Label20.AutoSize = true;
    this.Label20.BackColor = Color.Transparent;
    this.Label20.Location = new Point(317, 43);
    this.Label20.Name = "Label20";
    this.Label20.Size = new Size(52, 13);
    this.Label20.TabIndex = 167;
    this.Label20.Text = "Mobile #:";
    this.Label20.TextAlign = ContentAlignment.MiddleRight;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.ClientSize = new Size(825, 643);
    this.Controls.Add((Control) this.tabControl);
    this.Controls.Add((Control) this.dbSave);
    this.Controls.Add((Control) this.lnkAddSubmissionGroup);
    this.Controls.Add((Control) this.gbInsuredInfo2);
    this.Controls.Add((Control) this.gbInsuredInfo);
    this.Controls.Add((Control) this.lblCity);
    this.Controls.Add((Control) this._frmInsureds_Toolbars_Dock_Area_Left);
    this.Controls.Add((Control) this._frmInsureds_Toolbars_Dock_Area_Right);
    this.Controls.Add((Control) this._frmInsureds_Toolbars_Dock_Area_Bottom);
    this.Controls.Add((Control) this._frmInsureds_Toolbars_Dock_Area_Top);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ForeColor = Color.Black;
    this.Name = nameof (frmInsureds);
    this.StartPosition = FormStartPosition.CenterScreen;
    ((Control) this.UltraTabPageControl1).ResumeLayout(false);
    ((Control) this.UltraTabPageControl1).PerformLayout();
    ((ISupportInitialize) this.txtInsuredScoreStatus).EndInit();
    ((ISupportInitialize) this.chkOptOut).EndInit();
    this.dsInsured.EndInit();
    ((ISupportInitialize) this.txtAddedBy).EndInit();
    ((ISupportInitialize) this.txtEmail).EndInit();
    ((ISupportInitialize) this.cboDeliveryMethod).EndInit();
    ((ISupportInitialize) this.txtDateAdded).EndInit();
    ((ISupportInitialize) this.cbOfficeType).EndInit();
    ((ISupportInitialize) this.txtWebSite).EndInit();
    ((ISupportInitialize) this.txtLocation).EndInit();
    ((ISupportInitialize) this.btnDelete).EndInit();
    ((ISupportInitialize) this.btnPrev).EndInit();
    ((ISupportInitialize) this.btnNext).EndInit();
    ((ISupportInitialize) this.btnLast).EndInit();
    ((ISupportInitialize) this.btnFirst).EndInit();
    ((ISupportInitialize) this.btnNewInsuredLocation).EndInit();
    ((Control) this.UltraTabPageControl2).ResumeLayout(false);
    ((ISupportInitialize) this.btnNewContact).EndInit();
    ((ISupportInitialize) this.btnContacts).EndInit();
    ((ISupportInitialize) this.lstContacts).EndInit();
    ((Control) this.UltraTabPageControl3).ResumeLayout(false);
    ((ISupportInitialize) this.dgInvoices).EndInit();
    ((Control) this.tabOFAC).ResumeLayout(false);
    ((Control) this.tabOFAC).PerformLayout();
    ((ISupportInitialize) this.dtOFACClearedDate).EndInit();
    ((ISupportInitialize) this.btnClearOFAC).EndInit();
    ((ISupportInitialize) this.chkOFACCleared).EndInit();
    ((ISupportInitialize) this.ugOFAC).EndInit();
    ((Control) this.UltraTabPageControl4).ResumeLayout(false);
    ((Control) this.UltraTabPageControl4).PerformLayout();
    ((ISupportInitialize) this.dtEndDate).EndInit();
    ((ISupportInitialize) this.dtStartDate).EndInit();
    ((ISupportInitialize) this.cboCompanyLines).EndInit();
    ((ISupportInitialize) this.chartStats).EndInit();
    ((Control) this.tabCallReport).ResumeLayout(false);
    ((ISupportInitialize) this.btnReport).EndInit();
    ((ISupportInitialize) this.ugDetails).EndInit();
    this.dvCallReports.EndInit();
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
    ((ISupportInitialize) this.gbInsuredInfo).EndInit();
    ((Control) this.gbInsuredInfo).ResumeLayout(false);
    ((Control) this.gbInsuredInfo).PerformLayout();
    ((ISupportInitialize) this.cmbGender).EndInit();
    ((ISupportInitialize) this.txtlblDNBNumber).EndInit();
    ((ISupportInitialize) this.MgaTextBox1).EndInit();
    ((ISupportInitialize) this.txtRiskID).EndInit();
    ((ISupportInitialize) this.txtPolicyName).EndInit();
    ((ISupportInitialize) this.cboSalutations).EndInit();
    ((ISupportInitialize) this.txtLast).EndInit();
    ((ISupportInitialize) this.txtMiddle).EndInit();
    ((ISupportInitialize) this.txtFirst).EndInit();
    ((ISupportInitialize) this.txtBusiness).EndInit();
    ((ISupportInitialize) this.cboInsuredType).EndInit();
    ((ISupportInitialize) this.txtFEIN).EndInit();
    ((ISupportInitialize) this.txtSSN).EndInit();
    ((ISupportInitialize) this.txtInsuredCode).EndInit();
    ((ISupportInitialize) this.txtDBA).EndInit();
    ((ISupportInitialize) this.ErrProvider).EndInit();
    ((ISupportInitialize) this.gbInsuredInfo2).EndInit();
    ((Control) this.gbInsuredInfo2).ResumeLayout(false);
    ((Control) this.gbInsuredInfo2).PerformLayout();
    ((ISupportInitialize) this.txtStatusChangeComments).EndInit();
    ((ISupportInitialize) this.txtCarrierId).EndInit();
    ((ISupportInitialize) this.dtDOB).EndInit();
    ((ISupportInitialize) this.cboInsStatus).EndInit();
    ((ISupportInitialize) this.UltraToolbarsManager1).EndInit();
    ((ISupportInitialize) this.tabControl).EndInit();
    ((Control) this.tabControl).ResumeLayout(false);
    ((Control) this.UltraTabSharedControlsPage1).ResumeLayout(false);
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  public frmInsureds(Guid insuredGuid)
    : this()
  {
    this._insuredGuid = insuredGuid;
  }

  public frmInsureds(Guid insuredGuid, Guid insuredLocationGuid)
    : this(insuredGuid)
  {
    this._moveToInsuredLocationGuid = insuredLocationGuid;
  }

  public frmInsureds()
  {
    this.Load += new EventHandler(this.frmInsureds_Load);
    this._skipOfacOnNewInsured = MGASystems.Common.Settings.SystemSettings.GetLazySetting<bool>("OFAC.Insured.SkipOnNew", false, true);
    this._skipOfacOnModifiedInsured = MGASystems.Common.Settings.SystemSettings.GetLazySetting<bool>("OFAC.Insured.SkipOnModified", false, true);
    this._showOfacTab = false;
    this._canClearOFACAndUpdateHistoricalData = false;
    this._lock = RuntimeHelpers.GetObjectValue(new object());
    this._showInsuredCallReportsTab = false;
    this._UnlockIndividualType = false;
    this._producerStatusChanged = false;
    this._origInsuredStatuID = int.MinValue;
    this._origInsuredStatusComment = string.Empty;
    this._ofacStatus = (OfacSystem.OfacStatus) null;
    this._insuredEntity = new Lazy<MGASystems.BusinessObjects.Insured>((Func<MGASystems.BusinessObjects.Insured>) ([SpecialName] () => ObjectFactory.Instance.CreateObjectAs<MGASystems.BusinessObjects.Insured>((object) this._insuredGuid)));
    this.InitializeComponent();
    this.cnSQL.ConnectionString = CurrentUser.Instance.ConnectionString;
  }

  protected internal Guid InsuredGuid => this._insuredGuid;

  protected dsInsured.tblInsuredLocationsRow CurrentLocationRow
  {
    get
    {
      return this.bmbLocation.Position != -1 ? this.dsInsured.tblInsuredLocations[this.bmbLocation.Position] : (dsInsured.tblInsuredLocationsRow) null;
    }
  }

  protected BindingManagerBase bmbLocation
  {
    get
    {
      return this.BindingContext[(object) this.dsInsured, this.dsInsured.tblInsuredLocations.TableName];
    }
  }

  protected bool IsIndividual
  {
    get
    {
      bool isIndividual;
      try
      {
        isIndividual = this.dsInsured.lstBusinessTypes.FindByBusinessTypeID(Conversions.ToInteger(this.cboInsuredType.Value)).Individual;
      }
      catch (NullReferenceException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        isIndividual = false;
        ProjectData.ClearProjectError();
      }
      return isIndividual;
    }
  }

  protected bool ShowOfacTab => this._showOfacTab;

  protected MGASystems.BusinessObjects.Insured InsuredEntity => this._insuredEntity.Value;

  private string InsuredName
  {
    get
    {
      return !this.IsIndividual ? ((TextEditorControlBase) this.txtBusiness).Text : $"{((TextEditorControlBase) this.txtFirst).Text.Trim()}{RuntimeHelpers.GetObjectValue(Interaction.IIf(string.IsNullOrEmpty(((TextEditorControlBase) this.txtMiddle).Text.Trim()), (object) " ", (object) $" {((TextEditorControlBase) this.txtMiddle).Text} "))}{((TextEditorControlBase) this.txtLast).Text}";
    }
  }

  Guid IRecreatableEntity.ControlGUID => Guid.Empty;

  bool IRecreatableEntity.HasControlGUID => false;

  [Browsable(false)]
  public bool CanCreateNewNote
  {
    get
    {
      return !this.DesignMode && this.dsInsured.tblInsuredLocations.Count != 0 && this.dsInsured.tblInsuredLocations.Rows[0].RowState != DataRowState.Added && this.dsInsured.tblInsuredLocations.Rows.Count > 0;
    }
  }

  [Browsable(false)]
  Guid IRecreatableEntity.EntityGuid
  {
    get
    {
      Guid entityGuid;
      if (!this.DesignMode)
      {
        if (this.dsInsured.tblInsuredLocations.Count != 0)
        {
          try
          {
            entityGuid = this.CurrentLocationRow.RowState == DataRowState.Unchanged || this.CurrentLocationRow.RowState == DataRowState.Modified ? this.CurrentLocationRow.InsuredGuid : new Guid();
            goto label_5;
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            entityGuid = new Guid();
            ProjectData.ClearProjectError();
            goto label_5;
          }
        }
      }
      entityGuid = new Guid();
label_5:
      return entityGuid;
    }
  }

  public event ISupportDocumentSystem.EntityInfoChangedEventHandler EntityInfoChanged;

  public event ISupportNoteSystem.EntityInfoChangedEventHandler EntityInfoChanged1;

  [Browsable(false)]
  string IRecreatableEntity.FriendlyEntityName => !this.DesignMode ? "Insured" : (string) null;

  [Browsable(false)]
  string IRecreatableEntity.RecreateTypeName
  {
    get => !this.DesignMode ? typeof (frmInsureds).ToString() : (string) null;
  }

  [Browsable(false)]
  bool IRecreatableEntity.CanReCreateEntity => !this.DesignMode;

  bool IRecreatableEntity.RecreateEntityInitialize(Guid entityGuid)
  {
    this._insuredGuid = entityGuid;
    return true;
  }

  [Browsable(false)]
  string IRecreatableEntity.EntityName
  {
    get
    {
      string entityName;
      if (this.DesignMode)
        entityName = (string) null;
      else
        entityName = $"{this.CurrentLocationRow.tblInsuredsRow.PolicyName} - {ExtensionsMethods.FieldOrDefault<string>((DataRow) this.CurrentLocationRow, "Name", "")}".TrimEnd(' ', '-');
      return entityName;
    }
  }

  private void frmInsureds_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    Cursor.Current = MgaCursors.WaitCursor;
    ImageCache instance = ImageCache.Instance;
    ((ControlBase) this.btnNewInsuredLocation).Appearance.Image = (object) instance.NewImage;
    ((ControlBase) this.btnNewContact).Appearance.Image = (object) instance.NewImage;
    ((ControlBase) this.btnDelete).Appearance.Image = (object) instance.Delete;
    ((ControlBase) this.btnContacts).Appearance.Image = (object) instance.Forward;
    ((ControlBase) this.btnFirst).Appearance.Image = (object) instance.MoveFirst;
    ((ControlBase) this.btnPrev).Appearance.Image = (object) instance.MovePrev;
    ((ControlBase) this.btnNext).Appearance.Image = (object) instance.MoveNext;
    ((ControlBase) this.btnLast).Appearance.Image = (object) instance.MoveLast;
    ((ControlBase) this.btnClearOFAC).Appearance.Image = (object) instance.Undo;
    this._UnlockIndividualType = MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("UnLockIndividualTypeInsureds");
    this.PopulateDataSet();
    this.LoadContacts();
    this.SetSecurityLevel();
    this.dsInsured.tblInsuredContacts.DefaultView.RowFilter = "StatusID=1";
    if (this.dsInsured.tblInsuredLocations.Rows.Count <= 0 || ((TextEditorControlBase) this.txtLocation).Text.Length == 0)
    {
      ((Control) this.btnNewContact).Enabled = false;
      ((Control) this.btnContacts).Enabled = false;
    }
    this.UpdateLocationsNavDisplay();
    this.bmbLocation.PositionChanged += new EventHandler(this.bmbLocation_PositionChanged);
    if (this._insuredGuid.Equals(Guid.Empty))
    {
      ((Control) this.btnDelete).Enabled = false;
      this.CreateNewInsured();
      this.dbSave.UIState = UIState.Editing;
    }
    else
    {
      ((TextEditorControlBase) this.txtInsuredCode).Text = this.dsInsured.tblInsureds[0].InsuredID.ToString();
      if (this.dsInsured.tblInsureds.Count == 0)
        throw new InvalidOperationException("Insured Not Found");
      this.cboInsuredType_ValueChanged((object) null, (EventArgs) null);
      this.cboInsStatus_ValueChanged((object) null, (EventArgs) null);
      this.dbSave.UIState = UIState.HasRecordsNotEditing;
    }
    this.SetFormControlsEnabledState();
    this.cboInsuredType.ValueChanged += new EventHandler(this.cboInsuredType_ValueChanged);
    this.cboInsStatus.ValueChanged += new EventHandler(this.cboInsStatus_ValueChanged);
    Cursor.Current = MgaCursors.Default;
    this._showOfacTab = MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("OFAC.Insured.ShowTab");
    this._implementInsuredScores = InsuranceScore.ImplementsInsuranceScore();
    if (this._implementInsuredScores)
    {
      this.lnkOrderInsuranceScoreReport.Visible = true;
      this.lblInsuredScore.Visible = true;
      ((Control) this.txtInsuredScoreStatus).Visible = true;
    }
    ((UltraTabControlBase) this.tabControl).Tabs[3].Visible = this._showOfacTab;
    ((UltraGridBase) this.ugOFAC).DataSource = (object) null;
    if (this.dsInsured.tblInsureds[0].RowState != DataRowState.Added)
      this.ShowOfacXmlData();
    if (!this._moveToInsuredLocationGuid.Equals(Guid.Empty))
      Database.MoveTo((object) this._moveToInsuredLocationGuid, "InsuredLocationGuid", (DataTable) this.dsInsured.tblInsuredLocations, this.bmbLocation);
    MDIControls.Instance.StatusBarText = string.Empty;
    this._assignClientOffices = MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("AssignClientOfficeToInsured");
    UltraToolbarsManager toolbarsManager1 = this.UltraToolbarsManager1;
    ((ToolsCollectionBase) toolbarsManager1.Tools)["Combine Insureds"].SharedProps.Enabled = SecurityManager.Instance.AssertPermission("{BB72FEAA-727A-4d7a-BE51-35DDA92459B6}");
    ((ToolsCollectionBase) toolbarsManager1.Tools)["Assign Client Offices"].SharedProps.Visible = this._assignClientOffices;
    if (SecurityManager.Instance.AssertPermission("{BCF20F77-76DB-445D-9FDC-7F653B692779}"))
    {
      try
      {
        this.AddMenuItem("AdminRerunOfac", "Rerun OFAC", (string) null, (string) null, (Bitmap) null);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }
    this.lnkAddSubmissionGroup.Enabled = this._canAddSubmissions;
    ((UltraTabControlBase) this.tabControl).Tabs["tabInvoices"].Visible = this._canViewInvoicesTab;
    ((UltraTabControlBase) this.tabControl).Tabs["tabStatistics"].Visible = SecurityManager.Instance.AssertPermission("{4c3f185b-29ad-45c2-9c06-7d6a696f4bfb}");
    ((UltraTabControlBase) this.tabControl).Tabs["tabContacts"].Visible = SecurityManager.Instance.AssertPermission("{b0bef290-e672-4668-a754-01e0854cb3ab}");
    this._showInsuredCallReportsTab = MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("ShowInsuredsCallReportsTab");
    ((Control) this.chkOptOut).Visible = MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("ShowInsuredOptOut");
    ((UltraToggleEditorBase) this.chkOFACCleared).CheckedChanged += new EventHandler(this.OfacCleared_CheckChanged);
    ((UltraTabControlBase) this.tabControl).Tabs[5].Visible = this._showInsuredCallReportsTab;
    this.FillInsuredCallReports(this._insuredGuid, this._showInsuredCallReportsTab);
    this.ScoreNoticeCheck();
    this.FormLoadComplete();
  }

  private void SetSecurityLevel()
  {
    this._CanEditDateOfBirth = SecurityManager.Instance.AssertPermission("{BED4EDC7-CEE8-444B-9BE3-45A3A06DA7CD}");
    this._CanEditInsured = SecurityManager.Instance.AssertPermission("{09F4B2C7-F992-48a8-80C7-7481FA6ACB79}");
    this._canAddInsured = SecurityManager.Instance.AssertPermission("{ADAE0A61-DE61-4aaf-8BCA-39F8158C9248}");
    this._canAddSubmissions = SecurityManager.Instance.AssertPermission("{4951C7B9-9EBC-4711-B3EB-86E9649310E3}");
    this._canEditOFACCleared = SecurityManager.Instance.AssertPermission("{AB502BED-6A60-473D-8B06-B7F180F87B2B}");
    this._canViewInvoicesTab = SecurityManager.Instance.AssertPermission("{65b7a17f-e9e2-4714-8275-f4611a0ea2a6}");
    this._canClearOFACAndUpdateHistoricalData = SecurityManager.Instance.AssertPermission("{A3B94A69-F5FE-4C86-A927-93D45BC9E2D8}");
  }

  internal void LoadContacts()
  {
    if (this.CurrentLocationRow == null)
      return;
    this.dsInsured.tblInsuredContacts.Clear();
    this.daContacts.SelectCommand.Parameters["@InsuredLocationGuid"].Value = (object) this.CurrentLocationRow.InsuredLocationGuid;
    DefaultDatabase.DataAdapterFill((DbDataAdapter) this.daContacts, (DataTable) this.dsInsured.tblInsuredContacts);
    this.lstContacts.Enabled = this.dsInsured.tblInsuredContacts.Rows.Count != 0;
  }

  protected virtual void ValidateFein()
  {
    if (this.IsIndividual && !this._UnlockIndividualType || this.dsInsured.tblInsureds[0].IsFEINNull() || this.txtFEIN.Value == DBNull.Value || this.txtFEIN.Text.Replace("-", string.Empty).Trim().Length == 9)
      return;
    this.txtFEIN.Value = (object) DBNull.Value;
    this.dsInsured.tblInsureds[0].SetFEINNull();
  }

  protected virtual bool IsUniqueInsured()
  {
    DataTable dataTable = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT I.InsuredGUID, I.Name, IL.City, IL.State FROM tblInsureds I INNER JOIN tblInsuredLocations IL ON I.InsuredGUID = IL.InsuredGUID WHERE I.Soundex = dbo.SoundexAlphaFunction(@name)", new object[2]
    {
      (object) "@name",
      (object) this.InsuredName.Replace("'", "''")
    });
    bool flag;
    if (dataTable.Rows.Count > 0)
    {
      using (frmInsuredSoundexMatches insuredSoundexMatches = (frmInsuredSoundexMatches) FormSettings.ShowFormDialog(typeof (frmInsuredSoundexMatches), (object) dataTable))
      {
        if (!insuredSoundexMatches.Saved)
        {
          flag = false;
          goto label_8;
        }
      }
    }
    flag = true;
label_8:
    return flag;
  }

  private void ValidateDba()
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((TextEditorControlBase) this.txtDBA).Text, string.Empty, false) != 0 && ((TextEditorControlBase) this.txtDBA).Text.Replace(" ", string.Empty).Length != 0)
      return;
    this.dsInsured.tblInsureds[0].SetDBANull();
  }

  protected virtual bool IsValidSsnAndFein()
  {
    bool flag;
    if (this.IsIndividual && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(MGASystems.Data.Utility.IsNull<string>(RuntimeHelpers.GetObjectValue(this.txtSSN.Value), string.Empty), string.Empty, false) != 0 || !this.IsIndividual && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(MGASystems.Data.Utility.IsNull<string>(RuntimeHelpers.GetObjectValue(this.txtFEIN.Value), string.Empty), string.Empty, false) != 0)
    {
      string str1;
      string str2;
      if (this.IsIndividual && this.txtSSN.Value != DBNull.Value)
      {
        str1 = "SSN";
        str2 = this.txtSSN.Value.ToString();
      }
      else
      {
        str1 = "FEIN";
        str2 = this.txtFEIN.Value.ToString();
      }
      object objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar("spInsuredDuplicateCheck", new object[6]
      {
        (object) "@InsuredGuid",
        (object) this.InsuredGuid,
        (object) "@columnCheck",
        (object) str1,
        (object) "@columnValue",
        (object) str2
      }));
      if (!MGASystems.Data.Utility.IsNull(RuntimeHelpers.GetObjectValue(objectValue)))
      {
        int num = (int) MessageBox.Show($"{$"An insured with this {str1} was found in the database:"}\n\n{$"{RuntimeHelpers.GetObjectValue(objectValue)}"}\n\nYou can not enter the same insured twice.", "Duplicate Insured", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        flag = false;
        goto label_7;
      }
    }
    flag = true;
label_7:
    return flag;
  }

  private void SetSoundEx()
  {
    string str;
    if (!this.IsIndividual)
      str = DefaultDatabase.ExecuteFunction<string>("dbo.SoundexAlphaFunction", new object[2]
      {
        (object) "@business",
        (object) ((TextEditorControlBase) this.txtBusiness).Text
      });
    else
      str = DefaultDatabase.ExecuteFunction<string>("dbo.SoundexAlphaFunction", new object[2]
      {
        (object) "@insuredName",
        (object) this.InsuredName
      });
    this.dsInsured.tblInsureds[0].Soundex = str;
  }

  private void SetZip()
  {
    if (this.dsInsured.tblInsuredLocations[this.bmbLocation.Position].IsZipPlusNull() || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.dsInsured.tblInsuredLocations[this.bmbLocation.Position].ZipPlus, string.Empty, false) != 0)
      return;
    this.dsInsured.tblInsuredLocations[this.bmbLocation.Position].SetZipPlusNull();
  }

  private void SetCorporationName()
  {
    if (!this.IsIndividual || this.dsInsured.tblInsureds[0].IsCorporationNameNull())
      return;
    this.dsInsured.tblInsureds[0].SetCorporationNameNull();
  }

  protected virtual void SetFein()
  {
    if (!this.IsIndividual || this.dsInsured.tblInsureds[0].IsFEINNull() || this._UnlockIndividualType)
      return;
    this.dsInsured.tblInsureds[0].SetFEINNull();
  }

  private void LogInsuredChanges(bool isNewInsured, bool isModifiedInsured)
  {
    if (isNewInsured)
    {
      CurrentUser.Instance.LogAction("Add Insured: " + this.InsuredName, this._insuredGuid);
    }
    else
    {
      if (!isModifiedInsured)
        return;
      CurrentUser.Instance.LogAction("Modify Insured: " + this.InsuredName, this._insuredGuid);
      bool? nullable = this.dsInsured.tblInsureds[0].Field<bool?>("OFACCleared", DataRowVersion.Original);
      string str1;
      if (nullable.HasValue)
      {
        nullable = this.dsInsured.tblInsureds[0].Field<bool?>("OFACCleared", DataRowVersion.Original);
        str1 = nullable.ToString();
      }
      else
        str1 = "<null>";
      string str2 = str1;
      string str3 = this.dsInsured.tblInsureds[0].IsOFACClearedNull() ? "<null>" : this.dsInsured.tblInsureds[0].OFACCleared.ToString();
      if (str2.Equals(str3))
        return;
      CurrentUser.Instance.LogAction($"Modify Insured: Change 'OFAC Cleared' from {str2} to {str3}", this._insuredGuid);
    }
  }

  private void LogLocationChanges(bool isNewLocation, bool isModifiedLocation)
  {
    if (isNewLocation)
    {
      CurrentUser.Instance.LogAction("Add Insured Location: " + this.dsInsured.tblInsuredLocations[this.bmbLocation.Position].Name, this.dsInsured.tblInsuredLocations[this.bmbLocation.Position].InsuredLocationGuid);
    }
    else
    {
      if (!isModifiedLocation)
        return;
      CurrentUser.Instance.LogAction("Modify Insured Location: " + this.dsInsured.tblInsuredLocations[this.bmbLocation.Position].Name, this.dsInsured.tblInsuredLocations[this.bmbLocation.Position].InsuredLocationGuid);
    }
  }

  private void SetInsuredName() => this.Text = $"Insured Information - {this.InsuredEntity.Name}";

  private void SetInsuredCode(bool isNewInsured)
  {
    if (!isNewInsured)
      return;
    ((TextEditorControlBase) this.txtInsuredCode).Text = DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "SELECT InsuredID FROM tblInsureds WHERE InsuredGuid=@InsuredGuid", new object[2]
    {
      (object) "@InsuredGuid",
      (object) this.dsInsured.tblInsureds[0].InsuredGuid
    }).ToString();
  }

  protected virtual void DoInsuredClientWork(
    Guid insuredGuid,
    object orignalPolName,
    object currPolicyName)
  {
  }

  protected virtual bool SaveChanges()
  {
    bool flag1;
    if (!this.ValidateForm())
    {
      flag1 = false;
    }
    else
    {
      this.ValidateFein();
      this.ValidateDba();
      if (this._assignClientOffices)
      {
        if (DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "SELECT COUNT(*) FROM tblInsuredClientOffice WHERE InsuredGuid=@InsuredGuid", new object[2]
        {
          (object) "@InsuredGuid",
          (object) this.dsInsured.tblInsureds[0].InsuredGuid
        }) == 0)
        {
          int num = (int) MessageBox.Show("Must select at least one client office for Insured", "Insured Client Office", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          flag1 = false;
          goto label_26;
        }
      }
      bool isNewInsured = this.dsInsured.tblInsureds[0].RowState == DataRowState.Added;
      if (isNewInsured && (!this.IsUniqueInsured() || !this.IsValidSsnAndFein()))
      {
        flag1 = false;
      }
      else
      {
        this.SetSoundEx();
        this.BindingContext[(object) this.dsInsured, this.dsInsured.tblInsureds.TableName].EndCurrentEdit();
        this.bmbLocation.EndCurrentEdit();
        this.SetZip();
        this.SetCorporationName();
        this.SetFein();
        try
        {
          dsInsured.tblInsuredsRow tblInsured = this.dsInsured.tblInsureds[0];
          dsInsured.tblInsuredLocationsRow tblInsuredLocation = this.dsInsured.tblInsuredLocations[this.bmbLocation.Position];
          bool isModifiedInsured = tblInsured.RowState == DataRowState.Modified;
          bool isNewLocation = tblInsuredLocation.RowState == DataRowState.Added;
          bool isModifiedLocation = tblInsuredLocation.RowState == DataRowState.Modified;
          bool flag2 = isModifiedLocation && tblInsuredLocation.LocationTypeID == 1 && frmInsureds.HasAddressChanged(tblInsuredLocation);
          this.SaveRichTextBoxesInfo(tblInsuredLocation);
          string str1 = isNewInsured ? (string) null : tblInsured.Field<string>("PolicyName", DataRowVersion.Original);
          string str2 = tblInsured.Field<string>("PolicyName");
          tblInsuredLocation.CountryCodeforPhone = this.MgaInternationalPhone.CountryCode;
          tblInsuredLocation.Phone = this.MgaInternationalPhone.ValueString;
          tblInsuredLocation.CountryCodeforFax = this.MgaInternationaFax.CountryCode;
          tblInsuredLocation.Fax = this.MgaInternationaFax.ValueString;
          tblInsuredLocation.CountryCodeforMobile = this.MgaInternationalMobile.CountryCode;
          tblInsuredLocation.MobileNumber = this.MgaInternationalMobile.ValueString;
          tblInsuredLocation.ZipCode = this.ZipCodeResolver1.ZipCode;
          tblInsuredLocation.City = this.ZipCodeResolver1.City;
          tblInsuredLocation.County = this.ZipCodeResolver1.County;
          tblInsuredLocation.State = this.ZipCodeResolver1.State;
          tblInsuredLocation.ISOCountryCode = this.ZipCodeResolver1.ISOCountryCode;
          bool flag3 = isNewInsured && !this._skipOfacOnNewInsured.Value || isModifiedInsured && !this._skipOfacOnModifiedInsured.Value && (!str1.EqualsNoCase(str2) || flag2);
          if (!this.DoSaveWithTransaction())
          {
            flag1 = false;
          }
          else
          {
            this.SetInsuredCode(isNewInsured);
            this.LogInsuredChanges(isNewInsured, isModifiedInsured);
            this.LogLocationChanges(isNewLocation, isModifiedLocation);
            if (isNewInsured)
              Messaging.SendBroadcastMessage(BroadcastMessages.InsuredAdded, (object) tblInsured.InsuredGuid);
            MDIControls.Instance.StatusBarText = "Insured information saved.";
            if (isModifiedInsured)
              this.DoInsuredClientWork(tblInsured.InsuredGuid, (object) str1, (object) str2);
            this.SetInsuredName();
            ((Control) this.btnNewContact).Enabled = true;
            ((Control) this.btnDelete).Enabled = true;
            if (flag3)
            {
              if (this.NumberPrimaryLocations() > 0)
              {
                try
                {
                  MDIControls.Instance.StatusBarText = "Running OFAC on insured ...";
                  this.Cursor = MgaCursors.WaitCursor;
                  dsInsured.tblInsuredLocationsRow[] source = tblInsured.GettblInsuredLocationsRows();
                  System.Func<dsInsured.tblInsuredLocationsRow, bool> predicate;
                  // ISSUE: reference to a compiler-generated field
                  if (frmInsureds._Closure\u0024__.\u0024I681\u002D0 != null)
                  {
                    // ISSUE: reference to a compiler-generated field
                    predicate = frmInsureds._Closure\u0024__.\u0024I681\u002D0;
                  }
                  else
                  {
                    // ISSUE: reference to a compiler-generated field
                    frmInsureds._Closure\u0024__.\u0024I681\u002D0 = predicate = (System.Func<dsInsured.tblInsuredLocationsRow, bool>) ([SpecialName] (loc) => loc.LocationTypeID == 1 && !loc.Hidden);
                  }
                  InsuredLocation objectAs = ObjectFactory.Instance.CreateObjectAs<InsuredLocation>((object) ((IEnumerable<dsInsured.tblInsuredLocationsRow>) source).FirstOrDefault<dsInsured.tblInsuredLocationsRow>(predicate)?.InsuredLocationGuid.Value);
                  MGASystems.BusinessObjects.Insured insured = objectAs.Insured;
                  // ISSUE: reference to a compiler-generated method
                  Task.Run((Action) ([SpecialName] () => frmInsureds.CheckOfac(objectAs, insured))).ContinueWith((Action<Task>) ([SpecialName] (a0) => this._Lambda\u0024__681\u002D2()), TaskScheduler.FromCurrentSynchronizationContext());
                }
                finally
                {
                  this.Cursor = MgaCursors.Default;
                }
              }
            }
            flag1 = true;
          }
        }
        catch (Exception ex1)
        {
          ProjectData.SetProjectError(ex1);
          Exception ex2 = ex1;
          if (ex2.Message.IndexOf("Only one insured location can be marked as the primary location") != -1)
          {
            int num = (int) MessageBox.Show("There is already a location designated as the primary location.\n\nKindly check if this primary location is hidden.", "Already A Location Marked Primary", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          }
          else
            ErrorHandler.HandleError(ex2);
          flag1 = false;
          ProjectData.ClearProjectError();
        }
      }
    }
label_26:
    return flag1;
  }

  private static bool HasAddressChanged(dsInsured.tblInsuredLocationsRow locationRow)
  {
    bool flag;
    if (locationRow != null)
    {
      dsInsured.tblInsuredLocationsDataTable table = (dsInsured.tblInsuredLocationsDataTable) locationRow.Table;
      flag = ExtensionsMethods.AnyColumnsChanged<string>((DataRow) locationRow, (IEqualityComparer<string>) StringComparer.InvariantCultureIgnoreCase, new DataColumn[6]
      {
        table.Address1Column,
        table.Address2Column,
        table.CityColumn,
        table.StateColumn,
        table.ZipCodeColumn,
        table.ISOCountryCodeColumn
      });
    }
    else
      flag = false;
    return flag;
  }

  public static bool CheckOfac(InsuredLocation insLoc, MGASystems.BusinessObjects.Insured ins)
  {
    OfacSystem.OfacResult ofacResult = (OfacSystem.OfacResult) null;
    bool flag;
    try
    {
      ofacResult = OfacSystem.Instance.CheckOfacResult((IOfacEntity) insLoc ?? (IOfacEntity) ins);
      if (ofacResult == null)
      {
        flag = false;
        goto label_10;
      }
      if ("-1".Equals(ofacResult.ReturnCode))
        frmInsureds.OnOfacError(ins, (Exception) null, ofacResult.OfacTypeID, ofacResult);
      if (MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("OFAC.Insured.ShowMessageOnHit"))
      {
        if (ofacResult.OfacHit)
        {
          int num = (int) frmInsureds.ShowMessage(OfacSystem.Instance.GetEntityStatus((IOfacEntity) insLoc).HitMessage, "Insured Sanctions Non-Compliant", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
      }
    }
    catch (Exception ex1)
    {
      ProjectData.SetProjectError(ex1);
      Exception ex2 = ex1;
      frmInsureds.OnOfacError(ins, ex2, ofacResult != null ? ofacResult.OfacTypeID : -1, ofacResult);
      ErrorHandler.HandleErrorOnThread((Control) MDIControls.Instance.MDIParent, ex2);
      ProjectData.ClearProjectError();
    }
    flag = true;
label_10:
    return flag;
  }

  protected void RefreshOfacData()
  {
    this._ofacStatus = OfacSystem.Instance.GetEntityStatus(this.InsuredGuid, new Guid?());
    dsInsured.tblInsuredsRow tblInsured = this.dsInsured.tblInsureds[0];
    tblInsured.SetOFACClearedNull();
    tblInsured.SetOfacClearedDateNull();
    ((UltraGridBase) this.ugOFAC).DataSource = (object) null;
    if (this._ofacStatus != null)
    {
      tblInsured.OFACCleared = this._ofacStatus.OFACCleared;
      tblInsured.SetField<DateTime?>("OfacClearedDate", this._ofacStatus.ClearDate);
    }
    this.ShowOfacXmlData();
    this.ClientOfacRefreshed(this._ofacStatus);
  }

  protected virtual void ClientOfacRefreshed(OfacSystem.OfacStatus status)
  {
  }

  protected static DialogResult ShowMessage(
    string message,
    string caption,
    MessageBoxButtons buttons,
    MessageBoxIcon icon)
  {
    DialogResult dialogResult;
    if (MDIControls.Instance.MDIParent.InvokeRequired)
      MDIControls.Instance.MDIParent.Invoke((Delegate) new frmInsureds.MessageHandler(frmInsureds.ShowMessage), (object) message, (object) caption, (object) buttons, (object) icon);
    else
      dialogResult = MessageBox.Show(message, caption, buttons, icon);
    return dialogResult;
  }

  public static string StripNodes(string str, string sTag, string eTag)
  {
    string str1 = string.Empty;
    if (StringExtensions.ContainsCaseInsensitive(str, sTag) && StringExtensions.ContainsCaseInsensitive(str, eTag))
    {
      int startIndex = str.IndexOf(sTag, StringComparison.OrdinalIgnoreCase) + sTag.Length;
      int num = str.IndexOf(eTag, startIndex, StringComparison.OrdinalIgnoreCase);
      str1 = str.Substring(startIndex, num - startIndex);
    }
    return str1;
  }

  public static void OnOfacEntityError(
    IOfacEntity entity,
    Exception ex,
    int ofacType,
    OfacSystem.OfacResult ofacResult = null)
  {
    try
    {
      if (ofacResult == null)
        return;
      string setting = MGASystems.Common.Settings.SystemSettings.GetSetting<string>("OFAC.Insured.Error.Procedure");
      if (string.IsNullOrWhiteSpace(setting))
        return;
      XElement xelement = new XElement((XName) "header", new object[3]
      {
        (object) new XElement((XName) "IMSError", (object) ex?.Message),
        (object) new XElement((XName) "ServiceError", (object) ofacResult.ErrorDescription),
        (object) new XElement((XName) "EntityGuid", (object) entity.EntityGuid)
      });
      DefaultDatabase.ExecuteNonQuery(setting, new object[4]
      {
        (object) "@EntityGuid",
        (object) entity.EntityGuid,
        (object) "@ErrorString",
        (object) xelement.ToString()
      });
    }
    catch (Exception ex1)
    {
      ProjectData.SetProjectError(ex1);
      Exception ex2 = ex1;
      ex2.Data.Add((object) "EntityGuid", (object) entity.EntityGuid);
      ErrorHandler.SilentHandleError(ex2);
      ProjectData.ClearProjectError();
    }
  }

  public static void OnOfacError(
    MGASystems.BusinessObjects.Insured insured,
    Exception ex,
    int ofacType,
    OfacSystem.OfacResult ofacResult = null)
  {
    frmInsureds.OnOfacEntityError((IOfacEntity) insured, ex, ofacType, ofacResult);
  }

  private void AssignTransaction(SqlDataAdapter da, SqlTransaction trans)
  {
    SqlDataAdapter sqlDataAdapter = da;
    sqlDataAdapter.SelectCommand.Transaction = trans;
    if (sqlDataAdapter.InsertCommand != null)
      sqlDataAdapter.InsertCommand.Transaction = trans;
    if (sqlDataAdapter.UpdateCommand != null)
      sqlDataAdapter.UpdateCommand.Transaction = trans;
    if (sqlDataAdapter.DeleteCommand != null)
      sqlDataAdapter.DeleteCommand.Transaction = trans;
  }

  private bool DoSaveWithTransaction()
  {
    bool flag;
    try
    {
      DefaultDatabase.ExecuteTransaction((EventHandler<ExecuteTransactionEventArgs>) ([SpecialName] (obj, etea) =>
      {
        SqlCommand[] sqlCommandArray1 = new SqlCommand[8]
        {
          this.daInsureds.SelectCommand,
          this.daInsureds.InsertCommand,
          this.daInsureds.DeleteCommand,
          this.daInsureds.UpdateCommand,
          this.daLocations.SelectCommand,
          this.daLocations.InsertCommand,
          this.daLocations.DeleteCommand,
          this.daLocations.UpdateCommand
        };
        SqlConnection connection = (SqlConnection) etea.Transaction.Connection;
        SqlCommand[] sqlCommandArray2 = sqlCommandArray1;
        int index1 = 0;
        while (index1 < sqlCommandArray2.Length)
        {
          SqlCommand sqlCommand = sqlCommandArray2[index1];
          if (sqlCommand != null)
            sqlCommand.Connection = connection;
          checked { ++index1; }
        }
        DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.daInsureds, (DataTable) this.dsInsured.tblInsureds);
        DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.daLocations, (DataTable) this.dsInsured.tblInsuredLocations);
        if (this._ofacStatus != null && this._ofacStatus.OFACCleared != (this.dsInsured.tblInsureds[0].Field<bool?>("OFACCleared") ?? this._ofacStatus.OFACCleared))
        {
          if (this._ofacStatus.OFACCleared)
            OfacSystem.Instance.ReinstateOfacHit(this.InsuredGuid, new Guid?());
          else
            OfacSystem.Instance.ClearOfacHit(this.InsuredGuid, new Guid?(), new Guid?(CurrentUser.Instance.UserGUID), new DateTime?(CurrentUser.ServerTime), "Cleared via Insured UI");
          this.RefreshOfacData();
        }
        SqlCommand[] sqlCommandArray3 = sqlCommandArray1;
        int index2 = 0;
        while (index2 < sqlCommandArray3.Length)
        {
          SqlCommand sqlCommand = sqlCommandArray3[index2];
          if (sqlCommand != null)
            sqlCommand.Connection = this.cnSQL;
          checked { ++index2; }
        }
        etea.Transaction.Commit();
      }));
      flag = true;
      goto label_11;
    }
    catch (DBConcurrencyException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      int num = (int) MessageBox.Show("Another user has modified this insured While you were working With it.\n\nPlease re-open this form And make your edits again.", "Data Modified", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      ProjectData.ClearProjectError();
    }
    catch (SqlException ex1)
    {
      ProjectData.SetProjectError((Exception) ex1);
      SqlException ex2 = ex1;
      if (ex2.Message.Contains("Duplicate SSN/FEIN"))
      {
        int num1 = (int) MessageBox.Show("This insured has Duplicate SSN/FEIN", "Duplicate SSN/FEIN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
      else if (ex2.Message.Contains("tblInsuredLocations_NoHideAll"))
      {
        int num2 = (int) MessageBox.Show("Cannot mark all locations As hidden.", "All Locations Hidden", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
      else if (ex2.Message.Contains("CK_tblInsureds_OnlyOneTaxID"))
      {
        int num3 = (int) MessageBox.Show("Insured has both FEIN and SSN assigned.", "Cannot Save - Both SSN and FEIN Assigned", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
      else
        ErrorHandler.HandleError((Exception) ex2);
      ProjectData.ClearProjectError();
    }
    flag = false;
label_11:
    return flag;
  }

  private void OfacCleared_CheckChanged(object sender, EventArgs e)
  {
    if (!((UltraToggleEditorBase) this.chkOFACCleared).Checked)
      return;
    this.dtOFACClearedDate.Value = (object) DateTime.Now;
  }

  private void lnkAddSubmissionGroup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    if (!this._canAddSubmissions)
    {
      int num1 = (int) MessageBox.Show("You Do Not the required permission To add submissions.", "Insufficient Security", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else if (this.dsInsured.tblInsureds[0].RowState == DataRowState.Added)
    {
      int num2 = (int) MessageBox.Show("Please save this insured before creating a submission.", "Save Required", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else
      Messaging.SendBroadcastMessage(BroadcastMessages.BeginNewSubmission, (object) this._insuredGuid);
  }

  private void dgInvoices_AfterRowInsert(object sender, RowEventArgs e)
  {
    if ((double) e.Row.Cells["AmtBilled"].Value >= 0.0)
      return;
    e.Row.Cells["AmtBilled"].Appearance.ForeColor = Color.Red;
  }

  private void dbSave_ClickingEdit(object sender, CancelEventArgs e)
  {
    ((Control) this.dtDOB).Enabled = this._CanEditDateOfBirth;
    if (this._CanEditInsured)
      return;
    int num = (int) MessageBox.Show("You Do Not have the ability To edit the Insured's Information.", "Insufficient Security", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    e.Cancel = true;
  }

  private void dbSave_ClickingDelete(object sender, CancelEventArgs e)
  {
    try
    {
      if (!new MGASystems.IMS.InsuredsProducersCompanies.BusinessObjects.Insured(this._insuredGuid).Delete())
        return;
      List<Guid> guidList = new List<Guid>();
      try
      {
        foreach (dsInsured.tblInsuredLocationsRow tblInsuredLocation in (TypedTableBase<dsInsured.tblInsuredLocationsRow>) this.dsInsured.tblInsuredLocations)
          guidList.Add(tblInsuredLocation.InsuredLocationGuid);
      }
      finally
      {
        IEnumerator<dsInsured.tblInsuredLocationsRow> enumerator;
        enumerator?.Dispose();
      }
      Form[] mdiChildren = MDIControls.Instance.MDIParent.MdiChildren;
      int index = 0;
      while (index < mdiChildren.Length)
      {
        Form form = mdiChildren[index];
        if (form is frmSelection)
        {
          if (((frmSelection) form).SelectionType == frmSelection.SelectionTypes.Insured)
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
      CurrentUser.Instance.LogAction($"Deleted Insured: {this.InsuredName}", this._insuredGuid);
      this.Close();
    }
    catch (SubmissionsExistException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      int num = (int) MessageBox.Show("This insured cannot be deleted because they have existing submissions.", "Cannot Delete", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      ProjectData.ClearProjectError();
    }
  }

  protected virtual void CreateNewInsured()
  {
    this.lnkAddSubmissionGroup.Enabled = false;
    this.dsInsured.Invoices.Clear();
    this.dsInsured.tblInsuredContacts.Clear();
    this.dsInsured.tblInsuredLocations.Clear();
    this.dsInsured.tblInsureds.Clear();
    ((TextEditorControlBase) this.txtBusiness).Text = string.Empty;
    ((TextEditorControlBase) this.txtFirst).Text = string.Empty;
    this.cboSalutations.Text = string.Empty;
    ((TextEditorControlBase) this.txtMiddle).Text = string.Empty;
    ((TextEditorControlBase) this.txtLast).Text = string.Empty;
    ((UltraToggleEditorBase) this.chkOFACCleared).Checked = false;
    this.dtOFACClearedDate.Value = (object) null;
    this._insuredGuid = Guid.NewGuid();
    dsInsured.tblInsuredsRow row = this.dsInsured.tblInsureds.NewtblInsuredsRow();
    row.StatusID = 1;
    row.InsuredGuid = this._insuredGuid;
    this.dsInsured.tblInsureds.AddtblInsuredsRow(row);
    this._producerStatusChanged = false;
    ((Control) this.txtStatusChangeComments).Enabled = false;
    this.NewLocation();
    this.UpdateLocationsNavDisplay();
  }

  private void dbSave_ClickingNew(object sender, CancelEventArgs e)
  {
    if (!this._canAddInsured)
    {
      int num = (int) MessageBox.Show("You do not have the required security to add new insureds.", "Insufficient Security", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      e.Cancel = true;
    }
    else
    {
      this.CreateNewInsured();
      ((Control) this.dtDOB).Enabled = true;
    }
  }

  private void dbSave_ClickingCancel(object sender, CancelEventArgs e)
  {
    if (this.dsInsured.tblInsureds[0].RowState == DataRowState.Added)
    {
      if (MessageBox.Show("Are you sure you want to cancel this new insured?", "Cancel New Insured?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        this.Close();
      else
        e.Cancel = true;
    }
    else
    {
      this.dsInsured.RejectChanges();
      this.LocationClickingCancel();
    }
  }

  protected virtual void LocationClickingCancel()
  {
  }

  private void dbSave_UIStateChanged(object sender, EventArgs e)
  {
    this.SetFormControlsEnabledState();
  }

  private void SetFormControlsEnabledState()
  {
    try
    {
      foreach (Control control in this.Controls)
      {
        if (control.Tag == null || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(control.Tag.ToString(), "keepEnabled", false) != 0)
          control.Enabled = this.dbSave.UIState == UIState.Editing;
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    foreach (UltraTab tab in ((UltraTabControlBase) this.tabControl).Tabs)
    {
      try
      {
        foreach (Control control in ((Control) tab.TabPage).Controls)
        {
          if (control.Tag == null || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(control.Tag.ToString(), "keepEnabled", false) != 0)
            control.Enabled = this.dbSave.UIState == UIState.Editing;
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
    if (this.dbSave.UIState != UIState.Editing && this.dsInsured.tblInsureds.Count > 0)
      this.lnkAddSubmissionGroup.Enabled = true;
    ((Control) this.chkOFACCleared).Enabled = this._canEditOFACCleared && this._ofacStatus != null && this._ofacStatus.IsHit && this.dbSave.UIState == UIState.Editing;
    ((Control) this.btnClearOFAC).Enabled = this._canClearOFACAndUpdateHistoricalData && this._ofacStatus != null && this.dbSave.UIState == UIState.Editing;
  }

  private void dbSave_ClickingSave(object sender, CancelEventArgs e)
  {
    if (this.SaveChanges())
      return;
    e.Cancel = true;
  }

  private void dgInvoices_Paint(object sender, PaintEventArgs e)
  {
    if (this.DesignMode)
      return;
    ((Control) this.dgInvoices).Paint -= new PaintEventHandler(this.dgInvoices_Paint);
    Cursor.Current = MgaCursors.WaitCursor;
    try
    {
      HyperlinkEditor hyperlinkEditor = new HyperlinkEditor();
      ((UltraGridBase) this.dgInvoices).DisplayLayout.Bands[0].Columns["View"].Editor = (EmbeddableEditorBase) hyperlinkEditor;
      hyperlinkEditor.HyperLinkOpening += new CancelEventHandler(this.hlk_HyperLinkOpening);
      DefaultDatabase.LoadDataSet((DataSet) this.dsInsured, new string[1]
      {
        "Invoices"
      }, "dbo.[spInsuredInvoices]", new object[2]
      {
        (object) "@InsuredGuid",
        (object) this._insuredGuid
      });
      try
      {
        foreach (dsInsured.InvoicesRow invoice in (TypedTableBase<dsInsured.InvoicesRow>) this.dsInsured.Invoices)
          invoice.View = "View";
      }
      finally
      {
        IEnumerator<dsInsured.InvoicesRow> enumerator;
        enumerator?.Dispose();
      }
      this.dsInsured.Invoices.AcceptChanges();
      if (this.dsInsured.Invoices.Rows.Count <= 0)
        return;
      UltraGridBand band = ((UltraGridBase) this.dgInvoices).DisplayLayout.Bands[0];
      band.Summaries.Clear();
      band.Summaries.Add("AmountSum", (SummaryType) 1, band.Columns["AmtBilled"], (SummaryPosition) 3);
      band.Summaries[0].DisplayFormat = "{0:c}";
      band.Override.SummaryValueAppearance.TextHAlign = (HAlign) 3;
      band.Override.SummaryValueAppearance.BackColor = SystemColors.ControlLight;
      band.Override.SummaryFooterCaptionVisible = (DefaultableBoolean) 2;
      band.Override.SummaryFooterAppearance.BackColor = SystemColors.ControlLight;
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ErrorHandler.HandleError(ex);
      ProjectData.ClearProjectError();
    }
    finally
    {
      Cursor.Current = MgaCursors.WaitCursor;
    }
  }

  private void hlk_HyperLinkOpening(object sender, CancelEventArgs e)
  {
    try
    {
      int invoiceNumber = (int) ((UltraGridBase) this.dgInvoices).ActiveRow.Cells["InvoiceNum"].Value;
      MDIControls.Instance.StatusBarText = $"Showing invoice #{invoiceNumber.ToString()}...";
      ArrayList @params = new ArrayList();
      InvoiceItem[] invoices = new InvoiceItem[2]
      {
        new InvoiceItem(invoiceNumber, @params),
        null
      };
      @params.AddRange((ICollection) new object[2]
      {
        (object) "MGACopy",
        (object) true
      });
      invoices[1] = new InvoiceItem(invoiceNumber, @params);
      ReportFactory.Instance.ShowInvoices(invoices);
      MDIControls.Instance.StatusBarText = string.Empty;
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ErrorHandler.HandleError(ex);
      ProjectData.ClearProjectError();
    }
    e.Cancel = true;
  }

  protected virtual void UltraToolbarsManager1_ToolClick(object sender, ToolClickEventArgs e)
  {
    string key = ((ToolEventArgs) e).Tool.Key;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Combine Insureds", false) != 0)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Current Loss Information", false) != 0)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Assign Client Offices", false) != 0)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "AdminRerunOfac", false) != 0)
            return;
          if (this.dsInsured.tblInsureds[0].RowState == DataRowState.Added)
            return;
          try
          {
            MDIControls.Instance.StatusBarText = "Running OFAC on insured ...";
            this.Cursor = MgaCursors.WaitCursor;
            dsInsured.tblInsuredLocationsDataTable insuredLocations = this.dsInsured.tblInsuredLocations;
            System.Func<dsInsured.tblInsuredLocationsRow, bool> predicate;
            // ISSUE: reference to a compiler-generated field
            if (frmInsureds._Closure\u0024__.\u0024I707\u002D0 != null)
            {
              // ISSUE: reference to a compiler-generated field
              predicate = frmInsureds._Closure\u0024__.\u0024I707\u002D0;
            }
            else
            {
              // ISSUE: reference to a compiler-generated field
              frmInsureds._Closure\u0024__.\u0024I707\u002D0 = predicate = (System.Func<dsInsured.tblInsuredLocationsRow, bool>) ([SpecialName] (loc) => loc.LocationTypeID == 1 && !loc.Hidden);
            }
            InsuredLocation objectAs = ObjectFactory.Instance.CreateObjectAs<InsuredLocation>((object) insuredLocations.FirstOrDefault<dsInsured.tblInsuredLocationsRow>(predicate)?.InsuredLocationGuid.Value);
            MGASystems.BusinessObjects.Insured insured = objectAs.Insured;
            // ISSUE: reference to a compiler-generated method
            Task.Run((Action) ([SpecialName] () => frmInsureds.CheckOfac(objectAs, insured))).ContinueWith((Action<Task>) ([SpecialName] (a0) => this._Lambda\u0024__707\u002D2()), TaskScheduler.FromCurrentSynchronizationContext());
          }
          finally
          {
            this.Cursor = MgaCursors.Default;
          }
        }
        else
          MgaMdiChild.Create<AssignClientOfficeView>(new object[3]
          {
            (object) InsuredClientOffice.GetInsuredClientOffices(this.CurrentLocationRow.InsuredGuid),
            (object) this.CurrentLocationRow.InsuredGuid,
            (object) this.InsuredName
          }).Form.Show();
      }
      else
        FormSettings.ShowForm(typeof (frmCurrentLossInformation_Insureds), (object) this.CurrentLocationRow.InsuredGuid);
    }
    else if (this.dsInsured.tblInsureds.Rows[0].RowState == DataRowState.Added)
    {
      int num = (int) MessageBox.Show("This insured cannot be combined because it is not saved.", "Combine Error", MessageBoxButtons.OK);
    }
    else
      FormSettings.ShowForm(typeof (FormCombineInsureds), (object) this.CurrentLocationRow.InsuredGuid);
  }

  public virtual void ClientRerunOfac()
  {
  }

  protected virtual void cboInsStatus_ValueChanged(object sender, EventArgs e)
  {
    if (Convert.ToInt32(RuntimeHelpers.GetObjectValue(this.cboInsStatus.Value)) == this._origInsuredStatuID || this._origInsuredStatuID == int.MinValue)
      return;
    this._producerStatusChanged = true;
    ((Control) this.txtStatusChangeComments).Enabled = true;
  }

  protected virtual void cboInsuredType_ValueChanged(object sender, EventArgs e)
  {
    if (((UltraDropDownBase) this.cboInsuredType).SelectedRow == null)
      return;
    this.cmbGender.Value = (object) 1;
    if (this.IsIndividual)
    {
      ((TextEditorControlBase) this.txtBusiness).Text = string.Empty;
      if (!this._UnlockIndividualType)
        this.txtFEIN.Value = (object) string.Empty;
    }
    else
    {
      ((TextEditorControlBase) this.txtFirst).Text = string.Empty;
      ((TextEditorControlBase) this.txtMiddle).Text = string.Empty;
      ((TextEditorControlBase) this.txtLast).Text = string.Empty;
      this.txtSSN.Text = string.Empty;
      this.dtDOB.Value = (object) DBNull.Value;
    }
    ((Control) this.txtBusiness).Enabled = !this.IsIndividual;
    if (!this._UnlockIndividualType)
      ((Control) this.txtFEIN).Enabled = !this.IsIndividual;
    ((Control) this.txtSSN).Enabled = this.IsIndividual;
    ((Control) this.cmbGender).Enabled = this.IsIndividual;
    ((Control) this.cboSalutations).Enabled = this.IsIndividual;
    ((Control) this.txtFirst).Enabled = this.IsIndividual;
    ((Control) this.txtMiddle).Enabled = this.IsIndividual;
    ((Control) this.txtLast).Enabled = this.IsIndividual;
    ((Control) this.dtDOB).Enabled = this.IsIndividual;
  }

  private void UpdateLocationsNavDisplay()
  {
    ((Control) this.btnFirst).Enabled = this.bmbLocation.Position > 0;
    ((Control) this.btnPrev).Enabled = this.bmbLocation.Position > 0;
    ((Control) this.btnLast).Enabled = this.bmbLocation.Position < this.bmbLocation.Count - 1;
    ((Control) this.btnNext).Enabled = this.bmbLocation.Position < this.bmbLocation.Count - 1;
    Information.Err().Clear();
    this.ShowRichTextBoxesData();
    if (this.bmbLocation.Position != -1 && this.CurrentLocationRow != null)
    {
      if (!this.CurrentLocationRow.IsZipCodeNull())
      {
        try
        {
          this.ZipCodeResolver1.ZipCode = this.CurrentLocationRow.ZipCode;
        }
        catch (ArgumentException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          this.ZipCodeResolver1.ZipCode = this.CurrentLocationRow.ZipCode;
          ProjectData.ClearProjectError();
        }
      }
    }
    UltraLabel lblRecords = this.lblRecords;
    int num = this.bmbLocation.Position + 1;
    string str1 = num.ToString();
    num = this.bmbLocation.Count;
    string str2 = num.ToString();
    string str3 = $"{str1} of {str2}";
    ((ControlBase) lblRecords).Text = str3;
    ((Control) this.btnDelete).Enabled = this.bmbLocation.Count > 1;
  }

  private void PopulateDataSet()
  {
    try
    {
      MDIControls.Instance.StatusBar.Text = "Filling insured information...";
      DataTableMappingCollection tableMappings = this.daLookups.TableMappings;
      tableMappings.Clear();
      tableMappings.Add("Table", this.dsInsured.lstDeliveryMethod.TableName);
      tableMappings.Add("Table1", this.dsInsured.lstBusinessTypes.TableName);
      tableMappings.Add("Table2", this.dsInsured.lstLocationType.TableName);
      tableMappings.Add("Table3", this.dsInsured.lstStatus.TableName);
      tableMappings.Add("Table4", this.dsInsured.lstSalutations.TableName);
      tableMappings.Add("Table5", this.dsInsured.lstClaims_Gender.TableName);
      tableMappings.Add("Table6", this.dsInsured.lstInsuredLocationSource.TableName);
      tableMappings.Add("Table7", this.dsInsured.tblUsers.TableName);
      tableMappings.Add("Table8", this.dsInsured.lstProductionPotential.TableName);
      tableMappings.Add("Table9", this.dsInsured.lstInsuredRankings.TableName);
      DefaultDatabase.DataAdapterFill((DbDataAdapter) this.daLookups, (DataSet) this.dsInsured);
      this.daLookups.Dispose();
      this.daLookups = (SqlDataAdapter) null;
      this.daInsureds.SelectCommand.Parameters["@InsuredGuid"].Value = (object) this._insuredGuid;
      try
      {
        DefaultDatabase.DataAdapterFill((DbDataAdapter) this.daInsureds, (DataTable) this.dsInsured.tblInsureds);
      }
      catch (ConstraintException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        ErrorHandler.ShowDataSetErrors((DataSet) this.dsInsured, ex);
        ProjectData.ClearProjectError();
      }
      if (this.dsInsured.tblInsureds.Rows.Count > 0)
      {
        this._ofacStatus = OfacSystem.Instance.GetEntityStatus(this.InsuredGuid, new Guid?());
        if (this._ofacStatus != null && this._ofacStatus.IsHit)
        {
          this.dsInsured.tblInsureds[0].OFACCleared = this._ofacStatus.OFACCleared;
          this.dsInsured.tblInsureds[0].SetField<DateTime?>("OfacClearedDate", this._ofacStatus.ClearDate);
        }
        else
          this.dsInsured.tblInsureds[0].OFACCleared = true;
        this.dsInsured.tblInsureds.AcceptChanges();
        this.Text = $"Insured Information - {this.InsuredEntity.Name}";
        this._origInsuredStatuID = (int) this.InsuredEntity.Status;
        if (!this.dsInsured.tblInsureds[0].IsStatusChangeReasonCommentNull())
          this._origInsuredStatusComment = this.dsInsured.tblInsureds[0].StatusChangeReasonComment;
      }
      else
        this.Text = "New Insured";
      this.daLocations.SelectCommand.Parameters["@InsuredGuid"].Value = (object) this._insuredGuid;
      DefaultDatabase.DataAdapterFill((DbDataAdapter) this.daLocations, (DataTable) this.dsInsured.tblInsuredLocations);
      if (this.dsInsured.tblInsuredLocations.Rows.Count > 0)
      {
        this.daContacts.SelectCommand.Parameters["@InsuredLocationGuid"].Value = (object) this._moveToInsuredLocationGuid;
        DefaultDatabase.DataAdapterFill((DbDataAdapter) this.daContacts, (DataTable) this.dsInsured.tblInsuredContacts);
        Database.MoveTo((object) this._moveToInsuredLocationGuid, "InsuredLocationGuid", (DataTable) this.dsInsured.tblInsuredLocations, this.bmbLocation);
      }
      if (this.dsInsured.tblInsuredLocations == null)
        return;
      UltraLabel lblRecords = this.lblRecords;
      int num = this.bmbLocation.Position + 1;
      string str1 = num.ToString();
      num = this.bmbLocation.Count;
      string str2 = num.ToString();
      string str3 = $"{str1} of {str2}";
      ((ControlBase) lblRecords).Text = str3;
    }
    finally
    {
      MDIControls.Instance.StatusBar.Text = string.Empty;
    }
  }

  private void Navigation(object sender, EventArgs e)
  {
    this.bmbLocation.EndCurrentEdit();
    this.dsInsured.AcceptChanges();
    if (this.dsInsured.HasChanges())
    {
      switch (MessageBox.Show("You have unsaved changes on this record.  Would you like to save?", "Save Changes", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation))
      {
        case DialogResult.Cancel:
          return;
        case DialogResult.Yes:
          if (!this.SaveChanges())
          {
            int num = (int) MessageBox.Show("Please complete current location.", "Incomplete data", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            return;
          }
          break;
        default:
          this.dsInsured.tblInsuredLocations.RejectChanges();
          break;
      }
    }
    if (sender == this.btnNext)
    {
      BindingManagerBase bmbLocation;
      int num = (bmbLocation = this.bmbLocation).Position + 1;
      bmbLocation.Position = num;
    }
    else if (sender == this.btnFirst)
      this.bmbLocation.Position = 0;
    else if (sender == this.btnLast)
      this.bmbLocation.Position = this.bmbLocation.Count - 1;
    else if (sender == this.btnPrev)
    {
      BindingManagerBase bmbLocation;
      int num = (bmbLocation = this.bmbLocation).Position - 1;
      bmbLocation.Position = num;
    }
    this.LoadContacts();
    this.LoadClientLocationData();
    this.bmbLocation.EndCurrentEdit();
    this.dsInsured.tblInsuredLocations.AcceptChanges();
    // ISSUE: reference to a compiler-generated field
    ISupportDocumentSystem.EntityInfoChangedEventHandler infoChangedEvent = this.EntityInfoChangedEvent;
    if (infoChangedEvent == null)
      return;
    infoChangedEvent((object) this, EventArgs.Empty);
  }

  private void btnNewInsuredLocation_Click(object sender, EventArgs e)
  {
    if (!this._canAddInsured)
    {
      int num1 = (int) MessageBox.Show("You do not have the required security to add new insured location.", "Insufficient Security", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else if (!((Control) this.ZipCodeResolver1).Enabled)
      this.NewLocation();
    else if (this.ValidateForm())
    {
      ((Control) this.btnNewInsuredLocation).Enabled = false;
      this.SaveChanges();
      this.NewLocation();
      ((Control) this.btnNewInsuredLocation).Enabled = true;
    }
    else
    {
      int num2 = (int) MessageBox.Show("Please complete current location before adding additional locations.", "Incomplete data", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
  }

  private void btnContacts_Click(object sender, EventArgs e)
  {
    if (this.lstContacts.SelectedIndex >= 0)
    {
      FormSettings.ShowForm(typeof (frmInsuredContacts), (object) this.CurrentLocationRow.InsuredLocationGuid, (object) (Guid) this.lstContacts.SelectedValue);
    }
    else
    {
      int num = (int) MessageBox.Show("Please select a contact from the list.", "Select Contact", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
  }

  private void bmbLocation_PositionChanged(object sender, EventArgs e)
  {
    this.UpdateLocationsNavDisplay();
  }

  private int NumberPrimaryLocations()
  {
    int num = 0;
    try
    {
      foreach (dsInsured.tblInsuredLocationsRow tblInsuredLocation in (TypedTableBase<dsInsured.tblInsuredLocationsRow>) this.dsInsured.tblInsuredLocations)
      {
        if (tblInsuredLocation.LocationTypeID == 1 && !tblInsuredLocation.Hidden)
          ++num;
      }
    }
    finally
    {
      IEnumerator<dsInsured.tblInsuredLocationsRow> enumerator;
      enumerator?.Dispose();
    }
    return num;
  }

  private void btnNewContact_Click(object sender, EventArgs e)
  {
    if (this.dsInsured.tblInsuredLocations[this.bmbLocation.Position].RowState == DataRowState.Added)
    {
      int num = (int) MessageBox.Show("Please save this insured before adding contacts.", "Save Required", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else
    {
      Cursor.Current = MgaCursors.WaitCursor;
      FormSettings.ShowForm(typeof (frmInsuredContacts), (object) this.CurrentLocationRow.InsuredLocationGuid);
      Cursor.Current = MgaCursors.Default;
    }
  }

  private void btnDelete_Click(object sender, EventArgs e)
  {
    int count = this.dsInsured.tblInsuredLocations.Count;
    bool flag = ((DataRowView) this.bmbLocation.Current).Row.RowState == DataRowState.Added;
    switch (count)
    {
      case 0:
        break;
      case 1:
        if (flag)
        {
          this.DiscardAddedRow();
          break;
        }
        if (MessageBox.Show("The current location is the only location on the insured and cannot be deleted. \n\nWould you like to mark the location as inactive?", "Mark Location Inactive?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
          break;
        DefaultDatabase.ExecuteNonQuery(CommandType.Text, "UPDATE tblInsuredLocations SET Inactive = 1 WHERE InsuredLocationGUID = @IL", new object[2]
        {
          (object) "@IL",
          (object) this.dsInsured.tblInsuredLocations[this.bmbLocation.Position].InsuredLocationGuid
        });
        this.RefreshDataset();
        break;
      default:
        if (MessageBox.Show("Are you sure you want to delete this location?", "Delete Location?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
        {
          if (flag)
          {
            this.DiscardAddedRow();
          }
          else
          {
            frmInsureds frmInsureds = this;
            Guid insuredLocationGuid = this.dsInsured.tblInsuredLocations[this.bmbLocation.Position].InsuredLocationGuid;
            string name = this.dsInsured.tblInsuredLocations[this.bmbLocation.Position].Name;
            object obj1 = (object) null;
            if (this.dsInsured.tblInsuredLocations[this.bmbLocation.Position].LocationTypeID == 1 && count > 1)
            {
              FormChooseInsuredLocation chooseInsuredLocation = new FormChooseInsuredLocation(this.dsInsured.tblInsuredLocations, this.dsInsured.tblInsureds, this.dsInsured.tblInsuredLocations[this.bmbLocation.Position].InsuredLocationGuid);
              Guid InsuredLocationGuid;
              try
              {
                int num = (int) chooseInsuredLocation.ShowDialog();
                InsuredLocationGuid = chooseInsuredLocation.LocationChosen();
              }
              finally
              {
                chooseInsuredLocation.Dispose();
              }
              this.dsInsured.tblInsuredLocations.FindByInsuredLocationGuid(InsuredLocationGuid).LocationTypeID = 1;
              this.dsInsured.tblInsuredLocations[this.bmbLocation.Position].LocationTypeID = 4;
              obj1 = (object) InsuredLocationGuid.ToString();
            }
            this.dsInsured.tblInsuredLocations[this.bmbLocation.Position].Hidden = true;
            DefaultDatabase.ExecuteTransaction((EventHandler<ExecuteTransactionEventArgs>) ([SpecialName] (obj, args) =>
            {
              frmInsureds.UpdateLocationsTransaction(insuredLocationGuid, RuntimeHelpers.GetObjectValue(obj1));
              args.Transaction.Commit();
            }));
            CurrentUser.Instance.LogAction($"Deleted Insured Location: {name} for Insured:  {this.InsuredName}", this._insuredGuid);
            this.RefreshDataset();
            this.dbSave.UIState = this.dsInsured.tblInsuredLocations.Count <= 0 ? UIState.NoRecordsNotEditing : UIState.HasRecordsNotEditing;
          }
        }
        this.UpdateLocationsNavDisplay();
        break;
    }
  }

  private object UpdateLocationsTransaction(Guid currentLocationGuid, object otherLocation)
  {
    DefaultDatabase.ExecuteNonQuery("dbo.UpdateDeleteLocations", new object[4]
    {
      (object) "@currentLocation",
      (object) currentLocationGuid,
      (object) "@otherLocation",
      otherLocation
    });
    return (object) null;
  }

  protected virtual void DiscardAddedRow()
  {
    this.bmbLocation.EndCurrentEdit();
    this.dsInsured.tblInsuredLocations.RejectChanges();
    this.LoadContacts();
    this.bmbLocation.EndCurrentEdit();
    this.dsInsured.tblInsuredLocations.AcceptChanges();
  }

  protected virtual void RefreshDataset()
  {
    this.Cursor = MgaCursors.WaitCursor;
    try
    {
      this.dsInsured.EnforceConstraints = false;
      this.dsInsured.tblInsuredLocations.Clear();
      this.daLocations.SelectCommand.Parameters["@InsuredGuid"].Value = (object) this._insuredGuid;
      DefaultDatabase.DataAdapterFill((DbDataAdapter) this.daLocations, (DataTable) this.dsInsured.tblInsuredLocations);
      this.LoadContacts();
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
      this.dsInsured.EnforceConstraints = true;
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
      this.dsInsured.tblInsuredContacts.DefaultView.RowFilter = "StatusID=2";
    else if (this.mnuActive.Checked)
      this.dsInsured.tblInsuredContacts.DefaultView.RowFilter = "StatusID=1";
    else
      this.dsInsured.tblInsuredContacts.DefaultView.RowFilter = string.Empty;
  }

  private void lnkUseInsured_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    ((TextEditorControlBase) this.txtPolicyName).Text = this.InsuredName;
    this.dsInsured.tblInsureds[0].PolicyName = this.InsuredName;
  }

  private void lnkShowMap_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    if (this.CurrentLocationRow == null)
      return;
    this.ZipCodeResolver1.ShowInGoogleMaps();
  }

  protected virtual void LoadClientLocationData()
  {
  }

  protected virtual void NewLocation()
  {
    dsInsured.tblInsuredLocationsRow row = this.dsInsured.tblInsuredLocations.NewtblInsuredLocationsRow();
    row.LocationTypeID = this.dsInsured.tblInsuredLocations.Rows.Count != 0 ? 3 : 1;
    row.InsuredLocationGuid = Guid.NewGuid();
    row.InsuredGuid = this._insuredGuid;
    row.DateAdded = DateAndTime.Now;
    row.AddedBy = CurrentUser.Instance.UserGUID;
    row.Name_LastFirst = $"{CurrentUser.Instance.LastName}, {CurrentUser.Instance.FirstName}";
    row.DeliveryMethodID = 1;
    row.Name = "Mailing Address";
    string str = "USA";
    if (((IEnumerable<string>) ConfigurationManager.AppSettings.AllKeys).Contains<string>("ApplicationCultureName"))
    {
      try
      {
        str = new RegionInfo(new CultureInfo(ConfigurationManager.AppSettings["ApplicationCultureName"]).Name).ThreeLetterISORegionName;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ErrorHandler.SilentHandleError(new Exception("Failed loading IMS.exe.config:ApplicationCultureName", ex));
        ProjectData.ClearProjectError();
      }
    }
    this.MgaInternationalPhone.CountryCode = str;
    this.MgaInternationaFax.CountryCode = str;
    this.MgaInternationalMobile.CountryCode = str;
    this.MgaInternationalPhone.Value = (object) "";
    this.MgaInternationaFax.Value = (object) "";
    this.MgaInternationalMobile.Value = (object) "";
    row.CountryCodeforPhone = str;
    row.CountryCodeforFax = str;
    row.CountryCodeforMobile = str;
    row.Phone = "";
    row.Fax = "";
    row.MobileNumber = "";
    row.ZipCode = "";
    row.ISOCountryCode = str;
    row.City = "";
    row.County = "";
    row.State = "";
    row.SetZipPlusNull();
    this.dsInsured.tblInsuredLocations.AddtblInsuredLocationsRow(row);
    this.bmbLocation.EndCurrentEdit();
    this.bmbLocation.Position = this.bmbLocation.Count - 1;
    this.dsInsured.tblInsuredContacts.Clear();
    ((Control) this.btnDelete).Enabled = true;
    ((Control) this.btnNewContact).Enabled = false;
    ((Control) this.btnContacts).Enabled = false;
  }

  protected virtual bool ValidateForm()
  {
    ((TextEditorControlBase) this.txtPolicyName).Text = ((TextEditorControlBase) this.txtPolicyName).Text.Trim();
    bool flag = true;
    if (!this.IsIndividual && ((TextEditorControlBase) this.txtBusiness).Text.Length == 0)
    {
      this.ErrProvider.SetError((Control) this.txtBusiness, "Must enter insured's name");
      flag = false;
    }
    else
      this.ErrProvider.SetError((Control) this.txtBusiness, string.Empty);
    if (this.IsIndividual && ((TextEditorControlBase) this.txtLast).Text.Length == 0)
    {
      this.ErrProvider.SetError((Control) this.txtLast, "Must enter insured's name");
      flag = false;
    }
    else
      this.ErrProvider.SetError((Control) this.txtLast, string.Empty);
    if (((TextEditorControlBase) this.txtPolicyName).Text.Length == 0)
    {
      this.ErrProvider.SetError((Control) this.txtPolicyName, "Please enter the name of this insured as it appears on the policy.");
      flag = false;
    }
    else
      this.ErrProvider.SetError((Control) this.txtPolicyName, string.Empty);
    if (this.cboInsuredType.Text.Length == 0 && ((Control) this.cboInsuredType).Visible)
    {
      this.ErrProvider.SetError((Control) this.cboInsuredType, "Must enter insured's type.");
      flag = false;
    }
    else
      this.ErrProvider.SetError((Control) this.cboInsuredType, string.Empty);
    if (this.cboInsStatus.Text.Length == 0)
    {
      this.ErrProvider.SetError((Control) this.cboInsStatus, "Must enter status");
      flag = false;
    }
    else
      this.ErrProvider.SetError((Control) this.cboInsStatus, string.Empty);
    if (this._producerStatusChanged & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((TextEditorControlBase) this.txtStatusChangeComments).Text, string.Empty, false) == 0 | this._producerStatusChanged & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((TextEditorControlBase) this.txtStatusChangeComments).Text, this._origInsuredStatusComment, false) == 0)
    {
      this.ErrProvider.SetError((Control) this.txtStatusChangeComments, "Must enter an updated comment on why the Insured status was changed");
      flag = false;
    }
    else
      this.ErrProvider.SetError((Control) this.cboInsStatus, string.Empty);
    if (((TextEditorControlBase) this.txtLocation).Text.Length == 0)
    {
      this.ErrProvider.SetError((Control) this.txtLocation, "Must enter location");
      flag = false;
    }
    else
      this.ErrProvider.SetError((Control) this.txtLocation, string.Empty);
    if (this.cbOfficeType.Text.Length == 0)
    {
      this.ErrProvider.SetError((Control) this.cbOfficeType, "Must enter office type");
      flag = false;
    }
    else
      this.ErrProvider.SetError((Control) this.cbOfficeType, string.Empty);
    if (!this.ZipCodeResolver1.ValidateFields())
      flag = false;
    if (this.cboDeliveryMethod.Text.Length == 0)
    {
      this.ErrProvider.SetError((Control) this.cboDeliveryMethod, "Please enter a delivery method.");
      flag = false;
    }
    else if (Conversions.ToInteger(this.cboDeliveryMethod.Value) == 3 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((TextEditorControlBase) this.txtEmail).Text, string.Empty, false) == 0)
    {
      this.ErrProvider.SetError((Control) this.txtEmail, "Email must be provided when selecting email delivery type.");
      this.ErrProvider.SetError((Control) this.MgaInternationaFax, string.Empty);
      this.ErrProvider.SetError((Control) this.cboDeliveryMethod, string.Empty);
      flag = false;
    }
    else if (Conversions.ToInteger(this.cboDeliveryMethod.Value) == 2 && this.MgaInternationaFax.Value == DBNull.Value | this.MgaInternationaFax.Value == (object) string.Empty)
    {
      this.ErrProvider.SetError((Control) this.MgaInternationaFax, "Fax number be provided when selecting fax delivery type.");
      this.ErrProvider.SetError((Control) this.txtEmail, string.Empty);
      this.ErrProvider.SetError((Control) this.cboDeliveryMethod, string.Empty);
      flag = false;
    }
    else
    {
      this.ErrProvider.SetError((Control) this.MgaInternationaFax, string.Empty);
      this.ErrProvider.SetError((Control) this.txtEmail, string.Empty);
      this.ErrProvider.SetError((Control) this.cboDeliveryMethod, string.Empty);
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((TextEditorControlBase) this.txtEmail).Text, string.Empty, false) != 0 && !Parsing.IsValidEmailAddress(((TextEditorControlBase) this.txtEmail).Text))
    {
      this.ErrProvider.SetError((Control) this.txtEmail, "Please enter a valid email address.");
      flag = false;
    }
    int num1 = this.NumberPrimaryLocations();
    if (this.EnforcePrimaryInsuredLocation() && num1 == 0 && this.dsInsured.tblInsuredLocations.Count > 0)
    {
      this.ErrProvider.SetError((Control) this.cbOfficeType, "Primary location required");
      flag = false;
    }
    else if (num1 > 1)
    {
      int num2 = (int) MessageBox.Show("Only one location can be marked as the primary location.", "Primary Location Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      flag = false;
    }
    else
      this.ErrProvider.SetError((Control) this.cbOfficeType, string.Empty);
    return flag;
  }

  protected virtual void FormLoadComplete()
  {
  }

  protected void AddPolicyMenuItem(
    string key,
    string caption,
    string subMenu,
    string tagString,
    Bitmap imageResource)
  {
    this.AddMenuItem(key, caption, subMenu, tagString, imageResource);
  }

  private void AddMenuItem(
    string key,
    string caption,
    string subMenu,
    string tagString,
    Bitmap imageResource)
  {
    if (((ToolsCollectionBase) this.UltraToolbarsManager1.Tools).Exists(key))
      return;
    ButtonTool buttonTool = new ButtonTool(key);
    ((ToolPropsBase) ((ToolBase) buttonTool).SharedProps).Caption = caption;
    if (!string.IsNullOrEmpty(tagString))
      ((SubObjectBase) buttonTool).Tag = (object) tagString;
    this.UltraToolbarsManager1.Tools.Add((ToolBase) buttonTool);
    if (string.IsNullOrEmpty(subMenu))
    {
      ((ToolsCollectionBase) ((PopupMenuTool) ((ToolsCollectionBase) ((UltraToolbarBase) this.UltraToolbarsManager1.Toolbars[0]).Tools)["Insured"]).Tools).Add((ToolBase) buttonTool);
      if (imageResource != null)
        ((ToolPropsBase) ((ToolsCollectionBase) ((PopupMenuTool) ((ToolsCollectionBase) ((UltraToolbarBase) this.UltraToolbarsManager1.Toolbars[0]).Tools)["Insured"]).Tools)[key].SharedProps).AppearancesSmall.Appearance.Image = (object) imageResource;
    }
    else
    {
      ((PopupMenuTool) ((ToolsCollectionBase) ((PopupMenuTool) ((ToolsCollectionBase) ((UltraToolbarBase) this.UltraToolbarsManager1.Toolbars[0]).Tools)["Insured"]).Tools)[subMenu]).Tools.AddTool(key);
      if (imageResource != null)
        ((ToolPropsBase) ((ToolsCollectionBase) ((PopupMenuTool) ((ToolsCollectionBase) ((PopupMenuTool) ((ToolsCollectionBase) ((UltraToolbarBase) this.UltraToolbarsManager1.Toolbars[0]).Tools)["Insured"]).Tools)[subMenu]).Tools)[key].SharedProps).AppearancesSmall.Appearance.Image = (object) imageResource;
    }
    this.UltraToolbarsManager1.RefreshMerge();
  }

  protected virtual bool EnforcePrimaryInsuredLocation() => true;

  private bool IsEmpty(object obj) => obj == null || obj == DBNull.Value;

  private void ShowOfacXmlData()
  {
    if (!this._showOfacTab)
      return;
    this.lblOFACDate.Text = "OFAC Date:";
    this.lblOFACReturnCode.Text = "Return Code:";
    if (this._ofacStatus == null)
      return;
    this.lblOFACDate.Text = !this._ofacStatus.IsHit ? $"Search Date: {this._ofacStatus.LogDate:d}" : $"OFAC Date: {this._ofacStatus.HitDate:d}";
    this.lblOFACReturnCode.Text = $"Return Code: {this._ofacStatus.ReturnCode}";
    if (string.IsNullOrEmpty(this._ofacStatus.OfacXml))
      return;
    DataSet dataSet = this._ofacStatus.GetOfacDataset ?? new DataSet();
    ((UltraGridBase) this.ugOFAC).DataSource = (object) dataSet;
    ((UltraGridBase) this.ugOFAC).DataBind();
    if (dataSet.Tables.Count <= 0)
      return;
    if (((DisposableObjectCollectionBase) ((UltraGridBase) this.ugOFAC).DisplayLayout.Bands[0].Columns).Count > 13)
      ((UltraGridBase) this.ugOFAC).DisplayLayout.Bands[0].Columns[12].PerformAutoResize();
    ((UltraGridBase) this.ugOFAC).DisplayLayout.MaxColScrollRegions = 1;
    ((UltraGridBase) this.ugOFAC).UpdateData();
  }

  private void btnClearOFAC_Click(object sender, EventArgs e)
  {
    if (this.dsInsured.tblInsureds[0].RowState == DataRowState.Added)
    {
      int num = (int) MessageBox.Show("Please save the current insured before continuing", "Insured not Saved", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else
    {
      if (MessageBox.Show("You are about to clear OFAC info on this insured.\n\nContinue and clear OFAC info?", "Clear OFAC Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
        return;
      OfacSystem.Instance.RemoveOfacData(this.InsuredGuid, new Guid?(), true, true);
      CurrentUser.Instance.LogAction($"Modify Insured: '{this.InsuredName}' - Cleared OFAC information", this.InsuredGuid);
      this._ofacStatus = (OfacSystem.OfacStatus) null;
      ((UltraGridBase) this.ugOFAC).DataSource = (object) null;
      this.lblOFACDate.Text = "OFAC Date:";
      this.lblOFACReturnCode.Text = "Return Code:";
      ((UltraToggleEditorBase) this.chkOFACCleared).Checked = false;
      this.dtOFACClearedDate.Value = (object) null;
    }
  }

  List<int> ISupportTemplateDocs.SupportedTemplateGroupIDs
  {
    get
    {
      List<int> templateGroupIds;
      if (this.CurrentLocationRow != null && this.CurrentLocationRow.RowState != DataRowState.Added)
        templateGroupIds = new List<int>() { 4 };
      else
        templateGroupIds = (List<int>) null;
      return templateGroupIds;
    }
  }

  object[] ISupportTemplateDocs.TagParserConstructorArgs(int automationGroupID)
  {
    return new object[1]
    {
      (object) this.CurrentLocationRow.InsuredLocationGuid
    };
  }

  public string InsuredLocationName => string.Empty;

  private void FillInsuredStatistics()
  {
    ((Control) this.chartStats).Visible = false;
    this._statisticsThread?.Abort();
    this._statisticsThread = new Thread(new ThreadStart(this.FillInsuredsStatisticsThread))
    {
      Name = "Fill Insured Statistics"
    };
    this._statisticsThread.Start();
  }

  private void FillInsuredsStatisticsThread()
  {
    try
    {
      if (this.CurrentLocationRow == null)
        return;
      List<string> stringList = new List<string>();
      DataRow dataRow = (DataRow) null;
      object obj1 = (object) null;
      object obj2 = (object) null;
      object obj3 = (object) null;
      object objectValue = this.cboCompanyLines.Text == null || this.cboCompanyLines.Text.Length == 0 ? (object) null : RuntimeHelpers.GetObjectValue(this.cboCompanyLines.Value);
      DateTime date;
      if (this.dtStartDate.Value != null && this.dtStartDate.Value != DBNull.Value)
      {
        date = Conversions.ToDate(this.dtStartDate.Value);
        obj1 = (object) date.ToShortDateString();
      }
      if (this.dtEndDate.Value != null && this.dtEndDate.Value != DBNull.Value)
      {
        date = Conversions.ToDate(this.dtEndDate.Value);
        obj2 = (object) date.ToShortDateString();
      }
      if (this.CurrentLocationRow != null)
        obj3 = (object) this.CurrentLocationRow.InsuredLocationGuid;
      try
      {
        dataRow = DefaultDatabase.ExecuteDataRow("spGetInsuredStatistics", new object[8]
        {
          (object) "@insuredLocationGuid",
          obj3,
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
      this.Invoke((Delegate) new frmInsureds.FillInsuredStatisticsThreadCompleteHandler(this.FillInsuredStatisticsThreadComplete), (object) stringList, (object) dataRow);
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ErrorHandler.SilentHandleError(ex);
      ProjectData.ClearProjectError();
    }
  }

  private void FillInsuredStatisticsThreadComplete(List<string> output, DataRow dr)
  {
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

  private void tabControl_SelectedTabChanged(object sender, SelectedTabChangedEventArgs e)
  {
    if (this._tabStatisticsPainted || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((UltraTabControlBase) this.tabControl).SelectedTab.Key, "tabStatistics", false) != 0)
      return;
    this._tabStatisticsPainted = true;
    ((Control) this.cboCompanyLines).Enabled = false;
    ((Control) this.dtStartDate).Enabled = true;
    ((Control) this.dtEndDate).Enabled = true;
    this.btnQueryDates.Enabled = true;
    this.FillCompanyLines();
    this.FillInsuredStatistics();
  }

  private void FillCompanyLines()
  {
    ((Control) this.cboCompanyLines).Enabled = false;
    object obj = (object) null;
    if (this.CurrentLocationRow != null)
      obj = (object) this.CurrentLocationRow.InsuredLocationGuid;
    if (frmInsureds._compLineCache == null)
    {
      this.dsInsured.CompanyLines.AddCompanyLinesRow(Guid.Empty, string.Empty);
      DefaultDatabase.LoadDataSet((DataSet) this.dsInsured, new string[1]
      {
        "CompanyLines"
      }, "dbo.GetInsuredCompanyLineList", new object[2]
      {
        (object) "@insuredlocationGuid",
        obj
      });
    }
    if (frmInsureds._compLineCache != null)
    {
      this.dsInsured.CompanyLines.BeginLoadData();
      this.dsInsured.CompanyLines.Load((IDataReader) frmInsureds._compLineCache.CreateDataReader());
      this.dsInsured.CompanyLines.EndLoadData();
    }
    else
    {
      this.dsInsured.CompanyLines.Clear();
      this.dsInsured.CompanyLines.AddCompanyLinesRow(Guid.Empty, string.Empty);
      DefaultDatabase.LoadDataSet((DataSet) this.dsInsured, new string[1]
      {
        "CompanyLines"
      }, "dbo.GetInsuredCompanyLineList", new object[2]
      {
        (object) "@insuredlocationGuid",
        obj
      });
      frmInsureds._compLineCache = new dsInsured.CompanyLinesDataTable();
      frmInsureds._compLineCache.BeginLoadData();
      frmInsureds._compLineCache.Load((IDataReader) this.dsInsured.CompanyLines.CreateDataReader());
      frmInsureds._compLineCache.EndLoadData();
    }
    ((Control) this.cboCompanyLines).Enabled = true;
    this.FillCompanyLinesComplete();
  }

  private void FillCompanyLinesComplete()
  {
    MGASimpleComboBox cboCompanyLines = this.cboCompanyLines;
    ((UltraGridBase) cboCompanyLines).DataSource = (object) this.dsInsured.CompanyLines;
    ((UltraDropDownBase) cboCompanyLines).DisplayMember = "CompanyLine";
    ((UltraDropDownBase) cboCompanyLines).ValueMember = "CompanyLineGuid";
    ((Control) cboCompanyLines).Enabled = this._CanEditInsured;
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
        this.FillInsuredStatistics();
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

  private void cboCompanyLines_ValueChanged(object sender, EventArgs e)
  {
    this.FillInsuredStatistics();
  }

  private void btnReport_Click(object sender, EventArgs e)
  {
    if (this.CurrentLocationRow == null)
    {
      int num1 = (int) MessageBox.Show("Please select an insured location to add call reports to.", "No Insured Selected", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else if (this.CurrentLocationRow.RowState == DataRowState.Added)
    {
      int num2 = (int) MessageBox.Show("Please save the current insured prior to adding call reports.", "Current Location Not Added", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else
    {
      FormSettings.ShowFormDialog(typeof (FormInsuredCallReport), (object) this.CurrentLocationRow.InsuredLocationGuid, (object) true);
      this.FillInsuredCallReports(this._insuredGuid, this._showInsuredCallReportsTab);
    }
  }

  private void FillInsuredCallReports(Guid insured, bool showCallReportsTab)
  {
    if (!showCallReportsTab)
      return;
    this.dsInsured.tblInsuredCallReport.Clear();
    DefaultDatabase.LoadDataTable((DataTable) this.dsInsured.tblInsuredCallReport, "spGetInsuredCallReports", new object[2]
    {
      (object) "@InsuredGuid",
      (object) insured
    });
    ((UltraGridBase) this.ugDetails).UpdateData();
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
    FormSettings.ShowFormDialog(typeof (FormInsuredCallReport), (object) this.CurrentLocationRow.InsuredLocationGuid, (object) false, (object) Conversions.ToInteger(context.Cells["CallReportID"].Value));
    this.FillInsuredCallReports(this._insuredGuid, this._showInsuredCallReportsTab);
  }

  private void SaveRichTextBoxesInfo(dsInsured.tblInsuredLocationsRow dr)
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
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.ZipCodeResolver1.ZipCodeExtension, string.Empty, false) == 0)
      dr.SetZipPlusNull();
    else
      dr.ZipPlus = this.ZipCodeResolver1.ZipCodeExtension;
    dr.CountryCodeforPhone = this.MgaInternationalPhone.CountryCode;
    dr.Phone = this.MgaInternationalPhone.ValueString;
    dr.CountryCodeforFax = this.MgaInternationaFax.CountryCode;
    dr.Fax = this.MgaInternationaFax.ValueString;
    dr.CountryCodeforMobile = this.MgaInternationalMobile.CountryCode;
    dr.MobileNumber = this.MgaInternationalMobile.ValueString;
    dr.ZipCode = this.ZipCodeResolver1.ZipCode;
    dr.County = this.ZipCodeResolver1.County;
    dr.City = this.ZipCodeResolver1.City;
    dr.State = this.ZipCodeResolver1.State;
    dr.ISOCountryCode = this.ZipCodeResolver1.ISOCountryCode;
    this.SetZip();
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
        this.MgaInternationaFax.CountryCode = this.CurrentLocationRow.CountryCodeforFax;
      }
      catch (ArgumentException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        this.MgaInternationaFax.CountryCode = this.CurrentLocationRow.CountryCodeforFax;
        ProjectData.ClearProjectError();
      }
    }
    if (!this.CurrentLocationRow.IsFaxNull())
    {
      try
      {
        this.MgaInternationaFax.Value = (object) this.CurrentLocationRow.Fax;
      }
      catch (ArgumentException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        this.MgaInternationaFax.Text = this.CurrentLocationRow.Fax;
        ProjectData.ClearProjectError();
      }
    }
    if (!this.CurrentLocationRow.IsCountryCodeforMobileNull())
    {
      try
      {
        this.MgaInternationalMobile.CountryCode = this.CurrentLocationRow.CountryCodeforMobile;
      }
      catch (ArgumentException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        this.MgaInternationalMobile.CountryCode = this.CurrentLocationRow.CountryCodeforMobile;
        ProjectData.ClearProjectError();
      }
    }
    if (!this.CurrentLocationRow.IsMobileNumberNull())
    {
      try
      {
        this.MgaInternationalMobile.Value = (object) this.CurrentLocationRow.MobileNumber;
      }
      catch (ArgumentException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        this.MgaInternationalMobile.Text = this.CurrentLocationRow.MobileNumber;
        ProjectData.ClearProjectError();
      }
    }
    if (!this.CurrentLocationRow.IsZipCodeNull())
    {
      try
      {
        this.ZipCodeResolver1.ZipCode = this.CurrentLocationRow.ZipCode;
      }
      catch (ArgumentException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        this.ZipCodeResolver1.ZipCode = this.CurrentLocationRow.ZipCode;
        ProjectData.ClearProjectError();
      }
    }
    if (!this.CurrentLocationRow.IsZipPlusNull())
    {
      try
      {
        this.ZipCodeResolver1.ZipCodeExtension = this.CurrentLocationRow.ZipPlus;
      }
      catch (ArgumentException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        this.ZipCodeResolver1.ZipCodeExtension = this.CurrentLocationRow.ZipPlus;
        ProjectData.ClearProjectError();
      }
    }
    if (!this.CurrentLocationRow.IsCityNull())
    {
      try
      {
        this.ZipCodeResolver1.City = this.CurrentLocationRow.City;
      }
      catch (ArgumentException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        this.ZipCodeResolver1.City = this.CurrentLocationRow.City;
        ProjectData.ClearProjectError();
      }
    }
    if (!this.CurrentLocationRow.IsCountyNull())
    {
      try
      {
        this.ZipCodeResolver1.County = this.CurrentLocationRow.County;
      }
      catch (ArgumentException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        this.ZipCodeResolver1.County = this.CurrentLocationRow.County;
        ProjectData.ClearProjectError();
      }
    }
    if (!this.CurrentLocationRow.IsStateNull())
    {
      try
      {
        this.ZipCodeResolver1.State = this.CurrentLocationRow.State;
      }
      catch (ArgumentException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        this.ZipCodeResolver1.State = this.CurrentLocationRow.State;
        ProjectData.ClearProjectError();
      }
    }
    this.ZipCodeResolver1.ISOCountryCode = this.CurrentLocationRow.ISOCountryCode;
  }

  private void lnkOrderInsuranceScoreReport_LinkClicked(
    object sender,
    LinkLabelLinkClickedEventArgs e)
  {
    if (this.CurrentLocationRow == null)
    {
      int num1 = (int) MessageBox.Show("In order to continue, please select a currenct insured.", "Please Select Insured", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else if (InsuranceScore.IsStateExcluded(this.CurrentLocationRow.State))
    {
      int num2 = (int) MessageBox.Show($"State of {this.CurrentLocationRow.State} is excluded from ordering insurance scores.", "State Excluded", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else
    {
      bool valid = new InsuranceScore(this.CurrentLocationRow.InsuredGuid).Submit();
      this.ScoreNoticeCheck();
      this.OnInsuredScoreCheck(valid);
    }
  }

  private void ScoreNoticeCheck()
  {
    this.lnkInsuranceScoreNotice.Visible = false;
    this.lblInsuredScore.Text = "Insured Score:N/A";
    ((Control) this.txtInsuredScoreStatus).Visible = false;
    if (!this._implementInsuredScores)
      return;
    int num = InsuranceScore.ScoreThreshold();
    if (num == int.MinValue)
      return;
    int score = InsuranceScore.GetScore(this.CurrentLocationRow.InsuredGuid);
    if (score == int.MinValue)
    {
      string status = InsuranceScore.GetStatus(this.CurrentLocationRow.InsuredGuid);
      if (string.IsNullOrEmpty(status))
        return;
      ((Control) this.txtInsuredScoreStatus).Visible = true;
      ((TextEditorControlBase) this.txtInsuredScoreStatus).Text = status;
    }
    else
    {
      if (score < num)
        this.lnkInsuranceScoreNotice.Visible = true;
      this.lblInsuredScore.Text = $"Insured Score:{score}";
    }
  }

  protected virtual void OnInsuredScoreCheck(bool valid)
  {
  }

  private delegate void FillInsuredStatisticsThreadCompleteHandler(
    List<string> statList,
    DataRow dr);

  private delegate DialogResult MessageHandler(
    string message,
    string caption,
    MessageBoxButtons buttons,
    MessageBoxIcon icon);
}
