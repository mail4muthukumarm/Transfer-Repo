// Decompiled with JetBrains decompiler
// Type: MgaSystems.Ims.Fortegra.Overrides.Claims.Fortegra_FormClaimant
// Assembly: MgaSystems.Ims.Fortegra, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27007E94-85B4-4A1A-9444-255CCA5487B0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Fortegra.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.Layout;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using Infragistics.Win.UltraWinTabControl;
using Infragistics.Win.UltraWinToolbars;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Claims;
using MgaSystems.Ims.Fortegra.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

#nullable disable
namespace MgaSystems.Ims.Fortegra.Overrides.Claims;

[Override(typeof (FormClaimant))]
public class Fortegra_FormClaimant : FormClaimant
{
  private IContainer components;

  public Fortegra_FormClaimant() => this.InitializeComponent();

  public Fortegra_FormClaimant(Claim claim)
    : base(claim)
  {
    this.InitializeComponent();
  }

  public Fortegra_FormClaimant(Claim claim, Claimant claimant)
    : base(claim, claimant)
  {
    this.InitializeComponent();
  }

  public Fortegra_FormClaimant(Guid claimantGuid)
    : base(claimantGuid)
  {
    this.InitializeComponent();
  }

  protected override void SetToolbarEnabled()
  {
    UltraToolbar toolbar = this.ultraToolbarsManager1.Toolbars[0];
    if (((KeyedSubObjectsCollectionBase) ((UltraToolbarBase) toolbar).Tools).Exists("PAYMENTRETURN"))
      ((ToolsCollectionBase) ((UltraToolbarBase) toolbar).Tools)["PAYMENTRETURN"].SharedProps.Enabled = this.CurrentClaimant.CountPayments() > 0 && this.CurrentClaimant.StatusId == 0;
    if (((KeyedSubObjectsCollectionBase) ((UltraToolbarBase) toolbar).Tools).Exists("DELETEPAYMENT"))
      ((ToolsCollectionBase) ((UltraToolbarBase) toolbar).Tools)["DELETEPAYMENT"].SharedProps.Enabled = this.CurrentClaimant.CountPayments() > 0 && this.CurrentClaimant.StatusId == 0;
    if (((KeyedSubObjectsCollectionBase) ((UltraToolbarBase) toolbar).Tools).Exists("REOPENCLAIM"))
      ((ToolsCollectionBase) ((UltraToolbarBase) toolbar).Tools)["REOPENCLAIM"].SharedProps.Enabled = this.CurrentClaimant.StatusId == 1;
    if (((KeyedSubObjectsCollectionBase) ((UltraToolbarBase) toolbar).Tools).Exists("CLOSECLAIM"))
      ((ToolsCollectionBase) ((UltraToolbarBase) toolbar).Tools)["CLOSECLAIM"].SharedProps.Enabled = this.CurrentClaimant.StatusId == 0;
    if (((KeyedSubObjectsCollectionBase) ((UltraToolbarBase) toolbar).Tools).Exists("ADDRESERVE"))
      ((ToolsCollectionBase) ((UltraToolbarBase) toolbar).Tools)["ADDRESERVE"].SharedProps.Enabled = true;
    if (!((KeyedSubObjectsCollectionBase) ((UltraToolbarBase) toolbar).Tools).Exists("ADDPAYMENT"))
      return;
    ((ToolsCollectionBase) ((UltraToolbarBase) toolbar).Tools)["ADDPAYMENT"].SharedProps.Enabled = true;
  }

  protected override bool SaveClaimant(bool clearEntry)
  {
    if (this.dateTimeClaimant_DateReported.Value != null)
      return base.SaveClaimant(clearEntry);
    int num = (int) MessageBox.Show(this.BaseIsClosing ? "Date Reported required. Changes not saved." : "You must specify a date reported to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    return false;
  }

  protected override void CreateReservePaymentDataset()
  {
    this.dsReservesPayments1.Tables[0].PrimaryKey = (DataColumn[]) null;
    base.CreateReservePaymentDataset();
    if (((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout == null || this.CurrentClaimant == null || this.CurrentClaimant.Owner == null)
      return;
    UltraGridBand band = ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.Bands[0];
    if (!((KeyedSubObjectsCollectionBase) band.Columns).Exists("ChildLineGuid"))
    {
      UltraGridColumn ultraGridColumn1 = band.Columns.Add("ChildLineGuid", "ChildLineGuid");
      ultraGridColumn1.DataType = typeof (string);
      ultraGridColumn1.Group = band.Groups[0];
      ultraGridColumn1.Level = 0;
      ultraGridColumn1.CellActivation = (Activation) 3;
      ultraGridColumn1.Hidden = true;
      UltraGridColumn ultraGridColumn2 = band.Columns.Add("ChildLineDesc", "ChildLineDesc");
      ultraGridColumn2.DataType = typeof (string);
      ultraGridColumn2.Group = band.Groups[0];
      ultraGridColumn2.Level = 0;
      ultraGridColumn2.CellActivation = (Activation) 3;
      ((HeaderBase) ultraGridColumn2.Header).Caption = "Line (Child)";
      ultraGridColumn2.Hidden = false;
      UltraGridColumn ultraGridColumn3 = band.Columns.Add("TransactNum", "TransactNum");
      ultraGridColumn3.DataType = typeof (int);
      ultraGridColumn3.Group = band.Groups[0];
      ultraGridColumn3.Level = 0;
      ultraGridColumn3.Hidden = true;
    }
    Guid claimantGuid = this.CurrentClaimant.ClaimantGuid;
    if (this.CurrentClaimant.ClaimantGuid != Guid.Empty)
    {
      DataTable source1 = DefaultDatabase.ExecuteDataTable("dbo.Fortegra_GetCustomReservePaymentData", new object[2]
      {
        (object) "@claimantGuid",
        (object) this.CurrentClaimant.ClaimantGuid
      });
      if (source1.Rows.Count == 0)
      {
        this.SetUnsavedChildLine();
        return;
      }
      ((UltraControlBase) this.gridClaimants_ReservePayments).BeginUpdate();
      foreach (UltraGridRow row1 in ((UltraGridBase) this.gridClaimants_ReservePayments).Rows)
      {
        object resPayId = row1.Cells["ResPayId"].Value;
        EnumerableRowCollection<DataRow> source2 = source1.AsEnumerable().Where<DataRow>((System.Func<DataRow, bool>) (row => row.Field<int>("ResPayId") == (int) resPayId));
        if (source2.Count<DataRow>() > 0)
        {
          row1.Cells["ChildLineGuid"].Value = (object) Convert.ToString(source2.First<DataRow>().Field<object>("ChildLineGuid"));
          row1.Cells["ChildLineDesc"].Value = (object) source2.First<DataRow>().Field<string>("ChildLineDesc");
        }
      }
      band.ColumnFilters.ClearAllFilters();
      ((UltraControlBase) this.gridClaimants_ReservePayments).EndUpdate();
    }
    this.SetUnsavedChildLine();
  }

  private void SetUnsavedChildLine()
  {
    MemoryStream memoryStream = new MemoryStream();
    UltraGridBand band = ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.Bands[0];
    try
    {
      ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.Save((Stream) memoryStream);
      ((UltraControlBase) this.gridClaimants_ReservePayments).BeginUpdate();
      foreach (Fortegra_ReservePayment fortegraReservePayment in this.CurrentClaimant.ReservesAndPayments.AsEnumerable<PaymentReserve>().Where<PaymentReserve>((System.Func<PaymentReserve, bool>) (resPays => !resPays.ReservePaymentId.HasValue && resPays is Fortegra_ReservePayment && ((Fortegra_ReservePayment) resPays).ChildLineGuid != Guid.Empty)))
      {
        band.ColumnFilters.ClearAllFilters();
        band.ColumnFilters["ResPayId"].FilterConditions.Add((FilterComparisionOperator) 3, (object) 0);
        band.ColumnFilters["ResPayAmount"].FilterConditions.Add((FilterComparisionOperator) 0, (object) fortegraReservePayment.ReservePaymentAmount);
        band.ColumnFilters["ResPayType"].FilterConditions.Add((FilterComparisionOperator) 0, (object) fortegraReservePayment.ReservePaymentType);
        band.ColumnFilters["ResPaySubType"].FilterConditions.Add((FilterComparisionOperator) 0, (object) fortegraReservePayment.ReservePaymentSubType);
        band.ColumnFilters["CoverageType"].FilterConditions.Add((FilterComparisionOperator) 0, (object) fortegraReservePayment.CoverageType);
        band.ColumnFilters["CoverageTypeDescription"].FilterConditions.Add((FilterComparisionOperator) 0, (object) fortegraReservePayment.CoverageTypeDescription);
        band.ColumnFilters.LogicalOperator = (FilterLogicalOperator) 0;
        UltraGridRow[] inNonGroupByRows = ((UltraGridBase) this.gridClaimants_ReservePayments).Rows.GetFilteredInNonGroupByRows();
        foreach (UltraGridRow ultraGridRow in ((IEnumerable<UltraGridRow>) inNonGroupByRows).AsEnumerable<UltraGridRow>())
        {
          inNonGroupByRows[((IEnumerable<UltraGridRow>) inNonGroupByRows).Count<UltraGridRow>() - 1].Cells["ChildLineGuid"].Value = (object) fortegraReservePayment.ChildLineGuid.ToString();
          inNonGroupByRows[((IEnumerable<UltraGridRow>) inNonGroupByRows).Count<UltraGridRow>() - 1].Cells["ChildLineDesc"].Value = (object) fortegraReservePayment.ChildLineDesc;
        }
      }
    }
    finally
    {
      memoryStream.Position = 0L;
      ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.Load((Stream) memoryStream);
      band.ColumnFilters.ClearAllFilters();
      ((UltraControlBase) this.gridClaimants_ReservePayments).EndUpdate();
      memoryStream.Dispose();
    }
  }

  protected override void AddPayment(bool isPaymentReturn)
  {
    if (isPaymentReturn)
    {
      if (this.CurrentClaimant.CountPayments() == 0)
        return;
    }
    else if (this.CurrentClaimant.CountReserves() == 0)
      return;
    this.CreateClaimantLegalInformation(this.CurrentClaimant);
    this.ShowClaimantReserveTab();
    if (!isPaymentReturn)
    {
      if (this.CurrentClaimant.CountReserves() == 1)
      {
        foreach (UltraGridRow row in ((UltraGridBase) this.gridClaimants_ReservePayments).Rows)
        {
          if (row.Cells["EntryType"].Value.ToString() == "Reserve")
          {
            ((UltraGridBase) this.gridClaimants_ReservePayments).ActiveRow = row;
            ((GridItemBase) row).Selected = true;
            row.Activate();
          }
        }
      }
    }
    else if (this.CurrentClaimant.CountPayments() == 1)
    {
      foreach (UltraGridRow row in ((UltraGridBase) this.gridClaimants_ReservePayments).Rows)
      {
        if (row.Cells["EntryType"].Value.ToString() == "Payment")
        {
          ((UltraGridBase) this.gridClaimants_ReservePayments).ActiveRow = row;
          ((GridItemBase) row).Selected = true;
          row.Activate();
        }
      }
    }
    if (((UltraGridBase) this.gridClaimants_ReservePayments).ActiveRow == null || !isPaymentReturn && ((UltraGridBase) this.gridClaimants_ReservePayments).ActiveRow.Cells["EntryType"].Value.ToString() != "Reserve" || isPaymentReturn && ((UltraGridBase) this.gridClaimants_ReservePayments).ActiveRow.Cells["EntryType"].Value.ToString() != "Payment")
    {
      int num1 = (int) MessageBox.Show(Resources.RESERVEPAYMENT_RESERVEREQUIRED, Resources.ERROR_REQUIREDFIELD_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else
    {
      UltraGridRow activeRow = ((UltraGridBase) this.gridClaimants_ReservePayments).ActiveRow;
      if (activeRow == null)
        return;
      Guid empty = Guid.Empty;
      if (activeRow.Cells["ChildLineGuid"].Value != null)
        empty = Guid.Parse(activeRow.Cells["ChildLineGuid"].Value.ToString());
      using (FormAddPayment form = (FormAddPayment) ObjectFactory.Instance.CreateForm(typeof (FormAddPayment), new object[5]
      {
        (object) this._currentClaimant,
        (object) this._currentClaimant.GetReservePayment((int) activeRow.Cells["ResPayId"].Value),
        (object) isPaymentReturn,
        (object) empty,
        (object) this
      }))
      {
        form.OwnerForm = (FormClaimant) this;
        int num2 = (int) form.ShowDialog((IWin32Window) this);
      }
    }
  }

  protected override void CloseClaim()
  {
    using (Fortegra_FormClaimClose fortegraFormClaimClose = new Fortegra_FormClaimClose(this._currentClaimant))
    {
      if (fortegraFormClaimClose.ShowDialog() != DialogResult.OK)
        return;
    }
    base.CloseClaim();
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    ScrollBarLook scrollBarLook1 = new ScrollBarLook();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    UltraGridBand ultraGridBand = new UltraGridBand("ReservesPayments", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("ResPayId");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("EntryTypeId");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("EntryType");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("CoverageTypeId");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("CoverageType");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("CoverageTypeDescriptionId");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("CoverageTypeDescription");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("ResPayTypeId");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("ResPayType");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("ResPaySubTypeId");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("ResPaySubType");
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("ResPayAmount");
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("DateCreated");
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("CreatedByGuid");
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("CreatedBy");
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("Comments");
    UltraGridColumn ultraGridColumn17 = new UltraGridColumn("PayeeGuid");
    UltraGridColumn ultraGridColumn18 = new UltraGridColumn("Payee");
    UltraGridColumn ultraGridColumn19 = new UltraGridColumn("IsVoid");
    UltraGridColumn ultraGridColumn20 = new UltraGridColumn("IsPaymentReduction");
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    Appearance appearance17 = new Appearance();
    Appearance appearance18 = new Appearance();
    Appearance appearance19 = new Appearance();
    ScrollBarLook scrollBarLook2 = new ScrollBarLook();
    Appearance appearance20 = new Appearance();
    Appearance appearance21 = new Appearance();
    ((ISupportInitialize) this.checkClaimants_Closed).BeginInit();
    ((ISupportInitialize) this.maskedEditClaimants_SSNFEIN).BeginInit();
    ((ISupportInitialize) this.textClaimants_CorporationName).BeginInit();
    ((ISupportInitialize) this.textClaimants_FirstName).BeginInit();
    ((ISupportInitialize) this.textClaimants_MiddleName).BeginInit();
    ((ISupportInitialize) this.textClaimants_LastName).BeginInit();
    ((ISupportInitialize) this.checkClaimants_IsInsured).BeginInit();
    ((ISupportInitialize) this.optionClaimants_ClaimantType).BeginInit();
    ((ISupportInitialize) this.textClaimants_Comments).BeginInit();
    ((ISupportInitialize) this.tabControlClaimants).BeginInit();
    ((Control) this.tabControlClaimants).SuspendLayout();
    ((Control) this.tabPageClaimant).SuspendLayout();
    ((Control) this.tabPageLegal).SuspendLayout();
    ((Control) this.tabPageClaimSpecifications).SuspendLayout();
    ((ISupportInitialize) this.textClaimants_ClaimantAttorneyFEIN).BeginInit();
    ((ISupportInitialize) this.checkClaimants_PublishedDecision).BeginInit();
    ((ISupportInitialize) this.textClaimants_Judge).BeginInit();
    ((ISupportInitialize) this.textClaimants_ClaimantAttorney).BeginInit();
    ((ISupportInitialize) this.textClaimants_ClaimantLawFirm).BeginInit();
    ((ISupportInitialize) this.optionClaimantAttorneyEntityType).BeginInit();
    ((ISupportInitialize) this.dateTimeClaimant_DateDenied).BeginInit();
    ((ISupportInitialize) this.textClaimants_LastModifiedBy).BeginInit();
    ((ISupportInitialize) this.dateTimeClaimants_LastModified).BeginInit();
    ((ISupportInitialize) this.textClaimant_EnteredBy).BeginInit();
    ((ISupportInitialize) this.dateTimeClaimant_DateEntered).BeginInit();
    ((ISupportInitialize) this.dateTimeClaimant_DateReported).BeginInit();
    ((ISupportInitialize) this.gridClaimant_Coverages).BeginInit();
    ((ISupportInitialize) this.dateTimeClaimants_OutsideInvestigatorHireDate).BeginInit();
    ((ISupportInitialize) this.checkClaimants_Settled).BeginInit();
    ((ISupportInitialize) this.comboClaimants_SettlementType).BeginInit();
    ((ISupportInitialize) this.textClaimants_OutsideInvestigator).BeginInit();
    ((ISupportInitialize) this.comboClaimants_OutsideAdjuster).BeginInit();
    ((ISupportInitialize) this.comboClaimants_ManagedCare).BeginInit();
    ((ISupportInitialize) this.comboClaimants_LossType).BeginInit();
    ((ISupportInitialize) this.comboClaimant_AccidentTypes).BeginInit();
    ((ISupportInitialize) this.ultraToolbarsManager1).BeginInit();
    ((ISupportInitialize) this.textClaimants_DefenseFEIN).BeginInit();
    ((ISupportInitialize) this.textClaimants_DefenseAttorney).BeginInit();
    ((ISupportInitialize) this.textClaimants_DefenseFirm).BeginInit();
    ((ISupportInitialize) this.textClaimants_UserDefinedClaimantsID).BeginInit();
    ((ISupportInitialize) this.comboClaimants_Gender).BeginInit();
    ((ISupportInitialize) this.dateTimeClaimants_DOB).BeginInit();
    ((ISupportInitialize) this.textClaimants_EmailAddress).BeginInit();
    ((ISupportInitialize) this.checkClaimants_MedicareEligible).BeginInit();
    ((ISupportInitialize) this.dateTimeClaimants_SuitAnswered).BeginInit();
    ((ISupportInitialize) this.dateTimeClaimants_SuitServed).BeginInit();
    ((ISupportInitialize) this.checkClaimants_SuitServed).BeginInit();
    ((ISupportInitialize) this.optionDefenseEntityType).BeginInit();
    ((ISupportInitialize) this.gridClaimants_ReservePayments).BeginInit();
    this.dsReservesPayments1.BeginInit();
    ((ISupportInitialize) this.cboDefenseAttorney).BeginInit();
    ((ISupportInitialize) this.cboClaimantAttorney).BeginInit();
    ((ISupportInitialize) this.statusBar1).BeginInit();
    ((ISupportInitialize) this.Verisk_txtHICNMBI).BeginInit();
    ((ISupportInitialize) this.Verisk_txtICDCode).BeginInit();
    ((ISupportInitialize) this.Verisk_cboRepType).BeginInit();
    ((ISupportInitialize) this.Verisk_dtORMTermination).BeginInit();
    ((ISupportInitialize) this.Verisk_cboORMIndicator).BeginInit();
    ((ISupportInitialize) this.Verisk_txtApprovalComments).BeginInit();
    ((ISupportInitialize) this.Verisk_cboMedicareApproval).BeginInit();
    ((ISupportInitialize) this.Verisk_cboInsuranceType).BeginInit();
    ((ISupportInitialize) this.Verisk_dtInjuredDeathDate).BeginInit();
    ((ISupportInitialize) this.Verisk_dtFundingDelayed).BeginInit();
    ((ISupportInitialize) this.Verisk_dtExhaustDate).BeginInit();
    ((ISupportInitialize) this.Verisk_mgaNoFaultPolicyLimit).BeginInit();
    this.SuspendLayout();
    ((Control) this.tabControlClaimants).Size = new Size(1055, 617);
    ((UltraTabControlBase) this.tabControlClaimants).TabPageMargins.ForceSerialization = true;
    ((Control) this.tabPageClaimant).Location = new Point(1, 22);
    ((Control) this.tabPageClaimant).Size = new Size(1053, 594);
    ((Control) this.tabPageLegal).Size = new Size(1053, 594);
    ((Control) this.tabPageClaimSpecifications).Size = new Size(1053, 594);
    ((Control) this.ultraTabPageControl1).Size = new Size(1053, 594);
    this.phoneClaimants_ClaimantAttorney.PhoneLabelType = MgaPhoneNumberEntry.PhoneLabelTypes.Default;
    ((AppearanceBase) appearance1).BackColor = Color.White;
    ((AppearanceBase) appearance1).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridClaimant_Coverages).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.gridClaimant_Coverages).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((UltraGridBase) this.gridClaimant_Coverages).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance2).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance2).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance2).ForeColor = Color.Black;
    ((UltraGridBase) this.gridClaimant_Coverages).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance2;
    ((UltraGridBase) this.gridClaimant_Coverages).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridClaimant_Coverages).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridClaimant_Coverages).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance3).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridClaimant_Coverages).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance3;
    ((UltraGridBase) this.gridClaimant_Coverages).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance4).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.gridClaimant_Coverages).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance4;
    ((UltraGridBase) this.gridClaimant_Coverages).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance5).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridClaimant_Coverages).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance5;
    ((AppearanceBase) appearance6).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridClaimant_Coverages).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance6;
    ((UltraGridBase) this.gridClaimant_Coverages).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance7).BackColor = Color.Transparent;
    ((AppearanceBase) appearance7).ForeColor = Color.Black;
    ((UltraGridBase) this.gridClaimant_Coverages).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance7;
    ((AppearanceBase) appearance8).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance8).BorderColor = Color.Silver;
    scrollBarLook1.ButtonAppearance = (AppearanceBase) appearance8;
    ((AppearanceBase) appearance9).BackColor = Color.White;
    scrollBarLook1.TrackAppearance = (AppearanceBase) appearance9;
    ((UltraGridBase) this.gridClaimant_Coverages).DisplayLayout.ScrollBarLook = scrollBarLook1;
    ((SettingsBase) this.ultraToolbarsManager1.MenuSettings).ForceSerialization = true;
    this.ultraToolbarsManager1.ToolbarSettings.AllowCustomize = (DefaultableBoolean) 2;
    this.ultraToolbarsManager1.ToolbarSettings.AllowDockBottom = (DefaultableBoolean) 2;
    this.ultraToolbarsManager1.ToolbarSettings.AllowDockLeft = (DefaultableBoolean) 2;
    this.ultraToolbarsManager1.ToolbarSettings.AllowDockRight = (DefaultableBoolean) 2;
    this.ultraToolbarsManager1.ToolbarSettings.AllowDockTop = (DefaultableBoolean) 2;
    this.ultraToolbarsManager1.ToolbarSettings.AllowFloating = (DefaultableBoolean) 2;
    this.ultraToolbarsManager1.ToolbarSettings.AllowHiding = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance10).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    ((AppearanceBase) appearance10).BackColor2 = Color.White;
    ((AppearanceBase) appearance10).BackGradientAlignment = (GradientAlignment) 1;
    ((AppearanceBase) appearance10).BackGradientStyle = (GradientStyle) 14;
    ((SettingsBase) this.ultraToolbarsManager1.ToolbarSettings).Appearance = (AppearanceBase) appearance10;
    this.ultraToolbarsManager1.ToolbarSettings.FillEntireRow = (DefaultableBoolean) 1;
    this.ultraToolbarsManager1.ToolbarSettings.GrabHandleStyle = (GrabHandleStyle) 1;
    ((SettingsBase) this.ultraToolbarsManager1.ToolbarSettings).ToolDisplayStyle = (ToolDisplayStyle) 4;
    this.phoneClaimants_Primary.PhoneLabelType = MgaPhoneNumberEntry.PhoneLabelTypes.Default;
    this.phoneClaimants_Mailing.PhoneLabelType = MgaPhoneNumberEntry.PhoneLabelTypes.Default;
    this.phoneClaimants_DefenseAttorney.PhoneLabelType = MgaPhoneNumberEntry.PhoneLabelTypes.Default;
    ((AppearanceBase) appearance11).BackColor = Color.White;
    ((AppearanceBase) appearance11).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.Appearance = (AppearanceBase) appearance11;
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn1.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn1.Header).VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 30;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn2.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn2.Header).VisiblePosition = 11;
    ultraGridColumn2.Hidden = true;
    ultraGridColumn2.Width = 73;
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn3.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn3.Header).Caption = "Entry Type";
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn3.Header).VisiblePosition = 1;
    ultraGridColumn3.Width = 64 /*0x40*/;
    ultraGridColumn4.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn4.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn4.Header).VisiblePosition = 12;
    ultraGridColumn4.Hidden = true;
    ultraGridColumn4.Width = 59;
    ultraGridColumn5.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn5.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn5.Header).Caption = "Coverage Type";
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn5.Header).VisiblePosition = 9;
    ultraGridColumn5.Width = 68;
    ultraGridColumn6.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn6.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn6.Header).VisiblePosition = 13;
    ultraGridColumn6.Width = 50;
    ultraGridColumn7.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn7.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn7.Header).Caption = "Coverage Sub-Type";
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn7.Header).VisiblePosition = 10;
    ultraGridColumn7.Width = 68;
    ultraGridColumn8.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn8.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn8.Header).VisiblePosition = 14;
    ultraGridColumn8.Hidden = true;
    ultraGridColumn8.Width = 52;
    ultraGridColumn9.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn9.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn9.Header).Caption = "Type";
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn9.Header).VisiblePosition = 5;
    ultraGridColumn9.Width = 68;
    ultraGridColumn10.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn10.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn10.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn10.Header).VisiblePosition = 15;
    ultraGridColumn10.Hidden = true;
    ultraGridColumn10.Width = 64 /*0x40*/;
    ultraGridColumn11.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn11.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn11.Header).Caption = "Type Description";
    ((HeaderBase) ultraGridColumn11.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn11.Header).VisiblePosition = 7;
    ultraGridColumn11.Width = 68;
    ultraGridColumn12.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn12.CellActivation = (Activation) 3;
    ultraGridColumn12.Format = "c";
    ((HeaderBase) ultraGridColumn12.Header).Caption = "Amount";
    ((HeaderBase) ultraGridColumn12.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn12.Header).VisiblePosition = 8;
    ultraGridColumn12.Width = 60;
    ultraGridColumn13.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn13.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn13.Header).Caption = "Date Created";
    ((HeaderBase) ultraGridColumn13.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn13.Header).VisiblePosition = 3;
    ultraGridColumn13.Width = 82;
    ultraGridColumn14.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn14.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn14.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn14.Header).VisiblePosition = 16 /*0x10*/;
    ultraGridColumn14.Hidden = true;
    ultraGridColumn14.Width = 142;
    ultraGridColumn15.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn15.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn15.Header).Caption = "Created By";
    ((HeaderBase) ultraGridColumn15.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn15.Header).VisiblePosition = 2;
    ultraGridColumn15.Width = 61;
    ultraGridColumn16.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn16.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn16.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn16.Header).VisiblePosition = 6;
    ultraGridColumn16.MaxLength = 5000;
    ultraGridColumn16.Width = 192 /*0xC0*/;
    ultraGridColumn17.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn17.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn17.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn17.Header).VisiblePosition = 17;
    ultraGridColumn17.Width = 108;
    ultraGridColumn18.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn18.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn18.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn18.Header).VisiblePosition = 4;
    ultraGridColumn18.Width = 74;
    ((HeaderBase) ultraGridColumn19.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn19.Header).VisiblePosition = 18;
    ultraGridColumn19.Width = 28;
    ((HeaderBase) ultraGridColumn20.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn20.Header).VisiblePosition = 19;
    ultraGridColumn20.Width = 60;
    ultraGridBand.Columns.AddRange(new object[20]
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
      (object) ultraGridColumn19,
      (object) ultraGridColumn20
    });
    ultraGridBand.GroupHeadersVisible = false;
    ultraGridBand.LevelCount = 2;
    ultraGridBand.SummaryFooterCaption = "";
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance12).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance12).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance12).ForeColor = Color.Black;
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance12;
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.Override.AllowAddNew = (AllowAddNew) 2;
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.Override.AllowColMoving = (AllowColMoving) 1;
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.Override.AllowColSwapping = (AllowColSwapping) 1;
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 1;
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.Override.AllowGroupBy = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.Override.AllowGroupMoving = (AllowGroupMoving) 1;
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.Override.AllowGroupSwapping = (AllowGroupSwapping) 1;
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.Override.AllowMultiCellOperations = (AllowMultiCellOperation) 0;
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.Override.AllowRowLayoutCellSizing = (RowLayoutSizing) 1;
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.Override.AllowRowLayoutCellSpanSizing = (GridBagLayoutAllowSpanSizing) 1;
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.Override.AllowRowLayoutColMoving = (GridBagLayoutAllowMoving) 1;
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.Override.AllowRowLayoutLabelSizing = (RowLayoutSizing) 1;
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.Override.AllowRowLayoutLabelSpanSizing = (GridBagLayoutAllowSpanSizing) 1;
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.Override.AllowRowSummaries = (AllowRowSummaries) 2;
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 1;
    ((AppearanceBase) appearance13).BorderColor = Color.LightGray;
    ((AppearanceBase) appearance13).TextHAlignAsString = "Left";
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance13;
    ((AppearanceBase) appearance14).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((AppearanceBase) appearance14).TextHAlignAsString = "Left";
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance14;
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance15).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance15;
    ((AppearanceBase) appearance16).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance16;
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.Override.RowSpacingAfter = 1;
    ((AppearanceBase) appearance17).BackColor = Color.Transparent;
    ((AppearanceBase) appearance17).ForeColor = Color.Black;
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance17;
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.Override.SummaryFooterCaptionVisible = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance18).BackColor = Color.LightSteelBlue;
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.Override.SummaryValueAppearance = (AppearanceBase) appearance18;
    ((AppearanceBase) appearance19).BackColor = Color.LightSteelBlue;
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance19;
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.Override.TipStyleCell = (TipStyle) 2;
    ((AppearanceBase) appearance20).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance20).BorderColor = Color.Silver;
    scrollBarLook2.ButtonAppearance = (AppearanceBase) appearance20;
    ((AppearanceBase) appearance21).BackColor = Color.White;
    scrollBarLook2.TrackAppearance = (AppearanceBase) appearance21;
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.ScrollBarLook = scrollBarLook2;
    ((Control) this.gridClaimants_ReservePayments).Size = new Size(1053, 594);
    ((Control) this.statusBar1).Location = new Point(0, 663);
    ((Control) this.statusBar1).Size = new Size(1055, 23);
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(1055, 686);
    this.Name = nameof (Fortegra_FormClaimant);
    this.Text = "Add/Edit Claimant (Fortegra)";
    ((ISupportInitialize) this.checkClaimants_Closed).EndInit();
    ((ISupportInitialize) this.maskedEditClaimants_SSNFEIN).EndInit();
    ((ISupportInitialize) this.textClaimants_CorporationName).EndInit();
    ((ISupportInitialize) this.textClaimants_FirstName).EndInit();
    ((ISupportInitialize) this.textClaimants_MiddleName).EndInit();
    ((ISupportInitialize) this.textClaimants_LastName).EndInit();
    ((ISupportInitialize) this.checkClaimants_IsInsured).EndInit();
    ((ISupportInitialize) this.optionClaimants_ClaimantType).EndInit();
    ((ISupportInitialize) this.textClaimants_Comments).EndInit();
    ((ISupportInitialize) this.tabControlClaimants).EndInit();
    ((Control) this.tabControlClaimants).ResumeLayout(false);
    ((Control) this.tabPageClaimant).ResumeLayout(false);
    ((Control) this.tabPageClaimant).PerformLayout();
    ((Control) this.tabPageLegal).ResumeLayout(false);
    ((Control) this.tabPageLegal).PerformLayout();
    ((Control) this.tabPageClaimSpecifications).ResumeLayout(false);
    ((Control) this.tabPageClaimSpecifications).PerformLayout();
    ((ISupportInitialize) this.textClaimants_ClaimantAttorneyFEIN).EndInit();
    ((ISupportInitialize) this.checkClaimants_PublishedDecision).EndInit();
    ((ISupportInitialize) this.textClaimants_Judge).EndInit();
    ((ISupportInitialize) this.textClaimants_ClaimantAttorney).EndInit();
    ((ISupportInitialize) this.textClaimants_ClaimantLawFirm).EndInit();
    ((ISupportInitialize) this.optionClaimantAttorneyEntityType).EndInit();
    ((ISupportInitialize) this.dateTimeClaimant_DateDenied).EndInit();
    ((ISupportInitialize) this.textClaimants_LastModifiedBy).EndInit();
    ((ISupportInitialize) this.dateTimeClaimants_LastModified).EndInit();
    ((ISupportInitialize) this.textClaimant_EnteredBy).EndInit();
    ((ISupportInitialize) this.dateTimeClaimant_DateEntered).EndInit();
    ((ISupportInitialize) this.dateTimeClaimant_DateReported).EndInit();
    ((ISupportInitialize) this.gridClaimant_Coverages).EndInit();
    ((ISupportInitialize) this.dateTimeClaimants_OutsideInvestigatorHireDate).EndInit();
    ((ISupportInitialize) this.checkClaimants_Settled).EndInit();
    ((ISupportInitialize) this.comboClaimants_SettlementType).EndInit();
    ((ISupportInitialize) this.textClaimants_OutsideInvestigator).EndInit();
    ((ISupportInitialize) this.comboClaimants_OutsideAdjuster).EndInit();
    ((ISupportInitialize) this.comboClaimants_ManagedCare).EndInit();
    ((ISupportInitialize) this.comboClaimants_LossType).EndInit();
    ((ISupportInitialize) this.comboClaimant_AccidentTypes).EndInit();
    ((ISupportInitialize) this.ultraToolbarsManager1).EndInit();
    ((ISupportInitialize) this.textClaimants_DefenseFEIN).EndInit();
    ((ISupportInitialize) this.textClaimants_DefenseAttorney).EndInit();
    ((ISupportInitialize) this.textClaimants_DefenseFirm).EndInit();
    ((ISupportInitialize) this.textClaimants_UserDefinedClaimantsID).EndInit();
    ((ISupportInitialize) this.comboClaimants_Gender).EndInit();
    ((ISupportInitialize) this.dateTimeClaimants_DOB).EndInit();
    ((ISupportInitialize) this.textClaimants_EmailAddress).EndInit();
    ((ISupportInitialize) this.checkClaimants_MedicareEligible).EndInit();
    ((ISupportInitialize) this.dateTimeClaimants_SuitAnswered).EndInit();
    ((ISupportInitialize) this.dateTimeClaimants_SuitServed).EndInit();
    ((ISupportInitialize) this.checkClaimants_SuitServed).EndInit();
    ((ISupportInitialize) this.optionDefenseEntityType).EndInit();
    ((ISupportInitialize) this.gridClaimants_ReservePayments).EndInit();
    this.dsReservesPayments1.EndInit();
    ((ISupportInitialize) this.cboDefenseAttorney).EndInit();
    ((ISupportInitialize) this.cboClaimantAttorney).EndInit();
    ((ISupportInitialize) this.statusBar1).EndInit();
    ((ISupportInitialize) this.Verisk_txtHICNMBI).EndInit();
    ((ISupportInitialize) this.Verisk_txtICDCode).EndInit();
    ((ISupportInitialize) this.Verisk_cboRepType).EndInit();
    ((ISupportInitialize) this.Verisk_dtORMTermination).EndInit();
    ((ISupportInitialize) this.Verisk_cboORMIndicator).EndInit();
    ((ISupportInitialize) this.Verisk_txtApprovalComments).EndInit();
    ((ISupportInitialize) this.Verisk_cboMedicareApproval).EndInit();
    ((ISupportInitialize) this.Verisk_cboInsuranceType).EndInit();
    ((ISupportInitialize) this.Verisk_dtInjuredDeathDate).EndInit();
    ((ISupportInitialize) this.Verisk_dtFundingDelayed).EndInit();
    ((ISupportInitialize) this.Verisk_dtExhaustDate).EndInit();
    ((ISupportInitialize) this.Verisk_mgaNoFaultPolicyLimit).EndInit();
    this.ResumeLayout(false);
  }
}
