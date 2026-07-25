// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.DriverExcelImporter
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using MGASystems.AsposeFacade.Cells;
using MGASystems.BusinessObjects;
using MGASystems.Data;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies;

public class DriverExcelImporter : ImportClaims
{
  private int _QuoteID;
  private Quote _Quote;
  private string _RowErrorMessage;
  private string _totalErrorMessage;
  private int _driverSkipCount;
  private int _driverImportCount;
  private object _ErrorMessage;

  public DriverExcelImporter(int quoteID, dsExcelImport dsImport, Worksheet worksheet)
    : base(dsImport, string.Empty, worksheet)
  {
    this._RowErrorMessage = string.Empty;
    this._totalErrorMessage = string.Empty;
    this._driverSkipCount = 0;
    this._driverImportCount = 0;
    this._QuoteID = quoteID;
    this._Quote = new Quote(this._QuoteID);
  }

  public string ErrMessage => this._totalErrorMessage;

  protected override void OnLoad(EventArgs e)
  {
    this.lblStatus.Text = "Importing Data ...";
    this.Text = "Importing Driver Records";
    base.OnLoad(e);
  }

  protected override string GetPolicyNumber(Row worksheetRow)
  {
    return !this._Quote.HasPolicyNumber ? string.Empty : this._Quote.PolicyNumber;
  }

  protected override object GetControlNo(string policyNumber) => (object) this._Quote.ControlNo;

  protected override string GetAddListItemSuccessString(
    int _currentRow,
    Row worksheetRow,
    string policyNumber)
  {
    string empty1 = string.Empty;
    string str = !string.IsNullOrEmpty(this._RowErrorMessage) ? "Skip Driver - " : "Successfully imported Driver - ";
    string empty2 = string.Empty;
    string empty3 = string.Empty;
    string empty4 = string.Empty;
    string mappedValue1 = (string) this.GetMappedValue("FirstName", worksheetRow, true);
    string mappedValue2 = (string) this.GetMappedValue("LastName", worksheetRow, true);
    return string.Format(str + "' {1} ',' {0} ", (object) mappedValue1, (object) mappedValue2);
  }

  protected override void ImportComplete(int importCount, int skipCount, int notFoundCount)
  {
    this.spinner.Visible = false;
    if (!this._totalErrorMessage.Equals(string.Empty))
    {
      int num1 = (int) MessageBox.Show(this._totalErrorMessage, "Data Inconsistency", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    int num2 = (int) MessageBox.Show($"Driver import is complete.\n\nImported: {this._driverImportCount.ToString()}\n\nSkipped: {this._driverSkipCount.ToString()}\n\nPolicy Not Found: {notFoundCount.ToString()}", "Import Complete", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
  }

  protected override void OnInsertRecord(int controlNo, Row worksheetRow)
  {
    if (!this.ValidateFields(worksheetRow))
    {
      ++this._driverSkipCount;
    }
    else
    {
      try
      {
        DefaultDatabase.ExecuteNonQuery("ImportDriverInfo", new object[56]
        {
          (object) "@ControlNo",
          (object) this._Quote.ControlNo,
          (object) "@QuoteGuid",
          (object) this._Quote.QuoteGuid,
          (object) "@FirstName",
          this.GetMappedValue("FirstName", worksheetRow, true),
          (object) "@LastName",
          this.GetMappedValue("LastName", worksheetRow, true),
          (object) "@DOB",
          this.GetMappedValue("DOB", worksheetRow, true),
          (object) "@LicenseNumber",
          this.GetMappedValue("LicenseNumber", worksheetRow, true),
          (object) "@StateID",
          this.GetMappedValue("StateID", worksheetRow, true),
          (object) "@DateAdded",
          this.GetMappedValue("DateAdded", worksheetRow, true),
          (object) "@DriverDeleted",
          this.GetMappedValue("DriverDeleted", worksheetRow, true),
          (object) "@DriverAdded",
          this.GetMappedValue("DriverAdded", worksheetRow, true),
          (object) "@NumberOfPoints",
          this.GetMappedValue("NumberOfPoints", worksheetRow, true),
          (object) "@FurnishedCar",
          this.GetMappedValue("FurnishedCar", worksheetRow, true),
          (object) "@Comments",
          this.GetMappedValue("Comments", worksheetRow, true),
          (object) "@FullPartTime",
          this.GetMappedValue("FullPartTime", worksheetRow, true),
          (object) "@LicenseExpDate",
          this.GetMappedValue("LicenseExpDate", worksheetRow, true),
          (object) "@Street1",
          this.GetMappedValue("Street1", worksheetRow, true),
          (object) "@Street2",
          this.GetMappedValue("Street2", worksheetRow, true),
          (object) "@City",
          this.GetMappedValue("City", worksheetRow, true),
          (object) "@ZipCode",
          this.GetMappedValue("ZipCode", worksheetRow, true),
          (object) "@ZipPlus",
          this.GetMappedValue("ZipPlus", worksheetRow, true),
          (object) "@DriverRatingFactor",
          this.GetMappedValue("DriverRatingFactor", worksheetRow, true),
          (object) "@LicenseClass",
          this.GetMappedValue("LicenseClass", worksheetRow, true),
          (object) "@CopyOnRenewal",
          this.GetMappedValue("CopyOnRenewal", worksheetRow, true),
          (object) "@MedicalExpiration",
          this.GetMappedValue("MedicalExpiration", worksheetRow, true),
          (object) "@CDLDriverID",
          this.GetMappedValue("CDLDriverID", worksheetRow, true),
          (object) "@MVRDate",
          this.GetMappedValue("MVRDate", worksheetRow, true),
          (object) "@JobTitle",
          this.GetMappedValue("JobTitle", worksheetRow, true),
          (object) "@StatusID",
          this.GetMappedValue("StatusID", worksheetRow, true)
        });
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ++this._driverSkipCount;
        throw;
      }
      ++this._driverImportCount;
    }
  }

  private string DateValidator(string columnName, object columnValue)
  {
    string str1;
    if (columnValue == null || columnValue == DBNull.Value || columnValue.ToString().Equals(string.Empty))
    {
      str1 = string.Empty;
    }
    else
    {
      string str2 = string.Empty;
      if (!DateTime.TryParse(columnValue.ToString(), out DateTime _))
        str2 = $"'{columnName}' is not in date format. ";
      str1 = str2;
    }
    return str1;
  }

  private string IntegerValidator(string columnName, object columnValue)
  {
    string str1;
    if (columnValue == null || columnValue == DBNull.Value || columnValue.ToString().Equals(string.Empty))
    {
      str1 = string.Empty;
    }
    else
    {
      string str2 = string.Empty;
      if (columnValue != null && !int.TryParse(columnValue.ToString(), out int _))
        str2 = $"'{columnName}' must be in number format. ";
      str1 = str2;
    }
    return str1;
  }

  private string DecimalValidator(string columnName, object columnValue)
  {
    string str1;
    if (columnValue == null || columnValue == DBNull.Value || columnValue.ToString().Equals(string.Empty))
    {
      str1 = string.Empty;
    }
    else
    {
      string str2 = string.Empty;
      if (columnValue != null && !Decimal.TryParse(columnValue.ToString(), out Decimal _))
        str2 = $"'{columnName}' must be in decimal format. ";
      str1 = str2;
    }
    return str1;
  }

  private bool ValidateFields(Row worksheetRow)
  {
    this._RowErrorMessage = string.Empty;
    string empty1 = string.Empty;
    string str1 = this.DateValidator("DOB", RuntimeHelpers.GetObjectValue(this.GetMappedValue("DOB", worksheetRow, true)));
    string empty2 = string.Empty;
    string str2 = this.DateValidator("DriverDeleted", RuntimeHelpers.GetObjectValue(this.GetMappedValue("DriverDeleted", worksheetRow, true)));
    string str3 = !string.IsNullOrEmpty(str1) ? str1 + str2 : str2;
    string str4 = this.DateValidator("DriverAdded", RuntimeHelpers.GetObjectValue(this.GetMappedValue("DriverAdded", worksheetRow, true)));
    string str5 = !string.IsNullOrEmpty(str3) ? str3 + str4 : str4;
    string str6 = this.IntegerValidator("FullPartTime", RuntimeHelpers.GetObjectValue(this.GetMappedValue("FullPartTime", worksheetRow, true)));
    string str7 = !string.IsNullOrEmpty(str5) ? str5 + str6 : str6;
    string str8 = this.DateValidator("LicenseExpDate", RuntimeHelpers.GetObjectValue(this.GetMappedValue("LicenseExpDate", worksheetRow, true)));
    string str9 = !string.IsNullOrEmpty(str7) ? str7 + str8 : str8;
    string str10 = this.DecimalValidator("DriverRatingFactor", RuntimeHelpers.GetObjectValue(this.GetMappedValue("DriverRatingFactor", worksheetRow, true)));
    string str11 = !string.IsNullOrEmpty(str9) ? str9 + str10 : str10;
    object objectValue1 = RuntimeHelpers.GetObjectValue(this.GetMappedValue("LicenseClass", worksheetRow, true));
    if (objectValue1 != null && objectValue1.ToString().Length != 1)
      str11 = !string.IsNullOrEmpty(str11) ? str11 + ",'LicenseClass' must be 1 character" : "'LicenseClass' must be 1 character. ";
    object objectValue2 = RuntimeHelpers.GetObjectValue(this.GetMappedValue("ZipCode", worksheetRow, true));
    if (objectValue2 != null && objectValue2.ToString().Length != 5)
      str11 = !string.IsNullOrEmpty(str11) ? str11 + ",'ZipCode' must be 5 characters" : "'ZipCode' must be 5 characters. ";
    if (RuntimeHelpers.GetObjectValue(this.GetMappedValue("FirstName", worksheetRow, true)) == null)
      str11 = !string.IsNullOrEmpty(str11) ? str11 + ",'FirstName' is required" : "'FirstName' is required. ";
    if (RuntimeHelpers.GetObjectValue(this.GetMappedValue("LastName", worksheetRow, true)) == null)
      str11 = !string.IsNullOrEmpty(str11) ? str11 + ",'LastName' is required" : "'LastName' is required. ";
    this._RowErrorMessage = str11;
    bool flag;
    if (!string.IsNullOrEmpty(str11))
    {
      this._totalErrorMessage = $"{this._totalErrorMessage}Row {Conversions.ToString(worksheetRow.Index + 1)} has the following errors - \n{str11}";
      flag = false;
    }
    else
      flag = true;
    return flag;
  }
}
