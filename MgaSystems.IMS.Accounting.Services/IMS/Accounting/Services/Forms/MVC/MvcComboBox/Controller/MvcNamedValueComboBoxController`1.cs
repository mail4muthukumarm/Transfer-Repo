// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.Forms.MVC.MvcComboBox.Controller.MvcNamedValueComboBoxController`1
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using MGASystems.Common.MVC.BaseClasses.Controller;
using MGASystems.Data.CommonInterface;
using System;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.Forms.MVC.MvcComboBox.Controller;

public class MvcNamedValueComboBoxController<TDisplayItem> : 
  MvcComboBoxController<TDisplayItem>,
  IMvcNamedValueComboBoxController<TDisplayItem>,
  IMvcComboBoxController<TDisplayItem>,
  IMvcComboBoxController,
  IMvcController
  where TDisplayItem : class, INamedValue
{
  public MvcNamedValueComboBoxController()
    : base((Func<TDisplayItem, string>) (item => item.Name))
  {
  }

  public object SelectedId => ((IUniqueObject) (object) this.Model.SelectedItem).UniqueIdentifier;
}
