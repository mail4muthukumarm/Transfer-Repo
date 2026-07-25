// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.formLocationExcelImporter
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using Infragistics.Win.UltraWinListView;
using MGASystems.AsposeFacade.Cells;
using MGASystems.Common;
using MGASystems.Data;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies;

[DesignerGenerated]
public class formLocationExcelImporter : ImportClaims
{
  private IContainer components;
  private Guid _quoteGUID;
  private int _currentRow;
  private int _quoteOptionID;
  private Guid _currentUser;
  private int _locationID;
  private string _errorSuffix;
  private string _errorSummary;

  [DebuggerNonUserCode]
  protected override void Dispose(bool disposing)
  {
    try
    {
      if (!disposing || this.components == null)
        return;
      this.components.Dispose();
    }
    finally
    {
      base.Dispose(disposing);
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    this.AutoScaleMode = AutoScaleMode.Font;
    this.Text = nameof (formLocationExcelImporter);
  }

  public int LocationID
  {
    get => this._locationID;
    set => this._locationID = value;
  }

  public string ErrorSuffix
  {
    get => this._errorSuffix;
    set => this._errorSuffix = value;
  }

  public string ErrorSummary
  {
    get => this._errorSummary;
    set => this._errorSummary = value;
  }

  public formLocationExcelImporter(dsExcelImport dsImport, Worksheet worksheet)
    : this(dsImport, Guid.Empty, worksheet, 0)
  {
  }

  public formLocationExcelImporter(
    dsExcelImport dsImport,
    Guid QuoteGuid,
    Worksheet worksheet,
    int QuoteOptionID)
    : base(dsImport, string.Empty, worksheet)
  {
    this._currentRow = 0;
    this.InitializeComponent();
    this._quoteGUID = QuoteGuid;
    this._quoteOptionID = QuoteOptionID;
    this._currentUser = CurrentUser.Instance.UserGUID;
    this.ErrorSummary = (string) null;
    try
    {
      foreach (Row row in (IEnumerable<Row>) worksheet.Cells.Rows)
      {
        if (this._currentRow > 0)
        {
          try
          {
            if (!Information.IsNothing((object) row))
            {
              this.InsertLocationRecord(this._quoteGUID, QuoteOptionID, row);
              UltraListViewItem ultraListViewItem = new UltraListViewItem();
              ((UltraListViewItemBase) ultraListViewItem).Value = (object) this.GetAddListItemSuccessString(this._currentRow, row, string.Empty);
              this.AddListItem(ultraListViewItem);
            }
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
        }
        this.MoveProgress();
        // ISSUE: variable of a reference type
        int& local;
        // ISSUE: explicit reference operation
        int num = ^(local = ref this._currentRow) + 1;
        local = num;
      }
    }
    finally
    {
      IEnumerator<Row> enumerator;
      enumerator?.Dispose();
    }
    this.spinner.Visible = false;
    if (string.IsNullOrEmpty(this.ErrorSummary))
      return;
    int num1 = (int) MessageBox.Show(this.ErrorSummary.ToString());
  }

  protected override void OnLoad(EventArgs e)
  {
    this.lblStatus.Text = "Importing Location Data..";
    this.Text = "Importing........";
  }

  protected override string GetAddListItemSuccessString(
    int _currentRow,
    Row worksheetRow,
    string policyNumber)
  {
    return $"Successfully imported  {(string) this.GetMappedValue("Address1", worksheetRow, true)} ' - ' {(string) this.GetMappedValue("City", worksheetRow, true)} ',' {(string) this.GetMappedValue("State", worksheetRow, true)} ";
  }

  protected override void AddListItem(UltraListViewItem item)
  {
    if (!string.IsNullOrEmpty(this.ErrorSummary))
      return;
    if (this.InvokeRequired)
    {
      this.Invoke((Delegate) new formLocationExcelImporter.AddListItemHandler(this.AddListItem), (object) item);
    }
    else
    {
      this.listImportStatus.Items.Add(item);
      this.listImportStatus.PerformAction((UltraListViewAction) 23);
    }
  }

  private void InsertLocationRecord(Guid QuoteGuid, int QuoteOptionID, Row worksheetRow)
  {
    if (!this.CheckRequiredFields(worksheetRow))
      return;
    this.LocationID = Conversions.ToInteger(DefaultDatabase.ExecuteScalar("dbo.LocationImport", new object[122]
    {
      (object) "@QuoteGuid",
      (object) QuoteGuid,
      (object) "@LocationNo",
      this.GetMappedValue("LocationNo", worksheetRow, false),
      (object) "@BuildingNo",
      this.GetMappedValue("BuildingNo", worksheetRow, false),
      (object) "@PhysicalBuildingNo",
      this.GetMappedValue("PhysicalBuildingNo", worksheetRow, false),
      (object) "@Address1",
      this.GetMappedValue("Address1", worksheetRow, false),
      (object) "@City",
      this.GetMappedValue("City", worksheetRow, false),
      (object) "@State",
      this.GetMappedValue("State", worksheetRow, false),
      (object) "@Zip",
      this.GetMappedValue("Zip", worksheetRow, false),
      (object) "@WindCoverage",
      (object) 0,
      (object) "@Inspect",
      (object) 0,
      (object) "@Photo",
      (object) 0,
      (object) "@Diagram",
      (object) 0,
      (object) "@CostEstimator",
      (object) 0,
      (object) "@UserAdded",
      (object) this._currentUser,
      (object) "@DateAdded",
      (object) DateTime.Now,
      (object) "@ModificationCode",
      (object) "N",
      (object) "@LockedAndSecured",
      (object) 0,
      (object) "@Vacant",
      (object) 0,
      (object) "@RecCheck",
      (object) 0,
      (object) "@Rush",
      (object) 0,
      (object) "@Address2",
      this.GetMappedValue("Address2", worksheetRow, true),
      (object) "@County",
      this.GetMappedValue("County", worksheetRow, true),
      (object) "@ZipPlus",
      this.GetMappedValue("ZipPlus", worksheetRow, true),
      (object) "@ConstructionID",
      this.GetMappedValue("ConstructionID", worksheetRow, true),
      (object) "@ClassCodeID",
      this.GetMappedValue("ClassCodeID", worksheetRow, true),
      (object) "@ProtectionCode",
      this.GetMappedValue("ProtectionCode", worksheetRow, true),
      (object) "@AddnInformation",
      this.GetMappedValue("AddnInformation", worksheetRow, true),
      (object) "@SqFootage",
      this.GetMappedValue("SqFootage", worksheetRow, true),
      (object) "@EQZone",
      this.GetMappedValue("EQZone", worksheetRow, true),
      (object) "@FloodZone",
      this.GetMappedValue("FloodZone", worksheetRow, true),
      (object) "@EQConstruction",
      this.GetMappedValue("EQConstruction", worksheetRow, true),
      (object) "@Territory",
      this.GetMappedValue("Territory", worksheetRow, true),
      (object) "@TaxTerritory",
      this.GetMappedValue("TaxTerritory", worksheetRow, true),
      (object) "@DistToFireHydrant",
      this.GetMappedValue("DistToFireHydrant", worksheetRow, true),
      (object) "@DistToFireStation",
      this.GetMappedValue("DistToFireStation", worksheetRow, true),
      (object) "@FireDistrict",
      this.GetMappedValue("FireDistrict", worksheetRow, true),
      (object) "@Stories",
      this.GetMappedValue("Stories", worksheetRow, true),
      (object) "@Basements",
      this.GetMappedValue("Basements", worksheetRow, true),
      (object) "@Elevators",
      this.GetMappedValue("Elevators", worksheetRow, true),
      (object) "@YearBuilt",
      this.GetMappedValue("YearBuilt", worksheetRow, true),
      (object) "@WiringYear",
      this.GetMappedValue("WiringYear", worksheetRow, true),
      (object) "@RoofingYear",
      this.GetMappedValue("RoofingYear", worksheetRow, true),
      (object) "@PlumbingYear",
      this.GetMappedValue("PlumbingYear", worksheetRow, true),
      (object) "@HeatingYear",
      this.GetMappedValue("HeatingYear", worksheetRow, true),
      (object) "@InspectionCompanyID",
      this.GetMappedValue("InspectionCompanyID", worksheetRow, true),
      (object) "@InspectionContact",
      this.GetMappedValue("InspectionContact", worksheetRow, true),
      (object) "@InspectionContactPhone",
      this.GetMappedValue("InspectionContactPhone", worksheetRow, true),
      (object) "@InspectionRequested",
      this.GetMappedValue("InspectionRequested", worksheetRow, true),
      (object) "@Comments",
      this.GetMappedValue("Comments", worksheetRow, true),
      (object) "@FireAlarmTypeID",
      this.GetMappedValue("FireAlarmTypeID", worksheetRow, true),
      (object) "@BurglarAlarmTypeID",
      this.GetMappedValue("BurglarAlarmTypeID", worksheetRow, true),
      (object) "@SprinklerTypeID",
      this.GetMappedValue("SprinklerTypeID", worksheetRow, true),
      (object) "@WindRestrictionID",
      this.GetMappedValue("WindRestrictionID", worksheetRow, true),
      (object) "@GEOPhyBuildNum",
      this.GetMappedValue("GEOPhyBuildNum", worksheetRow, true),
      (object) "@GEOAddress1",
      this.GetMappedValue("GEOAddress1", worksheetRow, true),
      (object) "@GEOAddress2",
      this.GetMappedValue("GEOAddress2", worksheetRow, true),
      (object) "@GEOCity",
      this.GetMappedValue("GEOCity", worksheetRow, true),
      (object) "@GEOState",
      this.GetMappedValue("GEOState", worksheetRow, true),
      (object) "@GEOCounty",
      this.GetMappedValue("GEOCounty", worksheetRow, true),
      (object) "@GEOZip",
      this.GetMappedValue("GEOZip", worksheetRow, true),
      (object) "@GEOZipPlus",
      this.GetMappedValue("GEOZipPlus", worksheetRow, true)
    }));
    this.DynamicCoverageExposureGenerator(worksheetRow, QuoteOptionID, this.LocationID);
  }

  private void DynamicCoverageExposureGenerator(
    Row worksheetRow,
    int QuoteOptionID,
    int LocationID)
  {
    if (CoverageExposure.CoverageMap.Count <= 0)
      return;
    try
    {
      foreach (CoverageExposure coverage in CoverageExposure.CoverageMap)
      {
        int coverageId = coverage.CoverageID;
        string imsColumn = coverage.IMSColumn;
        Decimal covLimit = Conversions.ToDecimal(this.GetMappedValue(imsColumn, worksheetRow, true));
        try
        {
          this.InsertPropertyExposureRecord(QuoteOptionID, LocationID, coverageId, this._currentUser.ToString(), imsColumn, covLimit);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
      }
    }
    finally
    {
      List<CoverageExposure>.Enumerator enumerator;
      enumerator.Dispose();
    }
  }

  private void InsertPropertyExposureRecord(
    int QuoteOptionID,
    int LocationID,
    int CoverageID,
    string currentUser,
    string covIMSColumn,
    Decimal covLimit)
  {
    DefaultDatabase.ExecuteNonQuery("dbo.LocationPropertyExposureImport", new object[10]
    {
      (object) "@LocationID",
      (object) LocationID,
      (object) "@QuoteOptionID",
      (object) QuoteOptionID,
      (object) "@CoverageID",
      (object) CoverageID,
      (object) "@currentUser",
      (object) currentUser,
      (object) "@CoverageLimit",
      (object) covLimit
    });
  }

  private bool CheckRequiredFields(Row worksheetRow)
  {
    this._errorSuffix = (string) null;
    if (Information.IsNothing(RuntimeHelpers.GetObjectValue(this.GetMappedValue("LocationNo", worksheetRow, false))))
      this._errorSuffix = "LocationNo";
    if (Information.IsNothing(RuntimeHelpers.GetObjectValue(this.GetMappedValue("BuildingNo", worksheetRow, false))))
      this._errorSuffix = !string.IsNullOrEmpty(this._errorSuffix) ? this._errorSuffix + ", BuildingNo " : "BuildingNo ";
    if (Information.IsNothing(RuntimeHelpers.GetObjectValue(this.GetMappedValue("PhysicalBuildingNo", worksheetRow, false))))
      this._errorSuffix = !string.IsNullOrEmpty(this._errorSuffix) ? this._errorSuffix + ", PhysicalBuildingNo " : "PhysicalBuildingNo ";
    if (string.IsNullOrEmpty(this.GetMappedValue("Address1", worksheetRow, false) as string))
      this._errorSuffix = !string.IsNullOrEmpty(this._errorSuffix) ? this._errorSuffix + ", Address1 " : "Address1 ";
    if (string.IsNullOrEmpty(this.GetMappedValue("City", worksheetRow, false) as string))
      this._errorSuffix = !string.IsNullOrEmpty(this._errorSuffix) ? this._errorSuffix + ", City " : "City ";
    if (string.IsNullOrEmpty(this.GetMappedValue("State", worksheetRow, false) as string))
      this._errorSuffix = !string.IsNullOrEmpty(this._errorSuffix) ? this._errorSuffix + ", State " : "State ";
    if (string.IsNullOrEmpty(this.GetMappedValue("Zip", worksheetRow, false) as string))
      this._errorSuffix = !string.IsNullOrEmpty(this._errorSuffix) ? this._errorSuffix + ", Zip " : "Zip ";
    bool flag;
    if (!string.IsNullOrEmpty(this._errorSuffix))
    {
      this.ErrorSummary = $"{this.ErrorSummary}{$"In Row Number {Conversions.ToString(worksheetRow.Index + 1)} of your spreadsheet, the following fields must be mapped to enable\r\nLocation data import\r\n"}{this._errorSuffix}\r\n\r\n";
      flag = false;
    }
    else
      flag = true;
    return flag;
  }

  private new delegate void AddListItemHandler(UltraListViewItem item);
}
