// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Banking.Forms.frmBankTransfer
// Assembly: MgaSystems.IMS.Accounting.Banking, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: ED5B99DC-3DD2-44AB-BA36-49A11A94937D
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Banking.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using MGASystems.Common;
using MGASystems.IMS.Accounting.AccountingDatasets;
using MGASystems.IMS.Accounting.Banking.Services;
using MGASystems.IMS.Accounting.Shared;
using MGASystems.IMS.Security;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
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

[SecureResource("{1A2183F1-8CEF-47b4-97D0-573AF021AD16}", "Bank Transfer Wizard", "Determines whether or not a user can run the Bank Transfer Wizard.", "Accounting")]
public class frmBankTransfer : Form
{
  private IContainer components;
  private int _sourceBankGLAccountID;
  private int _destinationBankGLAccountID;
  private DateTime _transactionDate;
  private Decimal _transactionAmount;
  private string _transactionComment;
  private WizardStep _currentStep;

  public frmBankTransfer()
  {
    this.Load += new EventHandler(this.frmBankTransfer_Load);
    this.Resize += new EventHandler(this.frmBankTransfer_Resize);
    this._currentStep = WizardStep.Source;
    this.InitializeComponent();
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [field: AccessedThroughProperty("dsSourceBankAccounts")]
  internal virtual dsBankAccounts dsSourceBankAccounts { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dsDestinationBankAccounts")]
  internal virtual dsBankAccounts dsDestinationBankAccounts { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dsSourceOfficeLocations")]
  internal virtual dsOfficeLocations dsSourceOfficeLocations { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dsDestinationOfficeLocations")]
  internal virtual dsOfficeLocations dsDestinationOfficeLocations { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("daGetOfficeLocations")]
  internal virtual SqlDataAdapter daGetOfficeLocations { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlSelectCommand1")]
  internal virtual SqlCommand SqlSelectCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("FormDataConnection")]
  internal virtual SqlConnection FormDataConnection { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("daGetBankAccounts")]
  protected virtual SqlDataAdapter daGetBankAccounts { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlSelectCommand2")]
  protected virtual SqlCommand SqlSelectCommand2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("pnlBottom")]
  internal virtual Panel pnlBottom { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGAButton btnNext
  {
    get => this._btnNext;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnNext_Click);
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

  internal virtual MGAButton btnCancel
  {
    get => this._btnCancel;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnCancel_Click);
      MGAButton btnCancel1 = this._btnCancel;
      if (btnCancel1 != null)
        ((Control) btnCancel1).Click -= eventHandler;
      this._btnCancel = value;
      MGAButton btnCancel2 = this._btnCancel;
      if (btnCancel2 == null)
        return;
      ((Control) btnCancel2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("pnlSide")]
  internal virtual Panel pnlSide { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblSideBar")]
  internal virtual UltraLabel lblSideBar { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("panelTop")]
  internal virtual Panel panelTop { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblLine")]
  internal virtual Label lblLine { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("label1")]
  internal virtual Label label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("pnlSource")]
  internal virtual Panel pnlSource { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label2")]
  internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label3")]
  internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("comboSourceCostCenter")]
  internal virtual MGASimpleComboBox comboSourceCostCenter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label14")]
  internal virtual Label Label14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cmbSourceBankAccount")]
  internal virtual MGASimpleComboBox cmbSourceBankAccount { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label5")]
  internal virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGASimpleComboBox cmbSourceOfficeLocation
  {
    get => this._cmbSourceOfficeLocation;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      RowSelectedEventHandler selectedEventHandler = new RowSelectedEventHandler(this.OfficeLocationSelected);
      MGASimpleComboBox sourceOfficeLocation1 = this._cmbSourceOfficeLocation;
      if (sourceOfficeLocation1 != null)
        sourceOfficeLocation1.RowSelected -= selectedEventHandler;
      this._cmbSourceOfficeLocation = value;
      MGASimpleComboBox sourceOfficeLocation2 = this._cmbSourceOfficeLocation;
      if (sourceOfficeLocation2 == null)
        return;
      sourceOfficeLocation2.RowSelected += selectedEventHandler;
    }
  }

  [field: AccessedThroughProperty("Label4")]
  internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("pnlDestination")]
  internal virtual Panel pnlDestination { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label8")]
  internal virtual Label Label8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label9")]
  internal virtual Label Label9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("comboDestinationCostCenter")]
  internal virtual MGASimpleComboBox comboDestinationCostCenter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label17")]
  internal virtual Label Label17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cmbDestinationBankAccount")]
  internal virtual MGASimpleComboBox cmbDestinationBankAccount { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label6")]
  internal virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGASimpleComboBox cmbDestinationOfficeLocation
  {
    get => this._cmbDestinationOfficeLocation;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      RowSelectedEventHandler selectedEventHandler = new RowSelectedEventHandler(this.OfficeLocationSelected);
      MGASimpleComboBox destinationOfficeLocation1 = this._cmbDestinationOfficeLocation;
      if (destinationOfficeLocation1 != null)
        destinationOfficeLocation1.RowSelected -= selectedEventHandler;
      this._cmbDestinationOfficeLocation = value;
      MGASimpleComboBox destinationOfficeLocation2 = this._cmbDestinationOfficeLocation;
      if (destinationOfficeLocation2 == null)
        return;
      destinationOfficeLocation2.RowSelected += selectedEventHandler;
    }
  }

  [field: AccessedThroughProperty("Label7")]
  internal virtual Label Label7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("pnlConfirmation")]
  internal virtual Panel pnlConfirmation { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label15")]
  internal virtual Label Label15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label16")]
  internal virtual Label Label16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGAButton btnBack
  {
    get => this._btnBack;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnBack_Click);
      MGAButton btnBack1 = this._btnBack;
      if (btnBack1 != null)
        ((Control) btnBack1).Click -= eventHandler;
      this._btnBack = value;
      MGAButton btnBack2 = this._btnBack;
      if (btnBack2 == null)
        return;
      ((Control) btnBack2).Click += eventHandler;
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

  [field: AccessedThroughProperty("ultraLabel9")]
  internal virtual UltraLabel ultraLabel9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ultraLabel7")]
  internal virtual UltraLabel ultraLabel7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label13")]
  internal virtual Label Label13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label10")]
  internal virtual Label Label10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label11")]
  internal virtual Label Label11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dateTimeTrasactionDate")]
  internal virtual MGADateTimePicker dateTimeTrasactionDate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGATextBox txtTransferAmount
  {
    get => this._txtTransferAmount;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      CancelEventHandler cancelEventHandler = new CancelEventHandler(this.txtTransferAmount_Validating);
      MGATextBox txtTransferAmount1 = this._txtTransferAmount;
      if (txtTransferAmount1 != null)
        ((Control) txtTransferAmount1).Validating -= cancelEventHandler;
      this._txtTransferAmount = value;
      MGATextBox txtTransferAmount2 = this._txtTransferAmount;
      if (txtTransferAmount2 == null)
        return;
      ((Control) txtTransferAmount2).Validating += cancelEventHandler;
    }
  }

  [field: AccessedThroughProperty("txtComments")]
  internal virtual MGATextBox txtComments { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label12")]
  internal virtual Label Label12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label18")]
  internal virtual Label Label18 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label19")]
  internal virtual Label Label19 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("pnlcontainer")]
  internal virtual Panel pnlcontainer { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("pnlTransactionDetails")]
  internal virtual Panel pnlTransactionDetails { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblTransferFrom")]
  internal virtual Label lblTransferFrom { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblTransactionDate")]
  internal virtual Label lblTransactionDate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblTrasferTo")]
  internal virtual Label lblTrasferTo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblTransferAmount")]
  internal virtual Label lblTransferAmount { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PictureBox3")]
  internal virtual PictureBox PictureBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmBankTransfer));
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
    this.dsSourceBankAccounts = new dsBankAccounts();
    this.dsSourceOfficeLocations = new dsOfficeLocations();
    this.dsDestinationBankAccounts = new dsBankAccounts();
    this.dsDestinationOfficeLocations = new dsOfficeLocations();
    this.daGetOfficeLocations = new SqlDataAdapter();
    this.SqlSelectCommand1 = new SqlCommand();
    this.FormDataConnection = new SqlConnection();
    this.daGetBankAccounts = new SqlDataAdapter();
    this.SqlSelectCommand2 = new SqlCommand();
    this.pnlcontainer = new Panel();
    this.pnlConfirmation = new Panel();
    this.lblTransferFrom = new Label();
    this.lblTransactionDate = new Label();
    this.lblTrasferTo = new Label();
    this.lblTransferAmount = new Label();
    this.Label15 = new Label();
    this.Label16 = new Label();
    this.pnlSide = new Panel();
    this.ultraLabel7 = new UltraLabel();
    this.ultraLabel9 = new UltraLabel();
    this.lblSideBar = new UltraLabel();
    this.pnlBottom = new Panel();
    this.btnFinish = new MGAButton();
    this.btnBack = new MGAButton();
    this.btnNext = new MGAButton();
    this.btnCancel = new MGAButton();
    this.panelTop = new Panel();
    this.PictureBox3 = new PictureBox();
    this.lblLine = new Label();
    this.label1 = new Label();
    this.pnlSource = new Panel();
    this.comboSourceCostCenter = new MGASimpleComboBox();
    this.Label14 = new Label();
    this.cmbSourceBankAccount = new MGASimpleComboBox();
    this.Label5 = new Label();
    this.cmbSourceOfficeLocation = new MGASimpleComboBox();
    this.Label4 = new Label();
    this.Label2 = new Label();
    this.Label3 = new Label();
    this.pnlDestination = new Panel();
    this.Label8 = new Label();
    this.Label9 = new Label();
    this.comboDestinationCostCenter = new MGASimpleComboBox();
    this.Label17 = new Label();
    this.cmbDestinationBankAccount = new MGASimpleComboBox();
    this.Label6 = new Label();
    this.cmbDestinationOfficeLocation = new MGASimpleComboBox();
    this.Label7 = new Label();
    this.pnlTransactionDetails = new Panel();
    this.dateTimeTrasactionDate = new MGADateTimePicker();
    this.Label19 = new Label();
    this.Label12 = new Label();
    this.Label18 = new Label();
    this.txtComments = new MGATextBox();
    this.txtTransferAmount = new MGATextBox();
    this.Label13 = new Label();
    this.Label10 = new Label();
    this.Label11 = new Label();
    this.dsSourceBankAccounts.BeginInit();
    this.dsSourceOfficeLocations.BeginInit();
    this.dsDestinationBankAccounts.BeginInit();
    this.dsDestinationOfficeLocations.BeginInit();
    this.pnlcontainer.SuspendLayout();
    this.pnlConfirmation.SuspendLayout();
    this.pnlSide.SuspendLayout();
    this.pnlBottom.SuspendLayout();
    ((ISupportInitialize) this.btnFinish).BeginInit();
    ((ISupportInitialize) this.btnBack).BeginInit();
    ((ISupportInitialize) this.btnNext).BeginInit();
    ((ISupportInitialize) this.btnCancel).BeginInit();
    this.panelTop.SuspendLayout();
    ((ISupportInitialize) this.PictureBox3).BeginInit();
    this.pnlSource.SuspendLayout();
    ((ISupportInitialize) this.comboSourceCostCenter).BeginInit();
    ((ISupportInitialize) this.cmbSourceBankAccount).BeginInit();
    ((ISupportInitialize) this.cmbSourceOfficeLocation).BeginInit();
    this.pnlDestination.SuspendLayout();
    ((ISupportInitialize) this.comboDestinationCostCenter).BeginInit();
    ((ISupportInitialize) this.cmbDestinationBankAccount).BeginInit();
    ((ISupportInitialize) this.cmbDestinationOfficeLocation).BeginInit();
    this.pnlTransactionDetails.SuspendLayout();
    ((ISupportInitialize) this.dateTimeTrasactionDate).BeginInit();
    ((ISupportInitialize) this.txtComments).BeginInit();
    ((ISupportInitialize) this.txtTransferAmount).BeginInit();
    this.SuspendLayout();
    this.dsSourceBankAccounts.DataSetName = "dsBankAccounts";
    this.dsSourceBankAccounts.Locale = new CultureInfo("en-US");
    this.dsSourceOfficeLocations.DataSetName = "dsOfficeLocations";
    this.dsSourceOfficeLocations.Locale = new CultureInfo("en-US");
    this.dsDestinationBankAccounts.DataSetName = "dsBankAccounts";
    this.dsDestinationBankAccounts.Locale = new CultureInfo("en-US");
    this.dsDestinationOfficeLocations.DataSetName = "dsOfficeLocations";
    this.dsDestinationOfficeLocations.Locale = new CultureInfo("en-US");
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
    this.pnlcontainer.Controls.Add((Control) this.pnlConfirmation);
    this.pnlcontainer.Controls.Add((Control) this.pnlSide);
    this.pnlcontainer.Controls.Add((Control) this.pnlBottom);
    this.pnlcontainer.Controls.Add((Control) this.panelTop);
    this.pnlcontainer.Controls.Add((Control) this.pnlSource);
    this.pnlcontainer.Controls.Add((Control) this.pnlDestination);
    this.pnlcontainer.Controls.Add((Control) this.pnlTransactionDetails);
    this.pnlcontainer.Dock = DockStyle.Fill;
    this.pnlcontainer.Location = new Point(0, 0);
    this.pnlcontainer.Name = "pnlcontainer";
    this.pnlcontainer.Size = new Size(626, 336);
    this.pnlcontainer.TabIndex = 0;
    this.pnlConfirmation.AutoScroll = true;
    this.pnlConfirmation.Controls.Add((Control) this.lblTransferFrom);
    this.pnlConfirmation.Controls.Add((Control) this.lblTransactionDate);
    this.pnlConfirmation.Controls.Add((Control) this.lblTrasferTo);
    this.pnlConfirmation.Controls.Add((Control) this.lblTransferAmount);
    this.pnlConfirmation.Controls.Add((Control) this.Label15);
    this.pnlConfirmation.Controls.Add((Control) this.Label16);
    this.pnlConfirmation.Dock = DockStyle.Fill;
    this.pnlConfirmation.Location = new Point(232, 80 /*0x50*/);
    this.pnlConfirmation.Name = "pnlConfirmation";
    this.pnlConfirmation.Size = new Size(394, 216);
    this.pnlConfirmation.TabIndex = 224 /*0xE0*/;
    this.lblTransferFrom.ForeColor = Color.Black;
    this.lblTransferFrom.Location = new Point(-2, 109);
    this.lblTransferFrom.Name = "lblTransferFrom";
    this.lblTransferFrom.Size = new Size(396, 23);
    this.lblTransferFrom.TabIndex = 5;
    this.lblTransferFrom.Text = "From [Bank Account Name] - [Bank Account Number]";
    this.lblTransferFrom.TextAlign = ContentAlignment.MiddleCenter;
    this.lblTransactionDate.ForeColor = Color.Black;
    this.lblTransactionDate.Location = new Point(-2, 157);
    this.lblTransactionDate.Name = "lblTransactionDate";
    this.lblTransactionDate.Size = new Size(396, 23);
    this.lblTransactionDate.TabIndex = 7;
    this.lblTransactionDate.Text = "On [Transaction Date]";
    this.lblTransactionDate.TextAlign = ContentAlignment.MiddleCenter;
    this.lblTrasferTo.ForeColor = Color.Black;
    this.lblTrasferTo.Location = new Point(-2, 134);
    this.lblTrasferTo.Name = "lblTrasferTo";
    this.lblTrasferTo.Size = new Size(396, 23);
    this.lblTrasferTo.TabIndex = 6;
    this.lblTrasferTo.Text = "To [Bank Account Name] - [Bank Account Number]";
    this.lblTrasferTo.TextAlign = ContentAlignment.MiddleCenter;
    this.lblTransferAmount.ForeColor = Color.Black;
    this.lblTransferAmount.Location = new Point(-2, 86);
    this.lblTransferAmount.Name = "lblTransferAmount";
    this.lblTransferAmount.Size = new Size(396, 23);
    this.lblTransferAmount.TabIndex = 4;
    this.lblTransferAmount.Text = "Transfer $0.00";
    this.lblTransferAmount.TextAlign = ContentAlignment.MiddleCenter;
    this.Label15.ForeColor = Color.Black;
    this.Label15.Location = new Point(16 /*0x10*/, 32 /*0x20*/);
    this.Label15.Name = "Label15";
    this.Label15.Size = new Size(378, 32 /*0x20*/);
    this.Label15.TabIndex = 3;
    this.Label15.Text = "Please review the transfer infomation below.  If this information is correct, click the 'Finish' button to complete the bank transfer.";
    this.Label16.AutoSize = true;
    this.Label16.Font = new Font("Tahoma", 14f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label16.ForeColor = Color.Black;
    this.Label16.Location = new Point(8, 8);
    this.Label16.Name = "Label16";
    this.Label16.Size = new Size(220, 23);
    this.Label16.TabIndex = 2;
    this.Label16.Text = "Transfer Confirmation";
    this.pnlSide.BackColor = Color.LightSlateGray;
    this.pnlSide.Controls.Add((Control) this.ultraLabel7);
    this.pnlSide.Controls.Add((Control) this.ultraLabel9);
    this.pnlSide.Controls.Add((Control) this.lblSideBar);
    this.pnlSide.Dock = DockStyle.Left;
    this.pnlSide.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.pnlSide.Location = new Point(0, 80 /*0x50*/);
    this.pnlSide.Name = "pnlSide";
    this.pnlSide.Size = new Size(232, 216);
    this.pnlSide.TabIndex = 220;
    appearance1.BackColor = Color.White;
    appearance1.BackColor2 = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance1.BackGradientAlignment = (GradientAlignment) 3;
    appearance1.BackGradientStyle = (GradientStyle) 2;
    appearance1.ForeColor = Color.DimGray;
    ((ControlBase) this.ultraLabel7).Appearance = (AppearanceBase) appearance1;
    ((ControlBase) this.ultraLabel7).BackColorInternal = Color.White;
    ((Control) this.ultraLabel7).Font = new Font("Arial", 8f);
    ((ControlBase) this.ultraLabel7).ForeColor = Color.Black;
    ((Control) this.ultraLabel7).Location = new Point(8, 24);
    ((Control) this.ultraLabel7).Name = "ultraLabel7";
    ((Control) this.ultraLabel7).Size = new Size(216, 152);
    ((Control) this.ultraLabel7).TabIndex = 209;
    ((ControlBase) this.ultraLabel7).Text = componentResourceManager.GetString("ultraLabel7.Text");
    appearance2.BackColor = Color.White;
    appearance2.BackColor2 = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance2.BackGradientAlignment = (GradientAlignment) 3;
    appearance2.BackGradientStyle = (GradientStyle) 2;
    appearance2.ForeColor = Color.DimGray;
    ((ControlBase) this.ultraLabel9).Appearance = (AppearanceBase) appearance2;
    ((AutoSizeControlBase) this.ultraLabel9).AutoSize = true;
    ((ControlBase) this.ultraLabel9).BackColorInternal = Color.White;
    ((Control) this.ultraLabel9).Font = new Font("Tahoma", 8f, FontStyle.Bold);
    ((ControlBase) this.ultraLabel9).ForeColor = Color.Black;
    ((Control) this.ultraLabel9).Location = new Point(8, 8);
    ((Control) this.ultraLabel9).Name = "ultraLabel9";
    ((Control) this.ultraLabel9).Size = new Size(123, 15);
    ((Control) this.ultraLabel9).TabIndex = 208 /*0xD0*/;
    ((ControlBase) this.ultraLabel9).Text = "Bank Transfer Wizard";
    appearance3.BackColor = Color.White;
    appearance3.BackColor2 = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance3.BackGradientAlignment = (GradientAlignment) 3;
    appearance3.BackGradientStyle = (GradientStyle) 2;
    ((ControlBase) this.lblSideBar).Appearance = (AppearanceBase) appearance3;
    ((ControlBase) this.lblSideBar).BackColorInternal = Color.White;
    this.lblSideBar.BorderStyleOuter = (UIElementBorderStyle) 1;
    ((Control) this.lblSideBar).Dock = DockStyle.Fill;
    ((Control) this.lblSideBar).Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((ControlBase) this.lblSideBar).ForeColor = Color.Black;
    ((Control) this.lblSideBar).Location = new Point(0, 0);
    ((Control) this.lblSideBar).Name = "lblSideBar";
    ((Control) this.lblSideBar).Size = new Size(232, 216);
    ((Control) this.lblSideBar).TabIndex = 183;
    this.pnlBottom.BackColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.pnlBottom.Controls.Add((Control) this.btnFinish);
    this.pnlBottom.Controls.Add((Control) this.btnBack);
    this.pnlBottom.Controls.Add((Control) this.btnNext);
    this.pnlBottom.Controls.Add((Control) this.btnCancel);
    this.pnlBottom.Dock = DockStyle.Bottom;
    this.pnlBottom.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.pnlBottom.Location = new Point(0, 296);
    this.pnlBottom.Name = "pnlBottom";
    this.pnlBottom.Size = new Size(626, 40);
    this.pnlBottom.TabIndex = 5;
    ((Control) this.btnFinish).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    appearance4.BackColor = Color.Gainsboro;
    appearance4.BackColor2 = Color.White;
    appearance4.BackGradientStyle = (GradientStyle) 2;
    appearance4.BorderColor = Color.Gray;
    ((ControlBase) this.btnFinish).Appearance = (AppearanceBase) appearance4;
    ((ControlBase) this.btnFinish).BackColorInternal = Color.White;
    ((Control) this.btnFinish).Enabled = false;
    ((Control) this.btnFinish).Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.btnFinish).Location = new Point(456, 8);
    ((Control) this.btnFinish).Name = "btnFinish";
    ((Control) this.btnFinish).Size = new Size(80 /*0x50*/, 24);
    ((Control) this.btnFinish).TabIndex = 3;
    ((ControlBase) this.btnFinish).Text = "&Finish";
    this.btnFinish.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.btnBack).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance5.BackColor = Color.Gainsboro;
    appearance5.BackColor2 = Color.White;
    appearance5.BackGradientStyle = (GradientStyle) 2;
    appearance5.BorderColor = Color.Gray;
    ((ControlBase) this.btnBack).Appearance = (AppearanceBase) appearance5;
    ((Control) this.btnBack).Enabled = false;
    ((Control) this.btnBack).Location = new Point(272, 8);
    ((Control) this.btnBack).Name = "btnBack";
    ((Control) this.btnBack).Size = new Size(80 /*0x50*/, 24);
    ((Control) this.btnBack).TabIndex = 2;
    ((ControlBase) this.btnBack).Text = "< &Back";
    this.btnBack.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.btnNext).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    appearance6.BackColor = Color.White;
    appearance6.BackColor2 = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    appearance6.BackGradientStyle = (GradientStyle) 2;
    appearance6.BorderColor = Color.DimGray;
    ((ControlBase) this.btnNext).Appearance = (AppearanceBase) appearance6;
    ((ControlBase) this.btnNext).BackColorInternal = Color.White;
    ((Control) this.btnNext).Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.btnNext).Location = new Point(352, 8);
    ((Control) this.btnNext).Name = "btnNext";
    ((Control) this.btnNext).Size = new Size(80 /*0x50*/, 24);
    ((Control) this.btnNext).TabIndex = 0;
    ((ControlBase) this.btnNext).Text = "&Next >";
    this.btnNext.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.btnCancel).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    appearance7.BackColor = Color.Gainsboro;
    appearance7.BackColor2 = Color.White;
    appearance7.BackGradientStyle = (GradientStyle) 2;
    appearance7.BorderColor = Color.Gray;
    ((ControlBase) this.btnCancel).Appearance = (AppearanceBase) appearance7;
    ((ControlBase) this.btnCancel).BackColorInternal = Color.White;
    ((UltraButtonBase) this.btnCancel).DialogResult = DialogResult.Cancel;
    ((Control) this.btnCancel).Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.btnCancel).Location = new Point(536, 8);
    ((Control) this.btnCancel).Name = "btnCancel";
    ((Control) this.btnCancel).Size = new Size(80 /*0x50*/, 24);
    ((Control) this.btnCancel).TabIndex = 1;
    ((ControlBase) this.btnCancel).Text = "&Cancel";
    this.btnCancel.UseOSThemes = (DefaultableBoolean) 2;
    this.panelTop.BackColor = Color.White;
    this.panelTop.Controls.Add((Control) this.PictureBox3);
    this.panelTop.Controls.Add((Control) this.lblLine);
    this.panelTop.Controls.Add((Control) this.label1);
    this.panelTop.Dock = DockStyle.Top;
    this.panelTop.Location = new Point(0, 0);
    this.panelTop.Name = "panelTop";
    this.panelTop.Size = new Size(626, 80 /*0x50*/);
    this.panelTop.TabIndex = 221;
    this.PictureBox3.Image = (Image) componentResourceManager.GetObject("PictureBox3.Image");
    this.PictureBox3.Location = new Point(8, 8);
    this.PictureBox3.Name = "PictureBox3";
    this.PictureBox3.Size = new Size(64 /*0x40*/, 64 /*0x40*/);
    this.PictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
    this.PictureBox3.TabIndex = 2;
    this.PictureBox3.TabStop = false;
    this.lblLine.BackColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.lblLine.Dock = DockStyle.Bottom;
    this.lblLine.Location = new Point(0, 79);
    this.lblLine.Name = "lblLine";
    this.lblLine.Size = new Size(626, 1);
    this.lblLine.TabIndex = 1;
    this.label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.label1.AutoSize = true;
    this.label1.Font = new Font("Arial", 14f, FontStyle.Bold);
    this.label1.ForeColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.label1.Location = new Point(416, 48 /*0x30*/);
    this.label1.Name = "label1";
    this.label1.Size = new Size(210, 22);
    this.label1.TabIndex = 0;
    this.label1.Text = "Bank Transfer Wizard";
    this.pnlSource.Controls.Add((Control) this.comboSourceCostCenter);
    this.pnlSource.Controls.Add((Control) this.Label14);
    this.pnlSource.Controls.Add((Control) this.cmbSourceBankAccount);
    this.pnlSource.Controls.Add((Control) this.Label5);
    this.pnlSource.Controls.Add((Control) this.cmbSourceOfficeLocation);
    this.pnlSource.Controls.Add((Control) this.Label4);
    this.pnlSource.Controls.Add((Control) this.Label2);
    this.pnlSource.Controls.Add((Control) this.Label3);
    this.pnlSource.Dock = DockStyle.Fill;
    this.pnlSource.Location = new Point(0, 0);
    this.pnlSource.Name = "pnlSource";
    this.pnlSource.Size = new Size(626, 336);
    this.pnlSource.TabIndex = 222;
    this.comboSourceCostCenter.BorderStyle = (UIElementBorderStyle) 4;
    this.comboSourceCostCenter.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboSourceCostCenter).Location = new Point(32 /*0x20*/, 160 /*0xA0*/);
    this.comboSourceCostCenter.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboSourceCostCenter).Name = "comboSourceCostCenter";
    ((Control) this.comboSourceCostCenter).Size = new Size(224 /*0xE0*/, 21);
    ((Control) this.comboSourceCostCenter).TabIndex = 189;
    ((UltraControlBase) this.comboSourceCostCenter).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboSourceCostCenter).UseOsThemes = (DefaultableBoolean) 2;
    this.Label14.AutoSize = true;
    this.Label14.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label14.ForeColor = Color.Black;
    this.Label14.Location = new Point(24, 144 /*0x90*/);
    this.Label14.Name = "Label14";
    this.Label14.Size = new Size(65, 13);
    this.Label14.TabIndex = 190;
    this.Label14.Text = "Cost Center";
    this.cmbSourceBankAccount.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.cmbSourceBankAccount).DataMember = "spFin_GetBankAccounts";
    ((UltraGridBase) this.cmbSourceBankAccount).DataSource = (object) this.dsSourceBankAccounts;
    ((UltraDropDownBase) this.cmbSourceBankAccount).DisplayMember = "BANKNAME";
    this.cmbSourceBankAccount.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cmbSourceBankAccount).DropDownWidth = 350;
    ((Control) this.cmbSourceBankAccount).Location = new Point(32 /*0x20*/, 120);
    this.cmbSourceBankAccount.MGAStyle = MGAStyles.Blue;
    ((Control) this.cmbSourceBankAccount).Name = "cmbSourceBankAccount";
    ((Control) this.cmbSourceBankAccount).Size = new Size(224 /*0xE0*/, 21);
    ((Control) this.cmbSourceBankAccount).TabIndex = 188;
    ((UltraControlBase) this.cmbSourceBankAccount).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cmbSourceBankAccount).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cmbSourceBankAccount).ValueMember = "GLACCTID";
    this.Label5.AutoSize = true;
    this.Label5.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label5.ForeColor = Color.Black;
    this.Label5.Location = new Point(24, 104);
    this.Label5.Name = "Label5";
    this.Label5.Size = new Size(108, 13);
    this.Label5.TabIndex = 187;
    this.Label5.Text = "Source Bank Account";
    this.cmbSourceOfficeLocation.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.cmbSourceOfficeLocation).DataMember = "spFin_GetOfficeLocations";
    ((UltraDropDownBase) this.cmbSourceOfficeLocation).DisplayMember = "Office Location";
    this.cmbSourceOfficeLocation.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cmbSourceOfficeLocation).Location = new Point(32 /*0x20*/, 80 /*0x50*/);
    this.cmbSourceOfficeLocation.MGAStyle = MGAStyles.Blue;
    ((Control) this.cmbSourceOfficeLocation).Name = "cmbSourceOfficeLocation";
    ((Control) this.cmbSourceOfficeLocation).Size = new Size(224 /*0xE0*/, 21);
    ((Control) this.cmbSourceOfficeLocation).TabIndex = 186;
    ((UltraControlBase) this.cmbSourceOfficeLocation).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cmbSourceOfficeLocation).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cmbSourceOfficeLocation).ValueMember = "ID";
    this.Label4.AutoSize = true;
    this.Label4.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label4.ForeColor = Color.Black;
    this.Label4.Location = new Point(24, 64 /*0x40*/);
    this.Label4.Name = "Label4";
    this.Label4.Size = new Size(157, 13);
    this.Label4.TabIndex = 185;
    this.Label4.Text = "Source Account Office Location";
    this.Label2.AutoSize = true;
    this.Label2.BackColor = Color.White;
    this.Label2.Font = new Font("Tahoma", 14f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label2.ForeColor = Color.Black;
    this.Label2.Location = new Point(8, 8);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(158, 23);
    this.Label2.TabIndex = 184;
    this.Label2.Text = "Source Account";
    this.Label3.AutoSize = true;
    this.Label3.BackColor = Color.White;
    this.Label3.ForeColor = Color.Black;
    this.Label3.Location = new Point(16 /*0x10*/, 32 /*0x20*/);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(339, 13);
    this.Label3.TabIndex = 184;
    this.Label3.Text = "Please specify the bank account you wish to tranfers the funds from.";
    this.pnlDestination.Controls.Add((Control) this.Label8);
    this.pnlDestination.Controls.Add((Control) this.Label9);
    this.pnlDestination.Controls.Add((Control) this.comboDestinationCostCenter);
    this.pnlDestination.Controls.Add((Control) this.Label17);
    this.pnlDestination.Controls.Add((Control) this.cmbDestinationBankAccount);
    this.pnlDestination.Controls.Add((Control) this.Label6);
    this.pnlDestination.Controls.Add((Control) this.cmbDestinationOfficeLocation);
    this.pnlDestination.Controls.Add((Control) this.Label7);
    this.pnlDestination.Dock = DockStyle.Fill;
    this.pnlDestination.Location = new Point(0, 0);
    this.pnlDestination.Name = "pnlDestination";
    this.pnlDestination.Size = new Size(626, 336);
    this.pnlDestination.TabIndex = 223;
    this.Label8.AutoSize = true;
    this.Label8.BackColor = Color.White;
    this.Label8.ForeColor = Color.Black;
    this.Label8.Location = new Point(16 /*0x10*/, 32 /*0x20*/);
    this.Label8.Name = "Label8";
    this.Label8.Size = new Size(338, 13);
    this.Label8.TabIndex = 16 /*0x10*/;
    this.Label8.Text = "Please specify the bank account you want to tranfers the funds into.";
    this.Label9.AutoSize = true;
    this.Label9.BackColor = Color.White;
    this.Label9.Font = new Font("Tahoma", 14f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label9.ForeColor = Color.Black;
    this.Label9.Location = new Point(8, 8);
    this.Label9.Name = "Label9";
    this.Label9.Size = new Size(203, 23);
    this.Label9.TabIndex = 15;
    this.Label9.Text = "Destination Account";
    this.comboDestinationCostCenter.BorderStyle = (UIElementBorderStyle) 4;
    this.comboDestinationCostCenter.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboDestinationCostCenter).Location = new Point(24, 160 /*0xA0*/);
    this.comboDestinationCostCenter.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboDestinationCostCenter).Name = "comboDestinationCostCenter";
    ((Control) this.comboDestinationCostCenter).Size = new Size(224 /*0xE0*/, 21);
    ((Control) this.comboDestinationCostCenter).TabIndex = 13;
    ((UltraControlBase) this.comboDestinationCostCenter).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboDestinationCostCenter).UseOsThemes = (DefaultableBoolean) 2;
    this.Label17.AutoSize = true;
    this.Label17.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label17.ForeColor = Color.Black;
    this.Label17.Location = new Point(16 /*0x10*/, 144 /*0x90*/);
    this.Label17.Name = "Label17";
    this.Label17.Size = new Size(65, 13);
    this.Label17.TabIndex = 14;
    this.Label17.Text = "Cost Center";
    this.cmbDestinationBankAccount.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.cmbDestinationBankAccount).DataMember = "spFin_GetBankAccounts";
    ((UltraGridBase) this.cmbDestinationBankAccount).DataSource = (object) this.dsDestinationBankAccounts;
    ((UltraDropDownBase) this.cmbDestinationBankAccount).DisplayMember = "BANKNAME";
    this.cmbDestinationBankAccount.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cmbDestinationBankAccount).DropDownWidth = 350;
    ((Control) this.cmbDestinationBankAccount).Location = new Point(24, 120);
    this.cmbDestinationBankAccount.MGAStyle = MGAStyles.Blue;
    ((Control) this.cmbDestinationBankAccount).Name = "cmbDestinationBankAccount";
    ((Control) this.cmbDestinationBankAccount).Size = new Size(224 /*0xE0*/, 21);
    ((Control) this.cmbDestinationBankAccount).TabIndex = 12;
    ((UltraControlBase) this.cmbDestinationBankAccount).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cmbDestinationBankAccount).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cmbDestinationBankAccount).ValueMember = "GLACCTID";
    this.Label6.AutoSize = true;
    this.Label6.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label6.ForeColor = Color.Black;
    this.Label6.Location = new Point(16 /*0x10*/, 104);
    this.Label6.Name = "Label6";
    this.Label6.Size = new Size(129, 13);
    this.Label6.TabIndex = 11;
    this.Label6.Text = "Destination Bank Account";
    this.cmbDestinationOfficeLocation.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.cmbDestinationOfficeLocation).DataMember = "spFin_GetOfficeLocations";
    ((UltraDropDownBase) this.cmbDestinationOfficeLocation).DisplayMember = "Office Location";
    this.cmbDestinationOfficeLocation.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cmbDestinationOfficeLocation).Location = new Point(24, 80 /*0x50*/);
    this.cmbDestinationOfficeLocation.MGAStyle = MGAStyles.Blue;
    ((Control) this.cmbDestinationOfficeLocation).Name = "cmbDestinationOfficeLocation";
    ((Control) this.cmbDestinationOfficeLocation).Size = new Size(224 /*0xE0*/, 21);
    ((Control) this.cmbDestinationOfficeLocation).TabIndex = 10;
    ((UltraControlBase) this.cmbDestinationOfficeLocation).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cmbDestinationOfficeLocation).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cmbDestinationOfficeLocation).ValueMember = "ID";
    this.Label7.AutoSize = true;
    this.Label7.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label7.ForeColor = Color.Black;
    this.Label7.Location = new Point(16 /*0x10*/, 64 /*0x40*/);
    this.Label7.Name = "Label7";
    this.Label7.Size = new Size(178, 13);
    this.Label7.TabIndex = 9;
    this.Label7.Text = "Destination Account Office Location";
    this.pnlTransactionDetails.Controls.Add((Control) this.dateTimeTrasactionDate);
    this.pnlTransactionDetails.Controls.Add((Control) this.Label19);
    this.pnlTransactionDetails.Controls.Add((Control) this.Label12);
    this.pnlTransactionDetails.Controls.Add((Control) this.Label18);
    this.pnlTransactionDetails.Controls.Add((Control) this.txtComments);
    this.pnlTransactionDetails.Controls.Add((Control) this.txtTransferAmount);
    this.pnlTransactionDetails.Controls.Add((Control) this.Label13);
    this.pnlTransactionDetails.Controls.Add((Control) this.Label10);
    this.pnlTransactionDetails.Controls.Add((Control) this.Label11);
    this.pnlTransactionDetails.Dock = DockStyle.Fill;
    this.pnlTransactionDetails.Location = new Point(0, 0);
    this.pnlTransactionDetails.Name = "pnlTransactionDetails";
    this.pnlTransactionDetails.Size = new Size(626, 336);
    this.pnlTransactionDetails.TabIndex = 225;
    appearance8.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dateTimeTrasactionDate.Appearance = (AppearanceBase) appearance8;
    appearance9.AlphaLevel = (short) 14;
    appearance9.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance9.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance9.BackColorAlpha = (Alpha) 2;
    appearance9.BackGradientAlignment = (GradientAlignment) 4;
    appearance9.BackGradientStyle = (GradientStyle) 5;
    appearance9.BorderAlpha = (Alpha) 1;
    appearance9.BorderColor = Color.FromArgb(78, 122, 171);
    appearance9.ForeColor = Color.FromArgb(49, 85, 153);
    appearance9.ForegroundAlpha = (Alpha) 2;
    this.dateTimeTrasactionDate.ButtonAppearance = (AppearanceBase) appearance9;
    ((Control) this.dateTimeTrasactionDate).Location = new Point(112 /*0x70*/, 80 /*0x50*/);
    this.dateTimeTrasactionDate.MGAStyle = MGAStyles.Blue;
    ((Control) this.dateTimeTrasactionDate).Name = "dateTimeTrasactionDate";
    ((Control) this.dateTimeTrasactionDate).Size = new Size(176 /*0xB0*/, 20);
    ((Control) this.dateTimeTrasactionDate).TabIndex = 12;
    ((UltraControlBase) this.dateTimeTrasactionDate).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dateTimeTrasactionDate).UseOsThemes = (DefaultableBoolean) 2;
    this.Label19.AutoSize = true;
    this.Label19.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label19.ForeColor = Color.Black;
    this.Label19.Location = new Point(8, 80 /*0x50*/);
    this.Label19.Name = "Label19";
    this.Label19.Size = new Size(93, 13);
    this.Label19.TabIndex = 17;
    this.Label19.Text = "Transaction Date:";
    this.Label12.ForeColor = Color.Black;
    this.Label12.Location = new Point(8, 40);
    this.Label12.Name = "Label12";
    this.Label12.Size = new Size(432, 32 /*0x20*/);
    this.Label12.TabIndex = 16 /*0x10*/;
    this.Label12.Text = "Please specify the amount of money you would like to transfer and the on which the transaction should be posted.";
    this.Label18.AutoSize = true;
    this.Label18.Font = new Font("Tahoma", 14f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label18.ForeColor = Color.Black;
    this.Label18.Location = new Point(8, 8);
    this.Label18.Name = "Label18";
    this.Label18.Size = new Size(355, 23);
    this.Label18.TabIndex = 15;
    this.Label18.Text = "Transfer Amount / Transaction Date";
    appearance10.BackColor = Color.White;
    appearance10.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance10.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtComments).Appearance = (AppearanceBase) appearance10;
    ((TextEditorControlBase) this.txtComments).BackColor = Color.White;
    ((Control) this.txtComments).Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((TextEditorControlBase) this.txtComments).ForeColor = Color.Black;
    ((Control) this.txtComments).Location = new Point(112 /*0x70*/, 136);
    ((TextEditorControlBase) this.txtComments).MaxLength = 2000;
    this.txtComments.MGAStyle = MGAStyles.Blue;
    this.txtComments.Multiline = true;
    ((Control) this.txtComments).Name = "txtComments";
    ((Control) this.txtComments).Size = new Size(264, 72);
    ((Control) this.txtComments).TabIndex = 14;
    ((UltraControlBase) this.txtComments).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtComments).UseOsThemes = (DefaultableBoolean) 2;
    appearance11.BackColor = Color.White;
    appearance11.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance11.ForeColor = Color.Black;
    ((AppearanceBase) appearance11).TextHAlignAsString = "Right";
    ((TextEditorControlBase) this.txtTransferAmount).Appearance = (AppearanceBase) appearance11;
    ((TextEditorControlBase) this.txtTransferAmount).BackColor = Color.White;
    ((Control) this.txtTransferAmount).Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((TextEditorControlBase) this.txtTransferAmount).ForeColor = Color.Black;
    ((Control) this.txtTransferAmount).Location = new Point(112 /*0x70*/, 104);
    ((TextEditorControlBase) this.txtTransferAmount).MaxLength = 50;
    this.txtTransferAmount.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtTransferAmount).Name = "txtTransferAmount";
    ((Control) this.txtTransferAmount).Size = new Size(176 /*0xB0*/, 20);
    ((Control) this.txtTransferAmount).TabIndex = 13;
    ((UltraControlBase) this.txtTransferAmount).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtTransferAmount).UseOsThemes = (DefaultableBoolean) 2;
    this.Label13.AutoSize = true;
    this.Label13.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label13.ForeColor = Color.Black;
    this.Label13.Location = new Point(8, 136);
    this.Label13.Name = "Label13";
    this.Label13.Size = new Size(103, 13);
    this.Label13.TabIndex = 10;
    this.Label13.Text = "Transfer Comment :";
    this.Label10.AutoSize = true;
    this.Label10.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label10.ForeColor = Color.Black;
    this.Label10.Location = new Point(8, 104);
    this.Label10.Name = "Label10";
    this.Label10.Size = new Size(92, 13);
    this.Label10.TabIndex = 8;
    this.Label10.Text = "Transfer Amount:";
    this.Label11.AutoSize = true;
    this.Label11.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label11.ForeColor = Color.Black;
    this.Label11.Location = new Point(176 /*0xB0*/, 60);
    this.Label11.Name = "Label11";
    this.Label11.Size = new Size(93, 13);
    this.Label11.TabIndex = 6;
    this.Label11.Text = "Transaction Date:";
    this.AcceptButton = (IButtonControl) this.btnFinish;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.CancelButton = (IButtonControl) this.btnCancel;
    this.ClientSize = new Size(626, 336);
    this.ControlBox = false;
    this.Controls.Add((Control) this.pnlcontainer);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.Name = nameof (frmBankTransfer);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Bank Transfer";
    this.dsSourceBankAccounts.EndInit();
    this.dsSourceOfficeLocations.EndInit();
    this.dsDestinationBankAccounts.EndInit();
    this.dsDestinationOfficeLocations.EndInit();
    this.pnlcontainer.ResumeLayout(false);
    this.pnlConfirmation.ResumeLayout(false);
    this.pnlConfirmation.PerformLayout();
    this.pnlSide.ResumeLayout(false);
    this.pnlSide.PerformLayout();
    this.pnlBottom.ResumeLayout(false);
    ((ISupportInitialize) this.btnFinish).EndInit();
    ((ISupportInitialize) this.btnBack).EndInit();
    ((ISupportInitialize) this.btnNext).EndInit();
    ((ISupportInitialize) this.btnCancel).EndInit();
    this.panelTop.ResumeLayout(false);
    this.panelTop.PerformLayout();
    ((ISupportInitialize) this.PictureBox3).EndInit();
    this.pnlSource.ResumeLayout(false);
    this.pnlSource.PerformLayout();
    ((ISupportInitialize) this.comboSourceCostCenter).EndInit();
    ((ISupportInitialize) this.cmbSourceBankAccount).EndInit();
    ((ISupportInitialize) this.cmbSourceOfficeLocation).EndInit();
    this.pnlDestination.ResumeLayout(false);
    this.pnlDestination.PerformLayout();
    ((ISupportInitialize) this.comboDestinationCostCenter).EndInit();
    ((ISupportInitialize) this.cmbDestinationBankAccount).EndInit();
    ((ISupportInitialize) this.cmbDestinationOfficeLocation).EndInit();
    this.pnlTransactionDetails.ResumeLayout(false);
    this.pnlTransactionDetails.PerformLayout();
    ((ISupportInitialize) this.dateTimeTrasactionDate).EndInit();
    ((ISupportInitialize) this.txtComments).EndInit();
    ((ISupportInitialize) this.txtTransferAmount).EndInit();
    this.ResumeLayout(false);
  }

  private void CancelTransfer(object sender, EventArgs e)
  {
    if (MessageBox.Show("Cancel bank transfer wizard?", "Cancel Wizard?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
      return;
    this.DialogResult = DialogResult.Cancel;
    this.Close();
  }

  private void SaveTransfer()
  {
    BankingServices.TransferFunds(this._sourceBankGLAccountID, this._destinationBankGLAccountID, this._transactionDate, this._transactionAmount, this._transactionComment, CurrentUser.Instance.UserGUID, int.Parse(this.comboSourceCostCenter.Value.ToString()), int.Parse(this.comboDestinationCostCenter.Value.ToString()));
  }

  private void txtTransferAmount_Validating(object sender, CancelEventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((TextEditorControlBase) this.txtTransferAmount).Text, "", false) == 0)
      return;
    if (!Versioned.IsNumeric((object) ((TextEditorControlBase) this.txtTransferAmount).Text))
    {
      int num = (int) MessageBox.Show("Transfer amount must be numeric!", "Invalid Entry!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      e.Cancel = true;
    }
    else
      ((TextEditorControlBase) this.txtTransferAmount).Text = Microsoft.VisualBasic.Strings.Format((object) ((TextEditorControlBase) this.txtTransferAmount).Text, "Currency");
  }

  private void OfficeLocationSelected(object sender, RowSelectedEventArgs e)
  {
    this.Cursor = Cursors.WaitCursor;
    try
    {
      if (sender == this.cmbSourceOfficeLocation)
      {
        if (((UltraDropDownBase) this.cmbSourceOfficeLocation).SelectedRow == null)
          return;
        this.dsSourceBankAccounts.Clear();
        this.daGetBankAccounts.SelectCommand.Parameters["@glcompanyid"].Value = (object) Conversions.ToInteger(((UltraDropDownBase) this.cmbSourceOfficeLocation).SelectedRow.Cells["ID"].Value);
        this.daGetBankAccounts.Fill((DataTable) this.dsSourceBankAccounts.spFin_GetBankAccounts);
        int GlCompanyId = int.Parse(this.cmbSourceOfficeLocation.Value.ToString());
        MGASimpleComboBox sourceCostCenter = this.comboSourceCostCenter;
        ref MGASimpleComboBox local = ref sourceCostCenter;
        this.LoadCostCenters(GlCompanyId, ref local);
        this.comboSourceCostCenter = sourceCostCenter;
      }
      else
      {
        if (((UltraDropDownBase) this.cmbDestinationOfficeLocation).SelectedRow == null)
          return;
        this.dsDestinationBankAccounts.Clear();
        this.daGetBankAccounts.SelectCommand.Parameters["@glcompanyid"].Value = (object) Conversions.ToInteger(((UltraDropDownBase) this.cmbDestinationOfficeLocation).SelectedRow.Cells["ID"].Value);
        this.daGetBankAccounts.Fill((DataTable) this.dsDestinationBankAccounts.spFin_GetBankAccounts);
        int GlCompanyId = int.Parse(this.cmbDestinationOfficeLocation.Value.ToString());
        MGASimpleComboBox destinationCostCenter = this.comboDestinationCostCenter;
        ref MGASimpleComboBox local = ref destinationCostCenter;
        this.LoadCostCenters(GlCompanyId, ref local);
        this.comboDestinationCostCenter = destinationCostCenter;
      }
    }
    finally
    {
      this.Cursor = Cursors.Default;
    }
  }

  private void SetConfirmationText()
  {
    this.lblTransferAmount.Text = $"Transfer Amount: {Microsoft.VisualBasic.Strings.Format((object) this._transactionAmount, "Currency")}";
    this.lblTransferFrom.Text = $"From: {this.cmbSourceBankAccount.Text} - {BankingServices.GetBankAccountNumber(this._sourceBankGLAccountID)}";
    this.lblTrasferTo.Text = $"To: {this.cmbDestinationBankAccount.Text} - {BankingServices.GetBankAccountNumber(this._destinationBankGLAccountID)}";
    this.lblTransactionDate.Text = $"On: {Microsoft.VisualBasic.Strings.Format((object) this._transactionDate, "Long Date")}";
  }

  private void btnFinish_Click(object sender, EventArgs e)
  {
    if (!this.ValidateValues())
      return;
    this.SaveTransfer();
    this.DialogResult = DialogResult.OK;
    int num = (int) MessageBox.Show("Bank transfer has been completed", "Done", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    this.Close();
  }

  private bool ValidateValues()
  {
    bool flag;
    if (((UltraDropDownBase) this.cmbSourceOfficeLocation).SelectedRow == null)
    {
      int num = (int) MessageBox.Show("You must select a source office location to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      flag = false;
    }
    else if (((UltraDropDownBase) this.comboSourceCostCenter).SelectedRow == null)
    {
      int num = (int) MessageBox.Show("You must select a valid cost center to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      flag = false;
    }
    else if (((UltraDropDownBase) this.cmbSourceBankAccount).SelectedRow == null | int.Parse(this.cmbSourceBankAccount.Value.ToString()) == -1)
    {
      int num = (int) MessageBox.Show("You must select a source bank account to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      flag = false;
    }
    else if (((UltraDropDownBase) this.cmbDestinationOfficeLocation).SelectedRow == null)
    {
      int num = (int) MessageBox.Show("You must select a destination office location to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      flag = false;
    }
    else if (((UltraDropDownBase) this.cmbDestinationBankAccount).SelectedRow == null | int.Parse(this.cmbDestinationBankAccount.Value.ToString()) == -1)
    {
      int num = (int) MessageBox.Show("You must select a destination bank account to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      flag = false;
    }
    else if (((UltraDropDownBase) this.comboDestinationCostCenter).SelectedRow == null)
    {
      int num = (int) MessageBox.Show("You must select a valid cost center to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      flag = false;
    }
    else if (this._destinationBankGLAccountID == this._sourceBankGLAccountID)
    {
      int num = (int) MessageBox.Show("You can not transfer money to and from the same bank account.", "Invalid Transfer!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      flag = false;
    }
    else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((TextEditorControlBase) this.txtTransferAmount).Text, "", false) == 0 || !Versioned.IsNumeric((object) ((TextEditorControlBase) this.txtTransferAmount).Text))
    {
      int num = (int) MessageBox.Show("You must enter a valid transfer amount to continue.", "Valid Amount Required!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      flag = false;
    }
    else if (Decimal.Compare(Conversions.ToDecimal(((TextEditorControlBase) this.txtTransferAmount).Text), 0M) < 0)
    {
      int num = (int) MessageBox.Show("Transfer amount must be greater than zero.", "Valid Amount Required!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      flag = false;
    }
    else if (this.dateTimeTrasactionDate.Value == null)
    {
      int num = (int) MessageBox.Show("You must enter a valid transaction date to continue.", "Valid Transaction Date Required!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      flag = false;
    }
    else if (Conversions.ToInteger(this.cmbSourceOfficeLocation.Value) != Conversions.ToInteger(this.cmbSourceOfficeLocation.Value))
    {
      int num = (int) MessageBox.Show("You can not transfer money to a bank in a different chart of accounts.", "Office Locations Do Not Match!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      flag = false;
    }
    else
      flag = true;
    return flag;
  }

  private void LoadCostCenters(int GlCompanyId, ref MGASimpleComboBox mgaSimpleCombo)
  {
    DataSet dataSet = new DataSet();
    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(new SqlCommand("spFin_GetCostCentersList", new SqlConnection(CurrentUser.Instance.ConnectionString)));
    try
    {
      sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
      sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@glcompanyid", (object) GlCompanyId);
      sqlDataAdapter.Fill(dataSet);
      ((UltraGridBase) mgaSimpleCombo).DataSource = (object) dataSet;
      ((UltraDropDownBase) mgaSimpleCombo).DisplayMember = "Name";
      ((UltraDropDownBase) mgaSimpleCombo).ValueMember = "CostCenterID";
      if (dataSet == null || dataSet.Tables.Count <= 0 || dataSet.Tables[0].Rows.Count <= 0)
        return;
      mgaSimpleCombo.Value = RuntimeHelpers.GetObjectValue(dataSet.Tables[0].Rows[0][0]);
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

  private void btnBack_Click(object sender, EventArgs e)
  {
    if (this._currentStep == WizardStep.Summary)
    {
      this.pnlTransactionDetails.BringToFront();
      ((Control) this.btnBack).Enabled = true;
      ((Control) this.btnNext).Enabled = true;
      ((Control) this.btnFinish).Enabled = false;
      this._currentStep = WizardStep.TransactionDetails;
    }
    else if (this._currentStep == WizardStep.TransactionDetails)
    {
      this._currentStep = WizardStep.Destination;
      ((Control) this.btnBack).Enabled = true;
      ((Control) this.btnNext).Enabled = true;
      ((Control) this.btnFinish).Enabled = false;
      this.pnlDestination.BringToFront();
    }
    else
    {
      if (this._currentStep != WizardStep.Destination)
        return;
      this.pnlSource.BringToFront();
      ((Control) this.btnBack).Enabled = false;
      ((Control) this.btnNext).Enabled = true;
      this._currentStep = WizardStep.Source;
    }
  }

  private void btnNext_Click(object sender, EventArgs e)
  {
    if (this._currentStep == WizardStep.Source)
    {
      this.pnlDestination.BringToFront();
      ((Control) this.btnBack).Enabled = true;
      ((Control) this.btnNext).Enabled = true;
      this._currentStep = WizardStep.Destination;
    }
    else if (this._currentStep == WizardStep.Destination)
    {
      this.pnlTransactionDetails.BringToFront();
      ((Control) this.btnNext).Enabled = true;
      ((Control) this.btnBack).Enabled = true;
      ((Control) this.btnFinish).Enabled = false;
      this._currentStep = WizardStep.TransactionDetails;
    }
    else
    {
      if (this._currentStep != WizardStep.TransactionDetails)
        return;
      this.pnlConfirmation.BringToFront();
      ((Control) this.btnNext).Enabled = false;
      ((Control) this.btnBack).Enabled = true;
      ((Control) this.btnFinish).Enabled = true;
      this._currentStep = WizardStep.Summary;
      this._transactionDate = this.dateTimeTrasactionDate.DateTime;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((TextEditorControlBase) this.txtTransferAmount).Text, string.Empty, false) != 0)
        this._transactionAmount = Decimal.Parse(((TextEditorControlBase) this.txtTransferAmount).Text, NumberStyles.Any);
      this._transactionComment = ((TextEditorControlBase) this.txtComments).Text;
      if (((UltraDropDownBase) this.cmbSourceBankAccount).SelectedRow != null)
        this._sourceBankGLAccountID = Conversions.ToInteger(((UltraDropDownBase) this.cmbSourceBankAccount).SelectedRow.Cells["GLACCTID"].Value);
      if (((UltraDropDownBase) this.cmbDestinationBankAccount).SelectedRow != null)
        this._destinationBankGLAccountID = Conversions.ToInteger(((UltraDropDownBase) this.cmbDestinationBankAccount).SelectedRow.Cells["GLACCTID"].Value);
      this.SetConfirmationText();
    }
  }

  private void btnCancel_Click(object sender, EventArgs e) => this.Close();

  private void frmBankTransfer_Load(object sender, EventArgs e)
  {
    if (!SecurityManager.Instance.AssertPermission("{1A2183F1-8CEF-47b4-97D0-573AF021AD16}"))
    {
      Utility.DenyAccess();
      this.BeginInvoke((Delegate) new MethodInvoker(((Form) this).Close));
    }
    else
    {
      if (!this.DesignMode)
      {
        this.FormDataConnection.ConnectionString = CurrentUser.Instance.ConnectionString;
        ((UltraGridBase) this.cmbSourceOfficeLocation).DataSource = (object) Methods.GetOfficeLocationDataset();
        ((UltraGridBase) this.cmbDestinationOfficeLocation).DataSource = (object) Methods.GetOfficeLocationDataset();
      }
      this.pnlSource.BringToFront();
    }
  }

  private void frmBankTransfer_Resize(object sender, EventArgs e) => this.Refresh();
}
