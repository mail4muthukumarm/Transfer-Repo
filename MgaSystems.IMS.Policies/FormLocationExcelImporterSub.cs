// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.FormLocationExcelImporterSub
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using Infragistics.Win.UltraWinListView;
using MGASystems.AddressResolver;
using MGASystems.AsposeFacade.Cells;
using MGASystems.Common;
using MGASystems.Data;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies;

public class FormLocationExcelImporterSub : ImportClaims
{
  private Guid _quoteGUID;
  private string _errorSuffix;
  private string _errorSummary;
  private int _currentRow;
  private int _quoteOptionID;
  private Guid _currentUser;
  private int _locationID;

  private void InitializeComponent()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormLocationExcelImporterSub));
    ((ISupportInitialize) this.listImportStatus).BeginInit();
    ((ISupportInitialize) this.spinner).BeginInit();
    this.SuspendLayout();
    ((UltraListViewSettingsBase) this.listImportStatus.ViewSettingsDetails).ImageList = this.ImageList1;
    ((UltraListViewSettingsBase) this.listImportStatus.ViewSettingsIcons).ImageList = this.ImageList1;
    ((UltraListViewSettingsBase) this.listImportStatus.ViewSettingsList).ImageList = this.ImageList1;
    this.listImportStatus.ViewSettingsList.MultiColumn = false;
    this.ImageList1.ImageStream = (ImageListStreamer) componentResourceManager.GetObject("ImageList1.ImageStream");
    this.ImageList1.Images.SetKeyName(0, "bullet_green.png");
    this.ImageList1.Images.SetKeyName(1, "bullet_red.png");
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.ClientSize = new Size(609, 379);
    this.Name = nameof (FormLocationExcelImporterSub);
    ((ISupportInitialize) this.listImportStatus).EndInit();
    ((ISupportInitialize) this.spinner).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  public int LocationID
  {
    get => this._locationID;
    set => this._locationID = value;
  }

  public string ErrorSummary
  {
    get => this._errorSummary;
    set => this._errorSummary = value;
  }

  public string ErrorSuffix
  {
    get => this._errorSuffix;
    set => this._errorSuffix = value;
  }

  public FormLocationExcelImporterSub(dsExcelImport dsImport, Worksheet worksheet)
    : this(dsImport, Guid.Empty, worksheet, 0)
  {
  }

  public FormLocationExcelImporterSub(
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
    this.progress.Maximum = worksheet.Cells.Rows.Count;
    int num1 = 0;
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
              if (this.InsertLocationRecord(this._quoteGUID, QuoteOptionID, row))
              {
                UltraListViewItem ultraListViewItem = new UltraListViewItem();
                ((UltraListViewItemBase) ultraListViewItem).Value = (object) this.GetAddListItemSuccessString(this._currentRow, row, string.Empty);
                this.AddListItem(ultraListViewItem);
                ++num1;
              }
            }
          }
          catch (SqlException ex)
          {
            ProjectData.SetProjectError((Exception) ex);
            SqlException sqlException = ex;
            UltraListViewItem ultraListViewItem = new UltraListViewItem();
            ((UltraListViewItemBase) ultraListViewItem).Value = (object) $"Row {Conversions.ToString(this._currentRow)} - {sqlException.Message}";
            this.AddListItem(ultraListViewItem);
            ProjectData.ClearProjectError();
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            Exception exception = ex;
            UltraListViewItem ultraListViewItem = new UltraListViewItem();
            ((UltraListViewItemBase) ultraListViewItem).Value = (object) $"Row {Conversions.ToString(this._currentRow)} - {exception.Message}";
            this.AddListItem(ultraListViewItem);
            ProjectData.ClearProjectError();
          }
        }
        this.MoveProgress();
        // ISSUE: variable of a reference type
        int& local;
        // ISSUE: explicit reference operation
        int num2 = ^(local = ref this._currentRow) + 1;
        local = num2;
      }
    }
    finally
    {
      IEnumerator<Row> enumerator;
      enumerator?.Dispose();
    }
    this.spinner.Visible = false;
    if (!string.IsNullOrEmpty(this.ErrorSummary))
    {
      int num3 = (int) MessageBox.Show(this.ErrorSummary.ToString(), $"Imported {num1.ToString()} record(s) successfully", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else
    {
      if (worksheet.Cells.Rows.Count <= 1)
        return;
      int num4 = (int) MessageBox.Show($"Imported {num1.ToString()} record(s) successfully", "Successful Import", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
  }

  protected override string GetAddListItemSuccessString(
    int _currentRow,
    Row worksheetRow,
    string policyNumber)
  {
    string empty = string.Empty;
    return $"Successfully imported  {(string) this.GetMappedValue("Address1", worksheetRow, true)} ' - ' {(string) this.GetMappedValue("City", worksheetRow, true)} ',' {(string) this.GetMappedValue("State", worksheetRow, true)} ";
  }

  protected override void AddListItem(UltraListViewItem item)
  {
    if (!string.IsNullOrEmpty(this.ErrorSummary))
      return;
    if (this.InvokeRequired)
    {
      this.Invoke((Delegate) new FormLocationExcelImporterSub.AddListItemHandler(this.AddListItem), (object) item);
    }
    else
    {
      this.listImportStatus.Items.Add(item);
      this.listImportStatus.PerformAction((UltraListViewAction) 23);
    }
  }

  private bool InsertLocationRecord(Guid QuoteGuid, int QuoteOptionID, Row worksheetRow)
  {
    bool flag;
    if (this.CheckRequiredFields(worksheetRow))
    {
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
      flag = true;
    }
    else
      flag = false;
    return flag;
  }

  private bool CheckRequiredFields(Row worksheetRow)
  {
    this._errorSuffix = (string) null;
    object objectValue1 = RuntimeHelpers.GetObjectValue(this.GetMappedValue("LocationNo", worksheetRow, false));
    object objectValue2 = RuntimeHelpers.GetObjectValue(this.GetMappedValue("BuildingNo", worksheetRow, false));
    object objectValue3 = RuntimeHelpers.GetObjectValue(this.GetMappedValue("PhysicalBuildingNo", worksheetRow, false));
    object objectValue4 = RuntimeHelpers.GetObjectValue(this.GetMappedValue("Address1", worksheetRow, false));
    object objectValue5 = RuntimeHelpers.GetObjectValue(this.GetMappedValue("City", worksheetRow, false));
    object objectValue6 = RuntimeHelpers.GetObjectValue(this.GetMappedValue("State", worksheetRow, false));
    object objectValue7 = RuntimeHelpers.GetObjectValue(this.GetMappedValue("Zip", worksheetRow, false));
    object objectValue8 = RuntimeHelpers.GetObjectValue(this.GetMappedValue("SqFootage", worksheetRow, false));
    object objectValue9 = RuntimeHelpers.GetObjectValue(this.GetMappedValue("YearBuilt", worksheetRow, false));
    object objectValue10 = RuntimeHelpers.GetObjectValue(this.GetMappedValue("WiringYear", worksheetRow, false));
    object objectValue11 = RuntimeHelpers.GetObjectValue(this.GetMappedValue("RoofingYear", worksheetRow, false));
    object objectValue12 = RuntimeHelpers.GetObjectValue(this.GetMappedValue("PlumbingYear", worksheetRow, false));
    object objectValue13 = RuntimeHelpers.GetObjectValue(this.GetMappedValue("HeatingYear", worksheetRow, false));
    if (Information.IsNothing(RuntimeHelpers.GetObjectValue(objectValue1)))
      this._errorSuffix = "LocationNo";
    if (Information.IsNothing(RuntimeHelpers.GetObjectValue(objectValue2)))
      this._errorSuffix = !string.IsNullOrEmpty(this._errorSuffix) ? this._errorSuffix + ", BuildingNo " : "BuildingNo ";
    if (Information.IsNothing(RuntimeHelpers.GetObjectValue(objectValue3)))
      this._errorSuffix = !string.IsNullOrEmpty(this._errorSuffix) ? this._errorSuffix + ", PhysicalBuildingNo " : "PhysicalBuildingNo ";
    if (Information.IsNothing(RuntimeHelpers.GetObjectValue(objectValue4)) || string.IsNullOrEmpty(objectValue4 as string))
      this._errorSuffix = !string.IsNullOrEmpty(this._errorSuffix) ? this._errorSuffix + ", Address1 " : "Address1 ";
    if (Information.IsNothing(RuntimeHelpers.GetObjectValue(objectValue5)) || string.IsNullOrEmpty(objectValue5 as string))
      this._errorSuffix = !string.IsNullOrEmpty(this._errorSuffix) ? this._errorSuffix + ", City " : "City ";
    if (Information.IsNothing(RuntimeHelpers.GetObjectValue(objectValue6)) || string.IsNullOrEmpty(objectValue6 as string))
      this._errorSuffix = !string.IsNullOrEmpty(this._errorSuffix) ? this._errorSuffix + ", State " : "State ";
    if (Information.IsNothing(RuntimeHelpers.GetObjectValue(objectValue7)) || string.IsNullOrEmpty(objectValue7 as string))
    {
      this._errorSuffix = !string.IsNullOrEmpty(this._errorSuffix) ? this._errorSuffix + ", Zip " : "Zip ";
    }
    else
    {
      AddressChecker addressChecker = new AddressChecker();
      AppSettingsReader appSettingsReader = new AppSettingsReader();
      Address[] addressArray = (Address[]) null;
      bool flag = true;
      try
      {
        addressArray = addressChecker.ZipToLocality(objectValue7.ToString());
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        flag = false;
        ProjectData.ClearProjectError();
      }
      if (flag && (addressArray == null || addressArray.Length == 0))
        this._errorSuffix = !string.IsNullOrEmpty(this._errorSuffix) ? this._errorSuffix + ", Unknown Zip " : "Unknown Zip ";
    }
    if (string.IsNullOrEmpty(this._errorSuffix))
      this.DataValidationCheck(worksheetRow, RuntimeHelpers.GetObjectValue(objectValue1), RuntimeHelpers.GetObjectValue(objectValue8), RuntimeHelpers.GetObjectValue(objectValue9), RuntimeHelpers.GetObjectValue(objectValue10), RuntimeHelpers.GetObjectValue(objectValue11), RuntimeHelpers.GetObjectValue(objectValue12), RuntimeHelpers.GetObjectValue(objectValue13), RuntimeHelpers.GetObjectValue(objectValue6), RuntimeHelpers.GetObjectValue(objectValue7));
    bool flag1;
    if (!string.IsNullOrEmpty(this._errorSuffix))
    {
      this.ErrorSummary = $"{this.ErrorSummary}{$"Invalid mapping(s) on Row # {Conversions.ToString(worksheetRow.Index + 1)} - "}{this._errorSuffix}\r\n\r\n";
      flag1 = false;
    }
    else
      flag1 = true;
    return flag1;
  }

  private bool DataValidationCheck(
    Row worksheetRow,
    object objLocationNum,
    object objSqFt,
    object objYrBuilt,
    object objWireYr,
    object objRoofYr,
    object objPlumbYr,
    object objHeatingYr,
    object objState,
    object objZip)
  {
    int result;
    if (!int.TryParse(objLocationNum.ToString(), out result))
      this._errorSuffix = "'LocationNo' is numeric";
    if (!Information.IsNothing(RuntimeHelpers.GetObjectValue(objYrBuilt)) && !objYrBuilt.ToString().Equals(string.Empty) && !int.TryParse(objYrBuilt.ToString(), out result))
      this._errorSuffix = !string.IsNullOrEmpty(this._errorSuffix) ? this._errorSuffix + ", 'Year Built' is numeric " : "'Year Built' is numeric";
    if (!Information.IsNothing(RuntimeHelpers.GetObjectValue(objWireYr)) && !objWireYr.ToString().Equals(string.Empty) && !int.TryParse(objWireYr.ToString(), out result))
      this._errorSuffix = !string.IsNullOrEmpty(this._errorSuffix) ? this._errorSuffix + ", 'Wire Year' is numeric " : "'Wire Year' is numeric";
    if (!Information.IsNothing(RuntimeHelpers.GetObjectValue(objRoofYr)) && !objRoofYr.ToString().Equals(string.Empty) && !int.TryParse(objRoofYr.ToString(), out result))
      this._errorSuffix = !string.IsNullOrEmpty(this._errorSuffix) ? this._errorSuffix + ", 'Roof Year' is numeric " : "'Roof Year' is numeric";
    if (!Information.IsNothing(RuntimeHelpers.GetObjectValue(objPlumbYr)) && !objPlumbYr.ToString().Equals(string.Empty) && !int.TryParse(objPlumbYr.ToString(), out result))
      this._errorSuffix = !string.IsNullOrEmpty(this._errorSuffix) ? this._errorSuffix + ", 'Plumbing Year' is numeric " : "'Plumbing Year' is numeric";
    if (!Information.IsNothing(RuntimeHelpers.GetObjectValue(objHeatingYr)) && !objHeatingYr.ToString().Equals(string.Empty) && !int.TryParse(objHeatingYr.ToString(), out result))
      this._errorSuffix = !string.IsNullOrEmpty(this._errorSuffix) ? this._errorSuffix + ", 'Heating Year' is numeric " : "'Heating Year' is numeric";
    if (!Information.IsNothing(RuntimeHelpers.GetObjectValue(objState)) && objState.ToString().Replace(" ", string.Empty).Length > 2)
      this._errorSuffix = !string.IsNullOrEmpty(this._errorSuffix) ? this._errorSuffix + ", 'State' must be 2 characters " : "'State' must be 2 characters";
    if (!Information.IsNothing(RuntimeHelpers.GetObjectValue(objZip)) && objZip.ToString().Replace(" ", string.Empty).Length > 5)
      this._errorSuffix = !string.IsNullOrEmpty(this._errorSuffix) ? this._errorSuffix + ", 'Zip' must be 5 characters " : "'Zip' must be 5 characters";
    object objectValue1 = RuntimeHelpers.GetObjectValue(this.GetMappedValue("ConstructionID", worksheetRow, false));
    if (!Information.IsNothing(RuntimeHelpers.GetObjectValue(objectValue1)) && !int.TryParse(objectValue1.ToString(), out result))
      this._errorSuffix = !string.IsNullOrEmpty(this._errorSuffix) ? this._errorSuffix + ", 'ConstructionID' is numeric " : "'ConstructionID' is numeric";
    object objectValue2 = RuntimeHelpers.GetObjectValue(this.GetMappedValue("SprinklerTypeID", worksheetRow, false));
    if (!Information.IsNothing(RuntimeHelpers.GetObjectValue(objectValue2)) && !int.TryParse(objectValue2.ToString(), out result))
      this._errorSuffix = !string.IsNullOrEmpty(this._errorSuffix) ? this._errorSuffix + ", 'SprinklerTypeID' is numeric " : "'SprinklerTypeID' is numeric";
    bool flag;
    return flag;
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

  protected override void OnLoad(EventArgs e)
  {
    this.lblStatus.Text = "Importing Location Data..";
    this.Text = "Importing........";
  }

  private new delegate void AddListItemHandler(UltraListViewItem item);
}
