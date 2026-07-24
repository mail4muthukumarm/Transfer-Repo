// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.Forms.MVC.WrappedUltraGridControl.Controller.IWrappedUltraGridController
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using Infragistics.Win.UltraWinGrid;
using MGASystems.Common.MVC.BaseClasses.Controller;
using System;
using System.Collections;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.Forms.MVC.WrappedUltraGridControl.Controller;

public interface IWrappedUltraGridController : IMvcController
{
  void ReMapObjectsToRows();

  void WireUpGridAdapter(UltraGrid wrappedUltraGrid);

  event Action<object> GridSelectedObjectChanged;

  object GetSelected();

  void RequestSetSelected(object selected);

  void ClearSelected();

  IEnumerable GetDisplayItems();

  void InitializeListeners();
}
