// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.Forms.Mvc.ChargeCodeGLAccountMapping.UserInterface.ChargeCodeGLAccountMappingEditor
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using MGASystems.Common;
using MGASystems.IMS.Accounting.Core.Forms.Mvc.ChargeCodeGLAccountMapping.Controller;
using MGASystems.IMS.Accounting.Core.Forms.Mvc.ChargeCodeGLAccountMapping.Model;
using MGASystems.IMS.Accounting.Services.Forms.MVC.WrappedUltraGridControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.Forms.Mvc.ChargeCodeGLAccountMapping.UserInterface;

[SecureResource("{E06DEBA8-3FC9-429F-A1E7-938DE99AD1A1}", "Charge Code GL Account Mapping Management", "Determines if users can create and edit mappings that cause charge codes to post against specific GL Accounts instead of Accounts Payable.", "Accounting")]
public class ChargeCodeGLAccountMappingEditor : 
  GridForm<IChargeCodeGLAccountMappingModel, IChargeCodeGLAccountMappingGridController, IChargeCodeGLAccountMappingGridModel>
{
  public const string SECURITY_ID = "{E06DEBA8-3FC9-429F-A1E7-938DE99AD1A1}";

  public ChargeCodeGLAccountMappingEditor()
    : base(ObjectFactory.Instance.CreateObjectAs<IChargeCodeGLAccountMappingGridModel>(), ObjectFactory.Instance.CreateObjectAs<IChargeCodeGLAccountMappingGridController>())
  {
  }

  protected override void OnClosing(CancelEventArgs e)
  {
    if (this.DialogResult == DialogResult.Cancel && ((IEnumerable<IChargeCodeGLAccountMappingModel>) this.Model.DisplayItems).Any<IChargeCodeGLAccountMappingModel>((Func<IChargeCodeGLAccountMappingModel, bool>) (item => item.HasChanges())))
    {
      bool flag = this.View.DisplayYesNo("Closing the form will cause any unsaved data to be lost. Continue?", "Unsaved data may be lost");
      e.Cancel = !flag;
    }
    base.OnClosing(e);
  }
}
