// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.Claims_Entities.MVC.Controller.ClaimsEntityController
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
using MGASystems.IMS.Claims.Claims_Entities.MVC.Model;
using MGASystems.IMS.Claims.Claims_Entities.MVC.View;
using MGASystems.IMS.Claims.Properties;
using System;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Claims.Claims_Entities.MVC.Controller;

[Override(typeof (IClaimsEntityController))]
public class ClaimsEntityController : 
  MvcControllerBase<IClaimsEntityModel, IClaimsEntityView>,
  IClaimsEntityController,
  IMvcController,
  ITopControlController
{
  public IAddressController AddressController { get; }

  public ClaimsEntityController(IAddressController addressController)
  {
    this.AddressController = addressController ?? throw new ArgumentNullException(nameof (addressController));
  }

  public ClaimsEntityController()
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
        Name = "Claims Entity Management"
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

  public void RequestSetEntityGuid(Guid guid) => this.Model.EntityGuid = guid;

  public void RequestSetEntityType(int id, string text)
  {
    this.Model.EntityTypeId = id;
    this.Model.EntityTypeDesc = text;
  }

  public void RequestSetEntityName(string text) => this.Model.EntityName = text;

  public void RequestSetDBA(string text) => this.Model.DBA = text;

  public void RequestSetFirstName(string text) => this.Model.FirstName = text;

  public void RequestSetMiddleName(string text) => this.Model.MiddleName = text;

  public void RequestSetLastName(string text) => this.Model.LastName = text;

  public void RequestSetFEINSSN(string text) => this.Model.FEINSSN = text;

  public void RequestSetContactName(string text) => this.Model.ContactName = text;

  public void RequestSetPhoneNumber(string text) => this.Model.PhoneNumber = text;

  public void RequestSetFaxNumber(string text) => this.Model.FaxNumber = text;
}
