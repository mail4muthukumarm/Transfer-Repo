// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.Forms.Mvc.DatabaseRecords.W9.View.IW9View
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using MGASystems.Common.MVC.BaseClasses.View;
using System;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.Forms.Mvc.DatabaseRecords.W9.View;

public interface IW9View : IMvcView, IModelObserver
{
  void UserSetTinEin(string text);

  void UserSetBusinessName(string text);

  void UserSetTaxingEntity(string text);

  void UserSetW9Date(DateTime? date);

  void UserSearchAccountingEntity();

  void SetAddressEnableState(bool enabled);

  void SetTinEinEnableState(bool enabled);

  void SetSearchEnabledState(bool enabled);
}
