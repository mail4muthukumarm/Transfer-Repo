// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.FormDriverExcelImport
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using Infragistics.Win.Misc;
using System.Collections.Generic;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies;

public class FormDriverExcelImport : ClaimsExcelImport
{
  private int _quoteID;
  private string _policyNumber;
  private string _ErrorMessage;

  public FormDriverExcelImport()
  {
    this._policyNumber = string.Empty;
    this._ErrorMessage = string.Empty;
  }

  public FormDriverExcelImport(int QuoteID)
  {
    this._policyNumber = string.Empty;
    this._ErrorMessage = string.Empty;
    this._quoteID = QuoteID;
    ((Form) this).Text = "Driver Excel Import";
    ((ControlBase) this.buttonImport).Text = "Import Drivers";
    this.Label1.Visible = false;
    ((Control) this.comboPolicyNumber).Visible = false;
    ((Control) this.comboDate).Visible = false;
    this.lblWhere.Visible = false;
    this.lblFallsAfter.Visible = false;
    ((Control) this.dateCriteria).Visible = false;
  }

  protected override string MappingStore => "tblSavedDriversImportMappings";

  protected override void OnImport(string policyNumber)
  {
    if (this._workbook == null)
    {
      int num1 = (int) MessageBox.Show("Please seect a spreadsheet to import", "No Spreadsheet", MessageBoxButtons.OK, MessageBoxIcon.Hand);
    }
    else
    {
      using (DriverExcelImporter driverExcelImporter = new DriverExcelImporter(this._quoteID, this.ds, this._SelectedWorksheet))
      {
        driverExcelImporter.ShowInTaskbar = false;
        int num2 = (int) driverExcelImporter.ShowDialog();
      }
    }
  }

  protected override void OnImportButtonClicked() => this.OnImport(this._policyNumber);

  protected override void OnLoadDatabaseColumns()
  {
    this.AddIMSColumns("tblDriverInfo", new List<string>()
    {
      "DriverID",
      "ControlNo",
      "QuoteGuid",
      "ADRResults"
    });
  }
}
