// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.CoverageExposure
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using System;
using System.Collections.Generic;

#nullable disable
namespace MGASystems.IMS.Policies;

public class CoverageExposure
{
  private string _mappingName;
  private string _imsTable;
  private string _imsColumn;
  private string _spreadsheetColumn;
  private string _coverageType;
  private int _coverageID;
  private Decimal _coverageLimit;
  private static List<CoverageExposure> _coverageMap = new List<CoverageExposure>();
  private static List<object> _propertyExposureList = new List<object>();

  public CoverageExposure()
  {
  }

  public CoverageExposure(CoverageExposure myCoverage)
  {
    this._mappingName = myCoverage.MappingName;
    this._imsTable = myCoverage.IMSTable;
    this._imsColumn = myCoverage.IMSColumn;
    this._spreadsheetColumn = myCoverage.SpreadsheetColumn;
    this._coverageType = myCoverage.CoverageType;
    this._coverageID = myCoverage.CoverageID;
  }

  public CoverageExposure(string mn, string imt, string imc, string sc, string ct, int ci)
  {
    this._mappingName = mn;
    this._imsTable = imt;
    this._imsColumn = imc;
    this._spreadsheetColumn = sc;
    this._coverageType = ct;
    this._coverageID = ci;
  }

  public string MappingName
  {
    get => this._mappingName;
    set => this._mappingName = value;
  }

  public string IMSTable
  {
    get => this._imsTable;
    set => this._imsTable = value;
  }

  public string IMSColumn
  {
    get => this._imsColumn;
    set => this._imsColumn = value;
  }

  public string SpreadsheetColumn
  {
    get => this._spreadsheetColumn;
    set => this._spreadsheetColumn = value;
  }

  public string CoverageType
  {
    get => this._coverageType;
    set => this._coverageType = value;
  }

  public int CoverageID
  {
    get => this._coverageID;
    set => this._coverageID = value;
  }

  public static List<object> PropertyExposureList
  {
    get => CoverageExposure._propertyExposureList;
    set => CoverageExposure._propertyExposureList = value;
  }

  public static List<CoverageExposure> CoverageMap
  {
    get => CoverageExposure._coverageMap;
    set => CoverageExposure._coverageMap = value;
  }
}
