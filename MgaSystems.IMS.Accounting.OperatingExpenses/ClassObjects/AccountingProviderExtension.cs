// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.OperatingExpenses.ClassObjects.AccountingProviderExtension
// Assembly: MgaSystems.IMS.Accounting.OperatingExpenses, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 77B4DED4-9019-44D3-8D52-4669B0CA70E1
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.OperatingExpenses.dll

using MGASystems.IMS.Accounting.Interfaces;
using System;

#nullable disable
namespace MGASystems.IMS.Accounting.OperatingExpenses.ClassObjects;

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
    this._showModal = showModal;
    this._securityGuid = securityGuid;
  }

  public Type FormType => this._formType;

  public string SecurityGuid => this._securityGuid;

  public bool ShowFormModal => this._showModal;
}
