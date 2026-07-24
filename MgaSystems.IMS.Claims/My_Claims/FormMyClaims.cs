// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.My_Claims.FormMyClaims
// Assembly: MgaSystems.IMS.Claims, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FCD9D0B7-28CF-40B9-8EB7-297871E1AF5F
// Assembly location: F:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using Infragistics.Win.UltraWinToolbars;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Claims.Properties;
using MGASystems.IMS.Forms;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Claims.My_Claims;

[TestForm]
public class FormMyClaims : FormBase
{
  private IContainer components;
  private UltraToolbarsManager ultraToolbarsManager1;
  private Panel FormMyClaims_Fill_Panel;
  private UltraGrid gridMyClaims;
  private UltraToolbarsDockArea _FormMyClaims_Toolbars_Dock_Area_Left;
  private UltraToolbarsDockArea _FormMyClaims_Toolbars_Dock_Area_Right;
  private UltraToolbarsDockArea _FormMyClaims_Toolbars_Dock_Area_Bottom;
  private UltraToolbarsDockArea _FormMyClaims_Toolbars_Dock_Area_Top;

  private string ClaimIdFilter { get; set; }

  private string ClaimNumberFilter { get; set; }

  private string LossDateFilter { get; set; }

  private string PolicyNumberFilter { get; set; }

  private string DateEnteredFilter { get; set; }

  private string InsuredNameFilter { get; set; }

  private string CommentsFilter { get; set; }

  private string AdjusterFilter { get; set; }

  private string UserFilter { get; set; }

  private string ModifiedByFilter { get; set; }

  private string StatusFilter { get; set; }

  private string CatastropheCodeFilter { get; set; }

  private string CompanyCATCodeFilter { get; set; }

  private string ManualClaimNumberFilter { get; set; }

  public FormMyClaims() => this.InitializeComponent();

  private void LoadClaimsData()
  {
    ((UltraGridBase) this.gridMyClaims).DataSource = (object) DefaultDatabase.ExecuteDataSet("spClaims_GetMyClaims", new object[2]
    {
      (object) "@userGuid",
      (object) CurrentUser.Instance.UserGUID
    });
  }

  private void FormMyClaims_Load(object sender, EventArgs e)
  {
    this.LoadClaimsData();
    this.CreateGridDataRelationships();
    this.FormatGrid();
    this.LoadFilters();
  }

  private void FormatGrid()
  {
    ((UltraControlBase) this.gridMyClaims).BeginUpdate();
    this.LoadUserLayout();
    UltraGridBand band1 = ((UltraGridBase) this.gridMyClaims).DisplayLayout.Bands[0];
    band1.Columns["Claim Number"].ButtonDisplayStyle = (ButtonDisplayStyle) 0;
    band1.Columns["Claim Number"].CellButtonAppearance.ImageHAlign = (HAlign) 3;
    band1.Columns["Claim Number"].CellButtonAppearance.Image = (object) Resources.View;
    band1.Override.HeaderAppearance.TextHAlign = (HAlign) 1;
    band1.Override.CellClickAction = (CellClickAction) 0;
    band1.Override.HeaderClickAction = (HeaderClickAction) 2;
    foreach (UltraGridColumn column in band1.Columns)
      column.CellActivation = (Activation) 3;
    band1.Columns["Claim Number"].Style = (ColumnStyle) 8;
    ((UltraGridBase) this.gridMyClaims).DisplayLayout.Bands[1].Columns["ClaimantGuid"].Hidden = true;
    ((UltraGridBase) this.gridMyClaims).DisplayLayout.Bands[1].Override.HeaderAppearance.TextHAlign = (HAlign) 1;
    ((HeaderBase) ((UltraGridBase) this.gridMyClaims).DisplayLayout.Bands[1].Columns["Payment Total"].Header).Appearance.TextHAlign = (HAlign) 3;
    ((UltraGridBase) this.gridMyClaims).DisplayLayout.Bands[1].Columns["Payment Total"].Format = "c";
    ((UltraGridBase) this.gridMyClaims).DisplayLayout.Bands[1].Columns["Payment Total"].CellAppearance.TextHAlign = (HAlign) 3;
    ((HeaderBase) ((UltraGridBase) this.gridMyClaims).DisplayLayout.Bands[1].Columns["Reserve Total"].Header).Appearance.TextHAlign = (HAlign) 3;
    ((UltraGridBase) this.gridMyClaims).DisplayLayout.Bands[1].Columns["Reserve Total"].Format = "c";
    ((UltraGridBase) this.gridMyClaims).DisplayLayout.Bands[1].Columns["Reserve Total"].CellAppearance.TextHAlign = (HAlign) 3;
    ((UltraGridBase) this.gridMyClaims).DisplayLayout.Bands[1].Columns["Insured?"].CellAppearance.TextHAlign = (HAlign) 2;
    ((UltraGridBase) this.gridMyClaims).DisplayLayout.Bands[1].Columns["Insured?"].Width = 75;
    UltraGridBand band2 = ((UltraGridBase) this.gridMyClaims).DisplayLayout.Bands[1];
    SummarySettings summarySettings = new SummarySettings();
    band2.Summaries.Clear();
    band2.Summaries.Add("PaymentTotalSum", (SummaryType) 1, band2.Columns["Payment Total"], (SummaryPosition) 3).DisplayFormat = "{0:c}";
    band2.Summaries.Add("ReserveTotalSum", (SummaryType) 1, band2.Columns["Reserve Total"], (SummaryPosition) 3).DisplayFormat = "{0:c}";
    band2.Override.SummaryFooterCaptionVisible = (DefaultableBoolean) 2;
    band2.Override.SummaryValueAppearance.FontData.Bold = (DefaultableBoolean) 1;
    band2.Override.SummaryValueAppearance.BackColor = Color.LightSteelBlue;
    band2.Override.SummaryValueAppearance.TextHAlign = (HAlign) 3;
    ((UltraControlBase) this.gridMyClaims).EndUpdate();
  }

  private void CreateGridDataRelationships()
  {
    try
    {
      DataSet dataSource = (DataSet) ((UltraGridBase) this.gridMyClaims).DataSource;
      dataSource.Relations.Add("ClaimantsToClaim", dataSource.Tables[0].Columns["Claim Id"], dataSource.Tables[1].Columns["Claim Id"]);
    }
    catch (Exception ex)
    {
      throw ex;
    }
  }

  private void ultraToolbarsManager1_ToolClick(object sender, ToolClickEventArgs e)
  {
    string key = ((KeyedSubObjectBase) ((ToolEventArgs) e).Tool).Key;
    if (key == null)
      return;
    switch (key.Length)
    {
      case 4:
        int num1 = key == "VIEW" ? 1 : 0;
        break;
      case 7:
        switch (key[0])
        {
          case 'A':
            int num2 = key == "ADDULAE" ? 1 : 0;
            return;
          case 'R':
            int num3 = key == "Refresh" ? 1 : 0;
            return;
          default:
            return;
        }
      case 9:
        if (!(key == "COLCHOOSE"))
          break;
        ((UltraGridBase) this.gridMyClaims).ShowColumnChooser();
        break;
      case 10:
        switch (key[3])
        {
          case 'P':
            int num4 = key == "ADDPAYMENT" ? 1 : 0;
            return;
          case 'R':
            int num5 = key == "ADDRESERVE" ? 1 : 0;
            return;
          default:
            return;
        }
      case 11:
        if (!(key == "SAVEFILTERS"))
          break;
        this.UpdateFilters();
        break;
      case 13:
        int num6 = key == "CLOSECLAIMANT" ? 1 : 0;
        break;
    }
  }

  private void gridMyClaims_BeforeColumnChooserDisplayed(
    object sender,
    BeforeColumnChooserDisplayedEventArgs e)
  {
    ((UltraGridBase) this.gridMyClaims).DisplayLayout.Bands[1].Columns["ClaimantGuid"].ExcludeFromColumnChooser = (ExcludeFromColumnChooser) 1;
    ((Form) e.Dialog).FormClosing += new FormClosingEventHandler(this.ColumnChooser_FormClosing);
  }

  private void ColumnChooser_FormClosing(object sender, FormClosingEventArgs e)
  {
    if (MessageBox.Show("Do you wish to save your layout changes?", "Save Changes?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
      this.SaveColumnLayout();
    ((Form) sender).FormClosing -= new FormClosingEventHandler(this.ColumnChooser_FormClosing);
  }

  private void gridReceivables_AfterColPosChanged(object sender, AfterColPosChangedEventArgs e)
  {
    this.SaveColumnLayout();
  }

  private void SaveColumnLayout()
  {
    MemoryStream memoryStream = new MemoryStream();
    try
    {
      ((UltraGridBase) this.gridMyClaims).DisplayLayout.Save((Stream) memoryStream, (PropertyCategories) -1);
      memoryStream.Seek(0L, SeekOrigin.Begin);
      DefaultDatabase.ExecuteNonQuery("spClaims_SaveUserClaimColumnSettings", new object[4]
      {
        (object) "@userGuid",
        (object) CurrentUser.Instance.UserGUID,
        (object) "@layout",
        (object) memoryStream.ToArray()
      });
    }
    finally
    {
      memoryStream.Dispose();
    }
  }

  private void LoadUserLayout()
  {
    MemoryStream memoryStream1 = new MemoryStream();
    DataRow dataRow = DefaultDatabase.ExecuteDataRow("spClaims_GetUserClaimColumnSettings", new object[2]
    {
      (object) "@userGuid",
      (object) CurrentUser.Instance.UserGUID
    });
    if (dataRow == null)
      return;
    if (string.IsNullOrEmpty(dataRow["GridLayout"].ToString()))
      return;
    try
    {
      MemoryStream memoryStream2 = new MemoryStream((byte[]) dataRow["gridLayout"]);
      memoryStream2.Seek(0L, SeekOrigin.Begin);
      ((UltraGridBase) this.gridMyClaims).DisplayLayout.Load((Stream) memoryStream2, (PropertyCategories) -1);
    }
    catch
    {
      int num = (int) MessageBox.Show("Error loading your saved layout.", "Error Loading Layout", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
  }

  private void LoadFilters()
  {
    DataTable dataTable = DefaultDatabase.ExecuteDataTable("spClaims_GetUserClaimFilters", new object[2]
    {
      (object) "@UserGuid",
      (object) CurrentUser.Instance.UserGUID
    });
    if (dataTable.Rows.Count != 1)
      return;
    if (((DisposableObjectCollectionBase) ((UltraGridBase) this.gridMyClaims).Rows).Count <= 0)
      return;
    try
    {
      DataRow row = dataTable.Rows[0];
      if (row["ClaimIdFilter"].ToString().Length > 0)
      {
        this.ClaimIdFilter = row["ClaimIdFilter"].ToString();
        ((UltraGridBase) this.gridMyClaims).Rows.ColumnFilters[0].FilterConditions.Add(new FilterCondition(((UltraGridBase) this.gridMyClaims).Rows.ColumnFilters[0].Column, (FilterComparisionOperator) 0, (object) this.ClaimIdFilter));
      }
      if (row["ClaimNumberFilter"].ToString().Length > 0)
      {
        this.ClaimNumberFilter = row["ClaimNumberFilter"].ToString();
        ((UltraGridBase) this.gridMyClaims).Rows.ColumnFilters[1].FilterConditions.Add(new FilterCondition(((UltraGridBase) this.gridMyClaims).Rows.ColumnFilters[1].Column, (FilterComparisionOperator) 0, (object) this.ClaimNumberFilter));
      }
      if (row["LossDateFilter"].ToString().Length > 0)
      {
        this.LossDateFilter = row["LossDateFilter"].ToString();
        ((UltraGridBase) this.gridMyClaims).Rows.ColumnFilters[2].FilterConditions.Add(new FilterCondition(((UltraGridBase) this.gridMyClaims).Rows.ColumnFilters[2].Column, (FilterComparisionOperator) 0, (object) this.LossDateFilter));
      }
      if (row["PolicyNumberFilter"].ToString().Length > 0)
      {
        this.PolicyNumberFilter = row["PolicyNumberFilter"].ToString();
        ((UltraGridBase) this.gridMyClaims).Rows.ColumnFilters[3].FilterConditions.Add(new FilterCondition(((UltraGridBase) this.gridMyClaims).Rows.ColumnFilters[3].Column, (FilterComparisionOperator) 0, (object) this.PolicyNumberFilter));
      }
      if (row["InsuredNameFilter"].ToString().Length > 0)
      {
        this.InsuredNameFilter = row["InsuredNameFilter"].ToString();
        ((UltraGridBase) this.gridMyClaims).Rows.ColumnFilters[4].FilterConditions.Add(new FilterCondition(((UltraGridBase) this.gridMyClaims).Rows.ColumnFilters[4].Column, (FilterComparisionOperator) 0, (object) this.InsuredNameFilter));
      }
      if (row["DateEnteredFilter"].ToString().Length > 0)
      {
        this.DateEnteredFilter = row["DateEnteredFilter"].ToString();
        ((UltraGridBase) this.gridMyClaims).Rows.ColumnFilters[5].FilterConditions.Add(new FilterCondition(((UltraGridBase) this.gridMyClaims).Rows.ColumnFilters[5].Column, (FilterComparisionOperator) 0, (object) this.DateEnteredFilter));
      }
      if (row["CommentsFilter"].ToString().Length > 0)
      {
        this.CommentsFilter = row["CommentsFilter"].ToString();
        ((UltraGridBase) this.gridMyClaims).Rows.ColumnFilters[6].FilterConditions.Add(new FilterCondition(((UltraGridBase) this.gridMyClaims).Rows.ColumnFilters[6].Column, (FilterComparisionOperator) 0, (object) this.CommentsFilter));
      }
      if (row["ManualClaimNumberFilter"].ToString().Length > 0)
      {
        this.ManualClaimNumberFilter = row["ManualClaimNumberFilter"].ToString();
        ((UltraGridBase) this.gridMyClaims).Rows.ColumnFilters[7].FilterConditions.Add(new FilterCondition(((UltraGridBase) this.gridMyClaims).Rows.ColumnFilters[7].Column, (FilterComparisionOperator) 0, (object) this.ManualClaimNumberFilter));
      }
      if (row["CatastropheCodeFilter"].ToString().Length > 0)
      {
        this.CatastropheCodeFilter = row["CatastropheCodeFilter"].ToString();
        ((UltraGridBase) this.gridMyClaims).Rows.ColumnFilters[8].FilterConditions.Add(new FilterCondition(((UltraGridBase) this.gridMyClaims).Rows.ColumnFilters[8].Column, (FilterComparisionOperator) 0, (object) this.CatastropheCodeFilter));
      }
      if (row["CompanyCATCodeFilter"].ToString().Length > 0)
      {
        this.CompanyCATCodeFilter = row["CompanyCATCodeFilter"].ToString();
        ((UltraGridBase) this.gridMyClaims).Rows.ColumnFilters[9].FilterConditions.Add(new FilterCondition(((UltraGridBase) this.gridMyClaims).Rows.ColumnFilters[9].Column, (FilterComparisionOperator) 0, (object) this.CompanyCATCodeFilter));
      }
      if (row["AdjusterFilter"].ToString().Length > 0)
      {
        this.AdjusterFilter = row["AdjusterFilter"].ToString();
        ((UltraGridBase) this.gridMyClaims).Rows.ColumnFilters[10].FilterConditions.Add(new FilterCondition(((UltraGridBase) this.gridMyClaims).Rows.ColumnFilters[10].Column, (FilterComparisionOperator) 0, (object) this.AdjusterFilter));
      }
      if (row["UserFilter"].ToString().Length > 0)
      {
        this.UserFilter = row["UserFilter"].ToString();
        ((UltraGridBase) this.gridMyClaims).Rows.ColumnFilters[11].FilterConditions.Add(new FilterCondition(((UltraGridBase) this.gridMyClaims).Rows.ColumnFilters[11].Column, (FilterComparisionOperator) 0, (object) this.UserFilter));
      }
      if (row["ModifiedByFilter"].ToString().Length > 0)
      {
        this.ModifiedByFilter = row["ModifiedByFilter"].ToString();
        ((UltraGridBase) this.gridMyClaims).Rows.ColumnFilters[12].FilterConditions.Add(new FilterCondition(((UltraGridBase) this.gridMyClaims).Rows.ColumnFilters[12].Column, (FilterComparisionOperator) 0, (object) this.ModifiedByFilter));
      }
      if (row["StatusFilter"].ToString().Length <= 0)
        return;
      this.StatusFilter = row["StatusFilter"].ToString();
      ((UltraGridBase) this.gridMyClaims).Rows.ColumnFilters[13].FilterConditions.Add(new FilterCondition(((UltraGridBase) this.gridMyClaims).Rows.ColumnFilters[13].Column, (FilterComparisionOperator) 0, (object) this.StatusFilter));
    }
    catch
    {
      int num = (int) MessageBox.Show("Error loading your saved filters.", "Error Loading Filters", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
  }

  private void UpdateFilters()
  {
    this.Cursor = MgaCursors.Working;
    try
    {
      DefaultDatabase.ExecuteNonQuery("spClaims_UpdateUserClaimFilters", new object[30]
      {
        (object) "@UserGuid",
        (object) CurrentUser.Instance.UserGUID,
        (object) "@ClaimIdFilter",
        (object) this.ClaimIdFilter,
        (object) "@ClaimNumberFilter",
        (object) this.ClaimNumberFilter,
        (object) "@LossDateFilter",
        (object) this.LossDateFilter,
        (object) "@PolicyNumberFilter",
        (object) this.PolicyNumberFilter,
        (object) "@DateEnteredFilter",
        (object) this.DateEnteredFilter,
        (object) "@InsuredNameFilter",
        (object) this.InsuredNameFilter,
        (object) "@CommentsFilter",
        (object) this.CommentsFilter,
        (object) "@AdjusterFilter",
        (object) this.AdjusterFilter,
        (object) "@UserFilter",
        (object) this.UserFilter,
        (object) "@ModifiedByFilter",
        (object) this.ModifiedByFilter,
        (object) "@StatusFilter",
        (object) this.StatusFilter,
        (object) "@CatastropheCodeFilter",
        (object) this.CatastropheCodeFilter,
        (object) "@CompanyCATCodeFilter",
        (object) this.CompanyCATCodeFilter,
        (object) "@ManualClaimNumberFilter",
        (object) this.ManualClaimNumberFilter
      });
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
    }
  }

  private void gridMyClaims_ClickCellButton(object sender, CellEventArgs e)
  {
    if (!(((KeyedSubObjectBase) e.Cell.Column).Key == "Claim Number"))
      return;
    this.Cursor = MgaCursors.Working;
    try
    {
      FormClaims form = ObjectFactory.Instance.CreateForm(typeof (FormClaims), new object[1]
      {
        (object) (Claim) ObjectFactory.Instance.CreateObject(typeof (Claim), new object[1]
        {
          (object) (int) e.Cell.Row.Cells["Claim Id"].Value
        })
      }) as FormClaims;
      form.MdiParent = MDIControls.Instance.MDIParent;
      form.Show();
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
    }
  }

  private void gridMyClaims_AfterRowFilterChanged(object sender, AfterRowFilterChangedEventArgs e)
  {
    string str = ((KeyedSubObjectBase) e.NewColumnFilter.Column).Key.ToString();
    if (str == null)
      return;
    switch (str.Length)
    {
      case 4:
        if (!(str == "User"))
          break;
        this.UserFilter = ((DisposableObjectCollectionBase) e.NewColumnFilter.FilterConditions).Count > 0 ? e.NewColumnFilter.FilterConditions[0].CompareValue.ToString() : string.Empty;
        break;
      case 6:
        if (!(str == "Status"))
          break;
        this.StatusFilter = ((DisposableObjectCollectionBase) e.NewColumnFilter.FilterConditions).Count > 0 ? e.NewColumnFilter.FilterConditions[0].CompareValue.ToString() : string.Empty;
        break;
      case 7:
        if (!(str == "ClaimId"))
          break;
        this.ClaimIdFilter = ((DisposableObjectCollectionBase) e.NewColumnFilter.FilterConditions).Count > 0 ? e.NewColumnFilter.FilterConditions[0].CompareValue.ToString() : string.Empty;
        break;
      case 8:
        switch (str[0])
        {
          case 'A':
            if (!(str == "Adjuster"))
              return;
            this.AdjusterFilter = ((DisposableObjectCollectionBase) e.NewColumnFilter.FilterConditions).Count > 0 ? e.NewColumnFilter.FilterConditions[0].CompareValue.ToString() : string.Empty;
            return;
          case 'C':
            if (!(str == "Comments"))
              return;
            this.CommentsFilter = ((DisposableObjectCollectionBase) e.NewColumnFilter.FilterConditions).Count > 0 ? e.NewColumnFilter.FilterConditions[0].CompareValue.ToString() : string.Empty;
            return;
          default:
            return;
        }
      case 9:
        if (!(str == "Loss Date"))
          break;
        this.LossDateFilter = ((DisposableObjectCollectionBase) e.NewColumnFilter.FilterConditions).Count > 0 ? e.NewColumnFilter.FilterConditions[0].CompareValue.ToString() : string.Empty;
        break;
      case 10:
        if (!(str == "ModifiedBy"))
          break;
        this.ModifiedByFilter = ((DisposableObjectCollectionBase) e.NewColumnFilter.FilterConditions).Count > 0 ? e.NewColumnFilter.FilterConditions[0].CompareValue.ToString() : string.Empty;
        break;
      case 12:
        switch (str[0])
        {
          case 'C':
            if (!(str == "Claim Number"))
              return;
            this.ClaimNumberFilter = ((DisposableObjectCollectionBase) e.NewColumnFilter.FilterConditions).Count > 0 ? e.NewColumnFilter.FilterConditions[0].CompareValue.ToString() : string.Empty;
            return;
          case 'D':
            if (!(str == "Date Entered"))
              return;
            this.DateEnteredFilter = ((DisposableObjectCollectionBase) e.NewColumnFilter.FilterConditions).Count > 0 ? e.NewColumnFilter.FilterConditions[0].CompareValue.ToString() : string.Empty;
            return;
          case 'I':
            if (!(str == "Insured Name"))
              return;
            this.InsuredNameFilter = ((DisposableObjectCollectionBase) e.NewColumnFilter.FilterConditions).Count > 0 ? e.NewColumnFilter.FilterConditions[0].CompareValue.ToString() : string.Empty;
            return;
          case 'P':
            if (!(str == "PolicyNumber"))
              return;
            this.PolicyNumberFilter = ((DisposableObjectCollectionBase) e.NewColumnFilter.FilterConditions).Count > 0 ? e.NewColumnFilter.FilterConditions[0].CompareValue.ToString() : string.Empty;
            return;
          default:
            return;
        }
      case 14:
        if (!(str == "Manual Claim #"))
          break;
        this.ManualClaimNumberFilter = ((DisposableObjectCollectionBase) e.NewColumnFilter.FilterConditions).Count > 0 ? e.NewColumnFilter.FilterConditions[0].CompareValue.ToString() : string.Empty;
        break;
      case 16 /*0x10*/:
        switch (str[1])
        {
          case 'a':
            if (!(str == "Catastrophe Code"))
              return;
            this.CatastropheCodeFilter = ((DisposableObjectCollectionBase) e.NewColumnFilter.FilterConditions).Count > 0 ? e.NewColumnFilter.FilterConditions[0].CompareValue.ToString() : string.Empty;
            return;
          case 'o':
            if (!(str == "Company CAT Code"))
              return;
            this.CompanyCATCodeFilter = ((DisposableObjectCollectionBase) e.NewColumnFilter.FilterConditions).Count > 0 ? e.NewColumnFilter.FilterConditions[0].CompareValue.ToString() : string.Empty;
            return;
          default:
            return;
        }
    }
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
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    UltraToolbar ultraToolbar = new UltraToolbar("UltraToolbar1");
    ButtonTool buttonTool1 = new ButtonTool("Refresh");
    ButtonTool buttonTool2 = new ButtonTool("VIEW");
    ButtonTool buttonTool3 = new ButtonTool("ADDPAYMENT");
    ButtonTool buttonTool4 = new ButtonTool("ADDRESERVE");
    ButtonTool buttonTool5 = new ButtonTool("ADDULAE");
    ButtonTool buttonTool6 = new ButtonTool("CLOSECLAIMANT");
    ButtonTool buttonTool7 = new ButtonTool("COLCHOOSE");
    ButtonTool buttonTool8 = new ButtonTool("SAVEFILTERS");
    ButtonTool buttonTool9 = new ButtonTool("Refresh");
    Appearance appearance10 = new Appearance();
    ButtonTool buttonTool10 = new ButtonTool("ADDPAYMENT");
    Appearance appearance11 = new Appearance();
    ButtonTool buttonTool11 = new ButtonTool("ADDRESERVE");
    Appearance appearance12 = new Appearance();
    ButtonTool buttonTool12 = new ButtonTool("ADDULAE");
    Appearance appearance13 = new Appearance();
    ButtonTool buttonTool13 = new ButtonTool("CLOSECLAIMANT");
    Appearance appearance14 = new Appearance();
    ButtonTool buttonTool14 = new ButtonTool("VIEW");
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    ButtonTool buttonTool15 = new ButtonTool("COLCHOOSE");
    Appearance appearance17 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormMyClaims));
    ButtonTool buttonTool16 = new ButtonTool("SAVEFILTERS");
    Appearance appearance18 = new Appearance();
    this.FormMyClaims_Fill_Panel = new Panel();
    this.gridMyClaims = new UltraGrid();
    this._FormMyClaims_Toolbars_Dock_Area_Left = new UltraToolbarsDockArea();
    this.ultraToolbarsManager1 = new UltraToolbarsManager(this.components);
    this._FormMyClaims_Toolbars_Dock_Area_Right = new UltraToolbarsDockArea();
    this._FormMyClaims_Toolbars_Dock_Area_Top = new UltraToolbarsDockArea();
    this._FormMyClaims_Toolbars_Dock_Area_Bottom = new UltraToolbarsDockArea();
    this.FormMyClaims_Fill_Panel.SuspendLayout();
    ((ISupportInitialize) this.gridMyClaims).BeginInit();
    ((ISupportInitialize) this.ultraToolbarsManager1).BeginInit();
    this.SuspendLayout();
    this.FormMyClaims_Fill_Panel.BackColor = Color.Transparent;
    this.FormMyClaims_Fill_Panel.Controls.Add((Control) this.gridMyClaims);
    this.FormMyClaims_Fill_Panel.Cursor = Cursors.Default;
    this.FormMyClaims_Fill_Panel.Dock = DockStyle.Fill;
    this.FormMyClaims_Fill_Panel.Location = new Point(0, 49);
    this.FormMyClaims_Fill_Panel.Name = "FormMyClaims_Fill_Panel";
    this.FormMyClaims_Fill_Panel.Size = new Size(1166, 738);
    this.FormMyClaims_Fill_Panel.TabIndex = 0;
    ((AppearanceBase) appearance1).BackColor = Color.White;
    ((AppearanceBase) appearance1).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridMyClaims).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.gridMyClaims).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((UltraGridBase) this.gridMyClaims).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance2).BackColor = Color.Orange;
    ((AppearanceBase) appearance2).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance2).ForeColor = Color.Black;
    ((UltraGridBase) this.gridMyClaims).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance2;
    ((UltraGridBase) this.gridMyClaims).DisplayLayout.Override.AllowAddNew = (AllowAddNew) 2;
    ((UltraGridBase) this.gridMyClaims).DisplayLayout.Override.AllowColMoving = (AllowColMoving) 3;
    ((UltraGridBase) this.gridMyClaims).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridMyClaims).DisplayLayout.Override.AllowColSwapping = (AllowColSwapping) 3;
    ((UltraGridBase) this.gridMyClaims).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridMyClaims).DisplayLayout.Override.AllowGroupBy = (DefaultableBoolean) 1;
    ((UltraGridBase) this.gridMyClaims).DisplayLayout.Override.AllowGroupMoving = (AllowGroupMoving) 2;
    ((UltraGridBase) this.gridMyClaims).DisplayLayout.Override.AllowGroupSwapping = (AllowGroupSwapping) 2;
    ((UltraGridBase) this.gridMyClaims).DisplayLayout.Override.AllowMultiCellOperations = (AllowMultiCellOperation) 6;
    ((UltraGridBase) this.gridMyClaims).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    ((UltraGridBase) this.gridMyClaims).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance3).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridMyClaims).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance3;
    ((UltraGridBase) this.gridMyClaims).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance4).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.gridMyClaims).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance4;
    ((UltraGridBase) this.gridMyClaims).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.gridMyClaims).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance5).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridMyClaims).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance5;
    ((AppearanceBase) appearance6).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridMyClaims).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance6;
    ((UltraGridBase) this.gridMyClaims).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance7).BackColor = Color.Orange;
    ((AppearanceBase) appearance7).ForeColor = Color.Black;
    ((UltraGridBase) this.gridMyClaims).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance7;
    ((AppearanceBase) appearance8).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance8).BorderColor = Color.Silver;
    scrollBarLook.ButtonAppearance = (AppearanceBase) appearance8;
    ((AppearanceBase) appearance9).BackColor = Color.White;
    scrollBarLook.TrackAppearance = (AppearanceBase) appearance9;
    ((UltraGridBase) this.gridMyClaims).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.gridMyClaims).Dock = DockStyle.Fill;
    ((Control) this.gridMyClaims).Location = new Point(0, 0);
    ((Control) this.gridMyClaims).Name = "gridMyClaims";
    ((Control) this.gridMyClaims).Size = new Size(1166, 738);
    ((Control) this.gridMyClaims).TabIndex = 0;
    ((UltraControlBase) this.gridMyClaims).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridMyClaims).UseOsThemes = (DefaultableBoolean) 2;
    this.gridMyClaims.ClickCellButton += new CellEventHandler(this.gridMyClaims_ClickCellButton);
    ((UltraGridBase) this.gridMyClaims).AfterRowFilterChanged += new AfterRowFilterChangedEventHandler(this.gridMyClaims_AfterRowFilterChanged);
    ((UltraGridBase) this.gridMyClaims).BeforeColumnChooserDisplayed += new BeforeColumnChooserDisplayedEventHandler(this.gridMyClaims_BeforeColumnChooserDisplayed);
    ((Control) this._FormMyClaims_Toolbars_Dock_Area_Left).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormMyClaims_Toolbars_Dock_Area_Left).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._FormMyClaims_Toolbars_Dock_Area_Left.DockedPosition = (DockedPosition) 2;
    ((Control) this._FormMyClaims_Toolbars_Dock_Area_Left).ForeColor = SystemColors.ControlText;
    ((Control) this._FormMyClaims_Toolbars_Dock_Area_Left).Location = new Point(0, 49);
    ((Control) this._FormMyClaims_Toolbars_Dock_Area_Left).Name = "_FormMyClaims_Toolbars_Dock_Area_Left";
    ((Control) this._FormMyClaims_Toolbars_Dock_Area_Left).Size = new Size(0, 738);
    this._FormMyClaims_Toolbars_Dock_Area_Left.ToolbarsManager = this.ultraToolbarsManager1;
    this.ultraToolbarsManager1.DesignerFlags = 1;
    this.ultraToolbarsManager1.DockWithinContainer = (Control) this;
    this.ultraToolbarsManager1.DockWithinContainerBaseType = typeof (FormBase);
    this.ultraToolbarsManager1.MdiMergeable = false;
    this.ultraToolbarsManager1.ShowFullMenusDelay = 500;
    this.ultraToolbarsManager1.Style = (ToolbarStyle) 5;
    ultraToolbar.DockedColumn = 0;
    ultraToolbar.DockedRow = 0;
    ultraToolbar.FloatingLocation = new Point(705, 429);
    ultraToolbar.FloatingSize = new Size(212, 86);
    ultraToolbar.IsMainMenuBar = true;
    ((ToolBase) buttonTool2).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) buttonTool3).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) buttonTool6).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) buttonTool7).InstanceProps.IsFirstInGroup = true;
    ((UltraToolbarBase) ultraToolbar).NonInheritedTools.AddRange(new ToolBase[8]
    {
      (ToolBase) buttonTool1,
      (ToolBase) buttonTool2,
      (ToolBase) buttonTool3,
      (ToolBase) buttonTool4,
      (ToolBase) buttonTool5,
      (ToolBase) buttonTool6,
      (ToolBase) buttonTool7,
      (ToolBase) buttonTool8
    });
    ultraToolbar.Settings.AllowCustomize = (DefaultableBoolean) 2;
    ultraToolbar.Settings.AllowDockBottom = (DefaultableBoolean) 2;
    ultraToolbar.Settings.AllowDockLeft = (DefaultableBoolean) 2;
    ultraToolbar.Settings.AllowDockRight = (DefaultableBoolean) 2;
    ultraToolbar.Settings.AllowFloating = (DefaultableBoolean) 2;
    ultraToolbar.Settings.AllowHiding = (DefaultableBoolean) 2;
    ultraToolbar.Settings.CaptionPlacement = (TextPlacement) 2;
    ultraToolbar.Settings.FillEntireRow = (DefaultableBoolean) 1;
    ultraToolbar.Settings.GrabHandleStyle = (GrabHandleStyle) 1;
    ultraToolbar.Text = "UltraToolbar1";
    this.ultraToolbarsManager1.Toolbars.AddRange(new UltraToolbar[1]
    {
      ultraToolbar
    });
    ((AppearanceBase) appearance10).Image = (object) Resources.Refresh;
    ((ToolPropsBase) ((ToolBase) buttonTool9).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance10;
    ((ToolPropsBase) ((ToolBase) buttonTool9).SharedPropsInternal).Caption = "Refresh";
    ((ToolPropsBase) ((ToolBase) buttonTool9).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((AppearanceBase) appearance11).Image = (object) Resources.Coins;
    ((ToolPropsBase) ((ToolBase) buttonTool10).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance11;
    ((ToolPropsBase) ((ToolBase) buttonTool10).SharedPropsInternal).Caption = "Add Payment";
    ((ToolPropsBase) ((ToolBase) buttonTool10).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((ToolBase) buttonTool10).SharedPropsInternal.Visible = false;
    ((AppearanceBase) appearance12).Image = (object) Resources.AddReserve;
    ((ToolPropsBase) ((ToolBase) buttonTool11).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance12;
    ((ToolPropsBase) ((ToolBase) buttonTool11).SharedPropsInternal).Caption = "Add Reserve";
    ((ToolPropsBase) ((ToolBase) buttonTool11).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((ToolBase) buttonTool11).SharedPropsInternal.Visible = false;
    ((AppearanceBase) appearance13).Image = (object) Resources.PaymentsReserveSmall;
    ((ToolPropsBase) ((ToolBase) buttonTool12).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance13;
    ((ToolPropsBase) ((ToolBase) buttonTool12).SharedPropsInternal).Caption = "Add ULAE Transaction";
    ((ToolPropsBase) ((ToolBase) buttonTool12).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((ToolBase) buttonTool12).SharedPropsInternal.Visible = false;
    ((AppearanceBase) appearance14).Image = (object) Resources.CloseClaim;
    ((ToolPropsBase) ((ToolBase) buttonTool13).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance14;
    ((ToolPropsBase) ((ToolBase) buttonTool13).SharedPropsInternal).Caption = "Close Claimant";
    ((ToolPropsBase) ((ToolBase) buttonTool13).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((ToolBase) buttonTool13).SharedPropsInternal.Visible = false;
    ((AppearanceBase) appearance15).Image = (object) Resources.SearchClaimSmall;
    ((ToolPropsBase) ((ToolBase) buttonTool14).SharedPropsInternal).AppearancesLarge.Appearance = (AppearanceBase) appearance15;
    ((AppearanceBase) appearance16).Image = (object) Resources.SearchClaimSmall;
    ((ToolPropsBase) ((ToolBase) buttonTool14).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance16;
    ((ToolPropsBase) ((ToolBase) buttonTool14).SharedPropsInternal).Caption = "View Claim";
    ((ToolPropsBase) ((ToolBase) buttonTool14).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((AppearanceBase) appearance17).Image = componentResourceManager.GetObject("appearance17.Image");
    ((ToolPropsBase) ((ToolBase) buttonTool15).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance17;
    ((ToolPropsBase) ((ToolBase) buttonTool15).SharedPropsInternal).Caption = "Column Chooser";
    ((ToolPropsBase) ((ToolBase) buttonTool15).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((AppearanceBase) appearance18).Image = componentResourceManager.GetObject("appearance18.Image");
    ((ToolPropsBase) ((ToolBase) buttonTool16).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance18;
    ((ToolPropsBase) ((ToolBase) buttonTool16).SharedPropsInternal).Caption = "Save Filters";
    ((ToolPropsBase) ((ToolBase) buttonTool16).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((ToolsCollectionBase) this.ultraToolbarsManager1.Tools).AddRange(new ToolBase[8]
    {
      (ToolBase) buttonTool9,
      (ToolBase) buttonTool10,
      (ToolBase) buttonTool11,
      (ToolBase) buttonTool12,
      (ToolBase) buttonTool13,
      (ToolBase) buttonTool14,
      (ToolBase) buttonTool15,
      (ToolBase) buttonTool16
    });
    this.ultraToolbarsManager1.ToolClick += new ToolClickEventHandler(this.ultraToolbarsManager1_ToolClick);
    ((Control) this._FormMyClaims_Toolbars_Dock_Area_Right).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormMyClaims_Toolbars_Dock_Area_Right).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._FormMyClaims_Toolbars_Dock_Area_Right.DockedPosition = (DockedPosition) 3;
    ((Control) this._FormMyClaims_Toolbars_Dock_Area_Right).ForeColor = SystemColors.ControlText;
    ((Control) this._FormMyClaims_Toolbars_Dock_Area_Right).Location = new Point(1166, 49);
    ((Control) this._FormMyClaims_Toolbars_Dock_Area_Right).Name = "_FormMyClaims_Toolbars_Dock_Area_Right";
    ((Control) this._FormMyClaims_Toolbars_Dock_Area_Right).Size = new Size(0, 738);
    this._FormMyClaims_Toolbars_Dock_Area_Right.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._FormMyClaims_Toolbars_Dock_Area_Top).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormMyClaims_Toolbars_Dock_Area_Top).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._FormMyClaims_Toolbars_Dock_Area_Top.DockedPosition = (DockedPosition) 0;
    ((Control) this._FormMyClaims_Toolbars_Dock_Area_Top).ForeColor = SystemColors.ControlText;
    ((Control) this._FormMyClaims_Toolbars_Dock_Area_Top).Location = new Point(0, 0);
    ((Control) this._FormMyClaims_Toolbars_Dock_Area_Top).Name = "_FormMyClaims_Toolbars_Dock_Area_Top";
    ((Control) this._FormMyClaims_Toolbars_Dock_Area_Top).Size = new Size(1166, 49);
    this._FormMyClaims_Toolbars_Dock_Area_Top.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._FormMyClaims_Toolbars_Dock_Area_Bottom).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormMyClaims_Toolbars_Dock_Area_Bottom).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._FormMyClaims_Toolbars_Dock_Area_Bottom.DockedPosition = (DockedPosition) 1;
    ((Control) this._FormMyClaims_Toolbars_Dock_Area_Bottom).ForeColor = SystemColors.ControlText;
    ((Control) this._FormMyClaims_Toolbars_Dock_Area_Bottom).Location = new Point(0, 787);
    ((Control) this._FormMyClaims_Toolbars_Dock_Area_Bottom).Name = "_FormMyClaims_Toolbars_Dock_Area_Bottom";
    ((Control) this._FormMyClaims_Toolbars_Dock_Area_Bottom).Size = new Size(1166, 0);
    this._FormMyClaims_Toolbars_Dock_Area_Bottom.ToolbarsManager = this.ultraToolbarsManager1;
    this.AutoScaleDimensions = new SizeF(8f, 17f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(1166, 787);
    this.Controls.Add((Control) this.FormMyClaims_Fill_Panel);
    this.Controls.Add((Control) this._FormMyClaims_Toolbars_Dock_Area_Left);
    this.Controls.Add((Control) this._FormMyClaims_Toolbars_Dock_Area_Right);
    this.Controls.Add((Control) this._FormMyClaims_Toolbars_Dock_Area_Bottom);
    this.Controls.Add((Control) this._FormMyClaims_Toolbars_Dock_Area_Top);
    this.Font = new Font("Tahoma", 8.25f);
    this.Name = nameof (FormMyClaims);
    this.Text = "My Claims";
    this.Load += new EventHandler(this.FormMyClaims_Load);
    this.FormMyClaims_Fill_Panel.ResumeLayout(false);
    ((ISupportInitialize) this.gridMyClaims).EndInit();
    ((ISupportInitialize) this.ultraToolbarsManager1).EndInit();
    this.ResumeLayout(false);
  }
}
