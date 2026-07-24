// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.ClaimsAuditUser.ActiveUserGridController
// Assembly: MgaSystems.IMS.Claims, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FCD9D0B7-28CF-40B9-8EB7-297871E1AF5F
// Assembly location: F:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims.dll

using Infragistics.Win.UltraWinGrid;
using MGASystems.IMS.Accounting.Services.Forms.MVC.EditDataGridControl.View.GridDisplaySettings.Columns;
using MGASystems.IMS.Accounting.Services.Forms.MVC.WrappedUltraGridControl.Controller;
using MGASystems.IMS.Accounting.Services.Forms.MVC.WrappedUltraGridControl.Model;
using MGASystems.IMS.Accounting.Services.Forms.MVC.WrappedUltraGridControl.View;
using MGASystems.IMS.Accounting.Services.InfragisticsWrappers.GridDisplaySettings;
using MGASystems.IMS.Accounting.Services.InfragisticsWrappers.GridDisplaySettings.Addons.Filter;
using MGASystems.IMS.Accounting.Services.InfragisticsWrappers.GridDisplaySettings.Columns.BaseClasses;
using MGASystems.IMS.Claims.DataAccess.ActiveUser;
using System;
using System.Drawing;

#nullable disable
namespace MGASystems.IMS.Claims.ClaimsAuditUser;

public class ActiveUserGridController : 
  WrappedUltraGridController<ActiveUserDto, BasicUltraGridDataModel<ActiveUserDto>, IWrappedUltraGridView>
{
  protected virtual IUltraGridAdapter<ActiveUserDto> ChildCreateGridAdapter()
  {
    return (IUltraGridAdapter<ActiveUserDto>) new UltraGridSettingsAdapter<ActiveUserDto>((IUltraGridTableSettings<ActiveUserDto>) new UltraGridTableSettings<ActiveUserDto>(new IUltraGridColumnSettings<ActiveUserDto>[1]
    {
      (IUltraGridColumnSettings<ActiveUserDto>) new TextReadOnlyColumn<ActiveUserDto>("User Name", 100, (Func<ActiveUserDto, object>) (user => (object) user.Name), (Func<ActiveUserDto, Color>) null)
    })
    {
      FilterAdapter = new UltraGridFilterAdapter<ActiveUserDto>((FilterLogicalOperator) 0, true)
    });
  }
}
