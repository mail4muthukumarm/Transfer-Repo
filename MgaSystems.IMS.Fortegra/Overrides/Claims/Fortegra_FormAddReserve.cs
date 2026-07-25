// Decompiled with JetBrains decompiler
// Type: MgaSystems.Ims.Fortegra.Overrides.Claims.Fortegra_FormAddReserve
// Assembly: MgaSystems.Ims.Fortegra, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27007E94-85B4-4A1A-9444-255CCA5487B0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Fortegra.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
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

[Override(typeof (FormAddReserve))]
public class Fortegra_FormAddReserve : FormAddReserve
{
  private IContainer components;
  protected MGASimpleComboBox cboChildLine;
  protected UltraLabel ultraLabel7;

  public Fortegra_FormAddReserve() => this.InitializeComponent();

  public Fortegra_FormAddReserve(Claimant claimant, FormClaimant owner)
    : base(claimant, owner)
  {
    this.InitializeComponent();
  }

  public Fortegra_FormAddReserve(Claimant claimant)
    : base(claimant)
  {
    this.InitializeComponent();
  }

  private void Fortegra_FormAddReserve_Load(object sender, EventArgs e)
  {
    ((UltraGridBase) this.cboChildLine).DataSource = (object) DefaultDatabase.ExecuteDataSet("Fortegra_GetChildLines", new object[2]
    {
      (object) "@ControlNo",
      (object) this._currentClaimant.Owner.ControlNumber
    }).Tables[0];
    ((UltraDropDownBase) this.cboChildLine).DisplayMember = "LineName";
    ((UltraDropDownBase) this.cboChildLine).ValueMember = "LineGuid";
    this.dateTimeReserveDate.Value = (object) DateTime.Now;
  }

  protected override void CreateReservePayment()
  {
    this._reserve = (PaymentReserve) new Fortegra_ReservePayment(PaymentReserveType.Reserve, (int) this.comboReserveType.Value, ((Control) this.comboReserveType).Text, ((UltraDropDownBase) this.comboReserveSubType).SelectedRow == null ? new int?() : (int?) this.comboReserveSubType.Value, ((UltraDropDownBase) this.comboReserveSubType).SelectedRow == null ? string.Empty : ((Control) this.comboReserveSubType).Text, ((UltraDropDownBase) this.comboCoverageType).SelectedRow == null ? new int?() : (int?) this.comboCoverageType.Value, ((UltraDropDownBase) this.comboCoverageType).SelectedRow == null ? string.Empty : ((Control) this.comboCoverageType).Text, ((UltraDropDownBase) this.comboCoverageSubType).SelectedRow == null ? new int?() : (int?) this.comboCoverageSubType.Value, ((UltraDropDownBase) this.comboCoverageSubType).SelectedRow == null ? string.Empty : ((Control) this.comboCoverageSubType).Text, ((Control) this.textComments).Text, Decimal.Parse(((Control) this.textAmount).Text, NumberStyles.Any), Guid.Empty, string.Empty, (bool) ((UltraDropDownBase) this.comboReserveType).SelectedRow.Cells["IsRecoveryType"].Value);
    this._reserve.IsPaymentReduction = false;
    this._reserve.DateCreated = this.dateTimeReserveDate.DateTime != this.dateTimeReserveDate.MinDate ? this.dateTimeReserveDate.DateTime : DateTime.Now;
    if (((Control) this.cboChildLine).Text.Length <= 0)
      return;
    (this._reserve as Fortegra_ReservePayment).ChildLineGuid = Guid.Parse(this.cboChildLine.Value.ToString());
    (this._reserve as Fortegra_ReservePayment).ChildLineDesc = ((Control) this.cboChildLine).Text;
  }

  protected override bool ValidateForm()
  {
    if (((DisposableObjectCollectionBase) ((UltraGridBase) this.cboChildLine).Rows).Count <= 0 || this.cboChildLine.Value != null)
      return base.ValidateForm();
    int num = (int) MessageBox.Show("You must specify a child line to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    return false;
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    UltraGridLayout ultraGridLayout = new UltraGridLayout("Layout1");
    Appearance appearance1 = new Appearance();
    UltraGridBand ultraGridBand = new UltraGridBand("CoverageTypeDescriptions", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("CoverageTypeDescriptionId");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("CoverageTypeId");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("CoverageTypeDescription");
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    this.cboChildLine = new MGASimpleComboBox();
    this.ultraLabel7 = new UltraLabel();
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
    this.SuspendLayout();
    ((Control) this.ultraLabel5).Location = new Point(5, 134);
    ((Control) this.ultraLabel6).Location = new Point(5, 254);
    ((Control) this.textComments).Location = new Point(139, 132);
    ((Control) this.textAmount).Location = new Point(139, 252);
    ((Control) this.buttonSave).Location = new Point(240 /*0xF0*/, 294);
    ((Control) this.buttonCancel).Location = new Point(333, 294);
    ((Control) this.lblDate).Location = new Point(5, 226);
    this.dateTimeReserveDate.DateTime = new DateTime(2023, 1, 13, 0, 0, 0, 0);
    ((Control) this.dateTimeReserveDate).Location = new Point(139, 229);
    this.dateTimeReserveDate.Value = (object) new DateTime(2023, 1, 13, 0, 0, 0, 0);
    this.cboChildLine.BorderStyle = (UIElementBorderStyle) 4;
    this.cboChildLine.DropDownStyle = (UltraComboStyle) 1;
    ((AppearanceBase) appearance1).BackColor = Color.White;
    ((AppearanceBase) appearance1).BorderColor = Color.FromArgb(78, 122, 171);
    ultraGridLayout.Appearance = (AppearanceBase) appearance1;
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
    ((AppearanceBase) appearance2).BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    ((AppearanceBase) appearance2).BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    ultraGridLayout.Override.HotTrackRowAppearance = (AppearanceBase) appearance2;
    ((AppearanceBase) appearance3).BorderColor = Color.White;
    ultraGridLayout.Override.RowAppearance = (AppearanceBase) appearance3;
    ultraGridLayout.Override.RowSpacingAfter = 1;
    ((AppearanceBase) appearance4).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance4).BorderColor = Color.FromArgb((int) byte.MaxValue, 214, 88);
    ((AppearanceBase) appearance4).ForeColor = Color.Black;
    ultraGridLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance4;
    ((UltraGridBase) this.cboChildLine).Layouts.Add(ultraGridLayout);
    ((Control) this.cboChildLine).Location = new Point(139, 108);
    this.cboChildLine.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboChildLine).Name = "cboChildLine";
    ((Control) this.cboChildLine).Size = new Size(276, 21);
    ((Control) this.cboChildLine).TabIndex = 17;
    ((UltraControlBase) this.cboChildLine).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboChildLine).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance5).BackColor = Color.Transparent;
    ((ControlBase) this.ultraLabel7).Appearance = (AppearanceBase) appearance5;
    ((Control) this.ultraLabel7).AutoSize = true;
    ((Control) this.ultraLabel7).Location = new Point(5, 108);
    ((Control) this.ultraLabel7).Name = "ultraLabel7";
    ((Control) this.ultraLabel7).Size = new Size(65, 15);
    ((Control) this.ultraLabel7).TabIndex = 16 /*0x10*/;
    ((Control) this.ultraLabel7).Text = "Line (Child):";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(425, 340);
    this.Controls.Add((Control) this.cboChildLine);
    this.Controls.Add((Control) this.ultraLabel7);
    this.Name = nameof (Fortegra_FormAddReserve);
    this.Text = "Add Reserve (Fortegra)";
    this.Load += new EventHandler(this.Fortegra_FormAddReserve_Load);
    this.Controls.SetChildIndex((Control) this.ultraLabel1, 0);
    this.Controls.SetChildIndex((Control) this.ultraLabel2, 0);
    this.Controls.SetChildIndex((Control) this.ultraLabel3, 0);
    this.Controls.SetChildIndex((Control) this.ultraLabel4, 0);
    this.Controls.SetChildIndex((Control) this.ultraLabel5, 0);
    this.Controls.SetChildIndex((Control) this.ultraLabel6, 0);
    this.Controls.SetChildIndex((Control) this.comboReserveType, 0);
    this.Controls.SetChildIndex((Control) this.comboReserveSubType, 0);
    this.Controls.SetChildIndex((Control) this.comboCoverageType, 0);
    this.Controls.SetChildIndex((Control) this.comboCoverageSubType, 0);
    this.Controls.SetChildIndex((Control) this.textComments, 0);
    this.Controls.SetChildIndex((Control) this.textAmount, 0);
    this.Controls.SetChildIndex((Control) this.buttonSave, 0);
    this.Controls.SetChildIndex((Control) this.buttonCancel, 0);
    this.Controls.SetChildIndex((Control) this.lblDate, 0);
    this.Controls.SetChildIndex((Control) this.dateTimeReserveDate, 0);
    this.Controls.SetChildIndex((Control) this.ultraLabel7, 0);
    this.Controls.SetChildIndex((Control) this.cboChildLine, 0);
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
    this.ResumeLayout(false);
    this.PerformLayout();
  }
}
