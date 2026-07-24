// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.Forms.formWSDefaultBankSettings
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using Infragistics.Win.UltraWinToolbars;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Accounting.Services.Properties;
using MGASystems.IMS.Accounting.Shared;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.Forms;

public class formWSDefaultBankSettings : FormBase
{
  private IContainer components;
  protected MGASimpleComboBox mgaSimpleComboBox1;
  protected Label lblOfficeLocation;
  protected Label lblBankAccount;
  protected MGAButton btnCancel;
  protected MGAButton buttonSave;
  protected UltraGrid gridWSBankSettings;
  protected Label label1;
  protected MGASimpleComboBox comboOfficeActiveUsers;
  protected MGASimpleComboBox comboOfficeLocation;
  protected MGASimpleComboBox comboBankAccount;
  protected UltraToolbarsManager ultraToolbarsManager1;
  protected UltraToolbarsDockArea _formWSDefaultBankSettings_Toolbars_Dock_Area_Left;
  protected UltraToolbarsDockArea _formWSDefaultBankSettings_Toolbars_Dock_Area_Right;
  protected UltraToolbarsDockArea _formWSDefaultBankSettings_Toolbars_Dock_Area_Bottom;
  protected UltraToolbarsDockArea _formWSDefaultBankSettings_Toolbars_Dock_Area_Top;
  protected Label lblLineOfBusinessName;
  protected MGASimpleComboBox comboLineOfBusinessName;
  protected Label lblCompanyLocationName;
  protected MGASimpleComboBox comboCompanyLocation;

  protected int WspaymentBankAcctId { get; set; }

  protected bool UpdateEntry { get; set; }

  public formWSDefaultBankSettings() => this.InitializeComponent();

  protected virtual void FormWSDefaultBankSettings_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    this.LoadLOB();
    this.LoadOfficeLocations();
    this.LoadCompanyLocations();
    this.LoadDefaultBankSettings();
  }

  public void LoadOfficeLocationBankAccounts(int glCompanyID)
  {
    ((UltraGridBase) this.comboBankAccount).DataSource = (object) DefaultDatabase.ExecuteDataTable("dbo.spFin_GetBankAccounts", new object[2]
    {
      (object) "@glcompanyid",
      (object) glCompanyID
    });
    ((UltraDropDownBase) this.comboBankAccount).ValueMember = "glacctid";
    ((UltraDropDownBase) this.comboBankAccount).DisplayMember = "BankName";
  }

  public void LoadOfficeLocations()
  {
    ((UltraGridBase) this.comboOfficeLocation).DataSource = (object) Methods.GetOfficeLocationDataset();
    ((UltraDropDownBase) this.comboOfficeLocation).ValueMember = "ID";
    ((UltraDropDownBase) this.comboOfficeLocation).DisplayMember = "Office Location";
    if (((DisposableObjectCollectionBase) ((UltraGridBase) this.comboOfficeLocation).Rows).Count != 1)
      return;
    this.comboOfficeLocation.Value = ((UltraGridBase) this.comboOfficeLocation).Rows[0].Cells["ID"].Value;
  }

  protected virtual void SetBankSettingsDataSource()
  {
    ((UltraGridBase) this.gridWSBankSettings).DataSource = (object) DefaultDatabase.ExecuteDataTable("dbo.spFin_GetPaymentBankAccounts");
  }

  public void LoadDefaultBankSettings()
  {
    this.SetBankSettingsDataSource();
    this.FormatGrid();
    if (((DisposableObjectCollectionBase) ((UltraGridBase) this.gridWSBankSettings).Rows).Count == 0)
      return;
    ((GridItemBase) ((UltraGridBase) this.gridWSBankSettings).Rows[0]).Selected = true;
  }

  protected virtual void LoadGLOfficeUsers(int glCompanyID)
  {
    ((UltraGridBase) this.comboOfficeActiveUsers).DataSource = (object) DefaultDatabase.ExecuteDataTable("dbo.spFin_GetGlOfficeUsers", new object[2]
    {
      (object) "@glcompanyid",
      (object) glCompanyID
    });
    ((UltraDropDownBase) this.comboOfficeActiveUsers).ValueMember = "userGuid";
    ((UltraDropDownBase) this.comboOfficeActiveUsers).DisplayMember = "UserName";
    if (((DisposableObjectCollectionBase) ((UltraGridBase) this.comboOfficeActiveUsers).Rows).Count != 1)
      return;
    this.comboOfficeActiveUsers.Value = ((UltraGridBase) this.comboOfficeActiveUsers).Rows[0].Cells["userGuid"].Value;
  }

  protected virtual bool VerifyForm()
  {
    if (((UltraDropDownBase) this.comboBankAccount).SelectedRow == null)
    {
      int num = (int) MessageBox.Show("You must specify a bank account to continue.", "Required Field Missing", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (((UltraDropDownBase) this.comboOfficeLocation).SelectedRow == null)
    {
      int num = (int) MessageBox.Show("You must specify an office location to continue.", "Required Field Missing", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (((UltraDropDownBase) this.comboOfficeActiveUsers).SelectedRow == null)
    {
      int num = (int) MessageBox.Show("You must specify a user to continue.", "Required Field Missing", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (this.comboLineOfBusinessName.SelectedIndex == 0 || this.comboCompanyLocation.SelectedIndex != 0)
      return true;
    int num1 = (int) MessageBox.Show("You must specify a company location when a line of business is specified.", "Required Field Missing", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    return false;
  }

  protected virtual void HideColumns()
  {
    ColumnsCollection columns = ((UltraGridBase) this.gridWSBankSettings).DisplayLayout.Bands[0].Columns;
    columns["UserGuid"].Hidden = true;
    columns["GlCompanyId"].Hidden = true;
    columns["BankGLAcctId"].Hidden = true;
    columns["CompanyLocationGuid"].Hidden = true;
    columns["LineofBusinessGUID"].Hidden = true;
    columns["WSPaymentBankAcctId"].Hidden = true;
  }

  private void FormatColumns()
  {
    foreach (UltraGridColumn column in ((UltraGridBase) this.gridWSBankSettings).DisplayLayout.Bands[0].Columns)
    {
      ((HeaderBase) column.Header).Appearance.TextHAlign = (HAlign) 1;
      column.CellActivation = (Activation) 3;
    }
  }

  private void FormatGrid()
  {
    this.HideColumns();
    this.FormatColumns();
  }

  protected virtual void ClearSelected()
  {
    ((UltraDropDownBase) this.comboOfficeActiveUsers).SelectedRow = (UltraGridRow) null;
    ((UltraDropDownBase) this.comboOfficeLocation).SelectedRow = (UltraGridRow) null;
    ((UltraDropDownBase) this.comboBankAccount).SelectedRow = (UltraGridRow) null;
    this.comboCompanyLocation.SelectedIndex = 0;
    this.comboLineOfBusinessName.SelectedIndex = 0;
  }

  protected virtual void comboOfficeLocation_RowSelected(object sender, RowSelectedEventArgs e)
  {
    int result;
    if (((UltraDropDownBase) this.comboOfficeLocation).SelectedRow == null || !int.TryParse(((UltraDropDownBase) this.comboOfficeLocation).SelectedRow.Cells["ID"].Value.ToString(), out result))
      return;
    this.LoadGLOfficeUsers(result);
    this.LoadOfficeLocationBankAccounts(result);
  }

  private void comboBankAccount_RowSelected(object sender, RowSelectedEventArgs e)
  {
  }

  private void comboOfficeActiveUsers_RowSelected(object sender, RowSelectedEventArgs e)
  {
  }

  private void btnCancel_Click(object sender, EventArgs e)
  {
    this.DialogResult = DialogResult.Cancel;
    this.Close();
  }

  protected virtual void Save()
  {
    if (this.UpdateEntry)
      DefaultDatabase.ExecuteNonQuery("dbo.spFin_UpdatePaymentBankAccount", new object[12]
      {
        (object) "@WSPaymentBankAcctId",
        (object) this.WspaymentBankAcctId,
        (object) "@glCompanyID",
        this.comboOfficeLocation.Value,
        (object) "@BankAcctID",
        this.comboBankAccount.Value,
        (object) "@userGuid",
        this.comboOfficeActiveUsers.Value,
        (object) "@CompanyLocationGuid",
        this.comboCompanyLocation.Value,
        (object) "@LineofBusinessGUID",
        this.comboLineOfBusinessName.Value
      });
    else
      DefaultDatabase.ExecuteNonQuery("dbo.spFin_AddPaymentBankAccounts", new object[10]
      {
        (object) "@glCompanyID",
        this.comboOfficeLocation.Value,
        (object) "@BankAcctID",
        this.comboBankAccount.Value,
        (object) "@userGuid",
        this.comboOfficeActiveUsers.Value,
        (object) "@CompanyLocationGuid",
        this.comboCompanyLocation.Value,
        (object) "@LineofBusinessGUID",
        this.comboLineOfBusinessName.Value
      });
  }

  private void buttonSave_Click(object sender, EventArgs e)
  {
    if (!this.VerifyForm())
      return;
    this.Save();
    this.UpdateEntry = false;
    ((UltraGridBase) this.gridWSBankSettings).DataSource = (object) string.Empty;
    this.ClearSelected();
    this.LoadDefaultBankSettings();
  }

  private void ultraToolbarsManager1_ToolClick(object sender, ToolClickEventArgs e)
  {
    if (((UltraGridBase) this.gridWSBankSettings).ActiveRow != null && ((SparseCollectionBase) this.gridWSBankSettings.Selected.Rows).Count == 0)
      ((GridItemBase) ((UltraGridBase) this.gridWSBankSettings).ActiveRow).Selected = true;
    switch (((KeyedSubObjectBase) ((ToolEventArgs) e).Tool).Key)
    {
      case "Edit":
        if (((SparseCollectionBase) this.gridWSBankSettings.Selected.Rows).Count == 0)
          break;
        this.SetEditableData();
        this.UpdateEntry = true;
        break;
      case "Delete":
        int result;
        if (((UltraGridBase) this.gridWSBankSettings).ActiveRow == null || !int.TryParse(((UltraGridBase) this.gridWSBankSettings).ActiveRow.Cells["WSPaymentBankAcctId"].Value.ToString(), out result))
          break;
        this.DeletePaymentBankAccount(result);
        this.LoadOfficeLocations();
        this.LoadDefaultBankSettings();
        break;
    }
  }

  protected virtual void DeletePaymentBankAccount(int bankAcctId)
  {
    DefaultDatabase.ExecuteNonQuery("dbo.spFin_DeletePaymentBankAccount", new object[2]
    {
      (object) "@WSPaymentBankAcctId",
      (object) bankAcctId
    });
  }

  protected virtual void SetEditableData()
  {
    int result1;
    if (!int.TryParse(((UltraGridBase) this.gridWSBankSettings).ActiveRow.Cells["WSPaymentBankAcctId"].Value.ToString(), out result1))
      return;
    this.WspaymentBankAcctId = result1;
    UltraGridRow row = this.gridWSBankSettings.Selected.Rows[0];
    Guid result2;
    if (row.Cells["UserGuid"].Value == null || !Guid.TryParse(row.Cells["UserGuid"].Value.ToString(), out result2) || result2 == Guid.Empty)
      this.comboOfficeActiveUsers.Value = (object) null;
    else
      this.comboOfficeActiveUsers.Value = (object) result2;
    int result3;
    if (row.Cells["GlCompanyID"].Value == null || !int.TryParse(row.Cells["GlCompanyId"].Value.ToString(), out result3))
      this.comboOfficeLocation.Value = (object) null;
    else
      this.comboOfficeLocation.Value = (object) result3;
    int result4;
    if (row.Cells["BankGLAcctId"].Value == null || !int.TryParse(row.Cells["BankGLAcctId"].Value.ToString(), out result4))
      this.comboBankAccount.Value = (object) null;
    else
      this.comboBankAccount.Value = (object) result4;
    Guid result5;
    if (row.Cells["LineOfBusinessGuid"].Value.ToString() == string.Empty || !Guid.TryParse(row.Cells["LineOfBusinessGuid"].Value.ToString(), out result5) || result5 == Guid.Empty)
      this.comboLineOfBusinessName.SelectedIndex = 0;
    else
      this.comboLineOfBusinessName.Value = (object) result5;
    Guid result6;
    if (row.Cells["CompanyLocationGuid"].Value.ToString() == string.Empty || !Guid.TryParse(row.Cells["CompanyLocationGuid"].Value.ToString(), out result6) || result6 == Guid.Empty)
      this.comboCompanyLocation.SelectedIndex = 0;
    else
      this.comboCompanyLocation.Value = (object) result6;
  }

  public void LoadCompanyLocations()
  {
    ((UltraGridBase) this.comboCompanyLocation).DataSource = (object) DefaultDatabase.ExecuteDataTable("dbo.spfin_GetCompanyLocations");
    ((UltraDropDownBase) this.comboCompanyLocation).ValueMember = "CompanyLocationGuid";
    ((UltraDropDownBase) this.comboCompanyLocation).DisplayMember = "LocationName";
    this.comboCompanyLocation.SelectedIndex = 0;
  }

  public void LoadLOB()
  {
    ((UltraGridBase) this.comboLineOfBusinessName).DataSource = (object) DefaultDatabase.ExecuteDataTable("dbo.spFin_GetLOBS");
    ((UltraDropDownBase) this.comboLineOfBusinessName).ValueMember = "LineGuid";
    ((UltraDropDownBase) this.comboLineOfBusinessName).DisplayMember = "LineName";
    this.comboLineOfBusinessName.SelectedIndex = 0;
  }

  private void comboCompanyLocation_RowSelected(object sender, RowSelectedEventArgs e)
  {
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
    UltraGridBand ultraGridBand = new UltraGridBand("", -1);
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    UltraToolbar ultraToolbar = new UltraToolbar("UltraToolbar1");
    PopupMenuTool popupMenuTool = new PopupMenuTool("gridContext");
    ButtonTool buttonTool1 = new ButtonTool("Edit");
    ButtonTool buttonTool2 = new ButtonTool("Delete");
    ButtonTool buttonTool3 = new ButtonTool("Edit");
    Appearance appearance12 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (formWSDefaultBankSettings));
    ButtonTool buttonTool4 = new ButtonTool("Delete");
    Appearance appearance13 = new Appearance();
    this.mgaSimpleComboBox1 = new MGASimpleComboBox();
    this.comboOfficeLocation = new MGASimpleComboBox();
    this.comboBankAccount = new MGASimpleComboBox();
    this.lblOfficeLocation = new Label();
    this.lblBankAccount = new Label();
    this.btnCancel = new MGAButton();
    this.buttonSave = new MGAButton();
    this.gridWSBankSettings = new UltraGrid();
    this.label1 = new Label();
    this.comboOfficeActiveUsers = new MGASimpleComboBox();
    this._formWSDefaultBankSettings_Toolbars_Dock_Area_Left = new UltraToolbarsDockArea();
    this.ultraToolbarsManager1 = new UltraToolbarsManager(this.components);
    this._formWSDefaultBankSettings_Toolbars_Dock_Area_Right = new UltraToolbarsDockArea();
    this._formWSDefaultBankSettings_Toolbars_Dock_Area_Top = new UltraToolbarsDockArea();
    this._formWSDefaultBankSettings_Toolbars_Dock_Area_Bottom = new UltraToolbarsDockArea();
    this.lblCompanyLocationName = new Label();
    this.comboCompanyLocation = new MGASimpleComboBox();
    this.lblLineOfBusinessName = new Label();
    this.comboLineOfBusinessName = new MGASimpleComboBox();
    ((ISupportInitialize) this.mgaSimpleComboBox1).BeginInit();
    ((ISupportInitialize) this.comboOfficeLocation).BeginInit();
    ((ISupportInitialize) this.comboBankAccount).BeginInit();
    ((ISupportInitialize) this.btnCancel).BeginInit();
    ((ISupportInitialize) this.buttonSave).BeginInit();
    ((ISupportInitialize) this.gridWSBankSettings).BeginInit();
    ((ISupportInitialize) this.comboOfficeActiveUsers).BeginInit();
    ((ISupportInitialize) this.ultraToolbarsManager1).BeginInit();
    ((ISupportInitialize) this.comboCompanyLocation).BeginInit();
    ((ISupportInitialize) this.comboLineOfBusinessName).BeginInit();
    this.SuspendLayout();
    this.mgaSimpleComboBox1.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.mgaSimpleComboBox1).Location = new Point(0, 0);
    ((Control) this.mgaSimpleComboBox1).Name = "mgaSimpleComboBox1";
    ((Control) this.mgaSimpleComboBox1).Size = new Size(100, 20);
    ((Control) this.mgaSimpleComboBox1).TabIndex = 0;
    ((UltraControlBase) this.mgaSimpleComboBox1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.mgaSimpleComboBox1).UseOsThemes = (DefaultableBoolean) 2;
    this.comboOfficeLocation.BorderStyle = (UIElementBorderStyle) 4;
    this.comboOfficeLocation.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboOfficeLocation).Font = new Font("Tahoma", 8.25f);
    ((Control) this.comboOfficeLocation).Location = new Point(5, 26);
    this.comboOfficeLocation.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboOfficeLocation).Name = "comboOfficeLocation";
    ((Control) this.comboOfficeLocation).Size = new Size(262, 21);
    ((Control) this.comboOfficeLocation).TabIndex = 2;
    ((UltraControlBase) this.comboOfficeLocation).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboOfficeLocation).UseOsThemes = (DefaultableBoolean) 2;
    this.comboOfficeLocation.RowSelected += new RowSelectedEventHandler(this.comboOfficeLocation_RowSelected);
    this.comboBankAccount.BorderStyle = (UIElementBorderStyle) 4;
    this.comboBankAccount.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboBankAccount).Font = new Font("Tahoma", 8.25f);
    ((Control) this.comboBankAccount).Location = new Point(5, 109);
    this.comboBankAccount.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboBankAccount).Name = "comboBankAccount";
    ((Control) this.comboBankAccount).Size = new Size(262, 21);
    ((Control) this.comboBankAccount).TabIndex = 4;
    ((UltraControlBase) this.comboBankAccount).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboBankAccount).UseOsThemes = (DefaultableBoolean) 2;
    this.comboBankAccount.RowSelected += new RowSelectedEventHandler(this.comboBankAccount_RowSelected);
    this.lblOfficeLocation.AutoSize = true;
    this.lblOfficeLocation.BackColor = Color.Transparent;
    this.lblOfficeLocation.Font = new Font("Tahoma", 8.25f);
    this.lblOfficeLocation.ForeColor = Color.Black;
    this.lblOfficeLocation.Location = new Point(5, 10);
    this.lblOfficeLocation.Name = "lblOfficeLocation";
    this.lblOfficeLocation.Size = new Size(83, 13);
    this.lblOfficeLocation.TabIndex = 1;
    this.lblOfficeLocation.Text = "Office Location:";
    this.lblBankAccount.AutoSize = true;
    this.lblBankAccount.BackColor = Color.Transparent;
    this.lblBankAccount.Font = new Font("Tahoma", 8.25f);
    this.lblBankAccount.ForeColor = Color.Black;
    this.lblBankAccount.Location = new Point(5, 93);
    this.lblBankAccount.Name = "lblBankAccount";
    this.lblBankAccount.Size = new Size(76, 13);
    this.lblBankAccount.TabIndex = 3;
    this.lblBankAccount.Text = "Bank Account:";
    ((AppearanceBase) appearance1).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance1).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance1).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance1).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance1).Image = (object) Resources.delete;
    ((AppearanceBase) appearance1).ImageHAlign = (HAlign) 1;
    ((AppearanceBase) appearance1).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnCancel).Appearance = (AppearanceBase) appearance1;
    ((Control) this.btnCancel).Font = new Font("Tahoma", 8.25f);
    ((Control) this.btnCancel).Location = new Point(181, 271);
    ((Control) this.btnCancel).Name = "btnCancel";
    ((Control) this.btnCancel).Size = new Size(86, 29);
    ((Control) this.btnCancel).TabIndex = 3;
    ((Control) this.btnCancel).Text = "Cancel";
    ((UltraControlBase) this.btnCancel).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.btnCancel).Click += new EventHandler(this.btnCancel_Click);
    ((AppearanceBase) appearance2).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance2).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance2).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance2).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance2).Image = (object) Resources.disk;
    ((AppearanceBase) appearance2).ImageHAlign = (HAlign) 1;
    ((AppearanceBase) appearance2).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonSave).Appearance = (AppearanceBase) appearance2;
    ((Control) this.buttonSave).Font = new Font("Tahoma", 8.25f);
    ((Control) this.buttonSave).Location = new Point(89, 271);
    ((Control) this.buttonSave).Name = "buttonSave";
    ((Control) this.buttonSave).Size = new Size(86, 29);
    ((Control) this.buttonSave).TabIndex = 2;
    ((Control) this.buttonSave).Text = "&Save";
    ((UltraControlBase) this.buttonSave).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonSave).Click += new EventHandler(this.buttonSave_Click);
    this.ultraToolbarsManager1.SetContextMenuUltra((Component) this.gridWSBankSettings, "gridContext");
    ((AppearanceBase) appearance3).BackColor = Color.White;
    ((AppearanceBase) appearance3).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridWSBankSettings).DisplayLayout.Appearance = (AppearanceBase) appearance3;
    ((UltraGridBase) this.gridWSBankSettings).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    ultraGridBand.Override.AllowUpdate = (DefaultableBoolean) 1;
    ((UltraGridBase) this.gridWSBankSettings).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.gridWSBankSettings).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance4).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance4).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance4).ForeColor = Color.Black;
    ((UltraGridBase) this.gridWSBankSettings).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance4;
    ((UltraGridBase) this.gridWSBankSettings).DisplayLayout.Override.AllowAddNew = (AllowAddNew) 2;
    ((UltraGridBase) this.gridWSBankSettings).DisplayLayout.Override.AllowColMoving = (AllowColMoving) 3;
    ((UltraGridBase) this.gridWSBankSettings).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridWSBankSettings).DisplayLayout.Override.AllowColSwapping = (AllowColSwapping) 3;
    ((UltraGridBase) this.gridWSBankSettings).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridWSBankSettings).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance5).BorderColor = Color.LightGray;
    ((AppearanceBase) appearance5).TextHAlignAsString = "Left";
    ((UltraGridBase) this.gridWSBankSettings).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance5;
    ((AppearanceBase) appearance6).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((AppearanceBase) appearance6).TextHAlignAsString = "Left";
    ((UltraGridBase) this.gridWSBankSettings).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance6;
    ((UltraGridBase) this.gridWSBankSettings).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    ((UltraGridBase) this.gridWSBankSettings).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance7).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridWSBankSettings).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance7;
    ((AppearanceBase) appearance8).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridWSBankSettings).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance8;
    ((UltraGridBase) this.gridWSBankSettings).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance9).BackColor = Color.Transparent;
    ((AppearanceBase) appearance9).ForeColor = Color.Black;
    ((UltraGridBase) this.gridWSBankSettings).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance9;
    ((AppearanceBase) appearance10).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance10).BorderColor = Color.Silver;
    scrollBarLook.ButtonAppearance = (AppearanceBase) appearance10;
    ((AppearanceBase) appearance11).BackColor = Color.White;
    scrollBarLook.TrackAppearance = (AppearanceBase) appearance11;
    ((UltraGridBase) this.gridWSBankSettings).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.gridWSBankSettings).Font = new Font("Tahoma", 8f);
    ((Control) this.gridWSBankSettings).Location = new Point(291, 10);
    ((Control) this.gridWSBankSettings).MaximumSize = new Size(937, 290);
    ((Control) this.gridWSBankSettings).MinimumSize = new Size(937, 290);
    ((Control) this.gridWSBankSettings).Name = "gridWSBankSettings";
    ((Control) this.gridWSBankSettings).Size = new Size(937, 290);
    ((Control) this.gridWSBankSettings).TabIndex = 0;
    this.gridWSBankSettings.UpdateMode = (UpdateMode) 2;
    ((UltraControlBase) this.gridWSBankSettings).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridWSBankSettings).UseOsThemes = (DefaultableBoolean) 2;
    this.label1.AutoSize = true;
    this.label1.BackColor = Color.Transparent;
    this.label1.Font = new Font("Tahoma", 8.25f);
    this.label1.ForeColor = Color.Black;
    this.label1.Location = new Point(5, 50);
    this.label1.Name = "label1";
    this.label1.Size = new Size(33, 13);
    this.label1.TabIndex = 5;
    this.label1.Text = "User:";
    this.comboOfficeActiveUsers.BorderStyle = (UIElementBorderStyle) 4;
    this.comboOfficeActiveUsers.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboOfficeActiveUsers).Font = new Font("Tahoma", 8.25f);
    ((Control) this.comboOfficeActiveUsers).Location = new Point(5, 66);
    this.comboOfficeActiveUsers.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboOfficeActiveUsers).Name = "comboOfficeActiveUsers";
    ((Control) this.comboOfficeActiveUsers).Size = new Size(262, 21);
    ((Control) this.comboOfficeActiveUsers).TabIndex = 6;
    ((UltraControlBase) this.comboOfficeActiveUsers).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboOfficeActiveUsers).UseOsThemes = (DefaultableBoolean) 2;
    this.comboOfficeActiveUsers.RowSelected += new RowSelectedEventHandler(this.comboOfficeActiveUsers_RowSelected);
    ((Control) this._formWSDefaultBankSettings_Toolbars_Dock_Area_Left).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._formWSDefaultBankSettings_Toolbars_Dock_Area_Left).BackColor = SystemColors.Control;
    this._formWSDefaultBankSettings_Toolbars_Dock_Area_Left.DockedPosition = (DockedPosition) 2;
    ((Control) this._formWSDefaultBankSettings_Toolbars_Dock_Area_Left).ForeColor = SystemColors.ControlText;
    ((Control) this._formWSDefaultBankSettings_Toolbars_Dock_Area_Left).Location = new Point(0, 0);
    ((Control) this._formWSDefaultBankSettings_Toolbars_Dock_Area_Left).Name = "_formWSDefaultBankSettings_Toolbars_Dock_Area_Left";
    ((Control) this._formWSDefaultBankSettings_Toolbars_Dock_Area_Left).Size = new Size(0, 311);
    this._formWSDefaultBankSettings_Toolbars_Dock_Area_Left.ToolbarsManager = this.ultraToolbarsManager1;
    this.ultraToolbarsManager1.DesignerFlags = 1;
    this.ultraToolbarsManager1.DockWithinContainer = (Control) this;
    this.ultraToolbarsManager1.DockWithinContainerBaseType = typeof (FormBase);
    this.ultraToolbarsManager1.ShowFullMenusDelay = 500;
    ultraToolbar.DockedColumn = 0;
    ultraToolbar.DockedRow = 0;
    ultraToolbar.Text = "UltraToolbar1";
    ultraToolbar.Visible = false;
    this.ultraToolbarsManager1.Toolbars.AddRange(new UltraToolbar[1]
    {
      ultraToolbar
    });
    ((ToolPropsBase) ((ToolBase) popupMenuTool).SharedPropsInternal).Caption = "gridContext";
    ((ToolBase) buttonTool2).InstanceProps.IsFirstInGroup = true;
    ((ToolsCollectionBase) popupMenuTool.Tools).AddRange(new ToolBase[2]
    {
      (ToolBase) buttonTool1,
      (ToolBase) buttonTool2
    });
    ((AppearanceBase) appearance12).Image = componentResourceManager.GetObject("appearance3.Image");
    ((ToolPropsBase) ((ToolBase) buttonTool3).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance12;
    ((ToolPropsBase) ((ToolBase) buttonTool3).SharedPropsInternal).Caption = "Edit";
    ((AppearanceBase) appearance13).Image = (object) Resources.delete;
    ((ToolPropsBase) ((ToolBase) buttonTool4).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance13;
    ((ToolPropsBase) ((ToolBase) buttonTool4).SharedPropsInternal).Caption = "Delete";
    ((ToolsCollectionBase) this.ultraToolbarsManager1.Tools).AddRange(new ToolBase[3]
    {
      (ToolBase) popupMenuTool,
      (ToolBase) buttonTool3,
      (ToolBase) buttonTool4
    });
    this.ultraToolbarsManager1.ToolClick += new ToolClickEventHandler(this.ultraToolbarsManager1_ToolClick);
    ((Control) this._formWSDefaultBankSettings_Toolbars_Dock_Area_Right).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._formWSDefaultBankSettings_Toolbars_Dock_Area_Right).BackColor = SystemColors.Control;
    this._formWSDefaultBankSettings_Toolbars_Dock_Area_Right.DockedPosition = (DockedPosition) 3;
    ((Control) this._formWSDefaultBankSettings_Toolbars_Dock_Area_Right).ForeColor = SystemColors.ControlText;
    ((Control) this._formWSDefaultBankSettings_Toolbars_Dock_Area_Right).Location = new Point(1240, 0);
    ((Control) this._formWSDefaultBankSettings_Toolbars_Dock_Area_Right).Name = "_formWSDefaultBankSettings_Toolbars_Dock_Area_Right";
    ((Control) this._formWSDefaultBankSettings_Toolbars_Dock_Area_Right).Size = new Size(0, 311);
    this._formWSDefaultBankSettings_Toolbars_Dock_Area_Right.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._formWSDefaultBankSettings_Toolbars_Dock_Area_Top).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._formWSDefaultBankSettings_Toolbars_Dock_Area_Top).BackColor = SystemColors.Control;
    this._formWSDefaultBankSettings_Toolbars_Dock_Area_Top.DockedPosition = (DockedPosition) 0;
    ((Control) this._formWSDefaultBankSettings_Toolbars_Dock_Area_Top).ForeColor = SystemColors.ControlText;
    ((Control) this._formWSDefaultBankSettings_Toolbars_Dock_Area_Top).Location = new Point(0, 0);
    ((Control) this._formWSDefaultBankSettings_Toolbars_Dock_Area_Top).Name = "_formWSDefaultBankSettings_Toolbars_Dock_Area_Top";
    ((Control) this._formWSDefaultBankSettings_Toolbars_Dock_Area_Top).Size = new Size(1240, 0);
    this._formWSDefaultBankSettings_Toolbars_Dock_Area_Top.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._formWSDefaultBankSettings_Toolbars_Dock_Area_Bottom).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._formWSDefaultBankSettings_Toolbars_Dock_Area_Bottom).BackColor = SystemColors.Control;
    this._formWSDefaultBankSettings_Toolbars_Dock_Area_Bottom.DockedPosition = (DockedPosition) 1;
    ((Control) this._formWSDefaultBankSettings_Toolbars_Dock_Area_Bottom).ForeColor = SystemColors.ControlText;
    ((Control) this._formWSDefaultBankSettings_Toolbars_Dock_Area_Bottom).Location = new Point(0, 311);
    ((Control) this._formWSDefaultBankSettings_Toolbars_Dock_Area_Bottom).Name = "_formWSDefaultBankSettings_Toolbars_Dock_Area_Bottom";
    ((Control) this._formWSDefaultBankSettings_Toolbars_Dock_Area_Bottom).Size = new Size(1240, 0);
    this._formWSDefaultBankSettings_Toolbars_Dock_Area_Bottom.ToolbarsManager = this.ultraToolbarsManager1;
    this.lblCompanyLocationName.AutoSize = true;
    this.lblCompanyLocationName.BackColor = Color.Transparent;
    this.lblCompanyLocationName.Font = new Font("Tahoma", 8.25f);
    this.lblCompanyLocationName.ForeColor = Color.Black;
    this.lblCompanyLocationName.Location = new Point(5, 139);
    this.lblCompanyLocationName.Name = "lblCompanyLocationName";
    this.lblCompanyLocationName.Size = new Size(99, 13);
    this.lblCompanyLocationName.TabIndex = 13;
    this.lblCompanyLocationName.Text = "Company Location:";
    this.comboCompanyLocation.BorderStyle = (UIElementBorderStyle) 4;
    this.comboCompanyLocation.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboCompanyLocation).Font = new Font("Tahoma", 8.25f);
    ((Control) this.comboCompanyLocation).Location = new Point(5, 155);
    this.comboCompanyLocation.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboCompanyLocation).Name = "comboCompanyLocation";
    ((Control) this.comboCompanyLocation).Size = new Size(262, 21);
    ((Control) this.comboCompanyLocation).TabIndex = 14;
    ((UltraControlBase) this.comboCompanyLocation).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboCompanyLocation).UseOsThemes = (DefaultableBoolean) 2;
    this.comboCompanyLocation.RowSelected += new RowSelectedEventHandler(this.comboCompanyLocation_RowSelected);
    this.lblLineOfBusinessName.AutoSize = true;
    this.lblLineOfBusinessName.BackColor = Color.Transparent;
    this.lblLineOfBusinessName.Font = new Font("Tahoma", 8.25f);
    this.lblLineOfBusinessName.ForeColor = Color.Black;
    this.lblLineOfBusinessName.Location = new Point(5, 181);
    this.lblLineOfBusinessName.Name = "lblLineOfBusinessName";
    this.lblLineOfBusinessName.Size = new Size(117, 13);
    this.lblLineOfBusinessName.TabIndex = 15;
    this.lblLineOfBusinessName.Text = "Line of Business Name:";
    this.comboLineOfBusinessName.BorderStyle = (UIElementBorderStyle) 4;
    this.comboLineOfBusinessName.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboLineOfBusinessName).Font = new Font("Tahoma", 8.25f);
    ((Control) this.comboLineOfBusinessName).Location = new Point(5, 197);
    this.comboLineOfBusinessName.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboLineOfBusinessName).Name = "comboLineOfBusinessName";
    ((Control) this.comboLineOfBusinessName).Size = new Size(262, 21);
    ((Control) this.comboLineOfBusinessName).TabIndex = 16 /*0x10*/;
    ((UltraControlBase) this.comboLineOfBusinessName).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboLineOfBusinessName).UseOsThemes = (DefaultableBoolean) 2;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(1240, 311);
    this.Controls.Add((Control) this.lblLineOfBusinessName);
    this.Controls.Add((Control) this.comboLineOfBusinessName);
    this.Controls.Add((Control) this.lblCompanyLocationName);
    this.Controls.Add((Control) this.comboCompanyLocation);
    this.Controls.Add((Control) this.comboOfficeActiveUsers);
    this.Controls.Add((Control) this.label1);
    this.Controls.Add((Control) this.gridWSBankSettings);
    this.Controls.Add((Control) this.lblBankAccount);
    this.Controls.Add((Control) this.lblOfficeLocation);
    this.Controls.Add((Control) this.btnCancel);
    this.Controls.Add((Control) this.buttonSave);
    this.Controls.Add((Control) this.comboBankAccount);
    this.Controls.Add((Control) this.comboOfficeLocation);
    this.Controls.Add((Control) this._formWSDefaultBankSettings_Toolbars_Dock_Area_Left);
    this.Controls.Add((Control) this._formWSDefaultBankSettings_Toolbars_Dock_Area_Right);
    this.Controls.Add((Control) this._formWSDefaultBankSettings_Toolbars_Dock_Area_Bottom);
    this.Controls.Add((Control) this._formWSDefaultBankSettings_Toolbars_Dock_Area_Top);
    this.FormBorderStyle = FormBorderStyle.SizableToolWindow;
    this.MaximizeBox = false;
    this.MaximumSize = new Size(1256, 350);
    this.MinimizeBox = false;
    this.MinimumSize = new Size(1256, 350);
    this.Name = nameof (formWSDefaultBankSettings);
    this.Text = "Web Service Bank Settings";
    this.Load += new EventHandler(this.FormWSDefaultBankSettings_Load);
    ((ISupportInitialize) this.mgaSimpleComboBox1).EndInit();
    ((ISupportInitialize) this.comboOfficeLocation).EndInit();
    ((ISupportInitialize) this.comboBankAccount).EndInit();
    ((ISupportInitialize) this.btnCancel).EndInit();
    ((ISupportInitialize) this.buttonSave).EndInit();
    ((ISupportInitialize) this.gridWSBankSettings).EndInit();
    ((ISupportInitialize) this.comboOfficeActiveUsers).EndInit();
    ((ISupportInitialize) this.ultraToolbarsManager1).EndInit();
    ((ISupportInitialize) this.comboCompanyLocation).EndInit();
    ((ISupportInitialize) this.comboLineOfBusinessName).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }
}
