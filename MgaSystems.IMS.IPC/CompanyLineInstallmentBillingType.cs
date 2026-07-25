// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.CompanyLineInstallmentBillingType
// Assembly: MgaSystems.IMS.IPC, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: F22CEF02-8C0F-420D-8344-A8A010CA7834
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.IPC.dll

using MGASystems.Data.Binding;
using MGASystems.Data.ChangeTracking;
using MGASystems.Data.DataMapping;
using System.ComponentModel;
using System.Data;

#nullable disable
namespace MGASystems.IMS.InsuredsProducersCompanies;

[TableMapping("tblCompanyLine_InstallmentBillingType")]
[Description("Company Line Installment Billing Type")]
public abstract class CompanyLineInstallmentBillingType : ValidatingBindingObject
{
  public CompanyLineInstallmentBillingTypeManager Parent { get; set; }

  [DataKey]
  [TableFieldMapping]
  public int? InstallmentBillingTypeID { get; set; }

  [TableFieldMapping]
  [NotificationProperty]
  public virtual byte BillingTypeID { get; set; }

  [NotificationProperty]
  public virtual string BillingType { get; set; }

  [TableFieldMapping]
  [NotificationProperty]
  public virtual int CompanyLineInstallmentID { get; set; }

  [TableFieldMapping]
  [NotificationProperty]
  public virtual int CompanyLineID { get; set; }

  [TrackChanges]
  [NotificationProperty]
  public virtual bool IsSelected { get; set; }

  public static CompanyLineInstallmentBillingType Create(
    CompanyLineInstallmentBillingTypeManager manager,
    DataRow dr)
  {
    return NotifyProxyTypeManager.Allocate<CompanyLineInstallmentBillingType>(new object[2]
    {
      (object) manager,
      (object) dr
    });
  }

  public CompanyLineInstallmentBillingType(
    CompanyLineInstallmentBillingTypeManager manager,
    DataRow dr)
  {
    this.Parent = manager;
    this.InstallmentBillingTypeID = dr.Field<int?>(nameof (InstallmentBillingTypeID));
    this.BillingTypeID = dr.Field<byte>(nameof (BillingTypeID));
    this.BillingType = dr.Field<string>(nameof (BillingType));
    this.CompanyLineID = this.Parent.CompanyLineID;
    this.IsSelected = dr.Field<bool>(nameof (IsSelected));
    this.CompanyLineInstallmentID = this.Parent.CompanyLineInstallmentID;
  }
}
