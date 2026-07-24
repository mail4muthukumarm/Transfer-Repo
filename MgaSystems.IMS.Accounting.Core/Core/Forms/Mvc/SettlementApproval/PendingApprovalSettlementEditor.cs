// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.Forms.Mvc.SettlementApproval.PendingApprovalSettlementEditor
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using MGASystems.Common;
using MGASystems.IMS.Accounting.Core.Forms.Mvc.SettlementApproval.Controller;
using MGASystems.IMS.Accounting.Core.Forms.Mvc.SettlementApproval.Model;
using MGASystems.IMS.Accounting.Services.Forms.MVC.WrappedUltraGridControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.Forms.Mvc.SettlementApproval;

[SecureResource("{0B82413E-D6D3-4F80-81E2-27BC5D5D3EEC}", "Pending Settlement Approval Management", "Determines if users can approve or reject transactions sending out money.", "Accounting")]
public class PendingApprovalSettlementEditor : 
  GridForm<IPendingApprovalSettlementModel, IPendingApprovalSettlementGridController, PendingApprovalSettlementGridModel>
{
  public PendingApprovalSettlementEditor()
    : base(ObjectFactory.Instance.CreateObjectAs<PendingApprovalSettlementGridModel>(), ObjectFactory.Instance.CreateObjectAs<IPendingApprovalSettlementGridController>())
  {
  }

  protected override void ChildAfterLoad() => this.Controller.SetFilter();

  protected override void OnClosing(CancelEventArgs e)
  {
    if (this.DialogResult == DialogResult.Cancel && ((IEnumerable<IPendingApprovalSettlementModel>) this.Model.DisplayItems).Any<IPendingApprovalSettlementModel>((Func<IPendingApprovalSettlementModel, bool>) (model => model.HasChanges())))
    {
      bool flag = this.View.DisplayYesNo("Closing the form will cause any unsaved data to be lost. Continue?", "Unsaved data may be lost");
      e.Cancel = !flag;
    }
    base.OnClosing(e);
  }
}
