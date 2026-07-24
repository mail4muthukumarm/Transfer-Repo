// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Forms.Entities.EntityGroups
// Assembly: MgaSystems.IMS.Forms, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FB3F392E-40B6-486F-8F0B-A4A494A546D4
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Forms.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.UltraWinToolbars;
using Infragistics.Win.UltraWinTree;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Forms.Entities;

public class EntityGroups : UserControl
{
  private IContainer components;
  private UltraToolbarsDockArea _EntityGroups_Toolbars_Dock_Area_Left;
  private UltraToolbarsDockArea _EntityGroups_Toolbars_Dock_Area_Right;
  private UltraToolbarsDockArea _EntityGroups_Toolbars_Dock_Area_Top;
  private UltraToolbarsDockArea _EntityGroups_Toolbars_Dock_Area_Bottom;
  private ToolTip ToolTip1;
  private int _officeLocationID;
  private bool _hideUserGroups;

  public EntityGroups()
  {
    this.Load += new EventHandler(this.EntityGroups_Load);
    this._officeLocationID = -1;
    this.InitializeComponent();
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  protected virtual UltraTree treeGroups
  {
    get => this._treeGroups;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      AfterNodeSelectEventHandler selectEventHandler = new AfterNodeSelectEventHandler(this.treeGroups_AfterSelect);
      UIElementEventHandler elementEventHandler = new UIElementEventHandler(this.treeGroups_MouseEnterElement);
      UltraTree treeGroups1 = this._treeGroups;
      if (treeGroups1 != null)
      {
        treeGroups1.AfterSelect -= selectEventHandler;
        ((UltraControlBase) treeGroups1).MouseEnterElement -= elementEventHandler;
      }
      this._treeGroups = value;
      UltraTree treeGroups2 = this._treeGroups;
      if (treeGroups2 == null)
        return;
      treeGroups2.AfterSelect += selectEventHandler;
      ((UltraControlBase) treeGroups2).MouseEnterElement += elementEventHandler;
    }
  }

  private virtual UltraToolbarsManager toolbar
  {
    get => this._toolbar;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      ToolClickEventHandler clickEventHandler = new ToolClickEventHandler(this.toolBar_ToolClick);
      BeforeToolDropdownEventHandler dropdownEventHandler = new BeforeToolDropdownEventHandler(this.toolbar_BeforeToolDropdown);
      UltraToolbarsManager toolbar1 = this._toolbar;
      if (toolbar1 != null)
      {
        toolbar1.ToolClick -= clickEventHandler;
        toolbar1.BeforeToolDropdown -= dropdownEventHandler;
      }
      this._toolbar = value;
      UltraToolbarsManager toolbar2 = this._toolbar;
      if (toolbar2 == null)
        return;
      toolbar2.ToolClick += clickEventHandler;
      toolbar2.BeforeToolDropdown += dropdownEventHandler;
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    UltraTreeNode ultraTreeNode1 = new UltraTreeNode();
    UltraTreeNode ultraTreeNode2 = new UltraTreeNode();
    Override @override = new Override();
    Appearance appearance1 = new Appearance();
    UltraToolbar ultraToolbar = new UltraToolbar("UltraToolbar1");
    ButtonTool buttonTool1 = new ButtonTool("New");
    ButtonTool buttonTool2 = new ButtonTool("Edit");
    ButtonTool buttonTool3 = new ButtonTool("Add");
    ButtonTool buttonTool4 = new ButtonTool("Delete");
    PopupMenuTool popupMenuTool1 = new PopupMenuTool("contextMenu");
    ButtonTool buttonTool5 = new ButtonTool("New");
    Appearance appearance2 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (EntityGroups));
    ButtonTool buttonTool6 = new ButtonTool("Add");
    Appearance appearance3 = new Appearance();
    ButtonTool buttonTool7 = new ButtonTool("Edit");
    Appearance appearance4 = new Appearance();
    ButtonTool buttonTool8 = new ButtonTool("Delete");
    Appearance appearance5 = new Appearance();
    ButtonTool buttonTool9 = new ButtonTool("Make Default");
    Appearance appearance6 = new Appearance();
    PopupMenuTool popupMenuTool2 = new PopupMenuTool("contextMenu");
    ButtonTool buttonTool10 = new ButtonTool("Make Default");
    this.treeGroups = new UltraTree();
    this.toolbar = new UltraToolbarsManager(this.components);
    this._EntityGroups_Toolbars_Dock_Area_Left = new UltraToolbarsDockArea();
    this._EntityGroups_Toolbars_Dock_Area_Right = new UltraToolbarsDockArea();
    this._EntityGroups_Toolbars_Dock_Area_Top = new UltraToolbarsDockArea();
    this._EntityGroups_Toolbars_Dock_Area_Bottom = new UltraToolbarsDockArea();
    this.ToolTip1 = new ToolTip(this.components);
    ((ISupportInitialize) this.treeGroups).BeginInit();
    ((ISupportInitialize) this.toolbar).BeginInit();
    this.SuspendLayout();
    this.toolbar.SetContextMenuUltra((Component) this.treeGroups, "contextMenu");
    ((Control) this.treeGroups).Dock = DockStyle.Fill;
    this.treeGroups.HideSelection = false;
    ((Control) this.treeGroups).Location = new Point(0, 25);
    ((Control) this.treeGroups).Name = "treeGroups";
    ultraTreeNode1.Key = "nodeUserGroups";
    ultraTreeNode1.LeftImages.Add(RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("UltraTreeNode1.LeftImages")));
    ultraTreeNode1.Text = "User Groups";
    ultraTreeNode2.CheckedState = CheckState.Checked;
    ultraTreeNode2.Key = "nodeCostCenters";
    ultraTreeNode2.LeftImages.Add(RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("UltraTreeNode2.LeftImages")));
    ultraTreeNode2.Text = "Cost Centers";
    this.treeGroups.Nodes.AddRange(new UltraTreeNode[2]
    {
      ultraTreeNode1,
      ultraTreeNode2
    });
    @override.SelectionType = (SelectType) 1;
    this.treeGroups.Override = @override;
    ((Control) this.treeGroups).Size = new Size(520, 247);
    ((Control) this.treeGroups).TabIndex = 0;
    appearance1.BackColor = Color.WhiteSmoke;
    this.toolbar.Appearance = (AppearanceBase) appearance1;
    this.toolbar.DesignerFlags = 1;
    this.toolbar.DockWithinContainer = (Control) this;
    this.toolbar.ImageTransparentColor = Color.Magenta;
    this.toolbar.ShowFullMenusDelay = 500;
    ultraToolbar.DockedColumn = 0;
    ultraToolbar.DockedRow = 0;
    ((UltraToolbarBase) ultraToolbar).NonInheritedTools.AddRange(new ToolBase[5]
    {
      (ToolBase) buttonTool1,
      (ToolBase) buttonTool2,
      (ToolBase) buttonTool3,
      (ToolBase) buttonTool4,
      (ToolBase) popupMenuTool1
    });
    ultraToolbar.Text = "UltraToolbar1";
    this.toolbar.Toolbars.AddRange(new UltraToolbar[1]
    {
      ultraToolbar
    });
    this.toolbar.ToolbarSettings.AllowCustomize = (DefaultableBoolean) 2;
    this.toolbar.ToolbarSettings.AllowFloating = (DefaultableBoolean) 2;
    this.toolbar.ToolbarSettings.GrabHandleStyle = (GrabHandleStyle) 1;
    ((SettingsBase) this.toolbar.ToolbarSettings).ToolDisplayStyle = (ToolDisplayStyle) 4;
    appearance2.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance2.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool5).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance2;
    ((ToolPropsBase) ((ToolBase) buttonTool5).SharedPropsInternal).Caption = "New Group/Cost Center";
    appearance3.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance3.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool6).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance3;
    ((ToolPropsBase) ((ToolBase) buttonTool6).SharedPropsInternal).Caption = "Add/Edit Entity";
    ((ToolBase) buttonTool6).SharedPropsInternal.Enabled = false;
    appearance4.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance4.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool7).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance4;
    ((ToolPropsBase) ((ToolBase) buttonTool7).SharedPropsInternal).Caption = "Edit Group/Cost Center";
    ((ToolBase) buttonTool7).SharedPropsInternal.Enabled = false;
    appearance5.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance5.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool8).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance5;
    ((ToolPropsBase) ((ToolBase) buttonTool8).SharedPropsInternal).Caption = "Delete";
    ((ToolBase) buttonTool8).SharedPropsInternal.Enabled = false;
    appearance6.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance6.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool9).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance6;
    ((ToolPropsBase) ((ToolBase) buttonTool9).SharedPropsInternal).Caption = "Make Default";
    ((ToolPropsBase) ((ToolBase) popupMenuTool2).SharedPropsInternal).Caption = "contextMenu";
    ((ToolBase) popupMenuTool2).SharedPropsInternal.Visible = false;
    ((ToolsCollectionBase) popupMenuTool2.Tools).AddRange(new ToolBase[1]
    {
      (ToolBase) buttonTool10
    });
    this.toolbar.Tools.AddRange(new ToolBase[6]
    {
      (ToolBase) buttonTool5,
      (ToolBase) buttonTool6,
      (ToolBase) buttonTool7,
      (ToolBase) buttonTool8,
      (ToolBase) buttonTool9,
      (ToolBase) popupMenuTool2
    });
    ((Control) this._EntityGroups_Toolbars_Dock_Area_Left).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._EntityGroups_Toolbars_Dock_Area_Left).BackColor = Color.WhiteSmoke;
    this._EntityGroups_Toolbars_Dock_Area_Left.DockedPosition = (DockedPosition) 2;
    ((Control) this._EntityGroups_Toolbars_Dock_Area_Left).ForeColor = SystemColors.ControlText;
    ((Control) this._EntityGroups_Toolbars_Dock_Area_Left).Location = new Point(0, 25);
    ((Control) this._EntityGroups_Toolbars_Dock_Area_Left).Name = "_EntityGroups_Toolbars_Dock_Area_Left";
    ((Control) this._EntityGroups_Toolbars_Dock_Area_Left).Size = new Size(0, 247);
    this._EntityGroups_Toolbars_Dock_Area_Left.ToolbarsManager = this.toolbar;
    ((Control) this._EntityGroups_Toolbars_Dock_Area_Right).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._EntityGroups_Toolbars_Dock_Area_Right).BackColor = Color.WhiteSmoke;
    this._EntityGroups_Toolbars_Dock_Area_Right.DockedPosition = (DockedPosition) 3;
    ((Control) this._EntityGroups_Toolbars_Dock_Area_Right).ForeColor = SystemColors.ControlText;
    ((Control) this._EntityGroups_Toolbars_Dock_Area_Right).Location = new Point(520, 25);
    ((Control) this._EntityGroups_Toolbars_Dock_Area_Right).Name = "_EntityGroups_Toolbars_Dock_Area_Right";
    ((Control) this._EntityGroups_Toolbars_Dock_Area_Right).Size = new Size(0, 247);
    this._EntityGroups_Toolbars_Dock_Area_Right.ToolbarsManager = this.toolbar;
    ((Control) this._EntityGroups_Toolbars_Dock_Area_Top).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._EntityGroups_Toolbars_Dock_Area_Top).BackColor = Color.WhiteSmoke;
    this._EntityGroups_Toolbars_Dock_Area_Top.DockedPosition = (DockedPosition) 0;
    ((Control) this._EntityGroups_Toolbars_Dock_Area_Top).ForeColor = SystemColors.ControlText;
    ((Control) this._EntityGroups_Toolbars_Dock_Area_Top).Location = new Point(0, 0);
    ((Control) this._EntityGroups_Toolbars_Dock_Area_Top).Name = "_EntityGroups_Toolbars_Dock_Area_Top";
    ((Control) this._EntityGroups_Toolbars_Dock_Area_Top).Size = new Size(520, 25);
    this._EntityGroups_Toolbars_Dock_Area_Top.ToolbarsManager = this.toolbar;
    ((Control) this._EntityGroups_Toolbars_Dock_Area_Bottom).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._EntityGroups_Toolbars_Dock_Area_Bottom).BackColor = Color.WhiteSmoke;
    this._EntityGroups_Toolbars_Dock_Area_Bottom.DockedPosition = (DockedPosition) 1;
    ((Control) this._EntityGroups_Toolbars_Dock_Area_Bottom).ForeColor = SystemColors.ControlText;
    ((Control) this._EntityGroups_Toolbars_Dock_Area_Bottom).Location = new Point(0, 272);
    ((Control) this._EntityGroups_Toolbars_Dock_Area_Bottom).Name = "_EntityGroups_Toolbars_Dock_Area_Bottom";
    ((Control) this._EntityGroups_Toolbars_Dock_Area_Bottom).Size = new Size(520, 0);
    this._EntityGroups_Toolbars_Dock_Area_Bottom.ToolbarsManager = this.toolbar;
    this.Controls.Add((Control) this.treeGroups);
    this.Controls.Add((Control) this._EntityGroups_Toolbars_Dock_Area_Left);
    this.Controls.Add((Control) this._EntityGroups_Toolbars_Dock_Area_Right);
    this.Controls.Add((Control) this._EntityGroups_Toolbars_Dock_Area_Bottom);
    this.Controls.Add((Control) this._EntityGroups_Toolbars_Dock_Area_Top);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Name = nameof (EntityGroups);
    this.Size = new Size(520, 272);
    ((ISupportInitialize) this.treeGroups).EndInit();
    ((ISupportInitialize) this.toolbar).EndInit();
    this.ResumeLayout(false);
  }

  public int OfficeLocationID
  {
    get => this._officeLocationID;
    set => this._officeLocationID = value;
  }

  public bool HideUserGroups
  {
    get => this._hideUserGroups;
    set => this._hideUserGroups = value;
  }

  private void EntityGroups_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    this.FillTree();
  }

  public void RefreshTree() => this.FillTree();

  private void FillTree()
  {
    if (this.HideUserGroups)
      this.treeGroups.Nodes["nodeUserGroups"].Visible = false;
    string str = "SELECT GroupID, GroupName, IsCostCenter, GroupDescription, @O + tblClientOffices.Location + @C as [OfficeName] FROM tblEntityGroups INNER JOIN tblClientOffices ON tblClientOffices.OfficeId = tblEntityGroups.GLCompanyId WHERE GLCompanyID=COALESCE(@OfficeLocationID,GLCompanyID) AND SystemDefined=0 ORDER BY GroupName";
    object officeLocationId = (object) DBNull.Value;
    if (this.OfficeLocationID != -1)
      officeLocationId = (object) this.OfficeLocationID;
    try
    {
      DefaultDatabase.ExecuteReader((EventHandler<ExecuteReaderArgs>) ([SpecialName] (s, nodeReader) =>
      {
        this.treeGroups.Nodes["nodeCostCenters"].Nodes.Clear();
        this.treeGroups.Nodes["nodeUserGroups"].Nodes.Clear();
        while (nodeReader.Reader.Read())
        {
          EntityGroupTreeNode entityGroupTreeNode = new EntityGroupTreeNode();
          ((SubObjectBase) entityGroupTreeNode).Tag = (object) nodeReader.Reader.GetString(3);
          entityGroupTreeNode.Key = nodeReader.Reader[0].ToString();
          entityGroupTreeNode.Text = nodeReader.Reader.GetString(1) + nodeReader.Reader.GetString(4);
          entityGroupTreeNode.OfficeDisplayValue = nodeReader.Reader.GetString(4);
          if (nodeReader.Reader.GetBoolean(2))
            this.treeGroups.Nodes["nodeCostCenters"].Nodes.Add((UltraTreeNode) entityGroupTreeNode);
          else
            this.treeGroups.Nodes["nodeUserGroups"].Nodes.Add((UltraTreeNode) entityGroupTreeNode);
        }
      }), CommandType.Text, str, new object[6]
      {
        (object) "@OfficeLocationID",
        officeLocationId,
        (object) "@O",
        (object) " (",
        (object) "@C",
        (object) ")"
      });
      DefaultDatabase.ExecuteReader((EventHandler<ExecuteReaderArgs>) ([SpecialName] (s, entReader) =>
      {
        while (entReader.Reader.Read())
        {
          int integer = Conversions.ToInteger(entReader.Reader[0]);
          Guid entityGuid = (Guid) entReader.Reader[1];
          EntityGroups.EntityNode entityNode1 = new EntityGroups.EntityNode();
          EntityGroups.EntityNode entityNode2 = entityNode1;
          entityNode2.IsDefault = entReader.Reader.GetBoolean(3);
          entityNode2.Key = EntityGroups.GetUniqueKey(integer, entityGuid);
          entityNode2.entityGuid = entityGuid;
          if (entReader.Reader[2] != DBNull.Value)
            entityNode2.Text = entReader.Reader.GetString(2);
          if (entityNode1.IsDefault)
            entityNode1.LeftImages.Add((object) ImageCache.Instance.Check);
          if (((KeyedSubObjectsCollectionBase) this.treeGroups.Nodes["nodeUserGroups"].Nodes).Exists(integer.ToString()))
            this.treeGroups.Nodes["nodeUserGroups"].Nodes[integer.ToString()].Nodes.Add((UltraTreeNode) entityNode1);
          if (((KeyedSubObjectsCollectionBase) this.treeGroups.Nodes["nodeCostCenters"].Nodes).Exists(integer.ToString()))
            this.treeGroups.Nodes["nodeCostCenters"].Nodes[integer.ToString()].Nodes.Add((UltraTreeNode) entityNode1);
        }
      }), CommandType.Text, "SELECT GroupID, EntityGuid, dbo.GetEntityName(EntityGuid) AS Entity, IsDefault FROM tblEntityGroupEntities ORDER BY Entity");
    }
    finally
    {
      this.treeGroups.ExpandAll();
    }
  }

  protected int GetGroupID()
  {
    int integer;
    if (this.treeGroups.SelectedNodes[0].Level == 2)
      integer = Conversions.ToInteger(this.treeGroups.SelectedNodes[0].Parent.Key);
    else if (this.treeGroups.SelectedNodes[0].Level == 1)
      integer = Conversions.ToInteger(this.treeGroups.SelectedNodes[0].Key);
    return integer;
  }

  private void toolBar_ToolClick(object sender, ToolClickEventArgs e)
  {
    string key = ((ToolEventArgs) e).Tool.Key;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "New", false) != 0)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Add", false) != 0)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Edit", false) != 0)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Delete", false) != 0)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Make Default", false) != 0)
              return;
            Guid entityGuid = ((EntityGroups.EntityNode) this.treeGroups.SelectedNodes[0]).entityGuid;
            try
            {
              foreach (EntityGroups.EntityNode entityNode in this.GetAllNodesByEntity(entityGuid))
              {
                if (entityNode.IsDefault)
                {
                  entityNode.IsDefault = false;
                  entityNode.LeftImages.Clear();
                  int integer = Conversions.ToInteger(entityNode.Parent.Key);
                  DefaultDatabase.ExecuteNonQuery(CommandType.Text, "UPDATE tblEntityGroupEntities SET IsDefault=0 WHERE EntityGuid=@EG AND GroupID=@ID", new object[4]
                  {
                    (object) "@EG",
                    (object) entityGuid,
                    (object) "@ID",
                    (object) integer
                  });
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
            EntityGroups.EntityNode selectedNode = (EntityGroups.EntityNode) this.treeGroups.SelectedNodes[0];
            selectedNode.LeftImages.Add((object) ImageCache.Instance.Check);
            selectedNode.IsDefault = true;
            DefaultDatabase.ExecuteNonQuery(CommandType.Text, "UPDATE tblEntityGroupEntities SET IsDefault=1 WHERE EntityGuid=@EG AND GroupID=@ID", new object[4]
            {
              (object) "@ID",
              (object) selectedNode.Parent.Key,
              (object) "@EG",
              (object) entityGuid
            });
          }
          else if (this.treeGroups.SelectedNodes[0].Level == 1)
          {
            if (MessageBox.Show("Are you sure you want to delete this group?", "Delete Group?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
              return;
            DefaultDatabase.ExecuteNonQuery(CommandType.Text, "DELETE FROM tblEntityGroups WHERE GroupID=@ID", new object[2]
            {
              (object) "@ID",
              (object) this.GetGroupID()
            });
            this.treeGroups.SelectedNodes[0].Remove();
          }
          else if (this.treeGroups.SelectedNodes[0].Level == 2)
          {
            if (MessageBox.Show("Are you sure you want to delete this group member?", "Delete Group Member?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
              return;
            Guid entityGuid = ((EntityGroups.EntityNode) this.treeGroups.SelectedNodes[0]).entityGuid;
            DefaultDatabase.ExecuteNonQuery(CommandType.Text, "DELETE FROM tblEntityGroupEntities WHERE GroupID=@ID AND EntityGuid=@EG", new object[4]
            {
              (object) "@ID",
              (object) this.GetGroupID(),
              (object) "@EG",
              (object) entityGuid
            });
            this.treeGroups.SelectedNodes[0].Remove();
          }
          else
          {
            int num1 = (int) MessageBox.Show("Please select a group or group member to delete.", "Select Entity to Delete", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          }
        }
        else
        {
          frmNewEditEntityGroup formEx = (frmNewEditEntityGroup) ObjectFactory.Instance.CreateFormEX(typeof (frmNewEditEntityGroup), (object) this.GetGroupID());
          formEx.CostCenterOnly = this.HideUserGroups;
          int num2 = (int) formEx.ShowDialog();
          try
          {
            if (!formEx.Saved)
              return;
            this.AddUpdateGroup(formEx.IsCostCenter, formEx.GroupID, formEx.GroupName, formEx.GroupDescription);
          }
          finally
          {
            formEx.Dispose();
          }
        }
      }
      else
      {
        frmSearchEntity.LimiterValuesClass limiterValuesClass = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.treeGroups.SelectedNodes[0].RootNode.Key, "nodeUserGroups", false) != 0 ? new frmSearchEntity.LimiterValuesClass(true, true, true, true, true, true, true, true, true, true, true, true) : new frmSearchEntity.LimiterValuesClass(ShowUsers: true);
        frmSearchEntity frmSearchEntity = (frmSearchEntity) ObjectFactory.Instance.CreateObject(typeof (frmSearchEntity));
        try
        {
          frmSearchEntity.LimiterValues = limiterValuesClass;
          int num3 = (int) frmSearchEntity.ShowDialog();
          if (frmSearchEntity.DialogResult != DialogResult.OK)
            return;
          this.AddUpdateMember(this.GetGroupID(), frmSearchEntity.EntityName, frmSearchEntity.EntityGUID);
        }
        finally
        {
          frmSearchEntity.Dispose();
        }
      }
    }
    else
    {
      frmNewEditEntityGroup form = (frmNewEditEntityGroup) ObjectFactory.Instance.CreateForm(typeof (frmNewEditEntityGroup));
      form.CostCenterOnly = this.HideUserGroups;
      int num4 = (int) form.ShowDialog();
      if (this.OfficeLocationID != -1)
        form.DefaultOfficeLocationID = this.OfficeLocationID;
      try
      {
        if (!form.Saved)
          return;
        this.AddUpdateGroup(form.IsCostCenter, form.GroupID, form.GroupName, form.GroupDescription);
      }
      finally
      {
        form.Dispose();
      }
    }
  }

  private ArrayList GetAllNodesByEntity(Guid entityGuid)
  {
    ArrayList allNodesByEntity = new ArrayList();
    foreach (UltraTreeNode node1 in this.treeGroups.Nodes["nodeUserGroups"].Nodes)
    {
      foreach (EntityGroups.EntityNode node2 in node1.Nodes)
      {
        if (node2.entityGuid.Equals(entityGuid))
          allNodesByEntity.Add((object) node2);
      }
    }
    foreach (UltraTreeNode node3 in this.treeGroups.Nodes["nodeCostCenters"].Nodes)
    {
      foreach (EntityGroups.EntityNode node4 in node3.Nodes)
      {
        if (node4.entityGuid.Equals(entityGuid))
          allNodesByEntity.Add((object) node4);
      }
    }
    return allNodesByEntity;
  }

  private void AddUpdateMember(int groupID, string entityName, Guid entityGuid)
  {
    bool flag = this.GetAllNodesByEntity(entityGuid).Count == 0;
    DefaultDatabase.ExecuteNonQuery(CommandType.Text, "INSERT INTO tblEntityGroupEntities(GroupID, EntityGuid, IsDefault)VALUES(@GroupID,@EntityGuid,@IsDefault)", new object[6]
    {
      (object) "@GroupID",
      (object) groupID,
      (object) "@EntityGuid",
      (object) entityGuid,
      (object) "@IsDefault",
      (object) flag
    });
    this.RemoveExistingMember(groupID, entityGuid);
    string uniqueKey = EntityGroups.GetUniqueKey(groupID, entityGuid);
    if (this.treeGroups.GetNodeByKey(uniqueKey) == null)
    {
      EntityGroups.EntityNode entityNode1 = new EntityGroups.EntityNode();
      EntityGroups.EntityNode entityNode2 = entityNode1;
      entityNode2.IsDefault = flag;
      entityNode2.Key = uniqueKey;
      entityNode2.entityGuid = entityGuid;
      entityNode2.Text = entityName;
      if (flag)
        entityNode2.LeftImages.Add((object) ImageCache.Instance.Check);
      if (((KeyedSubObjectsCollectionBase) this.treeGroups.Nodes["nodeUserGroups"].Nodes).Exists(groupID.ToString()))
        this.treeGroups.Nodes["nodeUserGroups"].Nodes[groupID.ToString()].Nodes.Add((UltraTreeNode) entityNode1);
      else
        this.treeGroups.Nodes["nodeCostCenters"].Nodes[groupID.ToString()].Nodes.Add((UltraTreeNode) entityNode1);
      this.treeGroups.ExpandAll();
    }
    else
    {
      EntityGroups.EntityNode nodeByKey = (EntityGroups.EntityNode) this.treeGroups.GetNodeByKey(uniqueKey);
      nodeByKey.Key = uniqueKey;
      nodeByKey.Text = entityName;
      if (flag)
        nodeByKey.LeftImages.Add((object) ImageCache.Instance.Check);
    }
  }

  private static string GetUniqueKey(int groupID, Guid entityGuid)
  {
    return $"{groupID.ToString()}-{entityGuid.ToString()}";
  }

  private void RemoveExistingMember(int groupID, Guid entityGuid)
  {
    string uniqueKey = EntityGroups.GetUniqueKey(groupID, entityGuid);
    if (((KeyedSubObjectsCollectionBase) this.treeGroups.Nodes["nodeUserGroups"].Nodes).Exists(groupID.ToString()) && ((KeyedSubObjectsCollectionBase) this.treeGroups.Nodes["nodeUserGroups"].Nodes[groupID.ToString()].Nodes).Exists(uniqueKey))
      this.treeGroups.Nodes["nodeUserGroups"].Nodes[groupID.ToString()].Nodes[uniqueKey].Remove();
    if (!((KeyedSubObjectsCollectionBase) this.treeGroups.Nodes["nodeCostCenters"].Nodes).Exists(groupID.ToString()) || !((KeyedSubObjectsCollectionBase) this.treeGroups.Nodes["nodeCostCenters"].Nodes[groupID.ToString()].Nodes).Exists(uniqueKey))
      return;
    this.treeGroups.Nodes["nodeUserGroups"].Nodes[groupID.ToString()].Nodes[uniqueKey].Remove();
  }

  private void AddUpdateGroup(
    bool isCostCenter,
    int groupID,
    string groupName,
    string groupDescription)
  {
    UltraTreeNode nodeByKey = this.treeGroups.GetNodeByKey(groupID.ToString());
    if (nodeByKey == null)
    {
      UltraTreeNode ultraTreeNode1 = new UltraTreeNode();
      ultraTreeNode1.Key = groupID.ToString();
      ultraTreeNode1.Text = groupName;
      ((SubObjectBase) ultraTreeNode1).Tag = (object) groupDescription;
      UltraTreeNode ultraTreeNode2 = ultraTreeNode1;
      if (isCostCenter)
        this.treeGroups.Nodes["nodeCostCenters"].Nodes.Add(ultraTreeNode2);
      else
        this.treeGroups.Nodes["nodeUserGroups"].Nodes.Add(ultraTreeNode2);
    }
    else
    {
      if (!(nodeByKey is EntityGroupTreeNode))
        return;
      nodeByKey.Text = groupName + ((EntityGroupTreeNode) nodeByKey).OfficeDisplayValue;
      ((SubObjectBase) nodeByKey).Tag = (object) groupDescription;
    }
  }

  private void RemoveExistingNodes(int groupID)
  {
    if (((KeyedSubObjectsCollectionBase) this.treeGroups.Nodes["nodeUserGroups"].Nodes).Exists(groupID.ToString()))
      this.treeGroups.Nodes["nodeUserGroups"].Nodes[groupID.ToString()].Remove();
    if (!((KeyedSubObjectsCollectionBase) this.treeGroups.Nodes["nodeCostCenters"].Nodes).Exists(groupID.ToString()))
      return;
    this.treeGroups.Nodes["nodeCostCenters"].Nodes[groupID.ToString()].Remove();
  }

  protected virtual void TreeGroupsAfterSelect()
  {
  }

  private void treeGroups_AfterSelect(object sender, SelectEventArgs e)
  {
    if (((DisposableObjectCollectionBase) this.treeGroups.SelectedNodes).Count == 0 || this.treeGroups.SelectedNodes[0].Level == 0)
    {
      ((ToolsCollectionBase) this.toolbar.Tools)["Add"].SharedProps.Enabled = false;
      ((ToolsCollectionBase) this.toolbar.Tools)["Edit"].SharedProps.Enabled = false;
      ((ToolsCollectionBase) this.toolbar.Tools)["Delete"].SharedProps.Enabled = false;
    }
    else
    {
      ((ToolsCollectionBase) this.toolbar.Tools)["Add"].SharedProps.Enabled = true;
      ((ToolsCollectionBase) this.toolbar.Tools)["Edit"].SharedProps.Enabled = true;
      ((ToolsCollectionBase) this.toolbar.Tools)["Delete"].SharedProps.Enabled = true;
    }
    this.TreeGroupsAfterSelect();
  }

  private void toolbar_BeforeToolDropdown(object sender, BeforeToolDropdownEventArgs e)
  {
    if (((DisposableObjectCollectionBase) this.treeGroups.SelectedNodes).Count == 0)
      return;
    if (this.treeGroups.SelectedNodes[0].Level == 2)
      ((ToolsCollectionBase) this.toolbar.Tools)["Make Default"].SharedProps.Enabled = true;
    else
      ((CancelEventArgs) e).Cancel = true;
  }

  private void treeGroups_MouseEnterElement(object sender, UIElementEventArgs e)
  {
    UltraTreeNode context = (UltraTreeNode) e.Element.GetContext(typeof (UltraTreeNode));
    if (context == null || context.Level != 1)
      return;
    this.ToolTip1.Active = true;
    this.ToolTip1.SetToolTip((Control) this.treeGroups, ((SubObjectBase) context).Tag.ToString());
  }

  protected enum TreeLevels
  {
    GroupTypes,
    GroupNames,
    GroupMembers,
  }

  protected class EntityNode : UltraTreeNode
  {
    private bool _isDefault;
    private Guid _entityGuid;

    public Guid entityGuid
    {
      get => this._entityGuid;
      set => this._entityGuid = value;
    }

    public bool IsDefault
    {
      get => this._isDefault;
      set => this._isDefault = value;
    }

    protected override void OnDispose() => base.OnDispose();
  }
}
