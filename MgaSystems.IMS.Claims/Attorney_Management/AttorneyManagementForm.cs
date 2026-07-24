// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.Attorney_Management.AttorneyManagementForm
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
namespace MGASystems.IMS.Claims.Attorney_Management;

public class AttorneyManagementForm : RecordEditorForm_Right
{
  private readonly IAttorneyManagementRepository _attorneyManagementRepository;
  private IContainer components;

  public AttorneyManagementForm(IAttorneyManagementRepository repository)
  {
    this._attorneyManagementRepository = repository;
    this.InitializeComponent();
    IAttorneyManagementController objectAs = ObjectFactory.Instance.CreateObjectAs<IAttorneyManagementController>();
    this.Setup((IMvcView) ObjectFactory.Instance.CreateObjectAs<IAttorneyManagementView>(), (IMvcController) objectAs);
  }

  public AttorneyManagementForm()
    : this((IAttorneyManagementRepository) new AttorneyManagementRepository())
  {
  }

  protected virtual IDatabaseSaveModel[] AllRecords
  {
    get
    {
      return (IDatabaseSaveModel[]) ((IEnumerable<AttorneyManagementDto>) ((IGetAllRepository<AttorneyManagementDto, Guid>) this._attorneyManagementRepository).GetAll()).Select<AttorneyManagementDto, AttorneyManagementModel>((Func<AttorneyManagementDto, AttorneyManagementModel>) (x => ObjectFactory.Instance.CreateObjectAs<AttorneyManagementModel>((object) x, (object) this._attorneyManagementRepository))).ToArray<AttorneyManagementModel>();
    }
  }

  protected virtual Func<IDatabaseSaveModel> CreateNewFunc
  {
    get
    {
      return (Func<IDatabaseSaveModel>) (() => (IDatabaseSaveModel) ObjectFactory.Instance.CreateObjectAs<IAttorneyManagementModel>((object) this._attorneyManagementRepository));
    }
  }

  protected virtual IExcelExporter ExcelExporter => (IExcelExporter) null;

  protected virtual IDataGridDisplaySettings ListDisplaySettings
  {
    get
    {
      return (IDataGridDisplaySettings) new DataGridDisplaySettings(new IDisplayColumnSettings[5]
      {
        (IDisplayColumnSettings) new DisplayColumn("LawFirm", 150, "Law Firm", typeof (string), (Func<IMvcModel, string>) (attorneyManagement => (attorneyManagement as IAttorneyManagementModel).LawFirm)),
        (IDisplayColumnSettings) new DisplayColumn("AttorneyName", 150, "Attorney Name", typeof (string), (Func<IMvcModel, string>) (attorneyManagement => (attorneyManagement as IAttorneyManagementModel).AttorneyName)),
        (IDisplayColumnSettings) new DisplayColumn("Address1", 150, "Address", typeof (string), (Func<IMvcModel, string>) (attorneyManagement => (attorneyManagement as IAttorneyManagementModel).Address.Address1.ToString())),
        (IDisplayColumnSettings) new DisplayColumn("City", 100, "City", typeof (string), (Func<IMvcModel, string>) (attorneyManagement => (attorneyManagement as IAttorneyManagementModel).Address.City.ToString())),
        (IDisplayColumnSettings) new DisplayColumn("State", 50, "State", typeof (string), (Func<IMvcModel, string>) (attorneyManagement => (attorneyManagement as IAttorneyManagementModel).Address.State.ToString()))
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
    ((Form) this).ClientSize = new Size(902, 446);
    ((Control) this).Name = nameof (AttorneyManagementForm);
    ((Form) this).ShowIcon = false;
    ((Control) this).Text = "Attorney Management";
    ((Control) this).ResumeLayout(false);
  }
}
