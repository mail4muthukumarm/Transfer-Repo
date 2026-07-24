// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.Forms.MVC.DataDrivenComboBox.Model.ISelectableValueModel
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using MGASystems.Common.MVC.BaseClasses.Model;
using MGASystems.Common.MVC.BaseClasses.Model.DatabaseModels;
using MGASystems.Common.MVC.Utility;
using MGASystems.Data.CommonInterface;
using System;
using System.Collections.Generic;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.Forms.MVC.DataDrivenComboBox.Model;

[Obsolete("Use MvcComboBox")]
public interface ISelectableValueModel : IValidateModel, IMvcModel, IValidate
{
  object SelectedValue { get; set; }

  IEnumerable<INamedValue> SelectableValues { get; }

  bool HasValue();

  string FriendlyModelName { get; }

  INamedValue SelectedNamedValue { get; }
}
