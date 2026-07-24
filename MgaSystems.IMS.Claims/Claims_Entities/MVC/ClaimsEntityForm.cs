// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.Claims_Entities.MVC.ClaimsEntityForm
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
using MGASystems.IMS.Claims.Claims_Entities.DataAccess;
using MGASystems.IMS.Claims.Claims_Entities.MVC.Controller;
using MGASystems.IMS.Claims.Claims_Entities.MVC.Model;
using MGASystems.IMS.Claims.Claims_Entities.MVC.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Claims.Claims_Entities.MVC;

public class ClaimsEntityForm : RecordEditorForm_Right
{
  private readonly IClaimsEntityRepository _claimsEntityRepository;
  private IContainer components;

  public ClaimsEntityForm(IClaimsEntityRepository repository)
  {
    this._claimsEntityRepository = repository;
    this.InitializeComponent();
    IClaimsEntityController objectAs = ObjectFactory.Instance.CreateObjectAs<IClaimsEntityController>();
    this.Setup((IMvcView) ObjectFactory.Instance.CreateObjectAs<IClaimsEntityView>(), (IMvcController) objectAs);
  }

  public ClaimsEntityForm()
    : this((IClaimsEntityRepository) new ClaimsEntityRepository())
  {
  }

  protected virtual IDatabaseSaveModel[] AllRecords
  {
    get
    {
      return (IDatabaseSaveModel[]) ((IEnumerable<ClaimsEntityDto>) ((IGetAllRepository<ClaimsEntityDto, Guid>) this._claimsEntityRepository).GetAll()).Select<ClaimsEntityDto, ClaimsEntityModel>((Func<ClaimsEntityDto, ClaimsEntityModel>) (x => ObjectFactory.Instance.CreateObjectAs<ClaimsEntityModel>((object) x, (object) this._claimsEntityRepository))).ToArray<ClaimsEntityModel>();
    }
  }

  protected virtual Func<IDatabaseSaveModel> CreateNewFunc
  {
    get
    {
      return (Func<IDatabaseSaveModel>) (() => (IDatabaseSaveModel) ObjectFactory.Instance.CreateObjectAs<IClaimsEntityModel>((object) this._claimsEntityRepository));
    }
  }

  protected virtual IExcelExporter ExcelExporter => (IExcelExporter) null;

  protected virtual IDataGridDisplaySettings ListDisplaySettings
  {
    get
    {
      return (IDataGridDisplaySettings) new DataGridDisplaySettings(new IDisplayColumnSettings[4]
      {
        (IDisplayColumnSettings) new DisplayColumn("EntityName", 150, "Entity Name", typeof (string), (Func<IMvcModel, string>) (claimEntity => (claimEntity as IClaimsEntityModel).EntityName)),
        (IDisplayColumnSettings) new DisplayColumn("Address1", 150, "Address", typeof (string), (Func<IMvcModel, string>) (claimEntity => (claimEntity as IClaimsEntityModel).Address.Address1.ToString())),
        (IDisplayColumnSettings) new DisplayColumn("City", 100, "City", typeof (string), (Func<IMvcModel, string>) (claimEntity => (claimEntity as IClaimsEntityModel).Address.City.ToString())),
        (IDisplayColumnSettings) new DisplayColumn("State", 50, "State", typeof (string), (Func<IMvcModel, string>) (claimEntity => (claimEntity as IClaimsEntityModel).Address.State.ToString()))
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
    ((ContainerControl) this).AutoScaleDimensions = new SizeF(8f, 16f);
    ((ContainerControl) this).AutoScaleMode = AutoScaleMode.Font;
    ((Form) this).ClientSize = new Size(1229, 609);
    ((Form) this).Margin = new Padding(5, 5, 5, 5);
    ((Control) this).MaximumSize = new Size(1245, 648);
    ((Control) this).Name = nameof (ClaimsEntityForm);
    ((Control) this).Text = "Claims Entity Management";
    ((Control) this).ResumeLayout(false);
  }
}
