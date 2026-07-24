// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.formClaimsAuditUserManagement
// Assembly: MgaSystems.IMS.Claims, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FCD9D0B7-28CF-40B9-8EB7-297871E1AF5F
// Assembly location: F:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using Infragistics.Win.UltraWinToolbars;
using MGASystems.Common;
using MGASystems.Common.MVC.BaseClasses.View;
using MGASystems.Data;
using MGASystems.IMS.Accounting.Services.Forms.MVC.WrappedUltraGridControl.Controller;
using MGASystems.IMS.Accounting.Services.Forms.MVC.WrappedUltraGridControl.Model;
using MGASystems.IMS.Accounting.Services.Forms.MVC.WrappedUltraGridControl.View;
using MGASystems.IMS.Claims.ClaimsAuditUser;
using MGASystems.IMS.Claims.DataAccess.ActiveUser;
using MGASystems.IMS.Claims.Properties;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Claims;

public class formClaimsAuditUserManagement : FormBase
{
  private bool _loadingUserAuditSettings;
  private IActiveUserRepository _activeUserRepository;
  private ActiveUserGridController _activeUserGridController;
  private ActiveUserDto _selectedUser;
  private IContainer components;
  private MGAGroupBox groupUsers;
  private Label label1;
  private MGASimpleComboBox comboGLCompanyId;
  private Label label2;
  private Label labelSelectOfficeLocation;
  private MGAGroupBox mgaGroupBox1;
  private MGATextBox textClaimNumberSearch;
  private Label label3;
  private MGACheckBox checkUserExceptions;
  private GroupBox groupBox2;
  private UltraGrid gridExceptions;
  private GroupBox groupBox1;
  private UltraGrid gridSearchResults;
  private Label label4;
  private MGAButton buttonSearch;
  private Label label5;
  private UltraToolbarsManager ultraToolbarsManager1;
  private UltraToolbarsDockArea _formClaimsAuditUserManagement_Toolbars_Dock_Area_Left;
  private UltraToolbarsDockArea _formClaimsAuditUserManagement_Toolbars_Dock_Area_Right;
  private UltraToolbarsDockArea _formClaimsAuditUserManagement_Toolbars_Dock_Area_Bottom;
  private UltraToolbarsDockArea _formClaimsAuditUserManagement_Toolbars_Dock_Area_Top;
  private WrappedUltraGridView userGrid;
  private MGATextBox txtUserSearch;

  private bool HasSelectedUser => this._selectedUser != null;

  public formClaimsAuditUserManagement(IActiveUserRepository activeUserRepository = null)
  {
    this._activeUserRepository = activeUserRepository ?? (IActiveUserRepository) new ActiveUserRepository();
    this.InitializeComponent();
  }

  private void LoadUsers(int glCompanyId)
  {
    if (((MvcViewBase<IUltraGridDataModel, IWrappedUltraGridController>) this.userGrid).IsWiredUp())
      ((MvcViewBase<IUltraGridDataModel, IWrappedUltraGridController>) this.userGrid).UnWireUp();
    if (this._activeUserGridController != null)
      this._activeUserGridController.GridSelectedObjectChanged -= new Action<object>(this.OnSelectedUserChanged);
    BasicUltraGridDataModel<ActiveUserDto> model = new BasicUltraGridDataModel<ActiveUserDto>(this._activeUserRepository.GetActiveUsersForGlCompanyId(glCompanyId));
    this._activeUserGridController = new ActiveUserGridController();
    this._activeUserGridController.GridSelectedObjectChanged += new Action<object>(this.OnSelectedUserChanged);
    ((MvcViewBase<IUltraGridDataModel, IWrappedUltraGridController>) this.userGrid).WireUp((IWrappedUltraGridController) this._activeUserGridController, (IUltraGridDataModel) model);
    this._activeUserGridController.InitializeListeners();
  }

  private void OnSelectedUserChanged(object obj)
  {
    if (obj is ActiveUserDto activeUserDto)
    {
      this._selectedUser = activeUserDto;
      this.GetAuditUserSettings();
    }
    else
      this._selectedUser = (ActiveUserDto) null;
  }

  private void LoadOfficeLocations()
  {
    ((UltraGridBase) this.comboGLCompanyId).DataSource = (object) DefaultDatabase.ExecuteDataTable("spFin_GetOfficeLocations");
    ((UltraDropDownBase) this.comboGLCompanyId).DisplayMember = "Office Location";
    ((UltraDropDownBase) this.comboGLCompanyId).ValueMember = "Id";
  }

  private void formClaimsAuditUserManagement_Load(object sender, EventArgs e)
  {
    this.LoadOfficeLocations();
  }

  private void comboGLCompanyId_RowSelected(object sender, RowSelectedEventArgs e)
  {
    if (((UltraDropDownBase) this.comboGLCompanyId).SelectedRow == null)
      return;
    this.LoadUsers((int) ((UltraCombo) this.comboGLCompanyId).Value);
    this.labelSelectOfficeLocation.Visible = false;
  }

  private void buttonSearch_Click(object sender, EventArgs e)
  {
    if (string.IsNullOrEmpty(((Control) this.textClaimNumberSearch).Text))
      return;
    this.SearchClaim(((Control) this.textClaimNumberSearch).Text);
  }

  private void SearchClaim(string claimNumber)
  {
    ((UltraGridBase) this.gridSearchResults).DataSource = (object) this.CreateDisplayDataSet(DefaultDatabase.ExecuteDataSet("spClaims_ClaimsSearch", new object[2]
    {
      (object) "@claimNumber",
      (object) claimNumber
    }));
    this.FormatGrid(this.gridSearchResults);
  }

  private DataTable CreateDisplayDataSet(DataSet ds)
  {
    DataTable displayDataSet = new DataTable();
    displayDataSet.Columns.AddRange(new DataColumn[5]
    {
      new DataColumn("ClaimId", typeof (int)),
      new DataColumn("Claim #", typeof (string)),
      new DataColumn("Policy #", typeof (string)),
      new DataColumn("Loss Date", typeof (DateTime)),
      new DataColumn("# Claimants", typeof (int))
    });
    for (int index = 0; index < ds.Tables[1].Rows.Count; ++index)
    {
      int num1 = (int) ds.Tables[1].Rows[index]["ClaimId"];
      string str1 = ds.Tables[1].Rows[index]["ClaimNumber"].ToString();
      DateTime dateTime = (DateTime) ds.Tables[1].Rows[index]["LossDate"];
      int num2 = (int) ds.Tables[1].Rows[index]["Claimants"];
      string str2 = ds.Tables[0].Select($"controlNumber = {(int) ds.Tables[1].Rows[index]["ControlNumber"]}")[0]["PolicyNumber"].ToString();
      displayDataSet.Rows.Add((object) num1, (object) str1, (object) str2, (object) dateTime, (object) num2);
    }
    return displayDataSet;
  }

  private void FormatGrid(UltraGrid grid)
  {
    ((UltraGridBase) grid).DisplayLayout.Bands[0].Columns["ClaimId"].Hidden = true;
    if (((KeyedSubObjectsCollectionBase) ((UltraGridBase) grid).DisplayLayout.Bands[0].Columns).Exists("# Claimants"))
      ((UltraGridBase) grid).DisplayLayout.Bands[0].Columns["# Claimants"].Width = 50;
    if (!((KeyedSubObjectsCollectionBase) ((UltraGridBase) grid).DisplayLayout.Bands[0].Columns).Exists("Loss Date"))
      return;
    ((UltraGridBase) grid).DisplayLayout.Bands[0].Columns["Loss Date"].Width = 50;
  }

  private void InsertAuditUserSetting(int claimId)
  {
    Utility.LogAction($"Insert the claim audit exception for userGuid '{this._selectedUser.UserGuid.ToString()}', claim Id {claimId}", 0);
    DefaultDatabase.ExecuteNonQuery("spClaims_InsertAuditUserSetting", new object[8]
    {
      (object) "@userGuid",
      (object) this._selectedUser.UserGuid,
      (object) "@claimId",
      (object) claimId,
      (object) "@enteredByGuid",
      (object) CurrentUser.Instance.UserGUID,
      (object) "@dateEntered",
      (object) DateTime.Now
    });
  }

  private void DeleteAuditUserSetting(int claimId)
  {
    Utility.LogAction($"Delete the claim audit exception for userGuid '{this._selectedUser.UserGuid.ToString()}', claim Id {claimId}", 0);
    DefaultDatabase.ExecuteNonQuery("spClaims_DeleteAuditUserSetting", new object[4]
    {
      (object) "@userGuid",
      (object) this._selectedUser.UserGuid,
      (object) "@claimId",
      (object) claimId
    });
  }

  private void GetAuditUserSettings()
  {
    this._loadingUserAuditSettings = true;
    DataTable dataTable = DefaultDatabase.ExecuteDataTable("spClaims_GetAuditUserSettings", new object[2]
    {
      (object) "@userGuid",
      (object) this._selectedUser.UserGuid
    });
    ((UltraToggleEditorBase) this.checkUserExceptions).Checked = dataTable.Rows.Count == 0;
    ((Control) this.checkUserExceptions).Enabled = dataTable.Rows.Count != 0;
    ((UltraGridBase) this.gridExceptions).DataSource = (object) dataTable;
    this.FormatGrid(this.gridExceptions);
    this._loadingUserAuditSettings = false;
  }

  private void ultraToolbarsManager1_ToolClick(object sender, ToolClickEventArgs e)
  {
    if (!this.HasSelectedUser)
    {
      int num = (int) MessageBox.Show("You must select a user to continue.", "User Selection Required!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else
    {
      switch (((KeyedSubObjectBase) ((ToolEventArgs) e).Tool).Key)
      {
        case "ADDEXCEPTION":
          this.AddException();
          break;
        case "REMOVEEXCEPTION":
          this.RemoveException();
          break;
      }
    }
  }

  private void RemoveException()
  {
    if (((DisposableObjectCollectionBase) ((UltraGridBase) this.gridExceptions).Rows).Count == 0 || ((SparseCollectionBase) this.gridExceptions.Selected.Rows).Count == 0)
    {
      int num = (int) MessageBox.Show("You must select an audit setting to continue.", "Audit Setting Selection Required!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else
    {
      if (MessageBox.Show("This will permenantly delete the audit user setting, continue?", "Permenantly Delete Audit Setting?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
        return;
      this.DeleteAuditUserSetting(int.Parse(this.gridExceptions.Selected.Rows[0].Cells["ClaimId"].Value.ToString()));
      this.GetAuditUserSettings();
    }
  }

  private void AddException()
  {
    if (((DisposableObjectCollectionBase) ((UltraGridBase) this.gridSearchResults).Rows).Count == 0 || ((SparseCollectionBase) this.gridSearchResults.Selected.Rows).Count == 0)
    {
      int num = (int) MessageBox.Show("You must select a claim to continue.", "Claim Selection Required!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else
    {
      this.InsertAuditUserSetting(int.Parse(this.gridSearchResults.Selected.Rows[0].Cells["ClaimId"].Value.ToString()));
      this.GetAuditUserSettings();
    }
  }

  private void checkUserExceptions_BeforeCheckStateChanged(object sender, CancelEventArgs e)
  {
    if (this._loadingUserAuditSettings || !((Control) this.checkUserExceptions).Enabled || !this.HasSelectedUser || ((DisposableObjectCollectionBase) ((UltraGridBase) this.gridExceptions).Rows).Count == 0)
      return;
    if (MessageBox.Show("This will clear all of exceptions set for the current users, are you sure you wish to do this?", "Clear All User Audit Settings?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
    {
      e.Cancel = true;
    }
    else
    {
      foreach (UltraGridRow row in ((UltraGridBase) this.gridExceptions).Rows)
        this.DeleteAuditUserSetting(int.Parse(row.Cells["ClaimId"].Value.ToString()));
      this.GetAuditUserSettings();
    }
  }

  private void OnUserSearchValueChanged(object sender, EventArgs e)
  {
    MGATextBox textBox = sender as MGATextBox;
    if (textBox == null || Utility.IsNull((object) this._activeUserGridController))
      return;
    this._activeUserGridController?.SetTopLevelFilter((System.Func<ActiveUserDto, bool>) (dto => dto.Name.Contains(((Control) textBox).Text)));
    this._activeUserGridController.ClearSelected();
  }

  private void txtUserSearch_EditorButtonClick(object sender, EditorButtonEventArgs e)
  {
    ((Control) this.txtUserSearch).Text = string.Empty;
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
    EditorButton editorButton = new EditorButton();
    Appearance appearance4 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (formClaimsAuditUserManagement));
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("", -1);
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    ScrollBarLook scrollBarLook1 = new ScrollBarLook();
    Appearance appearance16 = new Appearance();
    Appearance appearance17 = new Appearance();
    Appearance appearance18 = new Appearance();
    UltraGridBand ultraGridBand2 = new UltraGridBand("", -1);
    Appearance appearance19 = new Appearance();
    Appearance appearance20 = new Appearance();
    Appearance appearance21 = new Appearance();
    Appearance appearance22 = new Appearance();
    Appearance appearance23 = new Appearance();
    Appearance appearance24 = new Appearance();
    Appearance appearance25 = new Appearance();
    ScrollBarLook scrollBarLook2 = new ScrollBarLook();
    Appearance appearance26 = new Appearance();
    Appearance appearance27 = new Appearance();
    Appearance appearance28 = new Appearance();
    Appearance appearance29 = new Appearance();
    UltraToolbar ultraToolbar = new UltraToolbar("UltraToolbar1");
    PopupMenuTool popupMenuTool1 = new PopupMenuTool("contextSearchGrid");
    ButtonTool buttonTool1 = new ButtonTool("ADDEXCEPTION");
    PopupMenuTool popupMenuTool2 = new PopupMenuTool("contextExceptionGrid");
    ButtonTool buttonTool2 = new ButtonTool("REMOVEEXCEPTION");
    ButtonTool buttonTool3 = new ButtonTool("ADDEXCEPTION");
    Appearance appearance30 = new Appearance();
    ButtonTool buttonTool4 = new ButtonTool("REMOVEEXCEPTION");
    Appearance appearance31 = new Appearance();
    this.groupUsers = new MGAGroupBox();
    this.txtUserSearch = new MGATextBox();
    this.labelSelectOfficeLocation = new Label();
    this.label2 = new Label();
    this.comboGLCompanyId = new MGASimpleComboBox();
    this.label1 = new Label();
    this.userGrid = new WrappedUltraGridView();
    this.mgaGroupBox1 = new MGAGroupBox();
    this.label5 = new Label();
    this.checkUserExceptions = new MGACheckBox();
    this.groupBox2 = new GroupBox();
    this.gridExceptions = new UltraGrid();
    this.groupBox1 = new GroupBox();
    this.gridSearchResults = new UltraGrid();
    this.label4 = new Label();
    this.buttonSearch = new MGAButton();
    this.textClaimNumberSearch = new MGATextBox();
    this.label3 = new Label();
    this._formClaimsAuditUserManagement_Toolbars_Dock_Area_Left = new UltraToolbarsDockArea();
    this.ultraToolbarsManager1 = new UltraToolbarsManager(this.components);
    this._formClaimsAuditUserManagement_Toolbars_Dock_Area_Right = new UltraToolbarsDockArea();
    this._formClaimsAuditUserManagement_Toolbars_Dock_Area_Top = new UltraToolbarsDockArea();
    this._formClaimsAuditUserManagement_Toolbars_Dock_Area_Bottom = new UltraToolbarsDockArea();
    ((ISupportInitialize) this.groupUsers).BeginInit();
    ((Control) this.groupUsers).SuspendLayout();
    ((ISupportInitialize) this.txtUserSearch).BeginInit();
    ((ISupportInitialize) this.comboGLCompanyId).BeginInit();
    ((ISupportInitialize) this.mgaGroupBox1).BeginInit();
    ((Control) this.mgaGroupBox1).SuspendLayout();
    ((ISupportInitialize) this.checkUserExceptions).BeginInit();
    this.groupBox2.SuspendLayout();
    ((ISupportInitialize) this.gridExceptions).BeginInit();
    this.groupBox1.SuspendLayout();
    ((ISupportInitialize) this.gridSearchResults).BeginInit();
    ((ISupportInitialize) this.buttonSearch).BeginInit();
    ((ISupportInitialize) this.textClaimNumberSearch).BeginInit();
    ((ISupportInitialize) this.ultraToolbarsManager1).BeginInit();
    this.SuspendLayout();
    ((Control) this.groupUsers).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
    ((AppearanceBase) appearance1).BackColor = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance1).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGroupBox) this.groupUsers).ContentAreaAppearance = (AppearanceBase) appearance1;
    ((Control) this.groupUsers).Controls.Add((Control) this.txtUserSearch);
    ((Control) this.groupUsers).Controls.Add((Control) this.labelSelectOfficeLocation);
    ((Control) this.groupUsers).Controls.Add((Control) this.label2);
    ((Control) this.groupUsers).Controls.Add((Control) this.comboGLCompanyId);
    ((Control) this.groupUsers).Controls.Add((Control) this.label1);
    ((Control) this.groupUsers).Controls.Add((Control) this.userGrid);
    ((AppearanceBase) appearance2).ForeColor = Color.Black;
    ((UltraGroupBox) this.groupUsers).HeaderAppearance = (AppearanceBase) appearance2;
    ((Control) this.groupUsers).Location = new Point(12, 12);
    ((Control) this.groupUsers).Name = "groupUsers";
    ((Control) this.groupUsers).Size = new Size(287, 582);
    ((Control) this.groupUsers).TabIndex = 0;
    ((Control) this.groupUsers).Text = "IMS Users";
    ((UltraGroupBox) this.groupUsers).ViewStyle = (GroupBoxViewStyle) 2;
    ((AppearanceBase) appearance3).BackColor = Color.White;
    ((AppearanceBase) appearance3).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance3).ForeColor = Color.Black;
    ((AppearanceBase) appearance3).Image = (object) Resources.magnifier;
    ((TextEditorControlBase) this.txtUserSearch).Appearance = (AppearanceBase) appearance3;
    ((Control) this.txtUserSearch).BackColor = Color.White;
    ((AppearanceBase) appearance4).Image = componentResourceManager.GetObject("appearance3.Image");
    ((EditorButtonBase) editorButton).Appearance = (AppearanceBase) appearance4;
    ((EditorButtonControlBase) this.txtUserSearch).ButtonsRight.Add((EditorButtonBase) editorButton);
    ((Control) this.txtUserSearch).Location = new Point(9, 75);
    ((Control) this.txtUserSearch).Margin = new Padding(3, 3, 3, 0);
    this.txtUserSearch.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtUserSearch).Name = "txtUserSearch";
    ((Control) this.txtUserSearch).Size = new Size(268, 20);
    ((Control) this.txtUserSearch).TabIndex = 6;
    ((UltraControlBase) this.txtUserSearch).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtUserSearch).UseOsThemes = (DefaultableBoolean) 2;
    ((TextEditorControlBase) this.txtUserSearch).ValueChanged += new EventHandler(this.OnUserSearchValueChanged);
    ((EditorButtonControlBase) this.txtUserSearch).EditorButtonClick += new EditorButtonEventHandler(this.txtUserSearch_EditorButtonClick);
    this.labelSelectOfficeLocation.BackColor = Color.White;
    this.labelSelectOfficeLocation.Location = new Point(11, 296);
    this.labelSelectOfficeLocation.Name = "labelSelectOfficeLocation";
    this.labelSelectOfficeLocation.Size = new Size(264, 17);
    this.labelSelectOfficeLocation.TabIndex = 4;
    this.labelSelectOfficeLocation.Text = "Please select an office location....";
    this.labelSelectOfficeLocation.TextAlign = ContentAlignment.MiddleCenter;
    this.label2.BackColor = Color.SlateGray;
    this.label2.Location = new Point(16 /*0x10*/, 68);
    this.label2.Name = "label2";
    this.label2.Size = new Size(250, 1);
    this.label2.TabIndex = 2;
    ((UltraCombo) this.comboGLCompanyId).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraCombo) this.comboGLCompanyId).DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboGLCompanyId).Location = new Point(9, 40);
    this.comboGLCompanyId.MGAStyle = (MGAStyles) 2;
    ((Control) this.comboGLCompanyId).Name = "comboGLCompanyId";
    ((Control) this.comboGLCompanyId).Size = new Size(268, 21);
    ((Control) this.comboGLCompanyId).TabIndex = 1;
    ((UltraControlBase) this.comboGLCompanyId).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboGLCompanyId).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraCombo) this.comboGLCompanyId).RowSelected += new RowSelectedEventHandler(this.comboGLCompanyId_RowSelected);
    this.label1.AutoSize = true;
    this.label1.BackColor = Color.Transparent;
    this.label1.Location = new Point(6, 23);
    this.label1.Name = "label1";
    this.label1.Size = new Size(83, 13);
    this.label1.TabIndex = 0;
    this.label1.Text = "Office Location:";
    ((UserControl) this.userGrid).AutoSizeMode = AutoSizeMode.GrowAndShrink;
    ((Control) this.userGrid).BackColor = Color.Transparent;
    ((Control) this.userGrid).Location = new Point(9, 103);
    ((Control) this.userGrid).Name = "userGrid";
    ((Control) this.userGrid).Size = new Size(268, 471);
    ((Control) this.userGrid).TabIndex = 5;
    ((Control) this.mgaGroupBox1).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((AppearanceBase) appearance5).BackColor = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance5).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGroupBox) this.mgaGroupBox1).ContentAreaAppearance = (AppearanceBase) appearance5;
    ((Control) this.mgaGroupBox1).Controls.Add((Control) this.label5);
    ((Control) this.mgaGroupBox1).Controls.Add((Control) this.checkUserExceptions);
    ((Control) this.mgaGroupBox1).Controls.Add((Control) this.groupBox2);
    ((Control) this.mgaGroupBox1).Controls.Add((Control) this.groupBox1);
    ((Control) this.mgaGroupBox1).Controls.Add((Control) this.label4);
    ((Control) this.mgaGroupBox1).Controls.Add((Control) this.buttonSearch);
    ((Control) this.mgaGroupBox1).Controls.Add((Control) this.textClaimNumberSearch);
    ((Control) this.mgaGroupBox1).Controls.Add((Control) this.label3);
    ((AppearanceBase) appearance6).ForeColor = Color.Black;
    ((UltraGroupBox) this.mgaGroupBox1).HeaderAppearance = (AppearanceBase) appearance6;
    ((Control) this.mgaGroupBox1).Location = new Point(305, 12);
    ((Control) this.mgaGroupBox1).Name = "mgaGroupBox1";
    ((Control) this.mgaGroupBox1).Size = new Size(567, 582);
    ((Control) this.mgaGroupBox1).TabIndex = 5;
    ((Control) this.mgaGroupBox1).Text = "Claim Numbers Search";
    ((UltraGroupBox) this.mgaGroupBox1).ViewStyle = (GroupBoxViewStyle) 2;
    this.label5.AutoSize = true;
    this.label5.BackColor = Color.Transparent;
    this.label5.ForeColor = Color.Red;
    this.label5.Location = new Point(120, 323);
    this.label5.Name = "label5";
    this.label5.Size = new Size(395, 13);
    this.label5.TabIndex = 9;
    this.label5.Text = "Users with claim numbers assigned will only be able to view the claim(s) specified.";
    ((AppearanceBase) appearance7).BackColor = Color.Transparent;
    ((AppearanceBase) appearance7).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance7).ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.checkUserExceptions).Appearance = (AppearanceBase) appearance7;
    ((Control) this.checkUserExceptions).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.checkUserExceptions).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.checkUserExceptions).Checked = true;
    ((UltraToggleEditorBase) this.checkUserExceptions).CheckState = CheckState.Checked;
    ((Control) this.checkUserExceptions).Enabled = false;
    ((UltraToggleEditorBase) this.checkUserExceptions).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.StandardCheckBoxGlyphInfo;
    ((Control) this.checkUserExceptions).Location = new Point(16 /*0x10*/, 322);
    this.checkUserExceptions.MGAStyle = (MGAStyles) 2;
    ((Control) this.checkUserExceptions).Name = "checkUserExceptions";
    ((Control) this.checkUserExceptions).Size = new Size(120, 12);
    ((Control) this.checkUserExceptions).TabIndex = 6;
    ((Control) this.checkUserExceptions).Text = "No Exceptions";
    ((UltraControlBase) this.checkUserExceptions).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.checkUserExceptions).UseOsThemes = (DefaultableBoolean) 2;
    // ISSUE: method pointer
    ((UltraToggleEditorBase) this.checkUserExceptions).BeforeCheckStateChanged += new ToggleEditorBase.BeforeCheckStateChangedHandler((object) this, __methodptr(checkUserExceptions_BeforeCheckStateChanged));
    this.groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.groupBox2.BackColor = Color.Transparent;
    this.groupBox2.Controls.Add((Control) this.gridExceptions);
    this.groupBox2.Location = new Point(10, 340);
    this.groupBox2.Name = "groupBox2";
    this.groupBox2.Size = new Size(545, 232);
    this.groupBox2.TabIndex = 8;
    this.groupBox2.TabStop = false;
    this.groupBox2.Text = "Exceptions";
    ((Control) this.gridExceptions).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.ultraToolbarsManager1.SetContextMenuUltra((Component) this.gridExceptions, "contextExceptionGrid");
    ((AppearanceBase) appearance8).BackColor = Color.White;
    ((AppearanceBase) appearance8).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridExceptions).DisplayLayout.Appearance = (AppearanceBase) appearance8;
    ((UltraGridBase) this.gridExceptions).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((AppearanceBase) appearance9).TextHAlignAsString = "Left";
    ultraGridBand1.Override.HeaderAppearance = (AppearanceBase) appearance9;
    ((UltraGridBase) this.gridExceptions).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.gridExceptions).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance10).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance10).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance10).ForeColor = Color.Black;
    ((UltraGridBase) this.gridExceptions).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance10;
    ((UltraGridBase) this.gridExceptions).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridExceptions).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridExceptions).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance11).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridExceptions).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance11;
    ((UltraGridBase) this.gridExceptions).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance12).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.gridExceptions).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance12;
    ((UltraGridBase) this.gridExceptions).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance13).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridExceptions).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance13;
    ((AppearanceBase) appearance14).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridExceptions).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance14;
    ((UltraGridBase) this.gridExceptions).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance15).BackColor = Color.Transparent;
    ((AppearanceBase) appearance15).ForeColor = Color.Black;
    ((UltraGridBase) this.gridExceptions).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance15;
    ((AppearanceBase) appearance16).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance16).BorderColor = Color.Silver;
    scrollBarLook1.ButtonAppearance = (AppearanceBase) appearance16;
    ((AppearanceBase) appearance17).BackColor = Color.White;
    scrollBarLook1.TrackAppearance = (AppearanceBase) appearance17;
    ((UltraGridBase) this.gridExceptions).DisplayLayout.ScrollBarLook = scrollBarLook1;
    ((Control) this.gridExceptions).Location = new Point(6, 15);
    ((Control) this.gridExceptions).Name = "gridExceptions";
    ((Control) this.gridExceptions).Size = new Size(533, 209);
    ((Control) this.gridExceptions).TabIndex = 5;
    ((UltraControlBase) this.gridExceptions).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridExceptions).UseOsThemes = (DefaultableBoolean) 2;
    this.groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.groupBox1.BackColor = Color.Transparent;
    this.groupBox1.Controls.Add((Control) this.gridSearchResults);
    this.groupBox1.Location = new Point(10, 78);
    this.groupBox1.Name = "groupBox1";
    this.groupBox1.Size = new Size(545, 235);
    this.groupBox1.TabIndex = 7;
    this.groupBox1.TabStop = false;
    this.groupBox1.Text = "Search Results";
    ((Control) this.gridSearchResults).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.ultraToolbarsManager1.SetContextMenuUltra((Component) this.gridSearchResults, "contextSearchGrid");
    ((AppearanceBase) appearance18).BackColor = Color.White;
    ((AppearanceBase) appearance18).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridSearchResults).DisplayLayout.Appearance = (AppearanceBase) appearance18;
    ((UltraGridBase) this.gridSearchResults).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((AppearanceBase) appearance19).TextHAlignAsString = "Left";
    ultraGridBand2.Override.HeaderAppearance = (AppearanceBase) appearance19;
    ((UltraGridBase) this.gridSearchResults).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.gridSearchResults).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance20).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance20).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance20).ForeColor = Color.Black;
    ((UltraGridBase) this.gridSearchResults).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance20;
    ((UltraGridBase) this.gridSearchResults).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridSearchResults).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridSearchResults).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance21).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridSearchResults).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance21;
    ((UltraGridBase) this.gridSearchResults).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance22).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.gridSearchResults).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance22;
    ((UltraGridBase) this.gridSearchResults).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance23).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridSearchResults).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance23;
    ((AppearanceBase) appearance24).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridSearchResults).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance24;
    ((UltraGridBase) this.gridSearchResults).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance25).BackColor = Color.Transparent;
    ((AppearanceBase) appearance25).ForeColor = Color.Black;
    ((UltraGridBase) this.gridSearchResults).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance25;
    ((AppearanceBase) appearance26).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance26).BorderColor = Color.Silver;
    scrollBarLook2.ButtonAppearance = (AppearanceBase) appearance26;
    ((AppearanceBase) appearance27).BackColor = Color.White;
    scrollBarLook2.TrackAppearance = (AppearanceBase) appearance27;
    ((UltraGridBase) this.gridSearchResults).DisplayLayout.ScrollBarLook = scrollBarLook2;
    ((Control) this.gridSearchResults).Location = new Point(0, 20);
    ((Control) this.gridSearchResults).Name = "gridSearchResults";
    ((Control) this.gridSearchResults).Size = new Size(533, 212);
    ((Control) this.gridSearchResults).TabIndex = 5;
    ((UltraControlBase) this.gridSearchResults).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridSearchResults).UseOsThemes = (DefaultableBoolean) 2;
    this.label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.label4.BackColor = Color.SlateGray;
    this.label4.Location = new Point(13, 68);
    this.label4.Name = "label4";
    this.label4.Size = new Size(535, 1);
    this.label4.TabIndex = 4;
    ((AppearanceBase) appearance28).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance28).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance28).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance28).BorderColor = Color.Black;
    ((AppearanceBase) appearance28).Image = componentResourceManager.GetObject("appearance29.Image");
    ((AppearanceBase) appearance28).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance28).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonSearch).Appearance = (AppearanceBase) appearance28;
    ((Control) this.buttonSearch).Location = new Point(368, 39);
    ((Control) this.buttonSearch).Name = "buttonSearch";
    ((Control) this.buttonSearch).Size = new Size(22, 22);
    ((Control) this.buttonSearch).TabIndex = 3;
    ((UltraControlBase) this.buttonSearch).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.buttonSearch).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonSearch).Click += new EventHandler(this.buttonSearch_Click);
    ((AppearanceBase) appearance29).BackColor = Color.White;
    ((AppearanceBase) appearance29).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance29).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textClaimNumberSearch).Appearance = (AppearanceBase) appearance29;
    ((Control) this.textClaimNumberSearch).BackColor = Color.White;
    ((Control) this.textClaimNumberSearch).Location = new Point(16 /*0x10*/, 40);
    this.textClaimNumberSearch.MGAStyle = (MGAStyles) 2;
    ((Control) this.textClaimNumberSearch).Name = "textClaimNumberSearch";
    ((Control) this.textClaimNumberSearch).Size = new Size(346, 20);
    ((Control) this.textClaimNumberSearch).TabIndex = 2;
    ((UltraControlBase) this.textClaimNumberSearch).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textClaimNumberSearch).UseOsThemes = (DefaultableBoolean) 2;
    this.label3.AutoSize = true;
    this.label3.BackColor = Color.Transparent;
    this.label3.Location = new Point(13, 23);
    this.label3.Name = "label3";
    this.label3.Size = new Size(77, 13);
    this.label3.TabIndex = 1;
    this.label3.Text = "Search Claims:";
    ((Control) this._formClaimsAuditUserManagement_Toolbars_Dock_Area_Left).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._formClaimsAuditUserManagement_Toolbars_Dock_Area_Left).BackColor = SystemColors.Control;
    this._formClaimsAuditUserManagement_Toolbars_Dock_Area_Left.DockedPosition = (DockedPosition) 2;
    ((Control) this._formClaimsAuditUserManagement_Toolbars_Dock_Area_Left).ForeColor = SystemColors.ControlText;
    ((Control) this._formClaimsAuditUserManagement_Toolbars_Dock_Area_Left).Location = new Point(0, 0);
    ((Control) this._formClaimsAuditUserManagement_Toolbars_Dock_Area_Left).Name = "_formClaimsAuditUserManagement_Toolbars_Dock_Area_Left";
    ((Control) this._formClaimsAuditUserManagement_Toolbars_Dock_Area_Left).Size = new Size(0, 596);
    this._formClaimsAuditUserManagement_Toolbars_Dock_Area_Left.ToolbarsManager = this.ultraToolbarsManager1;
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
    ((ToolPropsBase) ((ToolBase) popupMenuTool1).SharedPropsInternal).Caption = "contextSearchGrid";
    ((ToolsCollectionBase) popupMenuTool1.Tools).AddRange(new ToolBase[1]
    {
      (ToolBase) buttonTool1
    });
    ((ToolPropsBase) ((ToolBase) popupMenuTool2).SharedPropsInternal).Caption = "contextExceptionGrid";
    ((ToolsCollectionBase) popupMenuTool2.Tools).AddRange(new ToolBase[1]
    {
      (ToolBase) buttonTool2
    });
    ((AppearanceBase) appearance30).Image = (object) Resources.Add;
    ((ToolPropsBase) ((ToolBase) buttonTool3).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance30;
    ((ToolPropsBase) ((ToolBase) buttonTool3).SharedPropsInternal).Caption = "Add Audit Exception";
    ((AppearanceBase) appearance31).Image = (object) Resources.DeleteClaimSmall;
    ((ToolPropsBase) ((ToolBase) buttonTool4).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance31;
    ((ToolPropsBase) ((ToolBase) buttonTool4).SharedPropsInternal).Caption = "Remove Audit Exception";
    ((ToolsCollectionBase) this.ultraToolbarsManager1.Tools).AddRange(new ToolBase[4]
    {
      (ToolBase) popupMenuTool1,
      (ToolBase) popupMenuTool2,
      (ToolBase) buttonTool3,
      (ToolBase) buttonTool4
    });
    this.ultraToolbarsManager1.ToolClick += new ToolClickEventHandler(this.ultraToolbarsManager1_ToolClick);
    ((Control) this._formClaimsAuditUserManagement_Toolbars_Dock_Area_Right).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._formClaimsAuditUserManagement_Toolbars_Dock_Area_Right).BackColor = SystemColors.Control;
    this._formClaimsAuditUserManagement_Toolbars_Dock_Area_Right.DockedPosition = (DockedPosition) 3;
    ((Control) this._formClaimsAuditUserManagement_Toolbars_Dock_Area_Right).ForeColor = SystemColors.ControlText;
    ((Control) this._formClaimsAuditUserManagement_Toolbars_Dock_Area_Right).Location = new Point(872, 0);
    ((Control) this._formClaimsAuditUserManagement_Toolbars_Dock_Area_Right).Name = "_formClaimsAuditUserManagement_Toolbars_Dock_Area_Right";
    ((Control) this._formClaimsAuditUserManagement_Toolbars_Dock_Area_Right).Size = new Size(0, 596);
    this._formClaimsAuditUserManagement_Toolbars_Dock_Area_Right.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._formClaimsAuditUserManagement_Toolbars_Dock_Area_Top).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._formClaimsAuditUserManagement_Toolbars_Dock_Area_Top).BackColor = SystemColors.Control;
    this._formClaimsAuditUserManagement_Toolbars_Dock_Area_Top.DockedPosition = (DockedPosition) 0;
    ((Control) this._formClaimsAuditUserManagement_Toolbars_Dock_Area_Top).ForeColor = SystemColors.ControlText;
    ((Control) this._formClaimsAuditUserManagement_Toolbars_Dock_Area_Top).Location = new Point(0, 0);
    ((Control) this._formClaimsAuditUserManagement_Toolbars_Dock_Area_Top).Name = "_formClaimsAuditUserManagement_Toolbars_Dock_Area_Top";
    ((Control) this._formClaimsAuditUserManagement_Toolbars_Dock_Area_Top).Size = new Size(872, 0);
    this._formClaimsAuditUserManagement_Toolbars_Dock_Area_Top.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._formClaimsAuditUserManagement_Toolbars_Dock_Area_Bottom).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._formClaimsAuditUserManagement_Toolbars_Dock_Area_Bottom).BackColor = SystemColors.Control;
    this._formClaimsAuditUserManagement_Toolbars_Dock_Area_Bottom.DockedPosition = (DockedPosition) 1;
    ((Control) this._formClaimsAuditUserManagement_Toolbars_Dock_Area_Bottom).ForeColor = SystemColors.ControlText;
    ((Control) this._formClaimsAuditUserManagement_Toolbars_Dock_Area_Bottom).Location = new Point(0, 596);
    ((Control) this._formClaimsAuditUserManagement_Toolbars_Dock_Area_Bottom).Name = "_formClaimsAuditUserManagement_Toolbars_Dock_Area_Bottom";
    ((Control) this._formClaimsAuditUserManagement_Toolbars_Dock_Area_Bottom).Size = new Size(872, 0);
    this._formClaimsAuditUserManagement_Toolbars_Dock_Area_Bottom.ToolbarsManager = this.ultraToolbarsManager1;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(872, 596);
    this.Controls.Add((Control) this.mgaGroupBox1);
    this.Controls.Add((Control) this.groupUsers);
    this.Controls.Add((Control) this._formClaimsAuditUserManagement_Toolbars_Dock_Area_Left);
    this.Controls.Add((Control) this._formClaimsAuditUserManagement_Toolbars_Dock_Area_Right);
    this.Controls.Add((Control) this._formClaimsAuditUserManagement_Toolbars_Dock_Area_Bottom);
    this.Controls.Add((Control) this._formClaimsAuditUserManagement_Toolbars_Dock_Area_Top);
    this.Font = new Font("Tahoma", 8.25f);
    this.Name = nameof (formClaimsAuditUserManagement);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Claims Audit User Management";
    this.Load += new EventHandler(this.formClaimsAuditUserManagement_Load);
    ((ISupportInitialize) this.groupUsers).EndInit();
    ((Control) this.groupUsers).ResumeLayout(false);
    ((Control) this.groupUsers).PerformLayout();
    ((ISupportInitialize) this.txtUserSearch).EndInit();
    ((ISupportInitialize) this.comboGLCompanyId).EndInit();
    ((ISupportInitialize) this.mgaGroupBox1).EndInit();
    ((Control) this.mgaGroupBox1).ResumeLayout(false);
    ((Control) this.mgaGroupBox1).PerformLayout();
    ((ISupportInitialize) this.checkUserExceptions).EndInit();
    this.groupBox2.ResumeLayout(false);
    ((ISupportInitialize) this.gridExceptions).EndInit();
    this.groupBox1.ResumeLayout(false);
    ((ISupportInitialize) this.gridSearchResults).EndInit();
    ((ISupportInitialize) this.buttonSearch).EndInit();
    ((ISupportInitialize) this.textClaimNumberSearch).EndInit();
    ((ISupportInitialize) this.ultraToolbarsManager1).EndInit();
    this.ResumeLayout(false);
  }
}
