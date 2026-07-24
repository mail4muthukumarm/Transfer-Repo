// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Controls.GLTreeNode
// Assembly: MgaSystems.IMS.Accounting.Controls, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 69E8E7CF-F3E0-45A9-94CD-B8A0D33430C8
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Accounting.Controls.dll

using Infragistics.Win.UltraWinTree;
using Microsoft.VisualBasic.CompilerServices;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Accounting.Controls;

internal sealed class GLTreeNode : UltraTreeNode
{
  private string _glAcctFullname;
  private string _glAcctShortName;
  private int _glAcctID;
  private bool _CloneChildren;
  private bool _IsControlNode;
  private string _glAccountNumber;

  internal string GLAccountFullName
  {
    get => this._glAcctFullname;
    set
    {
      this._glAcctFullname = value;
      this.Text = value;
    }
  }

  internal bool CloneChildren
  {
    get => this._CloneChildren;
    set => this._CloneChildren = value;
  }

  internal string GLAccountShortName
  {
    get => this._glAcctShortName;
    set => this._glAcctShortName = value;
  }

  internal int GLAccountID
  {
    get => this._glAcctID;
    set => this._glAcctID = value;
  }

  internal string GLAccountNumber
  {
    get => this._glAccountNumber;
    set => this._glAccountNumber = value;
  }

  internal bool IsControlNode => this._IsControlNode;

  public GLTreeNode(bool ControlNode) => this._IsControlNode = ControlNode;

  protected override void OnDispose()
  {
  }

  public override object Clone()
  {
    GLTreeNode glTreeNode;
    if (Operators.CompareString(this.Text, string.Empty, false) != 0)
    {
      glTreeNode = new GLTreeNode(this.IsControlNode);
      glTreeNode._glAcctFullname = this.GLAccountFullName;
      glTreeNode._glAcctID = this.GLAccountID;
      glTreeNode._glAcctShortName = this.GLAccountShortName;
      glTreeNode._glAccountNumber = this.GLAccountNumber;
    }
    else
    {
      glTreeNode = new GLTreeNode(this.IsControlNode);
      glTreeNode._glAcctFullname = this.GLAccountFullName;
      glTreeNode._glAcctID = this.GLAccountID;
      glTreeNode._glAcctShortName = this.GLAccountShortName;
      glTreeNode._glAccountNumber = this.GLAccountNumber;
    }
    UltraTreeNode ultraTreeNode = (UltraTreeNode) base.Clone();
    ultraTreeNode.Nodes.Clear();
    glTreeNode.InitializeFrom(ultraTreeNode);
    object obj;
    if (!this.HasNodes | !this.CloneChildren)
      obj = (object) glTreeNode;
    else if (this.CloneChildren)
    {
      int num = this.Nodes.Count - 1;
      for (int index = 0; index <= num; ++index)
      {
        if (!Versioned.IsNumeric((object) this.Nodes[index].Key) || int.Parse(this.Nodes[index].Key) >= 0)
          ((GLTreeNode) this.Nodes[index]).CloneChildren = this.CloneChildren;
        glTreeNode.Nodes.Add(RuntimeHelpers.GetObjectValue(this.Nodes[index].Clone()));
      }
      obj = (object) glTreeNode;
    }
    else
      obj = (object) null;
    return obj;
  }
}
