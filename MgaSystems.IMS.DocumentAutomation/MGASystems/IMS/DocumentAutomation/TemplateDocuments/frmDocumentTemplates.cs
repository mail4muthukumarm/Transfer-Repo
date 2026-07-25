// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.DocumentAutomation.TemplateDocuments.frmDocumentTemplates
// Assembly: MgaSystems.IMS.DocumentAutomation, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: B33F9A76-E654-4386-A032-7A12D7CD66DE
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.DocumentAutomation.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinScrollBar;
using Infragistics.Win.UltraWinToolbars;
using Infragistics.Win.UltraWinTree;
using Mga.Wpf.Ims.Interop;
using MGASystems.AsposeFacade.Words;
using MGASystems.Common;
using MGASystems.Common.CustomExceptions;
using MGASystems.Common.DataAccess;
using MGASystems.Common.ErrorHandling;
using MGASystems.Common.FileSystemObserver;
using MGASystems.Data;
using MGASystems.IMS.DocumentAutomation.DocumentPreview;
using MGASystems.IMS.DocumentAutomation.OfficeAuto;
using MGASystems.IMS.Reporting.AutomationReports;
using MGASystems.IMS.Security;
using MGASystems.Tools;
using MGASystems.Tools.BaseClasses;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.DocumentAutomation.TemplateDocuments;

[SecureResource("{278314E6-FFF6-4ef2-A5FD-4BE878B5C772}", "Access to Document Templates", "Controls the ability to grant users access to Document Templates.", "Document System")]
[SecureResource("{8FB31D86-F039-4A80-B3A5-E5434EEB2F3C}", "Force Delete Document Templates", "Determines whether user can force delete a document template on unsuccessful attempts.", "Document System")]
[SecureResource("{1AD2E14B-35ED-4093-A4A9-459BF2CB2CEA}", "Can Access Document Template Right-Click Menu", "Determines whether user can access the document template right-click menu", "Document System")]
public sealed class frmDocumentTemplates : MGABaseForm, ITransactionLogFilter
{
  private IContainer components;
  private SqlConnection cnSQL;
  private OpenFileDialog diagOpen;
  private dsDocumentTemplates ds;
  private UltraToolbarsDockArea _frmDocumentTemplates_Toolbars_Dock_Area_Left;
  private UltraToolbarsDockArea _frmDocumentTemplates_Toolbars_Dock_Area_Right;
  private UltraToolbarsDockArea _frmDocumentTemplates_Toolbars_Dock_Area_Top;
  private UltraToolbarsDockArea _frmDocumentTemplates_Toolbars_Dock_Area_Bottom;
  public const string CanViewDocumentTemplate = "{278314E6-FFF6-4ef2-A5FD-4BE878B5C772}";
  public const string CanForceDeleteTemplates = "{8FB31D86-F039-4A80-B3A5-E5434EEB2F3C}";
  public const string CanViewRightClickMenu = "{1AD2E14B-35ED-4093-A4A9-459BF2CB2CEA}";
  public const string TemplateSystemGUID = "{7CFE4C1A-F2B3-45bf-8B91-D2899A714B7E}";
  private List<int> _groupIDs;
  private ISupportTemplateDocs _supportingObject;
  private frmDocumentTemplates.ScreenModes _screenMode;
  private int _selectedTemplateID;
  private bool _showFoldersOnly;
  private int _limitToGroupID;
  private bool _folderSelected;
  private Point _lastMouseDownPoint;
  private bool _onDemandTemplates;
  private bool _editingWordPolling;
  private bool _hideOnDoubleClick;
  private string _selectedFolderName;
  private MGASystems.Common.FileSystemObserver.FileSystemObserver _fileWatcher;
  private Dictionary<string, int> _watchedFiles;
  private List<UltraTreeNode> tempselected;

  protected override void Dispose(bool disposing)
  {
    if (this._fileWatcher != null)
    {
      this._fileWatcher.ChangedEvent -= new FileSystemEvent(this.FileModified);
      this._fileWatcher.Stop();
    }
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private virtual UltraToolbarsManager toolbar
  {
    get => this._toolbar;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      BeforeToolDropdownEventHandler dropdownEventHandler = new BeforeToolDropdownEventHandler(this.toolbar_BeforeToolDropdown);
      ToolClickEventHandler clickEventHandler = new ToolClickEventHandler(this.toolbar_ToolClick);
      UltraToolbarsManager toolbar1 = this._toolbar;
      if (toolbar1 != null)
      {
        toolbar1.BeforeToolDropdown -= dropdownEventHandler;
        toolbar1.ToolClick -= clickEventHandler;
      }
      this._toolbar = value;
      UltraToolbarsManager toolbar2 = this._toolbar;
      if (toolbar2 == null)
        return;
      toolbar2.BeforeToolDropdown += dropdownEventHandler;
      toolbar2.ToolClick += clickEventHandler;
    }
  }

  internal virtual UltraTree tree
  {
    get => this._tree;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      AfterNodeSelectEventHandler selectEventHandler = new AfterNodeSelectEventHandler(this.tree_AfterSelect);
      MouseEventHandler mouseEventHandler1 = new MouseEventHandler(this.tree_MouseDown);
      EventHandler eventHandler = new EventHandler(this.tree_DoubleClick);
      MouseEventHandler mouseEventHandler2 = new MouseEventHandler(this.tree_MouseMove);
      DragEventHandler dragEventHandler1 = new DragEventHandler(this.tree_DragOver);
      DragEventHandler dragEventHandler2 = new DragEventHandler(this.tree_DragDrop);
      UltraTree tree1 = this._tree;
      if (tree1 != null)
      {
        tree1.AfterSelect -= selectEventHandler;
        ((Control) tree1).MouseDown -= mouseEventHandler1;
        ((Control) tree1).DoubleClick -= eventHandler;
        ((Control) tree1).MouseMove -= mouseEventHandler2;
        ((Control) tree1).DragOver -= dragEventHandler1;
        ((Control) tree1).DragDrop -= dragEventHandler2;
      }
      this._tree = value;
      UltraTree tree2 = this._tree;
      if (tree2 == null)
        return;
      tree2.AfterSelect += selectEventHandler;
      ((Control) tree2).MouseDown += mouseEventHandler1;
      ((Control) tree2).DoubleClick += eventHandler;
      ((Control) tree2).MouseMove += mouseEventHandler2;
      ((Control) tree2).DragOver += dragEventHandler1;
      ((Control) tree2).DragDrop += dragEventHandler2;
    }
  }

  [field: AccessedThroughProperty("ImageList1")]
  internal virtual ImageList ImageList1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlDeleteCommand1")]
  private virtual SqlCommand SqlDeleteCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlUpdateCommand1")]
  private virtual SqlCommand SqlUpdateCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlInsertCommand1")]
  private virtual SqlCommand SqlInsertCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlSelectCommand1")]
  private virtual SqlCommand SqlSelectCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("daTemplates")]
  private virtual SqlDataAdapter daTemplates { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGATextBox txtFolderFilter
  {
    get => this._txtFolderFilter;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.txtFolderFilter_TextChanged);
      MGATextBox txtFolderFilter1 = this._txtFolderFilter;
      if (txtFolderFilter1 != null)
        ((Control) txtFolderFilter1).TextChanged -= eventHandler;
      this._txtFolderFilter = value;
      MGATextBox txtFolderFilter2 = this._txtFolderFilter;
      if (txtFolderFilter2 == null)
        return;
      ((Control) txtFolderFilter2).TextChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("StatusStrip1")]
  internal virtual StatusStrip StatusStrip1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("StatusBarLabel")]
  internal virtual ToolStripStatusLabel StatusBarLabel { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblLoadingTemplates")]
  internal virtual Label lblLoadingTemplates { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGATextBox txtTemplateFilter
  {
    get => this._txtTemplateFilter;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.txtTemplateFilter_TextChanged);
      MGATextBox txtTemplateFilter1 = this._txtTemplateFilter;
      if (txtTemplateFilter1 != null)
        ((Control) txtTemplateFilter1).TextChanged -= eventHandler;
      this._txtTemplateFilter = value;
      MGATextBox txtTemplateFilter2 = this._txtTemplateFilter;
      if (txtTemplateFilter2 == null)
        return;
      ((Control) txtTemplateFilter2).TextChanged += eventHandler;
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    Override @override = new Override();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmDocumentTemplates));
    UltraToolbar ultraToolbar1 = new UltraToolbar("toolbar");
    ButtonTool buttonTool1 = new ButtonTool("New Template");
    ButtonTool buttonTool2 = new ButtonTool("Edit Template");
    ButtonTool buttonTool3 = new ButtonTool("Delete Template");
    ButtonTool buttonTool4 = new ButtonTool("Replace Template");
    ButtonTool buttonTool5 = new ButtonTool("PDF Preview");
    UltraToolbar ultraToolbar2 = new UltraToolbar("ContextMenu");
    UltraToolbar ultraToolbar3 = new UltraToolbar("FilterBar");
    ControlContainerTool controlContainerTool1 = new ControlContainerTool("FilterFolderContainer");
    ControlContainerTool controlContainerTool2 = new ControlContainerTool(" FilterTemplateContainer");
    ButtonTool buttonTool6 = new ButtonTool("Hide Folders");
    ButtonTool buttonTool7 = new ButtonTool("Show Deleted Templates");
    ButtonTool buttonTool8 = new ButtonTool("New Template");
    ButtonTool buttonTool9 = new ButtonTool("Edit Template");
    ButtonTool buttonTool10 = new ButtonTool("Replace Template");
    ButtonTool buttonTool11 = new ButtonTool("Delete Template");
    ButtonTool buttonTool12 = new ButtonTool("PDF Preview");
    ButtonTool buttonTool13 = new ButtonTool("New Folder");
    ButtonTool buttonTool14 = new ButtonTool("Delete Folder");
    PopupMenuTool popupMenuTool = new PopupMenuTool("PopupMenuTool1");
    ButtonTool buttonTool15 = new ButtonTool("New Folder");
    ButtonTool buttonTool16 = new ButtonTool("Delete Folder");
    ButtonTool buttonTool17 = new ButtonTool("Rename Folder");
    ButtonTool buttonTool18 = new ButtonTool("Move To Folder");
    ButtonTool buttonTool19 = new ButtonTool("Extract Tags");
    ButtonTool buttonTool20 = new ButtonTool("Download");
    ButtonTool buttonTool21 = new ButtonTool("Restore Template");
    ButtonTool buttonTool22 = new ButtonTool("Preview");
    ButtonTool buttonTool23 = new ButtonTool("Rename Folder");
    ButtonTool buttonTool24 = new ButtonTool("Move To Folder");
    ControlContainerTool controlContainerTool3 = new ControlContainerTool("FilterFolderContainer");
    ControlContainerTool controlContainerTool4 = new ControlContainerTool(" FilterTemplateContainer");
    ButtonTool buttonTool25 = new ButtonTool("Extract Tags");
    ButtonTool buttonTool26 = new ButtonTool("Download");
    ButtonTool buttonTool27 = new ButtonTool("Hide Folders");
    ButtonTool buttonTool28 = new ButtonTool("Show Deleted Templates");
    ButtonTool buttonTool29 = new ButtonTool("Restore Template");
    ButtonTool buttonTool30 = new ButtonTool("Preview");
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    this.cnSQL = new SqlConnection();
    this.diagOpen = new OpenFileDialog();
    this.ds = new dsDocumentTemplates();
    this.tree = new UltraTree();
    this.ImageList1 = new ImageList(this.components);
    this._frmDocumentTemplates_Toolbars_Dock_Area_Left = new UltraToolbarsDockArea();
    this.toolbar = new UltraToolbarsManager(this.components);
    this._frmDocumentTemplates_Toolbars_Dock_Area_Right = new UltraToolbarsDockArea();
    this._frmDocumentTemplates_Toolbars_Dock_Area_Top = new UltraToolbarsDockArea();
    this._frmDocumentTemplates_Toolbars_Dock_Area_Bottom = new UltraToolbarsDockArea();
    this.SqlDeleteCommand1 = new SqlCommand();
    this.SqlUpdateCommand1 = new SqlCommand();
    this.SqlInsertCommand1 = new SqlCommand();
    this.SqlSelectCommand1 = new SqlCommand();
    this.daTemplates = new SqlDataAdapter();
    this.txtFolderFilter = new MGATextBox();
    this.txtTemplateFilter = new MGATextBox();
    this.StatusStrip1 = new StatusStrip();
    this.StatusBarLabel = new ToolStripStatusLabel();
    this.lblLoadingTemplates = new Label();
    this.ds.BeginInit();
    ((ISupportInitialize) this.tree).BeginInit();
    ((ISupportInitialize) this.toolbar).BeginInit();
    ((ISupportInitialize) this.txtFolderFilter).BeginInit();
    ((ISupportInitialize) this.txtTemplateFilter).BeginInit();
    this.StatusStrip1.SuspendLayout();
    this.SuspendLayout();
    this.cnSQL.ConnectionString = "Data Source=MGASYSTEMS;Initial Catalog=IMS;Integrated Security=True";
    this.cnSQL.FireInfoMessageEventOnUserErrors = false;
    this.ds.DataSetName = "dsDocumentTemplates";
    this.ds.Locale = new CultureInfo("en-US");
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((Control) this.tree).AllowDrop = true;
    this.toolbar.SetContextMenuUltra((Component) this.tree, "PopupMenuTool1");
    ((Control) this.tree).Dock = DockStyle.Fill;
    this.tree.ImageList = this.ImageList1;
    this.tree.ImageTransparentColor = Color.Magenta;
    ((Control) this.tree).Location = new Point(0, 76);
    ((Control) this.tree).Name = "tree";
    this.tree.NodeConnectorColor = SystemColors.ControlDark;
    @override.SelectionType = (SelectType) 2;
    this.tree.Override = @override;
    ((Control) this.tree).Size = new Size(758, 354);
    ((Control) this.tree).TabIndex = 11;
    ((UltraControlBase) this.tree).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.tree).UseOsThemes = (DefaultableBoolean) 2;
    this.ImageList1.ImageStream = (ImageListStreamer) componentResourceManager.GetObject("ImageList1.ImageStream");
    this.ImageList1.TransparentColor = Color.Magenta;
    this.ImageList1.Images.SetKeyName(0, "Root");
    this.ImageList1.Images.SetKeyName(1, "Folder");
    this.ImageList1.Images.SetKeyName(2, "Word");
    this.ImageList1.Images.SetKeyName(3, "PDF");
    this.ImageList1.Images.SetKeyName(4, "Excel");
    ((Control) this._frmDocumentTemplates_Toolbars_Dock_Area_Left).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._frmDocumentTemplates_Toolbars_Dock_Area_Left).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._frmDocumentTemplates_Toolbars_Dock_Area_Left.DockedPosition = (DockedPosition) 2;
    ((Control) this._frmDocumentTemplates_Toolbars_Dock_Area_Left).ForeColor = Color.Black;
    ((Control) this._frmDocumentTemplates_Toolbars_Dock_Area_Left).Location = new Point(0, 76);
    ((Control) this._frmDocumentTemplates_Toolbars_Dock_Area_Left).Name = "_frmDocumentTemplates_Toolbars_Dock_Area_Left";
    ((Control) this._frmDocumentTemplates_Toolbars_Dock_Area_Left).Size = new Size(0, 354);
    this._frmDocumentTemplates_Toolbars_Dock_Area_Left.ToolbarsManager = this.toolbar;
    this.toolbar.DesignerFlags = 1;
    this.toolbar.DockWithinContainer = (Control) this;
    this.toolbar.DockWithinContainerBaseType = typeof (Form);
    this.toolbar.ImageTransparentColor = Color.Magenta;
    this.toolbar.MdiMergeable = false;
    this.toolbar.ShowFullMenusDelay = 500;
    this.toolbar.Style = (ToolbarStyle) 5;
    ultraToolbar1.DockedColumn = 0;
    ultraToolbar1.DockedRow = 0;
    ((UltraToolbarBase) ultraToolbar1).NonInheritedTools.AddRange(new ToolBase[5]
    {
      (ToolBase) buttonTool1,
      (ToolBase) buttonTool2,
      (ToolBase) buttonTool3,
      (ToolBase) buttonTool4,
      (ToolBase) buttonTool5
    });
    ultraToolbar1.Text = "toolbar";
    ultraToolbar2.DockedColumn = 0;
    ultraToolbar2.DockedRow = 2;
    ultraToolbar2.FloatingLocation = new Point(267, 330);
    ultraToolbar2.FloatingSize = new Size(267, 24);
    ultraToolbar2.ShowInToolbarList = false;
    ultraToolbar2.Text = "ContextMenu";
    ultraToolbar3.DockedColumn = 0;
    ultraToolbar3.DockedRow = 1;
    controlContainerTool1.ControlName = "txtFolderFilter";
    ((ToolPropsBase) ((ToolBase) controlContainerTool1).InstanceProps).Width = 169;
    controlContainerTool2.ControlName = "txtTemplateFilter";
    ((ToolPropsBase) ((ToolBase) controlContainerTool2).InstanceProps).Width = 168;
    ((UltraToolbarBase) ultraToolbar3).NonInheritedTools.AddRange(new ToolBase[4]
    {
      (ToolBase) controlContainerTool1,
      (ToolBase) controlContainerTool2,
      (ToolBase) buttonTool6,
      (ToolBase) buttonTool7
    });
    ultraToolbar3.Text = "FilterBar";
    this.toolbar.Toolbars.AddRange(new UltraToolbar[3]
    {
      ultraToolbar1,
      ultraToolbar2,
      ultraToolbar3
    });
    this.toolbar.ToolbarSettings.AllowCustomize = (DefaultableBoolean) 2;
    this.toolbar.ToolbarSettings.AllowFloating = (DefaultableBoolean) 2;
    this.toolbar.ToolbarSettings.AllowHiding = (DefaultableBoolean) 2;
    this.toolbar.ToolbarSettings.CaptionPlacement = (TextPlacement) 4;
    this.toolbar.ToolbarSettings.GrabHandleStyle = (GrabHandleStyle) 1;
    ((ToolbarSettingsBase) this.toolbar.ToolbarSettings).PaddingLeft = 3;
    ((ToolbarSettingsBase) this.toolbar.ToolbarSettings).PaddingRight = 3;
    ((SettingsBase) this.toolbar.ToolbarSettings).ToolDisplayStyle = (ToolDisplayStyle) 4;
    ((ToolbarSettingsBase) this.toolbar.ToolbarSettings).ToolSpacing = 15;
    ((ToolPropsBase) ((ToolBase) buttonTool8).SharedPropsInternal).Caption = "New Template";
    ((ToolPropsBase) ((ToolBase) buttonTool9).SharedPropsInternal).Caption = "Edit Template";
    ((ToolBase) buttonTool9).SharedPropsInternal.Enabled = false;
    ((ToolPropsBase) ((ToolBase) buttonTool10).SharedPropsInternal).Caption = "Replace Template";
    ((ToolBase) buttonTool10).SharedPropsInternal.Enabled = false;
    ((ToolPropsBase) ((ToolBase) buttonTool11).SharedPropsInternal).Caption = "Delete Template";
    ((ToolBase) buttonTool11).SharedPropsInternal.Enabled = false;
    ((ToolPropsBase) ((ToolBase) buttonTool12).SharedPropsInternal).Caption = "PDF Preview";
    ((ToolBase) buttonTool12).SharedPropsInternal.Enabled = false;
    ((ToolPropsBase) ((ToolBase) buttonTool13).SharedPropsInternal).Caption = "New Folder...";
    ((ToolPropsBase) ((ToolBase) buttonTool14).SharedPropsInternal).Caption = "Delete Folder";
    ((ToolPropsBase) ((ToolBase) popupMenuTool).SharedPropsInternal).Caption = "PopupMenuTool1";
    ((ToolsCollectionBase) popupMenuTool.Tools).AddRange(new ToolBase[8]
    {
      (ToolBase) buttonTool15,
      (ToolBase) buttonTool16,
      (ToolBase) buttonTool17,
      (ToolBase) buttonTool18,
      (ToolBase) buttonTool19,
      (ToolBase) buttonTool20,
      (ToolBase) buttonTool21,
      (ToolBase) buttonTool22
    });
    ((ToolPropsBase) ((ToolBase) buttonTool23).SharedPropsInternal).Caption = "Rename Folder...";
    ((ToolPropsBase) ((ToolBase) buttonTool24).SharedPropsInternal).Caption = "Move To Folder...";
    controlContainerTool3.ControlName = "txtFolderFilter";
    ((ToolBase) controlContainerTool3).SharedPropsInternal.Category = "FilterToobar";
    ((ToolPropsBase) ((ToolBase) controlContainerTool3).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 1;
    ((ToolPropsBase) ((ToolBase) controlContainerTool3).SharedPropsInternal).Width = 169;
    controlContainerTool4.ControlName = "txtTemplateFilter";
    ((ToolBase) controlContainerTool4).SharedPropsInternal.Category = "FilterToobar";
    ((ToolPropsBase) ((ToolBase) controlContainerTool4).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 1;
    ((ToolPropsBase) ((ToolBase) controlContainerTool4).SharedPropsInternal).Width = 168;
    ((ToolPropsBase) ((ToolBase) buttonTool25).SharedPropsInternal).Caption = "Extract Tags...";
    ((ToolPropsBase) ((ToolBase) buttonTool26).SharedPropsInternal).Caption = "Download";
    ((ToolPropsBase) ((ToolBase) buttonTool27).SharedPropsInternal).Caption = "Hide Folders";
    ((ToolBase) buttonTool27).SharedPropsInternal.Enabled = false;
    ((ToolPropsBase) ((ToolBase) buttonTool28).SharedPropsInternal).Caption = "Show Deleted Templates";
    ((ToolBase) buttonTool28).SharedPropsInternal.Enabled = false;
    ((ToolPropsBase) ((ToolBase) buttonTool29).SharedPropsInternal).Caption = "Restore Template";
    ((ToolPropsBase) ((ToolBase) buttonTool30).SharedPropsInternal).Caption = "Preview...";
    this.toolbar.Tools.AddRange(new ToolBase[18]
    {
      (ToolBase) buttonTool8,
      (ToolBase) buttonTool9,
      (ToolBase) buttonTool10,
      (ToolBase) buttonTool11,
      (ToolBase) buttonTool12,
      (ToolBase) buttonTool13,
      (ToolBase) buttonTool14,
      (ToolBase) popupMenuTool,
      (ToolBase) buttonTool23,
      (ToolBase) buttonTool24,
      (ToolBase) controlContainerTool3,
      (ToolBase) controlContainerTool4,
      (ToolBase) buttonTool25,
      (ToolBase) buttonTool26,
      (ToolBase) buttonTool27,
      (ToolBase) buttonTool28,
      (ToolBase) buttonTool29,
      (ToolBase) buttonTool30
    });
    ((UltraComponentControlManagerBase) this.toolbar).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraComponentControlManagerBase) this.toolbar).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this._frmDocumentTemplates_Toolbars_Dock_Area_Right).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._frmDocumentTemplates_Toolbars_Dock_Area_Right).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._frmDocumentTemplates_Toolbars_Dock_Area_Right.DockedPosition = (DockedPosition) 3;
    ((Control) this._frmDocumentTemplates_Toolbars_Dock_Area_Right).ForeColor = Color.Black;
    ((Control) this._frmDocumentTemplates_Toolbars_Dock_Area_Right).Location = new Point(758, 76);
    ((Control) this._frmDocumentTemplates_Toolbars_Dock_Area_Right).Name = "_frmDocumentTemplates_Toolbars_Dock_Area_Right";
    ((Control) this._frmDocumentTemplates_Toolbars_Dock_Area_Right).Size = new Size(0, 354);
    this._frmDocumentTemplates_Toolbars_Dock_Area_Right.ToolbarsManager = this.toolbar;
    ((Control) this._frmDocumentTemplates_Toolbars_Dock_Area_Top).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._frmDocumentTemplates_Toolbars_Dock_Area_Top).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._frmDocumentTemplates_Toolbars_Dock_Area_Top.DockedPosition = (DockedPosition) 0;
    ((Control) this._frmDocumentTemplates_Toolbars_Dock_Area_Top).ForeColor = Color.Black;
    ((Control) this._frmDocumentTemplates_Toolbars_Dock_Area_Top).Location = new Point(0, 0);
    ((Control) this._frmDocumentTemplates_Toolbars_Dock_Area_Top).Name = "_frmDocumentTemplates_Toolbars_Dock_Area_Top";
    ((Control) this._frmDocumentTemplates_Toolbars_Dock_Area_Top).Size = new Size(758, 76);
    this._frmDocumentTemplates_Toolbars_Dock_Area_Top.ToolbarsManager = this.toolbar;
    ((Control) this._frmDocumentTemplates_Toolbars_Dock_Area_Bottom).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._frmDocumentTemplates_Toolbars_Dock_Area_Bottom).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._frmDocumentTemplates_Toolbars_Dock_Area_Bottom.DockedPosition = (DockedPosition) 1;
    ((Control) this._frmDocumentTemplates_Toolbars_Dock_Area_Bottom).ForeColor = Color.Black;
    ((Control) this._frmDocumentTemplates_Toolbars_Dock_Area_Bottom).Location = new Point(0, 430);
    ((Control) this._frmDocumentTemplates_Toolbars_Dock_Area_Bottom).Name = "_frmDocumentTemplates_Toolbars_Dock_Area_Bottom";
    ((Control) this._frmDocumentTemplates_Toolbars_Dock_Area_Bottom).Size = new Size(758, 0);
    this._frmDocumentTemplates_Toolbars_Dock_Area_Bottom.ToolbarsManager = this.toolbar;
    this.SqlDeleteCommand1.CommandText = componentResourceManager.GetString("SqlDeleteCommand1.CommandText");
    this.SqlDeleteCommand1.Connection = this.cnSQL;
    this.SqlDeleteCommand1.Parameters.AddRange(new SqlParameter[19]
    {
      new SqlParameter("@Original_AutomationGroupID", SqlDbType.TinyInt, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "AutomationGroupID", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_TemplateName", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "TemplateName", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_Description", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "Description", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_TemplateID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "TemplateID", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_FolderID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FolderID", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_FolderID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "FolderID", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_TemplateType", SqlDbType.Char, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "TemplateType", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_IsPolicyForm", SqlDbType.Bit, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "IsPolicyForm", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_IsEditable", SqlDbType.Bit, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "IsEditable", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_SaveAsType", SqlDbType.Char, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "SaveAsType", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_FileOnly", SqlDbType.Bit, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "FileOnly", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_Removable", SqlDbType.Bit, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "Removable", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_HideWaterMark", SqlDbType.Bit, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "HideWaterMark", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_IsEmail", SqlDbType.Bit, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "IsEmail", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_FileOnlyName", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FileOnlyName", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_FileOnlyName", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "FileOnlyName", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_SeparateDocName", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SeparateDocName", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_SeparateDocName", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "SeparateDocName", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_SeparateDoc", SqlDbType.Bit, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "SeparateDoc", DataRowVersion.Original, (object) null)
    });
    this.SqlUpdateCommand1.CommandText = componentResourceManager.GetString("SqlUpdateCommand1.CommandText");
    this.SqlUpdateCommand1.Connection = this.cnSQL;
    this.SqlUpdateCommand1.Parameters.AddRange(new SqlParameter[40]
    {
      new SqlParameter("@AutomationGroupID", SqlDbType.TinyInt, 1, "AutomationGroupID"),
      new SqlParameter("@TemplateName", SqlDbType.VarChar, 70, "TemplateName"),
      new SqlParameter("@Description", SqlDbType.VarChar, 500, "Description"),
      new SqlParameter("@FolderID", SqlDbType.Int, 4, "FolderID"),
      new SqlParameter("@Template", SqlDbType.Image, int.MaxValue, "Template"),
      new SqlParameter("@TemplateType", SqlDbType.Char, 1, "TemplateType"),
      new SqlParameter("@IsPolicyForm", SqlDbType.Bit, 1, "IsPolicyForm"),
      new SqlParameter("@IsEditable", SqlDbType.Bit, 1, "IsEditable"),
      new SqlParameter("@SaveAsType", SqlDbType.Char, 1, "SaveAsType"),
      new SqlParameter("@FileOnly", SqlDbType.Bit, 1, "FileOnly"),
      new SqlParameter("@Removable", SqlDbType.Bit, 1, "Removable"),
      new SqlParameter("@HideWaterMark", SqlDbType.Bit, 1, "HideWaterMark"),
      new SqlParameter("@IsEmail", SqlDbType.Bit, 1, "IsEmail"),
      new SqlParameter("@FileOnlyName", SqlDbType.VarChar, 100, "FileOnlyName"),
      new SqlParameter("@SeparateDocName", SqlDbType.VarChar, 100, "SeparateDocName"),
      new SqlParameter("@SeparateDoc", SqlDbType.Bit, 1, "SeparateDoc"),
      new SqlParameter("@RequiresEdit", SqlDbType.Bit, 1, "RequiresEdit"),
      new SqlParameter("@CopyForwardOnRenewal", SqlDbType.Bit, 1, "CopyForwardOnRenewal"),
      new SqlParameter("@Original_AutomationGroupID", SqlDbType.TinyInt, 1, ParameterDirection.Input, false, (byte) 0, (byte) 0, "AutomationGroupID", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_TemplateName", SqlDbType.VarChar, 70, ParameterDirection.Input, false, (byte) 0, (byte) 0, "TemplateName", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_Description", SqlDbType.VarChar, 500, ParameterDirection.Input, false, (byte) 0, (byte) 0, "Description", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_TemplateID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "TemplateID", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_FolderID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FolderID", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_TemplateType", SqlDbType.Char, 1, ParameterDirection.Input, false, (byte) 0, (byte) 0, "TemplateType", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_IsPolicyForm", SqlDbType.Bit, 1, ParameterDirection.Input, false, (byte) 0, (byte) 0, "IsPolicyForm", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_IsEditable", SqlDbType.Bit, 1, ParameterDirection.Input, false, (byte) 0, (byte) 0, "IsEditable", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_SaveAsType", SqlDbType.Char, 1, ParameterDirection.Input, false, (byte) 0, (byte) 0, "SaveAsType", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_FileOnly", SqlDbType.Bit, 1, ParameterDirection.Input, false, (byte) 0, (byte) 0, "FileOnly", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_Removable", SqlDbType.Bit, 1, ParameterDirection.Input, false, (byte) 0, (byte) 0, "Removable", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_HideWaterMark", SqlDbType.Bit, 1, ParameterDirection.Input, false, (byte) 0, (byte) 0, "HideWaterMark", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_IsEmail", SqlDbType.Bit, 1, ParameterDirection.Input, false, (byte) 0, (byte) 0, "IsEmail", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_FileOnlyName", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FileOnlyName", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@IsNull_SeparateDocName", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SeparateDocName", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_SeparateDoc", SqlDbType.Bit, 1, ParameterDirection.Input, false, (byte) 0, (byte) 0, "SeparateDoc", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_FolderID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "FolderID", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_FileOnlyName", SqlDbType.VarChar, 100, ParameterDirection.Input, false, (byte) 0, (byte) 0, "FileOnlyName", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_SeparateDocName", SqlDbType.VarChar, 100, ParameterDirection.Input, false, (byte) 0, (byte) 0, "SeparateDocName", DataRowVersion.Original, (object) null),
      new SqlParameter("@TemplateID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "TemplateID", DataRowVersion.Original, (object) null),
      new SqlParameter("@OnDemand", SqlDbType.Bit, 1, "OnDemand"),
      new SqlParameter("@OriginalFileName", SqlDbType.VarChar, 8000, "OriginalFileName")
    });
    this.SqlInsertCommand1.CommandText = componentResourceManager.GetString("SqlInsertCommand1.CommandText");
    this.SqlInsertCommand1.Connection = this.cnSQL;
    this.SqlInsertCommand1.Parameters.AddRange(new SqlParameter[20]
    {
      new SqlParameter("@AutomationGroupID", SqlDbType.TinyInt, 1, "AutomationGroupID"),
      new SqlParameter("@TemplateName", SqlDbType.VarChar, 70, "TemplateName"),
      new SqlParameter("@Description", SqlDbType.VarChar, 500, "Description"),
      new SqlParameter("@FolderID", SqlDbType.Int, 4, "FolderID"),
      new SqlParameter("@Template", SqlDbType.Image, int.MaxValue, "Template"),
      new SqlParameter("@TemplateType", SqlDbType.Char, 1, "TemplateType"),
      new SqlParameter("@IsPolicyForm", SqlDbType.Bit, 1, "IsPolicyForm"),
      new SqlParameter("@IsEditable", SqlDbType.Bit, 1, "IsEditable"),
      new SqlParameter("@SaveAsType", SqlDbType.Char, 1, "SaveAsType"),
      new SqlParameter("@FileOnly", SqlDbType.Bit, 1, "FileOnly"),
      new SqlParameter("@Removable", SqlDbType.Bit, 1, "Removable"),
      new SqlParameter("@HideWaterMark", SqlDbType.Bit, 1, "HideWaterMark"),
      new SqlParameter("@IsEmail", SqlDbType.Bit, 1, "IsEmail"),
      new SqlParameter("@FileOnlyName", SqlDbType.VarChar, 100, "FileOnlyName"),
      new SqlParameter("@SeparateDocName", SqlDbType.VarChar, 100, "SeparateDocName"),
      new SqlParameter("@SeparateDoc", SqlDbType.Bit, 1, "SeparateDoc"),
      new SqlParameter("@RequiresEdit", SqlDbType.Bit, 1, "RequiresEdit"),
      new SqlParameter("@CopyForwardOnRenewal", SqlDbType.Bit, 1, "CopyForwardOnRenewal"),
      new SqlParameter("@OnDemand", SqlDbType.Bit, 1, "OnDemand"),
      new SqlParameter("@OriginalFileName", SqlDbType.VarChar, 8000, "OriginalFileName")
    });
    this.SqlSelectCommand1.CommandText = componentResourceManager.GetString("SqlSelectCommand1.CommandText");
    this.SqlSelectCommand1.Connection = this.cnSQL;
    this.SqlSelectCommand1.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@TemplateID", SqlDbType.Int, 4, "TemplateID")
    });
    this.daTemplates.DeleteCommand = this.SqlDeleteCommand1;
    this.daTemplates.InsertCommand = this.SqlInsertCommand1;
    this.daTemplates.SelectCommand = this.SqlSelectCommand1;
    this.daTemplates.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblDocumentTemplates", new DataColumnMapping[19]
      {
        new DataColumnMapping("AutomationGroupID", "AutomationGroupID"),
        new DataColumnMapping("TemplateName", "TemplateName"),
        new DataColumnMapping("Description", "Description"),
        new DataColumnMapping("TemplateID", "TemplateID"),
        new DataColumnMapping("FolderID", "FolderID"),
        new DataColumnMapping("Template", "Template"),
        new DataColumnMapping("TemplateType", "TemplateType"),
        new DataColumnMapping("IsPolicyForm", "IsPolicyForm"),
        new DataColumnMapping("IsEditable", "IsEditable"),
        new DataColumnMapping("SaveAsType", "SaveAsType"),
        new DataColumnMapping("FileOnly", "FileOnly"),
        new DataColumnMapping("Removable", "Removable"),
        new DataColumnMapping("HideWaterMark", "HideWaterMark"),
        new DataColumnMapping("IsEmail", "IsEmail"),
        new DataColumnMapping("FileOnlyName", "FileOnlyName"),
        new DataColumnMapping("SeparateDocName", "SeparateDocName"),
        new DataColumnMapping("SeparateDoc", "SeparateDoc"),
        new DataColumnMapping("RequiresEdit", "RequiresEdit"),
        new DataColumnMapping("CopyForwardOnRenewal", "CopyForwardOnRenewal")
      })
    });
    this.daTemplates.UpdateCommand = this.SqlUpdateCommand1;
    ((Control) this.txtFolderFilter).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.Gray;
    appearance1.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtFolderFilter).Appearance = (AppearanceBase) appearance1;
    ((TextEditorControlBase) this.txtFolderFilter).BackColor = Color.White;
    ((Control) this.txtFolderFilter).Location = new Point(569, 32 /*0x20*/);
    ((Control) this.txtFolderFilter).Name = "txtFolderFilter";
    ((TextEditorControlBase) this.txtFolderFilter).NullText = "Filter Folders";
    ((Control) this.txtFolderFilter).Size = new Size(169, 20);
    ((Control) this.txtFolderFilter).TabIndex = 21;
    ((UltraControlBase) this.txtFolderFilter).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtFolderFilter).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.txtTemplateFilter).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    appearance2.BackColor = Color.White;
    appearance2.BorderColor = Color.Gray;
    appearance2.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtTemplateFilter).Appearance = (AppearanceBase) appearance2;
    ((TextEditorControlBase) this.txtTemplateFilter).BackColor = Color.White;
    ((Control) this.txtTemplateFilter).Location = new Point(389, 32 /*0x20*/);
    ((Control) this.txtTemplateFilter).Name = "txtTemplateFilter";
    ((TextEditorControlBase) this.txtTemplateFilter).NullText = "Filter Templates";
    ((Control) this.txtTemplateFilter).Size = new Size(168, 20);
    ((Control) this.txtTemplateFilter).TabIndex = 26;
    ((UltraControlBase) this.txtTemplateFilter).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtTemplateFilter).UseOsThemes = (DefaultableBoolean) 2;
    this.StatusStrip1.BackColor = Color.Transparent;
    this.StatusStrip1.Items.AddRange(new ToolStripItem[1]
    {
      (ToolStripItem) this.StatusBarLabel
    });
    this.StatusStrip1.Location = new Point(0, 430);
    this.StatusStrip1.Name = "StatusStrip1";
    this.StatusStrip1.Size = new Size(758, 22);
    this.StatusStrip1.TabIndex = 31 /*0x1F*/;
    this.StatusStrip1.Text = "StatusBar";
    this.StatusBarLabel.Name = "StatusBarLabel";
    this.StatusBarLabel.Size = new Size(0, 17);
    this.lblLoadingTemplates.Location = new Point(0, 0);
    this.lblLoadingTemplates.Name = "lblLoadingTemplates";
    this.lblLoadingTemplates.Size = new Size(758, 452);
    this.lblLoadingTemplates.TabIndex = 33;
    this.lblLoadingTemplates.Text = "Loading templates...";
    this.lblLoadingTemplates.TextAlign = ContentAlignment.MiddleCenter;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.ClientSize = new Size(758, 452);
    this.Controls.Add((Control) this.lblLoadingTemplates);
    this.Controls.Add((Control) this.txtTemplateFilter);
    this.Controls.Add((Control) this.txtFolderFilter);
    this.Controls.Add((Control) this.tree);
    this.Controls.Add((Control) this._frmDocumentTemplates_Toolbars_Dock_Area_Left);
    this.Controls.Add((Control) this._frmDocumentTemplates_Toolbars_Dock_Area_Right);
    this.Controls.Add((Control) this._frmDocumentTemplates_Toolbars_Dock_Area_Bottom);
    this.Controls.Add((Control) this.StatusStrip1);
    this.Controls.Add((Control) this._frmDocumentTemplates_Toolbars_Dock_Area_Top);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ForeColor = Color.Black;
    this.MinimumSize = new Size(758, 452);
    this.Name = nameof (frmDocumentTemplates);
    this.Text = "Document Template Management";
    this.ds.EndInit();
    ((ISupportInitialize) this.tree).EndInit();
    ((ISupportInitialize) this.toolbar).EndInit();
    ((ISupportInitialize) this.txtFolderFilter).EndInit();
    ((ISupportInitialize) this.txtTemplateFilter).EndInit();
    this.StatusStrip1.ResumeLayout(false);
    this.StatusStrip1.PerformLayout();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  public frmDocumentTemplates()
  {
    this.Load += new EventHandler(this.frmDocumentTemplates_Load);
    this.Closed += new EventHandler(this.frmDocumentTemplates_Closed);
    this._selectedTemplateID = -1;
    this._limitToGroupID = -1;
    this._lastMouseDownPoint = Point.Empty;
    this._onDemandTemplates = false;
    this._editingWordPolling = false;
    this._hideOnDoubleClick = false;
    this._selectedFolderName = "";
    this.tempselected = new List<UltraTreeNode>();
    this.InitializeComponent();
    this.ScreenMode = frmDocumentTemplates.ScreenModes.AdminTemplates;
    this.Cursor = MgaCursors.Default;
  }

  public frmDocumentTemplates(ISupportTemplateDocs supportingObject)
    : this()
  {
    this._groupIDs = supportingObject.SupportedTemplateGroupIDs;
    this._supportingObject = supportingObject;
    this.ScreenMode = frmDocumentTemplates.ScreenModes.LaunchTemplate;
  }

  public frmDocumentTemplates(ISupportTemplateDocs supportingObject, bool onlyOnDemandDocs)
    : this()
  {
    this._groupIDs = supportingObject.SupportedTemplateGroupIDs;
    this._supportingObject = supportingObject;
    this._onDemandTemplates = onlyOnDemandDocs;
    this.ScreenMode = frmDocumentTemplates.ScreenModes.LaunchTemplate;
  }

  public bool ShowFoldersOnly
  {
    get => this._showFoldersOnly;
    set
    {
      this._showFoldersOnly = value;
      if (!value)
        return;
      this.ScreenMode = frmDocumentTemplates.ScreenModes.SelectFolder;
      this.toolbar.Toolbars[0].Visible = false;
      this.StatusBarLabel.Text = "Please select the folder you would like to move this document to.  Double-click to select.";
    }
  }

  public bool FolderSelected => this._folderSelected;

  public int SelectedFolderID
  {
    get => Conversions.ToInteger(((SubObjectBase) this.tree.SelectedNodes[0]).Tag);
  }

  public int SelectedTemplateID => this._selectedTemplateID;

  public bool TemplateSelected => this._selectedTemplateID != -1;

  public string SelectedFolderName => this._selectedFolderName;

  private Dictionary<string, int> WatchedFiles => this._watchedFiles;

  public bool HideOnDoubleClickTemplate
  {
    get => this._hideOnDoubleClick;
    set => this._hideOnDoubleClick = value;
  }

  public bool CloseOnDoubleClickTemplate
  {
    get => this.ScreenMode == frmDocumentTemplates.ScreenModes.SelectTemplate;
    set
    {
      if (!value)
        return;
      this.ScreenMode = frmDocumentTemplates.ScreenModes.SelectTemplate;
    }
  }

  private frmDocumentTemplates.ScreenModes ScreenMode
  {
    get => this._screenMode;
    set
    {
      this._screenMode = value;
      if (value != frmDocumentTemplates.ScreenModes.LaunchTemplate && value != frmDocumentTemplates.ScreenModes.SelectTemplate)
        return;
      this.toolbar.Toolbars[0].Visible = false;
    }
  }

  private void frmDocumentTemplates_Load(object sender, EventArgs e)
  {
    this.cnSQL.ConnectionString = MGASystems.IMS.DocumentAutomation.Common.ConnectionString;
    Cursor.Current = MgaCursors.WaitCursor;
    ThreadPool.QueueUserWorkItem(new WaitCallback(this.AddTemplateGroups));
    this._fileWatcher = new MGASystems.Common.FileSystemObserver.FileSystemObserver(Path.Combine(MGATempFolder.MGATempPath, "Watched Files"), true);
    this._fileWatcher.ChangedEvent += new FileSystemEvent(this.FileModified);
    if (this.WatchedFiles == null)
      this._watchedFiles = new Dictionary<string, int>();
    this._fileWatcher.Start();
    this.StatusBarLabel.Text = "Right-click the template tree to add, modify, or delete template folders.";
  }

  public void LimitToOneGroup(int automationGroupID) => this._limitToGroupID = automationGroupID;

  private void AddTemplates(bool withFolders)
  {
    try
    {
      foreach (dsDocumentTemplates.tblDocumentTemplatesListRow documentTemplates in (TypedTableBase<dsDocumentTemplates.tblDocumentTemplatesListRow>) this.ds.tblDocumentTemplatesList)
      {
        if (!this.Disposing && !this.IsDisposed && this.IsHandleCreated)
        {
          string key = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(documentTemplates.TemplateType, "W", false) != 0 ? (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(documentTemplates.TemplateType, "P", false) != 0 ? "Excel" : "PDF") : "Word";
          UltraTreeNode node = new UltraTreeNode();
          UltraTreeNode ultraTreeNode = node;
          ultraTreeNode.Override.ActiveNodeAppearance.Image = (object) this.ImageList1.Images[key];
          ultraTreeNode.Override.NodeAppearance.Image = (object) this.ImageList1.Images[key];
          ultraTreeNode.Text = documentTemplates.TemplateName + Interaction.IIf(Microsoft.VisualBasic.CompilerServices.Operators.CompareString(documentTemplates.Description, string.Empty, false) == 0, (object) string.Empty, (object) (" - " + documentTemplates.Description)).ToString();
          ultraTreeNode.Key = documentTemplates.TemplateID.ToString();
          ((SubObjectBase) ultraTreeNode).Tag = (object) documentTemplates.TemplateType;
          bool result;
          bool.TryParse(documentTemplates["Hidden"].ToString(), out result);
          if (result)
          {
            ultraTreeNode.Override.NodeAppearance.FontData.Italic = (DefaultableBoolean) 1;
            ultraTreeNode.Override.NodeAppearance.ForeColor = Color.DarkGray;
          }
          else
            ultraTreeNode.Override.NodeAppearance.FontData.Italic = (DefaultableBoolean) 2;
          if (documentTemplates.IsTemplateGroupIDNull() || !withFolders)
            this.AddTreeNode(node, "automationGroup" + documentTemplates.AutomationGroupID.ToString(), withFolders);
          else
            this.AddTreeNode(node, "templateGroup" + documentTemplates.TemplateGroupID.ToString(), withFolders);
        }
      }
    }
    finally
    {
      IEnumerator<dsDocumentTemplates.tblDocumentTemplatesListRow> enumerator;
      enumerator?.Dispose();
    }
    if (this.Disposing || this.IsDisposed || !this.IsHandleCreated)
      return;
    MDIControls.Instance.MDIParent.Invoke((Delegate) new MethodInvoker(this.LoadComplete));
  }

  private void AddTemplatesNew(bool withFolders)
  {
    DataRow[] dataRowArray = this.ds.lstTemplateDocumentGroups.Select("ParentTemplateGroupID IS NULL", "TemplateGroup");
    int index = 0;
    while (index < dataRowArray.Length)
    {
      dsDocumentTemplates.lstTemplateDocumentGroupsRow dr = (dsDocumentTemplates.lstTemplateDocumentGroupsRow) dataRowArray[index];
      UltraTreeNode ultraTreeNode1 = new UltraTreeNode();
      if (this.Visible)
      {
        UltraTreeNode ultraTreeNode2 = ultraTreeNode1;
        ultraTreeNode1.LeftImages.Add((object) this.ImageList1.Images[1]);
        ultraTreeNode2.Text = dr.TemplateGroup;
        int num1 = dr.GroupID;
        ultraTreeNode2.Key = "templateGroup" + num1.ToString();
        ((SubObjectBase) ultraTreeNode2).Tag = (object) dr.GroupID;
        if (this._limitToGroupID == -1 || this._limitToGroupID == dr.AutomationGroupID || !withFolders)
        {
          UltraTreeNode node = ultraTreeNode1;
          num1 = dr.AutomationGroupID;
          string parentNodeKey = "automationGroup" + num1.ToString();
          int num2 = withFolders ? 1 : 0;
          this.AddTreeNode(node, parentNodeKey, num2 != 0);
        }
      }
      this.AddChildObject(dr, withFolders);
      checked { ++index; }
    }
    if (this.ShowFoldersOnly)
      return;
    this.AddTemplates(withFolders);
  }

  private void LoadComplete() => Cursor.Current = MgaCursors.Default;

  private void AddTemplateGroups(object state)
  {
    try
    {
      MDIControls.Instance.MDIParent.Invoke((Delegate) new frmDocumentTemplates.LoadingLabelVisibilityHandler(this.LoadingLabelVisibility), (object) true);
      bool withFoldersObj = true;
      bool flag = false;
      if (state != null)
      {
        frmDocumentTemplates.TemplateDisplay templateDisplay = (frmDocumentTemplates.TemplateDisplay) state;
        withFoldersObj = templateDisplay.showFolders;
        flag = templateDisplay.showHiddenItems;
      }
      ((ToolsCollectionBase) ((UltraToolbarBase) this.toolbar.Toolbars[2]).Tools)["Show Deleted Templates"].SharedProps.Enabled = false;
      ((ToolsCollectionBase) ((UltraToolbarBase) this.toolbar.Toolbars[2]).Tools)["Hide Folders"].SharedProps.Enabled = false;
      using (SqlConnection selectConnection = new SqlConnection(CurrentUser.Instance.ConnectionString))
      {
        using (SqlDataAdapter dataAdapter = new SqlDataAdapter("dbo.LoadTemplateData", selectConnection))
        {
          dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
          dataAdapter.SelectCommand.Parameters.AddWithValue("@showPolicyForms", (object) (this.ScreenMode != frmDocumentTemplates.ScreenModes.LaunchTemplate));
          dataAdapter.SelectCommand.Parameters.AddWithValue("@ShowHidden", (object) flag);
          dataAdapter.SelectCommand.Parameters.AddWithValue("@OnDemandTemplates", (object) this._onDemandTemplates);
          dataAdapter.SelectCommand.Parameters.AddWithValue("@UserGuid", (object) CurrentUser.Instance.UserGUID);
          DataTableMappingCollection tableMappings = dataAdapter.TableMappings;
          tableMappings.Clear();
          tableMappings.Add("Table", this.ds.lstDocumentAutomationGroups.TableName);
          tableMappings.Add("Table1", this.ds.tblDocumentTemplatesList.TableName);
          tableMappings.Add("Table2", this.ds.lstTemplateDocumentGroups.TableName);
          this.ds.tblDocumentTemplatesList.Clear();
          Database.SafeDataAdapterFill(dataAdapter, (DataSet) this.ds);
        }
      }
      if (this._groupIDs == null)
      {
        this._groupIDs = new List<int>();
        try
        {
          foreach (dsDocumentTemplates.lstDocumentAutomationGroupsRow documentAutomationGroup in (TypedTableBase<dsDocumentTemplates.lstDocumentAutomationGroupsRow>) this.ds.lstDocumentAutomationGroups)
            this._groupIDs.Add(documentAutomationGroup.ID);
        }
        finally
        {
          IEnumerator<dsDocumentTemplates.lstDocumentAutomationGroupsRow> enumerator;
          enumerator?.Dispose();
        }
      }
      MDIControls.Instance.MDIParent.Invoke((Delegate) new frmDocumentTemplates.BeginTreeUpdateHandler(this.BeginTreeUpdate), new object());
      this.AddNodes((object) withFoldersObj);
      MDIControls.Instance.MDIParent.Invoke((Delegate) new frmDocumentTemplates.EndTreeUpdateHandler(this.EndTreeUpdate), new object());
      ((ToolsCollectionBase) ((UltraToolbarBase) this.toolbar.Toolbars[2]).Tools)["Show Deleted Templates"].SharedProps.Enabled = true;
      ((ToolsCollectionBase) ((UltraToolbarBase) this.toolbar.Toolbars[2]).Tools)["Hide Folders"].SharedProps.Enabled = true;
      ((ToolsCollectionBase) ((UltraToolbarBase) this.toolbar.Toolbars[0]).Tools)["New Template"].SharedProps.Enabled = MGASystems.IMS.DocumentAutomation.Security.CanCreateNewTemplate();
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ErrorHandler.HandleErrorOnThread((Control) MDIControls.Instance.MDIParent, ex);
      ProjectData.ClearProjectError();
    }
  }

  private void BeginTreeUpdate(object obj) => ((UltraControlBase) this.tree).BeginUpdate();

  private void EndTreeUpdate(object obj)
  {
    ((UltraControlBase) this.tree).EndUpdate();
    this.lblLoadingTemplates.Visible = false;
  }

  private void LoadingLabelVisibility(bool isvisible)
  {
    this.lblLoadingTemplates.Visible = isvisible;
  }

  private void AddNodes(object withFoldersObj)
  {
    bool boolean = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(withFoldersObj));
    try
    {
      foreach (int groupId in this._groupIDs)
      {
        if (this._limitToGroupID == -1 || this._limitToGroupID == groupId)
        {
          TemplateCaptions templateCaptions = (TemplateCaptions) ObjectFactory.Instance.CreateObject(typeof (TemplateCaptions));
          UltraTreeNode node = new UltraTreeNode();
          UltraTreeNode ultraTreeNode = node;
          if (this.Visible)
          {
            ultraTreeNode.LeftImages.Add((object) this.ImageList1.Images[0]);
            ultraTreeNode.Text = this.ScreenMode != frmDocumentTemplates.ScreenModes.LaunchTemplate || this._onDemandTemplates ? this.ds.lstDocumentAutomationGroups.FindByID(groupId).TemplateGroup : templateCaptions.GetMenuCaption(this._supportingObject, groupId);
            ultraTreeNode.Key = "automationGroup" + groupId.ToString();
            ((SubObjectBase) ultraTreeNode).Tag = (object) groupId;
            if (this.ScreenMode != frmDocumentTemplates.ScreenModes.AdminTemplates)
              ultraTreeNode.Visible = false;
          }
          this.AddTreeNode(node, boolean);
        }
      }
    }
    finally
    {
      List<int>.Enumerator enumerator;
      enumerator.Dispose();
    }
    this.AddTemplatesNew(boolean);
  }

  private void AddTreeNode(UltraTreeNode node, string parentNodeKey, bool withFolders)
  {
    if (MDIControls.Instance.MDIParent.InvokeRequired)
    {
      MDIControls.Instance.MDIParent.Invoke((Delegate) new frmDocumentTemplates.AddChildTreeNodeHandler(this.AddTreeNode), (object) node, (object) parentNodeKey, (object) withFolders);
    }
    else
    {
      if (!this.Visible)
        return;
      if (string.IsNullOrEmpty(parentNodeKey))
      {
        this.tree.Nodes.Add(node);
      }
      else
      {
        if (this.tree.GetNodeByKey(parentNodeKey) == null)
          return;
        bool flag = true;
        if (node.Key.StartsWith("templateGroup") && !withFolders)
          flag = false;
        if (flag && this.tree.GetNodeByKey(node.Key) == null)
          this.tree.GetNodeByKey(parentNodeKey).Nodes.Add(node);
      }
      node.RootNode.Visible = true;
      if (node.Level != 0)
        return;
      node.Expanded = true;
    }
  }

  private void AddTreeNode(UltraTreeNode node, bool withFolders)
  {
    this.AddTreeNode(node, string.Empty, withFolders);
  }

  private void AddChildFolders(
    dsDocumentTemplates.lstTemplateDocumentGroupsRow dr)
  {
    DataRow[] dataRowArray = this.ds.lstTemplateDocumentGroups.Select("ParentTemplateGroupID=" + dr.GroupID.ToString());
    int index = 0;
    while (index < dataRowArray.Length)
    {
      dsDocumentTemplates.lstTemplateDocumentGroupsRow dr1 = (dsDocumentTemplates.lstTemplateDocumentGroupsRow) dataRowArray[index];
      UltraTreeNode ultraTreeNode1 = new UltraTreeNode();
      int groupId;
      if (this.Visible)
      {
        UltraTreeNode ultraTreeNode2 = ultraTreeNode1;
        ultraTreeNode2.LeftImages.Add((object) this.ImageList1.Images[1]);
        ultraTreeNode2.Text = dr1.TemplateGroup;
        groupId = dr1.GroupID;
        ultraTreeNode2.Key = "templateGroup" + groupId.ToString();
        ((SubObjectBase) ultraTreeNode2).Tag = (object) dr1.GroupID;
      }
      UltraTreeNode node = ultraTreeNode1;
      groupId = dr.GroupID;
      string parentNodeKey = "templateGroup" + groupId.ToString();
      this.AddTreeNode(node, parentNodeKey, true);
      this.AddChildFolders(dr1);
      checked { ++index; }
    }
  }

  private void AddChildObject(
    dsDocumentTemplates.lstTemplateDocumentGroupsRow dr,
    bool withFolders)
  {
    DataRow[] dataRowArray = this.ds.lstTemplateDocumentGroups.Select("ParentTemplateGroupID=" + dr.GroupID.ToString());
    int index = 0;
    while (index < dataRowArray.Length)
    {
      dsDocumentTemplates.lstTemplateDocumentGroupsRow dr1 = (dsDocumentTemplates.lstTemplateDocumentGroupsRow) dataRowArray[index];
      UltraTreeNode ultraTreeNode1 = new UltraTreeNode();
      int num1;
      if (this.Visible)
      {
        UltraTreeNode ultraTreeNode2 = ultraTreeNode1;
        ultraTreeNode2.LeftImages.Add((object) this.ImageList1.Images[1]);
        ultraTreeNode2.Text = dr1.TemplateGroup;
        num1 = dr1.GroupID;
        ultraTreeNode2.Key = "templateGroup" + num1.ToString();
        ((SubObjectBase) ultraTreeNode2).Tag = (object) dr1.GroupID;
      }
      if (withFolders)
      {
        UltraTreeNode node = ultraTreeNode1;
        num1 = dr.GroupID;
        string parentNodeKey = "templateGroup" + num1.ToString();
        int num2 = withFolders ? 1 : 0;
        this.AddTreeNode(node, parentNodeKey, num2 != 0);
      }
      else
      {
        UltraTreeNode node = ultraTreeNode1;
        num1 = dr1.AutomationGroupID;
        string parentNodeKey = "automationGroup" + num1.ToString();
        int num3 = withFolders ? 1 : 0;
        this.AddTreeNode(node, parentNodeKey, num3 != 0);
      }
      this.AddChildObject(dr1, withFolders);
      checked { ++index; }
    }
  }

  private void tree_AfterSelect(object sender, SelectEventArgs e)
  {
    if (((DisposableObjectCollectionBase) this.tree.SelectedNodes).Count == 0)
      return;
    bool flag = Versioned.IsNumeric((object) this.tree.SelectedNodes[0].Key);
    bool result = false;
    if (flag)
    {
      IEnumerable<dsDocumentTemplates.tblDocumentTemplatesListRow> source = (IEnumerable<dsDocumentTemplates.tblDocumentTemplatesListRow>) this.ds.tblDocumentTemplatesList.Where<dsDocumentTemplates.tblDocumentTemplatesListRow>((System.Func<dsDocumentTemplates.tblDocumentTemplatesListRow, bool>) ([SpecialName] (x) => x.TemplateID == Conversions.ToInteger(this.tree.SelectedNodes[0].Key)));
      if (source.FirstOrDefault<dsDocumentTemplates.tblDocumentTemplatesListRow>() != null)
        bool.TryParse(source.FirstOrDefault<dsDocumentTemplates.tblDocumentTemplatesListRow>()["Hidden"].ToString(), out result);
    }
    UltraToolbar toolbar = this.toolbar.Toolbars[0];
    if (!this._editingWordPolling)
      ((ToolsCollectionBase) ((UltraToolbarBase) toolbar).Tools)["Edit Template"].SharedProps.Enabled = flag && MGASystems.IMS.DocumentAutomation.Security.CanEditTemplate();
    else
      ((ToolsCollectionBase) ((UltraToolbarBase) toolbar).Tools)["Edit Template"].SharedProps.Enabled = false;
    ((ToolsCollectionBase) ((UltraToolbarBase) toolbar).Tools)["Replace Template"].SharedProps.Enabled = flag && MGASystems.IMS.DocumentAutomation.Security.CanReplaceTemplate();
    ((ToolsCollectionBase) ((UltraToolbarBase) toolbar).Tools)["PDF Preview"].SharedProps.Enabled = flag;
    if (result)
      ((ToolsCollectionBase) ((UltraToolbarBase) toolbar).Tools)["Delete Template"].SharedProps.Enabled = false;
    else
      ((ToolsCollectionBase) ((UltraToolbarBase) toolbar).Tools)["Delete Template"].SharedProps.Enabled = flag && MGASystems.IMS.DocumentAutomation.Security.CanDeleteTempalte();
  }

  private void toolbar_BeforeToolDropdown(object sender, BeforeToolDropdownEventArgs e)
  {
    if (((DisposableObjectCollectionBase) this.tree.SelectedNodes).Count == 0)
      ((CancelEventArgs) e).Cancel = true;
    else if (!SecurityManager.Instance.AssertPermission("{1AD2E14B-35ED-4093-A4A9-459BF2CB2CEA}"))
    {
      ((CancelEventArgs) e).Cancel = true;
    }
    else
    {
      ((ToolsCollectionBase) this.toolbar.Tools)["Delete Folder"].SharedProps.Enabled = frmDocumentTemplates.NodeIsFolder(this.tree.SelectedNodes[0]) && !this.tree.SelectedNodes[0].HasNodes;
      ((ToolsCollectionBase) this.toolbar.Tools)["Rename Folder"].SharedProps.Enabled = frmDocumentTemplates.NodeIsFolder(this.tree.SelectedNodes[0]);
      ((ToolsCollectionBase) this.toolbar.Tools)["Download"].SharedProps.Enabled = !frmDocumentTemplates.NodeIsFolder(this.tree.SelectedNodes[0]) && !this.tree.SelectedNodes[0].IsRootLevelNode;
      bool result = false;
      if (!frmDocumentTemplates.NodeIsFolder(this.tree.SelectedNodes[0]))
      {
        IEnumerable<dsDocumentTemplates.tblDocumentTemplatesListRow> source = (IEnumerable<dsDocumentTemplates.tblDocumentTemplatesListRow>) this.ds.tblDocumentTemplatesList.Where<dsDocumentTemplates.tblDocumentTemplatesListRow>((System.Func<dsDocumentTemplates.tblDocumentTemplatesListRow, bool>) ([SpecialName] (x) => x.TemplateID == Conversions.ToInteger(this.tree.SelectedNodes[0].Key)));
        if (source.FirstOrDefault<dsDocumentTemplates.tblDocumentTemplatesListRow>() != null)
          bool.TryParse(source.FirstOrDefault<dsDocumentTemplates.tblDocumentTemplatesListRow>()["Hidden"].ToString(), out result);
      }
      ((ToolsCollectionBase) this.toolbar.Tools)["Restore Template"].SharedProps.Enabled = result;
      ((ToolsCollectionBase) this.toolbar.Tools)["New Folder"].SharedProps.Enabled = ((DisposableObjectCollectionBase) this.tree.SelectedNodes).Count <= 1;
      ((ToolsCollectionBase) this.toolbar.Tools)["Extract Tags"].SharedProps.Enabled = ((DisposableObjectCollectionBase) this.tree.SelectedNodes).Count <= 1;
      ((ToolsCollectionBase) this.toolbar.Tools)["Preview"].SharedProps.Enabled = ((DisposableObjectCollectionBase) this.tree.SelectedNodes).Count <= 1;
      if (this.FoldersHidden())
        ((ToolsCollectionBase) this.toolbar.Tools)["Move To Folder"].SharedProps.Enabled = false;
      else
        ((ToolsCollectionBase) this.toolbar.Tools)["Move To Folder"].SharedProps.Enabled = ((DisposableObjectCollectionBase) this.tree.SelectedNodes).Count <= 1;
    }
  }

  private void tree_MouseDown(object sender, MouseEventArgs e)
  {
    if (e.Button != MouseButtons.Right)
    {
      this._lastMouseDownPoint = new Point(e.X, e.Y);
      this.tempselected.Clear();
      foreach (UltraTreeNode selectedNode in this.tree.SelectedNodes)
        this.tempselected.Add(selectedNode);
    }
    else
    {
      UIElement lastElementEntered = ((ControlUIElementBase) this.tree.UIElement).LastElementEntered;
    }
  }

  private string SaveByteArrayToFile(byte[] fileBytes, string originalFileName)
  {
    string tempFileName = Path.GetTempFileName();
    string path1 = originalFileName;
    char[] invalidFileNameChars = Path.GetInvalidFileNameChars();
    int index = 0;
    while (index < invalidFileNameChars.Length)
    {
      char ch = invalidFileNameChars[index];
      path1 = path1.Replace(Conversions.ToString(ch), string.Empty);
      checked { ++index; }
    }
    string path2 = Path.ChangeExtension(tempFileName, Path.GetExtension(path1));
    if (Path.GetExtension(path1).StartsWith(".x"))
    {
      string tempPath = Path.GetTempPath();
      path2 = path2.Replace(tempPath, $"{Path.Combine(MGATempFolder.MGATempPath, "Watched Files")}\\");
    }
    using (FileStream fileStream = new FileStream(path2, FileMode.Create))
    {
      fileStream.Write(fileBytes, 0, fileBytes.Length);
      fileStream.Close();
    }
    return path2;
  }

  private static void LogAsposePDFAction(string message)
  {
    PDF.LogAsposePDFAction("MGA.DocumentAutomation.frmDocumentTemplates.ShowPDFPreviewThread", message);
  }

  private void DocumentSaved(
    dsDocumentTemplates.tblDocumentTemplatesDataTable dt,
    string fileName)
  {
    bool flag = true;
    if (!WordTemplate.UseWordWithEvents() && System.Windows.Forms.MessageBox.Show($"Save changes to template '{dt[0].TemplateName}'?", "Save changes?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
      flag = false;
    if (!flag)
      return;
    byte[] numArray = FileReader.ReadAllBytes(fileName);
    dt[0].Template = numArray;
    Database.SafeDataAdapterUpdate(this.daTemplates, (DataTable) dt);
    CurrentUser.Instance.LogAction($"Template \"{dt[0].TemplateName}\" has been updated", new Guid("{7CFE4C1A-F2B3-45bf-8B91-D2899A714B7E}"), "Template ID: " + Conversions.ToString(dt[0].TemplateID));
  }

  private void DocumentClosed(
    dsDocumentTemplates.tblDocumentTemplatesDataTable dt,
    string fileName)
  {
    if (!WordTemplate.UseWordWithEvents())
      ((ToolsCollectionBase) ((UltraToolbarBase) this.toolbar.Toolbars[0]).Tools)["Edit Template"].SharedProps.Enabled = this.Enabled && MGASystems.IMS.DocumentAutomation.Security.CanEditTemplate();
    this._editingWordPolling = false;
  }

  private void ShowPDFPreview()
  {
    if (Versioned.IsNumeric((object) this.tree.SelectedNodes[0].Key))
    {
      this.daTemplates.SelectCommand.Parameters["@TemplateID"].Value = (object) Conversions.ToInteger(this.tree.SelectedNodes[0].Key);
      ThreadPool.QueueUserWorkItem(new WaitCallback(this.ShowPDFPreviewThread));
    }
    else
    {
      int num = (int) System.Windows.Forms.MessageBox.Show("Please select a document from the list to preview.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
  }

  private void ChangeCursor()
  {
    if (MDIControls.Instance.MDIParent.InvokeRequired)
      MDIControls.Instance.MDIParent.Invoke((Delegate) new MethodInvoker(this.ChangeCursor));
    else if ((object) this.Cursor == (object) MgaCursors.Default)
      this.Cursor = MgaCursors.WaitCursor;
    else
      this.Cursor = MgaCursors.Default;
  }

  private void ShowPDFPreviewThread(object state)
  {
    this.ChangeCursor();
    dsDocumentTemplates.tblDocumentTemplatesDataTable table = new dsDocumentTemplates.tblDocumentTemplatesDataTable();
    using (SqlConnection sqlConnection = new SqlConnection(CurrentUser.Instance.ConnectionString))
    {
      this.daTemplates.SelectCommand.Connection = sqlConnection;
      Database.SafeDataAdapterFill(this.daTemplates, (DataTable) table);
      this.daTemplates.SelectCommand.Connection = this.cnSQL;
    }
    if (table.Rows.Count == 0)
    {
      int num = (int) System.Windows.Forms.MessageBox.Show("The document template could not be located in the database", "Template Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      this.ChangeCursor();
    }
    else
    {
      string file = this.SaveByteArrayToFile(table[0].Template, table[0].OriginalFileName);
      string str = $"{MGATempFolder.MGATempPath}{Guid.NewGuid().ToString()}.pdf";
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(table[0].TemplateType, "W", false) == 0)
      {
        if (this.IsValidWordDocument(file))
          Compatibility.SaveToPDF(new Document(file), str);
      }
      else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(table[0].TemplateType, "P", false) == 0)
        File.Move(file, str);
      else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(table[0].TemplateType, "E", false) == 0)
      {
        str = Path.ChangeExtension(str, Path.GetExtension(table[0].OriginalFileName));
        File.Move(file, str);
        Process.Start(str);
      }
      if (this.IsHandleCreated && !this.IsDisposed && !this.Disposing)
        MDIControls.Instance.MDIParent.Invoke((Delegate) new frmDocumentTemplates.ShowPDFPreviewThreadCompleteHandler(this.ShowPDFPreviewThreadComplete), (object) str);
      this.ChangeCursor();
    }
  }

  private void ShowPDFPreviewThreadComplete(string outputPDFFileName)
  {
    try
    {
      Process.Start(outputPDFFileName);
    }
    catch (Win32Exception ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      int num = (int) System.Windows.Forms.MessageBox.Show("Unable to display the PDF document.\n\nPlease ensure that an application capable of viewing PDF documents is installed.", "Unable to View PDF", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      ProjectData.ClearProjectError();
    }
    finally
    {
      Cursor.Current = MgaCursors.Default;
    }
  }

  private void DeleteFolder()
  {
    if (((DisposableObjectCollectionBase) this.tree.SelectedNodes).Count == 0 || !frmDocumentTemplates.NodeIsFolder(this.tree.SelectedNodes[0]) || System.Windows.Forms.MessageBox.Show("Are you sure you want to delete this folder?", "Delete Folder?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
      return;
    Database.Instance.QueryText.PerformNonQuery("DELETE FROM lstTemplateDocumentGroups WHERE GroupID=@GroupID", (object) "@GroupID", ((SubObjectBase) this.tree.SelectedNodes[0]).Tag);
    CurrentUser.Instance.LogAction($"Folder \"{this.tree.SelectedNodes[0].Text}\" has been removed.", new Guid("{7CFE4C1A-F2B3-45bf-8B91-D2899A714B7E}"), "Folder ID: " + ((SubObjectBase) this.tree.SelectedNodes[0]).Tag.ToString());
    this.tree.SelectedNodes[0].Remove();
  }

  public event frmDocumentTemplates.DocTemplateSelectedEventHandler DocTemplateSelected;

  public event frmDocumentTemplates.DocTemplateClosedEventHandler DocTemplateClosed;

  private void tree_DoubleClick(object sender, EventArgs e)
  {
    if (!(((ControlUIElementBase) this.tree.UIElement).LastElementEntered.GetContext(typeof (UltraTreeNode)) is UltraTreeNode) || ((DisposableObjectCollectionBase) this.tree.SelectedNodes).Count <= 0)
      return;
    if (Versioned.IsNumeric((object) this.tree.SelectedNodes[0].Key))
    {
      if (this.ScreenMode == frmDocumentTemplates.ScreenModes.SelectTemplate)
      {
        this._selectedTemplateID = Conversions.ToInteger(this.tree.SelectedNodes[0].Key);
        if (this.HideOnDoubleClickTemplate)
        {
          // ISSUE: reference to a compiler-generated field
          frmDocumentTemplates.DocTemplateSelectedEventHandler templateSelectedEvent = this.DocTemplateSelectedEvent;
          if (templateSelectedEvent != null)
            templateSelectedEvent(RuntimeHelpers.GetObjectValue(sender), e);
          this.Hide();
        }
        else
          this.Close();
      }
      else if (this.ScreenMode == frmDocumentTemplates.ScreenModes.LaunchTemplate)
      {
        string tag = (string) ((SubObjectBase) this.tree.SelectedNodes[0]).Tag;
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(tag, "W", false) == 0)
          this.CreateNewTemplateDoc();
        else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(tag, "E", false) == 0)
          this.ShowPDFPreview();
        else
          this.ShowPDFPreview();
      }
      else
      {
        if (this.ScreenMode != frmDocumentTemplates.ScreenModes.AdminTemplates || frmDocumentTemplates.NodeIsFolder(this.tree.SelectedNodes[0]))
          return;
        this.ShowPDFPreview();
      }
    }
    else
    {
      if (this.ScreenMode != frmDocumentTemplates.ScreenModes.SelectFolder)
        return;
      this._folderSelected = frmDocumentTemplates.NodeIsFolder(this.tree.SelectedNodes[0]);
      if (this._folderSelected)
        this._selectedFolderName = this.tree.GetNodeByKey("templateGroup" + this.SelectedFolderID.ToString()).Text;
      this.Close();
    }
  }

  private void CreateNewTemplateDoc()
  {
    Cursor.Current = MgaCursors.WaitCursor;
    try
    {
      int integer = Conversions.ToInteger(this.tree.SelectedNodes[0].Key);
      Enums.AutomationDocGroups automationDocGroupID = (Enums.AutomationDocGroups) Enum.Parse(typeof (Enums.AutomationDocGroups), Database.Instance.QueryText.PerformScalarQueryInt("SELECT automationGroupID FROM tblDocumentTemplates WHERE TemplateID=@TID", (object) "@TID", (object) integer).ToString());
      if (!this._onDemandTemplates)
      {
        if (automationDocGroupID != Enums.AutomationDocGroups.AdditionalInterestDocuments)
        {
          object[] objArray = this._supportingObject.TagParserConstructorArgs((int) automationDocGroupID);
          if (objArray == null)
            return;
          ((DocumentHandling) ObjectFactory.Instance.CreateObjectEX(typeof (DocumentHandling), (object) integer)).ShowMergedDocument(objArray);
        }
        else
        {
          object[] source = this._supportingObject.TagParserConstructorArgs((int) automationDocGroupID);
          if (source != null)
            ((DocumentHandling) ObjectFactory.Instance.CreateObjectEX(typeof (DocumentHandling), (object) integer)).CreateAddlInterestDocuments(((IEnumerable<object>) source).ToList<object>());
          this.Close();
        }
      }
      else
      {
        object[] objArray = this._supportingObject.TagParserConstructorArgs((int) automationDocGroupID);
        if (objArray != null)
          ((DocumentHandling) ObjectFactory.Instance.CreateObjectEX(typeof (DocumentHandling), (object) integer)).CreateAdditionalDocument(objArray);
        this.Close();
      }
    }
    finally
    {
      Cursor.Current = MgaCursors.Default;
    }
  }

  private static bool NodeIsFolder(UltraTreeNode node) => node.Key.StartsWith("templateGroup");

  private static int GetFolderID(UltraTreeNode node)
  {
    return !frmDocumentTemplates.NodeIsFolder(node) ? -1 : Conversions.ToInteger(((SubObjectBase) node).Tag);
  }

  private void RenameFolder()
  {
    string str = Interaction.InputBox("Please enter the new name for this template folder:", "Rename Template Folder", this.tree.SelectedNodes[0].Text);
    if (string.IsNullOrEmpty(str))
      return;
    Database.Instance.QueryText.PerformNonQuery("UPDATE lstTemplateDocumentGroups SET TemplateGroup=@TemplateGroup WHERE GroupID=@GroupID", (object) "@TemplateGroup", (object) str, (object) "@GroupID", ((SubObjectBase) this.tree.SelectedNodes[0]).Tag);
    CurrentUser.Instance.LogAction($"Template folder \"{this.tree.SelectedNodes[0].Text}\" has been renamed to \"{str}\"", new Guid("{7CFE4C1A-F2B3-45bf-8B91-D2899A714B7E}"), "Folder ID: " + ((SubObjectBase) this.tree.SelectedNodes[0]).Tag.ToString());
    this.tree.SelectedNodes[0].Text = str;
  }

  private void toolbar_ToolClick(object sender, ToolClickEventArgs e)
  {
    string key = ((ToolEventArgs) e).Tool.Key;
    // ISSUE: reference to a compiler-generated method
    switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(key))
    {
      case 55822032:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Delete Template", false) != 0)
          break;
        this.DeleteTemplate();
        break;
      case 57464387:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Extract Tags", false) != 0)
          break;
        this.ExtractTags();
        break;
      case 287500657:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Restore Template", false) != 0)
          break;
        if (System.Windows.Forms.MessageBox.Show("Are you sure you want to restore this template?", "Restore Template?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
          break;
        try
        {
          Cursor.Current = MgaCursors.WaitCursor;
          UltraTreeNode selectedNode = this.tree.SelectedNodes[0];
          DefaultDatabase.ExecuteNonQuery(CommandType.Text, "UPDATE dbo.tblDocumentTemplates SET Hidden = 0 WHERE TemplateID = @templateID", new object[2]
          {
            (object) "@templateID",
            (object) Conversions.ToInteger(selectedNode.Key)
          });
          int integer = Conversions.ToInteger(selectedNode.Key);
          CurrentUser.Instance.LogAction($"Template \"{selectedNode.Text}\" has been restored.", new Guid("{7CFE4C1A-F2B3-45bf-8B91-D2899A714B7E}"), "TemplateID: " + Conversions.ToString(integer));
          this.RefreshTree(false, false);
          break;
        }
        finally
        {
          Cursor.Current = MgaCursors.Default;
        }
      case 486666510:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Delete Folder", false) != 0)
          break;
        this.DeleteFolder();
        break;
      case 1768209177:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Download", false) != 0)
          break;
        this.Download();
        break;
      case 2340089671:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "New Folder", false) != 0)
          break;
        this.NewFolder();
        break;
      case 2406335281:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Edit Template", false) != 0)
          break;
        this.EditTemplate();
        break;
      case 2490941520:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Hide Folders", false) != 0)
          break;
        this.RefreshTree(true, false);
        break;
      case 2553869873:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "New Template", false) != 0)
          break;
        this.NewTemplate();
        break;
      case 2773244923:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Move To Folder", false) != 0)
          break;
        UltraTreeNode movedNode = (UltraTreeNode) null;
        UltraTreeNode ultraTreeNode = (UltraTreeNode) null;
        string Left = "";
        try
        {
          using (frmDocumentTemplates form = (frmDocumentTemplates) ObjectFactory.Instance.CreateForm(typeof (frmDocumentTemplates)))
          {
            int integer = Conversions.ToInteger(((SubObjectBase) this.tree.SelectedNodes[0].RootNode).Tag);
            form.ShowFoldersOnly = true;
            form.LimitToOneGroup(integer);
            int num = (int) form.ShowDialog();
            if (!form.FolderSelected)
              break;
            movedNode = this.tree.SelectedNodes[0];
            ultraTreeNode = this.tree.GetNodeByKey("templateGroup" + form.SelectedFolderID.ToString());
            Left = movedNode.Parent.Text;
            CurrentUser.Instance.LogAction($"Template \"{movedNode.Text}\" has been moved{(Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "", false) == 0 ? "" : $" from folder \"{Left}\"").ToString()}{(Microsoft.VisualBasic.CompilerServices.Operators.CompareString(ultraTreeNode.Text, "", false) == 0 ? "" : $" to folder \"{ultraTreeNode.Text}\"").ToString()} (via menu)", new Guid("{7CFE4C1A-F2B3-45bf-8B91-D2899A714B7E}"), $"TemplateID:{movedNode.Key} moved from FolderID:{frmDocumentTemplates.GetFolderID(movedNode.Parent)} to FolderID:{frmDocumentTemplates.GetFolderID(ultraTreeNode)}");
            movedNode.Reposition(ultraTreeNode.Nodes);
            frmDocumentTemplates.UpdateDatabase(movedNode, ultraTreeNode);
            break;
          }
        }
        catch (ArgumentException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          int num = (int) System.Windows.Forms.MessageBox.Show($"Cannot move {movedNode.Text}{(Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "", false) == 0 ? "" : $" from folder \"{Left}\"").ToString()}{(Microsoft.VisualBasic.CompilerServices.Operators.CompareString(ultraTreeNode.Text, "", false) == 0 ? "" : $" to folder \"{ultraTreeNode.Text}\"").ToString()}", "Document Management", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          ProjectData.ClearProjectError();
          break;
        }
      case 2784802838:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Show Deleted Templates", false) != 0)
          break;
        this.RefreshTree(false, true);
        break;
      case 3158117119:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Replace Template", false) != 0)
          break;
        this.ReplaceTemplate();
        break;
      case 4070675481:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "PDF Preview", false) != 0)
          break;
        this.ShowPDFPreview();
        break;
      case 4129175913:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Rename Folder", false) != 0)
          break;
        this.RenameFolder();
        break;
      case 4258942199:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Preview", false) != 0)
          break;
        this.PreviewFile();
        break;
    }
  }

  private bool FoldersHidden()
  {
    ToolBase toolBase = (ToolBase) null;
    int num = ((ToolsCollectionBase) this.toolbar.Tools).Count - 1;
    for (int index = 0; index <= num; ++index)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((ToolsCollectionBase) this.toolbar.Tools)[index].Key, "Hide Folders", false) == 0)
        toolBase = ((ToolsCollectionBase) this.toolbar.Tools)[index];
    }
    return toolBase != null && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((ToolPropsBase) toolBase.SharedProps).Caption, "Show Folders", false) == 0;
  }

  private void RefreshTree(bool refreshOnFolderButtonClick, bool refreshOnHiddenButtonClick)
  {
    // ISSUE: variable of a compiler-generated type
    frmDocumentTemplates._Closure\u0024__157\u002D0 closure1570_1;
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    frmDocumentTemplates._Closure\u0024__157\u002D0 closure1570_2 = new frmDocumentTemplates._Closure\u0024__157\u002D0(closure1570_1);
    // ISSUE: reference to a compiler-generated field
    closure1570_2.\u0024VB\u0024Me = this;
    // ISSUE: reference to a compiler-generated field
    closure1570_2.\u0024VB\u0024Local_btnFolders = (ToolBase) null;
    // ISSUE: reference to a compiler-generated field
    closure1570_2.\u0024VB\u0024Local_btnHiddenItems = (ToolBase) null;
    int num = ((ToolsCollectionBase) this.toolbar.Tools).Count - 1;
    for (int index = 0; index <= num; ++index)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((ToolsCollectionBase) this.toolbar.Tools)[index].Key, "Hide Folders", false) == 0)
      {
        // ISSUE: reference to a compiler-generated field
        closure1570_2.\u0024VB\u0024Local_btnFolders = ((ToolsCollectionBase) this.toolbar.Tools)[index];
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((ToolsCollectionBase) this.toolbar.Tools)[index].Key, "Show Deleted Templates", false) == 0)
      {
        // ISSUE: reference to a compiler-generated field
        closure1570_2.\u0024VB\u0024Local_btnHiddenItems = ((ToolsCollectionBase) this.toolbar.Tools)[index];
      }
    }
    // ISSUE: reference to a compiler-generated field
    closure1570_2.\u0024VB\u0024Local_td = new frmDocumentTemplates.TemplateDisplay();
    string str1 = string.Empty;
    string str2 = string.Empty;
    bool flag1;
    // ISSUE: reference to a compiler-generated field
    if (closure1570_2.\u0024VB\u0024Local_btnFolders != null)
    {
      if (refreshOnFolderButtonClick)
      {
        // ISSUE: reference to a compiler-generated field
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((ToolPropsBase) closure1570_2.\u0024VB\u0024Local_btnFolders.SharedProps).Caption, "Hide Folders", false) == 0)
        {
          str1 = "Show Folders";
          flag1 = false;
        }
        else
        {
          str1 = "Hide Folders";
          flag1 = true;
        }
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        flag1 = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((ToolPropsBase) closure1570_2.\u0024VB\u0024Local_btnFolders.SharedProps).Caption, "Hide Folders", false) == 0;
      }
    }
    bool flag2;
    // ISSUE: reference to a compiler-generated field
    if (closure1570_2.\u0024VB\u0024Local_btnHiddenItems != null)
    {
      if (refreshOnHiddenButtonClick)
      {
        // ISSUE: reference to a compiler-generated field
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((ToolPropsBase) closure1570_2.\u0024VB\u0024Local_btnHiddenItems.SharedProps).Caption, "Show Deleted Templates", false) == 0)
        {
          str2 = "Hide Deleted Templates";
          flag2 = true;
        }
        else
        {
          str2 = "Show Deleted Templates";
          flag2 = false;
        }
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        flag2 = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((ToolPropsBase) closure1570_2.\u0024VB\u0024Local_btnHiddenItems.SharedProps).Caption, "Show Deleted Templates", false) != 0;
      }
    }
    // ISSUE: reference to a compiler-generated field
    closure1570_2.\u0024VB\u0024Local_btnFolders.SharedProps.Enabled = false;
    // ISSUE: reference to a compiler-generated field
    closure1570_2.\u0024VB\u0024Local_btnHiddenItems.SharedProps.Enabled = false;
    this.tree.Nodes.Clear();
    // ISSUE: reference to a compiler-generated field
    closure1570_2.\u0024VB\u0024Local_td.showFolders = flag1;
    // ISSUE: reference to a compiler-generated field
    closure1570_2.\u0024VB\u0024Local_td.showHiddenItems = flag2;
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    Utility.ExecuteThread(new DoWorkEventHandler(closure1570_2._Lambda\u0024__0), new RunWorkerCompletedEventHandler(closure1570_2._Lambda\u0024__1), (ProgressChangedEventHandler) null);
    if (!string.IsNullOrEmpty(str1))
    {
      // ISSUE: reference to a compiler-generated field
      ((ToolPropsBase) closure1570_2.\u0024VB\u0024Local_btnFolders.SharedProps).Caption = str1;
    }
    if (string.IsNullOrEmpty(str2))
      return;
    // ISSUE: reference to a compiler-generated field
    ((ToolPropsBase) closure1570_2.\u0024VB\u0024Local_btnHiddenItems.SharedProps).Caption = str2;
  }

  public void PreviewFile()
  {
    string str = this.DownloadForPreview();
    if (str.Equals(string.Empty))
      return;
    MGASystems.IMS.DocumentAutomation.FormSettings.ShowFormDialog(typeof (frmDocumentPreview), (object) str);
  }

  private void NewFolder()
  {
    if (((DisposableObjectCollectionBase) this.tree.SelectedNodes).Count == 0)
      return;
    string str = Interaction.InputBox("Please enter the name for this folder:", "Folder Name");
    if (string.IsNullOrEmpty(str))
      return;
    int tag = (int) ((SubObjectBase) this.tree.SelectedNodes[0].RootNode).Tag;
    object obj = (object) null;
    UltraTreeNode ultraTreeNode1;
    if (this.tree.SelectedNodes[0].Level > 1)
    {
      if (Versioned.IsNumeric((object) this.tree.SelectedNodes[0].Key))
      {
        ultraTreeNode1 = this.tree.SelectedNodes[0].Parent;
        obj = (object) (int) ((SubObjectBase) ultraTreeNode1).Tag;
      }
      else
      {
        ultraTreeNode1 = this.tree.SelectedNodes[0];
        obj = (object) (int) ((SubObjectBase) ultraTreeNode1).Tag;
      }
    }
    else
      ultraTreeNode1 = this.tree.SelectedNodes[0].RootNode;
    int num = DefaultDatabase.ExecuteScalar<int>(CommandType.StoredProcedure, "DocumentTemplate_CreateFolder", new object[8]
    {
      (object) "@TemplateGroup",
      (object) str,
      (object) "@AutomationGroupID",
      (object) tag,
      (object) "@ParentTemplateGroupID",
      obj,
      (object) "@UserGuid",
      (object) CurrentUser.Instance.UserGUID
    });
    UltraTreeNode ultraTreeNode2 = new UltraTreeNode();
    UltraTreeNode ultraTreeNode3 = ultraTreeNode2;
    ultraTreeNode3.LeftImages.Add((object) this.ImageList1.Images[1]);
    ultraTreeNode3.Key = "templateGroup" + num.ToString();
    ultraTreeNode3.Text = str;
    ((SubObjectBase) ultraTreeNode3).Tag = (object) num;
    ultraTreeNode1.Nodes.Insert(0, (object) ultraTreeNode2);
    ultraTreeNode1.Expanded = true;
    ultraTreeNode2.Selected = true;
    ultraTreeNode2.BringIntoView();
    CurrentUser.Instance.LogAction($"New template folder \"{str}\" has been created", new Guid("{7CFE4C1A-F2B3-45bf-8B91-D2899A714B7E}"), "FolderID: " + Conversions.ToString(num));
  }

  private void ReplaceTemplate()
  {
    this.diagOpen.Filter = this.GetDialogFilter();
    if (this.diagOpen.ShowDialog() != DialogResult.OK)
      return;
    string fileName = this.diagOpen.FileName;
    string text = this.tree.SelectedNodes[0].Text;
    dsDocumentTemplates.tblDocumentTemplatesDataTable table = new dsDocumentTemplates.tblDocumentTemplatesDataTable();
    if (this.IsWordDocument(fileName) && !this.IsValidWordDocument(fileName))
      return;
    byte[] numArray = FileReader.ReadAllBytes(fileName);
    this.daTemplates.SelectCommand.Parameters["@TemplateID"].Value = (object) Conversions.ToInteger(this.tree.SelectedNodes[0].Key);
    this.daTemplates.Fill((DataTable) table);
    dsDocumentTemplates.tblDocumentTemplatesRow documentTemplatesRow = table[0];
    documentTemplatesRow.Template = numArray;
    documentTemplatesRow.OriginalFileName = Path.GetFileName(this.diagOpen.FileName);
    documentTemplatesRow.TemplateType = this.GetTemplateType(fileName);
    Database.SafeDataAdapterUpdate(this.daTemplates, (DataTable) table);
    CurrentUser.Instance.LogAction($"Template \"{text}\" has been replaced", new Guid("{7CFE4C1A-F2B3-45bf-8B91-D2899A714B7E}"), "TemplateID: " + this.tree.SelectedNodes[0].Key);
  }

  private string GetDialogFilter()
  {
    return "Microsoft Word files (*.doc,*.docx)|*.doc;*.docx|Adobe PDF Files (*.pdf)|*.pdf|Excel document (*.xls;*.xlsx;*.xltm;*.xlsm;*.xlsb)|*.xls;*.xlsx;*.xltm;*.xlsm;*.xlsb|All files (*.*)|*.*";
  }

  private void NewTemplate()
  {
    if (!DocumentHandling.HasCompatibleOfficeVersion(true))
      return;
    frmDocumentTemplateInfo documentTemplateInfo = (frmDocumentTemplateInfo) MGASystems.IMS.DocumentAutomation.FormSettings.ShowFormDialog(typeof (frmDocumentTemplateInfo));
    try
    {
      if (documentTemplateInfo.Cancel)
        return;
      this.Refresh();
      this.diagOpen.Filter = this.GetDialogFilter();
      if (this.diagOpen.ShowDialog() != DialogResult.OK)
        return;
      string fileName = this.diagOpen.FileName;
      if (this.IsWordDocument(fileName) && !this.IsValidWordDocument(fileName))
        return;
      try
      {
        byte[] numArray = FileReader.ReadAllBytes(this.diagOpen.FileName);
        dsDocumentTemplates.tblDocumentTemplatesDataTable state = new dsDocumentTemplates.tblDocumentTemplatesDataTable();
        dsDocumentTemplates.tblDocumentTemplatesRow row = state.NewtblDocumentTemplatesRow();
        dsDocumentTemplates.tblDocumentTemplatesRow documentTemplatesRow = row;
        documentTemplatesRow.Description = documentTemplateInfo.TemplateDescription;
        documentTemplatesRow.AutomationGroupID = documentTemplateInfo.AutomationGroupID;
        documentTemplatesRow.TemplateName = documentTemplateInfo.TemplateName;
        documentTemplatesRow.Template = numArray;
        documentTemplatesRow.TemplateType = this.GetTemplateType(fileName);
        documentTemplatesRow.IsPolicyForm = documentTemplateInfo.IsPolicyForm;
        documentTemplatesRow.IsEditable = documentTemplateInfo.IsEditable;
        documentTemplatesRow.RequiresEdit = documentTemplateInfo.RequiresEdit;
        documentTemplatesRow.SaveAsType = documentTemplateInfo.SaveAsType;
        documentTemplatesRow.FileOnly = documentTemplateInfo.FileOnly;
        documentTemplatesRow.Removable = documentTemplateInfo.Removeable;
        documentTemplatesRow.HideWaterMark = documentTemplateInfo.HideWaterMark;
        documentTemplatesRow.CopyForwardOnRenewal = documentTemplateInfo.CopyForwardOnRenewals;
        documentTemplatesRow.SeparateDoc = documentTemplateInfo.SeperateDoc;
        documentTemplatesRow.OnDemand = documentTemplateInfo.OnDemand;
        documentTemplatesRow.OriginalFileName = Path.GetFileName(this.diagOpen.FileName);
        if (documentTemplateInfo.HasFolderID)
          documentTemplatesRow.FolderID = documentTemplateInfo.FolderID;
        else
          documentTemplatesRow.SetFolderIDNull();
        state.AddtblDocumentTemplatesRow(row);
        CurrentUser.Instance.LogAction($"New template added:{documentTemplateInfo.TemplateName}{(Microsoft.VisualBasic.CompilerServices.Operators.CompareString(documentTemplateInfo.FolderName, "", false) == 0 ? "" : " to folder: " + documentTemplateInfo.FolderName)}", new Guid("{7CFE4C1A-F2B3-45bf-8B91-D2899A714B7E}"), $"TemplateID:{row.TemplateID}, FolderID:{row.Field<int?>("FolderID")}");
        ThreadPool.QueueUserWorkItem(new WaitCallback(this.SaveTemplateOnThread), (object) state);
      }
      catch (UnauthorizedAccessException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        int num = (int) System.Windows.Forms.MessageBox.Show("The IMS could not access this document.\n\n It may be read-only, in use or you do not have the required permissions.", "Unauthorized File Access", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        ProjectData.ClearProjectError();
      }
      catch (IOException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        int num = (int) System.Windows.Forms.MessageBox.Show("The IMS could not access this document.\n\n Please ensure that it is not currently open in another application.", "Unable to Open Template", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        ProjectData.ClearProjectError();
      }
    }
    finally
    {
      documentTemplateInfo.Dispose();
    }
  }

  private bool IsValidWordDocument(string fileName)
  {
    bool flag;
    try
    {
      Document document = new Document(fileName);
    }
    catch (NotImplementedException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      MGASystems.Common.ThreadingFunctions.MessageBox.Show("This Word document is in an older, unsupported format.\n\nThe document must be created with Word 97 or later.", "Unsupported Word Format", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      flag = false;
      ProjectData.ClearProjectError();
      goto label_8;
    }
    catch (NotSupportedException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      MGASystems.Common.ThreadingFunctions.MessageBox.Show("This Word document is in an older, unsupported format.\n\nThe document must be created with Word 97 or later.", "Unsupported Word Format", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      flag = false;
      ProjectData.ClearProjectError();
      goto label_8;
    }
    catch (IOException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      MGASystems.Common.ThreadingFunctions.MessageBox.Show($"The IMS was unable to open the following file\n\n{this.diagOpen.FileName}\n\nPlease ensure it is not currently open by another application.", "Could Not Open File", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      flag = false;
      ProjectData.ClearProjectError();
      goto label_8;
    }
    catch (UnsupportedFileFormatException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      MGASystems.Common.ThreadingFunctions.MessageBox.Show(((Exception) ex).Message, "Word Document Format Not Supported", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      flag = false;
      ProjectData.ClearProjectError();
      goto label_8;
    }
    catch (OverflowException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      MGASystems.Common.ThreadingFunctions.MessageBox.Show("The IMS was unable to open this document.\n\nIf this is a valid Microsoft Word document, please contact technical supoport.", "Unable to Open Document", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      flag = false;
      ProjectData.ClearProjectError();
      goto label_8;
    }
    catch (InvalidOperationException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      MGASystems.Common.ThreadingFunctions.MessageBox.Show("This file is in the wrong format...It Should be a valid Word document File", "File in Wrong Format", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      flag = false;
      ProjectData.ClearProjectError();
      goto label_8;
    }
    flag = true;
label_8:
    return flag;
  }

  private bool IsWordDocument(string fileName)
  {
    return Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Path.GetExtension(fileName).ToUpper(), ".DOC", false) == 0 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Path.GetExtension(fileName).ToUpper(), ".DOCX", false) == 0;
  }

  private string GetTemplateType(string fileName)
  {
    return !this.IsWordDocument(fileName) ? (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Path.GetExtension(fileName).ToUpper(), ".PDF", false) != 0 ? "E" : "P") : "W";
  }

  private void SaveTemplateOnThread(object state)
  {
    dsDocumentTemplates.tblDocumentTemplatesDataTable templatesDataTable = (dsDocumentTemplates.tblDocumentTemplatesDataTable) state;
    try
    {
      this.daTemplates.Update((DataTable) templatesDataTable);
    }
    catch (DBConcurrencyException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      MGASystems.Common.ThreadingFunctions.MessageBox.Show("This template was not found in the database.\n\nIt is possible another user has removed it since it was retrieved from the database.", "Template Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      ProjectData.ClearProjectError();
      return;
    }
    if (!this.IsHandleCreated || this.IsDisposed || this.Disposing)
      return;
    MDIControls.Instance.MDIParent.Invoke((Delegate) new WaitCallback(this.SaveComplete), (object) templatesDataTable[0]);
  }

  private void SaveComplete(object state)
  {
    dsDocumentTemplates.tblDocumentTemplatesRow documentTemplatesRow = (dsDocumentTemplates.tblDocumentTemplatesRow) state;
    dsDocumentTemplates.tblDocumentTemplatesListRow row = this.ds.tblDocumentTemplatesList.NewtblDocumentTemplatesListRow();
    dsDocumentTemplates.tblDocumentTemplatesListRow templatesListRow = row;
    templatesListRow.TemplateID = documentTemplatesRow.TemplateID;
    templatesListRow.TemplateName = documentTemplatesRow.TemplateName;
    templatesListRow.AutomationGroupID = documentTemplatesRow.AutomationGroupID;
    templatesListRow.Description = documentTemplatesRow.Description;
    templatesListRow.TemplateType = documentTemplatesRow.TemplateType;
    this.ds.tblDocumentTemplatesList.AddtblDocumentTemplatesListRow(row);
    UltraTreeNode node = new UltraTreeNode();
    string key = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(row.TemplateType, "W", false) != 0 ? (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(row.TemplateType, "E", false) != 0 ? "PDF" : "Excel") : "Word";
    node.LeftImages.Add((object) this.ImageList1.Images[key]);
    node.Text = !string.IsNullOrEmpty(documentTemplatesRow.Description) ? $"{documentTemplatesRow.TemplateName} - {documentTemplatesRow.Description}" : documentTemplatesRow.TemplateName;
    node.Key = documentTemplatesRow.TemplateID.ToString();
    this.AddTreeNode(node, "automationGroup" + documentTemplatesRow.AutomationGroupID.ToString(), true);
    this.tree.SelectedNodes.Clear();
    node.Selected = true;
    node.BringIntoView();
  }

  private void DeleteTemplate()
  {
    if (System.Windows.Forms.MessageBox.Show("Are you sure you want to delete this template?", "Delete Template?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
      return;
    try
    {
      Cursor.Current = MgaCursors.WaitCursor;
      UltraTreeNode selectedNode = this.tree.SelectedNodes[0];
      DataRow result = DefaultDatabase.ExecuteDataRow("spDocumentTemplates_DeleteTemplate", new object[2]
      {
        (object) "@templateID",
        (object) Conversions.ToInteger(selectedNode.Key)
      });
      this.HandleDeleteTemplateResult(selectedNode, result);
    }
    finally
    {
      Cursor.Current = MgaCursors.Default;
    }
  }

  private void HandleDeleteTemplateResult(UltraTreeNode node, DataRow result)
  {
    int integer = Conversions.ToInteger(node.Key);
    if (result == null)
      return;
    string str = result.Field<string>("Result");
    if (!result.Field<bool>("Success"))
    {
      MessageBoxButtons buttons = MessageBoxButtons.OK;
      if (string.IsNullOrEmpty(str))
        str = "Unexpected error deleting template. Please try again.";
      if (SecurityManager.Instance.AssertPermission("{8FB31D86-F039-4A80-B3A5-E5434EEB2F3C}"))
      {
        str += "\nDelete anyway?";
        buttons = MessageBoxButtons.YesNo;
      }
      if (System.Windows.Forms.MessageBox.Show(str, "Unable to Delete Template", buttons, MessageBoxIcon.Asterisk) != DialogResult.Yes)
        return;
      DataRow result1 = DefaultDatabase.ExecuteDataRow("spDocumentTemplates_DeleteTemplate", new object[4]
      {
        (object) "@templateID",
        (object) integer,
        (object) "@forceDelete",
        (object) true
      });
      this.HandleDeleteTemplateResult(node, result1);
    }
    else
    {
      if (string.IsNullOrEmpty(str))
        str = $"Template \"{node.Text}\" has been deleted.";
      CurrentUser.Instance.LogAction(str, new Guid("{7CFE4C1A-F2B3-45bf-8B91-D2899A714B7E}"), "TemplateID: " + Conversions.ToString(integer));
      this.ds.tblDocumentTemplatesList.RemovetblDocumentTemplatesListRow(this.ds.tblDocumentTemplatesList.FindByTemplateID(integer));
      node.Remove();
    }
  }

  private void ShowEditedTemplateName(dsDocumentTemplates.tblDocumentTemplatesRow row)
  {
    if (row == null)
      return;
    this.tree.SelectedNodes[0].Text = row.TemplateName + (string.IsNullOrEmpty(row.Description) ? "" : " - " + row.Description);
  }

  private void EditTemplate()
  {
    frmDocumentTemplates documentTemplates = this;
    if (!DocumentHandling.HasCompatibleOfficeVersion(true) || ((DisposableObjectCollectionBase) this.tree.SelectedNodes).Count == 0)
      return;
    Cursor.Current = MgaCursors.WaitCursor;
    int integer = Conversions.ToInteger(this.tree.SelectedNodes[0].Key);
    string text = this.tree.SelectedNodes[0].Text;
    dsDocumentTemplates.tblDocumentTemplatesDataTable table = new dsDocumentTemplates.tblDocumentTemplatesDataTable();
    this.daTemplates.SelectCommand.Parameters["@TemplateID"].Value = (object) integer;
    this.daTemplates.Fill((DataTable) table);
    if (table.Count == 0)
    {
      int num1 = (int) System.Windows.Forms.MessageBox.Show("The template you are attempting to edit cannot be found in the system.", "Template Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else
    {
      using (frmDocumentTemplateInfo documentTemplateInfo = (frmDocumentTemplateInfo) MGASystems.IMS.DocumentAutomation.FormSettings.ShowFormDialog(typeof (frmDocumentTemplateInfo), (object) table[0]))
      {
        MDIControls.Instance.MDIParent.Refresh();
        if (documentTemplateInfo.Cancel)
        {
          Database.SafeDataAdapterUpdate(this.daTemplates, (DataTable) table);
          return;
        }
        if (!documentTemplateInfo.EditWordDoc)
        {
          Database.SafeDataAdapterUpdate(this.daTemplates, (DataTable) table);
          if (documentTemplateInfo.UpdateTemplateGroupIDAfterTypeChange)
            DefaultDatabase.ExecuteNonQuery(CommandType.Text, "UPDATE tblDocumentTemplates SET TemplateGroupID=NULL WHERE TemplateID=@TemplateID", new object[2]
            {
              (object) "@TemplateID",
              (object) integer
            });
          this.ShowEditedTemplateName(table[0]);
          if (documentTemplateInfo.ShowRefreshMessage && System.Windows.Forms.MessageBox.Show("A change was made that will not be shown unless a refresh is done.", "Refresh?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            this.RefreshTree(false, false);
          CurrentUser.Instance.LogAction($"Properties of template \"{text}\" has been updated", new Guid("{7CFE4C1A-F2B3-45bf-8B91-D2899A714B7E}"), "TemplateID: " + Conversions.ToString(integer));
          return;
        }
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(table[0].TemplateType, "P", false) == 0)
        {
          int num2 = (int) System.Windows.Forms.MessageBox.Show("Only Microsoft Word Or Microsoft Excel template documents can be edited.", "Unable to Edit Template", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          return;
        }
        this.ShowEditedTemplateName(table[0]);
      }
      string file = this.SaveByteArrayToFile(table[0].Template, table[0].OriginalFileName);
      if (this.IsWordDocument(table[0].OriginalFileName))
      {
        if (!WordTemplate.UseWordWithEvents())
        {
          ((ToolsCollectionBase) ((UltraToolbarBase) this.toolbar.Toolbars[0]).Tools)["Edit Template"].SharedProps.Enabled = false;
          this._editingWordPolling = true;
        }
        frmDocumentTemplatesWordHost formEx = (frmDocumentTemplatesWordHost) ObjectFactory.Instance.CreateFormEX(typeof (frmDocumentTemplatesWordHost), (object) file, (object) false);
        formEx.ShowAvailableTags(integer);
        formEx.WordDocumentSaved += (frmDocumentTemplatesWordHost.WordDocumentSavedEventHandler) ([SpecialName] (sender, evargs) =>
        {
          if (sender != formEx)
            return;
          closure_1.DocumentSaved(closure_0, evargs.FileName);
        });
        formEx.WordDocumentClosed += (frmDocumentTemplatesWordHost.WordDocumentClosedEventHandler) ([SpecialName] (sender, evargs) =>
        {
          if (sender != formEx)
            return;
          closure_1.DocumentClosed(closure_0, evargs.FileName);
        });
        MGASystems.IMS.DocumentAutomation.FormSettings.ShowFormOnSecondMonitorIfAvailableOA((Form) formEx, false);
      }
      else
      {
        this.AddFileWatch(file, integer);
        Process.Start(file);
      }
    }
  }

  public static void ShowFormOnSecondMonitorIfAvailableOA(Form frm, bool setMDIParent)
  {
    MGASystems.IMS.DocumentAutomation.FormSettings.ShowFormOnSecondMonitorIfAvailableOA(frm, setMDIParent);
  }

  private void ExtractTags()
  {
    Cursor.Current = MgaCursors.WaitCursor;
    try
    {
      int result;
      if (int.TryParse(this.tree.SelectedNodes[0].Key, out result) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((SubObjectBase) this.tree.SelectedNodes[0]).Tag.ToString(), "W", false) == 0)
      {
        List<DocTag> tags = DocumentHandling.ExtractTags(result);
        if (tags.Count > 0)
        {
          Enums.AutomationDocGroups automationDocGroups = (Enums.AutomationDocGroups) Enum.Parse(typeof (Enums.AutomationDocGroups), Database.Instance.QueryText.PerformScalarQueryInt("SELECT automationGroupID FROM tblDocumentTemplates WHERE TemplateID=@TID", (object) "@TID", (object) result).ToString());
          MGASystems.Common.FormSettings.ShowForm(typeof (frmTagExtractor), (object) tags, (object) this._supportingObject, (object) result, (object) automationDocGroups);
        }
        else
        {
          int num = (int) System.Windows.Forms.MessageBox.Show("This document has no template tags.", "No tags found.");
        }
      }
      else
      {
        int num1 = (int) System.Windows.Forms.MessageBox.Show("This is not a template document.", "Non-Template Document");
      }
    }
    finally
    {
      Cursor.Current = MgaCursors.Default;
    }
  }

  public string ScrubFileName(string fileName)
  {
    char[] invalidFileNameChars = Path.GetInvalidFileNameChars();
    int index = 0;
    while (index < invalidFileNameChars.Length)
    {
      char ch = invalidFileNameChars[index];
      fileName = fileName.Replace(Conversions.ToString(ch), string.Empty);
      checked { ++index; }
    }
    return fileName;
  }

  private void Download()
  {
    Cursor.Current = MgaCursors.WaitCursor;
    try
    {
      if (((DisposableObjectCollectionBase) this.tree.SelectedNodes).Count == 1)
      {
        int result;
        if (!int.TryParse(this.tree.SelectedNodes[0].Key, out result))
          return;
        DataRow row = DefaultDatabase.ExecuteDataRow("spGetDocumentTemplate", new object[2]
        {
          (object) "@TID",
          (object) result
        });
        string str1 = Path.Combine(Path.GetTempPath(), this.ScrubFileName(this.tree.SelectedNodes[0].Text.ToString()));
        string str2 = row.Field<string>("OriginalFileName");
        using (SaveFileDialog saveFileDialog = new SaveFileDialog())
        {
          if (((SubObjectBase) this.tree.SelectedNodes[0]).Tag.Equals((object) "P"))
          {
            saveFileDialog.FileName = str1 + ".pdf";
            saveFileDialog.Filter = "PDF|*.pdf";
          }
          else
          {
            string path = str2;
            char[] invalidFileNameChars = Path.GetInvalidFileNameChars();
            int index = 0;
            while (index < invalidFileNameChars.Length)
            {
              char ch = invalidFileNameChars[index];
              path = path.Replace(Conversions.ToString(ch), string.Empty);
              checked { ++index; }
            }
            if (string.Compare(Path.GetExtension(path), ".docx", true) == 0)
            {
              saveFileDialog.FileName = str1 + ".docx";
              saveFileDialog.Filter = "Word Document|*.docx";
            }
            else
            {
              saveFileDialog.FileName = str1 + ".doc";
              saveFileDialog.Filter = "Word Document|*.doc";
            }
          }
          if (saveFileDialog.ShowDialog() != DialogResult.OK)
            return;
          File.WriteAllBytes(saveFileDialog.FileName, row.Field<byte[]>("Template"));
        }
      }
      else
      {
        using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
        {
          if (folderBrowserDialog.ShowDialog() != DialogResult.OK)
            return;
          string selectedPath = folderBrowserDialog.SelectedPath;
          foreach (UltraTreeNode selectedNode in this.tree.SelectedNodes)
          {
            int result;
            if (int.TryParse(selectedNode.Key, out result))
            {
              DataRow row = DefaultDatabase.ExecuteDataRow("spGetDocumentTemplate", new object[2]
              {
                (object) "@TID",
                (object) result
              });
              string str3 = row.Field<string>("OriginalFileName");
              string str4 = Path.Combine(selectedPath, this.ScrubFileName(selectedNode.Text.ToString()));
              string path1;
              if (((SubObjectBase) selectedNode).Tag.Equals((object) "P"))
              {
                path1 = str4 + ".pdf";
              }
              else
              {
                string path2 = str3;
                char[] invalidFileNameChars = Path.GetInvalidFileNameChars();
                int index = 0;
                while (index < invalidFileNameChars.Length)
                {
                  char ch = invalidFileNameChars[index];
                  path2 = path2.Replace(Conversions.ToString(ch), string.Empty);
                  checked { ++index; }
                }
                path1 = string.Compare(Path.GetExtension(path2), ".docx", true) != 0 ? str4 + ".doc" : str4 + ".docx";
              }
              File.WriteAllBytes(path1, row.Field<byte[]>("Template"));
            }
          }
          int num = (int) System.Windows.Forms.MessageBox.Show("Download complete", "Document Template Download", MessageBoxButtons.OK);
        }
      }
    }
    finally
    {
      Cursor.Current = MgaCursors.Default;
    }
  }

  private string DownloadForPreview()
  {
    Cursor.Current = MgaCursors.WaitCursor;
    try
    {
      if (((DisposableObjectCollectionBase) this.tree.SelectedNodes).Count == 1)
      {
        int result;
        if (!int.TryParse(this.tree.SelectedNodes[0].Key, out result))
          return string.Empty;
        DataRow row = DefaultDatabase.ExecuteDataRow("spGetDocumentTemplate", new object[2]
        {
          (object) "@TID",
          (object) result
        });
        string str1 = Path.Combine(Path.GetTempPath(), this.ScrubFileName(this.tree.SelectedNodes[0].Text.ToString()));
        string str2 = row.Field<string>("OriginalFileName");
        if (((SubObjectBase) this.tree.SelectedNodes[0]).Tag.Equals((object) "P"))
        {
          int num = (int) System.Windows.Forms.MessageBox.Show("Previewing not supported for .pdf files");
          return string.Empty;
        }
        string path1 = str2;
        char[] invalidFileNameChars = Path.GetInvalidFileNameChars();
        int index = 0;
        while (index < invalidFileNameChars.Length)
        {
          char ch = invalidFileNameChars[index];
          path1 = path1.Replace(Conversions.ToString(ch), string.Empty);
          checked { ++index; }
        }
        string path2 = string.Compare(Path.GetExtension(path1), ".docx", true) != 0 ? str1 + ".doc" : str1 + ".docx";
        File.WriteAllBytes(path2, row.Field<byte[]>("Template"));
        return path2;
      }
      int num1 = (int) System.Windows.Forms.MessageBox.Show("Cannot preview multiple files");
      return string.Empty;
    }
    finally
    {
      Cursor.Current = MgaCursors.Default;
    }
  }

  private void tree_MouseMove(object sender, MouseEventArgs e)
  {
    if (this.tree == null || this.tree.ActiveNode == null || e.Button != MouseButtons.Left || this.tree.ActiveNode.Level <= 0 || this.ScreenMode != frmDocumentTemplates.ScreenModes.AdminTemplates)
      return;
    Point pt = new Point(e.X, e.Y);
    if (((UIElement) this.tree.UIElement).ElementFromPoint(pt) is ScrollThumbUIElement)
      return;
    Rectangle rectangle = new Rectangle(this._lastMouseDownPoint, SystemInformation.DragSize);
    ref Rectangle local1 = ref rectangle;
    int x = rectangle.X;
    Size dragSize = SystemInformation.DragSize;
    int num1 = (int) Math.Round((double) dragSize.Width / 2.0);
    int num2 = x - num1;
    local1.X = num2;
    ref Rectangle local2 = ref rectangle;
    int y = rectangle.Y;
    dragSize = SystemInformation.DragSize;
    int num3 = (int) Math.Round((double) dragSize.Height / 2.0);
    int num4 = y - num3;
    local2.Y = num4;
    if (!rectangle.Contains(pt))
      return;
    int num5 = (int) ((Control) this.tree).DoDragDrop((object) this.tree.SelectedNodes, DragDropEffects.All);
  }

  private void tree_DragOver(object sender, DragEventArgs e)
  {
    UltraTreeNode nodeFromPoint = this.tree.GetNodeFromPoint(((Control) this.tree).PointToClient(new Point(e.X, e.Y)));
    if (nodeFromPoint == null || !frmDocumentTemplates.NodeIsFolder(nodeFromPoint) && nodeFromPoint.Level != 0)
    {
      e.Effect = DragDropEffects.None;
    }
    else
    {
      UltraTreeNode ultraTreeNode = ((SelectedNodesCollection) e.Data.GetData(typeof (SelectedNodesCollection)))[0];
      if (nodeFromPoint.Level == 0 && nodeFromPoint != ultraTreeNode.RootNode)
      {
        e.Effect = DragDropEffects.None;
      }
      else
      {
        if (!frmDocumentTemplates.NodeIsFolder(nodeFromPoint) && !nodeFromPoint.IsRootLevelNode)
          return;
        e.Effect = DragDropEffects.Move;
        this.tree.SelectedNodes.Clear();
        nodeFromPoint.Selected = true;
        ultraTreeNode.Selected = true;
        this.tree.Refresh();
      }
    }
  }

  private void tree_DragDrop(object sender, DragEventArgs e)
  {
    UltraTreeNode nodeFromPoint = this.tree.GetNodeFromPoint(((Control) this.tree).PointToClient(new Point(e.X, e.Y)));
    if (nodeFromPoint == null)
      return;
    if (this.ScreenMode != frmDocumentTemplates.ScreenModes.AdminTemplates)
      return;
    try
    {
      foreach (UltraTreeNode ultraTreeNode in this.tempselected)
      {
        if (!frmDocumentTemplates.NodeIsFolder(ultraTreeNode))
        {
          int integer = Conversions.ToInteger(ultraTreeNode.Key);
          CurrentUser.Instance.LogAction($"Template \"{ultraTreeNode.Text}\" moved {(Microsoft.VisualBasic.CompilerServices.Operators.CompareString(ultraTreeNode.Parent.Text, "", false) == 0 ? "" : $" from folder \"{ultraTreeNode.Parent.Text}\"").ToString()}{(Microsoft.VisualBasic.CompilerServices.Operators.CompareString(nodeFromPoint.Text, "", false) == 0 ? "" : $" to folder \"{nodeFromPoint.Text}\"").ToString()}(via drag)", new Guid("{7CFE4C1A-F2B3-45bf-8B91-D2899A714B7E}"), $"TemplateID:{integer} moved from FolderID:{frmDocumentTemplates.GetFolderID(ultraTreeNode.Parent)} to FolderID:{frmDocumentTemplates.GetFolderID(nodeFromPoint)}");
          ultraTreeNode.Reposition(nodeFromPoint.Nodes);
          nodeFromPoint.Expanded = true;
          frmDocumentTemplates.UpdateDatabase(ultraTreeNode, nodeFromPoint);
        }
      }
    }
    finally
    {
      List<UltraTreeNode>.Enumerator enumerator;
      enumerator.Dispose();
    }
    this.tree.ActiveNode = nodeFromPoint;
  }

  private static void UpdateDatabase(UltraTreeNode movedNode, UltraTreeNode destinationNode)
  {
    try
    {
      int num;
      if (destinationNode.IsRootLevelNode)
      {
        if (frmDocumentTemplates.NodeIsFolder(movedNode))
          num = Database.Instance.QueryText.PerformNonQuery("UPDATE lstTemplateDocumentGroups SET ParentTemplateGroupID=NULL WHERE GroupID=@GroupID", (object) "@GroupID", ((SubObjectBase) movedNode).Tag);
        else
          num = Database.Instance.QueryText.PerformNonQuery("UPDATE tblDocumentTemplates SET TemplateGroupID=NULL WHERE TemplateID=@TemplateID", (object) "@TemplateGroupID", ((SubObjectBase) destinationNode).Tag, (object) "@TemplateID", (object) movedNode.Key);
      }
      else if (frmDocumentTemplates.NodeIsFolder(movedNode))
        num = Database.Instance.QueryText.PerformNonQuery("UPDATE lstTemplateDocumentGroups SET ParentTemplateGroupID=@ParentTemplateGroupID WHERE GroupID=@GroupID", (object) "@ParentTemplateGroupID", ((SubObjectBase) destinationNode).Tag, (object) "@GroupID", ((SubObjectBase) movedNode).Tag);
      else
        num = Database.Instance.QueryText.PerformNonQuery("UPDATE tblDocumentTemplates SET TemplateGroupID=@TemplateGroupID WHERE TemplateID=@TemplateID", (object) "@TemplateGroupID", ((SubObjectBase) destinationNode).Tag, (object) "@TemplateID", (object) movedNode.Key);
      if (num == 0)
        throw new IncorrectNumberOfRowsAffectedException();
    }
    catch (SqlException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ErrorHandler.HandleError((Exception) ex);
      ProjectData.ClearProjectError();
    }
  }

  private void txtFolderFilter_TextChanged(object sender, EventArgs e)
  {
    this.FilterFolders(((TextEditorControlBase) this.txtFolderFilter).Text, this.tree.Nodes);
  }

  private void txtTemplateFilter_TextChanged(object sender, EventArgs e)
  {
    this.FilterTemplates(((TextEditorControlBase) this.txtTemplateFilter).Text, this.tree.Nodes);
  }

  private void FilterTemplates(string containsString, TreeNodesCollection nodes)
  {
    foreach (UltraTreeNode node in nodes)
    {
      if (node.Level == 0 || frmDocumentTemplates.NodeIsFolder(node))
      {
        if (node.Visible && node.HasNodes)
          this.FilterTemplates(containsString, node.Nodes);
      }
      else
      {
        node.Visible = string.IsNullOrEmpty(containsString) || frmDocumentTemplates.ContainsCaseInsensitive(node.Text, containsString);
        if (node.Visible && node.HasNodes)
          this.FilterTemplates(containsString, node.Nodes);
      }
    }
  }

  private void FilterFolders(string containsString, TreeNodesCollection nodes)
  {
    foreach (UltraTreeNode node in nodes)
    {
      if (node.Level == 0)
      {
        if (node.Visible && node.HasNodes)
          this.FilterFolders(containsString, node.Nodes);
      }
      else if (frmDocumentTemplates.NodeIsFolder(node))
      {
        node.Visible = string.IsNullOrEmpty(containsString) || frmDocumentTemplates.ContainsCaseInsensitive(node.Text, containsString);
        if (node.Visible && node.HasNodes)
          this.FilterFolders(containsString, node.Nodes);
      }
    }
  }

  public static bool ContainsCaseInsensitive(string source, string value)
  {
    return source.IndexOf(value, StringComparison.CurrentCultureIgnoreCase) != -1;
  }

  private void frmDocumentTemplates_Closed(object sender, EventArgs e)
  {
    // ISSUE: reference to a compiler-generated field
    frmDocumentTemplates.DocTemplateClosedEventHandler templateClosedEvent = this.DocTemplateClosedEvent;
    if (templateClosedEvent == null)
      return;
    templateClosedEvent(RuntimeHelpers.GetObjectValue(sender), e);
  }

  public Guid? LogIdentifier => new Guid?(new Guid("{7CFE4C1A-F2B3-45bf-8B91-D2899A714B7E}"));

  public void AddFileWatch(string fullPath, int templateID)
  {
    if (this.WatchedFiles.ContainsKey(fullPath))
      return;
    this.WatchedFiles.Add(fullPath, templateID);
  }

  private void FileModified(string fullPath)
  {
    int num;
    if (!this.WatchedFiles.ContainsKey(fullPath) || !this.WatchedFiles.TryGetValue(fullPath, out num))
      return;
    dsDocumentTemplates.tblDocumentTemplatesDataTable dt = new dsDocumentTemplates.tblDocumentTemplatesDataTable();
    this.daTemplates.SelectCommand.Parameters["@TemplateID"].Value = (object) num;
    this.daTemplates.Fill((DataTable) dt);
    this.DocumentSaved(dt, fullPath);
  }

  private enum ScreenModes
  {
    AdminTemplates = 1,
    SelectTemplate = 2,
    LaunchTemplate = 3,
    SelectFolder = 4,
  }

  private delegate void AddTreeNodeHandler(UltraTreeNode node);

  private delegate void AddChildTreeNodeHandler(
    UltraTreeNode node,
    string parentNodeKey,
    bool withFolders);

  private delegate void BeginTreeUpdateHandler(object obj);

  private delegate void EndTreeUpdateHandler(object obj);

  private delegate void LoadingLabelVisibilityHandler(bool visibility);

  private delegate void ShowPDFPreviewThreadCompleteHandler(string outputPDFFileName);

  public delegate void DocTemplateSelectedEventHandler(object sender, EventArgs e);

  public delegate void DocTemplateClosedEventHandler(object sender, EventArgs e);

  private struct TemplateDisplay
  {
    public bool showFolders;
    public bool showHiddenItems;
  }
}
