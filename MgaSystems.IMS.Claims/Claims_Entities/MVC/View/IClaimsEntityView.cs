// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.Claims_Entities.MVC.View.IClaimsEntityView
// Assembly: MgaSystems.IMS.Claims, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FCD9D0B7-28CF-40B9-8EB7-297871E1AF5F
// Assembly location: F:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims.dll

using MGASystems.Common.MVC.BaseClasses.View;

#nullable disable
namespace MGASystems.IMS.Claims.Claims_Entities.MVC.View;

public interface IClaimsEntityView : IMvcView, IModelObserver
{
  void SetEntityType(int id, string text);

  void SetEntityName(string text);

  void SetDBA(string text);

  void SetFirstName(string text);

  void SetMiddleName(string text);

  void SetLastName(string text);

  void SetFEINSSN(string text);

  void SetContactName(string text);

  void SetPhoneNumber(string text);

  void SetFaxNumber(string text);
}
