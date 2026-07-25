// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Underwriting.Bulk_Renewal_Utility.FormBulkRenewalUtility
// Assembly: MGASystems.IMS.Underwriting, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1057C5B8-8299-4767-8242-AF9F1EF932DB
// Assembly location: D:\augusta\fortegra\IMS Project\MGASystems.IMS.Underwriting.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using MGASystems.Common;
using MGASystems.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Underwriting.Bulk_Renewal_Utility;

[SecureResource("{7C044B89-3BEC-4012-BE26-4D78DDA7E18D}", "Access Bulk Renewal Utility", "Allows the Bulk Renewal Utility", "Policy")]
public class FormBulkRenewalUtility : FormBase
{
  public const string CanAccessBulkRenewalUtility = "{7C044B89-3BEC-4012-BE26-4D78DDA7E18D}";
  private IContainer components;
  private DataTable dataTable4;
  private DataTable dataTable7;
  private DataTable dataTable8;
  private DataTable dataTable6;
  private DataTable dataTable5;
  private DataTable dataTable9;
  private ErrorProvider err;
  protected UltraLabel ultraLabel4;
  protected UltraLabel lblExpirationDate;
  protected UltraLabel lblProducers;
  protected UltraButton btnSearch;
  protected UltraButton btnCancel;
  protected UltraLabel lblLine;
  protected UltraLabel lblOffice;
  protected UltraLabel lblDepartment;
  protected UltraLabel lblTotalPremium;
  protected UltraLabel ultraLabel2;
  protected UltraLabel lblMinPremium;
  protected UltraLabel lblIHProducer;
  protected UltraLabel lblTACSR;
  protected UltraLabel lblUnderwriter;
  protected UltraLabel lblCompanyGroup;
  protected UltraLabel lblLocations;
  private DataTable dataTable3;
  private DataTable dataTable2;
  private DataTable dataTable1;
  protected DataSet dsConstraints;
  protected UltraComboEditor ddlIHProducer;
  protected UltraDateTimeEditor dtFrom;
  protected UltraComboEditor ddlTACSR;
  protected UltraComboEditor ddlUnderwriter;
  protected UltraComboEditor ddlLine;
  protected UltraComboEditor ddlOffice;
  protected UltraComboEditor ddlDepartment;
  protected UltraComboEditor ddlGroups;
  protected UltraComboEditor ddlLocations;
  protected UltraGrid ugProducers;
  protected UltraDateTimeEditor dtTo;
  protected UltraCheckEditor chkIncNonRenewal;
  protected UltraCurrencyEditor curPremiumTo;
  protected UltraCurrencyEditor curPremiumFrom;
  protected UltraCurrencyEditor curMinPremium;

  protected DataTable Producers
  {
    get
    {
      return this.dsConstraints.Tables.Count > 0 ? this.dsConstraints.Tables[nameof (Producers)] ?? this.dsConstraints.Tables[0] : (DataTable) null;
    }
  }

  protected virtual string StoredProcedure
  {
    get
    {
      return MGASystems.Common.Settings.SystemSettings.GetSetting<string>("BulkRenewal.Override.ProcName", "dbo.spGetBulkRenewalUtilityList");
    }
  }

  public FormBulkRenewalUtility() => this.InitializeComponent();

  private void frmBulkRenewalTool_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    this.FillSelectionCriteria(this.dsConstraints);
  }

  private void btnCancel_Click(object sender, EventArgs e)
  {
    this.DialogResult = DialogResult.Cancel;
    this.Close();
  }

  private void btnSearch_Click(object sender, EventArgs e)
  {
    if (!this.ValidateInputs())
      return;
    List<object> parameterArray = this.GetParameterArray();
    frmPleaseWaitMessage waitScreen = new frmPleaseWaitMessage("Searching for renewal candidates...");
    waitScreen.StartPosition = FormStartPosition.CenterScreen;
    waitScreen.TopMost = true;
    waitScreen.Show();
    try
    {
      Utility.ExecuteThread((object) parameterArray, new DoWorkEventHandler(this.GetRenewals), (RunWorkerCompletedEventHandler) ((objbw, wcargs) =>
      {
        waitScreen.Close();
        waitScreen = (frmPleaseWaitMessage) null;
        if (wcargs.Result == null)
          return;
        FormSettings.ShowForm(typeof (FormBulkRenewal), wcargs.Result);
        this.Close();
      }), (ProgressChangedEventHandler) null);
    }
    catch (Exception ex)
    {
      string message = ex.Message;
    }
  }

  private void ugProducers_CellChange(object sender, CellEventArgs e)
  {
    this.ugProducers.PerformAction((UltraGridAction) 44);
    this.ugProducers.PerformAction((UltraGridAction) 47);
    if (e.Cell.Row.Index == 0)
    {
      bool flag = (bool) e.Cell.Value;
      for (int index = 1; index < this.Producers.Rows.Count; ++index)
        this.Producers.Rows[index].SetField<bool>("Selected", flag);
    }
    else
      this.Producers.Rows[0].SetField<bool>("Selected", this.Producers.Select("ProducerGUID IS NOT NULL AND Selected = 1").Length >= this.Producers.Rows.Count - 1);
  }

  public bool ValidateInputs()
  {
    if (this.Producers.Select("Selected = 1").Length <= 200 || this.Producers.Rows[0].Field<bool>("Selected"))
      return true;
    this.err.SetError((Control) this.ugProducers, "Cannot have more than 200 producers selected unless 'All Producers' is selected.");
    return false;
  }

  protected void AddParameterFromCombo(List<object> listTo, UltraComboEditor control, string param)
  {
    if (control.SelectedItem == null || ((TextEditorControlBase) control).Value == null || ((TextEditorControlBase) control).Value == DBNull.Value)
      return;
    listTo.Add((object) param);
    listTo.Add(((TextEditorControlBase) control).Value);
  }

  protected void AddParameterValue(List<object> listObj, string parameter, object value)
  {
    listObj.Add((object) parameter);
    listObj.Add(value);
  }

  protected virtual void GetRenewals(object senderbw, DoWorkEventArgs dwargs)
  {
    List<object> objectList = new List<object>();
    if (this.Producers.Rows.Count > 0 && !this.Producers.Rows[0].Field<bool>("Selected"))
    {
      string str = string.Join(",", this.Producers.AsEnumerable().Where<DataRow>((System.Func<DataRow, bool>) (dr => dr.Field<bool>("Selected"))).Select<DataRow, string>((System.Func<DataRow, string>) (tr => tr.Field<Guid>("ProducerGUID").ToString())).ToArray<string>());
      objectList.AddRange((IEnumerable<object>) new object[2]
      {
        (object) "@ProducerGuids",
        (object) str
      });
    }
    objectList.AddRange((IEnumerable<object>) new object[2]
    {
      (object) "@DateFrom",
      (object) this.dtFrom.DateTime
    });
    objectList.AddRange((IEnumerable<object>) new object[2]
    {
      (object) "@DateTo",
      (object) this.dtTo.DateTime
    });
    objectList.AddRange((IEnumerable<object>) new object[2]
    {
      (object) "@IncludeNonRenewed",
      (object) ((UltraToggleEditorBase) this.chkIncNonRenewal).Checked
    });
    objectList.AddRange((IEnumerable<object>) new object[2]
    {
      (object) "@premium",
      (object) this.curMinPremium.Value
    });
    objectList.AddRange((IEnumerable<object>) new object[2]
    {
      (object) "@totalpremiumfrom",
      (object) this.curPremiumFrom.Value
    });
    objectList.AddRange((IEnumerable<object>) new object[2]
    {
      (object) "@totalpremiumto",
      (object) this.curPremiumTo.Value
    });
    objectList.AddRange((IEnumerable<object>) new object[2]
    {
      (object) "@HideRenewals",
      (object) true
    });
    if (this.ddlLocations.SelectedItem != null && ((TextEditorControlBase) this.ddlLocations).Value != null && ((TextEditorControlBase) this.ddlLocations).Value != DBNull.Value)
      objectList.AddRange((IEnumerable<object>) new object[2]
      {
        (object) "@CompanyLocationGuid",
        ((TextEditorControlBase) this.ddlLocations).Value
      });
    if (this.ddlGroups.SelectedItem != null && ((TextEditorControlBase) this.ddlGroups).Value != null && ((TextEditorControlBase) this.ddlGroups).Value != DBNull.Value)
      objectList.AddRange((IEnumerable<object>) new object[2]
      {
        (object) "@CompanyGroupGuid",
        ((TextEditorControlBase) this.ddlGroups).Value
      });
    if (this.ddlDepartment.SelectedItem != null && ((TextEditorControlBase) this.ddlDepartment).Value != null && ((TextEditorControlBase) this.ddlDepartment).Value != DBNull.Value)
      objectList.AddRange((IEnumerable<object>) new object[2]
      {
        (object) "@CostCenterID",
        ((TextEditorControlBase) this.ddlDepartment).Value
      });
    if (this.ddlOffice.SelectedItem != null && ((TextEditorControlBase) this.ddlOffice).Value != null && ((TextEditorControlBase) this.ddlOffice).Value != DBNull.Value)
      objectList.AddRange((IEnumerable<object>) new object[2]
      {
        (object) "@ClientOfficeGuid",
        ((TextEditorControlBase) this.ddlOffice).Value
      });
    if (this.ddlLine.SelectedItem != null && ((TextEditorControlBase) this.ddlLine).Value != null && ((TextEditorControlBase) this.ddlLine).Value != DBNull.Value)
      objectList.AddRange((IEnumerable<object>) new object[2]
      {
        (object) "@LineGUID",
        ((TextEditorControlBase) this.ddlLine).Value
      });
    if (this.ddlUnderwriter.SelectedItem != null && ((TextEditorControlBase) this.ddlUnderwriter).Value != null && ((TextEditorControlBase) this.ddlUnderwriter).Value != DBNull.Value)
      objectList.AddRange((IEnumerable<object>) new object[2]
      {
        (object) "@UnderwriterGuid",
        ((TextEditorControlBase) this.ddlUnderwriter).Value
      });
    if (this.ddlTACSR.SelectedItem != null && ((TextEditorControlBase) this.ddlTACSR).Value != null && ((TextEditorControlBase) this.ddlTACSR).Value != DBNull.Value)
      objectList.AddRange((IEnumerable<object>) new object[2]
      {
        (object) "@TACSRUserGuid",
        ((TextEditorControlBase) this.ddlTACSR).Value
      });
    if (this.ddlIHProducer.SelectedItem != null && ((TextEditorControlBase) this.ddlIHProducer).Value != null && ((TextEditorControlBase) this.ddlIHProducer).Value != DBNull.Value)
      objectList.AddRange((IEnumerable<object>) new object[2]
      {
        (object) "@InHouseProducerGuid",
        ((TextEditorControlBase) this.ddlTACSR).Value
      });
    dsBulkRenewal.spGetBulkRenewalUtilityListDataTable utilityListDataTable = new dsBulkRenewal.spGetBulkRenewalUtilityListDataTable();
    DefaultDatabase.LoadDataTable((DataTable) utilityListDataTable, CommandType.StoredProcedure, this.StoredProcedure, 60, (CommandArgumentType) 0, objectList.ToArray());
    dwargs.Result = (object) utilityListDataTable;
  }

  protected virtual List<object> GetParameterArray()
  {
    List<object> parameterArray = new List<object>();
    if (this.Producers.Rows.Count > 0 && !this.Producers.Rows[0].Field<bool>("Selected"))
      this.AddParameterValue(parameterArray, "@ProducerGuids", (object) string.Join(",", this.Producers.AsEnumerable().Where<DataRow>((System.Func<DataRow, bool>) (dr => dr.Field<bool>("Selected"))).Select<DataRow, string>((System.Func<DataRow, string>) (tr => tr.Field<Guid>("ProducerGUID").ToString())).ToArray<string>()));
    this.AddParameterFromCombo(parameterArray, this.ddlLocations, "@CompanyLocationGuid");
    this.AddParameterFromCombo(parameterArray, this.ddlGroups, "@CompanyGroupGuid");
    this.AddParameterFromCombo(parameterArray, this.ddlDepartment, "@CostCenterID");
    this.AddParameterFromCombo(parameterArray, this.ddlOffice, "@ClientOfficeGuid");
    this.AddParameterFromCombo(parameterArray, this.ddlLine, "@LineGUID");
    this.AddParameterFromCombo(parameterArray, this.ddlUnderwriter, "@UnderwriterGuid");
    this.AddParameterFromCombo(parameterArray, this.ddlTACSR, "@TACSRUserGuid");
    this.AddParameterFromCombo(parameterArray, this.ddlIHProducer, "@InHouseProducerGuid");
    this.AddParameterValue(parameterArray, "@DateFrom", (object) this.dtFrom.DateTime);
    this.AddParameterValue(parameterArray, "@DateTo", (object) this.dtTo.DateTime);
    this.AddParameterValue(parameterArray, "@IncludeNonRenewed", (object) ((UltraToggleEditorBase) this.chkIncNonRenewal).Checked);
    this.AddParameterValue(parameterArray, "@Premium", (object) this.curMinPremium.Value);
    this.AddParameterValue(parameterArray, "@totalpremiumfrom", (object) this.curPremiumFrom.Value);
    this.AddParameterValue(parameterArray, "@totalpremiumto", (object) this.curPremiumTo.Value);
    this.AddParameterValue(parameterArray, "@HideRenewals", (object) true);
    return parameterArray;
  }

  protected virtual void FillSelectionCriteria(DataSet ds)
  {
    string[] array = ds.Tables.Cast<DataTable>().Select<DataTable, string>((System.Func<DataTable, string>) (tr => tr.TableName)).ToArray<string>();
    DefaultDatabase.LoadDataSet(ds, array, "spRenewals_GetSelectionCriteria");
    ((UltraGridBase) this.ugProducers).DataSource = (object) ds.Tables[0];
    this.ddlLocations.DataSource = (object) ds.Tables[1];
    this.ddlLocations.DisplayMember = "CompanyName";
    this.ddlLocations.ValueMember = "CompanyLocationGUID";
    this.ddlGroups.DataSource = (object) ds.Tables[2];
    this.ddlGroups.DisplayMember = "CompanyGroupName";
    this.ddlGroups.ValueMember = "CompanyGroupGUID";
    this.ddlUnderwriter.DataSource = (object) ds.Tables[3];
    this.ddlUnderwriter.DisplayMember = "UnderwriterName";
    this.ddlUnderwriter.ValueMember = "UnderwriterGUID";
    this.ddlTACSR.DataSource = (object) ds.Tables[4];
    this.ddlTACSR.DisplayMember = "TACSRName";
    this.ddlTACSR.ValueMember = "TACSRGUID";
    this.ddlLine.DataSource = (object) ds.Tables[5];
    this.ddlLine.DisplayMember = "LineName";
    this.ddlLine.ValueMember = "LineGUID";
    this.ddlDepartment.DataSource = (object) ds.Tables[6];
    this.ddlDepartment.DisplayMember = "GroupName";
    this.ddlDepartment.ValueMember = "GroupID";
    this.ddlOffice.DataSource = (object) ds.Tables[7];
    this.ddlOffice.DisplayMember = "OfficeName";
    this.ddlOffice.ValueMember = "OfficeGUID";
    this.ddlIHProducer.DataSource = (object) ds.Tables[8];
    this.ddlIHProducer.DisplayMember = "UserName";
    this.ddlIHProducer.ValueMember = "UserGUID";
    this.ddlLocations.SelectedIndex = this.ddlGroups.SelectedIndex = this.ddlUnderwriter.SelectedIndex = this.ddlTACSR.SelectedIndex = this.ddlLine.SelectedIndex = this.ddlDepartment.SelectedIndex = this.ddlDepartment.SelectedIndex = this.ddlOffice.SelectedIndex = this.ddlIHProducer.SelectedIndex = 0;
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
    Appearance appearance1 = new Appearance();
    UltraGridBand ultraGridBand = new UltraGridBand("Band 0", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("Selected");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("ProducerName");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("ProducerGUID", 0);
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("Sort", 1);
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    Appearance appearance17 = new Appearance();
    Appearance appearance18 = new Appearance();
    Appearance appearance19 = new Appearance();
    Appearance appearance20 = new Appearance();
    Appearance appearance21 = new Appearance();
    Appearance appearance22 = new Appearance();
    Appearance appearance23 = new Appearance();
    Appearance appearance24 = new Appearance();
    Appearance appearance25 = new Appearance();
    Appearance appearance26 = new Appearance();
    this.dataTable4 = new DataTable();
    this.ddlIHProducer = new UltraComboEditor();
    this.dataTable7 = new DataTable();
    this.dataTable8 = new DataTable();
    this.dtFrom = new UltraDateTimeEditor();
    this.ddlTACSR = new UltraComboEditor();
    this.ddlUnderwriter = new UltraComboEditor();
    this.dataTable6 = new DataTable();
    this.dataTable5 = new DataTable();
    this.ddlLine = new UltraComboEditor();
    this.ddlOffice = new UltraComboEditor();
    this.dataTable9 = new DataTable();
    this.ddlDepartment = new UltraComboEditor();
    this.err = new ErrorProvider(this.components);
    this.ddlGroups = new UltraComboEditor();
    this.ddlLocations = new UltraComboEditor();
    this.dataTable3 = new DataTable();
    this.ugProducers = new UltraGrid();
    this.ultraLabel4 = new UltraLabel();
    this.lblExpirationDate = new UltraLabel();
    this.lblProducers = new UltraLabel();
    this.dtTo = new UltraDateTimeEditor();
    this.btnSearch = new UltraButton();
    this.btnCancel = new UltraButton();
    this.chkIncNonRenewal = new UltraCheckEditor();
    this.curPremiumTo = new UltraCurrencyEditor();
    this.curPremiumFrom = new UltraCurrencyEditor();
    this.dataTable2 = new DataTable();
    this.curMinPremium = new UltraCurrencyEditor();
    this.lblLine = new UltraLabel();
    this.lblOffice = new UltraLabel();
    this.lblDepartment = new UltraLabel();
    this.lblTotalPremium = new UltraLabel();
    this.ultraLabel2 = new UltraLabel();
    this.lblMinPremium = new UltraLabel();
    this.dataTable1 = new DataTable();
    this.lblIHProducer = new UltraLabel();
    this.lblTACSR = new UltraLabel();
    this.dsConstraints = new DataSet();
    this.lblUnderwriter = new UltraLabel();
    this.lblCompanyGroup = new UltraLabel();
    this.lblLocations = new UltraLabel();
    this.dataTable4.BeginInit();
    ((ISupportInitialize) this.ddlIHProducer).BeginInit();
    this.dataTable7.BeginInit();
    this.dataTable8.BeginInit();
    ((ISupportInitialize) this.dtFrom).BeginInit();
    ((ISupportInitialize) this.ddlTACSR).BeginInit();
    ((ISupportInitialize) this.ddlUnderwriter).BeginInit();
    this.dataTable6.BeginInit();
    this.dataTable5.BeginInit();
    ((ISupportInitialize) this.ddlLine).BeginInit();
    ((ISupportInitialize) this.ddlOffice).BeginInit();
    this.dataTable9.BeginInit();
    ((ISupportInitialize) this.ddlDepartment).BeginInit();
    ((ISupportInitialize) this.err).BeginInit();
    ((ISupportInitialize) this.ddlGroups).BeginInit();
    ((ISupportInitialize) this.ddlLocations).BeginInit();
    this.dataTable3.BeginInit();
    ((ISupportInitialize) this.ugProducers).BeginInit();
    ((ISupportInitialize) this.dtTo).BeginInit();
    ((ISupportInitialize) this.chkIncNonRenewal).BeginInit();
    ((ISupportInitialize) this.curPremiumTo).BeginInit();
    ((ISupportInitialize) this.curPremiumFrom).BeginInit();
    this.dataTable2.BeginInit();
    ((ISupportInitialize) this.curMinPremium).BeginInit();
    this.dataTable1.BeginInit();
    this.dsConstraints.BeginInit();
    this.SuspendLayout();
    this.dataTable4.TableName = "Department";
    ((Control) this.ddlIHProducer).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.ddlIHProducer.DropDownStyle = (DropDownStyle) 1;
    ((Control) this.ddlIHProducer).Location = new Point(135, 320);
    ((Control) this.ddlIHProducer).Name = "ddlIHProducer";
    ((Control) this.ddlIHProducer).Size = new Size(550, 21);
    ((Control) this.ddlIHProducer).TabIndex = 42;
    this.dataTable7.TableName = "Underwriter";
    this.dataTable8.TableName = "TACSR";
    ((Control) this.dtFrom).Location = new Point(135, 351);
    ((Control) this.dtFrom).Name = "dtFrom";
    ((Control) this.dtFrom).Size = new Size(96 /*0x60*/, 21);
    ((Control) this.dtFrom).TabIndex = 49;
    ((Control) this.ddlTACSR).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.ddlTACSR.DropDownStyle = (DropDownStyle) 1;
    ((Control) this.ddlTACSR).Location = new Point(135, 289);
    ((Control) this.ddlTACSR).Name = "ddlTACSR";
    ((Control) this.ddlTACSR).Size = new Size(550, 21);
    ((Control) this.ddlTACSR).TabIndex = 43;
    ((Control) this.ddlUnderwriter).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.ddlUnderwriter.DropDownStyle = (DropDownStyle) 1;
    ((Control) this.ddlUnderwriter).Location = new Point(135, 258);
    ((Control) this.ddlUnderwriter).Name = "ddlUnderwriter";
    ((Control) this.ddlUnderwriter).Size = new Size(550, 21);
    ((Control) this.ddlUnderwriter).TabIndex = 40;
    this.dataTable6.TableName = "Line";
    this.dataTable5.TableName = "Office";
    ((Control) this.ddlLine).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.ddlLine.DropDownStyle = (DropDownStyle) 1;
    ((Control) this.ddlLine).Location = new Point(135, 227);
    ((Control) this.ddlLine).Name = "ddlLine";
    ((Control) this.ddlLine).Size = new Size(550, 21);
    ((Control) this.ddlLine).TabIndex = 41;
    ((Control) this.ddlOffice).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.ddlOffice.DropDownStyle = (DropDownStyle) 1;
    ((Control) this.ddlOffice).Location = new Point(135, 196);
    ((Control) this.ddlOffice).Name = "ddlOffice";
    ((Control) this.ddlOffice).Size = new Size(550, 21);
    ((Control) this.ddlOffice).TabIndex = 44;
    this.dataTable9.TableName = "IHProducer";
    ((Control) this.ddlDepartment).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.ddlDepartment.DropDownStyle = (DropDownStyle) 1;
    ((Control) this.ddlDepartment).Location = new Point(135, 165);
    ((Control) this.ddlDepartment).Name = "ddlDepartment";
    ((Control) this.ddlDepartment).Size = new Size(550, 21);
    ((Control) this.ddlDepartment).TabIndex = 47;
    this.err.ContainerControl = (ContainerControl) this;
    ((Control) this.ddlGroups).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.ddlGroups.DropDownStyle = (DropDownStyle) 1;
    ((Control) this.ddlGroups).Location = new Point(135, 134);
    ((Control) this.ddlGroups).Name = "ddlGroups";
    ((Control) this.ddlGroups).Size = new Size(550, 21);
    ((Control) this.ddlGroups).TabIndex = 46;
    ((Control) this.ddlLocations).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.ddlLocations.DropDownStyle = (DropDownStyle) 1;
    ((Control) this.ddlLocations).Location = new Point(135, 103);
    ((Control) this.ddlLocations).Name = "ddlLocations";
    ((Control) this.ddlLocations).Size = new Size(550, 21);
    ((Control) this.ddlLocations).TabIndex = 45;
    this.dataTable3.TableName = "Group";
    ((Control) this.ugProducers).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    ((AppearanceBase) appearance1).BackColor = SystemColors.Window;
    ((AppearanceBase) appearance1).BorderColor = SystemColors.InactiveCaption;
    ((UltraGridBase) this.ugProducers).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.ugProducers).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand.ColHeadersVisible = false;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn1.Header).VisiblePosition = 0;
    ultraGridColumn1.MaxWidth = 30;
    ultraGridColumn1.Width = 30;
    ultraGridColumn2.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn2.Header).VisiblePosition = 1;
    ultraGridColumn2.Width = 500;
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn3.Header).VisiblePosition = 2;
    ultraGridColumn3.Hidden = true;
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn4.Header).VisiblePosition = 3;
    ultraGridColumn4.Hidden = true;
    ultraGridColumn4.Width = 71;
    ultraGridBand.Columns.AddRange(new object[4]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4
    });
    ((UltraGridBase) this.ugProducers).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.ugProducers).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.ugProducers).DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance2).BackColor = SystemColors.ActiveBorder;
    ((AppearanceBase) appearance2).BackColor2 = SystemColors.ControlDark;
    ((AppearanceBase) appearance2).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance2).BorderColor = SystemColors.Window;
    ((SpecialBoxBase) ((UltraGridBase) this.ugProducers).DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance2;
    ((AppearanceBase) appearance3).ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.ugProducers).DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance3;
    ((SpecialBoxBase) ((UltraGridBase) this.ugProducers).DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    ((SpecialBoxBase) ((UltraGridBase) this.ugProducers).DisplayLayout.GroupByBox).Hidden = true;
    ((AppearanceBase) appearance4).BackColor = SystemColors.ControlLightLight;
    ((AppearanceBase) appearance4).BackColor2 = SystemColors.Control;
    ((AppearanceBase) appearance4).BackGradientStyle = (GradientStyle) 3;
    ((AppearanceBase) appearance4).ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.ugProducers).DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance4;
    ((UltraGridBase) this.ugProducers).DisplayLayout.MaxColScrollRegions = 1;
    ((UltraGridBase) this.ugProducers).DisplayLayout.MaxRowScrollRegions = 1;
    ((AppearanceBase) appearance5).BackColor = SystemColors.Window;
    ((AppearanceBase) appearance5).ForeColor = SystemColors.ControlText;
    ((UltraGridBase) this.ugProducers).DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance5;
    ((AppearanceBase) appearance6).BackColor = SystemColors.Highlight;
    ((AppearanceBase) appearance6).ForeColor = SystemColors.HighlightText;
    ((UltraGridBase) this.ugProducers).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance6;
    ((UltraGridBase) this.ugProducers).DisplayLayout.Override.AllowAddNew = (AllowAddNew) 2;
    ((UltraGridBase) this.ugProducers).DisplayLayout.Override.AllowColMoving = (AllowColMoving) 1;
    ((UltraGridBase) this.ugProducers).DisplayLayout.Override.AllowColSwapping = (AllowColSwapping) 1;
    ((UltraGridBase) this.ugProducers).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.ugProducers).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 2;
    ((UltraGridBase) this.ugProducers).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 2;
    ((AppearanceBase) appearance7).BackColor = SystemColors.Window;
    ((UltraGridBase) this.ugProducers).DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance7;
    ((AppearanceBase) appearance8).BorderColor = Color.Silver;
    ((AppearanceBase) appearance8).TextTrimming = (TextTrimming) 3;
    ((UltraGridBase) this.ugProducers).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance8;
    ((UltraGridBase) this.ugProducers).DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    ((UltraGridBase) this.ugProducers).DisplayLayout.Override.CellPadding = 0;
    ((AppearanceBase) appearance9).BackColor = SystemColors.Control;
    ((AppearanceBase) appearance9).BackColor2 = SystemColors.ControlDark;
    ((AppearanceBase) appearance9).BackGradientAlignment = (GradientAlignment) 1;
    ((AppearanceBase) appearance9).BackGradientStyle = (GradientStyle) 3;
    ((AppearanceBase) appearance9).BorderColor = SystemColors.Window;
    ((UltraGridBase) this.ugProducers).DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance9;
    ((AppearanceBase) appearance10).TextHAlignAsString = "Left";
    ((UltraGridBase) this.ugProducers).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance10;
    ((UltraGridBase) this.ugProducers).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    ((UltraGridBase) this.ugProducers).DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    ((AppearanceBase) appearance11).BackColor = SystemColors.Window;
    ((AppearanceBase) appearance11).BorderColor = Color.Silver;
    ((UltraGridBase) this.ugProducers).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance11;
    ((UltraGridBase) this.ugProducers).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance12).BackColor = SystemColors.ControlLight;
    ((UltraGridBase) this.ugProducers).DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance12;
    ((UltraGridBase) this.ugProducers).DisplayLayout.Scrollbars = (Scrollbars) 2;
    ((UltraGridBase) this.ugProducers).DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    ((UltraGridBase) this.ugProducers).DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    ((UltraGridBase) this.ugProducers).DisplayLayout.ViewStyleBand = (ViewStyleBand) 2;
    ((Control) this.ugProducers).Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.ugProducers).Location = new Point(136, 13);
    ((Control) this.ugProducers).Name = "ugProducers";
    ((Control) this.ugProducers).Size = new Size(549, 80 /*0x50*/);
    ((Control) this.ugProducers).TabIndex = 39;
    this.ugProducers.CellChange += new CellEventHandler(this.ugProducers_CellChange);
    ((AppearanceBase) appearance13).BackColorAlpha = (Alpha) 3;
    ((ControlBase) this.ultraLabel4).Appearance = (AppearanceBase) appearance13;
    ((Control) this.ultraLabel4).Location = new Point(237, 355);
    ((Control) this.ultraLabel4).Name = "ultraLabel4";
    ((Control) this.ultraLabel4).Size = new Size(19, 18);
    ((Control) this.ultraLabel4).TabIndex = 22;
    ((Control) this.ultraLabel4).Text = "to";
    ((AppearanceBase) appearance14).BackColorAlpha = (Alpha) 3;
    ((ControlBase) this.lblExpirationDate).Appearance = (AppearanceBase) appearance14;
    ((Control) this.lblExpirationDate).Location = new Point(20, 355);
    ((Control) this.lblExpirationDate).Name = "lblExpirationDate";
    ((Control) this.lblExpirationDate).Size = new Size(110, 18);
    ((Control) this.lblExpirationDate).TabIndex = 25;
    ((Control) this.lblExpirationDate).Text = "Expiration Date";
    ((AppearanceBase) appearance15).BackColorAlpha = (Alpha) 3;
    ((ControlBase) this.lblProducers).Appearance = (AppearanceBase) appearance15;
    ((Control) this.lblProducers).Location = new Point(21, 13);
    ((Control) this.lblProducers).Name = "lblProducers";
    ((Control) this.lblProducers).Size = new Size(109, 19);
    ((Control) this.lblProducers).TabIndex = 24;
    ((Control) this.lblProducers).Text = "Producer(s)";
    ((Control) this.dtTo).Location = new Point(262, 351);
    ((Control) this.dtTo).Name = "dtTo";
    ((Control) this.dtTo).Size = new Size(96 /*0x60*/, 21);
    ((Control) this.dtTo).TabIndex = 48 /*0x30*/;
    ((Control) this.btnSearch).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    ((UltraButtonBase) this.btnSearch).DialogResult = DialogResult.Cancel;
    ((Control) this.btnSearch).Location = new Point(590, 445);
    ((Control) this.btnSearch).Name = "btnSearch";
    ((Control) this.btnSearch).Size = new Size(96 /*0x60*/, 23);
    ((Control) this.btnSearch).TabIndex = 37;
    ((Control) this.btnSearch).Text = "Search";
    ((Control) this.btnSearch).Click += new EventHandler(this.btnSearch_Click);
    ((Control) this.btnCancel).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    ((UltraButtonBase) this.btnCancel).DialogResult = DialogResult.Cancel;
    ((Control) this.btnCancel).Location = new Point(483, 445);
    ((Control) this.btnCancel).Name = "btnCancel";
    ((Control) this.btnCancel).Size = new Size(96 /*0x60*/, 23);
    ((Control) this.btnCancel).TabIndex = 38;
    ((Control) this.btnCancel).Text = "Cancel";
    ((Control) this.btnCancel).Click += new EventHandler(this.btnCancel_Click);
    ((Control) this.chkIncNonRenewal).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkIncNonRenewal).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkIncNonRenewal).CheckAlign = ContentAlignment.MiddleRight;
    ((Control) this.chkIncNonRenewal).Location = new Point(250, 379);
    ((Control) this.chkIncNonRenewal).Name = "chkIncNonRenewal";
    ((Control) this.chkIncNonRenewal).Size = new Size(160 /*0xA0*/, 29);
    ((Control) this.chkIncNonRenewal).TabIndex = 36;
    ((Control) this.chkIncNonRenewal).Text = "Include Non-Renewal Items";
    ((Control) this.curPremiumTo).Location = new Point(310, 414);
    ((Control) this.curPremiumTo).Name = "curPremiumTo";
    ((Control) this.curPremiumTo).Size = new Size(101, 21);
    ((Control) this.curPremiumTo).TabIndex = 35;
    ((Control) this.curPremiumFrom).Location = new Point(178, 414);
    ((Control) this.curPremiumFrom).Name = "curPremiumFrom";
    ((Control) this.curPremiumFrom).Size = new Size(101, 21);
    ((Control) this.curPremiumFrom).TabIndex = 34;
    this.dataTable2.TableName = "Locations";
    ((Control) this.curMinPremium).Location = new Point(136, 382);
    ((Control) this.curMinPremium).Name = "curMinPremium";
    ((Control) this.curMinPremium).Size = new Size(108, 21);
    ((Control) this.curMinPremium).TabIndex = 33;
    ((AppearanceBase) appearance16).BackColorAlpha = (Alpha) 3;
    ((ControlBase) this.lblLine).Appearance = (AppearanceBase) appearance16;
    ((Control) this.lblLine).Location = new Point(21, 231);
    ((Control) this.lblLine).Name = "lblLine";
    ((Control) this.lblLine).Size = new Size(109, 18);
    ((Control) this.lblLine).TabIndex = 21;
    ((Control) this.lblLine).Text = "Line";
    ((AppearanceBase) appearance17).BackColorAlpha = (Alpha) 3;
    ((ControlBase) this.lblOffice).Appearance = (AppearanceBase) appearance17;
    ((Control) this.lblOffice).Location = new Point(21, 200);
    ((Control) this.lblOffice).Name = "lblOffice";
    ((Control) this.lblOffice).Size = new Size(109, 18);
    ((Control) this.lblOffice).TabIndex = 23;
    ((Control) this.lblOffice).Text = "Issuing Office";
    ((AppearanceBase) appearance18).BackColorAlpha = (Alpha) 3;
    ((ControlBase) this.lblDepartment).Appearance = (AppearanceBase) appearance18;
    ((Control) this.lblDepartment).Location = new Point(21, 169);
    ((Control) this.lblDepartment).Name = "lblDepartment";
    ((Control) this.lblDepartment).Size = new Size(109, 18);
    ((Control) this.lblDepartment).TabIndex = 19;
    ((Control) this.lblDepartment).Text = "Department";
    ((AppearanceBase) appearance19).BackColorAlpha = (Alpha) 3;
    ((ControlBase) this.lblTotalPremium).Appearance = (AppearanceBase) appearance19;
    ((Control) this.lblTotalPremium).Location = new Point(20, 417);
    ((Control) this.lblTotalPremium).Name = "lblTotalPremium";
    ((Control) this.lblTotalPremium).Size = new Size(152, 18);
    ((Control) this.lblTotalPremium).TabIndex = 20;
    ((Control) this.lblTotalPremium).Text = "Total Account Premium from";
    ((AppearanceBase) appearance20).BackColorAlpha = (Alpha) 3;
    ((ControlBase) this.ultraLabel2).Appearance = (AppearanceBase) appearance20;
    ((Control) this.ultraLabel2).Location = new Point(285, 417);
    ((Control) this.ultraLabel2).Name = "ultraLabel2";
    ((Control) this.ultraLabel2).Size = new Size(19, 18);
    ((Control) this.ultraLabel2).TabIndex = 26;
    ((Control) this.ultraLabel2).Text = "to";
    ((AppearanceBase) appearance21).BackColorAlpha = (Alpha) 3;
    ((ControlBase) this.lblMinPremium).Appearance = (AppearanceBase) appearance21;
    ((Control) this.lblMinPremium).Location = new Point(20, 385);
    ((Control) this.lblMinPremium).Name = "lblMinPremium";
    ((Control) this.lblMinPremium).Size = new Size(106, 18);
    ((Control) this.lblMinPremium).TabIndex = 30;
    ((Control) this.lblMinPremium).Text = "Minimum Premium";
    this.dataTable1.TableName = "Producers";
    ((AppearanceBase) appearance22).BackColorAlpha = (Alpha) 3;
    ((ControlBase) this.lblIHProducer).Appearance = (AppearanceBase) appearance22;
    ((Control) this.lblIHProducer).Location = new Point(20, 324);
    ((Control) this.lblIHProducer).Name = "lblIHProducer";
    ((Control) this.lblIHProducer).Size = new Size(110, 18);
    ((Control) this.lblIHProducer).TabIndex = 31 /*0x1F*/;
    ((Control) this.lblIHProducer).Text = "In-House Producer";
    ((AppearanceBase) appearance23).BackColorAlpha = (Alpha) 3;
    ((ControlBase) this.lblTACSR).Appearance = (AppearanceBase) appearance23;
    ((Control) this.lblTACSR).Location = new Point(20, 293);
    ((Control) this.lblTACSR).Name = "lblTACSR";
    ((Control) this.lblTACSR).Size = new Size(110, 18);
    ((Control) this.lblTACSR).TabIndex = 32 /*0x20*/;
    ((Control) this.lblTACSR).Text = "TA/CSR";
    this.dsConstraints.DataSetName = "dsConstraints";
    this.dsConstraints.Tables.AddRange(new DataTable[9]
    {
      this.dataTable1,
      this.dataTable2,
      this.dataTable3,
      this.dataTable4,
      this.dataTable5,
      this.dataTable6,
      this.dataTable7,
      this.dataTable8,
      this.dataTable9
    });
    ((AppearanceBase) appearance24).BackColorAlpha = (Alpha) 3;
    ((ControlBase) this.lblUnderwriter).Appearance = (AppearanceBase) appearance24;
    ((Control) this.lblUnderwriter).Location = new Point(20, 262);
    ((Control) this.lblUnderwriter).Name = "lblUnderwriter";
    ((Control) this.lblUnderwriter).Size = new Size(110, 18);
    ((Control) this.lblUnderwriter).TabIndex = 27;
    ((Control) this.lblUnderwriter).Text = "Underwriter";
    ((AppearanceBase) appearance25).BackColorAlpha = (Alpha) 3;
    ((ControlBase) this.lblCompanyGroup).Appearance = (AppearanceBase) appearance25;
    ((Control) this.lblCompanyGroup).Location = new Point(20, 138);
    ((Control) this.lblCompanyGroup).Name = "lblCompanyGroup";
    ((Control) this.lblCompanyGroup).Size = new Size(110, 18);
    ((Control) this.lblCompanyGroup).TabIndex = 28;
    ((Control) this.lblCompanyGroup).Text = "Company Group";
    ((AppearanceBase) appearance26).BackColorAlpha = (Alpha) 3;
    ((ControlBase) this.lblLocations).Appearance = (AppearanceBase) appearance26;
    ((Control) this.lblLocations).Location = new Point(20, 107);
    ((Control) this.lblLocations).Name = "lblLocations";
    ((Control) this.lblLocations).Size = new Size(110, 18);
    ((Control) this.lblLocations).TabIndex = 29;
    ((Control) this.lblLocations).Text = "Company Locations";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(705, 476);
    this.Controls.Add((Control) this.ddlIHProducer);
    this.Controls.Add((Control) this.dtFrom);
    this.Controls.Add((Control) this.ddlTACSR);
    this.Controls.Add((Control) this.ddlUnderwriter);
    this.Controls.Add((Control) this.ddlLine);
    this.Controls.Add((Control) this.ddlOffice);
    this.Controls.Add((Control) this.ddlDepartment);
    this.Controls.Add((Control) this.ddlGroups);
    this.Controls.Add((Control) this.ddlLocations);
    this.Controls.Add((Control) this.ugProducers);
    this.Controls.Add((Control) this.ultraLabel4);
    this.Controls.Add((Control) this.lblExpirationDate);
    this.Controls.Add((Control) this.lblProducers);
    this.Controls.Add((Control) this.dtTo);
    this.Controls.Add((Control) this.btnSearch);
    this.Controls.Add((Control) this.btnCancel);
    this.Controls.Add((Control) this.chkIncNonRenewal);
    this.Controls.Add((Control) this.curPremiumTo);
    this.Controls.Add((Control) this.curPremiumFrom);
    this.Controls.Add((Control) this.curMinPremium);
    this.Controls.Add((Control) this.lblLine);
    this.Controls.Add((Control) this.lblOffice);
    this.Controls.Add((Control) this.lblDepartment);
    this.Controls.Add((Control) this.lblTotalPremium);
    this.Controls.Add((Control) this.ultraLabel2);
    this.Controls.Add((Control) this.lblMinPremium);
    this.Controls.Add((Control) this.lblIHProducer);
    this.Controls.Add((Control) this.lblTACSR);
    this.Controls.Add((Control) this.lblUnderwriter);
    this.Controls.Add((Control) this.lblCompanyGroup);
    this.Controls.Add((Control) this.lblLocations);
    this.FormBorderStyle = FormBorderStyle.Fixed3D;
    this.Name = nameof (FormBulkRenewalUtility);
    this.Text = "Bulk Renewals";
    this.Load += new EventHandler(this.frmBulkRenewalTool_Load);
    this.dataTable4.EndInit();
    ((ISupportInitialize) this.ddlIHProducer).EndInit();
    this.dataTable7.EndInit();
    this.dataTable8.EndInit();
    ((ISupportInitialize) this.dtFrom).EndInit();
    ((ISupportInitialize) this.ddlTACSR).EndInit();
    ((ISupportInitialize) this.ddlUnderwriter).EndInit();
    this.dataTable6.EndInit();
    this.dataTable5.EndInit();
    ((ISupportInitialize) this.ddlLine).EndInit();
    ((ISupportInitialize) this.ddlOffice).EndInit();
    this.dataTable9.EndInit();
    ((ISupportInitialize) this.ddlDepartment).EndInit();
    ((ISupportInitialize) this.err).EndInit();
    ((ISupportInitialize) this.ddlGroups).EndInit();
    ((ISupportInitialize) this.ddlLocations).EndInit();
    this.dataTable3.EndInit();
    ((ISupportInitialize) this.ugProducers).EndInit();
    ((ISupportInitialize) this.dtTo).EndInit();
    ((ISupportInitialize) this.chkIncNonRenewal).EndInit();
    ((ISupportInitialize) this.curPremiumTo).EndInit();
    ((ISupportInitialize) this.curPremiumFrom).EndInit();
    this.dataTable2.EndInit();
    ((ISupportInitialize) this.curMinPremium).EndInit();
    this.dataTable1.EndInit();
    this.dsConstraints.EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }
}
