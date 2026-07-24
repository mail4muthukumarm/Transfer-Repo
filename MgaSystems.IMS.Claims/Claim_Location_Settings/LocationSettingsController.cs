// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.Claim_Location_Settings.LocationSettingsController
// Assembly: MgaSystems.IMS.Claims, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FCD9D0B7-28CF-40B9-8EB7-297871E1AF5F
// Assembly location: F:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims.dll

using MGASystems.Common;
using MGASystems.Common.MVC.BaseClasses.Controller;
using MGASystems.Common.MVC.BaseClasses.Model.Validation;
using MGASystems.IMS.Accounting.Services.Forms.MVC.ToolbarEdit;
using MGASystems.IMS.Accounting.Services.InfragisticsWrappers.UltraToolBarSettings;
using MGASystems.IMS.Accounting.Services.InfragisticsWrappers.UltraToolBarSettings.BaseClasses;
using MGASystems.IMS.Claims.Properties;
using System;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Claims.Claim_Location_Settings;

[Override(typeof (ILocationSettingsController))]
public class LocationSettingsController : 
  MvcControllerBase<ILocationSettingsModel, ILocationSettingsView>,
  ILocationSettingsController,
  IMvcController,
  ITopControlController
{
  public IParentFormSettings ParentFormSettings
  {
    get
    {
      return (IParentFormSettings) new MGASystems.IMS.Accounting.Services.Forms.MVC.ToolbarEdit.ParentFormSettings()
      {
        Width = 922,
        Height = 448,
        Name = "Claim Location Settings"
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

  public void RequestSetQuotingOfficeGuid(Guid guid) => this.Model.QuotingOfficeGuid = guid;

  public void RequestSetQuotingOfficeId(int id, string text)
  {
    this.Model.QuotingOfficeId = id;
    this.Model.QuotingOfficeName = text;
  }

  public void RequestSetClaimsOfficeId(int id, string text)
  {
    this.Model.ClaimsOfficeId = id;
    this.Model.ClaimsOfficeName = text;
  }

  public void RequestSetGLAcctId(int id, string text)
  {
    this.Model.GLAcctId = id;
    this.Model.GLAcctName = text;
  }
}
