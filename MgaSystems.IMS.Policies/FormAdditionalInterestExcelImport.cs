// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.FormAdditionalInterestExcelImport
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using Infragistics.Win.Misc;
using System.Collections.Generic;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies;

public class FormAdditionalInterestExcelImport : ClaimsExcelImport
{
  private int _quoteID;
  private string _policyNumber;

  public FormAdditionalInterestExcelImport() => this._policyNumber = string.Empty;

  public FormAdditionalInterestExcelImport(int QuoteID)
  {
    this._policyNumber = string.Empty;
    ((Form) this).Text = "Additional Interest Excel Import";
    ((ControlBase) this.buttonImport).Text = "Import Add'l Interests";
    this._quoteID = QuoteID;
    this.Label1.Visible = false;
    ((Control) this.comboPolicyNumber).Visible = false;
    ((Control) this.comboDate).Visible = false;
    this.lblWhere.Visible = false;
    this.lblFallsAfter.Visible = false;
    ((Control) this.dateCriteria).Visible = false;
  }

  protected override string MappingStore => "tblSavedAddlInterestImportMappings";

  protected override void OnLoadDatabaseColumns()
  {
    this.AddIMSColumns("tblQuoteAdditionalInterests", new List<string>()
    {
      "ID",
      "AdditionalInterestGuid",
      "PreviousAdditionalInterestGuid",
      "QuoteID",
      "ModificationCode",
      "Billable",
      "AdditionalInterestControlID"
    });
  }

  protected override void OnImport(string policyNumber)
  {
    if (this._workbook == null)
    {
      int num1 = (int) MessageBox.Show("Please seect a spreadsheet to import", "No Spreadsheet", MessageBoxButtons.OK, MessageBoxIcon.Hand);
    }
    else
    {
      using (AddlInterestExcelImporter interestExcelImporter = new AddlInterestExcelImporter(this._quoteID, this.ds, this._SelectedWorksheet))
      {
        interestExcelImporter.ShowInTaskbar = false;
        int num2 = (int) interestExcelImporter.ShowDialog();
      }
    }
  }

  protected override void OnImportButtonClicked() => this.OnImport(this._policyNumber);

  protected override void AddClientTableColumns(dsExcelImport ds, string tableName)
  {
    ds.ImportMappings.AddImportMappingsRow("LocationNum", string.Empty);
    ds.ImportMappings.AddImportMappingsRow("BuildingNum", string.Empty);
    ds.ImportMappings.AddImportMappingsRow("AdditionalInterestType", string.Empty);
    ds.IMSColumns.AddIMSColumnsRow("LocationNum", tableName);
    ds.IMSColumns.AddIMSColumnsRow("BuildingNum", tableName);
    ds.IMSColumns.AddIMSColumnsRow("AdditionalInterestType", tableName);
  }
}
