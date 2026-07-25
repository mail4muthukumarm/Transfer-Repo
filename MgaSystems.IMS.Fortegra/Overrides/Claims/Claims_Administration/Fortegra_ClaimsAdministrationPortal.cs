// Decompiled with JetBrains decompiler
// Type: MgaSystems.Ims.Fortegra.Overrides.Claims.Claims_Administration.Fortegra_ClaimsAdministrationPortal
// Assembly: MgaSystems.Ims.Fortegra, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27007E94-85B4-4A1A-9444-255CCA5487B0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Fortegra.dll

using Infragistics.Shared;
using Infragistics.Win.UltraWinGrid;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Accounting.Services;
using MGASystems.IMS.Claims;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

#nullable disable
namespace MgaSystems.Ims.Fortegra.Overrides.Claims.Claims_Administration;

[Override(typeof (ClaimsAdministrationPortal))]
public class Fortegra_ClaimsAdministrationPortal : ClaimsAdministrationPortal
{
  private bool _isInitializing;
  private IContainer components;

  public Fortegra_ClaimsAdministrationPortal() => this.SetInitializing(true);

  public override void LoadClaimsAdmistration()
  {
    base.LoadClaimsAdmistration();
    this.LoadReservePaymentTypes();
  }

  private void LoadReservePaymentTypes()
  {
    this.ClearReservePaymentTypesDataSet();
    DefaultDatabase.LoadDataTable((DataTable) this.dsClaimsAdministration1.ReservePaymentTypes, "dbo.Fortegra_spClaims_GetReservePaymentTypes");
  }

  private void ClearReservePaymentTypesDataSet()
  {
    if (this.dsClaimsAdministration1.ReservePaymentTypes.Rows.Count <= 0)
      return;
    this.dsClaimsAdministration1.ReservePaymentTypes.Clear();
  }

  public void FormatReservePaymentFlagsPanel()
  {
    if (this.gridView == null || !(((KeyedSubObjectBase) ((UltraGridBase) this.gridView).DisplayLayout.Bands[0]).Key == "ReservePaymentTypes"))
      return;
    ((UltraGridBase) this.gridView).DisplayLayout.Override.CellClickAction = (CellClickAction) 1;
    ((UltraGridBase) this.gridView).DisplayLayout.Bands[0].Columns["SystemDefined"].Width = 123;
    ((HeaderBase) ((UltraGridBase) this.gridView).DisplayLayout.Bands[0].Columns["SystemDefined"].Header).Caption = "System Defined";
    ((UltraGridBase) this.gridView).DisplayLayout.Bands[0].Columns["IsIndemnity"].Width = 101;
    ((HeaderBase) ((UltraGridBase) this.gridView).DisplayLayout.Bands[0].Columns["IsIndemnity"].Header).Caption = "Is Indemnity";
    ((UltraGridBase) this.gridView).DisplayLayout.Bands[0].Columns["IsExpense"].Width = 104;
    ((HeaderBase) ((UltraGridBase) this.gridView).DisplayLayout.Bands[0].Columns["IsExpense"].Header).Caption = "Is Expense";
    ((UltraGridBase) this.gridView).DisplayLayout.Bands[0].Columns["IsLegal"].Width = 92;
    ((HeaderBase) ((UltraGridBase) this.gridView).DisplayLayout.Bands[0].Columns["IsLegal"].Header).Caption = "Is Legal";
    ((UltraGridBase) this.gridView).DisplayLayout.Bands[0].Columns["IsMedical"].Width = 101;
    ((HeaderBase) ((UltraGridBase) this.gridView).DisplayLayout.Bands[0].Columns["IsMedical"].Header).Caption = "Is Medical";
    ((UltraGridBase) this.gridView).DisplayLayout.Bands[0].Columns["IsRecoveryType"].Width = (int) sbyte.MaxValue;
    ((HeaderBase) ((UltraGridBase) this.gridView).DisplayLayout.Bands[0].Columns["IsRecoveryType"].Header).Caption = "Is Recovery Type";
  }

  protected override void dbSaveUISingle_ClickedCancel(object sender, EventArgs e)
  {
    base.dbSaveUISingle_ClickedCancel(sender, e);
    this.LoadReservePaymentTypes();
    foreach (UltraGridRow row in ((UltraGridBase) this.gridView).Rows)
      row.Activation = (Activation) 1;
  }

  protected override void dbSaveUISingle_ClickedEdit(object sender, EventArgs e)
  {
    base.dbSaveUISingle_ClickedEdit(sender, e);
    RowsCollection rows = ((UltraGridBase) this.gridView).Rows;
    foreach (UltraGridRow ultraGridRow in rows != null ? ((IEnumerable<UltraGridRow>) rows).Where<UltraGridRow>((System.Func<UltraGridRow, bool>) (x => x != ((UltraGridBase) this.gridView).ActiveRow)) : (IEnumerable<UltraGridRow>) null)
      ultraGridRow.Activation = (Activation) 2;
    this.MakeActiveRowFlagsEditable();
    this.SetInitializing(false);
  }

  private void SetInitializing(bool isInitializing) => this._isInitializing = isInitializing;

  protected override void gridView_BeforeSelectChange(object sender, BeforeSelectChangeEventArgs e)
  {
    if (!this._isInitializing)
      return;
    base.gridView_BeforeSelectChange(sender, e);
  }

  private void MakeActiveRowFlagsEditable()
  {
    UltraGridRow activeRow = ((UltraGridBase) this.gridView).ActiveRow;
    if (activeRow.Field<bool>("SystemDefined"))
      return;
    foreach (UltraGridCell cell in activeRow.Cells)
    {
      if (!(((KeyedSubObjectBase) cell.Column).Key == "SystemDefined"))
        cell.IgnoreRowColActivation = true;
    }
  }

  protected override void AddReservePaymentType()
  {
    UltraGridRow activeRow = ((UltraGridBase) this.gridView).ActiveRow;
    try
    {
      if (this._DBSaveUIState == ClaimsAdministrationPortal.DBSaveUIState.Adding)
        DefaultDatabase.ExecuteNonQuery("dbo.spClaims_InsertReservePaymentType", new object[2]
        {
          (object) "@ResPayTypeDescription",
          (object) ((Control) this.textOneText1).Text
        });
      else if (this._DBSaveUIState == ClaimsAdministrationPortal.DBSaveUIState.Editing)
        DefaultDatabase.ExecuteNonQuery("dbo.Fortegra_spClaims_UpdateReservePaymentType", new object[16 /*0x10*/]
        {
          (object) "@ResPayTypeId",
          (object) activeRow.Field<int>("ResPayTypeId"),
          (object) "@ResPayTypeDescription",
          (object) activeRow.Field<string>("ResPayTypeDescription"),
          (object) "@ResPayTypeSystemDefined",
          (object) activeRow.Field<bool>("SystemDefined"),
          (object) "@ResPayTypeIsIndemnity",
          (object) activeRow.Field<bool>("IsIndemnity"),
          (object) "@ResPayTypeIsExpense",
          (object) activeRow.Field<bool>("IsExpense"),
          (object) "@ResPayTypeIsLegal",
          (object) activeRow.Field<bool>("IsLegal"),
          (object) "@ResPayTypeIsMedical",
          (object) activeRow.Field<bool>("IsMedical"),
          (object) "@ResPayTypeIsRecoveryType",
          (object) activeRow.Field<bool>("IsRecoveryType")
        });
      this.FinalizeDatabaseOperation((DataTable) this.dsClaimsAdministration1.ReservePaymentTypes);
    }
    finally
    {
      this.SetDBSaveUIState(ClaimsAdministrationPortal.DBSaveUIState.None);
      this.ClearSingleUIBindings();
      this.ClearSingleView();
      this.InitUIEnabled();
      this.BindUI();
    }
  }

  protected override void Delete()
  {
    UltraGridRow activeRow = ((UltraGridBase) this.gridView).ActiveRow;
    if (this.PortalType == ClaimsAdministrationPortal.AdministrationPortalType.ReservePaymentTypes)
      this.DeleteReservePaymentType(activeRow.Field<int>("ResPayTypeId"), activeRow.Field<string>("ResPayTypeDescription"));
    else
      base.Delete();
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    this.AutoScaleMode = AutoScaleMode.Font;
    this.Text = "Form1";
  }
}
