// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.CompanyLineInstallmentBillingTypeManager
// Assembly: MgaSystems.IMS.IPC, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: F22CEF02-8C0F-420D-8344-A8A010CA7834
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.IPC.dll

using Mga.Wpf.Ims.Collections;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.Data.Binding;
using MGASystems.Data.ChangeTracking;
using MGASystems.Data.Validation;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.InsuredsProducersCompanies;

public abstract class CompanyLineInstallmentBillingTypeManager : ValidatingBindingObject
{
  private Guid TransactionLogGuid;

  public int CompanyLineID { get; set; }

  public int CompanyLineInstallmentID { get; set; }

  [TrackChanges]
  public virtual BulkObservableCollection<CompanyLineInstallmentBillingType> BillingTypeList { get; }

  public ChangeManager ChangeManager { get; }

  public bool HasChanges => this.ChangeManager.HasChanges;

  internal static CompanyLineInstallmentBillingTypeManager Create(
    int compLineID,
    int compLineInstallmentID)
  {
    return NotifyProxyTypeManager.Allocate<CompanyLineInstallmentBillingTypeManager>(new object[2]
    {
      (object) compLineID,
      (object) compLineInstallmentID
    });
  }

  public CompanyLineInstallmentBillingTypeManager(int compLineID, int compLineInstallmentID)
  {
    this.TransactionLogGuid = new Guid("772E2583-4CDD-444B-9AB0-BBC5E93108B3");
    this.BillingTypeList = new BulkObservableCollection<CompanyLineInstallmentBillingType>();
    this.ChangeManager = new ChangeManager();
    this.CompanyLineID = compLineID;
    this.CompanyLineInstallmentID = compLineInstallmentID;
    this.BillingTypeList.AddRange((IEnumerable<CompanyLineInstallmentBillingType>) DefaultDatabase.ExecuteDataTable(CommandType.StoredProcedure, "spCompanyLineInstallmentBillingTypeGet", new object[4]
    {
      (object) "@CompanyLineID",
      (object) this.CompanyLineID,
      (object) "@CompanyLineInstallmentID",
      (object) compLineInstallmentID
    }).AsEnumerable().Select<DataRow, CompanyLineInstallmentBillingType>((System.Func<DataRow, CompanyLineInstallmentBillingType>) ([SpecialName] (row) => CompanyLineInstallmentBillingType.Create(this, row))));
    this.ChangeManager.Initialize((INotifyPropertyChanged) this);
  }

  public List<ValidationResult> SubmitChanges()
  {
    List<ValidationResult> validationResultList = new List<ValidationResult>();
    if (DataErrorInfoSupport.ValidateModel((IDataErrorInfo) this, validationResultList))
    {
      try
      {
        foreach (ChangeDetail delta in this.ChangeManager.DeltaList)
        {
          CompanyLineInstallmentBillingType objectThatChanged = (CompanyLineInstallmentBillingType) delta.ObjectThatChanged;
          if (objectThatChanged != null)
          {
            DefaultDatabase.ExecuteNonQuery(CommandType.StoredProcedure, "spCompanyLineInstallmentBillingTypeUpdate", new object[8]
            {
              (object) "@CompanyLineID",
              (object) objectThatChanged.CompanyLineID,
              (object) "@BillingTypeID",
              (object) objectThatChanged.BillingTypeID,
              (object) "@IsSelected",
              (object) objectThatChanged.IsSelected,
              (object) "@CompanyLineInstallmentID",
              (object) objectThatChanged.CompanyLineInstallmentID
            });
            CurrentUser.Instance.LogAction((!objectThatChanged.IsSelected ? "Removed Billing Type " : "Added Billing Type ") + objectThatChanged.BillingType, this.TransactionLogGuid, "CompanyLineID:  " + Conversions.ToString(objectThatChanged.CompanyLineID));
          }
        }
      }
      finally
      {
        IEnumerator<ChangeDetail> enumerator;
        enumerator?.Dispose();
      }
    }
    return validationResultList;
  }
}
