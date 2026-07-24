// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.OperatingExpenses.UserControls.OpenExpenses
// Assembly: MgaSystems.IMS.Accounting.OperatingExpenses, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 77B4DED4-9019-44D3-8D52-4669B0CA70E1
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.OperatingExpenses.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using Infragistics.Win.UltraWinToolbars;
using MGASystems.Common;
using MGASystems.Common.DataAccess;
using MGASystems.IMS.Accounting.AccountingDatasets;
using MGASystems.IMS.Accounting.Controls;
using MGASystems.IMS.Accounting.Core.ClassObjects;
using MGASystems.IMS.Accounting.OperatingExpenses.Exceptions;
using MGASystems.IMS.Accounting.OperatingExpenses.Forms;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.OperatingExpenses.UserControls;

public class OpenExpenses : UserControl
{
  private UltraGrid gridOpenExpenses;
  private dsOpenExpenses dsOpenExpenses1;
  private Label labelHeader;
  private UltraToolbarsManager ultraToolbarsManager1;
  private UltraToolbarsDockArea _OpenExpenses_Toolbars_Dock_Area_Left;
  private UltraToolbarsDockArea _OpenExpenses_Toolbars_Dock_Area_Right;
  private UltraToolbarsDockArea _OpenExpenses_Toolbars_Dock_Area_Top;
  private UltraToolbarsDockArea _OpenExpenses_Toolbars_Dock_Area_Bottom;
  private DateRangeOptionPicker dateRangeOptionPicker1;
  private IContainer components;
  private int glCompanyId;

  public OpenExpenses()
  {
    this.InitializeComponent();
    this.Dock = DockStyle.Fill;
  }

  public OpenExpenses(int glCompanyId)
  {
    this.InitializeComponent();
    this.Dock = DockStyle.Fill;
    this.GlCompanyId = glCompanyId;
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
    UltraGridBand ultraGridBand = new UltraGridBand(nameof (OpenExpenses), -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("poNum");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("payeeGuid");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("Payee");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("PODate");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("enteredBy");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("ExpenseTotal");
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("AmountRemaining", -1, (object) null, 0, (SortIndicator) 1, false);
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    UltraToolbar ultraToolbar = new UltraToolbar("UltraToolbar1");
    PopupMenuTool popupMenuTool = new PopupMenuTool("gridContextMenu");
    ButtonTool buttonTool1 = new ButtonTool("PAYMENT");
    ButtonTool buttonTool2 = new ButtonTool("VIEWHISTORY");
    ButtonTool buttonTool3 = new ButtonTool("VOID");
    ButtonTool buttonTool4 = new ButtonTool("PAYMENT");
    Appearance appearance14 = new Appearance();
    ResourceManager resourceManager = new ResourceManager(typeof (OpenExpenses));
    ButtonTool buttonTool5 = new ButtonTool("VOID");
    Appearance appearance15 = new Appearance();
    ButtonTool buttonTool6 = new ButtonTool("VIEWHISTORY");
    Appearance appearance16 = new Appearance();
    this.gridOpenExpenses = new UltraGrid();
    this.dsOpenExpenses1 = new dsOpenExpenses();
    this.labelHeader = new Label();
    this.ultraToolbarsManager1 = new UltraToolbarsManager(this.components);
    this._OpenExpenses_Toolbars_Dock_Area_Left = new UltraToolbarsDockArea();
    this._OpenExpenses_Toolbars_Dock_Area_Right = new UltraToolbarsDockArea();
    this._OpenExpenses_Toolbars_Dock_Area_Top = new UltraToolbarsDockArea();
    this._OpenExpenses_Toolbars_Dock_Area_Bottom = new UltraToolbarsDockArea();
    this.dateRangeOptionPicker1 = new DateRangeOptionPicker();
    ((ISupportInitialize) this.gridOpenExpenses).BeginInit();
    this.dsOpenExpenses1.BeginInit();
    ((ISupportInitialize) this.ultraToolbarsManager1).BeginInit();
    this.SuspendLayout();
    this.ultraToolbarsManager1.SetContextMenuUltra((Component) this.gridOpenExpenses, "gridContextMenu");
    ((UltraGridBase) this.gridOpenExpenses).DataMember = nameof (OpenExpenses);
    ((UltraGridBase) this.gridOpenExpenses).DataSource = (object) this.dsOpenExpenses1;
    ((AppearanceBase) appearance1).BackColor = Color.White;
    ((AppearanceBase) appearance1).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridOpenExpenses).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.gridOpenExpenses).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn1.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn1.Header).VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 49;
    ultraGridColumn2.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn2.Header).VisiblePosition = 1;
    ultraGridColumn2.Hidden = true;
    ultraGridColumn2.Width = 92;
    ultraGridColumn3.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn3.Header).VisiblePosition = 2;
    ultraGridColumn3.Width = 163;
    ultraGridColumn4.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn4.Header).Caption = "Expense Date";
    ((HeaderBase) ultraGridColumn4.Header).VisiblePosition = 3;
    ultraGridColumn4.Width = 147;
    ultraGridColumn5.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn5.Header).Caption = "Entered By";
    ((HeaderBase) ultraGridColumn5.Header).VisiblePosition = 4;
    ultraGridColumn5.Width = 152;
    ultraGridColumn6.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance2).TextHAlign = (HAlign) 3;
    ultraGridColumn6.CellAppearance = (AppearanceBase) appearance2;
    ultraGridColumn6.Format = "c";
    ((AppearanceBase) appearance3).TextHAlign = (HAlign) 3;
    ((HeaderBase) ultraGridColumn6.Header).Appearance = (AppearanceBase) appearance3;
    ((HeaderBase) ultraGridColumn6.Header).Caption = "Expense Total";
    ((HeaderBase) ultraGridColumn6.Header).VisiblePosition = 5;
    ultraGridColumn6.Width = 141;
    ultraGridColumn7.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance4).TextHAlign = (HAlign) 3;
    ultraGridColumn7.CellAppearance = (AppearanceBase) appearance4;
    ultraGridColumn7.Format = "c";
    ((AppearanceBase) appearance5).TextHAlign = (HAlign) 3;
    ((HeaderBase) ultraGridColumn7.Header).Appearance = (AppearanceBase) appearance5;
    ((HeaderBase) ultraGridColumn7.Header).Caption = "Balance";
    ((HeaderBase) ultraGridColumn7.Header).VisiblePosition = 6;
    ultraGridColumn7.Width = 171;
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
    ((UltraGridBase) this.gridOpenExpenses).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.gridOpenExpenses).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance6).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance6).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance6).ForeColor = Color.Black;
    ((UltraGridBase) this.gridOpenExpenses).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance6;
    ((UltraGridBase) this.gridOpenExpenses).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridOpenExpenses).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridOpenExpenses).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    ((UltraGridBase) this.gridOpenExpenses).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance7).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridOpenExpenses).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance7;
    ((UltraGridBase) this.gridOpenExpenses).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance8).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((AppearanceBase) appearance8).TextHAlign = (HAlign) 1;
    ((UltraGridBase) this.gridOpenExpenses).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance8;
    ((UltraGridBase) this.gridOpenExpenses).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    ((UltraGridBase) this.gridOpenExpenses).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance9).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridOpenExpenses).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance9;
    ((AppearanceBase) appearance10).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridOpenExpenses).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance10;
    ((UltraGridBase) this.gridOpenExpenses).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance11).BackColor = Color.Transparent;
    ((AppearanceBase) appearance11).ForeColor = Color.Black;
    ((UltraGridBase) this.gridOpenExpenses).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance11;
    ((AppearanceBase) appearance12).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance12).BorderColor = Color.Silver;
    scrollBarLook.ButtonAppearance = (AppearanceBase) appearance12;
    ((AppearanceBase) appearance13).BackColor = Color.White;
    scrollBarLook.TrackAppearance = (AppearanceBase) appearance13;
    ((UltraGridBase) this.gridOpenExpenses).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.gridOpenExpenses).Dock = DockStyle.Fill;
    ((UltraControlBase) this.gridOpenExpenses).UseFlatMode = (DefaultableBoolean) 1;
    ((Control) this.gridOpenExpenses).Location = new Point(0, 23);
    ((Control) this.gridOpenExpenses).Name = "gridOpenExpenses";
    ((Control) this.gridOpenExpenses).Size = new Size(776, 529);
    ((UltraControlBase) this.gridOpenExpenses).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.gridOpenExpenses).TabIndex = 0;
    this.dsOpenExpenses1.DataSetName = "dsOpenExpenses";
    this.dsOpenExpenses1.Locale = new CultureInfo("en-US");
    this.labelHeader.Dock = DockStyle.Top;
    this.labelHeader.Font = new Font("Tahoma", 11f, FontStyle.Bold);
    this.labelHeader.ForeColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.labelHeader.Location = new Point(0, 0);
    this.labelHeader.Name = "labelHeader";
    this.labelHeader.Size = new Size(776, 23);
    this.labelHeader.TabIndex = 1;
    this.labelHeader.Text = "Open Expenses";
    this.ultraToolbarsManager1.DesignerFlags = 1;
    this.ultraToolbarsManager1.DockWithinContainer = (Control) this;
    this.ultraToolbarsManager1.HideToolbars = true;
    this.ultraToolbarsManager1.ShowFullMenusDelay = 500;
    ultraToolbar.DockedColumn = 0;
    ultraToolbar.DockedRow = 0;
    ultraToolbar.Text = "UltraToolbar1";
    ultraToolbar.Visible = false;
    this.ultraToolbarsManager1.Toolbars.AddRange(new UltraToolbar[1]
    {
      ultraToolbar
    });
    ((ToolPropsBase) ((ToolBase) popupMenuTool).SharedProps).Caption = "gridContextMenu";
    ((ToolBase) buttonTool3).InstanceProps.IsFirstInGroup = true;
    ((ToolsCollectionBase) popupMenuTool.Tools).AddRange(new ToolBase[3]
    {
      (ToolBase) buttonTool1,
      (ToolBase) buttonTool2,
      (ToolBase) buttonTool3
    });
    ((AppearanceBase) appearance14).Image = resourceManager.GetObject("appearance14.Image");
    ((ToolPropsBase) ((ToolBase) buttonTool4).SharedProps).AppearancesSmall.Appearance = (AppearanceBase) appearance14;
    ((ToolPropsBase) ((ToolBase) buttonTool4).SharedProps).Caption = "Issue Payment";
    ((ToolPropsBase) ((ToolBase) buttonTool4).SharedProps).DisplayStyle = (ToolDisplayStyle) 4;
    ((AppearanceBase) appearance15).Image = resourceManager.GetObject("appearance15.Image");
    ((ToolPropsBase) ((ToolBase) buttonTool5).SharedProps).AppearancesSmall.Appearance = (AppearanceBase) appearance15;
    ((ToolPropsBase) ((ToolBase) buttonTool5).SharedProps).Caption = "Void Expense";
    ((ToolPropsBase) ((ToolBase) buttonTool5).SharedProps).DisplayStyle = (ToolDisplayStyle) 4;
    ((AppearanceBase) appearance16).Image = resourceManager.GetObject("appearance16.Image");
    ((ToolPropsBase) ((ToolBase) buttonTool6).SharedProps).AppearancesSmall.Appearance = (AppearanceBase) appearance16;
    ((ToolPropsBase) ((ToolBase) buttonTool6).SharedProps).Caption = "View Payment History";
    ((ToolPropsBase) ((ToolBase) buttonTool6).SharedProps).DisplayStyle = (ToolDisplayStyle) 4;
    ((ToolsCollectionBase) this.ultraToolbarsManager1.Tools).AddRange(new ToolBase[4]
    {
      (ToolBase) popupMenuTool,
      (ToolBase) buttonTool4,
      (ToolBase) buttonTool5,
      (ToolBase) buttonTool6
    });
    this.ultraToolbarsManager1.BeforeToolDropdown += new BeforeToolDropdownEventHandler(this.ultraToolbarsManager1_BeforeToolDropdown);
    this.ultraToolbarsManager1.ToolClick += new ToolClickEventHandler(this.ultraToolbarsManager1_ToolClick);
    ((Control) this._OpenExpenses_Toolbars_Dock_Area_Left).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._OpenExpenses_Toolbars_Dock_Area_Left).BackColor = Color.White;
    this._OpenExpenses_Toolbars_Dock_Area_Left.DockedPosition = (DockedPosition) 2;
    ((Control) this._OpenExpenses_Toolbars_Dock_Area_Left).ForeColor = Color.Black;
    ((Control) this._OpenExpenses_Toolbars_Dock_Area_Left).Location = new Point(0, 0);
    ((Control) this._OpenExpenses_Toolbars_Dock_Area_Left).Name = "_OpenExpenses_Toolbars_Dock_Area_Left";
    ((Control) this._OpenExpenses_Toolbars_Dock_Area_Left).Size = new Size(0, 552);
    this._OpenExpenses_Toolbars_Dock_Area_Left.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._OpenExpenses_Toolbars_Dock_Area_Right).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._OpenExpenses_Toolbars_Dock_Area_Right).BackColor = Color.White;
    this._OpenExpenses_Toolbars_Dock_Area_Right.DockedPosition = (DockedPosition) 3;
    ((Control) this._OpenExpenses_Toolbars_Dock_Area_Right).ForeColor = Color.Black;
    ((Control) this._OpenExpenses_Toolbars_Dock_Area_Right).Location = new Point(776, 0);
    ((Control) this._OpenExpenses_Toolbars_Dock_Area_Right).Name = "_OpenExpenses_Toolbars_Dock_Area_Right";
    ((Control) this._OpenExpenses_Toolbars_Dock_Area_Right).Size = new Size(0, 552);
    this._OpenExpenses_Toolbars_Dock_Area_Right.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._OpenExpenses_Toolbars_Dock_Area_Top).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._OpenExpenses_Toolbars_Dock_Area_Top).BackColor = Color.White;
    this._OpenExpenses_Toolbars_Dock_Area_Top.DockedPosition = (DockedPosition) 0;
    ((Control) this._OpenExpenses_Toolbars_Dock_Area_Top).ForeColor = Color.Black;
    ((Control) this._OpenExpenses_Toolbars_Dock_Area_Top).Location = new Point(0, 0);
    ((Control) this._OpenExpenses_Toolbars_Dock_Area_Top).Name = "_OpenExpenses_Toolbars_Dock_Area_Top";
    ((Control) this._OpenExpenses_Toolbars_Dock_Area_Top).Size = new Size(776, 0);
    this._OpenExpenses_Toolbars_Dock_Area_Top.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._OpenExpenses_Toolbars_Dock_Area_Bottom).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._OpenExpenses_Toolbars_Dock_Area_Bottom).BackColor = Color.White;
    this._OpenExpenses_Toolbars_Dock_Area_Bottom.DockedPosition = (DockedPosition) 1;
    ((Control) this._OpenExpenses_Toolbars_Dock_Area_Bottom).ForeColor = Color.Black;
    ((Control) this._OpenExpenses_Toolbars_Dock_Area_Bottom).Location = new Point(0, 552);
    ((Control) this._OpenExpenses_Toolbars_Dock_Area_Bottom).Name = "_OpenExpenses_Toolbars_Dock_Area_Bottom";
    ((Control) this._OpenExpenses_Toolbars_Dock_Area_Bottom).Size = new Size(776, 0);
    this._OpenExpenses_Toolbars_Dock_Area_Bottom.ToolbarsManager = this.ultraToolbarsManager1;
    this.dateRangeOptionPicker1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.dateRangeOptionPicker1.Location = new Point(192 /*0xC0*/, -1);
    this.dateRangeOptionPicker1.Name = "dateRangeOptionPicker1";
    this.dateRangeOptionPicker1.Size = new Size(584, 24);
    this.dateRangeOptionPicker1.TabIndex = 6;
    this.dateRangeOptionPicker1.DateChanged += new DateRangeOptionPicker.DateChangedEventHandler(this.dateRangeOptionPicker1_DateChanged);
    this.BackColor = Color.White;
    this.Controls.Add((Control) this.dateRangeOptionPicker1);
    this.Controls.Add((Control) this.gridOpenExpenses);
    this.Controls.Add((Control) this.labelHeader);
    this.Controls.Add((Control) this._OpenExpenses_Toolbars_Dock_Area_Left);
    this.Controls.Add((Control) this._OpenExpenses_Toolbars_Dock_Area_Right);
    this.Controls.Add((Control) this._OpenExpenses_Toolbars_Dock_Area_Top);
    this.Controls.Add((Control) this._OpenExpenses_Toolbars_Dock_Area_Bottom);
    this.Font = new Font("Tahoma", 8f);
    this.ForeColor = Color.Black;
    this.Name = nameof (OpenExpenses);
    this.Size = new Size(776, 552);
    ((ISupportInitialize) this.gridOpenExpenses).EndInit();
    this.dsOpenExpenses1.EndInit();
    ((ISupportInitialize) this.ultraToolbarsManager1).EndInit();
    this.ResumeLayout(false);
  }

  public int GlCompanyId
  {
    get => this.glCompanyId;
    set
    {
      this.glCompanyId = value;
      this.labelHeader.Text = "Open Expenses - " + AccountingCache.Instance.GlCompany(value).GlCompanyName;
      this.LoadOpenExpenses(value);
    }
  }

  private void LoadOpenExpenses(int glCompanyId)
  {
    using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(new SqlCommand("spFin_GetOpenExpenses", new SqlConnection(CurrentUser.Instance.ConnectionString))))
    {
      this.dsOpenExpenses1.Clear();
      sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
      sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@glCompanyId", (object) glCompanyId);
      sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@DATERANGEFROM", (object) this.dateRangeOptionPicker1.DateRangeFrom);
      sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@DATERANGETO ", (object) this.dateRangeOptionPicker1.DateRangeTo);
      sqlDataAdapter.Fill((DataTable) this.dsOpenExpenses1.OpenExpenses);
    }
  }

  private void ultraToolbarsManager1_ToolClick(object sender, ToolClickEventArgs e)
  {
    if (((SparseCollectionBase) this.gridOpenExpenses.Selected.Rows).Count == 0 || this.gridOpenExpenses.Selected.Rows[0] == null)
      return;
    UltraGridRow row = this.gridOpenExpenses.Selected.Rows[0];
    switch (((KeyedSubObjectBase) ((ToolEventArgs) e).Tool).Key)
    {
      case "PAYMENT":
        using (formIssueCheck formIssueCheck = new formIssueCheck(this.GlCompanyId, int.Parse(row.Cells["ponum"].Value.ToString()), new Guid(row.Cells["payeeGuid"].Value.ToString()), row.Cells["payee"].Value.ToString()))
        {
          if (formIssueCheck.ShowDialog() != DialogResult.OK)
            break;
          this.LoadOpenExpenses(this.GlCompanyId);
          break;
        }
      case "VOID":
        this.VoidPurchaseOrder(int.Parse(row.Cells["ponum"].Value.ToString()));
        this.LoadOpenExpenses(this.GlCompanyId);
        break;
      case "VIEWHISTORY":
        using (formExpensePaymentHistory expensePaymentHistory = new formExpensePaymentHistory(int.Parse(row.Cells["poNum"].Value.ToString())))
        {
          int num = (int) expensePaymentHistory.ShowDialog();
          break;
        }
    }
  }

  private bool HasPaymentsPosted(int PostNum)
  {
    return Database.Instance.QuerySP.PerformScalarQueryBool("dbo.HasPaymentsPosted", false, (object) "@poNum", (object) PostNum);
  }

  private void ultraToolbarsManager1_BeforeToolDropdown(
    object sender,
    BeforeToolDropdownEventArgs e)
  {
    if (((DisposableObjectCollectionBase) ((UltraGridBase) this.gridOpenExpenses).Rows).Count == 0)
    {
      ((CancelEventArgs) e).Cancel = true;
    }
    else
    {
      if (((SparseCollectionBase) this.gridOpenExpenses.Selected.Rows).Count == 0)
      {
        if (((UltraGridBase) this.gridOpenExpenses).ActiveRow != null)
        {
          ((GridItemBase) ((UltraGridBase) this.gridOpenExpenses).ActiveRow).Selected = true;
        }
        else
        {
          ((UltraGridBase) this.gridOpenExpenses).ActiveRow = ((UltraGridBase) this.gridOpenExpenses).Rows[0];
          ((UltraGridBase) this.gridOpenExpenses).Rows[0].Activate();
          ((GridItemBase) ((UltraGridBase) this.gridOpenExpenses).Rows[0]).Selected = true;
        }
      }
      ((ToolsCollectionBase) ((PopupMenuTool) ((ToolsCollectionBase) ((UltraToolbarsManager) sender).Tools)["gridContextMenu"]).Tools)["VIEWHISTORY"].SharedProps.Visible = this.ExpenseHasPayments(this.gridOpenExpenses.Selected.Rows[0]);
      ((ToolsCollectionBase) ((PopupMenuTool) ((ToolsCollectionBase) ((UltraToolbarsManager) sender).Tools)["gridContextMenu"]).Tools)["VOID"].SharedProps.Visible = !this.ExpenseHasPayments(this.gridOpenExpenses.Selected.Rows[0]);
    }
  }

  private bool ExpenseHasPayments(UltraGridRow row)
  {
    return !(Decimal.Parse(row.Cells["AmountRemaining"].Value.ToString()) == Decimal.Parse(row.Cells["ExpenseTotal"].Value.ToString()));
  }

  private void VoidPurchaseOrder(int poNum)
  {
    string cmdText = $"select count(distinct tblFin_JournalPostings.transactnum) from tblFin_JournalPostings inner join tblfin_journal on tblfin_journal.transactnum = tblfin_journalpostings.transactnum and (voiderfor is null and voidedby is null)where ponum = {poNum}";
    string str = $"select distinct tblFin_JournalPostings.transactnum from tblFin_JournalPostings inner join tblfin_journal on tblfin_journal.transactnum = tblfin_journalpostings.transactnum and (voiderfor is null and voidedby is null)where ponum = {poNum}";
    using (SqlCommand sqlCommand = new SqlCommand(cmdText, new SqlConnection(CurrentUser.Instance.ConnectionString)))
    {
      sqlCommand.CommandType = CommandType.Text;
      sqlCommand.Connection.Open();
      if (int.Parse(sqlCommand.ExecuteScalar().ToString()) > 1)
        throw new MultipleTransactionsFoundException("The system has found multiple transactions for the specified purchase order. This purchase order can not be voided by this method.");
      sqlCommand.CommandText = str;
      SqlDataReader sqlDataReader = sqlCommand.ExecuteReader(CommandBehavior.CloseConnection);
      if (!sqlDataReader.Read())
        return;
      Utility.VoidTransaction(int.Parse(sqlDataReader["transactnum"].ToString()), true);
    }
  }

  private void dateRangeOptionPicker1_DateChanged(object sender, MGASystems.IMS.Accounting.Controls.DateRangeEventArgs e)
  {
    this.Cursor = Cursors.WaitCursor;
    this.LoadOpenExpenses(this.GlCompanyId);
    this.Cursor = Cursors.Default;
  }
}
