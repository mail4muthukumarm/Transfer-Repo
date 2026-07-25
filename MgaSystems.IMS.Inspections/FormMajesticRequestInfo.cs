// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Inspections.FormMajesticRequestInfo
// Assembly: MgaSystems.IMS.Inspections, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 07B8D1F3-634C-445B-ABFB-027DE209A43D
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Inspections.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinMaskedEdit;
using MGASystems.Data;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies.Inspections;

[DesignerGenerated]
public class FormMajesticRequestInfo : Form
{
  private IContainer components;
  private Guid _quoteGuid;

  [DebuggerNonUserCode]
  protected override void Dispose(bool disposing)
  {
    try
    {
      if (!disposing || this.components == null)
        return;
      this.components.Dispose();
    }
    finally
    {
      base.Dispose(disposing);
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
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
    Appearance appearance34 = new Appearance();
    Appearance appearance35 = new Appearance();
    Appearance appearance36 = new Appearance();
    Appearance appearance37 = new Appearance();
    Appearance appearance38 = new Appearance();
    Appearance appearance39 = new Appearance();
    Appearance appearance40 = new Appearance();
    Appearance appearance41 = new Appearance();
    Appearance appearance42 = new Appearance();
    Appearance appearance43 = new Appearance();
    Appearance appearance44 = new Appearance();
    Appearance appearance45 = new Appearance();
    Appearance appearance46 = new Appearance();
    this.grpInspection = new UltraGroupBox();
    this.numReceiptsAmount = new MGANumericEditor();
    this.numPayrollAmount = new MGANumericEditor();
    this.chkCoverageTypeProducts = new MGACheckBox();
    this.chkCoverageTypeGlassCoverage = new MGACheckBox();
    this.chkCoverageTypeGarageLiability = new MGACheckBox();
    this.chkCoverageTypeGarageKeepers = new MGACheckBox();
    this.chkCoverageTypeLiquorLegal = new MGACheckBox();
    this.chkCoverageTypeAutoFleetSurvey = new MGACheckBox();
    this.chkCoverageTypeRestaurant = new MGACheckBox();
    this.chkCoverageTypeAllRisk = new MGACheckBox();
    this.Label13 = new Label();
    this.Label12 = new Label();
    this.Label11 = new Label();
    this.chkConfirmAmountsReceipts = new MGACheckBox();
    this.chkConfirmAmountsPayroll = new MGACheckBox();
    this.Label10 = new Label();
    this.chkHomeOwnerFullReport = new MGACheckBox();
    this.chkHomeOwnerExterior = new MGACheckBox();
    this.Label9 = new Label();
    this.chkManuContrPremises = new MGACheckBox();
    this.chkManuContrJobsite = new MGACheckBox();
    this.Label8 = new Label();
    this.chkVacantBuildingInteriorRequired = new MGACheckBox();
    this.chkCoverageTypeWorkersComp = new MGACheckBox();
    this.chkVacantBuildingExteriorOnly = new MGACheckBox();
    this.chkCoverageTypeFire = new MGACheckBox();
    this.Label7 = new Label();
    this.chkCoverageTypeLiability = new MGACheckBox();
    this.chkPropertyCoverageInterior = new MGACheckBox();
    this.chkPropertyCoverageContents = new MGACheckBox();
    this.chkPropertyCoverageBuilding = new MGACheckBox();
    this.chkManuContrPhone = new MGACheckBox();
    this.chkPropertyCoverageExterior = new MGACheckBox();
    this.Label6 = new Label();
    this.Label5 = new Label();
    this.chkPropertyTypeOther = new MGACheckBox();
    this.chkPropertyTypeRetailStore = new MGACheckBox();
    this.chkPropertyTypeOfficeBuilding = new MGACheckBox();
    this.chkPropertyTypeBuildingOwner = new MGACheckBox();
    this.chkPropertyTypeApartmentBuilding = new MGACheckBox();
    this.chkPropertyTypeLessorsRiskOnly = new MGACheckBox();
    this.chkPropertyTypeMercantile = new MGACheckBox();
    this.Label4 = new Label();
    this.txtPropertyTypeDescription = new MGATextBox();
    this.rbRushRequestYes = new RadioButton();
    this.rbRushRequestNo = new RadioButton();
    this.Label3 = new Label();
    this.Label2 = new Label();
    this.Label1 = new Label();
    this.chkCostEstimatorReplacementCost = new MGACheckBox();
    this.chkCostEstimatorActualCashValue = new MGACheckBox();
    this.chkCostEstimatorInsuranceToValue = new MGACheckBox();
    this.chkInspectionTypeDiagram = new MGACheckBox();
    this.chkInspectionTypeShortForm = new MGACheckBox();
    this.chkInspectionTypeRecommendation = new MGACheckBox();
    this.chkInspectionTypeDriveBy = new MGACheckBox();
    this.chkInspectionTypeFullReport = new MGACheckBox();
    this.btnCancel = new MGAButton();
    this.btnSave = new MGAButton();
    this.lnkClearForm = new LinkLabel();
    this.chkBuildersRisk = new MGACheckBox();
    ((ISupportInitialize) this.grpInspection).BeginInit();
    ((Control) this.grpInspection).SuspendLayout();
    ((ISupportInitialize) this.numReceiptsAmount).BeginInit();
    ((ISupportInitialize) this.numPayrollAmount).BeginInit();
    ((ISupportInitialize) this.chkCoverageTypeProducts).BeginInit();
    ((ISupportInitialize) this.chkCoverageTypeGlassCoverage).BeginInit();
    ((ISupportInitialize) this.chkCoverageTypeGarageLiability).BeginInit();
    ((ISupportInitialize) this.chkCoverageTypeGarageKeepers).BeginInit();
    ((ISupportInitialize) this.chkCoverageTypeLiquorLegal).BeginInit();
    ((ISupportInitialize) this.chkCoverageTypeAutoFleetSurvey).BeginInit();
    ((ISupportInitialize) this.chkCoverageTypeRestaurant).BeginInit();
    ((ISupportInitialize) this.chkCoverageTypeAllRisk).BeginInit();
    ((ISupportInitialize) this.chkConfirmAmountsReceipts).BeginInit();
    ((ISupportInitialize) this.chkConfirmAmountsPayroll).BeginInit();
    ((ISupportInitialize) this.chkHomeOwnerFullReport).BeginInit();
    ((ISupportInitialize) this.chkHomeOwnerExterior).BeginInit();
    ((ISupportInitialize) this.chkManuContrPremises).BeginInit();
    ((ISupportInitialize) this.chkManuContrJobsite).BeginInit();
    ((ISupportInitialize) this.chkVacantBuildingInteriorRequired).BeginInit();
    ((ISupportInitialize) this.chkCoverageTypeWorkersComp).BeginInit();
    ((ISupportInitialize) this.chkVacantBuildingExteriorOnly).BeginInit();
    ((ISupportInitialize) this.chkCoverageTypeFire).BeginInit();
    ((ISupportInitialize) this.chkCoverageTypeLiability).BeginInit();
    ((ISupportInitialize) this.chkPropertyCoverageInterior).BeginInit();
    ((ISupportInitialize) this.chkPropertyCoverageContents).BeginInit();
    ((ISupportInitialize) this.chkPropertyCoverageBuilding).BeginInit();
    ((ISupportInitialize) this.chkManuContrPhone).BeginInit();
    ((ISupportInitialize) this.chkPropertyCoverageExterior).BeginInit();
    ((ISupportInitialize) this.chkPropertyTypeOther).BeginInit();
    ((ISupportInitialize) this.chkPropertyTypeRetailStore).BeginInit();
    ((ISupportInitialize) this.chkPropertyTypeOfficeBuilding).BeginInit();
    ((ISupportInitialize) this.chkPropertyTypeBuildingOwner).BeginInit();
    ((ISupportInitialize) this.chkPropertyTypeApartmentBuilding).BeginInit();
    ((ISupportInitialize) this.chkPropertyTypeLessorsRiskOnly).BeginInit();
    ((ISupportInitialize) this.chkPropertyTypeMercantile).BeginInit();
    ((ISupportInitialize) this.txtPropertyTypeDescription).BeginInit();
    ((ISupportInitialize) this.chkCostEstimatorReplacementCost).BeginInit();
    ((ISupportInitialize) this.chkCostEstimatorActualCashValue).BeginInit();
    ((ISupportInitialize) this.chkCostEstimatorInsuranceToValue).BeginInit();
    ((ISupportInitialize) this.chkInspectionTypeDiagram).BeginInit();
    ((ISupportInitialize) this.chkInspectionTypeShortForm).BeginInit();
    ((ISupportInitialize) this.chkInspectionTypeRecommendation).BeginInit();
    ((ISupportInitialize) this.chkInspectionTypeDriveBy).BeginInit();
    ((ISupportInitialize) this.chkInspectionTypeFullReport).BeginInit();
    ((ISupportInitialize) this.btnCancel).BeginInit();
    ((ISupportInitialize) this.btnSave).BeginInit();
    ((ISupportInitialize) this.chkBuildersRisk).BeginInit();
    this.SuspendLayout();
    ((Control) this.grpInspection).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    appearance1.BackColor = Color.FromArgb(240 /*0xF0*/, 247, 253);
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.grpInspection.ContentAreaAppearance = (AppearanceBase) appearance1;
    ((Control) this.grpInspection).Controls.Add((Control) this.chkBuildersRisk);
    ((Control) this.grpInspection).Controls.Add((Control) this.numReceiptsAmount);
    ((Control) this.grpInspection).Controls.Add((Control) this.numPayrollAmount);
    ((Control) this.grpInspection).Controls.Add((Control) this.chkCoverageTypeProducts);
    ((Control) this.grpInspection).Controls.Add((Control) this.chkCoverageTypeGlassCoverage);
    ((Control) this.grpInspection).Controls.Add((Control) this.chkCoverageTypeGarageLiability);
    ((Control) this.grpInspection).Controls.Add((Control) this.chkCoverageTypeGarageKeepers);
    ((Control) this.grpInspection).Controls.Add((Control) this.chkCoverageTypeLiquorLegal);
    ((Control) this.grpInspection).Controls.Add((Control) this.chkCoverageTypeAutoFleetSurvey);
    ((Control) this.grpInspection).Controls.Add((Control) this.chkCoverageTypeRestaurant);
    ((Control) this.grpInspection).Controls.Add((Control) this.chkCoverageTypeAllRisk);
    ((Control) this.grpInspection).Controls.Add((Control) this.Label13);
    ((Control) this.grpInspection).Controls.Add((Control) this.Label12);
    ((Control) this.grpInspection).Controls.Add((Control) this.Label11);
    ((Control) this.grpInspection).Controls.Add((Control) this.chkConfirmAmountsReceipts);
    ((Control) this.grpInspection).Controls.Add((Control) this.chkConfirmAmountsPayroll);
    ((Control) this.grpInspection).Controls.Add((Control) this.Label10);
    ((Control) this.grpInspection).Controls.Add((Control) this.chkHomeOwnerFullReport);
    ((Control) this.grpInspection).Controls.Add((Control) this.chkHomeOwnerExterior);
    ((Control) this.grpInspection).Controls.Add((Control) this.Label9);
    ((Control) this.grpInspection).Controls.Add((Control) this.chkManuContrPremises);
    ((Control) this.grpInspection).Controls.Add((Control) this.chkManuContrJobsite);
    ((Control) this.grpInspection).Controls.Add((Control) this.Label8);
    ((Control) this.grpInspection).Controls.Add((Control) this.chkVacantBuildingInteriorRequired);
    ((Control) this.grpInspection).Controls.Add((Control) this.chkCoverageTypeWorkersComp);
    ((Control) this.grpInspection).Controls.Add((Control) this.chkVacantBuildingExteriorOnly);
    ((Control) this.grpInspection).Controls.Add((Control) this.chkCoverageTypeFire);
    ((Control) this.grpInspection).Controls.Add((Control) this.Label7);
    ((Control) this.grpInspection).Controls.Add((Control) this.chkCoverageTypeLiability);
    ((Control) this.grpInspection).Controls.Add((Control) this.chkPropertyCoverageInterior);
    ((Control) this.grpInspection).Controls.Add((Control) this.chkPropertyCoverageContents);
    ((Control) this.grpInspection).Controls.Add((Control) this.chkPropertyCoverageBuilding);
    ((Control) this.grpInspection).Controls.Add((Control) this.chkManuContrPhone);
    ((Control) this.grpInspection).Controls.Add((Control) this.chkPropertyCoverageExterior);
    ((Control) this.grpInspection).Controls.Add((Control) this.Label6);
    ((Control) this.grpInspection).Controls.Add((Control) this.Label5);
    ((Control) this.grpInspection).Controls.Add((Control) this.chkPropertyTypeOther);
    ((Control) this.grpInspection).Controls.Add((Control) this.chkPropertyTypeRetailStore);
    ((Control) this.grpInspection).Controls.Add((Control) this.chkPropertyTypeOfficeBuilding);
    ((Control) this.grpInspection).Controls.Add((Control) this.chkPropertyTypeBuildingOwner);
    ((Control) this.grpInspection).Controls.Add((Control) this.chkPropertyTypeApartmentBuilding);
    ((Control) this.grpInspection).Controls.Add((Control) this.chkPropertyTypeLessorsRiskOnly);
    ((Control) this.grpInspection).Controls.Add((Control) this.chkPropertyTypeMercantile);
    ((Control) this.grpInspection).Controls.Add((Control) this.Label4);
    ((Control) this.grpInspection).Controls.Add((Control) this.txtPropertyTypeDescription);
    ((Control) this.grpInspection).Controls.Add((Control) this.rbRushRequestYes);
    ((Control) this.grpInspection).Controls.Add((Control) this.rbRushRequestNo);
    ((Control) this.grpInspection).Controls.Add((Control) this.Label3);
    ((Control) this.grpInspection).Controls.Add((Control) this.Label2);
    ((Control) this.grpInspection).Controls.Add((Control) this.Label1);
    ((Control) this.grpInspection).Controls.Add((Control) this.chkCostEstimatorReplacementCost);
    ((Control) this.grpInspection).Controls.Add((Control) this.chkCostEstimatorActualCashValue);
    ((Control) this.grpInspection).Controls.Add((Control) this.chkCostEstimatorInsuranceToValue);
    ((Control) this.grpInspection).Controls.Add((Control) this.chkInspectionTypeDiagram);
    ((Control) this.grpInspection).Controls.Add((Control) this.chkInspectionTypeShortForm);
    ((Control) this.grpInspection).Controls.Add((Control) this.chkInspectionTypeRecommendation);
    ((Control) this.grpInspection).Controls.Add((Control) this.chkInspectionTypeDriveBy);
    ((Control) this.grpInspection).Controls.Add((Control) this.chkInspectionTypeFullReport);
    ((Control) this.grpInspection).Location = new Point(12, 2);
    ((Control) this.grpInspection).Name = "grpInspection";
    ((Control) this.grpInspection).Size = new Size(702, 549);
    ((Control) this.grpInspection).TabIndex = 0;
    this.grpInspection.Text = "Inspection Online Request";
    appearance2.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.numReceiptsAmount).Appearance = (AppearanceBase) appearance2;
    ((UltraNumericEditorBase) this.numReceiptsAmount).FormatString = "";
    ((Control) this.numReceiptsAmount).Location = new Point(137, 441);
    this.numReceiptsAmount.MaskInput = "nnnnnnnnnnnnnnn.nnnn";
    this.numReceiptsAmount.MaxValue = (object) new Decimal(new int[4]
    {
      -1486618625,
      232830643,
      0,
      262144 /*0x040000*/
    });
    this.numReceiptsAmount.MGAStyle = MGAStyles.Blue;
    this.numReceiptsAmount.MinValue = (object) 0;
    ((Control) this.numReceiptsAmount).Name = "numReceiptsAmount";
    this.numReceiptsAmount.Nullable = true;
    this.numReceiptsAmount.NumericType = (NumericType) 2;
    ((Control) this.numReceiptsAmount).Size = new Size(130, 19);
    ((Control) this.numReceiptsAmount).TabIndex = 32 /*0x20*/;
    ((UltraWinEditorMaskedControlBase) this.numReceiptsAmount).TabNavigation = (MaskedEditTabNavigation) 0;
    ((UltraControlBase) this.numReceiptsAmount).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numReceiptsAmount).UseOsThemes = (DefaultableBoolean) 2;
    this.numReceiptsAmount.Value = (object) null;
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.numPayrollAmount).Appearance = (AppearanceBase) appearance3;
    ((UltraNumericEditorBase) this.numPayrollAmount).FormatString = "";
    ((Control) this.numPayrollAmount).Location = new Point(137, 417);
    this.numPayrollAmount.MaskInput = "nnnnnnnnnnnnnnn.nnnn";
    this.numPayrollAmount.MaxValue = (object) new Decimal(new int[4]
    {
      -1486618625,
      232830643,
      0,
      262144 /*0x040000*/
    });
    this.numPayrollAmount.MGAStyle = MGAStyles.Blue;
    this.numPayrollAmount.MinValue = (object) 0;
    ((Control) this.numPayrollAmount).Name = "numPayrollAmount";
    this.numPayrollAmount.Nullable = true;
    this.numPayrollAmount.NumericType = (NumericType) 2;
    ((Control) this.numPayrollAmount).Size = new Size(130, 19);
    ((Control) this.numPayrollAmount).TabIndex = 31 /*0x1F*/;
    ((UltraWinEditorMaskedControlBase) this.numPayrollAmount).TabNavigation = (MaskedEditTabNavigation) 0;
    ((UltraControlBase) this.numPayrollAmount).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numPayrollAmount).UseOsThemes = (DefaultableBoolean) 2;
    this.numPayrollAmount.Value = (object) null;
    appearance4.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance4.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkCoverageTypeProducts).Appearance = (AppearanceBase) appearance4;
    ((UltraToggleEditorBase) this.chkCoverageTypeProducts).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkCoverageTypeProducts).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkCoverageTypeProducts).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkCoverageTypeProducts).Location = new Point(267, 526);
    this.chkCoverageTypeProducts.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkCoverageTypeProducts).Name = "chkCoverageTypeProducts";
    ((Control) this.chkCoverageTypeProducts).Size = new Size(80 /*0x50*/, 20);
    ((Control) this.chkCoverageTypeProducts).TabIndex = 42;
    ((UltraToggleEditorBase) this.chkCoverageTypeProducts).Text = "Products";
    ((UltraControlBase) this.chkCoverageTypeProducts).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkCoverageTypeProducts).UseOsThemes = (DefaultableBoolean) 2;
    appearance5.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance5.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkCoverageTypeGlassCoverage).Appearance = (AppearanceBase) appearance5;
    ((UltraToggleEditorBase) this.chkCoverageTypeGlassCoverage).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkCoverageTypeGlassCoverage).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkCoverageTypeGlassCoverage).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkCoverageTypeGlassCoverage).Location = new Point(141, 526);
    this.chkCoverageTypeGlassCoverage.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkCoverageTypeGlassCoverage).Name = "chkCoverageTypeGlassCoverage";
    ((Control) this.chkCoverageTypeGlassCoverage).Size = new Size(110, 20);
    ((Control) this.chkCoverageTypeGlassCoverage).TabIndex = 41;
    ((UltraToggleEditorBase) this.chkCoverageTypeGlassCoverage).Text = "Glass Coverage";
    ((UltraControlBase) this.chkCoverageTypeGlassCoverage).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkCoverageTypeGlassCoverage).UseOsThemes = (DefaultableBoolean) 2;
    appearance6.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance6.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkCoverageTypeGarageLiability).Appearance = (AppearanceBase) appearance6;
    ((UltraToggleEditorBase) this.chkCoverageTypeGarageLiability).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkCoverageTypeGarageLiability).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkCoverageTypeGarageLiability).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkCoverageTypeGarageLiability).Location = new Point(492, 500);
    this.chkCoverageTypeGarageLiability.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkCoverageTypeGarageLiability).Name = "chkCoverageTypeGarageLiability";
    ((Control) this.chkCoverageTypeGarageLiability).Size = new Size(110, 20);
    ((Control) this.chkCoverageTypeGarageLiability).TabIndex = 40;
    ((UltraToggleEditorBase) this.chkCoverageTypeGarageLiability).Text = "Garage Liability";
    ((UltraControlBase) this.chkCoverageTypeGarageLiability).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkCoverageTypeGarageLiability).UseOsThemes = (DefaultableBoolean) 2;
    appearance7.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance7.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkCoverageTypeGarageKeepers).Appearance = (AppearanceBase) appearance7;
    ((UltraToggleEditorBase) this.chkCoverageTypeGarageKeepers).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkCoverageTypeGarageKeepers).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkCoverageTypeGarageKeepers).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkCoverageTypeGarageKeepers).Location = new Point(373, 500);
    this.chkCoverageTypeGarageKeepers.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkCoverageTypeGarageKeepers).Name = "chkCoverageTypeGarageKeepers";
    ((Control) this.chkCoverageTypeGarageKeepers).Size = new Size(113, 20);
    ((Control) this.chkCoverageTypeGarageKeepers).TabIndex = 39;
    ((UltraToggleEditorBase) this.chkCoverageTypeGarageKeepers).Text = "Garage Keepers";
    ((UltraControlBase) this.chkCoverageTypeGarageKeepers).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkCoverageTypeGarageKeepers).UseOsThemes = (DefaultableBoolean) 2;
    appearance8.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance8.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkCoverageTypeLiquorLegal).Appearance = (AppearanceBase) appearance8;
    ((UltraToggleEditorBase) this.chkCoverageTypeLiquorLegal).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkCoverageTypeLiquorLegal).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkCoverageTypeLiquorLegal).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkCoverageTypeLiquorLegal).Location = new Point(266, 500);
    this.chkCoverageTypeLiquorLegal.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkCoverageTypeLiquorLegal).Name = "chkCoverageTypeLiquorLegal";
    ((Control) this.chkCoverageTypeLiquorLegal).Size = new Size(101, 20);
    ((Control) this.chkCoverageTypeLiquorLegal).TabIndex = 38;
    ((UltraToggleEditorBase) this.chkCoverageTypeLiquorLegal).Text = "Liquor Legal";
    ((UltraControlBase) this.chkCoverageTypeLiquorLegal).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkCoverageTypeLiquorLegal).UseOsThemes = (DefaultableBoolean) 2;
    appearance9.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance9.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkCoverageTypeAutoFleetSurvey).Appearance = (AppearanceBase) appearance9;
    ((UltraToggleEditorBase) this.chkCoverageTypeAutoFleetSurvey).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkCoverageTypeAutoFleetSurvey).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkCoverageTypeAutoFleetSurvey).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkCoverageTypeAutoFleetSurvey).Location = new Point(141, 500);
    this.chkCoverageTypeAutoFleetSurvey.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkCoverageTypeAutoFleetSurvey).Name = "chkCoverageTypeAutoFleetSurvey";
    ((Control) this.chkCoverageTypeAutoFleetSurvey).Size = new Size(116, 20);
    ((Control) this.chkCoverageTypeAutoFleetSurvey).TabIndex = 37;
    ((UltraToggleEditorBase) this.chkCoverageTypeAutoFleetSurvey).Text = "Auto Fleet Survey";
    ((UltraControlBase) this.chkCoverageTypeAutoFleetSurvey).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkCoverageTypeAutoFleetSurvey).UseOsThemes = (DefaultableBoolean) 2;
    appearance10.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance10.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkCoverageTypeRestaurant).Appearance = (AppearanceBase) appearance10;
    ((UltraToggleEditorBase) this.chkCoverageTypeRestaurant).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkCoverageTypeRestaurant).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkCoverageTypeRestaurant).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkCoverageTypeRestaurant).Location = new Point(373, 474);
    this.chkCoverageTypeRestaurant.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkCoverageTypeRestaurant).Name = "chkCoverageTypeRestaurant";
    ((Control) this.chkCoverageTypeRestaurant).Size = new Size(91, 20);
    ((Control) this.chkCoverageTypeRestaurant).TabIndex = 35;
    ((UltraToggleEditorBase) this.chkCoverageTypeRestaurant).Text = "Restaurant";
    ((UltraControlBase) this.chkCoverageTypeRestaurant).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkCoverageTypeRestaurant).UseOsThemes = (DefaultableBoolean) 2;
    appearance11.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance11.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkCoverageTypeAllRisk).Appearance = (AppearanceBase) appearance11;
    ((UltraToggleEditorBase) this.chkCoverageTypeAllRisk).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkCoverageTypeAllRisk).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkCoverageTypeAllRisk).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkCoverageTypeAllRisk).Location = new Point(266, 474);
    this.chkCoverageTypeAllRisk.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkCoverageTypeAllRisk).Name = "chkCoverageTypeAllRisk";
    ((Control) this.chkCoverageTypeAllRisk).Size = new Size(79, 20);
    ((Control) this.chkCoverageTypeAllRisk).TabIndex = 34;
    ((UltraToggleEditorBase) this.chkCoverageTypeAllRisk).Text = "All Risk";
    ((UltraControlBase) this.chkCoverageTypeAllRisk).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkCoverageTypeAllRisk).UseOsThemes = (DefaultableBoolean) 2;
    this.Label13.AutoSize = true;
    this.Label13.BackColor = Color.Transparent;
    this.Label13.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label13.Location = new Point(13, 477);
    this.Label13.Name = "Label13";
    this.Label13.Size = new Size(97, 13);
    this.Label13.TabIndex = 61;
    this.Label13.Text = "Coverage Type:";
    this.Label12.AutoSize = true;
    this.Label12.BackColor = Color.Transparent;
    this.Label12.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label12.Location = new Point(12, 444);
    this.Label12.Name = "Label12";
    this.Label12.Size = new Size(107, 13);
    this.Label12.TabIndex = 59;
    this.Label12.Text = "Receipts Amount:";
    this.Label11.AutoSize = true;
    this.Label11.BackColor = Color.Transparent;
    this.Label11.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label11.Location = new Point(12, 420);
    this.Label11.Name = "Label11";
    this.Label11.Size = new Size(95, 13);
    this.Label11.TabIndex = 57;
    this.Label11.Text = "Payroll Amount:";
    appearance12.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance12.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkConfirmAmountsReceipts).Appearance = (AppearanceBase) appearance12;
    ((UltraToggleEditorBase) this.chkConfirmAmountsReceipts).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkConfirmAmountsReceipts).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkConfirmAmountsReceipts).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkConfirmAmountsReceipts).Location = new Point(262, 391);
    this.chkConfirmAmountsReceipts.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkConfirmAmountsReceipts).Name = "chkConfirmAmountsReceipts";
    ((Control) this.chkConfirmAmountsReceipts).Size = new Size(119, 20);
    ((Control) this.chkConfirmAmountsReceipts).TabIndex = 30;
    ((UltraToggleEditorBase) this.chkConfirmAmountsReceipts).Text = "Receipts Confirm";
    ((UltraControlBase) this.chkConfirmAmountsReceipts).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkConfirmAmountsReceipts).UseOsThemes = (DefaultableBoolean) 2;
    appearance13.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance13.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkConfirmAmountsPayroll).Appearance = (AppearanceBase) appearance13;
    ((UltraToggleEditorBase) this.chkConfirmAmountsPayroll).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkConfirmAmountsPayroll).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkConfirmAmountsPayroll).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkConfirmAmountsPayroll).Location = new Point(137, 391);
    this.chkConfirmAmountsPayroll.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkConfirmAmountsPayroll).Name = "chkConfirmAmountsPayroll";
    ((Control) this.chkConfirmAmountsPayroll).Size = new Size(108, 20);
    ((Control) this.chkConfirmAmountsPayroll).TabIndex = 29;
    ((UltraToggleEditorBase) this.chkConfirmAmountsPayroll).Text = "Payroll Confirm";
    ((UltraControlBase) this.chkConfirmAmountsPayroll).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkConfirmAmountsPayroll).UseOsThemes = (DefaultableBoolean) 2;
    this.Label10.AutoSize = true;
    this.Label10.BackColor = Color.Transparent;
    this.Label10.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label10.Location = new Point(9, 393);
    this.Label10.Name = "Label10";
    this.Label10.Size = new Size(105, 13);
    this.Label10.TabIndex = 54;
    this.Label10.Text = "Confirm Amounts:";
    appearance14.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance14.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkHomeOwnerFullReport).Appearance = (AppearanceBase) appearance14;
    ((UltraToggleEditorBase) this.chkHomeOwnerFullReport).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkHomeOwnerFullReport).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkHomeOwnerFullReport).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkHomeOwnerFullReport).Location = new Point(285, 364);
    this.chkHomeOwnerFullReport.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkHomeOwnerFullReport).Name = "chkHomeOwnerFullReport";
    ((Control) this.chkHomeOwnerFullReport).Size = new Size(85, 20);
    ((Control) this.chkHomeOwnerFullReport).TabIndex = 28;
    ((UltraToggleEditorBase) this.chkHomeOwnerFullReport).Text = "Full Report";
    ((UltraControlBase) this.chkHomeOwnerFullReport).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkHomeOwnerFullReport).UseOsThemes = (DefaultableBoolean) 2;
    appearance15.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance15.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkHomeOwnerExterior).Appearance = (AppearanceBase) appearance15;
    ((UltraToggleEditorBase) this.chkHomeOwnerExterior).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkHomeOwnerExterior).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkHomeOwnerExterior).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkHomeOwnerExterior).Location = new Point(195, 365);
    this.chkHomeOwnerExterior.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkHomeOwnerExterior).Name = "chkHomeOwnerExterior";
    ((Control) this.chkHomeOwnerExterior).Size = new Size(74, 20);
    ((Control) this.chkHomeOwnerExterior).TabIndex = 27;
    ((UltraToggleEditorBase) this.chkHomeOwnerExterior).Text = "Exterior";
    ((UltraControlBase) this.chkHomeOwnerExterior).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkHomeOwnerExterior).UseOsThemes = (DefaultableBoolean) 2;
    this.Label9.AutoSize = true;
    this.Label9.BackColor = Color.Transparent;
    this.Label9.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label9.Location = new Point(9, 367);
    this.Label9.Name = "Label9";
    this.Label9.Size = new Size(83, 13);
    this.Label9.TabIndex = 51;
    this.Label9.Text = "Home Owner:";
    appearance16.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance16.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkManuContrPremises).Appearance = (AppearanceBase) appearance16;
    ((UltraToggleEditorBase) this.chkManuContrPremises).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkManuContrPremises).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkManuContrPremises).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkManuContrPremises).Location = new Point(285, 339);
    this.chkManuContrPremises.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkManuContrPremises).Name = "chkManuContrPremises";
    ((Control) this.chkManuContrPremises).Size = new Size(85, 20);
    ((Control) this.chkManuContrPremises).TabIndex = 25;
    ((UltraToggleEditorBase) this.chkManuContrPremises).Text = "Premises";
    ((UltraControlBase) this.chkManuContrPremises).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkManuContrPremises).UseOsThemes = (DefaultableBoolean) 2;
    appearance17.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance17.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkManuContrJobsite).Appearance = (AppearanceBase) appearance17;
    ((UltraToggleEditorBase) this.chkManuContrJobsite).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkManuContrJobsite).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkManuContrJobsite).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkManuContrJobsite).Location = new Point(195, 339);
    this.chkManuContrJobsite.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkManuContrJobsite).Name = "chkManuContrJobsite";
    ((Control) this.chkManuContrJobsite).Size = new Size(74, 20);
    ((Control) this.chkManuContrJobsite).TabIndex = 24;
    ((UltraToggleEditorBase) this.chkManuContrJobsite).Text = "Jobsite";
    ((UltraControlBase) this.chkManuContrJobsite).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkManuContrJobsite).UseOsThemes = (DefaultableBoolean) 2;
    this.Label8.AutoSize = true;
    this.Label8.BackColor = Color.Transparent;
    this.Label8.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label8.Location = new Point(9, 341);
    this.Label8.Name = "Label8";
    this.Label8.Size = new Size(174, 13);
    this.Label8.TabIndex = 48 /*0x30*/;
    this.Label8.Text = "Manufacturer and Contractor:";
    appearance18.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance18.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkVacantBuildingInteriorRequired).Appearance = (AppearanceBase) appearance18;
    ((UltraToggleEditorBase) this.chkVacantBuildingInteriorRequired).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkVacantBuildingInteriorRequired).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkVacantBuildingInteriorRequired).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkVacantBuildingInteriorRequired).Location = new Point(238, 305);
    this.chkVacantBuildingInteriorRequired.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkVacantBuildingInteriorRequired).Name = "chkVacantBuildingInteriorRequired";
    ((Control) this.chkVacantBuildingInteriorRequired).Size = new Size(121, 20);
    ((Control) this.chkVacantBuildingInteriorRequired).TabIndex = 23;
    ((UltraToggleEditorBase) this.chkVacantBuildingInteriorRequired).Text = "Interior Required";
    ((UltraControlBase) this.chkVacantBuildingInteriorRequired).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkVacantBuildingInteriorRequired).UseOsThemes = (DefaultableBoolean) 2;
    appearance19.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance19.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkCoverageTypeWorkersComp).Appearance = (AppearanceBase) appearance19;
    ((UltraToggleEditorBase) this.chkCoverageTypeWorkersComp).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkCoverageTypeWorkersComp).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkCoverageTypeWorkersComp).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkCoverageTypeWorkersComp).Location = new Point(578, 474);
    this.chkCoverageTypeWorkersComp.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkCoverageTypeWorkersComp).Name = "chkCoverageTypeWorkersComp";
    ((Control) this.chkCoverageTypeWorkersComp).Size = new Size(103, 20);
    ((Control) this.chkCoverageTypeWorkersComp).TabIndex = 36;
    ((UltraToggleEditorBase) this.chkCoverageTypeWorkersComp).Text = "Workers Comp";
    ((UltraControlBase) this.chkCoverageTypeWorkersComp).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkCoverageTypeWorkersComp).UseOsThemes = (DefaultableBoolean) 2;
    appearance20.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance20.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkVacantBuildingExteriorOnly).Appearance = (AppearanceBase) appearance20;
    ((UltraToggleEditorBase) this.chkVacantBuildingExteriorOnly).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkVacantBuildingExteriorOnly).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkVacantBuildingExteriorOnly).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkVacantBuildingExteriorOnly).Location = new Point(137, 303);
    this.chkVacantBuildingExteriorOnly.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkVacantBuildingExteriorOnly).Name = "chkVacantBuildingExteriorOnly";
    ((Control) this.chkVacantBuildingExteriorOnly).Size = new Size(95, 20);
    ((Control) this.chkVacantBuildingExteriorOnly).TabIndex = 22;
    ((UltraToggleEditorBase) this.chkVacantBuildingExteriorOnly).Text = "Exterior Only";
    ((UltraControlBase) this.chkVacantBuildingExteriorOnly).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkVacantBuildingExteriorOnly).UseOsThemes = (DefaultableBoolean) 2;
    appearance21.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance21.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkCoverageTypeFire).Appearance = (AppearanceBase) appearance21;
    ((UltraToggleEditorBase) this.chkCoverageTypeFire).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkCoverageTypeFire).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkCoverageTypeFire).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkCoverageTypeFire).Location = new Point(492, 473);
    this.chkCoverageTypeFire.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkCoverageTypeFire).Name = "chkCoverageTypeFire";
    ((Control) this.chkCoverageTypeFire).Size = new Size(75, 23);
    ((Control) this.chkCoverageTypeFire).TabIndex = 35;
    ((UltraToggleEditorBase) this.chkCoverageTypeFire).Text = "Fire";
    ((UltraControlBase) this.chkCoverageTypeFire).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkCoverageTypeFire).UseOsThemes = (DefaultableBoolean) 2;
    this.Label7.AutoSize = true;
    this.Label7.BackColor = Color.Transparent;
    this.Label7.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label7.Location = new Point(9, 306);
    this.Label7.Name = "Label7";
    this.Label7.Size = new Size(100, 13);
    this.Label7.TabIndex = 43;
    this.Label7.Text = "Vacant Building:";
    appearance22.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance22.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkCoverageTypeLiability).Appearance = (AppearanceBase) appearance22;
    ((UltraToggleEditorBase) this.chkCoverageTypeLiability).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkCoverageTypeLiability).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkCoverageTypeLiability).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkCoverageTypeLiability).Location = new Point(141, 474);
    this.chkCoverageTypeLiability.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkCoverageTypeLiability).Name = "chkCoverageTypeLiability";
    ((Control) this.chkCoverageTypeLiability).Size = new Size(79, 20);
    ((Control) this.chkCoverageTypeLiability).TabIndex = 33;
    ((UltraToggleEditorBase) this.chkCoverageTypeLiability).Text = "Liability";
    ((UltraControlBase) this.chkCoverageTypeLiability).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkCoverageTypeLiability).UseOsThemes = (DefaultableBoolean) 2;
    appearance23.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance23.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkPropertyCoverageInterior).Appearance = (AppearanceBase) appearance23;
    ((UltraToggleEditorBase) this.chkPropertyCoverageInterior).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkPropertyCoverageInterior).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkPropertyCoverageInterior).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkPropertyCoverageInterior).Location = new Point(238, 270);
    this.chkPropertyCoverageInterior.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkPropertyCoverageInterior).Name = "chkPropertyCoverageInterior";
    ((Control) this.chkPropertyCoverageInterior).Size = new Size(76, 20);
    ((Control) this.chkPropertyCoverageInterior).TabIndex = 19;
    ((UltraToggleEditorBase) this.chkPropertyCoverageInterior).Text = "Interior";
    ((UltraControlBase) this.chkPropertyCoverageInterior).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkPropertyCoverageInterior).UseOsThemes = (DefaultableBoolean) 2;
    appearance24.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance24.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkPropertyCoverageContents).Appearance = (AppearanceBase) appearance24;
    ((UltraToggleEditorBase) this.chkPropertyCoverageContents).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkPropertyCoverageContents).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkPropertyCoverageContents).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkPropertyCoverageContents).Location = new Point(444, 270);
    this.chkPropertyCoverageContents.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkPropertyCoverageContents).Name = "chkPropertyCoverageContents";
    ((Control) this.chkPropertyCoverageContents).Size = new Size(103, 20);
    ((Control) this.chkPropertyCoverageContents).TabIndex = 21;
    ((UltraToggleEditorBase) this.chkPropertyCoverageContents).Text = "Contents";
    ((UltraControlBase) this.chkPropertyCoverageContents).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkPropertyCoverageContents).UseOsThemes = (DefaultableBoolean) 2;
    appearance25.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance25.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkPropertyCoverageBuilding).Appearance = (AppearanceBase) appearance25;
    ((UltraToggleEditorBase) this.chkPropertyCoverageBuilding).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkPropertyCoverageBuilding).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkPropertyCoverageBuilding).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkPropertyCoverageBuilding).Location = new Point(137, 270);
    this.chkPropertyCoverageBuilding.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkPropertyCoverageBuilding).Name = "chkPropertyCoverageBuilding";
    ((Control) this.chkPropertyCoverageBuilding).Size = new Size(71, 20);
    ((Control) this.chkPropertyCoverageBuilding).TabIndex = 18;
    ((UltraToggleEditorBase) this.chkPropertyCoverageBuilding).Text = "Building";
    ((UltraControlBase) this.chkPropertyCoverageBuilding).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkPropertyCoverageBuilding).UseOsThemes = (DefaultableBoolean) 2;
    appearance26.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance26.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkManuContrPhone).Appearance = (AppearanceBase) appearance26;
    ((UltraToggleEditorBase) this.chkManuContrPhone).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkManuContrPhone).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkManuContrPhone).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkManuContrPhone).Location = new Point(386, 339);
    this.chkManuContrPhone.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkManuContrPhone).Name = "chkManuContrPhone";
    ((Control) this.chkManuContrPhone).Size = new Size(130, 20);
    ((Control) this.chkManuContrPhone).TabIndex = 26;
    ((UltraToggleEditorBase) this.chkManuContrPhone).Text = "Phone";
    ((UltraControlBase) this.chkManuContrPhone).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkManuContrPhone).UseOsThemes = (DefaultableBoolean) 2;
    appearance27.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance27.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkPropertyCoverageExterior).Appearance = (AppearanceBase) appearance27;
    ((UltraToggleEditorBase) this.chkPropertyCoverageExterior).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkPropertyCoverageExterior).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkPropertyCoverageExterior).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkPropertyCoverageExterior).Location = new Point(338, 269);
    this.chkPropertyCoverageExterior.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkPropertyCoverageExterior).Name = "chkPropertyCoverageExterior";
    ((Control) this.chkPropertyCoverageExterior).Size = new Size(75, 23);
    ((Control) this.chkPropertyCoverageExterior).TabIndex = 20;
    ((UltraToggleEditorBase) this.chkPropertyCoverageExterior).Text = "Exterior";
    ((UltraControlBase) this.chkPropertyCoverageExterior).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkPropertyCoverageExterior).UseOsThemes = (DefaultableBoolean) 2;
    this.Label6.AutoSize = true;
    this.Label6.BackColor = Color.Transparent;
    this.Label6.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label6.Location = new Point(9, 270);
    this.Label6.Name = "Label6";
    this.Label6.Size = new Size(116, 13);
    this.Label6.TabIndex = 35;
    this.Label6.Text = "Property Coverage:";
    this.Label5.AutoSize = true;
    this.Label5.BackColor = Color.Transparent;
    this.Label5.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label5.Location = new Point(6, 207);
    this.Label5.Name = "Label5";
    this.Label5.Size = new Size(201, 13);
    this.Label5.TabIndex = 34;
    this.Label5.Text = "Property Type (Other Description):";
    appearance28.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance28.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkPropertyTypeOther).Appearance = (AppearanceBase) appearance28;
    ((UltraToggleEditorBase) this.chkPropertyTypeOther).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkPropertyTypeOther).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkPropertyTypeOther).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkPropertyTypeOther).Location = new Point(419, 163);
    this.chkPropertyTypeOther.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkPropertyTypeOther).Name = "chkPropertyTypeOther";
    ((Control) this.chkPropertyTypeOther).Size = new Size(79, 20);
    ((Control) this.chkPropertyTypeOther).TabIndex = 16 /*0x10*/;
    ((UltraToggleEditorBase) this.chkPropertyTypeOther).Text = "Other";
    ((UltraControlBase) this.chkPropertyTypeOther).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkPropertyTypeOther).UseOsThemes = (DefaultableBoolean) 2;
    appearance29.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance29.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkPropertyTypeRetailStore).Appearance = (AppearanceBase) appearance29;
    ((UltraToggleEditorBase) this.chkPropertyTypeRetailStore).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkPropertyTypeRetailStore).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkPropertyTypeRetailStore).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkPropertyTypeRetailStore).Location = new Point(267, 163);
    this.chkPropertyTypeRetailStore.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkPropertyTypeRetailStore).Name = "chkPropertyTypeRetailStore";
    ((Control) this.chkPropertyTypeRetailStore).Size = new Size(100, 20);
    ((Control) this.chkPropertyTypeRetailStore).TabIndex = 15;
    ((UltraToggleEditorBase) this.chkPropertyTypeRetailStore).Text = "Retail Store";
    ((UltraControlBase) this.chkPropertyTypeRetailStore).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkPropertyTypeRetailStore).UseOsThemes = (DefaultableBoolean) 2;
    appearance30.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance30.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkPropertyTypeOfficeBuilding).Appearance = (AppearanceBase) appearance30;
    ((UltraToggleEditorBase) this.chkPropertyTypeOfficeBuilding).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkPropertyTypeOfficeBuilding).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkPropertyTypeOfficeBuilding).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkPropertyTypeOfficeBuilding).Location = new Point(118, 163);
    this.chkPropertyTypeOfficeBuilding.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkPropertyTypeOfficeBuilding).Name = "chkPropertyTypeOfficeBuilding";
    ((Control) this.chkPropertyTypeOfficeBuilding).Size = new Size((int) sbyte.MaxValue, 20);
    ((Control) this.chkPropertyTypeOfficeBuilding).TabIndex = 14;
    ((UltraToggleEditorBase) this.chkPropertyTypeOfficeBuilding).Text = "Office Building";
    ((UltraControlBase) this.chkPropertyTypeOfficeBuilding).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkPropertyTypeOfficeBuilding).UseOsThemes = (DefaultableBoolean) 2;
    appearance31.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance31.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkPropertyTypeBuildingOwner).Appearance = (AppearanceBase) appearance31;
    ((UltraToggleEditorBase) this.chkPropertyTypeBuildingOwner).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkPropertyTypeBuildingOwner).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkPropertyTypeBuildingOwner).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkPropertyTypeBuildingOwner).Location = new Point(532, 137);
    this.chkPropertyTypeBuildingOwner.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkPropertyTypeBuildingOwner).Name = "chkPropertyTypeBuildingOwner";
    ((Control) this.chkPropertyTypeBuildingOwner).Size = new Size(130, 20);
    ((Control) this.chkPropertyTypeBuildingOwner).TabIndex = 13;
    ((UltraToggleEditorBase) this.chkPropertyTypeBuildingOwner).Text = "Building Owner";
    ((UltraControlBase) this.chkPropertyTypeBuildingOwner).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkPropertyTypeBuildingOwner).UseOsThemes = (DefaultableBoolean) 2;
    appearance32.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance32.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkPropertyTypeApartmentBuilding).Appearance = (AppearanceBase) appearance32;
    ((UltraToggleEditorBase) this.chkPropertyTypeApartmentBuilding).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkPropertyTypeApartmentBuilding).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkPropertyTypeApartmentBuilding).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkPropertyTypeApartmentBuilding).Location = new Point(118, 137);
    this.chkPropertyTypeApartmentBuilding.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkPropertyTypeApartmentBuilding).Name = "chkPropertyTypeApartmentBuilding";
    ((Control) this.chkPropertyTypeApartmentBuilding).Size = new Size((int) sbyte.MaxValue, 20);
    ((Control) this.chkPropertyTypeApartmentBuilding).TabIndex = 10;
    ((UltraToggleEditorBase) this.chkPropertyTypeApartmentBuilding).Text = "Apartment Building";
    ((UltraControlBase) this.chkPropertyTypeApartmentBuilding).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkPropertyTypeApartmentBuilding).UseOsThemes = (DefaultableBoolean) 2;
    appearance33.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance33.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkPropertyTypeLessorsRiskOnly).Appearance = (AppearanceBase) appearance33;
    ((UltraToggleEditorBase) this.chkPropertyTypeLessorsRiskOnly).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkPropertyTypeLessorsRiskOnly).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkPropertyTypeLessorsRiskOnly).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkPropertyTypeLessorsRiskOnly).Location = new Point(267, 137);
    this.chkPropertyTypeLessorsRiskOnly.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkPropertyTypeLessorsRiskOnly).Name = "chkPropertyTypeLessorsRiskOnly";
    ((Control) this.chkPropertyTypeLessorsRiskOnly).Size = new Size(130, 20);
    ((Control) this.chkPropertyTypeLessorsRiskOnly).TabIndex = 11;
    ((UltraToggleEditorBase) this.chkPropertyTypeLessorsRiskOnly).Text = "Lessor''s Risk Only";
    ((UltraControlBase) this.chkPropertyTypeLessorsRiskOnly).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkPropertyTypeLessorsRiskOnly).UseOsThemes = (DefaultableBoolean) 2;
    appearance34.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance34.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkPropertyTypeMercantile).Appearance = (AppearanceBase) appearance34;
    ((UltraToggleEditorBase) this.chkPropertyTypeMercantile).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkPropertyTypeMercantile).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkPropertyTypeMercantile).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkPropertyTypeMercantile).Location = new Point(419, 136);
    this.chkPropertyTypeMercantile.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkPropertyTypeMercantile).Name = "chkPropertyTypeMercantile";
    ((Control) this.chkPropertyTypeMercantile).Size = new Size(91, 23);
    ((Control) this.chkPropertyTypeMercantile).TabIndex = 12;
    ((UltraToggleEditorBase) this.chkPropertyTypeMercantile).Text = "Mercantile";
    ((UltraControlBase) this.chkPropertyTypeMercantile).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkPropertyTypeMercantile).UseOsThemes = (DefaultableBoolean) 2;
    this.Label4.AutoSize = true;
    this.Label4.BackColor = Color.Transparent;
    this.Label4.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label4.Location = new Point(9, 141);
    this.Label4.Name = "Label4";
    this.Label4.Size = new Size(90, 13);
    this.Label4.TabIndex = 22;
    this.Label4.Text = "Property Type:";
    appearance35.BackColor = Color.White;
    appearance35.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance35.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtPropertyTypeDescription).Appearance = (AppearanceBase) appearance35;
    ((TextEditorControlBase) this.txtPropertyTypeDescription).BackColor = Color.White;
    ((Control) this.txtPropertyTypeDescription).Location = new Point(222, 207);
    ((TextEditorControlBase) this.txtPropertyTypeDescription).MaxLength = 100;
    this.txtPropertyTypeDescription.MGAStyle = MGAStyles.Blue;
    this.txtPropertyTypeDescription.Multiline = true;
    ((Control) this.txtPropertyTypeDescription).Name = "txtPropertyTypeDescription";
    ((Control) this.txtPropertyTypeDescription).Size = new Size(450, 41);
    ((Control) this.txtPropertyTypeDescription).TabIndex = 17;
    ((UltraControlBase) this.txtPropertyTypeDescription).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtPropertyTypeDescription).UseOsThemes = (DefaultableBoolean) 2;
    this.rbRushRequestYes.AutoSize = true;
    this.rbRushRequestYes.BackColor = Color.Transparent;
    this.rbRushRequestYes.Location = new Point(119, 95);
    this.rbRushRequestYes.Name = "rbRushRequestYes";
    this.rbRushRequestYes.Size = new Size(43, 17);
    this.rbRushRequestYes.TabIndex = 8;
    this.rbRushRequestYes.TabStop = true;
    this.rbRushRequestYes.Text = "Yes";
    this.rbRushRequestYes.UseVisualStyleBackColor = false;
    this.rbRushRequestNo.AutoSize = true;
    this.rbRushRequestNo.BackColor = Color.Transparent;
    this.rbRushRequestNo.Location = new Point(186, 95);
    this.rbRushRequestNo.Name = "rbRushRequestNo";
    this.rbRushRequestNo.Size = new Size(39, 17);
    this.rbRushRequestNo.TabIndex = 9;
    this.rbRushRequestNo.TabStop = true;
    this.rbRushRequestNo.Text = "No";
    this.rbRushRequestNo.UseVisualStyleBackColor = false;
    this.Label3.AutoSize = true;
    this.Label3.BackColor = Color.Transparent;
    this.Label3.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label3.Location = new Point(12, 97);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(91, 13);
    this.Label3.TabIndex = 19;
    this.Label3.Text = "Rush Request:";
    this.Label2.AutoSize = true;
    this.Label2.BackColor = Color.Transparent;
    this.Label2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label2.Location = new Point(9, 56);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(92, 13);
    this.Label2.TabIndex = 18;
    this.Label2.Text = "Cost Estimator:";
    this.Label1.AutoSize = true;
    this.Label1.BackColor = Color.Transparent;
    this.Label1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label1.Location = new Point(9, 20);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(102, 13);
    this.Label1.TabIndex = 12;
    this.Label1.Text = "Inspection Type:";
    appearance36.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance36.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkCostEstimatorReplacementCost).Appearance = (AppearanceBase) appearance36;
    ((UltraToggleEditorBase) this.chkCostEstimatorReplacementCost).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkCostEstimatorReplacementCost).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkCostEstimatorReplacementCost).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkCostEstimatorReplacementCost).Location = new Point(347, 52);
    this.chkCostEstimatorReplacementCost.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkCostEstimatorReplacementCost).Name = "chkCostEstimatorReplacementCost";
    ((Control) this.chkCostEstimatorReplacementCost).Size = new Size(128 /*0x80*/, 20);
    ((Control) this.chkCostEstimatorReplacementCost).TabIndex = 6;
    ((UltraToggleEditorBase) this.chkCostEstimatorReplacementCost).Text = "Replacement Cost";
    ((UltraControlBase) this.chkCostEstimatorReplacementCost).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkCostEstimatorReplacementCost).UseOsThemes = (DefaultableBoolean) 2;
    appearance37.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance37.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkCostEstimatorActualCashValue).Appearance = (AppearanceBase) appearance37;
    ((UltraToggleEditorBase) this.chkCostEstimatorActualCashValue).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkCostEstimatorActualCashValue).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkCostEstimatorActualCashValue).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkCostEstimatorActualCashValue).Location = new Point(492, 52);
    this.chkCostEstimatorActualCashValue.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkCostEstimatorActualCashValue).Name = "chkCostEstimatorActualCashValue";
    ((Control) this.chkCostEstimatorActualCashValue).Size = new Size(138, 20);
    ((Control) this.chkCostEstimatorActualCashValue).TabIndex = 7;
    ((UltraToggleEditorBase) this.chkCostEstimatorActualCashValue).Text = "Actual Cash Value";
    ((UltraControlBase) this.chkCostEstimatorActualCashValue).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkCostEstimatorActualCashValue).UseOsThemes = (DefaultableBoolean) 2;
    appearance38.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance38.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkCostEstimatorInsuranceToValue).Appearance = (AppearanceBase) appearance38;
    ((UltraToggleEditorBase) this.chkCostEstimatorInsuranceToValue).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkCostEstimatorInsuranceToValue).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkCostEstimatorInsuranceToValue).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkCostEstimatorInsuranceToValue).Location = new Point(118, 52);
    this.chkCostEstimatorInsuranceToValue.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkCostEstimatorInsuranceToValue).Name = "chkCostEstimatorInsuranceToValue";
    ((Control) this.chkCostEstimatorInsuranceToValue).Size = new Size(210, 20);
    ((Control) this.chkCostEstimatorInsuranceToValue).TabIndex = 5;
    ((UltraToggleEditorBase) this.chkCostEstimatorInsuranceToValue).Text = "Insurance to Value(Cost Estimator)";
    ((UltraControlBase) this.chkCostEstimatorInsuranceToValue).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkCostEstimatorInsuranceToValue).UseOsThemes = (DefaultableBoolean) 2;
    appearance39.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance39.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkInspectionTypeDiagram).Appearance = (AppearanceBase) appearance39;
    ((UltraToggleEditorBase) this.chkInspectionTypeDiagram).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkInspectionTypeDiagram).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkInspectionTypeDiagram).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkInspectionTypeDiagram).Location = new Point(578, 16 /*0x10*/);
    this.chkInspectionTypeDiagram.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkInspectionTypeDiagram).Name = "chkInspectionTypeDiagram";
    ((Control) this.chkInspectionTypeDiagram).Size = new Size(94, 20);
    ((Control) this.chkInspectionTypeDiagram).TabIndex = 4;
    ((UltraToggleEditorBase) this.chkInspectionTypeDiagram).Text = "Diagram";
    ((UltraControlBase) this.chkInspectionTypeDiagram).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkInspectionTypeDiagram).UseOsThemes = (DefaultableBoolean) 2;
    appearance40.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance40.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkInspectionTypeShortForm).Appearance = (AppearanceBase) appearance40;
    ((UltraToggleEditorBase) this.chkInspectionTypeShortForm).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkInspectionTypeShortForm).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkInspectionTypeShortForm).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkInspectionTypeShortForm).Location = new Point(251, 16 /*0x10*/);
    this.chkInspectionTypeShortForm.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkInspectionTypeShortForm).Name = "chkInspectionTypeShortForm";
    ((Control) this.chkInspectionTypeShortForm).Size = new Size(96 /*0x60*/, 20);
    ((Control) this.chkInspectionTypeShortForm).TabIndex = 1;
    ((UltraToggleEditorBase) this.chkInspectionTypeShortForm).Text = "Short Form";
    ((UltraControlBase) this.chkInspectionTypeShortForm).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkInspectionTypeShortForm).UseOsThemes = (DefaultableBoolean) 2;
    appearance41.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance41.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkInspectionTypeRecommendation).Appearance = (AppearanceBase) appearance41;
    ((UltraToggleEditorBase) this.chkInspectionTypeRecommendation).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkInspectionTypeRecommendation).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkInspectionTypeRecommendation).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkInspectionTypeRecommendation).Location = new Point(444, 16 /*0x10*/);
    this.chkInspectionTypeRecommendation.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkInspectionTypeRecommendation).Name = "chkInspectionTypeRecommendation";
    ((Control) this.chkInspectionTypeRecommendation).Size = new Size(117, 20);
    ((Control) this.chkInspectionTypeRecommendation).TabIndex = 3;
    ((UltraToggleEditorBase) this.chkInspectionTypeRecommendation).Text = "Recommendation";
    ((UltraControlBase) this.chkInspectionTypeRecommendation).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkInspectionTypeRecommendation).UseOsThemes = (DefaultableBoolean) 2;
    appearance42.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance42.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkInspectionTypeDriveBy).Appearance = (AppearanceBase) appearance42;
    ((UltraToggleEditorBase) this.chkInspectionTypeDriveBy).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkInspectionTypeDriveBy).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkInspectionTypeDriveBy).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkInspectionTypeDriveBy).Location = new Point(363, 16 /*0x10*/);
    this.chkInspectionTypeDriveBy.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkInspectionTypeDriveBy).Name = "chkInspectionTypeDriveBy";
    ((Control) this.chkInspectionTypeDriveBy).Size = new Size(88, 20);
    ((Control) this.chkInspectionTypeDriveBy).TabIndex = 2;
    ((UltraToggleEditorBase) this.chkInspectionTypeDriveBy).Text = "Drive By";
    ((UltraControlBase) this.chkInspectionTypeDriveBy).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkInspectionTypeDriveBy).UseOsThemes = (DefaultableBoolean) 2;
    appearance43.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance43.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkInspectionTypeFullReport).Appearance = (AppearanceBase) appearance43;
    ((UltraToggleEditorBase) this.chkInspectionTypeFullReport).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkInspectionTypeFullReport).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkInspectionTypeFullReport).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkInspectionTypeFullReport).Location = new Point(118, 16 /*0x10*/);
    this.chkInspectionTypeFullReport.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkInspectionTypeFullReport).Name = "chkInspectionTypeFullReport";
    ((Control) this.chkInspectionTypeFullReport).Size = new Size(91, 20);
    ((Control) this.chkInspectionTypeFullReport).TabIndex = 0;
    ((UltraToggleEditorBase) this.chkInspectionTypeFullReport).Text = "Full Report";
    ((UltraControlBase) this.chkInspectionTypeFullReport).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkInspectionTypeFullReport).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.btnCancel).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance44.BackColor = Color.Gainsboro;
    appearance44.BackColor2 = Color.White;
    appearance44.BackGradientStyle = (GradientStyle) 2;
    appearance44.BorderColor = Color.Gray;
    appearance44.ImageHAlign = (HAlign) 2;
    appearance44.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnCancel).Appearance = (AppearanceBase) appearance44;
    ((ControlBase) this.btnCancel).ImageSize = new Size(24, 24);
    ((Control) this.btnCancel).Location = new Point(674, 557);
    ((Control) this.btnCancel).Name = "btnCancel";
    ((Control) this.btnCancel).Size = new Size(40, 40);
    ((Control) this.btnCancel).TabIndex = 2;
    this.btnCancel.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.btnSave).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance45.BackColor = Color.Gainsboro;
    appearance45.BackColor2 = Color.White;
    appearance45.BackGradientStyle = (GradientStyle) 2;
    appearance45.BorderColor = Color.Gray;
    appearance45.ImageHAlign = (HAlign) 2;
    appearance45.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnSave).Appearance = (AppearanceBase) appearance45;
    ((ControlBase) this.btnSave).ImageSize = new Size(24, 24);
    ((Control) this.btnSave).Location = new Point(590, 557);
    ((Control) this.btnSave).Name = "btnSave";
    ((Control) this.btnSave).Size = new Size(40, 40);
    ((Control) this.btnSave).TabIndex = 1;
    this.btnSave.UseOSThemes = (DefaultableBoolean) 2;
    this.lnkClearForm.AutoSize = true;
    this.lnkClearForm.Location = new Point(18, 584);
    this.lnkClearForm.Name = "lnkClearForm";
    this.lnkClearForm.Size = new Size(57, 13);
    this.lnkClearForm.TabIndex = 3;
    this.lnkClearForm.TabStop = true;
    this.lnkClearForm.Text = "Clear Form";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(726, 607);
    this.Controls.Add((Control) this.lnkClearForm);
    this.Controls.Add((Control) this.btnCancel);
    this.Controls.Add((Control) this.btnSave);
    this.Controls.Add((Control) this.grpInspection);
    this.Name = nameof (FormMajesticRequestInfo);
    this.Text = "Expert Insure Inspection < -- > Majestic Services";
    ((ISupportInitialize) this.grpInspection).EndInit();
    ((Control) this.grpInspection).ResumeLayout(false);
    ((Control) this.grpInspection).PerformLayout();
    ((ISupportInitialize) this.numReceiptsAmount).EndInit();
    ((ISupportInitialize) this.numPayrollAmount).EndInit();
    ((ISupportInitialize) this.chkCoverageTypeProducts).EndInit();
    ((ISupportInitialize) this.chkCoverageTypeGlassCoverage).EndInit();
    ((ISupportInitialize) this.chkCoverageTypeGarageLiability).EndInit();
    ((ISupportInitialize) this.chkCoverageTypeGarageKeepers).EndInit();
    ((ISupportInitialize) this.chkCoverageTypeLiquorLegal).EndInit();
    ((ISupportInitialize) this.chkCoverageTypeAutoFleetSurvey).EndInit();
    ((ISupportInitialize) this.chkCoverageTypeRestaurant).EndInit();
    ((ISupportInitialize) this.chkCoverageTypeAllRisk).EndInit();
    ((ISupportInitialize) this.chkConfirmAmountsReceipts).EndInit();
    ((ISupportInitialize) this.chkConfirmAmountsPayroll).EndInit();
    ((ISupportInitialize) this.chkHomeOwnerFullReport).EndInit();
    ((ISupportInitialize) this.chkHomeOwnerExterior).EndInit();
    ((ISupportInitialize) this.chkManuContrPremises).EndInit();
    ((ISupportInitialize) this.chkManuContrJobsite).EndInit();
    ((ISupportInitialize) this.chkVacantBuildingInteriorRequired).EndInit();
    ((ISupportInitialize) this.chkCoverageTypeWorkersComp).EndInit();
    ((ISupportInitialize) this.chkVacantBuildingExteriorOnly).EndInit();
    ((ISupportInitialize) this.chkCoverageTypeFire).EndInit();
    ((ISupportInitialize) this.chkCoverageTypeLiability).EndInit();
    ((ISupportInitialize) this.chkPropertyCoverageInterior).EndInit();
    ((ISupportInitialize) this.chkPropertyCoverageContents).EndInit();
    ((ISupportInitialize) this.chkPropertyCoverageBuilding).EndInit();
    ((ISupportInitialize) this.chkManuContrPhone).EndInit();
    ((ISupportInitialize) this.chkPropertyCoverageExterior).EndInit();
    ((ISupportInitialize) this.chkPropertyTypeOther).EndInit();
    ((ISupportInitialize) this.chkPropertyTypeRetailStore).EndInit();
    ((ISupportInitialize) this.chkPropertyTypeOfficeBuilding).EndInit();
    ((ISupportInitialize) this.chkPropertyTypeBuildingOwner).EndInit();
    ((ISupportInitialize) this.chkPropertyTypeApartmentBuilding).EndInit();
    ((ISupportInitialize) this.chkPropertyTypeLessorsRiskOnly).EndInit();
    ((ISupportInitialize) this.chkPropertyTypeMercantile).EndInit();
    ((ISupportInitialize) this.txtPropertyTypeDescription).EndInit();
    ((ISupportInitialize) this.chkCostEstimatorReplacementCost).EndInit();
    ((ISupportInitialize) this.chkCostEstimatorActualCashValue).EndInit();
    ((ISupportInitialize) this.chkCostEstimatorInsuranceToValue).EndInit();
    ((ISupportInitialize) this.chkInspectionTypeDiagram).EndInit();
    ((ISupportInitialize) this.chkInspectionTypeShortForm).EndInit();
    ((ISupportInitialize) this.chkInspectionTypeRecommendation).EndInit();
    ((ISupportInitialize) this.chkInspectionTypeDriveBy).EndInit();
    ((ISupportInitialize) this.chkInspectionTypeFullReport).EndInit();
    ((ISupportInitialize) this.btnCancel).EndInit();
    ((ISupportInitialize) this.btnSave).EndInit();
    ((ISupportInitialize) this.chkBuildersRisk).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  [field: AccessedThroughProperty("grpInspection")]
  protected virtual UltraGroupBox grpInspection { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkHomeOwnerFullReport")]
  protected virtual MGACheckBox chkHomeOwnerFullReport { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkHomeOwnerExterior")]
  protected virtual MGACheckBox chkHomeOwnerExterior { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label9")]
  internal virtual Label Label9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkManuContrPremises")]
  protected virtual MGACheckBox chkManuContrPremises { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkManuContrJobsite")]
  protected virtual MGACheckBox chkManuContrJobsite { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label8")]
  internal virtual Label Label8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkVacantBuildingInteriorRequired")]
  protected virtual MGACheckBox chkVacantBuildingInteriorRequired { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkCoverageTypeWorkersComp")]
  protected virtual MGACheckBox chkCoverageTypeWorkersComp { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkVacantBuildingExteriorOnly")]
  protected virtual MGACheckBox chkVacantBuildingExteriorOnly { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkCoverageTypeFire")]
  protected virtual MGACheckBox chkCoverageTypeFire { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label7")]
  internal virtual Label Label7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkCoverageTypeLiability")]
  protected virtual MGACheckBox chkCoverageTypeLiability { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkPropertyCoverageInterior")]
  protected virtual MGACheckBox chkPropertyCoverageInterior { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkPropertyCoverageContents")]
  protected virtual MGACheckBox chkPropertyCoverageContents { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkPropertyCoverageBuilding")]
  protected virtual MGACheckBox chkPropertyCoverageBuilding { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkManuContrPhone")]
  protected virtual MGACheckBox chkManuContrPhone { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkPropertyCoverageExterior")]
  protected virtual MGACheckBox chkPropertyCoverageExterior { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label6")]
  internal virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label5")]
  internal virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkPropertyTypeOther")]
  protected virtual MGACheckBox chkPropertyTypeOther { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkPropertyTypeRetailStore")]
  protected virtual MGACheckBox chkPropertyTypeRetailStore { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkPropertyTypeOfficeBuilding")]
  protected virtual MGACheckBox chkPropertyTypeOfficeBuilding { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkPropertyTypeBuildingOwner")]
  protected virtual MGACheckBox chkPropertyTypeBuildingOwner { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkPropertyTypeApartmentBuilding")]
  protected virtual MGACheckBox chkPropertyTypeApartmentBuilding { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkPropertyTypeLessorsRiskOnly")]
  protected virtual MGACheckBox chkPropertyTypeLessorsRiskOnly { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkPropertyTypeMercantile")]
  protected virtual MGACheckBox chkPropertyTypeMercantile { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label4")]
  internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtPropertyTypeDescription")]
  private virtual MGATextBox txtPropertyTypeDescription { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("rbRushRequestYes")]
  internal virtual RadioButton rbRushRequestYes { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("rbRushRequestNo")]
  internal virtual RadioButton rbRushRequestNo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label3")]
  internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label2")]
  internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkCostEstimatorReplacementCost")]
  protected virtual MGACheckBox chkCostEstimatorReplacementCost { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkCostEstimatorActualCashValue")]
  protected virtual MGACheckBox chkCostEstimatorActualCashValue { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkCostEstimatorInsuranceToValue")]
  protected virtual MGACheckBox chkCostEstimatorInsuranceToValue { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkInspectionTypeDiagram")]
  protected virtual MGACheckBox chkInspectionTypeDiagram { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkInspectionTypeShortForm")]
  protected virtual MGACheckBox chkInspectionTypeShortForm { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkInspectionTypeRecommendation")]
  protected virtual MGACheckBox chkInspectionTypeRecommendation { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkInspectionTypeDriveBy")]
  protected virtual MGACheckBox chkInspectionTypeDriveBy { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkInspectionTypeFullReport")]
  protected virtual MGACheckBox chkInspectionTypeFullReport { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkCoverageTypeGarageKeepers")]
  protected virtual MGACheckBox chkCoverageTypeGarageKeepers { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkCoverageTypeLiquorLegal")]
  protected virtual MGACheckBox chkCoverageTypeLiquorLegal { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkCoverageTypeAutoFleetSurvey")]
  protected virtual MGACheckBox chkCoverageTypeAutoFleetSurvey { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkCoverageTypeRestaurant")]
  protected virtual MGACheckBox chkCoverageTypeRestaurant { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkCoverageTypeAllRisk")]
  protected virtual MGACheckBox chkCoverageTypeAllRisk { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label13")]
  internal virtual Label Label13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label12")]
  internal virtual Label Label12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label11")]
  internal virtual Label Label11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkConfirmAmountsReceipts")]
  protected virtual MGACheckBox chkConfirmAmountsReceipts { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkConfirmAmountsPayroll")]
  protected virtual MGACheckBox chkConfirmAmountsPayroll { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label10")]
  internal virtual Label Label10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MGAButton btnSave
  {
    get => this._btnSave;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.BtnSave_Click);
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
      EventHandler eventHandler = new EventHandler(this.BtnCancel_Click);
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

  [field: AccessedThroughProperty("numReceiptsAmount")]
  protected virtual MGANumericEditor numReceiptsAmount { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("numPayrollAmount")]
  protected virtual MGANumericEditor numPayrollAmount { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkCoverageTypeGarageLiability")]
  private virtual MGACheckBox chkCoverageTypeGarageLiability { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkCoverageTypeProducts")]
  private virtual MGACheckBox chkCoverageTypeProducts { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkCoverageTypeGlassCoverage")]
  private virtual MGACheckBox chkCoverageTypeGlassCoverage { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual LinkLabel lnkClearForm
  {
    get => this._lnkClearForm;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.LnkClearForm_LinkClicked);
      LinkLabel lnkClearForm1 = this._lnkClearForm;
      if (lnkClearForm1 != null)
        lnkClearForm1.LinkClicked -= clickedEventHandler;
      this._lnkClearForm = value;
      LinkLabel lnkClearForm2 = this._lnkClearForm;
      if (lnkClearForm2 == null)
        return;
      lnkClearForm2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("chkBuildersRisk")]
  private virtual MGACheckBox chkBuildersRisk { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public FormMajesticRequestInfo(Guid quoteGuid)
  {
    this.Load += new EventHandler(this.FormMajesticRequestInfo_Load);
    this.InitializeComponent();
    this._quoteGuid = quoteGuid;
  }

  private void FormMajesticRequestInfo_Load(object sender, EventArgs e)
  {
    ((ControlBase) this.btnSave).Appearance.Image = (object) ImageCache.Instance.Save;
    ((ControlBase) this.btnCancel).Appearance.Image = (object) ImageCache.Instance.Undo;
    DataRow dataRow = DefaultDatabase.ExecuteDataRow(CommandType.Text, "SELECT InspectionTypeFullReport,InspectionTypeShortForm,InspectionTypeDriveBy, InspectionTypeRecommendation,InspectionTypeDiagram,CostEstimatorInsuranceToValue,CostEstimatorReplacementCost, CostEstimatorActualCashValue, RushRequest,PropertyTypeApartmentBuilding,PropertyTypeLessorRiskOnly,PropertyTypeMercantile, PropertyTypeaBuildingOwner,PropertyTypeOfficeBuilding,PropertyTypeRetailStore,PropertyTypeOther, PropertyTypeDescription, PropertyCoverageBuilding,PropertyCoverageInterior,PropertyCoverageExterior, PropertyCoverageContents,VacantBuildingExteriorOnly,VacantBuildingInteriorRequired,ManuContrJobsite, ManuContrPremises,ManuContrPhone,HomeOwnerExterior,HomeOwnerFullReport,ConfirmAmountsPayroll,ConfirmAmountsReceipts, PayrollAmount,ReceiptsAmount,CoverageTypeLiability,CoverageTypeAllRisk,CoverageTypeRestaurant,CoverageTypeFire, CoverageTypeWorkersComp,CoverageTypeAutoFleetSurvey,CoverageTypeLiquorLegal,CoverageTypeGarageKeepers, CoverageTypeGarageLiability,CoverageTypeGlassCoverage,CoverageTypeProducts, BuildersRisk FROM tblMajesticInsuredData WHERE QuoteGuid = @QG", new object[2]
    {
      (object) "@QG",
      (object) this._quoteGuid
    });
    if (dataRow == null || dataRow.Table.Rows.Count <= 0)
      return;
    ((UltraToggleEditorBase) this.chkInspectionTypeFullReport).Checked = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataRow["InspectionTypeFullReport"]));
    ((UltraToggleEditorBase) this.chkInspectionTypeShortForm).Checked = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataRow["InspectionTypeShortForm"]));
    ((UltraToggleEditorBase) this.chkInspectionTypeDriveBy).Checked = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataRow["InspectionTypeDriveBy"]));
    ((UltraToggleEditorBase) this.chkInspectionTypeRecommendation).Checked = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataRow["InspectionTypeRecommendation"]));
    ((UltraToggleEditorBase) this.chkInspectionTypeDiagram).Checked = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataRow["InspectionTypeDiagram"]));
    ((UltraToggleEditorBase) this.chkCostEstimatorInsuranceToValue).Checked = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataRow["CostEstimatorInsuranceToValue"]));
    ((UltraToggleEditorBase) this.chkCostEstimatorReplacementCost).Checked = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataRow["CostEstimatorReplacementCost"]));
    ((UltraToggleEditorBase) this.chkCostEstimatorActualCashValue).Checked = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataRow["CostEstimatorActualCashValue"]));
    if (!dataRow.IsNull("RushRequest"))
    {
      if (dataRow["RushRequest"].ToString().Equals("Y"))
        this.rbRushRequestYes.Checked = true;
      else if (dataRow["RushRequest"].ToString().Equals("N"))
        this.rbRushRequestNo.Checked = true;
    }
    ((UltraToggleEditorBase) this.chkPropertyTypeApartmentBuilding).Checked = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataRow["PropertyTypeApartmentBuilding"]));
    ((UltraToggleEditorBase) this.chkPropertyTypeLessorsRiskOnly).Checked = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataRow["PropertyTypeLessorRiskOnly"]));
    ((UltraToggleEditorBase) this.chkPropertyTypeMercantile).Checked = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataRow["PropertyTypeMercantile"]));
    ((UltraToggleEditorBase) this.chkPropertyTypeBuildingOwner).Checked = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataRow["PropertyTypeaBuildingOwner"]));
    ((UltraToggleEditorBase) this.chkPropertyTypeOfficeBuilding).Checked = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataRow["PropertyTypeOfficeBuilding"]));
    ((UltraToggleEditorBase) this.chkPropertyTypeRetailStore).Checked = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataRow["PropertyTypeRetailStore"]));
    ((UltraToggleEditorBase) this.chkPropertyTypeOther).Checked = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataRow["PropertyTypeOther"]));
    if (!dataRow.IsNull("PropertyTypeDescription"))
      ((TextEditorControlBase) this.txtPropertyTypeDescription).Text = dataRow["PropertyTypeDescription"].ToString();
    ((UltraToggleEditorBase) this.chkPropertyCoverageBuilding).Checked = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataRow["PropertyCoverageBuilding"]));
    ((UltraToggleEditorBase) this.chkPropertyCoverageInterior).Checked = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataRow["PropertyCoverageInterior"]));
    ((UltraToggleEditorBase) this.chkPropertyCoverageExterior).Checked = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataRow["PropertyCoverageExterior"]));
    ((UltraToggleEditorBase) this.chkPropertyCoverageContents).Checked = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataRow["PropertyCoverageContents"]));
    ((UltraToggleEditorBase) this.chkVacantBuildingExteriorOnly).Checked = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataRow["VacantBuildingExteriorOnly"]));
    ((UltraToggleEditorBase) this.chkVacantBuildingInteriorRequired).Checked = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataRow["VacantBuildingInteriorRequired"]));
    ((UltraToggleEditorBase) this.chkManuContrJobsite).Checked = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataRow["ManuContrJobsite"]));
    ((UltraToggleEditorBase) this.chkManuContrPremises).Checked = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataRow["ManuContrPremises"]));
    ((UltraToggleEditorBase) this.chkManuContrPhone).Checked = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataRow["ManuContrPhone"]));
    ((UltraToggleEditorBase) this.chkHomeOwnerExterior).Checked = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataRow["HomeOwnerExterior"]));
    ((UltraToggleEditorBase) this.chkHomeOwnerFullReport).Checked = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataRow["HomeOwnerFullReport"]));
    ((UltraToggleEditorBase) this.chkConfirmAmountsPayroll).Checked = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataRow["ConfirmAmountsPayroll"]));
    ((UltraToggleEditorBase) this.chkConfirmAmountsReceipts).Checked = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataRow["ConfirmAmountsReceipts"]));
    if (!dataRow.IsNull("PayrollAmount"))
      this.numPayrollAmount.Value = RuntimeHelpers.GetObjectValue(dataRow["PayrollAmount"]);
    if (!dataRow.IsNull("ReceiptsAmount"))
      this.numReceiptsAmount.Value = RuntimeHelpers.GetObjectValue(dataRow["ReceiptsAmount"]);
    ((UltraToggleEditorBase) this.chkCoverageTypeLiability).Checked = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataRow["CoverageTypeLiability"]));
    ((UltraToggleEditorBase) this.chkCoverageTypeAllRisk).Checked = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataRow["CoverageTypeAllRisk"]));
    ((UltraToggleEditorBase) this.chkCoverageTypeRestaurant).Checked = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataRow["CoverageTypeRestaurant"]));
    ((UltraToggleEditorBase) this.chkCoverageTypeFire).Checked = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataRow["CoverageTypeFire"]));
    ((UltraToggleEditorBase) this.chkCoverageTypeWorkersComp).Checked = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataRow["CoverageTypeWorkersComp"]));
    ((UltraToggleEditorBase) this.chkCoverageTypeAutoFleetSurvey).Checked = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataRow["CoverageTypeAutoFleetSurvey"]));
    ((UltraToggleEditorBase) this.chkCoverageTypeLiquorLegal).Checked = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataRow["CoverageTypeLiquorLegal"]));
    ((UltraToggleEditorBase) this.chkCoverageTypeGarageKeepers).Checked = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataRow["CoverageTypeGarageKeepers"]));
    ((UltraToggleEditorBase) this.chkCoverageTypeGarageLiability).Checked = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataRow["CoverageTypeGarageLiability"]));
    ((UltraToggleEditorBase) this.chkCoverageTypeGlassCoverage).Checked = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataRow["CoverageTypeGlassCoverage"]));
    ((UltraToggleEditorBase) this.chkCoverageTypeProducts).Checked = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataRow["CoverageTypeProducts"]));
    ((UltraToggleEditorBase) this.chkBuildersRisk).Checked = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataRow["BuildersRisk"]));
  }

  private void BtnSave_Click(object sender, EventArgs e)
  {
    object obj = (object) DBNull.Value;
    if (this.rbRushRequestNo.Checked)
      obj = (object) "N";
    else if (this.rbRushRequestYes.Checked)
      obj = (object) "Y";
    DefaultDatabase.ExecuteNonQuery("SaveMajesticRequest", new object[90]
    {
      (object) "@QuoteGuid",
      (object) this._quoteGuid,
      (object) "@InspectionTypeFullReport",
      (object) ((UltraToggleEditorBase) this.chkInspectionTypeFullReport).Checked,
      (object) "@InspectionTypeShortForm",
      (object) ((UltraToggleEditorBase) this.chkInspectionTypeShortForm).Checked,
      (object) "@InspectionTypeDriveBy",
      (object) ((UltraToggleEditorBase) this.chkInspectionTypeDriveBy).Checked,
      (object) "@InspectionTypeRecommendation",
      (object) ((UltraToggleEditorBase) this.chkInspectionTypeRecommendation).Checked,
      (object) "@InspectionTypeDiagram",
      (object) ((UltraToggleEditorBase) this.chkInspectionTypeDiagram).Checked,
      (object) "@CostEstimatorInsuranceToValue",
      (object) ((UltraToggleEditorBase) this.chkCostEstimatorInsuranceToValue).Checked,
      (object) "@CostEstimatorReplacementCost",
      (object) ((UltraToggleEditorBase) this.chkCostEstimatorReplacementCost).Checked,
      (object) "@CostEstimatorActualCashValue",
      (object) ((UltraToggleEditorBase) this.chkCostEstimatorActualCashValue).Checked,
      (object) "@RushRequest",
      obj,
      (object) "@PropertyTypeApartmentBuilding",
      (object) ((UltraToggleEditorBase) this.chkPropertyTypeApartmentBuilding).Checked,
      (object) "@PropertyTypeLessorRiskOnly",
      (object) ((UltraToggleEditorBase) this.chkPropertyTypeLessorsRiskOnly).Checked,
      (object) "@PropertyTypeMercantile",
      (object) ((UltraToggleEditorBase) this.chkPropertyTypeMercantile).Checked,
      (object) "@PropertyTypeaBuildingOwner",
      (object) ((UltraToggleEditorBase) this.chkPropertyTypeBuildingOwner).Checked,
      (object) "@PropertyTypeOfficeBuilding",
      (object) ((UltraToggleEditorBase) this.chkPropertyTypeOfficeBuilding).Checked,
      (object) "@PropertyTypeRetailStore",
      (object) ((UltraToggleEditorBase) this.chkPropertyTypeRetailStore).Checked,
      (object) "@PropertyTypeOther",
      (object) ((UltraToggleEditorBase) this.chkPropertyTypeOther).Checked,
      (object) "@PropertyTypeDescription",
      (object) ((TextEditorControlBase) this.txtPropertyTypeDescription).Text,
      (object) "@PropertyCoverageBuilding",
      (object) ((UltraToggleEditorBase) this.chkPropertyCoverageBuilding).Checked,
      (object) "@PropertyCoverageInterior",
      (object) ((UltraToggleEditorBase) this.chkPropertyCoverageInterior).Checked,
      (object) "@PropertyCoverageExterior",
      (object) ((UltraToggleEditorBase) this.chkPropertyCoverageExterior).Checked,
      (object) "@PropertyCoverageContents",
      (object) ((UltraToggleEditorBase) this.chkPropertyCoverageContents).Checked,
      (object) "@VacantBuildingExteriorOnly",
      (object) ((UltraToggleEditorBase) this.chkVacantBuildingExteriorOnly).Checked,
      (object) "@VacantBuildingInteriorRequired",
      (object) ((UltraToggleEditorBase) this.chkVacantBuildingInteriorRequired).Checked,
      (object) "@ManuContrJobsite",
      (object) ((UltraToggleEditorBase) this.chkManuContrJobsite).Checked,
      (object) "@ManuContrPremises",
      (object) ((UltraToggleEditorBase) this.chkManuContrPremises).Checked,
      (object) "@ManuContrPhone",
      (object) ((UltraToggleEditorBase) this.chkManuContrPhone).Checked,
      (object) "@HomeOwnerExterior",
      (object) ((UltraToggleEditorBase) this.chkHomeOwnerExterior).Checked,
      (object) "@HomeOwnerFullReport",
      (object) ((UltraToggleEditorBase) this.chkHomeOwnerFullReport).Checked,
      (object) "@ConfirmAmountsPayroll",
      (object) ((UltraToggleEditorBase) this.chkConfirmAmountsPayroll).Checked,
      (object) "@ConfirmAmountsReceipts",
      (object) ((UltraToggleEditorBase) this.chkConfirmAmountsReceipts).Checked,
      (object) "@PayrollAmount",
      this.numPayrollAmount.Value,
      (object) "@ReceiptsAmount",
      this.numReceiptsAmount.Value,
      (object) "@CoverageTypeLiability",
      (object) ((UltraToggleEditorBase) this.chkCoverageTypeLiability).Checked,
      (object) "@CoverageTypeAllRisk",
      (object) ((UltraToggleEditorBase) this.chkCoverageTypeAllRisk).Checked,
      (object) "@CoverageTypeRestaurant",
      (object) ((UltraToggleEditorBase) this.chkCoverageTypeRestaurant).Checked,
      (object) "@CoverageTypeFire",
      (object) ((UltraToggleEditorBase) this.chkCoverageTypeFire).Checked,
      (object) "@CoverageTypeWorkersComp",
      (object) ((UltraToggleEditorBase) this.chkCoverageTypeWorkersComp).Checked,
      (object) "@CoverageTypeAutoFleetSurvey",
      (object) ((UltraToggleEditorBase) this.chkCoverageTypeAutoFleetSurvey).Checked,
      (object) "@CoverageTypeLiquorLegal",
      (object) ((UltraToggleEditorBase) this.chkCoverageTypeLiquorLegal).Checked,
      (object) "@CoverageTypeGarageKeepers",
      (object) ((UltraToggleEditorBase) this.chkCoverageTypeGarageKeepers).Checked,
      (object) "@CoverageTypeGarageLiability",
      (object) ((UltraToggleEditorBase) this.chkCoverageTypeLiability).Checked,
      (object) "@CoverageTypeGlassCoverage",
      (object) ((UltraToggleEditorBase) this.chkCoverageTypeGlassCoverage).Checked,
      (object) "@CoverageTypeProducts",
      (object) ((UltraToggleEditorBase) this.chkCoverageTypeProducts).Checked,
      (object) "@BuildersRisk",
      (object) ((UltraToggleEditorBase) this.chkBuildersRisk).Checked
    });
    this.Close();
  }

  private void BtnCancel_Click(object sender, EventArgs e) => this.Close();

  private void LnkClearForm_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    try
    {
      foreach (Control control in ((Control) this.grpInspection).Controls)
      {
        if (control is MGACheckBox)
          ((UltraToggleEditorBase) control).Checked = false;
        if (control is RadioButton)
          ((RadioButton) control).Checked = false;
        if (control is MGATextBox)
          ((TextEditorControlBase) control).Text = string.Empty;
        if (control is MGANumericEditor)
          ((UltraNumericEditor) control).Value = (object) DBNull.Value;
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
