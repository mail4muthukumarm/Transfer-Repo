// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.Attorney_Management.AttorneyManagementView
// Assembly: MgaSystems.IMS.Claims, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FCD9D0B7-28CF-40B9-8EB7-297871E1AF5F
// Assembly location: F:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinMaskedEdit;
using MGASystems.Common;
using MGASystems.Common.MVC.BaseClasses.Model;
using MGASystems.Common.MVC.BaseClasses.View;
using MGASystems.IMS.Accounting.Services.Forms.MVC.Address.Controller;
using MGASystems.IMS.Accounting.Services.Forms.MVC.Address.Model;
using MGASystems.IMS.Accounting.Services.Forms.MVC.Address.View;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Claims.Attorney_Management;

[Override(typeof (IAttorneyManagementView))]
public class AttorneyManagementView : 
  MvcViewBase<IAttorneyManagementModel, IAttorneyManagementController>,
  IAttorneyManagementView,
  IMvcView,
  IModelObserver
{
  private IContainer components;
  private MGAMaskedEdit maskFax;
  private Label label1;
  private MGAMaskedEdit maskPhone;
  private Label label5;
  protected UltraOptionSet optionEntityType;
  protected MGAMaskedEdit maskFEINSSN;
  protected Label label53;
  protected UltraLabel lblAttorneyName;
  protected MGATextBox textAttorneyName;
  protected UltraLabel lblLawFirm;
  protected UltraOptionSet optionClaimantDefense;
  protected MGATextBox textLawFirm;
  private AddressView addressResolver;
  private Label label10;
  protected MGATextBox txtPayee_Email;

  public AttorneyManagementView() => this.InitializeComponent();

  private void ClaimsEntityView_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    this.ClearScreen();
    this.optionClaimantDefense.Value = (object) 0;
  }

  private void optionClaimantDefense_ValueChanged(object sender, EventArgs e)
  {
    this.InvokeIfNotSuppressed((Action) (() => this.SetAttorneyEntityType(((Control) this.optionClaimantDefense).Text)));
  }

  private void textLawFirmName_ValueChanged(object sender, EventArgs e)
  {
    this.InvokeIfNotSuppressed((Action) (() => this.SetLawFirm(((Control) this.textLawFirm).Text)));
  }

  private void textAttorneyName_ValueChanged(object sender, EventArgs e)
  {
    this.InvokeIfNotSuppressed((Action) (() => this.SetAttorneyName(((Control) this.textAttorneyName).Text)));
  }

  private void optionEntityType_ValueChanged(object sender, EventArgs e)
  {
    this.InvokeIfNotSuppressed((Action) (() => this.SetFEINSSNInputMask()));
  }

  private void maskFEINSSN_ValueChanged(object sender, EventArgs e)
  {
    this.InvokeIfNotSuppressed((Action) (() => this.SetFEINSSN(((Control) this.maskFEINSSN).Text)));
  }

  private void maskPhone_ValueChanged(object sender, EventArgs e)
  {
    this.InvokeIfNotSuppressed((Action) (() => this.SetPhoneNumber(((Control) this.maskPhone).Text)));
  }

  private void maskFax_ValueChanged(object sender, EventArgs e)
  {
    this.InvokeIfNotSuppressed((Action) (() => this.SetFaxNumber(((Control) this.maskFax).Text)));
  }

  private void SetFEINSSNInputMask()
  {
    object obj = ((UltraMaskedEdit) this.maskFEINSSN).Value;
    ((UltraMaskedEdit) this.maskFEINSSN).InputMask = "999-99-9999";
    if (((Control) this.optionEntityType).Text == "C")
      ((UltraMaskedEdit) this.maskFEINSSN).InputMask = "99-999999";
    ((UltraMaskedEdit) this.maskFEINSSN).Value = obj;
  }

  public void ClearScreen()
  {
    foreach (Control control in this.Controls.OfType<MGATextBox>())
      control.Text = string.Empty;
    foreach (UltraToggleEditorBase toggleEditorBase in this.Controls.OfType<MGACheckBox>())
      toggleEditorBase.Checked = false;
    foreach (Control control in this.Controls.OfType<MGAMaskedEdit>())
      control.Text = string.Empty;
    foreach (UltraDropDownBase ultraDropDownBase in this.Controls.OfType<MGASimpleComboBox>())
      ultraDropDownBase.SelectedRow = (UltraGridRow) null;
  }

  public void SetAttorneyGuid(Guid guid) => this.Controller.RequestSetAttorneyGuid(guid);

  public void SetAttorneyType(string text) => this.Controller.RequestSetAttorneyType(text);

  public void SetAttorneyName(string text) => this.Controller.RequestSetAttorneyName(text);

  public void SetLawFirm(string text) => this.Controller.RequestSetLawFirm(text);

  public void SetAttorneyEntityType(string text)
  {
    this.Controller.RequestSetAttorneyEntityType(text);
  }

  public void SetFEINSSN(string text) => this.Controller.RequestSetFEINSSN(text);

  public void SetPhoneNumber(string text) => this.Controller.RequestSetPhoneNumber(text);

  public void SetFaxNumber(string text) => this.Controller.RequestSetFaxNumber(text);

  protected override void ChildUpdateFromModel(IAttorneyManagementModel model)
  {
    ((MvcViewBase<IAddressModel, IAddressController>) this.addressResolver).WireUp((IAddressController) new AddressController(), this.Model.Address);
    ((IMvcModel) this.Model.Address).AddObserver((IModelObserver) this);
  }

  protected override void ChildUnWireUp() => this.ClearScreen();

  protected override void ChildSetFocus() => ((Control) this.optionClaimantDefense).Focus();

  public override void Update(object model)
  {
    if (!(model is IAttorneyManagementModel model1))
      return;
    this.Update(model1);
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
    ValueListItem valueListItem1 = new ValueListItem();
    ValueListItem valueListItem2 = new ValueListItem();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    ValueListItem valueListItem3 = new ValueListItem();
    ValueListItem valueListItem4 = new ValueListItem();
    ValueListItem valueListItem5 = new ValueListItem();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    this.maskFax = new MGAMaskedEdit();
    this.label1 = new Label();
    this.maskPhone = new MGAMaskedEdit();
    this.label5 = new Label();
    this.optionEntityType = new UltraOptionSet();
    this.maskFEINSSN = new MGAMaskedEdit();
    this.label53 = new Label();
    this.lblAttorneyName = new UltraLabel();
    this.textAttorneyName = new MGATextBox();
    this.lblLawFirm = new UltraLabel();
    this.optionClaimantDefense = new UltraOptionSet();
    this.textLawFirm = new MGATextBox();
    this.addressResolver = new AddressView();
    this.label10 = new Label();
    this.txtPayee_Email = new MGATextBox();
    ((ISupportInitialize) this.maskFax).BeginInit();
    ((ISupportInitialize) this.maskPhone).BeginInit();
    ((ISupportInitialize) this.optionEntityType).BeginInit();
    ((ISupportInitialize) this.maskFEINSSN).BeginInit();
    ((ISupportInitialize) this.textAttorneyName).BeginInit();
    ((ISupportInitialize) this.optionClaimantDefense).BeginInit();
    ((ISupportInitialize) this.textLawFirm).BeginInit();
    ((ISupportInitialize) this.txtPayee_Email).BeginInit();
    this.SuspendLayout();
    ((AppearanceBase) appearance1).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraMaskedEdit) this.maskFax).Appearance = (AppearanceBase) appearance1;
    ((UltraMaskedEdit) this.maskFax).DataMode = (MaskMode) 3;
    ((UltraMaskedEdit) this.maskFax).EditAs = (EditAsType) 1;
    ((UltraMaskedEdit) this.maskFax).InputMask = "(###) ###-####";
    ((Control) this.maskFax).Location = new Point(100, 266);
    this.maskFax.MGAStyle = (MGAStyles) 2;
    ((Control) this.maskFax).Name = "maskFax";
    ((UltraMaskedEdit) this.maskFax).NonAutoSizeHeight = 20;
    ((Control) this.maskFax).Size = new Size(89, 20);
    ((Control) this.maskFax).TabIndex = 80 /*0x50*/;
    ((Control) this.maskFax).Text = "(___) ___-____";
    ((UltraControlBase) this.maskFax).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.maskFax).UseOsThemes = (DefaultableBoolean) 2;
    this.label1.AutoSize = true;
    this.label1.BackColor = Color.Transparent;
    this.label1.Location = new Point(14, 270);
    this.label1.Name = "label1";
    this.label1.Size = new Size(27, 13);
    this.label1.TabIndex = 79;
    this.label1.Text = "Fax:";
    ((AppearanceBase) appearance2).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraMaskedEdit) this.maskPhone).Appearance = (AppearanceBase) appearance2;
    ((UltraMaskedEdit) this.maskPhone).DataMode = (MaskMode) 3;
    ((UltraMaskedEdit) this.maskPhone).EditAs = (EditAsType) 1;
    ((UltraMaskedEdit) this.maskPhone).InputMask = "(###) ###-####";
    ((Control) this.maskPhone).Location = new Point(100, 241);
    this.maskPhone.MGAStyle = (MGAStyles) 2;
    ((Control) this.maskPhone).Name = "maskPhone";
    ((UltraMaskedEdit) this.maskPhone).NonAutoSizeHeight = 20;
    ((Control) this.maskPhone).Size = new Size(89, 20);
    ((Control) this.maskPhone).TabIndex = 78;
    ((Control) this.maskPhone).Text = "(___) ___-____";
    ((UltraControlBase) this.maskPhone).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.maskPhone).UseOsThemes = (DefaultableBoolean) 2;
    this.label5.AutoSize = true;
    this.label5.BackColor = Color.Transparent;
    this.label5.Location = new Point(14, 245);
    this.label5.Name = "label5";
    this.label5.Size = new Size(41, 13);
    this.label5.TabIndex = 77;
    this.label5.Text = "Phone:";
    ((Control) this.optionEntityType).BackColor = Color.Transparent;
    this.optionEntityType.BackColorInternal = Color.Transparent;
    this.optionEntityType.BorderStyle = (UIElementBorderStyle) 1;
    this.optionEntityType.GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007RadioButtonGlyphInfo;
    valueListItem1.DataValue = (object) "I";
    valueListItem1.DisplayText = "Individual";
    valueListItem2.DataValue = (object) "C";
    valueListItem2.DisplayText = "Corporation";
    this.optionEntityType.Items.AddRange(new ValueListItem[2]
    {
      valueListItem1,
      valueListItem2
    });
    ((Control) this.optionEntityType).Location = new Point(187, 76);
    ((Control) this.optionEntityType).Name = "optionEntityType";
    ((Control) this.optionEntityType).Size = new Size(166, 18);
    ((Control) this.optionEntityType).TabIndex = 68;
    ((UltraControlBase) this.optionEntityType).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.optionEntityType).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance3).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraMaskedEdit) this.maskFEINSSN).Appearance = (AppearanceBase) appearance3;
    ((UltraMaskedEdit) this.maskFEINSSN).ClipMode = (MaskMode) 0;
    ((UltraMaskedEdit) this.maskFEINSSN).DataMode = (MaskMode) 0;
    ((UltraMaskedEdit) this.maskFEINSSN).EditAs = (EditAsType) 1;
    ((UltraMaskedEdit) this.maskFEINSSN).InputMask = "99-9999999";
    ((Control) this.maskFEINSSN).Location = new Point(100, 72);
    this.maskFEINSSN.MGAStyle = (MGAStyles) 2;
    ((Control) this.maskFEINSSN).Name = "maskFEINSSN";
    ((UltraMaskedEdit) this.maskFEINSSN).NonAutoSizeHeight = 20;
    ((Control) this.maskFEINSSN).Size = new Size(76, 20);
    ((Control) this.maskFEINSSN).TabIndex = 74;
    ((UltraControlBase) this.maskFEINSSN).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.maskFEINSSN).UseOsThemes = (DefaultableBoolean) 2;
    this.label53.AutoSize = true;
    this.label53.BackColor = Color.Transparent;
    this.label53.ForeColor = Color.Black;
    this.label53.Location = new Point(14, 75);
    this.label53.Name = "label53";
    this.label53.Size = new Size(61, 13);
    this.label53.TabIndex = 73;
    this.label53.Text = "FEIN/SSN:";
    ((AppearanceBase) appearance4).BackColor = Color.Transparent;
    ((ControlBase) this.lblAttorneyName).Appearance = (AppearanceBase) appearance4;
    ((Control) this.lblAttorneyName).AutoSize = true;
    ((Control) this.lblAttorneyName).Location = new Point(14, 51);
    ((Control) this.lblAttorneyName).Name = "lblAttorneyName";
    ((Control) this.lblAttorneyName).Size = new Size(83, 14);
    ((Control) this.lblAttorneyName).TabIndex = 71;
    ((Control) this.lblAttorneyName).Text = "Attorney Name:";
    ((AppearanceBase) appearance5).BackColor = Color.White;
    ((AppearanceBase) appearance5).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance5).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textAttorneyName).Appearance = (AppearanceBase) appearance5;
    ((Control) this.textAttorneyName).BackColor = Color.White;
    ((Control) this.textAttorneyName).Location = new Point(100, 48 /*0x30*/);
    this.textAttorneyName.MGAStyle = (MGAStyles) 2;
    ((Control) this.textAttorneyName).Name = "textAttorneyName";
    ((Control) this.textAttorneyName).Size = new Size(252, 19);
    ((Control) this.textAttorneyName).TabIndex = 72;
    ((UltraControlBase) this.textAttorneyName).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textAttorneyName).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance6).BackColor = Color.Transparent;
    ((ControlBase) this.lblLawFirm).Appearance = (AppearanceBase) appearance6;
    ((Control) this.lblLawFirm).AutoSize = true;
    ((Control) this.lblLawFirm).Location = new Point(13, 27);
    ((Control) this.lblLawFirm).Name = "lblLawFirm";
    ((Control) this.lblLawFirm).Size = new Size(87, 14);
    ((Control) this.lblLawFirm).TabIndex = 69;
    ((Control) this.lblLawFirm).Text = "Law Firm Name:";
    ((Control) this.optionClaimantDefense).BackColor = Color.Transparent;
    this.optionClaimantDefense.BackColorInternal = Color.Transparent;
    this.optionClaimantDefense.BorderStyle = (UIElementBorderStyle) 1;
    this.optionClaimantDefense.GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007RadioButtonGlyphInfo;
    valueListItem3.DataValue = (object) "Defense";
    valueListItem3.DisplayText = "Defense Attorney";
    valueListItem4.DataValue = (object) "Claimant";
    valueListItem4.DisplayText = "Claimant Attorney";
    valueListItem5.DataValue = (object) "Contractor";
    this.optionClaimantDefense.Items.AddRange(new ValueListItem[3]
    {
      valueListItem3,
      valueListItem4,
      valueListItem5
    });
    ((Control) this.optionClaimantDefense).Location = new Point(100, 3);
    ((Control) this.optionClaimantDefense).Name = "optionClaimantDefense";
    ((Control) this.optionClaimantDefense).Size = new Size(307, 19);
    ((Control) this.optionClaimantDefense).TabIndex = 76;
    ((UltraControlBase) this.optionClaimantDefense).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.optionClaimantDefense).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance7).BackColor = Color.White;
    ((AppearanceBase) appearance7).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance7).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textLawFirm).Appearance = (AppearanceBase) appearance7;
    ((Control) this.textLawFirm).BackColor = Color.White;
    ((Control) this.textLawFirm).Location = new Point(100, 25);
    this.textLawFirm.MGAStyle = (MGAStyles) 2;
    ((Control) this.textLawFirm).Name = "textLawFirm";
    ((Control) this.textLawFirm).Size = new Size(252, 19);
    ((Control) this.textLawFirm).TabIndex = 70;
    ((UltraControlBase) this.textLawFirm).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textLawFirm).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.addressResolver).BackColor = Color.Transparent;
    ((Control) this.addressResolver).Location = new Point(5, 89);
    ((Control) this.addressResolver).Margin = new Padding(3, 0, 3, 0);
    ((Control) this.addressResolver).Name = "addressResolver";
    ((Control) this.addressResolver).Size = new Size(293, 153);
    ((Control) this.addressResolver).TabIndex = 135;
    this.label10.AutoSize = true;
    this.label10.BackColor = Color.Transparent;
    this.label10.ForeColor = Color.Black;
    this.label10.Location = new Point(14, 293);
    this.label10.Margin = new Padding(4, 0, 4, 0);
    this.label10.Name = "label10";
    this.label10.Size = new Size(76, 13);
    this.label10.TabIndex = 136;
    this.label10.Text = "Email Address:";
    ((AppearanceBase) appearance8).BackColor = Color.White;
    ((AppearanceBase) appearance8).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance8).ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtPayee_Email).Appearance = (AppearanceBase) appearance8;
    ((Control) this.txtPayee_Email).BackColor = Color.White;
    ((Control) this.txtPayee_Email).Location = new Point(100, 291);
    ((Control) this.txtPayee_Email).Margin = new Padding(4);
    this.txtPayee_Email.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtPayee_Email).Name = "txtPayee_Email";
    ((Control) this.txtPayee_Email).Size = new Size(219, 19);
    ((Control) this.txtPayee_Email).TabIndex = 137;
    ((Control) this.txtPayee_Email).Tag = (object) "";
    ((UltraControlBase) this.txtPayee_Email).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtPayee_Email).UseOsThemes = (DefaultableBoolean) 2;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = SystemColors.Control;
    this.Controls.Add((Control) this.label10);
    this.Controls.Add((Control) this.txtPayee_Email);
    this.Controls.Add((Control) this.maskFax);
    this.Controls.Add((Control) this.label1);
    this.Controls.Add((Control) this.maskPhone);
    this.Controls.Add((Control) this.label5);
    this.Controls.Add((Control) this.optionEntityType);
    this.Controls.Add((Control) this.maskFEINSSN);
    this.Controls.Add((Control) this.label53);
    this.Controls.Add((Control) this.lblAttorneyName);
    this.Controls.Add((Control) this.textAttorneyName);
    this.Controls.Add((Control) this.lblLawFirm);
    this.Controls.Add((Control) this.optionClaimantDefense);
    this.Controls.Add((Control) this.textLawFirm);
    this.Controls.Add((Control) this.addressResolver);
    this.Name = nameof (AttorneyManagementView);
    this.Size = new Size(406, 324);
    ((ISupportInitialize) this.maskFax).EndInit();
    ((ISupportInitialize) this.maskPhone).EndInit();
    ((ISupportInitialize) this.optionEntityType).EndInit();
    ((ISupportInitialize) this.maskFEINSSN).EndInit();
    ((ISupportInitialize) this.textAttorneyName).EndInit();
    ((ISupportInitialize) this.optionClaimantDefense).EndInit();
    ((ISupportInitialize) this.textLawFirm).EndInit();
    ((ISupportInitialize) this.txtPayee_Email).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }
}
