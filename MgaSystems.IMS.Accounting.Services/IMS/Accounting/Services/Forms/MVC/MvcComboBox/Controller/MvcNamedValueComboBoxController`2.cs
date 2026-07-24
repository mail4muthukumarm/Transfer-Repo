// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.Forms.MVC.MvcComboBox.Controller.MvcNamedValueComboBoxController`2
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using MGASystems.Common.MVC.BaseClasses.Controller;
using MGASystems.Data.CommonInterface;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.Forms.MVC.MvcComboBox.Controller;

public class MvcNamedValueComboBoxController<TDisplayItem, TIdentifier> : 
  MvcNamedValueComboBoxController<TDisplayItem>,
  IMvcNamedValueComboBoxController<TDisplayItem, TIdentifier>,
  IMvcNamedValueComboBoxController<TDisplayItem>,
  IMvcComboBoxController<TDisplayItem>,
  IMvcComboBoxController,
  IMvcController
  where TDisplayItem : class, INamedValue<TIdentifier>
{
  public TIdentifier SelectedId
  {
    get => ((IUniqueObject<TIdentifier>) (object) this.Model.SelectedItem).UniqueIdentifier;
  }
}
