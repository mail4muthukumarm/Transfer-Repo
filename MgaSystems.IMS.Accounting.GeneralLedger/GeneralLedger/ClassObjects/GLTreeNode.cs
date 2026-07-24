// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.GeneralLedger.ClassObjects.GLTreeNode
// Assembly: MgaSystems.IMS.Accounting.GeneralLedger, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: DC511D5D-5AA9-4B52-8578-E2A0BCB046C3
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Accounting.GeneralLedger.dll

using Infragistics.Shared;
using Infragistics.Win.UltraWinTree;

#nullable disable
namespace MGASystems.IMS.Accounting.GeneralLedger.ClassObjects;

public sealed class GLTreeNode : UltraTreeNode
{
  private string _glAcctFullname;
  private string _glAcctShortName;
  private int _glAcctID;
  private bool _IsControlNode;
  private GLAccount _glAccount;
  private GLClass glClass;
  private bool isLocationNode;
  private bool isMasterAccountNode;
  private string masterAccountLoadType;
  private bool allowLoadChildren;
  private int glCompanyId;
  private bool isBankAccount;

  internal string GLAccountFullName
  {
    get => this._glAcctFullname;
    set
    {
      this._glAcctFullname = value;
      this.Text = value;
    }
  }

  internal GLAccount GlAccount
  {
    get => this._glAccount;
    set
    {
      this._glAccount = value;
      ((KeyedSubObjectBase) this).Key = this._glAccount.GLAccountID.ToString();
      this.glCompanyId = this._glAccount.GLCompanyId;
      this.Text = $"{value.AccountShortName}   ({value.GlAccountNumber})";
    }
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

  internal bool IsControlNode => this._IsControlNode;

  internal bool IsLocationNode
  {
    get => this.isLocationNode;
    set => this.isLocationNode = value;
  }

  internal bool IsMasterAccountNode
  {
    get => this.isMasterAccountNode;
    set => this.isMasterAccountNode = value;
  }

  internal string MasterAccountLoadType
  {
    get => this.masterAccountLoadType;
    set => this.masterAccountLoadType = value;
  }

  internal bool AllowLoadChildren
  {
    get => this.allowLoadChildren;
    set => this.allowLoadChildren = value;
  }

  internal int GlCompanyId
  {
    get => this.glCompanyId;
    set => this.glCompanyId = value;
  }

  public GLClass GLAccountClass
  {
    get => this.glClass;
    set => this.glClass = value;
  }

  public bool IsBankAccount
  {
    get => this.isBankAccount;
    set => this.isBankAccount = value;
  }

  public GLTreeNode(bool isControlNode) => this._IsControlNode = isControlNode;

  public GLTreeNode(int glAccountId, bool isControlNode)
  {
    this._IsControlNode = isControlNode;
    this.LoadGLAccount(glAccountId);
  }

  private void LoadGLAccount(int glAccountId)
  {
    this.GlAccount = new GLAccount(glAccountId);
    ((KeyedSubObjectBase) this).Key = this.GlAccount.GLAccountID.ToString();
    this.Text = this.GlAccount.AccountShortName;
  }

  public void RefreshNode()
  {
    if (this.GlAccount == null)
      return;
    this.GlAccount = new GLAccount(this.GlAccount.GLAccountID);
  }

  protected override void OnDispose()
  {
  }
}
