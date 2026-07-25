// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Security.FormAdminSecurityUsers
// Assembly: MgaSystems.IMS.Security, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: A5FACEA8-628E-4FEB-97EB-CBBA0F666906
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Security.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinToolbars;
using MGASystems.Common;
using MGASystems.Common.DataAccess;
using MGASystems.Data;
using MGASystems.Tools;
using MGASystems.Tools.BaseClasses;
using Microsoft.VisualBasic;
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
using System.Text;
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Security;

[SecureResource("{FB48ED71-E202-4bfc-9111-8DAC4DDCAEB2}", "Access Security Administration Screen", "Controls Access to the security administration screen.", "Security Administration")]
[SecureResource("{4505EA7A-68FA-4488-A824-BAC819D040DC}", "Group Administration", "Controls ability to add/delete security groups.", "Security Administration")]
[SecureResource("{FE820AC1-6427-49b7-AB0E-5123D75851B5}", "View group / User Properties", "Controls the ability to view the security attributes applied at the user and group level.", "Security Administration")]
[SecureResource("{8A5A4DD8-9A47-4c18-87FF-1530229CCE82}", "Grant/Deny Resource Permissions", "Controls the ability of the user to grant and deny permissions on various IMS resources.", "Security Administration")]
[SecureResource("{5C9F26FC-90F6-4561-B556-A0150DEDC8BC}", "Import Export Security Schemas", "Controls the ability of the user to import and export the system security schema.", "Security Administration")]
public sealed class FormAdminSecurityUsers : MGABaseForm, IComparer
{
  public const string SecurityIdViewForm = "{FB48ED71-E202-4bfc-9111-8DAC4DDCAEB2}";
  public const string SecurityIdCreateDeleteGroups = "{4505EA7A-68FA-4488-A824-BAC819D040DC}";
  public const string SecurityIdViewGroupUserProps = "{FE820AC1-6427-49b7-AB0E-5123D75851B5}";
  public const string SecurityIdGrantDenyPermissions = "{8A5A4DD8-9A47-4c18-87FF-1530229CCE82}";
  public const string SecurityIdImportExportSecuritySchemas = "{5C9F26FC-90F6-4561-B556-A0150DEDC8BC}";
  private IContainer components;
  private ImageList imgSmall;
  private SqlDataAdapter daGroups;
  private SqlConnection cnSQL;
  private Label Label1;
  private Label Label2;
  private Label Label3;
  private Label Label4;
  private Label Label6;
  private Panel pnlResources;
  private Panel pnlPermResources;
  private Panel Panel4;
  private Splitter Splitter1;
  private Panel pnlRightSplit;
  private ColumnHeader ColumnHeader1;
  private ColumnHeader ColumnHeader2;
  private SqlDataAdapter daUsers;
  private SqlCommand SqlSelectCommand2;
  private ColumnHeader ColumnHeader3;
  private ColumnHeader ColumnHeader4;
  private ColumnHeader ColumnHeader5;
  private SqlCommand SqlSelectCommand1;
  private SqlCommand SqlInsertCommand1;
  private SqlCommand SqlUpdateCommand1;
  private SqlCommand SqlDeleteCommand1;
  private Label lblResourceInfo;
  private ToolTip ToolTip1;
  private MenuItem mnuSeperator;
  private UltraToolbarsDockArea _FormAdminSecurityUsers_Toolbars_Dock_Area_Left;
  private UltraToolbarsDockArea _FormAdminSecurityUsers_Toolbars_Dock_Area_Right;
  private UltraToolbarsDockArea _FormAdminSecurityUsers_Toolbars_Dock_Area_Top;
  private UltraToolbarsDockArea _FormAdminSecurityUsers_Toolbars_Dock_Area_Bottom;
  private MGACheckBox chkShowUsers;
  private Size _pnlGroupUsersOriginalSize;
  private bool _groupsLoaded;
  private bool _usersLoaded;
  private Dictionary<string, string> _groupHash;
  private Dictionary<string, FormAdminSecurityUsers.ResourceListItem> _resourceListItemHash;
  private bool _resourceListFilled;
  private Guid _adminGroupGuid;
  private Dictionary<Guid, string> _externalResources;
  private ListViewItem _lastSelectedGroupItem;
  private bool selIndexChanging;

  internal virtual BackgroundWorker BackgroundWorker
  {
    get => this._BackgroundWorker;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      DoWorkEventHandler workEventHandler = new DoWorkEventHandler(this.BackgroundWorker_DoWork);
      RunWorkerCompletedEventHandler completedEventHandler = new RunWorkerCompletedEventHandler(this.BackgroundWorker_RunWorkerCompleted);
      BackgroundWorker backgroundWorker1 = this._BackgroundWorker;
      if (backgroundWorker1 != null)
      {
        backgroundWorker1.DoWork -= workEventHandler;
        backgroundWorker1.RunWorkerCompleted -= completedEventHandler;
      }
      this._BackgroundWorker = value;
      BackgroundWorker backgroundWorker2 = this._BackgroundWorker;
      if (backgroundWorker2 == null)
        return;
      backgroundWorker2.DoWork += workEventHandler;
      backgroundWorker2.RunWorkerCompleted += completedEventHandler;
    }
  }

  [field: AccessedThroughProperty("pnlLoad")]
  internal virtual Panel pnlLoad { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PictureBox1")]
  internal virtual PictureBox PictureBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label5")]
  internal virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public FormAdminSecurityUsers()
  {
    this.Load += new EventHandler(this.FormAdminSecurityUsers_Load);
    this.InitializeComponent();
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [field: AccessedThroughProperty("imgLarge")]
  private virtual ImageList imgLarge { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("DsSecurityManagement")]
  private virtual dsSecurityManagement DsSecurityManagement { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual ListView lvGroups
  {
    get => this._lvGroups;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.lvGroups_SelectedIndexChanged);
      MouseEventHandler mouseEventHandler = new MouseEventHandler(this.lvGroups_MouseUp);
      EventHandler eventHandler2 = new EventHandler(this.lvGroups_DoubleClick);
      ListView lvGroups1 = this._lvGroups;
      if (lvGroups1 != null)
      {
        lvGroups1.SelectedIndexChanged -= eventHandler1;
        lvGroups1.MouseUp -= mouseEventHandler;
        lvGroups1.DoubleClick -= eventHandler2;
      }
      this._lvGroups = value;
      ListView lvGroups2 = this._lvGroups;
      if (lvGroups2 == null)
        return;
      lvGroups2.SelectedIndexChanged += eventHandler1;
      lvGroups2.MouseUp += mouseEventHandler;
      lvGroups2.DoubleClick += eventHandler2;
    }
  }

  private virtual MGAButton btnNewGroup
  {
    get => this._btnNewGroup;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnNewGroup_Click);
      MGAButton btnNewGroup1 = this._btnNewGroup;
      if (btnNewGroup1 != null)
        ((Control) btnNewGroup1).Click -= eventHandler;
      this._btnNewGroup = value;
      MGAButton btnNewGroup2 = this._btnNewGroup;
      if (btnNewGroup2 == null)
        return;
      ((Control) btnNewGroup2).Click += eventHandler;
    }
  }

  private virtual MGAButton btnDeleteGroup
  {
    get => this._btnDeleteGroup;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnDeleteGroup_Click);
      MGAButton btnDeleteGroup1 = this._btnDeleteGroup;
      if (btnDeleteGroup1 != null)
        ((Control) btnDeleteGroup1).Click -= eventHandler;
      this._btnDeleteGroup = value;
      MGAButton btnDeleteGroup2 = this._btnDeleteGroup;
      if (btnDeleteGroup2 == null)
        return;
      ((Control) btnDeleteGroup2).Click += eventHandler;
    }
  }

  private virtual Panel pnlGroupUsers
  {
    get => this._pnlGroupUsers;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.pnlGroupUsers_SizeChanged);
      MouseEventHandler mouseEventHandler = new MouseEventHandler(this.pnlGroupUsers_MouseDown);
      Panel pnlGroupUsers1 = this._pnlGroupUsers;
      if (pnlGroupUsers1 != null)
      {
        pnlGroupUsers1.SizeChanged -= eventHandler;
        pnlGroupUsers1.MouseDown -= mouseEventHandler;
      }
      this._pnlGroupUsers = value;
      Panel pnlGroupUsers2 = this._pnlGroupUsers;
      if (pnlGroupUsers2 == null)
        return;
      pnlGroupUsers2.SizeChanged += eventHandler;
      pnlGroupUsers2.MouseDown += mouseEventHandler;
    }
  }

  private virtual ListView lvResources
  {
    get => this._lvResources;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.lvResources_SelectedIndexChanged);
      ListView lvResources1 = this._lvResources;
      if (lvResources1 != null)
        lvResources1.SelectedIndexChanged -= eventHandler;
      this._lvResources = value;
      ListView lvResources2 = this._lvResources;
      if (lvResources2 == null)
        return;
      lvResources2.SelectedIndexChanged += eventHandler;
    }
  }

  private virtual MGACheckBox chkDeny
  {
    get => this._chkDeny;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.chkDeny_CheckedChanged);
      MGACheckBox chkDeny1 = this._chkDeny;
      if (chkDeny1 != null)
        ((UltraToggleEditorBase) chkDeny1).CheckedChanged -= eventHandler;
      this._chkDeny = value;
      MGACheckBox chkDeny2 = this._chkDeny;
      if (chkDeny2 == null)
        return;
      ((UltraToggleEditorBase) chkDeny2).CheckedChanged += eventHandler;
    }
  }

  private virtual MGACheckBox chkGrant
  {
    get => this._chkGrant;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.chkGrant_CheckedChanged);
      MGACheckBox chkGrant1 = this._chkGrant;
      if (chkGrant1 != null)
        ((UltraToggleEditorBase) chkGrant1).CheckedChanged -= eventHandler;
      this._chkGrant = value;
      MGACheckBox chkGrant2 = this._chkGrant;
      if (chkGrant2 == null)
        return;
      ((UltraToggleEditorBase) chkGrant2).CheckedChanged += eventHandler;
    }
  }

  private virtual MGAButton btnApplyChanges
  {
    get => this._btnApplyChanges;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnApplyChanges_Click);
      MGAButton btnApplyChanges1 = this._btnApplyChanges;
      if (btnApplyChanges1 != null)
        ((Control) btnApplyChanges1).Click -= eventHandler;
      this._btnApplyChanges = value;
      MGAButton btnApplyChanges2 = this._btnApplyChanges;
      if (btnApplyChanges2 == null)
        return;
      ((Control) btnApplyChanges2).Click += eventHandler;
    }
  }

  private virtual MGAButton btnGroupProps
  {
    get => this._btnGroupProps;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnGroupProps_Click);
      MGAButton btnGroupProps1 = this._btnGroupProps;
      if (btnGroupProps1 != null)
        ((Control) btnGroupProps1).Click -= eventHandler;
      this._btnGroupProps = value;
      MGAButton btnGroupProps2 = this._btnGroupProps;
      if (btnGroupProps2 == null)
        return;
      ((Control) btnGroupProps2).Click += eventHandler;
    }
  }

  private virtual MGAButton btnCancelChanges
  {
    get => this._btnCancelChanges;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnCancelChanges_Click);
      MGAButton btnCancelChanges1 = this._btnCancelChanges;
      if (btnCancelChanges1 != null)
        ((Control) btnCancelChanges1).Click -= eventHandler;
      this._btnCancelChanges = value;
      MGAButton btnCancelChanges2 = this._btnCancelChanges;
      if (btnCancelChanges2 == null)
        return;
      ((Control) btnCancelChanges2).Click += eventHandler;
    }
  }

  private virtual ContextMenu ctxGroups
  {
    get => this._ctxGroups;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ctxGroups_Popup);
      ContextMenu ctxGroups1 = this._ctxGroups;
      if (ctxGroups1 != null)
        ctxGroups1.Popup -= eventHandler;
      this._ctxGroups = value;
      ContextMenu ctxGroups2 = this._ctxGroups;
      if (ctxGroups2 == null)
        return;
      ctxGroups2.Popup += eventHandler;
    }
  }

  private virtual ContextMenu ctxResources
  {
    get => this._ctxResources;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ctxResources_Popup);
      ContextMenu ctxResources1 = this._ctxResources;
      if (ctxResources1 != null)
        ctxResources1.Popup -= eventHandler;
      this._ctxResources = value;
      ContextMenu ctxResources2 = this._ctxResources;
      if (ctxResources2 == null)
        return;
      ctxResources2.Popup += eventHandler;
    }
  }

  private virtual MenuItem mnuNewGroup
  {
    get => this._mnuNewGroup;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.mnuNewGroup_Click);
      MenuItem mnuNewGroup1 = this._mnuNewGroup;
      if (mnuNewGroup1 != null)
        mnuNewGroup1.Click -= eventHandler;
      this._mnuNewGroup = value;
      MenuItem mnuNewGroup2 = this._mnuNewGroup;
      if (mnuNewGroup2 == null)
        return;
      mnuNewGroup2.Click += eventHandler;
    }
  }

  private virtual MenuItem mnuProperties
  {
    get => this._mnuProperties;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.mnuProperties_Click);
      MenuItem mnuProperties1 = this._mnuProperties;
      if (mnuProperties1 != null)
        mnuProperties1.Click -= eventHandler;
      this._mnuProperties = value;
      MenuItem mnuProperties2 = this._mnuProperties;
      if (mnuProperties2 == null)
        return;
      mnuProperties2.Click += eventHandler;
    }
  }

  private virtual MenuItem mnuGrant
  {
    get => this._mnuGrant;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.mnuGrant_Click);
      MenuItem mnuGrant1 = this._mnuGrant;
      if (mnuGrant1 != null)
        mnuGrant1.Click -= eventHandler;
      this._mnuGrant = value;
      MenuItem mnuGrant2 = this._mnuGrant;
      if (mnuGrant2 == null)
        return;
      mnuGrant2.Click += eventHandler;
    }
  }

  private virtual MenuItem mnuDeny
  {
    get => this._mnuDeny;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.mnuDeny_Click);
      MenuItem mnuDeny1 = this._mnuDeny;
      if (mnuDeny1 != null)
        mnuDeny1.Click -= eventHandler;
      this._mnuDeny = value;
      MenuItem mnuDeny2 = this._mnuDeny;
      if (mnuDeny2 == null)
        return;
      mnuDeny2.Click += eventHandler;
    }
  }

  private virtual MenuItem mnuUnspecified
  {
    get => this._mnuUnspecified;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.mnuUnspecified_Click);
      MenuItem mnuUnspecified1 = this._mnuUnspecified;
      if (mnuUnspecified1 != null)
        mnuUnspecified1.Click -= eventHandler;
      this._mnuUnspecified = value;
      MenuItem mnuUnspecified2 = this._mnuUnspecified;
      if (mnuUnspecified2 == null)
        return;
      mnuUnspecified2.Click += eventHandler;
    }
  }

  private virtual UltraToolbarsManager UltraToolbarsManager1
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

  private virtual MenuItem mnuDoDeleteGroup
  {
    get => this._mnuDoDeleteGroup;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.mnuDeleteGroup_Click);
      MenuItem mnuDoDeleteGroup1 = this._mnuDoDeleteGroup;
      if (mnuDoDeleteGroup1 != null)
        mnuDoDeleteGroup1.Click -= eventHandler;
      this._mnuDoDeleteGroup = value;
      MenuItem mnuDoDeleteGroup2 = this._mnuDoDeleteGroup;
      if (mnuDoDeleteGroup2 == null)
        return;
      mnuDoDeleteGroup2.Click += eventHandler;
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    ListViewItem listViewItem1 = new ListViewItem("");
    ListViewItem listViewItem2 = new ListViewItem("");
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormAdminSecurityUsers));
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    UltraToolbar ultraToolbar = new UltraToolbar("main");
    PopupMenuTool popupMenuTool1 = new PopupMenuTool("File");
    PopupMenuTool popupMenuTool2 = new PopupMenuTool("File");
    ButtonTool buttonTool1 = new ButtonTool("IMPORTASP");
    ButtonTool buttonTool2 = new ButtonTool("EXPORTASP");
    ButtonTool buttonTool3 = new ButtonTool("IMPORTASP");
    ButtonTool buttonTool4 = new ButtonTool("EXPORTASP");
    this.lvGroups = new ListView();
    this.ColumnHeader1 = new ColumnHeader();
    this.ColumnHeader2 = new ColumnHeader();
    this.ctxGroups = new ContextMenu();
    this.mnuNewGroup = new MenuItem();
    this.mnuSeperator = new MenuItem();
    this.mnuProperties = new MenuItem();
    this.mnuDoDeleteGroup = new MenuItem();
    this.imgLarge = new ImageList(this.components);
    this.imgSmall = new ImageList(this.components);
    this.daGroups = new SqlDataAdapter();
    this.SqlDeleteCommand1 = new SqlCommand();
    this.cnSQL = new SqlConnection();
    this.SqlInsertCommand1 = new SqlCommand();
    this.SqlSelectCommand1 = new SqlCommand();
    this.SqlUpdateCommand1 = new SqlCommand();
    this.DsSecurityManagement = new dsSecurityManagement();
    this.btnNewGroup = new MGAButton();
    this.btnDeleteGroup = new MGAButton();
    this.pnlGroupUsers = new Panel();
    this.chkShowUsers = new MGACheckBox();
    this.btnGroupProps = new MGAButton();
    this.Label2 = new Label();
    this.Label1 = new Label();
    this.pnlResources = new Panel();
    this.pnlLoad = new Panel();
    this.PictureBox1 = new PictureBox();
    this.Label5 = new Label();
    this.lvResources = new ListView();
    this.ColumnHeader3 = new ColumnHeader();
    this.ColumnHeader5 = new ColumnHeader();
    this.ColumnHeader4 = new ColumnHeader();
    this.ctxResources = new ContextMenu();
    this.mnuGrant = new MenuItem();
    this.mnuDeny = new MenuItem();
    this.mnuUnspecified = new MenuItem();
    this.Label4 = new Label();
    this.Label3 = new Label();
    this.pnlPermResources = new Panel();
    this.btnCancelChanges = new MGAButton();
    this.chkDeny = new MGACheckBox();
    this.chkGrant = new MGACheckBox();
    this.btnApplyChanges = new MGAButton();
    this.Label6 = new Label();
    this.lblResourceInfo = new Label();
    this.Panel4 = new Panel();
    this.pnlRightSplit = new Panel();
    this.Splitter1 = new Splitter();
    this.daUsers = new SqlDataAdapter();
    this.SqlSelectCommand2 = new SqlCommand();
    this.ToolTip1 = new ToolTip(this.components);
    this.UltraToolbarsManager1 = new UltraToolbarsManager(this.components);
    this._FormAdminSecurityUsers_Toolbars_Dock_Area_Left = new UltraToolbarsDockArea();
    this._FormAdminSecurityUsers_Toolbars_Dock_Area_Right = new UltraToolbarsDockArea();
    this._FormAdminSecurityUsers_Toolbars_Dock_Area_Top = new UltraToolbarsDockArea();
    this._FormAdminSecurityUsers_Toolbars_Dock_Area_Bottom = new UltraToolbarsDockArea();
    this.BackgroundWorker = new BackgroundWorker();
    this.DsSecurityManagement.BeginInit();
    ((ISupportInitialize) this.btnNewGroup).BeginInit();
    ((ISupportInitialize) this.btnDeleteGroup).BeginInit();
    this.pnlGroupUsers.SuspendLayout();
    ((ISupportInitialize) this.chkShowUsers).BeginInit();
    ((ISupportInitialize) this.btnGroupProps).BeginInit();
    this.pnlResources.SuspendLayout();
    this.pnlLoad.SuspendLayout();
    ((ISupportInitialize) this.PictureBox1).BeginInit();
    this.pnlPermResources.SuspendLayout();
    ((ISupportInitialize) this.btnCancelChanges).BeginInit();
    ((ISupportInitialize) this.chkDeny).BeginInit();
    ((ISupportInitialize) this.chkGrant).BeginInit();
    ((ISupportInitialize) this.btnApplyChanges).BeginInit();
    this.Panel4.SuspendLayout();
    this.pnlRightSplit.SuspendLayout();
    ((ISupportInitialize) this.UltraToolbarsManager1).BeginInit();
    this.SuspendLayout();
    this.lvGroups.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.lvGroups.BackColor = Color.White;
    this.lvGroups.BorderStyle = BorderStyle.None;
    this.lvGroups.Columns.AddRange(new ColumnHeader[2]
    {
      this.ColumnHeader1,
      this.ColumnHeader2
    });
    this.lvGroups.ContextMenu = this.ctxGroups;
    this.lvGroups.ForeColor = Color.Black;
    this.lvGroups.FullRowSelect = true;
    this.lvGroups.HideSelection = false;
    this.lvGroups.Items.AddRange(new ListViewItem[2]
    {
      listViewItem1,
      listViewItem2
    });
    this.lvGroups.LargeImageList = this.imgLarge;
    this.lvGroups.Location = new Point(0, 16 /*0x10*/);
    this.lvGroups.MultiSelect = false;
    this.lvGroups.Name = "lvGroups";
    this.lvGroups.Size = new Size(328, 419);
    this.lvGroups.SmallImageList = this.imgSmall;
    this.lvGroups.Sorting = System.Windows.Forms.SortOrder.Ascending;
    this.lvGroups.TabIndex = 0;
    this.ToolTip1.SetToolTip((Control) this.lvGroups, "All users and groups currently defined within the system.");
    this.lvGroups.UseCompatibleStateImageBehavior = false;
    this.lvGroups.View = View.Details;
    this.ColumnHeader1.Text = "Group/User";
    this.ColumnHeader1.Width = 150;
    this.ColumnHeader2.Text = "Description";
    this.ColumnHeader2.Width = 175;
    this.ctxGroups.MenuItems.AddRange(new MenuItem[4]
    {
      this.mnuNewGroup,
      this.mnuSeperator,
      this.mnuProperties,
      this.mnuDoDeleteGroup
    });
    this.mnuNewGroup.Index = 0;
    this.mnuNewGroup.Text = "New Group";
    this.mnuSeperator.Index = 1;
    this.mnuSeperator.Text = "-";
    this.mnuProperties.Index = 2;
    this.mnuProperties.Text = "Properties...";
    this.mnuDoDeleteGroup.Index = 3;
    this.mnuDoDeleteGroup.Text = "Delete Group";
    this.imgLarge.ImageStream = (ImageListStreamer) componentResourceManager.GetObject("imgLarge.ImageStream");
    this.imgLarge.TransparentColor = Color.Magenta;
    this.imgLarge.Images.SetKeyName(0, "computer.png");
    this.imgLarge.Images.SetKeyName(1, "group.png");
    this.imgLarge.Images.SetKeyName(2, "page_key.png");
    this.imgSmall.ImageStream = (ImageListStreamer) componentResourceManager.GetObject("imgSmall.ImageStream");
    this.imgSmall.TransparentColor = Color.Magenta;
    this.imgSmall.Images.SetKeyName(0, "computer.png");
    this.imgSmall.Images.SetKeyName(1, "group.png");
    this.imgSmall.Images.SetKeyName(2, "page_key.png");
    this.daGroups.DeleteCommand = this.SqlDeleteCommand1;
    this.daGroups.InsertCommand = this.SqlInsertCommand1;
    this.daGroups.SelectCommand = this.SqlSelectCommand1;
    this.daGroups.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblSecurityGroups", new DataColumnMapping[3]
      {
        new DataColumnMapping("Name", "Name"),
        new DataColumnMapping("GroupGuid", "GroupGuid"),
        new DataColumnMapping("Description", "Description")
      })
    });
    this.daGroups.UpdateCommand = this.SqlUpdateCommand1;
    this.SqlDeleteCommand1.CommandText = "DELETE FROM tblSecurityGroups WHERE (GroupGuid = @Original_GroupGuid) AND (Description = @Original_Description) AND (Name = @Original_Name)";
    this.SqlDeleteCommand1.Connection = this.cnSQL;
    this.SqlDeleteCommand1.Parameters.AddRange(new SqlParameter[3]
    {
      new SqlParameter("@Original_GroupGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, ParameterDirection.Input, false, (byte) 0, (byte) 0, "GroupGuid", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_Description", SqlDbType.VarChar, 150, ParameterDirection.Input, false, (byte) 0, (byte) 0, "Description", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_Name", SqlDbType.VarChar, 50, ParameterDirection.Input, false, (byte) 0, (byte) 0, "Name", DataRowVersion.Original, (object) null)
    });
    this.cnSQL.ConnectionString = "workstation id=DOMENIC;packet size=4096;user id=mgasystems;data source=MGASYSTEMS;persist security info=False;initial catalog=IMS";
    this.cnSQL.FireInfoMessageEventOnUserErrors = false;
    this.SqlInsertCommand1.CommandText = "INSERT INTO tblSecurityGroups(Name, GroupGuid, Description) VALUES (@Name, @GroupGuid, @Description); SELECT Name, GroupGuid, Description FROM tblSecurityGroups WHERE (GroupGuid = @GroupGuid)";
    this.SqlInsertCommand1.Connection = this.cnSQL;
    this.SqlInsertCommand1.Parameters.AddRange(new SqlParameter[3]
    {
      new SqlParameter("@Name", SqlDbType.VarChar, 50, "Name"),
      new SqlParameter("@GroupGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "GroupGuid"),
      new SqlParameter("@Description", SqlDbType.VarChar, 150, "Description")
    });
    this.SqlSelectCommand1.CommandText = "SELECT Name, GroupGuid, Description FROM tblSecurityGroups";
    this.SqlSelectCommand1.Connection = this.cnSQL;
    this.SqlUpdateCommand1.CommandText = componentResourceManager.GetString("SqlUpdateCommand1.CommandText");
    this.SqlUpdateCommand1.Connection = this.cnSQL;
    this.SqlUpdateCommand1.Parameters.AddRange(new SqlParameter[6]
    {
      new SqlParameter("@Name", SqlDbType.VarChar, 50, "Name"),
      new SqlParameter("@GroupGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "GroupGuid"),
      new SqlParameter("@Description", SqlDbType.VarChar, 150, "Description"),
      new SqlParameter("@Original_GroupGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, ParameterDirection.Input, false, (byte) 0, (byte) 0, "GroupGuid", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_Description", SqlDbType.VarChar, 150, ParameterDirection.Input, false, (byte) 0, (byte) 0, "Description", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_Name", SqlDbType.VarChar, 50, ParameterDirection.Input, false, (byte) 0, (byte) 0, "Name", DataRowVersion.Original, (object) null)
    });
    this.DsSecurityManagement.DataSetName = "dsSecurityManagement";
    this.DsSecurityManagement.Locale = new CultureInfo("en-US");
    this.DsSecurityManagement.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((Control) this.btnNewGroup).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance1.BackColor = Color.FromArgb(248, 248, 248);
    appearance1.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance1.BackGradientStyle = (GradientStyle) 2;
    appearance1.BorderColor = Color.DarkGray;
    ((ControlBase) this.btnNewGroup).Appearance = (AppearanceBase) appearance1;
    ((Control) this.btnNewGroup).Location = new Point(8, 453);
    ((Control) this.btnNewGroup).Name = "btnNewGroup";
    ((Control) this.btnNewGroup).Size = new Size(96 /*0x60*/, 24);
    ((Control) this.btnNewGroup).TabIndex = 0;
    ((ControlBase) this.btnNewGroup).Text = "New Group";
    this.ToolTip1.SetToolTip((Control) this.btnNewGroup, "Add a new user group.");
    this.btnNewGroup.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.btnDeleteGroup).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance2.BackColor = Color.FromArgb(248, 248, 248);
    appearance2.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance2.BackGradientStyle = (GradientStyle) 2;
    appearance2.BorderColor = Color.DarkGray;
    ((ControlBase) this.btnDeleteGroup).Appearance = (AppearanceBase) appearance2;
    ((Control) this.btnDeleteGroup).Enabled = false;
    ((Control) this.btnDeleteGroup).Location = new Point(112 /*0x70*/, 453);
    ((Control) this.btnDeleteGroup).Name = "btnDeleteGroup";
    ((Control) this.btnDeleteGroup).Size = new Size(96 /*0x60*/, 24);
    ((Control) this.btnDeleteGroup).TabIndex = 2;
    ((ControlBase) this.btnDeleteGroup).Text = "Delete Group...";
    this.ToolTip1.SetToolTip((Control) this.btnDeleteGroup, "Remove an existing user group.");
    this.btnDeleteGroup.UseOSThemes = (DefaultableBoolean) 2;
    this.pnlGroupUsers.BackColor = Color.Transparent;
    this.pnlGroupUsers.Controls.Add((Control) this.chkShowUsers);
    this.pnlGroupUsers.Controls.Add((Control) this.btnGroupProps);
    this.pnlGroupUsers.Controls.Add((Control) this.Label2);
    this.pnlGroupUsers.Controls.Add((Control) this.Label1);
    this.pnlGroupUsers.Controls.Add((Control) this.lvGroups);
    this.pnlGroupUsers.Controls.Add((Control) this.btnNewGroup);
    this.pnlGroupUsers.Controls.Add((Control) this.btnDeleteGroup);
    this.pnlGroupUsers.Dock = DockStyle.Left;
    this.pnlGroupUsers.Location = new Point(0, 0);
    this.pnlGroupUsers.Name = "pnlGroupUsers";
    this.pnlGroupUsers.Size = new Size(328, 491);
    this.pnlGroupUsers.TabIndex = 4;
    ((Control) this.chkShowUsers).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    appearance3.BorderColor = Color.Gray;
    appearance3.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkShowUsers).Appearance = (AppearanceBase) appearance3;
    ((UltraToggleEditorBase) this.chkShowUsers).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkShowUsers).Location = new Point(8, 435);
    ((Control) this.chkShowUsers).Name = "chkShowUsers";
    ((Control) this.chkShowUsers).Size = new Size(96 /*0x60*/, 16 /*0x10*/);
    ((Control) this.chkShowUsers).TabIndex = 4;
    ((UltraToggleEditorBase) this.chkShowUsers).Text = "Show all users";
    ((Control) this.btnGroupProps).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance4.BackColor = Color.FromArgb(248, 248, 248);
    appearance4.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance4.BackGradientStyle = (GradientStyle) 2;
    appearance4.BorderColor = Color.DarkGray;
    ((ControlBase) this.btnGroupProps).Appearance = (AppearanceBase) appearance4;
    ((Control) this.btnGroupProps).Enabled = false;
    ((Control) this.btnGroupProps).Location = new Point(216, 453);
    ((Control) this.btnGroupProps).Name = "btnGroupProps";
    ((Control) this.btnGroupProps).Size = new Size(96 /*0x60*/, 24);
    ((Control) this.btnGroupProps).TabIndex = 3;
    ((ControlBase) this.btnGroupProps).Text = "Properties...";
    this.ToolTip1.SetToolTip((Control) this.btnGroupProps, "View the security properties for the selected group or user.");
    this.btnGroupProps.UseOSThemes = (DefaultableBoolean) 2;
    this.Label2.BorderStyle = BorderStyle.FixedSingle;
    this.Label2.Dock = DockStyle.Top;
    this.Label2.Location = new Point(0, 16 /*0x10*/);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(328, 1);
    this.Label2.TabIndex = 2;
    this.Label1.Dock = DockStyle.Top;
    this.Label1.Location = new Point(0, 0);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(328, 16 /*0x10*/);
    this.Label1.TabIndex = 1;
    this.Label1.Text = "Groups/Users";
    this.pnlResources.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.pnlResources.Controls.Add((Control) this.pnlLoad);
    this.pnlResources.Controls.Add((Control) this.lvResources);
    this.pnlResources.Controls.Add((Control) this.Label4);
    this.pnlResources.Controls.Add((Control) this.Label3);
    this.pnlResources.Location = new Point(0, 0);
    this.pnlResources.Name = "pnlResources";
    this.pnlResources.Size = new Size(454, 435);
    this.pnlResources.TabIndex = 5;
    this.pnlLoad.BackColor = SystemColors.Window;
    this.pnlLoad.Controls.Add((Control) this.PictureBox1);
    this.pnlLoad.Controls.Add((Control) this.Label5);
    this.pnlLoad.Location = new Point(0, 16 /*0x10*/);
    this.pnlLoad.Name = "pnlLoad";
    this.pnlLoad.Size = new Size(454, 416);
    this.pnlLoad.TabIndex = 3;
    this.PictureBox1.Image = (Image) componentResourceManager.GetObject("PictureBox1.Image");
    this.PictureBox1.Location = new Point(0, 0);
    this.PictureBox1.Name = "PictureBox1";
    this.PictureBox1.Size = new Size(16 /*0x10*/, 16 /*0x10*/);
    this.PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
    this.PictureBox1.TabIndex = 3;
    this.PictureBox1.TabStop = false;
    this.Label5.AutoSize = true;
    this.Label5.Location = new Point(27, 2);
    this.Label5.Name = "Label5";
    this.Label5.Size = new Size(59, 13);
    this.Label5.TabIndex = 2;
    this.Label5.Text = "Loading ...";
    this.lvResources.BackColor = Color.White;
    this.lvResources.BorderStyle = BorderStyle.None;
    this.lvResources.Columns.AddRange(new ColumnHeader[3]
    {
      this.ColumnHeader3,
      this.ColumnHeader5,
      this.ColumnHeader4
    });
    this.lvResources.ContextMenu = this.ctxResources;
    this.lvResources.Dock = DockStyle.Fill;
    this.lvResources.ForeColor = Color.Black;
    this.lvResources.LargeImageList = this.imgLarge;
    this.lvResources.Location = new Point(0, 17);
    this.lvResources.Name = "lvResources";
    this.lvResources.Size = new Size(454, 418);
    this.lvResources.SmallImageList = this.imgSmall;
    this.lvResources.TabIndex = 2;
    this.ToolTip1.SetToolTip((Control) this.lvResources, "All application defined resources.");
    this.lvResources.UseCompatibleStateImageBehavior = false;
    this.lvResources.View = View.Details;
    this.ColumnHeader3.Text = "Resource";
    this.ColumnHeader3.Width = 146;
    this.ColumnHeader5.Text = "Group";
    this.ColumnHeader5.Width = 108;
    this.ColumnHeader4.Text = "Description";
    this.ColumnHeader4.Width = 498;
    this.ctxResources.MenuItems.AddRange(new MenuItem[3]
    {
      this.mnuGrant,
      this.mnuDeny,
      this.mnuUnspecified
    });
    this.mnuGrant.Index = 0;
    this.mnuGrant.Text = "Grant";
    this.mnuDeny.Index = 1;
    this.mnuDeny.Text = "Deny";
    this.mnuUnspecified.Index = 2;
    this.mnuUnspecified.Text = "Unspecified";
    this.Label4.BorderStyle = BorderStyle.FixedSingle;
    this.Label4.Dock = DockStyle.Top;
    this.Label4.Location = new Point(0, 16 /*0x10*/);
    this.Label4.Name = "Label4";
    this.Label4.Size = new Size(454, 1);
    this.Label4.TabIndex = 1;
    this.Label4.Text = "Label4";
    this.Label3.BackColor = Color.Transparent;
    this.Label3.Dock = DockStyle.Top;
    this.Label3.Location = new Point(0, 0);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(454, 16 /*0x10*/);
    this.Label3.TabIndex = 0;
    this.Label3.Text = "Resources";
    this.pnlPermResources.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.pnlPermResources.BackColor = Color.Transparent;
    this.pnlPermResources.Controls.Add((Control) this.btnCancelChanges);
    this.pnlPermResources.Controls.Add((Control) this.chkDeny);
    this.pnlPermResources.Controls.Add((Control) this.chkGrant);
    this.pnlPermResources.Controls.Add((Control) this.btnApplyChanges);
    this.pnlPermResources.Controls.Add((Control) this.Label6);
    this.pnlPermResources.Controls.Add((Control) this.lblResourceInfo);
    this.pnlPermResources.Location = new Point(0, 435);
    this.pnlPermResources.Name = "pnlPermResources";
    this.pnlPermResources.Size = new Size(464, 47);
    this.pnlPermResources.TabIndex = 6;
    ((Control) this.btnCancelChanges).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    appearance5.BackColor = Color.FromArgb(248, 248, 248);
    appearance5.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance5.BackGradientStyle = (GradientStyle) 2;
    appearance5.BorderColor = Color.DarkGray;
    ((ControlBase) this.btnCancelChanges).Appearance = (AppearanceBase) appearance5;
    ((Control) this.btnCancelChanges).Location = new Point(256 /*0x0100*/, 24);
    ((Control) this.btnCancelChanges).Name = "btnCancelChanges";
    ((Control) this.btnCancelChanges).Size = new Size(96 /*0x60*/, 24);
    ((Control) this.btnCancelChanges).TabIndex = 7;
    ((ControlBase) this.btnCancelChanges).Text = "Cancel Changes";
    this.ToolTip1.SetToolTip((Control) this.btnCancelChanges, "Cancel pending changes. (Bolded items)");
    this.btnCancelChanges.UseOSThemes = (DefaultableBoolean) 2;
    appearance6.BorderColor = Color.Gray;
    appearance6.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkDeny).Appearance = (AppearanceBase) appearance6;
    ((UltraToggleEditorBase) this.chkDeny).Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((UltraToggleEditorBase) this.chkDeny).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkDeny).Location = new Point(80 /*0x50*/, 24);
    ((Control) this.chkDeny).Name = "chkDeny";
    ((Control) this.chkDeny).Size = new Size(56, 16 /*0x10*/);
    ((Control) this.chkDeny).TabIndex = 6;
    ((UltraToggleEditorBase) this.chkDeny).Text = "Deny";
    this.ToolTip1.SetToolTip((Control) this.chkDeny, "Explicitly deny this access to this resource to the selected user or group.");
    appearance7.BorderColor = Color.Gray;
    appearance7.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkGrant).Appearance = (AppearanceBase) appearance7;
    ((UltraToggleEditorBase) this.chkGrant).Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((UltraToggleEditorBase) this.chkGrant).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkGrant).Location = new Point(16 /*0x10*/, 24);
    ((Control) this.chkGrant).Name = "chkGrant";
    ((Control) this.chkGrant).Size = new Size(56, 16 /*0x10*/);
    ((Control) this.chkGrant).TabIndex = 5;
    ((UltraToggleEditorBase) this.chkGrant).Text = "Grant";
    this.ToolTip1.SetToolTip((Control) this.chkGrant, "Explicitly grant this access to this resource to the selected user or group.");
    ((Control) this.btnApplyChanges).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    appearance8.BackColor = Color.FromArgb(248, 248, 248);
    appearance8.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance8.BackGradientStyle = (GradientStyle) 2;
    appearance8.BorderColor = Color.DarkGray;
    ((ControlBase) this.btnApplyChanges).Appearance = (AppearanceBase) appearance8;
    ((Control) this.btnApplyChanges).Location = new Point(360, 24);
    ((Control) this.btnApplyChanges).Name = "btnApplyChanges";
    ((Control) this.btnApplyChanges).Size = new Size(96 /*0x60*/, 24);
    ((Control) this.btnApplyChanges).TabIndex = 4;
    ((ControlBase) this.btnApplyChanges).Text = "Apply Changes";
    this.ToolTip1.SetToolTip((Control) this.btnApplyChanges, "Save pending changes. (Bolded items)");
    this.btnApplyChanges.UseOSThemes = (DefaultableBoolean) 2;
    this.Label6.BorderStyle = BorderStyle.FixedSingle;
    this.Label6.Dock = DockStyle.Top;
    this.Label6.Location = new Point(0, 15);
    this.Label6.Name = "Label6";
    this.Label6.Size = new Size(464, 1);
    this.Label6.TabIndex = 1;
    this.Label6.Text = "Label6";
    this.lblResourceInfo.Dock = DockStyle.Top;
    this.lblResourceInfo.Location = new Point(0, 0);
    this.lblResourceInfo.Name = "lblResourceInfo";
    this.lblResourceInfo.Size = new Size(464, 15);
    this.lblResourceInfo.TabIndex = 0;
    this.lblResourceInfo.Text = "Permissions form resource X";
    this.Panel4.BackColor = Color.Transparent;
    this.Panel4.Controls.Add((Control) this.pnlRightSplit);
    this.Panel4.Controls.Add((Control) this.Splitter1);
    this.Panel4.Controls.Add((Control) this.pnlGroupUsers);
    this.Panel4.Dock = DockStyle.Fill;
    this.Panel4.Location = new Point(0, 19);
    this.Panel4.Name = "Panel4";
    this.Panel4.Size = new Size(792, 491);
    this.Panel4.TabIndex = 7;
    this.pnlRightSplit.BackColor = Color.Transparent;
    this.pnlRightSplit.Controls.Add((Control) this.pnlResources);
    this.pnlRightSplit.Controls.Add((Control) this.pnlPermResources);
    this.pnlRightSplit.Dock = DockStyle.Fill;
    this.pnlRightSplit.Location = new Point(331, 0);
    this.pnlRightSplit.Name = "pnlRightSplit";
    this.pnlRightSplit.Size = new Size(461, 491);
    this.pnlRightSplit.TabIndex = 6;
    this.Splitter1.Location = new Point(328, 0);
    this.Splitter1.Name = "Splitter1";
    this.Splitter1.Size = new Size(3, 491);
    this.Splitter1.TabIndex = 5;
    this.Splitter1.TabStop = false;
    this.daUsers.SelectCommand = this.SqlSelectCommand2;
    this.daUsers.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblUsers", new DataColumnMapping[2]
      {
        new DataColumnMapping("UserGuid", "UserGuid"),
        new DataColumnMapping("FullName", "FullName")
      })
    });
    this.SqlSelectCommand2.CommandText = "SELECT StatusID,UserGuid, LastName + ', ' + FirstName AS FullName FROM tblUsers";
    this.SqlSelectCommand2.Connection = this.cnSQL;
    this.UltraToolbarsManager1.DesignerFlags = 1;
    this.UltraToolbarsManager1.DockWithinContainer = (Control) this;
    this.UltraToolbarsManager1.DockWithinContainerBaseType = typeof (Form);
    this.UltraToolbarsManager1.ShowFullMenusDelay = 500;
    this.UltraToolbarsManager1.ShowQuickCustomizeButton = false;
    ultraToolbar.DockedColumn = 0;
    ultraToolbar.DockedRow = 0;
    ultraToolbar.IsMainMenuBar = true;
    ((UltraToolbarBase) ultraToolbar).NonInheritedTools.AddRange(new ToolBase[1]
    {
      (ToolBase) popupMenuTool1
    });
    ultraToolbar.Text = "main";
    this.UltraToolbarsManager1.Toolbars.AddRange(new UltraToolbar[1]
    {
      ultraToolbar
    });
    ((ToolPropsBase) ((ToolBase) popupMenuTool2).SharedProps).Caption = "&File";
    ((ToolsCollectionBase) popupMenuTool2.Tools).AddRange(new ToolBase[2]
    {
      (ToolBase) buttonTool1,
      (ToolBase) buttonTool2
    });
    ((ToolPropsBase) ((ToolBase) buttonTool3).SharedProps).Caption = "Import Application Security Profile";
    ((ToolPropsBase) ((ToolBase) buttonTool4).SharedProps).Caption = "Export Application Security Profile";
    this.UltraToolbarsManager1.Tools.AddRange(new ToolBase[3]
    {
      (ToolBase) popupMenuTool2,
      (ToolBase) buttonTool3,
      (ToolBase) buttonTool4
    });
    ((Control) this._FormAdminSecurityUsers_Toolbars_Dock_Area_Left).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormAdminSecurityUsers_Toolbars_Dock_Area_Left).BackColor = Color.WhiteSmoke;
    this._FormAdminSecurityUsers_Toolbars_Dock_Area_Left.DockedPosition = (DockedPosition) 2;
    ((Control) this._FormAdminSecurityUsers_Toolbars_Dock_Area_Left).ForeColor = Color.Black;
    ((Control) this._FormAdminSecurityUsers_Toolbars_Dock_Area_Left).Location = new Point(0, 19);
    ((Control) this._FormAdminSecurityUsers_Toolbars_Dock_Area_Left).Name = "_FormAdminSecurityUsers_Toolbars_Dock_Area_Left";
    ((Control) this._FormAdminSecurityUsers_Toolbars_Dock_Area_Left).Size = new Size(0, 491);
    this._FormAdminSecurityUsers_Toolbars_Dock_Area_Left.ToolbarsManager = this.UltraToolbarsManager1;
    ((Control) this._FormAdminSecurityUsers_Toolbars_Dock_Area_Right).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormAdminSecurityUsers_Toolbars_Dock_Area_Right).BackColor = Color.WhiteSmoke;
    this._FormAdminSecurityUsers_Toolbars_Dock_Area_Right.DockedPosition = (DockedPosition) 3;
    ((Control) this._FormAdminSecurityUsers_Toolbars_Dock_Area_Right).ForeColor = Color.Black;
    ((Control) this._FormAdminSecurityUsers_Toolbars_Dock_Area_Right).Location = new Point(792, 19);
    ((Control) this._FormAdminSecurityUsers_Toolbars_Dock_Area_Right).Name = "_FormAdminSecurityUsers_Toolbars_Dock_Area_Right";
    ((Control) this._FormAdminSecurityUsers_Toolbars_Dock_Area_Right).Size = new Size(0, 491);
    this._FormAdminSecurityUsers_Toolbars_Dock_Area_Right.ToolbarsManager = this.UltraToolbarsManager1;
    ((Control) this._FormAdminSecurityUsers_Toolbars_Dock_Area_Top).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormAdminSecurityUsers_Toolbars_Dock_Area_Top).BackColor = Color.WhiteSmoke;
    this._FormAdminSecurityUsers_Toolbars_Dock_Area_Top.DockedPosition = (DockedPosition) 0;
    ((Control) this._FormAdminSecurityUsers_Toolbars_Dock_Area_Top).ForeColor = Color.Black;
    ((Control) this._FormAdminSecurityUsers_Toolbars_Dock_Area_Top).Location = new Point(0, 0);
    ((Control) this._FormAdminSecurityUsers_Toolbars_Dock_Area_Top).Name = "_FormAdminSecurityUsers_Toolbars_Dock_Area_Top";
    ((Control) this._FormAdminSecurityUsers_Toolbars_Dock_Area_Top).Size = new Size(792, 19);
    this._FormAdminSecurityUsers_Toolbars_Dock_Area_Top.ToolbarsManager = this.UltraToolbarsManager1;
    ((Control) this._FormAdminSecurityUsers_Toolbars_Dock_Area_Bottom).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormAdminSecurityUsers_Toolbars_Dock_Area_Bottom).BackColor = Color.WhiteSmoke;
    this._FormAdminSecurityUsers_Toolbars_Dock_Area_Bottom.DockedPosition = (DockedPosition) 1;
    ((Control) this._FormAdminSecurityUsers_Toolbars_Dock_Area_Bottom).ForeColor = Color.Black;
    ((Control) this._FormAdminSecurityUsers_Toolbars_Dock_Area_Bottom).Location = new Point(0, 510);
    ((Control) this._FormAdminSecurityUsers_Toolbars_Dock_Area_Bottom).Name = "_FormAdminSecurityUsers_Toolbars_Dock_Area_Bottom";
    ((Control) this._FormAdminSecurityUsers_Toolbars_Dock_Area_Bottom).Size = new Size(792, 0);
    this._FormAdminSecurityUsers_Toolbars_Dock_Area_Bottom.ToolbarsManager = this.UltraToolbarsManager1;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.WhiteSmoke;
    this.ClientSize = new Size(792, 510);
    this.Controls.Add((Control) this.Panel4);
    this.Controls.Add((Control) this._FormAdminSecurityUsers_Toolbars_Dock_Area_Left);
    this.Controls.Add((Control) this._FormAdminSecurityUsers_Toolbars_Dock_Area_Right);
    this.Controls.Add((Control) this._FormAdminSecurityUsers_Toolbars_Dock_Area_Top);
    this.Controls.Add((Control) this._FormAdminSecurityUsers_Toolbars_Dock_Area_Bottom);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ForeColor = Color.Black;
    this.Name = nameof (FormAdminSecurityUsers);
    this.Text = "Security group / user resource access administration.";
    this.DsSecurityManagement.EndInit();
    ((ISupportInitialize) this.btnNewGroup).EndInit();
    ((ISupportInitialize) this.btnDeleteGroup).EndInit();
    this.pnlGroupUsers.ResumeLayout(false);
    ((ISupportInitialize) this.chkShowUsers).EndInit();
    ((ISupportInitialize) this.btnGroupProps).EndInit();
    this.pnlResources.ResumeLayout(false);
    this.pnlLoad.ResumeLayout(false);
    this.pnlLoad.PerformLayout();
    ((ISupportInitialize) this.PictureBox1).EndInit();
    this.pnlPermResources.ResumeLayout(false);
    ((ISupportInitialize) this.btnCancelChanges).EndInit();
    ((ISupportInitialize) this.chkDeny).EndInit();
    ((ISupportInitialize) this.chkGrant).EndInit();
    ((ISupportInitialize) this.btnApplyChanges).EndInit();
    this.Panel4.ResumeLayout(false);
    this.pnlRightSplit.ResumeLayout(false);
    ((ISupportInitialize) this.UltraToolbarsManager1).EndInit();
    this.ResumeLayout(false);
  }

  private bool EnableProperties
  {
    get
    {
      return SecurityManager.Instance.AssertPermission("{FE820AC1-6427-49b7-AB0E-5123D75851B5}") && this.lvGroups.SelectedItems.Count > 0;
    }
  }

  private void FormAdminSecurityUsers_Load(object sender, EventArgs e)
  {
    this.cnSQL.ConnectionString = Database.Instance.ConnectionString;
    this._adminGroupGuid = DefaultDatabase.ExecuteScalar<Guid>(CommandType.Text, "SELECT GroupGuid FROM tblSecurityGroups WHERE Name = @GroupName", new object[2]
    {
      (object) "@GroupName",
      (object) "Administrators"
    });
    this.lvGroups.ListViewItemSorter = (IComparer) this;
    Database.Instance.QueryMultithreadedDataAdapter.PerformTableQuery((Control) this, "daGroups", this.daGroups, new TableQueryMultithreadEventHandler(this.groups_tableLoaded), (DataTable) this.DsSecurityManagement.tblSecurityGroups);
    Database.Instance.QueryMultithreadedDataAdapter.PerformTableQuery((Control) this, "daUsers", this.daUsers, new TableQueryMultithreadEventHandler(this.users_tableLoaded), (DataTable) this.DsSecurityManagement.tblUsers);
    this._groupHash = new Dictionary<string, string>();
    Type[] typeArray = ObjectFactory.Instance.QueryTypesWithAttribute((Attribute) new SecureResourceAttribute());
    int index1 = 0;
    while (index1 < typeArray.Length)
    {
      object[] customAttributes = typeArray[index1].GetCustomAttributes(typeof (SecureResourceAttribute), false);
      if (customAttributes != null)
      {
        object[] objArray = customAttributes;
        int index2 = 0;
        while (index2 < objArray.Length)
        {
          SecureResourceAttribute resourceAttribute = (SecureResourceAttribute) objArray[index2];
          Dictionary<string, string> groupHash1 = this._groupHash;
          Guid uniqueIdentifier = resourceAttribute.UniqueIdentifier;
          string key1 = uniqueIdentifier.ToString();
          if (!groupHash1.ContainsKey(key1))
          {
            Dictionary<string, string> groupHash2 = this._groupHash;
            uniqueIdentifier = resourceAttribute.UniqueIdentifier;
            string key2 = uniqueIdentifier.ToString();
            string securityGroup = resourceAttribute.SecurityGroup;
            groupHash2.Add(key2, securityGroup);
          }
          checked { ++index2; }
        }
      }
      checked { ++index1; }
    }
    this.BackgroundWorker.RunWorkerAsync();
    this._resourceListFilled = false;
    Database.Instance.QueryMultithreadedText.PerformTableQuery(new TableQueryMultithreadEventHandler(this.ResourceList_TableFilled), (Control) this, (object) "Fill Resource Table", "SELECT ResourceGuid, Name, Description FROM lstSecurityResources");
  }

  private void groups_tableLoaded(object sender, TableQueryMultithreadEventArgs e)
  {
    this._groupsLoaded = true;
    this.UIRefreshGroups(false);
  }

  private int CurrentAdminCount
  {
    get
    {
      return DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "SELECT COUNT(*) FROM tblSecurityUserGroups WHERE GroupGuid = @GroupGuid", new object[2]
      {
        (object) "@GroupGuid",
        (object) this._adminGroupGuid
      });
    }
  }

  private void users_tableLoaded(object sender, TableQueryMultithreadEventArgs e)
  {
    this._usersLoaded = true;
    this.UIRefreshGroups(false);
  }

  private void UIRefreshGroups() => this.UIRefreshGroups(true);

  private void UIRefreshGroups(bool forceRefresh)
  {
    if (forceRefresh || this._groupsLoaded && this._usersLoaded)
    {
      this._usersLoaded = false;
      this._groupsLoaded = false;
      this.lvGroups.Items.Clear();
      try
      {
        foreach (dsSecurityManagement.tblSecurityGroupsRow tblSecurityGroup in (TypedTableBase<dsSecurityManagement.tblSecurityGroupsRow>) this.DsSecurityManagement.tblSecurityGroups)
          this.lvGroups.Items.Add((ListViewItem) new FormAdminSecurityUsers.GroupListViewItem(tblSecurityGroup));
      }
      finally
      {
        IEnumerator<dsSecurityManagement.tblSecurityGroupsRow> enumerator;
        enumerator?.Dispose();
      }
      if (((UltraToggleEditorBase) this.chkShowUsers).Checked)
      {
        try
        {
          foreach (dsSecurityManagement.tblUsersRow tblUser in (TypedTableBase<dsSecurityManagement.tblUsersRow>) this.DsSecurityManagement.tblUsers)
            this.lvGroups.Items.Add((ListViewItem) new FormAdminSecurityUsers.UserListViewItem(tblUser));
        }
        finally
        {
          IEnumerator<dsSecurityManagement.tblUsersRow> enumerator;
          enumerator?.Dispose();
        }
      }
    }
    if (this.lvGroups.SelectedItems.Count != 0)
      return;
    this.lvGroups.Items[0].Selected = true;
  }

  private void btnNewGroup_Click(object sender, EventArgs e) => this.DoNewGroup();

  private void DoNewGroup()
  {
    FormSecurityManagementNewGroup managementNewGroup = new FormSecurityManagementNewGroup();
    try
    {
      if (managementNewGroup.ShowDialog() != DialogResult.OK)
        return;
      Guid GroupGuid = Guid.NewGuid();
      this.DsSecurityManagement.tblSecurityGroups.AddtblSecurityGroupsRow(this.EnsureUniqueGroupName(managementNewGroup.GroupName), GroupGuid, managementNewGroup.GroupDescription);
      this.daGroups.Update((DataSet) this.DsSecurityManagement, "tblSecurityGroups");
      if (managementNewGroup.ShouldCopyGroupPermissions)
        DefaultDatabase.ExecuteNonQuery(CommandType.Text, "INSERT INTO tblSecurityUsersGroupsPermissions SELECT ResourceGUID,PermissionBits,NULL,@NewGroupGUID FROM tblSecurityUsersGroupsPermissions WHERE GroupGUID = @GroupGUID", new object[4]
        {
          (object) "@NewGroupGUID",
          (object) GroupGuid,
          (object) "@GroupGUID",
          (object) managementNewGroup.CopyGroupPermissionGuid
        });
      this.UIRefreshGroups();
    }
    finally
    {
      managementNewGroup.Dispose();
    }
  }

  private string EnsureUniqueGroupName(string proposedName)
  {
    DataRow[] dataRowArray = this.DsSecurityManagement.tblSecurityGroups.Select(string.Format((IFormatProvider) Thread.CurrentThread.CurrentCulture, "Name = '{0}'", (object) proposedName.Replace("'", "''")));
    string str = proposedName;
    int num = 1;
    for (; dataRowArray.Length > 0; dataRowArray = this.DsSecurityManagement.tblSecurityGroups.Select(string.Format((IFormatProvider) Thread.CurrentThread.CurrentCulture, "Name = '{0}'", (object) str.Replace("'", "''"))))
    {
      str = string.Format((IFormatProvider) Thread.CurrentThread.CurrentCulture, "{0} ({1})", (object) str.Replace(string.Format((IFormatProvider) Thread.CurrentThread.CurrentCulture, " ({0})", (object) checked (num - 1)), ""), (object) num);
      checked { ++num; }
    }
    return str;
  }

  private void lvGroups_SelectedIndexChanged(object sender, EventArgs e)
  {
    ((Control) this.btnDeleteGroup).Enabled = this.EnableDelete;
    ((Control) this.btnGroupProps).Enabled = this.EnableProperties;
    this.SetResourceItemsAccessStatus();
    this.lvResources.Enabled = this.lvGroups.SelectedItems.Count > 0;
  }

  private void btnDeleteGroup_Click(object sender, EventArgs e) => this.DoDeleteGroup();

  private void DoDeleteGroup()
  {
    if (MessageBox.Show(SR.GetString("SECURITY_ADMIN_SEC_USERS_DELETE"), SR.GetString("SECURITY_ADMIN_SEC_USERS_DELETE_CAPTION"), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
    {
      bool flag;
      try
      {
        foreach (ListViewItem selectedItem in this.lvGroups.SelectedItems)
        {
          if (selectedItem is FormAdminSecurityUsers.GroupListViewItem groupListViewItem)
          {
            this.DsSecurityManagement.tblSecurityGroups.FindByGroupGuid(groupListViewItem.GroupGuid).Delete();
            flag = true;
          }
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      if (flag)
      {
        this.daGroups.Update((DataSet) this.DsSecurityManagement, "tblSecurityGroups");
        this.UIRefreshGroups();
      }
    }
    ((Control) this.btnDeleteGroup).Enabled = this.EnableDelete;
    ((Control) this.btnGroupProps).Enabled = this.EnableProperties;
  }

  private void pnlGroupUsers_SizeChanged(object sender, EventArgs e)
  {
    Panel panel = (Panel) sender;
    if (panel.Size.Width >= this._pnlGroupUsersOriginalSize.Width)
      return;
    panel.Size = new Size(this._pnlGroupUsersOriginalSize.Width, panel.Size.Height);
  }

  private void lvGroups_MouseUp(object sender, MouseEventArgs e)
  {
    ((Control) this.btnDeleteGroup).Enabled = this.EnableDelete;
    ((Control) this.btnGroupProps).Enabled = this.EnableProperties;
  }

  private bool EnableDelete
  {
    get
    {
      bool enableDelete;
      if (SecurityManager.Instance.AssertPermission("{4505EA7A-68FA-4488-A824-BAC819D040DC}"))
      {
        if (this.lvGroups.SelectedItems.Count > 0)
        {
          try
          {
            foreach (ListViewItem selectedItem in this.lvGroups.SelectedItems)
            {
              if (selectedItem is FormAdminSecurityUsers.GroupListViewItem groupListViewItem && !groupListViewItem.GroupGuid.Equals(this._adminGroupGuid))
              {
                enableDelete = true;
                goto label_11;
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
        enableDelete = false;
      }
      else
        enableDelete = false;
label_11:
      return enableDelete;
    }
  }

  public int Compare(object x, object y)
  {
    ListViewItem listViewItem1 = (ListViewItem) x;
    ListViewItem listViewItem2 = (ListViewItem) y;
    int num;
    if (listViewItem1.ListView == this.lvGroups)
    {
      FormAdminSecurityUsers.GroupListViewItem groupListViewItem1 = x as FormAdminSecurityUsers.GroupListViewItem;
      FormAdminSecurityUsers.GroupListViewItem groupListViewItem2 = y as FormAdminSecurityUsers.GroupListViewItem;
      FormAdminSecurityUsers.UserListViewItem userListViewItem1 = x as FormAdminSecurityUsers.UserListViewItem;
      FormAdminSecurityUsers.UserListViewItem userListViewItem2 = y as FormAdminSecurityUsers.UserListViewItem;
      num = groupListViewItem1 == null || groupListViewItem2 == null ? (userListViewItem1 == null || userListViewItem2 == null ? (groupListViewItem1 == null || userListViewItem2 == null ? 1 : -1) : (userListViewItem1.StatusID >= userListViewItem2.StatusID ? (userListViewItem1.StatusID <= userListViewItem2.StatusID ? string.Compare(listViewItem1.Text, listViewItem2.Text) : 1) : -1)) : string.Compare(listViewItem1.Text, listViewItem2.Text);
    }
    else
    {
      FormAdminSecurityUsers.ResourceListItem resourceListItem1 = (FormAdminSecurityUsers.ResourceListItem) x;
      FormAdminSecurityUsers.ResourceListItem resourceListItem2 = (FormAdminSecurityUsers.ResourceListItem) y;
      num = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(resourceListItem1.Group, resourceListItem2.Group, false) != 0 ? string.Compare(resourceListItem1.Group, resourceListItem2.Group) : string.Compare(resourceListItem1.Name, resourceListItem2.Name);
    }
    return num;
  }

  private string GetSecurityGroupName(Guid resGuid)
  {
    string securityGroupName;
    if (this._groupHash.ContainsKey(resGuid.ToString()))
    {
      securityGroupName = this._groupHash[resGuid.ToString()];
    }
    else
    {
      if (this._externalResources == null)
      {
        this._externalResources = new Dictionary<Guid, string>();
        DataTable dataTable = DefaultDatabase.ExecuteDataTable("DocumentSystem_GetFolderSecurityResources");
        try
        {
          foreach (DataRow row in dataTable.Rows)
            this._externalResources.Add((Guid) row["SecureResourceGuid"], "Folder");
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
      }
      securityGroupName = !this._externalResources.ContainsKey(resGuid) ? string.Empty : this._externalResources[resGuid];
    }
    return securityGroupName;
  }

  public static void UpdateSecureResources()
  {
    Database.Instance.PerformTransactionQuerySet(new Database.TransactionQuerySetEventHandler(FormAdminSecurityUsers.SharedUpdateSecureResources_TransactionedQuerySet));
  }

  private static object SharedUpdateSecureResources_TransactionedQuerySet(
    object sender,
    QuerySetHandlerEventArgs e)
  {
    Dictionary<Guid, FormAdminSecurityUsers.ResourceNameDescription> dictionary = new Dictionary<Guid, FormAdminSecurityUsers.ResourceNameDescription>();
    DataTable dataTable = e.Database.QueryText.PerformTableQuery("SELECT ResourceGuid, Name, Description FROM dbo.lstSecurityResources");
    try
    {
      foreach (DataRow row in dataTable.Rows)
        dictionary.Add((Guid) row["ResourceGuid"], new FormAdminSecurityUsers.ResourceNameDescription(row));
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    Type[] typeArray1 = ObjectFactory.Instance.QueryTypesWithAttribute((Attribute) new SecureResourceAttribute());
    int index1 = 0;
    while (index1 < typeArray1.Length)
    {
      object[] customAttributes = typeArray1[index1].GetCustomAttributes(typeof (SecureResourceAttribute), false);
      if (customAttributes != null)
      {
        object[] objArray = customAttributes;
        int index2 = 0;
        while (index2 < objArray.Length)
        {
          // ISSUE: object of a compiler-generated type is created
          // ISSUE: variable of a compiler-generated type
          FormAdminSecurityUsers._Closure\u0024__175\u002D0 closure1750 = new FormAdminSecurityUsers._Closure\u0024__175\u002D0(closure1750);
          // ISSUE: reference to a compiler-generated field
          closure1750.\u0024VB\u0024Local_securityAttribute = (SecureResourceAttribute) objArray[index2];
          // ISSUE: reference to a compiler-generated field
          if (dictionary.ContainsKey(closure1750.\u0024VB\u0024Local_securityAttribute.UniqueIdentifier))
          {
            // ISSUE: reference to a compiler-generated field
            FormAdminSecurityUsers.ResourceNameDescription resourceNameDescription = dictionary[closure1750.\u0024VB\u0024Local_securityAttribute.UniqueIdentifier];
            // ISSUE: reference to a compiler-generated field
            dictionary.Remove(closure1750.\u0024VB\u0024Local_securityAttribute.UniqueIdentifier);
            // ISSUE: reference to a compiler-generated field
            string Right1 = closure1750.\u0024VB\u0024Local_securityAttribute.Description.Replace("'", string.Empty);
            // ISSUE: reference to a compiler-generated field
            string Right2 = closure1750.\u0024VB\u0024Local_securityAttribute.Name.Replace("'", string.Empty);
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(resourceNameDescription.Description, Right1, false) != 0 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(resourceNameDescription.Name, Right2, false) != 0)
            {
              string queryText = "UPDATE dbo.lstSecurityResources SET Name = @name, Description = @description WHERE ResourceGuid = @resourceGuid";
              // ISSUE: reference to a compiler-generated field
              e.Database.QueryText.PerformNonQuery(queryText, (object) "@name", (object) Right2, (object) "@description", (object) Right1, (object) "@resourceGuid", (object) closure1750.\u0024VB\u0024Local_securityAttribute.UniqueIdentifier);
            }
          }
          else
          {
            try
            {
              string queryText = "INSERT INTO dbo.lstSecurityResources (Name, Description, ResourceGuid) VALUES (@name,@description,@resourceGUID)";
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              e.Database.QueryText.PerformNonQuery(queryText, (object) "@name", (object) closure1750.\u0024VB\u0024Local_securityAttribute.Name, (object) "@description", (object) closure1750.\u0024VB\u0024Local_securityAttribute.Description, (object) "@resourceGUID", (object) closure1750.\u0024VB\u0024Local_securityAttribute.UniqueIdentifier);
            }
            catch (SqlException ex)
            {
              ProjectData.SetProjectError((Exception) ex);
              SqlException innerException = ex;
              Guid uniqueIdentifier;
              if (innerException.Message.IndexOf("Violation of PRIMARY KEY constraint 'permissions_pk") != -1)
              {
                // ISSUE: reference to a compiler-generated method
                Type[] array = ((IEnumerable<Type>) ObjectFactory.Instance.QueryTypesWithAttribute((Attribute) new SecureResourceAttribute())).Where<Type>(new System.Func<Type, bool>(closure1750._Lambda\u0024__0)).ToArray<Type>();
                StringBuilder stringBuilder1 = new StringBuilder();
                StringBuilder stringBuilder2 = stringBuilder1;
                // ISSUE: reference to a compiler-generated field
                uniqueIdentifier = closure1750.\u0024VB\u0024Local_securityAttribute.UniqueIdentifier;
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                string str = SR.GetString("SECURITY_ADMIN_ITEM_ALREADY_EXISTS", (object) uniqueIdentifier.ToString(), (object) closure1750.\u0024VB\u0024Local_securityAttribute.Name, (object) closure1750.\u0024VB\u0024Local_securityAttribute.Description);
                stringBuilder2.AppendLine(str);
                stringBuilder1.AppendLine();
                stringBuilder1.AppendLine("Conflicting Types:");
                Type[] typeArray2 = array;
                int index3 = 0;
                while (index3 < typeArray2.Length)
                {
                  Type type = typeArray2[index3];
                  stringBuilder1.AppendLine(type.FullName);
                  checked { ++index3; }
                }
                int num = (int) MessageBox.Show(stringBuilder1.ToString(), SR.GetString("SECURITY_ADMIN_ITEM_ALREADY_EXISTS_CAPTION"), MessageBoxButtons.OK, MessageBoxIcon.Hand);
              }
              // ISSUE: reference to a compiler-generated field
              uniqueIdentifier = closure1750.\u0024VB\u0024Local_securityAttribute.UniqueIdentifier;
              // ISSUE: reference to a compiler-generated field
              throw new InvalidOperationException($"Security attribute is specified more than once {uniqueIdentifier.ToString()} {closure1750.\u0024VB\u0024Local_securityAttribute.Name}", (Exception) innerException);
            }
          }
          checked { ++index2; }
        }
      }
      checked { ++index1; }
    }
    return (object) null;
  }

  private void ResourceList_TableFilled(object sender, TableQueryMultithreadEventArgs e)
  {
    this.lvResources.Items.Clear();
    this._resourceListItemHash = new Dictionary<string, FormAdminSecurityUsers.ResourceListItem>();
    try
    {
      foreach (DataRow row in e.Table.Rows)
      {
        FormAdminSecurityUsers.ResourceListItem resourceListItem = new FormAdminSecurityUsers.ResourceListItem(row, this);
        this.lvResources.Items.Add((ListViewItem) resourceListItem);
        this._resourceListItemHash.Add(resourceListItem.ResourceGuid.ToString(), resourceListItem);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    this.lvResources.ListViewItemSorter = (IComparer) this;
    this.lvResources.Sorting = System.Windows.Forms.SortOrder.Ascending;
    this.lvResources.Sort();
    this._resourceListFilled = true;
    this.SetResourceItemsAccessStatus();
  }

  private void SetResourceItemsAccessStatus() => this.SetResourceItemsAccessStatus(false);

  private void SetResourceItemsAccessStatus(bool rejectChanges)
  {
    this.lvResources.BeginUpdate();
    if (!this._resourceListFilled || this.lvGroups.SelectedItems.Count == 0)
      return;
    if (!rejectChanges)
    {
      if (this.ResourceListHasChanges)
      {
        switch (MessageBox.Show(SR.GetString("SECURITY_ADMIN_SEC_USERS"), SR.GetString("SECURITY_ADMIN_SEC_USERS_CAPTION"), MessageBoxButtons.YesNo, MessageBoxIcon.Question))
        {
          case DialogResult.Yes:
            this.SaveResourceListChanges();
            break;
        }
      }
      this._lastSelectedGroupItem = this.lvGroups.SelectedItems[0];
    }
    bool isAdminGroup = false;
    DataTable permissionTable = (DataTable) null;
    if (this.lvGroups.SelectedItems[0] is FormAdminSecurityUsers.GroupListViewItem)
    {
      string str = "SELECT ResourceGuid, PermissionBits FROM tblSecurityUsersGroupsPermissions WHERE GroupGuid = @GroupGuid";
      if (((FormAdminSecurityUsers.GroupListViewItem) this.lvGroups.SelectedItems[0]).GroupGuid.Equals(this._adminGroupGuid))
        isAdminGroup = true;
      permissionTable = DefaultDatabase.ExecuteDataTable(CommandType.Text, str, new object[2]
      {
        (object) "@GroupGuid",
        (object) ((FormAdminSecurityUsers.GroupListViewItem) this.lvGroups.SelectedItems[0]).GroupGuid
      });
    }
    else if (this.lvGroups.SelectedItems[0] is FormAdminSecurityUsers.UserListViewItem)
      permissionTable = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT ResourceGuid, PermissionBits FROM tblSecurityUsersGroupsPermissions WHERE UserGuid = @UserGuid", new object[2]
      {
        (object) "@UserGuid",
        (object) ((FormAdminSecurityUsers.UserListViewItem) this.lvGroups.SelectedItems[0]).UserGuid
      });
    try
    {
      foreach (FormAdminSecurityUsers.ResourceListItem resourceListItem in this.lvResources.Items)
        resourceListItem.InitializeAccess(FormAdminSecurityUsers.ResourceAccess.Unspecified);
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    if (permissionTable == null)
      return;
    this.InitializeAccess(isAdminGroup, permissionTable);
    this.lvResources.SelectedItems.Clear();
    if (this.lvResources.Items.Count > 0)
      this.lvResources.Items[0].Selected = true;
    this.lvResources.EndUpdate();
    this.EnableControls(isAdminGroup);
  }

  private void EnableControls(bool isAdminGroup)
  {
    if (SecurityManager.Instance.AssertPermission("{8A5A4DD8-9A47-4c18-87FF-1530229CCE82}"))
    {
      ((Control) this.chkGrant).Enabled = !isAdminGroup;
      ((Control) this.chkDeny).Enabled = !isAdminGroup;
      ((Control) this.btnCancelChanges).Visible = true;
      ((Control) this.btnApplyChanges).Visible = true;
    }
    else
    {
      ((Control) this.chkGrant).Enabled = false;
      ((Control) this.chkDeny).Enabled = false;
      ((Control) this.btnCancelChanges).Visible = false;
      ((Control) this.btnApplyChanges).Visible = false;
    }
  }

  private void InitializeAccess(bool isAdminGroup, DataTable permissionTable)
  {
    if (isAdminGroup)
    {
      try
      {
        foreach (FormAdminSecurityUsers.ResourceListItem resourceListItem in this.lvResources.Items)
          resourceListItem.InitializeAccess(FormAdminSecurityUsers.ResourceAccess.Grant);
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
    else
    {
      try
      {
        foreach (DataRow row in permissionTable.Rows)
        {
          object obj = row["ResourceGuid"];
          Guid guid = obj != null ? (Guid) obj : new Guid();
          if (this._resourceListItemHash != null && this._resourceListItemHash.ContainsKey(guid.ToString()))
          {
            FormAdminSecurityUsers.ResourceListItem resourceListItem = this._resourceListItemHash[guid.ToString()];
            switch (Conversions.ToInteger(row["PermissionBits"]))
            {
              case 0:
                resourceListItem.InitializeAccess(FormAdminSecurityUsers.ResourceAccess.Deny);
                continue;
              case 1:
                resourceListItem.InitializeAccess(FormAdminSecurityUsers.ResourceAccess.Grant);
                continue;
              default:
                continue;
            }
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

  private bool ResourceListHasChanges
  {
    get
    {
      bool resourceListHasChanges;
      try
      {
        foreach (FormAdminSecurityUsers.ResourceListItem resourceListItem in this.lvResources.Items)
        {
          if (resourceListItem.HasChanges)
          {
            resourceListHasChanges = true;
            goto label_8;
          }
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      resourceListHasChanges = false;
label_8:
      return resourceListHasChanges;
    }
  }

  private object SaveResourceListChangesQuerySet(object sender, QuerySetHandlerEventArgs e)
  {
    Guid contextGuid;
    bool isUserGuid;
    if (this._lastSelectedGroupItem is FormAdminSecurityUsers.UserListViewItem)
    {
      contextGuid = ((FormAdminSecurityUsers.UserListViewItem) this._lastSelectedGroupItem).UserGuid;
      isUserGuid = true;
    }
    else
    {
      contextGuid = ((FormAdminSecurityUsers.GroupListViewItem) this._lastSelectedGroupItem).GroupGuid;
      isUserGuid = false;
    }
    try
    {
      foreach (FormAdminSecurityUsers.ResourceListItem resourceListItem in this.lvResources.Items)
      {
        if (resourceListItem.HasChanges)
        {
          this.LogPermissionChange(resourceListItem, isUserGuid, contextGuid, e);
          DatabaseQueryText queryText1 = e.Database.QueryText;
          StringBuilder stringBuilder = new StringBuilder("SELECT UserGroupPermissionID FROM tblSecurityUsersGroupsPermissions WHERE ResourceGuid = @ResourceGuid AND ");
          if (isUserGuid)
            stringBuilder.Append("UserGuid = @ContextGuid");
          else
            stringBuilder.Append("GroupGuid = @ContextGuid");
          int num = queryText1.PerformScalarQueryInt(stringBuilder.ToString(), -1, (object) "@ResourceGuid", (object) resourceListItem.ResourceGuid, (object) "@ContextGuid", (object) contextGuid);
          switch (resourceListItem.Access)
          {
            case FormAdminSecurityUsers.ResourceAccess.Deny:
            case FormAdminSecurityUsers.ResourceAccess.Grant:
              if (num == -1)
              {
                string queryText2 = !isUserGuid ? "INSERT INTO tblSecurityUsersGroupsPermissions (ResourceGuid, PermissionBits, GroupGuid)VALUES(@ResourceGuid, @PermissionBits, @ContextGuid)" : "INSERT INTO tblSecurityUsersGroupsPermissions (ResourceGuid, PermissionBits, UserGuid)VALUES(@ResourceGuid, @PermissionBits, @ContextGuid)";
                queryText1.PerformNonQuery(queryText2, (object) "@ResourceGuid", (object) resourceListItem.ResourceGuid, (object) "@PermissionBits", (object) (int) resourceListItem.Access, (object) "@ContextGuid", (object) contextGuid);
                break;
              }
              string queryText3 = "UPDATE tblSecurityUsersGroupsPermissions SET PermissionBits = @PermissionBits WHERE UserGroupPermissionID = @UserGroupPermissionID";
              queryText1.PerformNonQuery(queryText3, (object) "@PermissionBits", (object) (int) resourceListItem.Access, (object) "@UserGroupPermissionID", (object) num);
              break;
            case FormAdminSecurityUsers.ResourceAccess.Unspecified:
              if (num != -1)
              {
                queryText1.PerformNonQuery("DELETE FROM tblSecurityUsersGroupsPermissions WHERE UserGroupPermissionID = @UserGroupPermissionID", (object) "@UserGroupPermissionID", (object) num);
                break;
              }
              break;
          }
          resourceListItem.AcceptChanges();
        }
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    return (object) null;
  }

  private void LogPermissionChange(
    FormAdminSecurityUsers.ResourceListItem item,
    bool isUserGuid,
    Guid contextGuid,
    QuerySetHandlerEventArgs e)
  {
    string str1 = "Access to the [{0}] resource has been {1} to {2}.";
    DatabaseQueryText queryText = e.Database.QueryText;
    string str2;
    if (isUserGuid)
      str2 = queryText.PerformScalarQueryString("select lastname + ', ' + firstname + ' [' + username + ']' as FullName from tblusers where userguid = @userguid", (object) "@userguid", (object) contextGuid).Trim();
    else
      str2 = "the " + queryText.PerformScalarQueryString("select [name] from tblsecuritygroups where groupGuid = @groupGuid", (object) "@groupGuid", (object) contextGuid).Trim() + " group";
    try
    {
      switch (item.Access)
      {
        case FormAdminSecurityUsers.ResourceAccess.Deny:
          str1 = string.Format(str1, (object) item.Name, (object) "denied", (object) str2);
          break;
        case FormAdminSecurityUsers.ResourceAccess.Grant:
          str1 = string.Format(str1, (object) item.Name, (object) "granted", (object) str2);
          break;
        case FormAdminSecurityUsers.ResourceAccess.Unspecified:
          str1 = string.Format(str1, (object) item.Name, (object) "revoked", (object) str2);
          break;
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      str1 = "Error Occurred Logging Permission Change";
      ProjectData.ClearProjectError();
    }
    CurrentUser.Instance.LogAction(str1, "Security Change");
  }

  private void SaveResourceListChanges()
  {
    if (!this.ResourceListHasChanges)
      return;
    if (this._lastSelectedGroupItem == null)
    {
      int num = (int) Interaction.MsgBox((object) "help");
    }
    else
      Database.Instance.PerformTransactionQuerySet(new Database.TransactionQuerySetEventHandler(this.SaveResourceListChangesQuerySet));
  }

  private void lvResources_SelectedIndexChanged(object sender, EventArgs e)
  {
    this.selIndexChanging = true;
    if (this.lvResources.SelectedItems.Count == 1)
    {
      FormAdminSecurityUsers.ResourceListItem selectedItem = (FormAdminSecurityUsers.ResourceListItem) this.lvResources.SelectedItems[0];
      this.lblResourceInfo.Text = selectedItem.Description;
      switch (selectedItem.Access)
      {
        case FormAdminSecurityUsers.ResourceAccess.Deny:
          ((UltraToggleEditorBase) this.chkDeny).Checked = true;
          ((UltraToggleEditorBase) this.chkGrant).Checked = false;
          break;
        case FormAdminSecurityUsers.ResourceAccess.Grant:
          ((UltraToggleEditorBase) this.chkGrant).Checked = true;
          ((UltraToggleEditorBase) this.chkDeny).Checked = false;
          break;
        case FormAdminSecurityUsers.ResourceAccess.Unspecified:
          ((UltraToggleEditorBase) this.chkDeny).Checked = false;
          ((UltraToggleEditorBase) this.chkGrant).Checked = false;
          break;
      }
    }
    this.selIndexChanging = false;
  }

  private void chkGrant_CheckedChanged(object sender, EventArgs e)
  {
    if (this.selIndexChanging)
      return;
    this.selIndexChanging = true;
    FormAdminSecurityUsers.ResourceAccess resourceAccess = FormAdminSecurityUsers.ResourceAccess.Unspecified;
    if (((UltraToggleEditorBase) this.chkGrant).Checked)
    {
      ((UltraToggleEditorBase) this.chkDeny).Checked = false;
      resourceAccess = FormAdminSecurityUsers.ResourceAccess.Grant;
    }
    try
    {
      foreach (FormAdminSecurityUsers.ResourceListItem selectedItem in this.lvResources.SelectedItems)
        selectedItem.Access = resourceAccess;
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    this.selIndexChanging = false;
  }

  private void chkDeny_CheckedChanged(object sender, EventArgs e)
  {
    if (this.selIndexChanging)
      return;
    this.selIndexChanging = true;
    FormAdminSecurityUsers.ResourceAccess resourceAccess = FormAdminSecurityUsers.ResourceAccess.Unspecified;
    if (((UltraToggleEditorBase) this.chkDeny).Checked)
    {
      ((UltraToggleEditorBase) this.chkGrant).Checked = false;
      resourceAccess = FormAdminSecurityUsers.ResourceAccess.Deny;
    }
    try
    {
      foreach (FormAdminSecurityUsers.ResourceListItem selectedItem in this.lvResources.SelectedItems)
        selectedItem.Access = resourceAccess;
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    this.selIndexChanging = false;
  }

  private void btnApplyChanges_Click(object sender, EventArgs e) => this.SaveResourceListChanges();

  private void btnGroupProps_Click(object sender, EventArgs e) => this.DoGroupProperties();

  private void DoGroupProperties()
  {
    if (this.lvGroups.SelectedItems.Count > 0 && this.lvGroups.SelectedItems[0] is FormAdminSecurityUsers.GroupListViewItem)
    {
      this.OpenGroupProperties(((FormAdminSecurityUsers.GroupListViewItem) this.lvGroups.SelectedItems[0]).GroupGuid);
    }
    else
    {
      if (this.lvGroups.SelectedItems.Count <= 0 || !(this.lvGroups.SelectedItems[0] is FormAdminSecurityUsers.UserListViewItem))
        return;
      this.OpenUserProperties(((FormAdminSecurityUsers.UserListViewItem) this.lvGroups.SelectedItems[0]).UserGuid);
    }
  }

  private void lvGroups_DoubleClick(object sender, EventArgs e)
  {
    Point client = this.lvGroups.PointToClient(Cursor.Position);
    object itemAt = (object) this.lvGroups.GetItemAt(client.X, client.Y);
    FormAdminSecurityUsers.GroupListViewItem groupListViewItem = itemAt as FormAdminSecurityUsers.GroupListViewItem;
    FormAdminSecurityUsers.UserListViewItem userListViewItem = itemAt as FormAdminSecurityUsers.UserListViewItem;
    if (itemAt != null && groupListViewItem != null)
    {
      this.OpenGroupProperties(groupListViewItem.GroupGuid);
    }
    else
    {
      if (itemAt == null || userListViewItem == null)
        return;
      this.OpenUserProperties(userListViewItem.UserGuid);
    }
  }

  private void OpenGroupProperties(Guid groupGuid)
  {
    FormSecurityGroupProperties securityGroupProperties = new FormSecurityGroupProperties(groupGuid);
    try
    {
      if (securityGroupProperties.ShowDialog((IWin32Window) this) != DialogResult.OK)
        return;
      this.DsSecurityManagement.tblSecurityGroups.Clear();
      this.daGroups.Fill((DataTable) this.DsSecurityManagement.tblSecurityGroups);
      this.UIRefreshGroups();
    }
    finally
    {
      securityGroupProperties.Dispose();
    }
  }

  private void OpenUserProperties(Guid userGuid)
  {
    FormSecurityUserMemberList securityUserMemberList = new FormSecurityUserMemberList(userGuid);
    try
    {
      if (securityUserMemberList.ShowDialog((IWin32Window) this) != DialogResult.OK)
        return;
      this.UIRefreshGroups();
    }
    finally
    {
      securityUserMemberList.Dispose();
    }
  }

  private void btnCancelChanges_Click(object sender, EventArgs e)
  {
    this.SetResourceItemsAccessStatus(true);
  }

  private void ctxGroups_Popup(object sender, EventArgs e)
  {
    if (SecurityManager.Instance.AssertPermission("{4505EA7A-68FA-4488-A824-BAC819D040DC}"))
    {
      if (this.lvGroups.SelectedItems.Count == 0)
      {
        this.mnuDoDeleteGroup.Visible = false;
        this.mnuProperties.Visible = false;
        this.mnuSeperator.Visible = false;
      }
      else
      {
        if (this.lvGroups.SelectedItems.Count <= 0)
          return;
        this.mnuSeperator.Visible = true;
        if (this.lvGroups.SelectedItems[0] is FormAdminSecurityUsers.UserListViewItem)
        {
          this.mnuDoDeleteGroup.Visible = false;
          this.mnuProperties.Visible = true;
        }
        else
        {
          this.mnuDoDeleteGroup.Visible = this.EnableDelete;
          this.mnuProperties.Visible = true;
        }
      }
    }
    else
    {
      this.mnuDoDeleteGroup.Visible = false;
      this.mnuNewGroup.Visible = false;
      this.mnuProperties.Visible = false;
      this.mnuSeperator.Visible = false;
    }
  }

  private void ctxResources_Popup(object sender, EventArgs e)
  {
    bool flag = false;
    if (this.lvGroups.SelectedItems[0] is FormAdminSecurityUsers.GroupListViewItem && ((FormAdminSecurityUsers.GroupListViewItem) this.lvGroups.SelectedItems[0]).GroupGuid.Equals(this._adminGroupGuid))
      flag = true;
    if (flag)
    {
      this.mnuUnspecified.Visible = false;
      this.mnuGrant.Visible = false;
      this.mnuDeny.Visible = false;
    }
    else if (!((UltraToggleEditorBase) this.chkGrant).Checked && !((UltraToggleEditorBase) this.chkDeny).Checked)
    {
      this.mnuUnspecified.Visible = false;
      this.mnuGrant.Visible = true;
      this.mnuDeny.Visible = true;
    }
    else if (((UltraToggleEditorBase) this.chkGrant).Checked)
    {
      this.mnuUnspecified.Visible = true;
      this.mnuGrant.Visible = false;
      this.mnuDeny.Visible = true;
    }
    else
    {
      if (!((UltraToggleEditorBase) this.chkDeny).Checked)
        return;
      this.mnuUnspecified.Visible = true;
      this.mnuGrant.Visible = true;
      this.mnuDeny.Visible = false;
    }
  }

  private void mnuNewGroup_Click(object sender, EventArgs e) => this.DoNewGroup();

  private void mnuDeleteGroup_Click(object sender, EventArgs e) => this.DoDeleteGroup();

  private void mnuProperties_Click(object sender, EventArgs e) => this.DoGroupProperties();

  private void mnuDeny_Click(object sender, EventArgs e)
  {
    ((UltraToggleEditorBase) this.chkDeny).Checked = true;
  }

  private void mnuUnspecified_Click(object sender, EventArgs e)
  {
    ((UltraToggleEditorBase) this.chkDeny).Checked = false;
    ((UltraToggleEditorBase) this.chkGrant).Checked = false;
  }

  private void mnuGrant_Click(object sender, EventArgs e)
  {
    ((UltraToggleEditorBase) this.chkGrant).Checked = true;
  }

  private void UltraToolbarsManager1_ToolClick(object sender, ToolClickEventArgs e)
  {
    string key = ((ToolEventArgs) e).Tool.Key;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "IMPORTASP", false) == 0)
      return;
    Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "EXPORTASP", false);
  }

  private void chkShowUsers_CheckedChanged(object sender, EventArgs e) => this.UIRefreshGroups();

  private void pnlGroupUsers_MouseDown(object sender, MouseEventArgs e)
  {
    if (e.Button != MouseButtons.Right)
      return;
    frmDisplayFoundSecurityAttributes securityAttributes = new frmDisplayFoundSecurityAttributes();
    int num = (int) securityAttributes.ShowDialog();
    securityAttributes.Dispose();
  }

  private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
  {
    FormAdminSecurityUsers.UpdateSecureResources();
  }

  private void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
  {
    this._pnlGroupUsersOriginalSize = this.pnlGroupUsers.Size;
    if (SecurityManager.Instance.AssertPermission("{4505EA7A-68FA-4488-A824-BAC819D040DC}"))
      ((Control) this.btnNewGroup).Enabled = true;
    else
      ((Control) this.btnNewGroup).Enabled = false;
    if (!SecurityManager.Instance.AssertPermission("{5C9F26FC-90F6-4561-B556-A0150DEDC8BC}"))
    {
      ((ToolsCollectionBase) this.UltraToolbarsManager1.Tools)["IMPORTASP"].SharedProps.Visible = false;
      ((ToolsCollectionBase) this.UltraToolbarsManager1.Tools)["EXPORTASP"].SharedProps.Visible = false;
    }
    ((UltraToggleEditorBase) this.chkShowUsers).CheckedChanged += new EventHandler(this.chkShowUsers_CheckedChanged);
    this.pnlLoad.Visible = false;
  }

  private enum ImageIndexes
  {
    User,
    Group,
    Resource,
  }

  private sealed class UserListViewItem : ListViewItem
  {
    private Guid _userGuid;
    private int _statusID;

    public UserListViewItem(dsSecurityManagement.tblUsersRow user)
      : base(user.FullName)
    {
      this._userGuid = user.UserGuid;
      this._statusID = (int) user.StatusID;
      if (user.StatusID > (byte) 1)
        this.ForeColor = SystemColors.GrayText;
      this.ImageIndex = 0;
    }

    public Guid UserGuid => this._userGuid;

    public int StatusID => this._statusID;
  }

  private sealed class GroupListViewItem : ListViewItem
  {
    private Guid _groupGuid;

    public GroupListViewItem(dsSecurityManagement.tblSecurityGroupsRow group)
      : base(group.Name)
    {
      this._groupGuid = group.GroupGuid;
      this.ImageIndex = 1;
      this.SubItems.Add(group.Description);
    }

    public Guid GroupGuid => this._groupGuid;
  }

  private sealed class ResourceNameDescription
  {
    private string _name;
    private string _desc;

    public ResourceNameDescription(DataRow row)
    {
      if (!row.IsNull(nameof (Description)))
        this._desc = Conversions.ToString(row[nameof (Description)]);
      this._name = Conversions.ToString(row["name"]);
    }

    public string Description => this._desc;

    public string Name => this._name;
  }

  private enum ResourceAccess
  {
    Deny,
    Grant,
    Unspecified,
  }

  private sealed class ResourceListItem : ListViewItem
  {
    private Guid _uniqueIdentifier;
    private string _description;
    private FormAdminSecurityUsers.ResourceAccess _access;
    private FormAdminSecurityUsers.ResourceAccess _originalAccessValue;
    private Font _originalFont;

    public ResourceListItem(DataRow row, FormAdminSecurityUsers frm)
      : base(Conversions.ToString(row[nameof (Name)]))
    {
      this._description = string.Empty;
      this._access = FormAdminSecurityUsers.ResourceAccess.Unspecified;
      this._originalAccessValue = FormAdminSecurityUsers.ResourceAccess.Unspecified;
      this._originalFont = this.Font;
      object obj = row[nameof (ResourceGuid)];
      this._uniqueIdentifier = obj != null ? (Guid) obj : new Guid();
      this.ImageIndex = 2;
      this.SubItems.Add(frm.GetSecurityGroupName(this._uniqueIdentifier));
      if (row.IsNull(nameof (Description)))
        return;
      this._description = Conversions.ToString(row[nameof (Description)]);
      this.SubItems.Add(this._description);
    }

    public string Description => this._description;

    public string Group => this.SubItems[1].Text;

    public new string Name => this.Text;

    public FormAdminSecurityUsers.ResourceAccess Access
    {
      get => this._access;
      set
      {
        this._access = value;
        this.SetColor();
        if (this.HasChanges)
          this.Font = new Font(this._originalFont, FontStyle.Bold);
        else
          this.Font = this._originalFont;
      }
    }

    private void SetColor()
    {
      switch (this._access)
      {
        case FormAdminSecurityUsers.ResourceAccess.Deny:
          this.ForeColor = Color.Red;
          break;
        case FormAdminSecurityUsers.ResourceAccess.Grant:
          this.ForeColor = Color.Green;
          break;
        case FormAdminSecurityUsers.ResourceAccess.Unspecified:
          this.ForeColor = Color.Black;
          break;
      }
    }

    public Guid ResourceGuid => this._uniqueIdentifier;

    public void InitializeAccess(FormAdminSecurityUsers.ResourceAccess access)
    {
      this._access = access;
      this._originalAccessValue = access;
      this.SetColor();
      this.Font = this._originalFont;
    }

    public bool HasChanges => this._access != this._originalAccessValue;

    public void AcceptChanges()
    {
      this.Font = this._originalFont;
      this._originalAccessValue = this._access;
    }
  }
}
