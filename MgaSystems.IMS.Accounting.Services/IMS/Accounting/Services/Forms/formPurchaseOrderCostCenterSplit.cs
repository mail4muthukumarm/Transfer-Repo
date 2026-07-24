// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.Forms.formPurchaseOrderCostCenterSplit
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using MGASystems.Common;
using MGASystems.IMS.Accounting.AccountingDatasets;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.Forms;

public class formPurchaseOrderCostCenterSplit : Form
{
  private MGAButton btnCancel;
  private MGAButton btnUpdate;
  private ContextMenu contextCostCenter;
  private UltraGrid gridPoCostCenters;
  private dsPurchaseOrderCostCenterSplit dsPurchaseOrderCostCenterSplit;
  private Panel panel3;
  private System.ComponentModel.Container components;
  private DataTable dtCostCenter;
  private int PoNum;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    UltraGridBand ultraGridBand = new UltraGridBand("PoCostCenterSplit", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("PoNum");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("expensecode");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("ExpenseName");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("costCenterID");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("CostCenterName");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("Amount");
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("oldcostcenterid");
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    this.btnCancel = new MGAButton();
    this.gridPoCostCenters = new UltraGrid();
    this.dsPurchaseOrderCostCenterSplit = new dsPurchaseOrderCostCenterSplit();
    this.btnUpdate = new MGAButton();
    this.contextCostCenter = new ContextMenu();
    this.panel3 = new Panel();
    ((ISupportInitialize) this.btnCancel).BeginInit();
    ((ISupportInitialize) this.gridPoCostCenters).BeginInit();
    this.dsPurchaseOrderCostCenterSplit.BeginInit();
    ((ISupportInitialize) this.btnUpdate).BeginInit();
    this.SuspendLayout();
    ((Control) this.btnCancel).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    ((AppearanceBase) appearance1).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance1).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance1).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance1).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance1).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance1).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnCancel).Appearance = (AppearanceBase) appearance1;
    ((UltraButtonBase) this.btnCancel).DialogResult = DialogResult.Cancel;
    ((Control) this.btnCancel).Location = new Point(558, 286);
    ((Control) this.btnCancel).Name = "btnCancel";
    ((Control) this.btnCancel).Size = new Size(80 /*0x50*/, 24);
    ((Control) this.btnCancel).TabIndex = 3;
    ((Control) this.btnCancel).Text = "Cancel";
    ((Control) this.btnCancel).Click += new EventHandler(this.buttonClose_Click);
    ((UltraGridBase) this.gridPoCostCenters).DataMember = "PoCostCenterSplit";
    ((UltraGridBase) this.gridPoCostCenters).DataSource = (object) this.dsPurchaseOrderCostCenterSplit;
    ((AppearanceBase) appearance2).BackColor = Color.White;
    ((AppearanceBase) appearance2).BackGradientStyle = (GradientStyle) 1;
    ((AppearanceBase) appearance2).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridPoCostCenters).DisplayLayout.Appearance = (AppearanceBase) appearance2;
    ((UltraGridBase) this.gridPoCostCenters).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((HeaderBase) ultraGridColumn1.Header).VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 85;
    ((HeaderBase) ultraGridColumn2.Header).VisiblePosition = 1;
    ultraGridColumn2.Hidden = true;
    ultraGridColumn2.Width = 76;
    ((HeaderBase) ultraGridColumn3.Header).Caption = "Expense";
    ((HeaderBase) ultraGridColumn3.Header).VisiblePosition = 2;
    ultraGridColumn3.Width = 283;
    ((HeaderBase) ultraGridColumn4.Header).VisiblePosition = 3;
    ultraGridColumn4.Hidden = true;
    ultraGridColumn4.Width = 121;
    ((HeaderBase) ultraGridColumn5.Header).Caption = "Cost Center";
    ((HeaderBase) ultraGridColumn5.Header).VisiblePosition = 4;
    ultraGridColumn5.Width = 135;
    ((AppearanceBase) appearance3).TextHAlign = (HAlign) 3;
    ultraGridColumn6.CellAppearance = (AppearanceBase) appearance3;
    ultraGridColumn6.Format = "c";
    ((AppearanceBase) appearance4).TextHAlign = (HAlign) 3;
    ((HeaderBase) ultraGridColumn6.Header).Appearance = (AppearanceBase) appearance4;
    ((HeaderBase) ultraGridColumn6.Header).VisiblePosition = 5;
    ultraGridColumn6.Width = 224 /*0xE0*/;
    ((HeaderBase) ultraGridColumn7.Header).VisiblePosition = 6;
    ultraGridColumn7.Hidden = true;
    ultraGridBand.Columns.AddRange(new object[7]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4,
      (object) ultraGridColumn5,
      (object) ultraGridColumn6,
      (object) ultraGridColumn7
    });
    ((AppearanceBase) appearance5).FontData.BoldAsString = "False";
    ((HeaderBase) ultraGridBand.Header).Appearance = (AppearanceBase) appearance5;
    ultraGridBand.Override.AllowColSizing = (AllowColSizing) 2;
    ((AppearanceBase) appearance6).TextHAlign = (HAlign) 1;
    ultraGridBand.Override.HeaderAppearance = (AppearanceBase) appearance6;
    ((UltraGridBase) this.gridPoCostCenters).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.gridPoCostCenters).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.gridPoCostCenters).DisplayLayout.Override.AllowAddNew = (AllowAddNew) 2;
    ((UltraGridBase) this.gridPoCostCenters).DisplayLayout.Override.AllowColMoving = (AllowColMoving) 1;
    ((UltraGridBase) this.gridPoCostCenters).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 1;
    ((UltraGridBase) this.gridPoCostCenters).DisplayLayout.Override.AllowColSwapping = (AllowColSwapping) 1;
    ((UltraGridBase) this.gridPoCostCenters).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 1;
    ((UltraGridBase) this.gridPoCostCenters).DisplayLayout.Override.AllowGroupBy = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridPoCostCenters).DisplayLayout.Override.AllowGroupMoving = (AllowGroupMoving) 1;
    ((UltraGridBase) this.gridPoCostCenters).DisplayLayout.Override.AllowGroupSwapping = (AllowGroupSwapping) 1;
    ((UltraGridBase) this.gridPoCostCenters).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridPoCostCenters).DisplayLayout.Override.AllowRowLayoutCellSizing = (RowLayoutSizing) 1;
    ((UltraGridBase) this.gridPoCostCenters).DisplayLayout.Override.AllowRowLayoutLabelSizing = (RowLayoutSizing) 1;
    ((UltraGridBase) this.gridPoCostCenters).DisplayLayout.Override.AllowRowSummaries = (AllowRowSummaries) 2;
    ((UltraGridBase) this.gridPoCostCenters).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridPoCostCenters).DisplayLayout.Override.BorderStyleCardArea = (UIElementBorderStyle) 1;
    ((AppearanceBase) appearance7).BorderColor = Color.Silver;
    ((UltraGridBase) this.gridPoCostCenters).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance7;
    ((UltraGridBase) this.gridPoCostCenters).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance8).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((AppearanceBase) appearance8).FontData.BoldAsString = "False";
    ((UltraGridBase) this.gridPoCostCenters).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance8;
    ((UltraGridBase) this.gridPoCostCenters).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((AppearanceBase) appearance9).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridPoCostCenters).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance9;
    ((AppearanceBase) appearance10).BorderColor = Color.Silver;
    ((UltraGridBase) this.gridPoCostCenters).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance10;
    ((UltraGridBase) this.gridPoCostCenters).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance11).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance11).ForeColor = Color.Black;
    ((UltraGridBase) this.gridPoCostCenters).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance11;
    ((UltraControlBase) this.gridPoCostCenters).UseFlatMode = (DefaultableBoolean) 1;
    ((Control) this.gridPoCostCenters).Font = new Font("Tahoma", 8f);
    ((Control) this.gridPoCostCenters).Location = new Point(2, 2);
    ((Control) this.gridPoCostCenters).Name = "gridPoCostCenters";
    ((Control) this.gridPoCostCenters).Size = new Size(644, 267);
    ((UltraControlBase) this.gridPoCostCenters).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.gridPoCostCenters).TabIndex = 4;
    ((Control) this.gridPoCostCenters).MouseUp += new MouseEventHandler(this.gridPoCostCenters_MouseUp);
    this.dsPurchaseOrderCostCenterSplit.DataSetName = "dsPurchaseOrderCostCenterSplit";
    this.dsPurchaseOrderCostCenterSplit.Locale = new CultureInfo("en-US");
    ((Control) this.btnUpdate).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    ((AppearanceBase) appearance12).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance12).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance12).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance12).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance12).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance12).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnUpdate).Appearance = (AppearanceBase) appearance12;
    ((Control) this.btnUpdate).Location = new Point(474, 286);
    ((Control) this.btnUpdate).Name = "btnUpdate";
    ((Control) this.btnUpdate).Size = new Size(80 /*0x50*/, 24);
    ((Control) this.btnUpdate).TabIndex = 5;
    ((Control) this.btnUpdate).Text = "Update";
    ((Control) this.btnUpdate).Click += new EventHandler(this.btnUpdate_Click);
    this.panel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.panel3.BackColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.panel3.Location = new Point(0, 270);
    this.panel3.Name = "panel3";
    this.panel3.Size = new Size(648, 48 /*0x30*/);
    this.panel3.TabIndex = 77;
    this.AutoScaleBaseSize = new Size(5, 13);
    this.BackColor = Color.White;
    this.CancelButton = (IButtonControl) this.btnCancel;
    this.ClientSize = new Size(648, 318);
    this.Controls.Add((Control) this.btnUpdate);
    this.Controls.Add((Control) this.btnCancel);
    this.Controls.Add((Control) this.panel3);
    this.Controls.Add((Control) this.gridPoCostCenters);
    this.Font = new Font("Tahoma", 8f);
    this.FormBorderStyle = FormBorderStyle.FixedSingle;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (formPurchaseOrderCostCenterSplit);
    this.ShowInTaskbar = false;
    this.Text = "Purchase Order Cost Center Re-Assignment";
    ((ISupportInitialize) this.btnCancel).EndInit();
    ((ISupportInitialize) this.gridPoCostCenters).EndInit();
    this.dsPurchaseOrderCostCenterSplit.EndInit();
    ((ISupportInitialize) this.btnUpdate).EndInit();
    this.ResumeLayout(false);
  }

  private formPurchaseOrderCostCenterSplit() => this.InitializeComponent();

  public formPurchaseOrderCostCenterSplit(int poNum, DataTable dt)
  {
    this.InitializeComponent();
    this.PoNum = poNum;
    this.LoadData(this.PoNum);
    this.dtCostCenter = dt;
    this.PopulateContextMenu(this.dtCostCenter);
  }

  private void PopulateContextMenu(DataTable dt)
  {
    if (dt == null || dt.Rows.Count <= 0)
      return;
    MenuItem[] items = new MenuItem[dt.Rows.Count];
    int num = 0;
    foreach (DataRow row in (InternalDataCollectionBase) dt.Rows)
      items[num++] = new MenuItem(row["Name"].ToString(), new EventHandler(this.ContextCostCenter_Click));
    this.contextCostCenter.MenuItems.AddRange(items);
  }

  private void ContextCostCenter_Click(object sender, EventArgs e)
  {
    ((UltraGridBase) this.gridPoCostCenters).DisplayLayout.Bands[0].Override.AllowUpdate = (DefaultableBoolean) 1;
    foreach (UltraGridRow row in this.gridPoCostCenters.Selected.Rows)
    {
      DataRow[] dataRowArray = this.dtCostCenter.Select($"Name='{((MenuItem) sender).Text}'");
      if (dataRowArray.Length != 0)
      {
        row.Cells["CostCenterName"].Value = dataRowArray[0]["Name"];
        row.Cells["OldCostCenterId"].Value = row.Cells["costCenterID"].Value;
        row.Cells["costCenterID"].Value = (object) int.Parse(dataRowArray[0]["CostCenterID"].ToString());
        ((AppearanceBase) row.Appearance).FontData.Bold = (DefaultableBoolean) 1;
      }
    }
    ((UltraGridBase) this.gridPoCostCenters).DisplayLayout.Bands[0].Override.AllowUpdate = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridPoCostCenters).UpdateData();
  }

  private void gridPoCostCenters_MouseUp(object sender, MouseEventArgs e)
  {
    if (e.Button != MouseButtons.Right || this.gridPoCostCenters.Selected.Rows == null || ((SparseCollectionBase) this.gridPoCostCenters.Selected.Rows).Count <= 0)
      return;
    this.contextCostCenter.Show((Control) this.gridPoCostCenters, ((Control) this.gridPoCostCenters).PointToClient(Control.MousePosition));
  }

  private void LoadData(int poNum)
  {
    DataSet dataSet = new DataSet();
    using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(new SqlCommand("spfin_GetPoCostCenterSplit", new SqlConnection(CurrentUser.Instance.ConnectionString))))
    {
      sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
      sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@ponum", (object) poNum);
      sqlDataAdapter.Fill(dataSet);
      dataSet.Tables[0].TableName = "PoCostCenterSplit";
    }
    ((UltraGridBase) this.gridPoCostCenters).DataSource = (object) dataSet;
    ((UltraGridBase) this.gridPoCostCenters).DisplayLayout.Bands[0].Columns["costCenterID"].Hidden = true;
    ((UltraGridBase) this.gridPoCostCenters).DisplayLayout.Bands[0].Columns["PoNum"].Hidden = true;
    ((UltraGridBase) this.gridPoCostCenters).DisplayLayout.Bands[0].Columns["Amount"].CellActivation = (Activation) 0;
  }

  private void btnUpdate_Click(object sender, EventArgs e)
  {
    DataSet dataSource = (DataSet) ((UltraGridBase) this.gridPoCostCenters).DataSource;
    SqlDataAdapter sqlDataAdapter = (SqlDataAdapter) null;
    if (dataSource.HasChanges())
    {
      try
      {
        SqlConnection connection = new SqlConnection(CurrentUser.Instance.ConnectionString);
        sqlDataAdapter = new SqlDataAdapter(new SqlCommand("spfin_GetPoCostCenterSplit", connection));
        sqlDataAdapter.UpdateCommand = new SqlCommand("spfin_UpdatePoDetailCostCenters", connection);
        sqlDataAdapter.UpdateCommand.CommandType = CommandType.StoredProcedure;
        sqlDataAdapter.UpdateCommand.Parameters.Add("@ponum", SqlDbType.Int, 4, "ponum");
        sqlDataAdapter.UpdateCommand.Parameters.Add("@expensecode", SqlDbType.Int, 4, "expensecode");
        sqlDataAdapter.UpdateCommand.Parameters.Add("@oldcostcenterid", SqlDbType.Int, 4, "oldCostCenterId");
        sqlDataAdapter.UpdateCommand.Parameters.Add("@newcostcenterid", SqlDbType.Int, 4, "CostCenterId");
        sqlDataAdapter.Update(dataSource, "PoCostCenterSplit");
      }
      finally
      {
        if (sqlDataAdapter.SelectCommand.Connection.State != ConnectionState.Closed)
          sqlDataAdapter.SelectCommand.Connection.Close();
        sqlDataAdapter.SelectCommand.Connection.Dispose();
        sqlDataAdapter.SelectCommand.Dispose();
        sqlDataAdapter.Dispose();
      }
    }
    this.LoadData(this.PoNum);
  }

  private void buttonClose_Click(object sender, EventArgs e) => this.Close();
}
