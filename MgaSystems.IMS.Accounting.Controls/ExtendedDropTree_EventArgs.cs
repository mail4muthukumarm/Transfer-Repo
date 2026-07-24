// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Controls.ExtendedDropTree_EventArgs
// Assembly: MgaSystems.IMS.Accounting.Controls, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 69E8E7CF-F3E0-45A9-94CD-B8A0D33430C8
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Accounting.Controls.dll

using Infragistics.Win.UltraWinTree;
using System;

#nullable disable
namespace MGASystems.IMS.Accounting.Controls;

public sealed class ExtendedDropTree_EventArgs : EventArgs
{
  private UltraTreeNode m_node;
  private string m_selectedValue;
  private string m_selectedKey;
  private string m_selectedText;

  public string SelectedValue => this.m_selectedValue;

  public string SelectedKey => this.m_selectedKey;

  public string SelectedText => this.m_selectedText;

  public UltraTreeNode Node => this.m_node;

  public ExtendedDropTree_EventArgs(string mValue, string mKey, string mText, UltraTreeNode mNode)
  {
    this.m_selectedValue = mValue;
    this.m_selectedKey = mKey;
    this.m_selectedText = mText;
    this.m_node = mNode;
  }
}
