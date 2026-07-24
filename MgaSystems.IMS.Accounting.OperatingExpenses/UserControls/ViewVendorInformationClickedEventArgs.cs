// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.OperatingExpenses.UserControls.ViewVendorInformationClickedEventArgs
// Assembly: MgaSystems.IMS.Accounting.OperatingExpenses, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 77B4DED4-9019-44D3-8D52-4669B0CA70E1
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.OperatingExpenses.dll

using System;

#nullable disable
namespace MGASystems.IMS.Accounting.OperatingExpenses.UserControls;

public class ViewVendorInformationClickedEventArgs : EventArgs
{
  private Guid vendorGuid;

  public ViewVendorInformationClickedEventArgs(Guid vendorGuid) => this.vendorGuid = vendorGuid;

  public Guid VendorGuid => this.vendorGuid;
}
