// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Forms.Entities.frmSearchEntity
// Assembly: MgaSystems.IMS.Forms, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FB3F392E-40B6-486F-8F0B-A4A494A546D4
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Forms.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.Tools;
using Microsoft.VisualBasic;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Forms.Entities;

public class frmSearchEntity : Form
{
  private IContainer components;
  private Label Label1;
  private Label Label2;
  private SqlCommand SqlSelectCommand1;
  private AccountingSearchEntity ds;
  private SqlDataAdapter daSearchEntity;
  private ToolTip ToolTip1;
  internal bool _LimitToPayables;
  private bool _CompanyLocationSearch;
  private frmSearchEntity.EntitySearchType _SearchType;
  private frmSearchEntity.LimiterValuesClass mLimiterValues;

  public frmSearchEntity()
  {
    this.Load += new EventHandler(this.frmfrmSearchEntity_Load);
    this.InitializeComponent();
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private virtual MGASimpleComboBox cmbEntityType
  {
    get => this._cmbEntityType;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      InitializeLayoutEventHandler layoutEventHandler = new InitializeLayoutEventHandler(this.ChargeTypeValueList_InitializeLayout);
      MGASimpleComboBox cmbEntityType1 = this._cmbEntityType;
      if (cmbEntityType1 != null)
        cmbEntityType1.InitializeLayout -= layoutEventHandler;
      this._cmbEntityType = value;
      MGASimpleComboBox cmbEntityType2 = this._cmbEntityType;
      if (cmbEntityType2 == null)
        return;
      cmbEntityType2.InitializeLayout += layoutEventHandler;
    }
  }

  private virtual MGATextBox txtEntityName
  {
    get => this._txtEntityName;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.txtEntityName_GotFocus);
      EventHandler eventHandler2 = new EventHandler(this.txtEntityName_LostFocus);
      KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.txtEntityName_KeyPress);
      MGATextBox txtEntityName1 = this._txtEntityName;
      if (txtEntityName1 != null)
      {
        ((Control) txtEntityName1).GotFocus -= eventHandler1;
        ((Control) txtEntityName1).LostFocus -= eventHandler2;
        ((Control) txtEntityName1).KeyPress -= pressEventHandler;
      }
      this._txtEntityName = value;
      MGATextBox txtEntityName2 = this._txtEntityName;
      if (txtEntityName2 == null)
        return;
      ((Control) txtEntityName2).GotFocus += eventHandler1;
      ((Control) txtEntityName2).LostFocus += eventHandler2;
      ((Control) txtEntityName2).KeyPress += pressEventHandler;
    }
  }

  private virtual MGAButton btnSearch
  {
    get => this._btnSearch;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnSearch_Click);
      MGAButton btnSearch1 = this._btnSearch;
      if (btnSearch1 != null)
        ((Control) btnSearch1).Click -= eventHandler;
      this._btnSearch = value;
      MGAButton btnSearch2 = this._btnSearch;
      if (btnSearch2 == null)
        return;
      ((Control) btnSearch2).Click += eventHandler;
    }
  }

  private virtual MGAButton btnOpen
  {
    get => this._btnOpen;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnOpen_Click);
      MGAButton btnOpen1 = this._btnOpen;
      if (btnOpen1 != null)
        ((Control) btnOpen1).Click -= eventHandler;
      this._btnOpen = value;
      MGAButton btnOpen2 = this._btnOpen;
      if (btnOpen2 == null)
        return;
      ((Control) btnOpen2).Click += eventHandler;
    }
  }

  private virtual UltraGrid gridEntityList
  {
    get => this._gridEntityList;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.gridEntityList_DoubleClick);
      UltraGrid gridEntityList1 = this._gridEntityList;
      if (gridEntityList1 != null)
        ((Control) gridEntityList1).DoubleClick -= eventHandler;
      this._gridEntityList = value;
      UltraGrid gridEntityList2 = this._gridEntityList;
      if (gridEntityList2 == null)
        return;
      ((Control) gridEntityList2).DoubleClick += eventHandler;
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    UltraGridBand ultraGridBand = new UltraGridBand("spFin_SearchEntity", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("Entity Name");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("EntityGUID");
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    ResourceManager resourceManager = new ResourceManager(typeof (frmSearchEntity));
    this.cmbEntityType = new MGASimpleComboBox();
    this.Label1 = new Label();
    this.txtEntityName = new MGATextBox();
    this.btnSearch = new MGAButton();
    this.btnOpen = new MGAButton();
    this.Label2 = new Label();
    this.ds = new AccountingSearchEntity();
    this.daSearchEntity = new SqlDataAdapter();
    this.SqlSelectCommand1 = new SqlCommand();
    this.ToolTip1 = new ToolTip(this.components);
    this.gridEntityList = new UltraGrid();
    ((ISupportInitialize) this.cmbEntityType).BeginInit();
    ((ISupportInitialize) this.txtEntityName).BeginInit();
    ((ISupportInitialize) this.btnSearch).BeginInit();
    ((ISupportInitialize) this.btnOpen).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.gridEntityList).BeginInit();
    this.SuspendLayout();
    this.cmbEntityType.CharacterCasing = CharacterCasing.Normal;
    ((UltraDropDownBase) this.cmbEntityType).DisplayMember = "";
    this.cmbEntityType.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cmbEntityType).Location = new Point(80 /*0x50*/, 8);
    ((Control) this.cmbEntityType).Name = "cmbEntityType";
    ((Control) this.cmbEntityType).Size = new Size(216, 20);
    ((Control) this.cmbEntityType).TabIndex = 0;
    ((UltraDropDownBase) this.cmbEntityType).ValueMember = "";
    this.Label1.AutoSize = true;
    this.Label1.Location = new Point(8, 10);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(65, 17);
    this.Label1.TabIndex = 3;
    this.Label1.Text = "Entity Type:";
    this.Label1.TextAlign = ContentAlignment.MiddleRight;
    appearance1.BorderColor = Color.Gray;
    ((TextEditorControlBase) this.txtEntityName).Appearance = (AppearanceBase) appearance1;
    ((Control) this.txtEntityName).Location = new Point(80 /*0x50*/, 32 /*0x20*/);
    ((Control) this.txtEntityName).Name = "txtEntityName";
    ((Control) this.txtEntityName).Size = new Size(216, 20);
    ((Control) this.txtEntityName).TabIndex = 1;
    appearance2.BackColor = Color.Gainsboro;
    appearance2.BackColor2 = Color.White;
    appearance2.BackGradientStyle = (GradientStyle) 2;
    appearance2.BorderColor = Color.Gray;
    appearance2.ImageHAlign = (HAlign) 2;
    appearance2.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnSearch).Appearance = (AppearanceBase) appearance2;
    ((ControlBase) this.btnSearch).ImageSize = new Size(24, 24);
    ((Control) this.btnSearch).Location = new Point(304, 16 /*0x10*/);
    ((Control) this.btnSearch).Name = "btnSearch";
    ((Control) this.btnSearch).TabIndex = 2;
    this.ToolTip1.SetToolTip((Control) this.btnSearch, "Click here search for the entity.");
    appearance3.BackColor = Color.Gainsboro;
    appearance3.BackColor2 = Color.White;
    appearance3.BackGradientStyle = (GradientStyle) 2;
    appearance3.BorderColor = Color.Gray;
    ((ControlBase) this.btnOpen).Appearance = (AppearanceBase) appearance3;
    ((Control) this.btnOpen).Location = new Point(304, 400);
    ((Control) this.btnOpen).Name = "btnOpen";
    ((Control) this.btnOpen).TabIndex = 5;
    this.ToolTip1.SetToolTip((Control) this.btnOpen, "Click here to open the selected entity.");
    this.Label2.AutoSize = true;
    this.Label2.Location = new Point(4, 34);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(69, 17);
    this.Label2.TabIndex = 7;
    this.Label2.Text = "Entity Name:";
    this.Label2.TextAlign = ContentAlignment.MiddleRight;
    this.ds.DataSetName = nameof (frmSearchEntity);
    this.ds.Locale = new CultureInfo("en-US");
    this.daSearchEntity.SelectCommand = this.SqlSelectCommand1;
    this.daSearchEntity.TableMappings.AddRange(new DataTableMapping[10]
    {
      new DataTableMapping("Table", "spFin_SearchEntity", new DataColumnMapping[2]
      {
        new DataColumnMapping("Entity Name", "Entity Name"),
        new DataColumnMapping("EntityGUID", "EntityGUID")
      }),
      new DataTableMapping("Table1", "Table1", new DataColumnMapping[2]
      {
        new DataColumnMapping("Entity Name", "Entity Name"),
        new DataColumnMapping("EntityGUID", "EntityGUID")
      }),
      new DataTableMapping("Table2", "Table2", new DataColumnMapping[2]
      {
        new DataColumnMapping("Entity Name", "Entity Name"),
        new DataColumnMapping("EntityGUID", "EntityGUID")
      }),
      new DataTableMapping("Table3", "Table3", new DataColumnMapping[2]
      {
        new DataColumnMapping("Entity Name", "Entity Name"),
        new DataColumnMapping("EntityGUID", "EntityGUID")
      }),
      new DataTableMapping("Table4", "Table4", new DataColumnMapping[2]
      {
        new DataColumnMapping("Entity Name", "Entity Name"),
        new DataColumnMapping("EntityGUID", "EntityGUID")
      }),
      new DataTableMapping("Table5", "Table5", new DataColumnMapping[2]
      {
        new DataColumnMapping("Entity Name", "Entity Name"),
        new DataColumnMapping("EntityGUID", "EntityGUID")
      }),
      new DataTableMapping("Table6", "Table6", new DataColumnMapping[2]
      {
        new DataColumnMapping("Entity Name", "Entity Name"),
        new DataColumnMapping("EntityGUID", "EntityGUID")
      }),
      new DataTableMapping("Table7", "Table7", new DataColumnMapping[2]
      {
        new DataColumnMapping("Entity Name", "Entity Name"),
        new DataColumnMapping("EntityGUID", "EntityGUID")
      }),
      new DataTableMapping("Table8", "Table8", new DataColumnMapping[2]
      {
        new DataColumnMapping("Entity Name", "Entity Name"),
        new DataColumnMapping("EntityGUID", "EntityGUID")
      }),
      new DataTableMapping("Table9", "Table9", new DataColumnMapping[2]
      {
        new DataColumnMapping("Entity Name", "Entity Name"),
        new DataColumnMapping("EntityGUID", "EntityGUID")
      })
    });
    this.SqlSelectCommand1.CommandText = "[spFin_SearchEntity]";
    this.SqlSelectCommand1.CommandType = CommandType.StoredProcedure;
    this.SqlSelectCommand1.Parameters.Add(new SqlParameter("@ENTITYTYPE", SqlDbType.VarChar, 2));
    this.SqlSelectCommand1.Parameters.Add(new SqlParameter("@ENTITYNAME", SqlDbType.VarChar, 100));
    ((UltraGridBase) this.gridEntityList).DataSource = (object) this.ds.spFin_SearchEntity;
    appearance4.BackColor = Color.White;
    appearance4.BorderColor = Color.Gray;
    ((UltraGridBase) this.gridEntityList).DisplayLayout.Appearance = (AppearanceBase) appearance4;
    ultraGridBand.ColHeadersVisible = false;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Width = 334;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Hidden = true;
    ultraGridBand.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2
    });
    ((UltraGridBase) this.gridEntityList).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.gridEntityList).DisplayLayout.Override.AllowAddNew = (AllowAddNew) 2;
    ((UltraGridBase) this.gridEntityList).DisplayLayout.Override.AllowColMoving = (AllowColMoving) 1;
    ((UltraGridBase) this.gridEntityList).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 1;
    ((UltraGridBase) this.gridEntityList).DisplayLayout.Override.AllowColSwapping = (AllowColSwapping) 1;
    ((UltraGridBase) this.gridEntityList).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridEntityList).DisplayLayout.Override.AllowGroupBy = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridEntityList).DisplayLayout.Override.AllowGroupMoving = (AllowGroupMoving) 1;
    ((UltraGridBase) this.gridEntityList).DisplayLayout.Override.AllowGroupSwapping = (AllowGroupSwapping) 1;
    ((UltraGridBase) this.gridEntityList).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridEntityList).DisplayLayout.Override.AllowRowLayoutCellSizing = (RowLayoutSizing) 1;
    ((UltraGridBase) this.gridEntityList).DisplayLayout.Override.AllowRowLayoutLabelSizing = (RowLayoutSizing) 1;
    ((UltraGridBase) this.gridEntityList).DisplayLayout.Override.AllowRowSummaries = (AllowRowSummaries) 2;
    ((UltraGridBase) this.gridEntityList).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridEntityList).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.gridEntityList).DisplayLayout.Override.BorderStyleHeader = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.gridEntityList).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    appearance5.TextHAlign = (HAlign) 1;
    ((UltraGridBase) this.gridEntityList).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance5;
    ((UltraGridBase) this.gridEntityList).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    appearance6.BackColor = SystemColors.Control;
    appearance6.TextHAlign = (HAlign) 1;
    ((UltraGridBase) this.gridEntityList).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance6;
    ((UltraGridBase) this.gridEntityList).DisplayLayout.Override.MaxSelectedRows = 1;
    ((UltraGridBase) this.gridEntityList).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((UltraControlBase) this.gridEntityList).UseFlatMode = (DefaultableBoolean) 1;
    ((Control) this.gridEntityList).Location = new Point(8, 64 /*0x40*/);
    ((Control) this.gridEntityList).Name = "gridEntityList";
    ((Control) this.gridEntityList).Size = new Size(336, 328);
    ((Control) this.gridEntityList).TabIndex = 3;
    this.AcceptButton = (IButtonControl) this.btnOpen;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.WhiteSmoke;
    this.ClientSize = new Size(352, 446);
    this.Controls.Add((Control) this.gridEntityList);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.txtEntityName);
    this.Controls.Add((Control) this.btnOpen);
    this.Controls.Add((Control) this.btnSearch);
    this.Controls.Add((Control) this.cmbEntityType);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.Icon = (Icon) resourceManager.GetObject("$this.Icon");
    this.KeyPreview = true;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmSearchEntity);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Entity Selection";
    ((ISupportInitialize) this.cmbEntityType).EndInit();
    ((ISupportInitialize) this.txtEntityName).EndInit();
    ((ISupportInitialize) this.btnSearch).EndInit();
    ((ISupportInitialize) this.btnOpen).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.gridEntityList).EndInit();
    this.ResumeLayout(false);
  }

  public Guid EntityGUID
  {
    get
    {
      Guid empty;
      foreach (UltraGridRow row in ((UltraGridBase) this.gridEntityList).Rows)
      {
        if (row.Selected)
        {
          empty = (Guid) row.Cells[1].Value;
          goto label_5;
        }
      }
      empty = Guid.Empty;
label_5:
      return empty;
    }
  }

  public string EntityName
  {
    get
    {
      string empty;
      foreach (UltraGridRow row in ((UltraGridBase) this.gridEntityList).Rows)
      {
        if (row.Selected)
        {
          empty = (string) row.Cells[0].Value;
          goto label_5;
        }
      }
      empty = string.Empty;
label_5:
      return empty;
    }
  }

  internal bool LimitToPayables
  {
    get => this._LimitToPayables;
    set => this._LimitToPayables = value;
  }

  public bool CompanyLocationSearch => this._CompanyLocationSearch;

  internal frmSearchEntity.EntitySearchType SearchType => this._SearchType;

  public frmSearchEntity.LimiterValuesClass LimiterValues
  {
    set => this.mLimiterValues = value;
  }

  private void frmfrmSearchEntity_Load(object sender, EventArgs e)
  {
    this.FillEntityTypeCombo();
    ((ControlBase) this.btnOpen).Appearance.Image = (object) ImageCache.Instance.Forward;
    ((ControlBase) this.btnSearch).Appearance.Image = (object) ImageCache.Instance.Search;
  }

  private void FillEntityTypeCombo()
  {
    DataTable dataTable = new DataTable();
    dataTable.Columns.Add(new DataColumn("DisplayMember", typeof (string)));
    frmSearchEntity.LimiterValuesClass mLimiterValues = this.mLimiterValues;
    if (mLimiterValues.ShowCompanyGroup)
      dataTable.Rows.Add((object) "Company Group");
    if (mLimiterValues.ShowCompany)
      dataTable.Rows.Add((object) "Company");
    if (mLimiterValues.ShowCompanyLocation)
      dataTable.Rows.Add((object) "Company Locations");
    if (mLimiterValues.ShowCompanyLines)
      dataTable.Rows.Add((object) "Company Lines");
    if (mLimiterValues.ShowInsured)
      dataTable.Rows.Add((object) "Insured");
    if (mLimiterValues.ShowIntermediary)
      dataTable.Rows.Add((object) "Intermediary");
    if (mLimiterValues.ShowProducer)
      dataTable.Rows.Add((object) "Producer");
    if (mLimiterValues.ShowUsers)
      dataTable.Rows.Add((object) "Users");
    if (mLimiterValues.ShowUserGroups)
      dataTable.Rows.Add((object) "User Groups");
    if (mLimiterValues.ShowExpensePayees)
      dataTable.Rows.Add((object) "Expense Payees");
    if (mLimiterValues.Show3rdParty)
      dataTable.Rows.Add((object) "3RD Party Payees");
    if (mLimiterValues.ShowFinanceCompanies)
      dataTable.Rows.Add((object) "Finance Company");
    if (dataTable.Rows.Count <= 0)
      return;
    MGASimpleComboBox cmbEntityType = this.cmbEntityType;
    ((UltraGridBase) cmbEntityType).DataSource = (object) dataTable;
    ((UltraDropDownBase) cmbEntityType).MaxDropDownItems = dataTable.Rows.Count;
    ((UltraDropDownBase) cmbEntityType).MinDropDownItems = dataTable.Rows.Count;
    ((UltraDropDownBase) cmbEntityType).DisplayMember = dataTable.Columns[0].ColumnName;
    ((UltraDropDownBase) cmbEntityType).ValueMember = dataTable.Columns[0].ColumnName;
  }

  private void ExecuteSearch(string _EntityType, string _EntityName)
  {
    Utility.SetDataAdapterConnections((DbDataAdapter) this.daSearchEntity, (DbConnection) DefaultDatabase.CreateConnection(), (DbTransaction) null);
    SqlCommand selectCommand = this.daSearchEntity.SelectCommand;
    selectCommand.Parameters["@ENTITYTYPE"].Value = (object) _EntityType;
    if (_EntityName.Trim().Length != 0)
      selectCommand.Parameters["@ENTITYNAME"].Value = (object) _EntityName;
    this.ds.Clear();
    this.daSearchEntity.SelectCommand.CommandText = !this.LimitToPayables ? "dbo.spFin_SearchEntity" : "dbo.spFin_SearchEntityPayables";
    DefaultDatabase.DataAdapterFill((DbDataAdapter) this.daSearchEntity, (DataSet) this.ds);
    if (this.ds.Tables[0].Rows.Count == 0)
    {
      int num = (int) MessageBox.Show("The specified entity could not be found, please try again!", "Entity Not Found!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else
    {
      ((Control) this.gridEntityList).Focus();
      ((UltraGridBase) this.gridEntityList).ActiveRow = ((UltraGridBase) this.gridEntityList).Rows[0];
      ((UltraGridBase) this.gridEntityList).Rows[0].Selected = true;
    }
  }

  private void btnSearch_Click(object sender, EventArgs e)
  {
    if (((UltraDropDownBase) this.cmbEntityType).SelectedRow == null)
    {
      int num1 = (int) MessageBox.Show("You must select an entity type to continue.", "No Entity Type Selected!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else
    {
      this.Cursor = Cursors.WaitCursor;
      string text = ((UltraDropDownBase) this.cmbEntityType).SelectedRow.Cells[0].Text;
      // ISSUE: reference to a compiler-generated method
      switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(text))
      {
        case 73338750:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text, "Finance Company", false) == 0)
          {
            this._SearchType = frmSearchEntity.EntitySearchType.Intermediary;
            this.ExecuteSearch("FI", ((TextEditorControlBase) this.txtEntityName).Text.Trim());
            this._CompanyLocationSearch = false;
            break;
          }
          goto default;
        case 112472755:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text, "Users", false) == 0)
          {
            this._SearchType = frmSearchEntity.EntitySearchType.Users;
            this.ExecuteSearch("U", ((TextEditorControlBase) this.txtEntityName).Text.Trim());
            this._CompanyLocationSearch = false;
            break;
          }
          goto default;
        case 1026596288:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text, "Expense Payees", false) == 0)
          {
            this._SearchType = frmSearchEntity.EntitySearchType.ExpensePayees;
            this.ExecuteSearch("X", ((TextEditorControlBase) this.txtEntityName).Text.Trim());
            this._CompanyLocationSearch = false;
            break;
          }
          goto default;
        case 1450128085:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text, "3RD Party Payees", false) == 0)
          {
            this._SearchType = frmSearchEntity.EntitySearchType.ThirdParty;
            this.ExecuteSearch("3", ((TextEditorControlBase) this.txtEntityName).Text.Trim());
            this._CompanyLocationSearch = false;
            break;
          }
          goto default;
        case 2109709871:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text, "Company Lines", false) == 0)
          {
            this._SearchType = frmSearchEntity.EntitySearchType.CompanyLines;
            this.ExecuteSearch("C", ((TextEditorControlBase) this.txtEntityName).Text.Trim());
            this._CompanyLocationSearch = false;
            break;
          }
          goto default;
        case 2248369378:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text, "Intermediary", false) == 0)
          {
            this._SearchType = frmSearchEntity.EntitySearchType.Intermediary;
            this.ExecuteSearch("IN", ((TextEditorControlBase) this.txtEntityName).Text.Trim());
            this._CompanyLocationSearch = false;
            break;
          }
          goto default;
        case 2311623725:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text, "Insured", false) == 0)
          {
            this._SearchType = frmSearchEntity.EntitySearchType.Insured;
            this.ExecuteSearch("I", ((TextEditorControlBase) this.txtEntityName).Text.Trim());
            this._CompanyLocationSearch = false;
            break;
          }
          goto default;
        case 2990800743:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text, "Company Group", false) == 0)
          {
            this._SearchType = frmSearchEntity.EntitySearchType.CompanyGroup;
            this.ExecuteSearch("CG", ((TextEditorControlBase) this.txtEntityName).Text.Trim());
            this._CompanyLocationSearch = false;
            break;
          }
          goto default;
        case 3250523996:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text, "Company", false) == 0)
          {
            this._SearchType = frmSearchEntity.EntitySearchType.Company;
            this.ExecuteSearch("CO", ((TextEditorControlBase) this.txtEntityName).Text.Trim());
            this._CompanyLocationSearch = false;
            break;
          }
          goto default;
        case 3364644014:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text, "User Groups", false) == 0)
          {
            this._SearchType = frmSearchEntity.EntitySearchType.UserGroups;
            this.ExecuteSearch("G", ((TextEditorControlBase) this.txtEntityName).Text.Trim());
            this._CompanyLocationSearch = false;
            break;
          }
          goto default;
        case 3428265799:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text, "Producer", false) == 0)
          {
            this._SearchType = frmSearchEntity.EntitySearchType.Producer;
            this.ExecuteSearch("P", ((TextEditorControlBase) this.txtEntityName).Text.Trim());
            this._CompanyLocationSearch = false;
            break;
          }
          goto default;
        case 3833503216:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text, "Company Locations", false) == 0)
          {
            this._SearchType = frmSearchEntity.EntitySearchType.CompanyLocations;
            this.ExecuteSearch("CL", ((TextEditorControlBase) this.txtEntityName).Text.Trim());
            this._CompanyLocationSearch = true;
            break;
          }
          goto default;
        default:
          this._CompanyLocationSearch = false;
          int num2 = (int) MessageBox.Show("You must select an entity type to continue.", "No Entity Type Selected!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          this.Cursor = Cursors.Default;
          return;
      }
      if (((UltraGridBase) this.gridEntityList).Rows.Count == 500 && CurrentUser.Instance.UsingXP)
        BalloonTip.ShowEditTip((Control) this.txtEntityName, "Limiting Results", "More than 500 results may have been returned. Only 500 rows are being shown at this time. Please be more specifiec to narrow your search.\n\nPlease specify a better search criteria to limit the results.", BalloonTip.BalloonTipIcons.Info);
      this.Cursor = Cursors.Default;
    }
  }

  private void btnOpen_Click(object sender, EventArgs e)
  {
    if (this.gridEntityList.Selected.Rows.Count == 0)
      Interaction.Beep();
    else
      this.DialogResult = DialogResult.OK;
  }

  private void gridEntityList_DoubleClick(object sender, EventArgs e)
  {
    if ((UltraGridRow) ((UIElement) ((UltraGridBase) this.gridEntityList).DisplayLayout.UIElement).ElementFromPoint(((Control) this.gridEntityList).PointToClient(Cursor.Position)).GetContext(typeof (UltraGridRow)) == null)
      Interaction.Beep();
    else
      this.DialogResult = DialogResult.OK;
  }

  private void ChargeTypeValueList_InitializeLayout(object sender, InitializeLayoutEventArgs e)
  {
    MGASimpleComboBox cmbEntityType = this.cmbEntityType;
    cmbEntityType.DisplayLayout.Override.HeaderAppearance.TextHAlign = (HAlign) 1;
    cmbEntityType.DisplayLayout.Override.CellAppearance.TextHAlign = (HAlign) 1;
    ((HeaderBase) cmbEntityType.DisplayLayout.Bands[0].Columns[0].Header).Caption = "Please select an entity type...";
  }

  private void txtEntityName_GotFocus(object sender, EventArgs e)
  {
    this.AcceptButton = (IButtonControl) null;
  }

  private void txtEntityName_LostFocus(object sender, EventArgs e)
  {
    this.AcceptButton = (IButtonControl) this.btnOpen;
  }

  private void txtEntityName_KeyPress(object sender, KeyPressEventArgs e)
  {
    if (e.KeyChar != '\r' || Control.ModifierKeys != Keys.None)
      return;
    e.Handled = true;
    this.btnSearch_Click((object) this.btnSearch, new EventArgs());
    if (((UltraGridBase) this.gridEntityList).Rows.Count <= 0)
      return;
    ((Control) this.gridEntityList).Focus();
  }

  public enum EntitySearchType
  {
    None,
    Company,
    CompanyLocations,
    CompanyLines,
    ExpensePayees,
    Insured,
    Intermediary,
    Producer,
    ProducerLocation,
    ThirdParty,
    Users,
    UserGroups,
    CompanyGroup,
  }

  public class LimiterValuesClass
  {
    private bool mShowCompanyGroup;
    private bool mShowCompany;
    private bool mShowCompanyLocations;
    private bool mShowCompanyLines;
    private bool mShowInsured;
    private bool mShowIntermediary;
    private bool mShowProducer;
    private bool mShowUsers;
    private bool mShowUserGroups;
    private bool mShowExpensePayees;
    private bool mShow3rdParty;
    private bool mShowFinanceCompanies;

    public bool ShowCompanyGroup => this.mShowCompanyGroup;

    public bool ShowCompany => this.mShowCompany;

    public bool ShowCompanyLocation => this.mShowCompanyLocations;

    public bool ShowCompanyLines => this.mShowCompanyLines;

    public bool ShowInsured => this.mShowInsured;

    public bool ShowIntermediary => this.mShowIntermediary;

    public bool ShowProducer => this.mShowProducer;

    public bool ShowUsers => this.mShowUsers;

    public bool ShowUserGroups => this.mShowUserGroups;

    public bool ShowExpensePayees => this.mShowExpensePayees;

    public bool Show3rdParty => this.mShow3rdParty;

    public bool ShowFinanceCompanies => this.mShowFinanceCompanies;

    public LimiterValuesClass(
      bool ShowCompanyGroup = false,
      bool ShowCompany = false,
      bool ShowCompanyLocations = false,
      bool ShowCompanyLines = false,
      bool ShowInsured = false,
      bool ShowIntermediary = false,
      bool ShowProducer = false,
      bool ShowUsers = false,
      bool ShowUserGroups = false,
      bool ShowExpensePayees = false,
      bool Show3rdParty = false,
      bool ShowFinanceCompanies = false)
    {
      this.mShowCompanyGroup = ShowCompanyGroup;
      this.mShowCompany = ShowCompany;
      this.mShowCompanyLocations = ShowCompanyLocations;
      this.mShowCompanyLines = ShowCompanyLines;
      this.mShowInsured = ShowInsured;
      this.mShowIntermediary = ShowIntermediary;
      this.mShowProducer = ShowProducer;
      this.mShowUsers = ShowUsers;
      this.mShowUserGroups = ShowUserGroups;
      this.mShowExpensePayees = ShowExpensePayees;
      this.mShow3rdParty = Show3rdParty;
      this.mShowFinanceCompanies = ShowFinanceCompanies;
    }
  }
}
