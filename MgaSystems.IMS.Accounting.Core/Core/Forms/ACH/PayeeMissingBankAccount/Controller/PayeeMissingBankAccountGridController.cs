// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.Forms.ACH.PayeeMissingBankAccount.Controller.PayeeMissingBankAccountGridController
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using MGASystems.Common.MVC.BaseClasses.Controller;
using MGASystems.IMS.Accounting.Core.Forms.ACH.PayeeMissingBankAccount.DataAccess;
using MGASystems.IMS.Accounting.Core.Forms.ACH.PayeeMissingBankAccount.Model;
using MGASystems.IMS.Accounting.Core.Properties;
using MGASystems.IMS.Accounting.Services.Forms.MVC.EditDataGridControl.View.GridDisplaySettings.Columns;
using MGASystems.IMS.Accounting.Services.Forms.MVC.ToolbarEdit;
using MGASystems.IMS.Accounting.Services.Forms.MVC.ToolbarEdit.ParentFormSettingsOptions;
using MGASystems.IMS.Accounting.Services.Forms.MVC.WrappedUltraGridControl.Controller;
using MGASystems.IMS.Accounting.Services.Forms.MVC.WrappedUltraGridControl.View;
using MGASystems.IMS.Accounting.Services.InfragisticsWrappers.GridDisplaySettings;
using MGASystems.IMS.Accounting.Services.InfragisticsWrappers.GridDisplaySettings.Columns.BaseClasses;
using MGASystems.IMS.Accounting.Services.InfragisticsWrappers.UltraToolBarSettings;
using MGASystems.IMS.Accounting.Services.InfragisticsWrappers.UltraToolBarSettings.BaseClasses;
using System;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.Forms.ACH.PayeeMissingBankAccount.Controller;

public class PayeeMissingBankAccountGridController : 
  WrappedUltraGridController<PayeeMissingBankAccountDto, PayeeMissingBankAccountGridModel, IWrappedUltraGridView>,
  ITopControlController,
  IMvcController
{
  public IParentFormSettings ParentFormSettings
  {
    get
    {
      return (IParentFormSettings) new MGASystems.IMS.Accounting.Services.Forms.MVC.ToolbarEdit.ParentFormSettings()
      {
        Width = 500,
        Height = 500,
        Name = "Payees Missing Bank Accounts",
        BorderStyle = FormBorderStyle.Sizable,
        Maximizeable = true,
        ShortcutActions = new ShortcutAction[3]
        {
          ShortcutAction.CreateSave(new Action(this.Select)),
          ShortcutAction.CreateReset(new Action(this.Cancel)),
          ShortcutAction.CreateCancel((Action) (() => this.View.RequestCloseForm(DialogResult.Abort)))
        }
      };
    }
  }

  public IToolbarItem[] GetToolBarItems()
  {
    return new IToolbarItem[2]
    {
      (IToolbarItem) new ToolbarGroup(new IToolbarControl[1]
      {
        (IToolbarControl) new ButtonToolbarControl("Select", new Action(this.Select), (object) Resources.page_white_excel)
      }),
      (IToolbarItem) new ToolbarGroup(new IToolbarControl[1]
      {
        (IToolbarControl) new ButtonToolbarControl("Cancel", new Action(this.Cancel), (object) Resources.cross)
      })
    };
  }

  private void Cancel() => this.View.RequestCloseForm(DialogResult.Abort);

  private void Select()
  {
    try
    {
      this.Model.Selected = (PayeeMissingBankAccountDto) this.GridAdapter.SelectedObjectInGrid;
    }
    catch
    {
      this.Model.Selected = (PayeeMissingBankAccountDto) null;
      this.View.DisplayOkMessageBox("Must make a selection", "No Selection", MessageBoxIcon.Exclamation);
      return;
    }
    this.View.RequestCloseForm(DialogResult.OK);
  }

  protected override IUltraGridAdapter<PayeeMissingBankAccountDto> ChildCreateGridAdapter()
  {
    return (IUltraGridAdapter<PayeeMissingBankAccountDto>) new UltraGridSettingsAdapter<PayeeMissingBankAccountDto>((IUltraGridTableSettings<PayeeMissingBankAccountDto>) new UltraGridTableSettings<PayeeMissingBankAccountDto>(new IUltraGridColumnSettings<PayeeMissingBankAccountDto>[4]
    {
      (IUltraGridColumnSettings<PayeeMissingBankAccountDto>) new TextReadOnlyColumn<PayeeMissingBankAccountDto>("Payee", 200, (Func<PayeeMissingBankAccountDto, object>) (dto => (object) dto.Name)),
      (IUltraGridColumnSettings<PayeeMissingBankAccountDto>) new TextReadOnlyColumn<PayeeMissingBankAccountDto>("Entity Type", 100, (Func<PayeeMissingBankAccountDto, object>) (dto => (object) dto.EntityTypeName ?? (object) "Unknown")),
      (IUltraGridColumnSettings<PayeeMissingBankAccountDto>) new TextReadOnlyColumn<PayeeMissingBankAccountDto>("Claim Number", 100, (Func<PayeeMissingBankAccountDto, object>) (dto => (object) dto.ClaimNumber)),
      (IUltraGridColumnSettings<PayeeMissingBankAccountDto>) new TextReadOnlyColumn<PayeeMissingBankAccountDto>("Insured Payee", 200, (Func<PayeeMissingBankAccountDto, object>) (dto => (object) dto.InsuredName ?? (object) string.Empty))
    }));
  }
}
