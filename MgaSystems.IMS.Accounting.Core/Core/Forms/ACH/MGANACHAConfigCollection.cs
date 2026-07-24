// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.Forms.ACH.MGANACHAConfigCollection
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using ChoETL.NACHA;
using MGASystems.Data;
using System;
using System.Data;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.Forms.ACH;

public class MGANACHAConfigCollection : ChoNACHAConfiguration
{
  private string _orginatingCompanyID;
  private string _orginatingCompanyName;
  private string _destinationBankName;
  private string _destinationRoutingNumber;
  private string _fileName;
  private int _batchNumber;
  private string sprocName = "spFin_GetACHFileInformation";
  private string _destinationDestination;
  private string _destinationOrigin;
  private string _destinationName;
  private string _destinationOrginName;
  private string _originatingDFI;
  private string _bankAccNum;
  private string _RouteNum;
  private string _fullPathFileName;
  private string _entryServiceClass;
  private string _entryCompanyDescription;
  private string _entryTransactionServiceTypeCode;
  public ChoNACHAConfiguration MGANACHAConfig = new ChoNACHAConfiguration();

  public string MGAACHFileName => this._fileName;

  public string MGAACHFullPathFileName { get; set; }

  public int MGABatchNumber => this._batchNumber;

  public MGANACHAConfigCollection(int BankID, int ServiceCodeID)
  {
    this.LoadNACHABankInformation(BankID, "", ServiceCodeID);
  }

  public string MGAEntryClassCode { get; set; }

  public string MGACompanyEntryDescription { get; set; }

  public string MGACompanyID { get; set; }

  public string MGAServiceCodeType { get; set; }

  public uint MGABlockingFactor { get; set; }

  public string MGAOrginatingCompanyName { get; set; }

  public string MGAImmediateDestination { get; set; }

  public string MGADestinationOrigin { get; set; }

  public string MGADestinationName { get; set; }

  public string MGADestinationOrginName { get; private set; }

  public string MGAOriginatingDFI { get; private set; }

  public string MGABankAccNum { get; private set; }

  public string MGARoutingNumber { get; private set; }

  public MGANACHAConfigCollection(int BankID, string referenceCode, int ServiceCodeId)
  {
    this.LoadNACHABankInformation(BankID, this.ReferenceCode, ServiceCodeId);
  }

  internal static string SetACHServiceCodeType(int ServiceCodeId)
  {
    return DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "SELECT dbo.GetACHServiceType(@ACHServiceCodeId)", new object[2]
    {
      (object) "@ACHServiceCodeId",
      (object) ServiceCodeId
    });
  }

  private void LoadNACHABankInformation(int BankID, string _referenceCode, int ServiceCodeId)
  {
    using (DataTable dataTable = DefaultDatabase.ExecuteDataTable(CommandType.StoredProcedure, this.sprocName, 0, (CommandArgumentType) 0, new object[2]
    {
      (object) "@GLAcctID",
      (object) BankID
    }))
    {
      if (dataTable == null || dataTable.Rows.Count == 0)
        return;
      foreach (DataRow row in (InternalDataCollectionBase) dataTable.Rows)
      {
        this.MGACompanyID = row["ACHCompanyID"].ToString().Trim();
        this.MGAOrginatingCompanyName = row["ACHCompanyName"].ToString().ToUpper().Trim();
        this.MGAImmediateDestination = row["ImmediateDestination"].ToString().Trim();
        this.MGADestinationOrigin = row["ImmediateOrigin"].ToString().Trim();
        this.MGADestinationName = row["ImmediateDestName"].ToString().ToUpper().Trim();
        this.MGADestinationOrginName = row["ImmediateOrginName"].ToString().ToUpper().Trim();
        this.MGAOriginatingDFI = row["OriginatingDFI"].ToString().Trim();
        this.MGABankAccNum = row["BankAcctNum"].ToString().Trim();
        this.MGARoutingNumber = row["ABARouteNum"].ToString().Trim();
      }
    }
    this._batchNumber = this.GetUniqueBatchNumber();
    this.MGAServiceCodeType = MGANACHAConfigCollection.SetACHServiceCodeType(ServiceCodeId);
    this._fileName = $"ACH_{this.MGAOrginatingCompanyName}_{DateTime.Now.ToString("mm_dd_yyyy_hh_mm")}.txt";
    this.SetMGANACHConfiguration(_referenceCode);
  }

  private void SetMGANACHConfiguration(string _referenceCode)
  {
    this.MGANACHAConfig.OriginatingCompanyId = this.MGADestinationOrigin;
    this.MGANACHAConfig.OriginatingCompanyName = this.MGAOrginatingCompanyName;
    this.MGANACHAConfig.DestinationBankName = this.MGADestinationName;
    this.MGANACHAConfig.DestinationBankRoutingNumber = " " + this.MGAImmediateDestination;
    this.MGANACHAConfig.BatchNumber = Convert.ToUInt32(this._batchNumber);
    if (string.IsNullOrEmpty(_referenceCode))
      this.MGANACHAConfig.ReferenceCode = "Internal Use Only   ";
    else
      this.MGANACHAConfig.ReferenceCode = _referenceCode;
  }

  private int GetUniqueBatchNumber()
  {
    return (int) DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT dbo.CalcNextACHBatchID()");
  }
}
