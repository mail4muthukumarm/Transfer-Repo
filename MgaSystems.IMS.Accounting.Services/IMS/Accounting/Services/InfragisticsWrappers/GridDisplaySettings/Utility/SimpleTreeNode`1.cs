// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.InfragisticsWrappers.GridDisplaySettings.Utility.SimpleTreeNode`1
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using MGASystems.Data.CommonInterface;
using System;
using System.Collections.Generic;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.InfragisticsWrappers.GridDisplaySettings.Utility;

public class SimpleTreeNode<TNode> : UniqueObject<string>
{
  public override string UniqueIdentifier { get; }

  public virtual TNode Node { get; }

  public virtual List<SimpleTreeNode<TNode>> ChildNodes { get; }

  public SimpleTreeNode(TNode node, string uniqueIdentifier)
  {
    this.Node = (object) node != null ? node : throw new ArgumentNullException(nameof (node));
    this.UniqueIdentifier = uniqueIdentifier ?? throw new ArgumentNullException(nameof (UniqueIdentifier));
    this.ChildNodes = new List<SimpleTreeNode<TNode>>();
  }

  public virtual void AddChildNode(SimpleTreeNode<TNode> node) => this.ChildNodes.Add(node);
}
