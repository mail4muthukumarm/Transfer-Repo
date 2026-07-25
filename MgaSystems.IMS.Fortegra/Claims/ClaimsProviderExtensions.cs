// Decompiled with JetBrains decompiler
// Type: MgaSystems.Ims.Fortegra.Claims.ClaimsProviderExtensions
// Assembly: MgaSystems.Ims.Fortegra, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27007E94-85B4-4A1A-9444-255CCA5487B0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Fortegra.dll

using MGASystems.IMS.Claims;
using System;

#nullable disable
namespace MgaSystems.Ims.Fortegra.Claims;

public class ClaimsProviderExtensions : IClaimsExplorerProviderExtensions
{
  public ClaimsProviderExtensions(Type formType, bool showModal, string securityGuid)
  {
    this.ShowFormModal = showModal;
    this.FormType = formType;
    this.SecurityGuid = securityGuid;
  }

  public bool ShowFormModal { get; }

  public Type FormType { get; }

  public string SecurityGuid { get; }
}
