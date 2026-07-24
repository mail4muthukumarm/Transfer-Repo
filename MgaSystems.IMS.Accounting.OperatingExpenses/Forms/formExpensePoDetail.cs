// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.OperatingExpenses.Forms.formExpensePoDetail
// Assembly: MgaSystems.IMS.Accounting.OperatingExpenses, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 77B4DED4-9019-44D3-8D52-4669B0CA70E1
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.OperatingExpenses.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using MGASystems.Common;
using MGASystems.IMS.Accounting.AccountingDatasets;
using MGASystems.IMS.Accounting.Controls;
using MGASystems.IMS.Accounting.Core.ClassObjects;
using MGASystems.IMS.Accounting.Core.Forms;
using MGASystems.IMS.Accounting.Interfaces;
using MGASystems.IMS.Accounting.OperatingExpenses.ClassObjects;
using MGASystems.IMS.Accounting.OperatingExpenses.Exceptions;
using MGASystems.IMS.Accounting.Services;
using MGASystems.IMS.Accounting.Services.Forms;
using MGASystems.IMS.Accounting.Shared;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.OperatingExpenses.Forms;

public class formExpensePoDetail : AccountingNoteDocumentSupport
{
  internal Label Label8;
  internal UltraTextEditor txtExpenseTotal;
  internal Label Label7;
  internal UltraTextEditor txtExpenseDiscount;
  internal Label Label6;
  internal UltraTextEditor txtExpenseAmount;
  internal Label Label5;
  internal UltraTextEditor txtExpenseFor;
  internal UltraCombo cmbCostCenter;
  internal Label Label4;
  internal Label Label3;
  internal Label Label2;
  internal UltraCombo cmbExpense;
  internal Label Label1;
  private MGADateTimePicker mgaDateTimePicker1;
  private dsCostCenters dsCostCenters1;
  private SqlDataAdapter daGetCostCenters;
  private SqlCommand sqlSelectCommand1;
  private SqlConnection FormDataConnection;
  private dsExpensesList dsExpensesList1;
  private SqlDataAdapter daGetExpenseList;
  private SqlCommand sqlSelectCommand2;
  private MGACheckBox checkboxPercentage;
  private ToolTip toolTip1;
  private ExtendedTreeViewDropDown extendedTreeViewDropDown1;
  private MGAButton buttonRemoveExpenseFor;
  private MGAButton buttonEditAllocations;
  private IContainer components;
  private int GlCompanyId;
  internal PurchaseOrderExpenseDetail detailItem;

  private formExpensePoDetail() => this.InitializeComponent();

  public formExpensePoDetail(int glCompanyId)
  {
    this.InitializeComponent();
    this.FormDataConnection.ConnectionString = CurrentUser.Instance.ConnectionString;
    this.GlCompanyId = glCompanyId;
    this.extendedTreeViewDropDown1.LoadGLAccounts(glCompanyId);
    this.daGetCostCenters.SelectCommand.Parameters["@glcompanyid"].Value = (object) glCompanyId;
    this.daGetExpenseList.SelectCommand.Parameters["@glcompanyid"].Value = (object) glCompanyId;
    this.daGetCostCenters.Fill((DataTable) this.dsCostCenters1.spFin_GetCostCenters);
    this.daGetExpenseList.Fill((DataTable) this.dsExpensesList1.spFin_GetExpensesList);
  }

  public formExpensePoDetail(PurchaseOrderExpenseDetail DetailObject)
  {
    this.InitializeComponent();
    this.FormDataConnection.ConnectionString = CurrentUser.Instance.ConnectionString;
    this.GlCompanyId = DetailObject.Parent.GlCompanyId;
    this.extendedTreeViewDropDown1.LoadGLAccounts(DetailObject.Parent.GlCompanyId);
    this.daGetCostCenters.SelectCommand.Parameters["@glcompanyid"].Value = (object) DetailObject.Parent.GlCompanyId;
    this.daGetExpenseList.SelectCommand.Parameters["@glcompanyid"].Value = (object) DetailObject.Parent.GlCompanyId;
    this.daGetCostCenters.Fill((DataTable) this.dsCostCenters1.spFin_GetCostCenters);
    this.daGetExpenseList.Fill((DataTable) this.dsExpensesList1.spFin_GetExpensesList);
    this.detailItem = DetailObject;
    this.DisplayCurrentDetailObject();
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
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("spFin_GetCostCenters", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("CostCenterID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("Name");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("Description");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("GLCOMPANYID");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("spFin_GetCostCentersTable1");
    UltraGridBand ultraGridBand2 = new UltraGridBand("spFin_GetCostCentersTable1", 0);
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("COSTCENTERID");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("ENTITYGUID");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("Name");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("Entity Type");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("isdefault");
    Appearance appearance6 = new Appearance();
    UltraGridBand ultraGridBand3 = new UltraGridBand("spFin_GetExpensesList", -1);
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("EXPENSECODE");
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("EXPENSENAME");
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("GLCOMPANYID");
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("GLACCTID");
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("GLACCTFULLNAME");
    Appearance appearance7 = new Appearance();
    ResourceManager resourceManager = new ResourceManager(typeof (formExpensePoDetail));
    Appearance appearance8 = new Appearance();
    this.Label8 = new Label();
    this.txtExpenseTotal = new UltraTextEditor();
    this.Label7 = new Label();
    this.txtExpenseDiscount = new UltraTextEditor();
    this.Label6 = new Label();
    this.txtExpenseAmount = new UltraTextEditor();
    this.Label5 = new Label();
    this.txtExpenseFor = new UltraTextEditor();
    this.cmbCostCenter = new UltraCombo();
    this.dsCostCenters1 = new dsCostCenters();
    this.Label4 = new Label();
    this.Label3 = new Label();
    this.Label2 = new Label();
    this.cmbExpense = new UltraCombo();
    this.dsExpensesList1 = new dsExpensesList();
    this.Label1 = new Label();
    this.mgaDateTimePicker1 = new MGADateTimePicker();
    this.daGetCostCenters = new SqlDataAdapter();
    this.sqlSelectCommand1 = new SqlCommand();
    this.FormDataConnection = new SqlConnection();
    this.daGetExpenseList = new SqlDataAdapter();
    this.sqlSelectCommand2 = new SqlCommand();
    this.checkboxPercentage = new MGACheckBox();
    this.toolTip1 = new ToolTip(this.components);
    this.buttonRemoveExpenseFor = new MGAButton();
    this.extendedTreeViewDropDown1 = new ExtendedTreeViewDropDown();
    this.buttonEditAllocations = new MGAButton();
    ((ISupportInitialize) this.txtExpenseTotal).BeginInit();
    ((ISupportInitialize) this.txtExpenseDiscount).BeginInit();
    ((ISupportInitialize) this.txtExpenseAmount).BeginInit();
    ((ISupportInitialize) this.txtExpenseFor).BeginInit();
    ((ISupportInitialize) this.cmbCostCenter).BeginInit();
    this.dsCostCenters1.BeginInit();
    ((ISupportInitialize) this.cmbExpense).BeginInit();
    this.dsExpensesList1.BeginInit();
    ((ISupportInitialize) this.mgaDateTimePicker1).BeginInit();
    this.SuspendLayout();
    this.Label8.AutoSize = true;
    this.Label8.Location = new Point(8, 152);
    this.Label8.Name = "Label8";
    this.Label8.Size = new Size(78, 17);
    this.Label8.TabIndex = 15;
    this.Label8.Text = "Expense Total:";
    ((AppearanceBase) appearance1).BackColor = Color.Gainsboro;
    ((AppearanceBase) appearance1).TextHAlign = (HAlign) 3;
    ((TextEditorControlBase) this.txtExpenseTotal).Appearance = (AppearanceBase) appearance1;
    ((Control) this.txtExpenseTotal).Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    ((Control) this.txtExpenseTotal).Location = new Point(96 /*0x60*/, 152);
    ((Control) this.txtExpenseTotal).Name = "txtExpenseTotal";
    ((EditorButtonControlBase) this.txtExpenseTotal).ReadOnly = true;
    ((Control) this.txtExpenseTotal).Size = new Size(128 /*0x80*/, 22);
    ((Control) this.txtExpenseTotal).TabIndex = 16 /*0x10*/;
    ((Control) this.txtExpenseTotal).TabStop = false;
    this.Label7.AutoSize = true;
    this.Label7.Location = new Point(8, 128 /*0x80*/);
    this.Label7.Name = "Label7";
    this.Label7.Size = new Size(75, 17);
    this.Label7.TabIndex = 12;
    this.Label7.Text = "Discount Amt:";
    ((AppearanceBase) appearance2).TextHAlign = (HAlign) 3;
    ((TextEditorControlBase) this.txtExpenseDiscount).Appearance = (AppearanceBase) appearance2;
    ((Control) this.txtExpenseDiscount).Location = new Point(96 /*0x60*/, 128 /*0x80*/);
    ((Control) this.txtExpenseDiscount).Name = "txtExpenseDiscount";
    ((Control) this.txtExpenseDiscount).Size = new Size(128 /*0x80*/, 22);
    ((Control) this.txtExpenseDiscount).TabIndex = 13;
    ((Control) this.txtExpenseDiscount).Leave += new EventHandler(this.FormatDiscountAmt);
    ((Control) this.txtExpenseDiscount).Validating += new CancelEventHandler(this.txtExpenseAmount_Validating);
    this.Label6.AutoSize = true;
    this.Label6.Location = new Point(8, 104);
    this.Label6.Name = "Label6";
    this.Label6.Size = new Size(73, 17);
    this.Label6.TabIndex = 10;
    this.Label6.Text = "Expense Amt:";
    ((AppearanceBase) appearance3).TextHAlign = (HAlign) 3;
    ((TextEditorControlBase) this.txtExpenseAmount).Appearance = (AppearanceBase) appearance3;
    ((Control) this.txtExpenseAmount).Location = new Point(96 /*0x60*/, 104);
    ((Control) this.txtExpenseAmount).Name = "txtExpenseAmount";
    ((Control) this.txtExpenseAmount).Size = new Size(128 /*0x80*/, 22);
    ((Control) this.txtExpenseAmount).TabIndex = 11;
    ((Control) this.txtExpenseAmount).Validating += new CancelEventHandler(this.txtExpenseAmount_Validating);
    this.Label5.AutoSize = true;
    this.Label5.Location = new Point(8, 80 /*0x50*/);
    this.Label5.Name = "Label5";
    this.Label5.Size = new Size(69, 17);
    this.Label5.TabIndex = 6;
    this.Label5.Text = "Expense For:";
    ((AppearanceBase) appearance4).BackColor = Color.Gainsboro;
    ((TextEditorControlBase) this.txtExpenseFor).Appearance = (AppearanceBase) appearance4;
    ((Control) this.txtExpenseFor).Location = new Point(96 /*0x60*/, 80 /*0x50*/);
    ((Control) this.txtExpenseFor).Name = "txtExpenseFor";
    ((EditorButtonControlBase) this.txtExpenseFor).ReadOnly = true;
    ((Control) this.txtExpenseFor).Size = new Size(250, 22);
    ((Control) this.txtExpenseFor).TabIndex = 7;
    ((Control) this.txtExpenseFor).TabStop = false;
    this.cmbCostCenter.CharacterCasing = CharacterCasing.Normal;
    ((UltraGridBase) this.cmbCostCenter).DataMember = "spFin_GetCostCenters";
    ((UltraGridBase) this.cmbCostCenter).DataSource = (object) this.dsCostCenters1;
    ((AppearanceBase) appearance5).BackColor = Color.White;
    ((UltraGridBase) this.cmbCostCenter).DisplayLayout.Appearance = (AppearanceBase) appearance5;
    ((UltraGridBase) this.cmbCostCenter).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand1.AddButtonCaption = "Table1";
    ultraGridBand1.ColHeadersVisible = false;
    ((HeaderBase) ultraGridColumn1.Header).VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ((HeaderBase) ultraGridColumn2.Header).VisiblePosition = 1;
    ultraGridColumn2.Width = 286;
    ((HeaderBase) ultraGridColumn3.Header).VisiblePosition = 2;
    ultraGridColumn3.Hidden = true;
    ((HeaderBase) ultraGridColumn4.Header).VisiblePosition = 3;
    ultraGridColumn4.Hidden = true;
    ((HeaderBase) ultraGridColumn5.Header).VisiblePosition = 4;
    ultraGridBand1.Columns.AddRange(new object[5]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4,
      (object) ultraGridColumn5
    });
    ultraGridBand1.GroupHeadersVisible = false;
    ((HeaderBase) ultraGridColumn6.Header).VisiblePosition = 0;
    ((HeaderBase) ultraGridColumn7.Header).VisiblePosition = 1;
    ((HeaderBase) ultraGridColumn8.Header).VisiblePosition = 2;
    ((HeaderBase) ultraGridColumn9.Header).VisiblePosition = 3;
    ((HeaderBase) ultraGridColumn10.Header).VisiblePosition = 4;
    ultraGridBand2.Columns.AddRange(new object[5]
    {
      (object) ultraGridColumn6,
      (object) ultraGridColumn7,
      (object) ultraGridColumn8,
      (object) ultraGridColumn9,
      (object) ultraGridColumn10
    });
    ((UltraGridBase) this.cmbCostCenter).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.cmbCostCenter).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.cmbCostCenter).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.cmbCostCenter).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.cmbCostCenter).DisplayLayout.Override.BorderStyleHeader = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.cmbCostCenter).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.cmbCostCenter).DisplayLayout.Override.BorderStyleRowSelector = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.cmbCostCenter).DisplayLayout.Override.BorderStyleSummaryFooter = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.cmbCostCenter).DisplayLayout.Override.BorderStyleSummaryFooterCaption = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.cmbCostCenter).DisplayLayout.Override.BorderStyleSummaryValue = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.cmbCostCenter).DisplayLayout.Override.BorderStyleTemplateAddRow = (UIElementBorderStyle) 1;
    ((UltraDropDownBase) this.cmbCostCenter).DisplayMember = "Name";
    this.cmbCostCenter.DisplayStyle = (EmbeddableElementDisplayStyle) 4;
    ((Control) this.cmbCostCenter).Location = new Point(96 /*0x60*/, 176 /*0xB0*/);
    ((Control) this.cmbCostCenter).Name = "cmbCostCenter";
    ((Control) this.cmbCostCenter).Size = new Size(304, 22);
    ((Control) this.cmbCostCenter).TabIndex = 18;
    ((UltraDropDownBase) this.cmbCostCenter).ValueMember = "CostCenterID";
    this.cmbCostCenter.RowSelected += new RowSelectedEventHandler(this.cmbCostCenter_RowSelected);
    this.dsCostCenters1.DataSetName = "dsCostCenters";
    this.dsCostCenters1.Locale = new CultureInfo("en-US");
    this.Label4.AutoSize = true;
    this.Label4.Location = new Point(8, 32 /*0x20*/);
    this.Label4.Name = "Label4";
    this.Label4.Size = new Size(50, 17);
    this.Label4.TabIndex = 2;
    this.Label4.Text = "Expense:";
    this.Label3.AutoSize = true;
    this.Label3.Location = new Point(8, 56);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(65, 17);
    this.Label3.TabIndex = 4;
    this.Label3.Text = "GL Account:";
    this.Label2.AutoSize = true;
    this.Label2.Location = new Point(8, 176 /*0xB0*/);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(66, 17);
    this.Label2.TabIndex = 17;
    this.Label2.Text = "Cost Center:";
    this.cmbExpense.CharacterCasing = CharacterCasing.Normal;
    ((UltraGridBase) this.cmbExpense).DataMember = "spFin_GetExpensesList";
    ((UltraGridBase) this.cmbExpense).DataSource = (object) this.dsExpensesList1;
    ((AppearanceBase) appearance6).BackColor = Color.White;
    ((UltraGridBase) this.cmbExpense).DisplayLayout.Appearance = (AppearanceBase) appearance6;
    ((UltraGridBase) this.cmbExpense).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand3.ColHeadersVisible = false;
    ((HeaderBase) ultraGridColumn11.Header).VisiblePosition = 0;
    ultraGridColumn11.Hidden = true;
    ((HeaderBase) ultraGridColumn12.Header).VisiblePosition = 1;
    ultraGridColumn12.Width = 286;
    ((HeaderBase) ultraGridColumn13.Header).VisiblePosition = 2;
    ultraGridColumn13.Hidden = true;
    ((HeaderBase) ultraGridColumn14.Header).VisiblePosition = 3;
    ultraGridColumn14.Hidden = true;
    ((HeaderBase) ultraGridColumn15.Header).VisiblePosition = 4;
    ultraGridColumn15.Hidden = true;
    ultraGridBand3.Columns.AddRange(new object[5]
    {
      (object) ultraGridColumn11,
      (object) ultraGridColumn12,
      (object) ultraGridColumn13,
      (object) ultraGridColumn14,
      (object) ultraGridColumn15
    });
    ultraGridBand3.GroupHeadersVisible = false;
    ((UltraGridBase) this.cmbExpense).DisplayLayout.BandsSerializer.Add((object) ultraGridBand3);
    ((UltraGridBase) this.cmbExpense).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.cmbExpense).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.cmbExpense).DisplayLayout.Override.BorderStyleHeader = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.cmbExpense).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.cmbExpense).DisplayLayout.Override.BorderStyleRowSelector = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.cmbExpense).DisplayLayout.Override.BorderStyleSummaryFooter = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.cmbExpense).DisplayLayout.Override.BorderStyleSummaryFooterCaption = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.cmbExpense).DisplayLayout.Override.BorderStyleSummaryValue = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.cmbExpense).DisplayLayout.Override.BorderStyleTemplateAddRow = (UIElementBorderStyle) 1;
    ((UltraDropDownBase) this.cmbExpense).DisplayMember = "EXPENSENAME";
    this.cmbExpense.DisplayStyle = (EmbeddableElementDisplayStyle) 4;
    ((Control) this.cmbExpense).Location = new Point(96 /*0x60*/, 32 /*0x20*/);
    ((Control) this.cmbExpense).Name = "cmbExpense";
    ((Control) this.cmbExpense).Size = new Size(304, 22);
    ((UltraControlBase) this.cmbExpense).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.cmbExpense).TabIndex = 3;
    ((UltraDropDownBase) this.cmbExpense).ValueMember = "EXPENSECODE";
    this.cmbExpense.RowSelected += new RowSelectedEventHandler(this.cmbExpense_RowSelected);
    this.dsExpensesList1.DataSetName = "dsExpensesList";
    this.dsExpensesList1.Locale = new CultureInfo("en-US");
    this.Label1.AutoSize = true;
    this.Label1.Location = new Point(8, 8);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(77, 17);
    this.Label1.TabIndex = 0;
    this.Label1.Text = "Expense Date:";
    this.mgaDateTimePicker1.BorderStyle = (UIElementBorderStyle) 4;
    this.mgaDateTimePicker1.DisplayStyle = (EmbeddableElementDisplayStyle) 4;
    this.mgaDateTimePicker1.FormatString = "D";
    ((Control) this.mgaDateTimePicker1).Location = new Point(96 /*0x60*/, 8);
    ((Control) this.mgaDateTimePicker1).Name = "mgaDateTimePicker1";
    ((Control) this.mgaDateTimePicker1).Size = new Size(304, 20);
    ((Control) this.mgaDateTimePicker1).TabIndex = 1;
    this.daGetCostCenters.SelectCommand = this.sqlSelectCommand1;
    this.daGetCostCenters.TableMappings.AddRange(new DataTableMapping[2]
    {
      new DataTableMapping("Table", "spFin_GetCostCenters", new DataColumnMapping[4]
      {
        new DataColumnMapping("CostCenterId", "CostCenterId"),
        new DataColumnMapping("Name", "Name"),
        new DataColumnMapping("Description", "Description"),
        new DataColumnMapping("glCompanyId", "glCompanyId")
      }),
      new DataTableMapping("Table1", "Table1", new DataColumnMapping[5]
      {
        new DataColumnMapping("CostCenterId", "CostCenterId"),
        new DataColumnMapping("entityGuid", "entityGuid"),
        new DataColumnMapping("Name", "Name"),
        new DataColumnMapping("Entity Type", "Entity Type"),
        new DataColumnMapping("isdefault", "isdefault")
      })
    });
    this.sqlSelectCommand1.CommandText = "[spFin_GetCostCenters]";
    this.sqlSelectCommand1.CommandType = CommandType.StoredProcedure;
    this.sqlSelectCommand1.Connection = this.FormDataConnection;
    this.sqlSelectCommand1.Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null));
    this.sqlSelectCommand1.Parameters.Add(new SqlParameter("@GLCOMPANYID", SqlDbType.Int, 4));
    this.FormDataConnection.ConnectionString = "workstation id=WREYES;packet size=4096;user id=mgasystems;data source=MGASYSTEMS;persist security info=False;initial catalog=IMS";
    this.daGetExpenseList.SelectCommand = this.sqlSelectCommand2;
    this.daGetExpenseList.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "spFin_GetExpensesList", new DataColumnMapping[5]
      {
        new DataColumnMapping("EXPENSECODE", "EXPENSECODE"),
        new DataColumnMapping("EXPENSENAME", "EXPENSENAME"),
        new DataColumnMapping("GLCOMPANYID", "GLCOMPANYID"),
        new DataColumnMapping("GLACCTID", "GLACCTID"),
        new DataColumnMapping("GLACCTFULLNAME", "GLACCTFULLNAME")
      })
    });
    this.sqlSelectCommand2.CommandText = "[spFin_GetExpensesList]";
    this.sqlSelectCommand2.CommandType = CommandType.StoredProcedure;
    this.sqlSelectCommand2.Connection = this.FormDataConnection;
    this.sqlSelectCommand2.Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null));
    this.sqlSelectCommand2.Parameters.Add(new SqlParameter("@GLCOMPANYID", SqlDbType.Int, 4));
    ((Control) this.checkboxPercentage).Location = new Point(232, 128 /*0x80*/);
    ((Control) this.checkboxPercentage).Name = "checkboxPercentage";
    ((Control) this.checkboxPercentage).Size = new Size(136, 20);
    ((Control) this.checkboxPercentage).TabIndex = 14;
    ((Control) this.checkboxPercentage).Text = "Apply as a Percentage";
    ((UltraToggleEditorBase) this.checkboxPercentage).CheckedChanged += new EventHandler(this.FormatDiscountAmt);
    ((AppearanceBase) appearance7).BackColor = Color.Gainsboro;
    ((AppearanceBase) appearance7).BackColor2 = Color.White;
    ((AppearanceBase) appearance7).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance7).BorderColor = Color.Gray;
    ((AppearanceBase) appearance7).Image = resourceManager.GetObject("appearance7.Image");
    ((AppearanceBase) appearance7).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance7).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonRemoveExpenseFor).Appearance = (AppearanceBase) appearance7;
    this.buttonRemoveExpenseFor.ButtonStyle = (UIElementButtonStyle) 14;
    ((Control) this.buttonRemoveExpenseFor).Location = new Point(352, 80 /*0x50*/);
    ((Control) this.buttonRemoveExpenseFor).Name = "buttonRemoveExpenseFor";
    ((Control) this.buttonRemoveExpenseFor).Size = new Size(22, 22);
    ((Control) this.buttonRemoveExpenseFor).TabIndex = 8;
    this.toolTip1.SetToolTip((Control) this.buttonRemoveExpenseFor, "Click here to remove the currently selected expense entity.");
    ((Control) this.buttonRemoveExpenseFor).Visible = false;
    ((Control) this.buttonRemoveExpenseFor).Click += new EventHandler(this.buttonRemoveExpenseFor_Click);
    this.extendedTreeViewDropDown1.DropDownHeight = 300;
    this.extendedTreeViewDropDown1.DropDownWidth = 300;
    this.extendedTreeViewDropDown1.Location = new Point(96 /*0x60*/, 56);
    this.extendedTreeViewDropDown1.Name = "extendedTreeViewDropDown1";
    this.extendedTreeViewDropDown1.ShowExpenseAccounts = true;
    this.extendedTreeViewDropDown1.ShowSystemDefinedAccounts = true;
    this.extendedTreeViewDropDown1.Size = new Size(304, 20);
    this.extendedTreeViewDropDown1.TabIndex = 5;
    this.extendedTreeViewDropDown1.UseCheckedStateSelectionOverride = false;
    ((AppearanceBase) appearance8).BackColor = Color.Gainsboro;
    ((AppearanceBase) appearance8).BackColor2 = Color.White;
    ((AppearanceBase) appearance8).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance8).BorderColor = Color.Gray;
    ((ControlBase) this.buttonEditAllocations).Appearance = (AppearanceBase) appearance8;
    this.buttonEditAllocations.ButtonStyle = (UIElementButtonStyle) 14;
    ((Control) this.buttonEditAllocations).Location = new Point(56, 208 /*0xD0*/);
    ((Control) this.buttonEditAllocations).Name = "buttonEditAllocations";
    ((Control) this.buttonEditAllocations).Size = new Size(104, 24);
    ((Control) this.buttonEditAllocations).TabIndex = 19;
    ((Control) this.buttonEditAllocations).Text = "Edit Allocations";
    ((Control) this.buttonEditAllocations).Visible = false;
    ((Control) this.buttonEditAllocations).Click += new EventHandler(this.buttonEditAllocations_Click);
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.ClientSize = new Size(408, 238);
    this.ControlBox = false;
    this.Controls.Add((Control) this.buttonEditAllocations);
    this.Controls.Add((Control) this.buttonRemoveExpenseFor);
    this.Controls.Add((Control) this.extendedTreeViewDropDown1);
    this.Controls.Add((Control) this.checkboxPercentage);
    this.Controls.Add((Control) this.mgaDateTimePicker1);
    this.Controls.Add((Control) this.Label8);
    this.Controls.Add((Control) this.Label7);
    this.Controls.Add((Control) this.Label6);
    this.Controls.Add((Control) this.Label5);
    this.Controls.Add((Control) this.Label4);
    this.Controls.Add((Control) this.Label3);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.txtExpenseTotal);
    this.Controls.Add((Control) this.txtExpenseDiscount);
    this.Controls.Add((Control) this.txtExpenseAmount);
    this.Controls.Add((Control) this.txtExpenseFor);
    this.Controls.Add((Control) this.cmbCostCenter);
    this.Controls.Add((Control) this.cmbExpense);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.Name = nameof (formExpensePoDetail);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Purchase Order/Expense Detail";
    ((ISupportInitialize) this.txtExpenseTotal).EndInit();
    ((ISupportInitialize) this.txtExpenseDiscount).EndInit();
    ((ISupportInitialize) this.txtExpenseAmount).EndInit();
    ((ISupportInitialize) this.txtExpenseFor).EndInit();
    ((ISupportInitialize) this.cmbCostCenter).EndInit();
    this.dsCostCenters1.EndInit();
    ((ISupportInitialize) this.cmbExpense).EndInit();
    this.dsExpensesList1.EndInit();
    ((ISupportInitialize) this.mgaDateTimePicker1).EndInit();
    this.ResumeLayout(false);
  }

  private void buttonCancel_Click(object sender, EventArgs e) => this.Close();

  private bool CreateDetailItem()
  {
    if (!this.ValidateForm())
      return false;
    if (this.detailItem == null)
    {
      if (!(this.Owner is formNewExpensePO))
        throw new InvalidFormOwnerException(MGASystems.IMS.Accounting.OperatingExpenses.StringResourceManager.GetString("InvalidFormOwnerException"));
      this.detailItem = ((formNewExpensePO) this.Owner).poObject.CreateNewDetailItem(int.Parse(((UltraDropDownBase) this.cmbExpense).SelectedRow.Cells["expensecode"].Value.ToString()));
    }
    this.detailItem.ExpenseDate = this.mgaDateTimePicker1.DateTime;
    this.detailItem.GlAccountId = this.extendedTreeViewDropDown1.GLAccountID;
    this.detailItem.ExpenseAmount = Decimal.Parse(((Control) this.txtExpenseAmount).Text, NumberStyles.Currency);
    this.detailItem.IsDiscountPercentage = ((UltraToggleEditorBase) this.checkboxPercentage).Checked;
    this.detailItem.DiscountAmount = ((Control) this.txtExpenseDiscount).Text.Equals(string.Empty) || ((Control) this.txtExpenseDiscount).Text.Length == 0 ? 0M : (!((UltraToggleEditorBase) this.checkboxPercentage).Checked ? Decimal.Parse(((Control) this.txtExpenseDiscount).Text, NumberStyles.Currency) : Decimal.Parse(((Control) this.txtExpenseDiscount).Text));
    return true;
  }

  private bool ValidateForm()
  {
    if (((UltraDropDownBase) this.cmbExpense).SelectedRow == null)
    {
      int num = (int) MessageBox.Show(MGASystems.IMS.Accounting.OperatingExpenses.StringResourceManager.GetString("ExpenseRequiredToContinue"), MGASystems.IMS.Accounting.OperatingExpenses.StringResourceManager.GetString("RequiredFieldMissing"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (this.extendedTreeViewDropDown1.SelectedNodeCount != 0)
    {
      if (this.extendedTreeViewDropDown1.GLAccountID != -1)
      {
        try
        {
          Decimal.Parse(((Control) this.txtExpenseAmount).Text, NumberStyles.Currency);
        }
        catch (FormatException ex)
        {
          int num = (int) MessageBox.Show(MGASystems.IMS.Accounting.OperatingExpenses.StringResourceManager.GetString("ValidExpenseAmountRequired"), MGASystems.IMS.Accounting.OperatingExpenses.StringResourceManager.GetString("INVALIDENTRY"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return false;
        }
        if (!((Control) this.txtExpenseDiscount).Text.Equals(string.Empty))
        {
          if (((Control) this.txtExpenseDiscount).Text.Length != 0)
          {
            try
            {
              Decimal num = 0M;
              num = !((UltraToggleEditorBase) this.checkboxPercentage).Checked ? Decimal.Parse(((Control) this.txtExpenseDiscount).Text, NumberStyles.Currency) : Decimal.Parse(((Control) this.txtExpenseDiscount).Text);
            }
            catch (FormatException ex)
            {
              int num = (int) MessageBox.Show(MGASystems.IMS.Accounting.OperatingExpenses.StringResourceManager.GetString("ValidDiscountAmountRequired"), MGASystems.IMS.Accounting.OperatingExpenses.StringResourceManager.GetString("INVALIDENTRY"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
              return false;
            }
          }
        }
        return true;
      }
    }
    int num1 = (int) MessageBox.Show(MGASystems.IMS.Accounting.OperatingExpenses.StringResourceManager.GetString("GL_ACCOUNT_REQUIRED"), MGASystems.IMS.Accounting.OperatingExpenses.StringResourceManager.GetString("RequiredFieldMissing"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    return false;
  }

  private void CalculateExpenseTotal()
  {
    Decimal num1;
    try
    {
      num1 = Decimal.Parse(((Control) this.txtExpenseAmount).Text, NumberStyles.Currency);
    }
    catch (FormatException ex)
    {
      num1 = 0M;
    }
    Decimal num2;
    try
    {
      num2 = !((UltraToggleEditorBase) this.checkboxPercentage).Checked ? Decimal.Parse(((Control) this.txtExpenseDiscount).Text, NumberStyles.Currency) : Decimal.Parse(((Control) this.txtExpenseDiscount).Text);
    }
    catch (FormatException ex)
    {
      num2 = 0M;
    }
    if (num2 == 0M)
      ((Control) this.txtExpenseTotal).Text = num1.ToString("c");
    else if (((UltraToggleEditorBase) this.checkboxPercentage).Checked)
    {
      if (num2 < 0M)
        ((Control) this.txtExpenseTotal).Text = (num1 + num1 * (num2 / 100M)).ToString("c");
      else
        ((Control) this.txtExpenseTotal).Text = (num1 - num1 * (num2 / 100M)).ToString("c");
    }
    else if (num2 < 0M)
      ((Control) this.txtExpenseTotal).Text = (num1 - num2).ToString("c");
    else
      ((Control) this.txtExpenseTotal).Text = (num1 + num2).ToString("c");
  }

  private void FormatDiscountAmt(object sender, EventArgs e)
  {
    if (((Control) this.txtExpenseDiscount).Text.Equals(string.Empty) || ((Control) this.txtExpenseDiscount).Text.Length == 0)
    {
      ((Control) this.txtExpenseDiscount).Text = MGASystems.IMS.Accounting.OperatingExpenses.StringResourceManager.GetString("ZeroDollarAmount");
    }
    else
    {
      if (((UltraToggleEditorBase) this.checkboxPercentage).Checked)
      {
        if (!((Control) this.txtExpenseDiscount).Text.Equals(string.Empty))
        {
          if (((Control) this.txtExpenseDiscount).Text.Length != 0)
          {
            try
            {
              ((Control) this.txtExpenseDiscount).Text = (Decimal.Parse(((Control) this.txtExpenseDiscount).Text, NumberStyles.Currency) / 100M).ToString("P");
              goto label_13;
            }
            catch (FormatException ex)
            {
              int num = (int) MessageBox.Show(MGASystems.IMS.Accounting.OperatingExpenses.StringResourceManager.GetString("ValidDiscountAmountRequired"), MGASystems.IMS.Accounting.OperatingExpenses.StringResourceManager.GetString("INVALIDENTRY"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
              return;
            }
          }
        }
        ((Control) this.txtExpenseDiscount).Text = MGASystems.IMS.Accounting.OperatingExpenses.StringResourceManager.GetString("ZeroPercentage");
      }
      else
      {
        if (!((Control) this.txtExpenseDiscount).Text.Equals(string.Empty))
        {
          if (((Control) this.txtExpenseDiscount).Text.Length != 0)
          {
            try
            {
              ((Control) this.txtExpenseDiscount).Text = ((Control) this.txtExpenseDiscount).Text.Replace("%", "");
              ((Control) this.txtExpenseDiscount).Text = Decimal.Parse(((Control) this.txtExpenseDiscount).Text).ToString("c");
              goto label_13;
            }
            catch (FormatException ex)
            {
              int num = (int) MessageBox.Show(MGASystems.IMS.Accounting.OperatingExpenses.StringResourceManager.GetString("ValidDiscountAmountRequired"), MGASystems.IMS.Accounting.OperatingExpenses.StringResourceManager.GetString("INVALIDENTRY"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
              return;
            }
          }
        }
        ((Control) this.txtExpenseDiscount).Text = MGASystems.IMS.Accounting.OperatingExpenses.StringResourceManager.GetString("ZeroDollarAmount");
      }
label_13:
      this.CalculateExpenseTotal();
    }
  }

  private void SetSelectedCostCenter(int CostCenterId)
  {
    if (!this.CreateDetailItem())
      return;
    if (CostCenterId == 99999)
    {
      formCostCenterAllocation centerAllocation = new formCostCenterAllocation((ISupportCostCenterAllocation) this.detailItem, this.GlCompanyId);
      try
      {
        if (centerAllocation.ShowDialog() == DialogResult.OK)
        {
          this.detailItem = (PurchaseOrderExpenseDetail) centerAllocation.TransactionDetail;
        }
        else
        {
          ((UltraDropDownBase) this.cmbCostCenter).SelectedRow = (UltraGridRow) null;
          ((Control) this.cmbCostCenter).ResetText();
        }
      }
      finally
      {
        centerAllocation.Dispose();
      }
    }
    else if (this.detailItem.CostCenterAllocations.Count == 0)
      this.detailItem.CostCenterAllocations.Add(new CostCenterAllocation(CostCenterId, this.detailItem.ExpenseTotal), this.detailItem.ExpenseAmount);
    else if (MessageBox.Show(MGASystems.IMS.Accounting.OperatingExpenses.StringResourceManager.GetString("OverwriteExistingCostCenterAllocations"), MGASystems.IMS.Accounting.OperatingExpenses.StringResourceManager.GetString("OverwriteAllocationHeader"), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
    {
      this.detailItem.CostCenterAllocations.Clear();
      this.detailItem.CostCenterAllocations.Add(new CostCenterAllocation(CostCenterId, this.detailItem.ExpenseTotal), this.detailItem.ExpenseAmount);
    }
    ((Control) this.buttonEditAllocations).Visible = this.detailItem.CostCenterAllocations.Count > 1;
  }

  private void txtExpenseAmount_Validating(object sender, CancelEventArgs e)
  {
    if (!((Control) this.txtExpenseAmount).Text.Equals(string.Empty))
    {
      if (((Control) this.txtExpenseAmount).Text.Length != 0)
      {
        try
        {
          ((Control) this.txtExpenseAmount).Text = Decimal.Parse(((Control) this.txtExpenseAmount).Text, NumberStyles.Currency).ToString("c");
          goto label_5;
        }
        catch (FormatException ex)
        {
          int num = (int) MessageBox.Show(MGASystems.IMS.Accounting.OperatingExpenses.StringResourceManager.GetString("ValidExpenseAmountRequired"), MGASystems.IMS.Accounting.OperatingExpenses.StringResourceManager.GetString("INVALIDENTRY"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          e.Cancel = true;
          return;
        }
      }
    }
    ((Control) this.txtExpenseAmount).Text = MGASystems.IMS.Accounting.OperatingExpenses.StringResourceManager.GetString("ZeroDollarAmount");
label_5:
    this.CalculateExpenseTotal();
  }

  private void cmbCostCenter_RowSelected(object sender, RowSelectedEventArgs e)
  {
    if (((UltraDropDownBase) this.cmbCostCenter).SelectedRow == null)
      return;
    this.SetSelectedCostCenter(int.Parse(((UltraDropDownBase) this.cmbCostCenter).SelectedRow.Cells["costcenterid"].Value.ToString()));
  }

  private void buttonSearch_Click(object sender, EventArgs e)
  {
    if (this.detailItem == null)
    {
      if (((UltraDropDownBase) this.cmbExpense).SelectedRow == null)
      {
        int num = (int) MessageBox.Show(MGASystems.IMS.Accounting.OperatingExpenses.StringResourceManager.GetString("ExpenseRequiredToContinue"), MGASystems.IMS.Accounting.OperatingExpenses.StringResourceManager.GetString("RequiredFieldMissing"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }
      this.detailItem = ((formNewExpensePO) this.Owner).poObject.CreateNewDetailItem(int.Parse(((UltraDropDownBase) this.cmbExpense).SelectedRow.Cells["expensecode"].Value.ToString()));
    }
    FormSearchEntity formSearchEntity = new FormSearchEntity(Utility.SearchEntityTypes.ShowCompanyGroup | Utility.SearchEntityTypes.ShowCompany | Utility.SearchEntityTypes.ShowCompanyLocations | Utility.SearchEntityTypes.ShowCompanyLines | Utility.SearchEntityTypes.ShowInsured | Utility.SearchEntityTypes.ShowIntermediary | Utility.SearchEntityTypes.ShowProducer | Utility.SearchEntityTypes.ShowUsers | Utility.SearchEntityTypes.ShowExpensePayees | Utility.SearchEntityTypes.Show3rdParty | Utility.SearchEntityTypes.ShowFinanceCompanies | Utility.SearchEntityTypes.ShowInspectionCompanies);
    try
    {
      if (formSearchEntity.ShowDialog() == DialogResult.OK)
      {
        this.detailItem.ExpenseFor = formSearchEntity.EntityGuid;
        ((Control) this.txtExpenseFor).Text = formSearchEntity.EntityName;
      }
    }
    finally
    {
      formSearchEntity.Dispose();
    }
    ((Control) this.buttonRemoveExpenseFor).Visible = !this.detailItem.ExpenseFor.Equals(Guid.Empty);
  }

  private void buttonRemoveExpenseFor_Click(object sender, EventArgs e)
  {
    if (this.detailItem != null)
      this.detailItem.ExpenseFor = Guid.Empty;
    ((Control) this.txtExpenseFor).Text = MGASystems.IMS.Accounting.OperatingExpenses.StringResourceManager.GetString("EmptyString");
    ((Control) this.buttonRemoveExpenseFor).Visible = false;
  }

  private void cmbExpense_RowSelected(object sender, RowSelectedEventArgs e)
  {
    if (((UltraDropDownBase) this.cmbExpense).SelectedRow == null)
      return;
    if (this.detailItem == null)
    {
      if (!(this.Owner is formNewExpensePO))
        throw new InvalidFormOwnerException(MGASystems.IMS.Accounting.OperatingExpenses.StringResourceManager.GetString("InvalidFormOwnerException"));
      this.detailItem = ((formNewExpensePO) this.Owner).poObject.CreateNewDetailItem(int.Parse(((UltraDropDownBase) this.cmbExpense).SelectedRow.Cells["expensecode"].Value.ToString()));
    }
    this.extendedTreeViewDropDown1.SetSelectedNodeByKey(Expense.GetExpenseDefaultGLAccount(int.Parse(((UltraDropDownBase) this.cmbExpense).SelectedRow.Cells["expenseCode"].Value.ToString()), this.detailItem.Parent.GlCompanyId).ToString());
  }

  private void buttonSave_Click(object sender, EventArgs e)
  {
    if (this.detailItem == null || this.detailItem.State == PurchaseOrderExpenseDetail.DetailObjectState.InComplete)
    {
      int num = (int) MessageBox.Show(MGASystems.IMS.Accounting.OperatingExpenses.StringResourceManager.GetString("CANNOT_SAVE_DETAILITEM"), MGASystems.IMS.Accounting.OperatingExpenses.StringResourceManager.GetString("RequiredFieldMissing"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else
    {
      this.DialogResult = DialogResult.OK;
      this.Close();
    }
  }

  private void buttonEditAllocations_Click(object sender, EventArgs e)
  {
    formCostCenterAllocation centerAllocation = new formCostCenterAllocation((ISupportCostCenterAllocation) this.detailItem, this.GlCompanyId);
    try
    {
      if (centerAllocation.ShowDialog() != DialogResult.OK)
        return;
      this.detailItem = (PurchaseOrderExpenseDetail) centerAllocation.TransactionDetail;
    }
    finally
    {
      centerAllocation.Dispose();
    }
  }

  private void DisplayCurrentDetailObject()
  {
    this.mgaDateTimePicker1.Value = (object) this.detailItem.ExpenseDate;
    this.cmbExpense.Value = (object) this.detailItem.ExpenseCode;
    this.extendedTreeViewDropDown1.SetSelectedNodeByKey(this.detailItem.GlAccountId.ToString());
    ((Control) this.txtExpenseAmount).Text = this.detailItem.ExpenseAmount.ToString("c");
    Decimal num;
    if (this.detailItem.DiscountAmount > 0M)
    {
      UltraTextEditor txtExpenseDiscount = this.txtExpenseDiscount;
      num = this.detailItem.DiscountAmount;
      string str = num.ToString("c");
      ((Control) txtExpenseDiscount).Text = str;
      ((UltraToggleEditorBase) this.checkboxPercentage).Checked = this.detailItem.IsDiscountPercentage;
    }
    UltraTextEditor txtExpenseTotal = this.txtExpenseTotal;
    num = this.detailItem.ExpenseTotal;
    string str1 = num.ToString("c");
    ((Control) txtExpenseTotal).Text = str1;
    if (!this.detailItem.ExpenseFor.Equals(Guid.Empty))
      ((Control) this.txtExpenseFor).Text = this.detailItem.ExpenseForName;
    this.cmbCostCenter.Value = this.detailItem.CostCenterAllocations.Count <= 1 ? (object) this.detailItem.CostCenterAllocations[0].CostCenterId : (object) 99999;
    ((Control) this.buttonEditAllocations).Visible = this.detailItem.CostCenterAllocations.Count > 1;
  }
}
