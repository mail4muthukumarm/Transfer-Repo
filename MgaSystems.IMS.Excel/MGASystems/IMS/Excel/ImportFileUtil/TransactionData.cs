// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Excel.ImportFileUtil.TransactionData
// Assembly: MgaSystems.IMS.Excel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D783CE96-8BF7-4BCA-9997-5F16C01589C2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Excel.dll

using System;
using System.Reflection;

#nullable disable
namespace MGASystems.IMS.Excel.ImportFileUtil;

public class TransactionData
{
  private string _PolicyNumber;
  private Decimal _TransactionAmount;
  private DateTime? _EffectiveDate;
  private Decimal _CompanyCompositeCommission;
  private Decimal _ProducerCompositeCommission;
  private bool _error;
  private string _additionalInterestName;
  private string _additionalInterestAddress;
  private string _additionalInterestCity;
  private string _additionalInterestState;
  private string _additionalInterestZip;
  private int _rowNumber;
  private static PropertyInfo[] allClassProperties;
  private bool _CancelTransactions;
  private bool _DuplicateError;

  public object GetPropertyObject(TransactionData td, string name)
  {
    object propertyObject = new object();
    TransactionData.allClassProperties = typeof (TransactionData).GetProperties();
    foreach (PropertyInfo allClassProperty in TransactionData.allClassProperties)
    {
      if (name == allClassProperty.Name)
        return allClassProperty.GetValue((object) td, (object[]) null);
    }
    return propertyObject;
  }

  public TransactionData()
  {
  }

  public TransactionData(string policyNumber, Decimal transactionAmount)
  {
    this._PolicyNumber = policyNumber;
    this._TransactionAmount = Decimal.Round(transactionAmount, 2);
    this._error = false;
    this._CancelTransactions = false;
    this._DuplicateError = false;
  }

  public TransactionData(string policyNumber, Decimal transactionAmount, DateTime effectiveDate)
  {
    this._PolicyNumber = policyNumber;
    this._TransactionAmount = Decimal.Round(transactionAmount, 2);
    this._EffectiveDate = new DateTime?(effectiveDate);
    this._error = false;
    this._CancelTransactions = false;
    this._DuplicateError = false;
  }

  public TransactionData(string policyNumber, Decimal transactionAmount, DateTime? effectiveDate)
  {
    this._PolicyNumber = policyNumber;
    this._TransactionAmount = Decimal.Round(transactionAmount, 2);
    this._EffectiveDate = effectiveDate;
    this._error = false;
    this._CancelTransactions = false;
    this._DuplicateError = false;
  }

  public TransactionData(
    string policyNumber,
    Decimal transactionAmount,
    DateTime? effectiveDate,
    Decimal companyCompositeCommission,
    Decimal producerCompositeCommission)
  {
    this._PolicyNumber = policyNumber;
    this._TransactionAmount = Decimal.Round(transactionAmount, 2);
    this._EffectiveDate = effectiveDate;
    this._CompanyCompositeCommission = companyCompositeCommission;
    this._ProducerCompositeCommission = producerCompositeCommission;
    this._error = false;
    this._CancelTransactions = false;
    this._DuplicateError = false;
  }

  public TransactionData(
    string policyNumber,
    Decimal transactionAmount,
    DateTime? effectiveDate,
    bool error)
  {
    this._PolicyNumber = policyNumber;
    this._TransactionAmount = Decimal.Round(transactionAmount, 2);
    this._EffectiveDate = effectiveDate;
    this._error = error;
    this._CancelTransactions = false;
    this._DuplicateError = false;
  }

  public TransactionData(
    string policyNumber,
    Decimal transactionAmount,
    string additionalInterestName,
    string additionalInterestAddress,
    string additionalInterestCity,
    string additionalInterestState,
    string additionalInterestZip)
  {
    this._PolicyNumber = policyNumber;
    this._TransactionAmount = Decimal.Round(transactionAmount, 2);
    this._additionalInterestName = additionalInterestName;
    this._additionalInterestAddress = additionalInterestAddress;
    this._additionalInterestCity = additionalInterestCity;
    this._additionalInterestState = additionalInterestState;
    this._additionalInterestZip = additionalInterestZip;
    this._CancelTransactions = false;
    this._DuplicateError = false;
  }

  public TransactionData(
    string policyNumber,
    Decimal transactionAmount,
    DateTime? effectiveDate,
    string additionalInterestName,
    string additionalInterestAddress,
    string additionalInterestCity,
    string additionalInterestState,
    string additionalInterestZip)
  {
    this._PolicyNumber = policyNumber;
    this._TransactionAmount = Decimal.Round(transactionAmount, 2);
    this._EffectiveDate = effectiveDate;
    this._additionalInterestName = additionalInterestName;
    this._additionalInterestAddress = additionalInterestAddress;
    this._additionalInterestCity = additionalInterestCity;
    this._additionalInterestState = additionalInterestState;
    this._additionalInterestZip = additionalInterestZip;
    this._CancelTransactions = false;
    this._DuplicateError = false;
  }

  public string PolicyNumber
  {
    get => this._PolicyNumber;
    set => this._PolicyNumber = value;
  }

  public Decimal TransactionAmount
  {
    get => this._TransactionAmount;
    set => this._TransactionAmount = Decimal.Round(value, 2);
  }

  public DateTime? EffectiveDate
  {
    get => this._EffectiveDate;
    set => this._EffectiveDate = value;
  }

  public Decimal CompanyCompositeCommission
  {
    get => this._CompanyCompositeCommission;
    set => this._CompanyCompositeCommission = value;
  }

  public Decimal ProducerCompositeCommission
  {
    get => this._ProducerCompositeCommission;
    set => this._ProducerCompositeCommission = value;
  }

  public bool Error
  {
    get => this._error;
    set => this._error = value;
  }

  public string AdditionalInterestName
  {
    get => this._additionalInterestName;
    set => this._additionalInterestName = value;
  }

  public string AdditionalInterestAddress
  {
    get => this._additionalInterestAddress;
    set => this._additionalInterestAddress = value;
  }

  public string AdditionalInterestCity
  {
    get => this._additionalInterestCity;
    set => this._additionalInterestCity = value;
  }

  public string AdditionalInterestState
  {
    get => this._additionalInterestState;
    set => this._additionalInterestState = value;
  }

  public string AdditionalInterestZip
  {
    get => this._additionalInterestZip;
    set => this._additionalInterestZip = value;
  }

  public int RowNumber
  {
    get => this._rowNumber;
    set => this._rowNumber = value;
  }

  public bool CancelTransactions
  {
    get => this._CancelTransactions;
    set => this._CancelTransactions = value;
  }

  public bool DuplicateError
  {
    get => this._DuplicateError;
    set => this._DuplicateError = value;
  }
}
