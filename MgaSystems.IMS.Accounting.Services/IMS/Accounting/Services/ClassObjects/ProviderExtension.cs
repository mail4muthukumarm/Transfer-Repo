// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.ClassObjects.ProviderExtension
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using MGASystems.IMS.Accounting.Interfaces;
using System;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.ClassObjects;

public class ProviderExtension : IAccountingExplorerProviderExtensions
{
  private Type _formType;
  private bool _showModal;
  private string _securityGuid;

  private ProviderExtension()
  {
  }

  public ProviderExtension(Type formType, bool showModal, string securityGuid)
  {
    this._formType = formType;
    this._showModal = showModal;
    this._securityGuid = securityGuid;
  }

  public Type FormType => this._formType;

  public string SecurityGuid => this._securityGuid;

  public bool ShowFormModal => this._showModal;
}
