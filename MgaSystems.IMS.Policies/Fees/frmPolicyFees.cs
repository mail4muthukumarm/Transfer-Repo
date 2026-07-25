// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Fees.frmPolicyFees
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Common.ErrorHandling;
using MGASystems.Common.Extensions;
using MGASystems.Common.Functions;
using MGASystems.Data;
using MGASystems.IMS.Policies.PolicyDetail;
using MGASystems.IMS.Security;
using MGASystems.Tools;
using MGASystems.Tools.DBSaveUI;
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
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies.Fees;

[SecureResource("{22EF7D7A-3E7D-4dd1-B489-EA29D8B3B1F9}", "Reinstate Fees", "Allows the user to reinstate a waived fee.", "Fees")]
[SecureResource("{89510A95-E84D-415f-9AAA-A64DD6C03532}", "Waive Fees", "Allows the user to waive fees on a policy.", "Fees")]
[SecureResource("{A55A17AA-E531-40F0-AB46-6A82B9799508}", "Override Fee Payees", "Allow user to override the payee for a fee.", "Fees")]
[SecureResource("{7E42AE34-FE32-4892-BECE-F565F4D02455}", "Credit New Fees", "Allow user to credit fees that weren't previously billed.", "Fees")]
public class frmPolicyFees : Form
{
  private IContainer components;
  private Label Label3;
  private Label Label4;
  private MGATextBox txtAmount;
  private SqlDataAdapter daOptionFees;
  private ErrorProvider err;
  private dsPolicyFees ds;
  private Label Label6;
  private MGAGroupBox panelControls;
  private SqlCommand SqlSelectCommand1;
  private Label Label7;
  private UltraLabel lblFeeType;
  private UltraDropDown ddOffices;
  private Label Label9;
  private MGASimpleComboBox cboPercentOf;
  private UltraDropDown ddChargeCodes;
  private DataView dvChargeCodes;
  private Label Label8;
  private MGATextBox txtMinimum;
  private UltraLabel lblWaivedBy;
  private SqlCommand SqlSelectCommand2;
  private SqlCommand SqlInsertCommand1;
  private SqlCommand SqlUpdateCommand1;
  private SqlCommand SqlDeleteCommand1;
  private PictureBox PictureBox1;
  private Label Label1;
  private MGAComboBox cboFees;
  private BindingSource TblCompanyPolicyChargesBindingSource;
  private UltraGroupBox panelPleaseWait;
  internal const string CanReinstateFees = "{22EF7D7A-3E7D-4dd1-B489-EA29D8B3B1F9}";
  internal const string CanWaiveFees = "{89510A95-E84D-415f-9AAA-A64DD6C03532}";
  internal const string CanOverridePayee = "{A55A17AA-E531-40F0-AB46-6A82B9799508}";
  internal const string CanCreditNewFees = "{7E42AE34-FE32-4892-BECE-F565F4D02455}";
  private readonly Guid _quoteOptionGuid;
  private bool _convertingAutoFeeToManualFee;
  private bool _editing;
  protected Quote _quote;
  private MemoryStream _gridLayout;
  private bool _feeVerified;
  protected bool _canWaiveFee;
  private bool _canReinstateFee;
  private bool _canOverridePayee;
  private bool _canCreditNewFees;
  private Guid _quoteGuid;
  private List<int> _restrictFeeList;
  protected bool waiveFeeOrTax;
  private SqlConnection _cn;
  private bool handled;
  private bool rerunSave;
  private bool _skipSave;

  private virtual RadioButton rbFlat
  {
    get => this._rbFlat;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.FeeTypeChanged);
      RadioButton rbFlat1 = this._rbFlat;
      if (rbFlat1 != null)
        rbFlat1.CheckedChanged -= eventHandler;
      this._rbFlat = value;
      RadioButton rbFlat2 = this._rbFlat;
      if (rbFlat2 == null)
        return;
      rbFlat2.CheckedChanged += eventHandler;
    }
  }

  private virtual MGASystems.Tools.DBSaveUI.DBSaveUI dbSave
  {
    get => this._dbSave;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      CancelEventHandler cancelEventHandler1 = new CancelEventHandler(this.dbSave_ClickingEdit);
      EventHandler eventHandler1 = new EventHandler(this.dbSave_ClickedCancel);
      EventHandler eventHandler2 = new EventHandler(this.dbSave_UIStateChanged);
      EventHandler eventHandler3 = new EventHandler(this.dbSave_ClickedNew);
      CancelEventHandler cancelEventHandler2 = new CancelEventHandler(this.dbSave_ClickingDelete);
      CancelEventHandler cancelEventHandler3 = new CancelEventHandler(this.dbSave_ClickingSave);
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave1 = this._dbSave;
      if (dbSave1 != null)
      {
        dbSave1.ClickingEdit -= cancelEventHandler1;
        dbSave1.ClickedCancel -= eventHandler1;
        dbSave1.UIStateChanged -= eventHandler2;
        dbSave1.ClickedNew -= eventHandler3;
        dbSave1.ClickingDelete -= cancelEventHandler2;
        dbSave1.ClickingSave -= cancelEventHandler3;
      }
      this._dbSave = value;
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave2 = this._dbSave;
      if (dbSave2 == null)
        return;
      dbSave2.ClickingEdit += cancelEventHandler1;
      dbSave2.ClickedCancel += eventHandler1;
      dbSave2.UIStateChanged += eventHandler2;
      dbSave2.ClickedNew += eventHandler3;
      dbSave2.ClickingDelete += cancelEventHandler2;
      dbSave2.ClickingSave += cancelEventHandler3;
    }
  }

  private virtual RadioButton rbPercentagePremium
  {
    get => this._rbPercentagePremium;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.FeeTypeChanged);
      RadioButton percentagePremium1 = this._rbPercentagePremium;
      if (percentagePremium1 != null)
        percentagePremium1.CheckedChanged -= eventHandler;
      this._rbPercentagePremium = value;
      RadioButton percentagePremium2 = this._rbPercentagePremium;
      if (percentagePremium2 == null)
        return;
      percentagePremium2.CheckedChanged += eventHandler;
    }
  }

  private virtual MGASimpleComboBox cboOffices
  {
    get => this._cboOffices;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.cboOffices_ValueChanged);
      MGASimpleComboBox cboOffices1 = this._cboOffices;
      if (cboOffices1 != null)
        ((UltraCombo) cboOffices1).ValueChanged -= eventHandler;
      this._cboOffices = value;
      MGASimpleComboBox cboOffices2 = this._cboOffices;
      if (cboOffices2 == null)
        return;
      ((UltraCombo) cboOffices2).ValueChanged += eventHandler;
    }
  }

  private virtual RadioButton rbPercentOf
  {
    get => this._rbPercentOf;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.FeeTypeChanged);
      RadioButton rbPercentOf1 = this._rbPercentOf;
      if (rbPercentOf1 != null)
        rbPercentOf1.CheckedChanged -= eventHandler;
      this._rbPercentOf = value;
      RadioButton rbPercentOf2 = this._rbPercentOf;
      if (rbPercentOf2 == null)
        return;
      rbPercentOf2.CheckedChanged += eventHandler;
    }
  }

  private virtual UltraGrid ugFees
  {
    get => this._ugFees;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ugFees_AfterRowActivate);
      UltraGrid ugFees1 = this._ugFees;
      if (ugFees1 != null)
        ugFees1.AfterRowActivate -= eventHandler;
      this._ugFees = value;
      UltraGrid ugFees2 = this._ugFees;
      if (ugFees2 == null)
        return;
      ugFees2.AfterRowActivate += eventHandler;
    }
  }

  private virtual MGACheckBox chkShowWaived
  {
    get => this._chkShowWaived;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.chkShowWaived_CheckedChanged);
      MGACheckBox chkShowWaived1 = this._chkShowWaived;
      if (chkShowWaived1 != null)
        ((UltraToggleEditorBase) chkShowWaived1).CheckedChanged -= eventHandler;
      this._chkShowWaived = value;
      MGACheckBox chkShowWaived2 = this._chkShowWaived;
      if (chkShowWaived2 == null)
        return;
      ((UltraToggleEditorBase) chkShowWaived2).CheckedChanged += eventHandler;
    }
  }

  private virtual ContextMenu cm
  {
    get => this._cm;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.cm_Popup);
      ContextMenu cm1 = this._cm;
      if (cm1 != null)
        cm1.Popup -= eventHandler;
      this._cm = value;
      ContextMenu cm2 = this._cm;
      if (cm2 == null)
        return;
      cm2.Popup += eventHandler;
    }
  }

  private virtual MenuItem mnuReinstate
  {
    get => this._mnuReinstate;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.mnuReinstate_Click);
      MenuItem mnuReinstate1 = this._mnuReinstate;
      if (mnuReinstate1 != null)
        mnuReinstate1.Click -= eventHandler;
      this._mnuReinstate = value;
      MenuItem mnuReinstate2 = this._mnuReinstate;
      if (mnuReinstate2 == null)
        return;
      mnuReinstate2.Click += eventHandler;
    }
  }

  private virtual MenuItem mnuManualFee
  {
    get => this._mnuManualFee;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.mnuManualFee_Click);
      MenuItem mnuManualFee1 = this._mnuManualFee;
      if (mnuManualFee1 != null)
        mnuManualFee1.Click -= eventHandler;
      this._mnuManualFee = value;
      MenuItem mnuManualFee2 = this._mnuManualFee;
      if (mnuManualFee2 == null)
        return;
      mnuManualFee2.Click += eventHandler;
    }
  }

  protected virtual MenuItem mnuWaiveFee
  {
    get => this._mnuWaiveFee;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.mnuWaiveFee_Click);
      MenuItem mnuWaiveFee1 = this._mnuWaiveFee;
      if (mnuWaiveFee1 != null)
        mnuWaiveFee1.Click -= eventHandler;
      this._mnuWaiveFee = value;
      MenuItem mnuWaiveFee2 = this._mnuWaiveFee;
      if (mnuWaiveFee2 == null)
        return;
      mnuWaiveFee2.Click += eventHandler;
    }
  }

  private virtual LinkLabel lnkAutoApplyLog
  {
    get => this._lnkAutoApplyLog;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkAutoApplyLog_LinkClicked);
      LinkLabel lnkAutoApplyLog1 = this._lnkAutoApplyLog;
      if (lnkAutoApplyLog1 != null)
        lnkAutoApplyLog1.LinkClicked -= clickedEventHandler;
      this._lnkAutoApplyLog = value;
      LinkLabel lnkAutoApplyLog2 = this._lnkAutoApplyLog;
      if (lnkAutoApplyLog2 == null)
        return;
      lnkAutoApplyLog2.LinkClicked += clickedEventHandler;
    }
  }

  internal virtual MenuItem mnuOverridePayee
  {
    get => this._mnuOverridePayee;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.mnuOverridePayee_Click);
      MenuItem mnuOverridePayee1 = this._mnuOverridePayee;
      if (mnuOverridePayee1 != null)
        mnuOverridePayee1.Click -= eventHandler;
      this._mnuOverridePayee = value;
      MenuItem mnuOverridePayee2 = this._mnuOverridePayee;
      if (mnuOverridePayee2 == null)
        return;
      mnuOverridePayee2.Click += eventHandler;
    }
  }

  internal virtual MenuItem mnuResetPayee
  {
    get => this._mnuResetPayee;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.mnuResetPayee_Click);
      MenuItem mnuResetPayee1 = this._mnuResetPayee;
      if (mnuResetPayee1 != null)
        mnuResetPayee1.Click -= eventHandler;
      this._mnuResetPayee = value;
      MenuItem mnuResetPayee2 = this._mnuResetPayee;
      if (mnuResetPayee2 == null)
        return;
      mnuResetPayee2.Click += eventHandler;
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
    UltraGridBand ultraGridBand1 = new UltraGridBand("tblCompanyPolicyCharges", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("ID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("ChargeCode");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("CompanyLineGUID");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("FlatRate");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("PercentageRate");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("ChargeName");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("FeeTypeID");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("Payable");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("Splittable");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("Taxable");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("FullyEarned");
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("AppliesToPaymentID");
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("CompanyFeeID");
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("Description");
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("EffectiveDate");
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("PayableEntityGuid");
    UltraGridColumn ultraGridColumn17 = new UltraGridColumn("Payee");
    UltraGridColumn ultraGridColumn18 = new UltraGridColumn("ExistedOnPriorTransaction");
    UltraGridColumn ultraGridColumn19 = new UltraGridColumn("Disabled");
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    ScrollBarLook scrollBarLook1 = new ScrollBarLook();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    UltraGridBand ultraGridBand2 = new UltraGridBand("tblQuoteOptionCharges", -1);
    UltraGridColumn ultraGridColumn20 = new UltraGridColumn("OptionFeeID");
    UltraGridColumn ultraGridColumn21 = new UltraGridColumn("CompanyFeeID");
    UltraGridColumn ultraGridColumn22 = new UltraGridColumn("QuoteOptionGuid");
    UltraGridColumn ultraGridColumn23 = new UltraGridColumn("ChargeCode");
    UltraGridColumn ultraGridColumn24 = new UltraGridColumn("CompanyLineGuid");
    UltraGridColumn ultraGridColumn25 = new UltraGridColumn("OfficeID");
    UltraGridColumn ultraGridColumn26 = new UltraGridColumn("FeeTypeID");
    UltraGridColumn ultraGridColumn27 = new UltraGridColumn("Payable");
    UltraGridColumn ultraGridColumn28 = new UltraGridColumn("FlatRate");
    UltraGridColumn ultraGridColumn29 = new UltraGridColumn("PercentageRate");
    UltraGridColumn ultraGridColumn30 = new UltraGridColumn("PercentageMinimum");
    UltraGridColumn ultraGridColumn31 = new UltraGridColumn("Splittable");
    UltraGridColumn ultraGridColumn32 = new UltraGridColumn("AutoApplied");
    UltraGridColumn ultraGridColumn33 = new UltraGridColumn("ChargeName");
    Appearance appearance12 = new Appearance();
    UltraGridColumn ultraGridColumn34 = new UltraGridColumn("FeeType");
    Appearance appearance13 = new Appearance();
    UltraGridColumn ultraGridColumn35 = new UltraGridColumn("PercentOfChargeCode");
    UltraGridColumn ultraGridColumn36 = new UltraGridColumn("Taxable");
    UltraGridColumn ultraGridColumn37 = new UltraGridColumn("WaivedByUserGuid");
    UltraGridColumn ultraGridColumn38 = new UltraGridColumn("ConvertedToManualUserGuid");
    UltraGridColumn ultraGridColumn39 = new UltraGridColumn("FullyEarned");
    UltraGridColumn ultraGridColumn40 = new UltraGridColumn("AppliesToPaymentID");
    UltraGridColumn ultraGridColumn41 = new UltraGridColumn("Amount");
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    UltraGridColumn ultraGridColumn42 = new UltraGridColumn("Payee");
    Appearance appearance16 = new Appearance();
    UltraGridColumn ultraGridColumn43 = new UltraGridColumn("PayeeOverride");
    UltraGridColumn ultraGridColumn44 = new UltraGridColumn("ForceSavedBy");
    UltraGridColumn ultraGridColumn45 = new UltraGridColumn("Tax");
    Appearance appearance17 = new Appearance();
    Appearance appearance18 = new Appearance();
    Appearance appearance19 = new Appearance();
    Appearance appearance20 = new Appearance();
    Appearance appearance21 = new Appearance();
    Appearance appearance22 = new Appearance();
    ScrollBarLook scrollBarLook2 = new ScrollBarLook();
    UltraGridBand ultraGridBand3 = new UltraGridBand("PolicyChargeCodes", -1);
    UltraGridColumn ultraGridColumn46 = new UltraGridColumn("ChargeCode");
    UltraGridColumn ultraGridColumn47 = new UltraGridColumn("ChargeName");
    UltraGridColumn ultraGridColumn48 = new UltraGridColumn("OfficeID");
    UltraGridBand ultraGridBand4 = new UltraGridBand("tblClientOffices", -1);
    UltraGridColumn ultraGridColumn49 = new UltraGridColumn("OfficeID");
    UltraGridColumn ultraGridColumn50 = new UltraGridColumn("Location");
    UltraGridColumn ultraGridColumn51 = new UltraGridColumn("tblClientOfficestblQuoteOptionCharges");
    UltraGridBand ultraGridBand5 = new UltraGridBand("tblClientOfficestblQuoteOptionCharges", 0);
    UltraGridColumn ultraGridColumn52 = new UltraGridColumn("OptionFeeID");
    UltraGridColumn ultraGridColumn53 = new UltraGridColumn("QuoteOptionGuid");
    UltraGridColumn ultraGridColumn54 = new UltraGridColumn("ChargeCode");
    UltraGridColumn ultraGridColumn55 = new UltraGridColumn("CompanyLineGuid");
    UltraGridColumn ultraGridColumn56 = new UltraGridColumn("OfficeID");
    UltraGridColumn ultraGridColumn57 = new UltraGridColumn("FeeTypeID");
    UltraGridColumn ultraGridColumn58 = new UltraGridColumn("Payable");
    UltraGridColumn ultraGridColumn59 = new UltraGridColumn("FlatRate");
    UltraGridColumn ultraGridColumn60 = new UltraGridColumn("PercentageRate");
    UltraGridColumn ultraGridColumn61 = new UltraGridColumn("PercentageMinimum");
    UltraGridColumn ultraGridColumn62 = new UltraGridColumn("Splittable");
    UltraGridColumn ultraGridColumn63 = new UltraGridColumn("AutoApplied");
    UltraGridColumn ultraGridColumn64 = new UltraGridColumn("ChargeName");
    UltraGridColumn ultraGridColumn65 = new UltraGridColumn("FeeType");
    UltraGridColumn ultraGridColumn66 = new UltraGridColumn("PercentOfChargeCode");
    UltraGridColumn ultraGridColumn67 = new UltraGridColumn("Taxable");
    UltraGridColumn ultraGridColumn68 = new UltraGridColumn("WaivedByUserGuid");
    UltraGridColumn ultraGridColumn69 = new UltraGridColumn("ConvertedToManualUserGuid");
    UltraGridColumn ultraGridColumn70 = new UltraGridColumn("FullyEarned");
    UltraGridColumn ultraGridColumn71 = new UltraGridColumn("AppliesToPaymentID");
    Appearance appearance23 = new Appearance();
    Appearance appearance24 = new Appearance();
    Appearance appearance25 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmPolicyFees));
    this.ds = new dsPolicyFees();
    this.Label3 = new Label();
    this.txtAmount = new MGATextBox();
    this.Label4 = new Label();
    this.err = new ErrorProvider(this.components);
    this.daOptionFees = new SqlDataAdapter();
    this.SqlDeleteCommand1 = new SqlCommand();
    this.SqlInsertCommand1 = new SqlCommand();
    this.SqlSelectCommand2 = new SqlCommand();
    this.SqlUpdateCommand1 = new SqlCommand();
    this.panelControls = new MGAGroupBox();
    this.rbFlat = new RadioButton();
    this.cboFees = new MGAComboBox();
    this.TblCompanyPolicyChargesBindingSource = new BindingSource(this.components);
    this.Label8 = new Label();
    this.txtMinimum = new MGATextBox();
    this.Label9 = new Label();
    this.cboOffices = new MGASimpleComboBox();
    this.cboPercentOf = new MGASimpleComboBox();
    this.rbPercentOf = new RadioButton();
    this.lblFeeType = new UltraLabel();
    this.Label7 = new Label();
    this.Label6 = new Label();
    this.rbPercentagePremium = new RadioButton();
    this.dvChargeCodes = new DataView();
    this.SqlSelectCommand1 = new SqlCommand();
    this.ugFees = new UltraGrid();
    this.cm = new ContextMenu();
    this.mnuReinstate = new MenuItem();
    this.mnuManualFee = new MenuItem();
    this.mnuWaiveFee = new MenuItem();
    this.mnuOverridePayee = new MenuItem();
    this.mnuResetPayee = new MenuItem();
    this.dbSave = new MGASystems.Tools.DBSaveUI.DBSaveUI();
    this.ddChargeCodes = new UltraDropDown();
    this.ddOffices = new UltraDropDown();
    this.chkShowWaived = new MGACheckBox();
    this.lblWaivedBy = new UltraLabel();
    this.panelPleaseWait = new UltraGroupBox();
    this.Label1 = new Label();
    this.PictureBox1 = new PictureBox();
    this.lnkAutoApplyLog = new LinkLabel();
    this.ds.BeginInit();
    ((ISupportInitialize) this.txtAmount).BeginInit();
    ((ISupportInitialize) this.err).BeginInit();
    ((ISupportInitialize) this.panelControls).BeginInit();
    ((Control) this.panelControls).SuspendLayout();
    ((ISupportInitialize) this.cboFees).BeginInit();
    ((ISupportInitialize) this.TblCompanyPolicyChargesBindingSource).BeginInit();
    ((ISupportInitialize) this.txtMinimum).BeginInit();
    ((ISupportInitialize) this.cboOffices).BeginInit();
    ((ISupportInitialize) this.cboPercentOf).BeginInit();
    this.dvChargeCodes.BeginInit();
    ((ISupportInitialize) this.ugFees).BeginInit();
    ((ISupportInitialize) this.ddChargeCodes).BeginInit();
    ((ISupportInitialize) this.ddOffices).BeginInit();
    ((ISupportInitialize) this.chkShowWaived).BeginInit();
    ((ISupportInitialize) this.panelPleaseWait).BeginInit();
    ((Control) this.panelPleaseWait).SuspendLayout();
    ((ISupportInitialize) this.PictureBox1).BeginInit();
    this.SuspendLayout();
    this.ds.DataSetName = "dsPolicyFees";
    this.ds.Locale = new CultureInfo("en-US");
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.Label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.Label3.BackColor = Color.Transparent;
    this.Label3.ForeColor = Color.Black;
    this.Label3.Location = new Point(24, 34);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(28, 14);
    this.Label3.TabIndex = 4;
    this.Label3.Text = "Fee:";
    this.Label3.TextAlign = ContentAlignment.MiddleRight;
    ((Control) this.txtAmount).Anchor = AnchorStyles.Bottom;
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance1.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtAmount).Appearance = (AppearanceBase) appearance1;
    ((TextEditorControlBase) this.txtAmount).BackColor = Color.White;
    ((Control) this.txtAmount).Location = new Point(59, 123);
    this.txtAmount.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtAmount).Name = "txtAmount";
    ((Control) this.txtAmount).Size = new Size(119, 20);
    ((Control) this.txtAmount).TabIndex = 6;
    ((UltraControlBase) this.txtAmount).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtAmount).UseOsThemes = (DefaultableBoolean) 2;
    this.Label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.Label4.BackColor = Color.Transparent;
    this.Label4.ForeColor = Color.Black;
    this.Label4.Location = new Point(7, 126);
    this.Label4.Name = "Label4";
    this.Label4.Size = new Size(49, 14);
    this.Label4.TabIndex = 7;
    this.Label4.Text = "Amount:";
    this.Label4.TextAlign = ContentAlignment.MiddleRight;
    this.err.ContainerControl = (ContainerControl) this;
    this.daOptionFees.AcceptChangesDuringFill = false;
    this.daOptionFees.AcceptChangesDuringUpdate = false;
    this.daOptionFees.DeleteCommand = this.SqlDeleteCommand1;
    this.daOptionFees.InsertCommand = this.SqlInsertCommand1;
    this.daOptionFees.SelectCommand = this.SqlSelectCommand2;
    this.daOptionFees.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblQuoteOptionCharges", new DataColumnMapping[21]
      {
        new DataColumnMapping("QuoteOptionGuid", "QuoteOptionGuid"),
        new DataColumnMapping("ChargeCode", "ChargeCode"),
        new DataColumnMapping("CompanyLineGuid", "CompanyLineGuid"),
        new DataColumnMapping("FeeTypeID", "FeeTypeID"),
        new DataColumnMapping("Payable", "Payable"),
        new DataColumnMapping("FlatRate", "FlatRate"),
        new DataColumnMapping("PercentageRate", "PercentageRate"),
        new DataColumnMapping("Splittable", "Splittable"),
        new DataColumnMapping("AutoApplied", "AutoApplied"),
        new DataColumnMapping("PercentOfChargeCode", "PercentOfChargeCode"),
        new DataColumnMapping("OfficeID", "OfficeID"),
        new DataColumnMapping("PercentageMinimum", "PercentageMinimum"),
        new DataColumnMapping("Taxable", "Taxable"),
        new DataColumnMapping("WaivedByUserGuid", "WaivedByUserGuid"),
        new DataColumnMapping("OptionFeeID", "OptionFeeID"),
        new DataColumnMapping("FullyEarned", "FullyEarned"),
        new DataColumnMapping("AppliesToPaymentID", "AppliesToPaymentID"),
        new DataColumnMapping("Amount", "Amount"),
        new DataColumnMapping("CompanyFeeID", "CompanyFeeID"),
        new DataColumnMapping("PayeeOverride", "PayeeOverride"),
        new DataColumnMapping("ForceSavedBy", "ForceSavedBy")
      })
    });
    this.daOptionFees.UpdateCommand = this.SqlUpdateCommand1;
    this.SqlDeleteCommand1.CommandText = "DELETE FROM tblQuoteOptionCharges WHERE (OptionFeeID = @Original_OptionFeeID)";
    this.SqlDeleteCommand1.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@Original_OptionFeeID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "OptionFeeID", DataRowVersion.Original, (object) null)
    });
    this.SqlInsertCommand1.CommandText = componentResourceManager.GetString("SqlInsertCommand1.CommandText");
    this.SqlInsertCommand1.Parameters.AddRange(new SqlParameter[20]
    {
      new SqlParameter("@QuoteOptionGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "QuoteOptionGuid"),
      new SqlParameter("@ChargeCode", SqlDbType.Int, 4, "ChargeCode"),
      new SqlParameter("@CompanyLineGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "CompanyLineGuid"),
      new SqlParameter("@FeeTypeID", SqlDbType.TinyInt, 1, "FeeTypeID"),
      new SqlParameter("@Payable", SqlDbType.Bit, 1, "Payable"),
      new SqlParameter("@FlatRate", SqlDbType.Decimal, 5, ParameterDirection.Input, false, (byte) 9, (byte) 2, "FlatRate", DataRowVersion.Current, (object) null),
      new SqlParameter("@PercentageRate", SqlDbType.Decimal, 5, ParameterDirection.Input, false, (byte) 7, (byte) 6, "PercentageRate", DataRowVersion.Current, (object) null),
      new SqlParameter("@Splittable", SqlDbType.Bit, 1, "Splittable"),
      new SqlParameter("@AutoApplied", SqlDbType.Bit, 1, "AutoApplied"),
      new SqlParameter("@PercentOfChargeCode", SqlDbType.Int, 4, "PercentOfChargeCode"),
      new SqlParameter("@OfficeID", SqlDbType.Int, 4, "OfficeID"),
      new SqlParameter("@PercentageMinimum", SqlDbType.Decimal, 9, ParameterDirection.Input, false, (byte) 10, (byte) 2, "PercentageMinimum", DataRowVersion.Current, (object) null),
      new SqlParameter("@Taxable", SqlDbType.Bit, 1, "Taxable"),
      new SqlParameter("@WaivedByUserGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "WaivedByUserGuid"),
      new SqlParameter("@FullyEarned", SqlDbType.Bit, 1, "FullyEarned"),
      new SqlParameter("@AppliesToPaymentID", SqlDbType.Char, 1, "AppliesToPaymentID"),
      new SqlParameter("@CompanyFeeID", SqlDbType.Int, 4, "CompanyFeeID"),
      new SqlParameter("@amount", SqlDbType.Money, 8, "amount"),
      new SqlParameter("@PayeeOverride", SqlDbType.UniqueIdentifier, 1024 /*0x0400*/, "PayeeOverride"),
      new SqlParameter("@ForceSavedBy", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "ForceSavedBy")
    });
    this.SqlSelectCommand2.CommandText = componentResourceManager.GetString("SqlSelectCommand2.CommandText");
    this.SqlSelectCommand2.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@OptionFeeID", SqlDbType.Int, 4, "OptionFeeID")
    });
    this.SqlUpdateCommand1.CommandText = componentResourceManager.GetString("SqlUpdateCommand1.CommandText");
    this.SqlUpdateCommand1.Parameters.AddRange(new SqlParameter[22]
    {
      new SqlParameter("@QuoteOptionGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "QuoteOptionGuid"),
      new SqlParameter("@ChargeCode", SqlDbType.Int, 4, "ChargeCode"),
      new SqlParameter("@CompanyLineGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "CompanyLineGuid"),
      new SqlParameter("@FeeTypeID", SqlDbType.TinyInt, 1, "FeeTypeID"),
      new SqlParameter("@Payable", SqlDbType.Bit, 1, "Payable"),
      new SqlParameter("@FlatRate", SqlDbType.Decimal, 5, ParameterDirection.Input, false, (byte) 9, (byte) 2, "FlatRate", DataRowVersion.Current, (object) null),
      new SqlParameter("@PercentageRate", SqlDbType.Decimal, 5, ParameterDirection.Input, false, (byte) 7, (byte) 6, "PercentageRate", DataRowVersion.Current, (object) null),
      new SqlParameter("@Splittable", SqlDbType.Bit, 1, "Splittable"),
      new SqlParameter("@AutoApplied", SqlDbType.Bit, 1, "AutoApplied"),
      new SqlParameter("@PercentOfChargeCode", SqlDbType.Int, 4, "PercentOfChargeCode"),
      new SqlParameter("@OfficeID", SqlDbType.Int, 4, "OfficeID"),
      new SqlParameter("@PercentageMinimum", SqlDbType.Decimal, 9, ParameterDirection.Input, false, (byte) 10, (byte) 2, "PercentageMinimum", DataRowVersion.Current, (object) null),
      new SqlParameter("@Taxable", SqlDbType.Bit, 1, "Taxable"),
      new SqlParameter("@WaivedByUserGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "WaivedByUserGuid"),
      new SqlParameter("@FullyEarned", SqlDbType.Bit, 1, "FullyEarned"),
      new SqlParameter("@AppliesToPaymentID", SqlDbType.Char, 1, "AppliesToPaymentID"),
      new SqlParameter("@CompanyFeeID", SqlDbType.Int, 4, "CompanyFeeID"),
      new SqlParameter("@amount", SqlDbType.Money, 8, "amount"),
      new SqlParameter("@PayeeOverride", SqlDbType.UniqueIdentifier, 1024 /*0x0400*/, "PayeeOverride"),
      new SqlParameter("@Original_OptionFeeID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "OptionFeeID", DataRowVersion.Original, (object) null),
      new SqlParameter("@OptionFeeID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "OptionFeeID", DataRowVersion.Original, (object) null),
      new SqlParameter("@ForceSavedBy", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "ForceSavedBy")
    });
    ((Control) this.panelControls).Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    appearance2.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGroupBox) this.panelControls).Appearance = (AppearanceBase) appearance2;
    ((UltraGroupBox) this.panelControls).BackColorInternal = Color.FromArgb(239, 247, 253);
    appearance3.BackColor = Color.FromArgb(239, 247, 253);
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGroupBox) this.panelControls).ContentAreaAppearance = (AppearanceBase) appearance3;
    ((Control) this.panelControls).Controls.Add((Control) this.rbFlat);
    ((Control) this.panelControls).Controls.Add((Control) this.cboFees);
    ((Control) this.panelControls).Controls.Add((Control) this.Label8);
    ((Control) this.panelControls).Controls.Add((Control) this.txtMinimum);
    ((Control) this.panelControls).Controls.Add((Control) this.Label9);
    ((Control) this.panelControls).Controls.Add((Control) this.cboOffices);
    ((Control) this.panelControls).Controls.Add((Control) this.cboPercentOf);
    ((Control) this.panelControls).Controls.Add((Control) this.rbPercentOf);
    ((Control) this.panelControls).Controls.Add((Control) this.lblFeeType);
    ((Control) this.panelControls).Controls.Add((Control) this.Label7);
    ((Control) this.panelControls).Controls.Add((Control) this.Label6);
    ((Control) this.panelControls).Controls.Add((Control) this.rbPercentagePremium);
    ((Control) this.panelControls).Controls.Add((Control) this.Label4);
    ((Control) this.panelControls).Controls.Add((Control) this.Label3);
    ((Control) this.panelControls).Controls.Add((Control) this.txtAmount);
    ((Control) this.panelControls).Enabled = false;
    appearance4.ForeColor = Color.FromArgb(21, 66, 139);
    ((UltraGroupBox) this.panelControls).HeaderAppearance = (AppearanceBase) appearance4;
    ((Control) this.panelControls).Location = new Point(7, 203);
    ((Control) this.panelControls).Name = "panelControls";
    ((Control) this.panelControls).Size = new Size(473, 154);
    ((Control) this.panelControls).TabIndex = 11;
    ((UltraGroupBox) this.panelControls).Text = "Fee Information";
    ((UltraGroupBox) this.panelControls).ViewStyle = (GroupBoxViewStyle) 2;
    this.rbFlat.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.rbFlat.BackColor = Color.Transparent;
    this.rbFlat.ForeColor = Color.Black;
    this.rbFlat.Location = new Point(59, 98);
    this.rbFlat.Name = "rbFlat";
    this.rbFlat.Size = new Size(43, 24);
    this.rbFlat.TabIndex = 12;
    this.rbFlat.Text = "Flat";
    this.rbFlat.UseVisualStyleBackColor = false;
    ((UltraCombo) this.cboFees).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.cboFees).DataSource = (object) this.TblCompanyPolicyChargesBindingSource;
    appearance5.BackColor = Color.White;
    appearance5.BorderColor = Color.FromArgb(78, 122, 171);
    this.cboFees.DisplayLayout.Appearance = (AppearanceBase) appearance5;
    this.cboFees.DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand1.ColHeadersVisible = false;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 16 /*0x10*/;
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 2;
    ultraGridColumn2.Hidden = true;
    ultraGridColumn2.Width = 21;
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Header.VisiblePosition = 1;
    ultraGridColumn3.Hidden = true;
    ultraGridColumn3.Width = 64 /*0x40*/;
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn4.Header.VisiblePosition = 3;
    ultraGridColumn4.Hidden = true;
    ultraGridColumn4.Width = 22;
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn5.Header.VisiblePosition = 4;
    ultraGridColumn5.Hidden = true;
    ultraGridColumn5.Width = 26;
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn6.Header.VisiblePosition = 5;
    ultraGridColumn6.MinWidth = 70;
    ultraGridColumn6.Width = 170;
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn7.Header.VisiblePosition = 6;
    ultraGridColumn7.Hidden = true;
    ultraGridColumn7.Width = 20;
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn8.Header.VisiblePosition = 7;
    ultraGridColumn8.Hidden = true;
    ultraGridColumn8.Width = 17;
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn9.Header.VisiblePosition = 8;
    ultraGridColumn9.Hidden = true;
    ultraGridColumn9.Width = 17;
    ((HeaderBase) ultraGridColumn10.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn10.Header.VisiblePosition = 9;
    ultraGridColumn10.Hidden = true;
    ultraGridColumn10.Width = 17;
    ((HeaderBase) ultraGridColumn11.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn11.Header.VisiblePosition = 10;
    ultraGridColumn11.Hidden = true;
    ultraGridColumn11.Width = 21;
    ((HeaderBase) ultraGridColumn12.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn12.Header.VisiblePosition = 11;
    ultraGridColumn12.Hidden = true;
    ultraGridColumn12.Width = 33;
    ((HeaderBase) ultraGridColumn13.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn13.Header.VisiblePosition = 12;
    ultraGridColumn13.Hidden = true;
    ultraGridColumn13.Width = 26;
    ((HeaderBase) ultraGridColumn14.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn14.Header.VisiblePosition = 13;
    ultraGridColumn14.Width = 208 /*0xD0*/;
    ((HeaderBase) ultraGridColumn15.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn15.Header.VisiblePosition = 14;
    ultraGridColumn15.Width = 102;
    ((HeaderBase) ultraGridColumn16.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn16.Header.VisiblePosition = 15;
    ultraGridColumn16.Hidden = true;
    ultraGridColumn16.Width = 162;
    ((HeaderBase) ultraGridColumn17.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn17.Header.VisiblePosition = 16 /*0x10*/;
    ultraGridColumn17.Width = 201;
    ((HeaderBase) ultraGridColumn18.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn18.Header.VisiblePosition = 17;
    ultraGridColumn18.Hidden = true;
    ultraGridColumn18.Width = 125;
    ((HeaderBase) ultraGridColumn19.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn19.Header.VisiblePosition = 18;
    ultraGridColumn19.Hidden = true;
    ultraGridColumn19.Width = 66;
    ultraGridBand1.Columns.AddRange(new object[19]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
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
      (object) ultraGridColumn19
    });
    this.cboFees.DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    this.cboFees.DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    this.cboFees.DisplayLayout.BorderStyleCaption = (UIElementBorderStyle) 1;
    this.cboFees.DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    this.cboFees.DisplayLayout.Override.BorderStyleHeader = (UIElementBorderStyle) 1;
    this.cboFees.DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    this.cboFees.DisplayLayout.Override.BorderStyleRowSelector = (UIElementBorderStyle) 1;
    this.cboFees.DisplayLayout.Override.BorderStyleSummaryFooter = (UIElementBorderStyle) 1;
    this.cboFees.DisplayLayout.Override.BorderStyleSummaryFooterCaption = (UIElementBorderStyle) 1;
    this.cboFees.DisplayLayout.Override.BorderStyleSummaryValue = (UIElementBorderStyle) 1;
    this.cboFees.DisplayLayout.Override.BorderStyleTemplateAddRow = (UIElementBorderStyle) 1;
    appearance6.BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    appearance6.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this.cboFees.DisplayLayout.Override.HotTrackRowAppearance = (AppearanceBase) appearance6;
    appearance7.BorderColor = Color.White;
    this.cboFees.DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance7;
    this.cboFees.DisplayLayout.Override.RowSpacingAfter = 1;
    appearance8.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance8.BorderColor = Color.FromArgb((int) byte.MaxValue, 214, 88);
    appearance8.ForeColor = Color.Black;
    this.cboFees.DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance8;
    scrollBarLook1.ViewStyle = (ScrollBarViewStyle) 3;
    this.cboFees.DisplayLayout.ScrollBarLook = scrollBarLook1;
    ((UltraDropDownBase) this.cboFees).DisplayMember = "ChargeName";
    ((UltraCombo) this.cboFees).DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboFees).DropDownWidth = 700;
    ((Control) this.cboFees).Location = new Point(59, 31 /*0x1F*/);
    ((MGASimpleComboBox) this.cboFees).MGAStyle = (MGAStyles) 2;
    ((Control) this.cboFees).Name = "cboFees";
    ((Control) this.cboFees).Size = new Size(389, 21);
    ((Control) this.cboFees).TabIndex = 23;
    ((UltraControlBase) this.cboFees).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboFees).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboFees).ValueMember = "ID";
    this.TblCompanyPolicyChargesBindingSource.DataMember = "tblCompanyPolicyCharges";
    this.TblCompanyPolicyChargesBindingSource.DataSource = (object) this.ds;
    this.Label8.Anchor = AnchorStyles.Bottom;
    this.Label8.BackColor = Color.Transparent;
    this.Label8.ForeColor = Color.Black;
    this.Label8.Location = new Point(185, 126);
    this.Label8.Name = "Label8";
    this.Label8.Size = new Size(70, 14);
    this.Label8.TabIndex = 22;
    this.Label8.Text = "Minimum:";
    this.Label8.TextAlign = ContentAlignment.MiddleRight;
    ((Control) this.txtMinimum).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance9.BackColor = Color.White;
    appearance9.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance9.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtMinimum).Appearance = (AppearanceBase) appearance9;
    ((TextEditorControlBase) this.txtMinimum).BackColor = Color.White;
    ((Control) this.txtMinimum).Location = new Point(262, 123);
    this.txtMinimum.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtMinimum).Name = "txtMinimum";
    ((Control) this.txtMinimum).Size = new Size(119, 20);
    ((Control) this.txtMinimum).TabIndex = 21;
    ((UltraControlBase) this.txtMinimum).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtMinimum).UseOsThemes = (DefaultableBoolean) 2;
    this.Label9.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.Label9.BackColor = Color.Transparent;
    this.Label9.ForeColor = Color.Black;
    this.Label9.Location = new Point(7, 57);
    this.Label9.Name = "Label9";
    this.Label9.Size = new Size(49, 14);
    this.Label9.TabIndex = 19;
    this.Label9.Text = "Office:";
    this.Label9.TextAlign = ContentAlignment.MiddleRight;
    ((Control) this.cboOffices).Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraCombo) this.cboOffices).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraCombo) this.cboOffices).DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboOffices).Location = new Point(59, 54);
    this.cboOffices.MGAStyle = (MGAStyles) 2;
    ((Control) this.cboOffices).Name = "cboOffices";
    ((Control) this.cboOffices).Size = new Size(389, 21);
    ((Control) this.cboOffices).TabIndex = 20;
    ((UltraControlBase) this.cboOffices).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboOffices).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.cboPercentOf).Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraCombo) this.cboPercentOf).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraCombo) this.cboPercentOf).DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboPercentOf).Location = new Point(262, 100);
    this.cboPercentOf.MGAStyle = (MGAStyles) 2;
    ((Control) this.cboPercentOf).Name = "cboPercentOf";
    ((Control) this.cboPercentOf).Size = new Size(186, 21);
    ((Control) this.cboPercentOf).TabIndex = 18;
    ((UltraControlBase) this.cboPercentOf).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboPercentOf).UseOsThemes = (DefaultableBoolean) 2;
    this.rbPercentOf.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.rbPercentOf.BackColor = Color.Transparent;
    this.rbPercentOf.ForeColor = Color.Black;
    this.rbPercentOf.Location = new Point(213, 98);
    this.rbPercentOf.Name = "rbPercentOf";
    this.rbPercentOf.Size = new Size(49, 24);
    this.rbPercentOf.TabIndex = 17;
    this.rbPercentOf.Text = "% of ";
    this.rbPercentOf.UseVisualStyleBackColor = false;
    ((Control) this.lblFeeType).Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    appearance10.BackColor = Color.FromArgb(240 /*0xF0*/, 247, 253);
    appearance10.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance10).TextHAlignAsString = "Left";
    ((AppearanceBase) appearance10).TextVAlignAsString = "Middle";
    ((ControlBase) this.lblFeeType).Appearance = (AppearanceBase) appearance10;
    this.lblFeeType.BorderStyleOuter = (UIElementBorderStyle) 4;
    ((Control) this.lblFeeType).Location = new Point(59, 77);
    ((Control) this.lblFeeType).Name = "lblFeeType";
    ((Control) this.lblFeeType).Size = new Size(389, 20);
    ((Control) this.lblFeeType).TabIndex = 16 /*0x10*/;
    this.Label7.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.Label7.AutoSize = true;
    this.Label7.BackColor = Color.Transparent;
    this.Label7.ForeColor = Color.Black;
    this.Label7.Location = new Point(6, 79);
    this.Label7.Name = "Label7";
    this.Label7.Size = new Size(52, 13);
    this.Label7.TabIndex = 15;
    this.Label7.Text = "Fee Info:";
    this.Label7.TextAlign = ContentAlignment.MiddleRight;
    this.Label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.Label6.BackColor = Color.Transparent;
    this.Label6.ForeColor = Color.Black;
    this.Label6.Location = new Point(14, 103);
    this.Label6.Name = "Label6";
    this.Label6.Size = new Size(42, 14);
    this.Label6.TabIndex = 14;
    this.Label6.Text = "Type:";
    this.Label6.TextAlign = ContentAlignment.MiddleRight;
    this.rbPercentagePremium.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.rbPercentagePremium.BackColor = Color.Transparent;
    this.rbPercentagePremium.ForeColor = Color.Black;
    this.rbPercentagePremium.Location = new Point(108, 98);
    this.rbPercentagePremium.Name = "rbPercentagePremium";
    this.rbPercentagePremium.Size = new Size(119, 24);
    this.rbPercentagePremium.TabIndex = 13;
    this.rbPercentagePremium.Text = "% Total Premium";
    this.rbPercentagePremium.UseVisualStyleBackColor = false;
    this.dvChargeCodes.Table = (DataTable) this.ds.PolicyChargeCodes;
    this.SqlSelectCommand1.CommandText = componentResourceManager.GetString("SqlSelectCommand1.CommandText");
    ((Control) this.ugFees).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((Control) this.ugFees).ContextMenu = this.cm;
    ((UltraGridBase) this.ugFees).DataSource = (object) this.ds.tblQuoteOptionCharges;
    appearance11.BackColor = Color.White;
    appearance11.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ugFees).DisplayLayout.Appearance = (AppearanceBase) appearance11;
    ((UltraGridBase) this.ugFees).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((HeaderBase) ultraGridColumn20.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn20.Header.VisiblePosition = 0;
    ultraGridColumn20.Hidden = true;
    ultraGridColumn20.Width = 14;
    ((HeaderBase) ultraGridColumn21.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn21.Header.VisiblePosition = 1;
    ultraGridColumn21.Hidden = true;
    ultraGridColumn21.Width = 80 /*0x50*/;
    ((HeaderBase) ultraGridColumn22.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn22.Header.VisiblePosition = 2;
    ultraGridColumn22.Hidden = true;
    ultraGridColumn22.Width = 79;
    ((HeaderBase) ultraGridColumn23.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn23.Header.VisiblePosition = 3;
    ultraGridColumn23.Hidden = true;
    ultraGridColumn23.Width = 26;
    ((HeaderBase) ultraGridColumn24.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn24.Header.VisiblePosition = 4;
    ultraGridColumn24.Hidden = true;
    ultraGridColumn24.Width = 79;
    ((HeaderBase) ultraGridColumn25.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn25.Header.VisiblePosition = 5;
    ultraGridColumn25.Hidden = true;
    ultraGridColumn25.Width = 19;
    ((HeaderBase) ultraGridColumn26.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn26.Header.VisiblePosition = 6;
    ultraGridColumn26.Hidden = true;
    ultraGridColumn26.Width = 24;
    ((HeaderBase) ultraGridColumn27.Header).Caption = "Pay. to Comp.";
    ((HeaderBase) ultraGridColumn27.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn27.Header.VisiblePosition = 10;
    ultraGridColumn27.Width = 88;
    ((HeaderBase) ultraGridColumn28.Header).Caption = "Flat";
    ((HeaderBase) ultraGridColumn28.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn28.Header.VisiblePosition = 11;
    ultraGridColumn28.Hidden = true;
    ultraGridColumn28.Width = 94;
    ((HeaderBase) ultraGridColumn29.Header).Caption = "%";
    ((HeaderBase) ultraGridColumn29.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn29.Header.VisiblePosition = 12;
    ultraGridColumn29.Hidden = true;
    ultraGridColumn29.Width = 107;
    ((HeaderBase) ultraGridColumn30.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn30.Header.VisiblePosition = 13;
    ultraGridColumn30.Hidden = true;
    ultraGridColumn30.Width = 57;
    ((HeaderBase) ultraGridColumn31.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn31.Header.VisiblePosition = 14;
    ultraGridColumn31.Hidden = true;
    ultraGridColumn31.Width = 32 /*0x20*/;
    ((HeaderBase) ultraGridColumn32.Header).Caption = "Auto";
    ((HeaderBase) ultraGridColumn32.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn32.Header.VisiblePosition = 15;
    ultraGridColumn32.Width = 55;
    ((AppearanceBase) appearance12).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn33.Header).Appearance = (AppearanceBase) appearance12;
    ((HeaderBase) ultraGridColumn33.Header).Caption = "Fee";
    ((HeaderBase) ultraGridColumn33.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn33.Header.VisiblePosition = 7;
    ultraGridColumn33.Width = 264;
    ((AppearanceBase) appearance13).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn34.Header).Appearance = (AppearanceBase) appearance13;
    ((HeaderBase) ultraGridColumn34.Header).Caption = "Type";
    ((HeaderBase) ultraGridColumn34.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn34.Header.VisiblePosition = 9;
    ultraGridColumn34.Width = 142;
    ((HeaderBase) ultraGridColumn35.Header).Caption = "% Of";
    ((HeaderBase) ultraGridColumn35.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn35.Header.VisiblePosition = 16 /*0x10*/;
    ultraGridColumn35.Hidden = true;
    ultraGridColumn35.Width = 173;
    ((HeaderBase) ultraGridColumn36.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn36.Header.VisiblePosition = 17;
    ultraGridColumn36.Hidden = true;
    ultraGridColumn36.Width = 73;
    ((HeaderBase) ultraGridColumn37.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn37.Header.VisiblePosition = 18;
    ultraGridColumn37.Hidden = true;
    ultraGridColumn37.Width = 135;
    ((HeaderBase) ultraGridColumn38.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn38.Header.VisiblePosition = 19;
    ultraGridColumn38.Hidden = true;
    ultraGridColumn38.Width = 164;
    ((HeaderBase) ultraGridColumn39.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn39.Header.VisiblePosition = 20;
    ultraGridColumn39.Hidden = true;
    ultraGridColumn39.Width = 61;
    ((HeaderBase) ultraGridColumn40.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn40.Header.VisiblePosition = 21;
    ultraGridColumn40.Hidden = true;
    ultraGridColumn40.Width = 110;
    ((AppearanceBase) appearance14).TextHAlignAsString = "Right";
    ultraGridColumn41.CellAppearance = (AppearanceBase) appearance14;
    ultraGridColumn41.Format = "c";
    ((AppearanceBase) appearance15).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn41.Header).Appearance = (AppearanceBase) appearance15;
    ((HeaderBase) ultraGridColumn41.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn41.Header.VisiblePosition = 8;
    ultraGridColumn41.Width = 93;
    ((AppearanceBase) appearance16).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn42.Header).Appearance = (AppearanceBase) appearance16;
    ((HeaderBase) ultraGridColumn42.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn42.Header.VisiblePosition = 22;
    ultraGridColumn42.Width = 112 /*0x70*/;
    ((HeaderBase) ultraGridColumn43.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn43.Header.VisiblePosition = 23;
    ultraGridColumn43.Hidden = true;
    ultraGridColumn43.Width = 181;
    ((HeaderBase) ultraGridColumn44.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn44.Header.VisiblePosition = 24;
    ultraGridColumn44.Hidden = true;
    ultraGridColumn44.Width = 181;
    ((HeaderBase) ultraGridColumn45.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn45.Header.VisiblePosition = 25;
    ultraGridColumn45.Hidden = true;
    ultraGridColumn45.Width = 88;
    ultraGridBand2.Columns.AddRange(new object[26]
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
      (object) ultraGridColumn45
    });
    ((UltraGridBase) this.ugFees).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.ugFees).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance17.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance17.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ugFees).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance17;
    ((UltraGridBase) this.ugFees).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.ugFees).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.ugFees).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    appearance18.BorderColor = Color.Gainsboro;
    ((UltraGridBase) this.ugFees).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance18;
    ((UltraGridBase) this.ugFees).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    appearance19.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    appearance19.ForeColor = Color.Black;
    ((UltraGridBase) this.ugFees).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance19;
    ((UltraGridBase) this.ugFees).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance20.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ugFees).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance20;
    appearance21.BackColor = Color.White;
    appearance21.BorderColor = Color.Gainsboro;
    appearance21.ForeColor = Color.Black;
    ((UltraGridBase) this.ugFees).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance21;
    ((UltraGridBase) this.ugFees).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance22.BackColor = Color.Transparent;
    appearance22.ForeColor = Color.Black;
    ((UltraGridBase) this.ugFees).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance22;
    scrollBarLook2.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.ugFees).DisplayLayout.ScrollBarLook = scrollBarLook2;
    ((Control) this.ugFees).Location = new Point(7, 7);
    ((Control) this.ugFees).Name = "ugFees";
    ((Control) this.ugFees).Size = new Size(756, 189);
    ((Control) this.ugFees).TabIndex = 16 /*0x10*/;
    ((UltraControlBase) this.ugFees).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ugFees).UseOsThemes = (DefaultableBoolean) 2;
    this.cm.MenuItems.AddRange(new MenuItem[5]
    {
      this.mnuReinstate,
      this.mnuManualFee,
      this.mnuWaiveFee,
      this.mnuOverridePayee,
      this.mnuResetPayee
    });
    this.mnuReinstate.Index = 0;
    this.mnuReinstate.Text = "Reinstate Fee";
    this.mnuManualFee.Index = 1;
    this.mnuManualFee.Text = "Convert to Manual Fee";
    this.mnuWaiveFee.Index = 2;
    this.mnuWaiveFee.Text = "Waive Fee";
    this.mnuOverridePayee.Index = 3;
    this.mnuOverridePayee.Text = "Override Payee";
    this.mnuResetPayee.Index = 4;
    this.mnuResetPayee.Text = "Reset Payee";
    ((Control) this.dbSave).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.dbSave.AutoQueryRowCountOnLoad = false;
    this.dbSave.EditStyle = (EditStyle) 1;
    this.dbSave.FreezeEvents = false;
    ((Control) this.dbSave).Location = new Point(490, 315);
    ((Control) this.dbSave).Name = "dbSave";
    ((Control) this.dbSave).Size = new Size(112 /*0x70*/, 40);
    ((Control) this.dbSave).TabIndex = 19;
    ((Control) this.ddChargeCodes).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    ((HeaderBase) ultraGridColumn46.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn46.Header.VisiblePosition = 0;
    ((HeaderBase) ultraGridColumn47.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn47.Header.VisiblePosition = 1;
    ((HeaderBase) ultraGridColumn48.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn48.Header.VisiblePosition = 2;
    ultraGridBand3.Columns.AddRange(new object[3]
    {
      (object) ultraGridColumn46,
      (object) ultraGridColumn47,
      (object) ultraGridColumn48
    });
    ((UltraGridBase) this.ddChargeCodes).DisplayLayout.BandsSerializer.Add((object) ultraGridBand3);
    ((Control) this.ddChargeCodes).Location = new Point(686, 294);
    ((Control) this.ddChargeCodes).Name = "ddChargeCodes";
    ((Control) this.ddChargeCodes).Size = new Size(75, 23);
    ((Control) this.ddChargeCodes).TabIndex = 20;
    ((Control) this.ddChargeCodes).Visible = false;
    ((Control) this.ddOffices).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    ((HeaderBase) ultraGridColumn49.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn49.Header.VisiblePosition = 0;
    ((HeaderBase) ultraGridColumn50.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn50.Header.VisiblePosition = 1;
    ((HeaderBase) ultraGridColumn51.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn51.Header.VisiblePosition = 2;
    ultraGridBand4.Columns.AddRange(new object[3]
    {
      (object) ultraGridColumn49,
      (object) ultraGridColumn50,
      (object) ultraGridColumn51
    });
    ((HeaderBase) ultraGridColumn52.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn52.Header.VisiblePosition = 0;
    ((HeaderBase) ultraGridColumn53.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn53.Header.VisiblePosition = 1;
    ((HeaderBase) ultraGridColumn54.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn54.Header.VisiblePosition = 2;
    ((HeaderBase) ultraGridColumn55.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn55.Header.VisiblePosition = 3;
    ((HeaderBase) ultraGridColumn56.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn56.Header.VisiblePosition = 4;
    ((HeaderBase) ultraGridColumn57.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn57.Header.VisiblePosition = 5;
    ((HeaderBase) ultraGridColumn58.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn58.Header.VisiblePosition = 6;
    ((HeaderBase) ultraGridColumn59.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn59.Header.VisiblePosition = 7;
    ((HeaderBase) ultraGridColumn60.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn60.Header.VisiblePosition = 8;
    ((HeaderBase) ultraGridColumn61.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn61.Header.VisiblePosition = 9;
    ((HeaderBase) ultraGridColumn62.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn62.Header.VisiblePosition = 10;
    ((HeaderBase) ultraGridColumn63.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn63.Header.VisiblePosition = 11;
    ((HeaderBase) ultraGridColumn64.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn64.Header.VisiblePosition = 12;
    ((HeaderBase) ultraGridColumn65.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn65.Header.VisiblePosition = 13;
    ((HeaderBase) ultraGridColumn66.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn66.Header.VisiblePosition = 14;
    ((HeaderBase) ultraGridColumn67.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn67.Header.VisiblePosition = 15;
    ((HeaderBase) ultraGridColumn68.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn68.Header.VisiblePosition = 16 /*0x10*/;
    ((HeaderBase) ultraGridColumn69.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn69.Header.VisiblePosition = 17;
    ((HeaderBase) ultraGridColumn70.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn70.Header.VisiblePosition = 18;
    ((HeaderBase) ultraGridColumn71.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn71.Header.VisiblePosition = 19;
    ultraGridBand5.Columns.AddRange(new object[20]
    {
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
      (object) ultraGridColumn63,
      (object) ultraGridColumn64,
      (object) ultraGridColumn65,
      (object) ultraGridColumn66,
      (object) ultraGridColumn67,
      (object) ultraGridColumn68,
      (object) ultraGridColumn69,
      (object) ultraGridColumn70,
      (object) ultraGridColumn71
    });
    ((UltraGridBase) this.ddOffices).DisplayLayout.BandsSerializer.Add((object) ultraGridBand4);
    ((UltraGridBase) this.ddOffices).DisplayLayout.BandsSerializer.Add((object) ultraGridBand5);
    ((Control) this.ddOffices).Location = new Point(686, 322);
    ((Control) this.ddOffices).Name = "ddOffices";
    ((Control) this.ddOffices).Size = new Size(75, 23);
    ((Control) this.ddOffices).TabIndex = 21;
    ((Control) this.ddOffices).Text = "UltraDropDown2";
    ((Control) this.ddOffices).Visible = false;
    ((Control) this.chkShowWaived).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance23.BorderColor = Color.Gray;
    appearance23.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkShowWaived).Appearance = (AppearanceBase) appearance23;
    ((UltraToggleEditorBase) this.chkShowWaived).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkShowWaived).Location = new Point(644, 231);
    ((Control) this.chkShowWaived).Name = "chkShowWaived";
    ((Control) this.chkShowWaived).Size = new Size(119, 24);
    ((Control) this.chkShowWaived).TabIndex = 22;
    ((UltraToggleEditorBase) this.chkShowWaived).Text = "Show Waived Fees";
    ((UltraControlBase) this.chkShowWaived).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkShowWaived).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.lblWaivedBy).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance24.BackColor = Color.FromArgb(240 /*0xF0*/, 247, 253);
    appearance24.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance24).TextVAlignAsString = "Middle";
    ((ControlBase) this.lblWaivedBy).Appearance = (AppearanceBase) appearance24;
    this.lblWaivedBy.BorderStyleOuter = (UIElementBorderStyle) 4;
    ((ControlBase) this.lblWaivedBy).ForeColor = SystemColors.ActiveCaption;
    ((Control) this.lblWaivedBy).Location = new Point(490, 203);
    ((Control) this.lblWaivedBy).Name = "lblWaivedBy";
    ((Control) this.lblWaivedBy).Size = new Size(273, 23);
    ((Control) this.lblWaivedBy).TabIndex = 23;
    ((ControlBase) this.lblWaivedBy).Text = "Waived By ...";
    ((Control) this.lblWaivedBy).Visible = false;
    ((Control) this.panelPleaseWait).Anchor = AnchorStyles.Top;
    appearance25.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.panelPleaseWait.ContentAreaAppearance = (AppearanceBase) appearance25;
    ((Control) this.panelPleaseWait).Controls.Add((Control) this.Label1);
    ((Control) this.panelPleaseWait).Controls.Add((Control) this.PictureBox1);
    ((Control) this.panelPleaseWait).Location = new Point(212, 56);
    ((Control) this.panelPleaseWait).Name = "panelPleaseWait";
    ((Control) this.panelPleaseWait).Size = new Size(345, 84);
    ((Control) this.panelPleaseWait).TabIndex = 24;
    this.Label1.Font = new Font("Tahoma", 11f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label1.Location = new Point(55, 32 /*0x20*/);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(280, 21);
    this.Label1.TabIndex = 1;
    this.Label1.Text = "Please wait while the fees are loaded ...";
    this.PictureBox1.Image = (Image) componentResourceManager.GetObject("PictureBox1.Image");
    this.PictureBox1.Location = new Point(17, 26);
    this.PictureBox1.Name = "PictureBox1";
    this.PictureBox1.Size = new Size(32 /*0x20*/, 32 /*0x20*/);
    this.PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
    this.PictureBox1.TabIndex = 0;
    this.PictureBox1.TabStop = false;
    this.lnkAutoApplyLog.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.lnkAutoApplyLog.AutoSize = true;
    this.lnkAutoApplyLog.Location = new Point(682, 342);
    this.lnkAutoApplyLog.Name = "lnkAutoApplyLog";
    this.lnkAutoApplyLog.Size = new Size(81, 13);
    this.lnkAutoApplyLog.TabIndex = 25;
    this.lnkAutoApplyLog.TabStop = true;
    this.lnkAutoApplyLog.Text = "Auto-Apply Log";
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.ClientSize = new Size(769, 365);
    this.Controls.Add((Control) this.lnkAutoApplyLog);
    this.Controls.Add((Control) this.panelPleaseWait);
    this.Controls.Add((Control) this.lblWaivedBy);
    this.Controls.Add((Control) this.chkShowWaived);
    this.Controls.Add((Control) this.ddOffices);
    this.Controls.Add((Control) this.ddChargeCodes);
    this.Controls.Add((Control) this.dbSave);
    this.Controls.Add((Control) this.ugFees);
    this.Controls.Add((Control) this.panelControls);
    this.DoubleBuffered = true;
    this.Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ForeColor = Color.Black;
    this.Name = nameof (frmPolicyFees);
    this.Text = "Policy Fees";
    this.ds.EndInit();
    ((ISupportInitialize) this.txtAmount).EndInit();
    ((ISupportInitialize) this.err).EndInit();
    ((ISupportInitialize) this.panelControls).EndInit();
    ((Control) this.panelControls).ResumeLayout(false);
    ((Control) this.panelControls).PerformLayout();
    ((ISupportInitialize) this.cboFees).EndInit();
    ((ISupportInitialize) this.TblCompanyPolicyChargesBindingSource).EndInit();
    ((ISupportInitialize) this.txtMinimum).EndInit();
    ((ISupportInitialize) this.cboOffices).EndInit();
    ((ISupportInitialize) this.cboPercentOf).EndInit();
    this.dvChargeCodes.EndInit();
    ((ISupportInitialize) this.ugFees).EndInit();
    ((ISupportInitialize) this.ddChargeCodes).EndInit();
    ((ISupportInitialize) this.ddOffices).EndInit();
    ((ISupportInitialize) this.chkShowWaived).EndInit();
    ((ISupportInitialize) this.panelPleaseWait).EndInit();
    ((Control) this.panelPleaseWait).ResumeLayout(false);
    ((Control) this.panelPleaseWait).PerformLayout();
    ((ISupportInitialize) this.PictureBox1).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  public frmPolicyFees()
  {
    this.Load += new EventHandler(this.frmPolicyFees_Load);
    this.Closing += new CancelEventHandler(this.frmPolicyFees_Closing);
    this._gridLayout = new MemoryStream();
    this._feeVerified = true;
    this._restrictFeeList = new List<int>();
    this.waiveFeeOrTax = false;
    this.handled = false;
    this.rerunSave = false;
  }

  public frmPolicyFees(Guid quoteOptionGuid)
  {
    this.Load += new EventHandler(this.frmPolicyFees_Load);
    this.Closing += new CancelEventHandler(this.frmPolicyFees_Closing);
    this._gridLayout = new MemoryStream();
    this._feeVerified = true;
    this._restrictFeeList = new List<int>();
    this.waiveFeeOrTax = false;
    this.handled = false;
    this.rerunSave = false;
    this.InitializeComponent();
    this._quoteOptionGuid = quoteOptionGuid;
    this._cn = DefaultDatabase.CreateConnection();
  }

  private BindingManagerBase bmb
  {
    get => this.BindingContext[(object) this.ds, this.ds.tblQuoteOptionCharges.TableName];
  }

  protected Guid QuoteOptionGuid => this._quoteOptionGuid;

  protected Guid QuoteGuid => this._quoteGuid;

  protected Quote Quote => this._quote;

  protected override void Dispose(bool disposing)
  {
    if (disposing)
    {
      if (this.components != null)
        this.components.Dispose();
      if (this._cn != null)
        this._cn.Dispose();
    }
    base.Dispose(disposing);
  }

  private void ThreadedFill(object state)
  {
    try
    {
      Thread.Sleep(50);
      this._canReinstateFee = SecurityManager.Instance.AssertPermission("{22EF7D7A-3E7D-4dd1-B489-EA29D8B3B1F9}");
      this._canWaiveFee = SecurityManager.Instance.AssertPermission("{89510A95-E84D-415f-9AAA-A64DD6C03532}");
      this._canOverridePayee = SecurityManager.Instance.AssertPermission("{A55A17AA-E531-40F0-AB46-6A82B9799508}");
      this._canCreditNewFees = SecurityManager.Instance.AssertPermission("{7E42AE34-FE32-4892-BECE-F565F4D02455}");
      QuoteOption quoteOption = new QuoteOption(this._quoteOptionGuid);
      this._quote = ObjectFactory.Instance.CreateObjectAs<Quote>(new object[1]
      {
        (object) quoteOption.QuoteGuid
      });
      this._quoteGuid = quoteOption.QuoteGuid;
      try
      {
        this._quote.AutoApplyFees(this._quoteOptionGuid);
      }
      catch (SqlException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        if (ex.State != (byte) 123)
          throw;
        ProjectData.ClearProjectError();
      }
      this.ds.tblClientOffices.AddtblClientOfficesRow(string.Empty);
      try
      {
        DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[6]
        {
          "lstFeeTypes",
          "PolicyChargeCodes",
          "tblClientOffices",
          "tblQuoteOptionCharges",
          "tblCompanyPolicyCharges",
          "tblUsers"
        }, "GetPolicyFeesFormData", new object[2]
        {
          (object) "@QuoteOptionGuid",
          (object) this._quoteOptionGuid
        });
      }
      catch (ConstraintException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        InvokeExtensions.BetterInvoke((ISynchronizeInvoke) MDIControls.Instance.MDIParent, (Delegate) new frmPolicyFees.ShowConstraintErrorOnUIThreadHandler(this.ShowConstraintErrorOnUIThread), new object[1]
        {
          (object) ex
        });
        ProjectData.ClearProjectError();
      }
      if (!this.IsHandleCreated || this.IsDisposed || this.Disposing)
        return;
      InvokeExtensions.BetterInvoke((ISynchronizeInvoke) MDIControls.Instance.MDIParent, (Delegate) new frmPolicyFees.ThreadedFillCompleteHandler(this.ThreadedFillComplete), new object[0]);
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ErrorHandler.HandleErrorOnThread((Control) MDIControls.Instance.MDIParent, ex);
      ProjectData.ClearProjectError();
    }
  }

  private void ShowConstraintErrorOnUIThread(ConstraintException ex)
  {
    ErrorHandler.ShowDataSetErrors((DataSet) this.ds, ex);
  }

  private void ThreadedFillComplete()
  {
    try
    {
      this.mnuReinstate.Visible = this._canReinstateFee;
      this.mnuWaiveFee.Visible = this._canWaiveFee;
      this.mnuOverridePayee.Enabled = this._canOverridePayee;
      ((Control) this.dbSave).Enabled = !this._quote.IsBound;
      this.SetupDataBindings();
      this.dbSave.UIState = this.ds.tblQuoteOptionCharges.Count != 0 ? (UIState) 1 : (UIState) 0;
      this.ColorFeeDropdownRows();
      this.HideRestrictedFees();
      if (frmPolicyDetail.CurrentMultiCurrency && frmPolicyDetail.ImplementCurrencyDisplay)
        ((UltraGridBase) this.ugFees).DisplayLayout.Bands[0].Columns["Amount"].FormatInfo = (IFormatProvider) frmPolicyDetail.CurrentCultureInfo;
      ((UltraCombo) this.cboFees).ValueChanged += new EventHandler(this.cboFees_ValueChanged);
      ((Control) this.panelPleaseWait).Visible = false;
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
  }

  private void HideRestrictedFees()
  {
    DataTable dataTable = DefaultDatabase.ExecuteDataTable("GetFeeRestrictionsPerUser", new object[6]
    {
      (object) "@WholePolicy",
      (object) false,
      (object) "@QuoteGuid",
      (object) this._quote.QuoteGuid,
      (object) "@UserGuid",
      (object) CurrentUser.Instance.UserGUID
    });
    if (dataTable.Rows.Count <= 0)
      return;
    try
    {
      foreach (DataRow row in dataTable.Rows)
        this._restrictFeeList.Add(Conversions.ToInteger(row["ChargeCode"]));
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    foreach (UltraGridRow row in ((UltraGridBase) this.ugFees).Rows)
    {
      if (row.Cells["ChargeCode"].Value != DBNull.Value && row.Cells["ChargeCode"].Value != null)
      {
        if (dataTable.Select("ChargeCode=" + row.Cells["ChargeCode"].Value.ToString()).Length > 0)
          row.Hidden = true;
        else
          ((UltraGridBase) this.ugFees).ActiveRow = row;
      }
    }
  }

  private void ColorFeeDropdownRows()
  {
    foreach (UltraGridRow row in ((UltraGridBase) this.cboFees).Rows)
    {
      if ((bool) row.Cells["ExistedOnPriorTransaction"].Value)
        row.Appearance.ForeColor = Color.Gray;
      else if ((bool) row.Cells["Disabled"].Value)
        row.Appearance.ForeColor = Color.Red;
    }
  }

  private void SetupDataBindings()
  {
    MGASimpleComboBox cboOffices = this.cboOffices;
    ((UltraGridBase) cboOffices).DataSource = (object) this.ds.tblClientOffices;
    ((UltraDropDownBase) cboOffices).DisplayMember = "Location";
    ((UltraDropDownBase) cboOffices).ValueMember = "OfficeID";
    MGASimpleComboBox cboPercentOf = this.cboPercentOf;
    ((UltraGridBase) cboPercentOf).DataSource = (object) this.dvChargeCodes;
    ((UltraDropDownBase) cboPercentOf).DisplayMember = "ChargeName";
    ((UltraDropDownBase) cboPercentOf).ValueMember = "ChargeCode";
    UltraDropDown ddChargeCodes = this.ddChargeCodes;
    ((UltraGridBase) ddChargeCodes).DataSource = (object) this.ds.PolicyChargeCodes;
    ((UltraDropDownBase) ddChargeCodes).DisplayMember = "ChargeName";
    ((UltraDropDownBase) ddChargeCodes).ValueMember = "ChargeCode";
    UltraDropDown ddOffices = this.ddOffices;
    ((UltraGridBase) ddOffices).DataSource = (object) this.ds.tblClientOffices;
    ((UltraDropDownBase) ddOffices).DisplayMember = "Location";
    ((UltraDropDownBase) ddOffices).ValueMember = "OfficeID";
    ((UltraGridBase) this.ugFees).DataSource = (object) this.ds.tblQuoteOptionCharges;
    this._gridLayout.Position = 0L;
    ((UltraGridBase) this.ugFees).DisplayLayout.Load((Stream) this._gridLayout);
    ((UltraGridBase) this.ugFees).DisplayLayout.ScrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
  }

  private void frmPolicyFees_Load(object sender, EventArgs e)
  {
    this.dvChargeCodes.RowFilter = "0=1";
    this.ds.tblQuoteOptionCharges.DefaultView.RowFilter = "WaivedByUserGuid IS NULL";
    ((Control) this.dbSave).Enabled = false;
    SqlDataAdapter daOptionFees = this.daOptionFees;
    daOptionFees.SelectCommand.Connection = this._cn;
    daOptionFees.DeleteCommand.Connection = this._cn;
    daOptionFees.UpdateCommand.Connection = this._cn;
    daOptionFees.InsertCommand.Connection = this._cn;
    ((UltraGridBase) this.ugFees).DisplayLayout.Save((Stream) this._gridLayout);
    ((UltraGridBase) this.ugFees).DataSource = (object) null;
    this.SetupFeesComboAppearance();
    ThreadPool.QueueUserWorkItem(new WaitCallback(this.ThreadedFill));
  }

  private void SetupFeesComboAppearance()
  {
    UltraGridBand band = this.cboFees.DisplayLayout.Bands[0];
    band.ColHeadersVisible = true;
    band.Override.HeaderAppearance.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    band.Override.HeaderAppearance.ForeColor = Color.Black;
    ((HeaderBase) band.Columns["ChargeName"].Header).Caption = "Fee";
    ((HeaderBase) band.Columns["EffectiveDate"].Header).Caption = "Effective";
  }

  protected dsPolicyFees.tblQuoteOptionChargesRow CurrenttblQuoteOptionChargesRow
  {
    get
    {
      return ((UltraGridBase) this.ugFees).ActiveRow != null ? (((UltraGridBase) this.ugFees).ActiveRow.Cells["OptionFeeID"].Value != DBNull.Value ? this.ds.tblQuoteOptionCharges.FindByOptionFeeID((int) ((UltraGridBase) this.ugFees).ActiveRow.Cells["OptionFeeID"].Value) : (dsPolicyFees.tblQuoteOptionChargesRow) null) : (dsPolicyFees.tblQuoteOptionChargesRow) null;
    }
  }

  private void cboOffices_ValueChanged(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((UltraCombo) this.cboOffices).Text, string.Empty, false) == 0)
      return;
    this.dvChargeCodes.RowFilter = "OfficeID=" + ((UltraCombo) this.cboOffices).Value.ToString();
  }

  private void FeeTypeChanged(object sender, EventArgs e)
  {
    ((Control) this.txtMinimum).Enabled = !this.rbFlat.Checked;
  }

  private void ugFees_AfterRowActivate(object sender, EventArgs e)
  {
    if (this._convertingAutoFeeToManualFee || this._restrictFeeList.Contains(Conversions.ToInteger(((UltraGridBase) this.ugFees).ActiveRow.Cells["ChargeCode"].Value)))
      return;
    if (((UltraGridBase) this.ugFees).ActiveRow.Cells["WaivedByUserGuid"].Value != DBNull.Value)
    {
      ((Control) this.lblWaivedBy).Visible = true;
      this.mnuReinstate.Enabled = true;
      this.mnuManualFee.Enabled = false;
      ((ControlBase) this.lblWaivedBy).Text = "Waived by " + DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "SELECT LastName + @C + FirstName FROM tblUsers WHERE UserGuid=@UG", new object[4]
      {
        (object) "@UG",
        ((UltraGridBase) this.ugFees).ActiveRow.Cells["WaivedByUserGuid"].Value,
        (object) "@C",
        (object) ", "
      });
    }
    else
    {
      ((Control) this.lblWaivedBy).Visible = false;
      this.mnuReinstate.Enabled = false;
      this.mnuManualFee.Enabled = Conversions.ToBoolean(((UltraGridBase) this.ugFees).ActiveRow.Cells["AutoApplied"].Value);
    }
    if (this.CurrenttblQuoteOptionChargesRow == null)
      return;
    Database.MoveTo((object) this.CurrenttblQuoteOptionChargesRow.OptionFeeID, "OptionFeeID", (DataTable) this.ds.tblQuoteOptionCharges, this.bmb);
    dsPolicyFees.tblQuoteOptionChargesRow optionChargesRow = this.CurrenttblQuoteOptionChargesRow;
    foreach (UltraGridRow row in ((UltraGridBase) this.cboFees).Rows)
    {
      if ((int) row.Cells["CompanyFeeID"].Value == optionChargesRow.CompanyFeeID)
      {
        ((UltraDropDownBase) this.cboFees).SelectedRow = row;
        break;
      }
    }
    ((UltraCombo) this.cboOffices).Value = (object) optionChargesRow.OfficeID;
    this.rbFlat.Checked = !optionChargesRow.IsFlatRateNull();
    this.rbPercentagePremium.Checked = !optionChargesRow.IsPercentageRateNull() && optionChargesRow.IsPercentOfChargeCodeNull();
    this.rbPercentOf.Checked = !this.rbFlat.Checked && !this.rbPercentagePremium.Checked;
    Decimal num;
    if (this.rbPercentagePremium.Checked)
    {
      MGATextBox txtAmount = this.txtAmount;
      num = optionChargesRow.PercentageRate;
      string str = num.ToString();
      ((TextEditorControlBase) txtAmount).Text = str;
    }
    if (this.rbPercentOf.Checked)
    {
      ((UltraCombo) this.cboPercentOf).Value = (object) optionChargesRow.PercentOfChargeCode;
      MGATextBox txtAmount = this.txtAmount;
      num = optionChargesRow.PercentageRate;
      string str = num.ToString();
      ((TextEditorControlBase) txtAmount).Text = str;
    }
    else
      ((UltraDropDownBase) this.cboPercentOf).SelectedRow = (UltraGridRow) null;
    if (!optionChargesRow.IsFlatRateNull())
    {
      MGATextBox txtAmount = this.txtAmount;
      num = optionChargesRow.FlatRate;
      string str = num.ToString();
      ((TextEditorControlBase) txtAmount).Text = str;
    }
    if (!optionChargesRow.IsPercentageMinimumNull())
    {
      MGATextBox txtMinimum = this.txtMinimum;
      num = optionChargesRow.PercentageMinimum;
      string str = num.ToString();
      ((TextEditorControlBase) txtMinimum).Text = str;
    }
    else
      ((TextEditorControlBase) this.txtMinimum).Text = string.Empty;
  }

  private frmPolicyFees.ExistState FeeExists()
  {
    int ID = (int) ((UltraCombo) this.cboFees).Value;
    int chargeCode = this.ds.tblCompanyPolicyCharges.FindByID(ID).ChargeCode;
    Guid companyLineGuid = this.ds.tblCompanyPolicyCharges.FindByID(ID).CompanyLineGUID;
    int num1 = (int) ((UltraCombo) this.cboOffices).Value;
    int num2 = DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "SELECT COUNT(*) FROM tblQuoteOptionCharges WHERE QuoteOptionGuid=@QuoteOptionGuid AND ChargeCode=@ChargeCode AND OfficeID=@OfficeID AND CompanyLineGuid=@CompanyLineGuid", new object[8]
    {
      (object) "@QuoteOptionGuid",
      (object) this._quoteOptionGuid.ToString(),
      (object) "@ChargeCode",
      (object) chargeCode,
      (object) "@OfficeID",
      (object) num1,
      (object) "@CompanyLineGuid",
      (object) companyLineGuid
    });
    frmPolicyFees.ExistState existState1 = frmPolicyFees.ExistState.DoesntExist;
    if (num2 > 0)
      existState1 = frmPolicyFees.ExistState.Exists;
    DataRow[] dataRowArray = this.ds.tblQuoteOptionCharges.Select($"ChargeCode={chargeCode.ToString()} AND CompanyLineGuid='{companyLineGuid.ToString()}' AND OfficeID={num1.ToString()}");
    frmPolicyFees.ExistState existState2;
    if (dataRowArray.Length == 0)
    {
      existState2 = frmPolicyFees.ExistState.DoesntExist;
    }
    else
    {
      dsPolicyFees.tblQuoteOptionChargesRow dr = (dsPolicyFees.tblQuoteOptionChargesRow) dataRowArray[0];
      if (existState1 == frmPolicyFees.ExistState.Exists && !dr.IsWaivedByUserGuidNull())
      {
        if (MessageBox.Show("This fee already exists, but is waived.\n\nWould you like to reinstate this fee?", "Reinstate Fee?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        {
          this.ReinstateFee(false, dr);
          this._skipSave = true;
          existState2 = frmPolicyFees.ExistState.Reinstated;
        }
      }
      else
        existState2 = existState1;
    }
    return existState2;
  }

  private bool ValidForm()
  {
    bool flag = true;
    if (((TextEditorControlBase) this.txtAmount).Text.Contains("%"))
      ((TextEditorControlBase) this.txtAmount).Text = Parsing.PercentToDecimal(((TextEditorControlBase) this.txtAmount).Text).ToString();
    if (((UltraCombo) this.cboFees).Text.Length == 0 || ((UltraCombo) this.cboFees).Value == DBNull.Value)
    {
      this.err.SetError((Control) this.cboFees, "Please select a fee from the list.");
      flag = false;
    }
    else
      this.err.SetError((Control) this.cboFees, string.Empty);
    if (!Versioned.IsNumeric((object) ((TextEditorControlBase) this.txtAmount).Text))
    {
      this.err.SetError((Control) this.txtAmount, "Please enter a valid fee amount.");
      flag = false;
    }
    else if (Decimal.Compare(Conversions.ToDecimal(((TextEditorControlBase) this.txtAmount).Text), 0M) == 0)
    {
      this.err.SetError((Control) this.txtAmount, "The fee amount can not equal zero.");
      flag = false;
    }
    else if (!this.rbFlat.Checked && Decimal.Compare(Math.Abs(Conversions.ToDecimal(((TextEditorControlBase) this.txtAmount).Text)), 1M) >= 0)
    {
      this.err.SetError((Control) this.txtAmount, "Please enter a valid percentage.");
      flag = false;
    }
    else
      this.err.SetError((Control) this.txtAmount, string.Empty);
    if (((UltraCombo) this.cboOffices).Value == DBNull.Value || ((UltraCombo) this.cboOffices).Text.Length == 0)
    {
      this.err.SetError((Control) this.cboOffices, "Please select an office.");
      flag = false;
    }
    else
      this.err.SetError((Control) this.cboOffices, string.Empty);
    if (!this.rbFlat.Checked && !this.rbPercentagePremium.Checked && !this.rbPercentOf.Checked)
    {
      this.err.SetError((Control) this.rbFlat, "Please select the fee type.");
      flag = false;
    }
    else
      this.err.SetError((Control) this.rbFlat, string.Empty);
    if (flag && !this._convertingAutoFeeToManualFee && !this._editing && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.err.GetError((Control) this.cboFees), string.Empty, false) == 0 && this.FeeExists() == frmPolicyFees.ExistState.Exists)
    {
      this.err.SetError((Control) this.cboFees, "Fee Already Exists");
      flag = false;
    }
    else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.err.GetError((Control) this.cboFees), "Fee Already Exists", false) == 0)
      this.err.SetError((Control) this.cboFees, string.Empty);
    if (flag && this.rbFlat.Checked && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((TextEditorControlBase) this.txtAmount).Text, string.Empty, false) != 0 && Versioned.IsNumeric((object) ((TextEditorControlBase) this.txtAmount).Text) && Decimal.Compare(Conversions.ToDecimal(((TextEditorControlBase) this.txtAmount).Text), 9999999.99M) > 0)
    {
      this.err.SetError((Control) this.txtAmount, "Flat Rate cannot exceed " + Conversions.ToString(9999999.99M));
      flag = false;
    }
    else if (flag)
      this.err.SetError((Control) this.txtAmount, string.Empty);
    return flag;
  }

  private void FillFlatOrPercentageInfo(dsPolicyFees.tblQuoteOptionChargesRow dr)
  {
    if (this.rbFlat.Checked)
    {
      dr.SetPercentageRateNull();
      dr.SetPercentOfChargeCodeNull();
      dr.FlatRate = Conversions.ToDecimal(((TextEditorControlBase) this.txtAmount).Text);
    }
    else
    {
      dr.SetFlatRateNull();
      dr.PercentageRate = Conversions.ToDecimal(((TextEditorControlBase) this.txtAmount).Text);
      if (Versioned.IsNumeric((object) ((TextEditorControlBase) this.txtMinimum).Text))
        dr.PercentageMinimum = Conversions.ToDecimal(((TextEditorControlBase) this.txtMinimum).Text);
      else
        dr.SetPercentageMinimumNull();
      if (this.rbPercentagePremium.Checked)
        dr.SetPercentOfChargeCodeNull();
      else
        dr.PercentOfChargeCode = Conversions.ToInteger(((UltraCombo) this.cboPercentOf).Value);
    }
  }

  private void FillRowValues(int ID, dsPolicyFees.tblQuoteOptionChargesRow dr)
  {
    if (dr.RowState == DataRowState.Added || dr.CompanyFeeID != this.ds.tblCompanyPolicyCharges.FindByID(ID).CompanyFeeID)
    {
      if (!this.ds.tblCompanyPolicyCharges.FindByID(ID).IsPayeeNull())
        dr.Payee = this.ds.tblCompanyPolicyCharges.FindByID(ID).Payee;
      else
        dr.SetPayeeNull();
      dr.SetPayeeOverrideNull();
    }
    this.FillFlatOrPercentageInfo(dr);
    dr.AutoApplied = false;
    dr.ChargeName = ((UltraCombo) this.cboFees).Text;
    dr.OfficeID = Conversions.ToInteger(((UltraCombo) this.cboOffices).Value);
    dr.QuoteOptionGuid = this._quoteOptionGuid;
    dsPolicyFees.tblCompanyPolicyChargesRow byId = this.ds.tblCompanyPolicyCharges.FindByID(ID);
    dr.CompanyLineGuid = byId.CompanyLineGUID;
    dr.FeeTypeID = byId.FeeTypeID;
    dr.Payable = byId.Payable;
    dr.Splittable = byId.Splittable;
    dr.Taxable = byId.Taxable;
    dr.ChargeCode = byId.ChargeCode;
    dr.FeeType = this.ds.lstFeeTypes.FindByID(dr.FeeTypeID).FeeType;
    dr.Amount = Convert.ToDecimal(((TextEditorControlBase) this.txtAmount).Text);
  }

  private void cboFees_ValueChanged(object sender, EventArgs e)
  {
    if (((UltraCombo) this.cboFees).Value == null)
    {
      ((ControlBase) this.lblFeeType).Text = string.Empty;
    }
    else
    {
      dsPolicyFees.tblCompanyPolicyChargesRow byId = this.ds.tblCompanyPolicyCharges.FindByID((int) ((UltraCombo) this.cboFees).Value);
      if (!byId.IsFlatRateNull())
      {
        this.rbFlat.Checked = true;
        ((TextEditorControlBase) this.txtAmount).Text = byId.FlatRate.ToString();
      }
      else
      {
        this.rbPercentagePremium.Checked = true;
        ((TextEditorControlBase) this.txtAmount).Text = byId.PercentageRate.ToString();
      }
      ((ControlBase) this.lblFeeType).Text = this.ds.lstFeeTypes.FindByID(byId.FeeTypeID).FeeType;
    }
  }

  private void DeleteFee(int optionFeeID)
  {
    DefaultDatabase.ExecuteNonQuery(CommandType.Text, "DELETE FROM tblQuoteOptionCharges WHERE OptionFeeID=@OptionFeeID", new object[2]
    {
      (object) "@OptionFeeID",
      (object) optionFeeID
    });
    CurrentUser.Instance.LogAction($"Delete Fee - Charge '{this.CurrenttblQuoteOptionChargesRow.ChargeName}'", this._quoteGuid);
    this.ds.tblQuoteOptionCharges.RemovetblQuoteOptionChargesRow(this.CurrenttblQuoteOptionChargesRow);
    this.ds.tblQuoteOptionCharges.AcceptChanges();
    this.ClientDeleteFee();
    if (this.ds.tblQuoteOptionCharges.Count == 0)
      this.dbSave.UIState = (UIState) 0;
    else
      this.dbSave.UIState = (UIState) 1;
  }

  protected virtual void ClientDeleteFee()
  {
  }

  private void HandleDeleteException(int optionFeeID, SqlException ex)
  {
    if (ex.Message.Contains("FK_tblPolicyCommissions_tblQuoteOptionCharges"))
    {
      if (DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "SELECT COUNT(*) FROM tblPolicyCommissions WHERE OptionFeeID=@OptionFeeID", new object[2]
      {
        (object) "@OptionFeeID",
        (object) optionFeeID
      }) > 0)
      {
        if (MessageBox.Show("There are entities set to receive commission on this fee.\n\nWould you like to remove these entities and delete the fee?", "Remove Commissionable Entities?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
          return;
        DefaultDatabase.ExecuteNonQuery(CommandType.Text, "DELETE FROM tblPolicyCommissions WHERE OptionFeeID=@OptionFeeID", new object[2]
        {
          (object) "@OptionFeeID",
          (object) optionFeeID
        });
        this.DeleteFee(optionFeeID);
      }
      else
      {
        DefaultDatabase.ExecuteNonQuery(CommandType.Text, "DELETE FROM tblPolicyCommissions WHERE OptionFeeID=@OptionFeeID", new object[2]
        {
          (object) "@OptionFeeID",
          (object) optionFeeID
        });
        this.DeleteFee(optionFeeID);
      }
    }
    else
    {
      int num = (int) MessageBox.Show("An error occured while trying to save these fees.\n\n" + ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
    }
  }

  private void CollectSQLConnectionErrors(object sender, SqlInfoMessageEventArgs e)
  {
    if (this.handled)
      return;
    int num1 = e.Errors.Count - 1;
    for (int index = 0; index <= num1; ++index)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(e.Errors[index].Procedure, "VerifySufficientFeesForCredit", false) == 0)
      {
        if (this._canCreditNewFees)
        {
          if (MessageBox.Show(e.Errors[index].Message + "\nSave fees anyway?", "Override Insufficient Fees For Credit", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
          {
            try
            {
              dsPolicyFees.tblQuoteOptionChargesDataTable quoteOptionCharges = this.ds.tblQuoteOptionCharges;
              System.Func<dsPolicyFees.tblQuoteOptionChargesRow, bool> predicate;
              // ISSUE: reference to a compiler-generated field
              if (frmPolicyFees._Closure\u0024__.\u0024I140\u002D0 != null)
              {
                // ISSUE: reference to a compiler-generated field
                predicate = frmPolicyFees._Closure\u0024__.\u0024I140\u002D0;
              }
              else
              {
                // ISSUE: reference to a compiler-generated field
                frmPolicyFees._Closure\u0024__.\u0024I140\u002D0 = predicate = (System.Func<dsPolicyFees.tblQuoteOptionChargesRow, bool>) ([SpecialName] (qo) => qo.RowState == DataRowState.Modified || qo.RowState == DataRowState.Added);
              }
              foreach (dsPolicyFees.tblQuoteOptionChargesRow optionChargesRow in quoteOptionCharges.Where<dsPolicyFees.tblQuoteOptionChargesRow>(predicate))
                optionChargesRow.ForceSavedBy = CurrentUser.Instance.UserGUID;
            }
            finally
            {
              IEnumerator<dsPolicyFees.tblQuoteOptionChargesRow> enumerator;
              enumerator?.Dispose();
            }
            this.rerunSave = true;
            break;
          }
          break;
        }
        int num2 = (int) MessageBox.Show(e.Errors[index].Message, "Insufficient Fees For Credit", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        break;
      }
    }
    this.handled = true;
  }

  protected bool SaveChanges()
  {
    bool flag;
    if (this.ds.HasChanges())
    {
      SqlTransaction tran = (SqlTransaction) null;
      SqlConnection connection = DefaultDatabase.CreateConnection();
      try
      {
        Cursor.Current = MgaCursors.WaitCursor;
        connection.Open();
        connection.InfoMessage -= new SqlInfoMessageEventHandler(this.CollectSQLConnectionErrors);
        connection.InfoMessage += new SqlInfoMessageEventHandler(this.CollectSQLConnectionErrors);
        tran = connection.BeginTransaction();
        MDIControls.Instance.StatusBarText = "Saving fees...";
        SqlDataAdapter daOptionFees1 = this.daOptionFees;
        daOptionFees1.SelectCommand.Connection = connection;
        daOptionFees1.DeleteCommand.Connection = connection;
        daOptionFees1.UpdateCommand.Connection = connection;
        daOptionFees1.InsertCommand.Connection = connection;
        SqlDataAdapter daOptionFees2 = this.daOptionFees;
        daOptionFees2.SelectCommand.Transaction = tran;
        daOptionFees2.UpdateCommand.Transaction = tran;
        daOptionFees2.InsertCommand.Transaction = tran;
        dsPolicyFees.tblQuoteOptionChargesDataTable quoteOptionCharges = this.ds.tblQuoteOptionCharges;
        System.Func<dsPolicyFees.tblQuoteOptionChargesRow, bool> predicate;
        // ISSUE: reference to a compiler-generated field
        if (frmPolicyFees._Closure\u0024__.\u0024I142\u002D0 != null)
        {
          // ISSUE: reference to a compiler-generated field
          predicate = frmPolicyFees._Closure\u0024__.\u0024I142\u002D0;
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          frmPolicyFees._Closure\u0024__.\u0024I142\u002D0 = predicate = (System.Func<dsPolicyFees.tblQuoteOptionChargesRow, bool>) ([SpecialName] (qo) => qo.RowState == DataRowState.Modified || qo.RowState == DataRowState.Added);
        }
        dsPolicyFees.tblQuoteOptionChargesRow[] array = quoteOptionCharges.Where<dsPolicyFees.tblQuoteOptionChargesRow>(predicate).ToArray<dsPolicyFees.tblQuoteOptionChargesRow>();
        this.daOptionFees.Update((DataRow[]) array);
        if (this.rerunSave)
        {
          this.rerunSave = false;
          dsPolicyFees.tblQuoteOptionChargesRow[] optionChargesRowArray = array;
          int index = 0;
          while (index < optionChargesRowArray.Length)
          {
            dsPolicyFees.tblQuoteOptionChargesRow optionChargesRow = optionChargesRowArray[index];
            if (optionChargesRow.RowState == DataRowState.Unchanged)
            {
              if (optionChargesRow.IsNull("OptionFeeID"))
                optionChargesRow.SetAdded();
              else
                optionChargesRow.SetModified();
            }
            checked { ++index; }
          }
          tran.Rollback();
          connection.Close();
          flag = this.SaveChanges();
          goto label_32;
        }
        this.ClientSave(tran);
        tran.Commit();
        this.ds.tblQuoteOptionCharges.AcceptChanges();
        flag = true;
        goto label_32;
      }
      catch (SqlException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        SqlException sqlException = ex;
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(sqlException.Procedure, "VerifySufficientPremiumForCredit", false) == 0)
        {
          int num1 = (int) MessageBox.Show(sqlException.Message, "Insufficient Premium For Credit", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(sqlException.Procedure, "CantModifyFeesOnBoundPolicy", false) == 0)
        {
          int num2 = (int) MessageBox.Show(sqlException.Message, "Policy Is Now Bound", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        else if (sqlException.Message.Contains("IX_UniqueFees"))
        {
          int num3 = (int) MessageBox.Show("This fee already exists on this policy and can not be re-added.", "Duplicate Fee", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        else
          ErrorHandler.HandleError((Exception) sqlException);
        flag = false;
        ProjectData.ClearProjectError();
        goto label_32;
      }
      catch (DBConcurrencyException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        int num = (int) MessageBox.Show("Another user has modified this data while you were working with it.\nPlease exit the screen and come back in to ensure you are working with the most recent copy of this data.", "Save Failed", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        ProjectData.ClearProjectError();
      }
      finally
      {
        SqlDataAdapter daOptionFees = this.daOptionFees;
        daOptionFees.SelectCommand.Connection = this._cn;
        daOptionFees.DeleteCommand.Connection = this._cn;
        daOptionFees.UpdateCommand.Connection = this._cn;
        daOptionFees.InsertCommand.Connection = this._cn;
        tran?.Dispose();
        if (connection != null)
        {
          connection.Close();
          connection.Dispose();
        }
        this.handled = false;
        MDIControls.Instance.StatusBarText = string.Empty;
        Cursor.Current = MgaCursors.Default;
      }
      if (!this.ds.EnforceConstraints)
        this.ds.EnforceConstraints = true;
      this._convertingAutoFeeToManualFee = false;
    }
label_32:
    return flag;
  }

  protected void UpdateFeeAmounts(List<string> logList)
  {
    DataTable dataTable = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT OptionFeeID, ISNULL(Amount, 0) Amount, dbo.GetEntityName(dbo.CalculatePayableEntityGuid(OptionFeeID)) EntityName FROM tblQuoteOptionCharges WHERE QuoteOptionGuid = @optionGuid AND WaivedByUserGuid IS NULL", new object[2]
    {
      (object) "@optionGuid",
      (object) this._quoteOptionGuid
    });
    try
    {
      foreach (DataRow row in dataTable.Rows)
      {
        dsPolicyFees.tblQuoteOptionChargesRow byOptionFeeId = this.ds.tblQuoteOptionCharges.FindByOptionFeeID(row.Field<int>(0));
        if (byOptionFeeId != null)
        {
          if (logList != null && byOptionFeeId.IsFlatRateNull() && Decimal.Compare(byOptionFeeId.Amount, row.Field<Decimal>(1)) != 0)
            logList.Add($"Updated Fee - '{byOptionFeeId.ChargeName}'. Amount recalculated from '{byOptionFeeId.Amount:G}' to '{RuntimeHelpers.GetObjectValue(row[1]):G}'.");
          byOptionFeeId.Amount = row.Field<Decimal>(1);
          byOptionFeeId.SetField<object>("Payee", RuntimeHelpers.GetObjectValue(row[2]));
          byOptionFeeId.AcceptChanges();
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

  protected virtual void ClientSave(SqlTransaction tran)
  {
  }

  private void frmPolicyFees_Closing(object sender, CancelEventArgs e)
  {
    if (this.MdiParent == null)
      return;
    Form[] mdiChildren = this.MdiParent.MdiChildren;
    int index = 0;
    while (index < mdiChildren.Length)
    {
      if (mdiChildren[index] is frmPolicyDetail frmPolicyDetail)
        frmPolicyDetail.RefreshPremiums();
      checked { ++index; }
    }
  }

  protected void WaiveFee()
  {
    if (!this._canWaiveFee)
    {
      if (!this.waiveFeeOrTax)
        return;
      int num = (int) MessageBox.Show("You do not have the authority to waive this fee.  Please contact your administrator.", "Waive Fee", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else
    {
      UltraGridRow activeRow = ((UltraGridBase) this.ugFees).ActiveRow;
      if (activeRow == null)
      {
        int num1 = (int) MessageBox.Show("Please select the fee you would like to waive from the grid above. ", "No Fee Selected", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
      else
      {
        string chargeName = this.CurrenttblQuoteOptionChargesRow.ChargeName;
        if (MessageBox.Show("Are you sure you want to waive the following auto-applied fee?\n\n" + chargeName, "Waive Auto-Applied Fee?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
          return;
        this.CurrenttblQuoteOptionChargesRow.WaivedByUserGuid = CurrentUser.Instance.UserGUID;
        frmPolicyFees.ColorWaivedFeeRows(activeRow);
        try
        {
          this.SaveChanges();
          CurrentUser.Instance.LogAction("Waived Fee - " + chargeName, this._quote.QuoteGuid);
        }
        catch (SqlException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          int num2 = (int) MessageBox.Show("An error occured while trying to waive the fee:\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          ProjectData.ClearProjectError();
        }
      }
    }
  }

  protected virtual void ClientWaiveFeeOrTax()
  {
  }

  private void chkShowWaived_CheckedChanged(object sender, EventArgs e)
  {
    if (((UltraToggleEditorBase) this.chkShowWaived).Checked)
    {
      this.ds.tblQuoteOptionCharges.DefaultView.RowFilter = string.Empty;
      this.ColorWaivedFeeRows();
    }
    else
      this.ds.tblQuoteOptionCharges.DefaultView.RowFilter = "WaivedByUserGuid IS NULL";
  }

  protected static void ColorWaivedFeeRows(UltraGridRow row)
  {
    if (row.Cells["WaivedByUserGuid"].Value != DBNull.Value)
    {
      row.Appearance.ForeColor = Color.Red;
      row.Appearance.FontData.Strikeout = (DefaultableBoolean) 1;
    }
    else
    {
      row.Appearance.ForeColor = SystemColors.ControlText;
      row.Appearance.FontData.Strikeout = (DefaultableBoolean) 2;
    }
  }

  private void ColorWaivedFeeRows()
  {
    foreach (UltraGridRow row in ((UltraGridBase) this.ugFees).Rows)
    {
      if (row.Cells["WaivedByUserGuid"].Value != DBNull.Value)
        frmPolicyFees.ColorWaivedFeeRows(row);
    }
  }

  private void ReinstateFee(bool askUser, dsPolicyFees.tblQuoteOptionChargesRow dr)
  {
    // ISSUE: unable to decompile the method.
  }

  private void mnuReinstate_Click(object sender, EventArgs e)
  {
    if (!this._canReinstateFee)
      return;
    this.ReinstateFee(true, this.CurrenttblQuoteOptionChargesRow);
  }

  private void cm_Popup(object sender, EventArgs e)
  {
    UIElement lastElementEntered = ((ControlUIElementBase) ((UltraGridBase) this.ugFees).DisplayLayout.UIElement).LastElementEntered;
    bool isBound = this._quote.IsBound;
    if (lastElementEntered == null)
      return;
    object objectValue = RuntimeHelpers.GetObjectValue(lastElementEntered.GetContext(typeof (UltraGridRow), true));
    if (objectValue != null)
    {
      UltraGridRow ultraGridRow = (UltraGridRow) objectValue;
      ultraGridRow.Activate();
      this.mnuManualFee.Enabled = Conversions.ToBoolean(ultraGridRow.Cells["AutoApplied"].Value) && !isBound;
      this.mnuWaiveFee.Enabled = Conversions.ToBoolean(ultraGridRow.Cells["AutoApplied"].Value) && !isBound && this._canWaiveFee;
      this.mnuReinstate.Enabled = this.mnuReinstate.Enabled && this._canReinstateFee;
      this.mnuOverridePayee.Visible = ultraGridRow.Cells["WaivedByUserGuid"].Value == DBNull.Value && !isBound && this._canOverridePayee;
      this.mnuResetPayee.Visible = ultraGridRow.Cells["WaivedByUserGuid"].Value == DBNull.Value && ultraGridRow.Cells["PayeeOverride"].Value != DBNull.Value && this._canOverridePayee;
      this.ClientMenuPopup(Conversions.ToBoolean(ultraGridRow.Cells["AutoApplied"].Value), isBound);
      this.ugFees.Selected.Rows.Clear();
      ultraGridRow.Selected = true;
    }
    else
    {
      this.mnuManualFee.Enabled = false;
      this.mnuWaiveFee.Enabled = false;
      this.mnuReinstate.Enabled = false;
      this.mnuOverridePayee.Visible = false;
      this.mnuResetPayee.Visible = false;
      this.ClientMenuPopup(false, false);
    }
  }

  protected virtual void ClientMenuPopup(bool isAutoApplied, bool isBound)
  {
  }

  private void mnuOverridePayee_Click(object sender, EventArgs e)
  {
    if (!this._canOverridePayee || this.CurrenttblQuoteOptionChargesRow == null)
      return;
    using (frmSelectEntity formEx = (frmSelectEntity) ObjectFactory.Instance.CreateFormEX(typeof (frmSelectEntity), new object[0]))
    {
      int num = (int) ((Form) formEx).ShowDialog();
      if (formEx.EntityGuid.Equals(Guid.Empty))
        return;
      this.ConvertFeeToManual();
      this.CurrenttblQuoteOptionChargesRow.Payee = formEx.EntityName;
      this.CurrenttblQuoteOptionChargesRow.PayeeOverride = formEx.EntityGuid;
    }
  }

  private void mnuResetPayee_Click(object sender, EventArgs e)
  {
    if (!this._canOverridePayee || this.CurrenttblQuoteOptionChargesRow == null || this.CurrenttblQuoteOptionChargesRow.IsPayeeOverrideNull())
      return;
    dsPolicyFees.tblQuoteOptionChargesRow optionChargesRow = this.CurrenttblQuoteOptionChargesRow;
    string empty = string.Empty;
    object objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "UPDATE dbo.tblQuoteOptionCharges SET PayeeOverride = NULL WHERE OptionFeeID = @feeID;SELECT dbo.GetEntityName(dbo.CalculatePayableEntityGuid(@feeID))", new object[2]
    {
      (object) "@feeID",
      (object) optionChargesRow.OptionFeeID
    }));
    if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(objectValue)))
      empty = objectValue.ToString();
    optionChargesRow.SetPayeeOverrideNull();
    optionChargesRow.Payee = empty;
    optionChargesRow.AcceptChanges();
    CurrentUser.Instance.LogAction($"Modified Fee - '{optionChargesRow.ChargeName}'. Clear Payee override. Reset Payee to '{(string.IsNullOrEmpty(empty) ? "<Blank>" : empty)}'.", this._quoteGuid);
  }

  private void mnuManualFee_Click(object sender, EventArgs e) => this.ConvertFeeToManual();

  private void mnuWaiveFee_Click(object sender, EventArgs e)
  {
    if (!this._canWaiveFee)
      return;
    this.WaiveFee();
  }

  private void dbSave_ClickingEdit(object sender, CancelEventArgs e)
  {
    if (this.ds.tblQuoteOptionCharges[this.bmb.Position].RowState == DataRowState.Deleted)
    {
      e.Cancel = true;
    }
    else
    {
      if (this.ds.tblQuoteOptionCharges.Count == 0)
        throw new InvalidOperationException("Edit button should not be enabled when there are no fees.");
      if (this.ds.tblQuoteOptionCharges[this.bmb.Position].AutoApplied)
      {
        if (MessageBox.Show("Auto-applied fees can not be edited.\n\nWould you like to convert this to a manual fee?", "Convert To Manual?", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
          this.mnuManualFee_Click(RuntimeHelpers.GetObjectValue(sender), EventArgs.Empty);
        else
          e.Cancel = true;
        e.Cancel = true;
      }
      else
        this._editing = true;
    }
  }

  private void dbSave_ClickedCancel(object sender, EventArgs e)
  {
    try
    {
      foreach (Control control in ((Control) this.panelControls).Controls)
        this.err.SetError(control, string.Empty);
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    if (this.bmb.Position <= -1)
      return;
    this.ds.tblQuoteOptionCharges[this.bmb.Position]?.RejectChanges();
  }

  private void dbSave_UIStateChanged(object sender, EventArgs e)
  {
    bool flag = this.dbSave.UIState == 2;
    ((Control) this.panelControls).Enabled = flag;
    ((Control) this.ugFees).Enabled = !flag;
    if (flag)
      return;
    if (((UltraGridBase) this.ugFees).Rows.Count == 0)
      this.dbSave.UIState = (UIState) 0;
    else
      this.dbSave.UIState = (UIState) 1;
  }

  private void dbSave_ClickedNew(object sender, EventArgs e)
  {
    try
    {
      foreach (Control control in ((Control) this.panelControls).Controls)
      {
        if (control is MGASimpleComboBox mgaSimpleComboBox)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(control.Name, "cboFees", false) != 0)
          {
            if (((UltraGridBase) mgaSimpleComboBox).Rows.Count == 1 || ((UltraGridBase) mgaSimpleComboBox).Rows.Count == 2)
              ((UltraDropDownBase) mgaSimpleComboBox).SelectedRow = ((UltraGridBase) mgaSimpleComboBox).Rows[((UltraGridBase) mgaSimpleComboBox).Rows.Count - 1];
            else
              ((UltraDropDownBase) mgaSimpleComboBox).SelectedRow = (UltraGridRow) null;
          }
          else if (((UltraGridBase) this.cboFees).Rows.Count == 1)
            ((UltraDropDownBase) this.cboFees).SelectedRow = ((UltraGridBase) this.cboFees).Rows[((UltraGridBase) this.cboFees).Rows.Count - 1];
          else
            ((UltraDropDownBase) this.cboFees).SelectedRow = (UltraGridRow) null;
        }
        else if (control is MGATextBox || control == this.lblFeeType)
          control.Text = string.Empty;
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    this._editing = false;
  }

  private void dbSave_ClickingDelete(object sender, CancelEventArgs e)
  {
    if (((UltraGridBase) this.ugFees).ActiveRow == null)
    {
      int num = (int) MessageBox.Show("Please select the fee you would like to delete from the grid above.", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else if (Conversions.ToBoolean(((UltraGridBase) this.ugFees).ActiveRow.Cells["AutoApplied"].Value))
    {
      if (this.waiveFeeOrTax)
        this.ClientWaiveFeeOrTax();
      else
        this.WaiveFee();
    }
    else
    {
      if (this.CurrenttblQuoteOptionChargesRow == null || MessageBox.Show("Are you sure you want to delete this fee?", "Delete Fee?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
        return;
      Cursor.Current = MgaCursors.WaitCursor;
      int optionFeeId = this.CurrenttblQuoteOptionChargesRow.OptionFeeID;
      try
      {
        this.DeleteFee(optionFeeId);
      }
      catch (SqlException ex1)
      {
        ProjectData.SetProjectError((Exception) ex1);
        SqlException ex2 = ex1;
        this.HandleDeleteException(optionFeeId, ex2);
        ProjectData.ClearProjectError();
      }
      finally
      {
        Cursor.Current = MgaCursors.Default;
      }
    }
  }

  private void dbSave_ClickingSave(object sender, CancelEventArgs e)
  {
    if (!((Control) this.panelControls).Enabled)
      return;
    if (!this.ValidForm())
      e.Cancel = true;
    else if (this._skipSave)
      this._skipSave = false;
    else if (((UltraCombo) this.cboFees).Value == DBNull.Value || ((UltraCombo) this.cboFees).Value == null)
    {
      e.Cancel = true;
    }
    else
    {
      this._skipSave = false;
      int ID = (int) ((UltraCombo) this.cboFees).Value;
      int companyFeeId = this.ds.tblCompanyPolicyCharges.FindByID(ID).CompanyFeeID;
      dsPolicyFees.tblQuoteOptionChargesRow optionChargesRow;
      if (this._editing)
      {
        if (this.bmb.Position == -1 || this.ds.tblQuoteOptionCharges[this.bmb.Position].RowState == DataRowState.Deleted)
          return;
        optionChargesRow = this.ds.tblQuoteOptionCharges[this.bmb.Position];
      }
      else
      {
        optionChargesRow = this.ds.tblQuoteOptionCharges.NewtblQuoteOptionChargesRow();
        optionChargesRow.AppliesToPaymentID = this.ds.tblCompanyPolicyCharges.FindByID(ID).AppliesToPaymentID;
        optionChargesRow.CompanyFeeID = companyFeeId;
      }
      this.FillRowValues(ID, optionChargesRow);
      if (!this._editing)
      {
        this.ds.EnforceConstraints = false;
        this.ds.tblQuoteOptionCharges.AddtblQuoteOptionChargesRow(optionChargesRow);
      }
      else if (optionChargesRow.CompanyFeeID != companyFeeId)
        optionChargesRow.CompanyFeeID = this.ds.tblCompanyPolicyCharges.FindByID(ID).CompanyFeeID;
      List<string> logList = new List<string>();
      this.LogFeeChanges(this._editing, optionChargesRow, logList);
      bool flag = this.SaveChanges();
      if (flag && this._feeVerified)
      {
        this.UpdateFeeAmounts(logList);
        if (flag)
        {
          try
          {
            foreach (string str in logList)
              CurrentUser.Instance.LogAction(str, this._quoteGuid);
          }
          finally
          {
            List<string>.Enumerator enumerator;
            enumerator.Dispose();
          }
        }
        this._convertingAutoFeeToManualFee = false;
      }
      else
      {
        if (!this._editing)
          this.ds.tblQuoteOptionCharges.RemovetblQuoteOptionChargesRow(optionChargesRow);
        e.Cancel = true;
      }
    }
  }

  private void lnkAutoApplyLog_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    using (FormSettings.ShowFormDialog(typeof (frmGenericInfo), new object[2]
    {
      (object) "Fee Auto-Apply Log:",
      (object) new StringBuilder(Utility.IsNull<string>(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT AutoApplyFeeLog FROM tblQuoteOptions WHERE QuoteOptionGuid = @QOG", new object[2]
      {
        (object) "@QOG",
        (object) this._quoteOptionGuid
      }))), string.Empty))
    }))
      ;
  }

  private void ConvertFeeToManual()
  {
    if (this.CurrenttblQuoteOptionChargesRow == null)
      return;
    if (this.CurrenttblQuoteOptionChargesRow.AutoApplied)
    {
      this.AddMissingCharge(this.CurrenttblQuoteOptionChargesRow);
      dsPolicyFees.tblQuoteOptionChargesRow optionChargesRow = this.CurrenttblQuoteOptionChargesRow;
      optionChargesRow.AutoApplied = false;
      optionChargesRow.ConvertedToManualUserGuid = CurrentUser.Instance.UserGUID;
      this._convertingAutoFeeToManualFee = true;
    }
    ((UltraCombo) this.cboFees).Value = (object) ((dsPolicyFees.tblCompanyPolicyChargesRow) this.ds.tblCompanyPolicyCharges.Select($"CompanyFeeID={this.CurrenttblQuoteOptionChargesRow.CompanyFeeID.ToString()} AND CompanyLineGuid='{this.CurrenttblQuoteOptionChargesRow.CompanyLineGuid.ToString()}'")[0]).ID;
    ((UltraCombo) this.cboOffices).Value = (object) this.CurrenttblQuoteOptionChargesRow.OfficeID;
    this.dbSave.UIState = (UIState) 2;
    this._editing = true;
  }

  private void AddMissingCharge(dsPolicyFees.tblQuoteOptionChargesRow qoCharge)
  {
    if (this.ds.tblCompanyPolicyCharges.Select($"CompanyFeeID={qoCharge.CompanyFeeID.ToString()} AND CompanyLineGuid='{this.CurrenttblQuoteOptionChargesRow.CompanyLineGuid.ToString()}'").Length != 0)
      return;
    dsPolicyFees.tblQuoteOptionChargesRow optionChargesRow = qoCharge;
    dsPolicyFees.tblCompanyPolicyChargesRow row = this.ds.tblCompanyPolicyCharges.NewtblCompanyPolicyChargesRow();
    row.ChargeCode = optionChargesRow.ChargeCode;
    row.CompanyLineGUID = optionChargesRow.CompanyLineGuid;
    row.ChargeName = optionChargesRow.ChargeName;
    row.FeeTypeID = optionChargesRow.FeeTypeID;
    row.Taxable = optionChargesRow.Taxable;
    row.AppliesToPaymentID = optionChargesRow.AppliesToPaymentID;
    if (optionChargesRow.IsFlatRateNull())
      row.SetFlatRateNull();
    else
      row.FlatRate = optionChargesRow.FlatRate;
    row.Payable = optionChargesRow.Payable;
    if (optionChargesRow.IsPercentageRateNull())
      row.SetPercentageRateNull();
    else
      row.PercentageRate = optionChargesRow.PercentageRate;
    row.Splittable = optionChargesRow.Splittable;
    row.CompanyFeeID = optionChargesRow.CompanyFeeID;
    if (!optionChargesRow.IsPayeeNull())
      row.Payee = optionChargesRow.Payee;
    object objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT PayableEntityGuid FROM tblCompanyPolicyCharges WHERE CompanyFeeID = @CFID", new object[2]
    {
      (object) "@CFID",
      (object) row.CompanyFeeID
    }));
    if (objectValue != DBNull.Value)
      row.PayableEntityGuid = (Guid) objectValue;
    row.ExistedOnPriorTransaction = false;
    row.Disabled = false;
    this.ds.tblCompanyPolicyCharges.AddtblCompanyPolicyChargesRow(row);
  }

  private void LogFeeChanges(
    bool _editing,
    dsPolicyFees.tblQuoteOptionChargesRow dr,
    List<string> logList)
  {
    if (!_editing)
    {
      CurrentUser.Instance.LogAction($"Add Fee - Charge '{dr.ChargeName}'", this._quoteGuid);
    }
    else
    {
      string str1 = "SELECT ChargeName FROM tblFin_PolicyCharges WITH (NOLOCK) WHERE (ChargeCode = @CC)";
      try
      {
        foreach (DataColumn column in (InternalDataCollectionBase) this.ds.tblQuoteOptionCharges.Columns)
        {
          if (!column.ColumnName.Equals("CompanyLineGuid") && !column.ColumnName.Equals("QuoteOptionGuid") && !column.ColumnName.Equals("ChargeName") && !column.ColumnName.Equals("OptionFeeID") && !column.ColumnName.Equals("PayeeOverride") && !column.ColumnName.Equals("Amount"))
          {
            string g1 = "<Blank>";
            string g2 = "<Blank>";
            string columnName = column.ColumnName;
            string str2;
            // ISSUE: reference to a compiler-generated method
            switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(columnName))
            {
              case 293291698:
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(columnName, "PercentOfChargeCode", false) == 0)
                {
                  str2 = "Percent of ChargeCode";
                  break;
                }
                goto default;
              case 293759076:
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(columnName, "OfficeID", false) == 0)
                {
                  str2 = "Office";
                  break;
                }
                goto default;
              case 338466441:
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(columnName, "AppliesToPaymentID", false) == 0)
                {
                  str2 = "AppliesToPayment";
                  break;
                }
                goto default;
              case 939446748:
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(columnName, "WaivedByUserGuid", false) == 0)
                {
                  str2 = "Waived By User";
                  break;
                }
                goto default;
              case 2523683638:
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(columnName, "FeeTypeID", false) == 0)
                {
                  str2 = "FeeType";
                  break;
                }
                goto default;
              case 2572567032:
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(columnName, "ChargeCode", false) == 0)
                {
                  str2 = "Fee";
                  break;
                }
                goto default;
              case 3317751320:
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(columnName, "ConvertedToManualUserGuid", false) == 0)
                {
                  str2 = "ConvertedToManual";
                  break;
                }
                goto default;
              default:
                str2 = column.ColumnName;
                break;
            }
            if (dr[column.ColumnName, DataRowVersion.Original] != DBNull.Value)
            {
              g1 = dr[column.ColumnName, DataRowVersion.Original].ToString();
              if (column.ColumnName.Equals("OfficeID"))
                g1 = this.ds.tblClientOffices.FindByOfficeID(Conversions.ToInteger(g1)).Location;
              else if (column.ColumnName.Equals("ConvertedToManualUserGuid"))
                g1 = this.ds.tblUsers.FindByUserGUID(new Guid(g1)).Name_LastFirst;
              else if (column.ColumnName.Equals("FeeTypeID"))
                g1 = this.ds.lstFeeTypes.FindByID(Conversions.ToInteger(g1)).FeeType;
              else if (column.ColumnName.Equals("WaivedByUserGuid"))
                g1 = this.ds.tblUsers.FindByUserGUID(new Guid(g1)).Name_LastFirst;
              else if (column.ColumnName.Equals("ChargeCode"))
                g1 = DefaultDatabase.ExecuteScalar(CommandType.Text, str1, new object[2]
                {
                  (object) "@CC",
                  (object) Conversions.ToInteger(g1)
                }).ToString();
            }
            if (dr[column.ColumnName, DataRowVersion.Current] != DBNull.Value)
            {
              g2 = dr[column.ColumnName, DataRowVersion.Current].ToString();
              if (column.ColumnName.Equals("OfficeID"))
                g2 = this.ds.tblClientOffices.FindByOfficeID(Conversions.ToInteger(g2)).Location;
              else if (column.ColumnName.Equals("ConvertedToManualUserGuid"))
                g2 = this.ds.tblUsers.FindByUserGUID(new Guid(g2)).Name_LastFirst;
              else if (column.ColumnName.Equals("FeeTypeID"))
                g2 = this.ds.lstFeeTypes.FindByID(Conversions.ToInteger(g2)).FeeType;
              else if (column.ColumnName.Equals("WaivedByUserGuid"))
                g2 = this.ds.tblUsers.FindByUserGUID(new Guid(g2)).Name_LastFirst;
              else if (column.ColumnName.Equals("ChargeCode"))
                g2 = DefaultDatabase.ExecuteScalar(CommandType.Text, str1, new object[2]
                {
                  (object) "@CC",
                  (object) Conversions.ToInteger(g2)
                }).ToString();
            }
            if (!g1.Equals(g2))
              logList.Add($"Modified Fee - '{dr.ChargeName}'. Change {str2} from '{g1}' to '{g2}'");
          }
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      if (dr.IsNull("PayeeOverride") || dr["PayeeOverride", DataRowVersion.Original].ToString().Equals(dr["PayeeOverride", DataRowVersion.Current].ToString()))
        return;
      logList.Add($"Modified Fee - '{dr.ChargeName}'. Set Payee override.");
    }
  }

  protected void AddMenuOption(MenuItem mnuToAdd) => this.cm.MenuItems.Add(mnuToAdd);

  protected UltraGridRow ActiveFeeRow => ((UltraGridBase) this.ugFees).ActiveRow;

  private delegate void ShowConstraintErrorOnUIThreadHandler(ConstraintException ex);

  private delegate void ThreadedFillCompleteHandler();

  private enum ExistState
  {
    Exists,
    DoesntExist,
    Reinstated,
  }
}
