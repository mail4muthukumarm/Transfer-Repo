// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.ReportControls.ProducersLocationsContacts
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

using Infragistics.Shared;
using Infragistics.Win.UltraWinTree;
using MGASystems.Common.DataAccess;
using MGASystems.Data;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Reporting.ReportControls;

[DesignerGenerated]
public class ProducersLocationsContacts : BaseReportControl
{
  private IContainer components;
  private DataTable _dtProducers;
  private DataTable _dtLocations;
  private DataTable _dtContacts;
  private bool _ShowLocations;
  private bool _ShowContacts;
  private bool _ShowAll;
  private bool _ReturnAll;
  private int _ProducerLevel;
  private TreeNodesCollection _ProducerLevelNodesCollection;
  private object _ReturnValue;
  private const string SQLProducers = "SELECT ProducerGUID, ProducerName FROM tblProducers WHERE Closed = 0 AND ProducerName <> @EMPTY ORDER BY ProducerName";
  private const string SQLProducerLocations = "SELECT tblProducers.ProducerGUID, tblProducerLocations.ProducerLocationGUID, tblProducerLocations.Name as ProducerLocationName FROM tblProducers INNER JOIN tblProducerLocations ON tblProducers.ProducerGUID = tblProducerLocations.ProducerGUID WHERE (tblProducers.Closed = 0) ORDER BY tblProducerLocations.Name";
  private const string SQLProducerContacts = "SELECT tblProducers.ProducerGUID, tblProducerLocations.ProducerLocationGUID, tblProducerContacts.ProducerContactGUID, IsNull(tblProducerContacts.LName, @S) + IsNull(@C + tblProducerContacts.FName, @S) as ProducerContactName FROM tblProducers INNER JOIN tblProducerLocations ON tblProducers.ProducerGUID = tblProducerLocations.ProducerGUID INNER JOIN tblProducerContacts ON tblProducerLocations.ProducerLocationGUID = tblProducerContacts.ProducerLocationGUID WHERE (tblProducers.Closed = 0) ORDER BY tblProducerContacts.LName";

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
    this.treeProducersAndCo = new UltraTree();
    ((ISupportInitialize) this.treeProducersAndCo).BeginInit();
    this.SuspendLayout();
    this.lblDescription.Size = new Size(88, 144 /*0x90*/);
    ((Control) this.treeProducersAndCo).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    ((Control) this.treeProducersAndCo).Location = new Point(88, 3);
    ((Control) this.treeProducersAndCo).Name = "treeProducersAndCo";
    @override.NodeStyle = (NodeStyle) 2;
    this.treeProducersAndCo.Override = @override;
    ((Control) this.treeProducersAndCo).Size = new Size(300, 136);
    ((Control) this.treeProducersAndCo).TabIndex = 1;
    this.Controls.Add((Control) this.treeProducersAndCo);
    this.Name = nameof (ProducersLocationsContacts);
    this.Size = new Size(400, 144 /*0x90*/);
    this.Controls.SetChildIndex((Control) this.lblDescription, 0);
    this.Controls.SetChildIndex((Control) this.treeProducersAndCo, 0);
    ((ISupportInitialize) this.treeProducersAndCo).EndInit();
    this.ResumeLayout(false);
  }

  internal virtual UltraTree treeProducersAndCo
  {
    get => this._treeProducersAndCo;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      BeforeCheckEventHandler checkEventHandler = new BeforeCheckEventHandler(this.treeProducersAndCo_BeforeCheck);
      AfterNodeChangedEventHandler changedEventHandler = new AfterNodeChangedEventHandler(this.treeProducersAndCo_AfterCheck);
      UltraTree treeProducersAndCo1 = this._treeProducersAndCo;
      if (treeProducersAndCo1 != null)
      {
        treeProducersAndCo1.BeforeCheck -= checkEventHandler;
        treeProducersAndCo1.AfterCheck -= changedEventHandler;
      }
      this._treeProducersAndCo = value;
      UltraTree treeProducersAndCo2 = this._treeProducersAndCo;
      if (treeProducersAndCo2 == null)
        return;
      treeProducersAndCo2.BeforeCheck += checkEventHandler;
      treeProducersAndCo2.AfterCheck += changedEventHandler;
    }
  }

  public ProducersLocationsContacts()
  {
    this.Constructor("Producers\r\nLocations\r\nContacts", true, true, true, false);
  }

  public ProducersLocationsContacts(string labelText)
  {
    this.Constructor(labelText, true, true, true, true);
  }

  public ProducersLocationsContacts(string labelText, bool ShowAll)
  {
    this.Constructor(labelText, ShowAll, true, true, true);
  }

  public ProducersLocationsContacts(
    string labelText,
    bool ShowAll,
    bool ShowLocations,
    bool ShowContacts)
  {
    this.Constructor(labelText, ShowAll, ShowLocations, ShowContacts, true);
  }

  public ProducersLocationsContacts(
    string labelText,
    bool ShowAll,
    bool ShowLocations,
    bool ShowContacts,
    bool ReturnAll)
  {
    this.Constructor(labelText, ShowAll, ShowLocations, ShowContacts, ReturnAll);
  }

  private void Constructor(
    string labelText,
    bool ShowSelectAll,
    bool ShowLocations,
    bool ShowContacts,
    bool ReturnAll)
  {
    this.InitializeComponent();
    this._dtProducers = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT ProducerGUID, ProducerName FROM tblProducers WHERE Closed = 0 AND ProducerName <> @EMPTY ORDER BY ProducerName", new object[2]
    {
      (object) "@EMPTY",
      (object) "''"
    });
    if (ShowLocations)
      this._dtLocations = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT tblProducers.ProducerGUID, tblProducerLocations.ProducerLocationGUID, tblProducerLocations.Name as ProducerLocationName FROM tblProducers INNER JOIN tblProducerLocations ON tblProducers.ProducerGUID = tblProducerLocations.ProducerGUID WHERE (tblProducers.Closed = 0) ORDER BY tblProducerLocations.Name");
    if (ShowLocations && ShowContacts)
      this._dtContacts = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT tblProducers.ProducerGUID, tblProducerLocations.ProducerLocationGUID, tblProducerContacts.ProducerContactGUID, IsNull(tblProducerContacts.LName, @S) + IsNull(@C + tblProducerContacts.FName, @S) as ProducerContactName FROM tblProducers INNER JOIN tblProducerLocations ON tblProducers.ProducerGUID = tblProducerLocations.ProducerGUID INNER JOIN tblProducerContacts ON tblProducerLocations.ProducerLocationGUID = tblProducerContacts.ProducerLocationGUID WHERE (tblProducers.Closed = 0) ORDER BY tblProducerContacts.LName", new object[4]
      {
        (object) "@S",
        (object) "",
        (object) "@C",
        (object) ", "
      });
    this._ShowLocations = ShowLocations;
    this._ShowContacts = ShowContacts;
    this._ShowAll = ShowSelectAll;
    this._ReturnAll = ReturnAll;
    if (!this._ShowLocations)
      this._ShowContacts = false;
    this.PopulateTreeView(this._ShowAll, this._ShowLocations, this._ShowContacts);
    this.Description = labelText;
    this.InitialSize = this.Size;
  }

  private void PopulateTreeView(bool ShowAll, bool ShowLocations, bool ShowContacts)
  {
    if (ShowAll)
    {
      ProducersLocationsContacts.TreeItem treeItem = new ProducersLocationsContacts.TreeItem()
      {
        Level = -1,
        Display = "All Producer Contacts"
      };
      UltraTreeNode ultraTreeNode = this.treeProducersAndCo.Nodes.Add(Guid.Empty.ToString(), "All Producer Contacts");
      ((SubObjectBase) ultraTreeNode).Tag = (object) treeItem;
      this._ProducerLevelNodesCollection = ultraTreeNode.Nodes;
      this._ProducerLevel = 1;
      ultraTreeNode.Expanded = true;
    }
    else
    {
      this._ProducerLevelNodesCollection = this.treeProducersAndCo.Nodes;
      this._ProducerLevel = 0;
    }
    try
    {
      foreach (DataRow row in this._dtProducers.Rows)
      {
        ProducersLocationsContacts.TreeItem treeItem = new ProducersLocationsContacts.TreeItem()
        {
          Level = 0,
          Display = row["ProducerName"].ToString(),
          ProducerGUID = new Guid(row["ProducerGUID"].ToString())
        };
        ((SubObjectBase) this._ProducerLevelNodesCollection.Add(treeItem.ProducerGUID.ToString(), treeItem.Display)).Tag = (object) treeItem;
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
      foreach (DataRow row in this._dtLocations.Rows)
      {
        ProducersLocationsContacts.TreeItem treeItem = new ProducersLocationsContacts.TreeItem()
        {
          Level = 1,
          Display = row["ProducerLocationName"].ToString(),
          ProducerGUID = new Guid(row["ProducerGUID"].ToString()),
          ProducerLocationGUID = new Guid(row["ProducerLocationGUID"].ToString())
        };
        UltraTreeNode producerLevelNodes = this._ProducerLevelNodesCollection[treeItem.ProducerGUID.ToString()];
        if (!Information.IsNothing((object) producerLevelNodes) && !((DisposableObjectCollectionBase) producerLevelNodes.Nodes).Contains((object) treeItem.ProducerLocationGUID.ToString()))
          ((SubObjectBase) producerLevelNodes.Nodes.Add(treeItem.ProducerLocationGUID.ToString(), treeItem.Display)).Tag = (object) treeItem;
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
      foreach (DataRow row in this._dtContacts.Rows)
      {
        ProducersLocationsContacts.TreeItem treeItem = new ProducersLocationsContacts.TreeItem()
        {
          Level = 2,
          Display = row["ProducerContactName"].ToString(),
          ProducerGUID = new Guid(row["ProducerGUID"].ToString()),
          ProducerLocationGUID = new Guid(row["ProducerLocationGUID"].ToString()),
          ProducerContactGUID = new Guid(row["ProducerContactGUID"].ToString())
        };
        UltraTreeNode producerLevelNodes = this._ProducerLevelNodesCollection[treeItem.ProducerGUID.ToString()];
        if (!Information.IsNothing((object) producerLevelNodes))
        {
          UltraTreeNode node = producerLevelNodes.Nodes[treeItem.ProducerLocationGUID.ToString()];
          if (!Information.IsNothing((object) node) && !((DisposableObjectCollectionBase) node.Nodes).Contains((object) treeItem.ProducerContactGUID.ToString()))
            ((SubObjectBase) node.Nodes.Add(treeItem.ProducerContactGUID.ToString(), treeItem.Display)).Tag = (object) treeItem;
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

  private void treeProducersAndCo_BeforeCheck(object sender, BeforeCheckEventArgs e)
  {
    UltraTreeNode treeNode = ((CancelableNodeEventArgs) e).TreeNode;
    ProducersLocationsContacts.TreeItem tag = (ProducersLocationsContacts.TreeItem) ((SubObjectBase) treeNode).Tag;
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

  private void treeProducersAndCo_AfterCheck(object sender, NodeEventArgs e)
  {
    UltraTreeNode treeNode = e.TreeNode;
    ProducersLocationsContacts.TreeItem tag = (ProducersLocationsContacts.TreeItem) ((SubObjectBase) treeNode).Tag;
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
    ProducersLocationsContacts.TreeItem tag = (ProducersLocationsContacts.TreeItem) ((SubObjectBase) node.Parent).Tag;
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
    ((Control) this.treeProducersAndCo).Top = 0;
    this.lblDescription.Height = ((Control) this.treeProducersAndCo).Height;
    this.lblDescription.Top = 0;
    this.Height = ((Control) this.treeProducersAndCo).Height;
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
      return this._ReturnValue.ToString().Length <= int.MaxValue ? string.Empty : "Too many producer contacts selected.";
    }
  }

  private void SetTreeState(object value)
  {
    string str = value.ToString().Replace("'", "");
    if (this._ShowContacts)
    {
      ArrayList arrayList = new ArrayList((ICollection) str.Split(','));
      foreach (UltraTreeNode producerLevelNodes in this._ProducerLevelNodesCollection)
      {
        foreach (UltraTreeNode node1 in producerLevelNodes.Nodes)
        {
          foreach (UltraTreeNode node2 in node1.Nodes)
            node2.CheckedState = !arrayList.Contains((object) node2.Key) ? CheckState.Unchecked : CheckState.Checked;
        }
      }
    }
    if (!this._ShowContacts && this._ShowLocations && str.Length > 1)
    {
      DataTable dataTable = Database.Instance.QueryText.PerformTableQuery($"SELECT ProducerLocationGUID FROM tblProducerContacts WHERE ProducerContactGUID IN ({value.ToString()})");
      ArrayList arrayList = new ArrayList();
      try
      {
        foreach (DataRow row in dataTable.Rows)
          arrayList.Add((object) row["ProducerLocationGUID"].ToString());
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      foreach (UltraTreeNode producerLevelNodes in this._ProducerLevelNodesCollection)
      {
        foreach (UltraTreeNode node in producerLevelNodes.Nodes)
          node.CheckedState = !arrayList.Contains((object) node.Key) ? CheckState.Unchecked : CheckState.Checked;
      }
    }
    if (this._ShowContacts || this._ShowLocations || str.Length <= 1)
      return;
    DataTable dataTable1 = Database.Instance.QueryText.PerformTableQuery($"SELECT loc.ProducerGUID FROM tblProducerLocations AS loc INNER JOIN tblProducerContacts AS cont ON loc.ProducerLocationGUID = cont.ProducerLocationGUID WHERE cont.ProducerContactGUID IN ({value.ToString()})");
    ArrayList arrayList1 = new ArrayList();
    try
    {
      foreach (DataRow row in dataTable1.Rows)
        arrayList1.Add((object) row["ProducerGUID"].ToString());
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    foreach (UltraTreeNode producerLevelNodes in this._ProducerLevelNodesCollection)
      producerLevelNodes.CheckedState = !arrayList1.Contains((object) producerLevelNodes.Key) ? CheckState.Unchecked : CheckState.Checked;
  }

  private object CalculateReturnValue()
  {
    object returnValue;
    if (!Information.IsNothing(RuntimeHelpers.GetObjectValue(this._ReturnValue)))
      returnValue = this._ReturnValue;
    else if (this._ShowAll && !this._ReturnAll && this.treeProducersAndCo.Nodes[Guid.Empty.ToString()].CheckedState == CheckState.Checked)
    {
      returnValue = (object) Guid.Empty.ToString();
    }
    else
    {
      List<string> stringList1 = new List<string>();
      List<string> stringList2 = new List<string>();
      List<string> stringList3 = new List<string>();
      string str = "";
      if (this._ShowAll && this.treeProducersAndCo.Nodes[Guid.Empty.ToString()].CheckedState == CheckState.Checked)
      {
        DataTable dataTable = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT ProducerContactGUID FROM tblProducerContacts WITH (NOLOCK)");
        try
        {
          foreach (DataRow row in dataTable.Rows)
            stringList3.Add(row["ProducerContactGUID"].ToString());
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
        returnValue = (object) string.Join(",", stringList3.ToArray());
      }
      else
      {
        foreach (UltraTreeNode producerLevelNodes in this._ProducerLevelNodesCollection)
        {
          if (producerLevelNodes.CheckedState != CheckState.Unchecked)
          {
            stringList1.Add($"'{producerLevelNodes.Key}'");
            foreach (UltraTreeNode node1 in producerLevelNodes.Nodes)
            {
              if (node1.CheckedState != CheckState.Unchecked)
              {
                stringList2.Add($"'{node1.Key}'");
                foreach (UltraTreeNode node2 in node1.Nodes)
                {
                  if (node2.CheckedState != CheckState.Unchecked)
                    stringList3.Add(node2.Key);
                }
              }
            }
          }
        }
        if (this._ShowContacts)
          str = string.Join(",", stringList3.ToArray());
        if (!this._ShowContacts && this._ShowLocations && stringList2.Count > 0)
        {
          DataTable dataTable = Database.Instance.QueryText.PerformTableQuery($"SELECT ProducerContactGUID FROM tblProducerContacts WHERE ProducerLocationGUID IN ({string.Join(",", stringList2.ToArray())})");
          try
          {
            foreach (DataRow row in dataTable.Rows)
              stringList3.Add(row["ProducerContactGUID"].ToString());
          }
          finally
          {
            IEnumerator enumerator;
            if (enumerator is IDisposable)
              (enumerator as IDisposable).Dispose();
          }
          str = string.Join(",", stringList3.ToArray());
        }
        if (!this._ShowContacts && !this._ShowLocations && stringList1.Count > 0)
        {
          DataTable dataTable = Database.Instance.QueryText.PerformTableQuery($"SELECT cont.ProducerContactGUID FROM tblProducerLocations AS loc INNER JOIN tblProducerContacts AS cont ON loc.ProducerLocationGUID = cont.ProducerLocationGUID WHERE loc.ProducerGUID IN ({string.Join(",", stringList1.ToArray())})");
          try
          {
            foreach (DataRow row in dataTable.Rows)
              stringList3.Add(row["ProducerContactGUID"].ToString());
          }
          finally
          {
            IEnumerator enumerator;
            if (enumerator is IDisposable)
              (enumerator as IDisposable).Dispose();
          }
          str = string.Join(",", stringList3.ToArray());
        }
        returnValue = (object) str;
      }
    }
    return returnValue;
  }

  private class TreeItem
  {
    public int Level;
    public Guid ProducerGUID;
    public Guid ProducerLocationGUID;
    public Guid ProducerContactGUID;
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
