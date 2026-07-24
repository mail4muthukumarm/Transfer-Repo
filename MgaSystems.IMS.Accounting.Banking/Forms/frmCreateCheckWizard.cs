// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Banking.Forms.frmCreateCheckWizard
// Assembly: MgaSystems.IMS.Accounting.Banking, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: ED5B99DC-3DD2-44AB-BA36-49A11A94937D
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Banking.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using MGASystems.Common;
using MGASystems.IMS.Accounting.AccountingDatasets;
using MGASystems.IMS.Accounting.Controls;
using MGASystems.IMS.Accounting.Core.Forms;
using MGASystems.IMS.Accounting.Shared;
using MGASystems.IMS.Accounting.Utilities.Exceptions;
using MGASystems.IMS.Security;
using MGASystems.Tools;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Banking.Forms;

[SecureResource("{064AAFC5-45F0-4ecc-BA29-7D7002DA85B6}", "Create Check", "Determines whether or not a user can create a manual check using the create check wizard.", "Accounting")]
public class frmCreateCheckWizard : Form
{
  private IContainer components;
  private const string ConfirmString = "Pay {0}\r\n{1} from\r\n{2}\r\noffset by\r\n{3}.";
  private int _currentBankId;
  private bool _trackingChangedBankIdRequired;

  public frmCreateCheckWizard()
  {
    this.Load += new EventHandler(this.frmCreateCheckWizard_Load);
    this._currentBankId = -1;
    this._trackingChangedBankIdRequired = false;
    this.InitializeComponent();
    this.FormDataConnection.ConnectionString = CurrentUser.Instance.ConnectionString;
    ((UltraGridBase) this.cmbOfficeLocation).DataSource = (object) Methods.GetOfficeLocationDataset();
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [field: AccessedThroughProperty("Label12")]
  internal virtual Label Label12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label21")]
  internal virtual Label Label21 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Panel4")]
  internal virtual Panel Panel4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Panel7")]
  internal virtual Panel Panel7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PictureBox10")]
  internal virtual PictureBox PictureBox10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label13")]
  internal virtual Label Label13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label14")]
  internal virtual Label Label14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Panel11")]
  internal virtual Panel Panel11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PictureBox3")]
  internal virtual PictureBox PictureBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Panel12")]
  internal virtual Panel Panel12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PictureBox11")]
  internal virtual PictureBox PictureBox11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label17")]
  internal virtual Label Label17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label18")]
  internal virtual Label Label18 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("panelStart")]
  internal virtual Panel panelStart { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Panel9")]
  internal virtual Panel Panel9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PictureBox5")]
  internal virtual PictureBox PictureBox5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label20")]
  internal virtual Label Label20 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label19")]
  internal virtual Label Label19 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Panel8")]
  internal virtual Panel Panel8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGAButton btnStartNext
  {
    get => this._btnStartNext;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.NextButton);
      MGAButton btnStartNext1 = this._btnStartNext;
      if (btnStartNext1 != null)
        ((Control) btnStartNext1).Click -= eventHandler;
      this._btnStartNext = value;
      MGAButton btnStartNext2 = this._btnStartNext;
      if (btnStartNext2 == null)
        return;
      ((Control) btnStartNext2).Click += eventHandler;
    }
  }

  internal virtual MGAButton btnStartCancel
  {
    get => this._btnStartCancel;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.Cancel);
      MGAButton btnStartCancel1 = this._btnStartCancel;
      if (btnStartCancel1 != null)
        ((Control) btnStartCancel1).Click -= eventHandler;
      this._btnStartCancel = value;
      MGAButton btnStartCancel2 = this._btnStartCancel;
      if (btnStartCancel2 == null)
        return;
      ((Control) btnStartCancel2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("Label24")]
  internal virtual Label Label24 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label23")]
  internal virtual Label Label23 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label11")]
  internal virtual Label Label11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label2")]
  internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label3")]
  internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label4")]
  internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label5")]
  internal virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGASimpleComboBox cmbOfficeLocation
  {
    get => this._cmbOfficeLocation;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      RowSelectedEventHandler selectedEventHandler = new RowSelectedEventHandler(this.cmbOfficeLocation_RowSelected);
      MGASimpleComboBox cmbOfficeLocation1 = this._cmbOfficeLocation;
      if (cmbOfficeLocation1 != null)
        cmbOfficeLocation1.RowSelected -= selectedEventHandler;
      this._cmbOfficeLocation = value;
      MGASimpleComboBox cmbOfficeLocation2 = this._cmbOfficeLocation;
      if (cmbOfficeLocation2 == null)
        return;
      cmbOfficeLocation2.RowSelected += selectedEventHandler;
    }
  }

  internal virtual MGATextBox txtCheckAmount
  {
    get => this._txtCheckAmount;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      CancelEventHandler cancelEventHandler = new CancelEventHandler(this.ValidateCurrencyFields);
      MGATextBox txtCheckAmount1 = this._txtCheckAmount;
      if (txtCheckAmount1 != null)
        ((Control) txtCheckAmount1).Validating -= cancelEventHandler;
      this._txtCheckAmount = value;
      MGATextBox txtCheckAmount2 = this._txtCheckAmount;
      if (txtCheckAmount2 == null)
        return;
      ((Control) txtCheckAmount2).Validating += cancelEventHandler;
    }
  }

  [field: AccessedThroughProperty("cmbBankAccounts")]
  internal virtual MGASimpleComboBox cmbBankAccounts { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtCheckMemo")]
  internal virtual MGATextBox txtCheckMemo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dtpCheckDate")]
  internal virtual MGADateTimePicker dtpCheckDate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("daGetOfficeLocations")]
  internal virtual SqlDataAdapter daGetOfficeLocations { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlSelectCommand1")]
  internal virtual SqlCommand SqlSelectCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("FormDataConnection")]
  internal virtual SqlConnection FormDataConnection { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("daGetBankAccounts")]
  internal virtual SqlDataAdapter daGetBankAccounts { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlSelectCommand2")]
  internal virtual SqlCommand SqlSelectCommand2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("DsBankAccounts1")]
  internal virtual dsBankAccounts DsBankAccounts1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("DsOfficeLocations1")]
  internal virtual dsOfficeLocations DsOfficeLocations1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Panel2")]
  internal virtual Panel Panel2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PictureBox1")]
  internal virtual PictureBox PictureBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Panel3")]
  internal virtual Panel Panel3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PictureBox2")]
  internal virtual PictureBox PictureBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label8")]
  internal virtual Label Label8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label9")]
  internal virtual Label Label9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGATextBox txtDebitAmount
  {
    get => this._txtDebitAmount;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      CancelEventHandler cancelEventHandler = new CancelEventHandler(this.ValidateCurrencyFields);
      MGATextBox txtDebitAmount1 = this._txtDebitAmount;
      if (txtDebitAmount1 != null)
        ((Control) txtDebitAmount1).Validating -= cancelEventHandler;
      this._txtDebitAmount = value;
      MGATextBox txtDebitAmount2 = this._txtDebitAmount;
      if (txtDebitAmount2 == null)
        return;
      ((Control) txtDebitAmount2).Validating += cancelEventHandler;
    }
  }

  [field: AccessedThroughProperty("DsIssueCheckEntries1")]
  internal virtual dsIssueCheckEntries DsIssueCheckEntries1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("DsGLAccountInvoiceBalance1")]
  internal virtual dsGLAccountInvoiceBalance DsGLAccountInvoiceBalance1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGAButton btnCheckInformationBack
  {
    get => this._btnCheckInformationBack;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.BackButton);
      MGAButton checkInformationBack1 = this._btnCheckInformationBack;
      if (checkInformationBack1 != null)
        ((Control) checkInformationBack1).Click -= eventHandler;
      this._btnCheckInformationBack = value;
      MGAButton checkInformationBack2 = this._btnCheckInformationBack;
      if (checkInformationBack2 == null)
        return;
      ((Control) checkInformationBack2).Click += eventHandler;
    }
  }

  internal virtual MGAButton btnCheckInformationNext
  {
    get => this._btnCheckInformationNext;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.NextButton);
      MGAButton checkInformationNext1 = this._btnCheckInformationNext;
      if (checkInformationNext1 != null)
        ((Control) checkInformationNext1).Click -= eventHandler;
      this._btnCheckInformationNext = value;
      MGAButton checkInformationNext2 = this._btnCheckInformationNext;
      if (checkInformationNext2 == null)
        return;
      ((Control) checkInformationNext2).Click += eventHandler;
    }
  }

  internal virtual MGAButton btnCheckInformationCancel
  {
    get => this._btnCheckInformationCancel;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.Cancel);
      MGAButton informationCancel1 = this._btnCheckInformationCancel;
      if (informationCancel1 != null)
        ((Control) informationCancel1).Click -= eventHandler;
      this._btnCheckInformationCancel = value;
      MGAButton informationCancel2 = this._btnCheckInformationCancel;
      if (informationCancel2 == null)
        return;
      ((Control) informationCancel2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("panelDebitAccounts")]
  internal virtual Panel panelDebitAccounts { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGAButton btnDebitAccountsBack
  {
    get => this._btnDebitAccountsBack;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.BackButton);
      MGAButton debitAccountsBack1 = this._btnDebitAccountsBack;
      if (debitAccountsBack1 != null)
        ((Control) debitAccountsBack1).Click -= eventHandler;
      this._btnDebitAccountsBack = value;
      MGAButton debitAccountsBack2 = this._btnDebitAccountsBack;
      if (debitAccountsBack2 == null)
        return;
      ((Control) debitAccountsBack2).Click += eventHandler;
    }
  }

  internal virtual MGAButton btnDebitAccountsNext
  {
    get => this._btnDebitAccountsNext;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.NextButton);
      MGAButton debitAccountsNext1 = this._btnDebitAccountsNext;
      if (debitAccountsNext1 != null)
        ((Control) debitAccountsNext1).Click -= eventHandler;
      this._btnDebitAccountsNext = value;
      MGAButton debitAccountsNext2 = this._btnDebitAccountsNext;
      if (debitAccountsNext2 == null)
        return;
      ((Control) debitAccountsNext2).Click += eventHandler;
    }
  }

  internal virtual MGAButton btnDebitAccountsCancel
  {
    get => this._btnDebitAccountsCancel;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.Cancel);
      MGAButton debitAccountsCancel1 = this._btnDebitAccountsCancel;
      if (debitAccountsCancel1 != null)
        ((Control) debitAccountsCancel1).Click -= eventHandler;
      this._btnDebitAccountsCancel = value;
      MGAButton debitAccountsCancel2 = this._btnDebitAccountsCancel;
      if (debitAccountsCancel2 == null)
        return;
      ((Control) debitAccountsCancel2).Click += eventHandler;
    }
  }

  internal virtual MGAButton btnConfirmationBack
  {
    get => this._btnConfirmationBack;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.BackButton);
      MGAButton confirmationBack1 = this._btnConfirmationBack;
      if (confirmationBack1 != null)
        ((Control) confirmationBack1).Click -= eventHandler;
      this._btnConfirmationBack = value;
      MGAButton confirmationBack2 = this._btnConfirmationBack;
      if (confirmationBack2 == null)
        return;
      ((Control) confirmationBack2).Click += eventHandler;
    }
  }

  internal virtual MGAButton btnFinish
  {
    get => this._btnFinish;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnFinish_Click);
      MGAButton btnFinish1 = this._btnFinish;
      if (btnFinish1 != null)
        ((Control) btnFinish1).Click -= eventHandler;
      this._btnFinish = value;
      MGAButton btnFinish2 = this._btnFinish;
      if (btnFinish2 == null)
        return;
      ((Control) btnFinish2).Click += eventHandler;
    }
  }

  internal virtual MGAButton btnConfirmationCancel
  {
    get => this._btnConfirmationCancel;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.Cancel);
      MGAButton confirmationCancel1 = this._btnConfirmationCancel;
      if (confirmationCancel1 != null)
        ((Control) confirmationCancel1).Click -= eventHandler;
      this._btnConfirmationCancel = value;
      MGAButton confirmationCancel2 = this._btnConfirmationCancel;
      if (confirmationCancel2 == null)
        return;
      ((Control) confirmationCancel2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("panelCheckInformation")]
  internal virtual Panel panelCheckInformation { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("panelConfirmation")]
  internal virtual Panel panelConfirmation { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label6")]
  internal virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual UltraGrid gridInvoiceAllocations
  {
    get => this._gridInvoiceAllocations;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      CellDataErrorEventHandler errorEventHandler1 = new CellDataErrorEventHandler(this.gridInvoiceAllocations_CellDataError);
      BeforeCellUpdateEventHandler updateEventHandler = new BeforeCellUpdateEventHandler(this.gridInvoiceAllocations_BeforeCellUpdate);
      ErrorEventHandler errorEventHandler2 = new ErrorEventHandler(this.gridInvoiceAllocations_Error);
      RowEventHandler rowEventHandler = new RowEventHandler(this.gridInvoiceAllocations_AfterRowUpdate);
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.gridInvoiceAllocations_KeyDown);
      UltraGrid invoiceAllocations1 = this._gridInvoiceAllocations;
      if (invoiceAllocations1 != null)
      {
        invoiceAllocations1.CellDataError -= errorEventHandler1;
        invoiceAllocations1.BeforeCellUpdate -= updateEventHandler;
        invoiceAllocations1.Error -= errorEventHandler2;
        invoiceAllocations1.AfterRowUpdate -= rowEventHandler;
        ((Control) invoiceAllocations1).KeyDown -= keyEventHandler;
      }
      this._gridInvoiceAllocations = value;
      UltraGrid invoiceAllocations2 = this._gridInvoiceAllocations;
      if (invoiceAllocations2 == null)
        return;
      invoiceAllocations2.CellDataError += errorEventHandler1;
      invoiceAllocations2.BeforeCellUpdate += updateEventHandler;
      invoiceAllocations2.Error += errorEventHandler2;
      invoiceAllocations2.AfterRowUpdate += rowEventHandler;
      ((Control) invoiceAllocations2).KeyDown += keyEventHandler;
    }
  }

  [field: AccessedThroughProperty("EllipsePanel1")]
  internal virtual EllipsePanel EllipsePanel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("gridEntries")]
  internal virtual UltraGrid gridEntries { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label7")]
  internal virtual Label Label7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label10")]
  internal virtual Label Label10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtPayeeName")]
  protected virtual MGATextBox txtPayeeName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ErrorProvider1")]
  internal virtual ErrorProvider ErrorProvider1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGAButton btnSearchPayee
  {
    get => this._btnSearchPayee;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.SearchPayee);
      MGAButton btnSearchPayee1 = this._btnSearchPayee;
      if (btnSearchPayee1 != null)
        ((Control) btnSearchPayee1).Click -= eventHandler;
      this._btnSearchPayee = value;
      MGAButton btnSearchPayee2 = this._btnSearchPayee;
      if (btnSearchPayee2 == null)
        return;
      ((Control) btnSearchPayee2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("daGetGLInvoiceBalance")]
  internal virtual SqlDataAdapter daGetGLInvoiceBalance { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlSelectCommand3")]
  internal virtual SqlCommand SqlSelectCommand3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtAccountBalance")]
  internal virtual MGATextBox txtAccountBalance { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGAButton btnAddDebitAmount
  {
    get => this._btnAddDebitAmount;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnAddDebitAcct_Click);
      MGAButton btnAddDebitAmount1 = this._btnAddDebitAmount;
      if (btnAddDebitAmount1 != null)
        ((Control) btnAddDebitAmount1).Click -= eventHandler;
      this._btnAddDebitAmount = value;
      MGAButton btnAddDebitAmount2 = this._btnAddDebitAmount;
      if (btnAddDebitAmount2 == null)
        return;
      ((Control) btnAddDebitAmount2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("lblConfirmation")]
  internal virtual Label lblConfirmation { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtPostingComment")]
  internal virtual MGATextBox txtPostingComment { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label15")]
  internal virtual Label Label15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual ExtendedTreeViewDropDown dtGLAccounts
  {
    get => this._dtGLAccounts;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      ExtendedTreeViewDropDown.AfterSelectDelegate afterSelectDelegate = new ExtendedTreeViewDropDown.AfterSelectDelegate(this.dtGLAccounts_AfterSelect);
      ExtendedTreeViewDropDown dtGlAccounts1 = this._dtGLAccounts;
      if (dtGlAccounts1 != null)
        dtGlAccounts1.AfterSelect -= afterSelectDelegate;
      this._dtGLAccounts = value;
      ExtendedTreeViewDropDown dtGlAccounts2 = this._dtGLAccounts;
      if (dtGlAccounts2 == null)
        return;
      dtGlAccounts2.AfterSelect += afterSelectDelegate;
    }
  }

  [field: AccessedThroughProperty("Label16")]
  internal virtual Label Label16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("comboCostCenter")]
  internal virtual MGASimpleComboBox comboCostCenter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("DsCostCenters1")]
  internal virtual dsCostCenters DsCostCenters1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmCreateCheckWizard));
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("Entries", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("Description");
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("Debit Amt.");
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("Credit Amt.");
    Appearance appearance17 = new Appearance();
    Appearance appearance18 = new Appearance();
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("invoicenum");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("chargecode");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("companylineguid");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("glacctid");
    Appearance appearance19 = new Appearance();
    Appearance appearance20 = new Appearance();
    Appearance appearance21 = new Appearance();
    UltraGridBand ultraGridBand2 = new UltraGridBand("InvoiceBalances", -1);
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("officeInvoiceNum");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("insuredName");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("policyNumber");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("amount");
    Appearance appearance22 = new Appearance();
    Appearance appearance23 = new Appearance();
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("invoiceNum");
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("chargeCode");
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("companyLineGuid");
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("chargeName");
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("AppliedAmount", 0);
    Appearance appearance24 = new Appearance("AppliedAmount");
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
    this.panelCheckInformation = new Panel();
    this.comboCostCenter = new MGASimpleComboBox();
    this.Label16 = new Label();
    this.txtPostingComment = new MGATextBox();
    this.Label15 = new Label();
    this.txtCheckMemo = new MGATextBox();
    this.Label5 = new Label();
    this.dtpCheckDate = new MGADateTimePicker();
    this.Label4 = new Label();
    this.btnSearchPayee = new MGAButton();
    this.txtPayeeName = new MGATextBox();
    this.Label3 = new Label();
    this.cmbBankAccounts = new MGASimpleComboBox();
    this.DsBankAccounts1 = new dsBankAccounts();
    this.Label1 = new Label();
    this.Panel4 = new Panel();
    this.btnCheckInformationBack = new MGAButton();
    this.btnCheckInformationNext = new MGAButton();
    this.btnCheckInformationCancel = new MGAButton();
    this.Panel7 = new Panel();
    this.PictureBox10 = new PictureBox();
    this.Label13 = new Label();
    this.Label14 = new Label();
    this.txtCheckAmount = new MGATextBox();
    this.cmbOfficeLocation = new MGASimpleComboBox();
    this.DsOfficeLocations1 = new dsOfficeLocations();
    this.Label12 = new Label();
    this.Label21 = new Label();
    this.panelDebitAccounts = new Panel();
    this.dtGLAccounts = new ExtendedTreeViewDropDown();
    this.btnAddDebitAmount = new MGAButton();
    this.EllipsePanel1 = new EllipsePanel();
    this.gridEntries = new UltraGrid();
    this.DsIssueCheckEntries1 = new dsIssueCheckEntries();
    this.gridInvoiceAllocations = new UltraGrid();
    this.DsGLAccountInvoiceBalance1 = new dsGLAccountInvoiceBalance();
    this.txtAccountBalance = new MGATextBox();
    this.Label6 = new Label();
    this.txtDebitAmount = new MGATextBox();
    this.Label2 = new Label();
    this.Label11 = new Label();
    this.Panel11 = new Panel();
    this.btnDebitAccountsBack = new MGAButton();
    this.btnDebitAccountsNext = new MGAButton();
    this.btnDebitAccountsCancel = new MGAButton();
    this.PictureBox3 = new PictureBox();
    this.Panel12 = new Panel();
    this.PictureBox11 = new PictureBox();
    this.Label17 = new Label();
    this.Label18 = new Label();
    this.panelStart = new Panel();
    this.Label10 = new Label();
    this.Label7 = new Label();
    this.Panel9 = new Panel();
    this.PictureBox5 = new PictureBox();
    this.Label20 = new Label();
    this.Label19 = new Label();
    this.Panel8 = new Panel();
    this.btnStartNext = new MGAButton();
    this.btnStartCancel = new MGAButton();
    this.Label24 = new Label();
    this.Label23 = new Label();
    this.daGetOfficeLocations = new SqlDataAdapter();
    this.SqlSelectCommand1 = new SqlCommand();
    this.FormDataConnection = new SqlConnection();
    this.daGetBankAccounts = new SqlDataAdapter();
    this.SqlSelectCommand2 = new SqlCommand();
    this.panelConfirmation = new Panel();
    this.lblConfirmation = new Label();
    this.Panel2 = new Panel();
    this.btnConfirmationBack = new MGAButton();
    this.btnFinish = new MGAButton();
    this.btnConfirmationCancel = new MGAButton();
    this.PictureBox1 = new PictureBox();
    this.Panel3 = new Panel();
    this.PictureBox2 = new PictureBox();
    this.Label8 = new Label();
    this.Label9 = new Label();
    this.ErrorProvider1 = new ErrorProvider(this.components);
    this.daGetGLInvoiceBalance = new SqlDataAdapter();
    this.SqlSelectCommand3 = new SqlCommand();
    this.DsCostCenters1 = new dsCostCenters();
    this.panelCheckInformation.SuspendLayout();
    ((ISupportInitialize) this.comboCostCenter).BeginInit();
    ((ISupportInitialize) this.txtPostingComment).BeginInit();
    ((ISupportInitialize) this.txtCheckMemo).BeginInit();
    ((ISupportInitialize) this.dtpCheckDate).BeginInit();
    ((ISupportInitialize) this.btnSearchPayee).BeginInit();
    ((ISupportInitialize) this.txtPayeeName).BeginInit();
    ((ISupportInitialize) this.cmbBankAccounts).BeginInit();
    this.DsBankAccounts1.BeginInit();
    this.Panel4.SuspendLayout();
    ((ISupportInitialize) this.btnCheckInformationBack).BeginInit();
    ((ISupportInitialize) this.btnCheckInformationNext).BeginInit();
    ((ISupportInitialize) this.btnCheckInformationCancel).BeginInit();
    this.Panel7.SuspendLayout();
    ((ISupportInitialize) this.PictureBox10).BeginInit();
    ((ISupportInitialize) this.txtCheckAmount).BeginInit();
    ((ISupportInitialize) this.cmbOfficeLocation).BeginInit();
    this.DsOfficeLocations1.BeginInit();
    this.panelDebitAccounts.SuspendLayout();
    ((ISupportInitialize) this.btnAddDebitAmount).BeginInit();
    this.EllipsePanel1.SuspendLayout();
    ((ISupportInitialize) this.gridEntries).BeginInit();
    this.DsIssueCheckEntries1.BeginInit();
    ((ISupportInitialize) this.gridInvoiceAllocations).BeginInit();
    this.DsGLAccountInvoiceBalance1.BeginInit();
    ((ISupportInitialize) this.txtAccountBalance).BeginInit();
    ((ISupportInitialize) this.txtDebitAmount).BeginInit();
    this.Panel11.SuspendLayout();
    ((ISupportInitialize) this.btnDebitAccountsBack).BeginInit();
    ((ISupportInitialize) this.btnDebitAccountsNext).BeginInit();
    ((ISupportInitialize) this.btnDebitAccountsCancel).BeginInit();
    ((ISupportInitialize) this.PictureBox3).BeginInit();
    this.Panel12.SuspendLayout();
    ((ISupportInitialize) this.PictureBox11).BeginInit();
    this.panelStart.SuspendLayout();
    this.Panel9.SuspendLayout();
    ((ISupportInitialize) this.PictureBox5).BeginInit();
    this.Panel8.SuspendLayout();
    ((ISupportInitialize) this.btnStartNext).BeginInit();
    ((ISupportInitialize) this.btnStartCancel).BeginInit();
    this.panelConfirmation.SuspendLayout();
    this.Panel2.SuspendLayout();
    ((ISupportInitialize) this.btnConfirmationBack).BeginInit();
    ((ISupportInitialize) this.btnFinish).BeginInit();
    ((ISupportInitialize) this.btnConfirmationCancel).BeginInit();
    ((ISupportInitialize) this.PictureBox1).BeginInit();
    this.Panel3.SuspendLayout();
    ((ISupportInitialize) this.PictureBox2).BeginInit();
    ((ISupportInitialize) this.ErrorProvider1).BeginInit();
    this.DsCostCenters1.BeginInit();
    this.SuspendLayout();
    this.panelCheckInformation.BackColor = Color.White;
    this.panelCheckInformation.Controls.Add((Control) this.comboCostCenter);
    this.panelCheckInformation.Controls.Add((Control) this.Label16);
    this.panelCheckInformation.Controls.Add((Control) this.txtPostingComment);
    this.panelCheckInformation.Controls.Add((Control) this.Label15);
    this.panelCheckInformation.Controls.Add((Control) this.txtCheckMemo);
    this.panelCheckInformation.Controls.Add((Control) this.Label5);
    this.panelCheckInformation.Controls.Add((Control) this.dtpCheckDate);
    this.panelCheckInformation.Controls.Add((Control) this.Label4);
    this.panelCheckInformation.Controls.Add((Control) this.btnSearchPayee);
    this.panelCheckInformation.Controls.Add((Control) this.txtPayeeName);
    this.panelCheckInformation.Controls.Add((Control) this.Label3);
    this.panelCheckInformation.Controls.Add((Control) this.cmbBankAccounts);
    this.panelCheckInformation.Controls.Add((Control) this.Label1);
    this.panelCheckInformation.Controls.Add((Control) this.Panel4);
    this.panelCheckInformation.Controls.Add((Control) this.Panel7);
    this.panelCheckInformation.Controls.Add((Control) this.txtCheckAmount);
    this.panelCheckInformation.Controls.Add((Control) this.cmbOfficeLocation);
    this.panelCheckInformation.Controls.Add((Control) this.Label12);
    this.panelCheckInformation.Controls.Add((Control) this.Label21);
    this.panelCheckInformation.Dock = DockStyle.Fill;
    this.panelCheckInformation.ForeColor = Color.Black;
    this.panelCheckInformation.Location = new Point(0, 0);
    this.panelCheckInformation.Name = "panelCheckInformation";
    this.panelCheckInformation.Size = new Size(802, 456);
    this.panelCheckInformation.TabIndex = 1;
    this.panelCheckInformation.Visible = false;
    this.comboCostCenter.BorderStyle = (UIElementBorderStyle) 4;
    this.comboCostCenter.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboCostCenter).Location = new Point(392, 272);
    this.comboCostCenter.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboCostCenter).Name = "comboCostCenter";
    ((Control) this.comboCostCenter).Size = new Size(256 /*0x0100*/, 21);
    ((Control) this.comboCostCenter).TabIndex = 18;
    ((UltraControlBase) this.comboCostCenter).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboCostCenter).UseOsThemes = (DefaultableBoolean) 2;
    this.Label16.AutoSize = true;
    this.Label16.ForeColor = Color.Black;
    this.Label16.Location = new Point(392, 256 /*0x0100*/);
    this.Label16.Name = "Label16";
    this.Label16.Size = new Size(65, 13);
    this.Label16.TabIndex = 17;
    this.Label16.Text = "Cost Center";
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance1.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtPostingComment).Appearance = (AppearanceBase) appearance1;
    ((TextEditorControlBase) this.txtPostingComment).BackColor = Color.White;
    ((Control) this.txtPostingComment).Location = new Point(104, 320);
    ((TextEditorControlBase) this.txtPostingComment).MaxLength = 500;
    this.txtPostingComment.MGAStyle = MGAStyles.Blue;
    this.txtPostingComment.Multiline = true;
    ((Control) this.txtPostingComment).Name = "txtPostingComment";
    ((Control) this.txtPostingComment).Size = new Size(264, 72);
    ((Control) this.txtPostingComment).TabIndex = 15;
    ((UltraControlBase) this.txtPostingComment).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtPostingComment).UseOsThemes = (DefaultableBoolean) 2;
    this.Label15.AutoSize = true;
    this.Label15.ForeColor = Color.Black;
    this.Label15.Location = new Point(104, 304);
    this.Label15.Name = "Label15";
    this.Label15.Size = new Size(90, 13);
    this.Label15.TabIndex = 14;
    this.Label15.Text = "Posting Comment";
    appearance2.BackColor = Color.White;
    appearance2.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance2.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtCheckMemo).Appearance = (AppearanceBase) appearance2;
    ((TextEditorControlBase) this.txtCheckMemo).BackColor = Color.White;
    ((Control) this.txtCheckMemo).Location = new Point(392, 320);
    ((TextEditorControlBase) this.txtCheckMemo).MaxLength = 100;
    this.txtCheckMemo.MGAStyle = MGAStyles.Blue;
    this.txtCheckMemo.Multiline = true;
    ((Control) this.txtCheckMemo).Name = "txtCheckMemo";
    ((Control) this.txtCheckMemo).Size = new Size(256 /*0x0100*/, 72);
    ((Control) this.txtCheckMemo).TabIndex = 13;
    ((UltraControlBase) this.txtCheckMemo).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtCheckMemo).UseOsThemes = (DefaultableBoolean) 2;
    this.Label5.AutoSize = true;
    this.Label5.ForeColor = Color.Black;
    this.Label5.Location = new Point(392, 304);
    this.Label5.Name = "Label5";
    this.Label5.Size = new Size(67, 13);
    this.Label5.TabIndex = 12;
    this.Label5.Text = "Check Memo";
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dtpCheckDate.Appearance = (AppearanceBase) appearance3;
    appearance4.AlphaLevel = (short) 14;
    appearance4.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance4.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance4.BackColorAlpha = (Alpha) 2;
    appearance4.BackGradientAlignment = (GradientAlignment) 4;
    appearance4.BackGradientStyle = (GradientStyle) 5;
    appearance4.BorderAlpha = (Alpha) 1;
    appearance4.BorderColor = Color.FromArgb(78, 122, 171);
    appearance4.ForeColor = Color.FromArgb(49, 85, 153);
    appearance4.ForegroundAlpha = (Alpha) 2;
    this.dtpCheckDate.ButtonAppearance = (AppearanceBase) appearance4;
    this.dtpCheckDate.FormatString = "D";
    ((Control) this.dtpCheckDate).Location = new Point(392, 200);
    this.dtpCheckDate.MGAStyle = MGAStyles.Blue;
    ((Control) this.dtpCheckDate).Name = "dtpCheckDate";
    ((Control) this.dtpCheckDate).Size = new Size(256 /*0x0100*/, 20);
    ((Control) this.dtpCheckDate).TabIndex = 8;
    ((UltraControlBase) this.dtpCheckDate).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtpCheckDate).UseOsThemes = (DefaultableBoolean) 2;
    this.Label4.AutoSize = true;
    this.Label4.ForeColor = Color.Black;
    this.Label4.Location = new Point(392, 184);
    this.Label4.Name = "Label4";
    this.Label4.Size = new Size(62, 13);
    this.Label4.TabIndex = 7;
    this.Label4.Text = "Check Date";
    appearance5.BackColor = Color.FromArgb(248, 248, 248);
    appearance5.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance5.BackGradientStyle = (GradientStyle) 2;
    appearance5.BorderColor = Color.DarkGray;
    appearance5.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance5.Image"));
    appearance5.ImageHAlign = (HAlign) 2;
    appearance5.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnSearchPayee).Appearance = (AppearanceBase) appearance5;
    ((Control) this.btnSearchPayee).Location = new Point(346, 272);
    ((Control) this.btnSearchPayee).Name = "btnSearchPayee";
    ((Control) this.btnSearchPayee).Size = new Size(20, 20);
    ((Control) this.btnSearchPayee).TabIndex = 11;
    this.btnSearchPayee.UseOSThemes = (DefaultableBoolean) 2;
    appearance6.BackColor = Color.White;
    appearance6.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance6.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtPayeeName).Appearance = (AppearanceBase) appearance6;
    ((TextEditorControlBase) this.txtPayeeName).BackColor = Color.White;
    ((Control) this.txtPayeeName).Enabled = false;
    ((Control) this.txtPayeeName).Location = new Point(104, 272);
    this.txtPayeeName.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtPayeeName).Name = "txtPayeeName";
    ((EditorButtonControlBase) this.txtPayeeName).ReadOnly = true;
    ((Control) this.txtPayeeName).Size = new Size(240 /*0xF0*/, 20);
    ((Control) this.txtPayeeName).TabIndex = 10;
    ((UltraControlBase) this.txtPayeeName).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtPayeeName).UseOsThemes = (DefaultableBoolean) 2;
    this.Label3.AutoSize = true;
    this.Label3.ForeColor = Color.Black;
    this.Label3.Location = new Point(104, 256 /*0x0100*/);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(37, 13);
    this.Label3.TabIndex = 9;
    this.Label3.Text = "Payee";
    this.cmbBankAccounts.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.cmbBankAccounts).DataMember = "spFin_GetBankAccounts";
    ((UltraGridBase) this.cmbBankAccounts).DataSource = (object) this.DsBankAccounts1;
    ((UltraDropDownBase) this.cmbBankAccounts).DisplayMember = "BANKNAME";
    this.cmbBankAccounts.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cmbBankAccounts).Location = new Point(104, 200);
    this.cmbBankAccounts.MGAStyle = MGAStyles.Blue;
    ((Control) this.cmbBankAccounts).Name = "cmbBankAccounts";
    ((Control) this.cmbBankAccounts).Size = new Size(256 /*0x0100*/, 21);
    ((Control) this.cmbBankAccounts).TabIndex = 6;
    ((UltraControlBase) this.cmbBankAccounts).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cmbBankAccounts).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cmbBankAccounts).ValueMember = "GLACCTID";
    this.DsBankAccounts1.DataSetName = "dsBankAccounts";
    this.DsBankAccounts1.Locale = new CultureInfo("en-US");
    this.Label1.AutoSize = true;
    this.Label1.ForeColor = Color.Black;
    this.Label1.Location = new Point(104, 184);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(72, 13);
    this.Label1.TabIndex = 5;
    this.Label1.Text = "Bank Account";
    this.Panel4.BackgroundImage = (Image) componentResourceManager.GetObject("Panel4.BackgroundImage");
    this.Panel4.Controls.Add((Control) this.btnCheckInformationBack);
    this.Panel4.Controls.Add((Control) this.btnCheckInformationNext);
    this.Panel4.Controls.Add((Control) this.btnCheckInformationCancel);
    this.Panel4.Dock = DockStyle.Bottom;
    this.Panel4.Location = new Point(0, 416);
    this.Panel4.Name = "Panel4";
    this.Panel4.Size = new Size(802, 40);
    this.Panel4.TabIndex = 16 /*0x10*/;
    ((Control) this.btnCheckInformationBack).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    appearance7.BackColor = Color.FromArgb(248, 248, 248);
    appearance7.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance7.BackGradientStyle = (GradientStyle) 2;
    appearance7.BorderColor = Color.DarkGray;
    appearance7.ImageHAlign = (HAlign) 2;
    appearance7.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnCheckInformationBack).Appearance = (AppearanceBase) appearance7;
    ((Control) this.btnCheckInformationBack).Location = new Point(504, 8);
    ((Control) this.btnCheckInformationBack).Name = "btnCheckInformationBack";
    ((Control) this.btnCheckInformationBack).Size = new Size(100, 24);
    ((Control) this.btnCheckInformationBack).TabIndex = 0;
    ((ControlBase) this.btnCheckInformationBack).Text = "< &Back";
    this.btnCheckInformationBack.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.btnCheckInformationNext).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    appearance8.BackColor = Color.FromArgb(248, 248, 248);
    appearance8.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance8.BackGradientStyle = (GradientStyle) 2;
    appearance8.BorderColor = Color.DarkGray;
    appearance8.ImageHAlign = (HAlign) 2;
    appearance8.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnCheckInformationNext).Appearance = (AppearanceBase) appearance8;
    ((Control) this.btnCheckInformationNext).Location = new Point(608, 8);
    ((Control) this.btnCheckInformationNext).Name = "btnCheckInformationNext";
    ((Control) this.btnCheckInformationNext).Size = new Size(100, 24);
    ((Control) this.btnCheckInformationNext).TabIndex = 1;
    ((ControlBase) this.btnCheckInformationNext).Text = "&Next >";
    this.btnCheckInformationNext.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.btnCheckInformationCancel).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    appearance9.BackColor = Color.FromArgb(248, 248, 248);
    appearance9.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance9.BackGradientStyle = (GradientStyle) 2;
    appearance9.BorderColor = Color.DarkGray;
    appearance9.ImageHAlign = (HAlign) 2;
    appearance9.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnCheckInformationCancel).Appearance = (AppearanceBase) appearance9;
    ((Control) this.btnCheckInformationCancel).Location = new Point(720, 8);
    ((Control) this.btnCheckInformationCancel).Name = "btnCheckInformationCancel";
    ((Control) this.btnCheckInformationCancel).Size = new Size(75, 24);
    ((Control) this.btnCheckInformationCancel).TabIndex = 2;
    ((ControlBase) this.btnCheckInformationCancel).Text = "&Cancel";
    this.btnCheckInformationCancel.UseOSThemes = (DefaultableBoolean) 2;
    this.Panel7.BackColor = Color.Transparent;
    this.Panel7.BackgroundImage = (Image) componentResourceManager.GetObject("Panel7.BackgroundImage");
    this.Panel7.Controls.Add((Control) this.PictureBox10);
    this.Panel7.Controls.Add((Control) this.Label13);
    this.Panel7.Controls.Add((Control) this.Label14);
    this.Panel7.Dock = DockStyle.Top;
    this.Panel7.Location = new Point(0, 0);
    this.Panel7.Name = "Panel7";
    this.Panel7.Size = new Size(802, 80 /*0x50*/);
    this.Panel7.TabIndex = 0;
    this.PictureBox10.Image = (Image) componentResourceManager.GetObject("PictureBox10.Image");
    this.PictureBox10.Location = new Point(728, 8);
    this.PictureBox10.Name = "PictureBox10";
    this.PictureBox10.Size = new Size(64 /*0x40*/, 64 /*0x40*/);
    this.PictureBox10.SizeMode = PictureBoxSizeMode.AutoSize;
    this.PictureBox10.TabIndex = 3;
    this.PictureBox10.TabStop = false;
    this.Label13.BackColor = Color.Transparent;
    this.Label13.ForeColor = Color.White;
    this.Label13.Location = new Point(16 /*0x10*/, 40);
    this.Label13.Name = "Label13";
    this.Label13.Size = new Size(552, 24);
    this.Label13.TabIndex = 1;
    this.Label13.Text = "Please specify the office location, bank account, payee, check amount, check date and check memo.";
    this.Label14.AutoSize = true;
    this.Label14.BackColor = Color.Transparent;
    this.Label14.Font = new Font("Tahoma", 14f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label14.ForeColor = Color.White;
    this.Label14.Location = new Point(16 /*0x10*/, 8);
    this.Label14.Name = "Label14";
    this.Label14.Size = new Size(406, 23);
    this.Label14.TabIndex = 0;
    this.Label14.Text = "Create Check Wizard - Check Information";
    appearance10.BackColor = Color.White;
    appearance10.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance10.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtCheckAmount).Appearance = (AppearanceBase) appearance10;
    ((TextEditorControlBase) this.txtCheckAmount).BackColor = Color.White;
    ((Control) this.txtCheckAmount).Location = new Point(392, 128 /*0x80*/);
    this.txtCheckAmount.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtCheckAmount).Name = "txtCheckAmount";
    ((Control) this.txtCheckAmount).Size = new Size(256 /*0x0100*/, 20);
    ((Control) this.txtCheckAmount).TabIndex = 4;
    ((UltraControlBase) this.txtCheckAmount).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtCheckAmount).UseOsThemes = (DefaultableBoolean) 2;
    this.cmbOfficeLocation.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.cmbOfficeLocation).DataMember = "spFin_GetOfficeLocations";
    ((UltraGridBase) this.cmbOfficeLocation).DataSource = (object) this.DsOfficeLocations1;
    ((UltraDropDownBase) this.cmbOfficeLocation).DisplayMember = "Office Location";
    this.cmbOfficeLocation.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cmbOfficeLocation).Location = new Point(104, 128 /*0x80*/);
    this.cmbOfficeLocation.MGAStyle = MGAStyles.Blue;
    ((Control) this.cmbOfficeLocation).Name = "cmbOfficeLocation";
    ((Control) this.cmbOfficeLocation).Size = new Size(256 /*0x0100*/, 21);
    ((Control) this.cmbOfficeLocation).TabIndex = 2;
    ((UltraControlBase) this.cmbOfficeLocation).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cmbOfficeLocation).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cmbOfficeLocation).ValueMember = "ID";
    this.DsOfficeLocations1.DataSetName = "dsOfficeLocations";
    this.DsOfficeLocations1.Locale = new CultureInfo("en-US");
    this.Label12.AutoSize = true;
    this.Label12.ForeColor = Color.Black;
    this.Label12.Location = new Point(104, 112 /*0x70*/);
    this.Label12.Name = "Label12";
    this.Label12.Size = new Size(79, 13);
    this.Label12.TabIndex = 1;
    this.Label12.Text = "Office Location";
    this.Label21.AutoSize = true;
    this.Label21.ForeColor = Color.Black;
    this.Label21.Location = new Point(392, 112 /*0x70*/);
    this.Label21.Name = "Label21";
    this.Label21.Size = new Size(76, 13);
    this.Label21.TabIndex = 3;
    this.Label21.Text = "Check Amount";
    this.panelDebitAccounts.BackColor = Color.White;
    this.panelDebitAccounts.Controls.Add((Control) this.dtGLAccounts);
    this.panelDebitAccounts.Controls.Add((Control) this.btnAddDebitAmount);
    this.panelDebitAccounts.Controls.Add((Control) this.EllipsePanel1);
    this.panelDebitAccounts.Controls.Add((Control) this.gridInvoiceAllocations);
    this.panelDebitAccounts.Controls.Add((Control) this.txtAccountBalance);
    this.panelDebitAccounts.Controls.Add((Control) this.Label6);
    this.panelDebitAccounts.Controls.Add((Control) this.txtDebitAmount);
    this.panelDebitAccounts.Controls.Add((Control) this.Label2);
    this.panelDebitAccounts.Controls.Add((Control) this.Label11);
    this.panelDebitAccounts.Controls.Add((Control) this.Panel11);
    this.panelDebitAccounts.Controls.Add((Control) this.Panel12);
    this.panelDebitAccounts.Dock = DockStyle.Fill;
    this.panelDebitAccounts.Location = new Point(0, 0);
    this.panelDebitAccounts.Name = "panelDebitAccounts";
    this.panelDebitAccounts.Size = new Size(802, 456);
    this.panelDebitAccounts.TabIndex = 2;
    this.panelDebitAccounts.Visible = false;
    this.dtGLAccounts.DropDownHeight = 300;
    this.dtGLAccounts.DropDownWidth = 300;
    this.dtGLAccounts.Font = new Font("Tahoma", 8f);
    this.dtGLAccounts.Location = new Point(24, 112 /*0x70*/);
    this.dtGLAccounts.Name = "dtGLAccounts";
    this.dtGLAccounts.ShowAssetAccounts = ExtendedTreeViewDropDown.Assets.All;
    this.dtGLAccounts.ShowEquityAccounts = true;
    this.dtGLAccounts.ShowExpenseAccounts = true;
    this.dtGLAccounts.ShowIncomeAccounts = true;
    this.dtGLAccounts.ShowLiabilityAccounts = ExtendedTreeViewDropDown.Liabilities.All;
    this.dtGLAccounts.ShowSystemDefinedAccounts = true;
    this.dtGLAccounts.Size = new Size(408, 20);
    this.dtGLAccounts.TabIndex = 11;
    this.dtGLAccounts.UseCheckedStateSelectionOverride = false;
    appearance11.BackColor = Color.FromArgb(248, 248, 248);
    appearance11.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance11.BackGradientStyle = (GradientStyle) 2;
    appearance11.BorderColor = Color.DarkGray;
    appearance11.ImageHAlign = (HAlign) 2;
    appearance11.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnAddDebitAmount).Appearance = (AppearanceBase) appearance11;
    ((Control) this.btnAddDebitAmount).Location = new Point(320, 384);
    ((Control) this.btnAddDebitAmount).Name = "btnAddDebitAmount";
    ((Control) this.btnAddDebitAmount).Size = new Size(112 /*0x70*/, 24);
    ((Control) this.btnAddDebitAmount).TabIndex = 8;
    ((ControlBase) this.btnAddDebitAmount).Text = "Add Debit Amount";
    this.btnAddDebitAmount.UseOSThemes = (DefaultableBoolean) 2;
    this.EllipsePanel1.Controls.Add((Control) this.gridEntries);
    this.EllipsePanel1.Location = new Point(456, 96 /*0x60*/);
    this.EllipsePanel1.Name = "EllipsePanel1";
    this.EllipsePanel1.Size = new Size(336, 312);
    this.EllipsePanel1.TabIndex = 9;
    ((UltraControlBase) this.gridEntries).Cursor = Cursors.Default;
    ((UltraGridBase) this.gridEntries).DataMember = "Entries";
    ((UltraGridBase) this.gridEntries).DataSource = (object) this.DsIssueCheckEntries1;
    appearance12.BackColor = Color.White;
    ((UltraGridBase) this.gridEntries).DisplayLayout.Appearance = (AppearanceBase) appearance12;
    ((UltraGridBase) this.gridEntries).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    appearance13.BackColor = Color.White;
    ((AppearanceBase) appearance13).TextHAlignAsString = "Left";
    ultraGridColumn1.CellAppearance = (AppearanceBase) appearance13;
    ((AppearanceBase) appearance14).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn1.Header).Appearance = (AppearanceBase) appearance14;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Width = 143;
    appearance15.BackColor = Color.White;
    ((AppearanceBase) appearance15).TextHAlignAsString = "Right";
    ultraGridColumn2.CellAppearance = (AppearanceBase) appearance15;
    ultraGridColumn2.Format = "c";
    ((AppearanceBase) appearance16).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn2.Header).Appearance = (AppearanceBase) appearance16;
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Width = 93;
    appearance17.BackColor = Color.White;
    ((AppearanceBase) appearance17).TextHAlignAsString = "Right";
    ultraGridColumn3.CellAppearance = (AppearanceBase) appearance17;
    ultraGridColumn3.Format = "c";
    ((AppearanceBase) appearance18).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn3.Header).Appearance = (AppearanceBase) appearance18;
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridColumn3.Width = 84;
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn4.Header.VisiblePosition = 3;
    ultraGridColumn4.Hidden = true;
    ultraGridColumn4.Width = 67;
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn5.Header.VisiblePosition = 4;
    ultraGridColumn5.Hidden = true;
    ultraGridColumn5.Width = 84;
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn6.Header.VisiblePosition = 5;
    ultraGridColumn6.Hidden = true;
    ultraGridColumn6.Width = 108;
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn7.Header.VisiblePosition = 6;
    ultraGridColumn7.Hidden = true;
    ultraGridColumn7.Width = 87;
    ultraGridBand1.Columns.AddRange(new object[7]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4,
      (object) ultraGridColumn5,
      (object) ultraGridColumn6,
      (object) ultraGridColumn7
    });
    ultraGridBand1.Override.CellClickAction = (CellClickAction) 2;
    ((UltraGridBase) this.gridEntries).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.gridEntries).DisplayLayout.BorderStyle = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.gridEntries).DisplayLayout.Override.AllowAddNew = (AllowAddNew) 2;
    ((UltraGridBase) this.gridEntries).DisplayLayout.Override.AllowColMoving = (AllowColMoving) 1;
    ((UltraGridBase) this.gridEntries).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 1;
    ((UltraGridBase) this.gridEntries).DisplayLayout.Override.AllowColSwapping = (AllowColSwapping) 1;
    ((UltraGridBase) this.gridEntries).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 1;
    ((UltraGridBase) this.gridEntries).DisplayLayout.Override.AllowGroupBy = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridEntries).DisplayLayout.Override.AllowGroupMoving = (AllowGroupMoving) 1;
    ((UltraGridBase) this.gridEntries).DisplayLayout.Override.AllowGroupSwapping = (AllowGroupSwapping) 1;
    ((UltraGridBase) this.gridEntries).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridEntries).DisplayLayout.Override.AllowRowLayoutCellSizing = (RowLayoutSizing) 1;
    ((UltraGridBase) this.gridEntries).DisplayLayout.Override.AllowRowLayoutLabelSizing = (RowLayoutSizing) 1;
    ((UltraGridBase) this.gridEntries).DisplayLayout.Override.AllowRowSummaries = (AllowRowSummaries) 2;
    ((UltraGridBase) this.gridEntries).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridEntries).DisplayLayout.Override.BorderStyleCardArea = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.gridEntries).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.gridEntries).DisplayLayout.Override.BorderStyleHeader = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.gridEntries).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.gridEntries).DisplayLayout.Override.BorderStyleRowSelector = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.gridEntries).DisplayLayout.Override.BorderStyleSummaryFooter = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.gridEntries).DisplayLayout.Override.BorderStyleSummaryFooterCaption = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.gridEntries).DisplayLayout.Override.BorderStyleSummaryValue = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.gridEntries).DisplayLayout.Override.BorderStyleTemplateAddRow = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.gridEntries).DisplayLayout.Override.CellPadding = 0;
    ((UltraGridBase) this.gridEntries).DisplayLayout.Override.CellSpacing = 0;
    appearance19.BackColor = Color.White;
    appearance19.FontData.BoldAsString = "True";
    appearance19.ForeColor = Color.DimGray;
    ((UltraGridBase) this.gridEntries).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance19;
    appearance20.BackColor = Color.White;
    appearance20.BorderAlpha = (Alpha) 3;
    ((UltraGridBase) this.gridEntries).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance20;
    ((UltraGridBase) this.gridEntries).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridEntries).DisplayLayout.Override.RowSpacingAfter = 0;
    ((UltraGridBase) this.gridEntries).DisplayLayout.Override.RowSpacingBefore = 0;
    ((Control) this.gridEntries).Location = new Point(8, 8);
    ((Control) this.gridEntries).Name = "gridEntries";
    ((Control) this.gridEntries).Size = new Size(320, 296);
    ((Control) this.gridEntries).TabIndex = 0;
    ((UltraControlBase) this.gridEntries).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridEntries).UseOsThemes = (DefaultableBoolean) 2;
    this.DsIssueCheckEntries1.DataSetName = "dsIssueCheckEntries";
    this.DsIssueCheckEntries1.Locale = new CultureInfo("en-US");
    ((UltraControlBase) this.gridInvoiceAllocations).Cursor = Cursors.Default;
    ((UltraGridBase) this.gridInvoiceAllocations).DataMember = "InvoiceBalances";
    ((UltraGridBase) this.gridInvoiceAllocations).DataSource = (object) this.DsGLAccountInvoiceBalance1;
    appearance21.BackColor = Color.White;
    ((AppearanceBase) appearance21).TextHAlignAsString = "Left";
    ((UltraGridBase) this.gridInvoiceAllocations).DisplayLayout.Appearance = (AppearanceBase) appearance21;
    ((UltraGridBase) this.gridInvoiceAllocations).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn8.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn8.Header).Caption = "Invoice #";
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn8.Header.VisiblePosition = 0;
    ultraGridColumn8.Width = 41;
    ultraGridColumn9.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn9.Header.VisiblePosition = 1;
    ultraGridColumn9.Hidden = true;
    ultraGridColumn10.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn10.Header).Caption = "Policy #";
    ((HeaderBase) ultraGridColumn10.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn10.Header.VisiblePosition = 2;
    ultraGridColumn10.Width = 100;
    ultraGridColumn11.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance22).TextHAlignAsString = "Right";
    ultraGridColumn11.CellAppearance = (AppearanceBase) appearance22;
    ultraGridColumn11.Format = "c";
    ((AppearanceBase) appearance23).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn11.Header).Appearance = (AppearanceBase) appearance23;
    ((HeaderBase) ultraGridColumn11.Header).Caption = "Balance";
    ((HeaderBase) ultraGridColumn11.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn11.Header.VisiblePosition = 4;
    ultraGridColumn11.Width = 70;
    ((HeaderBase) ultraGridColumn12.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn12.Header.VisiblePosition = 5;
    ultraGridColumn12.Hidden = true;
    ((HeaderBase) ultraGridColumn13.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn13.Header.VisiblePosition = 6;
    ultraGridColumn13.Hidden = true;
    ((HeaderBase) ultraGridColumn14.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn14.Header.VisiblePosition = 7;
    ultraGridColumn14.Hidden = true;
    ultraGridColumn15.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn15.Header).Caption = "Charge Name";
    ((HeaderBase) ultraGridColumn15.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn15.Header.VisiblePosition = 3;
    ultraGridColumn15.Width = 107;
    appearance24.BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance24).TextHAlignAsString = "Right";
    ultraGridColumn16.CellAppearance = (AppearanceBase) appearance24;
    ultraGridColumn16.DataType = typeof (Decimal);
    ultraGridColumn16.DefaultCellValue = (object) new Decimal(new int[4]);
    ultraGridColumn16.Format = "c";
    ((AppearanceBase) appearance25).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn16.Header).Appearance = (AppearanceBase) appearance25;
    ((HeaderBase) ultraGridColumn16.Header).Caption = "Applied Amt";
    ((HeaderBase) ultraGridColumn16.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn16.Header.VisiblePosition = 8;
    ultraGridColumn16.Width = 88;
    ultraGridBand2.Columns.AddRange(new object[9]
    {
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
    ((UltraGridBase) this.gridInvoiceAllocations).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.gridInvoiceAllocations).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance26.BackColor = Color.WhiteSmoke;
    ((UltraGridBase) this.gridInvoiceAllocations).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance26;
    ((UltraGridBase) this.gridInvoiceAllocations).DisplayLayout.Override.BorderStyleCardArea = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.gridInvoiceAllocations).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.gridInvoiceAllocations).DisplayLayout.Override.BorderStyleHeader = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.gridInvoiceAllocations).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.gridInvoiceAllocations).DisplayLayout.Override.BorderStyleRowSelector = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.gridInvoiceAllocations).DisplayLayout.Override.BorderStyleSummaryFooter = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.gridInvoiceAllocations).DisplayLayout.Override.BorderStyleSummaryFooterCaption = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.gridInvoiceAllocations).DisplayLayout.Override.BorderStyleSummaryValue = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.gridInvoiceAllocations).DisplayLayout.Override.BorderStyleTemplateAddRow = (UIElementBorderStyle) 1;
    appearance27.BackColor = Color.White;
    appearance27.FontData.BoldAsString = "True";
    appearance27.FontData.Name = "Tahoma";
    appearance27.ForeColor = Color.DimGray;
    ((UltraGridBase) this.gridInvoiceAllocations).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance27;
    ((UltraGridBase) this.gridInvoiceAllocations).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((Control) this.gridInvoiceAllocations).Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.gridInvoiceAllocations).Location = new Point(24, 192 /*0xC0*/);
    ((Control) this.gridInvoiceAllocations).Name = "gridInvoiceAllocations";
    ((Control) this.gridInvoiceAllocations).Size = new Size(408, 144 /*0x90*/);
    ((Control) this.gridInvoiceAllocations).TabIndex = 5;
    ((Control) this.gridInvoiceAllocations).Text = "Balance From Invoices";
    ((UltraControlBase) this.gridInvoiceAllocations).UseOsThemes = (DefaultableBoolean) 2;
    this.DsGLAccountInvoiceBalance1.DataSetName = "dsGLAccountInvoiceBalance";
    this.DsGLAccountInvoiceBalance1.Locale = new CultureInfo("en-US");
    appearance28.BackColor = Color.White;
    appearance28.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance28.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtAccountBalance).Appearance = (AppearanceBase) appearance28;
    ((TextEditorControlBase) this.txtAccountBalance).BackColor = Color.White;
    ((Control) this.txtAccountBalance).Enabled = false;
    ((Control) this.txtAccountBalance).Location = new Point(24, 160 /*0xA0*/);
    this.txtAccountBalance.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtAccountBalance).Name = "txtAccountBalance";
    ((EditorButtonControlBase) this.txtAccountBalance).ReadOnly = true;
    ((Control) this.txtAccountBalance).Size = new Size(408, 20);
    ((Control) this.txtAccountBalance).TabIndex = 4;
    ((UltraControlBase) this.txtAccountBalance).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtAccountBalance).UseOsThemes = (DefaultableBoolean) 2;
    this.Label6.AutoSize = true;
    this.Label6.ForeColor = Color.Black;
    this.Label6.Location = new Point(24, 144 /*0x90*/);
    this.Label6.Name = "Label6";
    this.Label6.Size = new Size(86, 13);
    this.Label6.TabIndex = 3;
    this.Label6.Text = "Account Balance";
    appearance29.BackColor = Color.White;
    appearance29.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance29.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtDebitAmount).Appearance = (AppearanceBase) appearance29;
    ((TextEditorControlBase) this.txtDebitAmount).BackColor = Color.White;
    ((Control) this.txtDebitAmount).Location = new Point(24, 360);
    this.txtDebitAmount.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtDebitAmount).Name = "txtDebitAmount";
    ((Control) this.txtDebitAmount).Size = new Size(408, 20);
    ((Control) this.txtDebitAmount).TabIndex = 7;
    ((UltraControlBase) this.txtDebitAmount).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtDebitAmount).UseOsThemes = (DefaultableBoolean) 2;
    this.Label2.AutoSize = true;
    this.Label2.ForeColor = Color.Black;
    this.Label2.Location = new Point(24, 344);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(76, 13);
    this.Label2.TabIndex = 6;
    this.Label2.Text = "Debit Amount:";
    this.Label11.AutoSize = true;
    this.Label11.ForeColor = Color.Black;
    this.Label11.Location = new Point(24, 96 /*0x60*/);
    this.Label11.Name = "Label11";
    this.Label11.Size = new Size(65, 13);
    this.Label11.TabIndex = 1;
    this.Label11.Text = "GL Account:";
    this.Panel11.Controls.Add((Control) this.btnDebitAccountsBack);
    this.Panel11.Controls.Add((Control) this.btnDebitAccountsNext);
    this.Panel11.Controls.Add((Control) this.btnDebitAccountsCancel);
    this.Panel11.Controls.Add((Control) this.PictureBox3);
    this.Panel11.Dock = DockStyle.Bottom;
    this.Panel11.Location = new Point(0, 411);
    this.Panel11.Name = "Panel11";
    this.Panel11.Size = new Size(802, 45);
    this.Panel11.TabIndex = 10;
    ((Control) this.btnDebitAccountsBack).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    appearance30.BackColor = Color.FromArgb(248, 248, 248);
    appearance30.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance30.BackGradientStyle = (GradientStyle) 2;
    appearance30.BorderColor = Color.DarkGray;
    appearance30.ImageHAlign = (HAlign) 2;
    appearance30.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnDebitAccountsBack).Appearance = (AppearanceBase) appearance30;
    ((Control) this.btnDebitAccountsBack).Location = new Point(504, 8);
    ((Control) this.btnDebitAccountsBack).Name = "btnDebitAccountsBack";
    ((Control) this.btnDebitAccountsBack).Size = new Size(100, 24);
    ((Control) this.btnDebitAccountsBack).TabIndex = 0;
    ((ControlBase) this.btnDebitAccountsBack).Text = "< &Back";
    this.btnDebitAccountsBack.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.btnDebitAccountsNext).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    appearance31.BackColor = Color.FromArgb(248, 248, 248);
    appearance31.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance31.BackGradientStyle = (GradientStyle) 2;
    appearance31.BorderColor = Color.DarkGray;
    appearance31.ImageHAlign = (HAlign) 2;
    appearance31.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnDebitAccountsNext).Appearance = (AppearanceBase) appearance31;
    ((Control) this.btnDebitAccountsNext).Location = new Point(608, 8);
    ((Control) this.btnDebitAccountsNext).Name = "btnDebitAccountsNext";
    ((Control) this.btnDebitAccountsNext).Size = new Size(100, 24);
    ((Control) this.btnDebitAccountsNext).TabIndex = 1;
    ((ControlBase) this.btnDebitAccountsNext).Text = "&Next >";
    this.btnDebitAccountsNext.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.btnDebitAccountsCancel).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    appearance32.BackColor = Color.FromArgb(248, 248, 248);
    appearance32.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance32.BackGradientStyle = (GradientStyle) 2;
    appearance32.BorderColor = Color.DarkGray;
    appearance32.ImageHAlign = (HAlign) 2;
    appearance32.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnDebitAccountsCancel).Appearance = (AppearanceBase) appearance32;
    ((Control) this.btnDebitAccountsCancel).Location = new Point(720, 8);
    ((Control) this.btnDebitAccountsCancel).Name = "btnDebitAccountsCancel";
    ((Control) this.btnDebitAccountsCancel).Size = new Size(75, 24);
    ((Control) this.btnDebitAccountsCancel).TabIndex = 2;
    ((ControlBase) this.btnDebitAccountsCancel).Text = "&Cancel";
    this.btnDebitAccountsCancel.UseOSThemes = (DefaultableBoolean) 2;
    this.PictureBox3.Dock = DockStyle.Fill;
    this.PictureBox3.Image = (Image) componentResourceManager.GetObject("PictureBox3.Image");
    this.PictureBox3.Location = new Point(0, 0);
    this.PictureBox3.Name = "PictureBox3";
    this.PictureBox3.Size = new Size(802, 45);
    this.PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
    this.PictureBox3.TabIndex = 3;
    this.PictureBox3.TabStop = false;
    this.Panel12.BackColor = Color.Transparent;
    this.Panel12.BackgroundImage = (Image) componentResourceManager.GetObject("Panel12.BackgroundImage");
    this.Panel12.Controls.Add((Control) this.PictureBox11);
    this.Panel12.Controls.Add((Control) this.Label17);
    this.Panel12.Controls.Add((Control) this.Label18);
    this.Panel12.Dock = DockStyle.Top;
    this.Panel12.Location = new Point(0, 0);
    this.Panel12.Name = "Panel12";
    this.Panel12.Size = new Size(802, 80 /*0x50*/);
    this.Panel12.TabIndex = 0;
    this.PictureBox11.Image = (Image) componentResourceManager.GetObject("PictureBox11.Image");
    this.PictureBox11.Location = new Point(728, 8);
    this.PictureBox11.Name = "PictureBox11";
    this.PictureBox11.Size = new Size(64 /*0x40*/, 64 /*0x40*/);
    this.PictureBox11.SizeMode = PictureBoxSizeMode.AutoSize;
    this.PictureBox11.TabIndex = 3;
    this.PictureBox11.TabStop = false;
    this.Label17.BackColor = Color.Transparent;
    this.Label17.ForeColor = Color.White;
    this.Label17.Location = new Point(16 /*0x10*/, 40);
    this.Label17.Name = "Label17";
    this.Label17.Size = new Size(552, 24);
    this.Label17.TabIndex = 1;
    this.Label17.Text = "The system will credit the selected bank account. Please specify one or more offsetting debit accounts.";
    this.Label18.AutoSize = true;
    this.Label18.BackColor = Color.Transparent;
    this.Label18.Font = new Font("Tahoma", 14f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label18.ForeColor = Color.White;
    this.Label18.Location = new Point(16 /*0x10*/, 8);
    this.Label18.Name = "Label18";
    this.Label18.Size = new Size(372, 23);
    this.Label18.TabIndex = 0;
    this.Label18.Text = "Create Check Wizard - Debit Accounts";
    this.panelStart.BackColor = Color.White;
    this.panelStart.Controls.Add((Control) this.Label10);
    this.panelStart.Controls.Add((Control) this.Label7);
    this.panelStart.Controls.Add((Control) this.Panel9);
    this.panelStart.Controls.Add((Control) this.Label20);
    this.panelStart.Controls.Add((Control) this.Label19);
    this.panelStart.Controls.Add((Control) this.Panel8);
    this.panelStart.Controls.Add((Control) this.Label24);
    this.panelStart.Controls.Add((Control) this.Label23);
    this.panelStart.Dock = DockStyle.Fill;
    this.panelStart.Location = new Point(0, 0);
    this.panelStart.Name = "panelStart";
    this.panelStart.Size = new Size(802, 456);
    this.panelStart.TabIndex = 0;
    this.Label10.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label10.Location = new Point(168, 168);
    this.Label10.Name = "Label10";
    this.Label10.Size = new Size(624, 40);
    this.Label10.TabIndex = 4;
    this.Label10.Text = "Step 2: After specifying the check information the wizard will have the information it needs to credit the bank account. Next you will need to specify one or more offsetting debit accounts.";
    this.Label7.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label7.Location = new Point(168, 104);
    this.Label7.Name = "Label7";
    this.Label7.Size = new Size(624, 40);
    this.Label7.TabIndex = 3;
    this.Label7.Text = "Step 1: You will have to specify the check information. You will supply the wizard with ther office location, bank account, payee, check amount, check date and check memo.";
    this.Panel9.BackColor = Color.LightSlateGray;
    this.Panel9.Controls.Add((Control) this.PictureBox5);
    this.Panel9.Dock = DockStyle.Left;
    this.Panel9.Location = new Point(0, 0);
    this.Panel9.Name = "Panel9";
    this.Panel9.Size = new Size(152, 416);
    this.Panel9.TabIndex = 0;
    this.PictureBox5.Dock = DockStyle.Fill;
    this.PictureBox5.Image = (Image) componentResourceManager.GetObject("PictureBox5.Image");
    this.PictureBox5.Location = new Point(0, 0);
    this.PictureBox5.Name = "PictureBox5";
    this.PictureBox5.Size = new Size(152, 416);
    this.PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
    this.PictureBox5.TabIndex = 0;
    this.PictureBox5.TabStop = false;
    this.Label20.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label20.Location = new Point(168, 320);
    this.Label20.Name = "Label20";
    this.Label20.Size = new Size(624, 64 /*0x40*/);
    this.Label20.TabIndex = 6;
    this.Label20.Text = "If at any time you wish to cancel this transaction, simply click the 'Cancel' button.";
    this.Label19.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label19.Location = new Point(168, 232);
    this.Label19.Name = "Label19";
    this.Label19.Size = new Size(624, 64 /*0x40*/);
    this.Label19.TabIndex = 5;
    this.Label19.Text = "After completing steps 1 and 2 you can confirm and complete the wizard. If at any time you make a mistake or you want to change a value, you can click the 'Back' button to go back to a previous step.";
    this.Panel8.BackgroundImage = (Image) componentResourceManager.GetObject("Panel8.BackgroundImage");
    this.Panel8.Controls.Add((Control) this.btnStartNext);
    this.Panel8.Controls.Add((Control) this.btnStartCancel);
    this.Panel8.Dock = DockStyle.Bottom;
    this.Panel8.Location = new Point(0, 416);
    this.Panel8.Name = "Panel8";
    this.Panel8.Size = new Size(802, 40);
    this.Panel8.TabIndex = 7;
    ((Control) this.btnStartNext).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    appearance33.BackColor = Color.FromArgb(248, 248, 248);
    appearance33.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance33.BackGradientStyle = (GradientStyle) 2;
    appearance33.BorderColor = Color.DarkGray;
    appearance33.ImageHAlign = (HAlign) 2;
    appearance33.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnStartNext).Appearance = (AppearanceBase) appearance33;
    ((Control) this.btnStartNext).Location = new Point(600, 8);
    ((Control) this.btnStartNext).Name = "btnStartNext";
    ((Control) this.btnStartNext).Size = new Size(100, 24);
    ((Control) this.btnStartNext).TabIndex = 0;
    ((ControlBase) this.btnStartNext).Text = "&Next >";
    this.btnStartNext.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.btnStartCancel).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    appearance34.BackColor = Color.FromArgb(248, 248, 248);
    appearance34.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance34.BackGradientStyle = (GradientStyle) 2;
    appearance34.BorderColor = Color.DarkGray;
    appearance34.ImageHAlign = (HAlign) 2;
    appearance34.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnStartCancel).Appearance = (AppearanceBase) appearance34;
    ((Control) this.btnStartCancel).Location = new Point(712, 8);
    ((Control) this.btnStartCancel).Name = "btnStartCancel";
    ((Control) this.btnStartCancel).Size = new Size(75, 24);
    ((Control) this.btnStartCancel).TabIndex = 1;
    ((ControlBase) this.btnStartCancel).Text = "&Cancel";
    this.btnStartCancel.UseOSThemes = (DefaultableBoolean) 2;
    this.Label24.AutoSize = true;
    this.Label24.Font = new Font("Tahoma", 14f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label24.Location = new Point(168, 8);
    this.Label24.Name = "Label24";
    this.Label24.Size = new Size(208 /*0xD0*/, 23);
    this.Label24.TabIndex = 1;
    this.Label24.Text = "Create Check Wizard";
    this.Label23.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label23.Location = new Point(168, 64 /*0x40*/);
    this.Label23.Name = "Label23";
    this.Label23.Size = new Size(624, 24);
    this.Label23.TabIndex = 2;
    this.Label23.Text = "Welcome to the create check wizard. This wizard will walk you through the steps necessary to create a check.";
    this.daGetOfficeLocations.SelectCommand = this.SqlSelectCommand1;
    this.daGetOfficeLocations.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "spFin_GetOfficeLocations", new DataColumnMapping[2]
      {
        new DataColumnMapping("ID", "ID"),
        new DataColumnMapping("Office Location", "Office Location")
      })
    });
    this.SqlSelectCommand1.CommandText = "[spFin_GetOfficeLocations]";
    this.SqlSelectCommand1.CommandType = CommandType.StoredProcedure;
    this.SqlSelectCommand1.Connection = this.FormDataConnection;
    this.SqlSelectCommand1.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null)
    });
    this.FormDataConnection.ConnectionString = "workstation id=WREYES;packet size=4096;user id=mgasystems;data source=MGASYSTEMS;persist security info=False;initial catalog=IMS";
    this.FormDataConnection.FireInfoMessageEventOnUserErrors = false;
    this.daGetBankAccounts.SelectCommand = this.SqlSelectCommand2;
    this.daGetBankAccounts.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "spFin_GetBankAccounts", new DataColumnMapping[3]
      {
        new DataColumnMapping("GLACCTID", "GLACCTID"),
        new DataColumnMapping("BANKNAME", "BANKNAME"),
        new DataColumnMapping("CLOSED", "CLOSED")
      })
    });
    this.SqlSelectCommand2.CommandText = "[spFin_GetBankAccounts]";
    this.SqlSelectCommand2.CommandType = CommandType.StoredProcedure;
    this.SqlSelectCommand2.Connection = this.FormDataConnection;
    this.SqlSelectCommand2.Parameters.AddRange(new SqlParameter[2]
    {
      new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null),
      new SqlParameter("@GLCOMPANYID", SqlDbType.Int, 4)
    });
    this.panelConfirmation.BackColor = Color.White;
    this.panelConfirmation.Controls.Add((Control) this.lblConfirmation);
    this.panelConfirmation.Controls.Add((Control) this.Panel2);
    this.panelConfirmation.Controls.Add((Control) this.Panel3);
    this.panelConfirmation.Dock = DockStyle.Fill;
    this.panelConfirmation.Location = new Point(0, 0);
    this.panelConfirmation.Name = "panelConfirmation";
    this.panelConfirmation.Size = new Size(802, 456);
    this.panelConfirmation.TabIndex = 3;
    this.panelConfirmation.Visible = false;
    this.lblConfirmation.Font = new Font("Tahoma", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblConfirmation.ForeColor = Color.Black;
    this.lblConfirmation.Location = new Point(24, 88);
    this.lblConfirmation.Name = "lblConfirmation";
    this.lblConfirmation.Size = new Size(744, 320);
    this.lblConfirmation.TabIndex = 1;
    this.lblConfirmation.Text = "Pay";
    this.lblConfirmation.TextAlign = ContentAlignment.MiddleCenter;
    this.Panel2.Controls.Add((Control) this.btnConfirmationBack);
    this.Panel2.Controls.Add((Control) this.btnFinish);
    this.Panel2.Controls.Add((Control) this.btnConfirmationCancel);
    this.Panel2.Controls.Add((Control) this.PictureBox1);
    this.Panel2.Dock = DockStyle.Bottom;
    this.Panel2.Location = new Point(0, 416);
    this.Panel2.Name = "Panel2";
    this.Panel2.Size = new Size(802, 40);
    this.Panel2.TabIndex = 2;
    ((Control) this.btnConfirmationBack).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    appearance35.BackColor = Color.FromArgb(248, 248, 248);
    appearance35.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance35.BackGradientStyle = (GradientStyle) 2;
    appearance35.BorderColor = Color.DarkGray;
    appearance35.ImageHAlign = (HAlign) 2;
    appearance35.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnConfirmationBack).Appearance = (AppearanceBase) appearance35;
    ((Control) this.btnConfirmationBack).Location = new Point(504, 8);
    ((Control) this.btnConfirmationBack).Name = "btnConfirmationBack";
    ((Control) this.btnConfirmationBack).Size = new Size(100, 24);
    ((Control) this.btnConfirmationBack).TabIndex = 0;
    ((ControlBase) this.btnConfirmationBack).Text = "< &Back";
    this.btnConfirmationBack.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.btnFinish).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    appearance36.BackColor = Color.FromArgb(248, 248, 248);
    appearance36.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance36.BackGradientStyle = (GradientStyle) 2;
    appearance36.BorderColor = Color.DarkGray;
    appearance36.ImageHAlign = (HAlign) 2;
    appearance36.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnFinish).Appearance = (AppearanceBase) appearance36;
    ((Control) this.btnFinish).Location = new Point(608, 8);
    ((Control) this.btnFinish).Name = "btnFinish";
    ((Control) this.btnFinish).Size = new Size(100, 24);
    ((Control) this.btnFinish).TabIndex = 1;
    ((ControlBase) this.btnFinish).Text = "&Finish";
    this.btnFinish.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.btnConfirmationCancel).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    appearance37.BackColor = Color.FromArgb(248, 248, 248);
    appearance37.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance37.BackGradientStyle = (GradientStyle) 2;
    appearance37.BorderColor = Color.DarkGray;
    appearance37.ImageHAlign = (HAlign) 2;
    appearance37.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnConfirmationCancel).Appearance = (AppearanceBase) appearance37;
    ((Control) this.btnConfirmationCancel).Location = new Point(720, 8);
    ((Control) this.btnConfirmationCancel).Name = "btnConfirmationCancel";
    ((Control) this.btnConfirmationCancel).Size = new Size(75, 24);
    ((Control) this.btnConfirmationCancel).TabIndex = 2;
    ((ControlBase) this.btnConfirmationCancel).Text = "&Cancel";
    this.btnConfirmationCancel.UseOSThemes = (DefaultableBoolean) 2;
    this.PictureBox1.Dock = DockStyle.Fill;
    this.PictureBox1.Image = (Image) componentResourceManager.GetObject("PictureBox1.Image");
    this.PictureBox1.Location = new Point(0, 0);
    this.PictureBox1.Name = "PictureBox1";
    this.PictureBox1.Size = new Size(802, 40);
    this.PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
    this.PictureBox1.TabIndex = 3;
    this.PictureBox1.TabStop = false;
    this.Panel3.BackColor = Color.Transparent;
    this.Panel3.BackgroundImage = (Image) componentResourceManager.GetObject("Panel3.BackgroundImage");
    this.Panel3.Controls.Add((Control) this.PictureBox2);
    this.Panel3.Controls.Add((Control) this.Label8);
    this.Panel3.Controls.Add((Control) this.Label9);
    this.Panel3.Dock = DockStyle.Top;
    this.Panel3.Location = new Point(0, 0);
    this.Panel3.Name = "Panel3";
    this.Panel3.Size = new Size(802, 80 /*0x50*/);
    this.Panel3.TabIndex = 0;
    this.PictureBox2.Image = (Image) componentResourceManager.GetObject("PictureBox2.Image");
    this.PictureBox2.Location = new Point(728, 8);
    this.PictureBox2.Name = "PictureBox2";
    this.PictureBox2.Size = new Size(64 /*0x40*/, 64 /*0x40*/);
    this.PictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
    this.PictureBox2.TabIndex = 3;
    this.PictureBox2.TabStop = false;
    this.Label8.BackColor = Color.Transparent;
    this.Label8.ForeColor = Color.White;
    this.Label8.Location = new Point(16 /*0x10*/, 40);
    this.Label8.Name = "Label8";
    this.Label8.Size = new Size(552, 24);
    this.Label8.TabIndex = 1;
    this.Label8.Text = "Please review the transaction. If the transaction is correct click the 'Finish' button to complete this wizard.";
    this.Label9.AutoSize = true;
    this.Label9.BackColor = Color.Transparent;
    this.Label9.Font = new Font("Tahoma", 14f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label9.ForeColor = Color.White;
    this.Label9.Location = new Point(16 /*0x10*/, 8);
    this.Label9.Name = "Label9";
    this.Label9.Size = new Size(353, 23);
    this.Label9.TabIndex = 0;
    this.Label9.Text = "Create Check Wizard - Confirmation";
    this.ErrorProvider1.ContainerControl = (ContainerControl) this;
    this.daGetGLInvoiceBalance.SelectCommand = this.SqlSelectCommand3;
    this.daGetGLInvoiceBalance.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "spFin_GetGlAccountInvoiceBalance", new DataColumnMapping[8]
      {
        new DataColumnMapping("officeInvoiceNum", "officeInvoiceNum"),
        new DataColumnMapping("insuredName", "insuredName"),
        new DataColumnMapping("policynumber", "policynumber"),
        new DataColumnMapping("Amount", "Amount"),
        new DataColumnMapping("invoiceNum", "invoiceNum"),
        new DataColumnMapping("chargeCode", "chargeCode"),
        new DataColumnMapping("CompanyLineGuid", "CompanyLineGuid"),
        new DataColumnMapping("chargeName", "chargeName")
      })
    });
    this.SqlSelectCommand3.CommandText = "[spFin_GetGlAccountInvoiceBalance]";
    this.SqlSelectCommand3.CommandType = CommandType.StoredProcedure;
    this.SqlSelectCommand3.Connection = this.FormDataConnection;
    this.SqlSelectCommand3.Parameters.AddRange(new SqlParameter[2]
    {
      new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null),
      new SqlParameter("@glAcctId", SqlDbType.Int, 4)
    });
    this.DsCostCenters1.DataSetName = "dsCostCenters";
    this.DsCostCenters1.Locale = new CultureInfo("en-US");
    this.AutoScaleBaseSize = new Size(5, 14);
    this.ClientSize = new Size(802, 456);
    this.ControlBox = false;
    this.Controls.Add((Control) this.panelCheckInformation);
    this.Controls.Add((Control) this.panelDebitAccounts);
    this.Controls.Add((Control) this.panelConfirmation);
    this.Controls.Add((Control) this.panelStart);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.FormBorderStyle = FormBorderStyle.FixedSingle;
    this.Name = nameof (frmCreateCheckWizard);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Create Check Wizard";
    this.panelCheckInformation.ResumeLayout(false);
    this.panelCheckInformation.PerformLayout();
    ((ISupportInitialize) this.comboCostCenter).EndInit();
    ((ISupportInitialize) this.txtPostingComment).EndInit();
    ((ISupportInitialize) this.txtCheckMemo).EndInit();
    ((ISupportInitialize) this.dtpCheckDate).EndInit();
    ((ISupportInitialize) this.btnSearchPayee).EndInit();
    ((ISupportInitialize) this.txtPayeeName).EndInit();
    ((ISupportInitialize) this.cmbBankAccounts).EndInit();
    this.DsBankAccounts1.EndInit();
    this.Panel4.ResumeLayout(false);
    ((ISupportInitialize) this.btnCheckInformationBack).EndInit();
    ((ISupportInitialize) this.btnCheckInformationNext).EndInit();
    ((ISupportInitialize) this.btnCheckInformationCancel).EndInit();
    this.Panel7.ResumeLayout(false);
    this.Panel7.PerformLayout();
    ((ISupportInitialize) this.PictureBox10).EndInit();
    ((ISupportInitialize) this.txtCheckAmount).EndInit();
    ((ISupportInitialize) this.cmbOfficeLocation).EndInit();
    this.DsOfficeLocations1.EndInit();
    this.panelDebitAccounts.ResumeLayout(false);
    this.panelDebitAccounts.PerformLayout();
    ((ISupportInitialize) this.btnAddDebitAmount).EndInit();
    this.EllipsePanel1.ResumeLayout(false);
    ((ISupportInitialize) this.gridEntries).EndInit();
    this.DsIssueCheckEntries1.EndInit();
    ((ISupportInitialize) this.gridInvoiceAllocations).EndInit();
    this.DsGLAccountInvoiceBalance1.EndInit();
    ((ISupportInitialize) this.txtAccountBalance).EndInit();
    ((ISupportInitialize) this.txtDebitAmount).EndInit();
    this.Panel11.ResumeLayout(false);
    ((ISupportInitialize) this.btnDebitAccountsBack).EndInit();
    ((ISupportInitialize) this.btnDebitAccountsNext).EndInit();
    ((ISupportInitialize) this.btnDebitAccountsCancel).EndInit();
    ((ISupportInitialize) this.PictureBox3).EndInit();
    this.Panel12.ResumeLayout(false);
    this.Panel12.PerformLayout();
    ((ISupportInitialize) this.PictureBox11).EndInit();
    this.panelStart.ResumeLayout(false);
    this.panelStart.PerformLayout();
    this.Panel9.ResumeLayout(false);
    ((ISupportInitialize) this.PictureBox5).EndInit();
    this.Panel8.ResumeLayout(false);
    ((ISupportInitialize) this.btnStartNext).EndInit();
    ((ISupportInitialize) this.btnStartCancel).EndInit();
    this.panelConfirmation.ResumeLayout(false);
    this.Panel2.ResumeLayout(false);
    ((ISupportInitialize) this.btnConfirmationBack).EndInit();
    ((ISupportInitialize) this.btnFinish).EndInit();
    ((ISupportInitialize) this.btnConfirmationCancel).EndInit();
    ((ISupportInitialize) this.PictureBox1).EndInit();
    this.Panel3.ResumeLayout(false);
    this.Panel3.PerformLayout();
    ((ISupportInitialize) this.PictureBox2).EndInit();
    ((ISupportInitialize) this.ErrorProvider1).EndInit();
    this.DsCostCenters1.EndInit();
    this.ResumeLayout(false);
  }

  private void NextButton(object sender, EventArgs e)
  {
    this.panelStart.Visible = false;
    if (sender == this.btnStartNext)
    {
      this.panelCheckInformation.Visible = true;
      this.panelDebitAccounts.Visible = false;
      this.panelConfirmation.Visible = false;
    }
    if (sender == this.btnCheckInformationNext)
    {
      if (this._trackingChangedBankIdRequired && this.cmbBankAccounts.Value != null && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbBankAccounts.Value.ToString(), string.Empty, false) != 0)
        this.UpdateGridWithNewValues(int.Parse(this.cmbBankAccounts.Value.ToString()), this._currentBankId);
      if (!this.ValidateCheckInfomation())
        return;
      if (!this._trackingChangedBankIdRequired)
        this.AddCashEntry();
      this.panelCheckInformation.Visible = false;
      this.panelDebitAccounts.Visible = true;
      this.panelConfirmation.Visible = false;
    }
    if (sender != this.btnDebitAccountsNext || !this.VerifyDebitsAndCredits())
      return;
    this.lblConfirmation.Text = this.CreateConfirmString();
    this.panelCheckInformation.Visible = false;
    this.panelDebitAccounts.Visible = false;
    this.panelConfirmation.Visible = true;
  }

  private void BackButton(object sender, EventArgs e)
  {
    this.panelCheckInformation.Visible = false;
    if (sender == this.btnConfirmationBack)
    {
      this.panelCheckInformation.Visible = false;
      this.panelDebitAccounts.Visible = true;
      this.panelStart.Visible = false;
    }
    if (sender == this.btnDebitAccountsBack)
    {
      this.panelCheckInformation.Visible = true;
      this.panelDebitAccounts.Visible = false;
      this.panelStart.Visible = false;
      if (this.cmbBankAccounts.Value != null && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbBankAccounts.Value.ToString(), string.Empty, false) != 0)
        this._currentBankId = int.Parse(this.cmbBankAccounts.Value.ToString());
      this._trackingChangedBankIdRequired = true;
    }
    if (sender != this.btnCheckInformationBack)
      return;
    this.panelCheckInformation.Visible = false;
    this.panelDebitAccounts.Visible = false;
    this.panelStart.Visible = true;
  }

  private void Cancel(object sender, EventArgs e)
  {
    if (MessageBox.Show("Cancel create check wizard?", "Cancel Wizard?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
      return;
    this.DialogResult = DialogResult.Cancel;
    this.Close();
  }

  private void cmbOfficeLocation_RowSelected(object sender, RowSelectedEventArgs e)
  {
    this.DsIssueCheckEntries1.Entries.Clear();
    this.DsIssueCheckEntries1.AcceptChanges();
    this._trackingChangedBankIdRequired = false;
    this._currentBankId = -1;
    ((UltraGridBase) this.gridEntries).DisplayLayout.Bands[0].Summaries.Clear();
    this.dtGLAccounts.ResetText();
    if (((UltraDropDownBase) this.cmbOfficeLocation).SelectedRow == null)
      return;
    try
    {
      this.Cursor = Cursors.WaitCursor;
      this.daGetBankAccounts.SelectCommand.Parameters["@glcompanyid"].Value = (object) Conversions.ToInteger(((UltraDropDownBase) this.cmbOfficeLocation).SelectedRow.Cells["id"].Value);
      this.DsBankAccounts1.spFin_GetBankAccounts.Clear();
      this.daGetBankAccounts.Fill((DataTable) this.DsBankAccounts1.spFin_GetBankAccounts);
      this.dtGLAccounts.LoadGLAccounts(Conversions.ToInteger(((UltraDropDownBase) this.cmbOfficeLocation).SelectedRow.Cells["id"].Value));
      this.dtGLAccounts.DropDownHeight = 300;
      this.dtGLAccounts.DropDownWidth = 300;
      this.LoadCostCenters();
    }
    finally
    {
      this.Cursor = Cursors.Default;
    }
  }

  private bool ValidateCheckInfomation()
  {
    bool flag = true;
    if (((UltraDropDownBase) this.cmbOfficeLocation).SelectedRow == null)
    {
      this.ErrorProvider1.SetError((Control) this.cmbOfficeLocation, "You must select an office location to continue.");
      flag = false;
    }
    else
      this.ErrorProvider1.SetError((Control) this.cmbOfficeLocation, "");
    if (((UltraDropDownBase) this.cmbBankAccounts).SelectedRow == null)
    {
      this.ErrorProvider1.SetError((Control) this.cmbBankAccounts, "You must select a bank account to continue.");
      flag = false;
    }
    else
      this.ErrorProvider1.SetError((Control) this.cmbBankAccounts, "");
    if (((Control) this.txtPayeeName).Tag == null)
    {
      this.ErrorProvider1.SetError((Control) this.txtPayeeName, "You must select a payee to continue.");
      flag = false;
    }
    else
      this.ErrorProvider1.SetError((Control) this.txtPayeeName, "");
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((TextEditorControlBase) this.txtCheckAmount).Text, "", false) == 0 || !Versioned.IsNumeric((object) ((TextEditorControlBase) this.txtCheckAmount).Text))
    {
      this.ErrorProvider1.SetError((Control) this.txtCheckAmount, "You must enter a valid check amount to continue.");
      flag = false;
    }
    else if (Decimal.Compare(Conversions.ToDecimal(((TextEditorControlBase) this.txtCheckAmount).Text), 0M) < 0)
    {
      this.ErrorProvider1.SetError((Control) this.txtCheckAmount, "Check amount must be greater than zero.");
      flag = false;
    }
    else
      this.ErrorProvider1.SetError((Control) this.txtCheckAmount, "");
    if (((UltraDropDownBase) this.comboCostCenter).SelectedRow == null)
    {
      this.ErrorProvider1.SetError((Control) this.comboCostCenter, "You must select a cost center to continue.");
      flag = false;
    }
    else
      this.ErrorProvider1.SetError((Control) this.comboCostCenter, "");
    return flag;
  }

  protected virtual void SearchPayee(object sender, EventArgs e)
  {
    FormSearchEntity formSearchEntity = new FormSearchEntity(MGASystems.IMS.Accounting.Core.ClassObjects.Utility.SearchEntityTypes.All);
    try
    {
      if (formSearchEntity.ShowDialog() != DialogResult.OK)
        return;
      ((TextEditorControlBase) this.txtPayeeName).Text = formSearchEntity.EntityName;
      ((Control) this.txtPayeeName).Tag = (object) formSearchEntity.EntityGuid;
    }
    finally
    {
      formSearchEntity.Dispose();
    }
  }

  private void ValidateCurrencyFields(object sender, CancelEventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((TextEditorControlBase) sender).Text, "", false) == 0 || !Versioned.IsNumeric((object) ((TextEditorControlBase) sender).Text))
      return;
    ((TextEditorControlBase) sender).Text = Microsoft.VisualBasic.Strings.Format((object) ((TextEditorControlBase) sender).Text, "Currency");
  }

  private void DropTreeOffset_CloseUp(object sender, ExtendedDropTree_EventArgs e)
  {
    if (this.dtGLAccounts.GLAccountID == -1 || this.dtGLAccounts.GLAccountID == 0)
      return;
    this.DsGLAccountInvoiceBalance1.Clear();
    this.daGetGLInvoiceBalance.SelectCommand.Parameters["@glAcctId"].Value = (object) this.dtGLAccounts.GLAccountID;
    this.daGetGLInvoiceBalance.Fill((DataTable) this.DsGLAccountInvoiceBalance1.InvoiceBalances);
  }

  private void DropTreeOffset_AfterSelect(object sender, ExtendedDropTree_EventArgs e)
  {
    if (this.dtGLAccounts.GLAccountID == 0 || this.dtGLAccounts.GLAccountID == -1)
      return;
    ((TextEditorControlBase) this.txtAccountBalance).Text = Microsoft.VisualBasic.Strings.Format((object) Decimal.Multiply(MGASystems.IMS.Accounting.Utilities.Tools.GetGLAccountBalance(this.dtGLAccounts.GLAccountID), -1M), "Currency");
  }

  public void AddIssuanceEntry(
    string Description,
    Decimal CreditAmount = 0M,
    Decimal DebitAmount = 0M,
    int InvoiceNumber = -1,
    int ChargeCode = -1,
    string CompanyLineGuid = "",
    int GLAccountID = -1)
  {
    this.DsIssueCheckEntries1.Entries.AddEntriesRow(Description, DebitAmount, CreditAmount, InvoiceNumber, ChargeCode, CompanyLineGuid, GLAccountID);
    this.RefreshGridSummaries();
  }

  private void AddCashEntry()
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((TextEditorControlBase) this.txtCheckAmount).Text, "", false) == 0 || !Versioned.IsNumeric((object) ((TextEditorControlBase) this.txtCheckAmount).Text) || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbBankAccounts.Text.Trim(), "", false) == 0)
      return;
    bool flag = false;
    foreach (UltraGridRow row in ((UltraGridBase) this.gridEntries).Rows)
    {
      if (row.Cells["Description"].Value.ToString().StartsWith("CASH"))
      {
        row.Cells["Credit Amt."].Value = (object) Conversions.ToDecimal(((TextEditorControlBase) this.txtCheckAmount).Text);
        row.Cells["Debit Amt."].Value = (object) 0M;
        flag = true;
        break;
      }
    }
    if (flag)
      return;
    this.AddIssuanceEntry("CASH-" + this.cmbBankAccounts.Text, Conversions.ToDecimal(((TextEditorControlBase) this.txtCheckAmount).Text), GLAccountID: Conversions.ToInteger(this.cmbBankAccounts.Value));
  }

  private void gridInvoiceAllocations_CellDataError(object sender, CellDataErrorEventArgs e)
  {
    int num = (int) MessageBox.Show("Applied amount must be numeric!", "Invalid Entry!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    e.RestoreOriginalValue = true;
  }

  private void gridInvoiceAllocations_BeforeCellUpdate(object sender, BeforeCellUpdateEventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(e.Cell.Column.Key, "AppliedAmount", false) != 0 || Information.IsDBNull(RuntimeHelpers.GetObjectValue(e.NewValue)) || !Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(e.NewValue)))
      return;
    if (Decimal.Compare(Conversions.ToDecimal(e.NewValue), 0M) < 0)
    {
      int num = (int) MessageBox.Show("Applied amount must be greater than zero.", "Invalid Entry!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      ((CancelEventArgs) e).Cancel = true;
    }
    if (Decimal.Compare(Conversions.ToDecimal(e.NewValue), Conversions.ToDecimal(e.Cell.Row.Cells["Amount"].Value)) <= 0)
      return;
    int num1 = (int) MessageBox.Show("Applied amount can not exceed balance.", "Invalid Entry!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    ((CancelEventArgs) e).Cancel = true;
  }

  private void gridInvoiceAllocations_Error(object sender, ErrorEventArgs e)
  {
    ((CancelEventArgs) e).Cancel = true;
  }

  private Decimal InvoiceAllocationsTotal()
  {
    Decimal d1;
    foreach (UltraGridRow row in ((UltraGridBase) this.gridInvoiceAllocations).Rows)
    {
      if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(row.Cells["AppliedAmount"].Value)) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(row.Cells["AppliedAmount"].Text, "", false) != 0)
        d1 = Decimal.Add(d1, Conversions.ToDecimal(row.Cells["AppliedAmount"].Value));
    }
    return d1;
  }

  private void gridInvoiceAllocations_AfterRowUpdate(object sender, RowEventArgs e)
  {
    ((UltraGridBase) this.gridInvoiceAllocations).DisplayLayout.Bands[0].Summaries.Clear();
    ((UltraGridBase) this.gridInvoiceAllocations).DisplayLayout.Bands[0].Summaries.Add("appliedSum", (SummaryType) 1, ((UltraGridBase) this.gridInvoiceAllocations).DisplayLayout.Bands[0].Columns["AppliedAmount"], (SummaryPosition) 3);
    try
    {
      foreach (SummarySettings summary in (IEnumerable) ((UltraGridBase) this.gridInvoiceAllocations).DisplayLayout.Bands[0].Summaries)
      {
        summary.DisplayFormat = "{0:c}";
        summary.Appearance.TextHAlign = (HAlign) 3;
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    ((UltraGridBase) this.gridInvoiceAllocations).DisplayLayout.Bands[0].SummaryFooterCaption = "";
  }

  private void gridInvoiceAllocations_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return || !Versioned.IsNumeric((object) ((UltraGridBase) this.gridInvoiceAllocations).ActiveRow.Cells["AppliedAmount"].Text))
      return;
    ((UltraGridBase) this.gridInvoiceAllocations).ActiveRow.Update();
  }

  private void RefreshGridSummaries()
  {
    ((UltraGridBase) this.gridEntries).DisplayLayout.Bands[0].SortedColumns.Add("Debit Amt.", true);
    ((UltraGridBase) this.gridEntries).DisplayLayout.Bands[0].Summaries.Clear();
    UltraGridLayout displayLayout = ((UltraGridBase) this.gridEntries).DisplayLayout;
    displayLayout.Bands[0].Summaries.Add("DebitSum", (SummaryType) 1, displayLayout.Bands[0].Columns["Debit Amt."], (SummaryPosition) 3);
    displayLayout.Bands[0].Summaries.Add("CreditSum", (SummaryType) 1, displayLayout.Bands[0].Columns["Credit Amt."], (SummaryPosition) 3);
    try
    {
      foreach (SummarySettings summary in (IEnumerable) displayLayout.Bands[0].Summaries)
        summary.DisplayFormat = "{0:c}";
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    displayLayout.Override.SummaryValueAppearance.TextHAlign = (HAlign) 3;
  }

  private void btnAddDebitAcct_Click(object sender, EventArgs e)
  {
    if (!this.VerifyDebit())
      return;
    foreach (UltraGridRow row in ((UltraGridBase) this.gridInvoiceAllocations).Rows)
    {
      if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(row.Cells["AppliedAmount"].Value)) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(row.Cells["AppliedAmount"].Text, "", false) != 0)
        this.AddIssuanceEntry(this.dtGLAccounts.GLAccountShortName, DebitAmount: Conversions.ToDecimal(row.Cells["AppliedAmount"].Value), InvoiceNumber: Conversions.ToInteger(row.Cells["InvoiceNum"].Value), ChargeCode: Conversions.ToInteger(row.Cells["chargeCode"].Value), CompanyLineGuid: row.Cells["companyLineGuid"].Value.ToString(), GLAccountID: this.dtGLAccounts.GLAccountID);
    }
    if (Decimal.Compare(Decimal.Subtract(Conversions.ToDecimal(((TextEditorControlBase) this.txtDebitAmount).Text), this.InvoiceAllocationsTotal()), 0M) != 0)
      this.AddIssuanceEntry(this.dtGLAccounts.GLAccountShortName, DebitAmount: Decimal.Subtract(Conversions.ToDecimal(((TextEditorControlBase) this.txtDebitAmount).Text), this.InvoiceAllocationsTotal()), GLAccountID: this.dtGLAccounts.GLAccountID);
    ((TextEditorControlBase) this.txtDebitAmount).Text = "";
    this.dtGLAccounts.LoadGLAccounts(Conversions.ToInteger(this.cmbOfficeLocation.Value));
    ((TextEditorControlBase) this.txtAccountBalance).Text = "$0.00";
    this.DsGLAccountInvoiceBalance1.InvoiceBalances.Clear();
  }

  private bool VerifyDebit()
  {
    bool flag;
    if (this.dtGLAccounts.GLAccountID == -1)
    {
      int num = (int) MessageBox.Show("You must select a GL offset account to continue!", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      flag = false;
    }
    else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((TextEditorControlBase) this.txtDebitAmount).Text, "", false) == 0)
    {
      int num = (int) MessageBox.Show("You must enter a debit amount to continue!", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      flag = false;
    }
    else if (!Versioned.IsNumeric((object) ((TextEditorControlBase) this.txtDebitAmount).Text))
    {
      int num = (int) MessageBox.Show("Debit amount must be numeric!", "Invalid Entry!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      flag = false;
    }
    else if (Decimal.Compare(Conversions.ToDecimal(((TextEditorControlBase) this.txtDebitAmount).Text), this.InvoiceAllocationsTotal()) < 0)
    {
      int num = (int) MessageBox.Show("The invoice allocations amount can not exceed the debit amount entered.", "Invalid Entry!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      ((TextEditorControlBase) this.txtDebitAmount).Focus();
      flag = false;
    }
    else
      flag = true;
    return flag;
  }

  private bool VerifyDebitsAndCredits()
  {
    Decimal d1;
    try
    {
      foreach (dsIssueCheckEntries.EntriesRow entry in this.DsIssueCheckEntries1.Entries)
      {
        if (!Information.IsDBNull((object) entry._Debit_Amt_))
          d1 = Decimal.Add(d1, entry._Debit_Amt_);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    bool flag;
    if (Decimal.Compare(d1, Conversions.ToDecimal(((TextEditorControlBase) this.txtCheckAmount).Text)) != 0)
    {
      int num = (int) MessageBox.Show("The current debits do not match the credit amount. You must apply the full check amount to offsetting debit accounts to continue.", "Invalid Debits!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      flag = false;
    }
    else
      flag = true;
    return flag;
  }

  private void Post()
  {
    SqlCommand sqlCommand1 = new SqlCommand("spFin_PostCheckIssuance_Header", new SqlConnection(CurrentUser.Instance.ConnectionString));
    try
    {
      SqlCommand sqlCommand2 = sqlCommand1;
      sqlCommand2.CommandType = CommandType.StoredProcedure;
      sqlCommand2.Parameters.AddWithValue("@payeeguid", (object) new Guid(((Control) this.txtPayeeName).Tag.ToString()));
      sqlCommand2.Parameters.AddWithValue("@userguid", (object) CurrentUser.Instance.UserGUID);
      sqlCommand2.Parameters.AddWithValue("@frombankgl", (object) Conversions.ToInteger(this.cmbBankAccounts.Value));
      sqlCommand2.Parameters.AddWithValue("@amount", (object) Conversions.ToDecimal(((TextEditorControlBase) this.txtCheckAmount).Text));
      sqlCommand2.Parameters.AddWithValue("@checkmemo", (object) ((TextEditorControlBase) this.txtCheckMemo).Text);
      sqlCommand2.Parameters.AddWithValue("@checkdate", (object) this.dtpCheckDate.DateTime);
      sqlCommand2.Parameters.AddWithValue("@comments", (object) ((TextEditorControlBase) this.txtPostingComment).Text);
      sqlCommand2.Connection.Open();
      sqlCommand2.Transaction = sqlCommand2.Connection.BeginTransaction();
      int integer = Conversions.ToInteger(sqlCommand2.ExecuteScalar());
      this.DsIssueCheckEntries1.Entries.DefaultView.Sort = "[Debit Amt.] desc";
      DataRow[] dataRowArray = this.DsIssueCheckEntries1.Entries.Select("", "[Debit Amt.] DESC");
      int index = 0;
      while (index < dataRowArray.Length)
      {
        dsIssueCheckEntries.EntriesRow entriesRow = (dsIssueCheckEntries.EntriesRow) dataRowArray[index];
        if (entriesRow.RowState != DataRowState.Deleted || entriesRow.RowState == DataRowState.Detached)
        {
          sqlCommand2.CommandText = "spFin_PostCheckIssuance_Detail";
          sqlCommand2.CommandType = CommandType.StoredProcedure;
          sqlCommand2.Parameters.Clear();
          sqlCommand2.Parameters.AddWithValue("@transactnum", (object) integer);
          sqlCommand2.Parameters.AddWithValue("@glacctid", (object) entriesRow.glacctid);
          sqlCommand2.Parameters.AddWithValue("@payeeguid", (object) new Guid(((Control) this.txtPayeeName).Tag.ToString()));
          if (entriesRow._Debit_Amt_.Equals((object) DBNull.Value) || Information.IsDBNull((object) entriesRow._Debit_Amt_) || Decimal.Compare(entriesRow._Debit_Amt_, 0M) == 0)
            sqlCommand2.Parameters.AddWithValue("@amount", (object) Decimal.Multiply(entriesRow._Credit_Amt_, -1M));
          else
            sqlCommand2.Parameters.AddWithValue("@amount", (object) entriesRow._Debit_Amt_);
          if (!Information.IsDBNull((object) entriesRow.invoicenum) && entriesRow.invoicenum != -1)
          {
            sqlCommand2.Parameters.AddWithValue("@invoiceNum", (object) entriesRow.invoicenum);
            sqlCommand2.Parameters.AddWithValue("@chargeCode", (object) entriesRow.chargecode);
            sqlCommand2.Parameters.AddWithValue("@companyLineGuid", (object) new Guid(entriesRow.companylineguid));
          }
          sqlCommand2.Parameters.AddWithValue("@CostCenterId", (object) int.Parse(this.comboCostCenter.Value.ToString()));
          sqlCommand2.ExecuteNonQuery();
        }
        checked { ++index; }
      }
      sqlCommand2.Parameters.Clear();
      sqlCommand2.CommandText = "SPFIN_CheckTheBooks";
      sqlCommand2.CommandType = CommandType.StoredProcedure;
      if (Conversions.ToInteger(sqlCommand2.ExecuteScalar()) != 0)
      {
        sqlCommand2.Transaction.Rollback();
        sqlCommand1.Connection.Close();
        throw new DistributionsNotInBalanceException();
      }
      sqlCommand2.Transaction.Commit();
      sqlCommand1.Connection.Close();
      CurrentUser.Instance.LogAction($"Issued non-insurance check transaction # {integer}", "Banking Logs");
      int num = (int) MessageBox.Show("Check has been created successfully!", "Check Created Successfully!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    catch (SqlException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      if (sqlCommand1.Transaction != null)
        sqlCommand1.Transaction.Rollback();
      throw;
    }
    finally
    {
      if (sqlCommand1 != null)
      {
        if (sqlCommand1.Transaction != null)
          sqlCommand1.Transaction.Dispose();
        if (sqlCommand1.Connection != null)
        {
          sqlCommand1.Connection.Close();
          sqlCommand1.Connection.Dispose();
        }
        sqlCommand1.Dispose();
      }
    }
  }

  private string CreateConfirmString()
  {
    string Left = string.Empty;
    try
    {
      foreach (dsIssueCheckEntries.EntriesRow entry in this.DsIssueCheckEntries1.Entries)
      {
        if (!Information.IsDBNull((object) entry._Debit_Amt_) && Versioned.IsNumeric((object) entry._Debit_Amt_) && Decimal.Compare(entry._Debit_Amt_, 0M) > 0)
          Left = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "", false) == 0 ? Left + string.Format(entry.Description + " for {0}", (object) Microsoft.VisualBasic.Strings.Format((object) entry._Debit_Amt_, "Currency")) : Left + string.Format($" and {entry.Description} for {{0}}", (object) Microsoft.VisualBasic.Strings.Format((object) entry._Debit_Amt_, "Currency"));
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    return $"Pay {((TextEditorControlBase) this.txtPayeeName).Text}\r\n{Microsoft.VisualBasic.Strings.Format((object) ((TextEditorControlBase) this.txtCheckAmount).Text, "Currency")} from\r\n{this.cmbBankAccounts.Text}\r\noffset by\r\n{Left}.";
  }

  private void btnFinish_Click(object sender, EventArgs e)
  {
    this.Post();
    this.DialogResult = DialogResult.OK;
    this.Close();
  }

  private void dtGLAccounts_AfterSelect(object sender, ExtendedDropTree_EventArgs e)
  {
    if (this.dtGLAccounts.GLAccountID == 0 || this.dtGLAccounts.GLAccountID == -1)
      return;
    ((TextEditorControlBase) this.txtAccountBalance).Text = Microsoft.VisualBasic.Strings.Format((object) Decimal.Multiply(MGASystems.IMS.Accounting.Utilities.Tools.GetGLAccountBalance(this.dtGLAccounts.GLAccountID), -1M), "Currency");
    if (this.dtGLAccounts.GLAccountID == -1 || this.dtGLAccounts.GLAccountID == 0)
      return;
    this.DsGLAccountInvoiceBalance1.Clear();
    this.daGetGLInvoiceBalance.SelectCommand.Parameters["@glAcctId"].Value = (object) this.dtGLAccounts.GLAccountID;
    this.daGetGLInvoiceBalance.Fill((DataTable) this.DsGLAccountInvoiceBalance1.InvoiceBalances);
  }

  private void LoadCostCenters()
  {
    DataSet dataSet = new DataSet();
    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(new SqlCommand("spFin_GetCostCentersList", new SqlConnection(CurrentUser.Instance.ConnectionString)));
    try
    {
      sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
      sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@glcompanyid", (object) int.Parse(this.cmbOfficeLocation.Value.ToString()));
      sqlDataAdapter.Fill(dataSet);
      ((UltraGridBase) this.comboCostCenter).DataSource = (object) dataSet;
      ((UltraDropDownBase) this.comboCostCenter).DisplayMember = "Name";
      ((UltraDropDownBase) this.comboCostCenter).ValueMember = "CostCenterID";
    }
    finally
    {
      if (sqlDataAdapter.SelectCommand.Connection.State != ConnectionState.Closed)
        sqlDataAdapter.SelectCommand.Connection.Close();
      sqlDataAdapter.SelectCommand.Connection.Dispose();
      sqlDataAdapter.SelectCommand.Dispose();
      sqlDataAdapter.Dispose();
    }
  }

  private void UpdateGridWithNewValues(int newBankAccountId, int previousBankId)
  {
    DataRow[] dataRowArray = this.DsIssueCheckEntries1.Entries.Select($"glacctid ='{previousBankId.ToString()}'");
    int index = 0;
    while (index < dataRowArray.Length)
    {
      dsIssueCheckEntries.EntriesRow entriesRow = (dsIssueCheckEntries.EntriesRow) dataRowArray[index];
      if (entriesRow.RowState != DataRowState.Deleted || entriesRow.RowState == DataRowState.Detached)
      {
        entriesRow.glacctid = newBankAccountId;
        entriesRow.Description = this.cmbBankAccounts.Text;
        entriesRow._Credit_Amt_ = Conversions.ToDecimal(((TextEditorControlBase) this.txtCheckAmount).Text);
        entriesRow._Debit_Amt_ = 0M;
      }
      checked { ++index; }
    }
  }

  private void frmCreateCheckWizard_Load(object sender, EventArgs e)
  {
    if (SecurityManager.Instance.AssertPermission("{064AAFC5-45F0-4ecc-BA29-7D7002DA85B6}"))
      return;
    MGASystems.IMS.Accounting.Banking.Utility.DenyAccess();
    this.DialogResult = DialogResult.Cancel;
  }
}
