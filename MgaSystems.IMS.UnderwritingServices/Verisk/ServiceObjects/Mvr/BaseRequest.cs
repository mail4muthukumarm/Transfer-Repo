// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.UnderwritingServices.Verisk.ServiceObjects.Mvr.BaseRequest
// Assembly: MgaSystems.IMS.UnderwritingServices, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 4E63F408-1B27-4004-B8D3-2C6361F8A9AF
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.UnderwritingServices.dll

#nullable disable
namespace MgaSystems.IMS.UnderwritingServices.Verisk.ServiceObjects.Mvr;

public abstract class BaseRequest
{
  public BaseRequest()
  {
  }

  protected BaseRequest(BaseRequest fromBase)
  {
    this.RequestVersion = fromBase.RequestVersion;
    this.UserName = fromBase.UserName;
    this.UserPassword = fromBase.UserPassword;
    this.AccountId = fromBase.AccountId;
    this.BillingCode = fromBase.BillingCode;
  }

  public string RequestVersion { get; set; } = "00";

  public string UserName { get; set; }

  public string UserPassword { get; set; }

  public string AccountId { get; set; }

  public string BillingCode { get; set; }

  public string Product { get; protected set; } = "MVR";

  public string UserNameOrDefault(string defaultUsername)
  {
    return !string.IsNullOrEmpty(this.UserName) ? this.UserName : defaultUsername;
  }

  public string UserPasswordOrDefault(string defaultPassword)
  {
    return !string.IsNullOrEmpty(this.UserPassword) ? this.UserPassword : defaultPassword;
  }

  public string AccountIdOrDefault(string defaultAccountId)
  {
    return !string.IsNullOrEmpty(this.AccountId) ? this.AccountId : defaultAccountId;
  }

  public string BillingCodeOrDefault(string defaultBillingCode)
  {
    return !string.IsNullOrEmpty(this.BillingCode) ? this.BillingCode : defaultBillingCode;
  }
}
