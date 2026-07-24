// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.Forms.MVC.Address.Controller.IAddressController
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using MGASystems.Common.MVC.BaseClasses.Controller;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.Forms.MVC.Address.Controller;

public interface IAddressController : IMvcController
{
  void RequestSetAddress1(string line1);

  void RequestSetAddress2(string line2);

  void RequestSetCity(string city);

  void RequestSetState(string state);

  void RequestSetZipCode(string zipCode);

  void RequestSetZipCodeExtension(string zipExt);

  void RequestSetISOCountryCode(string isoCountryCode);
}
