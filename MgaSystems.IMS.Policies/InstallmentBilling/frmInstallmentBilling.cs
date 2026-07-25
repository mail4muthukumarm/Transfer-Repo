// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.InstallmentBilling.frmInstallmentBilling
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Common.ErrorHandling;
using MGASystems.Common.Extensions;
using MGASystems.Common.Settings;
using MGASystems.Common.ThreadingFunctions;
using MGASystems.Data;
using MGASystems.IMS.NoteDocuments;
using MGASystems.IMS.Policies.AccountingTransfer;
using MGASystems.IMS.Policies.BindPolicy;
using MGASystems.IMS.Policies.Endorsements;
using MGASystems.IMS.Policies.PolicyDetail;
using MGASystems.IMS.Security;
using MGASystems.Tools;
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
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies.InstallmentBilling;

[SecureResource("{D1C49040-E310-4f9f-BBE0-B09B54369409}", "Allow Binding with Different Billing Types", "Allow binding with different policy and downpayment billing types.", "Policies")]
[SecureResource("{7BF5790B-D172-4258-B05F-437AACC299C2}", "Change Date Billed", "Controls the abillity to change the date billed for an invoice.", "Invoices")]
public class frmInstallmentBilling : Form, IMessageListener, ITransactionDateBilling
{
  private IContainer components;
  private UltraLabel Label1;
  private UltraLabel Label2;
  private UltraLabel lblPremium;
  private UltraLabel lblTotalFees;
  private UltraLabel lblAllocated;
  private UltraLabel Label4;
  private UltraLabel lblRemaining;
  private UltraLabel Label6;
  private DbDataAdapter daInstallmentBilling;
  private UltraLabel Label3;
  private UltraGroupBox panelPleaseWait;
  private BouncingProgress BouncingProgress1;
  private DbCommand DbSelectCommand1;
  internal const string ChangeDateBilled = "{7BF5790B-D172-4258-B05F-437AACC299C2}";
  internal const string AllowBindWithDiffInstallAndPolicyBillingTypes = "{D1C49040-E310-4f9f-BBE0-B09B54369409}";
  private Quote _quote;
  private QuoteOption _quoteOption;
  private readonly int _quoteOptionID;
  private Dictionary<int, Decimal> _totalPremium;
  private Dictionary<int, Decimal> _totalFees;
  private Dictionary<int, string> _billingTypes;
  private bool _dataUpdated;
  private bool _splitAcross;
  private List<InstallmentInvoiceItem> _selectedInvoices;
  private int _paymentTerms;
  private MemoryStream _gridLayout;
  private bool _roundPremiums;
  private bool _blackBoxMode;
  private Dictionary<int, bool> _officeDownPayment;
  private Dictionary<int, int> _officeInvCount;
  private Decimal _premiumSum;
  private Decimal _feesSum;
  private string _premiumDisplay;
  private Dictionary<int, DateTime> _dateDue;
  private bool _usingEffectiveDateBilled;
  private bool _usingPolicyEffective;
  private bool _usingDayOfMonth;
  private int _dayOfMonthNumber;
  private int _effectiveDateDay;
  private Dictionary<int, DateTime> _dateBilling;
  private bool _monthFollowingDownPayment;
  private bool _monthFollowingDownPayment_Eff;
  private bool _monthFollowingDownPayment_Eff_DateBilled;
  private int _effectiveAltFirstInstallDays;
  private int _effDateBilledAltFirstInstallDays;
  private bool _installmentFromDateBilled;
  private bool _installmentFromEffectiveDate;
  private bool _setWeekendInvoiceDueDatesToMonday;
  private bool _makeFirstPaymentEqualsDownpaymentIfLess;
  private bool _useMonth;
  private int _dayOfMonthAltFirstInstallDays;
  private bool _deferDateBilledToCloseDate;
  private DateTime _closedDate;
  private bool _noProducerLineSetupForProducerLocation;
  private bool _revertToEffectiveDateDay;
  private bool _downpaymentFromEffectiveDate;
  private bool _downpaymentFromDateBilled;
  private int _billingDateDaysFromDueDate;
  private bool _useEffectiveDateForBilling;
  private bool _dateBilledEqualToDueDate;
  private bool _downPaymentGAAP;
  private bool _useMonthForAltFirstInstallment;
  private bool _singlePay;
  private bool _incorporateClosedDateTime;
  private bool _alreadyEvaluateGaap;
  private bool _isEndorsement;
  private int _glCompanyID;
  private bool _monthFollowingDownPayment_Exp;
  private bool _usingPolicyExpiration;
  private bool _revertToExpirationDateDay;
  private int _expirationDateDay;
  private int _expirationAltFirstInstallDays;
  private bool _downPaymentFromEffEndMonth;
  private bool _ignoreDueDateIncrementOnZeroPaymentTerm;
  private bool _implementDayOfMonthOnMonthFollowingDownPayment;
  private bool _setDueDateEqualsBillDate;
  private DateTime _tmpPolicyExpirationDate;
  private bool _allowDateDueLessThanDateBilled;
  private bool _includeEndorsementsForGAAP;
  private bool _implementEffectiveGAAP;
  private readonly CultureInfo _cultureInfo;
  private int _effDateBilledAltFinalInstallDays;
  private int _effectiveAltFinalInstallDays;
  private int _expirationAltFinalInstallDays;
  private int _dayOfMonthAltFinalInstallDays;
  private bool _useMonthFinalInstallment;
  private int _totalPayments;
  private bool _assignRemainderFinalInstallment;
  public static List<string> SpreadFees = new List<string>((IEnumerable<string>) new string[17]
  {
    "A",
    "B",
    "G",
    "H",
    "I",
    "2",
    "3",
    "4",
    "5",
    "6",
    "=",
    "@",
    "#",
    "$",
    "%",
    "^",
    "+"
  });

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [field: AccessedThroughProperty("ds")]
  protected virtual dsInstallmentBilling ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual UltraGrid dgInstallments
  {
    get => this._dgInstallments;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      InitializeRowEventHandler initializeRowEventHandler = new InitializeRowEventHandler(this.dgInstallments_InitializeRow);
      BeforeCellUpdateEventHandler updateEventHandler = new BeforeCellUpdateEventHandler(this.dgInstallments_BeforeCellUpdate);
      CellEventHandler cellEventHandler = new CellEventHandler(this.dgInstallments_AfterCellUpdate);
      UltraGrid dgInstallments1 = this._dgInstallments;
      if (dgInstallments1 != null)
      {
        dgInstallments1.InitializeRow -= initializeRowEventHandler;
        dgInstallments1.BeforeCellUpdate -= updateEventHandler;
        dgInstallments1.AfterCellUpdate -= cellEventHandler;
      }
      this._dgInstallments = value;
      UltraGrid dgInstallments2 = this._dgInstallments;
      if (dgInstallments2 == null)
        return;
      dgInstallments2.InitializeRow += initializeRowEventHandler;
      dgInstallments2.BeforeCellUpdate += updateEventHandler;
      dgInstallments2.AfterCellUpdate += cellEventHandler;
    }
  }

  protected virtual MGAButton btnPaymentOptions
  {
    get => this._btnPaymentOptions;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnPaymentOptions_Click);
      MGAButton btnPaymentOptions1 = this._btnPaymentOptions;
      if (btnPaymentOptions1 != null)
        ((Control) btnPaymentOptions1).Click -= eventHandler;
      this._btnPaymentOptions = value;
      MGAButton btnPaymentOptions2 = this._btnPaymentOptions;
      if (btnPaymentOptions2 == null)
        return;
      ((Control) btnPaymentOptions2).Click += eventHandler;
    }
  }

  private virtual MGAButton btnSplit
  {
    get => this._btnSplit;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnSplit_Click);
      MGAButton btnSplit1 = this._btnSplit;
      if (btnSplit1 != null)
        ((Control) btnSplit1).Click -= eventHandler;
      this._btnSplit = value;
      MGAButton btnSplit2 = this._btnSplit;
      if (btnSplit2 == null)
        return;
      ((Control) btnSplit2).Click += eventHandler;
    }
  }

  protected virtual MGAButton btnBind
  {
    get => this._btnBind;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnBind_Click);
      MGAButton btnBind1 = this._btnBind;
      if (btnBind1 != null)
        ((Control) btnBind1).Click -= eventHandler;
      this._btnBind = value;
      MGAButton btnBind2 = this._btnBind;
      if (btnBind2 == null)
        return;
      ((Control) btnBind2).Click += eventHandler;
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("Offices", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("OfficeID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("Location");
    Appearance appearance2 = new Appearance();
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("TotalPremium");
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("OfficesInvoices");
    UltraGridBand ultraGridBand2 = new UltraGridBand("OfficesInvoices", 0);
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("InvoiceNum");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("DateDue");
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("DateBilled");
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("OfficeID");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("Comment");
    Appearance appearance9 = new Appearance();
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("IsDownpayment");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("BillingType");
    Appearance appearance10 = new Appearance();
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("ModifiesInvoiceNum");
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("BillTo");
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("AdditionalInterestID");
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("PaymentsPaymentItems");
    UltraGridBand ultraGridBand3 = new UltraGridBand("PaymentsPaymentItems", 1);
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("InvoiceNum");
    UltraGridColumn ultraGridColumn17 = new UltraGridColumn("ItemType");
    Appearance appearance11 = new Appearance();
    UltraGridColumn ultraGridColumn18 = new UltraGridColumn("Amount");
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    UltraGridColumn ultraGridColumn19 = new UltraGridColumn("Description");
    Appearance appearance14 = new Appearance();
    UltraGridColumn ultraGridColumn20 = new UltraGridColumn("ModFactor");
    UltraGridColumn ultraGridColumn21 = new UltraGridColumn("OptionFeeID");
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    Appearance appearance17 = new Appearance();
    Appearance appearance18 = new Appearance();
    Appearance appearance19 = new Appearance();
    Appearance appearance20 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmInstallmentBilling));
    Appearance appearance31 = new Appearance();
    Appearance appearance32 = new Appearance();
    this.ds = new dsInstallmentBilling();
    this.dgInstallments = new UltraGrid();
    this.Label1 = new UltraLabel();
    this.Label2 = new UltraLabel();
    this.lblPremium = new UltraLabel();
    this.lblTotalFees = new UltraLabel();
    this.lblAllocated = new UltraLabel();
    this.Label4 = new UltraLabel();
    this.lblRemaining = new UltraLabel();
    this.Label6 = new UltraLabel();
    this.daInstallmentBilling = DefaultDatabase.CreateDataAdapter();
    this.DbSelectCommand1 = DefaultDatabase.CreateCommand();
    this.panelPleaseWait = new UltraGroupBox();
    this.BouncingProgress1 = new BouncingProgress();
    this.Label3 = new UltraLabel();
    this.btnPaymentOptions = new MGAButton();
    this.btnSplit = new MGAButton();
    this.btnBind = new MGAButton();
    this.lblCurrentTime = new Label();
    this.lblServerTime = new Label();
    this.GroupBox1 = new GroupBox();
    this.ds.BeginInit();
    ((ISupportInitialize) this.dgInstallments).BeginInit();
    ((ISupportInitialize) this.panelPleaseWait).BeginInit();
    ((Control) this.panelPleaseWait).SuspendLayout();
    ((ISupportInitialize) this.btnPaymentOptions).BeginInit();
    ((ISupportInitialize) this.btnSplit).BeginInit();
    ((ISupportInitialize) this.btnBind).BeginInit();
    this.GroupBox1.SuspendLayout();
    this.SuspendLayout();
    this.ds.DataSetName = "dsInstallmentBilling";
    this.ds.Locale = new CultureInfo("en-US");
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((Control) this.dgInstallments).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.dgInstallments).DataSource = (object) this.ds.Offices;
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.dgInstallments).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.dgInstallments).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 140;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance2).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn2.Header).Appearance = (AppearanceBase) appearance2;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Office";
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Width = 313;
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance3).TextHAlignAsString = "Right";
    ultraGridColumn3.CellAppearance = (AppearanceBase) appearance3;
    ultraGridColumn3.Format = "c";
    ((AppearanceBase) appearance4).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn3.Header).Appearance = (AppearanceBase) appearance4;
    ((HeaderBase) ultraGridColumn3.Header).Caption = "Premium";
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridColumn3.Width = 268;
    ultraGridColumn4.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn4.Header.VisiblePosition = 3;
    ultraGridBand1.Columns.AddRange(new object[4]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4
    });
    ultraGridBand1.Override.AllowUpdate = (DefaultableBoolean) 2;
    ultraGridColumn5.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn5.Header).Caption = "Invoice #";
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn5.Header.VisiblePosition = 0;
    ultraGridColumn5.Hidden = true;
    ultraGridColumn6.AutoCompleteMode = (AutoCompleteMode) 2;
    appearance5.BackColor = Color.LightYellow;
    ultraGridColumn6.CellAppearance = (AppearanceBase) appearance5;
    ultraGridColumn6.Format = "";
    ((AppearanceBase) appearance6).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn6.Header).Appearance = (AppearanceBase) appearance6;
    ((HeaderBase) ultraGridColumn6.Header).Caption = "Due";
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn6.Header.VisiblePosition = 1;
    ultraGridColumn6.Width = 68;
    ultraGridColumn7.AutoCompleteMode = (AutoCompleteMode) 2;
    appearance7.BackColor = Color.LightYellow;
    ultraGridColumn7.CellAppearance = (AppearanceBase) appearance7;
    ((AppearanceBase) appearance8).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn7.Header).Appearance = (AppearanceBase) appearance8;
    ((HeaderBase) ultraGridColumn7.Header).Caption = "Billed";
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn7.Header.VisiblePosition = 2;
    ultraGridColumn7.Width = 67;
    ultraGridColumn8.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn8.Header.VisiblePosition = 3;
    ultraGridColumn8.Hidden = true;
    ultraGridColumn9.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance9).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn9.Header).Appearance = (AppearanceBase) appearance9;
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn9.Header.VisiblePosition = 4;
    ultraGridColumn9.Width = 121;
    ultraGridColumn10.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn10.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn10.Header).Caption = "Downpayment";
    ((HeaderBase) ultraGridColumn10.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn10.Header.VisiblePosition = 5;
    ultraGridColumn10.Width = 71;
    ultraGridColumn11.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn11.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance10).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn11.Header).Appearance = (AppearanceBase) appearance10;
    ((HeaderBase) ultraGridColumn11.Header).Caption = "Billing Type";
    ((HeaderBase) ultraGridColumn11.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn11.Header.VisiblePosition = 6;
    ultraGridColumn11.Width = 150;
    ultraGridColumn12.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn12.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn12.Header.VisiblePosition = 7;
    ultraGridColumn12.Hidden = true;
    ultraGridColumn12.Width = 100;
    ultraGridColumn13.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn13.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn13.Header.VisiblePosition = 8;
    ultraGridColumn13.Width = 85;
    ultraGridColumn14.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn14.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn14.Header.VisiblePosition = 9;
    ultraGridColumn14.Hidden = true;
    ultraGridColumn14.Width = 84;
    ultraGridColumn15.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn15.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn15.Header.VisiblePosition = 10;
    ultraGridBand2.Columns.AddRange(new object[11]
    {
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
      (object) ultraGridColumn15
    });
    ultraGridColumn16.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn16.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn16.Header.VisiblePosition = 0;
    ultraGridColumn16.Hidden = true;
    ultraGridColumn17.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn17.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance11).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn17.Header).Appearance = (AppearanceBase) appearance11;
    ((HeaderBase) ultraGridColumn17.Header).Caption = "Type";
    ((HeaderBase) ultraGridColumn17.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn17.Header.VisiblePosition = 1;
    ultraGridColumn17.Width = 202;
    ultraGridColumn18.AutoCompleteMode = (AutoCompleteMode) 2;
    appearance12.BackColor = Color.LightYellow;
    ((AppearanceBase) appearance12).TextHAlignAsString = "Right";
    ultraGridColumn18.CellAppearance = (AppearanceBase) appearance12;
    ultraGridColumn18.Format = "c";
    ((AppearanceBase) appearance13).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn18.Header).Appearance = (AppearanceBase) appearance13;
    ((HeaderBase) ultraGridColumn18.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn18.Header.VisiblePosition = 2;
    ultraGridColumn18.Width = 88;
    ultraGridColumn19.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn19.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance14).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn19.Header).Appearance = (AppearanceBase) appearance14;
    ((HeaderBase) ultraGridColumn19.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn19.Header.VisiblePosition = 3;
    ultraGridColumn19.Width = 253;
    ultraGridColumn20.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn20.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn20.Header.VisiblePosition = 4;
    ultraGridColumn20.Hidden = true;
    ultraGridColumn20.Width = 70;
    ultraGridColumn21.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn21.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn21.Header.VisiblePosition = 5;
    ultraGridColumn21.Hidden = true;
    ultraGridBand3.Columns.AddRange(new object[6]
    {
      (object) ultraGridColumn16,
      (object) ultraGridColumn17,
      (object) ultraGridColumn18,
      (object) ultraGridColumn19,
      (object) ultraGridColumn20,
      (object) ultraGridColumn21
    });
    ((UltraGridBase) this.dgInstallments).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.dgInstallments).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.dgInstallments).DisplayLayout.BandsSerializer.Add((object) ultraGridBand3);
    ((UltraGridBase) this.dgInstallments).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance15.BackColor = Color.LightSteelBlue;
    appearance15.FontData.SizeInPoints = 10f;
    appearance15.ForeColor = Color.Black;
    ((UltraGridBase) this.dgInstallments).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance15;
    ((UltraGridBase) this.dgInstallments).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.dgInstallments).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    appearance16.BorderColor = Color.LightGray;
    ((UltraGridBase) this.dgInstallments).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance16;
    appearance17.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.dgInstallments).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance17;
    ((UltraGridBase) this.dgInstallments).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance18.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.dgInstallments).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance18;
    appearance19.BorderColor = Color.LightGray;
    ((UltraGridBase) this.dgInstallments).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance19;
    ((UltraGridBase) this.dgInstallments).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance20.BackColor = Color.Transparent;
    appearance20.ForeColor = Color.Black;
    ((UltraGridBase) this.dgInstallments).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance20;
    scrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.dgInstallments).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.dgInstallments).Location = new Point(7, 70);
    ((Control) this.dgInstallments).Name = "dgInstallments";
    ((Control) this.dgInstallments).Size = new Size(602, 323);
    ((Control) this.dgInstallments).TabIndex = 0;
    ((UltraControlBase) this.dgInstallments).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dgInstallments).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance21).TextHAlignAsString = "Right";
    ((AppearanceBase) appearance21).TextVAlignAsString = "Middle";
    ((ControlBase) this.Label1).Appearance = (AppearanceBase) appearance21;
    ((Control) this.Label1).Location = new Point(4, 12);
    ((Control) this.Label1).Name = "Label1";
    ((Control) this.Label1).Size = new Size(100, 23);
    ((Control) this.Label1).TabIndex = 3;
    ((ControlBase) this.Label1).Text = "Policy Premium:";
    ((AppearanceBase) appearance22).TextHAlignAsString = "Right";
    ((AppearanceBase) appearance22).TextVAlignAsString = "Middle";
    ((ControlBase) this.Label2).Appearance = (AppearanceBase) appearance22;
    ((Control) this.Label2).Location = new Point(4, 40);
    ((Control) this.Label2).Name = "Label2";
    ((Control) this.Label2).Size = new Size(100, 23);
    ((Control) this.Label2).TabIndex = 4;
    ((ControlBase) this.Label2).Text = "Total Fees:";
    appearance23.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance23).TextHAlignAsString = "Right";
    ((AppearanceBase) appearance23).TextVAlignAsString = "Middle";
    ((ControlBase) this.lblPremium).Appearance = (AppearanceBase) appearance23;
    this.lblPremium.BorderStyleOuter = (UIElementBorderStyle) 4;
    ((Control) this.lblPremium).Location = new Point(116, 12);
    ((Control) this.lblPremium).Name = "lblPremium";
    ((Control) this.lblPremium).Size = new Size(100, 23);
    ((Control) this.lblPremium).TabIndex = 5;
    appearance24.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance24).TextHAlignAsString = "Right";
    ((AppearanceBase) appearance24).TextVAlignAsString = "Middle";
    ((ControlBase) this.lblTotalFees).Appearance = (AppearanceBase) appearance24;
    this.lblTotalFees.BorderStyleOuter = (UIElementBorderStyle) 4;
    ((Control) this.lblTotalFees).Location = new Point(116, 40);
    ((Control) this.lblTotalFees).Name = "lblTotalFees";
    ((Control) this.lblTotalFees).Size = new Size(100, 23);
    ((Control) this.lblTotalFees).TabIndex = 6;
    appearance25.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance25).TextHAlignAsString = "Right";
    ((AppearanceBase) appearance25).TextVAlignAsString = "Middle";
    ((ControlBase) this.lblAllocated).Appearance = (AppearanceBase) appearance25;
    this.lblAllocated.BorderStyleOuter = (UIElementBorderStyle) 4;
    ((Control) this.lblAllocated).Location = new Point(330, 12);
    ((Control) this.lblAllocated).Name = "lblAllocated";
    ((Control) this.lblAllocated).Size = new Size(100, 23);
    ((Control) this.lblAllocated).TabIndex = 8;
    ((AppearanceBase) appearance26).TextHAlignAsString = "Right";
    ((AppearanceBase) appearance26).TextVAlignAsString = "Middle";
    ((ControlBase) this.Label4).Appearance = (AppearanceBase) appearance26;
    ((Control) this.Label4).Location = new Point(230, 12);
    ((Control) this.Label4).Name = "Label4";
    ((Control) this.Label4).Size = new Size(88, 23);
    ((Control) this.Label4).TabIndex = 7;
    ((ControlBase) this.Label4).Text = "Allocated:";
    appearance27.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance27).TextHAlignAsString = "Right";
    ((AppearanceBase) appearance27).TextVAlignAsString = "Middle";
    ((ControlBase) this.lblRemaining).Appearance = (AppearanceBase) appearance27;
    this.lblRemaining.BorderStyleOuter = (UIElementBorderStyle) 4;
    ((Control) this.lblRemaining).Location = new Point(330, 40);
    ((Control) this.lblRemaining).Name = "lblRemaining";
    ((Control) this.lblRemaining).Size = new Size(100, 23);
    ((Control) this.lblRemaining).TabIndex = 10;
    ((AppearanceBase) appearance28).TextHAlignAsString = "Right";
    ((AppearanceBase) appearance28).TextVAlignAsString = "Middle";
    ((ControlBase) this.Label6).Appearance = (AppearanceBase) appearance28;
    ((Control) this.Label6).Location = new Point(230, 40);
    ((Control) this.Label6).Name = "Label6";
    ((Control) this.Label6).Size = new Size(88, 23);
    ((Control) this.Label6).TabIndex = 9;
    ((ControlBase) this.Label6).Text = "Remaining:";
    this.daInstallmentBilling.SelectCommand = this.DbSelectCommand1;
    this.daInstallmentBilling.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblInstallmentBilling", new DataColumnMapping[6]
      {
        new DataColumnMapping("NumPayments", "NumPayments"),
        new DataColumnMapping("OfficeID", "OfficeID"),
        new DataColumnMapping("Downpayment", "Downpayment"),
        new DataColumnMapping("DownpaymentBillingTypeID", "DownpaymentBillingTypeID"),
        new DataColumnMapping("SingleInvoice", "SingleInvoice"),
        new DataColumnMapping("QuoteOptionID", "QuoteOptionID")
      })
    });
    this.DbSelectCommand1.CommandText = "SELECT NumPayments, OfficeID, Downpayment, DownpaymentBillingTypeID, SingleInvoice, QuoteOptionID FROM tblInstallmentBilling WHERE (QuoteOptionID = @quoteOptionID)";
    this.DbSelectCommand1.Parameters.AddRange((Array) new DbParameter[1]
    {
      DefaultDatabase.CreateParameter("@quoteOptionID", SqlDbType.Int, 4, "QuoteOptionID")
    });
    appearance29.BackColor = Color.FromArgb(246, 250, 253);
    appearance29.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.panelPleaseWait.ContentAreaAppearance = (AppearanceBase) appearance29;
    ((Control) this.panelPleaseWait).Controls.Add((Control) this.BouncingProgress1);
    ((Control) this.panelPleaseWait).Controls.Add((Control) this.Label3);
    ((Control) this.panelPleaseWait).Location = new Point(132, 188);
    ((Control) this.panelPleaseWait).Name = "panelPleaseWait";
    ((Control) this.panelPleaseWait).Size = new Size(350, 66);
    ((Control) this.panelPleaseWait).TabIndex = 12;
    ((Control) this.BouncingProgress1).BackColor = Color.White;
    this.BouncingProgress1.Border = BorderStyle.FixedSingle;
    this.BouncingProgress1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.BouncingProgress1.Bounce = false;
    this.BouncingProgress1.BounceColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((Control) this.BouncingProgress1).Location = new Point(14, 49);
    ((Control) this.BouncingProgress1).Name = "BouncingProgress1";
    ((Control) this.BouncingProgress1).Size = new Size(322, 7);
    ((Control) this.BouncingProgress1).TabIndex = 1;
    ((AutoSizeControlBase) this.Label3).AutoSize = true;
    ((ControlBase) this.Label3).BackColorInternal = Color.Transparent;
    ((Control) this.Label3).Font = new Font("Tahoma", 12f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.Label3).Location = new Point(84, 14);
    ((Control) this.Label3).Name = "Label3";
    ((Control) this.Label3).Size = new Size(182, 22);
    ((Control) this.Label3).TabIndex = 0;
    ((ControlBase) this.Label3).Text = "Loading... Please Wait...";
    ((Control) this.btnPaymentOptions).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    appearance30.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance30.Image"));
    ((ControlBase) this.btnPaymentOptions).Appearance = (AppearanceBase) appearance30;
    ((Control) this.btnPaymentOptions).Location = new Point(24, 407);
    ((Control) this.btnPaymentOptions).Name = "btnPaymentOptions";
    ((ControlBase) this.btnPaymentOptions).Padding = new Size(5, 0);
    ((Control) this.btnPaymentOptions).Size = new Size(154, 28);
    ((Control) this.btnPaymentOptions).TabIndex = 13;
    ((ControlBase) this.btnPaymentOptions).Text = "Payment Options";
    this.btnPaymentOptions.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.btnSplit).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    appearance31.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance31.Image"));
    ((ControlBase) this.btnSplit).Appearance = (AppearanceBase) appearance31;
    ((Control) this.btnSplit).Location = new Point(185, 407);
    ((Control) this.btnSplit).Name = "btnSplit";
    ((ControlBase) this.btnSplit).Padding = new Size(5, 0);
    ((Control) this.btnSplit).Size = new Size(245, 28);
    ((Control) this.btnSplit).TabIndex = 14;
    ((ControlBase) this.btnSplit).Text = "Split Across x Unissued Invoices";
    this.btnSplit.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.btnSplit).Visible = false;
    ((Control) this.btnBind).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance32.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance32.Image"));
    ((ControlBase) this.btnBind).Appearance = (AppearanceBase) appearance32;
    ((Control) this.btnBind).Enabled = false;
    ((Control) this.btnBind).Location = new Point(437, 407);
    ((Control) this.btnBind).Name = "btnBind";
    ((ControlBase) this.btnBind).Padding = new Size(5, 0);
    ((Control) this.btnBind).Size = new Size(155, 28);
    ((Control) this.btnBind).TabIndex = 15;
    ((ControlBase) this.btnBind).Text = "Continue";
    this.btnBind.UseOSThemes = (DefaultableBoolean) 2;
    this.lblCurrentTime.AutoSize = true;
    this.lblCurrentTime.Location = new Point(6, 17);
    this.lblCurrentTime.Name = "lblCurrentTime";
    this.lblCurrentTime.Size = new Size(46, 13);
    this.lblCurrentTime.TabIndex = 16 /*0x10*/;
    this.lblCurrentTime.Text = "System:";
    this.lblServerTime.AutoSize = true;
    this.lblServerTime.Location = new Point(6, 39);
    this.lblServerTime.Name = "lblServerTime";
    this.lblServerTime.Size = new Size(43, 13);
    this.lblServerTime.TabIndex = 17;
    this.lblServerTime.Text = "Server:";
    this.GroupBox1.Controls.Add((Control) this.lblCurrentTime);
    this.GroupBox1.Controls.Add((Control) this.lblServerTime);
    this.GroupBox1.Location = new Point(437, 5);
    this.GroupBox1.Name = "GroupBox1";
    this.GroupBox1.Size = new Size(170, 59);
    this.GroupBox1.TabIndex = 18;
    this.GroupBox1.TabStop = false;
    this.GroupBox1.Text = "Current Date/Time";
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.ClientSize = new Size(615, 442);
    this.Controls.Add((Control) this.GroupBox1);
    this.Controls.Add((Control) this.btnBind);
    this.Controls.Add((Control) this.btnSplit);
    this.Controls.Add((Control) this.btnPaymentOptions);
    this.Controls.Add((Control) this.panelPleaseWait);
    this.Controls.Add((Control) this.lblRemaining);
    this.Controls.Add((Control) this.Label6);
    this.Controls.Add((Control) this.lblAllocated);
    this.Controls.Add((Control) this.Label4);
    this.Controls.Add((Control) this.lblTotalFees);
    this.Controls.Add((Control) this.lblPremium);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.dgInstallments);
    this.DoubleBuffered = true;
    this.Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ForeColor = Color.Black;
    this.KeyPreview = true;
    this.Name = nameof (frmInstallmentBilling);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Installment Billing";
    this.ds.EndInit();
    ((ISupportInitialize) this.dgInstallments).EndInit();
    ((ISupportInitialize) this.panelPleaseWait).EndInit();
    ((Control) this.panelPleaseWait).ResumeLayout(false);
    ((Control) this.panelPleaseWait).PerformLayout();
    ((ISupportInitialize) this.btnPaymentOptions).EndInit();
    ((ISupportInitialize) this.btnSplit).EndInit();
    ((ISupportInitialize) this.btnBind).EndInit();
    this.GroupBox1.ResumeLayout(false);
    this.GroupBox1.PerformLayout();
    this.ResumeLayout(false);
  }

  [field: AccessedThroughProperty("lblCurrentTime")]
  internal virtual Label lblCurrentTime { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblServerTime")]
  internal virtual Label lblServerTime { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("GroupBox1")]
  internal virtual GroupBox GroupBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public frmInstallmentBilling()
  {
    this.Load += new EventHandler(this.frmInstallmentBilling_Load);
    this._totalPremium = new Dictionary<int, Decimal>();
    this._totalFees = new Dictionary<int, Decimal>();
    this._billingTypes = new Dictionary<int, string>();
    this._selectedInvoices = new List<InstallmentInvoiceItem>();
    this._paymentTerms = -1;
    this._gridLayout = new MemoryStream();
    this._officeDownPayment = new Dictionary<int, bool>();
    this._officeInvCount = new Dictionary<int, int>();
    this._premiumDisplay = "0";
    this._dateDue = new Dictionary<int, DateTime>();
    this._dateBilling = new Dictionary<int, DateTime>();
    this._effectiveAltFirstInstallDays = int.MinValue;
    this._effDateBilledAltFirstInstallDays = int.MinValue;
    this._makeFirstPaymentEqualsDownpaymentIfLess = false;
    this._useMonth = false;
    this._dayOfMonthAltFirstInstallDays = int.MinValue;
    this._deferDateBilledToCloseDate = false;
    this._closedDate = new DateTime(1900, 1, 1);
    this._billingDateDaysFromDueDate = int.MinValue;
    this._singlePay = false;
    this._incorporateClosedDateTime = false;
    this._alreadyEvaluateGaap = false;
    this._isEndorsement = false;
    this._glCompanyID = int.MinValue;
    this._monthFollowingDownPayment_Exp = false;
    this._usingPolicyExpiration = false;
    this._revertToExpirationDateDay = false;
    this._expirationAltFirstInstallDays = int.MinValue;
    this._ignoreDueDateIncrementOnZeroPaymentTerm = false;
    this._implementDayOfMonthOnMonthFollowingDownPayment = false;
    this._setDueDateEqualsBillDate = false;
    this._allowDateDueLessThanDateBilled = false;
    this._includeEndorsementsForGAAP = false;
    this._implementEffectiveGAAP = false;
    this._effDateBilledAltFinalInstallDays = int.MinValue;
    this._effectiveAltFinalInstallDays = int.MinValue;
    this._expirationAltFinalInstallDays = int.MinValue;
    this._dayOfMonthAltFinalInstallDays = int.MinValue;
    this.HasAlreadyProcessTerms = false;
    this.HasDownPaymentInstallment = false;
    this.TransactionDataRow = (DataRow) null;
    this.UseMonthIncrement = false;
    this.HasTransactionSetup = false;
    this.InitializeComponent();
  }

  public frmInstallmentBilling(int quoteOptionID)
  {
    this.Load += new EventHandler(this.frmInstallmentBilling_Load);
    this._totalPremium = new Dictionary<int, Decimal>();
    this._totalFees = new Dictionary<int, Decimal>();
    this._billingTypes = new Dictionary<int, string>();
    this._selectedInvoices = new List<InstallmentInvoiceItem>();
    this._paymentTerms = -1;
    this._gridLayout = new MemoryStream();
    this._officeDownPayment = new Dictionary<int, bool>();
    this._officeInvCount = new Dictionary<int, int>();
    this._premiumDisplay = "0";
    this._dateDue = new Dictionary<int, DateTime>();
    this._dateBilling = new Dictionary<int, DateTime>();
    this._effectiveAltFirstInstallDays = int.MinValue;
    this._effDateBilledAltFirstInstallDays = int.MinValue;
    this._makeFirstPaymentEqualsDownpaymentIfLess = false;
    this._useMonth = false;
    this._dayOfMonthAltFirstInstallDays = int.MinValue;
    this._deferDateBilledToCloseDate = false;
    this._closedDate = new DateTime(1900, 1, 1);
    this._billingDateDaysFromDueDate = int.MinValue;
    this._singlePay = false;
    this._incorporateClosedDateTime = false;
    this._alreadyEvaluateGaap = false;
    this._isEndorsement = false;
    this._glCompanyID = int.MinValue;
    this._monthFollowingDownPayment_Exp = false;
    this._usingPolicyExpiration = false;
    this._revertToExpirationDateDay = false;
    this._expirationAltFirstInstallDays = int.MinValue;
    this._ignoreDueDateIncrementOnZeroPaymentTerm = false;
    this._implementDayOfMonthOnMonthFollowingDownPayment = false;
    this._setDueDateEqualsBillDate = false;
    this._allowDateDueLessThanDateBilled = false;
    this._includeEndorsementsForGAAP = false;
    this._implementEffectiveGAAP = false;
    this._effDateBilledAltFinalInstallDays = int.MinValue;
    this._effectiveAltFinalInstallDays = int.MinValue;
    this._expirationAltFinalInstallDays = int.MinValue;
    this._dayOfMonthAltFinalInstallDays = int.MinValue;
    this.HasAlreadyProcessTerms = false;
    this.HasDownPaymentInstallment = false;
    this.TransactionDataRow = (DataRow) null;
    this.UseMonthIncrement = false;
    this.HasTransactionSetup = false;
    this.InitializeComponent();
    this._quoteOptionID = quoteOptionID;
    this._cultureInfo = MultiCurrencyUtilities.GetCultureInfo(DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "Select dbo.GetQuoteCurrencyCode(@quoteId)", new object[2]
    {
      (object) "@quoteId",
      (object) new QuoteOption(quoteOptionID).Quote.QuoteID
    }));
  }

  public virtual bool RoundPremiums(int quoteOptionID)
  {
    bool flag;
    if (SystemSettings.KeyExists("AllowPennyInstallments") && SystemSettings.GetBoolSetting("AllowPennyInstallments"))
    {
      flag = false;
    }
    else
    {
      Decimal premiumWithCents = new QuoteOption(quoteOptionID).PremiumWithCents;
      flag = Decimal.Compare(premiumWithCents, new Decimal(Convert.ToInt32(premiumWithCents))) == 0;
    }
    return flag;
  }

  public bool BlackBoxMode
  {
    get => this._blackBoxMode;
    set => this._blackBoxMode = value;
  }

  protected int PaymentTerms => this._paymentTerms;

  private QuoteOption QuoteOption
  {
    get
    {
      if (this._quoteOption == null)
        this._quoteOption = new QuoteOption(this._quoteOptionID);
      return this._quoteOption;
    }
  }

  protected Quote Quote => this._quote;

  protected Decimal FeeSum
  {
    get => this._feesSum;
    set => this._feesSum = value;
  }

  protected Dictionary<int, Decimal> TotalFees => this._totalFees;

  private Decimal FeesAllocated
  {
    get
    {
      object objectValue = RuntimeHelpers.GetObjectValue(this.ds.InvoiceItems.Compute("SUM(Amount)", "OptionFeeID IS NOT NULL"));
      return Utility.IsNull(RuntimeHelpers.GetObjectValue(objectValue)) ? 0M : Conversions.ToDecimal(objectValue);
    }
  }

  protected Dictionary<int, Decimal> TotalPremiums => this._totalPremium;

  protected Decimal PremiumAllocated
  {
    get
    {
      object objectValue = RuntimeHelpers.GetObjectValue(this.ds.InvoiceItems.Compute("SUM(Amount)", "OptionFeeID IS NULL"));
      return Utility.IsNull(RuntimeHelpers.GetObjectValue(objectValue)) ? 0M : Conversions.ToDecimal(objectValue);
    }
  }

  protected Decimal Allocated
  {
    get
    {
      object objectValue = RuntimeHelpers.GetObjectValue(this.ds.InvoiceItems.Compute("SUM(Amount)", string.Empty));
      return Utility.IsNull(RuntimeHelpers.GetObjectValue(objectValue)) ? 0M : Conversions.ToDecimal(objectValue);
    }
  }

  protected dsInstallmentBilling Dataset => this.ds;

  protected Dictionary<int, bool> OfficeDownPayment => this._officeDownPayment;

  protected Dictionary<int, int> OfficeInvoiceCount => this._officeInvCount;

  protected bool AlreadyEvaluateGaap
  {
    get => this._alreadyEvaluateGaap;
    set => this._alreadyEvaluateGaap = value;
  }

  protected List<InstallmentInvoiceItem> SelectedInvoices => this._selectedInvoices;

  private void frmInstallmentBilling_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    this.lblServerTime.Text = $"{this.lblServerTime.Text}{Strings.Format((object) CurrentUser.Instance.GetServerTime(), "yyyy-MM-dd hh:mm:ss")}";
    this.lblCurrentTime.Text = $"{this.lblCurrentTime.Text}{Strings.Format((object) DateAndTime.Now, "yyyy-MM-dd hh:mm:ss")}";
    this._quote = Quote.FromQuoteOptionID(this._quoteOptionID);
    this._roundPremiums = this.RoundPremiums(this._quoteOptionID);
    this._isEndorsement = this._quote.IsEndorsement;
    this._glCompanyID = this._quote.QuotingLocation.OfficeID;
    this._tmpPolicyExpirationDate = this._quote.ExpirationDate.Date;
    this._allowDateDueLessThanDateBilled = DefaultDatabase.ExecuteScalar<bool>("spAllowDateDueLessThanDateBilled", new object[2]
    {
      (object) "@QuoteGuid",
      (object) this._quote.QuoteGuid
    });
    this.BouncingProgress1.Bounce = true;
    ((Control) this.btnBind).Enabled = false;
    ((UltraGridBase) this.dgInstallments).DisplayLayout.Save((Stream) this._gridLayout);
    ((UltraGridBase) this.dgInstallments).DataSource = (object) null;
    this.SetupSecurityLevel();
    if (this._deferDateBilledToCloseDate)
      this._closedDate = DefaultDatabase.ExecuteScalar<DateTime>("dbo.spCompanyClosedDate", new object[2]
      {
        (object) "@QuoteGuid",
        (object) this._quote.QuoteGuid
      });
    ThreadPool.QueueUserWorkItem(new WaitCallback(this.ThreadedFill));
  }

  private void SetupSecurityLevel()
  {
    this._noProducerLineSetupForProducerLocation = SystemSettings.GetSetting<bool>("CheckForProducerLineSetupForProducerLocation", false);
    this._revertToEffectiveDateDay = SystemSettings.GetSetting<bool>("RevertToEffectiveDateDay", false);
    this._setWeekendInvoiceDueDatesToMonday = SystemSettings.GetSetting<bool>("SetWeekendInvoiceDueDatesToMonday", false);
    this._makeFirstPaymentEqualsDownpaymentIfLess = SystemSettings.GetSetting<bool>("MakeFirstPaymentEqualsDownpaymentIfLess", false);
    this._deferDateBilledToCloseDate = SystemSettings.GetSetting<bool>("DeferDateBilledToCloseDate", false);
    this._incorporateClosedDateTime = SystemSettings.GetSetting<bool>("IncorporateClosedDateTime", false);
    this._revertToExpirationDateDay = SystemSettings.GetSetting<bool>("RevertToExpirationDateDay", false);
    this._ignoreDueDateIncrementOnZeroPaymentTerm = SystemSettings.GetSetting<bool>("IgnoreDueDateIncrementOnZeroPaymentTerm", false);
    this._implementDayOfMonthOnMonthFollowingDownPayment = SystemSettings.GetSetting<bool>("ImplementDayOfMonthOnMonthFollowingDownPayment", false);
    this._setDueDateEqualsBillDate = SystemSettings.GetSetting<bool>("InstallmentBilling.SetDueDateEqualsBillDate", false);
    this._includeEndorsementsForGAAP = SystemSettings.GetSetting<bool>("InstallmentBilling.IncludeEndorsementsForGAAP", false);
    this._implementEffectiveGAAP = SystemSettings.GetSetting<bool>("InstallmentBilling.ImplementEffectiveGAAP", false);
  }

  protected virtual DateTime GetDateBilled(bool isDownpaymentInvoice, DateTime dateDue)
  {
    DateTime dateBilled;
    if (!isDownpaymentInvoice && this._dateBilledEqualToDueDate)
    {
      DateTime dateTime = dateDue;
      if (this._billingDateDaysFromDueDate != int.MinValue)
        dateTime = this._useMonth ? dateDue.AddMonths(this._billingDateDaysFromDueDate * -1) : dateDue.AddDays((double) (this._billingDateDaysFromDueDate * -1));
      if (this._useEffectiveDateForBilling)
      {
        DateTime effectiveDate = this._quote.EffectiveDate;
        if (effectiveDate.Day <= DateTime.DaysInMonth(dateTime.Year, dateTime.Month))
        {
          ref DateTime local = ref dateTime;
          int year = dateTime.Year;
          int month = dateTime.Month;
          effectiveDate = this._quote.EffectiveDate;
          int day = effectiveDate.Day;
          local = new DateTime(year, month, day);
        }
        else
          dateTime = new DateTime(dateTime.Year, dateTime.Month, DateTime.DaysInMonth(dateTime.Year, dateTime.Month));
      }
      dateBilled = dateTime;
    }
    else
      dateBilled = this.GetDateBilled();
    return dateBilled;
  }

  protected virtual DateTime GetDateBilled()
  {
    DateTime serverTime = CurrentUser.Instance.GetServerTime();
    DateTime dateBilled;
    if (!this._deferDateBilledToCloseDate || DateTime.Compare(this._closedDate, new DateTime(1900, 1, 1)) == 0)
    {
      dateBilled = serverTime;
    }
    else
    {
      TimeSpan timeSpan = this._closedDate - new DateTime(serverTime.Year, serverTime.Month, serverTime.Day);
      dateBilled = timeSpan.Days > 0 || timeSpan.Days == 0 && this._incorporateClosedDateTime ? this._closedDate.AddDays(1.0) : serverTime;
    }
    return dateBilled;
  }

  protected virtual int GetBillingTypeID() => this._quote.BillingTypeID.Value;

  private void DisableSplitButton(object sender, EventArgs e)
  {
    ((Control) this.btnSplit).Enabled = false;
  }

  private void SetupSplitButton(object Sender, TaggedEventArgs e)
  {
    if (this._isEndorsement && this._quote.UnissuedInvoiceCount > 0)
    {
      ((ControlBase) this.btnSplit).Text = $"Split Across {((int) e.Tag).ToString()} Unissued Invoices";
      ((Control) this.btnSplit).Visible = true;
    }
    else
      ((Control) this.btnSplit).Visible = false;
  }

  private void ThrowUIThreadException(object sender, TaggedEventArgs e)
  {
    ExceptionDispatchInfo.Capture((Exception) e.Tag).Throw();
  }

  protected DialogResult ShowMessage(
    string message,
    string caption,
    MessageBoxButtons buttons,
    MessageBoxIcon icon)
  {
    if (this.BlackBoxMode)
      throw new InvalidOperationException(message);
    DialogResult dialogResult;
    if (MDIControls.Instance.MDIParent.InvokeRequired)
      MDIControls.Instance.MDIParent.Invoke((Delegate) new frmInstallmentBilling.ShowMessageHandler(this.ShowMessage), (object) message, (object) caption, (object) buttons, (object) icon);
    else
      dialogResult = MessageBox.Show(message, caption, buttons, icon);
    return dialogResult;
  }

  private void LoadComplete(object sender, EventArgs e)
  {
    try
    {
      if (!this.BlackBoxMode)
      {
        this._gridLayout.Position = 0L;
        this.AssignColor();
        UltraGrid dgInstallments = this.dgInstallments;
        ((Control) dgInstallments).SuspendLayout();
        ((UltraGridBase) dgInstallments).DataSource = (object) this.ds.Offices;
        ((UltraGridBase) dgInstallments).DisplayLayout.Load((Stream) this._gridLayout);
        ((UltraGridBase) dgInstallments).DisplayLayout.ScrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
        ((UltraGridBase) dgInstallments).Rows.ExpandAll(true);
        ((Control) dgInstallments).ResumeLayout();
        if (!SecurityManager.Instance.AssertPermission("{7BF5790B-D172-4258-B05F-437AACC299C2}"))
          ((UltraGridBase) this.dgInstallments).DisplayLayout.Bands[1].Columns["DateBilled"].CellActivation = (Activation) 3;
        if (frmPolicyDetail.CurrentMultiCurrency && frmPolicyDetail.ImplementCurrencyDisplay)
        {
          ((UltraGridBase) this.dgInstallments).DisplayLayout.Bands[0].Columns["TotalPremium"].FormatInfo = (IFormatProvider) this._cultureInfo;
          ((UltraGridBase) this.dgInstallments).DisplayLayout.Bands[2].Columns["Amount"].FormatInfo = (IFormatProvider) this._cultureInfo;
          this._premiumDisplay = this._premiumSum.ToString("c", (IFormatProvider) this._cultureInfo);
          ((ControlBase) this.lblTotalFees).Text = this._feesSum.ToString("c", (IFormatProvider) this._cultureInfo);
          ((ControlBase) this.lblAllocated).Text = this.Allocated.ToString("c", (IFormatProvider) this._cultureInfo);
          ((ControlBase) this.lblRemaining).Text = Decimal.Subtract(Decimal.Add(this._premiumSum, this._feesSum), this.Allocated).ToString("c", (IFormatProvider) this._cultureInfo);
        }
        else
        {
          this._premiumDisplay = this._premiumSum.ToString("c");
          ((ControlBase) this.lblTotalFees).Text = this._feesSum.ToString("c");
          ((ControlBase) this.lblAllocated).Text = Strings.FormatCurrency((object) this.Allocated);
          ((ControlBase) this.lblRemaining).Text = Strings.FormatCurrency((object) Decimal.Subtract(Decimal.Add(this._premiumSum, this._feesSum), this.Allocated));
        }
        ((ControlBase) this.lblPremium).Text = this._premiumDisplay;
        ((Control) this.panelPleaseWait).Visible = false;
        this.BouncingProgress1.Bounce = false;
        if (this.ds.tblQuoteAdditionalInterests.Count == 0)
          ((UltraGridBase) this.dgInstallments).DisplayLayout.Bands[1].Columns["BillTo"].Hidden = true;
        DataTable dataTable = DefaultDatabase.ExecuteDataTable("GetFeeRestrictionsPerUser", new object[6]
        {
          (object) "@WholePolicy",
          (object) false,
          (object) "@QuoteGuid",
          (object) this._quote.QuoteGuid,
          (object) "@UserGuid",
          (object) CurrentUser.Instance.UserGUID
        });
        if (dataTable.Rows.Count > 0)
        {
          try
          {
            foreach (UltraGridRow ultraGridRow in ((UltraGridBase) this.dgInstallments).Rows.GetRowEnumerator((GridRowType) 1, ((UltraGridBase) this.dgInstallments).DisplayLayout.Bands[2], (UltraGridBand) null))
            {
              if (ultraGridRow.Band.Index == 2 && ultraGridRow.Cells["OptionFeeID"].Value != DBNull.Value && ultraGridRow.Cells["OptionFeeID"].Value != null)
              {
                int num = DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "SELECT ChargeCode FROM tblQuoteOptionCharges WITH (NOLOCK) WHERE OptionFeeID=@ID", new object[2]
                {
                  (object) "@ID",
                  ultraGridRow.Cells["OptionFeeID"].Value
                });
                if (dataTable.Select("ChargeCode=" + num.ToString()).Length > 0)
                  ultraGridRow.Hidden = true;
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
      this.GetDueDates();
      this.GetBillingDates();
      if (!SecurityManager.Instance.AssertPermission("0F2FF00F-BA1C-491b-BF18-DC745A92C520"))
        ((UltraGridBase) this.dgInstallments).DisplayLayout.Bands[1].Columns["DateDue"].CellActivation = (Activation) 3;
      ((Control) this.btnBind).Enabled = true;
    }
    catch (ObjectDisposedException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ProjectData.ClearProjectError();
    }
    catch (InvalidOperationException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ProjectData.ClearProjectError();
    }
    this.AfterLoadComplete();
  }

  protected virtual void AfterLoadComplete()
  {
  }

  private void GetDueDates()
  {
    try
    {
      foreach (dsInstallmentBilling.InvoicesRow row in this.ds.Invoices.Rows)
      {
        if (!row.IsDateDueNull())
          this._dateDue.Add(row.InvoiceNum, row.DateDue);
        else
          this._dateDue.Add(row.InvoiceNum, DateTime.MinValue);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void GetBillingDates()
  {
    try
    {
      foreach (dsInstallmentBilling.InvoicesRow row in this.ds.Invoices.Rows)
        this._dateBilling.Add(row.InvoiceNum, row.DateBilled);
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void AssignColor()
  {
    if (Decimal.Compare(this._premiumSum, 0M) < 0)
      ((ControlBase) this.lblPremium).Appearance.ForeColor = Color.Red;
    else
      ((ControlBase) this.lblPremium).Appearance.ForeColor = Color.Black;
    if (Decimal.Compare(this._feesSum, 0M) < 0)
      ((ControlBase) this.lblTotalFees).Appearance.ForeColor = Color.Red;
    else
      ((ControlBase) this.lblTotalFees).Appearance.ForeColor = Color.Black;
    if (Decimal.Compare(this.Allocated, 0M) < 0)
      ((ControlBase) this.lblAllocated).Appearance.ForeColor = Color.Red;
    else
      ((ControlBase) this.lblAllocated).Appearance.ForeColor = Color.Black;
    if (Decimal.Compare(Decimal.Subtract(Decimal.Add(this._premiumSum, this._feesSum), this.Allocated), 0M) < 0)
      ((ControlBase) this.lblRemaining).Appearance.ForeColor = Color.Red;
    else
      ((ControlBase) this.lblRemaining).Appearance.ForeColor = Color.Black;
  }

  internal void ConfigureInstallments()
  {
    if (!this.BlackBoxMode)
      throw new InvalidOperationException("ConfigureInstallments should only be called when in black box mode (BlackBox = True)");
    if (this._quote == null)
      this._quote = Quote.FromQuoteOptionID(this._quoteOptionID);
    new QuoteOption(this._quoteOptionID).SetupDefaultInstallmentBilling();
    this._roundPremiums = this.RoundPremiums(this._quoteOptionID);
    this._selectedInvoices = this.ClientSplitInvoices();
    this._splitAcross = this._selectedInvoices != null && this._selectedInvoices.Count > 0;
    this.ThreadedFill((object) null);
    if (!this._splitAcross)
      return;
    try
    {
      foreach (dsInstallmentBilling.InvoicesRow invoice in (TypedTableBase<dsInstallmentBilling.InvoicesRow>) this.ds.Invoices)
        this.PrepareSplitInvoice(invoice, this._officeDownPayment[invoice.OfficeID]);
    }
    finally
    {
      IEnumerator<dsInstallmentBilling.InvoicesRow> enumerator;
      enumerator?.Dispose();
    }
  }

  private void ThreadedFill(object state)
  {
    try
    {
      if (!this.BlackBoxMode)
        this.Invoke((Delegate) new frmInstallmentBilling.SetupSplitButtonHandler(this.SetupSplitButton), (object) this, (object) new TaggedEventArgs((object) this._quote.UnissuedInvoiceCount));
      Utility.SetDataAdapterConnections(this.daInstallmentBilling, DefaultDatabase.CreateDbConnection(), (DbTransaction) null);
      this.daInstallmentBilling.SelectCommand.Parameters["@quoteOptionID"].Value = (object) this._quoteOptionID;
      DefaultDatabase.DataAdapterFill(this.daInstallmentBilling, (DataTable) this.ds.tblInstallmentBilling);
      if (this.ds.tblInstallmentBilling.Rows.Count == 0)
      {
        try
        {
          if (this.BlackBoxMode)
            throw new InvalidOperationException("Installment billing information not found for quote ID " + this._quote.QuoteID.ToString());
          this.Invoke((Delegate) new frmInstallmentBilling.ThrowUIThreadExceptionHandler(this.ThrowUIThreadException), (object) this, (object) new TaggedEventArgs((object) new InvalidOperationException("Installment billing information not found for quote ID " + this._quote.QuoteID.ToString())));
        }
        catch (InvalidOperationException ex) when (
        {
          // ISSUE: unable to correctly present filter
          ProjectData.SetProjectError((Exception) ex);
          if (!this.BlackBoxMode)
          {
            SuccessfulFiltering;
          }
          else
            throw;
        }
        )
        {
          ProjectData.ClearProjectError();
        }
      }
      DefaultDatabase.LoadDataTable((DataTable) this.ds.tblQuoteAdditionalInterests, CommandType.Text, "SELECT ID, InterestName, BillableAmount FROM tblQuoteAdditionalInterests WHERE QuoteID = @QID AND BillableAmount IS NOT NULL", new object[2]
      {
        (object) "@QID",
        (object) this._quote.QuoteID
      });
      this.ds.EnforceConstraints = false;
      DefaultDatabase.LoadDataTable((DataTable) this.ds.Offices, CommandType.Text, "SELECT OfficeID, Location FROM tblClientOffices WHERE OfficeID IN (SELECT * FROM dbo.GetPolicyOfficeIDs(@QG,1,0))", new object[2]
      {
        (object) "@QG",
        (object) this._quote.QuoteGuid
      });
      if (this.ds.Offices.Rows.Count > 1)
      {
        if (!this.BlackBoxMode)
        {
          try
          {
            this.Invoke((Delegate) new frmInstallmentBilling.DisableSplitButtonHandler(this.DisableSplitButton), (object) this, (object) EventArgs.Empty);
          }
          catch (InvalidOperationException ex)
          {
            ProjectData.SetProjectError((Exception) ex);
            ProjectData.ClearProjectError();
          }
        }
      }
      try
      {
        foreach (dsInstallmentBilling.OfficesRow office in (TypedTableBase<dsInstallmentBilling.OfficesRow>) this.ds.Offices)
        {
          Decimal num = DefaultDatabase.ExecuteScalar<Decimal>(CommandType.Text, "SELECT ISNULL(SUM(P.Premium),0) FROM tblQuoteOptionPremiums P INNER JOIN tblQuoteOptions O ON P.QuoteOptionGuid=O.QuoteOptionGuid WHERE O.QuoteGuid = @QG AND O.Bound=1 AND P.OfficeID=@OID", new object[4]
          {
            (object) "@QG",
            (object) this._quote.QuoteGuid,
            (object) "@OID",
            (object) office.OfficeID
          });
          this._totalPremium[office.OfficeID] = num;
          office.TotalPremium = num;
          this._officeInvCount[office.OfficeID] = 0;
          this._totalFees[office.OfficeID] = 0M;
        }
      }
      finally
      {
        IEnumerator<dsInstallmentBilling.OfficesRow> enumerator;
        enumerator?.Dispose();
      }
      this._premiumSum = Utility.IsNull<Decimal>(RuntimeHelpers.GetObjectValue(this.ds.Offices.Compute("SUM(TotalPremium)", string.Empty)), 0M);
      this.ds.EnforceConstraints = true;
      this.SetInstallmentTerm();
      this.ClientSetupInstallmentBilling();
      this.PopulateScreen();
      if (!this.BlackBoxMode && this.IsHandleCreated && !this.IsDisposed)
      {
        if (!this.Disposing)
        {
          try
          {
            MDIControls.Instance.MDIParent.Invoke((Delegate) new frmInstallmentBilling.LoadCompleteHandler(this.LoadComplete), (object) this, (object) EventArgs.Empty);
            return;
          }
          catch (InvalidOperationException ex)
          {
            ProjectData.SetProjectError((Exception) ex);
            ProjectData.ClearProjectError();
            return;
          }
        }
      }
      if (!this.BlackBoxMode)
        return;
      this.LoadComplete((object) this, EventArgs.Empty);
    }
    catch (NullReferenceException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ProjectData.ClearProjectError();
    }
    catch (ObjectDisposedException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ProjectData.ClearProjectError();
    }
    catch (InvalidOperationException ex) when (
    {
      // ISSUE: unable to correctly present filter
      ProjectData.SetProjectError((Exception) ex);
      if (!this.BlackBoxMode)
      {
        SuccessfulFiltering;
      }
      else
        throw;
    }
    )
    {
      ProjectData.ClearProjectError();
    }
  }

  private void SetInstallmentTerm()
  {
    DataRow row = DefaultDatabase.ExecuteDataRow(CommandType.Text, "SELECT CL.EffectiveDateBilled, CL.PolicyEffective, CL.DayOfMonth, CL.DayOfMonthNumber, CL.MonthFollowingDownPayment, CL.MonthFollowingDownPayment_Eff, CL.MonthFollowingDownPayment_Eff_DateBilled, CL.EffectiveAltFirstInstallDays, CL.EffDateBilledAltFirstInstallDays, CL.InstallmentFromDateBilled, CL.InstallmentFromEffectiveDate,CL.UseMonth, CL.DayOfMonthAltFirstInstallDays, CL.DownpaymentFromEffectiveDate, CL.DownpaymentFromDateBilled, CL.BillingDateDaysFromDueDate, CL.UseEffectiveDateForBilling, CL.DateBilledEqualToDueDate, CL.DownPaymentGAAP, CL.UseMonthForAltFirstInstallment, CL.SinglePay, CL.MonthFollowingDownPayment_Exp, PolicyExpiration, CL.ExpirationAltFirstInstallDays, CL.DownPaymentFromEffEndMonth AS DownPaymentFromEffEndMonth,CL.EffDateBilledAltFinalInstallDays, CL.EffectiveAltFinalInstallDays, CL.ExpirationAltFinalInstallDays, CL.DayOfMonthAltFinalInstallDays, CL.UseMonthFinalInstallment, CL.AssignRemainderFinalInstallment FROM dbo.tblCompanyLineInstallments AS CL WITH (NOLOCK) INNER JOIN tblQuoteOptions AS QO WITH (NOLOCK) ON CL.ID = QO.CompanyInstallmentID WHERE  (QO.QuoteOptionID = @QO)", new object[2]
    {
      (object) "@QO",
      (object) this._quoteOptionID
    });
    this._effectiveDateDay = this._quote.EffectiveDate.Day;
    this._expirationDateDay = this._quote.ExpirationDate.Day;
    if (row == null)
      return;
    if (!row.IsNull("EffectiveDateBilled"))
      this._usingEffectiveDateBilled = row.Field<bool>("EffectiveDateBilled");
    if (!row.IsNull("PolicyEffective"))
      this._usingPolicyEffective = row.Field<bool>("PolicyEffective");
    if (!row.IsNull("DayOfMonth"))
      this._usingDayOfMonth = row.Field<bool>("DayOfMonth");
    if (!row.IsNull("DayOfMonthNumber"))
      this._dayOfMonthNumber = (int) row.Field<byte>("DayOfMonthNumber");
    if (!row.IsNull("MonthFollowingDownPayment"))
      this._monthFollowingDownPayment = row.Field<bool>("MonthFollowingDownPayment");
    if (!row.IsNull("MonthFollowingDownPayment_Eff"))
      this._monthFollowingDownPayment_Eff = row.Field<bool>("MonthFollowingDownPayment_Eff");
    if (!row.IsNull("MonthFollowingDownPayment_Eff_DateBilled"))
      this._monthFollowingDownPayment_Eff_DateBilled = row.Field<bool>("MonthFollowingDownPayment_Eff_DateBilled");
    if (!row.IsNull("EffectiveAltFirstInstallDays"))
      this._effectiveAltFirstInstallDays = (int) row.Field<short>("EffectiveAltFirstInstallDays");
    if (!row.IsNull("EffDateBilledAltFirstInstallDays"))
      this._effDateBilledAltFirstInstallDays = (int) row.Field<short>("EffDateBilledAltFirstInstallDays");
    if (!row.IsNull("InstallmentFromDateBilled"))
      this._installmentFromDateBilled = row.Field<bool>("InstallmentFromDateBilled");
    if (!row.IsNull("InstallmentFromEffectiveDate"))
      this._installmentFromEffectiveDate = row.Field<bool>("InstallmentFromEffectiveDate");
    if (!row.IsNull("UseMonth"))
      this._useMonth = row.Field<bool>("UseMonth");
    if (!row.IsNull("DayOfMonthAltFirstInstallDays"))
      this._dayOfMonthAltFirstInstallDays = (int) row.Field<short>("DayOfMonthAltFirstInstallDays");
    if (!row.IsNull("DownpaymentFromEffectiveDate"))
      this._downpaymentFromEffectiveDate = row.Field<bool>("DownpaymentFromEffectiveDate");
    if (!row.IsNull("DownpaymentFromDateBilled"))
      this._downpaymentFromDateBilled = row.Field<bool>("DownpaymentFromDateBilled");
    if (!row.IsNull("BillingDateDaysFromDueDate"))
      this._billingDateDaysFromDueDate = (int) row.Field<short>("BillingDateDaysFromDueDate");
    if (!row.IsNull("UseEffectiveDateForBilling"))
      this._useEffectiveDateForBilling = row.Field<bool>("UseEffectiveDateForBilling");
    if (!row.IsNull("DateBilledEqualToDueDate"))
      this._dateBilledEqualToDueDate = row.Field<bool>("DateBilledEqualToDueDate");
    if (!row.IsNull("DownPaymentGAAP"))
      this._downPaymentGAAP = row.Field<bool>("DownPaymentGAAP");
    if (!row.IsNull("UseMonthForAltFirstInstallment"))
      this._useMonthForAltFirstInstallment = row.Field<bool>("UseMonthForAltFirstInstallment");
    if (!row.IsNull("SinglePay"))
      this._singlePay = row.Field<bool>("SinglePay");
    if (!row.IsNull("MonthFollowingDownPayment_Exp"))
      this._monthFollowingDownPayment_Exp = row.Field<bool>("MonthFollowingDownPayment_Exp");
    if (!row.IsNull("PolicyExpiration"))
      this._usingPolicyExpiration = row.Field<bool>("PolicyExpiration");
    if (!row.IsNull("ExpirationAltFirstInstallDays"))
      this._expirationAltFirstInstallDays = (int) row.Field<short>("ExpirationAltFirstInstallDays");
    if (!row.IsNull("DownPaymentFromEffEndMonth"))
      this._downPaymentFromEffEndMonth = row.Field<bool>("DownPaymentFromEffEndMonth");
    if (!row.IsNull("EffDateBilledAltFinalInstallDays"))
      this._effDateBilledAltFinalInstallDays = (int) row.Field<short>("EffDateBilledAltFinalInstallDays");
    if (!row.IsNull("EffectiveAltFinalInstallDays"))
      this._effectiveAltFinalInstallDays = (int) row.Field<short>("EffectiveAltFinalInstallDays");
    if (!row.IsNull("ExpirationAltFinalInstallDays"))
      this._expirationAltFinalInstallDays = (int) row.Field<short>("ExpirationAltFinalInstallDays");
    if (!row.IsNull("DayOfMonthAltFinalInstallDays"))
      this._dayOfMonthAltFinalInstallDays = (int) row.Field<short>("DayOfMonthAltFinalInstallDays");
    if (!row.IsNull("UseMonthFinalInstallment"))
      this._useMonthFinalInstallment = row.Field<bool>("UseMonthFinalInstallment");
    if (row.IsNull("AssignRemainderFinalInstallment"))
      return;
    this._assignRemainderFinalInstallment = row.Field<bool>("AssignRemainderFinalInstallment");
  }

  protected virtual void ClientSetupInstallmentBilling()
  {
  }

  private void PopulateScreen()
  {
    try
    {
      this.ds.InvoiceItems.Clear();
    }
    catch (ArgumentOutOfRangeException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ProjectData.ClearProjectError();
    }
    try
    {
      this.ds.Invoices.Clear();
    }
    catch (ArgumentOutOfRangeException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ProjectData.ClearProjectError();
    }
    this._officeDownPayment.Clear();
    try
    {
      foreach (dsInstallmentBilling.OfficesRow office in (TypedTableBase<dsInstallmentBilling.OfficesRow>) this.ds.Offices)
      {
        this._officeInvCount[office.OfficeID] = 0;
        this._totalFees[office.OfficeID] = 0M;
      }
    }
    finally
    {
      IEnumerator<dsInstallmentBilling.OfficesRow> enumerator;
      enumerator?.Dispose();
    }
    this.FillInvoices();
    if (!this.SetupDownpaymentInvoices())
      return;
    this.DispersePremiums();
    this.FillFees();
    this.DisperseFees();
    this.AdjustUnevenPennySplits();
    this.SetModFactors();
    this.RemoveZeroInvoices();
    this.SetAdditionalInterestInvoiceAmounts();
  }

  private void InvalidInterestInstallmentSetup()
  {
    int num = (int) this.ShowMessage("The number of billable additional interests does Not match the number of invoices.", "Invalid Invoice Setup", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    this.Close();
  }

  private void SetAdditionalInterestInvoiceAmounts()
  {
    if (this.ds.tblQuoteAdditionalInterests.Count > 0 && this.ds.tblQuoteAdditionalInterests.Count != this.ds.Invoices.Count)
    {
      if (this.BlackBoxMode)
        throw new Exception("The number of billable additional interests does Not match the number of invoices.");
      InvokeExtensions.BetterInvoke((ISynchronizeInvoke) MDIControls.Instance.MDIParent, (Delegate) new MethodInvoker(this.InvalidInterestInstallmentSetup), new object[0]);
    }
    else
    {
      if (this.ds.tblQuoteAdditionalInterests.Count == 0)
        return;
      DataRow[] dataRowArray = this.ds.InvoiceItems.Select("ItemType='Premium'");
      int index1 = 0;
      while (index1 < dataRowArray.Length)
      {
        ((dsInstallmentBilling.InvoiceItemsRow) dataRowArray[index1]).Amount = 0M;
        checked { ++index1; }
      }
      int num = this.ds.tblQuoteAdditionalInterests.Count - 1;
      for (int index2 = 0; index2 <= num; ++index2)
      {
        dsInstallmentBilling.InvoiceItemsRow invoiceItemsRow = (dsInstallmentBilling.InvoiceItemsRow) this.ds.InvoiceItems.Select("ItemType='Premium' AND Amount = 0")[0];
        invoiceItemsRow.Amount = this.ds.tblQuoteAdditionalInterests[index2].BillableAmount;
        invoiceItemsRow.InvoicesRow.BillTo = this.ds.tblQuoteAdditionalInterests[index2].InterestName;
        invoiceItemsRow.InvoicesRow.AdditionalInterestID = this.ds.tblQuoteAdditionalInterests[index2].ID;
      }
    }
  }

  private void RemoveZeroInvoices()
  {
    List<dsInstallmentBilling.InvoicesRow> source1 = new List<dsInstallmentBilling.InvoicesRow>();
    int num1 = this.ds.Invoices.Count - 1;
    for (int index = 0; index <= num1; ++index)
    {
      int length = this.ds.InvoiceItems.Select($"InvoiceNum={this.ds.Invoices[index].InvoiceNum} AND Amount<>0").Length;
      if (Decimal.Compare(Utility.IsNull<Decimal>(RuntimeHelpers.GetObjectValue(this.ds.InvoiceItems.Compute("SUM(Amount)", $"InvoiceNum={this.ds.Invoices[index].InvoiceNum}")), 0M), 0M) == 0 & length == 0)
        source1.Add(this.ds.Invoices[index]);
    }
    if (!source1.Any<dsInstallmentBilling.InvoicesRow>())
      return;
    if (this.Quote.HasNonZeroPremiums)
    {
      if (source1.Count == this.ds.Invoices.Count)
      {
        try
        {
          List<dsInstallmentBilling.InvoicesRow> source2 = source1;
          System.Func<dsInstallmentBilling.InvoicesRow, IEnumerable<dsInstallmentBilling.InvoiceItemsRow>> selector;
          // ISSUE: reference to a compiler-generated field
          if (frmInstallmentBilling._Closure\u0024__.\u0024I186\u002D0 != null)
          {
            // ISSUE: reference to a compiler-generated field
            selector = frmInstallmentBilling._Closure\u0024__.\u0024I186\u002D0;
          }
          else
          {
            // ISSUE: reference to a compiler-generated field
            frmInstallmentBilling._Closure\u0024__.\u0024I186\u002D0 = selector = (System.Func<dsInstallmentBilling.InvoicesRow, IEnumerable<dsInstallmentBilling.InvoiceItemsRow>>) ([SpecialName] (invd) => (IEnumerable<dsInstallmentBilling.InvoiceItemsRow>) invd.GetInvoiceItemsRows());
          }
          foreach (dsInstallmentBilling.InvoiceItemsRow invoiceItemsRow1 in source2.SelectMany<dsInstallmentBilling.InvoicesRow, dsInstallmentBilling.InvoiceItemsRow>(selector))
          {
            dsInstallmentBilling.InvoiceItemsRow invoiceItemsRow2;
            string str = (invoiceItemsRow2 = invoiceItemsRow1).Description + " (Offsetting Premiums)";
            invoiceItemsRow2.Description = str;
          }
          return;
        }
        finally
        {
          IEnumerator<dsInstallmentBilling.InvoiceItemsRow> enumerator;
          enumerator?.Dispose();
        }
      }
    }
    try
    {
      foreach (dsInstallmentBilling.InvoicesRow row in source1)
        this.ds.Invoices.RemoveInvoicesRow(row);
    }
    finally
    {
      List<dsInstallmentBilling.InvoicesRow>.Enumerator enumerator;
      enumerator.Dispose();
    }
    if (SystemSettings.GetSetting<bool>("InstallmentBilling.BlackBox.AllowZeroInvoices", false))
      return;
    int num2 = (int) this.ShowMessage($"{source1.Count} invoices were removed because they contained no premium or fees.", "Invoices Removed", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
  }

  private void SetModFactors()
  {
    try
    {
      foreach (dsInstallmentBilling.InvoicesRow invoice in (TypedTableBase<dsInstallmentBilling.InvoicesRow>) this.ds.Invoices)
      {
        Decimal num1 = 0M;
        if (this._officeDownPayment[invoice.OfficeID])
          num1 = this.ds.tblInstallmentBilling.FindByQuoteOptionIDOfficeID(this._quoteOptionID, invoice.OfficeID).Downpayment;
        Decimal d1 = Decimal.Subtract(this._totalPremium[invoice.OfficeID], num1);
        dsInstallmentBilling.InvoiceItemsRow[] invoiceItemsRows = invoice.GetInvoiceItemsRows();
        int index = 0;
        while (index < invoiceItemsRows.Length)
        {
          dsInstallmentBilling.InvoiceItemsRow invoiceItemsRow = invoiceItemsRows[index];
          Decimal num2 = 1M;
          if (Decimal.Compare(Decimal.Add(d1, num1), 0M) != 0)
            num2 = this.CalculateModFactor(invoiceItemsRow.Amount, Convert.ToDouble(d1), num1);
          if (invoiceItemsRow.IsOptionFeeIDNull())
            invoiceItemsRow.ModFactor = num2;
          checked { ++index; }
        }
      }
    }
    finally
    {
      IEnumerator<dsInstallmentBilling.InvoicesRow> enumerator;
      enumerator?.Dispose();
    }
  }

  protected virtual Decimal CalculateModFactor(
    Decimal amount,
    double premium,
    Decimal downpaymentAmount)
  {
    return Decimal.Divide(amount, Decimal.Add(new Decimal(premium), downpaymentAmount));
  }

  private void dgInstallments_InitializeRow(object sender, InitializeRowEventArgs e)
  {
    if (e.Row.Band.Index == 0)
    {
      if (Decimal.Compare(Conversions.ToDecimal(e.Row.Cells["TotalPremium"].Value), 0M) >= 0)
        return;
      e.Row.Cells["TotalPremium"].Appearance.ForeColor = Color.Red;
    }
    else
    {
      if (e.Row.Band.Index != 2 || Decimal.Compare(Conversions.ToDecimal(e.Row.Cells["Amount"].Value), 0M) >= 0)
        return;
      e.Row.Cells["Amount"].Appearance.ForeColor = Color.Red;
    }
  }

  private void CloseFormOnUIThread()
  {
    if (MDIControls.Instance.MDIParent.InvokeRequired)
      InvokeExtensions.BetterInvoke((ISynchronizeInvoke) MDIControls.Instance.MDIParent, (Delegate) new MethodInvoker(this.CloseFormOnUIThread), new object[0]);
    else
      this.Close();
  }

  private bool AllocateRemainerToFinalInstallment(Decimal remaining, bool isFee)
  {
    bool finalInstallment;
    if (!this._assignRemainderFinalInstallment)
      finalInstallment = false;
    else if (Decimal.Compare(remaining, 0M) == 0 || this.ds.Invoices.Count <= 1)
    {
      finalInstallment = false;
    }
    else
    {
      if (!isFee ? SystemSettings.GetSetting<bool>("InstallmentBilling.AllocateRemainingPremiumToFinalInvoice", false) : SystemSettings.GetSetting<bool>("InstallmentBilling.AllocateRemainingFeeToFinalInvoice", false))
      {
        try
        {
          foreach (dsInstallmentBilling.InvoiceItemsRow invoiceItemsRow1 in this.ds.InvoiceItems.Reverse<dsInstallmentBilling.InvoiceItemsRow>())
          {
            if (isFee)
            {
              if (!invoiceItemsRow1.IsOptionFeeIDNull())
              {
                dsInstallmentBilling.InvoiceItemsRow invoiceItemsRow2;
                Decimal num = Decimal.Add((invoiceItemsRow2 = invoiceItemsRow1).Amount, remaining);
                invoiceItemsRow2.Amount = num;
                finalInstallment = true;
                goto label_16;
              }
            }
            else if (invoiceItemsRow1.IsOptionFeeIDNull())
            {
              dsInstallmentBilling.InvoiceItemsRow invoiceItemsRow3;
              Decimal num = Decimal.Add((invoiceItemsRow3 = invoiceItemsRow1).Amount, remaining);
              invoiceItemsRow3.Amount = num;
              finalInstallment = true;
              goto label_16;
            }
          }
        }
        finally
        {
          IEnumerator<dsInstallmentBilling.InvoiceItemsRow> enumerator;
          enumerator?.Dispose();
        }
      }
      finalInstallment = false;
    }
label_16:
    return finalInstallment;
  }

  protected virtual void AdjustUnevenPennySplits()
  {
    Decimal num1 = Decimal.Subtract(this._premiumSum, Math.Round(this.PremiumAllocated, 2));
    int index = this.ds.InvoiceItems.Count - 1;
    if (!this.AllocateRemainerToFinalInstallment(num1, false))
    {
      Decimal d2_1 = 0.01M;
      if (this._roundPremiums)
        d2_1 = 1M;
      Decimal d2_2 = new Decimal(Convert.ToDouble(d2_1) * 0.9);
      while (Decimal.Compare(Math.Abs(num1), d2_2) >= 0)
      {
        if (this.ds.InvoiceItems[index].IsOptionFeeIDNull() && Decimal.Compare(this.ds.InvoiceItems[index].ModFactor, 1M) != 0 && Decimal.Compare(Math.Abs(num1), 0M) != 0)
        {
          if (Decimal.Compare(num1, 0M) < 0)
          {
            dsInstallmentBilling.InvoiceItemsRow invoiceItem;
            Decimal num2 = Decimal.Subtract((invoiceItem = this.ds.InvoiceItems[index]).Amount, d2_1);
            invoiceItem.Amount = num2;
            num1 = Decimal.Add(num1, d2_1);
          }
          else
          {
            dsInstallmentBilling.InvoiceItemsRow invoiceItem;
            Decimal num3 = Decimal.Add((invoiceItem = this.ds.InvoiceItems[index]).Amount, d2_1);
            invoiceItem.Amount = num3;
            num1 = Decimal.Subtract(num1, d2_1);
          }
        }
        if (index == 0)
          index = this.ds.InvoiceItems.Count - 1;
        else
          --index;
      }
    }
    Decimal num4 = Decimal.Subtract(this._feesSum, Math.Round(this.FeesAllocated, 2));
    if (this.AllocateRemainerToFinalInstallment(num4, true))
      return;
    while ((Decimal.Compare(num4, 0M) != 0 || this.ImbalancedFeesExist()) && this.ds.Invoices.Count > 1)
    {
      if (Decimal.Compare(Utility.IsNull<Decimal>(RuntimeHelpers.GetObjectValue(this.ds.InvoiceItems.Compute("SUM(Amount)", "OptionFeeID IS NOT NULL")), 0M), 0M) == 0 && !this.ImbalancedFeesExist())
      {
        ErrorHandler.HandleErrorOnThread((Control) MDIControls.Instance.MDIParent, (Exception) new InvalidOperationException("Unable to distribute penny splits"));
        break;
      }
      int num5 = !this.ds.InvoiceItems[index].IsOptionFeeIDNull() ? 1 : 0;
      string str = string.Empty;
      if (num5 != 0)
        str = this.ds.Fees.FindByOptionFeeID(this.ds.InvoiceItems[index].OptionFeeID).AppliesToPaymentID;
      if (frmInstallmentBilling.SpreadFees.Contains(str))
      {
        Decimal num6 = Utility.IsNull<Decimal>(RuntimeHelpers.GetObjectValue(this.ds.InvoiceItems.Compute("SUM(Amount)", "OptionFeeID=" + this.ds.InvoiceItems[index].OptionFeeID.ToString())), 0M);
        dsInstallmentBilling.FeesRow feesRow = (dsInstallmentBilling.FeesRow) this.ds.Fees.Select($"OptionFeeID='{Conversions.ToString(this.ds.InvoiceItems[index].OptionFeeID)}'")[0];
        num4 = Decimal.Subtract(feesRow.Amount, num6);
        if (Decimal.Compare(this.ds.InvoiceItems[index].Amount, 0M) != 0 && Decimal.Compare(num6, feesRow.Amount) != 0)
        {
          Decimal amount = this.ds.InvoiceItems[index].Amount;
          if (Decimal.Compare(num6, feesRow.Amount) < 0)
          {
            dsInstallmentBilling.InvoiceItemsRow invoiceItem;
            Decimal num7 = Decimal.Add((invoiceItem = this.ds.InvoiceItems[index]).Amount, 0.01M);
            invoiceItem.Amount = num7;
            num4 = Decimal.Subtract(num4, 0.01M);
            Decimal.Divide(this.ds.InvoiceItems[index].Amount, amount);
            this.ds.InvoiceItems[index].ModFactor = Decimal.Divide(this.ds.InvoiceItems[index].Amount, feesRow.Amount);
          }
          else
          {
            if (Decimal.Compare(num6, feesRow.Amount) <= 0)
              break;
            dsInstallmentBilling.InvoiceItemsRow invoiceItem;
            Decimal num8 = Decimal.Subtract((invoiceItem = this.ds.InvoiceItems[index]).Amount, 0.01M);
            invoiceItem.Amount = num8;
            num4 = Decimal.Add(num4, 0.01M);
            Decimal.Divide(amount, this.ds.InvoiceItems[index].Amount);
            this.ds.InvoiceItems[index].ModFactor = Decimal.Divide(this.ds.InvoiceItems[index].Amount, feesRow.Amount);
          }
        }
      }
      if (index == 0)
        index = this.ds.InvoiceItems.Count - 1;
      else
        --index;
    }
  }

  private bool ImbalancedFeesExist()
  {
    int num = this.ds.InvoiceItems.Count - 1;
    bool flag;
    for (int index = 0; index <= num; ++index)
    {
      if (!this.ds.InvoiceItems[index].IsOptionFeeIDNull())
      {
        Decimal d1 = Utility.IsNull<Decimal>(RuntimeHelpers.GetObjectValue(this.ds.InvoiceItems.Compute("SUM(Amount)", "OptionFeeID=" + this.ds.InvoiceItems[index].OptionFeeID.ToString())), 0M);
        dsInstallmentBilling.FeesRow feesRow = (dsInstallmentBilling.FeesRow) this.ds.Fees.Select("OptionFeeID=" + this.ds.InvoiceItems[index].OptionFeeID.ToString())[0];
        string appliesToPaymentId = this.ds.Fees.FindByOptionFeeID(this.ds.InvoiceItems[index].OptionFeeID).AppliesToPaymentID;
        if (Decimal.Compare(d1, feesRow.Amount) != 0 && frmInstallmentBilling.SpreadFees.Contains(appliesToPaymentId))
        {
          flag = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(appliesToPaymentId, "H", false) != 0 || this.ds.Invoices.Select("IsDownpayment=0 AND OfficeID=" + Conversions.ToString(feesRow.OfficeID)).Length >= 2 || Decimal.Compare(d1, 0M) != 0;
          goto label_7;
        }
      }
    }
    flag = false;
label_7:
    return flag;
  }

  private void dgInstallments_BeforeCellUpdate(object sender, BeforeCellUpdateEventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(e.Cell.Column.Key, "Amount", false) != 0 || Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(e.NewValue)))
      return;
    ((CancelEventArgs) e).Cancel = true;
  }

  private DateTime GetDueDateFromCompanyInstallmentSetup(bool isDownpaymentInvoice)
  {
    DataRow dataRow = DefaultDatabase.ExecuteDataRow("dbo.GetCompanyInstallmentDueDate", new object[4]
    {
      (object) "@downpaymentInvoice",
      (object) isDownpaymentInvoice,
      (object) "@quoteOptionID",
      (object) this.QuoteOption.QuoteOptionID
    });
    this._paymentTerms = Conversions.ToInteger(dataRow[1]);
    DateTime installmentSetup = (DateTime) dataRow[0];
    if (isDownpaymentInvoice)
      this._paymentTerms = Conversions.ToInteger(DefaultDatabase.ExecuteDataRow("dbo.GetCompanyInstallmentDueDate", new object[4]
      {
        (object) "@downpaymentInvoice",
        (object) false,
        (object) "@quoteOptionID",
        (object) this.QuoteOption.QuoteOptionID
      })[1]);
    return installmentSetup;
  }

  protected virtual DateTime GeProducerLineGaapDate(Guid companyLineGuid, ProducerLine pl)
  {
    this.AlreadyEvaluateGaap = true;
    CompanyLine companyLine = new CompanyLine(companyLineGuid);
    DateTime dateTime1 = !this._isEndorsement ? this.Quote.EffectiveDate : this.Quote.EndorsementEffective;
    DateTime dateTime2;
    if (pl.EffectiveDatePlusDays > 0 || pl.UseEndOfMonthEffDatePlusDays)
    {
      if (this._implementEffectiveGAAP && DateTime.Compare(CurrentUser.Instance.GetServerTime(), dateTime1) > 0)
        dateTime1 = CurrentUser.Instance.GetServerTime();
      if (pl.EffectiveDatePlusDays > 0)
      {
        dateTime2 = dateTime1.AddDays((double) pl.EffectiveDatePlusDays);
        goto label_8;
      }
      if (pl.UseEndOfMonthEffDatePlusDays)
      {
        dateTime2 = new DateTime(dateTime1.Year, dateTime1.Month, DateTime.DaysInMonth(dateTime1.Year, dateTime1.Month)).AddDays((double) pl.EndOfMonthEffDatePlusDays);
        goto label_8;
      }
    }
    int num = !this._isEndorsement ? (!pl.HasDaysDue ? companyLine.GetDaysDue(this.Quote) : pl.DaysDue) : (!pl.HasDaysDueEndorsement ? companyLine.GetDaysDue(this.Quote) : pl.DaysDueEndorsement);
    DateTime serverTime = CurrentUser.Instance.GetServerTime();
    dateTime2 = (DateTime.Compare(dateTime1, serverTime) <= 0 ? serverTime : dateTime1).AddDays((double) num);
label_8:
    return dateTime2;
  }

  protected virtual DateTime GetDateDue(Guid companyLineGuid, bool isDownpaymentInvoice)
  {
    DateTime dateDue;
    Exception exception;
    try
    {
      ProducerLine pl = new ProducerLine(this._quote);
      bool flag;
      bool gaap;
      try
      {
        flag = pl.IsAccountCurrent;
        gaap = pl.GAAP;
      }
      catch (NoProducerLineException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        int num = (int) this.ShowMessage("No producer line setup could be found for this producer location or it is outside of the Effective Period.", "No Producer/Line Setups", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        dateDue = DateTime.MinValue;
        ProjectData.ClearProjectError();
        goto label_14;
      }
      if (gaap && !this.AlreadyEvaluateGaap)
      {
        dateDue = this.GeProducerLineGaapDate(companyLineGuid, pl);
      }
      else
      {
        if (this._quote.BillingType == 2)
          flag = false;
        if (!flag && !this.QuoteOption.IsCompanyInstallmentIDNull)
          dateDue = this.GetDueDateFromCompanyInstallmentSetup(isDownpaymentInvoice);
        else if (!flag)
        {
          dateDue = this.GetDateDueFromCompanyLine(pl, companyLineGuid);
        }
        else
        {
          DateTime dateTime1 = isDownpaymentInvoice || this.QuoteOption.IsCompanyInstallmentIDNull ? this.GetInvoiceStartDate(pl, companyLineGuid) : this.GetDueDateFromCompanyInstallmentSetup(isDownpaymentInvoice);
          DateTime dateTime2 = !this._isEndorsement ? this.Quote.EffectiveDate : this.Quote.EndorsementEffective;
          DateTime dateTime3 = !isDownpaymentInvoice ? (gaap ? (DateTime.Compare(dateTime1, dateTime2) <= 0 ? new DateTime(dateTime2.Year, dateTime2.Month, DateTime.DaysInMonth(dateTime2.Year, dateTime2.Month)) : new DateTime(dateTime1.Year, dateTime1.Month, DateTime.DaysInMonth(dateTime1.Year, dateTime1.Month))) : (this._includeEndorsementsForGAAP ? (DateTime.Compare(dateTime2, dateTime1) <= 0 ? new DateTime(dateTime1.Year, dateTime1.Month, DateTime.DaysInMonth(dateTime1.Year, dateTime1.Month)) : new DateTime(dateTime2.Year, dateTime2.Month, DateTime.DaysInMonth(dateTime2.Year, dateTime2.Month))) : new DateTime(dateTime1.Year, dateTime1.Month, DateTime.DaysInMonth(dateTime1.Year, dateTime1.Month)))) : (!this._downPaymentGAAP ? (!this._downpaymentFromEffectiveDate ? (!this._downPaymentFromEffEndMonth ? new DateTime(dateTime1.Year, dateTime1.Month, DateTime.DaysInMonth(dateTime1.Year, dateTime1.Month)) : new DateTime(dateTime2.Year, dateTime2.Month, DateTime.DaysInMonth(dateTime2.Year, dateTime2.Month))) : new DateTime(dateTime2.Year, dateTime2.Month, DateTime.DaysInMonth(dateTime2.Year, dateTime2.Month))) : (DateTime.Compare(dateTime1, dateTime2) <= 0 ? new DateTime(dateTime2.Year, dateTime2.Month, DateTime.DaysInMonth(dateTime2.Year, dateTime2.Month)) : new DateTime(dateTime1.Year, dateTime1.Month, DateTime.DaysInMonth(dateTime1.Year, dateTime1.Month))));
          CompanyLine companyLine = new CompanyLine(companyLineGuid);
          this._paymentTerms = !this._isEndorsement ? (!pl.HasDaysDue ? companyLine.GetDaysDue(this.Quote) : pl.DaysDue) : (!pl.HasDaysDueEndorsement ? companyLine.GetDaysDue(this.Quote) : pl.DaysDueEndorsement);
          dateDue = dateTime3.AddDays((double) this._paymentTerms);
        }
      }
    }
    catch (Exception ex) when (
    {
      // ISSUE: unable to correctly present filter
      ProjectData.SetProjectError(ex);
      exception = ex;
      if (!this.BlackBoxMode)
      {
        SuccessfulFiltering;
      }
      else
        throw;
    }
    )
    {
      ErrorHandler.HandleErrorOnThread((Control) MDIControls.Instance.MDIParent, exception);
      ProjectData.ClearProjectError();
    }
label_14:
    return dateDue;
  }

  protected virtual DateTime GetInvoiceStartDate(ProducerLine pl, Guid companyLineGuid)
  {
    return CurrentUser.Instance.GetServerTime();
  }

  protected DateTime GetDateDueFromCompanyLine(ProducerLine pl, Guid companyLineGuid)
  {
    DateTime serverTime = CurrentUser.Instance.GetServerTime();
    CompanyLine companyLine = new CompanyLine(companyLineGuid);
    string paymentMeasuredFrom = companyLine.GetProducerPaymentMeasuredFrom(this.Quote);
    this._paymentTerms = !this._isEndorsement ? (!pl.HasDaysDue ? companyLine.GetDaysDue(this.Quote) : pl.DaysDue) : (!pl.HasDaysDueEndorsement ? companyLine.GetDaysDue(this.Quote) : pl.DaysDueEndorsement);
    return this.GetPaymentTermDateDue(serverTime, paymentMeasuredFrom);
  }

  private void DefaultingMonthFollowingDownPayment(
    ref DateTime lastInvoicedDueDate,
    int invoiceNumber,
    bool hasDownPayment)
  {
    if (invoiceNumber - 2 != 0 || !hasDownPayment)
      return;
    DateTime dateDue = this.ds.Invoices[0].DateDue;
    if (lastInvoicedDueDate.Year != dateDue.Year || lastInvoicedDueDate.Month != dateDue.Month)
      return;
    if (this._monthFollowingDownPayment)
    {
      int day = this._dayOfMonthNumber;
      if (day > DateTime.DaysInMonth(lastInvoicedDueDate.Year, lastInvoicedDueDate.Month))
        day = DateTime.DaysInMonth(lastInvoicedDueDate.Year, lastInvoicedDueDate.Month);
      lastInvoicedDueDate = new DateTime(lastInvoicedDueDate.Year, lastInvoicedDueDate.Month, day);
    }
    this.ds.Invoices[invoiceNumber - 2].DateDue = lastInvoicedDueDate;
  }

  private bool MakeFirstPaymentEqualDownPayment(
    bool hasDownPayment,
    int invoiceNumber,
    DateTime tempDate)
  {
    return this._makeFirstPaymentEqualsDownpaymentIfLess && hasDownPayment && invoiceNumber == 2 && DateTime.Compare(tempDate, this.ds.Invoices[0].DateDue) < 0;
  }

  private DateTime LastInvoiceWithFinalDays(
    int invoiceNumber,
    bool hasDownpayment,
    bool isDownpaymentInvoice)
  {
    DateTime dateTime = DateTime.MinValue;
    if (!isDownpaymentInvoice && invoiceNumber == this._totalPayments)
    {
      DateTime dateDue = this.ds.Invoices[invoiceNumber - 2].DateDue;
      if (this._usingEffectiveDateBilled && this._effDateBilledAltFinalInstallDays != int.MinValue)
        dateTime = !this._useMonthFinalInstallment ? dateDue.AddDays((double) this._effDateBilledAltFinalInstallDays) : dateDue.AddMonths(this._effDateBilledAltFinalInstallDays);
      else if (this._usingPolicyEffective && this._effectiveAltFinalInstallDays != int.MinValue)
        dateTime = !this._useMonthFinalInstallment ? dateDue.AddDays((double) this._effectiveAltFinalInstallDays) : dateDue.AddMonths(this._effectiveAltFinalInstallDays);
      else if (this._usingPolicyExpiration && this._expirationAltFinalInstallDays != int.MinValue)
        dateTime = !this._useMonthFinalInstallment ? dateDue.AddDays((double) this._expirationAltFinalInstallDays) : dateDue.AddMonths(this._expirationAltFinalInstallDays);
      else if (this._usingDayOfMonth && this._dayOfMonthAltFinalInstallDays != int.MinValue)
        dateTime = !this._useMonthFinalInstallment ? dateDue.AddDays((double) this._dayOfMonthAltFinalInstallDays) : dateDue.AddMonths(this._dayOfMonthAltFinalInstallDays);
      if (DateTime.Compare(dateTime, DateTime.MinValue) != 0)
        dateTime = this.DeferWeekendInvoices(dateTime);
    }
    return dateTime;
  }

  protected virtual DateTime GetDateDue(
    int invoiceNumber,
    bool hasDownpayment,
    bool isDownpaymentInvoice)
  {
    DateTime dateDue1;
    if (hasDownpayment && invoiceNumber > 2 || !hasDownpayment && invoiceNumber > 1)
    {
      DateTime t1 = this.LastInvoiceWithFinalDays(invoiceNumber, hasDownpayment, isDownpaymentInvoice);
      if (DateTime.Compare(t1, DateTime.MinValue) != 0)
      {
        dateDue1 = t1;
      }
      else
      {
        DateTime dateDue2 = this.ds.Invoices[invoiceNumber - 2].DateDue;
        DateTime dateTime;
        if (!this.QuoteOption.IsCompanyInstallmentIDNull)
          dateTime = this.GetDueDateFromCompanyInstallmentSetup(false);
        if (this._usingDayOfMonth)
        {
          if (this._monthFollowingDownPayment)
            this.DefaultingMonthFollowingDownPayment(ref dateDue2, invoiceNumber, hasDownpayment);
          int dayOfMonthNumber = this._dayOfMonthNumber;
          dateTime = this.CalculateDateDue(dateDue2);
          int dayInMonth1 = this.EvaluateDayInMonth(dateTime.Year, dateTime.Month, dayOfMonthNumber);
          if (dateDue2.Year == dateTime.Year && dateDue2.Month == dateTime.Month)
          {
            dateTime = this.PaymentTerms != 0 || !this._ignoreDueDateIncrementOnZeroPaymentTerm ? dateTime.AddMonths(1) : dateTime.AddMonths(this.PaymentTerms);
            int dayInMonth2 = this.EvaluateDayInMonth(dateTime.Year, dateTime.Month, dayInMonth1);
            dateTime = new DateTime(dateTime.Year, dateTime.Month, dayInMonth2);
          }
          else
            dateTime = new DateTime(dateTime.Year, dateTime.Month, dayInMonth1);
        }
        else if (this._usingEffectiveDateBilled)
        {
          if (this._monthFollowingDownPayment_Eff_DateBilled)
            this.DefaultingMonthFollowingDownPayment(ref dateDue2, invoiceNumber, hasDownpayment);
          dateTime = this.CalculateDateDue(this.ds.Invoices[invoiceNumber - 2].DateDue);
        }
        else if (this._usingPolicyEffective)
        {
          if (this._monthFollowingDownPayment_Eff)
            this.DefaultingMonthFollowingDownPayment(ref dateDue2, invoiceNumber, hasDownpayment);
          dateTime = this.CalculateDateDue(dateDue2);
          int day = DateTime.DaysInMonth(dateTime.Year, dateTime.Month);
          if (day < this._effectiveDateDay)
            dateTime = new DateTime(dateTime.Year, dateTime.Month, day);
          else if (this._revertToEffectiveDateDay)
            dateTime = new DateTime(dateTime.Year, dateTime.Month, this._effectiveDateDay);
        }
        else if (this._usingPolicyExpiration)
        {
          if (this._monthFollowingDownPayment_Exp)
            this.DefaultingMonthFollowingDownPayment(ref dateDue2, invoiceNumber, hasDownpayment);
          dateTime = this.CalculateDateDue(dateDue2);
          int day = DateTime.DaysInMonth(dateTime.Year, dateTime.Month);
          if (day < this._expirationDateDay)
            dateTime = new DateTime(dateTime.Year, dateTime.Month, day);
          else if (this._revertToExpirationDateDay)
            dateTime = new DateTime(dateTime.Year, dateTime.Month, this._expirationDateDay);
        }
        dateTime = this.DeferWeekendInvoices(dateTime);
        if (this.MakeFirstPaymentEqualDownPayment(hasDownpayment, invoiceNumber, dateTime))
          dateTime = this.ds.Invoices[0].DateDue;
        if (DateTime.Compare(dateTime, DateTime.MinValue) == 0)
          dateTime = this.GetPaymentTermDateDue(dateDue2, this._quote.CompanyLine.GetProducerPaymentMeasuredFrom(this.Quote));
        dateDue1 = dateTime;
      }
    }
    else if (this.UsingAlternateFirstPaymentDays(hasDownpayment, isDownpaymentInvoice, invoiceNumber))
    {
      if (!this.QuoteOption.IsCompanyInstallmentIDNull)
        this.GetDueDateFromCompanyInstallmentSetup(false);
      if (this._usingPolicyEffective)
      {
        bool flag = false;
        DateTime dateTime = !this._isEndorsement ? this.Quote.EffectiveDate : this.Quote.EndorsementEffective;
        if (this._monthFollowingDownPayment_Eff && hasDownpayment && invoiceNumber == 2)
        {
          dateTime = this.ds.Invoices[invoiceNumber - 2].DateDue;
          flag = true;
        }
        if (this._effectiveAltFirstInstallDays != int.MinValue)
          dateTime = this._useMonthForAltFirstInstallment ? dateTime.AddMonths(this._effectiveAltFirstInstallDays) : dateTime.AddDays((double) this._effectiveAltFirstInstallDays);
        else if (flag)
          dateTime = this.CalculateDateDue(dateTime);
        if (this.MakeFirstPaymentEqualDownPayment(hasDownpayment, invoiceNumber, dateTime))
          dateTime = this.ds.Invoices[0].DateDue;
        dateDue1 = this.DeferWeekendInvoices(dateTime);
      }
      else if (this._usingEffectiveDateBilled)
      {
        bool flag = false;
        DateTime dateTime = !this._installmentFromDateBilled ? this.Quote.EffectiveDate : CurrentUser.Instance.GetServerTime();
        if (this._monthFollowingDownPayment_Eff_DateBilled && hasDownpayment && invoiceNumber == 2)
        {
          dateTime = this.ds.Invoices[invoiceNumber - 2].DateDue;
          flag = true;
        }
        if (this._effDateBilledAltFirstInstallDays != int.MinValue)
          dateTime = this._useMonthForAltFirstInstallment ? dateTime.AddMonths(this._effDateBilledAltFirstInstallDays) : dateTime.AddDays((double) this._effDateBilledAltFirstInstallDays);
        else if (flag)
          dateTime = this.CalculateDateDue(dateTime);
        if (this.MakeFirstPaymentEqualDownPayment(hasDownpayment, invoiceNumber, dateTime))
          dateTime = this.ds.Invoices[0].DateDue;
        dateDue1 = this.DeferWeekendInvoices(dateTime);
      }
      else if (this._usingDayOfMonth)
      {
        bool flag = false;
        DateTime dateTime;
        if (this._monthFollowingDownPayment && hasDownpayment && invoiceNumber == 2)
        {
          dateTime = this.ds.Invoices[invoiceNumber - 2].DateDue;
          flag = true;
        }
        else
          dateTime = CurrentUser.Instance.GetServerTime();
        if (this._dayOfMonthAltFirstInstallDays != int.MinValue)
          dateTime = this._useMonthForAltFirstInstallment ? dateTime.AddMonths(this._dayOfMonthAltFirstInstallDays) : dateTime.AddDays((double) this._dayOfMonthAltFirstInstallDays);
        else if (flag)
          dateTime = this.CalculateDateDue(dateTime);
        if (!flag || this._implementDayOfMonthOnMonthFollowingDownPayment && this._monthFollowingDownPayment && hasDownpayment && invoiceNumber == 2)
        {
          int day = DateTime.DaysInMonth(dateTime.Year, dateTime.Month);
          dateTime = this._dayOfMonthNumber <= day ? new DateTime(dateTime.Year, dateTime.Month, this._dayOfMonthNumber) : new DateTime(dateTime.Year, dateTime.Month, day);
        }
        if (this.MakeFirstPaymentEqualDownPayment(hasDownpayment, invoiceNumber, dateTime))
          dateTime = this.ds.Invoices[0].DateDue;
        dateTime = this.DeferWeekendInvoices(dateTime);
        dateDue1 = dateTime;
      }
      else if (this._usingPolicyExpiration)
      {
        DateTime dateTime = this.Quote.ExpirationDate;
        bool flag = false;
        if (this._monthFollowingDownPayment_Exp && hasDownpayment && invoiceNumber == 2)
        {
          dateTime = this.ds.Invoices[invoiceNumber - 2].DateDue;
          flag = true;
        }
        if (this._expirationAltFirstInstallDays != int.MinValue)
          dateTime = this._useMonthForAltFirstInstallment ? dateTime.AddMonths(this._expirationAltFirstInstallDays) : dateTime.AddDays((double) this._expirationAltFirstInstallDays);
        else if (flag)
          dateTime = this.CalculateDateDue(dateTime);
        if (this.MakeFirstPaymentEqualDownPayment(hasDownpayment, invoiceNumber, dateTime))
          dateTime = this.ds.Invoices[0].DateDue;
        dateDue1 = this.DeferWeekendInvoices(dateTime);
      }
    }
    else
      dateDue1 = this.GetDateDue(this._quote.CompanyLineGuid.Value, isDownpaymentInvoice);
    return dateDue1;
  }

  private DateTime CalculateDateDue(DateTime tmpDate)
  {
    return this._useMonth ? tmpDate.AddMonths(this._paymentTerms) : tmpDate.AddDays((double) this._paymentTerms);
  }

  private bool UsingAlternateFirstPaymentDays(
    bool hasDownPayment,
    bool isDownpaymentInvoice,
    int invoiceNumber)
  {
    if ((!hasDownPayment || isDownpaymentInvoice || invoiceNumber != 2) && (hasDownPayment || invoiceNumber != 1) || this._effDateBilledAltFirstInstallDays == int.MinValue && this._effectiveAltFirstInstallDays == int.MinValue && this._dayOfMonthAltFirstInstallDays == int.MinValue && this._expirationAltFirstInstallDays == int.MinValue)
      return false;
    return this._usingEffectiveDateBilled || this._usingPolicyEffective || this._usingDayOfMonth || this._usingPolicyExpiration;
  }

  private int EvaluateDayInMonth(int year, int month, int day)
  {
    int num = DateTime.DaysInMonth(year, month);
    if (day > num)
      day = num;
    return day;
  }

  private void FillInvoices()
  {
    try
    {
      int num1 = 0;
      int num2 = this.ds.Offices.Count - 1;
      for (int index = 0; index <= num2; ++index)
      {
        int officeId1 = this.ds.Offices[index].OfficeID;
        dsInstallmentBilling.tblInstallmentBillingRow optionIdOfficeId = this.ds.tblInstallmentBilling.FindByQuoteOptionIDOfficeID(this._quoteOptionID, officeId1);
        int num3 = this.ds.tblInstallmentBilling.FindByQuoteOptionIDOfficeID(this._quoteOptionID, officeId1).SingleInvoice ? 1 : 0;
        this._totalPayments = 0;
        this._totalPayments = num3 == 0 ? (!this._splitAcross ? optionIdOfficeId.NumPayments : this._selectedInvoices.Count) : 1;
        int? billingTypeId;
        int num4;
        if (!optionIdOfficeId.IsDownpaymentBillingTypeIDNull())
        {
          if (this._splitAcross)
          {
            int downpaymentBillingTypeId = optionIdOfficeId.DownpaymentBillingTypeID;
            billingTypeId = this._quote.BillingTypeID;
            int num5 = billingTypeId.Value;
            num4 = downpaymentBillingTypeId != num5 ? 1 : 0;
          }
          else
            num4 = 1;
        }
        else
          num4 = 0;
        bool hasDownpayment = num4 != 0;
        if (hasDownpayment)
        {
          // ISSUE: variable of a reference type
          int& local;
          // ISSUE: explicit reference operation
          int num6 = ^(local = ref this._totalPayments) + 1;
          local = num6;
        }
        this._officeDownPayment[officeId1] = hasDownpayment;
        int totalPayments = this._totalPayments;
        for (int invoiceNumber = 1; invoiceNumber <= totalPayments; ++invoiceNumber)
        {
          ++num1;
          bool isDownpaymentInvoice = false;
          int downpaymentBillingTypeId;
          if (hasDownpayment && invoiceNumber == 1)
          {
            downpaymentBillingTypeId = optionIdOfficeId.DownpaymentBillingTypeID;
            isDownpaymentInvoice = true;
          }
          else
          {
            billingTypeId = this._quote.BillingTypeID;
            downpaymentBillingTypeId = billingTypeId.Value;
          }
          string str = (string) null;
          if (!this._billingTypes.TryGetValue(downpaymentBillingTypeId, out str))
          {
            str = DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "SELECT BillingType FROM lstBillingTypes WHERE BillingTypeID=@ID", new object[2]
            {
              (object) "@ID",
              (object) downpaymentBillingTypeId
            });
            this._billingTypes.Add(downpaymentBillingTypeId, str);
          }
          dsInstallmentBilling.InvoicesRow row = this.ds.Invoices.NewInvoicesRow();
          dsInstallmentBilling.InvoicesRow invoicesRow = row;
          invoicesRow.InvoiceNum = num1;
          if (!this._splitAcross)
          {
            invoicesRow.DateDue = this.GetDateDue(invoiceNumber, hasDownpayment, isDownpaymentInvoice);
            invoicesRow.DateBilled = this.GetDateBilled(isDownpaymentInvoice, row.DateDue);
          }
          else
            invoicesRow.DateBilled = this.GetDateBilled();
          if (!invoicesRow.IsDateDueNull() && DateTime.Compare(invoicesRow.DateDue, DateTime.MinValue) == 0 && !this.BlackBoxMode && this._noProducerLineSetupForProducerLocation)
            this.CloseFormOnUIThread();
          invoicesRow.Comment = this._quote.CompanyLine.DefaultInvoiceComments;
          DateTime dateTime;
          if (!invoicesRow.IsDateDueNull())
          {
            dateTime = invoicesRow.DateDue;
            DateTime date1 = dateTime.Date;
            dateTime = invoicesRow.DateBilled;
            DateTime date2 = dateTime.Date;
            if (DateTime.Compare(date1, date2) < 0 && !this._allowDateDueLessThanDateBilled)
              invoicesRow.DateDue = invoicesRow.DateBilled;
          }
          if (!invoicesRow.IsDateDueNull())
          {
            dateTime = invoicesRow.DateDue;
            DateTime date3 = dateTime.Date;
            dateTime = invoicesRow.DateBilled;
            DateTime date4 = dateTime.Date;
            if (this.SetDueDateEqualsBillDate(date3, date4))
              invoicesRow.DateDue = invoicesRow.DateBilled;
          }
          invoicesRow.OfficeID = this.ds.Offices[index].OfficeID;
          invoicesRow.IsDownpayment = isDownpaymentInvoice;
          invoicesRow.BillingType = str;
          this.ds.Invoices.AddInvoicesRow(row);
          Dictionary<int, int> officeInvCount;
          int officeId2;
          (officeInvCount = this._officeInvCount)[officeId2 = row.OfficeID] = officeInvCount[officeId2] + 1;
        }
      }
    }
    catch (NullReferenceException ex) when (
    {
      // ISSUE: unable to correctly present filter
      ProjectData.SetProjectError((Exception) ex);
      if (!this.BlackBoxMode)
      {
        SuccessfulFiltering;
      }
      else
        throw;
    }
    )
    {
      ProjectData.ClearProjectError();
    }
  }

  private bool SetDueDateEqualsBillDate(DateTime dueDate, DateTime billedDate)
  {
    return this._setDueDateEqualsBillDate && (dueDate.Year != billedDate.Year || dueDate.Month != billedDate.Month || dueDate.Day != billedDate.Day) && (this._tmpPolicyExpirationDate - billedDate).Days <= 30;
  }

  private bool SetupDownpaymentInvoices()
  {
    bool flag;
    try
    {
      foreach (dsInstallmentBilling.OfficesRow office in (TypedTableBase<dsInstallmentBilling.OfficesRow>) this.ds.Offices)
      {
        if (this.ds.tblInstallmentBilling.FindByQuoteOptionIDOfficeID(this._quoteOptionID, office.OfficeID) == null)
        {
          if (this.BlackBoxMode)
            throw new InvalidOperationException("An invalid office configuration was detected on this policy.");
          MessageBox.Show("An invalid office configuration was detected on this policy.\n\nPlease ensure that all premium and fees are allocated to the proper offices.", "Invalid Office Configuration", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          this.Close();
          flag = false;
          goto label_12;
        }
        if (this._officeDownPayment[office.OfficeID])
        {
          Decimal downpayment = this.ds.tblInstallmentBilling.FindByQuoteOptionIDOfficeID(this._quoteOptionID, office.OfficeID).Downpayment;
          dsInstallmentBilling.InvoiceItemsRow row = this.ds.InvoiceItems.NewInvoiceItemsRow();
          dsInstallmentBilling.InvoiceItemsRow invoiceItemsRow = row;
          invoiceItemsRow.InvoiceNum = this.ds.Offices.FindByOfficeID(office.OfficeID).GetInvoicesRows()[0].InvoiceNum;
          invoiceItemsRow.ItemType = "Premium";
          invoiceItemsRow.Amount = downpayment;
          invoiceItemsRow.Description = "Downpayment";
          invoiceItemsRow.SetOptionFeeIDNull();
          invoiceItemsRow.ModFactor = 1M;
          this.ds.InvoiceItems.AddInvoiceItemsRow(row);
        }
      }
    }
    finally
    {
      IEnumerator<dsInstallmentBilling.OfficesRow> enumerator;
      enumerator?.Dispose();
    }
    flag = true;
label_12:
    return flag;
  }

  private bool InvoiceHasDownpayment(int OfficeID)
  {
    return !this.ds.tblInstallmentBilling.FindByQuoteOptionIDOfficeID(this._quoteOptionID, OfficeID).IsDownpaymentBillingTypeIDNull();
  }

  private void DispersePremiums()
  {
    try
    {
      foreach (dsInstallmentBilling.InvoicesRow invoice in (TypedTableBase<dsInstallmentBilling.InvoicesRow>) this.ds.Invoices)
      {
        if (invoice.GetInvoiceItemsRows().Length == 0)
        {
          Decimal d2 = 0M;
          if (this._officeDownPayment[invoice.OfficeID])
            d2 = this.ds.tblInstallmentBilling.FindByQuoteOptionIDOfficeID(this._quoteOptionID, invoice.OfficeID).Downpayment;
          Decimal d1 = Decimal.Subtract(this._totalPremium[invoice.OfficeID], d2);
          int length = this.ds.Invoices.Select("OfficeID=" + invoice.OfficeID.ToString()).Length;
          Decimal num = Decimal.Compare(Math.Abs(d2), 0M) <= 0 || length <= 1 ? (length <= 0 ? 0M : Math.Round(Decimal.Divide(d1, new Decimal(length)), 2)) : Math.Round(Decimal.Divide(d1, new Decimal(length - 1)), 2);
          if (this._roundPremiums)
            num = new Decimal(Convert.ToInt32(num));
          dsInstallmentBilling.InvoiceItemsRow row = this.ds.InvoiceItems.NewInvoiceItemsRow();
          dsInstallmentBilling.InvoiceItemsRow invoiceItemsRow = row;
          invoiceItemsRow.InvoiceNum = invoice.InvoiceNum;
          invoiceItemsRow.ItemType = "Premium";
          invoiceItemsRow.Amount = num;
          invoiceItemsRow.Description = "Premium";
          invoiceItemsRow.SetOptionFeeIDNull();
          invoiceItemsRow.ModFactor = -1M;
          this.ds.InvoiceItems.AddInvoiceItemsRow(row);
        }
      }
    }
    finally
    {
      IEnumerator<dsInstallmentBilling.InvoicesRow> enumerator;
      enumerator?.Dispose();
    }
  }

  protected virtual string FillFeesProcedure => "spInstallmentBilling_Fees";

  private void FillFees()
  {
    this.ds.Fees.Clear();
    DefaultDatabase.LoadDataTable((DataTable) this.ds.Fees, this.FillFeesProcedure, new object[2]
    {
      (object) "@QuoteGuid",
      (object) this._quote.QuoteGuid
    });
    this._feesSum = 0M;
    this.CalculateFeeSum();
  }

  protected virtual void CalculateFeeSum()
  {
    this._feesSum = 0M;
    try
    {
      foreach (dsInstallmentBilling.FeesRow fee in (TypedTableBase<dsInstallmentBilling.FeesRow>) this.ds.Fees)
      {
        fee.Amount = Math.Round(fee.Amount, 2);
        int officeId;
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fee.AppliesToPaymentID, "C", false) == 0)
        {
          dsInstallmentBilling.InvoicesDataTable invoices = this.ds.Invoices;
          officeId = fee.OfficeID;
          string filterExpression = "OfficeID=" + officeId.ToString();
          int length = invoices.Select(filterExpression).Length;
          // ISSUE: variable of a reference type
          Decimal& local;
          // ISSUE: explicit reference operation
          Decimal num = Decimal.Add(^(local = ref this._feesSum), Decimal.Multiply(fee.Amount, new Decimal(length)));
          local = num;
          Dictionary<int, Decimal> totalFees;
          (totalFees = this._totalFees)[officeId = fee.OfficeID] = Decimal.Add(totalFees[officeId], Decimal.Multiply(fee.Amount, new Decimal(length)));
        }
        else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fee.AppliesToPaymentID, "E", false) == 0)
        {
          dsInstallmentBilling.InvoicesDataTable invoices = this.ds.Invoices;
          officeId = fee.OfficeID;
          string filterExpression = "IsDownpayment=0 AND OfficeID=" + officeId.ToString();
          int length = invoices.Select(filterExpression).Length;
          // ISSUE: variable of a reference type
          Decimal& local;
          // ISSUE: explicit reference operation
          Decimal num = Decimal.Add(^(local = ref this._feesSum), Decimal.Multiply(fee.Amount, new Decimal(length)));
          local = num;
          Dictionary<int, Decimal> totalFees;
          (totalFees = this._totalFees)[officeId = fee.OfficeID] = Decimal.Add(totalFees[officeId], Decimal.Multiply(fee.Amount, new Decimal(length)));
        }
        else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fee.AppliesToPaymentID, "H", false) == 0)
        {
          dsInstallmentBilling.InvoicesDataTable invoices = this.ds.Invoices;
          officeId = fee.OfficeID;
          string filterExpression = "IsDownpayment=0 AND OfficeID=" + officeId.ToString();
          if (invoices.Select(filterExpression).Length > 1)
          {
            // ISSUE: variable of a reference type
            Decimal& local;
            // ISSUE: explicit reference operation
            Decimal num = Decimal.Add(^(local = ref this._feesSum), Math.Round(fee.Amount, 2));
            local = num;
            Dictionary<int, Decimal> totalFees;
            (totalFees = this._totalFees)[officeId = fee.OfficeID] = Decimal.Add(totalFees[officeId], Math.Round(fee.Amount, 2));
          }
        }
        else if ("23456@#$%^=+".Contains(fee.AppliesToPaymentID))
        {
          dsInstallmentBilling.InvoicesDataTable invoices = this.ds.Invoices;
          officeId = fee.OfficeID;
          string filterExpression = "OfficeID=" + officeId.ToString();
          int length = invoices.Select(filterExpression).Length;
          int num1 = "23456@#$%^".IndexOf(fee.AppliesToPaymentID) % 5 + 2;
          if ("=+".Contains(fee.AppliesToPaymentID))
            num1 = 12;
          if (("23456=".Contains(fee.AppliesToPaymentID) ? 0 : num1 - 1) < length)
          {
            // ISSUE: variable of a reference type
            Decimal& local;
            // ISSUE: explicit reference operation
            Decimal num2 = Decimal.Add(^(local = ref this._feesSum), fee.Amount);
            local = num2;
            Dictionary<int, Decimal> totalFees;
            (totalFees = this._totalFees)[officeId = fee.OfficeID] = Decimal.Add(totalFees[officeId], fee.Amount);
          }
        }
        else
        {
          // ISSUE: variable of a reference type
          Decimal& local;
          // ISSUE: explicit reference operation
          Decimal num = Decimal.Add(^(local = ref this._feesSum), Math.Round(fee.Amount, 2));
          local = num;
          Dictionary<int, Decimal> totalFees;
          (totalFees = this._totalFees)[officeId = fee.OfficeID] = Decimal.Add(totalFees[officeId], Math.Round(fee.Amount, 2));
        }
      }
    }
    finally
    {
      IEnumerator<dsInstallmentBilling.FeesRow> enumerator;
      enumerator?.Dispose();
    }
  }

  protected virtual void DisperseFees()
  {
    try
    {
      foreach (dsInstallmentBilling.FeesRow fee in (TypedTableBase<dsInstallmentBilling.FeesRow>) this.ds.Fees)
      {
        string appliesToPaymentId = fee.AppliesToPaymentID;
        int index1;
        int index2;
        int num1;
        // ISSUE: reference to a compiler-generated method
        switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(appliesToPaymentId))
        {
          case 537692064:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(appliesToPaymentId, "%", false) == 0)
              break;
            continue;
          case 554469683:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(appliesToPaymentId, "$", false) == 0)
              break;
            continue;
          case 638357778:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(appliesToPaymentId, "#", false) == 0)
              break;
            continue;
          case 772578730:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(appliesToPaymentId, "+", false) == 0)
              break;
            continue;
          case 806133968:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(appliesToPaymentId, "5", false) == 0)
              break;
            continue;
          case 822911587:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(appliesToPaymentId, "4", false) == 0)
              break;
            continue;
          case 856466825:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(appliesToPaymentId, "6", false) == 0)
              break;
            continue;
          case 906799682:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(appliesToPaymentId, "3", false) == 0)
              break;
            continue;
          case 923577301:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(appliesToPaymentId, "2", false) == 0)
              break;
            continue;
          case 940354920:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(appliesToPaymentId, "=", false) == 0)
              break;
            continue;
          case 3222007936:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(appliesToPaymentId, "E", false) == 0)
            {
              DataRow[] dataRowArray = this.ds.Invoices.Select("IsDownpayment=0 AND OfficeID=" + fee.OfficeID.ToString());
              index2 = 0;
              while (index2 < dataRowArray.Length)
              {
                this.ds.InvoiceItems.AddInvoiceItemsRow((dsInstallmentBilling.InvoicesRow) dataRowArray[index2], "Fee", fee.Amount, fee.ChargeName, 1M, fee.OptionFeeID);
                checked { ++index2; }
              }
              continue;
            }
            continue;
          case 3238785555:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(appliesToPaymentId, "D", false) == 0)
            {
              this.ds.InvoiceItems.AddInvoiceItemsRow((dsInstallmentBilling.InvoicesRow) this.ds.Invoices.Select("OfficeID=" + fee.OfficeID.ToString())[0], "Fee", fee.Amount, fee.ChargeName, 1M, fee.OptionFeeID);
              continue;
            }
            continue;
          case 3255563174:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(appliesToPaymentId, "G", false) == 0)
            {
              dsInstallmentBilling.tblInstallmentBillingRow optionIdOfficeId = this.ds.tblInstallmentBilling.FindByQuoteOptionIDOfficeID(this._quoteOptionID, fee.OfficeID);
              Decimal d2_1 = this._totalPremium[fee.OfficeID];
              int length = this.ds.Invoices.Select("IsDownpayment=0 AND OfficeID=" + Conversions.ToString(fee.OfficeID)).Length;
              int num2 = this._officeDownPayment[fee.OfficeID] ? 1 : 0;
              Decimal d2_2 = 0M;
              if (num2 != 0 && Convert.ToDouble(d2_1) != 0.0)
                d2_2 = Decimal.Divide(optionIdOfficeId.Downpayment, d2_1);
              Decimal d2_3 = Decimal.Divide(Decimal.Subtract(1M, d2_2), new Decimal(length));
              Decimal num3 = Math.Round(Decimal.Multiply(fee.Amount, d2_2), 2);
              Decimal num4 = Math.Round(Decimal.Multiply(fee.Amount, d2_3), 2);
              DataRow[] dataRowArray = this.ds.Invoices.Select("OfficeID=" + fee.OfficeID.ToString());
              int index3 = 0;
              while (index3 < dataRowArray.Length)
              {
                dsInstallmentBilling.InvoicesRow parentInvoicesRowByPaymentsPaymentItems = (dsInstallmentBilling.InvoicesRow) dataRowArray[index3];
                this.ds.InvoiceItems.AddInvoiceItemsRow(parentInvoicesRowByPaymentsPaymentItems, "Fee", parentInvoicesRowByPaymentsPaymentItems.IsDownpayment ? num3 : num4, fee.ChargeName, Decimal.Divide(parentInvoicesRowByPaymentsPaymentItems.IsDownpayment ? num3 : num4, fee.Amount), fee.OptionFeeID);
                checked { ++index3; }
              }
              continue;
            }
            continue;
          case 3272340793:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(appliesToPaymentId, "F", false) == 0)
            {
              this.ds.InvoiceItems.AddInvoiceItemsRow((dsInstallmentBilling.InvoicesRow) this.ds.Invoices.Select("IsDownpayment=0 AND OfficeID=" + fee.OfficeID.ToString())[0], "Fee", Math.Round(fee.Amount, 2), fee.ChargeName, 1M, fee.OptionFeeID);
              continue;
            }
            continue;
          case 3289118412:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(appliesToPaymentId, "A", false) == 0)
            {
              int length = this.ds.Invoices.Select("OfficeID=" + fee.OfficeID.ToString()).Length;
              Decimal num5 = Math.Round(Decimal.Divide(fee.Amount, new Decimal(length)), 2);
              dsInstallmentBilling.InvoicesDataTable invoices = this.ds.Invoices;
              index1 = fee.OfficeID;
              string filterExpression = "OfficeID=" + index1.ToString();
              DataRow[] dataRowArray = invoices.Select(filterExpression);
              int index4 = 0;
              while (index4 < dataRowArray.Length)
              {
                this.ds.InvoiceItems.AddInvoiceItemsRow((dsInstallmentBilling.InvoicesRow) dataRowArray[index4], "Fee", num5, fee.ChargeName, Decimal.Divide(num5, fee.Amount), fee.OptionFeeID);
                checked { ++index4; }
              }
              continue;
            }
            continue;
          case 3305896031:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(appliesToPaymentId, "@", false) == 0)
              break;
            continue;
          case 3322673650:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(appliesToPaymentId, "C", false) == 0)
            {
              DataRow[] dataRowArray = this.ds.Invoices.Select("OfficeID=" + fee.OfficeID.ToString());
              index1 = 0;
              while (index1 < dataRowArray.Length)
              {
                this.ds.InvoiceItems.AddInvoiceItemsRow((dsInstallmentBilling.InvoicesRow) dataRowArray[index1], "Fee", fee.Amount, fee.ChargeName, 1M, fee.OptionFeeID);
                checked { ++index1; }
              }
              continue;
            }
            continue;
          case 3339451269:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(appliesToPaymentId, "B", false) == 0)
            {
              int length = this.ds.Invoices.Select("IsDownpayment=0 AND OfficeID=" + fee.OfficeID.ToString()).Length;
              Decimal num6 = length > 0 ? Math.Round(Decimal.Divide(fee.Amount, new Decimal(length)), 2) : fee.Amount;
              dsInstallmentBilling.InvoicesDataTable invoices = this.ds.Invoices;
              index2 = fee.OfficeID;
              string filterExpression = "IsDownpayment=0 AND OfficeID=" + index2.ToString();
              DataRow[] dataRowArray = invoices.Select(filterExpression);
              int index5 = 0;
              while (index5 < dataRowArray.Length)
              {
                this.ds.InvoiceItems.AddInvoiceItemsRow((dsInstallmentBilling.InvoicesRow) dataRowArray[index5], "Fee", num6, fee.ChargeName, Decimal.Divide(num6, fee.Amount), fee.OptionFeeID);
                checked { ++index5; }
              }
              continue;
            }
            continue;
          case 3440116983:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(appliesToPaymentId, "H", false) == 0)
            {
              int length = this.ds.Invoices.Select("IsDownpayment=0 AND OfficeID=" + Conversions.ToString(fee.OfficeID)).Length;
              if (length > 1)
              {
                Decimal num7 = Math.Round(Decimal.Divide(fee.Amount, new Decimal(length)), 2);
                dsInstallmentBilling.InvoicesDataTable invoices = this.ds.Invoices;
                num1 = fee.OfficeID;
                string filterExpression = "OfficeID=" + num1.ToString();
                DataRow[] dataRowArray = invoices.Select(filterExpression);
                int index6 = 0;
                while (index6 < dataRowArray.Length)
                {
                  this.ds.InvoiceItems.AddInvoiceItemsRow((dsInstallmentBilling.InvoicesRow) dataRowArray[index6], "Fee", num7, fee.ChargeName, Decimal.Divide(num7, fee.Amount), fee.OptionFeeID);
                  checked { ++index6; }
                }
                continue;
              }
              continue;
            }
            continue;
          case 3675003649:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(appliesToPaymentId, "^", false) == 0)
              break;
            continue;
          default:
            continue;
        }
        int num8 = "23456@#$%^".IndexOf(fee.AppliesToPaymentID) % 5 + 2;
        if ("=+".Contains(fee.AppliesToPaymentID))
          num8 = 12;
        int num9 = "23456=".Contains(fee.AppliesToPaymentID) ? 0 : num8 - 1;
        dsInstallmentBilling.InvoicesDataTable invoices1 = this.ds.Invoices;
        num1 = fee.OfficeID;
        string filterExpression1 = "OfficeID=" + num1.ToString();
        DataRow[] dataRowArray1 = invoices1.Select(filterExpression1);
        if (num9 < dataRowArray1.Length)
        {
          int num10 = num9 == 0 ? 1 : 0;
          int num11 = num10 + (int) Math.Floor((double) (dataRowArray1.Length - num10) / (double) num8);
          Decimal num12 = Math.Round(Decimal.Divide(fee.Amount, new Decimal(num11)), 2);
          int num13 = num9;
          num1 = dataRowArray1.Length - 1;
          int num14 = num8;
          for (int index7 = num13; (num14 >> 31 /*0x1F*/ ^ index7) <= (num14 >> 31 /*0x1F*/ ^ num1); index7 += num14)
            this.ds.InvoiceItems.AddInvoiceItemsRow((dsInstallmentBilling.InvoicesRow) dataRowArray1[index7], "Fee", num12, fee.ChargeName, Decimal.Divide(num12, fee.Amount), fee.OptionFeeID);
        }
      }
    }
    finally
    {
      IEnumerator<dsInstallmentBilling.FeesRow> enumerator;
      enumerator?.Dispose();
    }
  }

  private void btnPaymentOptions_Click(object sender, EventArgs e)
  {
    if (this._dataUpdated && this.ShowMessage("Moving to the payment options will close this screen.\n\nAre you sure you want to close this form?", "Close Form?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation) != DialogResult.Yes)
      return;
    Cursor.Current = MgaCursors.WaitCursor;
    frmInstallmentBillingOptions.EnforceSingleFormInstance(this._quoteOptionID);
    frmInstallmentBillingOptions formEx = (frmInstallmentBillingOptions) ObjectFactory.Instance.CreateFormEX(typeof (frmInstallmentBillingOptions), new object[1]
    {
      (object) this._quoteOptionID
    });
    formEx.ConfiguratingPolicy = true;
    formEx.MdiParent = MDIControls.Instance.MDIParent;
    formEx.Show();
    this.Close();
    Cursor.Current = MgaCursors.Default;
  }

  internal static void EnforceSingleFormInstance(int quoteOptionID)
  {
    // ISSUE: variable of a compiler-generated type
    frmInstallmentBilling._Closure\u0024__219\u002D0 closure2190_1;
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    frmInstallmentBilling._Closure\u0024__219\u002D0 closure2190_2 = new frmInstallmentBilling._Closure\u0024__219\u002D0(closure2190_1);
    // ISSUE: reference to a compiler-generated field
    closure2190_2.\u0024VB\u0024Local_quoteOptionID = quoteOptionID;
    try
    {
      if (!BindingProcessSettings.EnforceFormSingleInstance)
        return;
      try
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated field
        foreach (Form form in MDIControls.Instance.MDIParent.MdiChildren.OfType<frmInstallmentBilling>().Where<frmInstallmentBilling>(closure2190_2.\u0024I0 == null ? (closure2190_2.\u0024I0 = new System.Func<frmInstallmentBilling, bool>(closure2190_2._Lambda\u0024__0)) : closure2190_2.\u0024I0))
          form.Close();
      }
      finally
      {
        IEnumerator<frmInstallmentBilling> enumerator;
        enumerator?.Dispose();
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ErrorHandler.SilentHandleError(ex);
      ProjectData.ClearProjectError();
    }
  }

  private void dgInstallments_AfterCellUpdate(object sender, CellEventArgs e)
  {
    this.dgInstallments.EventManager.SetEnabled((GridEventIds) 4, false);
    this._dataUpdated = true;
    if (((UltraGridBase) this.dgInstallments).ActiveRow != null && ((UltraGridBase) this.dgInstallments).ActiveRow.Band.Index == 2)
    {
      Decimal allocated = this.Allocated;
      Decimal premiumSum = this._premiumSum;
      Decimal feesSum = this._feesSum;
      ((ControlBase) this.lblAllocated).Text = allocated.ToString("c", (IFormatProvider) this._cultureInfo);
      ((ControlBase) this.lblRemaining).Text = Decimal.Subtract(Decimal.Add(premiumSum, feesSum), allocated).ToString("c", (IFormatProvider) this._cultureInfo);
      if (e.Cell.Row.Cells["OptionFeeID"].Value == DBNull.Value)
      {
        int key = (int) e.Cell.Row.ParentRow.Cells["OfficeID"].Value;
        e.Cell.Row.Cells["ModFactor"].Value = (object) Decimal.Divide(Conversions.ToDecimal(e.Cell.Row.Cells["Amount"].Value), this._totalPremium[key]);
      }
      else
      {
        int num = (int) e.Cell.Row.Cells["OptionFeeID"].Value;
        Decimal d1 = (Decimal) e.Cell.Row.Cells["Amount"].Value;
        Decimal d2 = DefaultDatabase.ExecuteScalar<Decimal>(CommandType.Text, "SELECT Amount FROM tblQuoteOptionCharges WHERE OptionFeeID=@ID", new object[2]
        {
          (object) "@ID",
          (object) num
        });
        e.Cell.Row.Cells["ModFactor"].Value = (object) Decimal.Divide(d1, d2);
      }
      this.AssignColor();
      this.AfterCellUpdateOnClient(RuntimeHelpers.GetObjectValue(sender), e);
    }
    this.dgInstallments.EventManager.SetEnabled((GridEventIds) 4, true);
  }

  protected virtual void AfterCellUpdateOnClient(object sender, CellEventArgs e)
  {
  }

  protected virtual bool IsValidUnderwritingPeriod(DateTime postDate)
  {
    bool flag1;
    if (this._isEndorsement)
    {
      flag1 = true;
    }
    else
    {
      bool flag2 = true;
      postDate = new DateTime(postDate.Year, postDate.Month, postDate.Day);
      flag1 = DefaultDatabase.ExecuteScalar<bool>(CommandType.Text, "SELECT dbo.IsUnderwritingPeriodValid_GlCompany(@d, @glCompanyId)", new object[4]
      {
        (object) "@d",
        (object) postDate,
        (object) "@glCompanyId",
        (object) this._glCompanyID
      }) && flag2;
    }
    return flag1;
  }

  protected virtual bool ReadyToBind()
  {
    double Expression = Math.Round(Conversions.ToDouble(this.ds.Offices.Compute("SUM(TotalPremium)", string.Empty)) + Convert.ToDouble(this._feesSum) - Convert.ToDouble(this.Allocated), 2);
    bool bind;
    if (Expression != 0.0)
    {
      int num = (int) this.ShowMessage("The full premium must be allocated 100% before binding.\n\nThere is currently " + Interaction.IIf(Expression < 0.0, (object) $"an extra {Strings.FormatCurrency((object) Math.Abs(Expression))} allocated.", (object) (Strings.FormatCurrency((object) Expression) + " remaining to be allocated.")).ToString(), "Premium Not Allocated", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      bind = false;
    }
    else
    {
      try
      {
        foreach (dsInstallmentBilling.InvoicesRow invoice in (TypedTableBase<dsInstallmentBilling.InvoicesRow>) this.ds.Invoices)
        {
          if (invoice.IsDateDueNull())
          {
            int num = (int) this.ShowMessage("Blank due dates detected.\n\nPlease ensure that all due dates have been properly filled in.", "Invalid Due Dates", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            bind = false;
            goto label_55;
          }
          if (DateTime.Compare(invoice.DateBilled, DateTime.MaxValue) > 0 || DateTime.Compare(invoice.DateBilled, Conversions.ToDate("1/1/1753 12:00:00 AM")) < 0)
          {
            int num = (int) this.ShowMessage(invoice.DateBilled.ToShortDateString() + " value falls outside the range of a valid date.\n\nPlease verify that all billing dates are valid.", "Invalid Date Billed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            bind = false;
            goto label_55;
          }
          if (DateTime.Compare(invoice.DateDue, DateTime.MaxValue) > 0 || DateTime.Compare(invoice.DateDue, Conversions.ToDate("1/1/1753 12:00:00 AM")) < 0)
          {
            int num = (int) this.ShowMessage(invoice.DateDue.ToShortDateString() + " value falls outside the range of a valid date.\n\nPlease verify that all due dates are valid.", "Invalid Date Due", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            bind = false;
            goto label_55;
          }
          if (!this.IsValidUnderwritingPeriod(invoice.DateBilled))
          {
            int num = (int) this.ShowMessage($"The current underwriting period is now closed.\n\nDate Billed of {invoice.DateBilled.ToShortDateString()} falls within a closed underwriting period.", "Cannot Bind - Underwriting Period Closed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            bind = false;
            goto label_55;
          }
        }
      }
      finally
      {
        IEnumerator<dsInstallmentBilling.InvoicesRow> enumerator;
        enumerator?.Dispose();
      }
      if (this._roundPremiums)
      {
        try
        {
          foreach (dsInstallmentBilling.InvoiceItemsRow invoiceItem in (TypedTableBase<dsInstallmentBilling.InvoiceItemsRow>) this.ds.InvoiceItems)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(invoiceItem.ItemType, "Premium", false) == 0 & !frmInstallmentBillingOptions.IsWholeNumber((object) invoiceItem.Amount))
            {
              int num = (int) this.ShowMessage($"All premiums must be whole numbers.\n\n{invoiceItem.Amount.ToString("c")} is not valid.", "Invalid Premium", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
              bind = false;
              goto label_55;
            }
          }
        }
        finally
        {
          IEnumerator<dsInstallmentBilling.InvoiceItemsRow> enumerator;
          enumerator?.Dispose();
        }
      }
      Dictionary<string, bool> dictionary1 = new Dictionary<string, bool>();
      if (CurrentUser.Instance.IsAccountingPackageActive)
      {
        try
        {
          foreach (dsInstallmentBilling.InvoicesRow invoice in (TypedTableBase<dsInstallmentBilling.InvoicesRow>) this.ds.Invoices)
          {
            DateTime dateTime = invoice.DateBilled;
            DateTime date1 = dateTime.Date;
            dateTime = CurrentUser.Instance.GetServerTime();
            DateTime date2 = dateTime.Date;
            if (DateTime.Compare(date1, date2) != 0)
            {
              Dictionary<string, bool> dictionary2 = dictionary1;
              dateTime = invoice.DateBilled;
              string shortDateString1 = dateTime.ToShortDateString();
              bool flag;
              if (dictionary2.ContainsKey(shortDateString1))
              {
                Dictionary<string, bool> dictionary3 = dictionary1;
                dateTime = invoice.DateBilled;
                string shortDateString2 = dateTime.ToShortDateString();
                flag = dictionary3[shortDateString2];
              }
              else
              {
                flag = DefaultDatabase.ExecuteScalar<bool>(CommandType.Text, "SELECT dbo.IsAccountingPeriodValid_GlCompany(@DateBilled, @GLCompanyID)", new object[4]
                {
                  (object) "@DateBilled",
                  (object) invoice.DateBilled,
                  (object) "@GLCompanyID",
                  (object) invoice.OfficeID
                });
                Dictionary<string, bool> dictionary4 = dictionary1;
                dateTime = invoice.DateBilled;
                string shortDateString3 = dateTime.ToShortDateString();
                int num = flag ? 1 : 0;
                dictionary4.Add(shortDateString3, num != 0);
              }
              if (!flag)
              {
                dateTime = invoice.DateBilled;
                int num = (int) this.ShowMessage(dateTime.ToShortDateString() + " falls within a closed accounting month.\n\nPlease verify that all billing dates are valid.", "Invalid Date Billed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                bind = false;
                goto label_55;
              }
            }
            else
            {
              dateTime = invoice.DateDue;
              DateTime date3 = dateTime.Date;
              dateTime = invoice.DateBilled;
              DateTime date4 = dateTime.Date;
              if (DateTime.Compare(date3, date4) < 0 && !this._allowDateDueLessThanDateBilled)
              {
                int num = (int) this.ShowMessage("The due date must not fall before the date billed.\n\nPlease verify that all billing dates are valid.", "Invalid Due Date", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                bind = false;
                goto label_55;
              }
            }
          }
        }
        finally
        {
          IEnumerator<dsInstallmentBilling.InvoicesRow> enumerator;
          enumerator?.Dispose();
        }
      }
      if (!SecurityManager.Instance.AssertPermission("{D1C49040-E310-4f9f-BBE0-B09B54369409}") && !this.ValidateBillingType())
      {
        int num = (int) this.ShowMessage("You do not have permission to bind when the policy billing type is different from that of the downpayment.", "Different Billing Types", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        bind = false;
      }
      else
      {
        bool flag1 = true;
        bool flag2 = SecurityManager.Instance.AssertPermission("{7E42AE34-FE32-4892-BECE-F565F4D02455}");
        List<string> values = new List<string>();
        try
        {
          foreach (dsInstallmentBilling.FeesRow fee in (TypedTableBase<dsInstallmentBilling.FeesRow>) this.ds.Fees)
          {
            Decimal num1 = Utility.IsNull<Decimal>(RuntimeHelpers.GetObjectValue(this.ds.InvoiceItems.Compute("SUM(Amount)", "OptionFeeID=" + fee.OptionFeeID.ToString())), 0M);
            if ((Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fee.AppliesToPaymentID, "A", false) == 0 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fee.AppliesToPaymentID, "B", false) == 0 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fee.AppliesToPaymentID, "G", false) == 0) && Decimal.Compare(num1, fee.Amount) != 0)
            {
              int num2 = (int) this.ShowMessage($"Penny distributions for the fees do not sum up to the correct amount for \"{fee.ChargeName}\".\n\nPlease ensure the invoices add up to {Strings.FormatCurrency((object) fee.Amount)} (currently {Strings.FormatCurrency((object) num1)}).", "Invalid Invoice Fee Breakout", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
              flag1 = false;
            }
            if (Decimal.Compare(num1, 0M) < 0)
            {
              Decimal d1 = Utility.IsNull<Decimal>(RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT SUM(qoc2.AmountWithInstallments) FROM dbo.tblQuoteOptionCharges qoc JOIN dbo.tblQuoteOptions qo ON qoc.QuoteOptionGuid = qo.QuoteOptionGUID JOIN dbo.tblQuotes q ON qo.QuoteGUID = q.QuoteGUID JOIN dbo.tblQuotes q2 ON q.ControlNo = q2.ControlNo AND q.QuoteGUID <> q2.QuoteGUID JOIN dbo.tblQuoteOptions qo2 ON q2.QuoteGUID = qo2.QuoteGUID JOIN dbo.tblQuoteOptionCharges qoc2 ON qo2.QuoteOptionGUID = qoc2.QuoteOptionGuid AND qoc2.ChargeCode = qoc.ChargeCode WHERE qoc.OptionFeeID = @optionFeeID AND qoc2.WaivedByUserGuid IS NULL", new object[2]
              {
                (object) "@optionFeeID",
                (object) fee.OptionFeeID
              })), 0M);
              if (Decimal.Compare(Decimal.Add(d1, num1), 0M) < 0)
              {
                if (flag2)
                {
                  values.Add($"{fee.ChargeName}:  {Math.Abs(num1):c} (previously billed {d1:c})");
                }
                else
                {
                  int num3 = (int) this.ShowMessage(string.Format("Attempting to credit {0:c} for {1}, which is {2:c} more than what was billed.{3}{3}Please ensure the fee is not credited for more than {4:c}.", (object) Math.Abs(num1), (object) fee.ChargeName, (object) Math.Abs(Decimal.Add(d1, num1)), (object) "\n", (object) d1), "Invalid Invoice Fee Credit", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                  flag1 = false;
                }
              }
            }
          }
        }
        finally
        {
          IEnumerator<dsInstallmentBilling.FeesRow> enumerator;
          enumerator?.Dispose();
        }
        if (values.Count > 0 && this.ShowMessage(string.Format("The following fee(s) are being credited for more than was previously billed: {0}{1}{0}Would you like to continue anyway?", (object) "\n", (object) string.Join("\n", (IEnumerable<string>) values)), "Invalid Invoice Fee Credit", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
          flag1 = false;
        bind = flag1;
      }
    }
label_55:
    return bind;
  }

  protected virtual bool ValidateBillingType()
  {
    string str = DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "SELECT B.BillingType FROM tblQuotes AS Q  WITH (NOLOCK) INNER JOIN lstBillingTypes AS B ON Q.BillingTypeID = B.BillingTypeID WHERE (Q.QuoteID = @QI)", new object[2]
    {
      (object) "@QI",
      (object) this._quote.QuoteID
    });
    bool flag;
    try
    {
      foreach (dsInstallmentBilling.InvoicesRow invoice in (TypedTableBase<dsInstallmentBilling.InvoicesRow>) this.ds.Invoices)
      {
        if (invoice.IsDownpayment && !invoice.BillingType.Equals(str))
        {
          flag = false;
          goto label_9;
        }
      }
    }
    finally
    {
      IEnumerator<dsInstallmentBilling.InvoicesRow> enumerator;
      enumerator?.Dispose();
    }
    flag = true;
label_9:
    return flag;
  }

  private void btnBind_Click(object sender, EventArgs e)
  {
    if (!((Control) this.btnBind).Enabled)
      return;
    this.Bind();
  }

  internal void Bind()
  {
    MGASystems.IMS.Policies.Invoices.Invoices invs = new MGASystems.IMS.Policies.Invoices.Invoices();
    if (!this.ReadyToBind())
      return;
    try
    {
      foreach (dsInstallmentBilling.InvoicesRow invoice1 in (TypedTableBase<dsInstallmentBilling.InvoicesRow>) this.ds.Invoices)
      {
        AccountingTransferInvoice invoice2 = this.CreateInvoice(invoice1);
        invs.AddInvoice(invoice2);
      }
    }
    finally
    {
      IEnumerator<dsInstallmentBilling.InvoicesRow> enumerator;
      enumerator?.Dispose();
    }
    if (this._quote.IsBound)
    {
      int num = (int) this.ShowMessage("This policy is currently bound.\n\nIt is possible another user has bound the policy while you were working with it.", "Policy Bound", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else
    {
      this.LogChanges();
      bool flag = this.BlackBoxMode && SystemSettings.KeyExists("SupportBlackboxEndorsementBinding") && SystemSettings.GetBoolSetting("SupportBlackboxEndorsementBinding");
      if (this._isEndorsement && !flag)
      {
        if (this.BlackBoxMode)
          throw new InvalidOperationException("Black box mode does not support endorsements");
        using (frmEndorsementInfo frmEndorsementInfo = (frmEndorsementInfo) FormSettings.ShowFormDialog(typeof (frmEndorsementInfo), new object[1]
        {
          (object) this._quote.QuoteID
        }))
        {
          if (!frmEndorsementInfo.Saved)
            return;
          this.ShowBindPolicyForm(invs);
        }
      }
      else if (this.BlackBoxMode)
      {
        using (frmBindPolicy formEx = (frmBindPolicy) ObjectFactory.Instance.CreateFormEX(typeof (frmBindPolicy), new object[3]
        {
          (object) this._quote.QuoteGuid,
          (object) invs,
          (object) true
        }))
          formEx.BindPolicy();
      }
      else
        this.ShowBindPolicyForm(invs);
    }
  }

  private void ShowBindPolicyForm(MGASystems.IMS.Policies.Invoices.Invoices invs)
  {
    this.Cursor = MgaCursors.WaitCursor;
    ((Control) this.btnBind).Enabled = false;
    frmBindPolicy formEx = (frmBindPolicy) ObjectFactory.Instance.CreateFormEX(typeof (frmBindPolicy), new object[2]
    {
      (object) this._quote.QuoteGuid,
      (object) invs
    });
    Cursor.Current = MgaCursors.WaitCursor;
    frmBindPolicy.BindPolicyFormLoadCompleteEventHandler completeEventHandler = new frmBindPolicy.BindPolicyFormLoadCompleteEventHandler(this.BindPolicyFormLoadComplete);
    formEx.BindPolicyFormLoadComplete += completeEventHandler;
  }

  private void BindPolicyFormLoadComplete(object sender, EventArgs e)
  {
    frmBindPolicy frmBindPolicy = (frmBindPolicy) sender;
    frmBindPolicy.BindPolicyFormLoadComplete -= new frmBindPolicy.BindPolicyFormLoadCompleteEventHandler(this.BindPolicyFormLoadComplete);
    this.Close();
    frmBindPolicy.EnforceSingleFormInstance(this.Quote.QuoteID);
    frmBindPolicy.MdiParent = MDIControls.Instance.MDIParent;
    frmBindPolicy.Visible = true;
    Cursor.Current = MgaCursors.Default;
  }

  private void LogChanges()
  {
    try
    {
      foreach (dsInstallmentBilling.InvoicesRow row in this.ds.Invoices.Rows)
      {
        if (this._dateDue.ContainsKey(row.InvoiceNum))
        {
          DateTime t1 = this._dateDue[row.InvoiceNum];
          if (DateTime.Compare(t1, row.DateDue) != 0)
            CurrentUser.Instance.LogAction($"Changed invoice date due from {Interaction.IIf(t1.Equals(DateTime.MinValue), (object) "null", (object) t1.ToShortDateString()).ToString()} to {row.DateDue.ToShortDateString()}.", this.Quote.QuoteGuid);
        }
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
      foreach (dsInstallmentBilling.InvoicesRow row in this.ds.Invoices.Rows)
      {
        if (this._dateBilling.ContainsKey(row.InvoiceNum))
        {
          DateTime t1 = this._dateBilling[row.InvoiceNum];
          if (DateTime.Compare(t1, row.DateBilled) != 0)
            CurrentUser.Instance.LogAction($"Changed invoice date billed from {t1.ToShortDateString()} to {Conversions.ToString(row.DateBilled)}", this.Quote.QuoteGuid);
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

  protected virtual AccountingTransferInvoice CreateInvoice(
    dsInstallmentBilling.InvoicesRow drInvoice)
  {
    dsInstallmentBilling.InvoiceItemsRow invoiceItemsRow = (dsInstallmentBilling.InvoiceItemsRow) this.ds.InvoiceItems.Select("OptionFeeID IS NULL AND InvoiceNum=" + drInvoice.InvoiceNum.ToString())[0];
    AccountingTransferInvoice i = new AccountingTransferInvoice();
    AccountingTransferInvoice accountingTransferInvoice = i;
    accountingTransferInvoice.DueDate = drInvoice.DateDue;
    accountingTransferInvoice.DateBilled = drInvoice.DateBilled;
    accountingTransferInvoice.InvoiceNumber = drInvoice.InvoiceNum;
    accountingTransferInvoice.PremiumModFactor = invoiceItemsRow.ModFactor;
    accountingTransferInvoice.Amount = invoiceItemsRow.Amount;
    accountingTransferInvoice.OfficeID = drInvoice.OfficeID;
    if (this.ds.tblQuoteAdditionalInterests.Count > 0)
      accountingTransferInvoice.BillToAdditionalInterestID = drInvoice.AdditionalInterestID;
    if (!drInvoice.IsCommentNull())
      i.Comment = drInvoice.Comment;
    if (this._officeDownPayment[drInvoice.OfficeID] && drInvoice.IsDownpayment)
    {
      if (this.ds.tblInstallmentBilling[0].IsDownpaymentBillingTypeIDNull())
      {
        int num = (int) this.ShowMessage("A downpayment amount has been entered, but no downpayment billing type was selected.", "Invalid Downpayment", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
      else
      {
        i.DownpaymentInvoice = true;
        i.BillingTypeID = this.ds.tblInstallmentBilling[0].DownpaymentBillingTypeID;
      }
    }
    else
    {
      if (!drInvoice.IsModifiesInvoiceNumNull())
        i.ModifiesInvoiceNum = drInvoice.ModifiesInvoiceNum;
      i.BillingTypeID = this.GetBillingTypeID();
    }
    this.AddInvoiceFees(i);
    return i;
  }

  private bool IsFirstInvoiceForOffice(int officeID, int invoiceNum)
  {
    return Conversions.ToInteger(this.ds.Invoices.Compute("MIN(InvoiceNum)", "OfficeID=" + officeID.ToString())) == invoiceNum;
  }

  private void AddInvoiceFees(AccountingTransferInvoice i)
  {
    DataRow[] dataRowArray = this.ds.InvoiceItems.Select($"InvoiceNum={i.InvoiceNumber.ToString()} AND OptionFeeID IS NOT NULL");
    int index = 0;
    while (index < dataRowArray.Length)
    {
      dsInstallmentBilling.InvoiceItemsRow invoiceItemsRow = (dsInstallmentBilling.InvoiceItemsRow) dataRowArray[index];
      i.AddFee(new Fee(invoiceItemsRow.OptionFeeID, invoiceItemsRow.ModFactor, invoiceItemsRow.Amount));
      checked { ++index; }
    }
  }

  private void btnSplit_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((ControlBase) this.btnSplit).Text, "Unsplit Invoice", false) == 0)
      this.UnsplitInvoices();
    else
      this.SplitInvoices();
    this.CalculateFeeSum();
    ((ControlBase) this.lblTotalFees).Text = this._feesSum.ToString("c", (IFormatProvider) this._cultureInfo);
    ((ControlBase) this.lblAllocated).Text = this.Allocated.ToString("c", (IFormatProvider) this._cultureInfo);
    this.AssignColor();
  }

  private void SplitInvoices()
  {
    if (Conversions.ToInteger(this.ds.Invoices.Compute("COUNT(InvoiceNum)", "IsDownpayment=0")) > 1)
    {
      int num1 = (int) this.ShowMessage("You can not split invoices when more than one non-downpayment invoice exists.", "Unable to Split Invoices", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else
    {
      using (SelectUnissuedInvoicesForm formEx = (SelectUnissuedInvoicesForm) ObjectFactory.Instance.CreateFormEX(typeof (SelectUnissuedInvoicesForm), new object[1]
      {
        (object) this._quote
      }))
      {
        int num2 = (int) formEx.ShowDialog();
        this._selectedInvoices = formEx.SelectInvoiceNumbers;
      }
      if (this._selectedInvoices.Count <= 0)
        return;
      this._splitAcross = true;
      this.PopulateScreen();
      try
      {
        foreach (dsInstallmentBilling.InvoicesRow invoice in (TypedTableBase<dsInstallmentBilling.InvoicesRow>) this.ds.Invoices)
          this.PrepareSplitInvoice(invoice, this._officeDownPayment[invoice.OfficeID]);
      }
      finally
      {
        IEnumerator<dsInstallmentBilling.InvoicesRow> enumerator;
        enumerator?.Dispose();
      }
      ((ControlBase) this.btnSplit).Text = "Unsplit Invoice";
    }
  }

  protected virtual List<InstallmentInvoiceItem> ClientSplitInvoices()
  {
    return (List<InstallmentInvoiceItem>) null;
  }

  protected virtual void PrepareSplitInvoice(
    dsInstallmentBilling.InvoicesRow drInvoice,
    bool hasDownPayment)
  {
    if (drInvoice.InvoiceNum > this._selectedInvoices.Count)
      return;
    drInvoice.ModifiesInvoiceNum = this._selectedInvoices[drInvoice.InvoiceNum - 1].InvoiceNum.Value;
    drInvoice.DateDue = this._selectedInvoices[drInvoice.InvoiceNum - 1].DueDate;
  }

  private void UnsplitInvoices()
  {
    this._splitAcross = false;
    this.PopulateScreen();
    ((ControlBase) this.btnSplit).Text = "Split Across Unissued Invoices";
  }

  private DateTime DeferWeekendInvoices(DateTime currDate)
  {
    if (this._setWeekendInvoiceDueDatesToMonday)
    {
      if (currDate.DayOfWeek == DayOfWeek.Saturday)
        currDate = currDate.AddDays(2.0);
      else if (currDate.DayOfWeek == DayOfWeek.Sunday)
        currDate = currDate.AddDays(1.0);
    }
    return currDate;
  }

  public void OnMessageReceived(Guid eventGuid, object context)
  {
    if (context == null)
      throw new ArgumentNullException(nameof (context));
    if (!eventGuid.Equals(BroadcastMessages.PolicyBound) && !eventGuid.Equals(BroadcastMessages.EndorsementBound) || !context.Equals((object) this._quote.QuoteGuid))
      return;
    this.Close();
  }

  public bool HasAlreadyProcessTerms { get; set; }

  public bool HasDownPaymentInstallment { get; set; }

  public DataRow TransactionDataRow { get; set; }

  public bool UseMonthIncrement { get; set; }

  public bool HasTransactionSetup { get; set; }

  public bool MonthFollowing(DataRow dr)
  {
    bool flag1 = false;
    if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(dr["DayOfMonth"])))
      flag1 = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dr["DayOfMonth"]));
    bool flag2;
    if (flag1 && !Utility.IsNull(RuntimeHelpers.GetObjectValue(dr["MonthFollowingDownPayment"])) && Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dr["MonthFollowingDownPayment"])))
    {
      flag2 = true;
    }
    else
    {
      bool flag3 = false;
      if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(dr["PolicyExpiration"])))
        flag3 = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dr["PolicyExpiration"]));
      if (flag3 && !Utility.IsNull(RuntimeHelpers.GetObjectValue(dr["MonthFollowingDownPayment_Exp"])) && Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dr["MonthFollowingDownPayment_Exp"])))
      {
        flag2 = true;
      }
      else
      {
        bool flag4 = false;
        if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(dr["PolicyEffective"])))
          flag4 = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dr["PolicyEffective"]));
        if (flag4 && !Utility.IsNull(RuntimeHelpers.GetObjectValue(dr["MonthFollowingDownPayment_Eff"])) && Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dr["MonthFollowingDownPayment_Eff"])))
        {
          flag2 = true;
        }
        else
        {
          bool flag5 = false;
          if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(dr["EffectiveDateBilled"])))
            flag5 = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dr["EffectiveDateBilled"]));
          flag2 = flag5 && !Utility.IsNull(RuntimeHelpers.GetObjectValue(dr["MonthFollowingDownPayment_Eff_DateBilled"])) && Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dr["MonthFollowingDownPayment_Eff_DateBilled"]));
        }
      }
    }
    return flag2;
  }

  public DateTime GetTransactionDate(
    UltraGridRow row,
    int quoteOptionID,
    ref int paymentTerm,
    ref DateTime transDate)
  {
    DateTime transactionDate;
    if (Convert.ToBoolean(RuntimeHelpers.GetObjectValue(row.Cells["IsDownpayment"].Value)))
    {
      this.HasDownPaymentInstallment = true;
      DataRow dataRow = DefaultDatabase.ExecuteDataRow("GetCompanyInstallmentTransactionDate", new object[4]
      {
        (object) "@DownpaymentInvoice",
        (object) true,
        (object) "@QuoteOptionID",
        (object) this._quoteOptionID
      });
      paymentTerm = Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataRow[1]));
      transDate = Convert.ToDateTime(RuntimeHelpers.GetObjectValue(dataRow[0]));
      transactionDate = transDate;
    }
    else if (this.HasDownPaymentInstallment && !Utility.IsNull(RuntimeHelpers.GetObjectValue(this.TransactionDataRow["DateBilledEqualToDueDate"])) && Convert.ToBoolean(RuntimeHelpers.GetObjectValue(this.TransactionDataRow["DateBilledEqualToDueDate"])))
    {
      DateTime dateTime = Convert.ToDateTime(RuntimeHelpers.GetObjectValue(row.Cells["DateDue"].Value));
      if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(this.TransactionDataRow["BillingDateDaysFromDueDate"])))
        dateTime = this.UseMonthIncrement ? dateTime.AddMonths(Convert.ToInt32(RuntimeHelpers.GetObjectValue(this.TransactionDataRow["BillingDateDaysFromDueDate"])) * -1) : dateTime.AddDays((double) (Convert.ToInt32(RuntimeHelpers.GetObjectValue(this.TransactionDataRow["BillingDateDaysFromDueDate"])) * -1));
      if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(this.TransactionDataRow["UseEffectiveDateForBilling"])) && Convert.ToBoolean(RuntimeHelpers.GetObjectValue(this.TransactionDataRow["UseEffectiveDateForBilling"])))
        dateTime = this._quote.EffectiveDate.Day > DateTime.DaysInMonth(dateTime.Year, dateTime.Month) ? new DateTime(dateTime.Year, dateTime.Month, DateTime.DaysInMonth(dateTime.Year, dateTime.Month)) : new DateTime(dateTime.Year, dateTime.Month, this._quote.EffectiveDate.Day);
      transactionDate = dateTime;
    }
    else if (!this.HasAlreadyProcessTerms)
    {
      DateTime dateTime = transDate;
      bool flag1 = false;
      bool flag2 = false;
      DataRow dataRow1 = DefaultDatabase.ExecuteDataRow("GetCompanyInstallmentTransactionDate", new object[4]
      {
        (object) "@DownpaymentInvoice",
        (object) false,
        (object) "@QuoteOptionID",
        (object) this._quoteOptionID
      });
      paymentTerm = Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataRow1[1]));
      transDate = Convert.ToDateTime(RuntimeHelpers.GetObjectValue(dataRow1[0]));
      if (this.MonthFollowing(this.TransactionDataRow) && this.HasDownPaymentInstallment)
      {
        flag1 = true;
        flag2 = !Utility.IsNull(RuntimeHelpers.GetObjectValue(this.TransactionDataRow["UseMonthForAltFirstInstallment"])) && Convert.ToBoolean(RuntimeHelpers.GetObjectValue(this.TransactionDataRow["UseMonthForAltFirstInstallment"]));
        if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(this.TransactionDataRow["DayOfMonth"])) && Convert.ToBoolean(RuntimeHelpers.GetObjectValue(this.TransactionDataRow["DayOfMonth"])) && !Utility.IsNull(RuntimeHelpers.GetObjectValue(this.TransactionDataRow["MonthFollowingDownPayment"])) && Convert.ToBoolean(RuntimeHelpers.GetObjectValue(this.TransactionDataRow["MonthFollowingDownPayment"])) && !Utility.IsNull(RuntimeHelpers.GetObjectValue(this.TransactionDataRow["DayOfMonthAltFirstInstallDays"])))
          paymentTerm = Conversions.ToInteger(this.TransactionDataRow["DayOfMonthAltFirstInstallDays"]);
        if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(this.TransactionDataRow["PolicyExpiration"])) && Convert.ToBoolean(RuntimeHelpers.GetObjectValue(this.TransactionDataRow["PolicyExpiration"])) && !Utility.IsNull(RuntimeHelpers.GetObjectValue(this.TransactionDataRow["MonthFollowingDownPayment_Exp"])) && Convert.ToBoolean(RuntimeHelpers.GetObjectValue(this.TransactionDataRow["MonthFollowingDownPayment_Exp"])) && !Utility.IsNull(RuntimeHelpers.GetObjectValue(this.TransactionDataRow["ExpirationAltFirstInstallDays"])))
          paymentTerm = Conversions.ToInteger(this.TransactionDataRow["ExpirationAltFirstInstallDays"]);
        if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(this.TransactionDataRow["PolicyEffective"])) && Convert.ToBoolean(RuntimeHelpers.GetObjectValue(this.TransactionDataRow["PolicyEffective"])) && !Utility.IsNull(RuntimeHelpers.GetObjectValue(this.TransactionDataRow["MonthFollowingDownPayment_Eff"])) && Convert.ToBoolean(RuntimeHelpers.GetObjectValue(this.TransactionDataRow["MonthFollowingDownPayment_Eff"])) && !Utility.IsNull(RuntimeHelpers.GetObjectValue(this.TransactionDataRow["EffectiveAltFirstInstallDays"])))
          paymentTerm = Conversions.ToInteger(this.TransactionDataRow["EffectiveAltFirstInstallDays"]);
        if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(this.TransactionDataRow["EffectiveDateBilled"])) && Convert.ToBoolean(RuntimeHelpers.GetObjectValue(this.TransactionDataRow["EffectiveDateBilled"])) && !Utility.IsNull(RuntimeHelpers.GetObjectValue(this.TransactionDataRow["MonthFollowingDownPayment_Eff_DateBilled"])) && Convert.ToBoolean(RuntimeHelpers.GetObjectValue(this.TransactionDataRow["MonthFollowingDownPayment_Eff_DateBilled"])) && !Utility.IsNull(RuntimeHelpers.GetObjectValue(this.TransactionDataRow["EffDateBilledAltFirstInstallDays"])))
          paymentTerm = Conversions.ToInteger(this.TransactionDataRow["EffDateBilledAltFirstInstallDays"]);
      }
      if (flag1)
        transDate = flag2 ? dateTime.AddMonths(paymentTerm) : dateTime.AddDays((double) paymentTerm);
      DataRow dataRow2 = DefaultDatabase.ExecuteDataRow("GetCompanyInstallmentTransactionDate", new object[4]
      {
        (object) "@DownpaymentInvoice",
        (object) false,
        (object) "@QuoteOptionID",
        (object) this._quoteOptionID
      });
      paymentTerm = Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataRow2[1]));
      this.HasAlreadyProcessTerms = true;
      transactionDate = transDate;
    }
    else
    {
      transDate = this.UseMonthIncrement ? transDate.AddMonths(paymentTerm) : transDate.AddDays((double) paymentTerm);
      transactionDate = transDate;
    }
    return transactionDate;
  }

  public DataRow InitializeTransactionDate(int quoteOptionID)
  {
    if (this.TransactionDataRow == null)
      this.TransactionDataRow = DefaultDatabase.ExecuteDataRow(CommandType.Text, "Select UseMonth as UseMonth, C.ID as ID, C.DayOfMonthAltFirstInstallDays as DayOfMonthAltFirstInstallDays, C.UseMonthForAltFirstInstallment as UseMonthForAltFirstInstallment, C.MonthFollowingDownPayment as MonthFollowingDownPayment, C.DayOfMonth as DayOfMonth, C.PolicyExpiration AS PolicyExpiration, C.PolicyEffective as PolicyEffective, C.EffectiveDateBilled as EffectiveDateBilled, C.MonthFollowingDownPayment_Exp AS MonthFollowingDownPayment_Exp,   C.MonthFollowingDownPayment_Eff_DateBilled AS MonthFollowingDownPayment_Eff_DateBilled, C.MonthFollowingDownPayment_Eff as MonthFollowingDownPayment_Eff, C.DateBilledEqualToDueDate, C.UseEffectiveDateForBilling, C.BillingDateDaysFromDueDate, C.EffDateBilledAltFirstInstallDays from tblCompanyLineInstallmentsTransDate C with (nolock) INNER JOIN tblQuoteOptions O WITH (NOLOCK) ON O.CompanyInstallmentID=C.InstallmentID WHERE O.QuoteOptionID = @quoteOptionID", new object[2]
      {
        (object) "@quoteOptionID",
        (object) this._quoteOptionID
      });
    this.HasTransactionSetup = !Utility.IsNull(RuntimeHelpers.GetObjectValue(this.TransactionDataRow["ID"]));
    if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(this.TransactionDataRow["UseMonth"])))
      this.UseMonthIncrement = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(this.TransactionDataRow["UseMonth"]));
    return this.TransactionDataRow;
  }

  private string GetCurrencyAmount(string moneyAmount)
  {
    string currencyAmount = "";
    char[] source = new char[3]{ '.', '-', ',' };
    string str = moneyAmount;
    int index = 0;
    while (index < str.Length)
    {
      char Expression = str[index];
      if (((IEnumerable<char>) source).Contains<char>(Expression))
        currencyAmount += Expression.ToString();
      else if (Versioned.IsNumeric((object) Expression))
        currencyAmount += Expression.ToString();
      checked { ++index; }
    }
    return currencyAmount;
  }

  private DateTime GetPaymentTermDateDue(DateTime currDate, string producerPaymentMeasuredFrom)
  {
    string str = producerPaymentMeasuredFrom;
    DateTime paymentTermDateDue;
    // ISSUE: reference to a compiler-generated method
    switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(str))
    {
      case 3222007936:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "E", false) == 0)
        {
          paymentTermDateDue = !this._isEndorsement ? this.Quote.EffectiveDate.AddDays((double) this._paymentTerms) : this.Quote.EndorsementEffective.AddDays((double) this._paymentTerms);
          break;
        }
        break;
      case 3238785555:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "D", false) == 0)
        {
          int day;
          if (this._isEndorsement)
            day = (int) DefaultDatabase.ExecuteScalar<byte>(CommandType.Text, "SELECT ProducerPaymentDayOfMonth_Endorsement FROM tblCompanyLineTermsOfPayment WHERE CompanyLineID=@ID", new object[2]
            {
              (object) "@ID",
              (object) this._quote.CompanyLine.CompanyLineID
            });
          else
            day = (int) DefaultDatabase.ExecuteScalar<byte>(CommandType.Text, "SELECT ProducerPaymentDayOfMonth FROM tblCompanyLineTermsOfPayment WHERE CompanyLineID=@ID", new object[2]
            {
              (object) "@ID",
              (object) this._quote.CompanyLine.CompanyLineID
            });
          paymentTermDateDue = new DateTime(currDate.Year, currDate.Month, day).AddDays((double) this._paymentTerms);
          break;
        }
        break;
      case 3255563174:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "G", false) == 0)
        {
          int num = this._paymentTerms;
          if (num == 0)
            num = 1;
          if (!SystemSettings.KeyExists("Ignore_GAAP_End_Of_Month_InstallmentBilling") || !SystemSettings.GetBoolSetting("Ignore_GAAP_End_Of_Month_InstallmentBilling"))
          {
            DateTime dateTime1;
            DateTime dateTime2;
            if (DateTime.Compare(this.Quote.EffectiveDate, currDate) > 0)
            {
              dateTime1 = this.Quote.EffectiveDate;
              dateTime2 = dateTime1.AddMonths(1);
            }
            else
              dateTime2 = currDate.AddMonths(1);
            dateTime1 = new DateTime(dateTime2.Year, dateTime2.Month, 1);
            paymentTermDateDue = dateTime1.AddDays((double) (num - 1));
            break;
          }
          paymentTermDateDue = (DateTime.Compare(this.Quote.EffectiveDate, currDate) <= 0 ? currDate : this.Quote.EffectiveDate).AddDays((double) num);
          break;
        }
        break;
      case 3339451269:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "B", false) == 0)
        {
          paymentTermDateDue = currDate.AddDays((double) this._paymentTerms);
          break;
        }
        break;
      case 3356228888:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "M", false) == 0)
        {
          int num1 = DateTime.DaysInMonth(currDate.Year, currDate.Month);
          DateTime dateTime = currDate.AddDays((double) (num1 - currDate.Day));
          if (this._includeEndorsementsForGAAP && this._isEndorsement)
          {
            DateTime t2 = this.Quote.EndorsementEffective;
            if (DateTime.Compare(currDate, t2) > 0)
              t2 = currDate;
            int num2 = DateTime.DaysInMonth(t2.Year, t2.Month);
            dateTime = t2.AddDays((double) (num2 - t2.Day));
          }
          paymentTermDateDue = dateTime.AddDays((double) this._paymentTerms);
          break;
        }
        break;
      case 3389784126:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "O", false) == 0)
        {
          paymentTermDateDue = !this._isEndorsement ? (DateTime.Compare(currDate, this.Quote.EffectiveDate) >= 0 ? currDate.AddDays((double) this._paymentTerms) : this.Quote.EffectiveDate.AddDays((double) this._paymentTerms)) : (DateTime.Compare(currDate, this.Quote.EndorsementEffective) >= 0 ? currDate.AddDays((double) this._paymentTerms) : this.Quote.EndorsementEffective.AddDays((double) this._paymentTerms));
          break;
        }
        break;
      case 3406561745:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "N", false) == 0)
        {
          DateTime dateTime = !this._isEndorsement ? this.Quote.EffectiveDate : this.Quote.EndorsementEffective;
          int num = DateTime.DaysInMonth(dateTime.Year, dateTime.Month);
          paymentTermDateDue = dateTime.AddDays((double) (num - dateTime.Day)).AddDays((double) this._paymentTerms);
          break;
        }
        break;
      case 3557560316:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Q", false) == 0)
        {
          DateTime dateTime = !this._isEndorsement ? this.Quote.EffectiveDate : this.Quote.EndorsementEffective;
          int num = DateTime.DaysInMonth(dateTime.Year, dateTime.Month);
          DateTime t1 = dateTime.AddDays((double) (num - dateTime.Day));
          paymentTermDateDue = DateTime.Compare(t1, currDate) <= 0 ? currDate.AddDays((double) this._paymentTerms) : t1.AddDays((double) this._paymentTerms);
          break;
        }
        break;
    }
    return paymentTermDateDue;
  }

  private delegate void DisableSplitButtonHandler(object sender, EventArgs e);

  private delegate void SetupSplitButtonHandler(object sender, TaggedEventArgs e);

  private delegate void ThrowUIThreadExceptionHandler(object sender, TaggedEventArgs e);

  public delegate DialogResult ShowMessageHandler(
    string message,
    string caption,
    MessageBoxButtons buttons,
    MessageBoxIcon icon);

  private delegate void LoadCompleteHandler(object sender, EventArgs e);
}
