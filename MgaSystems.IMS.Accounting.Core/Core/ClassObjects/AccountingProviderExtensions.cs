// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.ClassObjects.AccountingProviderExtensions
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using MGASystems.IMS.Accounting.Interfaces;
using System;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.ClassObjects;

public class AccountingProviderExtensions : IAccountingExplorerProviderExtensions
{
  private bool _showModal;
  private Type _formType;
  private string _securityGuid;

  public AccountingProviderExtensions(Type formType, bool showModal, string securityGuid)
  {
    this._showModal = showModal;
    this._formType = formType;
    this._securityGuid = securityGuid;
  }

  public bool ShowFormModal => this._showModal;

  public Type FormType => this._formType;

  public string SecurityGuid => this._securityGuid;
}
