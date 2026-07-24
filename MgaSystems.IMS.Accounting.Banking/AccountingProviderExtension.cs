// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Banking.AccountingProviderExtension
// Assembly: MgaSystems.IMS.Accounting.Banking, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: ED5B99DC-3DD2-44AB-BA36-49A11A94937D
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Banking.dll

using MGASystems.IMS.Accounting.Interfaces;
using System;

#nullable disable
namespace MGASystems.IMS.Accounting.Banking;

public class AccountingProviderExtension : IAccountingExplorerProviderExtensions
{
  private Type _formType;
  private bool _showModal;
  private string _securityGuid;

  private AccountingProviderExtension()
  {
  }

  public AccountingProviderExtension(Type formType, bool showModal, string securityGuid)
  {
    this._formType = formType;
    this._securityGuid = securityGuid;
    this._showModal = showModal;
  }

  public Type FormType => this._formType;

  public string SecurityGuid => this._securityGuid;

  public bool ShowFormModal => this._showModal;
}
