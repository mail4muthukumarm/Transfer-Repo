// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.Claims_Entities.MVC.Controller.IClaimsEntityController
// Assembly: MgaSystems.IMS.Claims, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FCD9D0B7-28CF-40B9-8EB7-297871E1AF5F
// Assembly location: F:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims.dll

using MGASystems.Common.MVC.BaseClasses.Controller;
using MGASystems.IMS.Accounting.Services.Forms.MVC.Address.Controller;
using MGASystems.IMS.Accounting.Services.Forms.MVC.ToolbarEdit;
using System;

#nullable disable
namespace MGASystems.IMS.Claims.Claims_Entities.MVC.Controller;

public interface IClaimsEntityController : IMvcController, ITopControlController
{
  IAddressController AddressController { get; }

  void RequestSetEntityGuid(Guid guid);

  void RequestSetEntityType(int id, string text);

  void RequestSetEntityName(string text);

  void RequestSetDBA(string text);

  void RequestSetFirstName(string text);

  void RequestSetMiddleName(string text);

  void RequestSetLastName(string text);

  void RequestSetFEINSSN(string text);

  void RequestSetContactName(string text);

  void RequestSetPhoneNumber(string text);

  void RequestSetFaxNumber(string text);
}
