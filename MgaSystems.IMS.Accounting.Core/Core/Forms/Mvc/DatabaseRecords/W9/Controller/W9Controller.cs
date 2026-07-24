// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.Forms.Mvc.DatabaseRecords.W9.Controller.W9Controller
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using MGASystems.Common;
using MGASystems.Common.MVC.BaseClasses.Controller;
using MGASystems.Common.MVC.BaseClasses.Model.Validation;
using MGASystems.IMS.Accounting.Core.ClassObjects;
using MGASystems.IMS.Accounting.Core.Forms.Mvc.DatabaseRecords.W9.Model;
using MGASystems.IMS.Accounting.Core.Forms.Mvc.DatabaseRecords.W9.View;
using MGASystems.IMS.Accounting.Core.Properties;
using MGASystems.IMS.Accounting.Services.Forms.MVC.Address.Controller;
using MGASystems.IMS.Accounting.Services.Forms.MVC.DataDrivenComboOtherEdit.Controller;
using MGASystems.IMS.Accounting.Services.Forms.MVC.ToolbarEdit;
using MGASystems.IMS.Accounting.Services.InfragisticsWrappers.UltraToolBarSettings;
using MGASystems.IMS.Accounting.Services.InfragisticsWrappers.UltraToolBarSettings.BaseClasses;
using System;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.Forms.Mvc.DatabaseRecords.W9.Controller;

[Override(typeof (IW9Controller))]
public class W9Controller : 
  MvcControllerBase<IW9Model, IW9View>,
  IW9Controller,
  IMvcController,
  ITopControlController,
  IRequestParentSize
{
  public IAddressController AddressController { get; }

  public IDataDrivenComboOtherEditController EntityTypeController { get; }

  public IParentFormSettings ParentFormSettings
  {
    get
    {
      return (IParentFormSettings) new MGASystems.IMS.Accounting.Services.Forms.MVC.ToolbarEdit.ParentFormSettings()
      {
        Width = 309,
        Height = 370,
        Name = "W9 Edit"
      };
    }
  }

  public ISizeSettings ParentSizeSettings
  {
    get => (ISizeSettings) new PlaceholderSizeSettings(this.ParentFormSettings);
  }

  public IToolbarItem[] GetToolBarItems()
  {
    return new IToolbarItem[2]
    {
      (IToolbarItem) new ButtonToolbarControl("Save", new Action(this.Save), (object) Resources.disk),
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

  public W9Controller(
    IAddressController addressController,
    IDataDrivenComboOtherEditController entityTypeController)
  {
    this.AddressController = addressController ?? throw new ArgumentNullException(nameof (addressController));
    this.EntityTypeController = entityTypeController ?? throw new ArgumentNullException(nameof (entityTypeController));
  }

  public W9Controller()
    : this(ObjectFactory.Instance.CreateObjectAs<IAddressController>(), ObjectFactory.Instance.CreateObjectAs<IDataDrivenComboOtherEditController>())
  {
  }

  public void RequestSetBusinessName(string businessName) => this.Model.BusinessName = businessName;

  public void RequestSetTaxingEntity(string taxingEntity) => this.Model.TaxingEntity = taxingEntity;

  public void RequestSetW9Date(DateTime? date) => this.Model.W9Date = date;

  public void RequestSetEntityGuid(Guid guid) => this.Model.SetNewId(guid);

  public void RequestSetSearchEnabledState(bool enabled)
  {
    this.View.SetSearchEnabledState(enabled);
  }

  public void RequestSetAddressEnableState(bool enabled)
  {
    this.View.SetAddressEnableState(enabled);
  }

  public void RequestSetTinEinEnableState(bool enabled) => this.View.SetTinEinEnableState(enabled);

  public virtual void RequestSetTinEin(string tinEin) => this.Model.TinEin = tinEin;

  public virtual void RequestSearchAccountingEntity()
  {
    using (FormSearchEntity formSearchEntity = new FormSearchEntity(Utility.SearchEntityTypes.All))
    {
      if (formSearchEntity.ShowDialog() != DialogResult.OK)
        return;
      this.RequestSetEntityGuid(formSearchEntity.EntityGuid);
      this.RequestSetBusinessName(formSearchEntity.EntityName);
    }
  }
}
