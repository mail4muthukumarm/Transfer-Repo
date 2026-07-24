// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.NoteDocuments.DocumentSystem.DocumentPanel
// Assembly: MgaSystems.IMS.NotesDocuments, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 3F898CF7-066D-4B05-A9F1-D37DBC4FAA16
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.NotesDocuments.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinToolbars;
using MGASystems.Common;
using MGASystems.Common.DataAccess;
using MGASystems.Common.Extensions;
using MGASystems.Common.NativeWindowMethods;
using MGASystems.ExtendedEditors.DragDrop;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.NoteDocuments.DocumentSystem;

public class DocumentPanel : UserControl
{
  private IContainer components;
  private MenuItem MenuItem1;
  private ContextMenu ctx;
  private ImageList imgSmall;
  private ImageList imgLarge;
  private MenuItem MenuItem5;
  private MenuItem MenuItem10;
  private MenuItem MenuItem11;
  private Panel DocumentPanel_Fill_Panel;
  private OpenFileDialog OpenFileDialog1;
  private UltraToolbarsDockArea _DocumentPanel_Toolbars_Dock_Area_Left;
  private UltraToolbarsDockArea _DocumentPanel_Toolbars_Dock_Area_Right;
  private UltraToolbarsDockArea _DocumentPanel_Toolbars_Dock_Area_Top;
  private UltraToolbarsDockArea _DocumentPanel_Toolbars_Dock_Area_Bottom;
  private ColumnHeader ColumnHeader1;
  private ColumnHeader ColumnHeader2;
  private ColumnHeader ColumnHeader3;
  private ColumnHeader ColumnHeader4;
  private ColumnHeader ColumnHeader5;
  private DocumentPanel.DocumentImageListInitializer _docListInitializer;
  private Guid _noteGuid;
  private bool _inDocumentBound;

  public DocumentPanel()
  {
    this.Load += new EventHandler(this.DocumentPanel_Load);
    this.InitializeComponent();
    if (!CurrentUser.Instance.UsingXP)
      return;
    this.imgSmall.ColorDepth = ColorDepth.Depth32Bit;
    this.imgLarge.ColorDepth = ColorDepth.Depth32Bit;
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    DocumentManager.EntityDocumentCollectionChanged -= new EventHandler(this.DocumentSystem_EntityCollectionModified);
    DocumentManager.DocumentBound -= new DocumentManager.DocumentBoundEventHandler(this.DocumentSystem_DocumentBound);
    base.Dispose(disposing);
  }

  private virtual MenuItem mnuDetails
  {
    get => this._mnuDetails;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.mnuDetails_Click);
      MenuItem mnuDetails1 = this._mnuDetails;
      if (mnuDetails1 != null)
        mnuDetails1.Click -= eventHandler;
      this._mnuDetails = value;
      MenuItem mnuDetails2 = this._mnuDetails;
      if (mnuDetails2 == null)
        return;
      mnuDetails2.Click += eventHandler;
    }
  }

  private virtual MenuItem mnuLargeIcons
  {
    get => this._mnuLargeIcons;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.mnuLargeIcons_Click);
      MenuItem mnuLargeIcons1 = this._mnuLargeIcons;
      if (mnuLargeIcons1 != null)
        mnuLargeIcons1.Click -= eventHandler;
      this._mnuLargeIcons = value;
      MenuItem mnuLargeIcons2 = this._mnuLargeIcons;
      if (mnuLargeIcons2 == null)
        return;
      mnuLargeIcons2.Click += eventHandler;
    }
  }

  private virtual MenuItem mnuSmallIcons
  {
    get => this._mnuSmallIcons;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.mnuSmallIcons_Click);
      MenuItem mnuSmallIcons1 = this._mnuSmallIcons;
      if (mnuSmallIcons1 != null)
        mnuSmallIcons1.Click -= eventHandler;
      this._mnuSmallIcons = value;
      MenuItem mnuSmallIcons2 = this._mnuSmallIcons;
      if (mnuSmallIcons2 == null)
        return;
      mnuSmallIcons2.Click += eventHandler;
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

  private virtual MenuItem mnuOpen
  {
    get => this._mnuOpen;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.mnuOpen_Click);
      MenuItem mnuOpen1 = this._mnuOpen;
      if (mnuOpen1 != null)
        mnuOpen1.Click -= eventHandler;
      this._mnuOpen = value;
      MenuItem mnuOpen2 = this._mnuOpen;
      if (mnuOpen2 == null)
        return;
      mnuOpen2.Click += eventHandler;
    }
  }

  private virtual MenuItem mnuRemove
  {
    get => this._mnuRemove;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.mnuRemove_Click);
      MenuItem mnuRemove1 = this._mnuRemove;
      if (mnuRemove1 != null)
        mnuRemove1.Click -= eventHandler;
      this._mnuRemove = value;
      MenuItem mnuRemove2 = this._mnuRemove;
      if (mnuRemove2 == null)
        return;
      mnuRemove2.Click += eventHandler;
    }
  }

  private virtual MenuItem mnuPrint
  {
    get => this._mnuPrint;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.mnuPrint_Click);
      MenuItem mnuPrint1 = this._mnuPrint;
      if (mnuPrint1 != null)
        mnuPrint1.Click -= eventHandler;
      this._mnuPrint = value;
      MenuItem mnuPrint2 = this._mnuPrint;
      if (mnuPrint2 == null)
        return;
      mnuPrint2.Click += eventHandler;
    }
  }

  private virtual MenuItem mnuAddExisting
  {
    get => this._mnuAddExisting;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.mnuAddExisting_Click);
      MenuItem mnuAddExisting1 = this._mnuAddExisting;
      if (mnuAddExisting1 != null)
        mnuAddExisting1.Click -= eventHandler;
      this._mnuAddExisting = value;
      MenuItem mnuAddExisting2 = this._mnuAddExisting;
      if (mnuAddExisting2 == null)
        return;
      mnuAddExisting2.Click += eventHandler;
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

  private virtual ListView lstDocs
  {
    get => this._lstDocs;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.lstDocs_DoubleClick);
      DragEventHandler dragEventHandler1 = new DragEventHandler(this.lstDocs_DragDrop);
      DragEventHandler dragEventHandler2 = new DragEventHandler(this.lstDocs_DragOver);
      ListView lstDocs1 = this._lstDocs;
      if (lstDocs1 != null)
      {
        lstDocs1.DoubleClick -= eventHandler;
        lstDocs1.DragDrop -= dragEventHandler1;
        lstDocs1.DragOver -= dragEventHandler2;
      }
      this._lstDocs = value;
      ListView lstDocs2 = this._lstDocs;
      if (lstDocs2 == null)
        return;
      lstDocs2.DoubleClick += eventHandler;
      lstDocs2.DragDrop += dragEventHandler1;
      lstDocs2.DragOver += dragEventHandler2;
    }
  }

  private virtual MenuItem mnuList
  {
    get => this._mnuList;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.mnuList_Click);
      MenuItem mnuList1 = this._mnuList;
      if (mnuList1 != null)
        mnuList1.Click -= eventHandler;
      this._mnuList = value;
      MenuItem mnuList2 = this._mnuList;
      if (mnuList2 == null)
        return;
      mnuList2.Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("DragDropExtender1")]
  internal virtual DragDropExtender DragDropExtender1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    UltraToolbar ultraToolbar = new UltraToolbar("UltraToolbar1");
    ButtonTool buttonTool1 = new ButtonTool("Open Existing");
    ButtonTool buttonTool2 = new ButtonTool("Refresh");
    ButtonTool buttonTool3 = new ButtonTool("View Doc");
    ButtonTool buttonTool4 = new ButtonTool("Remove Binding");
    ButtonTool buttonTool5 = new ButtonTool("Print Doc");
    ButtonTool buttonTool6 = new ButtonTool("View Props");
    LabelTool labelTool1 = new LabelTool("Files associated with this note");
    ButtonTool buttonTool7 = new ButtonTool("Open Existing");
    Appearance appearance1 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (DocumentPanel));
    ButtonTool buttonTool8 = new ButtonTool("Refresh");
    Appearance appearance2 = new Appearance();
    LabelTool labelTool2 = new LabelTool("Files associated with this note");
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    ButtonTool buttonTool9 = new ButtonTool("View Doc");
    Appearance appearance6 = new Appearance();
    ButtonTool buttonTool10 = new ButtonTool("Remove Binding");
    Appearance appearance7 = new Appearance();
    ButtonTool buttonTool11 = new ButtonTool("Print Doc");
    Appearance appearance8 = new Appearance();
    ButtonTool buttonTool12 = new ButtonTool("View Props");
    Appearance appearance9 = new Appearance();
    this.ctx = new ContextMenu();
    this.MenuItem1 = new MenuItem();
    this.mnuDetails = new MenuItem();
    this.mnuLargeIcons = new MenuItem();
    this.mnuSmallIcons = new MenuItem();
    this.mnuList = new MenuItem();
    this.MenuItem11 = new MenuItem();
    this.mnuOpen = new MenuItem();
    this.mnuPrint = new MenuItem();
    this.MenuItem10 = new MenuItem();
    this.mnuAddExisting = new MenuItem();
    this.mnuRemove = new MenuItem();
    this.MenuItem5 = new MenuItem();
    this.mnuProperties = new MenuItem();
    this.imgSmall = new ImageList(this.components);
    this.imgLarge = new ImageList(this.components);
    this.DocumentPanel_Fill_Panel = new Panel();
    this.lstDocs = new ListView();
    this.ColumnHeader1 = new ColumnHeader();
    this.ColumnHeader2 = new ColumnHeader();
    this.ColumnHeader3 = new ColumnHeader();
    this.ColumnHeader4 = new ColumnHeader();
    this.ColumnHeader5 = new ColumnHeader();
    this.OpenFileDialog1 = new OpenFileDialog();
    this._DocumentPanel_Toolbars_Dock_Area_Left = new UltraToolbarsDockArea();
    this.UltraToolbarsManager1 = new UltraToolbarsManager(this.components);
    this._DocumentPanel_Toolbars_Dock_Area_Right = new UltraToolbarsDockArea();
    this._DocumentPanel_Toolbars_Dock_Area_Top = new UltraToolbarsDockArea();
    this._DocumentPanel_Toolbars_Dock_Area_Bottom = new UltraToolbarsDockArea();
    this.DragDropExtender1 = new DragDropExtender(this.components);
    this.DocumentPanel_Fill_Panel.SuspendLayout();
    ((ISupportInitialize) this.UltraToolbarsManager1).BeginInit();
    this.SuspendLayout();
    this.ctx.MenuItems.AddRange(new MenuItem[9]
    {
      this.MenuItem1,
      this.MenuItem11,
      this.mnuOpen,
      this.mnuPrint,
      this.MenuItem10,
      this.mnuAddExisting,
      this.mnuRemove,
      this.MenuItem5,
      this.mnuProperties
    });
    this.MenuItem1.Index = 0;
    this.MenuItem1.MenuItems.AddRange(new MenuItem[4]
    {
      this.mnuDetails,
      this.mnuLargeIcons,
      this.mnuSmallIcons,
      this.mnuList
    });
    this.MenuItem1.Text = "&View";
    this.mnuDetails.Index = 0;
    this.mnuDetails.Text = "&Details";
    this.mnuLargeIcons.Index = 1;
    this.mnuLargeIcons.Text = "&Large Icons";
    this.mnuSmallIcons.Index = 2;
    this.mnuSmallIcons.Text = "&Small Icons";
    this.mnuList.Index = 3;
    this.mnuList.Text = "Lis&t";
    this.MenuItem11.Index = 1;
    this.MenuItem11.Text = "-";
    this.mnuOpen.Index = 2;
    this.mnuOpen.Text = "&Open";
    this.mnuPrint.Index = 3;
    this.mnuPrint.Text = "&Print";
    this.MenuItem10.Index = 4;
    this.MenuItem10.Text = "-";
    this.mnuAddExisting.Index = 5;
    this.mnuAddExisting.Text = "&Add Existing";
    this.mnuRemove.Index = 6;
    this.mnuRemove.Text = "&Remove";
    this.MenuItem5.Index = 7;
    this.MenuItem5.Text = "-";
    this.mnuProperties.Index = 8;
    this.mnuProperties.Text = "Proper&ties";
    this.imgSmall.ColorDepth = ColorDepth.Depth32Bit;
    this.imgSmall.ImageSize = new Size(16 /*0x10*/, 16 /*0x10*/);
    this.imgSmall.TransparentColor = Color.Transparent;
    this.imgLarge.ColorDepth = ColorDepth.Depth32Bit;
    this.imgLarge.ImageSize = new Size(32 /*0x20*/, 32 /*0x20*/);
    this.imgLarge.TransparentColor = Color.Transparent;
    this.DocumentPanel_Fill_Panel.Controls.Add((Control) this.lstDocs);
    this.DocumentPanel_Fill_Panel.Dock = DockStyle.Fill;
    this.DocumentPanel_Fill_Panel.Location = new Point(0, 26);
    this.DocumentPanel_Fill_Panel.Name = "DocumentPanel_Fill_Panel";
    this.DocumentPanel_Fill_Panel.Size = new Size(560, 294);
    this.DocumentPanel_Fill_Panel.TabIndex = 0;
    this.lstDocs.BorderStyle = BorderStyle.FixedSingle;
    this.lstDocs.Columns.AddRange(new ColumnHeader[5]
    {
      this.ColumnHeader1,
      this.ColumnHeader2,
      this.ColumnHeader3,
      this.ColumnHeader4,
      this.ColumnHeader5
    });
    this.lstDocs.ContextMenu = this.ctx;
    this.lstDocs.Location = new Point(16 /*0x10*/, 48 /*0x30*/);
    this.lstDocs.Name = "lstDocs";
    this.lstDocs.Size = new Size(528, 192 /*0xC0*/);
    this.lstDocs.TabIndex = 0;
    this.lstDocs.UseCompatibleStateImageBehavior = false;
    this.lstDocs.View = View.Details;
    this.ColumnHeader1.Text = "File Name";
    this.ColumnHeader1.Width = 159;
    this.ColumnHeader2.Text = "Type";
    this.ColumnHeader2.Width = 70;
    this.ColumnHeader3.Text = "Date Added";
    this.ColumnHeader3.Width = 94;
    this.ColumnHeader4.Text = "Description";
    this.ColumnHeader4.Width = 112 /*0x70*/;
    this.ColumnHeader5.Text = "Size";
    this.ColumnHeader5.Width = 67;
    ((Control) this._DocumentPanel_Toolbars_Dock_Area_Left).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._DocumentPanel_Toolbars_Dock_Area_Left).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._DocumentPanel_Toolbars_Dock_Area_Left.DockedPosition = (DockedPosition) 2;
    ((Control) this._DocumentPanel_Toolbars_Dock_Area_Left).ForeColor = SystemColors.ControlText;
    ((Control) this._DocumentPanel_Toolbars_Dock_Area_Left).Location = new Point(0, 26);
    ((Control) this._DocumentPanel_Toolbars_Dock_Area_Left).Name = "_DocumentPanel_Toolbars_Dock_Area_Left";
    ((Control) this._DocumentPanel_Toolbars_Dock_Area_Left).Size = new Size(0, 294);
    this._DocumentPanel_Toolbars_Dock_Area_Left.ToolbarsManager = this.UltraToolbarsManager1;
    this.UltraToolbarsManager1.DesignerFlags = 1;
    this.UltraToolbarsManager1.DockWithinContainer = (Control) this;
    this.UltraToolbarsManager1.ImageTransparentColor = Color.Magenta;
    this.UltraToolbarsManager1.ShowFullMenusDelay = 500;
    this.UltraToolbarsManager1.Style = (ToolbarStyle) 5;
    ultraToolbar.DockedColumn = 0;
    ultraToolbar.DockedRow = 0;
    ((UltraToolbarBase) ultraToolbar).NonInheritedTools.AddRange(new ToolBase[7]
    {
      (ToolBase) buttonTool1,
      (ToolBase) buttonTool2,
      (ToolBase) buttonTool3,
      (ToolBase) buttonTool4,
      (ToolBase) buttonTool5,
      (ToolBase) buttonTool6,
      (ToolBase) labelTool1
    });
    ultraToolbar.Settings.AllowCustomize = (DefaultableBoolean) 2;
    ultraToolbar.Settings.FillEntireRow = (DefaultableBoolean) 1;
    ultraToolbar.Settings.GrabHandleStyle = (GrabHandleStyle) 1;
    ultraToolbar.Text = "UltraToolbar1";
    this.UltraToolbarsManager1.Toolbars.AddRange(new UltraToolbar[1]
    {
      ultraToolbar
    });
    appearance1.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance1.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool7).SharedProps).AppearancesSmall.Appearance = (AppearanceBase) appearance1;
    ((ToolPropsBase) ((ToolBase) buttonTool7).SharedProps).Caption = "Open Existing";
    appearance2.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance2.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool8).SharedProps).AppearancesSmall.Appearance = (AppearanceBase) appearance2;
    ((ToolPropsBase) ((ToolBase) buttonTool8).SharedProps).Caption = "Refresh";
    ((AppearanceBase) appearance3).TextHAlignAsString = "Right";
    ((ToolPropsBase) ((ToolBase) labelTool2).SharedProps).AppearancesLarge.AppearanceOnToolbar = (AppearanceBase) appearance3;
    ((AppearanceBase) appearance4).TextHAlignAsString = "Right";
    ((ToolPropsBase) ((ToolBase) labelTool2).SharedProps).AppearancesSmall.Appearance = (AppearanceBase) appearance4;
    ((AppearanceBase) appearance5).TextHAlignAsString = "Right";
    ((ToolPropsBase) ((ToolBase) labelTool2).SharedProps).AppearancesSmall.AppearanceOnToolbar = (AppearanceBase) appearance5;
    ((ToolPropsBase) ((ToolBase) labelTool2).SharedProps).Caption = "Files associated with this note";
    ((ToolBase) labelTool2).SharedProps.Spring = true;
    appearance6.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance6.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool9).SharedProps).AppearancesSmall.Appearance = (AppearanceBase) appearance6;
    ((ToolPropsBase) ((ToolBase) buttonTool9).SharedProps).Caption = "View Doc";
    appearance7.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance7.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool10).SharedProps).AppearancesSmall.Appearance = (AppearanceBase) appearance7;
    ((ToolPropsBase) ((ToolBase) buttonTool10).SharedProps).Caption = "Remove Binding";
    appearance8.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance8.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool11).SharedProps).AppearancesSmall.Appearance = (AppearanceBase) appearance8;
    ((ToolPropsBase) ((ToolBase) buttonTool11).SharedProps).Caption = "Print Doc";
    appearance9.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance9.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool12).SharedProps).AppearancesSmall.Appearance = (AppearanceBase) appearance9;
    ((ToolPropsBase) ((ToolBase) buttonTool12).SharedProps).Caption = "View Props";
    this.UltraToolbarsManager1.Tools.AddRange(new ToolBase[7]
    {
      (ToolBase) buttonTool7,
      (ToolBase) buttonTool8,
      (ToolBase) labelTool2,
      (ToolBase) buttonTool9,
      (ToolBase) buttonTool10,
      (ToolBase) buttonTool11,
      (ToolBase) buttonTool12
    });
    ((Control) this._DocumentPanel_Toolbars_Dock_Area_Right).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._DocumentPanel_Toolbars_Dock_Area_Right).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._DocumentPanel_Toolbars_Dock_Area_Right.DockedPosition = (DockedPosition) 3;
    ((Control) this._DocumentPanel_Toolbars_Dock_Area_Right).ForeColor = SystemColors.ControlText;
    ((Control) this._DocumentPanel_Toolbars_Dock_Area_Right).Location = new Point(560, 26);
    ((Control) this._DocumentPanel_Toolbars_Dock_Area_Right).Name = "_DocumentPanel_Toolbars_Dock_Area_Right";
    ((Control) this._DocumentPanel_Toolbars_Dock_Area_Right).Size = new Size(0, 294);
    this._DocumentPanel_Toolbars_Dock_Area_Right.ToolbarsManager = this.UltraToolbarsManager1;
    ((Control) this._DocumentPanel_Toolbars_Dock_Area_Top).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._DocumentPanel_Toolbars_Dock_Area_Top).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._DocumentPanel_Toolbars_Dock_Area_Top.DockedPosition = (DockedPosition) 0;
    ((Control) this._DocumentPanel_Toolbars_Dock_Area_Top).ForeColor = SystemColors.ControlText;
    ((Control) this._DocumentPanel_Toolbars_Dock_Area_Top).Location = new Point(0, 0);
    ((Control) this._DocumentPanel_Toolbars_Dock_Area_Top).Name = "_DocumentPanel_Toolbars_Dock_Area_Top";
    ((Control) this._DocumentPanel_Toolbars_Dock_Area_Top).Size = new Size(560, 26);
    this._DocumentPanel_Toolbars_Dock_Area_Top.ToolbarsManager = this.UltraToolbarsManager1;
    ((Control) this._DocumentPanel_Toolbars_Dock_Area_Bottom).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._DocumentPanel_Toolbars_Dock_Area_Bottom).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._DocumentPanel_Toolbars_Dock_Area_Bottom.DockedPosition = (DockedPosition) 1;
    ((Control) this._DocumentPanel_Toolbars_Dock_Area_Bottom).ForeColor = SystemColors.ControlText;
    ((Control) this._DocumentPanel_Toolbars_Dock_Area_Bottom).Location = new Point(0, 320);
    ((Control) this._DocumentPanel_Toolbars_Dock_Area_Bottom).Name = "_DocumentPanel_Toolbars_Dock_Area_Bottom";
    ((Control) this._DocumentPanel_Toolbars_Dock_Area_Bottom).Size = new Size(560, 0);
    this._DocumentPanel_Toolbars_Dock_Area_Bottom.ToolbarsManager = this.UltraToolbarsManager1;
    this.DragDropExtender1.DropTarget = (Control) this.lstDocs;
    this.Controls.Add((Control) this.DocumentPanel_Fill_Panel);
    this.Controls.Add((Control) this._DocumentPanel_Toolbars_Dock_Area_Left);
    this.Controls.Add((Control) this._DocumentPanel_Toolbars_Dock_Area_Right);
    this.Controls.Add((Control) this._DocumentPanel_Toolbars_Dock_Area_Top);
    this.Controls.Add((Control) this._DocumentPanel_Toolbars_Dock_Area_Bottom);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Name = nameof (DocumentPanel);
    this.Size = new Size(560, 320);
    this.DocumentPanel_Fill_Panel.ResumeLayout(false);
    ((ISupportInitialize) this.UltraToolbarsManager1).EndInit();
    this.ResumeLayout(false);
  }

  [SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
  public event QueryEntityHandler QueryEntity;

  [SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
  public event DocumentAddedHandler DocumentAdded;

  protected virtual void OnDocumentAdded(DocumentAddedEventArgs e)
  {
    // ISSUE: reference to a compiler-generated field
    DocumentAddedHandler documentAddedEvent = this.DocumentAddedEvent;
    if (documentAddedEvent == null)
      return;
    documentAddedEvent((object) this, e);
  }

  protected virtual void OnQueryEntity(QueryEntityEventArgs e)
  {
    // ISSUE: reference to a compiler-generated field
    QueryEntityHandler queryEntityEvent = this.QueryEntityEvent;
    if (queryEntityEvent == null)
      return;
    queryEntityEvent((object) this, e);
  }

  public Guid NoteGuid
  {
    get => this._noteGuid;
    set => this._noteGuid = value;
  }

  internal Guid EntityGUID
  {
    get
    {
      QueryEntityEventArgs e = new QueryEntityEventArgs();
      this.OnQueryEntity(e);
      return e.EntityGUID;
    }
  }

  private void DocumentPanel_Load(object sender, EventArgs e)
  {
    this.lstDocs.Dock = DockStyle.Fill;
    if (this.DesignMode)
      return;
    this._docListInitializer = new DocumentPanel.DocumentImageListInitializer(this.imgSmall, this.imgLarge, this.lstDocs);
    this.RefreshView();
    DocumentManager.EntityDocumentCollectionChanged += new EventHandler(this.DocumentSystem_EntityCollectionModified);
    DocumentManager.DocumentBound += new DocumentManager.DocumentBoundEventHandler(this.DocumentSystem_DocumentBound);
  }

  private void DocumentSystem_EntityCollectionModified(object sender, EventArgs e)
  {
    if (MDIControls.Instance.MDIParent.InvokeRequired)
    {
      MDIControls.Instance.MDIParent.BetterInvoke((Delegate) new DocumentPanel.DocumentSystem_EntityCollectionModifiedHandler(this.DocumentSystem_EntityCollectionModified), sender, (object) e);
    }
    else
    {
      if (this.FindForm() != MDIControls.Instance.MDIParent.ActiveMdiChild)
        return;
      this.RefreshView();
    }
  }

  private void DocumentSystem_DocumentBound(object sender, DocumentManager.DocumentBoundEventArgs e)
  {
    if (this._inDocumentBound)
      return;
    if (MDIControls.Instance.MDIParent.InvokeRequired)
    {
      MDIControls.Instance.MDIParent.BetterInvoke((Delegate) new DocumentPanel.DocumentSystemDocumentBoundHandler(this.DocumentSystem_DocumentBound), sender, (object) e);
    }
    else
    {
      this._inDocumentBound = true;
      if (this.FindForm() == MDIControls.Instance.MDIParent.ActiveMdiChild && e.EntityGUID.Equals(this.EntityGUID))
        this.OnDocumentAdded(new DocumentAddedEventArgs(e.DocumentGuid));
      this._inDocumentBound = false;
    }
  }

  public void RefreshView()
  {
    Database.Instance.QueryMultithreadedSP.PerformTableQuery(ThreadPriority.BelowNormal, new TableQueryMultithreadEventHandler(this.DocumentTable_Filled), (Control) this, (object) "DocumentView", "dbo.NoteForm_RefreshView", (object) "@AssociatedEntityGUID", (object) this.EntityGUID);
  }

  private void DocumentTable_Filled(object sender, TableQueryMultithreadEventArgs e)
  {
    this.lstDocs.Clear();
    try
    {
      foreach (DataRow row in e.Table.Rows)
        this._docListInitializer.AddItem(Database.IsNull(RuntimeHelpers.GetObjectValue(row["FileName"]), "Unknown"), Database.IsNull(RuntimeHelpers.GetObjectValue(row["OriginalFileSize"]), 0), (Guid) row["DocumentStoreGUID"], Database.IsNull(RuntimeHelpers.GetObjectValue(row["Description"]), "Unknown"), Conversions.ToString(row["FileAssociation"]), Database.IsNull(RuntimeHelpers.GetObjectValue(row["DateAdded"]), DateAndTime.Now));
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    DataTable dataTable = Database.Instance.QuerySP.PerformTableQuery("NoteForm_GetAssociatedDocuments", (object) "@NoteGuid", (object) this._noteGuid);
    try
    {
      foreach (DataRow row in dataTable.Rows)
      {
        if (e.Table.Select($"DocumentStoreGUID = '{((Guid) row["DocumentStoreGUID"]).ToString()}'").Length == 0)
          this._docListInitializer.AddItem(Database.IsNull(RuntimeHelpers.GetObjectValue(row["FileName"]), "Unknown"), Database.IsNull(RuntimeHelpers.GetObjectValue(row["OriginalFileSize"]), 0), (Guid) row["DocumentStoreGUID"], Database.IsNull(RuntimeHelpers.GetObjectValue(row["Description"]), "Unknown"), Conversions.ToString(row["FileAssociation"]), Database.IsNull(RuntimeHelpers.GetObjectValue(row["DateAdded"]), DateAndTime.Now));
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void UltraToolbarsManager1_ToolClick(object sender, ToolClickEventArgs e)
  {
    string key = ((ToolEventArgs) e).Tool.Key;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Open Existing", false) != 0)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Refresh", false) != 0)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "View Doc", false) != 0)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Remove Binding", false) != 0)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Print Doc", false) != 0)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "View Props", false) != 0)
                return;
              this.ViewProperties();
            }
            else
              this.PrintDoc();
          }
          else
            this.RemoveDoc();
        }
        else
          this.OpenDoc();
      }
      else
        this.RefreshView();
    }
    else
      this.AddExistingDoc();
  }

  private void mnuDetails_Click(object sender, EventArgs e) => this.lstDocs.View = View.Details;

  private void mnuLargeIcons_Click(object sender, EventArgs e)
  {
    this.lstDocs.View = View.LargeIcon;
  }

  private void mnuSmallIcons_Click(object sender, EventArgs e)
  {
    this.lstDocs.View = View.SmallIcon;
  }

  private void mnuList_Click(object sender, EventArgs e) => this.lstDocs.View = View.List;

  private void mnuProperties_Click(object sender, EventArgs e) => this.ViewProperties();

  private void mnuPrint_Click(object sender, EventArgs e) => this.PrintDoc();

  private void mnuOpen_Click(object sender, EventArgs e) => this.OpenDoc();

  private void mnuRemove_Click(object sender, EventArgs e) => this.RemoveDoc();

  private void RemoveDoc()
  {
    if (this.lstDocs.SelectedItems.Count <= 0)
      return;
    ListViewItem selectedItem = this.lstDocs.SelectedItems[0];
    if (selectedItem == null)
      return;
    Guid tag = (Guid) selectedItem.Tag;
    DocumentManager.BeginUnbindDocument(tag, this.EntityGUID);
    Database.Instance.QueryText.PerformNonQuery("delete      from          tblNotesDocuments      where          NoteGuid = @NoteGuid and          DocumentStoreGuid = @DocumentStoreGuid ", (object) "@DocumentStoreGuid", (object) tag, (object) "@NoteGuid", (object) this.NoteGuid);
    this.RefreshView();
  }

  private void DocumentAddedAndBound(Guid docGUID)
  {
    INoteForm form = (INoteForm) this.FindForm();
    if (form == null || form.NoteSupportCache == null || docGUID.Equals(Guid.Empty))
      return;
    DocumentManager.BeginBindDocument(docGUID, form.DocumentSupportCache);
  }

  private void AddExistingDocs(string[] fileNames)
  {
    Form form = this.FindForm();
    ISupportDocumentSystem supportDocumentSystem = form as ISupportDocumentSystem;
    ISupportDocumentPanel supportDocumentPanel1 = form as ISupportDocumentPanel;
    INoteForm noteForm = form as INoteForm;
    if (supportDocumentSystem == null || noteForm == null && !supportDocumentSystem.AllowAddNewDocument)
      return;
    string[] strArray = fileNames;
    int index = 0;
    while (index < strArray.Length)
    {
      string path = strArray[index];
      if (supportDocumentPanel1 != null)
      {
        ISupportDocumentPanel supportDocumentPanel2 = supportDocumentPanel1;
        DocSupportCache docSupport = new DocSupportCache(true, true, supportDocumentPanel2.EntityGuid, supportDocumentPanel2.EntityName, supportDocumentPanel2.FriendlyEntityName, supportDocumentPanel2.RecreateTypeName, false, Guid.Empty);
        DocumentManager.BeginFileAddWithBind(new DocumentManager.FileAddedAndBound(this.DocumentAddedAndBound), path, -1, string.Empty, (ISupportDocumentSystem) docSupport);
      }
      checked { ++index; }
    }
  }

  private void AddExistingDoc()
  {
    Form form = this.FindForm();
    ISupportDocumentSystem supportDocumentSystem = form as ISupportDocumentSystem;
    INoteForm noteForm = form as INoteForm;
    if (supportDocumentSystem == null || noteForm == null && !supportDocumentSystem.AllowAddNewDocument)
      return;
    OpenFileDialog openFileDialog1 = this.OpenFileDialog1;
    openFileDialog1.CheckFileExists = true;
    openFileDialog1.CheckPathExists = true;
    openFileDialog1.DereferenceLinks = true;
    openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
    openFileDialog1.Multiselect = true;
    openFileDialog1.ReadOnlyChecked = true;
    openFileDialog1.ShowReadOnly = false;
    if (openFileDialog1.ShowDialog((IWin32Window) MDIControls.Instance.MDIParent) != DialogResult.Cancel)
      this.AddExistingDocs(openFileDialog1.FileNames);
  }

  private void PrintDoc()
  {
    if (this.lstDocs.SelectedItems.Count <= 0)
      return;
    ListViewItem selectedItem = this.lstDocs.SelectedItems[0];
    if (selectedItem == null)
      return;
    DocumentManager.BeginPrintDoc((Guid) selectedItem.Tag);
  }

  private void ViewProperties()
  {
    if (this.lstDocs.SelectedItems.Count <= 0)
      return;
    ListViewItem selectedItem = this.lstDocs.SelectedItems[0];
    if (selectedItem == null)
      return;
    using (frmDocumentProperties documentProperties = frmDocumentProperties.Create((Guid) selectedItem.Tag))
    {
      int num = (int) documentProperties.ShowDialog();
    }
    this.RefreshView();
  }

  private void OpenDoc()
  {
    if (this.lstDocs.SelectedItems.Count <= 0)
      return;
    ListViewItem selectedItem = this.lstDocs.SelectedItems[0];
    if (selectedItem == null)
      return;
    DocumentManager.BeginViewDocument((Guid) selectedItem.Tag);
  }

  private void mnuAddExisting_Click(object sender, EventArgs e) => this.AddExistingDoc();

  private void lstDocs_DoubleClick(object sender, EventArgs e) => this.OpenDoc();

  private void DoUploadFile(string filename)
  {
    this.AddExistingDocs(new string[1]{ filename });
  }

  private void lstDocs_DragDrop(object sender, DragEventArgs e)
  {
    if (this.FindForm() is ISupportDocumentSystem form && !form.AllowAddNewDocument)
      return;
    if (e.Data.GetDataPresent(System.Windows.Forms.DataFormats.FileDrop, false))
    {
      string[] data = (string[]) e.Data.GetData(System.Windows.Forms.DataFormats.FileDrop);
      int index = 0;
      while (index < data.Length)
      {
        this.DoUploadFile(data[index]);
        checked { ++index; }
      }
    }
    if (!(e.Data.GetData("ByteData", false) is List<ByteData> data1))
      return;
    try
    {
      TabDocumentPanel.ParseEmailOptionsStorageBegin();
      try
      {
        foreach (ByteData byteData in data1)
        {
          string str = MGATempFolder.MGATempRandomFolderPath + byteData.FileName;
          using (FileStream fileStream = new FileStream(str, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite))
          {
            byte[] bytes = byteData.GetBytes();
            fileStream.Write(bytes, 0, bytes.Length);
          }
          if (str.EndsWith(".msg", true, CultureInfo.InvariantCulture))
          {
            string[] email = TabDocumentPanel.ParseEmail(str);
            int index = 0;
            while (index < email.Length)
            {
              this.DoUploadFile(email[index]);
              checked { ++index; }
            }
          }
          else
            this.DoUploadFile(str);
        }
      }
      finally
      {
        List<ByteData>.Enumerator enumerator;
        enumerator.Dispose();
      }
    }
    finally
    {
      TabDocumentPanel.ParseEmailOptionsStorageComplete();
    }
  }

  private void lstDocs_DragOver(object sender, DragEventArgs e)
  {
    if (this.FindForm() is ISupportDocumentSystem form && !form.AllowAddNewDocument)
      e.Effect = DragDropEffects.None;
    else if (e.Data.GetDataPresent("ByteData", false) || e.Data.GetDataPresent(System.Windows.Forms.DataFormats.FileDrop, false))
      e.Effect = DragDropEffects.All;
    else
      e.Effect = DragDropEffects.None;
  }

  private delegate void DocumentSystem_EntityCollectionModifiedHandler(object sender, EventArgs e);

  private delegate void DocumentSystemDocumentBoundHandler(
    object sender,
    DocumentManager.DocumentBoundEventArgs e);

  private sealed class DocumentImageListInitializer : IDisposable
  {
    private ImageList _imgSmall;
    private ImageList _imgLarge;
    private ListView _listView;
    private Dictionary<string, int> _fileTypeImageIndexHash;

    public DocumentImageListInitializer(ImageList imgSmall, ImageList imgLarge, ListView listview)
    {
      this._imgSmall = (ImageList) null;
      this._imgLarge = (ImageList) null;
      this._listView = (ListView) null;
      this._fileTypeImageIndexHash = new Dictionary<string, int>();
      this._listView = listview;
      this._imgLarge = imgLarge;
      this._imgSmall = imgSmall;
      this._listView.LargeImageList = this._imgLarge;
      this._listView.SmallImageList = this._imgSmall;
    }

    private void VerifyColumns()
    {
      ListView.ColumnHeaderCollection columns = this._listView.Columns;
      if (columns.Count == 0)
      {
        columns.Add("File Name", 160 /*0xA0*/, HorizontalAlignment.Center);
        columns.Add("Type", 70, HorizontalAlignment.Center);
        columns.Add("Date Added", 94, HorizontalAlignment.Center);
        columns.Add("Description", 120, HorizontalAlignment.Center);
        columns.Add("Size", 60, HorizontalAlignment.Center);
      }
    }

    public void AddItem(
      string fileName,
      int size,
      Guid documentGuid,
      string description,
      string fileAssociation,
      DateTime dateadded)
    {
      this.VerifyColumns();
      string key = fileName.IndexOf(".") != -1 ? fileName.Substring(fileName.LastIndexOf(".")) : ".xxx";
      int num1 = -1;
      int imageIndex;
      if (this._fileTypeImageIndexHash.ContainsKey(key))
      {
        imageIndex = this._fileTypeImageIndexHash[key];
      }
      else
      {
        try
        {
          this._fileTypeImageIndexHash.Add(key, num1);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          Exception innerException = ex;
          if (this._listView.InvokeRequired)
            throw new InvalidOperationException("We should never be invoked from a thread.", innerException);
          throw;
        }
        this._imgSmall.Images.Add(FileInfoEx.GetSmallIcon("test" + key));
        this._imgLarge.Images.Add(FileInfoEx.GetLargeIcon("test" + key));
        imageIndex = this._imgLarge.Images.Count - 1;
      }
      ListViewItem listViewItem = new ListViewItem(fileName, imageIndex);
      listViewItem.Tag = (object) documentGuid;
      listViewItem.SubItems.Add(fileAssociation);
      listViewItem.SubItems.Add(dateadded.ToShortDateString());
      listViewItem.SubItems.Add(description);
      long num2 = (long) Math.Round((double) size / 1024.0);
      if (num2 == 0L)
        ++num2;
      listViewItem.SubItems.Add($"{num2} KB");
      this._listView.Items.Add(listViewItem);
    }

    public void Dispose()
    {
      this._imgSmall = (ImageList) null;
      this._imgLarge = (ImageList) null;
      this._listView = (ListView) null;
      this._fileTypeImageIndexHash = (Dictionary<string, int>) null;
    }
  }
}
