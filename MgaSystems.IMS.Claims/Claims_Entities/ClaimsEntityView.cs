// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.Claims_Entities.ClaimsEntityView
// Assembly: MgaSystems.IMS.Claims, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FCD9D0B7-28CF-40B9-8EB7-297871E1AF5F
// Assembly location: F:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinMaskedEdit;
using MGASystems.Common;
using MGASystems.Common.MVC.BaseClasses.Model;
using MGASystems.Common.MVC.BaseClasses.View;
using MGASystems.Data;
using MGASystems.IMS.Accounting.Services.Forms.MVC.Address.Controller;
using MGASystems.IMS.Accounting.Services.Forms.MVC.Address.Model;
using MGASystems.IMS.Accounting.Services.Forms.MVC.Address.View;
using MGASystems.IMS.Claims.Claims_Entities.MVC.Controller;
using MGASystems.IMS.Claims.Claims_Entities.MVC.Model;
using MGASystems.IMS.Claims.Claims_Entities.MVC.View;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Claims.Claims_Entities;

[Override(typeof (IClaimsEntityView))]
public class ClaimsEntityView : 
  MvcViewBase<IClaimsEntityModel, IClaimsEntityController>,
  IClaimsEntityView,
  IMvcView,
  IModelObserver
{
  private IContainer components;
  protected MGATextBox txtContactName;
  protected Label label3;
  protected MGATextBox txtDBA;
  protected Label label9;
  public MGATextBox txtLastName;
  public MGATextBox txtMiddleName;
  public MGATextBox txtFirstName;
  protected Label label10;
  protected Label label12;
  protected Label label14;
  protected MGASimpleComboBox cboEntityType;
  protected Label label8;
  protected MGAMaskedEdit maskFax;
  protected Label label4;
  public MGATextBox txtEntityName;
  protected MGAMaskedEdit maskPhone;
  protected Label label2;
  protected MGAMaskedEdit maskFEINSSN;
  protected Label label11;
  protected Label label1;
  private AddressView addrClaimEntity;

  public ClaimsEntityView()
  {
    this.InitializeComponent();
    this.ClearScreen();
    this.cboEntityType.SelectedIndex = 0;
  }

  private void ClaimsEntityView_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    this.LoadEntityTypes();
  }

  private void cboEntityType_ValueChanged(object sender, EventArgs e)
  {
    this.InvokeIfNotSuppressed((Action) (() =>
    {
      this.SetEntityType(Utility.IsNull<int>(((UltraCombo) this.cboEntityType).Value, 0), ((Control) this.cboEntityType).Text);
      this.SetFEINSSNInputMask();
    }));
  }

  private void txtEntityName_ValueChanged(object sender, EventArgs e)
  {
    this.InvokeIfNotSuppressed((Action) (() => this.SetEntityName(((Control) this.txtEntityName).Text)));
  }

  private void txtDBA_ValueChanged(object sender, EventArgs e)
  {
    this.InvokeIfNotSuppressed((Action) (() => this.SetDBA(((Control) this.txtDBA).Text)));
  }

  private void txtFirstName_ValueChanged(object sender, EventArgs e)
  {
    this.InvokeIfNotSuppressed((Action) (() => this.SetFirstName(((Control) this.txtFirstName).Text)));
  }

  private void txtMiddleName_ValueChanged(object sender, EventArgs e)
  {
    this.InvokeIfNotSuppressed((Action) (() => this.SetMiddleName(((Control) this.txtMiddleName).Text)));
  }

  private void txtLastName_ValueChanged(object sender, EventArgs e)
  {
    this.InvokeIfNotSuppressed((Action) (() => this.SetLastName(((Control) this.txtLastName).Text)));
  }

  private void maskPhone_ValueChanged(object sender, EventArgs e)
  {
    this.InvokeIfNotSuppressed((Action) (() => this.SetPhoneNumber(((Control) this.maskPhone).Text)));
  }

  private void maskFax_ValueChanged(object sender, EventArgs e)
  {
    this.InvokeIfNotSuppressed((Action) (() => this.SetFaxNumber(((Control) this.maskFax).Text)));
  }

  private void maskFEINSSN_ValueChanged(object sender, EventArgs e)
  {
    this.InvokeIfNotSuppressed((Action) (() => this.SetFEINSSN(((Control) this.maskFEINSSN).Text)));
  }

  private void textContactName_ValueChanged(object sender, EventArgs e)
  {
    this.InvokeIfNotSuppressed((Action) (() => this.SetContactName(((Control) this.txtContactName).Text)));
  }

  private void LoadEntityTypes()
  {
    ((UltraGridBase) this.cboEntityType).DataSource = (object) DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT CAST(BusinessTypeId as int) as BusinessTypeId, BusinessType, Individual FROM lstBusinessTypes ORDER BY BusinessType ASC");
    ((UltraDropDownBase) this.cboEntityType).DisplayMember = "BusinessType";
    ((UltraDropDownBase) this.cboEntityType).ValueMember = "BusinessTypeId";
  }

  protected virtual void SetFEINSSNInputMask()
  {
    object obj = ((UltraMaskedEdit) this.maskFEINSSN).Value;
    ((UltraMaskedEdit) this.maskFEINSSN).InputMask = "999-99-9999";
    if (((Control) this.cboEntityType).Text.ToLower().Contains("individual"))
    {
      ((Control) this.txtEntityName).Enabled = false;
      ((Control) this.txtFirstName).Enabled = true;
      ((Control) this.txtMiddleName).Enabled = true;
      ((Control) this.txtLastName).Enabled = true;
    }
    else if (((Control) this.cboEntityType).Text.Length > 0)
    {
      ((UltraMaskedEdit) this.maskFEINSSN).InputMask = "99-999999";
      ((Control) this.txtEntityName).Enabled = true;
      ((Control) this.txtFirstName).Enabled = false;
      ((Control) this.txtMiddleName).Enabled = false;
      ((Control) this.txtLastName).Enabled = false;
    }
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
    this.SetFEINSSNInputMask();
  }

  public void SetEntityType(int id, string text) => this.Controller.RequestSetEntityType(id, text);

  public void SetEntityName(string text) => this.Controller.RequestSetEntityName(text);

  public void SetDBA(string text) => this.Controller.RequestSetDBA(text);

  public void SetFirstName(string text) => this.Controller.RequestSetFirstName(text);

  public void SetMiddleName(string text) => this.Controller.RequestSetMiddleName(text);

  public void SetLastName(string text) => this.Controller.RequestSetLastName(text);

  public void SetFEINSSN(string text) => this.Controller.RequestSetFEINSSN(text);

  public void SetContactName(string text) => this.Controller.RequestSetContactName(text);

  public void SetPhoneNumber(string text) => this.Controller.RequestSetPhoneNumber(text);

  public void SetFaxNumber(string text) => this.Controller.RequestSetFaxNumber(text);

  protected override void ChildWireUp()
  {
    ((MvcViewBase<IAddressModel, IAddressController>) this.addrClaimEntity).WireUp((IAddressController) new AddressController(), this.Model.Address);
    ((IMvcModel) this.Model.Address).AddObserver((IModelObserver) this);
  }

  protected override void ChildUpdateFromModel(IClaimsEntityModel model)
  {
    ((UltraCombo) this.cboEntityType).Value = (object) model.EntityTypeId;
    ((Control) this.txtEntityName).Text = model.EntityName;
    ((Control) this.txtDBA).Text = model.DBA;
    ((Control) this.txtFirstName).Text = model.FirstName;
    ((Control) this.txtMiddleName).Text = model.MiddleName;
    ((Control) this.txtLastName).Text = model.LastName;
    ((MvcViewBase<IAddressModel, IAddressController>) this.addrClaimEntity).Update(model.Address);
    ((UltraMaskedEdit) this.maskFEINSSN).Value = (object) model.FEINSSN;
    ((Control) this.txtContactName).Text = model.ContactName;
    ((UltraMaskedEdit) this.maskPhone).Value = (object) model.PhoneNumber;
    ((UltraMaskedEdit) this.maskFax).Value = (object) model.FaxNumber;
    this.SetFEINSSNInputMask();
  }

  protected override void ChildUnWireUp()
  {
    ((MvcViewBase<IAddressModel, IAddressController>) this.addrClaimEntity).UnWireUp();
    this.ClearScreen();
  }

  protected override void ChildSetFocus() => ((UltraCombo) this.cboEntityType).Focus();

  public override void Update(object model)
  {
    if (!(model is IClaimsEntityModel model1))
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
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    this.txtContactName = new MGATextBox();
    this.label3 = new Label();
    this.txtDBA = new MGATextBox();
    this.label9 = new Label();
    this.txtLastName = new MGATextBox();
    this.txtMiddleName = new MGATextBox();
    this.txtFirstName = new MGATextBox();
    this.label10 = new Label();
    this.label12 = new Label();
    this.label14 = new Label();
    this.cboEntityType = new MGASimpleComboBox();
    this.label8 = new Label();
    this.maskFax = new MGAMaskedEdit();
    this.label4 = new Label();
    this.txtEntityName = new MGATextBox();
    this.maskPhone = new MGAMaskedEdit();
    this.label2 = new Label();
    this.maskFEINSSN = new MGAMaskedEdit();
    this.label11 = new Label();
    this.label1 = new Label();
    this.addrClaimEntity = new AddressView();
    ((ISupportInitialize) this.txtContactName).BeginInit();
    ((ISupportInitialize) this.txtDBA).BeginInit();
    ((ISupportInitialize) this.txtLastName).BeginInit();
    ((ISupportInitialize) this.txtMiddleName).BeginInit();
    ((ISupportInitialize) this.txtFirstName).BeginInit();
    ((ISupportInitialize) this.cboEntityType).BeginInit();
    ((ISupportInitialize) this.maskFax).BeginInit();
    ((ISupportInitialize) this.txtEntityName).BeginInit();
    ((ISupportInitialize) this.maskPhone).BeginInit();
    ((ISupportInitialize) this.maskFEINSSN).BeginInit();
    this.SuspendLayout();
    ((AppearanceBase) appearance1).BackColor = Color.White;
    ((AppearanceBase) appearance1).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance1).ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtContactName).Appearance = (AppearanceBase) appearance1;
    ((Control) this.txtContactName).BackColor = Color.White;
    ((Control) this.txtContactName).Location = new Point(94, 347);
    this.txtContactName.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtContactName).Name = "txtContactName";
    ((Control) this.txtContactName).Size = new Size(260, 19);
    ((Control) this.txtContactName).TabIndex = 137;
    ((UltraControlBase) this.txtContactName).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtContactName).UseOsThemes = (DefaultableBoolean) 2;
    ((TextEditorControlBase) this.txtContactName).ValueChanged += new EventHandler(this.textContactName_ValueChanged);
    this.label3.AutoSize = true;
    this.label3.BackColor = Color.Transparent;
    this.label3.Location = new Point(6, 347);
    this.label3.Name = "label3";
    this.label3.Size = new Size(78, 13);
    this.label3.TabIndex = 128 /*0x80*/;
    this.label3.Text = "Contact Name:";
    ((AppearanceBase) appearance2).BackColor = Color.White;
    ((AppearanceBase) appearance2).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance2).ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtDBA).Appearance = (AppearanceBase) appearance2;
    ((Control) this.txtDBA).BackColor = Color.White;
    ((Control) this.txtDBA).Location = new Point(94, 55);
    this.txtDBA.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtDBA).Name = "txtDBA";
    ((Control) this.txtDBA).Size = new Size(260, 19);
    ((Control) this.txtDBA).TabIndex = 113;
    ((UltraControlBase) this.txtDBA).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtDBA).UseOsThemes = (DefaultableBoolean) 2;
    ((TextEditorControlBase) this.txtDBA).ValueChanged += new EventHandler(this.txtDBA_ValueChanged);
    this.label9.AutoSize = true;
    this.label9.BackColor = Color.Transparent;
    this.label9.Location = new Point(7, 55);
    this.label9.Name = "label9";
    this.label9.Size = new Size(32 /*0x20*/, 13);
    this.label9.TabIndex = 112 /*0x70*/;
    this.label9.Text = "DBA:";
    ((AppearanceBase) appearance3).BackColor = Color.White;
    ((AppearanceBase) appearance3).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance3).ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtLastName).Appearance = (AppearanceBase) appearance3;
    ((Control) this.txtLastName).BackColor = Color.White;
    ((Control) this.txtLastName).Location = new Point(94, 129);
    this.txtLastName.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtLastName).Name = "txtLastName";
    ((Control) this.txtLastName).Size = new Size(260, 19);
    ((Control) this.txtLastName).TabIndex = 119;
    ((UltraControlBase) this.txtLastName).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtLastName).UseOsThemes = (DefaultableBoolean) 2;
    ((TextEditorControlBase) this.txtLastName).ValueChanged += new EventHandler(this.txtLastName_ValueChanged);
    ((AppearanceBase) appearance4).BackColor = Color.White;
    ((AppearanceBase) appearance4).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance4).ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtMiddleName).Appearance = (AppearanceBase) appearance4;
    ((Control) this.txtMiddleName).BackColor = Color.White;
    ((Control) this.txtMiddleName).Location = new Point(94, 105);
    this.txtMiddleName.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtMiddleName).Name = "txtMiddleName";
    ((Control) this.txtMiddleName).Size = new Size(260, 19);
    ((Control) this.txtMiddleName).TabIndex = 117;
    ((UltraControlBase) this.txtMiddleName).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtMiddleName).UseOsThemes = (DefaultableBoolean) 2;
    ((TextEditorControlBase) this.txtMiddleName).ValueChanged += new EventHandler(this.txtMiddleName_ValueChanged);
    ((AppearanceBase) appearance5).BackColor = Color.White;
    ((AppearanceBase) appearance5).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance5).ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtFirstName).Appearance = (AppearanceBase) appearance5;
    ((Control) this.txtFirstName).BackColor = Color.White;
    ((Control) this.txtFirstName).Location = new Point(94, 80 /*0x50*/);
    this.txtFirstName.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtFirstName).Name = "txtFirstName";
    ((Control) this.txtFirstName).Size = new Size(260, 19);
    ((Control) this.txtFirstName).TabIndex = 115;
    ((UltraControlBase) this.txtFirstName).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtFirstName).UseOsThemes = (DefaultableBoolean) 2;
    ((TextEditorControlBase) this.txtFirstName).ValueChanged += new EventHandler(this.txtFirstName_ValueChanged);
    this.label10.AutoSize = true;
    this.label10.BackColor = Color.Transparent;
    this.label10.Location = new Point(7, 105);
    this.label10.Name = "label10";
    this.label10.Size = new Size(72, 13);
    this.label10.TabIndex = 116;
    this.label10.Text = "Middle Name:";
    this.label12.AutoSize = true;
    this.label12.BackColor = Color.Transparent;
    this.label12.Location = new Point(7, 130);
    this.label12.Name = "label12";
    this.label12.Size = new Size(61, 13);
    this.label12.TabIndex = 118;
    this.label12.Text = "Last Name:";
    this.label14.AutoSize = true;
    this.label14.BackColor = Color.Transparent;
    this.label14.Location = new Point(7, 79);
    this.label14.Name = "label14";
    this.label14.Size = new Size(60, 13);
    this.label14.TabIndex = 114;
    this.label14.Text = "First Name:";
    ((UltraCombo) this.cboEntityType).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraCombo) this.cboEntityType).DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboEntityType).Location = new Point(94, 6);
    this.cboEntityType.MGAStyle = (MGAStyles) 2;
    ((Control) this.cboEntityType).Name = "cboEntityType";
    ((Control) this.cboEntityType).Size = new Size(232, 20);
    ((Control) this.cboEntityType).TabIndex = 109;
    ((UltraControlBase) this.cboEntityType).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboEntityType).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraCombo) this.cboEntityType).ValueChanged += new EventHandler(this.cboEntityType_ValueChanged);
    this.label8.AutoSize = true;
    this.label8.BackColor = Color.Transparent;
    this.label8.Location = new Point(7, 6);
    this.label8.Name = "label8";
    this.label8.Size = new Size(63 /*0x3F*/, 13);
    this.label8.TabIndex = 108;
    this.label8.Text = "Entity Type:";
    ((AppearanceBase) appearance6).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraMaskedEdit) this.maskFax).Appearance = (AppearanceBase) appearance6;
    ((UltraMaskedEdit) this.maskFax).DataMode = (MaskMode) 0;
    ((UltraMaskedEdit) this.maskFax).EditAs = (EditAsType) 1;
    ((UltraMaskedEdit) this.maskFax).InputMask = "(###) ###-####";
    ((Control) this.maskFax).Location = new Point(94, 322);
    this.maskFax.MGAStyle = (MGAStyles) 2;
    ((Control) this.maskFax).Name = "maskFax";
    ((UltraMaskedEdit) this.maskFax).NonAutoSizeHeight = 20;
    ((Control) this.maskFax).Size = new Size(89, 20);
    ((Control) this.maskFax).TabIndex = 136;
    ((Control) this.maskFax).Text = "(___) ___-____";
    ((UltraControlBase) this.maskFax).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.maskFax).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraMaskedEdit) this.maskFax).ValueChanged += new EventHandler(this.maskFax_ValueChanged);
    this.label4.AutoSize = true;
    this.label4.BackColor = Color.Transparent;
    this.label4.Location = new Point(7, 321);
    this.label4.Name = "label4";
    this.label4.Size = new Size(27, 13);
    this.label4.TabIndex = 126;
    this.label4.Text = "Fax:";
    ((AppearanceBase) appearance7).BackColor = Color.White;
    ((AppearanceBase) appearance7).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance7).ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtEntityName).Appearance = (AppearanceBase) appearance7;
    ((Control) this.txtEntityName).BackColor = Color.White;
    ((Control) this.txtEntityName).Location = new Point(94, 31 /*0x1F*/);
    this.txtEntityName.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtEntityName).Name = "txtEntityName";
    ((Control) this.txtEntityName).Size = new Size(260, 19);
    ((Control) this.txtEntityName).TabIndex = 111;
    ((UltraControlBase) this.txtEntityName).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtEntityName).UseOsThemes = (DefaultableBoolean) 2;
    ((TextEditorControlBase) this.txtEntityName).ValueChanged += new EventHandler(this.txtEntityName_ValueChanged);
    ((AppearanceBase) appearance8).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraMaskedEdit) this.maskPhone).Appearance = (AppearanceBase) appearance8;
    ((UltraMaskedEdit) this.maskPhone).DataMode = (MaskMode) 0;
    ((UltraMaskedEdit) this.maskPhone).EditAs = (EditAsType) 1;
    ((UltraMaskedEdit) this.maskPhone).InputMask = "(###) ###-####";
    ((Control) this.maskPhone).Location = new Point(94, 297);
    this.maskPhone.MGAStyle = (MGAStyles) 2;
    ((Control) this.maskPhone).Name = "maskPhone";
    ((UltraMaskedEdit) this.maskPhone).NonAutoSizeHeight = 20;
    ((Control) this.maskPhone).Size = new Size(89, 20);
    ((Control) this.maskPhone).TabIndex = 135;
    ((Control) this.maskPhone).Text = "(___) ___-____";
    ((UltraControlBase) this.maskPhone).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.maskPhone).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraMaskedEdit) this.maskPhone).ValueChanged += new EventHandler(this.maskPhone_ValueChanged);
    this.label2.AutoSize = true;
    this.label2.BackColor = Color.Transparent;
    this.label2.Location = new Point(7, 298);
    this.label2.Name = "label2";
    this.label2.Size = new Size(50, 13);
    this.label2.TabIndex = 124;
    this.label2.Text = "Phone 1:";
    ((AppearanceBase) appearance9).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraMaskedEdit) this.maskFEINSSN).Appearance = (AppearanceBase) appearance9;
    ((UltraMaskedEdit) this.maskFEINSSN).DataMode = (MaskMode) 0;
    ((UltraMaskedEdit) this.maskFEINSSN).EditAs = (EditAsType) 1;
    ((UltraMaskedEdit) this.maskFEINSSN).InputMask = "999-99-9999";
    ((Control) this.maskFEINSSN).Location = new Point(94, 371);
    this.maskFEINSSN.MGAStyle = (MGAStyles) 2;
    ((Control) this.maskFEINSSN).Name = "maskFEINSSN";
    ((UltraMaskedEdit) this.maskFEINSSN).NonAutoSizeHeight = 20;
    ((Control) this.maskFEINSSN).Size = new Size(89, 20);
    ((Control) this.maskFEINSSN).TabIndex = 138;
    ((UltraControlBase) this.maskFEINSSN).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.maskFEINSSN).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraMaskedEdit) this.maskFEINSSN).ValueChanged += new EventHandler(this.maskFEINSSN_ValueChanged);
    this.label11.AutoSize = true;
    this.label11.BackColor = Color.Transparent;
    this.label11.Location = new Point(6, 373);
    this.label11.Name = "label11";
    this.label11.Size = new Size(61, 13);
    this.label11.TabIndex = 130;
    this.label11.Text = "FEIN/SSN:";
    this.label1.AutoSize = true;
    this.label1.BackColor = Color.Transparent;
    this.label1.Location = new Point(7, 31 /*0x1F*/);
    this.label1.Name = "label1";
    this.label1.Size = new Size(67, 13);
    this.label1.TabIndex = 110;
    this.label1.Text = "Entity Name:";
    ((Control) this.addrClaimEntity).BackColor = Color.Transparent;
    ((Control) this.addrClaimEntity).Location = new Point(-1, 144 /*0x90*/);
    ((Control) this.addrClaimEntity).Margin = new Padding(3, 0, 3, 0);
    ((Control) this.addrClaimEntity).Name = "addrClaimEntity";
    ((Control) this.addrClaimEntity).Size = new Size(272, 153);
    ((Control) this.addrClaimEntity).TabIndex = 134;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.Transparent;
    this.Controls.Add((Control) this.txtLastName);
    this.Controls.Add((Control) this.addrClaimEntity);
    this.Controls.Add((Control) this.txtContactName);
    this.Controls.Add((Control) this.label3);
    this.Controls.Add((Control) this.txtDBA);
    this.Controls.Add((Control) this.label9);
    this.Controls.Add((Control) this.txtMiddleName);
    this.Controls.Add((Control) this.txtFirstName);
    this.Controls.Add((Control) this.label10);
    this.Controls.Add((Control) this.label12);
    this.Controls.Add((Control) this.label14);
    this.Controls.Add((Control) this.cboEntityType);
    this.Controls.Add((Control) this.label8);
    this.Controls.Add((Control) this.maskFax);
    this.Controls.Add((Control) this.label4);
    this.Controls.Add((Control) this.txtEntityName);
    this.Controls.Add((Control) this.maskPhone);
    this.Controls.Add((Control) this.label2);
    this.Controls.Add((Control) this.maskFEINSSN);
    this.Controls.Add((Control) this.label11);
    this.Controls.Add((Control) this.label1);
    this.Name = nameof (ClaimsEntityView);
    this.Size = new Size(362, 404);
    this.Load += new EventHandler(this.ClaimsEntityView_Load);
    ((ISupportInitialize) this.txtContactName).EndInit();
    ((ISupportInitialize) this.txtDBA).EndInit();
    ((ISupportInitialize) this.txtLastName).EndInit();
    ((ISupportInitialize) this.txtMiddleName).EndInit();
    ((ISupportInitialize) this.txtFirstName).EndInit();
    ((ISupportInitialize) this.cboEntityType).EndInit();
    ((ISupportInitialize) this.maskFax).EndInit();
    ((ISupportInitialize) this.txtEntityName).EndInit();
    ((ISupportInitialize) this.maskPhone).EndInit();
    ((ISupportInitialize) this.maskFEINSSN).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }
}
