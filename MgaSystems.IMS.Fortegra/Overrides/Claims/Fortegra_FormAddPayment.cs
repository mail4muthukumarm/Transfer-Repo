// Decompiled with JetBrains decompiler
// Type: MgaSystems.Ims.Fortegra.Overrides.Claims.Fortegra_FormAddPayment
// Assembly: MgaSystems.Ims.Fortegra, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27007E94-85B4-4A1A-9444-255CCA5487B0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Fortegra.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinListView;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Claims;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

#nullable disable
namespace MgaSystems.Ims.Fortegra.Overrides.Claims;

[Override(typeof (FormAddPayment))]
public class Fortegra_FormAddPayment : FormAddPayment
{
  private IContainer components;
  protected MGASimpleComboBox cboChildLine;
  protected UltraLabel ultraLabel10;
  private MGASimpleComboBox cboPaymentType;
  private Label label11;

  internal Guid _childLineGuid { get; set; }

  public Fortegra_FormAddPayment() => this.InitializeComponent();

  public Fortegra_FormAddPayment(
    Claimant claimant,
    PaymentReserve currentReserve,
    bool isPaymentReturn)
    : base(claimant, currentReserve, isPaymentReturn)
  {
    this.InitializeComponent();
  }

  public Fortegra_FormAddPayment(
    Claimant claimant,
    PaymentReserve currentReserve,
    bool isPaymentReturn,
    Guid childLineGuid,
    FormClaimant ownerForm)
    : base(claimant, currentReserve, isPaymentReturn, ownerForm)
  {
    this.InitializeComponent();
    this._claimantForm = ownerForm;
    this._childLineGuid = childLineGuid;
  }

  public Fortegra_FormAddPayment(Claimant claimant)
    : base(claimant)
  {
    this.InitializeComponent();
  }

  private void Fortegra_FormAddReserve_Load(object sender, EventArgs e)
  {
    this.LoadChildLines();
    this.LoadPaymentTypes();
    this.dateTimeReserveDate.Value = (object) DateTime.Now;
  }

  protected override void CreateReservePayment()
  {
    this._reserve = (PaymentReserve) new Fortegra_ReservePayment(PaymentReserveType.Reserve, (int) this.comboReserveType.Value, ((Control) this.comboReserveType).Text, ((UltraDropDownBase) this.comboReserveSubType).SelectedRow == null ? new int?() : (int?) this.comboReserveSubType.Value, ((UltraDropDownBase) this.comboReserveSubType).SelectedRow == null ? string.Empty : ((Control) this.comboReserveSubType).Text, ((UltraDropDownBase) this.comboCoverageType).SelectedRow == null ? new int?() : (int?) this.comboCoverageType.Value, ((UltraDropDownBase) this.comboCoverageType).SelectedRow == null ? string.Empty : ((Control) this.comboCoverageType).Text, ((UltraDropDownBase) this.comboCoverageSubType).SelectedRow == null ? new int?() : (int?) this.comboCoverageSubType.Value, ((UltraDropDownBase) this.comboCoverageSubType).SelectedRow == null ? string.Empty : ((Control) this.comboCoverageSubType).Text, ((Control) this.textComments).Text, Decimal.Parse(((Control) this.textAmount).Text, NumberStyles.Any) * -1M, Guid.Empty, string.Empty, (bool) ((UltraDropDownBase) this.comboReserveType).SelectedRow.Cells["IsRecoveryType"].Value, false, new int?());
    this._reserve.IsPaymentReduction = true;
    this._reserve.DateCreated = this.dateTimeReserveDate.DateTime;
    this._payment = (PaymentReserve) new Fortegra_ReservePayment(PaymentReserveType.Payment, (int) this.comboReserveType.Value, ((Control) this.comboReserveType).Text, ((UltraDropDownBase) this.comboReserveSubType).SelectedRow == null ? new int?() : (int?) this.comboReserveSubType.Value, ((UltraDropDownBase) this.comboReserveSubType).SelectedRow == null ? string.Empty : ((Control) this.comboReserveSubType).Text, ((UltraDropDownBase) this.comboCoverageType).SelectedRow == null ? new int?() : (int?) this.comboCoverageType.Value, ((UltraDropDownBase) this.comboCoverageType).SelectedRow == null ? string.Empty : ((Control) this.comboCoverageType).Text, ((UltraDropDownBase) this.comboCoverageSubType).SelectedRow == null ? new int?() : (int?) this.comboCoverageSubType.Value, ((UltraDropDownBase) this.comboCoverageSubType).SelectedRow == null ? string.Empty : ((Control) this.comboCoverageSubType).Text, ((Control) this.textComments).Text, Decimal.Parse(((Control) this.textAmount).Text, NumberStyles.Any), this.PayeeGuid, this.PayeeName, (bool) ((UltraDropDownBase) this.comboReserveType).SelectedRow.Cells["IsRecoveryType"].Value, this._isPaymentReturn, this._isPaymentReturn ? this._currentReserve.ReservePaymentId : new int?());
    this._payment.IsPaymentReduction = false;
    this._payment.DateCreated = this.dateTimeReserveDate.DateTime;
    this._payment.IsPayeeClaimant = this._payeeType == FormSelectPayee.PayeeType.Claimant;
    this._payment.IsPayeeInsured = this._payeeType == FormSelectPayee.PayeeType.Insured;
    this._payment.PayeeAddress1 = this.PayeeAddress1;
    this._payment.PayeeAddress2 = this.PayeeAddress2;
    this._payment.PayeeCity = this.PayeeCity;
    this._payment.PayeeState = this.PayeeState;
    this._payment.PayeeZipCode = this.PayeeZipCode;
    this._payment.PayeeZipCodeExtension = this.PayeeZipCodeExtension;
    this._payment.PayeeIsInternational = this.PayeeIsInternational;
    this._payment.PayeeInternationalZipCode = this.PayeeInternationalZipCode;
    this._payment.PayeeISOCountryCode = this.PayeeISOCountryCode;
    this._payment.PayeeFEIN = this.PayeeFEIN;
    this._payment.PayeeSSN = this.PayeeSSN;
    this._payment.PayeeEmail = this.PayeeEmail;
    this._payment.PayeeIs1099 = this.PayeeIs1099;
    this._payment.IsRecovery = this._isRecovery;
    this._payment.RecoveryCheckNumber = ((Control) this.textRecoveryCheckNumber).Text;
    this._payment.IsPayeeDefenseAttorney = this._payeeType == FormSelectPayee.PayeeType.DefenseAttorney;
    this._payment.IsPayeeClaimantAttorney = this._payeeType == FormSelectPayee.PayeeType.ClaimantAttorney;
    this._payment.AdditionalPayees = ((Control) this.textMultiplePayees).Text;
    if (!string.IsNullOrEmpty(this.addressResolverOverride.Address1))
    {
      this._payment.OverridePayeeAddress.Address1 = this.addressResolverOverride.Address1;
      this._payment.OverridePayeeAddress.Address2 = this.addressResolverOverride.Address2;
      this._payment.OverridePayeeAddress.City = this.addressResolverOverride.City;
      this._payment.OverridePayeeAddress.State = this.addressResolverOverride.State;
      this._payment.OverridePayeeAddress.ZipCode = this.addressResolverOverride.ZipCode;
      this._payment.OverridePayeeAddress.ZipCodeExtension = this.addressResolverOverride.ZipCodeExtension;
      this._payment.OverridePayeeAddress.IsoCountryCode = this.addressResolverOverride.ISOCountryCode;
      this._payment.OverridePayeeAddress.ZipCode = this.addressResolverOverride.ZipCode;
    }
    this.AddPaymentDocuments(this._payment);
    if (((Control) this.cboChildLine).Text.Length <= 0)
      return;
    if (this._payment is Fortegra_ReservePayment payment)
    {
      payment.ChildLineGuid = Guid.Parse(this.cboChildLine.Value.ToString());
      payment.ChildLineDesc = ((Control) this.cboChildLine).Text;
    }
    if (!(this._reserve is Fortegra_ReservePayment reserve))
      return;
    reserve.ChildLineGuid = Guid.Parse(this.cboChildLine.Value.ToString());
    reserve.ChildLineDesc = ((Control) this.cboChildLine).Text;
  }

  private void LoadChildLines()
  {
    ((UltraGridBase) this.cboChildLine).DataSource = (object) DefaultDatabase.ExecuteDataSet("Fortegra_GetChildLines", new object[2]
    {
      (object) "@ControlNo",
      (object) this._currentClaimant.Owner.ControlNumber
    }).Tables[0];
    ((UltraDropDownBase) this.cboChildLine).DisplayMember = "LineName";
    ((UltraDropDownBase) this.cboChildLine).ValueMember = "LineGuid";
    this.cboChildLine.Value = (object) this._childLineGuid;
  }

  private void LoadPaymentTypes()
  {
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Fortegra_FormAddPayment));
    Appearance appearance1 = new Appearance();
    UltraGridLayout ultraGridLayout = new UltraGridLayout("Layout1");
    Appearance appearance2 = new Appearance();
    UltraGridBand ultraGridBand = new UltraGridBand("CoverageTypeDescriptions", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("CoverageTypeDescriptionId");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("CoverageTypeId");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("CoverageTypeDescription");
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    this.cboChildLine = new MGASimpleComboBox();
    this.ultraLabel10 = new UltraLabel();
    this.cboPaymentType = new MGASimpleComboBox();
    this.label11 = new Label();
    ((ISupportInitialize) this.textRecoveryCheckNumber).BeginInit();
    ((ISupportInitialize) this.textMultiplePayees).BeginInit();
    ((ISupportInitialize) this.textPayee).BeginInit();
    ((ISupportInitialize) this.buttonAddDocument).BeginInit();
    ((ISupportInitialize) this.mgaViewDocuments).BeginInit();
    ((ISupportInitialize) this.listBoxDocuments).BeginInit();
    ((ISupportInitialize) this.buttonSearchPayee).BeginInit();
    ((ISupportInitialize) this.comboCoverageType).BeginInit();
    ((ISupportInitialize) this.comboReserveType).BeginInit();
    ((ISupportInitialize) this.comboReserveSubType).BeginInit();
    ((ISupportInitialize) this.comboCoverageSubType).BeginInit();
    ((ISupportInitialize) this.textComments).BeginInit();
    ((ISupportInitialize) this.textAmount).BeginInit();
    ((ISupportInitialize) this.buttonSave).BeginInit();
    ((ISupportInitialize) this.buttonCancel).BeginInit();
    ((ISupportInitialize) this.coverageTypeDescriptionsBindingSource).BeginInit();
    ((ISupportInitialize) this.reserveTypesBindingSource).BeginInit();
    ((ISupportInitialize) this.dsReservePaymentTypes1BindingSource).BeginInit();
    ((ISupportInitialize) this.reserveSubTypesBindingSource).BeginInit();
    ((ISupportInitialize) this.coverageTypesBindingSource).BeginInit();
    ((ISupportInitialize) this.reserveTypesBindingSource1).BeginInit();
    this.dsReservePaymentTypes1.BeginInit();
    this.dsCoverageTypes1.BeginInit();
    ((ISupportInitialize) this.dateTimeReserveDate).BeginInit();
    ((ISupportInitialize) this.cboChildLine).BeginInit();
    ((ISupportInitialize) this.cboPaymentType).BeginInit();
    this.SuspendLayout();
    ((Control) this.ultraLabel8).Location = new Point(5, 308);
    ((Control) this.textRecoveryCheckNumber).Location = new Point(137, 301);
    ((Control) this.textPayee).Location = new Point(137, 7);
    ((Control) this.buttonAddDocument).Location = new Point(137, 329);
    ((Control) this.mgaViewDocuments).Location = new Point((int) byte.MaxValue, 329);
    this.listBoxDocuments.ItemSettings.AllowEdit = (DefaultableBoolean) 2;
    this.listBoxDocuments.ItemSettings.DefaultImage = (Image) componentResourceManager.GetObject("listBoxDocuments.ItemSettings.DefaultImage");
    ((AppearanceBase) appearance1).BackColor = Color.Orange;
    ((AppearanceBase) appearance1).ForeColor = Color.Black;
    this.listBoxDocuments.ItemSettings.SelectedAppearance = (AppearanceBase) appearance1;
    ((UltraListViewListSettingsBase) this.listBoxDocuments.ViewSettingsList).CheckBoxStyle = (CheckBoxStyle) 1;
    this.listBoxDocuments.ViewSettingsList.MultiColumn = false;
    ((Control) this.comboCoverageType).Location = new Point(137, 84);
    ((Control) this.ultraLabel4).Location = new Point(5, 114);
    ((Control) this.ultraLabel5).Location = new Point(5, 162);
    ((Control) this.ultraLabel6).Location = new Point(5, 278);
    ((Control) this.comboReserveType).Location = new Point(137, 32 /*0x20*/);
    ((Control) this.comboReserveSubType).Location = new Point(137, 58);
    ((Control) this.comboCoverageSubType).Location = new Point(137, 110);
    ((Control) this.textComments).Location = new Point(137, 162);
    ((Control) this.textAmount).Location = new Point(137, 276);
    ((Control) this.buttonSave).Location = new Point(651, 342);
    ((Control) this.buttonCancel).Location = new Point(744, 342);
    ((Control) this.lblDate).Location = new Point(6, 252);
    this.dateTimeReserveDate.DateTime = new DateTime(2023, 2, 6, 0, 0, 0, 0);
    ((Control) this.dateTimeReserveDate).Location = new Point(137, 251);
    this.dateTimeReserveDate.Value = (object) new DateTime(2023, 2, 6, 0, 0, 0, 0);
    this.cboChildLine.BorderStyle = (UIElementBorderStyle) 4;
    this.cboChildLine.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboChildLine).Enabled = false;
    ((AppearanceBase) appearance2).BackColor = Color.White;
    ((AppearanceBase) appearance2).BorderColor = Color.FromArgb(78, 122, 171);
    ultraGridLayout.Appearance = (AppearanceBase) appearance2;
    ultraGridLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand.ColHeadersVisible = false;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn1.Header).VisiblePosition = 0;
    ultraGridColumn1.Width = 107;
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn2.Header).VisiblePosition = 1;
    ultraGridColumn2.Width = 67;
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn3.Header).VisiblePosition = 2;
    ultraGridColumn3.Width = 100;
    ultraGridBand.Columns.AddRange(new object[3]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3
    });
    ultraGridLayout.BandsSerializer.Add((object) ultraGridBand);
    ultraGridLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((KeyedSubObjectBase) ultraGridLayout).Key = "Layout1";
    ultraGridLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    ((AppearanceBase) appearance3).BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    ((AppearanceBase) appearance3).BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    ultraGridLayout.Override.HotTrackRowAppearance = (AppearanceBase) appearance3;
    ((AppearanceBase) appearance4).BorderColor = Color.White;
    ultraGridLayout.Override.RowAppearance = (AppearanceBase) appearance4;
    ultraGridLayout.Override.RowSpacingAfter = 1;
    ((AppearanceBase) appearance5).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance5).BorderColor = Color.FromArgb((int) byte.MaxValue, 214, 88);
    ((AppearanceBase) appearance5).ForeColor = Color.Black;
    ultraGridLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance5;
    ((UltraGridBase) this.cboChildLine).Layouts.Add(ultraGridLayout);
    ((Control) this.cboChildLine).Location = new Point(137, 136);
    this.cboChildLine.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboChildLine).Name = "cboChildLine";
    ((Control) this.cboChildLine).Size = new Size(276, 21);
    ((Control) this.cboChildLine).TabIndex = 26;
    ((UltraControlBase) this.cboChildLine).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboChildLine).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance6).BackColor = Color.Transparent;
    ((ControlBase) this.ultraLabel10).Appearance = (AppearanceBase) appearance6;
    ((Control) this.ultraLabel10).AutoSize = true;
    ((Control) this.ultraLabel10).Location = new Point(6, 139);
    ((Control) this.ultraLabel10).Name = "ultraLabel10";
    ((Control) this.ultraLabel10).Size = new Size(65, 15);
    ((Control) this.ultraLabel10).TabIndex = 25;
    ((Control) this.ultraLabel10).Text = "Line (Child):";
    this.cboPaymentType.BorderStyle = (UIElementBorderStyle) 4;
    this.cboPaymentType.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboPaymentType).Location = new Point(137, 358);
    this.cboPaymentType.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboPaymentType).Name = "cboPaymentType";
    ((Control) this.cboPaymentType).Size = new Size(138, 21);
    ((Control) this.cboPaymentType).TabIndex = 28;
    ((UltraControlBase) this.cboPaymentType).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboPaymentType).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.cboPaymentType).Visible = false;
    this.label11.AutoSize = true;
    this.label11.BackColor = Color.Transparent;
    this.label11.Location = new Point(3, 358);
    this.label11.Name = "label11";
    this.label11.Size = new Size(80 /*0x50*/, 13);
    this.label11.TabIndex = 27;
    this.label11.Text = "Payment Type:";
    this.label11.Visible = false;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(838, 388);
    this.Controls.Add((Control) this.cboPaymentType);
    this.Controls.Add((Control) this.label11);
    this.Controls.Add((Control) this.ultraLabel10);
    this.Controls.Add((Control) this.cboChildLine);
    this.Name = nameof (Fortegra_FormAddPayment);
    this.Text = "Add Payment (Fortegra)";
    this.Load += new EventHandler(this.Fortegra_FormAddReserve_Load);
    this.Controls.SetChildIndex((Control) this.cboChildLine, 0);
    this.Controls.SetChildIndex((Control) this.dateTimeReserveDate, 0);
    this.Controls.SetChildIndex((Control) this.lblDate, 0);
    this.Controls.SetChildIndex((Control) this.comboReserveType, 0);
    this.Controls.SetChildIndex((Control) this.ultraLabel1, 0);
    this.Controls.SetChildIndex((Control) this.ultraLabel2, 0);
    this.Controls.SetChildIndex((Control) this.ultraLabel3, 0);
    this.Controls.SetChildIndex((Control) this.ultraLabel4, 0);
    this.Controls.SetChildIndex((Control) this.ultraLabel5, 0);
    this.Controls.SetChildIndex((Control) this.ultraLabel6, 0);
    this.Controls.SetChildIndex((Control) this.comboReserveSubType, 0);
    this.Controls.SetChildIndex((Control) this.comboCoverageType, 0);
    this.Controls.SetChildIndex((Control) this.comboCoverageSubType, 0);
    this.Controls.SetChildIndex((Control) this.textComments, 0);
    this.Controls.SetChildIndex((Control) this.textAmount, 0);
    this.Controls.SetChildIndex((Control) this.buttonSave, 0);
    this.Controls.SetChildIndex((Control) this.buttonCancel, 0);
    this.Controls.SetChildIndex((Control) this.textPayee, 0);
    this.Controls.SetChildIndex((Control) this.buttonSearchPayee, 0);
    this.Controls.SetChildIndex((Control) this.ultraLabel8, 0);
    this.Controls.SetChildIndex((Control) this.textRecoveryCheckNumber, 0);
    this.Controls.SetChildIndex((Control) this.addressResolverOverride, 0);
    this.Controls.SetChildIndex((Control) this.textMultiplePayees, 0);
    this.Controls.SetChildIndex((Control) this.buttonAddDocument, 0);
    this.Controls.SetChildIndex((Control) this.mgaViewDocuments, 0);
    this.Controls.SetChildIndex((Control) this.listBoxDocuments, 0);
    this.Controls.SetChildIndex((Control) this.ultraLabel10, 0);
    this.Controls.SetChildIndex((Control) this.label11, 0);
    this.Controls.SetChildIndex((Control) this.cboPaymentType, 0);
    ((ISupportInitialize) this.textRecoveryCheckNumber).EndInit();
    ((ISupportInitialize) this.textMultiplePayees).EndInit();
    ((ISupportInitialize) this.textPayee).EndInit();
    ((ISupportInitialize) this.buttonAddDocument).EndInit();
    ((ISupportInitialize) this.mgaViewDocuments).EndInit();
    ((ISupportInitialize) this.listBoxDocuments).EndInit();
    ((ISupportInitialize) this.buttonSearchPayee).EndInit();
    ((ISupportInitialize) this.comboCoverageType).EndInit();
    ((ISupportInitialize) this.comboReserveType).EndInit();
    ((ISupportInitialize) this.comboReserveSubType).EndInit();
    ((ISupportInitialize) this.comboCoverageSubType).EndInit();
    ((ISupportInitialize) this.textComments).EndInit();
    ((ISupportInitialize) this.textAmount).EndInit();
    ((ISupportInitialize) this.buttonSave).EndInit();
    ((ISupportInitialize) this.buttonCancel).EndInit();
    ((ISupportInitialize) this.coverageTypeDescriptionsBindingSource).EndInit();
    ((ISupportInitialize) this.reserveTypesBindingSource).EndInit();
    ((ISupportInitialize) this.dsReservePaymentTypes1BindingSource).EndInit();
    ((ISupportInitialize) this.reserveSubTypesBindingSource).EndInit();
    ((ISupportInitialize) this.coverageTypesBindingSource).EndInit();
    ((ISupportInitialize) this.reserveTypesBindingSource1).EndInit();
    this.dsReservePaymentTypes1.EndInit();
    this.dsCoverageTypes1.EndInit();
    ((ISupportInitialize) this.dateTimeReserveDate).EndInit();
    ((ISupportInitialize) this.cboChildLine).EndInit();
    ((ISupportInitialize) this.cboPaymentType).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }
}
