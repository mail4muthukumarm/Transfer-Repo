// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.Claim_Location_Settings.ILocationSettingsController
// Assembly: MgaSystems.IMS.Claims, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FCD9D0B7-28CF-40B9-8EB7-297871E1AF5F
// Assembly location: F:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims.dll

using MGASystems.Common.MVC.BaseClasses.Controller;
using MGASystems.IMS.Accounting.Services.Forms.MVC.ToolbarEdit;
using System;

#nullable disable
namespace MGASystems.IMS.Claims.Claim_Location_Settings;

public interface ILocationSettingsController : IMvcController, ITopControlController
{
  void RequestSetQuotingOfficeGuid(Guid id);

  void RequestSetQuotingOfficeId(int id, string text);

  void RequestSetClaimsOfficeId(int id, string text);

  void RequestSetGLAcctId(int id, string text);
}
