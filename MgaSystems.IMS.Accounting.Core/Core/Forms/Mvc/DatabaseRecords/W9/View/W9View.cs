// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.Forms.Mvc.DatabaseRecords.W9.View.W9View
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using MGASystems.Common;
using MGASystems.Common.MVC.BaseClasses.View;
using MGASystems.IMS.Accounting.Core.Forms.Mvc.DatabaseRecords.W9.Controller;
using MGASystems.IMS.Accounting.Core.Forms.Mvc.DatabaseRecords.W9.Model;
using MGASystems.IMS.Accounting.Core.Properties;
using MGASystems.IMS.Accounting.Services.Forms.Controls;
using MGASystems.IMS.Accounting.Services.Forms.MVC.Address.Controller;
using MGASystems.IMS.Accounting.Services.Forms.MVC.Address.View;
using MGASystems.IMS.Accounting.Services.Forms.MVC.DataDrivenComboOtherEdit.Controller;
using MGASystems.IMS.Accounting.Services.Forms.MVC.DataDrivenComboOtherEdit.Model;
using MGASystems.IMS.Accounting.Services.Forms.MVC.DataDrivenComboOtherEdit.View;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.Forms.Mvc.DatabaseRecords.W9.View;

[Override(typeof (IW9View))]
public class W9View : MvcViewBase<IW9Model, IW9Controller>, IW9View, IMvcView, IModelObserver
{
  private IContainer components;
  private Label lTinEin;
  private Label lEntityType;
  private Label lW9Date;
  private MGATextBox tbBusinessName;
  private MGATextBox tbTaxingEntity;
  private DataDrivenComboOtherEditView cEntityType;
  private MGADateTimePicker dDate;
  private HiddenValueMgaTextBox cTinEin;
  private Label lBusinessName;
  private Label lTaxingEntity;
  private AddressView cAddress;
  private Label lLastEditBy;
  private Label lLastEditByValue;
  private Label lLastEditDate;
  private Label lLastEditDateValue;
  private UltraGroupBox ultraGroupBox1;
  private Label lEntityTypeOther;
  private Button bSearchAccountingEntity;

  public W9View()
  {
    this.InitializeComponent();
    this.dDate.Value = (object) null;
    this.lLastEditByValue.Text = string.Empty;
    this.lLastEditDateValue.Text = string.Empty;
  }

  protected override void ChildWireUp()
  {
    AddressController controller = new AddressController();
    this.cEntityType.WireUp((IDataDrivenComboOtherEditController) new DataDrivenComboOtherEditController(), (ISelectableValueWithOtherModel) this.Model.EntityType);
    this.Model.EntityType.AddObserver((IModelObserver) this);
    this.cAddress.WireUp((IAddressController) controller, this.Model.Address);
    this.Model.Address.AddObserver((IModelObserver) this);
    this.cTinEin.ValueChanged += new EventHandler(this.TbTinEin_ValueChanged);
  }

  public override void Update(object model)
  {
    if (!(model is IW9Model model1))
      return;
    this.Update(model1);
  }

  protected override void ChildUpdateFromModel(IW9Model model)
  {
    this.cEntityType.Update((ISelectableValueWithOtherModel) model.EntityType);
    ((Control) this.tbBusinessName).Text = model.BusinessName;
    ((Control) this.tbTaxingEntity).Text = model.TaxingEntity;
    this.cTinEin.SetPlainText(model.TinEin);
    this.dDate.Value = (object) model.W9Date;
    this.cAddress.Update(model.Address);
    this.lLastEditByValue.Text = model.ModificationData.UserName ?? string.Empty;
    Label lastEditDateValue = this.lLastEditDateValue;
    DateTime? modifiedDate = model.ModificationData.ModifiedDate;
    ref DateTime? local = ref modifiedDate;
    string str = (local.HasValue ? local.GetValueOrDefault().ToString("d") : (string) null) ?? string.Empty;
    lastEditDateValue.Text = str;
  }

  protected override void ChildUnWireUp()
  {
    this.cEntityType.UnWireUp();
    ((Control) this.tbBusinessName).Text = string.Empty;
    ((Control) this.tbTaxingEntity).Text = string.Empty;
    this.cTinEin.Clear();
    this.dDate.Value = (object) null;
    this.cAddress.UnWireUp();
    this.lLastEditByValue.Text = string.Empty;
    this.lLastEditDateValue.Text = string.Empty;
  }

  protected override void ChildSetFocus() => ((TextEditorControlBase) this.tbBusinessName).Focus();

  public void UserSetTinEin(string text) => this.Controller.RequestSetTinEin(text);

  public void UserSetBusinessName(string text) => this.Controller.RequestSetBusinessName(text);

  public void UserSetTaxingEntity(string text) => this.Controller.RequestSetTaxingEntity(text);

  public void UserSetW9Date(DateTime? date) => this.Controller.RequestSetW9Date(date);

  public void UserSearchAccountingEntity() => this.Controller.RequestSearchAccountingEntity();

  public void SetAddressEnableState(bool enabled) => this.cAddress.Enabled = enabled;

  public void SetTinEinEnableState(bool enabled) => this.cTinEin.Enabled = enabled;

  public void SetSearchEnabledState(bool enabled) => this.bSearchAccountingEntity.Enabled = enabled;

  private void TbTinEin_ValueChanged(object sender, EventArgs e)
  {
    this.InvokeIfNotSuppressed((Action) (() => this.UserSetTinEin(this.cTinEin.PlainText)));
  }

  private void tbTaxingEntity_ValueChanged(object sender, EventArgs e)
  {
    this.InvokeIfNotSuppressed((Action) (() => this.UserSetTaxingEntity(((Control) this.tbTaxingEntity).Text)));
  }

  private void dDate_ValueChanged(object sender, EventArgs e)
  {
    this.InvokeIfNotSuppressed((Action) (() => this.UserSetW9Date(!(this.dDate.Value is DateTime dateTime) ? new DateTime?() : new DateTime?(dateTime))));
  }

  private void bSearchAccountingEntity_Click(object sender, EventArgs e)
  {
    this.InvokeIfNotSuppressed(new Action(this.UserSearchAccountingEntity));
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
    this.lTinEin = new Label();
    this.lEntityType = new Label();
    this.lW9Date = new Label();
    this.tbBusinessName = new MGATextBox();
    this.tbTaxingEntity = new MGATextBox();
    this.cEntityType = new DataDrivenComboOtherEditView();
    this.dDate = new MGADateTimePicker();
    this.cTinEin = new HiddenValueMgaTextBox();
    this.lBusinessName = new Label();
    this.lTaxingEntity = new Label();
    this.cAddress = new AddressView();
    this.lLastEditBy = new Label();
    this.lLastEditByValue = new Label();
    this.lLastEditDate = new Label();
    this.lLastEditDateValue = new Label();
    this.ultraGroupBox1 = new UltraGroupBox();
    this.bSearchAccountingEntity = new Button();
    this.lEntityTypeOther = new Label();
    ((ISupportInitialize) this.tbBusinessName).BeginInit();
    ((ISupportInitialize) this.tbTaxingEntity).BeginInit();
    ((ISupportInitialize) this.dDate).BeginInit();
    ((ISupportInitialize) this.ultraGroupBox1).BeginInit();
    ((Control) this.ultraGroupBox1).SuspendLayout();
    this.SuspendLayout();
    this.lTinEin.AutoSize = true;
    this.lTinEin.Location = new Point(6, 254);
    this.lTinEin.Margin = new Padding(3);
    this.lTinEin.Name = "lTinEin";
    this.lTinEin.Size = new Size(55, 13);
    this.lTinEin.TabIndex = 4;
    this.lTinEin.Text = "TIN / EIN:";
    this.lTinEin.TextAlign = ContentAlignment.MiddleLeft;
    this.lEntityType.AutoSize = true;
    this.lEntityType.Location = new Point(6, 206);
    this.lEntityType.Margin = new Padding(3);
    this.lEntityType.Name = "lEntityType";
    this.lEntityType.Size = new Size(66, 13);
    this.lEntityType.TabIndex = 5;
    this.lEntityType.Text = "Entity Type:";
    this.lEntityType.TextAlign = ContentAlignment.MiddleLeft;
    this.lW9Date.AutoSize = true;
    this.lW9Date.Location = new Point(6, 278);
    this.lW9Date.Margin = new Padding(3);
    this.lW9Date.Name = "lW9Date";
    this.lW9Date.Size = new Size(53, 13);
    this.lW9Date.TabIndex = 6;
    this.lW9Date.Text = "W9 Date:";
    this.lW9Date.TextAlign = ContentAlignment.MiddleLeft;
    ((AppearanceBase) appearance1).BackColor = Color.White;
    ((AppearanceBase) appearance1).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance1).ForeColor = Color.Black;
    ((TextEditorControlBase) this.tbBusinessName).Appearance = (AppearanceBase) appearance1;
    ((Control) this.tbBusinessName).BackColor = Color.White;
    ((Control) this.tbBusinessName).Enabled = false;
    ((Control) this.tbBusinessName).Location = new Point(94, 18);
    this.tbBusinessName.MGAStyle = MGAStyles.Blue;
    ((Control) this.tbBusinessName).Name = "tbBusinessName";
    ((Control) this.tbBusinessName).Size = new Size(180, 20);
    ((Control) this.tbBusinessName).TabIndex = 1;
    ((UltraControlBase) this.tbBusinessName).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.tbBusinessName).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance2).BackColor = Color.White;
    ((AppearanceBase) appearance2).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance2).ForeColor = Color.Black;
    ((TextEditorControlBase) this.tbTaxingEntity).Appearance = (AppearanceBase) appearance2;
    ((Control) this.tbTaxingEntity).BackColor = Color.White;
    ((Control) this.tbTaxingEntity).Location = new Point(94, 41);
    ((Control) this.tbTaxingEntity).Margin = new Padding(3, 3, 3, 0);
    this.tbTaxingEntity.MGAStyle = MGAStyles.Blue;
    ((Control) this.tbTaxingEntity).Name = "tbTaxingEntity";
    ((Control) this.tbTaxingEntity).Size = new Size(203, 20);
    ((Control) this.tbTaxingEntity).TabIndex = 2;
    ((UltraControlBase) this.tbTaxingEntity).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.tbTaxingEntity).UseOsThemes = (DefaultableBoolean) 2;
    ((TextEditorControlBase) this.tbTaxingEntity).ValueChanged += new EventHandler(this.tbTaxingEntity_ValueChanged);
    this.cEntityType.AutoSizeMode = AutoSizeMode.GrowAndShrink;
    this.cEntityType.BackColor = Color.Transparent;
    this.cEntityType.Location = new Point(94, 205);
    this.cEntityType.Margin = new Padding(1, 0, 1, 0);
    this.cEntityType.Name = "cEntityType";
    this.cEntityType.Size = new Size(203, 50);
    this.cEntityType.TabIndex = 4;
    ((AppearanceBase) appearance3).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dDate.Appearance = (AppearanceBase) appearance3;
    ((AppearanceBase) appearance4).AlphaLevel = (short) 14;
    ((AppearanceBase) appearance4).BackColor = Color.FromArgb(0, 0, 246, 253);
    ((AppearanceBase) appearance4).BackColor2 = Color.FromArgb(133, 162, 221);
    ((AppearanceBase) appearance4).BackColorAlpha = (Alpha) 2;
    ((AppearanceBase) appearance4).BackGradientAlignment = (GradientAlignment) 4;
    ((AppearanceBase) appearance4).BackGradientStyle = (GradientStyle) 5;
    ((AppearanceBase) appearance4).BorderAlpha = (Alpha) 1;
    ((AppearanceBase) appearance4).BorderColor = Color.FromArgb(78, 122, 171);
    ((AppearanceBase) appearance4).ForeColor = Color.FromArgb(49, 85, 153);
    ((AppearanceBase) appearance4).ForegroundAlpha = (Alpha) 2;
    this.dDate.ButtonAppearance = (AppearanceBase) appearance4;
    this.dDate.DateTime = new DateTime(2023, 6, 3, 0, 0, 0, 0);
    ((Control) this.dDate).Location = new Point(94, 278);
    this.dDate.MGAStyle = MGAStyles.Blue;
    ((Control) this.dDate).Name = "dDate";
    ((Control) this.dDate).Size = new Size(100, 20);
    ((Control) this.dDate).TabIndex = 6;
    ((UltraControlBase) this.dDate).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dDate).UseOsThemes = (DefaultableBoolean) 2;
    this.dDate.Value = (object) new DateTime(2023, 6, 3, 0, 0, 0, 0);
    this.dDate.ValueChanged += new EventHandler(this.dDate_ValueChanged);
    this.cTinEin.HideCharacter = '*';
    this.cTinEin.IgnoreCharagers = (char[]) null;
    this.cTinEin.InputMask = "##-#######";
    this.cTinEin.Location = new Point(94, 254);
    this.cTinEin.Name = "cTinEin";
    this.cTinEin.Size = new Size(167, 21);
    this.cTinEin.TabIndex = 5;
    this.cTinEin.VisibleSuffixCharacters = 4;
    this.lBusinessName.AutoSize = true;
    this.lBusinessName.Location = new Point(6, 18);
    this.lBusinessName.Margin = new Padding(3);
    this.lBusinessName.Name = "lBusinessName";
    this.lBusinessName.Size = new Size(82, 13);
    this.lBusinessName.TabIndex = 1;
    this.lBusinessName.Text = "Business Name:";
    this.lBusinessName.TextAlign = ContentAlignment.MiddleLeft;
    this.lTaxingEntity.AutoSize = true;
    this.lTaxingEntity.Location = new Point(6, 41);
    this.lTaxingEntity.Margin = new Padding(3);
    this.lTaxingEntity.Name = "lTaxingEntity";
    this.lTaxingEntity.Size = new Size(74, 13);
    this.lTaxingEntity.TabIndex = 2;
    this.lTaxingEntity.Text = "Taxing Entity:";
    this.lTaxingEntity.TextAlign = ContentAlignment.MiddleLeft;
    this.cAddress.BackColor = Color.Transparent;
    this.cAddress.Location = new Point(-1, 56);
    this.cAddress.Margin = new Padding(3, 0, 3, 0);
    this.cAddress.Name = "cAddress";
    this.cAddress.Size = new Size(266, 153);
    this.cAddress.TabIndex = 3;
    this.lLastEditBy.AutoSize = true;
    this.lLastEditBy.Location = new Point(6, 301);
    this.lLastEditBy.Name = "lLastEditBy";
    this.lLastEditBy.Size = new Size(67, 13);
    this.lLastEditBy.TabIndex = 19;
    this.lLastEditBy.Text = "Last Edit By:";
    this.lLastEditByValue.AutoSize = true;
    this.lLastEditByValue.Location = new Point(91, 301);
    this.lLastEditByValue.Name = "lLastEditByValue";
    this.lLastEditByValue.Size = new Size(89, 13);
    this.lLastEditByValue.TabIndex = 20;
    this.lLastEditByValue.Text = "<Last Edit User>";
    this.lLastEditDate.AutoSize = true;
    this.lLastEditDate.Location = new Point(6, 318);
    this.lLastEditDate.Name = "lLastEditDate";
    this.lLastEditDate.Size = new Size(78, 13);
    this.lLastEditDate.TabIndex = 21;
    this.lLastEditDate.Text = "Last Edit Date:";
    this.lLastEditDateValue.AutoSize = true;
    this.lLastEditDateValue.Location = new Point(91, 318);
    this.lLastEditDateValue.Name = "lLastEditDateValue";
    this.lLastEditDateValue.Size = new Size(90, 13);
    this.lLastEditDateValue.TabIndex = 22;
    this.lLastEditDateValue.Text = "<Last Edit Date>";
    ((Control) this.ultraGroupBox1).Controls.Add((Control) this.bSearchAccountingEntity);
    ((Control) this.ultraGroupBox1).Controls.Add((Control) this.cTinEin);
    ((Control) this.ultraGroupBox1).Controls.Add((Control) this.lEntityTypeOther);
    ((Control) this.ultraGroupBox1).Controls.Add((Control) this.lEntityType);
    ((Control) this.ultraGroupBox1).Controls.Add((Control) this.cEntityType);
    ((Control) this.ultraGroupBox1).Controls.Add((Control) this.tbTaxingEntity);
    ((Control) this.ultraGroupBox1).Controls.Add((Control) this.cAddress);
    ((Control) this.ultraGroupBox1).Controls.Add((Control) this.lLastEditDateValue);
    ((Control) this.ultraGroupBox1).Controls.Add((Control) this.lW9Date);
    ((Control) this.ultraGroupBox1).Controls.Add((Control) this.lLastEditDate);
    ((Control) this.ultraGroupBox1).Controls.Add((Control) this.lLastEditByValue);
    ((Control) this.ultraGroupBox1).Controls.Add((Control) this.lTinEin);
    ((Control) this.ultraGroupBox1).Controls.Add((Control) this.lLastEditBy);
    ((Control) this.ultraGroupBox1).Controls.Add((Control) this.dDate);
    ((Control) this.ultraGroupBox1).Controls.Add((Control) this.tbBusinessName);
    ((Control) this.ultraGroupBox1).Controls.Add((Control) this.lTaxingEntity);
    ((Control) this.ultraGroupBox1).Controls.Add((Control) this.lBusinessName);
    ((Control) this.ultraGroupBox1).Dock = DockStyle.Fill;
    ((Control) this.ultraGroupBox1).Location = new Point(0, 0);
    ((Control) this.ultraGroupBox1).Margin = new Padding(0);
    ((Control) this.ultraGroupBox1).Name = "ultraGroupBox1";
    ((Control) this.ultraGroupBox1).Size = new Size(303, 344);
    ((Control) this.ultraGroupBox1).TabIndex = 23;
    ((Control) this.ultraGroupBox1).Text = "W9 Information";
    this.bSearchAccountingEntity.BackgroundImage = (Image) Resources.SearchTransaction;
    this.bSearchAccountingEntity.BackgroundImageLayout = ImageLayout.Center;
    this.bSearchAccountingEntity.FlatStyle = FlatStyle.Flat;
    this.bSearchAccountingEntity.Location = new Point(277, 18);
    this.bSearchAccountingEntity.Name = "bSearchAccountingEntity";
    this.bSearchAccountingEntity.Size = new Size(20, 20);
    this.bSearchAccountingEntity.TabIndex = 31 /*0x1F*/;
    this.bSearchAccountingEntity.UseVisualStyleBackColor = true;
    this.bSearchAccountingEntity.Click += new EventHandler(this.bSearchAccountingEntity_Click);
    this.lEntityTypeOther.AutoSize = true;
    this.lEntityTypeOther.Location = new Point(6, 230);
    this.lEntityTypeOther.Margin = new Padding(3);
    this.lEntityTypeOther.Name = "lEntityTypeOther";
    this.lEntityTypeOther.Size = new Size(39, 13);
    this.lEntityTypeOther.TabIndex = 23;
    this.lEntityTypeOther.Text = "Other:";
    this.lEntityTypeOther.TextAlign = ContentAlignment.MiddleLeft;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.Transparent;
    this.Controls.Add((Control) this.ultraGroupBox1);
    this.Font = new Font("Tahoma", 8.25f);
    this.Name = nameof (W9View);
    this.Size = new Size(303, 344);
    ((ISupportInitialize) this.tbBusinessName).EndInit();
    ((ISupportInitialize) this.tbTaxingEntity).EndInit();
    ((ISupportInitialize) this.dDate).EndInit();
    ((ISupportInitialize) this.ultraGroupBox1).EndInit();
    ((Control) this.ultraGroupBox1).ResumeLayout(false);
    ((Control) this.ultraGroupBox1).PerformLayout();
    this.ResumeLayout(false);
  }
}
