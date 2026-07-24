// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.Forms.Mvc.DatabaseRecords.W9.Controller.IW9Controller
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using MGASystems.Common.MVC.BaseClasses.Controller;
using MGASystems.IMS.Accounting.Services.Forms.MVC.Address.Controller;
using MGASystems.IMS.Accounting.Services.Forms.MVC.DataDrivenComboOtherEdit.Controller;
using MGASystems.IMS.Accounting.Services.Forms.MVC.ToolbarEdit;
using System;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.Forms.Mvc.DatabaseRecords.W9.Controller;

public interface IW9Controller : IMvcController, ITopControlController, IRequestParentSize
{
  IAddressController AddressController { get; }

  IDataDrivenComboOtherEditController EntityTypeController { get; }

  void RequestSetTaxingEntity(string taxingEntity);

  void RequestSetBusinessName(string businessName);

  void RequestSetTinEin(string tinEin);

  void RequestSetW9Date(DateTime? date);

  void RequestSetEntityGuid(Guid guid);

  void RequestSearchAccountingEntity();

  void RequestSetAddressEnableState(bool enabled);

  void RequestSetTinEinEnableState(bool enabled);

  void RequestSetSearchEnabledState(bool enabled);
}
