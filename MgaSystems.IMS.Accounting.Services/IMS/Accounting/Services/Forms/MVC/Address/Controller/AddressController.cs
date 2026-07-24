// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.Forms.MVC.Address.Controller.AddressController
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using MGASystems.Common;
using MGASystems.Common.MVC.BaseClasses.Controller;
using MGASystems.IMS.Accounting.Services.Forms.MVC.Address.Model;
using MGASystems.IMS.Accounting.Services.Forms.MVC.Address.View;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.Forms.MVC.Address.Controller;

[Override(typeof (IAddressController))]
public class AddressController : 
  MvcControllerBase<IAddressModel, IAddressView>,
  IAddressController,
  IMvcController
{
  public void RequestSetCity(string city) => this.Model.City = city;

  public void RequestSetAddress1(string address1) => this.Model.Address1 = address1;

  public void RequestSetAddress2(string address2) => this.Model.Address2 = address2;

  public void RequestSetState(string state) => this.Model.State = state;

  public void RequestSetZipCode(string zipCode) => this.Model.ZipCode = zipCode;

  public void RequestSetZipCodeExtension(string zipExt) => this.Model.ZipCodeExtension = zipExt;

  public void RequestSetISOCountryCode(string isoCountryCode)
  {
    this.Model.CountryCode = isoCountryCode;
  }
}
