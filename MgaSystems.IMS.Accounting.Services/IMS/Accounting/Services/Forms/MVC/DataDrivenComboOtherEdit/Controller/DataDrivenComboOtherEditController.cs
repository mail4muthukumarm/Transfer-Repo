// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.Forms.MVC.DataDrivenComboOtherEdit.Controller.DataDrivenComboOtherEditController
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using MGASystems.Common;
using MGASystems.Common.MVC.BaseClasses.Controller;
using MGASystems.IMS.Accounting.Services.Forms.MVC.DataDrivenComboBox.Controller;
using MGASystems.IMS.Accounting.Services.Forms.MVC.DataDrivenComboOtherEdit.Model;
using MGASystems.IMS.Accounting.Services.Forms.MVC.DataDrivenComboOtherEdit.View;
using System;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.Forms.MVC.DataDrivenComboOtherEdit.Controller;

[Override(typeof (IDataDrivenComboOtherEditController))]
public class DataDrivenComboOtherEditController : 
  MvcControllerBase<ISelectableValueWithOtherModel, IDataDrivenComboOtherEditView>,
  IDataDrivenComboOtherEditController,
  IMvcController
{
  public IDataDrivenComboBoxController ComboBoxController { get; }

  public DataDrivenComboOtherEditController(IDataDrivenComboBoxController comboBoxController)
  {
    this.ComboBoxController = comboBoxController ?? throw new ArgumentNullException(nameof (comboBoxController));
    this.ComboBoxController.SelectedValueChanged += new EventHandler(this.ComboBoxController_OnSelectedValueChanged);
  }

  public DataDrivenComboOtherEditController()
    : this((IDataDrivenComboBoxController) new DataDrivenComboBoxController())
  {
  }

  protected override void ChildWireUp()
  {
    this.UpdateUIEnabledState();
    this.ComboBoxController.SelectedValueChanged += new EventHandler(this.ComboBoxController_OnSelectedValueChanged);
  }

  protected override void ChildUnWireUp()
  {
    this.ComboBoxController.SelectedValueChanged -= new EventHandler(this.ComboBoxController_OnSelectedValueChanged);
    this.View.DisableOtherTextBox();
  }

  public void RequestSetOtherText(string otherText) => this.Model.OtherText = otherText;

  private void UpdateUIEnabledState()
  {
    if (this.Model.IsOtherSelected)
      this.View.EnableOtherTextBox();
    else
      this.View.DisableOtherTextBox();
  }

  private void ComboBoxController_OnSelectedValueChanged(object sender, EventArgs e)
  {
    this.UpdateUIEnabledState();
  }
}
