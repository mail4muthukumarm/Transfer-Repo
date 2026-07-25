// Decompiled with JetBrains decompiler
// Type: MgaSystems.Ims.Fortegra.Overrides.Claims.Fortegra_ClaimSearch
// Assembly: MgaSystems.Ims.Fortegra, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27007E94-85B4-4A1A-9444-255CCA5487B0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Fortegra.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using Infragistics.Win.UltraWinToolbars;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Claims;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MgaSystems.Ims.Fortegra.Overrides.Claims;

[Override(typeof (ClaimsSearch))]
public class Fortegra_ClaimSearch : ClaimsSearch, IClaimsSearch
{
  private IContainer components;

  public Fortegra_ClaimSearch() => this.InitializeComponent();

  protected override void SearchClaims()
  {
    this.dsClaimsSearch1.Clear();
    DefaultDatabase.LoadDataSet((DataSet) this.dsClaimsSearch1, new string[2]
    {
      "PolicyInformation",
      "ClaimsInformation"
    }, "Fortegra_spClaims_ClaimsSearch", new object[44]
    {
      (object) "@controlNo",
      (object) (string.IsNullOrEmpty(((Control) this.textControlNumber).Text) ? SqlInt32.Null : (SqlInt32) int.Parse(((Control) this.textControlNumber).Text)),
      (object) "@policyNumber",
      (object) (string.IsNullOrEmpty(((Control) this.textPolicyNumber).Text) ? SqlString.Null : (SqlString) ((Control) this.textPolicyNumber).Text),
      (object) "@insuredName",
      (object) (string.IsNullOrEmpty(((Control) this.textInsuredName).Text) ? SqlString.Null : (SqlString) ((Control) this.textInsuredName).Text),
      (object) "@companyLocationGuid",
      ((UltraDropDownBase) this.comboCompanyLocations).SelectedRow == null ? (object) SqlGuid.Null : this.comboCompanyLocations.Value,
      (object) "@lineGuid",
      ((UltraDropDownBase) this.comboLines).SelectedRow == null ? (object) SqlGuid.Null : this.comboLines.Value,
      (object) "@claimNumber",
      (object) (string.IsNullOrEmpty(((Control) this.textClaimNumber).Text) ? SqlString.Null : (SqlString) ((Control) this.textClaimNumber).Text.Trim()),
      (object) "@claimantSsnFein",
      (object) (string.IsNullOrEmpty(((Control) this.textClaimantSsnFein).Text) ? SqlString.Null : (SqlString) ((Control) this.textClaimantSsnFein).Text),
      (object) "@claimantLastName",
      (object) (string.IsNullOrEmpty(((Control) this.textClaimantLastName).Text) ? SqlString.Null : (SqlString) ((Control) this.textClaimantLastName).Text),
      (object) "@claimantFirstName",
      (object) (string.IsNullOrEmpty(((Control) this.textClaimantFirstName).Text) ? SqlString.Null : (SqlString) ((Control) this.textClaimantFirstName).Text),
      (object) "@lossDateFrom",
      (object) (this.dateLossDateFrom.Value == null || !this.dateLossDateFrom.IsDateValid ? SqlDateTime.Null : (SqlDateTime) this.dateLossDateFrom.DateTime),
      (object) "@lossDateTo",
      (object) (this.dateLossDateTo.Value == null || !this.dateLossDateTo.IsDateValid ? SqlDateTime.Null : (SqlDateTime) this.dateLossDateTo.DateTime),
      (object) "@datereportedfrom",
      (object) (this.dateTimeDateReportedFrom.Value == null || !this.dateTimeDateReportedFrom.IsDateValid ? SqlDateTime.Null : (SqlDateTime) this.dateTimeDateReportedFrom.DateTime),
      (object) "@datereportedto",
      (object) (this.dateTimeDateReportedTo.Value == null || !this.dateTimeDateReportedTo.IsDateValid ? SqlDateTime.Null : (SqlDateTime) this.dateTimeDateReportedTo.DateTime),
      (object) "@adjusterGuid",
      ((UltraDropDownBase) this.comboAdjusterName).SelectedRow == null ? (object) SqlGuid.Null : this.comboAdjusterName.Value,
      (object) "@claimStatus",
      ((UltraDropDownBase) this.comboClaimStatus).SelectedRow == null ? (object) SqlInt32.Null : this.comboClaimStatus.Value,
      (object) "@checkNumber",
      (object) (string.IsNullOrEmpty(((Control) this.textCheckNumber).Text) ? SqlInt32.Null : (SqlInt32) int.Parse(((Control) this.textCheckNumber).Text)),
      (object) "@UserId",
      (object) CurrentUser.Instance.UserID,
      (object) "@corporationName",
      (object) (string.IsNullOrEmpty(((Control) this.textClaimantCorporationName).Text) ? SqlString.Null : (SqlString) ((Control) this.textClaimantCorporationName).Text),
      (object) "@policyEffectiveFrom",
      (object) (this.dateTimePolicyEffectiveFrom.Value == null || !this.dateTimePolicyEffectiveFrom.IsDateValid ? SqlDateTime.Null : (SqlDateTime) this.dateTimePolicyEffectiveFrom.DateTime),
      (object) "@policyEffectiveTo",
      (object) (this.dateTimePolicyEffectiveTo.Value == null || !this.dateTimePolicyEffectiveTo.IsDateValid ? SqlDateTime.Null : (SqlDateTime) this.dateTimePolicyEffectiveTo.DateTime),
      (object) "@policyExpirationFrom",
      (object) (this.dateTimePolicyExpirationFrom.Value == null || !this.dateTimePolicyExpirationFrom.IsDateValid ? SqlDateTime.Null : (SqlDateTime) this.dateTimePolicyExpirationFrom.DateTime),
      (object) "@policyExpirationTo",
      (object) (this.dateTimePolicyExpirationTo.Value == null || !this.dateTimePolicyExpirationTo.IsDateValid ? SqlDateTime.Null : (SqlDateTime) this.dateTimePolicyExpirationTo.DateTime)
    });
    ((UltraGridBase) this.gridSearchResults).DisplayLayout.Load(((UltraGridBase) this.gridSearchResults).Layouts[0], (PropertyCategories) -1);
    ((UltraGridBase) this.gridSearchResults).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    this.FormatGrid();
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
    UltraGridBand ultraGridBand1 = new UltraGridBand("PolicyInformation", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("ControlNumber");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("PolicyNumber");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("Insured");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("Producer");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("Company");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("Line");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("ViewClaims");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("NumberOfClaims");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("FK_PolicyInformation_ClaimsInformation");
    UltraGridBand ultraGridBand2 = new UltraGridBand("FK_PolicyInformation_ClaimsInformation", 0);
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("ControlNumber");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("ClaimId");
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("ClaimNumber");
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("LossDate");
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("EnteredBy");
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("DateEntered");
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("Claimants");
    UltraGridColumn ultraGridColumn17 = new UltraGridColumn("Adjuster");
    UltraGridColumn ultraGridColumn18 = new UltraGridColumn("Locked");
    UltraGridColumn ultraGridColumn19 = new UltraGridColumn("LockImage");
    ColScrollRegion colScrollRegion1 = new ColScrollRegion(697);
    ColScrollRegion colScrollRegion2 = new ColScrollRegion(799);
    ColScrollRegion colScrollRegion3 = new ColScrollRegion(799);
    ColScrollRegion colScrollRegion4 = new ColScrollRegion(799);
    ColScrollRegion colScrollRegion5 = new ColScrollRegion(799);
    ColScrollRegion colScrollRegion6 = new ColScrollRegion(799);
    ColScrollRegion colScrollRegion7 = new ColScrollRegion(799);
    ColScrollRegion colScrollRegion8 = new ColScrollRegion(799);
    ColScrollRegion colScrollRegion9 = new ColScrollRegion(799);
    ColScrollRegion colScrollRegion10 = new ColScrollRegion(799);
    ColScrollRegion colScrollRegion11 = new ColScrollRegion(799);
    ColScrollRegion colScrollRegion12 = new ColScrollRegion(799);
    ColScrollRegion colScrollRegion13 = new ColScrollRegion(703);
    ColScrollRegion colScrollRegion14 = new ColScrollRegion(799);
    ColScrollRegion colScrollRegion15 = new ColScrollRegion(799);
    ColScrollRegion colScrollRegion16 = new ColScrollRegion(799);
    ColScrollRegion colScrollRegion17 = new ColScrollRegion(799);
    ColScrollRegion colScrollRegion18 = new ColScrollRegion(799);
    ColScrollRegion colScrollRegion19 = new ColScrollRegion(799);
    ColScrollRegion colScrollRegion20 = new ColScrollRegion(799);
    ColScrollRegion colScrollRegion21 = new ColScrollRegion(799);
    ColScrollRegion colScrollRegion22 = new ColScrollRegion(799);
    ColScrollRegion colScrollRegion23 = new ColScrollRegion(799);
    ColScrollRegion colScrollRegion24 = new ColScrollRegion(799);
    ColScrollRegion colScrollRegion25 = new ColScrollRegion(799);
    ColScrollRegion colScrollRegion26 = new ColScrollRegion(703);
    ColScrollRegion colScrollRegion27 = new ColScrollRegion(799);
    ColScrollRegion colScrollRegion28 = new ColScrollRegion(703);
    ColScrollRegion colScrollRegion29 = new ColScrollRegion(799);
    ColScrollRegion colScrollRegion30 = new ColScrollRegion(799);
    ColScrollRegion colScrollRegion31 = new ColScrollRegion(799);
    ColScrollRegion colScrollRegion32 = new ColScrollRegion(703);
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    this.dsClaimsSearch1.BeginInit();
    ((ISupportInitialize) this.textPolicyNumber).BeginInit();
    ((ISupportInitialize) this.textInsuredName).BeginInit();
    ((ISupportInitialize) this.textControlNumber).BeginInit();
    ((ISupportInitialize) this.comboLines).BeginInit();
    ((ISupportInitialize) this.comboCompanyLocations).BeginInit();
    ((ISupportInitialize) this.comboAdjusterName).BeginInit();
    ((ISupportInitialize) this.comboClaimStatus).BeginInit();
    ((ISupportInitialize) this.textClaimantLastName).BeginInit();
    ((ISupportInitialize) this.textClaimantFirstName).BeginInit();
    ((ISupportInitialize) this.textClaimantSsnFein).BeginInit();
    ((ISupportInitialize) this.textClaimNumber).BeginInit();
    ((ISupportInitialize) this.dateLossDateTo).BeginInit();
    ((ISupportInitialize) this.dateLossDateFrom).BeginInit();
    ((ISupportInitialize) this.dateTimeDateReportedTo).BeginInit();
    ((ISupportInitialize) this.dateTimeDateReportedFrom).BeginInit();
    ((ISupportInitialize) this.textCheckNumber).BeginInit();
    ((ISupportInitialize) this.textClaimantCorporationName).BeginInit();
    ((ISupportInitialize) this.ultraToolbarsManager1).BeginInit();
    ((ISupportInitialize) this.linesBindingSource1).BeginInit();
    ((ISupportInitialize) this.dsLinesBindingSource).BeginInit();
    this.dsLines.BeginInit();
    ((ISupportInitialize) this.linesBindingSource).BeginInit();
    ((ISupportInitialize) this.companyLocationsBindingSource).BeginInit();
    this.dsCompanyLocations.BeginInit();
    ((ISupportInitialize) this.groupNewClaimSearch).BeginInit();
    ((Control) this.groupNewClaimSearch).SuspendLayout();
    ((ISupportInitialize) this.buttonSearch).BeginInit();
    ((ISupportInitialize) this.buttonCancel).BeginInit();
    ((ISupportInitialize) this.pictureCurtain).BeginInit();
    ((ISupportInitialize) this.gridSearchResults).BeginInit();
    ((ISupportInitialize) this.dateTimePolicyExpirationFrom).BeginInit();
    ((ISupportInitialize) this.dateTimePolicyEffectiveFrom).BeginInit();
    ((ISupportInitialize) this.dateTimePolicyExpirationTo).BeginInit();
    ((ISupportInitialize) this.dateTimePolicyEffectiveTo).BeginInit();
    this.SuspendLayout();
    ((Control) this.textPolicyNumber).Location = new Point(125, 52);
    ((Control) this.textPolicyNumber).Margin = new Padding(2);
    ((Control) this.textPolicyNumber).MinimumSize = new Size(75, 16 /*0x10*/);
    ((Control) this.textInsuredName).Location = new Point(125, 121);
    ((Control) this.textInsuredName).Margin = new Padding(2);
    ((Control) this.textInsuredName).MinimumSize = new Size(75, 16 /*0x10*/);
    ((Control) this.textControlNumber).Location = new Point(125, 30);
    ((Control) this.textControlNumber).Margin = new Padding(2);
    ((Control) this.textControlNumber).MinimumSize = new Size(75, 16 /*0x10*/);
    ((Control) this.comboLines).Location = new Point(125, 166);
    ((Control) this.comboLines).Margin = new Padding(2);
    ((Control) this.comboLines).MinimumSize = new Size(75, 17);
    ((Control) this.comboCompanyLocations).Location = new Point(125, 143);
    ((Control) this.comboCompanyLocations).Margin = new Padding(2);
    ((Control) this.comboCompanyLocations).MinimumSize = new Size(75, 17);
    ((Control) this.comboAdjusterName).Location = new Point(125, 212);
    ((Control) this.comboAdjusterName).Margin = new Padding(2);
    ((Control) this.comboAdjusterName).MinimumSize = new Size(75, 17);
    ((Control) this.comboClaimStatus).Location = new Point(125, 189);
    ((Control) this.comboClaimStatus).Margin = new Padding(2);
    ((Control) this.comboClaimStatus).MinimumSize = new Size(75, 17);
    ((Control) this.textClaimantLastName).Location = new Point(444, 71);
    ((Control) this.textClaimantLastName).Margin = new Padding(2);
    ((Control) this.textClaimantLastName).MinimumSize = new Size(75, 16 /*0x10*/);
    ((Control) this.textClaimantFirstName).Location = new Point(444, 93);
    ((Control) this.textClaimantFirstName).Margin = new Padding(2);
    ((Control) this.textClaimantFirstName).MinimumSize = new Size(75, 16 /*0x10*/);
    ((Control) this.textClaimantSsnFein).Location = new Point(444, 50);
    ((Control) this.textClaimantSsnFein).Margin = new Padding(2);
    ((Control) this.textClaimantSsnFein).MinimumSize = new Size(75, 16 /*0x10*/);
    ((Control) this.textClaimNumber).Location = new Point(444, 29);
    ((Control) this.textClaimNumber).Margin = new Padding(2);
    ((Control) this.textClaimNumber).MinimumSize = new Size(75, 16 /*0x10*/);
    ((Control) this.dateLossDateTo).Location = new Point(572, 135);
    ((Control) this.dateLossDateTo).Margin = new Padding(2);
    ((Control) this.dateLossDateFrom).Location = new Point(444, 136);
    ((Control) this.dateLossDateFrom).Margin = new Padding(2);
    ((Control) this.dateTimeDateReportedTo).Location = new Point(572, 158);
    ((Control) this.dateTimeDateReportedTo).Margin = new Padding(2);
    ((Control) this.dateTimeDateReportedFrom).Location = new Point(444, 159);
    ((Control) this.dateTimeDateReportedFrom).Margin = new Padding(2);
    ((Control) this.textCheckNumber).Location = new Point(444, 181);
    ((Control) this.textCheckNumber).Margin = new Padding(2);
    ((Control) this.textCheckNumber).MinimumSize = new Size(75, 16 /*0x10*/);
    ((Control) this.textClaimantCorporationName).Location = new Point(444, 114);
    ((Control) this.textClaimantCorporationName).Margin = new Padding(2);
    ((Control) this.textClaimantCorporationName).MinimumSize = new Size(75, 16 /*0x10*/);
    ((SettingsBase) this.ultraToolbarsManager1.MenuSettings).ForceSerialization = true;
    ((SettingsBase) this.ultraToolbarsManager1.ToolbarSettings).ForceSerialization = true;
    ((Control) this.groupNewClaimSearch).Location = new Point(36, 44);
    ((Control) this.groupNewClaimSearch).Size = new Size(699, 241);
    ((Control) this.buttonSearch).Location = new Point(484, 212);
    ((Control) this.buttonCancel).Location = new Point(572, 212);
    this.label5.Location = new Point(339, 71);
    this.label6.Location = new Point(339, 93);
    this.label8.Location = new Point(339, 50);
    this.label15.Location = new Point(339, 29);
    this.label14.Location = new Point(542, 139);
    this.label13.Location = new Point(339, 136);
    this.label11.Location = new Point(542, 162);
    this.label12.Location = new Point(339, 159);
    this.label18.Location = new Point(339, 181);
    this.label19.Location = new Point(339, 114);
    this.label4.Location = new Point(14, 165);
    this.label7.Location = new Point(14, 121);
    this.label9.Location = new Point(14, 53);
    this.label10.Location = new Point(14, 29);
    this.label17.Location = new Point(14, 210);
    this.label16.Location = new Point(14, 189);
    this.label3.Location = new Point(14, 143);
    this.pictureCurtain.Location = new Point(36, 307);
    this.pictureCurtain.Size = new Size(699, 323);
    this.labelNoResults.Location = new Point(55, 318);
    ((Control) this.lnkControlNo).Location = new Point(41, 318);
    ((AppearanceBase) appearance1).BackColor = Color.White;
    ((AppearanceBase) appearance1).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridSearchResults).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.gridSearchResults).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn1.EditorComponent = (Component) this.lnkControlNo;
    ((HeaderBase) ultraGridColumn1.Header).Caption = "Control #";
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn1.Header).VisiblePosition = 0;
    ultraGridColumn1.Width = 62;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Policy Number";
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn2.Header).VisiblePosition = 1;
    ultraGridColumn2.Width = 126;
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn3.Header).VisiblePosition = 2;
    ultraGridColumn3.Width = 126;
    ultraGridColumn4.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn4.Header).VisiblePosition = 3;
    ultraGridColumn4.Width = 116;
    ultraGridColumn5.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn5.Header).VisiblePosition = 4;
    ultraGridColumn5.Width = 143;
    ultraGridColumn6.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn6.Header).VisiblePosition = 5;
    ultraGridColumn6.Width = 118;
    ultraGridColumn7.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn7.ButtonDisplayStyle = (ButtonDisplayStyle) 1;
    ((HeaderBase) ultraGridColumn7.Header).Caption = "# of Claims";
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn7.Header).VisiblePosition = 6;
    ultraGridColumn7.Width = 89;
    ultraGridColumn8.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn8.Header).VisiblePosition = 7;
    ultraGridColumn8.Hidden = true;
    ultraGridColumn8.Width = 80 /*0x50*/;
    ultraGridColumn9.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn9.Header).VisiblePosition = 8;
    ultraGridBand1.Columns.AddRange(new object[9]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4,
      (object) ultraGridColumn5,
      (object) ultraGridColumn6,
      (object) ultraGridColumn7,
      (object) ultraGridColumn8,
      (object) ultraGridColumn9
    });
    ultraGridBand1.Override.HeaderClickAction = (HeaderClickAction) 2;
    ultraGridBand1.RowLayoutStyle = (RowLayoutStyle) 1;
    ultraGridColumn10.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn10.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn10.Header).VisiblePosition = 0;
    ultraGridColumn10.Hidden = true;
    ultraGridColumn10.Width = 135;
    ultraGridColumn11.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn11.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn11.Header).VisiblePosition = 1;
    ultraGridColumn11.Hidden = true;
    ultraGridColumn11.Width = 73;
    ultraGridColumn12.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn12.Header).Caption = "Claim #";
    ((HeaderBase) ultraGridColumn12.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn12.Header).VisiblePosition = 2;
    ultraGridColumn12.Width = 155;
    ultraGridColumn13.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn13.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn13.Header).VisiblePosition = 3;
    ultraGridColumn13.Width = 63 /*0x3F*/;
    ultraGridColumn14.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn14.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn14.Header).VisiblePosition = 4;
    ultraGridColumn14.Width = 115;
    ultraGridColumn15.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn15.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn15.Header).VisiblePosition = 6;
    ultraGridColumn15.Width = 87;
    ultraGridColumn16.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn16.Header).Caption = "# of Claimants";
    ((HeaderBase) ultraGridColumn16.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn16.Header).VisiblePosition = 7;
    ultraGridColumn16.Width = 83;
    ultraGridColumn17.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn17.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn17.Header).VisiblePosition = 5;
    ultraGridColumn17.Width = 136;
    ((HeaderBase) ultraGridColumn18.Header).Caption = "";
    ((HeaderBase) ultraGridColumn18.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn18.Header).VisiblePosition = 8;
    ultraGridColumn18.Hidden = true;
    ultraGridColumn18.Style = (ColumnStyle) 27;
    ultraGridColumn18.Width = 27;
    ((HeaderBase) ultraGridColumn19.Header).Caption = "";
    ((HeaderBase) ultraGridColumn19.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn19.Header).VisiblePosition = 9;
    ultraGridColumn19.Style = (ColumnStyle) 27;
    ultraGridColumn19.Width = 20;
    ultraGridBand2.Columns.AddRange(new object[10]
    {
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
    ultraGridBand2.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.gridSearchResults).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.gridSearchResults).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.gridSearchResults).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.gridSearchResults).DisplayLayout.ColScrollRegions.Add((object) colScrollRegion1);
    ((UltraGridBase) this.gridSearchResults).DisplayLayout.ColScrollRegions.Add((object) colScrollRegion2);
    ((UltraGridBase) this.gridSearchResults).DisplayLayout.ColScrollRegions.Add((object) colScrollRegion3);
    ((UltraGridBase) this.gridSearchResults).DisplayLayout.ColScrollRegions.Add((object) colScrollRegion4);
    ((UltraGridBase) this.gridSearchResults).DisplayLayout.ColScrollRegions.Add((object) colScrollRegion5);
    ((UltraGridBase) this.gridSearchResults).DisplayLayout.ColScrollRegions.Add((object) colScrollRegion6);
    ((UltraGridBase) this.gridSearchResults).DisplayLayout.ColScrollRegions.Add((object) colScrollRegion7);
    ((UltraGridBase) this.gridSearchResults).DisplayLayout.ColScrollRegions.Add((object) colScrollRegion8);
    ((UltraGridBase) this.gridSearchResults).DisplayLayout.ColScrollRegions.Add((object) colScrollRegion9);
    ((UltraGridBase) this.gridSearchResults).DisplayLayout.ColScrollRegions.Add((object) colScrollRegion10);
    ((UltraGridBase) this.gridSearchResults).DisplayLayout.ColScrollRegions.Add((object) colScrollRegion11);
    ((UltraGridBase) this.gridSearchResults).DisplayLayout.ColScrollRegions.Add((object) colScrollRegion12);
    ((UltraGridBase) this.gridSearchResults).DisplayLayout.ColScrollRegions.Add((object) colScrollRegion13);
    ((UltraGridBase) this.gridSearchResults).DisplayLayout.ColScrollRegions.Add((object) colScrollRegion14);
    ((UltraGridBase) this.gridSearchResults).DisplayLayout.ColScrollRegions.Add((object) colScrollRegion15);
    ((UltraGridBase) this.gridSearchResults).DisplayLayout.ColScrollRegions.Add((object) colScrollRegion16);
    ((UltraGridBase) this.gridSearchResults).DisplayLayout.ColScrollRegions.Add((object) colScrollRegion17);
    ((UltraGridBase) this.gridSearchResults).DisplayLayout.ColScrollRegions.Add((object) colScrollRegion18);
    ((UltraGridBase) this.gridSearchResults).DisplayLayout.ColScrollRegions.Add((object) colScrollRegion19);
    ((UltraGridBase) this.gridSearchResults).DisplayLayout.ColScrollRegions.Add((object) colScrollRegion20);
    ((UltraGridBase) this.gridSearchResults).DisplayLayout.ColScrollRegions.Add((object) colScrollRegion21);
    ((UltraGridBase) this.gridSearchResults).DisplayLayout.ColScrollRegions.Add((object) colScrollRegion22);
    ((UltraGridBase) this.gridSearchResults).DisplayLayout.ColScrollRegions.Add((object) colScrollRegion23);
    ((UltraGridBase) this.gridSearchResults).DisplayLayout.ColScrollRegions.Add((object) colScrollRegion24);
    ((UltraGridBase) this.gridSearchResults).DisplayLayout.ColScrollRegions.Add((object) colScrollRegion25);
    ((UltraGridBase) this.gridSearchResults).DisplayLayout.ColScrollRegions.Add((object) colScrollRegion26);
    ((UltraGridBase) this.gridSearchResults).DisplayLayout.ColScrollRegions.Add((object) colScrollRegion27);
    ((UltraGridBase) this.gridSearchResults).DisplayLayout.ColScrollRegions.Add((object) colScrollRegion28);
    ((UltraGridBase) this.gridSearchResults).DisplayLayout.ColScrollRegions.Add((object) colScrollRegion29);
    ((UltraGridBase) this.gridSearchResults).DisplayLayout.ColScrollRegions.Add((object) colScrollRegion30);
    ((UltraGridBase) this.gridSearchResults).DisplayLayout.ColScrollRegions.Add((object) colScrollRegion31);
    ((UltraGridBase) this.gridSearchResults).DisplayLayout.ColScrollRegions.Add((object) colScrollRegion32);
    ((AppearanceBase) appearance2).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance2).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance2).ForeColor = Color.Black;
    ((UltraGridBase) this.gridSearchResults).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance2;
    ((UltraGridBase) this.gridSearchResults).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridSearchResults).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridSearchResults).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance3).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridSearchResults).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance3;
    ((UltraGridBase) this.gridSearchResults).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance4).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.gridSearchResults).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance4;
    ((UltraGridBase) this.gridSearchResults).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance5).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridSearchResults).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance5;
    ((AppearanceBase) appearance6).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridSearchResults).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance6;
    ((UltraGridBase) this.gridSearchResults).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance7).BackColor = Color.Transparent;
    ((AppearanceBase) appearance7).ForeColor = Color.Black;
    ((UltraGridBase) this.gridSearchResults).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance7;
    ((UltraGridBase) this.gridSearchResults).DisplayLayout.Override.SelectTypeCell = (SelectType) 2;
    ((AppearanceBase) appearance8).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance8).BorderColor = Color.Silver;
    scrollBarLook.ButtonAppearance = (AppearanceBase) appearance8;
    ((AppearanceBase) appearance9).BackColor = Color.White;
    scrollBarLook.TrackAppearance = (AppearanceBase) appearance9;
    scrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.gridSearchResults).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.gridSearchResults).Location = new Point(36, 295);
    ((Control) this.gridSearchResults).Size = new Size(699, 335);
    ((Control) this.dateTimePolicyExpirationFrom).Location = new Point(125, 98);
    ((Control) this.dateTimePolicyExpirationFrom).Margin = new Padding(2);
    ((Control) this.dateTimePolicyEffectiveFrom).Location = new Point(125, 75);
    ((Control) this.dateTimePolicyEffectiveFrom).Margin = new Padding(2);
    ((Control) this.dateTimePolicyExpirationTo).Location = new Point(233, 98);
    ((Control) this.dateTimePolicyExpirationTo).Margin = new Padding(2);
    ((Control) this.dateTimePolicyEffectiveTo).Location = new Point(233, 75);
    ((Control) this.dateTimePolicyEffectiveTo).Margin = new Padding(2);
    this.labelPolicyEffective.Location = new Point(14, 75);
    this.labelPolicyExpiration.Location = new Point(14, 98);
    this.label22.Location = new Point(214, 102);
    this.label20.Location = new Point(214, 79);
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.Margin = new Padding(2);
    this.Name = nameof (Fortegra_ClaimSearch);
    this.Size = new Size(759, 643);
    this.dsClaimsSearch1.EndInit();
    ((ISupportInitialize) this.textPolicyNumber).EndInit();
    ((ISupportInitialize) this.textInsuredName).EndInit();
    ((ISupportInitialize) this.textControlNumber).EndInit();
    ((ISupportInitialize) this.comboLines).EndInit();
    ((ISupportInitialize) this.comboCompanyLocations).EndInit();
    ((ISupportInitialize) this.comboAdjusterName).EndInit();
    ((ISupportInitialize) this.comboClaimStatus).EndInit();
    ((ISupportInitialize) this.textClaimantLastName).EndInit();
    ((ISupportInitialize) this.textClaimantFirstName).EndInit();
    ((ISupportInitialize) this.textClaimantSsnFein).EndInit();
    ((ISupportInitialize) this.textClaimNumber).EndInit();
    ((ISupportInitialize) this.dateLossDateTo).EndInit();
    ((ISupportInitialize) this.dateLossDateFrom).EndInit();
    ((ISupportInitialize) this.dateTimeDateReportedTo).EndInit();
    ((ISupportInitialize) this.dateTimeDateReportedFrom).EndInit();
    ((ISupportInitialize) this.textCheckNumber).EndInit();
    ((ISupportInitialize) this.textClaimantCorporationName).EndInit();
    ((ISupportInitialize) this.ultraToolbarsManager1).EndInit();
    ((ISupportInitialize) this.linesBindingSource1).EndInit();
    ((ISupportInitialize) this.dsLinesBindingSource).EndInit();
    this.dsLines.EndInit();
    ((ISupportInitialize) this.linesBindingSource).EndInit();
    ((ISupportInitialize) this.companyLocationsBindingSource).EndInit();
    this.dsCompanyLocations.EndInit();
    ((ISupportInitialize) this.groupNewClaimSearch).EndInit();
    ((Control) this.groupNewClaimSearch).ResumeLayout(false);
    ((Control) this.groupNewClaimSearch).PerformLayout();
    ((ISupportInitialize) this.buttonSearch).EndInit();
    ((ISupportInitialize) this.buttonCancel).EndInit();
    ((ISupportInitialize) this.pictureCurtain).EndInit();
    ((ISupportInitialize) this.gridSearchResults).EndInit();
    ((ISupportInitialize) this.dateTimePolicyExpirationFrom).EndInit();
    ((ISupportInitialize) this.dateTimePolicyEffectiveFrom).EndInit();
    ((ISupportInitialize) this.dateTimePolicyExpirationTo).EndInit();
    ((ISupportInitialize) this.dateTimePolicyEffectiveTo).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }
}
