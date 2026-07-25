// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.InstallmentBilling.frmInstallmentBillingOptions
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Common.CustomExceptions;
using MGASystems.Common.ErrorHandling;
using MGASystems.Data;
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
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies.InstallmentBilling;

[SecureResource("{9CAF7677-3F75-1251-8039-D89312411156}", "Allow Installments on Cancellation Endorsements", "Controls the ability to bill cancellation endorsements on installments.", "Policies")]
[SecureResource("{8491B507-2316-4E25-8003-F7F1A02DB8E2}", "Can Change Payments, Downpayment and Downpayment Billing Type Fields", "Controls the ability to Change Payments, Downpayment and Downpayment Billing Type Fields.", "Policies")]
[SecureResource("{108441FE-AFCE-40AF-8DAE-8960141C4D16}", "Allow edits of installment options when a company installment payment plan is chosen", "Controls the ability to edit installment options when a plan is chosen.", "Policies")]
public class frmInstallmentBillingOptions : Form
{
  private IContainer components;
  protected ErrorProvider err;
  protected dsInstallmentBillingOptions ds;
  private DbDataAdapter daInstallmentBilling;
  private UltraDropDown ddBillingType;
  protected MGASimpleComboBox cboCompanyOptions;
  private UltraDropDown ddAppliesTo;
  private DbCommand DbSelectCommand1;
  private DbCommand DbInsertCommand1;
  private DbCommand DbUpdateCommand1;
  private DbCommand DbDeleteCommand1;
  internal const string AllowInstallmentBillingOnCancellationEndorsements = "{9CAF7677-3F75-1251-8039-D89312411156}";
  internal const string _CanUserChangeInstallmentBillingFields = "{8491B507-2316-4E25-8003-F7F1A02DB8E2}";
  internal const string AllowEditingInstallmentOptionWithPaymentPlan = "{108441FE-AFCE-40AF-8DAE-8960141C4D16}";
  protected readonly Quote _quote;
  private readonly QuoteOption _quoteOption;
  private double _premium;
  private Dictionary<int, Decimal> _totalPremium;
  private Dictionary<int, bool> _officeHasFees;
  private bool _configuratingPolicy;
  private readonly bool _roundPremiums;
  private readonly CultureInfo _cultureInfo;
  private bool _ValidateInstallmentBillingRequirement;
  private readonly bool _QuoteHasFees;
  private bool _formLoaded;
  private int _companyLineID;
  private readonly bool _canEditWithPreConfigPlan;
  private readonly bool _isEndorsement;
  private bool _clickedSaveButton;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private virtual MGAButton btnSave
  {
    get => this._btnSave;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnSave_Click);
      MGAButton btnSave1 = this._btnSave;
      if (btnSave1 != null)
        ((Control) btnSave1).Click -= eventHandler;
      this._btnSave = value;
      MGAButton btnSave2 = this._btnSave;
      if (btnSave2 == null)
        return;
      ((Control) btnSave2).Click += eventHandler;
    }
  }

  private virtual MGAButton btnCancel
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

  [field: AccessedThroughProperty("dgFees")]
  public virtual UltraGrid dgFees { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ddOffices")]
  private virtual UltraDropDown ddOffices { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual UltraGrid dgPayments
  {
    get => this._dgPayments;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      CellEventHandler cellEventHandler1 = new CellEventHandler(this.dgPayments_CellClick);
      CellEventHandler cellEventHandler2 = new CellEventHandler(this.dgPayments_AfterCellUpdate);
      CancelableRowEventHandler cancelableRowEventHandler = new CancelableRowEventHandler(this.dgPayments_BeforeRowUpdate);
      UltraGrid dgPayments1 = this._dgPayments;
      if (dgPayments1 != null)
      {
        dgPayments1.CellChange -= cellEventHandler1;
        dgPayments1.AfterCellUpdate -= cellEventHandler2;
        dgPayments1.BeforeRowUpdate -= cancelableRowEventHandler;
      }
      this._dgPayments = value;
      UltraGrid dgPayments2 = this._dgPayments;
      if (dgPayments2 == null)
        return;
      dgPayments2.CellChange += cellEventHandler1;
      dgPayments2.AfterCellUpdate += cellEventHandler2;
      dgPayments2.BeforeRowUpdate += cancelableRowEventHandler;
    }
  }

  [field: AccessedThroughProperty("labelPolicyPremium")]
  private virtual Label labelPolicyPremium { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblInstallmentOption")]
  private virtual Label lblInstallmentOption { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("Fees", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("CompanyLineGuid");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("QuoteOptionGuid");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("ChargeCode");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("AppliesToPaymentID", -1, (object) "ddAppliesTo");
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("ChargeName");
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("Amount");
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("OfficeID", -1, (object) "ddOffices");
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    ScrollBarLook scrollBarLook1 = new ScrollBarLook();
    Appearance appearance15 = new Appearance();
    UltraGridBand ultraGridBand2 = new UltraGridBand("tblInstallmentBilling", -1);
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("QuoteOptionID");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("OfficeID", -1, (object) "ddOffices");
    Appearance appearance16 = new Appearance();
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("NumPayments");
    Appearance appearance17 = new Appearance();
    Appearance appearance18 = new Appearance();
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("Downpayment");
    Appearance appearance19 = new Appearance();
    Appearance appearance20 = new Appearance();
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("DownpaymentBillingTypeID", -1, (object) "ddBillingType");
    Appearance appearance21 = new Appearance();
    Appearance appearance22 = new Appearance();
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("Percentage");
    Appearance appearance23 = new Appearance();
    Appearance appearance24 = new Appearance();
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("SingleInvoice");
    Appearance appearance25 = new Appearance();
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("CompanyInstallmentID");
    Appearance appearance26 = new Appearance();
    Appearance appearance27 = new Appearance();
    Appearance appearance28 = new Appearance();
    Appearance appearance29 = new Appearance();
    ScrollBarLook scrollBarLook2 = new ScrollBarLook();
    Appearance appearance30 = new Appearance();
    UltraGridBand ultraGridBand3 = new UltraGridBand("tblClientOffices", -1);
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("OfficeID");
    UltraGridColumn ultraGridColumn17 = new UltraGridColumn("Location");
    UltraGridColumn ultraGridColumn18 = new UltraGridColumn("tblClientOfficestblInstallmentBilling");
    UltraGridBand ultraGridBand4 = new UltraGridBand("tblClientOfficestblInstallmentBilling", 0);
    UltraGridColumn ultraGridColumn19 = new UltraGridColumn("QuoteOptionID");
    UltraGridColumn ultraGridColumn20 = new UltraGridColumn("OfficeID");
    UltraGridColumn ultraGridColumn21 = new UltraGridColumn("NumPayments");
    UltraGridColumn ultraGridColumn22 = new UltraGridColumn("Downpayment");
    UltraGridColumn ultraGridColumn23 = new UltraGridColumn("DownpaymentBillingTypeID");
    UltraGridColumn ultraGridColumn24 = new UltraGridColumn("Percentage");
    UltraGridColumn ultraGridColumn25 = new UltraGridColumn("SingleInvoice");
    UltraGridColumn ultraGridColumn26 = new UltraGridColumn("CompanyInstallmentID");
    Appearance appearance31 = new Appearance();
    UltraGridBand ultraGridBand5 = new UltraGridBand("lstBillingTypes", -1);
    UltraGridColumn ultraGridColumn27 = new UltraGridColumn("BillingTypeID");
    UltraGridColumn ultraGridColumn28 = new UltraGridColumn("BillingType");
    UltraGridColumn ultraGridColumn29 = new UltraGridColumn("lstBillingTypestblInstallmentBilling");
    UltraGridBand ultraGridBand6 = new UltraGridBand("lstBillingTypestblInstallmentBilling", 0);
    UltraGridColumn ultraGridColumn30 = new UltraGridColumn("QuoteOptionID");
    UltraGridColumn ultraGridColumn31 = new UltraGridColumn("OfficeID");
    UltraGridColumn ultraGridColumn32 = new UltraGridColumn("NumPayments");
    UltraGridColumn ultraGridColumn33 = new UltraGridColumn("Downpayment");
    UltraGridColumn ultraGridColumn34 = new UltraGridColumn("DownpaymentBillingTypeID");
    UltraGridColumn ultraGridColumn35 = new UltraGridColumn("Percentage");
    UltraGridColumn ultraGridColumn36 = new UltraGridColumn("SingleInvoice");
    UltraGridColumn ultraGridColumn37 = new UltraGridColumn("CompanyInstallmentID");
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmInstallmentBillingOptions));
    Appearance appearance32 = new Appearance();
    UltraGridBand ultraGridBand7 = new UltraGridBand("lstFeeAppliesToPayment", -1);
    UltraGridColumn ultraGridColumn38 = new UltraGridColumn("ID");
    UltraGridColumn ultraGridColumn39 = new UltraGridColumn("Description");
    UltraGridColumn ultraGridColumn40 = new UltraGridColumn("lstFeeAppliesToPaymentFees");
    UltraGridBand ultraGridBand8 = new UltraGridBand("lstFeeAppliesToPaymentFees", 0);
    UltraGridColumn ultraGridColumn41 = new UltraGridColumn("CompanyLineGuid");
    UltraGridColumn ultraGridColumn42 = new UltraGridColumn("QuoteOptionGuid");
    UltraGridColumn ultraGridColumn43 = new UltraGridColumn("ChargeCode");
    UltraGridColumn ultraGridColumn44 = new UltraGridColumn("AppliesToPaymentID");
    UltraGridColumn ultraGridColumn45 = new UltraGridColumn("ChargeName");
    UltraGridColumn ultraGridColumn46 = new UltraGridColumn("Amount");
    UltraGridColumn ultraGridColumn47 = new UltraGridColumn("OfficeID");
    this.ds = new dsInstallmentBillingOptions();
    this.btnSave = new MGAButton();
    this.btnCancel = new MGAButton();
    this.err = new ErrorProvider(this.components);
    this.dgFees = new UltraGrid();
    this.dgPayments = new UltraGrid();
    this.ddOffices = new UltraDropDown();
    this.ddBillingType = new UltraDropDown();
    this.daInstallmentBilling = DefaultDatabase.CreateDataAdapter();
    this.DbDeleteCommand1 = DefaultDatabase.CreateCommand();
    this.DbInsertCommand1 = DefaultDatabase.CreateCommand();
    this.DbSelectCommand1 = DefaultDatabase.CreateCommand();
    this.DbUpdateCommand1 = DefaultDatabase.CreateCommand();
    this.lblInstallmentOption = new Label();
    this.cboCompanyOptions = new MGASimpleComboBox();
    this.ddAppliesTo = new UltraDropDown();
    this.labelPolicyPremium = new Label();
    Label label = new Label();
    this.ds.BeginInit();
    ((ISupportInitialize) this.btnSave).BeginInit();
    ((ISupportInitialize) this.btnCancel).BeginInit();
    ((ISupportInitialize) this.err).BeginInit();
    ((ISupportInitialize) this.dgFees).BeginInit();
    ((ISupportInitialize) this.dgPayments).BeginInit();
    ((ISupportInitialize) this.ddOffices).BeginInit();
    ((ISupportInitialize) this.ddBillingType).BeginInit();
    ((ISupportInitialize) this.cboCompanyOptions).BeginInit();
    ((ISupportInitialize) this.ddAppliesTo).BeginInit();
    this.SuspendLayout();
    label.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    label.AutoSize = true;
    label.Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    label.Location = new Point(4, 356);
    label.Name = "Label1";
    label.Size = new Size(97, 13);
    label.TabIndex = 28;
    label.Text = "Policy Premium:";
    label.TextAlign = ContentAlignment.MiddleRight;
    this.ds.DataSetName = "dsInstallmentBillingOptions";
    this.ds.Locale = new CultureInfo("en-US");
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((Control) this.btnSave).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance1.ImageHAlign = (HAlign) 2;
    appearance1.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnSave).Appearance = (AppearanceBase) appearance1;
    ((ControlBase) this.btnSave).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnSave).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnSave).Location = new Point(595, 329);
    ((Control) this.btnSave).Name = "btnSave";
    ((Control) this.btnSave).Size = new Size(40, 40);
    ((Control) this.btnSave).TabIndex = 19;
    this.btnSave.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.btnCancel).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance2.ImageHAlign = (HAlign) 2;
    appearance2.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnCancel).Appearance = (AppearanceBase) appearance2;
    ((UltraButtonBase) this.btnCancel).DialogResult = DialogResult.Cancel;
    ((ControlBase) this.btnCancel).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnCancel).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnCancel).Location = new Point(644, 329);
    ((Control) this.btnCancel).Name = "btnCancel";
    ((Control) this.btnCancel).Size = new Size(40, 40);
    ((Control) this.btnCancel).TabIndex = 20;
    this.btnCancel.UseOSThemes = (DefaultableBoolean) 2;
    this.err.ContainerControl = (ContainerControl) this;
    ((Control) this.dgFees).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.dgFees).DataSource = (object) this.ds.Fees;
    appearance3.BackColor = Color.White;
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.dgFees).DisplayLayout.Appearance = (AppearanceBase) appearance3;
    ((UltraGridBase) this.dgFees).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 175;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Hidden = true;
    ultraGridColumn2.Width = 178;
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridColumn3.Hidden = true;
    ultraGridColumn3.Width = 123;
    ultraGridColumn4.AutoCompleteMode = (AutoCompleteMode) 2;
    appearance4.BackColor = Color.LightYellow;
    ultraGridColumn4.CellAppearance = (AppearanceBase) appearance4;
    ((AppearanceBase) appearance5).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn4.Header).Appearance = (AppearanceBase) appearance5;
    ((HeaderBase) ultraGridColumn4.Header).Caption = "Applies To";
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn4.Header.VisiblePosition = 5;
    ultraGridColumn4.Style = (ColumnStyle) 6;
    ultraGridColumn4.Width = 174;
    ultraGridColumn5.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn5.CellActivation = (Activation) 1;
    ((AppearanceBase) appearance6).TextHAlignAsString = "Left";
    ultraGridColumn5.CellAppearance = (AppearanceBase) appearance6;
    ((AppearanceBase) appearance7).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn5.Header).Appearance = (AppearanceBase) appearance7;
    ((HeaderBase) ultraGridColumn5.Header).Caption = "Fee";
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn5.Header.VisiblePosition = 3;
    ultraGridColumn5.Width = 177;
    ultraGridColumn6.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn6.CellActivation = (Activation) 1;
    ((AppearanceBase) appearance8).TextHAlignAsString = "Right";
    ultraGridColumn6.CellAppearance = (AppearanceBase) appearance8;
    ultraGridColumn6.Format = "c";
    ((AppearanceBase) appearance9).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn6.Header).Appearance = (AppearanceBase) appearance9;
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn6.Header.VisiblePosition = 4;
    ultraGridColumn6.Width = 120;
    ultraGridColumn7.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn7.CellActivation = (Activation) 1;
    ((AppearanceBase) appearance10).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn7.Header).Appearance = (AppearanceBase) appearance10;
    ((HeaderBase) ultraGridColumn7.Header).Caption = "Office";
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn7.Header.VisiblePosition = 6;
    ultraGridColumn7.Width = 189;
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
    ((UltraGridBase) this.dgFees).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.dgFees).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.dgFees).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    appearance11.BorderColor = Color.Silver;
    ((UltraGridBase) this.dgFees).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance11;
    appearance12.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.dgFees).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance12;
    appearance13.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.dgFees).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance13;
    appearance14.BorderColor = Color.Silver;
    ((UltraGridBase) this.dgFees).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance14;
    ((UltraGridBase) this.dgFees).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    scrollBarLook1.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.dgFees).DisplayLayout.ScrollBarLook = scrollBarLook1;
    ((UltraGridBase) this.dgFees).DisplayLayout.Scrollbars = (Scrollbars) 3;
    ((Control) this.dgFees).Location = new Point(7, 147);
    ((Control) this.dgFees).MaximumSize = new Size(700, 600);
    ((Control) this.dgFees).Name = "dgFees";
    ((Control) this.dgFees).Size = new Size(679, 168);
    ((Control) this.dgFees).TabIndex = 21;
    ((UltraControlBase) this.dgFees).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dgFees).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.dgPayments).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.dgPayments).DataSource = (object) this.ds.tblInstallmentBilling;
    appearance15.BackColor = Color.White;
    appearance15.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.dgPayments).DisplayLayout.Appearance = (AppearanceBase) appearance15;
    ((UltraGridBase) this.dgPayments).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn8.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn8.Header.VisiblePosition = 0;
    ultraGridColumn8.Hidden = true;
    ultraGridColumn8.Width = 170;
    ultraGridColumn9.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn9.CellActivation = (Activation) 1;
    ((AppearanceBase) appearance16).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn9.Header).Appearance = (AppearanceBase) appearance16;
    ((HeaderBase) ultraGridColumn9.Header).Caption = "Office";
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn9.Header.VisiblePosition = 1;
    ultraGridColumn9.Width = 133;
    ultraGridColumn10.AutoCompleteMode = (AutoCompleteMode) 2;
    appearance17.BackColor = Color.LightYellow;
    ((AppearanceBase) appearance17).TextHAlignAsString = "Right";
    ultraGridColumn10.CellAppearance = (AppearanceBase) appearance17;
    ((AppearanceBase) appearance18).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn10.Header).Appearance = (AppearanceBase) appearance18;
    ((HeaderBase) ultraGridColumn10.Header).Caption = "# Payments";
    ((HeaderBase) ultraGridColumn10.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn10.Header.VisiblePosition = 2;
    ultraGridColumn10.Width = 77;
    ultraGridColumn11.AutoCompleteMode = (AutoCompleteMode) 2;
    appearance19.BackColor = Color.LightYellow;
    ((AppearanceBase) appearance19).TextHAlignAsString = "Right";
    ultraGridColumn11.CellAppearance = (AppearanceBase) appearance19;
    ultraGridColumn11.Format = "c";
    ((AppearanceBase) appearance20).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn11.Header).Appearance = (AppearanceBase) appearance20;
    ((HeaderBase) ultraGridColumn11.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn11.Header.VisiblePosition = 3;
    ultraGridColumn11.Width = 105;
    ultraGridColumn12.AutoCompleteMode = (AutoCompleteMode) 2;
    appearance21.BackColor = Color.LightYellow;
    ((AppearanceBase) appearance21).TextHAlignAsString = "Left";
    ultraGridColumn12.CellAppearance = (AppearanceBase) appearance21;
    ((AppearanceBase) appearance22).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn12.Header).Appearance = (AppearanceBase) appearance22;
    ((HeaderBase) ultraGridColumn12.Header).Caption = "Downpayment Billing Type";
    ((HeaderBase) ultraGridColumn12.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn12.Header.VisiblePosition = 4;
    ultraGridColumn12.Style = (ColumnStyle) 6;
    ultraGridColumn12.Width = 156;
    ultraGridColumn13.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn13.CellActivation = (Activation) 1;
    ((AppearanceBase) appearance23).TextHAlignAsString = "Right";
    ultraGridColumn13.CellAppearance = (AppearanceBase) appearance23;
    ultraGridColumn13.Format = "p";
    ((AppearanceBase) appearance24).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn13.Header).Appearance = (AppearanceBase) appearance24;
    ((HeaderBase) ultraGridColumn13.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn13.Header.VisiblePosition = 5;
    ultraGridColumn13.Width = 86;
    ultraGridColumn14.AutoCompleteMode = (AutoCompleteMode) 2;
    appearance25.BackColor = Color.LightYellow;
    ultraGridColumn14.CellAppearance = (AppearanceBase) appearance25;
    ((HeaderBase) ultraGridColumn14.Header).Caption = "Single Invoice";
    ((HeaderBase) ultraGridColumn14.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn14.Header.VisiblePosition = 6;
    ultraGridColumn14.Width = 103;
    ultraGridColumn15.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn15.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn15.Header.VisiblePosition = 7;
    ultraGridColumn15.Hidden = true;
    ultraGridColumn15.Width = 130;
    ultraGridBand2.Columns.AddRange(new object[8]
    {
      (object) ultraGridColumn8,
      (object) ultraGridColumn9,
      (object) ultraGridColumn10,
      (object) ultraGridColumn11,
      (object) ultraGridColumn12,
      (object) ultraGridColumn13,
      (object) ultraGridColumn14,
      (object) ultraGridColumn15
    });
    ((UltraGridBase) this.dgPayments).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.dgPayments).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.dgPayments).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    appearance26.BorderColor = Color.Silver;
    ((UltraGridBase) this.dgPayments).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance26;
    appearance27.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.dgPayments).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance27;
    appearance28.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.dgPayments).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance28;
    appearance29.BorderColor = Color.Silver;
    ((UltraGridBase) this.dgPayments).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance29;
    ((UltraGridBase) this.dgPayments).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    scrollBarLook2.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.dgPayments).DisplayLayout.ScrollBarLook = scrollBarLook2;
    ((UltraGridBase) this.dgPayments).DisplayLayout.Scrollbars = (Scrollbars) 3;
    ((Control) this.dgPayments).Location = new Point(7, 35);
    ((Control) this.dgPayments).Name = "dgPayments";
    ((Control) this.dgPayments).Size = new Size(679, 105);
    ((Control) this.dgPayments).TabIndex = 22;
    ((UltraControlBase) this.dgPayments).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dgPayments).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraGridBase) this.ddOffices).DataSource = (object) this.ds.tblClientOffices;
    appearance30.BackColor = Color.White;
    appearance30.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ddOffices).DisplayLayout.Appearance = (AppearanceBase) appearance30;
    ultraGridBand3.ColHeadersVisible = false;
    ultraGridColumn16.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn16.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn16.Header.VisiblePosition = 0;
    ultraGridColumn16.Hidden = true;
    ultraGridColumn17.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn17.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn17.Header.VisiblePosition = 1;
    ultraGridColumn17.Width = 200;
    ultraGridColumn18.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn18.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn18.Header.VisiblePosition = 2;
    ultraGridBand3.Columns.AddRange(new object[3]
    {
      (object) ultraGridColumn16,
      (object) ultraGridColumn17,
      (object) ultraGridColumn18
    });
    ultraGridColumn19.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn19.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn19.Header.VisiblePosition = 0;
    ultraGridColumn20.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn20.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn20.Header.VisiblePosition = 1;
    ultraGridColumn21.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn21.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn21.Header.VisiblePosition = 2;
    ultraGridColumn22.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn22.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn22.Header.VisiblePosition = 3;
    ultraGridColumn23.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn23.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn23.Header.VisiblePosition = 4;
    ultraGridColumn24.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn24.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn24.Header.VisiblePosition = 5;
    ultraGridColumn25.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn25.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn25.Header.VisiblePosition = 6;
    ultraGridColumn26.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn26.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn26.Header.VisiblePosition = 7;
    ultraGridBand4.Columns.AddRange(new object[8]
    {
      (object) ultraGridColumn19,
      (object) ultraGridColumn20,
      (object) ultraGridColumn21,
      (object) ultraGridColumn22,
      (object) ultraGridColumn23,
      (object) ultraGridColumn24,
      (object) ultraGridColumn25,
      (object) ultraGridColumn26
    });
    ((UltraGridBase) this.ddOffices).DisplayLayout.BandsSerializer.Add((object) ultraGridBand3);
    ((UltraGridBase) this.ddOffices).DisplayLayout.BandsSerializer.Add((object) ultraGridBand4);
    ((UltraGridBase) this.ddOffices).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.ddOffices).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.ddOffices).DisplayLayout.Override.BorderStyleHeader = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.ddOffices).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    ((UltraDropDownBase) this.ddOffices).DisplayMember = "Location";
    ((Control) this.ddOffices).Location = new Point(398, 218);
    ((Control) this.ddOffices).Name = "ddOffices";
    ((Control) this.ddOffices).Size = new Size(203, 70);
    ((Control) this.ddOffices).TabIndex = 23;
    ((UltraDropDownBase) this.ddOffices).ValueMember = "OfficeID";
    ((Control) this.ddOffices).Visible = false;
    ((UltraGridBase) this.ddBillingType).DataSource = (object) this.ds.lstBillingTypes;
    appearance31.BackColor = Color.White;
    appearance31.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ddBillingType).DisplayLayout.Appearance = (AppearanceBase) appearance31;
    ultraGridBand5.ColHeadersVisible = false;
    ultraGridColumn27.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn27.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn27.Header.VisiblePosition = 0;
    ultraGridColumn27.Hidden = true;
    ultraGridColumn28.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn28.Header).Caption = "Billing Type";
    ((HeaderBase) ultraGridColumn28.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn28.Header.VisiblePosition = 1;
    ultraGridColumn28.Width = 200;
    ultraGridColumn29.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn29.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn29.Header.VisiblePosition = 2;
    ultraGridBand5.Columns.AddRange(new object[3]
    {
      (object) ultraGridColumn27,
      (object) ultraGridColumn28,
      (object) ultraGridColumn29
    });
    ultraGridColumn30.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn30.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn30.Header.VisiblePosition = 0;
    ultraGridColumn31.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn31.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn31.Header.VisiblePosition = 1;
    ultraGridColumn32.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn32.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn32.Header.VisiblePosition = 2;
    ultraGridColumn33.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn33.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn33.Header.VisiblePosition = 3;
    ultraGridColumn34.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn34.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn34.Header.VisiblePosition = 4;
    ultraGridColumn35.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn35.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn35.Header.VisiblePosition = 5;
    ultraGridColumn36.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn36.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn36.Header.VisiblePosition = 6;
    ultraGridColumn37.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn37.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn37.Header.VisiblePosition = 7;
    ultraGridBand6.Columns.AddRange(new object[8]
    {
      (object) ultraGridColumn30,
      (object) ultraGridColumn31,
      (object) ultraGridColumn32,
      (object) ultraGridColumn33,
      (object) ultraGridColumn34,
      (object) ultraGridColumn35,
      (object) ultraGridColumn36,
      (object) ultraGridColumn37
    });
    ((UltraGridBase) this.ddBillingType).DisplayLayout.BandsSerializer.Add((object) ultraGridBand5);
    ((UltraGridBase) this.ddBillingType).DisplayLayout.BandsSerializer.Add((object) ultraGridBand6);
    ((UltraGridBase) this.ddBillingType).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.ddBillingType).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.ddBillingType).DisplayLayout.Override.BorderStyleHeader = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.ddBillingType).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    ((UltraDropDownBase) this.ddBillingType).DisplayMember = "BillingType";
    ((UltraDropDownBase) this.ddBillingType).DropDownWidth = 250;
    ((Control) this.ddBillingType).Location = new Point(168, 211);
    ((Control) this.ddBillingType).Name = "ddBillingType";
    ((Control) this.ddBillingType).Size = new Size(224 /*0xE0*/, 77);
    ((Control) this.ddBillingType).TabIndex = 24;
    ((UltraDropDownBase) this.ddBillingType).ValueMember = "BillingTypeID";
    ((Control) this.ddBillingType).Visible = false;
    this.daInstallmentBilling.DeleteCommand = this.DbDeleteCommand1;
    this.daInstallmentBilling.InsertCommand = this.DbInsertCommand1;
    this.daInstallmentBilling.SelectCommand = this.DbSelectCommand1;
    this.daInstallmentBilling.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblInstallmentBilling", new DataColumnMapping[6]
      {
        new DataColumnMapping("OfficeID", "OfficeID"),
        new DataColumnMapping("NumPayments", "NumPayments"),
        new DataColumnMapping("Downpayment", "Downpayment"),
        new DataColumnMapping("DownpaymentBillingTypeID", "DownpaymentBillingTypeID"),
        new DataColumnMapping("SingleInvoice", "SingleInvoice"),
        new DataColumnMapping("QuoteOptionID", "QuoteOptionID")
      })
    });
    this.daInstallmentBilling.UpdateCommand = this.DbUpdateCommand1;
    this.DbDeleteCommand1.CommandText = componentResourceManager.GetString("DbDeleteCommand1.CommandText");
    this.DbDeleteCommand1.Parameters.AddRange((Array) new DbParameter[6]
    {
      DefaultDatabase.CreateParameter("@Original_OfficeID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "OfficeID", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_QuoteOptionID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "QuoteOptionID", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_Downpayment", SqlDbType.Money, 8, ParameterDirection.Input, false, (byte) 0, (byte) 0, "Downpayment", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_DownpaymentBillingTypeID", SqlDbType.TinyInt, 1, ParameterDirection.Input, false, (byte) 0, (byte) 0, "DownpaymentBillingTypeID", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_NumPayments", SqlDbType.TinyInt, 1, ParameterDirection.Input, false, (byte) 0, (byte) 0, "NumPayments", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_SingleInvoice", SqlDbType.Bit, 1, ParameterDirection.Input, false, (byte) 0, (byte) 0, "SingleInvoice", DataRowVersion.Original, (object) null)
    });
    this.DbInsertCommand1.CommandText = componentResourceManager.GetString("DbInsertCommand1.CommandText");
    this.DbInsertCommand1.Parameters.AddRange((Array) new DbParameter[6]
    {
      DefaultDatabase.CreateParameter("@OfficeID", SqlDbType.Int, 4, "OfficeID"),
      DefaultDatabase.CreateParameter("@NumPayments", SqlDbType.TinyInt, 1, "NumPayments"),
      DefaultDatabase.CreateParameter("@Downpayment", SqlDbType.Money, 8, "Downpayment"),
      DefaultDatabase.CreateParameter("@DownpaymentBillingTypeID", SqlDbType.TinyInt, 1, "DownpaymentBillingTypeID"),
      DefaultDatabase.CreateParameter("@SingleInvoice", SqlDbType.Bit, 1, "SingleInvoice"),
      DefaultDatabase.CreateParameter("@QuoteOptionID", SqlDbType.Int, 4, "QuoteOptionID")
    });
    this.DbSelectCommand1.CommandText = "SELECT OfficeID, NumPayments, Downpayment, DownpaymentBillingTypeID, SingleInvoice, QuoteOptionID FROM tblInstallmentBilling WHERE (QuoteOptionID = @quoteOptionID)";
    this.DbSelectCommand1.Parameters.AddRange((Array) new DbParameter[1]
    {
      DefaultDatabase.CreateParameter("@quoteOptionID", SqlDbType.Int, 4, "QuoteOptionID")
    });
    this.DbUpdateCommand1.CommandText = componentResourceManager.GetString("DbUpdateCommand1.CommandText");
    this.DbUpdateCommand1.Parameters.AddRange((Array) new DbParameter[12]
    {
      DefaultDatabase.CreateParameter("@OfficeID", SqlDbType.Int, 4, "OfficeID"),
      DefaultDatabase.CreateParameter("@NumPayments", SqlDbType.TinyInt, 1, "NumPayments"),
      DefaultDatabase.CreateParameter("@Downpayment", SqlDbType.Money, 8, "Downpayment"),
      DefaultDatabase.CreateParameter("@DownpaymentBillingTypeID", SqlDbType.TinyInt, 1, "DownpaymentBillingTypeID"),
      DefaultDatabase.CreateParameter("@SingleInvoice", SqlDbType.Bit, 1, "SingleInvoice"),
      DefaultDatabase.CreateParameter("@QuoteOptionID", SqlDbType.Int, 4, "QuoteOptionID"),
      DefaultDatabase.CreateParameter("@Original_OfficeID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "OfficeID", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_QuoteOptionID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "QuoteOptionID", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_Downpayment", SqlDbType.Money, 8, ParameterDirection.Input, false, (byte) 0, (byte) 0, "Downpayment", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_DownpaymentBillingTypeID", SqlDbType.TinyInt, 1, ParameterDirection.Input, false, (byte) 0, (byte) 0, "DownpaymentBillingTypeID", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_NumPayments", SqlDbType.TinyInt, 1, ParameterDirection.Input, false, (byte) 0, (byte) 0, "NumPayments", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_SingleInvoice", SqlDbType.Bit, 1, ParameterDirection.Input, false, (byte) 0, (byte) 0, "SingleInvoice", DataRowVersion.Original, (object) null)
    });
    this.lblInstallmentOption.AutoSize = true;
    this.lblInstallmentOption.Location = new Point(7, 9);
    this.lblInstallmentOption.Name = "lblInstallmentOption";
    this.lblInstallmentOption.Size = new Size(147, 13);
    this.lblInstallmentOption.TabIndex = 25;
    this.lblInstallmentOption.Text = "Company Installment Option:";
    this.lblInstallmentOption.TextAlign = ContentAlignment.MiddleRight;
    ((UltraCombo) this.cboCompanyOptions).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.cboCompanyOptions).DataSource = (object) this.ds.tblCompanyLineInstallments;
    ((UltraDropDownBase) this.cboCompanyOptions).DisplayMember = "OptionName";
    ((UltraCombo) this.cboCompanyOptions).DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboCompanyOptions).Location = new Point(168, 5);
    this.cboCompanyOptions.MGAStyle = (MGAStyles) 2;
    ((Control) this.cboCompanyOptions).Name = "cboCompanyOptions";
    ((Control) this.cboCompanyOptions).Size = new Size(252, 21);
    ((Control) this.cboCompanyOptions).TabIndex = 26;
    ((UltraControlBase) this.cboCompanyOptions).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboCompanyOptions).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboCompanyOptions).ValueMember = "ID";
    ((UltraGridBase) this.ddAppliesTo).DataSource = (object) this.ds.lstFeeAppliesToPayment;
    appearance32.BackColor = Color.White;
    appearance32.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ddAppliesTo).DisplayLayout.Appearance = (AppearanceBase) appearance32;
    ultraGridBand7.ColHeadersVisible = false;
    ultraGridColumn38.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn38.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn38.Header.VisiblePosition = 0;
    ultraGridColumn38.Hidden = true;
    ultraGridColumn39.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn39.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn39.Header.VisiblePosition = 1;
    ultraGridColumn39.Width = 299;
    ultraGridColumn40.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn40.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn40.Header.VisiblePosition = 2;
    ultraGridBand7.Columns.AddRange(new object[3]
    {
      (object) ultraGridColumn38,
      (object) ultraGridColumn39,
      (object) ultraGridColumn40
    });
    ultraGridColumn41.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn41.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn41.Header.VisiblePosition = 0;
    ultraGridColumn42.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn42.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn42.Header.VisiblePosition = 1;
    ultraGridColumn43.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn43.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn43.Header.VisiblePosition = 2;
    ultraGridColumn44.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn44.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn44.Header.VisiblePosition = 3;
    ultraGridColumn45.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn45.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn45.Header.VisiblePosition = 4;
    ultraGridColumn46.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn46.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn46.Header.VisiblePosition = 5;
    ultraGridColumn47.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn47.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn47.Header.VisiblePosition = 6;
    ultraGridBand8.Columns.AddRange(new object[7]
    {
      (object) ultraGridColumn41,
      (object) ultraGridColumn42,
      (object) ultraGridColumn43,
      (object) ultraGridColumn44,
      (object) ultraGridColumn45,
      (object) ultraGridColumn46,
      (object) ultraGridColumn47
    });
    ((UltraGridBase) this.ddAppliesTo).DisplayLayout.BandsSerializer.Add((object) ultraGridBand7);
    ((UltraGridBase) this.ddAppliesTo).DisplayLayout.BandsSerializer.Add((object) ultraGridBand8);
    ((UltraGridBase) this.ddAppliesTo).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.ddAppliesTo).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.ddAppliesTo).DisplayLayout.Override.BorderStyleHeader = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.ddAppliesTo).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    ((UltraDropDownBase) this.ddAppliesTo).DisplayMember = "Description";
    ((UltraDropDownBase) this.ddAppliesTo).DropDownWidth = 300;
    ((Control) this.ddAppliesTo).Location = new Point(64 /*0x40*/, 218);
    ((Control) this.ddAppliesTo).Name = "ddAppliesTo";
    ((Control) this.ddAppliesTo).Size = new Size(98, 70);
    ((Control) this.ddAppliesTo).TabIndex = 27;
    ((UltraDropDownBase) this.ddAppliesTo).ValueMember = "ID";
    ((Control) this.ddAppliesTo).Visible = false;
    this.labelPolicyPremium.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.labelPolicyPremium.AutoSize = true;
    this.labelPolicyPremium.Location = new Point(107, 356);
    this.labelPolicyPremium.Name = "labelPolicyPremium";
    this.labelPolicyPremium.Size = new Size(55, 13);
    this.labelPolicyPremium.TabIndex = 29;
    this.labelPolicyPremium.Text = "(premium)";
    this.labelPolicyPremium.TextAlign = ContentAlignment.MiddleLeft;
    this.AcceptButton = (IButtonControl) this.btnSave;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.CancelButton = (IButtonControl) this.btnCancel;
    this.ClientSize = new Size(692, 379);
    this.Controls.Add((Control) this.labelPolicyPremium);
    this.Controls.Add((Control) label);
    this.Controls.Add((Control) this.cboCompanyOptions);
    this.Controls.Add((Control) this.ddAppliesTo);
    this.Controls.Add((Control) this.lblInstallmentOption);
    this.Controls.Add((Control) this.ddBillingType);
    this.Controls.Add((Control) this.ddOffices);
    this.Controls.Add((Control) this.dgPayments);
    this.Controls.Add((Control) this.dgFees);
    this.Controls.Add((Control) this.btnCancel);
    this.Controls.Add((Control) this.btnSave);
    this.DoubleBuffered = true;
    this.Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedSingle;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmInstallmentBillingOptions);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Installment Billing Options";
    this.ds.EndInit();
    ((ISupportInitialize) this.btnSave).EndInit();
    ((ISupportInitialize) this.btnCancel).EndInit();
    ((ISupportInitialize) this.err).EndInit();
    ((ISupportInitialize) this.dgFees).EndInit();
    ((ISupportInitialize) this.dgPayments).EndInit();
    ((ISupportInitialize) this.ddOffices).EndInit();
    ((ISupportInitialize) this.ddBillingType).EndInit();
    ((ISupportInitialize) this.cboCompanyOptions).EndInit();
    ((ISupportInitialize) this.ddAppliesTo).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  public frmInstallmentBillingOptions(int quoteOptionID)
  {
    this.Load += new EventHandler(this.frmInstallmentBillingOptions_Load);
    this._totalPremium = new Dictionary<int, Decimal>();
    this._officeHasFees = new Dictionary<int, bool>();
    this._formLoaded = false;
    this.InitializeComponent();
    this._quoteOption = new QuoteOption(quoteOptionID);
    this._quote = new Quote(this._quoteOption.QuoteGuid);
    this._premium = Convert.ToDouble(this._quote.Premium);
    this._QuoteHasFees = this._quote.HasFees;
    this._cultureInfo = MultiCurrencyUtilities.GetCultureInfo(DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "Select dbo.GetQuoteCurrencyCode(@quoteId)", new object[2]
    {
      (object) "@QuoteId",
      (object) this._quote.QuoteID
    }));
    this.labelPolicyPremium.Text = this._premium.ToString("c", (IFormatProvider) this._cultureInfo);
    if (this._premium > 0.0)
      this.labelPolicyPremium.ForeColor = Color.DarkGreen;
    else if (this._premium < 0.0)
      this.labelPolicyPremium.ForeColor = Color.Red;
    Decimal premiumWithCents = new QuoteOption(quoteOptionID).PremiumWithCents;
    this._roundPremiums = Decimal.Compare(premiumWithCents, new Decimal(Convert.ToInt32(premiumWithCents))) == 0 && !this.AlwaysAllowPennyPremiums();
    this._canEditWithPreConfigPlan = SecurityManager.Instance.AssertPermission("{108441FE-AFCE-40AF-8DAE-8960141C4D16}");
    this._isEndorsement = this._quote.IsEndorsement;
  }

  public frmInstallmentBillingOptions()
  {
    this.Load += new EventHandler(this.frmInstallmentBillingOptions_Load);
    this._totalPremium = new Dictionary<int, Decimal>();
    this._officeHasFees = new Dictionary<int, bool>();
    this._formLoaded = false;
    this.InitializeComponent();
  }

  public bool ConfiguratingPolicy
  {
    get => this._configuratingPolicy;
    set
    {
      this._configuratingPolicy = value;
      this._premium = this._premium;
    }
  }

  public dsInstallmentBillingOptions BaseDataset => this.ds;

  public Quote Quote => this._quote;

  public QuoteOption QuoteOption => this._quoteOption;

  public bool ClickedSaved => this._clickedSaveButton;

  protected virtual void GetCompanyInstallmentOptions()
  {
    DefaultDatabase.LoadDataTable((DataTable) this.ds.tblCompanyLineInstallments, "dbo.spGetCompanyLineInstallments", new object[4]
    {
      (object) "@CompanyLineID",
      (object) this._quote.CompanyLine.CompanyLineID,
      (object) "@QuoteGuid",
      (object) this._quote.QuoteGuid
    });
  }

  private void frmInstallmentBillingOptions_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    Utility.SetDataAdapterConnections(this.daInstallmentBilling, DefaultDatabase.CreateDbConnection(), (DbTransaction) null);
    UltraGridColumn column = ((UltraGridBase) this.dgPayments).DisplayLayout.Bands[0].Columns["OfficeID"];
    column.ValueList = (IValueList) this.ddOffices;
    column.CellActivation = (Activation) 3;
    ((ControlBase) this.btnSave).Appearance.Image = (object) ImageCache.Instance.Save;
    ((ControlBase) this.btnCancel).Appearance.Image = (object) ImageCache.Instance.Undo;
    ((UltraGridBase) this.dgPayments).DisplayLayout.Bands[0].Columns["DownpaymentBillingTypeID"].ValueList = (IValueList) this.ddBillingType;
    this._ValidateInstallmentBillingRequirement = SystemSettings.KeyExists("InstallmentBillingOptionRequiredForBinding") && SystemSettings.GetBoolSetting("InstallmentBillingOptionRequiredForBinding");
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "tblClientOffices"
    }, CommandType.Text, "SELECT OfficeID, Location FROM tblClientOffices WHERE OfficeID IN (SELECT * FROM dbo.GetOptionOfficeIDs(@QuoteOptionID))", new object[2]
    {
      (object) "@QuoteOptionID",
      (object) this._quoteOption.QuoteOptionID
    });
    try
    {
      foreach (dsInstallmentBillingOptions.tblClientOfficesRow tblClientOffice in (TypedTableBase<dsInstallmentBillingOptions.tblClientOfficesRow>) this.ds.tblClientOffices)
      {
        Decimal num = DefaultDatabase.ExecuteScalar<Decimal>(CommandType.Text, "SELECT ISNULL(SUM(P.Premium),0) FROM tblQuoteOptionPremiums P INNER JOIN tblQuoteOptions O ON P.QuoteOptionGuid=O.QuoteOptionGuid WHERE O.QuoteGuid = @QG AND O.Bound=1 AND P.OfficeID=@OID", new object[4]
        {
          (object) "@QG",
          (object) this._quote.QuoteGuid,
          (object) "@OID",
          (object) tblClientOffice.OfficeID
        });
        this._totalPremium[tblClientOffice.OfficeID] = num;
        this._officeHasFees[tblClientOffice.OfficeID] = false;
      }
    }
    finally
    {
      IEnumerator<dsInstallmentBillingOptions.tblClientOfficesRow> enumerator;
      enumerator?.Dispose();
    }
    this.ds.tblCompanyLineInstallments.AddtblCompanyLineInstallmentsRow(string.Empty, 0M, 0, 0, 0, 0, false, 0M);
    CompanyLine companyLine = this._quote.CompanyLine;
    this.GetCompanyInstallmentOptions();
    this._companyLineID = companyLine.CompanyLineID;
    if (this.ds.tblCompanyLineInstallments.Count == 1)
    {
      ((Control) this.cboCompanyOptions).Visible = false;
      this.lblInstallmentOption.Visible = false;
      ((Control) this.dgPayments).Top = ((Control) this.cboCompanyOptions).Top;
    }
    this.ds.lstBillingTypes.AddlstBillingTypesRow(-1, string.Empty);
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "lstBillingTypes"
    }, "dbo.spGetDownpaymentBillingTypes", new object[2]
    {
      (object) "@QuoteGuid",
      (object) this._quote.QuoteGuid
    });
    this.daInstallmentBilling.SelectCommand.Parameters["@QuoteOptionID"].Value = (object) this._quoteOption.QuoteOptionID;
    DefaultDatabase.DataAdapterFill(this.daInstallmentBilling, (DataTable) this.ds.tblInstallmentBilling);
    int integer = Conversions.ToInteger(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT COUNT(*) FROM tblQuoteAdditionalInterests WHERE BillableAmount IS NOT NULL And QuoteID = @QID", new object[2]
    {
      (object) "@QID",
      (object) this._quote.QuoteID
    }));
    if (integer != 0)
    {
      this.ds.tblInstallmentBilling[0].NumPayments = integer - 1;
      this.ds.tblInstallmentBilling[0].Downpayment = Conversions.ToDecimal(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT TOP 1 BillableAmount FROM dbo.tblQuoteAdditionalInterests WHERE BillableAmount IS NOT NULL AND QuoteID = @QID ORDER BY ID", new object[2]
      {
        (object) "@QID",
        (object) this._quote.QuoteID
      }));
    }
    if (!this._quoteOption.IsCompanyInstallmentIDNull)
    {
      ((UltraCombo) this.cboCompanyOptions).Value = (object) this._quoteOption.CompanyInstallmentID;
    }
    else
    {
      try
      {
        foreach (dsInstallmentBillingOptions.tblInstallmentBillingRow installmentBillingRow in (TypedTableBase<dsInstallmentBillingOptions.tblInstallmentBillingRow>) this.ds.tblInstallmentBilling)
          installmentBillingRow.Percentage = Decimal.Compare(this._totalPremium[installmentBillingRow.OfficeID], 0M) != 0 ? Decimal.Divide(installmentBillingRow.Downpayment, this._totalPremium[installmentBillingRow.OfficeID]) : 0M;
      }
      finally
      {
        IEnumerator<dsInstallmentBillingOptions.tblInstallmentBillingRow> enumerator;
        enumerator?.Dispose();
      }
    }
    ((UltraCombo) this.cboCompanyOptions).ValueChanged += new EventHandler(this.cboCompanyOptions_ValueChanged);
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "lstFeeAppliesToPayment"
    }, CommandType.Text, "SELECT ID, Description FROM lstFeeAppliesToPayment ORDER BY SortOrder");
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "Fees"
    }, "[GetInstallmentBillingFees]", new object[2]
    {
      (object) "@QuoteGuid",
      (object) this._quote.QuoteGuid
    });
    try
    {
      foreach (dsInstallmentBillingOptions.FeesRow fee in (TypedTableBase<dsInstallmentBillingOptions.FeesRow>) this.ds.Fees)
        this._officeHasFees[fee.OfficeID] = true;
    }
    finally
    {
      IEnumerator<dsInstallmentBillingOptions.FeesRow> enumerator;
      enumerator?.Dispose();
    }
    this.CalculateDownpaymentPercentages();
    this.LayoutControls();
    ((UltraGridBase) this.dgPayments).DisplayLayout.Bands[0].Columns["DownPayment"].FormatInfo = (IFormatProvider) this._cultureInfo;
    ((UltraGridBase) this.dgFees).DisplayLayout.Bands[0].Columns["Amount"].FormatInfo = (IFormatProvider) this._cultureInfo;
    this.cboCompanyOptions_ValueChanged((object) null, EventArgs.Empty);
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
      foreach (UltraGridRow row in ((UltraGridBase) this.dgFees).Rows)
      {
        if (dataTable.Select("ChargeCode=" + row.Cells["ChargeCode"].Value.ToString()).Length > 0)
          row.Hidden = true;
      }
    }
    this.AfterFormLoad();
    this._formLoaded = true;
    if (!this._quote.IsBound)
      return;
    this.SetFormState(false);
  }

  protected virtual void AfterFormLoad()
  {
  }

  internal static bool IsWholeNumber(object number)
  {
    return Conversions.ToInteger(number) == 0 || Decimal.Compare(Decimal.Remainder(Conversions.ToDecimal(number), new Decimal(Conversions.ToInteger(number))), 0M) == 0;
  }

  private void dgPayments_CellClick(object sender, CellEventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(e.Cell.Column.Key, "SingleInvoice", false) != 0)
      return;
    this.dgPayments.PerformAction((UltraGridAction) 44);
  }

  private void dgPayments_AfterCellUpdate(object sender, CellEventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(e.Cell.Column.Key, "Downpayment", false) == 0 && Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(e.Cell.Value)))
    {
      this.CalculateDownpaymentPercentage(e.Cell.Row);
    }
    else
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(e.Cell.Column.Key, "SingleInvoice", false) != 0)
        return;
      if (e.Cell.Value != DBNull.Value && ((bool?) e.Cell.Value).GetValueOrDefault())
      {
        e.Cell.Row.Cells["NumPayments"].Value = (object) 1;
        e.Cell.Row.Cells["NumPayments"].Activation = (Activation) 3;
        e.Cell.Row.Cells["Downpayment"].Value = (object) 0;
      }
      else
        e.Cell.Row.Cells["NumPayments"].Activation = (Activation) 0;
    }
  }

  private void CalculateDownpaymentPercentages()
  {
    foreach (UltraGridRow row in ((UltraGridBase) this.dgPayments).Rows)
      this.CalculateDownpaymentPercentage(row);
  }

  private void CalculateDownpaymentPercentage(UltraGridRow row)
  {
    Decimal d1 = Conversions.ToDecimal(row.Cells["Downpayment"].Value);
    int integer = Conversions.ToInteger(row.Cells["OfficeID"].Value);
    Decimal num = this._totalPremium[integer];
    this.dgPayments.AfterCellUpdate -= new CellEventHandler(this.dgPayments_AfterCellUpdate);
    row.Cells["Percentage"].Value = Decimal.Compare(num, 0M) != 0 ? (object) Decimal.Divide(d1, num) : (object) 0;
    if (Decimal.Compare(d1, 0M) == 0)
    {
      if (!this._officeHasFees[integer])
        row.Cells["DownpaymentBillingTypeID"].Value = (object) DBNull.Value;
    }
    else if (this.ds.lstBillingTypes.Count == 2)
      row.Cells["DownpaymentBillingTypeID"].Value = (object) this.ds.lstBillingTypes[1].BillingTypeID;
    this.dgPayments.AfterCellUpdate += new CellEventHandler(this.dgPayments_AfterCellUpdate);
  }

  private void dgPayments_BeforeRowUpdate(object sender, CancelableRowEventArgs e)
  {
    if (this.dgPayments == null || ((UltraGridBase) this.dgPayments).ActiveRow == null)
      return;
    if (((UltraGridBase) this.dgPayments).ActiveRow.Cells["Downpayment"].Value == DBNull.Value)
      ((UltraGridBase) this.dgPayments).ActiveRow.Cells["Downpayment"].Value = (object) 0;
    if (((UltraGridBase) this.dgPayments).ActiveRow.Cells["NumPayments"].Value != DBNull.Value)
      return;
    ((UltraGridBase) this.dgPayments).ActiveRow.Cells["NumPayments"].Value = (object) 0;
  }

  private bool ValidateDownpayment(
    bool valid,
    dsInstallmentBillingOptions.tblInstallmentBillingRow dr)
  {
    if (this.ds.Fees.Count == 0 && Decimal.Compare(dr.Downpayment, 0M) == 0)
      dr.SetDownpaymentBillingTypeIDNull();
    if (dr.IsDownpaymentBillingTypeIDNull() && Decimal.Compare(dr.Downpayment, 0M) > 0)
    {
      int num = (int) MessageBox.Show("Please select a billing type for all downpayments.", "Downpayment Billing Type Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      valid = false;
    }
    if (!dr.IsDownpaymentBillingTypeIDNull() && dr.DownpaymentBillingTypeID == -1)
      dr.SetDownpaymentBillingTypeIDNull();
    if (this._roundPremiums && Decimal.Compare(dr.Downpayment, 0M) != 0 && !frmInstallmentBillingOptions.IsWholeNumber((object) dr.Downpayment))
    {
      int num = (int) MessageBox.Show($"All downpayment amounts must be whole numbers, {Strings.FormatCurrency((object) dr.Downpayment)} is not valid.", "Invalid Downpayment Amount", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      valid = false;
    }
    if (Decimal.Compare(dr.Downpayment, 0M) == 0 && dr.NumPayments > 1 && Decimal.Compare(this._totalPremium[dr.OfficeID], 0M) > 0 && !this._officeHasFees[dr.OfficeID])
    {
      int num = (int) MessageBox.Show("The downpayment amount can not equal zero when more than one payment is specified.", "Invalid Downpayment Amount", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      valid = false;
    }
    if (Decimal.Compare(this._totalPremium[dr.OfficeID], 0M) < 0 && Decimal.Compare(dr.Downpayment, 0M) > 0)
    {
      int num = (int) MessageBox.Show("The downpayment amount must be negative for credits.", "Invalid Downpayment Amount", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      valid = false;
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this._quote.PolicyTypeType, "CF", false) == 0 && (Decimal.Compare(dr.Downpayment, 0M) != 0 || dr.NumPayments != 1))
    {
      int num = (int) MessageBox.Show("Installment billing and downpayments are not allowed when courtesy filing.", "No Installment Billing", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      valid = false;
    }
    if (Decimal.Compare(Math.Abs(dr.Downpayment), Math.Abs(this._totalPremium[dr.OfficeID])) > 0)
    {
      int num = (int) MessageBox.Show("The downpayment amount can not exceed the premium being billed.", "Invalid Downpayment Amount", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      valid = false;
    }
    if (!SecurityManager.Instance.AssertPermission("{9CAF7677-3F75-1251-8039-D89312411156}") && this._quote.BillingType == 3 && this._quote.QuoteStatus == 7 && (Decimal.Compare(dr.Downpayment, 0M) != 0 || dr.NumPayments > 1))
    {
      int num = (int) MessageBox.Show("Installment billing is not available on cancellation endorsements.", "Invalid Installment Setup", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      valid = false;
    }
    if (!dr.IsDownpaymentBillingTypeIDNull())
    {
      string Left = DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "SELECT BillingCode FROM lstBillingTypes WHERE BillingTypeID = @ID", new object[2]
      {
        (object) "@ID",
        (object) dr.DownpaymentBillingTypeID
      });
      if (this._quote.BillingType != 3 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "DPCOM", false) == 0)
      {
        int num = (int) MessageBox.Show("This downpayment type requires the policy to be billed as Agency Bill.", "Invalid Installment Setup", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        valid = false;
      }
    }
    return valid;
  }

  protected virtual bool ValidForm()
  {
    bool valid = true;
    ((UltraGridBase) this.dgFees).UpdateData();
    try
    {
      foreach (dsInstallmentBillingOptions.tblInstallmentBillingRow installmentBillingRow in (TypedTableBase<dsInstallmentBillingOptions.tblInstallmentBillingRow>) this.ds.tblInstallmentBilling)
      {
        valid = this.ValidateDownpayment(valid, installmentBillingRow);
        if (valid)
          valid = this.ValidateNonZeroBilling(valid, installmentBillingRow);
        if (!valid)
          break;
      }
    }
    finally
    {
      IEnumerator<dsInstallmentBillingOptions.tblInstallmentBillingRow> enumerator;
      enumerator?.Dispose();
    }
    Decimal totalDownpayment = Utility.IsNull<Decimal>(RuntimeHelpers.GetObjectValue(this.ds.tblInstallmentBilling.Compute("SUM(Downpayment)", string.Empty)), 0M);
    if (valid)
    {
      valid = this.ValidateTotalNotExceeded(valid, totalDownpayment);
      if (valid)
        valid = this.ValidateBillingConfigurations(valid, totalDownpayment);
      if (valid)
        valid = this.ValidateInstallmentBillingRequirement(valid);
      if (valid)
        valid = this.ValidateCompanyLineBindingRequirements(valid);
    }
    return valid;
  }

  private bool ValidateCompanyLineBindingRequirements(bool valid)
  {
    if (this._quote.CompanyLine.IsRequiredForBind((CompanyLine.BindingRequirements) 9) && !this._quote.IsEndorsement && string.IsNullOrEmpty(((UltraCombo) this.cboCompanyOptions).Text))
    {
      int num = (int) MessageBox.Show("Installment billing option is required for binding as per Company/line binding requirement", "Installment Billing Option Required", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      valid = false;
    }
    return valid;
  }

  private bool ValidateInstallmentBillingRequirement(bool valid)
  {
    if (this._ValidateInstallmentBillingRequirement && this.ds.tblCompanyLineInstallments.Count > 1 && string.IsNullOrEmpty(((UltraCombo) this.cboCompanyOptions).Text))
    {
      int num = (int) MessageBox.Show("Installment billing option is required for binding", "Installment Billing Option Required", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      valid = false;
    }
    return valid;
  }

  private bool ValidateNonZeroBilling(
    bool valid,
    dsInstallmentBillingOptions.tblInstallmentBillingRow installment)
  {
    if (Decimal.Compare(installment.Downpayment, 0M) == 0 && installment.NumPayments == 0 && !this._officeHasFees[installment.OfficeID])
    {
      int num = (int) MessageBox.Show("You must specify a number of payments or a downpayment if there are no fees on the policy.", "Invalid Setup", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      valid = false;
    }
    return valid;
  }

  private bool ValidateTotalNotExceeded(bool valid, Decimal totalDownpayment)
  {
    if (Convert.ToDouble(totalDownpayment) > this._premium && this._premium >= 0.0 || Convert.ToDouble(totalDownpayment) < this._premium && this._premium < 0.0)
    {
      int num = (int) MessageBox.Show($"Downpayment amount exceeds the total premium of {Strings.FormatCurrency((object) this._premium)}.", "Invalid Downpayment Amount", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      valid = false;
    }
    else if (Convert.ToDouble(totalDownpayment) == this._premium && this._premium > 0.0 && this._quote.BillingType == 3)
    {
      int num = (int) MessageBox.Show($"The downpayment amount can not equal the total policy premium ({Strings.FormatCurrency((object) this._premium)}).", "Invalid Downpayment Amount", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      valid = false;
    }
    return valid;
  }

  private bool ValidateBillingConfigurations(bool valid, Decimal totalDownpayment)
  {
    bool flag;
    if (SystemSettings.KeyExists("AlternateBillingConfigValidation"))
    {
      if (SystemSettings.GetBoolSetting("AlternateBillingConfigValidation"))
      {
        try
        {
          foreach (dsInstallmentBillingOptions.tblInstallmentBillingRow installmentBillingRow in (TypedTableBase<dsInstallmentBillingOptions.tblInstallmentBillingRow>) this.ds.tblInstallmentBilling)
          {
            if (Decimal.Compare(installmentBillingRow.Downpayment, this._totalPremium[installmentBillingRow.OfficeID]) == 0 && Decimal.Compare(this._totalPremium[installmentBillingRow.OfficeID], 0M) != 0 && installmentBillingRow.NumPayments == 0 && this.ds.Fees.Select("AppliesToPaymentID IN ('F','E','B') AND OfficeID = " + installmentBillingRow.OfficeID.ToString()).Length > 0 && MessageBox.Show($"One or more assigned fees will not be disbursed due to current\ninstallment billing configuration for {this.ds.tblClientOffices.FindByOfficeID(installmentBillingRow.OfficeID).Location}. Continue anyway?", "Invalid Fee Setup", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
            {
              valid = false;
              break;
            }
          }
        }
        finally
        {
          IEnumerator<dsInstallmentBillingOptions.tblInstallmentBillingRow> enumerator;
          enumerator?.Dispose();
        }
        flag = valid;
        goto label_13;
      }
    }
    if (Convert.ToDouble(totalDownpayment) == this._premium && this._premium != 0.0 && this.ds.Fees.Select("AppliesToPaymentID='F' OR AppliesToPaymentID='E' OR AppliesToPaymentID='B'").Length > 0)
    {
      int num = (int) MessageBox.Show("One or more fees are assigned to invalid installment billing configurations,\nbecause there will only be one payment and no downpayment.", "Invalid Fee Setup", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      valid = false;
    }
    flag = valid;
label_13:
    return flag;
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
    if (!this.ValidForm())
      return;
    try
    {
      Cursor.Current = MgaCursors.WaitCursor;
      MDIControls.Instance.StatusBarText = "Saving options...";
      this.BindingContext[(object) this.ds, this.ds.tblInstallmentBilling.TableName].EndCurrentEdit();
      DefaultDatabase.DataAdapterUpdate(this.daInstallmentBilling, (DataTable) this.ds.tblInstallmentBilling);
      try
      {
        foreach (dsInstallmentBillingOptions.FeesRow fee in (TypedTableBase<dsInstallmentBillingOptions.FeesRow>) this.ds.Fees)
        {
          if (fee.RowState == DataRowState.Modified)
          {
            if (DefaultDatabase.ExecuteNonQuery(CommandType.Text, "UPDATE dbo.tblQuoteOptionCharges SET AppliesToPaymentID=@ID WHERE QuoteOptionGuid=@QOG AND ChargeCode=@CC", new object[6]
            {
              (object) "@ID",
              (object) fee.AppliesToPaymentID,
              (object) "@QOG",
              (object) fee.QuoteOptionGuid,
              (object) "@CC",
              (object) fee.ChargeCode
            }) == 0)
              throw new IncorrectNumberOfRowsAffectedException();
          }
        }
      }
      finally
      {
        IEnumerator<dsInstallmentBillingOptions.FeesRow> enumerator;
        enumerator?.Dispose();
      }
      MDIControls.Instance.StatusBarText = "Launching installment billing form...";
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((UltraCombo) this.cboCompanyOptions).Text, string.Empty, false) != 0)
        DefaultDatabase.ExecuteNonQuery(CommandType.Text, "UPDATE dbo.tblQuoteOptions SET CompanyInstallmentID=@CID WHERE QuoteOptionID=@QOID", new object[4]
        {
          (object) "@CID",
          ((UltraCombo) this.cboCompanyOptions).Value,
          (object) "@QOID",
          (object) this._quoteOption.QuoteOptionID
        });
      else
        DefaultDatabase.ExecuteNonQuery(CommandType.Text, "UPDATE dbo.tblQuoteOptions SET CompanyInstallmentID=NULL WHERE QuoteOptionID=@QOID", new object[2]
        {
          (object) "@QOID",
          (object) this._quoteOption.QuoteOptionID
        });
      DefaultDatabase.ExecuteNonQuery(CommandType.Text, "UPDATE dbo.tblQuotes SET InstallmentBillingQuoteOptionID=NULL WHERE QuoteGuid=@QuoteGuid", new object[4]
      {
        (object) "@QuoteOptionID",
        (object) this._quoteOption.QuoteOptionID,
        (object) "@QuoteGuid",
        (object) this._quote.QuoteGuid
      });
      if (this._configuratingPolicy)
      {
        DefaultDatabase.ExecuteNonQuery(CommandType.Text, "UPDATE dbo.tblQuotes SET InstallmentBillingQuoteOptionID=@QuoteOptionID WHERE QuoteGuid=@QuoteGuid", new object[4]
        {
          (object) "@QuoteOptionID",
          (object) this._quoteOption.QuoteOptionID,
          (object) "@QuoteGuid",
          (object) this._quote.QuoteGuid
        });
        frmInstallmentBilling.EnforceSingleFormInstance(this._quoteOption.QuoteOptionID);
        FormSettings.ShowForm(typeof (frmInstallmentBilling), new object[1]
        {
          (object) this._quoteOption.QuoteOptionID
        });
      }
      this._clickedSaveButton = true;
      this.Close();
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ErrorHandler.HandleError(ex);
      ProjectData.ClearProjectError();
    }
    finally
    {
      Cursor.Current = MgaCursors.Default;
      MDIControls.Instance.StatusBarText = string.Empty;
    }
  }

  internal static void EnforceSingleFormInstance(int quoteOptionID)
  {
    // ISSUE: variable of a compiler-generated type
    frmInstallmentBillingOptions._Closure\u0024__89\u002D0 closure890_1;
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    frmInstallmentBillingOptions._Closure\u0024__89\u002D0 closure890_2 = new frmInstallmentBillingOptions._Closure\u0024__89\u002D0(closure890_1);
    // ISSUE: reference to a compiler-generated field
    closure890_2.\u0024VB\u0024Local_quoteOptionID = quoteOptionID;
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
        foreach (Form form in MDIControls.Instance.MDIParent.MdiChildren.OfType<frmInstallmentBillingOptions>().Where<frmInstallmentBillingOptions>(closure890_2.\u0024I0 == null ? (closure890_2.\u0024I0 = new System.Func<frmInstallmentBillingOptions, bool>(closure890_2._Lambda\u0024__0)) : closure890_2.\u0024I0))
          form.Close();
      }
      finally
      {
        IEnumerator<frmInstallmentBillingOptions> enumerator;
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

  private void LayoutControls()
  {
    this.SuspendLayout();
    if (((UltraGridBase) this.dgFees).Rows.Count == 0)
      ((Control) this.dgFees).Height = 0;
    else
      ((Control) this.dgFees).Height = ((UltraGridBase) this.dgFees).Rows[0].Height * (((UltraGridBase) this.dgFees).Rows.Count + 2);
    if (((UltraGridBase) this.dgPayments).Rows.Count > 0)
      ((Control) this.dgPayments).Height = ((UltraGridBase) this.dgPayments).Rows[0].Height * (((UltraGridBase) this.dgPayments).Rows.Count + 2) + 1;
    ((Control) this.dgFees).Top = ((Control) this.dgPayments).Bottom + 7;
    this.Height = ((Control) this.dgFees).Bottom + 90;
    this.ResumeLayout();
  }

  private void cboCompanyOptions_ValueChanged(object sender, EventArgs e)
  {
    this.dgPayments.AfterCellUpdate -= new CellEventHandler(this.dgPayments_AfterCellUpdate);
    ((UltraGridBase) this.dgPayments).DisplayLayout.Bands[0].Columns["NumPayments"].CellActivation = (Activation) 0;
    if (((UltraCombo) this.cboCompanyOptions).Text == null || ((UltraCombo) this.cboCompanyOptions).Text.Length == 0)
    {
      try
      {
        foreach (dsInstallmentBillingOptions.tblInstallmentBillingRow installmentBillingRow in (TypedTableBase<dsInstallmentBillingOptions.tblInstallmentBillingRow>) this.ds.tblInstallmentBilling)
        {
          if (this._formLoaded || Decimal.Compare(installmentBillingRow.Downpayment, 0M) == 0 && installmentBillingRow.NumPayments <= 1 && installmentBillingRow.IsDownpaymentBillingTypeIDNull())
          {
            installmentBillingRow.Downpayment = 0M;
            installmentBillingRow.Percentage = 0M;
            installmentBillingRow.SetDownpaymentBillingTypeIDNull();
            installmentBillingRow.NumPayments = 1;
            installmentBillingRow.SingleInvoice = false;
          }
        }
      }
      finally
      {
        IEnumerator<dsInstallmentBillingOptions.tblInstallmentBillingRow> enumerator;
        enumerator?.Dispose();
      }
    }
    else
    {
      dsInstallmentBillingOptions.tblCompanyLineInstallmentsRow byId = this.ds.tblCompanyLineInstallments.FindByID((int) ((UltraCombo) this.cboCompanyOptions).Value);
      try
      {
        foreach (dsInstallmentBillingOptions.tblInstallmentBillingRow installmentBillingRow1 in (TypedTableBase<dsInstallmentBillingOptions.tblInstallmentBillingRow>) this.ds.tblInstallmentBilling)
        {
          if (!byId.IsSinglePayNull() && byId.SinglePay)
          {
            installmentBillingRow1.Percentage = 0M;
            installmentBillingRow1.Downpayment = 0M;
            installmentBillingRow1.SetDownpaymentBillingTypeIDNull();
          }
          else
          {
            installmentBillingRow1.Percentage = byId.DownpaymentPercentage;
            dsInstallmentBillingOptions.tblInstallmentBillingRow installmentBillingRow2 = installmentBillingRow1;
            int? nullable1;
            int? nullable2 = nullable1 = byId.Field<int?>("DownpaymentBillingTypeID");
            int valueOrDefault;
            if (!nullable2.HasValue)
            {
              nullable2 = this._quote.BillingTypeID;
              valueOrDefault = nullable2.Value;
            }
            else
              valueOrDefault = nullable1.GetValueOrDefault();
            installmentBillingRow2.DownpaymentBillingTypeID = valueOrDefault;
            installmentBillingRow1.Downpayment = Math.Round(Decimal.Multiply(byId.DownpaymentPercentage, this._totalPremium[installmentBillingRow1.OfficeID]), 2);
            if (!byId.IsMinimumDownPaymentNull() && Decimal.Compare(installmentBillingRow1.Downpayment, byId.MinimumDownPayment) < 0)
              installmentBillingRow1.Downpayment = Math.Round(byId.MinimumDownPayment, 2);
            if (this._roundPremiums)
              installmentBillingRow1.Downpayment = new Decimal(Convert.ToInt32(installmentBillingRow1.Downpayment));
          }
          installmentBillingRow1.NumPayments = byId.NumPayments;
          if (!byId.IsSinglePayNull() && byId.SinglePay && !this._officeHasFees[installmentBillingRow1.OfficeID])
            installmentBillingRow1.NumPayments = 1;
          installmentBillingRow1.SingleInvoice = !byId.IsSinglePayNull() && byId.SinglePay;
        }
      }
      finally
      {
        IEnumerator<dsInstallmentBillingOptions.tblInstallmentBillingRow> enumerator;
        enumerator?.Dispose();
      }
      if (!byId.IsSinglePayNull() && byId.SinglePay)
        ((UltraGridBase) this.dgPayments).DisplayLayout.Bands[0].Columns["NumPayments"].CellActivation = (Activation) 3;
    }
    this.SetInstallmentPlanActivationLevel();
    ((UltraGridBase) this.dgPayments).UpdateData();
    this.dgPayments.AfterCellUpdate += new CellEventHandler(this.dgPayments_AfterCellUpdate);
  }

  private void btnCancel_Click(object sender, EventArgs e) => this.Close();

  private void SetFormState(bool enableFormState)
  {
    try
    {
      foreach (Control control in this.Controls)
      {
        if (control.Tag == null || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(control.Tag.ToString(), "KeepEnabled", false) != 0)
          control.Enabled = enableFormState;
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    ((Control) this.btnSave).Enabled = false;
  }

  public virtual bool AlwaysAllowPennyPremiums()
  {
    return SystemSettings.KeyExists("AllowPennyInstallments") && SystemSettings.GetBoolSetting("AllowPennyInstallments");
  }

  protected virtual void SetInstallmentPlanActivationLevel()
  {
    if (this._canEditWithPreConfigPlan || this._isEndorsement || !((Control) this.cboCompanyOptions).Visible || ((UltraCombo) this.cboCompanyOptions).Text == null || ((UltraCombo) this.cboCompanyOptions).Text.Length == 0)
      return;
    ((UltraGridBase) this.dgPayments).DisplayLayout.Bands[0].Columns["NumPayments"].CellActivation = (Activation) 3;
    ((UltraGridBase) this.dgPayments).DisplayLayout.Bands[0].Columns["Downpayment"].CellActivation = (Activation) 3;
    ((UltraGridBase) this.dgPayments).DisplayLayout.Bands[0].Columns["DownpaymentBillingTypeID"].CellActivation = (Activation) 3;
    ((UltraGridBase) this.dgPayments).DisplayLayout.Bands[0].Columns["SingleInvoice"].CellActivation = (Activation) 3;
  }
}
