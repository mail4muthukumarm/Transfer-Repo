// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.Claim_Location_Settings.LocationSettingsForm
// Assembly: MgaSystems.IMS.Claims, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FCD9D0B7-28CF-40B9-8EB7-297871E1AF5F
// Assembly location: F:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims.dll

using MGASystems.Common;
using MGASystems.Common.MVC.BaseClasses.Controller;
using MGASystems.Common.MVC.BaseClasses.Model;
using MGASystems.Common.MVC.BaseClasses.Model.DatabaseModels;
using MGASystems.Common.MVC.BaseClasses.View;
using MGASystems.Data.Repository.Interface;
using MGASystems.IMS.Accounting.Services.Forms.MVC.DataGridControl.View.UltragridViewAdapters;
using MGASystems.IMS.Accounting.Services.Forms.MVC.UserInterface;
using MGASystems.IMS.Accounting.Services.Forms.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Claims.Claim_Location_Settings;

[SecureResource("{4BCE65DD-4CAE-4852-90C9-483B0D1707BC}", "Location Settings Management Rights", "Users with this permission are granted the ability to maintain claims location settings.", "Claims")]
public class LocationSettingsForm : RecordEditorForm_Right
{
  private readonly ILocationSettingsRepository _locationSettingsRepository;
  private IContainer components;

  public LocationSettingsForm(ILocationSettingsRepository repository)
  {
    this._locationSettingsRepository = repository;
    this.InitializeComponent();
    ILocationSettingsController objectAs = ObjectFactory.Instance.CreateObjectAs<ILocationSettingsController>();
    this.Setup((IMvcView) ObjectFactory.Instance.CreateObjectAs<ILocationSettingsView>(), (IMvcController) objectAs);
  }

  public LocationSettingsForm()
    : this((ILocationSettingsRepository) new LocationSettingsRepository())
  {
  }

  protected virtual IDatabaseSaveModel[] AllRecords
  {
    get
    {
      return (IDatabaseSaveModel[]) ((IEnumerable<LocationSettingsDto>) ((IGetAllRepository<LocationSettingsDto, Guid>) this._locationSettingsRepository).GetAll()).Select<LocationSettingsDto, LocationSettingsModel>((Func<LocationSettingsDto, LocationSettingsModel>) (x => ObjectFactory.Instance.CreateObjectAs<LocationSettingsModel>((object) x, (object) this._locationSettingsRepository))).ToArray<LocationSettingsModel>();
    }
  }

  protected virtual Func<IDatabaseSaveModel> CreateNewFunc
  {
    get
    {
      return (Func<IDatabaseSaveModel>) (() => (IDatabaseSaveModel) ObjectFactory.Instance.CreateObjectAs<ILocationSettingsModel>((object) this._locationSettingsRepository));
    }
  }

  protected virtual IExcelExporter ExcelExporter => (IExcelExporter) null;

  protected virtual IDataGridDisplaySettings ListDisplaySettings
  {
    get
    {
      return (IDataGridDisplaySettings) new DataGridDisplaySettings(new IDisplayColumnSettings[3]
      {
        (IDisplayColumnSettings) new DisplayColumn("QuotingOfficeName", 150, "Quoting Office", typeof (string), (Func<IMvcModel, string>) (locationSettings => (locationSettings as ILocationSettingsModel).QuotingOfficeName)),
        (IDisplayColumnSettings) new DisplayColumn("ClaimsOfficeName", 150, "Claims Office", typeof (string), (Func<IMvcModel, string>) (locationSettings => (locationSettings as ILocationSettingsModel).ClaimsOfficeName)),
        (IDisplayColumnSettings) new DisplayColumn("GLAcctName", 150, "GL Offset Account", typeof (string), (Func<IMvcModel, string>) (locationSettings => (locationSettings as ILocationSettingsModel).GLAcctName))
      });
    }
  }

  protected virtual void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    ((Control) this).SuspendLayout();
    ((ContainerControl) this).AutoScaleDimensions = new SizeF(6f, 13f);
    ((ContainerControl) this).AutoScaleMode = AutoScaleMode.Font;
    ((Form) this).ClientSize = new Size(906, 409);
    ((Control) this).MaximumSize = new Size(1200, 448);
    ((Control) this).MinimumSize = new Size(922, 448);
    ((Control) this).Name = nameof (LocationSettingsForm);
    ((Form) this).ShowIcon = false;
    ((Control) this).Text = "Claims Location Settings";
    ((Control) this).ResumeLayout(false);
  }
}
