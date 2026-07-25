// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.ReportControls.EntityEntityLocationEntityContactTree
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

using Infragistics.Shared;
using Infragistics.Win.UltraWinTree;
using MGASystems.Common.DataAccess;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Reporting.ReportControls;

[DesignerGenerated]
public class EntityEntityLocationEntityContactTree : BaseReportControl
{
  private IContainer components;
  private DataTable _dtEntities;
  private DataTable _dtEntityLocations;
  private DataTable _dtEntityContacts;
  private bool _ShowLocations;
  private bool _ShowContacts;
  private bool _ShowAll;
  private bool _CheckAllOption;
  private bool _ReturnAll;
  private TreeNodesCollection _EntityLevelNodesCollection;
  private object _ReturnValue;

  [DebuggerNonUserCode]
  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    Override @override = new Override();
    this.treeEntitiesAndCo = new UltraTree();
    ((ISupportInitialize) this.treeEntitiesAndCo).BeginInit();
    this.SuspendLayout();
    this.lblDescription.Size = new Size(88, 150);
    ((Control) this.treeEntitiesAndCo).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    ((Control) this.treeEntitiesAndCo).Location = new Point(88, 3);
    ((Control) this.treeEntitiesAndCo).Name = "treeEntitiesAndCo";
    @override.NodeStyle = (NodeStyle) 2;
    this.treeEntitiesAndCo.Override = @override;
    ((Control) this.treeEntitiesAndCo).Size = new Size(300, 144 /*0x90*/);
    ((Control) this.treeEntitiesAndCo).TabIndex = 1;
    this.Controls.Add((Control) this.treeEntitiesAndCo);
    this.Name = nameof (EntityEntityLocationEntityContactTree);
    this.Size = new Size(400, 150);
    this.Controls.SetChildIndex((Control) this.lblDescription, 0);
    this.Controls.SetChildIndex((Control) this.treeEntitiesAndCo, 0);
    ((ISupportInitialize) this.treeEntitiesAndCo).EndInit();
    this.ResumeLayout(false);
  }

  internal virtual UltraTree treeEntitiesAndCo
  {
    get => this._treeEntitiesAndCo;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      BeforeCheckEventHandler checkEventHandler = new BeforeCheckEventHandler(this.treeEntitiesAndCo_BeforeCheck);
      AfterNodeChangedEventHandler changedEventHandler = new AfterNodeChangedEventHandler(this.treeEntitiesAndCo_AfterCheck);
      UltraTree treeEntitiesAndCo1 = this._treeEntitiesAndCo;
      if (treeEntitiesAndCo1 != null)
      {
        treeEntitiesAndCo1.BeforeCheck -= checkEventHandler;
        treeEntitiesAndCo1.AfterCheck -= changedEventHandler;
      }
      this._treeEntitiesAndCo = value;
      UltraTree treeEntitiesAndCo2 = this._treeEntitiesAndCo;
      if (treeEntitiesAndCo2 == null)
        return;
      treeEntitiesAndCo2.BeforeCheck += checkEventHandler;
      treeEntitiesAndCo2.AfterCheck += changedEventHandler;
    }
  }

  public EntityEntityLocationEntityContactTree(
    string labelText,
    string EntitiesSQL,
    string EntityLocationsSQL,
    string EntityContactsSQL,
    bool ShowAllOption,
    bool CheckAllOption,
    bool ShowEntityLocations,
    bool ShowEntityContacts,
    bool ReturnAll,
    int ControlHeight = 150)
  {
    this._dtEntities = Database.Instance.QueryText.PerformTableQuery(EntitiesSQL);
    if (ShowEntityLocations)
      this._dtEntityLocations = Database.Instance.QueryText.PerformTableQuery(EntityLocationsSQL);
    if (ShowEntityLocations && ShowEntityContacts)
      this._dtEntityContacts = Database.Instance.QueryText.PerformTableQuery(EntityContactsSQL);
    this.Constructor(labelText, ShowAllOption, CheckAllOption, ShowEntityLocations, ShowEntityContacts, ReturnAll, ControlHeight);
  }

  public EntityEntityLocationEntityContactTree(
    string labelText,
    DataTable Entities,
    DataTable EntityLocations,
    DataTable EntityContacts,
    bool ShowAllOption,
    bool CheckAllOption,
    bool ShowEntityLocations,
    bool ShowEntityContacts,
    bool ReturnAll,
    int ControlHeight = 150)
  {
    this._dtEntities = Entities;
    if (ShowEntityLocations)
      this._dtEntityLocations = EntityLocations;
    if (ShowEntityLocations && ShowEntityContacts)
      this._dtEntityContacts = EntityContacts;
    this.Constructor(labelText, ShowAllOption, CheckAllOption, ShowEntityLocations, ShowEntityContacts, ReturnAll, ControlHeight);
  }

  private void Constructor(
    string labelText,
    bool ShowAllOption,
    bool CheckAllOption,
    bool ShowEntityLocations,
    bool ShowEntityContacts,
    bool ReturnAll,
    int ControlHeight)
  {
    this.InitializeComponent();
    this._ShowAll = ShowAllOption;
    this._CheckAllOption = CheckAllOption;
    this._ShowLocations = ShowEntityLocations;
    this._ShowContacts = ShowEntityContacts;
    this._ReturnAll = ReturnAll;
    if (!this._ShowLocations)
      this._ShowContacts = false;
    ((Control) this.treeEntitiesAndCo).Height = ControlHeight - 6;
    this.Height = ControlHeight;
    this.PopulateTreeView(this._ShowAll, this._ShowLocations, this._ShowContacts);
    this.Description = labelText;
    this.InitialSize = this.Size;
  }

  private void PopulateTreeView(bool ShowAll, bool ShowLocations, bool ShowContacts)
  {
    if (ShowAll)
    {
      EntityEntityLocationEntityContactTree.TreeItem treeItem = new EntityEntityLocationEntityContactTree.TreeItem()
      {
        Level = -1,
        Display = "Select All"
      };
      UltraTreeNode ultraTreeNode = this.treeEntitiesAndCo.Nodes.Add(Guid.Empty.ToString(), "Select All");
      ((SubObjectBase) ultraTreeNode).Tag = (object) treeItem;
      this._EntityLevelNodesCollection = ultraTreeNode.Nodes;
      ultraTreeNode.Expanded = true;
    }
    else
      this._EntityLevelNodesCollection = this.treeEntitiesAndCo.Nodes;
    try
    {
      foreach (DataRow row in this._dtEntities.Rows)
      {
        EntityEntityLocationEntityContactTree.TreeItem treeItem = new EntityEntityLocationEntityContactTree.TreeItem()
        {
          Level = 0,
          Display = row["EntityName"].ToString(),
          EntityGUID = new Guid(row["EntityGUID"].ToString())
        };
        ((SubObjectBase) this._EntityLevelNodesCollection.Add(treeItem.EntityGUID.ToString(), treeItem.Display)).Tag = (object) treeItem;
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    if (!ShowLocations)
      return;
    try
    {
      foreach (DataRow row in this._dtEntityLocations.Rows)
      {
        EntityEntityLocationEntityContactTree.TreeItem treeItem = new EntityEntityLocationEntityContactTree.TreeItem()
        {
          Level = 1,
          Display = row["EntityLocationName"].ToString(),
          EntityGUID = new Guid(row["EntityGUID"].ToString()),
          EntityLocationGUID = new Guid(row["EntityLocationGUID"].ToString())
        };
        UltraTreeNode entityLevelNodes = this._EntityLevelNodesCollection[treeItem.EntityGUID.ToString()];
        if (!Information.IsNothing((object) entityLevelNodes) && !((DisposableObjectCollectionBase) entityLevelNodes.Nodes).Contains((object) treeItem.EntityLocationGUID.ToString()))
          ((SubObjectBase) entityLevelNodes.Nodes.Add(treeItem.EntityLocationGUID.ToString(), treeItem.Display)).Tag = (object) treeItem;
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    if (!ShowContacts)
      return;
    try
    {
      foreach (DataRow row in this._dtEntityContacts.Rows)
      {
        EntityEntityLocationEntityContactTree.TreeItem treeItem = new EntityEntityLocationEntityContactTree.TreeItem()
        {
          Level = 2,
          Display = row["EntityContactnName"].ToString(),
          EntityGUID = new Guid(row["EntityGUID"].ToString()),
          EntityLocationGUID = new Guid(row["EntityLocationGUID"].ToString()),
          EntityContactGUID = new Guid(row["EntityContactGUID"].ToString())
        };
        UltraTreeNode entityLevelNodes = this._EntityLevelNodesCollection[treeItem.EntityGUID.ToString()];
        if (!Information.IsNothing((object) entityLevelNodes))
        {
          UltraTreeNode node = entityLevelNodes.Nodes[treeItem.EntityLocationGUID.ToString()];
          if (!Information.IsNothing((object) node) && !((DisposableObjectCollectionBase) node.Nodes).Contains((object) treeItem.EntityContactGUID.ToString()))
            ((SubObjectBase) node.Nodes.Add(treeItem.EntityContactGUID.ToString(), treeItem.Display)).Tag = (object) treeItem;
        }
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    if (!ShowAll || !this._CheckAllOption)
      return;
    this.treeEntitiesAndCo.Nodes[Guid.Empty.ToString()].CheckedState = CheckState.Checked;
  }

  private void treeEntitiesAndCo_BeforeCheck(object sender, BeforeCheckEventArgs e)
  {
    UltraTreeNode treeNode = ((CancelableNodeEventArgs) e).TreeNode;
    EntityEntityLocationEntityContactTree.TreeItem tag = (EntityEntityLocationEntityContactTree.TreeItem) ((SubObjectBase) treeNode).Tag;
    if (tag.IgnoreEvent)
    {
      tag.IgnoreEvent = false;
    }
    else
    {
      if (e.NewValue != CheckState.Indeterminate)
        return;
      if (treeNode.CheckedState == CheckState.Checked)
      {
        e.NewValue = CheckState.Unchecked;
      }
      else
      {
        if (treeNode.CheckedState != CheckState.Unchecked)
          return;
        e.NewValue = CheckState.Checked;
      }
    }
  }

  private void treeEntitiesAndCo_AfterCheck(object sender, NodeEventArgs e)
  {
    UltraTreeNode treeNode = e.TreeNode;
    EntityEntityLocationEntityContactTree.TreeItem tag = (EntityEntityLocationEntityContactTree.TreeItem) ((SubObjectBase) treeNode).Tag;
    this._ReturnValue = (object) null;
    if (tag.IgnoreEvent)
    {
      tag.IgnoreEvent = false;
    }
    else
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(treeNode.Key, Guid.Empty.ToString(), false) == 0)
      {
        if (treeNode.CheckedState == CheckState.Checked)
        {
          foreach (UltraTreeNode node in treeNode.Nodes)
            node.Enabled = false;
          return;
        }
        foreach (UltraTreeNode node in treeNode.Nodes)
          node.Enabled = true;
      }
      if (treeNode.CheckedState == CheckState.Checked)
        this.SetChildrenCheckState(treeNode, CheckState.Checked);
      if (treeNode.CheckedState == CheckState.Unchecked)
        this.SetChildrenCheckState(treeNode, CheckState.Unchecked);
      this.SetParentCheckState(treeNode);
    }
  }

  private void SetParentCheckState(UltraTreeNode node)
  {
    if (Information.IsNothing((object) node.Parent))
      return;
    EntityEntityLocationEntityContactTree.TreeItem tag = (EntityEntityLocationEntityContactTree.TreeItem) ((SubObjectBase) node.Parent).Tag;
    TreeNodesCollection parentNodesCollection = node.ParentNodesCollection;
    int num1 = 0;
    int num2 = 0;
    foreach (UltraTreeNode ultraTreeNode in parentNodesCollection)
    {
      if (ultraTreeNode.CheckedState == CheckState.Checked)
        ++num1;
    }
    foreach (UltraTreeNode ultraTreeNode in parentNodesCollection)
    {
      if (ultraTreeNode.CheckedState == CheckState.Indeterminate)
        ++num2;
    }
    tag.IgnoreEvent = true;
    if (num1 == 0)
    {
      if (num2 == 0)
        node.Parent.CheckedState = CheckState.Unchecked;
      else
        node.Parent.CheckedState = CheckState.Indeterminate;
    }
    else if (num1 == parentNodesCollection.Count)
    {
      node.Parent.CheckedState = CheckState.Checked;
      node.Parent.Expanded = true;
    }
    else
    {
      if (num1 >= parentNodesCollection.Count)
        return;
      node.Parent.CheckedState = CheckState.Indeterminate;
      node.Parent.Expanded = true;
    }
  }

  private void SetChildrenCheckState(UltraTreeNode node, CheckState @checked)
  {
    foreach (UltraTreeNode node1 in node.Nodes)
      node1.CheckedState = @checked;
  }

  public override void Compress()
  {
    ((Control) this.treeEntitiesAndCo).Top = 0;
    this.lblDescription.Height = ((Control) this.treeEntitiesAndCo).Height;
    this.lblDescription.Top = 0;
    this.Height = ((Control) this.treeEntitiesAndCo).Height;
  }

  public override object Value
  {
    get => this.CalculateReturnValue();
    set => this.SetTreeState(RuntimeHelpers.GetObjectValue(value));
  }

  public override string InputErrorMessage
  {
    get
    {
      if (Information.IsNothing(RuntimeHelpers.GetObjectValue(this._ReturnValue)))
        this._ReturnValue = RuntimeHelpers.GetObjectValue(this.CalculateReturnValue());
      return this._ReturnValue.ToString().Length <= int.MaxValue ? (!this._ReturnValue.ToString().Equals(string.Empty) || !this._ReturnAll ? string.Empty : "Please select values.") : "Too many contacts selected.";
    }
  }

  private void SetTreeState(object value)
  {
    string str = value.ToString();
    if (!this._ShowContacts && !this._ShowLocations && str.Length > 1)
    {
      DataRow[] dataRowArray1 = this._dtEntityContacts.Select($"EntityContactGUID in ('{str.Replace(",", "','")}')");
      ArrayList arrayList = new ArrayList();
      DataRow[] dataRowArray2 = dataRowArray1;
      int index = 0;
      while (index < dataRowArray2.Length)
      {
        DataRow dataRow = dataRowArray2[index];
        arrayList.Add((object) dataRow["EntityGUID"].ToString());
        checked { ++index; }
      }
      foreach (UltraTreeNode entityLevelNodes in this._EntityLevelNodesCollection)
        entityLevelNodes.CheckedState = !arrayList.Contains((object) entityLevelNodes.Key) ? CheckState.Unchecked : CheckState.Checked;
    }
    else if (!this._ShowContacts && this._ShowLocations && str.Length > 1)
    {
      DataRow[] dataRowArray3 = this._dtEntityContacts.Select($"EntityContactGUID in ('{str.Replace(",", "','")}')");
      ArrayList arrayList = new ArrayList();
      DataRow[] dataRowArray4 = dataRowArray3;
      int index = 0;
      while (index < dataRowArray4.Length)
      {
        DataRow dataRow = dataRowArray4[index];
        arrayList.Add((object) dataRow["EntityLocationGUID"].ToString());
        checked { ++index; }
      }
      foreach (UltraTreeNode entityLevelNodes in this._EntityLevelNodesCollection)
      {
        foreach (UltraTreeNode node in entityLevelNodes.Nodes)
          node.CheckedState = !arrayList.Contains((object) node.Key) ? CheckState.Unchecked : CheckState.Checked;
      }
    }
    else
    {
      if (!this._ShowContacts || str.Length <= 1)
        return;
      ArrayList arrayList = new ArrayList((ICollection) str.Split(','));
      foreach (UltraTreeNode entityLevelNodes in this._EntityLevelNodesCollection)
      {
        foreach (UltraTreeNode node1 in entityLevelNodes.Nodes)
        {
          foreach (UltraTreeNode node2 in node1.Nodes)
            node2.CheckedState = !arrayList.Contains((object) node2.Key) ? CheckState.Unchecked : CheckState.Checked;
        }
      }
    }
  }

  private object CalculateReturnValue()
  {
    string str = "";
    object returnValue;
    if (!Information.IsNothing(RuntimeHelpers.GetObjectValue(this._ReturnValue)))
      returnValue = this._ReturnValue;
    else if (this._ShowAll && this.treeEntitiesAndCo.Nodes[Guid.Empty.ToString()].CheckedState == CheckState.Checked)
    {
      if (this._ReturnAll)
      {
        IEnumerable<DataRow> source = this._dtEntityContacts.Rows.Cast<DataRow>();
        System.Func<DataRow, string> selector;
        // ISSUE: reference to a compiler-generated field
        if (EntityEntityLocationEntityContactTree._Closure\u0024__.\u0024I32\u002D0 != null)
        {
          // ISSUE: reference to a compiler-generated field
          selector = EntityEntityLocationEntityContactTree._Closure\u0024__.\u0024I32\u002D0;
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          EntityEntityLocationEntityContactTree._Closure\u0024__.\u0024I32\u002D0 = selector = (System.Func<DataRow, string>) ([SpecialName] (dr) => dr["EntityContactGUID"].ToString());
        }
        this._ReturnValue = (object) string.Join(",", ((IEnumerable<string>) source.Select<DataRow, string>(selector).ToArray<string>()).ToArray<string>());
        returnValue = this._ReturnValue;
      }
      else
        returnValue = (object) Guid.Empty.ToString();
    }
    else
    {
      List<string> stringList1 = new List<string>();
      List<string> stringList2 = new List<string>();
      List<string> stringList3 = new List<string>();
      foreach (UltraTreeNode entityLevelNodes in this._EntityLevelNodesCollection)
      {
        if (entityLevelNodes.CheckedState != CheckState.Unchecked)
        {
          stringList1.Add(entityLevelNodes.Key);
          foreach (UltraTreeNode node1 in entityLevelNodes.Nodes)
          {
            if (node1.CheckedState != CheckState.Unchecked)
            {
              stringList2.Add(node1.Key);
              foreach (UltraTreeNode node2 in node1.Nodes)
              {
                if (node2.CheckedState != CheckState.Unchecked)
                  stringList3.Add(node2.Key);
              }
            }
          }
        }
      }
      if (!this._ShowContacts && !this._ShowLocations && stringList1.Count > 0)
      {
        DataRow[] dataRowArray1 = this._dtEntityContacts.Select("EntityGUID in " + $"('{string.Join("','", stringList1.ToArray())}')");
        ArrayList arrayList = new ArrayList();
        DataRow[] dataRowArray2 = dataRowArray1;
        int index = 0;
        while (index < dataRowArray2.Length)
        {
          DataRow dataRow = dataRowArray2[index];
          arrayList.Add((object) dataRow["EntityContactGUID"].ToString());
          checked { ++index; }
        }
        returnValue = (object) string.Join(",", arrayList.ToArray());
      }
      else if (!this._ShowContacts && this._ShowLocations && stringList2.Count > 0)
      {
        DataRow[] dataRowArray3 = this._dtEntityContacts.Select("EntityLocationGUID in " + $"('{string.Join("','", stringList2.ToArray())}')");
        ArrayList arrayList = new ArrayList();
        DataRow[] dataRowArray4 = dataRowArray3;
        int index = 0;
        while (index < dataRowArray4.Length)
        {
          DataRow dataRow = dataRowArray4[index];
          arrayList.Add((object) dataRow["EntityContactGUID"].ToString());
          checked { ++index; }
        }
        returnValue = (object) string.Join(",", arrayList.ToArray());
      }
      else
      {
        if (this._ShowContacts)
          str = string.Join(",", stringList3.ToArray());
        returnValue = (object) str;
      }
    }
    return returnValue;
  }

  private class TreeItem
  {
    public int Level;
    public Guid EntityGUID;
    public Guid EntityLocationGUID;
    public Guid EntityContactGUID;
    public string Display;
    public bool IgnoreEvent;
    public CheckState CheckState;

    public TreeItem()
    {
      this.Display = "";
      this.IgnoreEvent = false;
      this.CheckState = CheckState.Unchecked;
    }

    public override string ToString() => this.Display;
  }
}
