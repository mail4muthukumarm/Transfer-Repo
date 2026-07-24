// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.NoteDocuments.TreeNodeStructureSerializer
// Assembly: MgaSystems.IMS.NotesDocuments, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 3F898CF7-066D-4B05-A9F1-D37DBC4FAA16
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.NotesDocuments.dll

using Infragistics.Win.UltraWinTree;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;

#nullable disable
namespace MGASystems.IMS.NoteDocuments;

public class TreeNodeStructureSerializer
{
  private List<string> _expandedNodes;
  private List<string> _selectedNodes;
  private UltraTree _tree;
  private string _activeNodeKey;

  public TreeNodeStructureSerializer(UltraTree tree)
  {
    this._expandedNodes = new List<string>();
    this._selectedNodes = new List<string>();
    this._tree = tree;
  }

  public void SaveStructure() => this.SaveStructure(true);

  public void SaveStructure(bool saveCurrentNode)
  {
    if (this._tree.Nodes.Count == 0)
      return;
    if (saveCurrentNode)
    {
      if (this._tree != null && this._tree.ActiveNode != null && this._tree.ActiveNode.Key != null)
        this._activeNodeKey = this._tree.ActiveNode.Key;
    }
    else
      this._activeNodeKey = (string) null;
    UltraTreeNode[] allNodes = this.GetAllNodes();
    this._selectedNodes.Clear();
    this._expandedNodes.Clear();
    UltraTreeNode[] ultraTreeNodeArray = allNodes;
    int index = 0;
    while (index < ultraTreeNodeArray.Length)
    {
      UltraTreeNode ultraTreeNode = ultraTreeNodeArray[index];
      if (ultraTreeNode.Expanded && !this._expandedNodes.Contains(ultraTreeNode.Key))
        this._expandedNodes.Add(ultraTreeNode.Key);
      if (ultraTreeNode.Selected && !this._selectedNodes.Contains(ultraTreeNode.Key))
        this._selectedNodes.Add(ultraTreeNode.Key);
      checked { ++index; }
    }
  }

  public void ApplyStructure()
  {
    if (this._tree.Nodes.Count == 0)
      return;
    UltraTreeNode[] allNodes = this.GetAllNodes();
    List<string> stringList1 = new List<string>();
    List<string> stringList2 = new List<string>();
    try
    {
      foreach (string expandedNode in this._expandedNodes)
        stringList2.Add(expandedNode);
    }
    finally
    {
      List<string>.Enumerator enumerator;
      enumerator.Dispose();
    }
    UltraTreeNode[] ultraTreeNodeArray1 = allNodes;
    int index1 = 0;
    while (index1 < ultraTreeNodeArray1.Length)
    {
      UltraTreeNode ultraTreeNode = ultraTreeNodeArray1[index1];
      if (stringList2.Contains(ultraTreeNode.Key))
      {
        ultraTreeNode.Expanded = true;
        stringList2.Remove(ultraTreeNode.Key);
      }
      checked { ++index1; }
    }
    int num = -1;
    while (stringList2.Count > 0 && num != 0)
    {
      num = 0;
      UltraTreeNode[] ultraTreeNodeArray2 = allNodes;
      int index2 = 0;
      while (index2 < ultraTreeNodeArray2.Length)
      {
        UltraTreeNode ultraTreeNode = ultraTreeNodeArray2[index2];
        if (stringList2.Contains(ultraTreeNode.Key))
        {
          ultraTreeNode.Expanded = true;
          stringList2.Remove(ultraTreeNode.Key);
          ++num;
        }
        checked { ++index2; }
      }
    }
    if (this._selectedNodes.Count > 0)
    {
      UltraTreeNode[] ultraTreeNodeArray3 = allNodes;
      int index3 = 0;
      while (index3 < ultraTreeNodeArray3.Length)
      {
        UltraTreeNode ultraTreeNode = ultraTreeNodeArray3[index3];
        if (this._selectedNodes.Contains(ultraTreeNode.Key))
          ultraTreeNode.Selected = true;
        checked { ++index3; }
      }
    }
    if (this._activeNodeKey == null || this._activeNodeKey.Length <= 0)
      return;
    UltraTreeNode nodeByKey = this._tree.GetNodeByKey(this._activeNodeKey);
    if (nodeByKey == null)
      return;
    try
    {
      this._tree.ActiveNode = nodeByKey;
      nodeByKey.Selected = true;
      if (!nodeByKey.Control.HideSelection)
        return;
      nodeByKey.Control.HideSelection = false;
    }
    catch (ArgumentException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ProjectData.ClearProjectError();
    }
  }

  private UltraTreeNode[] GetAllNodes() => this.GetNodes(this._tree.Nodes).ToArray();

  private List<UltraTreeNode> GetNodes(TreeNodesCollection nodes)
  {
    List<UltraTreeNode> nodes1 = new List<UltraTreeNode>();
    foreach (UltraTreeNode node in nodes)
    {
      nodes1.Add(node);
      if (node.Nodes.Count > 0)
        nodes1.AddRange((IEnumerable<UltraTreeNode>) this.GetNodes(node.Nodes));
    }
    return nodes1;
  }
}
