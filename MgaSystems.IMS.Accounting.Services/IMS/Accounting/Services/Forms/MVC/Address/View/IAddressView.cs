// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.Forms.MVC.Address.View.IAddressView
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using MGASystems.Common.MVC.BaseClasses.View;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.Forms.MVC.Address.View;

public interface IAddressView : IMvcView, IModelObserver
{
  void UserSetAddress1(string address1);

  void UserSetAddress2(string address2);

  void UserSetCity(string city);

  void UserSetState(string state);

  void UserSetZipCode(string zipCode);

  void UserSetZipCodeExtension(string zipCodeExtension);

  void UserSetISOCountryCode(string isoCountryCode);
}
