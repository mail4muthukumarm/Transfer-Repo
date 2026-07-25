// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Inspections.FormExpertInsured
// Assembly: MgaSystems.IMS.Inspections, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 07B8D1F3-634C-445B-ABFB-027DE209A43D
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Inspections.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using MGASystems.Common;
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
public class FormExpertInsured : Form
{
  private IContainer components;
  private readonly Guid _controlGuid;
  private readonly int _controlNo;

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
    this.components = (IContainer) new System.ComponentModel.Container();
    Appearance appearance1 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormExpertInsured));
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    this.btnSave = new MGAButton();
    this.panelControls = new MGAGroupBox();
    this.chkBuildersRisk = new CheckBox();
    this.chkCoverageTypeRestaurant = new CheckBox();
    this.chkCoverageTypeFire = new CheckBox();
    this.chkCoverageTypeWorkersComp = new CheckBox();
    this.chkCoverageTypeAutoFleetSurvey = new CheckBox();
    this.chkCoverageTypeLiquorLegal = new CheckBox();
    this.chkCoverageTypeGarageKeepers = new CheckBox();
    this.chkCoverageTypeGarageLiability = new CheckBox();
    this.chkCoverageTypeGlassCoverage = new CheckBox();
    this.chkCoverageTypeProducts = new CheckBox();
    this.chkCoverageTypeAllRisk = new CheckBox();
    this.chkCoverageTypeLiability = new CheckBox();
    this.Label12 = new Label();
    this.numReceiptsAmount = new MGANumericEditor();
    this.Label11 = new Label();
    this.numPayrollAmount = new MGANumericEditor();
    this.Label10 = new Label();
    this.chkConfirmAmountsPayroll = new CheckBox();
    this.chkConfirmAmountsReceipts = new CheckBox();
    this.Label9 = new Label();
    this.chkHomeOwnerExterior = new CheckBox();
    this.chkHomeOwnerFullReport = new CheckBox();
    this.Label8 = new Label();
    this.chkManContractPhone = new CheckBox();
    this.chkManContractPremises = new CheckBox();
    this.chkManContractJobsite = new CheckBox();
    this.Label7 = new Label();
    this.chkVacantBuildingInteriorReq = new CheckBox();
    this.chkVacantBuildingExtOnly = new CheckBox();
    this.Label6 = new Label();
    this.chkPropertyCoverageBldg = new CheckBox();
    this.chkPropertyCoverageExterior = new CheckBox();
    this.chkPropertyCoverageContents = new CheckBox();
    this.chkPropertyCoverageInterior = new CheckBox();
    this.Label5 = new Label();
    this.txtPropertyTypeOtherDescription = new TextBox();
    this.Label4 = new Label();
    this.chkPropertyTypeAptBldg = new CheckBox();
    this.chkPropertyTypeLessorRiskOnly = new CheckBox();
    this.chkPropertyTypeMercantile = new CheckBox();
    this.chkPropertyTypeBldgOwner = new CheckBox();
    this.chkPropertyTypeOfficeBldg = new CheckBox();
    this.chkPropertyTypeRetailStore = new CheckBox();
    this.chkPropertyTypeOther = new CheckBox();
    this.lblPropertyType = new Label();
    this.rbRushRequiredNo = new RadioButton();
    this.rbRushRequiredYes = new RadioButton();
    this.Label2 = new Label();
    this.chkCostEstimatorRepCost = new CheckBox();
    this.chkCostEstimatorACV = new CheckBox();
    this.chkCostEstimatorITV = new CheckBox();
    this.Label1 = new Label();
    this.chkInspTypeShortForm = new CheckBox();
    this.chkInspTypeDriveBy = new CheckBox();
    this.chkInspTypeRecommendation = new CheckBox();
    this.chkInspTypeDiagram = new CheckBox();
    this.chkInspTypeFullReport = new CheckBox();
    this.lblInspectType = new Label();
    this.lnkClearForm = new LinkLabel();
    this.err = new ErrorProvider(this.components);
    ((ISupportInitialize) this.btnSave).BeginInit();
    ((ISupportInitialize) this.panelControls).BeginInit();
    ((Control) this.panelControls).SuspendLayout();
    ((ISupportInitialize) this.numReceiptsAmount).BeginInit();
    ((ISupportInitialize) this.numPayrollAmount).BeginInit();
    ((ISupportInitialize) this.err).BeginInit();
    this.SuspendLayout();
    ((Control) this.btnSave).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance1.BackColor = Color.FromArgb(248, 248, 248);
    appearance1.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance1.BackGradientStyle = (GradientStyle) 2;
    appearance1.BorderColor = Color.DarkGray;
    appearance1.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance1.Image"));
    appearance1.ImageHAlign = (HAlign) 1;
    appearance1.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnSave).Appearance = (AppearanceBase) appearance1;
    ((Control) this.btnSave).Font = new Font("Tahoma", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.btnSave).Location = new Point(681, 616);
    ((Control) this.btnSave).Name = "btnSave";
    ((ControlBase) this.btnSave).Padding = new Size(5, 0);
    ((Control) this.btnSave).Size = new Size(70, 34);
    ((Control) this.btnSave).TabIndex = 1;
    ((ControlBase) this.btnSave).Text = "Save";
    this.btnSave.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.panelControls).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    appearance2.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.panelControls.Appearance = (AppearanceBase) appearance2;
    this.panelControls.BackColorInternal = Color.FromArgb(239, 247, 253);
    appearance3.BackColor = Color.FromArgb(239, 247, 253);
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.panelControls.ContentAreaAppearance = (AppearanceBase) appearance3;
    ((Control) this.panelControls).Controls.Add((Control) this.chkBuildersRisk);
    ((Control) this.panelControls).Controls.Add((Control) this.chkCoverageTypeRestaurant);
    ((Control) this.panelControls).Controls.Add((Control) this.chkCoverageTypeFire);
    ((Control) this.panelControls).Controls.Add((Control) this.chkCoverageTypeWorkersComp);
    ((Control) this.panelControls).Controls.Add((Control) this.chkCoverageTypeAutoFleetSurvey);
    ((Control) this.panelControls).Controls.Add((Control) this.chkCoverageTypeLiquorLegal);
    ((Control) this.panelControls).Controls.Add((Control) this.chkCoverageTypeGarageKeepers);
    ((Control) this.panelControls).Controls.Add((Control) this.chkCoverageTypeGarageLiability);
    ((Control) this.panelControls).Controls.Add((Control) this.chkCoverageTypeGlassCoverage);
    ((Control) this.panelControls).Controls.Add((Control) this.chkCoverageTypeProducts);
    ((Control) this.panelControls).Controls.Add((Control) this.chkCoverageTypeAllRisk);
    ((Control) this.panelControls).Controls.Add((Control) this.chkCoverageTypeLiability);
    ((Control) this.panelControls).Controls.Add((Control) this.Label12);
    ((Control) this.panelControls).Controls.Add((Control) this.numReceiptsAmount);
    ((Control) this.panelControls).Controls.Add((Control) this.Label11);
    ((Control) this.panelControls).Controls.Add((Control) this.numPayrollAmount);
    ((Control) this.panelControls).Controls.Add((Control) this.Label10);
    ((Control) this.panelControls).Controls.Add((Control) this.chkConfirmAmountsPayroll);
    ((Control) this.panelControls).Controls.Add((Control) this.chkConfirmAmountsReceipts);
    ((Control) this.panelControls).Controls.Add((Control) this.Label9);
    ((Control) this.panelControls).Controls.Add((Control) this.chkHomeOwnerExterior);
    ((Control) this.panelControls).Controls.Add((Control) this.chkHomeOwnerFullReport);
    ((Control) this.panelControls).Controls.Add((Control) this.Label8);
    ((Control) this.panelControls).Controls.Add((Control) this.chkManContractPhone);
    ((Control) this.panelControls).Controls.Add((Control) this.chkManContractPremises);
    ((Control) this.panelControls).Controls.Add((Control) this.chkManContractJobsite);
    ((Control) this.panelControls).Controls.Add((Control) this.Label7);
    ((Control) this.panelControls).Controls.Add((Control) this.chkVacantBuildingInteriorReq);
    ((Control) this.panelControls).Controls.Add((Control) this.chkVacantBuildingExtOnly);
    ((Control) this.panelControls).Controls.Add((Control) this.Label6);
    ((Control) this.panelControls).Controls.Add((Control) this.chkPropertyCoverageBldg);
    ((Control) this.panelControls).Controls.Add((Control) this.chkPropertyCoverageExterior);
    ((Control) this.panelControls).Controls.Add((Control) this.chkPropertyCoverageContents);
    ((Control) this.panelControls).Controls.Add((Control) this.chkPropertyCoverageInterior);
    ((Control) this.panelControls).Controls.Add((Control) this.Label5);
    ((Control) this.panelControls).Controls.Add((Control) this.txtPropertyTypeOtherDescription);
    ((Control) this.panelControls).Controls.Add((Control) this.Label4);
    ((Control) this.panelControls).Controls.Add((Control) this.chkPropertyTypeAptBldg);
    ((Control) this.panelControls).Controls.Add((Control) this.chkPropertyTypeLessorRiskOnly);
    ((Control) this.panelControls).Controls.Add((Control) this.chkPropertyTypeMercantile);
    ((Control) this.panelControls).Controls.Add((Control) this.chkPropertyTypeBldgOwner);
    ((Control) this.panelControls).Controls.Add((Control) this.chkPropertyTypeOfficeBldg);
    ((Control) this.panelControls).Controls.Add((Control) this.chkPropertyTypeRetailStore);
    ((Control) this.panelControls).Controls.Add((Control) this.chkPropertyTypeOther);
    ((Control) this.panelControls).Controls.Add((Control) this.lblPropertyType);
    ((Control) this.panelControls).Controls.Add((Control) this.rbRushRequiredNo);
    ((Control) this.panelControls).Controls.Add((Control) this.rbRushRequiredYes);
    ((Control) this.panelControls).Controls.Add((Control) this.Label2);
    ((Control) this.panelControls).Controls.Add((Control) this.chkCostEstimatorRepCost);
    ((Control) this.panelControls).Controls.Add((Control) this.chkCostEstimatorACV);
    ((Control) this.panelControls).Controls.Add((Control) this.chkCostEstimatorITV);
    ((Control) this.panelControls).Controls.Add((Control) this.Label1);
    ((Control) this.panelControls).Controls.Add((Control) this.chkInspTypeShortForm);
    ((Control) this.panelControls).Controls.Add((Control) this.chkInspTypeDriveBy);
    ((Control) this.panelControls).Controls.Add((Control) this.chkInspTypeRecommendation);
    ((Control) this.panelControls).Controls.Add((Control) this.chkInspTypeDiagram);
    ((Control) this.panelControls).Controls.Add((Control) this.chkInspTypeFullReport);
    ((Control) this.panelControls).Controls.Add((Control) this.lblInspectType);
    appearance4.ForeColor = Color.FromArgb(21, 66, 139);
    this.panelControls.HeaderAppearance = (AppearanceBase) appearance4;
    ((Control) this.panelControls).Location = new Point(14, 12);
    ((Control) this.panelControls).Name = "panelControls";
    ((Control) this.panelControls).Size = new Size(737, 598);
    ((Control) this.panelControls).TabIndex = 0;
    this.panelControls.Text = "Inspection Details";
    this.panelControls.ViewStyle = (GroupBoxViewStyle) 2;
    this.chkBuildersRisk.AutoSize = true;
    this.chkBuildersRisk.Location = new Point(569, 549);
    this.chkBuildersRisk.Name = "chkBuildersRisk";
    this.chkBuildersRisk.Size = new Size(87, 17);
    this.chkBuildersRisk.TabIndex = 95;
    this.chkBuildersRisk.Text = "Builders Risk";
    this.chkBuildersRisk.UseVisualStyleBackColor = true;
    this.chkCoverageTypeRestaurant.AutoSize = true;
    this.chkCoverageTypeRestaurant.Location = new Point(438, 489);
    this.chkCoverageTypeRestaurant.Name = "chkCoverageTypeRestaurant";
    this.chkCoverageTypeRestaurant.Size = new Size(78, 17);
    this.chkCoverageTypeRestaurant.TabIndex = 35;
    this.chkCoverageTypeRestaurant.Text = "Restaurant";
    this.chkCoverageTypeRestaurant.UseVisualStyleBackColor = true;
    this.chkCoverageTypeFire.AutoSize = true;
    this.chkCoverageTypeFire.Location = new Point(569, 489);
    this.chkCoverageTypeFire.Name = "chkCoverageTypeFire";
    this.chkCoverageTypeFire.Size = new Size(43, 17);
    this.chkCoverageTypeFire.TabIndex = 36;
    this.chkCoverageTypeFire.Text = "Fire";
    this.chkCoverageTypeFire.UseVisualStyleBackColor = true;
    this.chkCoverageTypeWorkersComp.AutoSize = true;
    this.chkCoverageTypeWorkersComp.Location = new Point(193, 516);
    this.chkCoverageTypeWorkersComp.Name = "chkCoverageTypeWorkersComp";
    this.chkCoverageTypeWorkersComp.Size = new Size(96 /*0x60*/, 17);
    this.chkCoverageTypeWorkersComp.TabIndex = 37;
    this.chkCoverageTypeWorkersComp.Text = "Workers Comp";
    this.chkCoverageTypeWorkersComp.UseVisualStyleBackColor = true;
    this.chkCoverageTypeAutoFleetSurvey.AutoSize = true;
    this.chkCoverageTypeAutoFleetSurvey.Location = new Point(319, 516);
    this.chkCoverageTypeAutoFleetSurvey.Name = "chkCoverageTypeAutoFleetSurvey";
    this.chkCoverageTypeAutoFleetSurvey.Size = new Size(110, 17);
    this.chkCoverageTypeAutoFleetSurvey.TabIndex = 38;
    this.chkCoverageTypeAutoFleetSurvey.Text = "Auto Fleet Survey";
    this.chkCoverageTypeAutoFleetSurvey.UseVisualStyleBackColor = true;
    this.chkCoverageTypeLiquorLegal.AutoSize = true;
    this.chkCoverageTypeLiquorLegal.Location = new Point(438, 516);
    this.chkCoverageTypeLiquorLegal.Name = "chkCoverageTypeLiquorLegal";
    this.chkCoverageTypeLiquorLegal.Size = new Size(84, 17);
    this.chkCoverageTypeLiquorLegal.TabIndex = 39;
    this.chkCoverageTypeLiquorLegal.Text = "Liquor Legal";
    this.chkCoverageTypeLiquorLegal.UseVisualStyleBackColor = true;
    this.chkCoverageTypeGarageKeepers.AutoSize = true;
    this.chkCoverageTypeGarageKeepers.Location = new Point(569, 516);
    this.chkCoverageTypeGarageKeepers.Name = "chkCoverageTypeGarageKeepers";
    this.chkCoverageTypeGarageKeepers.Size = new Size(103, 17);
    this.chkCoverageTypeGarageKeepers.TabIndex = 40;
    this.chkCoverageTypeGarageKeepers.Text = "Garage Keepers";
    this.chkCoverageTypeGarageKeepers.UseVisualStyleBackColor = true;
    this.chkCoverageTypeGarageLiability.AutoSize = true;
    this.chkCoverageTypeGarageLiability.Location = new Point(193, 549);
    this.chkCoverageTypeGarageLiability.Name = "chkCoverageTypeGarageLiability";
    this.chkCoverageTypeGarageLiability.Size = new Size(98, 17);
    this.chkCoverageTypeGarageLiability.TabIndex = 41;
    this.chkCoverageTypeGarageLiability.Text = "Garage Liability";
    this.chkCoverageTypeGarageLiability.UseVisualStyleBackColor = true;
    this.chkCoverageTypeGlassCoverage.AutoSize = true;
    this.chkCoverageTypeGlassCoverage.Location = new Point(319, 549);
    this.chkCoverageTypeGlassCoverage.Name = "chkCoverageTypeGlassCoverage";
    this.chkCoverageTypeGlassCoverage.Size = new Size(101, 17);
    this.chkCoverageTypeGlassCoverage.TabIndex = 42;
    this.chkCoverageTypeGlassCoverage.Text = "Glass Coverage";
    this.chkCoverageTypeGlassCoverage.UseVisualStyleBackColor = true;
    this.chkCoverageTypeProducts.AutoSize = true;
    this.chkCoverageTypeProducts.Location = new Point(438, 549);
    this.chkCoverageTypeProducts.Name = "chkCoverageTypeProducts";
    this.chkCoverageTypeProducts.Size = new Size(68, 17);
    this.chkCoverageTypeProducts.TabIndex = 43;
    this.chkCoverageTypeProducts.Text = "Products";
    this.chkCoverageTypeProducts.UseVisualStyleBackColor = true;
    this.chkCoverageTypeAllRisk.AutoSize = true;
    this.chkCoverageTypeAllRisk.Location = new Point(319, 489);
    this.chkCoverageTypeAllRisk.Name = "chkCoverageTypeAllRisk";
    this.chkCoverageTypeAllRisk.Size = new Size(61, 17);
    this.chkCoverageTypeAllRisk.TabIndex = 34;
    this.chkCoverageTypeAllRisk.Text = "All Risk";
    this.chkCoverageTypeAllRisk.UseVisualStyleBackColor = true;
    this.chkCoverageTypeLiability.AutoSize = true;
    this.chkCoverageTypeLiability.Location = new Point(193, 489);
    this.chkCoverageTypeLiability.Name = "chkCoverageTypeLiability";
    this.chkCoverageTypeLiability.Size = new Size(60, 17);
    this.chkCoverageTypeLiability.TabIndex = 33;
    this.chkCoverageTypeLiability.Text = "Liability";
    this.chkCoverageTypeLiability.UseVisualStyleBackColor = true;
    this.Label12.AutoSize = true;
    this.Label12.Location = new Point(91, 491);
    this.Label12.Name = "Label12";
    this.Label12.Size = new Size(83, 13);
    this.Label12.TabIndex = 94;
    this.Label12.Text = "Coverage Type:";
    appearance5.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.numReceiptsAmount).Appearance = (AppearanceBase) appearance5;
    ((UltraNumericEditorBase) this.numReceiptsAmount).FormatString = "c";
    ((Control) this.numReceiptsAmount).Location = new Point(193, 454);
    this.numReceiptsAmount.MaskInput = "nnnnnnnnnnnnn.nn";
    this.numReceiptsAmount.MaxValue = (object) 9999999999999.99;
    this.numReceiptsAmount.MGAStyle = MGAStyles.Blue;
    this.numReceiptsAmount.MinValue = (object) 0.0;
    ((Control) this.numReceiptsAmount).Name = "numReceiptsAmount";
    this.numReceiptsAmount.Nullable = true;
    this.numReceiptsAmount.NumericType = (NumericType) 1;
    ((Control) this.numReceiptsAmount).Size = new Size(150, 19);
    ((Control) this.numReceiptsAmount).TabIndex = 32 /*0x20*/;
    ((UltraControlBase) this.numReceiptsAmount).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numReceiptsAmount).UseOsThemes = (DefaultableBoolean) 2;
    this.numReceiptsAmount.Value = (object) null;
    this.Label11.AutoSize = true;
    this.Label11.Location = new Point(83, 457);
    this.Label11.Name = "Label11";
    this.Label11.Size = new Size(91, 13);
    this.Label11.TabIndex = 92;
    this.Label11.Text = "Receipts Amount:";
    appearance6.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.numPayrollAmount).Appearance = (AppearanceBase) appearance6;
    ((UltraNumericEditorBase) this.numPayrollAmount).FormatString = "c";
    ((Control) this.numPayrollAmount).Location = new Point(193, 420);
    this.numPayrollAmount.MaskInput = "nnnnnnnnnnnnn.nn";
    this.numPayrollAmount.MaxValue = (object) 9999999999999.99;
    this.numPayrollAmount.MGAStyle = MGAStyles.Blue;
    this.numPayrollAmount.MinValue = (object) 0.0;
    ((Control) this.numPayrollAmount).Name = "numPayrollAmount";
    this.numPayrollAmount.Nullable = true;
    this.numPayrollAmount.NumericType = (NumericType) 1;
    ((Control) this.numPayrollAmount).Size = new Size(150, 19);
    ((Control) this.numPayrollAmount).TabIndex = 31 /*0x1F*/;
    ((UltraControlBase) this.numPayrollAmount).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numPayrollAmount).UseOsThemes = (DefaultableBoolean) 2;
    this.numPayrollAmount.Value = (object) null;
    this.Label10.AutoSize = true;
    this.Label10.Location = new Point(94, 423);
    this.Label10.Name = "Label10";
    this.Label10.Size = new Size(80 /*0x50*/, 13);
    this.Label10.TabIndex = 90;
    this.Label10.Text = "Payroll Amount:";
    this.chkConfirmAmountsPayroll.AutoSize = true;
    this.chkConfirmAmountsPayroll.Location = new Point(193, 387);
    this.chkConfirmAmountsPayroll.Name = "chkConfirmAmountsPayroll";
    this.chkConfirmAmountsPayroll.Size = new Size(95, 17);
    this.chkConfirmAmountsPayroll.TabIndex = 29;
    this.chkConfirmAmountsPayroll.Text = "Payroll Confirm";
    this.chkConfirmAmountsPayroll.UseVisualStyleBackColor = true;
    this.chkConfirmAmountsReceipts.AutoSize = true;
    this.chkConfirmAmountsReceipts.Location = new Point(320, 385);
    this.chkConfirmAmountsReceipts.Name = "chkConfirmAmountsReceipts";
    this.chkConfirmAmountsReceipts.Size = new Size(106, 17);
    this.chkConfirmAmountsReceipts.TabIndex = 30;
    this.chkConfirmAmountsReceipts.Text = "Receipts Confirm";
    this.chkConfirmAmountsReceipts.UseVisualStyleBackColor = true;
    this.Label9.AutoSize = true;
    this.Label9.Location = new Point(85, 389);
    this.Label9.Name = "Label9";
    this.Label9.Size = new Size(89, 13);
    this.Label9.TabIndex = 87;
    this.Label9.Text = "Confirm Amounts:";
    this.chkHomeOwnerExterior.AutoSize = true;
    this.chkHomeOwnerExterior.Location = new Point(193, 353);
    this.chkHomeOwnerExterior.Name = "chkHomeOwnerExterior";
    this.chkHomeOwnerExterior.Size = new Size(61, 17);
    this.chkHomeOwnerExterior.TabIndex = 26;
    this.chkHomeOwnerExterior.Text = "Exterior";
    this.chkHomeOwnerExterior.UseVisualStyleBackColor = true;
    this.chkHomeOwnerFullReport.AutoSize = true;
    this.chkHomeOwnerFullReport.Location = new Point(319, 351);
    this.chkHomeOwnerFullReport.Name = "chkHomeOwnerFullReport";
    this.chkHomeOwnerFullReport.Size = new Size(77, 17);
    this.chkHomeOwnerFullReport.TabIndex = 27;
    this.chkHomeOwnerFullReport.Text = "Full Report";
    this.chkHomeOwnerFullReport.UseVisualStyleBackColor = true;
    this.Label8.AutoSize = true;
    this.Label8.Location = new Point(102, 355);
    this.Label8.Name = "Label8";
    this.Label8.Size = new Size(72, 13);
    this.Label8.TabIndex = 84;
    this.Label8.Text = "Home Owner:";
    this.chkManContractPhone.AutoSize = true;
    this.chkManContractPhone.Location = new Point(418, 319);
    this.chkManContractPhone.Name = "chkManContractPhone";
    this.chkManContractPhone.Size = new Size(57, 17);
    this.chkManContractPhone.TabIndex = 28;
    this.chkManContractPhone.Text = "Phone";
    this.chkManContractPhone.UseVisualStyleBackColor = true;
    this.chkManContractPremises.AutoSize = true;
    this.chkManContractPremises.Location = new Point(319, 320);
    this.chkManContractPremises.Name = "chkManContractPremises";
    this.chkManContractPremises.Size = new Size(68, 17);
    this.chkManContractPremises.TabIndex = 25;
    this.chkManContractPremises.Text = "Premises";
    this.chkManContractPremises.UseVisualStyleBackColor = true;
    this.chkManContractJobsite.AutoSize = true;
    this.chkManContractJobsite.Location = new Point(193, 319);
    this.chkManContractJobsite.Name = "chkManContractJobsite";
    this.chkManContractJobsite.Size = new Size(59, 17);
    this.chkManContractJobsite.TabIndex = 24;
    this.chkManContractJobsite.Text = "Jobsite";
    this.chkManContractJobsite.UseVisualStyleBackColor = true;
    this.Label7.AutoSize = true;
    this.Label7.Location = new Point(28, 321);
    this.Label7.Name = "Label7";
    this.Label7.Size = new Size(146, 13);
    this.Label7.TabIndex = 80 /*0x50*/;
    this.Label7.Text = "Manufacturer and Contractor:";
    this.chkVacantBuildingInteriorReq.AutoSize = true;
    this.chkVacantBuildingInteriorReq.Location = new Point(319, 285);
    this.chkVacantBuildingInteriorReq.Name = "chkVacantBuildingInteriorReq";
    this.chkVacantBuildingInteriorReq.Size = new Size(104, 17);
    this.chkVacantBuildingInteriorReq.TabIndex = 23;
    this.chkVacantBuildingInteriorReq.Text = "Interior Required";
    this.chkVacantBuildingInteriorReq.UseVisualStyleBackColor = true;
    this.chkVacantBuildingExtOnly.AutoSize = true;
    this.chkVacantBuildingExtOnly.Location = new Point(193, 285);
    this.chkVacantBuildingExtOnly.Name = "chkVacantBuildingExtOnly";
    this.chkVacantBuildingExtOnly.Size = new Size(85, 17);
    this.chkVacantBuildingExtOnly.TabIndex = 22;
    this.chkVacantBuildingExtOnly.Text = "Exterior Only";
    this.chkVacantBuildingExtOnly.UseVisualStyleBackColor = true;
    this.Label6.AutoSize = true;
    this.Label6.Location = new Point(90, 287);
    this.Label6.Name = "Label6";
    this.Label6.Size = new Size(84, 13);
    this.Label6.TabIndex = 77;
    this.Label6.Text = "Vacant Building:";
    this.chkPropertyCoverageBldg.AutoSize = true;
    this.chkPropertyCoverageBldg.Location = new Point(193, 252);
    this.chkPropertyCoverageBldg.Name = "chkPropertyCoverageBldg";
    this.chkPropertyCoverageBldg.Size = new Size(63 /*0x3F*/, 17);
    this.chkPropertyCoverageBldg.TabIndex = 18;
    this.chkPropertyCoverageBldg.Text = "Building";
    this.chkPropertyCoverageBldg.UseVisualStyleBackColor = true;
    this.chkPropertyCoverageExterior.AutoSize = true;
    this.chkPropertyCoverageExterior.Location = new Point(418, 251);
    this.chkPropertyCoverageExterior.Name = "chkPropertyCoverageExterior";
    this.chkPropertyCoverageExterior.Size = new Size(61, 17);
    this.chkPropertyCoverageExterior.TabIndex = 20;
    this.chkPropertyCoverageExterior.Text = "Exterior";
    this.chkPropertyCoverageExterior.UseVisualStyleBackColor = true;
    this.chkPropertyCoverageContents.AutoSize = true;
    this.chkPropertyCoverageContents.Location = new Point(504, 251);
    this.chkPropertyCoverageContents.Name = "chkPropertyCoverageContents";
    this.chkPropertyCoverageContents.Size = new Size(68, 17);
    this.chkPropertyCoverageContents.TabIndex = 21;
    this.chkPropertyCoverageContents.Text = "Contents";
    this.chkPropertyCoverageContents.UseVisualStyleBackColor = true;
    this.chkPropertyCoverageInterior.AutoSize = true;
    this.chkPropertyCoverageInterior.Location = new Point(319, 251);
    this.chkPropertyCoverageInterior.Name = "chkPropertyCoverageInterior";
    this.chkPropertyCoverageInterior.Size = new Size(58, 17);
    this.chkPropertyCoverageInterior.TabIndex = 19;
    this.chkPropertyCoverageInterior.Text = "Interior";
    this.chkPropertyCoverageInterior.UseVisualStyleBackColor = true;
    this.Label5.AutoSize = true;
    this.Label5.Location = new Point(76, 253);
    this.Label5.Name = "Label5";
    this.Label5.Size = new Size(98, 13);
    this.Label5.TabIndex = 72;
    this.Label5.Text = "Property Coverage:";
    this.txtPropertyTypeOtherDescription.Location = new Point(191, 183);
    this.txtPropertyTypeOtherDescription.MaxLength = 500;
    this.txtPropertyTypeOtherDescription.Name = "txtPropertyTypeOtherDescription";
    this.txtPropertyTypeOtherDescription.Size = new Size(486, 20);
    this.txtPropertyTypeOtherDescription.TabIndex = 17;
    this.Label4.AutoSize = true;
    this.Label4.Location = new Point(5, 186);
    this.Label4.Name = "Label4";
    this.Label4.Size = new Size(167, 13);
    this.Label4.TabIndex = 70;
    this.Label4.Text = "Property Type (Other Description):";
    this.chkPropertyTypeAptBldg.AutoSize = true;
    this.chkPropertyTypeAptBldg.Location = new Point(191, 118);
    this.chkPropertyTypeAptBldg.Name = "chkPropertyTypeAptBldg";
    this.chkPropertyTypeAptBldg.Size = new Size(114, 17);
    this.chkPropertyTypeAptBldg.TabIndex = 10;
    this.chkPropertyTypeAptBldg.Tag = (object) "PropType";
    this.chkPropertyTypeAptBldg.Text = "Apartment Building";
    this.chkPropertyTypeAptBldg.UseVisualStyleBackColor = true;
    this.chkPropertyTypeLessorRiskOnly.AutoSize = true;
    this.chkPropertyTypeLessorRiskOnly.Location = new Point(318, 118);
    this.chkPropertyTypeLessorRiskOnly.Name = "chkPropertyTypeLessorRiskOnly";
    this.chkPropertyTypeLessorRiskOnly.Size = new Size(112 /*0x70*/, 17);
    this.chkPropertyTypeLessorRiskOnly.TabIndex = 11;
    this.chkPropertyTypeLessorRiskOnly.Tag = (object) "PropType";
    this.chkPropertyTypeLessorRiskOnly.Text = "Lessor's Risk Only";
    this.chkPropertyTypeLessorRiskOnly.UseVisualStyleBackColor = true;
    this.chkPropertyTypeMercantile.AutoSize = true;
    this.chkPropertyTypeMercantile.Location = new Point(448, 118);
    this.chkPropertyTypeMercantile.Name = "chkPropertyTypeMercantile";
    this.chkPropertyTypeMercantile.Size = new Size(75, 17);
    this.chkPropertyTypeMercantile.TabIndex = 12;
    this.chkPropertyTypeMercantile.Tag = (object) "PropType";
    this.chkPropertyTypeMercantile.Text = "Mercantile";
    this.chkPropertyTypeMercantile.UseVisualStyleBackColor = true;
    this.chkPropertyTypeBldgOwner.AutoSize = true;
    this.chkPropertyTypeBldgOwner.Location = new Point(552, 118);
    this.chkPropertyTypeBldgOwner.Name = "chkPropertyTypeBldgOwner";
    this.chkPropertyTypeBldgOwner.Size = new Size(97, 17);
    this.chkPropertyTypeBldgOwner.TabIndex = 13;
    this.chkPropertyTypeBldgOwner.Tag = (object) "PropType";
    this.chkPropertyTypeBldgOwner.Text = "Building Owner";
    this.chkPropertyTypeBldgOwner.UseVisualStyleBackColor = true;
    this.chkPropertyTypeOfficeBldg.AutoSize = true;
    this.chkPropertyTypeOfficeBldg.Location = new Point(191, 149);
    this.chkPropertyTypeOfficeBldg.Name = "chkPropertyTypeOfficeBldg";
    this.chkPropertyTypeOfficeBldg.Size = new Size(94, 17);
    this.chkPropertyTypeOfficeBldg.TabIndex = 14;
    this.chkPropertyTypeOfficeBldg.Tag = (object) "PropType";
    this.chkPropertyTypeOfficeBldg.Text = "Office Building";
    this.chkPropertyTypeOfficeBldg.UseVisualStyleBackColor = true;
    this.chkPropertyTypeRetailStore.AutoSize = true;
    this.chkPropertyTypeRetailStore.Location = new Point(318, 149);
    this.chkPropertyTypeRetailStore.Name = "chkPropertyTypeRetailStore";
    this.chkPropertyTypeRetailStore.Size = new Size(81, 17);
    this.chkPropertyTypeRetailStore.TabIndex = 15;
    this.chkPropertyTypeRetailStore.Tag = (object) "PropType";
    this.chkPropertyTypeRetailStore.Text = "Retail Store";
    this.chkPropertyTypeRetailStore.UseVisualStyleBackColor = true;
    this.chkPropertyTypeOther.AutoSize = true;
    this.chkPropertyTypeOther.Location = new Point(448, 149);
    this.chkPropertyTypeOther.Name = "chkPropertyTypeOther";
    this.chkPropertyTypeOther.Size = new Size(52, 17);
    this.chkPropertyTypeOther.TabIndex = 16 /*0x10*/;
    this.chkPropertyTypeOther.Tag = (object) "PropType";
    this.chkPropertyTypeOther.Text = "Other";
    this.chkPropertyTypeOther.UseVisualStyleBackColor = true;
    this.lblPropertyType.AutoSize = true;
    this.lblPropertyType.Location = new Point(96 /*0x60*/, 120);
    this.lblPropertyType.Name = "lblPropertyType";
    this.lblPropertyType.Size = new Size(76, 13);
    this.lblPropertyType.TabIndex = 62;
    this.lblPropertyType.Text = "Property Type:";
    this.rbRushRequiredNo.AutoSize = true;
    this.rbRushRequiredNo.Location = new Point(261, 86);
    this.rbRushRequiredNo.Name = "rbRushRequiredNo";
    this.rbRushRequiredNo.Size = new Size(39, 17);
    this.rbRushRequiredNo.TabIndex = 9;
    this.rbRushRequiredNo.TabStop = true;
    this.rbRushRequiredNo.Text = "No";
    this.rbRushRequiredNo.UseVisualStyleBackColor = true;
    this.rbRushRequiredYes.AutoSize = true;
    this.rbRushRequiredYes.Location = new Point(191, 86);
    this.rbRushRequiredYes.Name = "rbRushRequiredYes";
    this.rbRushRequiredYes.Size = new Size(43, 17);
    this.rbRushRequiredYes.TabIndex = 8;
    this.rbRushRequiredYes.TabStop = true;
    this.rbRushRequiredYes.Text = "Yes";
    this.rbRushRequiredYes.UseVisualStyleBackColor = true;
    this.Label2.AutoSize = true;
    this.Label2.Location = new Point(91, 88);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(81, 13);
    this.Label2.TabIndex = 59;
    this.Label2.Text = "Rush Required:";
    this.chkCostEstimatorRepCost.AutoSize = true;
    this.chkCostEstimatorRepCost.Location = new Point(418, 54);
    this.chkCostEstimatorRepCost.Name = "chkCostEstimatorRepCost";
    this.chkCostEstimatorRepCost.Size = new Size(113, 17);
    this.chkCostEstimatorRepCost.TabIndex = 6;
    this.chkCostEstimatorRepCost.Text = "Replacement Cost";
    this.chkCostEstimatorRepCost.UseVisualStyleBackColor = true;
    this.chkCostEstimatorACV.AutoSize = true;
    this.chkCostEstimatorACV.Location = new Point(567, 54);
    this.chkCostEstimatorACV.Name = "chkCostEstimatorACV";
    this.chkCostEstimatorACV.Size = new Size(113, 17);
    this.chkCostEstimatorACV.TabIndex = 7;
    this.chkCostEstimatorACV.Text = "Actual Cash Value";
    this.chkCostEstimatorACV.UseVisualStyleBackColor = true;
    this.chkCostEstimatorITV.AutoSize = true;
    this.chkCostEstimatorITV.Location = new Point(191, 54);
    this.chkCostEstimatorITV.Name = "chkCostEstimatorITV";
    this.chkCostEstimatorITV.Size = new Size(195, 17);
    this.chkCostEstimatorITV.TabIndex = 5;
    this.chkCostEstimatorITV.Text = "Insurance To Value (Cost Estimator)";
    this.chkCostEstimatorITV.UseVisualStyleBackColor = true;
    this.Label1.AutoSize = true;
    this.Label1.Location = new Point(95, 56);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(77, 13);
    this.Label1.TabIndex = 55;
    this.Label1.Text = "Cost Estimator:";
    this.chkInspTypeShortForm.AutoSize = true;
    this.chkInspTypeShortForm.Location = new Point(317, 23);
    this.chkInspTypeShortForm.Name = "chkInspTypeShortForm";
    this.chkInspTypeShortForm.Size = new Size(77, 17);
    this.chkInspTypeShortForm.TabIndex = 1;
    this.chkInspTypeShortForm.Text = "Short Form";
    this.chkInspTypeShortForm.UseVisualStyleBackColor = true;
    this.chkInspTypeDriveBy.AutoSize = true;
    this.chkInspTypeDriveBy.Location = new Point(418, 22);
    this.chkInspTypeDriveBy.Name = "chkInspTypeDriveBy";
    this.chkInspTypeDriveBy.Size = new Size(66, 17);
    this.chkInspTypeDriveBy.TabIndex = 2;
    this.chkInspTypeDriveBy.Text = "Drive By";
    this.chkInspTypeDriveBy.UseVisualStyleBackColor = true;
    this.chkInspTypeRecommendation.AutoSize = true;
    this.chkInspTypeRecommendation.Location = new Point(518, 22);
    this.chkInspTypeRecommendation.Name = "chkInspTypeRecommendation";
    this.chkInspTypeRecommendation.Size = new Size(109, 17);
    this.chkInspTypeRecommendation.TabIndex = 3;
    this.chkInspTypeRecommendation.Text = "Recommendation";
    this.chkInspTypeRecommendation.UseVisualStyleBackColor = true;
    this.chkInspTypeDiagram.AutoSize = true;
    this.chkInspTypeDiagram.Location = new Point(649, 22);
    this.chkInspTypeDiagram.Name = "chkInspTypeDiagram";
    this.chkInspTypeDiagram.Size = new Size(65, 17);
    this.chkInspTypeDiagram.TabIndex = 4;
    this.chkInspTypeDiagram.Text = "Diagram";
    this.chkInspTypeDiagram.UseVisualStyleBackColor = true;
    this.chkInspTypeFullReport.AutoSize = true;
    this.chkInspTypeFullReport.Location = new Point(191, 22);
    this.chkInspTypeFullReport.Name = "chkInspTypeFullReport";
    this.chkInspTypeFullReport.Size = new Size(77, 17);
    this.chkInspTypeFullReport.TabIndex = 0;
    this.chkInspTypeFullReport.Text = "Full Report";
    this.chkInspTypeFullReport.UseVisualStyleBackColor = true;
    this.lblInspectType.AutoSize = true;
    this.lblInspectType.Location = new Point(86, 24);
    this.lblInspectType.Name = "lblInspectType";
    this.lblInspectType.Size = new Size(86, 13);
    this.lblInspectType.TabIndex = 49;
    this.lblInspectType.Text = "Inspection Type:";
    this.lnkClearForm.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkClearForm.AutoSize = true;
    this.lnkClearForm.Location = new Point(11, 635);
    this.lnkClearForm.Name = "lnkClearForm";
    this.lnkClearForm.Size = new Size(57, 13);
    this.lnkClearForm.TabIndex = 4;
    this.lnkClearForm.TabStop = true;
    this.lnkClearForm.Text = "Clear Form";
    this.err.ContainerControl = (ContainerControl) this;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(763, 658);
    this.Controls.Add((Control) this.lnkClearForm);
    this.Controls.Add((Control) this.panelControls);
    this.Controls.Add((Control) this.btnSave);
    this.Name = nameof (FormExpertInsured);
    this.Text = "Expert Insure Inspection < -- > Majestic Services";
    ((ISupportInitialize) this.btnSave).EndInit();
    ((ISupportInitialize) this.panelControls).EndInit();
    ((Control) this.panelControls).ResumeLayout(false);
    ((Control) this.panelControls).PerformLayout();
    ((ISupportInitialize) this.numReceiptsAmount).EndInit();
    ((ISupportInitialize) this.numPayrollAmount).EndInit();
    ((ISupportInitialize) this.err).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
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

  [field: AccessedThroughProperty("panelControls")]
  private virtual MGAGroupBox panelControls { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("numReceiptsAmount")]
  private virtual MGANumericEditor numReceiptsAmount { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label11")]
  private virtual Label Label11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("numPayrollAmount")]
  private virtual MGANumericEditor numPayrollAmount { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label10")]
  private virtual Label Label10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkConfirmAmountsPayroll")]
  private virtual CheckBox chkConfirmAmountsPayroll { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkConfirmAmountsReceipts")]
  private virtual CheckBox chkConfirmAmountsReceipts { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label9")]
  private virtual Label Label9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkHomeOwnerExterior")]
  private virtual CheckBox chkHomeOwnerExterior { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkHomeOwnerFullReport")]
  private virtual CheckBox chkHomeOwnerFullReport { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label8")]
  private virtual Label Label8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkManContractPhone")]
  private virtual CheckBox chkManContractPhone { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkManContractPremises")]
  private virtual CheckBox chkManContractPremises { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkManContractJobsite")]
  private virtual CheckBox chkManContractJobsite { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label7")]
  private virtual Label Label7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkVacantBuildingInteriorReq")]
  private virtual CheckBox chkVacantBuildingInteriorReq { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkVacantBuildingExtOnly")]
  private virtual CheckBox chkVacantBuildingExtOnly { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label6")]
  private virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkPropertyCoverageBldg")]
  private virtual CheckBox chkPropertyCoverageBldg { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkPropertyCoverageExterior")]
  private virtual CheckBox chkPropertyCoverageExterior { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkPropertyCoverageContents")]
  private virtual CheckBox chkPropertyCoverageContents { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkPropertyCoverageInterior")]
  private virtual CheckBox chkPropertyCoverageInterior { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label5")]
  private virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label4")]
  private virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkPropertyTypeAptBldg")]
  private virtual CheckBox chkPropertyTypeAptBldg { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkPropertyTypeLessorRiskOnly")]
  private virtual CheckBox chkPropertyTypeLessorRiskOnly { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkPropertyTypeMercantile")]
  private virtual CheckBox chkPropertyTypeMercantile { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkPropertyTypeBldgOwner")]
  private virtual CheckBox chkPropertyTypeBldgOwner { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkPropertyTypeOfficeBldg")]
  private virtual CheckBox chkPropertyTypeOfficeBldg { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkPropertyTypeRetailStore")]
  private virtual CheckBox chkPropertyTypeRetailStore { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkPropertyTypeOther")]
  private virtual CheckBox chkPropertyTypeOther { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblPropertyType")]
  private virtual Label lblPropertyType { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("rbRushRequiredNo")]
  internal virtual RadioButton rbRushRequiredNo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("rbRushRequiredYes")]
  internal virtual RadioButton rbRushRequiredYes { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label2")]
  private virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkCostEstimatorRepCost")]
  private virtual CheckBox chkCostEstimatorRepCost { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkCostEstimatorACV")]
  private virtual CheckBox chkCostEstimatorACV { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkCostEstimatorITV")]
  private virtual CheckBox chkCostEstimatorITV { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  private virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkInspTypeShortForm")]
  private virtual CheckBox chkInspTypeShortForm { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkInspTypeDriveBy")]
  private virtual CheckBox chkInspTypeDriveBy { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkInspTypeRecommendation")]
  private virtual CheckBox chkInspTypeRecommendation { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkInspTypeDiagram")]
  private virtual CheckBox chkInspTypeDiagram { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkInspTypeFullReport")]
  private virtual CheckBox chkInspTypeFullReport { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblInspectType")]
  private virtual Label lblInspectType { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkCoverageTypeRestaurant")]
  private virtual CheckBox chkCoverageTypeRestaurant { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkCoverageTypeFire")]
  private virtual CheckBox chkCoverageTypeFire { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkCoverageTypeWorkersComp")]
  private virtual CheckBox chkCoverageTypeWorkersComp { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkCoverageTypeAutoFleetSurvey")]
  private virtual CheckBox chkCoverageTypeAutoFleetSurvey { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkCoverageTypeLiquorLegal")]
  private virtual CheckBox chkCoverageTypeLiquorLegal { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkCoverageTypeGarageKeepers")]
  private virtual CheckBox chkCoverageTypeGarageKeepers { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkCoverageTypeGarageLiability")]
  private virtual CheckBox chkCoverageTypeGarageLiability { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkCoverageTypeGlassCoverage")]
  private virtual CheckBox chkCoverageTypeGlassCoverage { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkCoverageTypeProducts")]
  private virtual CheckBox chkCoverageTypeProducts { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkCoverageTypeAllRisk")]
  private virtual CheckBox chkCoverageTypeAllRisk { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkCoverageTypeLiability")]
  private virtual CheckBox chkCoverageTypeLiability { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label12")]
  private virtual Label Label12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtPropertyTypeOtherDescription")]
  private virtual TextBox txtPropertyTypeOtherDescription { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual LinkLabel lnkClearForm
  {
    get => this._lnkClearForm;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkClearForm_LinkClicked);
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
  private virtual CheckBox chkBuildersRisk { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("err")]
  private virtual ErrorProvider err { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public FormExpertInsured(Guid controlGuid, int controlNo)
  {
    this.Load += new EventHandler(this.FormDisplayDocuments_Load);
    this.InitializeComponent();
    this._controlNo = controlNo;
    this._controlGuid = controlGuid;
  }

  private void FormDisplayDocuments_Load(object sender, EventArgs e)
  {
    DataRow row = DefaultDatabase.ExecuteDataRow("GetExpertInsuredData", new object[4]
    {
      (object) "@ControlNo",
      (object) this._controlNo,
      (object) "@ControlGuid",
      (object) this._controlGuid
    });
    if (row == null)
      return;
    if (!row.IsNull("InspTypeFullReport"))
      this.chkInspTypeFullReport.Checked = row.Field<bool>("InspTypeFullReport");
    if (!row.IsNull("InspTypeShortForm"))
      this.chkInspTypeShortForm.Checked = row.Field<bool>("InspTypeShortForm");
    if (!row.IsNull("InspTypeDriveBy"))
      this.chkInspTypeDriveBy.Checked = row.Field<bool>("InspTypeDriveBy");
    if (!row.IsNull("InspTypeRecommendation"))
      this.chkInspTypeRecommendation.Checked = row.Field<bool>("InspTypeRecommendation");
    if (!row.IsNull("InspTypeDiagram"))
      this.chkInspTypeDiagram.Checked = row.Field<bool>("InspTypeDiagram");
    if (!row.IsNull("CostEstimatorITV"))
      this.chkCostEstimatorITV.Checked = row.Field<bool>("CostEstimatorITV");
    if (!row.IsNull("CostEstimatorRepCost"))
      this.chkCostEstimatorRepCost.Checked = row.Field<bool>("CostEstimatorRepCost");
    if (!row.IsNull("RushRequired"))
    {
      if (row.Field<bool>("RushRequired"))
        this.rbRushRequiredYes.Checked = true;
      else
        this.rbRushRequiredNo.Checked = false;
    }
    if (!row.IsNull("CostEstimatorACV"))
      this.chkCostEstimatorACV.Checked = row.Field<bool>("CostEstimatorACV");
    if (!row.IsNull("PropertyTypeAptBldg"))
      this.chkPropertyTypeAptBldg.Checked = row.Field<bool>("PropertyTypeAptBldg");
    if (!row.IsNull("PropertyTypeLessorRiskOnly"))
      this.chkPropertyTypeLessorRiskOnly.Checked = row.Field<bool>("PropertyTypeLessorRiskOnly");
    if (!row.IsNull("PropertyTypeMercantile"))
      this.chkPropertyTypeMercantile.Checked = row.Field<bool>("PropertyTypeMercantile");
    if (!row.IsNull("PropertyTypeBldgOwner"))
      this.chkPropertyTypeBldgOwner.Checked = row.Field<bool>("PropertyTypeBldgOwner");
    if (!row.IsNull("PropertyTypeOfficeBldg"))
      this.chkPropertyTypeOfficeBldg.Checked = row.Field<bool>("PropertyTypeOfficeBldg");
    if (!row.IsNull("PropertyTypeRetailStore"))
      this.chkPropertyTypeRetailStore.Checked = row.Field<bool>("PropertyTypeRetailStore");
    if (!row.IsNull("PropertyTypeOther"))
      this.chkPropertyTypeOther.Checked = row.Field<bool>("PropertyTypeOther");
    if (!row.IsNull("PropertyTypeOtherDescription"))
      this.txtPropertyTypeOtherDescription.Text = row.Field<string>("PropertyTypeOtherDescription");
    if (!row.IsNull("PropertyCoverageBldg"))
      this.chkPropertyCoverageBldg.Checked = row.Field<bool>("PropertyCoverageBldg");
    if (!row.IsNull("PropertyCoverageInterior"))
      this.chkPropertyCoverageInterior.Checked = row.Field<bool>("PropertyCoverageInterior");
    if (!row.IsNull("PropertyCoverageExterior"))
      this.chkPropertyCoverageExterior.Checked = row.Field<bool>("PropertyCoverageExterior");
    if (!row.IsNull("PropertyCoverageContents"))
      this.chkPropertyCoverageContents.Checked = row.Field<bool>("PropertyCoverageContents");
    if (!row.IsNull("VacantBuildingExtOnly"))
      this.chkVacantBuildingExtOnly.Checked = row.Field<bool>("VacantBuildingExtOnly");
    if (!row.IsNull("ConfirmAmountsReceipts"))
      this.chkConfirmAmountsReceipts.Checked = row.Field<bool>("ConfirmAmountsReceipts");
    if (!row.IsNull("VacantBuildingInteriorReq"))
      this.chkVacantBuildingInteriorReq.Checked = row.Field<bool>("VacantBuildingInteriorReq");
    if (!row.IsNull("ManContractJobsite"))
      this.chkManContractJobsite.Checked = row.Field<bool>("ManContractJobsite");
    if (!row.IsNull("ManContractPremises"))
      this.chkManContractPremises.Checked = row.Field<bool>("ManContractPremises");
    if (!row.IsNull("HomeOwnerExterior"))
      this.chkHomeOwnerExterior.Checked = row.Field<bool>("HomeOwnerExterior");
    if (!row.IsNull("HomeOwnerFullReport"))
      this.chkHomeOwnerFullReport.Checked = row.Field<bool>("HomeOwnerFullReport");
    if (!row.IsNull("ManContractPhone"))
      this.chkManContractPhone.Checked = row.Field<bool>("ManContractPhone");
    if (!row.IsNull("ConfirmAmountsPayroll"))
      this.chkConfirmAmountsPayroll.Checked = row.Field<bool>("ConfirmAmountsPayroll");
    if (!row.IsNull("PayrollAmount"))
      this.numPayrollAmount.Value = (object) row.Field<Decimal>("PayrollAmount");
    if (!row.IsNull("ReceiptsAmount"))
      this.numReceiptsAmount.Value = (object) row.Field<Decimal>("ReceiptsAmount");
    if (!row.IsNull("CoverageTypeLiability"))
      this.chkCoverageTypeLiability.Checked = row.Field<bool>("CoverageTypeLiability");
    if (!row.IsNull("CoverageTypeAllRisk"))
      this.chkCoverageTypeAllRisk.Checked = row.Field<bool>("CoverageTypeAllRisk");
    if (!row.IsNull("CoverageTypeRestaurant"))
      this.chkCoverageTypeRestaurant.Checked = row.Field<bool>("CoverageTypeRestaurant");
    if (!row.IsNull("CoverageTypeFire"))
      this.chkCoverageTypeFire.Checked = row.Field<bool>("CoverageTypeFire");
    if (!row.IsNull("CoverageTypeWorkersComp"))
      this.chkCoverageTypeWorkersComp.Checked = row.Field<bool>("CoverageTypeWorkersComp");
    if (!row.IsNull("CoverageTypeAutoFleetSurvey"))
      this.chkCoverageTypeAutoFleetSurvey.Checked = row.Field<bool>("CoverageTypeAutoFleetSurvey");
    if (!row.IsNull("CoverageTypeLiquorLegal"))
      this.chkCoverageTypeLiquorLegal.Checked = row.Field<bool>("CoverageTypeLiquorLegal");
    if (!row.IsNull("CoverageTypeGarageKeepers"))
      this.chkCoverageTypeGarageKeepers.Checked = row.Field<bool>("CoverageTypeGarageKeepers");
    if (!row.IsNull("CoverageTypeGarageLiability"))
      this.chkCoverageTypeGarageLiability.Checked = row.Field<bool>("CoverageTypeGarageLiability");
    if (!row.IsNull("CoverageTypeGlassCoverage"))
      this.chkCoverageTypeGlassCoverage.Checked = row.Field<bool>("CoverageTypeGlassCoverage");
    if (!row.IsNull("CoverageTypeProducts"))
      this.chkCoverageTypeProducts.Checked = row.Field<bool>("CoverageTypeProducts");
    if (row.IsNull("BuildersRisk"))
      return;
    this.chkBuildersRisk.Checked = row.Field<bool>("BuildersRisk");
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
    if (!this.ValidData())
      return;
    bool flag = false;
    if (this.rbRushRequiredYes.Checked)
      flag = true;
    try
    {
      this.Cursor = MgaCursors.WaitCursor;
      DefaultDatabase.ExecuteNonQuery("SaveExpertInsuredData", new object[92]
      {
        (object) "@ControlNo",
        (object) this._controlNo,
        (object) "@ControlGuid",
        (object) this._controlGuid,
        (object) "@InspTypeFullReport",
        (object) this.chkInspTypeFullReport.Checked,
        (object) "@InspTypeShortForm",
        (object) this.chkInspTypeShortForm.Checked,
        (object) "@InspTypeDriveBy",
        (object) this.chkInspTypeDriveBy.Checked,
        (object) "@InspTypeRecommendation",
        (object) this.chkInspTypeRecommendation.Checked,
        (object) "@InspTypeDiagram",
        (object) this.chkInspTypeDiagram.Checked,
        (object) "@CostEstimatorITV",
        (object) this.chkCostEstimatorITV.Checked,
        (object) "@CostEstimatorRepCost",
        (object) this.chkCostEstimatorRepCost.Checked,
        (object) "@CostEstimatorACV",
        (object) this.chkCostEstimatorACV.Checked,
        (object) "@RushRequired",
        (object) flag,
        (object) "@PropertyTypeAptBldg",
        (object) this.chkPropertyTypeAptBldg.Checked,
        (object) "@PropertyTypeLessorRiskOnly",
        (object) this.chkPropertyTypeLessorRiskOnly.Checked,
        (object) "@PropertyTypeMercantile",
        (object) this.chkPropertyTypeMercantile.Checked,
        (object) "@PropertyTypeBldgOwner",
        (object) this.chkPropertyTypeBldgOwner.Checked,
        (object) "@PropertyTypeOfficeBldg",
        (object) this.chkPropertyTypeOfficeBldg.Checked,
        (object) "@PropertyTypeRetailStore",
        (object) this.chkPropertyTypeRetailStore.Checked,
        (object) "@PropertyTypeOther",
        (object) this.chkPropertyTypeOther.Checked,
        (object) "@PropertyTypeOtherDescription",
        (object) this.txtPropertyTypeOtherDescription.Text,
        (object) "@PropertyCoverageBldg",
        (object) this.chkPropertyCoverageBldg.Checked,
        (object) "@PropertyCoverageInterior",
        (object) this.chkPropertyCoverageInterior.Checked,
        (object) "@PropertyCoverageExterior",
        (object) this.chkPropertyCoverageExterior.Checked,
        (object) "@PropertyCoverageContents",
        (object) this.chkPropertyCoverageContents.Checked,
        (object) "@VacantBuildingExtOnly",
        (object) this.chkVacantBuildingExtOnly.Checked,
        (object) "@ConfirmAmountsReceipts",
        (object) this.chkConfirmAmountsReceipts.Checked,
        (object) "@VacantBuildingInteriorReq",
        (object) this.chkVacantBuildingInteriorReq.Checked,
        (object) "@ManContractJobsite",
        (object) this.chkManContractJobsite.Checked,
        (object) "@ManContractPremises",
        (object) this.chkManContractPremises.Checked,
        (object) "@HomeOwnerExterior",
        (object) this.chkHomeOwnerExterior.Checked,
        (object) "@HomeOwnerFullReport",
        (object) this.chkHomeOwnerFullReport.Checked,
        (object) "@ManContractPhone",
        (object) this.chkManContractPhone.Checked,
        (object) "@ConfirmAmountsPayroll",
        (object) this.chkConfirmAmountsPayroll.Checked,
        (object) "@PayrollAmount",
        this.numPayrollAmount.Value,
        (object) "@ReceiptsAmount",
        this.numReceiptsAmount.Value,
        (object) "@CoverageTypeLiability",
        (object) this.chkCoverageTypeLiability.Checked,
        (object) "@CoverageTypeAllRisk",
        (object) this.chkCoverageTypeAllRisk.Checked,
        (object) "@CoverageTypeRestaurant",
        (object) this.chkCoverageTypeRestaurant.Checked,
        (object) "@CoverageTypeFire",
        (object) this.chkCoverageTypeFire.Checked,
        (object) "@CoverageTypeWorkersComp",
        (object) this.chkCoverageTypeWorkersComp.Checked,
        (object) "@CoverageTypeAutoFleetSurvey",
        (object) this.chkCoverageTypeAutoFleetSurvey.Checked,
        (object) "@CoverageTypeLiquorLegal",
        (object) this.chkCoverageTypeLiquorLegal.Checked,
        (object) "@CoverageTypeGarageKeepers",
        (object) this.chkCoverageTypeGarageKeepers.Checked,
        (object) "@CoverageTypeGarageLiability",
        (object) this.chkCoverageTypeGarageLiability.Checked,
        (object) "@CoverageTypeGlassCoverage",
        (object) this.chkCoverageTypeGlassCoverage.Checked,
        (object) "@CoverageTypeProducts",
        (object) this.chkCoverageTypeProducts.Checked,
        (object) "@BuildersRisk",
        (object) this.chkBuildersRisk.Checked
      });
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
    }
    this.Close();
  }

  private void lnkClearForm_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    try
    {
      foreach (Control control in ((Control) this.panelControls).Controls)
      {
        if (control is MGACheckBox)
          ((UltraToggleEditorBase) control).Checked = false;
        if (control is CheckBox)
          ((CheckBox) control).Checked = false;
        if (control is RadioButton)
          ((RadioButton) control).Checked = false;
        if (control is MGATextBox)
          ((TextEditorControlBase) control).Text = string.Empty;
        if (control is TextBox)
          ((TextBox) control).Text = string.Empty;
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

  private bool ValidData()
  {
    this.err.SetError((Control) this.lblPropertyType, string.Empty);
    bool flag = false;
    try
    {
      foreach (Control control in ((Control) this.panelControls).Controls)
      {
        if (control.Tag != null && control.Tag.ToString().Equals("PropType") && control is CheckBox && ((CheckBox) control).Checked)
        {
          flag = true;
          break;
        }
        if (control.Tag != null && control.Tag.ToString().Equals("PropType") && control is MGACheckBox && ((UltraToggleEditorBase) control).Checked)
        {
          flag = true;
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
    if (!flag)
      this.err.SetError((Control) this.lblPropertyType, "Please select a property type.");
    return flag;
  }
}
