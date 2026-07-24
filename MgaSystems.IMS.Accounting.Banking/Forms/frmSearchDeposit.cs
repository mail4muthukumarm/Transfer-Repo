// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Banking.Forms.frmSearchDeposit
// Assembly: MgaSystems.IMS.Accounting.Banking, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: ED5B99DC-3DD2-44AB-BA36-49A11A94937D
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Banking.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using MGASystems.Common;
using MGASystems.Common.DataAccess;
using MGASystems.IMS.Accounting.Core.Forms;
using MGASystems.Tools;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Banking.Forms;

public sealed class frmSearchDeposit : Form
{
  private IContainer components;
  private int BankAccountGL;
  private DataSet optionsDataset;
  private DataSet searchByDataset;
  private frmSearchDeposit.SearchType CurrentSearchType;
  private frmSearchDeposit.CheckSearchType CurrentCheckSearchType;
  private frmSearchDeposit.CashReceiptSearchType CurrentCashReceiptSearchType;
  private frmSearchDeposit.DepositSearchType CurrentDepositSearchType;

  private frmSearchDeposit()
  {
    this.InitializeComponent();
    this.SetPanelDataBindings();
    this.BindSearchForCombo();
    this.comboSearchFor.Value = (object) 0;
    this.BindOptionsDropDowns();
  }

  public frmSearchDeposit(int GLCompanyId)
  {
    this.InitializeComponent();
    this.BankAccountGL = GLCompanyId;
    this.SetPanelDataBindings();
    this.BindSearchForCombo();
    this.comboSearchFor.Value = (object) 0;
    this.BindOptionsDropDowns();
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [field: AccessedThroughProperty("panelCheckSearchOptions")]
  internal virtual Panel panelCheckSearchOptions { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("panelCashReceiptSearchOptions")]
  internal virtual Panel panelCashReceiptSearchOptions { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("panelDepositSearchOptions")]
  internal virtual Panel panelDepositSearchOptions { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label5")]
  internal virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Panel1")]
  internal virtual Panel Panel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label3")]
  internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PictureBox1")]
  internal virtual PictureBox PictureBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGAButton buttonSearchCheck
  {
    get => this._buttonSearchCheck;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ExecuteSearch);
      MGAButton buttonSearchCheck1 = this._buttonSearchCheck;
      if (buttonSearchCheck1 != null)
        ((Control) buttonSearchCheck1).Click -= eventHandler;
      this._buttonSearchCheck = value;
      MGAButton buttonSearchCheck2 = this._buttonSearchCheck;
      if (buttonSearchCheck2 == null)
        return;
      ((Control) buttonSearchCheck2).Click += eventHandler;
    }
  }

  internal virtual MGAButton buttonSearchDeposit
  {
    get => this._buttonSearchDeposit;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ExecuteSearch);
      MGAButton buttonSearchDeposit1 = this._buttonSearchDeposit;
      if (buttonSearchDeposit1 != null)
        ((Control) buttonSearchDeposit1).Click -= eventHandler;
      this._buttonSearchDeposit = value;
      MGAButton buttonSearchDeposit2 = this._buttonSearchDeposit;
      if (buttonSearchDeposit2 == null)
        return;
      ((Control) buttonSearchDeposit2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("Label6")]
  internal virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label7")]
  internal virtual Label Label7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label8")]
  internal virtual Label Label8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label9")]
  internal virtual Label Label9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("panelCheckDateOptions")]
  internal virtual Panel panelCheckDateOptions { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label10")]
  internal virtual Label Label10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label11")]
  internal virtual Label Label11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("panelCheckAmountOptions")]
  internal virtual Panel panelCheckAmountOptions { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label12")]
  internal virtual Label Label12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label13")]
  internal virtual Label Label13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label14")]
  internal virtual Label Label14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("panelCheckPayeeOptions")]
  internal virtual Panel panelCheckPayeeOptions { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label15")]
  internal virtual Label Label15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label16")]
  internal virtual Label Label16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dateTimeCheckDate")]
  internal virtual MGADateTimePicker dateTimeCheckDate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("comboCheckDateOptions")]
  internal virtual MGASimpleComboBox comboCheckDateOptions { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGATextBox textboxCheckAmount
  {
    get => this._textboxCheckAmount;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      CancelEventHandler cancelEventHandler = new CancelEventHandler(this.FormatCurrencyFields);
      MGATextBox textboxCheckAmount1 = this._textboxCheckAmount;
      if (textboxCheckAmount1 != null)
        ((Control) textboxCheckAmount1).Validating -= cancelEventHandler;
      this._textboxCheckAmount = value;
      MGATextBox textboxCheckAmount2 = this._textboxCheckAmount;
      if (textboxCheckAmount2 == null)
        return;
      ((Control) textboxCheckAmount2).Validating += cancelEventHandler;
    }
  }

  [field: AccessedThroughProperty("comboCheckAmountOptions")]
  internal virtual MGASimpleComboBox comboCheckAmountOptions { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtCheckPayeeName")]
  internal virtual MGATextBox txtCheckPayeeName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGAButton buttonSearchCheckPayee
  {
    get => this._buttonSearchCheckPayee;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.SearchEntity);
      MGAButton searchCheckPayee1 = this._buttonSearchCheckPayee;
      if (searchCheckPayee1 != null)
        ((Control) searchCheckPayee1).Click -= eventHandler;
      this._buttonSearchCheckPayee = value;
      MGAButton searchCheckPayee2 = this._buttonSearchCheckPayee;
      if (searchCheckPayee2 == null)
        return;
      ((Control) searchCheckPayee2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("textboxCheckNumber")]
  internal virtual MGATextBox textboxCheckNumber { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("panelCheckNumberOptions")]
  internal virtual Panel panelCheckNumberOptions { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGAButton buttonCheckCancel
  {
    get => this._buttonCheckCancel;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.CancelSearch);
      MGAButton buttonCheckCancel1 = this._buttonCheckCancel;
      if (buttonCheckCancel1 != null)
        ((Control) buttonCheckCancel1).Click -= eventHandler;
      this._buttonCheckCancel = value;
      MGAButton buttonCheckCancel2 = this._buttonCheckCancel;
      if (buttonCheckCancel2 == null)
        return;
      ((Control) buttonCheckCancel2).Click += eventHandler;
    }
  }

  internal virtual MGAButton buttonDepositCancel
  {
    get => this._buttonDepositCancel;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.CancelSearch);
      MGAButton buttonDepositCancel1 = this._buttonDepositCancel;
      if (buttonDepositCancel1 != null)
        ((Control) buttonDepositCancel1).Click -= eventHandler;
      this._buttonDepositCancel = value;
      MGAButton buttonDepositCancel2 = this._buttonDepositCancel;
      if (buttonDepositCancel2 == null)
        return;
      ((Control) buttonDepositCancel2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("dateTimeDepositDate")]
  internal virtual MGADateTimePicker dateTimeDepositDate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("comboDepositDateOptions")]
  internal virtual MGASimpleComboBox comboDepositDateOptions { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGATextBox textboxDeposit_Amount
  {
    get => this._textboxDeposit_Amount;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      CancelEventHandler cancelEventHandler = new CancelEventHandler(this.FormatCurrencyFields);
      MGATextBox textboxDepositAmount1 = this._textboxDeposit_Amount;
      if (textboxDepositAmount1 != null)
        ((Control) textboxDepositAmount1).Validating -= cancelEventHandler;
      this._textboxDeposit_Amount = value;
      MGATextBox textboxDepositAmount2 = this._textboxDeposit_Amount;
      if (textboxDepositAmount2 == null)
        return;
      ((Control) textboxDepositAmount2).Validating += cancelEventHandler;
    }
  }

  [field: AccessedThroughProperty("comboDeposit_AmountOptions")]
  internal virtual MGASimpleComboBox comboDeposit_AmountOptions { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual RadioButton optionDeposit_DepositAmount
  {
    get => this._optionDeposit_DepositAmount;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.DepositOptionChanged);
      RadioButton depositDepositAmount1 = this._optionDeposit_DepositAmount;
      if (depositDepositAmount1 != null)
        depositDepositAmount1.CheckedChanged -= eventHandler;
      this._optionDeposit_DepositAmount = value;
      RadioButton depositDepositAmount2 = this._optionDeposit_DepositAmount;
      if (depositDepositAmount2 == null)
        return;
      depositDepositAmount2.CheckedChanged += eventHandler;
    }
  }

  internal virtual RadioButton optionDeposit_DepositDate
  {
    get => this._optionDeposit_DepositDate;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.DepositOptionChanged);
      RadioButton depositDepositDate1 = this._optionDeposit_DepositDate;
      if (depositDepositDate1 != null)
        depositDepositDate1.CheckedChanged -= eventHandler;
      this._optionDeposit_DepositDate = value;
      RadioButton depositDepositDate2 = this._optionDeposit_DepositDate;
      if (depositDepositDate2 == null)
        return;
      depositDepositDate2.CheckedChanged += eventHandler;
    }
  }

  internal virtual RadioButton optionCheck_CheckNumber
  {
    get => this._optionCheck_CheckNumber;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.CheckOptionChanged);
      RadioButton checkCheckNumber1 = this._optionCheck_CheckNumber;
      if (checkCheckNumber1 != null)
        checkCheckNumber1.CheckedChanged -= eventHandler;
      this._optionCheck_CheckNumber = value;
      RadioButton checkCheckNumber2 = this._optionCheck_CheckNumber;
      if (checkCheckNumber2 == null)
        return;
      checkCheckNumber2.CheckedChanged += eventHandler;
    }
  }

  internal virtual RadioButton optionCheck_Payee
  {
    get => this._optionCheck_Payee;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.CheckOptionChanged);
      RadioButton optionCheckPayee1 = this._optionCheck_Payee;
      if (optionCheckPayee1 != null)
        optionCheckPayee1.CheckedChanged -= eventHandler;
      this._optionCheck_Payee = value;
      RadioButton optionCheckPayee2 = this._optionCheck_Payee;
      if (optionCheckPayee2 == null)
        return;
      optionCheckPayee2.CheckedChanged += eventHandler;
    }
  }

  internal virtual RadioButton optionCheck_CheckAmount
  {
    get => this._optionCheck_CheckAmount;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.CheckOptionChanged);
      RadioButton checkCheckAmount1 = this._optionCheck_CheckAmount;
      if (checkCheckAmount1 != null)
        checkCheckAmount1.CheckedChanged -= eventHandler;
      this._optionCheck_CheckAmount = value;
      RadioButton checkCheckAmount2 = this._optionCheck_CheckAmount;
      if (checkCheckAmount2 == null)
        return;
      checkCheckAmount2.CheckedChanged += eventHandler;
    }
  }

  internal virtual RadioButton optionCheck_CheckDate
  {
    get => this._optionCheck_CheckDate;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.CheckOptionChanged);
      RadioButton optionCheckCheckDate1 = this._optionCheck_CheckDate;
      if (optionCheckCheckDate1 != null)
        optionCheckCheckDate1.CheckedChanged -= eventHandler;
      this._optionCheck_CheckDate = value;
      RadioButton optionCheckCheckDate2 = this._optionCheck_CheckDate;
      if (optionCheckCheckDate2 == null)
        return;
      optionCheckCheckDate2.CheckedChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("textboxCashReceipt_CheckNumber")]
  internal virtual MGATextBox textboxCashReceipt_CheckNumber { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label2")]
  internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual RadioButton optionCashReceipt_CheckNumber
  {
    get => this._optionCashReceipt_CheckNumber;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.CashReceiptOptionChanged);
      RadioButton receiptCheckNumber1 = this._optionCashReceipt_CheckNumber;
      if (receiptCheckNumber1 != null)
        receiptCheckNumber1.CheckedChanged -= eventHandler;
      this._optionCashReceipt_CheckNumber = value;
      RadioButton receiptCheckNumber2 = this._optionCashReceipt_CheckNumber;
      if (receiptCheckNumber2 == null)
        return;
      receiptCheckNumber2.CheckedChanged += eventHandler;
    }
  }

  internal virtual MGAButton buttonCashReceipt_SearchRemitter
  {
    get => this._buttonCashReceipt_SearchRemitter;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.SearchEntity);
      MGAButton receiptSearchRemitter1 = this._buttonCashReceipt_SearchRemitter;
      if (receiptSearchRemitter1 != null)
        ((Control) receiptSearchRemitter1).Click -= eventHandler;
      this._buttonCashReceipt_SearchRemitter = value;
      MGAButton receiptSearchRemitter2 = this._buttonCashReceipt_SearchRemitter;
      if (receiptSearchRemitter2 == null)
        return;
      ((Control) receiptSearchRemitter2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("textboxCashReceipt_Remitter")]
  internal virtual MGATextBox textboxCashReceipt_Remitter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label18")]
  internal virtual Label Label18 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual RadioButton optionCashReceipt_Remitter
  {
    get => this._optionCashReceipt_Remitter;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.CashReceiptOptionChanged);
      RadioButton cashReceiptRemitter1 = this._optionCashReceipt_Remitter;
      if (cashReceiptRemitter1 != null)
        cashReceiptRemitter1.CheckedChanged -= eventHandler;
      this._optionCashReceipt_Remitter = value;
      RadioButton cashReceiptRemitter2 = this._optionCashReceipt_Remitter;
      if (cashReceiptRemitter2 == null)
        return;
      cashReceiptRemitter2.CheckedChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("dateTimeCashReceipt_DepositDate")]
  internal virtual MGADateTimePicker dateTimeCashReceipt_DepositDate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label19")]
  internal virtual Label Label19 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("comboCashReceipt_DepositDateOptions")]
  internal virtual MGASimpleComboBox comboCashReceipt_DepositDateOptions { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label20")]
  internal virtual Label Label20 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGATextBox textboxCashReceipt_Amount
  {
    get => this._textboxCashReceipt_Amount;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      CancelEventHandler cancelEventHandler = new CancelEventHandler(this.FormatCurrencyFields);
      MGATextBox cashReceiptAmount1 = this._textboxCashReceipt_Amount;
      if (cashReceiptAmount1 != null)
        ((Control) cashReceiptAmount1).Validating -= cancelEventHandler;
      this._textboxCashReceipt_Amount = value;
      MGATextBox cashReceiptAmount2 = this._textboxCashReceipt_Amount;
      if (cashReceiptAmount2 == null)
        return;
      ((Control) cashReceiptAmount2).Validating += cancelEventHandler;
    }
  }

  [field: AccessedThroughProperty("Label21")]
  internal virtual Label Label21 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("comboCashReceipt_AmountOptions")]
  internal virtual MGASimpleComboBox comboCashReceipt_AmountOptions { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label22")]
  internal virtual Label Label22 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual RadioButton optionCashReceipt_CheckAmount
  {
    get => this._optionCashReceipt_CheckAmount;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.CashReceiptOptionChanged);
      RadioButton receiptCheckAmount1 = this._optionCashReceipt_CheckAmount;
      if (receiptCheckAmount1 != null)
        receiptCheckAmount1.CheckedChanged -= eventHandler;
      this._optionCashReceipt_CheckAmount = value;
      RadioButton receiptCheckAmount2 = this._optionCashReceipt_CheckAmount;
      if (receiptCheckAmount2 == null)
        return;
      receiptCheckAmount2.CheckedChanged += eventHandler;
    }
  }

  internal virtual RadioButton optionCashReceipt_DepositDate
  {
    get => this._optionCashReceipt_DepositDate;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.CashReceiptOptionChanged);
      RadioButton receiptDepositDate1 = this._optionCashReceipt_DepositDate;
      if (receiptDepositDate1 != null)
        receiptDepositDate1.CheckedChanged -= eventHandler;
      this._optionCashReceipt_DepositDate = value;
      RadioButton receiptDepositDate2 = this._optionCashReceipt_DepositDate;
      if (receiptDepositDate2 == null)
        return;
      receiptDepositDate2.CheckedChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("Label23")]
  internal virtual Label Label23 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGAButton buttonCashReceipt_Cancel
  {
    get => this._buttonCashReceipt_Cancel;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.CancelSearch);
      MGAButton cashReceiptCancel1 = this._buttonCashReceipt_Cancel;
      if (cashReceiptCancel1 != null)
        ((Control) cashReceiptCancel1).Click -= eventHandler;
      this._buttonCashReceipt_Cancel = value;
      MGAButton cashReceiptCancel2 = this._buttonCashReceipt_Cancel;
      if (cashReceiptCancel2 == null)
        return;
      ((Control) cashReceiptCancel2).Click += eventHandler;
    }
  }

  internal virtual MGAButton buttonCashReceipt_ExecuteSearch
  {
    get => this._buttonCashReceipt_ExecuteSearch;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ExecuteSearch);
      MGAButton receiptExecuteSearch1 = this._buttonCashReceipt_ExecuteSearch;
      if (receiptExecuteSearch1 != null)
        ((Control) receiptExecuteSearch1).Click -= eventHandler;
      this._buttonCashReceipt_ExecuteSearch = value;
      MGAButton receiptExecuteSearch2 = this._buttonCashReceipt_ExecuteSearch;
      if (receiptExecuteSearch2 == null)
        return;
      ((Control) receiptExecuteSearch2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("panelCashReceipt_CheckNumber")]
  internal virtual Panel panelCashReceipt_CheckNumber { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("panelCashReceipt_Remitter")]
  internal virtual Panel panelCashReceipt_Remitter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("panelCashReceipt_DepositDate")]
  internal virtual Panel panelCashReceipt_DepositDate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("panelCashReceipt_CheckAmount")]
  internal virtual Panel panelCashReceipt_CheckAmount { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("panelDeposit_DepositDate")]
  internal virtual Panel panelDeposit_DepositDate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("paneldeposit_DepositAmount")]
  internal virtual Panel paneldeposit_DepositAmount { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Panel2")]
  internal virtual Panel Panel2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGASimpleComboBox comboSearchFor
  {
    get => this._comboSearchFor;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      RowSelectedEventHandler selectedEventHandler = new RowSelectedEventHandler(this.comboSearchFor_RowSelected);
      MGASimpleComboBox comboSearchFor1 = this._comboSearchFor;
      if (comboSearchFor1 != null)
        comboSearchFor1.RowSelected -= selectedEventHandler;
      this._comboSearchFor = value;
      MGASimpleComboBox comboSearchFor2 = this._comboSearchFor;
      if (comboSearchFor2 == null)
        return;
      comboSearchFor2.RowSelected += selectedEventHandler;
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    ResourceManager resourceManager = new ResourceManager(typeof (frmSearchDeposit));
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    this.Label3 = new Label();
    this.PictureBox1 = new PictureBox();
    this.panelCheckSearchOptions = new Panel();
    this.buttonCheckCancel = new MGAButton();
    this.panelCheckNumberOptions = new Panel();
    this.textboxCheckNumber = new MGATextBox();
    this.Label16 = new Label();
    this.optionCheck_CheckNumber = new RadioButton();
    this.panelCheckPayeeOptions = new Panel();
    this.buttonSearchCheckPayee = new MGAButton();
    this.txtCheckPayeeName = new MGATextBox();
    this.Label15 = new Label();
    this.optionCheck_Payee = new RadioButton();
    this.panelCheckDateOptions = new Panel();
    this.dateTimeCheckDate = new MGADateTimePicker();
    this.Label10 = new Label();
    this.comboCheckDateOptions = new MGASimpleComboBox();
    this.Label11 = new Label();
    this.panelCheckAmountOptions = new Panel();
    this.textboxCheckAmount = new MGATextBox();
    this.Label12 = new Label();
    this.comboCheckAmountOptions = new MGASimpleComboBox();
    this.Label13 = new Label();
    this.optionCheck_CheckAmount = new RadioButton();
    this.optionCheck_CheckDate = new RadioButton();
    this.Label14 = new Label();
    this.buttonSearchCheck = new MGAButton();
    this.panelCashReceiptSearchOptions = new Panel();
    this.buttonCashReceipt_Cancel = new MGAButton();
    this.panelCashReceipt_CheckNumber = new Panel();
    this.textboxCashReceipt_CheckNumber = new MGATextBox();
    this.Label2 = new Label();
    this.optionCashReceipt_CheckNumber = new RadioButton();
    this.panelCashReceipt_Remitter = new Panel();
    this.buttonCashReceipt_SearchRemitter = new MGAButton();
    this.textboxCashReceipt_Remitter = new MGATextBox();
    this.Label18 = new Label();
    this.optionCashReceipt_Remitter = new RadioButton();
    this.panelCashReceipt_DepositDate = new Panel();
    this.dateTimeCashReceipt_DepositDate = new MGADateTimePicker();
    this.Label19 = new Label();
    this.comboCashReceipt_DepositDateOptions = new MGASimpleComboBox();
    this.Label20 = new Label();
    this.panelCashReceipt_CheckAmount = new Panel();
    this.textboxCashReceipt_Amount = new MGATextBox();
    this.Label21 = new Label();
    this.comboCashReceipt_AmountOptions = new MGASimpleComboBox();
    this.Label22 = new Label();
    this.optionCashReceipt_CheckAmount = new RadioButton();
    this.optionCashReceipt_DepositDate = new RadioButton();
    this.Label23 = new Label();
    this.buttonCashReceipt_ExecuteSearch = new MGAButton();
    this.panelDepositSearchOptions = new Panel();
    this.buttonDepositCancel = new MGAButton();
    this.panelDeposit_DepositDate = new Panel();
    this.dateTimeDepositDate = new MGADateTimePicker();
    this.Label8 = new Label();
    this.comboDepositDateOptions = new MGASimpleComboBox();
    this.Label9 = new Label();
    this.paneldeposit_DepositAmount = new Panel();
    this.textboxDeposit_Amount = new MGATextBox();
    this.Label7 = new Label();
    this.comboDeposit_AmountOptions = new MGASimpleComboBox();
    this.Label6 = new Label();
    this.optionDeposit_DepositAmount = new RadioButton();
    this.optionDeposit_DepositDate = new RadioButton();
    this.buttonSearchDeposit = new MGAButton();
    this.Label5 = new Label();
    this.Panel1 = new Panel();
    this.Panel2 = new Panel();
    this.Label1 = new Label();
    this.comboSearchFor = new MGASimpleComboBox();
    this.panelCheckSearchOptions.SuspendLayout();
    this.panelCheckNumberOptions.SuspendLayout();
    ((ISupportInitialize) this.textboxCheckNumber).BeginInit();
    this.panelCheckPayeeOptions.SuspendLayout();
    ((ISupportInitialize) this.txtCheckPayeeName).BeginInit();
    this.panelCheckDateOptions.SuspendLayout();
    ((ISupportInitialize) this.dateTimeCheckDate).BeginInit();
    ((ISupportInitialize) this.comboCheckDateOptions).BeginInit();
    this.panelCheckAmountOptions.SuspendLayout();
    ((ISupportInitialize) this.textboxCheckAmount).BeginInit();
    ((ISupportInitialize) this.comboCheckAmountOptions).BeginInit();
    this.panelCashReceiptSearchOptions.SuspendLayout();
    this.panelCashReceipt_CheckNumber.SuspendLayout();
    ((ISupportInitialize) this.textboxCashReceipt_CheckNumber).BeginInit();
    this.panelCashReceipt_Remitter.SuspendLayout();
    ((ISupportInitialize) this.textboxCashReceipt_Remitter).BeginInit();
    this.panelCashReceipt_DepositDate.SuspendLayout();
    ((ISupportInitialize) this.dateTimeCashReceipt_DepositDate).BeginInit();
    ((ISupportInitialize) this.comboCashReceipt_DepositDateOptions).BeginInit();
    this.panelCashReceipt_CheckAmount.SuspendLayout();
    ((ISupportInitialize) this.textboxCashReceipt_Amount).BeginInit();
    ((ISupportInitialize) this.comboCashReceipt_AmountOptions).BeginInit();
    this.panelDepositSearchOptions.SuspendLayout();
    this.panelDeposit_DepositDate.SuspendLayout();
    ((ISupportInitialize) this.dateTimeDepositDate).BeginInit();
    ((ISupportInitialize) this.comboDepositDateOptions).BeginInit();
    this.paneldeposit_DepositAmount.SuspendLayout();
    ((ISupportInitialize) this.textboxDeposit_Amount).BeginInit();
    ((ISupportInitialize) this.comboDeposit_AmountOptions).BeginInit();
    this.Panel1.SuspendLayout();
    this.Panel2.SuspendLayout();
    ((ISupportInitialize) this.comboSearchFor).BeginInit();
    this.SuspendLayout();
    this.Label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.Label3.BackColor = Color.Transparent;
    this.Label3.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label3.ForeColor = Color.White;
    this.Label3.Location = new Point(8, 2);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(352, 24);
    this.Label3.TabIndex = 1;
    this.Label3.Text = "Please specify the search search criteria for the information you are looking for then click the 'Execute Search ' button.";
    this.PictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.PictureBox1.BackColor = Color.Transparent;
    this.PictureBox1.Image = (Image) resourceManager.GetObject("PictureBox1.Image");
    this.PictureBox1.Location = new Point(376, 2);
    this.PictureBox1.Name = "PictureBox1";
    this.PictureBox1.Size = new Size(32 /*0x20*/, 32 /*0x20*/);
    this.PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
    this.PictureBox1.TabIndex = 10;
    this.PictureBox1.TabStop = false;
    this.panelCheckSearchOptions.Controls.Add((Control) this.buttonCheckCancel);
    this.panelCheckSearchOptions.Controls.Add((Control) this.panelCheckNumberOptions);
    this.panelCheckSearchOptions.Controls.Add((Control) this.optionCheck_CheckNumber);
    this.panelCheckSearchOptions.Controls.Add((Control) this.panelCheckPayeeOptions);
    this.panelCheckSearchOptions.Controls.Add((Control) this.optionCheck_Payee);
    this.panelCheckSearchOptions.Controls.Add((Control) this.panelCheckDateOptions);
    this.panelCheckSearchOptions.Controls.Add((Control) this.panelCheckAmountOptions);
    this.panelCheckSearchOptions.Controls.Add((Control) this.optionCheck_CheckAmount);
    this.panelCheckSearchOptions.Controls.Add((Control) this.optionCheck_CheckDate);
    this.panelCheckSearchOptions.Controls.Add((Control) this.Label14);
    this.panelCheckSearchOptions.Controls.Add((Control) this.buttonSearchCheck);
    this.panelCheckSearchOptions.Dock = DockStyle.Fill;
    this.panelCheckSearchOptions.ForeColor = Color.Black;
    this.panelCheckSearchOptions.Location = new Point(0, 80 /*0x50*/);
    this.panelCheckSearchOptions.Name = "panelCheckSearchOptions";
    this.panelCheckSearchOptions.Size = new Size(434, 384);
    this.panelCheckSearchOptions.TabIndex = 1;
    appearance1.BackColor = Color.Gainsboro;
    appearance1.BackColor2 = Color.White;
    appearance1.BackGradientStyle = (GradientStyle) 2;
    appearance1.BorderColor = Color.Gray;
    ((ControlBase) this.buttonCheckCancel).Appearance = (AppearanceBase) appearance1;
    ((Control) this.buttonCheckCancel).Location = new Point(288, 352);
    ((Control) this.buttonCheckCancel).Name = "buttonCheckCancel";
    ((Control) this.buttonCheckCancel).Size = new Size(96 /*0x60*/, 24);
    ((Control) this.buttonCheckCancel).TabIndex = 17;
    ((ControlBase) this.buttonCheckCancel).Text = "Cancel";
    this.panelCheckNumberOptions.Controls.Add((Control) this.textboxCheckNumber);
    this.panelCheckNumberOptions.Controls.Add((Control) this.Label16);
    this.panelCheckNumberOptions.Enabled = false;
    this.panelCheckNumberOptions.Location = new Point(80 /*0x50*/, 54);
    this.panelCheckNumberOptions.Name = "panelCheckNumberOptions";
    this.panelCheckNumberOptions.Size = new Size(304, 34);
    this.panelCheckNumberOptions.TabIndex = 2;
    ((Control) this.textboxCheckNumber).Location = new Point(96 /*0x60*/, 8);
    ((Control) this.textboxCheckNumber).Name = "textboxCheckNumber";
    ((Control) this.textboxCheckNumber).Size = new Size(200, 20);
    ((Control) this.textboxCheckNumber).TabIndex = 3;
    this.Label16.AutoSize = true;
    this.Label16.ForeColor = Color.Black;
    this.Label16.Location = new Point(8, 8);
    this.Label16.Name = "Label16";
    this.Label16.Size = new Size(81, 17);
    this.Label16.TabIndex = 2;
    this.Label16.Text = "Check Number:";
    this.optionCheck_CheckNumber.Checked = true;
    this.optionCheck_CheckNumber.FlatStyle = FlatStyle.Flat;
    this.optionCheck_CheckNumber.ForeColor = Color.Black;
    this.optionCheck_CheckNumber.Location = new Point(32 /*0x20*/, 32 /*0x20*/);
    this.optionCheck_CheckNumber.Name = "optionCheck_CheckNumber";
    this.optionCheck_CheckNumber.Size = new Size(160 /*0xA0*/, 16 /*0x10*/);
    this.optionCheck_CheckNumber.TabIndex = 1;
    this.optionCheck_CheckNumber.TabStop = true;
    this.optionCheck_CheckNumber.Text = "Search By Check Number";
    this.panelCheckPayeeOptions.Controls.Add((Control) this.buttonSearchCheckPayee);
    this.panelCheckPayeeOptions.Controls.Add((Control) this.txtCheckPayeeName);
    this.panelCheckPayeeOptions.Controls.Add((Control) this.Label15);
    this.panelCheckPayeeOptions.Enabled = false;
    this.panelCheckPayeeOptions.Location = new Point(80 /*0x50*/, 120);
    this.panelCheckPayeeOptions.Name = "panelCheckPayeeOptions";
    this.panelCheckPayeeOptions.Size = new Size(304, 32 /*0x20*/);
    this.panelCheckPayeeOptions.TabIndex = 14;
    appearance2.BackColor = Color.Gainsboro;
    appearance2.BackColor2 = Color.White;
    appearance2.BackGradientStyle = (GradientStyle) 2;
    appearance2.BorderColor = Color.Gray;
    appearance2.Image = RuntimeHelpers.GetObjectValue(resourceManager.GetObject("Appearance2.Image"));
    appearance2.ImageHAlign = (HAlign) 2;
    appearance2.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonSearchCheckPayee).Appearance = (AppearanceBase) appearance2;
    ((Control) this.buttonSearchCheckPayee).Location = new Point(280, 8);
    ((Control) this.buttonSearchCheckPayee).Name = "buttonSearchCheckPayee";
    ((Control) this.buttonSearchCheckPayee).Size = new Size(20, 20);
    ((Control) this.buttonSearchCheckPayee).TabIndex = 13;
    ((Control) this.txtCheckPayeeName).Enabled = false;
    ((Control) this.txtCheckPayeeName).Location = new Point(48 /*0x30*/, 8);
    ((Control) this.txtCheckPayeeName).Name = "txtCheckPayeeName";
    ((Control) this.txtCheckPayeeName).Size = new Size(228, 20);
    ((Control) this.txtCheckPayeeName).TabIndex = 12;
    this.Label15.AutoSize = true;
    this.Label15.ForeColor = Color.Black;
    this.Label15.Location = new Point(8, 8);
    this.Label15.Name = "Label15";
    this.Label15.Size = new Size(38, 17);
    this.Label15.TabIndex = 3;
    this.Label15.Text = "Payee:";
    this.optionCheck_Payee.FlatStyle = FlatStyle.Flat;
    this.optionCheck_Payee.ForeColor = Color.Black;
    this.optionCheck_Payee.Location = new Point(32 /*0x20*/, 96 /*0x60*/);
    this.optionCheck_Payee.Name = "optionCheck_Payee";
    this.optionCheck_Payee.Size = new Size(160 /*0xA0*/, 16 /*0x10*/);
    this.optionCheck_Payee.TabIndex = 13;
    this.optionCheck_Payee.Text = "Search By Payee";
    this.panelCheckDateOptions.Controls.Add((Control) this.dateTimeCheckDate);
    this.panelCheckDateOptions.Controls.Add((Control) this.Label10);
    this.panelCheckDateOptions.Controls.Add((Control) this.comboCheckDateOptions);
    this.panelCheckDateOptions.Controls.Add((Control) this.Label11);
    this.panelCheckDateOptions.Enabled = false;
    this.panelCheckDateOptions.Location = new Point(80 /*0x50*/, 184);
    this.panelCheckDateOptions.Name = "panelCheckDateOptions";
    this.panelCheckDateOptions.Size = new Size(304, 64 /*0x40*/);
    this.panelCheckDateOptions.TabIndex = 12;
    this.dateTimeCheckDate.FormatString = "D";
    ((Control) this.dateTimeCheckDate).Location = new Point(88, 32 /*0x20*/);
    ((Control) this.dateTimeCheckDate).Name = "dateTimeCheckDate";
    ((Control) this.dateTimeCheckDate).Size = new Size(208 /*0xD0*/, 20);
    ((Control) this.dateTimeCheckDate).TabIndex = 11;
    this.Label10.AutoSize = true;
    this.Label10.ForeColor = Color.Black;
    this.Label10.Location = new Point(8, 32 /*0x20*/);
    this.Label10.Name = "Label10";
    this.Label10.Size = new Size(32 /*0x20*/, 17);
    this.Label10.TabIndex = 10;
    this.Label10.Text = "Date:";
    this.comboCheckDateOptions.CharacterCasing = CharacterCasing.Normal;
    ((UltraDropDownBase) this.comboCheckDateOptions).DisplayMember = "";
    this.comboCheckDateOptions.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboCheckDateOptions).Location = new Point(88, 8);
    ((Control) this.comboCheckDateOptions).Name = "comboCheckDateOptions";
    this.comboCheckDateOptions.SelectedIndex = -1;
    this.comboCheckDateOptions.Value = (object) "";
    ((Control) this.comboCheckDateOptions).Size = new Size(208 /*0xD0*/, 20);
    ((Control) this.comboCheckDateOptions).TabIndex = 9;
    ((UltraDropDownBase) this.comboCheckDateOptions).ValueMember = "";
    this.Label11.AutoSize = true;
    this.Label11.ForeColor = Color.Black;
    this.Label11.Location = new Point(8, 8);
    this.Label11.Name = "Label11";
    this.Label11.Size = new Size(69, 17);
    this.Label11.TabIndex = 3;
    this.Label11.Text = "Date Options";
    this.panelCheckAmountOptions.Controls.Add((Control) this.textboxCheckAmount);
    this.panelCheckAmountOptions.Controls.Add((Control) this.Label12);
    this.panelCheckAmountOptions.Controls.Add((Control) this.comboCheckAmountOptions);
    this.panelCheckAmountOptions.Controls.Add((Control) this.Label13);
    this.panelCheckAmountOptions.Enabled = false;
    this.panelCheckAmountOptions.Location = new Point(80 /*0x50*/, 280);
    this.panelCheckAmountOptions.Name = "panelCheckAmountOptions";
    this.panelCheckAmountOptions.Size = new Size(304, 64 /*0x40*/);
    this.panelCheckAmountOptions.TabIndex = 11;
    ((Control) this.textboxCheckAmount).Location = new Point(104, 32 /*0x20*/);
    ((Control) this.textboxCheckAmount).Name = "textboxCheckAmount";
    ((Control) this.textboxCheckAmount).Size = new Size(144 /*0x90*/, 20);
    ((Control) this.textboxCheckAmount).TabIndex = 11;
    this.Label12.AutoSize = true;
    this.Label12.ForeColor = Color.Black;
    this.Label12.Location = new Point(8, 32 /*0x20*/);
    this.Label12.Name = "Label12";
    this.Label12.Size = new Size(47, 17);
    this.Label12.TabIndex = 10;
    this.Label12.Text = "Amount:";
    this.comboCheckAmountOptions.CharacterCasing = CharacterCasing.Normal;
    ((UltraDropDownBase) this.comboCheckAmountOptions).DisplayMember = "";
    this.comboCheckAmountOptions.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboCheckAmountOptions).Location = new Point(104, 8);
    ((Control) this.comboCheckAmountOptions).Name = "comboCheckAmountOptions";
    this.comboCheckAmountOptions.SelectedIndex = -1;
    this.comboCheckAmountOptions.Value = (object) "";
    ((Control) this.comboCheckAmountOptions).Size = new Size(192 /*0xC0*/, 20);
    ((Control) this.comboCheckAmountOptions).TabIndex = 9;
    ((UltraDropDownBase) this.comboCheckAmountOptions).ValueMember = "";
    this.Label13.AutoSize = true;
    this.Label13.ForeColor = Color.Black;
    this.Label13.Location = new Point(8, 8);
    this.Label13.Name = "Label13";
    this.Label13.Size = new Size(89, 17);
    this.Label13.TabIndex = 3;
    this.Label13.Text = "Amount Options:";
    this.optionCheck_CheckAmount.FlatStyle = FlatStyle.Flat;
    this.optionCheck_CheckAmount.ForeColor = Color.Black;
    this.optionCheck_CheckAmount.Location = new Point(32 /*0x20*/, 256 /*0x0100*/);
    this.optionCheck_CheckAmount.Name = "optionCheck_CheckAmount";
    this.optionCheck_CheckAmount.Size = new Size(160 /*0xA0*/, 16 /*0x10*/);
    this.optionCheck_CheckAmount.TabIndex = 10;
    this.optionCheck_CheckAmount.Text = "Search By Check Amount";
    this.optionCheck_CheckDate.FlatStyle = FlatStyle.Flat;
    this.optionCheck_CheckDate.ForeColor = Color.Black;
    this.optionCheck_CheckDate.Location = new Point(32 /*0x20*/, 160 /*0xA0*/);
    this.optionCheck_CheckDate.Name = "optionCheck_CheckDate";
    this.optionCheck_CheckDate.Size = new Size(160 /*0xA0*/, 16 /*0x10*/);
    this.optionCheck_CheckDate.TabIndex = 9;
    this.optionCheck_CheckDate.Text = "Search By Check Date";
    this.Label14.AutoSize = true;
    this.Label14.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label14.ForeColor = Color.Navy;
    this.Label14.Location = new Point(16 /*0x10*/, 8);
    this.Label14.Name = "Label14";
    this.Label14.Size = new Size(176 /*0xB0*/, 23);
    this.Label14.TabIndex = 0;
    this.Label14.Text = "Check - Search Options";
    appearance3.BackColor = Color.Gainsboro;
    appearance3.BackColor2 = Color.White;
    appearance3.BackGradientStyle = (GradientStyle) 2;
    appearance3.BorderColor = Color.Gray;
    ((ControlBase) this.buttonSearchCheck).Appearance = (AppearanceBase) appearance3;
    ((Control) this.buttonSearchCheck).Location = new Point(184, 352);
    ((Control) this.buttonSearchCheck).Name = "buttonSearchCheck";
    ((Control) this.buttonSearchCheck).Size = new Size(96 /*0x60*/, 24);
    ((Control) this.buttonSearchCheck).TabIndex = 2;
    ((ControlBase) this.buttonSearchCheck).Text = "Execute Search";
    this.panelCashReceiptSearchOptions.Controls.Add((Control) this.buttonCashReceipt_Cancel);
    this.panelCashReceiptSearchOptions.Controls.Add((Control) this.panelCashReceipt_CheckNumber);
    this.panelCashReceiptSearchOptions.Controls.Add((Control) this.optionCashReceipt_CheckNumber);
    this.panelCashReceiptSearchOptions.Controls.Add((Control) this.panelCashReceipt_Remitter);
    this.panelCashReceiptSearchOptions.Controls.Add((Control) this.optionCashReceipt_Remitter);
    this.panelCashReceiptSearchOptions.Controls.Add((Control) this.panelCashReceipt_DepositDate);
    this.panelCashReceiptSearchOptions.Controls.Add((Control) this.panelCashReceipt_CheckAmount);
    this.panelCashReceiptSearchOptions.Controls.Add((Control) this.optionCashReceipt_CheckAmount);
    this.panelCashReceiptSearchOptions.Controls.Add((Control) this.optionCashReceipt_DepositDate);
    this.panelCashReceiptSearchOptions.Controls.Add((Control) this.Label23);
    this.panelCashReceiptSearchOptions.Controls.Add((Control) this.buttonCashReceipt_ExecuteSearch);
    this.panelCashReceiptSearchOptions.Dock = DockStyle.Fill;
    this.panelCashReceiptSearchOptions.Location = new Point(0, 80 /*0x50*/);
    this.panelCashReceiptSearchOptions.Name = "panelCashReceiptSearchOptions";
    this.panelCashReceiptSearchOptions.Size = new Size(434, 384);
    this.panelCashReceiptSearchOptions.TabIndex = 10;
    appearance4.BackColor = Color.Gainsboro;
    appearance4.BackColor2 = Color.White;
    appearance4.BackGradientStyle = (GradientStyle) 2;
    appearance4.BorderColor = Color.Gray;
    ((ControlBase) this.buttonCashReceipt_Cancel).Appearance = (AppearanceBase) appearance4;
    ((Control) this.buttonCashReceipt_Cancel).Location = new Point(288, 352);
    ((Control) this.buttonCashReceipt_Cancel).Name = "buttonCashReceipt_Cancel";
    ((Control) this.buttonCashReceipt_Cancel).Size = new Size(96 /*0x60*/, 24);
    ((Control) this.buttonCashReceipt_Cancel).TabIndex = 28;
    ((ControlBase) this.buttonCashReceipt_Cancel).Text = "Cancel";
    this.panelCashReceipt_CheckNumber.Controls.Add((Control) this.textboxCashReceipt_CheckNumber);
    this.panelCashReceipt_CheckNumber.Controls.Add((Control) this.Label2);
    this.panelCashReceipt_CheckNumber.Location = new Point(80 /*0x50*/, 54);
    this.panelCashReceipt_CheckNumber.Name = "panelCashReceipt_CheckNumber";
    this.panelCashReceipt_CheckNumber.Size = new Size(304, 34);
    this.panelCashReceipt_CheckNumber.TabIndex = 21;
    ((Control) this.textboxCashReceipt_CheckNumber).Location = new Point(96 /*0x60*/, 8);
    ((Control) this.textboxCashReceipt_CheckNumber).Name = "textboxCashReceipt_CheckNumber";
    ((Control) this.textboxCashReceipt_CheckNumber).Size = new Size(200, 20);
    ((Control) this.textboxCashReceipt_CheckNumber).TabIndex = 3;
    this.Label2.AutoSize = true;
    this.Label2.ForeColor = Color.Black;
    this.Label2.Location = new Point(8, 8);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(81, 17);
    this.Label2.TabIndex = 2;
    this.Label2.Text = "Check Number:";
    this.optionCashReceipt_CheckNumber.Checked = true;
    this.optionCashReceipt_CheckNumber.FlatStyle = FlatStyle.Flat;
    this.optionCashReceipt_CheckNumber.ForeColor = Color.Black;
    this.optionCashReceipt_CheckNumber.Location = new Point(32 /*0x20*/, 32 /*0x20*/);
    this.optionCashReceipt_CheckNumber.Name = "optionCashReceipt_CheckNumber";
    this.optionCashReceipt_CheckNumber.Size = new Size(160 /*0xA0*/, 16 /*0x10*/);
    this.optionCashReceipt_CheckNumber.TabIndex = 19;
    this.optionCashReceipt_CheckNumber.TabStop = true;
    this.optionCashReceipt_CheckNumber.Text = "Search By Check Number";
    this.panelCashReceipt_Remitter.Controls.Add((Control) this.buttonCashReceipt_SearchRemitter);
    this.panelCashReceipt_Remitter.Controls.Add((Control) this.textboxCashReceipt_Remitter);
    this.panelCashReceipt_Remitter.Controls.Add((Control) this.Label18);
    this.panelCashReceipt_Remitter.Enabled = false;
    this.panelCashReceipt_Remitter.Location = new Point(80 /*0x50*/, 120);
    this.panelCashReceipt_Remitter.Name = "panelCashReceipt_Remitter";
    this.panelCashReceipt_Remitter.Size = new Size(304, 32 /*0x20*/);
    this.panelCashReceipt_Remitter.TabIndex = 27;
    appearance5.BackColor = Color.Gainsboro;
    appearance5.BackColor2 = Color.White;
    appearance5.BackGradientStyle = (GradientStyle) 2;
    appearance5.BorderColor = Color.Gray;
    appearance5.Image = RuntimeHelpers.GetObjectValue(resourceManager.GetObject("Appearance5.Image"));
    appearance5.ImageHAlign = (HAlign) 2;
    appearance5.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonCashReceipt_SearchRemitter).Appearance = (AppearanceBase) appearance5;
    ((Control) this.buttonCashReceipt_SearchRemitter).Location = new Point(280, 8);
    ((Control) this.buttonCashReceipt_SearchRemitter).Name = "buttonCashReceipt_SearchRemitter";
    ((Control) this.buttonCashReceipt_SearchRemitter).Size = new Size(20, 20);
    ((Control) this.buttonCashReceipt_SearchRemitter).TabIndex = 13;
    ((Control) this.textboxCashReceipt_Remitter).Enabled = false;
    ((Control) this.textboxCashReceipt_Remitter).Location = new Point(64 /*0x40*/, 8);
    ((Control) this.textboxCashReceipt_Remitter).Name = "textboxCashReceipt_Remitter";
    ((Control) this.textboxCashReceipt_Remitter).Size = new Size(208 /*0xD0*/, 20);
    ((Control) this.textboxCashReceipt_Remitter).TabIndex = 12;
    this.Label18.AutoSize = true;
    this.Label18.ForeColor = Color.Black;
    this.Label18.Location = new Point(8, 8);
    this.Label18.Name = "Label18";
    this.Label18.Size = new Size(51, 17);
    this.Label18.TabIndex = 3;
    this.Label18.Text = "Remitter:";
    this.optionCashReceipt_Remitter.FlatStyle = FlatStyle.Flat;
    this.optionCashReceipt_Remitter.ForeColor = Color.Black;
    this.optionCashReceipt_Remitter.Location = new Point(32 /*0x20*/, 96 /*0x60*/);
    this.optionCashReceipt_Remitter.Name = "optionCashReceipt_Remitter";
    this.optionCashReceipt_Remitter.Size = new Size(160 /*0xA0*/, 16 /*0x10*/);
    this.optionCashReceipt_Remitter.TabIndex = 26;
    this.optionCashReceipt_Remitter.Text = "Search By Remitter";
    this.panelCashReceipt_DepositDate.Controls.Add((Control) this.dateTimeCashReceipt_DepositDate);
    this.panelCashReceipt_DepositDate.Controls.Add((Control) this.Label19);
    this.panelCashReceipt_DepositDate.Controls.Add((Control) this.comboCashReceipt_DepositDateOptions);
    this.panelCashReceipt_DepositDate.Controls.Add((Control) this.Label20);
    this.panelCashReceipt_DepositDate.Enabled = false;
    this.panelCashReceipt_DepositDate.Location = new Point(80 /*0x50*/, 184);
    this.panelCashReceipt_DepositDate.Name = "panelCashReceipt_DepositDate";
    this.panelCashReceipt_DepositDate.Size = new Size(304, 64 /*0x40*/);
    this.panelCashReceipt_DepositDate.TabIndex = 25;
    this.dateTimeCashReceipt_DepositDate.FormatString = "D";
    ((Control) this.dateTimeCashReceipt_DepositDate).Location = new Point(88, 32 /*0x20*/);
    ((Control) this.dateTimeCashReceipt_DepositDate).Name = "dateTimeCashReceipt_DepositDate";
    ((Control) this.dateTimeCashReceipt_DepositDate).Size = new Size(208 /*0xD0*/, 20);
    ((Control) this.dateTimeCashReceipt_DepositDate).TabIndex = 11;
    this.Label19.AutoSize = true;
    this.Label19.ForeColor = Color.Black;
    this.Label19.Location = new Point(8, 32 /*0x20*/);
    this.Label19.Name = "Label19";
    this.Label19.Size = new Size(32 /*0x20*/, 17);
    this.Label19.TabIndex = 10;
    this.Label19.Text = "Date:";
    this.comboCashReceipt_DepositDateOptions.CharacterCasing = CharacterCasing.Normal;
    ((UltraDropDownBase) this.comboCashReceipt_DepositDateOptions).DisplayMember = "";
    this.comboCashReceipt_DepositDateOptions.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboCashReceipt_DepositDateOptions).Location = new Point(88, 8);
    ((Control) this.comboCashReceipt_DepositDateOptions).Name = "comboCashReceipt_DepositDateOptions";
    this.comboCashReceipt_DepositDateOptions.SelectedIndex = -1;
    this.comboCashReceipt_DepositDateOptions.Value = (object) "";
    ((Control) this.comboCashReceipt_DepositDateOptions).Size = new Size(208 /*0xD0*/, 20);
    ((Control) this.comboCashReceipt_DepositDateOptions).TabIndex = 9;
    ((UltraDropDownBase) this.comboCashReceipt_DepositDateOptions).ValueMember = "";
    this.Label20.AutoSize = true;
    this.Label20.ForeColor = Color.Black;
    this.Label20.Location = new Point(8, 8);
    this.Label20.Name = "Label20";
    this.Label20.Size = new Size(69, 17);
    this.Label20.TabIndex = 3;
    this.Label20.Text = "Date Options";
    this.panelCashReceipt_CheckAmount.Controls.Add((Control) this.textboxCashReceipt_Amount);
    this.panelCashReceipt_CheckAmount.Controls.Add((Control) this.Label21);
    this.panelCashReceipt_CheckAmount.Controls.Add((Control) this.comboCashReceipt_AmountOptions);
    this.panelCashReceipt_CheckAmount.Controls.Add((Control) this.Label22);
    this.panelCashReceipt_CheckAmount.Enabled = false;
    this.panelCashReceipt_CheckAmount.Location = new Point(80 /*0x50*/, 280);
    this.panelCashReceipt_CheckAmount.Name = "panelCashReceipt_CheckAmount";
    this.panelCashReceipt_CheckAmount.Size = new Size(304, 56);
    this.panelCashReceipt_CheckAmount.TabIndex = 24;
    ((Control) this.textboxCashReceipt_Amount).Location = new Point(104, 32 /*0x20*/);
    ((Control) this.textboxCashReceipt_Amount).Name = "textboxCashReceipt_Amount";
    ((Control) this.textboxCashReceipt_Amount).Size = new Size(144 /*0x90*/, 20);
    ((Control) this.textboxCashReceipt_Amount).TabIndex = 11;
    this.Label21.AutoSize = true;
    this.Label21.ForeColor = Color.Black;
    this.Label21.Location = new Point(8, 32 /*0x20*/);
    this.Label21.Name = "Label21";
    this.Label21.Size = new Size(47, 17);
    this.Label21.TabIndex = 10;
    this.Label21.Text = "Amount:";
    this.comboCashReceipt_AmountOptions.CharacterCasing = CharacterCasing.Normal;
    ((UltraDropDownBase) this.comboCashReceipt_AmountOptions).DisplayMember = "";
    this.comboCashReceipt_AmountOptions.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboCashReceipt_AmountOptions).Location = new Point(104, 8);
    ((Control) this.comboCashReceipt_AmountOptions).Name = "comboCashReceipt_AmountOptions";
    this.comboCashReceipt_AmountOptions.SelectedIndex = -1;
    this.comboCashReceipt_AmountOptions.Value = (object) "";
    ((Control) this.comboCashReceipt_AmountOptions).Size = new Size(192 /*0xC0*/, 20);
    ((Control) this.comboCashReceipt_AmountOptions).TabIndex = 9;
    ((UltraDropDownBase) this.comboCashReceipt_AmountOptions).ValueMember = "";
    this.Label22.AutoSize = true;
    this.Label22.ForeColor = Color.Black;
    this.Label22.Location = new Point(8, 8);
    this.Label22.Name = "Label22";
    this.Label22.Size = new Size(89, 17);
    this.Label22.TabIndex = 3;
    this.Label22.Text = "Amount Options:";
    this.optionCashReceipt_CheckAmount.FlatStyle = FlatStyle.Flat;
    this.optionCashReceipt_CheckAmount.ForeColor = Color.Black;
    this.optionCashReceipt_CheckAmount.Location = new Point(32 /*0x20*/, 256 /*0x0100*/);
    this.optionCashReceipt_CheckAmount.Name = "optionCashReceipt_CheckAmount";
    this.optionCashReceipt_CheckAmount.Size = new Size(160 /*0xA0*/, 16 /*0x10*/);
    this.optionCashReceipt_CheckAmount.TabIndex = 23;
    this.optionCashReceipt_CheckAmount.Text = "Search By Check Amount";
    this.optionCashReceipt_DepositDate.FlatStyle = FlatStyle.Flat;
    this.optionCashReceipt_DepositDate.ForeColor = Color.Black;
    this.optionCashReceipt_DepositDate.Location = new Point(32 /*0x20*/, 160 /*0xA0*/);
    this.optionCashReceipt_DepositDate.Name = "optionCashReceipt_DepositDate";
    this.optionCashReceipt_DepositDate.Size = new Size(160 /*0xA0*/, 16 /*0x10*/);
    this.optionCashReceipt_DepositDate.TabIndex = 22;
    this.optionCashReceipt_DepositDate.Text = "Search By Deposit Date";
    this.Label23.AutoSize = true;
    this.Label23.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label23.ForeColor = Color.Navy;
    this.Label23.Location = new Point(16 /*0x10*/, 8);
    this.Label23.Name = "Label23";
    this.Label23.Size = new Size(226, 23);
    this.Label23.TabIndex = 18;
    this.Label23.Text = "Cash Receipt - Search Options";
    appearance6.BackColor = Color.Gainsboro;
    appearance6.BackColor2 = Color.White;
    appearance6.BackGradientStyle = (GradientStyle) 2;
    appearance6.BorderColor = Color.Gray;
    ((ControlBase) this.buttonCashReceipt_ExecuteSearch).Appearance = (AppearanceBase) appearance6;
    ((Control) this.buttonCashReceipt_ExecuteSearch).Location = new Point(184, 352);
    ((Control) this.buttonCashReceipt_ExecuteSearch).Name = "buttonCashReceipt_ExecuteSearch";
    ((Control) this.buttonCashReceipt_ExecuteSearch).Size = new Size(96 /*0x60*/, 24);
    ((Control) this.buttonCashReceipt_ExecuteSearch).TabIndex = 20;
    ((ControlBase) this.buttonCashReceipt_ExecuteSearch).Text = "Execute Search";
    this.panelDepositSearchOptions.Controls.Add((Control) this.buttonDepositCancel);
    this.panelDepositSearchOptions.Controls.Add((Control) this.panelDeposit_DepositDate);
    this.panelDepositSearchOptions.Controls.Add((Control) this.paneldeposit_DepositAmount);
    this.panelDepositSearchOptions.Controls.Add((Control) this.optionDeposit_DepositAmount);
    this.panelDepositSearchOptions.Controls.Add((Control) this.optionDeposit_DepositDate);
    this.panelDepositSearchOptions.Controls.Add((Control) this.buttonSearchDeposit);
    this.panelDepositSearchOptions.Controls.Add((Control) this.Label5);
    this.panelDepositSearchOptions.Dock = DockStyle.Fill;
    this.panelDepositSearchOptions.ForeColor = Color.Black;
    this.panelDepositSearchOptions.Location = new Point(0, 80 /*0x50*/);
    this.panelDepositSearchOptions.Name = "panelDepositSearchOptions";
    this.panelDepositSearchOptions.Size = new Size(434, 384);
    this.panelDepositSearchOptions.TabIndex = 10;
    appearance7.BackColor = Color.Gainsboro;
    appearance7.BackColor2 = Color.White;
    appearance7.BackGradientStyle = (GradientStyle) 2;
    appearance7.BorderColor = Color.Gray;
    ((ControlBase) this.buttonDepositCancel).Appearance = (AppearanceBase) appearance7;
    ((Control) this.buttonDepositCancel).Location = new Point(280, 352);
    ((Control) this.buttonDepositCancel).Name = "buttonDepositCancel";
    ((Control) this.buttonDepositCancel).Size = new Size(96 /*0x60*/, 24);
    ((Control) this.buttonDepositCancel).TabIndex = 8;
    ((ControlBase) this.buttonDepositCancel).Text = "Cancel";
    this.panelDeposit_DepositDate.Controls.Add((Control) this.dateTimeDepositDate);
    this.panelDeposit_DepositDate.Controls.Add((Control) this.Label8);
    this.panelDeposit_DepositDate.Controls.Add((Control) this.comboDepositDateOptions);
    this.panelDeposit_DepositDate.Controls.Add((Control) this.Label9);
    this.panelDeposit_DepositDate.Location = new Point(72, 64 /*0x40*/);
    this.panelDeposit_DepositDate.Name = "panelDeposit_DepositDate";
    this.panelDeposit_DepositDate.Size = new Size(304, 64 /*0x40*/);
    this.panelDeposit_DepositDate.TabIndex = 7;
    this.dateTimeDepositDate.FormatString = "D";
    ((Control) this.dateTimeDepositDate).Location = new Point(88, 32 /*0x20*/);
    ((Control) this.dateTimeDepositDate).Name = "dateTimeDepositDate";
    ((Control) this.dateTimeDepositDate).Size = new Size(208 /*0xD0*/, 20);
    ((Control) this.dateTimeDepositDate).TabIndex = 0;
    this.Label8.AutoSize = true;
    this.Label8.ForeColor = Color.Black;
    this.Label8.Location = new Point(8, 32 /*0x20*/);
    this.Label8.Name = "Label8";
    this.Label8.Size = new Size(32 /*0x20*/, 17);
    this.Label8.TabIndex = 3;
    this.Label8.Text = "Date:";
    this.comboDepositDateOptions.CharacterCasing = CharacterCasing.Normal;
    ((UltraDropDownBase) this.comboDepositDateOptions).DisplayMember = "";
    this.comboDepositDateOptions.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboDepositDateOptions).Location = new Point(88, 8);
    ((Control) this.comboDepositDateOptions).Name = "comboDepositDateOptions";
    this.comboDepositDateOptions.SelectedIndex = -1;
    this.comboDepositDateOptions.Value = (object) "";
    ((Control) this.comboDepositDateOptions).Size = new Size(208 /*0xD0*/, 20);
    ((Control) this.comboDepositDateOptions).TabIndex = 1;
    ((UltraDropDownBase) this.comboDepositDateOptions).ValueMember = "";
    this.Label9.AutoSize = true;
    this.Label9.ForeColor = Color.Black;
    this.Label9.Location = new Point(8, 8);
    this.Label9.Name = "Label9";
    this.Label9.Size = new Size(69, 17);
    this.Label9.TabIndex = 2;
    this.Label9.Text = "Date Options";
    this.paneldeposit_DepositAmount.Controls.Add((Control) this.textboxDeposit_Amount);
    this.paneldeposit_DepositAmount.Controls.Add((Control) this.Label7);
    this.paneldeposit_DepositAmount.Controls.Add((Control) this.comboDeposit_AmountOptions);
    this.paneldeposit_DepositAmount.Controls.Add((Control) this.Label6);
    this.paneldeposit_DepositAmount.Location = new Point(72, 176 /*0xB0*/);
    this.paneldeposit_DepositAmount.Name = "paneldeposit_DepositAmount";
    this.paneldeposit_DepositAmount.Size = new Size(304, 64 /*0x40*/);
    this.paneldeposit_DepositAmount.TabIndex = 6;
    ((Control) this.textboxDeposit_Amount).Location = new Point(104, 32 /*0x20*/);
    ((Control) this.textboxDeposit_Amount).Name = "textboxDeposit_Amount";
    ((Control) this.textboxDeposit_Amount).Size = new Size(144 /*0x90*/, 20);
    ((Control) this.textboxDeposit_Amount).TabIndex = 11;
    this.Label7.AutoSize = true;
    this.Label7.ForeColor = Color.Black;
    this.Label7.Location = new Point(8, 32 /*0x20*/);
    this.Label7.Name = "Label7";
    this.Label7.Size = new Size(47, 17);
    this.Label7.TabIndex = 10;
    this.Label7.Text = "Amount:";
    this.comboDeposit_AmountOptions.CharacterCasing = CharacterCasing.Normal;
    ((UltraDropDownBase) this.comboDeposit_AmountOptions).DisplayMember = "";
    this.comboDeposit_AmountOptions.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboDeposit_AmountOptions).Location = new Point(104, 8);
    ((Control) this.comboDeposit_AmountOptions).Name = "comboDeposit_AmountOptions";
    this.comboDeposit_AmountOptions.SelectedIndex = -1;
    this.comboDeposit_AmountOptions.Value = (object) "";
    ((Control) this.comboDeposit_AmountOptions).Size = new Size(192 /*0xC0*/, 20);
    ((Control) this.comboDeposit_AmountOptions).TabIndex = 9;
    ((UltraDropDownBase) this.comboDeposit_AmountOptions).ValueMember = "";
    this.Label6.AutoSize = true;
    this.Label6.ForeColor = Color.Black;
    this.Label6.Location = new Point(8, 8);
    this.Label6.Name = "Label6";
    this.Label6.Size = new Size(89, 17);
    this.Label6.TabIndex = 3;
    this.Label6.Text = "Amount Options:";
    this.optionDeposit_DepositAmount.FlatStyle = FlatStyle.Flat;
    this.optionDeposit_DepositAmount.ForeColor = Color.Black;
    this.optionDeposit_DepositAmount.Location = new Point(24, 152);
    this.optionDeposit_DepositAmount.Name = "optionDeposit_DepositAmount";
    this.optionDeposit_DepositAmount.Size = new Size(160 /*0xA0*/, 24);
    this.optionDeposit_DepositAmount.TabIndex = 5;
    this.optionDeposit_DepositAmount.Text = "Search By Deposit Amount";
    this.optionDeposit_DepositDate.Checked = true;
    this.optionDeposit_DepositDate.FlatStyle = FlatStyle.Flat;
    this.optionDeposit_DepositDate.ForeColor = Color.Black;
    this.optionDeposit_DepositDate.Location = new Point(24, 40);
    this.optionDeposit_DepositDate.Name = "optionDeposit_DepositDate";
    this.optionDeposit_DepositDate.Size = new Size(160 /*0xA0*/, 16 /*0x10*/);
    this.optionDeposit_DepositDate.TabIndex = 4;
    this.optionDeposit_DepositDate.TabStop = true;
    this.optionDeposit_DepositDate.Text = "Search By Deposit Date";
    appearance8.BackColor = Color.Gainsboro;
    appearance8.BackColor2 = Color.White;
    appearance8.BackGradientStyle = (GradientStyle) 2;
    appearance8.BorderColor = Color.Gray;
    ((ControlBase) this.buttonSearchDeposit).Appearance = (AppearanceBase) appearance8;
    ((Control) this.buttonSearchDeposit).Location = new Point(176 /*0xB0*/, 352);
    ((Control) this.buttonSearchDeposit).Name = "buttonSearchDeposit";
    ((Control) this.buttonSearchDeposit).Size = new Size(96 /*0x60*/, 24);
    ((Control) this.buttonSearchDeposit).TabIndex = 2;
    ((ControlBase) this.buttonSearchDeposit).Text = "Execute Search";
    this.Label5.AutoSize = true;
    this.Label5.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label5.ForeColor = Color.Navy;
    this.Label5.Location = new Point(8, 8);
    this.Label5.Name = "Label5";
    this.Label5.Size = new Size(187, 23);
    this.Label5.TabIndex = 0;
    this.Label5.Text = "Deposit - Search Options";
    this.Panel1.BackgroundImage = (Image) resourceManager.GetObject("Panel1.BackgroundImage");
    this.Panel1.Controls.Add((Control) this.Panel2);
    this.Panel1.Dock = DockStyle.Top;
    this.Panel1.Location = new Point(0, 0);
    this.Panel1.Name = "Panel1";
    this.Panel1.Size = new Size(434, 80 /*0x50*/);
    this.Panel1.TabIndex = 0;
    this.Panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.Panel2.BackColor = Color.Transparent;
    this.Panel2.BackgroundImage = (Image) resourceManager.GetObject("Panel2.BackgroundImage");
    this.Panel2.Controls.Add((Control) this.Label1);
    this.Panel2.Controls.Add((Control) this.comboSearchFor);
    this.Panel2.Controls.Add((Control) this.PictureBox1);
    this.Panel2.Controls.Add((Control) this.Label3);
    this.Panel2.Location = new Point(8, 8);
    this.Panel2.Name = "Panel2";
    this.Panel2.Size = new Size(416, 64 /*0x40*/);
    this.Panel2.TabIndex = 11;
    this.Label1.AutoSize = true;
    this.Label1.BackColor = Color.Transparent;
    this.Label1.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label1.ForeColor = Color.White;
    this.Label1.Location = new Point(8, 36);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(62, 17);
    this.Label1.TabIndex = 12;
    this.Label1.Text = "Search For:";
    this.comboSearchFor.CharacterCasing = CharacterCasing.Normal;
    ((UltraDropDownBase) this.comboSearchFor).DisplayMember = "";
    this.comboSearchFor.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboSearchFor).Location = new Point(88, 36);
    ((Control) this.comboSearchFor).Name = "comboSearchFor";
    this.comboSearchFor.SelectedIndex = -1;
    this.comboSearchFor.Value = (object) "";
    ((Control) this.comboSearchFor).Size = new Size(288, 20);
    ((Control) this.comboSearchFor).TabIndex = 11;
    ((UltraDropDownBase) this.comboSearchFor).ValueMember = "";
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.ClientSize = new Size(434, 464);
    this.ControlBox = false;
    this.Controls.Add((Control) this.panelDepositSearchOptions);
    this.Controls.Add((Control) this.panelCheckSearchOptions);
    this.Controls.Add((Control) this.panelCashReceiptSearchOptions);
    this.Controls.Add((Control) this.Panel1);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.Name = nameof (frmSearchDeposit);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Banking - Search Deposit/Check/Cash Receipt";
    this.panelCheckSearchOptions.ResumeLayout(false);
    this.panelCheckNumberOptions.ResumeLayout(false);
    ((ISupportInitialize) this.textboxCheckNumber).EndInit();
    this.panelCheckPayeeOptions.ResumeLayout(false);
    ((ISupportInitialize) this.txtCheckPayeeName).EndInit();
    this.panelCheckDateOptions.ResumeLayout(false);
    ((ISupportInitialize) this.dateTimeCheckDate).EndInit();
    ((ISupportInitialize) this.comboCheckDateOptions).EndInit();
    this.panelCheckAmountOptions.ResumeLayout(false);
    ((ISupportInitialize) this.textboxCheckAmount).EndInit();
    ((ISupportInitialize) this.comboCheckAmountOptions).EndInit();
    this.panelCashReceiptSearchOptions.ResumeLayout(false);
    this.panelCashReceipt_CheckNumber.ResumeLayout(false);
    ((ISupportInitialize) this.textboxCashReceipt_CheckNumber).EndInit();
    this.panelCashReceipt_Remitter.ResumeLayout(false);
    ((ISupportInitialize) this.textboxCashReceipt_Remitter).EndInit();
    this.panelCashReceipt_DepositDate.ResumeLayout(false);
    ((ISupportInitialize) this.dateTimeCashReceipt_DepositDate).EndInit();
    ((ISupportInitialize) this.comboCashReceipt_DepositDateOptions).EndInit();
    this.panelCashReceipt_CheckAmount.ResumeLayout(false);
    ((ISupportInitialize) this.textboxCashReceipt_Amount).EndInit();
    ((ISupportInitialize) this.comboCashReceipt_AmountOptions).EndInit();
    this.panelDepositSearchOptions.ResumeLayout(false);
    this.panelDeposit_DepositDate.ResumeLayout(false);
    ((ISupportInitialize) this.dateTimeDepositDate).EndInit();
    ((ISupportInitialize) this.comboDepositDateOptions).EndInit();
    this.paneldeposit_DepositAmount.ResumeLayout(false);
    ((ISupportInitialize) this.textboxDeposit_Amount).EndInit();
    ((ISupportInitialize) this.comboDeposit_AmountOptions).EndInit();
    this.Panel1.ResumeLayout(false);
    this.Panel2.ResumeLayout(false);
    ((ISupportInitialize) this.comboSearchFor).EndInit();
    this.ResumeLayout(false);
  }

  private void CancelSearch(object sender, EventArgs e) => this.Close();

  private void SetPanelDataBindings()
  {
    this.panelCheckNumberOptions.DataBindings.Add("Enabled", (object) this.optionCheck_CheckNumber, "Checked");
    this.panelCheckDateOptions.DataBindings.Add("Enabled", (object) this.optionCheck_CheckDate, "Checked");
    this.panelCheckPayeeOptions.DataBindings.Add("Enabled", (object) this.optionCheck_Payee, "Checked");
    this.panelCheckAmountOptions.DataBindings.Add("Enabled", (object) this.optionCheck_CheckAmount, "Checked");
    this.panelCashReceipt_CheckAmount.DataBindings.Add("Enabled", (object) this.optionCashReceipt_CheckAmount, "Checked");
    this.panelCashReceipt_CheckNumber.DataBindings.Add("Enabled", (object) this.optionCashReceipt_CheckNumber, "Checked");
    this.panelCashReceipt_DepositDate.DataBindings.Add("Enabled", (object) this.optionCashReceipt_DepositDate, "Checked");
    this.panelCashReceipt_Remitter.DataBindings.Add("Enabled", (object) this.optionCashReceipt_Remitter, "Checked");
    this.paneldeposit_DepositAmount.DataBindings.Add("Enabled", (object) this.optionDeposit_DepositAmount, "Checked");
    this.panelDeposit_DepositDate.DataBindings.Add("Enabled", (object) this.optionDeposit_DepositDate, "Checked");
  }

  private void BindSearchForCombo()
  {
    DataTable table = new DataTable();
    DataTable dataTable = table;
    dataTable.Columns.Add(new DataColumn("SearchCode", typeof (int)));
    dataTable.Columns.Add(new DataColumn("SearchBy", typeof (string)));
    DataRow row1 = table.NewRow();
    row1[0] = (object) 0;
    row1[1] = (object) "Check";
    table.Rows.Add(row1);
    DataRow row2 = table.NewRow();
    row2[0] = (object) 1;
    row2[1] = (object) "Deposit";
    table.Rows.Add(row2);
    DataRow row3 = table.NewRow();
    row3[0] = (object) 2;
    row3[1] = (object) "Cash Receipt";
    table.Rows.Add(row3);
    this.searchByDataset = new DataSet();
    this.searchByDataset.Tables.Add(table);
    ((UltraGridBase) this.comboSearchFor).DataSource = (object) this.searchByDataset;
    ((UltraDropDownBase) this.comboSearchFor).DisplayMember = "SearchBy";
    ((UltraDropDownBase) this.comboSearchFor).ValueMember = "SearchCode";
  }

  private void CreateOptionsDataSet()
  {
    DataTable table = new DataTable();
    DataTable dataTable = table;
    dataTable.Columns.Add(new DataColumn("OptionCode", typeof (string)));
    dataTable.Columns.Add(new DataColumn("OptionDescription", typeof (string)));
    DataRow row1 = table.NewRow();
    row1[0] = (object) "0";
    row1[1] = (object) "Less Than";
    table.Rows.Add(row1);
    DataRow row2 = table.NewRow();
    row2[0] = (object) "1";
    row2[1] = (object) "Less Than or Equal To";
    table.Rows.Add(row2);
    DataRow row3 = table.NewRow();
    row3[0] = (object) "2";
    row3[1] = (object) "Equal To";
    table.Rows.Add(row3);
    DataRow row4 = table.NewRow();
    row4[0] = (object) "3";
    row4[1] = (object) "Greater Than Or Equal To";
    table.Rows.Add(row4);
    DataRow row5 = table.NewRow();
    row5[0] = (object) "4";
    row5[1] = (object) "Greater Than";
    table.Rows.Add(row5);
    this.optionsDataset = new DataSet();
    this.optionsDataset.Tables.Add(table);
  }

  private void BindOptionsDropDowns()
  {
    this.CreateOptionsDataSet();
    MGASimpleComboBox receiptAmountOptions = this.comboCashReceipt_AmountOptions;
    ((UltraGridBase) this.comboCashReceipt_AmountOptions).DataSource = (object) this.optionsDataset;
    ((UltraDropDownBase) this.comboCashReceipt_AmountOptions).DisplayMember = "OptionDescription";
    ((UltraDropDownBase) this.comboCashReceipt_AmountOptions).ValueMember = "OptionCode";
    MGASimpleComboBox depositDateOptions1 = this.comboCashReceipt_DepositDateOptions;
    ((UltraGridBase) this.comboCashReceipt_DepositDateOptions).DataSource = (object) this.optionsDataset;
    ((UltraDropDownBase) this.comboCashReceipt_DepositDateOptions).DisplayMember = "OptionDescription";
    ((UltraDropDownBase) this.comboCashReceipt_DepositDateOptions).ValueMember = "OptionCode";
    MGASimpleComboBox checkAmountOptions = this.comboCheckAmountOptions;
    ((UltraGridBase) this.comboCheckAmountOptions).DataSource = (object) this.optionsDataset;
    ((UltraDropDownBase) this.comboCheckAmountOptions).DisplayMember = "OptionDescription";
    ((UltraDropDownBase) this.comboCheckAmountOptions).ValueMember = "OptionCode";
    MGASimpleComboBox checkDateOptions = this.comboCheckDateOptions;
    ((UltraGridBase) this.comboCheckDateOptions).DataSource = (object) this.optionsDataset;
    ((UltraDropDownBase) this.comboCheckDateOptions).DisplayMember = "OptionDescription";
    ((UltraDropDownBase) this.comboCheckDateOptions).ValueMember = "OptionCode";
    MGASimpleComboBox depositAmountOptions = this.comboDeposit_AmountOptions;
    ((UltraGridBase) this.comboDeposit_AmountOptions).DataSource = (object) this.optionsDataset;
    ((UltraDropDownBase) this.comboDeposit_AmountOptions).DisplayMember = "OptionDescription";
    ((UltraDropDownBase) this.comboDeposit_AmountOptions).ValueMember = "OptionCode";
    MGASimpleComboBox depositDateOptions2 = this.comboDepositDateOptions;
    ((UltraGridBase) this.comboDepositDateOptions).DataSource = (object) this.optionsDataset;
    ((UltraDropDownBase) this.comboDepositDateOptions).DisplayMember = "OptionDescription";
    ((UltraDropDownBase) this.comboDepositDateOptions).ValueMember = "OptionCode";
  }

  private void comboSearchFor_RowSelected(object sender, RowSelectedEventArgs e)
  {
    if (((UltraDropDownBase) this.comboSearchFor).SelectedRow == null)
      return;
    switch (Conversions.ToInteger(((UltraDropDownBase) this.comboSearchFor).SelectedRow.Cells["SearchCode"].Value))
    {
      case 0:
        this.CurrentSearchType = frmSearchDeposit.SearchType.Check;
        break;
      case 1:
        this.CurrentSearchType = frmSearchDeposit.SearchType.Deposit;
        break;
      case 2:
        this.CurrentSearchType = frmSearchDeposit.SearchType.CashReceipt;
        break;
    }
    this.panelCashReceiptSearchOptions.Visible = this.CurrentSearchType == frmSearchDeposit.SearchType.CashReceipt;
    this.panelCheckSearchOptions.Visible = this.CurrentSearchType == frmSearchDeposit.SearchType.Check;
    this.panelDepositSearchOptions.Visible = this.CurrentSearchType == frmSearchDeposit.SearchType.Deposit;
  }

  private void FormatCurrencyFields(object sender, CancelEventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((TextEditorControlBase) sender).Text, "", false) != 0 && Versioned.IsNumeric((object) ((TextEditorControlBase) sender).Text))
      ((TextEditorControlBase) sender).Text = Strings.Format((object) ((TextEditorControlBase) sender).Text, "Currency");
    else
      ((TextEditorControlBase) sender).Text = "$0.00";
  }

  private void SearchCheck()
  {
    Form form1 = (Form) null;
    Form[] mdiChildren = MDIControls.Instance.MDIParent.MdiChildren;
    int index = 0;
    while (index < mdiChildren.Length)
    {
      Form form2 = mdiChildren[index];
      if (form2 is frmBanking)
        form1 = form2;
      checked { ++index; }
    }
    if (form1 == null)
      return;
    switch (this.CurrentCheckSearchType)
    {
      case frmSearchDeposit.CheckSearchType.CheckNumber:
        UltraGrid gridRegister1 = ((frmBanking) form1)._BankAccountRegister.gridRegister;
        ((UltraGridBase) gridRegister1).DisplayLayout.Bands[0].ColumnFilters["checkorref"].FilterConditions.Clear();
        ((UltraGridBase) gridRegister1).DisplayLayout.Bands[0].ColumnFilters["trxtype"].FilterConditions.Clear();
        ((UltraGridBase) gridRegister1).DisplayLayout.Bands[0].ColumnFilters["trxtype"].FilterConditions.Add((FilterComparisionOperator) 0, (object) "P");
        ((UltraGridBase) gridRegister1).DisplayLayout.Bands[0].Override.RowFilterMode = (RowFilterMode) 1;
        ((UltraGridBase) gridRegister1).DisplayLayout.Bands[0].ColumnFilters["checkorref"].FilterConditions.Add((FilterComparisionOperator) 0, (object) ((TextEditorControlBase) this.textboxCheckNumber).Text);
        ((frmBanking) form1)._BankAccountRegister.DisplayRemoveSearchFilter();
        break;
      case frmSearchDeposit.CheckSearchType.Payee:
        DataTable Data = Database.Instance.QuerySP.PerformTableQuery("spFin_SearchChecks_Payee", (object) "@bankacctgl", (object) this.BankAccountGL, (object) "@payeeguid", (object) new Guid(((Control) this.txtCheckPayeeName).Tag.ToString()));
        if (Data != null && Data.Rows.Count > 0)
        {
          UltraGrid gridRegister2 = ((frmBanking) form1)._BankAccountRegister.gridRegister;
          ((UltraGridBase) gridRegister2).DisplayLayout.Bands[0].ColumnFilters["checkorref"].FilterConditions.Clear();
          ((UltraGridBase) gridRegister2).DisplayLayout.Bands[0].ColumnFilters["trxtype"].FilterConditions.Clear();
          ((UltraGridBase) gridRegister2).DisplayLayout.Bands[0].ColumnFilters["trxtype"].FilterConditions.Add((FilterComparisionOperator) 0, (object) "P");
          ((UltraGridBase) gridRegister2).DisplayLayout.Bands[0].ColumnFilters["checkorref"].FilterConditions.Add((FilterCondition) new frmSearchDeposit.CustomFilterObject(((UltraGridBase) gridRegister2).DisplayLayout.Bands[0].Columns["checkorref"], Data));
        }
        Data.Dispose();
        ((frmBanking) form1)._BankAccountRegister.DisplayRemoveSearchFilter();
        break;
      case frmSearchDeposit.CheckSearchType.CheckDate:
        UltraGrid gridRegister3 = ((frmBanking) form1)._BankAccountRegister.gridRegister;
        ((UltraGridBase) gridRegister3).DisplayLayout.Bands[0].ColumnFilters["transactionDate"].FilterConditions.Clear();
        ((UltraGridBase) gridRegister3).DisplayLayout.Bands[0].ColumnFilters["trxtype"].FilterConditions.Clear();
        ((UltraGridBase) gridRegister3).DisplayLayout.Bands[0].ColumnFilters["trxtype"].FilterConditions.Add((FilterComparisionOperator) 0, (object) "P");
        ((UltraGridBase) gridRegister3).DisplayLayout.Bands[0].Override.RowFilterMode = (RowFilterMode) 1;
        switch (Conversions.ToInteger(((UltraDropDownBase) this.comboCheckDateOptions).SelectedRow.Cells["OptionCode"].Value))
        {
          case 0:
            ((UltraGridBase) gridRegister3).DisplayLayout.Bands[0].ColumnFilters["transactionDate"].FilterConditions.Add((FilterComparisionOperator) 2, (object) this.dateTimeCheckDate.DateTime);
            break;
          case 1:
            ((UltraGridBase) gridRegister3).DisplayLayout.Bands[0].ColumnFilters["transactionDate"].FilterConditions.Add((FilterComparisionOperator) 3, (object) this.dateTimeCheckDate.DateTime);
            break;
          case 2:
            ((UltraGridBase) gridRegister3).DisplayLayout.Bands[0].ColumnFilters["transactionDate"].FilterConditions.Add((FilterComparisionOperator) 0, (object) this.dateTimeCheckDate.DateTime);
            break;
          case 3:
            ((UltraGridBase) gridRegister3).DisplayLayout.Bands[0].ColumnFilters["transactionDate"].FilterConditions.Add((FilterComparisionOperator) 5, (object) this.dateTimeCheckDate.DateTime);
            break;
          case 4:
            ((UltraGridBase) gridRegister3).DisplayLayout.Bands[0].ColumnFilters["transactionDate"].FilterConditions.Add((FilterComparisionOperator) 4, (object) this.dateTimeCheckDate.DateTime);
            break;
        }
        ((frmBanking) form1)._BankAccountRegister.DisplayRemoveSearchFilter();
        break;
      case frmSearchDeposit.CheckSearchType.CheckAmount:
        UltraGrid gridRegister4 = ((frmBanking) form1)._BankAccountRegister.gridRegister;
        ((UltraGridBase) gridRegister4).DisplayLayout.Bands[0].ColumnFilters["credit"].FilterConditions.Clear();
        ((UltraGridBase) gridRegister4).DisplayLayout.Bands[0].ColumnFilters["trxtype"].FilterConditions.Clear();
        ((UltraGridBase) gridRegister4).DisplayLayout.Bands[0].ColumnFilters["trxtype"].FilterConditions.Add((FilterComparisionOperator) 0, (object) "P");
        ((UltraGridBase) gridRegister4).DisplayLayout.Bands[0].Override.RowFilterMode = (RowFilterMode) 1;
        switch (Conversions.ToInteger(((UltraDropDownBase) this.comboCheckAmountOptions).SelectedRow.Cells["OptionCode"].Value))
        {
          case 0:
            ((UltraGridBase) gridRegister4).DisplayLayout.Bands[0].ColumnFilters["credit"].FilterConditions.Add((FilterComparisionOperator) 2, (object) Decimal.Multiply(Conversions.ToDecimal(((TextEditorControlBase) this.textboxCheckAmount).Text), -1M));
            break;
          case 1:
            ((UltraGridBase) gridRegister4).DisplayLayout.Bands[0].ColumnFilters["credit"].FilterConditions.Add((FilterComparisionOperator) 3, (object) Decimal.Multiply(Conversions.ToDecimal(((TextEditorControlBase) this.textboxCheckAmount).Text), -1M));
            break;
          case 2:
            ((UltraGridBase) gridRegister4).DisplayLayout.Bands[0].ColumnFilters["credit"].FilterConditions.Add((FilterComparisionOperator) 0, (object) Decimal.Multiply(Conversions.ToDecimal(((TextEditorControlBase) this.textboxCheckAmount).Text), -1M));
            break;
          case 3:
            ((UltraGridBase) gridRegister4).DisplayLayout.Bands[0].ColumnFilters["credit"].FilterConditions.Add((FilterComparisionOperator) 5, (object) Decimal.Multiply(Conversions.ToDecimal(((TextEditorControlBase) this.textboxCheckAmount).Text), -1M));
            break;
          case 4:
            ((UltraGridBase) gridRegister4).DisplayLayout.Bands[0].ColumnFilters["credit"].FilterConditions.Add((FilterComparisionOperator) 4, (object) Decimal.Multiply(Conversions.ToDecimal(((TextEditorControlBase) this.textboxCheckAmount).Text), -1M));
            break;
        }
        ((frmBanking) form1)._BankAccountRegister.DisplayRemoveSearchFilter();
        break;
    }
  }

  private bool ValidateCheckSearch()
  {
    bool flag;
    switch (this.CurrentCheckSearchType)
    {
      case frmSearchDeposit.CheckSearchType.CheckNumber:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((TextEditorControlBase) this.textboxCheckNumber).Text, "", false) == 0)
        {
          int num = (int) MessageBox.Show("You must select a valid check number to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          ((TextEditorControlBase) this.textboxCheckNumber).Focus();
          flag = false;
          break;
        }
        goto default;
      case frmSearchDeposit.CheckSearchType.Payee:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((TextEditorControlBase) this.txtCheckPayeeName).Text, "", false) == 0 || ((Control) this.txtCheckPayeeName).Tag == null)
        {
          int num = (int) MessageBox.Show("You must select a payee to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          ((Control) this.buttonSearchCheckPayee).Focus();
          flag = false;
          break;
        }
        goto default;
      case frmSearchDeposit.CheckSearchType.CheckDate:
        if (((UltraDropDownBase) this.comboCheckDateOptions).SelectedRow == null)
        {
          int num = (int) MessageBox.Show("You must select a valid check date option to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          this.comboCheckDateOptions.Focus();
          flag = false;
          break;
        }
        if (this.dateTimeCheckDate.DateTime.Equals((object) DBNull.Value))
        {
          int num = (int) MessageBox.Show("You must select a valid check date to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          ((Control) this.dateTimeCheckDate).Focus();
          flag = false;
          break;
        }
        goto default;
      case frmSearchDeposit.CheckSearchType.CheckAmount:
        if (((UltraDropDownBase) this.comboCheckAmountOptions).SelectedRow == null)
        {
          int num = (int) MessageBox.Show("You must select a valid amount option to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          this.comboCheckAmountOptions.Focus();
          flag = false;
          break;
        }
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((TextEditorControlBase) this.textboxCheckAmount).Text, "", false) == 0)
        {
          int num = (int) MessageBox.Show("You must enter a check amount to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          ((TextEditorControlBase) this.textboxCheckAmount).Focus();
          flag = false;
          break;
        }
        goto default;
      default:
        flag = true;
        break;
    }
    return flag;
  }

  private void ExecuteSearch(object sender, EventArgs e)
  {
    if (sender == this.buttonSearchCheck)
    {
      if (!this.ValidateCheckSearch())
        return;
      this.SearchCheck();
    }
    if (sender == this.buttonCashReceipt_ExecuteSearch)
    {
      if (!this.ValidateCashReceiptSearch())
        return;
      this.SearchCashReceipt();
    }
    if (sender == this.buttonSearchDeposit)
    {
      if (!this.ValidateDepositSearch())
        return;
      this.SearchDeposit();
    }
    this.Close();
  }

  private void CheckOptionChanged(object sender, EventArgs e)
  {
    if (sender == this.optionCheck_CheckAmount)
      this.CurrentCheckSearchType = frmSearchDeposit.CheckSearchType.CheckAmount;
    if (sender == this.optionCheck_CheckDate)
      this.CurrentCheckSearchType = frmSearchDeposit.CheckSearchType.CheckDate;
    if (sender == this.optionCheck_CheckNumber)
      this.CurrentCheckSearchType = frmSearchDeposit.CheckSearchType.CheckNumber;
    if (sender != this.optionCheck_Payee)
      return;
    this.CurrentCheckSearchType = frmSearchDeposit.CheckSearchType.Payee;
  }

  private void SearchEntity(object sender, EventArgs e)
  {
    FormSearchEntity formSearchEntity = new FormSearchEntity(MGASystems.IMS.Accounting.Core.ClassObjects.Utility.SearchEntityTypes.All);
    try
    {
      if (formSearchEntity.ShowDialog() != DialogResult.OK)
        return;
      if (sender == this.buttonSearchCheckPayee)
      {
        ((TextEditorControlBase) this.txtCheckPayeeName).Text = formSearchEntity.EntityName;
        ((Control) this.txtCheckPayeeName).Tag = (object) formSearchEntity.EntityGuid;
      }
      else
      {
        if (sender != this.buttonCashReceipt_SearchRemitter)
          return;
        ((TextEditorControlBase) this.textboxCashReceipt_Remitter).Text = formSearchEntity.EntityName;
        ((Control) this.textboxCashReceipt_Remitter).Tag = (object) formSearchEntity.EntityGuid;
      }
    }
    finally
    {
      formSearchEntity.Dispose();
    }
  }

  private void SearchCashReceipt()
  {
    Form form1 = (Form) null;
    Form[] mdiChildren = MDIControls.Instance.MDIParent.MdiChildren;
    int index = 0;
    while (index < mdiChildren.Length)
    {
      Form form2 = mdiChildren[index];
      if (form2 is frmBanking)
        form1 = form2;
      checked { ++index; }
    }
    if (form1 == null)
      return;
    ((UltraGridBase) ((frmBanking) form1)._BankAccountRegister.gridRegister).DisplayLayout.Bands[0].ColumnFilters.ClearAllFilters();
    switch (this.CurrentCashReceiptSearchType)
    {
      case frmSearchDeposit.CashReceiptSearchType.CheckNumber:
        UltraGrid gridRegister1 = ((frmBanking) form1)._BankAccountRegister.gridRegister;
        try
        {
          this.Cursor = Cursors.WaitCursor;
          DataTable Data = Database.Instance.QuerySP.PerformTableQuery("spFin_SearchCashReceipt_CheckNumber", (object) "@bankAcctGl", (object) this.BankAccountGL, (object) "@checkNumber", (object) ((TextEditorControlBase) this.textboxCashReceipt_CheckNumber).Text);
          if (Data == null || Data.Rows.Count == 0)
          {
            int num = (int) MessageBox.Show("The system cound not find any cash receipts that have been grouped into a deposit that match the current search criteria.", "No Cash Receipts Found!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            if (Data == null)
              break;
            Data.Dispose();
            break;
          }
          ((UltraGridBase) gridRegister1).DisplayLayout.Bands[0].ColumnFilters["trxtype"].FilterConditions.Clear();
          ((UltraGridBase) gridRegister1).DisplayLayout.Bands[0].ColumnFilters["trxtype"].FilterConditions.Add((FilterComparisionOperator) 0, (object) "D");
          ((UltraGridBase) gridRegister1).DisplayLayout.Bands[0].Override.RowFilterMode = (RowFilterMode) 1;
          ((UltraGridBase) gridRegister1).DisplayLayout.Bands[0].ColumnFilters["transactNum"].FilterConditions.Add((FilterCondition) new frmSearchDeposit.CustomFilterObject(((UltraGridBase) gridRegister1).DisplayLayout.Bands[0].Columns["transactNum"], Data));
        }
        finally
        {
          this.Cursor = Cursors.Default;
        }
        ((frmBanking) form1)._BankAccountRegister.DisplayRemoveSearchFilter();
        break;
      case frmSearchDeposit.CashReceiptSearchType.Remitter:
        UltraGrid gridRegister2 = ((frmBanking) form1)._BankAccountRegister.gridRegister;
        try
        {
          this.Cursor = Cursors.WaitCursor;
          DataTable Data = Database.Instance.QuerySP.PerformTableQuery("spFin_SearchCashReceipt_Remitter", (object) "@bankAcctGl", (object) this.BankAccountGL, (object) "@remitterGuid", (object) new Guid(((Control) this.textboxCashReceipt_Remitter).Tag.ToString()));
          if (Data == null || Data.Rows.Count == 0)
          {
            int num = (int) MessageBox.Show("The system cound not find any cash receipts that have been grouped into a deposit that match the current search criteria.", "No Cash Receipts Found!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            if (Data == null)
              break;
            Data.Dispose();
            break;
          }
          ((UltraGridBase) gridRegister2).DisplayLayout.Bands[0].ColumnFilters["trxtype"].FilterConditions.Clear();
          ((UltraGridBase) gridRegister2).DisplayLayout.Bands[0].ColumnFilters["trxtype"].FilterConditions.Add((FilterComparisionOperator) 0, (object) "D");
          ((UltraGridBase) gridRegister2).DisplayLayout.Bands[0].Override.RowFilterMode = (RowFilterMode) 1;
          ((UltraGridBase) gridRegister2).DisplayLayout.Bands[0].ColumnFilters["transactNum"].FilterConditions.Add((FilterCondition) new frmSearchDeposit.CustomFilterObject(((UltraGridBase) gridRegister2).DisplayLayout.Bands[0].Columns["transactNum"], Data));
        }
        finally
        {
          this.Cursor = Cursors.Default;
        }
        ((frmBanking) form1)._BankAccountRegister.DisplayRemoveSearchFilter();
        break;
      case frmSearchDeposit.CashReceiptSearchType.DepositDate:
        UltraGrid gridRegister3 = ((frmBanking) form1)._BankAccountRegister.gridRegister;
        try
        {
          this.Cursor = Cursors.WaitCursor;
          DataTable Data = Database.Instance.QuerySP.PerformTableQuery("spFin_SearchCashReceipt_DepositDate", (object) "@bankAcctGl", (object) this.BankAccountGL, (object) "@checkDate", (object) this.dateTimeCashReceipt_DepositDate.DateTime, (object) "@searchType", (object) Conversions.ToInteger(((UltraDropDownBase) this.comboCashReceipt_DepositDateOptions).SelectedRow.Cells["OptionCode"].Value));
          if (Data == null || Data.Rows.Count == 0)
          {
            int num = (int) MessageBox.Show("The system cound not find any cash receipts that have been grouped into a deposit that match the current search criteria.", "No Cash Receipts Found!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            if (Data == null)
              break;
            Data.Dispose();
            break;
          }
          ((UltraGridBase) gridRegister3).DisplayLayout.Bands[0].ColumnFilters["trxtype"].FilterConditions.Clear();
          ((UltraGridBase) gridRegister3).DisplayLayout.Bands[0].ColumnFilters["trxtype"].FilterConditions.Add((FilterComparisionOperator) 0, (object) "D");
          ((UltraGridBase) gridRegister3).DisplayLayout.Bands[0].Override.RowFilterMode = (RowFilterMode) 1;
          ((UltraGridBase) gridRegister3).DisplayLayout.Bands[0].ColumnFilters["transactNum"].FilterConditions.Add((FilterCondition) new frmSearchDeposit.CustomFilterObject(((UltraGridBase) gridRegister3).DisplayLayout.Bands[0].Columns["transactNum"], Data));
        }
        finally
        {
          this.Cursor = Cursors.Default;
        }
        ((frmBanking) form1)._BankAccountRegister.DisplayRemoveSearchFilter();
        break;
      case frmSearchDeposit.CashReceiptSearchType.CheckAmount:
        UltraGrid gridRegister4 = ((frmBanking) form1)._BankAccountRegister.gridRegister;
        try
        {
          this.Cursor = Cursors.WaitCursor;
          DataTable Data = Database.Instance.QuerySP.PerformTableQuery("spFin_SearchCashReceipt_CheckAmount", (object) "@bankAcctGl", (object) this.BankAccountGL, (object) "@checkAmount", (object) Conversions.ToDecimal(((TextEditorControlBase) this.textboxCashReceipt_Amount).Text), (object) "@searchType", (object) Conversions.ToInteger(((UltraDropDownBase) this.comboCashReceipt_AmountOptions).SelectedRow.Cells["OptionCode"].Value));
          if (Data == null || Data.Rows.Count == 0)
          {
            int num = (int) MessageBox.Show("The system cound not find any cash receipts that have been grouped into a deposit that match the current search criteria.", "No Cash Receipts Found!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            if (Data == null)
              break;
            Data.Dispose();
            break;
          }
          ((UltraGridBase) gridRegister4).DisplayLayout.Bands[0].ColumnFilters["trxtype"].FilterConditions.Clear();
          ((UltraGridBase) gridRegister4).DisplayLayout.Bands[0].ColumnFilters["trxtype"].FilterConditions.Add((FilterComparisionOperator) 0, (object) "D");
          ((UltraGridBase) gridRegister4).DisplayLayout.Bands[0].Override.RowFilterMode = (RowFilterMode) 1;
          ((UltraGridBase) gridRegister4).DisplayLayout.Bands[0].ColumnFilters["transactNum"].FilterConditions.Add((FilterCondition) new frmSearchDeposit.CustomFilterObject(((UltraGridBase) gridRegister4).DisplayLayout.Bands[0].Columns["transactNum"], Data));
        }
        finally
        {
          this.Cursor = Cursors.Default;
        }
        ((frmBanking) form1)._BankAccountRegister.DisplayRemoveSearchFilter();
        break;
    }
  }

  private bool ValidateCashReceiptSearch()
  {
    bool flag;
    switch (this.CurrentCashReceiptSearchType)
    {
      case frmSearchDeposit.CashReceiptSearchType.CheckNumber:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((TextEditorControlBase) this.textboxCashReceipt_CheckNumber).Text, "", false) == 0)
        {
          int num = (int) MessageBox.Show("You must enter a check number to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          ((TextEditorControlBase) this.textboxCashReceipt_CheckNumber).Focus();
          flag = false;
          break;
        }
        goto default;
      case frmSearchDeposit.CashReceiptSearchType.Remitter:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((TextEditorControlBase) this.textboxCashReceipt_Remitter).Text, "", false) == 0 || ((Control) this.textboxCashReceipt_Remitter).Tag == null)
        {
          int num = (int) MessageBox.Show("You must select remitter to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          ((Control) this.buttonCashReceipt_SearchRemitter).Focus();
          flag = false;
          break;
        }
        goto default;
      case frmSearchDeposit.CashReceiptSearchType.DepositDate:
        if (((UltraDropDownBase) this.comboCashReceipt_DepositDateOptions).SelectedRow == null)
        {
          int num = (int) MessageBox.Show("You must select a valid deposit date option to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          this.comboCashReceipt_DepositDateOptions.Focus();
          flag = false;
          break;
        }
        if (this.dateTimeCashReceipt_DepositDate.DateTime.Equals((object) DBNull.Value))
        {
          int num = (int) MessageBox.Show("You must select a valid deposit date to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          ((Control) this.dateTimeCashReceipt_DepositDate).Focus();
          flag = false;
          break;
        }
        goto default;
      case frmSearchDeposit.CashReceiptSearchType.CheckAmount:
        if (((UltraDropDownBase) this.comboCashReceipt_AmountOptions).SelectedRow == null)
        {
          int num = (int) MessageBox.Show("You must select a valid amount option to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          this.comboCashReceipt_AmountOptions.Focus();
          flag = false;
          break;
        }
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((TextEditorControlBase) this.textboxCashReceipt_Amount).Text, "", false) == 0)
        {
          int num = (int) MessageBox.Show("You must enter a check amount to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          ((TextEditorControlBase) this.textboxCashReceipt_Amount).Focus();
          flag = false;
          break;
        }
        goto default;
      default:
        flag = true;
        break;
    }
    return flag;
  }

  private void SearchDeposit()
  {
    Form form1 = (Form) null;
    Form[] mdiChildren = MDIControls.Instance.MDIParent.MdiChildren;
    int index = 0;
    while (index < mdiChildren.Length)
    {
      Form form2 = mdiChildren[index];
      if (form2 is frmBanking)
        form1 = form2;
      checked { ++index; }
    }
    if (form1 == null)
      return;
    ((UltraGridBase) ((frmBanking) form1)._BankAccountRegister.gridRegister).DisplayLayout.Bands[0].ColumnFilters.ClearAllFilters();
    switch (this.CurrentDepositSearchType)
    {
      case frmSearchDeposit.DepositSearchType.DepositDate:
        UltraGrid gridRegister1 = ((frmBanking) form1)._BankAccountRegister.gridRegister;
        ((UltraGridBase) gridRegister1).DisplayLayout.Bands[0].ColumnFilters["trxtype"].FilterConditions.Add((FilterComparisionOperator) 0, (object) "D");
        ((UltraGridBase) gridRegister1).DisplayLayout.Bands[0].Override.RowFilterMode = (RowFilterMode) 1;
        switch (Conversions.ToInteger(((UltraDropDownBase) this.comboDepositDateOptions).SelectedRow.Cells["OptionCode"].Value))
        {
          case 0:
            ((UltraGridBase) gridRegister1).DisplayLayout.Bands[0].ColumnFilters["transactionDate"].FilterConditions.Add((FilterComparisionOperator) 2, (object) this.dateTimeDepositDate.DateTime);
            break;
          case 1:
            ((UltraGridBase) gridRegister1).DisplayLayout.Bands[0].ColumnFilters["transactionDate"].FilterConditions.Add((FilterComparisionOperator) 3, (object) this.dateTimeDepositDate.DateTime);
            break;
          case 2:
            ((UltraGridBase) gridRegister1).DisplayLayout.Bands[0].ColumnFilters["transactionDate"].FilterConditions.Add((FilterComparisionOperator) 0, (object) this.dateTimeDepositDate.DateTime);
            break;
          case 3:
            ((UltraGridBase) gridRegister1).DisplayLayout.Bands[0].ColumnFilters["transactionDate"].FilterConditions.Add((FilterComparisionOperator) 5, (object) this.dateTimeDepositDate.DateTime);
            break;
          case 4:
            ((UltraGridBase) gridRegister1).DisplayLayout.Bands[0].ColumnFilters["transactionDate"].FilterConditions.Add((FilterComparisionOperator) 4, (object) this.dateTimeDepositDate.DateTime);
            break;
        }
        ((frmBanking) form1)._BankAccountRegister.DisplayRemoveSearchFilter();
        break;
      case frmSearchDeposit.DepositSearchType.DepositAmount:
        UltraGrid gridRegister2 = ((frmBanking) form1)._BankAccountRegister.gridRegister;
        ((UltraGridBase) gridRegister2).DisplayLayout.Bands[0].ColumnFilters["trxtype"].FilterConditions.Add((FilterComparisionOperator) 0, (object) "D");
        ((UltraGridBase) gridRegister2).DisplayLayout.Bands[0].Override.RowFilterMode = (RowFilterMode) 1;
        switch (Conversions.ToInteger(((UltraDropDownBase) this.comboDeposit_AmountOptions).SelectedRow.Cells["OptionCode"].Value))
        {
          case 0:
            ((UltraGridBase) gridRegister2).DisplayLayout.Bands[0].ColumnFilters["debit"].FilterConditions.Add((FilterComparisionOperator) 2, (object) Conversions.ToDecimal(((TextEditorControlBase) this.textboxDeposit_Amount).Text));
            break;
          case 1:
            ((UltraGridBase) gridRegister2).DisplayLayout.Bands[0].ColumnFilters["debit"].FilterConditions.Add((FilterComparisionOperator) 3, (object) Conversions.ToDecimal(((TextEditorControlBase) this.textboxDeposit_Amount).Text));
            break;
          case 2:
            ((UltraGridBase) gridRegister2).DisplayLayout.Bands[0].ColumnFilters["debit"].FilterConditions.Add((FilterComparisionOperator) 0, (object) Conversions.ToDecimal(((TextEditorControlBase) this.textboxDeposit_Amount).Text));
            break;
          case 3:
            ((UltraGridBase) gridRegister2).DisplayLayout.Bands[0].ColumnFilters["debit"].FilterConditions.Add((FilterComparisionOperator) 5, (object) Conversions.ToDecimal(((TextEditorControlBase) this.textboxDeposit_Amount).Text));
            break;
          case 4:
            ((UltraGridBase) gridRegister2).DisplayLayout.Bands[0].ColumnFilters["debit"].FilterConditions.Add((FilterComparisionOperator) 4, (object) Conversions.ToDecimal(((TextEditorControlBase) this.textboxDeposit_Amount).Text));
            break;
        }
        ((frmBanking) form1)._BankAccountRegister.DisplayRemoveSearchFilter();
        break;
    }
  }

  private void CashReceiptOptionChanged(object sender, EventArgs e)
  {
    if (sender == this.optionCashReceipt_CheckAmount)
      this.CurrentCashReceiptSearchType = frmSearchDeposit.CashReceiptSearchType.CheckAmount;
    if (sender == this.optionCashReceipt_CheckNumber)
      this.CurrentCashReceiptSearchType = frmSearchDeposit.CashReceiptSearchType.CheckNumber;
    if (sender == this.optionCashReceipt_DepositDate)
      this.CurrentCashReceiptSearchType = frmSearchDeposit.CashReceiptSearchType.DepositDate;
    if (sender != this.optionCashReceipt_Remitter)
      return;
    this.CurrentCashReceiptSearchType = frmSearchDeposit.CashReceiptSearchType.Remitter;
  }

  private void DepositOptionChanged(object sender, EventArgs e)
  {
    if (sender == this.optionDeposit_DepositAmount)
      this.CurrentDepositSearchType = frmSearchDeposit.DepositSearchType.DepositAmount;
    if (sender != this.optionDeposit_DepositDate)
      return;
    this.CurrentDepositSearchType = frmSearchDeposit.DepositSearchType.DepositDate;
  }

  private bool ValidateDepositSearch()
  {
    bool flag;
    switch (this.CurrentDepositSearchType)
    {
      case frmSearchDeposit.DepositSearchType.DepositDate:
        if (((UltraDropDownBase) this.comboDepositDateOptions).SelectedRow == null)
        {
          int num = (int) MessageBox.Show("You must select a valid deposit date option to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          this.comboDepositDateOptions.Focus();
          flag = false;
          break;
        }
        if (this.dateTimeDepositDate.DateTime.Equals((object) DBNull.Value))
        {
          int num = (int) MessageBox.Show("You must select a valid deposit date to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          ((Control) this.dateTimeDepositDate).Focus();
          flag = false;
          break;
        }
        goto default;
      case frmSearchDeposit.DepositSearchType.DepositAmount:
        if (((UltraDropDownBase) this.comboDeposit_AmountOptions).SelectedRow == null)
        {
          int num = (int) MessageBox.Show("You must select a valid amount option to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          this.comboDeposit_AmountOptions.Focus();
          flag = false;
          break;
        }
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((TextEditorControlBase) this.textboxDeposit_Amount).Text, "", false) == 0)
        {
          int num = (int) MessageBox.Show("You must enter a check amount to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          ((TextEditorControlBase) this.textboxDeposit_Amount).Focus();
          flag = false;
          break;
        }
        goto default;
      default:
        flag = true;
        break;
    }
    return flag;
  }

  private class CustomFilterObject : FilterCondition
  {
    private DataTable _data;

    public CustomFilterObject(UltraGridColumn column, DataTable Data)
      : base(column, (FilterComparisionOperator) 16 /*0x10*/, (object) null)
    {
      this._data = Data;
    }

    public CustomFilterObject(UltraGridColumn column, object value)
      : base(column, (FilterComparisionOperator) 16 /*0x10*/, RuntimeHelpers.GetObjectValue(value))
    {
    }

    protected override void OnDispose()
    {
    }

    public override bool MeetsCriteria(UltraGridRow row)
    {
      bool flag;
      try
      {
        foreach (DataRow row1 in this._data.Rows)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(row.Cells[this.Column.Key].Value.ToString(), row1[0].ToString(), false) == 0)
          {
            flag = true;
            goto label_8;
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
label_8:
      return flag;
    }
  }

  private enum SearchType
  {
    Check,
    Deposit,
    CashReceipt,
  }

  private enum CheckSearchType
  {
    CheckNumber,
    Payee,
    CheckDate,
    CheckAmount,
  }

  private enum CashReceiptSearchType
  {
    CheckNumber,
    Remitter,
    DepositDate,
    CheckAmount,
  }

  private enum DepositSearchType
  {
    DepositDate,
    DepositAmount,
  }

  private enum Options
  {
    LessThan,
    LessThanOrEqual,
    Equal,
    GreaterThanOrEqual,
    GreaterThan,
  }
}
