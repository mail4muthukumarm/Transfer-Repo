// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.GeneralLedger.ClassObjects.AccountingProviderExtensions
// Assembly: MgaSystems.IMS.Accounting.GeneralLedger, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: DC511D5D-5AA9-4B52-8578-E2A0BCB046C3
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Accounting.GeneralLedger.dll

using MGASystems.IMS.Accounting.Interfaces;
using System;

#nullable disable
namespace MGASystems.IMS.Accounting.GeneralLedger.ClassObjects;

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
