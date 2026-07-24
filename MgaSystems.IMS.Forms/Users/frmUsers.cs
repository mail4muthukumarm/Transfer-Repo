// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Forms.Users.frmUsers
// Assembly: MgaSystems.IMS.Forms, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FB3F392E-40B6-486F-8F0B-A4A494A546D4
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Forms.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinMaskedEdit;
using Infragistics.Win.UltraWinTabControl;
using Infragistics.Win.UltraWinTabs;
using Infragistics.Win.UltraWinToolbars;
using MGASystems.AddressResolver;
using MGASystems.Common;
using MGASystems.Common.BroadcastMessaging;
using MGASystems.Common.ErrorHandling;
using MGASystems.Common.LogonServer;
using MGASystems.Data;
using MGASystems.IMS.NoteDocuments;
using MGASystems.IMS.Security;
using MGASystems.Tools;
using MGASystems.Tools.DBSaveUI;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Forms.Users;

[DocumentFolderFilter("User Administration")]
[SecureResource("{C2400842-F692-4f8a-9E42-B07980F04FBB}", "Edit Own User Information", "Controls the ability for a user to edit their own user information.", "Users")]
[SecureResource("{57AE819E-03F0-48d6-93CB-B5451E6D186F}", "Replace Inactive Users", "Controls the ability to replace inactive underwriters, assistant underwriters,etc with active users.", "Users")]
[SecureResource("{0BC4F32D-9489-4373-B358-B9E16EFA5883}", "Allows Access to Insured Viewing Rights", "Controls the ability to access Insured Viewing Rights UI.", "Users")]
[SecureResource("{87BEE935-5205-427f-9630-9C342E4ABE7E}", "Allows Access to Quoting Office Viewing Rights", "Controls the ability to access Quoting Office Viewing Rights UI.", "Users")]
[SecureResource("{13227AB4-1F29-40E2-94BA-F94AFE8CB885}", "Allows Access to Issuing Office Viewing Rights", "Controls the ability to access Issuing Office Viewing Rights UI.", "Users")]
[SecureResource("{305A65F9-B018-4c54-990D-F39BF27E4203}", "Allows Access to Producer Location Viewing Rights", "Controls the ability to access Producer Location Viewing Rights UI.", "Users")]
[SecureResource("{48A04113-3012-4237-9CCF-C5EB1EBB2F32}", "Allows Access to Policy Viewing Rights", "Controls the ability to access Policy Viewing Rights UI.", "Users")]
[SecureResource("{0B269EA5-EED3-4491-80B3-891DB35171EF}", "Allows Access to Fee Restriction Viewing Rights", "Controls the ability to access Fee Restriction Viewing Rights UI.", "Users")]
[SecureResource("{8021181D-4F53-4478-B390-6887E8C2EB54}", "Allows Saving of User Info", "Controls the ability to save user info.", "Users")]
[SecureResource("{CA58AA4C-B044-4AE2-A791-DF2755472442}", "Allows Deletion of User Info", "Controls the ability to delete user info.", "Users")]
[SecureResource("{CF3C09E2-1F42-481e-A977-AE8B157B6C1A}", "Edit Other User's Information", "Controls the ability for a user to edit other user's information.", "Users")]
public class frmUsers : Form, ISupportNoteSystem, ISupportDocumentSystem
{
  private IContainer components;
  private UltraToolbarsDockArea _frmUsers_Toolbars_Dock_Area_Left;
  private UltraToolbarsDockArea _frmUsers_Toolbars_Dock_Area_Right;
  private UltraToolbarsDockArea _frmUsers_Toolbars_Dock_Area_Top;
  private UltraToolbarsDockArea _frmUsers_Toolbars_Dock_Area_Bottom;
  internal const string EditOwnInformation = "{C2400842-F692-4f8a-9E42-B07980F04FBB}";
  internal const string EditOtherInformation = "{CF3C09E2-1F42-481e-A977-AE8B157B6C1A}";
  internal const string ReplaceInactiveUser = "{57AE819E-03F0-48d6-93CB-B5451E6D186F}";
  internal const string AccessInsuredViewingRights = "{0BC4F32D-9489-4373-B358-B9E16EFA5883}";
  internal const string AccessQuotingOfficeViewingRights = "{87BEE935-5205-427f-9630-9C342E4ABE7E}";
  internal const string AccessProducerLocationViewingRights = "{305A65F9-B018-4c54-990D-F39BF27E4203}";
  internal const string AccessIssuingOfficeViewingRights = "{13227AB4-1F29-40E2-94BA-F94AFE8CB885}";
  internal const string AccessPolicyViewingRights = "{48A04113-3012-4237-9CCF-C5EB1EBB2F32}";
  internal const string AccessFeeRestrictionViewingRights = "{0B269EA5-EED3-4491-80B3-891DB35171EF}";
  internal const string AllowSavingUserInfo = "{8021181D-4F53-4478-B390-6887E8C2EB54}";
  internal const string AllowDeletionUserInfo = "{CA58AA4C-B044-4AE2-A791-DF2755472442}";
  private Guid _userGuid;
  private Guid _officeGuid;
  private bool _newUserOnLoad;
  private frmUsers_BindingManagement _bindings;
  private bool _newUser;
  private bool _canEditOtherUsersInfo;
  private bool _initialized;
  private Guid _currentUserGuid;
  private string _strUserNameFirstLastName;
  private bool _allowSaveSecurity;
  private bool _allowDeleteSecurity;
  private List<TreeNode> RootNodes;

  [field: AccessedThroughProperty("lblUserName")]
  protected virtual Label lblUserName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblTitle")]
  protected virtual Label lblTitle { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblPassword")]
  protected virtual Label lblPassword { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtPassword")]
  protected virtual MGATextBox txtPassword { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtTitle")]
  protected virtual MGATextBox txtTitle { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtUserName")]
  protected virtual MGATextBox txtUserName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtInitials")]
  protected virtual MGATextBox txtInitials { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label2")]
  protected virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtEmail")]
  protected virtual MGATextBox txtEmail { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblPhone")]
  protected virtual Label lblPhone { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblForeignPhone")]
  protected virtual Label lblForeignPhone { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label6")]
  protected virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("daUsers")]
  protected virtual SqlDataAdapter daUsers { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dsUser")]
  protected virtual dsUser dsUser { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cbOffices")]
  protected virtual MGASimpleComboBox cbOffices { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual MGAButton btnClientLoc
  {
    get => this._btnClientLoc;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnClientLoc_Click);
      MGAButton btnClientLoc1 = this._btnClientLoc;
      if (btnClientLoc1 != null)
        ((Control) btnClientLoc1).Click -= eventHandler;
      this._btnClientLoc = value;
      MGAButton btnClientLoc2 = this._btnClientLoc;
      if (btnClientLoc2 == null)
        return;
      ((Control) btnClientLoc2).Click += eventHandler;
    }
  }

  protected virtual TreeView tvUsers
  {
    get => this._tvUsers;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      TreeViewEventHandler viewEventHandler = new TreeViewEventHandler(this.tvUsers_AfterSelect);
      EventHandler eventHandler1 = new EventHandler(this.tvUsers_EnabledChanged);
      EventHandler eventHandler2 = new EventHandler(this.tvUsers_Click);
      TreeView tvUsers1 = this._tvUsers;
      if (tvUsers1 != null)
      {
        tvUsers1.AfterSelect -= viewEventHandler;
        tvUsers1.EnabledChanged -= eventHandler1;
        tvUsers1.Click -= eventHandler2;
      }
      this._tvUsers = value;
      TreeView tvUsers2 = this._tvUsers;
      if (tvUsers2 == null)
        return;
      tvUsers2.AfterSelect += viewEventHandler;
      tvUsers2.EnabledChanged += eventHandler1;
      tvUsers2.Click += eventHandler2;
    }
  }

  [field: AccessedThroughProperty("txtFirst")]
  protected virtual MGATextBox txtFirst { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label15")]
  protected virtual Label Label15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtLast")]
  protected virtual MGATextBox txtLast { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label16")]
  protected virtual Label Label16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label3")]
  protected virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblOffice")]
  protected virtual UltraLabel lblOffice { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label4")]
  protected virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cbStatus")]
  protected virtual MGASimpleComboBox cbStatus { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label5")]
  protected virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboManagedby")]
  protected virtual MGASimpleComboBox cboManagedby { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label17")]
  protected virtual Label Label17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ZipCodeResolver1")]
  protected virtual MGA_ZipCodeResolver ZipCodeResolver1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual UltraToolbarsManager UltraToolbarsManager1
  {
    get => this._UltraToolbarsManager1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      ToolClickEventHandler clickEventHandler = new ToolClickEventHandler(this.UltraToolbarsManager1_ToolClick);
      UltraToolbarsManager toolbarsManager1_1 = this._UltraToolbarsManager1;
      if (toolbarsManager1_1 != null)
        toolbarsManager1_1.ToolClick -= clickEventHandler;
      this._UltraToolbarsManager1 = value;
      UltraToolbarsManager toolbarsManager1_2 = this._UltraToolbarsManager1;
      if (toolbarsManager1_2 == null)
        return;
      toolbarsManager1_2.ToolClick += clickEventHandler;
    }
  }

  [field: AccessedThroughProperty("txtPhone")]
  protected virtual MGAMaskedEdit txtPhone { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtForeignPhone")]
  protected virtual MGATextBox txtForeignPhone { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtCellPhone")]
  protected virtual MGAMaskedEdit txtCellPhone { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("err")]
  protected virtual ErrorProvider err { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("gbUsers")]
  protected virtual UltraGroupBox gbUsers { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtFax")]
  protected virtual MGAMaskedEdit txtFax { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  protected virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkLoggedIn")]
  protected virtual MGACheckBox chkLoggedIn { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label7")]
  protected virtual Label Label7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label8")]
  protected virtual Label Label8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label9")]
  protected virtual Label Label9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkComm")]
  protected virtual MGACheckBox chkComm { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtSSN")]
  protected virtual MGAMaskedEdit txtSSN { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraTabControl1")]
  protected virtual UltraTabControl UltraTabControl1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraTabSharedControlsPage1")]
  protected virtual UltraTabSharedControlsPage UltraTabSharedControlsPage1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraTabPageControl1")]
  protected virtual UltraTabPageControl UltraTabPageControl1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraTabPageControl2")]
  protected virtual UltraTabPageControl UltraTabPageControl2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraTabPageControl3")]
  protected virtual UltraTabPageControl UltraTabPageControl3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraTabPageControl4")]
  protected virtual UltraTabPageControl UltraTabPageControl4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SignatureCapturePanel1")]
  protected virtual SignatureCapturePanel SignatureCapturePanel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual MGASystems.Tools.DBSaveUI.DBSaveUI DbSaveUI1
  {
    get => this._DbSaveUI1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.DbSaveUI1_ClickedSave);
      CancelEventHandler cancelEventHandler1 = new CancelEventHandler(this.DbSaveUI1_ClickingEdit);
      CancelEventHandler cancelEventHandler2 = new CancelEventHandler(this.DbSaveUI1_ClickingSave);
      CancelEventHandler cancelEventHandler3 = new CancelEventHandler(this.DbSaveUI1_ClickingNew);
      CancelEventHandler cancelEventHandler4 = new CancelEventHandler(this.DbSaveUI1_ClickingCancel);
      CancelEventHandler cancelEventHandler5 = new CancelEventHandler(this.DbSaveUI1_ClickingDelete);
      EventHandler eventHandler2 = new EventHandler(this.DbSaveUI1_UIStateChanged);
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSaveUi1_1 = this._DbSaveUI1;
      if (dbSaveUi1_1 != null)
      {
        dbSaveUi1_1.ClickedSave -= eventHandler1;
        dbSaveUi1_1.ClickingEdit -= cancelEventHandler1;
        dbSaveUi1_1.ClickingSave -= cancelEventHandler2;
        dbSaveUi1_1.ClickingNew -= cancelEventHandler3;
        dbSaveUi1_1.ClickingCancel -= cancelEventHandler4;
        dbSaveUi1_1.ClickingDelete -= cancelEventHandler5;
        dbSaveUi1_1.UIStateChanged -= eventHandler2;
      }
      this._DbSaveUI1 = value;
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSaveUi1_2 = this._DbSaveUI1;
      if (dbSaveUi1_2 == null)
        return;
      dbSaveUi1_2.ClickedSave += eventHandler1;
      dbSaveUi1_2.ClickingEdit += cancelEventHandler1;
      dbSaveUi1_2.ClickingSave += cancelEventHandler2;
      dbSaveUi1_2.ClickingNew += cancelEventHandler3;
      dbSaveUi1_2.ClickingCancel += cancelEventHandler4;
      dbSaveUi1_2.ClickingDelete += cancelEventHandler5;
      dbSaveUi1_2.UIStateChanged += eventHandler2;
    }
  }

  [field: AccessedThroughProperty("treeImages")]
  protected virtual ImageList treeImages { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual ContextMenu ctxSecurity
  {
    get => this._ctxSecurity;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ctxSecurity_Popup);
      ContextMenu ctxSecurity1 = this._ctxSecurity;
      if (ctxSecurity1 != null)
        ctxSecurity1.Popup -= eventHandler;
      this._ctxSecurity = value;
      ContextMenu ctxSecurity2 = this._ctxSecurity;
      if (ctxSecurity2 == null)
        return;
      ctxSecurity2.Popup += eventHandler;
    }
  }

  [field: AccessedThroughProperty("SqlSelectCommand1")]
  protected virtual SqlCommand SqlSelectCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlInsertCommand1")]
  protected virtual SqlCommand SqlInsertCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlUpdateCommand1")]
  protected virtual SqlCommand SqlUpdateCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlDeleteCommand1")]
  protected virtual SqlCommand SqlDeleteCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual LinkLabel lnkEditEmailServerInfo
  {
    get => this._lnkEditEmailServerInfo;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.lnkEditEmailServerInfo_Click);
      LinkLabel editEmailServerInfo1 = this._lnkEditEmailServerInfo;
      if (editEmailServerInfo1 != null)
        editEmailServerInfo1.Click -= eventHandler;
      this._lnkEditEmailServerInfo = value;
      LinkLabel editEmailServerInfo2 = this._lnkEditEmailServerInfo;
      if (editEmailServerInfo2 == null)
        return;
      editEmailServerInfo2.Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("dvManagers")]
  protected virtual DataView dvManagers { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("udEnd")]
  protected virtual MGANumericEditor udEnd { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label10")]
  protected virtual Label Label10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkAllowMultipleLogins")]
  protected virtual MGACheckBox chkAllowMultipleLogins { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmUsers));
    Appearance appearance21 = new Appearance();
    Appearance appearance22 = new Appearance();
    Appearance appearance23 = new Appearance();
    UltraToolbar ultraToolbar = new UltraToolbar("MainMenu");
    PopupMenuTool popupMenuTool1 = new PopupMenuTool("Users");
    PopupMenuTool popupMenuTool2 = new PopupMenuTool("Users");
    ButtonTool buttonTool1 = new ButtonTool("Licenses");
    ButtonTool buttonTool2 = new ButtonTool("Lines");
    ButtonTool buttonTool3 = new ButtonTool("Assign Producer Contacts");
    ButtonTool buttonTool4 = new ButtonTool("Viewing Rights");
    ButtonTool buttonTool5 = new ButtonTool("User Types");
    ButtonTool buttonTool6 = new ButtonTool("Company Viewing Rights");
    ButtonTool buttonTool7 = new ButtonTool("Insured Viewing Rights");
    ButtonTool buttonTool8 = new ButtonTool("Quoting Office Viewing Rights");
    ButtonTool buttonTool9 = new ButtonTool("Producer Location View Rights ...");
    ButtonTool buttonTool10 = new ButtonTool("Issuing Office Viewing Rights");
    ButtonTool buttonTool11 = new ButtonTool("Policy Viewing Rights");
    ButtonTool buttonTool12 = new ButtonTool("User Goals");
    ButtonTool buttonTool13 = new ButtonTool("Fee Viewing Rights");
    ButtonTool buttonTool14 = new ButtonTool("Licenses");
    ButtonTool buttonTool15 = new ButtonTool("Lines");
    ButtonTool buttonTool16 = new ButtonTool("Assign Producer Contacts");
    ButtonTool buttonTool17 = new ButtonTool("Viewing Rights");
    ButtonTool buttonTool18 = new ButtonTool("User Types");
    ButtonTool buttonTool19 = new ButtonTool("Company Viewing Rights");
    ButtonTool buttonTool20 = new ButtonTool("Insured Viewing Rights");
    ButtonTool buttonTool21 = new ButtonTool("Quoting Office Viewing Rights");
    Appearance appearance24 = new Appearance();
    ButtonTool buttonTool22 = new ButtonTool("Producer Location View Rights ...");
    Appearance appearance25 = new Appearance();
    ButtonTool buttonTool23 = new ButtonTool("Issuing Office Viewing Rights");
    Appearance appearance26 = new Appearance();
    ButtonTool buttonTool24 = new ButtonTool("Policy Viewing Rights");
    Appearance appearance27 = new Appearance();
    ButtonTool buttonTool25 = new ButtonTool("User Goals");
    Appearance appearance28 = new Appearance();
    ButtonTool buttonTool26 = new ButtonTool("Fee Viewing Rights");
    Appearance appearance29 = new Appearance();
    UltraTab ultraTab1 = new UltraTab();
    Appearance appearance30 = new Appearance();
    UltraTab ultraTab2 = new UltraTab();
    Appearance appearance31 = new Appearance();
    UltraTab ultraTab3 = new UltraTab();
    Appearance appearance32 = new Appearance();
    UltraTab ultraTab4 = new UltraTab();
    Appearance appearance33 = new Appearance();
    Appearance appearance34 = new Appearance();
    this.UltraTabPageControl3 = new UltraTabPageControl();
    this.Label13 = new Label();
    this.txtEmployeeNum = new MGATextBox();
    this.dsUser = new dsUser();
    this.MgaCheckBox1 = new MGACheckBox();
    this.chkAllowMultipleLogins = new MGACheckBox();
    this.lblTitle = new Label();
    this.txtUserName = new MGATextBox();
    this.txtTitle = new MGATextBox();
    this.txtPassword = new MGATextBox();
    this.lblPassword = new Label();
    this.cbOffices = new MGASimpleComboBox();
    this.btnClientLoc = new MGAButton();
    this.Label15 = new Label();
    this.txtFirst = new MGATextBox();
    this.Label16 = new Label();
    this.txtLast = new MGATextBox();
    this.Label3 = new Label();
    this.cbStatus = new MGASimpleComboBox();
    this.Label4 = new Label();
    this.cboManagedby = new MGASimpleComboBox();
    this.dvManagers = new DataView();
    this.Label5 = new Label();
    this.chkLoggedIn = new MGACheckBox();
    this.Label7 = new Label();
    this.Label8 = new Label();
    this.chkComm = new MGACheckBox();
    this.Label9 = new Label();
    this.lblUserName = new Label();
    this.Label17 = new Label();
    this.txtInitials = new MGATextBox();
    this.txtSSN = new MGAMaskedEdit();
    this.UltraTabPageControl1 = new UltraTabPageControl();
    this.ZipCodeResolver1 = new MGA_ZipCodeResolver();
    this.UltraTabPageControl2 = new UltraTabPageControl();
    this.txtPhoneExtension = new MGATextBox();
    this.Label12 = new Label();
    this.cboUnderwritingTeam = new MGASimpleComboBox();
    this.txtHomeEmailAddress = new MGATextBox();
    this.LblHomeEmailAddress = new Label();
    this.Label10 = new Label();
    this.udEnd = new MGANumericEditor();
    this.lnkEditEmailServerInfo = new LinkLabel();
    this.txtFax = new MGAMaskedEdit();
    this.Label1 = new Label();
    this.txtCellPhone = new MGAMaskedEdit();
    this.txtPhone = new MGAMaskedEdit();
    this.txtForeignPhone = new MGATextBox();
    this.Label2 = new Label();
    this.lblPhone = new Label();
    this.lblForeignPhone = new Label();
    this.txtEmail = new MGATextBox();
    this.Label6 = new Label();
    this.UltraTabPageControl4 = new UltraTabPageControl();
    this.SignatureCapturePanel1 = new SignatureCapturePanel();
    this.DbSaveUI1 = new MGASystems.Tools.DBSaveUI.DBSaveUI();
    this.daUsers = new SqlDataAdapter();
    this.SqlDeleteCommand1 = new SqlCommand();
    this.SqlInsertCommand1 = new SqlCommand();
    this.SqlSelectCommand1 = new SqlCommand();
    this.SqlUpdateCommand1 = new SqlCommand();
    this.tvUsers = new TreeView();
    this.ctxSecurity = new ContextMenu();
    this.treeImages = new ImageList(this.components);
    this.gbUsers = new UltraGroupBox();
    this.pnlFilter = new Panel();
    this.txtFilter = new TextBox();
    this.pnlFilterIcon = new Panel();
    this.lblOffice = new UltraLabel();
    this.UltraToolbarsManager1 = new UltraToolbarsManager(this.components);
    this._frmUsers_Toolbars_Dock_Area_Left = new UltraToolbarsDockArea();
    this._frmUsers_Toolbars_Dock_Area_Right = new UltraToolbarsDockArea();
    this._frmUsers_Toolbars_Dock_Area_Top = new UltraToolbarsDockArea();
    this._frmUsers_Toolbars_Dock_Area_Bottom = new UltraToolbarsDockArea();
    this.err = new ErrorProvider(this.components);
    this.UltraTabControl1 = new UltraTabControl();
    this.UltraTabSharedControlsPage1 = new UltraTabSharedControlsPage();
    this.chkHideInactive = new MGACheckBox();
    this.ToolTip1 = new ToolTip(this.components);
    ((Control) this.UltraTabPageControl3).SuspendLayout();
    ((ISupportInitialize) this.txtEmployeeNum).BeginInit();
    this.dsUser.BeginInit();
    ((ISupportInitialize) this.MgaCheckBox1).BeginInit();
    ((ISupportInitialize) this.chkAllowMultipleLogins).BeginInit();
    ((ISupportInitialize) this.txtUserName).BeginInit();
    ((ISupportInitialize) this.txtTitle).BeginInit();
    ((ISupportInitialize) this.txtPassword).BeginInit();
    ((ISupportInitialize) this.cbOffices).BeginInit();
    ((ISupportInitialize) this.btnClientLoc).BeginInit();
    ((ISupportInitialize) this.txtFirst).BeginInit();
    ((ISupportInitialize) this.txtLast).BeginInit();
    ((ISupportInitialize) this.cbStatus).BeginInit();
    ((ISupportInitialize) this.cboManagedby).BeginInit();
    this.dvManagers.BeginInit();
    ((ISupportInitialize) this.chkLoggedIn).BeginInit();
    ((ISupportInitialize) this.chkComm).BeginInit();
    ((ISupportInitialize) this.txtInitials).BeginInit();
    ((ISupportInitialize) this.txtSSN).BeginInit();
    ((Control) this.UltraTabPageControl1).SuspendLayout();
    ((Control) this.UltraTabPageControl2).SuspendLayout();
    ((ISupportInitialize) this.txtPhoneExtension).BeginInit();
    ((ISupportInitialize) this.cboUnderwritingTeam).BeginInit();
    ((ISupportInitialize) this.txtHomeEmailAddress).BeginInit();
    ((ISupportInitialize) this.udEnd).BeginInit();
    ((ISupportInitialize) this.txtFax).BeginInit();
    ((ISupportInitialize) this.txtCellPhone).BeginInit();
    ((ISupportInitialize) this.txtPhone).BeginInit();
    ((ISupportInitialize) this.txtForeignPhone).BeginInit();
    ((ISupportInitialize) this.txtEmail).BeginInit();
    ((Control) this.UltraTabPageControl4).SuspendLayout();
    ((ISupportInitialize) this.gbUsers).BeginInit();
    ((Control) this.gbUsers).SuspendLayout();
    this.pnlFilter.SuspendLayout();
    ((ISupportInitialize) this.UltraToolbarsManager1).BeginInit();
    ((ISupportInitialize) this.err).BeginInit();
    ((ISupportInitialize) this.UltraTabControl1).BeginInit();
    ((Control) this.UltraTabControl1).SuspendLayout();
    ((ISupportInitialize) this.chkHideInactive).BeginInit();
    this.SuspendLayout();
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.Label13);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.txtEmployeeNum);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.MgaCheckBox1);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.chkAllowMultipleLogins);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.lblTitle);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.txtUserName);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.txtTitle);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.txtPassword);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.lblPassword);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.cbOffices);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.btnClientLoc);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.Label15);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.txtFirst);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.Label16);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.txtLast);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.Label3);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.cbStatus);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.Label4);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.cboManagedby);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.Label5);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.chkLoggedIn);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.Label7);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.Label8);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.chkComm);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.Label9);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.lblUserName);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.Label17);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.txtInitials);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.txtSSN);
    ((Control) this.UltraTabPageControl3).Location = new Point(1, 26);
    ((Control) this.UltraTabPageControl3).Name = "UltraTabPageControl3";
    ((Control) this.UltraTabPageControl3).Size = new Size(374, 413);
    this.Label13.AutoSize = true;
    this.Label13.BackColor = Color.Transparent;
    this.Label13.Location = new Point(12, 239);
    this.Label13.Name = "Label13";
    this.Label13.Size = new Size(68, 13);
    this.Label13.TabIndex = 28;
    this.Label13.Text = "Employee #:";
    this.Label13.TextAlign = ContentAlignment.MiddleRight;
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance1.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtEmployeeNum).Appearance = (AppearanceBase) appearance1;
    ((TextEditorControlBase) this.txtEmployeeNum).BackColor = Color.White;
    ((Control) this.txtEmployeeNum).DataBindings.Add(new Binding("Text", (object) this.dsUser, "tblUsers.EmployeeNumber", true));
    ((Control) this.txtEmployeeNum).Location = new Point(88, 235);
    ((TextEditorControlBase) this.txtEmployeeNum).MaxLength = 10;
    this.txtEmployeeNum.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtEmployeeNum).Name = "txtEmployeeNum";
    ((Control) this.txtEmployeeNum).Size = new Size(91, 20);
    ((Control) this.txtEmployeeNum).TabIndex = 27;
    ((UltraControlBase) this.txtEmployeeNum).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtEmployeeNum).UseOsThemes = (DefaultableBoolean) 2;
    this.dsUser.DataSetName = "dsUser";
    this.dsUser.Locale = new CultureInfo("en-US");
    this.dsUser.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    appearance2.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance2.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.MgaCheckBox1).Appearance = (AppearanceBase) appearance2;
    ((UltraToggleEditorBase) this.MgaCheckBox1).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.MgaCheckBox1).BackColorInternal = Color.Transparent;
    ((Control) this.MgaCheckBox1).DataBindings.Add(new Binding("Checked", (object) this.dsUser, "tblUsers.RequirePasswordResetOnNextLogin", true));
    ((UltraToggleEditorBase) this.MgaCheckBox1).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.MgaCheckBox1).Location = new Point(174, 310);
    this.MgaCheckBox1.MGAStyle = MGAStyles.Blue;
    ((Control) this.MgaCheckBox1).Name = "MgaCheckBox1";
    ((Control) this.MgaCheckBox1).Size = new Size(205, 20);
    ((Control) this.MgaCheckBox1).TabIndex = 26;
    ((UltraToggleEditorBase) this.MgaCheckBox1).Text = "Change password on next login";
    ((UltraControlBase) this.MgaCheckBox1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaCheckBox1).UseOsThemes = (DefaultableBoolean) 2;
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance3.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkAllowMultipleLogins).Appearance = (AppearanceBase) appearance3;
    ((UltraToggleEditorBase) this.chkAllowMultipleLogins).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkAllowMultipleLogins).BackColorInternal = Color.Transparent;
    ((Control) this.chkAllowMultipleLogins).DataBindings.Add(new Binding("Checked", (object) this.dsUser, "tblUsers.AllowSimultaneousLogins", true));
    ((UltraToggleEditorBase) this.chkAllowMultipleLogins).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkAllowMultipleLogins).Location = new Point(88, 336);
    this.chkAllowMultipleLogins.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkAllowMultipleLogins).Name = "chkAllowMultipleLogins";
    ((Control) this.chkAllowMultipleLogins).Size = new Size(272, 20);
    ((Control) this.chkAllowMultipleLogins).TabIndex = 25;
    ((UltraToggleEditorBase) this.chkAllowMultipleLogins).Text = "Allow simultaneous logins from different machines";
    ((UltraControlBase) this.chkAllowMultipleLogins).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkAllowMultipleLogins).UseOsThemes = (DefaultableBoolean) 2;
    this.lblTitle.AutoSize = true;
    this.lblTitle.BackColor = Color.Transparent;
    this.lblTitle.Location = new Point(51, 92);
    this.lblTitle.Name = "lblTitle";
    this.lblTitle.Size = new Size(31 /*0x1F*/, 13);
    this.lblTitle.TabIndex = 6;
    this.lblTitle.Text = "Title:";
    this.lblTitle.TextAlign = ContentAlignment.MiddleRight;
    appearance4.BackColor = Color.White;
    appearance4.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance4.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtUserName).Appearance = (AppearanceBase) appearance4;
    ((TextEditorControlBase) this.txtUserName).BackColor = Color.White;
    ((Control) this.txtUserName).DataBindings.Add(new Binding("Text", (object) this.dsUser, "tblUsers.UserName", true));
    ((Control) this.txtUserName).Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.txtUserName).Location = new Point(88, 112 /*0x70*/);
    ((TextEditorControlBase) this.txtUserName).MaxLength = 50;
    this.txtUserName.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtUserName).Name = "txtUserName";
    ((Control) this.txtUserName).Size = new Size(91, 20);
    ((Control) this.txtUserName).TabIndex = 9;
    ((UltraControlBase) this.txtUserName).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtUserName).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.txtTitle).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    appearance5.BackColor = Color.White;
    appearance5.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance5.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtTitle).Appearance = (AppearanceBase) appearance5;
    ((TextEditorControlBase) this.txtTitle).BackColor = Color.White;
    ((Control) this.txtTitle).DataBindings.Add(new Binding("Text", (object) this.dsUser, "tblUsers.Title", true));
    ((Control) this.txtTitle).Location = new Point(88, 88);
    ((Control) this.txtTitle).MaximumSize = new Size(400, 21);
    ((TextEditorControlBase) this.txtTitle).MaxLength = 100;
    this.txtTitle.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtTitle).Name = "txtTitle";
    ((Control) this.txtTitle).Size = new Size(126, 20);
    ((Control) this.txtTitle).TabIndex = 7;
    ((UltraControlBase) this.txtTitle).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtTitle).UseOsThemes = (DefaultableBoolean) 2;
    appearance6.BackColor = Color.White;
    appearance6.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance6.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtPassword).Appearance = (AppearanceBase) appearance6;
    ((TextEditorControlBase) this.txtPassword).BackColor = Color.White;
    ((Control) this.txtPassword).DataBindings.Add(new Binding("Text", (object) this.dsUser, "tblUsers.Password", true));
    ((Control) this.txtPassword).Location = new Point(88, 136);
    ((TextEditorControlBase) this.txtPassword).MaxLength = 60;
    this.txtPassword.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtPassword).Name = "txtPassword";
    this.txtPassword.PasswordChar = '*';
    ((Control) this.txtPassword).Size = new Size(91, 20);
    ((Control) this.txtPassword).TabIndex = 11;
    ((UltraControlBase) this.txtPassword).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtPassword).UseOsThemes = (DefaultableBoolean) 2;
    this.lblPassword.AutoSize = true;
    this.lblPassword.BackColor = Color.Transparent;
    this.lblPassword.Location = new Point(23, 140);
    this.lblPassword.Name = "lblPassword";
    this.lblPassword.Size = new Size(57, 13);
    this.lblPassword.TabIndex = 10;
    this.lblPassword.Text = "Password:";
    this.lblPassword.TextAlign = ContentAlignment.MiddleRight;
    ((Control) this.cbOffices).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.cbOffices.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cbOffices).DataBindings.Add(new Binding("Value", (object) this.dsUser, "tblUsers.OfficeGUID", true));
    ((UltraGridBase) this.cbOffices).DataSource = (object) this.dsUser.tblClientOffices;
    ((UltraDropDownBase) this.cbOffices).DisplayMember = "Location";
    this.cbOffices.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cbOffices).Location = new Point(88, 160 /*0xA0*/);
    this.cbOffices.MGAStyle = MGAStyles.Blue;
    ((Control) this.cbOffices).Name = "cbOffices";
    ((Control) this.cbOffices).Size = new Size(130, 21);
    ((Control) this.cbOffices).TabIndex = 13;
    ((UltraControlBase) this.cbOffices).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cbOffices).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cbOffices).ValueMember = "OfficeGuid";
    ((Control) this.btnClientLoc).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    appearance7.BackColor = Color.FromArgb(248, 248, 248);
    appearance7.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance7.BackGradientStyle = (GradientStyle) 2;
    appearance7.BorderColor = Color.DarkGray;
    appearance7.ImageHAlign = (HAlign) 2;
    appearance7.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnClientLoc).Appearance = (AppearanceBase) appearance7;
    ((Control) this.btnClientLoc).Location = new Point(223, 160 /*0xA0*/);
    ((Control) this.btnClientLoc).Name = "btnClientLoc";
    ((Control) this.btnClientLoc).Size = new Size(24, 21);
    ((Control) this.btnClientLoc).TabIndex = 14;
    ((ControlBase) this.btnClientLoc).Text = "...";
    this.btnClientLoc.UseOSThemes = (DefaultableBoolean) 2;
    this.Label15.AutoSize = true;
    this.Label15.BackColor = Color.Transparent;
    this.Label15.Location = new Point(48 /*0x30*/, 19);
    this.Label15.Name = "Label15";
    this.Label15.Size = new Size(32 /*0x20*/, 13);
    this.Label15.TabIndex = 0;
    this.Label15.Text = "First:";
    this.Label15.TextAlign = ContentAlignment.MiddleRight;
    ((Control) this.txtFirst).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    appearance8.BackColor = Color.White;
    appearance8.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance8.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtFirst).Appearance = (AppearanceBase) appearance8;
    ((TextEditorControlBase) this.txtFirst).BackColor = Color.White;
    ((Control) this.txtFirst).DataBindings.Add(new Binding("Text", (object) this.dsUser, "tblUsers.FirstName", true));
    ((Control) this.txtFirst).Location = new Point(88, 16 /*0x10*/);
    ((Control) this.txtFirst).MaximumSize = new Size(400, 21);
    ((TextEditorControlBase) this.txtFirst).MaxLength = 100;
    this.txtFirst.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtFirst).Name = "txtFirst";
    ((Control) this.txtFirst).Size = new Size(126, 20);
    ((Control) this.txtFirst).TabIndex = 1;
    ((UltraControlBase) this.txtFirst).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtFirst).UseOsThemes = (DefaultableBoolean) 2;
    this.Label16.AutoSize = true;
    this.Label16.BackColor = Color.Transparent;
    this.Label16.Location = new Point(48 /*0x30*/, 44);
    this.Label16.Name = "Label16";
    this.Label16.Size = new Size(31 /*0x1F*/, 13);
    this.Label16.TabIndex = 2;
    this.Label16.Text = "Last:";
    this.Label16.TextAlign = ContentAlignment.MiddleRight;
    ((Control) this.txtLast).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    appearance9.BackColor = Color.White;
    appearance9.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance9.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtLast).Appearance = (AppearanceBase) appearance9;
    ((TextEditorControlBase) this.txtLast).BackColor = Color.White;
    ((Control) this.txtLast).DataBindings.Add(new Binding("Text", (object) this.dsUser, "tblUsers.LastName", true));
    ((Control) this.txtLast).Location = new Point(88, 40);
    ((Control) this.txtLast).MaximumSize = new Size(400, 21);
    ((TextEditorControlBase) this.txtLast).MaxLength = 100;
    this.txtLast.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtLast).Name = "txtLast";
    ((Control) this.txtLast).Size = new Size(126, 20);
    ((Control) this.txtLast).TabIndex = 3;
    ((UltraControlBase) this.txtLast).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtLast).UseOsThemes = (DefaultableBoolean) 2;
    this.Label3.AutoSize = true;
    this.Label3.BackColor = Color.Transparent;
    this.Label3.Location = new Point(38, 67);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(42, 13);
    this.Label3.TabIndex = 4;
    this.Label3.Text = "Initials:";
    this.Label3.TextAlign = ContentAlignment.MiddleRight;
    ((Control) this.cbStatus).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.cbStatus.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cbStatus).DataBindings.Add(new Binding("Value", (object) this.dsUser, "tblUsers.StatusID", true));
    ((UltraGridBase) this.cbStatus).DataSource = (object) this.dsUser.lstStatus;
    ((UltraDropDownBase) this.cbStatus).DisplayMember = "Status";
    this.cbStatus.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cbStatus).Location = new Point(88, 210);
    ((Control) this.cbStatus).MaximumSize = new Size(400, 21);
    this.cbStatus.MGAStyle = MGAStyles.Blue;
    ((Control) this.cbStatus).Name = "cbStatus";
    ((Control) this.cbStatus).Size = new Size(130, 21);
    ((Control) this.cbStatus).TabIndex = 18;
    ((UltraControlBase) this.cbStatus).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cbStatus).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cbStatus).ValueMember = "StatusID";
    this.Label4.AutoSize = true;
    this.Label4.BackColor = Color.Transparent;
    this.Label4.Location = new Point(41, 214);
    this.Label4.Name = "Label4";
    this.Label4.Size = new Size(42, 13);
    this.Label4.TabIndex = 17;
    this.Label4.Text = "Status:";
    this.Label4.TextAlign = ContentAlignment.MiddleRight;
    ((Control) this.cboManagedby).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.cboManagedby.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboManagedby).DataBindings.Add(new Binding("Value", (object) this.dsUser, "tblUsers.UserManagerGUID", true));
    ((UltraGridBase) this.cboManagedby).DataSource = (object) this.dvManagers;
    ((UltraDropDownBase) this.cboManagedby).DisplayMember = "Name";
    this.cboManagedby.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboManagedby).Location = new Point(88, 185);
    ((Control) this.cboManagedby).MaximumSize = new Size(400, 21);
    this.cboManagedby.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboManagedby).Name = "cboManagedby";
    ((Control) this.cboManagedby).Size = new Size(130, 21);
    ((Control) this.cboManagedby).TabIndex = 16 /*0x10*/;
    ((UltraControlBase) this.cboManagedby).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboManagedby).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboManagedby).ValueMember = "UserGuid";
    this.Label5.AutoSize = true;
    this.Label5.BackColor = Color.Transparent;
    this.Label5.Location = new Point(10, 193);
    this.Label5.Name = "Label5";
    this.Label5.Size = new Size(70, 13);
    this.Label5.TabIndex = 15;
    this.Label5.Text = "Managed By:";
    this.Label5.TextAlign = ContentAlignment.MiddleRight;
    appearance10.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance10.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkLoggedIn).Appearance = (AppearanceBase) appearance10;
    ((UltraToggleEditorBase) this.chkLoggedIn).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkLoggedIn).BackColorInternal = Color.Transparent;
    ((Control) this.chkLoggedIn).DataBindings.Add(new Binding("Checked", (object) this.dsUser, "tblUsers.LoggedIn", true));
    ((UltraToggleEditorBase) this.chkLoggedIn).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkLoggedIn).Location = new Point(88, 312);
    this.chkLoggedIn.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkLoggedIn).Name = "chkLoggedIn";
    ((Control) this.chkLoggedIn).Size = new Size(80 /*0x50*/, 20);
    ((Control) this.chkLoggedIn).TabIndex = 22;
    ((UltraToggleEditorBase) this.chkLoggedIn).Text = "Logged In";
    ((UltraControlBase) this.chkLoggedIn).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkLoggedIn).UseOsThemes = (DefaultableBoolean) 2;
    this.Label7.AutoSize = true;
    this.Label7.BackColor = Color.Transparent;
    this.Label7.Location = new Point(21, 362);
    this.Label7.Name = "Label7";
    this.Label7.Size = new Size(59, 13);
    this.Label7.TabIndex = 23;
    this.Label7.Text = "Last Login:";
    this.Label7.TextAlign = ContentAlignment.MiddleRight;
    this.Label8.BackColor = Color.Transparent;
    this.Label8.DataBindings.Add(new Binding("Text", (object) this.dsUser, "tblUsers.LastLogin", true));
    this.Label8.Location = new Point(85, 360);
    this.Label8.Name = "Label8";
    this.Label8.Size = new Size(184, 17);
    this.Label8.TabIndex = 24;
    this.Label8.TextAlign = ContentAlignment.MiddleLeft;
    appearance11.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance11.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkComm).Appearance = (AppearanceBase) appearance11;
    ((UltraToggleEditorBase) this.chkComm).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkComm).BackColorInternal = Color.Transparent;
    ((Control) this.chkComm).DataBindings.Add(new Binding("Checked", (object) this.dsUser, "tblUsers.CommissionsFromOperatingAccount", true));
    ((UltraToggleEditorBase) this.chkComm).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkComm).Location = new Point(88, 259);
    this.chkComm.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkComm).Name = "chkComm";
    ((Control) this.chkComm).Size = new Size(216, 24);
    ((Control) this.chkComm).TabIndex = 19;
    ((UltraToggleEditorBase) this.chkComm).Text = "Commissions out of operating account";
    ((UltraControlBase) this.chkComm).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkComm).UseOsThemes = (DefaultableBoolean) 2;
    this.Label9.AutoSize = true;
    this.Label9.BackColor = Color.Transparent;
    this.Label9.Location = new Point(50, 291);
    this.Label9.Name = "Label9";
    this.Label9.Size = new Size(30, 13);
    this.Label9.TabIndex = 20;
    this.Label9.Text = "SSN:";
    this.Label9.TextAlign = ContentAlignment.MiddleRight;
    this.lblUserName.AutoSize = true;
    this.lblUserName.BackColor = Color.Transparent;
    this.lblUserName.Location = new Point(17, 116);
    this.lblUserName.Name = "lblUserName";
    this.lblUserName.Size = new Size(63 /*0x3F*/, 13);
    this.lblUserName.TabIndex = 8;
    this.lblUserName.Text = "User Name:";
    this.lblUserName.TextAlign = ContentAlignment.MiddleRight;
    this.Label17.AutoSize = true;
    this.Label17.BackColor = Color.Transparent;
    this.Label17.Location = new Point(43, 164);
    this.Label17.Name = "Label17";
    this.Label17.Size = new Size(40, 13);
    this.Label17.TabIndex = 12;
    this.Label17.Text = "Office:";
    this.Label17.TextAlign = ContentAlignment.MiddleRight;
    appearance12.BackColor = Color.White;
    appearance12.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance12.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtInitials).Appearance = (AppearanceBase) appearance12;
    ((TextEditorControlBase) this.txtInitials).BackColor = Color.White;
    ((Control) this.txtInitials).DataBindings.Add(new Binding("Text", (object) this.dsUser, "tblUsers.Initials", true));
    ((Control) this.txtInitials).Location = new Point(88, 64 /*0x40*/);
    ((TextEditorControlBase) this.txtInitials).MaxLength = 3;
    this.txtInitials.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtInitials).Name = "txtInitials";
    ((Control) this.txtInitials).Size = new Size(32 /*0x20*/, 20);
    ((Control) this.txtInitials).TabIndex = 5;
    ((UltraControlBase) this.txtInitials).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtInitials).UseOsThemes = (DefaultableBoolean) 2;
    appearance13.BorderColor = Color.Gray;
    this.txtSSN.Appearance = (AppearanceBase) appearance13;
    ((Control) this.txtSSN).DataBindings.Add(new Binding("Value", (object) this.dsUser, "tblUsers.SSN", true));
    this.txtSSN.DataMode = (MaskMode) 0;
    this.txtSSN.EditAs = (EditAsType) 1;
    this.txtSSN.InputMask = "###-##-####";
    ((Control) this.txtSSN).Location = new Point(88, 287);
    ((Control) this.txtSSN).Name = "txtSSN";
    this.txtSSN.NonAutoSizeHeight = 20;
    ((Control) this.txtSSN).Size = new Size(80 /*0x50*/, 21);
    ((Control) this.txtSSN).TabIndex = 21;
    ((UltraControlBase) this.txtSSN).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtSSN).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.ZipCodeResolver1);
    ((Control) this.UltraTabPageControl1).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabPageControl1).Name = "UltraTabPageControl1";
    ((Control) this.UltraTabPageControl1).Size = new Size(374, 413);
    this.ZipCodeResolver1.AddressServiceURL = "";
    this.ZipCodeResolver1.AutoScrollMargin = new Size(0, 0);
    this.ZipCodeResolver1.AutoScrollMinSize = new Size(0, 0);
    this.ZipCodeResolver1.BackColor = Color.Transparent;
    this.ZipCodeResolver1.City = "";
    this.ZipCodeResolver1.County = "";
    ((Control) this.ZipCodeResolver1).DataBindings.Add(new Binding("State", (object) this.dsUser, "tblUsers.State", true));
    ((Control) this.ZipCodeResolver1).DataBindings.Add(new Binding("City", (object) this.dsUser, "tblUsers.City", true));
    ((Control) this.ZipCodeResolver1).DataBindings.Add(new Binding("County", (object) this.dsUser, "tblUsers.County", true));
    ((Control) this.ZipCodeResolver1).DataBindings.Add(new Binding("Street1", (object) this.dsUser, "tblUsers.Address1", true));
    ((Control) this.ZipCodeResolver1).DataBindings.Add(new Binding("Street2", (object) this.dsUser, "tblUsers.Address2", true));
    ((Control) this.ZipCodeResolver1).DataBindings.Add(new Binding("ZipCode", (object) this.dsUser, "tblUsers.ZipCode", true));
    ((Control) this.ZipCodeResolver1).DataBindings.Add(new Binding("ZipCodeExtension", (object) this.dsUser, "tblUsers.ZipPlus", true));
    ((Control) this.ZipCodeResolver1).DataBindings.Add(new Binding("GeoRegion", (object) this.dsUser, "tblUsers.Region", true));
    ((Control) this.ZipCodeResolver1).DataBindings.Add(new Binding("ISOCountryCode", (object) this.dsUser, "tblUsers.ISOCountryCode", true));
    this.ZipCodeResolver1.GeoRegion = "";
    this.ZipCodeResolver1.ISOCountryCode = "";
    this.ZipCodeResolver1.ISOCountryCodeMember = "";
    this.ZipCodeResolver1.ISOCountryList = (object) null;
    this.ZipCodeResolver1.ISOCountryNameMember = "";
    ((Control) this.ZipCodeResolver1).Location = new Point(16 /*0x10*/, 16 /*0x10*/);
    this.ZipCodeResolver1.MGAStyle = MGAStyles.Blue;
    ((Control) this.ZipCodeResolver1).Name = "ZipCodeResolver1";
    this.ZipCodeResolver1.Password = "";
    this.ZipCodeResolver1.ShowGlobal = true;
    ((Control) this.ZipCodeResolver1).Size = new Size(328, 144 /*0x90*/);
    this.ZipCodeResolver1.State = "";
    this.ZipCodeResolver1.Street1 = "";
    this.ZipCodeResolver1.Street2 = "";
    ((Control) this.ZipCodeResolver1).TabIndex = 0;
    this.ZipCodeResolver1.UserID = "";
    this.ZipCodeResolver1.ZipCode = "";
    this.ZipCodeResolver1.ZipCodeExtension = "";
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.txtPhoneExtension);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.Label12);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.cboUnderwritingTeam);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.txtHomeEmailAddress);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.LblHomeEmailAddress);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.Label10);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.udEnd);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.lnkEditEmailServerInfo);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.txtFax);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.Label1);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.txtCellPhone);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.txtPhone);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.txtForeignPhone);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.Label2);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.lblPhone);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.lblForeignPhone);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.txtEmail);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.Label6);
    ((Control) this.UltraTabPageControl2).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabPageControl2).Name = "UltraTabPageControl2";
    ((Control) this.UltraTabPageControl2).Size = new Size(374, 413);
    appearance14.BackColor = Color.White;
    appearance14.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance14.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtPhoneExtension).Appearance = (AppearanceBase) appearance14;
    ((TextEditorControlBase) this.txtPhoneExtension).BackColor = Color.White;
    ((Control) this.txtPhoneExtension).DataBindings.Add(new Binding("Text", (object) this.dsUser, "tblUsers.PhoneExtension", true));
    ((Control) this.txtPhoneExtension).Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.txtPhoneExtension).Location = new Point(264, 16 /*0x10*/);
    ((TextEditorControlBase) this.txtPhoneExtension).MaxLength = 10;
    this.txtPhoneExtension.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtPhoneExtension).Name = "txtPhoneExtension";
    ((Control) this.txtPhoneExtension).Size = new Size(85, 20);
    ((Control) this.txtPhoneExtension).TabIndex = 2;
    ((UltraControlBase) this.txtPhoneExtension).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtPhoneExtension).UseOsThemes = (DefaultableBoolean) 2;
    this.Label12.AutoSize = true;
    this.Label12.BackColor = Color.Transparent;
    this.Label12.Location = new Point(16 /*0x10*/, 166);
    this.Label12.Name = "Label12";
    this.Label12.Size = new Size(97, 13);
    this.Label12.TabIndex = 19;
    this.Label12.Text = "Underwriting Team";
    this.Label12.TextAlign = ContentAlignment.MiddleRight;
    this.cboUnderwritingTeam.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboUnderwritingTeam).DataBindings.Add(new Binding("Value", (object) this.dsUser, "tblUsers.UnderwritingTeamID", true));
    ((UltraGridBase) this.cboUnderwritingTeam).DataMember = "lstUnderwritingTeam";
    ((UltraGridBase) this.cboUnderwritingTeam).DataSource = (object) this.dsUser;
    ((UltraDropDownBase) this.cboUnderwritingTeam).DisplayMember = "UnderwritingTeam";
    this.cboUnderwritingTeam.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboUnderwritingTeam).Location = new Point(120, 162);
    this.cboUnderwritingTeam.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboUnderwritingTeam).Name = "cboUnderwritingTeam";
    ((Control) this.cboUnderwritingTeam).Size = new Size(184, 21);
    ((Control) this.cboUnderwritingTeam).TabIndex = 18;
    ((UltraControlBase) this.cboUnderwritingTeam).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboUnderwritingTeam).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboUnderwritingTeam).ValueMember = "ID";
    appearance15.BackColor = Color.White;
    appearance15.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance15.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtHomeEmailAddress).Appearance = (AppearanceBase) appearance15;
    ((TextEditorControlBase) this.txtHomeEmailAddress).BackColor = Color.White;
    ((Control) this.txtHomeEmailAddress).DataBindings.Add(new Binding("Text", (object) this.dsUser, "tblUsers.HomeEmailAddress", true));
    ((Control) this.txtHomeEmailAddress).Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.txtHomeEmailAddress).Location = new Point(120, 138);
    ((TextEditorControlBase) this.txtHomeEmailAddress).MaxLength = 50;
    this.txtHomeEmailAddress.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtHomeEmailAddress).Name = "txtHomeEmailAddress";
    ((Control) this.txtHomeEmailAddress).Size = new Size(135, 20);
    ((Control) this.txtHomeEmailAddress).TabIndex = 17;
    ((UltraControlBase) this.txtHomeEmailAddress).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtHomeEmailAddress).UseOsThemes = (DefaultableBoolean) 2;
    this.LblHomeEmailAddress.AutoSize = true;
    this.LblHomeEmailAddress.BackColor = Color.Transparent;
    this.LblHomeEmailAddress.Location = new Point(10, 142);
    this.LblHomeEmailAddress.Name = "LblHomeEmailAddress";
    this.LblHomeEmailAddress.Size = new Size(103, 13);
    this.LblHomeEmailAddress.TabIndex = 16 /*0x10*/;
    this.LblHomeEmailAddress.Text = "Home Email Address";
    this.LblHomeEmailAddress.TextAlign = ContentAlignment.MiddleRight;
    this.Label10.AutoSize = true;
    this.Label10.BackColor = Color.Transparent;
    this.Label10.Location = new Point(208 /*0xD0*/, 20);
    this.Label10.Name = "Label10";
    this.Label10.Size = new Size(54, 13);
    this.Label10.TabIndex = 15;
    this.Label10.Text = "Extension";
    this.Label10.TextAlign = ContentAlignment.MiddleRight;
    ((Control) this.udEnd).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    appearance16.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.udEnd).Appearance = (AppearanceBase) appearance16;
    ((Control) this.udEnd).DataBindings.Add(new Binding("Value", (object) this.dsUser, "tblUsers.PhoneExt", true));
    ((Control) this.udEnd).Location = new Point(264, 16 /*0x10*/);
    this.udEnd.MaskInput = "nnnnnnn";
    this.udEnd.MaxValue = (object) 9999999;
    this.udEnd.MGAStyle = MGAStyles.Blue;
    this.udEnd.MinValue = (object) 0;
    ((Control) this.udEnd).Name = "udEnd";
    this.udEnd.Nullable = true;
    ((Control) this.udEnd).Size = new Size(10, 20);
    ((Control) this.udEnd).TabIndex = 20;
    ((UltraControlBase) this.udEnd).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.udEnd).UseOsThemes = (DefaultableBoolean) 2;
    this.udEnd.Value = (object) null;
    ((Control) this.udEnd).Visible = false;
    this.lnkEditEmailServerInfo.BackColor = Color.Transparent;
    this.lnkEditEmailServerInfo.Location = new Point(8, 328);
    this.lnkEditEmailServerInfo.Name = "lnkEditEmailServerInfo";
    this.lnkEditEmailServerInfo.Size = new Size(152, 16 /*0x10*/);
    this.lnkEditEmailServerInfo.TabIndex = 13;
    this.lnkEditEmailServerInfo.TabStop = true;
    this.lnkEditEmailServerInfo.Text = "Edit Email Server Information";
    appearance17.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.txtFax.Appearance = (AppearanceBase) appearance17;
    ((Control) this.txtFax).DataBindings.Add(new Binding("Value", (object) this.dsUser, "tblUsers.Fax", true));
    this.txtFax.EditAs = (EditAsType) 1;
    this.txtFax.InputMask = "###-###-####";
    ((Control) this.txtFax).Location = new Point(120, 89);
    this.txtFax.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtFax).Name = "txtFax";
    this.txtFax.NonAutoSizeHeight = 20;
    ((Control) this.txtFax).Size = new Size(80 /*0x50*/, 21);
    ((Control) this.txtFax).TabIndex = 5;
    this.txtFax.Text = "--";
    ((UltraControlBase) this.txtFax).UseFlatMode = (DefaultableBoolean) 2;
    ((UltraControlBase) this.txtFax).UseOsThemes = (DefaultableBoolean) 2;
    this.Label1.AutoSize = true;
    this.Label1.BackColor = Color.Transparent;
    this.Label1.Location = new Point(88, 93);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(25, 13);
    this.Label1.TabIndex = 4;
    this.Label1.Text = "Fax";
    this.Label1.TextAlign = ContentAlignment.MiddleRight;
    appearance18.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.txtCellPhone.Appearance = (AppearanceBase) appearance18;
    ((Control) this.txtCellPhone).DataBindings.Add(new Binding("Value", (object) this.dsUser, "tblUsers.CellPhone", true));
    this.txtCellPhone.EditAs = (EditAsType) 1;
    this.txtCellPhone.InputMask = "###-###-####";
    ((Control) this.txtCellPhone).Location = new Point(120, 64 /*0x40*/);
    this.txtCellPhone.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtCellPhone).Name = "txtCellPhone";
    this.txtCellPhone.NonAutoSizeHeight = 20;
    ((Control) this.txtCellPhone).Size = new Size(80 /*0x50*/, 21);
    ((Control) this.txtCellPhone).TabIndex = 4;
    this.txtCellPhone.Text = "--";
    ((UltraControlBase) this.txtCellPhone).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtCellPhone).UseOsThemes = (DefaultableBoolean) 2;
    appearance19.BackColor = Color.White;
    appearance19.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance19.ForeColor = Color.Black;
    this.txtPhone.Appearance = (AppearanceBase) appearance19;
    ((Control) this.txtPhone).DataBindings.Add(new Binding("Value", (object) this.dsUser, "tblUsers.Phone", true));
    this.txtPhone.EditAs = (EditAsType) 1;
    this.txtPhone.InputMask = "###-###-####";
    ((Control) this.txtPhone).Location = new Point(120, 16 /*0x10*/);
    this.txtPhone.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtPhone).Name = "txtPhone";
    this.txtPhone.NonAutoSizeHeight = 20;
    ((Control) this.txtPhone).Size = new Size(80 /*0x50*/, 21);
    ((Control) this.txtPhone).TabIndex = 1;
    this.txtPhone.Text = "--";
    ((UltraControlBase) this.txtPhone).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtPhone).UseOsThemes = (DefaultableBoolean) 2;
    ((TextEditorControlBase) this.txtForeignPhone).Appearance = (AppearanceBase) appearance19;
    ((TextEditorControlBase) this.txtForeignPhone).BackColor = Color.White;
    ((Control) this.txtForeignPhone).DataBindings.Add(new Binding("Text", (object) this.dsUser, "tblUsers.ForeignPhone", true));
    ((Control) this.txtForeignPhone).Location = new Point(120, 41);
    this.txtForeignPhone.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtForeignPhone).Name = "txtForeignPhone";
    ((Control) this.txtForeignPhone).Size = new Size(80 /*0x50*/, 20);
    ((Control) this.txtForeignPhone).TabIndex = 3;
    ((UltraControlBase) this.txtForeignPhone).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtForeignPhone).UseOsThemes = (DefaultableBoolean) 2;
    this.Label2.AutoSize = true;
    this.Label2.BackColor = Color.Transparent;
    this.Label2.Location = new Point(40, 118);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(73, 13);
    this.Label2.TabIndex = 6;
    this.Label2.Text = "Email Address";
    this.Label2.TextAlign = ContentAlignment.MiddleRight;
    this.lblPhone.AutoSize = true;
    this.lblPhone.BackColor = Color.Transparent;
    this.lblPhone.Location = new Point(76, 20);
    this.lblPhone.Name = "lblPhone";
    this.lblPhone.Size = new Size(37, 13);
    this.lblPhone.TabIndex = 0;
    this.lblPhone.Text = "Phone";
    this.lblPhone.TextAlign = ContentAlignment.MiddleRight;
    this.lblForeignPhone.AutoSize = true;
    this.lblForeignPhone.BackColor = Color.Transparent;
    this.lblForeignPhone.Location = new Point(40, 42);
    this.lblForeignPhone.Name = "lblForeignPhone";
    this.lblForeignPhone.Size = new Size(76, 13);
    this.lblForeignPhone.TabIndex = 0;
    this.lblForeignPhone.Text = "Foreign Phone";
    this.lblForeignPhone.TextAlign = ContentAlignment.MiddleRight;
    appearance20.BackColor = Color.White;
    appearance20.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance20.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtEmail).Appearance = (AppearanceBase) appearance20;
    ((TextEditorControlBase) this.txtEmail).BackColor = Color.White;
    ((Control) this.txtEmail).DataBindings.Add(new Binding("Text", (object) this.dsUser, "tblUsers.EmailAddress", true));
    ((Control) this.txtEmail).Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.txtEmail).Location = new Point(120, 114);
    ((TextEditorControlBase) this.txtEmail).MaxLength = 50;
    this.txtEmail.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtEmail).Name = "txtEmail";
    ((Control) this.txtEmail).Size = new Size(135, 20);
    ((Control) this.txtEmail).TabIndex = 7;
    ((UltraControlBase) this.txtEmail).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtEmail).UseOsThemes = (DefaultableBoolean) 2;
    this.Label6.AutoSize = true;
    this.Label6.BackColor = Color.Transparent;
    this.Label6.Location = new Point(56, 68);
    this.Label6.Name = "Label6";
    this.Label6.Size = new Size(57, 13);
    this.Label6.TabIndex = 2;
    this.Label6.Text = "Cell Phone";
    this.Label6.TextAlign = ContentAlignment.MiddleRight;
    ((Control) this.UltraTabPageControl4).Controls.Add((Control) this.SignatureCapturePanel1);
    ((Control) this.UltraTabPageControl4).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabPageControl4).Name = "UltraTabPageControl4";
    ((Control) this.UltraTabPageControl4).Size = new Size(374, 413);
    this.SignatureCapturePanel1.BackColor = Color.White;
    this.SignatureCapturePanel1.CaptureSize = new Size(240 /*0xF0*/, 100);
    this.SignatureCapturePanel1.Location = new Point(24, 93);
    this.SignatureCapturePanel1.Name = "SignatureCapturePanel1";
    this.SignatureCapturePanel1.Size = new Size(344, 160 /*0xA0*/);
    this.SignatureCapturePanel1.TabIndex = 0;
    this.DbSaveUI1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.DbSaveUI1.AutoQueryRowCountOnLoad = false;
    this.DbSaveUI1.EditStyle = EditStyle.ShowEditButton;
    this.DbSaveUI1.FreezeEvents = false;
    this.DbSaveUI1.Location = new Point(390, 447);
    this.DbSaveUI1.Name = "DbSaveUI1";
    this.DbSaveUI1.Size = new Size(112 /*0x70*/, 40);
    this.DbSaveUI1.TabIndex = 0;
    this.daUsers.DeleteCommand = this.SqlDeleteCommand1;
    this.daUsers.InsertCommand = this.SqlInsertCommand1;
    this.daUsers.SelectCommand = this.SqlSelectCommand1;
    this.daUsers.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblUsers", new DataColumnMapping[28]
      {
        new DataColumnMapping("UserGUID", "UserGUID"),
        new DataColumnMapping("OfficeGUID", "OfficeGUID"),
        new DataColumnMapping("UserName", "UserName"),
        new DataColumnMapping("Password", "Password"),
        new DataColumnMapping("EmailAddress", "EmailAddress"),
        new DataColumnMapping("FirstName", "FirstName"),
        new DataColumnMapping("LastName", "LastName"),
        new DataColumnMapping("Title", "Title"),
        new DataColumnMapping("Initials", "Initials"),
        new DataColumnMapping("Address1", "Address1"),
        new DataColumnMapping("Address2", "Address2"),
        new DataColumnMapping("ZipPlus", "ZipPlus"),
        new DataColumnMapping("Phone", "Phone"),
        new DataColumnMapping("CellPhone", "CellPhone"),
        new DataColumnMapping("StatusID", "StatusID"),
        new DataColumnMapping("UserSignature", "UserSignature"),
        new DataColumnMapping("UserManagerGUID", "UserManagerGUID"),
        new DataColumnMapping("City", "City"),
        new DataColumnMapping("County", "County"),
        new DataColumnMapping("State", "State"),
        new DataColumnMapping("ZipCode", "ZipCode"),
        new DataColumnMapping("Fax", "Fax"),
        new DataColumnMapping("LoggedIn", "LoggedIn"),
        new DataColumnMapping("LastLogin", "LastLogin"),
        new DataColumnMapping("Region", "Region"),
        new DataColumnMapping("ISOCountryCode", "ISOCountryCode"),
        new DataColumnMapping("CommissionsFromOperatingAccount", "CommissionsFromOperatingAccount"),
        new DataColumnMapping("SSN", "SSN")
      })
    });
    this.daUsers.UpdateCommand = this.SqlUpdateCommand1;
    this.SqlDeleteCommand1.CommandText = "DELETE FROM dbo.tblUsers WHERE (UserGUID = @Original_UserGUID)";
    this.SqlDeleteCommand1.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@Original_UserGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, ParameterDirection.Input, false, (byte) 0, (byte) 0, "UserGUID", DataRowVersion.Original, (object) null)
    });
    this.SqlInsertCommand1.CommandText = componentResourceManager.GetString("SqlInsertCommand1.CommandText");
    this.SqlInsertCommand1.Parameters.AddRange(new SqlParameter[37]
    {
      new SqlParameter("@UserGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "UserGUID"),
      new SqlParameter("@OfficeGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "OfficeGUID"),
      new SqlParameter("@UserName", SqlDbType.VarChar, 50, "UserName"),
      new SqlParameter("@Password", SqlDbType.VarChar, 50, "Password"),
      new SqlParameter("@EmailAddress", SqlDbType.VarChar, 50, "EmailAddress"),
      new SqlParameter("@FirstName", SqlDbType.VarChar, 50, "FirstName"),
      new SqlParameter("@LastName", SqlDbType.VarChar, 50, "LastName"),
      new SqlParameter("@Title", SqlDbType.VarChar, 50, "Title"),
      new SqlParameter("@Initials", SqlDbType.VarChar, 50, "Initials"),
      new SqlParameter("@Address1", SqlDbType.VarChar, 50, "Address1"),
      new SqlParameter("@Address2", SqlDbType.VarChar, 50, "Address2"),
      new SqlParameter("@ZipPlus", SqlDbType.VarChar, 4, "ZipPlus"),
      new SqlParameter("@Phone", SqlDbType.VarChar, 20, "Phone"),
      new SqlParameter("@CellPhone", SqlDbType.VarChar, 20, "CellPhone"),
      new SqlParameter("@StatusID", SqlDbType.TinyInt, 1, "StatusID"),
      new SqlParameter("@UserSignature", SqlDbType.Image, int.MaxValue, "UserSignature"),
      new SqlParameter("@UserManagerGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "UserManagerGUID"),
      new SqlParameter("@City", SqlDbType.VarChar, 50, "City"),
      new SqlParameter("@County", SqlDbType.VarChar, 50, "County"),
      new SqlParameter("@State", SqlDbType.VarChar, 2, "State"),
      new SqlParameter("@ZipCode", SqlDbType.Char, 5, "ZipCode"),
      new SqlParameter("@Fax", SqlDbType.VarChar, 20, "Fax"),
      new SqlParameter("@LoggedIn", SqlDbType.Bit, 1, "LoggedIn"),
      new SqlParameter("@LastLogin", SqlDbType.DateTime, 8, "LastLogin"),
      new SqlParameter("@Region", SqlDbType.VarChar, 100, "Region"),
      new SqlParameter("@ISOCountryCode", SqlDbType.Char, 3, "ISOCountryCode"),
      new SqlParameter("@CommissionsFromOperatingAccount", SqlDbType.Bit, 1, "CommissionsFromOperatingAccount"),
      new SqlParameter("@SSN", SqlDbType.VarChar, 9, "SSN"),
      new SqlParameter("@PhoneExt", SqlDbType.Int, 2, "PhoneExt"),
      new SqlParameter("@AllowSimultaneousLogins", SqlDbType.Bit, 1, "AllowSimultaneousLogins"),
      new SqlParameter("@HomeEmailAddress", SqlDbType.VarChar, 50, "HomeEmailAddress"),
      new SqlParameter("@ForeignPhone", SqlDbType.VarChar, 50, "ForeignPhone"),
      new SqlParameter("@UnderwritingTeamID", SqlDbType.Int, 4, "UnderwritingTeamID"),
      new SqlParameter("@RequirePasswordResetOnNextLogin", SqlDbType.Bit, 1, "RequirePasswordResetOnNextLogin"),
      new SqlParameter("@EmployeeNumber", SqlDbType.VarChar, 10, "EmployeeNumber"),
      new SqlParameter("@EncryptedPassword", SqlDbType.VarChar, 100, "EncryptedPassword"),
      new SqlParameter("@PhoneExtension", SqlDbType.VarChar, 10, "PhoneExtension")
    });
    this.SqlSelectCommand1.CommandText = componentResourceManager.GetString("SqlSelectCommand1.CommandText");
    this.SqlSelectCommand1.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@UserGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "UserGUID")
    });
    this.SqlUpdateCommand1.CommandText = componentResourceManager.GetString("SqlUpdateCommand1.CommandText");
    this.SqlUpdateCommand1.Parameters.AddRange(new SqlParameter[38]
    {
      new SqlParameter("@UserGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "UserGUID"),
      new SqlParameter("@OfficeGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "OfficeGUID"),
      new SqlParameter("@UserName", SqlDbType.VarChar, 50, "UserName"),
      new SqlParameter("@Password", SqlDbType.VarChar, 50, "Password"),
      new SqlParameter("@EmailAddress", SqlDbType.VarChar, 50, "EmailAddress"),
      new SqlParameter("@FirstName", SqlDbType.VarChar, 50, "FirstName"),
      new SqlParameter("@LastName", SqlDbType.VarChar, 50, "LastName"),
      new SqlParameter("@Title", SqlDbType.VarChar, 50, "Title"),
      new SqlParameter("@Initials", SqlDbType.VarChar, 50, "Initials"),
      new SqlParameter("@Address1", SqlDbType.VarChar, 50, "Address1"),
      new SqlParameter("@Address2", SqlDbType.VarChar, 50, "Address2"),
      new SqlParameter("@ZipPlus", SqlDbType.VarChar, 4, "ZipPlus"),
      new SqlParameter("@Phone", SqlDbType.VarChar, 20, "Phone"),
      new SqlParameter("@CellPhone", SqlDbType.VarChar, 20, "CellPhone"),
      new SqlParameter("@StatusID", SqlDbType.TinyInt, 1, "StatusID"),
      new SqlParameter("@UserSignature", SqlDbType.Image, int.MaxValue, "UserSignature"),
      new SqlParameter("@UserManagerGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "UserManagerGUID"),
      new SqlParameter("@City", SqlDbType.VarChar, 50, "City"),
      new SqlParameter("@County", SqlDbType.VarChar, 50, "County"),
      new SqlParameter("@State", SqlDbType.VarChar, 2, "State"),
      new SqlParameter("@ZipCode", SqlDbType.Char, 5, "ZipCode"),
      new SqlParameter("@Fax", SqlDbType.VarChar, 20, "Fax"),
      new SqlParameter("@LoggedIn", SqlDbType.Bit, 1, "LoggedIn"),
      new SqlParameter("@LastLogin", SqlDbType.DateTime, 8, "LastLogin"),
      new SqlParameter("@Region", SqlDbType.VarChar, 100, "Region"),
      new SqlParameter("@ISOCountryCode", SqlDbType.Char, 3, "ISOCountryCode"),
      new SqlParameter("@CommissionsFromOperatingAccount", SqlDbType.Bit, 1, "CommissionsFromOperatingAccount"),
      new SqlParameter("@SSN", SqlDbType.VarChar, 9, "SSN"),
      new SqlParameter("@PhoneExt", SqlDbType.Int, 2, "PhoneExt"),
      new SqlParameter("@AllowSimultaneousLogins", SqlDbType.Bit, 1, "AllowSimultaneousLogins"),
      new SqlParameter("@HomeEmailAddress", SqlDbType.VarChar, 50, "HomeEmailAddress"),
      new SqlParameter("@ForeignPhone", SqlDbType.VarChar, 50, "ForeignPhone"),
      new SqlParameter("@UnderwritingTeamID", SqlDbType.Int, 4, "UnderwritingTeamID"),
      new SqlParameter("@RequirePasswordResetOnNextLogin", SqlDbType.Bit, 1, "RequirePasswordResetOnNextLogin"),
      new SqlParameter("@EmployeeNumber", SqlDbType.VarChar, 10, "EmployeeNumber"),
      new SqlParameter("@Original_UserGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, ParameterDirection.Input, false, (byte) 0, (byte) 0, "UserGUID", DataRowVersion.Original, (object) null),
      new SqlParameter("@EncryptedPassword", SqlDbType.VarChar, 100, "EncryptedPassword"),
      new SqlParameter("@PhoneExtension", SqlDbType.VarChar, 10, "PhoneExtension")
    });
    this.tvUsers.BorderStyle = BorderStyle.None;
    this.tvUsers.ContextMenu = this.ctxSecurity;
    this.tvUsers.Dock = DockStyle.Fill;
    this.tvUsers.HideSelection = false;
    this.tvUsers.ImageIndex = 0;
    this.tvUsers.ImageList = this.treeImages;
    this.tvUsers.Location = new Point(3, 38);
    this.tvUsers.Name = "tvUsers";
    this.tvUsers.SelectedImageIndex = 0;
    this.tvUsers.Size = new Size(194, 326);
    this.tvUsers.TabIndex = 0;
    this.treeImages.ImageStream = (ImageListStreamer) componentResourceManager.GetObject("treeImages.ImageStream");
    this.treeImages.TransparentColor = Color.Transparent;
    this.treeImages.Images.SetKeyName(0, "house.png");
    this.treeImages.Images.SetKeyName(1, "user_suit.png");
    ((Control) this.gbUsers).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
    appearance21.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.gbUsers.ContentAreaAppearance = (AppearanceBase) appearance21;
    ((Control) this.gbUsers).Controls.Add((Control) this.tvUsers);
    ((Control) this.gbUsers).Controls.Add((Control) this.pnlFilter);
    appearance22.ForeColor = Color.Black;
    this.gbUsers.HeaderAppearance = (AppearanceBase) appearance22;
    ((Control) this.gbUsers).Location = new Point(392, 48 /*0x30*/);
    ((Control) this.gbUsers).Name = "gbUsers";
    ((Control) this.gbUsers).Size = new Size(200, 367);
    ((Control) this.gbUsers).TabIndex = 4;
    this.gbUsers.Text = "Users";
    this.pnlFilter.Controls.Add((Control) this.txtFilter);
    this.pnlFilter.Controls.Add((Control) this.pnlFilterIcon);
    this.pnlFilter.Dock = DockStyle.Top;
    this.pnlFilter.Location = new Point(3, 17);
    this.pnlFilter.Name = "pnlFilter";
    this.pnlFilter.Size = new Size(194, 21);
    this.pnlFilter.TabIndex = 3;
    this.txtFilter.Dock = DockStyle.Fill;
    this.txtFilter.Location = new Point(0, 0);
    this.txtFilter.Name = "txtFilter";
    this.txtFilter.Size = new Size(174, 21);
    this.txtFilter.TabIndex = 1;
    this.pnlFilterIcon.BackColor = Color.Transparent;
    this.pnlFilterIcon.BackgroundImageLayout = ImageLayout.Zoom;
    this.pnlFilterIcon.Dock = DockStyle.Right;
    this.pnlFilterIcon.Location = new Point(174, 0);
    this.pnlFilterIcon.Name = "pnlFilterIcon";
    this.pnlFilterIcon.Size = new Size(20, 21);
    this.pnlFilterIcon.TabIndex = 3;
    ((Control) this.lblOffice).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    ((AppearanceBase) appearance23).TextHAlignAsString = "Center";
    ((AppearanceBase) appearance23).TextVAlignAsString = "Middle";
    ((ControlBase) this.lblOffice).Appearance = (AppearanceBase) appearance23;
    ((Control) this.lblOffice).Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.lblOffice).Location = new Point(8, 16 /*0x10*/);
    ((Control) this.lblOffice).Name = "lblOffice";
    ((Control) this.lblOffice).Size = new Size(592, 25);
    ((Control) this.lblOffice).TabIndex = 0;
    ((ControlBase) this.lblOffice).Text = "(name here)";
    this.UltraToolbarsManager1.DesignerFlags = 1;
    this.UltraToolbarsManager1.DockWithinContainer = (Control) this;
    this.UltraToolbarsManager1.DockWithinContainerBaseType = typeof (Form);
    this.UltraToolbarsManager1.ShowFullMenusDelay = 500;
    ultraToolbar.DockedColumn = 0;
    ultraToolbar.DockedRow = 0;
    ultraToolbar.IsMainMenuBar = true;
    ((UltraToolbarBase) ultraToolbar).NonInheritedTools.AddRange(new ToolBase[1]
    {
      (ToolBase) popupMenuTool1
    });
    ultraToolbar.Text = "MainMenu";
    this.UltraToolbarsManager1.Toolbars.AddRange(new UltraToolbar[1]
    {
      ultraToolbar
    });
    ((ToolPropsBase) ((ToolBase) popupMenuTool2).SharedPropsInternal).Caption = "Users";
    ((ToolsCollectionBase) popupMenuTool2.Tools).AddRange(new ToolBase[13]
    {
      (ToolBase) buttonTool1,
      (ToolBase) buttonTool2,
      (ToolBase) buttonTool3,
      (ToolBase) buttonTool4,
      (ToolBase) buttonTool5,
      (ToolBase) buttonTool6,
      (ToolBase) buttonTool7,
      (ToolBase) buttonTool8,
      (ToolBase) buttonTool9,
      (ToolBase) buttonTool10,
      (ToolBase) buttonTool11,
      (ToolBase) buttonTool12,
      (ToolBase) buttonTool13
    });
    ((ToolPropsBase) ((ToolBase) buttonTool14).SharedPropsInternal).Caption = "Licenses...";
    ((ToolPropsBase) ((ToolBase) buttonTool15).SharedPropsInternal).Caption = "Lines...";
    ((ToolPropsBase) ((ToolBase) buttonTool16).SharedPropsInternal).Caption = "Assign Producer Contacts...";
    ((ToolPropsBase) ((ToolBase) buttonTool17).SharedPropsInternal).Caption = "Viewing Rights...";
    ((ToolPropsBase) ((ToolBase) buttonTool18).SharedPropsInternal).Caption = "User Types...";
    ((ToolPropsBase) ((ToolBase) buttonTool19).SharedPropsInternal).Caption = "Company Viewing Rights...";
    ((ToolPropsBase) ((ToolBase) buttonTool20).SharedPropsInternal).Caption = "Insured Viewing Rights ...";
    appearance24.Image = (object) MGASystems.IMS.Forms.My.Resources.Resources.building_edit;
    ((ToolPropsBase) ((ToolBase) buttonTool21).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance24;
    ((ToolPropsBase) ((ToolBase) buttonTool21).SharedPropsInternal).Caption = "Quoting Office Viewing Rights";
    appearance25.Image = (object) MGASystems.IMS.Forms.My.Resources.Resources.user_go;
    ((ToolPropsBase) ((ToolBase) buttonTool22).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance25;
    ((ToolPropsBase) ((ToolBase) buttonTool22).SharedPropsInternal).Caption = "Producer Location View Rights ...";
    appearance26.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance31.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool23).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance26;
    ((ToolPropsBase) ((ToolBase) buttonTool23).SharedPropsInternal).Caption = "Issuing Office Viewing Rights ...";
    appearance27.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance32.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool24).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance27;
    ((ToolPropsBase) ((ToolBase) buttonTool24).SharedPropsInternal).Caption = "Policy Viewing Rights ...";
    appearance28.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance33.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool25).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance28;
    ((ToolPropsBase) ((ToolBase) buttonTool25).SharedPropsInternal).Caption = "User Goals ...";
    appearance29.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance34.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool26).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance29;
    ((ToolPropsBase) ((ToolBase) buttonTool26).SharedPropsInternal).Caption = "Fee Viewing Rights";
    this.UltraToolbarsManager1.Tools.AddRange(new ToolBase[14]
    {
      (ToolBase) popupMenuTool2,
      (ToolBase) buttonTool14,
      (ToolBase) buttonTool15,
      (ToolBase) buttonTool16,
      (ToolBase) buttonTool17,
      (ToolBase) buttonTool18,
      (ToolBase) buttonTool19,
      (ToolBase) buttonTool20,
      (ToolBase) buttonTool21,
      (ToolBase) buttonTool22,
      (ToolBase) buttonTool23,
      (ToolBase) buttonTool24,
      (ToolBase) buttonTool25,
      (ToolBase) buttonTool26
    });
    ((Control) this._frmUsers_Toolbars_Dock_Area_Left).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._frmUsers_Toolbars_Dock_Area_Left).BackColor = Color.White;
    this._frmUsers_Toolbars_Dock_Area_Left.DockedPosition = (DockedPosition) 2;
    ((Control) this._frmUsers_Toolbars_Dock_Area_Left).ForeColor = Color.Black;
    ((Control) this._frmUsers_Toolbars_Dock_Area_Left).Location = new Point(0, 21);
    ((Control) this._frmUsers_Toolbars_Dock_Area_Left).Name = "_frmUsers_Toolbars_Dock_Area_Left";
    ((Control) this._frmUsers_Toolbars_Dock_Area_Left).Size = new Size(0, 480);
    this._frmUsers_Toolbars_Dock_Area_Left.ToolbarsManager = this.UltraToolbarsManager1;
    ((Control) this._frmUsers_Toolbars_Dock_Area_Right).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._frmUsers_Toolbars_Dock_Area_Right).BackColor = Color.White;
    this._frmUsers_Toolbars_Dock_Area_Right.DockedPosition = (DockedPosition) 3;
    ((Control) this._frmUsers_Toolbars_Dock_Area_Right).ForeColor = Color.Black;
    ((Control) this._frmUsers_Toolbars_Dock_Area_Right).Location = new Point(600, 21);
    ((Control) this._frmUsers_Toolbars_Dock_Area_Right).Name = "_frmUsers_Toolbars_Dock_Area_Right";
    ((Control) this._frmUsers_Toolbars_Dock_Area_Right).Size = new Size(0, 480);
    this._frmUsers_Toolbars_Dock_Area_Right.ToolbarsManager = this.UltraToolbarsManager1;
    ((Control) this._frmUsers_Toolbars_Dock_Area_Top).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._frmUsers_Toolbars_Dock_Area_Top).BackColor = Color.White;
    this._frmUsers_Toolbars_Dock_Area_Top.DockedPosition = (DockedPosition) 0;
    ((Control) this._frmUsers_Toolbars_Dock_Area_Top).ForeColor = Color.Black;
    ((Control) this._frmUsers_Toolbars_Dock_Area_Top).Location = new Point(0, 0);
    ((Control) this._frmUsers_Toolbars_Dock_Area_Top).Name = "_frmUsers_Toolbars_Dock_Area_Top";
    ((Control) this._frmUsers_Toolbars_Dock_Area_Top).Size = new Size(600, 21);
    this._frmUsers_Toolbars_Dock_Area_Top.ToolbarsManager = this.UltraToolbarsManager1;
    ((Control) this._frmUsers_Toolbars_Dock_Area_Bottom).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._frmUsers_Toolbars_Dock_Area_Bottom).BackColor = Color.White;
    this._frmUsers_Toolbars_Dock_Area_Bottom.DockedPosition = (DockedPosition) 1;
    ((Control) this._frmUsers_Toolbars_Dock_Area_Bottom).ForeColor = Color.Black;
    ((Control) this._frmUsers_Toolbars_Dock_Area_Bottom).Location = new Point(0, 501);
    ((Control) this._frmUsers_Toolbars_Dock_Area_Bottom).Name = "_frmUsers_Toolbars_Dock_Area_Bottom";
    ((Control) this._frmUsers_Toolbars_Dock_Area_Bottom).Size = new Size(600, 0);
    this._frmUsers_Toolbars_Dock_Area_Bottom.ToolbarsManager = this.UltraToolbarsManager1;
    this.err.ContainerControl = (ContainerControl) this;
    ((Control) this.UltraTabControl1).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    ((Control) this.UltraTabControl1).Controls.Add((Control) this.UltraTabSharedControlsPage1);
    ((Control) this.UltraTabControl1).Controls.Add((Control) this.UltraTabPageControl1);
    ((Control) this.UltraTabControl1).Controls.Add((Control) this.UltraTabPageControl2);
    ((Control) this.UltraTabControl1).Controls.Add((Control) this.UltraTabPageControl3);
    ((Control) this.UltraTabControl1).Controls.Add((Control) this.UltraTabPageControl4);
    ((Control) this.UltraTabControl1).Location = new Point(8, 48 /*0x30*/);
    ((Control) this.UltraTabControl1).Name = "UltraTabControl1";
    ((UltraTabControlBase) this.UltraTabControl1).SharedControlsPage = this.UltraTabSharedControlsPage1;
    ((Control) this.UltraTabControl1).Size = new Size(376, 440);
    ((Control) this.UltraTabControl1).TabIndex = 10;
    ((UltraTabControlBase) this.UltraTabControl1).TabLayoutStyle = (TabLayoutStyle) 2;
    ((UltraTabControlBase) this.UltraTabControl1).TabPadding = new Size(5, 3);
    appearance30.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance24.Image"));
    ultraTab1.Appearance = (AppearanceBase) appearance30;
    ultraTab1.Key = "General";
    ultraTab1.TabPage = this.UltraTabPageControl3;
    ultraTab1.Text = "General";
    appearance31.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance25.Image"));
    ultraTab2.Appearance = (AppearanceBase) appearance31;
    ultraTab2.Key = "Address";
    ultraTab2.TabPage = this.UltraTabPageControl1;
    ultraTab2.Text = "Address";
    appearance32.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance26.Image"));
    ultraTab3.Appearance = (AppearanceBase) appearance32;
    ultraTab3.Key = "Contact";
    ultraTab3.TabPage = this.UltraTabPageControl2;
    ultraTab3.Text = "Contact Info";
    appearance33.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance27.Image"));
    ultraTab4.Appearance = (AppearanceBase) appearance33;
    ultraTab4.Key = "Signature";
    ultraTab4.TabPage = this.UltraTabPageControl4;
    ultraTab4.Text = "Signature";
    ((UltraTabControlBase) this.UltraTabControl1).Tabs.AddRange(new UltraTab[4]
    {
      ultraTab1,
      ultraTab2,
      ultraTab3,
      ultraTab4
    });
    ((UltraTabControlBase) this.UltraTabControl1).ViewStyle = (ViewStyle) 4;
    ((Control) this.UltraTabSharedControlsPage1).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabSharedControlsPage1).Name = "UltraTabSharedControlsPage1";
    ((Control) this.UltraTabSharedControlsPage1).Size = new Size(374, 413);
    ((Control) this.chkHideInactive).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance34.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance34.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkHideInactive).Appearance = (AppearanceBase) appearance34;
    ((UltraToggleEditorBase) this.chkHideInactive).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkHideInactive).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkHideInactive).Checked = true;
    ((UltraToggleEditorBase) this.chkHideInactive).CheckState = CheckState.Checked;
    ((UltraToggleEditorBase) this.chkHideInactive).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkHideInactive).Location = new Point(390, 421);
    this.chkHideInactive.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkHideInactive).Name = "chkHideInactive";
    ((Control) this.chkHideInactive).Size = new Size(144 /*0x90*/, 20);
    ((Control) this.chkHideInactive).TabIndex = 22;
    ((UltraToggleEditorBase) this.chkHideInactive).Text = "Hide Closed/Inactive";
    ((UltraControlBase) this.chkHideInactive).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkHideInactive).UseOsThemes = (DefaultableBoolean) 2;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.ClientSize = new Size(600, 501);
    this.Controls.Add((Control) this.DbSaveUI1);
    this.Controls.Add((Control) this.UltraTabControl1);
    this.Controls.Add((Control) this.lblOffice);
    this.Controls.Add((Control) this.gbUsers);
    this.Controls.Add((Control) this.chkHideInactive);
    this.Controls.Add((Control) this._frmUsers_Toolbars_Dock_Area_Left);
    this.Controls.Add((Control) this._frmUsers_Toolbars_Dock_Area_Right);
    this.Controls.Add((Control) this._frmUsers_Toolbars_Dock_Area_Bottom);
    this.Controls.Add((Control) this._frmUsers_Toolbars_Dock_Area_Top);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ForeColor = Color.Black;
    this.MinimizeBox = false;
    this.MinimumSize = new Size(616, 540);
    this.Name = nameof (frmUsers);
    this.ShowInTaskbar = false;
    this.Text = "Users";
    ((Control) this.UltraTabPageControl3).ResumeLayout(false);
    ((Control) this.UltraTabPageControl3).PerformLayout();
    ((ISupportInitialize) this.txtEmployeeNum).EndInit();
    this.dsUser.EndInit();
    ((ISupportInitialize) this.MgaCheckBox1).EndInit();
    ((ISupportInitialize) this.chkAllowMultipleLogins).EndInit();
    ((ISupportInitialize) this.txtUserName).EndInit();
    ((ISupportInitialize) this.txtTitle).EndInit();
    ((ISupportInitialize) this.txtPassword).EndInit();
    ((ISupportInitialize) this.cbOffices).EndInit();
    ((ISupportInitialize) this.btnClientLoc).EndInit();
    ((ISupportInitialize) this.txtFirst).EndInit();
    ((ISupportInitialize) this.txtLast).EndInit();
    ((ISupportInitialize) this.cbStatus).EndInit();
    ((ISupportInitialize) this.cboManagedby).EndInit();
    this.dvManagers.EndInit();
    ((ISupportInitialize) this.chkLoggedIn).EndInit();
    ((ISupportInitialize) this.chkComm).EndInit();
    ((ISupportInitialize) this.txtInitials).EndInit();
    ((ISupportInitialize) this.txtSSN).EndInit();
    ((Control) this.UltraTabPageControl1).ResumeLayout(false);
    ((Control) this.UltraTabPageControl2).ResumeLayout(false);
    ((Control) this.UltraTabPageControl2).PerformLayout();
    ((ISupportInitialize) this.txtPhoneExtension).EndInit();
    ((ISupportInitialize) this.cboUnderwritingTeam).EndInit();
    ((ISupportInitialize) this.txtHomeEmailAddress).EndInit();
    ((ISupportInitialize) this.udEnd).EndInit();
    ((ISupportInitialize) this.txtFax).EndInit();
    ((ISupportInitialize) this.txtCellPhone).EndInit();
    ((ISupportInitialize) this.txtPhone).EndInit();
    ((ISupportInitialize) this.txtForeignPhone).EndInit();
    ((ISupportInitialize) this.txtEmail).EndInit();
    ((Control) this.UltraTabPageControl4).ResumeLayout(false);
    ((ISupportInitialize) this.gbUsers).EndInit();
    ((Control) this.gbUsers).ResumeLayout(false);
    this.pnlFilter.ResumeLayout(false);
    this.pnlFilter.PerformLayout();
    ((ISupportInitialize) this.UltraToolbarsManager1).EndInit();
    ((ISupportInitialize) this.err).EndInit();
    ((ISupportInitialize) this.UltraTabControl1).EndInit();
    ((Control) this.UltraTabControl1).ResumeLayout(false);
    ((ISupportInitialize) this.chkHideInactive).EndInit();
    this.ResumeLayout(false);
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    if (this.daUsers != null)
      this.daUsers.Dispose();
    base.Dispose(disposing);
  }

  [field: AccessedThroughProperty("txtHomeEmailAddress")]
  protected virtual MGATextBox txtHomeEmailAddress { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("LblHomeEmailAddress")]
  protected virtual Label LblHomeEmailAddress { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label12")]
  protected virtual Label Label12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual MGASimpleComboBox cboUnderwritingTeam
  {
    get => this._cboUnderwritingTeam;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.cboUnderwritingTeam_ValueChanged);
      MGASimpleComboBox underwritingTeam1 = this._cboUnderwritingTeam;
      if (underwritingTeam1 != null)
        underwritingTeam1.ValueChanged -= eventHandler;
      this._cboUnderwritingTeam = value;
      MGASimpleComboBox underwritingTeam2 = this._cboUnderwritingTeam;
      if (underwritingTeam2 == null)
        return;
      underwritingTeam2.ValueChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("MgaCheckBox1")]
  protected virtual MGACheckBox MgaCheckBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label13")]
  protected virtual Label Label13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtEmployeeNum")]
  protected virtual MGATextBox txtEmployeeNum { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual MGACheckBox chkHideInactive
  {
    get => this._chkHideInactive;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.chkHideInactive_CheckedChanged);
      MGACheckBox chkHideInactive1 = this._chkHideInactive;
      if (chkHideInactive1 != null)
        ((UltraToggleEditorBase) chkHideInactive1).CheckedChanged -= eventHandler;
      this._chkHideInactive = value;
      MGACheckBox chkHideInactive2 = this._chkHideInactive;
      if (chkHideInactive2 == null)
        return;
      ((UltraToggleEditorBase) chkHideInactive2).CheckedChanged += eventHandler;
    }
  }

  internal virtual TextBox txtFilter
  {
    get => this._txtFilter;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.txtFilter_TextChanged);
      TextBox txtFilter1 = this._txtFilter;
      if (txtFilter1 != null)
        txtFilter1.TextChanged -= eventHandler;
      this._txtFilter = value;
      TextBox txtFilter2 = this._txtFilter;
      if (txtFilter2 == null)
        return;
      txtFilter2.TextChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("pnlFilter")]
  internal virtual Panel pnlFilter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("pnlFilterIcon")]
  internal virtual Panel pnlFilterIcon { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ToolTip1")]
  internal virtual ToolTip ToolTip1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtPhoneExtension")]
  protected virtual MGATextBox txtPhoneExtension { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public frmUsers(MGASystems.BusinessObjects.User user)
    : this(user.OfficeGuid, user.UserGuid)
  {
  }

  public frmUsers(Guid officeGuid, Guid userGuid)
    : this()
  {
    this._userGuid = userGuid;
    this._officeGuid = officeGuid;
  }

  public frmUsers(Guid officeGuid, bool createNewUser)
    : this()
  {
    this._officeGuid = officeGuid;
    this._newUserOnLoad = createNewUser;
  }

  public frmUsers()
  {
    this.Load += new EventHandler(this.frmUsers_Load);
    this.Resize += new EventHandler(this.FrmUsers_Resize);
    this._currentUserGuid = CurrentUser.Instance.UserGUID;
    this._strUserNameFirstLastName = string.Empty;
    this._allowSaveSecurity = false;
    this._allowDeleteSecurity = false;
    this.RootNodes = new List<TreeNode>();
    this.InitializeComponent();
    this.pnlFilterIcon.BackgroundImage = ImageCache.Instance.Search;
    if (LicenseManager.UsageMode == LicenseUsageMode.Runtime)
      this._bindings = new frmUsers_BindingManagement((DataSet) this.dsUser, this.BindingContext);
    this._initialized = true;
  }

  public BindingManagerBase bmb
  {
    get => this.BindingContext[(object) this.dsUser, this.dsUser.tblUsers.TableName];
  }

  public dsUser.tblUsersRow CurrentUserRow => this.dsUser.tblUsers[0];

  private void frmUsers_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    if (!SecurityManager.Instance.AssertPermission("{48AED463-E95A-468b-92C0-5ADFCDB3814D}"))
      throw new InvalidOperationException("User does not have the required security to open this form.");
    this.FillLookupTables();
    this.FillUsersTree();
    this._canEditOtherUsersInfo = SecurityManager.Instance.AssertPermission("{CF3C09E2-1F42-481e-A977-AE8B157B6C1A}");
    if (this.tvUsers.SelectedNode == null)
      this.tvUsers.SelectedNode = this.tvUsers.Nodes[0];
    this.ZipCodeResolver1.ShowGlobal = true;
    this.ZipCodeResolver1.ShowStreets = true;
    this.ZipCodeResolver1.AddressServiceURL = AddressResolverSettings.AddressResolverURL;
    this.ZipCodeResolver1.Password = AddressResolverSettings.AddressResolverPassword;
    this.ZipCodeResolver1.UserID = AddressResolverSettings.AddressResolveUserName;
    this.DbSaveUI1_UIStateChanged((object) null, (EventArgs) null);
    this.dvManagers.Table = (DataTable) this.dsUser.UserLookup;
    ((Control) this.ZipCodeResolver1).Size = new Size(328, 144 /*0x90*/);
    this.OnFormLoad();
    if (!this._userGuid.Equals(Guid.Empty))
    {
      this.LoadUser(this._userGuid);
      this.SelectUserInTree(this._userGuid);
    }
    else if (!this._officeGuid.Equals(Guid.Empty))
    {
      this.SelectOfficeInTree(this._officeGuid);
      if (this._newUserOnLoad)
      {
        this.DbSaveUI1.UIState = UIState.Editing;
        this.NewUser();
      }
    }
    ((ToolsCollectionBase) this.UltraToolbarsManager1.Tools)["Fee Viewing Rights"].SharedProps.Visible = SecurityManager.Instance.AssertPermission("{0B269EA5-EED3-4491-80B3-891DB35171EF}") && MGASystems.Common.SystemSettings.KeyExists("ImplementUserFeeRestriction") && MGASystems.Common.SystemSettings.GetBoolSetting("ImplementUserFeeRestriction");
    this._allowDeleteSecurity = SecurityManager.Instance.AssertPermission("{CA58AA4C-B044-4AE2-A791-DF2755472442}");
    this._allowSaveSecurity = SecurityManager.Instance.AssertPermission("{8021181D-4F53-4478-B390-6887E8C2EB54}");
  }

  private void SetMenuState(frmUsers.MenuState state)
  {
    ((ToolsCollectionBase) ((UltraToolbarBase) this.UltraToolbarsManager1.Toolbars[0]).Tools)[0].SharedProps.Visible = state == frmUsers.MenuState.Enabled;
    ((UltraToolbarBase) MDIControls.Instance.ToolBarManager.Toolbars[0]).UIElement.DirtyChildElements(true);
  }

  private bool IsUserInActive(Guid userGuid)
  {
    bool flag = false;
    try
    {
      foreach (DataRow row in this.dvManagers.Table.Rows)
      {
        if (userGuid.Equals((Guid) row["UserGuid"]) && (int) row["StatusID"] != 1)
        {
          flag = true;
          break;
        }
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    return flag;
  }

  private void DbSaveUI1_ClickedSave(object sender, EventArgs e)
  {
    Action action;
    // ISSUE: reference to a compiler-generated field
    if (frmUsers._Closure\u0024__.\u0024I341\u002D0 != null)
    {
      // ISSUE: reference to a compiler-generated field
      action = frmUsers._Closure\u0024__.\u0024I341\u002D0;
    }
    else
    {
      // ISSUE: reference to a compiler-generated field
      frmUsers._Closure\u0024__.\u0024I341\u002D0 = action = (Action) ([SpecialName] () => DefaultDatabase.ExecuteNonQuery(CommandType.StoredProcedure, "DocumentSystem_V2RecalculateFolderPermissions", 50000, (CommandArgumentType) 0, (object[]) null));
    }
    action.BeginInvoke((AsyncCallback) null, (object) null);
  }

  private void DbSaveUI1_ClickingEdit(object sender, CancelEventArgs e)
  {
    if (this.bmb.Position == -1)
      return;
    if (this.dsUser.tblUsers[this.bmb.Position].UserGUID.Equals(this._currentUserGuid) && !SecurityManager.Instance.AssertPermission("{C2400842-F692-4f8a-9E42-B07980F04FBB}"))
    {
      int num = (int) MessageBox.Show("You do not have permission to edit this information.", "Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      e.Cancel = true;
    }
    else if (!this.dsUser.tblUsers[this.bmb.Position].UserGUID.Equals(this._currentUserGuid) && !SecurityManager.Instance.AssertPermission("{CF3C09E2-1F42-481e-A977-AE8B157B6C1A}"))
    {
      int num = (int) MessageBox.Show("You do not have permission to edit other user's information.", "Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      e.Cancel = true;
    }
    else
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cboManagedby.Text, string.Empty, false) != 0 && !this.cboManagedby.Value.Equals((object) Guid.Empty))
        this.dvManagers.Table.DefaultView.RowFilter = !this.IsUserInActive((Guid) this.cboManagedby.Value) ? "StatusID = 1" : $"StatusID = 1 OR UserGuid = '{this.cboManagedby.Value.ToString()}'";
      this.LoadPassword();
    }
  }

  private void FillLookupTables()
  {
    MDIControls.Instance.StatusBarText = "Getting client offices...";
    DefaultDatabase.LoadDataSet((DataSet) this.dsUser, new string[4]
    {
      "tblClientOffices",
      "lstStatus",
      "UserLookup",
      "lstUnderwritingTeam"
    }, "GetUserLookupInfo");
    MGASimpleComboBox cboManagedby = this.cboManagedby;
    ((UltraGridBase) cboManagedby).DataSource = (object) this.dsUser.UserLookup;
    ((UltraDropDownBase) cboManagedby).DisplayMember = "Name";
    ((UltraDropDownBase) cboManagedby).ValueMember = "UserGuid";
    MDIControls.Instance.StatusBarText = string.Empty;
  }

  private void btnClientLoc_Click(object sender, EventArgs e)
  {
    Form form = (Form) null;
    try
    {
      form = FormSettings.ShowFormDialog(typeof (frmClientLocations));
    }
    finally
    {
      form.Dispose();
    }
  }

  private void tvUsers_AfterSelect(object sender, TreeViewEventArgs e)
  {
    if (e.Node.Parent != null)
    {
      this._officeGuid = (Guid) e.Node.Parent.Tag;
      ((ControlBase) this.lblOffice).Text = e.Node.Parent.Text;
      if (((TextEditorControlBase) this.txtLast).Text.Length != 0)
        this.SetMenuState(frmUsers.MenuState.Enabled);
      this.DbSaveUI1.UIState = UIState.HasRecordsNotEditing;
      if (!((Guid) e.Node.Tag).Equals(this._currentUserGuid) && !this._canEditOtherUsersInfo)
        this.lnkEditEmailServerInfo.Enabled = false;
      else
        this.lnkEditEmailServerInfo.Enabled = true;
      this._userGuid = (Guid) e.Node.Tag;
      this.LoadUser(this._userGuid);
    }
    else
    {
      this.SetMenuState(frmUsers.MenuState.Disabled);
      this._officeGuid = (Guid) e.Node.Tag;
      ((ControlBase) this.lblOffice).Text = e.Node.Text;
      this.DbSaveUI1.UIState = UIState.NoRecordsNotEditing;
      this.lnkEditEmailServerInfo.Enabled = false;
    }
  }

  private void FillUsersTree()
  {
    this.RootNodes.Clear();
    this.tvUsers.Nodes.Clear();
    this.dsUser.viewUsersByOffice.Clear();
    DefaultDatabase.LoadDataSet((DataSet) this.dsUser, new string[1]
    {
      "viewUsersByOffice"
    }, CommandType.Text, "SELECT UserGUID, FirstName, LastName, Location, OfficeGUID FROM viewUsersByOffice ORDER BY Location, LastName");
    string Right = string.Empty;
    TreeNode node1 = (TreeNode) null;
    TreeNode treeNode = (TreeNode) null;
    try
    {
      foreach (dsUser.viewUsersByOfficeRow row in this.dsUser.viewUsersByOffice.Rows)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(row.Location, Right, false) != 0)
        {
          node1 = new TreeNode(row.Location, 0, 0);
          this.tvUsers.Nodes.Add(node1);
          this.RootNodes.Add(node1);
          node1.Tag = (object) row.OfficeGUID;
          if (treeNode == null && row.OfficeGUID == this._officeGuid)
            treeNode = node1;
        }
        if (!row.IsUserGUIDNull())
        {
          dsUser.UserLookupRow byUserGuid = this.dsUser.UserLookup.FindByUserGUID(row.UserGUID);
          if (!((UltraToggleEditorBase) this.chkHideInactive).Checked || byUserGuid != null && byUserGuid.StatusID == 1)
          {
            TreeNode node2 = new TreeNode($"{row.LastName}, {row.FirstName}", 1, 1);
            node2.Tag = (object) row.UserGUID;
            node1.Nodes.Add(node2);
            if (row.UserGUID == this._userGuid)
              treeNode = node2;
          }
        }
        Right = row.Location;
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    this.tvUsers.ExpandAll();
    if (treeNode != null)
      this.tvUsers.SelectedNode = treeNode;
    else
      this.DbSaveUI1.UIState = UIState.NoRecordsNotEditing;
    if (string.IsNullOrEmpty(this.txtFilter.Text))
      return;
    this.txtFilter_TextChanged((object) this.txtFilter, EventArgs.Empty);
  }

  private static bool NoItemSelected(MGASimpleComboBox cbo)
  {
    return ((Control) cbo).Enabled && (((UltraDropDownBase) cbo).SelectedRow == null || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((UltraDropDownBase) cbo).SelectedRow.Cells[((UltraDropDownBase) cbo).DisplayMember].Value.ToString(), string.Empty, false) == 0);
  }

  private bool ValidateForm()
  {
    bool flag1 = true;
    this.err.SetError((Control) this.txtFirst, string.Empty);
    this.err.SetError((Control) this.txtLast, string.Empty);
    this.err.SetError((Control) this.txtUserName, string.Empty);
    this.err.SetError((Control) this.txtPassword, string.Empty);
    this.err.SetError((Control) this.cbStatus, string.Empty);
    this.err.SetError((Control) this.txtSSN, string.Empty);
    if (((TextEditorControlBase) this.txtFirst).Text.Length == 0)
    {
      this.err.SetError((Control) this.txtFirst, "Please enter the user's first name.");
      flag1 = false;
    }
    if (((TextEditorControlBase) this.txtLast).Text.Length == 0)
    {
      this.err.SetError((Control) this.txtLast, "Please enter the user's last name.");
      flag1 = false;
    }
    if (((TextEditorControlBase) this.txtUserName).Text.Length == 0)
    {
      this.err.SetError((Control) this.txtUserName, "Please enter a username for this user.");
      flag1 = false;
    }
    if (((TextEditorControlBase) this.txtPassword).Text.Length == 0)
    {
      this.err.SetError((Control) this.txtPassword, "Please enter the user's password.");
      flag1 = false;
    }
    if (frmUsers.NoItemSelected(this.cbStatus))
    {
      this.err.SetError((Control) this.cbStatus, "Please select a status for this user.");
      flag1 = false;
    }
    bool flag2 = this.txtSSN.Value.ToString().Length == 0;
    bool flag3 = this.txtSSN.Value.ToString().Length == 9;
    if (!flag3 && !flag2)
    {
      this.err.SetError((Control) this.txtSSN, "Invalid SSN");
      flag1 = false;
    }
    if (((UltraToggleEditorBase) this.chkComm).Checked && (!flag3 || flag2))
    {
      this.err.SetError((Control) this.txtSSN, "SSN required when commissions out of operating.");
      flag1 = false;
    }
    if (flag1 & !this._allowSaveSecurity)
    {
      flag1 = false;
      int num = (int) MessageBox.Show("You do not have the required security to save user info.", "Insufficient Security", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    return flag1;
  }

  private bool SaveUser()
  {
    bool flag1 = false;
    bool flag2 = false;
    bool flag3 = false;
    Guid userGuid = this.dsUser.tblUsers[this.bmb.Position].UserGUID;
    this._bindings.CurrenttblUsers.UserSignature = this.SignatureCapturePanel1.GetSignatureImageBytes();
    this.dsUser.tblUsers[this.bmb.Position]["EncryptedPassword"] = (object) new Encryption().EncryptTripleDes(this.dsUser.tblUsers[this.bmb.Position].Password);
    this.bmb.EndCurrentEdit();
    this._strUserNameFirstLastName = $"username: {this.dsUser.tblUsers[this.bmb.Position].UserName.ToString()} , last name: {this.dsUser.tblUsers[this.bmb.Position].LastName.ToString()} , first name: {this.dsUser.tblUsers[this.bmb.Position].FirstName.ToString()}";
    DataRowState rowState = this.dsUser.tblUsers[this.bmb.Position].RowState;
    if (rowState == DataRowState.Modified)
    {
      object objectValue1 = RuntimeHelpers.GetObjectValue(this.dsUser.tblUsers[this.bmb.Position]["StatusID", DataRowVersion.Original]);
      object objectValue2 = RuntimeHelpers.GetObjectValue(this.dsUser.tblUsers[this.bmb.Position]["StatusID", DataRowVersion.Current]);
      if (objectValue1 != null && objectValue2 != null)
      {
        if (Conversions.ToByte(objectValue1) != (byte) 1 && Conversions.ToByte(objectValue2) == (byte) 1)
        {
          flag1 = true;
          CurrentUser.Instance.LogAction("Administration  Menu - user management screen -  user status was changed to Active for " + this._strUserNameFirstLastName, this._userGuid, this._strUserNameFirstLastName);
        }
        if (Conversions.ToByte(objectValue1) == (byte) 1 && Conversions.ToByte(objectValue2) == (byte) 2)
        {
          flag2 = true;
          CurrentUser.Instance.LogAction("Administration  Menu - user management screen -  user status was changed to Inactive for " + this._strUserNameFirstLastName, this._userGuid, this._strUserNameFirstLastName);
        }
        if (Conversions.ToByte(objectValue1) == (byte) 1 && Conversions.ToByte(objectValue2) == (byte) 3)
        {
          flag3 = true;
          CurrentUser.Instance.LogAction("Administration  Menu - user management screen -  user status was changed from active to closed  for " + this._strUserNameFirstLastName, this._userGuid, this._strUserNameFirstLastName);
        }
      }
    }
    bool flag4;
    if (this.dsUser.UserLookup.Select($"UserName = '{((TextEditorControlBase) this.txtUserName).Text.Trim()}'").Length > 0 & this.dsUser.tblUsers[this.bmb.Position].RowState == DataRowState.Added)
    {
      int num = (int) MessageBox.Show("This user name already exists", "Duplicate User", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      flag4 = false;
    }
    else
    {
      string str = "select password from tblUsers where userGuid = @userGuid";
      if (ServerXML.UseEncryptedPasswords)
        str = "select Encryptedpassword from tblUsers where userGuid = @userGuid";
      string oldPassword = Utility.IsNull<string>(RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, str, new object[2]
      {
        (object) "@userGuid",
        (object) this.dsUser.tblUsers[this.bmb.Position].UserGUID
      })), "");
      try
      {
        if (this.dsUser.HasChanges())
        {
          if (rowState == DataRowState.Modified)
          {
            if (DefaultDatabase.ExecuteScalar<bool>(CommandType.Text, "SELECT S.Disable FROM lstStatus S INNER JOIN tblUsers U ON U.StatusID = S.StatusID WHERE U.UserGuid=@UG", new object[2]
            {
              (object) "@UG",
              (object) CurrentUser.Instance.UserGUID
            }))
            {
              int num = (int) MessageBox.Show("Your account has been disabled and edits are not allowed.", "Account Disabled", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
              flag4 = false;
              goto label_40;
            }
          }
          DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.daUsers, (DataTable) this.dsUser.tblUsers);
          CurrentUser.Instance.LogAction("Administration  Menu - user management screen -  information was modified for " + this._strUserNameFirstLastName, this._userGuid, this._strUserNameFirstLastName);
          Form[] mdiChildren = MDIControls.Instance.MDIParent.MdiChildren;
          int index = 0;
          while (index < mdiChildren.Length)
          {
            if (mdiChildren[index] is frmClientLocations frmClientLocations)
            {
              switch (rowState)
              {
                case DataRowState.Added:
                  frmClientLocations.AddToUserList(this.dsUser.tblUsers[this.bmb.Position].UserGUID, this.dsUser.tblUsers[this.bmb.Position].OfficeGUID, $"{this.dsUser.tblUsers[this.bmb.Position].LastName}, {this.dsUser.tblUsers[this.bmb.Position].FirstName}");
                  break;
                case DataRowState.Modified:
                  frmClientLocations.UpdateUserList(this.dsUser.tblUsers[this.bmb.Position].UserGUID, this.dsUser.tblUsers[this.bmb.Position].OfficeGUID, $"{this.dsUser.tblUsers[this.bmb.Position].LastName}, {this.dsUser.tblUsers[this.bmb.Position].FirstName}");
                  break;
              }
            }
            checked { ++index; }
          }
        }
        if (flag1)
        {
          DefaultDatabase.ExecuteNonQuery(CommandType.Text, "UPDATE tblUsers SET InvalidLogins = 0 WHERE UserGUID = @UG", new object[2]
          {
            (object) "@UG",
            (object) userGuid
          });
          CurrentUser.Instance.LogAction("Administration  Menu - user management screen -  User status was changed from closed to active " + this._strUserNameFirstLastName, this._userGuid, this._strUserNameFirstLastName);
        }
        this.SaveOnClient(userGuid);
        MDIControls.Instance.StatusBarText = "The user was succesfully saved.";
        if ((flag2 || flag3) && SecurityManager.Instance.AssertPermission("{57AE819E-03F0-48d6-93CB-B5451E6D186F}"))
        {
          using (FormSettings.ShowFormDialog(typeof (FormActiveUserReplace), (object) userGuid))
            ;
        }
        dsUser.tblUsersRow tblUser = this.dsUser.tblUsers[this.bmb.Position];
        if (tblUser != null)
        {
          if ((flag1 || flag2) && this.dsUser.UserLookup.FindByUserGUID(tblUser.UserGUID) != null)
          {
            dsUser.UserLookupRow byUserGuid = this.dsUser.UserLookup.FindByUserGUID(tblUser.UserGUID);
            byUserGuid.StatusID = Convert.ToInt32(tblUser.StatusID);
            byUserGuid.AcceptChanges();
          }
          UserContext context = new UserContext(this.dsUser.tblUsers[this.bmb.Position].UserGUID, Utility.IsNull<string>(RuntimeHelpers.GetObjectValue(tblUser["UserName"]), ""), Utility.IsNull<string>(RuntimeHelpers.GetObjectValue(tblUser["Password"]), ""), oldPassword, Utility.IsNull<string>(RuntimeHelpers.GetObjectValue(tblUser["FirstName"]), ""), Utility.IsNull<string>(RuntimeHelpers.GetObjectValue(tblUser["Initials"]), ""), Utility.IsNull<string>(RuntimeHelpers.GetObjectValue(tblUser["LastName"]), ""), Decimal.Compare(this.dsUser.tblUsers[this.bmb.Position].StatusID, 1M) == 0, Utility.IsNull<string>(RuntimeHelpers.GetObjectValue(tblUser["Address1"]), ""), Utility.IsNull<string>(RuntimeHelpers.GetObjectValue(tblUser["Address2"]), ""), Utility.IsNull<string>(RuntimeHelpers.GetObjectValue(tblUser["City"]), ""), Utility.IsNull<string>(RuntimeHelpers.GetObjectValue(tblUser["State"]), ""), Utility.IsNull<string>(RuntimeHelpers.GetObjectValue(tblUser["ZipCode"]), ""), Utility.IsNull<string>(RuntimeHelpers.GetObjectValue(tblUser["Phone"]), ""), Utility.IsNull<string>(RuntimeHelpers.GetObjectValue(tblUser["CellPhone"]), ""), Utility.IsNull<string>(RuntimeHelpers.GetObjectValue(tblUser["Fax"]), ""), Utility.IsNull<string>(RuntimeHelpers.GetObjectValue(tblUser["EmailAddress"]), ""), Utility.IsNull<string>(RuntimeHelpers.GetObjectValue(tblUser["HomeEmailAddress"]), ""), Utility.IsNull<string>(RuntimeHelpers.GetObjectValue(tblUser["ForeignPhone"]), ""), CurrentUser.Instance.UserName, Utility.IsNull<string>(RuntimeHelpers.GetObjectValue(tblUser["EncryptedPassword"]), ""));
          if (this._newUser)
          {
            Messaging.SendBroadcastMessage(BroadcastMessages.UserInfoAdded, (object) context);
          }
          else
          {
            Messaging.SendBroadcastMessage(BroadcastMessages.UserContactInfoUpdated, (object) context);
            Messaging.SendBroadcastMessage(BroadcastMessages.UserCredentialsUpdated, (object) context);
          }
        }
        this.LoadPassword();
        flag4 = true;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ErrorHandler.HandleError(ex);
        flag4 = false;
        ProjectData.ClearProjectError();
      }
    }
label_40:
    return flag4;
  }

  protected virtual void SaveOnClient(Guid userGuid)
  {
  }

  protected virtual void CancelOnClient()
  {
  }

  protected virtual void LoadUser(Guid userGuid)
  {
    try
    {
      this.Cursor = Cursors.WaitCursor;
      this.daUsers.SelectCommand.Parameters["@UserGuid"].Value = (object) userGuid;
      this.dsUser.tblUsers.Clear();
      DefaultDatabase.DataAdapterFill((DbDataAdapter) this.daUsers, (DataTable) this.dsUser.tblUsers);
      this.LoadPassword();
      ((Control) this.chkLoggedIn).Enabled = !userGuid.Equals(this._currentUserGuid);
      this.SetMenuState(frmUsers.MenuState.Enabled);
      try
      {
        if (!this._bindings.CurrenttblUsers.IsUserSignatureNull())
          this.SignatureCapturePanel1.SetSignatureImageBytes(this._bindings.CurrenttblUsers.UserSignature);
        else
          this.SignatureCapturePanel1.Clear();
      }
      catch (StrongTypingException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        this.SignatureCapturePanel1.Clear();
        ProjectData.ClearProjectError();
      }
    }
    finally
    {
      this.Cursor = Cursors.Default;
    }
    // ISSUE: reference to a compiler-generated field
    ISupportNoteSystem.EntityInfoChangedEventHandler infoChangedEvent = this.EntityInfoChangedEvent;
    if (infoChangedEvent != null)
      infoChangedEvent((object) this, EventArgs.Empty);
    // ISSUE: reference to a compiler-generated field
    ISupportDocumentSystem.EntityInfoChangedEventHandler infoChanged1Event = this.EntityInfoChanged1Event;
    if (infoChanged1Event == null)
      return;
    infoChanged1Event((object) this, EventArgs.Empty);
  }

  private void LoadPassword()
  {
    if (!ServerXML.UseEncryptedPasswords)
      return;
    this.dsUser.tblUsers[this.bmb.Position]["Password"] = (object) new Encryption().DecryptTripleDes(this.dsUser.tblUsers[this.bmb.Position]["EncryptedPassword"].ToString());
    this.dsUser.tblUsers.AcceptChanges();
  }

  protected virtual void SelectUserInTree(Guid userGuid)
  {
    try
    {
      foreach (TreeNode node1 in this.tvUsers.Nodes)
      {
        try
        {
          foreach (TreeNode node2 in node1.Nodes)
          {
            if (((Guid) node2.Tag).Equals(userGuid))
            {
              this.tvUsers.SelectedNode = node2;
              node1.Expand();
              ((ControlBase) this.lblOffice).Text = node1.Text;
              return;
            }
          }
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    if (this.DbSaveUI1.UIState == UIState.Editing)
      return;
    this.DbSaveUI1.UIState = UIState.HasRecordsNotEditing;
  }

  private void SelectOfficeInTree(Guid officeGuid)
  {
    try
    {
      foreach (TreeNode node in this.tvUsers.Nodes)
      {
        if (((Guid) node.Tag).Equals(officeGuid))
        {
          this.tvUsers.SelectedNode = node;
          node.Expand();
          ((ControlBase) this.lblOffice).Text = node.Text;
          return;
        }
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    this.DbSaveUI1.UIState = UIState.NoRecordsNotEditing;
  }

  private void UltraToolbarsManager1_ToolClick(object sender, ToolClickEventArgs e)
  {
    if (this.dsUser.tblUsers.Rows.Count > 0 && this.dsUser.tblUsers[this.bmb.Position].RowState == DataRowState.Added)
    {
      int num1 = (int) MessageBox.Show("Please save your changes before continuing.", "Save Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else
    {
      if (this.bmb.Position < 0)
        return;
      this._userGuid = this.dsUser.tblUsers[this.bmb.Position].UserGUID;
      string key = ((ToolEventArgs) e).Tool.Key;
      // ISSUE: reference to a compiler-generated method
      switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(key))
      {
        case 716961717:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Licenses", false) == 0)
          {
            FormSettings.ShowForm(typeof (frmUserLicense), (object) this._userGuid);
            return;
          }
          break;
        case 1126466859:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Policy Viewing Rights", false) == 0)
          {
            if (SecurityManager.Instance.AssertPermission("{13227AB4-1F29-40E2-94BA-F94AFE8CB885}"))
            {
              Form formEx = ObjectFactory.Instance.CreateFormEX(typeof (FormPolicyViewingRights), (object) this._userGuid);
              formEx.MdiParent = MDIControls.Instance.MDIParent;
              formEx.Show();
              return;
            }
            int num2 = (int) MessageBox.Show("You do not have the required security for access.", "Insufficient Security", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            return;
          }
          break;
        case 1746714643:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Assign Producer Contacts", false) == 0)
          {
            FormSettings.ShowForm(typeof (frmUsersProducerContacts), (object) new MGASystems.BusinessObjects.User(this._userGuid).UserID);
            return;
          }
          break;
        case 2197933745:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Issuing Office Viewing Rights", false) == 0)
          {
            if (SecurityManager.Instance.AssertPermission("{13227AB4-1F29-40E2-94BA-F94AFE8CB885}"))
            {
              FormSettings.ShowForm(typeof (FormIssuingOfficeViewingRights), (object) this._userGuid);
              return;
            }
            int num3 = (int) MessageBox.Show("You do not have the required security for access.", "Insufficient Security", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            return;
          }
          break;
        case 2316959964:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Lines", false) == 0)
          {
            FormSettings.ShowForm(typeof (frmUserLines), (object) this._userGuid, (object) $"{((TextEditorControlBase) this.txtFirst).Text} {((TextEditorControlBase) this.txtLast).Text}");
            return;
          }
          break;
        case 2703868198:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Company Viewing Rights", false) == 0)
          {
            FormSettings.ShowForm(typeof (frmUserCompanyViewingRights), (object) this._userGuid);
            return;
          }
          break;
        case 3023206074:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Quoting Office Viewing Rights", false) == 0)
          {
            if (SecurityManager.Instance.AssertPermission("{87BEE935-5205-427f-9630-9C342E4ABE7E}"))
            {
              FormSettings.ShowForm(typeof (FormQuotingOfficeViewingRights), (object) this._userGuid);
              return;
            }
            int num4 = (int) MessageBox.Show("You do not have the required security for access.", "Insufficient Security", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            return;
          }
          break;
        case 3038836047:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "User Types", false) == 0)
          {
            FormSettings.ShowForm(typeof (frmUserTypes), (object) new MGASystems.BusinessObjects.User(this._userGuid).UserID);
            return;
          }
          break;
        case 3068235343:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Fee Viewing Rights", false) == 0)
          {
            if (SecurityManager.Instance.AssertPermission("{0B269EA5-EED3-4491-80B3-891DB35171EF}"))
            {
              FormSettings.ShowForm(typeof (FormFeeViewingRights), (object) this._userGuid);
              return;
            }
            int num5 = (int) MessageBox.Show("You do not have the required security for access.", "Insufficient Security", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            return;
          }
          break;
        case 3683957585:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Insured Viewing Rights", false) == 0)
          {
            if (SecurityManager.Instance.AssertPermission("{0BC4F32D-9489-4373-B358-B9E16EFA5883}"))
            {
              FormSettings.ShowForm(typeof (FormInsuredViewingRights), (object) this._userGuid);
              return;
            }
            int num6 = (int) MessageBox.Show("You do not have the required security for access.", "Insufficient Security", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            return;
          }
          break;
        case 3771280718:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "User Goals", false) == 0)
          {
            FormSettings.ShowForm(typeof (FormUserGoals), (object) this._userGuid);
            return;
          }
          break;
        case 4002962920:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Producer Location View Rights ...", false) == 0)
          {
            if (SecurityManager.Instance.AssertPermission("{305A65F9-B018-4c54-990D-F39BF27E4203}"))
            {
              FormSettings.ShowForm(typeof (FormProducerLocationViewingRights), (object) this._userGuid);
              return;
            }
            int num7 = (int) MessageBox.Show("You do not have the required security for access.", "Insufficient Security", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            return;
          }
          break;
        case 4096575763:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Viewing Rights", false) == 0)
          {
            object objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT UserID FROM tblUsers WHERE UserGuid=@UserGuid", new object[2]
            {
              (object) "@UserGuid",
              (object) this._userGuid
            }));
            if (objectValue == null || objectValue == DBNull.Value)
              return;
            FormSettings.ShowForm(typeof (frmUserViewingRights), (object) Conversions.ToInteger(objectValue));
            return;
          }
          break;
      }
      this.HandleClientClicks(this._userGuid, RuntimeHelpers.GetObjectValue(sender), e);
    }
  }

  private void DbSaveUI1_ClickingSave(object sender, CancelEventArgs e)
  {
    if (this.ValidateForm())
    {
      if (this.SaveUser())
      {
        if (this._newUserOnLoad || this._newUser)
        {
          int num = (int) DefaultDatabase.ExecuteScalar<short>(CommandType.Text, "SELECT UserID FROM tblUsers WHERE UserGuid=@UserGuid", new object[2]
          {
            (object) "@UserGuid",
            (object) this.dsUser.tblUsers[0].UserGUID
          });
          DataTable dataTable = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT UserID FROM tblUsers");
          string empty = string.Empty;
          if (MessageBox.Show($"Allow all users rights to see quotes produced by {((TextEditorControlBase) this.txtLast).Text},{((TextEditorControlBase) this.txtFirst).Text}?", "Show Quotes?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
          {
            CurrentUser.Instance.LogAction($"Administration  Menu - user management screen -  Inserted a new user and allowed rights for all users to see quotes produced by the new user.  New user:  {this._strUserNameFirstLastName}, new user id: {Conversions.ToString(num)}", this.dsUser.tblUsers[0].UserGUID, this._strUserNameFirstLastName);
            try
            {
              foreach (DataRow row in dataTable.Rows)
                DefaultDatabase.ExecuteNonQuery(CommandType.Text, "INSERT INTO tblUserViewingRights(UserID, ViewUserID) VALUES( @uID, @ViewUserID)", new object[4]
                {
                  (object) "@ViewUserID",
                  (object) num,
                  (object) "@uID",
                  (object) (short) row[0]
                });
            }
            finally
            {
              IEnumerator enumerator;
              if (enumerator is IDisposable)
                (enumerator as IDisposable).Dispose();
            }
          }
          if (MessageBox.Show("Do you want this user To be able To see quotes produced by all the other users?", "Allow New User To See Quotes Produced By All", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
          {
            CurrentUser.Instance.LogAction($"Administration  Menu - user management screen -  Inserted a new user and allowed this new user to see quotes produced by all.  The new user: {this._strUserNameFirstLastName}, new user id: {Conversions.ToString(num)}", this.dsUser.tblUsers[0].UserGUID, this._strUserNameFirstLastName);
            try
            {
              foreach (DataRow row in dataTable.Rows)
                DefaultDatabase.ExecuteNonQuery(CommandType.Text, "INSERT INTO tblUserViewingRights(UserID, ViewUserID) VALUES(@ViewUserID, @uID)", new object[4]
                {
                  (object) "@ViewUserID",
                  (object) num,
                  (object) "@uID",
                  (object) (short) row[0]
                });
            }
            finally
            {
              IEnumerator enumerator;
              if (enumerator is IDisposable)
                (enumerator as IDisposable).Dispose();
            }
          }
        }
        this.tvUsers.AfterSelect -= new TreeViewEventHandler(this.tvUsers_AfterSelect);
        try
        {
          this.FillUsersTree();
          this.SelectUserInTree(this._userGuid);
        }
        finally
        {
          this.tvUsers.AfterSelect += new TreeViewEventHandler(this.tvUsers_AfterSelect);
        }
        this._newUser = false;
      }
      else
        e.Cancel = true;
    }
    else
      e.Cancel = true;
    this.dvManagers.Table.DefaultView.RowFilter = "";
  }

  private void DbSaveUI1_ClickingNew(object sender, CancelEventArgs e)
  {
    if (!this._allowSaveSecurity)
    {
      int num = (int) MessageBox.Show("Cannot perform this operation because you do not have the required security to save user info", "Insufficient Security", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      e.Cancel = true;
    }
    else
    {
      this._newUser = true;
      this.NewUser();
      this.dvManagers.Table.DefaultView.RowFilter = "StatusID = 1";
    }
  }

  protected virtual void NewUser()
  {
    try
    {
      this.dsUser.tblUsers.Clear();
      dsUser.tblUsersRow row = this.dsUser.tblUsers.NewtblUsersRow();
      row.OfficeGUID = this._officeGuid;
      row.UserGUID = Guid.NewGuid();
      this.dsUser.tblUsers.AddtblUsersRow(row);
      this.SetMenuState(frmUsers.MenuState.Enabled);
      DefaultDatabase.LoadDataSet((DataSet) this.dsUser, new string[1]
      {
        "UserLookup"
      }, CommandType.Text, "SELECT UserGuid, LastName + @C + FirstName AS Name, UserName, StatusID FROM tblUsers", new object[2]
      {
        (object) "@C",
        (object) ", "
      });
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ErrorHandler.HandleError(ex);
      ProjectData.ClearProjectError();
    }
  }

  private void DbSaveUI1_ClickingCancel(object sender, CancelEventArgs e)
  {
    if (this.bmb.Position == -1)
      return;
    if (this.dsUser.tblUsers[this.bmb.Position].RowState == DataRowState.Added)
    {
      this.dsUser.tblUsers.RemovetblUsersRow(this.dsUser.tblUsers[this.bmb.Position]);
      this.bmb.Position = 0;
    }
    else
      this.dsUser.tblUsers[this.bmb.Position].RejectChanges();
    this.err.SetError((Control) this.txtFirst, string.Empty);
    this.err.SetError((Control) this.txtLast, string.Empty);
    this.err.SetError((Control) this.txtUserName, string.Empty);
    this.err.SetError((Control) this.txtPassword, string.Empty);
    this.err.SetError((Control) this.cbStatus, string.Empty);
    this.dvManagers.Table.DefaultView.RowFilter = "";
    this._newUser = false;
    this.CancelOnClient();
  }

  private void DbSaveUI1_ClickingDelete(object sender, CancelEventArgs e)
  {
    if (!this._allowDeleteSecurity)
    {
      int num = (int) MessageBox.Show("You do not have the required security to Delete user info.", "Insufficient Security", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      e.Cancel = true;
    }
    else if (this.tvUsers.SelectedNode.Parent != null || this.dsUser.tblUsers.Count == 0)
    {
      if (MessageBox.Show("Are you sure you want do delete this item?", "Delete Item?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
      {
        try
        {
          this.bmb.EndCurrentEdit();
          if (this.dsUser.tblUsers[0] == null)
            return;
          Guid userGuid = this.dsUser.tblUsers[0].UserGUID;
          string context = $" username: {this.dsUser.tblUsers[0].UserName} , lastname:{this.dsUser.tblUsers[0].LastName} , firstname: {this.dsUser.tblUsers[0].FirstName}";
          this.dsUser.tblUsers.FindByUserGUID(userGuid).Delete();
          DefaultDatabase.ExecuteNonQuery("dbo.spDeleteUserRelatedInfo", new object[2]
          {
            (object) "@UserGUID",
            (object) userGuid
          });
          CurrentUser.Instance.LogAction("Administration  Menu - user management screen -  following user was deleted: " + context, this._userGuid, context);
          DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.daUsers, (DataTable) this.dsUser.tblUsers);
          this.bmb.Position = 0;
          this.tvUsers.SelectedNode.Remove();
          Form[] mdiChildren = MDIControls.Instance.MDIParent.MdiChildren;
          int index = 0;
          while (index < mdiChildren.Length)
          {
            if (mdiChildren[index] is frmClientLocations frmClientLocations)
              frmClientLocations.DeleteFromUserList(userGuid);
            checked { ++index; }
          }
        }
        catch (SqlException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          this.MessageBoxErrorMessage(ex);
          ProjectData.ClearProjectError();
        }
        catch (IndexOutOfRangeException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          int num = (int) MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          ProjectData.ClearProjectError();
        }
      }
      else
        e.Cancel = true;
    }
    else
    {
      int num1 = (int) MessageBox.Show("You can only delete users from this screen.", "Cannot Delete", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
  }

  private void MessageBoxErrorMessage(SqlException ex)
  {
    if (ex.Message.Contains("FK_tblLog_tblUsers"))
    {
      int num1 = (int) MessageBox.Show("This user has associated entries in the IMS log and cannot be deleted.\n\nPlease set the user as 'Closed' or 'Inactive'.", "Cannot Delete", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else if (ex.Message.Contains("FK_tblQuotes_tblUsers2"))
    {
      int num2 = (int) MessageBox.Show("This user has issued a policy in the IMS and cannot be deleted.\n\nPlease set the user as 'Closed' or 'Inactive'.", "Cannot Delete", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else if (ex.Message.Contains("FK_tblQuotes_tblUsers1"))
    {
      int num3 = (int) MessageBox.Show("This user has bound a policy in the IMS and cannot be deleted.\n\nPlease set the user as 'Closed' or 'Inactive'.", "Cannot Delete", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else if (ex.Message.Equals("FK_tblQuotes_tblUsers"))
    {
      int num4 = (int) MessageBox.Show("This user is an underwriter on a policy in the IMS and cannot be deleted.\n\nPlease set the user as 'Closed' or 'Inactive'.", "Cannot Delete", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else if (ex.Message.Contains("FK_tblAdminCommissions"))
    {
      int num5 = (int) MessageBox.Show("This user is an underwriter, in-house producer or creator of an admin commissions and cannot be deleted.\n\nPlease set the user as 'Closed' or 'Inactive'.", "Cannot Delete", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else if (ex.Message.Contains("FK_tblSubmissionGroup_tblUser"))
    {
      int num6 = (int) MessageBox.Show("This user is logged as an underwriter, TACSR or creator of a submission in the IMS and cannot be deleted.\n\nPlease set the user as 'Closed' or 'Inactive'.", "Cannot Delete", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else if (ex.Message.Contains("FK_tblNoteEntries_tblUsers"))
    {
      int num7 = (int) MessageBox.Show("This user is associated to note entries in the IMS and cannot be deleted.\n\nPlease set the user as 'Closed' or 'Inactive'.", "Cannot Delete", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else if (ex.Message.Contains("FK_tblNoteRecipients_tblUsers"))
    {
      int num8 = (int) MessageBox.Show("This user is a recipient on note entries in the IMS and cannot be deleted.\n\nPlease set the user as 'Closed' or 'Inactive'.", "Cannot Delete", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else
    {
      int num9 = (int) MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
  }

  private void DbSaveUI1_UIStateChanged(object sender, EventArgs e)
  {
    foreach (UltraTab tab in ((UltraTabControlBase) this.UltraTabControl1).Tabs)
    {
      try
      {
        foreach (Control control in ((Control) tab.TabPage).Controls)
          control.Enabled = this.DbSaveUI1.UIState == UIState.Editing;
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
    this.tvUsers.Enabled = this.DbSaveUI1.UIState != UIState.Editing;
  }

  private void tvUsers_EnabledChanged(object sender, EventArgs e)
  {
    if (!this.tvUsers.Enabled)
      return;
    if (this.tvUsers.SelectedNode != null && this.tvUsers.SelectedNode.Parent == null)
      this.DbSaveUI1.UIState = UIState.NoRecordsNotEditing;
    else
      this.DbSaveUI1.UIState = UIState.HasRecordsNotEditing;
  }

  private void lnkEditEmailServerInfo_Click(object sender, EventArgs e)
  {
    FormSettings.ShowForm(typeof (frmEmailInfo), (object) this._userGuid);
  }

  bool IRecreatableEntity.CanReCreateEntity => false;

  bool IRecreatableEntity.RecreateEntityInitialize(Guid entityGuid)
  {
    bool flag;
    return flag;
  }

  string IRecreatableEntity.FriendlyEntityName => "User";

  string IRecreatableEntity.RecreateTypeName => typeof (frmUsers).ToString();

  public bool CanCreateNewNote
  {
    get
    {
      return this.dsUser.tblUsers.Rows.Count != 0 && (this.CurrentUserRow.RowState == DataRowState.Deleted || !this.CurrentUserRow.IsFirstNameNull() && !this.CurrentUserRow.IsLastNameNull()) && this.dsUser.tblUsers.Rows.Count > 0;
    }
  }

  string IRecreatableEntity.EntityName
  {
    get
    {
      return this.dsUser.tblUsers.Rows.Count <= 0 || this.CurrentUserRow.IsFirstNameNull() || this.CurrentUserRow.IsLastNameNull() ? "User" : $"{this.CurrentUserRow.FirstName} {this.CurrentUserRow.LastName}";
    }
  }

  Guid IRecreatableEntity.ControlGUID => Guid.Empty;

  bool IRecreatableEntity.HasControlGUID => false;

  Guid IRecreatableEntity.EntityGuid
  {
    get
    {
      Guid entityGuid;
      try
      {
        entityGuid = this.CurrentUserRow.RowState == DataRowState.Unchanged || this.CurrentUserRow.RowState == DataRowState.Modified ? this.CurrentUserRow.UserGUID : new Guid();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        entityGuid = new Guid();
        ProjectData.ClearProjectError();
      }
      return entityGuid;
    }
  }

  public event ISupportNoteSystem.EntityInfoChangedEventHandler EntityInfoChanged;

  public bool AllowAddNewDocument => this.CanCreateNewNote;

  public event ISupportDocumentSystem.EntityInfoChangedEventHandler EntityInfoChanged1;

  private void tvUsers_Click(object sender, EventArgs e)
  {
    TreeNode nodeAt = this.tvUsers.GetNodeAt(this.tvUsers.PointToClient(Cursor.Position));
    if (nodeAt == null || this.tvUsers.SelectedNode == nodeAt)
      return;
    this.tvUsers.SelectedNode = nodeAt;
  }

  private void ctxSecurity_Popup(object sender, EventArgs e)
  {
    ContextMenu contextMenu = (ContextMenu) sender;
    if (contextMenu.MenuItems.Count > 0)
    {
      try
      {
        foreach (MenuItem menuItem in contextMenu.MenuItems)
          menuItem.Click -= new EventHandler(this.SecurityMenuItem_Click);
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
    contextMenu.MenuItems.Clear();
    TreeNode nodeAt = this.tvUsers.GetNodeAt(this.tvUsers.PointToClient(Cursor.Position));
    if (nodeAt == null || nodeAt.Parent == null || !SecurityManager.Instance.AssertPermission("{FB48ED71-E202-4bfc-9111-8DAC4DDCAEB2}"))
      return;
    this._userGuid = (Guid) nodeAt.Tag;
    DataTable dataTable = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT dbo.tblSecurityGroups.GroupGUID, dbo.tblSecurityGroups.Name, CASE WHEN EXISTS ( \tSELECT GroupGUID \tFROM tblSecurityUserGroups \tWHERE UserGuid = @UserGUID \tAND dbo.tblSecurityGroups.GroupGUID = tblSecurityUserGroups.GroupGUID ) THEN 1 ELSE 0 END AS UserInGroup FROM dbo.tblSecurityGroups ", new object[2]
    {
      (object) "@UserGUID",
      (object) this._userGuid
    });
    try
    {
      foreach (DataRow row in dataTable.Rows)
      {
        string text = Conversions.ToString(row["Name"]);
        object obj = row["GroupGUID"];
        Guid groupGuid = obj != null ? (Guid) obj : new Guid();
        bool boolean = Conversions.ToBoolean(row["UserInGroup"]);
        frmUsers.MenuItemEx menuItemEx = new frmUsers.MenuItemEx(text, groupGuid, this._userGuid);
        menuItemEx.Checked = boolean;
        menuItemEx.Click += new EventHandler(this.SecurityMenuItem_Click);
        contextMenu.MenuItems.Add((MenuItem) menuItemEx);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void SecurityMenuItem_Click(object sender, EventArgs e)
  {
    frmUsers.MenuItemEx menuItemEx = (frmUsers.MenuItemEx) sender;
    if (SecurityManager.Instance.AssertPermission("{FE820AC1-6427-49b7-AB0E-5123D75851B5}"))
    {
      string str1 = string.Empty;
      if (!this.dsUser.tblUsers.FindByUserGUID(menuItemEx.UserGuid).IsFirstNameNull())
        str1 = this.dsUser.tblUsers.FindByUserGUID(menuItemEx.UserGuid).FirstName;
      if (!this.dsUser.tblUsers.FindByUserGUID(menuItemEx.UserGuid).IsLastNameNull())
        str1 = $"{str1} {this.dsUser.tblUsers.FindByUserGUID(menuItemEx.UserGuid).LastName}";
      bool flag = true;
      string str2;
      if (menuItemEx.Checked)
      {
        flag = false;
        str2 = "DELETE FROM tblSecurityUserGroups WHERE UserGuid = @UserGuid AND GroupGuid = @GroupGuid";
      }
      else
        str2 = "INSERT INTO tblSecurityUserGroups (UserGuid, GroupGuid) VALUES (@UserGuid, @GroupGuid)";
      DefaultDatabase.ExecuteNonQuery(CommandType.Text, str2, new object[4]
      {
        (object) "@UserGuid",
        (object) menuItemEx.UserGuid,
        (object) "@GroupGuid",
        (object) menuItemEx.GroupGuid
      });
      if (flag)
        CurrentUser.Instance.LogAction($"Administration Menu. User management. Added user '{str1}' to security group:{menuItemEx.Text}", menuItemEx.UserGuid);
      else
        CurrentUser.Instance.LogAction($"Administration Menu. User management. Removed user '{str1}' from security group: {menuItemEx.Text}", menuItemEx.UserGuid);
    }
    else
    {
      int num = (int) MessageBox.Show("You currently do not have permission to add or remove users from security groups", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
  }

  protected virtual void HandleClientClicks(Guid userGuid, object sender, ToolClickEventArgs e)
  {
  }

  protected virtual void OnFormLoad()
  {
  }

  private void chkHideInactive_CheckedChanged(object sender, EventArgs e)
  {
    if (!this._initialized)
      return;
    this.FillUsersTree();
  }

  private void txtFilter_TextChanged(object sender, EventArgs e)
  {
    this.tvUsers.BeginUpdate();
    this.tvUsers.Nodes.Clear();
    if (string.IsNullOrEmpty(this.txtFilter.Text))
    {
      this.tvUsers.Nodes.AddRange(this.RootNodes.ToArray());
    }
    else
    {
      List<TreeNode> rootNodes = this.RootNodes;
      System.Func<TreeNode, IEnumerable<TreeNode>> selector;
      // ISSUE: reference to a compiler-generated field
      if (frmUsers._Closure\u0024__.\u0024I401\u002D0 != null)
      {
        // ISSUE: reference to a compiler-generated field
        selector = frmUsers._Closure\u0024__.\u0024I401\u002D0;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        frmUsers._Closure\u0024__.\u0024I401\u002D0 = selector = (System.Func<TreeNode, IEnumerable<TreeNode>>) ([SpecialName] (nc) => nc.Nodes.Cast<TreeNode>());
      }
      List<TreeNode> list = rootNodes.SelectMany<TreeNode, TreeNode>(selector).Where<TreeNode>((System.Func<TreeNode, bool>) ([SpecialName] (tn) => tn.Text.IndexOf(this.txtFilter.Text, StringComparison.CurrentCultureIgnoreCase) > -1)).ToList<TreeNode>();
      try
      {
        List<TreeNode> source = list;
        System.Func<TreeNode, TreeNode> keySelector;
        // ISSUE: reference to a compiler-generated field
        if (frmUsers._Closure\u0024__.\u0024I401\u002D2 != null)
        {
          // ISSUE: reference to a compiler-generated field
          keySelector = frmUsers._Closure\u0024__.\u0024I401\u002D2;
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          frmUsers._Closure\u0024__.\u0024I401\u002D2 = keySelector = (System.Func<TreeNode, TreeNode>) ([SpecialName] (tn) => tn.Parent);
        }
        foreach (IGrouping<TreeNode, TreeNode> grouping in source.GroupBy<TreeNode, TreeNode>(keySelector))
        {
          TreeNode node = new TreeNode(grouping.Key.Text, 0, 0);
          node.Tag = RuntimeHelpers.GetObjectValue(grouping.Key.Tag);
          try
          {
            foreach (TreeNode treeNode in (IEnumerable<TreeNode>) grouping)
              node.Nodes.Add(new TreeNode(treeNode.Text, 1, 1)
              {
                Tag = RuntimeHelpers.GetObjectValue(treeNode.Tag)
              });
          }
          finally
          {
            IEnumerator<TreeNode> enumerator;
            enumerator?.Dispose();
          }
          this.tvUsers.Nodes.Add(node);
        }
      }
      finally
      {
        IEnumerator<IGrouping<TreeNode, TreeNode>> enumerator;
        enumerator?.Dispose();
      }
    }
    this.tvUsers.ExpandAll();
    this.tvUsers.EndUpdate();
  }

  private void cboUnderwritingTeam_ValueChanged(object sender, EventArgs e)
  {
    this.ToolTip1.RemoveAll();
    if (this.cboUnderwritingTeam.SelectedIndex <= -1)
      return;
    this.ToolTip1.SetToolTip((Control) this.cboUnderwritingTeam, this.cboUnderwritingTeam.Text);
  }

  protected virtual void FrmUsers_Resize(object sender, EventArgs e)
  {
  }

  private enum MenuState
  {
    Enabled,
    Disabled,
  }

  private class MenuItemEx : MenuItem
  {
    private Guid _groupGuid;
    private Guid _userGuid;

    public MenuItemEx(string text, Guid groupGuid, Guid userGuid)
      : base(text)
    {
      this._groupGuid = groupGuid;
      this._userGuid = userGuid;
    }

    public Guid UserGuid => this._userGuid;

    public Guid GroupGuid => this._groupGuid;
  }
}
