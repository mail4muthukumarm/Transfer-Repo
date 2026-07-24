// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.InfragisticsWrappers.GridDisplaySettings.Utility.SimpleTreeExtensions
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.InfragisticsWrappers.GridDisplaySettings.Utility;

public static class SimpleTreeExtensions
{
  public static SimpleTreeNode<TNode> ToSimpleTree<TNode>(
    this IEnumerable<TNode> allNodes,
    Func<TNode, TNode> getParentFunc,
    Func<TNode, string> getIdFunc)
  {
    if (allNodes == null)
      throw new ArgumentNullException(nameof (allNodes));
    if (getParentFunc == null)
      throw new ArgumentNullException(nameof (getParentFunc));
    if (getIdFunc == null)
      throw new ArgumentNullException(nameof (getIdFunc));
    return SimpleTreeExtensions.OrganizeBandsIntoTree<TNode>(allNodes, getParentFunc, getIdFunc);
  }

  private static SimpleTreeNode<TNode> OrganizeBandsIntoTree<TNode>(
    IEnumerable<TNode> allNodes,
    Func<TNode, TNode> getParentFunc,
    Func<TNode, string> getIdFunc)
  {
    TNode node1 = allNodes.Single<TNode>((Func<TNode, bool>) (node => (object) getParentFunc(node) == null));
    SimpleTreeNode<TNode> parentNode = new SimpleTreeNode<TNode>(node1, getIdFunc(node1));
    SimpleTreeExtensions.AddSubNodes<TNode>(allNodes, parentNode, getParentFunc, getIdFunc);
    return parentNode;
  }

  private static void AddSubNodes<TNode>(
    IEnumerable<TNode> allNodes,
    SimpleTreeNode<TNode> parentNode,
    Func<TNode, TNode> getParentFunc,
    Func<TNode, string> getIdFunc)
  {
    foreach (TNode allNode in allNodes)
    {
      TNode node = getParentFunc(allNode);
      ref TNode local = ref node;
      if (((object) local != null ? (local.Equals((object) parentNode.Node) ? 1 : 0) : 0) != 0)
      {
        SimpleTreeNode<TNode> simpleTreeNode = new SimpleTreeNode<TNode>(allNode, getIdFunc(allNode));
        SimpleTreeExtensions.AddSubNodes<TNode>(allNodes, simpleTreeNode, getParentFunc, getIdFunc);
        parentNode.AddChildNode(simpleTreeNode);
      }
    }
  }
}
