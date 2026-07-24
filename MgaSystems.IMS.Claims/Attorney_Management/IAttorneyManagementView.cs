// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.Attorney_Management.IAttorneyManagementView
// Assembly: MgaSystems.IMS.Claims, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FCD9D0B7-28CF-40B9-8EB7-297871E1AF5F
// Assembly location: F:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims.dll

using MGASystems.Common.MVC.BaseClasses.View;
using System;

#nullable disable
namespace MGASystems.IMS.Claims.Attorney_Management;

public interface IAttorneyManagementView : IMvcView, IModelObserver
{
  void SetAttorneyGuid(Guid guid);

  void SetAttorneyType(string text);

  void SetAttorneyName(string text);

  void SetLawFirm(string text);

  void SetAttorneyEntityType(string text);

  void SetFEINSSN(string text);

  void SetPhoneNumber(string text);

  void SetFaxNumber(string text);
}
