// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Excel.ImportFileUtil.FileExcel
// Assembly: MgaSystems.IMS.Excel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D783CE96-8BF7-4BCA-9997-5F16C01589C2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Excel.dll

using MGASystems.AsposeFacade.Cells;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

#nullable disable
namespace MGASystems.IMS.Excel.ImportFileUtil;

internal class FileExcel
{
  public DataSet ExcelDataSet { get; set; }

  public string FileTypeExcel2003 => ".xls";

  public string FileTypeExcel2007 => ".xlsx";

  public List<TransactionData> LoadExcelDataFromFile(ConfigInfo ci, DataTable dt)
  {
    List<TransactionData> transactionDataList = new List<TransactionData>();
    try
    {
      foreach (DataRow row in (InternalDataCollectionBase) dt.Rows)
      {
        string policyNumber = row.ItemArray[ci.ColumnNumberPolicyNumber].ToString();
        if (!string.IsNullOrEmpty(policyNumber))
        {
          Decimal result1;
          if (!Decimal.TryParse(row.ItemArray[ci.ColumnNumberTransactionAmount].ToString(), out result1))
            throw new Exception($"Policy Number = '{policyNumber}'. Failed to Convert Transaction Amount = '{row.ItemArray[ci.ColumnNumberTransactionAmount]}'.");
          DateTime? effectiveDate = new DateTime?();
          if (ci.ColumnNumberEffectiveDate != -1 && row.ItemArray.Length > ci.ColumnNumberEffectiveDate && row.ItemArray[ci.ColumnNumberEffectiveDate] != null)
          {
            DateTime result2;
            if (!DateTime.TryParse(row.ItemArray[ci.ColumnNumberEffectiveDate].ToString(), out result2))
            {
              double result3;
              if (!double.TryParse(row.ItemArray[ci.ColumnNumberEffectiveDate].ToString(), out result3))
                throw new Exception($"Policy Number = '{policyNumber}'. Failed to Convert Effective Date = '{row.ItemArray[ci.ColumnNumberEffectiveDate]}'.");
              result2 = DateTime.FromOADate(result3);
            }
            effectiveDate = new DateTime?(result2);
          }
          TransactionData transactionData = new TransactionData(policyNumber, result1, effectiveDate);
          transactionDataList.Add(transactionData);
        }
      }
    }
    catch (Exception ex)
    {
      string errorLogDirectory = ci.ErrorLogDirectory;
      int num = ci.AllDebugInfo ? 1 : 0;
      LogFile logFile = new LogFile(ex, "method LoadExcelDataFromFile", errorLogDirectory, num != 0);
    }
    return transactionDataList;
  }

  public void ISetDataForExcelWorksheet(
    string excelFileName,
    bool hasHeaderColumn,
    string fileType)
  {
    this.SetDataForExcelWorksheet(excelFileName, hasHeaderColumn);
  }

  public void SetDataForExcelWorksheet(string excelFileName, bool hasHeaderColumn)
  {
    this.ExcelDataSet = FileExcel.ToDataSet(new Workbook(excelFileName), hasHeaderColumn);
  }

  private static DataSet ToDataSet(Workbook workBook, bool isFirstRowAsColumnNames)
  {
    DataSet dataSet = new DataSet();
    foreach (Worksheet worksheet in (IEnumerable<Worksheet>) workBook.Worksheets)
    {
      if (worksheet.Cells.Rows.Count != 0)
      {
        int num1 = Math.Max(worksheet.Cells.Columns.Count, worksheet.Cells.MaxColumn);
        int num2 = isFirstRowAsColumnNames ? 1 : 0;
        int maxDataRow = worksheet.Cells.MaxDataRow;
        DataTable table = worksheet.Cells.ExportDataTable(num2, 0, maxDataRow, num1 + 1);
        dataSet.Tables.Add(table);
      }
    }
    return dataSet;
  }

  public bool CheckPolicyNumber(ConfigInfo ci, DataRow dr)
  {
    try
    {
      if (!string.IsNullOrEmpty(dr.ItemArray[ci.ColumnNumberPolicyNumber].ToString()))
        return true;
    }
    catch (Exception ex)
    {
      string errorLogDirectory = ci.ErrorLogDirectory;
      int num = ci.AllDebugInfo ? 1 : 0;
      LogFile logFile = new LogFile(ex, "method CheckPolicyNumber", errorLogDirectory, num != 0);
      return false;
    }
    return false;
  }

  private string removeNonAlphaNumerics(string s)
  {
    return new string(s.Where<char>((System.Func<char, bool>) (c => char.IsLetterOrDigit(c))).ToArray<char>());
  }

  public TransactionData LoadExcelDataFromTableRow(ConfigInfo ci, DataRow dr, int cellNumber)
  {
    TransactionData transactionData = new TransactionData();
    try
    {
      string PolicyNumber = !ci.StripPolicyNumber ? dr.ItemArray[ci.ColumnNumberPolicyNumber].ToString() : this.removeNonAlphaNumerics(dr.ItemArray[ci.ColumnNumberPolicyNumber].ToString());
      Decimal result1;
      int num = Decimal.TryParse(dr.ItemArray[ci.ColumnNumberTransactionAmount].ToString(), out result1) ? 1 : 0;
      if (ci.ColumnNumberEffectiveDate != -1)
        transactionData.EffectiveDate = this.CheckForEffectiveDate(ci, dr, PolicyNumber);
      if (ci.ColumnNumberCompanyCompositeCommission != -1)
      {
        Decimal result2;
        if (Decimal.TryParse(dr.ItemArray[ci.ColumnNumberCompanyCompositeCommission].ToString(), out result2))
        {
          if (result2 > 1M)
            result2 /= 100M;
          transactionData.CompanyCompositeCommission = result2;
        }
        if (result2 == 0M)
          transactionData.CompanyCompositeCommission = -0.001M;
      }
      if (ci.ColumnNumberProducerCompositeCommission != -1)
      {
        Decimal result3;
        if (Decimal.TryParse(dr.ItemArray[ci.ColumnNumberProducerCompositeCommission].ToString(), out result3))
        {
          if (result3 > 1M)
            result3 /= 100M;
          transactionData.ProducerCompositeCommission = result3;
        }
        if (result3 == 0M)
          transactionData.ProducerCompositeCommission = -0.001M;
      }
      if (ci.ColumnNumberAdditionalInterestName != -1)
        transactionData.AdditionalInterestName = dr.ItemArray[ci.ColumnNumberAdditionalInterestName].ToString();
      if (ci.ColumnNumberAdditionalInterestAddress != -1)
        transactionData.AdditionalInterestAddress = dr.ItemArray[ci.ColumnNumberAdditionalInterestAddress].ToString();
      if (ci.ColumnNumberAdditionalInterestCity != -1)
        transactionData.AdditionalInterestCity = dr.ItemArray[ci.ColumnNumberAdditionalInterestCity].ToString();
      if (ci.ColumnNumberAdditionalInterestState != -1)
        transactionData.AdditionalInterestState = dr.ItemArray[ci.ColumnNumberAdditionalInterestState].ToString();
      if (ci.ColumnNumberAdditionalInterestZip != -1)
        transactionData.AdditionalInterestZip = dr.ItemArray[ci.ColumnNumberAdditionalInterestZip].ToString();
      if (num == 0)
        throw new Exception($"Policy Number = '{PolicyNumber}'. Failed to Convert Transaction Amount = '{dr.ItemArray[ci.ColumnNumberTransactionAmount]}'.");
      transactionData.PolicyNumber = PolicyNumber;
      transactionData.TransactionAmount = result1;
      transactionData.RowNumber = cellNumber;
      return transactionData;
    }
    catch (Exception ex)
    {
      string errorLogDirectory = ci.ErrorLogDirectory;
      int num = ci.AllDebugInfo ? 1 : 0;
      LogFile logFile = new LogFile(ex, "method LoadExcelDataFromTableRow", errorLogDirectory, num != 0);
      transactionData.PolicyNumber = dr.ItemArray[ci.ColumnNumberPolicyNumber].ToString();
      transactionData.TransactionAmount = 0.0M;
      transactionData.Error = true;
    }
    return transactionData;
  }

  public DateTime? CheckForEffectiveDate(ConfigInfo ci, DataRow dr, string PolicyNumber)
  {
    DateTime? nullable = new DateTime?();
    try
    {
      if (dr.ItemArray.Length > ci.ColumnNumberEffectiveDate)
      {
        if (dr.ItemArray[ci.ColumnNumberEffectiveDate] != null)
        {
          DateTime result1;
          if (!DateTime.TryParse(dr.ItemArray[ci.ColumnNumberEffectiveDate].ToString(), out result1))
          {
            double result2;
            if (!double.TryParse(dr.ItemArray[ci.ColumnNumberEffectiveDate].ToString(), out result2))
              throw new Exception($"Policy Number = '{PolicyNumber}'. Failed to Convert Effective Date = '{dr.ItemArray[ci.ColumnNumberEffectiveDate]}'.");
            result1 = DateTime.FromOADate(result2);
          }
          nullable = new DateTime?(result1);
        }
      }
    }
    catch (Exception ex)
    {
      string errorLogDirectory = ci.ErrorLogDirectory;
      int num = ci.AllDebugInfo ? 1 : 0;
      LogFile logFile = new LogFile(ex, "method CheckEffectiveDate", errorLogDirectory, num != 0);
      return new DateTime?(DateTime.Today);
    }
    return nullable;
  }
}
