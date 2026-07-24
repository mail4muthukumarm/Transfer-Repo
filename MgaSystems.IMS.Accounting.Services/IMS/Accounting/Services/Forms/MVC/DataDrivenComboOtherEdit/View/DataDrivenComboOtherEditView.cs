// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.Forms.MVC.DataDrivenComboOtherEdit.View.DataDrivenComboOtherEditView
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinEditors;
using MGASystems.Common.MVC.BaseClasses.Controller;
using MGASystems.Common.MVC.BaseClasses.Model;
using MGASystems.Common.MVC.BaseClasses.View;
using MGASystems.IMS.Accounting.Services.Forms.MVC.DataDrivenComboBox.View;
using MGASystems.IMS.Accounting.Services.Forms.MVC.DataDrivenComboOtherEdit.Controller;
using MGASystems.IMS.Accounting.Services.Forms.MVC.DataDrivenComboOtherEdit.Model;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.Forms.MVC.DataDrivenComboOtherEdit.View;

public class DataDrivenComboOtherEditView : 
  MvcViewBase<ISelectableValueWithOtherModel, IDataDrivenComboOtherEditController>,
  IDataDrivenComboOtherEditView,
  IMvcView,
  IModelObserver
{
  private IContainer components;
  private DataDrivenComboBoxView cbOptions;
  private MGATextBox tbOther;

  public DataDrivenComboOtherEditView() => this.InitializeComponent();

  public void EnableOtherTextBox() => ((Control) this.tbOther).Enabled = true;

  public void DisableOtherTextBox() => ((Control) this.tbOther).Enabled = false;

  protected override void ChildUpdateFromModel(ISelectableValueWithOtherModel model)
  {
    ((Control) this.tbOther).Text = model.OtherText;
    this.cbOptions.Update((object) model.SelectableValueModel);
  }

  protected override void ChildWireUp()
  {
    this.cbOptions.WireUp((IMvcController) this.Controller.ComboBoxController, (IMvcModel) this.Model.SelectableValueModel);
  }

  protected override void ChildUnWireUp()
  {
    ((Control) this.tbOther).Text = string.Empty;
    this.cbOptions.UnWireUp();
  }

  public void UserChangeOtherValue(string otherValue)
  {
    this.Controller.RequestSetOtherText(otherValue);
  }

  private void tbOther_ValueChanged(object sender, EventArgs e)
  {
    this.InvokeIfNotSuppressed((Action) (() => this.UserChangeOtherValue(((Control) this.tbOther).Text)));
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    Appearance appearance = new Appearance();
    this.cbOptions = new DataDrivenComboBoxView();
    this.tbOther = new MGATextBox();
    ((ISupportInitialize) this.tbOther).BeginInit();
    this.SuspendLayout();
    this.cbOptions.Anchor = AnchorStyles.Left | AnchorStyles.Right;
    this.cbOptions.AutoSizeMode = AutoSizeMode.GrowAndShrink;
    this.cbOptions.Font = new Font("Tahoma", 8.25f);
    this.cbOptions.ForeColor = SystemColors.ControlText;
    this.cbOptions.Location = new Point(0, 0);
    this.cbOptions.Margin = new Padding(0);
    this.cbOptions.Name = "cbOptions";
    this.cbOptions.Size = new Size(166, 20);
    this.cbOptions.TabIndex = 0;
    ((Control) this.tbOther).Anchor = AnchorStyles.Left | AnchorStyles.Right;
    ((AppearanceBase) appearance).BackColor = Color.White;
    ((AppearanceBase) appearance).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance).ForeColor = Color.Black;
    ((TextEditorControlBase) this.tbOther).Appearance = (AppearanceBase) appearance;
    ((Control) this.tbOther).BackColor = Color.White;
    ((Control) this.tbOther).Enabled = false;
    ((Control) this.tbOther).Font = new Font("Tahoma", 8.25f);
    ((Control) this.tbOther).Location = new Point(0, 23);
    ((Control) this.tbOther).Margin = new Padding(0);
    this.tbOther.MGAStyle = MGAStyles.Blue;
    ((Control) this.tbOther).Name = "tbOther";
    ((Control) this.tbOther).Size = new Size(166, 20);
    ((Control) this.tbOther).TabIndex = 2;
    ((UltraControlBase) this.tbOther).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.tbOther).UseOsThemes = (DefaultableBoolean) 2;
    ((TextEditorControlBase) this.tbOther).ValueChanged += new EventHandler(this.tbOther_ValueChanged);
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
    this.BackColor = Color.Transparent;
    this.Controls.Add((Control) this.cbOptions);
    this.Controls.Add((Control) this.tbOther);
    this.Name = nameof (DataDrivenComboOtherEditView);
    this.Size = new Size(166, 44);
    ((ISupportInitialize) this.tbOther).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }
}
