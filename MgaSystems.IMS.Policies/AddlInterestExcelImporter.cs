// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.AddlInterestExcelImporter
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using MGASystems.AsposeFacade.Cells;
using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Common.Settings;
using MGASystems.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies;

public class AddlInterestExcelImporter : ImportClaims
{
  private readonly HashSet<string> _ofacAITypes;
  private List<Guid> _addedOfacEntities;
  private Quote _Quote;
  private int _QuoteID;

  public AddlInterestExcelImporter(int quoteID, dsExcelImport dsImport, Worksheet worksheet)
    : base(dsImport, string.Empty, worksheet)
  {
    this._ofacAITypes = new HashSet<string>((IEqualityComparer<string>) StringComparer.InvariantCultureIgnoreCase);
    this._addedOfacEntities = new List<Guid>();
    this._QuoteID = quoteID;
    this._Quote = new Quote(this._QuoteID);
  }

  protected override void OnLoad(EventArgs e)
  {
    this.lblStatus.Text = "Importing Data ...";
    this.Text = "Importing Add'l Interest";
    base.OnLoad(e);
    this._ofacAITypes.UnionWith((IEnumerable<string>) AdditionalInterest.OfacSearchTypes);
  }

  protected override object GetControlNo(string policyNumber) => (object) this._Quote.ControlNo;

  protected override string GetAddListItemSuccessString(
    int _currentRow,
    Row worksheetRow,
    string policyNumber)
  {
    string empty1 = string.Empty;
    string empty2 = string.Empty;
    string empty3 = string.Empty;
    string empty4 = string.Empty;
    return $"Successfully imported Addl Interest  {(string) this.GetMappedValue("InterestName", worksheetRow, true)} ' - ' {(string) this.GetMappedValue("FirstName", worksheetRow, true)} ',' {(string) this.GetMappedValue("LastName", worksheetRow, true)} ";
  }

  protected override string GetPolicyNumber(Row worksheetRow) => this._Quote.PolicyNumber;

  protected override void ImportComplete(int importCount, int skipCount, int notFoundCount)
  {
    if (SystemSettings.GetSetting<bool>("OFAC.AdditionalInterest.Import.RunSearch", false))
      this.RunOfacCheck();
    this.spinner.Visible = false;
    int num = (int) MessageBox.Show($"The Additional Interest import is complete.\n\nImported: {importCount.ToString()}\n\nSkipped: {skipCount.ToString()}\n\nPolicy Not Found: {notFoundCount.ToString()}", "Import Complete", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
  }

  protected override void OnInsertRecord(int controlNo, Row worksheetRow)
  {
    this._addedOfacEntities.Add(DefaultDatabase.ExecuteScalar<Guid>("dbo.ImportAdditionalInterests", new object[52]
    {
      (object) "@QuoteID",
      (object) this._QuoteID,
      (object) "@InterestName",
      this.GetMappedValue("InterestName", worksheetRow, true),
      (object) "@Address1",
      this.GetMappedValue("Address1", worksheetRow, true),
      (object) "@Address2",
      this.GetMappedValue("Address2", worksheetRow, true),
      (object) "@City",
      this.GetMappedValue("City", worksheetRow, true),
      (object) "@County",
      this.GetMappedValue("County", worksheetRow, true),
      (object) "@StateID",
      this.GetMappedValue("StateID", worksheetRow, true),
      (object) "@Region",
      this.GetMappedValue("Region", worksheetRow, true),
      (object) "@ISOCountryCode",
      this.GetMappedValue("ISOCountryCode", worksheetRow, true),
      (object) "@ZipCode",
      this.GetMappedValue("ZipCode", worksheetRow, true),
      (object) "@ZipPlus",
      this.GetMappedValue("ZipPlus", worksheetRow, true),
      (object) "@Phone",
      this.GetMappedValue("Phone", worksheetRow, true),
      (object) "@Fax",
      this.GetMappedValue("Fax", worksheetRow, true),
      (object) "@Interest",
      this.GetMappedValue("Interest", worksheetRow, true),
      (object) "@DescriptionText",
      this.GetMappedValue("DescriptionText", worksheetRow, true),
      (object) "@IssuanceDate",
      this.GetMappedValue("IssuanceDate", worksheetRow, true),
      (object) "@FEIN",
      this.GetMappedValue("FEIN", worksheetRow, true),
      (object) "@BillableAmount",
      this.GetMappedValue("BillableAmount", worksheetRow, true),
      (object) "@Salutation",
      this.GetMappedValue("Salutation", worksheetRow, true),
      (object) "@FirstName",
      this.GetMappedValue("FirstName", worksheetRow, true),
      (object) "@MiddleName",
      this.GetMappedValue("MiddleName", worksheetRow, true),
      (object) "@LastName",
      this.GetMappedValue("LastName", worksheetRow, true),
      (object) "@DateOfBirth",
      this.GetMappedValue("DateOfBirth", worksheetRow, true),
      (object) "@LocationNum",
      this.GetMappedValue("LocationNum", worksheetRow, true),
      (object) "@BuildingNum",
      this.GetMappedValue("BuildingNum", worksheetRow, true),
      (object) "@AdditionalInterestType",
      this.GetMappedValue("AdditionalInterestType", worksheetRow, true)
    }));
  }

  private void RunOfacCheck()
  {
    OfacSystem.Instance.CheckMultiple(BaseDataObject.SelectMultiple<AdditionalInterest>(new object[1]
    {
      (object) this._addedOfacEntities
    }).Where<AdditionalInterest>((Func<AdditionalInterest, bool>) ([SpecialName] (ai) => SystemSettings.GetSetting<bool>("OFAC.AdditionalInterest.Import.SearchAll", false) || ((IEnumerable<string>) ai.AdditionalInterestTypes).Intersect<string>((IEnumerable<string>) this._ofacAITypes).Any<string>())).Cast<IOfacEntity>().ToList<IOfacEntity>(), (Action<string, string>) null);
  }
}
