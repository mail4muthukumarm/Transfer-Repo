// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.Forms.Mvc.SettlementApproval.Controller.IPendingApprovalSettlementGridController
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using MGASystems.Common.MVC.BaseClasses.Controller;
using MGASystems.IMS.Accounting.Core.Forms.Mvc.SettlementApproval.Model;
using MGASystems.IMS.Accounting.Services.Forms.MVC.ToolbarEdit;
using MGASystems.IMS.Accounting.Services.Forms.MVC.WrappedUltraGridControl.Controller;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.Forms.Mvc.SettlementApproval.Controller;

public interface IPendingApprovalSettlementGridController : 
  ISaveDataController,
  IMvcController,
  IWrappedUltraGridController<IPendingApprovalSettlementModel>,
  IWrappedUltraGridController,
  ITopControlController,
  IRequestParentSize
{
  void ApproveAll();

  void RejectAll();

  void SetFilter();

  void ViewSelectedTransaction();
}
