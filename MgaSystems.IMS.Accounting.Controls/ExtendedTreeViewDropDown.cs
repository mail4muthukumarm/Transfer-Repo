// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Controls.ExtendedTreeViewDropDown
// Assembly: MgaSystems.IMS.Accounting.Controls, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 69E8E7CF-F3E0-45A9-94CD-B8A0D33430C8
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Accounting.Controls.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinTree;
using MGASystems.Common;
using MGASystems.Tools;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Controls;

public class ExtendedTreeViewDropDown : UserControl
{
  private IContainer components;
  private int m_dropDownWidth;
  private int m_dropDownHeight;
  private string m_value;
  private ContextMenu m_ContextMenu;
  private string m_parentNodeKey;
  private string m_parentNodeText;
  private string m_parentNodeTag;
  private bool m_UseCheckedState;
  private string m_SelectedNodeText;
  private bool NodeFound;
  private SqlCommand cmd;
  protected UltraTree DropTree;
  private int GLCompanyID;
  private ExtendedTreeViewDropDown.Assets _showAR;
  private ExtendedTreeViewDropDown.Liabilities _showAP;
  private bool _showExpense;
  private bool _showEquity;
  private bool _showIncome;
  private bool _UseShortNamesCollectionLimiter;
  private ArrayList _ShortNamesCollection;
  private bool _ShowSystemDefinedAccounts;
  private bool _MouseOverIsControlAccount;
  private int _MouseOverControlGLAcctID;
  private string _MouseOverControlGLAcctName;
  private string _MouseOverControlGLAcctShortName;

  public ExtendedTreeViewDropDown()
  {
    this.Load += new EventHandler(this.ExtendedTreeViewDropDown_Load);
    this.KeyDown += new KeyEventHandler(this.ExtendedTreeViewDropDown_KeyDown);
    this.Enter += new EventHandler(this.ExtendedTreeViewDropDown_Enter);
    this.cmd = new SqlCommand();
    this.DropTree = new UltraTree();
    this.GLCompanyID = -1;
    this._showAR = ExtendedTreeViewDropDown.Assets.None;
    this._showAP = ExtendedTreeViewDropDown.Liabilities.None;
    this._ShortNamesCollection = (ArrayList) null;
    this.InitializeComponent();
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  protected virtual UltraTree TreeView
  {
    get => this._TreeView;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      AfterNodeSelectEventHandler selectEventHandler1 = new AfterNodeSelectEventHandler(this.TreeView_AfterSelect);
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.TreeView_KeyDown);
      EventHandler eventHandler = new EventHandler(this.TreeView_Click);
      BeforeNodeSelectEventHandler selectEventHandler2 = new BeforeNodeSelectEventHandler(this.TreeView_BeforeSelect);
      UltraTree treeView1 = this._TreeView;
      if (treeView1 != null)
      {
        treeView1.AfterSelect -= selectEventHandler1;
        ((Control) treeView1).KeyDown -= keyEventHandler;
        ((Control) treeView1).Click -= eventHandler;
        treeView1.BeforeSelect -= selectEventHandler2;
      }
      this._TreeView = value;
      UltraTree treeView2 = this._TreeView;
      if (treeView2 == null)
        return;
      treeView2.AfterSelect += selectEventHandler1;
      ((Control) treeView2).KeyDown += keyEventHandler;
      ((Control) treeView2).Click += eventHandler;
      treeView2.BeforeSelect += selectEventHandler2;
    }
  }

  protected virtual UltraPopupControlContainer TreeContainer
  {
    get => this._TreeContainer;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.TreeContainer_Opened);
      UltraPopupControlContainer treeContainer1 = this._TreeContainer;
      if (treeContainer1 != null)
        treeContainer1.Opened -= eventHandler;
      this._TreeContainer = value;
      UltraPopupControlContainer treeContainer2 = this._TreeContainer;
      if (treeContainer2 == null)
        return;
      treeContainer2.Opened += eventHandler;
    }
  }

  [field: AccessedThroughProperty("GLAccountImages")]
  protected virtual ImageList GLAccountImages { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual UltraDropDownButton DropDownButton
  {
    get => this._DropDownButton;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      CancelEventHandler cancelEventHandler = new CancelEventHandler(this.DropDownButton_DroppingDown);
      EventHandler eventHandler = new EventHandler(this.DropDownButton_ClosedUp);
      UltraDropDownButton dropDownButton1 = this._DropDownButton;
      if (dropDownButton1 != null)
      {
        dropDownButton1.DroppingDown -= cancelEventHandler;
        dropDownButton1.ClosedUp -= eventHandler;
      }
      this._DropDownButton = value;
      UltraDropDownButton dropDownButton2 = this._DropDownButton;
      if (dropDownButton2 == null)
        return;
      dropDownButton2.DroppingDown += cancelEventHandler;
      dropDownButton2.ClosedUp += eventHandler;
    }
  }

  protected virtual MGATextBox Display
  {
    get => this._Display;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.Display_KeyDown);
      EventHandler eventHandler = new EventHandler(this.Display_Leave);
      MGATextBox display1 = this._Display;
      if (display1 != null)
      {
        ((Control) display1).KeyDown -= keyEventHandler;
        ((Control) display1).Leave -= eventHandler;
      }
      this._Display = value;
      MGATextBox display2 = this._Display;
      if (display2 == null)
        return;
      ((Control) display2).KeyDown += keyEventHandler;
      ((Control) display2).Leave += eventHandler;
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    Appearance appearance1 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (ExtendedTreeViewDropDown));
    Appearance appearance2 = new Appearance();
    this.TreeContainer = new UltraPopupControlContainer(this.components);
    this.TreeView = new UltraTree();
    this.DropDownButton = new UltraDropDownButton();
    this.GLAccountImages = new ImageList(this.components);
    this.Display = new MGATextBox();
    ((ISupportInitialize) this.TreeView).BeginInit();
    ((ISupportInitialize) this.Display).BeginInit();
    this.SuspendLayout();
    this.TreeContainer.PopupControl = (Control) this.TreeView;
    ((Control) this.TreeView).Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.TreeView).Location = new Point(40, 64 /*0x40*/);
    ((Control) this.TreeView).Name = "TreeView";
    ((Control) this.TreeView).Size = new Size(121, 97);
    ((Control) this.TreeView).TabIndex = 4;
    ((Control) this.TreeView).Visible = false;
    ((Control) this.DropDownButton).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    appearance1.BackColor = Color.LightSteelBlue;
    appearance1.BackColor2 = Color.LightSteelBlue;
    appearance1.BackGradientStyle = (GradientStyle) 2;
    appearance1.BorderAlpha = (Alpha) 2;
    appearance1.BorderColor = SystemColors.Highlight;
    ((ControlBase) this.DropDownButton).Appearance = (AppearanceBase) appearance1;
    ((ControlBase) this.DropDownButton).BackColorInternal = Color.Transparent;
    ((UltraButtonBase) this.DropDownButton).ButtonStyle = (UIElementButtonStyle) 12;
    ((Control) this.DropDownButton).Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.DropDownButton).Location = new Point(0, 0);
    ((Control) this.DropDownButton).Name = "DropDownButton";
    this.DropDownButton.PopupItemKey = "TreeView";
    this.DropDownButton.PopupItemProvider = (IPopupItemProvider) this.TreeContainer;
    ((UltraButtonBase) this.DropDownButton).ShowFocusRect = false;
    ((UltraButtonBase) this.DropDownButton).ShowOutline = false;
    ((Control) this.DropDownButton).Size = new Size(208 /*0xD0*/, 20);
    this.DropDownButton.Style = (SplitButtonDisplayStyle) 1;
    ((Control) this.DropDownButton).TabIndex = 3;
    ((UltraControlBase) this.DropDownButton).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.DropDownButton).UseOsThemes = (DefaultableBoolean) 2;
    this.GLAccountImages.ImageStream = (ImageListStreamer) componentResourceManager.GetObject("GLAccountImages.ImageStream");
    this.GLAccountImages.TransparentColor = Color.Transparent;
    this.GLAccountImages.Images.SetKeyName(0, "");
    this.GLAccountImages.Images.SetKeyName(1, "");
    this.GLAccountImages.Images.SetKeyName(2, "");
    ((Control) this.Display).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    appearance2.BackColor = Color.White;
    appearance2.BorderColor = Color.Gray;
    appearance2.ForeColor = Color.Black;
    ((TextEditorControlBase) this.Display).Appearance = (AppearanceBase) appearance2;
    ((TextEditorControlBase) this.Display).BackColor = Color.White;
    ((TextEditorControlBase) this.Display).BorderStyle = (UIElementBorderStyle) 1;
    ((Control) this.Display).Location = new Point(1, 1);
    ((Control) this.Display).Name = "Display";
    ((Control) this.Display).Size = new Size(189, 18);
    ((Control) this.Display).TabIndex = 6;
    ((UltraControlBase) this.Display).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.Display).UseOsThemes = (DefaultableBoolean) 2;
    this.Controls.Add((Control) this.Display);
    this.Controls.Add((Control) this.DropDownButton);
    this.Controls.Add((Control) this.TreeView);
    this.Font = new Font("Tahoma", 8f);
    this.Name = nameof (ExtendedTreeViewDropDown);
    this.Size = new Size(208 /*0xD0*/, 20);
    ((ISupportInitialize) this.TreeView).EndInit();
    ((ISupportInitialize) this.Display).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  public event ExtendedTreeViewDropDown.AfterSelectDelegate AfterSelect;

  public event ExtendedTreeViewDropDown.CloseUpEventDelegate CloseUp;

  [Browsable(true)]
  [DefaultValue(200)]
  [Description("Set the drop down width of the control")]
  public virtual int DropDownWidth
  {
    get => this.m_dropDownWidth;
    set => this.m_dropDownWidth = value;
  }

  [Browsable(true)]
  [DefaultValue(200)]
  [Description("Set the drop down height of the control")]
  public virtual int DropDownHeight
  {
    get => this.m_dropDownHeight;
    set => this.m_dropDownHeight = value;
  }

  [Description("Sets the tree view to be displayed in the drop down area.")]
  public UltraTree EmbeddedTreeView
  {
    get => this.TreeView;
    set
    {
      this.TreeView = value;
      ((Control) this.TreeView).Height = 200;
      ((Control) this.TreeView).Width = 250;
      this.DropDownWidth = 0;
      this.TreeView.Override.SelectionType = (SelectType) 1;
      ((Control) this.TreeView).ContextMenu = this.m_ContextMenu;
      this.TreeView.Override.HotTracking = (DefaultableBoolean) 1;
      ((UltraControlBase) this._TreeView).MouseEnterElement += new UIElementEventHandler(this.MouseEnterTreeElement);
    }
  }

  [Browsable(false)]
  [DefaultValue("-1")]
  public string Value => this.m_value;

  public override ContextMenu ContextMenu
  {
    get => this.m_ContextMenu;
    set
    {
      this.m_ContextMenu = value;
      ((Control) this.TreeView).ContextMenu = this.m_ContextMenu;
      ((Control) this.Display).ContextMenu = this.m_ContextMenu;
    }
  }

  [Browsable(false)]
  public bool IsDroppedDown => this.DropDownButton.IsDroppedDown;

  [Browsable(false)]
  [DefaultValue("")]
  public string ParentNodeKey => this.m_parentNodeKey;

  [Browsable(false)]
  [DefaultValue("")]
  public string ParentNodeText => this.m_parentNodeText;

  [Browsable(false)]
  public new string Text => ((TextEditorControlBase) this.Display).Text;

  [Browsable(false)]
  public int SelectedNodesCount
  {
    get => ((DisposableObjectCollectionBase) this.TreeView.SelectedNodes).Count;
  }

  [Browsable(false)]
  [DefaultValue(typeof (bool), "False")]
  public bool GLAccountSelected
  {
    get
    {
      return ((DisposableObjectCollectionBase) this.DropTree.SelectedNodes).Count != 0 && ((GLTreeNode) this.DropTree.SelectedNodes[0]).GLAccountID != -1;
    }
  }

  public bool UseCheckedStateSelectionOverride
  {
    get => this.m_UseCheckedState;
    set => this.m_UseCheckedState = value;
  }

  [Browsable(true)]
  [DefaultValue(typeof (ExtendedTreeViewDropDown.Assets), "None")]
  [Description("Gets/Sets whether the drop tree will show accounts payable accounts")]
  public virtual ExtendedTreeViewDropDown.Assets ShowAssetAccounts
  {
    get => this._showAR;
    set => this._showAR = value;
  }

  [Browsable(true)]
  [DefaultValue(typeof (ExtendedTreeViewDropDown.Liabilities), "None")]
  [Description("Gets/Sets whether the drop tree will show accounts receivable accounts")]
  public virtual ExtendedTreeViewDropDown.Liabilities ShowLiabilityAccounts
  {
    get => this._showAP;
    set => this._showAP = value;
  }

  [Browsable(true)]
  [DefaultValue(false)]
  [Description("Gets/Sets whether the drop tree will show expense accounts")]
  public virtual bool ShowExpenseAccounts
  {
    get => this._showExpense;
    set => this._showExpense = value;
  }

  [Browsable(true)]
  [DefaultValue(false)]
  [Description("Gets/Sets whether the drop tree will show equity accounts")]
  public virtual bool ShowEquityAccounts
  {
    get => this._showEquity;
    set => this._showEquity = value;
  }

  [Browsable(true)]
  [DefaultValue(false)]
  [Description("Gets/Sets whether the drop tree will show income accounts")]
  public virtual bool ShowIncomeAccounts
  {
    get => this._showIncome;
    set => this._showIncome = value;
  }

  [Browsable(true)]
  [DefaultValue(false)]
  [Description("Setting this to true will cause the control to show only gl accounts whose shorts names are listed in the ShortNamesCollection.")]
  public bool UseShortNamesCollectionLimiter
  {
    get => this._UseShortNamesCollectionLimiter;
    set => this._UseShortNamesCollectionLimiter = value;
  }

  [Browsable(true)]
  [Description("This represents the collection of GL Account shortnames to use as a limiter. This can only be used when the UseShortNamesCollectionLimiter = True.")]
  [Editor("System.Windows.Forms.Design.StringCollectionEditor,System.Design", "System.Drawing.Design.UITypeEditor, System.Drawing")]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public ArrayList ShortNamesCollection
  {
    get
    {
      if (this._ShortNamesCollection == null)
        this._ShortNamesCollection = new ArrayList();
      return this._ShortNamesCollection;
    }
  }

  private void ResetShortNamesCollection()
  {
    this._ShortNamesCollection.Clear();
    this._ShortNamesCollection = (ArrayList) null;
  }

  private bool ShouldSerializeShortNamesCollection()
  {
    return this._ShortNamesCollection != null && this._ShortNamesCollection.Count > 0;
  }

  [Browsable(true)]
  [Description("This will determine whether system defined accounts are shown to the user.")]
  [DefaultValue(false)]
  public virtual bool ShowSystemDefinedAccounts
  {
    get => this._ShowSystemDefinedAccounts;
    set => this._ShowSystemDefinedAccounts = value;
  }

  [Browsable(false)]
  [DefaultValue("")]
  private string GLAccountFullName
  {
    get
    {
      return this.DropTree.SelectedNodes[0] == null || ((GLTreeNode) this.DropTree.SelectedNodes[0]).IsControlNode ? "" : ((GLTreeNode) this.DropTree.SelectedNodes[0]).GLAccountFullName;
    }
  }

  [Browsable(false)]
  [DefaultValue("")]
  public string GLAccountShortName
  {
    get
    {
      return this.DropTree.SelectedNodes[0] == null || ((GLTreeNode) this.DropTree.SelectedNodes[0]).IsControlNode ? "" : ((GLTreeNode) this.DropTree.SelectedNodes[0]).GLAccountShortName;
    }
  }

  [Browsable(false)]
  [DefaultValue("")]
  public int GLAccountID
  {
    get
    {
      return ((DisposableObjectCollectionBase) this.DropTree.SelectedNodes).Count == 0 || this.DropTree.SelectedNodes[0] == null || ((GLTreeNode) this.DropTree.SelectedNodes[0]).IsControlNode ? -1 : ((GLTreeNode) this.DropTree.SelectedNodes[0]).GLAccountID;
    }
  }

  [Browsable(false)]
  [DefaultValue(0)]
  public int SelectedNodeCount
  {
    get => ((DisposableObjectCollectionBase) this.DropTree.SelectedNodes).Count;
  }

  [Browsable(false)]
  public bool MouseOverIsControlAccount => this._MouseOverIsControlAccount;

  [Browsable(false)]
  public int MouseOverControlGLAcctID => this._MouseOverControlGLAcctID;

  [Browsable(false)]
  public string MouseOverControlGLAcctName => this._MouseOverControlGLAcctName;

  [Browsable(false)]
  public string MouseOverControlGLAcctShortName => this._MouseOverControlGLAcctShortName;

  private void MouseEnterTreeElement(object sender, UIElementEventArgs e)
  {
  }

  private void DropDownButton_DroppingDown(object sender, CancelEventArgs e)
  {
    if (this.TreeContainer.PopupControl == null)
      this.TreeContainer.PopupControl = (Control) this.DropTree;
    ((Control) this.Display).SendToBack();
    // ISSUE: reference to a compiler-generated field
    ExtendedTreeViewDropDown.DroppingDownDelegate droppingDownEvent = this.DroppingDownEvent;
    if (droppingDownEvent == null)
      return;
    droppingDownEvent((object) this);
  }

  private void DropDownButton_ClosedUp(object sender, EventArgs e)
  {
    ((Control) this.Display).BringToFront();
    if (((DisposableObjectCollectionBase) this.DropTree.SelectedNodes).Count == 0)
    {
      ExtendedDropTree_EventArgs e1 = new ExtendedDropTree_EventArgs("0", "0", "", (UltraTreeNode) null);
      // ISSUE: reference to a compiler-generated field
      ExtendedTreeViewDropDown.CloseUpEventDelegate closeUpEvent = this.CloseUpEvent;
      if (closeUpEvent == null)
        return;
      closeUpEvent((object) this, e1);
    }
    else
    {
      if (((GLTreeNode) this.DropTree.SelectedNodes[0]).IsControlNode)
        return;
      ExtendedDropTree_EventArgs e2 = new ExtendedDropTree_EventArgs(((GLTreeNode) this.DropTree.SelectedNodes[0]).GLAccountID.ToString(), ((GLTreeNode) this.DropTree.SelectedNodes[0]).GLAccountID.ToString(), ((GLTreeNode) this.DropTree.SelectedNodes[0]).GLAccountFullName.ToString(), this.DropTree.SelectedNodes[0]);
      // ISSUE: reference to a compiler-generated field
      ExtendedTreeViewDropDown.CloseUpEventDelegate closeUpEvent = this.CloseUpEvent;
      if (closeUpEvent == null)
        return;
      closeUpEvent((object) this, e2);
    }
  }

  private void TreeView_AfterSelect(object sender, SelectEventArgs e)
  {
    if (((DisposableObjectCollectionBase) this.DropTree.SelectedNodes).Count == 0 || this.DropTree.SelectedNodes[0] == null || ((GLTreeNode) this.DropTree.SelectedNodes[0]).IsControlNode)
      return;
    GLTreeNode selectedNode = (GLTreeNode) this.DropTree.SelectedNodes[0];
    // ISSUE: reference to a compiler-generated field
    ExtendedTreeViewDropDown.AfterSelectDelegate afterSelectEvent = this.AfterSelectEvent;
    if (afterSelectEvent == null)
      return;
    afterSelectEvent((object) this, new ExtendedDropTree_EventArgs(selectedNode.GLAccountID.ToString(), selectedNode.Key, selectedNode.Text, (UltraTreeNode) selectedNode));
  }

  public UltraTreeNode SetSelectedNodeByKey(string _NodeKey)
  {
    UltraTreeNode ultraTreeNode;
    if (Information.IsDBNull((object) _NodeKey) || _NodeKey.Equals((object) DBNull.Value) || _NodeKey.Equals(string.Empty))
    {
      ultraTreeNode = (UltraTreeNode) null;
    }
    else
    {
      this.SetSelectedNode(_NodeKey);
      ultraTreeNode = (UltraTreeNode) null;
    }
    return ultraTreeNode;
  }

  public override void ResetText()
  {
    base.ResetText();
    if (((DisposableObjectCollectionBase) this.TreeView.SelectedNodes).Count != 0)
      this.TreeView.SelectedNodes[0].Selected = false;
    if (this.DropTree != null)
      this.DropTree.SelectedNodes.Clear();
    this.TreeView.SelectedNodes.Clear();
    this.TreeView.CollapseAll();
    ((TextEditorControlBase) this.Display).Text = "";
    this.m_parentNodeKey = "";
    this.m_parentNodeText = "";
    this.m_parentNodeTag = "";
    this.m_value = "";
    this.m_SelectedNodeText = "";
    this.DropDownButton.CloseUp();
  }

  public event ExtendedTreeViewDropDown.DroppingDownDelegate DroppingDown;

  private void TreeView_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.DropDownButton.CloseUp();
  }

  private void TreeContainer_Opened(object sender, EventArgs e)
  {
    ((Control) this.TreeView).Focus();
  }

  public void DoDropDown(bool AutomateCloseUp = false)
  {
    if (!this.DropDownButton.IsDroppedDown)
      this.DropDownButton.DropDown();
    if (!AutomateCloseUp)
      return;
    this.DropDownButton.CloseUp();
  }

  public event ExtendedTreeViewDropDown.ContextMenuItemClickedDelegate ContextMenuItemClicked;

  private void ContextMenuItemClicked_Handler(object sender, EventArgs e)
  {
    // ISSUE: reference to a compiler-generated field
    ExtendedTreeViewDropDown.ContextMenuItemClickedDelegate itemClickedEvent = this.ContextMenuItemClickedEvent;
    if (itemClickedEvent == null)
      return;
    itemClickedEvent((object) this, new ContextMenuItemClicked_EventArgs(((MenuItem) sender).Text, this.Name));
  }

  private void ExtendedTreeViewDropDown_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    if (this.ContextMenu != null)
    {
      try
      {
        foreach (MenuItem menuItem in this.ContextMenu.MenuItems)
          menuItem.Click -= new EventHandler(this.ContextMenuItemClicked_Handler);
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      try
      {
        foreach (MenuItem menuItem in this.ContextMenu.MenuItems)
          menuItem.Click += new EventHandler(this.ContextMenuItemClicked_Handler);
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
    if (this.DropTree == null)
      return;
    this.DropTree.AfterSelect += new AfterNodeSelectEventHandler(this.AfterTreeNodeSelected);
    this.DropTree.BeforeExpand += new BeforeNodeChangedEventHandler(this.BeforeTreeNodeExpand);
    ((Control) this.DropTree).Click += new EventHandler(this.TreeClick);
  }

  private void TreeClick(object sender, EventArgs e)
  {
    if (((ControlUIElementBase) ((UltraTree) sender).UIElement).LastElementEntered.GetContext(typeof (UltraTreeNode)) == null || ((GLTreeNode) ((ControlUIElementBase) ((UltraTree) sender).UIElement).LastElementEntered.GetContext(typeof (UltraTreeNode))).IsControlNode || ((DisposableObjectCollectionBase) this.DropTree.SelectedNodes).Count <= 0 || ((GLTreeNode) this.DropTree.SelectedNodes[0]).IsControlNode)
      return;
    ((TextEditorControlBase) this.Display).Text = ((GLTreeNode) this.DropTree.SelectedNodes[0]).GLAccountFullName;
    this.DropDownButton.CloseUp();
  }

  private void AfterTreeNodeSelected(object sender, SelectEventArgs e)
  {
  }

  private void BeforeTreeNodeExpand(object sender, CancelableNodeEventArgs e)
  {
    if (e.TreeNode == null || !((GLTreeNode) e.TreeNode).IsControlNode || ((GLTreeNode) e.TreeNode).GLAccountID == 0)
      return;
    this.Cursor = Cursors.WaitCursor;
    e.TreeNode.Nodes.Clear();
    this.LoadChildAccounts((GLTreeNode) e.TreeNode, ((GLTreeNode) e.TreeNode).GLAccountID);
    this.Cursor = Cursors.Default;
  }

  private void TreeView_Click(object sender, EventArgs e)
  {
    ((ControlUIElementBase) this.DropTree.UIElement).LastElementEntered.GetContext(typeof (UltraTreeNode));
  }

  private void SetDropDownWidth(UltraTreeNode node1)
  {
    if (node1.Parent == null)
    {
      if (node1.TextWidth + 100 > this.DropDownWidth)
        this.DropDownWidth = node1.TextWidth + 100;
    }
    else if (node1.TextWidth + 125 > this.DropDownWidth)
      this.DropDownWidth = node1.TextWidth + 125;
    if (!node1.HasNodes)
      return;
    foreach (UltraTreeNode node in node1.Nodes)
      this.SetDropDownWidth(node);
  }

  private void TreeView_BeforeSelect(object sender, BeforeSelectEventArgs e)
  {
    if (((DisposableObjectCollectionBase) e.NewSelections).Count == 0 || e.NewSelections[0].CheckedState != CheckState.Checked)
      return;
    ((CancelEventArgs) e).Cancel = true;
  }

  private void SetTreeProperties()
  {
    UltraTree dropTree = this.DropTree;
    dropTree.Override.SelectionType = (SelectType) 1;
    dropTree.Override.HotTracking = (DefaultableBoolean) 2;
    ((Control) dropTree).Width = this.DropDownWidth;
    if (this.DropDownHeight < 200)
      this.DropDownHeight = 200;
    ((Control) dropTree).Height = this.DropDownHeight;
    this.DropTree.AfterSelect += new AfterNodeSelectEventHandler(this.TreeView_AfterSelect);
  }

  public void LoadGLAccounts(int GLCompany)
  {
    if (this.DesignMode)
      return;
    this.GLCompanyID = GLCompany;
    this.Cursor = Cursors.WaitCursor;
    this.LoadTreeMasterNodes();
    this.Enabled = this.DropTree.Nodes.Count > 0;
    this.SetTreeProperties();
    this.TreeContainer.PopupControl = (Control) this.DropTree;
    this.Cursor = Cursors.Default;
  }

  private void LoadTreeMasterNodes()
  {
    this.DropTree.Nodes.Clear();
    if (this.UseShortNamesCollectionLimiter)
    {
      this.DropTree.Nodes.Clear();
      GLTreeNode glNode = new GLTreeNode(true);
      glNode.Key = "GL Accounts";
      glNode.Text = "Accounts";
      glNode.LeftImages.Add((object) this.GLAccountImages.Images[0]);
      this.LoadSpecifiedGLAccounts(glNode);
      if (((KeyedSubObjectsCollectionBase) this.DropTree.Nodes).Exists(glNode.Key))
        return;
      this.DropTree.Nodes.Add((UltraTreeNode) glNode);
    }
    else
    {
      switch (this.ShowAssetAccounts)
      {
        case ExtendedTreeViewDropDown.Assets.AR:
          GLTreeNode glTreeNode1 = new GLTreeNode(true);
          glTreeNode1.Text = "Assets";
          glTreeNode1.Key = "AssetsMaster";
          glTreeNode1.LeftImages.Add((object) this.GLAccountImages.Images[0]);
          this.DropTree.Nodes.Add((UltraTreeNode) glTreeNode1);
          GLTreeNode GLNode1 = new GLTreeNode(true);
          GLNode1.Text = "Receivable Accounts";
          GLNode1.Key = "ARMaster";
          GLNode1.LeftImages.Add((object) this.GLAccountImages.Images[1]);
          this.LoadMasterAccounts(GLNode1, "A/R");
          this.DropTree.Nodes[0].Nodes.Add((UltraTreeNode) GLNode1);
          break;
        case ExtendedTreeViewDropDown.Assets.Cash:
          GLTreeNode glTreeNode2 = new GLTreeNode(true);
          glTreeNode2.Text = "Assets";
          glTreeNode2.Key = "AssetsMaster";
          glTreeNode2.LeftImages.Add((object) this.GLAccountImages.Images[0]);
          this.DropTree.Nodes.Add((UltraTreeNode) glTreeNode2);
          GLTreeNode GLNode2 = new GLTreeNode(true);
          GLNode2.Text = "Cash Accounts";
          GLNode2.Key = "CashMaster";
          GLNode2.LeftImages.Add((object) this.GLAccountImages.Images[1]);
          this.LoadMasterAccounts(GLNode2, "Cash");
          this.DropTree.Nodes[0].Nodes.Add((UltraTreeNode) GLNode2);
          break;
        case ExtendedTreeViewDropDown.Assets.All:
          GLTreeNode GLNode3 = new GLTreeNode(true);
          GLNode3.Key = "AssetsMaster";
          GLNode3.Text = "Assets";
          GLNode3.LeftImages.Add((object) this.GLAccountImages.Images[0]);
          this.LoadMasterAccounts(GLNode3, "Assets");
          this.DropTree.Nodes.Add((UltraTreeNode) GLNode3);
          GLTreeNode GLNode4 = new GLTreeNode(true);
          GLNode4.Text = "Receivable Accounts";
          GLNode4.Key = "ARMaster";
          GLNode4.LeftImages.Add((object) this.GLAccountImages.Images[1]);
          this.LoadMasterAccounts(GLNode4, "A/R");
          this.DropTree.Nodes[0].Nodes.Add((UltraTreeNode) GLNode4);
          GLTreeNode GLNode5 = new GLTreeNode(true);
          GLNode5.Text = "Cash Accounts";
          GLNode5.Key = "CashMaster";
          GLNode5.LeftImages.Add((object) this.GLAccountImages.Images[1]);
          this.LoadMasterAccounts(GLNode5, "Cash");
          this.DropTree.Nodes[0].Nodes.Add((UltraTreeNode) GLNode5);
          break;
      }
      switch (this.ShowLiabilityAccounts)
      {
        case ExtendedTreeViewDropDown.Liabilities.AP:
          GLTreeNode glTreeNode3 = new GLTreeNode(true);
          glTreeNode3.Key = "LiabilityMaster";
          glTreeNode3.Text = "Liabilities";
          glTreeNode3.LeftImages.Add((object) this.GLAccountImages.Images[0]);
          this.DropTree.Nodes.Add((UltraTreeNode) glTreeNode3);
          GLTreeNode GLNode6 = new GLTreeNode(true);
          GLNode6.Text = "Payable Accounts";
          GLNode6.Key = "APMaster";
          GLNode6.LeftImages.Add((object) this.GLAccountImages.Images[1]);
          this.LoadMasterAccounts(GLNode6, "A/P");
          this.DropTree.Nodes[this.DropTree.Nodes.Count - 1].Nodes.Add((UltraTreeNode) GLNode6);
          break;
        case ExtendedTreeViewDropDown.Liabilities.SR:
          GLTreeNode glTreeNode4 = new GLTreeNode(true);
          glTreeNode4.Key = "LiabilityMaster";
          glTreeNode4.Text = "Liabilities";
          glTreeNode4.LeftImages.Add((object) this.GLAccountImages.Images[0]);
          this.DropTree.Nodes.Add((UltraTreeNode) glTreeNode4);
          GLTreeNode GLNode7 = new GLTreeNode(true);
          GLNode7.Text = "Un-Accounted Accounts";
          GLNode7.Key = "UnAcctMaster";
          GLNode7.LeftImages.Add((object) this.GLAccountImages.Images[1]);
          this.LoadMasterAccounts(GLNode7, "S/R");
          this.DropTree.Nodes[this.DropTree.Nodes.Count - 1].Nodes.Add((UltraTreeNode) GLNode7);
          break;
        case ExtendedTreeViewDropDown.Liabilities.XF:
          GLTreeNode glTreeNode5 = new GLTreeNode(true);
          glTreeNode5.Key = "LiabilityMaster";
          glTreeNode5.Text = "Liabilities";
          glTreeNode5.LeftImages.Add((object) this.GLAccountImages.Images[0]);
          this.DropTree.Nodes.Add((UltraTreeNode) glTreeNode5);
          GLTreeNode GLNode8 = new GLTreeNode(true);
          GLNode8.Text = "Exchange Accounts";
          GLNode8.Key = "ExchMaster";
          GLNode8.LeftImages.Add((object) this.GLAccountImages.Images[1]);
          this.LoadMasterAccounts(GLNode8, "X/F");
          this.DropTree.Nodes[this.DropTree.Nodes.Count - 1].Nodes.Add((UltraTreeNode) GLNode8);
          break;
        case ExtendedTreeViewDropDown.Liabilities.All:
          GLTreeNode GLNode9 = new GLTreeNode(true);
          GLNode9.Key = "LiabilityMaster";
          GLNode9.Text = "Liabilities";
          GLNode9.LeftImages.Add((object) this.GLAccountImages.Images[0]);
          this.LoadMasterAccounts(GLNode9, "Liabilities");
          this.DropTree.Nodes.Add((UltraTreeNode) GLNode9);
          GLTreeNode GLNode10 = new GLTreeNode(true);
          GLNode10.Text = "Payable Accounts";
          GLNode10.Key = "APMaster";
          GLNode10.LeftImages.Add((object) this.GLAccountImages.Images[1]);
          this.LoadMasterAccounts(GLNode10, "A/P");
          this.DropTree.Nodes[this.DropTree.Nodes.Count - 1].Nodes.Add((UltraTreeNode) GLNode10);
          GLTreeNode GLNode11 = new GLTreeNode(true);
          GLNode11.Text = "Un-Accounted Accounts";
          GLNode11.Key = "UnAcctMaster";
          GLNode11.LeftImages.Add((object) this.GLAccountImages.Images[1]);
          this.LoadMasterAccounts(GLNode11, "S/R");
          this.DropTree.Nodes[this.DropTree.Nodes.Count - 1].Nodes.Add((UltraTreeNode) GLNode11);
          GLTreeNode GLNode12 = new GLTreeNode(true);
          GLNode12.Text = "Exchange Accounts";
          GLNode12.Key = "ExchMaster";
          GLNode12.LeftImages.Add((object) this.GLAccountImages.Images[1]);
          this.LoadMasterAccounts(GLNode12, "X/F");
          this.DropTree.Nodes[this.DropTree.Nodes.Count - 1].Nodes.Add((UltraTreeNode) GLNode12);
          break;
      }
      if (this.ShowEquityAccounts)
      {
        GLTreeNode GLNode13 = new GLTreeNode(true);
        GLNode13.Text = "Equity Accounts";
        GLNode13.Key = "EquityMaster";
        GLNode13.LeftImages.Add((object) this.GLAccountImages.Images[0]);
        this.LoadMasterAccounts(GLNode13, "Equity");
        this.DropTree.Nodes.Add((UltraTreeNode) GLNode13);
      }
      if (this.ShowIncomeAccounts)
      {
        GLTreeNode GLNode14 = new GLTreeNode(true);
        GLNode14.Text = "Income Accounts";
        GLNode14.Key = "IncomeMaster";
        GLNode14.LeftImages.Add((object) this.GLAccountImages.Images[0]);
        this.LoadMasterAccounts(GLNode14, "Income");
        this.DropTree.Nodes.Add((UltraTreeNode) GLNode14);
      }
      if (!this.ShowExpenseAccounts)
        return;
      GLTreeNode GLNode15 = new GLTreeNode(true);
      GLNode15.Text = "Expense Accounts";
      GLNode15.Key = "ExpenseMaster";
      GLNode15.LeftImages.Add((object) this.GLAccountImages.Images[0]);
      this.LoadMasterAccounts(GLNode15, "Expenses");
      this.DropTree.Nodes.Add((UltraTreeNode) GLNode15);
    }
  }

  private void LoadMasterAccounts(GLTreeNode GLNode, string MasterAcctClass)
  {
    GLNode.Nodes.Clear();
    this.cmd = new SqlCommand("spFin_getChildAccounts", new SqlConnection(CurrentUser.Instance.ConnectionString));
    this.cmd.CommandType = CommandType.StoredProcedure;
    try
    {
      this.cmd.Parameters.Clear();
      this.cmd.Parameters.AddWithValue("@searchtype", (object) 0);
      this.cmd.Parameters.AddWithValue("@classtype", (object) MasterAcctClass);
      this.cmd.Parameters.AddWithValue("@glacctid", (object) DBNull.Value);
      this.cmd.Parameters.AddWithValue("@glcompanyid", (object) this.GLCompanyID);
      this.cmd.Parameters.AddWithValue("@showsystem", (object) -(this.ShowSystemDefinedAccounts ? 1 : 0));
      this.cmd.Connection.Open();
      SqlDataReader sqlDataReader = this.cmd.ExecuteReader(CommandBehavior.CloseConnection);
      while (sqlDataReader.Read())
      {
        GLTreeNode glTreeNode = new GLTreeNode(Conversions.ToBoolean(sqlDataReader["controlacct"]));
        if (glTreeNode.IsControlNode)
        {
          glTreeNode.LeftImages.Add((object) this.GLAccountImages.Images[1]);
          glTreeNode.Expanded = false;
          glTreeNode.Nodes.Add("-1" + sqlDataReader["glacctid"].ToString(), "");
        }
        else
          glTreeNode.LeftImages.Add((object) this.GLAccountImages.Images[2]);
        glTreeNode.Key = sqlDataReader["glacctid"].ToString();
        glTreeNode.GLAccountShortName = sqlDataReader["shortname"].ToString();
        glTreeNode.GLAccountFullName = sqlDataReader["fullname"].ToString();
        glTreeNode.GLAccountID = Conversions.ToInteger(sqlDataReader["glacctid"]);
        glTreeNode.GLAccountNumber = sqlDataReader["acctnum"].ToString();
        GLNode.Nodes.Add((UltraTreeNode) glTreeNode);
      }
      sqlDataReader.Close();
    }
    catch (SqlException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      int num = (int) MessageBox.Show("An error has occurred while trying to load the general ledger accounts in to the drop down tree.\r\n\r\n" + ex.Errors[0].Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      ProjectData.ClearProjectError();
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      int num = (int) MessageBox.Show("An error has occurred while trying to load the general ledger accounts in to the drop down tree.\r\n\r\n" + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      ProjectData.ClearProjectError();
    }
    finally
    {
      if (this.cmd.Connection.State != ConnectionState.Closed)
        this.cmd.Connection.Close();
      this.cmd.Connection.Dispose();
      this.cmd.Connection = (SqlConnection) null;
      this.cmd.Dispose();
      this.cmd = (SqlCommand) null;
    }
  }

  private void LoadChildAccounts(GLTreeNode GLNode, int GLAcctID)
  {
    this.cmd = new SqlCommand("spFin_getChildAccounts", new SqlConnection(CurrentUser.Instance.ConnectionString));
    this.cmd.CommandType = CommandType.StoredProcedure;
    try
    {
      this.cmd.Parameters.Clear();
      this.cmd.Parameters.AddWithValue("@searchtype", (object) 1);
      this.cmd.Parameters.AddWithValue("@classtype", (object) DBNull.Value);
      this.cmd.Parameters.AddWithValue("@glacctid", (object) GLAcctID);
      this.cmd.Parameters.AddWithValue("@glcompanyid", (object) this.GLCompanyID);
      this.cmd.Parameters.AddWithValue("@showsystem", (object) -(this.ShowSystemDefinedAccounts ? 1 : 0));
      this.cmd.Connection.Open();
      SqlDataReader sqlDataReader = this.cmd.ExecuteReader(CommandBehavior.CloseConnection);
      while (sqlDataReader.Read())
      {
        GLTreeNode glTreeNode = new GLTreeNode(Conversions.ToBoolean(sqlDataReader["controlacct"]));
        if (glTreeNode.IsControlNode)
        {
          glTreeNode.LeftImages.Add((object) this.GLAccountImages.Images[1]);
          glTreeNode.Expanded = false;
          glTreeNode.Nodes.Add("-1" + sqlDataReader["glacctid"].ToString(), "");
        }
        else
          glTreeNode.LeftImages.Add((object) this.GLAccountImages.Images[2]);
        glTreeNode.Key = sqlDataReader["glacctid"].ToString();
        glTreeNode.GLAccountShortName = sqlDataReader["shortname"].ToString();
        glTreeNode.GLAccountFullName = sqlDataReader["fullname"].ToString();
        glTreeNode.GLAccountID = Conversions.ToInteger(sqlDataReader["glacctid"]);
        glTreeNode.GLAccountNumber = Conversions.ToString(Conversions.ToInteger(sqlDataReader["acctnum"]));
        GLNode.Nodes.Add((UltraTreeNode) glTreeNode);
      }
      sqlDataReader.Close();
    }
    catch (SqlException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      int num = (int) MessageBox.Show("An error has occurred while trying to load the receivable accounts in to the drop down tree.\r\n\r\n" + ex.Errors[0].Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      ProjectData.ClearProjectError();
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      int num = (int) MessageBox.Show("An error has occurred while trying to load the receivable accounts in to the drop down tree.\r\n\r\n" + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      ProjectData.ClearProjectError();
    }
    finally
    {
      if (this.cmd.Connection.State != ConnectionState.Closed)
        this.cmd.Connection.Close();
      this.cmd.Connection.Dispose();
      this.cmd.Connection = (SqlConnection) null;
      this.cmd.Dispose();
      this.cmd = (SqlCommand) null;
    }
  }

  private void SetSelectedNode(string GLAcctID)
  {
    if (((KeyedSubObjectsCollectionBase) this.DropTree.Nodes).Exists(GLAcctID))
    {
      this.DropTree.GetNodeByKey(GLAcctID).Selected = true;
    }
    else
    {
      ArrayList a = new ArrayList();
      int num1 = 0;
      SqlCommand sqlCommand1 = new SqlCommand($"Select dbo.GetGLAccountFullPath({Conversions.ToInteger(GLAcctID)})", new SqlConnection(CurrentUser.Instance.ConnectionString));
      try
      {
        SqlCommand sqlCommand2 = sqlCommand1;
        sqlCommand2.CommandType = CommandType.Text;
        sqlCommand2.Connection.Open();
        string path = Conversions.ToString(sqlCommand1.ExecuteScalar());
        sqlCommand1.Connection.Close();
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(path.Trim(), "", false) != 0)
        {
          this.ParseGLFullPath(path, ref a);
          int index;
          for (; index < a.Count; ++index)
          {
            ++num1;
            if (this.DropTree.GetNodeByKey(Conversions.ToString(a[index])) != null)
            {
              if (((GLTreeNode) this.DropTree.GetNodeByKey(Conversions.ToString(a[index]))).IsControlNode)
              {
                this.DropTree.GetNodeByKey(Conversions.ToString(a[index])).Nodes.Clear();
                this.LoadChildAccounts((GLTreeNode) this.DropTree.GetNodeByKey(Conversions.ToString(a[index])), ((GLTreeNode) this.DropTree.GetNodeByKey(Conversions.ToString(a[index]))).GLAccountID);
              }
              this.DropTree.GetNodeByKey(Conversions.ToString(a[index])).Selected = true;
              if (!((GLTreeNode) this.DropTree.GetNodeByKey(Conversions.ToString(a[index]))).IsControlNode && num1 == a.Count)
              {
                ((TextEditorControlBase) this.Display).Text = ((GLTreeNode) this.DropTree.GetNodeByKey(Conversions.ToString(a[index]))).GLAccountFullName;
                break;
              }
            }
          }
        }
      }
      catch (SqlException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        int num2 = (int) MessageBox.Show("An error has occurred while trying to set the selected node.\r\n\r\n" + ex.Errors[0].Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        ProjectData.ClearProjectError();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num3 = (int) MessageBox.Show("An error has occurred while trying to set the selected node.\r\n\r\n" + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        ProjectData.ClearProjectError();
      }
      finally
      {
        if (sqlCommand1.Connection.State != ConnectionState.Closed)
          sqlCommand1.Connection.Close();
        sqlCommand1.Connection.Dispose();
        sqlCommand1.Connection = (SqlConnection) null;
        sqlCommand1.Dispose();
      }
    }
  }

  private void LoadSpecifiedGLAccounts(GLTreeNode glNode)
  {
    if (this.ShortNamesCollection.Count == 0)
      return;
    glNode.Nodes.Clear();
    this.cmd = new SqlCommand("spFin_getglaccount", new SqlConnection(CurrentUser.Instance.ConnectionString));
    this.cmd.CommandType = CommandType.StoredProcedure;
    try
    {
      int index;
      for (; index < this.ShortNamesCollection.Count; ++index)
      {
        this.cmd.Parameters.Clear();
        this.cmd.Parameters.AddWithValue("@shortname", (object) Conversions.ToString(this.ShortNamesCollection[index]));
        this.cmd.Parameters.AddWithValue("@glcompanyid", (object) this.GLCompanyID);
        this.cmd.Connection.Open();
        SqlDataReader sqlDataReader = this.cmd.ExecuteReader(CommandBehavior.CloseConnection);
        while (sqlDataReader.Read())
        {
          GLTreeNode glTreeNode = new GLTreeNode(Conversions.ToBoolean(sqlDataReader["controlacct"]));
          if (glTreeNode.IsControlNode)
          {
            glTreeNode.LeftImages.Add((object) this.GLAccountImages.Images[1]);
            glTreeNode.Expanded = false;
            glTreeNode.Nodes.Add("-1" + sqlDataReader["glacctid"].ToString(), "");
          }
          else
            glTreeNode.LeftImages.Add((object) this.GLAccountImages.Images[2]);
          glTreeNode.Key = sqlDataReader["glacctid"].ToString();
          glTreeNode.GLAccountShortName = sqlDataReader["shortname"].ToString();
          glTreeNode.GLAccountFullName = sqlDataReader["fullname"].ToString();
          glTreeNode.GLAccountID = Conversions.ToInteger(sqlDataReader["glacctid"]);
          glTreeNode.GLAccountNumber = Conversions.ToString(Conversions.ToInteger(sqlDataReader["acctnum"]));
          glNode.Nodes.Add((UltraTreeNode) glTreeNode);
        }
        sqlDataReader.Close();
      }
    }
    catch (SqlException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      int num = (int) MessageBox.Show("An error has occurred while trying to load the specified GL accounts into the drop down tree.\r\n\r\n" + ex.Errors[0].Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      ProjectData.ClearProjectError();
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      int num = (int) MessageBox.Show("An error has occurred while trying to load the specified GL accounts into the drop down tree.\r\n\r\n" + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      ProjectData.ClearProjectError();
    }
    finally
    {
      if (this.cmd.Connection.State != ConnectionState.Closed)
        this.cmd.Connection.Close();
      this.cmd.Connection.Dispose();
      this.cmd.Connection = (SqlConnection) null;
      this.cmd.Dispose();
      this.cmd = (SqlCommand) null;
    }
  }

  private void ParseGLFullPath(string path, ref ArrayList a)
  {
    try
    {
      a.Clear();
      char ch = '\\';
      int Start = 1;
      while (Start < path.Length)
      {
        string str = Strings.InStr(Start, path, Conversions.ToString(ch)) != 0 ? path.Substring(Start - 1, Strings.InStr(Start, path, Conversions.ToString(ch)) - Start) : path.Substring(Start - 1, path.Length - (Start - 1));
        Start = Strings.InStr(Start, path, Conversions.ToString(ch)) != 0 ? Strings.InStr(Start, path, Conversions.ToString(ch)) + 1 : path.Length;
        a.Add((object) str);
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      int num = (int) MessageBox.Show("An error has occurred while trying to parse the GL Account full path.\r\n\r\n" + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      ProjectData.ClearProjectError();
    }
  }

  private void ExtendedTreeViewDropDown_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.KeyCode)
      return;
    int num = (int) Interaction.MsgBox((object) "delete Pressed");
  }

  private bool GetGLAccountNodeFromAccountNumber(int accountNumber, GLTreeNode glNode)
  {
    bool fromAccountNumber;
    foreach (GLTreeNode node in glNode.Nodes)
    {
      if (node.HasNodes)
        this.GetGLAccountNodeFromAccountNumber(accountNumber, node);
      else if (Conversions.ToDouble(node.GLAccountNumber) == (double) accountNumber)
      {
        this.SetSelectedNode(node.GLAccountID.ToString());
        fromAccountNumber = true;
        goto label_7;
      }
    }
    fromAccountNumber = false;
label_7:
    return fromAccountNumber;
  }

  private void Display_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return && e.KeyCode != Keys.Tab)
      return;
    this.ProcessAccountNumber();
  }

  private void ExtendedTreeViewDropDown_Enter(object sender, EventArgs e)
  {
    ((TextEditorControlBase) this.Display).Focus();
  }

  private void Display_Leave(object sender, EventArgs e) => this.ProcessAccountNumber();

  private void ProcessAccountNumber()
  {
    try
    {
      ((ControlBase) this.DropDownButton).Appearance.BorderColor = Color.Red;
      if (string.IsNullOrEmpty(((TextEditorControlBase) this.Display).Text) || !Versioned.IsNumeric((object) ((TextEditorControlBase) this.Display).Text))
        return;
      this.DropTree.SelectedNodes.Clear();
      int result = 0;
      if (!int.TryParse(((TextEditorControlBase) this.Display).Text, out result))
      {
        ((TextEditorControlBase) this.Display).Text = string.Empty;
      }
      else
      {
        int num = 0;
        while (num < this.DropTree.Nodes.Count && !this.GetGLAccountNodeFromAccountNumber(result, (GLTreeNode) this.DropTree.Nodes[num]))
          ++num;
        if (((DisposableObjectCollectionBase) this.DropTree.SelectedNodes).Count != 0)
          return;
        ((TextEditorControlBase) this.Display).Text = string.Empty;
      }
    }
    finally
    {
      ((ControlBase) this.DropDownButton).Appearance.BorderColor = SystemColors.Highlight;
    }
  }

  [Browsable(false)]
  public delegate void CloseUpEventDelegate(object sender, ExtendedDropTree_EventArgs e);

  [Browsable(false)]
  public delegate void AfterSelectDelegate(object sender, ExtendedDropTree_EventArgs e);

  [Browsable(false)]
  public delegate void DroppingDownDelegate(object sender);

  [Browsable(false)]
  public delegate void ContextMenuItemClickedDelegate(
    object sender,
    ContextMenuItemClicked_EventArgs e);

  [Flags]
  public enum Assets
  {
    None = 0,
    AR = 2,
    Cash = 4,
    All = Cash | AR, // 0x00000006
  }

  [Flags]
  public enum Liabilities
  {
    None = 0,
    AP = 2,
    SR = 4,
    XF = 8,
    All = XF | SR | AP, // 0x0000000E
  }
}
