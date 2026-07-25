// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.Companies.frmCompanyLines
// Assembly: MgaSystems.IMS.IPC, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: F22CEF02-8C0F-420D-8344-A8A010CA7834
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.IPC.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinMaskedEdit;
using Infragistics.Win.UltraWinScrollBar;
using Infragistics.Win.UltraWinTabControl;
using Infragistics.Win.UltraWinTabs;
using Infragistics.Win.UltraWinToolbars;
using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Common.ErrorHandling;
using MGASystems.Common.Functions;
using MGASystems.Common.NativeWindowMethods;
using MGASystems.Data;
using MGASystems.IMS.DocumentAutomation;
using MGASystems.IMS.InsuredsProducersCompanies.Companies.Commissions;
using MGASystems.IMS.InsuredsProducersCompanies.Companies.FormsConditionsWarranties;
using MGASystems.IMS.InsuredsProducersCompanies.Companies.TermsOfPayment;
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
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.InsuredsProducersCompanies.Companies;

[SecureResource("{A43461BA-305B-4911-8AE3-145BCBD9B9F8}", "Access Company Lines Screen", "Controls access to the Company Lines screen.", "Companies")]
[SecureResource("{30823EC2-9D44-4C32-ADB9-DEA42B77E5F9}", "Access Unique Policy Number", "Controls access to Unique Policy Number.", "Companies")]
[SecureResource("{80B7143D-BAB0-499F-8480-4A345F912298}", "Access to Company Lines Data", "Controls access to the Company Lines data.", "Companies")]
public class frmCompanyLines : Form, IExposeMenuManager, IQueryResponse
{
  private IContainer components;
  private ToolTip ToolTip;
  private Label Label1;
  private Label Label3;
  private Label Label4;
  private UltraGroupBox GroupBox3;
  private DbConnection cnSQL;
  private DbDataAdapter daCompanyLines;
  private Label Label2;
  private MGASimpleComboBox cbLicenseType;
  private dsCompanyLines dsLines;
  private DbCommand DbSelectCommand1;
  private Label Label13;
  private MGASimpleComboBox cboStatus;
  private Label Label14;
  private MGASimpleComboBox cboCompanySignature;
  private Label Label16;
  private ErrorProvider err;
  private DbCommand DbSelectCommand4;
  private DbCommand DbInsertCommand1;
  private DbCommand DbUpdateCommand1;
  private DbCommand DbDeleteCommand1;
  private Label Label20;
  private Label Label23;
  private MGATextBox txtDefaultInvoiceComment;
  private UltraTabSharedControlsPage UltraTabSharedControlsPage1;
  private UltraTabPageControl UltraTabPageControl5;
  private Label Label24;
  private Label Label25;
  private Label Label26;
  private MGACheckBox chkAutoNOC;
  private Label Label27;
  private Label Label28;
  private MGACheckBox chkEmailReminder;
  private MGATextBox txtMailingDays;
  private MGATextBox txtNOCDays;
  private MGATextBox txtEmailReminderDays;
  private Label Label29;
  private MGACheckBox chkIncludeFeesNOC;
  private UltraGroupBox GroupBox1;
  private UltraGroupBox GroupBox2;
  private Label Label30;
  private Label Label31;
  private UltraToolbarsDockArea _frmCompanyLines_Toolbars_Dock_Area_Left;
  private UltraToolbarsDockArea _frmCompanyLines_Toolbars_Dock_Area_Right;
  private UltraToolbarsDockArea _frmCompanyLines_Toolbars_Dock_Area_Top;
  private UltraToolbarsDockArea _frmCompanyLines_Toolbars_Dock_Area_Bottom;
  private UltraTabPageControl UltraTabPageControl6;
  private Label Label32;
  private MGATextBox txtQuoteAdditionalComments;
  private DbCommand DbSelectCommand2;
  private Label Label33;
  private Label Label34;
  private MGANumericEditor numMinimumEarnedPercentage;
  private MGANumericEditor txtBinderExpiration;
  private MGANumericEditor txtInvoiceDays;
  private MGANumericEditor txtBackdateDays;
  private Label Label35;
  private MGACheckBox chkUniquePolicyNumbers;
  public const string OpenForm = "{A43461BA-305B-4911-8AE3-145BCBD9B9F8}";
  public const string UpdateFormData = "{80B7143D-BAB0-499F-8480-4A345F912298}";
  public const string UpdateUniquePolicyNumber = "{30823EC2-9D44-4C32-ADB9-DEA42B77E5F9}";
  private bool _fireHandler;
  private Dictionary<string, Binding> _bindings;
  private Dictionary<string, frmCompanyLines.ComboBoxDataSource> _dataSources;
  private MemoryStream _gridLayout;
  protected Guid _companyLineGuidFilter;
  protected Guid _companyLocationGuidFilter;
  private int _settingNOCDays;
  private bool _UpdateFormData;
  private bool _UpdateUniquePolicyNumber;
  private bool _canViewNOCGracePeriod;
  private Thread _fillThread;
  private Dictionary<Guid, bool> _quotesExist;
  private Thread _filterThread;

  protected override void Dispose(bool disposing)
  {
    if (disposing)
    {
      if (this.components != null)
        this.components.Dispose();
      if (this._gridLayout != null)
        this._gridLayout.Dispose();
    }
    base.Dispose(disposing);
  }

  private virtual MGASimpleComboBox cbStates
  {
    get => this._cbStates;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.cbStates_ValueChanged);
      MGASimpleComboBox cbStates1 = this._cbStates;
      if (cbStates1 != null)
        cbStates1.ValueChanged -= eventHandler;
      this._cbStates = value;
      MGASimpleComboBox cbStates2 = this._cbStates;
      if (cbStates2 == null)
        return;
      cbStates2.ValueChanged += eventHandler;
    }
  }

  private virtual MGASimpleComboBox cbLines
  {
    get => this._cbLines;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      CancelEventHandler cancelEventHandler = new CancelEventHandler(this.cbLines_BeforeDropDown);
      InitializeLayoutEventHandler layoutEventHandler = new InitializeLayoutEventHandler(this.cbLines_InitializeLayout);
      EventHandler eventHandler = new EventHandler(this.cbLines_ValueChanged);
      MGASimpleComboBox cbLines1 = this._cbLines;
      if (cbLines1 != null)
      {
        cbLines1.BeforeDropDown -= cancelEventHandler;
        cbLines1.InitializeLayout -= layoutEventHandler;
        cbLines1.ValueChanged -= eventHandler;
      }
      this._cbLines = value;
      MGASimpleComboBox cbLines2 = this._cbLines;
      if (cbLines2 == null)
        return;
      cbLines2.BeforeDropDown += cancelEventHandler;
      cbLines2.InitializeLayout += layoutEventHandler;
      cbLines2.ValueChanged += eventHandler;
    }
  }

  private virtual MGASimpleComboBox cbCompanies
  {
    get => this._cbCompanies;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      InitializeLayoutEventHandler layoutEventHandler = new InitializeLayoutEventHandler(this.cbCompanies_InitializeLayout);
      MGASimpleComboBox cbCompanies1 = this._cbCompanies;
      if (cbCompanies1 != null)
        cbCompanies1.InitializeLayout -= layoutEventHandler;
      this._cbCompanies = value;
      MGASimpleComboBox cbCompanies2 = this._cbCompanies;
      if (cbCompanies2 == null)
        return;
      cbCompanies2.InitializeLayout += layoutEventHandler;
    }
  }

  [field: AccessedThroughProperty("cbStateFilter")]
  private virtual MGASimpleComboBox cbStateFilter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MGASimpleComboBox cbLineFilter
  {
    get => this._cbLineFilter;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      InitializeLayoutEventHandler layoutEventHandler = new InitializeLayoutEventHandler(this.cbLineFilter_InitializeLayout);
      MGASimpleComboBox cbLineFilter1 = this._cbLineFilter;
      if (cbLineFilter1 != null)
        cbLineFilter1.InitializeLayout -= layoutEventHandler;
      this._cbLineFilter = value;
      MGASimpleComboBox cbLineFilter2 = this._cbLineFilter;
      if (cbLineFilter2 == null)
        return;
      cbLineFilter2.InitializeLayout += layoutEventHandler;
    }
  }

  private virtual MGASimpleComboBox cbCompanyFilter
  {
    get => this._cbCompanyFilter;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      InitializeLayoutEventHandler layoutEventHandler = new InitializeLayoutEventHandler(this.cbCompanyFilter_InitializeLayout);
      MGASimpleComboBox cbCompanyFilter1 = this._cbCompanyFilter;
      if (cbCompanyFilter1 != null)
        cbCompanyFilter1.InitializeLayout -= layoutEventHandler;
      this._cbCompanyFilter = value;
      MGASimpleComboBox cbCompanyFilter2 = this._cbCompanyFilter;
      if (cbCompanyFilter2 == null)
        return;
      cbCompanyFilter2.InitializeLayout += layoutEventHandler;
    }
  }

  protected virtual MGASimpleComboBox cboCompanyLicensed
  {
    get => this._cboCompanyLicensed;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.cboCompanyLicensed_ValueChanged);
      MGASimpleComboBox cboCompanyLicensed1 = this._cboCompanyLicensed;
      if (cboCompanyLicensed1 != null)
        cboCompanyLicensed1.ValueChanged -= eventHandler;
      this._cboCompanyLicensed = value;
      MGASimpleComboBox cboCompanyLicensed2 = this._cboCompanyLicensed;
      if (cboCompanyLicensed2 == null)
        return;
      cboCompanyLicensed2.ValueChanged += eventHandler;
    }
  }

  protected virtual UltraGrid dgView
  {
    get => this._dgView;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.dgView_KeyDown);
      MouseEventHandler mouseEventHandler = new MouseEventHandler(this.dgView_MouseDown);
      UltraGrid dgView1 = this._dgView;
      if (dgView1 != null)
      {
        ((Control) dgView1).KeyDown -= keyEventHandler;
        ((Control) dgView1).MouseDown -= mouseEventHandler;
      }
      this._dgView = value;
      UltraGrid dgView2 = this._dgView;
      if (dgView2 == null)
        return;
      ((Control) dgView2).KeyDown += keyEventHandler;
      ((Control) dgView2).MouseDown += mouseEventHandler;
    }
  }

  [field: AccessedThroughProperty("cboParent")]
  private virtual MGASimpleComboBox cboParent { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual UltraToolbarsManager menumanager
  {
    get => this._menumanager;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      ToolClickEventHandler clickEventHandler = new ToolClickEventHandler(this.menumanager_ToolClick);
      BeforeToolDropdownEventHandler dropdownEventHandler = new BeforeToolDropdownEventHandler(this.menumanager_BeforeToolDropdown);
      UltraToolbarsManager menumanager1 = this._menumanager;
      if (menumanager1 != null)
      {
        menumanager1.ToolClick -= clickEventHandler;
        menumanager1.BeforeToolDropdown -= dropdownEventHandler;
      }
      this._menumanager = value;
      UltraToolbarsManager menumanager2 = this._menumanager;
      if (menumanager2 == null)
        return;
      menumanager2.ToolClick += clickEventHandler;
      menumanager2.BeforeToolDropdown += dropdownEventHandler;
    }
  }

  protected virtual MGASystems.Tools.DBSaveUI.DBSaveUI dbSave
  {
    get => this._dbSave;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.dbSave_UIStateChanged);
      CancelEventHandler cancelEventHandler1 = new CancelEventHandler(this.dbSave_ClickingSave);
      CancelEventHandler cancelEventHandler2 = new CancelEventHandler(this.dbSave_ClickingNew);
      CancelEventHandler cancelEventHandler3 = new CancelEventHandler(this.dbSave_ClickingCancel);
      CancelEventHandler cancelEventHandler4 = new CancelEventHandler(this.dbSave_ClickingDelete);
      CancelEventHandler cancelEventHandler5 = new CancelEventHandler(this.dbSave_ClickingEdit);
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave1 = this._dbSave;
      if (dbSave1 != null)
      {
        dbSave1.UIStateChanged -= eventHandler;
        dbSave1.ClickingSave -= cancelEventHandler1;
        dbSave1.ClickingNew -= cancelEventHandler2;
        dbSave1.ClickingCancel -= cancelEventHandler3;
        dbSave1.ClickingDelete -= cancelEventHandler4;
        dbSave1.ClickingEdit -= cancelEventHandler5;
      }
      this._dbSave = value;
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave2 = this._dbSave;
      if (dbSave2 == null)
        return;
      dbSave2.UIStateChanged += eventHandler;
      dbSave2.ClickingSave += cancelEventHandler1;
      dbSave2.ClickingNew += cancelEventHandler2;
      dbSave2.ClickingCancel += cancelEventHandler3;
      dbSave2.ClickingDelete += cancelEventHandler4;
      dbSave2.ClickingEdit += cancelEventHandler5;
    }
  }

  [field: AccessedThroughProperty("ultraTab")]
  protected virtual UltraTabControl ultraTab { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraTabPageControl1")]
  protected virtual UltraTabPageControl UltraTabPageControl1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual LinkLabel lnkSignatures
  {
    get => this._lnkSignatures;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkSignatures_LinkClicked);
      LinkLabel lnkSignatures1 = this._lnkSignatures;
      if (lnkSignatures1 != null)
        lnkSignatures1.LinkClicked -= clickedEventHandler;
      this._lnkSignatures = value;
      LinkLabel lnkSignatures2 = this._lnkSignatures;
      if (lnkSignatures2 == null)
        return;
      lnkSignatures2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("daGetCompanyLine")]
  internal virtual DbDataAdapter daGetCompanyLine { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("DbSelectCommand3")]
  internal virtual DbCommand DbSelectCommand3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraTabPageControl2")]
  internal virtual UltraTabPageControl UltraTabPageControl2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtBinderComments")]
  internal virtual MGATextBox txtBinderComments { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label5")]
  internal virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaCheckBox1")]
  internal virtual MGACheckBox MgaCheckBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("DbInsertCommand2")]
  internal virtual DbCommand DbInsertCommand2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("DbUpdateCommand2")]
  internal virtual DbCommand DbUpdateCommand2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("DbDeleteCommand2")]
  internal virtual DbCommand DbDeleteCommand2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual LinkLabel lnkApplyFilter
  {
    get => this._lnkApplyFilter;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkApplyFilter_LinkClicked);
      LinkLabel lnkApplyFilter1 = this._lnkApplyFilter;
      if (lnkApplyFilter1 != null)
        lnkApplyFilter1.LinkClicked -= clickedEventHandler;
      this._lnkApplyFilter = value;
      LinkLabel lnkApplyFilter2 = this._lnkApplyFilter;
      if (lnkApplyFilter2 == null)
        return;
      lnkApplyFilter2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("panelLoading")]
  internal virtual UltraGroupBox panelLoading { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label6")]
  internal virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PictureBox1")]
  internal virtual PictureBox PictureBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkBlockXSPremium")]
  internal virtual MGACheckBox chkBlockXSPremium { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkAllowLapseInCoverage")]
  internal virtual MGACheckBox chkAllowLapseInCoverage { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("DbCommand1")]
  internal virtual DbCommand DbCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkInsuredFEINSSN")]
  internal virtual MGACheckBox chkInsuredFEINSSN { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkSupportPreIssuanceEndorsementNumbering")]
  internal virtual MGACheckBox chkSupportPreIssuanceEndorsementNumbering { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual LinkLabel lnkCPF
  {
    get => this._lnkCPF;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkCPF_LinkClicked);
      LinkLabel lnkCpf1 = this._lnkCPF;
      if (lnkCpf1 != null)
        lnkCpf1.LinkClicked -= clickedEventHandler;
      this._lnkCPF = value;
      LinkLabel lnkCpf2 = this._lnkCPF;
      if (lnkCpf2 == null)
        return;
      lnkCpf2.LinkClicked += clickedEventHandler;
    }
  }

  protected virtual LinkLabel lnkFCW
  {
    get => this._lnkFCW;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkFCW_LinkClicked);
      LinkLabel lnkFcw1 = this._lnkFCW;
      if (lnkFcw1 != null)
        lnkFcw1.LinkClicked -= clickedEventHandler;
      this._lnkFCW = value;
      LinkLabel lnkFcw2 = this._lnkFCW;
      if (lnkFcw2 == null)
        return;
      lnkFcw2.LinkClicked += clickedEventHandler;
    }
  }

  protected virtual LinkLabel lnkDocAuto
  {
    get => this._lnkDocAuto;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkDocAuto_LinkClicked);
      LinkLabel lnkDocAuto1 = this._lnkDocAuto;
      if (lnkDocAuto1 != null)
        lnkDocAuto1.LinkClicked -= clickedEventHandler;
      this._lnkDocAuto = value;
      LinkLabel lnkDocAuto2 = this._lnkDocAuto;
      if (lnkDocAuto2 == null)
        return;
      lnkDocAuto2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("chkWaivePremium")]
  private virtual MGACheckBox chkWaivePremium { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkBlockUIExit")]
  private virtual MGACheckBox chkBlockUIExit { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label7")]
  private virtual Label Label7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaNumericEditor2")]
  private virtual MGANumericEditor MgaNumericEditor2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaNumericEditor1")]
  private virtual MGANumericEditor MgaNumericEditor1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkSupportLossRuns")]
  internal virtual MGACheckBox chkSupportLossRuns { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboDefaultFinanceCo")]
  private virtual MGASimpleComboBox cboDefaultFinanceCo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label8")]
  private virtual Label Label8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraTabPageControl3")]
  internal virtual UltraTabPageControl UltraTabPageControl3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkResetFCWRecords")]
  internal virtual MGACheckBox chkResetFCWRecords { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkClearRenewalTemplates")]
  internal virtual MGACheckBox chkClearRenewalTemplates { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("grpRenewalForms")]
  private virtual UltraGroupBox grpRenewalForms { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkClearRenewalForms")]
  internal virtual MGACheckBox chkClearRenewalForms { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGACheckBox chkHideInactive
  {
    get => this._chkHideInactive;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.chkHideInactive_CheckedChanged);
      MGACheckBox chkHideInactive1 = this._chkHideInactive;
      if (chkHideInactive1 != null)
        ((UltraToggleEditorBase) chkHideInactive1).CheckedChanged -= eventHandler;
      this._chkHideInactive = value;
      MGACheckBox chkHideInactive2 = this._chkHideInactive;
      if (chkHideInactive2 == null)
        return;
      ((UltraToggleEditorBase) chkHideInactive2).CheckedChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("chkKeepPolicyNumberOnRewrite")]
  internal virtual MGACheckBox chkKeepPolicyNumberOnRewrite { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("grpCompanyLineFiling")]
  protected virtual GroupBox grpCompanyLineFiling { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtNOCGracePeriod")]
  protected virtual MGATextBox txtNOCGracePeriod { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblNOCGracePeriod")]
  private virtual Label lblNOCGracePeriod { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkResetSubjectivities")]
  internal virtual MGACheckBox chkResetSubjectivities { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual LinkLabel lnkAdminCommissions
  {
    get => this._lnkAdminCommissions;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkAdminCommissions_LinkClicked);
      LinkLabel adminCommissions1 = this._lnkAdminCommissions;
      if (adminCommissions1 != null)
        adminCommissions1.LinkClicked -= clickedEventHandler;
      this._lnkAdminCommissions = value;
      LinkLabel adminCommissions2 = this._lnkAdminCommissions;
      if (adminCommissions2 == null)
        return;
      adminCommissions2.LinkClicked += clickedEventHandler;
    }
  }

  [DebuggerStepThrough]
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmCompanyLines));
    Appearance appearance34 = new Appearance();
    Appearance appearance35 = new Appearance();
    Appearance appearance36 = new Appearance();
    UltraTab ultraTab1 = new UltraTab();
    Appearance appearance37 = new Appearance();
    UltraTab ultraTab2 = new UltraTab();
    Appearance appearance38 = new Appearance();
    UltraTab ultraTab3 = new UltraTab();
    Appearance appearance39 = new Appearance();
    UltraTab ultraTab4 = new UltraTab();
    Appearance appearance40 = new Appearance();
    UltraTab ultraTab5 = new UltraTab();
    Appearance appearance41 = new Appearance();
    Appearance appearance42 = new Appearance();
    UltraToolbar ultraToolbar = new UltraToolbar("MainMenu");
    PopupMenuTool popupMenuTool1 = new PopupMenuTool("fclCompany/Line");
    PopupMenuTool popupMenuTool2 = new PopupMenuTool("fclCompany/Line");
    Appearance appearance43 = new Appearance();
    PopupMenuTool popupMenuTool3 = new PopupMenuTool("fclCompany Info");
    PopupMenuTool popupMenuTool4 = new PopupMenuTool("fclPolicies");
    PopupMenuTool popupMenuTool5 = new PopupMenuTool("Line Ordering");
    ButtonTool buttonTool1 = new ButtonTool("Copy...");
    ButtonTool buttonTool2 = new ButtonTool("Copy to New Setup ...");
    ButtonTool buttonTool3 = new ButtonTool("Logging Information");
    ButtonTool buttonTool4 = new ButtonTool("Copy Rater Conditionals");
    ButtonTool buttonTool5 = new ButtonTool("Global Rater Update");
    ButtonTool buttonTool6 = new ButtonTool("Copy Cost Centers");
    ButtonTool buttonTool7 = new ButtonTool("Copy Policy Numbers");
    ButtonTool buttonTool8 = new ButtonTool("Assign Raters");
    Appearance appearance44 = new Appearance();
    ButtonTool buttonTool9 = new ButtonTool("Assign Fees");
    Appearance appearance45 = new Appearance();
    ButtonTool buttonTool10 = new ButtonTool("Copy...");
    Appearance appearance46 = new Appearance();
    ButtonTool buttonTool11 = new ButtonTool("Authorize Offices");
    Appearance appearance47 = new Appearance();
    ButtonTool buttonTool12 = new ButtonTool("Available Billing Types");
    Appearance appearance48 = new Appearance();
    ButtonTool buttonTool13 = new ButtonTool("Document Automation");
    Appearance appearance49 = new Appearance();
    PopupMenuTool popupMenuTool6 = new PopupMenuTool("fclCompany Info");
    ButtonTool buttonTool14 = new ButtonTool("New Company");
    ButtonTool buttonTool15 = new ButtonTool("New Contact");
    ButtonTool buttonTool16 = new ButtonTool("View");
    ButtonTool buttonTool17 = new ButtonTool("New Company");
    Appearance appearance50 = new Appearance();
    ButtonTool buttonTool18 = new ButtonTool("New Contact");
    Appearance appearance51 = new Appearance();
    ButtonTool buttonTool19 = new ButtonTool("View");
    Appearance appearance52 = new Appearance();
    ButtonTool buttonTool20 = new ButtonTool("Installment Options");
    Appearance appearance53 = new Appearance();
    ButtonTool buttonTool21 = new ButtonTool("FCW");
    Appearance appearance54 = new Appearance();
    ButtonTool buttonTool22 = new ButtonTool("Policy Classes");
    Appearance appearance55 = new Appearance();
    ButtonTool buttonTool23 = new ButtonTool("Construction Types");
    Appearance appearance56 = new Appearance();
    ButtonTool buttonTool24 = new ButtonTool("Binding Requirements");
    Appearance appearance57 = new Appearance();
    PopupMenuTool popupMenuTool7 = new PopupMenuTool("fclProducers");
    ButtonTool buttonTool25 = new ButtonTool("SIC Codes");
    Appearance appearance58 = new Appearance();
    ButtonTool buttonTool26 = new ButtonTool("CompanyCommissions");
    Appearance appearance59 = new Appearance();
    ButtonTool buttonTool27 = new ButtonTool("Payment Terms");
    Appearance appearance60 = new Appearance();
    ButtonTool buttonTool28 = new ButtonTool("Policy Numbering");
    Appearance appearance61 = new Appearance();
    PopupMenuTool popupMenuTool8 = new PopupMenuTool("fclPopupMenuTool1");
    ButtonTool buttonTool29 = new ButtonTool("Construction Types");
    ButtonTool buttonTool30 = new ButtonTool("SIC Codes");
    PopupMenuTool popupMenuTool9 = new PopupMenuTool("fclDocuments");
    ButtonTool buttonTool31 = new ButtonTool("Document Automation");
    ButtonTool buttonTool32 = new ButtonTool("FCW");
    ButtonTool buttonTool33 = new ButtonTool("Conditional Policy Forms...");
    PopupMenuTool popupMenuTool10 = new PopupMenuTool("fclPolicies");
    PopupMenuTool popupMenuTool11 = new PopupMenuTool("fclPopupMenuTool1");
    PopupMenuTool popupMenuTool12 = new PopupMenuTool("fclDocuments");
    PopupMenuTool popupMenuTool13 = new PopupMenuTool("fclBilling");
    ButtonTool buttonTool34 = new ButtonTool("Assign Raters");
    ButtonTool buttonTool35 = new ButtonTool("Generic Quote Wording");
    ButtonTool buttonTool36 = new ButtonTool("Assign Fees");
    ButtonTool buttonTool37 = new ButtonTool("Authorize Offices");
    ButtonTool buttonTool38 = new ButtonTool("Policy Classes");
    ButtonTool buttonTool39 = new ButtonTool("Binding Requirements");
    ButtonTool buttonTool40 = new ButtonTool("CompanyCommissions");
    ButtonTool buttonTool41 = new ButtonTool("Policy Numbering");
    ButtonTool buttonTool42 = new ButtonTool("Assign Cost Centers...");
    ButtonTool buttonTool43 = new ButtonTool("Cancellation Requirements ...");
    PopupMenuTool popupMenuTool14 = new PopupMenuTool("fclBilling");
    ButtonTool buttonTool44 = new ButtonTool("Available Billing Types");
    ButtonTool buttonTool45 = new ButtonTool("Installment Options");
    ButtonTool buttonTool46 = new ButtonTool("Payment Terms");
    ButtonTool buttonTool47 = new ButtonTool("Generic Quote Wording");
    Appearance appearance62 = new Appearance();
    ButtonTool buttonTool48 = new ButtonTool("Conditional Policy Forms...");
    Appearance appearance63 = new Appearance();
    PopupMenuTool popupMenuTool15 = new PopupMenuTool("Line Ordering");
    ButtonTool buttonTool49 = new ButtonTool("Move Up");
    ButtonTool buttonTool50 = new ButtonTool("Move Down");
    ButtonTool buttonTool51 = new ButtonTool("Move Up");
    Appearance appearance64 = new Appearance();
    ButtonTool buttonTool52 = new ButtonTool("Move Down");
    Appearance appearance65 = new Appearance();
    ButtonTool buttonTool53 = new ButtonTool("Assign Cost Centers...");
    Appearance appearance66 = new Appearance();
    ButtonTool buttonTool54 = new ButtonTool("Copy to New Setup ...");
    Appearance appearance67 = new Appearance();
    Appearance appearance68 = new Appearance();
    ButtonTool buttonTool55 = new ButtonTool("Logging Information");
    Appearance appearance69 = new Appearance();
    Appearance appearance70 = new Appearance();
    ButtonTool buttonTool56 = new ButtonTool("Copy Rater Conditionals");
    Appearance appearance71 = new Appearance();
    Appearance appearance72 = new Appearance();
    ButtonTool buttonTool57 = new ButtonTool("Global Rater Update");
    Appearance appearance73 = new Appearance();
    ButtonTool buttonTool58 = new ButtonTool("Cancellation Requirements ...");
    Appearance appearance74 = new Appearance();
    Appearance appearance75 = new Appearance();
    ButtonTool buttonTool59 = new ButtonTool("Copy Cost Centers");
    Appearance appearance76 = new Appearance();
    ButtonTool buttonTool60 = new ButtonTool("Copy Policy Numbers");
    Appearance appearance77 = new Appearance();
    Appearance appearance78 = new Appearance();
    Appearance appearance79 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("ViewCompanyLines", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("CompanyLineGuid");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("LineName");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("Name");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("State");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("CompanyLocationGuid");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("ViewCompanyLinesViewCompanyLinesChildren");
    UltraGridBand ultraGridBand2 = new UltraGridBand("ViewCompanyLinesViewCompanyLinesChildren", 0);
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("CompanyLineGuid");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("LineName");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("Name");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("State");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("CompanyLocationGuid");
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("ParentCompanyLineGuid");
    Appearance appearance80 = new Appearance();
    Appearance appearance81 = new Appearance();
    Appearance appearance82 = new Appearance();
    Appearance appearance83 = new Appearance();
    Appearance appearance84 = new Appearance();
    Appearance appearance85 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance86 = new Appearance();
    Appearance appearance87 = new Appearance();
    Appearance appearance88 = new Appearance();
    this.UltraTabPageControl1 = new UltraTabPageControl();
    this.grpCompanyLineFiling = new GroupBox();
    this.rbNone = new RadioButton();
    this.rbInside = new RadioButton();
    this.rbOutside = new RadioButton();
    this.chkKeepPolicyNumberOnRewrite = new MGACheckBox();
    this.dsLines = new dsCompanyLines();
    this.chkSupportLossRuns = new MGACheckBox();
    this.chkBlockUIExit = new MGACheckBox();
    this.chkSupportPreIssuanceEndorsementNumbering = new MGACheckBox();
    this.chkInsuredFEINSSN = new MGACheckBox();
    this.lnkAdminCommissions = new LinkLabel();
    this.chkAllowLapseInCoverage = new MGACheckBox();
    this.chkBlockXSPremium = new MGACheckBox();
    this.MgaCheckBox1 = new MGACheckBox();
    this.lnkSignatures = new LinkLabel();
    this.chkUniquePolicyNumbers = new MGACheckBox();
    this.txtBackdateDays = new MGANumericEditor();
    this.Label35 = new Label();
    this.txtBinderExpiration = new MGANumericEditor();
    this.numMinimumEarnedPercentage = new MGANumericEditor();
    this.Label34 = new Label();
    this.Label33 = new Label();
    this.Label14 = new Label();
    this.Label20 = new Label();
    this.cboParent = new MGASimpleComboBox();
    this.Label16 = new Label();
    this.cboCompanyLicensed = new MGASimpleComboBox();
    this.cboCompanySignature = new MGASimpleComboBox();
    this.Label13 = new Label();
    this.cboStatus = new MGASimpleComboBox();
    this.Label2 = new Label();
    this.Label4 = new Label();
    this.Label3 = new Label();
    this.Label1 = new Label();
    this.cbCompanies = new MGASimpleComboBox();
    this.cbLines = new MGASimpleComboBox();
    this.cbStates = new MGASimpleComboBox();
    this.cbLicenseType = new MGASimpleComboBox();
    this.lnkCPF = new LinkLabel();
    this.lnkFCW = new LinkLabel();
    this.dbSave = new MGASystems.Tools.DBSaveUI.DBSaveUI();
    this.lnkDocAuto = new LinkLabel();
    this.UltraTabPageControl5 = new UltraTabPageControl();
    this.cboDefaultFinanceCo = new MGASimpleComboBox();
    this.Label8 = new Label();
    this.GroupBox2 = new UltraGroupBox();
    this.Label7 = new Label();
    this.MgaNumericEditor2 = new MGANumericEditor();
    this.MgaNumericEditor1 = new MGANumericEditor();
    this.chkWaivePremium = new MGACheckBox();
    this.txtInvoiceDays = new MGANumericEditor();
    this.Label31 = new Label();
    this.Label30 = new Label();
    this.GroupBox1 = new UltraGroupBox();
    this.txtNOCGracePeriod = new MGATextBox();
    this.lblNOCGracePeriod = new Label();
    this.chkIncludeFeesNOC = new MGACheckBox();
    this.Label29 = new Label();
    this.txtEmailReminderDays = new MGATextBox();
    this.txtNOCDays = new MGATextBox();
    this.txtMailingDays = new MGATextBox();
    this.chkEmailReminder = new MGACheckBox();
    this.Label28 = new Label();
    this.Label27 = new Label();
    this.chkAutoNOC = new MGACheckBox();
    this.txtDefaultInvoiceComment = new MGATextBox();
    this.Label23 = new Label();
    this.UltraTabPageControl6 = new UltraTabPageControl();
    this.txtQuoteAdditionalComments = new MGATextBox();
    this.Label32 = new Label();
    this.UltraTabPageControl2 = new UltraTabPageControl();
    this.Label5 = new Label();
    this.txtBinderComments = new MGATextBox();
    this.UltraTabPageControl3 = new UltraTabPageControl();
    this.grpRenewalForms = new UltraGroupBox();
    this.chkClearRenewalTemplates = new MGACheckBox();
    this.chkClearRenewalForms = new MGACheckBox();
    this.chkResetSubjectivities = new MGACheckBox();
    this.chkResetFCWRecords = new MGACheckBox();
    this.ToolTip = new ToolTip(this.components);
    this.GroupBox3 = new UltraGroupBox();
    this.cbStateFilter = new MGASimpleComboBox();
    this.cbLineFilter = new MGASimpleComboBox();
    this.cbCompanyFilter = new MGASimpleComboBox();
    this.cnSQL = DefaultDatabase.CreateDbConnection();
    this.DbSelectCommand1 = DefaultDatabase.CreateCommand();
    this.daCompanyLines = DefaultDatabase.CreateDataAdapter();
    this.DbDeleteCommand2 = DefaultDatabase.CreateCommand();
    this.DbInsertCommand2 = DefaultDatabase.CreateCommand();
    this.DbCommand1 = DefaultDatabase.CreateCommand();
    this.DbUpdateCommand2 = DefaultDatabase.CreateCommand();
    this.DbDeleteCommand1 = DefaultDatabase.CreateCommand();
    this.DbInsertCommand1 = DefaultDatabase.CreateCommand();
    this.DbSelectCommand4 = DefaultDatabase.CreateCommand();
    this.DbUpdateCommand1 = DefaultDatabase.CreateCommand();
    this.err = new ErrorProvider(this.components);
    this.Label26 = new Label();
    this.Label25 = new Label();
    this.Label24 = new Label();
    this.ultraTab = new UltraTabControl();
    this.UltraTabSharedControlsPage1 = new UltraTabSharedControlsPage();
    this.DbSelectCommand2 = DefaultDatabase.CreateCommand();
    this.daGetCompanyLine = DefaultDatabase.CreateDataAdapter();
    this.DbSelectCommand3 = DefaultDatabase.CreateCommand();
    this.lnkApplyFilter = new LinkLabel();
    this.panelLoading = new UltraGroupBox();
    this.Label6 = new Label();
    this.PictureBox1 = new PictureBox();
    this._frmCompanyLines_Toolbars_Dock_Area_Left = new UltraToolbarsDockArea();
    this.menumanager = new UltraToolbarsManager(this.components);
    this.dgView = new UltraGrid();
    this._frmCompanyLines_Toolbars_Dock_Area_Right = new UltraToolbarsDockArea();
    this._frmCompanyLines_Toolbars_Dock_Area_Top = new UltraToolbarsDockArea();
    this._frmCompanyLines_Toolbars_Dock_Area_Bottom = new UltraToolbarsDockArea();
    this.chkHideInactive = new MGACheckBox();
    ((Control) this.UltraTabPageControl1).SuspendLayout();
    this.grpCompanyLineFiling.SuspendLayout();
    ((ISupportInitialize) this.chkKeepPolicyNumberOnRewrite).BeginInit();
    this.dsLines.BeginInit();
    ((ISupportInitialize) this.chkSupportLossRuns).BeginInit();
    ((ISupportInitialize) this.chkBlockUIExit).BeginInit();
    ((ISupportInitialize) this.chkSupportPreIssuanceEndorsementNumbering).BeginInit();
    ((ISupportInitialize) this.chkInsuredFEINSSN).BeginInit();
    ((ISupportInitialize) this.chkAllowLapseInCoverage).BeginInit();
    ((ISupportInitialize) this.chkBlockXSPremium).BeginInit();
    ((ISupportInitialize) this.MgaCheckBox1).BeginInit();
    ((ISupportInitialize) this.chkUniquePolicyNumbers).BeginInit();
    ((ISupportInitialize) this.txtBackdateDays).BeginInit();
    ((ISupportInitialize) this.txtBinderExpiration).BeginInit();
    ((ISupportInitialize) this.numMinimumEarnedPercentage).BeginInit();
    ((ISupportInitialize) this.cboParent).BeginInit();
    ((ISupportInitialize) this.cboCompanyLicensed).BeginInit();
    ((ISupportInitialize) this.cboCompanySignature).BeginInit();
    ((ISupportInitialize) this.cboStatus).BeginInit();
    ((ISupportInitialize) this.cbCompanies).BeginInit();
    ((ISupportInitialize) this.cbLines).BeginInit();
    ((ISupportInitialize) this.cbStates).BeginInit();
    ((ISupportInitialize) this.cbLicenseType).BeginInit();
    ((Control) this.UltraTabPageControl5).SuspendLayout();
    ((ISupportInitialize) this.cboDefaultFinanceCo).BeginInit();
    ((ISupportInitialize) this.GroupBox2).BeginInit();
    ((Control) this.GroupBox2).SuspendLayout();
    ((ISupportInitialize) this.MgaNumericEditor2).BeginInit();
    ((ISupportInitialize) this.MgaNumericEditor1).BeginInit();
    ((ISupportInitialize) this.chkWaivePremium).BeginInit();
    ((ISupportInitialize) this.txtInvoiceDays).BeginInit();
    ((ISupportInitialize) this.GroupBox1).BeginInit();
    ((Control) this.GroupBox1).SuspendLayout();
    ((ISupportInitialize) this.txtNOCGracePeriod).BeginInit();
    ((ISupportInitialize) this.chkIncludeFeesNOC).BeginInit();
    ((ISupportInitialize) this.txtEmailReminderDays).BeginInit();
    ((ISupportInitialize) this.txtNOCDays).BeginInit();
    ((ISupportInitialize) this.txtMailingDays).BeginInit();
    ((ISupportInitialize) this.chkEmailReminder).BeginInit();
    ((ISupportInitialize) this.chkAutoNOC).BeginInit();
    ((ISupportInitialize) this.txtDefaultInvoiceComment).BeginInit();
    ((Control) this.UltraTabPageControl6).SuspendLayout();
    ((ISupportInitialize) this.txtQuoteAdditionalComments).BeginInit();
    ((Control) this.UltraTabPageControl2).SuspendLayout();
    ((ISupportInitialize) this.txtBinderComments).BeginInit();
    ((Control) this.UltraTabPageControl3).SuspendLayout();
    ((ISupportInitialize) this.grpRenewalForms).BeginInit();
    ((Control) this.grpRenewalForms).SuspendLayout();
    ((ISupportInitialize) this.chkClearRenewalTemplates).BeginInit();
    ((ISupportInitialize) this.chkClearRenewalForms).BeginInit();
    ((ISupportInitialize) this.chkResetSubjectivities).BeginInit();
    ((ISupportInitialize) this.chkResetFCWRecords).BeginInit();
    ((ISupportInitialize) this.GroupBox3).BeginInit();
    ((ISupportInitialize) this.cbStateFilter).BeginInit();
    ((ISupportInitialize) this.cbLineFilter).BeginInit();
    ((ISupportInitialize) this.cbCompanyFilter).BeginInit();
    ((ISupportInitialize) this.err).BeginInit();
    ((ISupportInitialize) this.ultraTab).BeginInit();
    ((Control) this.ultraTab).SuspendLayout();
    ((Control) this.UltraTabSharedControlsPage1).SuspendLayout();
    ((ISupportInitialize) this.panelLoading).BeginInit();
    ((Control) this.panelLoading).SuspendLayout();
    ((ISupportInitialize) this.PictureBox1).BeginInit();
    ((ISupportInitialize) this.menumanager).BeginInit();
    ((ISupportInitialize) this.dgView).BeginInit();
    ((ISupportInitialize) this.chkHideInactive).BeginInit();
    this.SuspendLayout();
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.grpCompanyLineFiling);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.chkKeepPolicyNumberOnRewrite);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.chkSupportLossRuns);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.chkBlockUIExit);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.chkSupportPreIssuanceEndorsementNumbering);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.chkInsuredFEINSSN);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.lnkAdminCommissions);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.chkAllowLapseInCoverage);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.chkBlockXSPremium);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.MgaCheckBox1);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.lnkSignatures);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.chkUniquePolicyNumbers);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.txtBackdateDays);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label35);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.txtBinderExpiration);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.numMinimumEarnedPercentage);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label34);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label33);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label14);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label20);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.cboParent);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label16);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.cboCompanyLicensed);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.cboCompanySignature);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label13);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.cboStatus);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label2);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label4);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label3);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label1);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.cbCompanies);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.cbLines);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.cbStates);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.cbLicenseType);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.lnkCPF);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.lnkFCW);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.dbSave);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.lnkDocAuto);
    ((Control) this.UltraTabPageControl1).Location = new Point(1, 26);
    ((Control) this.UltraTabPageControl1).Name = "UltraTabPageControl1";
    ((Control) this.UltraTabPageControl1).Size = new Size(782, 247);
    this.grpCompanyLineFiling.BackColor = Color.Transparent;
    this.grpCompanyLineFiling.Controls.Add((Control) this.rbNone);
    this.grpCompanyLineFiling.Controls.Add((Control) this.rbInside);
    this.grpCompanyLineFiling.Controls.Add((Control) this.rbOutside);
    this.grpCompanyLineFiling.Location = new Point(13, 204);
    this.grpCompanyLineFiling.Name = "grpCompanyLineFiling";
    this.grpCompanyLineFiling.Size = new Size(210, 40);
    this.grpCompanyLineFiling.TabIndex = 49;
    this.grpCompanyLineFiling.TabStop = false;
    this.grpCompanyLineFiling.Text = "Filing";
    this.rbNone.AutoSize = true;
    this.rbNone.Location = new Point(153, 16 /*0x10*/);
    this.rbNone.Name = "rbNone";
    this.rbNone.Size = new Size(50, 17);
    this.rbNone.TabIndex = 2;
    this.rbNone.TabStop = true;
    this.rbNone.Text = "None";
    this.rbNone.UseVisualStyleBackColor = true;
    this.rbInside.AutoSize = true;
    this.rbInside.Location = new Point(76, 16 /*0x10*/);
    this.rbInside.Name = "rbInside";
    this.rbInside.Size = new Size(69, 17);
    this.rbInside.TabIndex = 1;
    this.rbInside.TabStop = true;
    this.rbInside.Text = "In-House";
    this.rbInside.UseVisualStyleBackColor = true;
    this.rbOutside.AutoSize = true;
    this.rbOutside.Location = new Point(6, 16 /*0x10*/);
    this.rbOutside.Name = "rbOutside";
    this.rbOutside.Size = new Size(62, 17);
    this.rbOutside.TabIndex = 0;
    this.rbOutside.TabStop = true;
    this.rbOutside.Text = "Outside";
    this.rbOutside.UseVisualStyleBackColor = true;
    appearance1.BorderColor = Color.Gray;
    appearance1.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkKeepPolicyNumberOnRewrite).Appearance = (AppearanceBase) appearance1;
    ((UltraToggleEditorBase) this.chkKeepPolicyNumberOnRewrite).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkKeepPolicyNumberOnRewrite).BackColorInternal = Color.Transparent;
    ((Control) this.chkKeepPolicyNumberOnRewrite).DataBindings.Add(new Binding("Checked", (object) this.dsLines, "tblCompanyLines.KeepPolicyNumberOnRewrites", true));
    ((UltraToggleEditorBase) this.chkKeepPolicyNumberOnRewrite).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkKeepPolicyNumberOnRewrite).Location = new Point(557, 151);
    ((Control) this.chkKeepPolicyNumberOnRewrite).Name = "chkKeepPolicyNumberOnRewrite";
    ((Control) this.chkKeepPolicyNumberOnRewrite).Size = new Size(148, 15);
    ((Control) this.chkKeepPolicyNumberOnRewrite).TabIndex = 47;
    ((UltraToggleEditorBase) this.chkKeepPolicyNumberOnRewrite).Text = "Keep Policy # on Rewrites";
    ((UltraControlBase) this.chkKeepPolicyNumberOnRewrite).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkKeepPolicyNumberOnRewrite).UseOsThemes = (DefaultableBoolean) 2;
    this.dsLines.DataSetName = "dsCompanyLines";
    this.dsLines.Locale = new CultureInfo("en-US");
    this.dsLines.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    appearance2.BorderColor = Color.Gray;
    appearance2.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkSupportLossRuns).Appearance = (AppearanceBase) appearance2;
    ((UltraToggleEditorBase) this.chkSupportLossRuns).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkSupportLossRuns).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkSupportLossRuns).Checked = true;
    ((UltraToggleEditorBase) this.chkSupportLossRuns).CheckState = CheckState.Checked;
    ((Control) this.chkSupportLossRuns).DataBindings.Add(new Binding("Checked", (object) this.dsLines, "tblCompanyLines.SupportLossRuns", true));
    ((UltraToggleEditorBase) this.chkSupportLossRuns).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkSupportLossRuns).Location = new Point(557, 133);
    ((Control) this.chkSupportLossRuns).Name = "chkSupportLossRuns";
    ((Control) this.chkSupportLossRuns).Size = new Size(120, 15);
    ((Control) this.chkSupportLossRuns).TabIndex = 46;
    ((UltraToggleEditorBase) this.chkSupportLossRuns).Text = "Support Loss Runs";
    ((UltraControlBase) this.chkSupportLossRuns).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkSupportLossRuns).UseOsThemes = (DefaultableBoolean) 2;
    appearance3.BorderColor = Color.Gray;
    appearance3.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkBlockUIExit).Appearance = (AppearanceBase) appearance3;
    ((UltraToggleEditorBase) this.chkBlockUIExit).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkBlockUIExit).BackColorInternal = Color.Transparent;
    ((Control) this.chkBlockUIExit).DataBindings.Add(new Binding("Checked", (object) this.dsLines, "tblCompanyLines.BlockUIExitOnBlankRenewalInformation", true));
    ((UltraToggleEditorBase) this.chkBlockUIExit).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkBlockUIExit).Location = new Point(70, 189);
    ((Control) this.chkBlockUIExit).Name = "chkBlockUIExit";
    ((Control) this.chkBlockUIExit).Size = new Size(189, 16 /*0x10*/);
    ((Control) this.chkBlockUIExit).TabIndex = 45;
    ((UltraToggleEditorBase) this.chkBlockUIExit).Text = "Quote Renewal Info Mandatory";
    this.ToolTip.SetToolTip((Control) this.chkBlockUIExit, "When checked, prevents Policy Edit screen from exiting if Exprirng Carrier is not selected");
    ((UltraControlBase) this.chkBlockUIExit).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkBlockUIExit).UseOsThemes = (DefaultableBoolean) 2;
    appearance4.BorderColor = Color.Gray;
    appearance4.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkSupportPreIssuanceEndorsementNumbering).Appearance = (AppearanceBase) appearance4;
    ((UltraToggleEditorBase) this.chkSupportPreIssuanceEndorsementNumbering).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkSupportPreIssuanceEndorsementNumbering).BackColorInternal = Color.Transparent;
    ((Control) this.chkSupportPreIssuanceEndorsementNumbering).DataBindings.Add(new Binding("Checked", (object) this.dsLines, "tblCompanyLines.SupportPreIssuanceEndorsementNumbering", true));
    ((UltraToggleEditorBase) this.chkSupportPreIssuanceEndorsementNumbering).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkSupportPreIssuanceEndorsementNumbering).Location = new Point(301, 169);
    ((Control) this.chkSupportPreIssuanceEndorsementNumbering).Name = "chkSupportPreIssuanceEndorsementNumbering";
    ((Control) this.chkSupportPreIssuanceEndorsementNumbering).Size = new Size(254, 15);
    ((Control) this.chkSupportPreIssuanceEndorsementNumbering).TabIndex = 41;
    ((UltraToggleEditorBase) this.chkSupportPreIssuanceEndorsementNumbering).Text = "Support Pre-Issuance Endorsement Numbering";
    ((UltraControlBase) this.chkSupportPreIssuanceEndorsementNumbering).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkSupportPreIssuanceEndorsementNumbering).UseOsThemes = (DefaultableBoolean) 2;
    appearance5.BorderColor = Color.Gray;
    appearance5.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkInsuredFEINSSN).Appearance = (AppearanceBase) appearance5;
    ((UltraToggleEditorBase) this.chkInsuredFEINSSN).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkInsuredFEINSSN).BackColorInternal = Color.Transparent;
    ((Control) this.chkInsuredFEINSSN).DataBindings.Add(new Binding("Checked", (object) this.dsLines, "tblCompanyLines.InsuredFEINSSNRequiredOnBind", true));
    ((UltraToggleEditorBase) this.chkInsuredFEINSSN).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkInsuredFEINSSN).Location = new Point(301, 151);
    ((Control) this.chkInsuredFEINSSN).Name = "chkInsuredFEINSSN";
    ((Control) this.chkInsuredFEINSSN).Size = new Size(230, 15);
    ((Control) this.chkInsuredFEINSSN).TabIndex = 40;
    ((UltraToggleEditorBase) this.chkInsuredFEINSSN).Text = "Insured's FEIN or SSN Required on Binding";
    ((UltraControlBase) this.chkInsuredFEINSSN).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkInsuredFEINSSN).UseOsThemes = (DefaultableBoolean) 2;
    this.lnkAdminCommissions.BackColor = Color.Transparent;
    this.lnkAdminCommissions.Location = new Point(551, 86);
    this.lnkAdminCommissions.Name = "lnkAdminCommissions";
    this.lnkAdminCommissions.Size = new Size(121, 14);
    this.lnkAdminCommissions.TabIndex = 39;
    this.lnkAdminCommissions.TabStop = true;
    this.lnkAdminCommissions.Text = "Configure Commissions";
    appearance6.BorderColor = Color.Gray;
    appearance6.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkAllowLapseInCoverage).Appearance = (AppearanceBase) appearance6;
    ((UltraToggleEditorBase) this.chkAllowLapseInCoverage).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkAllowLapseInCoverage).BackColorInternal = Color.Transparent;
    ((Control) this.chkAllowLapseInCoverage).DataBindings.Add(new Binding("Checked", (object) this.dsLines, "tblCompanyLines.AllowLapseOnRenewal", true));
    ((UltraToggleEditorBase) this.chkAllowLapseInCoverage).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkAllowLapseInCoverage).Location = new Point(301, 133);
    ((Control) this.chkAllowLapseInCoverage).Name = "chkAllowLapseInCoverage";
    ((Control) this.chkAllowLapseInCoverage).Size = new Size(201, 15);
    ((Control) this.chkAllowLapseInCoverage).TabIndex = 38;
    ((UltraToggleEditorBase) this.chkAllowLapseInCoverage).Text = "Allow Lapse in Coverage on Renewal";
    ((UltraControlBase) this.chkAllowLapseInCoverage).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkAllowLapseInCoverage).UseOsThemes = (DefaultableBoolean) 2;
    appearance7.BorderColor = Color.Gray;
    appearance7.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkBlockXSPremium).Appearance = (AppearanceBase) appearance7;
    ((UltraToggleEditorBase) this.chkBlockXSPremium).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkBlockXSPremium).BackColorInternal = Color.Transparent;
    ((Control) this.chkBlockXSPremium).DataBindings.Add(new Binding("Checked", (object) this.dsLines, "tblCompanyLines.BlockXSPremium", true));
    ((UltraToggleEditorBase) this.chkBlockXSPremium).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkBlockXSPremium).Location = new Point(70, 151);
    ((Control) this.chkBlockXSPremium).Name = "chkBlockXSPremium";
    ((Control) this.chkBlockXSPremium).Size = new Size(170, 15);
    ((Control) this.chkBlockXSPremium).TabIndex = 37;
    ((UltraToggleEditorBase) this.chkBlockXSPremium).Text = "Block Addition of XS Premium";
    this.ToolTip.SetToolTip((Control) this.chkBlockXSPremium, "When checked, it prevents any excess premium from by entered.");
    ((UltraControlBase) this.chkBlockXSPremium).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkBlockXSPremium).UseOsThemes = (DefaultableBoolean) 2;
    appearance8.BorderColor = Color.Gray;
    appearance8.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.MgaCheckBox1).Appearance = (AppearanceBase) appearance8;
    ((UltraToggleEditorBase) this.MgaCheckBox1).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.MgaCheckBox1).BackColorInternal = Color.Transparent;
    ((Control) this.MgaCheckBox1).DataBindings.Add(new Binding("Checked", (object) this.dsLines, "tblCompanyLines.AllowEndorsementsWithoutIssuance", true));
    ((UltraToggleEditorBase) this.MgaCheckBox1).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.MgaCheckBox1).Location = new Point(70, 133);
    ((Control) this.MgaCheckBox1).Name = "MgaCheckBox1";
    ((Control) this.MgaCheckBox1).Size = new Size(210, 15);
    ((Control) this.MgaCheckBox1).TabIndex = 35;
    ((UltraToggleEditorBase) this.MgaCheckBox1).Text = "Allow Endorsements Without Issuance";
    this.ToolTip.SetToolTip((Control) this.MgaCheckBox1, "Prevents the commission values from being changed when quotes are created.");
    ((UltraControlBase) this.MgaCheckBox1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaCheckBox1).UseOsThemes = (DefaultableBoolean) 2;
    this.lnkSignatures.BackColor = Color.Transparent;
    this.lnkSignatures.Location = new Point(468, 86);
    this.lnkSignatures.Name = "lnkSignatures";
    this.lnkSignatures.Size = new Size(77, 14);
    this.lnkSignatures.TabIndex = 34;
    this.lnkSignatures.TabStop = true;
    this.lnkSignatures.Text = "Signatures...";
    appearance9.BorderColor = Color.Gray;
    appearance9.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkUniquePolicyNumbers).Appearance = (AppearanceBase) appearance9;
    ((UltraToggleEditorBase) this.chkUniquePolicyNumbers).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkUniquePolicyNumbers).BackColorInternal = Color.Transparent;
    ((Control) this.chkUniquePolicyNumbers).DataBindings.Add(new Binding("Checked", (object) this.dsLines, "tblCompanyLines.EnforceUniquePolicyNumbers", true));
    ((UltraToggleEditorBase) this.chkUniquePolicyNumbers).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkUniquePolicyNumbers).Location = new Point(70, 169);
    ((Control) this.chkUniquePolicyNumbers).Name = "chkUniquePolicyNumbers";
    ((Control) this.chkUniquePolicyNumbers).Size = new Size(189, 17);
    ((Control) this.chkUniquePolicyNumbers).TabIndex = 33;
    ((UltraToggleEditorBase) this.chkUniquePolicyNumbers).Text = "Enforce Unique Policy Numbers";
    this.ToolTip.SetToolTip((Control) this.chkUniquePolicyNumbers, "Prevents the commission values from being changed when quotes are created.");
    ((UltraControlBase) this.chkUniquePolicyNumbers).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkUniquePolicyNumbers).UseOsThemes = (DefaultableBoolean) 2;
    appearance10.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.txtBackdateDays).Appearance = (AppearanceBase) appearance10;
    ((Control) this.txtBackdateDays).DataBindings.Add(new Binding("Value", (object) this.dsLines, "tblCompanyLines.MaxBackdateDays", true));
    ((Control) this.txtBackdateDays).Location = new Point(595, 60);
    this.txtBackdateDays.MaskInput = "nnn";
    this.txtBackdateDays.MaxValue = (object) 999;
    this.txtBackdateDays.MGAStyle = MGAStyles.Blue;
    this.txtBackdateDays.MinValue = (object) 0;
    ((Control) this.txtBackdateDays).Name = "txtBackdateDays";
    this.txtBackdateDays.Nullable = true;
    ((UltraNumericEditorBase) this.txtBackdateDays).PromptChar = ' ';
    ((Control) this.txtBackdateDays).Size = new Size(56, 20);
    ((Control) this.txtBackdateDays).TabIndex = 32 /*0x20*/;
    ((UltraControlBase) this.txtBackdateDays).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtBackdateDays).UseOsThemes = (DefaultableBoolean) 2;
    this.Label35.AutoSize = true;
    this.Label35.BackColor = Color.Transparent;
    this.Label35.ForeColor = Color.Black;
    this.Label35.Location = new Point(483, 62);
    this.Label35.Name = "Label35";
    this.Label35.Size = new Size(109, 13);
    this.Label35.TabIndex = 31 /*0x1F*/;
    this.Label35.Text = "Max. Backdate Days:";
    this.Label35.TextAlign = ContentAlignment.MiddleRight;
    appearance11.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.txtBinderExpiration).Appearance = (AppearanceBase) appearance11;
    ((Control) this.txtBinderExpiration).DataBindings.Add(new Binding("Value", (object) this.dsLines, "tblCompanyLines.BinderExpirationDays", true));
    ((Control) this.txtBinderExpiration).Location = new Point(595, 14);
    this.txtBinderExpiration.MaskInput = "nnn";
    this.txtBinderExpiration.MaxValue = (object) 256 /*0x0100*/;
    this.txtBinderExpiration.MGAStyle = MGAStyles.Blue;
    this.txtBinderExpiration.MinValue = (object) 1;
    ((Control) this.txtBinderExpiration).Name = "txtBinderExpiration";
    this.txtBinderExpiration.Nullable = true;
    ((UltraNumericEditorBase) this.txtBinderExpiration).PromptChar = ' ';
    ((Control) this.txtBinderExpiration).Size = new Size(56, 20);
    ((Control) this.txtBinderExpiration).TabIndex = 30;
    ((UltraControlBase) this.txtBinderExpiration).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtBinderExpiration).UseOsThemes = (DefaultableBoolean) 2;
    appearance12.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.numMinimumEarnedPercentage).Appearance = (AppearanceBase) appearance12;
    ((Control) this.numMinimumEarnedPercentage).DataBindings.Add(new Binding("Value", (object) this.dsLines, "tblCompanyLines.MinimumEarnedPercentage", true));
    ((UltraNumericEditorBase) this.numMinimumEarnedPercentage).FormatString = "p";
    ((Control) this.numMinimumEarnedPercentage).Location = new Point(595, 37);
    this.numMinimumEarnedPercentage.MaskInput = "nnn.nnn";
    this.numMinimumEarnedPercentage.MaxValue = (object) 1;
    this.numMinimumEarnedPercentage.MGAStyle = MGAStyles.Blue;
    this.numMinimumEarnedPercentage.MinValue = (object) 0.001;
    ((Control) this.numMinimumEarnedPercentage).Name = "numMinimumEarnedPercentage";
    this.numMinimumEarnedPercentage.Nullable = true;
    this.numMinimumEarnedPercentage.NumericType = (NumericType) 1;
    ((UltraNumericEditorBase) this.numMinimumEarnedPercentage).PromptChar = ' ';
    ((Control) this.numMinimumEarnedPercentage).Size = new Size(56, 20);
    ((Control) this.numMinimumEarnedPercentage).TabIndex = 29;
    ((UltraWinEditorMaskedControlBase) this.numMinimumEarnedPercentage).TabNavigation = (MaskedEditTabNavigation) 0;
    ((UltraControlBase) this.numMinimumEarnedPercentage).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numMinimumEarnedPercentage).UseOsThemes = (DefaultableBoolean) 2;
    this.Label34.AutoSize = true;
    this.Label34.BackColor = Color.Transparent;
    this.Label34.ForeColor = Color.Black;
    this.Label34.Location = new Point(483, 39);
    this.Label34.Name = "Label34";
    this.Label34.Size = new Size(102, 13);
    this.Label34.TabIndex = 28;
    this.Label34.Text = "Minimum Earned %:";
    this.Label34.TextAlign = ContentAlignment.MiddleRight;
    this.Label33.AutoSize = true;
    this.Label33.BackColor = Color.Transparent;
    this.Label33.ForeColor = Color.Black;
    this.Label33.Location = new Point(497, 16 /*0x10*/);
    this.Label33.Name = "Label33";
    this.Label33.Size = new Size(92, 13);
    this.Label33.TabIndex = 26;
    this.Label33.Text = "Binder Expiration:";
    this.Label33.TextAlign = ContentAlignment.MiddleRight;
    this.Label14.BackColor = Color.Transparent;
    this.Label14.ForeColor = Color.Black;
    this.Label14.Location = new Point(238, 86);
    this.Label14.Name = "Label14";
    this.Label14.Size = new Size(56, 14);
    this.Label14.TabIndex = 19;
    this.Label14.Text = "Signature";
    this.Label14.TextAlign = ContentAlignment.MiddleRight;
    this.Label20.BackColor = Color.Transparent;
    this.Label20.ForeColor = Color.Black;
    this.Label20.Location = new Point(7, 109);
    this.Label20.Name = "Label20";
    this.Label20.Size = new Size(56, 14);
    this.Label20.TabIndex = 25;
    this.Label20.Text = "Licensed:";
    this.Label20.TextAlign = ContentAlignment.MiddleRight;
    this.cboParent.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboParent).DataBindings.Add(new Binding("Value", (object) this.dsLines, "tblCompanyLines.ParentCompanyLineGuid", true));
    ((UltraGridBase) this.cboParent).DataSource = (object) this.dsLines.Parents;
    ((UltraDropDownBase) this.cboParent).DisplayMember = "Parent";
    this.cboParent.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboParent).DropDownWidth = 600;
    ((Control) this.cboParent).Location = new Point(70, 83);
    this.cboParent.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboParent).Name = "cboParent";
    ((Control) this.cboParent).Size = new Size(161, 21);
    ((Control) this.cboParent).TabIndex = 3;
    ((UltraControlBase) this.cboParent).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboParent).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboParent).ValueMember = "CompanyLineGuid";
    this.Label16.BackColor = Color.Transparent;
    this.Label16.ForeColor = Color.Black;
    this.Label16.Location = new Point(21, 86);
    this.Label16.Name = "Label16";
    this.Label16.Size = new Size(42, 14);
    this.Label16.TabIndex = 21;
    this.Label16.Text = "Parent:";
    this.Label16.TextAlign = ContentAlignment.MiddleRight;
    this.cboCompanyLicensed.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboCompanyLicensed).DataBindings.Add(new Binding("Value", (object) this.dsLines, "tblCompanyLines.CompanyLicenseTypeID", true));
    ((UltraGridBase) this.cboCompanyLicensed).DataSource = (object) this.dsLines.lstCompanyLicenseTypes;
    ((UltraDropDownBase) this.cboCompanyLicensed).DisplayMember = "CompanyLicenceType";
    this.cboCompanyLicensed.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboCompanyLicensed).Location = new Point(70, 106);
    this.cboCompanyLicensed.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboCompanyLicensed).Name = "cboCompanyLicensed";
    ((Control) this.cboCompanyLicensed).Size = new Size(161, 21);
    ((Control) this.cboCompanyLicensed).TabIndex = 4;
    ((UltraControlBase) this.cboCompanyLicensed).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboCompanyLicensed).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboCompanyLicensed).ValueMember = "CompanyLicenceTypeID";
    this.cboCompanySignature.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboCompanySignature).DataBindings.Add(new Binding("Value", (object) this.dsLines, "tblCompanyLines.UserSignatureGuid", true));
    ((UltraGridBase) this.cboCompanySignature).DataSource = (object) this.dsLines.tblUsers;
    ((UltraDropDownBase) this.cboCompanySignature).DisplayMember = "UserName";
    this.cboCompanySignature.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboCompanySignature).Location = new Point(301, 83);
    this.cboCompanySignature.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboCompanySignature).Name = "cboCompanySignature";
    ((Control) this.cboCompanySignature).Size = new Size(161, 21);
    ((Control) this.cboCompanySignature).TabIndex = 7;
    ((UltraControlBase) this.cboCompanySignature).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboCompanySignature).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboCompanySignature).ValueMember = "UserGuid";
    this.Label13.BackColor = Color.Transparent;
    this.Label13.ForeColor = Color.Black;
    this.Label13.Location = new Point(245, 63 /*0x3F*/);
    this.Label13.Name = "Label13";
    this.Label13.Size = new Size(48 /*0x30*/, 14);
    this.Label13.TabIndex = 17;
    this.Label13.Text = "Status";
    this.Label13.TextAlign = ContentAlignment.MiddleRight;
    this.cboStatus.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboStatus).DataBindings.Add(new Binding("Value", (object) this.dsLines, "tblCompanyLines.StatusID", true));
    ((UltraGridBase) this.cboStatus).DataSource = (object) this.dsLines.lstStatus;
    ((UltraDropDownBase) this.cboStatus).DisplayMember = "Status";
    this.cboStatus.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboStatus).Location = new Point(301, 60);
    this.cboStatus.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboStatus).Name = "cboStatus";
    ((Control) this.cboStatus).Size = new Size(161, 21);
    ((Control) this.cboStatus).TabIndex = 6;
    ((UltraControlBase) this.cboStatus).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboStatus).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboStatus).ValueMember = "StatusID";
    this.Label2.BackColor = Color.Transparent;
    this.Label2.ForeColor = Color.Black;
    this.Label2.Location = new Point(245, 109);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(48 /*0x30*/, 14);
    this.Label2.TabIndex = 13;
    this.Label2.Text = "Lic. Req.";
    this.Label2.TextAlign = ContentAlignment.MiddleRight;
    this.Label4.BackColor = Color.Transparent;
    this.Label4.ForeColor = Color.Black;
    this.Label4.Location = new Point(21, 63 /*0x3F*/);
    this.Label4.Name = "Label4";
    this.Label4.Size = new Size(42, 14);
    this.Label4.TabIndex = 11;
    this.Label4.Text = "State:";
    this.Label4.TextAlign = ContentAlignment.MiddleRight;
    this.Label3.BackColor = Color.Transparent;
    this.Label3.ForeColor = Color.Black;
    this.Label3.Location = new Point(21, 40);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(42, 14);
    this.Label3.TabIndex = 10;
    this.Label3.Text = "Line:";
    this.Label3.TextAlign = ContentAlignment.MiddleRight;
    this.Label1.BackColor = Color.Transparent;
    this.Label1.ForeColor = Color.Black;
    this.Label1.Location = new Point(7, 17);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(56, 14);
    this.Label1.TabIndex = 3;
    this.Label1.Text = "Company:";
    this.Label1.TextAlign = ContentAlignment.MiddleRight;
    this.cbCompanies.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cbCompanies).DataBindings.Add(new Binding("Value", (object) this.dsLines, "tblCompanyLines.CompanyLocationGuid", true));
    ((UltraGridBase) this.cbCompanies).DataSource = (object) this.dsLines.tblCompanyLocations;
    ((UltraDropDownBase) this.cbCompanies).DisplayMember = "Name";
    this.cbCompanies.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cbCompanies).DropDownWidth = 550;
    ((Control) this.cbCompanies).Location = new Point(70, 14);
    this.cbCompanies.MGAStyle = MGAStyles.Blue;
    ((Control) this.cbCompanies).Name = "cbCompanies";
    ((Control) this.cbCompanies).Size = new Size(392, 21);
    ((Control) this.cbCompanies).TabIndex = 0;
    ((UltraControlBase) this.cbCompanies).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cbCompanies).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cbCompanies).ValueMember = "CompanyLocationGuid";
    this.cbLines.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cbLines).DataBindings.Add(new Binding("Value", (object) this.dsLines, "tblCompanyLines.LineGuid", true));
    ((UltraGridBase) this.cbLines).DataSource = (object) this.dsLines.lstLines;
    ((UltraDropDownBase) this.cbLines).DisplayMember = "LineName";
    this.cbLines.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cbLines).DropDownWidth = 300;
    ((Control) this.cbLines).Location = new Point(70, 37);
    this.cbLines.MGAStyle = MGAStyles.Blue;
    ((Control) this.cbLines).Name = "cbLines";
    ((Control) this.cbLines).Size = new Size(392, 21);
    ((Control) this.cbLines).TabIndex = 1;
    ((UltraControlBase) this.cbLines).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cbLines).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cbLines).ValueMember = "LineGuid";
    this.cbStates.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cbStates).DataBindings.Add(new Binding("Value", (object) this.dsLines, "tblCompanyLines.StateID", true));
    ((UltraGridBase) this.cbStates).DataSource = (object) this.dsLines.lstStates;
    ((UltraDropDownBase) this.cbStates).DisplayMember = "State";
    this.cbStates.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cbStates).Location = new Point(70, 60);
    this.cbStates.MGAStyle = MGAStyles.Blue;
    ((Control) this.cbStates).Name = "cbStates";
    ((Control) this.cbStates).Size = new Size(161, 21);
    ((Control) this.cbStates).TabIndex = 2;
    ((UltraControlBase) this.cbStates).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cbStates).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cbStates).ValueMember = "StateID";
    this.cbLicenseType.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cbLicenseType).DataBindings.Add(new Binding("Value", (object) this.dsLines, "tblCompanyLines.LicenseTypeID", true));
    ((UltraGridBase) this.cbLicenseType).DataSource = (object) this.dsLines.lstLicenseTypes;
    ((UltraDropDownBase) this.cbLicenseType).DisplayMember = "LicenseType";
    this.cbLicenseType.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cbLicenseType).DropDownWidth = 250;
    ((Control) this.cbLicenseType).Location = new Point(301, 106);
    this.cbLicenseType.MGAStyle = MGAStyles.Blue;
    ((Control) this.cbLicenseType).Name = "cbLicenseType";
    ((Control) this.cbLicenseType).Size = new Size(161, 21);
    ((Control) this.cbLicenseType).TabIndex = 5;
    ((UltraControlBase) this.cbLicenseType).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cbLicenseType).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cbLicenseType).ValueMember = "LicenseTypeID";
    this.lnkCPF.BackColor = Color.Transparent;
    this.lnkCPF.Location = new Point(426, 224 /*0xE0*/);
    this.lnkCPF.Name = "lnkCPF";
    this.lnkCPF.Size = new Size(129, 14);
    this.lnkCPF.TabIndex = 44;
    this.lnkCPF.TabStop = true;
    this.lnkCPF.Text = "Conditional Policy Forms";
    this.lnkFCW.BackColor = Color.Transparent;
    this.lnkFCW.Location = new Point(382, 224 /*0xE0*/);
    this.lnkFCW.Name = "lnkFCW";
    this.lnkFCW.Size = new Size(31 /*0x1F*/, 14);
    this.lnkFCW.TabIndex = 43;
    this.lnkFCW.TabStop = true;
    this.lnkFCW.Text = "FCW";
    this.ToolTip.SetToolTip((Control) this.lnkFCW, "Forms / Conditions / Warranties ...");
    this.dbSave.AutoQueryRowCountOnLoad = false;
    this.dbSave.EditStyle = EditStyle.ShowEditButton;
    this.dbSave.FreezeEvents = false;
    this.dbSave.Location = new Point(667, 198);
    this.dbSave.Name = "dbSave";
    this.dbSave.Size = new Size(112 /*0x70*/, 40);
    this.dbSave.TabIndex = 13;
    this.lnkDocAuto.BackColor = Color.Transparent;
    this.lnkDocAuto.Location = new Point(250, 224 /*0xE0*/);
    this.lnkDocAuto.Name = "lnkDocAuto";
    this.lnkDocAuto.Size = new Size(119, 14);
    this.lnkDocAuto.TabIndex = 42;
    this.lnkDocAuto.TabStop = true;
    this.lnkDocAuto.Text = "Document Automation";
    ((Control) this.UltraTabPageControl5).Controls.Add((Control) this.cboDefaultFinanceCo);
    ((Control) this.UltraTabPageControl5).Controls.Add((Control) this.Label8);
    ((Control) this.UltraTabPageControl5).Controls.Add((Control) this.GroupBox2);
    ((Control) this.UltraTabPageControl5).Controls.Add((Control) this.GroupBox1);
    ((Control) this.UltraTabPageControl5).Controls.Add((Control) this.txtDefaultInvoiceComment);
    ((Control) this.UltraTabPageControl5).Controls.Add((Control) this.Label23);
    ((Control) this.UltraTabPageControl5).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabPageControl5).Name = "UltraTabPageControl5";
    ((Control) this.UltraTabPageControl5).Size = new Size(782, 247);
    this.cboDefaultFinanceCo.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboDefaultFinanceCo).DataBindings.Add(new Binding("Value", (object) this.dsLines, "tblCompanyLines.DefaultFinanceGUID", true));
    ((UltraGridBase) this.cboDefaultFinanceCo).DataSource = (object) this.dsLines.FinanceCompanies;
    ((UltraDropDownBase) this.cboDefaultFinanceCo).DisplayMember = "PayeeName";
    this.cboDefaultFinanceCo.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboDefaultFinanceCo).DropDownWidth = 600;
    ((Control) this.cboDefaultFinanceCo).Location = new Point(147, 198);
    this.cboDefaultFinanceCo.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboDefaultFinanceCo).Name = "cboDefaultFinanceCo";
    ((Control) this.cboDefaultFinanceCo).Size = new Size(161, 21);
    ((Control) this.cboDefaultFinanceCo).TabIndex = 22;
    ((UltraControlBase) this.cboDefaultFinanceCo).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboDefaultFinanceCo).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboDefaultFinanceCo).ValueMember = "PayeeGUID";
    this.Label8.BackColor = Color.Transparent;
    this.Label8.ForeColor = Color.Black;
    this.Label8.Location = new Point(8, 198);
    this.Label8.Name = "Label8";
    this.Label8.Size = new Size(141, 21);
    this.Label8.TabIndex = 23;
    this.Label8.Text = "Default Finance Company:";
    this.Label8.TextAlign = ContentAlignment.MiddleRight;
    this.GroupBox2.BackColorInternal = Color.Transparent;
    appearance13.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.GroupBox2.ContentAreaAppearance = (AppearanceBase) appearance13;
    ((Control) this.GroupBox2).Controls.Add((Control) this.Label7);
    ((Control) this.GroupBox2).Controls.Add((Control) this.MgaNumericEditor2);
    ((Control) this.GroupBox2).Controls.Add((Control) this.MgaNumericEditor1);
    ((Control) this.GroupBox2).Controls.Add((Control) this.chkWaivePremium);
    ((Control) this.GroupBox2).Controls.Add((Control) this.txtInvoiceDays);
    ((Control) this.GroupBox2).Controls.Add((Control) this.Label31);
    ((Control) this.GroupBox2).Controls.Add((Control) this.Label30);
    appearance14.ForeColor = Color.Navy;
    this.GroupBox2.HeaderAppearance = (AppearanceBase) appearance14;
    ((Control) this.GroupBox2).Location = new Point(336, 31 /*0x1F*/);
    ((Control) this.GroupBox2).Name = "GroupBox2";
    ((Control) this.GroupBox2).Size = new Size(247, 119);
    ((Control) this.GroupBox2).TabIndex = 17;
    this.GroupBox2.Text = "Invoice Automation";
    this.Label7.AutoSize = true;
    this.Label7.BackColor = Color.Transparent;
    this.Label7.Location = new Point(176 /*0xB0*/, 50);
    this.Label7.Name = "Label7";
    this.Label7.Size = new Size(17, 13);
    this.Label7.TabIndex = 16 /*0x10*/;
    this.Label7.Text = "to";
    this.Label7.TextAlign = ContentAlignment.MiddleRight;
    appearance15.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.MgaNumericEditor2).Appearance = (AppearanceBase) appearance15;
    ((Control) this.MgaNumericEditor2).DataBindings.Add(new Binding("Value", (object) this.dsLines, "tblCompanyLines.MaxWaivePremium", true));
    ((UltraNumericEditorBase) this.MgaNumericEditor2).FormatString = "";
    ((Control) this.MgaNumericEditor2).Location = new Point(199, 45);
    this.MgaNumericEditor2.MaskInput = "nnnnnn";
    this.MgaNumericEditor2.MaxValue = (object) 99999;
    this.MgaNumericEditor2.MGAStyle = MGAStyles.Blue;
    this.MgaNumericEditor2.MinValue = (object) -99999;
    ((Control) this.MgaNumericEditor2).Name = "MgaNumericEditor2";
    this.MgaNumericEditor2.Nullable = true;
    ((UltraNumericEditorBase) this.MgaNumericEditor2).PromptChar = ' ';
    ((Control) this.MgaNumericEditor2).Size = new Size(42, 20);
    ((Control) this.MgaNumericEditor2).TabIndex = 156;
    ((UltraWinEditorMaskedControlBase) this.MgaNumericEditor2).TabNavigation = (MaskedEditTabNavigation) 0;
    ((UltraControlBase) this.MgaNumericEditor2).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaNumericEditor2).UseOsThemes = (DefaultableBoolean) 2;
    appearance16.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.MgaNumericEditor1).Appearance = (AppearanceBase) appearance16;
    ((Control) this.MgaNumericEditor1).DataBindings.Add(new Binding("Value", (object) this.dsLines, "tblCompanyLines.MinWaivePremium", true));
    ((UltraNumericEditorBase) this.MgaNumericEditor1).FormatString = "";
    ((Control) this.MgaNumericEditor1).Location = new Point(123, 45);
    this.MgaNumericEditor1.MaskInput = "nnnnn";
    this.MgaNumericEditor1.MaxValue = (object) 9999;
    this.MgaNumericEditor1.MGAStyle = MGAStyles.Blue;
    this.MgaNumericEditor1.MinValue = (object) -9999;
    ((Control) this.MgaNumericEditor1).Name = "MgaNumericEditor1";
    this.MgaNumericEditor1.Nullable = true;
    ((UltraNumericEditorBase) this.MgaNumericEditor1).PromptChar = ' ';
    ((Control) this.MgaNumericEditor1).Size = new Size(42, 20);
    ((Control) this.MgaNumericEditor1).TabIndex = 155;
    ((UltraWinEditorMaskedControlBase) this.MgaNumericEditor1).TabNavigation = (MaskedEditTabNavigation) 0;
    ((UltraControlBase) this.MgaNumericEditor1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaNumericEditor1).UseOsThemes = (DefaultableBoolean) 2;
    appearance17.BorderColor = Color.Gray;
    appearance17.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkWaivePremium).Appearance = (AppearanceBase) appearance17;
    ((UltraToggleEditorBase) this.chkWaivePremium).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkWaivePremium).BackColorInternal = Color.Transparent;
    ((Control) this.chkWaivePremium).DataBindings.Add(new Binding("Checked", (object) this.dsLines, "tblCompanyLines.WaivePremium", true));
    ((UltraToggleEditorBase) this.chkWaivePremium).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkWaivePremium).Location = new Point(10, 47);
    ((Control) this.chkWaivePremium).Name = "chkWaivePremium";
    ((Control) this.chkWaivePremium).Size = new Size(107, 16 /*0x10*/);
    ((Control) this.chkWaivePremium).TabIndex = 16 /*0x10*/;
    ((UltraToggleEditorBase) this.chkWaivePremium).Text = "Waive Premium";
    ((UltraControlBase) this.chkWaivePremium).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkWaivePremium).UseOsThemes = (DefaultableBoolean) 2;
    appearance18.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.txtInvoiceDays).Appearance = (AppearanceBase) appearance18;
    ((Control) this.txtInvoiceDays).DataBindings.Add(new Binding("Value", (object) this.dsLines, "tblCompanyLines.InvoiceMailingDays", true));
    ((UltraNumericEditorBase) this.txtInvoiceDays).FormatString = "";
    ((Control) this.txtInvoiceDays).Location = new Point(84, 21);
    this.txtInvoiceDays.MaskInput = "nnn";
    this.txtInvoiceDays.MaxValue = (object) 999;
    this.txtInvoiceDays.MGAStyle = MGAStyles.Blue;
    this.txtInvoiceDays.MinValue = (object) 1;
    ((Control) this.txtInvoiceDays).Name = "txtInvoiceDays";
    this.txtInvoiceDays.Nullable = true;
    ((UltraNumericEditorBase) this.txtInvoiceDays).PromptChar = ' ';
    ((Control) this.txtInvoiceDays).Size = new Size(42, 20);
    ((Control) this.txtInvoiceDays).TabIndex = 154;
    ((UltraControlBase) this.txtInvoiceDays).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtInvoiceDays).UseOsThemes = (DefaultableBoolean) 2;
    this.Label31.AutoSize = true;
    this.Label31.Location = new Point(133, 23);
    this.Label31.Name = "Label31";
    this.Label31.Size = new Size(86, 13);
    this.Label31.TabIndex = 2;
    this.Label31.Text = "days before due";
    this.Label30.AutoSize = true;
    this.Label30.Location = new Point(7, 23);
    this.Label30.Name = "Label30";
    this.Label30.Size = new Size(72, 13);
    this.Label30.TabIndex = 1;
    this.Label30.Text = "Print Invoices";
    this.GroupBox1.BackColorInternal = Color.Transparent;
    appearance19.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.GroupBox1.ContentAreaAppearance = (AppearanceBase) appearance19;
    ((Control) this.GroupBox1).Controls.Add((Control) this.txtNOCGracePeriod);
    ((Control) this.GroupBox1).Controls.Add((Control) this.lblNOCGracePeriod);
    ((Control) this.GroupBox1).Controls.Add((Control) this.chkIncludeFeesNOC);
    ((Control) this.GroupBox1).Controls.Add((Control) this.Label29);
    ((Control) this.GroupBox1).Controls.Add((Control) this.txtEmailReminderDays);
    ((Control) this.GroupBox1).Controls.Add((Control) this.txtNOCDays);
    ((Control) this.GroupBox1).Controls.Add((Control) this.txtMailingDays);
    ((Control) this.GroupBox1).Controls.Add((Control) this.chkEmailReminder);
    ((Control) this.GroupBox1).Controls.Add((Control) this.Label28);
    ((Control) this.GroupBox1).Controls.Add((Control) this.Label27);
    ((Control) this.GroupBox1).Controls.Add((Control) this.chkAutoNOC);
    appearance20.ForeColor = Color.Navy;
    this.GroupBox1.HeaderAppearance = (AppearanceBase) appearance20;
    ((Control) this.GroupBox1).Location = new Point(7, 31 /*0x1F*/);
    ((Control) this.GroupBox1).Name = "GroupBox1";
    ((Control) this.GroupBox1).Size = new Size(323, 161);
    ((Control) this.GroupBox1).TabIndex = 16 /*0x10*/;
    this.GroupBox1.Text = "Notice of Cancellation Automation";
    this.txtNOCGracePeriod.AcceptsTab = true;
    appearance21.BackColor = Color.White;
    appearance21.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance21.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtNOCGracePeriod).Appearance = (AppearanceBase) appearance21;
    ((TextEditorControlBase) this.txtNOCGracePeriod).BackColor = Color.White;
    ((Control) this.txtNOCGracePeriod).CausesValidation = false;
    ((Control) this.txtNOCGracePeriod).DataBindings.Add(new Binding("Text", (object) this.dsLines, "tblCompanyLines.NOCGracePeriod", true));
    ((Control) this.txtNOCGracePeriod).Location = new Point(120, 72);
    ((TextEditorControlBase) this.txtNOCGracePeriod).MaxLength = 4;
    this.txtNOCGracePeriod.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtNOCGracePeriod).Name = "txtNOCGracePeriod";
    ((Control) this.txtNOCGracePeriod).Size = new Size(35, 20);
    ((Control) this.txtNOCGracePeriod).TabIndex = 13;
    ((UltraControlBase) this.txtNOCGracePeriod).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtNOCGracePeriod).UseOsThemes = (DefaultableBoolean) 2;
    this.txtNOCGracePeriod.WordWrap = false;
    this.lblNOCGracePeriod.AutoSize = true;
    this.lblNOCGracePeriod.BackColor = Color.Transparent;
    this.lblNOCGracePeriod.Location = new Point(7, 76);
    this.lblNOCGracePeriod.Name = "lblNOCGracePeriod";
    this.lblNOCGracePeriod.Size = new Size(97, 13);
    this.lblNOCGracePeriod.TabIndex = 16 /*0x10*/;
    this.lblNOCGracePeriod.Text = "NOC Grace Period:";
    this.lblNOCGracePeriod.TextAlign = ContentAlignment.MiddleRight;
    appearance22.BorderColor = Color.Gray;
    appearance22.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkIncludeFeesNOC).Appearance = (AppearanceBase) appearance22;
    ((UltraToggleEditorBase) this.chkIncludeFeesNOC).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkIncludeFeesNOC).BackColorInternal = Color.Transparent;
    ((Control) this.chkIncludeFeesNOC).DataBindings.Add(new Binding("Checked", (object) this.dsLines, "tblCompanyLines.NOCIncludeFees", true));
    ((UltraToggleEditorBase) this.chkIncludeFeesNOC).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkIncludeFeesNOC).Location = new Point(6, 129);
    ((Control) this.chkIncludeFeesNOC).Name = "chkIncludeFeesNOC";
    ((Control) this.chkIncludeFeesNOC).Size = new Size(280, 21);
    ((Control) this.chkIncludeFeesNOC).TabIndex = 15;
    ((UltraToggleEditorBase) this.chkIncludeFeesNOC).Text = "Include commissionable fees in NOC calculation";
    ((UltraControlBase) this.chkIncludeFeesNOC).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkIncludeFeesNOC).UseOsThemes = (DefaultableBoolean) 2;
    this.Label29.AutoSize = true;
    this.Label29.BackColor = Color.Transparent;
    this.Label29.Location = new Point(194, 103);
    this.Label29.Name = "Label29";
    this.Label29.Size = new Size(86, 13);
    this.Label29.TabIndex = 14;
    this.Label29.Text = "days before due";
    this.Label29.TextAlign = ContentAlignment.MiddleRight;
    this.txtEmailReminderDays.AcceptsTab = true;
    appearance23.BackColor = Color.White;
    appearance23.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance23.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtEmailReminderDays).Appearance = (AppearanceBase) appearance23;
    ((TextEditorControlBase) this.txtEmailReminderDays).BackColor = Color.White;
    ((Control) this.txtEmailReminderDays).CausesValidation = false;
    ((Control) this.txtEmailReminderDays).DataBindings.Add(new Binding("Text", (object) this.dsLines, "tblCompanyLines.EmailReminderDays", true));
    ((Control) this.txtEmailReminderDays).Location = new Point(154, 99);
    this.txtEmailReminderDays.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtEmailReminderDays).Name = "txtEmailReminderDays";
    ((Control) this.txtEmailReminderDays).Size = new Size(35, 20);
    ((Control) this.txtEmailReminderDays).TabIndex = 13;
    ((UltraControlBase) this.txtEmailReminderDays).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtEmailReminderDays).UseOsThemes = (DefaultableBoolean) 2;
    this.txtNOCDays.AcceptsTab = true;
    appearance24.BackColor = Color.White;
    appearance24.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance24.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtNOCDays).Appearance = (AppearanceBase) appearance24;
    ((TextEditorControlBase) this.txtNOCDays).BackColor = Color.White;
    ((Control) this.txtNOCDays).CausesValidation = false;
    ((Control) this.txtNOCDays).DataBindings.Add(new Binding("Text", (object) this.dsLines, "tblCompanyLines.NocNumDays", true));
    ((Control) this.txtNOCDays).Location = new Point(251, 48 /*0x30*/);
    this.txtNOCDays.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtNOCDays).Name = "txtNOCDays";
    ((Control) this.txtNOCDays).Size = new Size(35, 20);
    ((Control) this.txtNOCDays).TabIndex = 12;
    ((UltraControlBase) this.txtNOCDays).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtNOCDays).UseOsThemes = (DefaultableBoolean) 2;
    this.txtMailingDays.AcceptsTab = true;
    appearance25.BackColor = Color.White;
    appearance25.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance25.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtMailingDays).Appearance = (AppearanceBase) appearance25;
    ((TextEditorControlBase) this.txtMailingDays).BackColor = Color.White;
    ((Control) this.txtMailingDays).CausesValidation = false;
    ((Control) this.txtMailingDays).DataBindings.Add(new Binding("Text", (object) this.dsLines, "tblCompanyLines.MailingNumDays", true));
    ((Control) this.txtMailingDays).Location = new Point(120, 48 /*0x30*/);
    ((TextEditorControlBase) this.txtMailingDays).MaxLength = 4;
    this.txtMailingDays.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtMailingDays).Name = "txtMailingDays";
    ((Control) this.txtMailingDays).Size = new Size(35, 20);
    ((Control) this.txtMailingDays).TabIndex = 11;
    ((UltraControlBase) this.txtMailingDays).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtMailingDays).UseOsThemes = (DefaultableBoolean) 2;
    this.txtMailingDays.WordWrap = false;
    appearance26.BorderColor = Color.Gray;
    appearance26.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkEmailReminder).Appearance = (AppearanceBase) appearance26;
    ((UltraToggleEditorBase) this.chkEmailReminder).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkEmailReminder).BackColorInternal = Color.Transparent;
    ((Control) this.chkEmailReminder).DataBindings.Add(new Binding("Checked", (object) this.dsLines, "tblCompanyLines.EmailReminder", true));
    ((UltraToggleEditorBase) this.chkEmailReminder).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkEmailReminder).Location = new Point(6, 100);
    ((Control) this.chkEmailReminder).Name = "chkEmailReminder";
    ((Control) this.chkEmailReminder).Size = new Size(142, 18);
    ((Control) this.chkEmailReminder).TabIndex = 10;
    ((UltraToggleEditorBase) this.chkEmailReminder).Text = "Send an email reminder";
    ((UltraControlBase) this.chkEmailReminder).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkEmailReminder).UseOsThemes = (DefaultableBoolean) 2;
    this.Label28.AutoSize = true;
    this.Label28.BackColor = Color.Transparent;
    this.Label28.Location = new Point(181, 52);
    this.Label28.Name = "Label28";
    this.Label28.Size = new Size(60, 13);
    this.Label28.TabIndex = 9;
    this.Label28.Text = "NOC Days:";
    this.Label28.TextAlign = ContentAlignment.MiddleRight;
    this.Label27.AutoSize = true;
    this.Label27.BackColor = Color.Transparent;
    this.Label27.Location = new Point(7, 52);
    this.Label27.Name = "Label27";
    this.Label27.Size = new Size(70, 13);
    this.Label27.TabIndex = 8;
    this.Label27.Text = "Mailing Days:";
    this.Label27.TextAlign = ContentAlignment.MiddleRight;
    appearance27.BorderColor = Color.Gray;
    appearance27.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkAutoNOC).Appearance = (AppearanceBase) appearance27;
    ((UltraToggleEditorBase) this.chkAutoNOC).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkAutoNOC).BackColorInternal = Color.Transparent;
    ((Control) this.chkAutoNOC).DataBindings.Add(new Binding("Checked", (object) this.dsLines, "tblCompanyLines.AllowAutomaticNOC", true));
    ((UltraToggleEditorBase) this.chkAutoNOC).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkAutoNOC).Location = new Point(10, 20);
    ((Control) this.chkAutoNOC).Name = "chkAutoNOC";
    ((Control) this.chkAutoNOC).Size = new Size(279, 21);
    ((Control) this.chkAutoNOC).TabIndex = 7;
    ((UltraToggleEditorBase) this.chkAutoNOC).Text = "Allow automatic NOC for non-payment of premium";
    ((UltraControlBase) this.chkAutoNOC).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkAutoNOC).UseOsThemes = (DefaultableBoolean) 2;
    appearance28.BackColor = Color.White;
    appearance28.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance28.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtDefaultInvoiceComment).Appearance = (AppearanceBase) appearance28;
    ((TextEditorControlBase) this.txtDefaultInvoiceComment).BackColor = Color.White;
    ((Control) this.txtDefaultInvoiceComment).DataBindings.Add(new Binding("Value", (object) this.dsLines, "tblCompanyLines.DefaultInvoiceComment", true));
    ((Control) this.txtDefaultInvoiceComment).Location = new Point(161, 5);
    this.txtDefaultInvoiceComment.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtDefaultInvoiceComment).Name = "txtDefaultInvoiceComment";
    ((Control) this.txtDefaultInvoiceComment).Size = new Size(368, 20);
    ((Control) this.txtDefaultInvoiceComment).TabIndex = 1;
    ((UltraControlBase) this.txtDefaultInvoiceComment).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtDefaultInvoiceComment).UseOsThemes = (DefaultableBoolean) 2;
    this.Label23.AutoSize = true;
    this.Label23.BackColor = Color.Transparent;
    this.Label23.Location = new Point(10, 9);
    this.Label23.Name = "Label23";
    this.Label23.Size = new Size(132, 13);
    this.Label23.TabIndex = 0;
    this.Label23.Text = "Default Invoice Comment:";
    this.Label23.TextAlign = ContentAlignment.MiddleRight;
    ((Control) this.UltraTabPageControl6).Controls.Add((Control) this.txtQuoteAdditionalComments);
    ((Control) this.UltraTabPageControl6).Controls.Add((Control) this.Label32);
    ((Control) this.UltraTabPageControl6).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabPageControl6).Name = "UltraTabPageControl6";
    ((Control) this.UltraTabPageControl6).Size = new Size(782, 247);
    this.txtQuoteAdditionalComments.AcceptsReturn = true;
    appearance29.BackColor = Color.White;
    appearance29.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance29.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtQuoteAdditionalComments).Appearance = (AppearanceBase) appearance29;
    ((TextEditorControlBase) this.txtQuoteAdditionalComments).BackColor = Color.White;
    ((Control) this.txtQuoteAdditionalComments).DataBindings.Add(new Binding("Text", (object) this.dsLines, "tblCompanyLines.QuoteAdditionalComments", true));
    ((Control) this.txtQuoteAdditionalComments).Location = new Point(168, 14);
    ((TextEditorControlBase) this.txtQuoteAdditionalComments).MaxLength = 2000;
    this.txtQuoteAdditionalComments.MGAStyle = MGAStyles.Blue;
    this.txtQuoteAdditionalComments.Multiline = true;
    ((Control) this.txtQuoteAdditionalComments).Name = "txtQuoteAdditionalComments";
    ((Control) this.txtQuoteAdditionalComments).Size = new Size(497, 91);
    ((Control) this.txtQuoteAdditionalComments).TabIndex = 8;
    ((UltraControlBase) this.txtQuoteAdditionalComments).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtQuoteAdditionalComments).UseOsThemes = (DefaultableBoolean) 2;
    this.Label32.BackColor = Color.Transparent;
    this.Label32.Location = new Point(7, 14);
    this.Label32.Name = "Label32";
    this.Label32.Size = new Size(154, 23);
    this.Label32.TabIndex = 7;
    this.Label32.Text = "Default Additional Comments:";
    this.Label32.TextAlign = ContentAlignment.MiddleRight;
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.Label5);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.txtBinderComments);
    ((Control) this.UltraTabPageControl2).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabPageControl2).Name = "UltraTabPageControl2";
    ((Control) this.UltraTabPageControl2).Size = new Size(782, 247);
    this.Label5.BackColor = Color.Transparent;
    this.Label5.Location = new Point(42, 14);
    this.Label5.Name = "Label5";
    this.Label5.Size = new Size(119, 23);
    this.Label5.TabIndex = 15;
    this.Label5.Text = "Binder Comments:";
    this.Label5.TextAlign = ContentAlignment.MiddleRight;
    this.txtBinderComments.AcceptsReturn = true;
    appearance30.BackColor = Color.White;
    appearance30.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance30.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtBinderComments).Appearance = (AppearanceBase) appearance30;
    ((TextEditorControlBase) this.txtBinderComments).BackColor = Color.White;
    ((Control) this.txtBinderComments).DataBindings.Add(new Binding("Text", (object) this.dsLines, "tblCompanyLines.BinderComments", true));
    ((Control) this.txtBinderComments).Location = new Point(168, 14);
    ((TextEditorControlBase) this.txtBinderComments).MaxLength = 2000;
    this.txtBinderComments.MGAStyle = MGAStyles.Blue;
    this.txtBinderComments.Multiline = true;
    ((Control) this.txtBinderComments).Name = "txtBinderComments";
    ((Control) this.txtBinderComments).Size = new Size(497, 91);
    ((Control) this.txtBinderComments).TabIndex = 14;
    ((UltraControlBase) this.txtBinderComments).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtBinderComments).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.grpRenewalForms);
    ((Control) this.UltraTabPageControl3).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabPageControl3).Name = "UltraTabPageControl3";
    ((Control) this.UltraTabPageControl3).Size = new Size(782, 247);
    this.grpRenewalForms.BackColorInternal = Color.Transparent;
    appearance31.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.grpRenewalForms.ContentAreaAppearance = (AppearanceBase) appearance31;
    ((Control) this.grpRenewalForms).Controls.Add((Control) this.chkClearRenewalTemplates);
    ((Control) this.grpRenewalForms).Controls.Add((Control) this.chkClearRenewalForms);
    ((Control) this.grpRenewalForms).Controls.Add((Control) this.chkResetSubjectivities);
    ((Control) this.grpRenewalForms).Controls.Add((Control) this.chkResetFCWRecords);
    appearance32.ForeColor = Color.Navy;
    this.grpRenewalForms.HeaderAppearance = (AppearanceBase) appearance32;
    ((Control) this.grpRenewalForms).Location = new Point(7, 3);
    ((Control) this.grpRenewalForms).Name = "grpRenewalForms";
    ((Control) this.grpRenewalForms).Size = new Size(231, 111);
    ((Control) this.grpRenewalForms).TabIndex = 37;
    this.grpRenewalForms.Text = "Forms/Conditions/Warranties";
    appearance33.BorderColor = Color.Gray;
    appearance33.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkClearRenewalTemplates).Appearance = (AppearanceBase) appearance33;
    ((UltraToggleEditorBase) this.chkClearRenewalTemplates).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkClearRenewalTemplates).BackColorInternal = Color.Transparent;
    ((Control) this.chkClearRenewalTemplates).DataBindings.Add(new Binding("Checked", (object) this.dsLines, "tblCompanyLines.ClearCompletedTemplatesOnRenewal", true, DataSourceUpdateMode.OnPropertyChanged, (object) false));
    ((UltraToggleEditorBase) this.chkClearRenewalTemplates).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkClearRenewalTemplates).Location = new Point(6, 20);
    ((Control) this.chkClearRenewalTemplates).Name = "chkClearRenewalTemplates";
    ((Control) this.chkClearRenewalTemplates).Size = new Size(210, 15);
    ((Control) this.chkClearRenewalTemplates).TabIndex = 36;
    ((UltraToggleEditorBase) this.chkClearRenewalTemplates).Text = "Clear Completed Templates";
    this.ToolTip.SetToolTip((Control) this.chkClearRenewalTemplates, componentResourceManager.GetString("chkClearRenewalTemplates.ToolTip"));
    ((UltraControlBase) this.chkClearRenewalTemplates).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkClearRenewalTemplates).UseOsThemes = (DefaultableBoolean) 2;
    appearance34.BorderColor = Color.Gray;
    appearance34.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkClearRenewalForms).Appearance = (AppearanceBase) appearance34;
    ((UltraToggleEditorBase) this.chkClearRenewalForms).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkClearRenewalForms).BackColorInternal = Color.Transparent;
    ((Control) this.chkClearRenewalForms).DataBindings.Add(new Binding("Checked", (object) this.dsLines, "tblCompanyLines.ClearAppliedFormsOnRenewal", true, DataSourceUpdateMode.OnPropertyChanged, (object) false));
    ((UltraToggleEditorBase) this.chkClearRenewalForms).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkClearRenewalForms).Location = new Point(6, 62);
    ((Control) this.chkClearRenewalForms).Name = "chkClearRenewalForms";
    ((Control) this.chkClearRenewalForms).Size = new Size(210, 15);
    ((Control) this.chkClearRenewalForms).TabIndex = 36;
    ((UltraToggleEditorBase) this.chkClearRenewalForms).Text = "Clear All Applied FCW Records";
    this.ToolTip.SetToolTip((Control) this.chkClearRenewalForms, "Clears all applied forms/conditions/warranties on the renewal, as if the policy was new.");
    ((UltraControlBase) this.chkClearRenewalForms).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkClearRenewalForms).UseOsThemes = (DefaultableBoolean) 2;
    appearance35.BorderColor = Color.Gray;
    appearance35.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkResetSubjectivities).Appearance = (AppearanceBase) appearance35;
    ((UltraToggleEditorBase) this.chkResetSubjectivities).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkResetSubjectivities).BackColorInternal = Color.Transparent;
    ((Control) this.chkResetSubjectivities).DataBindings.Add(new Binding("Checked", (object) this.dsLines, "tblCompanyLines.ResetAppliedSubjectivities", true, DataSourceUpdateMode.OnPropertyChanged, (object) false));
    ((UltraToggleEditorBase) this.chkResetSubjectivities).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkResetSubjectivities).Location = new Point(6, 83);
    ((Control) this.chkResetSubjectivities).Name = "chkResetSubjectivities";
    ((Control) this.chkResetSubjectivities).Size = new Size(210, 15);
    ((Control) this.chkResetSubjectivities).TabIndex = 36;
    ((UltraToggleEditorBase) this.chkResetSubjectivities).Text = "Reset Subjectivities";
    this.ToolTip.SetToolTip((Control) this.chkResetSubjectivities, "Clears the Added/Waived values on applied conditions/warranties, treating them as newly applied on the renewal.");
    ((UltraControlBase) this.chkResetSubjectivities).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkResetSubjectivities).UseOsThemes = (DefaultableBoolean) 2;
    appearance36.BorderColor = Color.Gray;
    appearance36.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkResetFCWRecords).Appearance = (AppearanceBase) appearance36;
    ((UltraToggleEditorBase) this.chkResetFCWRecords).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkResetFCWRecords).BackColorInternal = Color.Transparent;
    ((Control) this.chkResetFCWRecords).DataBindings.Add(new Binding("Checked", (object) this.dsLines, "tblCompanyLines.ClearUserModifiedFCWOnRenewal", true, DataSourceUpdateMode.OnPropertyChanged, (object) false));
    ((UltraToggleEditorBase) this.chkResetFCWRecords).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkResetFCWRecords).Location = new Point(6, 41);
    ((Control) this.chkResetFCWRecords).Name = "chkResetFCWRecords";
    ((Control) this.chkResetFCWRecords).Size = new Size(210, 15);
    ((Control) this.chkResetFCWRecords).TabIndex = 36;
    ((UltraToggleEditorBase) this.chkResetFCWRecords).Text = "Clear User Added/Waived FCW";
    this.ToolTip.SetToolTip((Control) this.chkResetFCWRecords, componentResourceManager.GetString("chkResetFCWRecords.ToolTip"));
    ((UltraControlBase) this.chkResetFCWRecords).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkResetFCWRecords).UseOsThemes = (DefaultableBoolean) 2;
    this.GroupBox3.BackColorInternal = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((Control) this.GroupBox3).Location = new Point(7, 7);
    ((Control) this.GroupBox3).Name = "GroupBox3";
    ((Control) this.GroupBox3).Size = new Size(490, 42);
    ((Control) this.GroupBox3).TabIndex = 138;
    this.GroupBox3.Text = "Filters";
    this.cbStateFilter.BorderStyle = (UIElementBorderStyle) 4;
    this.cbStateFilter.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cbStateFilter).Location = new Point(461, 35);
    this.cbStateFilter.MGAStyle = MGAStyles.Blue;
    ((Control) this.cbStateFilter).Name = "cbStateFilter";
    ((Control) this.cbStateFilter).Size = new Size(224 /*0xE0*/, 21);
    ((Control) this.cbStateFilter).TabIndex = 2;
    ((UltraControlBase) this.cbStateFilter).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cbStateFilter).UseOsThemes = (DefaultableBoolean) 2;
    this.cbLineFilter.BorderStyle = (UIElementBorderStyle) 4;
    this.cbLineFilter.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cbLineFilter).DropDownWidth = 300;
    ((Control) this.cbLineFilter).Location = new Point(234, 35);
    this.cbLineFilter.MGAStyle = MGAStyles.Blue;
    ((Control) this.cbLineFilter).Name = "cbLineFilter";
    ((Control) this.cbLineFilter).Size = new Size(224 /*0xE0*/, 21);
    ((Control) this.cbLineFilter).TabIndex = 1;
    ((UltraControlBase) this.cbLineFilter).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cbLineFilter).UseOsThemes = (DefaultableBoolean) 2;
    this.cbCompanyFilter.BorderStyle = (UIElementBorderStyle) 4;
    this.cbCompanyFilter.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cbCompanyFilter).DropDownWidth = 500;
    ((Control) this.cbCompanyFilter).Location = new Point(7, 35);
    this.cbCompanyFilter.MGAStyle = MGAStyles.Blue;
    ((Control) this.cbCompanyFilter).Name = "cbCompanyFilter";
    ((Control) this.cbCompanyFilter).Size = new Size(224 /*0xE0*/, 21);
    ((Control) this.cbCompanyFilter).TabIndex = 0;
    ((UltraControlBase) this.cbCompanyFilter).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cbCompanyFilter).UseOsThemes = (DefaultableBoolean) 2;
    this.DbSelectCommand1.CommandText = "SELECT CompanyLocationGuid, Name, StatusID FROM tblCompanyLocations ORDER BY Name";
    this.DbSelectCommand1.Connection = this.cnSQL;
    this.daCompanyLines.AcceptChangesDuringUpdate = false;
    this.daCompanyLines.DeleteCommand = this.DbDeleteCommand2;
    this.daCompanyLines.InsertCommand = this.DbInsertCommand2;
    this.daCompanyLines.SelectCommand = this.DbCommand1;
    this.daCompanyLines.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblCompanyLines", new DataColumnMapping[30]
      {
        new DataColumnMapping("CompanyLineGUID", "CompanyLineGUID"),
        new DataColumnMapping("ParentCompanyLineGUID", "ParentCompanyLineGUID"),
        new DataColumnMapping("CompanyLocationGUID", "CompanyLocationGUID"),
        new DataColumnMapping("LineGUID", "LineGUID"),
        new DataColumnMapping("StateID", "StateID"),
        new DataColumnMapping("CompanyLicenseTypeID", "CompanyLicenseTypeID"),
        new DataColumnMapping("LicenseTypeID", "LicenseTypeID"),
        new DataColumnMapping("StatusID", "StatusID"),
        new DataColumnMapping("UserSignatureGUID", "UserSignatureGUID"),
        new DataColumnMapping("Added", "Added"),
        new DataColumnMapping("Hidden", "Hidden"),
        new DataColumnMapping("DefaultInvoiceComment", "DefaultInvoiceComment"),
        new DataColumnMapping("AllowAutomaticNOC", "AllowAutomaticNOC"),
        new DataColumnMapping("MailingNumDays", "MailingNumDays"),
        new DataColumnMapping("NocNumDays", "NocNumDays"),
        new DataColumnMapping("EmailReminder", "EmailReminder"),
        new DataColumnMapping("EmailReminderDays", "EmailReminderDays"),
        new DataColumnMapping("NOCIncludeFees", "NOCIncludeFees"),
        new DataColumnMapping("InvoiceMailingDays", "InvoiceMailingDays"),
        new DataColumnMapping("QuoteAdditionalComments", "QuoteAdditionalComments"),
        new DataColumnMapping("BinderExpirationDays", "BinderExpirationDays"),
        new DataColumnMapping("MinimumEarnedPercentage", "MinimumEarnedPercentage"),
        new DataColumnMapping("MaxBackdateDays", "MaxBackdateDays"),
        new DataColumnMapping("EnforceUniquePolicyNumbers", "EnforceUniquePolicyNumbers"),
        new DataColumnMapping("BinderComments", "BinderComments"),
        new DataColumnMapping("AllowEndorsementsWithoutIssuance", "AllowEndorsementsWithoutIssuance"),
        new DataColumnMapping("BlockXSPremium", "BlockXSPremium"),
        new DataColumnMapping("AllowLapseOnRenewal", "AllowLapseOnRenewal"),
        new DataColumnMapping("PackageOrder", "PackageOrder"),
        new DataColumnMapping("CompanyLineID", "CompanyLineID")
      })
    });
    this.daCompanyLines.UpdateCommand = this.DbUpdateCommand2;
    this.DbDeleteCommand2.CommandText = "DELETE FROM tblCompanyLines\r\nWHERE     (CompanyLineID = @Original_CompanyLineGuid)";
    this.DbDeleteCommand2.Connection = this.cnSQL;
    this.DbDeleteCommand2.Parameters.AddRange((Array) new DbParameter[1]
    {
      DefaultDatabase.CreateParameter("@Original_CompanyLineGuid", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "CompanyLineID", DataRowVersion.Original, (object) null)
    });
    this.DbInsertCommand2.CommandText = componentResourceManager.GetString("DbInsertCommand2.CommandText");
    this.DbInsertCommand2.Connection = this.cnSQL;
    this.DbInsertCommand2.Parameters.AddRange((Array) new DbParameter[31 /*0x1F*/]
    {
      DefaultDatabase.CreateParameter("@CompanyLineGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "CompanyLineGUID"),
      DefaultDatabase.CreateParameter("@ParentCompanyLineGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "ParentCompanyLineGUID"),
      DefaultDatabase.CreateParameter("@CompanyLocationGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "CompanyLocationGUID"),
      DefaultDatabase.CreateParameter("@LineGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "LineGUID"),
      DefaultDatabase.CreateParameter("@StateID", SqlDbType.Char, 2, "StateID"),
      DefaultDatabase.CreateParameter("@CompanyLicenseTypeID", SqlDbType.TinyInt, 1, "CompanyLicenseTypeID"),
      DefaultDatabase.CreateParameter("@LicenseTypeID", SqlDbType.TinyInt, 1, "LicenseTypeID"),
      DefaultDatabase.CreateParameter("@StatusID", SqlDbType.TinyInt, 1, "StatusID"),
      DefaultDatabase.CreateParameter("@UserSignatureGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "UserSignatureGUID"),
      DefaultDatabase.CreateParameter("@Added", SqlDbType.DateTime, 8, "Added"),
      DefaultDatabase.CreateParameter("@Hidden", SqlDbType.Bit, 1, "Hidden"),
      DefaultDatabase.CreateParameter("@DefaultInvoiceComment", SqlDbType.VarChar, 200, "DefaultInvoiceComment"),
      DefaultDatabase.CreateParameter("@AllowAutomaticNOC", SqlDbType.Bit, 1, "AllowAutomaticNOC"),
      DefaultDatabase.CreateParameter("@MailingNumDays", SqlDbType.TinyInt, 1, "MailingNumDays"),
      DefaultDatabase.CreateParameter("@NocNumDays", SqlDbType.TinyInt, 1, "NocNumDays"),
      DefaultDatabase.CreateParameter("@EmailReminder", SqlDbType.Bit, 1, "EmailReminder"),
      DefaultDatabase.CreateParameter("@EmailReminderDays", SqlDbType.TinyInt, 1, "EmailReminderDays"),
      DefaultDatabase.CreateParameter("@NOCIncludeFees", SqlDbType.Bit, 1, "NOCIncludeFees"),
      DefaultDatabase.CreateParameter("@InvoiceMailingDays", SqlDbType.TinyInt, 1, "InvoiceMailingDays"),
      DefaultDatabase.CreateParameter("@QuoteAdditionalComments", SqlDbType.VarChar, 2000, "QuoteAdditionalComments"),
      DefaultDatabase.CreateParameter("@BinderExpirationDays", SqlDbType.TinyInt, 1, "BinderExpirationDays"),
      DefaultDatabase.CreateParameter("@MinimumEarnedPercentage", SqlDbType.Decimal, 5, ParameterDirection.Input, false, (byte) 6, (byte) 3, "MinimumEarnedPercentage", DataRowVersion.Current, (object) null),
      DefaultDatabase.CreateParameter("@MaxBackdateDays", SqlDbType.Int, 4, "MaxBackdateDays"),
      DefaultDatabase.CreateParameter("@EnforceUniquePolicyNumbers", SqlDbType.Bit, 1, "EnforceUniquePolicyNumbers"),
      DefaultDatabase.CreateParameter("@BinderComments", SqlDbType.VarChar, 2000, "BinderComments"),
      DefaultDatabase.CreateParameter("@AllowEndorsementsWithoutIssuance", SqlDbType.Bit, 1, "AllowEndorsementsWithoutIssuance"),
      DefaultDatabase.CreateParameter("@BlockXSPremium", SqlDbType.Bit, 1, "BlockXSPremium"),
      DefaultDatabase.CreateParameter("@AllowLapseOnRenewal", SqlDbType.Bit, 1, "AllowLapseOnRenewal"),
      DefaultDatabase.CreateParameter("@PackageOrder", SqlDbType.TinyInt, 1, "PackageOrder"),
      DefaultDatabase.CreateParameter("@InsuredFEINSSNRequiredOnBind", SqlDbType.Bit, 1, "InsuredFEINSSNRequiredOnBind"),
      DefaultDatabase.CreateParameter("@WaivePremium", SqlDbType.Bit, 1, "WaivePremium")
    });
    this.DbCommand1.CommandText = componentResourceManager.GetString("DbCommand1.CommandText");
    this.DbCommand1.Connection = this.cnSQL;
    this.DbUpdateCommand2.CommandText = componentResourceManager.GetString("DbUpdateCommand2.CommandText");
    this.DbUpdateCommand2.Connection = this.cnSQL;
    this.DbUpdateCommand2.Parameters.AddRange((Array) new DbParameter[32 /*0x20*/]
    {
      DefaultDatabase.CreateParameter("@ParentCompanyLineGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "ParentCompanyLineGUID"),
      DefaultDatabase.CreateParameter("@CompanyLocationGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "CompanyLocationGUID"),
      DefaultDatabase.CreateParameter("@LineGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "LineGUID"),
      DefaultDatabase.CreateParameter("@StateID", SqlDbType.Char, 2, "StateID"),
      DefaultDatabase.CreateParameter("@CompanyLicenseTypeID", SqlDbType.TinyInt, 1, "CompanyLicenseTypeID"),
      DefaultDatabase.CreateParameter("@LicenseTypeID", SqlDbType.TinyInt, 1, "LicenseTypeID"),
      DefaultDatabase.CreateParameter("@StatusID", SqlDbType.TinyInt, 1, "StatusID"),
      DefaultDatabase.CreateParameter("@UserSignatureGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "UserSignatureGUID"),
      DefaultDatabase.CreateParameter("@Added", SqlDbType.DateTime, 8, "Added"),
      DefaultDatabase.CreateParameter("@Hidden", SqlDbType.Bit, 1, "Hidden"),
      DefaultDatabase.CreateParameter("@DefaultInvoiceComment", SqlDbType.VarChar, 200, "DefaultInvoiceComment"),
      DefaultDatabase.CreateParameter("@AllowAutomaticNOC", SqlDbType.Bit, 1, "AllowAutomaticNOC"),
      DefaultDatabase.CreateParameter("@MailingNumDays", SqlDbType.TinyInt, 1, "MailingNumDays"),
      DefaultDatabase.CreateParameter("@NocNumDays", SqlDbType.TinyInt, 1, "NocNumDays"),
      DefaultDatabase.CreateParameter("@EmailReminder", SqlDbType.Bit, 1, "EmailReminder"),
      DefaultDatabase.CreateParameter("@EmailReminderDays", SqlDbType.TinyInt, 1, "EmailReminderDays"),
      DefaultDatabase.CreateParameter("@NOCIncludeFees", SqlDbType.Bit, 1, "NOCIncludeFees"),
      DefaultDatabase.CreateParameter("@InvoiceMailingDays", SqlDbType.TinyInt, 1, "InvoiceMailingDays"),
      DefaultDatabase.CreateParameter("@QuoteAdditionalComments", SqlDbType.VarChar, 2000, "QuoteAdditionalComments"),
      DefaultDatabase.CreateParameter("@BinderExpirationDays", SqlDbType.TinyInt, 1, "BinderExpirationDays"),
      DefaultDatabase.CreateParameter("@MinimumEarnedPercentage", SqlDbType.Decimal, 5, ParameterDirection.Input, false, (byte) 6, (byte) 3, "MinimumEarnedPercentage", DataRowVersion.Current, (object) null),
      DefaultDatabase.CreateParameter("@MaxBackdateDays", SqlDbType.Int, 4, "MaxBackdateDays"),
      DefaultDatabase.CreateParameter("@EnforceUniquePolicyNumbers", SqlDbType.Bit, 1, "EnforceUniquePolicyNumbers"),
      DefaultDatabase.CreateParameter("@BinderComments", SqlDbType.VarChar, 2000, "BinderComments"),
      DefaultDatabase.CreateParameter("@AllowEndorsementsWithoutIssuance", SqlDbType.Bit, 1, "AllowEndorsementsWithoutIssuance"),
      DefaultDatabase.CreateParameter("@BlockXSPremium", SqlDbType.Bit, 1, "BlockXSPremium"),
      DefaultDatabase.CreateParameter("@AllowLapseOnRenewal", SqlDbType.Bit, 1, "AllowLapseOnRenewal"),
      DefaultDatabase.CreateParameter("@PackageOrder", SqlDbType.TinyInt, 1, "PackageOrder"),
      DefaultDatabase.CreateParameter("@InsuredFEINSSNRequiredOnBind", SqlDbType.Bit, 1, "InsuredFEINSSNRequiredOnBind"),
      DefaultDatabase.CreateParameter("@WaivePremium", SqlDbType.Bit, 1, "WaivePremium"),
      DefaultDatabase.CreateParameter("@Original_CompanyLineGuid", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "CompanyLineID", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@CompanyLineGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, ParameterDirection.Input, false, (byte) 0, (byte) 0, "CompanyLineGUID", DataRowVersion.Original, (object) null)
    });
    this.DbDeleteCommand1.CommandText = componentResourceManager.GetString("DbDeleteCommand1.CommandText");
    this.DbDeleteCommand1.Connection = this.cnSQL;
    this.DbDeleteCommand1.Parameters.AddRange((Array) new DbParameter[17]
    {
      DefaultDatabase.CreateParameter("@Original_CompanyLineGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, ParameterDirection.Input, false, (byte) 0, (byte) 0, "CompanyLineGuid", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_AcctCurrent", SqlDbType.Bit, 1, ParameterDirection.Input, false, (byte) 0, (byte) 0, "AcctCurrent", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_Added", SqlDbType.DateTime, 8, ParameterDirection.Input, false, (byte) 0, (byte) 0, "Added", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_CompanyLicenseTypeID", SqlDbType.Decimal, 9, ParameterDirection.Input, false, (byte) 18, (byte) 0, "CompanyLicenseTypeID", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_CompanyLineID", SqlDbType.Decimal, 9, ParameterDirection.Input, false, (byte) 18, (byte) 0, "CompanyLineID", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_CompanyLocationGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, ParameterDirection.Input, false, (byte) 0, (byte) 0, "CompanyLocationGuid", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_Hidden", SqlDbType.Bit, 1, ParameterDirection.Input, false, (byte) 0, (byte) 0, "Hidden", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_LicenseTypeID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "LicenseTypeID", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_LineGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, ParameterDirection.Input, false, (byte) 0, (byte) 0, "LineGuid", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_ParentCompanyLineGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ParentCompanyLineGuid", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_PaymentMethodID", SqlDbType.TinyInt, 1, ParameterDirection.Input, false, (byte) 0, (byte) 0, "PaymentMethodID", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_PolicyNumberRuleID", SqlDbType.Decimal, 9, ParameterDirection.Input, false, (byte) 18, (byte) 0, "PolicyNumberRuleID", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_RatingTypeID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "RatingTypeID", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_StateID", SqlDbType.VarChar, 2, ParameterDirection.Input, false, (byte) 0, (byte) 0, "StateID", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_StatusID", SqlDbType.TinyInt, 1, ParameterDirection.Input, false, (byte) 0, (byte) 0, "StatusID", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_TermsOfPayment", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "TermsOfPayment", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_UserSignatureGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, ParameterDirection.Input, false, (byte) 0, (byte) 0, "UserSignatureGuid", DataRowVersion.Original, (object) null)
    });
    this.DbInsertCommand1.CommandText = componentResourceManager.GetString("DbInsertCommand1.CommandText");
    this.DbInsertCommand1.Connection = this.cnSQL;
    this.DbInsertCommand1.Parameters.AddRange((Array) new DbParameter[16 /*0x10*/]
    {
      DefaultDatabase.CreateParameter("@CompanyLineGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "CompanyLineGuid"),
      DefaultDatabase.CreateParameter("@ParentCompanyLineGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "ParentCompanyLineGuid"),
      DefaultDatabase.CreateParameter("@CompanyLocationGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "CompanyLocationGuid"),
      DefaultDatabase.CreateParameter("@LineGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "LineGuid"),
      DefaultDatabase.CreateParameter("@StateID", SqlDbType.VarChar, 2, "StateID"),
      DefaultDatabase.CreateParameter("@CompanyLicenseTypeID", SqlDbType.Decimal, 9, ParameterDirection.Input, false, (byte) 18, (byte) 0, "CompanyLicenseTypeID", DataRowVersion.Current, (object) null),
      DefaultDatabase.CreateParameter("@RatingTypeID", SqlDbType.Int, 4, "RatingTypeID"),
      DefaultDatabase.CreateParameter("@StatusID", SqlDbType.TinyInt, 1, "StatusID"),
      DefaultDatabase.CreateParameter("@LicenseTypeID", SqlDbType.Int, 4, "LicenseTypeID"),
      DefaultDatabase.CreateParameter("@UserSignatureGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "UserSignatureGuid"),
      DefaultDatabase.CreateParameter("@Added", SqlDbType.DateTime, 8, "Added"),
      DefaultDatabase.CreateParameter("@Hidden", SqlDbType.Bit, 1, "Hidden"),
      DefaultDatabase.CreateParameter("@TermsOfPayment", SqlDbType.Int, 4, "TermsOfPayment"),
      DefaultDatabase.CreateParameter("@PaymentMethodID", SqlDbType.TinyInt, 1, "PaymentMethodID"),
      DefaultDatabase.CreateParameter("@AcctCurrent", SqlDbType.Bit, 1, "AcctCurrent"),
      DefaultDatabase.CreateParameter("@PolicyNumberRuleID", SqlDbType.Decimal, 9, ParameterDirection.Input, false, (byte) 18, (byte) 0, "PolicyNumberRuleID", DataRowVersion.Current, (object) null)
    });
    this.DbSelectCommand4.CommandText = componentResourceManager.GetString("DbSelectCommand4.CommandText");
    this.DbSelectCommand4.Connection = this.cnSQL;
    this.DbUpdateCommand1.CommandText = componentResourceManager.GetString("DbUpdateCommand1.CommandText");
    this.DbUpdateCommand1.Connection = this.cnSQL;
    this.DbUpdateCommand1.Parameters.AddRange((Array) new DbParameter[32 /*0x20*/]
    {
      DefaultDatabase.CreateParameter("@CompanyLineGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "CompanyLineGuid"),
      DefaultDatabase.CreateParameter("@ParentCompanyLineGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "ParentCompanyLineGuid"),
      DefaultDatabase.CreateParameter("@CompanyLocationGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "CompanyLocationGuid"),
      DefaultDatabase.CreateParameter("@LineGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "LineGuid"),
      DefaultDatabase.CreateParameter("@StateID", SqlDbType.VarChar, 2, "StateID"),
      DefaultDatabase.CreateParameter("@CompanyLicenseTypeID", SqlDbType.Decimal, 9, ParameterDirection.Input, false, (byte) 18, (byte) 0, "CompanyLicenseTypeID", DataRowVersion.Current, (object) null),
      DefaultDatabase.CreateParameter("@RatingTypeID", SqlDbType.Int, 4, "RatingTypeID"),
      DefaultDatabase.CreateParameter("@StatusID", SqlDbType.TinyInt, 1, "StatusID"),
      DefaultDatabase.CreateParameter("@LicenseTypeID", SqlDbType.Int, 4, "LicenseTypeID"),
      DefaultDatabase.CreateParameter("@UserSignatureGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "UserSignatureGuid"),
      DefaultDatabase.CreateParameter("@Added", SqlDbType.DateTime, 8, "Added"),
      DefaultDatabase.CreateParameter("@Hidden", SqlDbType.Bit, 1, "Hidden"),
      DefaultDatabase.CreateParameter("@TermsOfPayment", SqlDbType.Int, 4, "TermsOfPayment"),
      DefaultDatabase.CreateParameter("@PaymentMethodID", SqlDbType.TinyInt, 1, "PaymentMethodID"),
      DefaultDatabase.CreateParameter("@AcctCurrent", SqlDbType.Bit, 1, "AcctCurrent"),
      DefaultDatabase.CreateParameter("@PolicyNumberRuleID", SqlDbType.Decimal, 9, ParameterDirection.Input, false, (byte) 18, (byte) 0, "PolicyNumberRuleID", DataRowVersion.Current, (object) null),
      DefaultDatabase.CreateParameter("@Original_CompanyLineGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, ParameterDirection.Input, false, (byte) 0, (byte) 0, "CompanyLineGuid", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_AcctCurrent", SqlDbType.Bit, 1, ParameterDirection.Input, false, (byte) 0, (byte) 0, "AcctCurrent", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_Added", SqlDbType.DateTime, 8, ParameterDirection.Input, false, (byte) 0, (byte) 0, "Added", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_CompanyLicenseTypeID", SqlDbType.Decimal, 9, ParameterDirection.Input, false, (byte) 18, (byte) 0, "CompanyLicenseTypeID", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_CompanyLocationGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, ParameterDirection.Input, false, (byte) 0, (byte) 0, "CompanyLocationGuid", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_Hidden", SqlDbType.Bit, 1, ParameterDirection.Input, false, (byte) 0, (byte) 0, "Hidden", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_LicenseTypeID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "LicenseTypeID", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_LineGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, ParameterDirection.Input, false, (byte) 0, (byte) 0, "LineGuid", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_ParentCompanyLineGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ParentCompanyLineGuid", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_PaymentMethodID", SqlDbType.TinyInt, 1, ParameterDirection.Input, false, (byte) 0, (byte) 0, "PaymentMethodID", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_PolicyNumberRuleID", SqlDbType.Decimal, 9, ParameterDirection.Input, false, (byte) 18, (byte) 0, "PolicyNumberRuleID", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_RatingTypeID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "RatingTypeID", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_StateID", SqlDbType.VarChar, 2, ParameterDirection.Input, false, (byte) 0, (byte) 0, "StateID", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_StatusID", SqlDbType.TinyInt, 1, ParameterDirection.Input, false, (byte) 0, (byte) 0, "StatusID", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_TermsOfPayment", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "TermsOfPayment", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_UserSignatureGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, ParameterDirection.Input, false, (byte) 0, (byte) 0, "UserSignatureGuid", DataRowVersion.Original, (object) null)
    });
    this.err.ContainerControl = (ContainerControl) this;
    this.Label26.AutoSize = true;
    this.Label26.Location = new Point(462, 14);
    this.Label26.Name = "Label26";
    this.Label26.Size = new Size(64 /*0x40*/, 13);
    this.Label26.TabIndex = 12;
    this.Label26.Text = "State Filter:";
    this.Label25.AutoSize = true;
    this.Label25.Location = new Point(238, 14);
    this.Label25.Name = "Label25";
    this.Label25.Size = new Size(57, 13);
    this.Label25.TabIndex = 11;
    this.Label25.Text = "Line Filter:";
    this.Label24.AutoSize = true;
    this.Label24.Location = new Point(7, 14);
    this.Label24.Name = "Label24";
    this.Label24.Size = new Size(83, 13);
    this.Label24.TabIndex = 10;
    this.Label24.Text = "Company Filter:";
    ((Control) this.ultraTab).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    ((Control) this.ultraTab).Controls.Add((Control) this.UltraTabSharedControlsPage1);
    ((Control) this.ultraTab).Controls.Add((Control) this.UltraTabPageControl1);
    ((Control) this.ultraTab).Controls.Add((Control) this.UltraTabPageControl5);
    ((Control) this.ultraTab).Controls.Add((Control) this.UltraTabPageControl6);
    ((Control) this.ultraTab).Controls.Add((Control) this.UltraTabPageControl2);
    ((Control) this.ultraTab).Controls.Add((Control) this.UltraTabPageControl3);
    ((Control) this.ultraTab).Location = new Point(7, 318);
    ((Control) this.ultraTab).Name = "ultraTab";
    ((UltraTabControlBase) this.ultraTab).SharedControls.AddRange(new Control[4]
    {
      (Control) this.lnkCPF,
      (Control) this.lnkFCW,
      (Control) this.dbSave,
      (Control) this.lnkDocAuto
    });
    ((UltraTabControlBase) this.ultraTab).SharedControlsPage = this.UltraTabSharedControlsPage1;
    ((Control) this.ultraTab).Size = new Size(784, 274);
    ((Control) this.ultraTab).TabIndex = 8;
    ((UltraTabControlBase) this.ultraTab).TabLayoutStyle = (TabLayoutStyle) 2;
    ((UltraTabControlBase) this.ultraTab).TabPadding = new Size(5, 3);
    appearance37.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance39.Image"));
    ultraTab1.Appearance = (AppearanceBase) appearance37;
    ultraTab1.Key = "tabCompanyLine";
    ultraTab1.TabPage = this.UltraTabPageControl1;
    ultraTab1.Text = "Company/Line";
    appearance38.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance40.Image"));
    ultraTab2.Appearance = (AppearanceBase) appearance38;
    ultraTab2.Key = "TabInvoices";
    ultraTab2.TabPage = this.UltraTabPageControl5;
    ultraTab2.Text = "Invoices";
    appearance39.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance41.Image"));
    ultraTab3.Appearance = (AppearanceBase) appearance39;
    ultraTab3.Key = "tabQuotes";
    ultraTab3.TabPage = this.UltraTabPageControl6;
    ultraTab3.Text = "Quotes";
    appearance40.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance42.Image"));
    ultraTab4.Appearance = (AppearanceBase) appearance40;
    ultraTab4.Key = "tabBinderComments";
    ultraTab4.TabPage = this.UltraTabPageControl2;
    ultraTab4.Text = "Binder Comments";
    appearance41.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance43.Image"));
    ultraTab5.Appearance = (AppearanceBase) appearance41;
    ultraTab5.Key = "tabRenewalRules";
    ultraTab5.TabPage = this.UltraTabPageControl3;
    ultraTab5.Text = "Renewals";
    ((UltraTabControlBase) this.ultraTab).Tabs.AddRange(new UltraTab[5]
    {
      ultraTab1,
      ultraTab2,
      ultraTab3,
      ultraTab4,
      ultraTab5
    });
    ((UltraTabControlBase) this.ultraTab).ViewStyle = (ViewStyle) 4;
    ((Control) this.UltraTabSharedControlsPage1).Controls.Add((Control) this.lnkCPF);
    ((Control) this.UltraTabSharedControlsPage1).Controls.Add((Control) this.lnkFCW);
    ((Control) this.UltraTabSharedControlsPage1).Controls.Add((Control) this.dbSave);
    ((Control) this.UltraTabSharedControlsPage1).Controls.Add((Control) this.lnkDocAuto);
    ((Control) this.UltraTabSharedControlsPage1).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabSharedControlsPage1).Name = "UltraTabSharedControlsPage1";
    ((Control) this.UltraTabSharedControlsPage1).Size = new Size(782, 247);
    this.DbSelectCommand2.CommandText = componentResourceManager.GetString("DbSelectCommand2.CommandText");
    this.DbSelectCommand2.Connection = this.cnSQL;
    this.daGetCompanyLine.SelectCommand = this.DbSelectCommand3;
    this.DbSelectCommand3.CommandText = "[GetCompanyLines]";
    this.DbSelectCommand3.CommandType = CommandType.StoredProcedure;
    this.DbSelectCommand3.Connection = this.cnSQL;
    this.DbSelectCommand3.Parameters.AddRange((Array) new DbParameter[4]
    {
      DefaultDatabase.CreateParameter("@companyLocationGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/),
      DefaultDatabase.CreateParameter("@lineGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/),
      DefaultDatabase.CreateParameter("@stateID", SqlDbType.Char, 2),
      DefaultDatabase.CreateParameter("@HideInactive", SqlDbType.Bit)
    });
    this.lnkApplyFilter.AutoSize = true;
    this.lnkApplyFilter.Location = new Point(333, 59);
    this.lnkApplyFilter.Name = "lnkApplyFilter";
    this.lnkApplyFilter.Size = new Size(61, 13);
    this.lnkApplyFilter.TabIndex = 17;
    this.lnkApplyFilter.TabStop = true;
    this.lnkApplyFilter.Text = "Apply Filter";
    appearance42.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.panelLoading.ContentAreaAppearance = (AppearanceBase) appearance42;
    ((Control) this.panelLoading).Controls.Add((Control) this.Label6);
    ((Control) this.panelLoading).Controls.Add((Control) this.PictureBox1);
    ((Control) this.panelLoading).Location = new Point(230, 158);
    ((Control) this.panelLoading).Name = "panelLoading";
    ((Control) this.panelLoading).Size = new Size(240 /*0xF0*/, 48 /*0x30*/);
    ((Control) this.panelLoading).TabIndex = 149;
    ((Control) this.panelLoading).Visible = false;
    this.Label6.AutoSize = true;
    this.Label6.Font = new Font("Tahoma", 11f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label6.Location = new Point(47, 15);
    this.Label6.Name = "Label6";
    this.Label6.Size = new Size(173, 18);
    this.Label6.TabIndex = 1;
    this.Label6.Text = "Loading ... please wait ...";
    this.PictureBox1.Image = (Image) componentResourceManager.GetObject("PictureBox1.Image");
    this.PictureBox1.Location = new Point(16 /*0x10*/, 16 /*0x10*/);
    this.PictureBox1.Name = "PictureBox1";
    this.PictureBox1.Size = new Size(16 /*0x10*/, 16 /*0x10*/);
    this.PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
    this.PictureBox1.TabIndex = 0;
    this.PictureBox1.TabStop = false;
    ((Control) this._frmCompanyLines_Toolbars_Dock_Area_Left).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._frmCompanyLines_Toolbars_Dock_Area_Left).BackColor = Color.White;
    this._frmCompanyLines_Toolbars_Dock_Area_Left.DockedPosition = (DockedPosition) 2;
    ((Control) this._frmCompanyLines_Toolbars_Dock_Area_Left).ForeColor = Color.Black;
    ((Control) this._frmCompanyLines_Toolbars_Dock_Area_Left).Location = new Point(0, 27);
    ((Control) this._frmCompanyLines_Toolbars_Dock_Area_Left).Name = "_frmCompanyLines_Toolbars_Dock_Area_Left";
    ((Control) this._frmCompanyLines_Toolbars_Dock_Area_Left).Size = new Size(0, 573);
    this._frmCompanyLines_Toolbars_Dock_Area_Left.ToolbarsManager = this.menumanager;
    this.menumanager.DesignerFlags = 1;
    this.menumanager.DockWithinContainer = (Control) this;
    this.menumanager.DockWithinContainerBaseType = typeof (Form);
    this.menumanager.ShowFullMenusDelay = 500;
    ultraToolbar.DockedColumn = 0;
    ultraToolbar.DockedRow = 0;
    ultraToolbar.IsMainMenuBar = true;
    ((UltraToolbarBase) ultraToolbar).NonInheritedTools.AddRange(new ToolBase[1]
    {
      (ToolBase) popupMenuTool1
    });
    ultraToolbar.Text = "MainMenu";
    this.menumanager.Toolbars.AddRange(new UltraToolbar[1]
    {
      ultraToolbar
    });
    appearance43.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance44.Image"));
    ((ToolPropsBase) ((ToolBase) popupMenuTool2).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance43;
    ((ToolPropsBase) ((ToolBase) popupMenuTool2).SharedPropsInternal).Caption = "Company/Line";
    ((ToolsCollectionBase) popupMenuTool2.Tools).AddRange(new ToolBase[10]
    {
      (ToolBase) popupMenuTool3,
      (ToolBase) popupMenuTool4,
      (ToolBase) popupMenuTool5,
      (ToolBase) buttonTool1,
      (ToolBase) buttonTool2,
      (ToolBase) buttonTool3,
      (ToolBase) buttonTool4,
      (ToolBase) buttonTool5,
      (ToolBase) buttonTool6,
      (ToolBase) buttonTool7
    });
    appearance44.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance45.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool8).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance44;
    ((ToolPropsBase) ((ToolBase) buttonTool8).SharedPropsInternal).Caption = "Assign &Raters...";
    appearance45.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance46.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool9).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance45;
    ((ToolPropsBase) ((ToolBase) buttonTool9).SharedPropsInternal).Caption = "Assign &Fees...";
    appearance46.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance47.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool10).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance46;
    ((ToolPropsBase) ((ToolBase) buttonTool10).SharedPropsInternal).Caption = "Copy...";
    appearance47.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance48.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool11).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance47;
    ((ToolPropsBase) ((ToolBase) buttonTool11).SharedPropsInternal).Caption = "Authorize &Offices...";
    appearance48.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance49.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool12).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance48;
    ((ToolPropsBase) ((ToolBase) buttonTool12).SharedPropsInternal).Caption = "Available &Billing Types...";
    appearance49.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance50.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool13).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance49;
    ((ToolPropsBase) ((ToolBase) buttonTool13).SharedPropsInternal).Caption = "&Document Automation...";
    ((ToolPropsBase) ((ToolBase) popupMenuTool6).SharedPropsInternal).Caption = "Company Info";
    ((ToolsCollectionBase) popupMenuTool6.Tools).AddRange(new ToolBase[3]
    {
      (ToolBase) buttonTool14,
      (ToolBase) buttonTool15,
      (ToolBase) buttonTool16
    });
    appearance50.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance51.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool17).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance50;
    ((ToolPropsBase) ((ToolBase) buttonTool17).SharedPropsInternal).Caption = "New Company...";
    appearance51.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance52.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool18).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance51;
    ((ToolPropsBase) ((ToolBase) buttonTool18).SharedPropsInternal).Caption = "New Contact...";
    appearance52.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance53.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool19).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance52;
    ((ToolPropsBase) ((ToolBase) buttonTool19).SharedPropsInternal).Caption = "View";
    appearance53.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance54.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool20).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance53;
    ((ToolPropsBase) ((ToolBase) buttonTool20).SharedPropsInternal).Caption = "&Installment Options...";
    appearance54.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance55.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool21).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance54;
    ((ToolPropsBase) ((ToolBase) buttonTool21).SharedPropsInternal).Caption = "Forms / Conditions / Warranties...";
    appearance55.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance56.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool22).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance55;
    ((ToolPropsBase) ((ToolBase) buttonTool22).SharedPropsInternal).Caption = "Policy Classes...";
    appearance56.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance57.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool23).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance56;
    ((ToolPropsBase) ((ToolBase) buttonTool23).SharedPropsInternal).Caption = "Construction Types...";
    appearance57.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance58.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool24).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance57;
    ((ToolPropsBase) ((ToolBase) buttonTool24).SharedPropsInternal).Caption = "Requirements...";
    ((ToolPropsBase) ((ToolBase) popupMenuTool7).SharedPropsInternal).Caption = "Producers";
    appearance58.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance59.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool25).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance58;
    ((ToolPropsBase) ((ToolBase) buttonTool25).SharedPropsInternal).Caption = "SIC Codes...";
    appearance59.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance60.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool26).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance59;
    ((ToolPropsBase) ((ToolBase) buttonTool26).SharedPropsInternal).Caption = "Commissions...";
    appearance60.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance61.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool27).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance60;
    ((ToolPropsBase) ((ToolBase) buttonTool27).SharedPropsInternal).Caption = "Payment Terms...";
    appearance61.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance62.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool28).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance61;
    ((ToolPropsBase) ((ToolBase) buttonTool28).SharedPropsInternal).Caption = "Policy Numbering...";
    ((ToolPropsBase) ((ToolBase) popupMenuTool8).SharedPropsInternal).Caption = "Underwriting Locations";
    ((ToolsCollectionBase) popupMenuTool8.Tools).AddRange(new ToolBase[2]
    {
      (ToolBase) buttonTool29,
      (ToolBase) buttonTool30
    });
    ((ToolPropsBase) ((ToolBase) popupMenuTool9).SharedPropsInternal).Caption = "Documents";
    ((ToolsCollectionBase) popupMenuTool9.Tools).AddRange(new ToolBase[3]
    {
      (ToolBase) buttonTool31,
      (ToolBase) buttonTool32,
      (ToolBase) buttonTool33
    });
    ((ToolPropsBase) ((ToolBase) popupMenuTool10).SharedPropsInternal).Caption = "Policies";
    ((ToolsCollectionBase) popupMenuTool10.Tools).AddRange(new ToolBase[13]
    {
      (ToolBase) popupMenuTool11,
      (ToolBase) popupMenuTool12,
      (ToolBase) popupMenuTool13,
      (ToolBase) buttonTool34,
      (ToolBase) buttonTool35,
      (ToolBase) buttonTool36,
      (ToolBase) buttonTool37,
      (ToolBase) buttonTool38,
      (ToolBase) buttonTool39,
      (ToolBase) buttonTool40,
      (ToolBase) buttonTool41,
      (ToolBase) buttonTool42,
      (ToolBase) buttonTool43
    });
    ((ToolPropsBase) ((ToolBase) popupMenuTool14).SharedPropsInternal).Caption = "Billing";
    ((ToolsCollectionBase) popupMenuTool14.Tools).AddRange(new ToolBase[3]
    {
      (ToolBase) buttonTool44,
      (ToolBase) buttonTool45,
      (ToolBase) buttonTool46
    });
    appearance62.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance63.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool47).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance62;
    ((ToolPropsBase) ((ToolBase) buttonTool47).SharedPropsInternal).Caption = "Generic Quote Wording...";
    appearance63.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance64.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool48).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance63;
    ((ToolPropsBase) ((ToolBase) buttonTool48).SharedPropsInternal).Caption = "Conditional Policy Forms...";
    ((ToolPropsBase) ((ToolBase) popupMenuTool15).SharedPropsInternal).Caption = "Line Ordering";
    ((ToolsCollectionBase) popupMenuTool15.Tools).AddRange(new ToolBase[2]
    {
      (ToolBase) buttonTool49,
      (ToolBase) buttonTool50
    });
    appearance64.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance65.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool51).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance64;
    ((ToolPropsBase) ((ToolBase) buttonTool51).SharedPropsInternal).Caption = "Move Up";
    appearance65.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance66.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool52).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance65;
    ((ToolPropsBase) ((ToolBase) buttonTool52).SharedPropsInternal).Caption = "Move Down";
    appearance66.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance67.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool53).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance66;
    ((ToolPropsBase) ((ToolBase) buttonTool53).SharedPropsInternal).Caption = "Assign Cost Centers...";
    appearance67.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance68.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool54).SharedPropsInternal).AppearancesLarge.Appearance = (AppearanceBase) appearance67;
    appearance68.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance69.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool54).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance68;
    ((ToolPropsBase) ((ToolBase) buttonTool54).SharedPropsInternal).Caption = "Copy to New Setup ...";
    appearance69.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance70.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool55).SharedPropsInternal).AppearancesLarge.Appearance = (AppearanceBase) appearance69;
    appearance70.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance71.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool55).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance70;
    ((ToolPropsBase) ((ToolBase) buttonTool55).SharedPropsInternal).Caption = "Logging Information";
    appearance71.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance72.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool56).SharedPropsInternal).AppearancesLarge.Appearance = (AppearanceBase) appearance71;
    appearance72.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance73.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool56).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance72;
    ((ToolPropsBase) ((ToolBase) buttonTool56).SharedPropsInternal).Caption = "Copy Rater Conditionals";
    appearance73.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance74.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool57).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance73;
    ((ToolPropsBase) ((ToolBase) buttonTool57).SharedPropsInternal).Caption = "Global Rater Update";
    appearance74.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance75.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool58).SharedPropsInternal).AppearancesLarge.Appearance = (AppearanceBase) appearance74;
    appearance75.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance76.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool58).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance75;
    ((ToolPropsBase) ((ToolBase) buttonTool58).SharedPropsInternal).Caption = "Cancellation Requirements ...";
    appearance76.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance77.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool59).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance76;
    ((ToolPropsBase) ((ToolBase) buttonTool59).SharedPropsInternal).Caption = "Copy Cost Centers";
    appearance77.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance78.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool60).SharedPropsInternal).AppearancesLarge.Appearance = (AppearanceBase) appearance77;
    appearance78.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance79.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool60).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance78;
    ((ToolPropsBase) ((ToolBase) buttonTool60).SharedPropsInternal).Caption = "Copy Policy Numbers";
    this.menumanager.Tools.AddRange(new ToolBase[38]
    {
      (ToolBase) popupMenuTool2,
      (ToolBase) buttonTool8,
      (ToolBase) buttonTool9,
      (ToolBase) buttonTool10,
      (ToolBase) buttonTool11,
      (ToolBase) buttonTool12,
      (ToolBase) buttonTool13,
      (ToolBase) popupMenuTool6,
      (ToolBase) buttonTool17,
      (ToolBase) buttonTool18,
      (ToolBase) buttonTool19,
      (ToolBase) buttonTool20,
      (ToolBase) buttonTool21,
      (ToolBase) buttonTool22,
      (ToolBase) buttonTool23,
      (ToolBase) buttonTool24,
      (ToolBase) popupMenuTool7,
      (ToolBase) buttonTool25,
      (ToolBase) buttonTool26,
      (ToolBase) buttonTool27,
      (ToolBase) buttonTool28,
      (ToolBase) popupMenuTool8,
      (ToolBase) popupMenuTool9,
      (ToolBase) popupMenuTool10,
      (ToolBase) popupMenuTool14,
      (ToolBase) buttonTool47,
      (ToolBase) buttonTool48,
      (ToolBase) popupMenuTool15,
      (ToolBase) buttonTool51,
      (ToolBase) buttonTool52,
      (ToolBase) buttonTool53,
      (ToolBase) buttonTool54,
      (ToolBase) buttonTool55,
      (ToolBase) buttonTool56,
      (ToolBase) buttonTool57,
      (ToolBase) buttonTool58,
      (ToolBase) buttonTool59,
      (ToolBase) buttonTool60
    });
    ((Control) this.dgView).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.menumanager.SetContextMenuUltra((Component) this.dgView, "fclCompany/Line");
    ((UltraGridBase) this.dgView).DataSource = (object) this.dsLines.ViewCompanyLines;
    appearance79.BackColor = Color.White;
    appearance79.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.dgView).DisplayLayout.Appearance = (AppearanceBase) appearance79;
    ((UltraGridBase) this.dgView).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 156;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Line";
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 2;
    ultraGridColumn2.Width = 316;
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn3.Header).Caption = "Company";
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Header.VisiblePosition = 1;
    ultraGridColumn3.Width = 282;
    ultraGridColumn4.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn4.Header.VisiblePosition = 3;
    ultraGridColumn4.Width = 165;
    ultraGridColumn5.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn5.Header.VisiblePosition = 4;
    ultraGridColumn5.Hidden = true;
    ultraGridColumn5.Width = 248;
    ultraGridColumn6.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn6.Header.VisiblePosition = 5;
    ultraGridBand1.Columns.AddRange(new object[6]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4,
      (object) ultraGridColumn5,
      (object) ultraGridColumn6
    });
    ultraGridColumn7.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn7.Header.VisiblePosition = 0;
    ultraGridColumn7.Hidden = true;
    ultraGridColumn8.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn8.Header).Caption = "Line";
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn8.Header.VisiblePosition = 2;
    ultraGridColumn8.Width = 188;
    ultraGridColumn9.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn9.Header).Caption = "Company";
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn9.Header.VisiblePosition = 1;
    ultraGridColumn9.Width = 380;
    ultraGridColumn10.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn10.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn10.Header.VisiblePosition = 3;
    ultraGridColumn10.Width = 176 /*0xB0*/;
    ultraGridColumn11.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn11.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn11.Header.VisiblePosition = 4;
    ultraGridColumn11.Hidden = true;
    ultraGridColumn12.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn12.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn12.Header.VisiblePosition = 5;
    ultraGridColumn12.Hidden = true;
    ultraGridBand2.Columns.AddRange(new object[6]
    {
      (object) ultraGridColumn7,
      (object) ultraGridColumn8,
      (object) ultraGridColumn9,
      (object) ultraGridColumn10,
      (object) ultraGridColumn11,
      (object) ultraGridColumn12
    });
    ((UltraGridBase) this.dgView).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.dgView).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.dgView).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance80.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance80.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.dgView).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance80;
    ((UltraGridBase) this.dgView).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.dgView).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.dgView).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    appearance81.BorderColor = Color.LightGray;
    ((UltraGridBase) this.dgView).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance81;
    ((UltraGridBase) this.dgView).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    ((UltraGridBase) this.dgView).DisplayLayout.Override.ExpansionIndicator = (ShowExpansionIndicator) 3;
    appearance82.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.dgView).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance82;
    ((UltraGridBase) this.dgView).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance83.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.dgView).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance83;
    appearance84.BorderColor = Color.LightGray;
    ((UltraGridBase) this.dgView).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance84;
    ((UltraGridBase) this.dgView).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance85.BackColor = Color.Transparent;
    appearance85.ForeColor = Color.Black;
    ((UltraGridBase) this.dgView).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance85;
    appearance86.BackColor = Color.WhiteSmoke;
    appearance86.BorderColor = Color.Silver;
    scrollBarLook.ButtonAppearance = (AppearanceBase) appearance86;
    appearance87.BackColor = Color.White;
    scrollBarLook.TrackAppearance = (AppearanceBase) appearance87;
    ((UltraGridBase) this.dgView).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.dgView).Location = new Point(7, 77);
    ((Control) this.dgView).Name = "dgView";
    ((Control) this.dgView).Size = new Size(784, 235);
    ((Control) this.dgView).TabIndex = 0;
    ((UltraControlBase) this.dgView).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dgView).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this._frmCompanyLines_Toolbars_Dock_Area_Right).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._frmCompanyLines_Toolbars_Dock_Area_Right).BackColor = Color.White;
    this._frmCompanyLines_Toolbars_Dock_Area_Right.DockedPosition = (DockedPosition) 3;
    ((Control) this._frmCompanyLines_Toolbars_Dock_Area_Right).ForeColor = Color.Black;
    ((Control) this._frmCompanyLines_Toolbars_Dock_Area_Right).Location = new Point(797, 27);
    ((Control) this._frmCompanyLines_Toolbars_Dock_Area_Right).Name = "_frmCompanyLines_Toolbars_Dock_Area_Right";
    ((Control) this._frmCompanyLines_Toolbars_Dock_Area_Right).Size = new Size(0, 573);
    this._frmCompanyLines_Toolbars_Dock_Area_Right.ToolbarsManager = this.menumanager;
    ((Control) this._frmCompanyLines_Toolbars_Dock_Area_Top).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._frmCompanyLines_Toolbars_Dock_Area_Top).BackColor = Color.White;
    this._frmCompanyLines_Toolbars_Dock_Area_Top.DockedPosition = (DockedPosition) 0;
    ((Control) this._frmCompanyLines_Toolbars_Dock_Area_Top).ForeColor = Color.Black;
    ((Control) this._frmCompanyLines_Toolbars_Dock_Area_Top).Location = new Point(0, 0);
    ((Control) this._frmCompanyLines_Toolbars_Dock_Area_Top).Name = "_frmCompanyLines_Toolbars_Dock_Area_Top";
    ((Control) this._frmCompanyLines_Toolbars_Dock_Area_Top).Size = new Size(797, 27);
    this._frmCompanyLines_Toolbars_Dock_Area_Top.ToolbarsManager = this.menumanager;
    ((Control) this._frmCompanyLines_Toolbars_Dock_Area_Bottom).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._frmCompanyLines_Toolbars_Dock_Area_Bottom).BackColor = Color.White;
    this._frmCompanyLines_Toolbars_Dock_Area_Bottom.DockedPosition = (DockedPosition) 1;
    ((Control) this._frmCompanyLines_Toolbars_Dock_Area_Bottom).ForeColor = Color.Black;
    ((Control) this._frmCompanyLines_Toolbars_Dock_Area_Bottom).Location = new Point(0, 600);
    ((Control) this._frmCompanyLines_Toolbars_Dock_Area_Bottom).Name = "_frmCompanyLines_Toolbars_Dock_Area_Bottom";
    ((Control) this._frmCompanyLines_Toolbars_Dock_Area_Bottom).Size = new Size(797, 0);
    this._frmCompanyLines_Toolbars_Dock_Area_Bottom.ToolbarsManager = this.menumanager;
    appearance88.BorderColor = Color.Gray;
    appearance88.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkHideInactive).Appearance = (AppearanceBase) appearance88;
    ((UltraToggleEditorBase) this.chkHideInactive).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkHideInactive).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkHideInactive).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkHideInactive).Location = new Point(691, 35);
    ((Control) this.chkHideInactive).Name = "chkHideInactive";
    ((Control) this.chkHideInactive).Size = new Size(100, 15);
    ((Control) this.chkHideInactive).TabIndex = 47;
    ((UltraToggleEditorBase) this.chkHideInactive).Text = "Hide Inactive";
    ((UltraControlBase) this.chkHideInactive).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkHideInactive).UseOsThemes = (DefaultableBoolean) 2;
    this.AutoScaleBaseSize = new Size(5, 13);
    this.BackColor = Color.White;
    this.ClientSize = new Size(797, 600);
    this.Controls.Add((Control) this.chkHideInactive);
    this.Controls.Add((Control) this.panelLoading);
    this.Controls.Add((Control) this.lnkApplyFilter);
    this.Controls.Add((Control) this.Label26);
    this.Controls.Add((Control) this.Label25);
    this.Controls.Add((Control) this.Label24);
    this.Controls.Add((Control) this.cbStateFilter);
    this.Controls.Add((Control) this.cbCompanyFilter);
    this.Controls.Add((Control) this.ultraTab);
    this.Controls.Add((Control) this.cbLineFilter);
    this.Controls.Add((Control) this.dgView);
    this.Controls.Add((Control) this._frmCompanyLines_Toolbars_Dock_Area_Left);
    this.Controls.Add((Control) this._frmCompanyLines_Toolbars_Dock_Area_Right);
    this.Controls.Add((Control) this._frmCompanyLines_Toolbars_Dock_Area_Bottom);
    this.Controls.Add((Control) this._frmCompanyLines_Toolbars_Dock_Area_Top);
    this.Font = new Font("Tahoma", 8f);
    this.ForeColor = Color.Black;
    this.MinimumSize = new Size(700, 546);
    this.Name = nameof (frmCompanyLines);
    this.Text = "Company Lines Management";
    ((Control) this.UltraTabPageControl1).ResumeLayout(false);
    ((Control) this.UltraTabPageControl1).PerformLayout();
    this.grpCompanyLineFiling.ResumeLayout(false);
    this.grpCompanyLineFiling.PerformLayout();
    ((ISupportInitialize) this.chkKeepPolicyNumberOnRewrite).EndInit();
    this.dsLines.EndInit();
    ((ISupportInitialize) this.chkSupportLossRuns).EndInit();
    ((ISupportInitialize) this.chkBlockUIExit).EndInit();
    ((ISupportInitialize) this.chkSupportPreIssuanceEndorsementNumbering).EndInit();
    ((ISupportInitialize) this.chkInsuredFEINSSN).EndInit();
    ((ISupportInitialize) this.chkAllowLapseInCoverage).EndInit();
    ((ISupportInitialize) this.chkBlockXSPremium).EndInit();
    ((ISupportInitialize) this.MgaCheckBox1).EndInit();
    ((ISupportInitialize) this.chkUniquePolicyNumbers).EndInit();
    ((ISupportInitialize) this.txtBackdateDays).EndInit();
    ((ISupportInitialize) this.txtBinderExpiration).EndInit();
    ((ISupportInitialize) this.numMinimumEarnedPercentage).EndInit();
    ((ISupportInitialize) this.cboParent).EndInit();
    ((ISupportInitialize) this.cboCompanyLicensed).EndInit();
    ((ISupportInitialize) this.cboCompanySignature).EndInit();
    ((ISupportInitialize) this.cboStatus).EndInit();
    ((ISupportInitialize) this.cbCompanies).EndInit();
    ((ISupportInitialize) this.cbLines).EndInit();
    ((ISupportInitialize) this.cbStates).EndInit();
    ((ISupportInitialize) this.cbLicenseType).EndInit();
    ((Control) this.UltraTabPageControl5).ResumeLayout(false);
    ((Control) this.UltraTabPageControl5).PerformLayout();
    ((ISupportInitialize) this.cboDefaultFinanceCo).EndInit();
    ((ISupportInitialize) this.GroupBox2).EndInit();
    ((Control) this.GroupBox2).ResumeLayout(false);
    ((Control) this.GroupBox2).PerformLayout();
    ((ISupportInitialize) this.MgaNumericEditor2).EndInit();
    ((ISupportInitialize) this.MgaNumericEditor1).EndInit();
    ((ISupportInitialize) this.chkWaivePremium).EndInit();
    ((ISupportInitialize) this.txtInvoiceDays).EndInit();
    ((ISupportInitialize) this.GroupBox1).EndInit();
    ((Control) this.GroupBox1).ResumeLayout(false);
    ((Control) this.GroupBox1).PerformLayout();
    ((ISupportInitialize) this.txtNOCGracePeriod).EndInit();
    ((ISupportInitialize) this.chkIncludeFeesNOC).EndInit();
    ((ISupportInitialize) this.txtEmailReminderDays).EndInit();
    ((ISupportInitialize) this.txtNOCDays).EndInit();
    ((ISupportInitialize) this.txtMailingDays).EndInit();
    ((ISupportInitialize) this.chkEmailReminder).EndInit();
    ((ISupportInitialize) this.chkAutoNOC).EndInit();
    ((ISupportInitialize) this.txtDefaultInvoiceComment).EndInit();
    ((Control) this.UltraTabPageControl6).ResumeLayout(false);
    ((Control) this.UltraTabPageControl6).PerformLayout();
    ((ISupportInitialize) this.txtQuoteAdditionalComments).EndInit();
    ((Control) this.UltraTabPageControl2).ResumeLayout(false);
    ((Control) this.UltraTabPageControl2).PerformLayout();
    ((ISupportInitialize) this.txtBinderComments).EndInit();
    ((Control) this.UltraTabPageControl3).ResumeLayout(false);
    ((ISupportInitialize) this.grpRenewalForms).EndInit();
    ((Control) this.grpRenewalForms).ResumeLayout(false);
    ((ISupportInitialize) this.chkClearRenewalTemplates).EndInit();
    ((ISupportInitialize) this.chkClearRenewalForms).EndInit();
    ((ISupportInitialize) this.chkResetSubjectivities).EndInit();
    ((ISupportInitialize) this.chkResetFCWRecords).EndInit();
    ((ISupportInitialize) this.GroupBox3).EndInit();
    ((ISupportInitialize) this.cbStateFilter).EndInit();
    ((ISupportInitialize) this.cbLineFilter).EndInit();
    ((ISupportInitialize) this.cbCompanyFilter).EndInit();
    ((ISupportInitialize) this.err).EndInit();
    ((ISupportInitialize) this.ultraTab).EndInit();
    ((Control) this.ultraTab).ResumeLayout(false);
    ((Control) this.UltraTabSharedControlsPage1).ResumeLayout(false);
    ((ISupportInitialize) this.panelLoading).EndInit();
    ((Control) this.panelLoading).ResumeLayout(false);
    ((Control) this.panelLoading).PerformLayout();
    ((ISupportInitialize) this.PictureBox1).EndInit();
    ((ISupportInitialize) this.menumanager).EndInit();
    ((ISupportInitialize) this.dgView).EndInit();
    ((ISupportInitialize) this.chkHideInactive).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  [field: AccessedThroughProperty("rbNone")]
  protected virtual RadioButton rbNone { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("rbInside")]
  protected virtual RadioButton rbInside { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("rbOutside")]
  protected virtual RadioButton rbOutside { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("_bmb")]
  private virtual BindingManagerBase _bmb { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public frmCompanyLines()
  {
    this.FormClosing += new FormClosingEventHandler(this.frmCompanyLines_FormClosing);
    this.Load += new EventHandler(this.Form_Load);
    this._bindings = new Dictionary<string, Binding>();
    this._dataSources = new Dictionary<string, frmCompanyLines.ComboBoxDataSource>();
    this._gridLayout = new MemoryStream();
    this._settingNOCDays = 30;
    this._quotesExist = new Dictionary<Guid, bool>();
    this.InitializeComponent();
  }

  private void frmCompanyLines_FormClosing(object sender, FormClosingEventArgs e)
  {
    if (this._filterThread != null && this._filterThread.IsAlive)
      this._filterThread.Abort();
    if (this._fillThread != null && this._fillThread.IsAlive)
    {
      this._fillThread.Abort();
      this._fillThread = (Thread) null;
    }
    MDIControls.Instance.StatusBarText = string.Empty;
  }

  protected virtual void Form_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    Cursor.Current = MgaCursors.WaitCursor;
    this._UpdateFormData = SecurityManager.Instance.AssertPermission("{80B7143D-BAB0-499F-8480-4A345F912298}");
    this._UpdateUniquePolicyNumber = SecurityManager.Instance.AssertPermission("{30823EC2-9D44-4C32-ADB9-DEA42B77E5F9}");
    this.SetControlsEnabledState();
    this._bmb = this.BindingContext[(object) this.dsLines, this.dsLines.tblCompanyLines.TableName];
    this.dsLines.Parents.DefaultView.Sort = "Parent";
    this.dsLines.ViewCompanyLines.DefaultView.Sort = "Name, LineName";
    this.dsLines.ViewCompanyLinesChildren.DefaultView.Sort = "Name, LineName";
    ((Control) this.cbCompanyFilter).Enabled = false;
    ((Control) this.cbLineFilter).Enabled = false;
    ((Control) this.cbStateFilter).Enabled = false;
    this.dbSave.Enabled = false;
    this.SetupSecurity();
    if (SystemSettings.KeyExists("DaysNOCForNonPayment"))
      this._settingNOCDays = Decimal.ToInt32(Conversions.ToDecimal((object) SystemSettings.GetNumericSetting("DaysNOCForNonPayment")));
    this.FillData();
    this.RelocateClientControl();
    this.grpCompanyLineFiling.Visible = SystemSettings.KeyExists("ShowCompanyLineFiling") && SystemSettings.GetBoolSetting("ShowCompanyLineFiling");
    this._canViewNOCGracePeriod = SystemSettings.KeyExists("CompanyLines.ViewNOCGracePeriod") && SystemSettings.GetBoolSetting("CompanyLines.ViewNOCGracePeriod");
    this.lblNOCGracePeriod.Visible = this._canViewNOCGracePeriod;
    ((Control) this.txtNOCGracePeriod).Visible = this._canViewNOCGracePeriod;
  }

  private void RelocateClientControl()
  {
    try
    {
      foreach (Control control in ((Control) this.UltraTabPageControl1).Controls)
      {
        if (control.Name.Equals("chkIntentToCancel"))
        {
          control.Location = new Point(70, 201);
          break;
        }
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void StoreBindings()
  {
    ((UltraGridBase) this.dgView).DisplayLayout.Save((Stream) this._gridLayout);
    ((UltraGridBase) this.dgView).DataSource = (object) null;
    foreach (UltraTab tab in ((UltraTabControlBase) this.ultraTab).Tabs)
    {
      try
      {
        foreach (Control control in ((Control) tab.TabPage).Controls)
        {
          if (control.DataBindings.Count > 0)
          {
            Binding binding = new Binding(control.DataBindings[0].PropertyName, RuntimeHelpers.GetObjectValue(control.DataBindings[0].DataSource), control.DataBindings[0].BindingMemberInfo.BindingMember);
            this._bindings.Add(control.Name, binding);
            control.DataBindings.Clear();
          }
          if (control is MGASimpleComboBox mgaSimpleComboBox)
          {
            frmCompanyLines.ComboBoxDataSource comboBoxDataSource = new frmCompanyLines.ComboBoxDataSource(RuntimeHelpers.GetObjectValue(((UltraGridBase) mgaSimpleComboBox).DataSource), ((UltraDropDownBase) mgaSimpleComboBox).DisplayMember);
            this._dataSources.Add(control.Name, comboBoxDataSource);
            ((UltraGridBase) mgaSimpleComboBox).DataSource = (object) null;
          }
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
  }

  public void RestoreBindings()
  {
    foreach (UltraTab tab in ((UltraTabControlBase) this.ultraTab).Tabs)
    {
      try
      {
        foreach (Control control in ((Control) tab.TabPage).Controls)
        {
          if (this._bindings.ContainsKey(control.Name))
            control.DataBindings.Add(this._bindings[control.Name]);
          if (control is MGASimpleComboBox mgaSimpleComboBox)
          {
            frmCompanyLines.ComboBoxDataSource dataSource = this._dataSources[control.Name];
            ((UltraGridBase) mgaSimpleComboBox).DataSource = RuntimeHelpers.GetObjectValue(dataSource.DataSource);
            ((UltraDropDownBase) mgaSimpleComboBox).DisplayMember = dataSource.DisplayMember;
          }
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
    ((UltraGridBase) this.dgView).DataSource = (object) this.dsLines.ViewCompanyLines;
    this._gridLayout.Position = 0L;
    ((UltraGridBase) this.dgView).DisplayLayout.Load((Stream) this._gridLayout);
    ((UltraGridBase) this.dgView).DisplayLayout.ScrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
    this._bindings.Clear();
    this._dataSources.Clear();
  }

  private void FillDataThread()
  {
    this.dsLines.tblUsers.AddtblUsersRow(Guid.Empty, string.Empty);
    this.dsLines.FinanceCompanies.AddFinanceCompaniesRow(Guid.Empty, string.Empty);
    this.daCompanyLines.TableMappings.Clear();
    DataTableMappingCollection tableMappings1 = this.daCompanyLines.TableMappings;
    tableMappings1.Add("Table", this.dsLines.lstLines.TableName);
    tableMappings1.Add("Table1", this.dsLines.lstStates.TableName);
    tableMappings1.Add("Table2", this.dsLines.lstLicenseTypes.TableName);
    tableMappings1.Add("Table3", this.dsLines.lstCompanyLicenseTypes.TableName);
    tableMappings1.Add("Table4", this.dsLines.tblUsers.TableName);
    tableMappings1.Add("Table5", this.dsLines.lstStatus.TableName);
    tableMappings1.Add("Table6", this.dsLines.lstPaymentMethods.TableName);
    tableMappings1.Add("Table7", this.dsLines.tblCompanyLocations.TableName);
    tableMappings1.Add("Table8", this.dsLines.FinanceCompanies.TableName);
    DataTableMappingCollection tableMappings2 = this.daGetCompanyLine.TableMappings;
    tableMappings2.Add("Table", this.dsLines.tblCompanyLines.TableName);
    tableMappings2.Add("Table1", this.dsLines.ViewCompanyLines.TableName);
    tableMappings2.Add("Table2", this.dsLines.ViewCompanyLinesChildren.TableName);
    tableMappings2.Add("Table3", this.dsLines.Parents.TableName);
    try
    {
      foreach (DataTable table in (InternalDataCollectionBase) this.dsLines.Tables)
        table.BeginLoadData();
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    try
    {
      DefaultDatabase.LoadDataSet((DataSet) this.dsLines, new string[9]
      {
        this.dsLines.lstLines.TableName,
        this.dsLines.lstStates.TableName,
        this.dsLines.lstLicenseTypes.TableName,
        this.dsLines.lstCompanyLicenseTypes.TableName,
        this.dsLines.tblUsers.TableName,
        this.dsLines.lstStatus.TableName,
        this.dsLines.lstPaymentMethods.TableName,
        this.dsLines.tblCompanyLocations.TableName,
        this.dsLines.FinanceCompanies.TableName
      }, "dbo.GetCompanyLineFormData", new object[2]
      {
        (object) "@UserGuid",
        (object) CurrentUser.Instance.UserGUID
      });
    }
    catch (ConstraintException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      this.ShowErrorOnUIThread(ex);
      ProjectData.ClearProjectError();
    }
    if (!this.IsHandleCreated || this.IsDisposed || this.Disposing)
      return;
    this.Invoke((Delegate) new frmCompanyLines.FillDataThreadCompleteDelegate(this.FillDataThreadComplete));
  }

  private void ShowErrorOnUIThread(ConstraintException ex)
  {
    if (MDIControls.Instance.MDIParent.InvokeRequired)
      MDIControls.Instance.MDIParent.Invoke((Delegate) new frmCompanyLines.ShowErrorOnUIThreadHandler(this.ShowErrorOnUIThread), (object) ex);
    else
      ErrorHandler.ShowDataSetErrors((DataSet) this.dsLines, ex);
  }

  private void FillDataThreadComplete()
  {
    // ISSUE: unable to decompile the method.
  }

  private void FillData()
  {
    Cursor.Current = MgaCursors.WaitCursor;
    this.StoreBindings();
    this._fillThread = new Thread(new ThreadStart(this.FillDataThread));
    Thread fillThread = this._fillThread;
    fillThread.IsBackground = true;
    fillThread.Name = "Company Lines - Fill Data";
    fillThread.Start();
  }

  public Guid CompanyLineGuidFilter
  {
    get => this._companyLineGuidFilter;
    set => this._companyLineGuidFilter = value;
  }

  public Guid CompanyLocationGuidFilter
  {
    get => this._companyLocationGuidFilter;
    set => this._companyLocationGuidFilter = value;
  }

  public object SelectedLine => this.cbLines.Value;

  public object SelectedCompanyLicense => this.cboCompanyLicensed.Value;

  public object SelectedCompany => this.cbCompanies.Value;

  public object SelectedState => this.cbStates.Value;

  private void RefillView()
  {
    DefaultDatabase.DataAdapterFill(this.daGetCompanyLine, (DataSet) this.dsLines);
  }

  private void dgView_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Delete || ((UltraGridBase) this.dgView).ActiveRow == null)
      return;
    this.DeleteRow();
  }

  private void SetupSecurity()
  {
    ((ToolsCollectionBase) this.menumanager.Tools)["Assign Fees"].SharedProps.Visible = SecurityManager.Instance.AssertPermission("{A43461BA-305B-4911-8AE3-145BCBD9B9F8}");
    ((ToolsCollectionBase) this.menumanager.Tools)["Assign Raters"].SharedProps.Visible = SecurityManager.Instance.AssertPermission("{DC60B27B-78EC-4c89-9750-FAC8B385565A}");
  }

  private void ParseNumber(object sender, ConvertEventArgs e)
  {
    if (!e.Value.Equals((object) string.Empty))
      return;
    e.Value = (object) DBNull.Value;
  }

  private void dgView_MouseDown(object sender, MouseEventArgs e)
  {
    if (e.Button != MouseButtons.Right)
      return;
    UIElement lastElementEntered = ((ControlUIElementBase) ((UltraGridBase) this.dgView).DisplayLayout.UIElement).LastElementEntered;
    if (lastElementEntered == null)
      return;
    UltraGridRow context = (UltraGridRow) lastElementEntered.GetContext(typeof (UltraGridRow), true);
    if (context == null)
      return;
    ((UltraGridBase) this.dgView).ActiveRow = context;
    this.dgView.Selected.Rows.Clear();
    context.Selected = true;
  }

  private void dbSave_UIStateChanged(object sender, EventArgs e)
  {
    int uiState = (int) this.dbSave.UIState;
    this.SetControlsEnabledState();
  }

  private void SetControlsEnabledState()
  {
    if (this._bmb == null || this._bmb.Position == -1)
    {
      foreach (UltraTab tab in ((UltraTabControlBase) this.ultraTab).Tabs)
      {
        try
        {
          foreach (Control control in ((Control) tab.TabPage).Controls)
          {
            if (control != this.dbSave)
              control.Enabled = false;
          }
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
      }
    }
    else
    {
      this.Cursor = MgaCursors.WaitCursor;
      bool flag = this.dbSave.UIState == UIState.Editing;
      this.lnkApplyFilter.Enabled = !flag;
      ((Control) this.dgView).Enabled = !flag;
      Guid companyLineGuid = this.dsLines.tblCompanyLines[this._bmb.Position].CompanyLineGuid;
      bool boolean;
      if (!this._quotesExist.TryGetValue(companyLineGuid, out boolean))
      {
        boolean = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT CASE WHEN EXISTS(SELECT 1 FROM dbo.tblQuotes WITH (NOLOCK) WHERE CompanyLineGuid=@CompanyLineGuid) THEN 1 ELSE 0 END", new object[2]
        {
          (object) "@CompanyLineGuid",
          (object) companyLineGuid
        })));
        this._quotesExist.Add(companyLineGuid, boolean);
      }
      foreach (UltraTab tab in ((UltraTabControlBase) this.ultraTab).Tabs)
      {
        try
        {
          foreach (Control control in ((Control) tab.TabPage).Controls)
          {
            if (flag && (control == this.cbLines || control == this.cbStates || control == this.cbCompanies || control == this.cboParent))
            {
              if (this.dsLines.tblCompanyLines[this._bmb.Position].RowState != DataRowState.Added && this.dsLines.tblCompanyLines[this._bmb.Position].RowState != DataRowState.Deleted)
                control.Enabled = !boolean && this._UpdateFormData;
            }
            else if (!(control is MGASystems.Tools.DBSaveUI.DBSaveUI))
              control.Enabled = flag && this._UpdateFormData;
          }
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
      }
      this.dbSave.Enabled = this._UpdateFormData;
      this.lnkApplyFilter.Enabled = true;
      ((Control) this.chkUniquePolicyNumbers).Enabled = this._UpdateUniquePolicyNumber && flag;
      ((Control) this.cbCompanies).Enabled = this._UpdateFormData && !boolean && flag;
      ((Control) this.cbLines).Enabled = this._UpdateFormData && !boolean && flag;
      ((Control) this.cbStates).Enabled = this._UpdateFormData && !boolean && flag;
      if (this._UpdateUniquePolicyNumber)
        this.dbSave.Enabled = true;
      this.lnkCPF.Enabled = true;
      this.lnkFCW.Enabled = true;
      this.lnkDocAuto.Enabled = true;
      this.Cursor = MgaCursors.Default;
    }
  }

  private void FilterGridThread()
  {
    try
    {
      this.dsLines.ViewCompanyLinesChildren.Clear();
      this.dsLines.ViewCompanyLines.Clear();
      this.dsLines.tblCompanyLines.Clear();
    }
    catch (ArgumentOutOfRangeException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ProjectData.ClearProjectError();
    }
    DbCommand selectCommand = this.daGetCompanyLine.SelectCommand;
    selectCommand.Parameters["@CompanyLocationGuid"].Value = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cbCompanyFilter.Text, "Any", false) == 0 ? (object) null : RuntimeHelpers.GetObjectValue(this.cbCompanyFilter.Value);
    selectCommand.Parameters["@lineGuid"].Value = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cbLineFilter.Text, "Any", false) == 0 ? (object) null : RuntimeHelpers.GetObjectValue(this.cbLineFilter.Value);
    selectCommand.Parameters["@stateID"].Value = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cbStateFilter.Text, "Any", false) == 0 ? (object) null : RuntimeHelpers.GetObjectValue(this.cbStateFilter.Value);
    selectCommand.Parameters["@HideInactive"].Value = (object) ((UltraToggleEditorBase) this.chkHideInactive).Checked;
    try
    {
      this.daGetCompanyLine.SelectCommand.Connection = DefaultDatabase.CreateDbConnection();
      DefaultDatabase.DataAdapterFill(this.daGetCompanyLine, (DataSet) this.dsLines);
    }
    catch (NullReferenceException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ProjectData.ClearProjectError();
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ErrorHandler.HandleErrorOnThread((Control) MDIControls.Instance.MDIParent, ex);
      ProjectData.ClearProjectError();
    }
    MDIControls.Instance.MDIParent.Invoke((Delegate) new frmCompanyLines.FilterGridThreadCompleteHandler(this.FilterGridThreadComplete));
  }

  private void FilterGridThreadComplete()
  {
    ((Control) this.panelLoading).Visible = false;
    ((UltraGridBase) this.dgView).DataSource = (object) this.dsLines.ViewCompanyLines;
    this._gridLayout.Position = 0L;
    ((UltraGridBase) this.dgView).DisplayLayout.Load((Stream) this._gridLayout);
    this.RestoreBindings();
    if (this.dsLines.ViewCompanyLines.Count > 0)
    {
      this._bmb.Position = 0;
      ((UltraGridBase) this.dgView).ActiveRow = ((UltraGridBase) this.dgView).Rows[0];
      ((UltraGridBase) this.dgView).Rows[0].Selected = true;
      this.dbSave.UIState = UIState.HasRecordsNotEditing;
    }
    else
    {
      this._bmb.Position = -1;
      this.dbSave.UIState = UIState.NoRecordsNotEditing;
    }
    this.lnkApplyFilter.Enabled = true;
    this.dbSave.Enabled = true;
    ((Control) this.cbCompanyFilter).Enabled = true;
    ((Control) this.cbStateFilter).Enabled = true;
    ((Control) this.cbLineFilter).Enabled = true;
    this.SetControlsEnabledState();
    Cursor.Current = Cursors.Default;
  }

  private void FilterGrid()
  {
    ((Control) this.panelLoading).Visible = true;
    this.lnkApplyFilter.Enabled = false;
    this.dbSave.Enabled = false;
    ((Control) this.cbCompanyFilter).Enabled = false;
    ((Control) this.cbStateFilter).Enabled = false;
    ((Control) this.cbLineFilter).Enabled = false;
    this.StoreBindings();
    if (this._filterThread != null && this._filterThread.IsAlive)
      this._filterThread.Abort();
    Cursor.Current = MgaCursors.Working;
    this._filterThread = new Thread(new ThreadStart(this.FilterGridThread));
    this._filterThread.Name = "FilterGridDelay";
    this._filterThread.IsBackground = true;
    this._filterThread.Start();
  }

  private void ClearCombosAndRadioButtons()
  {
    foreach (UltraTab tab in ((UltraTabControlBase) this.ultraTab).Tabs)
    {
      try
      {
        foreach (Control control in ((Control) tab.TabPage).Controls)
        {
          if (control is MGASimpleComboBox mgaSimpleComboBox)
          {
            ((UltraDropDownBase) mgaSimpleComboBox).SelectedRow = (UltraGridRow) null;
            ((Control) mgaSimpleComboBox).Enabled = true;
          }
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
    this.rbInside.Checked = false;
    this.rbOutside.Checked = false;
    this.rbNone.Checked = false;
  }

  private void AssignFiling()
  {
    this.rbOutside.Checked = false;
    this.rbInside.Checked = false;
    this.rbNone.Checked = false;
    if (this._bmb.Position == -1 || this.dsLines.tblCompanyLines[this._bmb.Position].IsFilingNull())
      return;
    string filing = this.dsLines.tblCompanyLines[this._bmb.Position].Filing;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(filing, "O", false) != 0)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(filing, "I", false) != 0)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(filing, "N", false) != 0)
          throw new InvalidOperationException("Unexpected Company/Line Filing Type");
        this.rbNone.Checked = true;
      }
      else
        this.rbInside.Checked = true;
    }
    else
      this.rbOutside.Checked = true;
  }

  private void dgView_AfterSelectChange(object sender, AfterSelectChangeEventArgs e)
  {
    try
    {
      if (((UltraGridBase) this.dgView).ActiveRow == null || !this._fireHandler)
        return;
      Database.MoveTo(RuntimeHelpers.GetObjectValue(((UltraGridBase) this.dgView).ActiveRow.Cells["CompanyLineGuid"].Value), "CompanyLineGuid", (DataTable) this.dsLines.tblCompanyLines, this._bmb);
      this.AssignFiling();
      this.dsLines.tblCompanyLines.AcceptChanges();
      if (this.dbSave.UIState != UIState.Editing)
        this.dbSave.UIState = UIState.HasRecordsNotEditing;
      if (this._bmb.Position == -1)
        return;
      this.UpdateAfterBindingChanged(this.dsLines.tblCompanyLines[this._bmb.Position].CompanyLineGuid);
    }
    catch (ArgumentOutOfRangeException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ProjectData.ClearProjectError();
    }
  }

  private void lnkApplyFilter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.FilterGrid();
  }

  private string GetDataValue(object controlValue)
  {
    string dataValue = "Empty";
    if (controlValue != DBNull.Value && controlValue != null)
      dataValue = controlValue.ToString();
    return dataValue;
  }

  private Dictionary<string, string> GetDataColumns()
  {
    return new Dictionary<string, string>()
    {
      {
        "CompanyLicenseTypeID",
        "Licensed - " + this.GetDataValue((object) this.cboCompanyLicensed.Text)
      },
      {
        "StatusID",
        "Status - " + this.GetDataValue((object) this.cboStatus.Text)
      },
      {
        "UserSignatureGuid",
        "Signature - " + this.GetDataValue((object) this.cboCompanySignature.Text)
      },
      {
        "LicenseTypeID",
        "Lic - " + this.GetDataValue((object) this.cbLicenseType.Text)
      },
      {
        "BinderExpirationDays",
        "Binder Expiration - " + this.GetDataValue(RuntimeHelpers.GetObjectValue(this.txtBinderExpiration.Value))
      },
      {
        "MinimumEarnedPercentage",
        "Minimum Earned % - " + this.GetDataValue(RuntimeHelpers.GetObjectValue(this.numMinimumEarnedPercentage.Value))
      },
      {
        "MaxBackdateDays",
        "Max Backdate days - " + this.GetDataValue(RuntimeHelpers.GetObjectValue(this.txtBackdateDays.Value))
      },
      {
        "AllowEndorsementsWithoutIssuance",
        "Allow Endorsements Without Issuance - " + this.GetDataValue((object) ((UltraToggleEditorBase) this.MgaCheckBox1).Checked)
      },
      {
        "EnforceUniquePolicyNumbers",
        "Enforce Unique Policy Numbers - " + this.GetDataValue((object) ((UltraToggleEditorBase) this.chkUniquePolicyNumbers).Checked)
      },
      {
        "QuoteAdditionalComments",
        "Default Additional Comments - " + this.GetDataValue((object) ((TextEditorControlBase) this.txtQuoteAdditionalComments).Text)
      },
      {
        "NOCIncludeFees",
        "Include Commissionable Fees in NOC Calculation - " + this.GetDataValue((object) ((UltraToggleEditorBase) this.chkIncludeFeesNOC).Checked)
      },
      {
        "AllowAutomaticNOC",
        "Allow Automatic NOC For Non-Payment of Premiums - " + this.GetDataValue((object) ((UltraToggleEditorBase) this.chkAutoNOC).Checked)
      },
      {
        "BinderComments",
        "Binder Comments - " + this.GetDataValue((object) ((TextEditorControlBase) this.txtBinderComments).Text)
      },
      {
        "InvoiceMailingDays",
        "# days to print invoice before due - " + this.GetDataValue(RuntimeHelpers.GetObjectValue(this.txtInvoiceDays.Value))
      },
      {
        "EmailReminder",
        "Send Email Reminder - " + this.GetDataValue((object) ((UltraToggleEditorBase) this.chkEmailReminder).Checked)
      },
      {
        "EmailReminderDays",
        "# of days to send email reminder before due - " + this.GetDataValue((object) ((TextEditorControlBase) this.txtEmailReminderDays).Text)
      },
      {
        "MailingNumDays",
        "Mailing Days - " + this.GetDataValue((object) ((TextEditorControlBase) this.txtMailingDays).Text)
      },
      {
        "NocNumDays",
        "NOC Days - " + this.GetDataValue((object) ((TextEditorControlBase) this.txtNOCDays).Text)
      },
      {
        "BlockXSPremium",
        "Block XS Premium = " + this.GetDataValue((object) ((UltraToggleEditorBase) this.chkBlockXSPremium).Checked)
      },
      {
        "AllowLapseOnRenewal",
        "Allow Lapse in Coverage On Renewal =  " + this.GetDataValue((object) ((UltraToggleEditorBase) this.chkAllowLapseInCoverage).Checked)
      },
      {
        "PackageOrder",
        "Ordering of Child Lines"
      },
      {
        "InsuredFEINSSNRequiredOnBind",
        "Insured FEIN or SSN Required On Bind"
      },
      {
        "SupportPreIssuanceEndorsementNumbering",
        "Support Pre-Issuance Endorsement Numbering"
      },
      {
        "MinWaivePremium",
        "Min Waive Premium Amount -- > " + this.GetDataValue(RuntimeHelpers.GetObjectValue(this.MgaNumericEditor1.Value))
      },
      {
        "MaxWaivePremium",
        "Max Waive Premium Amount -- > " + this.GetDataValue(RuntimeHelpers.GetObjectValue(this.MgaNumericEditor2.Value))
      },
      {
        "WaivePremium",
        "Waive Premium - " + this.GetDataValue((object) ((UltraToggleEditorBase) this.chkWaivePremium).Checked)
      },
      {
        "BlockUIExitOnBlankRenewalInformation",
        "Prevent Policy Edit Screen from closing with no Expiring Carrier = " + this.GetDataValue((object) ((UltraToggleEditorBase) this.chkBlockUIExit).Checked)
      },
      {
        "SupportLossRuns",
        "Support Loss Runs =  " + this.GetDataValue((object) ((UltraToggleEditorBase) this.chkSupportLossRuns).Checked)
      },
      {
        "DefaultFinanceGUID",
        "Default Finance Company = " + this.GetDataValue((object) this.cboDefaultFinanceCo.Text)
      },
      {
        "ClearCompletedTemplatesOnRenewal",
        "Renewals: Clear Completed Templates = " + this.GetDataValue((object) ((UltraToggleEditorBase) this.chkClearRenewalTemplates).Checked)
      },
      {
        "ClearUserModifiedFCWOnRenewal",
        "Renewals: Clear Modified FCW = " + this.GetDataValue((object) ((UltraToggleEditorBase) this.chkResetFCWRecords).Checked)
      },
      {
        "ResetAppliedSubjectivities",
        "Renewals: Reset Subjectivities Added/Waived = " + this.GetDataValue((object) ((UltraToggleEditorBase) this.chkResetSubjectivities).Checked)
      },
      {
        "KeepPolicyNumberOnRewrites",
        "Keep Policy #s On Rewrites" + this.GetDataValue((object) ((UltraToggleEditorBase) this.chkKeepPolicyNumberOnRewrite).Checked)
      },
      {
        "Filing",
        "Filing" + this.GetFiling()
      }
    };
  }

  private string GetFiling()
  {
    string filing = "Empty";
    if (this.rbOutside.Checked)
      filing = "O";
    else if (this.rbInside.Checked)
      filing = "I";
    else if (this.rbNone.Checked)
      filing = "N";
    return filing;
  }

  private object GetFilingValue()
  {
    object filingValue = (object) DBNull.Value;
    if (this.rbOutside.Checked)
      filingValue = (object) "O";
    else if (this.rbInside.Checked)
      filingValue = (object) "I";
    else if (this.rbNone.Checked)
      filingValue = (object) "N";
    return filingValue;
  }

  private void SetFilingValue(dsCompanyLines.tblCompanyLinesRow drCL)
  {
    if (this.rbOutside.Checked)
      drCL.Filing = "O";
    else if (this.rbInside.Checked)
      drCL.Filing = "I";
    else if (this.rbNone.Checked)
      drCL.Filing = "N";
    else
      drCL.SetFilingNull();
  }

  private void lnkAdminCommissions_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    MGASystems.Common.FormSettings.ShowForm(ObjectFactory.Instance.CreateTypeFromString("MGASystems.IMS.Policies.Commissions.frmAdminCommissions"));
  }

  private void SwapUltragridChildRows(dsCompanyLines.tblCompanyLinesRow dr, Guid rowToSwap)
  {
    IEnumerable rowEnumerator = ((UltraGridBase) this.dgView).DisplayLayout.Bands[1].GetRowEnumerator((GridRowType) 1);
    if (rowEnumerator == null)
      return;
    UltraGridRow ultraGridRow1 = (UltraGridRow) null;
    try
    {
      foreach (UltraGridRow ultraGridRow2 in rowEnumerator)
      {
        if (ultraGridRow2.Cells["CompanyLineGuid"].Value.Equals((object) rowToSwap))
        {
          ultraGridRow1 = ultraGridRow2;
          break;
        }
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    dsCompanyLines.ViewCompanyLinesChildrenRow linesChildrenRow = (dsCompanyLines.ViewCompanyLinesChildrenRow) null;
    try
    {
      foreach (dsCompanyLines.ViewCompanyLinesChildrenRow companyLinesChild in (TypedTableBase<dsCompanyLines.ViewCompanyLinesChildrenRow>) this.dsLines.ViewCompanyLinesChildren)
      {
        Guid companyLineGuid = companyLinesChild.CompanyLineGuid;
        string Left = companyLineGuid.ToString();
        companyLineGuid = dr.CompanyLineGuid;
        string Right = companyLineGuid.ToString();
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, Right, false) == 0)
          linesChildrenRow = companyLinesChild;
      }
    }
    finally
    {
      IEnumerator<dsCompanyLines.ViewCompanyLinesChildrenRow> enumerator;
      enumerator?.Dispose();
    }
    try
    {
      foreach (UltraGridRow ultraGridRow3 in rowEnumerator)
      {
        if (ultraGridRow3.Cells["CompanyLineGuid"].Value.Equals((object) dr.CompanyLineGuid))
        {
          ArrayList arrayList = new ArrayList();
          try
          {
            foreach (DataColumn column in (InternalDataCollectionBase) this.dsLines.ViewCompanyLinesChildren.Columns)
            {
              arrayList.Add(RuntimeHelpers.GetObjectValue(ultraGridRow1.Cells[column.ColumnName].Value));
              ultraGridRow1.Cells[column.ColumnName].Value = RuntimeHelpers.GetObjectValue(linesChildrenRow[column]);
            }
          }
          finally
          {
            IEnumerator enumerator;
            if (enumerator is IDisposable)
              (enumerator as IDisposable).Dispose();
          }
          int num = arrayList.Count - 1;
          for (int index = 0; index <= num; ++index)
            linesChildrenRow[index] = RuntimeHelpers.GetObjectValue(arrayList[index]);
          ultraGridRow1.Selected = true;
          ((UltraGridBase) this.dgView).ActiveRow = ultraGridRow1;
          break;
        }
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private static Guid SwapDatatableChildRows(
    bool moveDown,
    dsCompanyLines.tblCompanyLinesRow dr,
    dsCompanyLines.tblCompanyLinesRow[] childRows,
    Guid rowToSwap)
  {
    dsCompanyLines.tblCompanyLinesRow[] tblCompanyLinesRowArray1 = childRows;
    int index1 = 0;
    while (index1 < tblCompanyLinesRowArray1.Length)
    {
      dsCompanyLines.tblCompanyLinesRow tblCompanyLinesRow = tblCompanyLinesRowArray1[index1];
      checked { ++index1; }
    }
    if (moveDown)
    {
      dsCompanyLines.tblCompanyLinesRow tblCompanyLinesRow1;
      int num1 = (tblCompanyLinesRow1 = dr).PackageOrder + 1;
      tblCompanyLinesRow1.PackageOrder = num1;
      dsCompanyLines.tblCompanyLinesRow[] tblCompanyLinesRowArray2 = childRows;
      int index2 = 0;
      while (index2 < tblCompanyLinesRowArray2.Length)
      {
        dsCompanyLines.tblCompanyLinesRow tblCompanyLinesRow2 = tblCompanyLinesRowArray2[index2];
        if (tblCompanyLinesRow2.PackageOrder == dr.PackageOrder && !tblCompanyLinesRow2.CompanyLineGuid.Equals(dr.CompanyLineGuid))
        {
          dsCompanyLines.tblCompanyLinesRow tblCompanyLinesRow3;
          int num2 = (tblCompanyLinesRow3 = tblCompanyLinesRow2).PackageOrder - 1;
          tblCompanyLinesRow3.PackageOrder = num2;
          rowToSwap = tblCompanyLinesRow2.CompanyLineGuid;
          break;
        }
        checked { ++index2; }
      }
    }
    else
    {
      dsCompanyLines.tblCompanyLinesRow tblCompanyLinesRow4;
      int num3 = (tblCompanyLinesRow4 = dr).PackageOrder - 1;
      tblCompanyLinesRow4.PackageOrder = num3;
      dsCompanyLines.tblCompanyLinesRow[] tblCompanyLinesRowArray3 = childRows;
      int index3 = 0;
      while (index3 < tblCompanyLinesRowArray3.Length)
      {
        dsCompanyLines.tblCompanyLinesRow tblCompanyLinesRow5 = tblCompanyLinesRowArray3[index3];
        if (tblCompanyLinesRow5.PackageOrder == dr.PackageOrder && !tblCompanyLinesRow5.CompanyLineGuid.Equals(dr.CompanyLineGuid))
        {
          dsCompanyLines.tblCompanyLinesRow tblCompanyLinesRow6;
          int num4 = (tblCompanyLinesRow6 = tblCompanyLinesRow5).PackageOrder + 1;
          tblCompanyLinesRow6.PackageOrder = num4;
          rowToSwap = tblCompanyLinesRow5.CompanyLineGuid;
          break;
        }
        checked { ++index3; }
      }
    }
    return rowToSwap;
  }

  private void ChangeChildLineOrder(bool moveDown)
  {
    dsCompanyLines.tblCompanyLinesRow tblCompanyLine = this.dsLines.tblCompanyLines[this._bmb.Position];
    if (tblCompanyLine.IsParentCompanyLineGuidNull())
      throw new InvalidOperationException("Should not call ChangeChildLineOrder for non-child lines");
    dsCompanyLines.tblCompanyLinesRow[] childRows = (dsCompanyLines.tblCompanyLinesRow[]) this.dsLines.tblCompanyLines.Select($"ParentCompanyLineGuid='{tblCompanyLine.ParentCompanyLineGuid.ToString()}'", "PackageOrder");
    if (!tblCompanyLine.IsPackageOrderNull())
    {
      if (childRows.Length > 1)
      {
        dsCompanyLines.tblCompanyLinesRow[] source = childRows;
        Func<dsCompanyLines.tblCompanyLinesRow, int, bool> predicate;
        // ISSUE: reference to a compiler-generated field
        if (frmCompanyLines._Closure\u0024__.\u0024I362\u002D0 != null)
        {
          // ISSUE: reference to a compiler-generated field
          predicate = frmCompanyLines._Closure\u0024__.\u0024I362\u002D0;
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          frmCompanyLines._Closure\u0024__.\u0024I362\u002D0 = predicate = (Func<dsCompanyLines.tblCompanyLinesRow, int, bool>) ([SpecialName] (x, i) => x.IsPackageOrderNull() || x.PackageOrder != i);
        }
        if (!((IEnumerable<dsCompanyLines.tblCompanyLinesRow>) source).Where<dsCompanyLines.tblCompanyLinesRow>(predicate).Any<dsCompanyLines.tblCompanyLinesRow>())
          goto label_19;
      }
      else
        goto label_19;
    }
    DataTable dataTable = DefaultDatabase.ExecuteDataTable("dbo.FixCompanyLinePackageOrder", new object[2]
    {
      (object) "@parentLine",
      (object) tblCompanyLine.ParentCompanyLineGuid
    });
    if (dataTable.Rows.Count != childRows.Length)
      throw new InvalidOperationException("Unable to fix PackageOrder for child lines. Number of fixed lines does not match current number of child lines.");
    try
    {
      foreach (DataRow row in dataTable.Rows)
      {
        dsCompanyLines.tblCompanyLinesRow byCompanyLineGuid = this.dsLines.tblCompanyLines.FindByCompanyLineGuid(row.Field<Guid>("CompanyLineGuid"));
        if (byCompanyLineGuid == null)
          throw new InvalidOperationException("Unable to fix PackageOrder for child lines. Unable to find fixed child line in data table.");
        byCompanyLineGuid.PackageOrder = row.Field<int>("FixedOrder");
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
label_19:
    int num1 = tblCompanyLine.PackageOrder + (moveDown ? 1 : -1);
    if (num1 < 0 || num1 >= childRows.Length)
      return;
    Guid guid = Guid.Empty;
    int num2 = childRows.Length - 1;
    for (int index = 0; index <= num2; ++index)
    {
      if (childRows[index].CompanyLineGuid.Equals(tblCompanyLine.CompanyLineGuid))
      {
        guid = frmCompanyLines.SwapDatatableChildRows(moveDown, tblCompanyLine, childRows, guid);
        break;
      }
    }
    this.SwapUltragridChildRows(tblCompanyLine, guid);
    dsCompanyLines.tblCompanyLinesRow byCompanyLineGuid1 = this.dsLines.tblCompanyLines.FindByCompanyLineGuid(guid);
    DefaultDatabase.ExecuteNonQuery("SetCompanyLinePackageOrder", new object[8]
    {
      (object) "@companyLine1",
      (object) tblCompanyLine.CompanyLineGuid,
      (object) "@packageOrder1",
      (object) tblCompanyLine.PackageOrder,
      (object) "@companyLine2",
      (object) byCompanyLineGuid1.CompanyLineGuid,
      (object) "@packageOrder2",
      (object) byCompanyLineGuid1.PackageOrder
    });
  }

  private void menumanager_ToolClick(object sender, ToolClickEventArgs e)
  {
    if (this._bmb.Position == -1)
    {
      int num1 = (int) MessageBox.Show("Please select a company-line setup from the grid below.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else if (this.dsLines.tblCompanyLines[this._bmb.Position].RowState == DataRowState.Added)
    {
      int num2 = (int) MessageBox.Show("Please save this setup before continuing.", "Save Required", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else
    {
      CompanyLine companyLine = new CompanyLine(this.dsLines.tblCompanyLines[this._bmb.Position].CompanyLineGuid);
      string key = ((ToolEventArgs) e).Tool.Key;
      // ISSUE: reference to a compiler-generated method
      switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(key))
      {
        case 81283355:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "FCW", false) == 0)
          {
            using (MGASystems.Common.FormSettings.ShowFormDialog(typeof (frmCompanyFormsConditionsWarranties), (object) companyLine.CompanyLineID))
              return;
          }
          break;
        case 324612653:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Assign Raters", false) == 0)
          {
            MGASystems.Common.FormSettings.ShowForm(typeof (frmCompanyRaters), (object) companyLine.CompanyLineGuid);
            return;
          }
          break;
        case 329388739:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Document Automation", false) == 0)
          {
            MGASystems.Common.FormSettings.ShowForm(typeof (frmDocumentAutomation), (object) companyLine.CompanyLineGuid);
            return;
          }
          break;
        case 393573397:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "New Contact", false) == 0)
          {
            MGASystems.Common.FormSettings.ShowForm(typeof (frmCompanyContacts), (object) companyLine.CompanyGuid, (object) companyLine.CompanyLocationGuid);
            return;
          }
          break;
        case 411903900:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Cancellation Requirements ...", false) == 0)
          {
            using (MGASystems.Common.FormSettings.ShowFormDialog(typeof (FormCancellationRequirements), (object) companyLine.CompanyLineID))
              return;
          }
          break;
        case 599355865:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Authorize Offices", false) == 0)
          {
            if (!SecurityManager.Instance.AssertPermission("{27F8D768-D1BD-4CA2-A6A9-0B0479BFE7CC}"))
            {
              int num3 = (int) MessageBox.Show("You do not have permission to access this form.", "Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
              return;
            }
            MGASystems.Common.FormSettings.ShowForm(typeof (frmAssignOfficesToLines), (object) companyLine.CompanyLineGuid);
            return;
          }
          break;
        case 655153442:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Installment Options", false) == 0)
          {
            if (!SecurityManager.Instance.AssertPermission("{E2E48817-AB10-480E-B4C3-788D4107602D}"))
            {
              int num4 = (int) MessageBox.Show("You do not have permission to access this form.", "Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
              return;
            }
            MGASystems.Common.FormSettings.ShowForm(typeof (frmCompanyInstallments), (object) companyLine.CompanyLineGuid);
            return;
          }
          break;
        case 1025234373:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Assign Fees", false) == 0)
          {
            MGASystems.Common.FormSettings.ShowForm(typeof (frmAdminCompanyPolicyFees), (object) companyLine.CompanyLineGuid);
            return;
          }
          break;
        case 1173969368:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Copy to New Setup ...", false) == 0)
          {
            using (MGASystems.Common.FormSettings.ShowFormDialog(typeof (FormCopyOverCompanyLineInfo), (object) companyLine.CompanyLineGuid))
              return;
          }
          break;
        case 1311704911:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Policy Classes", false) == 0)
          {
            frmCompanyLineClasses.ShowForm(companyLine);
            return;
          }
          break;
        case 1316709758:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Generic Quote Wording", false) == 0)
          {
            using (MGASystems.Common.FormSettings.ShowFormDialog(typeof (frmCompanyLineGenericWording), (object) companyLine.CompanyLineID))
              return;
          }
          break;
        case 1329618370:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "CompanyCommissions", false) == 0)
          {
            MGASystems.Common.FormSettings.ShowForm(typeof (frmCompanyLineCommissions), (object) companyLine.CompanyLineID);
            return;
          }
          break;
        case 1456586214:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Payment Terms", false) == 0)
          {
            MGASystems.Common.FormSettings.ShowForm(typeof (frmCompanyLineTermsOfPayment), (object) companyLine.CompanyLineID);
            return;
          }
          break;
        case 1582017048:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "View", false) == 0)
          {
            MGASystems.Common.FormSettings.ShowForm(typeof (frmCompanies), (object) companyLine.CompanyGuid);
            return;
          }
          break;
        case 1868002132:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "SIC Codes", false) == 0)
          {
            using (MGASystems.Common.FormSettings.ShowFormDialog(typeof (frmCompanySIC), (object) companyLine.CompanyLineGuid))
              return;
          }
          break;
        case 2011444160:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Policy Numbering", false) == 0)
          {
            using (MGASystems.Common.FormSettings.ShowFormDialog(typeof (frmCompanyLinePolicyNumbers), (object) companyLine.CompanyLineID))
              return;
          }
          break;
        case 2274627276:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Logging Information", false) == 0)
          {
            using (MGASystems.Common.FormSettings.ShowFormDialog(typeof (FormCompanyLineLoggingInfo), (object) companyLine.CompanyLineID))
              return;
          }
          break;
        case 2594157101:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Construction Types", false) == 0)
          {
            if (SecurityManager.Instance.AssertPermission("{76423BDA-8CC8-4a48-BB91-43C968F3B6C8}"))
            {
              using (MGASystems.Common.FormSettings.ShowFormDialog(typeof (frmCompanyConstructionTypes), (object) companyLine.CompanyLineID))
                return;
            }
            int num5 = (int) MessageBox.Show("You do not have permission to access this form.", "Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return;
          }
          break;
        case 2610321534:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Binding Requirements", false) == 0)
          {
            using (MGASystems.Common.FormSettings.ShowFormDialog(typeof (frmCompanyLineBindingRequirements), (object) companyLine.CompanyLineID))
              return;
          }
          break;
        case 2626777763:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Assign Cost Centers...", false) == 0)
          {
            MGASystems.Common.FormSettings.ShowForm(typeof (FormCompanyLineCostCenters), (object) companyLine.CompanyLineGuid);
            return;
          }
          break;
        case 2678761549:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Copy Rater Conditionals", false) == 0)
          {
            MGASystems.Common.FormSettings.ShowForm(typeof (FormCopyCompanyLineRaterConditionals), (object) companyLine.CompanyLineID);
            return;
          }
          break;
        case 2719036894:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Available Billing Types", false) == 0)
          {
            if (!SecurityManager.Instance.AssertPermission("{45331795-F7B4-4E5D-A835-A634CCB23C7E}"))
            {
              int num6 = (int) MessageBox.Show("You do not have permission to access this form.", "Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
              return;
            }
            MGASystems.Common.FormSettings.ShowForm(typeof (frmAdminAvailableBillingTypes), (object) companyLine.CompanyLineGuid);
            return;
          }
          break;
        case 2874912392:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Move Down", false) == 0)
          {
            this.ChangeChildLineOrder(true);
            return;
          }
          break;
        case 2952039034:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Copy...", false) == 0)
          {
            using (MGASystems.Common.FormSettings.ShowFormDialog(typeof (frmCopyCompanyLine), (object) companyLine.CompanyLineGuid))
              ;
            this.RefillView();
            return;
          }
          break;
        case 2999722212:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Copy Policy Numbers", false) == 0)
          {
            using (MGASystems.Common.FormSettings.ShowFormDialog(typeof (FormCopyPolicyNumbers), (object) companyLine.CompanyLineGuid))
              return;
          }
          break;
        case 3206497135:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Copy Cost Centers", false) == 0)
          {
            using (MGASystems.Common.FormSettings.ShowFormDialog(typeof (FormCopyCostCenters), (object) companyLine.CompanyLineGuid))
              return;
          }
          break;
        case 3299709363:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Global Rater Update", false) == 0)
          {
            using (MGASystems.Common.FormSettings.ShowFormDialog(typeof (FormGlobalRaterUpdate), (object) companyLine.CompanyLineID))
              return;
          }
          break;
        case 3441060342:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Conditional Policy Forms...", false) == 0)
          {
            MGASystems.Common.FormSettings.ShowForm(ObjectFactory.Instance.CreateTypeFromString("MGASystems.IMS.Policies.Rating.FormAdminRaterForms"), (object) this.dsLines.tblCompanyLines[this._bmb.Position].CompanyLineGuid);
            return;
          }
          break;
        case 3867627553:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Move Up", false) == 0)
          {
            this.ChangeChildLineOrder(false);
            return;
          }
          break;
        case 4166200250:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "New Company", false) == 0)
          {
            MGASystems.Common.FormSettings.ShowForm(typeof (frmCompanies));
            return;
          }
          break;
      }
      this.ClientMenuToolClick(((ToolEventArgs) e).Tool.Key, companyLine);
    }
  }

  public virtual void ClientMenuToolClick(string key, CompanyLine companyLine)
  {
  }

  private bool NoItemSelected(MGASimpleComboBox cbo)
  {
    return ((Control) cbo).Enabled && (((UltraDropDownBase) cbo).SelectedRow == null || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((UltraDropDownBase) cbo).SelectedRow.Cells[((UltraDropDownBase) cbo).DisplayMember].Value.ToString(), string.Empty, false) == 0);
  }

  private bool ValidForm()
  {
    bool flag1 = true;
    this.err.SetError((Control) this.txtMailingDays, string.Empty);
    this.err.SetError((Control) this.txtNOCDays, string.Empty);
    this.err.SetError((Control) this.cboStatus, string.Empty);
    this.err.SetError((Control) this.cboCompanyLicensed, string.Empty);
    this.err.SetError((Control) this.cbLicenseType, string.Empty);
    this.err.SetError((Control) this.cbCompanies, string.Empty);
    this.err.SetError((Control) this.cbStates, string.Empty);
    this.err.SetError((Control) this.cbLines, string.Empty);
    this.err.SetError((Control) this.cboStatus, string.Empty);
    this.err.SetError((Control) this.txtBackdateDays, string.Empty);
    this.err.SetError((Control) this.txtNOCGracePeriod, string.Empty);
    if (this.NoItemSelected(this.cboStatus) || this.dsLines.tblCompanyLines[this._bmb.Position].IsStatusIDNull())
    {
      this.err.SetError((Control) this.cboStatus, "Please select a status.");
      flag1 = false;
    }
    if (this.NoItemSelected(this.cboCompanyLicensed))
    {
      this.err.SetError((Control) this.cboCompanyLicensed, "Please select a valid license type.");
      flag1 = false;
    }
    if (this.NoItemSelected(this.cbLicenseType))
    {
      this.err.SetError((Control) this.cbLicenseType, "Please select a valid license type.");
      flag1 = false;
    }
    if (this.NoItemSelected(this.cbCompanies))
    {
      this.err.SetError((Control) this.cbCompanies, "Please select a company.");
      flag1 = false;
    }
    if (this.NoItemSelected(this.cbStates))
    {
      this.err.SetError((Control) this.cbStates, "Please select a state.");
      flag1 = false;
    }
    if (this.NoItemSelected(this.cbLines))
    {
      this.err.SetError((Control) this.cbLines, "Please select a line of business.");
      flag1 = false;
    }
    if (this.NoItemSelected(this.cboStatus))
    {
      this.err.SetError((Control) this.cboStatus, "Please select a status.");
      flag1 = false;
    }
    if (this.txtBackdateDays.Value.Equals((object) 0))
    {
      this.err.SetError((Control) this.txtBackdateDays, "0 is not a valid option. Please select a value between 1 and 999.");
      flag1 = false;
    }
    bool flag2;
    if (!flag1)
    {
      ((UltraTabControlBase) this.ultraTab).SelectedTab = ((UltraTabControlBase) this.ultraTab).Tabs["tabCompanyLine"];
      flag2 = false;
    }
    else
    {
      if (((UltraToggleEditorBase) this.chkAutoNOC).Checked)
      {
        if (!Versioned.IsNumeric((object) ((TextEditorControlBase) this.txtMailingDays).Text))
        {
          this.err.SetError((Control) this.txtMailingDays, "Please enter the number of days.");
          flag1 = false;
        }
        else
          this.err.SetError((Control) this.txtMailingDays, string.Empty);
        if (!Versioned.IsNumeric((object) ((TextEditorControlBase) this.txtNOCDays).Text))
        {
          this.err.SetError((Control) this.txtNOCDays, "Please enter the number of days for NOC.");
          flag1 = false;
        }
        else if (Conversions.ToInteger(((TextEditorControlBase) this.txtNOCDays).Text) > this._settingNOCDays)
        {
          this.err.SetError((Control) this.txtNOCDays, this._settingNOCDays.ToString() + " days is the maximum number of days for NOC.");
          flag1 = false;
        }
        else
          this.err.SetError((Control) this.txtNOCDays, string.Empty);
      }
      if (((UltraToggleEditorBase) this.chkEmailReminder).Checked && !Versioned.IsNumeric((object) ((TextEditorControlBase) this.txtEmailReminderDays).Text))
      {
        this.err.SetError((Control) this.txtEmailReminderDays, "Please enter the number of days.");
        flag1 = false;
      }
      else
        this.err.SetError((Control) this.txtEmailReminderDays, string.Empty);
      if (flag1 && ((UltraToggleEditorBase) this.chkEmailReminder).Checked && Versioned.IsNumeric((object) ((TextEditorControlBase) this.txtEmailReminderDays).Text) && Conversions.ToInteger(((TextEditorControlBase) this.txtEmailReminderDays).Text) < 0)
      {
        this.err.SetError((Control) this.txtEmailReminderDays, "Please enter a positive number.");
        flag1 = false;
      }
      else if (flag1)
        this.err.SetError((Control) this.txtEmailReminderDays, string.Empty);
      if (flag1 && Versioned.IsNumeric((object) ((TextEditorControlBase) this.txtMailingDays).Text) && Conversions.ToInteger(((TextEditorControlBase) this.txtMailingDays).Text) < 0)
      {
        this.err.SetError((Control) this.txtMailingDays, "Please enter a positive number.");
        flag1 = false;
      }
      else if (flag1)
        this.err.SetError((Control) this.txtMailingDays, string.Empty);
      if (flag1 && Versioned.IsNumeric((object) ((TextEditorControlBase) this.txtNOCDays).Text) && Conversions.ToInteger(((TextEditorControlBase) this.txtNOCDays).Text) < 0)
      {
        this.err.SetError((Control) this.txtNOCDays, "Please enter a positive number.");
        flag1 = false;
      }
      else if (flag1)
        this.err.SetError((Control) this.txtNOCDays, string.Empty);
      if (!flag1)
      {
        ((UltraTabControlBase) this.ultraTab).SelectedTab = ((UltraTabControlBase) this.ultraTab).Tabs["tabInvoices"];
        flag2 = false;
      }
      else
      {
        DataRow dataRow = DefaultDatabase.ExecuteDataRow(CommandType.Text, "SELECT * FROM dbo.tblCompanyLines WHERE CompanyLocationGuid = @CLG AND StateID = @StateID AND LineGuid = @LG AND ParentCompanyLineGuid = @PCLG", new object[8]
        {
          (object) "CLG",
          this.cbCompanies.Value,
          (object) "@StateID",
          this.cbStates.Value,
          (object) "@LG",
          this.cbLines.Value,
          (object) "PCLG",
          this.cboParent.Value
        });
        bool flag3 = dataRow != null && !dataRow.IsNull("CompanyLineGuid");
        if (this.dsLines.tblCompanyLines[this._bmb.Position].RowState == DataRowState.Added && flag3)
        {
          int num = (int) MessageBox.Show("You can not add this company setup.  It already exists.", "Company Setup Exists", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          flag1 = false;
        }
        else
        {
          if (this.dsLines.tblCompanyLines[this._bmb.Position].RowState == DataRowState.Modified && flag3)
          {
            if (!this.dsLines.tblCompanyLines.Select($"CompanyLocationGuid='{this.cbCompanies.Value.ToString()}' AND StateID='{this.cbStates.Value.ToString()}' AND LineGuid='{this.cbLines.Value.ToString()}'")[0]["CompanyLineGuid"].Equals((object) this.dsLines.tblCompanyLines[this._bmb.Position].CompanyLineGuid))
            {
              int num = (int) MessageBox.Show("You can not save this company setup.  It already exists.", "Company Setup Exists", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
              flag1 = false;
              goto label_51;
            }
          }
          if (this.dsLines.tblCompanyLines[this._bmb.Position].RowState == DataRowState.Added && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cboParent.Text, string.Empty, false) != 0 && MessageBox.Show("You have a selected a parent company for this setup. This should only be used for package/umbrella policies.\n\nAre you sure you want to save this setup?", "Save With Parent?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
            flag1 = false;
        }
label_51:
        if (!flag1)
        {
          ((UltraTabControlBase) this.ultraTab).SelectedTab = ((UltraTabControlBase) this.ultraTab).Tabs[0];
          flag2 = false;
        }
        else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((TextEditorControlBase) this.txtMailingDays).Text, string.Empty, false) != 0 && Versioned.IsNumeric((object) ((TextEditorControlBase) this.txtMailingDays).Text) && Decimal.Compare(Conversions.ToDecimal(((TextEditorControlBase) this.txtMailingDays).Text), 255M) > 0)
        {
          this.err.SetError((Control) this.txtMailingDays, "Value must be between (0-255)");
          flag2 = false;
        }
        else
        {
          this.err.SetError((Control) this.txtMailingDays, string.Empty);
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((TextEditorControlBase) this.txtNOCDays).Text, string.Empty, false) != 0 && Versioned.IsNumeric((object) ((TextEditorControlBase) this.txtNOCDays).Text) && Decimal.Compare(Conversions.ToDecimal(((TextEditorControlBase) this.txtNOCDays).Text), 255M) > 0)
          {
            this.err.SetError((Control) this.txtNOCDays, "Value must be between (0-255)");
            flag2 = false;
          }
          else
          {
            this.err.SetError((Control) this.txtNOCDays, string.Empty);
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((TextEditorControlBase) this.txtEmailReminderDays).Text, string.Empty, false) != 0 && Versioned.IsNumeric((object) ((TextEditorControlBase) this.txtEmailReminderDays).Text) && Decimal.Compare(Conversions.ToDecimal(((TextEditorControlBase) this.txtEmailReminderDays).Text), 255M) > 0)
            {
              this.err.SetError((Control) this.txtEmailReminderDays, "Value must be between (0-255)");
              flag2 = false;
            }
            else
            {
              this.err.SetError((Control) this.txtEmailReminderDays, string.Empty);
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((UltraWinEditorMaskedControlBase) this.txtInvoiceDays).Text, string.Empty, false) != 0 && Versioned.IsNumeric((object) ((UltraWinEditorMaskedControlBase) this.txtInvoiceDays).Text) && Decimal.Compare(Conversions.ToDecimal(((UltraWinEditorMaskedControlBase) this.txtInvoiceDays).Text), 255M) > 0)
              {
                this.err.SetError((Control) this.txtInvoiceDays, "Value must be between (0-255)");
                flag2 = false;
              }
              else
              {
                this.err.SetError((Control) this.txtInvoiceDays, string.Empty);
                if (this._canViewNOCGracePeriod && !string.IsNullOrEmpty(((TextEditorControlBase) this.txtNOCGracePeriod).Text) && !Versioned.IsNumeric((object) ((TextEditorControlBase) this.txtNOCGracePeriod).Text))
                {
                  this.err.SetError((Control) this.txtNOCGracePeriod, "Please enter grace period value between (0-255).");
                  flag2 = false;
                }
                else
                  flag2 = this.ValidateOnClient();
              }
            }
          }
        }
      }
    }
    return flag2;
  }

  private void dbSave_ClickingSave(object sender, CancelEventArgs e)
  {
    if (!this.ValidForm())
    {
      e.Cancel = true;
    }
    else
    {
      this._bmb.EndCurrentEdit();
      dsCompanyLines.tblCompanyLinesRow tblCompanyLine1 = this.dsLines.tblCompanyLines[this._bmb.Position];
      bool flag = tblCompanyLine1.RowState == DataRowState.Added;
      Guid companyLineGuid = tblCompanyLine1.CompanyLineGuid;
      Guid parentCompanyLineGuid = Guid.Empty;
      if (!tblCompanyLine1.IsParentCompanyLineGuidNull())
        parentCompanyLineGuid = tblCompanyLine1.ParentCompanyLineGuid;
      Cursor.Current = MgaCursors.WaitCursor;
      object objectValue = RuntimeHelpers.GetObjectValue(Utility.IsNull((object) ((TextEditorControlBase) this.txtNOCGracePeriod).Text) || string.IsNullOrEmpty(((TextEditorControlBase) this.txtNOCGracePeriod).Text) ? (object) DBNull.Value : (object) ((TextEditorControlBase) this.txtNOCGracePeriod).Text);
      if (this.cboCompanySignature.Text.Length == 0)
        tblCompanyLine1.SetUserSignatureGuidNull();
      this.SetFilingValue(tblCompanyLine1);
      try
      {
        foreach (dsCompanyLines.tblCompanyLinesRow tblCompanyLine2 in (TypedTableBase<dsCompanyLines.tblCompanyLinesRow>) this.dsLines.tblCompanyLines)
        {
          if (!tblCompanyLine2.IsParentCompanyLineGuidNull() && tblCompanyLine2.ParentCompanyLineGuid.Equals(tblCompanyLine2.CompanyLineGuid))
            tblCompanyLine2.SetParentCompanyLineGuidNull();
        }
      }
      finally
      {
        IEnumerator<dsCompanyLines.tblCompanyLinesRow> enumerator;
        enumerator?.Dispose();
      }
      try
      {
        Dictionary<string, DbParameter> dictionary = new Dictionary<string, DbParameter>((IDictionary<string, DbParameter>) DefaultDatabase.DiscoverParameters("dbo.SaveCompanyLine"), (IEqualityComparer<string>) StringComparer.InvariantCultureIgnoreCase);
        try
        {
          foreach (DataColumn column in (InternalDataCollectionBase) this.dsLines.tblCompanyLines.Columns)
          {
            DbParameter dbParameter = (DbParameter) null;
            if (dictionary.TryGetValue($"@{column.ColumnName}", out dbParameter))
              dbParameter.Value = RuntimeHelpers.GetObjectValue(tblCompanyLine1[column.ColumnName]);
          }
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
        dictionary["@DefaultFinanceGUID"].Value = RuntimeHelpers.GetObjectValue(this.cboDefaultFinanceCo.Value);
        dictionary["@Filing"].Value = RuntimeHelpers.GetObjectValue(this.GetFilingValue());
        dictionary["@NOCGracePeriod"].Value = RuntimeHelpers.GetObjectValue(objectValue);
        DefaultDatabase.ExecuteNonQuery(CommandType.StoredProcedure, "dbo.SaveCompanyLine", (CommandArgumentType) 2, new object[1]
        {
          (object) dictionary
        });
      }
      catch (Exception ex1)
      {
        ProjectData.SetProjectError(ex1);
        Exception ex2 = ex1;
        if (ex2.Message.Contains("IX_tblCompanyLines"))
        {
          int num = (int) MessageBox.Show("This company/line configuration already exists.", "Setup Exists", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        else
          ErrorHandler.HandleError(ex2);
        e.Cancel = true;
        ProjectData.ClearProjectError();
        return;
      }
      finally
      {
        Cursor.Current = MgaCursors.Default;
      }
      MDIControls.Instance.StatusBarText = "Company line setup succesfully saved.";
      API.LockWindowUpdate(this.Handle);
      this.dsLines.Parents.Clear();
      if (flag)
        CurrentUser.Instance.LogAction($"Created Company/Line/State: {this.cbCompanies.Text}/{this.cbLines.Text}/{this.cbStates.Text} ", tblCompanyLine1.CompanyLineGuid, "Company/Line");
      if (!flag)
      {
        dsCompanyLines.ViewCompanyLinesRow byCompanyLineGuid = this.dsLines.ViewCompanyLines.FindByCompanyLineGuid(tblCompanyLine1.CompanyLineGuid);
        if (byCompanyLineGuid != null)
        {
          dsCompanyLines.ViewCompanyLinesChildrenRow[] linesChildrenRows = byCompanyLineGuid.GetViewCompanyLinesChildrenRows();
          int index = 0;
          while (index < linesChildrenRows.Length)
          {
            this.dsLines.ViewCompanyLinesChildren.Rows.Remove((DataRow) linesChildrenRows[index]);
            checked { ++index; }
          }
          this.dsLines.ViewCompanyLines.RemoveViewCompanyLinesRow(byCompanyLineGuid);
        }
      }
      this.SaveClientData(tblCompanyLine1.CompanyLineGuid);
      if (!parentCompanyLineGuid.Equals(Guid.Empty))
        this.DuplicateChildPolicyNumbersCheck(companyLineGuid, parentCompanyLineGuid);
      if (!flag && Database.DataHasChanged((DataRow) this.dsLines.tblCompanyLines[this._bmb.Position]))
      {
        string str1 = string.Empty;
        string str2 = $"{this.cbCompanies.Text} - {this.cbLines.Text} - {this.cbStates.Text}";
        try
        {
          foreach (KeyValuePair<string, string> dataColumn in this.GetDataColumns())
          {
            if (Database.DataHasChanged((DataRow) tblCompanyLine1, tblCompanyLine1.Table.Columns[dataColumn.Key]))
            {
              str1 = (str1 != null ? str1 + ", " : string.Empty) + dataColumn.Key;
              string str3 = "<NULL>";
              string str4 = "<NULL>";
              if (tblCompanyLine1[dataColumn.Key, DataRowVersion.Original] != DBNull.Value)
                str3 = tblCompanyLine1[dataColumn.Key, DataRowVersion.Original].ToString();
              if (tblCompanyLine1[dataColumn.Key] != DBNull.Value)
                str4 = tblCompanyLine1[dataColumn.Key].ToString();
              if (!str3.Equals(str4))
                CurrentUser.Instance.LogAction($"Modified Company/Line: {str2}. Changed '{dataColumn.Key}' from {str3} to {str4}", tblCompanyLine1.CompanyLineGuid);
            }
          }
        }
        finally
        {
          Dictionary<string, string>.Enumerator enumerator;
          enumerator.Dispose();
        }
        if (DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "SELECT COUNT(*) FROM tblCompanyLines WITH (NOLOCK) WHERE CompanyLocationGuid=@CL and LineGuid =@LG", new object[4]
        {
          (object) "@CL",
          (object) tblCompanyLine1.CompanyLocationGuid,
          (object) "@LG",
          (object) tblCompanyLine1.LineGuid
        }) > 1)
        {
          string str5 = "Clicking the save button will update all other states with this company/line \nconfiguration to the specificied new values";
          string str6 = $" WHERE CompanyLocationGuid = '{tblCompanyLine1.CompanyLocationGuid.ToString()}' AND LineGUID = '{tblCompanyLine1.LineGuid.ToString()}'";
          using (Form form = MGASystems.Common.FormSettings.ShowFormDialog(typeof (FormDataUpdate), (object) tblCompanyLine1, (object) this.GetDataColumns(), null, (object) str6, (object) str5))
          {
            if (form.DialogResult == DialogResult.OK)
            {
              string action = $"Modified Company Line: [Bulk updated] - {((FormDataUpdate) form).UpdatedFields}";
              DataRow[] dataRowArray = this.dsLines.tblCompanyLines.Select(str6.Substring(" WHERE ".Length) + $" AND CompanyLineGuid <> '{tblCompanyLine1.CompanyLineGuid}'");
              int index = 0;
              while (index < dataRowArray.Length)
              {
                dsCompanyLines.tblCompanyLinesRow tblCompanyLinesRow = (dsCompanyLines.tblCompanyLinesRow) dataRowArray[index];
                CurrentUser.Instance.LogAction(action, tblCompanyLinesRow.CompanyLineGuid, "Company/Line");
                checked { ++index; }
              }
            }
          }
        }
      }
      if (!flag)
        this.UpdateClientOnDataChanged(tblCompanyLine1.CompanyLineGuid);
      this.RefillView();
      API.LockWindowUpdate(new IntPtr());
    }
  }

  private void dbSave_ClickingNew(object sender, CancelEventArgs e)
  {
    if (!this._UpdateFormData)
    {
      int num = (int) MessageBox.Show("You do not have the required security.", "Security Required", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      e.Cancel = true;
    }
    else
    {
      if (((UltraGridBase) this.dgView).ActiveRow != null)
        ((UltraGridBase) this.dgView).ActiveRow.Selected = false;
      dsCompanyLines.tblCompanyLinesRow tblCompanyLinesRow = this.dsLines.tblCompanyLines.NewtblCompanyLinesRow();
      tblCompanyLinesRow.CompanyLineGuid = Guid.NewGuid();
      tblCompanyLinesRow.Added = DateAndTime.Now;
      tblCompanyLinesRow.SetFilingNull();
      if (SystemSettings.KeyExists("AllowEndorsementsWithoutIssuance"))
      {
        object boolSetting = (object) SystemSettings.GetBoolSetting("AllowEndorsementsWithoutIssuance");
        tblCompanyLinesRow.AllowEndorsementsWithoutIssuance = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(boolSetting));
      }
      this.ClientWorkOnClickingNew(tblCompanyLinesRow);
      this.dsLines.tblCompanyLines.AddtblCompanyLinesRow(tblCompanyLinesRow);
      this._bmb.Position = this.dsLines.tblCompanyLines.Rows.Count - 1;
      this.ClearCombosAndRadioButtons();
    }
  }

  private void dbSave_ClickingCancel(object sender, CancelEventArgs e)
  {
    if (this.dsLines.tblCompanyLines[this._bmb.Position].RowState == DataRowState.Added)
      this.dsLines.tblCompanyLines.RemovetblCompanyLinesRow(this.dsLines.tblCompanyLines[this._bmb.Position]);
    else
      this._bmb.CancelCurrentEdit();
    this.ClearErrorProviders();
    this.ClientWorkOnClickingCancel();
  }

  private void ClearErrorProviders()
  {
    foreach (UltraTab tab in ((UltraTabControlBase) this.ultraTab).Tabs)
    {
      try
      {
        foreach (Control control in ((Control) tab.TabPage).Controls)
          this.err.SetError(control, string.Empty);
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
  }

  private void DeleteRow()
  {
    if (MessageBox.Show("Are you sure you want to delete this company line setup?", "Delete Action?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
      return;
    this.Refresh();
    if (this._bmb.Position == -1)
    {
      this.dbSave.UIState = UIState.NoRecordsNotEditing;
    }
    else
    {
      bool flag = false;
      string stateID = string.Empty;
      Guid companyLocationGuid = Guid.Empty;
      bool isParentLine = false;
      Guid lineGuid = Guid.Empty;
      string str = string.Empty;
      if (!this.dsLines.tblCompanyLines[this._bmb.Position].IsCompanyLocationGuidNull())
        str = $"{str}{this.dsLines.tblCompanyLocations.FindByCompanyLocationGuid(this.dsLines.tblCompanyLines[this._bmb.Position].CompanyLocationGuid).Name}/";
      if (!this.dsLines.tblCompanyLines[this._bmb.Position].IsLineGuidNull())
        str = $"{str}{this.dsLines.lstLines.FindByLineGuid(this.dsLines.tblCompanyLines[this._bmb.Position].LineGuid).LineName}/";
      if (!this.dsLines.tblCompanyLines[this._bmb.Position].IsStateIDNull())
        str += this.dsLines.tblCompanyLines[this._bmb.Position].StateID;
      try
      {
        Guid companyLineGuid = this.dsLines.tblCompanyLines[this._bmb.Position].CompanyLineGuid;
        CompanyLine companyLine = new CompanyLine(companyLineGuid);
        stateID = companyLine.StateID;
        companyLocationGuid = companyLine.CompanyLocationGuid;
        isParentLine = companyLine.IsParentLine;
        lineGuid = companyLine.LineGuid;
        DefaultDatabase.ExecuteNonQuery("spDeleteCompanyLines", new object[2]
        {
          (object) "@CompanyLineGuid",
          (object) companyLineGuid
        });
        this.dsLines.tblCompanyLines.RemovetblCompanyLinesRow(this.dsLines.tblCompanyLines.FindByCompanyLineGuid(companyLineGuid));
        if (this.dsLines.ViewCompanyLines.FindByCompanyLineGuid(companyLineGuid) != null)
          this.dsLines.ViewCompanyLines.RemoveViewCompanyLinesRow(this.dsLines.ViewCompanyLines.FindByCompanyLineGuid(companyLineGuid));
        else
          this.dsLines.ViewCompanyLinesChildren.RemoveViewCompanyLinesChildrenRow(this.dsLines.ViewCompanyLinesChildren.FindByCompanyLineGuid(companyLineGuid));
        flag = true;
      }
      catch (Exception ex1)
      {
        ProjectData.SetProjectError(ex1);
        Exception ex2 = ex1;
        if (ex2.Message.Contains("FK_tblQuoteOptionCharges_tblCompanyLines"))
        {
          int num1 = (int) MessageBox.Show("This company/line can not be deleted, because it has policy fees associated with it.", "Unable To Delete Company/Line", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        else if (ex2.Message.Contains("FK_tblQuoteDetails_tblCompanyLines"))
        {
          int num2 = (int) MessageBox.Show("This company/line can not be deleted, because it has been applied to policies.", "Unable To Delete Company/Line", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        else if (ex2.Message.Contains("FK_tblFin_InvoiceCompanies_tblCompanyLines") || ex2.Message.Contains("FK_tblFin_InvoiceDetails_tblCompanyLines"))
        {
          int num3 = (int) MessageBox.Show("This company/line can not be deleted, because it has been applied to invoices.", "Unable To Delete Company/Line", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        else if (ex2.Message.Contains("FK_tblCompanyLines_tblCompanyLines"))
        {
          int num4 = (int) MessageBox.Show("This company/line can not be deleted, because it has child lines beneath it.\n\nPlease delete any child records first before removing the primary line.", "Unable To Delete Company/Line", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        else if (ex2.Message.Contains("FK_tblCompanyLineBindingRequirements_tblCompanyLines"))
        {
          int num5 = (int) MessageBox.Show("This company/Line is also applied to Company/Line Binding Requirements.", "Unable To Delete Company/Line", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        else if (ex2.Message.Contains("FK_tblFin_InvoicedItemsPayees_tblCompanyLines"))
        {
          int num6 = (int) MessageBox.Show("This company/line setup can not be deleted because it is associated with invoices.", "Unable To Delete Company/Line", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        else if (ex2.Message.Contains("FK_tblQuoteOptions_tblCompanyLineInstallments"))
        {
          int num7 = (int) MessageBox.Show("This company installment setup can not be deleted,\n because it is currently in use on one or more policies.", "Unable to Delete Company/Line", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        else if (ex2.Message.Contains("Company line can not be deleted"))
        {
          int num8 = (int) MessageBox.Show(ex2.Message, "Unable To Delete Company/Line", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        else
          ErrorHandler.HandleError(ex2);
        ProjectData.ClearProjectError();
      }
      if (!flag)
        return;
      CurrentUser.Instance.LogAction("Deleted Company/Line/State:" + str);
      this.DeleteOtherCompanyLines(companyLocationGuid, stateID, lineGuid, isParentLine);
    }
  }

  private void dbSave_ClickingDelete(object sender, CancelEventArgs e)
  {
    if (!this._UpdateFormData)
    {
      int num = (int) MessageBox.Show("You do not have the required security.", "Security Required", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      e.Cancel = true;
    }
    else
      this.DeleteRow();
  }

  private void dbSave_ClickingEdit(object sender, CancelEventArgs e)
  {
    if (this.dgView.Selected.Rows.Count == 0)
    {
      e.Cancel = true;
      int num = (int) MessageBox.Show("Please select a row in the grid to edit.", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else
      ((Control) this.cbCompanies).Select();
  }

  private void menumanager_BeforeToolDropdown(object sender, BeforeToolDropdownEventArgs e)
  {
    foreach (ToolBase tool in (ToolsCollectionBase) ((PopupMenuTool) ((CancelableToolEventArgs) e).Tool).Tools)
      tool.SharedProps.Enabled = this.dsLines.tblCompanyLines.Count > 0 && this.dsLines.tblCompanyLines[this._bmb.Position].RowState != DataRowState.Added;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((CancelableToolEventArgs) e).Tool.Key, "fclCompany/Line", false) != 0 || this.dgView == null || ((UltraGridBase) this.dgView).ActiveRow == null)
      return;
    ((ToolsCollectionBase) ((ToolsCollectionBase) ((PopupMenuTool) ((CancelableToolEventArgs) e).Tool).Tools).ToolbarsManager.Tools)["Line Ordering"].SharedProps.Visible = ((UltraGridBase) this.dgView).ActiveRow.Band.Index == 1;
    this.menumanager.RefreshMerge();
  }

  private void DeleteOtherCompanyLines(
    Guid companyLocationGuid,
    string stateID,
    Guid lineGuid,
    bool isParentLine)
  {
    if (DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "SELECT COUNT(1)  FROM tblCompanyLines WITH (NOLOCK)  WHERE CompanyLocationGuid = @CL AND LineGuid = @LG AND StateID <> @ST  AND CompanyLineGuid NOT IN (SELECT CompanyLineGuid FROM tblQuoteDetails WITH (NOLOCK))", new object[6]
    {
      (object) "@CL",
      (object) companyLocationGuid,
      (object) "@LG",
      (object) lineGuid,
      (object) "@ST",
      (object) stateID
    }) == 0)
      return;
    FormDeleteBulkCompanyLine deleteBulkCompanyLine = (FormDeleteBulkCompanyLine) ObjectFactory.Instance.CreateObject(typeof (FormDeleteBulkCompanyLine), new object[4]
    {
      (object) companyLocationGuid,
      (object) lineGuid,
      (object) stateID,
      (object) isParentLine
    });
    int num = (int) deleteBulkCompanyLine.ShowDialog();
    if (deleteBulkCompanyLine == null)
      return;
    if (deleteBulkCompanyLine.DeletedCompanyLineRows)
      this.FilterGrid();
    deleteBulkCompanyLine.Dispose();
  }

  private void GetMinMaxInfoHelper(ref Message m)
  {
    frmCompanyLines.MINMAXINFO lparam = (frmCompanyLines.MINMAXINFO) m.GetLParam(typeof (frmCompanyLines.MINMAXINFO));
    Size size;
    if (!this.MinimumSize.IsEmpty)
    {
      ref frmCompanyLines.POINTAPI local1 = ref lparam.ptMinTrackSize;
      size = this.MinimumSize;
      int width = size.Width;
      local1.x = width;
      ref frmCompanyLines.POINTAPI local2 = ref lparam.ptMinTrackSize;
      size = this.MinimumSize;
      int height = size.Height;
      local2.y = height;
    }
    size = this.MaximumSize;
    if (!size.IsEmpty)
    {
      ref frmCompanyLines.POINTAPI local3 = ref lparam.ptMaxTrackSize;
      size = this.MaximumSize;
      int width = size.Width;
      local3.x = width;
      ref frmCompanyLines.POINTAPI local4 = ref lparam.ptMaxTrackSize;
      size = this.MaximumSize;
      int height = size.Height;
      local4.y = height;
    }
    Marshal.StructureToPtr<frmCompanyLines.MINMAXINFO>(lparam, m.LParam, true);
    m.Result = IntPtr.Zero;
  }

  protected override void WndProc(ref Message m)
  {
    if (m.Msg == 36)
      this.GetMinMaxInfoHelper(ref m);
    else
      base.WndProc(ref m);
  }

  public UltraToolbarsManager ExposedMenuManager => this.menumanager;

  public object RetrieveResponse(string query, object supportingInfo)
  {
    object obj;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(query, "CompanyLineGuid", false) == 0)
    {
      try
      {
        obj = (object) this.dsLines.tblCompanyLines[this._bmb.Position].CompanyLineGuid;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        obj = (object) null;
        ProjectData.ClearProjectError();
      }
    }
    else
      obj = (object) null;
    return obj;
  }

  private void lnkSignatures_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    frmSignatures frmSignatures = new frmSignatures(this.dsLines.tblCompanyLines[this._bmb.Position].CompanyLineGuid);
    frmSignatures.MdiParent = MDIControls.Instance.MDIParent;
    frmSignatures.Show();
  }

  protected virtual void UpdateAfterBindingChanged(Guid companyLineGuid)
  {
  }

  protected virtual void SaveClientData(Guid companyLineGuid)
  {
  }

  protected virtual void ClientWorkOnClickingNew(dsCompanyLines.tblCompanyLinesRow dr)
  {
  }

  protected virtual void UpdateClientOnDataChanged(Guid currentCompanyLineGuid)
  {
  }

  protected virtual void OnLineChange(object LineComboBoxValue)
  {
  }

  protected virtual void OnCompanyLicenseChange(object LineComboBoxValue)
  {
  }

  protected virtual void ClientWorkOnClickingCancel()
  {
  }

  protected virtual bool ValidateOnClient() => true;

  protected virtual void OnStatehange(object StateComboBoxValue)
  {
  }

  private void cbLines_BeforeDropDown(object sender, CancelEventArgs e)
  {
    foreach (UltraGridRow row in ((UltraGridBase) this.cbLines).Rows)
    {
      dsCompanyLines.lstLinesRow byLineGuid = this.dsLines.lstLines.FindByLineGuid((Guid) row.Cells["LineGuid"].Value);
      row.Hidden = byLineGuid.Inactive;
    }
  }

  private bool IsProperSelection()
  {
    bool flag;
    if (this._bmb.Position == -1)
    {
      int num = (int) MessageBox.Show("Please select a company / line.", "No Company / Line Selection", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      flag = false;
    }
    else if (this.dsLines.tblCompanyLines[this._bmb.Position].RowState == DataRowState.Added)
    {
      int num = (int) MessageBox.Show("Please save this setup before continuing.", "Save Required", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      flag = false;
    }
    else
      flag = true;
    return flag;
  }

  private void lnkDocAuto_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    if (!this.IsProperSelection())
      return;
    MGASystems.Common.FormSettings.ShowForm(typeof (frmDocumentAutomation), (object) this.dsLines.tblCompanyLines[this._bmb.Position].CompanyLineGuid);
  }

  private void lnkFCW_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    if (!this.IsProperSelection())
      return;
    using (MGASystems.Common.FormSettings.ShowFormDialog(typeof (frmCompanyFormsConditionsWarranties), (object) new CompanyLine(this.dsLines.tblCompanyLines[this._bmb.Position].CompanyLineGuid).CompanyLineID))
      ;
  }

  private void lnkCPF_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    if (!this.IsProperSelection())
      return;
    MGASystems.Common.FormSettings.ShowForm(ObjectFactory.Instance.CreateTypeFromString("MGASystems.IMS.Policies.Rating.FormAdminRaterForms"), (object) this.dsLines.tblCompanyLines[this._bmb.Position].CompanyLineGuid);
  }

  private void chkHideInactive_CheckedChanged(object sender, EventArgs e)
  {
    UltraGridBand band1 = this.cbCompanyFilter.DisplayLayout.Bands[0];
    UltraGridBand band2 = this.cbCompanies.DisplayLayout.Bands[0];
    UltraGridBand band3 = this.cbLineFilter.DisplayLayout.Bands[0];
    UltraGridBand band4 = this.cbLines.DisplayLayout.Bands[0];
    if (((UltraToggleEditorBase) this.chkHideInactive).Checked)
    {
      band1.ColumnFilters["StatusID"].FilterConditions.Clear();
      band1.ColumnFilters["StatusID"].FilterConditions.Add((FilterComparisionOperator) 0, (object) 1);
      band2.ColumnFilters["StatusID"].FilterConditions.Clear();
      band2.ColumnFilters["StatusID"].FilterConditions.Add((FilterComparisionOperator) 0, (object) 1);
      band3.ColumnFilters["Inactive"].FilterConditions.Clear();
      band3.ColumnFilters["Inactive"].FilterConditions.Add((FilterComparisionOperator) 0, (object) false);
      band4.ColumnFilters["Inactive"].FilterConditions.Clear();
      band4.ColumnFilters["Inactive"].FilterConditions.Add((FilterComparisionOperator) 0, (object) false);
    }
    else
    {
      band1.ColumnFilters["StatusID"].FilterConditions.Clear();
      band2.ColumnFilters["StatusID"].FilterConditions.Clear();
      band3.ColumnFilters["Inactive"].FilterConditions.Clear();
      band4.ColumnFilters["Inactive"].FilterConditions.Clear();
    }
  }

  private void cbCompanyFilter_InitializeLayout(object sender, InitializeLayoutEventArgs e)
  {
    UltraGridBand band = this.cbCompanyFilter.DisplayLayout.Bands[0];
    int num = 2;
    band.Columns["StatusID"].Hidden = false;
    band.Columns["StatusID"].Header.VisiblePosition = num;
    band.Override.AllowRowFiltering = (DefaultableBoolean) 2;
    band.Override.RowFilterMode = (RowFilterMode) 1;
  }

  private void cbCompanies_InitializeLayout(object sender, InitializeLayoutEventArgs e)
  {
    UltraGridBand band = this.cbCompanies.DisplayLayout.Bands[0];
    int num = 2;
    band.Columns["StatusID"].Hidden = false;
    band.Columns["StatusID"].Header.VisiblePosition = num;
    band.Override.AllowRowFiltering = (DefaultableBoolean) 2;
    band.Override.RowFilterMode = (RowFilterMode) 1;
  }

  private void cbLineFilter_InitializeLayout(object sender, InitializeLayoutEventArgs e)
  {
    UltraGridBand band = this.cbLineFilter.DisplayLayout.Bands[0];
    int num = 2;
    band.Columns["Inactive"].Hidden = false;
    band.Columns["Inactive"].Header.VisiblePosition = num;
    band.Override.AllowRowFiltering = (DefaultableBoolean) 2;
    band.Override.RowFilterMode = (RowFilterMode) 1;
  }

  private void cbLines_InitializeLayout(object sender, InitializeLayoutEventArgs e)
  {
    UltraGridBand band = this.cbLines.DisplayLayout.Bands[0];
    int num = 2;
    band.Columns["Inactive"].Hidden = false;
    band.Columns["Inactive"].Header.VisiblePosition = num;
    band.Override.AllowRowFiltering = (DefaultableBoolean) 2;
    band.Override.RowFilterMode = (RowFilterMode) 1;
  }

  private void cbLines_ValueChanged(object sender, EventArgs e)
  {
    this.OnLineChange(RuntimeHelpers.GetObjectValue(this.cbLines.Value));
  }

  private void cbStates_ValueChanged(object sender, EventArgs e)
  {
    this.OnStatehange(RuntimeHelpers.GetObjectValue(this.cbStates.Value));
  }

  private void DuplicateChildPolicyNumbersCheck(Guid companyLineGuid, Guid parentCompanyLineGuid)
  {
    DataTable dataTable = DefaultDatabase.ExecuteDataTable("DuplicateParentChildPolicyNumbers", new object[4]
    {
      (object) "@CompanyLineGuid",
      (object) companyLineGuid,
      (object) "@ParentCompanyLineGuid",
      (object) parentCompanyLineGuid
    });
    if (dataTable.Rows.Count <= 0)
      return;
    string str = dataTable.Rows.Count > 1 ? "are" : "is";
    StringBuilder stringBuilder = new StringBuilder();
    List<int> intList = new List<int>();
    stringBuilder.AppendLine(string.Empty);
    stringBuilder.AppendLine(string.Empty);
    try
    {
      foreach (DataRow row in dataTable.Rows)
      {
        intList.Add((int) row.Field<short>("RuleID"));
        stringBuilder.AppendLine(row.Field<string>("RuleName"));
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    if (MessageBox.Show($"The following policy # rule(s) on this child {str} the same on the parent.{Environment.NewLine} Remove Policy # Rule(s)? {stringBuilder}", "Duplicate Policy # Rules", MessageBoxButtons.YesNo) != DialogResult.Yes)
      return;
    try
    {
      this.Cursor = MgaCursors.Working;
      int companyLineId = new CompanyLine(companyLineGuid).CompanyLineID;
      try
      {
        foreach (int num in intList)
          DefaultDatabase.ExecuteNonQuery(CommandType.Text, "delete from tblCompanyLinePolicyNumbers where CompanyLineID = @CL and PolicyNumberRuleID = @ID", new object[4]
          {
            (object) "@CL",
            (object) companyLineId,
            (object) "@ID",
            (object) num
          });
      }
      finally
      {
        List<int>.Enumerator enumerator;
        enumerator.Dispose();
      }
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
    }
  }

  private void cboCompanyLicensed_ValueChanged(object sender, EventArgs e)
  {
    this.OnCompanyLicenseChange(RuntimeHelpers.GetObjectValue(this.cboCompanyLicensed.Value));
  }

  private delegate void ShowErrorOnUIThreadHandler(ConstraintException ex);

  private delegate void FillDataThreadCompleteDelegate();

  private delegate void FilterGridThreadCompleteHandler();

  private struct POINTAPI
  {
    public int x;
    public int y;
  }

  private struct MINMAXINFO
  {
    public frmCompanyLines.POINTAPI ptReserved;
    public frmCompanyLines.POINTAPI ptMaxSize;
    public frmCompanyLines.POINTAPI ptMaxPosition;
    public frmCompanyLines.POINTAPI ptMinTrackSize;
    public frmCompanyLines.POINTAPI ptMaxTrackSize;
  }

  private class ComboBoxDataSource
  {
    private readonly object _dataSource;
    private readonly string _displayMember;

    public ComboBoxDataSource(object dataSource, string displayMember)
    {
      this._dataSource = RuntimeHelpers.GetObjectValue(dataSource);
      this._displayMember = displayMember;
    }

    public object DataSource => this._dataSource;

    public string DisplayMember => this._displayMember;
  }
}
