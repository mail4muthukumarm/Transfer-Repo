// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Banking.AcctCheckRegister
// Assembly: MgaSystems.IMS.Accounting.Banking, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: ED5B99DC-3DD2-44AB-BA36-49A11A94937D
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Banking.dll

using GrapeCity.ActiveReports;
using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using MGASystems.Common;
using MGASystems.Common.ErrorHandling;
using MGASystems.IMS.Accounting.AccountingDatasets;
using MGASystems.IMS.Accounting.Banking.Forms;
using MGASystems.IMS.Reporting;
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
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Banking;

public sealed class AcctCheckRegister : UserControl
{
  private IContainer components;
  private int _GLCompanyId;
  private string _connectionString;
  private int intPageNumber;
  private int intMaxPage;
  private int intRecordBuffer;
  private DataSet dsData;
  private AcctCheckRegister.SearchBy sbSearchBy;
  private int _BankGLAcct;
  protected const int CommandTimeout = 300;

  public AcctCheckRegister()
  {
    this.Load += new EventHandler(this.AcctCheckRegister_Load);
    this.dsData = new DataSet();
    this.InitializeComponent();
  }

  public AcctCheckRegister(int GLCompanyID)
  {
    this.Load += new EventHandler(this.AcctCheckRegister_Load);
    this.dsData = new DataSet();
    this.InitializeComponent();
    this._GLCompanyId = GLCompanyID;
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [field: AccessedThroughProperty("pictCheck1Background")]
  internal virtual PictureBox pictCheck1Background { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label2")]
  internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label3")]
  internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label4")]
  internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblCheck1Payee")]
  internal virtual Label lblCheck1Payee { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblCheck1AmountEnglish")]
  internal virtual Label lblCheck1AmountEnglish { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblCheck1MGAName")]
  internal virtual Label lblCheck1MGAName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblCheck1CheckNumber")]
  internal virtual Label lblCheck1CheckNumber { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblCheck1AmountCurrency")]
  internal virtual Label lblCheck1AmountCurrency { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label5")]
  internal virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblCheck1Date")]
  internal virtual Label lblCheck1Date { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label7")]
  internal virtual Label Label7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label8")]
  internal virtual Label Label8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblCheck1Status")]
  internal virtual Label lblCheck1Status { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblCheck1StatusOnText")]
  internal virtual Label lblCheck1StatusOnText { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label11")]
  internal virtual Label Label11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblCheck1StatusOnValue")]
  internal virtual Label lblCheck1StatusOnValue { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label10")]
  internal virtual Label Label10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label13")]
  internal virtual Label Label13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label14")]
  internal virtual Label Label14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label17")]
  internal virtual Label Label17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label19")]
  internal virtual Label Label19 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label24")]
  internal virtual Label Label24 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label25")]
  internal virtual Label Label25 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label26")]
  internal virtual Label Label26 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label29")]
  internal virtual Label Label29 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label31")]
  internal virtual Label Label31 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label32")]
  internal virtual Label Label32 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label35")]
  internal virtual Label Label35 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label37")]
  internal virtual Label Label37 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label42")]
  internal virtual Label Label42 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label43")]
  internal virtual Label Label43 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label44")]
  internal virtual Label Label44 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual Button btnNextPage
  {
    get => this._btnNextPage;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnNextPage_Click);
      Button btnNextPage1 = this._btnNextPage;
      if (btnNextPage1 != null)
        btnNextPage1.Click -= eventHandler;
      this._btnNextPage = value;
      Button btnNextPage2 = this._btnNextPage;
      if (btnNextPage2 == null)
        return;
      btnNextPage2.Click += eventHandler;
    }
  }

  internal virtual Button btnPreviousPage
  {
    get => this._btnPreviousPage;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnPreviousPage_Click);
      Button btnPreviousPage1 = this._btnPreviousPage;
      if (btnPreviousPage1 != null)
        btnPreviousPage1.Click -= eventHandler;
      this._btnPreviousPage = value;
      Button btnPreviousPage2 = this._btnPreviousPage;
      if (btnPreviousPage2 == null)
        return;
      btnPreviousPage2.Click += eventHandler;
    }
  }

  internal virtual Button btnPrint
  {
    get => this._btnPrint;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnPrint_Click);
      Button btnPrint1 = this._btnPrint;
      if (btnPrint1 != null)
        btnPrint1.Click -= eventHandler;
      this._btnPrint = value;
      Button btnPrint2 = this._btnPrint;
      if (btnPrint2 == null)
        return;
      btnPrint2.Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("lblCheck2StatusOnValue")]
  internal virtual Label lblCheck2StatusOnValue { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblCheck2StatusOnText")]
  internal virtual Label lblCheck2StatusOnText { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblCheck2Status")]
  internal virtual Label lblCheck2Status { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblCheck2Date")]
  internal virtual Label lblCheck2Date { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblCheck2AmountCurrency")]
  internal virtual Label lblCheck2AmountCurrency { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblCheck2CheckNumber")]
  internal virtual Label lblCheck2CheckNumber { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblCheck2Payee")]
  internal virtual Label lblCheck2Payee { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblCheck2AmountEnglish")]
  internal virtual Label lblCheck2AmountEnglish { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblCheck2MGAName")]
  internal virtual Label lblCheck2MGAName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblCheck3Date")]
  internal virtual Label lblCheck3Date { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblCheck3CheckNumber")]
  internal virtual Label lblCheck3CheckNumber { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblCheck3Payee")]
  internal virtual Label lblCheck3Payee { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblCheck3MGAName")]
  internal virtual Label lblCheck3MGAName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblCheck3StatusOnValue")]
  internal virtual Label lblCheck3StatusOnValue { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblCheck3StatusOnText")]
  internal virtual Label lblCheck3StatusOnText { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblCheck3Status")]
  internal virtual Label lblCheck3Status { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblCheck3AmountCurrency")]
  internal virtual Label lblCheck3AmountCurrency { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblCheck3AmountEnglish")]
  internal virtual Label lblCheck3AmountEnglish { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("panelCheck1")]
  internal virtual Panel panelCheck1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("panelCheck2")]
  internal virtual Panel panelCheck2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("pictCheck2Background")]
  internal virtual PictureBox pictCheck2Background { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("panelCheck3")]
  internal virtual Panel panelCheck3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("pictCheck3Background")]
  internal virtual PictureBox pictCheck3Background { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblPageN_OF_M")]
  internal virtual Label lblPageN_OF_M { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label9")]
  internal virtual Label Label9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("GroupBox1")]
  internal virtual GroupBox GroupBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cmbSearchBy")]
  internal virtual ComboBox cmbSearchBy { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtSearchFor")]
  internal virtual TextBox txtSearchFor { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual Button btnSearch
  {
    get => this._btnSearch;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnSearch_Click);
      Button btnSearch1 = this._btnSearch;
      if (btnSearch1 != null)
        btnSearch1.Click -= eventHandler;
      this._btnSearch = value;
      Button btnSearch2 = this._btnSearch;
      if (btnSearch2 == null)
        return;
      btnSearch2.Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("pic1SearchCheckNum")]
  internal virtual PictureBox pic1SearchCheckNum { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("pic1SearchPayee")]
  internal virtual PictureBox pic1SearchPayee { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("pic1SearchDate")]
  internal virtual PictureBox pic1SearchDate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("pic2SearchCheckNum")]
  internal virtual PictureBox pic2SearchCheckNum { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("pic3SearchCheckNum")]
  internal virtual PictureBox pic3SearchCheckNum { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("pic2SearchDate")]
  internal virtual PictureBox pic2SearchDate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("pic2SearchPayee")]
  internal virtual PictureBox pic2SearchPayee { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("pic3SearchDate")]
  internal virtual PictureBox pic3SearchDate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("pic3SearchPayee")]
  internal virtual PictureBox pic3SearchPayee { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblCheck1BankName")]
  internal virtual Label lblCheck1BankName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblCheck2BankName")]
  internal virtual Label lblCheck2BankName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblCheck3BankName")]
  internal virtual Label lblCheck3BankName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblCheck3BankAddress")]
  internal virtual Label lblCheck3BankAddress { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblCheck1BankAddress")]
  internal virtual Label lblCheck1BankAddress { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblCheck2BankAddress")]
  internal virtual Label lblCheck2BankAddress { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label12")]
  internal virtual Label Label12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label15")]
  internal virtual Label Label15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label18")]
  internal virtual Label Label18 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual PictureBox picViewTransferForm1
  {
    get => this._picViewTransferForm1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ViewTransferFax);
      PictureBox viewTransferForm1_1 = this._picViewTransferForm1;
      if (viewTransferForm1_1 != null)
        viewTransferForm1_1.Click -= eventHandler;
      this._picViewTransferForm1 = value;
      PictureBox viewTransferForm1_2 = this._picViewTransferForm1;
      if (viewTransferForm1_2 == null)
        return;
      viewTransferForm1_2.Click += eventHandler;
    }
  }

  internal virtual PictureBox picViewTransferForm2
  {
    get => this._picViewTransferForm2;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ViewTransferFax);
      PictureBox viewTransferForm2_1 = this._picViewTransferForm2;
      if (viewTransferForm2_1 != null)
        viewTransferForm2_1.Click -= eventHandler;
      this._picViewTransferForm2 = value;
      PictureBox viewTransferForm2_2 = this._picViewTransferForm2;
      if (viewTransferForm2_2 == null)
        return;
      viewTransferForm2_2.Click += eventHandler;
    }
  }

  internal virtual PictureBox picViewTransferForm3
  {
    get => this._picViewTransferForm3;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ViewTransferFax);
      PictureBox viewTransferForm3_1 = this._picViewTransferForm3;
      if (viewTransferForm3_1 != null)
        viewTransferForm3_1.Click -= eventHandler;
      this._picViewTransferForm3 = value;
      PictureBox viewTransferForm3_2 = this._picViewTransferForm3;
      if (viewTransferForm3_2 == null)
        return;
      viewTransferForm3_2.Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("ToolTip1")]
  internal virtual ToolTip ToolTip1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual Label lblVoid1
  {
    get => this._lblVoid1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.VoidLabelMouseOver);
      EventHandler eventHandler2 = new EventHandler(this.VoidLabelMouseOut);
      Label lblVoid1_1 = this._lblVoid1;
      if (lblVoid1_1 != null)
      {
        lblVoid1_1.MouseEnter -= eventHandler1;
        lblVoid1_1.MouseLeave -= eventHandler2;
      }
      this._lblVoid1 = value;
      Label lblVoid1_2 = this._lblVoid1;
      if (lblVoid1_2 == null)
        return;
      lblVoid1_2.MouseEnter += eventHandler1;
      lblVoid1_2.MouseLeave += eventHandler2;
    }
  }

  internal virtual Label lblVoid2
  {
    get => this._lblVoid2;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.VoidLabelMouseOver);
      EventHandler eventHandler2 = new EventHandler(this.VoidLabelMouseOut);
      Label lblVoid2_1 = this._lblVoid2;
      if (lblVoid2_1 != null)
      {
        lblVoid2_1.MouseEnter -= eventHandler1;
        lblVoid2_1.MouseLeave -= eventHandler2;
      }
      this._lblVoid2 = value;
      Label lblVoid2_2 = this._lblVoid2;
      if (lblVoid2_2 == null)
        return;
      lblVoid2_2.MouseEnter += eventHandler1;
      lblVoid2_2.MouseLeave += eventHandler2;
    }
  }

  internal virtual Label lblVoid3
  {
    get => this._lblVoid3;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.VoidLabelMouseOver);
      EventHandler eventHandler2 = new EventHandler(this.VoidLabelMouseOut);
      Label lblVoid3_1 = this._lblVoid3;
      if (lblVoid3_1 != null)
      {
        lblVoid3_1.MouseEnter -= eventHandler1;
        lblVoid3_1.MouseLeave -= eventHandler2;
      }
      this._lblVoid3 = value;
      Label lblVoid3_2 = this._lblVoid3;
      if (lblVoid3_2 == null)
        return;
      lblVoid3_2.MouseEnter += eventHandler1;
      lblVoid3_2.MouseLeave += eventHandler2;
    }
  }

  [field: AccessedThroughProperty("txtTransactNum1")]
  internal virtual TextBox txtTransactNum1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtTransactNum2")]
  internal virtual TextBox txtTransactNum2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtTransactNum3")]
  internal virtual TextBox txtTransactNum3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual Label lblVoidCheck2
  {
    get => this._lblVoidCheck2;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.VoidCheck);
      Label lblVoidCheck2_1 = this._lblVoidCheck2;
      if (lblVoidCheck2_1 != null)
        lblVoidCheck2_1.Click -= eventHandler;
      this._lblVoidCheck2 = value;
      Label lblVoidCheck2_2 = this._lblVoidCheck2;
      if (lblVoidCheck2_2 == null)
        return;
      lblVoidCheck2_2.Click += eventHandler;
    }
  }

  internal virtual Label lblVoidCheck1
  {
    get => this._lblVoidCheck1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.VoidCheck);
      Label lblVoidCheck1_1 = this._lblVoidCheck1;
      if (lblVoidCheck1_1 != null)
        lblVoidCheck1_1.Click -= eventHandler;
      this._lblVoidCheck1 = value;
      Label lblVoidCheck1_2 = this._lblVoidCheck1;
      if (lblVoidCheck1_2 == null)
        return;
      lblVoidCheck1_2.Click += eventHandler;
    }
  }

  internal virtual Label lblVoidCheck3
  {
    get => this._lblVoidCheck3;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.VoidCheck);
      Label lblVoidCheck3_1 = this._lblVoidCheck3;
      if (lblVoidCheck3_1 != null)
        lblVoidCheck3_1.Click -= eventHandler;
      this._lblVoidCheck3 = value;
      Label lblVoidCheck3_2 = this._lblVoidCheck3;
      if (lblVoidCheck3_2 == null)
        return;
      lblVoidCheck3_2.Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("daGetBankAccounts")]
  internal virtual SqlDataAdapter daGetBankAccounts { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ControlDataConnection")]
  internal virtual SqlConnection ControlDataConnection { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlSelectCommand1")]
  internal virtual SqlCommand SqlSelectCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("DsBankAccounts1")]
  internal virtual dsBankAccounts DsBankAccounts1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label6")]
  internal virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual UltraCombo cmbBankAccounts
  {
    get => this._cmbBankAccounts;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      RowSelectedEventHandler selectedEventHandler = new RowSelectedEventHandler(this.cmbBankAccounts_RowSelected);
      UltraCombo cmbBankAccounts1 = this._cmbBankAccounts;
      if (cmbBankAccounts1 != null)
        cmbBankAccounts1.RowSelected -= selectedEventHandler;
      this._cmbBankAccounts = value;
      UltraCombo cmbBankAccounts2 = this._cmbBankAccounts;
      if (cmbBankAccounts2 == null)
        return;
      cmbBankAccounts2.RowSelected += selectedEventHandler;
    }
  }

  [field: AccessedThroughProperty("Panel1")]
  internal virtual Panel Panel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Panel2")]
  internal virtual Panel Panel2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    ResourceManager resourceManager = new ResourceManager(typeof (AcctCheckRegister));
    Appearance appearance1 = new Appearance();
    UltraGridBand ultraGridBand = new UltraGridBand("spFin_GetBankAccounts", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("GLACCTID");
    Appearance appearance2 = new Appearance();
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("BANKNAME");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("CLOSED");
    this.panelCheck1 = new Panel();
    this.lblVoidCheck1 = new Label();
    this.txtTransactNum1 = new TextBox();
    this.lblVoid1 = new Label();
    this.picViewTransferForm1 = new PictureBox();
    this.Label12 = new Label();
    this.lblCheck1BankAddress = new Label();
    this.Label4 = new Label();
    this.lblCheck1BankName = new Label();
    this.pic1SearchDate = new PictureBox();
    this.pic1SearchPayee = new PictureBox();
    this.pic1SearchCheckNum = new PictureBox();
    this.lblCheck1StatusOnValue = new Label();
    this.Label11 = new Label();
    this.lblCheck1StatusOnText = new Label();
    this.Label8 = new Label();
    this.Label7 = new Label();
    this.lblCheck1Status = new Label();
    this.Label5 = new Label();
    this.lblCheck1Date = new Label();
    this.Label1 = new Label();
    this.lblCheck1AmountCurrency = new Label();
    this.lblCheck1CheckNumber = new Label();
    this.lblCheck1Payee = new Label();
    this.lblCheck1AmountEnglish = new Label();
    this.Label3 = new Label();
    this.Label2 = new Label();
    this.lblCheck1MGAName = new Label();
    this.pictCheck1Background = new PictureBox();
    this.panelCheck2 = new Panel();
    this.lblVoidCheck2 = new Label();
    this.txtTransactNum2 = new TextBox();
    this.lblVoid2 = new Label();
    this.picViewTransferForm2 = new PictureBox();
    this.Label15 = new Label();
    this.lblCheck2BankAddress = new Label();
    this.lblCheck2BankName = new Label();
    this.pic2SearchDate = new PictureBox();
    this.pic2SearchPayee = new PictureBox();
    this.pic2SearchCheckNum = new PictureBox();
    this.lblCheck2StatusOnValue = new Label();
    this.Label10 = new Label();
    this.lblCheck2StatusOnText = new Label();
    this.Label13 = new Label();
    this.Label14 = new Label();
    this.lblCheck2Status = new Label();
    this.Label17 = new Label();
    this.lblCheck2Date = new Label();
    this.Label19 = new Label();
    this.lblCheck2AmountCurrency = new Label();
    this.lblCheck2CheckNumber = new Label();
    this.lblCheck2Payee = new Label();
    this.lblCheck2AmountEnglish = new Label();
    this.Label24 = new Label();
    this.Label25 = new Label();
    this.Label26 = new Label();
    this.lblCheck2MGAName = new Label();
    this.pictCheck2Background = new PictureBox();
    this.panelCheck3 = new Panel();
    this.lblVoidCheck3 = new Label();
    this.txtTransactNum3 = new TextBox();
    this.lblVoid3 = new Label();
    this.picViewTransferForm3 = new PictureBox();
    this.Label18 = new Label();
    this.lblCheck3BankAddress = new Label();
    this.lblCheck3BankName = new Label();
    this.pic3SearchDate = new PictureBox();
    this.pic3SearchPayee = new PictureBox();
    this.pic3SearchCheckNum = new PictureBox();
    this.lblCheck3StatusOnValue = new Label();
    this.Label29 = new Label();
    this.lblCheck3StatusOnText = new Label();
    this.Label31 = new Label();
    this.Label32 = new Label();
    this.lblCheck3Status = new Label();
    this.Label35 = new Label();
    this.lblCheck3Date = new Label();
    this.Label37 = new Label();
    this.lblCheck3AmountCurrency = new Label();
    this.lblCheck3CheckNumber = new Label();
    this.lblCheck3Payee = new Label();
    this.lblCheck3AmountEnglish = new Label();
    this.Label42 = new Label();
    this.Label43 = new Label();
    this.Label44 = new Label();
    this.lblCheck3MGAName = new Label();
    this.pictCheck3Background = new PictureBox();
    this.btnNextPage = new Button();
    this.btnPreviousPage = new Button();
    this.btnPrint = new Button();
    this.lblPageN_OF_M = new Label();
    this.Label9 = new Label();
    this.GroupBox1 = new GroupBox();
    this.btnSearch = new Button();
    this.txtSearchFor = new TextBox();
    this.cmbSearchBy = new ComboBox();
    this.ToolTip1 = new ToolTip(this.components);
    this.cmbBankAccounts = new UltraCombo();
    this.daGetBankAccounts = new SqlDataAdapter();
    this.ControlDataConnection = new SqlConnection();
    this.SqlSelectCommand1 = new SqlCommand();
    this.DsBankAccounts1 = new dsBankAccounts();
    this.Label6 = new Label();
    this.Panel1 = new Panel();
    this.Panel2 = new Panel();
    this.panelCheck1.SuspendLayout();
    this.panelCheck2.SuspendLayout();
    this.panelCheck3.SuspendLayout();
    this.GroupBox1.SuspendLayout();
    ((ISupportInitialize) this.cmbBankAccounts).BeginInit();
    this.DsBankAccounts1.BeginInit();
    this.Panel1.SuspendLayout();
    this.Panel2.SuspendLayout();
    this.SuspendLayout();
    this.panelCheck1.BackColor = Color.SteelBlue;
    this.panelCheck1.BorderStyle = BorderStyle.FixedSingle;
    this.panelCheck1.Controls.Add((Control) this.lblVoidCheck1);
    this.panelCheck1.Controls.Add((Control) this.txtTransactNum1);
    this.panelCheck1.Controls.Add((Control) this.lblVoid1);
    this.panelCheck1.Controls.Add((Control) this.picViewTransferForm1);
    this.panelCheck1.Controls.Add((Control) this.Label12);
    this.panelCheck1.Controls.Add((Control) this.lblCheck1BankAddress);
    this.panelCheck1.Controls.Add((Control) this.Label4);
    this.panelCheck1.Controls.Add((Control) this.lblCheck1BankName);
    this.panelCheck1.Controls.Add((Control) this.pic1SearchDate);
    this.panelCheck1.Controls.Add((Control) this.pic1SearchPayee);
    this.panelCheck1.Controls.Add((Control) this.pic1SearchCheckNum);
    this.panelCheck1.Controls.Add((Control) this.lblCheck1StatusOnValue);
    this.panelCheck1.Controls.Add((Control) this.Label11);
    this.panelCheck1.Controls.Add((Control) this.lblCheck1StatusOnText);
    this.panelCheck1.Controls.Add((Control) this.Label8);
    this.panelCheck1.Controls.Add((Control) this.Label7);
    this.panelCheck1.Controls.Add((Control) this.lblCheck1Status);
    this.panelCheck1.Controls.Add((Control) this.Label5);
    this.panelCheck1.Controls.Add((Control) this.lblCheck1Date);
    this.panelCheck1.Controls.Add((Control) this.Label1);
    this.panelCheck1.Controls.Add((Control) this.lblCheck1AmountCurrency);
    this.panelCheck1.Controls.Add((Control) this.lblCheck1CheckNumber);
    this.panelCheck1.Controls.Add((Control) this.lblCheck1Payee);
    this.panelCheck1.Controls.Add((Control) this.lblCheck1AmountEnglish);
    this.panelCheck1.Controls.Add((Control) this.Label3);
    this.panelCheck1.Controls.Add((Control) this.Label2);
    this.panelCheck1.Controls.Add((Control) this.lblCheck1MGAName);
    this.panelCheck1.Controls.Add((Control) this.pictCheck1Background);
    this.panelCheck1.Location = new Point(0, 0);
    this.panelCheck1.Name = "panelCheck1";
    this.panelCheck1.Size = new Size(744, 176 /*0xB0*/);
    this.panelCheck1.TabIndex = 0;
    this.lblVoidCheck1.Cursor = Cursors.Hand;
    this.lblVoidCheck1.Font = new Font("Arial", 8.25f, FontStyle.Underline, GraphicsUnit.Point, (byte) 0);
    this.lblVoidCheck1.Location = new Point(664, 152);
    this.lblVoidCheck1.Name = "lblVoidCheck1";
    this.lblVoidCheck1.Size = new Size(72, 16 /*0x10*/);
    this.lblVoidCheck1.TabIndex = 27;
    this.lblVoidCheck1.Text = "Void Check";
    this.lblVoidCheck1.TextAlign = ContentAlignment.MiddleRight;
    this.ToolTip1.SetToolTip((Control) this.lblVoidCheck1, "Click here to void this check.");
    this.txtTransactNum1.Location = new Point(704, 24);
    this.txtTransactNum1.Name = "txtTransactNum1";
    this.txtTransactNum1.Size = new Size(32 /*0x20*/, 20);
    this.txtTransactNum1.TabIndex = 24;
    this.txtTransactNum1.Text = "";
    this.txtTransactNum1.Visible = false;
    this.lblVoid1.BackColor = Color.White;
    this.lblVoid1.Font = new Font("Arial", 24f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblVoid1.ForeColor = Color.Red;
    this.lblVoid1.Location = new Point(544, 104);
    this.lblVoid1.Name = "lblVoid1";
    this.lblVoid1.Size = new Size(192 /*0xC0*/, 32 /*0x20*/);
    this.lblVoid1.TabIndex = 23;
    this.lblVoid1.Text = "VOID";
    this.lblVoid1.TextAlign = ContentAlignment.TopRight;
    this.lblVoid1.Visible = false;
    this.picViewTransferForm1.Cursor = Cursors.Hand;
    this.picViewTransferForm1.Image = (Image) resourceManager.GetObject("picViewTransferForm1.Image");
    this.picViewTransferForm1.Location = new Point(560, 8);
    this.picViewTransferForm1.Name = "picViewTransferForm1";
    this.picViewTransferForm1.Size = new Size(16 /*0x10*/, 16 /*0x10*/);
    this.picViewTransferForm1.SizeMode = PictureBoxSizeMode.StretchImage;
    this.picViewTransferForm1.TabIndex = 22;
    this.picViewTransferForm1.TabStop = false;
    this.ToolTip1.SetToolTip((Control) this.picViewTransferForm1, "Click here to view the wire transfer facsimile.");
    this.picViewTransferForm1.Visible = false;
    this.Label12.Anchor = AnchorStyles.Left | AnchorStyles.Right;
    this.Label12.BackColor = Color.Black;
    this.Label12.Location = new Point(64 /*0x40*/, 78);
    this.Label12.Name = "Label12";
    this.Label12.Size = new Size(576, 1);
    this.Label12.TabIndex = 21;
    this.Label12.Tag = (object) "LINE";
    this.Label12.Text = "Pay:";
    this.lblCheck1BankAddress.Anchor = AnchorStyles.Left | AnchorStyles.Right;
    this.lblCheck1BankAddress.BackColor = Color.White;
    this.lblCheck1BankAddress.Font = new Font("Tahoma", 7f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblCheck1BankAddress.Location = new Point(100, 120);
    this.lblCheck1BankAddress.Name = "lblCheck1BankAddress";
    this.lblCheck1BankAddress.Size = new Size(240 /*0xF0*/, 24);
    this.lblCheck1BankAddress.TabIndex = 20;
    this.lblCheck1BankAddress.Text = "Label1";
    this.Label4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
    this.Label4.BackColor = Color.Black;
    this.Label4.Location = new Point(64 /*0x40*/, 98);
    this.Label4.Name = "Label4";
    this.Label4.Size = new Size(582, 1);
    this.Label4.TabIndex = 4;
    this.Label4.Tag = (object) "LINE";
    this.Label4.Text = "Pay:";
    this.lblCheck1BankName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
    this.lblCheck1BankName.BackColor = Color.White;
    this.lblCheck1BankName.Font = new Font("Tahoma", 7f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblCheck1BankName.Location = new Point(100, 104);
    this.lblCheck1BankName.Name = "lblCheck1BankName";
    this.lblCheck1BankName.Size = new Size(264, 16 /*0x10*/);
    this.lblCheck1BankName.TabIndex = 15;
    this.lblCheck1BankName.Text = "Label1";
    this.lblCheck1BankName.TextAlign = ContentAlignment.BottomLeft;
    this.pic1SearchDate.Location = new Point(648, 40);
    this.pic1SearchDate.Name = "pic1SearchDate";
    this.pic1SearchDate.Size = new Size(16 /*0x10*/, 16 /*0x10*/);
    this.pic1SearchDate.SizeMode = PictureBoxSizeMode.StretchImage;
    this.pic1SearchDate.TabIndex = 14;
    this.pic1SearchDate.TabStop = false;
    this.pic1SearchPayee.Location = new Point(648, 64 /*0x40*/);
    this.pic1SearchPayee.Name = "pic1SearchPayee";
    this.pic1SearchPayee.Size = new Size(16 /*0x10*/, 16 /*0x10*/);
    this.pic1SearchPayee.SizeMode = PictureBoxSizeMode.StretchImage;
    this.pic1SearchPayee.TabIndex = 13;
    this.pic1SearchPayee.TabStop = false;
    this.pic1SearchCheckNum.Location = new Point(576, 8);
    this.pic1SearchCheckNum.Name = "pic1SearchCheckNum";
    this.pic1SearchCheckNum.Size = new Size(16 /*0x10*/, 16 /*0x10*/);
    this.pic1SearchCheckNum.SizeMode = PictureBoxSizeMode.StretchImage;
    this.pic1SearchCheckNum.TabIndex = 12;
    this.pic1SearchCheckNum.TabStop = false;
    this.lblCheck1StatusOnValue.Anchor = AnchorStyles.Left | AnchorStyles.Right;
    this.lblCheck1StatusOnValue.BackColor = Color.White;
    this.lblCheck1StatusOnValue.Font = new Font("Tahoma", 8f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblCheck1StatusOnValue.ForeColor = Color.SteelBlue;
    this.lblCheck1StatusOnValue.Location = new Point(312, 147);
    this.lblCheck1StatusOnValue.Name = "lblCheck1StatusOnValue";
    this.lblCheck1StatusOnValue.Size = new Size(112 /*0x70*/, 16 /*0x10*/);
    this.lblCheck1StatusOnValue.TabIndex = 10;
    this.lblCheck1StatusOnValue.Tag = (object) "STATON";
    this.lblCheck1StatusOnValue.Text = "Reconciled";
    this.lblCheck1StatusOnValue.TextAlign = ContentAlignment.BottomCenter;
    this.Label11.Anchor = AnchorStyles.Left | AnchorStyles.Right;
    this.Label11.BackColor = Color.Black;
    this.Label11.Location = new Point(312, 163);
    this.Label11.Name = "Label11";
    this.Label11.Size = new Size(120, 1);
    this.Label11.TabIndex = 11;
    this.Label11.Tag = (object) "STATON-LINE";
    this.Label11.Text = "Pay:";
    this.lblCheck1StatusOnText.BackColor = Color.White;
    this.lblCheck1StatusOnText.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblCheck1StatusOnText.Location = new Point(224 /*0xE0*/, 151);
    this.lblCheck1StatusOnText.Name = "lblCheck1StatusOnText";
    this.lblCheck1StatusOnText.Size = new Size(88, 16 /*0x10*/);
    this.lblCheck1StatusOnText.TabIndex = 10;
    this.lblCheck1StatusOnText.Tag = (object) "STATON";
    this.lblCheck1StatusOnText.Text = "Reconciled On:";
    this.lblCheck1StatusOnText.TextAlign = ContentAlignment.TopRight;
    this.Label8.Anchor = AnchorStyles.Left | AnchorStyles.Right;
    this.Label8.BackColor = Color.Black;
    this.Label8.Location = new Point(90, 163);
    this.Label8.Name = "Label8";
    this.Label8.Size = new Size(120, 1);
    this.Label8.TabIndex = 9;
    this.Label8.Tag = (object) "LINE";
    this.Label8.Text = "Pay:";
    this.Label7.BackColor = Color.White;
    this.Label7.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label7.Location = new Point(8, 151);
    this.Label7.Name = "Label7";
    this.Label7.Size = new Size(88, 16 /*0x10*/);
    this.Label7.TabIndex = 8;
    this.Label7.Text = "Check Status:";
    this.lblCheck1Status.Anchor = AnchorStyles.Left | AnchorStyles.Right;
    this.lblCheck1Status.BackColor = Color.White;
    this.lblCheck1Status.Font = new Font("Tahoma", 8f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblCheck1Status.ForeColor = Color.SteelBlue;
    this.lblCheck1Status.Location = new Point(88, 147);
    this.lblCheck1Status.Name = "lblCheck1Status";
    this.lblCheck1Status.Size = new Size(112 /*0x70*/, 16 /*0x10*/);
    this.lblCheck1Status.TabIndex = 4;
    this.lblCheck1Status.Text = "Reconciled";
    this.lblCheck1Status.TextAlign = ContentAlignment.BottomCenter;
    this.Label5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
    this.Label5.BackColor = Color.Black;
    this.Label5.Location = new Point(558, 56);
    this.Label5.Name = "Label5";
    this.Label5.Size = new Size(82, 1);
    this.Label5.TabIndex = 6;
    this.Label5.Tag = (object) "LINE";
    this.Label5.Text = "Pay:";
    this.lblCheck1Date.Anchor = AnchorStyles.Left | AnchorStyles.Right;
    this.lblCheck1Date.BackColor = Color.White;
    this.lblCheck1Date.Font = new Font("Tahoma", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblCheck1Date.Location = new Point(560, 41);
    this.lblCheck1Date.Name = "lblCheck1Date";
    this.lblCheck1Date.Size = new Size(80 /*0x50*/, 14);
    this.lblCheck1Date.TabIndex = 3;
    this.lblCheck1Date.Text = "12/31/2004";
    this.lblCheck1Date.TextAlign = ContentAlignment.MiddleCenter;
    this.Label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
    this.Label1.AutoSize = true;
    this.Label1.BackColor = Color.White;
    this.Label1.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label1.Location = new Point(528, 40);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(35, 17);
    this.Label1.TabIndex = 5;
    this.Label1.Text = "Date:";
    this.lblCheck1AmountCurrency.Anchor = AnchorStyles.Left | AnchorStyles.Right;
    this.lblCheck1AmountCurrency.BackColor = Color.White;
    this.lblCheck1AmountCurrency.BorderStyle = BorderStyle.FixedSingle;
    this.lblCheck1AmountCurrency.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblCheck1AmountCurrency.Location = new Point(640, 83);
    this.lblCheck1AmountCurrency.Name = "lblCheck1AmountCurrency";
    this.lblCheck1AmountCurrency.Size = new Size(96 /*0x60*/, 16 /*0x10*/);
    this.lblCheck1AmountCurrency.TabIndex = 3;
    this.lblCheck1AmountCurrency.Text = "$999,999,999.00";
    this.lblCheck1AmountCurrency.TextAlign = ContentAlignment.TopRight;
    this.lblCheck1CheckNumber.BackColor = Color.White;
    this.lblCheck1CheckNumber.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblCheck1CheckNumber.ForeColor = Color.Black;
    this.lblCheck1CheckNumber.Location = new Point(600, 8);
    this.lblCheck1CheckNumber.Name = "lblCheck1CheckNumber";
    this.lblCheck1CheckNumber.Size = new Size(136, 16 /*0x10*/);
    this.lblCheck1CheckNumber.TabIndex = 2;
    this.lblCheck1CheckNumber.Text = "223698";
    this.lblCheck1CheckNumber.TextAlign = ContentAlignment.MiddleRight;
    this.lblCheck1Payee.Anchor = AnchorStyles.Left | AnchorStyles.Right;
    this.lblCheck1Payee.BackColor = Color.White;
    this.lblCheck1Payee.Font = new Font("Tahoma", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblCheck1Payee.Location = new Point(62, 64 /*0x40*/);
    this.lblCheck1Payee.Name = "lblCheck1Payee";
    this.lblCheck1Payee.Size = new Size(458, 16 /*0x10*/);
    this.lblCheck1Payee.TabIndex = 2;
    this.lblCheck1Payee.Text = "MGA Systems Inc.";
    this.lblCheck1Payee.UseMnemonic = false;
    this.lblCheck1AmountEnglish.Anchor = AnchorStyles.Left | AnchorStyles.Right;
    this.lblCheck1AmountEnglish.BackColor = Color.White;
    this.lblCheck1AmountEnglish.Font = new Font("Tahoma", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblCheck1AmountEnglish.Location = new Point(64 /*0x40*/, 82);
    this.lblCheck1AmountEnglish.Name = "lblCheck1AmountEnglish";
    this.lblCheck1AmountEnglish.Size = new Size(572, 16 /*0x10*/);
    this.lblCheck1AmountEnglish.TabIndex = 3;
    this.lblCheck1AmountEnglish.Text = "Label1";
    this.lblCheck1AmountEnglish.TextAlign = ContentAlignment.BottomLeft;
    this.lblCheck1AmountEnglish.UseMnemonic = false;
    this.Label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
    this.Label3.AutoSize = true;
    this.Label3.BackColor = Color.White;
    this.Label3.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label3.Location = new Point(8, 84);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(53, 17);
    this.Label3.TabIndex = 3;
    this.Label3.Text = "Amount:";
    this.Label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
    this.Label2.AutoSize = true;
    this.Label2.BackColor = Color.White;
    this.Label2.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label2.Location = new Point(8, 64 /*0x40*/);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(42, 17);
    this.Label2.TabIndex = 2;
    this.Label2.Text = "Payee:";
    this.lblCheck1MGAName.BackColor = Color.White;
    this.lblCheck1MGAName.Font = new Font("Tahoma", 7f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblCheck1MGAName.ForeColor = Color.Black;
    this.lblCheck1MGAName.Location = new Point(8, 8);
    this.lblCheck1MGAName.Name = "lblCheck1MGAName";
    this.lblCheck1MGAName.Size = new Size(360, 55);
    this.lblCheck1MGAName.TabIndex = 1;
    this.lblCheck1MGAName.UseMnemonic = false;
    this.pictCheck1Background.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.pictCheck1Background.BackColor = Color.White;
    this.pictCheck1Background.Location = new Point(2, 2);
    this.pictCheck1Background.Name = "pictCheck1Background";
    this.pictCheck1Background.Size = new Size(738, 170);
    this.pictCheck1Background.SizeMode = PictureBoxSizeMode.StretchImage;
    this.pictCheck1Background.TabIndex = 0;
    this.pictCheck1Background.TabStop = false;
    this.panelCheck2.BackColor = Color.SteelBlue;
    this.panelCheck2.BorderStyle = BorderStyle.FixedSingle;
    this.panelCheck2.Controls.Add((Control) this.lblVoidCheck2);
    this.panelCheck2.Controls.Add((Control) this.txtTransactNum2);
    this.panelCheck2.Controls.Add((Control) this.lblVoid2);
    this.panelCheck2.Controls.Add((Control) this.picViewTransferForm2);
    this.panelCheck2.Controls.Add((Control) this.Label15);
    this.panelCheck2.Controls.Add((Control) this.lblCheck2BankAddress);
    this.panelCheck2.Controls.Add((Control) this.lblCheck2BankName);
    this.panelCheck2.Controls.Add((Control) this.pic2SearchDate);
    this.panelCheck2.Controls.Add((Control) this.pic2SearchPayee);
    this.panelCheck2.Controls.Add((Control) this.pic2SearchCheckNum);
    this.panelCheck2.Controls.Add((Control) this.lblCheck2StatusOnValue);
    this.panelCheck2.Controls.Add((Control) this.Label10);
    this.panelCheck2.Controls.Add((Control) this.lblCheck2StatusOnText);
    this.panelCheck2.Controls.Add((Control) this.Label13);
    this.panelCheck2.Controls.Add((Control) this.Label14);
    this.panelCheck2.Controls.Add((Control) this.lblCheck2Status);
    this.panelCheck2.Controls.Add((Control) this.Label17);
    this.panelCheck2.Controls.Add((Control) this.lblCheck2Date);
    this.panelCheck2.Controls.Add((Control) this.Label19);
    this.panelCheck2.Controls.Add((Control) this.lblCheck2AmountCurrency);
    this.panelCheck2.Controls.Add((Control) this.lblCheck2CheckNumber);
    this.panelCheck2.Controls.Add((Control) this.lblCheck2Payee);
    this.panelCheck2.Controls.Add((Control) this.lblCheck2AmountEnglish);
    this.panelCheck2.Controls.Add((Control) this.Label24);
    this.panelCheck2.Controls.Add((Control) this.Label25);
    this.panelCheck2.Controls.Add((Control) this.Label26);
    this.panelCheck2.Controls.Add((Control) this.lblCheck2MGAName);
    this.panelCheck2.Controls.Add((Control) this.pictCheck2Background);
    this.panelCheck2.Location = new Point(0, 168);
    this.panelCheck2.Name = "panelCheck2";
    this.panelCheck2.Size = new Size(744, 176 /*0xB0*/);
    this.panelCheck2.TabIndex = 1;
    this.lblVoidCheck2.Cursor = Cursors.Hand;
    this.lblVoidCheck2.Font = new Font("Arial", 8.25f, FontStyle.Underline, GraphicsUnit.Point, (byte) 0);
    this.lblVoidCheck2.Location = new Point(664, 152);
    this.lblVoidCheck2.Name = "lblVoidCheck2";
    this.lblVoidCheck2.Size = new Size(72, 16 /*0x10*/);
    this.lblVoidCheck2.TabIndex = 27;
    this.lblVoidCheck2.Text = "Void Check";
    this.lblVoidCheck2.TextAlign = ContentAlignment.MiddleRight;
    this.ToolTip1.SetToolTip((Control) this.lblVoidCheck2, "Click here to void this check.");
    this.txtTransactNum2.Location = new Point(704, 24);
    this.txtTransactNum2.Name = "txtTransactNum2";
    this.txtTransactNum2.Size = new Size(32 /*0x20*/, 20);
    this.txtTransactNum2.TabIndex = 25;
    this.txtTransactNum2.Text = "";
    this.txtTransactNum2.Visible = false;
    this.lblVoid2.BackColor = Color.White;
    this.lblVoid2.Font = new Font("Arial", 24f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblVoid2.ForeColor = Color.Red;
    this.lblVoid2.Location = new Point(544, 104);
    this.lblVoid2.Name = "lblVoid2";
    this.lblVoid2.Size = new Size(192 /*0xC0*/, 32 /*0x20*/);
    this.lblVoid2.TabIndex = 24;
    this.lblVoid2.Text = "VOID";
    this.lblVoid2.TextAlign = ContentAlignment.TopRight;
    this.lblVoid2.Visible = false;
    this.picViewTransferForm2.Cursor = Cursors.Hand;
    this.picViewTransferForm2.Image = (Image) resourceManager.GetObject("picViewTransferForm2.Image");
    this.picViewTransferForm2.Location = new Point(560, 8);
    this.picViewTransferForm2.Name = "picViewTransferForm2";
    this.picViewTransferForm2.Size = new Size(16 /*0x10*/, 16 /*0x10*/);
    this.picViewTransferForm2.SizeMode = PictureBoxSizeMode.StretchImage;
    this.picViewTransferForm2.TabIndex = 23;
    this.picViewTransferForm2.TabStop = false;
    this.ToolTip1.SetToolTip((Control) this.picViewTransferForm2, "Click here to view the wire transfer facsimile.");
    this.picViewTransferForm2.Visible = false;
    this.Label15.Anchor = AnchorStyles.Left | AnchorStyles.Right;
    this.Label15.BackColor = Color.Black;
    this.Label15.Location = new Point(64 /*0x40*/, 78);
    this.Label15.Name = "Label15";
    this.Label15.Size = new Size(576, 1);
    this.Label15.TabIndex = 22;
    this.Label15.Tag = (object) "LINE";
    this.Label15.Text = "Pay:";
    this.lblCheck2BankAddress.Anchor = AnchorStyles.Left | AnchorStyles.Right;
    this.lblCheck2BankAddress.BackColor = Color.White;
    this.lblCheck2BankAddress.Font = new Font("Tahoma", 7f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblCheck2BankAddress.Location = new Point(100, 120);
    this.lblCheck2BankAddress.Name = "lblCheck2BankAddress";
    this.lblCheck2BankAddress.Size = new Size(240 /*0xF0*/, 24);
    this.lblCheck2BankAddress.TabIndex = 20;
    this.lblCheck2BankAddress.Text = "Label1";
    this.lblCheck2BankName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
    this.lblCheck2BankName.BackColor = Color.White;
    this.lblCheck2BankName.Font = new Font("Tahoma", 7f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblCheck2BankName.Location = new Point(100, 104);
    this.lblCheck2BankName.Name = "lblCheck2BankName";
    this.lblCheck2BankName.Size = new Size(264, 16 /*0x10*/);
    this.lblCheck2BankName.TabIndex = 18;
    this.lblCheck2BankName.Text = "Label1";
    this.lblCheck2BankName.TextAlign = ContentAlignment.BottomLeft;
    this.pic2SearchDate.Location = new Point(648, 40);
    this.pic2SearchDate.Name = "pic2SearchDate";
    this.pic2SearchDate.Size = new Size(16 /*0x10*/, 16 /*0x10*/);
    this.pic2SearchDate.SizeMode = PictureBoxSizeMode.StretchImage;
    this.pic2SearchDate.TabIndex = 17;
    this.pic2SearchDate.TabStop = false;
    this.pic2SearchPayee.Location = new Point(648, 63 /*0x3F*/);
    this.pic2SearchPayee.Name = "pic2SearchPayee";
    this.pic2SearchPayee.Size = new Size(16 /*0x10*/, 16 /*0x10*/);
    this.pic2SearchPayee.SizeMode = PictureBoxSizeMode.StretchImage;
    this.pic2SearchPayee.TabIndex = 16 /*0x10*/;
    this.pic2SearchPayee.TabStop = false;
    this.pic2SearchCheckNum.Location = new Point(576, 8);
    this.pic2SearchCheckNum.Name = "pic2SearchCheckNum";
    this.pic2SearchCheckNum.Size = new Size(16 /*0x10*/, 16 /*0x10*/);
    this.pic2SearchCheckNum.SizeMode = PictureBoxSizeMode.StretchImage;
    this.pic2SearchCheckNum.TabIndex = 15;
    this.pic2SearchCheckNum.TabStop = false;
    this.lblCheck2StatusOnValue.Anchor = AnchorStyles.Left | AnchorStyles.Right;
    this.lblCheck2StatusOnValue.BackColor = Color.White;
    this.lblCheck2StatusOnValue.Font = new Font("Tahoma", 8f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblCheck2StatusOnValue.ForeColor = Color.SteelBlue;
    this.lblCheck2StatusOnValue.Location = new Point(312, 147);
    this.lblCheck2StatusOnValue.Name = "lblCheck2StatusOnValue";
    this.lblCheck2StatusOnValue.Size = new Size(104, 16 /*0x10*/);
    this.lblCheck2StatusOnValue.TabIndex = 10;
    this.lblCheck2StatusOnValue.Tag = (object) "STATON";
    this.lblCheck2StatusOnValue.Text = "Reconciled";
    this.lblCheck2StatusOnValue.TextAlign = ContentAlignment.BottomCenter;
    this.Label10.Anchor = AnchorStyles.Left | AnchorStyles.Right;
    this.Label10.BackColor = Color.Black;
    this.Label10.Location = new Point(312, 163);
    this.Label10.Name = "Label10";
    this.Label10.Size = new Size(120, 1);
    this.Label10.TabIndex = 11;
    this.Label10.Tag = (object) "STATON-LINE";
    this.Label10.Text = "Pay:";
    this.lblCheck2StatusOnText.BackColor = Color.White;
    this.lblCheck2StatusOnText.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblCheck2StatusOnText.Location = new Point(224 /*0xE0*/, 152);
    this.lblCheck2StatusOnText.Name = "lblCheck2StatusOnText";
    this.lblCheck2StatusOnText.Size = new Size(88, 16 /*0x10*/);
    this.lblCheck2StatusOnText.TabIndex = 10;
    this.lblCheck2StatusOnText.Tag = (object) "STATON";
    this.lblCheck2StatusOnText.Text = "Reconciled On:";
    this.lblCheck2StatusOnText.TextAlign = ContentAlignment.TopRight;
    this.Label13.Anchor = AnchorStyles.Left | AnchorStyles.Right;
    this.Label13.BackColor = Color.Black;
    this.Label13.Location = new Point(90, 163);
    this.Label13.Name = "Label13";
    this.Label13.Size = new Size(120, 1);
    this.Label13.TabIndex = 9;
    this.Label13.Tag = (object) "LINE";
    this.Label13.Text = "Pay:";
    this.Label14.BackColor = Color.White;
    this.Label14.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label14.Location = new Point(8, 152);
    this.Label14.Name = "Label14";
    this.Label14.Size = new Size(88, 16 /*0x10*/);
    this.Label14.TabIndex = 8;
    this.Label14.Text = "Check Status:";
    this.lblCheck2Status.Anchor = AnchorStyles.Left | AnchorStyles.Right;
    this.lblCheck2Status.BackColor = Color.White;
    this.lblCheck2Status.Font = new Font("Tahoma", 8f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblCheck2Status.ForeColor = Color.Red;
    this.lblCheck2Status.Location = new Point(88, 147);
    this.lblCheck2Status.Name = "lblCheck2Status";
    this.lblCheck2Status.Size = new Size(112 /*0x70*/, 16 /*0x10*/);
    this.lblCheck2Status.TabIndex = 4;
    this.lblCheck2Status.Text = "Un-Printed";
    this.lblCheck2Status.TextAlign = ContentAlignment.BottomCenter;
    this.Label17.Anchor = AnchorStyles.Left | AnchorStyles.Right;
    this.Label17.BackColor = Color.Black;
    this.Label17.Location = new Point(558, 56);
    this.Label17.Name = "Label17";
    this.Label17.Size = new Size(82, 1);
    this.Label17.TabIndex = 6;
    this.Label17.Tag = (object) "LINE";
    this.Label17.Text = "Pay:";
    this.lblCheck2Date.Anchor = AnchorStyles.Left | AnchorStyles.Right;
    this.lblCheck2Date.BackColor = Color.White;
    this.lblCheck2Date.Font = new Font("Tahoma", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblCheck2Date.Location = new Point(560, 41);
    this.lblCheck2Date.Name = "lblCheck2Date";
    this.lblCheck2Date.Size = new Size(80 /*0x50*/, 14);
    this.lblCheck2Date.TabIndex = 3;
    this.lblCheck2Date.Text = "12/31/2004";
    this.lblCheck2Date.TextAlign = ContentAlignment.MiddleCenter;
    this.Label19.Anchor = AnchorStyles.Left | AnchorStyles.Right;
    this.Label19.AutoSize = true;
    this.Label19.BackColor = Color.White;
    this.Label19.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label19.Location = new Point(528, 40);
    this.Label19.Name = "Label19";
    this.Label19.Size = new Size(35, 17);
    this.Label19.TabIndex = 5;
    this.Label19.Text = "Date:";
    this.lblCheck2AmountCurrency.Anchor = AnchorStyles.Left | AnchorStyles.Right;
    this.lblCheck2AmountCurrency.BackColor = Color.White;
    this.lblCheck2AmountCurrency.BorderStyle = BorderStyle.FixedSingle;
    this.lblCheck2AmountCurrency.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblCheck2AmountCurrency.Location = new Point(640, 87);
    this.lblCheck2AmountCurrency.Name = "lblCheck2AmountCurrency";
    this.lblCheck2AmountCurrency.Size = new Size(96 /*0x60*/, 16 /*0x10*/);
    this.lblCheck2AmountCurrency.TabIndex = 3;
    this.lblCheck2AmountCurrency.Text = "$999,999,999.00";
    this.lblCheck2AmountCurrency.TextAlign = ContentAlignment.TopRight;
    this.lblCheck2CheckNumber.BackColor = Color.White;
    this.lblCheck2CheckNumber.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblCheck2CheckNumber.ForeColor = Color.Black;
    this.lblCheck2CheckNumber.Location = new Point(600, 8);
    this.lblCheck2CheckNumber.Name = "lblCheck2CheckNumber";
    this.lblCheck2CheckNumber.Size = new Size(136, 16 /*0x10*/);
    this.lblCheck2CheckNumber.TabIndex = 2;
    this.lblCheck2CheckNumber.Text = "223698";
    this.lblCheck2CheckNumber.TextAlign = ContentAlignment.MiddleRight;
    this.lblCheck2Payee.Anchor = AnchorStyles.Left | AnchorStyles.Right;
    this.lblCheck2Payee.BackColor = Color.White;
    this.lblCheck2Payee.Font = new Font("Tahoma", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblCheck2Payee.Location = new Point(62, 62);
    this.lblCheck2Payee.Name = "lblCheck2Payee";
    this.lblCheck2Payee.Size = new Size(458, 16 /*0x10*/);
    this.lblCheck2Payee.TabIndex = 2;
    this.lblCheck2Payee.Text = "MGA Systems Inc.";
    this.lblCheck2Payee.UseMnemonic = false;
    this.lblCheck2AmountEnglish.Anchor = AnchorStyles.Left | AnchorStyles.Right;
    this.lblCheck2AmountEnglish.BackColor = Color.White;
    this.lblCheck2AmountEnglish.Font = new Font("Tahoma", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblCheck2AmountEnglish.Location = new Point(62, 84);
    this.lblCheck2AmountEnglish.Name = "lblCheck2AmountEnglish";
    this.lblCheck2AmountEnglish.Size = new Size(572, 16 /*0x10*/);
    this.lblCheck2AmountEnglish.TabIndex = 3;
    this.lblCheck2AmountEnglish.Text = "Label1";
    this.lblCheck2AmountEnglish.TextAlign = ContentAlignment.BottomLeft;
    this.lblCheck2AmountEnglish.UseMnemonic = false;
    this.Label24.Anchor = AnchorStyles.Left | AnchorStyles.Right;
    this.Label24.BackColor = Color.Black;
    this.Label24.Location = new Point(64 /*0x40*/, 102);
    this.Label24.Name = "Label24";
    this.Label24.Size = new Size(582, 1);
    this.Label24.TabIndex = 4;
    this.Label24.Tag = (object) "LINE";
    this.Label24.Text = "Pay:";
    this.Label25.Anchor = AnchorStyles.Left | AnchorStyles.Right;
    this.Label25.AutoSize = true;
    this.Label25.BackColor = Color.White;
    this.Label25.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label25.Location = new Point(8, 85);
    this.Label25.Name = "Label25";
    this.Label25.Size = new Size(53, 17);
    this.Label25.TabIndex = 3;
    this.Label25.Text = "Amount:";
    this.Label26.Anchor = AnchorStyles.Left | AnchorStyles.Right;
    this.Label26.AutoSize = true;
    this.Label26.BackColor = Color.White;
    this.Label26.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label26.Location = new Point(8, 62);
    this.Label26.Name = "Label26";
    this.Label26.Size = new Size(42, 17);
    this.Label26.TabIndex = 2;
    this.Label26.Text = "Payee:";
    this.lblCheck2MGAName.BackColor = Color.White;
    this.lblCheck2MGAName.Font = new Font("Tahoma", 7f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblCheck2MGAName.ForeColor = Color.Black;
    this.lblCheck2MGAName.Location = new Point(8, 8);
    this.lblCheck2MGAName.Name = "lblCheck2MGAName";
    this.lblCheck2MGAName.Size = new Size(336, 55);
    this.lblCheck2MGAName.TabIndex = 1;
    this.lblCheck2MGAName.Text = "The Best MGA";
    this.lblCheck2MGAName.UseMnemonic = false;
    this.pictCheck2Background.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.pictCheck2Background.BackColor = Color.White;
    this.pictCheck2Background.Location = new Point(2, 2);
    this.pictCheck2Background.Name = "pictCheck2Background";
    this.pictCheck2Background.Size = new Size(738, 170);
    this.pictCheck2Background.SizeMode = PictureBoxSizeMode.StretchImage;
    this.pictCheck2Background.TabIndex = 0;
    this.pictCheck2Background.TabStop = false;
    this.panelCheck3.BackColor = Color.SteelBlue;
    this.panelCheck3.BorderStyle = BorderStyle.FixedSingle;
    this.panelCheck3.Controls.Add((Control) this.lblVoidCheck3);
    this.panelCheck3.Controls.Add((Control) this.txtTransactNum3);
    this.panelCheck3.Controls.Add((Control) this.lblVoid3);
    this.panelCheck3.Controls.Add((Control) this.picViewTransferForm3);
    this.panelCheck3.Controls.Add((Control) this.Label18);
    this.panelCheck3.Controls.Add((Control) this.lblCheck3BankAddress);
    this.panelCheck3.Controls.Add((Control) this.lblCheck3BankName);
    this.panelCheck3.Controls.Add((Control) this.pic3SearchDate);
    this.panelCheck3.Controls.Add((Control) this.pic3SearchPayee);
    this.panelCheck3.Controls.Add((Control) this.pic3SearchCheckNum);
    this.panelCheck3.Controls.Add((Control) this.lblCheck3StatusOnValue);
    this.panelCheck3.Controls.Add((Control) this.Label29);
    this.panelCheck3.Controls.Add((Control) this.lblCheck3StatusOnText);
    this.panelCheck3.Controls.Add((Control) this.Label31);
    this.panelCheck3.Controls.Add((Control) this.Label32);
    this.panelCheck3.Controls.Add((Control) this.lblCheck3Status);
    this.panelCheck3.Controls.Add((Control) this.Label35);
    this.panelCheck3.Controls.Add((Control) this.lblCheck3Date);
    this.panelCheck3.Controls.Add((Control) this.Label37);
    this.panelCheck3.Controls.Add((Control) this.lblCheck3AmountCurrency);
    this.panelCheck3.Controls.Add((Control) this.lblCheck3CheckNumber);
    this.panelCheck3.Controls.Add((Control) this.lblCheck3Payee);
    this.panelCheck3.Controls.Add((Control) this.lblCheck3AmountEnglish);
    this.panelCheck3.Controls.Add((Control) this.Label42);
    this.panelCheck3.Controls.Add((Control) this.Label43);
    this.panelCheck3.Controls.Add((Control) this.Label44);
    this.panelCheck3.Controls.Add((Control) this.lblCheck3MGAName);
    this.panelCheck3.Controls.Add((Control) this.pictCheck3Background);
    this.panelCheck3.Location = new Point(0, 344);
    this.panelCheck3.Name = "panelCheck3";
    this.panelCheck3.Size = new Size(744, 176 /*0xB0*/);
    this.panelCheck3.TabIndex = 2;
    this.lblVoidCheck3.Cursor = Cursors.Hand;
    this.lblVoidCheck3.Font = new Font("Arial", 8.25f, FontStyle.Underline, GraphicsUnit.Point, (byte) 0);
    this.lblVoidCheck3.Location = new Point(664, 152);
    this.lblVoidCheck3.Name = "lblVoidCheck3";
    this.lblVoidCheck3.Size = new Size(72, 16 /*0x10*/);
    this.lblVoidCheck3.TabIndex = 26;
    this.lblVoidCheck3.Text = "Void Check";
    this.lblVoidCheck3.TextAlign = ContentAlignment.MiddleRight;
    this.ToolTip1.SetToolTip((Control) this.lblVoidCheck3, "Click here to void this check.");
    this.txtTransactNum3.Location = new Point(704, 24);
    this.txtTransactNum3.Name = "txtTransactNum3";
    this.txtTransactNum3.Size = new Size(32 /*0x20*/, 20);
    this.txtTransactNum3.TabIndex = 25;
    this.txtTransactNum3.Text = "";
    this.txtTransactNum3.Visible = false;
    this.lblVoid3.BackColor = Color.White;
    this.lblVoid3.Font = new Font("Arial", 24f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblVoid3.ForeColor = Color.Red;
    this.lblVoid3.Location = new Point(544, 104);
    this.lblVoid3.Name = "lblVoid3";
    this.lblVoid3.Size = new Size(192 /*0xC0*/, 32 /*0x20*/);
    this.lblVoid3.TabIndex = 24;
    this.lblVoid3.Text = "VOID";
    this.lblVoid3.TextAlign = ContentAlignment.TopRight;
    this.lblVoid3.Visible = false;
    this.picViewTransferForm3.Cursor = Cursors.Hand;
    this.picViewTransferForm3.Image = (Image) resourceManager.GetObject("picViewTransferForm3.Image");
    this.picViewTransferForm3.Location = new Point(560, 8);
    this.picViewTransferForm3.Name = "picViewTransferForm3";
    this.picViewTransferForm3.Size = new Size(16 /*0x10*/, 16 /*0x10*/);
    this.picViewTransferForm3.SizeMode = PictureBoxSizeMode.StretchImage;
    this.picViewTransferForm3.TabIndex = 23;
    this.picViewTransferForm3.TabStop = false;
    this.ToolTip1.SetToolTip((Control) this.picViewTransferForm3, "Click here to view the wire transfer facsimile.");
    this.picViewTransferForm3.Visible = false;
    this.Label18.Anchor = AnchorStyles.Left | AnchorStyles.Right;
    this.Label18.BackColor = Color.Black;
    this.Label18.Location = new Point(64 /*0x40*/, 80 /*0x50*/);
    this.Label18.Name = "Label18";
    this.Label18.Size = new Size(576, 1);
    this.Label18.TabIndex = 22;
    this.Label18.Tag = (object) "LINE";
    this.Label18.Text = "Pay:";
    this.lblCheck3BankAddress.Anchor = AnchorStyles.Left | AnchorStyles.Right;
    this.lblCheck3BankAddress.BackColor = Color.White;
    this.lblCheck3BankAddress.Font = new Font("Tahoma", 7f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblCheck3BankAddress.Location = new Point(100, 120);
    this.lblCheck3BankAddress.Name = "lblCheck3BankAddress";
    this.lblCheck3BankAddress.Size = new Size(240 /*0xF0*/, 24);
    this.lblCheck3BankAddress.TabIndex = 19;
    this.lblCheck3BankAddress.Text = "Label1";
    this.lblCheck3BankName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
    this.lblCheck3BankName.BackColor = Color.White;
    this.lblCheck3BankName.Font = new Font("Tahoma", 7f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblCheck3BankName.Location = new Point(100, 104);
    this.lblCheck3BankName.Name = "lblCheck3BankName";
    this.lblCheck3BankName.Size = new Size(264, 16 /*0x10*/);
    this.lblCheck3BankName.TabIndex = 18;
    this.lblCheck3BankName.Text = "Label1";
    this.lblCheck3BankName.TextAlign = ContentAlignment.BottomLeft;
    this.pic3SearchDate.Location = new Point(648, 40);
    this.pic3SearchDate.Name = "pic3SearchDate";
    this.pic3SearchDate.Size = new Size(16 /*0x10*/, 16 /*0x10*/);
    this.pic3SearchDate.SizeMode = PictureBoxSizeMode.StretchImage;
    this.pic3SearchDate.TabIndex = 17;
    this.pic3SearchDate.TabStop = false;
    this.pic3SearchPayee.Location = new Point(648, 66);
    this.pic3SearchPayee.Name = "pic3SearchPayee";
    this.pic3SearchPayee.Size = new Size(16 /*0x10*/, 16 /*0x10*/);
    this.pic3SearchPayee.SizeMode = PictureBoxSizeMode.StretchImage;
    this.pic3SearchPayee.TabIndex = 16 /*0x10*/;
    this.pic3SearchPayee.TabStop = false;
    this.pic3SearchCheckNum.Location = new Point(576, 8);
    this.pic3SearchCheckNum.Name = "pic3SearchCheckNum";
    this.pic3SearchCheckNum.Size = new Size(16 /*0x10*/, 16 /*0x10*/);
    this.pic3SearchCheckNum.SizeMode = PictureBoxSizeMode.StretchImage;
    this.pic3SearchCheckNum.TabIndex = 15;
    this.pic3SearchCheckNum.TabStop = false;
    this.lblCheck3StatusOnValue.Anchor = AnchorStyles.Left | AnchorStyles.Right;
    this.lblCheck3StatusOnValue.BackColor = Color.White;
    this.lblCheck3StatusOnValue.Font = new Font("Tahoma", 8f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblCheck3StatusOnValue.ForeColor = Color.SteelBlue;
    this.lblCheck3StatusOnValue.Location = new Point(312, 147);
    this.lblCheck3StatusOnValue.Name = "lblCheck3StatusOnValue";
    this.lblCheck3StatusOnValue.Size = new Size(104, 16 /*0x10*/);
    this.lblCheck3StatusOnValue.TabIndex = 10;
    this.lblCheck3StatusOnValue.Tag = (object) "STATON";
    this.lblCheck3StatusOnValue.Text = "Reconciled";
    this.lblCheck3StatusOnValue.TextAlign = ContentAlignment.BottomCenter;
    this.Label29.Anchor = AnchorStyles.Left | AnchorStyles.Right;
    this.Label29.BackColor = Color.Black;
    this.Label29.Location = new Point(312, 163);
    this.Label29.Name = "Label29";
    this.Label29.Size = new Size(120, 1);
    this.Label29.TabIndex = 11;
    this.Label29.Tag = (object) "STATON-LINE";
    this.Label29.Text = "Pay:";
    this.lblCheck3StatusOnText.BackColor = Color.White;
    this.lblCheck3StatusOnText.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblCheck3StatusOnText.Location = new Point(224 /*0xE0*/, 151);
    this.lblCheck3StatusOnText.Name = "lblCheck3StatusOnText";
    this.lblCheck3StatusOnText.Size = new Size(88, 16 /*0x10*/);
    this.lblCheck3StatusOnText.TabIndex = 10;
    this.lblCheck3StatusOnText.Tag = (object) "STATON";
    this.lblCheck3StatusOnText.Text = "Reconciled On:";
    this.Label31.Anchor = AnchorStyles.Left | AnchorStyles.Right;
    this.Label31.BackColor = Color.Black;
    this.Label31.Location = new Point(90, 163);
    this.Label31.Name = "Label31";
    this.Label31.Size = new Size(120, 1);
    this.Label31.TabIndex = 9;
    this.Label31.Tag = (object) "LINE";
    this.Label31.Text = "Pay:";
    this.Label32.BackColor = Color.White;
    this.Label32.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label32.Location = new Point(8, 151);
    this.Label32.Name = "Label32";
    this.Label32.Size = new Size(88, 16 /*0x10*/);
    this.Label32.TabIndex = 8;
    this.Label32.Text = "Check Status:";
    this.lblCheck3Status.Anchor = AnchorStyles.Left | AnchorStyles.Right;
    this.lblCheck3Status.BackColor = Color.White;
    this.lblCheck3Status.Font = new Font("Tahoma", 8f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblCheck3Status.ForeColor = Color.SeaGreen;
    this.lblCheck3Status.Location = new Point(88, 147);
    this.lblCheck3Status.Name = "lblCheck3Status";
    this.lblCheck3Status.Size = new Size(112 /*0x70*/, 16 /*0x10*/);
    this.lblCheck3Status.TabIndex = 4;
    this.lblCheck3Status.Text = "Printed";
    this.lblCheck3Status.TextAlign = ContentAlignment.BottomCenter;
    this.Label35.Anchor = AnchorStyles.Left | AnchorStyles.Right;
    this.Label35.BackColor = Color.Black;
    this.Label35.Location = new Point(558, 56);
    this.Label35.Name = "Label35";
    this.Label35.Size = new Size(82, 1);
    this.Label35.TabIndex = 6;
    this.Label35.Tag = (object) "LINE";
    this.Label35.Text = "Pay:";
    this.lblCheck3Date.Anchor = AnchorStyles.Left | AnchorStyles.Right;
    this.lblCheck3Date.BackColor = Color.White;
    this.lblCheck3Date.Font = new Font("Tahoma", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblCheck3Date.Location = new Point(560, 42);
    this.lblCheck3Date.Name = "lblCheck3Date";
    this.lblCheck3Date.Size = new Size(80 /*0x50*/, 14);
    this.lblCheck3Date.TabIndex = 3;
    this.lblCheck3Date.Text = "12/31/2004";
    this.lblCheck3Date.TextAlign = ContentAlignment.MiddleCenter;
    this.Label37.Anchor = AnchorStyles.Left | AnchorStyles.Right;
    this.Label37.AutoSize = true;
    this.Label37.BackColor = Color.White;
    this.Label37.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label37.Location = new Point(528, 40);
    this.Label37.Name = "Label37";
    this.Label37.Size = new Size(35, 17);
    this.Label37.TabIndex = 5;
    this.Label37.Text = "Date:";
    this.lblCheck3AmountCurrency.Anchor = AnchorStyles.Left | AnchorStyles.Right;
    this.lblCheck3AmountCurrency.BackColor = Color.White;
    this.lblCheck3AmountCurrency.BorderStyle = BorderStyle.FixedSingle;
    this.lblCheck3AmountCurrency.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblCheck3AmountCurrency.Location = new Point(640, 87);
    this.lblCheck3AmountCurrency.Name = "lblCheck3AmountCurrency";
    this.lblCheck3AmountCurrency.Size = new Size(96 /*0x60*/, 16 /*0x10*/);
    this.lblCheck3AmountCurrency.TabIndex = 3;
    this.lblCheck3AmountCurrency.Text = "$999,999,999.00";
    this.lblCheck3AmountCurrency.TextAlign = ContentAlignment.TopRight;
    this.lblCheck3CheckNumber.BackColor = Color.White;
    this.lblCheck3CheckNumber.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblCheck3CheckNumber.ForeColor = Color.Black;
    this.lblCheck3CheckNumber.Location = new Point(600, 8);
    this.lblCheck3CheckNumber.Name = "lblCheck3CheckNumber";
    this.lblCheck3CheckNumber.Size = new Size(136, 16 /*0x10*/);
    this.lblCheck3CheckNumber.TabIndex = 2;
    this.lblCheck3CheckNumber.Text = "223698";
    this.lblCheck3CheckNumber.TextAlign = ContentAlignment.MiddleRight;
    this.lblCheck3Payee.Anchor = AnchorStyles.Left | AnchorStyles.Right;
    this.lblCheck3Payee.BackColor = Color.White;
    this.lblCheck3Payee.Font = new Font("Tahoma", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblCheck3Payee.Location = new Point(62, 64 /*0x40*/);
    this.lblCheck3Payee.Name = "lblCheck3Payee";
    this.lblCheck3Payee.Size = new Size(458, 16 /*0x10*/);
    this.lblCheck3Payee.TabIndex = 2;
    this.lblCheck3Payee.Text = "MGA Systems Inc.";
    this.lblCheck3Payee.UseMnemonic = false;
    this.lblCheck3AmountEnglish.Anchor = AnchorStyles.Left | AnchorStyles.Right;
    this.lblCheck3AmountEnglish.BackColor = Color.White;
    this.lblCheck3AmountEnglish.Font = new Font("Tahoma", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblCheck3AmountEnglish.Location = new Point(62, 84);
    this.lblCheck3AmountEnglish.Name = "lblCheck3AmountEnglish";
    this.lblCheck3AmountEnglish.Size = new Size(572, 16 /*0x10*/);
    this.lblCheck3AmountEnglish.TabIndex = 3;
    this.lblCheck3AmountEnglish.Text = "Label1";
    this.lblCheck3AmountEnglish.TextAlign = ContentAlignment.BottomLeft;
    this.lblCheck3AmountEnglish.UseMnemonic = false;
    this.Label42.Anchor = AnchorStyles.Left | AnchorStyles.Right;
    this.Label42.BackColor = Color.Black;
    this.Label42.Location = new Point(64 /*0x40*/, 102);
    this.Label42.Name = "Label42";
    this.Label42.Size = new Size(582, 1);
    this.Label42.TabIndex = 4;
    this.Label42.Tag = (object) "LINE";
    this.Label42.Text = "Pay:";
    this.Label43.Anchor = AnchorStyles.Left | AnchorStyles.Right;
    this.Label43.AutoSize = true;
    this.Label43.BackColor = Color.White;
    this.Label43.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label43.Location = new Point(8, 86);
    this.Label43.Name = "Label43";
    this.Label43.Size = new Size(53, 17);
    this.Label43.TabIndex = 3;
    this.Label43.Text = "Amount:";
    this.Label44.Anchor = AnchorStyles.Left | AnchorStyles.Right;
    this.Label44.AutoSize = true;
    this.Label44.BackColor = Color.White;
    this.Label44.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label44.Location = new Point(8, 64 /*0x40*/);
    this.Label44.Name = "Label44";
    this.Label44.Size = new Size(42, 17);
    this.Label44.TabIndex = 2;
    this.Label44.Text = "Payee:";
    this.lblCheck3MGAName.BackColor = Color.White;
    this.lblCheck3MGAName.Font = new Font("Tahoma", 7f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblCheck3MGAName.ForeColor = Color.Black;
    this.lblCheck3MGAName.Location = new Point(8, 8);
    this.lblCheck3MGAName.Name = "lblCheck3MGAName";
    this.lblCheck3MGAName.Size = new Size(296, 55);
    this.lblCheck3MGAName.TabIndex = 1;
    this.lblCheck3MGAName.Text = "The Best MGA";
    this.lblCheck3MGAName.UseMnemonic = false;
    this.pictCheck3Background.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.pictCheck3Background.BackColor = Color.White;
    this.pictCheck3Background.Location = new Point(2, 2);
    this.pictCheck3Background.Name = "pictCheck3Background";
    this.pictCheck3Background.Size = new Size(738, 170);
    this.pictCheck3Background.SizeMode = PictureBoxSizeMode.StretchImage;
    this.pictCheck3Background.TabIndex = 0;
    this.pictCheck3Background.TabStop = false;
    this.btnNextPage.FlatStyle = FlatStyle.Flat;
    this.btnNextPage.Location = new Point(632, 8);
    this.btnNextPage.Name = "btnNextPage";
    this.btnNextPage.Size = new Size(104, 24);
    this.btnNextPage.TabIndex = 3;
    this.btnNextPage.Text = "Next Page >>";
    this.ToolTip1.SetToolTip((Control) this.btnNextPage, "Click here to view the next page.");
    this.btnPreviousPage.FlatStyle = FlatStyle.Flat;
    this.btnPreviousPage.Location = new Point(528, 8);
    this.btnPreviousPage.Name = "btnPreviousPage";
    this.btnPreviousPage.Size = new Size(104, 24);
    this.btnPreviousPage.TabIndex = 4;
    this.btnPreviousPage.Text = "<< Previous Page";
    this.ToolTip1.SetToolTip((Control) this.btnPreviousPage, "Click here to view the previous page.");
    this.btnPrint.FlatStyle = FlatStyle.Flat;
    this.btnPrint.Location = new Point(440, 8);
    this.btnPrint.Name = "btnPrint";
    this.btnPrint.Size = new Size(80 /*0x50*/, 24);
    this.btnPrint.TabIndex = 6;
    this.btnPrint.Text = "Print Checks";
    this.ToolTip1.SetToolTip((Control) this.btnPrint, "Click here to print checks.");
    this.lblPageN_OF_M.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblPageN_OF_M.ForeColor = Color.LightSlateGray;
    this.lblPageN_OF_M.Location = new Point(528, 32 /*0x20*/);
    this.lblPageN_OF_M.Name = "lblPageN_OF_M";
    this.lblPageN_OF_M.Size = new Size(208 /*0xD0*/, 16 /*0x10*/);
    this.lblPageN_OF_M.TabIndex = 7;
    this.lblPageN_OF_M.Text = "Page N of M";
    this.lblPageN_OF_M.TextAlign = ContentAlignment.TopCenter;
    this.Label9.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label9.Location = new Point(8, 16 /*0x10*/);
    this.Label9.Name = "Label9";
    this.Label9.Size = new Size(96 /*0x60*/, 16 /*0x10*/);
    this.Label9.TabIndex = 8;
    this.Label9.Text = "Search By:";
    this.GroupBox1.Controls.Add((Control) this.btnSearch);
    this.GroupBox1.Controls.Add((Control) this.txtSearchFor);
    this.GroupBox1.Controls.Add((Control) this.cmbSearchBy);
    this.GroupBox1.Controls.Add((Control) this.Label9);
    this.GroupBox1.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.GroupBox1.Location = new Point(0, 0);
    this.GroupBox1.Name = "GroupBox1";
    this.GroupBox1.Size = new Size(424, 48 /*0x30*/);
    this.GroupBox1.TabIndex = 9;
    this.GroupBox1.TabStop = false;
    this.GroupBox1.Text = "Search Checks";
    this.btnSearch.Location = new Point(384, 10);
    this.btnSearch.Name = "btnSearch";
    this.btnSearch.Size = new Size(32 /*0x20*/, 32 /*0x20*/);
    this.btnSearch.TabIndex = 11;
    this.ToolTip1.SetToolTip((Control) this.btnSearch, "Click here to execute your search.");
    this.txtSearchFor.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtSearchFor.Location = new Point(208 /*0xD0*/, 16 /*0x10*/);
    this.txtSearchFor.Name = "txtSearchFor";
    this.txtSearchFor.Size = new Size(160 /*0xA0*/, 20);
    this.txtSearchFor.TabIndex = 10;
    this.txtSearchFor.Text = "";
    this.ToolTip1.SetToolTip((Control) this.txtSearchFor, "Enter a value to search for.");
    this.cmbSearchBy.DropDownStyle = ComboBoxStyle.DropDownList;
    this.cmbSearchBy.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.cmbSearchBy.Items.AddRange(new object[4]
    {
      (object) "",
      (object) "Check Number",
      (object) "Check Date",
      (object) "Payee"
    });
    this.cmbSearchBy.Location = new Point(72, 16 /*0x10*/);
    this.cmbSearchBy.Name = "cmbSearchBy";
    this.cmbSearchBy.Size = new Size(128 /*0x80*/, 22);
    this.cmbSearchBy.TabIndex = 9;
    this.ToolTip1.SetToolTip((Control) this.cmbSearchBy, "Select a field to search by.");
    appearance1.BackColor = Color.WhiteSmoke;
    this.cmbBankAccounts.Appearance = (AppearanceBase) appearance1;
    this.cmbBankAccounts.BorderStyle = (UIElementBorderStyle) 1;
    this.cmbBankAccounts.CharacterCasing = CharacterCasing.Normal;
    ((UltraControlBase) this.cmbBankAccounts).Cursor = Cursors.Default;
    ((UltraGridBase) this.cmbBankAccounts).DataMember = "spFin_GetBankAccounts";
    ((UltraGridBase) this.cmbBankAccounts).DataSource = (object) this.DsBankAccounts1;
    ((UltraGridBase) this.cmbBankAccounts).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand.ColHeadersVisible = false;
    appearance2.FontData.Name = "Tahoma";
    appearance2.FontData.SizeInPoints = 18f;
    ultraGridColumn1.CellAppearance = (AppearanceBase) appearance2;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 151;
    ultraGridColumn2.Width = 237;
    ultraGridColumn3.Hidden = true;
    ultraGridColumn3.Width = 137;
    ultraGridBand.Columns.Add((object) ultraGridColumn1);
    ultraGridBand.Columns.Add((object) ultraGridColumn2);
    ultraGridBand.Columns.Add((object) ultraGridColumn3);
    ultraGridBand.GroupHeadersVisible = false;
    ((UltraGridBase) this.cmbBankAccounts).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.cmbBankAccounts).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.cmbBankAccounts).DisplayLayout.Override.AllowRowSummaries = (AllowRowSummaries) 2;
    ((UltraGridBase) this.cmbBankAccounts).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.cmbBankAccounts).DisplayLayout.Override.BorderStyleHeader = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.cmbBankAccounts).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.cmbBankAccounts).DisplayLayout.Override.BorderStyleRowSelector = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.cmbBankAccounts).DisplayLayout.Override.BorderStyleSummaryFooter = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.cmbBankAccounts).DisplayLayout.Override.BorderStyleSummaryFooterCaption = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.cmbBankAccounts).DisplayLayout.Override.BorderStyleSummaryValue = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.cmbBankAccounts).DisplayLayout.Override.BorderStyleTemplateAddRow = (UIElementBorderStyle) 1;
    ((UltraDropDownBase) this.cmbBankAccounts).DisplayMember = "BANKNAME";
    this.cmbBankAccounts.DropDownStyle = (UltraComboStyle) 1;
    ((UltraControlBase) this.cmbBankAccounts).UseFlatMode = (DefaultableBoolean) 1;
    ((Control) this.cmbBankAccounts).Font = new Font("Tahoma", 16f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.cmbBankAccounts).Location = new Point(8, 8);
    ((Control) this.cmbBankAccounts).Name = "cmbBankAccounts";
    ((Control) this.cmbBankAccounts).Size = new Size(544, 32 /*0x20*/);
    ((Control) this.cmbBankAccounts).TabIndex = 10;
    ((UltraDropDownBase) this.cmbBankAccounts).ValueMember = "GLACCTID";
    this.daGetBankAccounts.SelectCommand = this.SqlSelectCommand1;
    this.daGetBankAccounts.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "spFin_GetBankAccounts", new DataColumnMapping[3]
      {
        new DataColumnMapping("GLACCTID", "GLACCTID"),
        new DataColumnMapping("BANKNAME", "BANKNAME"),
        new DataColumnMapping("CLOSED", "CLOSED")
      })
    });
    this.ControlDataConnection.ConnectionString = "workstation id=WREYES;packet size=4096;user id=mgasystems;data source=MGASYSTEMS;persist security info=False;initial catalog=IMS";
    this.SqlSelectCommand1.CommandText = "[spFin_GetBankAccounts]";
    this.SqlSelectCommand1.CommandType = CommandType.StoredProcedure;
    this.SqlSelectCommand1.Connection = this.ControlDataConnection;
    this.SqlSelectCommand1.Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null));
    this.SqlSelectCommand1.Parameters.Add(new SqlParameter("@GLCOMPANYID", SqlDbType.Int, 4));
    this.DsBankAccounts1.DataSetName = "dsBankAccounts";
    this.DsBankAccounts1.Locale = new CultureInfo("en-US");
    this.Label6.AutoSize = true;
    this.Label6.Font = new Font("Tahoma", 16f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label6.ForeColor = Color.DarkGray;
    this.Label6.Location = new Point(560, 8);
    this.Label6.Name = "Label6";
    this.Label6.Size = new Size(173, 29);
    this.Label6.TabIndex = 11;
    this.Label6.Text = "Check Register";
    this.Panel1.Controls.Add((Control) this.panelCheck3);
    this.Panel1.Controls.Add((Control) this.panelCheck1);
    this.Panel1.Controls.Add((Control) this.panelCheck2);
    this.Panel1.Location = new Point(0, 72);
    this.Panel1.Name = "Panel1";
    this.Panel1.Size = new Size(744, 520);
    this.Panel1.TabIndex = 12;
    this.Panel2.Controls.Add((Control) this.btnNextPage);
    this.Panel2.Controls.Add((Control) this.btnPreviousPage);
    this.Panel2.Controls.Add((Control) this.btnPrint);
    this.Panel2.Controls.Add((Control) this.lblPageN_OF_M);
    this.Panel2.Controls.Add((Control) this.GroupBox1);
    this.Panel2.Dock = DockStyle.Bottom;
    this.Panel2.Location = new Point(0, 600);
    this.Panel2.Name = "Panel2";
    this.Panel2.Size = new Size(744, 48 /*0x30*/);
    this.Panel2.TabIndex = 13;
    this.BackColor = Color.WhiteSmoke;
    this.Controls.Add((Control) this.Panel2);
    this.Controls.Add((Control) this.Panel1);
    this.Controls.Add((Control) this.Label6);
    this.Controls.Add((Control) this.cmbBankAccounts);
    this.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Name = nameof (AcctCheckRegister);
    this.Size = new Size(744, 648);
    this.panelCheck1.ResumeLayout(false);
    this.panelCheck2.ResumeLayout(false);
    this.panelCheck3.ResumeLayout(false);
    this.GroupBox1.ResumeLayout(false);
    ((ISupportInitialize) this.cmbBankAccounts).EndInit();
    this.DsBankAccounts1.EndInit();
    this.Panel1.ResumeLayout(false);
    this.Panel2.ResumeLayout(false);
    this.ResumeLayout(false);
  }

  internal int GLCompanyID => this._GLCompanyId;

  public string ConnectionString
  {
    get => this._connectionString;
    set => this._connectionString = value;
  }

  public Image SearchButtonImage
  {
    set => this.btnSearch.Image = value;
  }

  public int BankGLAcct
  {
    get => this._BankGLAcct;
    set => this._BankGLAcct = value;
  }

  private void AcctCheckRegister_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    this.Dock = DockStyle.Fill;
    this.Cursor = Cursors.WaitCursor;
    this.ControlDataConnection.ConnectionString = CurrentUser.Instance.ConnectionString;
    this.ConnectionString = CurrentUser.Instance.ConnectionString;
    this.LoadBankAccounts();
    this.ChangeBackColor();
    if (this.GetData())
    {
      this.SetPage_N_OF_M_Label(this.intPageNumber);
      this.ShowPage(this.intPageNumber);
    }
    this.Cursor = Cursors.Default;
  }

  private void LoadBankAccounts()
  {
    if (this._GLCompanyId == 0)
      return;
    this.DsBankAccounts1.Clear();
    this.daGetBankAccounts.SelectCommand.Parameters["@GLCOMPANYID"].Value = (object) this.GLCompanyID;
    this.daGetBankAccounts.Fill((DataSet) this.DsBankAccounts1);
    this._BankGLAcct = Conversions.ToInteger(this.DsBankAccounts1.Tables[0].Rows[1]["glacctid"]);
    this.cmbBankAccounts.Value = (object) Conversions.ToInteger(this.DsBankAccounts1.Tables[0].Rows[1]["glacctid"]);
  }

  private string ConvertNumericToEnglish(Decimal N)
  {
    double num = Convert.ToDouble(N);
    string english;
    if (Decimal.Compare(N, 0M) == 0)
    {
      english = "Zero";
    }
    else
    {
      string str1 = Decimal.Compare(N, 0M) >= 0 ? "" : "Negative ";
      Decimal d1 = Math.Abs(Decimal.Subtract(N, Conversion.Fix(N)));
      if (Decimal.Compare(N, 0M) < 0 | Decimal.Compare(d1, 0M) != 0)
        N = Math.Abs(Conversion.Fix(N));
      bool flag = Decimal.Compare(N, 1M) >= 0;
      if (Decimal.Compare(N, 1000000000000M) >= 0)
      {
        str1 = $"{str1}{AcctCheckRegister.EnglishDigitGroup(new Decimal(Convert.ToInt32(Decimal.Divide(N, 1000000000000M))))} Trillion";
        N = Decimal.Subtract(N, Decimal.Multiply(Conversion.Int(Decimal.Divide(N, 1000000000000M)), 1000000000000M));
        if (Decimal.Compare(N, 1M) >= 0)
          str1 += " ";
      }
      if (Decimal.Compare(N, 1000000000M) >= 0)
      {
        str1 = $"{str1}{AcctCheckRegister.EnglishDigitGroup(new Decimal(Convert.ToInt32(Decimal.Divide(N, 1000000000M))))} Billion";
        N = Decimal.Subtract(N, Decimal.Multiply(Conversion.Int(Decimal.Divide(N, 1000000000M)), 1000000000M));
        if (Decimal.Compare(N, 1M) >= 0)
          str1 += " ";
      }
      if (Decimal.Compare(N, 1000000M) >= 0)
      {
        str1 = $"{str1}{AcctCheckRegister.EnglishDigitGroup(new Decimal(Convert.ToInt32(N) / 1000000))} Million";
        N = Decimal.Remainder(N, 1000000M);
        if (Decimal.Compare(N, 1M) >= 0)
          str1 += " ";
      }
      if (Decimal.Compare(N, 1000M) >= 0)
      {
        str1 = $"{str1}{AcctCheckRegister.EnglishDigitGroup(new Decimal(Convert.ToInt32(N) / 1000))} Thousand";
        N = Decimal.Remainder(N, 1000M);
        if (Decimal.Compare(N, 1M) >= 0)
          str1 += " ";
      }
      if (Decimal.Compare(N, 1M) >= 0)
        str1 += AcctCheckRegister.EnglishDigitGroup(N);
      if (num > 1.0)
        str1 = num >= 2.0 ? str1 + " Dollars" : str1 + " Dollar";
      string str2;
      if (Decimal.Compare(d1, 0M) == 0)
        str2 = str1 ?? "";
      else if (Decimal.Compare(Conversion.Int(Decimal.Multiply(d1, 100M)), Decimal.Multiply(d1, 100M)) == 0)
      {
        str2 = $"{(!flag ? str1 + "Zero Dollars And " : str1 + " and ")}{Strings.Format((object) Decimal.Multiply(d1, 100M), "00")}/100";
      }
      else
      {
        if (flag)
          str1 += " and ";
        str2 = $"{str1}{Strings.Format((object) Decimal.Multiply(d1, 10000M), "0000")}/10000";
      }
      english = str2;
    }
    return english;
  }

  private static string EnglishDigitGroup(Decimal N)
  {
    string str1 = "";
    bool flag = false;
    switch (Convert.ToInt32(N) / 100)
    {
      case 0:
        str1 = "";
        flag = false;
        break;
      case 1:
        str1 = "One Hundred";
        flag = true;
        break;
      case 2:
        str1 = "Two Hundred";
        flag = true;
        break;
      case 3:
        str1 = "Three Hundred";
        flag = true;
        break;
      case 4:
        str1 = "Four Hundred";
        flag = true;
        break;
      case 5:
        str1 = "Five Hundred";
        flag = true;
        break;
      case 6:
        str1 = "Six Hundred";
        flag = true;
        break;
      case 7:
        str1 = "Seven Hundred";
        flag = true;
        break;
      case 8:
        str1 = "Eight Hundred";
        flag = true;
        break;
      case 9:
        str1 = "Nine Hundred";
        flag = true;
        break;
    }
    if (flag)
      N = Decimal.Remainder(N, 100M);
    string str2;
    if (Decimal.Compare(N, 0M) > 0)
    {
      if (flag)
        str1 += " ";
      switch (Convert.ToInt32(N) / 10)
      {
        case 0:
        case 1:
          flag = false;
          break;
        case 2:
          str1 += "Twenty";
          flag = true;
          break;
        case 3:
          str1 += "Thirty";
          flag = true;
          break;
        case 4:
          str1 += "Forty";
          flag = true;
          break;
        case 5:
          str1 += "Fifty";
          flag = true;
          break;
        case 6:
          str1 += "Sixty";
          flag = true;
          break;
        case 7:
          str1 += "Seventy";
          flag = true;
          break;
        case 8:
          str1 += "Eighty";
          flag = true;
          break;
        case 9:
          str1 += "Ninety";
          flag = true;
          break;
      }
      if (flag)
        N = Decimal.Remainder(N, 10M);
      if (Decimal.Compare(N, 0M) > 0)
      {
        if (flag)
          str1 += "-";
        Decimal d1 = N;
        if (Decimal.Compare(d1, 0M) != 0)
        {
          if (Decimal.Compare(d1, 1M) == 0)
            str1 += "One";
          else if (Decimal.Compare(d1, 2M) == 0)
            str1 += "Two";
          else if (Decimal.Compare(d1, 3M) == 0)
            str1 += "Three";
          else if (Decimal.Compare(d1, 4M) == 0)
            str1 += "Four";
          else if (Decimal.Compare(d1, 5M) == 0)
            str1 += "Five";
          else if (Decimal.Compare(d1, 6M) == 0)
            str1 += "Six";
          else if (Decimal.Compare(d1, 7M) == 0)
            str1 += "Seven";
          else if (Decimal.Compare(d1, 8M) == 0)
            str1 += "Eight";
          else if (Decimal.Compare(d1, 9M) == 0)
            str1 += "Nine";
          else if (Decimal.Compare(d1, 10M) == 0)
            str1 += "Ten";
          else if (Decimal.Compare(d1, 11M) == 0)
            str1 += "Eleven";
          else if (Decimal.Compare(d1, 12M) == 0)
            str1 += "Twelve";
          else if (Decimal.Compare(d1, 13M) == 0)
            str1 += "Thirteen";
          else if (Decimal.Compare(d1, 14M) == 0)
            str1 += "Fourteen";
          else if (Decimal.Compare(d1, 15M) == 0)
            str1 += "Fifteen";
          else if (Decimal.Compare(d1, 16M) == 0)
            str1 += "Sixteen";
          else if (Decimal.Compare(d1, 17M) == 0)
            str1 += "Seventeen";
          else if (Decimal.Compare(d1, 18M) == 0)
            str1 += "Eighteen";
          else if (Decimal.Compare(d1, 19M) == 0)
            str1 += "Nineteen";
        }
        str2 = str1;
      }
      else
        str2 = str1;
    }
    else
      str2 = str1;
    return str2;
  }

  internal bool GetData()
  {
    bool data;
    if (this.ConnectionString.Length == 0)
    {
      data = false;
    }
    else
    {
      this.dsData.Clear();
      SqlConnection selectConnection = new SqlConnection(this.ConnectionString);
      SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("dbo.spFin_CheckRegister", selectConnection);
      sqlDataAdapter.SelectCommand.CommandTimeout = 0;
      sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@GLAccountID", (object) this.BankGLAcct);
      sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
      try
      {
        sqlDataAdapter.Fill(this.dsData);
        this.intPageNumber = 1;
        this.intRecordBuffer = 0;
        data = true;
      }
      catch (SqlException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        ErrorHandler.HandleError((Exception) ex);
        data = false;
        ProjectData.ClearProjectError();
      }
      finally
      {
        selectConnection.Dispose();
        sqlDataAdapter.Dispose();
      }
    }
    return data;
  }

  private void ShowPage(int PageNumber)
  {
    DataTable table = this.dsData.Tables[0];
    if (3 * (PageNumber - 1) > table.Rows.Count - 1)
    {
      this.pictCheck1Background.BringToFront();
    }
    else
    {
      this.pictCheck1Background.SendToBack();
      this.lblCheck1Payee.Text = table.Rows[3 * (PageNumber - 1)]["Payee"].ToString();
      this.lblCheck1AmountCurrency.Text = Strings.Format((object) table.Rows[3 * (PageNumber - 1)]["CHECKAMT"].ToString(), "Currency");
      this.lblCheck1AmountEnglish.Text = this.ConvertNumericToEnglish(Conversions.ToDecimal(table.Rows[3 * (PageNumber - 1)]["CHECKAMT"]));
      this.lblCheck1Date.Text = Strings.Format((object) table.Rows[3 * (PageNumber - 1)]["CHECKDATE"].ToString(), "Short Date");
      this.lblCheck1CheckNumber.Text = table.Rows[3 * (PageNumber - 1)]["CheckNum"].ToString();
      this.lblCheck1BankName.Text = table.Rows[3 * (PageNumber - 1)]["BankName"].ToString();
      this.lblCheck1BankAddress.Text = table.Rows[3 * (PageNumber - 1)]["BankAddress"].ToString();
      this.lblCheck1MGAName.Text = table.Rows[3 * (PageNumber - 1)]["MGAAddress"].ToString();
      this.txtTransactNum1.Text = table.Rows[3 * (PageNumber - 1)]["TRANSACTNUM"].ToString();
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(table.Rows[3 * (PageNumber - 1)]["PRINTDATE"].ToString().Trim(), "NP", false) == 0)
      {
        this.lblCheck1Status.Text = "Not Printed";
        this.lblCheck1Status.ForeColor = Color.Red;
        try
        {
          foreach (Control control in this.panelCheck1.Controls)
          {
            if (Strings.InStr(Conversions.ToString(control.Tag), "STATON") != 0)
              control.Visible = false;
          }
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
      }
      else
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(table.Rows[3 * (PageNumber - 1)]["PRINTDATE"].ToString().Trim(), "NP", false) != 0)
        {
          if (!Conversions.ToBoolean(table.Rows[3 * (PageNumber - 1)]["RECONCILED"]))
          {
            try
            {
              foreach (Control control in this.panelCheck1.Controls)
              {
                if (Strings.InStr(Conversions.ToString(control.Tag), "STATON") != 0)
                  control.Visible = true;
              }
            }
            finally
            {
              IEnumerator enumerator;
              if (enumerator is IDisposable)
                (enumerator as IDisposable).Dispose();
            }
            this.lblCheck1StatusOnText.Text = "Printed On:";
            this.lblCheck1StatusOnValue.Text = table.Rows[3 * (PageNumber - 1)]["PRINTDATE"].ToString();
            this.lblCheck1Status.Text = "Printed";
            this.lblCheck1Status.ForeColor = Color.Green;
            goto label_30;
          }
        }
        if (Conversions.ToBoolean(table.Rows[3 * (PageNumber - 1)]["RECONCILED"]))
        {
          try
          {
            foreach (Control control in this.panelCheck1.Controls)
            {
              if (Strings.InStr(Conversions.ToString(control.Tag), "STATON") != 0)
                control.Visible = true;
            }
          }
          finally
          {
            IEnumerator enumerator;
            if (enumerator is IDisposable)
              (enumerator as IDisposable).Dispose();
          }
          this.lblCheck1StatusOnText.Text = "Reconciled On:";
          this.lblCheck1StatusOnValue.Text = table.Rows[3 * (PageNumber - 1)]["PRINTDATE"].ToString();
          this.lblCheck1Status.Text = "Reconciled";
          this.lblCheck1Status.ForeColor = Color.SteelBlue;
        }
      }
label_30:
      this.picViewTransferForm1.Visible = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblCheck1CheckNumber.Text, "TRANSFER", false) == 0;
      this.picViewTransferForm1.Tag = (object) table.Rows[3 * (PageNumber - 1)]["TRANSACTNUM"].ToString();
    }
    if (3 * (PageNumber - 1) + 1 > table.Rows.Count - 1)
    {
      this.pictCheck2Background.BringToFront();
    }
    else
    {
      this.pictCheck2Background.SendToBack();
      this.lblCheck2Payee.Text = table.Rows[3 * (PageNumber - 1) + 1]["Payee"].ToString();
      this.lblCheck2AmountCurrency.Text = Strings.Format((object) table.Rows[3 * (PageNumber - 1) + 1]["CHECKAMT"].ToString(), "Currency");
      this.lblCheck2AmountEnglish.Text = this.ConvertNumericToEnglish(Conversions.ToDecimal(table.Rows[3 * (PageNumber - 1) + 1]["CHECKAMT"]));
      this.lblCheck2Date.Text = Strings.Format((object) table.Rows[3 * (PageNumber - 1) + 1]["CHECKDATE"].ToString(), "Short Date");
      this.lblCheck2CheckNumber.Text = table.Rows[3 * (PageNumber - 1) + 1]["CheckNum"].ToString();
      this.lblCheck2BankName.Text = table.Rows[3 * (PageNumber - 1) + 1]["BankName"].ToString();
      this.lblCheck2BankAddress.Text = table.Rows[3 * (PageNumber - 1) + 1]["BankAddress"].ToString();
      this.lblCheck2MGAName.Text = table.Rows[3 * (PageNumber - 1) + 1]["MGAAddress"].ToString();
      this.txtTransactNum2.Text = table.Rows[3 * (PageNumber - 1) + 1]["TRANSACTNUM"].ToString();
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(table.Rows[3 * (PageNumber - 1) + 1]["PRINTDATE"].ToString().Trim(), "NP", false) == 0)
      {
        this.lblCheck2Status.Text = "Not Printed";
        this.lblCheck2Status.ForeColor = Color.Red;
        try
        {
          foreach (Control control in this.panelCheck2.Controls)
          {
            if (Strings.InStr(Conversions.ToString(control.Tag), "STATON") != 0)
              control.Visible = false;
          }
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
      }
      else
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(table.Rows[3 * (PageNumber - 1) + 1]["PRINTDATE"].ToString().Trim(), "NP", false) != 0)
        {
          if (!Conversions.ToBoolean(table.Rows[3 * (PageNumber - 1) + 1]["RECONCILED"]))
          {
            try
            {
              foreach (Control control in this.panelCheck2.Controls)
              {
                if (Strings.InStr(Conversions.ToString(control.Tag), "STATON") != 0)
                  control.Visible = true;
              }
            }
            finally
            {
              IEnumerator enumerator;
              if (enumerator is IDisposable)
                (enumerator as IDisposable).Dispose();
            }
            this.lblCheck2StatusOnText.Text = "Printed On:";
            this.lblCheck2StatusOnValue.Text = table.Rows[3 * (PageNumber - 1) + 1]["PRINTDATE"].ToString();
            this.lblCheck2Status.Text = "Printed";
            this.lblCheck2Status.ForeColor = Color.Green;
            goto label_61;
          }
        }
        if (Conversions.ToBoolean(table.Rows[3 * (PageNumber - 1) + 1]["RECONCILED"]))
        {
          try
          {
            foreach (Control control in this.panelCheck2.Controls)
            {
              if (Strings.InStr(Conversions.ToString(control.Tag), "STATON") != 0)
                control.Visible = true;
            }
          }
          finally
          {
            IEnumerator enumerator;
            if (enumerator is IDisposable)
              (enumerator as IDisposable).Dispose();
          }
          this.lblCheck2StatusOnText.Text = "Reconciled On:";
          this.lblCheck2StatusOnValue.Text = table.Rows[3 * (PageNumber - 1) + 1]["PRINTDATE"].ToString();
          this.lblCheck2Status.Text = "Reconciled";
          this.lblCheck2Status.ForeColor = Color.SteelBlue;
        }
      }
label_61:
      this.picViewTransferForm2.Visible = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblCheck2CheckNumber.Text, "TRANSFER", false) == 0;
      this.picViewTransferForm2.Tag = (object) table.Rows[3 * (PageNumber - 1) + 1]["TRANSACTNUM"].ToString();
    }
    if (3 * (PageNumber - 1) + 2 > table.Rows.Count - 1)
    {
      this.pictCheck3Background.BringToFront();
    }
    else
    {
      this.pictCheck3Background.SendToBack();
      this.lblCheck3Payee.Text = table.Rows[3 * (PageNumber - 1) + 2]["Payee"].ToString();
      this.lblCheck3AmountCurrency.Text = Strings.Format((object) table.Rows[3 * (PageNumber - 1) + 2]["CHECKAMT"].ToString(), "Currency");
      this.lblCheck3AmountEnglish.Text = this.ConvertNumericToEnglish(Conversions.ToDecimal(table.Rows[3 * (PageNumber - 1) + 2]["CHECKAMT"]));
      this.lblCheck3Date.Text = Strings.Format((object) table.Rows[3 * (PageNumber - 1) + 2]["CHECKDATE"].ToString(), "Short Date");
      this.lblCheck3CheckNumber.Text = table.Rows[3 * (PageNumber - 1) + 2]["CheckNum"].ToString();
      this.lblCheck3BankName.Text = table.Rows[3 * (PageNumber - 1) + 2]["BankName"].ToString();
      this.lblCheck3BankAddress.Text = table.Rows[3 * (PageNumber - 1) + 2]["BankAddress"].ToString();
      this.lblCheck3MGAName.Text = table.Rows[3 * (PageNumber - 1) + 2]["MGAAddress"].ToString();
      this.txtTransactNum3.Text = table.Rows[3 * (PageNumber - 1) + 2]["TRANSACTNUM"].ToString();
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(table.Rows[3 * (PageNumber - 1) + 2]["PRINTDATE"].ToString().Trim(), "NP", false) == 0)
      {
        this.lblCheck3Status.Text = "Not Printed";
        this.lblCheck3Status.ForeColor = Color.Red;
        try
        {
          foreach (Control control in this.panelCheck3.Controls)
          {
            if (Strings.InStr(Conversions.ToString(control.Tag), "STATON") != 0)
              control.Visible = false;
          }
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
      }
      else
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(table.Rows[3 * (PageNumber - 1) + 2]["PRINTDATE"].ToString().Trim(), "NP", false) != 0)
        {
          if (!Conversions.ToBoolean(table.Rows[3 * (PageNumber - 1) + 2]["RECONCILED"]))
          {
            try
            {
              foreach (Control control in this.panelCheck3.Controls)
              {
                if (Strings.InStr(Conversions.ToString(control.Tag), "STATON") != 0)
                  control.Visible = true;
              }
            }
            finally
            {
              IEnumerator enumerator;
              if (enumerator is IDisposable)
                (enumerator as IDisposable).Dispose();
            }
            this.lblCheck3StatusOnText.Text = "Printed On:";
            this.lblCheck3StatusOnValue.Text = table.Rows[3 * (PageNumber - 1) + 2]["PRINTDATE"].ToString();
            this.lblCheck3Status.Text = "Printed";
            this.lblCheck3Status.ForeColor = Color.Green;
            goto label_92;
          }
        }
        if (Conversions.ToBoolean(table.Rows[3 * (PageNumber - 1) + 2]["RECONCILED"]))
        {
          try
          {
            foreach (Control control in this.panelCheck3.Controls)
            {
              if (Strings.InStr(Conversions.ToString(control.Tag), "STATON") != 0)
                control.Visible = true;
            }
          }
          finally
          {
            IEnumerator enumerator;
            if (enumerator is IDisposable)
              (enumerator as IDisposable).Dispose();
          }
          this.lblCheck3StatusOnText.Text = "Reconciled On:";
          this.lblCheck3StatusOnValue.Text = table.Rows[3 * (PageNumber - 1) + 2]["PRINTDATE"].ToString();
          this.lblCheck3Status.Text = "Reconciled";
          this.lblCheck3Status.ForeColor = Color.SteelBlue;
        }
      }
label_92:
      this.picViewTransferForm3.Visible = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblCheck3CheckNumber.Text, "TRANSFER", false) == 0;
      this.picViewTransferForm3.Tag = (object) table.Rows[3 * (PageNumber - 1) + 2]["TRANSACTNUM"].ToString();
    }
  }

  private void SetPage_N_OF_M_Label(int PageNumber)
  {
    try
    {
      if (this.dsData.Tables[0].Rows.Count == 0)
        return;
      this.lblPageN_OF_M.Text = $"Page {Conversions.ToString(PageNumber)} of ";
      if (this.dsData.Tables[0].Rows.Count < 3)
      {
        this.lblPageN_OF_M.Text += "1";
        this.intMaxPage = 1;
      }
      else
      {
        this.lblPageN_OF_M.Text += Conversions.ToString(this.dsData.Tables[0].Rows.Count / 3 + Conversions.ToInteger(Interaction.IIf(this.dsData.Tables[0].Rows.Count % 3 > 0, (object) 1, (object) 0)));
        this.intMaxPage = this.dsData.Tables[0].Rows.Count / 3 + Conversions.ToInteger(Interaction.IIf(this.dsData.Tables[0].Rows.Count % 3 > 0, (object) 1, (object) 0));
      }
    }
    finally
    {
      this.Cursor = Cursors.Default;
    }
  }

  private void btnNextPage_Click(object sender, EventArgs e)
  {
    this.ChangeBackColor();
    if (this.intPageNumber == this.intMaxPage)
      return;
    // ISSUE: variable of a reference type
    int& local;
    // ISSUE: explicit reference operation
    int num = ^(local = ref this.intPageNumber) + 1;
    local = num;
    this.ClearAllSearchIcons();
    this.Cursor = Cursors.WaitCursor;
    this.SetPage_N_OF_M_Label(this.intPageNumber);
    this.ShowPage(this.intPageNumber);
    this.Cursor = Cursors.Default;
  }

  private void btnPreviousPage_Click(object sender, EventArgs e)
  {
    this.ChangeBackColor();
    if (this.intPageNumber == 1)
      return;
    // ISSUE: variable of a reference type
    int& local;
    // ISSUE: explicit reference operation
    int num = ^(local = ref this.intPageNumber) - 1;
    local = num;
    this.ClearAllSearchIcons();
    this.Cursor = Cursors.WaitCursor;
    this.SetPage_N_OF_M_Label(this.intPageNumber);
    this.ShowPage(this.intPageNumber);
    this.Cursor = Cursors.Default;
  }

  private void ChangeBackColor()
  {
    Color color;
    switch (Conversion.Int(5f * VBMath.Rnd()))
    {
      case 1f:
        color = Color.White;
        break;
      case 2f:
        color = Color.Linen;
        break;
      case 3f:
        color = Color.WhiteSmoke;
        break;
      case 4f:
        color = Color.LightSteelBlue;
        break;
      case 5f:
        color = Color.Wheat;
        break;
      default:
        color = Color.White;
        break;
    }
    try
    {
      foreach (Control control in this.panelCheck1.Controls)
      {
        if (Strings.InStr(Conversions.ToString(control.Tag), "LINE") == 0)
          control.BackColor = color;
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    try
    {
      foreach (Control control in this.panelCheck2.Controls)
      {
        if (Strings.InStr(Conversions.ToString(control.Tag), "LINE") == 0)
          control.BackColor = color;
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    try
    {
      foreach (Control control in this.panelCheck3.Controls)
      {
        if (Strings.InStr(Conversions.ToString(control.Tag), "LINE") == 0)
          control.BackColor = color;
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void btnSearch_Click(object sender, EventArgs e)
  {
    if (this.DesignMode || this.dsData.Tables.Count == 0 || this.dsData.Tables[0].Rows.Count == 0)
      return;
    if (this.ValidateSearchInput())
    {
      this.SearchCheck(this.sbSearchBy, this.txtSearchFor.Text);
      this.ClearSearchCriteria();
    }
    else
    {
      int num = (int) MessageBox.Show("Invalid search criteria!", "Invavlid Search Criteria!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      this.ClearSearchCriteria();
    }
  }

  private bool ValidateSearchInput()
  {
    bool flag;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbSearchBy.Text.Trim(), "", false) == 0)
      flag = false;
    else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtSearchFor.Text, "", false) == 0)
    {
      flag = false;
    }
    else
    {
      string text = this.cmbSearchBy.Text;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text, "Check Number", false) != 0)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text, "Check Date", false) != 0)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text, "Payee", false) == 0)
          {
            this.sbSearchBy = AcctCheckRegister.SearchBy.Payee;
            flag = true;
          }
          else
            flag = false;
        }
        else if (!Information.IsDate((object) this.txtSearchFor.Text))
        {
          flag = false;
        }
        else
        {
          this.sbSearchBy = AcctCheckRegister.SearchBy.CheckDate;
          flag = true;
        }
      }
      else if (!Versioned.IsNumeric((object) this.txtSearchFor.Text))
      {
        flag = false;
      }
      else
      {
        this.sbSearchBy = AcctCheckRegister.SearchBy.CheckNumber;
        flag = true;
      }
    }
    return flag;
  }

  private void SearchCheck(AcctCheckRegister.SearchBy SearchType, string SearchFor)
  {
    this.ClearAllSearchIcons();
    string filterExpression = string.Empty;
    switch (SearchType)
    {
      case AcctCheckRegister.SearchBy.CheckNumber:
        if (Versioned.IsNumeric((object) SearchFor))
        {
          filterExpression = $"checknum = '{SearchFor}'";
          break;
        }
        break;
      case AcctCheckRegister.SearchBy.CheckDate:
        if (Information.IsDate((object) SearchFor))
        {
          filterExpression = $"CheckDate = '{SearchFor}'";
          break;
        }
        break;
      case AcctCheckRegister.SearchBy.Payee:
        filterExpression = $"payee LIKE '{SearchFor}%'";
        break;
    }
    DataRow[] dataRowArray1 = this.dsData.Tables[0].Select(filterExpression);
    if (dataRowArray1.Length <= 0)
    {
      this.ClearAllSearchIcons();
    }
    else
    {
      DataRow[] dataRowArray2 = dataRowArray1;
      int index = 0;
      if (index < dataRowArray2.Length)
      {
        DataRow dataRow = dataRowArray2[index];
        try
        {
          foreach (DataRow row in this.dsData.Tables[0].Rows)
          {
            int num;
            if (Conversions.ToInteger(row["transactnum"]) == Conversions.ToInteger(dataRow["transactnum"]))
            {
              this.intPageNumber = num / 3 + 1;
              this.SetPage_N_OF_M_Label(this.intPageNumber);
              this.ShowPage(this.intPageNumber);
              this.ShowSearchIcon(SearchType, num % 3);
              break;
            }
            ++num;
          }
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
      }
      this.ClearSearchCriteria();
    }
  }

  private void ClearAllSearchIcons()
  {
    this.pic1SearchCheckNum.Image = (Image) null;
    this.pic1SearchDate.Image = (Image) null;
    this.pic1SearchPayee.Image = (Image) null;
    this.pic2SearchCheckNum.Image = (Image) null;
    this.pic2SearchDate.Image = (Image) null;
    this.pic2SearchPayee.Image = (Image) null;
    this.pic3SearchCheckNum.Image = (Image) null;
    this.pic3SearchDate.Image = (Image) null;
    this.pic3SearchPayee.Image = (Image) null;
  }

  private void ShowSearchIcon(AcctCheckRegister.SearchBy SearchType, int CheckPanel)
  {
    switch (CheckPanel)
    {
      case 0:
        switch (SearchType)
        {
          case AcctCheckRegister.SearchBy.CheckNumber:
            this.pic1SearchPayee.Image = (Image) null;
            this.pic1SearchDate.Image = (Image) null;
            this.pic1SearchCheckNum.Image = this.btnSearch.Image;
            return;
          case AcctCheckRegister.SearchBy.CheckDate:
            this.pic1SearchPayee.Image = (Image) null;
            this.pic1SearchCheckNum.Image = (Image) null;
            this.pic1SearchDate.Image = this.btnSearch.Image;
            return;
          case AcctCheckRegister.SearchBy.Payee:
            this.pic1SearchCheckNum.Image = (Image) null;
            this.pic1SearchDate.Image = (Image) null;
            this.pic1SearchPayee.Image = this.btnSearch.Image;
            return;
          default:
            return;
        }
      case 1:
        switch (SearchType)
        {
          case AcctCheckRegister.SearchBy.CheckNumber:
            this.pic2SearchPayee.Image = (Image) null;
            this.pic2SearchDate.Image = (Image) null;
            this.pic2SearchCheckNum.Image = this.btnSearch.Image;
            return;
          case AcctCheckRegister.SearchBy.CheckDate:
            this.pic2SearchPayee.Image = (Image) null;
            this.pic2SearchCheckNum.Image = (Image) null;
            this.pic2SearchDate.Image = this.btnSearch.Image;
            return;
          case AcctCheckRegister.SearchBy.Payee:
            this.pic2SearchCheckNum.Image = (Image) null;
            this.pic2SearchDate.Image = (Image) null;
            this.pic2SearchPayee.Image = this.btnSearch.Image;
            return;
          default:
            return;
        }
      case 2:
        switch (SearchType)
        {
          case AcctCheckRegister.SearchBy.CheckNumber:
            this.pic3SearchPayee.Image = (Image) null;
            this.pic3SearchDate.Image = (Image) null;
            this.pic3SearchCheckNum.Image = this.btnSearch.Image;
            return;
          case AcctCheckRegister.SearchBy.CheckDate:
            this.pic3SearchPayee.Image = (Image) null;
            this.pic3SearchCheckNum.Image = (Image) null;
            this.pic3SearchDate.Image = this.btnSearch.Image;
            return;
          case AcctCheckRegister.SearchBy.Payee:
            this.pic3SearchCheckNum.Image = (Image) null;
            this.pic3SearchDate.Image = (Image) null;
            this.pic3SearchPayee.Image = this.btnSearch.Image;
            return;
          default:
            return;
        }
    }
  }

  private void ClearSearchCriteria()
  {
    this.cmbSearchBy.ResetText();
    this.txtSearchFor.Text = "";
  }

  private void btnPrint_Click(object sender, EventArgs e)
  {
    frmPrintChecks form = ObjectFactory.Instance.CreateForm(typeof (frmPrintChecks), new object[2]
    {
      (object) this.GeneratePrintTable(),
      (object) this._BankGLAcct
    }) as frmPrintChecks;
    try
    {
      int num = (int) form.ShowDialog();
    }
    finally
    {
      form.Dispose();
    }
  }

  internal DataTable GeneratePrintTable()
  {
    DataTable dataTable = new DataTable();
    DataColumnCollection columns = dataTable.Columns;
    columns.Add(new DataColumn("CheckNum", Type.GetType("System.Int32")));
    columns.Add(new DataColumn("Payee", Type.GetType("System.String")));
    columns.Add(new DataColumn("CheckDate", Type.GetType("System.DateTime")));
    columns.Add(new DataColumn("AmountEnglish", Type.GetType("System.String")));
    columns.Add(new DataColumn("AmountCurrency", Type.GetType("System.String")));
    columns.Add(new DataColumn("E13BCheck", Type.GetType("System.String")));
    columns.Add(new DataColumn("E13BRouting", Type.GetType("System.String")));
    columns.Add(new DataColumn("E13BAccount", Type.GetType("System.String")));
    columns.Add(new DataColumn("E13BAmount", Type.GetType("System.String")));
    columns.Add(new DataColumn("BANKNAME", Type.GetType("System.String")));
    columns.Add(new DataColumn("BANKADDRESS", Type.GetType("System.String")));
    columns.Add(new DataColumn("TRANSITNUM", Type.GetType("System.String")));
    columns.Add(new DataColumn("MGANAME", Type.GetType("System.String")));
    columns.Add(new DataColumn("MGAADDRESS", Type.GetType("System.String")));
    columns.Add(new DataColumn("CHECKMEMO", Type.GetType("System.String")));
    columns.Add(new DataColumn("TRANSACTNUM", Type.GetType("System.Int32")));
    columns.Add(new DataColumn("PAYEEADDRESS", Type.GetType("System.String")));
    DataRow[] dataRowArray1 = this.dsData.Tables[0].Select("CheckNum <> 'TRANSFER' and PRINTDATE = 'NP' and RECONCILED = 0");
    DataTable printTable;
    if (dataRowArray1.Length > 0)
    {
      DataRow[] dataRowArray2 = dataRowArray1;
      int index = 0;
      while (index < dataRowArray2.Length)
      {
        DataRow dataRow = dataRowArray2[index];
        DataRow row = dataTable.NewRow();
        row["CHECKNUM"] = RuntimeHelpers.GetObjectValue(dataRow["CHECKNUM"]);
        row["PAYEE"] = RuntimeHelpers.GetObjectValue(dataRow["PAYEE"]);
        row["CHECKDATE"] = (object) Strings.Mid(dataRow["CHECKDATE"].ToString(), 1, 10);
        row["CHECKMEMO"] = RuntimeHelpers.GetObjectValue(dataRow["CHECKMEMO"]);
        string Expression;
        int num;
        for (Expression = this.ConvertNumericToEnglish(Conversions.ToDecimal(dataRow["CHECKAMT"])) + " "; num + Strings.Len(Expression) < 160 /*0xA0*/; ++num)
          Expression += "X";
        row["AMOUNTENGLISH"] = (object) Expression;
        row["AMOUNTCURRENCY"] = (object) Strings.Format((object) dataRow["CHECKAMT"].ToString(), "Currency");
        row["E13BCheck"] = (object) this.CreateE13BCheckNumber(Conversions.ToString(dataRow["CHECKNUM"]));
        row["E13BRouting"] = (object) this.CreateE13BRoutingNumber(Conversions.ToString(dataRow["ABAROUTENUM"]));
        row["E13BAccount"] = (object) this.CreateE13BAccountNumber(Conversions.ToString(dataRow["BANKACCTNUM"]));
        row["E13BAmount"] = (object) this.CreateE13BAmount(dataRow["CHECKAMT"].ToString());
        row["BANKNAME"] = RuntimeHelpers.GetObjectValue(dataRow["BANKNAME"]);
        row["BANKADDRESS"] = RuntimeHelpers.GetObjectValue(dataRow["BANKADDRESS"]);
        row["MGANAME"] = RuntimeHelpers.GetObjectValue(dataRow["MGANAME"]);
        row["MGAADDRESS"] = RuntimeHelpers.GetObjectValue(dataRow["MGAADDRESS"]);
        row["TRANSITNUM"] = RuntimeHelpers.GetObjectValue(dataRow["ABAFRACTIONALTRANSITNUM"]);
        row["TRANSACTNUM"] = RuntimeHelpers.GetObjectValue(dataRow["TRANSACTNUM"]);
        row["PAYEEADDRESS"] = RuntimeHelpers.GetObjectValue(dataRow["PAYEEADDRESS"]);
        dataTable.Rows.Add(row);
        num = 0;
        checked { ++index; }
      }
      printTable = dataTable;
    }
    else
    {
      dataTable.Dispose();
      printTable = (DataTable) null;
    }
    return printTable;
  }

  private string CreateE13BString(
    string CheckNumber,
    string RoutingNumber,
    string AccountNumber,
    string Amount)
  {
    string str = "C";
    int num;
    for (; num + Strings.Len(CheckNumber) < 6; ++num)
      str += "0";
    return $"{$"{str}{CheckNumber}C  A"}{RoutingNumber}A  {AccountNumber}C    B{Amount.Substring(0, Strings.InStr(Amount, ".") - 1)}B{Amount.Substring(Strings.InStr(Amount, ".") + 1, 2)}";
  }

  private string CreateE13BCheckNumber(string CheckNumber)
  {
    string str = "C";
    int num;
    for (; num + Strings.Len(CheckNumber) < 6; ++num)
      str += "0";
    return $"{str}{CheckNumber}C";
  }

  private string CreateE13BRoutingNumber(string RoutingNumber) => $"A{RoutingNumber}A";

  private string CreateE13BAccountNumber(string AccountNumber) => AccountNumber + "C";

  private string CreateE13BAmount(string Amount)
  {
    return $"B{Amount.Substring(0, Strings.InStr(Amount, ".") - 1)}B{Amount.Substring(Strings.InStr(Amount, "."), 2)}";
  }

  private void ViewTransferFax(object sender, EventArgs e)
  {
    rptCustomerRemittance rpt = new rptCustomerRemittance(Conversions.ToInteger(((Control) sender).Tag));
    rpt.Run();
    ReportFactory.Instance.ShowReport((SectionReport) rpt, true);
    rpt.Dispose();
  }

  public void RefreshData()
  {
    if (this.DesignMode)
      return;
    this.Cursor = Cursors.WaitCursor;
    int intPageNumber = this.intPageNumber;
    this.ChangeBackColor();
    if (this.GetData())
    {
      this.intPageNumber = intPageNumber;
      this.SetPage_N_OF_M_Label(this.intPageNumber);
      this.ShowPage(this.intPageNumber);
    }
    this.Cursor = Cursors.Default;
  }

  private void VoidCheck(object sender, EventArgs e)
  {
    if (MessageBox.Show("Are you sure you wish to void this check, this action can not be undone?", "Permanently Void This Check?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
      return;
    int integer;
    if (sender == this.lblVoidCheck1)
      integer = Conversions.ToInteger(this.txtTransactNum1.Text);
    else if (sender == this.lblVoidCheck2)
      integer = Conversions.ToInteger(this.txtTransactNum2.Text);
    else if (sender == this.lblVoidCheck3)
      integer = Conversions.ToInteger(this.txtTransactNum3.Text);
    SqlCommand sqlCommand = new SqlCommand("spFin_VoidJournalTransaction", new SqlConnection(CurrentUser.Instance.ConnectionString));
    sqlCommand.CommandTimeout = 300;
    sqlCommand.CommandType = CommandType.StoredProcedure;
    try
    {
      sqlCommand.Connection.Open();
      sqlCommand.Transaction = sqlCommand.Connection.BeginTransaction();
      sqlCommand.Parameters.AddWithValue("@TRANSACTNUM_VOIDEE", (object) integer);
      sqlCommand.Parameters.AddWithValue("@USERGUID", (object) CurrentUser.Instance.UserGUID);
      sqlCommand.ExecuteNonQuery();
      sqlCommand.Transaction.Commit();
      sqlCommand.Connection.Close();
      this.Cursor = Cursors.WaitCursor;
      this.ChangeBackColor();
      if (!this.GetData())
        return;
      this.SetPage_N_OF_M_Label(this.intPageNumber);
      this.ShowPage(this.intPageNumber);
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      if (sqlCommand.Transaction != null)
        sqlCommand.Transaction.Rollback();
      ProjectData.ClearProjectError();
    }
    finally
    {
      if (sqlCommand.Transaction != null)
        sqlCommand.Transaction.Dispose();
      sqlCommand.Connection.Close();
      sqlCommand.Connection.Dispose();
      sqlCommand.Dispose();
      this.Cursor = Cursors.Default;
    }
  }

  private void VoidLabelMouseOver(object sender, EventArgs e)
  {
    ((Control) sender).ForeColor = Color.LightSteelBlue;
  }

  private void VoidLabelMouseOut(object sender, EventArgs e)
  {
    ((Control) sender).ForeColor = Color.Black;
  }

  private void cmbBankAccounts_RowSelected(object sender, RowSelectedEventArgs e)
  {
    if (((UltraDropDownBase) this.cmbBankAccounts).SelectedRow == null)
      return;
    this._BankGLAcct = Conversions.ToInteger(((UltraDropDownBase) this.cmbBankAccounts).SelectedRow.Cells["glacctid"].Value);
    this.ChangeBackColor();
    if (!this.GetData())
      return;
    this.SetPage_N_OF_M_Label(this.intPageNumber);
    this.ShowPage(this.intPageNumber);
  }

  private enum SearchBy
  {
    CheckNumber,
    CheckDate,
    Payee,
  }
}
