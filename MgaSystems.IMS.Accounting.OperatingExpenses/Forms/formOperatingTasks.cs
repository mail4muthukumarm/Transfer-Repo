// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.OperatingExpenses.Forms.formOperatingTasks
// Assembly: MgaSystems.IMS.Accounting.OperatingExpenses, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 77B4DED4-9019-44D3-8D52-4669B0CA70E1
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.OperatingExpenses.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.UltraWinExplorerBar;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinToolbars;
using MGASystems.Common;
using MGASystems.IMS.Accounting.AccountingDatasets;
using MGASystems.IMS.Accounting.Services;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.OperatingExpenses.Forms;

public class formOperatingTasks : AccountingNoteDocumentSupport
{
  private UltraExplorerBar ultraExplorerBar1;
  private UltraExplorerBarContainerControl ultraExplorerBarContainerControl1;
  private UltraGrid gridPrepaidExpenses;
  private dsOpenPrepaidExpenses dsOpenPrepaidExpenses1;
  private IContainer components;
  private Thread LoadDataThread;
  private UltraToolbarsManager ultraToolbarsManager1;
  private UltraToolbarsDockArea _formOperatingTasks_Toolbars_Dock_Area_Left;
  private UltraToolbarsDockArea _formOperatingTasks_Toolbars_Dock_Area_Right;
  private UltraToolbarsDockArea _formOperatingTasks_Toolbars_Dock_Area_Top;
  private UltraToolbarsDockArea _formOperatingTasks_Toolbars_Dock_Area_Bottom;
  private dsOpenPrepaidExpenses ds;

  public formOperatingTasks()
  {
    this.InitializeComponent();
    this.ReloadData();
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
    UltraExplorerBarGroup explorerBarGroup = new UltraExplorerBarGroup();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    ResourceManager resourceManager = new ResourceManager(typeof (formOperatingTasks));
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    UltraGridBand ultraGridBand = new UltraGridBand("OpenPrePaid", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("PoNum");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("PoDate");
    Appearance appearance6 = new Appearance();
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("Payee");
    Appearance appearance7 = new Appearance();
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("PaymentDueDate");
    Appearance appearance8 = new Appearance();
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("GlCompanyId");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("Location");
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    UltraToolbar ultraToolbar = new UltraToolbar("UltraToolbar1");
    PopupMenuTool popupMenuTool = new PopupMenuTool("GridContextMenu");
    ButtonTool buttonTool1 = new ButtonTool("ReconcileExpense");
    ButtonTool buttonTool2 = new ButtonTool("VoidExpense");
    ButtonTool buttonTool3 = new ButtonTool("ReconcileExpense");
    Appearance appearance15 = new Appearance();
    ButtonTool buttonTool4 = new ButtonTool("VoidExpense");
    Appearance appearance16 = new Appearance();
    Appearance appearance17 = new Appearance();
    this.ultraExplorerBar1 = new UltraExplorerBar();
    this.ultraExplorerBarContainerControl1 = new UltraExplorerBarContainerControl();
    this.gridPrepaidExpenses = new UltraGrid();
    this.dsOpenPrepaidExpenses1 = new dsOpenPrepaidExpenses();
    this.ultraToolbarsManager1 = new UltraToolbarsManager(this.components);
    this._formOperatingTasks_Toolbars_Dock_Area_Left = new UltraToolbarsDockArea();
    this._formOperatingTasks_Toolbars_Dock_Area_Right = new UltraToolbarsDockArea();
    this._formOperatingTasks_Toolbars_Dock_Area_Top = new UltraToolbarsDockArea();
    this._formOperatingTasks_Toolbars_Dock_Area_Bottom = new UltraToolbarsDockArea();
    ((ISupportInitialize) this.ultraExplorerBar1).BeginInit();
    ((Control) this.ultraExplorerBar1).SuspendLayout();
    ((Control) this.ultraExplorerBarContainerControl1).SuspendLayout();
    ((ISupportInitialize) this.gridPrepaidExpenses).BeginInit();
    this.dsOpenPrepaidExpenses1.BeginInit();
    ((ISupportInitialize) this.ultraToolbarsManager1).BeginInit();
    this.SuspendLayout();
    ((AppearanceBase) appearance1).BackColor = Color.White;
    ((AppearanceBase) appearance1).BackColor2 = Color.White;
    ((AppearanceBase) appearance1).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.ultraExplorerBar1.Appearance = (AppearanceBase) appearance1;
    this.ultraExplorerBar1.BorderStyle = (UIElementBorderStyle) 1;
    this.ultraExplorerBar1.ColumnSpacing = 30;
    ((Control) this.ultraExplorerBar1).Controls.Add((Control) this.ultraExplorerBarContainerControl1);
    ((Control) this.ultraExplorerBar1).Dock = DockStyle.Fill;
    explorerBarGroup.Container = this.ultraExplorerBarContainerControl1;
    explorerBarGroup.Settings.ContainerHeight = 253;
    ((UltraExplorerBarSettingsBase) explorerBarGroup.Settings).MaxLines = 100;
    explorerBarGroup.Settings.ShowExpansionIndicator = (DefaultableBoolean) 2;
    explorerBarGroup.Settings.Style = (GroupStyle) 6;
    explorerBarGroup.Text = "Operating Alerts!";
    this.ultraExplorerBar1.Groups.AddRange(new UltraExplorerBarGroup[1]
    {
      explorerBarGroup
    });
    ((AppearanceBase) appearance2).BackColor = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance2).BackColor2 = Color.FromArgb(239, 247, 253);
    this.ultraExplorerBar1.GroupSettings.AppearancesSmall.Appearance = (AppearanceBase) appearance2;
    ((AppearanceBase) appearance3).AlphaLevel = (short) 38;
    ((AppearanceBase) appearance3).BackColor = Color.FromArgb(166, 202, 238);
    ((AppearanceBase) appearance3).BackColor2 = Color.FromArgb(166, 202, 238);
    ((AppearanceBase) appearance3).BackColorAlpha = (Alpha) 2;
    ((AppearanceBase) appearance3).BorderColor = Color.White;
    ((AppearanceBase) appearance3).FontData.Name = "Tahoma";
    ((AppearanceBase) appearance3).FontData.SizeInPoints = 8f;
    ((AppearanceBase) appearance3).ForeColor = Color.DarkBlue;
    ((AppearanceBase) appearance3).ForegroundAlpha = (Alpha) 2;
    ((AppearanceBase) appearance3).ImageBackground = (Image) resourceManager.GetObject("appearance3.ImageBackground");
    this.ultraExplorerBar1.GroupSettings.AppearancesSmall.HeaderAppearance = (AppearanceBase) appearance3;
    ((AppearanceBase) appearance4).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.ultraExplorerBar1.GroupSettings.AppearancesSmall.ItemAreaAppearance = (AppearanceBase) appearance4;
    this.ultraExplorerBar1.GroupSettings.BorderStyleItemArea = (UIElementBorderStyle) 4;
    this.ultraExplorerBar1.GroupSpacing = 10;
    ((Control) this.ultraExplorerBar1).Location = new Point(0, 0);
    this.ultraExplorerBar1.Margins.Bottom = 8;
    this.ultraExplorerBar1.Margins.Left = 8;
    this.ultraExplorerBar1.Margins.Right = 8;
    this.ultraExplorerBar1.Margins.Top = 8;
    ((Control) this.ultraExplorerBar1).Name = "ultraExplorerBar1";
    this.ultraExplorerBar1.NavigationAllowGroupReorder = false;
    this.ultraExplorerBar1.Scrollbars = (ScrollbarStyle) 2;
    ((Control) this.ultraExplorerBar1).Size = new Size(672, 312);
    ((UltraControlBase) this.ultraExplorerBar1).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.ultraExplorerBar1).TabIndex = 1;
    this.ultraExplorerBar1.UseLargeGroupHeaderImages = (DefaultableBoolean) 2;
    this.ultraExplorerBar1.ViewStyle = (UltraExplorerBarViewStyle) 2;
    ((Control) this.ultraExplorerBarContainerControl1).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((Control) this.ultraExplorerBarContainerControl1).Controls.Add((Control) this.gridPrepaidExpenses);
    ((Control) this.ultraExplorerBarContainerControl1).Location = new Point(22, 43);
    ((Control) this.ultraExplorerBarContainerControl1).Name = "ultraExplorerBarContainerControl1";
    ((Control) this.ultraExplorerBarContainerControl1).Size = new Size(635, 251);
    ((Control) this.ultraExplorerBarContainerControl1).TabIndex = 0;
    this.ultraToolbarsManager1.SetContextMenuUltra((Component) this.gridPrepaidExpenses, "GridContextMenu");
    ((UltraGridBase) this.gridPrepaidExpenses).DataMember = "OpenPrePaid";
    ((UltraGridBase) this.gridPrepaidExpenses).DataSource = (object) this.dsOpenPrepaidExpenses1;
    ((AppearanceBase) appearance5).BackColor = Color.White;
    ((AppearanceBase) appearance5).BorderColor = Color.FromArgb(133, 162, 221);
    ((UltraGridBase) this.gridPrepaidExpenses).DisplayLayout.Appearance = (AppearanceBase) appearance5;
    ((UltraGridBase) this.gridPrepaidExpenses).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((HeaderBase) ultraGridColumn1.Header).VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ((AppearanceBase) appearance6).TextHAlign = (HAlign) 1;
    ((HeaderBase) ultraGridColumn2.Header).Appearance = (AppearanceBase) appearance6;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Purchase Order Date";
    ((HeaderBase) ultraGridColumn2.Header).VisiblePosition = 1;
    ultraGridColumn2.Width = 108;
    ((AppearanceBase) appearance7).TextHAlign = (HAlign) 1;
    ((HeaderBase) ultraGridColumn3.Header).Appearance = (AppearanceBase) appearance7;
    ((HeaderBase) ultraGridColumn3.Header).VisiblePosition = 2;
    ultraGridColumn3.Width = 269;
    ((AppearanceBase) appearance8).TextHAlign = (HAlign) 1;
    ((HeaderBase) ultraGridColumn4.Header).Appearance = (AppearanceBase) appearance8;
    ((HeaderBase) ultraGridColumn4.Header).Caption = "Payment Date";
    ((HeaderBase) ultraGridColumn4.Header).VisiblePosition = 3;
    ultraGridColumn4.Width = 80 /*0x50*/;
    ((HeaderBase) ultraGridColumn5.Header).VisiblePosition = 4;
    ultraGridColumn5.Hidden = true;
    ((AppearanceBase) appearance9).TextHAlign = (HAlign) 1;
    ((HeaderBase) ultraGridColumn6.Header).Appearance = (AppearanceBase) appearance9;
    ((HeaderBase) ultraGridColumn6.Header).Caption = "GL Office";
    ((HeaderBase) ultraGridColumn6.Header).VisiblePosition = 5;
    ultraGridColumn6.Width = 176 /*0xB0*/;
    ultraGridBand.Columns.AddRange(new object[6]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4,
      (object) ultraGridColumn5,
      (object) ultraGridColumn6
    });
    ultraGridBand.Override.RowSelectors = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridPrepaidExpenses).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.gridPrepaidExpenses).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.gridPrepaidExpenses).DisplayLayout.Override.AllowAddNew = (AllowAddNew) 2;
    ((UltraGridBase) this.gridPrepaidExpenses).DisplayLayout.Override.AllowColMoving = (AllowColMoving) 1;
    ((UltraGridBase) this.gridPrepaidExpenses).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 1;
    ((UltraGridBase) this.gridPrepaidExpenses).DisplayLayout.Override.AllowColSwapping = (AllowColSwapping) 1;
    ((UltraGridBase) this.gridPrepaidExpenses).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridPrepaidExpenses).DisplayLayout.Override.AllowGroupBy = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridPrepaidExpenses).DisplayLayout.Override.AllowGroupMoving = (AllowGroupMoving) 1;
    ((UltraGridBase) this.gridPrepaidExpenses).DisplayLayout.Override.AllowGroupSwapping = (AllowGroupSwapping) 1;
    ((UltraGridBase) this.gridPrepaidExpenses).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridPrepaidExpenses).DisplayLayout.Override.AllowRowLayoutCellSizing = (RowLayoutSizing) 1;
    ((UltraGridBase) this.gridPrepaidExpenses).DisplayLayout.Override.AllowRowLayoutLabelSizing = (RowLayoutSizing) 1;
    ((UltraGridBase) this.gridPrepaidExpenses).DisplayLayout.Override.AllowRowSummaries = (AllowRowSummaries) 2;
    ((UltraGridBase) this.gridPrepaidExpenses).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance10).BorderColor = Color.Silver;
    ((UltraGridBase) this.gridPrepaidExpenses).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance10;
    ((UltraGridBase) this.gridPrepaidExpenses).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance11).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.gridPrepaidExpenses).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance11;
    ((AppearanceBase) appearance12).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridPrepaidExpenses).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance12;
    ((AppearanceBase) appearance13).BorderColor = Color.Silver;
    ((UltraGridBase) this.gridPrepaidExpenses).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance13;
    ((AppearanceBase) appearance14).BackColor = Color.NavajoWhite;
    ((AppearanceBase) appearance14).BackColor2 = Color.White;
    ((AppearanceBase) appearance14).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance14).ForeColor = Color.Black;
    ((UltraGridBase) this.gridPrepaidExpenses).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance14;
    ((Control) this.gridPrepaidExpenses).Dock = DockStyle.Fill;
    ((Control) this.gridPrepaidExpenses).Location = new Point(0, 0);
    ((Control) this.gridPrepaidExpenses).Name = "gridPrepaidExpenses";
    ((Control) this.gridPrepaidExpenses).Size = new Size(635, 251);
    ((UltraControlBase) this.gridPrepaidExpenses).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.gridPrepaidExpenses).TabIndex = 0;
    this.dsOpenPrepaidExpenses1.DataSetName = "dsOpenPrepaidExpenses";
    this.dsOpenPrepaidExpenses1.Locale = new CultureInfo("en-US");
    this.ultraToolbarsManager1.DesignerFlags = 1;
    this.ultraToolbarsManager1.DockWithinContainer = (Control) this;
    this.ultraToolbarsManager1.ShowFullMenusDelay = 500;
    ultraToolbar.DockedColumn = 0;
    ultraToolbar.DockedRow = 0;
    ultraToolbar.Text = "UltraToolbar1";
    ultraToolbar.Visible = false;
    this.ultraToolbarsManager1.Toolbars.AddRange(new UltraToolbar[1]
    {
      ultraToolbar
    });
    ((ToolPropsBase) ((ToolBase) popupMenuTool).SharedProps).Caption = "GridContextMenu";
    ((ToolBase) buttonTool2).InstanceProps.IsFirstInGroup = true;
    ((ToolsCollectionBase) popupMenuTool.Tools).AddRange(new ToolBase[2]
    {
      (ToolBase) buttonTool1,
      (ToolBase) buttonTool2
    });
    ((AppearanceBase) appearance15).Image = resourceManager.GetObject("appearance15.Image");
    ((ToolPropsBase) ((ToolBase) buttonTool3).SharedProps).AppearancesSmall.Appearance = (AppearanceBase) appearance15;
    ((ToolPropsBase) ((ToolBase) buttonTool3).SharedProps).Caption = "Reconcile Expense";
    ((ToolPropsBase) ((ToolBase) buttonTool3).SharedProps).DisplayStyle = (ToolDisplayStyle) 4;
    ((AppearanceBase) appearance16).Image = resourceManager.GetObject("appearance16.Image");
    ((ToolPropsBase) ((ToolBase) buttonTool4).SharedProps).AppearancesSmall.Appearance = (AppearanceBase) appearance16;
    ((AppearanceBase) appearance17).Image = resourceManager.GetObject("appearance17.Image");
    ((ToolPropsBase) ((ToolBase) buttonTool4).SharedProps).AppearancesSmall.AppearanceOnToolbar = (AppearanceBase) appearance17;
    ((ToolPropsBase) ((ToolBase) buttonTool4).SharedProps).Caption = "Void Expense";
    ((ToolPropsBase) ((ToolBase) buttonTool4).SharedProps).DisplayStyle = (ToolDisplayStyle) 4;
    ((ToolsCollectionBase) this.ultraToolbarsManager1.Tools).AddRange(new ToolBase[3]
    {
      (ToolBase) popupMenuTool,
      (ToolBase) buttonTool3,
      (ToolBase) buttonTool4
    });
    this.ultraToolbarsManager1.BeforeToolDropdown += new BeforeToolDropdownEventHandler(this.ultraToolbarsManager1_BeforeToolDropdown);
    this.ultraToolbarsManager1.ToolClick += new ToolClickEventHandler(this.ultraToolbarsManager1_ToolClick);
    ((Control) this._formOperatingTasks_Toolbars_Dock_Area_Left).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._formOperatingTasks_Toolbars_Dock_Area_Left).BackColor = SystemColors.Control;
    this._formOperatingTasks_Toolbars_Dock_Area_Left.DockedPosition = (DockedPosition) 2;
    ((Control) this._formOperatingTasks_Toolbars_Dock_Area_Left).ForeColor = Color.Black;
    ((Control) this._formOperatingTasks_Toolbars_Dock_Area_Left).Location = new Point(0, 0);
    ((Control) this._formOperatingTasks_Toolbars_Dock_Area_Left).Name = "_formOperatingTasks_Toolbars_Dock_Area_Left";
    ((Control) this._formOperatingTasks_Toolbars_Dock_Area_Left).Size = new Size(0, 312);
    this._formOperatingTasks_Toolbars_Dock_Area_Left.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._formOperatingTasks_Toolbars_Dock_Area_Right).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._formOperatingTasks_Toolbars_Dock_Area_Right).BackColor = SystemColors.Control;
    this._formOperatingTasks_Toolbars_Dock_Area_Right.DockedPosition = (DockedPosition) 3;
    ((Control) this._formOperatingTasks_Toolbars_Dock_Area_Right).ForeColor = Color.Black;
    ((Control) this._formOperatingTasks_Toolbars_Dock_Area_Right).Location = new Point(672, 0);
    ((Control) this._formOperatingTasks_Toolbars_Dock_Area_Right).Name = "_formOperatingTasks_Toolbars_Dock_Area_Right";
    ((Control) this._formOperatingTasks_Toolbars_Dock_Area_Right).Size = new Size(0, 312);
    this._formOperatingTasks_Toolbars_Dock_Area_Right.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._formOperatingTasks_Toolbars_Dock_Area_Top).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._formOperatingTasks_Toolbars_Dock_Area_Top).BackColor = SystemColors.Control;
    this._formOperatingTasks_Toolbars_Dock_Area_Top.DockedPosition = (DockedPosition) 0;
    ((Control) this._formOperatingTasks_Toolbars_Dock_Area_Top).ForeColor = Color.Black;
    ((Control) this._formOperatingTasks_Toolbars_Dock_Area_Top).Location = new Point(0, 0);
    ((Control) this._formOperatingTasks_Toolbars_Dock_Area_Top).Name = "_formOperatingTasks_Toolbars_Dock_Area_Top";
    ((Control) this._formOperatingTasks_Toolbars_Dock_Area_Top).Size = new Size(672, 0);
    this._formOperatingTasks_Toolbars_Dock_Area_Top.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._formOperatingTasks_Toolbars_Dock_Area_Bottom).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._formOperatingTasks_Toolbars_Dock_Area_Bottom).BackColor = SystemColors.Control;
    this._formOperatingTasks_Toolbars_Dock_Area_Bottom.DockedPosition = (DockedPosition) 1;
    ((Control) this._formOperatingTasks_Toolbars_Dock_Area_Bottom).ForeColor = Color.Black;
    ((Control) this._formOperatingTasks_Toolbars_Dock_Area_Bottom).Location = new Point(0, 312);
    ((Control) this._formOperatingTasks_Toolbars_Dock_Area_Bottom).Name = "_formOperatingTasks_Toolbars_Dock_Area_Bottom";
    ((Control) this._formOperatingTasks_Toolbars_Dock_Area_Bottom).Size = new Size(672, 0);
    this._formOperatingTasks_Toolbars_Dock_Area_Bottom.ToolbarsManager = this.ultraToolbarsManager1;
    this.AutoScaleBaseSize = new Size(5, 13);
    this.ClientSize = new Size(672, 312);
    this.Controls.Add((Control) this.ultraExplorerBar1);
    this.Controls.Add((Control) this._formOperatingTasks_Toolbars_Dock_Area_Left);
    this.Controls.Add((Control) this._formOperatingTasks_Toolbars_Dock_Area_Right);
    this.Controls.Add((Control) this._formOperatingTasks_Toolbars_Dock_Area_Top);
    this.Controls.Add((Control) this._formOperatingTasks_Toolbars_Dock_Area_Bottom);
    this.Font = new Font("Tahoma", 8f);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.MaximizeBox = false;
    this.Name = nameof (formOperatingTasks);
    this.Text = "Operating Expense Taks / Alerts";
    ((ISupportInitialize) this.ultraExplorerBar1).EndInit();
    ((Control) this.ultraExplorerBar1).ResumeLayout(false);
    ((Control) this.ultraExplorerBarContainerControl1).ResumeLayout(false);
    ((ISupportInitialize) this.gridPrepaidExpenses).EndInit();
    this.dsOpenPrepaidExpenses1.EndInit();
    ((ISupportInitialize) this.ultraToolbarsManager1).EndInit();
    this.ResumeLayout(false);
  }

  public void ReloadData()
  {
    if (this.LoadDataThread != null)
    {
      if (this.LoadDataThread.ThreadState != ThreadState.Stopped)
      {
        try
        {
          this.LoadDataThread.Abort();
        }
        catch (ThreadAbortException ex)
        {
        }
      }
    }
    this.LoadDataThread = new Thread(new ThreadStart(this.LoadData));
    this.LoadDataThread.Start();
  }

  private void LoadData()
  {
    using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter())
    {
      sqlDataAdapter.SelectCommand = new SqlCommand("spFin_GetOpenPrePaidExpenses", new SqlConnection(CurrentUser.Instance.ConnectionString));
      this.ds = new dsOpenPrepaidExpenses();
      sqlDataAdapter.Fill((DataTable) this.ds.OpenPrePaid);
    }
    if (this.IsDisposed || this.Disposing)
      return;
    this.Invoke((Delegate) new formOperatingTasks.LoadDataCompletedHandler(this.LoadDataComplete));
  }

  private void LoadDataComplete()
  {
    ((UltraGridBase) this.gridPrepaidExpenses).DataSource = (object) this.ds;
  }

  private void ultraToolbarsManager1_ToolClick(object sender, ToolClickEventArgs e)
  {
    UltraGridRow row = this.gridPrepaidExpenses.Selected.Rows[0];
    int PurchaseOrderNumber = int.Parse(row.Cells["ponum"].Value.ToString());
    DateTime dateTime = Convert.ToDateTime(row.Cells["paymentduedate"].Value.ToString());
    string Payee = row.Cells["payee"].Value.ToString();
    int GlCompanyId = int.Parse(row.Cells["glcompanyid"].Value.ToString());
    string key = ((KeyedSubObjectBase) ((ToolEventArgs) e).Tool).Key;
    if (!(key == "ReconcileExpense"))
    {
      int num1 = key == "VoidExpense" ? 1 : 0;
    }
    else
    {
      using (formReconcilePrePaidExpense reconcilePrePaidExpense = new formReconcilePrePaidExpense(PurchaseOrderNumber, dateTime, Payee, GlCompanyId))
      {
        int num2 = (int) reconcilePrePaidExpense.ShowDialog((IWin32Window) this);
      }
    }
  }

  private void ultraToolbarsManager1_BeforeToolDropdown(
    object sender,
    BeforeToolDropdownEventArgs e)
  {
    UltraGridRow context = (UltraGridRow) ((ControlUIElementBase) ((UltraGridBase) this.gridPrepaidExpenses).DisplayLayout.UIElement).LastElementEntered.GetContext(typeof (UltraGridRow), true);
    if (context == null)
      return;
    ((GridItemBase) context).Selected = true;
    ((UltraGridBase) this.gridPrepaidExpenses).ActiveRow = context;
    context.Activate();
  }

  private delegate void LoadDataCompletedHandler();
}
