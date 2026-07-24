// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.Attorney_Management.AttorneyManagementController
// Assembly: MgaSystems.IMS.Claims, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FCD9D0B7-28CF-40B9-8EB7-297871E1AF5F
// Assembly location: F:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims.dll

using MGASystems.Common;
using MGASystems.Common.MVC.BaseClasses.Controller;
using MGASystems.Common.MVC.BaseClasses.Model.Validation;
using MGASystems.IMS.Accounting.Services.Forms.MVC.Address.Controller;
using MGASystems.IMS.Accounting.Services.Forms.MVC.ToolbarEdit;
using MGASystems.IMS.Accounting.Services.InfragisticsWrappers.UltraToolBarSettings;
using MGASystems.IMS.Accounting.Services.InfragisticsWrappers.UltraToolBarSettings.BaseClasses;
using MGASystems.IMS.Claims.Properties;
using System;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Claims.Attorney_Management;

[Override(typeof (IAttorneyManagementController))]
public class AttorneyManagementController : 
  MvcControllerBase<IAttorneyManagementModel, IAttorneyManagementView>,
  IAttorneyManagementController,
  IMvcController,
  ITopControlController
{
  public IAddressController AddressController { get; }

  public AttorneyManagementController(IAddressController addressController)
  {
    this.AddressController = addressController ?? throw new ArgumentNullException(nameof (addressController));
  }

  public AttorneyManagementController()
    : this(ObjectFactory.Instance.CreateObjectAs<IAddressController>())
  {
  }

  public IParentFormSettings ParentFormSettings
  {
    get
    {
      return (IParentFormSettings) new MGASystems.IMS.Accounting.Services.Forms.MVC.ToolbarEdit.ParentFormSettings()
      {
        Width = 309,
        Height = 370,
        Name = "Attorney Management"
      };
    }
  }

  public IToolbarItem[] GetToolBarItems()
  {
    return new IToolbarItem[2]
    {
      (IToolbarItem) new ButtonToolbarControl("Save", new Action(this.Save), (object) Resources.Save),
      (IToolbarItem) new ButtonToolbarControl("Cancel", new Action(this.Cancel), (object) Resources.arrow_undo)
    };
  }

  private void Save()
  {
    try
    {
      this.Model.ValidateData();
    }
    catch (DataValidationException ex)
    {
      int num = (int) MessageBox.Show(ex.Message, "Error Saving Record.", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      return;
    }
    this.View.RequestCloseForm(DialogResult.OK);
  }

  private void Cancel() => this.View.RequestCloseForm(DialogResult.Cancel);

  public void RequestSetAttorneyGuid(Guid guid) => this.Model.AttorneyGuid = guid;

  public void RequestSetAttorneyType(string text) => this.Model.AttorneyType = text;

  public void RequestSetAttorneyName(string text) => this.Model.AttorneyName = text;

  public void RequestSetLawFirm(string text) => this.Model.LawFirm = text;

  public void RequestSetAttorneyEntityType(string text) => this.Model.AttorneyEntityType = text;

  public void RequestSetFEINSSN(string text) => this.Model.FEINSSN = text;

  public void RequestSetPhoneNumber(string text) => this.Model.PhoneNumber = text;

  public void RequestSetFaxNumber(string text) => this.Model.FaxNumber = text;
}
